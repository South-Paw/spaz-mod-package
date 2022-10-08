
///////////////////////////////////////////////////////////
// AMBIENT MISSION 03A (INF BASE DEFEND no complete)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Ambient_03A : QuestBase_Ambient_Silent)
{
   addToDatabase = true;  //Important 
   
   DeployData["InstanceType"] = "Infrastructure";  //Security Infrastructure Hide
   DeployData["LevelRange"]     = "6 70"; //so it won't occur till a bit later
       
   title = "INF BASE DEFEND";  
   description = "nil";
   
   initialWaves = "";
   initialTimedCallbacks[0] = "5000 startWaveName UTA_attackers";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("UTA_attackers")
   {
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";    
      new ScriptGroup(UTAShips_01 : MO_Ships)
      {                                    
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 2 4"; 
         offset = "2000 3500"; 
         factionOverride = "terran";
         refObjectName = "REF_InstanceFocus"; 
         creationChance = 0.4; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";                        
      };
      //add more enemies
      new ScriptGroup(UTAShips_02 : UTAShips_01)
      {  
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1 1";  
         SelectionData["SecLevelRange"] = "2 3";                              
      };           
   };
}; 

///////////////////////////////////////////////////////////
// AMBIENT MISSION 03B (INF BASE DEFEND no complete)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Ambient_03B : QuestBase_Ambient_Silent)
{
   addToDatabase = true;  //Important 
   
   DeployData["InstanceType"] = "Infrastructure";  //Security Infrastructure Hide
   DeployData["LevelRange"]     = "6 70"; //so it won't occur till a bit later
       
   title = "INF BASE DEFEND HEAVY";  
   description = "nil";
   
   initialWaves = "";
   initialTimedCallbacks[0] = "5000 startWaveName UTA_attackers";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("UTA_attackers")
   {
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";    
      new ScriptGroup(UTAShips_01 : MO_Ships)
      {                                    
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "Scaled 2 4"; 
         offset = "2000 3500"; 
         factionOverride = "terran";
         refObjectName = "REF_InstanceFocus"; 
         creationChance = 0.3; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";                        
      };
      //add more enemies
      new ScriptGroup(UTAShips_02 : UTAShips_01)
      {  
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1 1";  
         SelectionData["SecLevelRange"] = "2 3";                              
      };           
   };
}; 