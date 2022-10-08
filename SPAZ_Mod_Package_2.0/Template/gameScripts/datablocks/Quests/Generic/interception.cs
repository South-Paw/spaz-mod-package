///////////////////////////////////////////////////////////
// ZOMBIE INTERCEPTION MISSIONS
///////////////////////////////////////////////////////////
//Called when zombies intercept mothership in sector 4
//These missions are holdout style and once timer runs out, we warp to destination instance.

new ScriptGroup(InterceptionQuestBase : QuestBase_Event)
{   
   addToDatabase    = false;  //should just be inherited from 
   
   locksScreenSelector = true; //don't flee during this time, bad idea
    
   deactivateOnFail = false; //Game over.
   failOnWarpout    = false; //must be false cuz of jiggery pokery. 
   //gameOverOnFail   = true;  //mothership will fail game on its own
   maxCompletes     = -1;
   
   description = "The mothership is trying to flee the system, but the zombies have discovered its hidden position.  Defend the mothership long enough to make its escape.";
   
   overrideMarker = "objectiveMarker_zombieImageMap";
   
   SelectionData["InfectionLevel"] = "1 3"; 
   
   rarity = "ZombieIntercept"; //THIS IS IMPORTANT FLAG 

   Rewards["Complete", "Resource"] = "";
   Rewards["Complete", "Data"]     = "";
  
   //These missions are selected and not deployed or saved.
   //Probably need a special flag for this to keep mission system from barfing.   
     
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


   Callbacks["Complete"] = "Sec4_OnZombieInterceptSuccess";
   
   Callbacks["BeaconArrival"] = "Sec4_StartReinforcementsFromQuest GuardMothership";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "125000 StartWaveName QuestComplete";
   
   missionText["initial"] = "MT_DEFEND DEFEND THE MOTHERSHIP";
   missionText["defTime"] = "MT_INFO DEFEND TIME";
   missionText["wavesLeft"] = "MT_INFO nil";
   missionText["respawnTime"] = "MT_INFO nil";
   missionText["motherHealth"] = "MT_INFO nil";
   
   missionTrackerData[0] = "initial MT_HEALTHBAR NOSET_isMothership";
   missionTrackerData[1] = "defTime MT_TIMERTEXT 125";
   missionTrackerData[2] = "wavesLeft MT_EVAL AWG_GetWavesLeftText";
   missionTrackerData[3] = "respawnTime MT_EVAL AWG_GetRespawnTimeText";
};


//////////////////////////////////
// Small Interceptions
//////////////////////////////////

new ScriptGroup(Interception_Small_01 : InterceptionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   interceptionSize = 0; //0 = Small. 1 = Med, 2 = Large, 3 = Huge 
   
   
   title = "SMALL MOTHERSHIP ASSAULT";  
   initialWaves = "WAVE_zombie_setup WAVE_zombie_bugger";
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      waveTimedCallbacks[1, 0] = "5000 StartWaveName WAVE_zombie_extraAttackers 0";
      waveTimedCallbacks[1, 1] = "20000 StartWaveName WAVE_zombie_extraAttackers 0";             
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers")
   {
      maxWaves = -1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet DestroyBeacon"; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers 8000";            
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10 AverageShips 5";
          offset = "4000 6000";  
          objectCount = "1";
          factionOverride = "Zombie"; 
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";                      
      };
      new ScriptGroup(ZomRespawnShips_killers : ZomRespawnShips)
      {       
         objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet";  //attack mom                              
         factionOverride = "ZombieKiller";             
      };                      
   };
   
   new ScriptGroup("WAVE_zombie_bugger")
   {
      maxWaves = -1; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_bugger 2000";            
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10";
          offset = "2000 3000";  
          objectCount = "1";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";                      
      };                    
   };
}; 

//////////////////////////////////
// Medium Interceptions 
//////////////////////////////////

new ScriptGroup(Interception_Medium_01 : InterceptionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   interceptionSize = 1; //0 = Small. 1 = Med, 2 = Large, 3 = Huge 
   
   
   title = "MOTHERSHIP ASSAULT ";  
   initialWaves = "WAVE_zombie_setup WAVE_zombie_bugger";
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      waveTimedCallbacks[1, 0] = "5000 StartWaveName WAVE_zombie_extraAttackers 0";
      waveTimedCallbacks[1, 1] = "14000 StartWaveName WAVE_zombie_extraAttackers 0";             
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers")
   {
      maxWaves = -1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet DestroyBeacon"; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers 6000";            
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";
          offset = "4000 6000";  
          objectCount = "1";
          factionOverride = "Zombie"; 
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";                      
      };
      new ScriptGroup(ZomRespawnShips_killers : ZomRespawnShips)
      {       
         objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet";  //attack mom                              
         factionOverride = "ZombieKiller";             
      };                      
   };
   
   new ScriptGroup("WAVE_zombie_bugger")
   {
      maxWaves = -1; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_bugger 2000";            
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10";
          offset = "2000 3000";  
          objectCount = "1";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";                      
      };                    
   };
}; 

//////////////////////////////////
// Large Interceptions 
//////////////////////////////////

new ScriptGroup(Interception_Large_01 : InterceptionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   interceptionSize = 2; //0 = Small. 1 = Med, 2 = Large, 3 = Huge 
   
   title = "LARGE MOTHERSHIP ASSAULT "; 
   initialWaves = "WAVE_zombie_setup WAVE_zombie_bugger"; 
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      waveTimedCallbacks[1, 0] = "5000 StartWaveName WAVE_zombie_extraAttackers 0";
      waveTimedCallbacks[1, 1] = "12000 StartWaveName WAVE_zombie_extraAttackers 0";             
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers")
   {
      maxWaves = -1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet DestroyBeacon"; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers 5000";            
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10 HeavyShips 3";
          offset = "4000 6000";  
          objectCount = "1";
          factionOverride = "Zombie"; 
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";                      
      };
      new ScriptGroup(ZomRespawnShips_killers : ZomRespawnShips)
      {       
         objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet";  //attack mom                              
         factionOverride = "ZombieKiller";             
      };                      
   };
   
   new ScriptGroup("WAVE_zombie_bugger")
   {
      maxWaves = -1; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_bugger 2000";            
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10";
          offset = "2000 3000";  
          objectCount = "1";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";                      
      };                    
   };
}; 

//////////////////////////////////
// Huge Interceptions
//////////////////////////////////

new ScriptGroup(Interception_Huge_01 : InterceptionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   interceptionSize = 3; //0 = Small. 1 = Med, 2 = Large, 3 = Huge 
   
   title = "HUGE MOTHERSHIP ASSAULT"; 
   initialWaves = "WAVE_zombie_setup WAVE_zombie_bugger"; 
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      WaveMissionTrackers["active", 1] = "0 1 2 3";
      waveTimedCallbacks[1, 0] = "5000 StartWaveName WAVE_zombie_extraAttackers 0";
      waveTimedCallbacks[1, 1] = "10000 StartWaveName WAVE_zombie_extraAttackers 0";             
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers")
   {
      maxWaves = -1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet DestroyBeacon"; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_extraAttackers 4000";            
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10 HeavyShips 6";
          offset = "4000 6000";  
          objectCount = "1";
          factionOverride = "Zombie"; 
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";                      
      };
      new ScriptGroup(ZomRespawnShips_killers : ZomRespawnShips)
      {       
         objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet";  //attack mom                              
         factionOverride = "ZombieKiller";         
      };                      
   };
   
   new ScriptGroup("WAVE_zombie_bugger")
   {
      maxWaves = -1; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_zombie_bugger 2000";            
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10";
          offset = "2000 3000";  
          objectCount = "1";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Beacon";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";                      
      };                    
   };
}; 

