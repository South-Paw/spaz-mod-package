
///////////////////////////////////////////////////////////
// COLLECT 01
///////////////////////////////////////////////////////////

//RLBRLB handle prop destruction

new ScriptGroup(Quest_Collect_01 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
     
   title = "SALVAGE JOB";  
   description = "The civilians in this system are salvaging materials to upgrade the local space station.";
  
   initialWaves = "WAVE_SetupDropPoint WAVE_collectables WAVE_HeavyRespawner MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO COLLECT THE ITEMS";
   missionText["return"] = "MT_GOTO RETURN ITEMS TO THE STATION";
   missionText["remaining"] = "MT_INFO REMAINING ITEMS:";
   missionText["failText"] = "MT_FAIL Civilian base destroyed";
   
   initialTimedCallbacks[0] = "3000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER pickupSet";
   missionTrackerData[2] = "return";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Infrastructure"]   = 1; 
   Rewards["Complete", "Goons"] = "low";
   Rewards["Complete", "Bounty"] = "Sub_High";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_SetupDropPoint)
   {
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE; 
      new ScriptGroup(DropOff_Context : MO_Props) 
      {   
         instanceObjectWeightedList = "AsteroidBreakage";
         offset = "2000 2500";  
         new ScriptGroup(DropOff_Station : MO_Ships) 
         {   
            instanceObjectWeightedList = "SpawnMyShip";
            offset = "0";  
            objectCount = "1 1";
            factionOverride = "Civ"; 
            shipDesignWL = "OutpostBase 10 Pirate01Base 8"; 
            refObjectName = "";
            objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 failText";                         
         };                        
      };              
   };
   
   new ScriptGroup(WAVE_collectables)
   {
      maxWaves = 1;     
      WaveMissionTrackers["active", 1] = "0 1"; 
      //creat pickup clusters       
      new ScriptGroup(CollectProp_01 : MO_CollectProp)
      {   
         objectFuncs["Spawn", 1] = "AddGoToMarker";   
         objectFuncs["Pickup", 0] = "evalTrackingSetCount pickupSet 0 StartWaveName WAVE_DropOff";   
         objectFuncs["Pickup", 1] = "CallInstanceFunc StartWaveName WAVE_attackers 1000";   
         new ScriptGroup(CollectGuard_01 : MO_CollectGuard) 
         {                                            
         };                                   
      };
                                               
      new ScriptGroup(CollectProp_02 : CollectProp_01)
      {   
         new ScriptGroup(CollectGuard_02 : MO_CollectGuard) 
         {                                            
         };                               
      };
                                   
      new ScriptGroup(CollectProp_03 : CollectProp_01)
      {    
         new ScriptGroup(CollectGuard_03 : MO_CollectGuard) 
         {                                            
         };                             
      };
      //not all pickups need guards, they spawn extras when you collect
      new ScriptGroup(CollectProp_04 : CollectProp_01)
      {
         offset = "4000 6000";                               
      };
      new ScriptGroup(CollectProp_05 : CollectProp_01)
      {  
         offset = "4000 6000";                                
      };
   };
   
   new ScriptGroup(WAVE_attackers)
   {
      maxWaves = -1;         
      new ScriptGroup(CollectGuard_01 : MO_Ships) 
      {  
         instanceObjectWeightedList = "AverageShips 10";
         offset = "500 600";  
         objectCount = "Scaled 1 3";
         factionOverride = "Terran";                     
         refObjectName = "REF_Player";
         respectShipCount = 4;                                           
      };                                   
   };

   new ScriptGroup(WAVE_DropOff)
   {
      maxWaves = 1; 
      waveContext[1] = "return"; 
      WaveMissionTrackers["active", 1] = "2";   
      WaveMissionTrackers["remove", 1] = "0 1";   
      new ScriptGroup(DropOff_Trigger : MO_Trigger) 
      {   
         refObjectName = "DropOff_Station"; 
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName QuestComplete";
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet setTriggerActive REF_CrateTrigger 0";
         triggerFuncs[2] = "ObjectFunc 1 PlayerSet fireStoryProbe DropOff_Trigger";  
         objectFuncs["Spawn", 0] = "AddGoToMarker";             
      };              
   };
   
   new ScriptGroup(WAVE_HeavyRespawner)
   {
      maxWaves = 8; //lots, but not forever
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName WAVE_HeavyRespawner 10000";
      waveTimedCallbacks["All", 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";  
      new ScriptGroup(REF_ZomAttackers2 : MO_Ships) 
      {   
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "5000 6000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Player"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";             
      };    
   }; 
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CivHelpGroup : MADD_Civ_Help)
      {
         refObjectName = "DropOff_Station";                       
      };  
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                             
      };  
   };
}; 

