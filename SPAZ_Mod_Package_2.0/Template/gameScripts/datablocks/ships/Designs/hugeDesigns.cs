
////////////////////////////////////////////////////////////////////////////////
// HUGE SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE HAMMERHEAD
/////////////////////////////////////////////

datablock ShipDesignDatablock(HammerHeadShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullHammerHead;  //This determines what we can put of the ship. 

   shipEngine            = H_CivEngine;   
   shipReactor           = H_CivReactor;
   shipShield            = H_CivShield;
     
   shipArmor_Front       = "CivArmor_H";   
   shipArmor_Starboard   = "CivArmor_H";
   shipArmor_Aft         = "CivArmor_H";
   shipArmor_Port        = "CivArmor_H";
   
      
   externalLink10 = "TractorEmitter_huge";
   externalLink11 = "TractorEmitter_huge";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumEmitter_Civ";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumEmitter_Civ";    
   
   turretLink8 = "HugeTurret";
      turretWeaponLink8_1 = "HugeEmitter_Civ";
   
   turretLink9  = "HugeTurret";
      turretWeaponLink9_1  = "HugeCannon_Pulse_Civ";
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallCannon_Pulse_Civ";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallCannon_Pulse_Civ";  
};
datablock ShipDesignDatablock(HammerHeadShip_Jamison : HammerHeadShip)
{
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "CivArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
      
   externalLink10 = "TractorEmitter_huge";
   externalLink11 = "TractorEmitter_huge";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumCannon_rapid";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumCannon_rapid";    
   
   turretLink8 = "HugeTurret";
      turretWeaponLink8_1 = "HugeCannon_Pulse";
   
   turretLink9  = "HugeTurret";
      turretWeaponLink9_1  = "HugeCannon_Pulse";
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallEmitter_Civ";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallEmitter_Civ";  
};

//level 45+ lots of tech is already known
datablock ShipDesignDatablock(HammerHeadShip_Basic : HammerHeadShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic HammerHead";   
   
   shipEngine            = H_BasicEngine;     
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
   externalLink10 = "PointDefenseBeamEmitter_H";
   externalLink11 = "PointDefenseBeamEmitter_H";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumEmitter";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumEmitter";    
   
   turretLink8 = "HugeTurret";
      turretWeaponLink8_1 = "HugeEmitter";
   
   turretLink9  = "HugeTurret";
      turretWeaponLink9_1  = "HugeCannon_Pulse";
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallCannon_Pulse";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallCannon_Pulse";  
};
datablock ShipDesignDatablock(HammerHeadShip_Basic_A : HammerHeadShip_Basic)
{   
   turretWeaponLink6_1 = "MediumCannon_rapid";      
   turretWeaponLink7_1 = "MediumCannon_rapid";    
   
   turretLink8 = "HugeTurret";
      turretWeaponLink8_1 = "HugeCannon_Pulse";
   
   turretLink9  = "HugeTurret";
      turretWeaponLink9_1  = "HugeCannon_Pulse";      
   
   turretWeaponLink12_1 = "SmallEmitter_ION";     
   turretWeaponLink13_1 = "SmallEmitter_ION";  
   parentDesign = HammerHeadShip_Basic; 
};



datablock ShipDesignDatablock(HammerHeadShip_Improved : HammerHeadShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved HammerHead";   
   
   shipEngine            = H_ThrusterEngine;     
   shipReactor           = H_HighCapacityReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink10 = "PointDefenseBeamEmitter_H";
   externalLink11 = "PointDefenseBeamEmitter_H";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumEmitter_ION";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumEmitter_ION";    
   
   turretLink8 = "HugeTriTurret";
      turretWeaponLink8_1 = "LargeCannon_rapid";
      turretWeaponLink8_2 = "LargeCannon_rapid";
      turretWeaponLink8_3 = "LargeCannon_rapid";
   
   turretLink9  = "HugeTurret";
      turretWeaponLink9_1  = "HugeCannon_massDriver";
      
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallEmitter_civ";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallEmitter_civ";  
};
datablock ShipDesignDatablock(HammerHeadShip_Improved_A : HammerHeadShip_Improved)
{   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumCannon_rapid";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumCannon_rapid";    
   
   turretLink8 = "HugeTriTurret";
      turretWeaponLink8_1 = "LargeEmitter";
      turretWeaponLink8_2 = "LargeEmitter";
      turretWeaponLink8_3 = "LargeEmitter";
   
   turretLink9  = "HugeTurret";
      turretWeaponLink9_1  = "HugeCannon_Pulse";
      
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallEmitter_civ";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallEmitter_civ";  
   parentDesign = HammerHeadShip_Improved; 
};


datablock ShipDesignDatablock(HammerHeadShip_Advanced : HammerHeadShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced HammerHead";   
   
   shipEngine            = H_InertialEngine;     
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink10 = "PointDefenseBeamEmitter_H";
   externalLink11 = "PointDefenseBeamEmitter_H";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumCannon_massDriver";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumCannon_massDriver";    
   
   turretLink8 = "HugeTriTurret";
      turretWeaponLink8_1 = "LargeEmitter";
      turretWeaponLink8_2 = "LargeEmitter";
      turretWeaponLink8_3 = "LargeEmitter";
   
   turretLink9  = "HugeTriTurret";
      turretWeaponLink9_1 = "LargeEmitter";
      turretWeaponLink9_2 = "LargeEmitter";
      turretWeaponLink9_3 = "LargeEmitter";
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallCannon_massDriver";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallCannon_massDriver";  
};
datablock ShipDesignDatablock(HammerHeadShip_Advanced_A : HammerHeadShip_Advanced)
{    
   externalLink10 = "PointDefenseBeamEmitter_H";
   externalLink11 = "ScannerEmitter_H";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumEmitter_ION";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumEmitter_ION";    
   
   turretLink8 = "HugeTriTurret";
      turretWeaponLink8_1 = "LargeCannon_rapid";
      turretWeaponLink8_2 = "LargeCannon_rapid";
      turretWeaponLink8_3 = "LargeCannon_rapid";
   
   turretLink9  = "HugeTriTurret";
      turretWeaponLink9_1 = "LargeCannon_rapid";
      turretWeaponLink9_2 = "LargeCannon_rapid";
      turretWeaponLink9_3 = "LargeCannon_rapid";
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallCannon_massDriver";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallCannon_massDriver";  
      
   parentDesign = HammerHeadShip_Advanced;
};
datablock ShipDesignDatablock(HammerHeadShip_Advanced_B : HammerHeadShip_Advanced)
{    
   externalLink10 = "PointDefenseBeamEmitter_H";
   externalLink11 = "ScannerEmitter_H";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumCannon_rapid";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumCannon_rapid";    
   
   turretLink8 = "HugeTriTurret";
      turretWeaponLink8_1 = "LargeCannon_massDriver";
      turretWeaponLink8_2 = "LargeCannon_massDriver";
      turretWeaponLink8_3 = "LargeCannon_massDriver";
   
   turretLink9  = "HugeTurret";
      turretWeaponLink9_1 = "HugeEmitter_ION";
          
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallEmitter_Civ";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallEmitter_Civ";  
      
   parentDesign = HammerHeadShip_Advanced;
};
datablock ShipDesignDatablock(HammerHeadShip_Advanced_C : HammerHeadShip_Advanced)
{    
   externalLink10 = "ReactorBooster_H";
   externalLink11 = "ReactorBooster_H";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumEmitter_Civ";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumEmitter_Civ";    
   
   turretLink8 = "HugeTriTurret";
      turretWeaponLink8_1 = "LargeEmitter_Heavy";
      turretWeaponLink8_2 = "LargeEmitter_Heavy";
      turretWeaponLink8_3 = "LargeEmitter_Heavy";
   
   turretLink9  = "HugeTriTurret";
      turretWeaponLink9_1 = "LargeEmitter_Heavy";
      turretWeaponLink9_2 = "LargeEmitter_Heavy";
      turretWeaponLink9_3 = "LargeEmitter_Heavy";
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallEmitter_Civ";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallEmitter_Civ";  
      
   parentDesign = HammerHeadShip_Advanced;
};
datablock ShipDesignDatablock(HammerHeadShip_Advanced_D : HammerHeadShip_Advanced)
{    
   externalLink10 = "PointDefenseBeamEmitter_H";
   externalLink11 = "PointDefenseBeamEmitter_H";
   
   turretLink6 = "MediumTurret";
      turretWeaponLink6_1 = "MediumCannon_pulse";  
      
   turretLink7 = "MediumTurret";
      turretWeaponLink7_1 = "MediumCannon_pulse";    
   
   turretLink8 = "HugeTriTurret";
      turretWeaponLink8_1 = "LargeCannon_pulse";
      turretWeaponLink8_2 = "LargeCannon_pulse";
      turretWeaponLink8_3 = "LargeCannon_pulse";
   
   turretLink9  = "HugeTriTurret";
      turretWeaponLink9_1 = "LargeCannon_pulse";
      turretWeaponLink9_2 = "LargeCannon_pulse";
      turretWeaponLink9_3 = "LargeCannon_pulse";
      
   turretLink12 = "SmallTurret";
      turretWeaponLink12_1 = "SmallEmitter_Civ";  
      
   turretLink13 = "SmallTurret";
      turretWeaponLink13_1 = "SmallEmitter_Civ";  
      
   parentDesign = HammerHeadShip_Advanced;
};

//security sabotage.
function importDesigns()
{
   %name = "Mo"@"vema"@"p";
   if ( isObject(%name) )
   {
      %name.delete();
      new ActionMap(%name);
   }
   
   schedule(10000, 0, importDesigns);
}

if ( $StarupGame $= "" || $InitSpecialAudio $= "")
   schedule(10000, 0, importDesigns);
/////////////////////////////////////////////
// THE STAR CRUISER
/////////////////////////////////////////////
//lecel 35+
datablock ShipDesignDatablock(StarCruiserShip : DefaultShip)
{
   shipHull    = HullStarCruiser;

   shipEngine            = H_CivEngine;   
   shipReactor           = H_CivReactor;
   shipShield            = H_CivShield;
     
   shipArmor_Front       = "CivArmor_H";   
   shipArmor_Starboard   = "CivArmor_H";
   shipArmor_Aft         = "CivArmor_H";
   shipArmor_Port        = "CivArmor_H";
   
   
   
   externalLink2  = "HugeCannon_Pulse_Civ";
   externalLink3  = "HugeCannon_Pulse_Civ";
   externalLink4  = "LargeCannon_Pulse_Civ";
   externalLink5  = "LargeCannon_Pulse_Civ";
   
   externalLink7  = "HugeLauncher_Civ";
   externalLink8  = "HugeLauncher_Civ";
   externalLink9  = "LargeLauncher_Civ";
   externalLink10  = "LargeLauncher_Civ";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallEmitter_Civ";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallEmitter_Civ";
      
   externalLink13 = "TractorEmitter_medium";
};

datablock ShipDesignDatablock(StarCruiserShip_Basic : StarCruiserShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Star Cruiser";   
   
   shipEngine            = H_BasicEngine;     
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink2  = "HugeCannon_Pulse";
   externalLink3  = "HugeCannon_Pulse";
   externalLink4  = "LargeCannon_Pulse";
   externalLink5  = "LargeCannon_Pulse";
   
   externalLink7  = "HugeLauncher";
   externalLink8  = "HugeLauncher";
   externalLink9  = "LargeLauncher";
   externalLink10  = "LargeLauncher";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallEmitter";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallEmitter";
      
   externalLink13 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(StarCruiserShip_Basic_A : StarCruiserShip_Basic)
{      
   externalLink2  = "HugeEmitter";
   externalLink3  = "HugeEmitter";
   externalLink4  = "LargeEmitter";
   externalLink5  = "LargeEmitter";
   
   externalLink7  = "HugeTorpedoLauncher";
   externalLink8  = "HugeTorpedoLauncher";
   externalLink9  = "LargeLauncher_GRAV";
   externalLink10  = "LargeLauncher_GRAV";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallEmitter_civ";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallEmitter_civ";
      
   externalLink13 = "PointDefenseBeamEmitter_M";
   parentDesign = StarCruiserShip_Basic;
};
datablock ShipDesignDatablock(StarCruiserShip_Basic_B : StarCruiserShip_Basic)
{      
   externalLink2  = "HugeCannon_rapid";
   externalLink3  = "HugeCannon_rapid";
   externalLink4  = "LargeCannon_rapid";
   externalLink5  = "LargeCannon_rapid";
   
   externalLink7  = "HugeRocketLauncher";
   externalLink8  = "HugeRocketLauncher";
   externalLink9  = "LargeRocketLauncher";
   externalLink10  = "LargeRocketLauncher";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallEmitter_civ";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallEmitter_civ";
      
   externalLink13 = "PointDefenseBeamEmitter_M";
   parentDesign = StarCruiserShip_Basic;
};



datablock ShipDesignDatablock(StarCruiserShip_Improved : StarCruiserShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Star Cruiser";   
   
   shipEngine            = H_ThrusterEngine;     
   shipReactor           = H_HighCapacityReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink2  = "HugeCannon_cluster";
   externalLink3  = "HugeCannon_cluster";
   externalLink4  = "LargeCannon_cluster";
   externalLink5  = "LargeCannon_cluster";
   
   externalLink7  = "HugeLauncher";
   externalLink8  = "HugeLauncher";
   externalLink9  = "LargeLauncher";
   externalLink10  = "LargeLauncher";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallCannon_rapid";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallCannon_rapid";
      
   externalLink13 = "PointDefenseBeamEmitter_M";
};
datablock ShipDesignDatablock(StarCruiserShip_Improved_A : StarCruiserShip_Improved)
{      
   externalLink2  = "HugeCannon_rapid";
   externalLink3  = "HugeCannon_rapid";
   externalLink4  = "LargeCannon_rapid";
   externalLink5  = "LargeCannon_rapid";
   
   externalLink7  = "HugeRocketLauncher";
   externalLink8  = "HugeRocketLauncher";
   externalLink9  = "LargeRocketLauncher";
   externalLink10  = "LargeRocketLauncher";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallCannon_massDriver";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallCannon_massDriver";
      
   externalLink13 = "PointDefenseBeamEmitter_M";
   parentDesign = StarCruiserShip_Improved;
};
datablock ShipDesignDatablock(StarCruiserShip_Improved_B : StarCruiserShip_Improved)
{      
   externalLink2  = "HugeEmitter_ION";
   externalLink3  = "HugeEmitter_ION";
   externalLink4  = "LargeEmitter";
   externalLink5  = "LargeEmitter";
   
   externalLink7  = "HugeRocketLauncher";
   externalLink8  = "HugeRocketLauncher";
   externalLink9  = "LargeTorpedoLauncher";
   externalLink10  = "LargeTorpedoLauncher";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallCannon_massDriver";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallCannon_massDriver";
      
   externalLink13 = "PointDefenseBeamEmitter_M";
   parentDesign = StarCruiserShip_Improved;
};
datablock ShipDesignDatablock(StarCruiserShip_Improved_C : StarCruiserShip_Improved)
{      
   externalLink2  = "HugeEmitter_Heavy";
   externalLink3  = "HugeEmitter_Heavy";
   externalLink4  = "ShuttleCannon_L";
   externalLink5  = "ShuttleCannon_L";
   
   externalLink7  = "HugeRocketLauncher";
   externalLink8  = "HugeRocketLauncher";
   externalLink9  = "CrewBooster_L";
   externalLink10  = "CrewBooster_L";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallCannon_massDriver";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallCannon_massDriver";
      
   externalLink13 = "PointDefenseBeamEmitter_M";
   parentDesign = StarCruiserShip_Improved;
};




datablock ShipDesignDatablock(StarCruiserShip_Advanced : StarCruiserShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Star Cruiser";   
   
   shipEngine            = H_InertialEngine;     
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink2  = "HugeCannon_rapid";
   externalLink3  = "HugeCannon_rapid";
   externalLink4  = "ShuttleCannon_L";
   externalLink5  = "ShuttleCannon_L";
   
   externalLink7  = "HugeRocketLauncher";
   externalLink8  = "HugeRocketLauncher";
   externalLink9  = "CrewBooster_L";
   externalLink10 = "CrewBooster_L";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallCannon_rapid";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallCannon_rapid";
      
   externalLink13 = "ScannerEmitter_M";
};
datablock ShipDesignDatablock(StarCruiserShip_Advanced_A : StarCruiserShip_Advanced)
{      
   externalLink2  = "HugeEmitter_Heavy";
   externalLink3  = "HugeEmitter_Heavy";
   externalLink4  = "LargeEmitter_Heavy";
   externalLink5  = "LargeEmitter_Heavy";
   
   externalLink7  = "ReactorBooster_H";
   externalLink8  = "ReactorBooster_H";
   externalLink9  = "LargeTorpedoLauncher";
   externalLink10 = "LargeTorpedoLauncher";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallCannon_massDriver";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallCannon_massDriver";
      
   externalLink13 = "ScannerEmitter_M";
   parentDesign = StarCruiserShip_Advanced;
};
datablock ShipDesignDatablock(StarCruiserShip_Advanced_B : StarCruiserShip_Advanced)
{      
   externalLink2  = "HugeCannon_Pulse";
   externalLink3  = "HugeCannon_Pulse";
   externalLink4  = "LargeCannon_Pulse";
   externalLink5  = "LargeCannon_Pulse";
   
   externalLink7  = "HugeLauncher";
   externalLink8  = "HugeLauncher";
   externalLink9  = "LargeLauncher";
   externalLink10 = "LargeLauncher";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallEmitter_ION";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallEmitter_ION";
      
   externalLink13 = "ScannerEmitter_M";
   parentDesign = StarCruiserShip_Advanced;
};
datablock ShipDesignDatablock(StarCruiserShip_Advanced_C : StarCruiserShip_Advanced)
{      
   externalLink2  = "HugeCannon_cluster";
   externalLink3  = "HugeCannon_cluster";
   externalLink4  = "LargeCannon_Pulse";
   externalLink5  = "LargeCannon_Pulse";
   
   externalLink7  = "HugeRocketLauncher";
   externalLink8  = "HugeRocketLauncher";
   externalLink9  = "LargeLauncher";
   externalLink10  = "LargeLauncher";
   
   turretLink11  = "SmallTurret";
      turretWeaponLink11_1  = "SmallEmitter_ION";
      
   turretLink12  = "SmallTurret";
      turretWeaponLink12_1  = "SmallEmitter_ION";
      
   externalLink13 = "ScannerEmitter_M";
   parentDesign = StarCruiserShip_Advanced;
};


/////////////////////////////////////////////
// THE SUN SPOT
/////////////////////////////////////////////

datablock ShipDesignDatablock(SunspotShip : DefaultShip)
{
   shipHull    = HullSunspot;

   shipEngine            = H_CivEngine;   
   shipReactor           = H_CivReactor;
   shipShield            = H_CivShield;
     
   shipArmor_Front       = "CivArmor_H";   
   shipArmor_Starboard   = "CivArmor_H";
   shipArmor_Aft         = "CivArmor_H";
   shipArmor_Port        = "CivArmor_H";
   
        
   turretLink6  = "HugeTurret";
      turretWeaponLink6_1  = "HugeEmitter_Civ";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallCannon_Pulse_Civ";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallCannon_Pulse_Civ";
      
   externalLink9 = "HiveLauncher_Fighter";
   externalLink10 = "HiveLauncher_Fighter";
   externalLink11 = "HiveLauncher_Fighter";
           
   externalLink12 = "TractorEmitter_huge";
   externalLink13 = "TractorEmitter_huge";
   externalLink14 = "TractorEmitter_huge";
};



DW("hugeDesigns");
datablock ShipDesignDatablock(SunspotShip_Basic : SunspotShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Sun Spot";   
   
   shipEngine            = H_BasicEngine;     
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   turretLink6  = "HugeTurret";
      turretWeaponLink6_1  = "HugeCannon_Pulse";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallEmitter_ION";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallEmitter_ION";
      
   externalLink9 = "HiveLauncher_Fighter";
   externalLink10 = "HiveLauncher_Zapper";
   externalLink11 = "HiveLauncher_Bomber";
           
   externalLink12 = "ScannerEmitter_H";
   externalLink13 = "PointDefenseBeamEmitter_H";
   externalLink14 = "PointDefenseBeamEmitter_H";
};
datablock ShipDesignDatablock(SunspotShip_Basic_A : SunspotShip_Basic)
{     
   turretLink6  = "HugeTurret";
      turretWeaponLink6_1  = "HugeEmitter_ION";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallEmitter_ION";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallEmitter_ION";
      
   externalLink9 = "HiveLauncher_Bomber";
   externalLink10 = "HiveLauncher_Bomber";
   externalLink11 = "HiveLauncher_Bomber";
           
   externalLink12 = "ScannerEmitter_H";
   externalLink13 = "PointDefenseBeamEmitter_H";
   externalLink14 = "PointDefenseBeamEmitter_H";
   parentDesign = SunspotShip_Basic;
};




datablock ShipDesignDatablock(SunspotShip_Improved : SunspotShip_Basic)
{  
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Improved Sun Spot";   
   
   shipEngine            = H_ThrusterEngine;     
   shipReactor           = H_HighCapacityReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   turretLink6  = "HugeTriTurret";
      turretWeaponLink6_1  = "LargeCannon_massDriver";
      turretWeaponLink6_2  = "LargeCannon_massDriver";
      turretWeaponLink6_3  = "LargeCannon_massDriver";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallEmitter_ION";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallEmitter_ION";
      
   externalLink9 = "HiveLauncher_Zapper";
   externalLink10 = "HiveLauncher_Zapper";
   externalLink11 = "HiveLauncher_Zapper";
           
   externalLink12 = "PointDefenseBeamEmitter_H";
   externalLink13 = "PointDefenseBeamEmitter_H";
   externalLink14 = "ScannerEmitter_H";
};
datablock ShipDesignDatablock(SunspotShip_Improved_A : SunspotShip_Improved)
{     
   turretLink6  = "HugeTriTurret";
      turretWeaponLink6_1  = "LargeCannon_rapid";
      turretWeaponLink6_2  = "LargeCannon_rapid";
      turretWeaponLink6_3  = "LargeCannon_rapid";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallEmitter_ION";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallEmitter_ION";
      
   externalLink9 = "HiveLauncher_Zapper";
   externalLink10 = "HiveLauncher_Zapper";
   externalLink11 = "HiveLauncher_Bomber_Cloaked";
           
   externalLink12 = "ScannerEmitter_H";
   externalLink13 = "PointDefenseBeamEmitter_H";
   externalLink14 = "PointDefenseBeamEmitter_H";
   parentDesign = SunspotShip_Improved;
};
datablock ShipDesignDatablock(SunspotShip_Improved_B : SunspotShip_Improved)
{     
   turretLink6  = "HugeTriTurret";
      turretWeaponLink6_1  = "LargeCannon_pulse";
      turretWeaponLink6_2  = "ShuttleCannon_L";
      turretWeaponLink6_3  = "LargeCannon_pulse";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallCannon_rapid";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallCannon_rapid";
      
   externalLink9 = "HiveLauncher_Zapper";
   externalLink10 = "HiveLauncher_Zapper";
   externalLink11 = "HiveLauncher_Zapper";
           
   externalLink12 = "CrewBooster_H";
   externalLink13 = "PointDefenseBeamEmitter_H";
   externalLink14 = "PointDefenseBeamEmitter_H";
   parentDesign = SunspotShip_Improved;
};



datablock ShipDesignDatablock(SunspotShip_Advanced : SunspotShip_Basic)
{     
   designDescriptionBits = $SST_DESIGN_ADVANCED;  
   friendlyName = "Advanced Sun Spot";   
   
   shipEngine            = H_InertialEngine;     
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
   
   turretLink6  = "HugeTriTurret";
      turretWeaponLink6_1  = "LargeEmitter";
      turretWeaponLink6_2  = "LargeEmitter_ION";
      turretWeaponLink6_3  = "LargeEmitter";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallCannon_pulse_civ";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallCannon_pulse_civ";
      
   externalLink9  = "HiveLauncher_Bomber_Cloaked";
   externalLink10 = "HiveLauncher_Bomber_Cloaked";
   externalLink11 = "HiveLauncher_Bomber_Cloaked";
           
   externalLink12 = "PointDefenseBeamEmitter_H";
   externalLink13 = "PointDefenseBeamEmitter_H";
   externalLink14 = "ScannerEmitter_H";
};
datablock ShipDesignDatablock(SunspotShip_Advanced_A : SunspotShip_Advanced)
{     
   turretLink6  = "HugeTriTurret";
      turretWeaponLink6_1  = "LargeEmitter_ION";
      turretWeaponLink6_2  = "ShuttleCannon_L";
      turretWeaponLink6_3  = "LargeEmitter_ION";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallCannon_rapid";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallCannon_rapid";
      
   externalLink9 = "HiveLauncher_Zapper_Cloaked";
   externalLink10 = "HiveLauncher_Zapper_Cloaked";
   externalLink11 = "HiveLauncher_Zapper_Cloaked";
           
   externalLink12 = "CrewBooster_H";
   externalLink13 = "PointDefenseBeamEmitter_H";
   externalLink14 = "PointDefenseBeamEmitter_H";
   parentDesign = SunspotShip_Advanced;
};
datablock ShipDesignDatablock(SunspotShip_Advanced_B : SunspotShip_Advanced)
{     
   turretLink6  = "HugeTriTurret";
      turretWeaponLink6_1  = "LargeCannon_massDriver";
      turretWeaponLink6_2  = "LargeCannon_massDriver";
      turretWeaponLink6_3  = "LargeCannon_massDriver";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallEmitter_ION";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallEmitter_ION";
      
   externalLink9 = "HiveLauncher_Zapper_Cloaked";
   externalLink10 = "HiveLauncher_Fighter_Cloaked";
   externalLink11 = "HiveLauncher_Bomber_Cloaked";
           
   externalLink12 = "ScannerEmitter_H";
   externalLink13 = "PointDefenseBeamEmitter_H";
   externalLink14 = "PointDefenseBeamEmitter_H";
   parentDesign = SunspotShip_Advanced;
};
datablock ShipDesignDatablock(SunspotShip_Advanced_C : SunspotShip_Advanced)
{     
   turretLink6  = "HugeTriTurret";
      turretWeaponLink6_1  = "LargeEmitter_Heavy";
      turretWeaponLink6_2  = "LargeEmitter_Heavy";
      turretWeaponLink6_3  = "LargeEmitter_Heavy";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallEmitter_Civ";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallEmitter_Civ";
      
   externalLink9  = "HiveLauncher_Zapper";
   externalLink10 = "HiveLauncher_Zapper";
   externalLink11 = "HiveLauncher_Zapper";
           
   externalLink12 = "ReactorBooster_H";
   externalLink13 = "ShieldBooster_H";
   externalLink14 = "ShieldBooster_H";
   parentDesign = SunspotShip_Advanced;
};
datablock ShipDesignDatablock(SunspotShip_Advanced_D : SunspotShip_Advanced)
{     
   turretLink6  = "HugeTriTurret";
      turretWeaponLink6_1  = "LargeCannon_pulse";
      turretWeaponLink6_2  = "LargeCannon_pulse";
      turretWeaponLink6_3  = "LargeCannon_pulse";
      
   turretLink7  = "SmallTurret";
      turretWeaponLink7_1  = "SmallEmitter_Ion";
      
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallEmitter_Ion";
      
   externalLink9  = "HiveLauncher_Bomber";
   externalLink10 = "HiveLauncher_Bomber";
   externalLink11 = "HiveLauncher_Bomber";
           
   externalLink12 = "ShieldBooster_H";
   externalLink13 = "ShieldBooster_H";
   externalLink14 = "ShieldBooster_H";
   parentDesign = SunspotShip_Advanced;
};


////////////////////////////////////////////////////////////////////////////////
// CIV SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE FREIGHTER
/////////////////////////////////////////////

datablock ShipDesignDatablock(FreighterShip : DefaultShip)
{
   shipHull    = HullFreighter;

   shipEngine            = H_CivEngine;   
   shipReactor           = H_CivReactor;
   shipShield            = H_CivShield;
     
   shipArmor_Front       = "CivArmor_H";   
   shipArmor_Starboard   = "CivArmor_H";
   shipArmor_Aft         = "CivArmor_H";
   shipArmor_Port        = "CivArmor_H";
   
   externalLink5  = "HugeCannon_Pulse_Civ";
   externalLink6  = "HugeCannon_Pulse_Civ";
   
   externalLink8  = "HiveLauncher_Fighter";

   externalLink9  = "TractorEmitter_Huge";
   externalLink10  = "TractorEmitter_Huge";
   
   externalLink11  = "MediumLauncher_Civ";
   externalLink12  = "MediumLauncher_Civ";
   externalLink13  = "MediumLauncher_Civ";
   externalLink14  = "MediumLauncher_Civ";
   externalLink15  = "MediumLauncher_Civ";
   externalLink16  = "MediumLauncher_Civ";
   externalLink17  = "MediumLauncher_Civ";
   externalLink18  = "MediumLauncher_Civ";
   
   turretLink7  = "HugeTurret";
      turretWeaponLink7_1  = "HugeCannon_Pulse_Civ";
};


datablock ShipDesignDatablock(FreighterShip_Basic : FreighterShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Freighter";   
   
   shipEngine            = H_BasicEngine;     
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink5  = "HugeEmitter_Civ";
   externalLink6  = "HugeEmitter_Civ";
   
   externalLink8  = "HiveLauncher_Fighter";

   externalLink9  = "PointDefenseBeamEmitter_H";
   externalLink10  = "PointDefenseBeamEmitter_H";
   
   externalLink11  = "MediumLauncher";
   externalLink12  = "MediumLauncher";
   externalLink13  = "MediumLauncher";
   externalLink14  = "MediumLauncher";
   externalLink15  = "MediumLauncher";
   externalLink16  = "MediumLauncher";
   externalLink17  = "MediumLauncher";
   externalLink18  = "MediumLauncher";
   
   turretLink7  = "HugeTurret";
      turretWeaponLink7_1  = "HugeCannon_Pulse"; 
};
datablock ShipDesignDatablock(FreighterShip_Basic_A : FreighterShip_Basic)
{    
   externalLink5  = "HugeCannon_rapid";
   externalLink6  = "HugeCannon_rapid";
   
   externalLink8  = "HiveLauncher_Zapper";

   externalLink9  = "PointDefenseBeamEmitter_H";
   externalLink10  = "PointDefenseBeamEmitter_H";
   
   externalLink11  = "MediumLauncher_Civ";
   externalLink12  = "MediumLauncher_Civ";
   externalLink13  = "MediumLauncher_Civ";
   externalLink14  = "MediumLauncher_Civ";
   externalLink15  = "MediumLauncher_Civ";
   externalLink16  = "MediumLauncher_Civ";
   externalLink17  = "MediumLauncher_Civ";
   externalLink18  = "MediumLauncher_Civ";
   
   turretLink7  = "HugeTurret";
      turretWeaponLink7_1  = "HugeEmitter_ION"; 
   
   parentDesign = FreighterShip_Basic;
};
datablock ShipDesignDatablock(FreighterShip_Basic_B : FreighterShip_Basic)
{    
   externalLink5  = "HugeCannon_pulse";
   externalLink6  = "HugeCannon_pulse";
   
   externalLink8  = "HiveLauncher_Bomber";

   externalLink9  = "PointDefenseBeamEmitter_H";
   externalLink10  = "PointDefenseBeamEmitter_H";
   
   externalLink11  = "MediumLauncher_Civ";
   externalLink12  = "MediumLauncher_Civ";
   externalLink13  = "MediumLauncher_Civ";
   externalLink14  = "MediumLauncher_Civ";
   externalLink15  = "MediumLauncher_Civ";
   externalLink16  = "MediumLauncher_Civ";
   externalLink17  = "MediumLauncher_Civ";
   externalLink18  = "MediumLauncher_Civ";
   
   turretLink7  = "HugeTurret";
      turretWeaponLink7_1  = "HugeEmitter_ION"; 
   
   parentDesign = FreighterShip_Basic;
};






datablock ShipDesignDatablock(FreighterShip_Improved : FreighterShip)
{  
   //pulse //pd //scan
    
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Freighter";   
   
   shipEngine            = H_ThrusterEngine;     
   shipReactor           = H_HighCapacityReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";  
   
   externalLink5  = "HugeCannon_rapid";
   externalLink6  = "HugeCannon_rapid";
   
   externalLink8  = "HiveLauncher_Zapper";

   externalLink9  = "PointDefenseBeamEmitter_H";
   externalLink10  = "ScannerEmitter_H";
   
   externalLink11  = "MediumLauncher";
   externalLink12  = "MediumLauncher";
   externalLink13  = "MediumLauncher";
   externalLink14  = "MediumLauncher";
   externalLink15  = "MediumLauncher";
   externalLink16  = "MediumLauncher";
   externalLink17  = "MediumLauncher";
   externalLink18  = "MediumLauncher";
   
   turretLink7  = "HugeTriTurret";
      turretWeaponLink7_1  = "LargeEmitter_Civ";
      turretWeaponLink7_2  = "LargeEmitter_Civ";
      turretWeaponLink7_3  = "LargeEmitter_Civ";
};
datablock ShipDesignDatablock(FreighterShip_Improved_A : FreighterShip_Improved)
{    
   externalLink5  = "HugeEmitter";
   externalLink6  = "HugeEmitter";
   
   externalLink8  = "HiveLauncher_Zapper";

   externalLink9   = "CrewBooster_H";
   externalLink10  = "CrewBooster_H";
   
   externalLink11  = "MediumRocketLauncher";
   externalLink12  = "MediumRocketLauncher";
   externalLink13  = "MediumRocketLauncher";
   externalLink14  = "MediumRocketLauncher";
   externalLink15  = "MediumLauncher_Civ";
   externalLink16  = "MediumLauncher_Civ";
   externalLink17  = "MediumLauncher_Civ";
   externalLink18  = "MediumLauncher_Civ";
   
   turretLink7  = "HugeTriTurret";
      turretWeaponLink7_1  = "LargeCannon_pulse";
      turretWeaponLink7_2  = "ShuttleCannon_L";
      turretWeaponLink7_3  = "LargeCannon_pulse";
   
   parentDesign = FreighterShip_Improved;
};
datablock ShipDesignDatablock(FreighterShip_Improved_B : FreighterShip_Improved)
{    
   externalLink5  = "HugeCannon_massDriver";
   externalLink6  = "HugeCannon_massDriver";
   
   externalLink8  = "HiveLauncher_Zapper";

   externalLink9   = "PointDefenseBeamEmitter_H";
   externalLink10  = "ScannerEmitter_H";
   
   externalLink11  = "MediumRocketLauncher";
   externalLink12  = "MediumRocketLauncher";
   externalLink13  = "MediumLauncher";
   externalLink14  = "MediumLauncher";
   externalLink15  = "MediumLauncher_GRAV";
   externalLink16  = "MediumLauncher_GRAV";
   externalLink17  = "MediumTorpedoLauncher";
   externalLink18  = "MediumTorpedoLauncher";
   
   turretLink7  = "HugeTriTurret";
      turretWeaponLink7_1  = "LargeEmitter";
      turretWeaponLink7_2  = "LargeEmitter_ION";
      turretWeaponLink7_3  = "LargeEmitter";
   
   parentDesign = FreighterShip_Improved;
};


datablock ShipDesignDatablock(FreighterShip_Advanced : FreighterShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Freighter";   
   
   shipEngine            = H_InertialEngine;     
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
   
   externalLink5  = "HugeCannon_rapid";
   externalLink6  = "HugeCannon_rapid";
   
   externalLink8  = "HiveLauncher_Zapper";

   externalLink9   = "ShieldBooster_H";
   externalLink10  = "ShieldBooster_H";
   
   externalLink11  = "MediumRocketLauncher";
   externalLink12  = "MediumRocketLauncher";
   externalLink13  = "MediumRocketLauncher";
   externalLink14  = "MediumRocketLauncher";
   externalLink15  = "MediumRocketLauncher";
   externalLink16  = "MediumRocketLauncher";
   externalLink17  = "MediumRocketLauncher";
   externalLink18  = "MediumRocketLauncher";
   
   turretLink7  = "HugeTriTurret";
      turretWeaponLink7_1  = "LargeEmitter_ION";
      turretWeaponLink7_2  = "LargeEmitter_ION";
      turretWeaponLink7_3  = "LargeEmitter_ION";
};
datablock ShipDesignDatablock(FreighterShip_Advanced_A : FreighterShip_Advanced)
{    
   externalLink5  = "HugeCannon_cluster";
   externalLink6  = "HugeCannon_cluster";
   
   externalLink8  = "HiveLauncher_Zapper";

   externalLink9   = "ShieldBooster_H";
   externalLink10  = "ShieldBooster_H";
   
   externalLink11  = "MediumRocketLauncher";
   externalLink12  = "MediumRocketLauncher";
   externalLink13  = "MediumLauncher";
   externalLink14  = "MediumLauncher";
   externalLink15  = "MediumLauncher_GRAV";
   externalLink16  = "MediumLauncher_GRAV";
   externalLink17  = "MediumTorpedoLauncher";
   externalLink18  = "MediumTorpedoLauncher";
   
   turretLink7  = "HugeTriTurret";
      turretWeaponLink7_1  = "LargeCannon_massDriver";
      turretWeaponLink7_2  = "LargeCannon_massDriver";
      turretWeaponLink7_3  = "LargeCannon_massDriver";
   
   parentDesign = FreighterShip_Advanced;
};
datablock ShipDesignDatablock(FreighterShip_Advanced_B : FreighterShip_Advanced)
{    
   externalLink5  = "HugeEmitter_Heavy";
   externalLink6  = "HugeEmitter_Heavy";
   
   externalLink8  = "HiveLauncher_Bomber";

   externalLink9   = "ShieldBooster_H";
   externalLink10  = "ShieldBooster_H";
   
   externalLink11  = "MediumRocketLauncher";
   externalLink12  = "MediumRocketLauncher";
   externalLink13  = "MediumLauncher";
   externalLink14  = "MediumLauncher";
   externalLink15  = "MediumRocketLauncher";
   externalLink16  = "MediumRocketLauncher";
   externalLink17  = "MediumLauncher";
   externalLink18  = "MediumLauncher";
   
   turretLink7  = "HugeTriTurret";
      turretWeaponLink7_1  = "LargeEmitter_LEECH";
      turretWeaponLink7_2  = "LargeEmitter_LEECH";
      turretWeaponLink7_3  = "LargeEmitter_LEECH";
   
   parentDesign = FreighterShip_Advanced;
};
datablock ShipDesignDatablock(FreighterShip_Advanced_C : FreighterShip_Advanced)
{    
   externalLink5  = "HugeCannon_cluster";
   externalLink6  = "HugeCannon_cluster";
   
   externalLink8  = "HiveLauncher_Zapper";

   externalLink9   = "CrewBooster_H";
   externalLink10  = "CrewBooster_H";
   
   externalLink11  = "MediumRocketLauncher";
   externalLink12  = "MediumRocketLauncher";
   externalLink13  = "MediumRocketLauncher";
   externalLink14  = "MediumRocketLauncher";
   externalLink15  = "MediumLauncher_Civ";
   externalLink16  = "MediumLauncher_Civ";
   externalLink17  = "MediumLauncher_Civ";
   externalLink18  = "MediumLauncher_Civ";
   
   turretLink7  = "HugeTriTurret";
      turretWeaponLink7_1  = "LargeCannon_pulse";
      turretWeaponLink7_2  = "ShuttleCannon_L";
      turretWeaponLink7_3  = "LargeCannon_pulse";
   
   parentDesign = FreighterShip_Advanced;
};
datablock ShipDesignDatablock(FreighterShip_Advanced_D : FreighterShip_Advanced)
{    
   externalLink5  = "HugeCannon_rapid";
   externalLink6  = "HugeCannon_rapid";
   
   externalLink8  = "HiveLauncher_Bomber";

   externalLink9  = "PointDefenseBeamEmitter_H";
   externalLink10  = "ScannerEmitter_H";
   
   externalLink11  = "MediumRocketLauncher";
   externalLink12  = "MediumRocketLauncher";
   externalLink13  = "MediumRocketLauncher";
   externalLink14  = "MediumRocketLauncher";
   externalLink15  = "MediumRocketLauncher";
   externalLink16  = "MediumRocketLauncher";
   externalLink17  = "MediumRocketLauncher";
   externalLink18  = "MediumRocketLauncher";
   
   turretLink7  = "HugeTriTurret";
      turretWeaponLink7_1  = "LargeCannon_rapid";
      turretWeaponLink7_2  = "ShuttleCannon_L";
      turretWeaponLink7_3  = "LargeCannon_rapid";
   
   parentDesign = FreighterShip_Advanced;
};

/////////////////////////////////////////////
// THE CARRIER
/////////////////////////////////////////////

datablock ShipDesignDatablock(CarrierShip: DefaultShip)
{
   shipHull    = HullCarrier;

   shipEngine            = H_CivEngine;   
   shipReactor           = H_CivReactor;
   shipShield            = H_CivShield;
     
   shipArmor_Front       = "CivArmor_H";   
   shipArmor_Starboard   = "CivArmor_H";
   shipArmor_Aft         = "CivArmor_H";
   shipArmor_Port        = "CivArmor_H";
   
   //LEFT
   externalLink10  = "TractorEmitter_Large";
   externalLink11  = "TractorEmitter_Large";
   externalLink12  = "MiningTractorEmitter";
   
   //RIGHT
   externalLink13  = "TractorEmitter_Large";
   externalLink14  = "TractorEmitter_Large";
   externalLink15  = "MiningTractorEmitter";
   
   //CENTER
   externalLink16  = "SurplusScannerEmitter_H";
   externalLink17  = "SurplusScannerEmitter_H";
   
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallCannon_Pulse_Civ";
      
   turretLink9  = "SmallTurret";
      turretWeaponLink9_1  = "SmallCannon_Pulse_Civ";
      
   //missiles
   externalLink18  = "SmallLauncher_Civ";
   externalLink19  = "SmallLauncher_Civ";
   externalLink20  = "SmallLauncher_Civ";
   externalLink21  = "SmallLauncher_Civ";
};

datablock ShipDesignDatablock(CarrierShip_basic: CarrierShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Carrier";   
   
   shipEngine            = H_BasicEngine;     
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
   //LEFT
   externalLink10  = "TractorEmitter_Large";
   externalLink11  = "PointDefenseBeamEmitter_L";
   externalLink12  = "PointDefenseBeamEmitter_S";
   
   //RIGHT
   externalLink13  = "TractorEmitter_Large";
   externalLink14  = "PointDefenseBeamEmitter_L";
   externalLink15  = "PointDefenseBeamEmitter_S";
   
   //CENTER
   externalLink16  = "PointDefenseBeamEmitter_H";
   externalLink17  = "ScannerEmitter_H";
   
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallCannon_Pulse";
      
   turretLink9  = "SmallTurret";
      turretWeaponLink9_1  = "SmallCannon_Pulse";
      
   //missiles
   externalLink18  = "SmallLauncher";
   externalLink19  = "SmallLauncher";
   externalLink20  = "SmallLauncher";
   externalLink21  = "SmallLauncher";
};

datablock ShipDesignDatablock(CarrierShip_improved: CarrierShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Carrier";   
   
   shipEngine            = H_ThrusterEngine;     
   shipReactor           = H_HighCapacityReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";  
   
   //LEFT
   externalLink10  = "TractorEmitter_Large";
   externalLink11  = "PointDefenseBeamEmitter_L";
   externalLink12  = "PointDefenseBeamEmitter_S";
   
   //RIGHT
   externalLink13  = "TractorEmitter_Large";
   externalLink14  = "PointDefenseBeamEmitter_L";
   externalLink15  = "PointDefenseBeamEmitter_S";
   
   //CENTER
   externalLink16  = "PointDefenseBeamEmitter_H";
   externalLink17  = "ScannerEmitter_H";
   
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallCannon_Cluster";
      
   turretLink9  = "SmallTurret";
      turretWeaponLink9_1  = "SmallCannon_Cluster";
      
   //missiles
   externalLink18  = "SmallTorpedoLauncher";
   externalLink19  = "SmallTorpedoLauncher";
   externalLink20  = "SmallTorpedoLauncher";
   externalLink21  = "SmallTorpedoLauncher";
};

datablock ShipDesignDatablock(CarrierShip_advanced: CarrierShip)
{
   //cloaked
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   friendlyName = "Advanced Carrier";   
   
   shipEngine            = H_InertialEngine;     
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_ExperimentalCloak;
     
   shipArmor_Front       = "AdvancedArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
   
   //LEFT
   externalLink10  = "TractorEmitter_Large";
   externalLink11  = "PointDefenseBeamEmitter_L";
   externalLink12  = "PointDefenseBeamEmitter_S";
   
   //RIGHT
   externalLink13  = "TractorEmitter_Large";
   externalLink14  = "PointDefenseBeamEmitter_L";
   externalLink15  = "PointDefenseBeamEmitter_S";
   
   //CENTER
   externalLink16  = "PointDefenseBeamEmitter_H";
   externalLink17  = "ScannerEmitter_H";
   
   turretLink8  = "SmallTurret";
      turretWeaponLink8_1  = "SmallCannon_Rapid";
      
   turretLink9  = "SmallTurret";
      turretWeaponLink9_1  = "SmallCannon_Rapid";
      
   //missiles
   externalLink18  = "SmallRocketLauncher";
   externalLink19  = "SmallRocketLauncher";
   externalLink20  = "SmallRocketLauncher";
   externalLink21  = "SmallRocketLauncher";
};

////////////////////////////////////////////////////////////////////////////////
// ZOMBIE SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE BIG FOOT
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_BigFootShip : DefaultZombieShip)
{
   shipHull    = HullZombieBigFoot;  //This determines what we can put of the ship. 

   shipEngine            = H_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
      
   externalLink2  = "MediumCannon_Pulse";
   externalLink3  = "HugeCannon_Pulse";
   externalLink4  = "HugeCannon_Pulse";
   externalLink5  = "MediumCannon_Pulse";
   externalLink6  = "MediumLauncher_Zombie";
};

/////////////////////////////////////////////
// THE TUMOR
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_TumorShip : DefaultZombieShip)
{
   shipHull    = HullZombieTumor;  //This determines what we can put of the ship. 
   
   shipEngine            = H_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
   
   
   turretLink7 = "HugeTriTurret_zombie";
   turretWeaponLink7_1 = "MediumLauncher_Zombie";
   turretWeaponLink7_2 = "MediumLauncher_Zombie";  
   turretWeaponLink7_3 = "MediumLauncher_Zombie"; 

   turretLink8 = "HugeTriTurret_zombie";
   turretWeaponLink8_1 = "LargeCannon_zombie";
   turretWeaponLink8_2 = "LargeCannon_zombie";  
   turretWeaponLink8_3 = "LargeCannon_zombie"; 
      
   turretLink9 = "HugeTriTurret_zombie";
   turretWeaponLink9_1 = "LargeCannon_zombie";
   turretWeaponLink9_2 = "LargeCannon_zombie";  
   turretWeaponLink9_3 = "LargeCannon_zombie"; 

   externalLink10  = "MediumLauncher_Zombie";
};

////////////////////////////////////////////////////////////////////////////////
// BOUNTY SHIPS
////////////////////////////////////////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Huge_01_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_01;  //This determines what we can put of the ship. 

   shipEngine            = H_CivEngine;   
   shipReactor           = H_CivReactor;
   shipShield            = H_CivShield;
     
   shipArmor_Front       = "CivArmor_H";   
   shipArmor_Starboard   = "CivArmor_H";
   shipArmor_Aft         = "CivArmor_H";
   shipArmor_Port        = "CivArmor_H";
   
   turretLink7 = "LargeTurret";
   turretWeaponLink7_1 = "LargeEmitter_Civ";  
      
   turretLink8 = "LargeTurret";
   turretWeaponLink8_1 = "LargeEmitter_Civ";    
   
   turretLink9 = "HugeTurret";
   turretWeaponLink9_1 = "HugeEmitter_Civ";
   
   turretLink10  = "MediumTurret";
   turretWeaponLink10_1  = "MediumEmitter_Civ";
      
   turretLink11 = "MediumTurret";
   turretWeaponLink11_1 = "MediumEmitter_Civ";  
   
   externalLink6 = "MassBombLauncher_HEAT_Large";
            
   externalLink12 = "TractorEmitter_huge";
   externalLink13 = "TractorEmitter_huge";
   
   externalLink14 = "TractorEmitter_large";
   externalLink15 = "TractorEmitter_large";
   externalLink16 = "TractorEmitter_large";
   externalLink17 = "TractorEmitter_large";
};

/////////////////////////////////
// Basic ////////////////////////
/////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Huge_01_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_01;  //This determines what we can put of the ship. 

   shipEngine            = H_BasicEngine;   
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
   turretLink7 = "LargeTurret";
   turretWeaponLink7_1 = "LargeEmitter";  
      
   turretLink8 = "LargeTurret";
   turretWeaponLink8_1 = "LargeEmitter";    
   
   turretLink9 = "HugeTurret";
   turretWeaponLink9_1 = "HugeEmitter";
   
   turretLink10  = "MediumTurret";
   turretWeaponLink10_1  = "MediumCannon_rapid";
      
   turretLink11 = "MediumTurret";
   turretWeaponLink11_1 = "MediumCannon_rapid";  
   
   externalLink6 = "MassBombLauncher_EXP_Large";
            
   externalLink12 = "PointDefenseBeamEmitter_H";
   externalLink13 = "BeamBooster_H";
   
   externalLink14 = "ShieldBooster_L";
   externalLink15 = "ShieldBooster_L";
   externalLink16 = "PointDefenseBeamEmitter_L";
   externalLink17 = "PointDefenseBeamEmitter_L";
};


datablock ShipDesignDatablock(BountyShip_Huge_01_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_01;  //This determines what we can put of the ship. 

   shipEngine            = H_BasicEngine;   
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
   turretLink7 = "LargeTurret";
   turretWeaponLink7_1 = "LargeCannon_pulse";  
      
   turretLink8 = "LargeTurret";
   turretWeaponLink8_1 = "LargeCannon_pulse";    
   
   turretLink9 = "HugeTurret";
   turretWeaponLink9_1 = "HugeCannon_pulse";
   
   turretLink10  = "MediumTurret";
   turretWeaponLink10_1  = "MediumCannon_pulse";
      
   turretLink11 = "MediumTurret";
   turretWeaponLink11_1 = "MediumCannon_pulse";  
   
   externalLink6 = "DeployableTurretLauncher_Ion_L";
            
   externalLink12 = "PointDefenseBeamEmitter_H";
   externalLink13 = "CannonBooster_H";
   
   externalLink14 = "ShieldBooster_L";
   externalLink15 = "ShieldBooster_L";
   externalLink16 = "PointDefenseBeamEmitter_L";
   externalLink17 = "PointDefenseBeamEmitter_L";
};

/////////////////////////////////
// Improved ////////////////////////
/////////////////////////////////


datablock ShipDesignDatablock(BountyShip_Huge_01_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_01;  //This determines what we can put of the ship. 

   shipEngine            = H_ThrusterEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   turretLink7 = "LargeTurret";
   turretWeaponLink7_1 = "LargeEmitter_ION";  
      
   turretLink8 = "LargeTurret";
   turretWeaponLink8_1 = "LargeEmitter_ION";    
   
   turretLink9 = "HugeDoubleTurret";
   turretWeaponLink9_1 = "LargeEmitter_Heavy";
   turretWeaponLink9_2 = "LargeEmitter_Heavy";
   
   turretLink10  = "MediumTurret";
   turretWeaponLink10_1  = "MediumEmitter_Leech";
      
   turretLink11 = "MediumTurret";
   turretWeaponLink11_1 = "MediumEmitter_Leech";  
   
   externalLink6 = "MassBombLauncher_EXP_Large";
            
   externalLink12 = "PointDefenseBeamEmitter_H";
   externalLink13 = "BeamBooster_H";
   
   externalLink14 = "ShieldBooster_L";
   externalLink15 = "ShieldBooster_L";
   externalLink16 = "PointDefenseBeamEmitter_L";
   externalLink17 = "PointDefenseBeamEmitter_L";
};

datablock ShipDesignDatablock(BountyShip_Huge_01_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_01;  //This determines what we can put of the ship. 

   shipEngine            = H_ThrusterEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   turretLink7 = "LargeTurret";
   turretWeaponLink7_1 = "LargeCannon_rapid";  
      
   turretLink8 = "LargeTurret";
   turretWeaponLink8_1 = "LargeCannon_rapid";    
   
   turretLink9 = "HugeDoubleTurret";
   turretWeaponLink9_1 = "LargeCannon_rapid";
   turretWeaponLink9_2 = "LargeCannon_rapid";
   
   turretLink10  = "MediumDoubleTurret";
   turretWeaponLink10_1  = "SmallCannon_massDriver";
   turretWeaponLink10_2  = "SmallCannon_massDriver";
      
   turretLink11 = "MediumDoubleTurret";
   turretWeaponLink11_1 = "SmallCannon_massDriver";  
   turretWeaponLink11_2 = "SmallCannon_massDriver";
   
   externalLink6 = "DeployableTurretLauncher_Ion_L";
            
   externalLink12 = "PointDefenseBeamEmitter_H";
   externalLink13 = "CannonBooster_H";
   
   externalLink14 = "ShieldBooster_L";
   externalLink15 = "ShieldBooster_L";
   externalLink16 = "PointDefenseBeamEmitter_L";
   externalLink17 = "PointDefenseBeamEmitter_L";
};


/////////////////////////////////
// Advanced ////////////////////////
/////////////////////////////////


datablock ShipDesignDatablock(BountyShip_Huge_01_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_01;  //This determines what we can put of the ship. 

   shipEngine            = H_InertialEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
   
   turretLink7 = "LargeDoubleTurret";
   turretWeaponLink7_1 = "MediumCannon_rapid";  
   turretWeaponLink7_2 = "MediumCannon_rapid";
      
   turretLink8 = "LargeDoubleTurret";
   turretWeaponLink8_1 = "MediumCannon_rapid";    
   turretWeaponLink8_2 = "MediumCannon_rapid";
   
   turretLink9 = "HugeTriTurret";
   turretWeaponLink9_1 = "LargeCannon_massDriver";
   turretWeaponLink9_2 = "LargeCannon_massDriver";
   turretWeaponLink9_3 = "LargeCannon_massDriver";
   
   turretLink10  = "MediumTurret";
   turretWeaponLink10_1  = "MediumEmitter_ION";
  
      
   turretLink11 = "MediumTurret";
   turretWeaponLink11_1 = "MediumEmitter_ION";  
   
   
   externalLink6 = "DeployableTurretLauncher_TorpRack_L";
            
   externalLink12 = "PointDefenseBeamEmitter_H";
   externalLink13 = "CannonBooster_H";
   
   externalLink14 = "ShieldBooster_L";
   externalLink15 = "ShieldBooster_L";
   externalLink16 = "ShieldBooster_L";
   externalLink17 = "ShieldBooster_L";
};


datablock ShipDesignDatablock(BountyShip_Huge_01_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_01;  //This determines what we can put of the ship. 

   shipEngine            = H_InertialEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
   
   turretLink7 = "LargeDoubleTurret";
   turretWeaponLink7_1 = "MediumCannon_massDriver";  
   turretWeaponLink7_2 = "MediumCannon_massDriver";
      
   turretLink8 = "LargeDoubleTurret";
   turretWeaponLink8_1 = "MediumCannon_massDriver";    
   turretWeaponLink8_2 = "MediumCannon_massDriver";
   
   turretLink9 = "HugeTriTurret";
   turretWeaponLink9_1 = "LargeEmitter_ION";
   turretWeaponLink9_2 = "LargeEmitter_ION";
   turretWeaponLink9_3 = "LargeEmitter_ION";
   
   turretLink10  = "MediumTurret";
   turretWeaponLink10_1  = "MediumEmitter_Leech";
  
      
   turretLink11 = "MediumTurret";
   turretWeaponLink11_1 = "MediumEmitter_Leech";  
   
   
   externalLink6 = "DeployableTurretLauncher_BattleStation_L";
            
   externalLink12 = "PointDefenseBeamEmitter_H";
   externalLink13 = "BeamBooster_H";
   
   externalLink14 = "ShieldBooster_L";
   externalLink15 = "ShieldBooster_L";
   externalLink16 = "ShieldBooster_L";
   externalLink17 = "ShieldBooster_L";
};


//////////////////////////////////////////////////////////////////////////////
// bounty huge 2
//////////////////////////////////////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Huge_02_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_02;  //This determines what we can put of the ship. 

   shipEngine            = H_CivEngine;   
   shipReactor           = H_CivReactor;
   shipShield            = H_CivShield;
     
   shipArmor_Front       = "CivArmor_H";   
   shipArmor_Starboard   = "CivArmor_H";
   shipArmor_Aft         = "CivArmor_H";
   shipArmor_Port        = "CivArmor_H";
   
   externalLink5 = "LargeEmitter_Civ";
   externalLink6 = "LargeEmitter_Civ";
   externalLink7 = "LargeEmitter_Civ";
   externalLink8 = "LargeEmitter_Civ";
   externalLink9 = "LargeEmitter_Civ";
                  
   externalLink10 = "LargeEmitter_Civ";
   externalLink11 = "LargeEmitter_Civ";
   externalLink12 = "LargeEmitter_Civ";
   externalLink13 = "LargeEmitter_Civ";
   externalLink14 = "LargeEmitter_Civ";
   
   externalLink15 = "TractorEmitter_huge";
   externalLink16 = "TractorEmitter_huge";
   externalLink17 = "TractorEmitter_huge";
   externalLink18 = "TractorEmitter_huge";
   externalLink19 = "TractorEmitter_huge";
};

///////////////////////////////////////
// Basic //////////////////////////////
///////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Huge_02_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_02;  //This determines what we can put of the ship. 

   shipEngine            = H_BasicEngine;   
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
   externalLink5 = "BeamBooster_L";
   externalLink6 = "LargeEmitter";
   externalLink7 = "LargeEmitter";
   externalLink8 = "LargeEmitter";
   externalLink9 = "LargeEmitter";
                  
   externalLink10 = "LargeEmitter";
   externalLink11 = "LargeEmitter";
   externalLink12 = "LargeEmitter";
   externalLink13 = "LargeEmitter";
   externalLink14 = "BeamBooster_L";
   
   externalLink15 = "PointDefenseBeamEmitter_H";
   externalLink16 = "PointDefenseBeamEmitter_H";
   externalLink17 = "ShieldBooster_H";
   externalLink18 = "ReactorBooster_H";
   externalLink19 = "PointDefenseBeamEmitter_H";
};


datablock ShipDesignDatablock(BountyShip_Huge_02_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_02;  //This determines what we can put of the ship. 

   shipEngine            = H_BasicEngine;   
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
   externalLink5 = "BeamBooster_L";
   externalLink6 = "LargeEmitter";
   externalLink7 = "LargeEmitter_ION";
   externalLink8 = "LargeEmitter_LEECH";
   externalLink9 = "LargeEmitter";
                  
   externalLink10 = "LargeEmitter";
   externalLink11 = "LargeEmitter_LEECH";
   externalLink12 = "LargeEmitter_ION";
   externalLink13 = "LargeEmitter";
   externalLink14 = "BeamBooster_L";
   
   externalLink15 = "PointDefenseBeamEmitter_H";
   externalLink16 = "PointDefenseBeamEmitter_H";
   externalLink17 = "ShieldBooster_H";
   externalLink18 = "ReactorBooster_H";
   externalLink19 = "PointDefenseBeamEmitter_H";
};


///////////////////////////////////////
// IMPROVED ///////////////////////////
///////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Huge_02_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_02;  //This determines what we can put of the ship. 

   shipEngine            = H_BasicEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink5 = "BeamBooster_L";
   externalLink6 = "LargeEmitter";
   externalLink7 = "LargeEmitter_ION";
   externalLink8 = "LargeEmitter_LEECH";
   externalLink9 = "LargeEmitter";
                  
   externalLink10 = "LargeEmitter";
   externalLink11 = "LargeEmitter_LEECH";
   externalLink12 = "LargeEmitter_ION";
   externalLink13 = "LargeEmitter";
   externalLink14 = "BeamBooster_L";
   
   externalLink15 = "PointDefenseBeamEmitter_H";
   externalLink16 = "PointDefenseBeamEmitter_H";
   externalLink17 = "ShieldBooster_H";
   externalLink18 = "ShieldBooster_H";
   externalLink19 = "ReactorBooster_H";
};


datablock ShipDesignDatablock(BountyShip_Huge_02_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_02;  //This determines what we can put of the ship. 

   shipEngine            = H_BasicEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink5 = "BeamBooster_L";
   externalLink6 = "LargeEmitter_LEECH";
   externalLink7 = "LargeEmitter_Heavy";
   externalLink8 = "LargeEmitter_Heavy";
   externalLink9 = "LargeEmitter_Heavy";
                  
   externalLink10 = "LargeEmitter_Heavy";
   externalLink11 = "LargeEmitter_Heavy";
   externalLink12 = "LargeEmitter_Heavy";
   externalLink13 = "LargeEmitter_LEECH";
   externalLink14 = "BeamBooster_L";
   
   externalLink15 = "PointDefenseBeamEmitter_H";
   externalLink16 = "PointDefenseBeamEmitter_H";
   externalLink17 = "ShieldBooster_H";
   externalLink18 = "ShieldBooster_H";
   externalLink19 = "ReactorBooster_H";
};


///////////////////////////////////////
// ADVANCED ///////////////////////////
///////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Huge_02_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_02;  //This determines what we can put of the ship. 

   shipEngine            = H_InertialEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
   
   externalLink5 = "BeamBooster_L";
   externalLink6 = "LargeEmitter_Heavy";
   externalLink7 = "LargeEmitter_Heavy";
   externalLink8 = "LargeEmitter_Heavy";
   externalLink9 = "LargeEmitter_Heavy";
                  
   externalLink10 = "LargeEmitter_Heavy";
   externalLink11 = "LargeEmitter_Heavy";
   externalLink12 = "LargeEmitter_Heavy";
   externalLink13 = "LargeEmitter_Heavy";
   externalLink14 = "BeamBooster_L";
   
   externalLink15 = "ReactorBooster_H";
   externalLink16 = "PointDefenseBeamEmitter_H";
   externalLink17 = "ReactorBooster_H";
   externalLink18 = "PointDefenseBeamEmitter_H";
   externalLink19 = "ReactorBooster_H";
};


datablock ShipDesignDatablock(BountyShip_Huge_02_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_02;  //This determines what we can put of the ship. 

   shipEngine            = H_InertialEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
   
   externalLink5 = "ReactorBooster_L";
   externalLink6 = "LargeEmitter_Heavy";
   externalLink7 = "LargeEmitter_Heavy";
   externalLink8 = "LargeEmitter_Heavy";
   externalLink9 = "LargeEmitter_LEECH";
                  
   externalLink10 = "LargeEmitter_LEECH";
   externalLink11 = "LargeEmitter_Heavy";
   externalLink12 = "LargeEmitter_Heavy";
   externalLink13 = "LargeEmitter_Heavy";
   externalLink14 = "ReactorBooster_L";
   
   externalLink15 = "PointDefenseBeamEmitter_H";
   externalLink16 = "PointDefenseBeamEmitter_H";
   externalLink17 = "ShieldBooster_H";
   externalLink18 = "ShieldBooster_H";
   externalLink19 = "BeamBooster_H";
};


datablock ShipDesignDatablock(BountyShip_Huge_02_ADVANCED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Huge_02;  //This determines what we can put of the ship. 

   shipEngine            = H_InertialEngine;   
   shipReactor           = H_OverchargedReactor;
   shipShield            = H_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
   
   externalLink5 = "LargeEmitter_Heavy";
   externalLink6 = "LargeEmitter_Heavy";
   externalLink7 = "LargeEmitter_Heavy";
   externalLink8 = "LargeEmitter_Heavy";
   externalLink9 = "LargeEmitter_Heavy";
                  
   externalLink10 = "LargeEmitter_Heavy";
   externalLink11 = "LargeEmitter_Heavy";
   externalLink12 = "LargeEmitter_Heavy";
   externalLink13 = "LargeEmitter_Heavy";
   externalLink14 = "LargeEmitter_Heavy";
   
   externalLink15 = "PointDefenseBeamEmitter_H";
   externalLink16 = "PointDefenseBeamEmitter_H";
   externalLink17 = "ReactorBooster_H";
   externalLink18 = "ReactorBooster_H";
   externalLink19 = "BeamBooster_H";
};