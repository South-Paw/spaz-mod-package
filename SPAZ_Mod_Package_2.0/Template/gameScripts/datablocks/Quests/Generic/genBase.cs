////////////////////////////////////////////////////////////////////////////////
//GEN BASE
////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////
//BASE EVENT
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(QuestBase_Event : QuestBase)
{
   addToDatabase = false;  //Important 
   
   DeployData["StarType"]       = "Any"; //Any, INNER (UTA Sector2), OUTTER (Sector3,4), "Earth" for story ones
   DeployData["Infrastructure"] = "Any"; //Any, Mining, Science, Colony Determines what type of stars i go to to keep quests in context
   DeployData["InstanceType"]   = "Random"; //Any, Random (Which is random instances only), Hide, Security, Infrastructure (will be the mining,science or colony base), Zombie (zombie security instance) [Note: we do not use warpgate, it is special]
   DeployData["InstanceName"]   = "Any"; //Any, Name, like "Earth" or "Mars" for a specific instance
   DeployData["LevelRange"]     = "6 70"; //Maps to instance levels, usually taken from the star level, but warpgate will tent to have higher levels. (these are actual ship levels)
   DeployData["TechFocus"]      = "Random"; 
    
   questType   = "Event";
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["SectorProgress"] = "1 4";
   
   rarity        = "Uncommon"; 
   maxCompletes  = -1;
       
   title = "TITLE UNDEFINED";  
   description = "DESCRIPTION UNDEFINED";

   parentQuest = "";
   childQuests = "";
      
   overrideMarker = "objectiveMarker_exclamationImageMap";
   overrideColor = "1 0 0 1";
   
   expiryTurns    = 5;
   downtimeTurns  = 5;
   
   beaconDistance = 2000;
   
   hiddenTracker = false; 
   
   Rewards["Complete", "Resource"] = "med";
   Rewards["Complete", "Data"] = "med";
   
   SelectionData["Relations_Civ_Terran"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; 
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; 
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION; 
};

////////////////////////////////////////////////////////////////////////////////
//MISSION OBJECTS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(MO_Props)
{                                   
   instanceObjectWeightedList = "AsteroidBreakage";
   offset = "2000 3000"; 
   objectCount = "14 18";
   creationChance = 1;
   refObjectName = "REF_Beacon";
}; 

new ScriptGroup(MO_Ships)
{                                      
    instanceObjectWeightedList = "AverageShips 10";
    offset = "500 600";  
    creationChance = 1;  
    objectCount = "3 3"; 
    factionOverride = "Terran";                     
    refObjectName = "REF_Beacon";
}; 

new ScriptGroup(MO_Trigger)
{                                      
   instanceObjectWeightedList = "QuestTrigger 10";
   offset = 0;  
   creationChance = 1;  
   objectCount = "1 1";
   triggerRadius = 450;
   triggerPingRate = 250; //milliseconds
   questCleanup = true;
   oneCallPerPing = false;
};  

new ScriptGroup(MO_Pickups)
{  
   refObjectName = "REF_Beacon"; 
   offset = 0;    
   pickupWL = "MissionPickup_Basic 10";                                 
   instanceObjectWeightedList = "Pickups_Generic 10";
   creationChance = 1;  
   objectCount = "2 3";
};  

new ScriptGroup(MO_Mines)
{  
   refObjectName = "REF_Beacon"; 
   instanceObjectWeightedList = "RegenSwarmMineField 10";
   offset = 0;  
   creationChance = 1;  
   objectCount = "1 1";
}; 

///////////////////////////////////////////////////////////
// UTIL STUFF
///////////////////////////////////////////////////////////
 
function AsteroidClass::ImpulseToRef(%this, %refName, %variance) //used to get comet moving
{
   if (%refName $= "")
      %refName = "Ref_Beacon";
   
   %targetPos = getCurrentInstance().GetRefObjectPosition(%refName); 
   if (%variance)
      %targetPos = t2dVectorAdd(%targetPos, getRandom(-%variance, %variance) SPC getRandom(-%variance, %variance));  
   
   %vectorAngle = t2dVectorSub(%targetPos, %this.position);
   
   %rotation =  getVectorAngle(%vectorAngle);
   
   %this.setImpulseForcePolar(%rotation, 500);
}

function AsteroidClass::destroyAtRange(%this, %range) 
{
   %distance = t2dVectorDistance(%this.position, "0 0");
   if (%distance > %range)
      %this.setHealth(0);  
   else
      %this.sceneSchedule(5000, "destroyAtRange", %range);
}

function AsteroidClass::destroyWhenNear(%this, %range, %refName, %waveToCall) 
{
   %instance = GetCurrentInstance();
   %tracker = %instance.GetCurrentQuestTracker();
   %refObject = %instance.FindRefObject(%refName); 
   if (!isObject(%refObject))
      return;
   
   %distance = t2dVectorDistance(%this.position, %refObject.position);
   if (%distance < %range)
   {
      %this.setHealth(0);  
      if (isObject(%tracker))
         %instance.StartWaveName(%waveToCall); 
   }
   else
   {
      %this.sceneSchedule(150, "destroyWhenNear", %range, %refName, %waveToCall);
   }
}

function AIShipClass::mission_destroyShip(%this) 
{
   %this.applyDamage(1000000, "Explosive", "", "0 1", 1, %this.position);  
}



