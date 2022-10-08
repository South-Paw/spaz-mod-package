

///////////////////////////////////////////////////////////
// SIDE MISSION 01 DIALOG
///////////////////////////////////////////////////////////

//mission 1

new ScriptGroup (Dialog_sideMission_02_A_A : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "According to my readings, this artifact differs from the common ones we see littered throughout space.  We should crack it open and salvage what we can from inside.  There are a few unremarkable ones in the area, so you'll have to break them all to find the sample we're looking for.";
    
   character[1] = "MS_PIRATE";
   text[1]      = "Destroy the priceless artifacts?  It's not a damn fortune cookie!  You sure do have a delicate touch there Carl.  Make this quick so we can get back on the road.";   
};

new ScriptGroup (Dialog_sideMission_02_A_B : dialogBox_base) 
{
   character[0] = "MS_EXTRA_02";
   text[0]      = "This area is restricted.  You will power down your ships and relinquish your cargo immediately!";
    
   character[1] = "MS_PIRATE";
   text[1]      = "Nothing ever comes easy, does it?";   
};

new ScriptGroup (Dialog_sideMission_02_A_C : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "Well now that we've dispensed with the pleasantries, let me take a look at this artifact.  Yes, yes, very interesting.  This appears to be some kind of marker.  I believe it is one of many.  I won't be able to find out too much more unless we collect more samples.  I need something to compare it with before I can decipher more.  You people need to keep an eye out for more of these.  They could be anywhere.";
    
   character[1] = "MS_MINER";
   text[1]      = "Great!  Because we just don't have anything better to do than to look for needles in haystacks.";   
};

//mission 2

new ScriptGroup (Dialog_sideMission_02_B_A : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "Excellent, I've located another rare artifact.  Go fetch it for me!  I'll be awaiting the samples in my lab.";
    
   character[1] = "MS_MINER";
   text[1]      = "You forgot to say the magic word you slave driver.  Wait a minute!  I'm picking up enemy contacts.  We're not the only ones looking for a score here.  Weapons hot!";   
};

new ScriptGroup (Dialog_sideMission_02_B_B : dialogBox_base) 
{
   character[0] = "MS_EXTRA_02";
   text[0]      = "Salvaging contraband is illegal.  That artifact will be confiscated.  Leave this area immediately.";
    
   character[1] = "MS_SCIENTIST";
   text[1]      = "Thieving bastard!  How dare he make off with my prize.  Destroy his ship, now!";   
};

new ScriptGroup (Dialog_sideMission_02_B_C : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "Fascinating!  These artifacts are millions of years old.  Each seems to contain a critical piece of some puzzle, but I can't quite yet understand it.  Whoever  built these intentionally scattered them across the Galaxy, presumably to ensure whoever found them had some base level of technology.  Whatever secrets are within must be mine.  Go fetch another!";
    
   character[1] = "MS_PIRATE";
   text[1]      = "The galaxy is a damn big place.  We're lucky we even stumbled across two so far.  The question is, are we opening a treasure chest or Pandora's Box?";   
};

//mission 3

new ScriptGroup (Dialog_sideMission_02_C_A : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "This is the last one.  Finally, after all this time!  You should know the drill by now.  Fetch!  Oh, and watch out for all those infected ships.";
   
   character[1] = "MS_MINER";
   text[1]      = "Shucks, thanks Carl!  You go ahead and play outside, and I'll call you in for supper.  Don't trouble yourself with any real work.";   

};

new ScriptGroup (Dialog_sideMission_02_C_B : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "No, this is impossible!  It's empty.";
   
   character[1] = "MS_MINER";
   text[1]      = "Carl, we can't stick around and have a cry.  We need to evacuate.  I'm picking up a lot of infected bogies heading our way.  I'll get you some ice cream later.";   

   character[2] = "MS_SCIENTIST";
   text[2]      = "Don't you patronize me grease monkey.  We can't leave until I've found it!  The signal is still on radar.  One of these infected vessels must be carrying it.  Elsa, we must find it.";   

   character[3] = "MS_MINER";
   text[3]      = "Shit!  Fine, fine!  Let's go risk life and limb for trinkets, again.";   
};

new ScriptGroup (Dialog_sideMission_02_C_C : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "Amazing!  I'm able to combine all three artifacts to unlock a repository of ancient alien research.  This is definitely the same race that built the alien warp gate.  It's a legacy of a long since extinct race.  They left their secrets behind, hidden away in a puzzle.  I believe they are trying to safeguard future races against the infection by improving their technology.";
    
   character[1] = "MS_MINER";
   text[1]      = "Well isn't that all fine and dandy.  Lets hope you're right and they don't come back all pissed off after we just raided their toy box.  Integrate what you can into the database and let's get the hell out of here.";   
};

///////////////////////////////////////////////////////////
// SIDE MISSION SETUP 2A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_02_A : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA";
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_02_A"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_02_A Dialog_sideMission_02_A_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_02_A Dialog_sideMission_02_A_C";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "THE TREASURE HUNT PART 1";  
   description = "An alien artifact has been detected in the area.  Further study is required.";
  
   initialWaves = "WAVE_setup";
   
   missionText["initial"] = "MT_ATTACK CRACK OPEN THE ARTIFACTS";
   missionText["attack"] = "MT_ATTACK DESTROY ATTACKERS";
   missionText["pickup"] = "MT_GOTO COLLECT THE ARTIFACT";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "pickup"; 
   missionTrackerData[2] = "attack";       
      
   SelectionData["SectorProgress"] = "2 3"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_setup")
   {    
      maxWaves = 1;  
      WaveMissionTrackers["active", 1] = "0"; 
      new ScriptGroup("REF_Artifact" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_Artifacts";
         objectCount = "1"; 
         offset = "4500"; 
         refObjectName = "REF_Beacon";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_dropBox 0";  
         minDistanceOverride = 0;
         maxDistanceOverride = 0;                          
      }; 
      new ScriptGroup("REF_FakeArtifact_1" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_Artifacts";
         objectCount = "1"; 
         offset = "4500"; 
         refObjectName = "REF_Beacon";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet artifactSet";  
         minDistanceOverride = 0;
         maxDistanceOverride = 0;                          
      }; 
      new ScriptGroup("REF_FakeArtifact_2" : REF_FakeArtifact_1) 
      {                       
      }; 
      new ScriptGroup("REF_FakeArtifact_3" : REF_FakeArtifact_1) 
      {                       
      }; 
      new ScriptGroup(Barrels_01 : MO_Props) 
      {    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels 10";                                
         objectCount = "10";
         offset = "0";  
         refObjectName = "REF_Artifact"; 
      };
      new ScriptGroup(Barrels_02 : Barrels_01) 
      {    
         refObjectName = "REF_FakeArtifact_1"; 
      };
      new ScriptGroup(Barrels_03 : Barrels_01) 
      {    
         refObjectName = "REF_FakeArtifact_2"; 
      };
      new ScriptGroup(Barrels_04 : Barrels_01) 
      {    
         refObjectName = "REF_FakeArtifact_3"; 
      };
      new ScriptGroup(AmbientShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 5";
         objectCount = "2"; 
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         offset = "3000"; 
      };    
      new ScriptGroup(AmbientShips_01 : AmbientShips_01)
      {                                      
         factionOverride = "Civ"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                     
      };           
   };
   
   new ScriptGroup("WAVE_dropBox")
   {
      maxWaves = 1;        
      waveContext[1] = "pickup"; 
      WaveMissionTrackers["active", 1] = "1";
      WaveMissionTrackers["remove", 1] = "0"; 
      
      waveTimedCallbacks[1, 0] = "0 trackingSet_callOnObjects artifactSet RemoveObjectiveMarker_ALL";       
      
      new ScriptGroup(CollectProp_01 : MO_Pickups)
      {  
         offset = "0";                                  
         objectCount = "1";
         refObjectName = "REF_Artifact";    
         objectFuncs["Spawn", 0] = "AddGoToMarker";   
         objectFuncs["Pickup", 0] = "CallInstanceFunc StartWaveName WAVE_UTA_attackers 0"; 
         minDistanceOverride = 0;
         maxDistanceOverride = 0;                                    
      };
   };
   
   new ScriptGroup("WAVE_UTA_attackers")
   {   
      maxWaves = 3;  
      waveContext[1] = "attack";
      
      WaveMissionTrackers["active", 1] = "2";
      WaveMissionTrackers["remove", 1] = "1"; 
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName WAVE_UTA_attackers"; 
      setHealthCallback[3, "enemy", 0] = "0 StartWaveName questComplete"; 
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";
      waveTimedCallbacks[1, 1] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_02_A_B"; 
      
      waveRelations[1, 0] = "Terran Pirate" SPC $FactionRelation_HATE; 
               
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         objectCount = "2 3"; 
         factionOverride = "Terran"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                     
         refObjectName = "REF_Player";
         offset = "3500"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
         objectFuncs["Spawn", 1] = "AddTargetMarker"; 
      };          
   };
}; 

///////////////////////////////////////////////////////////
// SIDE MISSION SETUP 2B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_02_B : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV UTA";
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1 OBJ_SideMission_02_A"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_02_B"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_02_B Dialog_sideMission_02_B_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_02_B Dialog_sideMission_02_B_C";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "THE TREASURE HUNT PART 2";  
   description = "An alien artifact has been detected in the area.  Further study is required.";
  
   initialWaves = "WAVE_setup";
   
   missionText["initial"] = "MT_ATTACK CRACK OPEN THE ARTIFACT";
   missionText["takeBack"] = "MT_ATTACK TAKE BACK THE ARTIFACT";
   missionText["pickup"] = "MT_GOTO COLLECT THE ARTIFACT";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "4000 StartWaveName WAVE_attackers";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "takeBack";
   missionTrackerData[2] = "pickup";      
      
   SelectionData["SectorProgress"] = "2 3"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_setup")
   {    
      maxWaves = 1;  
      WaveMissionTrackers["active", 1] = "0"; 
      waveRelations[1, 0] = "Civ Pirate" SPC $FactionRelation_HATE; 
      new ScriptGroup("REF_Artifact" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_Artifacts";
         objectCount = "1"; 
         offset = "4500"; 
         refObjectName = "REF_Beacon";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_UTA_swoop 0";
         minDistanceOverride = 0;
         maxDistanceOverride = 0;                            
      };           
   };
   
   new ScriptGroup("WAVE_UTA_swoop")
   {    
      maxWaves = 1; 
      waveContext[1] = "takeBack";
      waveRelations[1, 0] = "Terran Pirate" SPC $FactionRelation_HATE;  
      WaveMissionTrackers["active", 1] = "1";
      WaveMissionTrackers["remove", 1] = "0"; 
      waveTimedCallbacks[1, 0] = "1000 callQuestFunction SEQ_activateSequence Dialog_sideMission_02_B_B";   
      new ScriptGroup(REF_swooperLoc : MO_Trigger) 
      {                                
      };         
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1"; 
         factionOverride = "Terran";                    
         refObjectName = "REF_Artifact";
         offset = "0"; 
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_dropBox 0";  
         mountRefObjectNames = "REF_swooperLoc";   
      };          
   };
   
   new ScriptGroup("WAVE_dropBox")
   {
      maxWaves = 1;        
      waveContext[1] = "pickup"; 
      WaveMissionTrackers["active", 1] = "2";
      WaveMissionTrackers["remove", 1] = "1"; 
      new ScriptGroup(CollectProp_01 : MO_Pickups)
      {  
         offset = "0";                                  
         objectCount = "1";
         refObjectName = "REF_swooperLoc";    
         objectFuncs["Spawn", 0] = "AddGoToMarker";   
         objectFuncs["Pickup", 0] = "CallInstanceFunc StartWaveName QuestComplete 0"; 
         minDistanceOverride = 0;
         maxDistanceOverride = 0;                                    
      };
   };
   
   new ScriptGroup("WAVE_attackers")
   {    
      maxWaves = 6;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName WAVE_attackers 1500"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";         
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         objectCount = "Scaled 2 4"; 
         factionOverride = "Civ"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                     
         refObjectName = "REF_Player";
         offset = "2000"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";
      };          
   };
}; 


///////////////////////////////////////////////////////////
// SIDE MISSION SETUP 2C
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_02_C : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1 OBJ_SideMission_02_B"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_02_C"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_02_C Dialog_sideMission_02_C_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_02_C Dialog_sideMission_02_C_C";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "THE TREASURE HUNT PART 3";  
   description = "An alien artifact has been detected in the area.  Further study is required.";
  
   initialWaves = "WAVE_setup WAVE_attackers";
   
   Rewards["Complete", "Data"] = "Exact 2500";
   
   missionText["initial"] = "MT_ATTACK CRACK OPEN THE ARTIFACT";
   missionText["findPickup"] = "MT_ATTACK DESTROY TARGETS TO FIND ARTIFACT";
   missionText["pickup"] = "MT_GOTO COLLECT THE ARTIFACT";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "findPickup"; 
   missionTrackerData[2] = "pickup"; 
   
   DeployData["StarType"] = "INNER";  
   SelectionData["SectorProgress"] = "4 4"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_setup")
   {    
      maxWaves = 1;  
      WaveMissionTrackers["active", 1] = "0"; 
      new ScriptGroup("REF_Artifact" : MO_Props) 
      {
         instanceObjectWeightedList = "SpaceProp_Artifacts";
         objectCount = "1"; 
         offset = "4500"; 
         refObjectName = "REF_Beacon";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_zomFleet_01 0";  
         minDistanceOverride = 0;
         maxDistanceOverride = 0;                          
      };           
   };
      
   new ScriptGroup("WAVE_attackers")
   {    
      maxWaves = 1;        
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 5";
         objectCount = "3"; 
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Artifact";
         offset = "700"; 
      }; 
      new ScriptGroup(KillShips_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 5";
         objectCount = "3"; 
         factionOverride = "Zombie";                     
         refObjectName = "REF_Artifact";
         offset = "700"; 
      };           
   };
   
   new ScriptGroup("WAVE_zomFleet_01")
   {    
      maxWaves = 3; 
      waveContext[1] = "findPickup";
      WaveMissionTrackers["remove", 1] = "0"; 
      WaveMissionTrackers["active", 1] = "1"; 
       
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName WAVE_zomFleet_01 1500"; 
      setHealthCallback[3, "enemy", 0] = "0 StartWaveName WAVE_zomFleet_02 1500"; 
      
      waveTimedCallbacks[1, 0] = "1000 callQuestFunction SEQ_activateSequence Dialog_sideMission_02_C_B"; 
               
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         objectCount = "2 3"; 
         factionOverride = "ZombieKiller";                  
         refObjectName = "REF_Player";
         offset = "4000"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
      };          
   };
   
   new ScriptGroup("WAVE_zomFleet_02")
   {    
      maxWaves = 1;         
      new ScriptGroup(REF_zomShipLoc : MO_Trigger) 
      {                                
      }; 
      new ScriptGroup(KillShips_fake : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         objectCount = "1"; 
         factionOverride = "ZombieKiller";                  
         refObjectName = "REF_Player";
         offset = "4000"; 
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
      }; 
      new ScriptGroup(KillShips_real : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";
         objectCount = "1"; 
         factionOverride = "ZombieKiller";                  
         refObjectName = "REF_Player";
         offset = "4000"; 
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_dropBox 0";  
         mountRefObjectNames = "REF_zomShipLoc";       
      };   
   };
   
   new ScriptGroup("WAVE_dropBox")
   {
      maxWaves = 1;        
      waveContext[1] = "pickup"; 
      WaveMissionTrackers["active", 1] = "2";
      WaveMissionTrackers["remove", 1] = "1"; 
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects KillShips_fake RemoveObjectiveMarker_ALL"; 
      new ScriptGroup(CollectProp_01 : MO_Pickups)
      {  
         offset = "0";                                  
         objectCount = "1";
         refObjectName = "REF_zomShipLoc";    
         objectFuncs["Spawn", 0] = "AddGoToMarker";   
         objectFuncs["Pickup", 0] = "CallInstanceFunc StartWaveName QuestComplete 0";
         minDistanceOverride = 0;
         maxDistanceOverride = 0;                                     
      };
   };
}; 
