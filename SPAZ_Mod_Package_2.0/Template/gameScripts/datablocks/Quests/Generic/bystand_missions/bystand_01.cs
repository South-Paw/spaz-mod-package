
///////////////////////////////////////////////////////////
// BYSTAND 01 (miner)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Bystand_01A : QuestBase_Bystand)
{
   addToDatabase = true;  //Important 
       
   title = "MINING EXPEDITION";  
   description = "Miners have been harvesting Rez deposits in this area.  As long as you stay out of the way, this is a good place to harvest some Rez if your bank is low.";
  
   DeployData["Infrastructure"] = "Mining"; //Any, Mining, Science, Colony
  
   initialWaves = "WAVE_SetupMinerStation WAVE_SetupMinerRocks WAVE_SetupMinerRocks WAVE_SetupMinerRocks MADD_WAVE";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_SetupMinerStation)
   {
      maxWaves = 1; 
      new ScriptGroup("REF_civ_station" : MO_Ships) 
      {
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "2500 3000";   
         objectCount = 1;               
         refObjectName = "REF_Beacon";
         factionOverride = "Civ";
         shipDesignWL = "OutpostBase 10"; 
         new ScriptGroup("civ_rocks" : MO_props) 
         {                                    
             instanceObjectWeightedList = "AsteroidBreakage 10 ";
             offset = 0;  
             creationChance = 1;
             objectCount = "30 40";
             refObjectName = "REF_civ_station";
         };
         new ScriptGroup("civ_ships" : MO_Ships)
         {   
            instanceObjectWeightedList = "AverageShips 10";
            offset = "500 1000";  
            objectCount = "1";
            factionOverride = "Civ"; 
            refObjectName = "REF_civ_station";
            hullBitMatching = $SST_HULL_INF;     
         }; 
      };       
   };
   
   new ScriptGroup(WAVE_SetupMinerRocks)
   {
      maxWaves = -1; 
      new ScriptGroup("civ_rocks2" : MO_props) 
      {                                    
         instanceObjectWeightedList = "AsteroidBreakage 10 ";
         offset = "5000 10000";  
         creationChance = 1;
         objectCount = "20 25";
         refObjectName = "REF_civ_station";
         new ScriptGroup("civ_ships3" : MO_Ships)
         {   
            instanceObjectWeightedList = "AverageShips 8 LightShips 10";
            offset = "0 0";  
            objectCount = "1";
            factionOverride = "Civ"; 
            refObjectName = "";
            hullBitMatching = $SST_HULL_INF;     
         };
      };     
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

///////////////////////////////////////////////////////////
// BYSTAND 02 (science)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Bystand_01B : QuestBase_Bystand)
{
   addToDatabase = true;  //Important 
       
   title = "OBSERVATION OUTPOST";  
   description = "The science base has set up a temporary observation outpost in the area.  There might be something interesting in the area worth salvaging.";
  
   DeployData["Infrastructure"] = "Science"; //Any, Mining, Science, Colony
  
   initialWaves = "WAVE_SetupScience WAVE_SetupGoodies WAVE_ScienceDrop WAVE_ScienceDrop WAVE_Comet MADD_WAVE";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_SetupScience)
   {
      maxWaves = 1; 
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ScienceDropWarpoutSet SetTactic TP_Retreat TP_RetreatOn";
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand ScienceDropSet MoveTo REF_scienceDropTrigger 0";
      
      new ScriptGroup("REF_civ_station" : MO_Ships) 
      {
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "2500 5000";   
         objectCount = 1;               
         refObjectName = "REF_Beacon";
         factionOverride = "Civ";
         shipDesignWL = "OutpostBase 10"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail"; //this stops the ships from respawning to come to the station
         new ScriptGroup("REF_scienceDropTrigger" : MO_Trigger) 
         {   
            refObjectName = "";         
            triggerFuncs[0] = "ObjectFunc 1 ScienceDropSet QAI_AddToSet ScienceDropWarpoutSet";  
         };
         new ScriptGroup("civ_ships" : MO_Ships)
         {   
            instanceObjectWeightedList = "AverageShips 10";
            offset = "500 1000";  
            objectCount = "2 3";
            factionOverride = "Civ"; 
            refObjectName = "REF_civ_station";
            hullBitMatching = $SST_HULL_INF;     
         };
      };     
   };
   
   new ScriptGroup(WAVE_SetupGoodies)
   {
      maxWaves = 1;    
      new ScriptGroup("REF_supplyDropUTA" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_UTASupply";
         offset = "2500 5000";      
         objectCount = "4 6";           
         refObjectName = "REF_Beacon";
      };  
      new ScriptGroup("civ_barrels_1" : MO_props) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_EMPBarrels 10";
         offset = "1000 4000";  
         creationChance = 0.7;
         objectCount = "10 15";
         refObjectName = "REF_civ_station";
      };
      new ScriptGroup("civ_barrels_2" : civ_barrels_1)
      {
         instanceObjectWeightedList = "SpaceProp_AcidBarrels 10";  
      };  
      new ScriptGroup("civ_artifacts" : civ_barrels_1)
      {
         creationChance = 1;
         instanceObjectWeightedList = "SpaceProp_Artifacts 10"; 
         objectCount = "2 5";
      };  
      new ScriptGroup("civ_artifacts_2" : civ_artifacts)
      {
         creationChance = 0.35;
         objectCount = "1 3";
         offset = "3000 6000"; 
      };
      new ScriptGroup("civ_artifacts_3" : civ_artifacts)
      {
         creationChance = 0.35;
         objectCount = "1 3";
         offset = "3000 6000"; 
      };  
      new ScriptGroup("civ_artifacts_4" : civ_artifacts)
      {
         creationChance = 0.35;
         objectCount = "1 3";
         offset = "3000 6000"; 
      };    
   };
   
   new ScriptGroup(WAVE_ScienceDrop)
   {
      maxWaves = 30; //to prevent infinite exploit
      new ScriptGroup("civ_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 6000";  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         refObjectName = "REF_scienceDropTrigger";
         hullBitMatching = $SST_HULL_INF; 
         objectFuncs["Spawn", 0] = "QAI_AddToSet ScienceDropSet"; 
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName WAVE_ScienceDrop 7000";     
      };      
   };
   
   new ScriptGroup(WAVE_Comet)
   {
      maxWaves = 1; //to prevent infinite exploit
      new ScriptGroup("REF_comet" : MO_Props) 
      {
         instanceObjectWeightedList = "AsteroidCometMassive";
         offset = "10000 10000";      
         objectCount = "1 1";           
         refObjectName = "REF_Beacon";
         creationChance = 0.1;
         objectFuncs["Spawn", 0] = "destroyAtRange 500000"; //get rid of the thing if it goes too far
         objectFuncs["Spawn", 1] = "ImpulseToRef Ref_Beacon 400"; 
         objectFuncs["Spawn", 2] = "AddPoiMarker"; 
         new ScriptGroup("REF_comet_bits" : MO_Props) 
         {
            instanceObjectWeightedList = "AsteroidComet";
            offset = "0 0";      
            objectCount = "4 5";       
            refObjectName = "REF_comet";
            objectFuncs["Spawn", 0] = "ImpulseToRef REF_Beacon 380";  
            objectFuncs["Spawn", 1] = "destroyAtRange 500000"; //get rid of the thing if it goes too far
         }; 
      }; 
      
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


///////////////////////////////////////////////////////////
// BYSTAND 03 (colony)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Bystand_01C : QuestBase_Bystand)
{
   addToDatabase = true;  //Important 
       
   title = "CHEAP MOTEL";  
   description = "A cheap motel has popped up to accommodate the civilian population.  This is a good place to pickup crew members if need be.  You can intercept crew pods when they transfer between the station and the visiting ships.";
  
   DeployData["Infrastructure"] = "Colony"; //Any, Mining, Science, Colony
  
   initialWaves = "WAVE_SetupMotel WAVE_CivBusDump WAVE_CivBusDump WAVE_CivBusDump WAVE_CivBusDump MADD_WAVE";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_SetupMotel)
   {
      maxWaves = 1; 
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand TrafficWarpOutSet SetTactic TP_Retreat TP_RetreatOn";
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand TrafficShipSet MoveTo REF_civ_station 0";
      
      new ScriptGroup("REF_civ_station" : MO_Ships) 
      {
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "2500 5000";   
         objectCount = 1;               
         refObjectName = "REF_Beacon";
         factionOverride = "Civ";
         shipDesignWL = "OutpostBase 10 Pirate01Base 10 Pirate02Base 5 Pirate03Base 2"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail"; //this stops the ships from respawning to come to the station
      };
      new ScriptGroup("TrafficTrig_01" : MO_Trigger) 
      {   
         refObjectName = "REF_civ_station";  
         triggerFuncs[0] = "ObjectFunc 1 TrafficShipSet Ship_RequestCrew";  
         triggerFuncs[1] = "ObjectFunc 1 TrafficShipSet QAI_AddToSet TrafficWarpOutSet";  
         triggerFuncs[2] = "InstanceFunc 1 TrafficShipSet callOnSubObjects REF_civ_station Ship_RequestCrew";                      
      };        
   };
   
   new ScriptGroup(WAVE_CivBusDump)
   {
      maxWaves = 15; //prevent infinite exploit
      new ScriptGroup("civ_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "4000 6000";  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         refObjectName = "REF_civ_station";
         hullBitMatching = $SST_HULL_INF;   
         objectFuncs["Spawn", 0] = "QAI_AddToSet TrafficShipSet"; 
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName WAVE_CivBusDump 15000";     
      };      
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

