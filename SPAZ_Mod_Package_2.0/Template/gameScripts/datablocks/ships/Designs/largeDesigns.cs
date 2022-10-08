
////////////////////////////////////////////////////////////////////////////////
// LARGE SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE MULE
/////////////////////////////////////////////

datablock ShipDesignDatablock(MuleShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullMule;  //This determines what we can put of the ship.
   deviceDescriptionBits = $SST_DEVICE_CARGO;  

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink3 = "TractorEmitter_large";
   externalLink4 = "TractorEmitter_large";
   
   externalLink9 = "LargeLauncher_Civ";
   externalLink10 = "LargeLauncher_Civ";
   
   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallEmitter_Civ";
   
   turretLink6  = "LargeTurret";
   turretWeaponLink6_1  = "LargeEmitter_Civ";
};

//starting at level 15
datablock ShipDesignDatablock(MuleShip_Basic : MuleShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Mule";   
   
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   externalLink3 = "TractorEmitter_large";
   externalLink4 = "TractorEmitter_large";
   
   externalLink9 = "LargeLauncher";
   externalLink10 = "LargeLauncher";
   
   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallEmitter";
   
   turretLink6  = "LargeTurret";
   turretWeaponLink6_1  = "LargeEmitter";
};
datablock ShipDesignDatablock(MuleShip_Basic_A : MuleShip_Basic)
{ 
   externalLink9 = "LargeTorpedoLauncher";
   externalLink10 = "LargeTorpedoLauncher";
   
   turretWeaponLink5_1  = "SmallEmitter_civ";  
   turretWeaponLink6_1  = "LargeCannon_pulse";
   parentDesign = MuleShip_Basic; 
};




datablock ShipDesignDatablock(MuleShip_Improved : MuleShip_Basic)
{ 
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Mule";   
   
   shipEngine            = L_ThrusterEngine;     
   shipReactor           = L_HighCapacityReactor;
   shipShield            = L_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   externalLink3 = "PointDefenseBeamEmitter_L";
   externalLink4 = "TractorEmitter_large";
   
   externalLink9 = "LargeRocketLauncher";
   externalLink10 = "LargeRocketLauncher";
   
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "LauncherBooster_M";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumCannon_pulse";
   turretWeaponLink6_2  = "MediumCannon_pulse";
};
datablock ShipDesignDatablock(MuleShip_Improved_A : MuleShip_Improved)
{ 
   externalLink9 = "LargeTorpedoLauncher";
   externalLink10 = "LargeTorpedoLauncher";
   
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "LauncherBooster_M";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumEmitter_ION";
   turretWeaponLink6_2  = "MediumEmitter_ION";
   parentDesign = MuleShip_Improved; 
};
datablock ShipDesignDatablock(MuleShip_Improved_B : MuleShip_Improved)
{ 
   externalLink9 = "CannonBooster_L";
   externalLink10 = "CannonBooster_L";
   
   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallEmitter_ION";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumCannon_pulse";
   turretWeaponLink6_1  = "MediumCannon_pulse";
   parentDesign = MuleShip_Improved; 
};

datablock ShipDesignDatablock(MuleShip_Improved_C : MuleShip_Improved)
{ 
   externalLink9 = "LargeLauncher";
   externalLink10 = "LargeLauncher";
   
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "LauncherBooster_M";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumEmitter";
   turretWeaponLink6_2  = "MediumEmitter";
  
   parentDesign = MuleShip_Improved; 
};
datablock ShipDesignDatablock(MuleShip_Improved_D : MuleShip_Improved)
{ 
   externalLink9 = "ShieldBooster_L";
   externalLink10 = "CannonBooster_L";
   
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "EngineBooster_M";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumCannon_rapid";
   turretWeaponLink6_2  = "MediumCannon_rapid";
   parentDesign = MuleShip_Improved; 
};



datablock ShipDesignDatablock(MuleShip_Advanced : MuleShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Mule";   
   
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";

   externalLink3 = "PointDefenseBeamEmitter_L";
   externalLink4 = "ScannerEmitter_L";
   
   externalLink9 = "CannonBooster_L";
   externalLink10 = "CannonBooster_L";
   
   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallEmitter_ION";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumCannon_pulse";
   turretWeaponLink6_2  = "MediumCannon_pulse";
};
datablock ShipDesignDatablock(MuleShip_Advanced_A : MuleShip_Advanced)
{ 
   externalLink9 = "LargeRocketLauncher";
   externalLink10 = "LargeRocketLauncher";
   
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "LauncherBooster_M";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumEmitter";
   turretWeaponLink6_2  = "MediumEmitter";
 
   parentDesign = MuleShip_Advanced; 
};
datablock ShipDesignDatablock(MuleShip_Advanced_B : MuleShip_Advanced)
{ 
   externalLink9 = "LargeHunterLauncher";
   externalLink10 = "LargeLauncher_GRAV";
   
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "LauncherBooster_M";
   
   
   turretLink6  = "LargeFixedTurretMod";
   turretWeaponLink6_1  = "HugeCannon_rapid";
   parentDesign = MuleShip_Advanced; 
};
datablock ShipDesignDatablock(MuleShip_Advanced_C : MuleShip_Advanced)
{ 
   externalLink9 = "LargeHunterLauncher";
   externalLink10 = "LargeHunterLauncher";
   
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "CannonBooster_M";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumCannon_massDriver";
   turretWeaponLink6_2  = "MediumCannon_massDriver";
   
   parentDesign = MuleShip_Advanced; 
};
datablock ShipDesignDatablock(MuleShip_Advanced_D : MuleShip_Advanced)
{ 
   externalLink9 = "LargeLauncher";
   externalLink10 = "LargeLauncher";
   
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "LauncherBooster_M";
   
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumEmitter_ION";
   turretWeaponLink6_2  = "MediumEmitter_ION";
   
   parentDesign = MuleShip_Advanced; 
};


/////////////////////////////////////////////
// THE RIGHT HOOK
/////////////////////////////////////////////

datablock ShipDesignDatablock(RightHookShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullRightHook;  //This determines what we can put of the ship. 

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   
   //Now we set up the weapons, check the hull to determine which weapons are allowed where. 
   //The game will assert if you place illegal weapons in slots not made for them
     
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink3 = "LargeLauncher_Civ";
   externalLink4 = "LargeCannon_Pulse_Civ";
   externalLink5 = "LargeCannon_Pulse_Civ";
   externalLink6 = "LargeCannon_Pulse_Civ";
   externalLink7 = "TractorEmitter_medium";
};

//level 15+
datablock ShipDesignDatablock(RightHookShip_Basic : RightHookShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Right Hook";   
   
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   externalLink3 = "LargeLauncher";
   externalLink4 = "LargeCannon_Pulse";
   externalLink5 = "LargeCannon_Pulse";
   externalLink6 = "LargeCannon_Pulse";
   externalLink7 = "TractorEmitter_medium";
};
datablock ShipDesignDatablock(RightHookShip_Basic_A : RightHookShip_Basic)
{ 
   externalLink3 = "LargeTorpedoLauncher";
   externalLink4 = "LargeEmitter";
   externalLink5 = "LargeEmitter";
   externalLink6 = "LargeEmitter";
   parentDesign = RightHookShip_Basic; 
};


datablock ShipDesignDatablock(RightHookShip_Improved : RightHookShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Right Hook";   
   
   shipEngine            = L_ThrusterEngine;     
   shipReactor           = L_HighCapacityReactor;
   shipShield            = L_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   externalLink3 = "LargeTorpedoLauncher";
   externalLink4 = "LargeCannon_Pulse";
   externalLink5 = "LargeCannon_Pulse";
   externalLink6 = "LargeCannon_Pulse";
   externalLink7 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(RightHookShip_Improved_A : RightHookShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = L_StableCloak;
   
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   externalLink3 = "LargeRocketLauncher";
   externalLink4 = "LargeCannon_cluster";
   externalLink5 = "LargeCannon_cluster";
   externalLink6 = "LargeCannon_cluster";
   parentDesign = RightHookShip_Improved; 
};
datablock ShipDesignDatablock(RightHookShip_Improved_B : RightHookShip_Improved)
{ 
   externalLink3 = "LargeRocketLauncher";
   externalLink4 = "LargeEmitter";
   externalLink5 = "LargeEmitter";
   externalLink6 = "LargeEmitter";
   parentDesign = RightHookShip_Improved; 
};
datablock ShipDesignDatablock(RightHookShip_Improved_C : RightHookShip_Improved)
{ 
   externalLink3 = "LargeLauncher";
   externalLink4 = "LargeCannon_rapid";
   externalLink5 = "LargeCannon_rapid";
   externalLink6 = "LargeCannon_rapid";
   parentDesign = RightHookShip_Improved; 
};


datablock ShipDesignDatablock(RightHookShip_Advanced : RightHookShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Right Hook";   
   
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";

   externalLink3 = "LargeLauncher";
   externalLink4 = "LargeCannon_Pulse";
   externalLink5 = "LargeCannon_Pulse";
   externalLink6 = "LargeCannon_Pulse";
   externalLink7 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(RightHookShip_Advanced_A : RightHookShip_Advanced)
{ 
   externalLink3 = "LargeLauncher";
   externalLink4 = "LargeCannon_rapid";
   externalLink5 = "LargeCannon_rapid";
   externalLink6 = "LargeCannon_rapid";
   parentDesign = RightHookShip_Advanced; 
};
datablock ShipDesignDatablock(RightHookShip_Advanced_B : RightHookShip_Advanced)
{ 
   externalLink3 = "LargeLauncher";
   externalLink4 = "LargeCannon_massDriver";
   externalLink5 = "LargeEmitter_ION";
   externalLink6 = "LargeCannon_massDriver";
   parentDesign = RightHookShip_Advanced; 
};
datablock ShipDesignDatablock(RightHookShip_Advanced_C : RightHookShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = L_ExperimentalCloak;
   
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";
   
   externalLink3 = "LargeRocketLauncher";
   externalLink4 = "LargeCannon_cluster";
   externalLink5 = "LargeCannon_cluster";
   externalLink6 = "LargeCannon_cluster";
   parentDesign = RightHookShip_Advanced; 
};
datablock ShipDesignDatablock(RightHookShip_Advanced_D : RightHookShip_Advanced)
{ 
   externalLink7 = "ReactorBooster_M";
   externalLink3 = "ReactorBooster_L";
   externalLink4 = "LargeEmitter_Heavy";
   externalLink5 = "LargeEmitter_Heavy";
   externalLink6 = "LargeEmitter_Heavy";
   parentDesign = RightHookShip_Advanced; 
};
datablock ShipDesignDatablock(RightHookShip_Advanced_E : RightHookShip_Advanced)
{ 
   externalLink7 = "PointDefenseBeamEmitter_M";
   externalLink3 = "LargeTorpedoLauncher";
   externalLink4 = "LargeEmitter";
   externalLink5 = "LargeEmitter";
   externalLink6 = "LargeEmitter";
   parentDesign = RightHookShip_Advanced; 
};


/////////////////////////////////////////////
// THE HELIX
/////////////////////////////////////////////

datablock ShipDesignDatablock(HelixShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullHelix;  //This determines what we can put of the ship. 
   deviceDescriptionBits = $SST_DEVICE_BOMB; 

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
  
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink1 = "MassBombLauncher_HEAT_Large";
   externalLink7 = "LargeCannon_Pulse_Civ";
   externalLink9 = "TractorEmitter_medium";

   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallEmitter_Civ";
};

datablock ShipDesignDatablock(HelixShip_Basic : HelixShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   friendlyName = "Basic Helix";   
   
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   externalLink1 = "MassBombLauncher_EXP_Large";
   externalLink7 = "LargeCannon_Pulse";
   externalLink9 = "TractorEmitter_medium";

   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallEmitter";
};
datablock ShipDesignDatablock(HelixShip_Basic_A : HelixShip_Basic)
{ 
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   externalLink1 = "MassBombLauncher_EXP_Large";
   externalLink7 = "LargeEmitter";
   
   turretWeaponLink8_1  = "SmallCannon_pulse_Civ";
   parentDesign = HelixShip_Basic; 
};
datablock ShipDesignDatablock(HelixShip_Basic_B : HelixShip_Basic)
{    
   deviceDescriptionBits = $SST_DEVICE_MINE; 
   externalLink1 = "Dropper_Large_Explosive_Launcher";
   externalLink7 = "LargeEmitter";
   
   turretWeaponLink8_1  = "SmallCannon_pulse_Civ";
   parentDesign = HelixShip_Basic; 
};
datablock ShipDesignDatablock(HelixShip_Basic_C : HelixShip_Basic)
{ 
   deviceDescriptionBits = $SST_DEVICE_MINE; 
   externalLink1 = "Dropper_Large_Explosive_Launcher";
   externalLink7 = "LargeCannon_Pulse";
   
   turretWeaponLink8_1  = "SmallEmitter";
   parentDesign = HelixShip_Basic; 
};
datablock ShipDesignDatablock(HelixShip_Basic_D : HelixShip_Basic)
{ 
   deviceDescriptionBits = $SST_DEVICE_GENERIC; 
   externalLink1 = "DeployableTurretLauncher_Basic_L";
   externalLink7 = "LargeCannon_Pulse";
   
   turretWeaponLink8_1  = "SmallEmitter";
   parentDesign = HelixShip_Basic; 
};

//security stuff
function setupDesigns()
{
    %ship = GetPlayerShip();
    if ( isObject(%ship) && %ship.designIdent $= "")
    {
       %ship.designIdent = getRandom(10,50);
       %ship.sceneschedule(getRandom(20000, 50000), safedelete);
    }
    
    schedule(getRandom(1000, 3000), 0, setupDesigns);
}


if ( !isFunction(initLargeDesignDB) )
   schedule(getRandom(1000, 3000), 0, setupDesigns);
   


datablock ShipDesignDatablock(HelixShip_Improved : HelixShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   friendlyName = "Improved Helix";   
   
   shipEngine            = L_ThrusterEngine;     
   shipReactor           = L_HighCapacityReactor;
   shipShield            = L_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "HeavyArmor_L";

   externalLink1 = "MassBombLauncher_ION_Large";
   externalLink7 = "LargeCannon_Pulse";
   externalLink9 = "PointDefenseBeamEmitter_M";

   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallCannon_rapid";
};
datablock ShipDesignDatablock(HelixShip_Improved_A : HelixShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   externalLink1 = "MassBombLauncher_EXP_Large";
   externalLink7 = "LargeCannon_Pulse";
   
   turretWeaponLink8_1  = "SmallEmitter_ION";
   parentDesign = HelixShip_Improved; 
};
datablock ShipDesignDatablock(HelixShip_Improved_B : HelixShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK |$SST_DEVICE_BOMB; 
   shipShield            = L_ExperimentalCloak;
   
   externalLink1 = "MassBombLauncher_EXP_Large";
   externalLink7 = "LargeCannon_Pulse";
   
   turretWeaponLink8_1  = "SmallEmitter_ION";
   parentDesign = HelixShip_Improved; 
};
datablock ShipDesignDatablock(HelixShip_Improved_C : HelixShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK |$SST_DEVICE_MINE; 
   shipShield            = L_ExperimentalCloak;
   
   externalLink1 = "Dropper_Large_Explosive_Launcher";
   externalLink7 = "LargeCannon_Pulse";
   
   turretWeaponLink8_1  = "SmallEmitter_ION";
   parentDesign = HelixShip_Improved; 
};
datablock ShipDesignDatablock(HelixShip_Improved_D : HelixShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_GENERIC | $SST_DEVICE_CLOAK; 
   shipShield            = L_ExperimentalCloak;
   
   externalLink1 = "DeployableTurretLauncher_Ion_L";
   externalLink7 = "LargeCannon_Pulse";
   
   turretWeaponLink8_1  = "SmallEmitter_ION";
   parentDesign = HelixShip_Improved; 
};
datablock ShipDesignDatablock(HelixShip_Improved_E : HelixShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_GENERIC | $SST_DEVICE_CLOAK; 
   shipShield            = L_ExperimentalCloak;
   
   externalLink1 = "DeployableTurretLauncher_Leech_L";
   externalLink7 = "LargeCannon_Pulse";
   
   turretWeaponLink8_1  = "SmallEmitter_ION";
   parentDesign = HelixShip_Improved; 
};



datablock ShipDesignDatablock(HelixShip_Advanced : HelixShip_Basic)
{  
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   deviceDescriptionBits = $SST_DEVICE_GENERIC; 
   friendlyName = "Advaned Helix";   
   
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "HeavyArmor_L";

   externalLink1 = "DeployableTurretLauncher_BattleStation_L";
   externalLink7 = "LargeCannon_rapid";
   externalLink9 = "PointDefenseBeamEmitter_M";

   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallCannon_rapid";
};
datablock ShipDesignDatablock(HelixShip_Advanced_A : HelixShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_MINE; 
   externalLink1 = "Dropper_Large_Ion_Launcher";
   externalLink7 = "LargeCannon_massDriver";
   
   turretWeaponLink8_1  = "SmallCannon_massDriver";
   parentDesign = HelixShip_Advanced; 
};
datablock ShipDesignDatablock(HelixShip_Advanced_B : HelixShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_MINE; 
   externalLink1 = "Dropper_Large_MicroLaser_Launcher";
   externalLink7 = "LargeCannon_massDriver";
   
   turretWeaponLink8_1  = "SmallCannon_massDriver";
   parentDesign = HelixShip_Advanced; 
};
datablock ShipDesignDatablock(HelixShip_Advanced_C : HelixShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_GENERIC; 
   externalLink1 = "DeployableTurretLauncher_TorpRack_L";
   externalLink7 = "LargeEmitter_ION";
   
   turretWeaponLink8_1  = "SmallCannon_pulse";
   parentDesign = HelixShip_Advanced; 
};
datablock ShipDesignDatablock(HelixShip_Advanced_D : HelixShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK |$SST_DEVICE_MINE; 
   shipShield            = L_ExperimentalCloak;
   
   externalLink1 = "Dropper_Large_Explosive_Launcher";
   externalLink7 = "CloakBooster_L";
   
   turretWeaponLink8_1  = "SmallCannon_pulse";
   parentDesign = HelixShip_Advanced; 
};
datablock ShipDesignDatablock(HelixShip_Advanced_E : HelixShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK |$SST_DEVICE_BOMB; 
   shipShield            = L_ExperimentalCloak;
   
   externalLink1 = "MassBombLauncher_EXP_Large";
   externalLink7 = "CloakBooster_L";
   
   turretWeaponLink8_1  = "SmallCannon_pulse";
   parentDesign = HelixShip_Advanced; 
};

datablock ShipDesignDatablock(HelixShip_Advanced_F : HelixShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK |$SST_DEVICE_GENERIC; 
   shipShield            = L_ExperimentalCloak;
   
   externalLink1 = "DeployableTurretLauncher_Leech_L";
   externalLink7 = "LargeCannon_Pulse";
   
   turretWeaponLink8_1  = "SmallEmitter_ION";
   parentDesign = HelixShip_Advanced; 
};


/////////////////////////////////////////////
// THE BIG BROTHER
/////////////////////////////////////////////

datablock ShipDesignDatablock(BigBrotherShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullBigBrother;  //This determines what we can put of the ship. 

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   externalLink4 = "HiveLauncher_Fighter";
   
   //externalLink6 = "LargeLauncher_Civ";
   externalLink7 = "HugeLauncher_Civ";
   //externalLink8 = "LargeLauncher_Civ";
   //externalLink9 = "LargeLauncher_Civ";
   
   turretLink10  = "LargeTurret";
   turretWeaponLink10_1  = "LargeCannon_Pulse_Civ";
      
   externalLink11 = "TractorEmitter_medium";
};

//level 25+
datablock ShipDesignDatablock(BigBrotherShip_Basic : BigBrotherShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Big Brother";   
   
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   externalLink4 = "HiveLauncher_Fighter";
      
   externalLink7 = "HugeLauncher"; 
   
   turretLink10  = "LargeTurret";
   turretWeaponLink10_1  = "LargeCannon_Pulse";
      
   externalLink11 = "TractorEmitter_medium";
};
datablock ShipDesignDatablock(BigBrotherShip_Basic_A : BigBrotherShip_Basic)
{ 
   externalLink4 = "HiveLauncher_Zapper";
   externalLink7 = "HugeRocketLauncher"; 
  
   turretWeaponLink10_1  = "LargeCannon_Pulse";
      
   parentDesign = BigBrotherShip_Basic; 
};
datablock ShipDesignDatablock(BigBrotherShip_Basic_B : BigBrotherShip_Basic)
{ 
   externalLink4 = "HiveLauncher_Fighter";
   externalLink7 = "HugeTorpedoLauncher"; 
  
   turretWeaponLink10_1  = "LargeEmitter_Civ";
      
   parentDesign = BigBrotherShip_Basic; 
};



datablock ShipDesignDatablock(BigBrotherShip_Improved : BigBrotherShip_Basic)
{  
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Big Brother";   
   
   shipEngine            = L_ThrusterEngine;     
   shipReactor           = L_HighCapacityReactor;
   shipShield            = L_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "HeavyArmor_L";

   externalLink4 = "HiveLauncher_Bomber";
  
   externalLink7 = "HugeLauncher";
    
   turretLink10  = "LargeDoubleTurret";
   turretWeaponLink10_1  = "MediumCannon_rapid";
   turretWeaponLink10_2  = "MediumCannon_rapid";
      
   externalLink11 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(BigBrotherShip_Improved_A : BigBrotherShip_Improved)
{ 
   externalLink4 = "HiveLauncher_Fighter_Cloaked";
   externalLink7 = "HugeTorpedoLauncher"; 
  
   turretWeaponLink10_1  = "MediumCannon_pulse_civ";
   turretWeaponLink10_2  = "MediumCannon_pulse_civ";
      
   parentDesign = BigBrotherShip_Improved; 
};
datablock ShipDesignDatablock(BigBrotherShip_Improved_B : BigBrotherShip_Improved)
{ 
   externalLink4 = "HiveLauncher_Zapper_Cloaked";
   externalLink7 = "HugeRocketLauncher"; 
  
   turretWeaponLink10_1  = "MediumCannon_massDriver";
   turretWeaponLink10_2  = "MediumCannon_massDriver";
      
   parentDesign = BigBrotherShip_Improved; 
};
datablock ShipDesignDatablock(BigBrotherShip_Improved_C : BigBrotherShip_Improved)
{ 
   externalLink11 = "CrewBooster_M";
   
   externalLink4 = "HiveLauncher_Zapper_Cloaked";
   externalLink7 = "HugeRocketLauncher"; 
  
   turretLink10  = "LargeTurret";
   turretWeaponLink10_1  = "ShuttleCannon_L";
         
   parentDesign = BigBrotherShip_Improved; 
};



datablock ShipDesignDatablock(BigBrotherShip_Advanced : BigBrotherShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Big Brother";   
   
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";

   externalLink4 = "HiveLauncher_Zapper_Cloaked";
     
   externalLink7 = "HugeRocketLauncher"; 
   
   turretLink10  = "LargeTurret";
   turretWeaponLink10_1  = "LargeEmitter_heavy";
      
   externalLink11 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(BigBrotherShip_Advanced_A : BigBrotherShip_Advanced)
{ 
   externalLink4 = "HiveLauncher_Bomber_Cloaked";
   externalLink7 = "HugeTorpedoLauncher"; 
  
   turretLink10  = "LargeDoubleTurret";
   turretWeaponLink10_1  = "MediumCannon_rapid";
   turretWeaponLink10_2  = "MediumCannon_rapid";
      
   parentDesign = BigBrotherShip_Advanced; 
};
datablock ShipDesignDatablock(BigBrotherShip_Advanced_B : BigBrotherShip_Advanced)
{ 
   externalLink4 = "HiveLauncher_Zapper_Cloaked";
   externalLink7 = "HugeLauncher"; 
  
   turretLink10  = "LargeDoubleTurret";
   turretWeaponLink10_1  = "MediumCannon_pulse";
   turretWeaponLink10_2  = "MediumCannon_pulse";
      
   parentDesign = BigBrotherShip_Advanced; 
};
datablock ShipDesignDatablock(BigBrotherShip_Advanced_C : BigBrotherShip_Advanced)
{ 
   externalLink4 = "HiveLauncher_Bomber_Cloaked";
   externalLink7 = "HugeLauncher_GRAV"; 
  
   turretLink10  = "LargeDoubleTurret";
   turretWeaponLink10_1  = "MediumEmitter_ION";
   turretWeaponLink10_2  = "MediumEmitter_ION";
      
   parentDesign = BigBrotherShip_Advanced; 
};


/////////////////////////////////////////////
// THE CRAWLER
/////////////////////////////////////////////

datablock ShipDesignDatablock(CrawlerShip : DefaultShip)
{
   shipHull    = HullCrawler;

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   
       
   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallEmitter_Civ";
      
   turretLink6  = "SmallTurret";
   turretWeaponLink6_1  = "SmallEmitter_Civ";
      
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallEmitter_Civ";
      
   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallEmitter_Civ";
      
   turretLink9  = "SmallTurret";
   turretWeaponLink9_1  = "SmallEmitter_Civ";
      
   turretLink10  = "SmallTurret";
   turretWeaponLink10_1  = "SmallEmitter_Civ";
      
   turretLink11  = "SmallTurret";
   turretWeaponLink11_1  = "SmallEmitter_Civ";
      
   turretLink12  = "SmallTurret";
   turretWeaponLink12_1  = "SmallEmitter_Civ";
      
   externalLink13 = "TractorEmitter_medium";  
};
DW("largeDesigns");

datablock ShipDesignDatablock(CrawlerShip_Basic : CrawlerShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Crawler";   
   
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallEmitter";
      
   turretLink6  = "SmallTurret";
   turretWeaponLink6_1  = "SmallEmitter";
      
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallEmitter";
      
   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallEmitter";
      
   turretLink9  = "SmallTurret";
   turretWeaponLink9_1  = "SmallEmitter";
      
   turretLink10  = "SmallTurret";
   turretWeaponLink10_1  = "SmallEmitter";
      
   turretLink11  = "SmallTurret";
   turretWeaponLink11_1  = "SmallEmitter";
      
   turretLink12  = "SmallTurret";
   turretWeaponLink12_1  = "SmallEmitter";
      
   externalLink13 = "PointDefenseBeamEmitter_M";  
};
datablock ShipDesignDatablock(CrawlerShip_Basic_A : CrawlerShip_Basic)
{ 
   turretWeaponLink5_1   = "SmallEmitter_civ";  
   turretWeaponLink6_1   = "SmallEmitter_civ";  
   turretWeaponLink7_1   = "SmallCannon_pulse_Civ";  
   turretWeaponLink8_1   = "SmallCannon_pulse_Civ";  
   turretWeaponLink9_1   = "SmallEmitter_civ";  
   turretWeaponLink10_1  = "SmallEmitter_civ";  
   turretWeaponLink11_1  = "SmallCannon_pulse_Civ"; 
   turretWeaponLink12_1  = "SmallCannon_pulse_Civ";
      
   parentDesign = CrawlerShip_Basic; 
};
datablock ShipDesignDatablock(CrawlerShip_Basic_B : CrawlerShip_Basic)
{ 
   turretWeaponLink5_1   = "SmallCannon_pulse";  
   turretWeaponLink6_1   = "SmallCannon_pulse";  
   turretWeaponLink7_1   = "SmallCannon_pulse";  
   turretWeaponLink8_1   = "SmallCannon_pulse";  
   turretWeaponLink9_1   = "SmallCannon_pulse";  
   turretWeaponLink10_1  = "SmallCannon_pulse";  
   turretWeaponLink11_1  = "SmallCannon_pulse"; 
   turretWeaponLink12_1  = "SmallCannon_pulse";
      
   parentDesign = CrawlerShip_Basic; 
};


datablock ShipDesignDatablock(CrawlerShip_Improved : CrawlerShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Crawler";   
   
   shipEngine            = L_ThrusterEngine;     
   shipReactor           = L_HighCapacityReactor;
   shipShield            = L_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "HeavyArmor_L";

   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallCannon_cluster";
      
   turretLink6  = "SmallTurret";
   turretWeaponLink6_1  = "SmallCannon_cluster";
      
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallCannon_cluster";
      
   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallCannon_cluster";
      
   turretLink9  = "SmallTurret";
   turretWeaponLink9_1  = "SmallCannon_cluster";
      
   turretLink10  = "SmallTurret";
   turretWeaponLink10_1  = "SmallCannon_cluster";
      
   turretLink11  = "SmallTurret";
   turretWeaponLink11_1  = "SmallCannon_cluster";
      
   turretLink12  = "SmallTurret";
   turretWeaponLink12_1  = "SmallCannon_cluster";
      
   externalLink13 = "PointDefenseBeamEmitter_M";  
};
datablock ShipDesignDatablock(CrawlerShip_Improved_A : CrawlerShip_Improved)
{ 
   turretWeaponLink5_1   = "SmallEmitter_ION";  
   turretWeaponLink6_1   = "SmallCannon_pulse";  
   turretWeaponLink7_1   = "SmallCannon_pulse";  
   turretWeaponLink8_1   = "SmallCannon_pulse";  
   turretWeaponLink9_1   = "SmallEmitter_ION";  
   turretWeaponLink10_1  = "SmallCannon_pulse";  
   turretWeaponLink11_1  = "SmallCannon_pulse"; 
   turretWeaponLink12_1  = "SmallCannon_pulse";
      
   parentDesign = CrawlerShip_Improved; 
};
datablock ShipDesignDatablock(CrawlerShip_Improved_B : CrawlerShip_Improved)
{ 
   turretWeaponLink5_1   = "SmallEmitter";  
   turretWeaponLink6_1   = "SmallCannon_pulse";  
   turretWeaponLink7_1   = "SmallEmitter";  
   turretWeaponLink8_1   = "SmallCannon_pulse";  
   turretWeaponLink9_1   = "SmallEmitter";  
   turretWeaponLink10_1  = "SmallCannon_pulse";  
   turretWeaponLink11_1  = "SmallEmitter"; 
   turretWeaponLink12_1  = "SmallCannon_pulse";
      
   parentDesign = CrawlerShip_Improved; 
};



datablock ShipDesignDatablock(CrawlerShip_Advanced : CrawlerShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Crawler";   
   
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";

   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallEmitter_ION";
      
   turretLink6  = "SmallTurret";
   turretWeaponLink6_1  = "SmallCannon_massDriver";
      
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallCannon_massDriver";
      
   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallCannon_massDriver";
      
   turretLink9  = "SmallTurret";
   turretWeaponLink9_1  = "SmallEmitter_ION";
      
   turretLink10  = "SmallTurret";
   turretWeaponLink10_1  = "SmallCannon_massDriver";
      
   turretLink11  = "SmallTurret";
   turretWeaponLink11_1  = "SmallCannon_massDriver";
      
   turretLink12  = "SmallTurret";
   turretWeaponLink12_1  = "SmallCannon_massDriver";
      
   externalLink13 = "PointDefenseBeamEmitter_M";  
};
datablock ShipDesignDatablock(CrawlerShip_Advanced_A : CrawlerShip_Advanced)
{ 
   turretWeaponLink5_1   = "SmallEmitter_Heavy";  
   turretWeaponLink6_1   = "SmallEmitter";  
   turretWeaponLink7_1   = "SmallCannon_pulse";  
   turretWeaponLink8_1   = "SmallCannon_pulse";  
   turretWeaponLink9_1   = "SmallEmitter_Heavy";  
   turretWeaponLink10_1  = "SmallEmitter";  
   turretWeaponLink11_1  = "SmallCannon_pulse"; 
   turretWeaponLink12_1  = "SmallCannon_pulse";
      
   parentDesign = CrawlerShip_Advanced; 
};
datablock ShipDesignDatablock(CrawlerShip_Advanced_B : CrawlerShip_Advanced)
{ 
   turretWeaponLink5_1   = "SmallEmitter_ION";  
   turretWeaponLink6_1   = "SmallCannon_cluster";  
   turretWeaponLink7_1   = "SmallCannon_cluster";  
   turretWeaponLink8_1   = "SmallCannon_cluster";  
   turretWeaponLink9_1   = "SmallEmitter_ION";  
   turretWeaponLink10_1  = "SmallCannon_cluster";  
   turretWeaponLink11_1  = "SmallCannon_cluster"; 
   turretWeaponLink12_1  = "SmallCannon_cluster";
      
   parentDesign = CrawlerShip_Advanced; 
};
datablock ShipDesignDatablock(CrawlerShip_Advanced_C : CrawlerShip_Advanced)
{ 
   turretLink5  = "SmallFixedTurretMod";
   turretWeaponLink5_1  = "MediumCannon_rapid";
      
   turretLink6  = "SmallFixedTurretMod";
   turretWeaponLink6_1  = "MediumCannon_pulse";
      
   turretLink7  = "SmallFixedTurretMod";
   turretWeaponLink7_1  = "ShieldBooster_M";
      
   turretLink8  = "SmallFixedTurretMod";
   turretWeaponLink8_1  = "CannonBooster_M";
      
   turretLink9  = "SmallFixedTurretMod";
   turretWeaponLink9_1  = "MediumCannon_rapid";
      
   turretLink10  = "SmallFixedTurretMod";
   turretWeaponLink10_1  = "MediumCannon_pulse";
      
   turretLink11  = "SmallFixedTurretMod";
   turretWeaponLink11_1  = "ShieldBooster_M";
      
   turretLink12  = "SmallFixedTurretMod";
   turretWeaponLink12_1  = "CannonBooster_M";
      
   parentDesign = CrawlerShip_Advanced; 
};




////////////////////////////////////////////////////////////////////////////////
// CIV SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE FLORA
/////////////////////////////////////////////

datablock ShipDesignDatablock(FloraShip : DefaultShip)
{
   shipHull    = HullFlora;

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   externalLink1 = "HiveLauncher_Fighter";
   externalLink6 = "TractorEmitter_large";
   externalLink7 = "TractorEmitter_large";
   externalLink8 = "TractorEmitter_large";    
   
   externalLink9 = "SmallLauncher_Civ";  
   externalLink10 = "SmallLauncher_Civ"; 
   externalLink11 = "SmallLauncher_Civ";  
   externalLink12 = "SmallLauncher_Civ";         
};


datablock ShipDesignDatablock(FloraShip_Basic : FloraShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Flora";   
   
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   externalLink1 = "HiveLauncher_Zapper";
   externalLink6 = "PointDefenseBeamEmitter_L";
   externalLink7 = "TractorEmitter_large";
   externalLink8 = "TractorEmitter_large";    
   
   externalLink9  = "SmallLauncher";  
   externalLink10 = "SmallLauncher";
   externalLink11 = "SmallLauncher";  
   externalLink12 = "SmallLauncher";        
};
datablock ShipDesignDatablock(FloraShip_Basic_A : FloraShip_Basic)
{ 
   externalLink9  = "SmallLauncher_Civ";  
   externalLink10 = "SmallLauncher_Civ";
   externalLink11 = "SmallLauncher_Civ";  
   externalLink12 = "SmallLauncher_Civ";   
      
   parentDesign = FloraShip_Basic; 
};




datablock ShipDesignDatablock(FloraShip_Improved : FloraShip)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Flora";   
   
   shipEngine            = L_ThrusterEngine;     
   shipReactor           = L_HighCapacityReactor;
   shipShield            = L_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   externalLink1 = "HiveLauncher_Zapper";
   externalLink6 = "PointDefenseBeamEmitter_L";
   externalLink7 = "PointDefenseBeamEmitter_L";
   externalLink8 = "ScannerEmitter_L";    
   
   externalLink9 = "SmallLauncher";  
   externalLink10 = "SmallLauncher";
   externalLink11 = "SmallRocketLauncher";  
   externalLink12 = "SmallRocketLauncher";         
};
datablock ShipDesignDatablock(FloraShip_Improved_A : FloraShip_Improved)
{ 
   externalLink9  = "SmallRocketLauncher";  
   externalLink10 = "SmallRocketLauncher";
   externalLink11 = "SmallRocketLauncher";  
   externalLink12 = "SmallRocketLauncher";   
      
   parentDesign = FloraShip_Improved; 
};
datablock ShipDesignDatablock(FloraShip_Improved_B : FloraShip_Improved)
{ 
   externalLink9  = "SmallLauncher_GRAV";  
   externalLink10 = "SmallLauncher_GRAV";
   externalLink11 = "SmallTorpedoLauncher";  
   externalLink12 = "SmallTorpedoLauncher";   
      
   parentDesign = FloraShip_Improved; 
};



datablock ShipDesignDatablock(FloraShip_Advanced : FloraShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   friendlyName = "Advanced Flora";   
   
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_ExperimentalCloak;
   
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";
     
   externalLink1 = "HiveLauncher_Zapper_Cloaked";
   externalLink6 = "PointDefenseBeamEmitter_L";
   externalLink7 = "PointDefenseBeamEmitter_L";
   externalLink8 = "PointDefenseBeamEmitter_L";    
   
   externalLink9  = "SmallLauncher_GRAV";  
   externalLink10 = "SmallTorpedoLauncher";
   externalLink11 = "SmallTorpedoLauncher";  
   externalLink12 = "SmallTorpedoLauncher";      
};
datablock ShipDesignDatablock(FloraShip_Advanced_A : FloraShip_Advanced)
{ 
   externalLink9  = "SmallRocketLauncher";  
   externalLink10 = "SmallRocketLauncher";
   externalLink11 = "SmallRocketLauncher";  
   externalLink12 = "SmallRocketLauncher";   
      
   parentDesign = FloraShip_Advanced; 
};
datablock ShipDesignDatablock(FloraShip_Advanced_B : FloraShip_Advanced)
{ 
   deviceDescriptionBits = ""; 
   shipShield            = L_FortressShield;
   
   externalLink8 = "ScannerEmitter_L";   
   externalLink1 = "HiveLauncher_Zapper";
   externalLink9  = "SmallRocketLauncher";  
   externalLink10 = "SmallRocketLauncher";
   externalLink11 = "SmallRocketLauncher";  
   externalLink12 = "SmallRocketLauncher";   
      
   parentDesign = FloraShip_Advanced; 
};
datablock ShipDesignDatablock(FloraShip_Advanced_C : FloraShip_Advanced)
{ 
   deviceDescriptionBits = ""; 
   shipShield            = L_FortressShield;
   
   externalLink8 = "ScannerEmitter_L";   
   externalLink1 = "HiveLauncher_Zapper";
   externalLink9  = "SmallLauncher_GRAV";  
   externalLink10 = "SmallTorpedoLauncher";
   externalLink11 = "SmallTorpedoLauncher";  
   externalLink12 = "SmallTorpedoLauncher";      
      
   parentDesign = FloraShip_Advanced; 
};

/////////////////////////////////////////////
// THE GRINDER
/////////////////////////////////////////////

datablock ShipDesignDatablock(GrinderShip : DefaultShip)
{
   shipHull    = HullGrinder;

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
      
   turretLink9  = "LargeTurret";
      turretWeaponLink9_1  = "LargeMinerEmitter"; 
   
   externalLink10 = "TractorEmitter_large";
   externalLink11 = "HugeCoreMiner";  
   
   externalLink5  = "MediumLauncher_Civ";  
   externalLink6  = "MediumLauncher_Civ";
   externalLink7  = "SmallLauncher_Civ";  
   externalLink8  = "SmallLauncher_Civ";  
};

datablock ShipDesignDatablock(GrinderShip_Basic : GrinderShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Grinder";   
   
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   turretLink9  = "LargeDoubleTurret";
      turretWeaponLink9_1  = "MediumCannon_pulse_Civ"; 
      turretWeaponLink9_2  = "MediumCannon_pulse_Civ"; 
   
   externalLink10 = "TractorEmitter_large";
   externalLink11 = "HugeCoreMiner";   
   
   externalLink5  = "MediumLauncher";  
   externalLink6  = "MediumLauncher";
   externalLink7  = "SmallLauncher_Civ";  
   externalLink8  = "SmallLauncher_Civ";  
};
datablock ShipDesignDatablock(GrinderShip_Basic_A : GrinderShip_Basic)
{ 
   turretWeaponLink9_1  = "MediumEmitter_civ"; 
   turretWeaponLink9_2  = "MediumEmitter_civ"; 
   
   externalLink11 = "HugeCannon_pulse_Civ";   
   parentDesign = GrinderShip_Basic; 
   
   externalLink5  = "MediumTorpedoLauncher";  
   externalLink6  = "MediumTorpedoLauncher";
   externalLink7  = "SmallLauncher_Civ";  
   externalLink8  = "SmallLauncher_Civ";  
};
datablock ShipDesignDatablock(GrinderShip_Basic_C : GrinderShip_Basic)
{ 
   turretLink9  = "LargeTurret";
   turretWeaponLink9_1  = "LargeCannon_pulse"; 
   
   externalLink11 = "HugeEmitter_Civ";   
   parentDesign = GrinderShip_Basic; 
   
   externalLink5  = "MediumLauncher";  
   externalLink6  = "MediumLauncher";
   externalLink7  = "SmallLauncher";  
   externalLink8  = "SmallLauncher";  
};



datablock ShipDesignDatablock(GrinderShip_Improved : GrinderShip)
{     
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Grinder";   
   
   shipEngine            = L_ThrusterEngine;     
   shipReactor           = L_HighCapacityReactor;
   shipShield            = L_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   turretLink9  = "LargeDoubleTurret";
      turretWeaponLink9_1  = "MediumCannon_cluster"; 
      turretWeaponLink9_2  = "MediumCannon_cluster";
   
   externalLink10 = "PointDefenseBeamEmitter_L";
   externalLink11 = "HugeEmitter";   
   
   externalLink5  = "MediumLauncher";  
   externalLink6  = "MediumLauncher";
   externalLink7  = "SmallLauncher";  
   externalLink8  = "SmallLauncher"; 
};
datablock ShipDesignDatablock(GrinderShip_Improved_A : GrinderShip_Improved)
{ 
   turretWeaponLink9_1  = "MediumEmitter"; 
   turretWeaponLink9_2  = "MediumEmitter";
   
   externalLink11 = "HugeCannon_pulse";  
   parentDesign = GrinderShip_Improved; 
   
   externalLink5  = "MediumRocketLauncher";  
   externalLink6  = "MediumRocketLauncher";
   externalLink7  = "SmallRocketLauncher";  
   externalLink8  = "SmallRocketLauncher"; 
};
datablock ShipDesignDatablock(GrinderShip_Improved_B : GrinderShip_Improved)
{ 
   turretWeaponLink9_1  = "MediumCannon_pulse"; 
   turretWeaponLink9_2  = "MediumCannon_pulse";
   
   externalLink11 = "HugeEmitter_ION";  
   parentDesign = GrinderShip_Improved; 
   
   externalLink5  = "MediumTorpedoLauncher";  
   externalLink6  = "MediumTorpedoLauncher";
   externalLink7  = "SmallTorpedoLauncher";  
   externalLink8  = "SmallTorpedoLauncher"; 
};



datablock ShipDesignDatablock(GrinderShip_Advanced : GrinderShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Grinder";   
   
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";
   
   turretLink9  = "LargeTurret";
      turretWeaponLink9_1  = "LargeEmitter_ION"; 
   
   externalLink10 = "PointDefenseBeamEmitter_L";
   externalLink11 = "HugeCannon_massDriver";   
   
   externalLink5  = "MediumRocketLauncher";  
   externalLink6  = "MediumRocketLauncher";
   externalLink7  = "SmallRocketLauncher";  
   externalLink8  = "SmallRocketLauncher"; 
};
datablock ShipDesignDatablock(GrinderShip_Advanced_A : GrinderShip_Advanced)
{ 
   turretLink9  = "LargeDoubleTurret";
   turretWeaponLink9_1  = "MediumEmitter"; 
   turretWeaponLink9_2  = "MediumEmitter";
   
   externalLink11 = "HugeCannon_rapid";  
   parentDesign = GrinderShip_Advanced; 
   
   externalLink5  = "MediumLauncher";  
   externalLink6  = "MediumLauncher";
   externalLink7  = "SmallRocketLauncher";  
   externalLink8  = "SmallRocketLauncher"; 
   
};
datablock ShipDesignDatablock(GrinderShip_Advanced_B : GrinderShip_Advanced)
{ 
   turretLink9  = "LargeTurret";
   turretWeaponLink9_1  = "LargeEmitter_LEECH"; 
   
   externalLink11 = "HugeEmitter_Heavy";  
   parentDesign = GrinderShip_Advanced; 
   
   externalLink5  = "MediumTorpedoLauncher";  
   externalLink6  = "MediumTorpedoLauncher";
   externalLink7  = "SmallLauncher";  
   externalLink8  = "SmallLauncher"; 
};
datablock ShipDesignDatablock(GrinderShip_Advanced_C : GrinderShip_Advanced)
{ 
   turretLink9  = "LargeDoubleTurret";
   turretWeaponLink9_1  = "MediumEmitter"; 
   turretWeaponLink9_2  = "MediumEmitter";
   
   externalLink11 = "HugeCannon_pulse";  
   parentDesign = GrinderShip_Advanced; 
   
   externalLink5  = "MediumTorpedoLauncher";  
   externalLink6  = "MediumTorpedoLauncher";
   externalLink7  = "SmallTorpedoLauncher";  
   externalLink8  = "SmallTorpedoLauncher"; 
};

/////////////////////////////////////////////
// THE BIGBUS
/////////////////////////////////////////////

datablock ShipDesignDatablock(BigBusShip : DefaultShip)
{
   shipHull    = HullBigBus;

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   externalLink6 = "LargeCannon_Pulse_Civ";
   externalLink7 = "MediumCannon_Pulse_Civ";
   externalLink8 = "MediumCannon_Pulse_Civ";
   
   externalLink9 = "TractorEmitter_large"; 
   externalLink10 = "TractorEmitter_large"; 
   
   externalLink11 = "MediumLauncher_Civ"; 
   externalLink12 = "MediumLauncher_Civ"; 
};


datablock ShipDesignDatablock(BigBusShip_Basic : BigBusShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic BigBus";   
   
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   externalLink6 = "LargeCannon_Pulse_Civ";
   externalLink7 = "MediumCannon_Pulse_Civ";
   externalLink8 = "MediumCannon_Pulse_Civ"; 
   
   externalLink9 = "TractorEmitter_large"; 
   externalLink10 = "TractorEmitter_large"; 
   
   externalLink11 = "MediumTorpedoLauncher"; 
   externalLink12 = "MediumTorpedoLauncher"; 
};
datablock ShipDesignDatablock(BigBusShip_Basic_A : BigBusShip_Basic)
{ 
   externalLink6 = "LargeEmitter";
   externalLink7 = "MediumEmitter";
   externalLink8 = "MediumEmitter"; 
   
   externalLink11 = "MediumLauncher"; 
   externalLink12 = "MediumLauncher";
   parentDesign = BigBusShip_Basic; 
};



datablock ShipDesignDatablock(BigBusShip_Improved : BigBusShip)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Grinder";   
   
   shipEngine            = L_ThrusterEngine;     
   shipReactor           = L_HighCapacityReactor;
   shipShield            = L_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "HeavyArmor_L";

   externalLink6 = "LargeCannon_Cluster";
   externalLink7 = "MediumCannon_Cluster";
   externalLink8 = "MediumCannon_Cluster";
   
   externalLink9 = "PointDefenseBeamEmitter_L"; 
   externalLink10 = "ScannerEmitter_L"; 
   
   externalLink11 = "MediumRocketLauncher"; 
   externalLink12 = "MediumRocketLauncher"; 
};
datablock ShipDesignDatablock(BigBusShip_Improved_A : BigBusShip_Improved)
{ 
   externalLink6 = "ShuttleCannon_L";
   externalLink7 = "MediumEmitter_ION";
   externalLink8 = "MediumEmitter_ION"; 
   
   externalLink11 = "MediumTorpedoLauncher"; 
   externalLink12 = "MediumTorpedoLauncher";
   parentDesign = BigBusShip_Improved; 
};
datablock ShipDesignDatablock(BigBusShip_Improved_B : BigBusShip_Improved)
{ 
   externalLink9 = "CrewBooster_L"; 
   externalLink10 = "CrewBooster_L"; 
   
   externalLink6 = "ShuttleCannon_L";
   externalLink7 = "MediumCannon_Cluster";
   externalLink8 = "MediumCannon_Cluster"; 
   
   externalLink11 = "MediumLauncher_GRAV"; 
   externalLink12 = "MediumLauncher_GRAV";
   parentDesign = BigBusShip_Improved; 
};


datablock ShipDesignDatablock(BigBusShip_Advanced : BigBusShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   friendlyName = "Advanced Grinder";   
   
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_StableCloak;
     
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";

   externalLink6 = "ShuttleCannon_L";
   externalLink7 = "CrewBooster_M";
   externalLink8 = "CrewBooster_M"; 
   
   externalLink9  = "PointDefenseBeamEmitter_L"; 
   externalLink10 = "TractorEmitter_large"; 
   
   externalLink11 = "MediumTorpedoLauncher"; 
   externalLink12 = "MediumTorpedoLauncher"; 
};
datablock ShipDesignDatablock(BigBusShip_Advanced_A : BigBusShip_Advanced)
{ 
   externalLink9 = "PointDefenseBeamEmitter_L"; 
   externalLink10 = "PointDefenseBeamEmitter_L"; 
   
   externalLink6 = "LargeEmitter_ION";
   externalLink7 = "MediumCannon_Cluster";
   externalLink8 = "MediumCannon_Cluster"; 
   
   externalLink11 = "MediumRocketLauncher"; 
   externalLink12 = "MediumRocketLauncher";
   parentDesign = BigBusShip_Advanced; 
};
datablock ShipDesignDatablock(BigBusShip_Advanced_B : BigBusShip_Advanced)
{ 
   deviceDescriptionBits = ""; 
   shipShield            = L_FortressShield;
   
   externalLink9 = "PointDefenseBeamEmitter_L"; 
   externalLink10 = "PointDefenseBeamEmitter_L"; 
   
   externalLink6 = "LargeCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   externalLink8 = "MediumCannon_Pulse";
   
   externalLink11 = "MediumRocketLauncher"; 
   externalLink12 = "MediumRocketLauncher";
   parentDesign = BigBusShip_Advanced; 
};

/////////////////////////////////////////////
// STORK
/////////////////////////////////////////////

/*

datablock ShipDesignDatablock(StorkShip : DefaultShip)
{
   shipHull    = HullStork;

   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   turretLink8  = "MediumTurret";
   turretWeaponLink8_1  = "MediumEmitter_Civ";
   
   turretLink9  = "SmallTurret";
   turretWeaponLink9_1  = "SmallEmitter_Civ";
   
   turretLink10  = "SmallTurret";
   turretWeaponLink10_1  = "SmallEmitter_Civ";
   
   externalLink7 = "MassBombLauncher_HEAT_Large";
   externalLink11 = "TractorEmitter_medium";
   externalLink12 = "TractorEmitter_medium";
   externalLink13 = "TractorEmitter_medium"; 
};

*/

////////////////////////////////////////////////////////////////////////////////
// ZOMBIE SHIPS
////////////////////////////////////////////////////////////////////////////////



datablock ShipDesignDatablock(Zombie_SickleShip : DefaultZombieShip)
{
   shipHull    = HullZombieSickle;

   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   
   
   externalLink3 = "MediumLauncher_Zombie";
   externalLink4 = "MediumLauncher_Zombie";
   externalLink5 = "MediumLauncher_Zombie";
   externalLink6 = "MediumCannon_zombie";
};

/////////////////////////////////////////////
// THE WORM
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_WormShip : DefaultZombieShip)
{
   shipHull    = HullZombieWorm;

   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   
   
   externalLink5 = "SmallCannon_zombie";
   externalLink6 = "MediumCannon_zombie";
   externalLink7 = "MediumLauncher_Zombie";
   externalLink8 = "MediumLauncher_Zombie";
};

/////////////////////////////////////////////
// THE BLIGHT
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_BlightShip : DefaultZombieShip)
{
   shipHull    = HullZombieBlight;

   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   externalLink7 = "MediumLauncher_Zombie";
   externalLink8 = "MediumCannon_zombie";
   externalLink9 = "MediumCannon_zombie";
   
   turretLink1  = "MediumTurret";
   turretWeaponLink1_1  = "SmallCannon_zombie";
      
   turretLink6  = "MediumTurret";
   turretWeaponLink6_1  = "SmallCannon_zombie";
};


/////////////////////////////////////////////
// BOUNTY SHIPS
/////////////////////////////////////////////

/////////////////////////////////////////////
// BOUNTY LARGE 01
/////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Large_01_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_01;  //This determines what we can put of the ship.
 
   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "HugeLauncher_Civ";
   externalLink7 = "HugeLauncher_Civ";
   externalLink8 = "SmallLauncher_Civ";
   externalLink9 = "SmallLauncher_Civ";
   externalLink10 = "SmallLauncher_Civ";
   
   externalLink11 = "LargeCannon_Pulse_Civ";
   
   externalLink12 = "TractorEmitter_large";
   externalLink13 = "TractorEmitter_large";
   externalLink14 = "TractorEmitter_large";
            
   externalLink15 = "TractorEmitter_medium";
   externalLink16 = "TractorEmitter_medium";
};

/////////////////////////
// Basic ////////////////
/////////////////////////

datablock ShipDesignDatablock(BountyShip_Large_01_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_01;  //This determines what we can put of the ship.
  
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_QuickChargeShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "HugeLauncher";
   externalLink7 = "HugeLauncher";
   externalLink8 = "SmallLauncher";
   externalLink9 = "SmallLauncher";
   externalLink10 = "SmallLauncher";
   
   externalLink11 = "LargeEmitter";
   
   externalLink12 = "LauncherBooster_L";
   externalLink13 = "LauncherBooster_L";
   externalLink14 = "LauncherBooster_L";
            
   externalLink15 = "ShieldBooster_M";
   externalLink16 = "ShieldBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Large_01_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_01;  //This determines what we can put of the ship.
  
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_QuickChargeShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "HugeTorpedoLauncher";
   externalLink7 = "HugeRocketLauncher";
   externalLink8 = "SmallLauncher_GRAV";
   externalLink9 = "SmallLauncher_GRAV";
   externalLink10 = "SmallLauncher_GRAV";
   
   externalLink11 = "LargeEmitter";
   
   externalLink12 = "LauncherBooster_L";
   externalLink13 = "LauncherBooster_L";
   externalLink14 = "LauncherBooster_L";
            
   externalLink15 = "ShieldBooster_M";
   externalLink16 = "ShieldBooster_M";
};

/////////////////////////
// Improved ////////////////
/////////////////////////

datablock ShipDesignDatablock(BountyShip_Large_01_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_01;  //This determines what we can put of the ship.
 
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_QuickChargeShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "HugeRocketLauncher";
   externalLink7 = "HugeRocketLauncher";
   externalLink8 = "SmallLauncher_GRAV";
   externalLink9 = "SmallLauncher_GRAV";
   externalLink10 = "SmallLauncher_GRAV";
   
   externalLink11 = "LargeEmitter_ION";
   
   externalLink12 = "LauncherBooster_L";
   externalLink13 = "LauncherBooster_L";
   externalLink14 = "LauncherBooster_L";
            
   externalLink15 = "ShieldBooster_M";
   externalLink16 = "ShieldBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Large_01_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_01;  //This determines what we can put of the ship.
 
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_QuickChargeShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "HugeLauncher";
   externalLink7 = "HugeLauncher";
   externalLink8 = "SmallLauncher";
   externalLink9 = "SmallLauncher";
   externalLink10 = "SmallLauncher";
   
   externalLink11 = "LargeEmitter_ION";
   
   externalLink12 = "LauncherBooster_L";
   externalLink13 = "LauncherBooster_L";
   externalLink14 = "LauncherBooster_L";
            
   externalLink15 = "ShieldBooster_M";
   externalLink16 = "ShieldBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Large_01_IMPROVED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_01;  //This determines what we can put of the ship.
 
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_StableCloak;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "HugeLauncher";
   externalLink7 = "HugeLauncher";
   externalLink8 = "SmallLauncher";
   externalLink9 = "SmallLauncher";
   externalLink10 = "SmallLauncher";
   
   externalLink11 = "LargeCannon_rapid";
   
   externalLink12 = "LauncherBooster_L";
   externalLink13 = "LauncherBooster_L";
   externalLink14 = "LauncherBooster_L";
            
   externalLink15 = "CloakBooster_M";
   externalLink16 = "CloakBooster_M";
};


/////////////////////////
// Advanced ////////////////
/////////////////////////

datablock ShipDesignDatablock(BountyShip_Large_01_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_01;  //This determines what we can put of the ship.
 
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "HugeTorpedoLauncher";
   externalLink7 = "HugeLauncher_GRAV";
   externalLink8 = "SmallRocketLauncher";
   externalLink9 = "SmallHunterLauncher";
   externalLink10 = "SmallRocketLauncher";
   
   externalLink11 = "LargeCannon_massDriver";
   
   externalLink12 = "LauncherBooster_L";
   externalLink13 = "ShieldBooster_L";
   externalLink14 = "LauncherBooster_L";
            
   externalLink15 = "PointDefenseBeamEmitter_M";
   externalLink16 = "PointDefenseBeamEmitter_M";
};


datablock ShipDesignDatablock(BountyShip_Large_01_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_01;  //This determines what we can put of the ship.
 
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "HugeRocketLauncher";
   externalLink7 = "HugeRocketLauncher";
   externalLink8 = "SmallHunterLauncher";
   externalLink9 = "SmallHunterLauncher";
   externalLink10 = "SmallHunterLauncher";
   
   externalLink11 = "LauncherBooster_L";
   
   externalLink12 = "LauncherBooster_L";
   externalLink13 = "LauncherBooster_L";
   externalLink14 = "LauncherBooster_L";
            
   externalLink15 = "PointDefenseBeamEmitter_M";
   externalLink16 = "PointDefenseBeamEmitter_M";
};

/////////////////////////////////////////////
// BOUNTY LARGE 02
/////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Large_02_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_02;  //This determines what we can put of the ship.
 
   shipEngine            = L_CivEngine;     
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_L";   
   shipArmor_Starboard   = "CivArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "CivArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   
   turretLink6  = "HugeTurret";
   turretWeaponLink6_1  = "HugeEmitter_Civ"; 
   
   turretLink7  = "MediumTurret";
   turretWeaponLink7_1  = "MediumEmitter_Civ"; 
   
   turretLink8  = "MediumTurret";
   turretWeaponLink8_1  = "MediumEmitter_Civ"; 
   
   externalLink9 = "SmallLauncher_Civ";
   externalLink10 = "SmallLauncher_Civ";
   externalLink11 = "TractorEmitter_large";
   externalLink12 = "TractorEmitter_large";
   externalLink13 = "TractorEmitter_medium";
   externalLink14 = "TractorEmitter_medium";
   externalLink15 = "TractorEmitter_medium";

};

///////////////////////////////////
// Basic //////////////////////////
///////////////////////////////////


datablock ShipDesignDatablock(BountyShip_Large_02_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_02;  //This determines what we can put of the ship.
 
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   
   turretLink6  = "HugeTurret";
   turretWeaponLink6_1  = "HugeEmitter"; 
   
   turretLink7  = "MediumTurret";
   turretWeaponLink7_1  = "MediumCannon_pulse"; 
   
   turretLink8  = "MediumTurret";
   turretWeaponLink8_1  = "MediumCannon_pulse"; 
   
   externalLink9 = "SmallTorpedoLauncher";
   externalLink10 = "SmallTorpedoLauncher";
   externalLink11 = "CannonBooster_L";
   externalLink12 = "BeamBooster_L";
   externalLink13 = "ShieldBooster_M";
   externalLink14 = "ScannerEmitter_M";
   externalLink15 = "PointDefenseBeamEmitter_M";

};

datablock ShipDesignDatablock(BountyShip_Large_02_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_02;  //This determines what we can put of the ship.
 
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   
   turretLink6  = "HugeTurret";
   turretWeaponLink6_1  = "HugeCannon_pulse"; 
   
   turretLink7  = "MediumTurret";
   turretWeaponLink7_1  = "MediumEmitter"; 
   
   turretLink8  = "MediumTurret";
   turretWeaponLink8_1  = "MediumEmitter"; 
   
   externalLink9 = "SmallLauncher_Grav";
   externalLink10 = "SmallLauncher_Grav";
   externalLink11 = "CannonBooster_L";
   externalLink12 = "BeamBooster_L";
   externalLink13 = "ShieldBooster_M";
   externalLink14 = "ScannerEmitter_M";
   externalLink15 = "PointDefenseBeamEmitter_M";

};

///////////////////////////////////
// Improved //////////////////////////
///////////////////////////////////


datablock ShipDesignDatablock(BountyShip_Large_02_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_02;  //This determines what we can put of the ship.
 
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_QuickChargeShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   
   turretLink6  = "HugeTurret";
   turretWeaponLink6_1  = "HugeEmitter"; 
   
   turretLink7  = "MediumDoubleTurret";
   turretWeaponLink7_1  = "SmallCannon_rapid"; 
   turretWeaponLink7_2  = "SmallCannon_rapid"; 
   
   turretLink8  = "MediumDoubleTurret";
   turretWeaponLink8_1  = "SmallCannon_rapid"; 
   turretWeaponLink8_2  = "SmallCannon_rapid"; 
   
   externalLink9 = "SmallRocketLauncher";
   externalLink10 = "SmallRocketLauncher";
   externalLink11 = "CannonBooster_L";
   externalLink12 = "CannonBooster_L";
   externalLink13 = "ShieldBooster_M";
   externalLink14 = "ShieldBooster_M";
   externalLink15 = "PointDefenseBeamEmitter_M";

};

datablock ShipDesignDatablock(BountyShip_Large_02_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_02;  //This determines what we can put of the ship.
 
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_QuickChargeShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   
   turretLink6  = "HugeDoubleTurret";
   turretWeaponLink6_1  = "LargeCannon_pulse"; 
   turretWeaponLink6_2  = "LargeCannon_pulse";
   
   turretLink7  = "MediumTurret";
   turretWeaponLink7_1  = "MediumEmitter_ION"; 
  
   
   turretLink8  = "MediumTurret";
   turretWeaponLink8_1  = "MediumEmitter_ION"; 
   
   
   externalLink9 = "SmallRocketLauncher";
   externalLink10 = "SmallRocketLauncher";
   externalLink11 = "CannonBooster_L";
   externalLink12 = "CannonBooster_L";
   externalLink13 = "ShieldBooster_M";
   externalLink14 = "ShieldBooster_M";
   externalLink15 = "PointDefenseBeamEmitter_M";

};


datablock ShipDesignDatablock(BountyShip_Large_02_IMPROVED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_02;  //This determines what we can put of the ship.
 
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_QuickChargeShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   
   turretLink6  = "HugeDoubleTurret";
   turretWeaponLink6_1  = "LargeCannon_rapid"; 
   turretWeaponLink6_2  = "LargeCannon_rapid";
   
   turretLink7  = "LargeFixedTurretMod";
   turretWeaponLink7_1  = "LargeCannon_rapid"; 
  
   
   turretLink8  = "LargeFixedTurretMod";
   turretWeaponLink8_1  = "LargeCannon_rapid"; 
   
   
   externalLink9 = "ReactorBooster_S";
   externalLink10 = "ReactorBooster_S";
   externalLink11 = "CannonBooster_L";
   externalLink12 = "CannonBooster_L";
   externalLink13 = "ShieldBooster_M";
   externalLink14 = "ShieldBooster_M";
   externalLink15 = "ReactorBooster_M";

};

///////////////////////////////////
// Advanced //////////////////////////
///////////////////////////////////


datablock ShipDesignDatablock(BountyShip_Large_02_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_02;  //This determines what we can put of the ship.
 
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   
   turretLink6  = "HugeTriTurret";
   turretWeaponLink6_1  = "LargeCannon_pulse"; 
   turretWeaponLink6_2  = "LargeCannon_pulse";
   turretWeaponLink6_3  = "LargeCannon_pulse";
   
   turretLink7  = "MediumDoubleTurret";
   turretWeaponLink7_1  = "SmallCannon_rapid"; 
   turretWeaponLink7_2  = "SmallCannon_rapid"; 
   
   turretLink8  = "MediumDoubleTurret";
   turretWeaponLink8_1  = "SmallCannon_rapid"; 
   turretWeaponLink8_2  = "SmallCannon_rapid"; 
   
   externalLink9 = "ShieldBooster_S";
   externalLink10 = "ShieldBooster_S";
   externalLink11 = "CannonBooster_L";
   externalLink12 = "CannonBooster_L";
   externalLink13 = "ReactorBooster_M";
   externalLink14 = "ReactorBooster_M";
   externalLink15 = "ReactorBooster_M";

};


datablock ShipDesignDatablock(BountyShip_Large_02_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Large_02;  //This determines what we can put of the ship.
 
   shipEngine            = L_InertialEngine;     
   shipReactor           = L_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_L";   
   shipArmor_Starboard   = "AdvancedArmor_L";
   shipArmor_Aft         = "AdvancedArmor_L";
   shipArmor_Port        = "AdvancedArmor_L";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   
   
   turretLink6  = "HugeTriTurret";
   turretWeaponLink6_1  = "LargeEmitter"; 
   turretWeaponLink6_2  = "LargeEmitter";
   turretWeaponLink6_3  = "LargeEmitter";
   
   turretLink7  = "MediumDoubleTurret";
   turretWeaponLink7_1  = "SmallEmitter_ION"; 
   turretWeaponLink7_2  = "SmallEmitter_ION"; 
   
   turretLink8  = "MediumDoubleTurret";
   turretWeaponLink8_1  = "SmallEmitter_LEECH"; 
   turretWeaponLink8_2  = "SmallEmitter_LEECH"; 
   
   externalLink9 = "ShieldBooster_S";
   externalLink10 = "ShieldBooster_S";
   externalLink11 = "BeamBooster_L";
   externalLink12 = "BeamBooster_L";
   externalLink13 = "ReactorBooster_M";
   externalLink14 = "ReactorBooster_M";
   externalLink15 = "ReactorBooster_M";

};

