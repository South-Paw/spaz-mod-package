//Mine Dropper Launcher Datablocks


function MineDropperLauncherDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "MineDropperLauncherBase" )
      return;
            
   Parent::onAdd(%this);            
}


datablock MineDropperLauncherDatablock(MineDropperLauncherBase : WeaponBase) 
{         
   componentType      = "External";
   componentSubType   = $WEAPON_MineDropperLauncher;
   isAutomated        = false;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   researchDatablock    = "MineResearch";
   
   componentButtonColor = "Basic";
   
   purchaseTutorial     = "PT_minesBasic";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_None;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Med;  //long range lasers and projectiles
   threat_Short = $WT_None; //$WT_None $WT_Low $WT_Med $WT_High
};

//////////////////////////////////////////////
// Smalls ////////////////////////////////////
//////////////////////////////////////////////

datablock MineDropperLauncherDatablock(Dropper_Small_Explosive_Launcher : MineDropperLauncherBase) 
{    
   friendlyName = "Small Explosive Minefield";
     
   reloadMS           = "7000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "Dropper_Small_Explosive";
      
   componentSize      = $SLOT_MEDIUM;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_basicMines";
      
   WeaponMountDatablock = "MineDropperLauncherMount";   
  
   RUCost                      = 10;

   
   componentButtonColor        = "Basic";
   purchaseTutorial     = "PT_minesBasic";
};


datablock MineDropperLauncherDatablock(Dropper_Small_Civ_Launcher : Dropper_Small_Explosive_Launcher) 
{
   friendlyName = "Small Civilian Minefield";
   
   AmmoType           = "Dropper_Small_Civ";
   

   
   componentButtonColor        = "Civ";
   purchaseTutorial     = "PT_minesSurplus";
};


datablock MineDropperLauncherDatablock(Dropper_Small_Ion_Launcher : Dropper_Small_Explosive_Launcher) 
{
   friendlyName = "Small Ion Minefield";
   componentIconGraphic        = "shipconIcon_empMines";
   
   AmmoType           = "Dropper_Small_Ion";
   
   componentButtonColor        = "Improved";
   purchaseTutorial     = "PT_minesIon";
};


datablock MineDropperLauncherDatablock(Dropper_Small_Scanner_Launcher : Dropper_Small_Explosive_Launcher) 
{
   friendlyName = "Small Scanner Minefield";
   componentIconGraphic        = "shipconIcon_scanMines";
   
   AmmoType             = "Dropper_Small_Scanner";
   
   componentButtonColor = "Improved";
   purchaseTutorial     = "PT_minesScan";
};


datablock MineDropperLauncherDatablock(Dropper_Small_MicroLaser_Launcher : Dropper_Small_Explosive_Launcher) 
{
   friendlyName = "Small Micro Laser Minefield";
   componentIconGraphic        = "shipconIcon_shooterMines";
   
   AmmoType           = "Dropper_Small_MicroLaser";
   
   componentButtonColor = "Advanced";
   purchaseTutorial     = "PT_minesShooter";
};

datablock MineDropperLauncherDatablock(Dropper_Small_Random_Launcher : Dropper_Small_Explosive_Launcher) 
{
   friendlyName = "Small Random Minefield";
   componentIconGraphic        = "shipconIcon_allMines";
   
   AmmoType           = "Dropper_Small_Random";
   
   componentButtonColor = "Advanced";
   purchaseTutorial     = "PT_minesAll";
};



//////////////////////////////////////////////
// Larges ////////////////////////////////////
//////////////////////////////////////////////


datablock MineDropperLauncherDatablock(Dropper_Large_Explosive_Launcher : MineDropperLauncherBase) 
{    
   friendlyName = "Large Explosive Minefield";
     
   reloadMS           = "7000";  //MS to reload after old minefield destroyed. 
   AmmoType           = "Dropper_Large_Explosive";
      
   componentSize      = $SLOT_LARGE;    
   powerConsumption   = "1";

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_basicMines";
      
   WeaponMountDatablock = "MineDropperLauncherMount";   
  
   RUCost                      = 50;

   
   componentButtonColor        = "Basic";
   purchaseTutorial     = "PT_minesBasic";
};


datablock MineDropperLauncherDatablock(Dropper_Large_Civ_Launcher : Dropper_Large_Explosive_Launcher) 
{
   friendlyName = "Large Civilian Minefield";
   
   AmmoType           = "Dropper_Large_Civ";
   

   
   componentButtonColor        = "Civ";
   purchaseTutorial     = "PT_minesSurplus";
};


datablock MineDropperLauncherDatablock(Dropper_Large_Ion_Launcher : Dropper_Large_Explosive_Launcher) 
{
   friendlyName = "Large Ion Minefield";
   componentIconGraphic        = "shipconIcon_empMines";
   
   AmmoType           = "Dropper_Large_Ion";
   
   componentButtonColor        = "Improved";
   purchaseTutorial     = "PT_minesIon";
};

datablock MineDropperLauncherDatablock(Dropper_Large_Scanner_Launcher : Dropper_Large_Explosive_Launcher) 
{
   friendlyName = "Large Scanner Minefield";
   componentIconGraphic        = "shipconIcon_scanMines";
   
   AmmoType             = "Dropper_Large_Scanner";
   
   componentButtonColor = "Improved";
   purchaseTutorial     = "PT_minesScan";
};

datablock MineDropperLauncherDatablock(Dropper_Large_MicroLaser_Launcher : Dropper_Large_Explosive_Launcher) 
{
   friendlyName = "Large Micro Laser Minefield";
   componentIconGraphic        = "shipconIcon_shooterMines";
   
   AmmoType           = "Dropper_Large_MicroLaser";
   
   componentButtonColor = "Advanced";
   purchaseTutorial     = "PT_minesShooter";
};

datablock MineDropperLauncherDatablock(Dropper_Large_Random_Launcher : Dropper_Large_Explosive_Launcher) 
{
   friendlyName = "Large Random Minefield";
   componentIconGraphic        = "shipconIcon_allMines";
   
   AmmoType           = "Dropper_Large_Random";
   
   componentButtonColor = "Advanced";
   purchaseTutorial     = "PT_minesAll";
};
