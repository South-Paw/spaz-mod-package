
///////////////////////////////////////////////////////////
// COLLECT 04
///////////////////////////////////////////////////////////

//RLBRLB handle prop destruction

new ScriptGroup(Quest_Collect_04 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
       
   title = "ESPIONAGE";  
   description = "The UTA have sensitive data awaiting pickup.  It is heavily guarded, and they have orders to delete the data at the first sign of trouble.  You can not be seen while stealing the data.  A cloaking device is highly recommended.";
  
   initialWaves = "WAVE_DataDrop WAVE_DataDrop WAVE_DataDrop WAVE_DataDrop MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO COLLECT THE DATA";
   missionText["remaining"] = "MT_INFO REMAINING DATA:";
   missionText["sneakInfo"] = "MT_HINT USE CLOAKING TO AVOID DETECTION";
   missionText["sneakMeter"] = "MT_INFO SNEAK METER";
   missionText["spottedFail"] = "MT_FAIL YOUR COVER WAS BLOWN";
   
   initialTimedCallbacks[0] = "0 callQuestFunctionOnInstance SNEAK_SetCoverValue 15";
   initialTimedCallbacks[1] = "3000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER pickupSet";
   missionTrackerData[2] = "sneakInfo";
   missionTrackerData[3] = "sneakMeter MT_METER_EVAL SNEAK_getCoverValue";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   
   SelectionData["SectorProgress"] = "3 3"; //late mission ... civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_DataDrop)
   {
      maxWaves = -1;
      WaveMissionTrackers["active", 1] = "0 1 2 3";      
      new ScriptGroup(DataProp_01 : MO_CollectProp)
      {   
         offset = "5000 8000";                                  
         refObjectName = "REF_beacon"; 
         objectCount = "1";
         objectFuncs["Spawn", 1] = "AddGoToMarker";   
         objectFuncs["Pickup", 0] = "evalTrackingSetCount pickupSet 0 StartWaveName questComplete";    
         new ScriptGroup(DataGuard_01 : MO_Ships)
         {                                      
            instanceObjectWeightedList = "LightShips 10";                 
            refObjectName = "";
            offset = 0;
            objectFuncs["Spawn", 0]   = "isScoutingShip pirate 500 SNEAK_BlowCover WAVE_spotted";  
            objectCount = "1";
            factionOverride = "Terran"; 
         };
         new ScriptGroup(UTAMines_01 : MO_Mines) 
         {                                      
            objectCount = "1"; 
            factionOverride = "terran";
            refObjectName = ""; 
            offset = 0;
            instanceObjectWeightedList = "ScannerSwarmMineField_Large";
         };                                       
      };            
   };
   
   new ScriptGroup("WAVE_spotted")
   {
      maxWaves = 1;   
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestFail 0 spottedFail";            
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
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

