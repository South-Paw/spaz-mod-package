
////////////////////////////////////////////////////////////////////////////////
//SIDE MISSION BASE
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(QuestBase_SideMission : QuestBase)
{
   addToDatabase = false;  //Important 
   isSideMission = true;
   
   DeployData["StarType"]       = "Any"; //Any, INNER (UTA Sector2), OUTTER (Sector3,4), "Earth" for story ones
   DeployData["Infrastructure"] = "Any"; //Any, Mining, Science, Colony Determines what type of stars i go to to keep quests in context
   DeployData["InstanceType"]   = "Random"; //Any, Random (Which is random instances only), Hide, Security, Infrastructure (will be the mining,science or colony base), Zombie (zombie security instance) [Note: we do not use warpgate, it is special]
   DeployData["InstanceName"]   = "Any"; //Any, Name, like "Earth" or "Mars" for a specific instance
   DeployData["LevelRange"]     = "6 70"; //Maps to instance levels, usually taken from the star level, but warpgate will tent to have higher levels. (these are actual ship levels)
   DeployData["TechFocus"]      = "Random"; 
    
   questType   = "Event";
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["SectorProgress"] = "1 4";
   
   //rarity        = "common"; 
   rarity        = "uncommon"; 
   
   maxCompletes  = 1; //once this mission is done, its over and one with
       
   title = "TITLE UNDEFINED";  
   description = "DESCRIPTION UNDEFINED";

   parentQuest = "";
   childQuests = "";
      
   overrideMarker = "objectiveMarker_sideMissionImageMap";
   overrideColor = "0 0.5 1 1";
   
   expiryTurns    = 5;
   downtimeTurns  = 5;
   
   beaconDistance = 2000;
   
   hiddenTracker = false; 
   
   Rewards["Complete", "Data"] = "high";
   Rewards["Complete", "Resource"] = "high";
   
   SelectionData["Relations_Civ_Terran"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; 
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; 
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; 
};

function SideMission_Start(%tracker, %objective, %dialog)
{
   %title = %objective SPC "TITLE";
   %desc = %objective SPC "DESC";
   AddMissionObjective(%objective, "", %title, %desc);
   
   if (%dialog !$= "")
      SideMission_Dialog(%tracker, %dialog);
   else
      SideMission_TutorialOnly(%tracker);
}

function SideMission_Complete(%tracker, %objective, %dialog)
{
   CompleteObjective(%objective);
   if (%dialog !$= "")
      SideMission_Dialog(%tracker, %dialog);
}

function SideMission_Dialog(%tracker, %dialog)
{
   if (!Tutorial_HasPlayed("SecondaryMissionTutorial"))
      SEQ_activateSequence("SecondaryMissionTutorial", "SEQ_activateSequence", %dialog);
   else
      SEQ_activateSequence(%dialog);
}

function SideMission_TutorialOnly(%tracker)
{
   if (!Tutorial_HasPlayed("SecondaryMissionTutorial"))
      SEQ_activateSequence("SecondaryMissionTutorial");
}