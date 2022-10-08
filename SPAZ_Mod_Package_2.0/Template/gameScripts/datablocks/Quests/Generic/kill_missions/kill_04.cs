
///////////////////////////////////////////////////////////
// KILL 04 
///////////////////////////////////////////////////////////


new ScriptGroup(Quest_Kill_04 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   rarity = "VeryCommon"; //meta mission needs to stick around 
   overrideMarker = "objectiveMarker_happyFaceImageMap";
   
   warningTags = "UTA SECUP";
    
   title = "FIGHT THE POWER";  
   description = "Take out a UTA fleet to allow the Civilians to regain some control of the system.";
   initialWaves = "WAVE_uta_1 MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY UTA TARGETS";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //mission can happen any time
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   
   missionTrackerData[0] = "initial";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Down;
   Rewards["Complete", "Infrastructure"] = 1;
   Rewards["Complete", "Bounty"] = "low";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_uta_1")
   {
      maxWaves = 5;        
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName WAVE_uta_1 0";
      
      WaveMissionTrackers["active", 1] = "0"; 
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy"; 
      waveTimedCallbacks[5, 0] = "0 callQuestFunction Basic_AddTrackingSetCondition finalWave missionTargets";  
      
      new ScriptGroup(UTA_ships_1 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 20 AverageShips 5";
         offset = "4000 8000";  
         objectCount = "Scaled 1 2";
         factionOverride = "Terran"; 
         refObjectName = "REF_Beacon";                
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";   
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet"; 
         objectFuncs["Spawn", 2] = "addToTrackingSet missionTargets";
         objectFuncs["Death", 0] = "evalTrackingSetCountCondition finalWave missionTargets 0 StartWaveName QuestComplete";       
      };       
      new ScriptGroup(UTA_ships_2 : UTA_ships_1)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         offset = "2500 3000";   
         objectCount = "1";       
      };
      //add more enemies
      new ScriptGroup(Kill_CMADD : UTA_ships_1)
      {  
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1";  
         SelectionData["SecLevelRange"] = "2 3";                             
      };                 
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   //stuff that came with the mission area
   //don't spawn mission target faction or it feels like a bug
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {
      new ScriptGroup(CivHelpGroup : MADD_Civ_Help)
      {                           
      };       
   };
};  