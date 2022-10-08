
////////////////////////////////////////////////////////////////////////////////
// mining favor 1
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(S1_MiningFavor1 : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Earth";
   DeployData["InstanceName"] = "Saturn";
   
   questType   = "Inf";   //Pick this one up at the star base. 
   
   SelectionData["ObjectivesComplete"]  = ""; //always allowed
   SelectionData["ObjectivesNotComplete"]  = "S1_CompleteFavor1"; //fixes bug with tutorial skipper
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "A MINER PROBLEM";  
   description = "The UTA have been confiscating the cargo from some of our mining ships in an attempt to use it to establish a lookout post in the area.  This is not good for business.  We need to destroy their supplies and force them to restock elsewhere.  It should not be heavily guarded.";

   parentQuest = "";
   childQuests = "S1_MiningFavor2";
   
   Rewards["Complete", "Resource"] = "Exact 75";
  
   Callbacks["Selected"]      = "S1_Favor1Accepted";    
   Callbacks["BeaconArrival"] = "S1_Favor1Started";
   Callbacks["Complete"]      = "S1_Favor1Complete"; //should also introduce Favor 2.  
 
   initialWaves = "CargoField AmbientCivShips";
   
   initialTimedCallbacks[0] = "6500 callQuestFunctionOnInstance MissionCallout initial"; //wait till after presentation schedule
   
   missionText["initial"] = "MT_ATTACK DESTROY UTA STORAGE CRATES";
   missionText["utaShips"] = "MT_ATTACK DESTROY INCOMING UTA SHIPS";
   missionText["remaining"] = "MT_INFO REMAINING CRATES:";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER cargoSet";
   missionTrackerData[2] = "utaShips";
   
   new ScriptGroup("CargoField")
   {
      maxWaves = 1;  
      healthCallbackSets = "Cargo";
      setHealthCallback["All", "Cargo", 0] = "0 callQuestFunction SEQ_activateSequence Dialog_S1_Favor1GoneBad Tutorial_Request CombatTutorial";
      setHealthCallback["All", "Cargo", 1] = "0 StartWaveName CargoPickerGuards";
      
      WaveMissionTrackers["active", 1] = "0 1";
      
      //UTA CREATES
      new ScriptGroup("REF_S1_01") 
      {                                      
         instanceObjectWeightedList = "S1_SpaceProp_UTASupply";
         offset = 0;  
         creationChance = 1;
         objectCount = "8 8";
         onInitializedFunc[0] = "AddToHealthCallbackSet Cargo";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";   
         objectFuncs["Spawn", 1] = "addToTrackingSet cargoSet";       
      };
      new ScriptGroup("S1_subCrates_1" : REF_S1_01) 
      {                                      
         offset = "1200 1800";  
         objectCount = "3 3";
         refObjectName = "REF_S1_01"; 
      };
      new ScriptGroup("S1_subCrates_2" : S1_subCrates_1) 
      {                                      
      };
      new ScriptGroup("S1_subCrates_2" : S1_subCrates_1) 
      {                                      
      };
      
      //SET DRESS CRATES
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "SpaceProp_Crates";
         offset = 0;  
         creationChance = 1;
         objectCount = "6 6";
         refObjectName = "REF_S1_01"; 
      };
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "SpaceProp_Crates_Rich";
         offset = 0;  
         creationChance = 1;
         objectCount = "6 6";
         refObjectName = "REF_S1_01"; 
      };        
   };
  
   new ScriptGroup("CargoPickerGuards")
   {
      maxWaves = 4; //you should fight something easier then you first, so lets spawn some nerfed ships
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName CargoPickerGuards";
      setHealthCallback[4, "Enemies", 0] = "0 StartWaveName QuestEnding 2000";
      waveContext[1] = "utaShips";
      
      WaveMissionTrackers["active", 1] = "2";
      WaveMissionTrackers["remove", 1] = "0 1";   
      
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "500 750";  
          creationChance = 1;  
          objectCount = "1 1";
          factionOverride = "Terran";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
          objectFuncs["Spawn", 0]   = "AddTargetMarker";   
          refObjectName = "REF_S1_01";
          shipDesignWL = "DartShip 10"; 
          shipSpawnHealth = 0.9;  //to knock out shields mostly.
      };      
   };
   new ScriptGroup("AmbientCivShips")
   {
      maxWaves = 8; //make sure you have a good supply of help
      waveRelations[1, 0] = "Civ Pirate" SPC $FactionRelation_FRIEND;
      waveRelations[1, 1] = "Civ Terran" SPC $FactionRelation_HATE;
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand Helpers MoveTo REF_Player 0";
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand Helpers SetTactic TP_Collect TP_NoCollect"; 
      
      healthCallbackSets = "Helpers";
      setHealthCallback["All", "Helpers", 0] = "0 StartWaveName AmbientCivShips";      
      
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "TinyShips 20";
          offset = "100 200";  
          creationChance = 1;  
          objectCount = "2 2";
          factionOverride = "Civ";
          onInitializedFunc[0] = "AddToHealthCallbackSet Helpers";
          refObjectName = "REF_S1_01";   
          hullBitMatching = $SST_HULL_INF;  
          objectFuncs["Spawn", 0] = "QAI_AddToSet Helpers";
      };     
   }; 
   
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 

////////////////////////////////////////////////////////////////////////////////
// mining favor 2
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(S1_MiningFavor2 : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Earth";
   DeployData["InstanceName"] = "Uranus";
   
   //If set to inf, youll have to go to starbase to get this mission.
   questType   = "Event";    
   
   SelectionData["ObjectivesComplete"]  = ""; //Will let parenting handle this.
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "THE BAD SEEDS"; 
   description = "It looks like a handful of workers have been feeding the UTA our supplies in exchange for credits.  Now that those plans are foiled, they are on the run.  These bad seeds need to be taken care of before they find a way to flee the system.";
   
   parentQuest = "S1_MiningFavor1";  //IMPORTANT TO IDENTIFY PARENT!
   childQuests = "S1_MiningFavor3";
   
   Rewards["Complete", "Resource"] = "Exact 100";
  
   Callbacks["Selected"]      = "S1_Favor2Accepted";  //will only fire if questType set to "Inf" 
   Callbacks["Activated"]     = "S1_Favor2Activated"; 
   Callbacks["BeaconArrival"] = "S1_Favor2Started";
   Callbacks["Complete"]      = "S1_Favor2Complete"; //should also introduce Favor 2.  
  
   initialWaves = "BadMiners";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionText["initial"] = "MT_ATTACK DESTROY THE ROGUE MINERS";
   missionText["destroyAll"] = "MT_ATTACK DESTROY ALL HOSTILE TARGETS";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "destroyAll";
   
   new ScriptGroup("BadMiners")
   {
      maxWaves = 2; 
      waveRelations[1, 0] = "Civ Pirate" SPC $FactionRelation_HATE;
      waveRelations[1, 1] = "Civ Terran" SPC $FactionRelation_MYFACTION;
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName BadMiners";
      setHealthCallback[2, "Enemies", 0] = "0 StartWaveName BadMiner_Rangars";
      WaveMissionTrackers["active", 1] = "0";     
      
      new ScriptGroup("Moles") 
      {                                    
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "500 750";  
          creationChance = 1;  
          objectCount = "1 1";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
          objectFuncs["Spawn", 0]   = "AddTargetMarker";
          factionOverride = "Civ";
          refObjectName = "REF_S2_01";
          hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;  
          //shipSpawnHealth = 0.8;  //crippled 
          shipDesignWL = "MoleShip 10";  
      }; 
      new ScriptGroup("moleHelpers" : Moles) 
      {     
         factionOverride = "Civ";                                 
         shipDesignWL = "ShortbusShip 10";  
         objectCount = "0 2";
         shipSpawnHealth = 0.8; //cripple these tho
      };   
   };
   new ScriptGroup("BadMiner_Rangars")
   {
      maxWaves = 1; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName BadMiner_Rangars";
      setHealthCallback[1, "Enemies", 0] = "0 StartWaveName BadMiners_Boss";
      
      WaveMissionTrackers["active", 1] = "1"; 
      WaveMissionTrackers["remove", 1] = "0";   
      
      new ScriptGroup("rangerShip1") 
      {                                      
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "500 750";  
          creationChance = 1;  
          objectCount = "2 2";
          factionOverride = "Terran";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
          refObjectName = "REF_S2_01";
          shipDesignWL = "RangerShip 10";
          shipSpawnHealth = 0.8;  //crippled
          objectFuncs["Spawn", 0]   = "AddTargetMarker"; 
      };     
   };
   new ScriptGroup("BadMiners_Boss")
   {
      maxWaves = 1; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName BadMiners_Boss 2000";
      setHealthCallback[1, "Enemies", 0] = "0 StartWaveName QuestEnding 2000";
      new ScriptGroup("bossShip1") 
      {                                      
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "500 750";  
          creationChance = 1;  
          objectCount = "2 2";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
          objectFuncs["Spawn", 0]   = "AddTargetMarker";
          factionOverride = "Terran";
          refObjectName = "REF_S3_01"; 
          shipDesignWL = "HatchetShip 10";
          shipSpawnHealth = 0.7;  //crippled     
      };        
   };
   
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 

////////////////////////////////////////////////////////////////////////////////
// mining favor 3
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(S1_MiningFavor3 : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Earth";
   DeployData["InstanceName"] = "Neptune";
   
   //If set to inf, youll have to go to starbase to get this mission.
   questType   = "Event";    
   
   SelectionData["ObjectivesComplete"]  = ""; //Will let parenting handle this.
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "THIS IS OUR TOWN!"; 
   description = "It looks like the UTA have come looking for their missing supplies.  We're going to have to send these guys packing just like the rest.  Eventually they'll realize the Sol system isn't worth the lost ships.   This scouting party is quite a bit larger than the last.";

   parentQuest = "S1_MiningFavor2";  //IMPORTANT TO IDENTIFY PARENT!
   childQuests = "";
   
   Rewards["Complete", "Resource"] = "Exact 150";
  
   Callbacks["Selected"]      = "S1_Favor3Accepted";  //will only fire if questType set to "Inf" 
   Callbacks["Activated"]     = "S1_Favor3Activated"; 
   Callbacks["BeaconArrival"] = "S1_Favor3Started";
   Callbacks["Complete"]      = "S1_Favor3Complete"; //should also introduce Favor 2.  
        
   initialWaves = "UTAScouts";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
      
   missionText["initial"] = "MT_ATTACK DESTROY ALL ENEMY SHIPS";
   missionText["largeShip"] = "MT_ATTACK UTA ASSAULT SHIP INBOUND";
   
   missionTrackerData[0] = "initial";
   
   new ScriptGroup("UTAScouts")
   {
      maxWaves = 3; 
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName UTAScouts";
      setHealthCallback[3, "Enemies", 0] = "0 StartWaveName UTABoss";
      
      WaveMissionTrackers["active", 1] = "0";
      
      new ScriptGroup("utaAttack1") 
      {                                      
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "500 750";  
          creationChance = 1;  
          objectCount = "1 1";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
          objectFuncs["Spawn", 0]   = "AddTargetMarker";
          factionOverride = "Terran";
          shipDesignWL = "DartShip 10 RangerShip 5"; 
          refObjectName = "REF_S3_01";
          shipSpawnHealth = 0.6;  //crippled     
      }; 
      new ScriptGroup("utaAttack2" : utaAttack1) 
      {                                      
          shipDesignWL = "DartShip_tutorial 10";  
      };      
   };
   new ScriptGroup("UTABoss")
   {
      maxWaves = 2; 
      waveContext[1] = "largeShip";
      
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName UTABoss";
      setHealthCallback[2, "Enemies", 0] = "0 StartWaveName QuestEnding";
      new ScriptGroup("bossShip1") 
      {                                      
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "500 750";  
          creationChance = 1;  
          objectCount = "1";
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
          objectFuncs["Spawn", 0]   = "AddTargetMarker";
          factionOverride = "Terran";
          refObjectName = "REF_S3_01";
          shipDesignWL = "BoomerangShip 10";
          shipSpawnHealth = 0.5;  //crippled       
      }; 
      new ScriptGroup("bossWingman" : bossShip1) 
      {                                      
          shipDesignWL = "DartShip_tutorial 10"; 
          objectCount = "2"; 
      };       
   };
   
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 




//moved here for demo setup ease. 
new ScriptGroup(S2_GetFocusCrystal : QuestBase)
{
   addToDatabase = true;  //Important 
   
   DeployData["StarType"]     = "Sector2_Root";
   DeployData["InstanceName"] = "Experiment Site";
   
   questType   = "Sec";   //Pick this one up at the star base. 
   
   SelectionData["ObjectivesComplete"]  = ""; //always allowed
   
   //Since this is unlocked by story, lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION

   rarity        = "Story"; 
   maxCompletes  = 1;
       
   title = "WE NEED TO FOCUS";  
   description = "Carl knows of a derelict space craft that can be pillaged for a focus crystal.";

   parentQuest = "";
   childQuests = "";
   
   Rewards["Complete", "Resource"] = "Exact 250";
  
   Callbacks["Selected"]      = "S2_FocusAccepted";    
   Callbacks["BeaconArrival"] = "S2_FocusStarted";
   Callbacks["Complete"]      = "S2_FocusComplete";   
 
   //Placeholder
   initialWaves = "WAVE_FakeScienceShip_01";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionText["initial"] = "MT_ATTACK FREE CARLS SHIP FROM THE ROCK";
   missionText["killzombie"] = "MT_ATTACK DESTROY THE ZOMBIE SHIP";
   missionText["crystal"] = "MT_GOTO COLLECT THE FOCUS CRYSTAL";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "killzombie";
   missionTrackerData[2] = "crystal";
   
   new ScriptGroup("WAVE_FakeScienceShip_01")
   {
      maxWaves = 1; 
      WaveMissionTrackers["active", 1] = "0";  
      new ScriptGroup("REF_carlsFakeShip" : MO_Props) 
      {                                      
         instanceObjectWeightedList = "CarlsFakeShip";
         objectCount = "1 1";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_FakeScienceShip_02 0";             
      };
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "SmallShips 10";
          refObjectName = "REF_carlsFakeShip";   
          offset = "200 250";  
          creationChance = 1;  
          objectCount = "4 4";
          factionOverride = "Civ";  
          hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;   
      };         
   };
     
   new ScriptGroup("WAVE_FakeScienceShip_02")
   {
      maxWaves = 1; 
      
      WaveMissionTrackers["active", 1] = "1";    
      WaveMissionTrackers["remove", 1] = "0"; 
      
      waveTimedCallbacks[1, 0] = "1000 callQuestFunction S2_FocusShipFound";   
      
      new ScriptGroup("REF_FakeScienceShip_Loc" : MO_Trigger) 
      {                                               
      };      
      
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "SpawnMyShipInstant";
          refObjectName = "REF_carlsFakeShip";   
          offset = "0 0";  
          creationChance = 1;  
          objectCount = "1 1";
          factionOverride = "Zombie";
          objectFuncs["Spawn", 0]   = "AddTargetMarker";   
          shipDesignWL = "Zombie_BlightShip_tutorial 10";
          mountRefObjectNames = "REF_FakeScienceShip_Loc";    
          objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName CrystalCollect";       
      };      
   };
   
   new ScriptGroup("CrystalCollect")
   {
      maxWaves = 1; 
      waveContext[1] = "crystal"; 
       
      WaveMissionTrackers["active", 1] = "2";  
      WaveMissionTrackers["remove", 1] = "1";          
      
      new ScriptGroup("REF_crystal" : MO_CollectProp)
      {   
         offset = "0 0";   
         refObjectName = "REF_FakeScienceShip_Loc"; 
         
         pickupWL = "S2_crystalPickup 10"; 
         
         objectFuncs["Spawn", 1] = "AddGoToMarker";                
         objectFuncs["Pickup", 1] = "evalTrackingSet pickupSet collected 1 StartWaveName QuestEnding 1000"; 
         
         objectCount = "1 1";  
         pickupFaction = "Pirate";
      };
   };
     
   new ScriptGroup("QuestEnding")
   {
      maxWaves = 1; 
      waveTimedCallbacks[1, 0] = "0 StartWaveName QuestComplete 0";
   }; 
}; 

