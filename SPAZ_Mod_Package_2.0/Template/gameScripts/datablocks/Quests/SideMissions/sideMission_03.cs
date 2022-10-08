

///////////////////////////////////////////////////////////
// SIDE MISSION 03 DIALOG
///////////////////////////////////////////////////////////

new ScriptGroup (Dialog_sideMission_03_A : dialogBox_base) 
{ 
   character[0] = "MS_SCIENTIST";
   text[0]      = "Ah splendid!  People just leave their prize possessions laying around, ripe for the taking.";   
   
   character[1] = "MS_PIRATE";
   text[1]      = "Carl, don't jinx it.  Let's just do our thing and move on.";   
};

new ScriptGroup (Dialog_sideMission_03_B : dialogBox_base) 
{
   character[0] = "MS_JAMISON";
   text[0]      = "Hey shit heads!  I knew you couldn't resist easy pickings.  What do you think of my new warship?  Why read the brochure when you can have a personalized live demonstration?";
    
   character[1] = "MS_PIRATE";
   text[1]      = "Damn, I'm getting tired of seeing your mangled face.  I've kicked your ass once, we can do it again.  All hands, target that flagship and fire!";   
};

new ScriptGroup (Dialog_sideMission_03_C : dialogBox_base) 
{
   character[0] = "MS_JAMISON";
   text[0]      = "What in the hell?  This ship is brand new, top of the line.  We must have some factory defect.  Helmsman, get us the hell out of here.  Don, you haven't seen the last of my mangled face!";
    
   character[1] = "MS_MINER";
   text[1]      = "Did he really just say that?";   
};

///////////////////////////////////////////////////////////
// SPECIAL FUNCTIONS
///////////////////////////////////////////////////////////

function SideMission_03_ScriptEvent(%ship)
{
   //start camera focus
   %TotalSceneTime = 6000;
   presentationSchedule(%TotalSceneTime, true, "SEQ_activateSequence", "Dialog_sideMission_03_B");
   Camera_FocusOnObject(%ship, %TotalSceneTime, 0.6);
   %ship.getHullObject().hullMinHealthPercent = 0.01; //CAN'T DIE
}


///////////////////////////////////////////////////////////
// SIDE MISSION SETUP
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_03 : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA";
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_03"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_03 Dialog_sideMission_03_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_03";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "EASY PICKINGS";  
   description = "The UTA have left a supply depot relatively unguarded.  Resistance should be minimal.  Rewards should be lucrative.";
  
   initialWaves = "WAVE_Crates";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE CRATES";
   missionText["remaining"] = "MT_INFO REMAINING CRATES:";
   missionText["health"] = "MT_INFO WARSHIP HEALTH";
   missionText["fight"] = "MT_ATTACK ATTACK THE WARSHIP";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER targetCrates";
   missionTrackerData[2] = "fight";     
   missionTrackerData[3] = "health MT_HEALTHBAR UTA_attackerSet"; 
    
   DeployData["StarType"] = "INNER";     
   SelectionData["SectorProgress"] = "3 3"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_Crates")
   {
      maxWaves = 1; 
      healthCallbackSets = "Cargo";
      setHealthCallback["All", "Cargo", 0] = "0 StartWaveName attackWave";
      WaveMissionTrackers["active", 1] = "0 1"; 
      new ScriptGroup(UTA_crates_01 : MO_Props) 
      {     
         offset = "3000 3100";                                 
         instanceObjectWeightedList = "SpaceProp_UTASupply";
         objectCount = "2";
         onInitializedFunc[0] = "AddToHealthCallbackSet Cargo";
         
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet targetCrates"; 
         
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_Pissoff"; 
         
         factionOverride = "Terran";  //so that cloak hunter srms can find them        
      }; 
      new ScriptGroup(UTA_crates_02 : UTA_crates_01) 
      {                                       
      }; 
      new ScriptGroup(UTA_crates_03 : UTA_crates_01) 
      {                                          
      }; 
      new ScriptGroup(REF_guardShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1"; 
         offset = "500";  
         factionOverride = "Terran";                     
         refObjectName = "UTA_crates_01";      
      };  
      new ScriptGroup(REF_guardShips_02 : REF_guardShips_01)
      {                                                         
         refObjectName = "UTA_crates_02";      
      };  
      new ScriptGroup(REF_guardShips_03 : REF_guardShips_01)
      {                                                        
         refObjectName = "UTA_crates_03";      
      };           
   };
         
   new ScriptGroup("attackWave")
   {
      maxWaves = 1;        
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand UTA_attacker SetTactic TP_Stance TP_SeekAndDestroy";
      waveTimedCallbacks[1, 1] = "7000 callQuestFunctionOnInstance MissionCallout fight"; 
      waveTimedCallbacks[1, 2] = "0 StartWaveName dyson_helperWave 0";   
      
      WaveMissionTrackers["remove", 1] = "0 1"; 
      WaveMissionTrackers["active", 1] = "2 3"; 
      new ScriptGroup(REF_dysonShip : MO_Ships)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         shipDesignWL = "DysonStation_01 10"; 
         objectCount = "1"; 
         offset = "3000";  
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         respectShipCount = 4; 
         
         objectFuncs["Spawn", 0]   = "QAI_AddToSet UTA_attacker"; 
         objectFuncs["Spawn", 1] = "addToTrackingSet UTA_attackerSet"; 
         objectFuncs["Spawn", 2]   = "AddTargetMarker";
         objectFuncs["Spawn", 3] = "callFunctionWithObject SideMission_03_ScriptEvent";
         
         objectFuncs["Damage", 0]  = "isHealthLessThen 0.2 true StartWaveName warpoutWave 0";
         
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName QuestComplete";       
      };       
   };
   
   new ScriptGroup("dyson_helperWave")
   {
      maxWaves = 5;        
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand DysonWarpoutSet SetTactic TP_Stance TP_SeekAndDestroy";
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName dyson_helperWave 3500";    
      new ScriptGroup(helperShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "2 3"; 
         factionOverride = "Terran";                     
         refObjectName = "REF_dysonShip";
         offset = "650"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet DysonWarpoutSet";     
      };       
   };
   
   new ScriptGroup("warpoutWave")
   {
      maxWaves = 1;        
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_dysonShip QAI_AddToSet DysonWarpoutSet";
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand DysonWarpoutSet SetTactic TP_Retreat TP_RetreatOn";
      waveTimedCallbacks[1, 2] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_03_C"; 
   };
   
   new ScriptGroup("WAVE_Pissoff")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "0 callQuestFunction ChangePlayerRelations terran -1"; 
   };       
}; 
