

///////////////////////////////////////////////////////////
// SIDE MISSION 05 DIALOG
///////////////////////////////////////////////////////////

new ScriptGroup (Dialog_sideMission_05_A_intro : dialogBox_base) 
{
   character[0] = "MS_MOONBURGER";
   text[0]      = "Moon Burger thanks you for accepting the position of \"Meat node harvester\".  Moon Burger is excited you are part of the fine Moon Burger family.  Be sure to contact HR and set up your contact info.  Moon burger provides full dental benefits, and underground parking is available upon request.";
   
   character[1] = "MS_MINER";
   text[1]      = "Well, harvesting food supplies from the vacuum of space might not be my idea of fine dining, but I suppose people need to eat.  Let's collect as much as we can for these poor folks.";
};

new ScriptGroup (Dialog_sideMission_05_A : dialogBox_base) 
{
   character[0] = "MS_MINER";
   text[0]      = "Is it just me, or is this the worst thing we've ever done?  Harvesting toxic waste for a meat substitute seems so very wrong.";
    
   character[1] = "MS_EXTRA_02";
   text[1]      = "Halt, you are in violation of the UTA health standard code.  Power down your ships and prepare to be boarded.";   
   
   character[2] = "MS_PIRATE";
   text[2]      = "Damn it Elsa, why did you have to open your yap?  This could have been a simple pay day, but yet again we're in a fight for our lives.";  
};

new ScriptGroup (Dialog_sideMission_05_B : dialogBox_base) 
{
   character[0] = "MS_PIRATE";
   text[0]      = "Damn, we're short the quota.  There isn't enough meat in this system.  Where's the beef!";
    
   character[1] = "MS_SCIENTIST";
   text[1]      = "I should be able to successfully synthesize something convincing from spent reactor coolant.  I'm targeting candidates now.  Destroy the ships and recover the reactor casings.  Have Elsa scrub them for the coolant residue.";   
   
   character[2] = "MS_MINER";
   text[2]      = "Sigh!  Why do I even bother arguing with you?  I guess I'll go put the hazard suit on, again.";  
};

new ScriptGroup (Dialog_sideMission_05_C : dialogBox_base) 
{
   character[0] = "MS_MOONBURGER";
   text[0]      = "On behalf of Moon Burger, we thank you for your assistance.  In addition to the standard payment, we're offering you a life time supply of Moon Burger products.  If you choose not to accept your life time voucher, we can offer you a fully functional bipedal human laborer, which has infinitely less value than our fine food products.  \n\nPlease note that our secret recipes are not to be disclosed.  Violation is punishable by organ liquefaction.";
    
   character[1] = "MS_MINER";
   text[1]      = "Consuming \"anything\" from Moon Burger results in organ liquefacton.  Lets pick up that poor sap laborer and tell Moon Barf where they can stick their voucher.  Excuse me while I spend the rest of the evening dry heaving.";   
};

///////////////////////////////////////////////////////////
// SIDE MISSION 05 B DIALOG
///////////////////////////////////////////////////////////

new ScriptGroup (Dialog_sideMission_05_D : dialogBox_base) 
{
   character[0] = "MS_MINER";
   text[0]      = "This is zombie country!  They can't really expect people to eat infected meat!  Do people even know what they are putting into their mouths?  Is this even safe?";
    
   character[1] = "MS_SCIENTIST";
   text[1]      = "Oh I'm sure it is perfectly safe if you cook it.  And expose it to high doses of gamma radiation, and flash freeze it, and maybe boil it for twenty hours, then leave it in the vacuum of space for a week or so.  Ya, I'm sure it's fine.  The milk shakes on the other hand, stay clear of those.";   
   
   character[2] = "MS_MINER";
   text[2]      = "Gross!  This is a nightmare.  If anything, they'll give us another one of their slave line cooks for payment.  Not only do we need the labor, but I couldn't live with myself leaving someone to this hellish fate.";  
};

new ScriptGroup (Dialog_sideMission_05_E : dialogBox_base) 
{
   character[0] = "MS_MOONBURGER";
   text[0]      = "On behalf of Moon Burger, we thank you for your assistance.  In addition to the standard payment . . .";
    
   character[1] = "MS_MINER";
   text[1]      = "Yes yes!  Just give up the damn slave.  We're not eating your latrine blaster.  Not unless you offer a stomach pump free with every meal.";   
};

///////////////////////////////////////////////////////////
// SIDE MISSION SETUP
///////////////////////////////////////////////////////////


new ScriptGroup(Quest_SideMission_05 : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA";
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_05"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_05 Dialog_sideMission_05_A_intro";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_05 Dialog_sideMission_05_C";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "MOON BURGER NEEDS \"BEEF\"";  
   description = "The popular Moon Burger franchise is having a hard time acquiring material for their meat patties.";
  
   initialWaves = "WAVE_meatRocks";
   
   missionText["initial"] = "MT_ATTACK DESTROY BARRELS FOR MEAT";
   missionText["collect"] = "MT_GOTO COLLECT MEAT NODES";
   missionText["meatCount"] = "MT_INFO MEAT NEEDED:";
   missionText["killShips"] = "MT_ATTACK DESTROY TARGETS FOR REACTOR COOLANT";
   missionText["collectCoolant"] = "MT_GOTO COLLECT REACTOR COOLANT";
   missionText["coolantNeeded"] = "MT_INFO COOLANT NEEDED:";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick meatNeeded 15";
   initialTimedCallbacks[2] = "0 TS_addTrackingTick coolantNeeded 2";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "collect";
   missionTrackerData[2] = "meatCount MT_TICKCOUNTER meatNeeded"; 
   missionTrackerData[3] = "killShips";
   missionTrackerData[4] = "collectCoolant";
   missionTrackerData[5] = "coolantNeeded MT_TICKCOUNTER coolantNeeded";      
        
   SelectionData["SectorProgress"] = "2 3"; 
   
   Rewards["Complete", "Spec"] = "SS_MoonBeef"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   //spawn props
   new ScriptGroup("WAVE_meatRocks")
   {
      maxWaves = 1;  
      WaveMissionTrackers["active", 1] = "0 1 2";
      new ScriptGroup("WAVE_meatRock_01") 
      {                                      
         instanceObjectWeightedList = "SpaceProp_AcidBarrels";
         offset = "3000 6500";
         refObjectName = "REF_Beacon";  
         creationChance = 1;
         minDistanceOverride = 0;
         maxDistanceOverride = 0;
         objectCount = "1";
         objectFuncs["Spawn", 0] = "AddTargetMarker";   
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_meatSpawn_01 0";      
      };
      new ScriptGroup("WAVE_meatRock_02" : WAVE_meatRock_01) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_meatSpawn_02 0";                                          
      };
      new ScriptGroup("WAVE_meatRock_03" : WAVE_meatRock_01) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_meatSpawn_03 0";                                          
      };
      new ScriptGroup("WAVE_meatRock_04" : WAVE_meatRock_01) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_meatSpawn_04 0";                                          
      };
      new ScriptGroup("WAVE_meatRock_05" : WAVE_meatRock_01) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_meatSpawn_05 0";                                          
      };
   };   
   
   //meat pickups      
   new ScriptGroup("WAVE_meatSpawn_01")
   {
      maxWaves = 1;  
      new ScriptGroup("REF_meatPickup_01" : MO_pickups) 
      {                                      
         offset = "0 0";                                  
         objectCount = "3";
         refObjectName = "WAVE_meatRock_01"; 
         pickupWL = "MissionPickup_MeatNode 10";  
         pickupImpulse = 200;    
         objectFuncs["Spawn", 0] = "AddGoToMarker";       
         objectFuncs["Pickup", 0] = "CallInstanceFunc TS_addTrackingTick meatNeeded -1";
         objectFuncs["Pickup", 1] = "CallInstanceFunc TS_evalTrackingTick meatNeeded 0 StartWaveName WAVE_coolantHarvest_01";  
         objectFuncs["Pickup", 2] = "CallInstanceFunc TS_evalTrackingTick meatNeeded 13 StartWaveName attackWave_uta";    
         objectFuncs["Pickup", 3] = "CallInstanceFunc TS_evalTrackingTick meatNeeded 13 StartWaveName WAVE_Pissoff";    
      };
   }; 
   new ScriptGroup("WAVE_meatSpawn_02" : WAVE_meatSpawn_01)
   {
      new ScriptGroup("REF_meatPickup_02" : REF_meatPickup_01) 
      {                                      
         refObjectName = "WAVE_meatRock_02";          
      };
   }; 
   new ScriptGroup("WAVE_meatSpawn_03" : WAVE_meatSpawn_01)
   {
      new ScriptGroup("REF_meatPickup_03" : REF_meatPickup_01) 
      {                                      
         refObjectName = "WAVE_meatRock_03";          
      };
   }; 
   new ScriptGroup("WAVE_meatSpawn_04" : WAVE_meatSpawn_01)
   {
      new ScriptGroup("REF_meatPickup_04" : REF_meatPickup_01) 
      {                                      
         refObjectName = "WAVE_meatRock_04";          
      };
   }; 
   new ScriptGroup("WAVE_meatSpawn_05" : WAVE_meatSpawn_01)
   {
      new ScriptGroup("REF_meatPickup_05" : REF_meatPickup_01) 
      {                                      
         refObjectName = "WAVE_meatRock_05";          
      };
   }; 
   
   //attack
   new ScriptGroup("attackWave_uta")
   {
      maxWaves = 4;
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName attackWave_uta 6000";       
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";
      waveTimedCallbacks[1, 1] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_05_A"; 
      new ScriptGroup(REF_attackShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "2"; 
         offset = "1000";  
         factionOverride = "Terran";                     
         refObjectName = "REF_Player";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";   
      };  
      new ScriptGroup(REF_attackShips_02 : REF_attackShips_01)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "1"; 
         offset = "2000";  
      };      
   }; 
   
   new ScriptGroup("WAVE_coolantHarvest_01")
   {    
      maxWaves = 1;
      waveContext[1] = "collectCoolant";
      WaveMissionTrackers["remove", 1] = "0 1 2";
      WaveMissionTrackers["active", 1] = "3 4 5"; 
      waveTimedCallbacks[1, 0] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_05_B"; 
      new ScriptGroup(REF_coolantShipLoc_01 : MO_Trigger) 
      {                                
      }; 
      new ScriptGroup(REF_coolantShipLoc_02 : MO_Trigger) 
      {                                
      };             
      new ScriptGroup(coolantShip_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "1"; 
         factionOverride = "Terran";                  
         refObjectName = "REF_Player";
         offset = "4000"; 
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_dropBox_01 0";  
         mountRefObjectNames = "REF_coolantShipLoc_01";       
      };  
      new ScriptGroup(coolantShip_02 : coolantShip_01)
      { 
         mountRefObjectNames = "REF_coolantShipLoc_02";  
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_dropBox_02 0";                                              
      };  
   };
   
   new ScriptGroup("WAVE_dropBox_01")
   {
      maxWaves = 1;        
      new ScriptGroup(CollectProp_01 : MO_Pickups)
      {  
         offset = "0";                                  
         objectCount = "1";
         refObjectName = "REF_coolantShipLoc_01";    
         objectFuncs["Spawn", 0] = "AddGoToMarker";   
         minDistanceOverride = 0;
         maxDistanceOverride = 0; 
         objectFuncs["Pickup", 0] = "CallInstanceFunc TS_addTrackingTick coolantNeeded -1";
         objectFuncs["Pickup", 1] = "CallInstanceFunc TS_evalTrackingTick coolantNeeded 0 StartWaveName QuestComplete";                                       
      };
   };
   new ScriptGroup("WAVE_dropBox_02")
   {
      maxWaves = 1;        
      new ScriptGroup(CollectProp_01 : MO_Pickups)
      {  
         offset = "0";                                  
         objectCount = "1";
         refObjectName = "REF_coolantShipLoc_02";    
         objectFuncs["Spawn", 0] = "AddGoToMarker";   
         minDistanceOverride = 0;
         maxDistanceOverride = 0;
         objectFuncs["Pickup", 0] = "CallInstanceFunc TS_addTrackingTick coolantNeeded -1";
         objectFuncs["Pickup", 1] = "CallInstanceFunc TS_evalTrackingTick coolantNeeded 0 StartWaveName QuestComplete";                                       
                                     
      };
   };   
   
   new ScriptGroup("WAVE_Pissoff")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "0 callQuestFunction ChangePlayerRelations terran -5"; 
   };   
}; 

//////////////////////////////////////////////////////////
// SIDE MISSION SETUP B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_05B : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1 OBJ_SideMission_05"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_05B"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_05B Dialog_sideMission_05_D";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_05B Dialog_sideMission_05_E";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "MOON BURGER NEEDS \"CHICKEN\"";  
   description = "The popular Moon Burger franchise is having a hard time acquiring material for their meat patties.";
  
   initialWaves = "WAVE_meatShips";
   
   missionText["initial"] = "MT_ATTACK DESTROY ZOMBIE SHIPS FOR MEAT";
   missionText["collect"] = "MT_GOTO COLLECT MEAT NODES";
   missionText["meatCount"] = "MT_INFO MEAT NEEDED:";
   missionText["meatLoad"] = "MT_ATTACK MASSIVE MEAT SOURCE DETECTED";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick meatNeeded 20";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "collect";
   missionTrackerData[2] = "meatCount MT_TICKCOUNTER meatNeeded";    
    
   DeployData["StarType"] = "INNER";        
   SelectionData["SectorProgress"] = "3 4"; 
   SelectionData["InfectionLevel"] = "1 3"; 
   
   Rewards["Complete", "Spec"] = "SS_MoonChicken"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   //spawn props
   new ScriptGroup("WAVE_meatShips")
   {
      maxWaves = 1;  
      WaveMissionTrackers["active", 1] = "0 1 2";
      new ScriptGroup("REF_meatLoc_01" : MO_Trigger) 
      {                                       
      }; 
      new ScriptGroup("REF_meatLoc_02" : MO_Trigger) 
      {                                       
      }; 
      new ScriptGroup("REF_meatLoc_03" : MO_Trigger) 
      {                                       
      }; 
      
      new ScriptGroup("REF_meatShip_01" : MO_Ships) 
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         offset = "5000 6000";  
         factionOverride = "ZombieKiller";  
         objectCount = "1";
         objectFuncs["Spawn", 0] = "AddTargetMarker";   
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_meatSpawn_01 0";
         mountRefObjectNames = "REF_meatLoc_01";        
      };
      new ScriptGroup("REF_meatShip_02" : REF_meatShip_01) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_meatSpawn_02 0";   
         mountRefObjectNames = "REF_meatLoc_02";                                         
      }; 
      new ScriptGroup("REF_meatShip_03" : REF_meatShip_01) 
      {
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_meatSpawn_03 0";
         mountRefObjectNames = "REF_meatLoc_03";                                          
      };
   };   
      
   //meat pickups      
   new ScriptGroup("WAVE_meatSpawn_01")
   {
      maxWaves = 1; 
      new ScriptGroup("REF_meatPickup_01" : MO_pickups) 
      {                                      
         offset = "0 0";                                  
         objectCount = "2";
         refObjectName = "REF_meatLoc_01"; 
         pickupWL = "MissionPickup_MeatNode 10";  
         pickupImpulse = 200;    
         objectFuncs["Spawn", 0] = "AddGoToMarker";       
         objectFuncs["Pickup", 0] = "CallInstanceFunc TS_addTrackingTick meatNeeded -1";
         objectFuncs["Pickup", 1] = "CallInstanceFunc TS_evalTrackingTick meatNeeded 0 StartWaveName QuestComplete"; 
         objectFuncs["Pickup", 2] = "CallInstanceFunc TS_evalTrackingTick meatNeeded 15 StartWaveName WAVE_meatBoss";     
      };
   }; 
   new ScriptGroup("WAVE_meatSpawn_02" : WAVE_meatSpawn_01)
   {
      new ScriptGroup("REF_meatPickup_02" : REF_meatPickup_01) 
      {                                      
         refObjectName = "REF_meatLoc_02";          
      };
   }; 
   new ScriptGroup("WAVE_meatSpawn_03" : WAVE_meatSpawn_01)
   {
      new ScriptGroup("REF_meatPickup_03" : REF_meatPickup_01) 
      {                                      
         refObjectName = "REF_meatLoc_03";          
      };
   }; 
   
   //meat boss
   new ScriptGroup("WAVE_meatBoss")
   {
      maxWaves = 1;  
      waveContext[1] = "meatLoad";
      new ScriptGroup("REF_meatBossLoc_01" : MO_Trigger) 
      {                                       
      }; 
      new ScriptGroup("REF_meatBoss_01" : MO_Ships) 
      {                                      
         instanceObjectWeightedList = "BossShips 10";
         offset = "4000 6000";  
         factionOverride = "ZombieKiller";  
         objectCount = "1";
         objectFuncs["Spawn", 0] = "AddTargetMarker";   
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_bossMeatSpawn 0";
         mountRefObjectNames = "REF_meatBossLoc_01";        
      };
   }; 
   
   //boss meat   
   new ScriptGroup("WAVE_bossMeatSpawn")
   {
      maxWaves = 1;  
      new ScriptGroup("REF_meatBossPickup" : MO_pickups) 
      {                                      
         offset = "0 0";                                  
         objectCount = "14";
         refObjectName = "REF_meatBossLoc_01"; 
         pickupWL = "MissionPickup_MeatNode 10";  
         pickupImpulse = 200;    
         objectFuncs["Spawn", 0] = "AddGoToMarker";       
         objectFuncs["Pickup", 0] = "CallInstanceFunc TS_addTrackingTick meatNeeded -1";
         objectFuncs["Pickup", 1] = "CallInstanceFunc TS_evalTrackingTick meatNeeded 0 StartWaveName QuestComplete";   
      };
   };  
}; 

