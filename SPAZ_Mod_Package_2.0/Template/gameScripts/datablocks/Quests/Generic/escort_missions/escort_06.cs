
///////////////////////////////////////////////////////////
// ESCORT 06A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Escort_06A : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   title = "BODY GUARD"; 
   warningTags = "UTA"; 
   factionRelateReq = "Civ";
   description = "A civilian ship needs an escort through a particularly bad region of space.";
  
   initialWaves = "WAVE_EscortShip MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO RENDEZVOUS WITH THE ESCORT";
   missionText["attackers"] = "MT_DEFEND ESCORT THE SHIP TO SAFETY";
   missionText["distance"] = "MT_INFO DISTANCE TO EXIT";
   missionText["health"] = "MT_INFO ESCORT HEALTH";
   missionText["escortFail"] = "MT_FAIL YOU FAILED TO DEFEND THE ESCORT SHIP";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "attackers";
   missionTrackerData[2] = "distance MT_DISTANCEBAR REF_ShipArea REF_EscortOut_Trig";
   missionTrackerData[3] = "health MT_HEALTHBAR EscortShipSet";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Bounty"] = "Sub_High";
   
   DeployData["LevelRange"]     = "1 10"; //can occur only early
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
          
   new ScriptGroup(WAVE_EscortShip : Escort_WaveBasic)
   { 
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE;
      WaveMissionTrackers["active", 1] = "0";       
      new ScriptGroup("REF_EscortOutProp" : MO_Props) 
      {
         instanceObjectWeightedList = "FakeWarpGate";
         offset = "18000 20000";   
         objectCount = 1;               
         refObjectName = "";  
      };
      new ScriptGroup(REF_ShipArea : MO_Trigger) 
      {                              
      }; 
      new ScriptGroup(REF_EscortPickupTrigger : MO_Trigger)
      {     
         //refObjectName = "REF_EscortShip";         
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Destination";
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet setTriggerActive REF_EscortPickupTrigger 0";  
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_1";                        
      };
      new ScriptGroup(REF_EscortShip : MO_Escort_Ship) 
      {   
         instanceObjectWeightedList = "MediumShips 10";
         mountRefObjectNames = "REF_ShipArea REF_EscortPickupTrigger"; 
         hullBitMatching = $SST_HULL_INF; 
         refAngleData = "REF_Beacon REF_EscortOutProp 0 2000"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 escortFail";                                  
      }; 
   };
   
   new ScriptGroup(WAVE_Destination)
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand EscortShipSet MoveTo REF_EscortOutProp 0";
      
      WaveMissionTrackers["remove", 1] = "0";   
      WaveMissionTrackers["active", 1] = "1 2 3";     
      
      new ScriptGroup("REF_EscortOut_Trig" : MO_Escort_DestinationTrig)
      {                                      
      }; 
      new ScriptGroup("REF_CampTrigger" : MO_Trigger)
      {    
         triggerRadius = 4000; 
         triggerFuncs[0] = "InstanceFunc 1 EscortShipSet StartWaveName WAVE_exitCamper";   
         refObjectName = "REF_EscortOut_Trig";                                  
      }; 
   };
    
   new ScriptGroup(WAVE_1)
   {
      maxWaves = 10;        
      waveContext[1] = "attackers";
      healthCallbackSets = "EscortAttackerSet"; 
      setHealthCallback["All", "EscortAttackerSet", 0] = "0 StartWaveName WAVE_1 12000";
      new ScriptGroup(escortAttackShips_1 : MO_Ships)
      {      
         offset = "4000 5000";  
         factionOverride = "Terran";                     
         refObjectName = "REF_ShipArea";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet EscortAttackerSet";  
         onInitializedFunc[0] = "AddToHealthCallbackSet EscortAttackerSet";                                
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "Scaled 2 3";
      };              
   };
   
   new ScriptGroup(WAVE_exitCamper)
   {
      maxWaves = 1;        
      new ScriptGroup(warpoutCampers : MO_Ships)
      {    
         objectFuncs["Spawn", 0]   = "QAI_AddToSet EscortAttackerSet";                                    
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1 1"; 
         factionOverride = "Terran";                         
         offset = "500 750";  
         refObjectName = "REF_EscortOut_Trig";    
      };               
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {         
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                             
      }; 
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {                  
      }; 
   };
};

///////////////////////////////////////////////////////////
// ESCORT 06B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Escort_06B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   title = "CROSSING GUARD"; 
   warningTags = "CIV"; 
   factionRelateReq = "Terran"; 
   description = "A UTA ship is trying to pickup a supply drop, but civilian raiders have set up an ambush.  The UTA ship needs backup.";
  
   initialWaves = "WAVE_escortsetup WAVE_FollowShip MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO RENDEZVOUS WITH THE ESCORT";
   missionText["escort"] = "MT_GOTO BRING ESCORT TO ITS CARGO";
   missionText["escortFail"] = "MT_FAIL YOU FAILED TO DEFEND THE ESCORT SHIP";
   missionText["distance"] = "MT_INFO DISTANCE TO CARGO";
   missionText["health"] = "MT_INFO ESCORT HEALTH";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Terran"]    = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Civ"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "escort";
   missionTrackerData[2] = "health MT_HEALTHBAR EscortShipSet";
   
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   
   DeployData["LevelRange"]     = "1 10"; //can occur only early
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
         offset = "17000 18000";  
         refObjectName = "REF_Beacon";
         objectCount = "1 1";  
         pickupFaction = "terran"; 
         objectFuncs["Pickup", 0] = "evalTrackingSetCount pickupSet 0 StartWaveName WAVE_CollectComplete";  
         new ScriptGroup(REF_pickup_getMeTrigger1 : MO_Trigger)
         {    
            triggerRadius = 800; 
            triggerFuncs[0] = "InstanceFunc 1 EscortShipSet QAI_SetAICommand EscortShipSet SetTactic TP_Stance TP_Defensive"; //this allows the ship to pick up the thing when near by
            triggerFuncs[1] = "InstanceFunc 0 EscortShipSet QAI_SetAICommand EscortShipSet SetTactic TP_Stance TP_Escorted";                           
         };          
      };          
   };
          
   new ScriptGroup("WAVE_FollowShip" : Escort_WaveBasic)
   { 
      maxWaves = 1; 
      WaveMissionTrackers["active", 1] = "0";  
      new ScriptGroup(REF_ShipArea : MO_Trigger) 
      {                              
      };      
      new ScriptGroup(REF_EscortPickupTrigger : MO_Trigger)
      {           
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Destination";
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet setTriggerActive REF_EscortPickupTrigger 0";  
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_1";                           
      };
      new ScriptGroup(REF_EscortShip : MO_Follower_Ship) 
      {   
         instanceObjectWeightedList = "MediumShips 10";
         factionOverride = "terran"; 
         refObjectName = "REF_Beacon"; 
         offset = "2500 2600"; 
         mountRefObjectNames = "REF_ShipArea REF_EscortPickupTrigger"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 escortFail";                              
      }; 
   };
   new ScriptGroup("WAVE_Destination")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_pickupProp1 AddGoToMarker";
      
      WaveMissionTrackers["remove", 1] = "0";   
      WaveMissionTrackers["active", 1] = "1 2"; 
      
      waveContext[1] = "escort";    
   };
   
   new ScriptGroup("WAVE_CollectComplete")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "CallInstanceFunc callOnSubObjects REF_EscortShip QAI_AddToSet EscortWarpOutSet";   
   };
   
   new ScriptGroup("WAVE_1")
   {
      maxWaves = 10;  
      healthCallbackSets = "EscortAttackerSet"; 
      setHealthCallback["All", "EscortAttackerSet", 0] = "0 StartWaveName WAVE_1 12000";      
      new ScriptGroup(escortAttackShips_1 : MO_ships)
      {    
         offset = "3200 3200";                    
         refObjectName = "REF_ShipArea";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet EscortAttackerSet";  
         onInitializedFunc[0] = "AddToHealthCallbackSet EscortAttackerSet";
         factionOverride = "civ";                                
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "Scaled 2 3";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
      };              
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















