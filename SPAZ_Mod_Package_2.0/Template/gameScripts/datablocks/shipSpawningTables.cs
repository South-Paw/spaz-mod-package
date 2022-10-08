//This system leta us ask for a "large" ship and what that actually means at different times in the game
//changes.  this will keep everything nice and consistent.

//Ships will automaticallly add themselves to this list.  
//We register by hull types.  There may be multiple designs within that type. 
//Each hull type will have a set of factions it is valid for.
//We test this by checking for faction based art. 





$SST_MaxLevels = 10; //we divide the ships into this many increments or decks.
$SST_LevelIncrement = $MaxLevel / $SST_MaxLevels;  //will be 10; here mosrlty for clarity. 
//So we have 10 levels at ten point ranges. 

$SST_INIT = false;
function SST_InitShipSpawningDatabase()
{
   if ( $SST_INIT )
      return;  //only need to do once
      
   for ( %factionIndex = 0; %factionIndex <= $FactionCount; %factionIndex++ )
   {
      if ( %factionIndex == $FactionCount )
         %currentFaction = "ZombieKiller"; //add a special database for these. 
      else
         %currentFaction = $Faction_Lookup[%factionIndex];      
      
      for ( %shipType = $HULLTYPE_TINY; %shipType <= $HULLTYPE_HUGE; %shipType++ )
      {        
         for ( %levelIndex = 0; %levelIndex <= $SST_MaxLevels; %levelIndex++ )
         {
            SST_AddDatabaseEntry(%shipType, %currentFaction, %levelIndex);            
         }        
      }      
   }   
   $SST_INIT = true;
}



function SST_AddDatabaseEntry(%shipType, %currentFaction, %levelIndex)
{
   %hullDatabase = GetFactionHullDatabase(%shipType, %currentFaction);
   
   %entryCount = %hullDatabase.getCount();
   %databaseEntry = "";

   
   //Note: dont forget to add all sub designs. 
   for ( %i = 0; %i < %hullDatabase.getCount(); %i++ )
   {
      %currentHullObject = %hullDatabase.getObject(%i);      
      
      %starLevelUnlock = %currentHullObject.starLevelUnlock;
      if ( %starLevelUnlock > %levelIndex )
         continue;  //this hull is not yet unlocked. 
            
      %shipDesignDatabase = GetHullDesigns(%currentHullObject.getName());
      for ( %j = 0; %j < %shipDesignDatabase.getCount(); %j++ )
      {        
         %shipDesignDatablock = %shipDesignDatabase.getObject(%j);
         %unlockLevel = SST_CalculateUnlockLevel(%shipDesignDatablock);
         if ( %unlockLevel > %levelIndex )
            continue;
            
         %unlockWeight = SST_CalculateUnlockWeight(%shipDesignDatablock, %levelIndex);
         if ( %unlockWeight <= 0 )
            continue;           
           
         %databaseEntry = %databaseEntry @ %shipDesignDatablock.getID() SPC %unlockWeight @ " ";         
      }      
   }
   
   //echo("SST:" SPC %currentFaction SPC "ShipType" SPC %shipType SPC "Level:" SPC %levelIndex SPC %databaseEntry);    
      
   %databaseEntry = createEfficientWeightedList(%databaseEntry); 
      
   if ( %databaseEntry $= "" && %shipType == 0 ) //since we downgrade shiptype if cannot find, we only need to worry if there are none at 0
      echo("Warning! Cannot find ship for SST: Faction:" SPC %currentFaction SPC "ShipType:" SPC %shipType SPC "LevelIndex:" SPC %levelIndex);
      
   $SST_DB[%currentFaction, %shipType, %levelIndex] = %databaseEntry;
}

function SST_CalculateUnlockLevel(%shipDesignDatablock)
{
   %starLevelUnlock = %shipDesignDatablock.shipHull.starLevelUnlock;
   %designDescription = %shipDesignDatablock.designDescriptionBits;
   //We use designBitMatching in SST_GetRandomShipFromDatabaseEntry to get what we want.
   //$SST_DESIGN_CIV $SST_DESIGN_BASIC $SST_DESIGN_IMPROVED $SST_DESIGN_ADVANCED
   //Improved should become available 1 level after the basic design, and advanced, 2 levels. 
   %unlockLevel = %starLevelUnlock;
   if ( %designDescription == $SST_DESIGN_IMPROVED )
   {
      %unlockLevel += 1;
      if ( %unlockLevel < 3 )  
         %unlockLevel = 3; //prevent improved tech too early.
   }
   if ( %designDescription == $SST_DESIGN_ADVANCED )
   {
      %unlockLevel += 2;
      if ( %unlockLevel < 5 )  
         %unlockLevel = 5; //prevent improved tech too early.
   }
   if ( %unlockLevel > $SST_MaxLevels )
      echo("WARNING!: Ship Design unlock level too high! (improved = +1 advanced = +2)" SPC %shipDesignDatablock.getName());

   return %unlockLevel;  
}



function SST_CalculateUnlockWeight(%shipDesignDatablock, %levelIndex)
{
   %designDescription = %shipDesignDatablock.designDescriptionBits;
   
   %isZombie = %shipDesignDatablock.shipHull.hullDescriptionBits & $SST_HULL_ZOMBIE; //does not count ZombieKillers on purpose. 
   if ( %levelIndex == 0 && %designDescription != $SST_DESIGN_CIV && !%isZombie)
      return 0;
      
   if ( !BH_Allowed() && %shipDesignDatablock.shipHull.factionImageMap_Bounty !$= "" )
      return 0;
      
   if ( %designDescription == $SST_DESIGN_CIV )
   {
      if ( %levelIndex >= 2 ) //level 15+ = no more civ designs.
         return 0; //no more civ designs
         
      if ( %levelIndex == 1 )
         return 33;
         
      return 66;      
   }
   else
   {         
      if ( %levelIndex == 0 )
         return 33; //Will only trigger on ZombieKiller ships
         
      if ( %levelIndex == 1 )
         return 66; //less likley than civ designs. 
      
             
      %unlockLevel = SST_CalculateUnlockLevel(%shipDesignDatablock);
      //%unlockWeight = mFloor((mSqrt(%unlockLevel) + 5) * 10);      
      
      //Need better alg to make sure newer stuff shows up better.
      %unlockWeight = mPow(%unlockLevel + 3, 2) * 5;       
      
      return %unlockWeight; 
   }
}


function SST_GetDatabaseEntry(%currentFaction, %shipType, %realLevel)
{
   %level = SST_ConvertRealLevelToSSTLevel(%realLevel);
   return $SST_DB[%currentFaction, %shipType, %level];   
}


function SST_GetRandomShipDatablock(%faction, %shipDescription, %realLevel, %allowSizeDegrade, %hullBitMatching, %designBitMatching, %deviceBitMatching)
{   
   if ( %realLevel $= "" )
      %realLevel = GetCurrentInstance().getTechLevel();   
      
   %shipType = SST_ConvertShipDescToShipType(%shipDescription, %realLevel);       
   return SST_GetRandomShipDatablock_ByType(%faction, %shipType, %realLevel, %allowSizeDegrade, %hullBitMatching, %designBitMatching, %deviceBitMatching);
}

//Private for warp gates, dont use. 
function SST_GetRandomShipDatablock_ByType(%faction, %shipType, %realLevel, %allowSizeDegrade, %hullBitMatching, %designBitMatching, %deviceBitMatching)
{      
   if ( IDG() && %shipType >= $HULLTYPE_LARGE )
      %shipType = $HULLTYPE_MEDIUM; //prevent larges.
      
   %databaseEntry = SST_GetDatabaseEntry(%faction, %shipType, %realLevel);
   if ( %databaseEntry $= "" && !%allowSizeDegrade )
      return "";  
   
   while ( %databaseEntry $= "" && %shipType >= 0 )
   {
      %shipType--;  //ok no ships of this size at this level, try a smaller ship size instead. (Should rarely happen if ever)
      //echo("SST_Cannot Find Ship:" SPC %faction SPC %shipType SPC %realLevel SPC "Downgrading ship size");
      
      %databaseEntry = SST_GetDatabaseEntry(%faction, %shipType, %realLevel);
   }
   SAssert( %databaseEntry !$= "", "SST_SpawnShip could not find valid entry", %faction, %shipType, %level); 
          
   %shipDatablock = SST_GetRandomShipFromDatabaseEntry(%faction, %databaseEntry, %hullBitMatching, %designBitMatching, %deviceBitMatching, %realLevel);   
   return %shipDatablock;  
}


$InfHullLookup["Mining"] = $SST_HULL_MINING;
$InfHullLookup["Colony"] = $SST_HULL_COLONY;
$InfHullLookup["Science"] = $SST_HULL_SCIENCE;
function SST_GetInfHullBit()
{
   %starInfraType = GetCurrentStar().GetStarType();
   %hullBit = $InfHullLookup[%starInfraType];
   if ( %hullBit $= "" )
   {
      echo("HULL BIT ERROR! SST_GetInfHullBit" SPC %starInfraType);
      %hullBit = $SST_HULL_MINING;
   }
   return %hullBit;
}

function SST_GetRandomShipFromDatabaseEntry(%faction, %databaseEntry, %hullBitMatching, %designBitMatching, %deviceBitMatching, %realLevel)
{
   if ( getWordCount(%databaseEntry) <= 1 )
      return %databaseEntry;
   
   if ( %hullBitMatching $= "" )  
      %hullBitMatching = $SST_HULL_ANY;
   
   if ( %hullBitMatching & $SST_HULL_INF )
      %hullBitMatching = %hullBitMatching | SST_GetInfHullBit();
      
   
   if ( %designBitMatching $= "" )
      %designBitMatching = $SST_DESIGN_ANY;
      
   if ( %deviceBitMatching $= "" )
      %deviceBitMatching = $SST_DEVICE_ANY;
            
   %levelIndex = SST_ConvertRealLevelToSSTLevel(%realLevel);
            
   %validShips = SST_FindValidShips(%databaseEntry, %hullBitMatching, %designBitMatching, %deviceBitMatching, %levelIndex);
   
   //Strip off device bits if we couldnt find anything.
   if ( %validShips $= "" && %deviceBitMatching != $SST_DEVICE_ANY)
   {
      %deviceBitMatching = $SST_DEVICE_ANY;
      %validShips = SST_FindValidShips(%databaseEntry, %hullBitMatching, %designBitMatching, %deviceBitMatching, %levelIndex);           
   } 
   
   //Strip off design bits if we couldnt find anything.
   if ( %validShips $= "" )
   {      
      %designBitMatching = $SST_DESIGN_BASIC;         
      %validShips = SST_FindValidShips(%databaseEntry, %hullBitMatching, %designBitMatching, %deviceBitMatching, %levelIndex);           
   } 
      
   if ( %validShips $= "" )
      %validShips = %databaseEntry;  //Couldnt find a valid entry so going old school
      
   %selectedParentDesign = getRandomWeightedWord(%validShips);    
   
   //Now we need to grab the sub design.
   
   %actualDesign = %selectedParentDesign.PickSubHullDesign();
   return %actualDesign;   
}

function SST_FindValidShips(%databaseEntry, %hullBitMatching, %designBitMatching, %deviceBitMatching, %levelIndex)
{
   %validShips = "";
   %initialIndex = 2; //in an efficient weighted list the first 2 elements are special
 
   for ( %i = %initialIndex; %i < getWordCount(%databaseEntry); %i+=2)
   {//First check for valid hull types. 
        %currentShipDesign = getWord(%databaseEntry, %i);
        %hull = %currentShipDesign.shipHull;
        %currentHullBits = %hull.hullDescriptionBits;
        if ( %currentHullBits $= "" || %currentHullBits & %hullBitMatching )
        {  //the hull is valid, so now lets check if the design is valid. 
            %currentDesignBits = %currentShipDesign.designDescriptionBits;
            if ( %currentDesignBits $= "" || %currentDesignBits & %designBitMatching)
            {//the design is valid.
               %currentDeviceBits = %currentShipDesign.deviceDescriptionBits;
               if ( %currentDeviceBits $= "" || %currentDeviceBits & %deviceBitMatching)
               {
                  //%unlockWeight = getWord(%databaseEntry, %i+1); //note: this is invalid since it is from an EWL so entries near the end will have cumulative weights!
                  %unlockWeight = SST_CalculateUnlockWeight(%currentShipDesign, %levelIndex);
                  if ( %unlockWeight <= 0 )
                     continue;    
                                    
                  %validShips = %validShips @ %currentShipDesign SPC %unlockWeight @ " ";
               }
            }        
        }
   }
   return %validShips;
}



//Most things should use this now. 
function SST_SpawnShip(%faction, %shipDescription, %position, %level)
{   
   %shipDatablock = SST_GetRandomShipDatablock(%faction, %shipDescription, %level, true);
          
   %ship = SpawnFactionShip(%faction, %shipDatablock, %position);
   return %ship;  
}



$SST_DESCRIPTIONS["Light", 0]  = createEfficientWeightedList($HULLTYPE_TINY);
$SST_DESCRIPTIONS["Light", 1]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 5);
$SST_DESCRIPTIONS["Light", 2]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 10);
$SST_DESCRIPTIONS["Light", 3]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 20);
$SST_DESCRIPTIONS["Light", 4]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 20 SPC $HULLTYPE_MEDIUM SPC 10);
$SST_DESCRIPTIONS["Light", 5]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 20 SPC $HULLTYPE_MEDIUM SPC 20);
$SST_DESCRIPTIONS["Light", 6]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 20 SPC $HULLTYPE_MEDIUM SPC 40);
$SST_DESCRIPTIONS["Light", 7]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 20 SPC $HULLTYPE_MEDIUM SPC 60);
$SST_DESCRIPTIONS["Light", 8]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 20 SPC $HULLTYPE_MEDIUM SPC 80);
$SST_DESCRIPTIONS["Light", 9]  = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 20 SPC $HULLTYPE_MEDIUM SPC 100);
$SST_DESCRIPTIONS["Light", 10] = createEfficientWeightedList($HULLTYPE_TINY SPC 10 SPC $HULLTYPE_SMALL SPC 20 SPC $HULLTYPE_MEDIUM SPC 120);


$SST_DESCRIPTIONS["Average", 0]  = createEfficientWeightedList($HULLTYPE_SMALL);
$SST_DESCRIPTIONS["Average", 1]  = createEfficientWeightedList($HULLTYPE_SMALL);
$SST_DESCRIPTIONS["Average", 2]  = createEfficientWeightedList($HULLTYPE_SMALL SPC 10 SPC $HULLTYPE_MEDIUM SPC 10);
$SST_DESCRIPTIONS["Average", 3]  = createEfficientWeightedList($HULLTYPE_SMALL SPC 10 SPC $HULLTYPE_MEDIUM SPC 20);
$SST_DESCRIPTIONS["Average", 4]  = createEfficientWeightedList($HULLTYPE_MEDIUM SPC 10 SPC $HULLTYPE_LARGE SPC 3);
$SST_DESCRIPTIONS["Average", 5]  = createEfficientWeightedList($HULLTYPE_MEDIUM SPC 10 SPC $HULLTYPE_LARGE SPC 7);
$SST_DESCRIPTIONS["Average", 6]  = createEfficientWeightedList($HULLTYPE_MEDIUM SPC 10 SPC $HULLTYPE_LARGE SPC 15);
$SST_DESCRIPTIONS["Average", 7]  = createEfficientWeightedList($HULLTYPE_MEDIUM SPC 10 SPC $HULLTYPE_LARGE SPC 30);
$SST_DESCRIPTIONS["Average", 8]  = createEfficientWeightedList($HULLTYPE_MEDIUM SPC 10 SPC $HULLTYPE_LARGE SPC 50);
$SST_DESCRIPTIONS["Average", 9]  = createEfficientWeightedList($HULLTYPE_MEDIUM SPC 10 SPC $HULLTYPE_LARGE SPC 80);
$SST_DESCRIPTIONS["Average", 10] = createEfficientWeightedList($HULLTYPE_LARGE);


$SST_DESCRIPTIONS["Heavy", 0]  = createEfficientWeightedList($HULLTYPE_MEDIUM);
$SST_DESCRIPTIONS["Heavy", 1]  = createEfficientWeightedList($HULLTYPE_MEDIUM);
$SST_DESCRIPTIONS["Heavy", 2]  = createEfficientWeightedList($HULLTYPE_MEDIUM SPC 10 SPC $HULLTYPE_LARGE SPC 10);
$SST_DESCRIPTIONS["Heavy", 3]  = createEfficientWeightedList($HULLTYPE_MEDIUM SPC 10 SPC $HULLTYPE_LARGE SPC 20);
$SST_DESCRIPTIONS["Heavy", 4]  = createEfficientWeightedList($HULLTYPE_LARGE);
$SST_DESCRIPTIONS["Heavy", 5]  = createEfficientWeightedList($HULLTYPE_LARGE SPC 10 SPC $HULLTYPE_HUGE SPC 5);
$SST_DESCRIPTIONS["Heavy", 6]  = createEfficientWeightedList($HULLTYPE_LARGE SPC 10 SPC $HULLTYPE_HUGE SPC 10);
$SST_DESCRIPTIONS["Heavy", 7]  = createEfficientWeightedList($HULLTYPE_LARGE SPC 10 SPC $HULLTYPE_HUGE SPC 20);
$SST_DESCRIPTIONS["Heavy", 8]  = createEfficientWeightedList($HULLTYPE_LARGE SPC 10 SPC $HULLTYPE_HUGE SPC 40);
$SST_DESCRIPTIONS["Heavy", 9]  = createEfficientWeightedList($HULLTYPE_LARGE SPC 10 SPC $HULLTYPE_HUGE SPC 80);
$SST_DESCRIPTIONS["Heavy", 10] = createEfficientWeightedList($HULLTYPE_HUGE);


$SST_SIZES["Tiny"]   = $HULLTYPE_TINY;
$SST_SIZES["Small"]  = $HULLTYPE_SMALL;
$SST_SIZES["Medium"] = $HULLTYPE_MEDIUM;
$SST_SIZES["Large"]  = $HULLTYPE_LARGE;
$SST_SIZES["Huge"]   = $HULLTYPE_HUGE;

$SST_SIZES[$HULLTYPE_TINY]   = $HULLTYPE_TINY;
$SST_SIZES[$HULLTYPE_SMALL]  = $HULLTYPE_SMALL;
$SST_SIZES[$HULLTYPE_MEDIUM] = $HULLTYPE_MEDIUM;
$SST_SIZES[$HULLTYPE_LARGE]  = $HULLTYPE_LARGE;
$SST_SIZES[$HULLTYPE_HUGE]   = $HULLTYPE_HUGE;

$SST_BOSSES[0]  = $HULLTYPE_MEDIUM;
$SST_BOSSES[1]  = $HULLTYPE_MEDIUM;
$SST_BOSSES[2]  = $HULLTYPE_LARGE;
$SST_BOSSES[3]  = $HULLTYPE_LARGE;
$SST_BOSSES[4]  = $HULLTYPE_LARGE;
$SST_BOSSES[5]  = $HULLTYPE_LARGE;
$SST_BOSSES[6]  = $HULLTYPE_HUGE;
$SST_BOSSES[7]  = $HULLTYPE_HUGE;
$SST_BOSSES[8]  = $HULLTYPE_HUGE;
$SST_BOSSES[9]  = $HULLTYPE_HUGE;
$SST_BOSSES[10] = $HULLTYPE_HUGE;

function GetSectorByLevel(%realLevel)
{
   if ( %realLevel == 1 )
      return 1;
      
   if ( %realLevel <= $OuterRingMax )
      return 2;
      
   return 3; //level 3 and 4 the same boss wise.   
}

function SST_ConvertRealLevelToSSTLevel(%realLevel)
{
   %level = %realLevel - 3; // need to make early levels a little easier.
   if ( %level < 0 )
      %level = 0;
      
   %level = mRound(%level / $SST_LevelIncrement); //convert 0 - 100, to 0 - 10
   %level = mClamp(%level, 0, $SST_MaxLevels);
   
   return %level;   
}

function SST_ConvertShipDescToShipType(%shipDescription, %realLevel)
{
   %level = SST_ConvertRealLevelToSSTLevel(%realLevel);
   
   %selectedType = $SST_SIZES[%shipDescription];
   if ( %selectedType !$= "" )
      return %selectedType;
   
   //Ok we want a morphing type,   
   %weightedList = $SST_DESCRIPTIONS[%shipDescription, %level];   
   if ( %weightedList !$= "" )
   {
      %selectedType = getRandomWeightedWord(%weightedList);
      return %selectedType;
   }
   
   if ( $FrontEndMode )
      return $HULLTYPE_MEDIUM;  //just in case
      
   //Must be asking for something very special like a boss.  
   %selectedType = $SST_BOSSES[%level];
   
   if ( %selectedType $= "" )
      echo("WARNING: SST_ConvertShipSizeToShipType cannot convert:" SPC %shipDescription SPC %level);
      
   return %selectedType;  
}

































