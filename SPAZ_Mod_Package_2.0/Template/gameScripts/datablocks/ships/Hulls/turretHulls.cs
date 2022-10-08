////////////////////////////////////////////////////////////////////////////////
//DEPLOYABLE TURRETS
////////////////////////////////////////////////////////////////////////////////

datablock HullDatablock(HullTurret : HullStation) 
{   
   friendlyName = "Deployable Turret Base";    
   
   size = "64 64";   
   imageMapShield = "base_circle_shieldImageMap";
   
   explosionDatablock    = "MediumExplosion_Debris";  
   explosionScale        = "0.65";  
   explosionSound        = "snd_mediumExplosion";
   explosionCascadeMulti = 0.15; //tiny cascade
   
   rootDesign = "DeployTurretShip_Surplus";
   
   hasShockwave = false;  
   canBeInvaded = false;   
   isTurretHull = true;
   
   maxCrewSize = 1;  //if blows up we only lose 1 crew
   comparativeCrew       = -1;
      
   factionImageMap_Default = "deployTurret_large_01ImageMap"; 
   factionImageMap_Terran = "deployTurret_large_01ImageMap"; 
   factionImageMap_Pirate = "deployTurret_large_01_pirateImageMap";
   factionImageMap_Civ = "deployTurret_large_01_civImageMap";
   factionImageMap_Zombie = "deployTurret_large_01_zomImageMap";
   factionImageMap_Bounty = "deployTurret_large_01_bountyImageMap";
   
   hullIconImageMap = "deployTurret_large_01_iconImageMap";   
   miniHudIcon = "deployTurret_large_01_iconImageMap";   
         
   CollisionPolyList = "-0.058 -0.805 0.650 -0.540 0.786 0.025 0.576 0.633 0.005 0.820 -0.592 0.619 -0.822 0.020 -0.634 -0.570";
   LinkPoints = "-0.021 0.010";
   
   maxComponentHealth    = 60; 
   comparativeHealth     = -1; //skip
      
   engineLinksThrust     = "";
   engineLinksRetro      = "";   
   engineLinksClockwise  = "";
   engineLinksCClockwise = "";
 
   
   //Link types are ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   turretLinkPoints = "1";

   hullTurretSize1 = $SLOT_MEDIUM;    
   
   //doodadLink_Faction# offsetX offsetY rotation isUnderShip creationChance DoodadDatablockOrSet1 ...DoodadDatablockOrSetN   
   doodadLinkTerran_1 = "0.6 0.6 0  1 DoodadSet_Terran_S_Lights";   
   doodadLinkTerran_2 = "-0.6 -0.6 0 0 1 DoodadSet_Terran_S_Lights";
   doodadLinkTerran_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
      
   doodadLinkPirate_1 = "0.6 0.6 0 0 1 DoodadSet_Pirate_S_Lights";   
   doodadLinkPirate_2 = "-0.6 -0.6 0 0 1 DoodadSet_Pirate_S_Lights";
   doodadLinkPirate_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   
   doodadLinkCiv_1 = "0.6 0.6 0 0 1 DoodadSet_Civ_S_Lights";   
   doodadLinkCiv_2 = "-0.6 -0.6 0 0 1 DoodadSet_Civ_S_Lights";
   doodadLinkCiv_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   
   doodadLinkZombie_1 = "0.6 0.6 0 0 1 DoodadSet_Zombie_S_Lights";   
   doodadLinkZombie_2 = "-0.6 -0.6 0 0 1 DoodadSet_Zombie_S_Lights";
   doodadLinkZombie_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   
   doodadLinkBounty_1 = "0.6 0.6 0  1 DoodadSet_Bounty_S_Lights";   
   doodadLinkBounty_2 = "-0.6 -0.6 0 0 1 DoodadSet_Bounty_S_Lights";
   doodadLinkBounty_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   
   breachLinks["Minor", 1] = "0.2 0.2 Random BreachSet_Small";
   breachLinks["Major", 1] = "0 0 Random BreachSet_Huge";
   
   //egg
   embryoInfo[0] = "0 0 1 ZombieEggBase";  
   
   hullTypeXPMult = 0.025;
   
   comparativeCargo = -1;
   hullCargoSpace = 25;
   
   threatMult = 0;
   blossomRangeMult = 0.15;
   
   
};

//SURPLUS
datablock HullDatablock(DeployTurretHull_Surplus : HullTurret) 
{   
   friendlyName = "Focal Turret";    
   
   size = "64 64";  
   explosionScale        = "0.65";    
   rootDesign = "DeployTurretShip_Surplus";
   
   doodadLinkTerran_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   doodadLinkPirate_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   doodadLinkCiv_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   doodadLinkZombie_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   doodadLinkBounty_3 = "0 0 0 1 1 Doodad_DeployTurret_Beam"; 
   
   maxComponentHealth    = 15; 
   
   hullTurretSize1 = $SLOT_MEDIUM;       
};

//BASIC
datablock HullDatablock(DeployTurretHull_Basic : HullTurret) 
{   
   friendlyName = "Disruptor Turret";    
   
   size = "64 64";  
   explosionScale        = "0.65";    
   rootDesign = "DeployTurretShip_Surplus";
   
   doodadLinkTerran_3 = "0 0 0 1 1 Doodad_DeployTurret_Cannon"; 
   doodadLinkPirate_3 = "0 0 0 1 1 Doodad_DeployTurret_Cannon"; 
   doodadLinkCiv_3 = "0 0 0 1 1 Doodad_DeployTurret_Cannon"; 
   doodadLinkZombie_3 = "0 0 0 1 1 Doodad_DeployTurret_Cannon"; 
   doodadLinkBounty_3 = "0 0 0 1 1 Doodad_DeployTurret_Cannon"; 
   
   maxComponentHealth    = 25; 
   
   hullTurretSize1 = $SLOT_MEDIUM;       
};

//IMPROVED
datablock HullDatablock(DeployTurretHull_Ion : HullTurret) 
{   
   friendlyName = "Stealth Ion Turret";    
   
   size = "64 64";  //would be cool to have a scarier looking one with spikes
   explosionScale        = "0.65";    
   rootDesign = "DeployTurretShip_Surplus";
   
   doodadLinkTerran_3 = "0 0 0 1 1 Doodad_DeployTurret_Ion"; 
   doodadLinkPirate_3 = "0 0 0 1 1 Doodad_DeployTurret_Ion"; 
   doodadLinkCiv_3 = "0 0 0 1 1 Doodad_DeployTurret_Ion"; 
   doodadLinkZombie_3 = "0 0 0 1 1 Doodad_DeployTurret_Ion"; 
   doodadLinkBounty_3 = "0 0 0 1 1 Doodad_DeployTurret_Ion"; 
   
   maxComponentHealth    = 50; 
   
   hullTurretSize1 = $SLOT_MEDIUM;       
};

//IMPROVED
datablock HullDatablock(DeployTurretHull_Leech : HullTurret) 
{   
   friendlyName = "Stealth Leech Turret";    
   
   size = "64 64";  //would be cool to have a scarier looking one with spikes
   explosionScale        = "0.65";    
   rootDesign = "DeployTurretShip_Surplus";
   
   doodadLinkTerran_3 = "0 0 0 1 1 Doodad_DeployTurret_Leech"; 
   doodadLinkPirate_3 = "0 0 0 1 1 Doodad_DeployTurret_Leech"; 
   doodadLinkCiv_3 = "0 0 0 1 1 Doodad_DeployTurret_Leech"; 
   doodadLinkZombie_3 = "0 0 0 1 1 Doodad_DeployTurret_Leech"; 
   doodadLinkBounty_3 = "0 0 0 1 1 Doodad_DeployTurret_Leech"; 
   
   maxComponentHealth    = 50; 
   
   hullTurretSize1 = $SLOT_MEDIUM;       
};

//ADVANCED
datablock HullDatablock(DeployTurretHull_Torpedo : HullTurret) 
{   
   friendlyName = "Torpedo Rack";    
   
   size = "64 64";   //moooooooooooooooooore spikes!
   explosionScale        = "0.65";    
   rootDesign = "DeployTurretShip_Surplus";
   
   LinkPoints = "-0.021 0.010 0.001 0.001"; //second link for the scanner.
   externalLinkPoints = "2";
   
   externalLinkType2  = $LINK_Utility;
   externalLinkSize2  = $SLOT_LARGE;
   
   doodadLinkTerran_3 = "0 0 0 1 1 Doodad_DeployTurret_Torp"; 
   doodadLinkPirate_3 = "0 0 0 1 1 Doodad_DeployTurret_Torp"; 
   doodadLinkCiv_3 = "0 0 0 1 1 Doodad_DeployTurret_Torp"; 
   doodadLinkZombie_3 = "0 0 0 1 1 Doodad_DeployTurret_Torp"; 
   doodadLinkBounty_3 = "0 0 0 1 1 Doodad_DeployTurret_Torp"; 
   
   maxComponentHealth    = 100; 
   
   hullTurretSize1 = $SLOT_MEDIUM;       
};

//ADVANCED
datablock HullDatablock(DeployTurretHull_BattleStation : HullTurret) 
{   
   friendlyName = "Battle Station";    
   
   size = "64 64";   //moooooooooooooooooore spikes!
   explosionScale        = "0.65";    
   rootDesign = "DeployTurretShip_Surplus";
   
   LinkPoints = "-0.021 0.010 0.001 0.001"; //second link for the scanner.
   externalLinkPoints = "2";
   
   externalLinkType2  = $LINK_Utility;
   externalLinkSize2  = $SLOT_LARGE;
   
   doodadLinkTerran_3 = "0 0 0 1 1 Doodad_DeployTurret_Rapid"; 
   doodadLinkPirate_3 = "0 0 0 1 1 Doodad_DeployTurret_Rapid"; 
   doodadLinkCiv_3 = "0 0 0 1 1 Doodad_DeployTurret_Rapid"; 
   doodadLinkZombie_3 = "0 0 0 1 1 Doodad_DeployTurret_Rapid"; 
   doodadLinkBounty_3 = "0 0 0 1 1 Doodad_DeployTurret_Rapid"; 
   
   maxComponentHealth    = 200; 
   
   hullTurretSize1 = $SLOT_HUGE;       
};



