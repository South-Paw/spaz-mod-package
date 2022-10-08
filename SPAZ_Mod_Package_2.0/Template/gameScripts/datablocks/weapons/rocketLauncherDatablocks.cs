////////////////////////////////////////////////////////////////////////
// Rocket Launchers //////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////
function RocketLauncherDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "RocketLauncherBase" )
      return;
            
   Parent::onAdd(%this);            
}



datablock RocketLauncherDatablock(RocketLauncherBase : WeaponBase) 
{         
   componentType      = "External";
   componentSubType   = $WEAPON_RocketLauncher; 
   isAutomated        = false;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   researchDatablock = "MissileResearch";
   
   componentButtonColor = "Improved";
   
   purchaseTutorial = "PT_srm";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_None;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Low;  //long range lasers and projectiles
   threat_Short = $WT_Med; //$WT_None $WT_Low $WT_Med $WT_High
};

/////////////////////////////////////////////////////////////
//SRMS //////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////


//Rocket Launchers are Actually SRM pods.
datablock RocketLauncherDatablock(SmallRocketLauncher : RocketLauncherBase) 
{      
   friendlyName = "Small SRM Pod";
   
   ammoType           = "SRM_Pod_Small";
   
   myType = "SRM_POD"; //used for procedural systmes. 
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
     
   componentSize      = $SLOT_SMALL;    
     
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_rockets";
 
   WeaponMountDatablock = "SmallMissileMount"; 
   componentButtonColor = "Improved";
};
datablock RocketLauncherDatablock(SmallHunterLauncher : SmallRocketLauncher) 
{   
   ammoType = "HUNTER_Pod_Small";
   myType = "HUNTER_POD"; //used for procedural systmes. 
   componentButtonColor = "Advanced";
   purchaseTutorial = "PT_HunterSRM";
   componentIconGraphic        = "shipconIcon_hunterSRM";
};


datablock RocketLauncherDatablock(MediumRocketLauncher : RocketLauncherBase) 
{      
   friendlyName = "Medium SRM Pod";
   
   myType = "SRM_POD"; //used for procedural systmes. 
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption

   ammoType           = "SRM_Pod_Medium";
     
   componentSize      = $SLOT_MEDIUM;    
     
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_rockets";
       
   WeaponMountDatablock = "MediumMissileMount"; 
   componentButtonColor = "Improved";
};
datablock RocketLauncherDatablock(MediumHunterLauncher : MediumRocketLauncher) 
{   
   ammoType = "HUNTER_Pod_Medium";
   myType = "HUNTER_POD"; //used for procedural systmes. 
   componentButtonColor = "Advanced";
   purchaseTutorial = "PT_HunterSRM";
   componentIconGraphic        = "shipconIcon_hunterSRM";
};


datablock RocketLauncherDatablock(LargeRocketLauncher : RocketLauncherBase) 
{      
   friendlyName = "Large SRM Pod";
   
   myType = "SRM_POD"; //used for procedural systmes. 
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

   ammoType           = "SRM_Pod_Large";
     
   componentSize      = $SLOT_LARGE;    
     
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_rockets";
       
   WeaponMountDatablock = "LargeMissileMount"; 
   componentButtonColor = "Improved";
};
datablock RocketLauncherDatablock(LargeHunterLauncher : LargeRocketLauncher) 
{   
   ammoType = "HUNTER_Pod_Large";
   myType = "HUNTER_POD"; //used for procedural systmes. 
   componentButtonColor = "Advanced";
   purchaseTutorial = "PT_HunterSRM";
   componentIconGraphic        = "shipconIcon_hunterSRM";
};


datablock RocketLauncherDatablock(HugeRocketLauncher : RocketLauncherBase) 
{      
   friendlyName = "Huge SRM Pod";
   
   myType = "SRM_POD"; //used for procedural systmes. 
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption

   ammoType           = "SRM_Pod_Huge";
     
   componentSize      = $SLOT_HUGE;    
     
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_rockets";
       
   WeaponMountDatablock = "HugeMissileMount"; 
   componentButtonColor = "Improved";
};
datablock RocketLauncherDatablock(HugeHunterLauncher : HugeRocketLauncher) 
{   
   ammoType = "HUNTER_Pod_Huge";
   myType = "HUNTER_POD"; //used for procedural systmes. 
   componentButtonColor = "Advanced";
   purchaseTutorial = "PT_HunterSRM";
   componentIconGraphic        = "shipconIcon_hunterSRM";
};

