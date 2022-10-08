
///////////////////////////////////////////////////////////
// DESTROY 05A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_05A : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA";
       
   title = "BEACON BASHER";  
   description = "The UTA are installing beacons in the area to give their ships quick access throughout the system.  The Civilian population is unhappy with this and will pay to have the beacons destroyed.";
  
   initialWaves = "WAVE_Beacon WAVE_Beacon WAVE_Beacon MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY UTA BEACONS";
   missionText["remaining"] = "MT_INFO REMAINING BEACONS:";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //can run at any time 
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER targetBeacons";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   
   DeployData["LevelRange"]     = "1 10"; //can occur only early
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_Beacon")
   {
      maxWaves = 3;   
      WaveMissionTrackers["active", 1] = "0 1"; 
      new ScriptGroup(UTA_Beacon : MO_Props) 
      {    
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "5000 7000";  
         creationChance = 1;  
         objectCount = "1 1";
         factionOverride = "Terran";
         refObjectName = "REF_Beacon"; 
         
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         objectFuncs["Spawn", 1] = "addToTrackingSet targetBeacons";
         
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_2 1000";  
         objectFuncs["Death", 1] = "evalTrackingSetCount targetBeacons 0 StartWaveName QuestComplete"; 
         
         objectFuncs["Damage", 0]  = "isHealthLessThen 0.5 true StartWaveName WAVE_1 0";
           
         shipDesignWL = "BeaconBase_nerfed 10";
         new ScriptGroup(Barrels_01 : MO_Props) 
         {    
            instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_Light 10";                                
            objectCount = "3 6";
            offset = "200 600";  
            refObjectName = ""; 
         };   
      };      
   };
   
   new ScriptGroup("WAVE_1")
   {    
      maxWaves = 5;  //in case the thing repairs and recalls damage callback .. no infinite spawn
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";   
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "Scaled 2 3"; 
         factionOverride = "Terran";                         
         offset = "800 1200";
         refObjectName = "REF_Player"; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";   
         respectShipCount = 8;
      };            
   };
   
   new ScriptGroup("WAVE_2")
   {    
      maxWaves = 5;  
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations terran -1"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";    
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 1";
         objectCount = "1 1"; 
         factionOverride = "Terran";                         
         offset = "800 1200";
         refObjectName = "REF_Player";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";   
         respectShipCount = 8; 
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

//////////////////////////////////////////////////////////
// DESTROY 05B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_05B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA CIV";
       
   title = "BAD INFLUENCE";  
   description = "A group of Civilians and UTA officials are covertly working together on a peace treaty.  An anonymous group feels that this will have a negative impact on the weapons market.  Destroy the outposts they have established in the area for a reward.";
  
   initialWaves = "WAVE_Outpost MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY ENEMY OUTPOSTS";
   missionText["remaining"] = "MT_INFO REMAINING OUTPOSTS:";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //can run at any time 
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER targetOutposts";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Down;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Down;
   Rewards["Complete", "Resource"] = "high";
   Rewards["Complete", "Data"] = "high";
   
   DeployData["StarType"] = "OUTTER"; //mission gets a bit easy after a while, so keep in rim
   DeployData["LevelRange"]     = "10 40"; //can occur only early
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_Outpost")
   {
      maxWaves = 1;   
      WaveMissionTrackers["active", 1] = "0 1"; 
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_FRIEND;
      new ScriptGroup(UTA_Outpost1 : MO_Props) 
      {    
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "5000 7000";  
         creationChance = 1;  
         objectCount = "1 1";
         factionOverride = "Terran";
         refObjectName = "REF_Beacon"; 
         
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         objectFuncs["Spawn", 1] = "addToTrackingSet targetOutposts";
         
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_utaAttack 1000";  
         objectFuncs["Death", 1] = "evalTrackingSetCount targetOutposts 0 StartWaveName QuestComplete"; 
         
         objectFuncs["Damage", 0]  = "isHealthLessThen 0.5 true StartWaveName WAVE_utaAttack 0";
           
         shipDesignWL = "OutpostBase 10"; 
         
         new ScriptGroup(uta_guardships : MO_Ships)
         {                                      
            instanceObjectWeightedList = "AverageShips 10";
            objectCount = "Scaled 1 2"; 
            factionOverride = "Terran";                         
            offset = "800 1200";
            refObjectName = "CIV_Outpost1"; 
         };   
      }; 
      new ScriptGroup(CIV_Outpost1 : UTA_Outpost1) 
      {    
         factionOverride = "Civ";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_civAttack 1000"; 
         objectFuncs["Damage", 0]  = "isHealthLessThen 0.5 true StartWaveName WAVE_civAttack 0"; 
         refObjectName = "UTA_Outpost1";
         offset = "500 550"; 
         new ScriptGroup(civ_guardships : MO_Ships)
         {                                      
            instanceObjectWeightedList = "AverageShips 10";
            objectCount = "Scaled 1 2"; 
            factionOverride = "Civ";                         
            offset = "800 1200";
            refObjectName = "CIV_Outpost1"; 
         };   
      };     
   };
      
   new ScriptGroup("WAVE_utaAttack")
   {    
      maxWaves = 10;  //in case the thing repairs and recalls damage callback .. no infinite spawn
      
      waveTimedCallbacks["All", 0] = "1000 callQuestFunction ChangePlayerRelations terran -1"; 
      waveTimedCallbacks["All", 1] = "1000 callQuestFunction ChangePlayerRelations civ -1";           
      new ScriptGroup(KillShips_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10 AverageShips 6";
         objectCount = "Scaled 1 2"; 
         factionOverride = "Terran";                         
         offset = "800 1200";
         refObjectName = "CIV_Outpost1"; 
         respectShipCount = 6;  
      };            
   };
   
   new ScriptGroup("WAVE_civAttack")
   {    
      maxWaves = 10;  //in case the thing repairs and recalls damage callback .. no infinite spawn
      
      waveTimedCallbacks["All", 0] = "1000 callQuestFunction ChangePlayerRelations civ -1"; 
      waveTimedCallbacks["All", 1] = "1000 callQuestFunction ChangePlayerRelations terran -1";    
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10 AverageShips 6";
         objectCount = "Scaled 1 2"; 
         factionOverride = "Civ";                         
         offset = "500 600";
         refObjectName = "UTA_Outpost2"; 
         respectShipCount = 6; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
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




























