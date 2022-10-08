
///////////////////////////////////////////////////////////
// ESCORT 04 A (do not rename to A or players will have broken missions)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Escort_04 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   title = "CIVILIAN SURVIVORS";  
   description = "Civilian ships are attempting to flee the system with refugees.  They are currently under attack by infected ships.";
     
   initialWaves = "WAVE_EscortSetup WAVE_escortAttack_campers WAVE_escortAttack_respawn MADD_WAVE";
   
   initialTimedCallbacks[0] = "0 TS_addTrackingTick shipsLost 2";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick shipsNeeded 4";
   initialTimedCallbacks[2] = "1000 StartWaveName WAVE_PickupShip";
   
   missionText["pickup"] = "MT_GOTO PICKUP A CONVOY AT STATION";
   missionText["dropoff"] = "MT_DEFEND DEFEND THE SHIP FROM ZOMBIES";
   missionText["distance"] = "MT_INFO DISTANCE TO EXIT";
   missionText["health"] = "MT_INFO ESCORT HEALTH";
   
   missionText["remaining"] = "MT_INFO RESCUE QUOTA";
   missionText["acceptLost"] = "MT_INFO ACCEPTABLE LOSSES";
   
   missionText["stationFail"] = "MT_FAIL THE STATION WAS DESTROYED";
   missionText["escortFail"] = "MT_FAIL TOO MANY CONVOY SHIPS LOST";
   
   missionTrackerData[0] = "pickup";
   missionTrackerData[1] = "dropoff";
   missionTrackerData[2] = "distance MT_DISTANCEBAR REF_ShipArea REF_DropOffTrigger";
   missionTrackerData[3] = "health MT_HEALTHBAR EscortShipSet"; 
   missionTrackerData[4] = "remaining MT_TICKCOUNTER shipsNeeded";
   missionTrackerData[5] = "acceptLost MT_TICKCOUNTER shipsLost";
   
   DeployData["StarType"] = "INNER";
   SelectionData["SectorProgress"] = "4 4"; //sec 4 spicific
   SelectionData["InfectionLevel"] = "1 3";
   
   Rewards["Complete", "Infrastructure"] = 1;
   Rewards["Complete", "Goons"] = "high";
   Rewards["Complete", "Bounty"] = "Sub_High";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
          
   new ScriptGroup(WAVE_EscortSetup: Escort_WaveBasic)
   { 
      WaveMissionTrackers["active", 1] = "4 5"; 
      new ScriptGroup("REF_EscortOutProp" : MO_Props) 
      {
         instanceObjectWeightedList = "FakeWarpGate";
         offset = "8000 8000";   
         objectCount = 1;               
         refObjectName = "";
         new ScriptGroup("REF_DropOffTrigger" : MO_Escort_DestinationTrig) 
         {   
            triggerFuncs[1] = "InstanceFunc 1 EscortShipSet setTriggerActive REF_DropOffTrigger 0";
            objectFuncs["Spawn", 0] = ""; //don't mark                   
         };  
      };
      
      new ScriptGroup("REF_Pickup_Station" : MO_Ships) 
      {   
         instanceObjectWeightedList = "SpawnMyShip";
         offset = 0;  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         shipDesignWL = "Pirate02Base 10 Pirate03Base 5";
         refObjectName = "";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 stationFail";   
         new ScriptGroup("REF_Pickup_Trigger" : MO_Trigger) 
         {   
            triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_DropOffShip 0";  
            oneCallPerPing = true; //don't eval 2 ships within             
         };                       
      };
   };
   
   new ScriptGroup(WAVE_PickupShip)
   {
      maxWaves = -1; 
      waveContext[-1] = "pickup";
      
      WaveMissionTrackers["active", -1] = "0"; 
      WaveMissionTrackers["remove", -1] = "1 2 3";   

      waveTimedCallbacks["All", 0] = "0 setTriggerActive REF_Pickup_Trigger 1";
      waveTimedCallbacks["All", 1] = "0 setTriggerActive REF_DropOffTrigger 0";
      waveTimedCallbacks["All", 2] = "0 callOnSubObjects REF_Pickup_Station AddGoToMarker";
      waveTimedCallbacks["All", 3] = "0 callOnSubObjects REF_EscortOutProp RemoveObjectiveMarker_ALL";  
   };
   
   new ScriptGroup(WAVE_DropOffShip)
   {
      maxWaves = -1; 
      waveContext[-1] = "dropOff";
         
      WaveMissionTrackers["active", -1] = "1 2 3"; 
      WaveMissionTrackers["remove", -1] = "0";   

      waveTimedCallbacks["All", 0] = "0 setTriggerActive REF_Pickup_Trigger 0";
      waveTimedCallbacks["All", 1] = "0 setTriggerActive REF_DropOffTrigger 1";
      waveTimedCallbacks["All", 2] = "0 callOnSubObjects REF_Pickup_Station RemoveObjectiveMarker_ALL";
      waveTimedCallbacks["All", 3] = "0 callOnSubObjects REF_EscortOutProp AddGoToMarker";
      waveTimedCallbacks["All", 4] = "0 startWaveName WAVE_escortAttack_dropIn 4000";
      waveTimedCallbacks["All", 5] = "0 QAI_SetAICommand EscortShipSet MoveTo REF_EscortOutProp 0";   
      
      new ScriptGroup(REF_ShipArea : MO_Trigger) 
      {                                
      }; 
      
      new ScriptGroup(REF_EscortShip : MO_Escort_Ship) 
      {   
         factionOverride = "Civ";
         refObjectName = "REF_Pickup_Station"; 
          
         objectFuncs["WarpOut", 0] = "evalTrackingSetCount EscortShipSet 0 StartWaveName WAVE_PickupShip 500";  //needs to delay so mission can finish if it needs to         
         objectFuncs["WarpOut", 1] = "CallInstanceFunc TS_addTrackingTick shipsNeeded -1";       
         objectFuncs["WarpOut", 2] = "CallInstanceFunc TS_evalTrackingTick shipsNeeded 0 StartWaveName QuestComplete";    
         
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_PickupShip 500";   
         objectFuncs["Death", 1] = "CallInstanceFunc TS_addTrackingTick shipslost -1";       
         objectFuncs["Death", 2] = "CallInstanceFunc TS_evalTrackingTick shipslost 0 StartWaveName QuestFail 0 escortFail";    
         
         mountRefObjectNames = "REF_ShipArea";                                
      }; 
   };
   
   new ScriptGroup("WAVE_escortAttack_campers")
   {
      maxWaves = 10; 
      healthCallbackSets = "EscortAttackerSet"; 
      setHealthCallback["All", "EscortAttackerSet", 0] = "0 StartWaveName WAVE_escortAttack_campers 12000";    
      new ScriptGroup(CivAttackShips : MO_Ships)
      {      
         offset = "3200 3200";               
         onInitializedFunc[0] = "AddToHealthCallbackSet EscortAttackerSet";                                         
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "2";
         factionOverride = "zombieKiller"; 
         refObjectName = "REF_DropOffTrigger";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet EscortAttackerSet";                       
      };                    
   };
   
   new ScriptGroup("WAVE_escortAttack_dropIn")
   {
      maxWaves = 10;      
      new ScriptGroup(CivAttackShips : MO_Ships)
      {     
         offset = "3200 3200";                              
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "2";
         factionOverride = "zombieKiller"; 
         refObjectName = "REF_DropOffTrigger";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet EscortAttackerSet"; 
         respectShipCount = 4;                      
      };                    
   };
   
   new ScriptGroup("WAVE_escortAttack_respawn")
   {
      maxWaves = 20;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_escortAttack_respawn 10000";
      new ScriptGroup(escortAttackShips_2 : MO_Ships)
      {   
         offset = "10000 12000";  
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";                                       
         instanceObjectWeightedList = "AverageShips 10"; 
         objectCount = "1";
      };           
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CivHelpGroup : MADD_Civ_Ped)
      { 
      }; 
      new ScriptGroup(CivUTAGroup : MADD_UTA_Ped)
      {                       
      }; 
   };
};


///////////////////////////////////////////////////////////
// ESCORT 04B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Escort_04B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   title = "LOST PUPPIES";  
   description = "Several ships are currently stranded amongst the zombie horde.  They need to be located and escorted back to safety before they are exterminated by infected ships.";
     
   initialWaves = "WAVE_EscortPuppies WAVE_DropStation MADD_WAVE";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick shipsLost 2";
   initialTimedCallbacks[2] = "0 TS_addTrackingTick shipsNeeded 3";
   initialTimedCallbacks[3] = "10000 StartWaveName WAVE_firstAttack"; 
   initialTimedCallbacks[4] = "18000 StartWaveName WAVE_secondAttack"; 
   
   missionText["initial"] = "MT_GOTO RESCUE LOST SHIPS";
   missionText["dropoff"] = "MT_DEFEND KEEP BASE ALIVE";
   missionText["remaining"] = "MT_INFO RESCUE QUOTA";
   missionText["acceptLost"] = "MT_INFO ACCEPTABLE LOSSES";
   
   missionText["stationFail"] = "MT_FAIL THE STATION WAS DESTROYED";
   missionText["escortFail"] = "MT_FAIL TOO MANY SHIPS LOST";
   missionText["escortAggro"] = "MT_GOTO BRING SHIPS BACK TO THE STATION";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "dropoff";
   missionTrackerData[2] = "remaining MT_TICKCOUNTER shipsNeeded";
   missionTrackerData[3] = "acceptLost MT_TICKCOUNTER shipsLost";
   
   DeployData["StarType"] = "INNER";
   SelectionData["SectorProgress"] = "4 4"; //sec 4 spicific
   SelectionData["InfectionLevel"] = "1 3";
   
   Rewards["Complete", "Goons"] = "high";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
                
   new ScriptGroup("WAVE_EscortPuppies")
   { 
      maxWaves = 1; 
      WaveMissionTrackers["active", 1] = "0 1 2 3";  
      waveTimedCallbacks["all", 0] = "0 QAI_SetAICommand puppyFollowSet MoveTo REF_Player 0"; 
      waveTimedCallbacks["all", 1] = "0 QAI_SetAICommand puppyFollowSet SetTactic TP_Stance TP_Escorted"; 
      //ship 1
      new ScriptGroup(REF_PuppyTrigger_1 : MO_Trigger)
      {     
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet callOnSubObjects REF_PuppyShip_1 leashToPlayer 1000"; 
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet callOnSubObjects REF_PuppyShip_1 QAI_AddToSet puppyFollowSet"; 
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet setTriggerActive REF_PuppyTrigger_1 0"; 
         triggerFuncs[3] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_EscortContext 0";                            
      };
      new ScriptGroup(REF_PuppyShip_1 : MO_Ships) 
      {   
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1"; 
         refObjectName = "REF_Beacon"; 
         offset = "5000 7000"; 
         mountRefObjectNames = "REF_PuppyTrigger_1"; 
         hullBitMatching = $SST_HULL_INF;
         
         objectFuncs["Spawn", 0]   = "QAI_AddToSet puppyStaySet";  
         objectFuncs["Spawn", 1] = "AddGoToMarker"; 
         
         objectFuncs["WarpOut", 0] = "CallInstanceFunc TS_addTrackingTick shipsNeeded -1";       
         objectFuncs["WarpOut", 1] = "CallInstanceFunc TS_evalTrackingTick shipsNeeded 0 StartWaveName QuestComplete";    
         
         objectFuncs["Death", 0] = "CallInstanceFunc TS_addTrackingTick shipslost -1";       
         objectFuncs["Death", 1] = "CallInstanceFunc TS_evalTrackingTick shipslost 0 StartWaveName QuestFail 0 escortFail";                                   
      }; 
      //ship 2
      new ScriptGroup(REF_PuppyTrigger_2 : REF_PuppyTrigger_1)
      {     
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet callOnSubObjects REF_PuppyShip_2 leashToPlayer 1000"; 
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet callOnSubObjects REF_PuppyShip_2 QAI_AddToSet puppyFollowSet"; 
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet setTriggerActive REF_PuppyTrigger_2 0";
         triggerFuncs[3] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_EscortContext 0";                                   
      };
      new ScriptGroup(REF_PuppyShip_2 : REF_PuppyShip_1) 
      {   
         mountRefObjectNames = "REF_PuppyTrigger_2";                                  
      }; 
      //ship 3
      new ScriptGroup(REF_PuppyTrigger_3 : REF_PuppyTrigger_1)
      {     
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet callOnSubObjects REF_PuppyShip_3 leashToPlayer 1000"; 
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet callOnSubObjects REF_PuppyShip_3 QAI_AddToSet puppyFollowSet"; 
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet setTriggerActive REF_PuppyTrigger_3 0";   
         triggerFuncs[3] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_EscortContext 0";                                      
      };
      new ScriptGroup(REF_PuppyShip_3 : REF_PuppyShip_1) 
      {   
         mountRefObjectNames = "REF_PuppyTrigger_3";                                  
      }; 
      //ship 4
      new ScriptGroup(REF_PuppyTrigger_4 : REF_PuppyTrigger_1)
      {     
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet callOnSubObjects REF_PuppyShip_4 leashToPlayer 1000"; 
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet callOnSubObjects REF_PuppyShip_4 QAI_AddToSet puppyFollowSet"; 
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet setTriggerActive REF_PuppyTrigger_4 0";  
         triggerFuncs[3] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_EscortContext 0";                                       
      };
      new ScriptGroup(REF_PuppyShip_4 : REF_PuppyShip_1) 
      {   
         mountRefObjectNames = "REF_PuppyTrigger_4";                                  
      }; 
   };
   
   new ScriptGroup("WAVE_EscortContext")
   { 
      maxWaves = -1; 
      waveContext[-1] = "escortAggro";
   };
   
   new ScriptGroup("WAVE_DropStation")
   { 
      maxWaves = 1; 
      waveTimedCallbacks["all", 0] = "0 QAI_SetAICommand PuppyWarpSet SetTactic TP_Retreat TP_RetreatOn"; 
      new ScriptGroup("DropStation" : MO_Ships) 
      {   
         instanceObjectWeightedList = "SpawnMyShip";
         refObjectName = "REF_Beacon"; 
         offset = 1400;  
         objectCount = "1 1";
         factionOverride = "Civ"; 
         shipDesignWL = "Pirate02Base 10 Pirate03Base 5";
         objectFuncs["Spawn", 0] = "AddDefendMarker";    
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 stationFail";   
         new ScriptGroup("REF_Pickup_Trigger" : MO_Trigger) 
         {   
            triggerFuncs[0] = "ObjectFunc 1 puppyFollowSet QAI_AddToSet PuppyWarpSet";   
            triggerRadius = 700;                    
         };                       
      };
   };
   
   new ScriptGroup("WAVE_firstAttack")
   { 
      maxWaves = 20; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName WAVE_firstAttack 6000"; 
      new ScriptGroup("ZomAttackers_01" : MO_Ships) 
      {   
         instanceObjectWeightedList = "LightShips";
         refObjectName = "REF_Player"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
         offset = 750;  
         objectCount = "1";
         factionOverride = "ZombieKiller";                     
      };
   };
   
   new ScriptGroup("WAVE_secondAttack")
   { 
      maxWaves = 10; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName WAVE_secondAttack 12000"; 
      new ScriptGroup("ZomAttackers_02" : MO_Ships) 
      {   
         instanceObjectWeightedList = "AverageShips";
         refObjectName = "REF_Player";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
         offset = 2000;  
         objectCount = "1";
         factionOverride = "ZombieKiller";                     
      };
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CivHelpGroup : MADD_Civ_Ped)
      { 
      }; 
      new ScriptGroup(CivUTAGroup : MADD_UTA_Ped)
      {                       
      }; 
   };
};


