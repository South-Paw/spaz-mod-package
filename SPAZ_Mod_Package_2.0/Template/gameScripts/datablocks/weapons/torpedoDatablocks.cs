
datablock TorpedoDatablock(TorpedoBase) 
{
   launchSound = "snd_smallTorpLaunch";
   explosionSound = "snd_smallExplosion";
   hasLightFlash = false;
   subProjectileCount = "0";
   isMassBomb = false;
   
   CollisionPolyList = "-0.241 -0.884 0.069 -0.884 0.069 0.869 -0.246 0.869";
   LinkPoints = "0.000 0.000 0.000 1.000";
   
   researchDatablock = "MissileResearch";
   
   engineDatablock_Zombie = "ZombieThruster"; 
   thrustEffectScale = 1;
   
   launchImpulse = 100;
   launchDir     = 0;  //direction is mirrored if missile is on the left side.  
   launchDamping = 0;
 
   isCloaking = false;
   
   spawnEffect = "MissileReloadFlash";
   spawnScale = 0.5;
   spawnSound = "snd_missileReload"; //played on player ship only. and only if ship has been alive for > 1 second.

   
   allowNonFactionCollision = false; //will not hit asteroids and such
   hitShipsOnly = true;  //most missiles we want to avoid all but ships. will also only target ships. 
   useRandomTargeting = false;
   randomTargetingRange = 400;
   
   isMissilePod = false;
   
   flightDamping = 0.5; 
   brainActivationTime = 0.5;
   
   //paint job
   mountedImageMaps[0] = "torp_glowImageMap 16 16 0 0 0";
   
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0.5 0.5 0.5 0.5";
   mountedImageMapState["Mounted", "FinalBlend", 0]   = "0.5 0.5 0.5 0.5";
   mountedImageMapState["Mounted", "PulseData", 0]    = "0 0 1 1 0";
   
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0.5 0.5 0.5 0.5";
   mountedImageMapState["Drifting", "FinalBlend", 0]   = "1 1 1 1"; 
   mountedImageMapState["Drifting", "PulseData", 0]    = "0 0 1 1 0";
   
   mountedImageMapState["Active", "InitialBlend", 0] = "1 1 1 1";
   mountedImageMapState["Active", "FinalBlend", 0]   = "1 1 1 0.5"; 
   mountedImageMapState["Active", "PulseData", 0]    = "0 0 1 1 0"; 
   
   //glow off until active
   mountedImageMapState["Mounted", "InitialBlend", 1] = "0 0 0 0";
   mountedImageMapState["Mounted", "FinalBlend", 1]   = "0 0 0 0";
   mountedImageMapState["Mounted", "PulseData", 1]    = "0 0 1 1 0";
  
   mountedImageMapState["Drifting", "InitialBlend", 1] = "0 0 0 0";
   mountedImageMapState["Drifting", "FinalBlend", 1]   = "0 0 0 0"; 
   mountedImageMapState["Drifting", "PulseData", 1]    = "0 1 1 1 0"; 
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   //FINS FOR LARGE AND HUGES
   mountedImageMapState["Mounted", "InitialBlend", 2] = "1 1 1 0";
   mountedImageMapState["Mounted", "FinalBlend", 2]   = "1 1 1 0"; 
   mountedImageMapState["Mounted", "PulseData", 2]    = "0 0 0 0 0";      
   
   mountedImageMapState["Drifting", "InitialBlend", 2] = "1 1 1 0";
   mountedImageMapState["Drifting", "FinalBlend", 2]   = "1 1 1 0"; 
   mountedImageMapState["Drifting", "PulseData", 2]    = "0 0 0 0 0";      
   
   mountedImageMapState["Active", "InitialBlend", 2] = "1 1 1 1";
   mountedImageMapState["Active", "FinalBlend", 2]   = "1 1 1 1"; 
   mountedImageMapState["Active", "PulseData", 2]    = "300 1 0.1 1 0";   
};



function TorpedoDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}


function TorpedoDatablock::GetFactionEngineDatablock(%this, %factionName)
{
   %engineDatablock = %this.engineDatablock_[%factionName];
   if ( %engineDatablock $= "" )
      %engineDatablock = %this.engineDatablock_Default;
       
   return %engineDatablock;   
}

////////////////////////////////////////////////////////////////////////////////
//BASIC TORPS
////////////////////////////////////////////////////////////////////////////////


datablock TorpedoDatablock(SmallTorpedo : TorpedoBase) 
{
   imageMap_Default = "torp_caseImageMap";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 1;
   
   size = "12 48";         
   
   damageStrength = SmallMissile.damageStrength * $TorpDamageMult;
   maxSpeed = SmallMissile.maxSpeed * $TorpSpeedMult;
   explosionDatablock = "MediumExplosion_Missile";
   explosionScale = "0.4";
   turnSpeed = SmallMissile.turnSpeed * $TorpTurnSpeedMult;
   constantThrustForce = SmallMissile.constantThrustForce * $TorpThrustMult;
   missileLifetimeMS = SmallMissile.missileLifetimeMS * $TorpLifeTimeMult;
   engineEngageTimer = "50";
   maxHealth = SmallMissile.maxHealth *$TorpHealthMult; //armored   
   damageType = "Explosive";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "torp_glowImageMap 12 48 0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap 12 48 0 0 0";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 1 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 1 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 1 0 0.5";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Mounted", "InitialBlend", 1] = "1 1 1 0";
   mountedImageMapState["Drifting", "InitialBlend", 1] = "1 1 1 0";
   mountedImageMapState["Active", "InitialBlend", 1] = "1 1 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 1 0 0.3"; 
   mountedImageMapState["Active", "PulseData", 1]    = "300 0 1.5 2 1";  
};

datablock TorpedoDatablock(MediumTorpedo : SmallTorpedo) 
{
   imageMap_Default = "torp_caseImageMap";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 1.2;
   
   size = "14 56";            
     
   damageStrength = MediumMissile.damageStrength * $TorpDamageMult;
   maxSpeed = MediumMissile.maxSpeed * $TorpSpeedMult;
   explosionDatablock = "MediumExplosion_Missile";
   explosionScale = "0.6";
   turnSpeed = MediumMissile.turnSpeed * $TorpTurnSpeedMult;
   constantThrustForce = MediumMissile.constantThrustForce * $TorpThrustMult;
   missileLifetimeMS = MediumMissile.missileLifetimeMS * $TorpLifeTimeMult;
   engineEngageTimer = "50";
   maxHealth = MediumMissile.maxHealth *$TorpHealthMult; //armored   
   damageType = "Explosive";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "torp_glowImageMap 14 56 0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap 14 56 0 0 0";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "PulseData", 1]    = "300 0 1.5 2 1"; 
};

datablock TorpedoDatablock(LargeTorpedo : SmallTorpedo) 
{
   imageMap_Default = "torp_caseImageMap";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 1.6;
   
   size = "16 64";    
   
   damageStrength = LargeMissile.damageStrength * $TorpDamageMult;
   maxSpeed = LargeMissile.maxSpeed * $TorpSpeedMult;
   
   explosionScale = "0.7"; 
   hasLightFlash = true;
   explosionDatablock = "MediumExplosion_Missile";
   explosionSound = "snd_mediumExplosion";
   
   turnSpeed = LargeMissile.turnSpeed * $TorpTurnSpeedMult;
   constantThrustForce = LargeMissile.constantThrustForce * $TorpThrustMult;
   missileLifetimeMS = LargeMissile.missileLifetimeMS * $TorpLifeTimeMult;
   engineEngageTimer = "50";
   maxHealth = LargeMissile.maxHealth *$TorpHealthMult; //armored   
   damageType = "Explosive";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "torp_glowImageMap 16 64 0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap 16 64 0 0 0";
   mountedImageMaps[2] = "missile_finLargeImageMap 32 16 0 0 1";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "PulseData", 1]    = "300 0 1.5 2 1"; 
};

datablock TorpedoDatablock(HugeTorpedo : SmallTorpedo) 
{
   imageMap_Default = "torp_caseImageMap";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 1.8;
   
   size = "20 80";        
    
   damageStrength = HugeMissile.damageStrength * $TorpDamageMult;
   maxSpeed = HugeMissile.maxSpeed * $TorpSpeedMult;

   explosionScale = "1"; 
   hasLightFlash = true;
   explosionDatablock = "MediumExplosion_Missile";
   explosionSound = "snd_mediumExplosion";

   turnSpeed = HugeMissile.turnSpeed * $TorpTurnSpeedMult;
   constantThrustForce = HugeMissile.constantThrustForce * $TorpThrustMult;
   missileLifetimeMS = HugeMissile.missileLifetimeMS * $TorpLifeTimeMult;
   engineEngageTimer = "50";
   maxHealth = HugeMissile.maxHealth *$TorpHealthMult; //armored   
   damageType = "Explosive";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "torp_glowImageMap 20 80 0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap 20 80 0 0 0";
   mountedImageMaps[2] = "missile_finHugeImageMap 40 80 0 0 1";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "PulseData", 1]    = "300 0 1.5 2 1";
};

////////////////////////////////////////////////////////////////////////////////
//CIV TORPS
////////////////////////////////////////////////////////////////////////////////

//KEEP ALL CIV COLORS THE SAME
$CivTorpMult = 0.850;
datablock TorpedoDatablock(SmallTorpedo_Civ : SmallTorpedo) 
{   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0.5 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0.5 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0.5 0 0.5";
   
   damageStrength = SmallTorpedo.damageStrength * $CivTorpMult;
   maxSpeed = SmallTorpedo.maxSpeed * $CivTorpMult;
   turnSpeed = SmallTorpedo.turnSpeed * $CivTorpMult;
   constantThrustForce = SmallTorpedo.constantThrustForce * $CivTorpMult;
   missileLifetimeMS = SmallTorpedo.missileLifetimeMS * $CivTorpMult;
   maxHealth = SmallTorpedo.maxHealth * $CivTorpMult; //armored   
      
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0.5 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0.5 0 0.3";   
};

datablock TorpedoDatablock(MediumTorpedo_Civ : MediumTorpedo) 
{   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0.5 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0.5 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0.5 0 0.5";
   
   damageStrength = MediumTorpedo.damageStrength * $CivTorpMult;
   maxSpeed = MediumTorpedo.maxSpeed * $CivTorpMult;
   turnSpeed = MediumTorpedo.turnSpeed * $CivTorpMult;
   constantThrustForce = MediumTorpedo.constantThrustForce * $CivTorpMult;
   missileLifetimeMS = MediumTorpedo.missileLifetimeMS * $CivTorpMult;
   maxHealth = MediumTorpedo.maxHealth * $CivTorpMult; //armored   
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0.5 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0.5 0 0.3";   
};

datablock TorpedoDatablock(LargeTorpedo_Civ : LargeTorpedo) 
{   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0.5 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0.5 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0.5 0 0.5";
   
   damageStrength = LargeTorpedo.damageStrength * $CivTorpMult;
   maxSpeed = LargeTorpedo.maxSpeed * $CivTorpMult;
   turnSpeed = LargeTorpedo.turnSpeed * $CivTorpMult;
   constantThrustForce = LargeTorpedo.constantThrustForce * $CivTorpMult;
   missileLifetimeMS = LargeTorpedo.missileLifetimeMS * $CivTorpMult;
   maxHealth = LargeTorpedo.maxHealth * $CivTorpMult; //armored   
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0.5 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0.5 0 0.3";   
};

datablock TorpedoDatablock(HugeTorpedo_Civ : HugeTorpedo) 
{   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0.5 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0.5 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0.5 0 0.5";
   
   damageStrength = HugeTorpedo.damageStrength * $CivTorpMult;
   maxSpeed = HugeTorpedo.maxSpeed * $CivTorpMult;
   turnSpeed = HugeTorpedo.turnSpeed * $CivTorpMult;
   constantThrustForce = HugeTorpedo.constantThrustForce * $CivTorpMult;
   missileLifetimeMS = HugeTorpedo.missileLifetimeMS * $CivTorpMult;
   maxHealth = HugeTorpedo.maxHealth * $CivTorpMult; //armored   
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0.5 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0.5 0 0.3";   
};





