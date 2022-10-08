
///////////////////////////////////////////////////////////
// ESCORT 05
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Escort_05 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   title = "DROPPED SOMETHING?"; 
   factionRelateReq = "Civ"; 
   description = "A civilian ship has accidentally jettisoned its cargo in a mine field.  Help the ship find it.";
  
   initialWaves = "WAVE_escortsetup WAVE_FollowShip MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO RENDEZVOUS WITH THE ESCORT";
   missionText["escort"] = "MT_GOTO BRING ESCORT TO ITS CARGO";
   missionText["escortFail"] = "MT_FAIL YOU FAILED TO DEFEND THE ESCORT SHIP";
   missionText["distance"] = "MT_INFO DISTANCE TO CARGO";
   missionText["health"] = "MT_INFO ESCORT HEALTH";
   missionText["remaining"] = "MT_INFO REMAINING CARGO:";
   missionText["mineHint"] = "MT_HINT BEWARE OF MINES";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "escort";
   missionTrackerData[2] = "mineHint";
   missionTrackerData[3] = "remaining MT_SETCOUNTER PickupSet";
   missionTrackerData[4] = "health MT_HEALTHBAR EscortShipSet";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Bounty"] = "Sub_High";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   new ScriptGroup("WAVE_escortsetup")
   {
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE;
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand EscortShipSet MoveTo REF_Player 0";     
      new ScriptGroup("REF_pickupProp1" : MO_CollectProp)
      {    
         offset = "7000 8000";  
         refObjectName = "REF_Beacon";
         objectCount = "1 1";  
         pickupFaction = "Civ"; 
         objectFuncs["Pickup", 0] = "evalTrackingSetCount pickupSet 0 StartWaveName WAVE_CollectComplete";
         new ScriptGroup(UTAMines_01 : MO_Mines) 
         {   
            offset = 0;                                     
            objectCount = "1"; 
            factionOverride = "terran";
            refObjectName = "";
            minDistanceOverride = 50;
            maxDistanceOverride = 100; 
            instanceObjectWeightedList = "RegenSwarmMineField_large 10";
         };
         new ScriptGroup(Barrels_01 : MO_Props) 
         {    
            instanceObjectWeightedList = "SpaceProp_ExplodingBarrels 10";                                
            objectCount = "14 16";
            offset = 0;  
            refObjectName = ""; 
         };
         new ScriptGroup(REF_pickup_getMeTrigger1 : MO_Trigger)
         {    
            triggerRadius = 800; 
            triggerFuncs[0] = "InstanceFunc 1 EscortShipSet QAI_SetAICommand EscortShipSet SetTactic TP_Stance TP_Passive"; //this allows the ship to pick up the thing when near by
            triggerFuncs[1] = "InstanceFunc 0 EscortShipSet QAI_SetAICommand EscortShipSet SetTactic TP_Stance TP_Escorted";                           
         };                  
      };      
      //set 2    
      new ScriptGroup("REF_pickupProp2" : REF_pickupProp1)
      {  
         new ScriptGroup(UTAMines_02 : UTAMines_01) 
         {                                 
         };
         new ScriptGroup(Barrels_02 : Barrels_01) 
         {   
         }; 
         new ScriptGroup(REF_pickup_getMeTrigger2 : REF_pickup_getMeTrigger1)
         {    
         };             
      };      
      //set 3    
      new ScriptGroup("REF_pickupProp3" : REF_pickupProp1)
      {  
         new ScriptGroup(UTAMines_03 : UTAMines_01) 
         {                                 
         };
         new ScriptGroup(Barrels_03 : Barrels_01) 
         {   
         };
         new ScriptGroup(REF_pickup_getMeTrigger3 : REF_pickup_getMeTrigger1)
         {    
         };                 
      }; 
      // set 4  
      new ScriptGroup("REF_pickupProp4" : REF_pickupProp1)
      {  
         new ScriptGroup(UTAMines_04 : UTAMines_01) 
         {                                 
         };
         new ScriptGroup(Barrels_04 : Barrels_01) 
         {   
         }; 
         new ScriptGroup(REF_pickup_getMeTrigger4 : REF_pickup_getMeTrigger1)
         {    
         };                
      };     
   };
          
   new ScriptGroup("WAVE_FollowShip" : Escort_WaveBasic)
   { 
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE;
      WaveMissionTrackers["active", 1] = "0";    
      new ScriptGroup(REF_EscortPickupTrigger : MO_Trigger)
      {           
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Destination";
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_respawnAttacker";
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet setTriggerActive REF_EscortPickupTrigger 0";                                 
      };
      new ScriptGroup(REF_EscortShip : MO_Follower_Ship) 
      {   
         instanceObjectWeightedList = "AverageShips 10";
         refObjectName = "REF_Beacon"; 
         offset = "2500 2600"; 
         mountRefObjectNames = "REF_EscortPickupTrigger"; 
         hullBitMatching = $SST_HULL_INF; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 escortFail";                                  
      }; 
   };
   
   new ScriptGroup("WAVE_respawnAttacker")
   {
      maxWaves = 15;  //lots, but not forever      
      healthCallbackSets = "EscortAttackerSet"; 
      setHealthCallback["All", "EscortAttackerSet", 0] = "0 StartWaveName WAVE_respawnAttacker 10000";
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";   
      new ScriptGroup(escortAttackShips_1 : MO_Ships)
      {     
         offset = "4500 5500";  
         factionOverride = "Terran";                     
         refObjectName = "REF_EscortPickupTrigger";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet SeekAndDestroySet";  
         onInitializedFunc[0] = "AddToHealthCallbackSet EscortAttackerSet";                                 
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1 2"; //keep random
      };              
   };
   
   new ScriptGroup("WAVE_Destination")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_pickupProp1 AddGoToMarker";
      waveTimedCallbacks[1, 1] = "0 callOnSubObjects REF_pickupProp2 AddGoToMarker";
      waveTimedCallbacks[1, 2] = "0 callOnSubObjects REF_pickupProp3 AddGoToMarker";
      waveTimedCallbacks[1, 3] = "0 callOnSubObjects REF_pickupProp4 AddGoToMarker";
      
      WaveMissionTrackers["remove", 1] = "0";   
      WaveMissionTrackers["active", 1] = "1 2 3 4"; 
      
      waveContext[1] = "escort";    
   };
   
   new ScriptGroup("WAVE_CollectComplete")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "CallInstanceFunc callOnSubObjects REF_EscortShip QAI_AddToSet EscortWarpOutSet";   
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {  
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                          
      };  
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                             
      };    
   };
};