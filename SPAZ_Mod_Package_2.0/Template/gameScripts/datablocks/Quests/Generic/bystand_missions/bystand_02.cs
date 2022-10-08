
///////////////////////////////////////////////////////////
// BYSTAND 02
///////////////////////////////////////////////////////////


new ScriptGroup(Quest_Bystand_02 : QuestBase_Bystand)
{
   addToDatabase = true;  //Important 
       
   title = "TRAFFIC JAM";  
   description = "Even the infinite vastness of space is not immune to the odd traffic jam.  This could be a good opportunity to take advantage of some Civilian ships.";
  
   rarity = "Uncommon"; 
   DeployData["Infrastructure"] = "Any"; //Any, Mining, Science, Colony
  
   initialWaves = "WAVE_SetupTraffic MADD_WAVE";
   
   initialTimedCallbacks[0] = "1000 StartWaveName WAVE_traffic_1";
   initialTimedCallbacks[1] = "2000 StartWaveName WAVE_traffic_2";
   initialTimedCallbacks[2] = "3000 StartWaveName WAVE_traffic_3";
   initialTimedCallbacks[3] = "7000 StartWaveName WAVE_traffic_4";
   initialTimedCallbacks[4] = "8000 StartWaveName WAVE_traffic_5";
   
   initialTimedCallbacks[5] = "10000 StartWaveName WAVE_traffic_1";
   initialTimedCallbacks[6] = "12000 StartWaveName WAVE_traffic_2";
   initialTimedCallbacks[7] = "16000 StartWaveName WAVE_traffic_3";
   
   SelectionData["SectorProgress"] = "1 3"; //mission is totally useless in sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_SetupTraffic)
   {
      maxWaves = 1; 
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand TrafficWarpOutSet SetTactic TP_Retreat TP_RetreatOn";
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand TrafficShipSet_1 MoveTo REF_trafficStation_01 0";
      waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand TrafficShipSet_2 MoveTo REF_trafficStation_02 0";
      waveTimedCallbacks[1, 3] = "0 QAI_SetAICommand TrafficShipSet_3 MoveTo REF_trafficStation_03 0";
      
      new ScriptGroup("REF_trafficStation_01" : MO_Props) 
      {
         instanceObjectWeightedList = "FakeWarpGate";
         offset = "2500 5000";   
         objectCount = 1;               
         refObjectName = "REF_Beacon";
      }; 
      new ScriptGroup("REF_trafficStation_02" : REF_trafficStation_01) 
      {
      }; 
      new ScriptGroup("REF_trafficStation_03" : REF_trafficStation_01) 
      {
      }; 
      new ScriptGroup("TrafficTrig_01" : MO_Trigger) 
      {   
         refObjectName = "REF_trafficStation_01";  
         triggerFuncs[0] = "ObjectFunc 1 TrafficShipSet_1 QAI_AddToSet TrafficWarpOutSet";                         
      }; 
      new ScriptGroup("TrafficTrig_02" : MO_Trigger) 
      {  
         refObjectName = "REF_trafficStation_02";  
         triggerFuncs[0] = "ObjectFunc 1 TrafficShipSet_2 QAI_AddToSet TrafficWarpOutSet";                          
      }; 
      new ScriptGroup("TrafficTrig_03" : MO_Trigger) 
      {    
         refObjectName = "REF_trafficStation_03"; 
         triggerFuncs[0] = "ObjectFunc 1 TrafficShipSet_3 QAI_AddToSet TrafficWarpOutSet";                         
      }; 
   };   
      
   new ScriptGroup(WAVE_traffic_1)
   {
      maxWaves = 20; //to prevent infinite exploit
      new ScriptGroup("civ_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "0 0";  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         refObjectName = "REF_trafficStation_03";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
         objectFuncs["Spawn", 0] = "QAI_AddToSet TrafficShipSet_1"; 
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName WAVE_traffic_1";       
      };    
   };
   
   new ScriptGroup(WAVE_traffic_2)
   {
      maxWaves = 20; //to prevent infinite exploit
      new ScriptGroup("civ_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "0 0";  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         refObjectName = "REF_trafficStation_01";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
         objectFuncs["Spawn", 0] = "QAI_AddToSet TrafficShipSet_2"; 
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName WAVE_traffic_2";       
      };    
   };
   
   new ScriptGroup(WAVE_traffic_3)
   {
      maxWaves = 20; //to prevent infinite exploit
      new ScriptGroup("civ_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "0 0";  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         refObjectName = "REF_trafficStation_02";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
         objectFuncs["Spawn", 0] = "QAI_AddToSet TrafficShipSet_3"; 
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName WAVE_traffic_3";       
      };    
   };
   
   
   new ScriptGroup(WAVE_traffic_4)
   {
      maxWaves = 20; //to prevent infinite exploit
      new ScriptGroup("civ_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "0 0";  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         refObjectName = "REF_trafficStation_03";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
         objectFuncs["Spawn", 0] = "QAI_AddToSet TrafficShipSet_2"; 
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName WAVE_traffic_4";       
      };    
   };
   
   new ScriptGroup(WAVE_traffic_5)
   {
      maxWaves = 20; //to prevent infinite exploit
      new ScriptGroup("civ_ships" : MO_Ships)
      {   
         instanceObjectWeightedList = "AverageShips 10";
         offset = "0 0";  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         refObjectName = "REF_trafficStation_01";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;
         objectFuncs["Spawn", 0] = "QAI_AddToSet TrafficShipSet_3"; 
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName WAVE_traffic_5";       
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