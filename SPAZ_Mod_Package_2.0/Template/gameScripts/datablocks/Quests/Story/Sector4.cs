

new ScriptGroup(Sec3To4CloakedWarpGate : QuestBase)
{   
   addToDatabase    = true;  //Important 
   allowAmbientHunters = false;
   
   rarity        = "Story"; 
   maxCompletes  = 1;
   expiryTurns = -1;
   
   quietFinish = true; //dont mess up the scripted event
   
   title = "THE FINAL CROSSING";  
   description = "Destroy the cloak generators keeping the final gate hidden.  Once they are destroyed, travel through to the galactic core.";
   initialWaves = "WAVE_CloakGens";
   
   Rewards["Complete", "Resource"] = "Exact 2000";
   Rewards["Complete", "Data"] = "Exact 175";
   
   initialTimedCallbacks[0] = "6500 callQuestFunctionOnInstance MissionCallout initial";
     
   DeployData["InstanceName"]   = "SECRET WARPGATE";
   DeployData["InstanceType"]   = "Any"; //important that is not "random"
   
   SelectionData["ObjectivesComplete"]  = "UberScienceFavor";
   
   Callbacks["Complete"] = "S3_gateDisplay_ScriptEvent"; 
   Callbacks["BeaconArrival"] = "S3_gateAriveDialog";
   
   missionText["initial"] = "MT_ATTACK DESTROY CLOAK GENERATORS";
   missionText["remaining"] = "MT_INFO REMAINING GENERATORS:";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER CloakGens";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_CloakGens")
   {
      maxWaves = 1; 
      healthCallbackSets = "CloakGens";
      setHealthCallback["All", "CloakGens", 0] = "0 StartWaveName QuestEnding 1500";
      WaveMissionTrackers["active", 1] = "0 1"; 
      
      waveRelations[1, 0] = "Terran Zombie" SPC $FactionRelation_DISLIKE;   //so they attack player more then eachother    
      
      new ScriptGroup(UTA_cloakGen_01 : MO_Props) 
      {    
         offset = "2000 7000";                                  
         instanceObjectWeightedList = "CloakGenerator";
         objectCount = "1 1";
         onInitializedFunc[0] = "AddToHealthCallbackSet CloakGens";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet CloakGens";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_utaAttack 2000"; 
         factionOverride = "terran"; //so that hunter srm's can find them
         new ScriptGroup(UTAMines_01 : MO_Mines) 
         {         
            offset = 0;                             
            objectCount = "1"; 
            factionOverride = "terran";
            refObjectName = ""; 
            instanceObjectWeightedList = "ScannerSwarmMineField";
         };             
      };
      new ScriptGroup(UTA_cloakGen_02 : UTA_cloakGen_01) 
      {
         new ScriptGroup(UTAMines_02 : UTAMines_01) 
         {         
         };            
      };
      //some gens start zom attacks    
      new ScriptGroup(UTA_cloakGen_plusZom_01 : UTA_cloakGen_01) 
      {  
         objectFuncs["Death", 1] = "CallInstanceFunc StartWaveName WAVE_zomAttack 12000"; 
      };  
      new ScriptGroup(UTA_cloakGen_plusZom_02 : UTA_cloakGen_plusZom_01) 
      {     
      };  
      new ScriptGroup(UTA_cloakGen_plusZom_03 : UTA_cloakGen_plusZom_01) 
      {    
      }; 
      new ScriptGroup(UTA_cloakGen_plusZom_04 : UTA_cloakGen_plusZom_01) 
      {      
      };                    
   };
   
   new ScriptGroup("WAVE_utaAttack")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations terran -1"; 
      waveTimedCallbacks[1, 0] = "1000 callQuestFunction SEQ_activateSequence Sector3CloakedGate_destroyed"; 
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand UTA_attacker SetTactic TP_Stance TP_SeekAndDestroy"; 
      new ScriptGroup(UTA_ships_1 : MO_Ships)
      {     
          creationChance = 1;                                
          instanceObjectWeightedList = "HeavyShips 10 BossShips 6";
          offset = "3000 4500";  
          objectCount = "1";
          factionOverride = "Terran"; 
          refObjectName = "REF_Player"; 
          respectShipCount = 3;    
          objectFuncs["Spawn", 0]   = "QAI_AddToSet UTA_attacker";                 
      };                  
      new ScriptGroup(UTA_ships_2 : UTA_ships_1)
      {                                
          instanceObjectWeightedList = "LightShips 5 AverageShips 10";   
          objectCount = "1 2";           
      };                    
   };
   
   new ScriptGroup("WAVE_zomAttack")
   {
      maxWaves = -1; 
      waveTimedCallbacks[1, 0] = "1000 callQuestFunction SEQ_activateSequence Sector3CloakedGate_zoms"; 
      new ScriptGroup(ZOM_ships_1 : MO_Ships)
      {     
          creationChance = 1;                                
          instanceObjectWeightedList = "HeavyShips 10";
          offset = "1500 2000";  
          objectCount = "1";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Player"; 
          respectShipCount = 3;                  
      }; 
      new ScriptGroup(ZOM_ships_2 : ZOM_ships_1)
      {                                   
          instanceObjectWeightedList = "LightShips 10";               
      };                                   
   };
   
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 

DW("Sector4");
new ScriptGroup(Sec4SpidersWebInfection : QuestBase)
{   
   addToDatabase    = true;  //Important 
   allowAmbientHunters = false;
   
   rarity        = "Story"; //Not zombie we are using trickery to place it here.
   maxCompletes  = 1;
   expiryTurns = -1;
   
   ignoreWarnings = true;
   
   title = "THE SPIDER'S WEB";  
   description = "The system is heavily infected, and the warp gates are offline.  Destroy the infected nest to resume star travel.";
   initialWaves = "WAVE_zombie_setup";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
     
   DeployData["InstanceName"]   = "SPECIAL"; //Grabbing manually.
   DeployData["InstanceType"]   = "Any"; //important that is not "random"
   
   Callbacks["Complete"] = "S4WebCleared";   

   Callbacks["BeaconArrival"] = "S4WebArrival";
   
   //Knock out infection on complete. 
   Rewards["Complete", "Infection"]        = -3;
   Rewards["Complete", "Resource"] = "Exact 2250";
   Rewards["Complete", "Data"] = "Exact 180";
   
   missionText["initial"] = "MT_ATTACK DESTROY ZOMBIE NEST";
   missionText["health"] = "MT_INFO HIVE HEALTH";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "health MT_HEALTHBAR zombieNestSet"; 
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      
      healthCallbackSets = "zombieNestSet"; 
      setHealthCallback["All", "zombieNestSet", 0] = "0 StartWaveName QuestEnding 8500";
      
      WaveMissionTrackers["active", 1] = "0 1"; 
       
      new ScriptGroup(Zom_spiderBase : MO_Ships)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         shipDesignWL = "HeartZombieStation 10";
         objectCount = "1 1"; 
         offset = "4000 5000"; 
         factionOverride = "Zombie";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet zombieNestSet";   
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         objectFuncs["Spawn", 1] = "addToTrackingSet zombieNestSet";         
      };  
      new ScriptGroup(Zom_ships_1 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "HeavyShips 10";
          offset = "300 600";  
          objectCount = "1";
          factionOverride = "zombieKiller"; 
          refObjectName = "Zom_spiderBase";              
      }; 
      new ScriptGroup(Zom_ships_2 : Zom_ships_1)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";
          factionOverride = "zombie";        
      };                     
   };
   
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 


if ( IDG_CODE() )
   schedule(50, 0, quit); 


//This is a hold out over time usng mothership, but no civ fleet to help
//THe civ fleet is held in reserve as not to alarm the zombie overlord
//Once gate opens, they warp in and everyone goes thru to kick booty
//Can explain lack of giant fleet as not to attract too much attention or the zombie horde

new ScriptGroup(AlienGateCrasher : QuestBase)
{   
   addToDatabase    = true;  //Important 
   allowAmbientHunters = false;
   
   warningTags = "CRIT";
   
   rarity        = "Story"; //Not zombie we are using trickery to place it here.
   maxCompletes  = 1;
   expiryTurns   = -1;
   
   gameOverOnFail = true;
   quietFinish = true; //dont mess up the scripted event
    
   title = "GATE CRASHER";  
   description = "Hold out long enough for Carl to open the alien warp gate.";
   initialWaves = "WAVE_gateGenerators";
   
   Rewards["Complete", "Resource"] = "Exact 7500";
   Rewards["Complete", "Data"] = "Exact 185";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 callQuestFunctionOnInstance S4_AlienGate_SetPower";
   initialTimedCallbacks[2] = "8000 StartWaveName WAVE_firePowerPulse";
   initialTimedCallbacks[3] = "40000 StartWaveName WAVE_zombieAttackWave";
   initialTimedCallbacks[4] = "42000 StartWaveName WAVE_zombieAttackWave_light";
   initialTimedCallbacks[5] = "48000 StartWaveName WAVE_zombieAttackWave_heavy";
     
   DeployData["InstanceName"]   = "Alien Gate"; 
   DeployData["InstanceType"]   = "Any"; 
   
   SelectionData["ObjectivesComplete"]  = "AlienGateCrasher_Setup";
   
   Callbacks["Complete"] = "S4_AlienGateOpened";   
   Callbacks["BeaconArrival"] = "S4_AlienGateArrival";
   
   missionText["initial"] = "MT_DEFEND DEFEND THE POWER GENERATORS";
   missionText["gatePower"] = "MT_INFO GATE POWER";
   missionText["remaining"] = "MT_INFO REMAINING GENERATORS:";
   missionText["gensLost"] = "MT_FAIL You failed to defend the generators";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "gatePower MT_METER_EVAL S4_AlienGate_EvalPowerUp";
   missionTrackerData[2] = "remaining MT_SETCOUNTER GateGens";
     
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_gateGenerators")
   {
      maxWaves = 1; 
      WaveMissionTrackers["active", 1] = "0 1 2";   
      new ScriptGroup(UTA_powerGen_01 : MO_Props) 
      {    
         offset = "0 0";                                  
         instanceObjectWeightedList = "S4_GateGens";
         objectCount = "1 1";
         objectFuncs["Spawn", 0]   = "AddDefendMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet GateGens";
         objectFuncs["Spawn", 2]   = "QAI_AddToSet GateDefendSet"; 
         objectFuncs["Death", 0] = "evalTrackingSetCount GateGens 0 StartWaveName QuestFail 0 gensLost"; 
         factionOverride = "pirate";
         refObjectName = "REF_InstanceFocus";
         refAngleData = "REF_InstanceFocus REF_Beacon 0 5000"; //startpos, endpos, angle, distance.  (starttpos/endpos gives a line to reference the angle with)           
      };
      
      new ScriptGroup(UTA_powerGen_02 : UTA_powerGen_01) 
      {    
         refAngleData = "REF_InstanceFocus REF_Beacon 90 5000"; //startpos, endpos, angle, distance.  (starttpos/endpos gives a line to reference the angle with)           
      };
      new ScriptGroup(UTA_powerGen_03 : UTA_powerGen_01) 
      {    
         refAngleData = "REF_InstanceFocus REF_Beacon 180 5000"; //startpos, endpos, angle, distance.  (starttpos/endpos gives a line to reference the angle with)            
      };  
      new ScriptGroup(UTA_powerGen_04 : UTA_powerGen_01) 
      {    
         refAngleData = "REF_InstanceFocus REF_Beacon -90 5000"; //startpos, endpos, angle, distance.  (starttpos/endpos gives a line to reference the angle with)         
      };                                    
   };
   
   new ScriptGroup("WAVE_firePowerPulse")
   {
      maxWaves = -1;   
      waveTimedCallbacks["All", 0] = "0 startWaveName WAVE_firePowerPulse 9000";  
      waveTimedCallbacks["All", 1] = "0 callQuestFunction S4_AlienGate_FirePowerPulse";                       
   };

   new ScriptGroup("WAVE_zombieAttackWave")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "0 startWaveName WAVE_zombieAttackWave 15000";  //call again and again until you win or die     
      new ScriptGroup(Zom_ships_tiny : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 4 LightShips 10";
          offset = "0 0";  
          objectCount = "1";
          factionOverride = "zombie"; 
          refObjectName = "REF_InstanceFocus";
          respectShipCount = 5;                      
      };                    
   };
   
   new ScriptGroup("WAVE_zombieAttackWave_light")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "0 startWaveName WAVE_zombieAttackWave_light 25000";  //call again and again until you win or die
      waveTimedCallbacks["All", 1] = "0 QAI_SetAICommand AlienAttackSet Attack GateDefendSet";           
      new ScriptGroup(Zom_ships_01 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10";
          offset = "0 0";  
          objectCount = "1";
          factionOverride = "zombieKiller"; 
          refObjectName = "REF_InstanceFocus";
          respectShipCount = 5;  
          objectFuncs["Spawn", 0]   = "QAI_AddToSet AlienAttackSet";                    
      };                    
   };
   
   new ScriptGroup("WAVE_zombieAttackWave_heavy")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "0 startWaveName WAVE_zombieAttackWave_heavy 25000";  //call again and again until you win or die
      waveTimedCallbacks["All", 1] = "0 QAI_SetAICommand AlienAttackSet Attack GateDefendSet";           
      new ScriptGroup(Zom_ships_01 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";
          offset = "0 0";  
          objectCount = "1";
          factionOverride = "zombieKiller"; 
          refObjectName = "REF_InstanceFocus";
          respectShipCount = 5;  
          objectFuncs["Spawn", 0]   = "QAI_AddToSet AlienAttackSet";                    
      };                    
   };
}; 

//This is the final boss fight. it will run with the same code running underneath
//That infection instances use. so you will get procedural reinforcements based on that.
new ScriptGroup(FinalBossFight : QuestBase)
{   
   addToDatabase    = true;  //Important 
   allowAmbientHunters = false;
   
   rarity        = "Story"; //Not zombie we are using trickery to place it here.
   maxCompletes  = 1;
   expiryTurns   = -1;
   
   quietFinish = true; //dont mess up the scripted event
    
   title = "END OF THE LINE";  
   description = "Hidden";
   initialWaves = "WAVE_zombie_setup";
   
   initialTimedCallbacks[0] = "4000 callQuestFunctionOnInstance MissionCallout initial"; //long delay to account for scripted event
   initialTimedCallbacks[1] = "15000 StartWaveName WAVE_zombie_mothershipHarrasser"; 
   initialTimedCallbacks[2] = "16500 StartWaveName WAVE_zombie_mothershipBugger"; 
     
   DeployData["InstanceName"]   = "Boss Fight"; 
   DeployData["InstanceType"]   = "Any"; 
   
   SelectionData["ObjectivesComplete"]  = "AlienGateCrasher";
   
   Callbacks["BeaconArrival"] = "S4_FinalBossArrival"; //Sec4_StartAllyReinforcements inside.
   Callbacks["Complete"] = "S4_FinalBossComplete";  
   
   missionText["initial"] = "MT_ATTACK DESTROY ZOMBIE CLOCKWORK";
   missionText["wavesLeft"] = "MT_INFO nil";
   missionText["respawnTime"] = "MT_INFO nil"; 
   missionText["motherHealth"] = "MT_DEFEND YOUR MOTHERSHIP"; 
   
   missionTrackerData[0] = "initial MT_BOSSMETER"; 
   missionTrackerData[1] = "motherHealth MT_HEALTHBAR NOSET_isMothership";
   missionTrackerData[2] = "wavesLeft MT_EVAL AWG_GetWavesLeftText";
   missionTrackerData[3] = "respawnTime MT_EVAL AWG_GetRespawnTimeText";
          
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_zombie_setup")
   {
      maxWaves = 1;        
      
      healthCallbackSets = "finalBoss"; 
      setHealthCallback["All", "finalBoss", 0] = "0 StartWaveName QuestComplete 0";
      
      WaveMissionTrackers["active", 1] = "0 1 2 3";
       
      new ScriptGroup(REF_FinalBossShip : MO_Ships)
      {                                      
          instanceObjectWeightedList = "SpawnMyShipInstant";
          offset = "5000";  
          objectCount = "1 1";
          factionOverride = "Zombie"; 
          refObjectName = "REF_Beacon";                
          onInitializedFunc[0] = "AddToHealthCallbackSet finalBoss";
          objectFuncs["Spawn", 0] = "AddTargetMarker";
          objectFuncs["Spawn", 1] = "addToTrackingSet finalBoss";
          shipDesignWL = "Zombie_ClockworkStation 10";    
          mountRefObjectNames = "REF_FinalBossShip";
      };                    
   };
   
   new ScriptGroup("WAVE_zombie_mothershipHarrasser")
   {
      maxWaves = -1;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zombie_mothershipHarrasser 32000";
      new ScriptGroup(REF_FinalBossShip_01 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "AverageShips 10";
          offset = "6000 7000";  
          objectCount = "1";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Beacon";                
          onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
      };                  
   };
   
   new ScriptGroup("WAVE_zombie_mothershipBugger")
   {
      maxWaves = -1;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zombie_mothershipHarrasser 28000";
      new ScriptGroup(REF_FinalBossShip_02 : MO_Ships)
      {                                      
          instanceObjectWeightedList = "LightShips 10";
          offset = "6000 7000";  
          objectCount = "1";
          factionOverride = "ZombieKiller"; 
          refObjectName = "REF_Beacon";                
          onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
      };                   
   };
}; 



