
///////////////////////////////////////////////////////////
// DESTROY 04 
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_04 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   //warningTags = "TIME";
       
   title = "TRASH HEAP";  
   description = "A large amount of trash has accumulated in the area.  Local business owners are willing to pay to have it disposed of.  The work is extremely dangerous, as these substances are incredibly volatile.  To make matters worse, the UTA frown on this kind of waste disposal.";
  
   initialWaves = "WAVE_Barrels MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY TOXIC BARRELS";
   missionText["remaining"] = "MT_INFO REMAINING BARRELS:";
   missionText["attackships"] = "MT_ATTACK UTA ATTACK SHIPS INBOUND";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //can run at any time 
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER toxicBarrels";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Goons"] = "low";
   Rewards["Complete", "Bounty"] = "low";
   
   DeployData["LevelRange"]     = "1 10"; //can occur only early
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_Barrels")
   {
      maxWaves = 1; 
      healthCallbackSets = "Barrels";
      setHealthCallback["All", "Barrels", 0] = "0 StartWaveName QuestComplete";   
      setHealthCallback["All", "Barrels", 1] = "2 StartWaveName WAVE_Heavy";
      setHealthCallback["All", "Barrels", 2] = "6 StartWaveName WAVE_1"; 
      setHealthCallback["All", "Barrels", 3] = "10 StartWaveName WAVE_1"; 
      setHealthCallback["All", "Barrels", 4] = "15 StartWaveName WAVE_1";   
      setHealthCallback["All", "Barrels", 5] = "20 StartWaveName WAVE_1"; 
      setHealthCallback["All", "Barrels", 6] = "30 StartWaveName WAVE_1";       
      WaveMissionTrackers["active", 1] = "0 1"; 
      
      new ScriptGroup(Barrels_01 : MO_Props) 
      {    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels 10 SpaceProp_EMPBarrels 5 SpaceProp_AcidBarrels 3";                                
         objectCount = "10 12";
         offset = "3000 3500";  
         onInitializedFunc[0] = "AddToHealthCallbackSet Barrels";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet toxicBarrels";  
         //factionOverride = "Terran";  //makes ai look dumb
         refObjectName = "REF_Beacon";
         new ScriptGroup(crateSetDress_01 : MO_Props) 
         {                                      
            instanceObjectWeightedList = "SpaceProp_Crates";
            offset = 0;  
            creationChance = 1;
            objectCount = "1 2";
            refObjectName = "Barrels_01"; 
         };
         new ScriptGroup("shipWrecks_01") 
         {    
            creationChance = 1;
            instanceObjectWeightedList = "ShipWreck_Graveyard 10";                                
            offset = "500 600";  
            refObjectName = "Barrels_01"; 
            wreckDatablockWL = "ShipWreck_BigBus 10 ShipWreck_Flora 10 ShipWreck_BigBrother 10 ShipWreck_RightHook 10 ShipWreck_Helix 10 ShipWreck_SunSpot_Left 5 ShipWreck_SunSpot_Right 5 ShipWreck_terranStation_01 5 shipWreck_quasarStation_01 5 ShipWreck_stationDoodad_Large 5 ShipWreck_stationDoodad_Med02 5"; 
            objectCount = "12 15";  
         };  
      };   
      new ScriptGroup(Barrels_02 : Barrels_01) 
      {   
         offset = "4000 7000"; 
         new ScriptGroup(crateSetDress_02 : crateSetDress_01) 
         {                                      
            refObjectName = "Barrels_02"; 
         };   
         new ScriptGroup("shipWrecks_02" : shipWrecks_01) 
         {    
            refObjectName = "Barrels_02"; 
         };                                    
      };   
      new ScriptGroup(Barrels_03 : Barrels_01) 
      {  
         offset = "4000 8000"; 
         new ScriptGroup(crateSetDress_03 : crateSetDress_01) 
         {                                      
            refObjectName = "Barrels_03"; 
         }; 
         new ScriptGroup("shipWrecks_03" : shipWrecks_01) 
         {    
            refObjectName = "Barrels_03"; 
         };                                      
      };  
      new ScriptGroup(Barrels_04 : Barrels_01) 
      {  
         offset = "6000 8000"; 
         new ScriptGroup(crateSetDress_04 : crateSetDress_01) 
         {                                      
            refObjectName = "Barrels_04"; 
         };
         new ScriptGroup("shipWrecks_04" : shipWrecks_01) 
         {    
            refObjectName = "Barrels_04"; 
         };                                       
      }; 
   };
   
   new ScriptGroup("WAVE_1")
   {    
      maxWaves = -1;  
      waveContext[1] = "attackships";
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations terran -1";
      waveTimedCallbacks["All", 1] = "0 QAI_SetAICommand UTA_attacker SetTactic TP_Stance TP_SeekAndDestroy";   
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10 AverageShips 2";
         objectCount = "Scaled 1 2"; 
         factionOverride = "Terran";                         
         offset = "800 1200";
         refObjectName = "REF_Player"; 
         respectShipCount = 4; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet UTA_attacker";    
      };            
   };
   
   new ScriptGroup("WAVE_Heavy")
   {    
      maxWaves = -1;  
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations terran -1";
      waveTimedCallbacks["All", 1] = "0 QAI_SetAICommand UTA_attacker SetTactic TP_Stance TP_SeekAndDestroy";   
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "1"; 
         factionOverride = "Terran";                         
         offset = "800 1200";
         refObjectName = "REF_Player"; 
         respectShipCount = 4; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet UTA_attacker";    
      };            
   };
     
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {             
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                          
      };
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                          
      };                                     
   }; 
}; 




























