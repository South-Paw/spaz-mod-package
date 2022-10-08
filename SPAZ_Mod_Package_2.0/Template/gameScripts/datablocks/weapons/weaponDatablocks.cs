


function WeaponDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "WeaponBase"  )
      return;
            
   %this.HandleProceduralStats();
   Parent::onAdd(%this);            
}

//Override me
function WeaponDatablock::GetProceduralData(%this, %statID)
{
   return 1; //Override me
}

//Override me
function WeaponDatablock::GetProceduralMult(%this, %statID)
{
   return 1; //Override me
}

///////////////////////////////////////
//Procedural Stat /////////////////////
///////////////////////////////////////

function WeaponDatablock::GetFinalStat(%this, %statID)
{
   %data = %this.GetProceduralData(%statID);
   %mult = %this.GetProceduralMult(%statID);
   
   %result = %data * %mult;  
   return %result;
}

function WeaponDatablock::HandleProceduralStats(%this)
{
   %this.powerConsumption = %this.GetFinalStat("PowerConsumption");
   %this.powerConsumption *= %this.GetReferenceReactorOutput(); //based on maxReactorOutput so can balance if the cap will be going down or not per sec.    

   %this.RUCost = mRound(%this.GetFinalStat("ResourceCost"));  //rounding just in case  
}

//IMPORTANT NOTE: waepons draw from capacitor for reference that ofr tuning. 
function WeaponDatablock::GetReferenceReactorOutput(%this)
{
   if ( isObject(%this.referenceReactor) )
      return %this.referenceReactor.maxReactorOutput;
      
   return 1;   
}


////////////////////////////////////////////////
// BaseClass ///////////////////////////////////
////////////////////////////////////////////////

//NOTE: WE CANNOT INHERIT CODE VARIABLES ACROSS CLASSES!!!!
//This imheritance is ONLY here for dynamic fields!!!
//BEWARE

$WT_None = 0; //WT = weapon threat
$WT_Low  = 1; 
$WT_Med  = 2; //WT = weapon threat
$WT_High = 4; //WT = weapon threat //if 4 on purpose so is 2X the prev

datablock WeaponDatablock(WeaponBase : ComponentBase) 
{      
   
   //componentType      = "External";  //NOTE: inheritance through code for Datablocks does not seem to work!!! beware!!
                                     //an:thing defined code side, MUST be defined 
   //componentSubType   = "Invalid";
   
   isAutomated        = false;  //only tractors are automated (they fire themselves, point defense will too

   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_None;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_None;  //long range lasers and projectiles
   threat_Short = $WT_None; //WT_None WT_Low WT_Med WT_High
};



///////////////////////////////////////////////
// Weapon Type Definitions ///////////////////
///////////////////////////////////////////////

%counter = 0;
$WEAPON_MissileLauncher    = bit(%counter++);  //will be 1
$WEAPON_TorpedoLauncher    = bit(%counter++);
$WEAPON_RocketLauncher     = bit(%counter++);


$WEAPON_MassBombLauncher     = bit(%counter++);
$WEAPON_MineDropperLauncher  = bit(%counter++);
$WEAPON_DeployableTurretLauncher = bit(%counter++);

$WEAPON_BeamEmitter            = bit(%counter++);
$WEAPON_ProjectileCannon       = bit(%counter++);
$WEAPON_CrewProjectileCannon   = bit(%counter++);

$WEAPON_MiningBeamEmitter   = bit(%counter++);
$WEAPON_TractorBeamEmitter  = bit(%counter++);
$WEAPON_PointDefenseEmitter = bit(%counter++);
$WEAPON_ScannerEmitter      = bit(%counter++);
$WEAPON_DroneHiveLauncher   = bit(%counter++);

$WEAPON_BoosterModule       = bit(%counter++);

$WEAPON_Turret              = bit(%counter++);


$LINK_Launcher  = $WEAPON_MissileLauncher | $WEAPON_TorpedoLauncher | $WEAPON_RocketLauncher | $WEAPON_BoosterModule;
$LINK_Bomber    = $WEAPON_MassBombLauncher | $WEAPON_MineDropperLauncher | $WEAPON_DeployableTurretLauncher | $WEAPON_BoosterModule;
$LINK_Drones    = $WEAPON_DroneHiveLauncher | $WEAPON_BoosterModule;
$LINK_Shooter   = $WEAPON_BeamEmitter | $WEAPON_ProjectileCannon | $WEAPON_CrewProjectileCannon | $WEAPON_MiningBeamEmitter | $WEAPON_BoosterModule;
$LINK_Utility   = $WEAPON_TractorBeamEmitter | $WEAPON_PointDefenseEmitter | $WEAPON_ScannerEmitter | $WEAPON_BoosterModule;
$LINK_Mining    = $WEAPON_MiningBeamEmitter;
$LINK_Turret    = $WEAPON_Turret;  //just an identifier

//ZOMBIE ONLY
$LINK_Universal = $LINK_Drones | $LINK_Launcher | $LINK_Bomber | $LINK_Shooter | $LINK_Utility;


//Used to determine is we allow a ship to be built. it needs a gun
$WEAPON_COMPONENTS = $LINK_Launcher | $LINK_Bomber | $LINK_Shooter | $WEAPON_DroneHiveLauncher; 

//weapons that can tell a ship what is best firing rotation.
$FIXED_AI_WEAPONS = $WEAPON_BeamEmitter | $WEAPON_ProjectileCannon | $WEAPON_CrewProjectileCannon | $WEAPON_MiningBeamEmitter;


//Link images for the design screen 
//once a weapon is selected, i will use its image.  this is more of an indicator of what "Can" go in the slot, should be iconic
$LINKIMAGES[$LINK_Launcher, $SLOT_SMALL]  = "shipconIcon_T_launcherImageMap 16 16";
$LINKIMAGES[$LINK_Launcher, $SLOT_MEDIUM] = "shipconIcon_T_launcherImageMap 24 24";
$LINKIMAGES[$LINK_Launcher, $SLOT_LARGE]  = "shipconIcon_T_launcherImageMap 32 32";
$LINKIMAGES[$LINK_Launcher, $SLOT_HUGE]   = "shipconIcon_T_launcherImageMap 48 48";

$LINKIMAGES[$LINK_Bomber, $SLOT_SMALL]    = "shipconIcon_T_bombImageMap 16 16";
$LINKIMAGES[$LINK_Bomber, $SLOT_MEDIUM]   = "shipconIcon_T_bombImageMap 24 24";
$LINKIMAGES[$LINK_Bomber, $SLOT_LARGE]    = "shipconIcon_T_bombImageMap 32 32";
$LINKIMAGES[$LINK_Bomber, $SLOT_HUGE]     = "shipconIcon_T_bombImageMap 48 48";

$LINKIMAGES[$LINK_Shooter, $SLOT_SMALL]   = "shipconIcon_T_shooterImageMap 16 16";
$LINKIMAGES[$LINK_Shooter, $SLOT_MEDIUM]  = "shipconIcon_T_shooterImageMap 24 24";
$LINKIMAGES[$LINK_Shooter, $SLOT_LARGE]   = "shipconIcon_T_shooterImageMap 32 32";
$LINKIMAGES[$LINK_Shooter, $SLOT_HUGE]    = "shipconIcon_T_shooterImageMap 48 48";

$LINKIMAGES[$LINK_Utility, $SLOT_SMALL]   = "shipconIcon_T_utilityImageMap 16 16";
$LINKIMAGES[$LINK_Utility, $SLOT_MEDIUM]  = "shipconIcon_T_utilityImageMap 24 24";
$LINKIMAGES[$LINK_Utility, $SLOT_LARGE]   = "shipconIcon_T_utilityImageMap 32 32";
$LINKIMAGES[$LINK_Utility, $SLOT_HUGE]    = "shipconIcon_T_utilityImageMap 48 48";


//RLB, Need mining image
$LINKIMAGES[$LINK_Mining, $SLOT_SMALL]    = "shipconIcon_T_miningImageMap 16 16";
$LINKIMAGES[$LINK_Mining, $SLOT_MEDIUM]   = "shipconIcon_T_miningImageMap 24 24";
$LINKIMAGES[$LINK_Mining, $SLOT_LARGE]    = "shipconIcon_T_miningImageMap 32 32";
$LINKIMAGES[$LINK_Mining, $SLOT_HUGE]     = "shipconIcon_T_miningImageMap 48 48";

//RLB, Need Drones image
$LINKIMAGES[$LINK_Drones, $SLOT_SMALL]    = "shipconIcon_T_droneImageMap 16 16";
$LINKIMAGES[$LINK_Drones, $SLOT_MEDIUM]   = "shipconIcon_T_droneImageMap 24 24";
$LINKIMAGES[$LINK_Drones, $SLOT_LARGE]    = "shipconIcon_T_droneImageMap 32 32";
$LINKIMAGES[$LINK_Drones, $SLOT_HUGE]     = "shipconIcon_T_droneImageMap 48 48";


$LINKIMAGES[$LINK_Universal, $SLOT_SMALL] = "shipconIcon_T_universalImageMap 16 16";
$LINKIMAGES[$LINK_Universal, $SLOT_MEDIUM]= "shipconIcon_T_universalImageMap 24 24";
$LINKIMAGES[$LINK_Universal, $SLOT_LARGE] = "shipconIcon_T_universalImageMap 32 32";
$LINKIMAGES[$LINK_Universal, $SLOT_HUGE]  = "shipconIcon_T_universalImageMap 48 48";

//This is the turret ball.
$LINKIMAGES[$LINK_Turret, $SLOT_SMALL]    = "shipconIcon_T_turretImageMap 30 30";
$LINKIMAGES[$LINK_Turret, $SLOT_MEDIUM]   = "shipconIcon_T_turretImageMap 40 40";
$LINKIMAGES[$LINK_Turret, $SLOT_LARGE]    = "shipconIcon_T_turretImageMap 50 50";
$LINKIMAGES[$LINK_Turret, $SLOT_HUGE]     = "shipconIcon_T_turretImageMap 65 65";

function LinkImage_GetImageMap(%linkType, %size)
{
   return getWord($LINKIMAGES[%linkType, %size], 0);
}

function LinkImage_GetSize(%linkType, %size, %hullSize)
{
   %baseSize = getWords($LINKIMAGES[%linkType, %size], 1, 2);
   if ( %size <= %hullSize + 1 )
      return %baseSize;
   
   if ( %hullSize >= $HULLTYPE_MEDIUM )
      return %baseSize; //normal sizing ok
   
   %scale = 1.0;
   while ( %size > %hullSize )
   {
      %size--;      
      %scale *= 0.85;      
   }
   %newSize = t2dVectorScale(%baseSize, %scale);   
}

////////////////////////////////////////////
// For weapon automation ///////////////////
////////////////////////////////////////////

function WeaponDatablock::HasAutomationData(%this)
{
   return %this.GetAutomatedTargetCollisionGroups() !$= "";
}


function WeaponDatablock::GetAutomatedTargetCollisionGroups(%this)
{
   return %this.automatedTargetCollisionGroups;
}


function WeaponDatablock::GetAutomatedTargetPriority(%this)
{
   %priority = %this.automatedTargetPriority;
   if ( %priority $= "" )
      %priority = $AutomatedPriority_Any;
      
   return %priority;
}


//////////////////////////////////////////////////
// Hooking up weapon mounts to tactics ///////////
//////////////////////////////////////////////////
//So player can deny ai from firing certain weapon types. 


$TacticWeaponGroups["TP_Beams"]       = $WEAPON_BeamEmitter;
$TacticWeaponGroups["TP_Cannons"]     = $WEAPON_ProjectileCannon;
$TacticWeaponGroups["TP_CrewCannons"] = $WEAPON_CrewProjectileCannon;
$TacticWeaponGroups["TP_Launchers"]   = $WEAPON_MissileLauncher | $WEAPON_TorpedoLauncher | $WEAPON_RocketLauncher | $WEAPON_MassBombLauncher | $WEAPON_MineDropperLauncher | $WEAPON_DeployableTurretLauncher;


$TacticWeaponGroups_Lookup[$WEAPON_BeamEmitter]          = "TP_Beams";
$TacticWeaponGroups_Lookup[$WEAPON_ProjectileCannon]     = "TP_Cannons";
$TacticWeaponGroups_Lookup[$WEAPON_CrewProjectileCannon] = "TP_CrewCannons";
$TacticWeaponGroups_Lookup[$WEAPON_MissileLauncher]      = "TP_Launchers";
$TacticWeaponGroups_Lookup[$WEAPON_TorpedoLauncher]      = "TP_Launchers";
$TacticWeaponGroups_Lookup[$WEAPON_RocketLauncher]       = "TP_Launchers";
$TacticWeaponGroups_Lookup[$WEAPON_MassBombLauncher]     = "TP_Launchers";
$TacticWeaponGroups_Lookup[$WEAPON_MineDropperLauncher]  = "TP_Launchers";
$TacticWeaponGroups_Lookup[$WEAPON_DeployableTurretLauncher]  = "TP_Launchers";


function GetWeaponSubTypeFromTacticID(%tacticID)
{
   %bits = $TacticWeaponGroups[%tacticID];
   if ( %bits $= "" )
      return 0;
   
   return %bits;
}

function GetTacticIDFromWeaponSubType(%weaponSubType)
{
   %tacticID = $TacticWeaponGroups_Lookup[%weaponSubType];
   if ( %tacticID $= "" )
      return "TP_Invalid";
   
   return %tacticID;
}







