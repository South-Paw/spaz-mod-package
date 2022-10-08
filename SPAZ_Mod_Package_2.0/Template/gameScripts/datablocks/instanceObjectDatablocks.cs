

function InstanceObjectDatablockBaseClass::OnAdd(%this)
{
   %this.objectDatablockList = createEfficientWeightedList(%this.objectDatablockList); 
   
   
}

///////////////////////////////////////////////////////////////////////////////////////////////////////
// Definition for spawning objects within instances ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptObject(InstanceObjectDatablockBase)
{
   class = "InstanceObjectDatablockBaseClass";
      
   objectClass = "";  //Will cause usage of the base class (which will not spawn anything)
      
   instanceObjectSize = "0";  //0 means overlap is ok since it is just some ambient stuff
   
   objectMinDistance = 0;
   objectMaxDistance = "0 200";
   evenSpread = false;   //will be more stuff toward the center
   isPersistent = false; //we dont want to store the location of ever asteroidin the game, but ships woul dbe good. 
};



///////////////////////////////////////////////////////////////////////////////////////////////////////
// Asteroid Handling //////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

$AsteroidChances_S = "asteroidSmall_01 100";
$AsteroidChances_M = "asteroidMedium_01 25 asteroidMedium_02 25 asteroidMedium_03 12 asteroidMedium_04 12";
$AsteroidChances_L = "asteroidLarge_01 12 asteroidLarge_02 12 asteroidLarge_03 12 asteroidLarge_04 12";

$AsteroidChances_ZC = "asteroid_Alien_Crystal 10 asteroid_Alien_Crystal_2 10";
$AsteroidChances_ZC_hard = "asteroid_Alien_Crystal_01_hard 10 asteroid_Alien_Crystal_02_hard 10";

$AsteroidZombieChances_H = "asteroidZombie_Small_01 10 asteroidZombie_Small_02 10 asteroidZombie_Medium_01 10 asteroidZombie_Medium_02 10 asteroidZombie_Medium_03 10 asteroidZombie_Medium_04 10";
$AsteroidZombieChances_S = "asteroidZombie_Small_01 100 asteroidZombie_Small_02 100";
$AsteroidZombieChances_M = "asteroidZombie_Medium_01 25 asteroidZombie_Medium_02 25 asteroidZombie_Medium_03 12 asteroidZombie_Medium_04 12";
$AsteroidZombieChances_L = $AsteroidZombieChances_M; //there are no large ones.


new ScriptObject(AsteroidBreakage : InstanceObjectDatablockBase)
{
   objectDatablockList = $AsteroidChances_M SPC $AsteroidChances_L;  //Weighted List
   objectClass = "AsteroidRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1000;   
};


new ScriptObject(AmbientAsteroids : InstanceObjectDatablockBase)
{
   objectDatablockList = $AsteroidChances_S;  
   objectClass = "AsteroidRespawnerClass";
   objectMinDistance = 0;
   objectMaxDistance = 3000;
   evenSpread = true;   
};

new ScriptObject(AsteroidCluster : InstanceObjectDatablockBase)
{
   objectDatablockList = $AsteroidChances_M SPC $AsteroidChances_L;  
   objectClass = "AsteroidRespawnerClass";
   objectMinDistance = 0;
   objectMaxDistance = "400 600";
   evenSpread = true;   
};

new ScriptObject(SingleAsteroid : AsteroidCluster)
{
   objectMaxDistance = 0; 
};


new ScriptObject(AsteroidCluster_zombie : AsteroidCluster)
{
   objectDatablockList = $AsteroidZombieChances_H;
   objectMinDistance = 0;
   objectMaxDistance = "3000 3000";  
};

new ScriptObject(AsteroidCluster_alien_crystal : AsteroidCluster)
{
   objectDatablockList = $AsteroidChances_ZC;  
   objectMaxDistance = "4000 5000";  
};
new ScriptObject(AsteroidCluster_alien_crystal_hard : AsteroidCluster)
{
   objectDatablockList = $AsteroidChances_ZC_hard;  
   objectMaxDistance = "4000 5000";  
};

new ScriptObject(AsteroidMother : InstanceObjectDatablockBase)
{
   objectDatablockList = "asteroidMother_01";  
   objectClass = "AsteroidRespawnerClass";     
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
};

new ScriptObject(AsteroidAutoDriller : InstanceObjectDatablockBase)
{
   objectDatablockList = "asteroid_AutoDriller_01 10 asteroid_AutoDriller_02 10";  
   objectClass = "AsteroidRespawnerClass";     
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
   
   objectMinDistance = "500 600";
   objectMaxDistance = "1500 2000";
};


new ScriptObject(AsteroidComet : InstanceObjectDatablockBase)
{
   objectDatablockList = "asteroidComet_01";  
   objectClass = "AsteroidRespawnerClass";     
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
};

new ScriptObject(AsteroidCometMassive : InstanceObjectDatablockBase)
{
   objectDatablockList = "asteroidComet_massive_01";  
   objectClass = "AsteroidRespawnerClass";     
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
};

new ScriptObject(CloakGenerator : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_CloakGenerator";  
   objectClass = "SpacePropRespawnerClass";     
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
};

new ScriptObject(S4_GateGens : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_AlienPowGen";  
   objectClass = "SpacePropRespawnerClass";     
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
};


new ScriptObject(CarlsFakeShip : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_CarlsFakeShip";  
   objectClass = "AsteroidRespawnerClass";     
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
};
new ScriptObject(SpammerRadarDish : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_SpammerRadar";  
   objectClass = "AsteroidRespawnerClass";     
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
};


new ScriptObject(MiningBase : InstanceObjectDatablockBase)
{
   objectDatablockList = "MiningStationData";  
   objectClass = "StationRespawnerClass";       
   instanceObjectSize = "1000";  //no other object should try to deploy from this object's parent within this radius.
};


///////////////////////////////////////////////
// Space Props
///////////////////////////////////////////////

new ScriptObject(SpaceProp_ExplodingBarrels_Light : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_ExplodingBarrel_lite_01 10";  //Weighted List
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1500;   
};

new ScriptObject(SpaceProp_ExplodingBarrels : SpaceProp_ExplodingBarrels_Light)
{
   objectDatablockList = "Prop_ExplodingBarrel_01 50 Prop_BarrelHolder_01 5 Prop_ExplodingBarrel_lite_01 1";  //Weighted List
};

new ScriptObject(SpaceProp_ExplodingBarrels_HoldersOnly : SpaceProp_ExplodingBarrels_Light)
{
   objectDatablockList = "Prop_BarrelHolder_01 10";
};

new ScriptObject(SpaceProp_EMPBarrels : SpaceProp_ExplodingBarrels_Light)
{
   objectDatablockList = "Prop_EMPBarrel_01 50 Prop_EMPBarrelHolder_01 5";  //Weighted List
};

new ScriptObject(SpaceProp_AcidBarrels : SpaceProp_ExplodingBarrels_Light)
{
   objectDatablockList = "Prop_AcidBarrel_01 50 Prop_AcidBarrelHolder_01 5";  //Weighted List
};




new ScriptObject(SpaceProp_Crates : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_SmallCrate_01 80 Prop_LargeCrate_01 40 Prop_HugeCrate_01 10";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1000;   
};


new ScriptObject(SpaceProp_GoonPods : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_goonCrate_small 90 Prop_goonCrate_large 30";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1000;   
};

//Need some zombie versions. 
new ScriptObject(SpaceProp_GoonPods_Zom : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_goonCrate_small_zom 90 Prop_goonCrate_large_zom 30";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1000;   
};


new ScriptObject(SpaceProp_Crates_Zom : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_SmallCrate_01_zom 80 Prop_LargeCrate_01_zom 40 Prop_HugeCrate_01_zom 10";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1000;   
};


new ScriptObject(SpaceProp_Crates_Rich : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_Crate_Red 80 Prop_Crate_Yellow 40 Prop_Crate_Green 10 Prop_Crate_Blue 10 Prop_Crate_Purple 10";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1500;   
};

new ScriptObject(SpaceProp_Artifacts : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_ArtifactCrate_01 10";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1500;   
};

new ScriptObject(SpaceProp_Artifacts_zom : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_ArtifactCrate_01_zom 10";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 1500;   
};

new ScriptObject(SpaceProp_AmbientCrates : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_SmallCrate_01 30 Prop_LargeCrate_01 10"; 
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 2000;
   objectMaxDistance = 3500;   
};

new ScriptObject(SpaceProp_UTASupply : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_UTACrate_01";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 1000;
   objectMaxDistance = 1500;   
};

new ScriptObject(SpaceProp_UTASupply_zom : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_UTACrate_01_zom";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 1000;
   objectMaxDistance = 1500;   
};

new ScriptObject(S1_SpaceProp_UTASupply : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_UTACrate_S1";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 1000;
   objectMaxDistance = 1500;   
};

new ScriptObject(SpaceProp_UTASupply_cloaked : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_UTACrate_cloaked_01";  
   objectClass = "SpacePropRespawnerClass";
   objectMinDistance = 1000;
   objectMaxDistance = 1500;   
};

new ScriptObject(SpaceProp_UTASupply_cloaked_S4 : SpaceProp_UTASupply_cloaked) //used for sec 4 since you can see / not shoot anything civ or terran any more
{
   objectDatablockList = "Prop_UTACrate_cloaked_S4_01";  
};

///////////////////////////////////////////////
// Ship Wreckage
///////////////////////////////////////////////

new ScriptObject(ShipWreck_Graveyard : InstanceObjectDatablockBase)
{
   objectDatablockList = "Prop_ExplodingBarrel_01 10";  //Weighted List
   objectClass = "AmbientWreckRespawnerClass";
   objectMinDistance = 500;
   objectMaxDistance = 2000;   
};

///////////////////////////////////////////////
// Pickups
///////////////////////////////////////////////

new ScriptObject(Pickups_Generic : InstanceObjectDatablockBase)
{
   objectDatablockList = "NeedsToSaySumptin";     
   objectClass = "PickupRespawnerClass";
   objectMinDistance = 0;
   objectMaxDistance = 0;   
};

new ScriptObject(Pickups_Generic_scatter : Pickups_Generic)
{
   objectMinDistance = 100;
   objectMaxDistance = 450;   
};

///////////////////////////////////////////////
// Mine Fields
///////////////////////////////////////////////

//Modified to use basic minefield for now.  changed minefields. 
new ScriptObject(RegenSwarmMineField: InstanceObjectDatablockBase)
{
   objectDatablockList = "Dropper_Small_Explosive";
   objectClass = "MineFieldRespawnerClass";
   objectMinDistance = 1500;
   objectMaxDistance = 2500;   
   evenSpread = true;   
};

new ScriptObject(RegenSwarmMineField_large: RegenSwarmMineField)
{ 
   objectDatablockList = "Dropper_Large_Explosive";
};

new ScriptObject(ScannerSwarmMineField: RegenSwarmMineField)
{
   objectDatablockList = "Dropper_Small_Scanner";
};

new ScriptObject(ScannerSwarmMineField_Large: RegenSwarmMineField)
{
   objectDatablockList = "Dropper_Large_Scanner";
};

///////////////////////////////////////////////
// Drone Hives
///////////////////////////////////////////////

new ScriptObject(AttackDroneHive: InstanceObjectDatablockBase)
{
   objectDatablockList = "DroneHive_Attack_Small";
   objectClass = "DroneHiveRespawnerClass";
   objectMinDistance = 1500;
   objectMaxDistance = 2500;   
   evenSpread = true;   
};


////////////////////////////////////////////////////////////////////////
// Science Handling ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////


new ScriptObject(ScienceBase : InstanceObjectDatablockBase)
{
   objectDatablockList = "ScienceStationData";  
   objectClass = "StationRespawnerClass";       
   instanceObjectSize = "1000";  
};


////////////////////////////////////////////////////////////////////////
// Military Handling ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////


new ScriptObject(MilitaryBase : InstanceObjectDatablockBase)
{
   objectDatablockList = "MilitaryStationData";  
   objectClass = "StationRespawnerClass";       
   instanceObjectSize = "1000";  
};




////////////////////////////////////////////////////////////////////////
// Security Handling ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////


new ScriptObject(SecurityBase : InstanceObjectDatablockBase)
{
   objectDatablockList = "SecurityBaseData";  
   objectClass = "SecurityRespawnerClass";       
   instanceObjectSize = "1000";  
   objectMinDistance = 0;
   objectMaxDistance = 0;
};


////////////////////////////////////////////////////////////////////////
// Bounty Handling ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////


new ScriptObject(BountyStarbase : InstanceObjectDatablockBase)
{
   objectDatablockList = "BountyStarbaseData";  
   objectClass = "BountyStarbaseRespawnerClass";       
   instanceObjectSize = "1000";  
   objectMinDistance = 0;
   objectMaxDistance = 0;
};




////////////////////////////////////////////////////////////////////////
// Colony Handling ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////


new ScriptObject(ColonyBase : InstanceObjectDatablockBase)
{
   objectDatablockList = "ColonyStationData";  
   objectClass = "StationRespawnerClass";       
   instanceObjectSize = "1000";  
};

////////////////////////////////////////////////////////////////////////
// Pirate Handling ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////


new ScriptObject(PirateBase : InstanceObjectDatablockBase)
{
   objectDatablockList = "PirateStationData";  
   objectClass = "StationRespawnerClass";       
   instanceObjectSize = "1000";  
};


////////////////////////////////////////////////////////////////////////
// Zombie Handling ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////


new ScriptObject(ZombieBase : InstanceObjectDatablockBase)
{
   objectDatablockList = "ZombieStationData";  
   objectClass = "StationRespawnerClass";       
   instanceObjectSize = "1000";  
};


////////////////////////////////////////////////////////////////////////
// WarpGate Handling ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////


new ScriptObject(WarpGate : InstanceObjectDatablockBase)
{
   objectDatablockList = "StandardWarpGate";  //Currently only 1 type of warpgate, so no need to have a datablock here. 
   objectClass = "WarpGateRespawnerClass";       
   instanceObjectSize = "1000";  
};


////////////////////////////////////////////////////////////////////////////////////////////////
// Ship Handling ///////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////
//LEVEL OFFSET ALSO BELONGS IN INSTANCE DEFINITION

//Specific Ships
new ScriptObject(TinyShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Tiny";    
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};

new ScriptObject(SmallShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Small";  
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};

new ScriptObject(MediumShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Medium";   
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};

new ScriptObject(LargeShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Large";  
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};

new ScriptObject(HugeShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Huge";   
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};


//Scaled Ships
new ScriptObject(LightShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Light";    
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};

new ScriptObject(AverageShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Average";    
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};

new ScriptObject(HeavyShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Heavy";    
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};

//Boss Ships:  these are related to the player's mothership level.
new ScriptObject(BossShips : InstanceObjectDatablockBase)
{
   objectDatablockList = "Boss";    
   objectClass = "LeveledShipRespawnerClass";       
   isPersistent = true;    
};


////////////////////////////////////////////////////////////////////////////////////////////
// Special Respaswer class to allow easy ship definition in the instanceObjectDatablock
///////////////////////////////////////////////////////////////////////////////////////////


new ScriptObject(SpawnMyShip : InstanceObjectDatablockBase)
{
   objectDatablockList = "NeedsToSaySumptin";     
   objectClass = "SpawnMyShipRespawnerClass";       
   isPersistent = true;    
};

new ScriptObject(SpawnMyShipInstant : InstanceObjectDatablockBase)
{
   objectDatablockList = "NeedsToSaySumptin";     
   objectClass = "SpawnMyShipInstantRespawnerClass";       
   isPersistent = true;    
};

///////////////////////////////////////////////////
// QuestTriggers //////////////////////////////////
///////////////////////////////////////////////////

new ScriptObject(QuestTrigger : InstanceObjectDatablockBase)
{
   objectDatablockList = "NeedsToSaySumptin";     
   objectClass = "QuestTriggerRespawnerClass";       
   
   objectMinDistance = 0;  //stay where i put ya
   objectMaxDistance = 0;
};


new ScriptObject(FakeWarpGate : InstanceObjectDatablockBase)
{
   objectDatablockList = "CaptainPoopyPants1";   //meaningless here.
   objectClass = "FakeWarpGateRespawnerClass";       
     
   objectMinDistance = 0;  //stay where i put ya
   objectMaxDistance = 0;
};

///////////////////////////////////////////////////////
// Locators ///////////////////////////////////////////
///////////////////////////////////////////////////////
//These are invisible objects created for reference by other objects. 
//These automatically appear if instanceObjectWeightedList = ""

new ScriptObject(Invisible_Locator : InstanceObjectDatablockBase)
{
   objectDatablockList = "IAmInvisible";   //meaningless here.
   objectClass = "LocatorRespawnerClass";       
     
   objectMinDistance = 0;  //stay where i put ya
   objectMaxDistance = 0;
};


////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Extras (move to there files //////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//TODO: figure out a generalization for stuff like this too. 

//////////////////////////////////////
// Mining ////////////////////////////
//////////////////////////////////////
new ScriptObject(MiningStationData)
{
   stationFaction = "Civ";
   infra0 = "OutpostBase01Data";
   infra1 = "StationData_Mining1";
   infra2 = "StationData_Mining2";
   infra3 = "StationData_Mining3";
};

new ScriptObject(StationData_Mining1)
{
   stationDatablockList = "BoreBase";
};

new ScriptObject(StationData_Mining2)
{
   stationDatablockList = "DredgeBase";
};

new ScriptObject(StationData_Mining3)
{
   stationDatablockList = "QuarryBase";
};

new ScriptObject(MiningShipData)
{
   shipFaction = "Civ";
   shipDatablockList = "ShortBusShip";
};

///////////////////////////////////////////////
// Colony /////////////////////////////////////
///////////////////////////////////////////////

new ScriptObject(ColonyStationData)
{
   stationFaction = "Civ";
   infra0 = "OutpostBase01Data";
   infra1 = "StationData_Colony1";
   infra2 = "StationData_Colony2";
   infra3 = "StationData_Colony3";
};

new ScriptObject(StationData_Colony1)
{
   stationDatablockList = "SanctuaryBase";
};

new ScriptObject(StationData_Colony2)
{
   stationDatablockList = "FiveStarBase";
};

new ScriptObject(StationData_Colony3)
{
   stationDatablockList = "OasisBase";
};

new ScriptObject(ColonyShipData)
{
   shipFaction = "Civ";
   shipDatablockList = "CabShip";
};


///////////////////////////////////////////////
// Science /////////////////////////////////////
///////////////////////////////////////////////

new ScriptObject(ScienceStationData)
{
   stationFaction = "Civ";
   infra0 = "OutpostBase01Data";
   infra1 = "StationData_Science1";
   infra2 = "StationData_Science2";
   infra3 = "StationData_Science3";
};

new ScriptObject(StationData_Science1)
{
   stationDatablockList = "EchoBase";
};

new ScriptObject(StationData_Science2)
{
   stationDatablockList = "QuasarBase";
};

new ScriptObject(StationData_Science3)
{
   stationDatablockList = "PulsarBase";
};


new ScriptObject(ScienceShipData)
{
   shipFaction = "Civ";
   shipDatablockList = "RetinaShip";
};



///////////////////////////////////////////////
// Military ///////////////////////////////////
///////////////////////////////////////////////

new ScriptObject(MilitaryStationData)
{
   stationFaction = "Terran";
   infra0 = "OutpostBase01Data";
   infra1 = "StationData_Military1";
   infra2 = "StationData_Military2";
   infra3 = "StationData_Military3";
};


new ScriptObject(StationData_Military1)
{
   stationDatablockList = "Terran01Base";
};

new ScriptObject(StationData_Military2)
{
   stationDatablockList = "Terran02Base";
};

new ScriptObject(StationData_Military3)
{
   stationDatablockList = "Terran03Base";
};





///////////////////////////////////////////////
// Pirate /////////////////////////////////////
///////////////////////////////////////////////

new ScriptObject(PirateStationData)
{
   stationFaction = "Pirate";
   infra0 = "OutpostBase01Data";
   infra1 = "StationData_Pirate1";
   infra2 = "StationData_Pirate2";
   infra3 = "StationData_Pirate3";
};


new ScriptObject(StationData_Pirate1)
{
   stationDatablockList = "Pirate01Base";
};

new ScriptObject(StationData_Pirate2)
{
   stationDatablockList = "Pirate02Base";
};

new ScriptObject(StationData_Pirate3)
{
   stationDatablockList = "Pirate03Base";
};


///////////////////////////////////////////////
// SecurityBase ///////////////////////////////
///////////////////////////////////////////////

new ScriptObject(SecurityBaseData)
{
    
   //NOTE: security base is either Civ or Terran.  Zombies get their own instance and pirates dont own systems
   infra["Terran", 0] = "OutpostBase01Data";
   infra["Terran", 1] = "StationData_Military1";
   infra["Terran", 2] = "StationData_Military2";
   infra["Terran", 3] = "StationData_Military3";
   
   infra["Civ", 0] = "OutpostBase01Data";
   infra["Civ", 1] = "StationData_Pirate1";
   infra["Civ", 2] = "StationData_Pirate2";
   infra["Civ", 3] = "StationData_Pirate3";
};

///////////////////////////////////////////////
// Bounty /////////////////////////////////////
///////////////////////////////////////////////

new ScriptObject(BountyStarbaseData)
{
   stationFaction = "Bounty";
   infra0 = "StationData_Bounty0";
   infra1 = "StationData_Bounty1";
   infra2 = "StationData_Bounty2";
   infra3 = "StationData_Bounty3";
};


new ScriptObject(StationData_Bounty0)
{
   stationDatablockList = "";  
};

new ScriptObject(StationData_Bounty1)
{
   stationDatablockList = "Bounty03Base_Basic";
};

new ScriptObject(StationData_Bounty2)
{
   stationDatablockList = "Bounty03Base_Improved";
};

new ScriptObject(StationData_Bounty3)
{
   stationDatablockList = "Bounty03Base_Advanced";
};




///////////////////////////////////////////////
// Zombie /////////////////////////////////////
///////////////////////////////////////////////

new ScriptObject(ZombieStationData)
{
   stationFaction = "Zombie";
   infra0 = "StationData_Zombie1";
   infra1 = "StationData_Zombie1";
   infra2 = "StationData_Zombie2";
   infra3 = "StationData_Zombie3";
};


new ScriptObject(StationData_Zombie1)
{
   stationDatablockList = "HeartZombieStation";
};

new ScriptObject(StationData_Zombie2)
{
   stationDatablockList = "ArteryZombieStation";
};

new ScriptObject(StationData_Zombie3)
{
   stationDatablockList = "HiveZombieStation";
};

///////////////////////////////////////////////
// Zombie END BOSS
///////////////////////////////////////////////

new ScriptObject(ZombieEndBossData)
{
   shipFaction = "Zombie";
   shipDatablockList = "Zombie_ClockworkStation";
};

///////////////////////////////////////////////
// CLOCKWORK ZERO
///////////////////////////////////////////////

new ScriptObject(ClockworkBaseStation : InstanceObjectDatablockBase)
{
   objectDatablockList = "ClockworkBaseData";  
   objectClass = "StationRespawnerClass"; 
   instanceObjectSize = "1000"; 
   objectMinDistance = 1500;
   objectMaxDistance = 2500;          
};

new ScriptObject(ClockworkBaseData)
{
   stationFaction = "Civ";
   infra0 = "ClockworkBase01Data";
   infra1 = "ClockworkBase01Data";
   infra2 = "ClockworkBase01Data";
   infra3 = "ClockworkBase01Data";   
};

new ScriptObject(ClockworkBase01Data)
{
   stationFaction = "Civ";
   stationDatablockList = "PirateClockworkZero";
};

///////////////////////////////////////////////
// GENERIC OUTPOST
///////////////////////////////////////////////

new ScriptObject(OutpostBaseStation : InstanceObjectDatablockBase)
{
   objectDatablockList = "OutpostBaseData";  
   objectClass = "StationRespawnerClass"; 
   instanceObjectSize = "1000"; 
   objectMinDistance = 1500;
   objectMaxDistance = 2500;          
};

new ScriptObject(OutpostBaseZombieStation : OutpostBaseStation)
{
   objectDatablockList = "OutpostZombieBaseData";         
};

new ScriptObject(OutpostBaseData)
{
   stationFaction = "Terran";
   infra0 = "OutpostBase01Data";
   infra1 = "OutpostBase01Data";
   infra2 = "OutpostBase01Data";
   infra3 = "OutpostBase01Data";
};

new ScriptObject(OutpostZombieBaseData)
{
   stationFaction = "Zombie";
   infra0 = "EyeZombieStation01Data";
   infra1 = "EyeZombieStation01Data";
   infra2 = "OutpostZombieBase01Data";
   infra3 = "OutpostZombieBase01Data";
};

new ScriptObject(OutpostBase01Data)
{
   stationFaction = "Terran";
   stationDatablockList = "OutpostBase";
};

new ScriptObject(OutpostZombieBase01Data)
{
   stationFaction = "Zombie";
   stationDatablockList = "OutpostBase_zombie";
};

new ScriptObject(EyeZombieStation01Data)
{
   stationFaction = "Zombie";
   stationDatablockList = "EyeZombieStation";
};








