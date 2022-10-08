
///////////////////////////////////////////////////////////
// DESTROY 06A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_06A : QuestBase_Event)
{
   addToDatabase = true;  //Important 
       
   title = "TAKE CANDY FROM A ZOMBIE";  
   description = "A zombie nest in the area is going dormant.  Destroying its Rez supply will keep it from acting up again.  This must be done with stealth or the nest will reawaken.  Cloaking device recommended.";
  
   initialWaves = "WAVE_zomRockSetup WAVE_zomRockSetup WAVE_zomRockSetup MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY ZOMBIE REZ SOURCE";
   missionText["remaining"] = "MT_INFO REMAINING REZ SOURCE:";
   missionText["sneakInfo"] = "MT_HINT USE CLOAKING TO AVOID DETECTION";
   missionText["sneakMeter"] = "MT_INFO SNEAK METER";
   missionText["spottedFail"] = "MT_FAIL YOUR COVER WAS BLOWN";
   
   initialTimedCallbacks[0] = "0 callQuestFunctionOnInstance SNEAK_SetCoverValue 15";
   initialTimedCallbacks[1] = "0 callQuestFunctionOnInstance factionScouting_Start zombie 800 SNEAK_BlowCover WAVE_spotted 3"; //fast cover blow rate
   initialTimedCallbacks[2] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER zomFood";
   missionTrackerData[2] = "sneakInfo";
   missionTrackerData[3] = "sneakMeter MT_METER_EVAL SNEAK_getCoverValue";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   
   DeployData["StarType"] = "INNER";
   SelectionData["InfectionLevel"] = "1 3";
   
   Rewards["Complete", "Security"] = 1;
   Rewards["Complete", "Infrastructure"] = 1;
   Rewards["Complete", "Goons"] = "low";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zomRockSetup")
   {
      maxWaves = -1;   
      WaveMissionTrackers["active", 1] = "0 1 2 3"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomDefenderSet SetTactic TP_Stance TP_Defensive";      
      new ScriptGroup(REF_zomFood : MO_Props) 
      {     
         offset = "5000 6000";                                 
         instanceObjectWeightedList = "AsteroidCluster_zombie";
         objectCount = "Scaled 5 10";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet zomFood"; 
         objectFuncs["Death", 0] = "evalTrackingSetCount zomFood 0 StartWaveName QuestComplete";
         new ScriptGroup(zomFoodGuard_1 : MO_Ships)
         {                                      
            instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";                 
            refObjectName = "";
            offset = 0;
            objectCount = "1";
            factionOverride = "ZombieKiller"; 
            objectFuncs["Spawn", 0] = "QAI_AddToSet ZomDefenderSet"; 
         };
         new ScriptGroup(zomFoodGuard_2 : zomFoodGuard_1)
         {                                      
            factionOverride = "Zombie"; 
         };
      };     
   };
   
   new ScriptGroup("WAVE_spotted")
   {
      maxWaves = 1;   
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestFail 0 spottedFail";            
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

///////////////////////////////////////////////////////////
// DESTROY 06B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_06B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
       
   title = "AREA 42.1";  
   description = "Scientists had discovered ancient alien artifacts in deep space.  Before they were able to set up a quarantine zone, the area fell to the infection.  The artifacts represent a threat in the hands of the infection and must be destroyed.";
  
   initialWaves = "WAVE_zomArtifact WAVE_zomArtifact WAVE_zomArtifact Zom_respawnFleet MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY ZOMBIE ARTIFACTS";
   missionText["remaining"] = "MT_INFO REMAINING ARTIFACTS:";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER zomArtifacts";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   
   DeployData["StarType"] = "INNER";
   SelectionData["InfectionLevel"] = "1 3";
   
   Rewards["Complete", "Goons"] = "low";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zomArtifact")
   {
      maxWaves = -1;   
      WaveMissionTrackers["active", 1] = "0 1"; 
      new ScriptGroup(REF_artifacts : MO_Props) 
      {     
         offset = "5000 8000";                                 
         instanceObjectWeightedList = "SpaceProp_Artifacts_zom";
         objectCount = "2 3";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet zomArtifacts"; 
         objectFuncs["Death", 0] = "evalTrackingSetCount zomArtifacts 0 StartWaveName QuestComplete";
         objectFuncs["Death", 1] = "CallInstanceFunc StartWaveName WAVE_zombie_extraAttackers 2500";  
      };     
   };
   
   new ScriptGroup("WAVE_zombie_extraAttackers")
   {
      maxWaves = 20; //just to make sure there is no exploit
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand ZomAssaultSet SetTactic TP_Stance TP_SeekAndDestroy";             
      new ScriptGroup(ZomRespawnShips : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10 AverageShips 5";
          offset = "4000 6000";  
          objectCount = "1";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Player";
          objectFuncs["Spawn", 0] = "QAI_AddToSet ZomAssaultSet"; 
          respectShipCount = 4;                       
      };
      new ScriptGroup(ZomRespawnShips_killers : ZomRespawnShips)
      {                                      
          factionOverride = "ZombieKiller";  
          instanceObjectWeightedList = "HeavyShips 10";
          objectCount = "1";           
      };                      
   };
   
   new ScriptGroup("Zom_respawnFleet")
   {
      maxWaves = 15; //lots, but not forever
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName Zom_respawnFleet 7500";
      new ScriptGroup(REF_ZomAttackers2 : MO_Ships) 
      {   
         instanceObjectWeightedList = "LightShips 10 AverageShips 5";
         offset = "3000 6000";  
         objectCount = "1 2";
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Player"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";              
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
      //some zom set dress for context
      new ScriptGroup(ZombieNest : MADD_ZombieNest)
      {   
         new ScriptGroup("zombieRocks" : MADD_ZombieRocks) 
         {                                      
         };                            
      };                                       
   }; 
}; 




























