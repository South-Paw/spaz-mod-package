//Mine Dropper Launcher Datablocks


function DeployableTurretLauncherDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "DeployableTurretLauncherBase" )
      return;
            
   Parent::onAdd(%this);            
}


datablock DeployableTurretLauncherDatablock(DeployableTurretLauncherBase : WeaponBase) 
{         
   componentType      = "External";
   componentSubType   = $WEAPON_DeployableTurretLauncher;
   isAutomated        = false;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   maxCount           = 1;  
   
   WeaponMountDatablock = "DeployableTurretLauncherMount";
   researchDatablock    = "TurretResearch";
   
   componentButtonColor = "Basic";
   
   purchaseTutorial     = "PT_deployableTurretsBasic";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_None;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Med;  //long range lasers and projectiles
   threat_Short = $WT_High; //$WT_None $WT_Low $WT_Med $WT_High
};

//////////////////////////////////////////////
// Medium ////////////////////////////////////
//////////////////////////////////////////////
datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_Surplus_M : DeployableTurretLauncherBase) 
{    
   friendlyName = "Medium Deployable Surplus Turret";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "DeployableTurretContainer_Surplus";
   maxCount           = 1;   
      
      
      
   componentSize      = $SLOT_MEDIUM;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_deploy_beam";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 10;

   
   componentButtonColor = "Civ";
   purchaseTutorial     = "PT_deployableTurretsSurplus";
};


datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_Basic_M : DeployableTurretLauncherBase) 
{    
   friendlyName = "Medium Deployable Basic Turret";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "DeployableTurretContainer_Basic";
   maxCount           = 1;   
      
      
      
   componentSize      = $SLOT_MEDIUM;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_deploy_cannon";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 15;

   
   componentButtonColor = "Basic";
   purchaseTutorial     = "PT_deployableTurretsBasic";
};

datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_Ion_M : DeployableTurretLauncherBase) 
{    
   friendlyName = "Medium Deployable Ion Turret";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "DeployableTurretContainer_Ion";
   maxCount           = 1;   
      
      
      
   componentSize      = $SLOT_MEDIUM;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_deploy_ion";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 20;

   
   componentButtonColor = "Improved";
   purchaseTutorial     = "PT_deployableTurretsIon";
};

datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_Leech_M : DeployableTurretLauncherBase) 
{    
   friendlyName = "Medium Deployable Leech Turret";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "DeployableTurretContainer_Leech";
   maxCount           = 1;   
      
      
      
   componentSize      = $SLOT_MEDIUM;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_deploy_leech";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 20;

   
   componentButtonColor = "Improved";
   purchaseTutorial     = "PT_deployableTurretsLeech";
};

datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_TorpRack_M : DeployableTurretLauncherBase) 
{    
   friendlyName = "Medium Deployable Torpedo Rack";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "DeployableTurretContainer_TorpRack";
   maxCount           = 1;   
      
   componentSize      = $SLOT_MEDIUM;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_deploy_torp";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 25;

   
   componentButtonColor = "Advanced";
   purchaseTutorial     = "PT_deployableTurretsTorpRack";
};

datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_BattleStation_M : DeployableTurretLauncherBase) 
{    
   friendlyName = "Medium Battle Station";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "DeployableTurretContainer_BattleStation";
   maxCount           = 1;   
      
      
      
   componentSize      = $SLOT_MEDIUM;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_deploy_rapid";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 25;

   
   componentButtonColor = "Advanced";
   purchaseTutorial     = "PT_deployableTurretsBattleStation";
};

//////////////////////////////////////////////
// Large /////////////////////////////////////
//////////////////////////////////////////////
datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_Surplus_L : DeployableTurretLauncherBase) 
{    
   friendlyName = "Large Deployable Surplus Turret";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "DeployableTurretContainer_Surplus";
   maxCount           = 2;  
   
   componentSize      = $SLOT_LARGE;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_deploy_beam";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 20;

   
   componentButtonColor = "Civ";
   purchaseTutorial     = "PT_deployableTurretsSurplus";
};


datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_Basic_L : DeployableTurretLauncherBase) 
{    
   friendlyName = "Large Deployable Basic Turret";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType             = "DeployableTurretContainer_Basic";
   
   
   maxCount           = 2;  
   
   componentSize      = $SLOT_LARGE;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_deploy_cannon";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 30;

   
   componentButtonColor = "Basic";
   purchaseTutorial     = "PT_deployableTurretsBasic";
};

datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_Ion_L : DeployableTurretLauncherBase) 
{    
   friendlyName = "Large Deployable Ion Turret";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType             = "DeployableTurretContainer_Ion";
   
   
   maxCount           = 2;  
   
   componentSize      = $SLOT_LARGE;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_deploy_ion";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 40;

   
   componentButtonColor = "Improved";
   purchaseTutorial     = "PT_deployableTurretsIon";
};

datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_Leech_L : DeployableTurretLauncherBase) 
{    
   friendlyName = "Large Deployable Leech Turret";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType             = "DeployableTurretContainer_Leech";
   
   
   maxCount           = 2;  
   
   componentSize      = $SLOT_LARGE;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_deploy_leech";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 40;

   
   componentButtonColor = "Improved";
   purchaseTutorial     = "PT_deployableTurretsLeech";
};

datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_TorpRack_L : DeployableTurretLauncherBase) 
{    
   friendlyName = "Large Deployable Torpedo Rack";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType             = "DeployableTurretContainer_TorpRack";
   
   
   maxCount           = 2;  
   
   componentSize      = $SLOT_LARGE;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_deploy_torp";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 50;

   
   componentButtonColor = "Advanced";
   purchaseTutorial     = "PT_deployableTurretsTorpRack";
};

datablock DeployableTurretLauncherDatablock(DeployableTurretLauncher_BattleStation_L : DeployableTurretLauncherBase) 
{    
   friendlyName = "Large Battle Station";
     
   reloadMS           = "3000";  //MS to reload after old minefield destroyed. 
   AmmoType             = "DeployableTurretContainer_BattleStation";
   
   
   maxCount           = 2;  
   
   componentSize      = $SLOT_LARGE;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_deploy_rapid";
      
   WeaponMountDatablock = "DeployableTurretLauncherMount";   
  
   RUCost                      = 50;

   
   componentButtonColor = "Advanced";
   purchaseTutorial     = "PT_deployableTurretsBattleStation";
};


