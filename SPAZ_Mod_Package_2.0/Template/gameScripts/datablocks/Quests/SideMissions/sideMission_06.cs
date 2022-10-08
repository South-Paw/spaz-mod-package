

///////////////////////////////////////////////////////////
// SIDE MISSION 06 DIALOG
///////////////////////////////////////////////////////////

new ScriptGroup (Dialog_sideMission_06_A : dialogBox_base) 
{
   character[0] = "MS_SPAMBOT";
   text[0]      = "Scientists have made an amazing discovery!  The Linear Ion Pump 3000 can increase the length of your index finger by %30.  No more hot ladies laughing at your stubby finger wag.  Order now for only 10 payments of $100,000.";
    
   character[1] = "MS_SPAMBOT";
   text[1]      = "THIS REALLY WORKS!!  Last month I sent this mail to 10 of my friends and within a week I had won the lottery, gained diplomatic immunity, and had my mother in law get eaten by zombies.  E-mail this to 10 other people you know, or you'll have bad luck for 7 years.";
  
   character[2] = "MS_SPAMBOT";
   text[2]      = "Greetings.  I have a client interested in starting up a business in far off regions.  My client has $100,000,000 to invest in various businesses across the Galaxy.  Your business seems to be a perfect fit for my client.  Send us $2000 to get the paper work going, and you'll receive an investment paycheck in the mail in the following weeks.";
  
   character[3] = "MS_PIRATE";
   text[3]      = "Oh shit!  Sub space spam generators.  It is our duty to humanity to destroy these things, at any cost!";   
};

new ScriptGroup (Dialog_sideMission_06_B : dialogBox_base) 
{
   character[0] = "MS_SPAMBOT";
   text[0]      = "WARNING!  Malicious software has been detected on your computer.  Perform a scan immediately.  Click here to cancel undoing the closure of this cancelled window that is opening.  Attack ships have been deployed to scan your hard drive.";

   character[1] = "MS_PIRATE";
   text[1]      = "What the hell?";   
};

new ScriptGroup (Dialog_sideMission_06_C : dialogBox_base) 
{
   character[0] = "MS_PIRATE";
   text[0]      = "Okay!  Let's never speak of this again.";   
};

///////////////////////////////////////////////////////////
// SPECIAL FUNCTIONS
///////////////////////////////////////////////////////////

function SideMission_06_ScriptEvent(%prop)
{
   //start camera focus
   %TotalSceneTime = 6000;
   presentationSchedule(%TotalSceneTime, true, "SEQ_activateSequence", "Dialog_sideMission_06_A");
   Camera_FocusOnObject(%prop, %TotalSceneTime, 0.6);
}

///////////////////////////////////////////////////////////
// SIDE MISSION SETUP
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_06 : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV";
      
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_06"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_06";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_06 Dialog_sideMission_06_C";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "AMAZING DISCOVERY";  
   description = "A beacon has been detected in the area requesting assistance.  Large profits are promised to those who assist.";
   
   missionText["initial"] = "MT_ATTACK DESTROY TRANSMITTERS";
   missionText["remaining"] = "MT_INFO REMAINING TRANSMITTERS:";
   missionText["attack"] = "MT_ATTACK DESTROY SPAM SHIPS";
   
   initialTimedCallbacks[0] = "10000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "4000 StartWaveName WAVE_SpamCrates"; //delay it so scripted event will work
   
   missionTrackerData[0] = "initial";   
   missionTrackerData[1] = "remaining MT_SETCOUNTER spamSet";
   missionTrackerData[2] = "attack";
   SelectionData["SectorProgress"] = "2 3"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_SpamCrates")
   {
      maxWaves = 1; 
      healthCallbackSets = "Cargo";
      setHealthCallback["All", "Cargo", 0] = "0 StartWaveName WAVE_spamAttackers";
      WaveMissionTrackers["active", 1] = "0 1"; 
      waveRelations[1, 0] = "Civ Pirate" SPC $FactionRelation_HATE;     
      //crates 
      new ScriptGroup(spam_crates_01 : MO_Props) 
      {     
         offset = "6000 7000";                                 
         instanceObjectWeightedList = "SpammerRadarDish";
         objectCount = "1";
         onInitializedFunc[0] = "AddToHealthCallbackSet Cargo";
         
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet targetCrates"; 
         objectFuncs["Spawn", 2] = "addToTrackingSet spamSet";  
        
         factionOverride = "Civ";  //so that cloak hunter srms can find them        
      };  
      new ScriptGroup(spam_crates_02 : spam_crates_01) 
      {     
         offset = "5000 6000";                                        
      }; 
      new ScriptGroup(spam_crates_03 : spam_crates_01) 
      {     
         offset = "3000 4000";  
         objectFuncs["Spawn", 3] = "callFunctionWithObject SideMission_06_ScriptEvent";                                      
      };
      //mines 
      new ScriptGroup(spamMines_01 : MO_Mines) 
      {                                      
         objectCount = "1"; 
         factionOverride = "civ";
         refObjectName = "spam_crates_01"; 
         offset = 0;
         instanceObjectWeightedList = "RegenSwarmMineField_large";
      };    
      new ScriptGroup(spamMines_02 : spamMines_01) 
      {                                      
         refObjectName = "spam_crates_02"; 
      }; 
      new ScriptGroup(spamMines_03 : spamMines_01) 
      {                                      
         refObjectName = "spam_crates_03"; 
      };       
   };
   
   new ScriptGroup("WAVE_spamAttackers")
   {
      maxWaves = 4;        
      waveContext[1] = "attack"; 
      WaveMissionTrackers["active", 1] = "2"; 
      WaveMissionTrackers["remove", 1] = "0 1"; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_spamAttackers"; 
      setHealthCallback[4, "enemy", 0] = "0 StartWaveName questComplete";     
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";
      waveTimedCallbacks[1, 1] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_06_B"; 
      new ScriptGroup(KillShips_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 5";
         objectCount = "2 3"; 
         factionOverride = "Civ"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                       
         refObjectName = "REF_Player";
         offset = "1000"; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";  
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
      };    
   };
}; 


