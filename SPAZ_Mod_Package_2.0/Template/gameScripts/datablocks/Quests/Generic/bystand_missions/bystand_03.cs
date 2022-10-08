
///////////////////////////////////////////////////////////
// BYSTAND 03 (uta supply drop)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Bystand_03 : QuestBase_Bystand)
{
   addToDatabase = true;  //Important 
       
   title = "UTA SUPPLY DROP ZONE";  
   description = "The UTA have received a supply shipment and are staging it in this area.  They don't take kindly to people intruding on their supplies.";
  
   DeployData["Infrastructure"] = "Any"; //Any, Mining, Science, Colony
  
   initialWaves = "WAVE_SetupDrop MADD_WAVE";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_SetupDrop)
   {
      maxWaves = 1; 
      new ScriptGroup("REF_supplyDrop" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_UTASupply";
         offset = "2500 5000";      
         objectCount = "2 4";           
         refObjectName = "REF_Beacon";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName PickupPissoff";  
      };
      new ScriptGroup("REF_supplyDrop_3" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_Crates_Rich";
         offset = "500 1000";      
         objectCount = "2 4";           
         refObjectName = "REF_supplyDrop";
      };  
      new ScriptGroup("REF_supplyDrop_2" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_Crates";
         offset = "500 1000";      
         objectCount = "2 4";           
         refObjectName = "REF_supplyDrop";
      }; 
      new ScriptGroup("uta_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "0 0";  
         objectCount = "2 5";
         factionOverride = "Terran"; 
         refObjectName = "REF_supplyDrop";  
      };
   };
   
   new ScriptGroup("PickupPissoff")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "1000 callQuestFunction ChangePlayerRelations terran -1";
   };    
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      {                      
      }; 
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      {                      
      };   
   };
};