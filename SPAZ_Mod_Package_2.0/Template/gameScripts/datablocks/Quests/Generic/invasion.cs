///////////////////////////////
//Invasion Missions ///////////
///////////////////////////////
//When zombies try to re-infect a system
//Happens are security instance

//These are placing in sec instance manually.


////////////////////////////////////////////////////////////////////////////////
// zombie setup stuff
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ZomInvasion_Ships : MO_Ships)
{      
   instanceObjectWeightedList = "LightShips 10";
   offset = "10000 12000"; //keep them far away so you have time to deal  
   objectCount = "1";
   factionOverride = "ZombieKiller"; 
   refObjectName = "REF_InstanceFocus";
    
   onInitializedFunc[0] = "AddToHealthCallbackSet Enemies"; 
    
   objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet"; 
   objectFuncs["Spawn", 1] = "AddTargetMarker";  
   objectFuncs["Spawn", 2] = "addToTrackingSet zomInvasionSet";    
    
   objectFuncs["Death", 0] = "evalTrackingSetCount zomInvasionSet 0 StartWaveName QuestComplete";                          
};   

new ScriptGroup(ZomInvasion_Ship_Seeker : MO_Ships)
{      
   instanceObjectWeightedList = "LightShips 10";
   offset = "8000 10000";  
   objectCount = "1";
   factionOverride = "ZombieKiller"; 
   refObjectName = "REF_InstanceFocus";
   
   onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
   
   objectFuncs["Spawn", 0] = "AddTargetMarker";  
   objectFuncs["Spawn", 1] = "addToTrackingSet zomInvasionSet"; 
      
   objectFuncs["Death", 0] = "evalTrackingSetCount zomInvasionSet 0 StartWaveName QuestComplete";                          
};  

new ScriptGroup(InvasionQuestBase : QuestBase_Event)
{
   addToDatabase    = false;  //should just be inherited from 
      
   deactivateOnFail = false; //need to remove manually. system will become infected. 
   failOnWarpout    = true; 
   maxCompletes     = -1;
   
   overrideMarker = "objectiveMarker_zombieImageMap";
    
   rarity        = "ZombieInvasion"; //THIS IS IMPORTANT FLAG 

   Rewards["Complete", "Resource"] = "low";
   Rewards["Complete", "Data"]     = "low";
      
   DeployData["InstanceType"] = "Security";  
   expiryTurns    = -1; //never expires. 
   
   description = "This star base is being invaded by Zombie ships.  If you want to keep this system, you will have to destroy the zombie invasion.  The harder you hit them, the longer they will back off.";
   
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

   Callbacks["Complete"] = "Sec4_OnStopInvasionSuccess";
   Callbacks["Failed"]   = "Sec4_OnStopInvasionFailed";
   Callbacks["BeaconArrival"] = "Sec4_StartReinforcementsFromQuest GuardStation";

   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionText["initial"] = "MT_DEFEND DEFEND THE STAR BASE";
   missionText["zombieTargets"] = "MT_ATTACK DESTROY ZOMBIE TARGETS";
   missionText["stationHealth"] = "MT_INFO STATION HEALTH";
   missionText["wavesLeft"] = "MT_INFO nil";
   missionText["respawnTime"] = "MT_INFO nil";
   missionText["failText"] = "MT_FAIL THE STATION WAS DESTROYED";
   
   missionTrackerData[0] = "zombieTargets";
   missionTrackerData[1] = "initial"; 
   missionTrackerData[1] = "stationHealth MT_HEALTHBAR invasionBaseSet";    
   missionTrackerData[2] = "wavesLeft MT_EVAL AWG_GetWavesLeftText";
   missionTrackerData[3] = "respawnTime MT_EVAL AWG_GetRespawnTimeText";
};


new ScriptGroup(InvasionQuest_Small_01 : InvasionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   invasionSize = 0; //0 = Small. 1 = Med, 2 = Large, 3 = Huge 
   
   title = "MINOR INVASION";  
   initialWaves = "WAVE_zombie_setup WAVE_zombie_extraAttackers_1 WAVE_zombie_extraAttackers_2";
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_InstanceFocus AddDefendMarker"; 
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects REF_InstanceFocus addToTrackingSet invasionBaseSet";         
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers_1")
   { 
      maxWaves = 2; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_1 5000"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet DestroyBase";            
      new ScriptGroup(ZomRespawnShips : ZomInvasion_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";                     
      };                    
   };
   new ScriptGroup("WAVE_zombie_extraAttackers_2")
   {
      maxWaves = 2; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_2 5000";   
      new ScriptGroup(ZomRespawnShips2 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "LightShips 10";                      
      };       
      new ScriptGroup(ZomRespawnShips3 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "LightShips 10";                      
      };  
      new ScriptGroup(ZomRespawnShips4 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "LightShips 10";                      
      };  
   };
}; 

new ScriptGroup(InvasionQuest_Medium_01 : InvasionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   invasionSize = 1; //0 = Small. 1 = Med, 2 = Large, 3 = Huge 
   
   title = "SMALL INVASION";  
   initialWaves = "WAVE_zombie_setup WAVE_zombie_extraAttackers_1 WAVE_zombie_extraAttackers_2 WAVE_zombie_extraAttackers_3";
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_InstanceFocus AddDefendMarker";
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects REF_InstanceFocus addToTrackingSet invasionBaseSet";             
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers_1")
   {
      maxWaves = 3; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_1 5000";   
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet DestroyBase";    
      new ScriptGroup(ZomRespawnShips : ZomInvasion_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 5";                      
      };                    
   };
   new ScriptGroup("WAVE_zombie_extraAttackers_2")
   {
      maxWaves = 3; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_2 5000";     
      new ScriptGroup(ZomRespawnShips2 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "LightShips 10 AverageShips 10";                      
      };                    
   };
   new ScriptGroup("WAVE_zombie_extraAttackers_3")
   {
      maxWaves = 3; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_3 8000";     
      new ScriptGroup(ZomRespawnShips3 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";                      
      };                    
   };
}; 

new ScriptGroup(InvasionQuest_Large_01 : InvasionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   invasionSize = 2; //0 = Small. 1 = Med, 2 = Large, 3 = Huge 
   
   title = "LARGE INVASION";  
   initialWaves = "WAVE_zombie_setup WAVE_zombie_extraAttackers_1 WAVE_zombie_extraAttackers_2 WAVE_zombie_extraAttackers_3";
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_InstanceFocus AddDefendMarker"; 
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects REF_InstanceFocus addToTrackingSet invasionBaseSet";              
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers_1")
   {
      maxWaves = 1; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_1";   
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet DestroyBase";                    
      new ScriptGroup(ZomRespawnShips : ZomInvasion_Ships)
      {                                      
          instanceObjectWeightedList = "HeavyShips 10";  //(1 heavy attacker)                  
      };                    
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers_2")
   {
      maxWaves = 4; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_2";       
      new ScriptGroup(ZomRespawnShips2 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";                      
      };                    
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers_3")
   {
      maxWaves = 4; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_3 8000";     
      new ScriptGroup(ZomRespawnShips3 : ZomInvasion_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";                      
      }; 
      new ScriptGroup(ZomRespawnShips4 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";                      
      };                    
   };
}; 

new ScriptGroup(InvasionQuest_Huge_01 : InvasionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   invasionSize = 3; //0 = Small. 1 = Med, 2 = Large, 3 = Huge 
   
   title = "HUGE INVASION";    
   initialWaves = "WAVE_zombie_setup WAVE_zombie_extraAttackers_1 WAVE_zombie_extraAttackers_2 WAVE_zombie_extraAttackers_3";
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";

      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_InstanceFocus AddDefendMarker";
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects REF_InstanceFocus addToTrackingSet invasionBaseSet";                 
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers_1")
   {
      maxWaves = 2; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_1";   
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet DestroyBase";           
      new ScriptGroup(ZomRespawnShips : ZomInvasion_Ships)
      {                                      
          instanceObjectWeightedList = "HeavyShips 2";  //2 Heavy attackers waves (will be huges)               
      };                    
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers_2")
   {
      maxWaves = 4; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_2";    
      new ScriptGroup(ZomRespawnShips2 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "AverageShips 5 HeavyShips 5"; //50/50 change of a huge)                     
      };                    
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers_3")
   {
      maxWaves = 4; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers_3 8000";     
      new ScriptGroup(ZomRespawnShips3 : ZomInvasion_Ships) //Anything marked ZomInvasion_Ships will attack base. 
      {                                      
          instanceObjectWeightedList = "AverageShips 10";                      
      };     
      new ScriptGroup(ZomRespawnShips5 : ZomInvasion_Ship_Seeker)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";                      
      };                    
   };
}; 












































