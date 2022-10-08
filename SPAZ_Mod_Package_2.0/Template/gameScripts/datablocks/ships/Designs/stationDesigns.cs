
////////////////////////////////////////////////////////////////////////////////
// SPACE STATION
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// BEACON 1
/////////////////////////////////////////////

datablock ShipDesignDatablock(BeaconBase_01 : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullBeacon_01;
   designDescriptionBits = $SST_DESIGN_BASIC;

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   
  
   externalLink2   = "TractorEmitter_large";  
};

datablock ShipDesignDatablock(BeaconBase_02 : BeaconBase_01)
{
   shipHull    = HullBeacon_02;
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   shipReactor           = L_BasicReactor;
   shipShield            = L_BasicShield;
   
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   externalLink3   = "TractorEmitter_large";  
   externalLink4   = "TractorEmitter_large";  
   
   turretLink2  = "MediumTurret";
   turretWeaponLink2_1  = "SmallEmitter";
};

datablock ShipDesignDatablock(BeaconBase_03 : BeaconBase_01)
{
   shipHull    = HullBeacon_03;
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   shipReactor           = H_BasicReactor;
   shipShield            = H_BasicShield;
   
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   externalLink3   = "TractorEmitter_large";  
   externalLink4   = "TractorEmitter_large";  
   externalLink5   = "TractorEmitter_large";  
   
   turretLink2  = "MediumTurret";
   turretWeaponLink2_1  = "MediumEmitter";
};

//used for mission

datablock ShipDesignDatablock(BeaconBase_nerfed : BeaconBase_02) 
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   shipReactor           = M_CivReactor;
   shipShield            = M_CivShield;
   
   shipArmor_Front       = "CivArmor_M";   
   shipArmor_Starboard   = "CivArmor_M";
   shipArmor_Aft         = "CivArmor_M";
   shipArmor_Port        = "CivArmor_M";
   
   turretLink2  = "MediumTurret";
   turretWeaponLink2_1  = "SmallEmitter_Civ";
};

/////////////////////////////////////////////
// OUTPOST STATIONS / FILLER
/////////////////////////////////////////////

datablock ShipDesignDatablock(OutpostBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Outpost;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = L_CivReactor;
   shipShield            = L_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   
  
   externalLink2   = "TractorEmitter_large";  
   externalLink4   = "TractorEmitter_large";  
   
   turretLink3  = "MediumTurret";
   turretWeaponLink3_1  = "MediumCannon_Pulse_Civ";
   
   turretLink5  = "LargeMiningDoubleTurret";
   turretWeaponLink5_1  = "MediumMinerEmitter";
   turretWeaponLink5_2  = "MediumMinerEmitter";
};

datablock ShipDesignDatablock(OutpostBase_zombie : OutpostBase)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   shipHull  = HullBase_zombie_Outpost;
  
   externalLink2   = "LargeCannon_zombie";  
   externalLink4   = "MediumLauncher_Zombie";  
   
   turretLink3  = "MediumTurret";
   turretWeaponLink3_1  = "SmallCannon_Zombie";
  
   turretLink5  = "MediumTurret";
   turretWeaponLink5_1  = "SmallCannon_Zombie";
};

/////////////////////////////////////////////
// TERRAN BASE 1, 2, 3
/////////////////////////////////////////////

datablock ShipDesignDatablock(Terran01Base : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Terran01;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   
  
   externalLink3   = "PointDefenseBeamEmitter_M";
   externalLink5   = "TractorEmitter_large";   
   externalLink6   = "HiveLauncher_Fighter";  

   turretLink1  = "LargeTurret";
   turretWeaponLink1_1  = "LargeCannon_Pulse";
   
   turretLink2  = "SmallTurret";
   turretWeaponLink2_1  = "SmallEmitter";
  
   turretLink4  = "SmallTurret";
   turretWeaponLink4_1  = "SmallEmitter"; 
};

datablock ShipDesignDatablock(Terran02Base : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Terran02;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   
     
   turretLink1  = "HugeTurret";
   turretWeaponLink1_1  = "HugeEmitter";
   
   turretLink2  = "LargeTurret";
   turretWeaponLink2_1  = "LargeEmitter";
     
   turretLink3  = "MediumTurret";
   turretWeaponLink3_1  = "MediumEmitter";
   
   turretLink4  = "LargeTurret";
   turretWeaponLink4_1  = "LargeEmitter";
   
   turretLink5  = "MediumTurret";
   turretWeaponLink5_1  = "MediumEmitter";

   externalLink6   = "HiveLauncher_Fighter";  
   externalLink7   = "ScannerEmitter_L"; 
   externalLink8   = "PointDefenseBeamEmitter_L";    //point def 
   externalLink9   = "TractorEmitter_large";   
};

datablock ShipDesignDatablock(Terran03Base : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Terran03;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
  
   turretLink1  = "HugeTriTurret";
   turretWeaponLink1_1  = "MediumCannon_Pulse";
   turretWeaponLink1_2  = "MediumCannon_Pulse";
   turretWeaponLink1_3  = "MediumCannon_Pulse";
   
   turretLink2  = "HugeTurret";
   turretWeaponLink2_1  = "HugeEmitter";
   
   turretLink3  = "HugeTurret";
   turretWeaponLink3_1  = "HugeEmitter";
   
   turretLink4  = "HugeTurret";
   turretWeaponLink4_1  = "HugeEmitter";
   
   turretLink5  = "HugeTurret";
   turretWeaponLink5_1  = "HugeEmitter";
   
   turretLink6  = "HugeTurret";
   turretWeaponLink6_1  = "HugeEmitter";
   
   turretLink7  = "HugeTurret";
   turretWeaponLink7_1  = "HugeEmitter";
   
   externalLink8   = "TractorEmitter_large";  
   externalLink9   = "PointDefenseBeamEmitter_L";    //point def
   externalLink10   = "PointDefenseBeamEmitter_L";   //point def
   externalLink11   = "HiveLauncher_Fighter";      
   externalLink12   = "ScannerEmitter_L";        
};

/////////////////////////////////////////////
// PIRATE CIV BASE 1, 2, 3
/////////////////////////////////////////////

datablock ShipDesignDatablock(Pirate01Base : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Pirate01;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   
      
   turretLink1  = "LargeTurret";
   turretWeaponLink1_1  = "LargeCannon_Pulse";
   
   turretLink2  = "SmallTurret";
   turretWeaponLink2_1  = "SmallEmitter";  
   
   turretLink3  = "SmallTurret";
   turretWeaponLink3_1  = "SmallEmitter";
   
   externalLink4   = "TractorEmitter_large";  //point def
   externalLink5   = "PointDefenseBeamEmitter_L";  //point def
   externalLink6   = "ScannerEmitter_L";      
};

datablock ShipDesignDatablock(Pirate02Base : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Pirate02;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   
  
   turretLink1  = "HugeTurret";
   turretWeaponLink1_1  = "HugeCannon_Pulse";
   
   turretLink2  = "SmallTurret";
   turretWeaponLink2_1  = "SmallEmitter";

   turretLink3  = "SmallTurret";
   turretWeaponLink3_1  = "SmallEmitter"; 
   
   turretLink4  = "SmallTurret";
   turretWeaponLink4_1  = "SmallEmitter";
   
   externalLink5   = "TractorEmitter_large";  //point def
   externalLink6   = "PointDefenseBeamEmitter_L";  //point def
   externalLink7   = "PointDefenseBeamEmitter_L";  //point def
   
   externalLink8   = "HiveLauncher_Fighter";      
   externalLink9   = "ScannerEmitter_L";          
};

datablock ShipDesignDatablock(Pirate03Base : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Pirate03;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
  
   turretLink1  = "HugeTurret";
   turretWeaponLink1_1  = "HugeCannon_Pulse";
   
   turretLink2  = "LargeTurret";
   turretWeaponLink2_1  = "LargeEmitter"; 
   
   turretLink3  = "LargeTurret";
   turretWeaponLink3_1  = "LargeEmitter";
   
   turretLink4  = "LargeTurret";
   turretWeaponLink4_1  = "LargeEmitter";
   
   turretLink5  = "LargeTurret";
   turretWeaponLink5_1  = "LargeEmitter";  
   
   turretLink6  = "LargeTurret";
   turretWeaponLink6_1  = "LargeEmitter";
   
   turretLink7  = "LargeTurret";
   turretWeaponLink7_1  = "LargeEmitter"; 
   
   externalLink8   = "TractorEmitter_large";  //point def
   externalLink9   = "PointDefenseBeamEmitter_L";  //point def
   externalLink10   = "PointDefenseBeamEmitter_L"; //point def 
     
   externalLink11   = "HiveLauncher_Fighter"; 
   externalLink12   = "ScannerEmitter_L";        
};

/////////////////////////////////////////////
// MINING CIV BASE 1, 2, 3
/////////////////////////////////////////////

datablock ShipDesignDatablock(BoreBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Bore;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   
  
   externalLink3   = "TractorEmitter_large";  
   externalLink5   = "TractorEmitter_large";  
    
   turretLink1  = "HugeMiningTurret";
   turretWeaponLink1_1  = "HugeCoreMiner";
   
   turretLink2  = "LargeMiningDoubleTurret";
   turretWeaponLink2_1  = "MediumMinerEmitter";
   turretWeaponLink2_2  = "MediumMinerEmitter";
  
   turretLink4  = "LargeMiningTurret";
   turretWeaponLink4_1  = "LargeMinerEmitter"; 
};

datablock ShipDesignDatablock(QuarryBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Quarry;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   
  
   externalLink4   = "TractorEmitter_large";  
   externalLink5   = "TractorEmitter_large";  
   externalLink6   = "TractorEmitter_large"; 
   externalLink7   = "TractorEmitter_large";  
   externalLink8   = "HiveLauncher_Civ";   
    
   turretLink1  = "MediumTurret";
   turretWeaponLink1_1  = "MediumCannon_pulse"; 
   
   turretLink2  = "SmallTurret";
   turretWeaponLink2_1  = "SmallCannon_rapid";   
   
   turretLink3  = "SmallTurret";
   turretWeaponLink3_1  = "SmallCannon_rapid";         
    
   turretLink9  = "HugeMiningTurret";
   turretWeaponLink9_1  = "HugeCoreMiner";
   
   turretLink10  = "LargeMiningDoubleTurret";
   turretWeaponLink10_1  = "MediumMinerEmitter";
   turretWeaponLink10_2  = "MediumMinerEmitter";
   
   turretLink11  = "LargeMiningTurret";
   turretWeaponLink11_1  = "LargeMinerEmitter";   
};

datablock ShipDesignDatablock(DredgeBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Dredge;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
   
   externalLink1   = "HiveLauncher_Civ";  
   externalLink10   = "TractorEmitter_large";  
   externalLink11   = "TractorEmitter_large"; 
   externalLink12   = "TractorEmitter_large"; 
   externalLink13   = "TractorEmitter_large"; 
   
   turretLink2  = "HugeMiningTurret";
   turretWeaponLink2_1  = "HugeCoreMiner";
   
   turretLink3  = "HugeMiningTurret";
   turretWeaponLink3_1  = "HugeCoreMiner";
   
   turretLink4  = "LargeDoubleTurret";
   turretWeaponLink4_1  = "MediumEmitter_Civ";
   turretWeaponLink4_2  = "MediumEmitter_Civ";
     
   turretLink5  = "LargeDoubleTurret";
   turretWeaponLink5_1  = "MediumEmitter";
   turretWeaponLink5_2  = "MediumEmitter";
     
   turretLink6  = "LargeDoubleTurret";
   turretWeaponLink6_1  = "MediumCannon_pulse_Civ";
   turretWeaponLink6_2  = "MediumCannon_pulse_Civ"; 
    
   turretLink7  = "LargeDoubleTurret";
   turretWeaponLink7_1  = "MediumCannon_pulse";
   turretWeaponLink7_2  = "MediumCannon_pulse"; 
   
   turretLink8  = "SmallTurret";
   turretWeaponLink8_1  = "SmallCannon_massDriver";
   
   turretLink9  = "SmallTurret";
   turretWeaponLink9_1  = "SmallCannon_massDriver";   
};

/////////////////////////////////////////////
// SCIENCE CIV BASE 1, 2, 3
/////////////////////////////////////////////

datablock ShipDesignDatablock(EchoBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Echo;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   
  
   externalLink1   = "PointDefenseBeamEmitter_L";  //point def
   externalLink2   = "PointDefenseBeamEmitter_L";  //point def
   externalLink3   = "PointDefenseBeamEmitter_L";  //point def
   externalLink4   = "ScannerEmitter_L"; 
   externalLink5   = "SmallLauncher";
   externalLink6   = "SmallLauncher";  
   externalLink7   = "SmallRocketLauncher"; 
   externalLink8   = "SmallRocketLauncher"; 
   externalLink9   = "TractorEmitter_large"; 
};

datablock ShipDesignDatablock(QuasarBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Quasar;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   
  
   externalLink1   = "PointDefenseBeamEmitter_L";  //point def
   externalLink2   = "PointDefenseBeamEmitter_L";  //point def
   externalLink3   = "PointDefenseBeamEmitter_L";  //point def
   externalLink4   = "TractorEmitter_large";  
   externalLink5   = "ScannerEmitter_L";
   externalLink6   = "TractorEmitter_large";  
   externalLink7   = "MediumLauncher"; 
   externalLink8   = "MediumLauncher";
   externalLink9   = "MediumTorpedoLauncher";
   externalLink10   = "MediumTorpedoLauncher";      
   externalLink11   = "MediumRocketLauncher";
   externalLink12   = "MediumRocketLauncher";                  
};

datablock ShipDesignDatablock(PulsarBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Pulsar;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
  
   externalLink1   = "TractorEmitter_large";  
   externalLink2   = "PointDefenseBeamEmitter_L";  //point def
   externalLink3   = "PointDefenseBeamEmitter_L";  //point def
   externalLink4   = "PointDefenseBeamEmitter_L";  //point def
   externalLink5   = "PointDefenseBeamEmitter_L";  //point def
   externalLink6   = "PointDefenseBeamEmitter_L";  //point def
   externalLink7   = "PointDefenseBeamEmitter_L";  //point def
   externalLink8   = "PointDefenseBeamEmitter_L";  //point def
   externalLink9   = "ScannerEmitter_L";  
   externalLink10   = "LargeLauncher"; 
   externalLink11   = "LargeTorpedoLauncher";
   externalLink12   = "LargeLauncher";
   externalLink13   = "LargeTorpedoLauncher";      
   externalLink14   = "MediumRocketLauncher";
   externalLink15   = "MediumRocketLauncher"; 
   externalLink16   = "MediumRocketLauncher";
   externalLink17   = "MediumRocketLauncher";   
};

/////////////////////////////////////////////
// COLONY CIV BASE 1, 2, 3
/////////////////////////////////////////////

datablock ShipDesignDatablock(SanctuaryBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Sanctuary;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   
  
   externalLink1   = "HiveLauncher_Civ";  
   externalLink2   = "TractorEmitter_large";  
   externalLink3   = "PointDefenseBeamEmitter_M"; //point def
};

datablock ShipDesignDatablock(OasisBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Oasis;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   
  
   externalLink2   = "PointDefenseBeamEmitter_L"; //point def 
   externalLink3   = "PointDefenseBeamEmitter_L"; //point def 
   externalLink4   = "TractorEmitter_large";  
   externalLink5   = "TractorEmitter_large";  
   externalLink6   = "HiveLauncher_Zapper";  
   externalLink7   = "HiveLauncher_Civ";   
};

datablock ShipDesignDatablock(FiveStarBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_FiveStar;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
  
   externalLink2   = "HiveLauncher_Civ";
   externalLink3   = "HiveLauncher_Fighter";  
   externalLink4   = "HiveLauncher_Zapper";  
   externalLink5   = "HiveLauncher_Bomber";
                
   externalLink6   = "PointDefenseBeamEmitter_L";  
   externalLink7   = "PointDefenseBeamEmitter_L";  
   externalLink8   = "PointDefenseBeamEmitter_L";  
   externalLink9   = "PointDefenseBeamEmitter_L";  
     
   externalLink10   = "TractorEmitter_large"; 
   externalLink11   = "TractorEmitter_large";   
   externalLink12   = "TractorEmitter_large";  
   externalLink13   = "TractorEmitter_large";  
};

/////////////////////////////////////////////
// CAR LOT BASE (unused)
/////////////////////////////////////////////

datablock ShipDesignDatablock(CarLotBase : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   shipHull    = HullCarLot;

   shipEngine            = Station_CivEngine;   
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   shipArmor_Front       = "HeavyArmor_M";   
   shipArmor_Starboard   = "HeavyArmor_M";
   shipArmor_Aft         = "HeavyArmor_M";
   shipArmor_Port        = "HeavyArmor_M";
   
   
  
   externalLink2   = "TractorEmitter_large";  
};

////////////////////////////////////////////////////////////////////////////////
// ZOMBIE STATION 1, 2, 3
////////////////////////////////////////////////////////////////////////////////

datablock ShipDesignDatablock(EyeZombieStation : DefaultZombieShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = Hull_zombie_eye;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
   
   turretLink1  = "LargeDoubleTurret_zombie";
   turretWeaponLink1_1  = "MediumCannon_zombie";
   turretWeaponLink1_2  = "MediumLauncher_Zombie"; 
};

datablock ShipDesignDatablock(HeartZombieStation : DefaultZombieShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = Hull_zombie_heart;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
   
   turretLink2  = "LargeDoubleTurret_zombie";
   turretWeaponLink2_1  = "MediumCannon_zombie";
   turretWeaponLink2_2  = "MediumLauncher_Zombie"; 
   
   turretLink3  = "LargeDoubleTurret_zombie";
   turretWeaponLink3_1  = "MediumLauncher_Zombie";
   turretWeaponLink3_2  = "MediumCannon_zombie";  
   
   turretLink4  = "LargeDoubleTurret_zombie";
   turretWeaponLink4_1  = "MediumCannon_zombie";
   turretWeaponLink4_2  = "MediumLauncher_Zombie";   
};

datablock ShipDesignDatablock(ArteryZombieStation : DefaultZombieShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = Hull_zombie_artery;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
  
   turretLink1  = "HugeTriTurret_zombie";
   turretWeaponLink1_1  = "MediumCannon_zombie";
   turretWeaponLink1_2  = "MediumLauncher_Zombie";
   turretWeaponLink1_3  = "MediumCannon_zombie";
   
   turretLink2  = "LargeDoubleTurret_zombie";
   turretWeaponLink2_1  = "MediumCannon_zombie";
   turretWeaponLink2_2  = "MediumLauncher_Zombie"; 
   
   turretLink3  = "LargeDoubleTurret_zombie";
   turretWeaponLink3_1  = "MediumCannon_zombie";
   turretWeaponLink3_2  = "MediumLauncher_Zombie";  
   
   turretLink4  = "LargeDoubleTurret_zombie";
   turretWeaponLink4_1  = "MediumCannon_zombie";
   turretWeaponLink4_2  = "MediumLauncher_Zombie";   
};

datablock ShipDesignDatablock(HiveZombieStation : DefaultZombieShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = Hull_zombie_hive;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
  
   turretLink2  = "HugeTriTurret_zombie";
   turretWeaponLink2_1  = "MediumCannon_zombie";
   turretWeaponLink2_2  = "MediumCannon_zombie";
   turretWeaponLink2_3  = "MediumCannon_zombie";
   
   turretLink3  = "LargeDoubleTurret_zombie";
   turretWeaponLink3_1  = "MediumLauncher_Zombie";
   turretWeaponLink3_2  = "MediumLauncher_Zombie"; 
   
   turretLink4  = "LargeDoubleTurret_zombie";
   turretWeaponLink4_1  = "MediumLauncher_Zombie";
   turretWeaponLink4_2  = "MediumLauncher_Zombie";  
   
   turretLink5  = "LargeDoubleTurret_zombie";
   turretWeaponLink5_1  = "MediumCannon_zombie";
   turretWeaponLink5_2  = "MediumCannon_zombie";   
};

////////////////////////////////////////////////////////////////////////////////
// BOUNTY BASE 03
////////////////////////////////////////////////////////////////////////////////

datablock ShipDesignDatablock(Bounty03Base_Basic : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Bounty03;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_CivReactor;
   shipShield            = Station_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
    
   turretLink2  = "HugeTurret";
   turretWeaponLink2_1  = "HugeEmitter";
   
   turretLink3  = "HugeTurret";
   turretWeaponLink3_1  = "HugeEmitter";
   
   turretLink4  = "HugeTurret";
   turretWeaponLink4_1  = "HugeEmitter";
   
   turretLink5  = "HugeTurret";
   turretWeaponLink5_1  = "HugeEmitter";
   
   turretLink6  = "HugeTurret";
   turretWeaponLink6_1  = "HugeEmitter";
   
   turretLink7  = "HugeTurret";
   turretWeaponLink7_1  = "HugeEmitter";
   
   externalLink1   = "HiveLauncher_Fighter"; 
   externalLink8   = "HugeLauncher";  
   externalLink9   = "HugeLauncher";    
   externalLink10   = "PointDefenseBeamEmitter_H";   
   externalLink11   = "PointDefenseBeamEmitter_H";      
   externalLink12   = "PointDefenseBeamEmitter_H"; 
   externalLink13   = "PointDefenseBeamEmitter_H"; 
   externalLink14   = "HugeLauncher";  
   externalLink15   = "HugeLauncher";          
};



datablock ShipDesignDatablock(Bounty03Base_Improved : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Bounty03;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_AdvancedReactor;
   shipShield            = Station_ImprovedShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
    
   turretLink2  = "HugeDoubleTurret";
   turretWeaponLink2_1  = "LargeEmitter_ION";
   turretWeaponLink2_2  = "LargeEmitter_LEECH";
   
   turretLink3  = "HugeDoubleTurret";
   turretWeaponLink3_1  = "LargeCannon_pulse";
   turretWeaponLink3_2  = "LargeCannon_pulse";
   
   turretLink4  = "HugeDoubleTurret";
   turretWeaponLink4_1  = "HugeEmitter";
   turretWeaponLink4_2  = "HugeEmitter";
   
   turretLink5  = "HugeDoubleTurret";
   turretWeaponLink5_1  = "LargeEmitter_ION";
   turretWeaponLink5_2  = "LargeEmitter_ION";
   
   turretLink6  = "HugeDoubleTurret";
   turretWeaponLink6_1  = "LargeCannon_pulse";
   turretWeaponLink6_2  = "LargeCannon_pulse";
   
   turretLink7  = "HugeDoubleTurret";
   turretWeaponLink7_1  = "HugeEmitter";
   turretWeaponLink7_2  = "HugeEmitter";
   
   externalLink1   = "HiveLauncher_Bomber"; 
   externalLink8   = "HugeRocketLauncher";  
   externalLink9   = "HugeLauncher";    
   externalLink10   = "ScannerEmitter_H";   
   externalLink11   = "PointDefenseBeamEmitter_H";      
   externalLink12   = "PointDefenseBeamEmitter_H"; 
   externalLink13   = "PointDefenseBeamEmitter_H"; 
   externalLink14   = "HugeRocketLauncher";  
   externalLink15   = "HugeLauncher";          
};


datablock ShipDesignDatablock(Bounty03Base_Advanced : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   //Determines the skeleton for the ship.  
   shipHull    = HullBase_Bounty03;  //This determines what we can put of the ship. 

   shipEngine            = Station_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Station_AdvancedReactor;
   shipShield            = Station_AdvancedShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "AdvancedArmor_H";   
   shipArmor_Starboard   = "AdvancedArmor_H";
   shipArmor_Aft         = "AdvancedArmor_H";
   shipArmor_Port        = "AdvancedArmor_H";
    
   turretLink2  = "HugeMotherTurret_Bounty";
   turretWeaponLink2_1  = "MothershipEmitter";
      
   turretLink3  = "HugeTriTurret";
   turretWeaponLink3_1  = "LargeCannon_massDriver";
   turretWeaponLink3_2  = "LargeCannon_massDriver";
   turretWeaponLink3_3  = "LargeCannon_massDriver";
   
   turretLink4  = "HugeTriTurret";
   turretWeaponLink4_1  = "LargeCannon_rapid";
   turretWeaponLink4_2  = "LargeCannon_rapid";
   turretWeaponLink4_3  = "LargeCannon_rapid";
   
   turretLink5  = "DeployTurret_Tri";
   turretWeaponLink5_1  = "LargeTorpedoLauncher";
   turretWeaponLink5_2  = "LargeTorpedoLauncher";
   turretWeaponLink5_3  = "LargeTorpedoLauncher";
   
   turretLink6  = "HugeTriTurret";
   turretWeaponLink6_1  = "LargeEmitter";
   turretWeaponLink6_2  = "LargeEmitter";
   turretWeaponLink6_3  = "LargeEmitter";
   
   turretLink7  = "HugeTriTurret";
   turretWeaponLink7_1  = "LargeEmitter_ION";
   turretWeaponLink7_2  = "LargeEmitter_ION";
   turretWeaponLink7_3  = "LargeEmitter_ION";
   
   externalLink1   = "ShieldBooster_H"; 
   externalLink8   = "ShieldBooster_H";  
   externalLink9   = "ShieldBooster_H";    
   externalLink10   = "ShieldBooster_H";   
   externalLink11   = "ScannerEmitter_H";      
   externalLink12   = "CannonBooster_H"; 
   externalLink13   = "BeamBooster_H"; 
   externalLink14   = "ShieldBooster_H";  
   externalLink15   = "ShieldBooster_H";          
};






