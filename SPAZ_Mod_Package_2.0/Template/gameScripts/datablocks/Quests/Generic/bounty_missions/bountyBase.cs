////////////////////////////////////////////////////////////////////////////////
//BASE EVENT
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(BountyBase : QuestBase)
{
   addToDatabase = false;  //Important (FOR ALL)
   
   allowAmbientHunters = false;
     
   questType   = "Event";
   maxCompletes  = -1;
       
   title = "TITLE UNDEFINED";  
   description = "DESCRIPTION UNDEFINED";

   parentQuest = "";
   childQuests = "";
      
   overrideMarker = "objectiveMarker_emptyImageMap";
   overrideColor = "1 0.5 0.5 1";
   
   expiryTurns    = 5;
   downtimeTurns  = 5;
   
   beaconDistance = 2000;
   
   baseInstances = "ArenaInstance";
   
   initialWaves = "arenaSetup";
   
   hiddenTracker = false; 
   missionText["initial"] = "MT_ATTACK DEFEAT YOUR OPPONENT";
   missionText["timer"] = "MT_INFO TIME LIMIT";
   missionText["failTime"] = "MT_FAIL YOU RAN OUT OF TIME";
   missionText["noMoreHelp"] = "MT_FAIL YOU CAN'T WIN WITHOUT HELP";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "3500 startWaveName arenaSpawn";
   missionTrackerData[0] = "initial"; 
   missionTrackerData[1] = "timer MT_TIMERTEXT 60";  
   
   //0 = Bronze
   //1 = Silver
   //2 - Gold
   
   //BRONZE
   Rewards["Complete_0", "Resource"]         = ""; //Possibilities: Low, Med, High, or an exact number. (like for story missions)
   Rewards["Complete_0", "Data"]             = "";
   Rewards["Complete_0", "Infrastructure"]   = 0; //The nuymber is the change in value, so 0 does nothing, -1 decreases, 1 increases
   Rewards["Complete_0", "Security"]         = 0; //IMPORTANT: the -1 possibility here allows for missions to return resource in exchange for destroying infrastructure. 
   Rewards["Complete_0", "Infection"]        = 0;  
   Rewards["Complete_0", "Relations_Civ"]    = 0; //Change can be +/- (Relations bleed over to neighbor stars at 1/2 value of current star
   Rewards["Complete_0", "Relations_Terran"] = 0; //Values $RelChange_Small, $RelChange_Medium, $RelChange_Large, $RelChange_Max (will do a full shift to other end)
   Rewards["Complete_0", "Goons"]            = "";
   Rewards["Complete_0", "Spec"]             = ""; //Random will deliver a level appropriate Specialist, else use SS_SpaceSkidPuff which is the name of a story specialist. 
   Rewards["Complete_0", "Bounty"]           = 0;  //can be positive or negative (positive is bad for the player) 

   //SILVER
   Rewards["Complete_1", "Resource"]         = ""; //Possibilities: Low, Med, High, or an exact number. (like for story missions)
   Rewards["Complete_1", "Data"]             = "";
   Rewards["Complete_1", "Infrastructure"]   = 0; //The nuymber is the change in value, so 0 does nothing, -1 decreases, 1 increases
   Rewards["Complete_1", "Security"]         = 0; //IMPORTANT: the -1 possibility here allows for missions to return resource in exchange for destroying infrastructure. 
   Rewards["Complete_1", "Infection"]        = 0;  
   Rewards["Complete_1", "Relations_Civ"]    = 0; //Change can be +/- (Relations bleed over to neighbor stars at 1/2 value of current star
   Rewards["Complete_1", "Relations_Terran"] = 0; //Values $RelChange_Small, $RelChange_Medium, $RelChange_Large, $RelChange_Max (will do a full shift to other end)
   Rewards["Complete_1", "Goons"]            = "";
   Rewards["Complete_1", "Spec"]             = ""; //Random will deliver a level appropriate Specialist, else use SS_SpaceSkidPuff which is the name of a story specialist. 
   Rewards["Complete_1", "Bounty"]           = 0;  //can be positive or negative (positive is bad for the player) 

   //GOLD
   Rewards["Complete_2", "Resource"]         = ""; //Possibilities: Low, Med, High, or an exact number. (like for story missions)
   Rewards["Complete_2", "Data"]             = "";
   Rewards["Complete_2", "Infrastructure"]   = 0; //The nuymber is the change in value, so 0 does nothing, -1 decreases, 1 increases
   Rewards["Complete_2", "Security"]         = 0; //IMPORTANT: the -1 possibility here allows for missions to return resource in exchange for destroying infrastructure. 
   Rewards["Complete_2", "Infection"]        = 0;  
   Rewards["Complete_2", "Relations_Civ"]    = 0; //Change can be +/- (Relations bleed over to neighbor stars at 1/2 value of current star
   Rewards["Complete_2", "Relations_Terran"] = 0; //Values $RelChange_Small, $RelChange_Medium, $RelChange_Large, $RelChange_Max (will do a full shift to other end)
   Rewards["Complete_2", "Goons"]            = "";
   Rewards["Complete_2", "Spec"]             = ""; //Random will deliver a level appropriate Specialist, else use SS_SpaceSkidPuff which is the name of a story specialist. 
   Rewards["Complete_2", "Bounty"]           = 0;  //can be positive or negative (positive is bad for the player) 


   //Arena Ships
   PlayerShipInfo_0 = "ScoutShip_Basic_B";  //Bronze
   PlayerShipInfo_1 = "ScoutShip_Basic_B";  //Silver
   PlayerShipInfo_2 = "ScoutShip_Basic_B";  //Gold

   //We can define tech levels per faction and per difficulty level;
   //Allows us to tune difficulty using ships AND relative tech
   
   //Terran, Pirate, Zombie, Civ, Bounty levels
   TechLevels_0 = "2 4 2 2 2";
   TechLevels_1 = "2 2 2 2 2";
   TechLevels_2 = "4 2 4 4 4";
   
   DifficultyTitle[0] = "Bronze Event (Easy)"; //Can color the button to difficulty of something too
   DifficultyTitle[1] = "Silver Event (Normal)";
   DifficultyTitle[2] = "Gold Event (Hard)";
   
   DifficultyDesc[0]  = "Describe gameplay on this level (Bronze).  who is tough who is weak etc";
   DifficultyDesc[1]  = "Describe gameplay on this level (Silver).  who is tough who is weak etc";
   DifficultyDesc[2]  = "Describe gameplay on this level (Gold).  who is tough who is weak etc";

   //$Difficulty_Easy  
   //$Difficulty_Normal 
   //$Difficulty_Hard   
   //$Difficulty_Expert 
   //$Difficulty_Insane 
   DifficultySettings_0 = $Difficulty_Insane;
   DifficultySettings_1 = $Difficulty_Insane;
   DifficultySettings_2 = $Difficulty_Insane;

};

////////////////////////////////////////////////////////////////////////////////
// ARENA UTILITY
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(WAVE_arenaSetup)
{    
   maxWaves = 1;  
   waveRelations[1, 0] = "Pirate Civ" SPC $FactionRelation_HATE;
   waveRelations[1, 1] = "Pirate Terran" SPC $FactionRelation_HATE;  
   waveRelations[1, 2] = "Terran Civ" SPC $FactionRelation_FRIEND;
   waveRelations[1, 3] = "Civ Bounty" SPC $FactionRelation_HATE; 
   waveRelations[1, 4] = "Terran Bounty" SPC $FactionRelation_HATE; 
   waveRelations[1, 5] = "Pirate Bounty" SPC $FactionRelation_HATE;           
};

new ScriptGroup(WAVE_arenaSpawnBasic)
{    
   maxWaves = 1;  
   healthCallbackSets = "enemy"; 
   setHealthCallback["all", "enemy", 0] = "0 StartWaveName questComplete 0"; 
   WaveMissionTrackers["active", 1] = "0";   
   waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand BountyArenaShipSet SetTactic TP_Stance TP_SeekAndDestroy"; 
};

new ScriptGroup(WAVE_arenaSpawnTimed : WAVE_arenaSpawnBasic)
{    
   WaveMissionTrackers["active", 1] = "0 1";   
};

new ScriptGroup(SHIP_ArenaBasic : MO_Ships)
{                                      
   instanceObjectWeightedList = "SpawnMyShip";
   objectCount = "1"; 
   factionOverride = "Terran";                     
   refObjectName = "REF_Beacon";
   offset = "3000"; 
   onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
   objectFuncs["Spawn", 0] = "AddTargetMarker"; 
   objectFuncs["Spawn", 1]   = "QAI_AddToSet BountyArenaShipSet";
}; 

new ScriptGroup(SHIP_ArenaWingman : MO_Ships)
{                                      
   instanceObjectWeightedList = "SpawnMyShip";
   objectCount = "1"; 
   factionOverride = "Terran";                     
   refObjectName = "REF_Beacon";
   offset = "100"; 
   objectFuncs["Spawn", 0]   = "QAI_AddToSet BountyArenaShipSet"; //so helpers will find targets
}; 

new ScriptGroup(PROP_arenaProps_01 : MO_props) 
{                                    
   instanceObjectWeightedList = "SpaceProp_EMPBarrels 10";
   offset = "3200 3300";  
   objectCount = "16";
   refObjectName = "REF_Beacon";
};    

//Place one of these at the top of each Ladder file, defining the ladder.  Should be clean.

//IMPORTANT NOTES
//Never rename the Ladders once deployed to public [CLASS ACTION!]
//Tiers can be reordered (but really shouldnt, but never rename them or will scramble save data.
//Tier names only need to be unique within each challenge. 

/*
new ScriptGroup(ArenaChallenge_Test : ArenaChallengeLadder_Base)
{
   ladderName = "Test Challenge";
   ladderDescription = "Some description of the over arching goal of the test challenge";

   deployStarLevelRange = "20 25";
   
   new ScriptObject(Tier_0:ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01A";    
   };
   new ScriptObject(Tier_1:ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01A";    
   };
   new ScriptObject(Tier_2:ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01A";    
   };
   new ScriptObject(Tier_3:ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01A";    
   };
   new ScriptObject(Tier_4:ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01A";    
   };
};

*/

