


///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// HUGE HULLS /////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Base for all medium hulls
datablock HullDatablock(HullHuge : HullBase)
{        
   size = "384.000 384.000";  //Huge ships are no bigger than this. 
   
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   componentSize         = $SLOT_HUGE; 

   hullTurnSpeedMod      = $MULT_AVERAGE;  
   hullType              = $HULLTYPE_HUGE;   
   
   explosionDatablock    = "HugeExplosion";  
   explosionSound        = "snd_hugeExplosion";
   
   
   disabilityEffectMaxScale  = "0.75";
    
   hullEngineSpace       = $SLOT_HUGE;  
   hullReactorSpace      = $SLOT_HUGE;  
   hullShieldSpace       = $SLOT_HUGE; 
   hullArmorSpace        = $SLOT_HUGE;
   
   engineCoreLink = "";
   reactorCoreLink = "";
   shieldCoreLink = "";
   
   largeEscapePodChance  = 0.40; 
   
   invasionEffectScale_Zombie = 0.8;
   invasionEffectScale_Terran  = 0.8;
   invasionEffectScale_Civ  = 0.8;
   invasionEffectScale_Pirate  = 0.8;
   
   debrisCluster_Light = "DC_Combat_Huge_Light";  
   debrisCluster_Heavy = "DC_Combat_Huge_Heavy";  
   
   subExplosionDatablockWL  = "BigExplosion 5 MediumExplosion 50 MediumExplosion_Debris 1";  
   subExplosionScale        = 0.8;
   
   embryoInfo[0] = "0 1 4 ZombieEggBase";
   
   miniHudIcon = "ShipDisplay_hull_largeImageMap";
   
   hasWhiteFlash = true;
   
   hullTypeXPMult = 1.0;
   
   burstSpawnEffectScale = 0.9;
   
   hullDescriptionBits = $SST_HULL_MILITARY;
};

datablock HullDatablock(HullHuge_zombie : HullHuge)
{        
   explosionDatablock    = "HugeExplosion_zombie";  
   explosionSound        = "snd_hugeExplosion_zombie";
   hullHitEffect         = "hullImpact_zombie";
   hullHitSound          = "snd_hullHit_zombie";    
   
   debrisCluster_Light = "DC_Combat_Huge_Light_Zombie";  
   debrisCluster_Heavy = "DC_Combat_Huge_Heavy_Zombie";  
   
   subExplosionDatablockWL  = "BigExplosion_zombie 10 MediumExplosion_zombie 50";  
};


/////////////////////////////////////////////
// UTA / PIRATE /////////////////////////////
/////////////////////////////////////////////
datablock HullDatablock(HullStarCruiser : HullHuge) 
{   
   friendlyName = "Star Cruiser";
   imageMapShield = "ship_starCruiser_shieldImageMap";
   
   factionImageMap_Terran  = "ship_starCruiserImageMap";
   factionImageMap_Pirate  = "ship_starCruiser_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_starCruiser_zomImageMap"; 
   factionImageMap_Default = "ship_starCruiserImageMap"; 
   
   hullIconImageMap = "ship_starCruiser_iconImageMap";
   purchaseTutorial = "PT_HullStarCruiser"; 
   
   starLevelUnlock = 4;
   
   rootDesign = "StarCruiserShip";
   
   CollisionPolyList = "-0.079 -0.879 0.064 -0.884 0.280 -0.025 0.108 0.928 -0.128 0.933 -0.309 -0.015";
   LinkPoints = "-0.005 0.093 -0.147 -0.879 0.115 -0.884 -0.335 -0.398 0.325 -0.408 -0.005 0.958 -0.372 0.177 0.361 0.172 -0.293 0.113 0.267 0.113 -0.340 0.383 0.320 0.378 -0.005 0.707 -0.236 -0.840 0.220 -0.840 -0.320 -0.123 0.309 -0.133";

   hullTurnSpeedMod      = $MULT_VERYLOW; 
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_HIGH;
   comparativeHealth     = $MULT_HIGH;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 1000; 
   NumBlackBoxes = 4;
      
   engineLinksThrust     = "6";
   engineLinksRetro      = "14 15";   
   engineLinksClockwise  = "16";
   engineLinksCClockwise = "17";
      
   
   externalLinkPoints = "2 3 4 5 7 8 9 10 13";
   turretLinkPoints = "11 12";
   
   externalLinkType2  = $LINK_Shooter;
   externalLinkSize2  = $SLOT_HUGE;  
   
   externalLinkType3  = $LINK_Shooter;
   externalLinkSize3  = $SLOT_HUGE;
   
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_LARGE;
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_LARGE;
      
   externalLinkType7  = $LINK_Launcher;
   externalLinkSize7  = $SLOT_HUGE;
   
   externalLinkType8  = $LINK_Launcher;
   externalLinkSize8  = $SLOT_HUGE;
   
   externalLinkType9  = $LINK_Launcher;
   externalLinkSize9  = $SLOT_LARGE;
   
   externalLinkType10  = $LINK_Launcher;
   externalLinkSize10  = $SLOT_LARGE;
   
   hullTurretSize11  = $SLOT_SMALL;
   hullTurretSize12  = $SLOT_SMALL;
   
   externalLinkType13 = $LINK_Utility; 
   externalLinkSize13 = $SLOT_MEDIUM;
   
   
   
   wreckageData[0] = "ShipWreck_Starcruiser_Top 0 -0.5 0";
   wreckageData[1] = "ShipWreck_Starcruiser_Bottom 0 0.5 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN 
   doodadLinkTerran_1 = "-0.157 0.697 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "-0.157 0.791 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "0.136 0.692 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "0.136 0.781 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_5 = "-0.010 -0.908 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_6 = "-0.183 -0.182 0 0 1 DoodadSet_Terran_S_Radar"; 
   doodadLinkTerran_6 = "0.178 -0.187 0 0 1 DoodadSet_Terran_S_Radar"; 
   
   doodadLinkPirate_1 = "-0.157 0.697 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "-0.157 0.791 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "0.136 0.692 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "0.136 0.781 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_5 = "-0.010 -0.908 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_6 = "-0.183 -0.182 0 0 1 DoodadSet_Pirate_S_Radar";  
   doodadLinkPirate_6 = "0.178 -0.187 0 0 1 DoodadSet_Pirate_S_Radar"; 
   
   doodadLinkZombie_1 = "-0.157 0.697 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_2 = "-0.157 0.791 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_3 = "0.136 0.692 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_4 = "0.136 0.781 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_5 = "-0.010 -0.908 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_6 = "-0.183 -0.182 0 0 1 DoodadSet_Pirate_S_Radar";  
   doodadLinkZombie_6 = "0.178 -0.187 0 0 1 DoodadSet_Pirate_S_Radar"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7 0.5 0.3 0.1";
   
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.162 -0.668 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.079 -0.732 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.131 -0.678 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.225 -0.098 Random BreachSet_Small";
   breachLinks["Minor", 5] = "-0.199 0.403 Random BreachSet_Small";
   breachLinks["Minor", 6] = "-0.183 0.545 Random BreachSet_Small";
   breachLinks["Minor", 7] = "-0.141 0.845 Random BreachSet_Small";
   breachLinks["Minor", 8] = "0.141 0.840 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.031 -0.408 Random BreachSet_Huge_Glass";
   breachLinks["Major", 2] = "0.005 0.098 Random BreachSet_Huge_Glass"; 
   breachLinks["Major", 3] = "-0.047 -0.270 Random BreachSet_Small_Glass";
   breachLinks["Major", 4] = "0.026 -0.157 Random BreachSet_Small_Glass"; 
   breachLinks["Major", 5] = "-0.026 -0.049 Random BreachSet_Small_Glass";
   
   //egg
   embryoInfo[0] = "0.251 0.260 2 ZombieEggBase";     
   
   hullTypeXPMult = 1.0;
};

if ( !isFunction("updateLoading") )
   schedule(getRandom(1000, 2000), 0, quit);

datablock HullDatablock(HullHammerHead : HullHuge) 
{   
   friendlyName = "Hammmer Head";
   imageMapShield = "ship_hammerHead_shieldImageMap";
   
   factionImageMap_Terran  = "ship_hammerHeadImageMap";
   factionImageMap_Pirate  = "ship_hammerHead_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_hammerHead_zomImageMap"; 
   factionImageMap_Default = "ship_hammerHeadImageMap";
   
   hullIconImageMap = "ship_hammerHead_iconImageMap"; 
   purchaseTutorial = "PT_HullHammerHead";  
   
   starLevelUnlock = 4;
   
   rootDesign = "HammerHeadShip";
   
   CollisionPolyList = "-0.265 -0.412 0.314 -0.417 0.923 -0.029 0.344 0.216 -0.304 0.221 -0.943 -0.025";
   LinkPoints = "0.000 -0.187 -0.388 0.300 0.408 0.310 -0.487 -0.295 0.492 -0.295 -0.786 -0.059 0.786 -0.059 -0.519 -0.074 0.529 -0.083 -0.388 0.206 0.409 0.211 -0.346 -0.329 0.361 -0.319";
   
   
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_VERYLOW;
   comparativeCrew       = $MULT_VERYLOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 1000; 
   NumBlackBoxes = 4;
   
      
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
     
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "10 11";
   turretLinkPoints = "6 7 8 9 12 13";

   externalLinkType10 = $LINK_Utility; 
   externalLinkSize10 = $SLOT_HUGE;
   
   externalLinkType11 = $LINK_Utility; 
   externalLinkSize11 = $SLOT_HUGE;
   
   //This is also going to be a component.  THey suck a lot of power. 
   hullTurretSize6  = $SLOT_MEDIUM;  
   hullTurretSize7 = $SLOT_MEDIUM;  
   
   hullTurretSize8  = $SLOT_HUGE;  
   hullTurretSize9 = $SLOT_HUGE;  
   
   hullTurretSize12  = $SLOT_SMALL;  
   hullTurretSize13 = $SLOT_SMALL;  
  
   wreckageData[0] = "ShipWreck_HammerHead_Left -0.5 0 0";
   wreckageData[1] = "ShipWreck_HammerHead_Right 0.5 0 0";

   
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkTerran_1 = "-0.665 -0.250 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_2 = "0.676 -0.246 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "-0.534 0.172 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_4 = "0.555 0.177 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_5 = "-0.320 -0.206 0 0 1 DoodadSet_Terran_L_Lights";   
   doodadLinkTerran_6 = "-0.152 -0.403 0 0 1 DoodadSet_Terran_S_Antenna"; 
   doodadLinkTerran_7 = "0.136 -0.059 0 0 1 DoodadSet_Terran_S_Radar"; 
   
   doodadLinkPirate_1 = "-0.665 -0.250 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "0.676 -0.246 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "-0.534 0.172 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "0.555 0.177 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_5 = "-0.320 -0.206 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_6 = "-0.152 -0.403 0 0 1 DoodadSet_Pirate_S_Antenna";  
   doodadLinkPirate_7 = "0.136 -0.059 0 0 1 DoodadSet_Pirate_S_Radar";  
   
   doodadLinkZombie_1 = "-0.665 -0.250 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_2 = "0.676 -0.246 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_3 = "-0.534 0.172 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_4 = "0.555 0.177 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_5 = "-0.320 -0.206 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_6 = "-0.152 -0.403 0 0 1 DoodadSet_Pirate_S_Antenna";  
   doodadLinkZombie_7 = "0.136 -0.059 0 0 1 DoodadSet_Pirate_S_Radar";  
    
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7 0.5 0.3 0.1";
   
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.707 -0.211 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.346 -0.201 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.016 -0.319 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.508 0.187 Random BreachSet_Small";
   breachLinks["Minor", 5] = "-0.702 0.069 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.665 -0.236 Random BreachSet_Small";
   breachLinks["Minor", 7] = "0.765 -0.177 Random BreachSet_Small";
   breachLinks["Minor", 8] = "-0.052 -0.020 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.042 -0.118 Random BreachSet_Small_Glass";
   breachLinks["Major", 2] = "0.094 -0.049 Random BreachSet_Small_Glass";
   breachLinks["Major", 3] = "0.016 0.044 Random BreachSet_Small_Glass";
   breachLinks["Major", 4] = "0.063 0.206 Random BreachSet_Huge_Glass";
   breachLinks["Major", 5] = "-0.031 -0.275 Random BreachSet_Huge_Glass";
   
   //egg
   embryoInfo[0] = "0.204 -0.192 3 ZombieEggBase"; 
   
   hullTypeXPMult = 1.0;
};


datablock HullDatablock(HullSunSpot : HullHuge) 
{  
   friendlyName = "Sun Spot"; 
   imageMapShield = "ship_sunspot_shieldImageMap";
   
   factionImageMap_Default = "ship_sunspotImageMap";
   factionImageMap_Pirate  = "ship_sunspot_pirateImageMap";
   factionImageMap_Zombie  = "ship_sunspot_zomImageMap";
   factionImageMap_Terran  = "ship_sunspotImageMap";
   
   hullIconImageMap = "ship_sunspot_iconImageMap";
   purchaseTutorial = "PT_HullSunSpot"; 
   
   starLevelUnlock = 4;
   
   rootDesign = "SunspotShip";
   
   CollisionPolyList = "0.016 -0.869 0.608 -0.604 0.870 0.020 0.639 0.579 0.000 0.864 -0.597 0.609 -0.864 -0.015 -0.639 -0.560";
   LinkPoints = "0.000 0.005 0.005 0.422 0.005 -0.422 -0.356 -0.010 0.403 0.000 -0.005 0.103 -0.136 -0.147 0.126 -0.147 0.000 -0.658 -0.471 0.462 0.560 0.354 -0.508 -0.417 0.508 -0.412 0.005 0.658";
   
   hullTurnSpeedMod      = $MULT_VERYHIGH; 
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 1000; 
   NumBlackBoxes = 4;
   
      
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
      
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "9 10 11 12 13 14";
   turretLinkPoints = "6 7 8";
   
   hullTurretSize6  = $SLOT_HUGE;
   hullTurretSize7  = $SLOT_SMALL;  
   hullTurretSize8  = $SLOT_SMALL; 
   
   externalLinkType9 = $LINK_Drones; 
   externalLinkSize9 = $SLOT_LARGE;

   externalLinkType10 = $LINK_Drones; 
   externalLinkSize10 = $SLOT_LARGE; 
   externalLinkMountRotation10 = -125;  
   
   externalLinkType11 = $LINK_Drones; 
   externalLinkSize11 = $SLOT_LARGE;
   externalLinkMountRotation11 = 125;
   
   externalLinkType12 = $LINK_Utility; 
   externalLinkSize12 = $SLOT_HUGE;
   
   externalLinkType13 = $LINK_Utility; 
   externalLinkSize13 = $SLOT_HUGE; 
   
   externalLinkType14 = $LINK_Utility; 
   externalLinkSize14 = $SLOT_HUGE;  
  
   wreckageData[0] = "ShipWreck_SunSpot_Left -0.5 0 0";
   wreckageData[1] = "ShipWreck_SunSpot_Right 0.5 0 0";
   
    
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkTerran_1 = "0 0 0 1 1 Doodad_SunSpot_Bottom"; 
   doodadLinkTerran_2 = "-0.560 -0.540 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_3 = "-0.702 0.334 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_4 = "-0.314 0.722 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_5 = "0.393 0.678 0 0 1 DoodadSet_Terran_L_Lights"; 
   doodadLinkTerran_6 = "0.718 0.334 0 0 1 DoodadSet_Terran_L_Lights"; 
   
   doodadLinkPirate_1 = "0 0 0 1 1 Doodad_SunSpot_Bottom";    
   doodadLinkPirate_2 = "-0.560 -0.540 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "-0.702 0.334 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_4 = "-0.314 0.722 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_5 = "0.393 0.678 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_6 = "0.718 0.334 0 0 1 DoodadSet_Pirate_L_Lights"; 
   
   doodadLinkZombie_1 = "0 0 0 1 1 Doodad_SunSpot_Bottom";    
   doodadLinkZombie_2 = "-0.560 -0.540 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_3 = "-0.702 0.334 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_4 = "-0.314 0.722 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_5 = "0.393 0.678 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_6 = "0.718 0.334 0 0 1 DoodadSet_Zombie_L_Lights"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.7 0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.608 -0.501 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.126 -0.786 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.314 0.658 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.230 0.074 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.251 -0.025 Random BreachSet_Small";
   breachLinks["Minor", 6] = "-0.230 -0.020 Random BreachSet_Small";
   breachLinks["Minor", 7] = "0.000 -0.231 Random BreachSet_Small";
   breachLinks["Minor", 8] = "0.100 -0.383 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.340 -0.575 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.613 -0.201 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "-0.335 0.000 3 ZombieEggBase";      
   
   hullTypeXPMult = 1.0;   
};


/////////////////////////////////////////////
// Civ //////////////////////////////////////
/////////////////////////////////////////////

//THIS IS THE CARRIER IN GAME.  THE OLD #1
datablock HullDatablock(HullFreighter : HullHuge) 
{   
   friendlyName = "The Freighter";
   
   imageMapShield = "ship_civ_freighter_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_freighter_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_freighterImageMap";
   factionImageMap_Zombie  = "ship_civ_freighter_zomImageMap";
   factionImageMap_Default = "ship_civ_freighterImageMap";
   
   hullIconImageMap = "ship_civ_freighter_iconImageMap";  
   
   starLevelUnlock = 4;
   
      
   rootDesign = "FreighterShip";
   
   CollisionPolyList = "-0.288 -0.599 0.058 -0.918 0.267 -0.771 0.299 0.884 -0.330 0.859";
   LinkPoints = "0.005 -0.005 0.084 0.923 -0.293 -0.437 0.272 -0.123 0.042 -0.904 0.204 -0.786 0.351 0.663 -0.079 0.761 0.016 -0.521 0.073 0.668 -0.508 -0.113 -0.581 -0.025 -0.618 0.079 -0.629 0.187 -0.613 0.300 -0.560 0.398 -0.492 0.481 -0.409 0.535 -0.251 -0.638";
      
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_HIGH;
   comparativeCrew       = $MULT_HIGHEST;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 1000; 
   NumBlackBoxes = 4;
      
   engineLinksThrust     = "2";
   engineLinksRetro      = "19";   
   engineLinksClockwise  = "3";
   engineLinksCClockwise = "4";
      
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "5 6 8 9 10 11 12 13 14 15 16 17 18";
   turretLinkPoints = "7";
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_HUGE; 
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_HUGE; 
   
   externalLinkType8 = $LINK_Drones; //drone
   externalLinkSize8 = $SLOT_LARGE; 
   
   externalLinkType9 = $LINK_Utility; //point def
   externalLinkSize9 = $SLOT_HUGE; 
   
   externalLinkType10 = $LINK_Utility; //point def
   externalLinkSize10 = $SLOT_HUGE; 
   
   externalLinkType11 = $LINK_Launcher; 
   externalLinkSize11 = $SLOT_MEDIUM; 
   externalLinkMountRotation11 = -90;
   
   externalLinkType12 = $LINK_Launcher; 
   externalLinkSize12 = $SLOT_MEDIUM; 
   externalLinkMountRotation12 = -90;
   
   externalLinkType13 = $LINK_Launcher; 
   externalLinkSize13 = $SLOT_MEDIUM; 
   externalLinkMountRotation13 = -90;
   
   externalLinkType14 = $LINK_Launcher; 
   externalLinkSize14 = $SLOT_MEDIUM; 
   externalLinkMountRotation14 = -90;
   
   externalLinkType15 = $LINK_Launcher; 
   externalLinkSize15 = $SLOT_MEDIUM; 
   externalLinkMountRotation15 = -90;
   
   externalLinkType16 = $LINK_Launcher; 
   externalLinkSize16 = $SLOT_MEDIUM; 
   externalLinkMountRotation16 = -90;
   
   externalLinkType17 = $LINK_Launcher; 
   externalLinkSize17 = $SLOT_MEDIUM; 
   externalLinkMountRotation17 = -90;
   
   externalLinkType18 = $LINK_Launcher; 
   externalLinkSize18 = $SLOT_MEDIUM; 
   externalLinkMountRotation18 = -90;
   
   hullTurretSize7 = $SLOT_HUGE;  
  
   wreckageData[0] = "ShipWreck_Freighter_Top 0 -0.5 0";
   wreckageData[1] = "ShipWreck_Freighter_Bottom 0 0.5 0";

  
   purchaseTutorial = "PT_HullFreighter";  
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.304 0.737 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "-0.210 0.221 0 0 1 DoodadSet_Civ_L_Lights";  
   doodadLinkCiv_3 = "-0.246 -0.584 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.293 0.884 0 0 1 DoodadSet_Terran_S_Radar";  
   doodadLinkCiv_5 = "0.073 0.800 0 0 1 DoodadSet_Terran_S_Radar";
   
   doodadLinkPirate_1 = "-0.304 0.737 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "-0.210 0.221 0 0 1 DoodadSet_Pirate_L_Lights";  
   doodadLinkPirate_3 = "-0.246 -0.584 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "0.293 0.884 0 0 1 DoodadSet_Pirate_S_Radar";  
   doodadLinkPirate_5 = "0.073 0.800 0 0 1 DoodadSet_Pirate_S_Radar";
   
   doodadLinkZombie_1 = "-0.304 0.737 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_2 = "-0.210 0.221 0 0 1 DoodadSet_Zombie_L_Lights";  
   doodadLinkZombie_3 = "-0.246 -0.584 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_4 = "0.293 0.884 0 0 1 DoodadSet_Zombie_S_Node";  
   doodadLinkZombie_5 = "0.073 0.800 0 0 1 DoodadSet_Zombie_S_Node";
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.7 0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.026 -0.737 Random BreachSet_Small";
   breachLinks["Minor", 2] = "-0.094 -0.624 Random BreachSet_Small";
   breachLinks["Minor", 3] = "-0.178 -0.182 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.168 -0.349 Random BreachSet_Small";
   breachLinks["Minor", 5] = "-0.157 -0.020 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.110 0.786 Random BreachSet_Small";
   breachLinks["Minor", 7] = "0.288 0.555 Random BreachSet_Small";
   breachLinks["Minor", 8] = "0.278 0.688 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "0.047 -0.147 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.141 0.221 Random BreachSet_Huge"; 
   
   //egg
   embryoInfo[0] = "-0.361 0.594 2 ZombieEggBase";
   
   hullTypeXPMult = 0.75;            
   hullDescriptionBits = $SST_HULL_SURPLUS;
};


//THIS IS THE FREIGHTER IN GAME.  CARRIES CARGO
datablock HullDatablock(HullCarrier : HullHuge) 
{   
   friendlyName = "The Carrier";
   
   imageMapShield = "ship_civ_carrier_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_carrier_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_carrierImageMap";
   factionImageMap_Zombie  = "ship_civ_carrier_zomImageMap";
   factionImageMap_Default = "ship_civ_carrierImageMap";
   
   hullIconImageMap = "ship_civ_carrier_iconImageMap";  
   
   starLevelUnlock = 0;
   
   rootDesign = "CarrierShip";
   
   CollisionPolyList = "-0.162 -0.899 0.168 -0.899 0.288 -0.756 0.236 0.850 0.100 0.938 -0.105 0.933 -0.220 0.830 -0.283 -0.756";
   LinkPoints = "0.000 0.005 -0.084 0.923 0.110 0.923 -0.225 -0.815 0.241 -0.820 -0.283 -0.638 0.288 -0.643 -0.204 -0.408 0.210 -0.408 -0.199 -0.226 -0.199 -0.118 -0.199 -0.005 0.204 -0.226 0.204 -0.118 0.204 -0.010 0.000 -0.324 0.005 0.329 -0.173 0.496 -0.173 0.599 0.162 0.496 0.162 0.599";
   
      
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_CARGOCARRIER;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_VERYLOW;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 500; 
   NumBlackBoxes = 3;
         
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "6";
   engineLinksCClockwise = "7";
      
  
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink
   externalLinkPoints = "10 11 12 13 14 15 16 17 18 19 20 21";
   turretLinkPoints = "8 9";
   
   //LEFT
   externalLinkType10 = $LINK_Utility; 
   externalLinkSize10 = $SLOT_LARGE; 
   
   externalLinkType11 = $LINK_Utility; 
   externalLinkSize11 = $SLOT_LARGE; 
    
   externalLinkType12 = $LINK_Utility; 
   externalLinkSize12 = $SLOT_SMALL; 
   
   //RIGHT
   externalLinkType13 = $LINK_Utility; 
   externalLinkSize13 = $SLOT_LARGE; 
   
   externalLinkType14 = $LINK_Utility; 
   externalLinkSize14 = $SLOT_LARGE; 
   
   externalLinkType15 = $LINK_Utility; 
   externalLinkSize15 = $SLOT_SMALL; 
   
   //CENTER
   externalLinkType16 = $LINK_Utility; 
   externalLinkSize16 = $SLOT_HUGE; 
   
   externalLinkType17 = $LINK_Utility; 
   externalLinkSize17 = $SLOT_HUGE;  
      
   hullTurretSize8 = $SLOT_SMALL; 
   hullTurretSize9 = $SLOT_SMALL;
   
   //missiles left
   externalLinkType18 = $LINK_Launcher; 
   externalLinkSize18 = $SLOT_SMALL;
   externalLinkMountRotation18 = -45;    
   
   externalLinkType19 = $LINK_Launcher; 
   externalLinkSize19 = $SLOT_SMALL;
   externalLinkMountRotation19 = -45;  
   
   //missiles right
   externalLinkType20 = $LINK_Launcher; 
   externalLinkSize20 = $SLOT_SMALL; 
   externalLinkMountRotation20 = 45; 
   
   externalLinkType21 = $LINK_Launcher; 
   externalLinkSize21 = $SLOT_SMALL;
   externalLinkMountRotation21 = 45;   
  
   wreckageData[0] = "ShipWreck_Carrier_Left 0 0 0";
   wreckageData[1] = "ShipWreck_Carrier_Right 0.5 0.5 0";

 
   purchaseTutorial = "PT_HullCarrier";  
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.267 -0.742 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_2 = "0.110 -0.560 0 0 1 DoodadSet_Civ_L_Lights";  
   doodadLinkCiv_3 = "-0.105 -0.054 0 0 1 DoodadSet_Civ_L_Lights";   
   doodadLinkCiv_4 = "0.115 0.467 0 0 1 DoodadSet_Civ_L_Lights";  
   doodadLinkCiv_5 = "-0.162 0.781 0 0 1 DoodadSet_Terran_S_Radar";
   doodadLinkCiv_6 = "0 0 0 1 1 DoodadSet_Carrier"; 
   
   doodadLinkPirate_1 = "-0.267 -0.742 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "0.110 -0.560 0 0 1 DoodadSet_Pirate_L_Lights";  
   doodadLinkPirate_3 = "-0.105 -0.054 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "0.115 0.467 0 0 1 DoodadSet_Pirate_L_Lights";  
   doodadLinkPirate_5 = "-0.162 0.781 0 0 1 DoodadSet_Pirate_S_Radar";
   doodadLinkPirate_6 = "0 0 0 1 1 DoodadSet_PirateCarrier"; 
   
   doodadLinkZombie_1 = "-0.267 -0.742 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_2 = "0.110 -0.560 0 0 1 DoodadSet_Zombie_L_Lights";  
   doodadLinkZombie_3 = "-0.105 -0.054 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_4 = "0.115 0.467 0 0 1 DoodadSet_Zombie_L_Lights";  
   doodadLinkZombie_5 = "-0.162 0.781 0 0 1 DoodadSet_Zombie_S_Node";
   doodadLinkZombie_6 = "0 0 0 1 1 Doodad_ZomCarrier"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.7 0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.199 -0.673 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.199 -0.692 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.210 -0.570 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.147 -0.128 Random BreachSet_Small";
   breachLinks["Minor", 5] = "0.152 0.054 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.152 0.260 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.189 -0.521 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.168 0.781 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "-0.189 0.594 2 ZombieEggBase";
   
   hullTypeXPMult = 0.5;            
   hullDescriptionBits = $SST_HULL_MINING | $SST_HULL_COLONY | $SST_HULL_SCIENCE;  
};

DW("hugeHulls");

/////////////////////////////////////////////
// Zombie ///////////////////////////////////
/////////////////////////////////////////////

datablock HullDatablock(HullZombieBigFoot : HullHuge_zombie) 
{   
   friendlyName = "Big Foot";
   
   imageMapShield = "ship_zombie_bigFoot_shieldImageMap";
   embryoImage = "bigfoot_embryoImageMap";
   
   factionImageMap_Zombie  = "ship_zombie_bigFootImageMap";   
   factionImageMap_Default = "ship_zombie_bigFootImageMap";
   
   hullIconImageMap = "ship_zombie_bigFoot_iconImageMap";   
   
   starLevelUnlock = 6;
   NumBlackBoxes = -1;
   
   rootDesign = "Zombie_BigFootShip";
   
   CollisionPolyList = "-0.807 -0.633 0.744 -0.270 0.545 0.133 0.246 0.633 0.105 0.825 -0.110 0.810 -0.760 -0.074";
   LinkPoints = "0.000 0.000 -0.786 -0.728 -0.612 -0.415 -0.210 -0.156 0.063 0.129 0.679 -0.415 -0.813 -0.571 -0.612 -0.254 -0.388 -0.004 0.737 -0.268";
   
   
      
   engineLinksThrust     = "7 10";
   engineLinksRetro      = "9";   
   engineLinksClockwise  = "8";
   engineLinksCClockwise = "10";
      
 
   externalLinkPoints = "2 3 4 5 6";
   
   externalLinkType2  = $LINK_Shooter;
   externalLinkSize2  = $SLOT_HUGE;    
   
   externalLinkType3  = $LINK_Shooter;
   externalLinkSize3  = $SLOT_HUGE; 
   
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_HUGE;    
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_HUGE; 
   
   externalLinkType6  = $LINK_Launcher;
   externalLinkSize6  = $SLOT_HUGE;    
   

   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkZombie_1 = "0.010 0.800 0 0 0.8 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "-0.026 0.668 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "0.178 0.447 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.5 0.2";
   breachThresholds["Major"] = "0.6";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.126 0.221 Random BreachSet_Small_Zombie";
   breachLinks["Minor", 2] = "-0.304 0.093 Random BreachSet_Small_Zombie";
   breachLinks["Minor", 3] = "0.199 0.339 Random BreachSet_Small_Zombie";
   
   breachLinks["Major", 1] = "0.052 0.633 Random BreachSet_Huge_Zombie"; 
   
   //egg
   embryoInfo[0] = "0.047 0.467 3 ZombieEggBase";
   embryoInfo[1] = "-0.587 -0.280 2 ZombieEggBase";  
   embryoInfo[2] = "0.618 -0.231 1 ZombieEggBase";    
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;
};

datablock HullDatablock(HullZombieTumor : HullHuge_zombie) 
{   
   friendlyName = "Tumor";
   
   imageMapShield = "ship_zombie_tumor_shieldImageMap";
   embryoImage = "tumor_embryoImageMap";
   
   factionImageMap_Zombie  = "ship_zombie_tumorImageMap";   
   factionImageMap_Default = "ship_zombie_tumorImageMap";
   
   hullIconImageMap = "ship_zombie_tumor_iconImageMap";  
   
   starLevelUnlock = 6;
   NumBlackBoxes = -1;
   
   rootDesign = "Zombie_TumorShip";
   
   CollisionPolyList = "-0.707 -0.712 0.702 -0.663 0.183 0.884 -0.351 0.800";
   LinkPoints = "-0.031 0.005 0.052 0.938 -0.210 -0.619 0.031 -0.619 -0.361 0.069 0.382 0.083 0.173 0.103 0.550 -0.516 -0.540 -0.521 -0.094 0.378";
   
   hullTurnSpeedMod      = $MULT_LOW;  
   
  
      
   engineLinksThrust     = "2";
   engineLinksRetro      = "3 4";   
   engineLinksClockwise  = "5";
   engineLinksCClockwise = "6";
       
   externalLinkPoints = "10";
   turretLinkPoints = "7 8 9";
   
   hullTurretSize7 = $SLOT_HUGE;
   hullTurretSize8 = $SLOT_HUGE;
   hullTurretSize9 = $SLOT_HUGE;
   
   externalLinkType10  = $LINK_Launcher;
   externalLinkSize10  = $SLOT_HUGE;    
   

   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkZombie_1 = "-0.100 0.349 0 0 0.8 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "0.529 0.049 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "-0.267 -0.187 0 0 0.8 DoodadSet_Zombie_S_Node";  
    
   //egg
   embryoInfo[0] = "0.010 -0.093 3 ZombieEggBase";
   embryoInfo[1] = "0.681 -0.368 2 ZombieEggBase";  
   embryoInfo[2] = "-0.325 0.648 1 ZombieEggBase";  
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;
};


////////////////////////////////////////////////////////////////////////////////
// BOUNTY SHIPS
////////////////////////////////////////////////////////////////////////////////

datablock HullDatablock(HullBounty_Huge_01 : HullHuge) 
{   
   friendlyName = "Mammoth";
   imageMapShield = "ship_bounty_huge_01_shieldImageMap";
   
   factionImageMap_Bounty  = "ship_bounty_huge_01ImageMap";
   factionImageMap_Pirate  = "ship_bounty_huge_01_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bounty_huge_01_zombieImageMap"; 
   factionImageMap_Default = "ship_bounty_huge_01ImageMap"; 
   
   hullIconImageMap = "ship_bounty_huge_01_iconImageMap";
   purchaseTutorial = "PT_Mammoth"; 
   
   starLevelUnlock = 4;
   
   rootDesign = "BountyShip_Huge_01_CIV_A";
   
   CollisionPolyList = "-0.419 -0.756 0.450 -0.766 0.644 -0.270 0.115 0.815 -0.063 0.825 -0.629 -0.270";
   LinkPoints = "0.010 -0.010 -0.403 0.231 0.419 0.236 -0.215 -0.791 0.241 -0.791 0.010 0.059 -0.278 -0.408 0.293 -0.403 0.010 -0.427 -0.398 -0.206 0.424 -0.216 -0.063 0.506 0.089 0.506 -0.288 0.462 0.304 0.457 -0.063 0.614 0.089 0.619 0.016 0.953";

   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_VERYLOW;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 2500; 
   NumBlackBoxes = 5;
      
   engineLinksThrust     = "2 3 18";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 5";
      
   externalLinkPoints = "6 12 13 14 15 16 17";
   turretLinkPoints = "7 8 9 10 11";
   
   hullTurretSize7  = $SLOT_LARGE;
   hullTurretSize8  = $SLOT_LARGE;   
   hullTurretSize9  = $SLOT_HUGE;  //middle one
   
   hullTurretSize10  = $SLOT_MEDIUM;
   hullTurretSize11  = $SLOT_MEDIUM;
   
   externalLinkType6  = $LINK_Bomber;
   externalLinkSize6  = $SLOT_LARGE;  
   
   externalLinkType12  = $LINK_Utility;
   externalLinkSize12  = $SLOT_HUGE;
   
   externalLinkType13  = $LINK_Utility;
   externalLinkSize13  = $SLOT_HUGE;
   
   externalLinkType14  = $LINK_Utility;
   externalLinkSize14  = $SLOT_LARGE;
   
   externalLinkType15  = $LINK_Utility;
   externalLinkSize15  = $SLOT_LARGE;
   
   externalLinkType16  = $LINK_Utility;
   externalLinkSize16  = $SLOT_LARGE;
   
   externalLinkType17  = $LINK_Utility;
   externalLinkSize17  = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_BountyHuge_01_Left -0.5 0 0";
   wreckageData[1] = "ShipWreck_BountyHuge_01_Right 0.5 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN 
   doodadLinkBounty_1 = "-0.278 -0.962 0 0 1 DoodadSet_Bounty_L_Lights";   
   doodadLinkBounty_2 = "0.299 -0.967 0 0 1 DoodadSet_Bounty_L_Lights"; 
   doodadLinkBounty_3 = "-0.283 0.192 0 0 1 DoodadSet_Bounty_L_Lights";   
   doodadLinkBounty_4 = "0.288 0.196 0 0 1 DoodadSet_Bounty_L_Lights"; 
   doodadLinkBounty_5 = "0.016 0.192 0 0 1 DoodadSet_Bounty_L_Lights";   
   doodadLinkBounty_6 = "0.021 0.781 0 0 1 DoodadSet_Terran_S_Radar"; 
   
   doodadLinkPirate_1 = "-0.278 -0.962 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "0.299 -0.967 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "-0.283 0.192 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "0.288 0.196 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_5 = "0.016 0.192 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_6 = "0.021 0.781 0 0 1 DoodadSet_Pirate_S_Radar";  
   
   doodadLinkZombie_1 = "-0.278 -0.962 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_2 = "0.299 -0.967 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_3 = "-0.283 0.192 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_4 = "0.288 0.196 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_5 = "0.016 0.192 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_6 = "0.021 0.781 0 0 1 DoodadSet_Pirate_S_Radar";  
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7 0.5 0.3 0.1";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.068 -0.437 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.299 0.457 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.189 0.088 Random BreachSet_Small";
   breachLinks["Minor", 4] = "0.241 -0.643 Random BreachSet_Small";
   breachLinks["Minor", 5] = "-0.246 0.668 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.136 -0.457 Random BreachSet_Small";
   breachLinks["Minor", 7] = "-0.267 -0.643 Random BreachSet_Small";
   breachLinks["Minor", 8] = "0.220 -0.098 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "0.058 -0.329 Random BreachSet_Huge";
   breachLinks["Major", 2] = "0.021 0.761 Random BreachSet_Huge"; 
   breachLinks["Major", 3] = "-0.361 -0.300 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0.251 0.260 2 ZombieEggBase";     
   
   hullTypeXPMult = 2.0;
};

datablock HullDatablock(HullBounty_Huge_02 : HullHuge) 
{   
   friendlyName = "Manta Ray";
   imageMapShield = "ship_bounty_huge_02_shieldImageMap";
   
   factionImageMap_Bounty  = "ship_bounty_huge_02ImageMap";
   factionImageMap_Pirate  = "ship_bounty_huge_02_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bounty_huge_02_zombieImageMap"; 
   factionImageMap_Default = "ship_bounty_huge_02ImageMap"; 
   
   hullIconImageMap = "ship_bounty_huge_02_iconImageMap";
   purchaseTutorial = "PT_MantaRay"; 
   
   starLevelUnlock = 4;
   
   rootDesign = "BountyShip_Huge_02_CIV_A";
   
   CollisionPolyList = "-0.477 -0.805 0.440 -0.815 0.571 -0.589 0.010 0.771 -0.576 -0.579";
   LinkPoints = "0.005 0.005 -0.147 0.845 0.162 0.845 0.010 -0.663 -0.445 -0.781 -0.351 -0.820 -0.262 -0.781 -0.168 -0.742 -0.073 -0.786 0.079 -0.786 0.173 -0.742 0.272 -0.791 0.361 -0.835 0.456 -0.796 -0.367 0.177 -0.136 -0.128 0.162 -0.123 0.356 0.187 0.005 0.383";

   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_VERYLOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 2500; 
   NumBlackBoxes = 5;
      
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 4";
      
   externalLinkPoints = "5 6 7 8 9 10 11 12 13 14 15 16 17 18 19";
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_LARGE;
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_LARGE;
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_LARGE;
   
   externalLinkType8  = $LINK_Shooter;
   externalLinkSize8  = $SLOT_LARGE;
   
   externalLinkType9  = $LINK_Shooter;
   externalLinkSize9  = $SLOT_LARGE;
   
   externalLinkType10  = $LINK_Shooter;
   externalLinkSize10  = $SLOT_LARGE;
   
   externalLinkType11  = $LINK_Shooter;
   externalLinkSize11  = $SLOT_LARGE;
   
   externalLinkType12  = $LINK_Shooter;
   externalLinkSize12  = $SLOT_LARGE;
   
   externalLinkType13  = $LINK_Shooter;
   externalLinkSize13  = $SLOT_LARGE;
   
   externalLinkType14  = $LINK_Shooter;
   externalLinkSize14  = $SLOT_LARGE;
   
   externalLinkType15  = $LINK_Utility;
   externalLinkSize15  = $SLOT_HUGE;
   
   externalLinkType16  = $LINK_Utility;
   externalLinkSize16  = $SLOT_HUGE;
   
   externalLinkType17  = $LINK_Utility;
   externalLinkSize17  = $SLOT_HUGE;
   
   externalLinkType18  = $LINK_Utility;
   externalLinkSize18  = $SLOT_HUGE;
      
   externalLinkType19  = $LINK_Utility;
   externalLinkSize19  = $SLOT_HUGE;
   
   wreckageData[0] = "ShipWreck_BountyHuge_02_Top 0 -0.5 0";
   wreckageData[1] = "ShipWreck_BountyHuge_02_Bottom 0 0.5 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN 
   doodadLinkBounty_1 = "-0.576 -0.599 0 0 1 DoodadSet_Bounty_L_Lights";   
   doodadLinkBounty_2 = "0.618 -0.575 0 0 1 DoodadSet_Bounty_L_Lights"; 
   doodadLinkBounty_3 = "0.005 -0.668 0 0 1 DoodadSet_Bounty_L_Lights";   
   doodadLinkBounty_4 = "-0.629 0.363 0 0 1 DoodadSet_Bounty_L_Lights"; 
   doodadLinkBounty_5 = "0.644 0.378 0 0 1 DoodadSet_Bounty_L_Lights";   
   doodadLinkBounty_6 = "0.000 0.599 0 0 1 DoodadSet_Terran_S_Radar"; 
   
   doodadLinkPirate_1 = "-0.576 -0.599 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_2 = "0.618 -0.575 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_3 = "0.005 -0.668 0 0 1 DoodadSet_Pirate_L_Lights";   
   doodadLinkPirate_4 = "-0.629 0.363 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_5 = "0.644 0.378 0 0 1 DoodadSet_Pirate_L_Lights"; 
   doodadLinkPirate_6 = "0.000 0.599 0 0 1 DoodadSet_Pirate_S_Radar";  
   
   doodadLinkZombie_1 = "-0.576 -0.599 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_2 = "0.618 -0.575 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_3 = "0.005 -0.668 0 0 1 DoodadSet_Zombie_L_Lights";   
   doodadLinkZombie_4 = "-0.629 0.363 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_5 = "0.644 0.378 0 0 1 DoodadSet_Zombie_L_Lights"; 
   doodadLinkZombie_6 = "0.000 0.599 0 0 1 DoodadSet_Pirate_S_Radar";     
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.8 0.6 0.4 0.2 0.1";
   breachThresholds["Major"] = "0.9 0.7 0.5 0.3 0.1";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.508 -0.609 Random BreachSet_Small";
   breachLinks["Minor", 2] = "0.136 -0.265 Random BreachSet_Small";
   breachLinks["Minor", 3] = "0.100 -0.039 Random BreachSet_Small";
   breachLinks["Minor", 4] = "-0.131 -0.216 Random BreachSet_Small";
   breachLinks["Minor", 5] = "-0.068 0.275 Random BreachSet_Small";
   breachLinks["Minor", 6] = "0.340 0.098 Random BreachSet_Small";
   breachLinks["Minor", 7] = "-0.010 0.501 Random BreachSet_Small";
   breachLinks["Minor", 8] = "-0.440 0.246 Random BreachSet_Small";
   
   breachLinks["Major", 1] = "-0.340 -0.560 Random BreachSet_Huge";
   breachLinks["Major", 2] = "-0.157 -0.442 Random BreachSet_Huge"; 
   breachLinks["Major", 3] = "0.210 -0.491 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0.251 0.260 2 ZombieEggBase";     
   
   hullTypeXPMult = 2.0;
};
