datablock HullDatablock(HullZombieBlight_tutorial : HullBase)
{              
   size = "256.000 256.000";  //Large ships are no bigger than this. 
   
   comparativeCargo      = $MULT_AVERAGE;
   comparativeCrew       = $MULT_AVERAGE;
   comparativeHealth     = -1;
   maxComponentHealth    = 300;
      
   comparativeMass       = $MULT_AVERAGE;
   componentSize         = $SLOT_MEDIUM; 

   hullTurnSpeedMod      = $MULT_AVERAGE;  
   hullType              = $HULLTYPE_MEDIUM;   
   
   explosionDatablock    = "BigExplosion_zombie";  
   explosionSound        = "snd_bigExplosion_zombie";
   explosionScale        = "1.5";
   
   disabilityEffectMaxScale  = "0.66";
   hullDamageModifier_Explosive   = "1";  //so explosions do not nuke zombies.

  
   
   hullEngineSpace       = $SLOT_MEDIUM;  
   hullReactorSpace      = $SLOT_MEDIUM;  
   hullShieldSpace       = $SLOT_MEDIUM;  
   hullArmorSpace        = $SLOT_MEDIUM;
   
   engineCoreLink = "";
   reactorCoreLink = "";
   shieldCoreLink = "";
 
   largeEscapePodChance  = 0.25; 
   
   invasionEffectScale_Zombie = 1;
   invasionEffectScale_Terran  = 1;
   invasionEffectScale_Civ  = 1;
   invasionEffectScale_Pirate  = 1;
   
   debrisCluster_Light = "DC_Combat_Large_Light_Zombie";  
   debrisCluster_Heavy = "DC_Combat_Large_Heavy_Zombie";  
   
   subExplosionDatablockWL  = "BigExplosion_zombie 10 MediumExplosion_zombie 50";  
   subExplosionScale        = 0.667;
   
   embryoInfo[0] = "0 1 3 ZombieEggBase";
   
   burstSpawnEffectScale = 0.850;
   
   miniHudIcon = "ShipDisplay_hull_mediumImageMap";
   
   hullTypeXPMult = 1.0;
   hullDescriptionBits = $SST_HULL_MILITARY;
   
   hullHitEffect         = "hullImpact_zombie";
   hullHitSound          = "snd_hullHit_zombie";  

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
   
   maxCrewSize = 1;  
   comparativeCrew       = -1;
   doNotAddToDatabase = true;      
};

datablock HullDatablock(HullTug_SM_09 : HullTug) 
{
   NumBlackBoxes = -1;
   hullTypeXPMult = 0.01; //give very little xp to prevent exploit
   comparativeCargo = $MULT_LOWEST;
   comparativeCrew  = $MULT_LOWEST;
   blossomRangeMult = 1.5;
   doNotAddToDatabase = true;      
};

