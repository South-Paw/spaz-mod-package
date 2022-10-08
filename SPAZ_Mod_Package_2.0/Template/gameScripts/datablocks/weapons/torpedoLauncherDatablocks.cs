////////////////////////////////////////////////////////////////////////
// Torpedo Launchers //////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////
function TorpedoLauncherDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "TorpedoLauncherBase" )
      return;
            
   Parent::onAdd(%this);            
}



datablock TorpedoLauncherDatablock(TorpedoLauncherBase : WeaponBase) 
{         
   componentType      = "External";
   componentSubType   = $WEAPON_TorpedoLauncher; 
   isAutomated        = false;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   researchDatablock = "MissileResearch";
   
   componentButtonColor        = "Basic";
   
   purchaseTutorial = "PT_torp";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_High;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Low;  //long range lasers and projectiles
   threat_Short = $WT_None; //$WT_None $WT_Low $WT_Med $WT_High
};

/////////////////////////////////////////////////////////////
//SMALLS ////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////

datablock TorpedoLauncherDatablock(SmallTorpedoLauncher : TorpedoLauncherBase) 
{      
   friendlyName = "Small Basic Torpedos";
   
   ammoType           = "SmallTorpedo";
   
   myType = "BASIC"; //used for procedural systmes. 
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_SMALL;    
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_torp";
       
   WeaponMountDatablock = "SmallMissileMount"; 
};

datablock TorpedoLauncherDatablock(SmallTorpedoLauncher_Civ : SmallTorpedoLauncher) 
{ 
   friendlyName = "Small Civilian Torpedos"; 
   
   purchaseTutorial = "PT_torp_civ";  
      
   myType = "CIV";

   componentButtonColor        = "Civ";
   ammoType           = "SmallTorpedo_Civ";
};

/////////////////////////////////////////////////////////////
//Mediums ////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////


datablock TorpedoLauncherDatablock(MediumTorpedoLauncher : TorpedoLauncherBase) 
{    
   friendlyName = "Medium Basic Torpedos";        
     
   ammoType          = "MediumTorpedo";
     
   componentSize      = $SLOT_MEDIUM;    

   myType = "BASIC"; //used for procedural systmes. 
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption


   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_torp";
      
   WeaponMountDatablock = "MediumMissileMount";   
};

datablock TorpedoLauncherDatablock(MediumTorpedoLauncher_Civ : MediumTorpedoLauncher) 
{ 
   friendlyName = "Medium Civilian Torpedos"; 
   
   purchaseTutorial = "PT_torp_civ";        
   
   myType = "CIV"; 

   componentButtonColor        = "Civ";
   ammoType           = "MediumTorpedo_Civ";
};

/////////////////////////////////////////////////////////////
//Larges ////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////

datablock TorpedoLauncherDatablock(LargeTorpedoLauncher : TorpedoLauncherBase) 
{    
   friendlyName = "Large Basic Torpedos";     
     
   ammoType          = "LargeTorpedo";
      
   componentSize      = $SLOT_LARGE;  
     
   myType = "BASIC"; //used for procedural systmes. 
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
   componentIconGraphic        = "shipconIcon_torp";
   
   WeaponMountDatablock = "LargeMissileMount";  
};

datablock TorpedoLauncherDatablock(LargeTorpedoLauncher_Civ : LargeTorpedoLauncher) 
{ 
   friendlyName = "Large Civilian Torpedos";
   
   purchaseTutorial = "PT_torp_civ";    
   
   myType = "CIV";

   componentButtonColor        = "Civ";
   ammoType           = "LargeTorpedo_Civ";
};

/////////////////////////////////////////////////////////////
//Huges ////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////

datablock TorpedoLauncherDatablock(HugeTorpedoLauncher : TorpedoLauncherBase) 
{     
   friendlyName = "Huge Basic Torpedos";  
       
   ammoType          = "HugeTorpedo";
   
   myType = "BASIC"; //used for procedural systmes. 
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_HUGE;    
  
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_torp";
        
   WeaponMountDatablock = "HugeMissileMount";  
};

datablock TorpedoLauncherDatablock(HugeTorpedoLauncher_Civ : HugeTorpedoLauncher) 
{ 
   friendlyName = "Huge Civilian Torpedos";
   
   purchaseTutorial = "PT_torp_civ";       
   
   myType = "CIV";

   componentButtonColor        = "Civ";
   ammoType           = "HugeTorpedo_Civ";
};





