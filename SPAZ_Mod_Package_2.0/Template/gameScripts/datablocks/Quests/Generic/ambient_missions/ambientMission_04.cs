
///////////////////////////////////////////////////////////
// AMBIENT MISSION 04 (cargo ship arives and does something cool / can be attacked) 
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Ambient_04 : QuestBase_Ambient_Silent)
{
   addToDatabase = true;  //Important 
   
   DeployData["InstanceType"] = "Infrastructure";  //Security Infrastructure Hide
   DeployData["LevelRange"]     = "6 70"; //so it won't occur till a bit later
       
   title = "STARBASE DROPOFF";  
   description = "nil";
   
   initialTimedCallbacks[0] = "5000 startWaveName CIV_ESCORTSHIP";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("CIV_ESCORTSHIP")
   {
      maxWaves = 1;  
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand DropShipSet SetTactic TP_Collect TP_NoCollect";
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand DropShipSet SetTactic TP_Stance TP_Passive";  
      waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand DropShipSet MoveTo REF_InstanceFocus 0"; 
      waveTimedCallbacks[1, 3] = "0 QAI_SetAICommand DropWartOutSet SetTactic TP_Retreat TP_RetreatOn";   
       
      new ScriptGroup(REF_DropTrig : MO_Trigger) //we will use this to turn it on and off maybe? 
      {    
         triggerFuncs[0] = "ObjectFunc 1 DropShipSet DumpResources";                                    
         triggerFuncs[1] = "ObjectFunc 1 DropShipSet QAI_AddToSet DropWartOutSet"; 
         
         refObjectName = "REF_InstanceFocus";
      }; 
      new ScriptGroup(REF_ShipArea : MO_Trigger) 
      {                              
      };                       
      new ScriptGroup(REF_EscortShip : MO_Ships) 
      {   
         instanceObjectWeightedList = "HugeShips 10";
         offset = "4000 5000";  
         objectCount = "1 1";
         factionOverride = "Civ";                     
         refObjectName = "REF_InstanceFocus";   

         mountRefObjectNames = "REF_ShipArea"; 
         hullBitMatching = $SST_HULL_INF;    
         
         objectFuncs["Spawn", 0] = "QAI_AddToSet DropShipSet";  
         objectFuncs["Spawn", 1] = "AddResourcesFromQuest 150";  //peculiar bug with eval. needs a wrapper to get to code i think.   
         objectFuncs["Spawn", 2] = "CallInstanceFunc StartWaveName CIV_ESCORTSHIP_ATTACKERS 7500";                             
      };          
   };
   
   new ScriptGroup("CIV_ESCORTSHIP_ATTACKERS")
   {
      maxWaves = 1;
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE;               
      new ScriptGroup(UTAShips_01 : MO_Ships)
      {                                    
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 2 3"; 
         offset = "200 400"; 
         factionOverride = "terran";
         refObjectName = "REF_ShipArea";  
         SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4                      
      };          
   };
}; 
