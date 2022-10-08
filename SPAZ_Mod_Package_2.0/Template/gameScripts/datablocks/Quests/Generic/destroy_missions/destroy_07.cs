
///////////////////////////////////////////////////////////
// DESTROY 07A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_07 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
       
   title = "TAKE OUT THE TAKE-OUT";  
   description = "A shipment of food has been dropped in the area to be later transported to the Civilian station in this system.  Destroying the storage crates will sabotage the Civilian station.";
  
   initialWaves = "WAVE_creatSetup MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY FOOD CRATES";
   missionText["remaining"] = "MT_INFO REMAINING CRATES:";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER foodCrates";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Down;
   Rewards["Complete", "Infrastructure"]   = -1; 
   Rewards["Complete", "Bounty"] = "low";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   SelectionData["InfraLevelRange"]     = "1 3";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_creatSetup")
   {
      maxWaves = 1;   
      WaveMissionTrackers["active", 1] = "0 1"; 
      //waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomDefenderSet SetTactic TP_Stance TP_Defensive";      
      new ScriptGroup(REF_foodCrate_1 : MO_Props) 
      {     
         offset = "4000 5000";                                 
         instanceObjectWeightedList = "SpaceProp_Crates_Rich";
         objectCount = "Scaled 5 8";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet foodCrates"; 
         objectFuncs["Death", 0] = "evalTrackingSetCount foodCrates 0 StartWaveName QuestComplete";
         objectFuncs["Death", 1] = "CallInstanceFunc StartWaveName WAVE_foodDefenders 5000";   
         objectFuncs["Death", 2] = "evalTrackingSetCount foodCrates 12 StartWaveName WAVE_foodBoss 5000";
         objectFuncs["Death", 3] = "CallInstanceFunc StartWaveName PickupPissoff";   
      };
      new ScriptGroup(REF_foodCrate_2 : REF_foodCrate_1) 
      {     
      }; 
      new ScriptGroup(REF_foodCrate_2 : REF_foodCrate_1) 
      {     
      };
      //dressing
      new ScriptGroup(civ_barrels : MO_props) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels 10";
         offset = "0 0";  
         objectCount = "4 6";
         refObjectName = "REF_foodCrate_1";
      };
      new ScriptGroup(civ_mines) 
      {                                      
         instanceObjectWeightedList = "RegenSwarmMineField";
         offset = "0 0"; 
         objectCount = "1";
         factionOverride = "Civ";
         refObjectName = "REF_foodCrate_2";   
      };      
   };
   
   new ScriptGroup("WAVE_foodDefenders")
   {
      maxWaves = 20;        
      waveTimedCallbacks["All", 0] = "0 QAI_SetAICommand foodDefenders SetTactic TP_Stance TP_SeekAndDestroy";         
      new ScriptGroup(CIV_ships_1 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         offset = "3000 5000";  
         objectCount = "Scaled 1 2";
         factionOverride = "Civ"; 
         refObjectName = "REF_Player";                
         objectFuncs["Spawn", 0] = "QAI_AddToSet foodDefenders";    
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
         respectShipCount = 4;
      };                    
   };
   
   new ScriptGroup("WAVE_foodBoss")
   {
      maxWaves = 3; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName WAVE_foodBoss 8000";       
      waveTimedCallbacks["All", 0] = "0 QAI_SetAICommand foodDefenders SetTactic TP_Stance TP_SeekAndDestroy";         
      new ScriptGroup(CIV_ships_1 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         offset = "3000 5000";  
         objectCount = "1";
         factionOverride = "Civ"; 
         refObjectName = "REF_Player"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";               
         objectFuncs["Spawn", 0] = "QAI_AddToSet foodDefenders";    
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
      };                    
   };
   
   new ScriptGroup("PickupPissoff")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations civ -1";
   }; 
     
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {             
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                          
      };
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                          
      };                                     
   }; 
}; 

///////////////////////////////////////////////////////////
// DESTROY 07B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_07B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   factionRelateReq = "Civ";
       
   title = "CASTING STONES";  
   description = "A civilian star base is in the path of an incoming asteroid shower.   The base is not capable of withstanding several direct impacts.  Any assistance in this matter will be rewarded.";
  
   initialWaves = "WAVE_StationVictim MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO RENDEZVOUS WITH THE ESCORT";
   missionText["incoming"] = "MT_ATTACK DESTROY INCOMING COMETS";
   missionText["remaining"] = "MT_INFO ALLOWABLE IMPACTS:";
   missionText["stationFail"] = "MT_FAIL THE STATION WAS DESTROYED";
   missionText["showerTime"] = "MT_INFO TIME REMAINING";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick cometHits 6";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "incoming";
   missionTrackerData[2] = "remaining MT_TICKCOUNTER cometHits";
   missionTrackerData[3] = "showerTime MT_TIMERTEXT 120";
   
   SelectionData["Relations_Pirate_Civ"] = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND;
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_StationVictim")
   { 
      maxWaves = 1; 
      WaveMissionTrackers["active", 1] = "0"; 
      new ScriptGroup("REF_baseCometTrig" : MO_Trigger)
      {   
         triggerRadius = 750;        
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_SetupComet 0";
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_SetupComet 60000"; //turn up the heat half way
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet setTriggerActive REF_baseCometTrig 0";                                 
      };
      new ScriptGroup("REF_CometStation" : MO_Ships) 
      {   
         instanceObjectWeightedList = "SpawnMyShip";
         refObjectName = "REF_Beacon"; 
         offset = 3500;  
         objectCount = "1";
         factionOverride = "Civ"; 
         shipDesignWL = "Pirate02Base 10 Pirate03Base 5";
         objectFuncs["Spawn", 0] = "AddDefendMarker";  
         objectFuncs["Spawn", 1] = "SetAngerMult 0.3";      
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 stationFail"; 
         mountRefObjectNames = "REF_baseCometTrig";                         
      };
   };

   new ScriptGroup("WAVE_SetupComet")
   {
      maxWaves = 1; 
      waveContext[1] = "incoming";
      WaveMissionTrackers["active", 1] = "1 2 3"; 
      WaveMissionTrackers["remove", 1] = "0"; 
      waveTimedCallbacks["all", 0] = "0 startWaveName WAVE_CometFinish 120000";
      waveTimedCallbacks["all", 1] = "0 startWaveName WAVE_cometCreate 0";
   }; 
   
   new ScriptGroup("WAVE_cometCreate")
   {
      maxWaves = -1; 
      waveTimedCallbacks["all", 0] = "0 startWaveName WAVE_cometCreate 8000";
      new ScriptGroup("REF_comet_01" : MO_Props) 
      {
         instanceObjectWeightedList = "AsteroidComet";
         offset = "14000";      
         objectCount = "scaled 1 3";           
         refObjectName = "REF_CometStation";
         objectFuncs["Spawn", 0] = "ImpulseToRef REF_CometStation 300"; 
         objectFuncs["Spawn", 1] = "AddTargetMarker true";
         objectFuncs["Spawn", 2] = "destroyWhenNear 300 REF_CometStation WAVE_CometHit"; 
         objectFuncs["Spawn", 3] = "addToTrackingSet cometSet";  
      }; 
   }; 
   
   new ScriptGroup("WAVE_CometHit")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "0 TS_addTrackingTick cometHits -1"; 
      waveTimedCallbacks["All", 1] = "0 TS_evalTrackingTick cometHits 0 StartWaveName WAVE_CometFail 0";        
   };
   
   new ScriptGroup("WAVE_CometFail")
   {
      maxWaves = 1; 
      waveTimedCallbacks["All", 0] = "0 callOnSubObjects REF_CometStation mission_destroyShip"; 
      waveTimedCallbacks["All", 1] = "0 StartWaveName QuestFail 0 stationFail";        
   };
   
   new ScriptGroup("WAVE_CometFinish")
   {
      maxWaves = 1; 
      //waveTimedCallbacks["All", 0] = "0 trackingSet_callOnObjects cometSet setHealth 0";  //doesn't work, also not needed
      waveTimedCallbacks["All", 0] = "0 StartWaveName QuestComplete";        
   };
     
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {             
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                          
      };
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                          
      };                                     
   }; 
}; 

