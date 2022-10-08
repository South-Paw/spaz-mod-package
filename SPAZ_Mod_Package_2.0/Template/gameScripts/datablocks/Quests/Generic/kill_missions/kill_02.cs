
///////////////////////////////////////////////////////////
// KILL 02
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_02 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   rarity = "VeryCommon"; //meta mission needs to stick around 
   overrideMarker = "objectiveMarker_happyFaceImageMap";
   
   warningTags = "CIV";
    
   title = "ESTABLISH DOMINANCE";  
   description = "Take out a few Civilian ships to lower morale long enough for the UTA to establish more control over the system.";
   initialWaves = "WAVE_civ_1 MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY CIVILIAN TARGETS";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //mission can happen any time
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   
   missionTrackerData[0] = "initial";
   
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   Rewards["Complete", "Relations_Civ"] = $RelChange_Down;
   Rewards["Complete", "Security"] = 1;
   Rewards["Complete", "Goons"] = "low";
   Rewards["Complete", "Bounty"] = "low";
   
   DeployData["LevelRange"]     = "6 70"; //a bit too hard for noobs
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
 
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_civ_1")
   {
      maxWaves = 4;        
      
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName WAVE_civ_1 0";
      
      WaveMissionTrackers["active", 1] = "0";
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand Civ_attackers SetTactic TP_Stance TP_SeekAndDestroy"; 
      waveTimedCallbacks[4, 0] = "0 callQuestFunction Basic_AddTrackingSetCondition finalWave missionTargets";          
      
      new ScriptGroup(CIV_ships_1 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         offset = "5000 7000";  
         objectCount = "Scaled 1 3";
         factionOverride = "Civ"; 
         refObjectName = "REF_Beacon";                
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "QAI_AddToSet Civ_attackers";
         objectFuncs["Spawn", 2] = "addToTrackingSet missionTargets";
         objectFuncs["Death", 0] = "evalTrackingSetCountCondition finalWave missionTargets 0 StartWaveName QuestComplete";               
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS; 
      };       
      new ScriptGroup(CIV_ships_2 : CIV_ships_1)
      {                                      
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 3";
         offset = "8000 10000";  
         objectCount = "1 1";
      };              
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   //stuff that came with the mission area
   //don't spawn mission target faction or it feels like a bug
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {
      new ScriptGroup(UTAHelpGroup : MADD_UTA_Help)
      {                           
      };      
   };
}; 