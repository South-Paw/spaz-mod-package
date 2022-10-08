
///////////////////////////////////////////////////////////
// DEFEND 02 / beacon defence
///////////////////////////////////////////////////////////

//RLBRLB we need to fail on beacon destroyed

new ScriptGroup(Quest_Defend_02: QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "INFUP";
       
   title = "CIVILIAN TRANSMISSION";  
   description = "The civilians are using line of sight transmissions to communicate without the UTA knowing.  A reward will be paid if these transmissions can be tapped.  All that is required is to hold out long enough for a trace program to scan the area.";
  
   initialWaves = "WAVE_setup MADD_WAVE";
   
   missionText["initial"] = "MT_DEFEND SURVIVE";
   missionText["bossWave"] = "MT_ATTACK LARGE SHIPS INBOUND";
   missionText["defendTime"] = "MT_INFO DEFEND TIME";
   missionText["failReason"] = "MT_FAIL You failed to defend your own beacon from attack";
   
   initialTimedCallbacks[0] = "5000 StartWaveName WAVE_CIV_01";  
   initialTimedCallbacks[1] = "15000 StartWaveName WAVE_CIV_02";       
   initialTimedCallbacks[2] = "40000 StartWaveName WAVE_CIV_03"; 
   initialTimedCallbacks[3] = "120000 StartWaveName WarpoutWave";
   initialTimedCallbacks[4] = "125000 StartWaveName QuestComplete";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "defendTime MT_TIMERTEXT 125";
   
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   Rewards["Complete", "Bounty"] = "low";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
      
   new ScriptGroup("WAVE_setup")
   {
      maxWaves = -1;        
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand DefendAttackerSet MoveTo REF_Beacon 0"; 
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand DefendAttackerSet SetTactic TP_Stance TP_SeekAndDestroy";    
      
      WaveMissionTrackers["active", 1] = "0 1";    
   };
       
   new ScriptGroup("WAVE_CIV_01")
   {
      maxWaves = -1;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_CIV_01 3000";
      waveContext[1] = "initial";  
      new ScriptGroup(CivShips_01 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10";
          offset = "4000 5000";  
          objectCount = "Scaled 1 3";
          factionOverride = "Civ";                     
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
          objectFuncs["Spawn", 0]   = "QAI_AddToSet DefendAttackerSet"; 
          hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
      };               
   };
   new ScriptGroup("WAVE_CIV_02")
   {
      maxWaves = -1;
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_CIV_02 4000";      
      new ScriptGroup(CivShips_02 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";
          offset = "4000 5000";  
          objectCount = "Scaled 1 2";
          factionOverride = "Civ";                     
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
          objectFuncs["Spawn", 0]   = "QAI_AddToSet DefendAttackerSet"; 
          hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
      };
      new ScriptGroup(Defend_CMADD : CivShips_02)
      {  
         objectCount = "1 1"; 
         SelectionData["InfraLevelRange"]     = "2 3";                         
      };                 
   };
   new ScriptGroup("WAVE_CIV_03")
   {
      maxWaves = -1;
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_CIV_03 7000"; 
      waveContext[1] = "bossWave";    
      new ScriptGroup(CivShips_03 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "HeavyShips 10";
          offset = "4000 6000";  
          objectCount = "1 1";
          factionOverride = "Civ";                     
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
          objectFuncs["Spawn", 0]   = "QAI_AddToSet DefendAttackerSet"; 
          hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
      }; 
      //add more enemies
      new ScriptGroup(Defend_CMADD : CivShips_03)
      {   
         SelectionData["InfraLevelRange"]     = "2 3";                         
      };                 
   };
   
   new ScriptGroup("WarpoutWave")
   {
      maxWaves = 1;
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand DefendAttackerSet SetTactic TP_Retreat TP_RetreatOn";           
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   //stuff that came with the mission area
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {
      new ScriptGroup(UTAHelpGroup : MADD_UTA_Help)
      {                           
      };  
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                             
      };        
   };
}; 














