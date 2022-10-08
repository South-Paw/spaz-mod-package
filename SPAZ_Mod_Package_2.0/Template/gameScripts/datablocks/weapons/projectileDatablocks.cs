
////////////////////////////////////////////////////////////////////////////////
// PROJECTILE DATABLOCKS
////////////////////////////////////////////////////////////////////////////////
   
datablock ProjectileDatablock(ProjectileBase) 
{      
   //art
   imageMap = "bullet_normalImageMap";
   frame = "0";
   canSaveDynamicFields = "1";
   CollisionPolyList = "-0.372 -0.678 0.424 -0.683 0.424 0.948 -0.351 0.938";
   size = "64 64";
   
   //Speed and distance
   maxSpeed      = "500";
   speedVariance = "0";
   maxRange      = "1000";     
   
   //damage
   damageType     = "Projectile";
   damageStrength = "1";
   
   //spin.  
   initialAngularVelocity = 0;
   
   inheritWeaponVelocity = true;
   
   //effects projectile color and size multipliers
   blendBeginTime = 0.8; //how long before the end of the projectile life do we begin blending to final
   
   //Projectile color
   isIntense = true;
   
   initialRed   = "1";
   initialGreen = "1";
   initialBlue  = "1";
   initialAlpha = "1";
   
   finalRed   = "1";
   finalGreen = "1";
   finalBlue  = "1";
   finalAlpha = "1";
   
   //Blend Size 
   finalSizeMultX = 0.33;  //hooked up to blendBeginTime
   finalSizeMultY = 0.66;

   //initial random size
   sizeRandomness = 0;  //this is a percentage.  so 0.2 would be +/- 20%
   maintainAspectRatio = true; //when selecting random sizes, should we maintain aspect ratio
     
   //fire effect
   fire_effect            = "ProjectileFire";
   fire_effect_scale      = "1";          
   fire_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   fire_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   fireSound              = "snd_smallProjectileFire";
   
   //hit Effect
   hit_effect            = "ProjectileImpact";
   hit_effect_scale      = "1";
   hit_effect_StartBlend = "1 1 0 1";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   hit_effect_EndBlend   = "1 0 0 1";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   hitSound              = "snd_smallProjectileHit"; 
   
   //Exit effect  For penetrating projectiles.
   IsPenetrating = false;  //NOTE: must not use preload motion effects for penetrators or they will be left behind
   exit_effect            = "SmallExplosion";
   exit_effect_scale      = "1.5";    //NOTE!!!! exit effect is not 100% reliable to be played
   exit_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   exit_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   exitDamageMult         = 1;
   exitSound              = "snd_smallExplosion"; //effect will happen 200ms after the object is exited
   exitShipDebris         = "DC_MassDriver_Small";


   //motion Effect
   motionEffect             = "";
   motionEffectScale        = 1;
   motionEffectOffset       = "0 0";
   motionEffectStartTime    = 0;  //so can start and end the effect whenever you want.
   motionEffectEndTime      = 1;   
   motion_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   motion_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   
   
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
   
   //base chance changes with how direct the fire is at the normal.  higher angles = greater reflect chance.
   //shield damage is related to the angle on incidence.  so a high angle shot will do little damage
   shieldReflectionChance   = 0.5;   //if it is 1 it will always reflect.  else will be based on angle
   shieldReflectImpulse     = 0;   
   shieldReflectEffect      = "ProjectileImpact";
   shieldReflectEffectScale = 1;
   shieldReflectSound       = "snd_smallProjectileHit"; 
   shieldReflect_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   shieldReflect_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   shieldReflectDamageMult = 1;  //for things like mass drivers to not cause much shield damage.  
      
      
   //Research
   researchDatablock = "ProjectileResearch";
};

////////////////////////////////////////////////////////////////////////////////
// BASIC BULLETS
////////////////////////////////////////////////////////////////////////////////

datablock ProjectileDatablock(SmallBullet : ProjectileBase) 
{
   imageMap = "bullet_normalImageMap";   
         
   size = "12 24";
   maxRange = "750";  //cannon has 50% longer range. 
   maxSpeed = "1800";  
   damageStrength = 1; 
   speedVariance = "0.25";
   
   damageType     = "Universal"; 

   coronaImageMap = "bullet_normal_glowImageMap"; 
   coronaInitialScale = 1.5; //look at projectile scale and keep in sync with it. 
   coronaAngularVelocity = 0; //looks weird to spin things that arent round
   
   coronaBlendBeginTime = 0.5;
   
   coronaFinalSizeMultX = 0; //poof
   coronaFinalSizeMultY = 0;
   
   //coloring
   initialRed   = "1";
   initialGreen = "1";
   initialBlue  = "0";
   initialAlpha = "1";
   
   finalRed   = "1";
   finalGreen = "1";
   finalBlue  = "0";
   finalAlpha = "0";   
   
   coronaInitialRed   = "1";
   coronaInitialGreen = "0";
   coronaInitialBlue  = "0";
   coronaInitialAlpha = "0.4";
   
   coronaFinalRed   = "1";
   coronaFinalGreen = "0";
   coronaFinalBlue  = "0";
   coronaFinalAlpha = "0";

   hit_effect_scale  = "0.7";
   hit_effect_StartBlend = "1 1 0 1"; 
   hit_effect_EndBlend   = "1 0.5 0 1"; 
   
   fire_effect_scale      = "0.6";          
   fire_effect_StartBlend = "1 1 0 1";  
   fire_effect_EndBlend   = "1 0.5 0 1";  
   
   motionEffect = "bulletSparks";
   motion_effect_StartBlend = "1 0 0 1";  
   motion_effect_EndBlend   = "1 0 0 1";    
};

datablock ProjectileDatablock(MediumBullet : SmallBullet) 
{
   maxRange = "900";  //lives 600ms
   maxSpeed = "1700";
   damageStrength = 1.500; 
   speedVariance = "0.25";
   
   size = "24 24";
   
   coronaInitialScale = 1.5; //look at projectile scale and keep in sync with it. 
   coronaAngularVelocity = 0; //looks weird to spin things that arent round
   
   coronaBlendBeginTime = 0.5;
   
   coronaFinalSizeMultX = 0; //poof
   coronaFinalSizeMultY = 0;
   
   hit_effect_scale  = "0.8";   
   fire_effect_scale      = "1";          
};


datablock ProjectileDatablock(LargeBullet : SmallBullet) 
{
   imageMap = "bullet_normalImageMap";
 
   maxRange = "1050";  //cannon has 50% longer range. 
   maxSpeed = "1600";
   damageStrength = 2.250; 
   speedVariance = "0.25";
   
   size = "32 32";
   
   coronaInitialScale = 1.75; //look at projectile scale and keep in sync with it. 
   coronaAngularVelocity = 0; //looks weird to spin things that arent round
   
   coronaBlendBeginTime = 0.5;
   
   coronaFinalSizeMultX = 0; //poof
   coronaFinalSizeMultY = 0;
   
   motionEffectScale = 1;
   motionEffectOffset = "0 0";
   motionEffectStartTime = 0;  //so can start and end the effect whenever you want.
   motionEffectEndTime = 1;
   
   hit_effect_scale  = "0.9";   
   fire_effect_scale      = "1.2";          
};



datablock ProjectileDatablock(HugeBullet : SmallBullet) 
{  
   maxRange = "1200";  //cannon has 50% longer range. 
   maxSpeed = "1500";
   damageStrength = 3; 
   speedVariance = "0.25";
   
   size = "48 48";
   
   coronaInitialScale = 1.75; //look at projectile scale and keep in sync with it. 
   coronaAngularVelocity = 0; //looks weird to spin things that arent round
   
   coronaBlendBeginTime = 0.5;
   
   coronaFinalSizeMultX = 0; //poof
   coronaFinalSizeMultY = 0; 

   motionEffectScale = 1;
   motionEffectOffset = "0 0";
   motionEffectStartTime = 0;  //so can start and end the effect whenever you want.
   motionEffectEndTime = 1;
      
   hit_effect_scale  = "0.95";   
   fire_effect_scale      = "1.5";          
};

////////////////////////////////////////////////////////////////////////////////
// CANNONS
////////////////////////////////////////////////////////////////////////////////

datablock ProjectileDatablock(SmallBullet_cannon : SmallBullet) 
{
   size = "32 32";
   
   maxRange = "900";  
   maxSpeed = "800";
   damageStrength = "10";
   speedVariance = "0"; //sniper weapon so better be fair
   
   damageType     = "Projectile";
   
   initialAngularVelocity = 360;
   imageMap = "bullet_ballImageMap";
   coronaImageMap = "bullet_ball_glowImageMap";  
   fireSound = "snd_pulseFire";
   
   motionEffect = "bulletRings";  //NOTE: must not use preload effects for penetrators or they will be left behind
   motion_effect_StartBlend = "1 1 1 0";  
   motion_effect_EndBlend   = "0 1 1 0"; 
   motionEffectScale = 0.5;
   motionEffectOffset = "0 0";
   motionEffectStartTime = 0;  //so can start and end the effect whenever you want.
   motionEffectEndTime = 1;
   
   //coloring
   initialRed   = "0.8";
   initialGreen = "1";
   initialBlue  = "1";
   initialAlpha = "1";
   
   finalRed   = "0.8";
   finalGreen = "1";
   finalBlue  = "1";
   finalAlpha = "0";   
   
   coronaInitialScale = 2.25;   
   
   coronaInitialRed   = "0";
   coronaInitialGreen = "1";
   coronaInitialBlue  = "0";
   coronaInitialAlpha = "0.4";
   
   coronaFinalRed   = "0";
   coronaFinalGreen = "1";
   coronaFinalBlue  = "0";
   coronaFinalAlpha = "0";

   hit_effect_scale  = "0.7";
   hit_effect_StartBlend = "0.5 1 1 1"; 
   hit_effect_EndBlend   = "0 1 0 1"; 
   
   fire_effect_scale      = "0.6";          
   fire_effect_StartBlend = "0.5 1 1 1";  
   fire_effect_EndBlend   = "0 1 0 1";    
};

datablock ProjectileDatablock(MediumBullet_cannon : SmallBullet_cannon) 
{
   size = "42 42";   
   
   maxRange = "1050";  
   maxSpeed = "700";
   damageStrength = "15";
   
   initialAngularVelocity = 270;
   motionEffectScale = 0.667;

   hit_effect_scale  = "0.9";
   fire_effect_scale      = "0.8";          
};

datablock ProjectileDatablock(LargeBullet_cannon : SmallBullet_cannon) 
{
   size = "52 52";   
   
   maxRange = "1200";  
   maxSpeed = "600";
   damageStrength = "23";
   
   initialAngularVelocity = 135;
   motionEffectScale = 0.800;
   
   hit_effect_scale  = "1";
   fire_effect_scale      = "0.9";    
};

datablock ProjectileDatablock(HugeBullet_cannon : SmallBullet_cannon) 
{
   size = "64 64";   
   
   maxRange = "1350";  
   maxSpeed = "500";
   damageStrength = "35";
   
   initialAngularVelocity = 60;
   motionEffectScale = 1.0;

   hit_effect_scale  = "1.2";
   fire_effect_scale      = "1";  
};

////////////////////////////////////////////////////////////////////////////////
// CIV CANNONS
////////////////////////////////////////////////////////////////////////////////

//KEEP ALL COLOR DATA THE SAME

datablock ProjectileDatablock(SmallBullet_cannon_civ : SmallBullet_cannon) 
{ 
   maxRange = SmallBullet_cannon.maxRange * 1.333;  
   maxSpeed = SmallBullet_cannon.maxSpeed * 1.500;  
   damageStrength = SmallBullet_cannon.damageStrength * 0.500;  
   
   //coloring   
   coronaInitialRed   = "0.5";
   coronaInitialGreen = "0.5";
   coronaInitialBlue  = "1";
   coronaInitialAlpha = "0.4";
   
   coronaFinalRed   = "0";
   coronaFinalGreen = "0";
   coronaFinalBlue  = "1";
   coronaFinalAlpha = "0";

   hit_effect_scale  = "0.7";
   hit_effect_StartBlend = "0.5 1 1 1"; 
   hit_effect_EndBlend   = "0 1 1 1"; 
   
   fire_effect_scale      = "0.6";          
   fire_effect_StartBlend = "0.5 1 1 1";  
   fire_effect_EndBlend   = "0 1 1 1"; 
};

datablock ProjectileDatablock(MediumBullet_cannon_civ : MediumBullet_cannon) 
{ 
   maxRange = MediumBullet_cannon.maxRange * 1.333;  
   maxSpeed = MediumBullet_cannon.maxSpeed * 1.500;  
   damageStrength = MediumBullet_cannon.damageStrength * 0.500;  
   
   //coloring
   coronaInitialRed   = "0.5";
   coronaInitialGreen = "0.5";
   coronaInitialBlue  = "1";
   coronaInitialAlpha = "0.4";
   
   coronaFinalRed   = "0";
   coronaFinalGreen = "0";
   coronaFinalBlue  = "1";
   coronaFinalAlpha = "0";

   hit_effect_scale  = "0.7";
   hit_effect_StartBlend = "0.5 1 1 1"; 
   hit_effect_EndBlend   = "0 1 1 1"; 
   
   fire_effect_scale      = "0.6";          
   fire_effect_StartBlend = "0.5 1 1 1";  
   fire_effect_EndBlend   = "0 1 1 1"; 

};

datablock ProjectileDatablock(LargeBullet_cannon_civ : LargeBullet_cannon) 
{ 
   maxRange = LargeBullet_cannon.maxRange * 1.333;  
   maxSpeed = LargeBullet_cannon.maxSpeed * 1.500;  
   damageStrength = LargeBullet_cannon.damageStrength * 0.500;  
   
   //coloring
   coronaInitialRed   = "0.5";
   coronaInitialGreen = "0.5";
   coronaInitialBlue  = "1";
   coronaInitialAlpha = "0.4";
   
   coronaFinalRed   = "0";
   coronaFinalGreen = "0";
   coronaFinalBlue  = "1";
   coronaFinalAlpha = "0";

   hit_effect_scale  = "0.7";
   hit_effect_StartBlend = "0.5 1 1 1"; 
   hit_effect_EndBlend   = "0 1 1 1"; 
   
   fire_effect_scale      = "0.6";          
   fire_effect_StartBlend = "0.5 1 1 1";  
   fire_effect_EndBlend   = "0 1 1 1"; 
};

datablock ProjectileDatablock(HugeBullet_cannon_civ : HugeBullet_cannon) 
{ 
   maxRange = HugeBullet_cannon.maxRange * 1.333;  
   maxSpeed = HugeBullet_cannon.maxSpeed * 1.500;  
   damageStrength = HugeBullet_cannon.damageStrength * 0.500;  
   
   //coloring
   coronaInitialRed   = "0.5";
   coronaInitialGreen = "0.5";
   coronaInitialBlue  = "1";
   coronaInitialAlpha = "0.4";
   
   coronaFinalRed   = "0";
   coronaFinalGreen = "0";
   coronaFinalBlue  = "1";
   coronaFinalAlpha = "0";

   hit_effect_scale  = "0.7";
   hit_effect_StartBlend = "0.5 1 0.5 1"; 
   hit_effect_EndBlend   = "0 1 0 1"; 
   
   fire_effect_scale      = "0.6";          
   fire_effect_StartBlend = "0.5 1 0.5 1";  
   fire_effect_EndBlend   = "0 1 0 1"; 
};

////////////////////////////////////////////////////////////////////////////////
// CLUSTERS
////////////////////////////////////////////////////////////////////////////////

datablock ProjectileDatablock(SmallBullet_cluster : SmallBullet) 
{
   size = "20 20";
   
   maxRange = "650";  
   maxSpeed = "1500";
   damageStrength = "2";   
   
   hit_effect_scale  = "0.33";
   fire_effect_scale = "1";
   
   finalSizeMultX = 3;
   finalSizeMultY = 3;
   blendBeginTime = 0;
   initialAngularVelocity = 0;
   imageMap = "bullet_clusterImageMap";
   coronaImageMap = "bullet_ball_glowImageMap"; 
   coronaInitialAlpha = "0.4";
   fireSound = "snd_clusterProjectileFire";
   
   motionEffect = "";  
   
   damageType     = "Energy";
   
   //coloring
   initialRed   = "0";
   initialGreen = "1";
   initialBlue  = "1";
   initialAlpha = "1";
   
   finalRed   = "0";
   finalGreen = "0.5";
   finalBlue  = "1";
   finalAlpha = "0";   
   
   coronaInitialScale = 2.25;      
   
   coronaInitialRed   = "0";
   coronaInitialGreen = "0.3";
   coronaInitialBlue  = "1";
   coronaInitialAlpha = "0.4";
   
   coronaFinalRed   = "0";
   coronaFinalGreen = "0";
   coronaFinalBlue  = "1";
   coronaFinalAlpha = "0";

   hit_effect            = "ProjectileImpact_ION";
   hit_effect_scale  = "0.7";
   hit_effect_StartBlend = "0 0 0 0"; 
   hit_effect_EndBlend   = "0 0 0 0"; 
   //hit_effect_StartBlend = "0 1 1 1"; 
   //hit_effect_EndBlend   = "0 0.5 1 1";
   
   fire_effect_scale      = "0.6";          
   fire_effect_StartBlend = "0 1 1 1";  
   fire_effect_EndBlend   = "0 0.5 1 1";    
};

datablock ProjectileDatablock(MediumBullet_cluster : SmallBullet_cluster) 
{
   size = "24 24";
   
   maxRange = "800";  
   maxSpeed = "1350";
   damageStrength = "3";   

   hit_effect_scale  = "0.8";
   fire_effect_scale      = "0.6";          
};

datablock ProjectileDatablock(LargeBullet_cluster : SmallBullet_cluster) 
{
   size = "32 32";

   maxRange = "950";  
   maxSpeed = "1200";
   damageStrength = "4.5";   
   
   hit_effect_scale  = "0.9";
   fire_effect_scale      = "0.7";   
};

datablock ProjectileDatablock(HugeBullet_cluster : SmallBullet_cluster) 
{
   size = "48 48";
   
   maxRange = "1100";  
   maxSpeed = "1050";
   damageStrength = "6.75";

   hit_effect_scale  = "1";
   fire_effect_scale      = "0.8";   
};

////////////////////////////////////////////////////////////////////////////////
// MASS DRIVERS
////////////////////////////////////////////////////////////////////////////////

datablock ProjectileDatablock(SmallBullet_massDriver : LargeBullet) 
{
   damageType     = "ArmorPierce"; //ignores armor
   IsPenetrating  = true; //will exit back end
   inheritWeaponVelocity = false;
   
   maxRange = "1500";  
   maxSpeed = "1500";   
   
   damageStrength = "1";  //good cuz will hit going in and comming out so really does 40
   exitDamageMult = 4;  
   shieldReflectDamageMult  = 1; //base damage strngth very low, //downside of mass driver suuuuux vs shields
   shieldReflectionChance   = 1;  //always reflect
   shieldReflectImpulse     = 50;  //may want this quite high 
      
   size = "16 64";
   finalSizeMultX = 2;
   finalSizeMultY = 2;
   initialAngularVelocity = 0;
   coronaAngularVelocity = 0;
   coronaInitialAlpha = "0.4";    
   
   imageMap = "bullet_normalImageMap";
   coronaImageMap = "bullet_normal_glowImageMap";   
   fireSound = "snd_massDriverFire";
  
   initialRed   = "1";
   initialGreen = "1";
   initialBlue  = "1";
   initialAlpha = "1";
   
   finalRed   = "1";
   finalGreen = "1";
   finalBlue  = "1";
   finalAlpha = "0";   
   
   motionEffect = "MassDriverMotion";  //NOTE: must not use preload effects for penetrators or they will be left behind
   motion_effect_StartBlend = "1 0 1 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   motion_effect_EndBlend   = "1 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   
   hit_effect        = "MassDriverImpact"; //effect looks bad is scaled
   hit_effect_scale  = "1";
   hit_effect_StartBlend = "1 1 1 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   hit_effect_EndBlend   = "1 1 1 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag

   exit_effect        = "MassDriverExit"; //effect looks bad is scaled
   exit_effect_scale  = "1";
   exit_effect_StartBlend = "1 1 1 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   exit_effect_EndBlend   = "1 0 0.5 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag

};

datablock ProjectileDatablock(MediumBullet_massDriver : SmallBullet_massDriver) 
{
   maxRange = "1500";  
   maxSpeed = "1500";   
   
   damageStrength = "1.333";  //good cuz will hit going in and comming out so really does 40
   exitDamageMult = 5;  
   shieldReflectDamageMult  = 1; //base damage strngth very low, //downside of mass driver suuuuux vs shields
   shieldReflectionChance   = 1;  //always reflect
   shieldReflectImpulse     = 50;  //may want this quite high 
      
   size = "20 80";
   finalSizeMultX = 2;
   finalSizeMultY = 2;
   initialAngularVelocity = 0;
   coronaAngularVelocity = 0;
   coronaInitialAlpha = "0.4";    
};


datablock ProjectileDatablock(LargeBullet_massDriver : SmallBullet_massDriver) 
{
   maxRange = "1500";  
   maxSpeed = "1500";   
   
   damageStrength = "2";  //good cuz will hit going in and comming out so really does 40
   exitDamageMult = 4;  
   shieldReflectDamageMult  = 1; //base damage strngth very low, //downside of mass driver suuuuux vs shields
   shieldReflectionChance   = 1;  //always reflect
   shieldReflectImpulse     = 50;  //may want this quite high 
      
   size = "24 96";
   finalSizeMultX = 2;
   finalSizeMultY = 2;
   initialAngularVelocity = 0;
   coronaAngularVelocity = 0;
   coronaInitialAlpha = "0.4";    
};

datablock ProjectileDatablock(HugeBullet_massDriver : SmallBullet_massDriver) 
{
   maxRange = "1500";  
   maxSpeed = "1500";   
   
   damageStrength = "3.335";  //good cuz will hit going in and comming out so really does 40
   exitDamageMult = 4;  
   shieldReflectDamageMult  = 1;  //downside of mass driver suuuuux vs shields
   shieldReflectionChance   = 1;  //always reflect
   shieldReflectImpulse     = 100;  //may want this quite high 
   
   size = "32 128";
   finalSizeMultX = 2;
   finalSizeMultY = 2;
   initialAngularVelocity = 0;
   coronaAngularVelocity = 0;
   coronaInitialAlpha = "0.4"; 
};

////////////////////////////////////////////////////////////////////////////////
//drone weapons
////////////////////////////////////////////////////////////////////////////////

datablock ProjectileDatablock(MicroDoubleBullet : ProjectileBase) 
{
   imageMap = "bullet_doubleImageMap";   
         
   maxRange = "600";  
   maxSpeed = "2000";
   damageStrength = "2";
   speedVariance = "0.3";
   size = "12 12";
   
   initialRed   = "1";
   initialGreen = "0.6";
   initialBlue  = "0.2";
   initialAlpha = "1";
   
   damageType     = "Projectile";
   
   finalRed   = "1";
   finalGreen = "0.2";
   finalBlue  = "0.2";
   finalAlpha = "0";

   coronaImageMap = "bullet_normal_glowImageMap"; 
   coronaInitialScale = 1.5; //look at projectile scale and keep in sync with it. 
   coronaAngularVelocity = 0; //looks weird to spin things that arent round
   
   coronaInitialRed   = "1";
   coronaInitialGreen = "0.2";
   coronaInitialBlue  = "0";
   coronaInitialAlpha = "0.8";
   
   coronaBlendBeginTime = 0.5;
   
   coronaFinalRed   = "1";
   coronaFinalGreen = "0.2";
   coronaFinalBlue  = "0";
   coronaFinalAlpha = "0";
   
   coronaFinalSizeMultX = 0; //poof
   coronaFinalSizeMultY = 0;
   
   fireSound              = "snd_microProjectileFire";   
   
   fire_effect            = "MicroImpact";
   hit_effect            = "MicroImpact";       
   
   hit_effect_scale  = "1";
   hit_effect_StartBlend = "1 0.5 0 1"; 
   hit_effect_EndBlend   = "1 0 0 1"; 
   
   fire_effect_scale      = "1";          
   fire_effect_StartBlend = "1 0.5 0 1";  
   fire_effect_EndBlend   = "1 0 0 1";  
};

datablock ProjectileDatablock(MicroBombBullet : ProjectileBase) 
{
   imageMap = "bullet_ballImageMap";
   
   initialAngularVelocity = 100;
   
   CollisionPolyList = "-0.477 -0.408 0.466 -0.398 0.477 0.530 -0.456 0.530";
   
   maxRange = "600";  
   maxSpeed = "1000";
  
   damageType     = "Universal";
   
   damageStrength = "10";
   speedVariance = "0";
   size = "24 24";
   
   initialRed   = "1";
   initialGreen = "0.5";
   initialBlue  = "0.1";
   initialAlpha = "1";
   
   finalRed   = "1";
   finalGreen = "0.3";
   finalBlue  = "0";
   finalAlpha = "0";
   
   coronaImageMap = "bullet_ball_glowImageMap"; 
   coronaInitialScale = 1.75; //look at projectile scale and keep in sync with it. 
   coronaAngularVelocity = 35; //looks weird to spin things that arent round
   
   coronaInitialRed   = "1";
   coronaInitialGreen = "0.2";
   coronaInitialBlue  = "0";
   coronaInitialAlpha = "0.7";
   
   coronaBlendBeginTime = 0.5;
   
   coronaFinalRed   = "1";
   coronaFinalGreen = "0.2";
   coronaFinalBlue  = "0";
   coronaFinalAlpha = "0";
   
   coronaFinalSizeMultX = 0; //poof
   coronaFinalSizeMultY = 0;
   
   motionEffect = "";
     
   fireSound              = "snd_microProjectileFire";     
     
   fire_effect            = "MicroImpact";
   hit_effect            = "SmallExplosion"; 
   
   hit_effect_scale  = "0.5";
   hit_effect_StartBlend = "1 1 1 1"; 
   hit_effect_EndBlend   = "1 1 1 0"; 
   
   fire_effect_scale      = "0.8";          
   fire_effect_StartBlend = "1 0.6 0 1";  
   fire_effect_EndBlend   = "1 0.3 0 1";  
};

////////////////////////////////////////////////////////////////////////////////
//zombie specific ///////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////

datablock ProjectileDatablock(ZombieBlobBullet : ProjectileBase) 
{
   imageMap = "bullet_pelletsImageMap";
   
   fire_effect       = "ProjectileFire_zombie";
   hit_effect        = "ProjectileImpact_zombie";
   
   damageType     = "Ion"; 
   
   //RLB: did some jiggery pokery here
   isIntense = true;
   blendBeginTime = 0.10; //how long before the end of the projectile life do we begin blending to final
   finalSizeMultX = 1.5;
   finalSizeMultY = 2;
   sizeRandomness = 0.33;  //+/- 33%
   maintainAspectRatio = false; //when selecting random sizes, should we maintain aspect ratio
   
   maxRange = "750";  
   maxSpeed = "250";
   damageStrength = "1.5"; //Scales star tech level wise until sec4 when it is set to 70%
   speedVariance = "0.7";
   size = "64 64";
   
   initialRed   = "0.3";
   initialGreen = "1";
   initialBlue  = "0.3";
   initialAlpha = "1";
   
   finalRed   = "0.3";
   finalGreen = "1";
   finalBlue  = "0.3";
   finalAlpha = "0";
   
   hit_effect_scale  = "1";
   
   coronaImageMap = "bullet_ball_glowImageMap"; 
   coronaInitialScale = 1; //look at projectile scale and keep in sync with it. 
   coronaAngularVelocity = 0; //looks weird to spin things that arent round
   
   coronaInitialRed   = "0.7";
   coronaInitialGreen = "1";
   coronaInitialBlue  = "0.3";
   coronaInitialAlpha = "0.3";
   
   coronaBlendBeginTime = 0.80;
   
   coronaFinalRed   = "1";
   coronaFinalGreen = "0.7";
   coronaFinalBlue  = "0.3";
   coronaFinalAlpha = "0";
   
   coronaFinalSizeMultX = 5; //poof
   coronaFinalSizeMultY = 5;
   
   motionEffect = "BulletDrip";
   motionEffectScale = 1;
   motionEffectOffset = "0 0";
   motionEffectStartTime = 0;  //so can start and end the effect whenever you want.
   motionEffectEndTime = 1;
   
   hit_effect_StartBlend = "0.6 1 0 1";  
   hit_effect_EndBlend   = "0 1 0 1"; 
   hitSound              = "snd_zombieSpitting"; 
   
   fire_effect_StartBlend = "0.6 1 0 1";  
   fire_effect_EndBlend   = "0 1 0 1"; 
   fireSound = "snd_zombieSpitting";   
};





















