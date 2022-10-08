

///////////////////////////////////////////////////////////
// SIDE MISSION 04 DIALOG
///////////////////////////////////////////////////////////

new ScriptGroup (Dialog_sideMission_04_A : dialogBox_base) 
{
   character[0] = "MS_MINER";
   text[0]      = "We've picked up a distress call in this area.  Anyone out there?  Please respond.";
    
   character[1] = "MS_PUNK";
   text[1]      = "Oh hell, if it ain't my little lady.  Why you just leave me out here?  Do you have any idea how long I've been twisting in the wind?";   

   character[2] = "MS_MINER";
   text[2]      = "What the hell?  How did YOU survive?  Forget it!  You're going to twist here for the next trillion years.";

   character[3] = "MS_PIRATE";
   text[3]      = "Elsa, we should snatch this guy up. He's got to have some skills if he was able to escape us before.  We need the labor, so let's put his ass to work.";

   character[4] = "MS_MINER";
   text[4]      = "Don, no!  Just, no!  I'll kill him.  I swear I'll do it.";

   character[5] = "MS_PIRATE";
   text[5]      = "Easy there Elsa.  We'll rig him up with an explosive collar like the rest of the goons, and you can have the key.  He'll be your little bitch.  How'd you like that?";

   character[6] = "MS_MINER";
   text[6]      = "I don't like it one damn bit.";

   character[7] = "MS_PIRATE";
   text[7]      = "Well how about this?  You'll damn well do it!  That is an order.  Don't push me any more than you already have.";
   
   character[8] = "MS_PUNK";
   text[8]      = "Well this is just the cat's ass!  When is the wedding hot stuff?";
   
   character[9] = "MS_MINER";
   text[9]      = "I think I'm going to be sick.";
};

new ScriptGroup (Dialog_sideMission_04_B : dialogBox_base) 
{
   character[0] = "MS_EXTRA_01";
   text[0]      = "You folks are not going anywhere!  Any friends of that scum are enemies of mine.  The horrible things that bastard did to my dog.  The poor girl will never be right again.  He has to suffer!";
    
   character[1] = "MS_MINER";
   text[1]      = "Oh lovely.  Looks like we're not the only ones this clown has pissed off.  With any luck we will lose this battle and we'll all be killed.  Things are really looking up.";   

   character[2] = "MS_PIRATE";
   text[2]      = "I'm not interested in this school yard drama.  We all know how this goes people.  Shoot for the reactor, and let's get home in time for dinner.";
};

new ScriptGroup (Dialog_sideMission_04_C : dialogBox_base) 
{
   character[0] = "MS_EXTRA_02";
   text[0]      = "You are harboring a fugitive.  That is an act of treason!  Power down your ships NOW and prepare to be boarded.";
    
   character[1] = "MS_MINER";
   text[1]      = "This is ridiculous!  How can this meat bag be worth all this trouble?";   
};

///////////////////////////////////////////////////////////
// SPECIAL FUNCTIONS
///////////////////////////////////////////////////////////

//need to move to specialists.cs
//$skidPuffFaceData = "MALE M_head_02ImageMap M_eyes_02ImageMap M_mouth_04ImageMap M_nose_01ImageMap M_hair_03ImageMap 1 1 1 1";   

///////////////////////////////////////////////////////////
// SIDE MISSION SETUP
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_04 : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA CIV";
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1 S2_GetCapacitors"; //must come after story event
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_04"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_04 Dialog_sideMission_04_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_04";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "OH, IT'S YOU!!!";  
   description = "A very obnoxious distress call has been detected in this region.";
  
   initialWaves = "WAVE_Setup";
   
   missionText["initial"] = "MT_GOTO PICK UP THE POD";
   missionText["fight"] = "MT_ATTACK FIGHT OFF ATTACKERS";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "fight";    
        
   SelectionData["SectorProgress"] = "2 3"; 
   
   Rewards["Complete", "Spec"] = "SS_SpaceSkidPuff"; //until now, not sure how to make spec DB
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_Setup")
   {
      maxWaves = 1; 
      WaveMissionTrackers["active", 1] = "0";
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE;  
      waveRelations[1, 1] = "Terran Pirate" SPC $FactionRelation_HATE; 
      waveRelations[1, 2] = "Civ Pirate" SPC $FactionRelation_HATE; 
      new ScriptGroup("REF_puffPickup" : MO_Pickups)
      {   
         offset = "3500";   
         refObjectName = "REF_beacon";
         pickupWL = "S3_PrisonPod 10"; 
         objectFuncs["Spawn", 0] = "AddGoToMarker";           
         objectFuncs["Pickup", 0] = "CallInstanceFunc StartWaveName attackWave_civ 1000"; 
         objectCount = "1";  
         pickupFaction = "Pirate";    
      };          
   };
         
   new ScriptGroup("attackWave_civ")
   {
      maxWaves = 1;
      waveContext[1] = "fight"; 
       
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName attackWave_uta"; 
            
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";
      waveTimedCallbacks[1, 1] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_04_B"; 
      
      WaveMissionTrackers["remove", 1] = "0"; 
      WaveMissionTrackers["active", 1] = "1"; 
      new ScriptGroup(REF_attackShips : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "4"; 
         offset = "1000";  
         factionOverride = "Civ";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                         
         refObjectName = "REF_Player";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";  
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";   
      };       
   }; 
   new ScriptGroup("attackWave_uta")
   {
      maxWaves = 1;
       
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName attackWave_combo"; 
            
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";
      waveTimedCallbacks[1, 1] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_04_C"; 
      
      new ScriptGroup(REF_attackShips : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "3"; 
         offset = "1000";  
         factionOverride = "Terran";                     
         refObjectName = "REF_Player";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";  
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";   
      };       
   };  
   
   new ScriptGroup("attackWave_combo")
   {
      maxWaves = 2;
       
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName attackWave_combo"; 
      setHealthCallback[2, "enemy", 0] = "0 StartWaveName questComplete"; 
            
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";
      
      new ScriptGroup(REF_attackShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1"; 
         offset = "2500";  
         factionOverride = "Terran";                     
         refObjectName = "REF_Player";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";  
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";   
      }; 
      new ScriptGroup(REF_attackShips_02 : REF_attackShips_01)
      {                                      
         factionOverride = "Civ";  
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                         
      };        
   };    
}; 
