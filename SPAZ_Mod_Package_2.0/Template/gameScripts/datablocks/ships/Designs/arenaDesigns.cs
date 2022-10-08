////////////////////////////////////////////////////////////////////////////////
// special arena designs
////////////////////////////////////////////////////////////////////////////////

datablock ShipDesignDatablock(DartShip_ArenaSpecial_01 : DartShip)
{   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
   
   externalLink3 = "EngineBooster_S"; 
   externalLink4 = "EngineBooster_S"; 
   
   includeInSSTDatabase = false;    
};

datablock ShipDesignDatablock(DartShip_ArenaSpecial_02 : DartShip)
{   
   externalLink3 = "SmallEmitter_Civ"; 
   externalLink4 = "ShieldBooster_S"; 
   
   includeInSSTDatabase = false;    
};

datablock ShipDesignDatablock(DartShip_ArenaSpecial_03 : DartShip)
{   
   externalLink3 = "ShieldBooster_S"; 
   externalLink4 = "ShieldBooster_S"; 
   
   includeInSSTDatabase = false;    
};

datablock ShipDesignDatablock(MuleShip_ArenaSpecial_01 : MuleShip)
{     
   shipEngine            = L_BasicEngine;     
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "CivArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";

   externalLink3 = "PointDefenseBeamEmitter_L";
   externalLink4 = "PointDefenseBeamEmitter_L";
   
   externalLink9 = "LargeTorpedoLauncher";
   externalLink10 = "LargeLauncher";
   
   turretLink5  = "SmallTurret";
   turretWeaponLink5_1  = "SmallEmitter";
   
   turretLink6  = "LargeTurret";
   turretWeaponLink6_1  = "LargeEmitter";
   
   includeInSSTDatabase = false;
};
datablock ShipDesignDatablock(MuleShip_ArenaSpecial_02 : MuleShip_ArenaSpecial_01)
{    
   externalLink9 = "LargeLauncher";
   externalLink10 = "LargeLauncher"; 
   turretWeaponLink5_1  = "SmallEmitter";
   turretWeaponLink6_1  = "LargeEmitter_Civ"; 
   
   includeInSSTDatabase = false;    
};
datablock ShipDesignDatablock(MuleShip_ArenaSpecial_03 : MuleShip_ArenaSpecial_01)
{  
   externalLink9 = "LargeLauncher_Civ";
   externalLink10 = "LargeLauncher_Civ"; 
   turretWeaponLink5_1  = "SmallEmitter";
   turretWeaponLink6_1  = "LargeEmitter_Civ"; 
   
   includeInSSTDatabase = false;   
};

datablock ShipDesignDatablock(BigBusShip_ArenaSpecial_01 : BigBusShip_Advanced)
{ 
   externalLink7 = "LargeCannon_rapid";
   
   includeInSSTDatabase = false;   
};

datablock ShipDesignDatablock(BountyShip_Small_01_ArenaSpecial_01 : BountyShip_Small_01_ADVANCED_D)
{
   externalLink6 = "HugeCannon_cluster";
   includeInSSTDatabase = false;  
};
datablock ShipDesignDatablock(BountyShip_Small_01_ArenaSpecial_02 : BountyShip_Small_01_ADVANCED_D)
{
   externalLink6 = "HugeCannon_pulse";
   includeInSSTDatabase = false;  
};

datablock ShipDesignDatablock(RightHookShip_ArenaSpecial_01 : RightHookShip_Advanced)
{ 
   externalLink3 = "LargeTorpedoLauncher";
   externalLink4 = "LargeCannon_massDriver";
   externalLink5 = "ReactorBooster_L";
   externalLink6 = "LargeCannon_massDriver";
   parentDesign = RightHookShip_Advanced; 
   
   includeInSSTDatabase = false;  
};

datablock ShipDesignDatablock(CabShip_ArenaSpecial_01 : CabShip_advanced)
{     
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "PointDefenseBeamEmitter_S"; 
   externalLink4 = "SmallCannon_rapid"; 
   externalLink5 = "SmallCannon_rapid"; 
   parentDesign = CabShip_advanced;   
   
   includeInSSTDatabase = false;         
};

datablock ShipDesignDatablock(ArrayShip_ArenaSpecial_01 : ArrayShip)
{
   shipHull    = HullArray;  

   shipEngine            = M_BasicEngine;    
   shipReactor           = M_HighCapacityReactor;
   shipShield            = M_QuickChargeShield;
   
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   externalLink3 = "EngineBooster_M";
   externalLink4 = "EngineBooster_M";
   externalLink5 = "PointDefenseBeamEmitter_M";
   externalLink6 = "PointDefenseBeamEmitter_M";
   externalLink7 = "PointDefenseBeamEmitter_M"; 
   
   includeInSSTDatabase = false;
};

datablock ShipDesignDatablock(ArrayShip_ArenaSpecial_02 : ArrayShip)
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
   
   externalLink3 = "MediumCannon_Cluster";
   externalLink4 = "SmallCannon_massDriver";
   externalLink5 = "ScannerEmitter_M";
   externalLink6 = "PointDefenseBeamEmitter_M";
   externalLink7 = "PointDefenseBeamEmitter_M";
   
   includeInSSTDatabase = false;   
};

datablock ShipDesignDatablock(OutpostBase_ArenaSpecial_01 : DefaultShip)
{
   shipHull    = HullBase_Outpost;  

   shipEngine            = Station_CivEngine;   
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
  
   externalLink2   = "PointDefenseBeamEmitter_L";  
   externalLink4   = "PointDefenseBeamEmitter_L";  
   
   turretLink3  = "MediumTurret";
   turretWeaponLink3_1  = "MediumCannon_Pulse";
   
   turretLink5  = "LargeMiningDoubleTurret";
   turretWeaponLink5_1  = "MediumEmitter_Civ";
   turretWeaponLink5_2  = "MediumEmitter_Civ";
   
   includeInSSTDatabase = false;
};

datablock ShipDesignDatablock(BeaconBase_03_ArenaSpecial_01 : BeaconBase_01)
{
   shipHull    = HullBeacon_03;
   
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
   
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink3   = "PointDefenseBeamEmitter_L";  
   externalLink4   = "PointDefenseBeamEmitter_L";  
   externalLink5   = "PointDefenseBeamEmitter_L";  
   
   turretLink2  = "MediumTurret";
   turretWeaponLink2_1  = "MediumEmitter_Civ";
   
   includeInSSTDatabase = false;
};