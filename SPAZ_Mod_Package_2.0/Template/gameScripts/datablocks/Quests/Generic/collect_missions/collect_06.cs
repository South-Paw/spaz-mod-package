
///////////////////////////////////////////////////////////
// COLLECT 06 A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Collect_06A : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "TIME";
       
   title = "AUTO DRILLER COMPANY";  
   description = "A private company has set up an automated drilling site in a prime location.  The locals want the auto drilling machines removed from the asteroids, but without damaging the asteroids themselves.  In addition, this must be done quickly as Rez stock in the system is in rapid decline.";
  
   initialWaves = "WAVE_drillRock MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY AUTO DRILLER MACHINES";
   missionText["remaining"] = "MT_INFO ASTEROID QUOTA";
   missionText["arriveTime"] = "MT_INFO TIME LIMIT";
   missionText["acceptLost"] = "MT_INFO ACCEPTABLE LOSSES";
   missionText["failTime"] = "MT_FAIL You failed to remove the drillers in time";
   missionText["failLost"] = "MT_FAIL You destroyed too many asteroids";
   
   initialTimedCallbacks[0] = "0 TS_addTrackingTick roidsLost 2";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick roidsNeeded 4";
   initialTimedCallbacks[2] = "3000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[3] = "165000 StartWaveName QuestFail 0 failTime";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "arriveTime MT_TIMERTEXT 160";
   missionTrackerData[2] = "remaining MT_TICKCOUNTER roidsNeeded";
   missionTrackerData[3] = "acceptLost MT_TICKCOUNTER roidsLost";
   
   Rewards["Complete", "Bounty"] = "low";
   
   //SelectionData["SectorProgress"] = "1 3"; //can occur whenever
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   new ScriptGroup(WAVE_drillRock)
   {
      maxWaves = 1;
      WaveMissionTrackers["active", 1] = "0 1 2 3";     
      new ScriptGroup("REF_drillRock1") 
      {                                      
         instanceObjectWeightedList = "AsteroidAutoDriller";
         offset = "4000 7000";  
         creationChance = 1;
         objectCount = "2";
         refObjectName = "REF_Beacon";
         
         objectFuncs["Spawn", 0] = "AddTargetMarker";   
           
         objectFuncs["Death", 0] = "CallInstanceFunc TS_addTrackingTick roidsLost -1";       
         objectFuncs["Death", 1] = "CallInstanceFunc TS_evalTrackingTick roidsLost 0 StartWaveName QuestFail 0 failLost";             
         
         objectFuncs["DeGrowth", 0] = "CallInstanceFunc TS_addTrackingTick roidsNeeded -1"; 
         objectFuncs["DeGrowth", 1] = "CallInstanceFunc TS_evalTrackingTick roidsNeeded 0 StartWaveName QuestComplete";  
         objectFuncs["DeGrowth", 2] = "RemoveObjectiveMarker_ALL"; 
      }; 
      new ScriptGroup("REF_drillRock2" : REF_drillRock1) 
      {                                      
      }; 
      new ScriptGroup("REF_drillRock3" : REF_drillRock1) 
      {                                      
      };    
      new ScriptGroup("REF_drillRock4" : REF_drillRock1) 
      {                                      
      };            
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {  
      //lots of extra set dress
      new ScriptGroup(CivBaseAmbient : MADD_Civ_Base)
      {                                   
      };
      new ScriptGroup(UTABaseAmbient : MADD_UTA_Base)
      {                                   
      };
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {
         SelectionData["InfraLevelRange"]     = "0 3";                          
      };
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      { 
         SelectionData["InfraLevelRange"]     = "0 3";                         
      };
      
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                          
      };
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                          
      };
      new ScriptGroup(ZombieNest : MADD_ZombieNest)
      {   
         new ScriptGroup("zombieRocks" : MADD_ZombieRocks) 
         {                                      
         };                            
      };   
   };
};


///////////////////////////////////////////////////////////
// COLLECT 06 B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Collect_06B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
       
   title = "CRYSTAL CRUSH";  
   description = "The infected horde is harvesting Rez in the area to produce more breeder ships.  Destroying the entire deposit will only aggravate the swarm.  The Rez crystals that grow on the asteroid must be destroyed, while keeping the asteroid itself intact.";
  
   initialWaves = "WAVE_zomCrystals MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY REZ CRYSTALS";
   missionText["remaining"] = "MT_INFO ASTEROID QUOTA";
   missionText["acceptLost"] = "MT_INFO ACCEPTABLE LOSSES";
   missionText["failLost"] = "MT_FAIL You destroyed too many asteroids";
   
   initialTimedCallbacks[0] = "0 TS_addTrackingTick roidsLost 2";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick roidsNeeded 5";
   initialTimedCallbacks[2] = "3000 callQuestFunctionOnInstance MissionCallout initial";
  
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_TICKCOUNTER roidsNeeded";
   missionTrackerData[2] = "acceptLost MT_TICKCOUNTER roidsLost";
   
   DeployData["StarType"] = "INNER";
   SelectionData["InfectionLevel"] = "1 3"; 
   
   Rewards["Complete", "Goons"] = "low";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   new ScriptGroup(WAVE_zomCrystals)
   {
      maxWaves = 1;
      WaveMissionTrackers["active", 1] = "0 1 2";     
      new ScriptGroup("REF_zomCrystal1") 
      {                                      
         instanceObjectWeightedList = "AsteroidCluster_alien_crystal";
         offset = "4000 7000";  
         creationChance = 1;
         objectCount = "2";
         refObjectName = "REF_Beacon";
         
         objectFuncs["Spawn", 0] = "AddTargetMarker";   
           
         objectFuncs["Death", 0] = "CallInstanceFunc TS_addTrackingTick roidsLost -1";       
         objectFuncs["Death", 1] = "CallInstanceFunc TS_evalTrackingTick roidsLost 0 StartWaveName QuestFail 0 failLost";  
         objectFuncs["Death", 2] = "CallInstanceFunc StartWaveName WAVE_zombie_extraAttackers 2500";  
         
         objectFuncs["DeGrowth", 0] = "CallInstanceFunc TS_addTrackingTick roidsNeeded -1"; 
         objectFuncs["DeGrowth", 1] = "CallInstanceFunc TS_evalTrackingTick roidsNeeded 0 StartWaveName QuestComplete";  
         objectFuncs["DeGrowth", 2] = "RemoveObjectiveMarker_ALL"; 
         objectFuncs["DeGrowth", 3] = "CallInstanceFunc StartWaveName WAVE_zombie_extraAttackers 2500";  
      }; 
      new ScriptGroup("REF_zomCrystal2" : REF_zomCrystal1) 
      {                                      
      }; 
      new ScriptGroup("REF_zomCrystal3" : REF_zomCrystal1) 
      {                                      
      };    
      new ScriptGroup("REF_zomCrystal4" : REF_zomCrystal1) 
      {                                      
      }; 
      new ScriptGroup("REF_zomCrystal5" : REF_zomCrystal1) 
      {                                      
      };             
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers")
   {
      maxWaves = 20; //just to make sure there is no exploit
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10 AverageShips 5";
          offset = "4000 6000";  
          objectCount = "1";
          factionOverride = "Zombie"; 
          refObjectName = "REF_Player";
          objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet"; 
          respectShipCount = 4;                       
      };
      new ScriptGroup(ZomRespawnShips_killers : ZomRespawnShips)
      {                                      
          factionOverride = "ZombieKiller";  
          objectCount = "1 2";           
      };                      
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