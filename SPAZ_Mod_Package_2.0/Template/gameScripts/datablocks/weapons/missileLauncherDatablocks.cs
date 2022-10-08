

function MissileLauncherDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "MissileLauncherBase" )
      return;
            
   Parent::onAdd(%this);            
}



////////////////////////////////////////////////
// PROCEDURAL STATS  ///////////////////////////
////////////////////////////////////////////////
//These are the numbers for the basic military version. 

$LAUNCHERDATA["PowerConsumption", $HULLTYPE_SMALL]        = 0.150;
$LAUNCHERDATA["PowerConsumption", $HULLTYPE_MEDIUM]       = 0.150;    
$LAUNCHERDATA["PowerConsumption", $HULLTYPE_LARGE]        = 0.150;  
$LAUNCHERDATA["PowerConsumption", $HULLTYPE_HUGE]         = 0.150;   

$LAUNCHERDATA["ResourceCost", $HULLTYPE_SMALL]            = 2;  
$LAUNCHERDATA["ResourceCost", $HULLTYPE_MEDIUM]           = 6;    
$LAUNCHERDATA["ResourceCost", $HULLTYPE_LARGE]            = 20;   
$LAUNCHERDATA["ResourceCost", $HULLTYPE_HUGE]             = 60;   

$LAUNCHERDATA["reloadMS", $HULLTYPE_SMALL]                = 5000;  
$LAUNCHERDATA["reloadMS", $HULLTYPE_MEDIUM]               = 6000;    
$LAUNCHERDATA["reloadMS", $HULLTYPE_LARGE]                = 8500;   
$LAUNCHERDATA["reloadMS", $HULLTYPE_HUGE]                 = 12000;   

function MissileLauncherDatablock::GetProceduralData(%this, %statID)
{
   %datum = $LAUNCHERDATA[%statID, %this.hullType];
   if ( %datum $= "" )
      echo("$LAUNCHERDATA::GetProceduralData WARNING: Trying to get invalid procedural Stat!" SPC %statID);
   
   return %datum;
}


////////////////////////
// $EMITTERMULTS ////////
////////////////////////
//This is how we keep technology consistent between categories. 

$LAUNCHERMULTS["PowerConsumption", "BASIC"]      = 1.000;
$LAUNCHERMULTS["PowerConsumption", "CIV"]        = 0.750;
$LAUNCHERMULTS["PowerConsumption", "HUNTER_POD"] = 0.500; //long recharge time
$LAUNCHERMULTS["PowerConsumption", "GRAV"]       = 1.500;
$LAUNCHERMULTS["PowerConsumption", "SRM_POD"]    = 1.000;
$LAUNCHERMULTS["PowerConsumption", "MB_EXP"]     = 2.500;
$LAUNCHERMULTS["PowerConsumption", "MB_HEAT"]    = 2.500;
$LAUNCHERMULTS["PowerConsumption", "MB_ION"]     = 2.500;
$LAUNCHERMULTS["PowerConsumption", "MB_COR"]     = 2.500;
$LAUNCHERMULTS["PowerConsumption", "ZOMBIE"]     = 0.000;

$LAUNCHERMULTS["ResourceCost", "BASIC"]          = 1.000;
$LAUNCHERMULTS["ResourceCost", "CIV"]            = 0.500;  
$LAUNCHERMULTS["ResourceCost", "HUNTER_POD"]     = 2.000;  
$LAUNCHERMULTS["ResourceCost", "GRAV"]           = 1.500;
$LAUNCHERMULTS["ResourceCost", "SRM_POD"]        = 1.500;
$LAUNCHERMULTS["ResourceCost", "MB_EXP"]         = 2.500;
$LAUNCHERMULTS["ResourceCost", "MB_HEAT"]        = 1.500;
$LAUNCHERMULTS["ResourceCost", "MB_ION"]         = 3.000;
$LAUNCHERMULTS["ResourceCost", "MB_COR"]         = 5.000;
$LAUNCHERMULTS["ResourceCost", "ZOMBIE"]         = 0.000;

$LAUNCHERMULTS["reloadMS", "BASIC"]              = 1.000; 
$LAUNCHERMULTS["reloadMS", "CIV"]                = 0.500;
$LAUNCHERMULTS["reloadMS", "HUNTER_POD"]         = 1.000;
$LAUNCHERMULTS["reloadMS", "GRAV"]               = 0.667;
$LAUNCHERMULTS["reloadMS", "SRM_POD"]            = 1.500;
$LAUNCHERMULTS["reloadMS", "MB_EXP"]             = 2.000;
$LAUNCHERMULTS["reloadMS", "MB_HEAT"]            = 2.000;
$LAUNCHERMULTS["reloadMS", "MB_ION"]             = 2.000;
$LAUNCHERMULTS["reloadMS", "MB_COR"]             = 2.000;
$LAUNCHERMULTS["reloadMS", "ZOMBIE"]             = 2.000;

function MissileLauncherDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $LAUNCHERMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("$LAUNCHERMULTS::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}


function MissileLauncherDatablock::HandleProceduralStats(%this)
{
   Parent::HandleProceduralStats(%this); //will do power consumption + RU
   
   %this.reloadMS = mRound(%this.GetFinalStat("reloadMS")); 
}


////////////////////////////////////////////////
// BaseClass ///////////////////////////////////
////////////////////////////////////////////////

datablock MissileLauncherDatablock(MissileLauncherBase : WeaponBase) 
{         
   componentType      = "External";
   componentSubType   = $WEAPON_MissileLauncher;
   isAutomated        = false;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   researchDatablock    = "MissileResearch";
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   componentButtonColor        = "Basic";
      
   purchaseTutorial = "PT_missile";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   
   
   //NOTE: dont fiddle with this, it makes boating possible.  else best we will tend to get is sniping.
   //we cant make the long threat high else it will offset lasers too much 
   threat_Long = $WT_Med;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Low;  //long range lasers and projectiles
   threat_Short = $WT_Low; //$WT_None $WT_Low $WT_Med $WT_High
};

/////////////////////////////////////////////
//SMALLS ////////////////////////////////////
/////////////////////////////////////////////

datablock MissileLauncherDatablock(SmallLauncher : MissileLauncherBase) 
{     
   friendlyName = "Small Basic Missiles";
      
   AmmoType           = "SmallMissile";
       
   componentSize      = $SLOT_SMALL;    //1000 blocks
      
   myType = "BASIC"; //used for procedural systmes. 
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
   

   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_missile";

      
   WeaponMountDatablock = "SmallMissileMount";   
 };

datablock MissileLauncherDatablock(SmallLauncher_Civ : SmallLauncher) 
{  
   friendlyName = "Small Civilian Missiles";
   
   purchaseTutorial = "PT_missile_civ";
         
   myType = "CIV"; //used for procedural systmes.      
   
   componentButtonColor        = "Civ";
   AmmoType           = "SmallMissile_Civ";
};

datablock MissileLauncherDatablock(SmallLauncher_GRAV : SmallLauncher) 
{  
   friendlyName = "Small Gravity Missiles";
         
   myType = "GRAV"; //used for procedural systmes.      
   
   componentButtonColor        = "Improved";
   AmmoType           = "SmallMissile_Grav";
   purchaseTutorial = "PT_gravMissile";
   
   componentIconGraphic        = "shipconIcon_gravMissile";
};


/////////////////////////////////////////////
//Mediums ////////////////////////////////////
/////////////////////////////////////////////

datablock MissileLauncherDatablock(MediumLauncher : MissileLauncherBase) 
{  
   friendlyName = "Medium Basic Missiles";
          
   myType = "BASIC"; //used for procedural systmes. 
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
   
   AmmoType          = "MediumMissile";
  
   componentSize      = $SLOT_MEDIUM;    
   
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_missile";
   
   WeaponMountDatablock = "MediumMissileMount";    
};

datablock MissileLauncherDatablock(MediumLauncher_Civ : MediumLauncher) 
{    
   friendlyName = "Medium Civilian Missiles";  
   
   purchaseTutorial = "PT_missile_civ"; 
     
   myType      = "CIV"; //used for procedural systmes. 
  
   componentButtonColor        = "Civ";
   AmmoType           = "MediumMissile_Civ";
};

datablock MissileLauncherDatablock(MediumLauncher_GRAV : MediumLauncher) 
{  
   friendlyName = "Medium Gravity Missiles";
         
   myType = "GRAV"; //used for procedural systmes.      
   
   componentButtonColor        = "Improved";
   AmmoType           = "MediumMissile_Grav";
   purchaseTutorial = "PT_gravMissile";
   
   componentIconGraphic        = "shipconIcon_gravMissile";
};

/////////////////////////////////////////////
//Larges ////////////////////////////////////
/////////////////////////////////////////////
datablock MissileLauncherDatablock(LargeLauncher : MissileLauncherBase) 
{  
   friendlyName = "Large Basic Missiles";
       
   AmmoType          = "LargeMissile";
   
   
   myType = "BASIC"; //used for procedural systmes. 
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_LARGE;    
   

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
   componentIconGraphic        = "shipconIcon_missile";
  
   WeaponMountDatablock = "LargeMissileMount";   
};

datablock MissileLauncherDatablock(LargeLauncher_Civ : LargeLauncher) 
{   
   friendlyName = "Large Civilian Missiles";
   
   purchaseTutorial = "PT_missile_civ"; 
   
   myType = "CIV"; //used for procedural systmes. 
   
   componentButtonColor        = "Civ";
   AmmoType           = "LargeMissile_Civ";
};


datablock MissileLauncherDatablock(LargeLauncher_GRAV : LargeLauncher) 
{  
   friendlyName = "Large Gravity Missiles";
         
   myType = "GRAV"; //used for procedural systmes.      
   
   componentButtonColor        = "Improved";
   AmmoType           = "LargeMissile_Grav";
   purchaseTutorial = "PT_gravMissile";
   
   componentIconGraphic        = "shipconIcon_gravMissile";
};

/////////////////////////////////////////////
//Huges ////////////////////////////////////
/////////////////////////////////////////////
datablock MissileLauncherDatablock(HugeLauncher : MissileLauncherBase) 
{   
   friendlyName = "Huge Basic Missiles";
      
   
   myType             = "BASIC"; //used for procedural systmes. 
   hullType           = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor   = "H_BasicReactor"; //used to determine power consumption

   AmmoType           = "HugeMissile";
      
   componentSize      = $SLOT_HUGE;    
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_missile";
     
   WeaponMountDatablock = "HugeMissileMount";      
};

datablock MissileLauncherDatablock(HugeLauncher_Civ : HugeLauncher) 
{    
   friendlyName = "Huge Civilian Missiles";
     
   purchaseTutorial = "PT_missile_civ";   
   
   myType             = "CIV"; //used for procedural systmes. 
   

   componentButtonColor  = "Civ";
   AmmoType              = "HugeMissile_Civ";
};


datablock MissileLauncherDatablock(HugeLauncher_GRAV : HugeLauncher) 
{  
   friendlyName = "Huge Gravity Missiles";
         
   myType = "GRAV"; //used for procedural systmes.      
   
   componentButtonColor        = "Improved";
   AmmoType           = "HugeMissile_Grav";
   purchaseTutorial = "PT_gravMissile";
   
   componentIconGraphic        = "shipconIcon_gravMissile";
};

/////////////////////////////////////////////
//Specials //////////////////////////////////
/////////////////////////////////////////////

datablock MissileLauncherDatablock(SmallLauncher_Zombie : MissileLauncherBase) 
{     
   friendlyName = "Small Zombie Missiles";
      
   AmmoType           = "ZombieMissile_Small";
  
   myType             = "Zombie";
   hullType           = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor   = "S_BasicReactor"; //used to determine power consumption

   
   componentSize      = $SLOT_SMALL;    //1000 blocks
  
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_missile";
   
   WeaponMountDatablock = "SmallMissileMount";
};

datablock MissileLauncherDatablock(MediumLauncher_Zombie : MissileLauncherBase) 
{    
   friendlyName = "Medium Zombie Missiles";
     
   AmmoType           = "ZombieMissile_Medium";
   
   myType             = "Zombie";
   hullType           = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor   = "M_BasicReactor"; //used to determine power consumption

   
   componentSize      = $SLOT_MEDIUM;    //1000 blocks
  
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_missile";
   
   WeaponMountDatablock = "MediumMissileMount";  
};






















