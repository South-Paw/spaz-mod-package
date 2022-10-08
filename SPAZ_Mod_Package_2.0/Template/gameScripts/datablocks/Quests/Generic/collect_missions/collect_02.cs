
///////////////////////////////////////////////////////////
// COLLECT 02
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Collect_02 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV";
       
   title = "SUPPLY THIEVES";  
   description = "The Civilians are trying to take UTA supplies.  Bounties will be awarded for destroying the thieves.";
  
   initialWaves = "WAVE_Items MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO GO TO SUPPLY FIELD";
   missionText["defend"] = "MT_DEFEND PROTECT SUPPLY FIELD";
   missionText["failed"] = "MT_FAIL YOU FAILED TO STOP THE THIEVES";
   missionText["stationLost"] = "MT_FAIL YOUR EMPLOYERS ARE DEAD";
   missionText["remaining"] = "MT_INFO REMAINING ITEMS:";
   missionText["timeLimit"] = "MT_INFO DEFEND TIME";
   
   initialTimedCallbacks[0] = "3000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND; 
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "defend";
   missionTrackerData[2] = "remaining MT_SETCOUNTER pickupSet";
   missionTrackerData[3] = "timeLimit MT_TIMERTEXT 125";
   
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   Rewards["Complete", "Security"]         = 1;
   Rewards["Complete", "Bounty"] = "low"; 
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   new ScriptGroup(WAVE_Items)
   {
      maxWaves = 1;
      WaveMissionTrackers["active", 1] = "0";   
      new ScriptGroup("uta_station" : MO_Ships) 
      {
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "2500 2600";  
         objectCount = "1 1";              
         refObjectName = "REF_Beacon";
         shipDesignWL = "OutpostBase 10 Pirate01Base 8";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_RetreatAll_StationLost";
         objectFuncs["Spawn", 0] = "AddDefendMarker";  
         new ScriptGroup("REF_stash" : MO_CollectProp_Scatter)
         {    
            offset = "100 600";  
            refObjectName = "";       
            objectFuncs["Pickup", 0] = "evalTrackingSetCount pickupSet 0 StartWaveName WAVE_RetreatAll_Collected"; 
            objectFuncs["Pickup", 1] = "collectorFunk QAI_AddToSet ThievesFleeSet"; 
            objectCount = "12 12";  
            pickupFaction = "Civ";               
         };
         new ScriptGroup("collectStartTrigger" : MO_Trigger) 
         {   
            offset = "0 0"; 
            refObjectName = ""; 
            
            triggerRadius = 800;    
            
            triggerFuncs[0] = "InstanceFunc 1 PlayerSet setTriggerActive collectStartTrigger 0";  
            triggerFuncs[1] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Thieves 0";
            triggerFuncs[2] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Thieves 10000";
            triggerFuncs[3] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Thieves 30000";   
            triggerFuncs[4] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Thieves 40000";
            triggerFuncs[5] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Thieves 60000";
            triggerFuncs[6] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Thieves 70000";
            triggerFuncs[7] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Thieves 80000";
            triggerFuncs[8] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Stop 120000";                           
         };               
      };            
   };

   new ScriptGroup(WAVE_Thieves)
   {
      maxWaves = -1; 
      waveContext[1] = "defend";
      
      WaveMissionTrackers["active", 1] = "1 2 3"; 
      WaveMissionTrackers["remove", 1] = "0"; 
      
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects uta_station RemoveObjectiveMarker_ALL";
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects REF_stash AddDefendMarker";
      
      waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand PickupThieves MoveTo REF_stash"; 
      waveTimedCallbacks[1, 3] = "0 QAI_SetAICommand PickupThieves SetTactic TP_Stance TP_Passive"; 
      
      waveTimedCallbacks[1, 4] = "0 QAI_SetAICommand ThievesFleeSet SetTactic TP_Collect TP_NoCollect";
      waveTimedCallbacks[1, 5] = "0 QAI_SetAICommand ThievesFleeSet SetTactic TP_Retreat TP_RetreatOn"; 
      
      waveTimedCallbacks[1, 6] = "0 QAI_SetAICommand PickupThieves SetTactic TP_Shields TP_ShieldsDown"; //makes them easier to kill off
      
      new ScriptGroup(CivShips_01 : MO_Ships) 
      {   
         instanceObjectWeightedList = "LightShips 10";
         offset = "12000 13000";    
         refObjectName = "collectStartTrigger"; 
         factionOverride = "Civ";   
         objectFuncs["Spawn", 0] = "QAI_AddToSet PickupThieves";  
         objectFuncs["Spawn", 1] = "AddTargetMarker";    
         objectCount = "scaled 1 2";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;   
         respectShipCount = 6;  
         shipSpawnHealth = 0.7;  //crippled          
      };                      
   };
   
   new ScriptGroup(WAVE_Stop)
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "5000 StartWaveName QuestComplete";    
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand PickupThieves SetTactic TP_Collect TP_NoCollect";
      waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand PickupThieves SetTactic TP_Retreat TP_RetreatOn";   
       
   };
   
   new ScriptGroup(WAVE_RetreatAll_StationLost)
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand PickupThieves SetTactic TP_Retreat TP_RetreatOn";   
      waveTimedCallbacks[1, 1] = "500 StartWaveName QuestFail 0 stationLost";    
   };
   new ScriptGroup(WAVE_RetreatAll_Collected)
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand PickupThieves SetTactic TP_Retreat TP_RetreatOn";  
      waveTimedCallbacks[1, 1] = "500 StartWaveName QuestFail 0 failed";    
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {  
      new ScriptGroup(UTAHelpGroup : MADD_UTA_Ped)
      {  
         refObjectName = "REF_stash";                           
      };
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                          
      };   
   };
};