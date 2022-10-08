
///////////////////////////////////////////////////////////
// BYSTAND 04 (zombie wreckage)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Bystand_04 : QuestBase_Bystand)
{
   addToDatabase = true;  //Important 
       
   title = "WRECK FIELD";  
   description = "Zombies have massacred a fleet of ships.  Debris and supplies are littered everywhere.  There may be salvage in the area.";
  
   rarity = "Uncommon"; 
   DeployData["Infrastructure"] = "Any"; //Any, Mining, Science, Colony
   
   SelectionData["InfectionLevel"]          = "1 3";
  
   initialWaves = "WAVE_SetupWreck MADD_WAVE";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_SetupWreck)
   {
      maxWaves = 1; 
      new ScriptGroup("REF_supplyDropUTA" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_UTASupply";
         offset = "2500 5000";      
         objectCount = "2 4";           
         refObjectName = "REF_Beacon";
      };
      new ScriptGroup("REF_supplyDrop_1" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_Crates";
         offset = "500 4000";      
         objectCount = "4 8";           
         refObjectName = "REF_beacon";
      }; 
      new ScriptGroup("REF_supplyDrop_2" : REF_supplyDrop_1) 
      {
         creationChance = 0.2;
      }; 
      new ScriptGroup("REF_supplyDrop_3" : REF_supplyDrop_1) 
      {
         creationChance = 0.2;
      }; 
      new ScriptGroup("shipWrecks") 
      {    
         creationChance = 1;
         instanceObjectWeightedList = "ShipWreck_Graveyard 10";                                
         objectCount = "6 10";
         offset = "500 600";  
         refObjectName = ""; 
         wreckDatablockWL = "ShipWreck_BigBus 10 ShipWreck_Flora 10 ShipWreck_BigBrother 10 ShipWreck_RightHook 10 ShipWreck_Helix 10 ShipWreck_SunSpot_Left 5 ShipWreck_SunSpot_Right 5 ShipWreck_terranStation_01 5 shipWreck_quasarStation_01 5 ShipWreck_stationDoodad_Large 5 ShipWreck_stationDoodad_Med02 5"; 
         objectCount = "12 15";  
      }; 
      new ScriptGroup("civ_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "1000 5000";  
         objectCount = "scaled 1 2";
         factionOverride = "Civ"; 
         shipSpawnHealth = 0.2;  //crippled 
      };
      new ScriptGroup("uta_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "1000 5000";  
         objectCount = "scaled 1 2";
         factionOverride = "Terran";
         shipSpawnHealth = 0.2;  //crippled  
      };
   };  
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      { 
         shipSpawnHealth = 0.2;  //crippled                      
      }; 
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      { 
         shipSpawnHealth = 0.2;  //crippled                      
      };   
   };
};