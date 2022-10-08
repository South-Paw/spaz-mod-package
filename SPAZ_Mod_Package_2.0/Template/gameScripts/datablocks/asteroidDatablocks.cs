////////////////////////////////////////////////////////////////////////////////
//asteroids
////////////////////////////////////////////////////////////////////////////////


/////////////////////////////
// Base Class ///////////////
/////////////////////////////

datablock AsteroidDatablock(AsteroidBase)  //Cannot inherit safely from SpacePropBase.  Datablocks a little funky that way. 
{
   imageMapList = "";   // Can define multiple image maps for a prop in here.  Like with pickups
   
   explosionDatablock        = "AsteroidExplosion";
   explosionSound            = "snd_asteroidExplosion";
   explosionScale            = 1;   
   explosionDamageType       = "Explosive";
   explosionDamageStrength   = 0;
   explosionDamageRadius     = 300;
   
   explosiveFlash = true;
   
   mountedEffect = "";
   ignoreAutoBlending = false;
   
   maxHealth = 10;
   propMass  = 10;   
   
   isInvincible = false;  
   
   minLifeSpan = 10000; 
   
   subPropChance  = 0;
   subPropCount   = "1 3";       //GetRandomFromPair can be just a single number too
   subPropList    = "";         //weighted list of SpacePropDatablocks. can be single value
   subPropImpulse = 50;
     
   resourceChance      = 0;
   resourceMaxValue    = 0;   //Max resource value the prop can spawn. so we do not get big things popping out of small things. 
   resourceMaxToSpawn  = 2;
    
   datacubeChance     = 0;   
   datacubeMaxValue   = 0; 
   datacubeMaxToSpawn = 2;
   dataSpawnCheck = ""; //a function you can call to check for drop or not ... used to prevent exploits
            
   maxAngularVelocity = 40;  //getrandom (-maxAngularVelocity, maxAngularVelocity)
   
   dampenVel = "";
   
   objectClass = "";
   objectSuperClass = "AsteroidClass";    //IMPORTANT  
  
   objectLayer = $LAYER_ASTEROIDS_SMALL;
   objectGraphGroup = $COLLISION_ID_ASTEROIDS;
   
   wispChance = 0;
   wispCount = 1;  //GetRandomFromPair can be just a single number too
   wispDatablocks = "ExplosiveWisp";  //does a get random word
   
   canSpawnEggs = false;
   eggChance = 0;
   
   allowSceneWindowBlend = true;  
   
   heatRate = 0.02;
   coolRate = 0.005;
};


////////////////////////////////////////
// Smalls //////////////////////////////
////////////////////////////////////////
datablock AsteroidDatablock(AsteroidBase_Small : AsteroidBase) 
{
   size = "32 32";
   explosionScale = 0.2;   
   maxHealth = 4;
   maxAngularVelocity = 120;  
   
   wispChance = 0.02;   
   
   resourceChance     = 0.7;
   resourceMaxValue   = 19;   //Max resource value the prop can spawn. so we do not get big things popping out of small things. 
   
   
   objectLayer = $LAYER_ASTEROIDS_SMALL;
};

datablock AsteroidDatablock(asteroidSmall_01 : AsteroidBase_Small) 
{  
   imageMap = "asteroid_small_01ImageMap";
   CollisionPolyList = "-0.414 -0.859 0.388 -0.530 0.430 0.732 -0.634 0.481";
};


////////////////////////////////////////
// Mediums /////////////////////////////
////////////////////////////////////////
datablock AsteroidDatablock(AsteroidBase_Medium : AsteroidBase) 
{
   size = "64 64";
   explosionScale = 0.5;   
   maxHealth = 10;
   maxAngularVelocity = 90;  
   
   wispChance = 0.04;
   
   resourceChance    = 0.5;
   resourceMaxValue  = 49;   //Max resource value the prop can spawn. so we do not get big things popping out of small things. 

   subPropChance   = 0.5;
   subPropList     = "asteroidSmall_01";
   SubPropCount    = "1 3";
   
   objectLayer = $LAYER_ASTEROIDS_MEDIUM;
};


datablock AsteroidDatablock(asteroidMedium_01 : AsteroidBase_Medium) 
{  
   imageMap = "asteroid_medium_01ImageMap";
   CollisionPolyList = "-0.466 -0.796 0.335 -0.152 0.602 0.496 0.136 0.761 -0.320 -0.005";
};

datablock AsteroidDatablock(asteroidMedium_02 : AsteroidBase_Medium) 
{  
   imageMap = "asteroid_medium_02ImageMap";
   CollisionPolyList = "-0.199 -0.904 0.608 -0.412 0.461 0.231 0.031 0.825 -0.749 0.044";
};

datablock AsteroidDatablock(asteroidMedium_03 : AsteroidBase_Medium) 
{  
   imageMap = "asteroid_medium_03ImageMap";
   CollisionPolyList = "-0.744 -0.707 0.801 -0.079 0.173 0.648 -0.367 0.422";
};

datablock AsteroidDatablock(asteroidMedium_04 : AsteroidBase_Medium) 
{  
   imageMap = "asteroid_medium_04ImageMap";
   CollisionPolyList = "-0.194 -0.854 0.571 -0.167 -0.089 0.717 -0.702 0.059";
};


////////////////////////////////////////
// Larges //////////////////////////////
////////////////////////////////////////
datablock AsteroidDatablock(AsteroidBase_Large : AsteroidBase) 
{
   size = "128 128";
   explosionScale = 1;   
   maxHealth = 30;
   maxAngularVelocity = 45;  
   
   wispChance = 0.08;
   
   resourceChance    = 0.4;
   resourceMaxValue  = 199;   //Max resource value the prop can spawn. so we do not get big things popping out of small things. 

   subPropChance   = 0.50;
   subPropList     = "asteroidMedium_01 10 asteroidMedium_02 10 asteroidMedium_03 10 asteroidMedium_04 10 asteroidSmall_01 20";
   SubPropCount    = "1 3";
   
   objectLayer = $LAYER_ASTEROIDS_LARGE;
};


datablock AsteroidDatablock(asteroidLarge_01 : AsteroidBase_Large) 
{  
   imageMap = "asteroid_large_01ImageMap";
   CollisionPolyList = "-0.424 -0.334 0.293 -0.653 0.361 0.614 -0.168 0.727";  
};

datablock AsteroidDatablock(asteroidLarge_02 : AsteroidBase_Large) 
{  
   imageMap = "asteroid_large_02ImageMap";
   CollisionPolyList = "-0.309 -0.707 0.320 -0.349 0.461 0.467 -0.178 0.501";   
};

datablock AsteroidDatablock(asteroidLarge_03 : AsteroidBase_Large) 
{  
   imageMap = "asteroid_large_03ImageMap";
   CollisionPolyList = "-0.718 -0.702 0.623 -0.535 0.602 0.643 -0.005 0.579";
};

datablock AsteroidDatablock(asteroidLarge_04 : AsteroidBase_Large) 
{  
   imageMap = "asteroid_large_04ImageMap";
   CollisionPolyList = "-0.660 -0.707 0.461 -0.633 0.529 0.619 -0.440 0.354";
};



////////////////////////////////////////
// Crystal Rocks ///////////////////////
////////////////////////////////////////
datablock AsteroidDatablock(AsteroidBase_Crystal : AsteroidBase) 
{
   size = "256 256";
   explosionScale = 2.2;   
   maxHealth = 120;
   maxAngularVelocity = 15;  
   
   wispChance = 0.1;
   wispCount = "2 5";
   wispDatablocks = "CorrosiveWisp";  //does a get random word
   
   resourceChance    = 0.3;
   resourceMaxValue  = 24;   //Max resource value the prop can spawn. so we do not get big things popping out of small things. 

   subPropChance   = 1;
   subPropList     = "asteroidZombie_Small_01 10 10 asteroid_Medium_01 5 asteroidZombie_Medium_02 5 asteroidZombie_Medium_03 5 asteroidZombie_Medium_04 5";
   SubPropCount    = "1 3";
   
   objectClass = "CrystalRockClass";
   
   objectLayer = $LAYER_ASTEROIDS_HUGE;
   
   allowSceneWindowBlend = false;  //want to see crystal roids 
   
   dampenVel = 0.4; //slow you down a bit //using im missions sometimes
};

datablock AsteroidDatablock(asteroid_Alien_Crystal : AsteroidBase_Crystal) 
{     
   imageMap = "asteroid_huge_01ImageMap";   
   CollisionPolyList = "-0.513 -0.658 0.560 -0.648 0.770 -0.128 0.330 0.791 -0.230 0.776 -0.707 -0.128";
   LinkPoints = "-0.010 -0.717 -0.372 0.467 0.749 -0.133 -0.712 -0.152 0.183 0.796";
   
   canSpawnEggs = true;
   eggChance = 0.6;
};

datablock AsteroidDatablock(asteroid_Alien_Crystal_2 : AsteroidBase_Crystal) 
{     
   imageMap = "asteroid_huge_02ImageMap";   
   CollisionPolyList = "-0.435 -0.471 0.550 -0.575 0.456 0.280 -0.634 0.648";
   LinkPoints = "-0.367 -0.079 -0.131 -0.599 0.534 -0.629 0.529 0.147 -0.623 0.624";
   
   canSpawnEggs = true;
   eggChance = 0.6;
};

datablock AsteroidDatablock(asteroid_Alien_Crystal_01_hard : asteroid_Alien_Crystal) 
{  
   imageMap = "asteroid_huge_01_hardImageMap";
   heatRate = 0.003; 
   maxHealth = 600;
   eggChance = 1;
};
datablock AsteroidDatablock(asteroid_Alien_Crystal_02_hard : asteroid_Alien_Crystal_2) 
{  
   imageMap = "asteroid_huge_02_hardImageMap"; 
   heatRate = 0.003;    
   maxHealth = 600;
   eggChance = 1;
};

////////////////////////////////////////
// AutoDriller
////////////////////////////////////////

datablock AsteroidDatablock(AsteroidBase_AutoDriller : AsteroidBase) 
{
   size = "256 256";
   explosionScale = 1.4;   
   maxHealth = 60;
   maxAngularVelocity = 15;  
   
   wispChance = 0.1;
   wispCount = "2 5";
   wispDatablocks = "CorrosiveWisp";  //does a get random word
   
   resourceChance    = 0.3;
   resourceMaxValue  = 24;   //Max resource value the prop can spawn. so we do not get big things popping out of small things. 

   subPropChance   = 1;
   subPropList     = "asteroidSmall_01 10 asteroidMedium_01 2 asteroidMedium_02 2";
   SubPropCount    = "1 3";
   
   objectClass = "AutoDrillRockClass";
   
   objectLayer = $LAYER_ASTEROIDS_HUGE;
   
   allowSceneWindowBlend = false;  //want to see crystal roids 
   
   dampenVel = 0.4; //slow you down a bit //used in missions
};

datablock AsteroidDatablock(asteroid_AutoDriller_01 : AsteroidBase_AutoDriller) 
{     
   imageMap = "asteroid_huge_01ImageMap";   
   CollisionPolyList = "-0.513 -0.658 0.560 -0.648 0.770 -0.128 0.330 0.791 -0.230 0.776 -0.707 -0.128";
   LinkPoints = "-0.010 -0.717 -0.372 0.467 0.749 -0.133 -0.712 -0.152 0.183 0.796";
};

datablock AsteroidDatablock(asteroid_AutoDriller_02 : AsteroidBase_AutoDriller) 
{     
   imageMap = "asteroid_huge_02ImageMap";   
   CollisionPolyList = "-0.435 -0.471 0.550 -0.575 0.456 0.280 -0.634 0.648";
   LinkPoints = "-0.367 -0.079 -0.131 -0.599 0.534 -0.629 0.529 0.147 -0.623 0.624";
};

///////////////////////////////////////////////
// MotherRock /////////////////////////////////
///////////////////////////////////////////////
datablock AsteroidDatablock(AsteroidBase_Mother : AsteroidBase) 
{
   size = "512 512";   
   maxAngularVelocity = 10;  
   
   explosionScale            = 1;   //hide rocks comming off
   
   maxHealth = 10000;  //prevent beam penetration
   
   resourceChance  = 0.3;
   SubPropChance   = 1;
   SubPropList     = "asteroidLarge_01 10 asteroidLarge_02 10 asteroidLarge_03 10 asteroidLarge_04 10 asteroidMedium_01 10 asteroidMedium_02 10 asteroidMedium_03 10 asteroidMedium_04 10";
   SubPropCount    = "1 2";
      
   objectClass = "MotherRockClass";
   
   objectLayer = $LAYER_MOTHERROCK;
   objectGraphGroup = $COLLISION_ID_MOTHER_ROCK;
   
   isInvincible = true;
   
   explosiveFlash = false;
};


datablock AsteroidDatablock(asteroidMother_01 : AsteroidBase_Mother) 
{     
   imageMap = "asteroid_mother_01ImageMap";   
   CollisionPolyList = "-0.560 -0.550 0.414 -0.457 0.639 0.403 -0.571 0.167";
};

///////////////////////////////////////////////
// COMETS
///////////////////////////////////////////////

datablock AsteroidDatablock(AsteroidBase_Comet : AsteroidBase) 
{
   size = "512 512";   
   maxAngularVelocity = 20;  
   
   explosionScale            = 1;   //hide rocks comming off
   
   bornToDie = false;
   minLifeSpan = 45000; 
   ignoreAutoBlending = true;
   
   explosionDamageStrength = 200;
   explosionDamageRadius     = 400;
   
   explosionDatablock = "AsteroidExplosion_crystal";
   
   resourceChance  = 1;
   SubPropChance   = 1;
   SubPropList     = "asteroidLarge_01 10 asteroidLarge_02 10 asteroidLarge_03 10 asteroidLarge_04 10 asteroidMedium_01 10 asteroidMedium_02 10 asteroidMedium_03 10 asteroidMedium_04 10";
   SubPropCount    = "10 12";
};


datablock AsteroidDatablock(asteroidComet_01 : AsteroidBase_Comet) 
{   
   size = "64 64";     
   imageMap = "comet_smallImageMap";
   CollisionPolyList = "-0.424 -0.334 0.293 -0.653 0.361 0.614 -0.168 0.727";  
   SubPropCount    = "1 2";
   SubPropList     = "asteroidSmall_01 10";
   mountedEffect = "SmallCometTail";
   explosionScale            = 1;
   maxAngularVelocity = 50; 
   
   datacubeChance    = 1;   
   datacubeMaxValue  = 99;
   
   resourceMaxValue  = 99; 
};

datablock AsteroidDatablock(asteroidComet_massive_01 : AsteroidBase_Comet) 
{    
   imageMap = "comet_huge_01ImageMap";   
   explosionSound            = "snd_cometExplosion";   
   CollisionPolyList = "-0.639 -0.550 0.016 -0.638 0.560 -0.349 0.739 0.358 0.508 0.619 -0.272 0.525 -0.639 0.192";
   mountedEffect = "MassiveCometTail";
   SubPropList     = "asteroidComet_01 10";
   SubPropCount    = "4 5";
   subPropImpulse = 200;
   explosionDatablock = "CometExplosion";
   explosionScale            = 1;
   explosionDamageStrength = 400;
   explosionDamageRadius     = 800;
   
   datacubeChance    = 1;   
   datacubeMaxValue  = 499;
   
   resourceMaxValue  = 499; 
};

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Growth Props ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////
// Crystals ///////////////
///////////////////////////

//Looks like setting class on a datablock doesnt work for script side inheritance.  this isnt called.
/*
function CrystalDatablock::OnAdd(%this)
{
   Parent::OnAdd(%this);
   
   if ( !isObject($CrystalPropDatabase) )
      $CrystalPropDatabase = new SimSet() {};
      
   if ( %this.imageMap $= "" )
      return;   //this is a base class
   
   $CrystalPropDatabase.add(%this);   //so we can randomly spawn and test them.
}
*/

datablock SpacePropDatablock(Prop_BaseCrystal : SpacePropBase) 
{  
   class = "CrystalDatablock";
   size = "128 128";  
   CollisionPolyList = "-0.372 -0.761 0.430 -0.746 0.576 0.712 -0.466 0.697";
   
   explosionDatablock = "AsteroidExplosion_crystal";
   explosionScale = 1;
   
   resourceChance  = 0.8;
   
   objectGraphGroup = $COLLISION_ID_CRYSTALS;   
   objectLayer = $LAYER_ASTEROIDS_HUGE;
   
   objectClass = "CrystalClass";
   pulseBlend = "1 1 1 0.65"; 
   isCrystal = true;
   
   allowSceneWindowBlend = false;  //want to see crystals 
};


datablock SpacePropDatablock(Prop_Crystal_Red : Prop_BaseCrystal) 
{  
   imageMap = "asteroid_zombieGrowth_01Imagemap";  //define each time in case we ever want different images.  is also a signal to the system that this is not a base class. 
   blend = "1 0.3 0.3 1";
   resourceMaxValue  = 4;
};

datablock SpacePropDatablock(Prop_Crystal_Orange : Prop_BaseCrystal) 
{  
   imageMap = "asteroid_zombieGrowth_05Imagemap";   
   blend = "1 0.6 0.15 1";
   resourceMaxValue  = 12;
};


datablock SpacePropDatablock(Prop_Crystal_Yellow : Prop_BaseCrystal) 
{  
   imageMap = "asteroid_zombieGrowth_02Imagemap";   
   blend = "1 1 0.3 1";
   resourceMaxValue  = 24;
};

datablock SpacePropDatablock(Prop_Crystal_Green : Prop_BaseCrystal) 
{  
   imageMap = "asteroid_zombieGrowth_03Imagemap";   
   blend = "0.3 1 0.3 1";
   resourceMaxValue  = 49;
};

datablock SpacePropDatablock(Prop_Crystal_Blue : Prop_BaseCrystal) 
{  
   imageMap = "asteroid_zombieGrowth_04Imagemap";   
   blend = "0.3 0.3 1 1";
   resourceMaxValue  = 99;
};

datablock SpacePropDatablock(Prop_Crystal_Purple : Prop_BaseCrystal) 
{  
   imageMap = "asteroid_zombieGrowth_05Imagemap";   
   blend = "1 0.3 1 1";
   resourceMaxValue  = 249;
};

//autoDrill

datablock SpacePropDatablock(Prop_AutoDrill : SpacePropBase) 
{  
   //class = "CrystalDatablock";
   size = "128 128";  
   CollisionPolyList = "-0.267 -0.894 0.351 -0.894 0.466 0.609 0.037 0.756 -0.361 0.545";
   imageMap = "asteroid_autoDrillImageMap";    
   explosionDatablock = "BigExplosion";
   explosionScale = 1;
   
   resourceChance  = 0.8;
   
   objectGraphGroup = $COLLISION_ID_CRYSTALS;   
   objectLayer = $LAYER_ASTEROIDS_HUGE;
   
   pulseBlend = "1 1 1 1"; 
   isCrystal = false;
   
   ignoreAutoBlending = false;
   allowSceneWindowBlend = true; 
   
   mountedEffect = "HullSmoke";
};

/////////////////////////////////////////////////////////
// zombie asteroids
/////////////////////////////////////////////////////////

datablock AsteroidDatablock(AsteroidBase_Zombie : AsteroidBase) 
{
   explosionDatablock        = "Zombie_AsteroidExplosion";
   size = "64 64";
   explosionScale = 0.5;   
   maxHealth = 10;
   maxAngularVelocity = 90;  
   
   wispChance = 0.04;
   
   resourceChance    = 0.5;
   resourceMaxValue  = 99;   //Max resource value the prop can spawn. so we do not get big things popping out of small things. 
   
   //The array indexes are infection levels. 
   zombieBurstImpulse = 50; //larger objects with more zombies probably want higher impulse. 
   zombieBurstSound  = "snd_eggHatchSmall"; //acts as a cue that zombies spawned
   zombieBurstDebris = "DC_Combat_Small_Light_Zombie"; //do not need to define if dont want
   zombieBurstDebrisMult = 1; //how many copies of the burst debris to create.
   zombieBurstEffect = "zombieEggHatchSmall"; //do not need to define if dont want
   zombieBurstEffectScale = 0.500;   //must define if effect is defined.
   
   zombieChance[0]   = 0.750;
   zombieMaxCount[0] = 1;
   
   zombieChance[1]   = 0.750;
   zombieMaxCount[1] = 3;
   
   zombieChance[2]   = 0.750;
   zombieMaxCount[2] = 5;
   
   zombieChance[3]   = 0.750;
   zombieMaxCount[3] = 8;
   //Note: probably good to give these asteroids more rez and the larger ones have more zombies
   //this is just a working example of the datastructure. 
     
   objectLayer = $LAYER_ASTEROIDS_MEDIUM;
   
   dampenVel = 0.1; //slow you down a bit a tiny big .. used in missions
   
   //allowSceneWindowBlend = false;  //let these blend or look too much like eggs.
};

datablock AsteroidDatablock(asteroidZombie_Small_01 : AsteroidBase_Zombie) 
{  
   explosionScale = 0.35;   
   size = "32 32";   
   imageMap = "asteroid_zombie_small_01ImageMap";   
   CollisionPolyList = "-0.623 -0.766 0.498 -0.589 0.398 0.678 -0.660 0.285";
};
datablock AsteroidDatablock(asteroidZombie_Small_02 : AsteroidBase_Zombie) 
{   
   explosionScale = 0.35;   
   size = "32 32";
   imageMap = "asteroid_zombie_small_02ImageMap";   
   CollisionPolyList = "-0.765 -0.638 0.592 -0.403 0.330 0.683 -0.414 0.412";
};
datablock AsteroidDatablock(asteroidZombie_Medium_01 : AsteroidBase_Zombie) 
{    
   imageMap = "asteroid_zombie_medium_01ImageMap";   
   CollisionPolyList = "-0.545 -0.550 0.293 -0.840 0.534 0.265 0.272 0.879 -0.257 0.796";
};
datablock AsteroidDatablock(asteroidZombie_Medium_02 : AsteroidBase_Zombie) 
{     
   imageMap = "asteroid_zombie_medium_02ImageMap";   
   CollisionPolyList = "-0.440 -0.756 0.550 0.476 0.094 0.653";
};
datablock AsteroidDatablock(asteroidZombie_Medium_03 : AsteroidBase_Zombie) 
{     
   imageMap = "asteroid_zombie_medium_03ImageMap";   
   CollisionPolyList = "-0.419 -0.756 0.435 -0.300 0.534 0.481 0.173 0.766 -0.581 0.486 -0.765 -0.118";
};
datablock AsteroidDatablock(asteroidZombie_Medium_04 : AsteroidBase_Zombie) 
{     
   imageMap = "asteroid_zombie_medium_04ImageMap";   
   CollisionPolyList = "-0.665 -0.766 0.210 -0.751 0.712 0.300 0.335 0.673 -0.707 0.280";
};

