

///////////////////////////////////////////////////////////
// KILL 01
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_01 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   rarity = "VeryCommon"; //meta mission needs to stick around 
   overrideMarker = "objectiveMarker_happyFaceImageMap";
   
   warningTags = "UTA SECUP";
       
   title = "UTA ATTACK FLEET";  
   description = "The UTA are wrongfully cleansing outposts in this system.  Any assistance in this matter will be rewarded.  The UTA will not take kindly to any aggression.";
  
   initialWaves = "WAVE_1 MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY UTA TARGETS";
   missionText["boss"] = "MT_ATTACK ASSAULT FLEET INBOUND";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //this mission can happen in any state
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;
   
   missionTrackerData[0] = "initial";   
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Down;
   Rewards["Complete", "Infrastructure"]   = 1; 
   Rewards["Complete", "Goons"] = "low";
   Rewards["Complete", "Bounty"] = "low";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_1")
   {    
      maxWaves = 3;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "1 StartWaveName WAVE_1 0"; 
      setHealthCallback[3, "enemy", 0] = "1 StartWaveName WAVE_2 0"; 
      
      WaveMissionTrackers["active", 1] = "0";   
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";         

      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10 AverageShips 5";
         objectCount = "Scaled 2 4"; 
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         offset = "4000 6500"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";
         objectFuncs["Spawn", 2] = "addToTrackingSet missionTargets";
         objectFuncs["Death", 0] = "evalTrackingSetCountCondition bossIsDead missionTargets 0 StartWaveName QuestComplete";
      };
      //add more enemies
      new ScriptGroup(Kill_CMADD : KillShips_01)
      {  
         instanceObjectWeightedList = "LightShips 10 AverageShips 5";
         objectCount = "1";  
         SelectionData["SecLevelRange"] = "2 3";                              
      };              
   };
   
   new ScriptGroup("WAVE_2")
   {
      maxWaves = 1;        
      waveContext[1] = "boss"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";   

      new ScriptGroup(KillShips_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "1"; 
         factionOverride = "Terran";                     
         refObjectName = "REF_Beacon";
         offset = "6000 8000"; 
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";  
         objectFuncs["Spawn", 2] = "addToTrackingSet missionTargets";

         objectFuncs["Death", 0] = "addTrackingSetCondition bossIsDead missionTargets";
         objectFuncs["Death", 1] = "evalTrackingSetCountCondition bossIsDead missionTargets 0 StartWaveName QuestComplete";         
      };   
      //add more enemies
      new ScriptGroup(Kill_CMADD : KillShips_02)
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
