
///////////////////////////////////////////////////////////
// ESCORT 01
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Escort_01 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   title = "CIVILIAN REFUGEES"; 
   warningTags = "UTA SECUP"; 
   factionRelateReq = "Civ";
   description = "A civilian freighter is attempting to flee the system with refugees.  They are currently under attack from UTA forces.";
  
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
   Rewards["Complete", "Goons"] = "low";
   Rewards["Complete", "Bounty"] = "Sub_High";
   
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
         offset = "16000 16000";   
         objectCount = 1;               
         refObjectName = "";
      };
      new ScriptGroup("REF_ShipArea" : MO_Trigger) 
      {                        
      };   
      new ScriptGroup(REF_EscortPickupTrigger : MO_Trigger)
      {   
         triggerRadius = 1000;        
         triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_Destination 0";
         triggerFuncs[1] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_1 0";
         triggerFuncs[2] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_2 0";
         triggerFuncs[3] = "InstanceFunc 1 PlayerSet setTriggerActive REF_EscortPickupTrigger 0";                                 
      };
      new ScriptGroup(REF_EscortShip : MO_Escort_Ship) 
      {   
         mountRefObjectNames = "REF_ShipArea REF_EscortPickupTrigger"; 
         hullBitMatching = $SST_HULL_INF; 
         refAngleData = "REF_Beacon REF_EscortOutProp 0 2000"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail 0 escortFail";                                  
      }; 
   };
   
   new ScriptGroup(WAVE_Destination)
   {
      maxWaves = 1; 
      WaveMissionTrackers["remove", 1] = "0";   
      WaveMissionTrackers["active", 1] = "1 2 3"; 
      waveTimedCallbacks["all", 0] = "0 QAI_SetAICommand EscortShipSet MoveTo REF_EscortOutProp 0";    
      new ScriptGroup("REF_EscortOut_Trig" : MO_Escort_DestinationTrig)
      {                                      
      }; 
   };
    
   new ScriptGroup(WAVE_1)
   {
      maxWaves = 20;        
      waveContext[1] = "attackers";
      healthCallbackSets = "EscortAttackerSet"; 
      setHealthCallback["All", "EscortAttackerSet", 0] = "0 StartWaveName WAVE_1 6000";
      new ScriptGroup(escortAttackShips_1 : MO_Ships)
      {     
         offset = "4500 5500";  
         factionOverride = "Terran";                     
         refObjectName = "REF_ShipArea";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet EscortAttackerSet";  
         onInitializedFunc[0] = "AddToHealthCallbackSet EscortAttackerSet";                                 
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "Scaled 1 3";
      };
      new ScriptGroup(escort_CMADD : escortAttackShips_1)
      {  
         instanceObjectWeightedList = "LightShips 10"; 
         objectCount = "1";    
         SelectionData["SecLevelRange"]     = "2 3";                    
      };                
   };
   new ScriptGroup(WAVE_2)
   {
      maxWaves = 20;        
      healthCallbackSets = "EscortAttackerSet"; 
      setHealthCallback["All", "EscortAttackerSet", 0] = "0 StartWaveName WAVE_2 10000";
      new ScriptGroup(escortAttackShips_2 : MO_Ships)
      {   
         offset = "5000 6000";  
         factionOverride = "Terran";                     
         refObjectName = "REF_ShipArea";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet EscortAttackerSet";  
         onInitializedFunc[0] = "AddToHealthCallbackSet EscortAttackerSet";                                       
         instanceObjectWeightedList = "AverageShips 10"; 
         objectCount = "1";
      };
      new ScriptGroup(escort_CMADD : escortAttackShips_2)
      {  
         instanceObjectWeightedList = "HeavyShips 10"; 
         objectCount = "1";    
         SelectionData["SecLevelRange"] = "2 3";                   
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
      new ScriptGroup(CivHelpGroup : MADD_Civ_Ped)
      {
         refObjectName = "REF_ShipArea";                     
      }; 
      //this mission needs some hand placed zombies
      new ScriptGroup(ZombieNest : MADD_ZombieNest)
      {   
         offset = "0";  
         refAngleData = "REF_Beacon REF_EscortOutProp 0 8000";  //between ship and destination 
         refObjectName = ""; 
         new ScriptGroup("zombieRocks" : MADD_ZombieRocks) 
         {                                      
         };                            
      };
   };
};
















