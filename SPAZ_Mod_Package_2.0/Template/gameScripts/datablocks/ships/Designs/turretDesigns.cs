/////////////////////////////////////////////
// DEPLOYABLE TURRETS
/////////////////////////////////////////////


//////////////////////////////////////////////////////////////////
// Medium ////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////
datablock ShipDesignDatablock(DeployTurretShip_Surplus : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = DeployTurretHull_Surplus; //may want some surplus art.
   designDescriptionBits = $SST_DESIGN_CIV;

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";
   
   turretLink1  = "DeployTurret_Single";
   turretWeaponLink1_1  = "MediumEmitter_Civ";
};

/////////////////////////////////
// $SST_DESIGN_BASIC 
/////////////////////////////////
//Small armor and systems

datablock ShipDesignDatablock(DeployTurretShip_Basic : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = DeployTurretHull_Basic;
   designDescriptionBits = $SST_DESIGN_BASIC;

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
   
   turretLink1  = "DeployTurret_Single";
   turretWeaponLink1_1  = "MediumCannon_pulse";
};


/////////////////////////////////
// $SST_DESIGN_BASIC 
/////////////////////////////////
//medium armor and systems

datablock ShipDesignDatablock(DeployTurretShip_Ion : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = DeployTurretHull_Ion;
   designDescriptionBits = $SST_DESIGN_IMPROVED;

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = L_OverchargedReactor;  //need lots of power
   shipShield            = M_StableCloak;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   turretLink1  = "DeployTurret_Single";
   turretWeaponLink1_1  = "LargeEmitter_ION";
   
};


datablock ShipDesignDatablock(DeployTurretShip_Leech : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = DeployTurretHull_Leech;
   designDescriptionBits = $SST_DESIGN_IMPROVED;

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = L_OverchargedReactor;  //need lots of power
   shipShield            = M_StableCloak;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_M";   
   shipArmor_Starboard   = "TitaniumArmor_M";
   shipArmor_Aft         = "TitaniumArmor_M";
   shipArmor_Port        = "TitaniumArmor_M";
   
   turretLink1  = "DeployTurret_Single";
   turretWeaponLink1_1  = "LargeEmitter_LEECH";
};

/////////////////////////////////
// $SST_DESIGN_ADVANCED 
/////////////////////////////////


datablock ShipDesignDatablock(DeployTurretShip_TorpedoRack : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = DeployTurretHull_Torpedo;
   designDescriptionBits = $SST_DESIGN_ADVANCED;

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = M_FortressShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   turretLink1  = "DeployTurret_Tri";
   turretWeaponLink1_1  = "MediumTorpedoLauncher";
   turretWeaponLink1_2  = "MediumTorpedoLauncher";
   turretWeaponLink1_3  = "MediumTorpedoLauncher";
   
   externalLink2 = "ScannerEmitter_L";
};

datablock ShipDesignDatablock(DeployTurretShip_BattleStation : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = DeployTurretHull_BattleStation;
   designDescriptionBits = $SST_DESIGN_ADVANCED;

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_OverchargedReactor;
   shipShield            = L_FortressShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   turretLink1  = "DeployTurret_Dual";
   turretWeaponLink1_1  = "LargeCannon_rapid";
   turretWeaponLink1_2  = "LargeCannon_rapid";
     
   externalLink2 = "ScannerEmitter_L";
};


