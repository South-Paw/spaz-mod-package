
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// STATION HULLS /////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Base for all Station hulls (uses mothership sized stuff)
//sizes 512, 768 1024
datablock HullDatablock(HullStation : HullBase)
{        
   
   size = "512 512";  //Motherships are no bigger than this. 
   
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   componentSize         = $SLOT_MOTHERSHIP; 

   hullTurnSpeedMod      = $MULT_AVERAGE;  
   hullType              = $HULLTYPE_STATION;   
   
   explosionDatablock    = "HugeExplosion";  
   explosionSound        = "snd_hugeExplosion";
  
   
   disabilityEffectMaxScale  = "1";
   
   hullEngineSpace       = $SLOT_MOTHERSHIP; 
   hullReactorSpace      = $SLOT_MOTHERSHIP; 
   hullShieldSpace       = $SLOT_MOTHERSHIP; 
   hullArmorSpace        = $SLOT_HUGE;
   
   NumBlackBoxes = -1;
   
   engineCoreLink = "";
   reactorCoreLink = "";
   shieldCoreLink = "";
   
   largeEscapePodChance  = 0.50; 
   
   //no bigger then this or it looks dumb
   invasionEffectScale_Zombie = 2;
   invasionEffectScale_Terran  = 2;
   invasionEffectScale_Civ  = 2;
   invasionEffectScale_Pirate  = 2;
     
   miniHudIcon = "ShipDisplay_hull_stationImageMap";
   
   debrisCluster_Light = "DC_Combat_Huge_Light";  
   debrisCluster_Heavy = "DC_Combat_Huge_Heavy";  
   
   subExplosionDatablockWL  = "BigExplosion 5 MediumExplosion 50 MediumExplosion_Debris 1";  
   subExplosionScale        = 0.7; 
   
   rotationRate = 8;  //makes immobile objects like stations rotate on their axis
   
   hasWhiteFlash = true;
   hasShockwave = true;
   
   //egg
   embryoInfo[0] = "0 1 1 ZombieEggBase";  
   
   hullTypeXPMult = 1.0;   
};

datablock HullDatablock(HullStation_zombie : HullStation)
{        
   explosionDatablock    = "HugeExplosion_zombie";  
   explosionSound        = "snd_hugeExplosion_zombie";
   hullHitEffect         = "hullImpact_zombie";
   hullHitSound          = "snd_hullHit_zombie"; 
   
   embryoImage = "heart_embryoImageMap"; 
   
   debrisCluster_Light = "DC_Combat_Huge_Light_Zombie";  
   debrisCluster_Heavy = "DC_Combat_Huge_Heavy_Zombie";  
   hullDamageModifier_Explosive   = "1";  //so explosions do not nuke zombies.

   subExplosionDatablockWL  = "BigExplosion_zombie 10 MediumExplosion_zombie 50";  
};

//beacons

datablock HullDatablock(HullBeacon_01 : HullStation) 
{   
   friendlyName = "Warp Beacon";    
   
   size = "128 128";   
   imageMapShield = "base_circle_shieldImageMap";
   
   explosionDatablock    = "BigExplosion";  
   explosionSound        = "snd_bigExplosion"; 
   explosionCascadeMulti = 0.25; //tiny cascade
   
   rootDesign = "BeaconBase_01";
   
   hasShockwave = false;  
   canBeInvaded = false;   
   
   maxCrewSize = 1;  //if blows up we only lose 1 crew
   comparativeCrew       = -1;
      
   factionImageMap_Default = "beacon_terran_01ImageMap"; 
   factionImageMap_Terran = "beacon_terran_01ImageMap"; 
   factionImageMap_Pirate = "beacon_pirate_01ImageMap";
   
   hullIconImageMap = "beacon_iconImageMap";      
         
   CollisionPolyList = "-0.508 -0.447 -0.021 -0.692 0.471 -0.481 0.644 0.005 0.545 0.432 0.000 0.697 -0.513 0.442 -0.707 -0.015";
   LinkPoints = "0.010 0.000 0.728 0.005";
   
   maxComponentHealth    = 75; 
   comparativeHealth     = -1; //skip
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "2";
   
   externalLinkType2  = $LINK_Utility; 
   externalLinkSize2  = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_beacon 0 0 0";     
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkTerran_1 = "0.005 -0.452 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "0.000 0.442 0 0 1 DoodadSet_Terran_L_Lights";
   doodadLinkTerran_3 = "0.000 0.000 0 1 1 DoodadSet_BeaconTerran"; 
     
   doodadLinkPirate_1 = "0.005 -0.452 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "0.000 0.442 0 0 1 DoodadSet_Pirate_L_Lights";
   doodadLinkPirate_3 = "0.000 0.000 0 1 1 DoodadSet_BeaconPirate"; 
   
   miniHudIcon = "beacon_iconImageMap";
   
   //egg
   embryoInfo[0] = "0.246 -0.290 1 ZombieEggBase";  
   
   hullTypeXPMult = 0.025;
   
   comparativeCargo = -1;
   hullCargoSpace = 50;
   
   threatMult = 0;
   blossomRangeMult = 0.200;
};

datablock HullDatablock(HullBeacon_02 : HullBeacon_01) 
{  
   LinkPoints = "0.005 0.005 0.728 0.000 -0.634 0.417 -0.639 -0.452"; 
   
   factionImageMap_Default = "beacon_terran_02ImageMap"; 
   factionImageMap_Terran = "beacon_terran_02ImageMap"; 
   factionImageMap_Pirate = "beacon_pirate_02ImageMap"; 
    
   externalLinkPoints = "3 4";
   turretLinkPoints = "2";
   
   canBeInvaded = false; 
   
   rootDesign = "BeaconBase_02";
   
   maxCrewSize = 1;  //if blows up we only lose 1 crew
   comparativeCrew       = -1;
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE; 
   
   hullTurretSize2 = $SLOT_LARGE;      
   
   maxComponentHealth    = 150; 
   comparativeHealth     = -1;  //SKIP
   
   hullTypeXPMult = 0.05;
   comparativeCargo = -1;
   hullCargoSpace = 75;
   
   threatMult = $ThreatMult_VeryLow;
   blossomRangeMult = 0.250;
};

datablock HullDatablock(HullBeacon_03 : HullBeacon_01) 
{   
   LinkPoints = "0.000 0.005 0.650 -0.447 0.629 0.412 -0.634 0.417 -0.644 -0.447";
   
   factionImageMap_Default = "beacon_terran_03ImageMap"; 
   factionImageMap_Terran = "beacon_terran_03ImageMap"; 
   factionImageMap_Pirate = "beacon_pirate_03ImageMap"; 
   
   externalLinkPoints = "3 4 5";
   turretLinkPoints = "2";
   
   canBeInvaded = false; 
   
   rootDesign = "BeaconBase_03";
   
   maxCrewSize = 1;  //if blows up we only lose 1 crew
   comparativeCrew       = -1;
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE; 
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE; 
   
   hullTurretSize2 = $SLOT_LARGE;   
   
   maxComponentHealth    = 225; 
   comparativeHealth     = -1;  //Skip
   
   hullTypeXPMult = 0.1;
   comparativeCargo = -1;
   hullCargoSpace = 125;
   
   threatMult = $ThreatMult_Low;
   blossomRangeMult = 0.350;
};

//generic outpost

datablock HullDatablock(HullBase_Outpost : HullStation) 
{   
   friendlyName = "Outpost";     
   
   size = "256 256";   
   imageMapShield = "base_circle_shieldImageMap";
   
   explosionDatablock    = "BigExplosion";  
   explosionSound        = "snd_bigExplosion"; 
   
   rootDesign = "OutpostBase";
   
   hasShockwave = false;
   
   comparativeCrew       = $MULT_LOWEST;
   
   factionImageMap_Default = "base_terran_outpostImageMap"; 
   factionImageMap_Terran  = "base_terran_outpostImageMap"; 
   factionImageMap_Civ     = "base_civ_outpostImageMap"; 
   factionImageMap_Pirate  = "base_pirate_outpostImageMap";
   
   hullIconImageMap = "base_terran_outpost_iconImageMap";   
   
   GuiCollision = "-0.948 -0.020 0.026 -1.000 0.948 -0.015 0.000 0.982";         
   CollisionPolyList = "-0.346 -0.334 0.000 -0.471 0.351 -0.270 0.450 0.000 0.320 0.309 -0.016 0.476 -0.325 0.329 -0.519 0.005";
   MountedCollisionPolyList[0] = "-0.126 -0.859 0.136 -0.859 0.131 0.850 -0.126 0.845"; 
   MountedCollisionPolyList[1] = "-0.849 -0.128 0.833 -0.113 0.843 0.123 -0.859 0.118"; 
   
   LinkPoints = "0.005 0.005 -0.760 0.010 -0.010 -0.746 0.749 0.010 -0.010 0.761";
   
   maxComponentHealth    = 150; 
   comparativeHealth     = -1;  //skip
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "2 4";
   turretLinkPoints = "3 5";
   
   externalLinkType2  = $LINK_Universal; 
   externalLinkSize2  = $SLOT_LARGE;   
   
   externalLinkType4  = $LINK_Universal; 
   externalLinkSize4  = $SLOT_LARGE;  
   
   hullTurretSize3 = $SLOT_LARGE;  
   hullTurretSize5 = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_stationDoodad_Small 0 0 0";    
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkTerran_1 = "-0.314 -0.295 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "0.304 -0.295 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "0.304 0.304 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "-0.309 0.324 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_5 = "0 0 0 1 1 Doodad_StationSpinner_Small";   
   
   doodadLinkPirate_1 = "-0.314 -0.295 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "0.304 -0.295 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "0.304 0.304 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "-0.309 0.324 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_5 = "0 0 0 1 1 Doodad_StationSpinner_Small";   
   
   doodadLinkCiv_1 = "-0.314 -0.295 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "0.304 -0.295 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "0.304 0.304 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "-0.309 0.324 0 0 1 DoodadSet_Civ_L_Lights";
   doodadLinkCiv_5 = "0 0 0 1 1 Doodad_StationSpinner_Small"; 

   //egg
   embryoInfo[0] = "0.204 -0.196 2 ZombieEggBase";    
   
   hullTypeXPMult = 0.2;   
   comparativeCargo = -1;
   hullCargoSpace = 250;
   
   threatMult = $ThreatMult_Low;
   blossomRangeMult = 0.500;
};

//terran

datablock HullDatablock(HullBase_Terran01 : HullStation) 
{   
   friendlyName = "UTA Base T1";  
   
   size = "512 512";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_terran_01ImageMap";
   hullIconImageMap = "base_terran_01_iconImageMap";    
      
   GuiCollision = "-0.524 -0.908 0.482 -0.913 0.739 0.000 0.576 0.884 -0.508 0.918 -0.744 0.044";   
   CollisionPolyList = "-0.471 -0.471 0.016 -0.629 0.487 -0.388 0.623 0.010 0.477 0.437 0.000 0.648 -0.461 0.481 -0.655 -0.010";
   MountedCollisionPolyList[0] = "-0.461 -0.761 0.010 -0.899 0.492 -0.766 0.288 -0.565 -0.320 -0.565"; //top terran
   MountedCollisionPolyList[1] = "-0.487 0.781 -0.314 0.550 0.262 0.550 0.414 0.786 0.005 0.908"; //bottom terran
   LinkPoints = "0.000 0.010 -0.432 -0.742 0.442 -0.742 -0.427 0.751 0.437 0.751 -0.005 -0.246";
   
   rootDesign = "Terran01Base";
   
   comparativeHealth     = $MULT_LOWEST;
   
   comparativeCrew       = $MULT_LOWEST;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "3 5 6";
   turretLinkPoints = "1 2 4";
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE;   
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE; 
   
   externalLinkType6  = $LINK_Drones; 
   externalLinkSize6  = $SLOT_LARGE;   
   
   hullTurretSize1 = $SLOT_LARGE;  
   hullTurretSize2 = $SLOT_SMALL;  
   hullTurretSize4 = $SLOT_SMALL; 
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med02 0 0 0";
   wreckageData[1] = "ShipWreck_terranStation_01 -0.1 0.1 0";
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkTerran_1 = "-0.275 -0.575 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "-0.206 -0.437 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "0.216 0.452 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "0.290 0.594 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_5 = "-0.270 0.093 0 0 1 DoodadSet_Terran_S_Radar"; 
   doodadLinkTerran_6 = "0.260 -0.093 0 0 1 DoodadSet_Terran_S_Radar"; 
   doodadLinkTerran_7 = "0 0 0 1 1 Doodad_StationSpinner_Med_02"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.4 0.2";
   breachThresholds["Major"] = "0.9 0.7";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.199 -0.192 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.309 -0.069 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.267 0.118 Random BreachSet_Small";

   breachLinks["Major", 1] = "0.309 0.088 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.016 0.339 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0.162 -0.393 3 ZombieEggBase";  
   
   hullTypeXPMult = 0.5;
   comparativeCargo = -1;
   hullCargoSpace = 500;
   
   threatMult = $ThreatMult_Normal;
   blossomRangeMult = 1.000;
};

datablock HullDatablock(HullBase_Terran02 : HullStation) 
{   
   friendlyName = "UTA Base T2";     
   
   rotationRate = 5;
   
   rootDesign = "Terran02Base";
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_terran_02ImageMap";
   hullIconImageMap = "base_terran_02_iconImageMap";     
   
   GuiCollision = "-0.885 -0.427 -0.016 -0.904 0.812 -0.913 0.875 0.309 0.058 0.894 -0.765 0.908";     
   CollisionPolyList = "-0.524 0.000 -0.398 -0.358 0.005 -0.540 0.330 -0.398 0.513 0.010 0.435 0.354 0.016 0.521 -0.314 0.388";
   MountedCollisionPolyList[0] = "-0.807 -0.015 -0.786 -0.349 0.000 0.830 -0.581 0.530 "; //bottom
   MountedCollisionPolyList[1] = "-0.016 -0.805 0.419 -0.717 0.775 -0.226 0.770 0.358"; //top
   MountedCollisionPolyList[2] = "-0.775 0.830 0.712 -0.874 0.780 -0.830 -0.702 0.879"; //bar

   LinkPoints = "0.000 0.010 -0.761 -0.295 -0.707 0.815 0.761 0.295 0.707 -0.810 0.000 -0.221 0.005 0.192 -0.820 -0.005 0.815 0.005";
   
   comparativeHealth     = $MULT_AVERAGE;
   
   comparativeCrew       = $MULT_AVERAGE;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9";
   turretLinkPoints = "1 2 3 4 5";
   
   hullTurretSize1 = $SLOT_HUGE;  
   hullTurretSize2 = $SLOT_LARGE;  
   hullTurretSize3 = $SLOT_LARGE; 
   hullTurretSize4 = $SLOT_LARGE;  
   hullTurretSize5 = $SLOT_LARGE;  
   
   externalLinkType6  = $LINK_Drones; 
   externalLinkSize6  = $SLOT_LARGE;     
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_LARGE;   
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_LARGE;  
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_LARGE;  
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med 0 0 0";
   wreckageData[1] = "ShipWreck_terranStation_02 -0.3 0.3 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN 
   doodadLinkTerran_1 = "-0.422 0.486 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "-0.319 0.373 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "-0.236 0.275 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "0.319 -0.363 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_5 = "0.000 -0.800 0 0 1 DoodadSet_Terran_S_Radar"; 
   doodadLinkTerran_6 = "0.000 0.805 0 0 1 DoodadSet_Terran_S_Radar"; 
   doodadLinkTerran_7 = "0.000 0.010 0 1 1 Doodad_StationSpinner_Med"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.152 -0.192 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.246 -0.118 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.183 -0.025 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.126 -0.196 Random BreachSet_Small";
   breachLinks["Minor", 5] = "-0.079 0.260 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.178 0.138 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.215 0.015 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0.739 0.020 4 ZombieEggBase";  
   
   hullTypeXPMult = 1; 
   comparativeCargo = -1;
   hullCargoSpace = 1000;
   
   threatMult = $ThreatMult_High;
   blossomRangeMult = 1.500;
};

datablock HullDatablock(HullBase_Terran03 : HullStation) 
{   
   friendlyName = "UTA Base T3";  
   
   rotationRate = 2;
   
   rootDesign = "Terran03Base";
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_terran_03ImageMap";
   hullIconImageMap = "base_terran_03_iconImageMap";     
    
   GuiCollision = "-0.587 -0.746 0.560 -0.938 0.948 -0.005 0.849 0.732 -0.152 0.884 -0.964 0.550 -0.995 -0.010";    
   CollisionPolyList = "-0.609 -0.594 0.093 -0.845 0.702 -0.491 0.820 0.074 0.668 0.550 -0.010 0.845 -0.608 0.589 -0.840 0.010";
   MountedCollisionPolyList[0] = "-0.964 0.481 -0.571 0.329 -0.880 0.584"; 
   MountedCollisionPolyList[1] = "0.608 -0.869 0.367 -0.658 0.492 -0.948"; 
   MountedCollisionPolyList[2] = "0.780 0.712 0.581 0.496 0.843 0.614"; 

   LinkPoints = "0.000 0.005 -0.383 0.005 0.049 0.378 0.196 -0.329 0.511 -0.874 0.786 0.648 -0.894 0.511 0.383 -0.658 0.579 0.496 -0.668 0.398 -0.005 -0.108 0.000 0.103";
   
   comparativeHealth     = $MULT_HIGHEST;
   
   comparativeCrew       = $MULT_HIGHEST;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   
   externalLinkPoints = "8 9 10 11 12";
   turretLinkPoints = "1 2 3 4 5 6 7";
   
   hullTurretSize1 = $SLOT_HUGE;  
   hullTurretSize2 = $SLOT_HUGE;  
   hullTurretSize3 = $SLOT_HUGE;  
   hullTurretSize4 = $SLOT_HUGE; 
   hullTurretSize5 = $SLOT_HUGE;  
   hullTurretSize6 = $SLOT_HUGE; 
   hullTurretSize7 = $SLOT_HUGE;   
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_LARGE;   
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_LARGE;  
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_LARGE;  
   
   externalLinkType11  = $LINK_Drones; 
   externalLinkSize11  = $SLOT_LARGE;  
   
   externalLinkType12  = $LINK_Utility; 
   externalLinkSize12  = $SLOT_LARGE; 
   
   wreckageData[0] = "ShipWreck_terranStation_03 0 0 0";
   wreckageData[1] = "ShipWreck_stationDoodad_Large 0 0 0";
   wreckageData[2] = "ShipWreck_stationDoodad_Med 0 0 0";
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN 
   
   doodadLinkTerran_1 = "-0.673 -0.354 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_2 = "-0.216 -0.727 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_3 = "0.732 -0.226 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "-0.358 0.678 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_5 = "-0.481 0.599 0 0 1 DoodadSet_Terran_S_Radar";  
   doodadLinkTerran_6 = "-0.594 -0.471 0 0 1 DoodadSet_Terran_S_Radar";
   doodadLinkTerran_7 = "0.000 0.015 0 1 1 Doodad_StationSpinner_Med"; 
   doodadLinkTerran_8 = "0.000 0.015 0 1 1 Doodad_StationSpinner_Large"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.089 -0.751 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.608 -0.432 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.079 -0.079 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.456 0.619 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.105 0.766 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.760 -0.113 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.094 0.049 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.110 -0.015 Random BreachSet_Huge"; 
   
   //egg
   embryoInfo[0] = "0.419 -0.722 4 ZombieEggBase"; 
   
   hullTypeXPMult = 2.0;
   comparativeCargo = -1;
   hullCargoSpace = 2000;
   
   threatMult = $ThreatMult_VeryHigh;
   blossomRangeMult = 2.000;
};

//pirate

datablock HullDatablock(HullBase_Pirate01 : HullStation) 
{   
   friendlyName = "Rogue Base T1";  
   
   size = "512 512";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_pirate_01ImageMap"; 
   factionImageMap_Terran = "base_pirate_01ImageMap"; 
   factionImageMap_Pirate = "base_pirate_01ImageMap";   
   factionImageMap_Civ = "base_pirate_01ImageMap";  
   hullIconImageMap = "base_pirate_01_iconImageMap"; 

   GuiCollision = "-0.922 -0.015 -0.325 -1.000 0.335 -0.967 0.953 0.010 0.403 0.943 -0.230 0.962";   
   CollisionPolyList = "-0.367 -0.471 0.021 -0.594 0.508 -0.496 0.592 0.010 0.377 0.452 0.000 0.594 -0.498 0.501 -0.581 -0.015";
   MountedCollisionPolyList[0] = "0.849 -0.059 0.864 0.083 -0.817 0.064 -0.817 -0.093"; //horiz bar
   MountedCollisionPolyList[1] = "-0.377 -0.688 -0.220 -0.923 0.031 -0.977 0.026 -0.717"; //top
   MountedCollisionPolyList[2] = "-0.016 0.712 0.419 0.668 0.236 0.889 -0.031 0.948"; //bottom
   MountedCollisionPolyList[3] = "-0.031 -0.889 0.052 -0.889 0.047 0.923 -0.021 0.918"; //vert bar
   
   LinkPoints = "0.010 0.000 -0.761 -0.010 0.781 0.020 -0.054 -0.854 0.064 0.845 0.403 -0.408";
   
   comparativeHealth     = $MULT_LOWEST;
   
   comparativeCrew       = $MULT_LOWEST;
   
   rootDesign = "Pirate01Base";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "4 5 6";
   turretLinkPoints = "1 2 3";
      
   hullTurretSize1 = $SLOT_LARGE;  
   hullTurretSize2 = $SLOT_SMALL;  
   hullTurretSize3 = $SLOT_SMALL; 
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE;   
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE;
   
   externalLinkType6  = $LINK_Utility; 
   externalLinkSize6  = $SLOT_LARGE; 
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med02 0 0 0";   
   wreckageData[1] = "ShipWreck_pirateStation_01 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.215 -0.309 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "-0.346 0.118 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "0.005 0.358 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.330 0.098 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_5 = "0.162 -0.545 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_6 = "-0.157 0.550 0 0 1 DoodadSet_Civ_L_Lights";
   doodadLinkCiv_7 = "0.010 0.000 0 1 1 Doodad_StationSpinner_Med_02"; 
   
   doodadLinkTerran_1 = "-0.215 -0.309 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "-0.346 0.118 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "0.005 0.358 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "0.330 0.098 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_5 = "0.162 -0.545 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_6 = "-0.157 0.550 0 0 1 DoodadSet_Terran_L_Lights";
   doodadLinkTerran_7 = "0.010 0.000 0 1 1 Doodad_StationSpinner_Med_02"; 

   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.4 0.2";
   breachThresholds["Major"] = "0.9 0.7";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.461 0.462 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.309 -0.756 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.299 0.771 Random BreachSet_Small";

   breachLinks["Major", 1] = "-0.168 0.231 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.288 -0.088 Random BreachSet_Huge";  
   
   //egg
   embryoInfo[0] = "-0.335 0.467 3 ZombieEggBase"; 
   
   hullTypeXPMult = 0.5;
   comparativeCargo = -1;
   hullCargoSpace = 500;
   
   threatMult = $ThreatMult_Normal;
   blossomRangeMult = 1.000;
};


datablock HullDatablock(HullBase_Pirate02 : HullStation) 
{   
   friendlyName = "Rogue Base T2";     
   
   rotationRate = 5;
   
   rootDesign = "Pirate02Base";
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_pirate_02ImageMap"; 
   factionImageMap_Terran = "base_pirate_02ImageMap"; 
   factionImageMap_Pirate = "base_pirate_02ImageMap";   
   factionImageMap_Civ = "base_pirate_02ImageMap";  
   hullIconImageMap = "base_pirate_02_iconImageMap";  
    
   GuiCollision = "0.005 -1.000 0.969 0.511 -0.880 0.516";     
   CollisionPolyList = "-0.204 -0.290 0.210 -0.280 0.314 0.093 0.005 0.354 -0.320 0.098";
   MountedCollisionPolyList[0] = "-0.215 -0.692 0.010 -0.948 0.225 -0.678 0.052 0.619 -0.042 0.619"; 
   MountedCollisionPolyList[1] = "-0.555 -0.290 -0.498 -0.363 0.691 0.147 0.791 0.442 0.492 0.496"; 
   MountedCollisionPolyList[2] = "0.534 -0.398 0.587 -0.309 -0.477 0.530 -0.796 0.452 -0.712 0.133"; 
   LinkPoints = "0.010 0.000 -0.486 -0.309 0.521 -0.334 0.015 0.550 -0.756 0.432 0.746 0.412 0.005 -0.859 0.005 -0.246 0.005 -0.457";
   
   comparativeHealth     = $MULT_AVERAGE;
   
   comparativeCrew       = $MULT_AVERAGE;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
   
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "5 6 7 8 9";
   turretLinkPoints = "1 2 3 4";
      
   hullTurretSize1 = $SLOT_HUGE;  
   hullTurretSize2 = $SLOT_SMALL;  
   hullTurretSize3 = $SLOT_SMALL; 
   hullTurretSize4 = $SLOT_SMALL; 
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE;  
   
   externalLinkType6  = $LINK_Utility; 
   externalLinkSize6  = $SLOT_LARGE;  
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_LARGE;  
   
   externalLinkType8  = $LINK_Drones; 
   externalLinkSize8  = $SLOT_LARGE;  
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med02 0 0 0";   
   wreckageData[1] = "ShipWreck_pirateStation_02 0 0 0";
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN      
   doodadLinkCiv_1 = "-0.182 -0.250 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "0.187 -0.241 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "0.010 0.388 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "-0.530 0.275 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_5 = "-0.015 -0.638 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_6 = "0.521 0.265 0 0 1 DoodadSet_Civ_L_Lights";
   doodadLinkCiv_7 = "0.010 0.000 0 1 1 Doodad_StationSpinner_Med_02";  
   
   doodadLinkTerran_1 = "-0.182 -0.250 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "0.187 -0.241 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "0.010 0.388 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "-0.530 0.275 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_5 = "-0.015 -0.638 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_6 = "0.521 0.265 0 0 1 DoodadSet_Terran_L_Lights";
   doodadLinkTerran_7 = "0.010 0.000 0 1 1 Doodad_StationSpinner_Med_02"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7 0.3";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.005 0.221 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.231 0.083 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.157 -0.221 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.442 0.196 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.432 0.236 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.142 -0.192 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.231 -0.079 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.152 0.201 Random BreachSet_Huge";
   breachLinks["Major", 3] = "0.152 0.206 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "-0.340 0.167 4 ZombieEggBase";   
   
   hullTypeXPMult = 1.0;     
   comparativeCargo = -1;
   hullCargoSpace = 1000;   
   
   threatMult = $ThreatMult_High;
   blossomRangeMult = 1.500;
};


datablock HullDatablock(HullBase_Pirate03 : HullStation) 
{   
   friendlyName = "Rogue Base T3";  
   
   rotationRate = 2;
   
   rootDesign = "Pirate03Base";
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_pirate_03ImageMap"; 
   factionImageMap_Terran = "base_pirate_03ImageMap"; 
   factionImageMap_Pirate = "base_pirate_03ImageMap";   
   factionImageMap_Civ = "base_pirate_03ImageMap";  
   hullIconImageMap = "base_pirate_03_iconImageMap";  
     
   GuiCollision = "-0.340 -0.972 0.325 -0.992 1.000 0.093 0.618 0.761 -0.602 0.766 -1.000 0.093";    
   CollisionPolyList = "0.016 -0.309 0.288 -0.088 0.199 0.226 -0.157 0.241 -0.288 -0.088";
   //arms
   MountedCollisionPolyList[0] = "-0.120 -0.928 0.120 -0.928 0.010 -0.093"; 
   MountedCollisionPolyList[1] = "0.917 0.358 0.760 0.594 0.079 0.020"; 
   MountedCollisionPolyList[2] = "-0.718 0.579 -0.870 0.329 -0.094 0.049"; 
   //caps
   MountedCollisionPolyList[3] = "-0.409 -0.727 0.000 -0.982 0.419 -0.722"; 
   MountedCollisionPolyList[4] = "0.859 -0.005 0.843 0.501 0.456 0.712"; 
   MountedCollisionPolyList[5] = "-0.440 0.722 -0.838 0.471 -0.864 0.010"; 
   
   LinkPoints = "0.005 0.005 -0.796 0.324 -0.683 0.501 0.697 0.501 0.791 0.314 0.098 -0.859 -0.113 -0.854 -0.010 -0.688 0.589 0.324 -0.589 0.329 0.005 -0.196 0.005 -0.403";
   
   comparativeHealth     = $MULT_HIGHEST;
   comparativeCrew       = $MULT_HIGHEST;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "8 9 10";
   turretLinkPoints = "1 2 3 4 5 6 7";
      
   hullTurretSize1 = $SLOT_HUGE;  
   hullTurretSize2 = $SLOT_MEDIUM;  
   hullTurretSize3 = $SLOT_MEDIUM; 
   hullTurretSize4 = $SLOT_MEDIUM; 
   hullTurretSize5 = $SLOT_MEDIUM;  
   hullTurretSize6 = $SLOT_MEDIUM; 
   hullTurretSize7 = $SLOT_MEDIUM; 
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_LARGE;  
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_LARGE;  
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_LARGE; 
   
   externalLinkType11  = $LINK_Drones; 
   externalLinkSize11  = $SLOT_LARGE;   
   
   externalLinkType12  = $LINK_Utility; 
   externalLinkSize12  = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med02 0 0 0";     
   wreckageData[1] = "ShipWreck_pirateStation_03 0 0 0";   
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.136 -0.206 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_2 = "-0.230 0.074 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_3 = "-0.440 0.241 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.466 0.250 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_5 = "0.361 0.363 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_6 = "-0.152 -0.481 0 0 1 DoodadSet_Civ_L_Lights";
   doodadLinkCiv_7 = "0.010 0.000 0 1 1 Doodad_StationSpinner_Med";  
   
   doodadLinkTerran_1 = "-0.136 -0.206 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_2 = "-0.230 0.074 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_3 = "-0.440 0.241 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "0.466 0.250 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_5 = "0.361 0.363 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_6 = "-0.152 -0.481 0 0 1 DoodadSet_Terran_L_Lights";
   doodadLinkTerran_7 = "0.010 0.000 0 1 1 Doodad_StationSpinner_Med"; 
   
   doodadLinkPirate_1 = "-0.136 -0.206 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_2 = "-0.230 0.074 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_3 = "-0.440 0.241 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "0.466 0.250 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_5 = "0.361 0.363 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_6 = "-0.152 -0.481 0 0 1 DoodadSet_Pirate_L_Lights";
   doodadLinkPirate_7 = "0.010 0.000 0 1 1 Doodad_StationSpinner_Med"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7 0.3";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.000 -0.599 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.335 0.246 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.388 0.157 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.519 0.275 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.849 0.103 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.540 0.653 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.189 -0.074 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.110 0.152 Random BreachSet_Huge";
   breachLinks["Major", 3] = "0.199 -0.064 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0.461 0.246 4 ZombieEggBase"; 
   
   hullTypeXPMult = 2.0;    
   comparativeCargo = -1;
   hullCargoSpace = 2000;
   
   threatMult = $ThreatMult_VeryHigh;    
   blossomRangeMult = 2.000;        
};

//civ

datablock HullDatablock(HullBase_Bore : HullStation) 
{   
   friendlyName = "Bore Mining Base";  
   
   size = "512 512";   
   imageMapShield = "base_circle_shieldImageMap";
   
   rootDesign = "BoreBase";
   
   
   factionImageMap_Default = "base_civ_boreImageMap";
   hullIconImageMap = "base_civ_bore_iconImageMap";  
      
   CollisionPolyList = "-0.614 -0.403 -0.417 -0.550 0.437 -0.545 0.624 -0.201 0.609 0.565 -0.633 0.560";
   LinkPoints = "0.005 -0.462 -0.182 -0.152 0.162 0.300 0.172 -0.162 -0.167 0.074 -0.177 0.300";
   
   comparativeHealth     = $MULT_LOWEST;
   
   comparativeCrew       = $MULT_LOWEST; 
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "3 5";
   turretLinkPoints = "1 2 4";
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE;   
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE;  
   
   hullTurretSize1 = $SLOT_HUGE;  
   hullTurretSize2 = $SLOT_LARGE;  
   hullTurretSize4 = $SLOT_LARGE; 
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med02 0 0 0";
   wreckageData[1] = "shipWreck_boreStation_01 0 0 0";
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkCiv_1 = "-0.211 -0.398 0 0 0.9 DoodadSet_Terran_S_Radar";   
   doodadLinkCiv_2 = "0.162 0.064 0 0 0.9 DoodadSet_Terran_S_Radar"; 
   doodadLinkCiv_3 = "-0.231 -0.417 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.280 -0.442 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_5 = "-0.108 -0.648 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_6 = "-0.196 -0.648 0 0 1 DoodadSet_Civ_L_Lights";
   doodadLinkCiv_7 = "0 0 0 1 1 Doodad_StationSpinner_Med_02";   
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.4 0.2";
   breachThresholds["Major"] = "0.9 0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.325 0.128 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.126 0.192 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.005 0.236 Random BreachSet_Small";

   breachLinks["Major", 1] = "0.010 -0.260 Random BreachSet_Small";
   breachLinks["Major", 2] = "0.299 -0.059 Random BreachSet_Small";
   
   //egg
   embryoInfo[0] = "0.712 0.025 3 ZombieEggBase"; 
   
   hullTypeXPMult = 0.25;    
   comparativeCargo = -1;
   hullCargoSpace = 500; 
   
   threatMult = $ThreatMult_Normal; 
   blossomRangeMult = 1.000;
};


datablock HullDatablock(HullBase_Quarry : HullStation) 
{   
   friendlyName = "Quarry Mining Base";     
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_civ_quarryImageMap";
   hullIconImageMap = "base_civ_quarry_iconImageMap";   
      
   CollisionPolyList = "-0.555 -0.638 0.025 -0.859 0.781 -0.398 0.663 0.589 0.005 0.864 -0.535 0.653 -0.864 0.069";
   LinkPoints = "0.290 0.103 0.108 0.147 0.177 0.246 0.555 0.010 0.722 0.010 0.496 -0.535 0.614 -0.648 -0.727 0.049 -0.506 -0.363 -0.039 -0.442 -0.309 0.049";
   
   comparativeHealth     = $MULT_AVERAGE;
   
   comparativeCrew       = $MULT_AVERAGE;
   
   rootDesign = "QuarryBase";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "4 5 6 7 8";
   turretLinkPoints = "1 2 3 9 10 11";
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE;     
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE;   
   
   externalLinkType6  = $LINK_Utility; 
   externalLinkSize6  = $SLOT_LARGE;  
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_LARGE;  
   
   externalLinkType8  = $LINK_Drones; 
   externalLinkSize8  = $SLOT_LARGE;  
   
   hullTurretSize1 = $SLOT_MEDIUM;  
   hullTurretSize2 = $SLOT_SMALL;  
   hullTurretSize3 = $SLOT_SMALL; 
   
   hullTurretSize9 = $SLOT_HUGE;  
   hullTurretSize10 = $SLOT_MEDIUM;  
   hullTurretSize11 = $SLOT_MEDIUM; 
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med 0 0 0";
   wreckageData[1] = "shipWreck_quarryStation_01 0 0 0";

   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkCiv_1 = "-0.026 -0.614 0 0 0.9 DoodadSet_Terran_S_Radar";   
   doodadLinkCiv_2 = "-0.257 0.486 0 0 0.9 DoodadSet_Terran_S_Radar"; 
   doodadLinkCiv_3 = "0.157 -0.383 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.456 0.231 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_5 = "-0.592 0.177 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_6 = "-0.471 0.118 0 0 1 DoodadSet_Civ_L_Lights";
   doodadLinkCiv_7 = "0 0 0 1 1 Doodad_StationSpinner_Med";    
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.3";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.733 -0.118 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.597 0.457 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.466 0.579 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.037 0.761 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.545 0.540 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.718 -0.314 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.016 -0.746 Random BreachSet_Small";  //not enough room
   breachLinks["Major", 2] = "-0.251 -0.697 Random BreachSet_Small"; //not enough room
   
   //egg
   embryoInfo[0] = "-0.398 0.408 4 ZombieEggBase";     
   
   hullTypeXPMult = 0.5; 
   comparativeCargo = -1;
   hullCargoSpace = 1000;
   
   threatMult = $ThreatMult_High;
   blossomRangeMult = 1.500;
};


datablock HullDatablock(HullBase_Dredge : HullStation) 
{   
   friendlyName = "Dredge Mining Base";
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_civ_dredgeImageMap";
   hullIconImageMap = "base_civ_dredge_iconImageMap";   
   
   GuiCollision = "-0.445 -0.948 0.377 -0.958 0.634 0.044 0.492 0.967 -0.351 0.938 -0.686 0.039";   
   CollisionPolyList = "-0.602 0.015 -0.398 -0.388 -0.010 -0.584 0.435 -0.427 0.592 -0.015 0.409 0.363 0.042 0.570 -0.409 0.358";
   MountedCollisionPolyList[0] = "-0.278 -0.874 0.000 -0.958 0.241 -0.751 0.435 0.692 0.236 0.859 -0.005 0.918 -0.220 0.717"; 
   LinkPoints = "0.005 -0.005 0.000 -0.683 0.010 0.678 -0.408 -0.368 -0.412 0.354 0.403 0.354 0.403 -0.373 -0.236 -0.840 0.236 0.879 -0.039 -0.864 0.044 -0.864 -0.034 0.854 0.059 0.854";
   
   rootDesign = "DredgeBase";
   
   comparativeHealth     = $MULT_HIGHEST; 
   comparativeCrew       = $MULT_HIGHEST;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
    
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "1 10 11 12 13";
   turretLinkPoints = "2 3 4 5 6 7 8 9";
   
   externalLinkType1  = $LINK_Drones; 
   externalLinkSize1  = $SLOT_LARGE;   
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_LARGE;  
   
   externalLinkType11  = $LINK_Utility; 
   externalLinkSize11  = $SLOT_LARGE;  
   
   externalLinkType12  = $LINK_Utility; 
   externalLinkSize12  = $SLOT_LARGE; 
   
   externalLinkType13  = $LINK_Utility; 
   externalLinkSize13  = $SLOT_LARGE; 
   
   hullTurretSize2 = $SLOT_HUGE;  
   hullTurretSize3 = $SLOT_HUGE;  
   hullTurretSize4 = $SLOT_LARGE; 
   hullTurretSize5 = $SLOT_LARGE; 
   hullTurretSize6 = $SLOT_LARGE; 
   hullTurretSize7 = $SLOT_LARGE; 
   hullTurretSize8 = $SLOT_SMALL; 
   hullTurretSize9 = $SLOT_SMALL; 
   
   wreckageData[0] = "ShipWreck_stationDoodad_Large 0 0 0";
   wreckageData[1] = "shipWreck_dredgeStation_01 0 0 0";
                  
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.513 -0.172 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "-0.545 -0.015 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "0.545 0.000 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.519 0.167 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_5 = "-0.314 0.791 0 0 1 DoodadSet_Terran_S_Radar"; 
   doodadLinkCiv_6 = "0.309 -0.742 0 0 1 DoodadSet_Terran_S_Radar";
   doodadLinkCiv_7 = "0 0 0 1 1 Doodad_StationSpinner_Large";     

   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.3";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.241 -0.737 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.257 0.481 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.230 -0.133 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.288 -0.049 Random BreachSet_Small";
   breachLinks["Minor", 5] = "-0.178 0.196 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.272 -0.088 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.005 -0.260 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.162 0.201 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0.262 -0.776 4 ZombieEggBase";    
   
   hullTypeXPMult = 1.0;     
   comparativeCargo = -1;
   hullCargoSpace = 2000;
      
   threatMult = $ThreatMult_VeryHigh;
   blossomRangeMult = 2.000;
};

//civ science

datablock HullDatablock(HullBase_Echo : HullStation) 
{  
   friendlyName = "Echo Science Base";
    
   size = "512 512";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_civ_echoImageMap";
   hullIconImageMap = "base_civ_echo_iconImageMap";   
      
   CollisionPolyList = "0.010 -0.943 0.618 -0.599 0.943 0.020 0.644 0.624 0.010 0.938 -0.581 0.629 -0.906 0.010 -0.608 -0.604";
   LinkPoints = "-0.807 0.010 0.843 0.015 0.010 -0.825 0.010 0.845 -0.581 -0.579 0.608 -0.584 0.618 0.609 -0.592 0.614 0.014 0.013";

   comparativeHealth     = $MULT_LOWEST;
   comparativeCrew       = $MULT_LOWEST;
   
   rootDesign = "EchoBase";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "1 2 3 4 5 6 7 8 9";
   
   externalLinkType1  = $LINK_Utility; 
   externalLinkSize1  = $SLOT_LARGE;   
   
   externalLinkType2  = $LINK_Utility; 
   externalLinkSize2  = $SLOT_LARGE; 
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE; 
   
   externalLinkType5  = $LINK_Launcher;
   externalLinkSize5  = $SLOT_SMALL;
   externalLinkMountRotation5 = -45;
     
   externalLinkType6  = $LINK_Launcher;
   externalLinkSize6  = $SLOT_SMALL; 
   externalLinkMountRotation6 = 45; 
   
   externalLinkType7  = $LINK_Launcher;
   externalLinkSize7  = $SLOT_SMALL; 
   externalLinkMountRotation7 = 135; 
   
   externalLinkType8  = $LINK_Launcher;
   externalLinkSize8  = $SLOT_SMALL; 
   externalLinkMountRotation8 = 225; 
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med02 0 0 0";     
   wreckageData[1] = "shipWreck_EchoStation_01 0 0 0";
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkCiv_1 = "-0.430 -0.442 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "0.492 0.471 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "0.487 -0.471 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "-0.461 0.481 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_5 = "-0.304 -0.319 0 0 1 DoodadSet_Civ_L_Lights";
   doodadLinkCiv_6 = "0.335 0.334 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_7 = "-0.503 0.015 0 0 0.9 DoodadSet_Terran_S_Radar";
   doodadLinkCiv_8 = "0 0 0 1 1 Doodad_StationSpinner_Med_02";    
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.3";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.424 -0.020 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.293 0.034 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.016 -0.412 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.382 0.010 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.005 0.432 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.183 0.280 Random BreachSet_Small";
   breachLinks["Minor", 7] = "0.299 0.201 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.241 0.226 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.230 -0.211 Random BreachSet_Huge";  
   
   //egg
   embryoInfo[0] = "0.576 -0.560 3 ZombieEggBase";  
   
   hullTypeXPMult = 0.25; 
   comparativeCargo = -1;
   hullCargoSpace = 500;
   
   threatMult = $ThreatMult_Normal;
   blossomRangeMult = 1.000;
};

datablock HullDatablock(HullBase_Quasar : HullStation) 
{   
   friendlyName = "Quasar Science Base";
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_civ_quasarImageMap";
   hullIconImageMap = "base_civ_quasar_iconImageMap";   
      
   GuiCollision = "-0.524 -0.943 0.534 -0.943 0.540 0.938 -0.513 0.943";  
   CollisionPolyList = "0.293 -0.840 0.351 -0.093 0.037 0.796 -0.299 -0.103 -0.230 -0.840";
   MountedCollisionPolyList[0] = "0.545 0.388 0.445 0.668 0.047 0.899 -0.377 0.683 -0.492 0.378 -0.293 0.147 0.304 0.162"; 
   MountedCollisionPolyList[1] = "-0.487 -0.334 -0.241 -0.791 0.309 -0.786 0.581 -0.319"; 
   MountedCollisionPolyList[2] = "-0.477 -0.869 0.519 -0.874 0.021 -0.383"; 
   
   LinkPoints = "-0.325 0.751 -0.052 0.501 0.152 0.403 0.236 0.550 0.456 0.471 0.026 -0.771 -0.233 0.067 -0.186 -0.013 -0.090 -0.027 0.186 -0.022 0.267 0.000 0.305 0.071";
   
   comparativeHealth     = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   
   rootDesign = "QuasarBase";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "1 2 3 4 5 6 7 8 9 10 11 12 13";

   externalLinkType1  = $LINK_Utility; 
   externalLinkSize1  = $SLOT_LARGE;  

   externalLinkType2  = $LINK_Utility; 
   externalLinkSize2  = $SLOT_LARGE;   
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE; 
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE;   
   
   externalLinkType6  = $LINK_Utility; 
   externalLinkSize6  = $SLOT_LARGE; 
   
   externalLinkType7  = $LINK_Launcher; 
   externalLinkSize7  = $SLOT_MEDIUM; 
   
   externalLinkType8  = $LINK_Launcher;
   externalLinkSize8  = $SLOT_MEDIUM; 
   
   externalLinkType9  = $LINK_Launcher;
   externalLinkSize9  = $SLOT_MEDIUM; 
   
   externalLinkType10  = $LINK_Launcher;
   externalLinkSize10  = $SLOT_MEDIUM; 
   
   externalLinkType11  = $LINK_Launcher;
   externalLinkSize11  = $SLOT_MEDIUM; 
   
   externalLinkType12  = $LINK_Launcher;
   externalLinkSize12  = $SLOT_MEDIUM; 
   
   externalLinkType13  = $LINK_Launcher;
   externalLinkSize13  = $SLOT_MEDIUM; 
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med 0 0 0";
   wreckageData[1] = "shipWreck_quasarStation_01 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.183 -0.825 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "0.251 -0.835 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "-0.283 -0.079 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.340 -0.088 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_5 = "-0.283 -0.319 0 0 0.9 DoodadSet_Terran_S_Radar"; 
   doodadLinkCiv_6 = "0.335 -0.643 0 0 0.9 DoodadSet_Terran_S_Radar";
   doodadLinkCiv_7 = "0.037 -0.074 0 1 1 Doodad_StationSpinner_Med";    
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.3";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.063 -0.481 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.141 -0.506 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.403 -0.393 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.409 0.629 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.340 0.712 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.005 0.378 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "0.063 0.604 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.047 0.751 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "-0.058 -0.005 4 ZombieEggBase";   
   
   hullTypeXPMult = 0.5; 
   comparativeCargo = -1;
   hullCargoSpace = 1000;
   
   threatMult = $ThreatMult_High;
   blossomRangeMult = 1.500;
};

datablock HullDatablock(HullBase_Pulsar : HullStation) 
{   
   friendlyName = "Pulsar Science Base";   
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_civ_pulsarImageMap";
   hullIconImageMap = "base_civ_pulsar_iconImageMap";   
      
   CollisionPolyList = "-0.005 -0.815 0.602 -0.511 0.812 -0.010 0.576 0.565 -0.005 0.820 -0.571 0.589 -0.817 -0.005 -0.576 -0.550";
   LinkPoints = "0.000 0.005 -0.681 0.088 -0.681 -0.074 -0.086 -0.674 0.084 -0.673 0.681 -0.071 0.686 0.085 0.086 0.683 -0.086 0.688 -0.805 0.000 0.005 -0.795 0.800 0.009 0.000 0.808 -0.267 0.295 -0.286 -0.263 0.281 -0.268 0.286 0.263";
   
   comparativeHealth     = $MULT_HIGHEST;
   comparativeCrew       = $MULT_HIGHEST;
   
   rootDesign = "PulsarBase";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17";
   
   externalLinkType1  = $LINK_Utility; 
   externalLinkSize1  = $SLOT_LARGE;      
   
   externalLinkType2  = $LINK_Utility; 
   externalLinkSize2  = $SLOT_LARGE;   
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE; 
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE; 
   
   externalLinkType6  = $LINK_Utility; 
   externalLinkSize6  = $SLOT_LARGE;   
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_LARGE; 
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_LARGE; 
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_LARGE;
   
   externalLinkType10  = $LINK_Launcher;
   externalLinkSize10  = $SLOT_LARGE;
   externalLinkMountRotation10 = -90;   
   
   externalLinkType11  = $LINK_Launcher;
   externalLinkSize11  = $SLOT_LARGE;
   
   externalLinkType12  = $LINK_Launcher;
   externalLinkSize12  = $SLOT_LARGE;
   externalLinkMountRotation12 = 90;  
   
   externalLinkType13  = $LINK_Launcher;
   externalLinkSize13  = $SLOT_LARGE;
   externalLinkMountRotation13 = 180;   
   
   externalLinkType14  = $LINK_Launcher;
   externalLinkSize14  = $SLOT_MEDIUM;
   externalLinkMountRotation14 = 225;  
   
   externalLinkType15  = $LINK_Launcher;
   externalLinkSize15  = $SLOT_MEDIUM;
   externalLinkMountRotation15 = -45;  
   
   externalLinkType16  = $LINK_Launcher;
   externalLinkSize16  = $SLOT_MEDIUM; 
   externalLinkMountRotation16 = 45; 
   
   externalLinkType17  = $LINK_Launcher;
   externalLinkSize17  = $SLOT_MEDIUM; 
   externalLinkMountRotation17 = 135;
   
   wreckageData[0] = "ShipWreck_stationDoodad_Large 0 0 0";
   wreckageData[1] = "ShipWreck_stationDoodad_Med 0 0 0";     
   wreckageData[2] = "shipWreck_pulsarStation_01 0 0 0";    
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "0.000 -0.393 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "-0.393 0.010 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "0.000 0.388 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.377 0.015 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_5 = "-0.760 -0.079 0 0 0.9 DoodadSet_Terran_S_Radar"; 
   doodadLinkCiv_6 = "0.765 0.083 0 0 0.9 DoodadSet_Terran_S_Radar";
   doodadLinkCiv_7 = "0 0 0 1 1 Doodad_StationSpinner_Med";
   doodadLinkCiv_8 = "0 0 0 1 1 Doodad_StationSpinner_Large";        
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.529 -0.535 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.100 -0.742 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.456 -0.575 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.739 -0.108 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.503 0.540 Random BreachSet_Small";
   breachLinks["Minor", 6] = "-0.466 0.604 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.728 0.167 Random BreachSet_Small"; //not enough room
   
   //egg
   embryoInfo[0] = "0.414 -0.029 4 ZombieEggBase"; 
   
   hullTypeXPMult = 1.0; 
   comparativeCargo = -1;
   hullCargoSpace = 2000;
   
   threatMult = $ThreatMult_VeryHigh;
   blossomRangeMult = 2.000;
};

//civ colony

datablock HullDatablock(HullBase_Sanctuary : HullStation) 
{   
   friendlyName = "Sanctuary Colony Base";
   
   size = "512 512";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_civ_sanctuaryImageMap";
   hullIconImageMap = "base_civ_sanctuary_iconImageMap";   
      
   GuiCollision = "-0.566 -0.874 0.597 -0.904 0.592 0.943 -0.576 0.938";    
   CollisionPolyList = "-0.492 -0.152 0.005 -0.688 0.524 -0.138 0.513 0.172 0.016 0.751 -0.508 0.172";
   MountedCollisionPolyList[0] = "-0.393 -0.722 0.005 -0.850 0.435 -0.717 0.251 -0.530 -0.215 -0.530"; //top wedge 
   MountedCollisionPolyList[1] = "0.414 0.771 0.005 0.884 -0.409 0.791 -0.225 0.579 0.230 0.589"; //bottom wedge
   
   LinkPoints = "0.010 0.020 -0.005 -0.152 0.005 0.187";

   comparativeHealth     = $MULT_LOWEST;
   comparativeCrew       = $MULT_LOWEST; 
   
   rootDesign = "SanctuaryBase";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "1 2 3";
   
   externalLinkType1  = $LINK_Drones; 
   externalLinkSize1  = $SLOT_LARGE;   
   
   externalLinkType2  = $LINK_Utility; 
   externalLinkSize2  = $SLOT_LARGE; 
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med 0 0 0";  
   wreckageData[1] = "shipWreck_sanctuaryStation_01 0 0 0";  
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.189 -0.177 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "0.199 0.206 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "0.199 -0.187 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "-0.173 0.192 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_5 = "0.005 -0.702 0 0 1 DoodadSet_Terran_S_Radar"; 
   doodadLinkCiv_6 = "0.010 0.742 0 0 1 DoodadSet_Terran_S_Radar";   
   doodadLinkCiv_7 = "0.010 0.020 0 1 1 Doodad_StationSpinner_Med"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.367 -0.226 Random BreachSet_Small_Glass";
   breachLinks["Minor", 2] = "0.382 0.265 Random BreachSet_Small_Glass";
   breachLinks["Minor", 3] = "-0.225 -0.702 Random BreachSet_Small_Glass";
   breachLinks["Minor", 4] = "-0.120 -0.653 Random BreachSet_Small_Glass";
   breachLinks["Minor", 5] = "0.094 -0.692 Random BreachSet_Small_Glass";
   
   breachLinks["Major", 1] = "-0.016 0.746 Random BreachSet_Huge_Glass";
   
   //egg
   embryoInfo[0] = "0.199 -0.491 3 ZombieEggBase";   
   
   hullTypeXPMult = 0.25; 
   comparativeCargo = -1;
   hullCargoSpace = 500;
   
   threatMult = $ThreatMult_Normal;
   blossomRangeMult = 1.000;
};

datablock HullDatablock(HullBase_Oasis : HullStation) 
{   
   friendlyName = "Oasis Colony Base";   
   
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_civ_oasisImageMap"; 
   hullIconImageMap = "base_civ_oasis_iconImageMap";   
      
   CollisionPolyList = "-0.005 -0.967 0.728 -0.619 0.953 0.000 0.712 0.629 0.000 0.948 -0.686 0.619 -0.948 0.000 -0.702 -0.648";
   LinkPoints = "0.016 0.000 0.393 -0.742 -0.382 0.746 -0.728 -0.383 0.765 0.358 0.010 -0.167 0.016 0.162";
   
   comparativeHealth     = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   
   rootDesign = "OasisBase";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "2 3 4 5 6 7";
   
   externalLinkType2  = $LINK_Utility; 
   externalLinkSize2  = $SLOT_LARGE;   
   
   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE; 
   
   externalLinkType5  = $LINK_Utility; 
   externalLinkSize5  = $SLOT_LARGE; 
   
   externalLinkType6  = $LINK_Drones; 
   externalLinkSize6  = $SLOT_LARGE; 
   
   externalLinkType7  = $LINK_Drones; 
   externalLinkSize7  = $SLOT_LARGE; 
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med02 0 0 0";   
   wreckageData[1] = "shipWreck_OasisStation_01 0 0 0";
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.299 0.309 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "0.005 0.447 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "0.340 0.319 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.010 -0.442 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_5 = "-0.293 -0.025 0 0 0.9 DoodadSet_Terran_S_Radar"; 
   doodadLinkCiv_6 = "0.304 0.020 0 0 0.9 DoodadSet_Terran_S_Radar"; 
   doodadLinkCiv_7 = "0.016 0.0 0 1 1 Doodad_StationSpinner_Med_02";
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7 0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.592 -0.594 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.094 0.142 Random BreachSet_Small_Glass";
   breachLinks["Minor", 3] = "-0.644 0.525 Random BreachSet_Small_Glass";
   breachLinks["Minor", 4] = "-0.094 0.835 Random BreachSet_Small_Glass";
   breachLinks["Minor", 5] = "0.450 0.712 Random BreachSet_Small_Glass";
   
   breachLinks["Major", 1] = "0.639 0.550 Random BreachSet_Small_Glass";
   breachLinks["Major", 2] = "-0.634 0.216 Random BreachSet_Small_Glass";
   breachLinks["Major", 3] = "0.168 -0.069 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "-0.304 -0.309 4 ZombieEggBase";   
   
   hullTypeXPMult = 0.5;  
   comparativeCargo = -1;
   hullCargoSpace = 1000;  
   
   threatMult = $ThreatMult_High;     
   blossomRangeMult = 1.500;  
};

datablock HullDatablock(HullBase_FiveStar : HullStation) 
{  
   friendlyName = "Four Star Colony Base";
    
   size = "768 768";   
   imageMapShield = "base_circle_shieldImageMap";
   
   factionImageMap_Default = "base_civ_fiveStarImageMap";
   hullIconImageMap = "base_civ_fiveStar_iconImageMap";    
      
   GuiCollision = "-0.969 -0.083 0.042 -1.000 1.000 0.000 0.026 1.000";  
   CollisionPolyList = "0.026 -0.633 0.471 -0.427 0.650 0.015 0.503 0.393 0.010 0.629 -0.466 0.408 -0.602 -0.005 -0.440 -0.471";
   MountedCollisionPolyList[0] = "0.016 -0.972 0.147 -0.904 0.147 0.899 0.016 0.962 -0.110 0.894 -0.110 -0.904"; 
   MountedCollisionPolyList[1] = "-0.875 0.133 -0.948 0.000 -0.870 -0.128 0.917 -0.123 0.980 0.000 0.932 0.128"; 
   
   LinkPoints = "0.016 0.005 -0.162 0.005 0.194 0.005 0.016 -0.177 0.010 0.187 -0.896 0.005 0.016 -0.913 0.927 0.005 0.005 0.908 -0.257 0.005 0.016 -0.275 0.299 0.000 0.016 0.285";
   
   comparativeHealth     = $MULT_HIGHEST;
   comparativeCrew       = $MULT_HIGHEST;
   
   rootDesign = "FiveStarBase";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "2 3 4 5 6 7 8 9 10 11 12 13";
   
   externalLinkType2  = $LINK_Drones; 
   externalLinkSize2  = $SLOT_LARGE;   
   
   externalLinkType3  = $LINK_Drones; 
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Drones; 
   externalLinkSize4  = $SLOT_LARGE; 
   
   externalLinkType5  = $LINK_Drones; 
   externalLinkSize5  = $SLOT_LARGE; 
      
   externalLinkType6  = $LINK_Utility; 
   externalLinkSize6  = $SLOT_LARGE;   
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_LARGE; 
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_LARGE; 
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_LARGE; 
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_LARGE;   
   
   externalLinkType11  = $LINK_Utility; 
   externalLinkSize11  = $SLOT_LARGE; 
   
   externalLinkType12  = $LINK_Utility; 
   externalLinkSize12  = $SLOT_LARGE; 
   
   externalLinkType13  = $LINK_Utility; 
   externalLinkSize13  = $SLOT_LARGE;   
   
   wreckageData[0] = "ShipWreck_stationDoodad_Med 0 0 0";   
   wreckageData[1] = "shipWreck_fiveStarStation_01 0 0 0"; 
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.880 -0.123 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "-0.875 0.118 0 0 1 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_3 = "-0.110 -0.899 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.157 -0.904 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_5 = "0.917 -0.113 0 0 0.9 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_6 = "0.927 0.118 0 0 0.9 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_7 = "-0.105 0.899 0 0 0.9 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_8 = "0.141 0.899 0 0 0.9 DoodadSet_Civ_L_Lights"; 
   doodadLinkCiv_9 = "0.016 0.010 0 1 1 Doodad_StationSpinner_Med";
   doodadLinkCiv_10 = "0.016 0.010 0 1 1 Doodad_StationSpinner_Small";
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.5 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.712 0.000 Random BreachSet_Small_Glass";
   breachLinks["Minor", 2] = "-0.435 0.000 Random BreachSet_Small_Glass";
   breachLinks["Minor", 3] = "0.498 0.015 Random BreachSet_Small_Glass";
   breachLinks["Minor", 4] = "0.236 0.358 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.262 -0.412 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.424 -0.241 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.220 -0.393 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.215 0.403 Random BreachSet_Huge"; 
   
   //egg
   embryoInfo[0] = "-0.267 -0.290 4 ZombieEggBase"; 
   
   hullTypeXPMult = 1.0;  
   comparativeCargo = -1;
   hullCargoSpace = 2000;
   
   threatMult = $ThreatMult_VeryHigh; 
   blossomRangeMult = 2.000;        
};

//car lot

datablock HullDatablock(HullCarLot : HullStation) 
{   
   friendlyName = "Used Car Lot";
   
   size = "256 256";   
   imageMapShield = "base_circle_shieldImageMap";
   
   explosionDatablock    = "BigExplosion";  
   explosionSound        = "snd_bigExplosion"; 
   
   factionImageMap_Default = "base_civ_carlotImageMap"; 
   factionImageMap_Civ = "base_civ_carlotImageMap"; 
   
   hullIconImageMap = "base_civ_carlot_iconImageMap";      
         
   CollisionPolyList = "-0.623 -0.594 0.225 -0.697 0.760 -0.029 0.089 0.643 -0.597 0.486";
   LinkPoints = "0.000 0.010 0.440 -0.584";
   
   maxComponentHealth    = 100; 
   comparativeHealth     = -1;
   maxCrewSize = 10; 
   comparativeCrew       = -1;
   
   rootDesign = "CarLotBase";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "2";
   
   externalLinkType2  = $LINK_Utility; 
   externalLinkSize2  = $SLOT_LARGE;  
    
   wreckageData[0] = "ShipWreck_stationDoodad_Small 0 0 0";   
   wreckageData[1] = "shipWreck_carlotStation_01 0 0 0"; 
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.618 -0.015 0 0 1 DoodadSet_Civ_S_Lights";   
   doodadLinkCiv_2 = "0.618 -0.059 0 0 1 DoodadSet_Civ_S_Lights";
   doodadLinkCiv_3 = "0.016 0.575 0 1 1 DoodadSet_Civ_S_Lights";
   doodadLinkCiv_4 = "0 0 0 1 1 Doodad_StationSpinner_Small";
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.5 0.4";
   breachThresholds["Major"] = "0.9 0.7";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.304 -0.152 Random BreachSet_Small_Glass";
   breachLinks["Minor", 2] = "0.278 0.128 Random BreachSet_Small_Glass";
   breachLinks["Minor", 3] = "-0.430 -0.034 Random BreachSet_Small_Glass";
   
   breachLinks["Major", 1] = "-0.100 -0.295 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.100 0.167 Random BreachSet_Huge";

   //egg
   embryoInfo[0] = "0.246 -0.290 1 ZombieEggBase";  
   
   hullTypeXPMult = 0.05;
   threatMult = 0;
   comparativeCargo = -1;
   hullCargoSpace = 100;
   blossomRangeMult = 0.500;
};

//zombie

datablock HullDatablock(Hull_zombie_eye : HullStation_zombie) 
{   
   friendlyName = "Eye";
   
   size = "128 128";   
   imageMapShield = "station_zombie_eye_shieldImageMap";
   embryoImage = "eye_embryoImageMap";
   
   explosionDatablock    = "BigExplosion_zombie";  
   explosionSound        = "snd_bigExplosion"; 
   
   hasWhiteFlash = false; //not massive
   hasShockwave = false;
   
   rootDesign = "EyeZombieStation";
   
   factionImageMap_Default = "station_zombie_eyeImageMap"; 
   
   hullIconImageMap = "station_zombie_eye_iconImageMap";      
         
   CollisionPolyList = "-0.508 -0.447 -0.021 -0.692 0.471 -0.481 0.644 0.005 0.545 0.432 0.000 0.697 -0.513 0.442 -0.707 -0.015";
   LinkPoints = "0.010 0.000";
   
   maxComponentHealth    = 350; 
   comparativeHealth     = -1;
   
   comparativeCrew       = $MULT_LOWEST;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   turretLinkPoints = "1";

   hullTurretSize1 = $SLOT_LARGE; 
      
   hullDescriptionBits = $SST_HULL_ZOMBIE; 
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkZombie_1 = "0.005 -0.452 0 0 1 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "0.000 0.442 0 0 1 DoodadSet_Zombie_S_Node";
   
   //egg
   embryoInfo[0] = "-0.20 0 1 ZombieEggBase";  
   
   threatMult = $ThreatMult_VeryLow;  
   
   hullTypeXPMult = 0.1;
   comparativeCargo = -1;
   hullCargoSpace = 100;
   blossomRangeMult = 0.300;
};

datablock HullDatablock(HullBase_zombie_Outpost : HullStation_zombie) 
{   
   friendlyName = "Infected Outpost";
   
   size = "256 256";   
   imageMapShield = "base_zombie_outpost_shieldImageMap";
   
   explosionDatablock    = "BigExplosion_zombie";  
   explosionSound        = "snd_bigExplosion"; 
   
   factionImageMap_Default = "base_zombie_outpostImageMap"; 
   hullIconImageMap = "base_zombie_outpost_iconImageMap"; 
   
   hasWhiteFlash = false;
   hasShockwave = false;  
   
   rootDesign = "OutpostBase_zombie";
    
   GuiCollision = "-0.948 -0.020 0.026 -1.000 0.948 -0.015 0.000 0.982";         
   CollisionPolyList = "-0.346 -0.334 0.000 -0.471 0.351 -0.270 0.450 0.000 0.320 0.309 -0.016 0.476 -0.325 0.329 -0.519 0.005";
   MountedCollisionPolyList[0] = "-0.126 -0.859 0.136 -0.859 0.131 0.850 -0.126 0.845"; 
   MountedCollisionPolyList[1] = "-0.849 -0.128 0.833 -0.113 0.843 0.123 -0.859 0.118"; 
   LinkPoints = "0.005 0.005 -0.760 0.010 -0.010 -0.746 0.749 0.010 -0.010 0.761";
   
   maxComponentHealth    = 750;    
   comparativeHealth     = -1;
   
   comparativeCrew       = $MULT_LOWEST;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   hullDescriptionBits = $SST_HULL_ZOMBIE; 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "2 4";
   turretLinkPoints = "3 5";
   
   externalLinkType2  = $LINK_Shooter; 
   externalLinkSize2  = $SLOT_LARGE;   
   
   externalLinkType4  = $LINK_Launcher; 
   externalLinkSize4  = $SLOT_LARGE;  
   
   hullTurretSize3 = $SLOT_LARGE;  
   hullTurretSize5 = $SLOT_LARGE; 
      

   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkZombie_1 = "-0.314 -0.295 0 0 0.8 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "0.304 -0.295 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "0.304 0.304 0 0 0.8 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_4 = "-0.309 0.324 0 0 0.8 DoodadSet_Zombie_S_Node";  
   //doodadLinkZombie_5 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Large";
   
   //egg
   embryoInfo[0] = "-0.1 0.2 2 ZombieEggBase";    
   
   threatMult = $ThreatMult_Low;
   hullTypeXPMult = 0.25;
   comparativeCargo = -1;
   hullCargoSpace = 250;
   blossomRangeMult = 0.500;
};

datablock HullDatablock(Hull_zombie_heart : HullStation_zombie) 
{   
   friendlyName = "Heart";
   
   size = "512 512";  //Motherships are no bigger than this. 
   imageMapShield = "station_zombie_heart_shieldImagemap";
   
   factionImageMap_Default = "station_zombie_heartImagemap";
   hullIconImageMap = "station_zombie_heart_iconImageMap";    
   
   comparativeHealth     = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   
   rootDesign = "HeartZombieStation";
     
   GuiCollision = "-0.660 -0.854 -0.058 -0.923 0.765 -0.363 0.608 0.668 -0.194 0.884 -0.780 0.064";      
   CollisionPolyList = "-0.183 -0.805 0.435 -0.005 0.330 0.525 -0.110 0.712 -0.592 0.157 -0.487 -0.344";
   MountedCollisionPolyList[0] = "0.723 -0.196 0.356 0.103 0.037 -0.339 0.361 -0.638"; 
   LinkPoints = "-0.005 0.005 0.461 0.015 0.356 -0.584 -0.105 0.668";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
   
   hullDescriptionBits = $SST_HULL_ZOMBIE; 
   
   turretLinkPoints = "2 3 4";

   hullTurretSize2 = $SLOT_LARGE; 
   hullTurretSize3 = $SLOT_LARGE;  
   hullTurretSize4 = $SLOT_LARGE;   
   
   wreckageData[0] = "ShipWreck_zombie_heart 0 0 0"; 
   wreckageData[1] = "ShipWreck_zombie_generic_01 0 0 0"; 
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkZombie_1 = "-0.199 -0.746 0 0 0.8 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "-0.194 -0.491 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "-0.540 -0.010 0 0 0.8 DoodadSet_Zombie_S_Node";
   doodadLinkZombie_4 = "0.063 0.575 0 0 0.8 DoodadSet_Zombie_S_Node";
   //doodadLinkZombie_5 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Huge";
   
   //egg
   embryoInfo[0] = "-0.524 -0.383 3 ZombieEggBase";
   embryoInfo[1] = "0.168 -0.344 2 ZombieEggBase";  
   embryoInfo[2] = "0.492 -0.059 1 ZombieEggBase";
   embryoInfo[3] = "0.351 0.688 1 ZombieEggBase";    
   
   threatMult = $ThreatMult_Normal;  
   hullTypeXPMult = 0.5;
   comparativeCargo = -1;
   hullCargoSpace = 500;
   blossomRangeMult = 1.000;
};

datablock HullDatablock(Hull_zombie_artery : HullStation_zombie) 
{   
   friendlyName = "Artery";
   
   size = "768 768";  //Motherships are no bigger than this. 
   imageMapShield = "station_zombie_artery_shieldImagemap";
   
   factionImageMap_Default = "station_zombie_arteryImagemap"; 
   hullIconImageMap = "station_zombie_artery_iconImageMap";   
   
   comparativeHealth     = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   
   rootDesign = "ArteryZombieStation"; 
      
   CollisionPolyList = "-0.293 -0.894 0.210 -0.904 0.534 -0.182 0.278 0.904 -0.278 0.889 -0.503 -0.314";
   LinkPoints = "-0.005 0.000 -0.393 -0.501 -0.052 0.481 0.257 -0.157";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
  
   hullDescriptionBits = $SST_HULL_ZOMBIE; 

   turretLinkPoints = "1 2 3 4";

   hullTurretSize1 = $SLOT_LARGE; 
   hullTurretSize2 = $SLOT_LARGE; 
   hullTurretSize3 = $SLOT_LARGE;  
   hullTurretSize4 = $SLOT_LARGE;  

   wreckageData[0] = "ShipWreck_zombie_artery 0 0 0"; 
   wreckageData[1] = "ShipWreck_zombie_generic_01 0 0 0"; 
   wreckageData[2] = "ShipWreck_zombie_generic_02 0 0 0"; 
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkZombie_1 = "-0.335 0.516 0 0 0.8 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "-0.534 -0.255 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "0.173 -0.732 0 0 0.8 DoodadSet_Zombie_S_Node";
   doodadLinkZombie_4 = "0.430 -0.029 0 0 0.8 DoodadSet_Zombie_S_Node";
   //doodadLinkZombie_5 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Huge"; 
   
   //egg
   embryoInfo[0] = "0.120 -0.383 3 ZombieEggBase";
   embryoInfo[1] = "-0.377 0.398 2 ZombieEggBase";  
   embryoInfo[2] = "0.288 0.805 1 ZombieEggBase";
   embryoInfo[3] = "-0.409 -0.521 1 ZombieEggBase";  
   
   threatMult = $ThreatMult_High;  
   hullTypeXPMult = 1;
   comparativeCargo = -1;
   hullCargoSpace = 1000; 
   blossomRangeMult = 1.500;  
};

datablock HullDatablock(Hull_zombie_hive : HullStation_zombie) 
{   
   friendlyName = "Hive";
   
   size = "768 768";  //Motherships are no bigger than this. 
   imageMapShield = "station_zombie_hive_shieldImagemap";
   
   factionImageMap_Default = "station_zombie_hiveImagemap";
   hullIconImageMap = "station_zombie_hive_iconImageMap";    
   
   comparativeHealth     = $MULT_VERYHIGH; //waa highest, but gets kind of slow to kill
   comparativeCrew       = $MULT_HIGH;
   
   hullDescriptionBits = $SST_HULL_ZOMBIE; 
   
   rootDesign = "HiveZombieStation"; 
    
   GuiCollision = "-0.414 -0.967 0.576 -0.938 0.833 0.771 -0.953 0.953 -0.702 -0.147";     
   CollisionPolyList = "-0.325 -0.889 -0.126 -0.913 0.021 -0.766 0.052 0.516 -0.676 0.943 -0.796 0.943 -0.854 0.835";
   MountedCollisionPolyList[0] = "-0.220 0.575 -0.225 -0.550 0.021 -0.805 0.293 -0.938 0.540 -0.501 0.618 -0.285 0.681 0.054 0.655 0.378 0.545 0.688 0.246 0.746";
   LinkPoints = "0.000 0.005 0.183 0.329 0.037 -0.648 -0.424 0.594 0.267 0.511";
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
   

   turretLinkPoints = "2 3 4 5";

   hullTurretSize2 = $SLOT_HUGE; 
   hullTurretSize3 = $SLOT_LARGE; 
   hullTurretSize4 = $SLOT_LARGE;  
   hullTurretSize5 = $SLOT_LARGE;     


   wreckageData[0] = "ShipWreck_zombie_hive 0 0 0"; 
   wreckageData[1] = "ShipWreck_zombie_generic_01 0 0 0"; 
   wreckageData[2] = "ShipWreck_zombie_generic_02 0 0 0"; 
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
     
   //doodadLinkZombie_1 = "0 0 0 1 1 Doodad_HiveHeart"; 
   //doodadLinkZombie_2 = "0.1 -0.4 0 1 1 Doodad_HiveHeart"; 
   //doodadLinkZombie_5 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Huge";
   
   //egg
   embryoInfo[0] = "0.398 0.422 4 ZombieEggBase";   
   embryoInfo[1] = "-0.058 -0.751 3 ZombieEggBase";  
   embryoInfo[2] = "0.450 -0.530 2 ZombieEggBase";  
   embryoInfo[3] = "-0.524 -0.034 1 ZombieEggBase";  
   
   threatMult = $ThreatMult_VeryHigh;
   
   hullTypeXPMult = 2;
   comparativeCargo = -1;
   hullCargoSpace = 2000;
   blossomRangeMult = 2.000;
};

////////////////////////////////////////////////////////////////////////////////
//BOUNTY BASE 03
////////////////////////////////////////////////////////////////////////////////

datablock HullDatablock(HullBase_Bounty03 : HullStation) 
{   
   friendlyName = "Bounty Hunter Base";  
   
   rotationRate = 2;
   
   rootDesign = "Bounty03Base_Basic";
   
   size = "768 768";   
   imageMapShield = "base_bounty_03_shieldImageMap";
   
   factionImageMap_Bounty  = "base_bounty_03ImageMap";
   factionImageMap_Default = "base_bounty_03ImageMap";
   hullIconImageMap = "base_bounty_03_iconImageMap";     

   CollisionPolyList = "-0.754 -0.054 -0.010 -0.187 0.775 -0.044 0.780 0.044 -0.016 0.216 -0.754 0.054";
   GuiCollision = "0.010 -0.884 0.765 0.010 -0.010 0.820 -0.723 -0.025";  
   MountedCollisionPolyList[0] = "-0.236 -0.805 0.241 -0.810 0.367 -0.550 -0.005 -0.074 -0.351 -0.525"; 
   MountedCollisionPolyList[1] = "-0.194 0.810 -0.351 0.506 0.016 0.015 0.351 0.530 0.241 0.805"; 
   LinkPoints = "-0.005 0.000 -0.157 -0.648 0.136 -0.648 -0.157 0.653 0.136 0.648 -0.419 0.005 0.398 0.010 -0.545 -0.029 0.534 -0.025 -0.073 -0.786 0.058 -0.786 -0.073 0.776 0.068 0.776 -0.545 0.034 0.534 0.025";
   
   comparativeHealth     = $MULT_HIGHEST;
   comparativeCrew       = $MULT_HIGHEST;
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   externalLinkPoints = "1 8 9 10 11 12 13 14 15";
   turretLinkPoints = "2 3 4 5 6 7";
   
   hullTurretSize2 = $SLOT_HUGE;  
   hullTurretSize3 = $SLOT_HUGE;  
   hullTurretSize4 = $SLOT_HUGE;  
   hullTurretSize5 = $SLOT_HUGE;
   hullTurretSize6 = $SLOT_HUGE; 
   hullTurretSize7 = $SLOT_HUGE;
   
   externalLinkType1  = $LINK_Drones; 
   externalLinkSize1  = $SLOT_LARGE;   
   
   externalLinkType8  = $LINK_Launcher; 
   externalLinkSize8  = $SLOT_HUGE; 
   externalLinkMountRotation8 = -90;    
   
   externalLinkType9  = $LINK_Launcher; 
   externalLinkSize9  = $SLOT_HUGE;  
   externalLinkMountRotation9 = 90; 
   
   externalLinkType14  = $LINK_Launcher; 
   externalLinkSize14  = $SLOT_HUGE; 
   externalLinkMountRotation14 = -90;    
   
   externalLinkType15  = $LINK_Launcher; 
   externalLinkSize15  = $SLOT_HUGE;  
   externalLinkMountRotation15 = 90;   
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_HUGE;  
   
   externalLinkType11  = $LINK_Utility; 
   externalLinkSize11  = $SLOT_HUGE;  
   
   externalLinkType12  = $LINK_Utility; 
   externalLinkSize12  = $SLOT_HUGE; 
   
   externalLinkType13  = $LINK_Utility; 
   externalLinkSize13  = $SLOT_HUGE; 
   
   wreckageData[0] = "ShipWreck_bountyStation_03 0 0 0";
   wreckageData[1] = "ShipWreck_stationDoodad_Med 0 0 0";
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN 
   doodadLinkBounty_1 = "-0.367 -0.604 0 0 1 DoodadSet_Bounty_L_Lights"; 
   doodadLinkBounty_2 = "0.367 -0.604 0 0 1 DoodadSet_Bounty_L_Lights";   
   doodadLinkBounty_3 = "-0.367 0.589 0 0 1 DoodadSet_Bounty_L_Lights";   
   doodadLinkBounty_4 = "0.356 0.589 0 0 1 DoodadSet_Bounty_L_Lights"; 
   doodadLinkBounty_5 = "-0.089 0.285 0 0 1 DoodadSet_Terran_S_Radar";  
   doodadLinkBounty_6 = "0.073 -0.285 0 0 1 DoodadSet_Terran_S_Radar";
   doodadLinkBounty_7 = "-0.005 0.000 0 1 1 Doodad_StationSpinner_Med"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.272 -0.535 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.084 -0.467 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.288 0.521 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.110 0.476 Random BreachSet_Small";
   breachLinks["Minor", 5] = "-0.089 0.285 Random BreachSet_Small";
   breachLinks["Minor", 6] = "-0.178 -0.103 Random BreachSet_Small";
   breachLinks["Minor", 7] = "0.492 -0.044 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "0.120 0.462 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.094 -0.005 Random BreachSet_Huge"; 
   
   //egg
   embryoInfo[0] = "0.1 -0.1 4 ZombieEggBase"; 
   
   hullTypeXPMult = 2.0;
   comparativeCargo = -1;
   hullCargoSpace = 2000;
   
   threatMult = $ThreatMult_VeryHigh;
   blossomRangeMult = 2.000;
};

