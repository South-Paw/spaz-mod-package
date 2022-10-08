

//////////////////////////////////////////////////////////////////////
// Mass Bombs ////////////////////////////////////////////////////////

//A mass bomb is a torpedo without an engine and that makes a big boom when it times out

datablock MassBombDatablock(MassBombBase) 
{
   imageMap_Default = "massBomb_caseImageMap";
   
   size = "64 64";
   launchSound = "snd_smallMissileLaunch";
   explosionSound = "snd_massBombExplosion";
   subProjectileCount = "0";
   
   CollisionPolyList = "-0.456 -0.766 -0.225 -0.943 0.147 -0.943 0.435 -0.761 0.702 -0.182 0.456 0.884 -0.466 0.884 -0.702 -0.192";
   LinkPoints = "-0.005 0.005 0.000 1.000";
   
   explosionScale = "1";
   explosionDatablock = "BigExplosion";
     
   researchDatablock = "MassBombResearch";
   thrustEffectScale = 1;
   
   explosiveLightMultiplier = 0; //no light
   
   launchImpulse = 100;
   launchDir     = 0;  //direction is mirrored if missile is on the left side.  
   launchDamping = 0;  //inherit velocity
 
   isCloaking = false;
   
   spawnEffect = "MissileReloadFlash";
   spawnScale = 1.0;
   spawnSound = "snd_missileReload"; //played on player ship only. and only if ship has been alive for > 1 second.

   
   isMissilePod = false;
   
   allowNonFactionCollision = false; //will not hit asteroids and such
   hitShipsOnly = true;  //most missiles we want to avoid all but ships. will also only target ships. 
   useRandomTargeting = false;
   randomTargetingRange = 400;
   
   flightDamping = 0.5;
   brainActivationTime = 0.5;
   
   wispDatablocks = "ExplosiveWisp"; //does a get random word if we have a potpurri mass bomb 
   wispCount = 4;
   
   blossomData["Final", "DamageType"]   = "Mass";
   blossomData["Final", "Speed"]        = 1500;  //speeds below 512 are not recommended.
   blossomData["Final", "ImageMaps"]    = "effect_gravPlasmaImageMap"; 
   blossomData["Final", "InitialBlend"] = "1 0.5 1 1";
   blossomData["Final", "FinalBlend"]   = "1 0 1 0";
   blossomData["Final", "MaxDamage"]    = 200;
   blossomData["Final", "DamageRadius"] = 800; 
   
   //paint job
   mountedImageMaps[0] = "massBomb_blastImageMap 64 64 0 0 0";
      
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 1 1 1";
   mountedImageMapState["Mounted", "FinalBlend", 0]   = "1 1 1 1";
   mountedImageMapState["Mounted", "PulseData", 0]    = "0 0 1 1 0";
   
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 1 1 1";
   mountedImageMapState["Drifting", "FinalBlend", 0]   = "1 1 1 1"; 
   mountedImageMapState["Drifting", "PulseData", 0]    = "0 0 1 1 0";
   
   mountedImageMapState["Active", "InitialBlend", 0] = "1 1 1 1";
   mountedImageMapState["Active", "FinalBlend", 0]   = "1 1 1 1"; 
   mountedImageMapState["Active", "PulseData", 0]    = "0 0 1 1 0"; 
};


function MassBombDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}

//////////////////////////////////////////////
// Mediums //////////////////////////////////
////////////////////////////////////////////


//Will need to show health and time left. 
//longer it lives, more destructive power. 
datablock MassBombDatablock(MassBomb_EXP_Medium : MassBombBase) 
{
   explosionScale = "1";
   explosionDatablock = "MassBombExplosion";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 1.65;
   
   missileLifetimeMS = "8000";
   maxHealth = "20";    
   maxSpeed = "350";    
   
   wispDatablocks = "ExplosiveWisp"; //does a get random word if we have a potpurri mass bomb 
   wispCount = 4;
         
   constantThrustForce = "5000";
   engineEngageTimer   = "1"; //next frame
   turnSpeed           = "45";
   
   blossomData["Final", "MaxDamage"]    = 200;
   blossomData["Final", "DamageRadius"] = 500; 
   
   damageType = "Projectile";  //impact damage
   damageStrength = LargeTorpedo.damageStrength/2;
         
   explosiveLightMultiplier = 4;
   
   mountedImageMaps[0] = "massBomb_heatImageMap 64 64 0 0 0"; 
};

datablock MassBombDatablock(MassBomb_HEAT_Medium : MassBomb_EXP_Medium) 
{   
   wispDatablocks = "HeatWisp"; //does a get random word if we have a potpurri mass bomb 
   mountedImageMaps[0] = "massBomb_blastImageMap 64 64 0 0 0"; 
};


datablock MassBombDatablock(MassBomb_CORROSIVE_Medium : MassBomb_EXP_Medium) 
{   
   wispDatablocks = "CorrosiveWisp"; //does a get random word if we have a potpurri mass bomb 
   mountedImageMaps[0] = "massBomb_toxicImageMap 64 64 0 0 0";   
};



datablock MassBombDatablock(MassBomb_ION_Medium : MassBomb_EXP_Medium) 
{   
   wispDatablocks = "IonWisp"; //does a get random word if we have a potpurri mass bomb 
   mountedImageMaps[0] = "massBomb_empImageMap 64 64 0 0 0";   
};

//////////////////////////////////////////////
// Larges ///////////////////////////////////
////////////////////////////////////////////

datablock MassBombDatablock(MassBomb_EXP_Large : MassBombBase) 
{
   size = "96 96";
   
   explosionScale = "1";
   explosionDatablock = "MassBombExplosion";
   
   engineDatablock_Default = "MissileThruster";
   thrustEffectScale = 2;
   
   wispDatablocks = "ExplosiveWisp"; //does a get random word if we have a potpurri mass bomb 
   wispCount = 7;
   
   damageType = "Projectile";  //impact damage
   damageStrength = HugeTorpedo.damageStrength/2;
   
   missileLifetimeMS = "12000";   
   maxHealth = "50";    
   maxSpeed = "250";   
   
   blossomData["Final", "MaxDamage"]    = 400;
   blossomData["Final", "DamageRadius"] = 800; 
   
   constantThrustForce = "5000";
   engineEngageTimer   = "1"; //next frame
   turnSpeed           = "30";
     
   explosiveLightMultiplier = 6; 
   
   mountedImageMaps[0] = "massBomb_heatImageMap 96 96 0 0 0";   
};


datablock MassBombDatablock(MassBomb_HEAT_Large : MassBomb_EXP_Large) 
{  
   wispDatablocks = "HeatWisp"; //does a get random word if we have a potpurri mass bomb 
   mountedImageMaps[0] = "massBomb_blastImageMap 96 96 0 0 0";   
};


datablock MassBombDatablock(MassBomb_CORROSIVE_Large : MassBomb_EXP_Large) 
{  
   wispDatablocks = "CorrosiveWisp"; //does a get random word if we have a potpurri mass bomb 
   mountedImageMaps[0] = "massBomb_toxicImageMap 96 96 0 0 0";   
};

datablock MassBombDatablock(MassBomb_ION_Large : MassBomb_EXP_Large) 
{   
   wispDatablocks = "IonWisp"; //does a get random word if we have a potpurri mass bomb 
   mountedImageMaps[0] = "massBomb_empImageMap 96 96 0 0 0";   
};

