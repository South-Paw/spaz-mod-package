
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// MEDIUM HULLS ///////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Base for all medium hulls
datablock HullDatablock(HullMedium : HullBase)
{        
  
   size = "128.000 128.000";  //Medium ships are no bigger than this. 
   
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   componentSize         = $SLOT_MEDIUM;  

   hullTurnSpeedMod      = $MULT_AVERAGE;  
   hullType              = $HULLTYPE_MEDIUM;   
   
   explosionDatablock    = "BigExplosion";  
   explosionSound        = "snd_bigExplosion";
   
   disabilityEffectMaxScale  = "0.50";
   
   
   hullEngineSpace       = $SLOT_MEDIUM; 
   hullReactorSpace      = $SLOT_MEDIUM;  
   hullShieldSpace       = $SLOT_MEDIUM; 
   hullArmorSpace        = $SLOT_MEDIUM;
   
   engineCoreLink = "";
   reactorCoreLink = "";
   shieldCoreLink = "";
 
   debrisCluster_Light = "DC_Combat_Large_Light";  
   debrisCluster_Heavy = "DC_Combat_Large_Heavy";  
   
   subExplosionDatablockWL  = "BigExplosion 10 MediumExplosion 50";  
   subExplosionScale        = 0.45;
   
   embryoInfo[0] = "0 1 2 ZombieEggBase";
   
   miniHudIcon = "ShipDisplay_hull_mediumImageMap";
   
   invasionEffectScale_Zombie = 0.6;
   invasionEffectScale_Terran  = 0.6;
   invasionEffectScale_Civ  = 0.6;
   invasionEffectScale_Pirate  = 0.6;
  
   burstSpawnEffectScale = 0.667;
  
   hullTypeXPMult = 1.0;
   hullDescriptionBits = $SST_HULL_MILITARY;
};

datablock HullDatablock(HullMedium_zombie : HullMedium)
{        
   explosionDatablock    = "BigExplosion_zombie";  
   explosionSound        = "snd_bigExplosion_zombie";
   hullHitEffect         = "hullImpact_zombie";
   hullHitSound          = "snd_hullHit_zombie";  
   
   debrisCluster_Light = "DC_Combat_Large_Light_Zombie";  
   debrisCluster_Heavy = "DC_Combat_Large_Heavy_Zombie";   
   hullDamageModifier_Explosive   = "1";  //so explosions do not nuke zombies.

   subExplosionDatablockWL  = "BigExplosion_zombie 10 MediumExplosion_zombie 50";  
};

/////////////////////////////////////////////
// UTA / PIRATE /////////////////////////////
/////////////////////////////////////////////
datablock HullDatablock(HullTug : HullMedium) 

{
   friendlyName = "Tug";
   imageMapShield = "ship_tug_shieldImageMap";
   
   factionImageMap_Terran  = "ship_tugImageMap";
   factionImageMap_Pirate  = "ship_tug_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_tug_zomImageMap"; 
   factionImageMap_Default = "ship_tugImageMap"; 
   
   hullIconImageMap = "ship_tug_iconImageMap";
   purchaseTutorial = "PT_HullTug";    
   
   rootDesign = "TugShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 0;
  
   CollisionPolyList = "-0.737 -0.555 -0.231 -0.830 0.280 -0.820 0.771 -0.550 0.010 0.864";
   LinkPoints = "0.010 -0.324 -0.717 0.192 0.776 0.196 0.000 -0.624 -0.639 -0.319 0.655 -0.309 -0.435 -0.540 0.461 -0.540 -0.330 -0.781 0.340 -0.791";

   
   hullTurnSpeedMod      = $MULT_VERYLOW; 
   comparativeCargo      = $MULT_CARGOCARRIER;
   comparativeCrew       = $MULT_VERYLOW;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_LOW;
   RUCost        = 50; 
   NumBlackBoxes = 2;
   hullTypeXPMult = 0.5; 
   
   
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "9 10";   
   engineLinksClockwise  = "4 2";
   engineLinksCClockwise = "4 3";
 
   
   externalLinkPoints = "5 6 7 8";
   turretLinkPoints = "4";
      
   hullTurretSize4  = $SLOT_MEDIUM;    
   
   externalLinkType5  = $LINK_Launcher;
   externalLinkSize5  = $SLOT_MEDIUM;
   
   externalLinkType6  = $LINK_Launcher;
   externalLinkSize6  = $SLOT_MEDIUM;  
      
   externalLinkType7  = $LINK_Utility;
   externalLinkSize7  = $SLOT_MEDIUM;  
   
   externalLinkType8  = $LINK_Utility;
   externalLinkSize8  = $SLOT_MEDIUM;    
  
   wreckageData[0] = "ShipWreck_Small_01 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkTerran_1 = "0.765 -0.285 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "-0.728 -0.280 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkTerran_3 = "-0.419 -0.678 0 1 0.7 DoodadSet_Terran_S_Antenna"; 
   doodadLinkTerran_4 = "0.435 -0.678 0 1 0.7 DoodadSet_Terran_S_Antenna";
   doodadLinkTerran_5 = "0.010 0.835 0 0 1 DoodadSet_Terran_S_Lights";
   
   doodadLinkPirate_1 = "0.765 -0.285 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "-0.728 -0.280 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "-0.419 -0.678 -45 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkPirate_4 = "0.435 -0.678 45 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkPirate_5 = "0.010 0.835 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "0.765 -0.285 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "-0.728 -0.280 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "-0.419 -0.678 -45 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkZombie_4 = "0.435 -0.678 45 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkZombie_5 = "0.010 0.835 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.010 -0.324 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.346 -0.648 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.545 -0.511 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.210 -0.584 Random BreachSet_Small";  
   
   //egg
   embryoInfo[0] = "0.157 0.192 1 ZombieEggBase";      
   
 
};

datablock HullDatablock(HullVolley : HullMedium) 
{
   friendlyName = "Volley";
   imageMapShield = "ship_volley_shieldImageMap";
   
   factionImageMap_Terran  = "ship_volleyImageMap";
   factionImageMap_Pirate  = "ship_volley_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_volley_zomImageMap"; 
   factionImageMap_Default = "ship_volleyImageMap"; 
   
   hullIconImageMap = "ship_volley_iconImageMap";
   purchaseTutorial = "PT_HullVolley";    
   
   rootDesign = "VolleyShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 2;
  
   CollisionPolyList = "-0.216 -0.864 0.196 -0.864 0.742 -0.005 0.417 0.820 -0.417 0.815 -0.717 -0.010";
   LinkPoints = "0.000 0.005 -0.403 0.810 0.417 0.810 -0.692 -0.005 0.717 -0.005 -0.550 -0.383 0.570 -0.363 -0.250 -0.599 0.260 -0.604";

   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 60; 
   NumBlackBoxes = 4;
   hullTypeXPMult = 1; 
   
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "8 9";   
   engineLinksClockwise  = "2 8";
   engineLinksCClockwise = "3 9";
 
   
   externalLinkPoints = "4 5 6 7 8 9";
      
   externalLinkType4  = $LINK_Launcher;
   externalLinkSize4  = $SLOT_SMALL;   
   
   externalLinkType5  = $LINK_Launcher;
   externalLinkSize5  = $SLOT_SMALL;
   
   externalLinkType6  = $LINK_Launcher;
   externalLinkSize6  = $SLOT_SMALL;
   
   externalLinkType7  = $LINK_Launcher;
   externalLinkSize7  = $SLOT_SMALL;  
   
   externalLinkType8  = $LINK_Launcher;
   externalLinkSize8  = $SLOT_MEDIUM;   
   
   externalLinkType9  = $LINK_Launcher;
   externalLinkSize9  = $SLOT_MEDIUM;     
   
   
   wreckageData[0] = "ShipWreck_Small_02 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "-0.356 0.039 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "0.382 0.029 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkTerran_3 = "-0.136 -0.805 -45 1 0.6 DoodadSet_Terran_S_Antenna"; 
   doodadLinkTerran_4 = "0.152 -0.810 45 1 0.6 DoodadSet_Terran_S_Antenna"; 
   
   doodadLinkPirate_1 = "-0.356 0.039 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_2 = "0.382 0.029 0 0 1 DoodadSet_Pirate_M_Lights"; 
   doodadLinkPirate_3 = "-0.136 -0.805 -45 1 0.6 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkPirate_4 = "0.152 -0.810 45 1 0.6 DoodadSet_Pirate_S_Antenna"; 
   
   doodadLinkZombie_1 = "-0.356 0.039 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_2 = "0.382 0.029 0 0 1 DoodadSet_Zombie_M_Lights"; 
   doodadLinkZombie_3 = "-0.136 -0.805 -45 1 0.6 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkZombie_4 = "0.152 -0.810 45 1 0.6 DoodadSet_Pirate_S_Antenna"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.079 -0.368 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.094 -0.167 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.524 -0.182 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.021 0.098 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "0.262 -0.275 1 ZombieEggBase";     
};

datablock HullDatablock(HullSaucer : HullMedium) 
{
   friendlyName = "Saucer";
   imageMapShield = "ship_saucer_shieldImageMap";
   
   factionImageMap_Terran  = "ship_saucerImageMap";
   factionImageMap_Pirate  = "ship_saucer_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_saucer_zomImageMap"; 
   factionImageMap_Default = "ship_saucerImageMap";
   
   hullIconImageMap = "ship_saucer_iconImageMap";
   purchaseTutorial = "PT_HullSaucer";     
   
   rootDesign = "SaucerShip";  //This is what the player gets when selecting the hull.


   starLevelUnlock = 3;
  
   CollisionPolyList = "-0.236 -0.683 0.172 -0.688 0.746 -0.118 0.300 0.815 -0.275 0.815 -0.786 -0.079";
   LinkPoints = "-0.010 -0.059 -0.265 0.805 0.275 0.800 -0.010 -0.643 -0.746 -0.118 0.737 -0.118 -0.010 0.005 -0.540 -0.476 0.519 -0.486";
     
   hullTurnSpeedMod      = $MULT_VERYHIGH; 
   comparativeCargo      = $MULT_VERYLOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_LOW;
   RUCost        = 100; 
   NumBlackBoxes = 5;
   hullTypeXPMult = 1.5; 
   

   engineLinksThrust     = "2 3";
   engineLinksRetro      = "8 9";   
   engineLinksClockwise  = "8";
   engineLinksCClockwise = "9";

   
   externalLinkPoints = "4 5 6";
   turretLinkPoints = "7";
         
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_MEDIUM;
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_MEDIUM; 
   externalLinkMountRotation5 = 4;
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_MEDIUM;
   externalLinkMountRotation6 = -4;
   
   hullTurretSize7  = $SLOT_SMALL;     
   

      
   wreckageData[0] = "ShipWreck_Small_03 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "-0.492 -0.442 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "0.482 -0.447 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkTerran_3 = "-0.691 0.241 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkTerran_4 = "0.183 -0.663 0 1 0.6 DoodadSet_Terran_S_Antenna";
   
   doodadLinkPirate_1 = "-0.492 -0.442 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "0.482 -0.447 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "-0.691 0.241 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_4 = "0.183 -0.663 0 1 0.6 DoodadSet_Pirate_S_Antenna"; 
   
   doodadLinkZombie_1 = "-0.492 -0.442 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.482 -0.447 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "-0.691 0.241 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_4 = "0.183 -0.663 0 1 0.6 DoodadSet_Pirate_S_Antenna"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.377 -0.412 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.440 -0.196 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.388 0.319 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.456 0.241 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "-0.560 0.530 1 ZombieEggBase";    
   
};


datablock HullDatablock(HullGull : HullMedium) 
{
   friendlyName = "Gull";
   imageMapShield = "ship_gull_shieldImageMap";
   
   factionImageMap_Terran  = "ship_gullImageMap";
   factionImageMap_Pirate  = "ship_gull_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_gull_zomImageMap"; 
   factionImageMap_Default = "ship_gullImageMap";
   
   hullIconImageMap = "ship_gull_iconImageMap";
   purchaseTutorial = "PT_HullGull";     
   
   rootDesign = "GullShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 1;  
  
   GuiCollision = "-0.440 -0.889 0.393 -0.879 0.634 -0.481 0.597 0.761 -0.623 0.746 -0.629 -0.442";    
   CollisionPolyList = "0.608 -0.457 0.608 0.555 -0.623 0.560 -0.629 -0.442";
   MountedCollisionPolyList[0] = "-0.414 -0.933 -0.340 0.781 -0.634 0.717 -0.629 -0.442"; //left fin
   MountedCollisionPolyList[1] = "0.372 -0.894 0.644 -0.457 0.571 0.737 0.314 0.746";  //right fin
   LinkPoints = "0.005 0.000 -0.440 0.756 0.424 0.766 -0.367 -0.491 0.325 -0.496 -0.450 -0.845 0.419 -0.830";

   
     //use for gui  CollisionPolyList = "-0.440 -0.889 0.393 -0.879 0.634 -0.481 0.597 0.761 -0.623 0.746 -0.629 -0.442";


   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
 
   
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 75; 
   NumBlackBoxes = 3;
   hullTypeXPMult = 1; 
   
   
   externalLinkPoints = "1 6 7";
      
   externalLinkType1  = $LINK_Bomber;
   externalLinkSize1  = $SLOT_MEDIUM;
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_MEDIUM;   
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_MEDIUM;   
   
   wreckageData[0] = "ShipWreck_Small_01 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "-0.587 -0.300 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "-0.581 0.314 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkTerran_3 = "0.534 -0.005 0 0 1 DoodadSet_Terran_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.587 -0.300 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "-0.581 0.314 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "0.534 -0.005 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.587 -0.300 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "-0.581 0.314 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "0.534 -0.005 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.519 -0.349 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.576 -0.113 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.524 -0.054 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.487 0.422 Random BreachSet_Tiny"; 
   
   //egg
   embryoInfo[0] = "-0.272 -0.231 1 ZombieEggBase";     
   

};

/////////////////////////////////////////////
// CIV //////////////////////////////////////
/////////////////////////////////////////////

datablock HullDatablock(HullArray : HullMedium) 
{
   friendlyName = "Array";
   imageMapShield = "ship_civ_array_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_array_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_arrayImageMap"; 
   factionImageMap_Zombie  = "ship_civ_array_zomImageMap"; 
   factionImageMap_Default = "ship_civ_arrayImageMap";
   
   hullIconImageMap = "ship_civ_array_iconImageMap";    
   
   rootDesign = "ArrayShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 0;
  
   CollisionPolyList = "-0.702 -0.633 0.005 -0.712 0.670 -0.648 0.911 -0.025 0.801 0.408 0.016 0.683 -0.796 0.403 -0.932 -0.029";
   LinkPoints = "-0.005 0.010 0.005 0.781 -0.424 -0.476 0.361 -0.457 -0.005 -0.393 -0.870 -0.020 0.885 -0.015 -0.780 -0.501 0.770 -0.516";

   engineLinksThrust     = "2";
   engineLinksRetro      = "8 9";   
   engineLinksClockwise  = "8";
   engineLinksCClockwise = "9";
 
   
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 60; 
   NumBlackBoxes = 3;
   hullTypeXPMult = 0.75; 
   
   
   
   externalLinkPoints = "3 4 5 6 7";
      
   externalLinkType3  = $LINK_Shooter;
   externalLinkSize3  = $SLOT_MEDIUM;    
      
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_MEDIUM;    
   
   externalLinkType5  = $LINK_Utility;
   externalLinkSize5  = $SLOT_MEDIUM;    
   
   externalLinkType6  = $LINK_Utility;
   externalLinkSize6  = $SLOT_MEDIUM;    
   
   externalLinkType7  = $LINK_Utility;
   externalLinkSize7  = $SLOT_MEDIUM;   

   
   purchaseTutorial = "PT_HullArray";  
   
   wreckageData[0] = "ShipWreck_Small_02 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.901 -0.010 0 0 1 DoodadSet_Civ_M_Lights";   
   doodadLinkCiv_2 = "0.917 -0.010 0 0 1 DoodadSet_Civ_M_Lights"; 
   
   doodadLinkPirate_1 = "-0.901 -0.010 0 0 1 DoodadSet_Pirate_M_Lights";   
   doodadLinkPirate_2 = "0.917 -0.010 0 0 1 DoodadSet_Pirate_M_Lights"; 
   
   doodadLinkZombie_1 = "-0.901 -0.010 0 0 1 DoodadSet_Zombie_M_Lights";   
   doodadLinkZombie_2 = "0.917 -0.010 0 0 1 DoodadSet_Zombie_M_Lights"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.267 -0.358 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.581 -0.020 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.110 0.570 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "-0.010 0.108 Random BreachSet_Small";
   
   //egg
   embryoInfo[0] = "-0.571 -0.255 1 ZombieEggBase";     
     
   hullDescriptionBits = $SST_HULL_SCIENCE;  
};


datablock HullDatablock(HullPounder : HullMedium) 
{
   friendlyName = "Pounder";
   imageMapShield = "ship_civ_pounder_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_pounder_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_pounderImageMap"; 
   factionImageMap_Zombie  = "ship_civ_pounder_zomImageMap"; 
   factionImageMap_Default = "ship_civ_pounderImageMap";
   
   hullIconImageMap = "ship_civ_pounder_iconImageMap";     
   
   rootDesign = "PounderShip";  //This is what the player gets when selecting the hull.

 
   starLevelUnlock = 0;
  
   CollisionPolyList = "-0.686 -0.776 0.718 -0.781 0.828 -0.118 0.042 0.913 -0.749 -0.074";
   LinkPoints = "0.026 -0.275 -0.550 0.142 0.608 0.147 -0.880 -0.521 0.927 -0.516 -0.555 -0.820 0.597 -0.820 0.021 0.241";

   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
   
   turretLinkPoints = "1";
   externalLinkPoints = "6 7 8";
   
    
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_VERYHIGH;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 50; 
   NumBlackBoxes = 3;
   hullTypeXPMult = 0.75; 
   
   
   hullTurretSize1  = $SLOT_SMALL;   
      
   externalLinkType6  = $LINK_Utility;
   externalLinkSize6  = $SLOT_MEDIUM;  
   
   externalLinkType7  = $LINK_Utility;
   externalLinkSize7  = $SLOT_MEDIUM; 
   
   externalLinkType8  = $LINK_Bomber;
   externalLinkSize8  = $SLOT_MEDIUM; 

     
   purchaseTutorial = "PT_HullPounder";  
   
   wreckageData[0] = "ShipWreck_Small_02 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "0.021 -0.280 0 0 1 DoodadSet_Civ_S_Lights";   
   doodadLinkCiv_2 = "0.031 0.098 0 0 1 DoodadSet_Civ_S_Lights";
   
   doodadLinkPirate_1 = "0.021 -0.280 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.031 0.098 0 0 1 DoodadSet_Pirate_S_Lights";
   
   doodadLinkZombie_1 = "0.021 -0.280 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.031 0.098 0 0 1 DoodadSet_Zombie_S_Lights";
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.566 -0.545 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.492 -0.216 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.581 -0.363 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.021 0.614 Random BreachSet_Small";
   
   //egg
   embryoInfo[0] = "-0.021 0.098 1 ZombieEggBase";    
   
  
   hullDescriptionBits = $SST_HULL_MINING;      
};

datablock HullDatablock(HullYacht : HullMedium) 
{ 
   friendlyName = "Yacht";
   imageMapShield = "ship_civ_yacht_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_yacht_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_yachtImageMap"; 
   factionImageMap_Zombie  = "ship_civ_yacht_zomImageMap"; 
   factionImageMap_Default = "ship_civ_yachtImageMap";
   
   hullIconImageMap = "ship_civ_yacht_iconImageMap";     
   
   rootDesign = "YachtShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 0;
   
   CollisionPolyList = "0.016 -0.825 0.890 0.064 0.901 0.506 0.026 0.800 -0.885 0.535 -0.880 0.152";
   LinkPoints = "0.016 0.005 -0.765 0.570 0.780 0.570 -0.367 -0.575 0.409 -0.570 -0.629 0.039 0.670 0.039 -0.162 -0.805 0.173 -0.805";

   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
    
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_VERYLOW;
   comparativeCrew       = $MULT_HIGHEST;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 75; 
   NumBlackBoxes = 3;
   hullTypeXPMult = 1; 
   
   
   
   externalLinkPoints = "1 6 7 8 9";
   
   externalLinkType1  = $LINK_Utility;
   externalLinkSize1  = $SLOT_MEDIUM; 

   externalLinkType6  = $LINK_Launcher;
   externalLinkSize6  = $SLOT_MEDIUM; 
   
   externalLinkType7  = $LINK_Launcher;
   externalLinkSize7  = $SLOT_MEDIUM;    
    
   externalLinkType8  = $LINK_Shooter;
   externalLinkSize8  = $SLOT_MEDIUM; 
   
   externalLinkType9  = $LINK_Shooter;
   externalLinkSize9  = $SLOT_MEDIUM; 

    
   purchaseTutorial = "PT_HullYacht";  
   
   wreckageData[0] = "ShipWreck_Small_03 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkCiv_1 = "-0.367 -0.545 0 0 1 DoodadSet_Civ_M_Lights";   
   doodadLinkCiv_2 = "0.409 -0.555 0 0 1 DoodadSet_Civ_M_Lights"; 
   
   doodadLinkPirate_1 = "-0.367 -0.545 0 0 1 DoodadSet_Pirate_M_Lights";   
   doodadLinkPirate_2 = "0.409 -0.555 0 0 1 DoodadSet_Pirate_M_Lights"; 
   
   doodadLinkZombie_1 = "-0.367 -0.545 0 0 1 DoodadSet_Zombie_M_Lights";   
   doodadLinkZombie_2 = "0.409 -0.555 0 0 1 DoodadSet_Zombie_M_Lights"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.749 0.079 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.749 0.319 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.293 0.029 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.126 0.206 Random BreachSet_Small";
   
   //egg
   embryoInfo[0] = "0.540 0.182 1 ZombieEggBase";        
   
 
   hullDescriptionBits = $SST_HULL_COLONY;
};


datablock HullDatablock(HullHound : HullMedium) 
{
   friendlyName = "Hound";
   imageMapShield = "ship_civ_hound_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_hound_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_houndImageMap"; 
   factionImageMap_Zombie  = "ship_civ_hound_zomImageMap"; 
   factionImageMap_Default = "ship_civ_houndImageMap";
   
   hullIconImageMap = "ship_civ_hound_iconImageMap";    
   
   rootDesign = "HoundShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 1;
  
   CollisionPolyList = "-0.587 -0.727 0.592 -0.746 0.896 -0.054 0.393 0.845 -0.367 0.854 -0.870 -0.034";
   LinkPoints = "0.005 0.005 -0.299 0.830 0.304 0.815 -0.430 -0.702 0.450 -0.707 -0.398 0.069 0.403 0.074 0.005 0.285";
    
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 75; 
   NumBlackBoxes = 4;
   hullTypeXPMult = 1; 
   
   

   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 5";
 
   externalLinkPoints = "8";
   turretLinkPoints = "6 7";
   
   externalLinkType8  = $LINK_Utility;
   externalLinkSize8  = $SLOT_MEDIUM; 
   
   hullTurretSize6  = $SLOT_MEDIUM;  
   hullTurretSize7  = $SLOT_MEDIUM;     
   
  
   purchaseTutorial = "PT_HullHound";  
   
   wreckageData[0] = "ShipWreck_Small_01 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkCiv_1 = "-0.005 -0.668 0 0 1 DoodadSet_Civ_S_Lights";   
   doodadLinkCiv_2 = "-0.718 0.329 0 0 1 DoodadSet_Civ_S_Lights"; 
   doodadLinkCiv_3 = "0.754 0.334 0 0 1 DoodadSet_Civ_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.005 -0.668 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "-0.718 0.329 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "0.754 0.334 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.005 -0.668 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "-0.718 0.329 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "0.754 0.334 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.367 -0.422 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.388 -0.516 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "0.005 0.452 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.010 -0.309 Random BreachSet_Small";
   
   //egg
   embryoInfo[0] = "0.697 0.196 1 ZombieEggBase";  
   

   hullDescriptionBits = $SST_HULL_SURPLUS;
};

/////////////////////////////////////////////
// Zombie  //////////////////////////////////
/////////////////////////////////////////////


datablock HullDatablock(HullZombieBlowfish : HullMedium_zombie) 
{   
   friendlyName = "Blow Fish";
   imageMapShield = "ship_zombie_blowfish_shieldImageMap"; 
   embryoImage = "blowfish_embryoImageMap";  
   
   factionImageMap_Zombie  = "ship_zombie_blowfishImageMap"; 
   factionImageMap_Default = "ship_zombie_blowfishImageMap"; 
   
   hullIconImageMap = "ship_zombie_blowfish_iconImageMap";    
   
   rootDesign = "Zombie_BlowfishShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 0;
   
  
   CollisionPolyList = "-0.309 -0.629 0.524 -0.491 0.655 0.334 -0.152 0.692 -0.681 0.088";
   LinkPoints = "0.021 0.005 0.026 0.751 -0.796 -0.467 0.922 -0.255 0.356 -0.584";
   
   hullTurnSpeedMod      = $MULT_LOW;  //slow turn

   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "3 4";
 

   externalLinkPoints = "5";
   turretLinkPoints = "1";
      
   externalLinkType5  = $LINK_Launcher;
   externalLinkSize5  = $SLOT_SMALL;    
   
   hullTurretSize1  = $SLOT_LARGE;     
   
   NumBlackBoxes = -1;   
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkZombie_1 = "-0.435 -0.147 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "-0.105 0.447 0 0 0.7 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "0.461 -0.049 0 0 0.7 DoodadSet_Zombie_S_Node";
   //doodadLinkZombie_4 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Med";   
   
   //egg
   embryoInfo[0] = "-0.330 -0.378 2 ZombieEggBase";   
   embryoInfo[1] = "0.031 0.516 1 ZombieEggBase";
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;
};


datablock HullDatablock(HullZombieScab : HullMedium_zombie) 
{   
   friendlyName = "Scab";
   imageMapShield = "ship_zombie_scab_shieldImageMap";  
   embryoImage = "scab_embryoImageMap"; 
   
   factionImageMap_Zombie  = "ship_zombie_scabImageMap"; 
   factionImageMap_Default = "ship_zombie_scabImageMap";
   
   rootDesign = "Zombie_ScabShip";  //This is what the player gets when selecting the hull.

   hullIconImageMap = "ship_zombie_scab_iconImageMap";    
   
   starLevelUnlock = 3;
   
  
   CollisionPolyList = "-0.707 -0.727 0.525 -0.594 0.751 0.152 0.412 0.737 -0.805 0.594";
   LinkPoints = "-0.015 0.000 0.309 0.746 -0.442 -0.452 -0.781 -0.010 0.766 0.000";
   
   hullTurnSpeedMod      = $MULT_HIGH;  //QUICK TURNER

   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
  
   
   externalLinkPoints = "3 4 5";
   
   externalLinkType3  = $LINK_Shooter;
   externalLinkSize3  = $SLOT_MEDIUM; 
   
   externalLinkType4  = $LINK_Launcher;
   externalLinkSize4  = $SLOT_MEDIUM;
   
   externalLinkType5  = $LINK_Shooter; 
   externalLinkSize5  = $SLOT_MEDIUM; 

   NumBlackBoxes = -1;
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkZombie_1 = "0.367 -0.368 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "0.560 -0.054 0 0 0.7 DoodadSet_Zombie_S_Node"; 
   doodadLinkZombie_3 = "0.482 0.236 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_4 = "-0.571 0.049 0 0 0.7 DoodadSet_Zombie_S_Node";  
   //doodadLinkZombie_5 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Med"; 
   
   //egg
   embryoInfo[0] = "-0.105 0.383 2 ZombieEggBase";  
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;
};


////////////////////////////////////////////////////////////////////////////////
// BOUNTY SHIPS
////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////
// BOUNTY MED 01
//////////////////////////////////


datablock HullDatablock(HullBounty_Medium_01 : HullMedium) 
{
   friendlyName = "Raven";
   imageMapShield = "ship_bounty_medium_01_shieldImageMap";
   
   factionImageMap_Bounty  = "ship_bounty_medium_01ImageMap";
   factionImageMap_Pirate  = "ship_bounty_medium_01_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bounty_medium_01_zombieImageMap"; 
   factionImageMap_Default = "ship_bounty_medium_01ImageMap"; 
   
   hullIconImageMap = "ship_bounty_medium_01_iconImageMap";
   purchaseTutorial = "PT_Raven";    
   
   rootDesign = "BountyShip_Medium_01_CIV_A";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 0;
  
   CollisionPolyList = "-0.105 -0.869 0.084 -0.874 0.744 0.398 0.550 0.850 -0.540 0.850 -0.691 0.417";
   LinkPoints = "0.010 0.157 -0.199 0.899 0.210 0.899 -0.115 -0.835 0.131 -0.835 -0.477 0.020 0.482 0.015 0.010 0.393 -0.320 0.393 0.351 0.398 -0.597 0.530 0.597 0.535";

   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 150; 
   NumBlackBoxes = 6;
   hullTypeXPMult = 2; 
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 5";
 
   
   externalLinkPoints = "6 7 8 9 10 11 12";
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_MEDIUM;
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_MEDIUM;  
      
   externalLinkType8 = $LINK_Drones; 
   externalLinkSize8 = $SLOT_LARGE;
   
   externalLinkType9  = $LINK_Utility;
   externalLinkSize9  = $SLOT_MEDIUM;    
   
   externalLinkType10  = $LINK_Utility;
   externalLinkSize10  = $SLOT_MEDIUM;   
   
   externalLinkType11  = $LINK_Utility;
   externalLinkSize11  = $SLOT_MEDIUM;   
   
   externalLinkType12  = $LINK_Utility;
   externalLinkSize12  = $SLOT_MEDIUM;   
  
   wreckageData[0] = "ShipWreck_Small_01 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkBounty_1 = "0.299 -0.447 0 0 1 DoodadSet_Bounty_S_Lights";   
   doodadLinkBounty_2 = "0.005 0.854 0 0 1 DoodadSet_Bounty_S_Lights"; 
   doodadLinkBounty_3 = "-0.602 0.339 0 1 0.7 DoodadSet_Terran_S_Antenna"; 
   doodadLinkBounty_4 = "0.623 0.334 0 1 0.7 DoodadSet_Terran_S_Antenna";
   doodadLinkBounty_5 = "-0.283 -0.447 0 0 1 DoodadSet_Bounty_S_Lights";   
   
   doodadLinkPirate_1 = "0.299 -0.447 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "0.005 0.854 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "-0.602 0.339 -45 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkPirate_4 = "0.623 0.334 45 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkPirate_5 = "-0.283 -0.447 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "0.299 -0.447 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.005 0.854 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "-0.602 0.339 -45 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkZombie_4 = "0.623 0.334 45 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkZombie_5 = "-0.283 -0.447 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.152 -0.280 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.136 -0.339 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.120 0.619 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.000 0.059 Random BreachSet_Small";  
   
   //egg
   embryoInfo[0] = "0.157 0.192 1 ZombieEggBase";      
};

//////////////////////////////////
// BOUNTY MED 02
//////////////////////////////////

datablock HullDatablock(HullBounty_Medium_02 : HullMedium) 
{
   friendlyName = "Hydra";
   imageMapShield = "ship_bounty_medium_02_shieldImageMap";
   
   factionImageMap_Bounty  = "ship_bounty_medium_02ImageMap";
   factionImageMap_Pirate  = "ship_bounty_medium_02_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bounty_medium_02_zombieImageMap"; 
   factionImageMap_Default = "ship_bounty_medium_02ImageMap"; 
   
   hullIconImageMap = "ship_bounty_medium_02_iconImageMap";
   purchaseTutorial = "PT_GunSlinger";    
   
   rootDesign = "BountyShip_Medium_02_CIV_A";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 0;
  
   CollisionPolyList = "-0.796 -0.629 0.005 -0.776 0.828 -0.614 0.445 0.835 -0.445 0.830";
   LinkPoints = "0.005 0.000 -0.215 0.908 0.251 0.904 -0.304 -0.653 0.299 -0.653 0.000 -0.707 -0.566 -0.575 0.560 -0.594 -0.650 0.000 0.655 -0.005 -0.225 0.226 0.230 0.221 -0.246 0.560 0.246 0.560";

   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_LOW;
   RUCost        = 150; 
   NumBlackBoxes = 6;
   hullTypeXPMult = 2; 
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 5";
 
   externalLinkPoints = "6 7 8 9 10 11 12 13 14";
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_LARGE;
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_MEDIUM;  
      
   externalLinkType8 = $LINK_Shooter; 
   externalLinkSize8 = $SLOT_MEDIUM;
   
   externalLinkType9  = $LINK_Launcher;
   externalLinkSize9  = $SLOT_MEDIUM;  
   externalLinkMountRotation9 = -18;  
   
   externalLinkType10  = $LINK_Launcher;
   externalLinkSize10  = $SLOT_MEDIUM; 
   externalLinkMountRotation10 = 18;  
   
   externalLinkType11  = $LINK_Utility;
   externalLinkSize11  = $SLOT_SMALL;   
   
   externalLinkType12  = $LINK_Utility;
   externalLinkSize12  = $SLOT_SMALL;  
   
   externalLinkType13  = $LINK_Utility;
   externalLinkSize13  = $SLOT_MEDIUM; 
   
   externalLinkType14  = $LINK_Utility;
   externalLinkSize14  = $SLOT_MEDIUM;  
  
   wreckageData[0] = "ShipWreck_Small_01 0 0 0";
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkBounty_1 = "-0.608 0.216 0 0 1 DoodadSet_Bounty_S_Lights";   
   doodadLinkBounty_2 = "0.602 0.211 0 0 1 DoodadSet_Bounty_S_Lights"; 
   doodadLinkBounty_3 = "-0.204 -0.756 0 1 0.7 DoodadSet_Terran_S_Antenna"; 
   doodadLinkBounty_4 = "0.194 -0.761 0 1 0.7 DoodadSet_Terran_S_Antenna";
   doodadLinkBounty_5 = "0.000 0.786 0 0 1 DoodadSet_Bounty_S_Lights";   
   
   doodadLinkPirate_1 = "-0.608 0.216 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "0.602 0.211 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "-0.204 -0.756 0 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkPirate_4 = "0.194 -0.761 0 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkPirate_5 = "0.000 0.786 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.608 0.216 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.602 0.211 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "-0.204 -0.756 0 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkZombie_4 = "0.194 -0.761 0 1 0.7 DoodadSet_Pirate_S_Antenna"; 
   doodadLinkZombie_5 = "0.000 0.786 0 0 1 DoodadSet_Zombie_S_Lights";   
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.7 0.5 0.3";
   breachThresholds["Major"] = "0.4";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.330 -0.432 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.435 -0.506 Random BreachSet_Tiny";
   breachLinks["Minor", 3] = "-0.010 0.412 Random BreachSet_Tiny";   
   
   breachLinks["Major", 1] = "0.031 -0.236 Random BreachSet_Small";  

   //egg
   embryoInfo[0] = "0.157 0.192 1 ZombieEggBase";      
};