///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// TINY HULLS BASE
///////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Base for all tiny hulls
datablock HullDatablock(HullTiny : HullBase)
{        
      
   size = "48.000 48.000";  //tiny ships are no bigger than this. 
   
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   componentSize         = $SLOT_SMALL;  //MEANINGLESS HERE

   hullTurnSpeedMod      = $MULT_AVERAGE;  
   hullType              = $HULLTYPE_TINY;   
   
   explosionDatablock    = "MediumExplosion_Debris";  
   explosionScale        = "0.8";  
   explosionSound        = "snd_mediumExplosion_ship";
    
   
   disabilityEffectMaxScale  = "0.33";
   
   invasionEffectScale_Zombie = 0.4;
   invasionEffectScale_Terran  = 0.4;
   invasionEffectScale_Civ  = 0.4;
   invasionEffectScale_Pirate  = 0.4;
   
   
   hullEngineSpace       = $SLOT_SMALL;  
   hullReactorSpace      = $SLOT_SMALL;  
   hullShieldSpace       = $SLOT_SMALL;    //we use small components for these ships. 
   
   hullArmorSpace        = $SLOT_NONE;

   
   engineCoreLink = "";
   reactorCoreLink = "";
   shieldCoreLink = "";
   
   debrisCluster_Light = "DC_Combat_Small_Light";  
   debrisCluster_Heavy = "DC_Combat_Small_Heavy";  
   
   subExplosionDatablockWL  = "SmallExplosion";  
   subExplosionScale        = 0.5;
   subExplosionSoundWL      = "snd_smallExplosion_cascade 10 snd_smallExplosion 10";
   
   embryoInfo[0] = "0 1 0 ZombieEggBase";
   
   //snd_mediumExplosion
   
   miniHudIcon = "ShipDisplay_hull_smallImageMap"; 
   
   burstSpawnEffectScale = 0.5;
   
   hullTypeXPMult = 1.0;
};

datablock HullDatablock(HullTiny_zombie : HullTiny)
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

datablock HullDatablock(HullShortBus : HullTiny) 
{   
   friendlyName = "Short Bus"; 
   
   hullDescriptionBits = $SST_HULL_MINING;
   comparativeHealth   = $MULT_VERYLOW;
   
   
   imageMapShield = "ship_shortbus_shieldImageMap";
   
   //factionImageMap_Terran  = "ship_shortbusImageMap"; no terran version
   factionImageMap_Pirate  = "ship_shortbusImageMap"; 
   factionImageMap_Default = "ship_shortbusImageMap";
   factionImageMap_Zombie = "ship_shortbus_zomImageMap";
   factionImageMap_Civ = "ship_civ_shortbusImageMap";
   
   
   hullIconImageMap = "ship_shortbus_iconImageMap";
   purchaseTutorial = "PT_HullShortBus";         
   
   rootDesign = "ShortBusShip";  //This is what the player gets when selecting the hull.

   starLevelUnlock = 0;
      
   CollisionPolyList = "-0.560 -0.894 0.482 -0.913 0.492 0.864 -0.534 0.850";
   LinkPoints = "-0.005 0.005 -0.257 0.869 0.272 0.859 -0.524 -0.732 0.487 -0.737 0.000 -0.668 0.350 0.250 -0.350 0.250";

   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
   
  
   
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_CARGOCARRIER;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_VERYLOW;
   comparativeMass       = $MULT_HIGH;
   RUCost = 0; 
   NumBlackBoxes = 0;
   hullTypeXPMult = 0.25;
   
   
  
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "6 7 8";
   
   externalLinkType6  = $LINK_Mining;
   externalLinkSize6  = $SLOT_SMALL; 
   
   externalLinkType7 = $LINK_Utility;
   externalLinkSize7 = $SLOT_SMALL;   
   
   externalLinkType8 = $LINK_Utility;
   externalLinkSize8 = $SLOT_SMALL;     

   RUCost = 0; 
   NumBlackBoxes = 0;
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN
   
   doodadLinkTerran_1 = "-0.534 -0.383 0 0 1 DoodadSet_Terran_S_Lights"; 
   doodadLinkTerran_2 = "0.534 -0.393 0 0 1 DoodadSet_Terran_S_Lights";   
   
   doodadLinkPirate_1 = "-0.534 -0.383 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_2 = "0.534 -0.393 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkCiv_1 = "-0.534 -0.383 0 0 1 DoodadSet_Civ_S_Lights"; 
   doodadLinkCiv_2 = "0.534 -0.393 0 0 1 DoodadSet_Civ_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.534 -0.383 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_2 = "0.534 -0.393 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA
   breachThresholds["Minor"] = "0.6 0.4";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.241 -0.093 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.141 0.363 Random BreachSet_Tiny";
   
   //egg
   embryoInfo[0] = "0.141 0.363 1 ZombieEggBase";   
   
   
};

/////////////////////////////////////////////
// THE DART
/////////////////////////////////////////////

datablock HullDatablock(HullDart : HullTiny) 
{
   friendlyName = "Dart"; 
   
   size = "48.000 48.000";
   imageMapShield = "ship_dart_shieldImageMap";
   
   factionImageMap_Terran  = "ship_dartImageMap";
   factionImageMap_Pirate  = "ship_dart_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_dart_zomImageMap"; 
   factionImageMap_Default = "ship_dartImageMap";
   
   hullIconImageMap = "ship_dart_iconImageMap"; 
   purchaseTutorial = "PT_HullDart";     
   
   starLevelUnlock = 0;
      
  
   hullTurnSpeedMod      = $MULT_VERYHIGH; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_LOW;
   RUCost                = 5; 
   NumBlackBoxes = 2;
   hullTypeXPMult = 1;
   

   rootDesign = "DartShip";  //This is what the player gets when selecting the hull.

   CollisionPolyList = "-0.618 -0.869 0.592 -0.869 0.828 0.840 -0.838 0.854";
   LinkPoints = "-0.005 0.000 0.005 0.462 -0.566 -0.673 0.540 -0.678 0.000 -0.496 0.000 -0.776 -0.870 -0.172 0.854 -0.167";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "6";   
   engineLinksClockwise  = "7";
   engineLinksCClockwise = "8";
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "3 4";
   
   externalLinkType3  = $LINK_Shooter;
   externalLinkSize3  = $SLOT_SMALL;  
   
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_SMALL;  

   
   
   doodadLinkTerran_1 = "-0.498 0.000 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "0.503 -0.005 0 0 1 DoodadSet_Terran_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.498 0.000 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.503 -0.005 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.498 0.000 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.503 -0.005 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.540 -0.501 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.000 -0.255 Random BreachSet_Tiny";
   
   //egg
   embryoInfo[0] = "0.005 -0.049 0 ZombieEggBase";   
   
  
};

/////////////////////////////////////////////
// THE RANGER
/////////////////////////////////////////////

datablock HullDatablock(HullRanger : HullTiny) 
{
   friendlyName = "Scout"; //swapped name with scout 
   
   size = "48.000 48.000";
   imageMapShield = "ship_ranger_shieldImageMap";
   
   factionImageMap_Terran  = "ship_rangerImageMap";
   factionImageMap_Pirate  = "ship_ranger_pirateImageMap"; 
   factionImageMap_Zombie  = "ship_ranger_zomImageMap"; 
   factionImageMap_Default = "ship_rangerImageMap";
   
   hullIconImageMap = "ship_ranger_iconImageMap"; 
   purchaseTutorial = "PT_HullRanger";      
   
   starLevelUnlock = 0;
      
      
   hullTurnSpeedMod      = $MULT_AVERAGE; 
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_AVERAGE;
   RUCost                = 5; 
   NumBlackBoxes = 2;
   hullTypeXPMult = 1.5;

   rootDesign = "RangerShip";  //This is what the player gets when selecting the hull.

   CollisionPolyList = "-0.288 -0.830 0.246 -0.840 0.581 0.211 0.005 0.859 -0.592 0.211";
   LinkPoints = "0.000 0.005 0.000 0.864 0.000 -0.835 -0.524 -0.422 0.529 -0.427";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "4";
   engineLinksCClockwise = "5";
      
   
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "2 3";
   
   externalLinkType3  = $LINK_Shooter;
   externalLinkSize3  = $SLOT_SMALL;  
   
   externalLinkType2  = $LINK_Launcher;
   externalLinkSize2  = $SLOT_SMALL;
   externalLinkMountRotation2 = 180;  
   
         
   doodadLinkTerran_1 = "0.000 -0.707 0 0 1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "-0.005 0.501 0 0 1 DoodadSet_Terran_S_Lights"; 
   
   doodadLinkPirate_1 = "0.000 -0.707 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "-0.005 0.501 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "0.000 -0.707 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "-0.005 0.501 0 0 1 DoodadSet_Zombie_S_Lights"; 
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.110 -0.300 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.147 0.250 Random BreachSet_Tiny"; 
   
   //egg
   embryoInfo[0] = "0.340 0.467 0 ZombieEggBase"; 
   
   
};

/////////////////////////////////////////////
// CIV SHIPS
/////////////////////////////////////////////

datablock HullDatablock(HullMole : HullTiny) 
{
   friendlyName = "Mole"; 
   hullDescriptionBits = $SST_HULL_SURPLUS;
   
   purchaseTutorial = "PT_HullMole";  
   
   size = "48.000 48.000";
   imageMapShield = "ship_civ_mole_shieldImageMap";
      
   factionImageMap_Civ     = "ship_civ_moleImageMap"; 
   factionImageMap_Pirate     = "ship_civ_mole_pirateImageMap"; 
   factionImageMap_Zombie     = "ship_civ_mole_zomImageMap"; 
   factionImageMap_Default = "ship_civ_moleImageMap";
   
   hullIconImageMap = "ship_civ_mole_iconImageMap";    
   
   starLevelUnlock = 0;
    
   
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = $MULT_AVERAGE;
   comparativeMass       = $MULT_VERYHIGH;
   RUCost                = 5; 
   NumBlackBoxes = 1;
   hullTypeXPMult = 1;
   

   rootDesign = "MoleShip";  //This is what the player gets when selecting the hull.

   CollisionPolyList = "-0.005 -0.874 0.602 -0.319 0.597 0.683 -0.592 0.688 -0.608 -0.304";
   LinkPoints = "-0.005 0.496 0.000 0.953 -0.320 0.329 0.309 0.319 -0.492 -0.265 0.487 -0.270";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3 4";   
   engineLinksClockwise  = "3";
   engineLinksCClockwise = "4";
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "5 6";
   
   externalLinkType5  = $LINK_Launcher;
   externalLinkSize5  = $SLOT_SMALL; 
   externalLinkMountRotation5 = -45; 
   
   externalLinkType6  = $LINK_Launcher;
   externalLinkSize6  = $SLOT_SMALL;
   externalLinkMountRotation6 = 45;    
   
   //externalLinkType6  = $LINK_Utility;
   //externalLinkSize6  = $SLOT_SMALL;  
  
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkCiv_1 = "-0.498 0.000 0 0 1 DoodadSet_Civ_S_Lights";   
   doodadLinkCiv_2 = "0.503 -0.005 0 0 1 DoodadSet_Civ_S_Lights"; 
   doodadLinkCiv_3 = "0.262 -0.845 0 1 0.8 DoodadSet_Terran_S_Antenna";
   
   doodadLinkPirate_1 = "-0.498 0.000 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.503 -0.005 0 0 1 DoodadSet_Pirate_S_Lights"; 
   doodadLinkPirate_3 = "0.262 -0.845 0 1 0.8 DoodadSet_Pirate_S_Antenna";
   
   doodadLinkZombie_1 = "-0.498 0.000 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.503 -0.005 0 0 1 DoodadSet_Zombie_S_Lights"; 
   doodadLinkZombie_3 = "0.262 -0.845 0 1 0.8 DoodadSet_Pirate_S_Antenna";
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.000 0.555 Random BreachSet_Tiny";
   
   //egg
   embryoInfo[0] = "-0.272 0.619 0 ZombieEggBase"; 
   
};

////////////////////////////////////////////////////////////////////////////////
// THE CAB
////////////////////////////////////////////////////////////////////////////////

datablock HullDatablock(HullCab : HullTiny) 
{
   friendlyName = "Petri"; 
   
   size = "48.000 48.000";
   imageMapShield = "ship_civ_cab_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_cab_pirateImageMap"; 
   factionImageMap_Civ  = "ship_civ_cabImageMap"; 
   factionImageMap_Zombie  = "ship_civ_cab_zomImageMap"; 
   factionImageMap_Default = "ship_civ_cabImageMap"; 
   
   hullIconImageMap = "ship_civ_cab_iconImageMap";    
   
   starLevelUnlock = 0;
   
   purchaseTutorial = "PT_HullCab";    
   
   hullTurnSpeedMod      = $MULT_LOW; 
   comparativeCargo      = $MULT_HIGH;
   comparativeCrew       = $MULT_VERYHIGH;
   comparativeHealth     = $MULT_HIGH;
   comparativeMass       = $MULT_HIGH;
   RUCost                = 5; 
   NumBlackBoxes = 2;
   hullTypeXPMult = 1;
   
   

   rootDesign = "CabShip";  //This is what the player gets when selecting the hull.
   
   CollisionPolyList = "-0.398 -0.781 0.430 -0.786 0.576 0.761 -0.560 0.761";
   LinkPoints = "0.031 0.010 -0.409 0.688 0.409 0.692 -0.335 -0.599 0.346 -0.579 0.016 0.737 -0.358 -0.068 0.393 -0.073 0.015 -0.822";
   
   engineLinksThrust     = "6";
   engineLinksRetro      = "9";   
   engineLinksClockwise  = "7";
   engineLinksCClockwise = "8";
         
   externalLinkPoints = "2 3 4 5";
   
   externalLinkType2  = $LINK_Utility;
   externalLinkSize2  = $SLOT_SMALL;  
   
   externalLinkType3  = $LINK_Utility;
   externalLinkSize3  = $SLOT_SMALL;  
   
   externalLinkType4  = $LINK_Shooter;
   externalLinkSize4  = $SLOT_SMALL; 
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_SMALL;  
      
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkCiv_1 = "-0.498 0.000 0 0 1 DoodadSet_Civ_S_Lights";   
   doodadLinkCiv_2 = "0.503 -0.005 0 0 1 DoodadSet_Civ_S_Lights";
   
   doodadLinkPirate_1 = "-0.498 0.000 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.503 -0.005 0 0 1 DoodadSet_Pirate_S_Lights"; 
   
   doodadLinkZombie_1 = "-0.498 0.000 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.503 -0.005 0 0 1 DoodadSet_Zombie_S_Lights";  
   
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.141 -0.123 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.152 0.427 Random BreachSet_Tiny"; 
   
   //egg
   embryoInfo[0] = "-0.293 0.638 0 ZombieEggBase";   
   
   hullDescriptionBits = $SST_HULL_SCIENCE;
};

/////////////////////////////////////////////
// THE RETENA
/////////////////////////////////////////////

datablock HullDatablock(HullRetina : HullTiny) 
{
   friendlyName = "Gyro"; 
   
   size = "48.000 48.000";
   imageMapShield = "ship_civ_retina_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_civ_retina_pirateImageMap";
   factionImageMap_Civ  = "ship_civ_retinaImageMap"; 
   factionImageMap_Zombie  = "ship_civ_retina_zomImageMap"; 
   factionImageMap_Default = "ship_civ_retinaImageMap";
   
   hullIconImageMap = "ship_civ_retina_iconImageMap";     
   
   starLevelUnlock = 0;
   
     
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_HIGHEST;
   comparativeHealth     = $MULT_VERYHIGH;
   comparativeMass       = $MULT_LOW;
   RUCost                = 5; 
   NumBlackBoxes = 2;
   hullTypeXPMult = 1;
   
   purchaseTutorial = "PT_HullRetina";   
      
   comparativeMass       = $MULT_LOW;  //high tech science bubble   
   hullTurnSpeedMod      = $MULT_AVERAGE;  //turns slow  

   rootDesign = "RetinaShip";  //This is what the player gets when selecting the hull.
   
   CollisionPolyList = "-0.435 -0.796 0.367 -0.796 0.864 0.025 0.691 0.756 -0.613 0.786 -0.890 0.015";
   LinkPoints = "0.005 0.005 0.005 0.398 -0.707 -0.452 0.655 -0.486";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3 4";   
   engineLinksClockwise  = "2 3";
   engineLinksCClockwise = "2 4";
   
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink    
   turretLinkPoints = "1"; 
   hullTurretSize1  = $SLOT_SMALL;    
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkCiv_1 = "-0.498 0.000 0 0 1 DoodadSet_Civ_S_Lights";   
   doodadLinkCiv_2 = "0.503 -0.005 0 0 1 DoodadSet_Civ_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.498 0.000 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.503 -0.005 0 0 1 DoodadSet_Pirate_S_Lights"; 
        
   doodadLinkZombie_1 = "-0.498 0.000 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.503 -0.005 0 0 1 DoodadSet_Zombie_S_Lights";         
        
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "0.529 -0.319 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "-0.010 -0.530 Random BreachSet_Tiny"; 
   
   //egg
   embryoInfo[0] = "-0.702 -0.383 0 ZombieEggBase";  
   
   hullDescriptionBits = $SST_HULL_COLONY;
};

/////////////////////////////////////////////
// ZOMBIE SHIPS
/////////////////////////////////////////////

/////////////////////////////////////////////
// THE TICK
/////////////////////////////////////////////

datablock HullDatablock(HullTick : HullTiny_zombie) 
{
   friendlyName = "Tick";    
   
   size = "48.000 48.000";
   embryoImage = "tick_embryoImageMap";
   
   imageMapShield = "ship_zombie_tick_shieldImageMap";
   
   factionImageMap_Zombie  = "ship_zombie_tickImageMap"; 
   factionImageMap_Default = "ship_zombie_tickImageMap"; 
   
   hullIconImageMap = "ship_zombie_tick_iconImageMap";    
   
   starLevelUnlock = 0;
   
      
   comparativeMass       = $MULT_AVERAGE;  
   hullTurnSpeedMod      = $MULT_AVERAGE;  

   rootDesign = "Zombie_TickShip";  //This is what the player gets when selecting the hull.

      
   CollisionPolyList = "-0.330 -0.943 0.838 -0.059 -0.120 0.908 -0.901 0.025";
   LinkPoints = "-0.037 0.128 -0.220 0.673 -0.513 0.118 0.571 0.049 -0.136 -0.344";
   
   engineLinksThrust     = "2";
   engineLinksRetro      = "3 4";   
   engineLinksClockwise  = "3";
   engineLinksCClockwise = "4";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   externalLinkPoints = "5 ";
   
   externalLinkType5  = $LINK_Shooter;
   externalLinkSize5  = $SLOT_SMALL;  

   RUCost        = 2; 
   NumBlackBoxes = -1;
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN  
   
   //egg
   embryoInfo[0] = "0.178 0.565 0 ZombieEggBase";    
   
   hullDescriptionBits = $SST_HULL_ZOMBIE;
};


/////////////////////////////////////////////
// BOUNTY SHIPS
/////////////////////////////////////////////

datablock HullDatablock(HullBounty_Tiny_01 : HullTiny) 
{
   friendlyName = "Claw"; 
   
   size = "48.000 48.000";
   imageMapShield = "ship_bounty_tiny_01_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_bounty_tiny_01_pirateImageMap";
   factionImageMap_Zombie  = "ship_bounty_tiny_01_zombieImageMap"; 
   factionImageMap_Bounty  = "ship_bounty_tiny_01ImageMap";
   factionImageMap_Default = "ship_bounty_tiny_01ImageMap";
   
   hullIconImageMap = "ship_bounty_tiny_01_iconImageMap";     
   
   starLevelUnlock = 0;
   
   hullTurnSpeedMod      = $MULT_AVERAGE; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_VERYLOW;
   comparativeMass       = $MULT_AVERAGE;
   RUCost                = 15; 
   NumBlackBoxes = 5;
   hullTypeXPMult = 2;
   
   purchaseTutorial = "PT_Claw";   
      
 
   rootDesign = "BountyShip_Tiny_01_CIV_A";  //This is what the player gets when selecting the hull.
   
   CollisionPolyList = "-0.786 -0.324 -0.005 -0.913 0.723 -0.314 0.183 0.889 -0.225 0.889";
   LinkPoints = "-0.010 0.000 -0.183 0.570 0.141 0.570 -0.168 -0.908 0.136 -0.918 -0.498 -0.609 0.471 -0.619";
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4 5";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 5";
   
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink    
   externalLinkPoints = "6 7";
   
   externalLinkType6  = $LINK_Shooter;
   externalLinkSize6  = $SLOT_MEDIUM; 
   
   externalLinkType7  = $LINK_Shooter;
   externalLinkSize7  = $SLOT_MEDIUM;    
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkBounty_1 = "-0.010 -0.633 0 0 1 DoodadSet_Bounty_S_Lights";   
   doodadLinkBounty_2 = "0.000 0.869 0 0 1 DoodadSet_Bounty_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.010 -0.633 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.000 0.869 0 0 1 DoodadSet_Pirate_S_Lights"; 
        
   doodadLinkZombie_1 = "-0.010 -0.633 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.000 0.869 0 0 1 DoodadSet_Zombie_S_Lights";         
        
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.340 -0.138 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.079 0.324 Random BreachSet_Tiny"; 
   
    
   
   //egg
   embryoInfo[0] = "-0.702 -0.383 0 ZombieEggBase";  
};

datablock HullDatablock(HullBounty_Tiny_02 : HullTiny) 
{
   friendlyName = "Wasp"; 
   
   size = "48.000 48.000";
   imageMapShield = "ship_bounty_tiny_02_shieldImageMap";
   
   factionImageMap_Pirate  = "ship_bounty_tiny_02_pirateImageMap";
   factionImageMap_Zombie  = "ship_bounty_tiny_02_zombieImageMap"; 
   factionImageMap_Bounty  = "ship_bounty_tiny_02ImageMap";
   factionImageMap_Default = "ship_bounty_tiny_02ImageMap";
   
   hullIconImageMap = "ship_bounty_tiny_02_iconImageMap";     
   
   starLevelUnlock = 0;
   
   hullTurnSpeedMod      = $MULT_HIGH; 
   comparativeCargo      = $MULT_LOW;
   comparativeCrew       = $MULT_LOW;
   comparativeHealth     = $MULT_LOW;
   comparativeMass       = $MULT_LOW;
   RUCost                = 15; 
   NumBlackBoxes = 5;
   hullTypeXPMult = 2;
   
   purchaseTutorial = "PT_Wasp";   
  
   rootDesign = "BountyShip_Tiny_02_CIV_A";  //This is what the player gets when selecting the hull.
   
   CollisionPolyList = "0.152 -0.859 0.943 0.432 0.141 0.958 -0.723 -0.147";
   LinkPoints = "0.136 0.000 -0.105 0.776 0.382 0.776 0.126 -0.786 -0.702 -0.162 0.131 -0.388 0.131 0.358";
   
   engineLinksThrust     = "2 3";
   engineLinksRetro      = "4";   
   engineLinksClockwise  = "2 4";
   engineLinksCClockwise = "3 4";
   
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink    
   externalLinkPoints = "5 6 7";
   
   externalLinkType5  = $LINK_Launcher;
   externalLinkSize5  = $SLOT_MEDIUM; 
   
   externalLinkType6  = $LINK_Utility;
   externalLinkSize6  = $SLOT_SMALL; 
   
   externalLinkType7  = $LINK_Utility;
   externalLinkSize7  = $SLOT_SMALL;    
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   
   doodadLinkBounty_1 = "-0.079 -0.908 0 0 1 DoodadSet_Bounty_S_Lights";   
   doodadLinkBounty_2 = "0.959 0.447 0 0 1 DoodadSet_Bounty_S_Lights"; 
   
   doodadLinkPirate_1 = "-0.079 -0.908 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "0.959 0.447 0 0 1 DoodadSet_Pirate_S_Lights"; 
      
   doodadLinkZombie_1 = "-0.079 -0.908 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "0.959 0.447 0 0 1 DoodadSet_Zombie_S_Lights";       
        
   //BREACH DATA     
   breachThresholds["Minor"] = "0.5";
   breachThresholds["Major"] = "";
   
   //breachLink_# offsetX offsetY rotation BreachSet
   breachLinks["Minor", 1] = "-0.079 -0.432 Random BreachSet_Tiny";
   breachLinks["Minor", 2] = "0.320 0.226 Random BreachSet_Tiny"; 
   
   //egg
   embryoInfo[0] = "-0.702 -0.383 0 ZombieEggBase";  
};

