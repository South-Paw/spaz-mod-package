/////////////////////////////////////////////////////////////////////////
// Mass Bombs ///////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////


function MassBombLauncherDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "MassBombLauncherBase" )
      return;
            
   Parent::onAdd(%this);            
}



datablock MassBombLauncherDatablock(MassBombLauncherBase : WeaponBase) 
{         
   componentType      = "External";
   componentSubType   = $WEAPON_MassBombLauncher; 
   isAutomated        = false;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   researchDatablock = "MassBombResearch";
   
   componentButtonColor        = "Basic";
   
   purchaseTutorial = "PT_massBomb";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_High;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Low;  //long range lasers and projectiles
   threat_Short = $WT_None; //$WT_None $WT_Low $WT_Med $WT_High
};

/////////////////////////////////////////////
// Mediums //////////////////////////////////
/////////////////////////////////////////////

datablock MassBombLauncherDatablock(MassBombLauncher_EXP_Medium : MassBombLauncherBase) 
{    
   friendlyName = "Medium Thermal Bomb Launcher";
     
   ammoType          = "MassBomb_EXP_Medium";
   
   myType = "MB_EXP"; //used for procedural systmes. 
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_MEDIUM;    
 
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;  
   componentIconGraphic        = "shipconIcon_bomb";
    
   WeaponMountDatablock = "MediumMissileMount"; 
   
   purchaseTutorial = "PT_massBomb";  
};


datablock MassBombLauncherDatablock(MassBombLauncher_HEAT_Medium : MassBombLauncher_EXP_Medium) 
{
   friendlyName = "Medium Resonance Bomb Launcher";
   componentIconGraphic = "shipconIcon_bombResonate";
        
   ammoType          = "MassBomb_HEAT_Medium";   
   
   componentButtonColor        = "Civ";
   
   myType = "MB_HEAT"; //used for procedural systmes. 
   
   purchaseTutorial = "PT_heatBomb";  
};

datablock MassBombLauncherDatablock(MassBombLauncher_ION_Medium : MassBombLauncher_EXP_Medium) 
{
   friendlyName = "Medium Ion Bomb Launcher";
   componentIconGraphic = "shipconIcon_bombEMP";
        
   ammoType          = "MassBomb_ION_Medium";   
   
   componentButtonColor        = "Improved";
   
   myType = "MB_ION"; //used for procedural systmes. 
   
   purchaseTutorial = "PT_empBomb";  
};

datablock MassBombLauncherDatablock(MassBombLauncher_CORROSIVE_Medium : MassBombLauncher_EXP_Medium) 
{
   friendlyName = "Medium Corrosive Bomb Launcher";
   componentIconGraphic = "shipconIcon_bombToxic";
        
   ammoType          = "MassBomb_CORROSIVE_Medium";   
   
   componentButtonColor        = "Advanced";
   
   myType = "MB_COR"; //used for procedural systmes.
   
   purchaseTutorial = "PT_toxicBomb";   
};
/////////////////////////////////////////////
// Larges ///////////////////////////////////
/////////////////////////////////////////////


datablock MassBombLauncherDatablock(MassBombLauncher_EXP_Large : MassBombLauncherBase) 
{    
   friendlyName = "Large Mass Bomb Launcher";
   
   ammoType          = "MassBomb_EXP_Large";
   
   myType = "MB_EXP"; //used for procedural systmes. 
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_LARGE;    
     
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_bomb";
      
   WeaponMountDatablock = "LargeMissileMount"; 
   
   purchaseTutorial = "PT_massBomb";    
};

datablock MassBombLauncherDatablock(MassBombLauncher_HEAT_Large : MassBombLauncher_EXP_Large) 
{
   friendlyName = "Large Resonance Bomb Launcher";
   componentIconGraphic = "shipconIcon_bombResonate";
        
   ammoType          = "MassBomb_HEAT_Large";   
   
   componentButtonColor        = "Civ";
   
   myType = "MB_HEAT";
   
   purchaseTutorial = "PT_heatBomb";  
};


datablock MassBombLauncherDatablock(MassBombLauncher_ION_Large : MassBombLauncher_EXP_Large) 
{
   friendlyName = "Large Ion Bomb Launcher";
   componentIconGraphic = "shipconIcon_bombEMP";
        
   ammoType          = "MassBomb_ION_Large";   
   
   componentButtonColor        = "Improved";
   
   myType = "MB_ION";
   
   purchaseTutorial = "PT_empBomb";  
};


datablock MassBombLauncherDatablock(MassBombLauncher_CORROSIVE_Large : MassBombLauncher_EXP_Large) 
{
   friendlyName = "Large Corrosive Bomb Launcher";
   componentIconGraphic = "shipconIcon_bombToxic";
        
   ammoType          = "MassBomb_CORROSIVE_Large";   
   
   componentButtonColor        = "Advanced";
   
   myType = "MB_COR";
   
   purchaseTutorial = "PT_toxicBomb";  
};

