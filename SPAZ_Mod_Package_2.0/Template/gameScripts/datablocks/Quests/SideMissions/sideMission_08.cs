
///////////////////////////////////////////////////////////
// SIDE MISSION 08 DIALOG
///////////////////////////////////////////////////////////

//part 1

new ScriptGroup (Dialog_sideMission_08A_A : dialogBox_base) 
{
   character[0] = "MS_ANONYMOUS";
   text[0]      = "Greetings.  Please forgive the subterfuge, but my identity can not be made public.  I represent a conglomeration of both UTA and civilian interests.  As you know, civilization is falling apart and nobody is doing anything to remedy the situation.  That is where you and I come in.  I need you to take out a few select targets in order to maintain the balance of power.  There is a greater threat looming, and all of our chess pieces must be in place if we are to survive as a species.";
   
   character[1] = "MS_PIRATE";
   text[1]      = "What a pitch!  In all honesty, I don't really give two shits about your agenda.  All I need from you is a target and a fat pay check when this is over.  We're pirates and mercenaries, so as soon as the cash flow stops, we're gone.  Don't forget that."; 

   character[2] = "MS_ANONYMOUS";
   text[2]      = "Very well.  I'm transmitting the mission details to you now.  I assure you, you'll be handsomely rewarded from your troubles.  You are free to do whatever you please with any survivors."; 

   character[3] = "MS_PIRATE";
   text[3]      = "Thanks, but I don't need your permission."; 
};

new ScriptGroup (Dialog_sideMission_08A_B : dialogBox_base) 
{
   character[0] = "MS_ANONYMOUS";
   text[0]      = "Good work.  I'm sure this doesn't make a lot of sense, but your actions have seeded great changes for the future.  We will be in touch."; 

   character[1] = "MS_PIRATE";
   text[1]      = "Whatever you say buddy.  Don't let the airlock hit your ass on the way out."; 

   character[2] = "MS_MINER";
   text[2]      = "Shit, you wake up on the wrong side of the event horizon?  What is up with you anyway?"; 
};

//part 2

new ScriptGroup (Dialog_sideMission_08B_A : dialogBox_base) 
{
   character[0] = "MS_ANONYMOUS";
   text[0]      = "Hello again.  As you can no doubt see, human dominance over the Galaxy is slipping away.  Though you have your own goals, they truly do coincide with my own.  To that effect, I ask for your services once again.  We must keep the War balanced, or all will be lost.  There is a civilian fleet under attack by infected vessels.  As counter productive as it may appear, they must lose this fight, and the infection must spread.  You must not harm the infected ships.";
   
   character[1] = "MS_MINER";
   text[1]      = "Say what?  No way are we doing that.  Those are human beings, and you want us to condemn them to a fate worse than death?";
   
   character[2] = "MS_ANONYMOUS";
   text[2]      = "The harder the path ahead of us, the stronger we become.  I don't expect you to have the foresight to understand the game being played here, but we are all pawns.  Do as I ask, and you will get your payment.  That is what you want, correct?";

   character[3] = "MS_PIRATE";
   text[3]      = "Don't screw this up Elsa.  The reality is we're barely hanging on here.  We need to get paid so we can eat some time this week.  Thousands of ships are lost every day to these zombie freaks.  Another couple more won't make any difference.";
};

new ScriptGroup (Dialog_sideMission_08B_B : dialogBox_base) 
{
   character[0] = "MS_ANONYMOUS";
   text[0]      = "Excellent!  Your payment is being transferred to you now.  You truly are ensuring the survival of our race.  We will be in contact again.";

   character[1] = "MS_PIRATE";
   text[1]      = "Ya, we're all Saints, now wire me my damn payment.  Your shadowy mumbo bullshit is getting irritating.";
   
   character[2] = "MS_MINER";
   text[2]      = "Don, what is it with you and this guy?  I know you're a son of a bitch, but I've never seen you quite this hostile.";
   
   character[3] = "MS_PIRATE";
   text[3]      = "Elsa, one thing you'll learn before this is all over, is to never trust anyone.";
};

//part 3

new ScriptGroup (Dialog_sideMission_08C_A : dialogBox_base) 
{
   character[0] = "MS_ANONYMOUS";
   text[0]      = "Hello again my friends.  I have brought you here to say only one thing.  How very disappointed I am in you both.";
   
   character[1] = "MS_MINER";
   text[1]      = "What the hell are you talking about?";
   
   character[2] = "MS_EVILDON";
   text[2]      = "It was me Elsa.  Together we've been doing the work of the damned.  I had no choice, but you did!  I did my best to tell you never to trust anyone.  You never could read between the lines Elsa.";

   character[3] = "MS_MINER";
   text[3]      = "Oh my god, what are you saying?  Are we responsible for this?";
   
   character[4] = "MS_EVILDON";
   text[4]      = "In a sense, yes, we are all responsible for breaching the gates.  We all played our part.  As for these trivial and meaningless tasks, even I don't fully understand the will of the infection.  I simply do as I'm instructed.";

   character[5] = "MS_MINER";
   text[5]      = "Don't give me that crap Don.  How could you do this to me?  You were like a father to me, and you did nothing but blow smoke up my ass from day one!";
   
   character[6] = "MS_EVILDON";
   text[6]      = "I did my damnedest to reach out to you Elsa.  I tried to teach you to make your own decisions, to leave this wretched life behind and live your own!  I'm a renegade pirate traveling with a half mad scientist charged with crimes against humanity.  This is the company you choose?  How could I possibly make this life more unappealing for you?  You put entirely too much blind faith in believing I was a good person.  Now there is no hope.  All that is left is the end.  It is time for you to be put to rest.  I'm sorry I failed you.";

   character[7] = "MS_MINER";
   text[7]      = "Put to rest my ass!  You and I, we're going to finish this right here, right now!";
};

new ScriptGroup (Dialog_sideMission_08C_B : dialogBox_base) 
{
   character[0] = "MS_EVILDON";
   text[0]      = "Elsa, you never cease to impress me with your resourcefulness.  Just remember, every infected vessel you destroy, we claim thousand more.  What is done can't be undone.  You can count on seeing me again.  Farewell.";

   character[1] = "MS_MINER";
   text[1]      = "You son of a bitch!  Where ever you are, I'm going to find you and fly this ship straight up your ass.";
   
   character[2] = "MS_SCIENTIST";
   text[2]      = "Well that certainly was unexpected.  At least we somehow got paid for the jobs.  What baffles me is, where did he keep all the Rez to bait us along this far.  His deception was nearly seamless.";
   
   character[3] = "MS_MINER";
   text[3]      = "Carl, just shut up.  I'll be in my quarters.  I need to be alone right now.";
};

///////////////////////////////////////////////////////////
// SIDE MISSION SETUP A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_08A : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA CIV";
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_08A"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_08A Dialog_sideMission_08A_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_08A Dialog_sideMission_08A_B";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "BALANCE OF POWER PART 1";  
   description = "A mysterious man is offering a business opportunity.";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE TARGETS";
   missionText["revenge"] = "MT_ATTACK REINFORCEMENTS HAVE ARRIVED";

   initialWaves = "WAVE_setupShips";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";   
   
   SelectionData["SectorProgress"] = "2 3";  
   DeployData["LevelRange"]     = "20 100"; //too hard to come early
   
   Rewards["Complete", "Spec"] = "SS_BalancePower1"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_setupShips")
   {
      maxWaves = 1;        
      WaveMissionTrackers["active", 1] = "0"; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_revenge";
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_FRIEND;
      new ScriptGroup(REF_targetStation_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         objectCount = "1"; 
         factionOverride = "Civ";                     
         offset = "4500"; 
         shipDesignWL = "Pirate01Base 10";  
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_Pissoff";   
      };
      new ScriptGroup(UTA_Beacon_01 : MO_Ships) 
      {    
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "1000";  
         creationChance = 1;  
         objectCount = "1";
         factionOverride = "Terran";
         refObjectName = "REF_targetStation_01"; 
         
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_Pissoff";    
           
         shipDesignWL = "BeaconBase_02 10"; 
      };  
      new ScriptGroup(UTA_Beacon_02 : UTA_Beacon_01) 
      {    
      };   
      new ScriptGroup(targetShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "2"; 
         factionOverride = "Terran";                      
         refObjectName = "REF_targetStation_01";
         offset = "1000";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_Pissoff";   
      }; 
      new ScriptGroup(targetShips_02 : targetShips_01)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "2"; 
         factionOverride = "Civ";  
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                      
         offset = "1000";  
      };         
   };
   
   new ScriptGroup("WAVE_revenge")
   {
      maxWaves = 1;
      waveContext[1] = "revenge";
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName QuestComplete";   
      new ScriptGroup(revengeShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1"; 
         factionOverride = "Terran";                      
         refObjectName = "REF_targetStation_01";
         offset = "1000";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_Pissoff";  
      }; 
      new ScriptGroup(revengeShips_02 : revengeShips_01)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "3"; 
         factionOverride = "Civ";  
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                       
      };  
   };
   
   new ScriptGroup("WAVE_Pissoff")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations civ -1";
      waveTimedCallbacks["All", 1] = "1500 callQuestFunction ChangePlayerRelations terran -1";
   }; 
}; 

///////////////////////////////////////////////////////////
// SIDE MISSION SETUP B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_08B : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV";
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1 OBJ_SideMission_08A"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_08B"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_08B Dialog_sideMission_08B_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_08B Dialog_sideMission_08B_B";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "BALANCE OF POWER PART 2";  
   description = "The mysterious man has returned with a new job opportunity.";
   
   missionText["initial"] = "MT_ATTACK DESTROY TARGET SHIPS";
   missionText["remaining"] = "MT_INFO KILL QUOTA";
   missionText["defend"] = "MT_DEFEND DEFEND INFECTED TARGETS";
   missionText["acceptLost"] = "MT_INFO ACCEPTABLE LOSSES";
   missionText["failText"] = "MT_FAIL TOO MANY INFECTED SHIPS LOST";

   initialWaves = "WAVE_zomWave WAVE_civWave";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick killsNeeded 10";
   initialTimedCallbacks[2] = "0 TS_addTrackingTick acceptableLosses 5";
   
   missionTrackerData[0] = "initial";   
   missionTrackerData[1] = "remaining MT_TICKCOUNTER killsNeeded";
   missionTrackerData[2] = "defend";
   missionTrackerData[3] = "acceptLost MT_TICKCOUNTER acceptableLosses";   
   
   DeployData["StarType"] = "INNER";
   SelectionData["SectorProgress"] = "3 3"; 
   SelectionData["InfectionLevel"] = "1 3";  
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_zomWave")
   {
      maxWaves = 5;        
      WaveMissionTrackers["active", 1] = "0 1 2 3"; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zomWave 6000";
      waveRelations[1, 0] = "Civ Zombie" SPC $FactionRelation_HATE;
      waveRelations[1, 1] = "Pirate Zombie" SPC $FactionRelation_ENEMY; //make sure the zoms go after targets
      new ScriptGroup(targetShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "2"; 
         factionOverride = "Zombie";                 
         refObjectName = "REF_Beacon";
         offset = "3000";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddDefendMarker";
         objectFuncs["Death", 0] = "CallInstanceFunc TS_addTrackingTick acceptableLosses -1"; 
         objectFuncs["Death", 1] = "CallInstanceFunc TS_evalTrackingTick acceptableLosses 0 StartWaveName QuestFail 0 failText";    
      };     
   };
   
   new ScriptGroup("WAVE_civWave")
   {
      maxWaves = 5;
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName WAVE_civWave 4000";  
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";         
      new ScriptGroup(targetShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "3"; 
         factionOverride = "Civ";  
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                    
         refObjectName = "REF_Beacon";
         offset = "3000";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";   
         objectFuncs["Death", 0] = "CallInstanceFunc TS_addTrackingTick killsNeeded -1"; 
         objectFuncs["Death", 1] = "CallInstanceFunc TS_evalTrackingTick killsNeeded 0 StartWaveName QuestComplete";    
      };       
   };
}; 


///////////////////////////////////////////////////////////
// SIDE MISSION SETUP C
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_08C : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1 OBJ_SideMission_08B"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_08C"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_08C Dialog_sideMission_08C_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_08C Dialog_sideMission_08C_B";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "BALANCE OF POWER PART 3";  
   description = "A mysterious man requires one final favor.";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE TARGETS";

   initialWaves = "WAVE_zomAttack_01";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";   
   
   DeployData["StarType"] = "INNER";
   SelectionData["SectorProgress"] = "4 4";  
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_zomAttack_01")
   {
      maxWaves = 2;        
      WaveMissionTrackers["active", 1] = "0"; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zomAttack_01";
      setHealthCallback[2, "enemy", 0] = "0 StartWaveName WAVE_zomAttack_02";
      new ScriptGroup(targetShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "3"; 
         factionOverride = "ZombieKiller";                   
         refObjectName = "REF_Beacon";
         offset = "3000";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
      };      
   };
   
   new ScriptGroup("WAVE_zomAttack_02")
   {
      maxWaves = 2;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zomAttack_02";
      setHealthCallback[2, "enemy", 0] = "0 StartWaveName WAVE_zomAttack_03";
      new ScriptGroup(targetShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "2"; 
         factionOverride = "ZombieKiller";                   
         refObjectName = "REF_Beacon";
         offset = "3000";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
      };      
   };
   
   new ScriptGroup("WAVE_zomAttack_03")
   {
      maxWaves = 1;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName QuestComplete";
      new ScriptGroup(targetShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1"; 
         factionOverride = "ZombieKiller";                   
         refObjectName = "REF_Beacon";
         offset = "3000";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
      };      
   };
}; 











