
///////////////////////////////////////////////////////////
// SIDE MISSION 10 DIALOG
///////////////////////////////////////////////////////////

new ScriptGroup (Dialog_sideMission_10_A : dialogBox_base) 
{
   character[0] = "MS_TURBODEF";
   text[0]      = "TURBO DEFENDER 9000-EX remembers what you have done to TURBO DEFENDER 9000-EX.  Because of you TURBO DEFENDER 9000-EX has lost family, home, job, and now spends a 92% partition of time at local pub.  TURBO DEFENDER 9000-EX has allocated primary power to rage.  You will be deleted now!";

   character[1] = "MS_SCIENTIST";
   text[1]      = "Well this is interesting.  This thing seems to becoming self-aware.  I'd say it's surpasses Elsa's capacity for learning.  It isn't much of a feat, but it is still quite interesting."; 

   character[2] = "MS_MINER";
   text[2]      = "Hey!  Don't be an ass.  You want to get beat down by a girl?"; 

   character[3] = "MS_PIRATE";
   text[3]      = "Damn you two, shut up already!  Let's destroy this thing once and for all and Carl can muck around with its circuitry all he likes."; 

   character[4] = "MS_MINER";
   text[4]      = "Umm.  This can't be good.  I'm picking up a lot of signals here.  A hell of a lot of signals!  This is very bad.  Their reactors are rigged to blow.  These are suicide bombers!"; 

};

new ScriptGroup (Dialog_sideMission_10_B : dialogBox_base) 
{
   character[0] = "MS_TURBODEF";
   text[0]      = "TURBO DEFENDER 9000-EX sees the light at the end of the tunnel.  TURBO DEFENDER 9000-EX can finally be with grandma again."; 

   character[1] = "MS_SCIENTIST";
   text[1]      = "What a shame we had to destroy it.  It could have spawned an entire race of sentient machines."; 

   character[2] = "MS_MINER";
   text[2]      = "Carl, that never goes over very well.  Haven't you seen that movie?  I can't remember what it's called.  I have a feeling we haven't seen that last of that thing."; 

   character[3] = "MS_PIRATE";
   text[3]      = "Stay focused.  Collect what data and scrap you can and let's get back on the road."; 

};
///////////////////////////////////////////////////////////
// SIDE MISSION SETUP
///////////////////////////////////////////////////////////

/*

new ScriptGroup(Quest_SideMission_10 : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV";
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1 S2_GetReactor"; //must come after story event
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_09"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_09 Dialog_sideMission_09_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_09 Dialog_sideMission_09_B";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "TURBO REVENGE 2";  
   description = "Someone wants to fight behind the playground after school.";
   
   missionText["initial"] = "MT_ATTACK SURVIVE";
   missionText["remaining"] = "MT_INFO REMAINING TARGETS:";
   missionText["killBoss"] = "MT_ATTACK DESTROY TURBO BOSS";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "5000 StartWaveName WAVE_suicideShips";
   initialTimedCallbacks[2] = "8000 StartWaveName WAVE_suicideShips";
   initialTimedCallbacks[3] = "10000 StartWaveName WAVE_suicideShips";
   initialTimedCallbacks[4] = "12000 StartWaveName WAVE_suicideShips";
   initialTimedCallbacks[5] = "14000 StartWaveName WAVE_suicideShips";
   initialTimedCallbacks[6] = "16000 StartWaveName WAVE_suicideShips";
   initialTimedCallbacks[7] = "0 TS_addTrackingTick shipsRemain 40";
   
   missionTrackerData[0] = "initial"; 
   missionTrackerData[1] = "remaining MT_TICKCOUNTER shipsRemain"; 
   missionTrackerData[2] = "killBoss"; 
   
   SelectionData["SectorProgress"] = "2 3";  
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_suicideShips")
   {
      maxWaves = 40;  
      waveRelations[1, 0] = "Civ Pirate" SPC $FactionRelation_HATE;        
      WaveMissionTrackers["active", 1] = "0 1"; 
      healthCallbackSets = "enemy"; 
      
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_suicideShips"; 
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand suicideSet MoveTo REF_Player 0";
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand suicideSet SetTactic TP_Collect TP_NoCollect";
      //waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand suicideSet SetTactic TP_Stance TP_Passive";       
      new ScriptGroup(suicideShip : MO_Ships)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         objectCount = "1"; 
         factionOverride = "Civ";                      
         refObjectName = "REF_Player";
         offset = "3000";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         objectFuncs["Spawn", 1]   = "QAI_AddToSet suicideSet";
         objectFuncs["Spawn", 2]   = "SM_09_nearPlayerCheck";
         objectFuncs["Spawn", 3] = "addToTrackingSet markerRemoveSet"; 
         
         objectFuncs["Death", 0] = "CallInstanceFunc TS_addTrackingTick shipsRemain -1";
         objectFuncs["Death", 1] = "CallInstanceFunc TS_evalTrackingTick shipsRemain 0 StartWaveName WAVE_turboBoss";           
           
         shipDesignWL = "TugShip_SM_09 10";     
      };  
   };
   
   new ScriptGroup("WAVE_turboBoss")
   {
      maxWaves = 1;     
      waveContext[1] = "killBoss";   
      WaveMissionTrackers["active", 1] = "2"; 
      WaveMissionTrackers["remove", 1] = "0 1";  
      waveTimedCallbacks[1, 0] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_09_BossIntro"; 
      waveTimedCallbacks[1, 1] = "0 callQuestFunction TS_addTrackingTick bossSpawned 1"; 
      waveTimedCallbacks[1, 2] = "0 trackingSet_callOnObjects markerRemoveSet RemoveObjectiveMarker_ALL"; 
      waveTimedCallbacks[1, 3] = "1500 trackingSet_callOnObjects markerRemoveSet RemoveObjectiveMarker_ALL"; //make sure you get any warp ins
      new ScriptGroup(suicideShip : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HugeShips 10";
         objectCount = "1"; 
         factionOverride = "Civ";                      
         refObjectName = "REF_Player";
         offset = "3000";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName questComplete";    
      };  
   };
}; 

*/


