////////////////////////////////////////////////////////////////////////////////
//MISSION ADDS
////////////////////////////////////////////////////////////////////////////////


//search for CMADD to find all special hand crafted mission adds


////////////////////////////////////////////////////////////////////////////////
//BASIC WAVE SETUP
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(MADD_WaveBasic)
{                                     
   maxWaves = 1;  
   waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand MADD_Civ_HelperSet MoveTo REF_Player 0"; 
   waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand MADD_UTA_HelperSet MoveTo REF_Player 0";
   waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand MADD_SeekAndDestroy SetTactic TP_Stance TP_SeekAndDestroy";      
};  


////////////////////////////////////////////////////////////////////////////////
//CIV
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(MADD_Civ_Ped)
{                                    
   instanceObjectWeightedList = "AverageShips 10";
   offset = "3000 5000";  
   creationChance = 1;  
   objectCount = "1";
   factionOverride = "Civ";                     
   refObjectName = "REF_Beacon"; 
   hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
   SelectionData["InfraLevelRange"]     = "1 3";
   objectFuncs["Spawn", 0] = "QAI_AddToSet MADD_SeekAndDestroy";     
}; 

new ScriptGroup(MADD_CIV_Ambient : MADD_Civ_Ped)
{                                   
   offset = "3000 6000";
};

new ScriptGroup(MADD_Civ_Base : MADD_Civ_Ped)
{                                   
   instanceObjectWeightedList = "SpawnMyShip";
   offset = "4000 12000";  
   objectCount = "1";
   factionOverride = "Civ";
   creationChance = 0.4; 
   shipDesignWL = "OutpostBase 10 Pirate01Base 8 Pirate02Base 4 Pirate03Base 2";
   
   SelectionData["LevelRange"]     = "20 100"; //too hard early on
   SelectionData["InfraLevelRange"]     = "1 3";    
};

new ScriptGroup(MADD_Civ_Help)
{   
   instanceObjectWeightedList = "AverageShips 10";
   creationChance = 1;  
   objectCount = "1";
   factionOverride = "Civ";                     
   refObjectName = "REF_Beacon"; 
   hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
   
   objectFuncs["Spawn", 0] = "QAI_AddToSet MADD_Civ_HelperSet";
   offset = "4000 8000";  //they will come to you
   
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_LIKE SPC $FactionRelation_FRIEND; 
}; 

////////////////////////////////////////////////////////////////////////////////
//UTA
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(MADD_UTA_Ped)
{                                   
   instanceObjectWeightedList = "AverageShips 10";
   offset = "3000 5000";  
   creationChance = 1;
   objectCount = "1";
   factionOverride = "Terran";                     
   refObjectName = "REF_Beacon"; 
   SelectionData["SecLevelRange"]       = "2 3";
   objectFuncs["Spawn", 0] = "QAI_AddToSet MADD_SeekAndDestroy";     
}; 

new ScriptGroup(MADD_UTA_Ambient : MADD_UTA_Ped)
{                                   
   offset = "3000 6000";  
}; 

new ScriptGroup(MADD_UTA_Base : MADD_UTA_Ped)
{                                   
   instanceObjectWeightedList = "SpawnMyShip";
   offset = "4000 12000";  
   objectCount = "1";
   factionOverride = "Terran";
   creationChance = 0.4;
   shipDesignWL = "OutpostBase 10 Pirate01Base 8 Pirate02Base 4 Pirate03Base 2"; 
   
   SelectionData["LevelRange"]     = "20 100"; //too hard early on  
}; 

new ScriptGroup(MADD_UTA_Help)
{   
   instanceObjectWeightedList = "AverageShips 10";
   creationChance = 1;
   objectCount = "1";
   factionOverride = "Terran";                     
   refObjectName = "REF_Beacon"; 
      
   objectFuncs["Spawn", 0] = "QAI_AddToSet MADD_UTA_HelperSet";
   offset = "4000 8000";  //they will come to you
   
   SelectionData["Relations_Pirate_Terran"]    = $FactionRelation_LIKE SPC $FactionRelation_FRIEND; 
}; 

////////////////////////////////////////////////////////////////////////////////
//ZOMBIE
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(MADD_Zom_Base)
{                                   
   instanceObjectWeightedList = "SpawnMyShip";
   offset = "5000 7000";  
   objectCount = "1";
   factionOverride = "Zombie";
   creationChance = 0.5; 
   shipDesignWL = "OutpostBase_Zombie 10";                  
   refObjectName = "REF_Beacon";   
};

new ScriptGroup(MADD_ZombieNest)
{      
   //hook up pre reqs to this                                
   instanceObjectWeightedList = "AverageShips 10";
   offset = "4000 5000";  //far away so they have time to birth
   creationChance = 1; 
   objectCount = "1";
   factionOverride = "Zombie";                     
   refObjectName = "REF_Beacon"; 
   SelectionData["InfectionLevel"] = "1 3";
   objectFuncs["Spawn", 0] = "QAI_AddToSet MADD_SeekAndDestroy";     
}; 

new ScriptGroup(MADD_ZombieRocks)
{                                   
   instanceObjectWeightedList = "AsteroidCluster_zombie 10";
   offset = "0 0";  
   creationChance = 1;
   objectCount = "20 30";
}; 


