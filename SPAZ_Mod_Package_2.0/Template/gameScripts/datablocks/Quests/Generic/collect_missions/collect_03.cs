
///////////////////////////////////////////////////////////
// COLLECT 03 A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Collect_03A : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "TIME";
       
   title = "BURIED TREASURE";  
   description = "Rogue Civilians have stashed some contraband in a nearby asteroid.  Now the UTA are on the way to lock down the area.  The Civs are desperate to find their stash before the UTA arrives.";
  
   initialWaves = "WAVE_pickupRock WAVE_fakeRock WAVE_fakeRock WAVE_fakeRock WAVE_fakeRock MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO FIND THE HIDDEN STASH";
   missionText["remaining"] = "MT_INFO ASTEROIDS REMAINING";
   missionText["arriveTime"] = "MT_INFO REMAINING TIME";
   missionText["pickup"] = "MT_GOTO COLLECT THE STASH";
   missionText["failed"] = "MT_FAIL You failed to find the stash in time.";
   
   initialTimedCallbacks[0] = "3000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "125000 StartWaveName QuestFail 0 failed";

   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND; 
   SelectionData["Relations_Pirate_Terran"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "arriveTime MT_TIMERTEXT 125";
   missionTrackerData[2] = "remaining MT_SETCOUNTER asteroidSet";
   missionTrackerData[3] = "pickup";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Down;
   Rewards["Complete", "Infrastructure"]   = 1;
   Rewards["Complete", "Bounty"] = "low"; 
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   new ScriptGroup(WAVE_pickupRock)
   {
      maxWaves = 1;
      WaveMissionTrackers["active", 1] = "0 1 2";     
       
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AmbientAsteroids";
         offset = "4000 7000";  
         creationChance = 1;
         objectCount = "3 8";
         refObjectName = "REF_Beacon"; 
         new ScriptGroup("REF_realRock" : MO_Props) 
         {    
            refObjectName = ""; 
            offset = "0 0";                               
            instanceObjectWeightedList = "SingleAsteroid";
            objectCount = "1 1";
            objectFuncs["Spawn", 0]   = "AddTargetMarker";
            objectFuncs["Spawn", 1] = "addToTrackingSet asteroidSet"; 
            objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_stashProp 0";   
            new ScriptGroup("REF_pickupLocator" : MO_Trigger) 
            {   
               offset = "0 0"; 
               refObjectName = ""; 
               triggerRadius = 10;                              
            };           
         }; 
      };             
   };
     
   new ScriptGroup(WAVE_fakeRock)
   {
      maxWaves = -1; 
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AmbientAsteroids";
         offset = "2000 6000";  
         creationChance = 1;
         objectCount = "3 8";
         refObjectName = "REF_Beacon";        
         new ScriptGroup("REF_fakeRock" : MO_Props) 
         {  
            refObjectName = "";   
            offset = "0 0";                                   
            instanceObjectWeightedList = "AsteroidCluster";
            objectCount = "Scaled 2 4";
            objectFuncs["Spawn", 0]   = "AddTargetMarker";
            objectFuncs["Spawn", 1] = "addToTrackingSet asteroidSet";          
         }; 
      };
   };
   
   new ScriptGroup(WAVE_stashProp)
   {
      maxWaves = 1; 
      waveContext[1] = "pickup"; 
       
      WaveMissionTrackers["active", 1] = "3";  
      WaveMissionTrackers["remove", 1] = "0 2"; 
      
      waveTimedCallbacks[1, 0] = "0 trackingSet_callOnObjects asteroidSet RemoveObjectiveMarker_ALL"; 
      
      new ScriptGroup("REF_pickup" : MO_CollectProp)
      {   
         offset = "0 0";   
         refObjectName = "REF_pickupLocator";         
         objectCount = "1 1";  
         pickupFaction = "Pirate";
         objectFuncs["Spawn", 1]   = "AddGoToMarker"; //1 is next in index
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
   };
};


///////////////////////////////////////////////////////////
// COLLECT 03 B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Collect_03B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
       
   title = "XYZ MARKS THE SPOT";  
   description = "A UTA freighter had to dump its cargo and flee from a zombie swarm.  Most of the cargo is of little value, but one crate has highly sensitive materials inside.  The UTA will pay to have these materials retrieved.  To further complicate maters, all the jettisoned cargo is cloaked.";
  
   initialWaves = "WAVE_pickupCrate WAVE_fakeCrate WAVE_fakeCrate WAVE_fakeCrate WAVE_fakeCrate WAVE_fakeCrate MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO FIND THE CLOAKED MATERIALS";
   missionText["remaining"] = "MT_INFO CRATES REMAINING";
   missionText["pickup"] = "MT_GOTO COLLECT THE MATERIALS";
   
   initialTimedCallbacks[0] = "3000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER crateSet";
   missionTrackerData[2] = "pickup";
   
   DeployData["StarType"] = "INNER";
   SelectionData["InfectionLevel"]     = "1 3";
   
   Rewards["Complete", "Goons"] = "low";    
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   new ScriptGroup(WAVE_pickupCrate)
   {
      maxWaves = 1;
      WaveMissionTrackers["active", 1] = "0 1";     
       
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AmbientAsteroids";
         offset = "4000 7000";  
         creationChance = 1;
         objectCount = "3 8";
         refObjectName = "REF_Beacon"; 
         new ScriptGroup("REF_realCrate" : MO_Props) 
         {    
            refObjectName = ""; 
            offset = "0 0";                               
            instanceObjectWeightedList = "SpaceProp_UTASupply_cloaked_S4";
            objectCount = "1 1";
            objectFuncs["Spawn", 0]   = "AddTargetMarker";
            objectFuncs["Spawn", 1] = "addToTrackingSet crateSet"; 
            objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_crateProp 0";   
            minDistanceOverride = 0;
            maxDistanceOverride = 0;
            new ScriptGroup("REF_pickupLocator" : MO_Trigger) 
            {   
               offset = "0 0"; 
               refObjectName = "REF_realCrate"; 
               triggerRadius = 10;                              
            };           
         }; 
      };             
   };
     
   new ScriptGroup(WAVE_fakeCrate)
   {
      maxWaves = -1; 
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AmbientAsteroids";
         offset = "2000 6000";  
         creationChance = 1;
         objectCount = "3 8";
         refObjectName = "REF_Beacon";        
         new ScriptGroup("REF_fakeCrate" : MO_Props) 
         {  
            refObjectName = "";   
            offset = "0 0";                                   
            instanceObjectWeightedList = "SpaceProp_UTASupply_cloaked_S4";
            objectCount = "Scaled 2 4";
            objectFuncs["Spawn", 0]   = "AddTargetMarker";
            objectFuncs["Spawn", 1] = "addToTrackingSet crateSet";  
            objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_zombie_extraAttackers 2500";          
         }; 
      };
   };
   
   new ScriptGroup(WAVE_crateProp)
   {
      maxWaves = 1; 
      waveContext[1] = "pickup"; 
       
      WaveMissionTrackers["active", 1] = "2";  
      WaveMissionTrackers["remove", 1] = "0 1"; 
      
      waveTimedCallbacks[1, 0] = "0 trackingSet_callOnObjects crateSet RemoveObjectiveMarker_ALL"; 
      
      new ScriptGroup("REF_pickup" : MO_CollectProp)
      {   
         offset = "0 0";   
         refObjectName = "REF_realCrate";         
         objectCount = "1 1";  
         pickupFaction = "Pirate";
         objectFuncs["Spawn", 1]   = "AddGoToMarker"; //1 is next in index
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
          instanceObjectWeightedList = "HeavyShips 10";
          objectCount = "1";           
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
      //some zom set dress for context
      new ScriptGroup(ZombieNest : MADD_ZombieNest)
      {   
         new ScriptGroup("zombieRocks" : MADD_ZombieRocks) 
         {                                      
         };                            
      };    
   };
};