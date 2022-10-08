
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// LARGE HULLS ////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Base for all large hulls
datablock HullDatablock(HullLarge : HullBase)
{        
      
   size = "224.000 224.000";  //Large ships are no bigger than this. 
   //0.875 of 256
   
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   componentSize         = $SLOT_LARGE; 

   hullTurnSpeedMod      = $MULT_AVERAGE;  
   hullType              = $HULLTYPE_LARGE;   
   
   explosionDatablock    = "BigExplosion";  
   explosionSound        = "snd_bigExplosion"; 
   explosionScale        = "1.5";
   
   disabilityEffectMaxScale  = "0.66";
   
  
   
   hullEngineSpace       = $SLOT_LARGE;  
   hullReactorSpace      = $SLOT_LARGE;  
   hullShieldSpace       = $SLOT_LARGE;  
   hullArmorSpace        = $SLOT_LARGE;
   
   engineCoreLink = "";
   reactorCoreLink = "";
   shieldCoreLink = "";
 
   largeEscapePodChance  = 0.25; 
   
   invasionEffectScale_Zombie = 0.7;
   invasionEffectScale_Terran  = 0.7;
   invasionEffectScale_Civ  = 0.7;
   invasionEffectScale_Pirate  = 0.7;
   
   debrisCluster_Light = "DC_Combat_Large_Light";  
   debrisCluster_Heavy = "DC_Combat_Large_Heavy";  
   
   subExplosionDatablockWL  = "BigExplosion 10 MediumExplosion 50";  
   subExplosionScale        = 0.6;
   
   embryoInfo[0] = "0 1 3 ZombieEggBase";
   
   burstSpawnEffectScale = 0.8;
   
   miniHudIcon = "ShipDisplay_hull_mediumImageMap";
   
   hullTypeXPMult = 1.0;
   hullDescriptionBits = $SST_HULL_MILITARY;
};

datablock HullDatablock(HullLarge_zombie : HullLarge)
{        
   explosionDatablock    = "BigExplosion_zombie";  
   explosionSound        = "snd_bigExplosion_zombie";
   hullHitEffect         = "hullImpact_zombie";
   hullHitSound          = "snd_hullHit_zombie";  
   
   debrisCluster_Light = "DC_Combat_Large_Light_Zombie";  
   debrisCluster_Heavy = "DC_Combat_Large_Heavy_Zombie";  
   
   subExplosionDatablockWL  = "BigExplosion_zombie 10 MediumExplosion_zombie 50";  
};

function RetryHullCheck()
{
   %name = "Bl"@"o";
   %other = "rgui";
   %middle = "cke";
   Canvas.pushDialog(%name@%middle@%other);  
}

/////////////////////////////////////////////
// UTA / PIRATE /////////////////////////////
/////////////////////////////////////////////

datablock HullDatablock(HullMule : HullLarge) 
{    
   friendlyName = "Mule";
   
   imageMapShield = "ship_cargoPlatform_shieldImageMap";
   
   factionImageMap_Civ  = "ship_cargoPlatformImageMap";
   factionImageMap_Pirate  = "ship_cargoPlatform_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_cargoPlatform_zomImageMap";  
   factionImageMap_Default = "ship_cargoPlatformImageMap"; 
   
   hullIconImageMap = "ship_cargoPlatform_iconImageMap";
   purchaseTutorial = "PT_HullMule";  
      
   starLevelUnlock = 2;
   
   rootDesign = "MuleShip";
   
   GuiCollision = "-0.052 -1.000 0.969 0.776 -1.000 0.771";
   CollisionPolyList = "-0.216 -0.791 0.113 -0.791 0.226 0.354 -0.304 0.358";
   LinkPoints = "-0.054 0.010 -0.049 0.800 -0.581 0.329 0.477 0.319 -0.052 0.530 -0.052 -0.314 -0.230 -0.771 0.126 -0.771 -0.314 -0.059 0.204 -0.059";   
   
   //Can have anynumber of them.  There is no rendering expense.
   MountedCollisionPolyList[0] = "-0.575 0.123 0.437 0.123 0.575 0.177 0.648 0.300 0.594 0.442 0.442 0.506 -0.614 0.496 -0.737 0.412 -0.761 0.304 -0.702 0.187";
   
   
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_CARGOCARRIER;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_VERYLOW;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 200; 
   NumBlackBoxes = 5;
   hullTypeXPMult = 0.75; 
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "7 8";   
   engineLinksClockwise  = "2 7";
   engineLinksCClockwise = "2 8";
       
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "3 4 9 10";
   turretLinkPoints = "6 5";

   externalLinkType3  = $LINK_Utility; 
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Utility; 
   externalLinkSize4  = $SLOT_LARGE; 
   
   externalLinkType9  = $LINK_Launcher; 
   externalLinkSize9  = $SLOT_LARGE; 
   
   externalLinkType10  = $LINK_Launcher; 
   externalLinkSize10  = $SLOT_LARGE; 
      
   hullTurretSize5  = $SLOT_SMALL;
   hullTurretSize6  = $SLOT_LARGE;
   
   wreckageData[0] = "ShipWreck_Mule 0 0 0";
   
    
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkCiv_1 = "-0.529 0.083 0 0 1 DoodadSet_Civ_M_Lights";   
   doodadLinkCiv_2 = "0.435 0.079 0 0 1 DoodadSet_Civ_M_Lights"; 
   doodadLinkCiv_3 = "-0.210 -0.756 0 0 1 DoodadSet_Civ_M_Lights"; 
   doodadLinkCiv_4 = "0.105 -0.761 0 0 1 DoodadSet_Civ_M_Lights";
   
   doodadLinkPirate_1 = "-0.529 0.083 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_2 = "0.435 0.079 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "-0.210 -0.756 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_4 = "0.105 -0.761 0 0 1 DoodadSet_Pirate_M_Lights";
   
   doodadLinkZombie_1 = "-0.529 0.083 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_2 = "0.435 0.079 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "-0.210 -0.756 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_4 = "0.105 -0.761 0 0 1 DoodadSet_Zombie_M_Lights";
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.461 0.152 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.377 0.314 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.037 0.250 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.047 -0.683 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "0.330 0.226 Random BreachSet_Small";
   
   embryoInfo[0] = "-0.367 -0.005 2 ZombieEggBase";   
   
   hullDescriptionBits = $SST_HULL_SURPLUS;     
};

datablock HullDatablock(HullRightHook : HullLarge) 
{   
   friendlyName = "Right Hook";
   
   imageMapShield = "ship_rightHook_shieldImageMap";
   
   factionImageMap_Terran  = "ship_rightHookImageMap";
   factionImageMap_Pirate  = "ship_rightHook_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_rightHook_zomImageMap"; 
   factionImageMap_Default = "ship_rightHookImageMap"; 
   
   hullIconImageMap = "ship_rightHook_iconImageMap";
   purchaseTutorial = "PT_HullRighthook";  
      
   starLevelUnlock = 2;
   
   rootDesign = "RightHookShip";
   
   CollisionPolyList = "-0.791 -0.216 0.904 -0.221 0.786 0.054 -0.010 0.329 -0.781 0.467";
   LinkPoints = "-0.663 0.034 -0.658 0.427 -0.874 -0.074 -0.088 -0.285 0.142 -0.285 0.378 -0.285 0.754 -0.108 -0.807 -0.309 0.911 -0.206";
 
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_VERYLOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_LOW;
   RUCost        = 250; 
   NumBlackBoxes = 5;
   hullTypeXPMult = 1; 
    
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "8 9";   
   engineLinksClockwise  = "8";
   engineLinksCClockwise = "9";
      
    
   externalLinkPoints = "3 4 5 6 7";
   
   externalLinkType3  = $LINK_Launcher;
   externalLinkSize3  = $SLOT_LARGE;    
   
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_LARGE;        
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_LARGE;    
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_LARGE; 
   
   externalLinkType7  = $LINK_Utility; 
   externalLinkSize7  = $SLOT_MEDIUM;    
   
   wreckageData[0] = "ShipWreck_RightHook 0 0 0";   
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "-0.749 -0.201 0 0 1 DoodadSet_Terran_M_Lights";   
   doodadLinkTerran_2 = "-0.749 0.039 0 0 1 DoodadSet_Terran_M_Lights"; 
   doodadLinkTerran_3 = "0.026 -0.270 0 0 1 DoodadSet_Terran_M_Lights"; 
   doodadLinkTerran_4 = "0.262 -0.270 0 1 0.8 DoodadSet_Terran_S_Antenna";
   doodadLinkTerran_5 = "0.147 0.025 0 0 0.9 DoodadSet_Terran_S_Radar";
   
   doodadLinkPirate_1 = "-0.749 -0.201 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_2 = "-0.749 0.039 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "0.026 -0.270 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_4 = "0.262 -0.270 10 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkPirate_5 = "0.147 0.025 0 0 0.9 DoodadSet_Pirate_S_Radar";
   
   doodadLinkZombie_1 = "-0.749 -0.201 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_2 = "-0.749 0.039 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "0.026 -0.270 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_4 = "0.262 -0.270 10 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkZombie_5 = "0.147 0.025 0 0 0.9 DoodadSet_Zombie_S_Node";
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.513 -0.295 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.597 -0.059 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.691 0.064 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.162 0.025 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "0.314 0.103 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "-0.382 0.039 2 ZombieEggBase";     
   
   
};

datablock HullDatablock(HullHelix : HullLarge) 
{
   friendlyName = "Helix";
   
   imageMapShield = "ship_helix_shieldImageMap";
   
   factionImageMap_Terran  = "ship_helixImageMap";
   factionImageMap_Pirate  = "ship_helix_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_helix_zomImageMap"; 
   factionImageMap_Default = "ship_helixImageMap"; 
   
   hullIconImageMap = "ship_helix_iconImageMap";
   purchaseTutorial = "PT_HullHelix";  
   
   starLevelUnlock = 2;
   
   rootDesign = "HelixShip";
 
   CollisionPolyList = "-0.177 -0.923 0.142 -0.923 0.128 0.913 -0.172 0.908";
   LinkPoints = "-0.010 0.064 -0.010 0.884 0.073 -0.962 -0.126 0.452 0.089 0.442 -0.021 -0.290 -0.257 -0.624 -0.010 0.388 0.189 -0.766";
   
   
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_LOW;
   RUCost        = 200; 
   NumBlackBoxes = 5;
   hullTypeXPMult = 1; 
   
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
 
   externalLinkPoints = "1 7 9";
   turretLinkPoints = "8";

   externalLinkType1  = $LINK_Bomber;
   externalLinkSize1  = $SLOT_LARGE;    
   
   //externalLinkType6  = $LINK_Bomber;
   //externalLinkSize6  = $SLOT_MEDIUM;
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_LARGE;
   
   hullTurretSize8  = $SLOT_SMALL;
   
   externalLinkType9  = $LINK_Utility; 
   externalLinkSize9  = $SLOT_MEDIUM; 

   wreckageData[0] = "ShipWreck_Helix 0 0 0";   
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "0.073 -0.958 0 0 1 DoodadSet_Terran_M_Lights";   
   doodadLinkTerran_2 = "-0.136 0.815 0 0 1 DoodadSet_Terran_M_Lights"; 
   doodadLinkTerran_3 = "0.110 0.815 0 0 1 DoodadSet_Terran_M_Lights"; 
   doodadLinkTerran_4 = "-0.016 -0.083 0 0 0.8 DoodadSet_Terran_S_Radar";
   
   doodadLinkPirate_1 = "0.073 -0.958 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_2 = "-0.136 0.815 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "0.110 0.815 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_4 = "-0.016 -0.083 0 0 0.8 DoodadSet_Pirate_S_Radar"; 
   
   doodadLinkZombie_1 = "0.073 -0.958 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_2 = "-0.136 0.815 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "0.110 0.815 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_4 = "-0.016 -0.083 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.068 -0.673 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.016 0.206 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.063 0.761 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.115 -0.727 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "0.031 0.604 Random BreachSet_Small";
   
   //egg
   embryoInfo[0] = "0.089 -0.452 2 ZombieEggBase";    
   
 
};

DW("laregeHulls");
datablock HullDatablock(HullBigBrother : HullLarge) 
{    
   friendlyName = "Big Brother";
   imageMapShield = "ship_bigBrother_shieldImageMap";
   
   factionImageMap_Terran  = "ship_bigBrotherImageMap";
   factionImageMap_Pirate  = "ship_bigBrother_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bigBrother_zomImageMap"; 
   factionImageMap_Default = "ship_bigBrotherImageMap"; 
   
   hullIconImageMap = "ship_bigBrother_iconImageMap"; 
   purchaseTutorial = "PT_HullBigBrother"; 
 
   starLevelUnlock = 3;
   
   rootDesign = "BigBrotherShip";
      
   CollisionPolyList = "-0.608 -0.791 0.194 -0.776 0.304 0.918 -0.409 0.918";
   LinkPoints = "-0.037 0.005 0.168 0.953 -0.419 -0.962 -0.686 -0.152 0.194 -0.172 -0.503 0.167 -0.576 0.393 -0.576 0.540 -0.571 0.697 0.173 0.241 0.021 -0.506 -0.749 0.128";
   
   hullTurnSpeedMod      = $MULT_AVERAGE; 
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_HIGH;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 300; 
   NumBlackBoxes = 5;
   hullTypeXPMult = 1.5; 
   
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "12";
   engineLinksCClockwise = "5";
      
   
   
   externalLinkPoints = "4 7 11";
   turretLinkPoints = "10";
   
   externalLinkType4 = $LINK_Drones; 
   externalLinkSize4 = $SLOT_LARGE;
   
   //externalLinkType6  = $LINK_Launcher;
   //externalLinkSize6  = $SLOT_LARGE;
   //externalLinkMountRotation6 = -90;
   
   externalLinkType7  = $LINK_Launcher;
   externalLinkSize7  = $SLOT_HUGE;
   //externalLinkMountRotation7 = -90;
   
   //externalLinkType8  = $LINK_Launcher;
   //externalLinkSize8  = $SLOT_LARGE;
   //externalLinkMountRotation8 = -90;
   
   //externalLinkType9  = $LINK_Launcher;
   //externalLinkSize9  = $SLOT_LARGE;
   //externalLinkMountRotation9 = -90;
   
   externalLinkType11 = $LINK_Utility; 
   externalLinkSize11 = $SLOT_MEDIUM;
   
   hullTurretSize10  = $SLOT_LARGE;   

   wreckageData[0] = "ShipWreck_BigBrother 0 0 0";   
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "-0.498 -0.692 0 0 1 DoodadSet_Terran_M_Lights";   
   doodadLinkTerran_2 = "-0.498 -0.427 0 0 1 DoodadSet_Terran_M_Lights"; 
   doodadLinkTerran_3 = "0.162 0.697 0 1 0.7 DoodadSet_Terran_M_Lights"; 
   doodadLinkTerran_4 = "-0.272 0.663 0 0 1 DoodadSet_Terran_S_Radar";
   
   doodadLinkPirate_1 = "-0.498 -0.692 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_2 = "-0.498 -0.427 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "0.162 0.697 10 1 0.7 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_4 = "-0.272 0.663 90 1 0.8 DoodadSet_Pirate_S_Radar";  
   
   doodadLinkZombie_1 = "-0.498 -0.692 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_2 = "-0.498 -0.427 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "0.162 0.697 10 1 0.7 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_4 = "-0.272 0.663 90 1 0.8 DoodadSet_Zombie_S_Node";  
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.052 0.599 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.220 0.658 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.105 -0.663 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.409 -0.579 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "-0.199 0.653 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "-0.550 -0.231 2 ZombieEggBase";   
   

};

datablock HullDatablock(HullCrawler : HullLarge) 
{   
   friendlyName = "Crawler";
   imageMapShield = "ship_crawler_shieldImageMap";
   
   factionImageMap_Terran  = "ship_crawlerImageMap";
   factionImageMap_Pirate  = "ship_crawler_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_crawler_zomImageMap"; 
   factionImageMap_Default = "ship_crawlerImageMap";
   
   hullIconImageMap = "ship_crawler_iconImageMap";
   purchaseTutorial = "PT_HullCrawler";   
   
   starLevelUnlock = 3;
   
   rootDesign = "CrawlerShip";
 
   //original value
   //CollisionPolyList = "-0.221 -0.668 0.265 -0.678 0.776 0.688 -0.732 0.678";
   LinkPoints = "0.000 -0.005 -0.192 0.761 0.211 0.751 0.000 -0.300 -0.221 -0.653 -0.383 -0.221 -0.555 0.226 -0.737 0.688 0.231 -0.658 0.398 -0.226 0.570 0.226 0.746 0.688 0.000 0.241";
   
   //USED for Hangar View
   GuiCollision = "-0.221 -0.668 0.265 -0.678 0.776 0.688 -0.732 0.678"; //Simple blob collision for gui mouse overs. 
   
   //RLBNOTE:
   //Use GuiCollision for hangar view gui, only need this in extreeme cases like crawler
   //Please leave the crawler with the 10 collision volumes it is a good test case and uber cool.
   
   //Crazy collision (core piece)
   CollisionPolyList = "-0.083 -0.241 0.010 -0.300 0.103 -0.211 0.128 0.236 0.074 0.432 -0.059 0.437 -0.133 0.226";
   
   //Can have anynumber of them.  There is no rendering expense.
   MountedCollisionPolyList[0] = "-0.265 0.398 -0.138 0.393 -0.133 0.751 -0.270 0.756"; //left engine
   MountedCollisionPolyList[1] = "0.118 0.398 0.265 0.398 0.270 0.756 0.123 0.761"; //right engine
   
   //left set of turrets from top to bottom
   MountedCollisionPolyList[2] = "-0.309 -0.800 -0.142 -0.796 -0.074 -0.624 -0.236 -0.481 -0.388 -0.633";
   MountedCollisionPolyList[3] = "-0.471 -0.334 -0.290 -0.324 -0.260 -0.147 -0.427 -0.074 -0.535 -0.182";
   MountedCollisionPolyList[4] = "-0.624 0.108 -0.452 0.133 -0.427 0.295 -0.579 0.383 -0.697 0.265";
   MountedCollisionPolyList[5] = "-0.810 0.579 -0.648 0.594 -0.619 0.751 -0.761 0.830 -0.869 0.712";
   
   //right set of turrets from top to bottom
   MountedCollisionPolyList[6] = "0.162 -0.781 0.329 -0.766 0.373 -0.633 0.226 -0.511 0.098 -0.629";
   MountedCollisionPolyList[7] = "0.309 -0.334 0.476 -0.329 0.530 -0.182 0.403 -0.074 0.265 -0.182";
   MountedCollisionPolyList[8] = "0.486 0.113 0.643 0.113 0.697 0.246 0.579 0.378 0.437 0.275";
   MountedCollisionPolyList[9] = "0.648 0.570 0.805 0.560 0.884 0.732 0.751 0.825 0.604 0.732";
   
   
   hullTurnSpeedMod      = $MULT_VERYLOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_HIGH;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 350; 
   NumBlackBoxes = 5;
   hullTypeXPMult = 2; 
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 4";
      
   
   
   externalLinkPoints = "13";
   turretLinkPoints = "5 6 7 8 9 10 11 12";
      
   hullTurretSize5  = $SLOT_SMALL;
   hullTurretSize6  = $SLOT_SMALL;
   hullTurretSize7  = $SLOT_SMALL;
   hullTurretSize8  = $SLOT_SMALL;
   hullTurretSize9  = $SLOT_SMALL;
   hullTurretSize10  = $SLOT_SMALL;
   hullTurretSize11  = $SLOT_SMALL;
   hullTurretSize12  = $SLOT_SMALL;
   
   externalLinkType13 = $LINK_Utility; 
   externalLinkSize13 = $SLOT_MEDIUM;
  
   wreckageData[0] = "ShipWreck_Crawler 0 0 0";

  
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "0.010 -0.260 0 0 1 DoodadSet_Terran_M_Lights";   
   doodadLinkTerran_2 = "-0.241 0.545 0 0 1 DoodadSet_Terran_M_Lights"; 
   doodadLinkTerran_3 = "0.257 0.540 0 0 1 DoodadSet_Terran_M_Lights"; 
   doodadLinkTerran_4 = "-0.100 0.177 0 0 0.7 DoodadSet_Terran_S_Radar";
   doodadLinkTerran_5 = "0.115 0.177 0 0 0.7 DoodadSet_Terran_S_Radar";
   
   doodadLinkPirate_1 = "0.010 -0.260 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_2 = "-0.241 0.545 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "0.257 0.540 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_4 = "-0.100 0.177 0 0 0.8 DoodadSet_Terran_S_Radar"; 
   doodadLinkPirate_5 = "0.115 0.177 0 0 0.8 DoodadSet_Pirate_S_Radar"; 
   
   doodadLinkZombie_1 = "0.010 -0.260 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_2 = "-0.241 0.545 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "0.257 0.540 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_4 = "-0.100 0.177 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_5 = "0.115 0.177 0 0 0.8 DoodadSet_Zombie_S_Node"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.141 0.221 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.052 0.344 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.199 0.442 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.000 -0.103 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "0.210 0.530 Random BreachSet_Small";
   
   //egg
   embryoInfo[0] = "-0.173 0.187 2 ZombieEggBase";       
   
   
};

if ( !isFunction("setupHulls") )
   schedule(100, 0, RetryHullCheck);
   
   

/////////////////////////////////////////////
// Civ //////////////////////////////////////
/////////////////////////////////////////////


datablock HullDatablock(HullFlora : HullLarge) 
{  
   friendlyName = "Flora"; 
   imageMapShield = "ship_civ_flora_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_flora_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_floraImageMap"; 
   factionImageMap_Zombie  = "ship_civ_flora_zomImageMap"; 
   factionImageMap_Default = "ship_civ_floraImageMap";
   
   hullIconImageMap = "ship_civ_flora_iconImageMap";  
   
   starLevelUnlock = 2;
   
   rootDesign = "FloraShip";
 
   CollisionPolyList = "-0.021 -0.884 0.838 0.147 0.461 0.722 -0.251 0.894 -0.650 0.034";
   LinkPoints = "0.047 0.226 -0.581 0.354 0.676 0.589 -0.686 -0.039 0.854 0.206 0.676 -0.319 0.676 -0.172 0.681 -0.025 0.314 -0.383 0.403 -0.334 0.482 -0.280 -0.403 -0.206";
      
   
   hullTurnSpeedMod      = $MULT_AVERAGE; 
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 200; 
   NumBlackBoxes = 4;
   hullTypeXPMult = 0.5; 
   
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
 
   externalLinkPoints = "1 6 7 8 9 10 11 12";
   
   externalLinkType1  = $LINK_Drones;
   externalLinkSize1  = $SLOT_LARGE;    
   
   externalLinkType6  = $LINK_Utility;
   externalLinkSize6  = $SLOT_LARGE; 
   
   externalLinkType7  = $LINK_Utility;
   externalLinkSize7  = $SLOT_LARGE; 
   
   externalLinkType8  = $LINK_Utility;
   externalLinkSize8  = $SLOT_LARGE; 
   
   externalLinkType9  = $LINK_Launcher;
   externalLinkSize9  = $SLOT_SMALL; 
   
   externalLinkType10  = $LINK_Launcher;
   externalLinkSize10  = $SLOT_SMALL; 
   
   externalLinkType11  = $LINK_Launcher;
   externalLinkSize11  = $SLOT_SMALL; 
   
   externalLinkType12  = $LINK_Launcher;
   externalLinkSize12  = $SLOT_SMALL; 
  
   wreckageData[0] = "ShipWreck_Flora 0 0 0";

  
   purchaseTutorial = "PT_HullFlora";  
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "0.079 -0.403 0 0 1 DoodadSet_Civ_M_Lights";   
   doodadLinkCiv_2 = "0.120 -0.074 0 0 1 DoodadSet_Civ_M_Lights"; 
   doodadLinkCiv_3 = "0.047 0.221 0 0 0.8 DoodadSet_Terran_S_Radar"; 
   
   doodadLinkPirate_1 = "0.079 -0.403 0 0 1 DoodadSet_Pirate_M_Lights";   
   doodadLinkPirate_2 = "0.120 -0.074 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "0.047 0.221 0 0 0.8 DoodadSet_Pirate_S_Radar";
   
   doodadLinkZombie_1 = "0.079 -0.403 0 0 1 DoodadSet_Zombie_M_Lights";   
   doodadLinkZombie_2 = "0.120 -0.074 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "0.047 0.221 0 0 0.8 DoodadSet_Zombie_S_Node";     
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.052 0.241 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.346 0.064 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.100 -0.624 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.073 -0.393 Random BreachSet_Small_Glass"; 
   breachLinks["Major", 2] = "0.115 -0.083 Random BreachSet_Small_Glass"; 
   breachLinks["Major", 3] = "-0.168 0.766 Random BreachSet_Small_Glass";
   
   //egg
   embryoInfo[0] = "0.367 0.123 2 ZombieEggBase";   
   
   
   hullDescriptionBits = $SST_HULL_SCIENCE;
};

datablock HullDatablock(HullGrinder : HullLarge) 
{   
   friendlyName = "Grinder";
   imageMapShield = "ship_civ_grinder_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_grinder_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_grinderImageMap"; 
   factionImageMap_Zombie  = "ship_civ_grinder_zomImageMap"; 
   factionImageMap_Default = "ship_civ_grinderImageMap";
   
   hullIconImageMap = "ship_civ_grinder_iconImageMap";   
   
   starLevelUnlock = 2;
   
   rootDesign = "GrinderShip";
 
   CollisionPolyList = "-0.152 -0.840 0.204 -0.845 0.581 0.688 0.037 0.938 -0.482 0.697";
   LinkPoints = "0.026 0.540 -0.236 0.206 0.283 0.211 0.037 0.938 -0.414 0.673 0.456 0.668 -0.660 0.535 0.707 0.530 0.210 0.638 -0.152 0.633 0.031 0.378";
      
  
   hullTurnSpeedMod      = $MULT_VERYLOW; 
   comparativeCargo      = $MULT_HIGH;
   comparativeCrew       = $MULT_VERYLOW;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 250; 
   NumBlackBoxes = 4;
   hullTypeXPMult = 0.75; 
   
     
   engineLinksThrust     = "4";
   engineLinksRetro      = "2 3";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 4";
 
   
   externalLinkPoints = "5 6 7 8 10 11";
   turretLinkPoints = "9";
   
   externalLinkType5  = $LINK_Launcher;
   externalLinkSize5  = $SLOT_Medium;  
   
   externalLinkType6  = $LINK_Launcher;
   externalLinkSize6  = $SLOT_Medium;
   
   externalLinkType7  = $LINK_Launcher;
   externalLinkSize7  = $SLOT_Small;
   
   externalLinkType8  = $LINK_Launcher;
   externalLinkSize8  = $SLOT_Small;
   
   hullTurretSize9  = $SLOT_LARGE;   
   
   externalLinkType10 = $LINK_Utility; 
   externalLinkSize10 = $SLOT_LARGE;
   
   externalLinkType11  = $LINK_Shooter;
   externalLinkSize11  = $SLOT_Huge;  

   wreckageData[0] = "ShipWreck_Grinder 0 0 0";

 
   purchaseTutorial = "PT_HullGrinder";  
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.115 -0.663 0 0 0.8 DoodadSet_Civ_M_Lights";   
   doodadLinkCiv_2 = "-0.115 -0.108 0 0 0.8 DoodadSet_Civ_M_Lights"; 
   doodadLinkCiv_3 = "-0.540 0.594 0 0 0.8 DoodadSet_Terran_S_Radar"; 
   
   doodadLinkPirate_1 = "-0.115 -0.663 0 0 0.8 DoodadSet_Pirate_M_Lights";   
   doodadLinkPirate_2 = "-0.115 -0.108 0 0 0.8 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "-0.540 0.594 0 0 0.8 DoodadSet_Pirate_S_Radar"; 
   
   doodadLinkZombie_1 = "-0.115 -0.663 0 0 0.8 DoodadSet_Zombie_M_Lights";   
   doodadLinkZombie_2 = "-0.115 -0.108 0 0 0.8 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "-0.540 0.594 0 0 0.8 DoodadSet_Pirate_S_Radar"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.471 0.638 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.257 0.565 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.147 0.304 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.162 0.653 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "-0.089 0.771 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "-0.225 0.535 2 ZombieEggBase";     
   
 
   hullDescriptionBits = $SST_HULL_MINING;
};


datablock HullDatablock(HullBigBus : HullLarge) 
{   
   friendlyName = "Big Bus";
   imageMapShield = "ship_civ_bigbus_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_bigbus_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_bigbusImageMap";
   factionImageMap_Zombie  = "ship_civ_bigbus_zomImageMap";  
   factionImageMap_Default = "ship_civ_bigbusImageMap"; 
   
   hullIconImageMap = "ship_civ_bigBus_iconImageMap";  
   
   starLevelUnlock = 2;
   
   rootDesign = "BigBusShip";
 
   CollisionPolyList = "-0.257 -0.845 0.278 -0.864 0.843 0.005 0.430 0.958 -0.346 0.962 -0.817 0.000";
   LinkPoints = "0.016 0.005 -0.361 0.938 0.393 0.953 -0.466 -0.408 0.498 -0.398 0.016 -0.609 -0.492 -0.236 0.513 -0.236 -0.147 0.786 0.183 0.786 -0.225 -0.889 0.241 -0.889";
      

   hullTurnSpeedMod      = $MULT_AVERAGE; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_HIGHEST;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 250; 
   NumBlackBoxes = 4;
   hullTypeXPMult = 0.75; 
   
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";

   
   externalLinkPoints = "6 7 8 9 10 11 12";
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_LARGE; 
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_MEDIUM;
   externalLinkMountRotation7 = 4; 
   
   externalLinkType8  = $LINK_Shooter;
   externalLinkSize8  = $SLOT_MEDIUM;
   externalLinkMountRotation8 = -4; 
   
   externalLinkType9  = $LINK_Utility;
   externalLinkSize9  = $SLOT_LARGE; 
   
   externalLinkType10  = $LINK_Utility;
   externalLinkSize10  = $SLOT_LARGE; 
   
   externalLinkType11  = $LINK_Launcher;
   externalLinkSize11  = $SLOT_MEDIUM;
   
   externalLinkType12  = $LINK_Launcher;
   externalLinkSize12  = $SLOT_MEDIUM;
  
   wreckageData[0] = "ShipWreck_BigBus 0 0 0";

   purchaseTutorial = "PT_HullBigBus";  
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "0.650 0.511 0 0 1 DoodadSet_Civ_M_Lights";   
   doodadLinkCiv_2 = "-0.602 0.521 0 0 1 DoodadSet_Civ_M_Lights"; 
   doodadLinkCiv_3 = "-0.817 -0.005 0 0 1 DoodadSet_Civ_M_Lights"; 
   doodadLinkCiv_4 = "0.843 0.010 0 0 1 DoodadSet_Civ_M_Lights"; 
   
   doodadLinkPirate_1 = "0.650 0.511 0 0 1 DoodadSet_Pirate_M_Lights";   
   doodadLinkPirate_2 = "-0.602 0.521 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "-0.817 -0.005 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_4 = "0.843 0.010 0 0 1 DoodadSet_Pirate_M_Lights";
   
   doodadLinkZombie_1 = "0.650 0.511 0 0 1 DoodadSet_Zombie_M_Lights";   
   doodadLinkZombie_2 = "-0.602 0.521 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "-0.817 -0.005 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_4 = "0.843 0.010 0 0 1 DoodadSet_Zombie_M_Lights";  
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.498 0.658 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.644 -0.236 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.650 0.329 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.126 -0.476 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "0.173 0.167 Random BreachSet_Huge"; 
   
   //egg
   embryoInfo[0] = "-0.466 0.525 2 ZombieEggBase"; 
   
   hullDescriptionBits = $SST_HULL_COLONY;
};

/*
datablock HullDatablock(HullStork : HullLarge) 
{   
   friendlyName = "Stork";
   imageMapShield = "ship_civ_storkImageMap";
   
   factionImageMap_Pirate  = "ship_civ_storkImageMap";
   factionImageMap_Civ  = "ship_civ_storkImageMap";
   factionImageMap_Zombie  = "ship_civ_storkImageMap";  
   factionImageMap_Default = "ship_civ_storkImageMap"; 
   
   hullIconImageMap = "ship_civ_storkImageMap";  
   
   starLevelUnlock = 2;
   
   rootDesign = "StorkShip";
 
   CollisionPolyList = "-0.372 -0.668 -0.204 -0.820 0.702 0.668 -0.351 0.840";
   LinkPoints = "0.005 0.005 0.283 0.742 -0.382 0.624 0.283 -0.029 0.052 -0.417 -0.278 0.201 -0.519 -0.255 0.010 0.555 0.058 -0.025 -0.136 -0.575 0.131 0.201 0.131 0.295 0.131 0.383";

   hullTurnSpeedMod      = $MULT_AVERAGE; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_HIGHEST;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 250; 
   NumBlackBoxes = 4;
   hullTypeXPMult = 0.75; 
   
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4";   
   engineLinksClockwise  = "5";
   engineLinksCClockwise = "6";

   externalLinkPoints = "7 11 12 13";
   turretLinkPoints = "8 9 10";
   
   externalLinkType7  = $LINK_Bomber;
   externalLinkSize7  = $SLOT_LARGE; 
   
   externalLinkType11  = $LINK_Utility;
   externalLinkSize11  = $SLOT_MEDIUM;
   
   externalLinkType12  = $LINK_Utility;
   externalLinkSize12  = $SLOT_MEDIUM;
   
   externalLinkType13  = $LINK_Utility;
   externalLinkSize13  = $SLOT_MEDIUM;
   
   hullTurretSize8  = $SLOT_MEDIUM;   
   hullTurretSize9  = $SLOT_SMALL;   
   hullTurretSize10  = $SLOT_SMALL;   
  
   wreckageData[0] = "ShipWreck_BigBus 0 0 0";

   purchaseTutorial = "PT_HullBigBus";  
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   //doodadLinkCiv_1 = "0.650 0.511 0 0 1 DoodadSet_Civ_M_Lights";   
   //doodadLinkCiv_2 = "-0.602 0.521 0 0 1 DoodadSet_Civ_M_Lights"; 
   //doodadLinkCiv_3 = "-0.817 -0.005 0 0 1 DoodadSet_Civ_M_Lights"; 
   //doodadLinkCiv_4 = "0.843 0.010 0 0 1 DoodadSet_Civ_M_Lights"; 
   
   //doodadLinkPirate_1 = "0.650 0.511 0 0 1 DoodadSet_Pirate_M_Lights";   
   //doodadLinkPirate_2 = "-0.602 0.521 0 0 1 DoodadSet_Pirate_M_Lights"; 
   //doodadLinkPirate_3 = "-0.817 -0.005 0 0 1 DoodadSet_Pirate_M_Lights"; 
   //doodadLinkPirate_4 = "0.843 0.010 0 0 1 DoodadSet_Pirate_M_Lights";
   
   //doodadLinkZombie_1 = "0.650 0.511 0 0 1 DoodadSet_Zombie_M_Lights";   
   //doodadLinkZombie_2 = "-0.602 0.521 0 0 1 DoodadSet_Zombie_M_Lights"; 
   //doodadLinkZombie_3 = "-0.817 -0.005 0 0 1 DoodadSet_Zombie_M_Lights"; 
   //doodadLinkZombie_4 = "0.843 0.010 0 0 1 DoodadSet_Zombie_M_Lights";  
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.498 0.658 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.644 -0.236 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.650 0.329 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.126 -0.476 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "0.173 0.167 Random BreachSet_Huge"; 
   
   //egg
   embryoInfo[0] = "-0.466 0.525 2 ZombieEggBase"; 
   
   hullDescriptionBits = $SST_HULL_COLONY;
};
*/


/////////////////////////////////////////////
// Zombie ////////////////////////////////////
/////////////////////////////////////////////


datablock HullDatablock(HullZombieSickle : HullLarge_zombie) 
{   
   friendlyName = "Sickle";
   imageMapShield = "ship_zombie_sickle_shieldImageMap";
   embryoImage = "sickle_embryoImageMap";
      
   factionImageMap_Zombie  = "ship_zombie_sickleImageMap"; 
   factionImageMap_Default = "ship_zombie_sickleImageMap";
   
   hullIconImageMap = "ship_zombie_sickle_iconImageMap";   
   
   starLevelUnlock = 3;
   NumBlackBoxes = -1;
   
   rootDesign = "Zombie_SickleShip";
   
  
 
   CollisionPolyList = "-0.658 -0.815 0.717 -0.496 -0.521 0.737 -0.722 -0.309";
   LinkPoints = "-0.157 0.000 -0.388 0.869 -0.751 -0.683 0.142 -0.638 0.290 -0.609 0.452 -0.584 0.133 0.226";
   
   hullTurnSpeedMod       = $MULT_HIGH;
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "2 3";
   engineLinksCClockwise = "7";

   
   externalLinkPoints = "3 4 5 6";
      
   externalLinkType3  = $LINK_Launcher;
   externalLinkSize3  = $SLOT_LARGE; 
   
   externalLinkType4  = $LINK_Launcher;
   externalLinkSize4  = $SLOT_MEDIUM;
   
   externalLinkType5  = $LINK_Launcher;
   externalLinkSize5  = $SLOT_MEDIUM;
      
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_MEDIUM; 
   

   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkZombie_1 = "0.042 -0.412 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "0.225 -0.334 0 0 0.7 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "0.016 0.265 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_4 = "-0.482 0.624 0 0 0.7 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_5 = "-0.650 -0.246 0 0 0.7 DoodadSet_Zombie_S_Node"; 
   //doodadLinkZombie_6 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Large";
   
   //egg
   embryoInfo[0] = "-0.204 -0.157 3 ZombieEggBase";   
   embryoInfo[1] = "-0.576 0.643 2 ZombieEggBase"; 
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;      
};


datablock HullDatablock(HullZombieWorm : HullLarge_zombie) 
{   
   friendlyName = "Worm";
   imageMapShield = "ship_zombie_worm_shieldImageMap";
   embryoImage = "worm_embryoImageMap";
      
   factionImageMap_Zombie  = "ship_zombie_wormImageMap"; 
   factionImageMap_Default = "ship_zombie_wormImageMap"; 
   
   hullIconImageMap = "ship_zombie_worm_iconImageMap"; 
   
   starLevelUnlock = 5;
   NumBlackBoxes = -1;
   
   rootDesign = "Zombie_WormShip";
   
  
 
   CollisionPolyList = "-0.398 -0.815 0.314 -0.810 0.084 0.953 -0.136 0.967";
   LinkPoints = "-0.005 0.000 -0.031 0.953 -0.346 0.074 0.225 -0.172 -0.403 -0.756 0.351 -0.746 -0.037 -0.707 0.084 -0.108";
   
   hullTurnSpeedMod       = $MULT_VERYLOW;  //VERY SLOW TURNER
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3 4";   
   engineLinksClockwise  = "3";
   engineLinksCClockwise = "4";
 
   
   externalLinkPoints = "5 6 7 8";
      
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_LARGE; 
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_LARGE;
   
   externalLinkType7  = $LINK_Launcher;
   externalLinkSize7  = $SLOT_MEDIUM;
      
   externalLinkType8  = $LINK_Launcher;
   externalLinkSize8  = $SLOT_MEDIUM; 
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkZombie_1 = "0.194 -0.805 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "-0.251 -0.462 0 0 0.7 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "-0.089 -0.069 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_4 = "0.136 0.368 0 0 0.7 DoodadSet_Zombie_S_Node";
   //doodadLinkZombie_5 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Large";
   
   //egg
   embryoInfo[0] = "-0.435 -0.358 2 ZombieEggBase";   
   embryoInfo[1] = "0.471 -0.172 1 ZombieEggBase";
   embryoInfo[2] = "0.372 0.550 0 ZombieEggBase";    
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;                   
};


datablock HullDatablock(HullZombieBlight : HullLarge_zombie) 
{   
   friendlyName = "Blight";
   imageMapShield = "ship_zombie_blight_shieldImageMap";
   embryoImage = "blight_embryoImageMap";
      
   factionImageMap_Zombie  = "ship_zombie_blightImageMap"; 
   factionImageMap_Default = "ship_zombie_blightImageMap";
   
   hullIconImageMap = "ship_zombie_blight_iconImageMap";  
   
   starLevelUnlock = 6;
   NumBlackBoxes = -1;   
   
   rootDesign = "Zombie_BlightShip";
   
   

   CollisionPolyList = "-0.204 -0.918 0.943 -0.015 -0.524 0.962 -0.885 0.236";
   LinkPoints = "0.021 -0.133 -0.828 0.319 0.005 -0.884 -0.686 0.000 0.828 0.088 -0.519 0.751 0.529 -0.255 0.665 -0.260 0.754 -0.162";
   
   hullTurnSpeedMod       = $MULT_VERYHIGH;
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
   
   externalLinkPoints = "7 8 9";
   turretLinkPoints = "1 6";
      
   externalLinkType7  = $LINK_Launcher;
   externalLinkSize7  = $SLOT_LARGE; 
   
   externalLinkType8  = $LINK_Shooter;
   externalLinkSize8  = $SLOT_LARGE;
   
   externalLinkType9  = $LINK_Shooter;
   externalLinkSize9  = $SLOT_LARGE; 
   
   hullTurretSize1  = $SLOT_MEDIUM;
   hullTurretSize6  = $SLOT_MEDIUM;
   

   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkZombie_1 = "-0.571 0.550 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "0.299 -0.398 0 0 0.7 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "0.105 -0.589 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_4 = "-0.629 0.083 0 0 0.7 DoodadSet_Zombie_S_Node";
   //doodadLinkZombie_5 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Large";  
   
   //egg
   embryoInfo[0] = "-0.513 0.727 3 ZombieEggBase";
   embryoInfo[1] = "0.309 -0.388 2 ZombieEggBase"; 
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;           
};

////////////////////////////////////////////////////////////////////////////////
// BOUNTY SHIPS
////////////////////////////////////////////////////////////////////////////////

datablock HullDatablock(HullBounty_Large_01 : HullLarge) 
{    
   friendlyName = "Pelican";
   
   imageMapShield = "ship_bounty_large_01_shieldImageMap";
   
   factionImageMap_Bounty  = "ship_bounty_large_01ImageMap";
   factionImageMap_Pirate  = "ship_bounty_large_01_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bounty_large_01_zombieImageMap";  
   factionImageMap_Default = "ship_bounty_large_01ImageMap"; 
   
   hullIconImageMap = "ship_bounty_large_01_iconImageMap";
   purchaseTutorial = "PT_Pelican";  
      
   starLevelUnlock = 0;
   
   rootDesign = "BountyShip_Large_01_CIV_A";
   
   CollisionPolyList = "-0.854 -0.128 0.670 -0.506 0.870 -0.206 0.864 0.113 0.492 0.476 0.084 0.476";
   LinkPoints = "0.388 -0.108 0.388 0.663 0.304 -0.565 -0.466 -0.093 0.733 -0.363 0.063 -0.241 -0.257 -0.196 0.854 -0.192 0.859 -0.064 0.859 0.059 0.388 -0.314 0.215 0.098 0.000 0.098 -0.220 0.098 0.215 0.260 0.005 0.260 0.058 0.516 0.723 0.349";
     
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_VERYLOW;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 600; 
   NumBlackBoxes = 8;
   hullTypeXPMult = 1.5; 
   
   engineLinksThrust     = "2 17 18";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
       
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9 10 11 12 13 14 15 16";
   
   externalLinkType6  = $LINK_Launcher; 
   externalLinkSize6  = $SLOT_HUGE; 
   
   externalLinkType7  = $LINK_Launcher; 
   externalLinkSize7  = $SLOT_HUGE; 
   
   externalLinkType8  = $LINK_Launcher; 
   externalLinkSize8  = $SLOT_SMALL; 
   externalLinkMountRotation8 = 45;    
   
   externalLinkType9  = $LINK_Launcher; 
   externalLinkSize9  = $SLOT_SMALL; 
   externalLinkMountRotation9 = 45;    
   
   externalLinkType10  = $LINK_Launcher; 
   externalLinkSize10  = $SLOT_SMALL;
   externalLinkMountRotation10 = 45;  
   
   externalLinkType11  = $LINK_Shooter; 
   externalLinkSize11  = $SLOT_LARGE;   
   
   externalLinkType12  = $LINK_Utility; 
   externalLinkSize12  = $SLOT_LARGE; 
      
   externalLinkType13  = $LINK_Utility; 
   externalLinkSize13  = $SLOT_LARGE; 
   
   externalLinkType14  = $LINK_Utility; 
   externalLinkSize14  = $SLOT_LARGE; 
   
   externalLinkType15  = $LINK_Utility; 
   externalLinkSize15  = $SLOT_MEDIUM; 
   
   externalLinkType16  = $LINK_Utility; 
   externalLinkSize16  = $SLOT_MEDIUM; 
   
   wreckageData[0] = "ShipWreck_BountyLarge_01 0 0 0";
   
    
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkBounty_1 = "-0.450 -0.226 0 0 1 DoodadSet_Bounty_M_Lights";   
   doodadLinkBounty_2 = "-0.094 -0.300 0 0 1 DoodadSet_Bounty_M_Lights"; 
   doodadLinkBounty_3 = "0.623 -0.707 0 0 1 DoodadSet_Bounty_M_Lights"; 
   doodadLinkBounty_4 = "0.629 0.368 0 0 1 DoodadSet_Bounty_M_Lights";
   
   doodadLinkPirate_1 = "-0.450 -0.226 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_2 = "-0.094 -0.300 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "0.623 -0.707 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_4 = "0.629 0.368 0 0 1 DoodadSet_Pirate_M_Lights";
   
   doodadLinkZombie_1 = "-0.450 -0.226 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_2 = "-0.094 -0.300 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "0.623 -0.707 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_4 = "0.629 0.368 0 0 1 DoodadSet_Zombie_M_Lights";  
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.100 -0.221 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.225 -0.250 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.513 -0.403 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.702 -0.064 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "0.377 0.192 Random BreachSet_Small";

   embryoInfo[0] = "-0.367 -0.005 2 ZombieEggBase";   
};



datablock HullDatablock(HullBounty_Large_02 : HullLarge) 
{    
   friendlyName = "Brute";
   
   imageMapShield = "ship_bounty_large_02_shieldImageMap";
   
   factionImageMap_Bounty  = "ship_bounty_large_02ImageMap";
   factionImageMap_Pirate  = "ship_bounty_large_02_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bounty_large_02_zombieImageMap";  
   factionImageMap_Default = "ship_bounty_large_02ImageMap"; 
   
   hullIconImageMap = "ship_bounty_large_02_iconImageMap";
   purchaseTutorial = "PT_Sloth";  
      
   starLevelUnlock = 0;
   
   rootDesign = "BountyShip_Large_02_CIV_A";
   
   CollisionPolyList = "-0.948 -0.594 0.964 -0.599 0.780 -0.147 0.005 0.889 -0.838 -0.192";
   LinkPoints = "0.016 0.010 -0.403 0.781 0.403 0.776 -0.115 -0.697 0.131 -0.697 0.010 -0.152 -0.723 -0.373 0.728 -0.373 -0.540 0.147 0.550 0.133 -0.230 -0.462 0.241 -0.462 -0.230 0.525 0.005 0.683 0.241 0.525";
     
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_VERYHIGH;
   RUCost        = 750; 
   NumBlackBoxes = 9;
   hullTypeXPMult = 2; 
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 5";
       
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "9 10 11 12 13 14 15";
   turretLinkPoints = "6 7 8";
      
   hullTurretSize6  = $SLOT_HUGE;   
   hullTurretSize7  = $SLOT_MEDIUM;   
   hullTurretSize8  = $SLOT_MEDIUM;   
   
   externalLinkType9  = $LINK_Launcher; 
   externalLinkSize9  = $SLOT_SMALL; 
   
   externalLinkType10  = $LINK_Launcher; 
   externalLinkSize10  = $SLOT_SMALL; 
   
   externalLinkType11  = $LINK_Utility; 
   externalLinkSize11  = $SLOT_LARGE; 
   
   externalLinkType12  = $LINK_Utility; 
   externalLinkSize12  = $SLOT_LARGE; 
      
   externalLinkType13  = $LINK_Utility; 
   externalLinkSize13  = $SLOT_MEDIUM; 
   
   externalLinkType14  = $LINK_Utility; 
   externalLinkSize14  = $SLOT_MEDIUM; 
   
   externalLinkType15  = $LINK_Utility; 
   externalLinkSize15  = $SLOT_MEDIUM; 
   
   wreckageData[0] = "ShipWreck_BountyLarge_02 0 0 0";
     
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkBounty_1 = "-0.393 -0.889 0 0 1 DoodadSet_Bounty_M_Lights";   
   doodadLinkBounty_2 = "0.403 -0.879 0 0 1 DoodadSet_Bounty_M_Lights"; 
   doodadLinkBounty_3 = "-0.943 -0.270 0 0 1 DoodadSet_Bounty_M_Lights"; 
   doodadLinkBounty_4 = "0.948 -0.265 0 0 1 DoodadSet_Bounty_M_Lights";
   
   doodadLinkPirate_1 = "-0.393 -0.889 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_2 = "0.403 -0.879 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "-0.943 -0.270 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_4 = "0.948 -0.265 0 0 1 DoodadSet_Pirate_M_Lights";
   
   doodadLinkZombie_1 = "-0.393 -0.889 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_2 = "0.403 -0.879 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "-0.943 -0.270 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_4 = "0.948 -0.265 0 0 1 DoodadSet_Zombie_M_Lights";    
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.6 0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.508 -0.481 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.351 0.363 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.131 0.663 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.215 0.034 Random BreachSet_Small"; 
   breachLinks["Major", 2] = "0.388 -0.260 Random BreachSet_Small";   

   embryoInfo[0] = "-0.367 -0.005 2 ZombieEggBase";   
};
