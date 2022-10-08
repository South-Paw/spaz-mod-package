
///////////////////////////////////////////////////////////
// DEFEND 03 (defend 3 UTA stations from zombies)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Defend_03: QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   factionRelateReq = "Terran";
       
   title = "UTA DISTRESS BEACON";  
   description = "A UTA outpost is under attack by the zombie infection.  A distress signal has gone out on all open channels.";
  
   initialWaves = "WAVE_stations WAVE_infection WAVE_infection WAVE_infection WAVE_zombieAttackers MADD_WAVE";
   
   initialTimedCallbacks[0] = "120000 StartWaveName WAVE_fakePickups";
   initialTimedCallbacks[1] = "125000 StartWaveName QuestComplete";
   
   missionText["initial"] = "MT_DEFEND DEFEND THE UTA STATIONS";
   missionText["stationsLost"] = "MT_FAIL THE STATIONS WERE DESTROYED";
   missionText["remaining"] = "MT_INFO REMAINING STATIONS:";
   missionText["defendTime"] = "MT_INFO DEFEND TIME";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Terran"]    = $FactionRelation_NEUTRAL SPC $FactionRelation_MYFACTION;  
   SelectionData["InfectionLevel"]          = "2 3";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER utaStations";
   missionTrackerData[2] = "defendTime MT_TIMERTEXT 125";
   
   Rewards["Complete", "Security"] = 1;
   Rewards["Complete", "Bounty"] = "Sub_High";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
      
   new ScriptGroup("WAVE_stations")
   {
      maxWaves = 1; 
      waveContext[1] = "initial";
      
      healthCallbackSets = "stations"; 
      setHealthCallback["All", "stations", 0] = "0 StartWaveName QuestFail 0 stationsLost"; 
      
      WaveMissionTrackers["active", 1] = "0 1 2";    
               
      new ScriptGroup("UTA_station_01" : MO_Ships) 
      {
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "1400 1500";   
         objectCount = 1;               
         refObjectName = "REF_Beacon";
         objectFuncs["Spawn", 0]   = "AddDefendMarker"; 
         objectFuncs["Spawn", 1]   = "addToTrackingSet utaStations";  
         objectFuncs["Spawn", 2]   = "QAI_AddToSet defendStationSet"; 
         objectFuncs["Spawn", 3] = "SetAngerMult 0.3";    
         onInitializedFunc[0] = "AddToHealthCallbackSet stations"; 
         shipDesignWL = "OutpostBase 10 Pirate01Base 8 Pirate02Base 2 Pirate03Base 1";
      };
      new ScriptGroup("UTA_station_02" : UTA_station_01) 
      {
         offset = "1700 1800";   
      };
   };
       
   new ScriptGroup("WAVE_infection")
   {
      maxWaves = -1;        
      new ScriptGroup(ZomShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "3000 4000";  
         objectCount = "1";
         factionOverride = "Zombie";                     
         refObjectName = "UTA_station_01";
         new ScriptGroup("zombieRocks" : MADD_ZombieRocks) 
         {                                      
         };  
      };          
   };
   
   new ScriptGroup("WAVE_zombieAttackers")
   {
      maxWaves = -1; 
      healthCallbackSets = "zombieAttackSet";
      setHealthCallback["All", "zombieAttackSet", 0] = "0 StartWaveName WAVE_zombieAttackers";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand zombieAttackSet SetTactic TP_Stance TP_SeekAndDestroy";            
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand zombieAttackSet Attack defendStationSet";  

      new ScriptGroup(Zom_ships_large : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";
          offset = "4000 8000";  
          objectCount = "1 2";
          factionOverride = "zombieKiller"; 
          refObjectName = "REF_Beacon";
          objectFuncs["Spawn", 0]   = "QAI_AddToSet zombieAttackSet"; 
          onInitializedFunc[0] = "AddToHealthCallbackSet zombieAttackSet";                   
      };                     
   };
   
   new ScriptGroup("WAVE_fakePickups")
   {
      maxWaves = 1;    
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand fakePickups SetTactic TP_Retreat TP_RetreatOn";      
      new ScriptGroup(pickupShips_01 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "HeavyShips 10";
          offset = "500 600";  
          objectCount = "1";
          factionOverride = "terran"; 
          refObjectName = "UTA_station_01";
          objectFuncs["Spawn", 0]   = "Ship_RequestCrew"; 
          objectFuncs["Spawn", 1] = "QAI_AddToSet fakePickups";                  
      };  
      new ScriptGroup(pickupShips_02 : pickupShips_01)
      {                                      
          refObjectName = "UTA_station_02";             
      };                     
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
