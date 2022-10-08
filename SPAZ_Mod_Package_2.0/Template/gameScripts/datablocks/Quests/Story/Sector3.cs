
///////////////////////////////////////////
// Uber Mining Mission ////////////////////
///////////////////////////////////////////

new ScriptGroup(S3_UberColonyQuest : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Sector3_UberColony";
   DeployData["InstanceType"]   = "Infrastructure"; //this mission happesn at the base
   
   questType   = "Ambient";   
   
   SelectionData["ObjectivesComplete"]  = "Grab_Black_Box"; 
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
   
   gameOverOnFail = true;
       
   title = "PRISON BREAK";  
   description = "Attack the prison base until they release Mac.";

   parentQuest = "";
   childQuests = "";  //This may be a mission chain.
   
   Rewards["Complete", "Resource"] = "Exact 1250";
   Rewards["Complete", "Data"] = "Exact 150";
   Rewards["Complete", "Spec"] = "Random";
  
   Callbacks["BeaconArrival"] = "";   
   Callbacks["Complete"]      = "S3_UberColonyComplete";   
 
   initialWaves = "WAVE_prisonSetup";   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE PRISON";
   missionText["collectPods"] = "MT_GOTO COLLECT THE PRISONERS";
   missionText["podCount"] = "MT_INFO PODS REMAINING:";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "collectPods";
   missionTrackerData[2] = "podCount MT_SETCOUNTER pickupSet";
         
   new ScriptGroup("WAVE_prisonSetup")
   {
      maxWaves = 1;   
      WaveMissionTrackers["active", 1] = "0"; 
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_InstanceFocus AddTargetMarker";         
   };
   
   new ScriptGroup("WAVE_dumpPrisionPods")
   {
      maxWaves = 1;  
       
      WaveMissionTrackers["active", 1] = "1 2"; 
      WaveMissionTrackers["remove", 1] = "0"; 
      
      waveContext[1] = "collectPods";
      
      new ScriptGroup("REF_prisonPodPickups" : MO_CollectProp)
      {   
         offset = "0 0";   
         refObjectName = "REF_instanceFocus";
         
         pickupWL = "S3_PrisonPod 10"; 
         pickupImpulse = 100; 
         
         objectFuncs["Spawn", 1] = "AddGoToMarker";           
         objectFuncs["Pickup", 0] = "evalTrackingSet pickupSet collected 5 StartWaveName QuestEnding 1000"; 
         
         objectCount = "5 5";  
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
// Uber Mining Mission ////////////////////
///////////////////////////////////////////

new ScriptGroup(S3_TrojanHorse : QuestBase)
{
   addToDatabase = true;  //Important 
   allowAmbientHunters = false;
   
   warningTags = "CRIT";
   
   DeployData["StarType"]     = "Sector3_UberMining";
   DeployData["InstanceName"] = "SHIP TRADE ROUTE";
   
   questType   = "Event";   
   
   SelectionData["ObjectivesComplete"]  = "HeadForUberMining"; 
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
   
   gameOverOnFail = true;
       
   title = "TROJAN HORSE";  
   description = "Hijack a civilian transport ship in order to plant operatives on board the processing base.  The transport will likely be guarded by UTA ships.";

   parentQuest = "";
   childQuests = "S3_UberMiningQuest";  //This may be a mission chain.
   
   Rewards["Complete", "Resource"] = "Exact 1300";
   Rewards["Complete", "Data"] = "Exact 160";
   
   Callbacks["BeaconArrival"] = "S3_UberMiningStart";  
   Callbacks["Complete"]      = "S3_UberMiningComplete";   
 
   initialWaves = "transportGuards WAVE_scoutGroup WAVE_scoutGroup WAVE_scoutGroup WAVE_scoutGroup"; 
     
   initialTimedCallbacks[0] = "0 callQuestFunctionOnInstance SNEAK_SetCoverValue 15";
   initialTimedCallbacks[1] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionText["initial"] = "MT_GOTO SNEAK ON BOARD TRANSPORT SHIP";
   missionText["sneakInfo"] = "MT_HINT USE CLOAKING TO AVOID DETECTION";
   missionText["sneakMeter"] = "MT_INFO SNEAK METER";
   missionText["returnHome"] = "MT_GOTO ESCORT TRANSPORT TO BEACON";
   missionText["stayNear"] = "MT_HINT STAY NEAR THE TRANSPORT";
   missionText["questFail"] = "MT_FAIL THE TRANSPORT WAS DESTROYED";
   missionText["spottedFail"] = "MT_FAIL YOUR COVER WAS BLOWN";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "sneakInfo";
   missionTrackerData[2] = "sneakMeter MT_METER_EVAL SNEAK_getCoverValue";
   missionTrackerData[3] = "returnHome";
   missionTrackerData[4] = "stayNear";
         
   new ScriptGroup("transportGuards")
   {
      maxWaves = 1;
      WaveMissionTrackers["active", 1] = "0 1 2"; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_FRIEND;  
      waveRelations[1, 1] = "Terran Pirate" SPC $FactionRelation_HATE;
      waveRelations[1, 2] = "Pirate Civ" SPC $FactionRelation_FRIEND;  
 
      new ScriptGroup("REF_homeTrigger" : MO_Trigger) 
      {  
         refObjectName = "REF_Beacon"; 
         triggerRadius = 500;
         triggerFuncs[0] = "InstanceFunc 1 TransShipSet StartWaveName WAVE_exitComplete 0";                            
      };          
       
      new ScriptGroup("REF_TransTrigger" : MO_Trigger) 
      {  
         triggerRadius = 1000;
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_hijackComplete 0"; 
         triggerFuncs[1] = "ObjectFunc 1 PlayerSet fireStoryProbe REF_TransTrigger";  
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet setTriggerActive REF_TransTrigger 0";
         triggerFuncs[3] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_escortFollow 0";                              
      };                     
      new ScriptGroup("REF_TransShip" : MO_Ships) 
      {   
         instanceObjectWeightedList = "spawnMyShip";
         offset = "7000 7000";  
         objectCount = "1 1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon"; 
         shipDesignWL = "FreighterShip 10";   
         hullBitMatching = $SST_HULL_INF;  
         
         objectFuncs["Spawn", 0] = "QAI_AddToSet TransShipSet";    
         objectFuncs["Spawn", 1]   = "AddDefendMarker";  
         objectFuncs["Spawn", 2]   = "leashToPlayer 500"; 
           
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 questFail";  
         
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName QuestComplete";  
         
         mountRefObjectNames = "REF_TransTrigger";                
      }; 
      new ScriptGroup(UTAMines_01 : MO_Mines) 
      {                                      
         objectCount = "1"; 
         factionOverride = "terran";
         refObjectName = "REF_TransShip"; 
         instanceObjectWeightedList = "ScannerSwarmMineField_Large";
      }; 
      new ScriptGroup(REF_TransDefenders : MO_Ships) 
      {   
         instanceObjectWeightedList = "LargeShips 10";
         offset = "500 600";  
         objectCount = "2 2";
         factionOverride = "Terran";                     
         refObjectName = "REF_TransShip";   
         objectFuncs["Spawn", 0]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";                     
      };    
   };
   
   new ScriptGroup("WAVE_scoutGroup")
   {
      maxWaves = -1;
      new ScriptGroup(REF_TransScout : MO_Ships) 
      {   
         instanceObjectWeightedList = "TinyShips 10";
         offset = "2000 3000";  
         objectCount = "1 1";
         factionOverride = "Terran";                     
         refObjectName = "REF_TransShip";   
         objectFuncs["Spawn", 0]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";                     
      };    
   };
   
   new ScriptGroup("WAVE_hijackComplete")
   {
      maxWaves = 1;
      waveContext[1] = "returnHome";  
      WaveMissionTrackers["remove", 1] = "0 1"; 
      WaveMissionTrackers["active", 1] = "3 4 2"; 
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_homeTrigger AddGoToMarker";  
   };
   
   new ScriptGroup("WAVE_escortFollow")
   {
      maxWaves = 1;
      waveTimedCallbacks["all", 0] = "0 QAI_SetAICommand TransShipSet MoveTo REF_Beacon 0"; 
      waveTimedCallbacks["all", 1] = "0 QAI_SetAICommand TransShipSet SetTactic TP_Stance TP_Passive";
   };
   
   new ScriptGroup("WAVE_exitComplete")
   {
      maxWaves = 1;   
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand TransShipSet SetTactic TP_Retreat TP_RetreatOn";          
   };
   
   new ScriptGroup("WAVE_spotted")
   {
      maxWaves = 1;   
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestFail 0 spottedFail";            
   };
}; 

///////////////////////////////////////////
// Uber Mining Mission ////////////////////
///////////////////////////////////////////
DW("Sector3");

new ScriptGroup(S3_UberMiningQuest : QuestBase)
{
   addToDatabase = true;  //Important 
   allowAmbientHunters = false;
   
   warningTags = "CRIT";
   
   DeployData["StarType"]     = "Sector3_UberMining";
   DeployData["InstanceType"]   = "Infrastructure"; //this mission happesn at the base
   
   questType   = "Ambient";   
   
   SelectionData["ObjectivesComplete"]  = "UberMiningFavor1"; 
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
   
   gameOverOnFail = true;
       
   title = "THE HIJACK";  
   description = "Escort the hijacked civilian transport until it reaches the processing base.  Once the operatives are onboard, they will begin hacking the system to gain control of the base.";

   parentQuest = "S3_TrojanHorse";
   childQuests = "";  //This may be a mission chain.
   
   Rewards["Complete", "Resource"] = "Exact 1500";
   Rewards["Complete", "Data"] = "Exact 165";
   Rewards["Complete", "Spec"] = "Random";
  
   Callbacks["BeaconArrival"] = "S3_HijackMiningBaseStart";   
   Callbacks["Complete"]      = "S3_HijackMiningBaseComplete";   
 
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "4000 StartWaveName CIV_HIJACKSHIP";
   
   missionText["initial"] = "MT_DEFEND ESCORT THE TRANSPORT";
   missionText["hackText"] = "MT_DEFEND DEFEND THE BASE";
   missionText["hackTime"] = "MT_INFO HACK TIME";
   missionText["baseHealth"] = "MT_INFO BASE HEALTH";
   missionText["pickupMac"] = "MT_GOTO PICK UP MAC";
   missionText["questFail"] = "MT_FAIL THE TRANSPORT WAS DESTROYED";
   missionText["baseDestroyed"] = "MT_FAIL THE BASE WAS DESTROYED";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "hackText";
   missionTrackerData[2] = "hackTime MT_TIMERTEXT 140";
   missionTrackerData[3] = "baseHealth MT_HEALTHBAR UberMiningBaseSet";
   missionTrackerData[4] = "pickupMac";
   
   new ScriptGroup("CIV_HIJACKSHIP")
   {
      maxWaves = 1; 
      
      waveRelations[1, 0] = "Pirate Civ" SPC $FactionRelation_MYFACTION;   //RLBRLB special case where civs can not be shot 
      
      WaveMissionTrackers["active", 1] = "0";  
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand DropShipSet SetTactic TP_Collect TP_NoCollect";
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand DropShipSet SetTactic TP_Stance TP_Passive"; 
      waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand DropShipSet MoveTo REF_InstanceFocus 0"; 
      waveTimedCallbacks[1, 3] = "0 QAI_SetAICommand DropWartOutSet SetTactic TP_Retreat TP_RetreatOn";   
       
      new ScriptGroup(REF_DropTrig : MO_Trigger) //we will use this to turn it on and off maybe? 
      {                                    
         triggerFuncs[0] = "ObjectFunc 1 DropShipSet QAI_AddToSet DropWartOutSet"; 
         triggerFuncs[1] = "InstanceFunc 1 DropShipSet callOnSubObjects REF_instanceFocus Ship_RequestCrew";   
         triggerFuncs[2] = "InstanceFunc 1 DropShipSet setTriggerActive REF_DropTrig 0";  
         
         refObjectName = "REF_InstanceFocus";
      }; 
      new ScriptGroup(REF_ShipArea : MO_Trigger) 
      {                              
      };                       
      new ScriptGroup(REF_EscortShip : MO_Ships) 
      {   
         instanceObjectWeightedList = "spawnMyShip";
         offset = "100 200";  
         objectCount = "1 1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";   
         
         shipDesignWL = "FreighterShip 10"; 

         mountRefObjectNames = "REF_ShipArea"; 
         hullBitMatching = $SST_HULL_INF;    
         
         objectFuncs["Spawn", 0] = "QAI_AddToSet DropShipSet"; 
         objectFuncs["Spawn", 1]   = "AddDefendMarker";   
         objectFuncs["Spawn", 2] = "addToTrackingSet DropShipSet";  
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName CIV_hackStation"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 questFail";                     
      };          
   };
   
   new ScriptGroup("CIV_hackStation")
   {
      maxWaves = 1; 
      
      waveContext[1] = "hackText";      
      
      WaveMissionTrackers["remove", 1] = "0";  
      WaveMissionTrackers["active", 1] = "1 2 3"; 
      
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE; 
      
      waveTimedCallbacks[1, 0] = "0 callQuestFunction S3_HijackMiningBeginHacking";   
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects REF_InstanceFocus AddDefendMarker";
      waveTimedCallbacks[1, 2] = "0 callOnSubObjects REF_InstanceFocus QAI_AddToSet defendStationQAISet";
      waveTimedCallbacks[1, 3] = "3500 StartWaveName UTA_attackFleet_small 0";
      waveTimedCallbacks[1, 4] = "8000 StartWaveName UTA_attackFleet_large 0";      
      waveTimedCallbacks[1, 5] = "140000 StartWaveName WAVE_pickupMac 0";       
   };
   
   new ScriptGroup("WAVE_pickupMac")
   {
      maxWaves = 1; 
      
      waveContext[1] = "pickupMac"; 
       
      WaveMissionTrackers["active", 1] = "4"; 
      WaveMissionTrackers["remove", 1] = "1 2 3"; 
      
      waveTimedCallbacks[1, 0] = "0 callQuestFunction SEQ_activateSequence Sector3UberMiningComplete";   
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects REF_InstanceFocus RemoveObjectiveMarker_ALL";

      new ScriptGroup("REF_prisonPodPickups" : MO_CollectProp)
      {   
         offset = "0 0";   
         refObjectName = "REF_instanceFocus";
         
         pickupWL = "S3_PrisonPod 10"; 
         pickupImpulse = 100; 
         
         objectFuncs["Spawn", 0] = "AddGoToMarker";           
         objectFuncs["Pickup", 0] = "CallInstanceFunc StartWaveName QuestEnding 1000";   
         
         objectCount = "1";  
         pickupFaction = "Pirate";    
      };           
   };
      
   new ScriptGroup("UTA_attackFleet_small")
   {
      maxWaves = -1;
      healthCallbackSets = "enemies";
      setHealthCallback["All", "enemies", 0] = "0 StartWaveName UTA_attackFleet_large 6000";
      waveTimedCallbacks["All", 0] = "0 QAI_SetAICommand BaseAttackSet SetTactic TP_Stance TP_Defensive"; 
      waveTimedCallbacks["All", 1] = "0 QAI_SetAICommand BaseAttackSet MoveTo REF_InstanceFocus 0";
      waveTimedCallbacks["All", 2] = "0 QAI_SetAICommand BaseAttackSet Attack defendStationQAISet";  //unsure if this is doing anything
      new ScriptGroup(REF_TransDefenders1 : MO_Ships) 
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "5000";  
         objectCount = "2";
         factionOverride = "Terran";                     
         refObjectName = "REF_InstanceFocus"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemies"; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet BaseAttackSet";                   
      };    
   };
   new ScriptGroup("UTA_attackFleet_large")
   {
      maxWaves = -1;
      healthCallbackSets = "enemies";
      setHealthCallback["All", "enemies", 0] = "0 StartWaveName UTA_attackFleet_large 10000";
      waveTimedCallbacks["All", 0] = "0 QAI_SetAICommand BaseAttackSet SetTactic TP_Stance TP_Defensive"; 
      waveTimedCallbacks["All", 1] = "0 QAI_SetAICommand BaseAttackSet MoveTo REF_InstanceFocus 0"; 
      waveTimedCallbacks["All", 3] = "0 QAI_SetAICommand BaseAttackSet Attack defendStationQAISet";  //unsure if this is doing anything
      new ScriptGroup(REF_TransDefenders2 : MO_Ships) 
      {   
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "7500";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_InstanceFocus"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemies"; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet BaseAttackSet";                   
      };    
   };
   
   new ScriptGroup("WAVE_baseDestroyed")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestFail 0 baseDestroyed";
   }; 
   
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 

///////////////////////////////////////////
// Uber SCIENCE Mission ///////////////////
///////////////////////////////////////////

new ScriptGroup(S3_UberScienceQuest : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Sector3_UberScience";
   DeployData["InstanceName"] = "PURE REZ DEPOSIT";
   
   questType   = "Inf";   
   
   SelectionData["ObjectivesComplete"]  = "UberMiningFavor2"; 
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "THE REAL DEAL";  
   description = "The UTA have overlooked a potential vein of Rez.  Harvest the pure Rez deposits to find out what unknown properties it may contain.";

   parentQuest = "";
   childQuests = "";  //This may be a mission chain.
   
   Rewards["Complete", "Resource"] = "Exact 1750";
   Rewards["Complete", "Data"] = "Exact 170";
  
   Callbacks["Selected"]      = "S3_UberScienceSelected";     
   Callbacks["BeaconArrival"] = "S3_UberScienceStarted";
   Callbacks["Complete"]      = "S3_UberScienceComplete";   
 
   initialWaves = "PreSetup_RezField WAVE_rock1 WAVE_rock2 WAVE_rock3 WAVE_rock4 WAVE_rock5 WAVE_rock6 WAVE_rock7 WAVE_rock8";   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick rezPickupNeeded 24";
   
   missionText["initial"] = "MT_ATTACK HARVEST THE REZ";
   missionText["deposits"] = "MT_INFO REZ DEPOSITS:";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "deposits MT_TICKCOUNTER rezPickupNeeded";
   
   new ScriptGroup("PreSetup_RezField")
   {
      maxWaves = 1;  
      WaveMissionTrackers["active", 1] = "0 1";
   };
   
   //rez rocks
   new ScriptGroup("WAVE_rock1")
   {
      maxWaves = 1;  
      new ScriptGroup("REF_S3_rock1") 
      {                                      
         instanceObjectWeightedList = "AsteroidCluster_alien_crystal";
         offset = "3000 6500";
         refObjectName = "REF_Beacon";  
         creationChance = 1;
         minDistanceOverride = 0;
         maxDistanceOverride = 0;
         objectCount = "1";
         objectFuncs["Spawn", 0] = "AddTargetMarker";   
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_pickup1 0";      
      };
   };
   
   new ScriptGroup("WAVE_rock2" : WAVE_rock1)
   {
      new ScriptGroup("REF_S3_rock2" : REF_S3_rock1) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_pickup2 0";                                          
      };
   };
   new ScriptGroup("WAVE_rock3" : WAVE_rock1)
   {
      new ScriptGroup("REF_S3_rock3" : REF_S3_rock1) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_pickup3 0";                                          
      };
   };
   new ScriptGroup("WAVE_rock4" : WAVE_rock1)
   {
      new ScriptGroup("REF_S3_rock4" : REF_S3_rock1) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_pickup4 0";                                          
      };
   };
   new ScriptGroup("WAVE_rock5" : WAVE_rock1)
   {
      new ScriptGroup("REF_S3_rock5" : REF_S3_rock1) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_pickup5 0";                                          
      };
   };
   new ScriptGroup("WAVE_rock6" : WAVE_rock1)
   {
      new ScriptGroup("REF_S3_rock6" : REF_S3_rock1) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_pickup6 0";                                          
      };
   };
   new ScriptGroup("WAVE_rock7" : WAVE_rock1)
   {
      new ScriptGroup("REF_S3_rock7" : REF_S3_rock1) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_pickup7 0";                                          
      };
   };
   new ScriptGroup("WAVE_rock8" : WAVE_rock1)
   {
      new ScriptGroup("REF_S3_rock8" : REF_S3_rock1) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_pickup8 0";                                          
      };
   };
   
   //pickups
   new ScriptGroup("WAVE_pickup1")
   {
      maxWaves = 1;  
      new ScriptGroup("REF_S3_pickup1" : MO_pickups) 
      {                                      
         offset = "0 0";                                  
         objectCount = "3";
         refObjectName = "REF_S3_rock1"; 
         pickupWL = "S3_PureRezPickup 10";  
         pickupImpulse = 200;    
         objectFuncs["Spawn", 0] = "AddGoToMarker";       
         objectFuncs["Pickup", 0] = "CallInstanceFunc TS_addTrackingTick rezPickupNeeded -1";
         objectFuncs["Pickup", 1] = "CallInstanceFunc TS_evalTrackingTick rezPickupNeeded 0 StartWaveName QuestEnding";     
      };
   };
   
   new ScriptGroup("WAVE_pickup2" : WAVE_pickup1)
   {
      new ScriptGroup("REF_S3_pickup2" : REF_S3_pickup1) 
      {                                      
         refObjectName = "REF_S3_rock2";          
      };
   };
   new ScriptGroup("WAVE_pickup3" : WAVE_pickup1)
   {
      new ScriptGroup("REF_S3_pickup3" : REF_S3_pickup1) 
      {                                      
         refObjectName = "REF_S3_rock3";          
      };
   };
   new ScriptGroup("WAVE_pickup4" : WAVE_pickup1)
   {
      new ScriptGroup("REF_S3_pickup4" : REF_S3_pickup1) 
      {                                      
         refObjectName = "REF_S3_rock4";          
      };
   };
   new ScriptGroup("WAVE_pickup5" : WAVE_pickup1)
   {
      new ScriptGroup("REF_S3_pickup5" : REF_S3_pickup1) 
      {                                      
         refObjectName = "REF_S3_rock5";          
      };
   };
   new ScriptGroup("WAVE_pickup6" : WAVE_pickup1)
   {
      new ScriptGroup("REF_S3_pickup6" : REF_S3_pickup1) 
      {                                      
         refObjectName = "REF_S3_rock6";          
      };
   };
   new ScriptGroup("WAVE_pickup7" : WAVE_pickup1)
   {
      new ScriptGroup("REF_S3_pickup7" : REF_S3_pickup1) 
      {                                      
         refObjectName = "REF_S3_rock7";          
      };
   };
   new ScriptGroup("WAVE_pickup8" : WAVE_pickup1)
   {
      new ScriptGroup("REF_S3_pickup8" : REF_S3_pickup1) 
      {                                      
         refObjectName = "REF_S3_rock8";          
      };
   };
         
   //attackers
   new ScriptGroup("Zom_attackFleet")
   {
      maxWaves = -1;
      new ScriptGroup(REF_ZomAttackers : MO_Ships) 
      {   
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 3";
         offset = "800 1000";  
         objectCount = "1 2";
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Player";
         respectShipCount = 4;                
      };    
   }; 
   
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   };
}; 
























