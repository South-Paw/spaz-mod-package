
///////////////////////////////////////////////////////////
// AMBIENT MISSION 05A (mothership attack no complete)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Ambient_05A : QuestBase_Ambient_Silent)
{
   addToDatabase = true;  //Important 
   
   DeployData["InstanceType"] = "Hide";  //Security Infrastructure Hide
   DeployData["LevelRange"]     = "6 70"; //so it won't occur till a bit later
       
   title = "MOTHERSHIP ATTACK";  
   description = "The Mothership is under attack.";
   
   missionText["attackCallout"] = "MT_ATTACK MOTHERSHIP UNDER ATTACK";
   
   initialTimedCallbacks[0] = "2500 StartWaveName CIV_WAVE";
   initialTimedCallbacks[1] = "7000 StartWaveName UTA_WAVE";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("CIV_WAVE")
   {
      maxWaves = 1;
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName CIV_WAVE_respawn 0"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy"; 
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;                               
      new ScriptGroup(CivShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 2 4"; 
         offset = "1000 1200"; 
         factionOverride = "Civ";                     
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
         SelectionData["Relations_Pirate_Civ"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
         objectFuncs["Spawn", 0] = "CallInstanceFunc StartWaveName AttackCalloutWave";
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";
         creationChance = 0.3;   
         new ScriptGroup(CivShips_02 : CivShips_01)
         {                                      
            objectCount = "Scaled 1 3"; 
            SelectionData["Relations_Pirate_Civ"] = $FactionRelation_HATE SPC $FactionRelation_ENEMY;        
         };       
      };            
   };
   
   new ScriptGroup("CIV_WAVE_respawn")
   {
      maxWaves = 2;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName CIV_WAVE_respawn 0";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                           
      new ScriptGroup(UTAShips_03 : MO_Ships)
      {     
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";                               
         instanceObjectWeightedList = "LightShips 10 AverageShips 5";
         objectCount = "Scaled 1 3"; 
         offset = "3000 4000"; 
         factionOverride = "civ"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
         respectShipCount = 4; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";                    
      };               
   };
   
   new ScriptGroup("UTA_WAVE")
   {
      maxWaves = 1; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName UTA_WAVE_respawn 0"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";  
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;                           
      new ScriptGroup(UTAShips_01 : MO_Ships)
      {                                    
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 2 4"; 
         offset = "1000 1200"; 
         factionOverride = "terran"; 
         SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
         objectFuncs["Spawn", 0] = "CallInstanceFunc StartWaveName AttackCalloutWave";    
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet"; 
         creationChance = 0.3; 
         new ScriptGroup(UTAShips_02 : UTAShips_01)
         {                                    
            objectCount = "Scaled 1 3"; 
            SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_ENEMY;                         
         };                        
      };               
   };
      
   new ScriptGroup("UTA_WAVE_respawn")
   {
      maxWaves = 2;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName UTA_WAVE_respawn 0";  
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                         
      new ScriptGroup(UTAShips_03 : MO_Ships)
      {     
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";                               
         instanceObjectWeightedList = "LightShips 10 AverageShips 5";
         objectCount = "Scaled 1 3"; 
         offset = "3000 4000"; 
         factionOverride = "terran"; 
         respectShipCount = 4;  
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";                    
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


///////////////////////////////////////////////////////////
// AMBIENT MISSION 05B (mothership attack no complete)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Ambient_05B : QuestBase_Ambient_Silent)
{
   addToDatabase = true;  //Important 
   
   DeployData["InstanceType"] = "Hide";  //Security Infrastructure Hide
   DeployData["LevelRange"]     = "25 70"; //so it won't occur till a bit later
       
   title = "HEAVY MOTHERSHIP ATTACK";  
   description = "The Mothership is under attack.";
   
   missionText["attackCallout"] = "MT_ATTACK MOTHERSHIP UNDER HEAVY ATTACK";
   
   initialTimedCallbacks[0] = "2500 StartWaveName CIV_WAVE";
   initialTimedCallbacks[1] = "7000 StartWaveName UTA_WAVE";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("CIV_WAVE")
   {
      maxWaves = 1;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName CIV_WAVE_respawn 0"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy"; 
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;                                 
      new ScriptGroup(CivShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 2 4"; 
         offset = "3000 4000"; 
         factionOverride = "Civ";                     
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
         SelectionData["Relations_Pirate_Civ"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE; 
         objectFuncs["Spawn", 0] = "CallInstanceFunc StartWaveName AttackCalloutWave";
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";
         creationChance = 0.3;  
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
         respectShipCount = 4;
         new ScriptGroup(CivShips_02 : CivShips_01)
         {                                      
            objectCount = "1"; 
            instanceObjectWeightedList = "HeavyShips 10";
            SelectionData["Relations_Pirate_Civ"] = $FactionRelation_HATE SPC $FactionRelation_ENEMY;        
         };       
      };            
   };
   
   new ScriptGroup("CIV_WAVE_respawn")
   {
      maxWaves = 3;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName CIV_WAVE_respawn 0";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                           
      new ScriptGroup(UTAShips_03 : MO_Ships)
      {     
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";                               
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 3";
         objectCount = "Scaled 1 3"; 
         offset = "3000 4000"; 
         factionOverride = "civ"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
         respectShipCount = 4; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";                    
      };               
   };
   
   new ScriptGroup("UTA_WAVE")
   {
      maxWaves = 1;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName UTA_WAVE_respawn 0";  
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;                     
      new ScriptGroup(UTAShips_01 : MO_Ships)
      {                                    
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 2 4"; 
         offset = "3000 4000"; 
         factionOverride = "terran"; 
         SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;
         objectFuncs["Spawn", 0] = "CallInstanceFunc StartWaveName AttackCalloutWave";
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";     
         creationChance = 0.3; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         respectShipCount = 4;
         new ScriptGroup(UTAShips_02 : UTAShips_01)
         {                                    
            objectCount = "1"; 
            instanceObjectWeightedList = "HeavyShips 10";
            SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_ENEMY;                         
         };                        
      };               
   };
   
   new ScriptGroup("UTA_WAVE_respawn")
   {
      maxWaves = 3;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName UTA_WAVE_respawn 0";  
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                         
      new ScriptGroup(UTAShips_03 : MO_Ships)
      {     
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";                               
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 3";
         objectCount = "Scaled 1 3"; 
         offset = "3000 4000"; 
         factionOverride = "terran"; 
         respectShipCount = 4;  
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";                    
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

