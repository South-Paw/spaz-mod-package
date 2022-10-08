
new ScriptGroup(ExtortionQuestBase : QuestBase_Event)
{   
   addToDatabase    = false;  //should just be inherited from 
   
   locksScreenSelector = true; //don't flee during this time, bad idea
    
   quietFinish      = true;
   deactivateOnFail = false; //Game over.
   failOnWarpout    = false; //must be false cuz of jiggery pokery. 
   //gameOverOnFail   = true;  //mothership will fail game on its own
   maxCompletes     = -1;
   
   description = "The Bounty Hunters want payment... NOW.";
   
   overrideMarker = "objectiveMarker_bountyBaseImageMap";
   
   rarity = "BountyExtortion"; //THIS IS IMPORTANT FLAG 

   Rewards["Complete", "Resource"] = "";
   Rewards["Complete", "Data"]     = "";
  
   //These missions are selected and not deployed or saved.
   //Probably need a special flag for this to keep mission system from barfing.   
     
   expiryTurns    = 3; //never expires. 
   
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

   Callbacks["Complete"] = "EXT_OnExtortionMissionComplete";
   Callbacks["BeaconArrival"] = "EXT_OnBeaconArrival"; //This will start the right waves.
};

new ScriptGroup(BOUNTY_WAVE_BASE_START)
{
   maxWaves = 1;
   healthCallbackSets = "enemy"; 
   waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";   
   waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand MotherAttackSet DestroyBeacon";  
};
new ScriptGroup(BOUNTY_WAVE_BASE_RESPAWN)
{
   maxWaves = 1;
   healthCallbackSets = "enemy";
   setHealthCallback["all", "enemy", 0] = "0 StartWaveName BOUNTY_WAVE_RESPAWN_1 0"; //SPAWN 2 SETS        
};
new ScriptGroup(EXTORTION_SHIPS_BASE : MO_Ships)
{                                      
   instanceObjectWeightedList = "AverageShips 10";
   objectCount = "Scaled 2 4"; 
   offset = "4000"; 
   factionOverride = "Bounty";                     
   hullBitMatching = $SST_HULL_ANY; 
   onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
   objectFuncs["Spawn", 0] = "QAI_AddToSet SeekAndDestroySet";
   objectFuncs["Spawn", 1] = "CallInstanceFunc StartWaveName AttackCalloutWave";
   creationChance = 1;            
}; 
new ScriptGroup(EXTORTION_SHIPS_MOM_ATTACK : MO_Ships)
{                                      
   instanceObjectWeightedList = "AverageShips 10";
   objectCount = "Scaled 2 4"; 
   offset = "4000"; 
   factionOverride = "Bounty";                     
   hullBitMatching = $SST_HULL_ANY; 
   onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
   objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet";  //attack mom   
   objectFuncs["Spawn", 1] = "CallInstanceFunc StartWaveName AttackCalloutWave";
   creationChance = 1;            
}; 
      
new ScriptGroup(EXTORTION_Turrets : MO_Ships)
{                                      
   instanceObjectWeightedList = "SpawnMyShip";
   offset = "1200"; 
   factionOverride = "Bounty";
   shipDesignWL = "DeployTurretShip_BattleStation 10";      
   objectCount = "1";                   
   refObjectName = "REF_Beacon";
}; 

//////////////////////////////////
// Small Extortions
//////////////////////////////////

new ScriptGroup(Extortion_Small_01 : ExtortionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   extortionSize = 1; //1 = Small. 2 = Med, 3 = Large, 4 = Huge 
   
   //Only called is Extortion rejected.
   EXT_initialTimedCallbacks[0] = "1500 StartWaveName BOUNTY_WAVE_START"; 
     
   title = "SMALL EXTORTION";  
   missionText["attackCallout"] = "MT_ATTACK MOTHERSHIP UNDER SMALL ATTACK";
       
   new ScriptGroup("BOUNTY_WAVE_START" : BOUNTY_WAVE_BASE_START)
   {      
      waveTimedCallbacks[1, 2] = "1000 StartWaveName BOUNTY_WAVE_RESPAWN_1 0"; //SPAWN 2 SETS
      waveTimedCallbacks[1, 3] = "5000 StartWaveName BOUNTY_WAVE_RESPAWN_1 0"; //SPAWN 2 SETS     
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1";        
      };         
   };
   
   new ScriptGroup("BOUNTY_WAVE_RESPAWN_1" : BOUNTY_WAVE_BASE_RESPAWN)
   {
      maxWaves = 8;        
      setHealthCallback[8, "enemy", 0] = "0 StartWaveName questComplete"; 
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "TinyShips 10";
         objectCount = "1";        
      };
      new ScriptGroup(BountyShips_02 : EXTORTION_SHIPS_MOM_ATTACK)
      {                                      
         instanceObjectWeightedList = "TinyShips 10";
         objectCount = "1";        
      };          
   };
   
   //these are called when ships spawn .. we can not attack to the wave because the selectionData is on the instanceObjects and the wave fires regardless
   //the waves are set to 1 so they only call once, but every spawned ship will ping this wave
   new ScriptGroup("AttackCalloutWave")
   {
      maxWaves = 1;    
      waveContext[1] = "attackCallout";                                      
   };
}; 

//////////////////////////////////
// Medium Extortions
//////////////////////////////////

new ScriptGroup(Extortion_Medium_01 : ExtortionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   extortionSize = 2; //1 = Small. 2 = Med, 3 = Large, 4 = Huge 
   
   //Only called is Extortion rejected.
   EXT_initialTimedCallbacks[0] = "1500 StartWaveName BOUNTY_WAVE_START";    
   
   title = "MEDIUM EXTORTION";  
   missionText["attackCallout"] = "MT_ATTACK MOTHERSHIP UNDER MEDIUM ATTACK";
       
   new ScriptGroup("BOUNTY_WAVE_START" : BOUNTY_WAVE_BASE_START)
   {   
      waveTimedCallbacks[1, 2] = "1000 StartWaveName BOUNTY_WAVE_RESPAWN_1 0"; //SPAWN 2 SETS
      waveTimedCallbacks[1, 3] = "5000 StartWaveName BOUNTY_WAVE_RESPAWN_1 0"; //SPAWN 2 SETS           
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1";        
      };
      //extra stuff      
      new ScriptGroup(BountyTurrets_01 : EXTORTION_Turrets)
      {     
         SelectionData["LevelRange"]     = "30 100";                                 
         shipDesignWL = "DeployTurretShip_Surplus 10";  //_Surplus _Basic _Ion _Leech _BattleStation _TorpedoRack
      };   
      new ScriptGroup(BountyTurrets_02 : EXTORTION_Turrets)
      {     
         SelectionData["LevelRange"]     = "40 100";                                 
         shipDesignWL = "DeployTurretShip_Basic 10";  //_Surplus _Basic _Ion _Leech _BattleStation _TorpedoRack
      };              
   };
   
   new ScriptGroup("BOUNTY_WAVE_RESPAWN_1" : BOUNTY_WAVE_BASE_RESPAWN)
   {
      maxWaves = 6;                
      setHealthCallback[6, "enemy", 0] = "0 StartWaveName questComplete"; 
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1";        
      };
      new ScriptGroup(BountyShips_02 : EXTORTION_SHIPS_MOM_ATTACK)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1";        
      };            
   };
   
   //these are called when ships spawn .. we can not attack to the wave because the selectionData is on the instanceObjects and the wave fires regardless
   //the waves are set to 1 so they only call once, but every spawned ship will ping this wave
   new ScriptGroup("AttackCalloutWave")
   {
      maxWaves = 1;    
      waveContext[1] = "attackCallout";                                      
   };
   
}; 

//////////////////////////////////
// Large Extortions
//////////////////////////////////

new ScriptGroup(Extortion_Large_01 : ExtortionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   extortionSize = 3; //1 = Small. 2 = Med, 3 = Large, 4 = Huge 
   
   //Only called is Extortion rejected.
   EXT_initialTimedCallbacks[0] = "1500 StartWaveName BOUNTY_WAVE_START";    
   
   title = "LARGE EXTORTION";  
   missionText["attackCallout"] = "MT_ATTACK MOTHERSHIP UNDER LARGE ATTACK";
       
   new ScriptGroup("BOUNTY_WAVE_START" : BOUNTY_WAVE_BASE_START)
   {   
      waveTimedCallbacks[1, 2] = "1000 StartWaveName BOUNTY_WAVE_RESPAWN_1 0"; //SPAWN 2 SETS
      waveTimedCallbacks[1, 3] = "5000 StartWaveName BOUNTY_WAVE_RESPAWN_1 0"; //SPAWN 2 SETS            
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "1";        
      };
      //extra stuff      
      new ScriptGroup(BountyTurrets_01 : EXTORTION_Turrets)
      {     
         SelectionData["LevelRange"]     = "30 100";                                 
         shipDesignWL = "DeployTurretShip_Basic 10";  //_Surplus _Basic _Ion _Leech _BattleStation _TorpedoRack
      };
      new ScriptGroup(BountyTurrets_02 : EXTORTION_Turrets)
      {  
         SelectionData["LevelRange"]     = "35 100";                                 
         shipDesignWL = "DeployTurretShip_TorpedoRack 10";  //_Surplus _Basic _Ion _Leech _BattleStation _TorpedoRack   
      };    
      new ScriptGroup(BountyTurrets_03 : EXTORTION_Turrets)
      {     
         SelectionData["LevelRange"]     = "40 100";                                 
         shipDesignWL = "DeployTurretShip_Ion 10";  //_Surplus _Basic _Ion _Leech _BattleStation _TorpedoRack
      };              
   };
   
   new ScriptGroup("BOUNTY_WAVE_RESPAWN_1" : BOUNTY_WAVE_BASE_RESPAWN)
   {
      maxWaves = 6;                
      setHealthCallback[6, "enemy", 0] = "0 StartWaveName BOUNTY_WAVE_RESPAWN_BOSS"; 
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1";        
      };
      new ScriptGroup(BountyShips_02 : EXTORTION_SHIPS_MOM_ATTACK)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1";        
      };           
   };
   
   new ScriptGroup("BOUNTY_WAVE_RESPAWN_BOSS" : BOUNTY_WAVE_BASE_RESPAWN)
   {
      setHealthCallback[1, "enemy", 0] = "0 StartWaveName questComplete";  
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1";        
      };     
   };
   
   //these are called when ships spawn .. we can not attack to the wave because the selectionData is on the instanceObjects and the wave fires regardless
   //the waves are set to 1 so they only call once, but every spawned ship will ping this wave
   new ScriptGroup("AttackCalloutWave")
   {
      maxWaves = 1;    
      waveContext[1] = "attackCallout";                                      
   };
   
}; 


//////////////////////////////////
// Huge Extortions
//////////////////////////////////

new ScriptGroup(Extortion_Huge_01 : ExtortionQuestBase)
{    
   addToDatabase    = true;  //Important 
   
   //Special Flags:
   extortionSize = 4; //1 = Small. 2 = Med, 3 = Large, 4 = Huge 
   
   //Only called is Extortion rejected.
   EXT_initialTimedCallbacks[0] = "1500 StartWaveName BOUNTY_WAVE_START";    
   
   title = "HUGE EXTORTION";  
   missionText["attackCallout"] = "MT_ATTACK MOTHERSHIP UNDER HUGE ATTACK";
       
   new ScriptGroup("BOUNTY_WAVE_START" : BOUNTY_WAVE_BASE_START)
   {   
      waveTimedCallbacks[1, 2] = "1000 StartWaveName BOUNTY_WAVE_RESPAWN_1 0";  
      waveTimedCallbacks[1, 3] = "5000 StartWaveName BOUNTY_WAVE_RESPAWN_2 0"; //SPAWN 2 SETS
      waveTimedCallbacks[1, 4] = "8000 StartWaveName BOUNTY_WAVE_RESPAWN_2 0"; //SPAWN 2 SETS           
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1";        
      };
      //extra stuff      
      new ScriptGroup(BountyTurrets_01 : EXTORTION_Turrets)
      {     
         SelectionData["LevelRange"]     = "30 100";                                 
         shipDesignWL = "DeployTurretShip_TorpedoRack 10";  //_Surplus _Basic _Ion _Leech _BattleStation _TorpedoRack
      };
      new ScriptGroup(BountyTurrets_02 : EXTORTION_Turrets)
      {  
         SelectionData["LevelRange"]     = "35 100";                                 
         shipDesignWL = "DeployTurretShip_BattleStation 10";  //_Surplus _Basic _Ion _Leech _BattleStation _TorpedoRack   
      };    
      new ScriptGroup(BountyTurrets_03 : EXTORTION_Turrets)
      {     
         SelectionData["LevelRange"]     = "40 100";                                 
         shipDesignWL = "DeployTurretShip_Leech 10";  //_Surplus _Basic _Ion _Leech _BattleStation _TorpedoRack
      };                
   };
   
   new ScriptGroup("BOUNTY_WAVE_RESPAWN_1" : BOUNTY_WAVE_BASE_RESPAWN)
   {
      maxWaves = 4;                
      setHealthCallback[3, "enemy", 0] = "0 StartWaveName BOUNTY_WAVE_RESPAWN_BOSS"; //KILLING BIG SHIPS WILL FINISH THE EVENT
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "1";        
      };          
   };
   
   new ScriptGroup("BOUNTY_WAVE_RESPAWN_2" : BOUNTY_WAVE_BASE_RESPAWN)
   {
      maxWaves = 10; 
      
      //causes nasty infinite spawning case.  better to have a higher wave count (was 6) but not infinite.  
      //setHealthCallback["all", "enemy", 0] = "0 StartWaveName BOUNTY_WAVE_RESPAWN_2 0";          
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_MOM_ATTACK)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1";        
      };     
   };
   
   new ScriptGroup("BOUNTY_WAVE_RESPAWN_BOSS" : BOUNTY_WAVE_BASE_RESPAWN)
   {
      setHealthCallback[1, "enemy", 0] = "0 StartWaveName questComplete";  
      new ScriptGroup(BountyShips_01 : EXTORTION_SHIPS_BASE)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1";        
      };     
   };
   
   //these are called when ships spawn .. we can not attack to the wave because the selectionData is on the instanceObjects and the wave fires regardless
   //the waves are set to 1 so they only call once, but every spawned ship will ping this wave
   new ScriptGroup("AttackCalloutWave")
   {
      maxWaves = 1;    
      waveContext[1] = "attackCallout";                                      
   };
}; 
