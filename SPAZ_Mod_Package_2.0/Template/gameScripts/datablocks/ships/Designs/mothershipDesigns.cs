
////////////////////////////////////////////////////////////////////////////////
// MOTHERSHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE DYSON 1
/////////////////////////////////////////////

datablock ShipDesignDatablock(DysonStation_01 : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullDyson_01;  //This determines what we can put of the ship. 

   shipEngine            = Mothership_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Mothership_BasicReactor;
   shipShield            = Mothership_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
  
   externalLink6  = "MothershipEmitter";  //dont start with one. 
   
   externalLink7   = "TractorEmitter_large";
   externalLink8   = "TractorEmitter_large";
   externalLink9   = "TractorEmitter_large";
   externalLink10   = "TractorEmitter_large";
  
   turretLink11  = "MediumTurret";
   turretWeaponLink11_1  = "MediumCannon_Pulse";
           
   turretLink12 = "MediumTurret";
   turretWeaponLink12_1 = "MediumCannon_Pulse";
      
   turretLink13 = "LargeTurret";
   turretWeaponLink13_1 = "LargeEmitter";
   
   turretLink14 = "MediumTurret";
   turretWeaponLink14_1 = "MediumEmitter";
};

/////////////////////////////////////////////
// THE DYSON 2
/////////////////////////////////////////////

datablock ShipDesignDatablock(DysonStation_02 : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullDyson_02;  //This determines what we can put of the ship. 

   shipEngine            = Mothership_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Mothership_BasicReactor;
   shipShield            = Mothership_FortressShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   shipArmorPlates_Front     = 400;
   shipArmorPlates_Starboard = 200;
   shipArmorPlates_Aft       = 200;
   shipArmorPlates_Port      = 200;
  
   externalLink6  = "MothershipEmitter_super";  
   
   externalLink7   = "TractorEmitter_large";
   externalLink8   = "TractorEmitter_large";
   externalLink9   = "TractorEmitter_large";
   externalLink10   = "TractorEmitter_large";
   
   externalLink15   = "HugeLauncher";
   externalLink16   = "HugeLauncher";
  
   turretLink11  = "LargeTurret";
   turretWeaponLink11_1  = "LargeCannon_Pulse";
           
   turretLink12 = "LargeTurret";
   turretWeaponLink12_1 = "LargeCannon_Pulse";
      
   turretLink13 = "HugeTurret";
   turretWeaponLink13_1 = "HugeEmitter";
   
   turretLink14 = "LargeTurret";
   turretWeaponLink14_1 = "LargeCannon_Pulse";  
};

/////////////////////////////////////////////
// THE CLOCKWORK ZERO
/////////////////////////////////////////////

datablock ShipDesignDatablock(ClockworkStation_Zero : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullClockwork_Zero;  //This determines what we can put of the ship. 

   shipEngine            = Mothership_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Mothership_BasicReactor;
   shipShield            = L_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "TitaniumArmor_H";   
   shipArmor_Starboard   = "TitaniumArmor_H";
   shipArmor_Aft         = "TitaniumArmor_H";
   shipArmor_Port        = "TitaniumArmor_H";
   
   
  
   externalLink6   = "TractorEmitter_large";
};

/////////////////////////////////////////////
// THE CLOCKWORK ONE
/////////////////////////////////////////////

datablock ShipDesignDatablock(ClockworkStation_01 : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullClockwork_01;  //This determines what we can put of the ship. 

   shipEngine            = Mothership_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Mothership_BasicReactor;
   shipShield            = L_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_L";   
   shipArmor_Starboard   = "HeavyArmor_L";
   shipArmor_Aft         = "HeavyArmor_L";
   shipArmor_Port        = "HeavyArmor_L";
   
   
  
   //externalLink6  = "HugeEmitter_Heavy";  //no beam for mother at this point
  
   //externalLink7   = "HiveLauncher_Fighter";
   externalLink8   = "TractorEmitter_large";
   externalLink9   = "TractorEmitter_large";
   externalLink10  = "TractorEmitter_large";
   
   externalLink13   = "largeLauncher";
  
   turretLink11  = "MediumTurret";
   turretWeaponLink11_1  = "MediumCannon_Pulse";
    
   turretLink12 = "SmallTurret";
   turretWeaponLink12_1 = "SmallCannon_Pulse";
};

datablock ShipDesignDatablock(ClockworkStation_01_Half : ClockworkStation_01)
{
   shipHull    = HullClockwork_01_Half; 
};

/////////////////////////////////////////////
// THE CLOCKWORK TWO
/////////////////////////////////////////////

datablock ShipDesignDatablock(ClockworkStation_02 : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullClockwork_02;  //This determines what we can put of the ship. 

   shipEngine            = Mothership_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Mothership_BasicReactor;
   shipShield            = H_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
   
   externalLink6  = "MothershipEmitter";  
  
   externalLink7   = "TractorEmitter_large";
   externalLink8   = "TractorEmitter_large";
   externalLink9   = "TractorEmitter_large";
   externalLink10  = "TractorEmitter_large";
   
   externalLink17   = "HugeLauncher";
  
   turretLink11  = "LargeTurret";
   turretWeaponLink11_1  = "LargeCannon_Pulse";
           
   turretLink12 = "SmallTurret";
   turretWeaponLink12_1 = "SmallCannon_Pulse";
      
   turretLink13 = "SmallTurret";
   turretWeaponLink13_1 = "SmallCannon_Pulse";
   
   turretLink14 = "SmallTurret";
   turretWeaponLink14_1 = "SmallCannon_Pulse";
   
   turretLink15 = "SmallTurret";
   turretWeaponLink15_1 = "SmallCannon_Pulse";
   
   turretLink16 = "SmallTurret";
   turretWeaponLink16_1 = "SmallCannon_Pulse";
};

/////////////////////////////////////////////
// THE ZOMBIE CLOCKWORK
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_ClockworkStation : DefaultZombieShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullZombieClockwork;  //This determines what we can put of the ship. 

   shipEngine            = Mothership_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = Mothership_BasicReactor;
   shipShield            = Mothership_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "HeavyArmor_H";   
   shipArmor_Starboard   = "HeavyArmor_H";
   shipArmor_Aft         = "HeavyArmor_H";
   shipArmor_Port        = "HeavyArmor_H";
   
   
     
   turretLink1 = "ZombieCorruptionTurret";
   turretWeaponLink1_1 = "MothershipEmitter_zombie";      
     
   turretLink6 = "HugeTriTurret_zombie";
   turretWeaponLink6_1 = "LargeCannon_Pulse";
   turretWeaponLink6_2 = "MediumLauncher_zombie";  
   turretWeaponLink6_3 = "MediumCannon_zombie"; 
   
   turretLink7 = "HugeTriTurret_zombie";
   turretWeaponLink7_1 = "MediumCannon_zombie";
   turretWeaponLink7_2 = "LargeCannon_Pulse";  
   turretWeaponLink7_3 = "MediumLauncher_zombie"; 
   
   turretLink8 = "HugeTriTurret_zombie";
   turretWeaponLink8_1 = "LargeCannon_Pulse";
   turretWeaponLink8_2 = "LargeCannon_Pulse";  
   turretWeaponLink8_3 = "MediumLauncher_zombie"; 
   
   turretLink9 = "HugeTriTurret_zombie";
   turretWeaponLink9_1 = "LargeCannon_Pulse";
   turretWeaponLink9_2 = "MediumCannon_zombie";  
   turretWeaponLink9_3 = "LargeCannon_Pulse"; 
      
   turretLink10 = "LargeDoubleTurret_zombie";
   turretWeaponLink10_1 = "MediumCannon_zombie";
   turretWeaponLink10_2 = "MediumCannon_zombie"; 
   
   turretLink11 = "LargeDoubleTurret_zombie";
   turretWeaponLink11_1 = "MediumCannon_zombie";
   turretWeaponLink11_2 = "MediumCannon_zombie"; 
};
