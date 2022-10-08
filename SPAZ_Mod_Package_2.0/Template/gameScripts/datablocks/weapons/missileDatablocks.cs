
//Moved here to hunter missiles can ref
$TorpDamageMult = 2.0;
$TorpSpeedMult = 0.667;  //was 0.667.
$TorpTurnSpeedMult = 1/8; //was 1/6
$TorpThrustMult = 0.5;
//$TorpLifeTimeMult = 1 / $TorpSpeedMult;
$TorpLifeTimeMult = 1.333;
$TorpLifeTimeMult = 1; //lower life a bit so dont get 2 passes all the time
$TorpHealthMult = 2.0;

datablock MissileDatablock(MissileBase) 
{
   launchSound = "snd_smallMissileLaunch";
   explosionSound = "snd_smallExplosion";
   hasLightFlash = false;
   subProjectileCount = "0";
   thrustEffectScale = 1;
   
   CollisionPolyList = "-0.241 -0.884 0.069 -0.884 0.069 0.869 -0.246 0.869";
   LinkPoints = "0.000 0.000 0.000 1.000";
   
   researchDatablock = "MissileResearch";
   
   engineDatablock_Zombie = "ZombieThruster";  
   thrustEffectScale = 1;
    
   launchImpulse = 400;
   launchDir     = 90;  //direction is mirrored if missile is on the left side.  
   launchDamping = 3;
   
   allowNonFactionCollision = false; //will not hit asteroids and such
   hitShipsOnly = true;  //most missiles we want to avoid all but ships. will also only target ships. 
   useRandomTargeting = false;
   randomTargetingRange = 400;
   cloakHunter = false; //only works with random targeting.
      
   isCloaking = false;
   cloakDisruptTime = 2.0; //seconds
      
   flightDamping = 0.5;
   
   isMissilePod = false;
   
   spawnEffect = "MissileReloadFlash";
   spawnScale = 0.5;
   spawnSound = "snd_missileReload"; //played on player ship only. and only if ship has been alive for > 1 second.
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense 
   //(if pulse time = 0, we will just set the color from initialblend)
   //If pulseCount = 0, we will pulse forever, if 1, we will blend to the final color and stop.
   //Note: isIntense, and initialSize will be used even if object not pulsing
   
   //paint job
   mountedImageMaps[0] = "missile_glowImageMap 16 16 0 0 0";
   
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

function MissileDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}


function MissileDatablock::GetFactionEngineDatablock(%this, %factionName)
{
   %engineDatablock = %this.engineDatablock_[%factionName];
   if ( %engineDatablock $= "" )
      %engineDatablock = %this.engineDatablock_Default;
       
   return %engineDatablock;   
}


/////////////////////////////////////
// Mounted Image Data ///////////////
/////////////////////////////////////



function MissileDatablock::GetMountedImageData(%this, %index, %dataType)
{
   %dataRanges["ImageMap"]    = "0 0";
   %dataRanges["Size"]        = "1 2";
   %dataRanges["LinkOffset"]  = "3 4";
   %dataRanges["LayerOffset"] = "5 5";
   
   %data = %this.mountedImageMaps[%index];
   if ( %data $= "" )
      echo("MissileDatablock::GetMountedImageData Missing Data:" SPC %index SPC %dataType);
   
   %dataRange = %dataRanges[%dataType];
   if ( %dataRange $= "" )
      echo("MissileDatablock::GetMountedImageData Bad Datatype:" SPC %index SPC %dataType);
      
   %datum = getWords(%data, getWord(%dataRange, 0), getWord(%dataRange, 1));  
   
   return %datum;   
}

////////////////////////////////////////////////////////////////////////////////
//BASIC MISSILES
////////////////////////////////////////////////////////////////////////////////

datablock MissileDatablock(SmallMissile : MissileBase) 
{
   imageMap_Default = "missile_caseImageMap";
   
   engineDatablock_Default = "MissileThruster";
     
   thrustEffectScale = 1;
   
   damageStrength = "10";
   maxSpeed = "1000";   
   brainActivationTime = 0.100; //fly away a bit before tracking enemy
   missileLifetimeMS = "3500";
   engineEngageTimer = "100";
   maxHealth = "1";   
   turnSpeed = "360";
   constantThrustForce = "3000";   
   
   size = "12 48";
   
   explosionDatablock = "MediumExplosion_Missile";
   explosionScale = "0.4";   
   isTwitchy = "1";   
   damageType = "Explosive";
   
   launchImpulse = 400;
   launchDir     = 90;  //direction is mirrored if missile is on the left side.  
   launchDamping = 3;
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "missile_glowImageMap 12 48 0 0 0";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 0 1 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 0 1 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 0 1 0.5";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[1] = "missileHighlightImageMap 12 48 0 0 0";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "0 0 1 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "0 0 1 0.3"; 
   mountedImageMapState["Active", "PulseData", 1]    = "300 0 1.5 2 1";   
};

datablock MissileDatablock(MediumMissile : SmallMissile) 
{
   imageMap_Default = "missile_caseImageMap";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 1.2;
   
   explosionDatablock = "MediumExplosion_Missile";
   explosionScale = "0.6";   
   
   size = "14 56";
   
   damageStrength = "15";
   maxSpeed = "800";   
   brainActivationTime = 0.200; //fly away a bit before tracking enemy
   missileLifetimeMS = "4500";
   engineEngageTimer = "200";
   maxHealth = "3";   
   turnSpeed = "315";
   constantThrustForce = "4500";   
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "missile_glowImageMap 14 56 0 0 0";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[1] = "missileHighlightImageMap 14 56 0 0 0";
};

datablock MissileDatablock(LargeMissile : SmallMissile) 
{
   imageMap_Default = "missile_caseImageMap";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 1.6;
   
   size = "16 64";
   
   damageStrength = "24";
   maxSpeed = "640";   
   brainActivationTime = 0.300; //fly away a bit before tracking enemy
   missileLifetimeMS = "5800";
   engineEngageTimer = "300";
   maxHealth = "5";   
   turnSpeed = "270";
   constantThrustForce = "6750";   
      
   explosionScale = "0.8"; 
   hasLightFlash = true;
   explosionDatablock = "MediumExplosion_Missile";
   explosionSound = "snd_mediumExplosion";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "missile_glowImageMap 16 64 0 0 0";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[1] = "missileHighlightImageMap 16 64 0 0 0";
   
   mountedImageMaps[2] = "missile_finLargeImageMap 32 16 0 0 1";
};

datablock MissileDatablock(HugeMissile : SmallMissile) 
{
   imageMap_Default = "missile_caseImageMap";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 1.8;

   size = "20 80"; 
   
   
   damageStrength = "40";
   maxSpeed = "512";   
   brainActivationTime = 0.500; //fly away a bit before tracking enemy
   missileLifetimeMS = "7777";
   engineEngageTimer = "500";
   maxHealth = "10";   
   turnSpeed = "225";
   constantThrustForce = "10000";  
   
   explosionScale = "1"; 
   hasLightFlash = true;
   explosionDatablock = "MediumExplosion_Missile";
   explosionSound = "snd_mediumExplosion";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "missile_glowImageMap 20 80 0 0 0";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[1] = "missileHighlightImageMap 20 80 0 0 0";
   
   mountedImageMaps[2] = "missile_finHugeImageMap 40 80 0 0 1";
};

////////////////////////////////////////////////////////////////////////////////
//CIV MISSILES
////////////////////////////////////////////////////////////////////////////////

//KEEP ALL COLOR DATA THE SAME

datablock MissileDatablock(SmallMissile_Civ : SmallMissile) 
{
   damageStrength = SmallMissile.damageStrength * 0.500;
   maxSpeed = SmallMissile.maxSpeed * 1.50; 
   turnSpeed = SmallMissile.turnSpeed * 0.500; 
   constantThrustForce = SmallMissile.constantThrustForce * 1.5;   
   size = t2dVectorScale(SmallMissile.size, 0.667);
   maxHealth = SmallMissile.maxHealth * 0.250;
   brainActivationTime = SmallMissile.brainActivationTime * 0.500;
   engineEngageTimer = SmallMissile.engineEngageTimer * 0.500;
   
   mountedImageMaps[0] = "missile_glowImageMap" SPC t2dVectorScale(SmallMissile.size, 0.667) SPC "0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap" SPC t2dVectorScale(SmallMissile.size, 0.667) SPC "0 0 0";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 1 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 1 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 0 0.5";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "0 1 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "0 1 0 0.3"; 
};

datablock MissileDatablock(MediumMissile_Civ : MediumMissile) 
{   
   damageStrength = MediumMissile.damageStrength * 0.500;
   maxSpeed = MediumMissile.maxSpeed * 1.50; 
   turnSpeed = MediumMissile.turnSpeed * 0.500; 
   constantThrustForce = MediumMissile.constantThrustForce * 1.5;   
   size = t2dVectorScale(MediumMissile.size, 0.667);
   maxHealth = MediumMissile.maxHealth * 0.250;
   brainActivationTime = MediumMissile.brainActivationTime * 0.500;
   engineEngageTimer = MediumMissile.engineEngageTimer * 0.500;
   
   mountedImageMaps[0] = "missile_glowImageMap" SPC t2dVectorScale(MediumMissile.size, 0.667) SPC "0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap" SPC t2dVectorScale(MediumMissile.size, 0.667) SPC "0 0 0";


   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 1 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 1 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 0 0.5";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "0 1 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "0 1 0 0.3"; 
};

datablock MissileDatablock(LargeMissile_Civ : LargeMissile) 
{   
   damageStrength = LargeMissile.damageStrength * 0.500;
   maxSpeed = LargeMissile.maxSpeed * 1.50; 
   turnSpeed = LargeMissile.turnSpeed * 0.500; 
   constantThrustForce = LargeMissile.constantThrustForce * 1.5;   
   size = t2dVectorScale(LargeMissile.size, 0.667);
   maxHealth = LargeMissile.maxHealth * 0.250;
   brainActivationTime = LargeMissile.brainActivationTime * 0.500;
   engineEngageTimer = LargeMissile.engineEngageTimer * 0.500;
   
   mountedImageMaps[0] = "missile_glowImageMap" SPC t2dVectorScale(LargeMissile.size, 0.667) SPC "0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap" SPC t2dVectorScale(LargeMissile.size, 0.667) SPC "0 0 0";
   mountedImageMaps[2] = "missile_finLargeImageMap 21.344 10.67 0 0 1";

   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 1 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 1 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 0 0.5";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "0 1 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "0 1 0 0.3"; 
};

datablock MissileDatablock(HugeMissile_Civ : HugeMissile) 
{   
   damageStrength = HugeMissile.damageStrength * 0.500;
   maxSpeed = HugeMissile.maxSpeed * 1.50; 
   turnSpeed = HugeMissile.turnSpeed * 0.500; 
   constantThrustForce = HugeMissile.constantThrustForce * 1.5;   
   size = t2dVectorScale(HugeMissile.size, 0.667);
   maxHealth = HugeMissile.maxHealth * 0.250;
   brainActivationTime = HugeMissile.brainActivationTime * 0.500;
   engineEngageTimer = HugeMissile.engineEngageTimer * 0.500;
   
   mountedImageMaps[0] = "missile_glowImageMap" SPC t2dVectorScale(HugeMissile.size, 0.667) SPC "0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap" SPC t2dVectorScale(HugeMissile.size, 0.667) SPC "0 0 0";
   mountedImageMaps[2] = "missile_finHugeImageMap 26.68 53.36 0 0 1";

   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 1 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 1 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 0 0.5";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "0 1 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "0 1 0 0.3"; 
};

////////////////////////////////////////////////////////////////////////////////
//GRAV MISSILES
////////////////////////////////////////////////////////////////////////////////
datablock MissileDatablock(SmallMissile_Grav : SmallMissile) 
{
   imageMap_Default = "missile_case_gravImageMap";
   explosionDatablock = "GravExplosion";
   explosionSound = "snd_mediumExplosion";   
   
   damageStrength = $HULL_BASEMASS[$HULLTYPE_SMALL]; 
   damageType = "Mass";
   
   damageStrength = "10";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0 0 0.5";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0 0 0.3";
};

datablock MissileDatablock(MediumMissile_Grav : MediumMissile) 
{
   imageMap_Default = "missile_case_gravImageMap";
   explosionDatablock = "GravExplosion";
   explosionSound = "snd_mediumExplosion";   
   
   damageStrength = $HULL_BASEMASS[$HULLTYPE_MEDIUM]; 
   damageType = "Mass";
   
   damageStrength = "50";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0 0 0.3";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0 0 0.3";
};

datablock MissileDatablock(LargeMissile_Grav : LargeMissile) 
{
   imageMap_Default = "missile_case_gravImageMap";
   explosionDatablock = "GravExplosion";
   explosionSound = "snd_mediumExplosion";      
   
   damageStrength = $HULL_BASEMASS[$HULLTYPE_LARGE]; 
   damageType = "Mass";
   
   damageStrength = "250";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0 0 0.5";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0 0 0.3";
};

datablock MissileDatablock(HugeMissile_Grav : HugeMissile) 
{
   imageMap_Default = "missile_case_gravImageMap";
   explosionDatablock = "GravExplosion";
   explosionSound = "snd_mediumExplosion";      
   
   damageStrength = $HULL_BASEMASS[$HULLTYPE_HUGE]; 
   damageType = "Mass";
   
   damageStrength = "1000";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0 0 0.5";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0 0 0.3";
};

//////////////////////////////////////////////////////////////////////////
// SRM Bomblets //////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//Using a missile here to produce a srm
//SRMs do their own tracking. 
datablock MissileDatablock(SRM_BombletBase) 
{
   isMissileDatablock = true;
   imageMap_Default = "subRocket_caseImageMap";   
   
   launchSound = "snd_smallTorpLaunch";
   explosionSound = "snd_smallExplosion";
   subProjectileCount = "0";
   
   CollisionPolyList = "-0.241 -0.884 0.069 -0.884 0.069 0.869 -0.246 0.869";
   LinkPoints = "0.000 0.000 0.000 1.000";
     
   researchDatablock = "MissileResearch";
   
   engineDatablock_Default = "MissileThruster";
   engineDatablock_Zombie = "ZombieThruster";  
   
   launchImpulse = 100;
   launchDir     = 0;  //direction is mirrored if missile is on the left side.  
   launchDamping = 0;
 
   isCloaking = false;
   
   flightDamping = 0;  
   
   allowNonFactionCollision = false; //will not hit asteroids and such
   hitShipsOnly = false;  //most missiles we want to avoid all but ships. will also only target ships. 
   useRandomTargeting = true;
   randomTargetingRange = 400;
};


//THIS IS A SRM
datablock MissileDatablock(SRMBomblet_Small : SRM_BombletBase) 
{   
   thrustEffectScale = 0.5;
   size = "6 12";
   
   explosionDatablock = "MediumExplosion_Missile";
   explosionScale = "0.35";
   
   damageStrength = "5";   
   damageType = "Explosive";   
   
   brainActivationTime = 0.500; //fly away a bit before tracking enemy
   randomTargetingRange = 500;
   
   bombletLaunchImpulseMin = 50;
   bombletLaunchImpulseMax = 100;
   bombletLaunchAngleRange = 22.5;  //+/- this degrees
   
   //very fast
   turnSpeed = "360";
   maxSpeed = "1200";
   constantThrustForce = "1500";
   
   engineEngageTimer = "200";  //next frame.
   missileLifetimeMS = "4000";
   
   subProjectile = "";
   
   maxHealth = "0.1";
   
   
   
   //glow
   mountedImageMaps[0] = "effect_whiteLight_01ImageMap 16 16 0 0 0";
   
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 0 0 0";
   mountedImageMapState["Mounted", "FinalBlend", 0]   = "0 0 0 0";
   mountedImageMapState["Mounted", "PulseData", 0]    = "0 0 1 1 0";
   
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 0 0 0";
   mountedImageMapState["Drifting", "FinalBlend", 0]   = "0 0 0 0"; 
   mountedImageMapState["Drifting", "PulseData", 0]    = "0 0 1 1 0";
   
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0 0 0.5";
   mountedImageMapState["Active", "FinalBlend", 0]   = "1 0.5 0 0.5"; 
   mountedImageMapState["Active", "PulseData", 0]    = "200 0 2 4 1 1"; 
};
datablock MissileDatablock(HunterBomblet_Small : SRMBomblet_Small) 
{
   damageStrength = 3;
   damageType = "Ion";    
   cloakHunter = true; //only works with random targeting. 
   useRandomTargeting = true;
   randomTargetingRange = 500;
   missileLifetimeMS = "4000";
   
   size = "16 16";
   imageMap_Default = "subHunter_caseImageMap";  
   
   //glow
   mountedImageMaps[0] = "effect_whiteLight_01ImageMap 18 18 0 0 0";

   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Active", "FinalBlend", 0]   = "0 0.5 1 0.5"; 
   mountedImageMapState["Active", "PulseData", 0]    = "200 0 2 4 1 1";  
};




   
datablock MissileDatablock(SRMBomblet_Large : SRMBomblet_Small) 
{
   thrustEffectScale = 1;
   size = "12 24";
  
   damageStrength = "12";
   explosionScale = "0.6";
   
   brainActivationTime = 0.500; //fly away a bit before tracking enemy
   randomTargetingRange = 750;
   
   bombletLaunchImpulseMin = 150;
   bombletLaunchImpulseMax = 300;
   bombletLaunchAngleRange = 45;  //+/- this degrees
   
   //very fast
   turnSpeed = "225";
   maxSpeed = "800";
   constantThrustForce = "4500";
   
   engineEngageTimer = "200";  
   missileLifetimeMS = "6000";
   
   subProjectile = "";
   
   maxHealth = "1";
         
   //glow
   mountedImageMaps[0] = "effect_whiteLight_01ImageMap 36 36 0 0 0";
   mountedImageMapState["Mounted", "PulseData", 0]    = "0 0 1 1 0";
   mountedImageMapState["Drifting", "PulseData", 0]    = "0 0 1 1 0";   
   mountedImageMapState["Active", "PulseData", 0]    = "200 0 2 4 1 1"; 
};
datablock MissileDatablock(HunterBomblet_Large : SRMBomblet_Large) 
{
   damageStrength = 6;
   damageType = "Ion";  
   cloakHunter = true; //only works with random targeting.
   useRandomTargeting = true;
   randomTargetingRange = 750;
   missileLifetimeMS = "6000";
   
   size = "32 32";
   imageMap_Default = "subHunter_caseImageMap";  
   
   //glow
   mountedImageMaps[0] = "effect_whiteLight_01ImageMap 40 40 0 0 0";

   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Active", "FinalBlend", 0]   = "0 0.5 1 0.5"; 
   mountedImageMapState["Active", "PulseData", 0]    = "200 0 2 4 1 1";   
};
   
   

/////////////////////////////////////////////////////////////////////////////////
//ZOMBIE SPICIFIC
/////////////////////////////////////////////////////////////////////////////////

datablock MissileDatablock(ZombieMissile_Small : MissileBase) 
{
   imageMap_Default = "missile_zombie_smallImageMap";
   
   engineDatablock_Default = "SmallThruster";
   
   launchSound = "snd_rapidMissileLaunch";
   
   spawnEffect = "MissileReloadFlash_zom";

   size = "32 32"; 
   damageStrength = 10; 
   maxSpeed = "250";
   explosionDatablock = "SmallBlob_Explosion";
   explosionScale = "0.4";
   turnSpeed = "90";
   constantThrustForce = "600";
   missileLifetimeMS = "7000";
   engineEngageTimer = "150";
   isTwitchy = "1";
   maxHealth = "3";   
   damageType = "Explosive";
   
   spawnZombies = 1;
   
   //glow
   mountedImageMaps[0] = "effect_puffImageMap 64 64 0 0 0";
   mountedImageMaps[1] = "missile_zombie_spikeImageMap 48 48 0 0 1";   
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 0]   = "1 0 0 0.3"; 
   mountedImageMapState["Active", "PulseData", 0]    = "300 0 1.5 2 1";  
   
   //FINS 
   mountedImageMapState["Mounted", "InitialBlend", 1] = "1 1 1 0";
   mountedImageMapState["Mounted", "FinalBlend", 1]   = "1 1 1 0"; 
   mountedImageMapState["Mounted", "PulseData", 1]    = "0 0 0 0 0";      
   
   mountedImageMapState["Drifting", "InitialBlend", 1] = "1 1 1 0";
   mountedImageMapState["Drifting", "FinalBlend", 1]   = "1 1 1 0"; 
   mountedImageMapState["Drifting", "PulseData", 1]    = "0 0 0 0 0";   
   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 1 1 1";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 1 1 1"; 
   mountedImageMapState["Active", "PulseData", 1]    = "300 1 0.1 1 0";   
};

datablock MissileDatablock(ZombieMissile_Medium : MissileBase) 
{
   imageMap_Default = "missile_zombie_smallImageMap";
   
   engineDatablock_Default = "SmallThruster";
   
   launchSound = "snd_rapidMissileLaunch";
   
   spawnEffect = "MissileReloadFlash_zom";

   size = "48 48"; 
   damageStrength = 24; 
   maxSpeed = "200";
   explosionDatablock = "LargeBlob_Explosion";
   explosionScale = "1";
   turnSpeed = "60";
   constantThrustForce = "1000";
   missileLifetimeMS = "10000";
   engineEngageTimer = "250";
   isTwitchy = "1";
   maxHealth = "10";   
   damageType = "Explosive";
   
   spawnZombies = 2;
   
   //glow
   mountedImageMaps[0] = "effect_puffImageMap 96 96 0 0 0";
   mountedImageMaps[1] = "missile_zombie_spikeImageMap 64 64 0 0 1";   
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 0]   = "1 0 0 0.3"; 
   mountedImageMapState["Active", "PulseData", 0]    = "300 0 1.5 2 1";
   
   //FINS 
   mountedImageMapState["Mounted", "InitialBlend", 1] = "1 1 1 0";
   mountedImageMapState["Mounted", "FinalBlend", 1]   = "1 1 1 0"; 
   mountedImageMapState["Mounted", "PulseData", 1]    = "0 0 0 0 0";      
   
   mountedImageMapState["Drifting", "InitialBlend", 1] = "1 1 1 0";
   mountedImageMapState["Drifting", "FinalBlend", 1]   = "1 1 1 0"; 
   mountedImageMapState["Drifting", "PulseData", 1]    = "0 0 0 0 0";   
   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 1 1 1";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 1 1 1"; 
   mountedImageMapState["Active", "PulseData", 1]    = "300 1 0.1 1 0";     
};





 
 
 
