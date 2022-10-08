
///////////////////////////////////////////////////////////
// COMBAT EVENTS
///////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////
// UTA VS CIV
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_CombatEvent_01 : QuestBase_Ambient_Zone)
{
   addToDatabase = true;  //Important 
       
   title = "UTA VS CIVS";  
   description = "A conflict has erupted in this area between the UTA and the Civilians.  Intervene at your own risk.";
  
   initialWaves = "WAVE_conflict_uta1 WAVE_conflict_uta2 WAVE_conflict_civ1 WAVE_conflict_civ2 MADD_WAVE";
   
   hiddenTracker = true;  
   
   DeployData["LevelRange"]     = "2 70"; //hold back
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
       
   new ScriptGroup("WAVE_conflict_uta1")
   {
      maxWaves = 6;        
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_uta2")
   {
      maxWaves = 3;        
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta2 5000"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_civ1")
   {
      maxWaves = 6;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                   
      new ScriptGroup(Civ_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_civ2")
   {
      maxWaves = 3;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ2 5000";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                 
      new ScriptGroup(Civ_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet"; 
      };
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(Civ_Station : MADD_Civ_Base) 
      {    
      }; 
      new ScriptGroup(UTA_Station : MADD_UTA_Base) 
      {    
      }; 
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      {                      
      }; 
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      {                      
      };   
   };
}; 

///////////////////////////////////////////////////////////
// UTA VS CIV B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_CombatEvent_01B : QuestBase_Ambient_Zone)
{
   addToDatabase = true;  //Important 
       
   title = "CIVS VS UTA";  //flip the name so it doesn't colide with version A
   description = "A heavy conflict has erupted in this area between the UTA and the Civilians.  Intervene at your own risk.";
  
   initialWaves = "WAVE_conflict_uta1 WAVE_conflict_uta2 WAVE_conflict_civ1 WAVE_conflict_civ2 MADD_WAVE";
   
   hiddenTracker = true;  
   
   DeployData["LevelRange"]     = "6 70"; //hold back for a while
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
       
   new ScriptGroup("WAVE_conflict_uta1")
   {
      maxWaves = 10;        
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_uta2")
   {
      maxWaves = 5;        
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta2 5000"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_civ1")
   {
      maxWaves = 10;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                   
      new ScriptGroup(Civ_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_civ2")
   {
      maxWaves = 5;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ2 5000";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                 
      new ScriptGroup(Civ_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";  
      };
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(Civ_Station : MADD_Civ_Base) 
      {    
      }; 
      new ScriptGroup(UTA_Station : MADD_UTA_Base) 
      {    
      }; 
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      {                      
      }; 
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      {                      
      };   
   };
}; 


///////////////////////////////////////////////////////////
// UTA VS CIV C
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_CombatEvent_01C : QuestBase_Ambient_Zone)
{
   addToDatabase = true;  //Important 
       
   title = "CIV PATROL VS UTA PATROL";  //flip the name so it doesn't colide with version A
   description = "A light conflict has erupted in this area between the UTA and the Civilians.  Intervene at your own risk.";
  
   initialWaves = "WAVE_conflict_uta1 WAVE_conflict_uta1 WAVE_conflict_civ1 WAVE_conflict_civ1 MADD_WAVE"; //double up on waves
   
   hiddenTracker = true;  
   
   DeployData["LevelRange"]     = "1 30"; //front load the easy ones
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
       
   new ScriptGroup("WAVE_conflict_uta1")
   {
      maxWaves = 5;        
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_civ1")
   {
      maxWaves = 5;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                   
      new ScriptGroup(Civ_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(Civ_Station : MADD_Civ_Base) 
      {    
      }; 
      new ScriptGroup(UTA_Station : MADD_UTA_Base) 
      {    
      }; 
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      {                      
      }; 
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      {                      
      };  
   };
}; 


///////////////////////////////////////////////////////////
// UTA VS ZOMBIE
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_CombatEvent_02 : QuestBase_Ambient_Zone)
{
   addToDatabase = true;  //Important 
       
   title = "UTA VS ZOMBIES";  
   description = "A conflict has erupted in this area between the UTA and the Zombies.  Intervene at your own risk.";
  
   initialWaves = "WAVE_conflict_uta1 WAVE_conflict_uta2 WAVE_conflict_zom1 WAVE_conflict_zom2 MADD_WAVE";
   
   hiddenTracker = true; 
   
   DeployData["StarType"] = "INNER";
   SelectionData["InfectionLevel"]     = "1 3"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
       
   new ScriptGroup("WAVE_conflict_uta1")
   {
      maxWaves = 10;        
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_uta2")
   {
      maxWaves = 5;        
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta2 5000"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_zom1")
   {
      maxWaves = 1;  
      new ScriptGroup(Zom_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Zombie";                     
         refObjectName = "REF_Beacon";
      };
   };
   
   new ScriptGroup("WAVE_conflict_zom2")
   {
      maxWaves = 5;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_zom2 5000"; 
      new ScriptGroup(Zom_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
      };
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(ZOM_Station : MADD_Zom_Base)
      {                      
      };   
      new ScriptGroup(UTA_Station : MADD_UTA_Base) 
      {    
      }; 
      new ScriptGroup(UTA_Station : MADD_UTA_Base) //up to 2 stations
      {    
      }; 
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      {                      
      };   
   };
}; 

///////////////////////////////////////////////////////////
// CIV VS ZOMBIE
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_CombatEvent_03 : QuestBase_Ambient_Zone)
{
   addToDatabase = true;  //Important 
       
   title = "CIVS VS ZOMBIES";  
   description = "A conflict has erupted in this area between the Civilians and the Zombies.  Intervene at your own risk.";
  
   initialWaves = "WAVE_conflict_civ1 WAVE_conflict_civ2 WAVE_conflict_zom1 WAVE_conflict_zom2 MADD_WAVE";
   
   hiddenTracker = true; 
   
   DeployData["StarType"] = "INNER";
   SelectionData["InfectionLevel"]     = "1 3"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
       
   new ScriptGroup("WAVE_conflict_civ1")
   {
      maxWaves = 10;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                   
      new ScriptGroup(Civ_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_civ2")
   {
      maxWaves = 5;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ2 5000";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                 
      new ScriptGroup(Civ_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";  
      };
   };
   
   new ScriptGroup("WAVE_conflict_zom1")
   {
      maxWaves = 1;  
      new ScriptGroup(Zom_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Zombie";                     
         refObjectName = "REF_Beacon";
      };
   };
   
   new ScriptGroup("WAVE_conflict_zom2")
   {
      maxWaves = 5;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_zom2 5000"; 
      new ScriptGroup(Zom_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
      };
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {  
      new ScriptGroup(ZOM_Station : MADD_Zom_Base)
      {                      
      };    
      new ScriptGroup(Civ_Station : MADD_Civ_Base) 
      {    
      };
      new ScriptGroup(Civ_Station : MADD_Civ_Base) //UP TO 2 STATIONS
      {    
      };  
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      {                      
      };  
   };
}; 

///////////////////////////////////////////////////////////
// 3 WAY WAR
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_CombatEvent_04 : QuestBase_Ambient_Zone)
{
   addToDatabase = true;  //Important 
       
   title = "THREE WAY WARZONE";  
   description = "A massive conflict has erupted in this area between the UTA, Civilians and Zombies.  Intervene at your own risk.";
  
   initialWaves = "WAVE_conflict_uta1 WAVE_conflict_civ1 WAVE_conflict_zom1 WAVE_conflict_zom2 MADD_WAVE";
   
   hiddenTracker = true; 
   
   DeployData["StarType"] = "INNER";
   SelectionData["SectorProgress"]     = "1 3";
   SelectionData["InfectionLevel"]     = "1 3"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
       
   new ScriptGroup("WAVE_conflict_uta1")
   {
      maxWaves = 10;        
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_civ1")
   {
      maxWaves = 10;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                   
      new ScriptGroup(Civ_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_zom1")
   {
      new ScriptGroup(Zom_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Zombie";                     
         refObjectName = "REF_Beacon";
      };
   };
   
   new ScriptGroup("WAVE_conflict_zom2")
   {
      maxWaves = 10;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_zom2 5000"; 
      new ScriptGroup(Zom_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
      };
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(ZOM_Station : MADD_Zom_Base)
      {                      
      };   
      new ScriptGroup(Civ_Station : MADD_Civ_Base) 
      {    
      }; 
      new ScriptGroup(UTA_Station : MADD_UTA_Base) 
      {    
      }; 
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      {                      
      };
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      {                      
      };   
   };
};


///////////////////////////////////////////////////////////
// ZOMBIE VS RESISTANCE
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_CombatEvent_05 : QuestBase_Ambient_Zone)
{
   addToDatabase = true;  //Important 
       
   title = "RESISTANCE VS ZOMBIE";  
   description = "Resistance fighters are in conflict with the zombie infection.  Intervene at your own risk.";
  
   initialWaves = "WAVE_conflict_uta1 WAVE_conflict_civ1 WAVE_conflict_zom1 WAVE_conflict_zom2 MADD_WAVE";
      
   hiddenTracker = true; 
   
   DeployData["StarType"] = "INNER";
   SelectionData["InfectionLevel"]     = "1 3"; 
   SelectionData["SectorProgress"] = "4 4"; //sec 4 spicific mission
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
       
  new ScriptGroup("WAVE_conflict_uta1")
   {
      maxWaves = 10;        
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_uta1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(UTA_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_civ1")
   {
      maxWaves = 10;  
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_civ1 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                   
      new ScriptGroup(Civ_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };
   };
   
   new ScriptGroup("WAVE_conflict_zom1")
   {
      maxWaves = 1;  
      new ScriptGroup(Zom_ships_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 10000";  
         objectCount = "2";
         factionOverride = "Zombie";                     
         refObjectName = "REF_Beacon";
      };
   };
   
   new ScriptGroup("WAVE_conflict_zom2")
   {
      maxWaves = 10;
      healthCallbackSets = "combatShips"; 
      setHealthCallback["all", "combatShips", 0] = "0 StartWaveName WAVE_conflict_zom2 5000"; 
      new ScriptGroup(Zom_ships_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "4000 10000";  
         objectCount = "1";
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet combatShips";
      };
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(ZOM_Station : MADD_Zom_Base)
      {                      
      };   
      new ScriptGroup(Civ_Station : MADD_Civ_Base) 
      {    
      }; 
      new ScriptGroup(UTA_Station : MADD_UTA_Base) 
      {    
      }; 
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      {                      
      };
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      {                      
      };   
   };
};
