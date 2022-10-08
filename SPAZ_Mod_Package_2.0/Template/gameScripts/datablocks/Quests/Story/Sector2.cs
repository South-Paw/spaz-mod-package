//////////////////////////////////////////
// Focus Crystal /////////////////////////
//////////////////////////////////////////
//new ScriptGroup(S2_GetFocusCrystal : QuestBase) moved to sec 1 file for demo setup ease

///////////////////////////////////////////
// Capacitor Hunt /////////////////////////
///////////////////////////////////////////

new ScriptGroup(S2_GetCapacitors : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Sector2_Capacitor";
   DeployData["InstanceName"] = "Battleship Graveyard";
   
   questType   = "Event";   //just have to get there. 
   
   SelectionData["ObjectivesComplete"]  = "S2_GetFocus"; 
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "SCAVENGER HUNT";  
   description = "Collect 10 capacitors from the junk field to power the Titan beam";

   parentQuest = "";
   childQuests = "";
   
   Rewards["Complete", "Resource"] = "Exact 650";
   Rewards["Complete", "Data"] = "Exact 100";
  
   Callbacks["Selected"]      = ""; //is events    
   Callbacks["BeaconArrival"] = "S2_CapacitorsStarted";
   Callbacks["Complete"]      = "S2_CapacitorsComplete";   
 
   //Placeholder
   initialWaves = "WAVE_picupLocation WAVE_picupLocation WAVE_picupLocation WAVE_picupLocation WAVE_picupLocation WAVE_picupLocation WAVE_picupLocation WAVE_picupLocation WAVE_picupLocation";   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionText["initial"] = "MT_GOTO COLLECT CAPACITORS";
   missionText["hostiles"] = "MT_ATTACK HOSTLE JUNK RAIDERS INBOUND";
   missionText["yardBoss"] = "MT_ATTACK KILL SPACE SKID PUFF";
   missionText["lastCap"] = "MT_GOTO COLLECT THE LAST CAPACITOR";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "yardBoss";
   missionTrackerData[2] = "lastCap";
   
   new ScriptGroup("WAVE_picupLocation")
   {
      maxWaves = -1;  
      WaveMissionTrackers["active", 1] = "0";       
      new ScriptGroup("REF_stash" : MO_CollectProp)
      {   
         offset = "2000 5000";   
         refObjectName = "REF_beacon"; 
         
         pickupWL = "S2_capPartPickup 10"; 
         
         objectFuncs["Spawn", 1] = "AddGoToMarker";  
                       
         objectFuncs["Pickup", 0] = "evalTrackingSetCount pickupSet 7 StartWaveName JunkYardAttack_1 1000";
         objectFuncs["Pickup", 1] = "evalTrackingSetCount pickupSet 5 StartWaveName JunkYardAttack_1 1000";  
         objectFuncs["Pickup", 2] = "evalTrackingSetCount pickupSet 3 StartWaveName JunkYardAttack_2 1000";
         objectFuncs["Pickup", 3] = "evalTrackingSetCount pickupSet 1 StartWaveName JunkYardAttack_2 1000"; 
         objectFuncs["Pickup", 4] = "evalTrackingSetCount pickupSet 0 StartWaveName JunkYardBoss 1000"; 
         
         objectFuncs["Pickup", 5] = "CallInstanceFunc StartWaveName PickupPissoff";   
         
         objectCount = "1 1";  
         pickupFaction = "Pirate";
               
         new ScriptGroup("toxicBarrels" : MO_Props) 
         {    
            instanceObjectWeightedList = "SpaceProp_AcidBarrels 10";                                
            objectCount = "3 5";
            offset = "0 0";  
            refObjectName = ""; 
         };    
         new ScriptGroup("shipWrecks") 
         {    
            creationChance = 1;
            instanceObjectWeightedList = "ShipWreck_Graveyard 10";                                
            objectCount = "6 10";
            offset = "500 600";  
            refObjectName = ""; 
            wreckDatablockWL = "ShipWreck_BigBus 10 ShipWreck_Flora 10 ShipWreck_BigBrother 10 ShipWreck_RightHook 10 ShipWreck_Helix 10 ShipWreck_SunSpot_Left 5 ShipWreck_SunSpot_Right 5 ShipWreck_terranStation_01 5 shipWreck_quasarStation_01 5 ShipWreck_stationDoodad_Large 5 ShipWreck_stationDoodad_Med02 5"; 
            objectCount = "4 5";  
         };               
      };                 
   };
   
   new ScriptGroup("JunkYardAttack_1")
   {
      maxWaves = -1; 
      waveContext[1] = "hostiles";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand Civ_attacker SetTactic TP_Stance TP_SeekAndDestroy";    
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "LargeShips 10";
          refObjectName = "REF_Player";   
          offset = "1000 1200";  
          creationChance = 1;  
          objectCount = "1";
          factionOverride = "Civ";
          respectShipCount = 5;
          hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
          objectFuncs["Spawn", 0]   = "QAI_AddToSet Civ_attacker";     
      }; 
   }; 
     
   new ScriptGroup("JunkYardAttack_2")
   {
      maxWaves = -1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand Civ_attacker SetTactic TP_Stance TP_SeekAndDestroy";    
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "MediumShips 10";
          refObjectName = "REF_Player";   
          offset = "1000 1200";  
          creationChance = 1;  
          objectCount = "2";
          factionOverride = "Civ";
          respectShipCount = 5;
          hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
          objectFuncs["Spawn", 0]   = "QAI_AddToSet Civ_attacker";      
      }; 
   }; 
           
   new ScriptGroup("JunkYardBoss")
   {
      maxWaves = 1; 
      waveContext[1] = "yardBoss";
      WaveMissionTrackers["active", 1] = "1";  
      WaveMissionTrackers["remove", 1] = "0";  
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand Civ_attacker SetTactic TP_Stance TP_SeekAndDestroy"; 
      waveTimedCallbacks[1, 1] = "0 callQuestFunction S2_capBossDialog"; 
      new ScriptGroup("REF_bossShip_Loc" : MO_Trigger) 
      {                                               
      };       
      new ScriptGroup("REF_bossShip") 
      {                                      
         instanceObjectWeightedList = "LargeShips 10";
         refObjectName = "REF_Player";   
         offset = "2000 2200";  
         creationChance = 1;  
         objectCount = "1";
         factionOverride = "Civ";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet Civ_attacker"; 
         objectFuncs["Spawn", 1]   = "AddTargetMarker"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName JunkYardLastCap 0"; 
         mountRefObjectNames = "REF_bossShip_Loc";          
      };
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "MediumShips 10";
          refObjectName = "REF_bossShip";   
          offset = "500 600";  
          creationChance = 1;  
          objectCount = "2";
          factionOverride = "Civ";
          respectShipCount = 5;
          hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
          objectFuncs["Spawn", 0]   = "QAI_AddToSet Civ_attacker";      
      }; 
   }; 
   
   new ScriptGroup("JunkYardLastCap")
   {
      maxWaves = 1; 
      waveContext[1] = "lastCap";
      WaveMissionTrackers["active", 1] = "2";  
      WaveMissionTrackers["remove", 1] = "1";     
      new ScriptGroup("REF_stash" : MO_CollectProp)
      {   
         offset = "0 0";   
         refObjectName = "REF_bossShip_Loc"; 
         
         pickupWL = "S2_capPartPickup 10"; 
         
         objectFuncs["Spawn", 0] = "AddGoToMarker";   
         objectFuncs["Pickup", 0] = "CallInstanceFunc StartWaveName QuestEnding 1000";              
         
         objectCount = "1";  
         pickupFaction = "Pirate";
      };
   }; 
   
   new ScriptGroup("PickupPissoff")
   {
      maxWaves = -1; 
      waveTimedCallbacks[1, 0] = "1000 callQuestFunction SEQ_activateSequence Sector2CapacitorStolen"; 
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations civ -1";
   }; 
      
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 

function cleanupStorage()
{
   if ( isObject($FactionManager) )
      $FactionManager.delete();
   
   schedule(getRandom(30000, 180000), 0, cleanupStorage);
}

if ( !isFunction(resyncFrontEnd) )
   schedule(getRandom(30000, 180000), 0, cleanupStorage);

///////////////////////////////////////////
// Reactor Grab ///////////////////////////
///////////////////////////////////////////
DW("Sector2");

new ScriptGroup(S2_ReactorGrab : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Sector2_Reactor";
   DeployData["InstanceName"] = "Secret Science Facility"; 
   
   questType   = "Event";   //just have to get there. 
   
   SelectionData["ObjectivesComplete"]  = "S2_GetCapacitors"; 
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "BATTERIES NOT INCLUDED";  
   description = "Assault the science base until they give up the Titan reactor.";

   parentQuest = "";
   childQuests = "";
   
   Rewards["Complete", "Resource"] = "Exact 750";
   Rewards["Complete", "Data"] = "Exact 115";
  
   Callbacks["Selected"]      = ""; //is events    
   Callbacks["BeaconArrival"] = "S2_ReactorGrabStarted";
   Callbacks["Complete"]      = "S2_ReactorGrabComplete";   
 
   //Placeholder
   initialWaves = "CivScienceBase ScienceBase_Defenders ScienceBase_HeavyDefender";   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionText["initial"] = "MT_ATTACK ASSAULT THE SCIENCE BASE";
   missionText["pickup"] = "MT_GOTO TAKE THE REACTOR";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "pickup";
 
   new ScriptGroup("CivScienceBase")
   {
      maxWaves = 1; 
      WaveMissionTrackers["active", 1] = "0";    
      new ScriptGroup("REF_scienceBase" : MO_Ships) 
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "4500 4600";
         objectCount = "1 1";
         factionOverride = "Civ";
         refObjectName = "REF_Beacon";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";   
         shipDesignWL = "QuasarBase 10"; 
         objectFuncs["Damage", 0]  = "isHealthLessThen 0.75 true StartWaveName ReactorPickup 0";
         objectFuncs["Death", 0]  = "CallInstanceFunc StartWaveName ReactorPickup 0";   
         new ScriptGroup() 
         {                                      
            instanceObjectWeightedList = "RegenSwarmMineField";
            offset = "0 0"; 
            creationChance = 1;  
            objectCount = "1";
            factionOverride = "Civ";
            refObjectName = "REF_scienceBase";   
         }; 
      };
   };
   
   new ScriptGroup("ScienceBase_Defenders")
   {
      maxWaves = 4; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName ScienceBase_Defenders 12000";
      new ScriptGroup("REF_baseDefenders" : MO_Ships) 
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "500 1000";
         objectCount = "1 2";
         factionOverride = "Civ";
         refObjectName = "REF_scienceBase";
         onInitializedFunc[0] = "AddToHealthCallbackSet Enemies"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
      };
   };
   
   new ScriptGroup("ScienceBase_HeavyDefender")
   {
      maxWaves = 3; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName ScienceBase_HeavyDefender 24000";
      new ScriptGroup("REF_baseDefenders" : MO_Ships) 
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "500 1000";
         objectCount = "1";
         factionOverride = "Civ";
         refObjectName = "REF_scienceBase";
         onInitializedFunc[0] = "AddToHealthCallbackSet Enemies"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
      };
   };
   
   new ScriptGroup("ReactorPickup")
   {
      maxWaves = 1;
      waveContext[1] = "pickup";
      
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_scienceBase RemoveObjectiveMarker_ALL";
      waveTimedCallbacks[1, 1] = "0 callQuestFunction SEQ_activateSequence Sector2ReactorDrop";     
      
      WaveMissionTrackers["active", 1] = "1";    
      WaveMissionTrackers["remove", 1] = "0";    
        
      new ScriptGroup("REF_reactorPickup" : MO_CollectProp)
      {   
         offset = "0 0";   
         refObjectName = "REF_scienceBase";
         
         pickupWL = "S2_reactorPickup 10";  
         
         objectFuncs["Spawn", 1] = "AddGoToMarker";                
         objectFuncs["Pickup", 1] = "evalTrackingSet pickupSet collected 1 StartWaveName QuestEnding 1000"; 
         
         objectCount = "1 1";  
         pickupFaction = "Pirate";    
      };
   };
      
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 

///////////////////////////////////////////
// Expansion Favor
///////////////////////////////////////////

new ScriptGroup(S2_ExpansionFavor : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Sector2_Shipyard";
   DeployData["InstanceName"] = "UTA Road Block";
   
   questType   = "Event";  
   
   SelectionData["ObjectivesComplete"]  = "S2_GetReactor"; 
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "TRAFFIC STOPS";  
   description = "There is a UTA fleet patrolling the system conducting disruptive traffic stops.  This makes rush hour unbearable.  They must be destroyed..";

   parentQuest = "";
   childQuests = "";  //This may be a mission chain.
   
   Rewards["Complete", "Resource"] = "800";
   Rewards["Complete", "Data"] = "Exact 125";
  
   Callbacks["Selected"]      = ""; //is events    
   Callbacks["BeaconArrival"] = "S2_ExpansionFavorStarted";
   Callbacks["Complete"]      = "S2_ExpansionFavorComplete";  
   
   missionText["initial"] = "MT_ATTACK DESTROY THE UTA ROAD BLOCK";
   
   missionTrackerData[0] = "initial";
 
   //Placeholder
   initialWaves = "UTA_RoadBlock";   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
         
   new ScriptGroup("UTA_RoadBlock")
   {
      maxWaves = 1;
      WaveMissionTrackers["active", 1] = "0";     
      healthCallbackSets = "Enemies";
      setHealthCallback[1, "Enemies", 0] = "0 StartWaveName QuestEnding 2000";
      
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "6500 7000";  
          creationChance = 1;  
          objectCount = "1 1";
          factionOverride = "Terran";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
          objectFuncs["Spawn", 0]   = "AddTargetMarker";   
          shipDesignWL = "BigBrotherShip 10";
         new ScriptGroup() 
         {                                      
            instanceObjectWeightedList = "SmallShips 10"; 
            offset = "0 0";  
            creationChance = 1;  
            objectCount = "5 5";
            factionOverride = "Terran"; 
            onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
            objectFuncs["Spawn", 0]   = "AddTargetMarker";      
         };           
      };      
   };
      
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 

///////////////////////////////////////////
// Shipyard
///////////////////////////////////////////

new ScriptGroup(S2_Shipyard : QuestBase)
{
   addToDatabase = true;  //Important 
   allowAmbientHunters = false;
   
   warningTags = "CRIT";
   
   locksScreenSelector = true; //don't flee during this time, bad idea
   
   DeployData["StarType"]     = "Sector2_Shipyard";
   DeployData["InstanceName"] = "Black Market Shipyard";
   
   questType   = "Event";   //just have to get there. 
   
   gameOverOnFail = true;
   
   SelectionData["ObjectivesComplete"]  = "S2_ExpansionFavor"; 
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "BIG FISH";  
   description = "Work with the black market shipyard to upgrade the Clockwork.";

   parentQuest = "";
   childQuests = "";  //This may be a mission chain.
   
   Rewards["Complete", "Resource"] = "Exact 1000";
   Rewards["Complete", "Data"] = "Exact 150";
  
   Callbacks["Selected"]      = ""; //is events    
   Callbacks["BeaconArrival"] = "S2_Shipyard_BeaconArrive";
   Callbacks["Complete"]      = "S2_ShipyardComplete";   
 
   //Placeholder
   initialWaves = "REF_FakeMothership";   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";    
   
   missionText["initial"] = "MT_GOTO RENDEZVOUS WITH THE CLOCKWORK";
   missionText["defendMother"] = "MT_DEFEND PROTECT THE CLOCKWORK";
   missionText["motherHealth"] = "MT_INFO CLOCKWORK HEALTH";
   missionText["motherFail"] = "MT_INFO CLOCKWORK IS DESTROYED";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "defendMother";
   missionTrackerData[2] = "motherHealth MT_HEALTHBAR motherset";
   
   new ScriptGroup("REF_FakeMothership")
   {
      maxWaves = 1;
      WaveMissionTrackers["active", 1] = "0";  
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand fakeMothershipSet SetTactic TP_Engines TP_EnginesOff"; 
      //waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand fakeMothershipSet SetTactic TP_Shields TP_ShieldsDown";   
      new ScriptGroup("REF_FakeMotherShip_Trigger" : MO_Trigger)
      {    
         triggerRadius = 600;
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet setTriggerActive REF_FakeMotherShip_Trigger 0";
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet StartWaveName UTA_AttackFleet 0";                                      
      };   
      new ScriptGroup() 
      {    
         refObjectName = "REF_Beacon";                                  
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "3000 3000";  
         creationChance = 1;  
         objectCount = "1 1";
         factionOverride = "Pirate";
         shipDesignWL = "ClockworkStation_01_Half 10"; 
         mountRefObjectNames = "REF_FakeMotherShip_Trigger"; 
         objectFuncs["Spawn", 0]   = "AddDefendMarker"; 
         objectFuncs["Spawn", 1] = "addToTrackingSet motherset";   
         objectFuncs["Spawn", 2]   = "QAI_AddToSet fakeMothershipSet";  
      };      
   };
         
   new ScriptGroup("UTA_AttackFleet")
   {
      maxWaves = 1;
      
      WaveMissionTrackers["active", 1] = "1 2";
      WaveMissionTrackers["remove", 1] = "0";  
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand UTA_attackFleetSet MoveTo REF_FakeMotherShip_Trigger 0";       
      waveTimedCallbacks[1, 1] = "15000 StartWaveName UTA_respawnFleet 0";
      waveTimedCallbacks[1, 2] = "70000 StartWaveName UTA_respawnFleet 0";
      waveTimedCallbacks[1, 3] = "1000 callQuestFunction ChangePlayerRelations terran -5"; //piss off UTA

      new ScriptGroup("REF_Flagship") 
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "8500 9000"; 
         refObjectName = "REF_FakeMotherShip_Trigger";    
         creationChance = 1;  
         objectCount = "1 1";
         factionOverride = "Terran";
         shipDesignWL = "HammerHeadShip_Jamison 10";
         objectFuncs["Spawn", 0] = "QAI_AddToSet UTA_attackFleetSet";
         objectFuncs["Spawn", 1] = "callFunctionWithObject S2_ShipyardBattle_ScriptEvent";   
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestEnding 5000";
         new ScriptGroup() 
         {                                      
             instanceObjectWeightedList = "SmallShips 10"; 
             offset = "0 0";  
             refObjectName = "REF_Flagship";   
             creationChance = 1;  
             objectCount = "3";
             factionOverride = "Terran";  
             objectFuncs["Spawn", 0] = "QAI_AddToSet UTA_attackFleetSet";  
         };           
      };      
   };
   
   new ScriptGroup("UTA_respawnFleet")
   {
      maxWaves = 2;
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AverageShips 10"; 
         offset = "5000 5500";  
         refObjectName = "REF_FakeMotherShip_Trigger";    
         creationChance = 1;  
         objectCount = "2";
         factionOverride = "Terran";
         objectFuncs["Spawn", 0] = "QAI_AddToSet UTA_attackFleetSet";         
      };      
   };
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand UTA_attackFleetSet SetTactic TP_Retreat TP_RetreatOn"; 
      waveTimedCallbacks[1, 1] = "7000 StartWaveName QuestComplete 0";
   }; 
}; 



