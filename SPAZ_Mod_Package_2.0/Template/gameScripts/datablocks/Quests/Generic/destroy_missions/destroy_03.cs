
///////////////////////////////////////////////////////////
// DESTROY 03
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Destroy_03 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "TIME";
       
   title = "UNDER THE RUG";  
   description = "The Civilians are trying to dispose of illegal hazardous materials before they are inspected by UTA officials.";
  
   initialWaves = "WAVE_Barrels MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY TOXIC BARRELS";
   missionText["timeout"] = "MT_FAIL YOU COULDN'T DISPOSE OF THE BARRELS IN TIME";
   missionText["remaining"] = "MT_INFO REMAINING BARRELS:";
   missionText["timeLimit"] = "MT_INFO REMAINING TIME:";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "90000 StartWaveName QuestFail 0 timeout"; 
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //can run at any time 
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER toxicBarrels";
   missionTrackerData[2] = "timeLimit MT_TIMERTEXT 90";
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Goons"] = "low";
   Rewards["Complete", "Bounty"] = "low";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup("WAVE_Barrels")
   {
      maxWaves = 1; 
      healthCallbackSets = "Barrels";
      setHealthCallback["All", "Barrels", 0] = "0 StartWaveName QuestComplete";      
      WaveMissionTrackers["active", 1] = "0 1 2"; 
      new ScriptGroup(Barrels_01 : MO_Props) 
      {    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels 10";                                
         objectCount = "Scaled 10 16";
         offset = "3000 3500";  
         onInitializedFunc[0] = "AddToHealthCallbackSet Barrels";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet toxicBarrels";  
         //factionOverride = "Terran"; //makes ai look dumb when they shoot
         refObjectName = "REF_Beacon"; 
      };   
      new ScriptGroup(Barrels_02 : Barrels_01) 
      {   
         offset = "3500 4000";                                     
      };   
      new ScriptGroup(Barrels_03 : Barrels_01) 
      {  
         offset = "4000 4500";                                      
      };  
      new ScriptGroup(Barrels_04 : Barrels_01) 
      {  
         offset = "6000 6500";                                      
      };        
   };
     
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {  
      //lots of extra set dress
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand BarrelDefender SetTactic TP_Stance TP_SeekAndDestroy"; 
      new ScriptGroup(CivBaseAmbient : MADD_Civ_Base)
      {                                   
      };
      new ScriptGroup(UTABaseAmbient : MADD_UTA_Base)
      {                                   
      };
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {  
         objectFuncs["Spawn", 0]   = "QAI_AddToSet BarrelDefender";                          
      };
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      {   
         objectFuncs["Spawn", 0]   = "QAI_AddToSet BarrelDefender";                         
      }; 
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {
         objectFuncs["Spawn", 0]   = "QAI_AddToSet BarrelDefender";  
         SelectionData["InfraLevelRange"]     = "0 3";                          
      };
      new ScriptGroup(CivAmbient : MADD_CIV_Ambient)
      { 
         objectFuncs["Spawn", 0]   = "QAI_AddToSet BarrelDefender";  
         SelectionData["InfraLevelRange"]     = "0 3";                         
      };                                    
   }; 
}; 




























