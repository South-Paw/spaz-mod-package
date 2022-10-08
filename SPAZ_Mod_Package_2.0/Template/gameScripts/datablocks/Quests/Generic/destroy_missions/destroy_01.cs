
///////////////////////////////////////////////////////////
// DESTROY 01 (destroy cloaked props)
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_01 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "SECUP";
       
   title = "LOST UTA SUPPLY";  
   description = "The UTA have hidden some valuable supply crates under a cloak field.  Any old scanner should be able to locate them.  The UTA will not like people looting their supplies.";
  
   initialWaves = "WAVE_Crates attackWave MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY HIDDEN UTA CRATES";
   missionText["remaining"] = "MT_INFO REMAINING CRATES:";
      
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;
   
   //RLBRLB add big cash payout
   Rewards["Complete", "Relations_Terran"] = $RelChange_Down;  
   Rewards["Complete", "Bounty"] = "low";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER targetCrates";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   DeployData["LevelRange"]     = "20 70"; //a bit too hard for noobs
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_Crates")
   {
      maxWaves = 1; 
      healthCallbackSets = "Cargo";
      setHealthCallback["All", "Cargo", 0] = "0 StartWaveName QuestComplete";
      WaveMissionTrackers["active", 1] = "0 1"; 
      new ScriptGroup(UTA_crates_01 : MO_Props) 
      {     
         offset = "3000 4000";                                 
         instanceObjectWeightedList = "SpaceProp_UTASupply_cloaked";
         objectCount = "4 4";
         onInitializedFunc[0] = "AddToHealthCallbackSet Cargo";
         
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet targetCrates"; 
         
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName PickupPissoff"; 
         objectFuncs["Death", 1] = "CallInstanceFunc StartWaveName attackWave 4000";  
         
         factionOverride = "Terran";  //so that cloak hunter srms can find them        
      };  
      new ScriptGroup(UTA_crates_02 : UTA_crates_01) 
      {     
         offset = "5000 6000";                                        
      }; 
      new ScriptGroup(UTA_crates_03 : UTA_crates_01) 
      {     
         offset = "7000 8000";                                        
      };          
   };
         
   new ScriptGroup("attackWave")
   {
      maxWaves = -1;        
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand UTA_attacker SetTactic TP_Stance TP_SeekAndDestroy"; 
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10 AverageShips 3";
         objectCount = "Scaled 1 3"; 
         offset = "4000 5000";  
         factionOverride = "Terran";                     
         refObjectName = "REF_Player";
         respectShipCount = 4; 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet UTA_attacker"; 
      };  
      //add more enemies
      new ScriptGroup(Kill_CMADD : KillShips_01)
      {  
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1 1";  
         SelectionData["SecLevelRange"] = "2 3";                              
      };        
   };
   
   new ScriptGroup("PickupPissoff")
   {
      maxWaves = -1; 
      waveTimedCallbacks["All", 0] = "1500 callQuestFunction ChangePlayerRelations terran -1";
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
