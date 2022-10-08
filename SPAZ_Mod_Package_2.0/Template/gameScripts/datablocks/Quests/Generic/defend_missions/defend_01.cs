
///////////////////////////////////////////////////////////
// DEFEND 01A
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Defend_01A : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "SECUP";
   
   title = "ARTIFACT DISCOVERY";  
   description = "A civilian patrol has discovered strange alien artifacts.  The UTA wants to cleanse these forbidden objects, while the civilians need them for their trade value.";
   
   initialWaves = "WAVE_DefendProps MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO GO TO ARTIFACT FIELD";
   missionText["defend"] = "MT_DEFEND DEFEND THE ARTIFACTS";
   missionText["killShips"] = "MT_ATTACK DESTROY ATTACKERS";
   missionText["remaining"] = "MT_INFO REMAINING ARTIFACTS:";
   missionText["failReason"] = "MT_FAIL You failed to defend the artifacts";
   
   initialTimedCallbacks[0] = "3000 callQuestFunctionOnInstance MissionCallout initial";
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE; 
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "defend";
   missionTrackerData[2] = "killShips";
   missionTrackerData[3] = "remaining MT_SETCOUNTER defendPropSet";
   
   Rewards["Complete", "Resource"] = "High";
   Rewards["Complete", "Relations_Civ"] = $RelChange_Up;
   Rewards["Complete", "Infrastructure"]   = 1; 
   Rewards["Complete", "Goons"] = "med";
   Rewards["Complete", "Bounty"] = "Sub_High";
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_DefendProps : Defend_WaveBasic)
   {
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;   
      WaveMissionTrackers["active", 1] = "0";        
      new ScriptGroup("REF_DefendCluster" : MO_Defend_Prop) 
      {
         instanceObjectWeightedList = "SpaceProp_Artifacts";
         objectCount = "6 6";           
         factionOverride = "Civ";   
         new ScriptGroup(REF_CrateTrigger : MO_Trigger)
         {                                      
            triggerRadius = 1500;
            triggerFuncs[0] = "InstanceFunc 1 PlayerSet StartWaveName WAVE_DefendAttackers_1";
            triggerFuncs[1] = "InstanceFunc 1 PlayerSet setTriggerActive REF_CrateTrigger 0";
         };           
      };
   };
        
   new ScriptGroup(WAVE_DefendAttackers_1)
   {
      maxWaves = 4;        
      waveContext[1] = "defend";
      
      WaveMissionTrackers["active", 1] = "1 2 3"; 
      WaveMissionTrackers["remove", 1] = "0"; 
   
      healthCallbackSets = "Defend_AttackerSet";
      setHealthCallback["All", "Defend_AttackerSet", 0] = "0 StartWaveName WAVE_DefendAttackers_1 5000";
      setHealthCallback[4, "Defend_AttackerSet", 0] = "0 StartWaveName QuestComplete"; 
      
      new ScriptGroup(defendAttackerShips_01 : MO_Defend_Attackers)
      {    
         instanceObjectWeightedList = "LightShips 10";                                
         objectCount = "Scaled 1 2";
         factionOverride = "Terran"; 
         shipSpawnHealth = 0.7;  //crippled                     
      }; 
      new ScriptGroup(defendAttackerShips_02 : defendAttackerShips_01)
      {    
         offset = "12000 14000";    
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 2";                                
         objectCount = "Scaled 1 2";                
      }; 
      new ScriptGroup(defend_CMADD : defendAttackerShips_01)
      {  
         instanceObjectWeightedList = "AverageShips 10";                                
         objectCount = "1"; 
         SelectionData["SecLevelRange"]       = "2 3";                       
      };                
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CivHelpGroup : MADD_Civ_Ped)
      {
         refObjectName = "REF_DefendCluster";                         
      }; 
      new ScriptGroup(UTAAmbient : MADD_UTA_Ambient)
      {                             
      };   
   };
}; 


///////////////////////////////////////////////////////////
// DEFEND 01B
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Defend_01B : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV";
   
   title = "EXPLOSIVE SITUATION";  
   description = "This area has been used to stockpile materials to refine ship fuel.  Civilian gangs have seized the stockpile and won't allow anyone to access it.  Destroy the Civilian ships guarding the stock, while not destroying the stockpile itself.";
   
   initialWaves = "WAVE_DefendProps WAVE_StockAttackers_1 MADD_WAVE";
   
   missionText["initial"] = "MT_ATTACK DESTROY ENEMY TARGETS";
   missionText["defendStock"] = "MT_DEFEND DEFEND THE STOCKPILE";
   missionText["remaining"] = "MT_INFO REMAINING STOCK:";
   missionText["failReason"] = "MT_FAIL You failed to defend the stockpile";
   missionText["moreships"] = "MT_ATTACK MORE TARGETS INCOMING";
   
   initialTimedCallbacks[0] = "3000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "defendStock";
   missionTrackerData[2] = "remaining MT_SETCOUNTER defendPropSet";
   
   Rewards["Complete", "Relations_Terran"] = $RelChange_Up;
   
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Terran"]    = $FactionRelation_NEUTRAL SPC $FactionRelation_FRIEND;  
   SelectionData["Relations_Pirate_Civ"] = $FactionRelation_HATE SPC $FactionRelation_DISLIKE; 
   
   DeployData["StarType"] = "OUTTER"; //mission gets a bit easy after a while, so keep in rim
   DeployData["LevelRange"]     = "10 40"; //can occur only early
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_DefendProps : Defend_WaveBasic)
   {
      waveRelations[1, 0] = "Civ Terran" SPC $FactionRelation_HATE;   
      WaveMissionTrackers["active", 1] = "0 1 2";        
      new ScriptGroup("REF_DefendCluster" : MO_Defend_Prop) 
      {
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels";
         objectCount = "10 10";                     
      };
   };
        
   new ScriptGroup(WAVE_StockAttackers_1)
   {
      maxWaves = 1;        
      healthCallbackSets = "stockAttackers";
      setHealthCallback["All", "stockAttackers", 0] = "0 StartWaveName WAVE_StockAttackers_2";
      new ScriptGroup(attackerShips_01 : MO_Ships)
      {    
         instanceObjectWeightedList = "BossShips 10";                                
         objectCount = "1";
         factionOverride = "Civ"; 
         offset = "0 0"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet stockAttackers";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         refObjectName = "REF_DefendCluster"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                   
      };
      new ScriptGroup(attackerShips_03 : attackerShips_01)
      {    
         instanceObjectWeightedList = "LightShips 10";                                
         objectCount = "scaled 1 2";                
      };                   
   };
   
   new ScriptGroup(WAVE_StockAttackers_2)
   {
      waveContext[1] = "moreships";
      maxWaves = 1;        
      healthCallbackSets = "stockAttackers";
      setHealthCallback["All", "stockAttackers", 0] = "0 StartWaveName QuestComplete";
      new ScriptGroup(attackerShips_04 : MO_Ships)
      {    
         instanceObjectWeightedList = "AverageShips 10";                                
         objectCount = "scaled 2 3";
         factionOverride = "Civ"; 
         offset = "0 0"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet stockAttackers";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
         refObjectName = "REF_DefendCluster"; 
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;                   
      };                  
   };
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      //no madd .. heavy combat can make a mess of things
   };
}; 