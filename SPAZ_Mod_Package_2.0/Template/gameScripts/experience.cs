//Each XP level takes a fixed number of points to reach
//The relative strength of the enemies dictates how much xp they drop
//Therefore fighting low end enemies is not a good grinding tool
//We want the player challenging themselves and facing tough stuff
//Levelups should come relativley quickly.  
//We want to balance points per levelup with time played. more points should mean longer time between levelups
//we dont want the player constantly in the research screen
//ships that are lower level have less useful data to extract (important for tutorial)

//when a ship is spawned we store its level to compare to the player's level when a kill occurs.

$XP_LevelupBaseCost = 30;  //100 points per level (fixed) we adjust the data you get by relative ship tech 
$XP_LevelupIncreaseCost = 20; 

//We only worry about the player for the XP system.  dont want to over engineer for multiplayer here.
$XP_CurrentLevel = 0;
$XP_CurrentUpgradePoints = 0;
$XP_UpgradePointsPerLevel = 3;

//called whenever data is set. 
function XP_Update(%faction)
{
   if ( $FrontEndMode )
      return;
      
   if ( %faction !$= FM_GetPlayerFaction() )  
      return;      
         
   %dataPoints = FM_GetFactionData(%faction);
   
   %newLevel = XP_CalculateXPLevel(%dataPoints);
   
   while ( %newLevel > XP_GetCurrentLevel() )
      XP_Levelup();      
   
   XP_UpdateLevelProgressBar();
}

function XP_UpdateLevelProgressBar() 
{
   %currentXP = FM_GetFactionData(FM_GetPlayerFaction());
   %currentLevel = XP_GetCurrentLevel();
   %nextLevelXP = XP_CalculateDataPointsForLevel(%currentLevel + 1);
   
   %currentLevelXP = XP_CalculateDataPointsForLevel(%currentLevel);
   
   %totalXPRequiredForNextLevel = %nextLevelXP - %currentLevelXP;
   %currentXPLevelProgress = %currentXP - %currentLevelXP;
      
   %debt = DEBT_GetDebt();
   if ( %debt > 0 )
      TechLevel_Text.setText("DEBT:" SPC %debt);
   else
      TechLevel_Text.setText(%currentXPLevelProgress SPC "/" SPC %totalXPRequiredForNextLevel);
   
   TechLevel_Progress.setValue(%currentXPLevelProgress / %totalXPRequiredForNextLevel);     

   
}

function XP_GetSurplusData()
{
   %currentXP = FM_GetFactionData(FM_GetPlayerFaction());
   %currentLevel = XP_GetCurrentLevel();
   %nextLevelXP = XP_CalculateDataPointsForLevel(%currentLevel + 1);
   
   %currentLevelXP = XP_CalculateDataPointsForLevel(%currentLevel);
   
   %totalXPRequiredForNextLevel = %nextLevelXP - %currentLevelXP;
   %currentXPLevelProgress = %currentXP - %currentLevelXP;
   
   return %currentXPLevelProgress;
}


function XP_PingGUI()
{
   XP_SetUpgradePoints(XP_GetUpgradePoints());
   XP_SetCurrentLevel(XP_GetCurrentLevel());
   XP_UpdateLevelProgressBar();
}



function XP_CalculateDataPointsForLevel(%level)
{    
   if ( %level == 0 )
      return 0;
      
   %dataPoints = (((%level * (%level + 1)) / 2) * $XP_LevelupIncreaseCost) + ($XP_LevelupBaseCost * %level);
   return %datapoints;
}

//%dataPoints = (((%level * (%level + 1)) / 2) * $XP_LevelupIncreaseCost) + $XP_BaseLevelupCost;
// (data - base)/cost = 


// (data / 1000) * 2 = n(n+1)
// data / 500 = n2 + n
//


function XP_CalculateXPLevel(%dataPoints)
{
   %a = $XP_LevelupIncreaseCost/2;
   %b = ($XP_LevelupIncreaseCost/2) + $XP_LevelupBaseCost;
   %c = -%dataPoints;
   
   %level = (-%b + mSqrt(mPow(%b,2) - (4 * %a * %c))) / (2 * %a);    
      
   %level = mFloor(%level);
   return %level;
   
}


/////////////////////////////////////////
// Level Handling ///////////////////////
/////////////////////////////////////////

function XP_Levelup()
{
   XP_ChangeCurrentLevel(1);
   SPEC_OnLevelup();
   
   if ($PauseSet.getCount() == 0) //this will push the meta info over top of the hangar view and cheats, which is bad, so we have to bail
      MetaInfo_Push(); //the hint system needs to be updated to know about the upgrade point change
   
   if ( !isObject($thescenegraph) )
      return;
      
   LevelupCallout(); 
   
   %hasCloned = Levelup_DoCloning();
     
   if (!Tutorial_HasPlayed("CON_TUT_Levelup"))
   {
      SEQ_activateSequence("Dialog_S1_Levelup", "Tutorial_Request", "CON_TUT_Levelup");
      return;
   }
   
   //if (%hasCloned) //mentioned elsewhere now
   //   Tutorial_Request("CON_TUT_CLONING");   
}

function XP_GetCurrentLevel()
{
   return $XP_CurrentLevel;
}

function XP_SetCurrentLevel(%level)
{
   $XP_CurrentLevel = %level;
   
   if ( %level == 10 )
      SetAchievement("ACH_LEVEL_10");  
      
   if ( %level == 50 )
      SetAchievement("ACH_LEVEL_50");  
      
   if ( %level == 100 )
      SetAchievement("ACH_LEVEL_100");  
      
      
   //TechLevelText.setText(%level); //no longer used
}

function XP_ChangeCurrentLevel(%change)
{
   XP_SetCurrentLevel(XP_GetCurrentLevel() + %change);
   XP_ChangeUpgradePoints(XP_GetUpgradePointsRewardForLevel(XP_GetCurrentLevel()));
}

///////////////////////////////////////
// CLoning ////////////////////////////
///////////////////////////////////////

$CloneRate[0] = 0;
$CloneRate[1] = 0;
$CloneRate[2] = 0.10;
$CloneRate[3] = 0.15;
$CloneRate[4] = 0.15;

function Levelup_DoCloning()
{
   %cloneRate = $CloneRate[GetMothershipLevel()];  
   if ( %cloneRate == 0 )
      return false;
      
   %maxGoons = Goon_GetMaxCount();
   %cloneRate *= GetSpecMult("Pirate", "SC_Cloning");  
   %cloneCount = mRound(%maxGoons * %cloneRate);
   
   %goonRoom = %maxGoons - Goon_GetCurrentCount();
   if ( %cloneCount > %goonRoom )
      %cloneCount = %goonRoom;
      
   Goon_ChangeCurrentCount(%cloneCount);
   
   CustomCallout("GOONS CLONED:" SPC %cloneCount, "", "", "", "", "", "", "", "goonClone");
   
   return true;
}

//////////////////////////////////////
// Level Up Upgrade Points ///////////
//////////////////////////////////////

function XP_SetUpgradePoints(%points)
{            
   $XP_CurrentUpgradePoints = %points;
   //update the GUI:
   RS_UpgradePointsText.setText(%points);
   MetaInfo_LevelupText.setText(%points);
}

function XP_GetUpgradePoints()
{
   return $XP_CurrentUpgradePoints;
}


function XP_ChangeUpgradePoints(%points)
{   
   XP_SetUpgradePoints(XP_GetUpgradePoints() + %points);
}


//Used by research screen.
function XP_GetPointsForUpgradeLevel(%level)
{
   return %level;   
}


/////////////////////////////////////////////
// level upgrade points /////////////////////
/////////////////////////////////////////////

function XP_GetUpgradePointsRewardForLevel(%level)
{
   //%points = mFloor(mSqrt(%level));
   %points = $XP_UpgradePointsPerLevel;
   return %points;
}



/////////////////////////////////////////////
// Data multiplier alg //////////////////////
/////////////////////////////////////////////
 
function XP_GetXPMult(%currentLevel, %desiredLevel)
{   
   %levelDiff = mAbs(%currentLevel - %desiredLevel);
   if ( %levelDiff == 0 )
      return 1;
   
   //Must drop harshly but grow slowly.
   if ( %currentLevel > %desiredLevel )
   {//Drop harshly.
      %xpMult = 1 / (1 + (0.5 * %levelDiff));
      if ( %xpMult < 0.15 )
         %xpMult = 0.15; //always give something      
      
      return %xpMult;
   }
   else
   {//rise slowly.
      %xpMult = 1 + (0.08 * %levelDiff);
      if ( %xpMult > 2 )
         %xpMult = 2;
         
      return %xpMult;      
   }
}



//SST filler ships obey a star system's theme.
//Star systems focus on different research categories
//Star systems get 1 weapon focus, and 2 other focuses
//serves  as a guide line for sst selections.  must also obey quest constraints. 

/////////////////////////////////////////////
// Ship Kill XP /////////////////////////////
/////////////////////////////////////////////
$XP_ShipDesignTypeMults[$SST_DESIGN_CIV]      = 1.000; //dont need to degrade civ designs, we already do with their hullTypeXPMult = 0.5;     
$XP_ShipDesignTypeMults[$SST_DESIGN_BASIC]    = 1.000;
$XP_ShipDesignTypeMults[$SST_DESIGN_IMPROVED] = 1.500;
$XP_ShipDesignTypeMults[$SST_DESIGN_ADVANCED] = 2.500;

$XP_ShipHullSizeValues[$HULLTYPE_TINY]       = 15;
$XP_ShipHullSizeValues[$HULLTYPE_SMALL]      = 35;
$XP_ShipHullSizeValues[$HULLTYPE_MEDIUM]     = 70;
$XP_ShipHullSizeValues[$HULLTYPE_LARGE]      = 133;
$XP_ShipHullSizeValues[$HULLTYPE_HUGE]       = 250;
$XP_ShipHullSizeValues[$HULLTYPE_STATION]    = 300;
$XP_ShipHullSizeValues[$HULLTYPE_MOTHERSHIP] = 0; //only happens in story.

function XP_GetShipDestroyedDataAmount(%shipObject)
{
   %myTechLevel   = XP_GetCurrentLevel();
   %shipTechLevel = %shipObject.getTechLevel();
   %xpMult = XP_GetXPMult(%myTechLevel, %shipTechLevel);
   
   %shipDesign = %shipObject.shipDesignDatablock; //to check if basic, improved, or advanced.
   %descriptionBits = %shipDesign.designDescriptionBits;
   %designTypeMult = $XP_ShipDesignTypeMults[%descriptionBits];
   
   %hullDatablock = %shipObject.getHullDatablock();
   %hullType = %hullDatablock.hullType;
   %hullTypeXPMult = %hullDatablock.hullTypeXPMult;
   
   %hullSizeXPValue = $XP_ShipHullSizeValues[%hullType];
   
   %rewardData = %hullSizeXPValue * %xpMult * %designTypeMult * %hullTypeXPMult;
   %rewardData =  mCeil(%rewardData);
   return %rewardData;
}

/////////////////////////////////////////////////
// Star Tech Focus //////////////////////////////
/////////////////////////////////////////////////
//This is used to generate a star's tech tree. 

//This is a profile for how levels are randomly assigned up to the star's level
$STF_CATEGORIES["Bal"] = createEfficientWeightedList("Projectile 200 Beam 200 Missile 150 MassBomb 10 Mine 10 Drone 10 Shield 150 Cloaking 10 Reactor 200 Engine 100 Turret 20 Armor 150 Hull 150 SubSystem 20 Crew 30");  //balanced
$STF_CATEGORIES["Off"] = createEfficientWeightedList("Projectile 300 Beam 300 Missile 200 MassBomb 10 Mine 10 Drone 10 Shield 150 Cloaking 10 Reactor 200 Engine 100 Turret 20 Armor 150 Hull 150 SubSystem 20 Crew 30");
$STF_CATEGORIES["Def"] = createEfficientWeightedList("Projectile 200 Beam 200 Missile 150 MassBomb 10 Mine 10 Drone 10 Shield 250 Cloaking 10 Reactor 200 Engine 100 Turret 20 Armor 250 Hull 250 SubSystem 20 Crew 30");
//"Any" is also a valid type when ships refer to the star tech focus type. 

$STF_CATEGORIES = "Bal Off Def";






//SST: define ship roles like medic, sniper etc.. the fleet make up is logical
//SST: define ship roles like medic, sniper etc.. the fleet make up is logical
//Add preferred star tech focus to ship deisgns, multiply the selectioon chance
//so we have:  star tech profiles, ship roles, ship desired star profile matching








//////////////////////////////////////////////
// Debug //////////////////////////////////////
/////////////////////////////////////////////

function XP_DebugDoLevelUp()
{
   %currentXP = FM_GetFactionData(FM_GetPlayerFaction());
   %currentLevel = XP_GetCurrentLevel();
   %nextLevelXP = XP_CalculateDataPointsForLevel(%currentLevel + 1);
   
   %currentLevelXP = XP_CalculateDataPointsForLevel(%currentLevel);
   
   %totalXPRequiredForNextLevel = %nextLevelXP - %currentLevelXP;
  
   
   FM_ChangeFactionData(FM_GetPlayerFaction(), %totalXPRequiredForNextLevel);   
}



