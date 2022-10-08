

///////////////////////////////////////////////////////////
// KILL 06 A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_06A : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA";
       
   title = "UTA PATROL";  
   description = "Eliminate the UTA patrol to win over the Civilian faction in this system.";
  
   initialWaves = "WAVE_1";
   
   missionText["initial"] = "MT_ATTACK DESTROY UTA TARGETS";
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //this mission can happen in any state
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;
   
   missionTrackerData[0] = "initial";   
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Down;
   Rewards["Complete", "Bounty"] = "low";
   
   //rarity        = "Uncommon"; 
   DeployData["LevelRange"]     = "1 10"; //can occur only early
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_1")
   {    
      maxWaves = 3;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_1 2000";
      setHealthCallback[3, "enemy", 0] = "0 StartWaveName WAVE_2"; 
      WaveMissionTrackers["active", 1] = "0";                 
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "Scaled 2 3"; 
         factionOverride = "Terran";                         
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         offset = "1000 2000";      
      };            
   };
   
   new ScriptGroup("WAVE_2")
   {    
      maxWaves = 1;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName QuestComplete";    
      new ScriptGroup(KillShips_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "1 1"; 
         factionOverride = "Terran";                         
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         offset = "1000 2000";      
      };            
   };
}; 

///////////////////////////////////////////////////////////
// KILL 06 B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_06B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV";
       
   title = "CIVILIAN PATROL";  
   description = "Eliminate the Civilian patrol to win over the UTA faction in this system.";
  
   initialWaves = "WAVE_1";
   
   missionText["initial"] = "MT_ATTACK DESTROY CIVILIAN TARGETS";
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //this mission can happen in any state
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;
   
   missionTrackerData[0] = "initial";   
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Down;
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   
   //rarity        = "Uncommon"; 
   DeployData["LevelRange"]     = "1 10"; //can occur only early
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_1")
   {    
      maxWaves = 3;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_1 2000";
      setHealthCallback[3, "enemy", 0] = "0 StartWaveName WAVE_2 0";  
      WaveMissionTrackers["active", 1] = "0";        
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "Scaled 2 3"; 
         factionOverride = "Civ";                           
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         offset = "1000 2000"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;        
      };            
   };
   
   new ScriptGroup("WAVE_2")
   {    
      maxWaves = 1;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName QuestComplete";     
      new ScriptGroup(KillShips_02 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "1 1"; 
         factionOverride = "Civ";                           
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         offset = "1000 2000"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;        
      };            
   };
}; 
