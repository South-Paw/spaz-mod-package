//////////////////////////////////////////////////////////////////
// Crew Manager //////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////

//THIS IS NOW JUST FOR GOONS. HANGARS WILL CONTAIN ASSIGNED CREW


//Player Only
function Goon_Init()
{
   $CM_CurrentGoons = 0;  
}

/////////////////////////////////////////////////////////////////////
// Database /////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////

function Goon_GetCurrentCount()
{
   return $CM_CurrentGoons;     
}

function Goon_SetCurrentCount(%count)
{
   %maxCount = Goon_GetMaxCount();   
   %count = mClamp(%count, 0, %maxCount);
   
   $CM_CurrentGoons = %count;     
   
   UpdateGoonGui();
}

function Goon_GetGoonSpace()
{
   %maxCount = Goon_GetMaxCount();
   %current = Goon_GetCurrentCount();
   return %maxCount - %current;   
}

function Goon_ChangeCurrentCount(%change)
{
   %current = Goon_GetCurrentCount();
   Goon_SetCurrentCount(%current + %change);
   
   if ( %change > 0 )
      ChangeStat("ST_GoonsCollected", %change);  
}

function Goon_GetAvailableGoons()
{
   return Goon_GetCurrentCount();  
}

//////////////////////////////////////////////////////////////
// Strength //////////////////////////////////////////////////
//////////////////////////////////////////////////////////////


function Crew_GetShipSpawnCrew(%ship)
{
   %faction = %ship.getFaction();
   %maxCrew = %ship.getMaxCrew();
 
   if ( $FrontEndMode )
      return mRound(0.5 * %maxCrew);
      
   if ( %faction $= "Civ" )
   {
      %infraLevel = GetCurrentStar().GetInfrastructureLevel();
      %strength = 0.50 + (0.15 * %infraLevel); 
      return mRound(%strength * %maxCrew);
   }
   
   if ( %faction $= "Bounty" )
   {
      return %maxCrew;
   }
   
   if ( %faction $= "Terran" )
   {
      %infraLevel = GetCurrentStar().GetSecurityLevel();
      %strength = 0.50 + (0.15 * %infraLevel); 
      return mRound(%strength * %maxCrew);
   }
   
   if ( %faction $= "Zombie" )
      return mRound(0.333 * %maxCrew); //crew regens
   
   //This should grab any spare crew required.
   %hangarIndex = %ship.getHangarIndex();
   if ( %hangarIndex $= "" || %hangarIndex < 0 )
      return 1;
   
   HM_OnShipSpawned_UpdateCrew(%ship);
   %crew = HM_GetCurrentCrew(%hangarIndex);
   %crew++; //add captain
 
   return %crew;   
}

//////////////////////////////////////////////////////////////////////////
// Goon GUI Updater //////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////
$Goon_Levels[0] = 10;    //"ClockworkStation_Zero";   //1 hangar
$Goon_Levels[1] = 50;    //"ClockworkStation_Zero";  //3 hangars
$Goon_Levels[2] = 150;    //"ClockworkStation_01";
$Goon_Levels[3] = 500;   //"ClockworkStation_02";
$Goon_Levels[4] = 1500;   //"DysonStation_03";

//Player only 25 50 100 200
function Goon_GetMaxCount()
{
   %level = GetMothershipLevel();
   return $Goon_Levels[%level];      
}

function Goon_IsMothershipFull()
{
   %current = Goon_GetCurrentCount();
   return %current == Goon_GetMaxCount();
}


function UpdateGoonGui()
{
   %current = Goon_GetAvailableGoons();
   %max = Goon_GetMaxCount();
   %progress = %current/%max;
   
   TotalGoons_Text.setText(%current SPC "/" SPC %max);
   TotalGoons_Progress.setValue(%progress);
}


//////////////////////////////////////////////////////////////////////////
// Resources GUI Updater /////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////
//Piggybakin here for now.

//Player only

$RU_Levels[0] = 100;     //"ClockworkStation_Zero";   
$RU_Levels[1] = 500;     //"ClockworkStation_Zero";  
$RU_Levels[2] = 2500;    //"ClockworkStation_01";
$RU_Levels[3] = 10000;   //"ClockworkStation_02";
$RU_Levels[4] = 50000;   //"DysonStation_03";

function GetMaxRU()
{
   if ( $HangarCheat )
      return 10000;
      
   %level = GetMothershipLevel();
   return $RU_Levels[%level];   
}

function IsMothershipFull_RU()
{
   %current = FM_GetFactionRU(FM_GetPlayerFaction());
   return %current == GetMaxRU();
}


function UpdateResourcesGui()
{
   %current = FM_GetFactionRU(FM_GetPlayerFaction());
   %max = GetMaxRU();
   %progress = %current/%max;
   
   TotalResources_Text.setText(%current SPC "/" SPC %max);
   TotalResources_Progress.setValue(%progress);
}












