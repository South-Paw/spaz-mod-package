
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// SMALL HULLS ////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Base for all small hulls
datablock HullDatablock(HullSmall : HullBase)
{        
   
   size = "64.000 64.000";  //Small ships are no bigger than this. 
   
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   componentSize         = $SLOT_SMALL;  //MEANINGLESS HERE

   hullTurnSpeedMod      = $MULT_AVERAGE;  
   hullType              = $HULLTYPE_SMALL;   
   
   explosionDatablock    = "MediumExplosion_Debris";  
   explosionSound        = "snd_mediumExplosion_ship";
   explosionScale        = "1";  
   
   disabilityEffectMaxScale  = "0.40";
     
   
      
   hullEngineSpace       = $SLOT_SMALL;  
   hullReactorSpace      = $SLOT_SMALL;  
   hullShieldSpace       = $SLOT_SMALL;  
   
   hullArmorSpace        = $SLOT_SMALL;

   
   engineCoreLink = "";
   reactorCoreLink = "";
   shieldCoreLink = "";
   
   debrisCluster_Light = "DC_Combat_Small_Light";  
   debrisCluster_Heavy = "DC_Combat_Small_Heavy";  
   
   subExplosionDatablockWL  = "SmallExplosion";  
   subExplosionScale        = 0.7;
   subExplosionSoundWL      = "snd_smallExplosion_cascade 10 snd_smallExplosion 10";
    
   invasionEffectScale_Zombie = 0.5;
   invasionEffectScale_Terran  = 0.5;
   invasionEffectScale_Civ  = 0.5;
   invasionEffectScale_Pirate  = 0.5;
   
   embryoInfo[0] = "0 1 1 ZombieEggBase";
   
   miniHudIcon = "ShipDisplay_hull_smallImageMap";
   
   burstSpawnEffectScale = 0.5;
   
   hullTypeXPMult = 1.0;
   hullDescriptionBits = $SST_HULL_MILITARY;
};

datablock HullDatablock(HullSmall_zombie : HullSmall)
{        
   explosionDatablock    = "BigExplosion_zombie";  
   explosionSound        = "snd_bigExplosion_zombie";
   hullHitEffect         = "hullImpact_zombie";
   hullHitSound          = "snd_hullHit_zombie";  
   
   debrisCluster_Light = "DC_Combat_Small_Light_Zombie";  
   debrisCluster_Heavy = "DC_Combat_Small_Heavy_Zombie";  
   
   subExplosionDatablockWL  = "MediumExplosion_zombie";  
   hullDamageModifier_Explosive   = "1";  //so explosions do not nuke zombies.

};


/////////////////////////////////////////////
// THE HATCHET
/////////////////////////////////////////////

datablock HullDatablock(HullHatchet : HullSmall) 
{
   friendlyName = "Hatchet"; 
   
   size = "64 64";
   imageMapShield = "ship_hatchet_shieldImageMap";
   
   factionImageMap_Terran  = "ship_hatchet_terranImageMap";  
   factionImageMap_Pirate  = "ship_hatchet_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_hatchet_zomImageMap"; 
   factionImageMap_Default = "ship_hatchet_terranImageMap";
   
   hullIconImageMap = "ship_hatchet_iconImageMap";
   purchaseTutorial = "PT_HullHatchet";       
   
   starLevelUnlock = 0;
     
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_CARGOCARRIER;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_LOW;
   RUCost        = 10; 
   NumBlackBoxes = 2;
   hullTypeXPMult = 0.667;
   
   rootDesign = "HatchetShip";  //This is what the player gets when selecting the hull.

   CollisionPolyList = "0.540 -0.722 0.733 0.083 0.094 0.918 -0.744 0.530 -0.791 -0.471 -0.272 -0.899";
   LinkPoints = "-0.005 0.000 -0.105 0.869 -0.220 -0.899 -0.822 -0.437 0.780 0.088 0.005 -0.496 0.314 -0.491 0.010 0.010";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8";
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_SMALL;
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_SMALL;    
   
   externalLinkType8 = $LINK_Utility;
   externalLinkSize8 = $SLOT_MEDIUM;  

      
   doodadLinkTerran_1 = "-0.430 -0.511 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "0.487 0.270 0 0 1 DoodadSet_Terran_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.430 -0.511 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.487 0.270 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.430 -0.511 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.487 0.270 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.450 -0.093 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.005 0.481 Random BreachSet_Tiny";
   
   //egg
   embryoInfo[0] = "0.435 -0.275 0 ZombieEggBase"; 
   
   
};

/////////////////////////////////////////////
// UTA / PIRATE /////////////////////////////
/////////////////////////////////////////////

datablock HullDatablock(HullGimp : HullSmall) 
{   
   friendlyName = "Gimp"; 
   
   imageMapShield = "ship_gimp_shieldImageMap";
   
   factionImageMap_Terran  = "ship_gimpImageMap";
   factionImageMap_Pirate  = "ship_gimp_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_gimp_zomImageMap"; 
   factionImageMap_Default = "ship_gimpImageMap";
   
   hullIconImageMap = "ship_gimp_iconImageMap";
   purchaseTutorial = "PT_HullGimp";         
   
    
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_VERYLOW;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 20; 
   NumBlackBoxes = 3;
   hullTypeXPMult = 0.75;
   
   
   //starLevelUnlock = 0;  //was 0 in demo.
   starLevelUnlock = 1;  
   
   rootDesign = "GimpShip";  //This is what the player gets when selecting the hull.

      
   size = "64.000 64.000";
   CollisionPolyList = "-0.142 -0.766 0.462 -0.751 0.962 -0.157 0.403 0.609 -0.869 0.142";
   LinkPoints = "0.133 -0.309 -0.466 -0.123 0.412 0.771 -0.255 -0.201 0.560 -0.206 0.417 -0.707 0.828 -0.226";

   engineLinksThrust     = "3";
   engineLinksRetro      = "6";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "1 2 7";
   
   externalLinkType1  = $LINK_Launcher;
   externalLinkSize1  = $SLOT_SMALL;    
   
   externalLinkType2  = $LINK_Shooter;
   externalLinkSize2  = $SLOT_SMALL;   
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_SMALL;   
   

   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN
   
   doodadLinkTerran_1 = "0.414 -0.373 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkPirate_2 = "0.409 0.241 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_3 = "-0.503 -0.079 0 1 0.8 DoodadSet_Terran_S_Antenna";
   
   doodadLinkPirate_1 = "0.414 -0.373 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "0.409 0.241 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "-0.503 -0.079 10 1 0.8 DoodadSet_Pirate_S_Antenna"; 
   
   doodadLinkZombie_1 = "0.414 -0.373 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.409 0.241 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "-0.503 -0.079 10 1 0.8 DoodadSet_Pirate_S_Antenna"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.6 0.4";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.152 -0.246 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.482 -0.314 Random BreachSet_Tiny";
   
   //egg
   embryoInfo[0] = "0.115 -0.162 1 ZombieEggBase";   
   
  
};



datablock HullDatablock(HullBoomerang : HullSmall) 
{   
   friendlyName = "Boomerang"; 
   
   imageMapShield = "ship_boomerang_shieldImageMap";
   
   factionImageMap_Terran  = "ship_boomerangImageMap";
   factionImageMap_Pirate  = "ship_boomerang_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_boomerang_zomImageMap"; 
   factionImageMap_Default = "ship_boomerangImageMap";
   
   hullIconImageMap = "ship_boomerang_iconImageMap";
   purchaseTutorial = "PT_HullBoomerang";          
      
   starLevelUnlock = 0;
   
   rootDesign = "BoomerangShip";  //This is what the player gets when selecting the hull.

    
   hullTurnSpeedMod      = $MULT_VERYHIGH; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_LOW;
   RUCost        = 15; 
   NumBlackBoxes = 2;
   hullTypeXPMult = 0.667;
   
   
   size = "64.000 64.000";
   CollisionPolyList = "-0.422 -0.565 0.403 -0.565 0.810 0.226 -0.899 0.241";
   LinkPoints = "-0.005 -0.246 -0.746 0.399 0.717 0.399 -0.437 -0.511 0.408 -0.511 -0.681 -0.314 0.639 -0.319";
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "6 7";   
   engineLinksClockwise  = "6";
   engineLinksCClockwise = "7";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "4 5";
   
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_SMALL;    
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_SMALL; 
   

   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "-0.320 0.113 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "0.293 0.113 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkTerran_3 = "-0.010 -0.496 0 1 0.8 DoodadSet_Terran_S_Antenna";
   
   doodadLinkPirate_1 = "-0.320 0.113 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "0.293 0.113 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "-0.010 -0.496 0 1 0.5 DoodadSet_Pirate_S_Antenna"; 
   
   doodadLinkZombie_1 = "-0.320 0.113 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.293 0.113 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "-0.010 -0.496 0 1 0.5 DoodadSet_Pirate_S_Antenna"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.6 0.4";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.236 -0.457 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.058 -0.196 Random BreachSet_Tiny";  
   
   //egg
   embryoInfo[0] = "-0.377 -0.177 1 ZombieEggBase";     
   
  
};

datablock HullDatablock(HullScout : HullSmall) 
{
   friendlyName = "Ranger"; //swapped name with ranger
   
   imageMapShield = "ship_scout_shieldImageMap";
   
   factionImageMap_Terran  = "ship_scoutImageMap";
   factionImageMap_Pirate  = "ship_scout_pirateImageMap";  
   factionImageMap_Zombie  = "ship_scout_zomImageMap";   
   factionImageMap_Default = "ship_scoutImageMap";
   
   rootDesign = "ScoutShip";  //This is what the player gets when selecting the hull.

   
   hullIconImageMap = "ship_scout_iconImageMap";
   purchaseTutorial = "PT_HullScout";       
   
   starLevelUnlock = 2;
   
   size = "64.000 64.000";
   CollisionPolyList = "0.000 -0.933 0.678 0.633 -0.648 0.624";
   LinkPoints = "-0.005 0.059 -0.005 0.624 -0.668 0.295 0.678 0.304 -0.412 -0.412 0.417 -0.422 -0.564 -0.103 0.581 -0.103";

   engineLinksThrust     = "2";
   engineLinksRetro      = "7 8";   
   engineLinksClockwise  = "7";
   engineLinksCClockwise = "8";
  
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost        = 30; 
   NumBlackBoxes = 3;
   hullTypeXPMult = 1;
   
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "3 4 5 6";
   
   externalLinkType3  = $LINK_Launcher;
   externalLinkSize3  = $SLOT_SMALL;      
   
   externalLinkType4  = $LINK_Launcher;
   externalLinkSize4  = $SLOT_SMALL;
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_SMALL;
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_SMALL;


   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN
   
   doodadLinkTerran_1 = "0.500 0.250 45 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "-0.500 0.250 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_3 = "0.100 -0.900 0 1 0.5 DoodadSet_Terran_S_Antenna";
   
   doodadLinkPirate_1 = "0.100 -0.900 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "-0.100 -0.900 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "0.900 0.100 60 1 0.5 DoodadSet_Pirate_S_Antenna"; 
   
   doodadLinkCiv_1 = "-0.760 0.177 0 0 1 DoodadSet_Civ_S_Lights"; 
   doodadLinkCiv_2 = "0.754 0.187 0 0 1 DoodadSet_Civ_S_Lights"; 
   doodadLinkCiv_3 = "0.900 0.100 60 1 0.5 DoodadSet_Terran_S_Antenna"; 
   
   doodadLinkZombie_1 = "-0.760 0.177 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.754 0.187 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "0.900 0.100 60 1 0.5 DoodadSet_Pirate_S_Antenna"; 

   //BREACH DATA
   breachThresholds["Minor"] = "0.6 0.4";
   breachThresholds["Major"] = "0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.487 0.133 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.309 0.368 Random BreachSet_Tiny";
   
   breachLinks["Major", 1] = "0.225 0.216 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "0.550 -0.147 1 ZombieEggBase";  
      
};

datablock HullDatablock(HullColt : HullSmall) 
{   
   friendlyName = "Colt"; 
   
   imageMapShield = "ship_colt_shieldImageMap";
   
   factionImageMap_Terran  = "ship_coltImageMap";
   factionImageMap_Pirate  = "ship_colt_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_colt_zomImageMap"; 
   factionImageMap_Default = "ship_coltImageMap";
   
   hullIconImageMap = "ship_colt_iconImageMap"; 
   purchaseTutorial = "PT_HullColt";      
   
   starLevelUnlock = 2;
   
   rootDesign = "ColtShip";  //This is what the player gets when selecting the hull.

      
   size = "64.000 64.000";
   CollisionPolyList = "-0.525 -0.845 0.462 -0.854 0.633 0.363 0.378 0.879 -0.324 0.884 -0.614 0.378";
   LinkPoints = "-0.015 0.000 -0.250 0.874 0.275 0.869 -0.589 0.000 0.589 -0.005 -0.422 -0.859 -0.251 -0.496 -0.020 -0.938 0.230 -0.501 0.388 -0.840";
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
   

   
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_HIGH;
   comparativeHealth     = $MULT_VERYHIGH;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 50;
   NumBlackBoxes = 4; 
   hullTypeXPMult = 2;
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9 10";
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_SMALL;  
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_SMALL;  
   
   externalLinkType8  = $LINK_Shooter;
   externalLinkSize8  = $SLOT_SMALL;  
   
   externalLinkType9  = $LINK_Shooter;
   externalLinkSize9  = $SLOT_SMALL;  
   
   externalLinkType10  = $LINK_Shooter;
   externalLinkSize10  = $SLOT_SMALL;  
   
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkTerran_1 = "-0.498 0.000 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "0.503 -0.005 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkTerran_3 = "0.262 -0.845 0 1 0.8 DoodadSet_Terran_S_Antenna";
   
   doodadLinkPirate_1 = "-0.498 0.000 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "0.503 -0.005 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "0.262 -0.845 0 1 0.8 DoodadSet_Pirate_S_Antenna";  
   
   doodadLinkZombie_1 = "-0.498 0.000 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.503 -0.005 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "0.262 -0.845 0 1 0.8 DoodadSet_Pirate_S_Antenna"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.6 0.4";
   breachThresholds["Major"] = "0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.377 -0.034 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.419 0.250 Random BreachSet_Tiny";
   
   breachLinks["Major", 1] = "-0.005 0.142 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "-0.409 0.511 0 ZombieEggBase";     
   
   
};

/////////////////////////////////////////////
// CIV  /////////////////////////////////////
/////////////////////////////////////////////


datablock HullDatablock(HullGirlScout : HullSmall) 
{
   friendlyName = "Turtle Head"; 
   
   imageMapShield = "ship_scout_shieldImageMap";
      
   factionImageMap_Pirate  = "ship_civ_girlscout_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_girlscoutImageMap"; 
   factionImageMap_Zombie  = "ship_civ_girlscout_zomImageMap"; 
   factionImageMap_Default = "ship_civ_girlscoutImageMap";
   
   hullIconImageMap = "ship_civ_girlscout_iconImageMap";
   purchaseTutorial = "PT_HullScout";       
   
   rootDesign = "GirlScoutShip";  //This is what the player gets when selecting the hull.


   starLevelUnlock = 0;
 
   purchaseTutorial = "PT_HullGirlScout";  
   
   size = "64.000 64.000";
   CollisionPolyList = "0.000 -0.933 0.678 0.633 -0.648 0.624";
   LinkPoints = "-0.005 0.059 -0.005 0.624 -0.668 0.295 0.678 0.304 -0.412 -0.412 0.417 -0.422 -0.419 0.692 0.409 0.707 0.000 -0.874";
   
   engineLinksThrust     = "7 8";
   engineLinksRetro      = "9";   
   engineLinksClockwise  = "5 7";
   engineLinksCClockwise = "6 8";
 
     
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_HIGH;
   comparativeCrew       = $MULT_HIGHEST;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 15; 
   NumBlackBoxes = 3;
   hullTypeXPMult = 0.75;     
   
   
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "2 3 4 5 6";
   
   externalLinkType2  = $LINK_Launcher;
   externalLinkSize2  = $SLOT_SMALL;
   externalLinkMountRotation2 = 180;         
   
   externalLinkType3  = $LINK_Shooter;
   externalLinkSize3  = $SLOT_SMALL;      
   
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_SMALL;
   
   externalLinkType5  = $LINK_Utility;
   externalLinkSize5  = $SLOT_SMALL;
   
   externalLinkType6  = $LINK_Utility;
   externalLinkSize6  = $SLOT_SMALL;

   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN
   
   doodadLinkTerran_1 = "0.500 0.250 45 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "-0.500 0.250 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_3 = "0.100 -0.900 0 1 0.5 DoodadSet_Terran_S_Antenna";
   
   doodadLinkPirate_1 = "0.100 -0.900 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "-0.100 -0.900 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "0.900 0.100 60 1 0.5 DoodadSet_Pirate_S_Antenna"; 
   
   doodadLinkCiv_1 = "-0.760 0.177 0 0 1 DoodadSet_Civ_S_Lights"; 
   doodadLinkCiv_2 = "0.754 0.187 0 0 1 DoodadSet_Civ_S_Lights"; 
   doodadLinkCiv_3 = "0.900 0.100 60 1 0.5 DoodadSet_Terran_S_Antenna"; 
   
   doodadLinkZombie_1 = "-0.760 0.177 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.754 0.187 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "0.900 0.100 60 1 0.5 DoodadSet_Pirate_S_Antenna"; 

   //BREACH DATA
   breachThresholds["Minor"] = "0.6 0.4";
   breachThresholds["Major"] = "0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.487 0.133 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.309 0.368 Random BreachSet_Tiny";
   
   breachLinks["Major", 1] = "0.225 0.216 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "0.550 -0.147 1 ZombieEggBase";  
   
       
   hullDescriptionBits = $SST_HULL_SURPLUS;
};

/*
datablock HullDatablock(HullGemini : HullSmall) 
{
   friendlyName = "Gemini"; 
   
   imageMapShield = "ship_civ_geminiImageMap";
      
   factionImageMap_Pirate  = "ship_civ_geminiImageMap";
   factionImageMap_Civ  = "ship_civ_geminiImageMap"; 
   factionImageMap_Zombie  = "ship_civ_geminiImageMap"; 
   factionImageMap_Default = "ship_civ_geminiImageMap";
   
   hullIconImageMap = "ship_civ_geminiImageMap";
   purchaseTutorial = "PT_HullScout";       
   
   rootDesign = "GeminiShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 0;
 
   purchaseTutorial = "PT_HullGirlScout";  
   
   size = "64.000 64.000";
   CollisionPolyList = "-0.849 -0.869 0.634 -0.633 0.833 0.845 -0.801 0.727";
   LinkPoints = "0.005 0.000 -0.398 0.879 -0.791 0.427 0.424 -0.334 0.948 0.432 -0.403 -0.417 0.419 0.417";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
     
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_HIGH;
   comparativeCrew       = $MULT_HIGHEST;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 15; 
   NumBlackBoxes = 3;
   hullTypeXPMult = 0.75;     
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   turretLinkPoints = "6 7";
   
   hullTurretSize6  = $SLOT_SMALL;
   hullTurretSize7  = $SLOT_SMALL;
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN
   
   //doodadLinkTerran_1 = "0.500 0.250 45 0 1 DoodadSet_Terran_S_Lights";   
   //doodadLinkTerran_2 = "-0.500 0.250 0 0 1 DoodadSet_Terran_S_Lights";   
   //doodadLinkTerran_3 = "0.100 -0.900 0 1 0.5 DoodadSet_Terran_S_Antenna";
   
   //doodadLinkPirate_1 = "0.100 -0.900 0 0 1 DoodadSet_Pirate_S_Lights"; 
   //doodadLinkPirate_2 = "-0.100 -0.900 0 0 1 DoodadSet_Pirate_S_Lights"; 
   //doodadLinkPirate_3 = "0.900 0.100 60 1 0.5 DoodadSet_Pirate_S_Antenna"; 
   
   //doodadLinkCiv_1 = "-0.760 0.177 0 0 1 DoodadSet_Civ_S_Lights"; 
   //doodadLinkCiv_2 = "0.754 0.187 0 0 1 DoodadSet_Civ_S_Lights"; 
   //doodadLinkCiv_3 = "0.900 0.100 60 1 0.5 DoodadSet_Terran_S_Antenna"; 
   
   //doodadLinkZombie_1 = "-0.760 0.177 0 0 1 DoodadSet_Zombie_S_Lights"; 
   //doodadLinkZombie_2 = "0.754 0.187 0 0 1 DoodadSet_Zombie_S_Lights"; 
   //doodadLinkZombie_3 = "0.900 0.100 60 1 0.5 DoodadSet_Pirate_S_Antenna"; 

   //BREACH DATA
   breachThresholds["Minor"] = "0.6 0.4";
   breachThresholds["Major"] = "0.5";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.487 0.133 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.309 0.368 Random BreachSet_Tiny";
   
   breachLinks["Major", 1] = "0.225 0.216 Random BreachSet_Small"; 
   
   //egg
   embryoInfo[0] = "0.550 -0.147 1 ZombieEggBase";  
   
       
   hullDescriptionBits = $SST_HULL_SURPLUS;
};
*/


/////////////////////////////////////////////
// Zombie ///////////////////////////////////
/////////////////////////////////////////////

datablock HullDatablock(HullZombieLeech : HullSmall_zombie) 
{   
   friendlyName = "Leech"; 
   
   imageMapShield = "ship_zombie_leech_shieldImageMap";
   embryoImage = "leech_embryoImageMap";
      
   factionImageMap_Zombie  = "ship_zombie_leechImageMap";   
   factionImageMap_Default = "ship_zombie_leechImageMap";
   
   hullIconImageMap = "ship_zombie_leech_iconImageMap";      
   
   starLevelUnlock = 1;
   
   rootDesign = "Zombie_LeechShip";  //This is what the player gets when selecting the hull.

   
   size = "64.000 64.000";
   CollisionPolyList = "-0.162 -0.796 0.859 -0.241 0.442 0.614 -0.373 0.614 -0.727 -0.098";
   LinkPoints = "-0.005 0.000 -0.344 -0.575 0.417 0.491 -0.756 0.236 0.535 -0.147";
   
   engineLinksThrust     = "3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
     
   
   externalLinkPoints = "2 4 5";
   
   externalLinkType2  = $LINK_Launcher;
   externalLinkSize2  = $SLOT_SMALL;   
   
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_SMALL;   
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_SMALL;   
   
   NumBlackBoxes = -1;
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkZombie_1 = "-0.052 -0.462 0 1 1 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "0.168 -0.069 0 1 1 DoodadSet_Zombie_S_Node"; 
   //doodadLinkZombie_3 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Small"; 
   
   //egg
   embryoInfo[0] = "-0.388 0.506 1 ZombieEggBase";   
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;
};

datablock HullDatablock(HullZombieWart : HullSmall_zombie) 
{   
   friendlyName = "Wart"; 
   
   imageMapShield = "ship_zombie_wart_shieldImageMap";
   embryoImage = "wart_embryoImageMap";
      
   factionImageMap_Zombie  = "ship_zombie_wartImageMap";   
   factionImageMap_Default = "ship_zombie_wartImageMap"; 
   
   hullIconImageMap = "ship_zombie_wart_iconImageMap";     
   
   rootDesign = "Zombie_WartShip";  //This is what the player gets when selecting the hull.
   
   starLevelUnlock = 1;
   
   
   size = "64.000 64.000";
   CollisionPolyList = "-0.157 -0.825 0.676 -0.300 0.424 0.805 -0.330 0.791 -0.822 -0.025";
   LinkPoints = "0.058 0.005 0.084 0.786 -0.026 -0.869 -0.592 0.000 0.670 -0.010 -0.503 -0.501 0.461 -0.506 -0.377 0.609 0.456 0.579";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
  
   
   comparativeMass       = $MULT_HIGH;
   hullTurnSpeedMod      = $MULT_LOW;    
   
   externalLinkPoints = "6 7 8 9";
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_SMALL;      
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_SMALL;
   
   externalLinkType8  = $LINK_Launcher;
   externalLinkSize8  = $SLOT_SMALL;
   
   externalLinkType9  = $LINK_Launcher;
   externalLinkSize9  = $SLOT_SMALL;
   
   NumBlackBoxes = -1;
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkZombie_1 = "-0.052 -0.462 0 0 0.7 DoodadSet_Zombie_S_Node";   
   doodadLinkZombie_2 = "0.168 -0.069 0 0 0.7 DoodadSet_Zombie_S_Node"; 
   //doodadLinkZombie_3 = "0 0 0 1 1 DoodadSet_Zombie_Glow_Small"; 
   
   //egg
   embryoInfo[0] = "0.430 -0.054 1 ZombieEggBase";   
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;
};





////////////////////////////////////////////////////////////////////////////////
// BOUNTY SHIPS
////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////
// CYCLOPS
////////////////////////////////////////////////////////////////////////////////

datablock HullDatablock(HullBounty_Small_01 : HullSmall) 
{
   friendlyName = "Cyclops"; 
   
   size = "64 64";
   imageMapShield = "ship_bounty_small_01_shieldImageMap";
   
   factionImageMap_Bounty  = "ship_bounty_small_01ImageMap";
   factionImageMap_Pirate  = "ship_bounty_small_01_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bounty_small_01_zombieImageMap"; 
   factionImageMap_Default = "ship_bounty_small_01ImageMap";
   
   hullIconImageMap = "ship_bounty_small_01_iconImageMap";
   purchaseTutorial = "PT_Cyclops";       
   
   starLevelUnlock = 0;
   
   hullArmorSpace        = $SLOT_SMALL;
     
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_HIGH;
   comparativeMass       = $MULT_HIGH;
   RUCost        = 70; 
   NumBlackBoxes = 6;
   hullTypeXPMult = 2;
   
   rootDesign = "BountyShip_Small_01_CIV_A";  //This is what the player gets when selecting the hull.

   CollisionPolyList = "-0.639 -0.732 0.644 -0.732 0.618 0.324 0.021 0.899 -0.639 0.309";
   LinkPoints = "0.010 0.000 -0.571 0.707 0.602 0.717 -0.330 -0.805 0.340 -0.805 0.000 -0.584 -0.215 0.246 0.010 0.501 0.288 0.246";
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 5";
      
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9";
      
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_HUGE;  
   
   externalLinkType7  = $LINK_Utility;
   externalLinkSize7  = $SLOT_SMALL;  
      
   externalLinkType8  = $LINK_Utility;
   externalLinkSize8  = $SLOT_SMALL;  
   
   externalLinkType9  = $LINK_Utility;
   externalLinkSize9  = $SLOT_SMALL;       
   
   doodadLinkBounty_1 = "-0.849 -0.560 0 0 1 DoodadSet_Bounty_S_Lights";   
   doodadLinkBounty_2 = "0.843 -0.560 0 0 1 DoodadSet_Bounty_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.849 -0.560 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.843 -0.560 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.849 -0.560 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.843 -0.560 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.288 -0.476 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.393 -0.103 Random BreachSet_Tiny";
   
   //egg
   embryoInfo[0] = "0.435 -0.275 0 ZombieEggBase"; 
};

////////////////////////////////////////////////////////////////////////////////
// LEFT HOOK
////////////////////////////////////////////////////////////////////////////////

datablock HullDatablock(HullBounty_Small_02 : HullSmall) 
{
   friendlyName = "Left Hook"; 
   
   size = "64 64";
   imageMapShield = "ship_bounty_small_02_shieldImageMap";
   
   factionImageMap_Bounty  = "ship_bounty_small_02ImageMap";
   factionImageMap_Pirate  = "ship_bounty_small_02_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_bounty_small_02_zombieImageMap"; 
   factionImageMap_Default = "ship_bounty_small_02ImageMap";
   
   hullIconImageMap = "ship_bounty_small_02_iconImageMap";
   purchaseTutorial = "PT_LeftHook";       
   
   starLevelUnlock = 0;
   
   hullArmorSpace        = $SLOT_SMALL;
     
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_HIGH;
   comparativeCrew       = $MULT_HIGH;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_LOW;
   RUCost        = 70; 
   NumBlackBoxes = 6;
   hullTypeXPMult = 2;
   
   rootDesign = "BountyShip_Small_02_CIV_A";  //This is what the player gets when selecting the hull.

   CollisionPolyList = "-0.870 -0.584 0.597 -0.648 0.623 0.201 0.147 0.800 -0.849 0.280";
   LinkPoints = "0.215 -0.005 0.230 0.933 0.492 -0.668 0.571 -0.118 -0.906 -0.103 0.676 -0.118 -0.581 -0.349 -0.136 -0.354 -0.576 0.079 -0.120 0.074";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3";   
   engineLinksClockwise  = "5";
   engineLinksCClockwise = "4";
      
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8 9 10";
      
   externalLinkType6  = $LINK_Launcher;
   externalLinkSize6  = $SLOT_LARGE;  
   
   externalLinkType7  = $LINK_Utility;
   externalLinkSize7  = $SLOT_SMALL;  
      
   externalLinkType8  = $LINK_Utility;
   externalLinkSize8  = $SLOT_SMALL;  
   
   externalLinkType9  = $LINK_Utility;
   externalLinkSize9  = $SLOT_SMALL;      
   
   externalLinkType10  = $LINK_Utility;
   externalLinkSize10  = $SLOT_SMALL;   
   
   doodadLinkBounty_1 = "-0.272 -0.737 0 0 1 DoodadSet_Bounty_S_Lights";   
   doodadLinkBounty_2 = "0.566 -0.059 0 0 1 DoodadSet_Bounty_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.272 -0.737 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.566 -0.059 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.272 -0.737 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.566 -0.059 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.372 -0.142 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.299 -0.103 Random BreachSet_Tiny";
   
   //egg
   embryoInfo[0] = "0.435 -0.275 0 ZombieEggBase"; 
};







