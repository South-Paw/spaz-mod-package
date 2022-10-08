////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Global Pickup Databse ///////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//$PickupDatabase = new SimSet() {};  //very odd.  i cannot assign a class here.  so doing it on the base class i guess. 

$PickupDatabase = new ScriptObject() 
{
   class = "PickupDatabase";
};


//Private
function PickupDatabase::GetPickupTypeDatabase(%this, %pickupDatablock)
{
   %pickupType = %pickupDatablock.codeClass;
   if ( %pickupType $= "Pickup" )
   {
      %pickupType =  %pickupDatablock.objectClass; 
      if ( %pickupType $= "" )
         %pickupType =  %pickupDatablock.objectSuperclass;       
   }
      
   %typeDatabase = %this.TypeDatabases[%pickupType]; 
   if ( !isObject(%typeDatabase) )
      %typeDatabase = %this.CreatePickupTypeDatabase(%pickupType);
      
   return %typeDatabase;   
}

//Private
function PickupDatabase::CreatePickupTypeDatabase(%this, %pickupType)
{   
   %database = CreatePickupTypeDatabase(%pickupType);
   %this.TypeDatabases[%pickupType] = %database;   
   return %database;
}



//Public
function GetPickupTypeDatabase(%pickupDatablock)
{   
   return $PickupDatabase.GetPickupTypeDatabase(%pickupDatablock);   
}

//Public
function AddPickupDatablock(%pickupDatablock)
{ 
   %typeDatabase = GetPickupTypeDatabase(%pickupDatablock);
   %typeDatabase.AddPickupDatablock(%pickupDatablock);      
}

//public
function GetSpawnValueTable(%pickupDatablockBase, %totalValue)
{
   %typeDatabase = GetPickupTypeDatabase(%pickupDatablockBase);
   return %typeDatabase.GetSpawnValueTable(%totalValue);   
}



////////////////////////////
// Pickup Registration /////
////////////////////////////

function PickupDatablock::OnAdd(%this)
{
   if ( %this.IsBaseDatablock() )
      return;  
      
   AddPickupDatablock(%this);   
}

function PickupDatablock::GetValue(%this)
{
   return %this.value;   
}

function PickupDatablock::IsBaseDatablock(%this)
{
   return %this.GetValue() < 0;  //base classes have a value < 0
}

////////////////////////////
// Type Database ///////////
////////////////////////////
function CreatePickupTypeDatabase(%pickupType)
{  
   %database = new ScriptObject() 
   {
      pickupType = %pickupType;
      class = "PickupTypeDatabase";   
      valueTable = "";      
   };
   
   return %database;   
}


function PickupTypeDatabase::AddPickupDatablock(%this, %pickupDatablock)
{
   %pickupValue = %pickupDatablock.GetValue();
   
   if ( %this.GetPickupByValue(%pickupValue) )
      echo("WARNING: PickupTypeDatabase::AddPickupDatablock Stomping Pickup!" SPC %this.GetPickupByValue(%pickupValue) SPC %pickupDatablock.getName());
   
   %this.pickupValueLookup[%pickupValue] = %pickupDatablock;
   
   %this.AddValueToValueTable(%pickupValue);
}   


function PickupTypeDatabase::GetPickupByValue(%this, %value)
{
   %pickupDatablock = %this.pickupValueLookup[%value];
   if ( !isObject( %pickupDatablock ) )
      %pickupDatablock = 0;
      
   return %pickupDatablock;
}

//The value table acts as a list of value pointers to the pickupDatablock.
//This allows us to quickly "make change" using these datablocks.  
function PickupTypeDatabase::AddValueToValueTable(%this, %value)
{
   %currentValueTable = %this.valueTable;
   
   %tableIndex = 0;
   for ( %tableIndex; %tableIndex < getWordCount(%currentValueTable); %tableIndex++ )
   {
      %currentValue = getWord(%currentValueTable, %tableIndex);
      if ( %value > %currentValue )
         break;      
   }
   
   %currentValueTable = addWord(%currentValueTable, %tableIndex, %value);
   %this.valueTable = %currentValueTable;
}


//Returns all the values required to make totalValue
//Then we just get pickup by value
function PickupTypeDatabase::GetSpawnValueTable(%this, %totalValue)
{
   %totalValue = mFloor(%totalValue);  //whole numbers ONLY
   %currentValueTable = %this.valueTable;
   %returnValues = "";
   
   %currentValueIndex = 0;
   %triesLeft = 100;
   while ( %totalValue > 0 && %triesLeft > 0)
   {
      for ( %i = %currentValueIndex; %i < getWordCount(%currentValueTable); %i++ )
      {
         %currentValue = getWord(%currentValueTable, %i);         
         if ( %currentValue <= %totalValue )
         {
            %returnValues = %returnValues @ %currentValue @ " ";
            %totalValue -= %currentValue;
            break;            
         }        
      }
      %currentValueIndex = %i; //remember my spot.     
      %triesLeft--;
   }
   
   if( %triesLeft <= 0 )
      echo("Something is broken with: PickupTypeDatabase::GetSpawnValueTable" SPC %this.pickupType);
   
   return %returnValues; //this list should add up to %totalvalue.  
}


/////////////////////////////////////////////////////////////////////////////////////////////////////
// Pickup Datablock Definitions /////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////
$PD_EffectDatablock = 0;
$PD_EffectScale = 1;
$PD_EffectLinkPoints = 2;


datablock PickupDatablock(PickupBase) 
{     
   explosionDatablock = "SmallExplosion";
   explosionSound     = "snd_smallExplosion";
   explosionScale     = "1.0";
   
   collectionDatablock = "beamAbord";  
   collectionSound     = "snd_smallCargoPickup";
   collectionScale     = "1.0";
   
   spawnEffect = "pickupSpawnBurst";
   spawnEffectScale     = "1";
   
   minLifeSpan = 15000;  //In MS  will vary but this is the minimum
   maxHealth = 100;
   pickupMass = 10;  //keep mass constant for pickups then we can play with their ejection forces.   
   
   value = -1;  //if value < 0 the databse will ignore.  good for base classes. 
   
   codeClass = "Pickup";
   objectClass = "";  //for simple script defined classes like for rare story objects. will call: ShouldAllowCollection_SCRODE
   objectSuperclass = ""; 
   
   baseBlend = "1 1 1 1";
   pulseBlend = "1 1 1 1";    
   pulseTime = 0;
  
   size = "32 32";
   pulseSize = "32 32"; 
   
   initialStateTime = "800 1200"; //getrandomfrompair
 
   isIntense = false;      
   pickupDamping = 0.25;
   valueMultiplier = 1;    //to allow AI to better prioritize what to pick up.
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Resources ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

datablock PickupDatablock(ResourceRockBase : PickupBase) 
{
   initialState = "Attract";
   
   stateEffects["Attract", $PD_EffectDatablock]  = "WhiteFlash";
   stateEffects["Attract", $PD_EffectScale]      = "1";
   stateEffects["Attract", $PD_EffectLinkPoints] = "1";
   
     
   size = "32 32";
   CollisionPolyList = "-0.241 -0.953 0.670 -0.192 0.073 0.854 -0.807 0.093";
   LinkPoints = "-0.005 0.000";
   
   codeClass = "ResourceRockObject";  
   
   GraphGroup = $COLLISION_ID_RESOURCE_ROCKS;  //this determines what the thing is and is therefore very important. ai looks at this.

   value = -1;  //DB Ignore
   valueMultiplier = 1;  //to allow AI to better prioritize what to pick up.
};

//////////////////////////
// RESOURCE TYPES
//////////////////////////

datablock PickupDatablock(ResourceRockGreen : ResourceRockBase) 
{
   imageMapList = "pickup_asteroid_01_greenImageMap pickup_asteroid_02_greenImageMap pickup_asteroid_03_greenImageMap";   
   size = "16 16";
   value = 1;
   maxHealth = 5; 
};


datablock PickupDatablock(ResourceRockBlue : ResourceRockBase) 
{ 
   imageMapList = "pickup_asteroid_01_blueImageMap pickup_asteroid_02_blueImageMap pickup_asteroid_03_blueImageMap"; 
   size = "24 24";  //too big for asteroid chunks
   value = 5;
   maxHealth = 10; 
};

datablock PickupDatablock(ResourceRockYellow : ResourceRockBase) 
{
   imageMapList = "pickup_asteroid_01_yellowImageMap pickup_asteroid_02_yellowImageMap pickup_asteroid_03_yellowImageMap";   
   size = "32 32";
   value = 25;
   maxHealth = 2; 
};

datablock PickupDatablock(ResourceRockRed : ResourceRockBase) 
{
   imageMapList = "pickup_asteroid_01_redImageMap pickup_asteroid_02_redImageMap pickup_asteroid_03_redImageMap";  
   size = "48 48"; 
   value = 100;
   maxHealth = 1; 
};

datablock PickupDatablock(ResourceRockPurple : ResourceRockBase) 
{
   imageMapList = "pickup_asteroid_01_purpleImageMap pickup_asteroid_02_purpleImageMap pickup_asteroid_03_purpleImageMap"; 
   size = "64 64";   //too big for asteroid chunks
   value = 500;
   maxHealth = 20; 
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Data Cubes ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


datablock PickupDatablock(DatacubeBase : PickupBase) 
{
   initialState = "Attract";
   
   stateEffects["Attract", $PD_EffectDatablock]  = "DataLight";
   stateEffects["Attract", $PD_EffectScale]      = "1.4";
   stateEffects["Attract", $PD_EffectLinkPoints] = "1";
   
   baseBlend = "1 1 1 1";
   size = "32 32";
   isIntense = false;     
   
   minLifeSpan = 10000;
   
   CollisionPolyList = "-0.241 -0.953 0.670 -0.192 0.073 0.854 -0.807 0.093";
   LinkPoints = "-0.005 0.000";
   
   codeClass = "DatacubeObject";  
   
   GraphGroup = $COLLISION_ID_DATA_CUBES;  //this determines what the thing is and is therefore very important. ai looks at this.

   value = -1;  //DB Ignore
   valueMultiplier = 10;  //to allow AI to better prioritize what to pick up.

   initialStateTime = "150 350";  //wanna pick these up right away. 
};

///////////////////////////
//DATA TYPES
///////////////////////////

datablock PickupDatablock(DatacubeGreen : DatacubeBase) 
{
   imageMap = "pickup_data_greenImageMap";   
   value = 1;
   minLifeSpan = 25000;
   size = "16 16";
   stateEffects["Attract", $PD_EffectScale]      = "1.2";
};

datablock PickupDatablock(DatacubeBlue : DatacubeBase) 
{
   imageMap = "pickup_data_blueImageMap";   
   value = 5;
   minLifeSpan = 30000;
   size = "24 24";
   stateEffects["Attract", $PD_EffectScale]      = "1.3";
};

datablock PickupDatablock(DatacubeYellow : DatacubeBase) 
{
   imageMap = "pickup_data_yellowImageMap";   
   value = 10;
   minLifeSpan = 45000;
   size = "32 32";
   stateEffects["Attract", $PD_EffectScale]      = "1.4";
};


datablock PickupDatablock(DatacubeRed : DatacubeBase) 
{
   imageMap = "pickup_data_redImageMap";    
   value = 25;
   minLifeSpan = 60000;
   size = "48 48";
   stateEffects["Attract", $PD_EffectScale]      = "1.6";
};

datablock PickupDatablock(DatacubePurple : DatacubeBase) 
{
   imageMap = "pickup_data_purpleImageMap";      
   value = 100; //equates to 1 full level up
   minLifeSpan = 120000;
   size = "64 64";
   stateEffects["Attract", $PD_EffectScale]      = "1.8";
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Story Pickups ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


datablock PickupDatablock(StoryPickupBase : PickupBase) 
{
   initialState = "Attract";
   
   stateEffects["Attract", $PD_EffectDatablock]  = "WhiteFlash";
   stateEffects["Attract", $PD_EffectScale]      = "1";
   stateEffects["Attract", $PD_EffectLinkPoints] = "1";
   
     
   size = "32 32";
   CollisionPolyList = "-0.946 -0.884 0.910 -0.879 0.840 0.810 -0.849 0.820";
   LinkPoints = "-0.005 0.000";
   
   objectClass = "StoryPickupObject";  
   
   GraphGroup = $COLLISION_ID_STORYPICKUPS;  //this determines what the thing is and is therefore very important. ai looks at this.
   maxHealth = 10000; //prevent their deaths.
   value = -1;  //DB Ignore
   valueMultiplier = 10000;  //Player has to grab it themself, Has super high priority for tractor beam pickup
};

///////////////////////////
//DATA TYPES
///////////////////////////

////////////////////////////////////////////////////////////////////////////////
//generic pickups for collect missions
////////////////////////////////////////////////////////////////////////////////

datablock PickupDatablock(GenericMissionPickupBase : StoryPickupBase) 
{
   objectClass = "GenericMissionPickupObject";  
   //valueMultiplier = 10000;  //Player has to grab it themself, Has super high priority for tractor beam pickup
};

datablock PickupDatablock(MissionPickup_Basic : GenericMissionPickupBase) 
{
   imageMapList = "gen_pickup_01ImageMap gen_pickup_02ImageMap gen_pickup_03ImageMap gen_pickup_04ImageMap";  
   size = "32 32";  
   value = 1;
   pickupCallback = "MissionPickup_Basic_Fetched";
};
datablock PickupDatablock(MissionPickup_MeatNode : GenericMissionPickupBase) 
{
   imageMap = "pickup_meatNodeImageMap";  
   size = "16 16";  
   value = 96;
   pickupCallback = "MissionPickup_Basic_Fetched";
};

////////////////////////////////////////////////////////////////////////////////
//generic custom art
////////////////////////////////////////////////////////////////////////////////

datablock PickupDatablock(S1_EnginePart : StoryPickupBase) 
{
   imageMap = "S1_EnginePartImageMap";  
   size = "64 64";  
   value = 1;
   
   pickupCallback = "S1_OnPartFetched";
};

datablock PickupDatablock(S1_EnginePart_Dropoff : S1_EnginePart) 
{   
   objectClass = "StoryDropOffObject";  //Only beacons and motherships grab these. 
   pickupCallback = "S1_OnPartReturned";
};

datablock PickupDatablock(S2_crystalPickup : MissionPickup_Basic) 
{
   imageMapList = "";  //don't use root junk
   imageMap = "S2_beamCrystalImageMap";  
   value = 2;
};

datablock PickupDatablock(S2_capPartPickup : MissionPickup_Basic) 
{
   imageMapList = "";  //don't use root junk
   imageMap = "S2_capPartImageMap"; 
   value = 3; 
};

datablock PickupDatablock(S2_reactorPickup : MissionPickup_Basic) 
{
   imageMapList = "";  //don't use root junk
   imageMap = "S2_reactorImageMap";  
   value = 4;
   size = "64 64";  
};

datablock PickupDatablock(S3_PrisonPod: MissionPickup_Basic) 
{
   imageMapList = "";  //don't use root junk
   imageMap = "S3_prisionPodImageMap"; 
   size = "64 64";  
   value = 92239;  //values of story pickups need to be different.
   spawnEffectScale = "2.5";
};

datablock PickupDatablock(S3_PureRezPickup : MissionPickup_Basic) 
{
   imageMapList = "";  //don't use root junk
   imageMap = "S3_pureRezImageMap"; 
   size = "32 32";  
   value = 91929;  //values of story pickups need to be different.
};

datablock PickupDatablock(S3_BlackBox : StoryPickupBase) 
{
   imageMap = "S3_ComCoreImageMap"; 
   size = "32 32";  
   value = 9999;  //values of story pickups need to be different.
   
   pickupCallback = "OnS3BlackBoxPickup";
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// BlackBox Pickups ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


datablock PickupDatablock(BlackBoxPickupBase : PickupBase) 
{
   initialState = "Attract";
   
   stateEffects["Attract", $PD_EffectDatablock]  = "DataLight";
   stateEffects["Attract", $PD_EffectScale]      = "0.7";
   stateEffects["Attract", $PD_EffectLinkPoints] = "1";
   
   baseBlend = "1 1 1 1";
   size = "16 16";
   isIntense = false;     
   
   //RLB: probably want a proper collison for this. this is stolen from data.
   CollisionPolyList = "-0.241 -0.953 0.670 -0.192 0.073 0.854 -0.807 0.093";
   LinkPoints = "-0.005 0.000";
   
   codeClass = "BlackBoxObject";  
   
   GraphGroup = $COLLISION_ID_DATA_CUBES;  //this determines what the thing is and is therefore very important. ai looks at this.

   minLifeSpan = 60000;
   
   value = -1;  //DB Ignore
   valueMultiplier = 1000;  //to allow AI to better prioritize what to pick up.
};



///////////////////////////
//DATA TYPES
///////////////////////////

datablock PickupDatablock(BlackBoxPickup : BlackBoxPickupBase) 
{
   //Needs art.
   imageMap = "pickup_blackBoxImageMap";  
   size = "24 24";  
   value = 1;   
};


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Research Pickups ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


datablock PickupDatablock(ResearchPickupBase : PickupBase) 
{
   initialState = "Attract";
   
   stateEffects["Attract", $PD_EffectDatablock]  = "DataLight";
   stateEffects["Attract", $PD_EffectScale]      = "0.7";
   stateEffects["Attract", $PD_EffectLinkPoints] = "1";
   
   baseBlend = "1 1 1 1";
   size = "16 16";
   isIntense = false;     
   
   //RLB: probably want a proper collison for this. this is stolen from data.
   CollisionPolyList = "-0.241 -0.953 0.670 -0.192 0.073 0.854 -0.807 0.093";
   LinkPoints = "-0.005 0.000";
   
   codeClass = "ResearchObject";  
   
   GraphGroup = $COLLISION_ID_DATA_CUBES;  //this determines what the thing is and is therefore very important. ai looks at this.

   minLifeSpan = 60000;
   
   value = -1;  //DB Ignore
   valueMultiplier = 1000;  //to allow AI to better prioritize what to pick up.
};

datablock PickupDatablock(ResearchPickup : ResearchPickupBase) 
{
   //Needs art.
   imageMap = "pickup_blackBoxImageMap";  
   size = "24 24";  
   value = 1;   
};


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Pilot Pickups ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

datablock PickupDatablock(PilotPickupBase : PickupBase) 
{
   initialState = "Attract";
   
   stateEffects["Attract", $PD_EffectDatablock]  = "WhiteFlash";
   stateEffects["Attract", $PD_EffectScale]      = "1";
   stateEffects["Attract", $PD_EffectLinkPoints] = "1";
   
     
   size = "32 32";
   CollisionPolyList = "-0.309 -0.678 0.000 -0.908 0.299 -0.697 0.304 0.702 0.000 0.972 -0.309 0.707";
   LinkPoints = "-0.005 0.000";
   
   GraphGroup = $COLLISION_ID_DATA_CUBES;  //hopefully will make indestructible
   
   minLifeSpan = 1000000;  //In MS  will vary but this is the minimum
   maxHealth = 50000;

   value = -1;  //DB Ignore
   valueMultiplier = 5000;  //Player has to grab it themself, Has super high priority for tractor beam pickup
    
   objectSuperclass = "PilotPickupClass";  
};

datablock PickupDatablock(PilotPickup : PilotPickupBase) 
{
   imageMap = "pilotpod_baseImageMap";  
   size = "32 32";  
   value = 1;
   
};



