

///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// MOTHERSHIP HULLS /////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////



//Base for all medium hulls
datablock HullDatablock(HullMothership : HullBase)
{        
  
   
   size = "1024 1024";  //Motherships are no bigger than this. 
   
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   componentSize         = $SLOT_MOTHERSHIP; 

   hullTurnSpeedMod      = $MULT_AVERAGE;  
   hullType              = $HULLTYPE_MOTHERSHIP;   
   
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
   
   
   beaconDatablock       = "BeaconBase_01";
   miniHudIcon = "ShipDisplay_hull_motherImageMap";
   
   debrisCluster_Light = "DC_Combat_Huge_Light";  
   debrisCluster_Heavy = "DC_Combat_Huge_Heavy"; 
   
   subExplosionDatablockWL  = "BigExplosion 5 MediumExplosion 50 MediumExplosion_Debris 1";  
   subExplosionScale        = 0.7; 
   
   hasWhiteFlash = true;
   hasShockwave = true;
   canBeInvaded = false;
   commandPoints = 0;
};

datablock HullDatablock(HullMothership_zombie : HullMothership)
{        
   explosionDatablock    = "HugeExplosion_zombie";  
   explosionSound        = "snd_hugeExplosion_zombie";
   hullHitEffect         = "hullImpact_zombie";
   hullHitSound          = "snd_hullHit_zombie";    
   
   debrisCluster_Light = "DC_Combat_Huge_Light_Zombie";  
   debrisCluster_Heavy = "DC_Combat_Huge_Heavy_Zombie";  
   hullDamageModifier_Explosive   = "1";  //so explosions do not nuke zombies.

   subExplosionDatablockWL  = "BigExplosion_zombie 10 MediumExplosion_zombie 20";  
};


datablock HullDatablock(HullDyson_01 : HullMothership) 
{   
   friendlyName = "UTA Mothership";
   size = "512 512";  //Motherships are no bigger than this. 
   imageMapShield = "station_dyson_01_shieldImageMap";
   
   factionImageMap_Default = "station_dyson_01ImageMap"; 
   factionImageMap_Terran = "station_dyson_01ImageMap"; 
   factionImageMap_Pirate = "station_dyson_pirate_01ImageMap"; 
   
   hullIconImageMap = "station_dyson_01_iconImageMap";   
   
   rootDesign = "DysonStation_01";
      
   CollisionPolyList = "-0.005 -0.997 0.692 -0.678 1.000 0.049 0.943 0.977 -0.918 0.967 -0.982 0.054 -0.751 -0.594";
   LinkPoints = "0.000 0.010 -0.766 0.943 0.786 0.958 -0.933 0.010 0.938 0.010 0.005 -0.948 -0.746 0.521 -0.746 0.668 0.761 0.521 0.761 0.668 -0.437 -0.643 0.437 -0.638 0.010 0.702 0.015 -0.633";
   
   comparativeHealth     = $MULT_LOWEST;
      
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9 10";
   turretLinkPoints = "11 12 13 14";
   
   externalLinkType6  = $LINK_Shooter; //This is the BIG one
   externalLinkSize6  = $SLOT_MOTHERSHIP;   
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_HUGE;  
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_HUGE;     
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_HUGE;  
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_HUGE;    
      
   hullTurretSize11 = $SLOT_MEDIUM;  
   hullTurretSize12 = $SLOT_MEDIUM; 
   hullTurretSize13 = $SLOT_LARGE; 
   hullTurretSize14 = $SLOT_MEDIUM; 
   
   wreckageData[0] = "ShipWreck_Dyson_Left -0.5 0 0";
   wreckageData[1] = "ShipWreck_Dyson_Right 0.5 0 0";      
   
   beaconDatablock       = "BeaconBase_01";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN  
   doodadLinkTerran_1 = "-0.911 0.486 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "-0.906 0.761 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "0.655 -0.648 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "-0.644 -0.648 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_5 = "0.927 0.746 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_6 = "0.922 0.486 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_7 = "-0.299 0.889 0 0 1 DoodadSet_Terran_S_Radar";   
   doodadLinkTerran_8 = "0.304 0.894 0 0 1 DoodadSet_Terran_S_Radar";
   
   doodadLinkPirate_1 = "-0.911 0.486 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "-0.906 0.761 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "0.655 -0.648 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "-0.644 -0.648 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_5 = "0.927 0.746 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_6 = "0.922 0.486 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_7 = "-0.299 0.889 0 0 1 DoodadSet_Pirate_S_Radar";   
   doodadLinkPirate_8 = "0.304 0.894 0 0 1 DoodadSet_Pirate_S_Radar";  
   
   //BREACH DATA  
   breachThresholds["Minor"] = "0.9 0.8 0.6 0.5 0.3 0.1";
   breachThresholds["Major"] = "0.7 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.288 -0.398 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.398 -0.221 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.419 0.329 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.419 0.265 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.424 0.702 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.513 0.142 Random BreachSet_Small";

   breachLinks["Major", 1] = "0.419 -0.226 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.162 -0.427 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0.571 0.673 3 ZombieEggBase";     
   
   threatMult = $ThreatMult_Normal;
};

datablock HullDatablock(HullDyson_02 : HullMothership) 
{   
   friendlyName = "Clockwork Two"; 
   size = "768 768";  //Motherships are no bigger than this. 
   imageMapShield = "station_dyson_02_shieldImageMap";
   
   factionImageMap_Default = "station_dyson_02ImageMap"; 
   hullIconImageMap = "station_dyson_02_iconImageMap"; 
   
   GuiCollision = "-0.985 -0.152 -0.555 -0.840 0.031 -1.000 0.660 -0.815 1.000 -0.103 0.786 0.712 -0.760 0.717";   
   CollisionPolyList = "0.304 -0.840 0.760 -0.545 0.913 -0.182 0.901 0.260 -0.864 0.241 -0.894 -0.152 -0.723 -0.575 -0.304 -0.845";
   MountedCollisionPolyList[0] = "-0.424 0.688 -0.618 0.688 -0.623 0.206 -0.424 0.196";
   MountedCollisionPolyList[1] = "0.644 0.683 0.440 0.683 0.435 0.201 0.644 0.196"; 
   MountedCollisionPolyList[2] = "0.251 0.638 -0.016 0.658 -0.246 0.643 -0.430 0.491 -0.712 0.108 0.780 0.113"; 

   LinkPoints = "0.000 0.005 -0.540 0.697 0.550 0.692 -0.383 -0.825 0.358 -0.845 0.000 -0.619 -0.525 0.378 -0.525 0.481 0.535 0.378 0.535 0.481 -0.309 -0.437 0.309 -0.437 0.000 0.511 0.010 -0.437 -0.890 -0.162 0.906 -0.157";
   
   comparativeHealth     = $MULT_HIGHEST;
      
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
   thrust_forward_multiplier  = "1";
   thrust_back_multiplier     = "0.7";
   thrust_strafe_multiplier   = "0.7";
   thrust_brake_multiplier    = "0.7";    
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9 10 15 16";
   turretLinkPoints = "11 12 13 14";
   
   externalLinkType6  = $LINK_Shooter; //This is the BIG one
   externalLinkSize6  = $SLOT_MOTHERSHIP;   
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_HUGE;  
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_HUGE;     
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_HUGE;  
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_HUGE;
   
   externalLinkType15  = $LINK_Launcher; 
   externalLinkSize15  = $SLOT_HUGE; 
   externalLinkMountRotation15 = -45; 
   
   externalLinkType16  = $LINK_Launcher; 
   externalLinkSize16  = $SLOT_HUGE; 
   externalLinkMountRotation16 = 45;     
      
   hullTurretSize11 = $SLOT_LARGE;  
   hullTurretSize12 = $SLOT_LARGE; 
   hullTurretSize13 = $SLOT_HUGE; 
   hullTurretSize14 = $SLOT_LARGE; 
   
   wreckageData[0] = "ShipWreck_Dyson_Left -0.3 0.2 0";
   wreckageData[1] = "ShipWreck_Dyson_Right 0.3 0.2 0";      
   wreckageData[2] = "ShipWreck_Dyson_Med 0 -0.2 0";
   
   beaconDatablock       = "BeaconBase_02";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkPirate_1 = "-0.608 0.467 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "-0.450 0.467 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "0.466 0.457 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "0.608 0.457 0 0 1 DoodadSet_Pirate_L_Lights"; 
   
   doodadLinkPirate_5 = "-0.189 -0.491 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_6 = "-0.409 -0.354 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_7 = "-0.534 -0.118 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_8 = "0.189 -0.501 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_9 = "0.435 -0.344 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_10 = "0.545 -0.118 0 0 1 DoodadSet_Pirate_L_Lights"; 
   
   doodadLinkPirate_11 = "-0.152 -0.236 0 0 0.8 DoodadSet_Pirate_S_Radar";   
   doodadLinkPirate_12 = "0.162 -0.236 0 0 0.8 DoodadSet_Pirate_S_Radar";  
   
   doodadLinkPirate_13 = "-0.435 -0.697 0 0 0.8 DoodadSet_Pirate_S_Radar";   
   doodadLinkPirate_14 = "0.419 -0.712 0 0 0.8 DoodadSet_Pirate_S_Radar";

   //BREACH DATA  
   breachThresholds["Minor"] = "0.9 0.8 0.6 0.5 0.3 0.2 0.1";
   breachThresholds["Major"] = "0.7 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.351 0.383 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.162 0.378 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.204 -0.241 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.293 -0.093 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.859 0.113 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.786 -0.304 Random BreachSet_Small";
   breachLinks["Minor", 7] = "-0.817 -0.108 Random BreachSet_Small";
   breachLinks["Minor", 8] = "-0.822 0.049 Random BreachSet_Small";

   breachLinks["Major", 1] = "-0.723 -0.388 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.414 -0.707 Random BreachSet_Huge";  
   
   //egg
   embryoInfo[0] = "0.686 0.275 3 ZombieEggBase";    
   
   threatMult = $ThreatMult_High;
};

//pirate


datablock HullDatablock(HullClockwork_Zero : HullMothership) 
{  
   PlayerCanFly = false;
   
   friendlyName = "Clockwork construction yard";    
    
   size = "512 512";  //Motherships are no bigger than this. 
   imageMapShield = "base_clockwork_zero_shieldImageMap";
   
   factionImageMap_Default = "base_clockwork_zeroImagemap";
   hullIconImageMap = "station_clockwork_01_iconImageMap";  
   
   CollisionPolyList = "-0.780 -0.840 0.754 -0.845 0.498 0.761 -0.670 0.825";
   LinkPoints = "-0.079 0.054 -0.587 0.864 0.430 0.825 -0.670 -0.918 0.540 -0.275 -0.262 -0.054";   
   comparativeHealth     = $MULT_LOWEST;
   
   rootDesign = "ClockworkStation_Zero";
      
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
    
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6";
   
   externalLinkType6  = $LINK_Utility; 
   externalLinkSize6  = $SLOT_HUGE;

   beaconDatablock       = "BeaconBase_01";
   commandPoints = 3;
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkPirate_1 = "-0.419 -0.388 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_2 = "0.293 -0.360 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_3 = "-0.414 0.172 0 0 1 DoodadSet_Pirate_L_Lights";      
   doodadLinkPirate_4 = "0.477 -0.550 0 0 0.9 DoodadSet_Pirate_S_Radar"; 
   doodadLinkPirate_5 = "0.644 -0.025 0 0 0.9 DoodadSet_Pirate_S_Radar"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.5 0.3";
   breachThresholds["Major"] = "0.7 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.267 -0.408 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.466 -0.290 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.529 0.010 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.566 0.516 Random BreachSet_Small";

   breachLinks["Major", 1] = "0.215 -0.354 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.340 0.334 Random BreachSet_Huge";

   //egg
   embryoInfo[0] = "0.602 -0.128 3 ZombieEggBase"; 
   
   threatMult = $ThreatMult_VeryLow;
};

datablock HullDatablock(HullClockwork_01 : HullMothership) 
{   
   friendlyName = "Clockwork Mothership"; 
   
   size = "512 512";  //Motherships are no bigger than this. 
   imageMapShield = "station_clockwork_01_shieldImageMap";
   
   factionImageMap_Default = "station_clockwork_01ImageMap";
   hullIconImageMap = "station_clockwork_01_iconImageMap";  
      
   CollisionPolyList = "-0.638 -0.820 0.761 -0.830 0.712 0.079 0.594 0.908 -0.555 0.894 -0.663 0.476 -0.707 -0.280";
   LinkPoints = "0.005 0.010 -0.545 0.923 0.525 0.933 -0.688 -0.727 0.702 -0.113 0.000 -0.791 0.314 -0.177 -0.015 0.737 0.000 -0.408 0.000 -0.304 -0.221 -0.020 0.201 0.452 -0.691 -0.300";
   comparativeHealth     = $MULT_LOW;
   
   rootDesign = "ClockworkStation_01";
      
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9 10 13";
   turretLinkPoints = "11 12";
   
   externalLinkType6  = $LINK_Shooter;  //This is the BIG one
   externalLinkSize6  = $SLOT_MOTHERSHIP;
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_HUGE; 
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_HUGE; 
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_HUGE;    
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_HUGE;   
    
   hullTurretSize11 = $SLOT_MEDIUM;
   hullTurretSize12 = $SLOT_SMALL;
   
   externalLinkType13  = $LINK_Launcher; 
   externalLinkSize13  = $SLOT_LARGE; 
   externalLinkMountRotation13 = -45; 
   
   wreckageData[0] = "ShipWreck_Clockwork_Left -0.4 0.4 0";
   wreckageData[1] = "ShipWreck_Clockwork_Right 0.4 0.4 0";

   beaconDatablock       = "BeaconBase_01";
   commandPoints = 7;
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN      
   doodadLinkPirate_1 = "-0.409 -0.805 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "-0.173 -0.874 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "0.246 0.791 0 0 1 DoodadSet_Pirate_L_Lights";  
   doodadLinkPirate_4 = "-0.702 0.319 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_5 = "0.477 -0.550 0 0 1 DoodadSet_Pirate_S_Radar"; 
   doodadLinkPirate_6 = "0.644 -0.025 0 0 1 DoodadSet_Pirate_S_Radar"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.5 0.3";
   breachThresholds["Major"] = "0.7 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.356 -0.383 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.325 0.206 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.466 0.408 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.409 0.629 Random BreachSet_Small";

   breachLinks["Major", 1] = "0.126 0.118 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.183 0.393 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0.602 -0.128 3 ZombieEggBase"; 
   
   threatMult = $ThreatMult_Low;
};

datablock HullDatablock(HullClockwork_01_Half : HullClockwork_01) 
{   
   rootDesign = "ClockworkStation_01_Half";
   doodadLinkPirate_7 = "0 0 0 1 1 DoodadSet_Mother2Scafold"; 
};

datablock HullDatablock(HullClockwork_02 : HullMothership) 
{   
   friendlyName = "Clockwork Mothership B"; 
   
   size = "768 768";  //Motherships are no bigger than this. 
   imageMapShield = "station_clockwork_02_shieldImageMap";
   
   factionImageMap_Default = "station_clockwork_02ImageMap"; 
   hullIconImageMap = "station_clockwork_02_iconImageMap";  
      
   CollisionPolyList = "-0.368 -0.913 0.408 -0.889 0.471 0.059 0.432 0.908 -0.422 0.894 -0.511 -0.614";
   LinkPoints = "0.029 0.152 -0.358 0.943 0.393 0.948 -0.422 -0.717 0.462 -0.776 0.034 -0.246 -0.349 -0.869 0.015 0.805 0.029 0.000 0.029 0.074 -0.128 0.280 0.172 0.604 -0.432 -0.594 -0.064 -0.805 0.142 -0.805 0.506 -0.589 -0.409 -0.300";
   
   comparativeHealth     = $MULT_AVERAGE;
   
   rootDesign = "ClockworkStation_02";
      
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9 10 17";
   turretLinkPoints = "11 12 13 14 15 16";
   
   externalLinkType6  = $LINK_Shooter;  //This is the BIG one
   externalLinkSize6  = $SLOT_MOTHERSHIP;
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_HUGE; 
   
   externalLinkType8  = $LINK_Utility; 
   externalLinkSize8  = $SLOT_HUGE; 
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_HUGE;    
   
   externalLinkType10  = $LINK_Utility; 
   externalLinkSize10  = $SLOT_HUGE; 
   
   externalLinkType17  = $LINK_Launcher; 
   externalLinkSize17  = $SLOT_HUGE; 
   externalLinkMountRotation17 = -45;   
    
   hullTurretSize11 = $SLOT_LARGE;
   hullTurretSize12 = $SLOT_SMALL;
   hullTurretSize13 = $SLOT_SMALL;
   hullTurretSize14 = $SLOT_SMALL;
   hullTurretSize15 = $SLOT_SMALL;
   hullTurretSize16 = $SLOT_SMALL;

   wreckageData[0] = "ShipWreck_Clockwork_Top 0 -0.5 0";
   wreckageData[1] = "ShipWreck_Clockwork_Left -0.4 0.4 0";
   wreckageData[2] = "ShipWreck_Clockwork_Right 0.4 0.4 0";

   beaconDatablock       = "BeaconBase_02";
   commandPoints = 15;
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkPirate_1 = "-0.241 0.010 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "0.335 0.162 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "0.304 0.442 0 0 1 DoodadSet_Pirate_L_Lights";   

   doodadLinkPirate_4 = "0.283 0.025 0 0 1 DoodadSet_Pirate_S_Radar";   
   doodadLinkPirate_5 = "-0.272 0.589 0 0 1 DoodadSet_Pirate_S_Radar"; 
   doodadLinkPirate_6 = "0.320 0.742 0 0 1 DoodadSet_Pirate_S_Radar";  
   
   doodadLinkPirate_7 = "0.152 -0.304 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_8 = "0.340 -0.737 0 0 1 DoodadSet_Pirate_S_Radar"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7 0.5 0.3 0.1";
   
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.314 -0.742 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.361 -0.599 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.314 -0.354 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.278 0.589 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.031 0.496 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.147 0.285 Random BreachSet_Huge"; 
   breachLinks["Major", 3] = "-0.063 -0.555 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "-0.220 -0.815 3 ZombieEggBase"; 
   
   threatMult = $ThreatMult_Normal;
};

//zombie

datablock HullDatablock(HullZombieClockwork : HullMothership_zombie) 
{   
   friendlyName = "Mothership"; 
   
   hullDamageModifier_AntiZombie = "0";  //changes ship state but does no damage. 
   
   size = "768 768";  //Motherships are no bigger than this. 
   imageMapShield = "station_zombie_clockwork_shieldImageMap";
   
   factionImageMap_Default = "station_zombie_clockworkImageMap";
   hullIconImageMap = "station_zombie_clockwork_iconImageMap";   
    
   GuiCollision = "-0.723 -0.766 -0.089 -0.972 0.807 -0.751 0.980 -0.128 0.906 0.702 0.005 0.904 -0.812 0.756 -0.990 -0.123";    
   CollisionPolyList = "0.010 -0.285 0.199 -0.162 0.141 0.025 -0.063 0.054 -0.173 -0.147";
   
   LinkPoints = "0.005 -0.103 -0.728 0.712 0.843 0.354 -0.890 -0.482 0.814 0.071 -0.571 -0.063 -0.610 0.179 0.286 0.295 -0.310 0.478 -0.352 -0.629 0.157 -0.795";
   MountedCollisionPolyList[0] = "0.021 -0.918 0.283 -0.928 0.613 -0.658 0.173 -0.604"; 
   MountedCollisionPolyList[1] = "0.880 -0.501 0.906 -0.025 0.602 -0.201 0.676 -0.442"; 
   MountedCollisionPolyList[2] = "0.807 0.059 0.964 0.408 0.660 0.771 0.409 0.889 0.126 0.565 0.110 0.280 0.372 0.093"; 
   MountedCollisionPolyList[3] = "-0.157 0.678 -0.482 0.751 -0.791 0.545 -0.870 0.020 -0.843 -0.457 -0.498 -0.756 -0.100 -0.791"; 
   
   comparativeHealth     = $MULT_HIGHEST;
   canBeInvaded = true;
   
   rootDesign = "Zombie_ClockworkStation";
      
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
    
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   turretLinkPoints = "1 6 7 8 9 10 11";
   
   hullTurretSize1 = $SLOT_HUGE;
   hullTurretSize6 = $SLOT_HUGE;
   hullTurretSize7 = $SLOT_HUGE;
   hullTurretSize8 = $SLOT_HUGE;
   hullTurretSize9 = $SLOT_HUGE;
   
   hullTurretSize10 = $SLOT_LARGE;
   hullTurretSize11 = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_zombie_clockwork 0 0 0"; 
   wreckageData[1] = "ShipWreck_zombie_generic_01 0 0 0"; 
   wreckageData[2] = "ShipWreck_zombie_generic_02 0 0 0"; 
   wreckageData[3] = "ShipWreck_zombie_generic_01 0 0 0"; 

   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN 
   doodadLinkZombie_1 = "0.005 -0.108 0 0 1 Doodad_ZombieClockworkCore"; 
   
   //these just look bad
   //doodadLinkZombie_2 = "-0.658 -0.417 291 1 1 Doodad_ZombieCrystal_01"; 
   //doodadLinkZombie_3 = "0.540 0.108 45 1 1 Doodad_ZombieCrystal_01"; 
   //doodadLinkZombie_4 = "0.285 -0.918 0 1 1 Doodad_ZombieCrystal_02"; 
   //doodadLinkZombie_5 = "0.167 0.648 198 1 1 Doodad_ZombieCrystal_03"; 

   //egg
   embryoInfo[0] = "0.346 -0.211 4 ZombieEggBase";
   embryoInfo[1] = "-0.440 -0.496 3 ZombieEggBase";    
   embryoInfo[2] = "0.215 -0.796 2 ZombieEggBase";    
   embryoInfo[3] = "0.712 -0.290 1 ZombieEggBase";    
   embryoInfo[4] = "0.178 0.535 0 ZombieEggBase";        
   
   minEggLayHealthPercent = 0.150;
   minEggGrowHealthPercent = 0.150; 
   breeding_nestSize     = -1;
   breeding_eggsPerNest  = -1; 
   
   comparativeHealth     = -1;
   maxComponentHealth    = 6000;
   
   threatMult = $ThreatMult_VeryHigh;
};
