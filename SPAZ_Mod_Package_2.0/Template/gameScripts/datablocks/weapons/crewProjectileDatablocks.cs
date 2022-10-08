////////////////////////////////////////////////////////////////////////////////
//Crew Bullets /////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////

//NOTE: cross inheritance doesnt work right with coded classes, so need to redefine everyhting in this one. 
datablock CrewProjectileDatablock(CrewCannonBulletBase) 
{   
   //Stuff from Proejctile dATABLOCK: Has to be here!
   imageMap = "bullet_normalImageMap";
   frame = "0";
   canSaveDynamicFields = "1";
   CollisionPolyList = "-0.372 -0.678 0.424 -0.683 0.424 0.948 -0.351 0.938";
   maxSpeed = "500";
   speedVariance = "0";
   maxRange = "1000";     
   size = "64 64";

   damageType = "Projectile";
   damageStrength = "2";
   
   initialRed   = "1";
   initialGreen = "1";
   initialBlue  = "1";
   initialAlpha = "1";
   initialAngularVelocity = 0;
     
   blendBeginTime = 1; //how long before the end of the projectile life do we begin blending to final
   finalSizeMultX = 1;
   finalSizeMultY = 1;
   
   sizeRandomness = 0;  //this is a percentage.  so 0.2 would be +/- 20%
   maintainAspectRatio = true; //when selecting random sizes, should we maintain aspect ratio
   
   isIntense = true;
    
   researchDatablock = "CrewResearch";
   
   //Coronas
   coronaImageMap = "";  //no corona
   coronaInitialScale = 1.3; //look at projectile scale and keep in sync with it. 
   coronaAngularVelocity = 0; //looks weird to spin things that arent round
   
   coronaInitialRed   = "1";
   coronaInitialGreen = "1";
   coronaInitialBlue  = "1";
   coronaInitialAlpha = "1";
   
   coronaBlendBeginTime = 0.66;
   
   coronaFinalRed   = "1";
   coronaFinalGreen = "1";
   coronaFinalBlue  = "1";
   coronaFinalAlpha = "0";
   
   coronaFinalSizeMultX = 0; //shrink really fast compared to parent projectile
   coronaFinalSizeMultY = 0;
   
   //effects
   motionEffect = "";
   motionEffectScale = 1;
   motionEffectOffset = "0 0";
   motionEffectStartTime = 0;  //so can start and end the effect whenever you want.
   motionEffectEndTime = 1;
   
   //////////////////////////
   //Changed Stuff: ////////  
   ////////////////////////  
      
   //we want these to explode on death and not fade out
   fire_effect             = "SmallExplosion";  //cannot be infinite.  make like other projectile fire effect
   fire_effect_scale       = "1";
   fireSound               = "snd_shuttleLaunch";  //needs a whoosh of some kind
      
   //This is reall a marine pod bursting effect.
   hit_effect              = "marinepod_eject";  //played when hitting other ships, or popping when returning home
   hit_effect_scale        = "0.5";
   hitSound                = "snd_smallProjectileHit";
   
   explosion_effect        = "escapePod_shatter";  //played when shot down
   explosion_effect_scale  = 1;
   explosionSound          = "snd_smallExplosion";
   
   invadeShip_effect       = "BeamAbord";
   invadeShip_effect_scale = 1;
   
      
   motionEffect = "shuttleMotion";  //will be cancelled when engines engage
   motionEffectScale = 1;
   motionEffectOffset = "0 1";
   motionEffectStartTime = 0; 
   motionEffectEndTime = 0.9;
   
   isIntense = false;
   //We may want to use a different research datablock for this. 
   
   
   
   /////////////////////////
   //New Stuff: ///////////  
   ///////////////////////
   canSeekTargets = false;  //also implies spawning pods when destroyed or returning home
   popOnRemove = false;
    
   numCrew = 1;
   maxHealth = 2;     
   projectileMass = 1;   //used to standardize engine thrust.
   
   //if !canSeekTargets engines will not turn on.
   engineMaxSpeed         = 400;  //we may want to upgrade this with tech
   engineThrustForce      = 250;
   engineDamping          = 0.2;
   engineBaseRotationRate = 120; //we may want to upgrade this with tech
   engineEffectScale      = 1;   
   engineStartSeconds = 1;  //this is in seconds for firing consistency
   engineThrustEffect = "TinyThruster";  //will color this to faction
   engineThrustOffset = "0 1";
   
   factionImageMap_Pirate = "marinePod_pirateImageMap";
   factionImageMap_Terran = "marinePod_terranImageMap";
   factionImageMap_Civ    = "marinePod_civImageMap";  //TODO: use civ
   factionImageMap_Zombie = "marinePod_zomImageMap";  //TEMP Here so we can make a version for zombies without a new class. 
   factionImageMap_Bounty = "marinePod_bountyImageMap";  //TEMP Here so we can make a version for zombies without a new class. 
   //Civs dont get them.  
   
};

//NOTE: need imagemap pirate and terran
datablock CrewProjectileDatablock(CrewCannonBullet_Kamakazie : CrewCannonBulletBase) 
{   
   factionImageMap_Pirate = "marinePod_tiny_pirateImageMap";
   factionImageMap_Terran = "marinePod_tiny_terranImageMap";  
   factionImageMap_Civ = "marinePod_tiny_civImageMap"; 
   factionImageMap_Zombie = "marinePod_tiny_zomImageMap"; 
   factionImageMap_Bounty = "marinePod_tiny_bountyImageMap";     
    
   numCrew = 1;
   maxHealth = 1;
   popOnRemove = true;
   
   maxRange = "1000";  
   maxSpeed = "1000";
   damageStrength = "2";   
   speedVariance = "0";
   size = "32 32";
      
   //we pop it now
   //blendBeginTime = 0.8; //how long before the end of the projectile life do we begin blending to final
   //finalSizeMultX = 0;   //into deep spaaaaaaceee!
   //finalSizeMultY = 0;    
   //finalAlpha = 0;
     
   hit_effect_scale  = "0.4";
};


//Shuttles should burst into pickups!!!
datablock CrewProjectileDatablock(CrewCannonBullet_Shuttle : CrewCannonBulletBase) 
{     
   canSeekTargets = true;
   
   numCrew = 5;
   maxHealth = 10;
   popOnRemove = false;
   
   maxRange = "2000";  
   maxSpeed = "500";   //This is only for the projectile shot
   damageStrength = "0";  //lands softly
   speedVariance = "0";
   size = "48 48";
     
   hit_effect_scale        = "0.66";
   explosion_effect_scale  = 1.5;
   invadeShip_effect_scale = 1.5;
   
   
   engineMaxSpeed         = 400;  //we may want to upgrade this with tech
   engineThrustForce      = 1500;
   engineDamping          = 0.2;
   engineBaseRotationRate = 240; //we may want to upgrade this with tech
   engineEffectScale      = 1;   
   engineStartSeconds = 1;  //this is in seconds for firing consistency
       
};
