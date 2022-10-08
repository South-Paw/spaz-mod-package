
////////////////////////////////////////////////////////////////////////////////
// MEDIUM SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE SCOUT
/////////////////////////////////////////////

datablock ShipDesignDatablock(SaucerShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullSaucer;  //This determines what we can put of the ship. 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink4 = "MediumEmitter_Civ";
   externalLink5 = "MediumCannon_Pulse_Civ";
   externalLink6 = "MediumCannon_Pulse_Civ";
   
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallCannon_Pulse_Civ";
};

//level 25+ (some good tech available already)
datablock ShipDesignDatablock(SaucerShip_Basic : SaucerShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Saucer";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";

   externalLink4 = "MediumEmitter";
   externalLink5 = "MediumCannon_Pulse";
   externalLink6 = "MediumCannon_Pulse";
   
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallEmitter_Civ";
};
datablock ShipDesignDatablock(SaucerShip_Basic_A : SaucerShip_Basic)
{ 
   externalLink4 = "MediumCannon_cluster";
   externalLink5 = "MediumCannon_cluster";
   externalLink6 = "MediumCannon_cluster";
   turretWeaponLink7_1  = "SmallEmitter_ION";
   parentDesign = SaucerShip_Basic; 
};
datablock ShipDesignDatablock(SaucerShip_Basic_B : SaucerShip_Basic)
{ 
   externalLink4 = "MediumEmitter";
   externalLink5 = "MediumEmitter";
   externalLink6 = "MediumEmitter";
   turretWeaponLink7_1  = "SmallCannon_pulse_Civ";
   parentDesign = SaucerShip_Basic; 
};




//35+
datablock ShipDesignDatablock(SaucerShip_Improved : SaucerShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Saucer";   
   
   shipEngine            = M_ThrusterEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";

   externalLink4 = "MediumCannon_rapid";
   externalLink5 = "MediumCannon_rapid";
   externalLink6 = "MediumCannon_rapid";
   
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallEmitter_ION";
};
datablock ShipDesignDatablock(SaucerShip_Improved_A : SaucerShip_Improved)
{        
   externalLink4 = "MediumCannon_Pulse";
   externalLink5 = "MediumCannon_Pulse";
   externalLink6 = "MediumCannon_Pulse";
   
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallEmitter_ION";
   parentDesign = SaucerShip_Improved; 
};
datablock ShipDesignDatablock(SaucerShip_Improved_B : SaucerShip_Improved)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipEngine            = M_BasicEngine;    
   shipShield            = M_StableCloak;
      
   externalLink4 = "MediumEmitter_ION";
   externalLink5 = "MediumCannon_cluster";
   externalLink6 = "MediumCannon_cluster";
   
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallCannon_pulse";
   parentDesign = SaucerShip_Improved; 
};
datablock ShipDesignDatablock(SaucerShip_Improved_C : SaucerShip_Improved)
{        
   externalLink4 = "MediumEmitter";
   externalLink5 = "MediumEmitter";
   externalLink6 = "MediumEmitter";
   
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallCannon_pulse";
   parentDesign = SaucerShip_Improved; 
};




//45+
datablock ShipDesignDatablock(SaucerShip_Advanced : SaucerShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Saucer";   
   
   shipEngine            = M_InertialEngine;    
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";

   externalLink4 = "MediumCannon_rapid";
   externalLink5 = "MediumCannon_massDriver";
   externalLink6 = "MediumCannon_massDriver";
   
   turretLink7  = "SmallFixedTurretMod"; 
   turretWeaponLink7_1  = "ShieldBooster_M";   
};
datablock ShipDesignDatablock(SaucerShip_Advanced_A : SaucerShip_Advanced)
{  
   externalLink4 = "MediumCannon_rapid";
   externalLink5 = "MediumCannon_Pulse";
   externalLink6 = "MediumCannon_Pulse";
    
   turretLink7  = "SmallFixedTurretMod"; 
   turretWeaponLink7_1  = "ShieldBooster_M";   
   parentDesign = SaucerShip_Advanced; 
};
datablock ShipDesignDatablock(SaucerShip_Advanced_B : SaucerShip_Advanced)
{  
   deviceDescriptionBits = $SST_DEVICE_CLOAK;    
   shipShield            = M_ExperimentalCloak;
   
   externalLink4 = "MediumCannon_Pulse";
   externalLink5 = "MediumCannon_Pulse";
   externalLink6 = "MediumCannon_Pulse";
    
   turretLink7  = "SmallFixedTurretMod"; 
   turretWeaponLink7_1  = "CloakBooster_M";  
   parentDesign = SaucerShip_Advanced; 
};
datablock ShipDesignDatablock(SaucerShip_Advanced_C : SaucerShip_Advanced)
{  
   deviceDescriptionBits = $SST_DEVICE_CLOAK;    
   shipShield            = M_ExperimentalCloak;
   
   externalLink4 = "MediumCannon_rapid";
   externalLink5 = "MediumCannon_rapid";
   externalLink6 = "MediumCannon_rapid";
   
   turretLink7  = "SmallFixedTurretMod"; 
   turretWeaponLink7_1  = "CloakBooster_M";  
   parentDesign = SaucerShip_Advanced; 
};
datablock ShipDesignDatablock(SaucerShip_Advanced_D : SaucerShip_Advanced)
{  
   deviceDescriptionBits = $SST_DEVICE_CLOAK;    
   shipShield            = M_ExperimentalCloak;
   
   externalLink4 = "MediumCannon_cluster";
   externalLink5 = "MediumCannon_cluster";
   externalLink6 = "MediumCannon_cluster";
    
   turretLink7  = "SmallFixedTurretMod"; 
   turretWeaponLink7_1  = "CloakBooster_M";  
   parentDesign = SaucerShip_Advanced; 
};
datablock ShipDesignDatablock(SaucerShip_Advanced_E : SaucerShip_Advanced)
{  
   externalLink4 = "ReactorBooster_M";
   externalLink5 = "MediumEmitter_Heavy";
   externalLink6 = "MediumEmitter_Heavy";
    
   turretLink7  = "SmallFixedTurretMod"; 
   turretWeaponLink7_1  = "ReactorBooster_M";   
   parentDesign = SaucerShip_Advanced; 
};

/////////////////////////////////////////////
// THE VOLLEY
/////////////////////////////////////////////

datablock ShipDesignDatablock(VolleyShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullVolley;  //This determines what we can put of the ship. 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink4 = "SmallLauncher_Civ";
   externalLink5 = "SmallLauncher_Civ";
   externalLink6 = "SmallLauncher_Civ";
   externalLink7 = "SmallLauncher_Civ";
   externalLink8 = "MediumLauncher_Civ";
   externalLink9 = "MediumLauncher_Civ";
};

//15+
datablock ShipDesignDatablock(VolleyShip_Basic : VolleyShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Volley";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";

   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallLauncher";
   externalLink6 = "SmallLauncher";
   externalLink7 = "SmallLauncher";
   externalLink8 = "MediumLauncher";
   externalLink9 = "MediumLauncher";
};
datablock ShipDesignDatablock(VolleyShip_Basic_A : VolleyShip_Basic)
{
   externalLink4 = "SmallTorpedoLauncher";
   externalLink5 = "SmallTorpedoLauncher";
   externalLink6 = "SmallTorpedoLauncher";
   externalLink7 = "SmallTorpedoLauncher";
   externalLink8 = "MediumLauncher";
   externalLink9 = "MediumLauncher";
   parentDesign = VolleyShip_Basic; 
};
datablock ShipDesignDatablock(VolleyShip_Basic_B : VolleyShip_Basic)
{
   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallLauncher";
   externalLink6 = "SmallLauncher";
   externalLink7 = "SmallLauncher";
   externalLink8 = "MediumTorpedoLauncher";
   externalLink9 = "MediumTorpedoLauncher";
   parentDesign = VolleyShip_Basic; 
};
datablock ShipDesignDatablock(VolleyShip_Basic_C : VolleyShip_Basic)
{
   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallLauncher";
   externalLink6 = "SmallLauncher";
   externalLink7 = "SmallLauncher";
   externalLink8 = "LauncherBooster_M";
   externalLink9 = "LauncherBooster_M";
   parentDesign = VolleyShip_Basic; 
};




datablock ShipDesignDatablock(VolleyShip_Improved : VolleyShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Volley";   
   
   shipEngine            = M_ThrusterEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";

   externalLink4 = "SmallTorpedoLauncher";
   externalLink5 = "SmallTorpedoLauncher";
   externalLink6 = "SmallTorpedoLauncher";
   externalLink7 = "SmallTorpedoLauncher";
   externalLink8 = "MediumRocketLauncher";
   externalLink9 = "MediumRocketLauncher";
};
datablock ShipDesignDatablock(VolleyShip_Improved_A : VolleyShip_Improved)
{
   externalLink4 = "SmallRocketLauncher";
   externalLink5 = "SmallRocketLauncher";
   externalLink6 = "SmallRocketLauncher";
   externalLink7 = "SmallRocketLauncher";
   externalLink8 = "LauncherBooster_M";
   externalLink9 = "LauncherBooster_M";
   parentDesign = VolleyShip_Improved; 
};
datablock ShipDesignDatablock(VolleyShip_Improved_B : VolleyShip_Improved)
{
   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallLauncher";
   externalLink6 = "SmallRocketLauncher";
   externalLink7 = "SmallRocketLauncher";
   externalLink8 = "MediumTorpedoLauncher";
   externalLink9 = "MediumTorpedoLauncher";
   parentDesign = VolleyShip_Improved; 
};
datablock ShipDesignDatablock(VolleyShip_Improved_C : VolleyShip_Improved)
{
   externalLink4 = "SmallLauncher_GRAV";
   externalLink5 = "SmallLauncher_GRAV";
   externalLink6 = "SmallLauncher_GRAV";
   externalLink7 = "SmallLauncher_GRAV";
   externalLink8 = "MediumTorpedoLauncher";
   externalLink9 = "MediumTorpedoLauncher";
   parentDesign = VolleyShip_Improved; 
};




datablock ShipDesignDatablock(VolleyShip_Advanced : VolleyShip_Basic)
{ 
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Volley";   
   
   shipEngine            = M_InertialEngine;    
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";

   externalLink4 = "SmallRocketLauncher";
   externalLink5 = "ShieldBooster_S";
   externalLink6 = "SmallRocketLauncher";
   externalLink7 = "LauncherBooster_S";
   externalLink8 = "MediumLauncher";
   externalLink9 = "MediumLauncher";
};
datablock ShipDesignDatablock(VolleyShip_Advanced_A : VolleyShip_Advanced)
{
   externalLink4 = "SmallLauncher_GRAV";
   externalLink5 = "SmallLauncher_GRAV";
   externalLink6 = "SmallHunterLauncher";
   externalLink7 = "SmallHunterLauncher";
   externalLink8 = "MediumTorpedoLauncher";
   externalLink9 = "MediumTorpedoLauncher";
   parentDesign = VolleyShip_Advanced; 
};
datablock ShipDesignDatablock(VolleyShip_Advanced_B : VolleyShip_Advanced)
{
   deviceDescriptionBits = $SST_DEVICE_CLOAK;    
   shipShield            = M_ExperimentalCloak;
   
   externalLink4 = "SmallTorpedoLauncher";
   externalLink5 = "SmallTorpedoLauncher";
   externalLink6 = "SmallTorpedoLauncher";
   externalLink7 = "SmallTorpedoLauncher";
   externalLink8 = "MediumTorpedoLauncher";
   externalLink9 = "MediumTorpedoLauncher";
   parentDesign = VolleyShip_Advanced; 
};
datablock ShipDesignDatablock(VolleyShip_Advanced_C : VolleyShip_Advanced)
{
   deviceDescriptionBits = $SST_DEVICE_CLOAK;    
   shipShield            = M_ExperimentalCloak;
   
   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallLauncher";
   externalLink6 = "SmallLauncher";
   externalLink7 = "SmallLauncher";
   externalLink8 = "MediumTorpedoLauncher";
   externalLink9 = "MediumTorpedoLauncher";
   parentDesign = VolleyShip_Advanced; 
};


/////////////////////////////////////////////
// THE TUG
/////////////////////////////////////////////

datablock ShipDesignDatablock(TugShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullTug;  //This determines what we can put of the ship. 
   deviceDescriptionBits = $SST_DEVICE_CARGO; 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
      
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   turretLink4  = "MediumTurret";
   turretWeaponLink4_1  = "MediumEmitter_Civ";   
   
   externalLink5 = "MediumLauncher_Civ";
   externalLink6 = "MediumLauncher_Civ";
   
   externalLink7 = "TractorEmitter_medium";
   externalLink8 = "TractorEmitter_medium";
};

datablock ShipDesignDatablock(TugShip_Basic : TugShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Tug";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";

   turretLink4  = "MediumTurret";
   turretWeaponLink4_1  = "MediumCannon_Pulse";   
   
   externalLink5 = "MediumLauncher";
   externalLink6 = "MediumLauncher";
   
   externalLink7 = "TractorEmitter_medium";
   externalLink8 = "TractorEmitter_medium";
};
datablock ShipDesignDatablock(TugShip_Basic_A : TugShip_Basic)
{   
   turretWeaponLink4_1  = "MediumCannon_Pulse";   
   
   externalLink5 = "MediumLauncher";
   externalLink6 = "MediumLauncher"; 
   parentDesign = TugShip_Basic; 
};
datablock ShipDesignDatablock(TugShip_Basic_B : TugShip_Basic)
{   
   turretWeaponLink4_1  = "MediumCannon_Pulse";   
   
   externalLink5 = "MediumTorpedoLauncher";
   externalLink6 = "MediumTorpedoLauncher"; 
   parentDesign = TugShip_Basic; 
};
datablock ShipDesignDatablock(TugShip_Basic_C : TugShip_Basic)
{   
   turretWeaponLink4_1  = "MediumEmitter";   
   
   externalLink5 = "MediumLauncher";
   externalLink6 = "MediumLauncher"; 
   parentDesign = TugShip_Basic; 
};
datablock ShipDesignDatablock(TugShip_Basic_D : TugShip_Basic)
{   
   turretWeaponLink4_1  = "MediumEmitter_Civ";   
   
   externalLink5 = "MediumTorpedoLauncher";
   externalLink6 = "MediumTorpedoLauncher"; 
   parentDesign = TugShip_Basic; 
};




datablock ShipDesignDatablock(TugShip_Improved : TugShip)
{ 
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Tug";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";

   turretLink4  = "MediumTurret";
   turretWeaponLink4_1  = "MediumEmitter";   
     
   externalLink5 = "MediumRocketLauncher";
   externalLink6 = "MediumRocketLauncher";
   
   externalLink7 = "ScannerEmitter_M";
   externalLink8 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(TugShip_Improved_A : TugShip_Improved)
{    
   turretWeaponLink4_1  = "MediumEmitter";   
      
   externalLink5 = "MediumTorpedoLauncher";
   externalLink6 = "MediumTorpedoLauncher";
   
   externalLink7 = "PointDefenseBeamEmitter_M";
   externalLink8 = "PointDefenseBeamEmitter_M";
   parentDesign = TugShip_Improved; 
};
datablock ShipDesignDatablock(TugShip_Improved_B : TugShip_Improved)
{    
   turretWeaponLink4_1  = "MediumEmitter";   
      
   externalLink5 = "MediumLauncher";
   externalLink6 = "MediumLauncher";
   
   externalLink7 = "PointDefenseBeamEmitter_M";
   externalLink8 = "PointDefenseBeamEmitter_M";
   parentDesign = TugShip_Improved; 
};
datablock ShipDesignDatablock(TugShip_Improved_C : TugShip_Improved)
{    
   turretLink4  = "MediumFixedTurretMod";
   turretWeaponLink4_1  = "LargeCannon_Pulse";   
      
   externalLink5 = "MediumTorpedoLauncher";
   externalLink6 = "MediumTorpedoLauncher";
   
   externalLink7 = "PointDefenseBeamEmitter_M";
   externalLink8 = "PointDefenseBeamEmitter_M";
   parentDesign = TugShip_Improved; 
};
datablock ShipDesignDatablock(TugShip_Improved_D : TugShip_Improved)
{    
   
   turretLink4  = "MediumDoubleTurret";
   turretWeaponLink4_1  = "SmallCannon_rapid";   
   turretWeaponLink4_2  = "SmallCannon_rapid";
      
   externalLink5 = "MediumLauncher";
   externalLink6 = "MediumLauncher";
   
   externalLink7 = "PointDefenseBeamEmitter_M";
   externalLink8 = "PointDefenseBeamEmitter_M";
   parentDesign = TugShip_Improved; 
};






datablock ShipDesignDatablock(TugShip_Advanced : TugShip)
{ 
   designDescriptionBits = $SST_DESIGN_Advanced;
   friendlyName = "Advanced Tug";   
   
   shipEngine            = M_InertialEngine;    
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";

   turretLink4  = "MediumFixedTurretMod";
   turretWeaponLink4_1  = "LargeCannon_cluster";   
   
   externalLink5 = "MediumLauncher_GRAV";
   externalLink6 = "MediumHunterLauncher";
   
   externalLink7 = "ScannerEmitter_M";
   externalLink8 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(TugShip_Advanced_A : TugShip_Advanced)
{    
   turretLink4  = "MediumDoubleTurret";
   turretWeaponLink4_1  = "SmallCannon_rapid";   
   turretWeaponLink4_2  = "SmallCannon_rapid";
      
   externalLink5 = "MediumLauncher";
   externalLink6 = "MediumLauncher";
   
   externalLink7 = "LauncherBooster_M";
   externalLink8 = "ShieldBooster_M";
   parentDesign = TugShip_Advanced; 
};
datablock ShipDesignDatablock(TugShip_Advanced_B : TugShip_Advanced)
{    
   turretLink4  = "MediumFixedTurretMod";
   turretWeaponLink4_1  = "LargeCannon_rapid";   
      
   externalLink5 = "MediumRocketLauncher";
   externalLink6 = "MediumRocketLauncher";
   
   externalLink7 = "LauncherBooster_M";
   externalLink8 = "ShieldBooster_M";
   parentDesign = TugShip_Advanced; 
};
datablock ShipDesignDatablock(TugShip_Advanced_C : TugShip_Advanced)
{    
   turretLink4  = "MediumDoubleTurret";
   turretWeaponLink4_1  = "SmallCannon_massDriver";   
   turretWeaponLink4_2  = "SmallCannon_massDriver";   
      
   externalLink5 = "MediumHunterLauncher";
   externalLink6 = "MediumHunterLauncher";
   
   externalLink7 = "PointDefenseBeamEmitter_M";
   externalLink8 = "PointDefenseBeamEmitter_M";
   parentDesign = TugShip_Advanced; 
};

datablock ShipDesignDatablock(TugShip_Advanced_D : TugShip_Advanced)
{    
   turretLink4  = "MediumDoubleTurret";
   turretWeaponLink4_1  = "SmallEmitter_ION";   
   turretWeaponLink4_2  = "SmallEmitter_ION";   
      
   externalLink5 = "MediumTorpedoLauncher";
   externalLink6 = "MediumTorpedoLauncher";
   
   externalLink7 = "PointDefenseBeamEmitter_M";
   externalLink8 = "PointDefenseBeamEmitter_M";
   parentDesign = TugShip_Advanced; 
};


/////////////////////////////////////////////
// THE GULL
/////////////////////////////////////////////

datablock ShipDesignDatablock(GullShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullGull;  //This determines what we can put of the ship.
   deviceDescriptionBits = $SST_DEVICE_BOMB; 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
        
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink1 = "Dropper_Small_Civ_Launcher";
   externalLink6 = "MediumCannon_Pulse_Civ";
   externalLink7 = "MediumCannon_Pulse_Civ";
};

datablock ShipDesignDatablock(GullShip_Basic : GullShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   friendlyName = "Basic Gull";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   externalLink1 = "MassBombLauncher_EXP_Medium";
   externalLink6 = "MediumCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
};
datablock ShipDesignDatablock(GullShip_Basic_A : GullShip_Basic)
{      
   deviceDescriptionBits = $SST_DEVICE_GENERIC;
   externalLink1 = "DeployableTurretLauncher_Basic_M";
   externalLink6 = "MediumCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   parentDesign = GullShip_Basic; 
};
datablock ShipDesignDatablock(GullShip_Basic_B : GullShip_Basic)
{      
   deviceDescriptionBits = $SST_DEVICE_MINE;
   externalLink1 = "Dropper_Small_Explosive_Launcher";
   externalLink6 = "MediumEmitter";
   externalLink7 = "MediumEmitter";
   parentDesign = GullShip_Basic; 
};
datablock ShipDesignDatablock(GullShip_Basic_C : GullShip_Basic)
{      
   deviceDescriptionBits = $SST_DEVICE_MINE;
   externalLink1 = "Dropper_Small_Explosive_Launcher";
   externalLink6 = "MediumCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   parentDesign = GullShip_Basic; 
};
datablock ShipDesignDatablock(GullShip_Basic_D : GullShip_Basic)
{      
   deviceDescriptionBits = $SST_DEVICE_GENERIC;
   externalLink1 = "DeployableTurretLauncher_Surplus_M";
   externalLink6 = "MediumEmitter";
   externalLink7 = "MediumEmitter";
   parentDesign = GullShip_Basic; 
};


datablock ShipDesignDatablock(GullShip_Improved : GullShip)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   deviceDescriptionBits = $SST_DEVICE_BOMB | $SST_DEVICE_CLOAK;
   friendlyName = "Improved Gull";   
   
   shipEngine            = M_ThrusterEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_BasicCloak;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   externalLink1 = "MassBombLauncher_EXP_Medium";
   externalLink6 = "CloakBooster_M";
   externalLink7 = "CloakBooster_M";
};
datablock ShipDesignDatablock(GullShip_Improved_A : GullShip_Basic)
{      
   deviceDescriptionBits = $SST_DEVICE_CLOAK;
   externalLink1 = "DeployableTurretLauncher_Leech_M";
   externalLink6 = "MediumCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   parentDesign = GullShip_Basic; 
};
datablock ShipDesignDatablock(GullShip_Improved_B : GullShip_Improved)
{    
   deviceDescriptionBits = $SST_DEVICE_MINE | $SST_DEVICE_CLOAK;
   externalLink1 = "Dropper_Small_Explosive_Launcher";
   externalLink6 = "MediumCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   parentDesign = GullShip_Improved; 
};
datablock ShipDesignDatablock(GullShip_Improved_C : GullShip_Basic)
{      
   deviceDescriptionBits = $SST_DEVICE_CLOAK;
   externalLink1 = "DeployableTurretLauncher_Ion_M";
   externalLink6 = "MediumCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   parentDesign = GullShip_Basic; 
};
datablock ShipDesignDatablock(GullShip_Improved_D : GullShip_Improved)
{    
   deviceDescriptionBits = $SST_DEVICE_BOMB | $SST_DEVICE_CLOAK;
   externalLink1 = "MassBombLauncher_ION_Medium";
   externalLink6 = "CloakBooster_M";
   externalLink7 = "CloakBooster_M";
   parentDesign = GullShip_Improved; 
};
datablock ShipDesignDatablock(GullShip_Improved_E : GullShip_Improved)
{    
   deviceDescriptionBits = $SST_DEVICE_BOMB | $SST_DEVICE_CLOAK;
   externalLink1 = "DeployableTurretLauncher_Basic_M";
   externalLink6 = "MediumCannon_cluster";
   externalLink7 = "MediumCannon_cluster";
   parentDesign = GullShip_Improved; 
};





datablock ShipDesignDatablock(GullShip_Advanced : GullShip)
{ 
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   deviceDescriptionBits = $SST_DEVICE_MINE | $SST_DEVICE_CLOAK; 
   friendlyName = "Advanced Gull";   
   
   shipEngine            = M_InertialEngine;    
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_StableCloak;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   externalLink1 = "DeployableTurretLauncher_TorpRack_M";
   externalLink6 = "MediumEmitter_ION";
   externalLink7 = "MediumEmitter_ION";
};
datablock ShipDesignDatablock(GullShip_Advanced_A : GullShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_MINE | $SST_DEVICE_CLOAK; 
     
   externalLink1 = "Dropper_Small_Ion_Launcher";
   externalLink6 = "MediumCannon_massDriver";
   externalLink7 = "MediumCannon_massDriver";
   parentDesign = GullShip_Advanced; 
};
datablock ShipDesignDatablock(GullShip_Advanced_B : GullShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_BOMB | $SST_DEVICE_CLOAK; 
     
   externalLink1 = "DeployableTurretLauncher_TorpRack_M";
   externalLink6 = "MediumCannon_cluster";
   externalLink7 = "MediumCannon_cluster";
   parentDesign = GullShip_Advanced; 
};
datablock ShipDesignDatablock(GullShip_Advanced_C : GullShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_BOMB | $SST_DEVICE_CLOAK; 
     
   externalLink1 = "MassBombLauncher_ION_Medium";
   externalLink6 = "MediumCannon_rapid";
   externalLink7 = "MediumCannon_rapid";
   parentDesign = GullShip_Advanced; 
};
datablock ShipDesignDatablock(GullShip_Advanced_D : GullShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_MINE | $SST_DEVICE_CLOAK; 
     
   externalLink1 = "Dropper_Small_MicroLaser_Launcher";
   externalLink6 = "MediumCannon_pulse";
   externalLink7 = "MediumCannon_pulse";
   parentDesign = GullShip_Advanced; 
};
datablock ShipDesignDatablock(GullShip_Advanced_E : GullShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_MINE | $SST_DEVICE_CLOAK; 
     
   externalLink1 = "DeployableTurretLauncher_BattleStation_M";
   externalLink6 = "MediumCannon_rapid";
   externalLink7 = "MediumCannon_rapid";
   parentDesign = GullShip_Advanced; 
};


////////////////////////////////////////////////////////////////////////////////
// CIV SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE ARRAY
/////////////////////////////////////////////

datablock ShipDesignDatablock(ArrayShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullArray;  //This determines what we can put of the ship. 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
        
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink3 = "MediumEmitter_Civ";
   externalLink4 = "MediumEmitter_Civ";
   externalLink5 = "TractorEmitter_medium";
   externalLink6 = "TractorEmitter_medium";
   externalLink7 = "TractorEmitter_medium";
};


datablock ShipDesignDatablock(ArrayShip_Basic : ArrayShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Array";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
     
   externalLink3 = "MediumEmitter";
   externalLink4 = "MediumEmitter";
   externalLink5 = "TractorEmitter_medium";
   externalLink6 = "TractorEmitter_medium";
   externalLink7 = "TractorEmitter_medium";
};
datablock ShipDesignDatablock(ArrayShip_Basic_A : ArrayShip_Basic)
{   
   externalLink3 = "MediumEmitter_Civ";
   externalLink4 = "MediumEmitter_Civ";
   parentDesign = ArrayShip_Basic; 
};



datablock ShipDesignDatablock(ArrayShip_Improved : ArrayShip)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Array";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
   
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
     
   externalLink3 = "MediumEmitter";
   externalLink4 = "MediumEmitter";
   externalLink5 = "PointDefenseBeamEmitter_M";
   externalLink6 = "ScannerEmitter_M";
   externalLink7 = "ScannerEmitter_M";
};
datablock ShipDesignDatablock(ArrayShip_Improved_A : ArrayShip_Improved)
{   
   deviceDescriptionBits = $SST_DEVICE_CLOAK;
   shipShield            = M_StableCloak;
    
   externalLink3 = "MediumEmitter_ION";
   externalLink4 = "MediumEmitter_ION";
      
   externalLink5 = "PointDefenseBeamEmitter_M";
   externalLink6 = "PointDefenseBeamEmitter_M";
   externalLink7 = "PointDefenseBeamEmitter_M";
   parentDesign = ArrayShip_Improved; 
};



datablock ShipDesignDatablock(ArrayShip_Advanced : ArrayShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   deviceDescriptionBits = $SST_DEVICE_CLOAK;
   friendlyName = "Advanced Array"; 
   
   shipEngine            = M_InertialEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_ExperimentalCloak;  
   
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   externalLink3 = "MediumEmitter_ION";
   externalLink4 = "SmallCannon_massDriver";
   externalLink5 = "ScannerEmitter_M";
   externalLink6 = "PointDefenseBeamEmitter_M";
   externalLink7 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(ArrayShip_Advanced_A : ArrayShip_Advanced)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   deviceDescriptionBits = "";
   
   shipEngine            = M_InertialEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_FortressShield;  
   
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   externalLink3 = "MediumEmitter_Heavy";
   externalLink4 = "MediumEmitter_Heavy";
   externalLink5 = "ReactorBooster_M";
   externalLink6 = "ShieldBooster_M";
   externalLink7 = "ShieldBooster_M";
   parentDesign = ArrayShip_Advanced; 
};


/////////////////////////////////////////////
// THE POUNDER
/////////////////////////////////////////////

datablock ShipDesignDatablock(PounderShip : DefaultShip)
{
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   //Determines the skeleton for the ship.  
   shipHull    = HullPounder;  //This determines what we can put of the ship. 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   turretLink1  = "SmallTurret";
   turretWeaponLink1_1  = "SmallCannon_Pulse_Civ";   
   
   externalLink6 = "TractorEmitter_medium";
   externalLink7 = "TractorEmitter_medium";
   externalLink8 = "MassBombLauncher_HEAT_Medium";
};


datablock ShipDesignDatablock(PounderShip_Basic : PounderShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   friendlyName = "Basic Pounder";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
     
   turretLink1  = "SmallTurret";
   turretWeaponLink1_1  = "SmallCannon_Pulse_Civ";   
   
   externalLink6 = "TractorEmitter_medium";
   externalLink7 = "TractorEmitter_medium";
   
   externalLink8 = "MassBombLauncher_EXP_Medium";
};
datablock ShipDesignDatablock(PounderShip_Basic_A : PounderShip_Basic)
{   
   deviceDescriptionBits = $SST_DEVICE_MINE; 
   turretWeaponLink1_1  = "SmallCannon_Pulse_Civ";     
   externalLink8 = "Dropper_Small_Explosive_Launcher";
   parentDesign = PounderShip_Basic; 
};
datablock ShipDesignDatablock(PounderShip_Basic_B : PounderShip_Basic)
{   
   deviceDescriptionBits = $SST_DEVICE_GENERIC; 
   turretWeaponLink1_1  = "SmallCannon_Pulse";     
   externalLink8 = "DeployableTurretLauncher_Basic_M";
   parentDesign = PounderShip_Basic; 
};
   


datablock ShipDesignDatablock(PounderShip_Improved : PounderShip)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   deviceDescriptionBits = $SST_DEVICE_GENERIC; 
   friendlyName = "Improved Pounder";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
   
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
     
   turretLink1  = "SmallTurret";
   turretWeaponLink1_1  = "SmallCannon_Pulse";   
   
   externalLink6 = "PointDefenseBeamEmitter_M";
   externalLink7 = "PointDefenseBeamEmitter_M";
   
   externalLink8 = "DeployableTurretLauncher_Ion_M";
};
datablock ShipDesignDatablock(PounderShip_Improved_A : PounderShip_Improved)
{   
   deviceDescriptionBits = $SST_DEVICE_MINE; 
   turretWeaponLink1_1  = "SmallCannon_Pulse";     
   externalLink8 = "Dropper_Small_Explosive_Launcher";
   parentDesign = PounderShip_Improved; 
};
datablock ShipDesignDatablock(PounderShip_Improved_B : PounderShip_Improved)
{   
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   turretWeaponLink1_1  = "SmallCannon_Pulse";     
   externalLink8 = "MassBombLauncher_Ion_Medium";
   parentDesign = PounderShip_Improved; 
};
datablock ShipDesignDatablock(PounderShip_Improved_C : PounderShip_Improved)
{   
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   turretWeaponLink1_1  = "SmallCannon_Pulse";     
   externalLink8 = "MassBombLauncher_EXP_Medium";
   parentDesign = PounderShip_Improved; 
};
datablock ShipDesignDatablock(PounderShip_Improved_D : PounderShip_Improved)
{   
   deviceDescriptionBits = $SST_DEVICE_GENERIC; 
   turretWeaponLink1_1  = "SmallCannon_rapid";     
   externalLink8 = "DeployableTurretLauncher_Basic_M";
   parentDesign = PounderShip_Improved; 
};



datablock ShipDesignDatablock(PounderShip_Advanced : PounderShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   deviceDescriptionBits = $SST_DEVICE_BOMB; 
   friendlyName = "Advanced Pounder";   
   
   shipEngine            = M_ThrusterEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_FortressShield;
   
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   turretLink1  = "SmallTurret";
   turretWeaponLink1_1  = "SmallEmitter_ION";   
   
   externalLink6 = "PointDefenseBeamEmitter_M";
   externalLink7 = "PointDefenseBeamEmitter_M";
   
   externalLink8 = "MassBombLauncher_EXP_Medium";
};
datablock ShipDesignDatablock(PounderShip_Advanced_A : PounderShip_Advanced)
{   
   deviceDescriptionBits = $SST_DEVICE_GENERIC; 
   turretWeaponLink1_1  = "SmallEmitter_ION";     
   externalLink8 = "DeployableTurretLauncher_TorpRack_M";
   parentDesign = PounderShip_Advanced; 
};
datablock ShipDesignDatablock(PounderShip_Advanced_B : PounderShip_Advanced)
{   
   deviceDescriptionBits = $SST_DEVICE_MINE; 
   turretWeaponLink1_1  = "SmallCannon_Pulse";     
   externalLink8 = "Dropper_Small_MicroLaser_Launcher";
   parentDesign = PounderShip_Advanced; 
};
datablock ShipDesignDatablock(PounderShip_Advanced_C : PounderShip_Advanced)
{   
   deviceDescriptionBits = $SST_DEVICE_GENERIC; 
   turretWeaponLink1_1  = "SmallCannon_rapid";     
   externalLink8 = "DeployableTurretLauncher_BattleStation_M";
   parentDesign = PounderShip_Advanced; 
};

/////////////////////////////////////////////
// THE YACHT
/////////////////////////////////////////////

datablock ShipDesignDatablock(YachtShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullYacht;  //This determines what we can put of the ship. 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink1 = "TractorEmitter_medium";
   externalLink6 = "MediumLauncher_Civ";
   externalLink7 = "MediumLauncher_Civ";
   externalLink8 = "MediumCannon_Pulse_Civ";
   externalLink9 = "MediumCannon_Pulse_Civ";
};


datablock ShipDesignDatablock(YachtShip_Basic : YachtShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Yacht";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
     
   externalLink1 = "TractorEmitter_medium";
   externalLink6 = "MediumLauncher";
   externalLink7 = "MediumLauncher";
   externalLink8 = "MediumCannon_Pulse";
   externalLink9 = "MediumCannon_Pulse";
};
datablock ShipDesignDatablock(YachtShip_Basic_A : YachtShip_Basic)
{   
   externalLink6 = "MediumTorpedoLauncher";
   externalLink7 = "MediumTorpedoLauncher";
   externalLink8 = "MediumCannon_Pulse_Civ";
   externalLink9 = "MediumCannon_Pulse_Civ";
   parentDesign = YachtShip_Basic; 
};
datablock ShipDesignDatablock(YachtShip_Basic_B : YachtShip_Basic)
{   
   externalLink6 = "MediumLauncher";
   externalLink7 = "MediumLauncher";
   externalLink8 = "MediumEmitter";
   externalLink9 = "MediumEmitter";
   parentDesign = YachtShip_Basic; 
};
datablock ShipDesignDatablock(YachtShip_Basic_C : YachtShip_Basic)
{   
   externalLink6 = "MediumTorpedoLauncher";
   externalLink7 = "MediumTorpedoLauncher";
   externalLink8 = "MediumEmitter_Civ";
   externalLink9 = "MediumEmitter_Civ";
   parentDesign = YachtShip_Basic; 
};




datablock ShipDesignDatablock(YachtShip_Improved : YachtShip)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Yacht";   
   
   shipEngine            = M_ThrusterEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
   
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   externalLink1 = "PointDefenseBeamEmitter_M";
   externalLink6 = "MediumRocketLauncher";
   externalLink7 = "MediumRocketLauncher";
   externalLink8 = "MediumCannon_Cluster";
   externalLink9 = "MediumCannon_Cluster";
};
datablock ShipDesignDatablock(YachtShip_Improved_A : YachtShip_Improved)
{   
   externalLink1 = "TractorEmitter_medium";
   externalLink6 = "MediumTorpedoLauncher";
   externalLink7 = "CrewBooster_M";
   externalLink8 = "KamakazieCannon_M";
   externalLink9 = "CrewBooster_M";
   parentDesign = YachtShip_Improved; 
};
datablock ShipDesignDatablock(YachtShip_Improved_B : YachtShip_Improved)
{   
   externalLink6 = "MediumTorpedoLauncher";
   externalLink7 = "MediumTorpedoLauncher";
   externalLink8 = "MediumEmitter_ION";
   externalLink9 = "MediumEmitter_ION";
   parentDesign = YachtShip_Improved; 
};
datablock ShipDesignDatablock(YachtShip_Improved_C : YachtShip_Improved)
{   
   externalLink6 = "MediumLauncher";
   externalLink7 = "MediumLauncher";
   externalLink8 = "MediumEmitter";
   externalLink9 = "MediumEmitter";
   parentDesign = YachtShip_Improved; 
};
datablock ShipDesignDatablock(YachtShip_Improved_D : YachtShip_Improved)
{   
   externalLink6 = "MediumLauncher";
   externalLink7 = "MediumLauncher";
   externalLink8 = "MediumCannon_Pulse";
   externalLink9 = "MediumCannon_Pulse";
   parentDesign = YachtShip_Improved; 
};


datablock ShipDesignDatablock(YachtShip_Advanced : YachtShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;   
   friendlyName = "Advanced Yacht";   
   
   shipEngine            = M_ThrusterEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_FortressShield;
   
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
     
   externalLink1 = "PointDefenseBeamEmitter_M";
   externalLink6 = "MediumLauncher_GRAV";
   externalLink7 = "MediumLauncher_GRAV";
   externalLink8 = "KamakazieCannon_M";
   externalLink9 = "MediumCannon_Pulse";
};
datablock ShipDesignDatablock(YachtShip_Advanced_A : YachtShip_Advanced)
{   
   deviceDescriptionBits = $SST_DEVICE_CLOAK;
   shipShield            = M_StableCloak;
   
   externalLink1 = "TractorEmitter_medium";
   externalLink6 = "MediumRocketLauncher";
   externalLink7 = "MediumRocketLauncher";
   externalLink8 = "KamakazieCannon_M";
   externalLink9 = "KamakazieCannon_M";
   parentDesign = YachtShip_Advanced; 
};
datablock ShipDesignDatablock(YachtShip_Advanced_C : YachtShip_Advanced)
{   
   externalLink6 = "MediumTorpedoLauncher";
   externalLink7 = "MediumTorpedoLauncher";
   externalLink8 = "MediumEmitter_ION";
   externalLink9 = "MediumEmitter_ION";
   parentDesign = YachtShip_Advanced; 
};
datablock ShipDesignDatablock(YachtShip_Advanced_D : YachtShip_Advanced)
{   
   externalLink6 = "MediumLauncher";
   externalLink7 = "MediumLauncher";
   externalLink8 = "MediumCannon_Pulse";
   externalLink9 = "MediumCannon_Pulse";
   parentDesign = YachtShip_Advanced; 
};



/////////////////////////////////////////////
// THE HOUND
/////////////////////////////////////////////

datablock ShipDesignDatablock(HoundShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullHound;  //This determines what we can put of the ship. 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   externalLink8 = "TractorEmitter_medium";
   
   turretLink6  = "MediumTurret";
   turretWeaponLink6_1  = "MediumCannon_Pulse_Civ";   
   
   turretLink7  = "MediumTurret";
   turretWeaponLink7_1  = "MediumCannon_Pulse_Civ";
};


datablock ShipDesignDatablock(HoundShip_Basic : HoundShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Hound";   
   
   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
     
   externalLink8 = "TractorEmitter_medium";     
     
   turretLink6  = "MediumTurret";
   turretWeaponLink6_1  = "MediumCannon_Pulse";   
   
   turretLink7  = "MediumTurret";
   turretWeaponLink7_1  = "MediumCannon_Pulse";
};
datablock ShipDesignDatablock(HoundShip_Basic_A : HoundShip_Basic)
{        
   turretWeaponLink6_1  = "MediumEmitter";   
   turretWeaponLink7_1  = "MediumEmitter";
   parentDesign = HoundShip_Basic;
};
datablock ShipDesignDatablock(HoundShip_Basic_B : HoundShip_Basic)
{        
   turretWeaponLink6_1  = "MediumEmitter_Civ";   
   turretWeaponLink7_1  = "MediumCannon_pulse_Civ";
   parentDesign = HoundShip_Basic;
};



datablock ShipDesignDatablock(HoundShip_Improved : HoundShip)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Hound";   
   
   shipEngine            = M_ThrusterEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
   
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
     
   externalLink8 = "CrewBooster_M";     
     
   turretLink6  = "MediumTurret";
   turretWeaponLink6_1  = "KamakazieCannon_M";   
   
   turretLink7  = "MediumTurret";
   turretWeaponLink7_1  = "MediumCannon_pulse";
};
datablock ShipDesignDatablock(HoundShip_Improved_A : HoundShip_Improved)
{        
   externalLink8 = "PointDefenseBeamEmitter_M";    
   
   
   turretLink6  = "MediumFixedTurretMod";
   turretWeaponLink6_1  = "LargeEmitter_Civ";   
   turretLink7  = "MediumFixedTurretMod";
   turretWeaponLink7_1  = "LargeEmitter_Civ";
   parentDesign = HoundShip_Improved;
};
datablock ShipDesignDatablock(HoundShip_Improved_B : HoundShip_Improved)
{        
   externalLink8 = "PointDefenseBeamEmitter_M";    
   turretWeaponLink6_1  = "MediumEmitter";   
   turretWeaponLink7_1  = "MediumEmitter";
   parentDesign = HoundShip_Improved;
};
datablock ShipDesignDatablock(HoundShip_Improved_C : HoundShip_Improved)
{        
   turretLink6  = "MediumDoubleTurret";
   turretWeaponLink6_1  = "SmallCannon_rapid";   
   turretWeaponLink6_2  = "SmallCannon_rapid";   
   turretLink7  = "MediumDoubleTurret";
   turretWeaponLink7_1  = "SmallCannon_rapid";
   turretWeaponLink7_2  = "SmallCannon_rapid";
   parentDesign = HoundShip_Improved;
};
datablock ShipDesignDatablock(HoundShip_Improved_D : HoundShip_Improved)
{        
   turretLink6  = "MediumDoubleTurret";
   turretWeaponLink6_1  = "SmallEmitter";   
   turretWeaponLink6_2  = "SmallEmitter";   
   turretLink7  = "MediumDoubleTurret";
   turretWeaponLink7_1  = "SmallEmitter";
   turretWeaponLink7_2  = "SmallEmitter";
   parentDesign = HoundShip_Improved;
};



datablock ShipDesignDatablock(HoundShip_Advanced : HoundShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Hound";   
   
   shipEngine            = M_InertialEngine;    
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
   
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   externalLink8 = "PointDefenseBeamEmitter_M";   
   
   turretLink6  = "MediumTurret";
   turretWeaponLink6_1  = "MediumEmitter_Heavy";   
   
   turretLink7  = "MediumTurret";
   turretWeaponLink7_1  = "MediumEmitter_Heavy";
};
datablock ShipDesignDatablock(HoundShip_Advanced_A : HoundShip_Advanced)
{        
   externalLink8 = "PointDefenseBeamEmitter_M";    
   
   turretLink6  = "MediumDoubleTurret";
   turretWeaponLink6_1  = "SmallEmitter_ION"; 
   turretWeaponLink6_2  = "SmallEmitter_ION"; 
   turretLink7  = "MediumDoubleTurret";  
   turretWeaponLink7_1  = "SmallCannon_massDriver";
   turretWeaponLink7_2  = "SmallCannon_massDriver";
   parentDesign = HoundShip_Advanced;
};
datablock ShipDesignDatablock(HoundShip_Advanced_B : HoundShip_Advanced)
{        
   deviceDescriptionBits = $SST_DEVICE_CLOAK;
   shipShield            = M_ExperimentalCloak;
   
   externalLink8 = "CrewBooster_M";          
   turretWeaponLink6_1  = "KamakazieCannon_M";   
   turretWeaponLink7_1  = "MediumCannon_pulse";
   parentDesign = HoundShip_Advanced;
};
datablock ShipDesignDatablock(HoundShip_Advanced_C : HoundShip_Advanced)
{        
   externalLink8 = "PointDefenseBeamEmitter_M";    
   turretLink6  = "MediumFixedTurretMod";
   turretWeaponLink6_1  = "LargeCannon_rapid";   
   turretLink7  = "MediumFixedTurretMod";
   turretWeaponLink7_1  = "LargeCannon_rapid";
   parentDesign = HoundShip_Advanced;
};


////////////////////////////////////////////////////////////////////////////////
// ZOMBIE SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE SCAB
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_ScabShip : DefaultZombieShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullZombieScab;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
     
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink3 = "SmallCannon_zombie";
   externalLink4 = "SmallLauncher_Zombie";
   externalLink5 = "MediumCannon_zombie";
};

/////////////////////////////////////////////
// THE BLOWFISH
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_BlowfishShip : DefaultZombieShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullZombieBlowfish;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
     
   //Weapons also have weight, so no need to add all available weapons if less will do
   turretLink1  = "LargeDoubleTurret_zombie";
      turretWeaponLink1_1  = "SmallCannon_zombie";
      turretWeaponLink1_2  = "MediumCannon_zombie";
   
   externalLink5 = "SmallLauncher_Zombie";
};


/////////////////////////////////////////////
// BOUNTY SHIPS
/////////////////////////////////////////////

/////////////////////////////////////////////
// BOUNTY MED 01
/////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Medium_01_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumCannon_Pulse_Civ";
   externalLink7 = "MediumCannon_Pulse_Civ";
   externalLink8 = "HiveLauncher_Fighter";
   externalLink9 = "TractorEmitter_medium";
   externalLink10 = "TractorEmitter_medium";
   externalLink11 = "TractorEmitter_medium";
   externalLink12 = "TractorEmitter_medium";
};

////////////////////////////////
// Basic ///////////////////////
////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Medium_01_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicCloak;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   externalLink8 = "HiveLauncher_Fighter_Cloaked";
   externalLink9 = "CannonBooster_M";
   externalLink10 = "CannonBooster_M";
   externalLink11 = "CannonBooster_M";
   externalLink12 = "CannonBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_01_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_BasicReactor;
   shipShield            = M_QuickChargeShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumEmitter";
   externalLink7 = "MediumEmitter";
   externalLink8 = "HiveLauncher_Fighter";
   externalLink9 = "BeamBooster_M";
   externalLink10 = "BeamBooster_M";
   externalLink11 = "ShieldBooster_M";
   externalLink12 = "ShieldBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_01_BASIC_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_BasicReactor;
   shipShield            = M_QuickChargeShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumEmitter_ION";
   externalLink7 = "MediumEmitter_ION";
   externalLink8 = "HiveLauncher_Bomber";
   externalLink9 = "BeamBooster_M";
   externalLink10 = "BeamBooster_M";
   externalLink11 = "ShieldBooster_M";
   externalLink12 = "ShieldBooster_M";
};

////////////////////////////////
// Improved ///////////////////////
////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Medium_01_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_StableCloak;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   externalLink8 = "HiveLauncher_Zapper";
   externalLink9 = "CannonBooster_M";
   externalLink10 = "CannonBooster_M";
   externalLink11 = "CannonBooster_M";
   externalLink12 = "CannonBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_01_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_StableCloak;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumCannon_rapid";
   externalLink7 = "MediumCannon_rapid";
   externalLink8 = "HiveLauncher_Bomber";
   externalLink9 = "CannonBooster_M";
   externalLink10 = "CannonBooster_M";
   externalLink11 = "CannonBooster_M";
   externalLink12 = "CannonBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Medium_01_IMPROVED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_StableCloak;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumCannon_cluster";
   externalLink7 = "MediumCannon_cluster";
   externalLink8 = "HiveLauncher_Bomber";
   externalLink9 = "CannonBooster_M";
   externalLink10 = "CannonBooster_M";
   externalLink11 = "CannonBooster_M";
   externalLink12 = "CannonBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Medium_01_IMPROVED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumEmitter_ION";
   externalLink7 = "MediumEmitter_ION";
   externalLink8 = "HiveLauncher_Bomber";
   externalLink9 = "BeamBooster_M";
   externalLink10 = "BeamBooster_M";
   externalLink11 = "BeamBooster_M";
   externalLink12 = "BeamBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_01_IMPROVED_E : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumEmitter";
   externalLink7 = "MediumEmitter";
   externalLink8 = "HiveLauncher_Bomber";
   externalLink9 = "BeamBooster_M";
   externalLink10 = "BeamBooster_M";
   externalLink11 = "BeamBooster_M";
   externalLink12 = "BeamBooster_M";
};
////////////////////////////////
// Advanced ///////////////////////
////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Medium_01_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumEmitter";
   externalLink7 = "MediumEmitter";
   externalLink8 = "HiveLauncher_Bomber";
   externalLink9 = "BeamBooster_M";
   externalLink10 = "BeamBooster_M";
   externalLink11 = "BeamBooster_M";
   externalLink12 = "BeamBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_01_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumEmitter_Heavy";
   externalLink7 = "MediumEmitter_Heavy";
   externalLink8 = "HiveLauncher_Bomber";
   externalLink9 = "ReactorBooster_M";
   externalLink10 = "ReactorBooster_M";
   externalLink11 = "BeamBooster_M";
   externalLink12 = "BeamBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_01_ADVANCED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_ExperimentalCloak;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumCannon_pulse";
   externalLink7 = "MediumCannon_pulse";
   externalLink8 = "HiveLauncher_Zapper_Cloaked";
   externalLink9 = "CannonBooster_M";
   externalLink10 = "CannonBooster_M";
   externalLink11 = "CannonBooster_M";
   externalLink12 = "CannonBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_01_ADVANCED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_ExperimentalCloak;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumCannon_rapid";
   externalLink7 = "MediumCannon_rapid";
   externalLink8 = "HiveLauncher_Zapper_Cloaked";
   externalLink9 = "CannonBooster_M";
   externalLink10 = "CannonBooster_M";
   externalLink11 = "CannonBooster_M";
   externalLink12 = "CannonBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Medium_01_ADVANCED_E : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_01;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_ExperimentalCloak;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "MediumCannon_massDriver";
   externalLink7 = "MediumCannon_massDriver";
   externalLink8 = "HiveLauncher_Zapper_Cloaked";
   externalLink9 = "CannonBooster_M";
   externalLink10 = "CannonBooster_M";
   externalLink11 = "CannonBooster_M";
   externalLink12 = "CannonBooster_M";
};
/////////////////////////////////////////////
// BOUNTY MED 02
/////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Medium_02_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeCannon_Pulse_Civ";
   externalLink7 = "MediumCannon_Pulse_Civ";
   externalLink8 = "MediumCannon_Pulse_Civ";
   externalLink9 = "MediumLauncher_Civ";
   externalLink10 = "MediumLauncher_Civ";
   externalLink11 = "MiningTractorEmitter";
   externalLink12 = "MiningTractorEmitter";
   externalLink13 = "TractorEmitter_medium";
   externalLink14 = "TractorEmitter_medium";
};


/////////////////////////////////////
// Basic ////////////////////////////
/////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Medium_02_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   externalLink8 = "MediumCannon_Pulse";
   externalLink9 = "MediumLauncher";
   externalLink10 = "MediumLauncher";
   externalLink11 = "ShieldBooster_S";
   externalLink12 = "ShieldBooster_S";
   externalLink13 = "CannonBooster_M";
   externalLink14 = "CannonBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Medium_02_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeEmitter";
   externalLink7 = "MediumEmitter";
   externalLink8 = "MediumEmitter";
   externalLink9 = "MediumTorpedoLauncher";
   externalLink10 = "MediumTorpedoLauncher";
   externalLink11 = "ShieldBooster_S";
   externalLink12 = "ShieldBooster_S";
   externalLink13 = "LauncherBooster_M";
   externalLink14 = "BeamBooster_M";
};


/////////////////////////////////////
// Improved ////////////////////////////
/////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Medium_02_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeCannon_Pulse";
   externalLink7 = "MediumCannon_Rapid";
   externalLink8 = "MediumCannon_Rapid";
   externalLink9 = "MediumRocketLauncher";
   externalLink10 = "MediumRocketLauncher";
   externalLink11 = "ShieldBooster_S";
   externalLink12 = "ShieldBooster_S";
   externalLink13 = "CannonBooster_M";
   externalLink14 = "CannonBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_02_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeCannon_Rapid";
   externalLink7 = "MediumCannon_Rapid";
   externalLink8 = "MediumCannon_Rapid";
   externalLink9 = "MediumLauncher_GRAV";
   externalLink10 = "MediumLauncher_GRAV";
   externalLink11 = "CannonBooster_S";
   externalLink12 = "CannonBooster_S";
   externalLink13 = "CannonBooster_M";
   externalLink14 = "CannonBooster_M";
};

datablock ShipDesignDatablock(BountyShip_Medium_02_IMPROVED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeEmitter_ION";
   externalLink7 = "MediumEmitter_LEECH";
   externalLink8 = "MediumEmitter_LEECH";
   externalLink9 = "MediumTorpedoLauncher";
   externalLink10 = "MediumTorpedoLauncher";
   externalLink11 = "LauncherBooster_S";
   externalLink12 = "LauncherBooster_S";
   externalLink13 = "ShieldBooster_M";
   externalLink14 = "ShieldBooster_M";
};

/////////////////////////////////////
// Advanced ////////////////////////////
/////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Medium_02_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeCannon_massDriver";
   externalLink7 = "MediumCannon_Rapid";
   externalLink8 = "MediumCannon_Rapid";
   externalLink9 = "MediumHunterLauncher";
   externalLink10 = "MediumHunterLauncher";
   externalLink11 = "ShieldBooster_S";
   externalLink12 = "ShieldBooster_S";
   externalLink13 = "CannonBooster_M";
   externalLink14 = "CannonBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Medium_02_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeCannon_Pulse";
   externalLink7 = "MediumCannon_Pulse";
   externalLink8 = "MediumCannon_Pulse";
   externalLink9 = "CannonBooster_M";
   externalLink10 = "CannonBooster_M";
   externalLink11 = "CannonBooster_S";
   externalLink12 = "CannonBooster_S";
   externalLink13 = "CannonBooster_M";
   externalLink14 = "CannonBooster_M";
};



datablock ShipDesignDatablock(BountyShip_Medium_02_ADVANCED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeEmitter_Heavy";
   externalLink7 = "MediumEmitter_Heavy";
   externalLink8 = "MediumEmitter_Heavy";
   externalLink9 = "ReactorBooster_M";
   externalLink10 = "ReactorBooster_M";
   externalLink11 = "BeamBooster_S";
   externalLink12 = "BeamBooster_S";
   externalLink13 = "ShieldBooster_M";
   externalLink14 = "ShieldBooster_M";
};


datablock ShipDesignDatablock(BountyShip_Medium_02_ADVANCED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Medium_02;  //This determines what we can put of the ship. 

   shipEngine            = M_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_ExperimentalCloak;
     
   
   
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_M";   
   shipArmor_Starboard   = "AdvancedArmor_M";
   shipArmor_Aft         = "AdvancedArmor_M";
   shipArmor_Port        = "AdvancedArmor_M";
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "LargeEmitter_ION";
   externalLink7 = "LauncherBooster_M";
   externalLink8 = "LauncherBooster_M";
   externalLink9 = "MediumLauncher";
   externalLink10 = "MediumLauncher";
   externalLink11 = "LauncherBooster_S";
   externalLink12 = "LauncherBooster_S";
   externalLink13 = "LauncherBooster_M";
   externalLink14 = "LauncherBooster_M";
};


