
///////////////////////////////////////////////////////////
// AMBIENT MISSION 02A (SEC BASE DEFEND no complete)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Ambient_02A : QuestBase_Ambient_Silent)
{
   addToDatabase = true;  //Important 
   
   DeployData["InstanceType"] = "Security";  //Security Infrastructure Hide
   DeployData["LevelRange"]     = "6 70"; //so it won't occur till a bit later
       
   title = "SEC BASE DEFEND";  
   description = "nil";
   
   initialWaves = "";
   initialTimedCallbacks[0] = "5000 startWaveName CIV_attackers";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("CIV_attackers")
   {
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE;
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";         
      new ScriptGroup(CIVShips_01 : MO_Ships)
      {                                    
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 2 3"; 
         offset = "800 1000"; 
         factionOverride = "civ";
         refObjectName = "REF_InstanceFocus"; 
         creationChance = 0.4; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;               
      };
      //add more enemies
      new ScriptGroup(CIVShips_02 : CIVShips_01)
      {  
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1 1";  
         SelectionData["InfraLevelRange"] = "2 3";                              
      };             
   };
}; 

///////////////////////////////////////////////////////////
// AMBIENT MISSION 02B (SEC BASE DEFEND no complete)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Ambient_02B : QuestBase_Ambient_Silent)
{
   addToDatabase = true;  //Important 
   
   DeployData["InstanceType"] = "Security";  //Security Infrastructure Hide
   DeployData["LevelRange"]     = "6 70"; //so it won't occur till a bit later
       
   title = "SEC BASE DEFEND HEAVY";  
   description = "nil";
   
   initialWaves = "";
   initialTimedCallbacks[0] = "5000 startWaveName CIV_attackers";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
      
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("CIV_attackers")
   {
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";      
      new ScriptGroup(CIVShips_01 : MO_Ships)
      {                                    
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "Scaled 2 3"; 
         offset = "2000 3500"; 
         factionOverride = "civ";
         refObjectName = "REF_InstanceFocus"; 
         creationChance = 0.3; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";   
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;             
      }; 
      //add more enemies
      new ScriptGroup(CIVShips_02 : CIVShips_01)
      {  
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1 1";  
         SelectionData["InfraLevelRange"] = "2 3";                              
      };          
   };
}; 
