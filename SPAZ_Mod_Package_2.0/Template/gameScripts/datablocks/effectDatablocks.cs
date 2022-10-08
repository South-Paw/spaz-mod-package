//preload counts
//Note default level for effects is now 0.667 so i scaled these up by 50% to keep consistent with what we have now.
//Our comps are comaprativley low end
$effectCount_FEW = 6;
$effectCount_AVERAGE = 12;
$effectCount_MANY = 18;
$effectCount_TONS = 30;


//Need to preload effects. 

function EffectDatablock::OnAdd(%this)
{
   //Empty Placeholder.  in case we want to do somehting with this someday or database it
   %this.isPreload = false;
}

/////////////////////////////////
// Preload Effects //////////////
/////////////////////////////////
$EffectPreloadDatablocks = new SimSet() {};

function PreloadEffectDatablock::OnAdd(%this)
{
   Parent::OnAdd(%this);
   %this.isPreload = true;
   $EffectPreloadDatablocks.add(%this);   
}

//////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////
// PreloadEffectDatablock ////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////
//These are managed effects.

datablock PreloadEffectDatablock(CometExplosion) 
{   
   effectFile = "game/data/particles/comet_explosion.eff";  
   maxEffects = $effectCount_MANY;    
};

datablock PreloadEffectDatablock(AsteroidExplosion) 
{   
   effectFile = "game/data/particles/asteroid_explosion.eff";  
   maxEffects = $effectCount_MANY;    
};

datablock PreloadEffectDatablock(zombie_AsteroidExplosion) 
{   
   effectFile = "game/data/particles/zombie_asteroid_explosion.eff";  
   maxEffects = $effectCount_MANY;    
};


datablock PreloadEffectDatablock(AsteroidExplosion_crystal) 
{   
   effectFile = "game/data/particles/asteroid_explosion_crystal.eff";  
   maxEffects = $effectCount_AVERAGE;    
};


datablock PreloadEffectDatablock(AsteroidExplosion_plant) 
{   
   effectFile = "game/data/particles/asteroid_explosion_plant.eff";  
   maxEffects = $effectCount_AVERAGE;    
};

datablock PreloadEffectDatablock(MassBombExplosion) 
{   
   effectFile = "game/data/particles/MassBomb_Explosion.eff";  
   maxEffects = $effectCount_FEW;    
};


datablock PreloadEffectDatablock(BigExplosion) 
{   
   effectFile = "game/data/particles/big_explosion.eff";  
   maxEffects = $effectCount_AVERAGE;    
};


datablock PreloadEffectDatablock(BigExplosion_zombie) 
{   
   effectFile = "game/data/particles/big_explosion_zombie.eff";  
   maxEffects = $effectCount_AVERAGE;    
};

datablock PreloadEffectDatablock(HugeExplosion) 
{   
   effectFile = "game/data/particles/huge_explosion.eff";    
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(HugeExplosion_zombie) 
{   
   effectFile = "game/data/particles/huge_explosion_zombie.eff";    
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(ReactorExplosion) 
{   
   effectFile = "game/data/particles/reactor_explosion.eff";  
   maxEffects = $effectCount_AVERAGE;    
};

datablock PreloadEffectDatablock(MetalExplosion) 
{   
   effectFile = "game/data/particles/metal_explosion.eff";  
   maxEffects = $effectCount_AVERAGE;    
};
datablock PreloadEffectDatablock(MetalFleshExplosion) 
{   
   effectFile = "game/data/particles/metal_flesh_explosion.eff";  
   maxEffects = $effectCount_AVERAGE;    
};


datablock PreloadEffectDatablock(ElectricExplosion) 
{   
   effectFile = "game/data/particles/electric_explosion.eff";  
   maxEffects = $effectCount_FEW;    
};

datablock PreloadEffectDatablock(CrateExplosion) 
{   
   effectFile = "game/data/particles/crate_explosion.eff";  
   maxEffects = $effectCount_AVERAGE;    
};


datablock PreloadEffectDatablock(SmallExplosion) 
{   
   effectFile = "game/data/particles/small_explosion.eff";   
   maxEffects = $effectCount_MANY;
};

datablock PreloadEffectDatablock(GravExplosion) 
{   
   effectFile = "game/data/particles/grav_explosion.eff";   
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(MediumExplosion_Missile) 
{   
   effectFile = "game/data/particles/med_explosionMissile.eff";   
   maxEffects = $effectCount_MANY;
};



datablock PreloadEffectDatablock(MediumExplosion) 
{   
   effectFile = "game/data/particles/med_explosion.eff";   
   maxEffects = $effectCount_MANY;
};

datablock PreloadEffectDatablock(MediumExplosion_Debris) 
{   
   effectFile = "game/data/particles/med_explosionDebris.eff";   
   maxEffects = $effectCount_MANY;
};


datablock PreloadEffectDatablock(MediumExplosion_zombie) 
{
   effectFile = "game/data/particles/med_explosion_zombie.eff";   
   maxEffects = $effectCount_MANY;
};


datablock PreloadEffectDatablock(SmallBlob_Explosion) 
{   
   effectFile = "game/data/particles/SmallBlob_Explosion.eff";   
   maxEffects = $effectCount_AVERAGE;
};

datablock PreloadEffectDatablock(LargeBlob_Explosion) 
{      
   effectFile = "game/data/particles/LargeBlob_Explosion.eff";   
   maxEffects = $effectCount_AVERAGE;
};


datablock PreloadEffectDatablock(shipRetrofit) 
{   
   effectFile = "game/data/particles/shipRetrofit.eff";  
   maxEffects = $effectCount_FEW;    
};


datablock PreloadEffectDatablock(marinepod_eject) 
{   
   effectFile = "game/data/particles/marinepod_eject.eff";    
   maxEffects = $effectCount_FEW;
};
datablock PreloadEffectDatablock(deployCase_eject) 
{   
   effectFile = "game/data/particles/deployCase_eject.eff";    
   maxEffects = $effectCount_FEW;
};


datablock PreloadEffectDatablock(escapePod_shatter) 
{   
   effectFile = "game/data/particles/escapePod_shatter.eff";    
   maxEffects = $effectCount_FEW;
};


datablock PreloadEffectDatablock(escapePod_eject) 
{   
   effectFile = "game/data/particles/escapePod_eject.eff";    
   maxEffects = $effectCount_MANY;
};

datablock PreloadEffectDatablock(LaserCut) 
{      
   effectFile = "game/data/particles/laser_cut.eff";  
   maxEffects = $effectCount_AVERAGE; 
};


datablock PreloadEffectDatablock(MicroImpact) 
{      
   effectFile = "game/data/particles/MicroImpact.eff";
   maxEffects = $effectCount_AVERAGE; 
};


datablock PreloadEffectDatablock(ScannerContact) 
{      
   effectFile = "game/data/particles/ScannerContact.eff";  
   maxEffects = $effectCount_FEW; 
};

datablock PreloadEffectDatablock(GravContact) 
{      
   effectFile = "game/data/particles/GravContact.eff";  
   maxEffects = $effectCount_FEW; 
};

datablock PreloadEffectDatablock(LeechContact) 
{      
   effectFile = "game/data/particles/LeechContact.eff";  
   maxEffects = $effectCount_FEW; 
};


//PROJECTILES


datablock PreloadEffectDatablock(ProjectileFire) 
{      
   effectFile = "game/data/particles/projectileFire.eff";    
   maxEffects = $effectCount_AVERAGE;   
};

datablock PreloadEffectDatablock(ProjectileFire_zombie) 
{      
   effectFile = "game/data/particles/ProjectileFire_zombie.eff";    
   maxEffects = $effectCount_AVERAGE;   
};

datablock PreloadEffectDatablock(ProjectileImpact) 
{      
   effectFile = "game/data/particles/projectileImpact.eff";   
   maxEffects = $effectCount_TONS;
};

datablock PreloadEffectDatablock(ProjectileImpact_ION) 
{      
   effectFile = "game/data/particles/projectileImpact_ION.eff";   
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(ProjectileImpact_zombie) 
{      
   effectFile = "game/data/particles/ProjectileImpact_zombie.eff";   
   maxEffects = $effectCount_TONS;
};

datablock PreloadEffectDatablock(MassDriverImpact) 
{      
   effectFile = "game/data/particles/MassDriverImpact.eff";   
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(MassDriverExit) 
{      
   effectFile = "game/data/particles/MassDriverExit.eff";   
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(BulletSparks) 
{      
   effectFile = "game/data/particles/BulletSparks.eff";   
   maxEffects = $effectCount_AVERAGE;
};


datablock PreloadEffectDatablock(BulletDrip) 
{      
   effectFile = "game/data/particles/BulletDrip.eff";   
   maxEffects = $effectCount_AVERAGE;
};

datablock PreloadEffectDatablock(zombieGravBulletDrip) 
{      
   effectFile = "game/data/particles/zombieGravBulletDrip.eff";   
   maxEffects = $effectCount_AVERAGE;
};

datablock PreloadEffectDatablock(CloakImpact) 
{      
   effectFile = "game/data/particles/CloakImpact.eff";   
   maxEffects = $effectCount_FEW;
};


datablock PreloadEffectDatablock(CloakEngage) 
{      
   effectFile = "game/data/particles/CloakEngage.eff";   
   maxEffects = $effectCount_FEW;
};


datablock PreloadEffectDatablock(BloodSplat) 
{      
   effectFile = "game/data/particles/blood_splat.eff";
   maxEffects = $effectCount_FEW;   
};  

datablock PreloadEffectDatablock(zombie_bodyImpulse) 
{   
   effectFile = "game/data/particles/zombieBodyImpulse.eff";  
   maxEffects = $effectCount_AVERAGE;    
}; 


datablock PreloadEffectDatablock(BeamAbord) 
{     
   effectFile = "game/data/particles/BeamAbord.eff";
   maxEffects = $effectCount_FEW;   
};   

datablock PreloadEffectDatablock(pickupSpawnBurst) 
{     
   effectFile = "game/data/particles/pickupSpawnBurst.eff";
   maxEffects = $effectCount_FEW;   
}; 


datablock PreloadEffectDatablock(SmallBurn) 
{      
   effectFile = "game/data/particles/burn_small.eff"; 
   maxEffects = $effectCount_FEW;  
};


datablock PreloadEffectDatablock(ShieldCollapse) 
{      
   effectFile = "game/data/particles/shield_collapse.eff";  
   maxEffects = $effectCount_FEW; 
};

datablock PreloadEffectDatablock(ShieldCollapse_Large) 
{      
   effectFile = "game/data/particles/shield_collapse_large.eff";  
   maxEffects = $effectCount_FEW; 
};


datablock PreloadEffectDatablock(ReactorCritical) 
{      
   effectFile = "game/data/particles/reactor_critical.eff"; 
   maxEffects = $effectCount_FEW;  
};

datablock PreloadEffectDatablock(WispHole) 
{   
   effectFile = "game/data/particles/WispHole.eff";  
   maxEffects = $effectCount_FEW;    
};

datablock PreloadEffectDatablock(Wisp_Resonate) 
{   
   effectFile = "game/data/particles/Wisp_Resonate.eff";  
   maxEffects = $effectCount_FEW;    
};

datablock PreloadEffectDatablock(ArmorImpact) 
{     
   effectFile = "game/data/particles/armorImpact.eff";   
   maxEffects = $effectCount_MANY;
};


datablock PreloadEffectDatablock(hullImpact) 
{      
   effectFile = "game/data/particles/hullImpact.eff";
   maxEffects = $effectCount_TONS;   
};


datablock PreloadEffectDatablock(hullImpact_zombie) 
{      
   effectFile = "game/data/particles/hullImpact_zombie.eff";
   maxEffects = $effectCount_TONS;   
};

datablock PreloadEffectDatablock(warpIn) 
{     
   effectFile = "game/data/particles/warpIn.eff"; 
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(warpOut) 
{     
   effectFile = "game/data/particles/warpOut.eff"; 
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(fireworks) 
{      
   effectFile = "game/data/particles/fireworks.eff"; 
   maxEffects = $effectCount_FEW;
};


datablock PreloadEffectDatablock(warpGateHole) 
{      
   effectFile = "game/data/particles/warpGateHole.eff"; 
   maxEffects = $effectCount_FEW;
};

//egg effects

datablock PreloadEffectDatablock(zombieEggChange) 
{   
   effectFile = "game/data/particles/zombieEggChange.eff"; 
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(zombieEggBirth) 
{   
   effectFile = "game/data/particles/zombieEggBirth.eff"; 
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(zombieEggHatchSmall) 
{   
   effectFile = "game/data/particles/zombieEggHatchSmall.eff"; 
   maxEffects = $effectCount_FEW;
};

datablock PreloadEffectDatablock(zombieEggHatchLarge) 
{   
   effectFile = "game/data/particles/zombieEggHatchLarge.eff"; 
   maxEffects = $effectCount_FEW;
};

//////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////
// Normal Effects ////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////
//These are unmanaged effects.


datablock EffectDatablock(MissileReloadFlash) 
{   
   effectFile = "game/data/particles/missileReloadFlash.eff";   
};
datablock EffectDatablock(MissileReloadFlash_zom) 
{   
   effectFile = "game/data/particles/missileReloadFlash_zom.eff";   
};


datablock EffectDatablock(MicroFire) 
{      
   effectFile = "game/data/particles/MicroFire.eff";  
};


datablock EffectDatablock(TractorFire) 
{      
   effectFile = "game/data/particles/TractorFire.eff";   
};

datablock EffectDatablock(LaserFire) 
{   
   effectFile = "game/data/particles/laserFire.eff";   
};

datablock EffectDatablock(LaserCharge) 
{   
   effectFile = "game/data/particles/LaserCharge.eff";   
};

datablock EffectDatablock(LaserCharge_zombie) 
{   
   effectFile = "game/data/particles/LaserCharge_zombie.eff";   
};

datablock EffectDatablock(AlignedThruster) 
{
   effectFile = "game/data/particles/alignedParticle.eff";   
};

datablock EffectDatablock(ZombieThruster) 
{
   effectFile = "game/data/particles/ZombieThruster.eff";   
};

datablock EffectDatablock(SmokeyThruster) 
{
   effectFile = "game/data/particles/SmokeyThruster.eff";   
};

datablock EffectDatablock(MissileThruster) 
{
   effectFile = "game/data/particles/MissileThruster.eff";   
};

datablock EffectDatablock(TinyThruster) 
{
   effectFile = "game/data/particles/TinyThruster.eff";   
};

datablock EffectDatablock(LatThruster) 
{
   effectFile = "game/data/particles/LatThruster.eff";   
};

datablock EffectDatablock(Lat_InertThruster) 
{
   effectFile = "game/data/particles/Lat_InertThruster.eff";   
};

datablock EffectDatablock(SmallThruster) 
{
   effectFile = "game/data/particles/smallThruster.eff";    
};

datablock EffectDatablock(inertiaThruster) 
{
   effectFile = "game/data/particles/inertiaThruster.eff";    
};

datablock EffectDatablock(CloakThruster) 
{
   effectFile = "game/data/particles/CloakThruster.eff";    
};

datablock EffectDatablock(ShipEngine) 
{
   effectFile = "game/data/particles/engineLight.eff";  
};

datablock EffectDatablock(RedLight) 
{   
   effectFile = "game/data/particles/redlight.eff";   
};

datablock EffectDatablock(GreenLight) 
{   
   effectFile = "game/data/particles/greenlight.eff";   
};

datablock EffectDatablock(YellowLight) 
{   
   effectFile = "game/data/particles/yellowlight.eff";   
};

datablock EffectDatablock(DataLight) 
{   
   effectFile = "game/data/particles/datalight.eff";   
};

datablock EffectDatablock(WhiteFlash) 
{   
   effectFile = "game/data/particles/whiteFlash.eff";   
};

datablock EffectDatablock(RadarPingFriendly) 
{   
   effectFile = "game/data/particles/RadarPingFriend.eff";   
};

datablock EffectDatablock(RadarPingEnemy) 
{   
   effectFile = "game/data/particles/RadarPingEnemy.eff";   
};

datablock EffectDatablock(lightning_01) 
{   
   effectFile = "game/data/particles/lightning_01.eff";   
};


datablock EffectDatablock(cloudBurst_01) 
{   
   effectFile = "game/data/particles/cloudBurst_01.eff"; 
};


datablock EffectDatablock(plasmaBurst_01) 
{   
   effectFile = "game/data/particles/plasmaBurst_01.eff"; 
};


datablock EffectDatablock(sparkBurst_01) 
{   
   effectFile = "game/data/particles/sparkBurst_01.eff"; 
};


datablock EffectDatablock(auroraBurst_01) 
{   
   effectFile = "game/data/particles/auroraBurst_01.eff"; 
};


datablock EffectDatablock(beaconPirate) 
{   
   effectFile = "game/data/particles/beaconPirate.eff"; 
};

datablock EffectDatablock(beaconTerran) 
{   
   effectFile = "game/data/particles/beaconTerran.eff"; 
};

datablock EffectDatablock(beacon_WarpIn) 
{   
   effectFile = "game/data/particles/beacon_WarpIn.eff"; 
};

datablock EffectDatablock(motherWarpin) 
{   
   effectFile = "game/data/particles/motherWarpin.eff"; 
};

datablock EffectDatablock(starmap_attack) 
{   
   effectFile = "game/data/particles/starmap_attack.eff"; 
};

datablock EffectDatablock(armorEject_small_front) 
{   
   effectFile = "game/data/particles/armorEject_small_front.eff"; 
};

datablock EffectDatablock(armorEject_small_side) 
{   
   effectFile = "game/data/particles/armorEject_small_side.eff"; 
};

datablock EffectDatablock(BulletRings) 
{      
   effectFile = "game/data/particles/BulletRings.eff";   
};

datablock EffectDatablock(MassDriverMotion) 
{      
   effectFile = "game/data/particles/MassDriverMotion.eff";   
};
datablock EffectDatablock(fireWisp) 
{
   effectFile = "game/data/particles/fireWisp_explosion.eff";   
};

/////////////////////////////////////
//hull doodad effects
/////////////////////////////////////

datablock EffectDatablock(sparks) 
{   
   effectFile = "game/data/particles/sparks.eff"; 
};

datablock EffectDatablock(smokePuff) 
{   
   effectFile = "game/data/particles/smokePuff.eff"; 
};

datablock EffectDatablock(bloodPuff) 
{   
   effectFile = "game/data/particles/bloodPuff.eff"; 
};

datablock EffectDatablock(hullBreach) 
{
   effectFile = "game/data/particles/hullBreach.eff";   
};

datablock EffectDatablock(hullVent) 
{
   effectFile = "game/data/particles/hullVent.eff";   
};

datablock EffectDatablock(hullLinger) 
{
   effectFile = "game/data/particles/hullLinger.eff";   
};

datablock EffectDatablock(hullFire) 
{
   effectFile = "game/data/particles/hullFire.eff";   
};

datablock EffectDatablock(hullSmoke) 
{
   effectFile = "game/data/particles/hullSmoke.eff";   
};

datablock EffectDatablock(hullBleed) 
{
   effectFile = "game/data/particles/hullBleed.eff";   
};

datablock EffectDatablock(hullElecPuff) 
{
   effectFile = "game/data/particles/hullElecPuff.eff";   
};

datablock EffectDatablock(hullPurgeSmall) 
{
   effectFile = "game/data/particles/hullPurgeSmall.eff";   
};

datablock EffectDatablock(hullPurgeHuge) 
{
   effectFile = "game/data/particles/hullPurgeHuge.eff";   
};

datablock EffectDatablock(explosivePuff) 
{
   effectFile = "game/data/particles/metal_explosion.eff";   
};

datablock EffectDatablock(hullCleanupPuff) 
{
   effectFile = "game/data/particles/hullCleanupPuff.eff";   
};

datablock EffectDatablock(zombiePuke) 
{   
   effectFile = "game/data/particles/zombie_puke_01.eff"; 
};

datablock EffectDatablock(zombiePuke_small) 
{   
   effectFile = "game/data/particles/zombie_puke_02.eff"; 
};

datablock EffectDatablock(zombie_evilEnergy) 
{   
   effectFile = "game/data/particles/zombie_evilEnergy_01.eff"; 
};

datablock EffectDatablock(zombieClockworkCore) 
{   
   effectFile = "game/data/particles/zombieClockworkCore.eff"; 
};

datablock EffectDatablock(shuttleMotion) 
{   
   effectFile = "game/data/particles/shuttleMotion.eff";
};

datablock EffectDatablock(repairEffect) 
{   
   effectFile = "game/data/particles/breachRepair.eff"; 
};

datablock EffectDatablock(zombieEggBugs_01) 
{   
   effectFile = "game/data/particles/eggBugs_01.eff"; 
};

//beam area

datablock EffectDatablock(beamAreaExample) 
{   
   effectFile = "game/data/particles/beamAreaExample.eff"; 
};

datablock EffectDatablock(beamAreaSparks) 
{   
   effectFile = "game/data/particles/beamAreaSparks.eff"; 
};

datablock EffectDatablock(beamAreaScanner) 
{   
   effectFile = "game/data/particles/beamAreaScanner.eff"; 
};


datablock EffectDatablock(beamAreaElec) 
{   
   effectFile = "game/data/particles/beamAreaElec.eff"; 
};


datablock EffectDatablock(beamAreaWaves) 
{   
   effectFile = "game/data/particles/beamAreaWaves.eff"; 
};

datablock EffectDatablock(beamAreaFire) 
{   
   effectFile = "game/data/particles/beamAreaFire.eff"; 
};

datablock EffectDatablock(beamAreaCoils) 
{   
   effectFile = "game/data/particles/beamAreaCoils.eff"; 
};

datablock EffectDatablock(beamAreaCoilsLarge) 
{   
   effectFile = "game/data/particles/beamAreaCoilsLarge.eff"; 
};

datablock EffectDatablock(beamAreaCorruption_small) 
{   
   effectFile = "game/data/particles/beamAreaCorruption_small.eff"; 
};


datablock EffectDatablock(beamAreaCorruption) 
{   
   effectFile = "game/data/particles/beamAreaCorruption.eff"; 
};

datablock EffectDatablock(beamAreaTractor) 
{   
   effectFile = "game/data/particles/beamAreaTractor.eff"; 
};

datablock EffectDatablock(beamAreaGrav) 
{   
   effectFile = "game/data/particles/beamAreaGrav.eff"; 
};

datablock EffectDatablock(beamAreaLeech) 
{   
   effectFile = "game/data/particles/beamAreaLeech.eff"; 
};

datablock EffectDatablock(beamAreaHighlight) 
{   
   effectFile = "game/data/particles/beamAreaHighlight.eff"; 
};

//wisp fill effects

datablock EffectDatablock(Wisp_ToxicFill) 
{   
   effectFile = "game/data/particles/Wisp_ToxicFill.eff";   
};

//ship combat effects

datablock EffectDatablock(shipcombat_zombie) 
{   
   effectFile = "game/data/particles/shipcombat_zombie.eff";   
};
datablock EffectDatablock(shipcombat_human) 
{   
   effectFile = "game/data/particles/shipcombat_human.eff";   
};

//starmap effects

datablock EffectDatablock(starInfection) 
{   
   effectFile = "game/data/particles/starInfection.eff";   
};

datablock EffectDatablock(galaxyCore) 
{   
   effectFile = "game/data/particles/galaxyCore.eff";   
};

datablock EffectDatablock(warpWarmup) 
{     
   effectFile = "game/data/particles/warpWarmup.eff"; 
};

//special stuff

datablock EffectDatablock(SmallCometTail) 
{   
   effectFile = "game/data/particles/SmallCometTail.eff";   
};
datablock EffectDatablock(MassiveCometTail) 
{   
   effectFile = "game/data/particles/MassiveCometTail.eff";   
};

//alien gate
datablock EffectDatablock(alienGatePowerPulse) 
{   
   effectFile = "game/data/particles/alienGatePowerPulse.eff";   
};

//grav effects

datablock EffectDatablock(gravSlowEffect) 
{   
   effectFile = "game/data/particles/gravSlowEffect.eff";   
};





