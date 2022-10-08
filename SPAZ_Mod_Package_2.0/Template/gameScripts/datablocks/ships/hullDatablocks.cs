//Hull Datablocks
//The hull datablock defines what will fit in the ship.
/*
//For size comparisons
$HULLTYPE_TINY       = 0;
$HULLTYPE_SMALL      = 1;  //also defined in hullDatablocks.cs
$HULLTYPE_MEDIUM     = 2;
$HULLTYPE_LARGE      = 3;
$HULLTYPE_HUGE       = 4;
$HULLTYPE_MOTHERSHIP = 5;
$HULLTYPE_STATION    = 6;
$HULLSIZE_COUNT = 7;
*/

$HULL_SIZETEXT[$HULLTYPE_TINY]       = "Tiny";
$HULL_SIZETEXT[$HULLTYPE_SMALL]      = "Small";
$HULL_SIZETEXT[$HULLTYPE_MEDIUM]     = "Medium";
$HULL_SIZETEXT[$HULLTYPE_LARGE]      = "Large";
$HULL_SIZETEXT[$HULLTYPE_HUGE]       = "Huge";
$HULL_SIZETEXT[$HULLTYPE_MOTHERSHIP] = "Mothership";
$HULL_SIZETEXT[$HULLTYPE_STATION]    = "Space Station";


$HULL_BASEMASS[$HULLTYPE_TINY]       = 4;
$HULL_BASEMASS[$HULLTYPE_SMALL]      = 5;
$HULL_BASEMASS[$HULLTYPE_MEDIUM]     = 25;
$HULL_BASEMASS[$HULLTYPE_LARGE]      = 125;
$HULL_BASEMASS[$HULLTYPE_HUGE]       = 625;
$HULL_BASEMASS[$HULLTYPE_MOTHERSHIP] = 3125;
$HULL_BASEMASS[$HULLTYPE_STATION]    = 3125;

$HULL_BASEHEALTH[$HULLTYPE_TINY]       = 30;
$HULL_BASEHEALTH[$HULLTYPE_SMALL]      = 45;
$HULL_BASEHEALTH[$HULLTYPE_MEDIUM]     = 80;
$HULL_BASEHEALTH[$HULLTYPE_LARGE]      = 150;
$HULL_BASEHEALTH[$HULLTYPE_HUGE]       = 300;
$HULL_BASEHEALTH[$HULLTYPE_MOTHERSHIP] = 500;
$HULL_BASEHEALTH[$HULLTYPE_STATION]    = 750;

$HULL_BASECREW[$HULLTYPE_TINY]       = 2;
$HULL_BASECREW[$HULLTYPE_SMALL]      = 5;
$HULL_BASECREW[$HULLTYPE_MEDIUM]     = 10;
$HULL_BASECREW[$HULLTYPE_LARGE]      = 25;
$HULL_BASECREW[$HULLTYPE_HUGE]       = 50;
$HULL_BASECREW[$HULLTYPE_MOTHERSHIP] = 50;
$HULL_BASECREW[$HULLTYPE_STATION]    = 100;

$HULL_BASECARGO[$HULLTYPE_TINY]       = 2;
$HULL_BASECARGO[$HULLTYPE_SMALL]      = 10;
$HULL_BASECARGO[$HULLTYPE_MEDIUM]     = 50;
$HULL_BASECARGO[$HULLTYPE_LARGE]      = 200;
$HULL_BASECARGO[$HULLTYPE_HUGE]       = 1000;
$HULL_BASECARGO[$HULLTYPE_MOTHERSHIP] = 0;
$HULL_BASECARGO[$HULLTYPE_STATION]    = 2000;

//Mass Multiplier IDs
$MULT_LOWEST   = 0.500;//careful with this
$MULT_VERYLOW  = 0.667;
$MULT_LOW      = 0.800;
$MULT_AVERAGE  = 1.000;
$MULT_HIGH     = 1.250;
$MULT_VERYHIGH = 1.500;
$MULT_HIGHEST  = 2.000; //careful with this

$MULT_CARGOCARRIER = 5.0; //super carge vessel mult



$HULL_DATABASE_INITIALIZED = false;
function Hull_CreateHullDatabases()
{
   for ( %shipType = $HULLTYPE_TINY; %shipType < $HULLSIZE_COUNT; %shipType++ )
   {
      $HULL_DATABASE[%shipType] = new SimSet() {}; //for ALL entries
      
      for ( %factionIndex = 0; %factionIndex < $FactionCount; %factionIndex++ )
      {
         %currentFaction = $Faction_Lookup[%factionIndex];
         if ( %currentFaction $= "Zombie" )
         {
            $HULL_DATABASE[%shipType, "Zombie"] = new SimSet("HULL_DB_"@%shipType@"_"@"Zombie") {};  
            $HULL_DATABASE[%shipType, "ZombieKiller"] = new SimSet("HULL_DB_"@%shipType@"_"@"ZombieKiller") {};              
         }
         else
            $HULL_DATABASE[%shipType, %currentFaction] = new SimSet("HULL_DB_"@%shipType@"_"@%currentFaction) {};      //given a name so i can find it is code.        
      }      
   }     
   $HULL_DATABASE_INITIALIZED = true;
}


function GetHullDatabase(%hullType)
{
   return $HULL_DATABASE[%hullType];
}

function GetFactionHullDatabase(%hullType, %faction)
{
   return $HULL_DATABASE[%hullType, %faction];
}


function GetRandomHullDesign(%hullType)
{
   %hullDB = GetHullDatabase(%hullType);
   %randomHull = %hullDB.GetObject(getRandom(0, %hullDB.getCount() - 1));
   %hullDesigns = GetHullDesigns(%randomHull.getName());
   %randomDesign = %hullDesigns.GetObject(getRandom(0, %hullDesigns.getCount() - 1));
   return %randomDesign;
}


function GetHullDesigns(%hullName)
{
   return $HULL_DESIGNS[%hullName];
}

//TODO: add a remove
function AddHullDesign(%shipDesignDatablock)
{
   %database = GetHullDesigns(%shipDesignDatablock.shipHull);
   %database.Add(%shipDesignDatablock);   
}

function HullDatablock::OnAdd(%this)
{   
   %name = %this.getName();
   //Tried to set a class on the datablocks and override the on Add for them, but for some reason they are not getting called.  
   if( %name $= "HullBase" || %name $= "HullTiny" || %name $= "HullSmall" || %name $= "HullMedium" || %name $= "HullLarge" || %name $= "HullHuge" || %name $= "HullMothership" || %name $= "HullStation" || %name $= "HullTurret")
      return;
      
   //bah, maybe i should have left in the include in database flag. 
   if( %name $= "HullTiny_zombie" || %name $= "HullSmall_zombie" || %name $= "HullMedium_zombie" || %name $= "HullLarge_zombie" || %name $= "HullHuge_zombie" || %name $= "HullMothership_zombie" || %name $= "HullStation_zombie")
      return;
      
   Parent::OnAdd(%this);
   
   if ( !%this.doNotAddToDatabase )
   {     
      if ( !$HULL_DATABASE_INITIALIZED )
         Hull_CreateHullDatabases();
      

      $HULL_DATABASE[%this.hullType].add(%this);
      for ( %factionIndex = 0; %factionIndex < $FactionCount; %factionIndex++ )
      {
         %currentFaction = $Faction_Lookup[%factionIndex];
         if ( %currentFaction $= "Zombie" )
         {  //we do not add zombie killers.  we dont want em hatching out of eggs
            if ( %this.factionImageMap_[%currentFaction] !$= "" )
            {
               if (  %this.hullDescriptionBits & $SST_HULL_ZOMBIE )      
                  $HULL_DATABASE[%this.hullType, "Zombie"].add(%this);  
               else
                  $HULL_DATABASE[%this.hullType, "ZombieKiller"].add(%this);
            }
         }
         else
         {
            if ( %this.factionImageMap_[%currentFaction] !$= "" )      
               $HULL_DATABASE[%this.hullType, %currentFaction].add(%this);             
         }
      } 
      
      
      %hullName = %this.getName();
      $HULL_DESIGNS[%hullName] = new SimSet() {};
   }
   
   
   %this.subExplosionDatablockWL  = createEfficientWeightedList(%this.subExplosionDatablockWL);   

   //COMPARATIVE MASS
   if ( %this.comparativeMass $= "" )
      %this.comparativeMass = $MULT_AVERAGE;
    
   //Also good to be used by engines for base mass calc. 
   %this.componentMass = %this.comparativeMass * $HULL_BASEMASS[%this.hullType];
   
   //COMPARATIVE HEALTH
   if ( %this.comparativeHealth $= "" )
      %this.comparativeHealth = $MULT_AVERAGE;
   
   if ( %this.comparativeHealth >= 0 )
   {
      %this.maxComponentHealth = %this.comparativeHealth * $HULL_BASEHEALTH[%this.hullType];
      %this.maxComponentHealth *= 2; //globally increasing all hull health now.
      if ( %this.hullDescriptionBits == $SST_HULL_ZOMBIE )
      {         
         if ( %this.hullType == $HULLTYPE_STATION )
            %this.maxComponentHealth *= 2; //since cannot move (was 5 but zombies strong)
         else
            %this.maxComponentHealth *= 1.5;
      }
   }
   
   //COMPARATIVE CREW
   if ( %this.comparativeCrew $= "" )
      %this.comparativeCrew = $MULT_AVERAGE;
   
   if ( %this.comparativeCrew >= 0 )  //avoid messing with beacons
      %this.maxCrewSize = %this.comparativeCrew * $HULL_BASECREW[%this.hullType];
   
   //COMPARATIVE CARGO
   if ( %this.comparativeCargo $= "" )
      %this.comparativeCargo = $MULT_AVERAGE;
   
   if ( %this.comparativeCargo >= 0 )  //avoid messing with beacons
      %this.hullCargoSpace = %this.comparativeCargo * $HULL_BASECARGO[%this.hullType];

   
   //If zombie, mult by 2 for health hullDescriptionBits = ;
}


      
function HullDatablock::getFactionImageMap(%this, %factionName)
{
   %factionImageMap = %this.factionImageMap_[%factionName];
   if ( %factionImageMap $= "" )
      %factionImageMap = %this.factionImageMap_Default;  
   return %factionImageMap;
}

$HullThreat[$HULLTYPE_TINY]       = 1;
$HullThreat[$HULLTYPE_SMALL]      = 3;
$HullThreat[$HULLTYPE_MEDIUM]     = 10;
$HullThreat[$HULLTYPE_LARGE]      = 30;
$HullThreat[$HULLTYPE_HUGE]       = 100;
$HullThreat[$HULLTYPE_MOTHERSHIP] = 100; //mothership level 2
$HullThreat[$HULLTYPE_STATION]    = 50; //assume a station level 2.

$ThreatMult_VeryLow = 0.333;
$ThreatMult_Low = 0.667;
$ThreatMult_Normal = 1.000;
$ThreatMult_High = 1.500;
$ThreatMult_VeryHigh = 3.000;

function HullDatablock::GetHullThreat(%this)
{
   %baseThreat = $HullThreat[%this.hullType];
   %threatMult = %this.threatMult;
   %realThreat = %baseThreat * %threatMult;
   return %realThreat;  
}


//This is basic data, and cannot be used for construction of a ship. 
datablock HullDatablock(HullBase : ComponentBase)
{
   frame = "0";
   canSaveDynamicFields = "1";    
   imageMap = "whitePixelImageMap";   
   hullIconImageMap = "ShipDisplay_hullImageMap";  
  
   hullDescriptionBits = $SST_HULL_MILITARY;  //default everything to military
   
   componentType        = "Hull";  //identifier for the component system
  
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 0;
     
   hullDamageModifier_Default     = "1";   
   hullDamageModifier_Explosive   = "3";//explosives breaks stuff
   hullDamageModifier_Projectile  = "0.500"; //projectiles just swiss cheese
   hullDamageModifier_Energy      = "1.0"; //lasers just swiss cheese
   hullDamageModifier_Ion         = "0.25";
   hullDamageModifier_Corrosive   = "1"; //burn that hull
   hullDamageModifier_Zombify     = "0.1"; //dont wanna destroy hull, wanna convert it.  
   
   
   hullDamageAbsorbtion           = "0.75";  //NOTE: THIS DOES NOTHING: BUT REMOVE AND DEBUG BUILD DIES!!!!
   
         
   hullHitEffect                  = "hullImpact";   
   hullHitEffectScale             = "1";
   hullHitSound                   = "snd_hullHit";   
      
   //for killer ships.  will use this 50% of the time.
   hullHitEffect_Killer           = "hullImpact_zombie";   
   hullHitEffectScale_Killer      = "1";
   hullHitSound_Killer            = "snd_hullHit_zombie";   
   
   explosionScale        = "1";  
    
   hullArmorSpace        = $SLOT_SMALL;  
   
   disabilityEffectDatablock   = "ReactorCritical";     
   disabilityEffectMaxScale    = "0.5";
   
   maxCrewSize           = 2;
   
   largeEscapePodChance  = 0;
   
   hullBaseDamageMult = 1.0;  //research increases this. 
      
   researchDatablock = "HullResearch";
   miniHudIcon = "ShipDisplay_hull_smallImageMap";
   
   breachThresholds["Minor"] = "0.75 0.5";
   breachThresholds["Major"] = "0.25";
      
   //breachLink_# offsetX offsetY rotation BreachSet
   //breachLinks["Minor", 1] = "0.25 -0.8 0 BreachSet_Small";
   //breachLinks["Minor", 2] = "-0.25 -0.8 0 BreachSet_Small";
   //breachLinks["Minor", 3] = "0 0 0 BreachSet_Small";
   
   //breachLinks["Major", 1] = "0 0.8 0 BreachSet_Small";
   //breachLinks["Major", 2] = "-0.5 0.8 0 BreachSet_Small";
   //breachLinks["Major", 3] = "-0.5 0.8 0 BreachSet_Small";
   
   hasWhiteFlash = false;
   hasShockwave = false;
   explosionCascadeMulti = 1;
   canBeInvaded = true;
   debrisCluster_Light = "DC_Combat_Small_Light";  
   debrisCluster_Heavy = "DC_Combat_Small_Heavy";  
   
   //only for zombies.  Places here for now for testing
   embryoImage = "bigfoot_embryoImageMap";
   embryoInfo[0] = "0 1 0 ZombieEggBase";  //offsetx, offsety maxEmbryo level (can have many link points) and the egg datablock
   
   //this is only for zombie ships, but easiest to define here
   breeding_maxRange     = 5000;  //Max travel dist from birthplace.  Will turn back once reach the border.
   breeding_nestDistance = "1500 2000";  //distance between nests (weighted pair)
   breeding_nestSize     = -1; //Size of the nest itself, i will only count eggs dropped inside nest, size < 0 = everywhere is the nest
   breeding_eggsPerNest  = -1;  //once this many eggs spawned, a new nest site it picked. is < 0, will never pick a new site 
   breeding_totalEggs    = -1;  //if >= 0 we will only spawn that many eggs in our life, else we do infinite
    
   subExplosionDatablockWL  = "BigExplosion 10 MediumExplosion 50";  
   subExplosionSoundWL      = "snd_mediumExplosion 100 snd_smallExplosion_cascade 5";
   subExplosionScale        = 1;
      
   //wreckageData offsetX offsetY Rotation (usually 0)
   wreckageData[0] = "";  //"ShipWreck_HammerHead_Left -0.5 0 0";
   
   hullTypeXPMult = 1.0; //This allows us to vary the data awarded for destroying a hull within its size class. 
   
   starLevelUnlock = 0;  //always unlocked.  this is the star tech level where the ship will begin to appear.
   //Over time the early unlockers will become more rare. 


   //Invasion effects will scale quantity based on invasion level
   //Invasion effects should be infinite they will be turned on and off and scaled. 
   invasionEffect_Zombie = "shipcombat_human";
   invasionEffect_Terran  = "shipcombat_human";  //Need something themed. 
   invasionEffect_Civ  = "shipcombat_human";
   invasionEffect_Pirate  = "shipcombat_human";
   
   //This scales size.  Invasion level will scale quantity.  
   //Quantity scale will max out at 1, so that should be the setting for a massive invaded ship.
   //1 Will be scale when the invaders = max possible crew on a ship. 
   //Zombies maaay scale over 1, but only to about 1.4 max in special curcumstances, so assume 1 is max. 
   invasionEffectScale_Zombie = 1.0;
   invasionEffectScale_Terran  = 1.0;
   invasionEffectScale_Civ  = 1.0;
   invasionEffectScale_Pirate  = 1.0;
   
   //WORKS SAME AS PROJECTILES> 
   //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   invasionEffectStartBlend_Zombie = "1 1 1 0";  //alpha value is ignored works like projectiles. 
   invasionEffectEndBlend_Zombie   = "1 0.333 1 0";
   
   invasionEffectStartBlend_Terran = "1 1 1 0";
   invasionEffectEndBlend_Terran   = "1 0 0 0";
   
   invasionEffectStartBlend_Civ = "1 1 1 0";
   invasionEffectEndBlend_Civ   = "0 1 0 0";
   
   invasionEffectStartBlend_Pirate = "1 1 1 0";
   invasionEffectEndBlend_Pirate   = "0 0.5 1 0";  
   
   
   //Burst spawning: (only for zombie ships, when they reach population cap, they release zombies like dandilions)
   burstSpawnEffect = "zombieEggHatchSmall";
   burstSpawnEffectScale = 1;
   burstSpawnEffectSound = "snd_eggHatchSmall"; 
   burstSpawnDebris = "DC_Combat_Small_Light_Zombie";
   
   //For zombie ships.  some ships we may want to tweak this like for end bosses etc..
   minEggLayHealthPercent = 0.500;
   minEggGrowHealthPercent = 0.500; 
   
   threatMult = $ThreatMult_Normal;
   
   massEffect = "gravSlowEffect";
   massEffectBaseScale = 1.0; //this is the scale of the effect when artificial mass == ship mass. 
   //base scale should be slightly smaller than ship.  scale mults from 0 - 3

   blossomRangeMult = 1.0;
   doNotAddToDatabase = false;
   
   isTurretHull = false;
   
};

//////////////////////////////////////////////////////////////
// Hull Breach Stuff /////////////////////////////////////////
//////////////////////////////////////////////////////////////

 //breachLink_# offsetX offsetY rotation BreachSet
$HB_OffsetX   = 0;
$HB_OffsetY   = 1;
$HB_Rotation  = 2;
$HB_BreachSet = 3;
 
function HullDatablock::GetMaxSpawnedBreaches(%this, %breachType)
{
   return getWordCount(%this.GetBreachThresholds(%breachType));   
}

function HullDatablock::GetBreachThresholds(%this, %breachType)
{
   return %this.breachThresholds[%breachType];   
}


function HullDatablock::GetUniqueBreachIndex(%this, %breachType, %excludedIndexes)
{
   %maxIndex = %this.GetMaxBreachIndex(%breachType);
   %numExcluded = getWordCount(%excludedIndexes);
   if ( %numExcluded == %maxIndex )
      return ""; //none unique left to pick from
   
   %availableIndexes = "";
   for ( %allowedIndex = 1; %allowedIndex <= %maxIndex; %allowedIndex++ )
   {
      %shouldAllowIndex = true;
      for ( %i = 0; %i < getWordCount(%excludedIndexes); %i++ )
      {
         %currentExcludedIndex = getWord(%excludedIndexes, %i);
         if ( %currentExcludedIndex == %allowedIndex )
         {
            %shouldAllowIndex = false;
            break;
         }
      }
      if ( %shouldAllowIndex )
         %availableIndexes = %availableIndexes @ %allowedIndex @ " ";      
   }
   
   %randomIndex = getRandomWord(%availableIndexes);
   return %randomIndex;  
}

function HullDatablock::GetMaxBreachIndex(%this, %breachType)
{
   if ( %this.maxBreachIndex[%breachType] !$= "" )
      return %this.maxBreachIndex[%breachType];
      
   %index = 1;
   %currentBreachInfo = %this.breachLinks[%breachType, %index];
   while ( %currentBreachInfo !$= "" )
   {
      %index++;
      %currentBreachInfo = %this.breachLinks[%breachType, %index];
   }     
   %this.maxBreachIndex[%breachType] = %index - 1;  
   return %this.maxBreachIndex[%breachType];
}


function HullDatablock::GetBreachData(%this, %breachType, %breachIndex)
{
   return %this.breachLinks[%breachType, %breachIndex];
   
   
}



///////////////////////////////
// Root Design /////////////////
///////////////////////////////


function HullDatablock::GetRootDesign(%this)
{
   %rootDesign = %this.rootDesign;
   if ( !isObject(%rootDesign))
      echo("WARNING: Missing Root Design!" SPC %this.getName());
      
   return %rootDesign;   
}










