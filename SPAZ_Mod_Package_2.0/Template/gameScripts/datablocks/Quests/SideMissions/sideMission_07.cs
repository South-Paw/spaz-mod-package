

///////////////////////////////////////////////////////////
// SIDE MISSION 07 DIALOG
///////////////////////////////////////////////////////////

new ScriptGroup (Dialog_sideMission_07_A : dialogBox_base) 
{
   character[0] = "MS_SEC3_SCIENCE_BASE";
   text[0]      = "Thank you all for volunteering for this mission.  I've been cataloging zombie behaviors for some time now.  This may seem like an odd request, but I need you to destroy only the smallest infected ships, while I observe the behavior of the large guardian ship.  Understanding their relationships to one another may prove useful when training our pilots how to combat them.";

   character[1] = "MS_MINER";
   text[1]      = "Wait, what?  Kill some, but not others?  It's all bad beef in my book."; 
   
   character[2] = "MS_SEC3_SCIENCE_BASE";
   text[2]      = "Yes, that is correct.  Destroy only the targeted ships.  Keep your auto pilot systems in check and do not engage the large infected vessel."; 
};

new ScriptGroup (Dialog_sideMission_07_B : dialogBox_base) 
{
   character[0] = "MS_SEC3_SCIENCE_BASE";
   text[0]      = "Great!  I've collected the data I need.  Okay, go ahead and destroy the guardian ship."; 
};

///////////////////////////////////////////////////////////
// SIDE MISSION SETUP
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_07 : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_07"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_07 Dialog_sideMission_07_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_07";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "DOES A ZOMBIE CRY?";  
   description = "Dr. Gale Harper is conducting research into zombie behaviors and is in need of volunteers.";
   
   missionText["initial"] = "MT_ATTACK DESTROY SMALL ZOMBIE SHIPS";
   missionText["defend"] = "MT_DEFEND DEFEND LARGE ZOMBIE SHIP";
   missionText["killAll"] = "MT_ATTACK DESTROY GUARDIAN SHIP";
   missionText["largeGone"] = "MT_FAIL THE GUARDIAN WAS DESTROYED";
   
   initialWaves = "WAVE_setupShips WAVE_tinyZomShips";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";   
   missionTrackerData[1] = "defend";
   missionTrackerData[2] = "killAll";
   
   DeployData["StarType"] = "INNER";
   SelectionData["SectorProgress"] = "4 4";  //sec 4 spicific
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_setupShips")
   {
      maxWaves = 1;        
      WaveMissionTrackers["active", 1] = "0 1"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand StickAroundSet SetTactic TP_Stance TP_Defensive";
      new ScriptGroup(zomShips_large : MO_Ships)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1"; 
         factionOverride = "ZombieKiller";                      
         refObjectName = "REF_Beacon";
         offset = "6000";
          
         objectFuncs["Spawn", 0] = "AddDefendMarker";  
         objectFuncs["Spawn", 1] = "addBasicCondition guardianState doNotKill";  
         objectFuncs["Spawn", 2]   = "QAI_AddToSet StickAroundSet";  
         
         objectFuncs["Death", 0] = "evalBasicCondition guardianState doNotKill StartWaveName questFail 0 largeGone";
         objectFuncs["Death", 1] = "CallInstanceFunc StartWaveName questComplete 100"; 
         
      };   
   };
   
   new ScriptGroup("WAVE_tinyZomShips")
   {
      maxWaves = 3;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_tinyZomShips";    
      setHealthCallback[3, "enemy", 0] = "0 StartWaveName WAVE_killAll";   
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand StickAroundSet SetTactic TP_Stance TP_Defensive"; 
      new ScriptGroup(zomShips_small_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "6"; 
         factionOverride = "ZombieKiller";                      
         refObjectName = "zomShips_large";
         offset = "500"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Spawn", 1]   = "QAI_AddToSet StickAroundSet";   
      };    
   };
   
   new ScriptGroup("WAVE_killAll")
   {
      maxWaves = 1;
      waveContext[1] = "killAll";
      WaveMissionTrackers["remove", 1] = "0 1"; 
      WaveMissionTrackers["active", 1] = "2"; 
      waveTimedCallbacks[1, 0] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_07_B"; 
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects zomShips_large RemoveObjectiveMarker_ALL";   
      waveTimedCallbacks[1, 2] = "0 callOnSubObjects zomShips_large AddTargetMarker";
      waveTimedCallbacks[1, 3] = "0 callOnSubObjects zomShips_large addBasicCondition guardianState killNow";     
   };
}; 


