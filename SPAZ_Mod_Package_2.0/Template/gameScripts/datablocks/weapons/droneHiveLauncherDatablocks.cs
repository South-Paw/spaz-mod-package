

function DroneHiveLauncherDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "DroneHiveLauncherBase" )
      return;
            
   Parent::onAdd(%this);            
}



////////////////////////////////////////////////
// PROCEDURAL STATS  ///////////////////////////
////////////////////////////////////////////////
//These are the numbers for the basic military version. 

//$DRONEHIVEDATA["PowerConsumption", $HULLTYPE_SMALL]        = 0.250;
//$DRONEHIVEDATA["PowerConsumption", $HULLTYPE_MEDIUM]       = 0.333;    
$DRONEHIVEDATA["PowerConsumption", $HULLTYPE_LARGE]          = 0.250;  //should have no power consume. 
//$DRONEHIVEDATA["PowerConsumption", $HULLTYPE_HUGE]         = 0.500;   
//$DRONEHIVEDATA["PowerConsumption", $HULLTYPE_MOTHERSHIP]   = 0;   
//$DRONEHIVEDATA["PowerConsumption", $HULLTYPE_STATION]      = 0;

//$DRONEHIVEDATA["ResourceCost", $HULLTYPE_SMALL]                = 2;  
//$DRONEHIVEDATA["ResourceCost", $HULLTYPE_MEDIUM]               = 10;    
$DRONEHIVEDATA["ResourceCost", $HULLTYPE_LARGE]                  = 50;   
//$DRONEHIVEDATA["ResourceCost", $HULLTYPE_HUGE]                 = 250;   
//$DRONEHIVEDATA["ResourceCost", $HULLTYPE_MOTHERSHIP]           = 0; 
//$DRONEHIVEDATA["ResourceCost", $HULLTYPE_STATION]              = 0;


function DroneHiveLauncherDatablock::GetProceduralData(%this, %statID)
{
   %datum = $DRONEHIVEDATA[%statID, %this.hullType];
   if ( %datum $= "" )
      echo("$DRONEHIVEDATA::GetProceduralData WARNING: Trying to get invalid procedural Stat!" SPC %statID);
   
   return %datum;
}


////////////////////////
// $DRONEHIVEMULTS ////////
////////////////////////
//This is how we keep technology consistent between categories. 

$DRONEHIVEMULTS["PowerConsumption", "FIGHTER"]        = 1.000;  
$DRONEHIVEMULTS["PowerConsumption", "ZAPPER"]         = 2.000;
$DRONEHIVEMULTS["PowerConsumption", "BOMBER"]         = 3.000;
$DRONEHIVEMULTS["PowerConsumption", "FIGHTER_C"]      = 2.000;
$DRONEHIVEMULTS["PowerConsumption", "ZAPPER_C"]       = 4.000;
$DRONEHIVEMULTS["PowerConsumption", "BOMBER_C"]       = 8.000;
$DRONEHIVEMULTS["PowerConsumption", "ZOMBIE"]         = 0;

$DRONEHIVEMULTS["ResourceCost", "FIGHTER"]        = 1.000;  
$DRONEHIVEMULTS["ResourceCost", "ZAPPER"]         = 2.000;
$DRONEHIVEMULTS["ResourceCost", "BOMBER"]         = 3.000;
$DRONEHIVEMULTS["ResourceCost", "FIGHTER_C"]      = 2.000;
$DRONEHIVEMULTS["ResourceCost", "ZAPPER_C"]       = 4.000;
$DRONEHIVEMULTS["ResourceCost", "BOMBER_C"]       = 8.000;
$DRONEHIVEMULTS["ResourceCost", "ZOMBIE"]         = 0;

function DroneHiveLauncherDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $DRONEHIVEMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("$DRONEHIVEMULTS::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}


////////////////////////////////////////////////
// BaseClass ///////////////////////////////////
////////////////////////////////////////////////


datablock DroneHiveLauncherDatablock(DroneHiveLauncherBase : WeaponBase) 
{         
   componentType      = "External";
   componentSubType   = $WEAPON_DroneHiveLauncher;
   isAutomated        = false;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 0;
   
   reloadMS           = "10000"; //NOTE: usused, but need high number to prevent a reload while a ship is exploding 
   
   //Like missiles, only consume power while constructing drones.      
   componentSize      = $SLOT_LARGE;    
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

   WeaponMountDatablock = "DefaultWeaponMount";
   researchDatablock    = "DroneResearch";
   
   componentButtonColor        = "Basic";
   
   purchaseTutorial = "PT_droneFighter";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_Med;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Med;  //long range lasers and projectiles
   threat_Short = $WT_Low; //$WT_None $WT_Low $WT_Med $WT_High
};



///////////////////////////////////////////////////////
//fighter //////////////////////////////////////////////
///////////////////////////////////////////////////////

datablock DroneHiveLauncherDatablock(HiveLauncher_Fighter : DroneHiveLauncherBase) 
{    
   friendlyName = "Fighter Launcher";     
   
   AmmoType           = "DroneHive_Fighter";
      
   myType = "FIGHTER"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_fighterDrone";
   
   WeaponMountDatablock = "DroneHiveLauncherMount";      
   

   
   componentButtonColor        = "Civ";
   
   purchaseTutorial = "PT_droneFighter";
};

datablock DroneHiveLauncherDatablock(HiveLauncher_Fighter_Cloaked : HiveLauncher_Fighter) 
{    
   friendlyName          = "Cloaked Fighter Launcher";
   AmmoType              = "DroneHive_Fighter_Cloaked";
   componentButtonColor  = "Basic";
   

   
   myType = "FIGHTER_C"; //used for procedural systmes.
   
   purchaseTutorial = "PT_droneFighter_Cloaked";
};

///////////////////////////////////////////////////////
//zapper //////////////////////////////////////////////
///////////////////////////////////////////////////////

datablock DroneHiveLauncherDatablock(HiveLauncher_Zapper : DroneHiveLauncherBase) 
{    
   friendlyName = "Zapper Launcher";
        
   AmmoType           = "DroneHive_Zapper";
      
   componentIconGraphic        = "shipconIcon_zapperDrone";
   
   WeaponMountDatablock = "DroneHiveLauncherMount";   
      

   
   componentButtonColor        = "Improved";
   
   myType = "ZAPPER"; //used for procedural systmes.
   
   purchaseTutorial = "PT_droneZapper";
};

datablock DroneHiveLauncherDatablock(HiveLauncher_Zapper_Cloaked : HiveLauncher_Zapper) 
{    
   friendlyName                = "Cloaked Zapper Launcher";
   AmmoType                    = "DroneHive_Zapper_Cloaked";
   componentButtonColor        = "Improved";
   
   myType = "ZAPPER_C"; //used for procedural systmes.
   
   componentButtonColor        = "Advanced";
   
   purchaseTutorial = "PT_droneZapper_Cloaked";
};

///////////////////////////////////////////////////////
//bomber //////////////////////////////////////////////
///////////////////////////////////////////////////////

datablock DroneHiveLauncherDatablock(HiveLauncher_Bomber : DroneHiveLauncherBase) 
{    
   friendlyName = "Bomber Launcher";     
   
   AmmoType           = "DroneHive_Bomber";
      
   componentIconGraphic        = "shipconIcon_bomberDrone";
   
   WeaponMountDatablock = "DroneHiveLauncherMount";   
   

   
   componentButtonColor        = "Improved";
   
   myType = "BOMBER"; //used for procedural systmes.
         
   purchaseTutorial = "PT_droneBomber";
};


datablock DroneHiveLauncherDatablock(HiveLauncher_Bomber_Cloaked : HiveLauncher_Bomber) 
{    
   friendlyName                = "Cloaked Bomber Launcher";
   AmmoType                    = "DroneHive_Bomber_Cloaked";
   componentButtonColor        = "Advanced";
   
   myType = "BOMBER_C"; //used for procedural systmes.
   
   componentButtonColor        = "Advanced";
   
   purchaseTutorial = "PT_droneBomber_Cloaked";
};

///////////////////////////////////////////////////////
// civ ////////////////////////////////////////////////
///////////////////////////////////////////////////////

//NOT FOR PLAYER
datablock DroneHiveLauncherDatablock(HiveLauncher_Civ : DroneHiveLauncherBase) 
{    
   friendlyName           = "Civilian Launcher";     
   AmmoType               = "DroneHive_Civ"; 
   componentIconGraphic   = "shipconIcon_bomberDrone";
   WeaponMountDatablock   = "DroneHiveLauncherMount";   
   
   componentButtonColor        = "Civ";

   myType = "FIGHTER"; //used for procedural systmes.
};


///////////////////////////////////////////////////////
// Zombie /////////////////////////////////////////////
///////////////////////////////////////////////////////

datablock DroneHiveLauncherDatablock(AttackHive_Zombie : DroneHiveLauncherBase) 
{    
   friendlyName = "Small Zombie Attack Hive";   
        
   AmmoType           = "DroneHive_Zombie";        
   
   componentSize      = $SLOT_MEDIUM;    
   
   componentIconGraphic        = "shipconIcon_mine";
      
   WeaponMountDatablock = "DroneHiveLauncherMount";   
        
   componentButtonColor        = "Basic";
   

   
   myType = "ZOMBIE"; //used for procedural systmes.
};





















