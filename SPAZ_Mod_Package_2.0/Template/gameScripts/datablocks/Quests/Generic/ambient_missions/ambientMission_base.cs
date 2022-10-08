
///////////////////////////////////////////////////////////
// AMBIENT BASE
// non completes, but combat related
// faction vs faction battle zones
// mothership and station attacks
// cool stuff that happens at star bases
///////////////////////////////////////////////////////////

new ScriptGroup(QuestBase_Ambient_Zone : QuestBase_Event)
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
   
   rarity        = "Common"; 
   
   quietFinish = true;
       
   title = "TITLE UNDEFINED";  
   description = "DESCRIPTION UNDEFINED";
   
   overrideMarker = "objectiveMarker_commonImageMap";
   overrideColor = "1 0.5 0 1";

   parentQuest = "";
   childQuests = "";
   
   expiryTurns    = 5; 
   downtimeTurns  = 5;
   
   beaconDistance = 2000;
   
   hiddenTracker = true; 
   
   failOnWarpout    = true; //get rid of quest after you check it out
   
   Callbacks["BeaconArrival"] = "RunCombatEventTutorial";
   
   Rewards["Complete", "Resource"] = "";
   Rewards["Complete", "Data"] = "";
   
   SelectionData["Relations_Civ_Terran"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; 
};


new ScriptGroup(QuestBase_Ambient_Silent : QuestBase_Ambient_Zone)
{
   rarity = "Common"; 
   questType   = "Ambient";
   
   Callbacks["BeaconArrival"] = ""; //don't inherit from zone
};