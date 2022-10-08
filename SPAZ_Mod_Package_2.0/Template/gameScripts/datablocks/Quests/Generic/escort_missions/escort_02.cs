
///////////////////////////////////////////////////////////
// ESCORT 02
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Escort_02 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   title = "UTA EXTRACTION";  
   warningTags = "CIV";
   factionRelateReq = "Terran";
   description = "The UTA are abandoning an outpost and are outsourcing to mercenaries to guard their convoys.  Civilian raiding parties are now trying to take advantage of the situation.";
  
   initialWaves = "WAVE_EscortSetup WAVE_escortAttack_campers MADD_WAVE";
   
   
   initialTimedCallbacks[0] = "0 TS_addTrackingTick shipsLost 2";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick shipsNeeded 3";
   initialTimedCallbacks[2] = "1000 StartWaveName WAVE_PickupShip";
   
   missionText["pickup"] = "MT_GOTO PICKUP A CONVOY AT UTA STATION";
   missionText["dropoff"] = "MT_DEFEND DEFEND THE SHIP FROM ATTACKERS";
   missionText["distance"] = "MT_INFO DISTANCE TO EXIT";
   missionText["health"] = "MT_INFO ESCORT HEALTH";
   
   missionText["remaining"] = "MT_INFO RESCUE QUOTA";
   missionText["acceptLost"] = "MT_INFO ACCEPTABLE LOSSES";
   
   missionText["stationFail"] = "MT_FAIL THE STATION WAS DESTROYED";
   missionText["escortFail"] = "MT_FAIL TOO MANY CONVOY SHIPS LOST";
   
   //initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND; 
   
   missionTrackerData[0] = "pickup";
   missionTrackerData[1] = "dropoff";
   missionTrackerData[2] = "distance MT_DISTANCEBAR REF_ShipArea REF_DropOffTrigger";
   missionTrackerData[3] = "health MT_HEALTHBAR EscortShipSet"; 
   missionTrackerData[4] = "remaining MT_TICKCOUNTER shipsNeeded";
   missionTrackerData[5] = "acceptLost MT_TICKCOUNTER shipsLost";
   
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   Rewards["Complete", "Resource"] = "high"; //mission is hard, so lets give them lots
   Rewards["Complete", "Goons"] = "med";
   Rewards["Complete", "Bounty"] = "low";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
          
   new ScriptGroup(WAVE_EscortSetup: Escort_WaveBasic)
   { 
      WaveMissionTrackers["active", 1] = "4 5"; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE;
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
         factionOverride = "Terran"; 
         shipDesignWL = "OutpostBase 10 Pirate01Base 5 Pirate02Base 2";
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
         factionOverride = "Terran";
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
         objectCount = "Scaled 1 2";
         factionOverride = "civ"; 
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
         objectCount = "1";
         factionOverride = "civ"; 
         refObjectName = "REF_DropOffTrigger";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet EscortAttackerSet";                       
      };                    
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   //stuff that came with the mission area
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {
      new ScriptGroup(CivHelpGroup : MADD_Civ_Help)
      {                           
      }; 
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                             
      };        
   };
};
