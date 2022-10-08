
///////////////////////////////////////////////////////////
// KILL 03
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_03 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   rarity = "VeryCommon"; //meta mission needs to stick around 
   overrideMarker = "objectiveMarker_happyFaceImageMap";
   
   warningTags = "CIV INFUP";
       
   title = "CIVILIAN RESISTANCE";  
   description = "Some civilians have setup a blockade near a registered supply warp gate.  The UTA needs it to be cleared so they can resume operations.";
  
   initialWaves = "WAVE_1 MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY CIVILIAN TARGETS";
   missionText["boss"] = "MT_ATTACK CIVILIAN FLAGSHIP INBOUND";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //mission can happen any time
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;
   
   missionTrackerData[0] = "initial";
   
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   Rewards["Complete", "Relations_Civ"] = $RelChange_Down;
   Rewards["Complete", "Security"]         = 1;
   Rewards["Complete", "Bounty"] = "low"; 
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4   
   DeployData["LevelRange"]     = "10 70"; //a bit too hard for noobs
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_1")
   {
      maxWaves = 2;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName WAVE_1 0";
      setHealthCallback[2, "enemy", 0] = "1 StartWaveName WAVE_2 0"; 
      
      WaveMissionTrackers["active", 1] = "0"; 
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";                   

      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "Scaled 3 4"; 
         offset = "4000 7000"; 
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet"; 
         objectFuncs["Spawn", 2] = "addToTrackingSet missionTargets";
         objectFuncs["Death", 0] = "evalTrackingSetCountCondition bossIsDead missionTargets 0 StartWaveName QuestComplete";   
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;        
      };
      //add more enemies
      new ScriptGroup(Kill_CMADD : KillShips_01)
      {  
         objectCount = "1 1"; 
         SelectionData["InfraLevelRange"]     = "2 3";                            
      };              
   };
   
   new ScriptGroup("WAVE_2")
   {
      maxWaves = 3;        
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName WAVE_2 0";
      setHealthCallback[3, "enemy", 0] = "1 StartWaveName WAVE_BOSS 0";
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";        

      new ScriptGroup(KillShips_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "Scaled 1 3"; 
         offset = "5000 8000"; 
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon";
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";   
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet"; 
         objectFuncs["Spawn", 2] = "addToTrackingSet missionTargets";
         objectFuncs["Death", 0] = "evalTrackingSetCountCondition bossIsDead missionTargets 0 StartWaveName QuestComplete";   
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;          
      };   
      //add more enemies
      new ScriptGroup(Kill_CMADD : KillShips_02)
      {  
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1 1";   
         SelectionData["InfraLevelRange"]     = "2 3";                           
      };      
   };
   
   new ScriptGroup("WAVE_BOSS")
   {
      maxWaves = 1;        
      waveContext[1] = "boss"; 
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";     

      new ScriptGroup(KillShips_03 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips";
         objectCount = "1 1"; 
         offset = "8000 10000"; 
         factionOverride = "Civ";                     
         refObjectName = "REF_Beacon"; 
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet"; 
         objectFuncs["Spawn", 2] = "addToTrackingSet missionTargets";
         
         objectFuncs["Death", 0] = "addTrackingSetCondition bossIsDead missionTargets";
         objectFuncs["Death", 1] = "evalTrackingSetCountCondition bossIsDead missionTargets 0 StartWaveName QuestComplete";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;             
      };       
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   //stuff that came with the mission area
   //don't spawn mission target faction or it feels like a bug
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                             
      };        
   };
}; 