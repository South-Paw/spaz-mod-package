
///////////////////////////////////////////////////////////
// BYSTAND BASE
// stuff that just happens out there that is non combat (but could be) ... something for the player to do harrass
///////////////////////////////////////////////////////////

new ScriptGroup(QuestBase_Bystand : QuestBase_Event)
{
   addToDatabase = false;  //Important 
   
   DeployData["StarType"]       = "Any"; //Any, INNER (UTA Sector2), OUTTER (Sector3,4), "Earth" for story ones
   DeployData["Infrastructure"] = "Any"; //Any, Mining, Science, Colony Determines what type of stars i go to to keep quests in context
   DeployData["InstanceType"]   = "Random"; //Any, Random (Which is random instances only), Hide, Security, Infrastructure (will be the mining,science or colony base), Zombie (zombie security instance) [Note: we do not use warpgate, it is special]
   DeployData["InstanceName"]   = "Any"; //Any, Name, like "Earth" or "Mars" for a specific instance
   DeployData["LevelRange"]     = "0 70"; //Maps to instance levels, usually taken from the star level, but warpgate will tent to have higher levels. (these are actual ship levels)
   DeployData["TechFocus"]      = "Random"; 
    
   questType   = "Event";
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   
   rarity        = "Uncommon"; 
   
   quietFinish = true;
       
   title = "TITLE UNDEFINED";  
   description = "DESCRIPTION UNDEFINED";

   parentQuest = "";
   childQuests = "";
   
   overrideMarker = "objectiveMarker_questionImageMap";
   overrideColor = "1 1 0 1";
   
   expiryTurns    = 5; 
   downtimeTurns  = 5;
   
   beaconDistance = 2000;
   
   hiddenTracker = true; 
   
   failOnWarpout    = true; //get rid of quest after you check it out
   
   Callbacks["BeaconArrival"] = "RunBystandTutorial";

   Rewards["Complete", "Resource"] = "";
   Rewards["Complete", "Data"] = "";
   
   //RLBRLB for testing remove later
   SelectionData["Relations_Civ_Terran"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; //may not use, so can be defined for all
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
};
