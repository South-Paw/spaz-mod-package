
///////////////////////////////////////////////////////////
// KILL 05 A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_05A : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV TIME";
    
   title = "PROPAGANDA";  
   description = "A civilian mouth piece is speaking out against UTA propaganda.  The UTA want this civilian eliminated quietly.  The target is currently in transit in deep space, but not for long.  You must not be seen making the kill.  A cloaking device is recommended.";
   initialWaves = "WAVE_targetWave MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK KILL THE TARGET";
   missionText["escaping"] = "MT_ATTACK TARGET IS ESCAPING";
   missionText["sneakInfo"] = "MT_HINT USE CLOAKING TO AVOID DETECTION";
   missionText["sneakMeter"] = "MT_INFO SNEAK METER";
   missionText["killTime"] = "MT_INFO TIME LIMIT";
   missionText["spottedFail"] = "MT_FAIL YOUR COVER WAS BLOWN";
   
   initialTimedCallbacks[0] = "0 callQuestFunctionOnInstance SNEAK_SetCoverValue 8";
   initialTimedCallbacks[1] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[2] = "120000 StartWaveName WAVE_spotted";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //mission can happen any time
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "sneakInfo";
   missionTrackerData[2] = "sneakMeter MT_METER_EVAL SNEAK_getCoverValue";
   missionTrackerData[3] = "killTime MT_TIMERTEXT 120";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Down;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   Rewards["Complete", "Security"]         = 1; 
   
   SelectionData["SectorProgress"] = "3 3"; //lat mission civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_targetWave")
   {
      maxWaves = 1;        
      WaveMissionTrackers["active", 1] = "0 1 2 3";  
      new ScriptGroup(REF_targetShip: MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "6000 10000";  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         refObjectName = "REF_Beacon";  
         objectFuncs["Spawn", 0] = "QAI_AddToSet AttackTargetSet";               
         objectFuncs["Spawn", 1] = "AddTargetMarker";  
         objectFuncs["Spawn", 2]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";  
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestComplete";
         objectFuncs["Warpout", 0] = "CallInstanceFunc StartWaveName QuestFail 0 spottedFail"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
         new ScriptGroup(guardShips: MO_Ships)
         {                                      
             instanceObjectWeightedList = "LightShips 10";
             offset = 0;  
             objectCount = "Scaled 2 3";
             factionOverride = "Civ"; 
             refObjectName = "";                
             objectFuncs["Spawn", 0]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";  
             hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;        
         }; 
         new ScriptGroup(guardShips_02: guardShips)
         { 
            offset = "2000 4000";  
            objectCount = "1 1";                                        
         };
         new ScriptGroup(guardShips_03: guardShips_02)
         {                                        
         };   
         new ScriptGroup(guardShips_04: guardShips_02)
         {                                        
         };             
      };                  
   };
   
   new ScriptGroup("WAVE_spotted")
   {
      maxWaves = 1; 
      waveContext[1] = "escaping"; 
      WaveMissionTrackers["remove", 1] = "1 2 3";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand AttackTargetSet SetTactic TP_Retreat TP_RetreatOn";       
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   //stuff that came with the mission area
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {  
         objectFuncs["Spawn", 0]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";                               
      };    
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                             
      };        
   };
};  


///////////////////////////////////////////////////////////
// KILL 05 B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_05B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA";
    
   title = "ASSASSINATION";  
   description = "A few UTA commanders are rallying the people against the rightful civilian rule in the system.  A reward will be paid for their elimination.  Assassinate them without being spotted.  A cloaking device is recommended.";
   initialWaves = "WAVE_targetWave WAVE_targetWave WAVE_targetWave MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK KILL THE TARGETS";
   missionText["escaping"] = "MT_ATTACK TARGET IS ESCAPING";
   missionText["sneakInfo"] = "MT_HINT USE CLOAKING TO AVOID DETECTION";
   missionText["sneakMeter"] = "MT_INFO SNEAK METER";
   missionText["spottedFail"] = "MT_FAIL YOUR COVER WAS BLOWN";
   missionText["remaining"] = "MT_INFO REMAINING TARGETS:";
   
   initialTimedCallbacks[0] = "0 callQuestFunctionOnInstance SNEAK_SetCoverValue 8";
   initialTimedCallbacks[1] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //mission can happen any time
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER killTargets";
   missionTrackerData[2] = "sneakInfo";
   missionTrackerData[3] = "sneakMeter MT_METER_EVAL SNEAK_getCoverValue";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Resource"] = "high";
   Rewards["Complete", "Infrastructure"]   = 1; 
   
   SelectionData["SectorProgress"] = "3 3"; //lat mission civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_targetWave")
   {
      maxWaves = 3;        
      WaveMissionTrackers["active", 1] = "0 1 2 3";  
      new ScriptGroup(REF_targetShip: MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "5000 8000";  
         objectCount = "1 1";
         factionOverride = "Terran"; 
         refObjectName = "REF_Beacon";  
         objectFuncs["Spawn", 0] = "QAI_AddToSet AttackTargetSet";               
         objectFuncs["Spawn", 1] = "AddTargetMarker";  
         objectFuncs["Spawn", 2]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";  
         objectFuncs["Spawn", 3] = "addToTrackingSet killTargets";  
         objectFuncs["Death", 0] = "evalTrackingSetCount killTargets 0 StartWaveName QuestComplete"; 
         objectFuncs["Warpout", 0] = "CallInstanceFunc StartWaveName QuestFail 0 spottedFail"; 
         new ScriptGroup(guardShips: MO_Ships)
         {                                      
             instanceObjectWeightedList = "LightShips 10";
             offset = 0;  
             objectCount = "Scaled 1 2";
             factionOverride = "Terran"; 
             refObjectName = "";                
             objectFuncs["Spawn", 0]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";         
         };             
      };                  
   };
   
   new ScriptGroup("WAVE_spotted")
   {
      maxWaves = 1; 
      waveContext[1] = "escaping"; 
      WaveMissionTrackers["remove", 1] = "1 2 3";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand AttackTargetSet SetTactic TP_Retreat TP_RetreatOn";       
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   //stuff that came with the mission area
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                               
      };    
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {  
         objectFuncs["Spawn", 0]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";                             
      };        
   };
};  