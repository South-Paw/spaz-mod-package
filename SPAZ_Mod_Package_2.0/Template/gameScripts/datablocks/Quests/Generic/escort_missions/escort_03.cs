
///////////////////////////////////////////////////////////
// ESCORT 03
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Escort_03 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA SECUP";
   
   title = "INTERCEPT WARSHIP";  
   description = "A UTA warship is about to pass through the area.  If it can be destroyed before it moves on, the Civilians can regain some control over the system.";
  
   initialWaves = "WAVE_EscortShip WAVE_defenders MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE FLEEING WARSHIP";
   missionText["distance"] = "MT_INFO ESCAPE RANGE";
   missionText["escapeFail"] = "MT_FAIL The warship escaped";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_FRIEND SPC $FactionRelation_NEUTRAL;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_NEUTRAL SPC $FactionRelation_HATE; 
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "distance MT_DISTANCEBAR REF_ShipArea REF_EscortOut_Trig";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Down;
   Rewards["Complete", "Infrastructure"] = 1;
   Rewards["Complete", "Bounty"] = "Sub_High";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   DeployData["LevelRange"]     = "15 70"; //a bit too hard for noobs
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
          
   new ScriptGroup(WAVE_EscortShip : Escort_WaveBasic)
   { 
      maxWaves = 1; 
      waveRelations[1, 0] = "Terran Civ" SPC $FactionRelation_HATE; 
      //next available is 4
      waveTimedCallbacks[1, 4] = "0 QAI_SetAICommand EscortShipSet MoveTo REF_EscortOutProp 0";
      WaveMissionTrackers["active", 1] = "0 1";  
      new ScriptGroup("REF_EscortOutProp" : MO_Props) 
      {
         instanceObjectWeightedList = "FakeWarpGate";
         offset = "20000 20000";   
         objectCount = 1;               
         refObjectName = "";
      };
      new ScriptGroup(REF_ShipArea : MO_Trigger) 
      {                              
      }; 
      new ScriptGroup("REF_EscortOut_Trig" : MO_Escort_DestinationTrig)
      { 
         objectFuncs["Spawn", 0] = "";   //don't mark this time                                   
      };  
      new ScriptGroup(REF_EscortShip : MO_Ships) 
      {   
         objectCount = "1 1"; 
         mountRefObjectNames = "REF_ShipArea"; 
         refAngleData = "REF_Beacon REF_EscortOutProp 0 2000"; 
         
         instanceObjectWeightedList = "BossShips 10";
         factionOverride = "Terran";  
         
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Spawn", 1] = "QAI_AddToSet EscortShipSet"; 
         objectFuncs["Spawn", 2] = "addToTrackingSet EscortShipSet";  
          
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestComplete";  
         objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName questFail 0 escapeFail";                                
      };
   };
   
   new ScriptGroup(WAVE_defenders)
   {
      maxWaves = -1;        
      healthCallbackSets = "WarshipDefenders"; 
      setHealthCallback["All", "WarshipDefenders", 0] = "0 StartWaveName WAVE_defenders 4000";
      waveTimedCallbacks["All", 0] = "0 QAI_SetAICommand WarshipDefenders SetTactic TP_Stance TP_SeekAndDestroy";  
      waveTimedCallbacks["All", 1] = "0 QAI_SetAICommand WarshipDefenders MoveTo REF_ShipArea 0";   
      new ScriptGroup(escortAttackShips_1 : MO_Ships)
      {    
         offset = "3200 3200";  
         factionOverride = "Terran";                     
         refObjectName = "REF_ShipArea";
         objectFuncs["Spawn", 0]   = "QAI_AddToSet WarshipDefenders";  
         onInitializedFunc[0] = "AddToHealthCallbackSet WarshipDefenders";                                
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 2 4";
      };
      //add more enemies
      new ScriptGroup(escort_CMADD : escortAttackShips_1)
      {  
         instanceObjectWeightedList = "LightShips 10"; 
         objectCount = "1";  
         SelectionData["SecLevelRange"] = "1 2";                      
      };                
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
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
















