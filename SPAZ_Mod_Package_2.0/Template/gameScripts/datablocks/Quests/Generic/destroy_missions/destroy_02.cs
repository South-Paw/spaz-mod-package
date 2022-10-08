
///////////////////////////////////////////////////////////
// DESTROY 02 (destroy mines)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_02 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "INFUP";
       
   title = "MINE SWEEP";  
   description = "The Civs have hidden some minefields in the area.  The UTA need them cleared.  Having a cloak scanner is recommended.";
  
   initialWaves = "WAVE_Mines MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE HIDDEN MINES";
   missionText["remaining"] = "MT_INFO REMAINING MINES:";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_DISLIKE;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND; 
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER targetMines";
   
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   Rewards["Complete", "Relations_Civ"] = $RelChange_Down;
   Rewards["Complete", "Security"]         = 1; 
   Rewards["Complete", "Goons"] = "low";
   Rewards["Complete", "Bounty"] = "low";
   
   DeployData["LevelRange"]     = "20 70"; //a bit too hard for noobs
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_Mines")
   {
      maxWaves = 1; 
      healthCallbackSets = "Mines";
      setHealthCallback["All", "Mines", 0] = "0 StartWaveName QuestComplete";
      WaveMissionTrackers["active", 1] = "0 1"; 
      
      new ScriptGroup(CivMines_01 : MO_Mines) 
      {    
         offset = "2000 3000";                                    
         objectCount = "1";
         onInitializedFunc[0] = "AddToHealthCallbackSet Mines";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet targetMines"; 
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName PickupPissoff";  
         objectFuncs["Death", 1] = "CallInstanceFunc StartWaveName attackWave 4000"; 
         factionOverride = "Civ";
         refObjectName = "REF_Beacon"; 
      };   
      new ScriptGroup(CivMines_02 : CivMines_01) 
      { 
         offset = "3000 4000";                                       
      };   
      new ScriptGroup(CivMines_03 : CivMines_01) 
      { 
         offset = "4000 6000";                                       
      };
      new ScriptGroup(CivMines_04 : CivMines_01) 
      { 
         offset = "6000 7000";                                       
      };         
   };
   
   new ScriptGroup("attackWave")
   {
      maxWaves = -1;        
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand Civ_attacker SetTactic TP_Stance TP_SeekAndDestroy"; 
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10 AverageShips 5";
         objectCount = "Scaled 1 3"; 
         offset = "4000 5000";  
         factionOverride = "Civ";                     
         refObjectName = "REF_Player";
         respectShipCount = 4; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet Civ_attacker"; 
      }; 
      new ScriptGroup(KillShips_CMADD : KillShips_01)
      {  
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1 1";  
         SelectionData["InfraLevelRange"]     = "2 3";                         
      };        
   };
   
   new ScriptGroup("PickupPissoff")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations civ -1";
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































