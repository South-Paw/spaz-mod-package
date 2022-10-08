//Infection Instance Missions.


///////////////////////////////////////////////////////////
// ZOMBIE INFECTION INSTANCE MISSIONS
///////////////////////////////////////////////////////////

new ScriptGroup(InfectionQuestBase : QuestBase_Event)
{
   addToDatabase    = false;  //should just be inherited from 
    
   deactivateOnFail = false; 
   failOnWarpout    = true; 
   maxCompletes     = -1;
   SelectionData["InfectionLevel"] = "1 3"; 
   
   rarity        = "Zombie"; //THIS IS IMPORTANT FLAG 

   Rewards["Complete", "Resource"] = "low";
   Rewards["Complete", "Data"]     = "low";
   
   overrideMarker = "objectiveMarker_zombieImageMap";
      
   DeployData["InstanceType"] = "Zombie";  
   expiryTurns    = -1; //never expires. 
   
   //IMPORTANT NOTE: 
   //Selection data will still be evaluated for the quests, you you can tailor them a bit. 
   //is just set to default for now. Here for reference.
    
   SelectionData["SectorProgress"]      = "1 4"; //Durring which sectors is this quest available
   SelectionData["InfraLevelRange"]     = "0 3";//Some quests we may only want at low or high infrastructure (the starbase building ones for example)
   SelectionData["SecLevelRange"]       = "0 3";//What level is the local security base.
   SelectionData["ObjectivesComplete"]  = ""; //must be blank for at least 1 or em
   SelectionData["InfectionLevel"]      = "0 3";//some missions only in infeced systems 
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; //IMPORTANT IMPORTANT IMPORTANT
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; //YOU MUST DEFINE THIS AS ABOVE FOR EACH QUEST SO WE KNOW IT RUNS AT A LOGICAL TIME!!!
   SelectionData["Relations_Civ_Terran"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; //may not use, so can be defined for all

   //Knock out infection on complete. 
   Rewards["Complete", "Infection"]        = -3; 
   
   //Global to all child quests. 
   Callbacks["BeaconArrival"] = "Sec4_StartReinforcementsFromQuest FollowPlayer";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE HIVE";
   missionText["wavesLeft"] = "MT_INFO nil";
   missionText["respawnTime"] = "MT_INFO nil";
   
   missionTrackerData[0] = "initial";
   // 1 is unique to each type
   missionTrackerData[2] = "wavesLeft MT_EVAL AWG_GetWavesLeftText";
   missionTrackerData[3] = "respawnTime MT_EVAL AWG_GetRespawnTimeText";
};



new ScriptGroup(InfectionQuest_01 : InfectionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   title = "ZOMBIE HIVE";  
   description = "Destroy the zombie hive to clear the infection in this system.";
   initialWaves = "WAVE_zombie_setup";
   
   missionText["health"] = "MT_INFO HIVE HEALTH";
   missionTrackerData[1] = "health MT_HEALTHBAR infectionHiveSet";
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName QuestComplete 0";
      
      new ScriptGroup(REF_ZomHive_SetDress : MO_Props)
      {                                      
         instanceObjectWeightedList = "AsteroidCluster_zombie 10";
         offset = "3000 6000";  
         objectCount = "4 5";
         factionOverride = "Zombie"; 
         refObjectName = "REF_Beacon";
         new ScriptGroup(ZomHive1 : MO_Ships)
         {                                      
            instanceObjectWeightedList = "SpawnMyShip";
            offset = "0 0";  
            objectCount = "1 1";
            factionOverride = "Zombie"; 
            refObjectName = "REF_ZomHive_SetDress";                
            onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
            objectFuncs["Spawn", 0] = "AddTargetMarker"; 
            objectFuncs["Spawn", 1] = "addToTrackingSet infectionHiveSet";   
            shipDesignWL = "HeartZombieStation 10";  
            SelectionData["InfectionLevel"]      = "0 1";     
         }; 
         new ScriptGroup(ZomHive2 : ZomHive1)
         {    
            shipDesignWL = "ArteryZombieStation 10";  
            SelectionData["InfectionLevel"]      = "2 2";                                         
         }; 
         new ScriptGroup(ZomHive3 : ZomHive1)
         {    
            shipDesignWL = "HiveZombieStation 10";  
            SelectionData["InfectionLevel"]      = "3 3";                                        
         };  
         new ScriptGroup(ZomGuardShips_1 : MO_Ships)
         {                                      
            instanceObjectWeightedList = "AverageShips 10 HeavyShips 5";
            offset = "1000 1200";   
            objectCount = "1 2";
            factionOverride = "Zombie"; 
            refObjectName = ""; 
            refObjectName = "REF_ZomHive_SetDress";                       
         };  
         new ScriptGroup(ZomGuardShips_2 : ZomGuardShips_1)
         {    
            objectCount = "1";
            instanceObjectWeightedList = "HeavyShips 10";                                 
            factionOverride = "ZombieKiller";                  
         };                   
      }; 
      
      //set dressing
      new ScriptGroup(ZomRocks_1 : MO_Props)
      {                                      
          instanceObjectWeightedList = "AsteroidCluster_alien_crystal 10";
          offset = "3000 6000";  
          objectCount = "2 3";
          factionOverride = "Zombie"; 
          refObjectName = "REF_Beacon";
          creationChance = 0.2;                     
      };  
      new ScriptGroup(ZomRocks_2 : ZomRocks_1)
      {                                               
      };                 
   };
}; 


new ScriptGroup(InfectionQuest_02 : InfectionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   title = "ZOMBIE COLONY";  
   description = "The zombies are amassing a fleet at this location.  Destroy it to liberate this system.";
   initialWaves = "WAVE_zombie_setup";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE INFECTED OUTPOSTS";
   missionText["remaining"] = "MT_INFO REMAINING OUTPOSTS:";
   missionTrackerData[1] = "remaining MT_SETCOUNTER targetOutposts";
        
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;   
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";   
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName QuestComplete 0";
      
      new ScriptGroup(ZomOutposts_1 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "3000 6000";  
         objectCount = "1 1";
         factionOverride = "Zombie"; 
         refObjectName = "REF_Beacon";                
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet targetOutposts"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_infectionWarpinExtra"; 
         shipDesignWL = "OutpostBase_zombie 10"; 
         new ScriptGroup(ZomGuardShips_1 : MO_Ships)
         {                                      
            instanceObjectWeightedList = "AverageShips 10 HeavyShips 6";
            offset = "1000 1200";   
            objectCount = "1";
            factionOverride = "Zombie"; 
            refObjectName = "";                     
         };       
      };  
      new ScriptGroup(ZomOutposts_2 : ZomOutposts_1)
      {  
         new ScriptGroup(ZomGuardShips_2 : ZomGuardShips_1)
         {  
            instanceObjectWeightedList = "HeavyShips 10";                                                        
         };                                          
      };   
      new ScriptGroup(ZomOutposts_3 : ZomOutposts_1)
      {  
         SelectionData["InfectionLevel"]      = "2 3";
         new ScriptGroup(ZomGuardShips_3 : ZomGuardShips_1)
         {                                                          
         };                                           
      };
      new ScriptGroup(ZomOutposts_4 : ZomOutposts_1)
      {  
         SelectionData["InfectionLevel"]      = "3 3";                                         
      };
      new ScriptGroup(ZomOutposts_5 : ZomOutposts_1)
      {  
         SelectionData["InfectionLevel"]      = "3 3";                                         
      };
      
      // set dressing
      new ScriptGroup(ZomRocks_1 : MO_Props)
      {                                      
          instanceObjectWeightedList = "AsteroidCluster_alien_crystal 10";
          offset = "3000 6000";  
          objectCount = "2 3";
          factionOverride = "Zombie"; 
          refObjectName = "REF_Beacon";
          creationChance = 0.2;                     
      };  
      new ScriptGroup(ZomRocks_2 : ZomRocks_1)
      {                                               
      };                      
   };
    
   new ScriptGroup("WAVE_infectionWarpinExtra")
   {
      maxWaves = -1;  
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet SetTactic TP_Stance TP_SeekAndDestroy";         
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10 HeavyShips 6";
          offset = "2000 3000";  
          objectCount = "1 2";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Player";
          objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet"; 
          respectShipCount = 5;                       
      };                  
   };
}; 



new ScriptGroup(InfectionQuest_03 : InfectionQuestBase)
{   
   addToDatabase    = true;  //Important 
   
   title = "ZOMBIE SOURCE";  
   description = "The zombies in this system are coming from a Rez field nearby.  Destroy it to regain control of the system.";
   initialWaves = "WAVE_zombie_setup";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE REZ DEPOSITS";
   missionText["remaining"] = "MT_INFO REMAINING DEPOSITS:";
   missionTrackerData[1] = "remaining MT_SETCOUNTER targetDeposits";
     
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;     
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";   
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName QuestComplete 0";
      
      new ScriptGroup(ZomRocks_1 : MO_Props)
      {                                      
         instanceObjectWeightedList = "AsteroidCluster_alien_crystal_hard 10";
         offset = "3000 6000";  
         objectCount = "2 3";
         factionOverride = "Zombie"; 
         refObjectName = "REF_Beacon";                
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet targetDeposits"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_infectionWarpinExtra"; 
         new ScriptGroup(ZomGuardShips_1 : MO_Ships)
         {                                      
            instanceObjectWeightedList = "AverageShips 10 HeavyShips 6";
            offset = "1000 1200";   
            objectCount = "1";
            factionOverride = "Zombie"; 
            refObjectName = "";                     
         };            
      };  
      new ScriptGroup(ZomRocks_2 : ZomRocks_1)
      {  
         new ScriptGroup(ZomGuardShips_2 : ZomGuardShips_1) //only some rocks have guards, as they produce zoms on their own
         {  
            instanceObjectWeightedList = "HeavyShips 10";                                                        
         };                                               
      };
      new ScriptGroup(ZomRocks_3 : ZomRocks_1)
      {    
         new ScriptGroup(ZomGuardShips_3 : ZomGuardShips_1)
         {                                                          
         };                                             
      }; 
      new ScriptGroup(ZomRocks_4 : ZomRocks_1)
      {  
         SelectionData["InfectionLevel"]      = "2 3";                                                
      };
      new ScriptGroup(ZomRocks_5 : ZomRocks_1)
      {  
         SelectionData["InfectionLevel"]      = "3 3";                                                
      };                        
   };
   
   new ScriptGroup("WAVE_infectionWarpinExtra")
   {
      maxWaves = -1;  
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet SetTactic TP_Stance TP_SeekAndDestroy";         
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10 HeavyShips 7";
          offset = "4000 5000";  
          objectCount = "1 2";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Player";
          objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet"; 
          respectShipCount = 4;                       
      };                  
   };
}; 


new ScriptGroup(InfectionQuest_04 : InfectionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   title = "INFECTED STRUCTURES";  
   description = "Destroy the infected structures to clear the infection in this system.";
   initialWaves = "WAVE_zombie_setup WAVE_zombieAttackWave_01";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE INFECTED STRUCTURES";
   missionText["remaining"] = "MT_INFO REMAINING STRUCTURES:";
   missionTrackerData[1] = "remaining MT_SETCOUNTER infectionStructureSet";
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName QuestComplete 0";
            
      new ScriptGroup(ZomHive1 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "3000 6000";  
         objectCount = "1 1";
         factionOverride = "Zombie"; 
         refObjectName = "REF_Beacon";                
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Spawn", 1] = "addToTrackingSet infectionStructureSet";   
         shipDesignWL = "ArteryZombieStation 10"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_zombieAttackWave_01";    
      }; 
      new ScriptGroup(ZomOutposts_1 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "3000 6000";  
         objectCount = "1 1";
         factionOverride = "Zombie"; 
         refObjectName = "REF_Beacon";                
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet infectionStructureSet"; 
         shipDesignWL = "OutpostBase_zombie 10";   
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_zombieAttackWave_01";       
      }; 
      new ScriptGroup(ZomOutposts_2 : ZomOutposts_1)
      {                                      
         SelectionData["InfectionLevel"] = "2 3";      
      };
      new ScriptGroup(ZomHive2 : ZomHive1)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "4000 7500";  
         objectCount = "1 1";
         factionOverride = "Zombie"; 
         refObjectName = "REF_Beacon";                
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Spawn", 1] = "addToTrackingSet infectionStructureSet";   
         shipDesignWL = "HeartZombieStation 10"; 
         SelectionData["InfectionLevel"] = "3 3"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_zombieAttackWave_01";     
      };                                      
   };
   
   new ScriptGroup("WAVE_zombieAttackWave_01")
   {
      maxWaves = -1;       
      new ScriptGroup(Zomships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 5";
         objectCount = "2 3"; 
         offset = "3000 4000"; 
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Player"; 
         respectShipCount = 5;   
      }; 
      new ScriptGroup(Zomships_02 : Zomships_01)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1"; 
         factionOverride = "Zombie";                        
      }; 
   };
}; 


new ScriptGroup(InfectionQuest_05 : InfectionQuestBase)
{   
   addToDatabase    = true;  //Important 
   
   title = "ZOMBIE FLOTILLA";  
   description = "The zombies are coming from a near by flotilla of infected ships.  Destroy them to regain control of the system.";
   initialWaves = "WAVE_zombieFloat_01";
   
   missionText["initial"] = "MT_ATTACK DESTROY INFECTED TARGETS";  
   missionText["heavy"] = "MT_ATTACK HEAVY FLOATILLA DETECTED";  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "wavesLeft MT_EVAL AWG_GetWavesLeftText";
   missionTrackerData[2] = "respawnTime MT_EVAL AWG_GetRespawnTimeText";
   missionTrackerData[3] = ""; //overrite the parent
     
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombieFloat_01")
   {
      maxWaves = 5;     
      
      WaveMissionTrackers["active", 1] = "0 1 2";   
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zombieFloat_01 1500";
      setHealthCallback[5, "enemy", 0] = "0 StartWaveName WAVE_zombieFloat_02 0";
      
      new ScriptGroup(FloatShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "2"; 
         offset = "5000 8000"; 
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";   
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         new ScriptGroup(FloatShips_02 : FloatShips_01)
         {     
            objectCount = "1"; 
            offset = "500 1000"; 
            factionOverride = "Zombie";
            refObjectName = "FloatShips_01";                                        
         };      
      }; 
   };
   new ScriptGroup("WAVE_zombieFloat_02")
   {
      maxWaves = 2; 
      
      waveContect[1] = "heavy";    
      
      WaveMissionTrackers["active", 1] = "0 1 2";   
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zombieFloat_02 1500";
      setHealthCallback[2, "enemy", 0] = "0 StartWaveName QuestComplete 0";
      
      new ScriptGroup(FloatShips_03 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "2"; 
         offset = "5000 8000"; 
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";   
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         new ScriptGroup(FloatShips_04 : FloatShips_01)
         {   
            refObjectName = "FloatShips_03";
            instanceObjectWeightedList = "AverageShips 10";  
            objectCount = "1"; 
            offset = "500 1000"; 
            factionOverride = "Zombie";                                        
         };      
      }; 
   };
}; 



new ScriptGroup(InfectionQuest_06 : InfectionQuestBase)
{   
   addToDatabase    = true;  //Important 
   
   title = "ZOMBIE SWARM";  
   description = "Small zombie ships are swarming the area.  Destroy them to regain control of the system.";
   initialWaves = "WAVE_zombieSwarm_01 WAVE_zombieSwarm_01";
   
   //index zero is attached to parent
   initialTimedCallbacks[1] = "12000 StartWaveName WAVE_zombieSwarm_01";
   initialTimedCallbacks[2] = "20000 StartWaveName WAVE_zombieSwarm_01";
   initialTimedCallbacks[3] = "30000 StartWaveName WAVE_zombieSwarm_01";
   
   missionText["initial"] = "MT_ATTACK DESTROY INFECTED TARGETS";  
   //missionText["heavy"] = "MT_ATTACK HEAVY FLOATILLA DETECTED";  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "wavesLeft MT_EVAL AWG_GetWavesLeftText";
   missionTrackerData[2] = "respawnTime MT_EVAL AWG_GetRespawnTimeText";
   missionTrackerData[3] = ""; //overrite the parent
     
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombieSwarm_01")
   {
      maxWaves = 20;     
      
      WaveMissionTrackers["active", 1] = "0 1 2";   
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zombieSwarm_01 2000";
      setHealthCallback[20, "enemy", 0] = "0 StartWaveName QuestComplete 0";
      
      new ScriptGroup(AttackShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1"; 
         offset = "5000 6000"; 
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";   
         objectFuncs["Spawn", 0] = "AddTargetMarker";      
      }; 
   };
}; 





