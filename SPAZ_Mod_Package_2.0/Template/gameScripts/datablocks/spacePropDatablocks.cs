////////////////////////////////////////////////////////////////////////////////
//SPACE PROPS
////////////////////////////////////////////////////////////////////////////////

function SpacePropDatablock::OnAdd(%this)
{
   if ( !isObject($SpacePropDatabase) )
      $SpacePropDatabase = new SimSet() {};
      
   if ( %this.imageMap $= "" )
      return;   //this is a base class
   
   $SpacePropDatabase.add(%this);   //so we can randomly spawn and test them.
   
   %this.subPropList = createEfficientWeightedList(%this.subPropList);
}


/////////////////////////////
// Base Class ///////////////
/////////////////////////////

datablock SpacePropDatablock(SpacePropBase) 
{
   imageMapList = "";   // Can define multiple image maps for a prop in here.  Like with pickups
   
   explosionDatablock        = "AsteroidExplosion";
   explosionSound            = "snd_mediumExplosion";
   explosionScale            = 1;   
   explosionDamageType       = "Explosive";
   explosionDamageStrength   = 0;
   explosionDamageRadius     = 200;
   
   explosiveFlash = true;
   
   maxHealth = 10;
   propMass  = 10;     
   
   minLifeSpan = 10000; 
   bornToDie = false;   //this means when the thing spawns it counts down to death
   
   spawnFaction = "";
   
   subPropChance  = 0;
   subPropCount   = "1 3";       //GetRandomFromPair can be just a single number too
   subPropList    = "";         //weighted list of SpacePropDatablocks. can be single value
   subPropImpulse = 50;
     
   resourceChance      = 0;
   resourceMaxValue    = 0;   //Max resource value the prop can spawn. so we do not get big things popping out of small things. 
   resourceMaxToSpawn  = 2;
         
   dataFixedValue = "";  
   datacubeChance      = 0;   
   datacubeMaxValue    = 0; 
   datacubeMaxToSpawn  = 2; 
   dataSpawnCheck = ""; //a function you can call to check for drop or not ... used to prevent exploits
   
   goonPodDatablock = "EscapePod_Small";
   goonFactionList = "Civ 10";
   goonValueRange = "1 2";
   goonChance = 0;
            
   maxAngularVelocity = 40;  //getrandom (-maxAngularVelocity, maxAngularVelocity)
   
   dampenVel = "";
      
   objectClass = "";
   objectSuperClass = "";    //if superclass is "AsteroidClass", that class will be created code side.  
  
   objectLayer = $LAYER_DEBRIS;
   objectGraphGroup = $COLLISION_ID_BARRELS;
   
   wispChance = 0;
   wispCount = "1 2";  //GetRandomFromPair can be just a single number too
   wispDatablocks = "ExplosiveWisp";  //does a get random word
   
   canSpawnEggs = false;
   eggChance = 0;
      
   isCloaked = false;
   cloakDisruptionTime = 2; 
   
   allowSceneWindowBlend = true;
   
   cloakFaction = ""; //cloaked props need a faction
};


   
   
//////////////////////
//exploding barrels //
//////////////////////
datablock SpacePropDatablock(Prop_BarrelBase : SpacePropBase) 
{
   objectGraphGroup    = $COLLISION_ID_BARRELS;   
   explosionDatablock  = "MediumExplosion";
   maxHealth = 0.2;   //easy to pop
   CollisionPolyList = "-0.450 -0.908 0.445 -0.908 0.461 0.987 -0.440 0.977";
   size = "32 32"; 
   
   allowSceneWindowBlend = false; //want to see barrels
};

datablock SpacePropDatablock(Prop_ExplodingBarrel_01 : Prop_BarrelBase) 
{
   imageMap = "crate_barrel_01ImageMap";
   explosionDamageType       = "Explosive";
   explosionScale          = 0.5;    
   explosionDamageStrength = 200;   
   explosionDamageRadius   = 400;
};

datablock SpacePropDatablock(Prop_ExplodingBarrel_lite_01 : Prop_BarrelBase) 
{
   imageMap = "crate_barrel_lite01ImageMap";
   explosionDamageType       = "Explosive";
   explosionScale          = 0.4;    
   explosionDamageStrength = 120;   
   explosionDamageRadius   = 400;
};

datablock SpacePropDatablock(Prop_EMPBarrel_01 : Prop_BarrelBase) 
{
   imageMap = "crate_empbarrel_01ImageMap"; 
   explosionScale          = 0.5;    
     
   explosionDamageType       = "Ion";
   
   //Instant is better here. 
   //wispChance = 0.6;
   //wispCount = "1";  
   //wispDatablocks = "IonWisp";
   
   explosionDamageStrength = 100;   
   explosionDamageRadius   = 400;
};
datablock SpacePropDatablock(Prop_AcidBarrel_01 : Prop_BarrelBase) 
{
   imageMap = "crate_acidbarrel_01ImageMap"; 
   explosionScale          = 0.5;    
   explosionDamageStrength = 50; //tiny explosiong, but releases wisp
   
   explosionDamageType       = "Corrosive";
   
   wispChance = 1;  //wisp chance must be 1
   wispCount = "1";  
   wispDatablocks = "CorrosiveWisp"; 
   
   explosionDamageStrength = 100;   
   explosionDamageRadius   = 400;
};

datablock SpacePropDatablock(Prop_BarrelHolder_01 : Prop_BarrelBase) 
{
   explosionDatablock  = "MetalExplosion";
   
   imageMap = "crate_barrel_huge_01ImageMap";
   CollisionPolyList = "-0.450 -0.908 0.445 -0.908 0.461 0.987 -0.440 0.977";
   size = "128 128";
   
   explosionDamageType       = "Explosive";
   
   maxHealth = 1; 
   explosionDamageStrength = 400;
   explosionDamageRadius   = 600;
   explosionScale          = 1;
   
   subPropChance = 1;
   SubPropCount = "4 8";
   subPropList = "Prop_ExplodingBarrel_01";
   subPropImpulse = 250;  
};
datablock SpacePropDatablock(Prop_EMPBarrelHolder_01 : Prop_BarrelHolder_01) 
{
   imageMap = "crate_empbarrel_huge_01ImageMap";
   subPropList = "Prop_EMPBarrel_01";
   explosionDamageType       = "Ion";
   explosionDamageStrength = 200;   
   explosionDamageRadius   = 600;
};
datablock SpacePropDatablock(Prop_AcidBarrelHolder_01 : Prop_BarrelHolder_01) 
{
   imageMap = "crate_acidbarrel_huge_01ImageMap";
   subPropList = "Prop_AcidBarrel_01";
   explosionDamageType       = "Corrosive";
   
   wispChance = 1;
   wispCount = "2";  
   wispDatablocks = "CorrosiveWisp"; 
   
   explosionDamageStrength = 100;   
   explosionDamageRadius   = 600;   
};

////////////////////////////
// Resource Crates /////////
////////////////////////////
datablock SpacePropDatablock(Prop_CrateBase : SpacePropBase) 
{
   objectGraphGroup = $COLLISION_ID_CRATES; 
   explosionDatablock  = "MetalExplosion";  
   
   allowSceneWindowBlend = false;  //want to see crates 
};


datablock SpacePropDatablock(Prop_SmallCrate_01 : Prop_CrateBase) 
{
   imageMap = "crate_wooden_01ImageMap";
   CollisionPolyList = "-0.414 -0.859 0.388 -0.530 0.430 0.732 -0.634 0.481";
   size = "32 32";
   
   maxHealth = 0.2;
   
   explosionSound = "snd_smallExplosion";
   explosionScale = 0.5;
   
   resourceChance    = 0.5;
   resourceMaxValue  = 24;
};

datablock SpacePropDatablock(Prop_SmallCrate_01_zom : Prop_SmallCrate_01) 
{
   imageMap = "crate_wooden_zom_01ImageMap";
   explosionDatablock  = "MetalFleshExplosion";   
   zombieChance[0]   = 0.333;
   zombieMaxCount[0] = 1;
   
   zombieChance[1]   = 0.50;
   zombieMaxCount[1] = 2;
   
   zombieChance[2]   = 0.667;
   zombieMaxCount[2] = 3;
   
   zombieChance[3]   = 0.750;
   zombieMaxCount[3] = 4;
};

datablock SpacePropDatablock(Prop_LargeCrate_01 : Prop_CrateBase) 
{
   imageMap = "crate_large_01ImageMap";
   CollisionPolyList = "-0.414 -0.859 0.388 -0.530 0.430 0.732 -0.634 0.481";
   size = "64 64";
   
   maxHealth = 1;
   
   explosionScale = 0.66;
};

datablock SpacePropDatablock(Prop_LargeCrate_01_zom : Prop_LargeCrate_01) 
{
   imageMap = "crate_large_01_zomImageMap";
   explosionDatablock  = "MetalFleshExplosion";  
   zombieChance[0]   = 0.333;
   zombieMaxCount[0] = 2;
   
   zombieChance[1]   = 0.50;
   zombieMaxCount[1] = 3;
   
   zombieChance[2]   = 0.667;
   zombieMaxCount[2] = 4;
   
   zombieChance[3]   = 0.750;
   zombieMaxCount[3] = 6;
};

datablock SpacePropDatablock(Prop_HugeCrate_01 : Prop_CrateBase) 
{
   imageMap = "crate_huge_01ImageMap";
   CollisionPolyList = "-0.262 -0.810 0.267 -0.815 0.707 -0.221 0.697 0.206 0.283 0.810 -0.262 0.791 -0.618 0.206 -0.618 -0.231";
   size = "128 128";
   
   maxHealth = 2;
   
   explosionScale = 1;
   
   subPropChance   = 0.5;
   subPropList     = "Prop_SmallCrate_01 10";
   SubPropCount    = "1 2";   
   
};

datablock SpacePropDatablock(Prop_HugeCrate_01_zom : Prop_HugeCrate_01) 
{
   imageMap = "crate_huge_01_zomImageMap";
   explosionDatablock  = "MetalFleshExplosion";  
   zombieChance[0]   = 0.333;
   zombieMaxCount[0] = 3;
   
   zombieChance[1]   = 0.50;
   zombieMaxCount[1] = 4;
   
   zombieChance[2]   = 0.667;
   zombieMaxCount[2] = 6;
   
   zombieChance[3]   = 0.750;
   zombieMaxCount[3] = 8;
};

datablock SpacePropDatablock(Prop_UTACrate_01 : Prop_CrateBase) //gives out lots of xp, do not over use
{
   imageMap = "crate_UTA_01ImageMap";
   CollisionPolyList = "-0.414 -0.859 0.388 -0.530 0.430 0.732 -0.634 0.481";
   size = "64 64";
   
   maxHealth = 0.4;
   
   dampenVel = 1;
   
   explosionScale = 0.66;
   
   datacubeChance    = 1;   
   datacubeMaxValue  = 5;
};

datablock SpacePropDatablock(Prop_UTACrate_01_zom : Prop_UTACrate_01) //gives out lots of xp, do not over use
{
   imageMap = "crate_UTA_01_zomImageMap";
   explosionDatablock  = "MetalFleshExplosion";  
   zombieChance[0]   = 0.333;
   zombieMaxCount[0] = 1;
   
   zombieChance[1]   = 0.50;
   zombieMaxCount[1] = 2;
   
   zombieChance[2]   = 0.667;
   zombieMaxCount[2] = 3;
   
   zombieChance[3]   = 0.750;
   zombieMaxCount[3] = 4;
};

datablock SpacePropDatablock(Prop_UTACrate_S1 : Prop_UTACrate_01) //gives out lots of xp, do not over use
{
   dataFixedValue = 5; 
   dataSpawnCheck = "S1_Favor1_PropSpawnCheck";
};

datablock SpacePropDatablock(Prop_UTACrate_cloaked_01 : Prop_UTACrate_01)
{
   objectClass = "cloakedSpaceProp";
   cloakFaction = "terran"; //needs faction for cloak to work correctly
   dampenVel = 1;
};

datablock SpacePropDatablock(Prop_UTACrate_cloaked_S4_01 : Prop_UTACrate_cloaked_01)
{
   cloakFaction = "zombie"; //used for sec4 since you can't shoot terran or civ any more
};



//colored crates

datablock SpacePropDatablock(Prop_Crate_Red : Prop_CrateBase) //gives out lots of xp, do not over use
{
   imageMap = "crate_redImageMap";
   size = "16 16";
   
   maxHealth = 0.4;
   explosionScale = 0.66;
 
   datacubeChance    = 0.5;   
   datacubeMaxValue  = 1;  
   resourceChance    = 0.5;
   resourceMaxValue  = 5;     
};
datablock SpacePropDatablock(Prop_Crate_Yellow : Prop_CrateBase) //gives out lots of xp, do not over use
{
   imageMap = "crate_yellowImageMap";
   size = "24 24";
   
   maxHealth = 0.4;
   explosionScale = 0.66;
 
   datacubeChance    = 0.5;   
   datacubeMaxValue  = 2;  
   resourceChance    = 0.5;
   resourceMaxValue  = 10;       
};
datablock SpacePropDatablock(Prop_Crate_Green : Prop_CrateBase) //gives out lots of xp, do not over use
{
   imageMap = "crate_greenImageMap";
   size = "32 32";
   
   maxHealth = 0.4;
   explosionScale = 0.66;
 
   datacubeChance    = 0.5;   
   datacubeMaxValue  = 3;  
   resourceChance    = 0.5;
   resourceMaxValue  = 15;        
};
datablock SpacePropDatablock(Prop_Crate_Blue : Prop_CrateBase) //gives out lots of xp, do not over use
{
   imageMap = "crate_blueImageMap";
   size = "48 48";
   
   maxHealth = 0.4;
   explosionScale = 0.66;
 
   datacubeChance    = 0.5;   
   datacubeMaxValue  = 4;  
   resourceChance    = 0.5;
   resourceMaxValue  = 20;       
};
datablock SpacePropDatablock(Prop_Crate_Purple : Prop_CrateBase) //gives out lots of xp, do not over use
{
   imageMap = "crate_purpleImageMap";
   size = "64 64";
   
   maxHealth = 0.4;
   explosionScale = 0.66;
   
   datacubeChance    = 0.5;   
   datacubeMaxValue  = 5;  
   resourceChance    = 0.5;
   resourceMaxValue  = 30;     
};

////////////////////////////
// Data Crates /////////////
////////////////////////////
datablock SpacePropDatablock(Prop_ArtifactBase : SpacePropBase) 
{
   objectGraphGroup = $COLLISION_ID_ARTIFACTS; 
   explosionDatablock  = "ElectricExplosion";
   
   wispChance = 1;
   wispCount = "2 5";
   
   maxHealth = 120; //strong
   
   allowSceneWindowBlend = false;  //want to seeartifacts 
   
   dampenVel = 0.4; //slow you down a bit
};

datablock SpacePropDatablock(Prop_ArtifactCrate_01 : Prop_ArtifactBase) 
{
   imageMap = "crate_artifact_01ImageMap";
   CollisionPolyList = "-0.414 -0.859 0.388 -0.530 0.430 0.732 -0.634 0.481"; 
   size = "64 64";
   
   explosionScale = 0.5;
   
   datacubeChance    = 1;   
   datacubeMaxValue  = 50;  
};

datablock SpacePropDatablock(Prop_ArtifactCrate_01_zom : Prop_ArtifactCrate_01) 
{
   imageMap = "crate_artifact_01_zomImageMap";
   zombieChance[0]   = 0.333;
   zombieMaxCount[0] = 2;
   
   zombieChance[1]   = 0.50;
   zombieMaxCount[1] = 3;
   
   zombieChance[2]   = 0.667;
   zombieMaxCount[2] = 4;
   
   zombieChance[3]   = 0.750;
   zombieMaxCount[3] = 6;
};

///////////////////////////////////
//cloak generator
////////////////////////////////////

datablock SpacePropDatablock(Prop_CloakGenerator : SpacePropBase) 
{
   imageMap = "cloakGeneratorImageMap";
   CollisionPolyList = "-0.503 -0.633 0.492 -0.643 0.618 0.624 -0.566 0.638";
   
   objectClass = "CloakGenPropClass";
     
   size = "128 256";     
     
   explosionScale          = 1.4;    
   explosionDamageStrength = 300; 
   explosionDamageRadius   = 600;
   
   maxHealth = 1500;     
   
   objectGraphGroup = $COLLISION_ID_CRATES; 
   explosionDatablock  = "BigExplosion";  
   
   allowSceneWindowBlend = false;  //want to see crates 
   
   dampenVel = 2;
};

function CloakGenPropClass::onAddToScene(%this)
{
   Parent::onAddToScene(%this, $theSceneGraph);  
   %glowObject = new t2dStaticSprite()
   {
      scenegraph = $thescenegraph; 
      size = "128 256";
      imageMap = "cloakGenerator_GlowImageMap";
      layer = %this.layer;  
      position = %this.position;
   };
   %glowObject.mount(%this, "0 0", 0, true, true, true, false);  
   %glowObject.SetupPulse(500, "128 256", "128 256", "1 1 0 0.5", "0 1 1 0.8", true);
   %glowObject.StartPulse();
   %glowObject.setBlending(true, SRC_ALPHA, ONE);  //INTENSE    
}

///////////////////////////////////
//alien power gen
////////////////////////////////////



datablock SpacePropDatablock(Prop_AlienPowGen : SpacePropBase) 
{
   imageMap = "alienPowGenImageMap";
   CollisionPolyList = "-0.471 -0.437 0.471 -0.442 0.461 0.491 -0.492 0.491";
   
   objectClass = "AlienGenPropClass";
   
   spawnFaction = "pirate";
     
   size = "256 256";     
     
   explosionScale          = 1.4;    
   explosionDamageStrength = 300; 
   explosionDamageRadius   = 600;
   
   maxHealth = 7500;     
   
   objectGraphGroup = $COLLISION_ID_CRATES; 
   explosionDatablock  = "BigExplosion";  
   
   allowSceneWindowBlend = false;  //want to see crates 
   
   dampenVel = 2;
};

function AlienGenPropClass::onAddToScene(%this)
{
   Parent::onAddToScene(%this, $theSceneGraph);  
   %glowObject = new t2dStaticSprite()
   {
      scenegraph = $thescenegraph; 
      size = "128 256";
      imageMap = "effect_puffImageMap";
      layer = %this.layer;  
      position = %this.position;
   };
   %glowObject.mount(%this, "0 0", 0, true, true, true, false);  
   %glowObject.SetupPulse(300, "128 128", "64 64", "1 1 1 1", "1 1 1 1", true);
   %glowObject.StartPulse();
   %glowObject.setBlending(true, SRC_ALPHA, ONE);  //INTENSE    
}


///////////////////////////////////
//carls fake ship
////////////////////////////////////

datablock SpacePropDatablock(Prop_CarlsFakeShip : SpacePropBase) 
{
   imageMap = "carlsFakeShipPropImageMap";
   CollisionPolyList = "-0.529 -0.579 0.073 -0.766 0.597 -0.673 0.686 0.427 0.194 0.668 -0.513 0.688 -0.859 -0.025";
     
   size = "256 256";     
     
   explosionScale          = 0.8;    
   explosionDamageStrength = 100; 
   explosionDamageRadius   = 300;
   
   maxHealth = 100;     
   
   objectGraphGroup = $COLLISION_ID_CRATES; 
   explosionDatablock  = "zombieEggHatchLarge";
   explosionSound            = "snd_eggHatchHuge"; 
   
   dampenVel = 10; //don't you move
   
   allowSceneWindowBlend = false;  //want to see crates 
};

///////////////////////////////////
//goon crates
////////////////////////////////////

datablock SpacePropDatablock(Prop_goonCrateBase : SpacePropBase) 
{
   objectGraphGroup = $COLLISION_ID_CRATES; 
   explosionDatablock  = "MetalExplosion";  
   allowSceneWindowBlend = false;  //want to see crates 
};

datablock SpacePropDatablock(Prop_goonCrate_small : Prop_goonCrateBase) 
{
   imageMap = "crate_pod_smallImageMap";
   CollisionPolyList = "-0.466 -0.962 0.419 -0.972 0.424 0.982 -0.487 0.982";
     
   size = "48 48";     
   explosionScale          = 0.5;    
   maxHealth = 5;     
   goonFlightTime = 100;
   
   goonPodDatablock = "EscapePod_Small";
   goonFactionList = "Civ 10 Terran 10 Pirate 3";
   goonValueRange = "3 5";
   goonChance = 1;
};



datablock SpacePropDatablock(Prop_goonCrate_small_zom : Prop_goonCrate_small) 
{
   imageMap = "crate_pod_zombie_smallImageMap"; 
   explosionDatablock  = "MetalFleshExplosion";   
   zombieChance[0]   = 0.333;
   zombieMaxCount[0] = 1;
   
   zombieChance[1]   = 0.50;
   zombieMaxCount[1] = 2;
   
   zombieChance[2]   = 0.667;
   zombieMaxCount[2] = 3;
   
   zombieChance[3]   = 0.750;
   zombieMaxCount[3] = 4;
};


datablock SpacePropDatablock(Prop_goonCrate_large : Prop_goonCrateBase) 
{
   imageMap = "crate_pod_largeImageMap";
   CollisionPolyList = "-0.487 -0.830 0.524 -0.835 0.513 0.830 -0.540 0.791";
     
   size = "96 96";      
   explosionScale          = 0.8;    
   maxHealth = 20;     
   goonFlightTime = 250;
   
   goonPodDatablock = "EscapePod_Large";
   goonFactionList = "Civ 10 Terran 10 Pirate 3";
   goonValueRange = "2 2";
   goonChance = 1;
};

datablock SpacePropDatablock(Prop_goonCrate_large_zom : Prop_goonCrate_large) 
{
   imageMap = "crate_pod_zombie_largeImageMap"; 
   explosionDatablock  = "MetalFleshExplosion";  
   zombieChance[0]   = 0.333;
   zombieMaxCount[0] = 2;
   
   zombieChance[1]   = 0.50;
   zombieMaxCount[1] = 3;
   
   zombieChance[2]   = 0.667;
   zombieMaxCount[2] = 4;
   
   zombieChance[3]   = 0.750;
   zombieMaxCount[3] = 6;
};


///////////////////////////////////
//spammer radar
////////////////////////////////////

datablock SpacePropDatablock(Prop_SpammerRadar : SpacePropBase) 
{
   imageMap = "crate_spammerImageMap";
   CollisionPolyList = "-0.723 -0.025 -0.445 -0.506 0.021 -0.673 0.503 -0.442 0.697 -0.010 0.524 0.467 0.010 0.712 -0.471 0.442";
     
   size = "128 128";     
     
   explosionScale          = 1.4;    
   explosionDamageStrength = 200; 
   explosionDamageRadius   = 450;
   
   maxHealth = 80;     
   
   objectGraphGroup = $COLLISION_ID_CRATES; 
   explosionDatablock  = "BigExplosion";  
   
   dampenVel = 10; //don't you move
   
   allowSceneWindowBlend = false;  //want to see crates 
};

///////////////////////////////////
//zombie spec prop
////////////////////////////////////

datablock SpacePropDatablock(Prop_SpecPod_Zombie : SpacePropBase) 
{
   imageMap = "specPod_zombieImageMap";
   CollisionPolyList = "-0.278 -0.805 0.262 -0.683 0.555 0.280 0.409 0.850 -0.330 0.717 -0.697 0.039";
   
   objectSuperClass = "SpecPod_Zombie_Class";
     
   size = "48 48";     
   
   maxHealth = 30;     
   
   objectGraphGroup = $COLLISION_ID_CRATES; 
   explosionDatablock = "Zombie_AsteroidExplosion";
   explosionSound            = "snd_asteroidExplosion";
   explosionScale          = 0.7;    
   
   dampenVel = 1; //don't you move
   
   allowSceneWindowBlend = false;  //want to see crates 
};

//////////////////////////////////////////////////////////
// SPINNERS //////////////////////////////////////////////
//////////////////////////////////////////////////////////


datablock SpacePropDatablock(Prop_WeaponSpinnerBase : SpacePropBase) 
{
   objectSuperClass = "WeaponSpinner";
   
   objectGraphGroup    = $COLLISION_ID_BARRELS;  //Gets a faction, so this doesnt matter really.
   explosionDatablock  = "MediumExplosion";
   
   maxHealth = 30;   
   CollisionPolyList = "0.021 -0.997 0.665 -0.275 0.990 0.663 0.016 0.958 -0.964 0.673 -0.655 -0.221";
   LinkPoints = "0.016 -0.992 0.969 0.673 -0.948 0.673";

   size = "64 64"; 
   
   minLifeSpan = 15000; 
   bornToDie = true;
   
   imageMap = "SpinnerTrap_OneImageMap"; 
   explosionScale          = 0.5;    
     
   explosionDamageType       = "Ion";       
   explosionDamageStrength = 100;   
   explosionDamageRadius   = 200;
   
   allowSceneWindowBlend = false; 
   
   mountedEffect = "RedLight";
   dampenVel = 0.333;
   
   maxAngularVelocity = 60;
         
};

// 2 SPINNER ///////////////////////////////////////////

datablock SpacePropDatablock(Prop_WeaponSpinnerBase_2 : Prop_WeaponSpinnerBase) 
{
   minLifeSpan = 10000; 
   maxAngularVelocity = 360;
   explosionDamageStrength = 100;  
   maxHealth = 30;   
   imageMap = "SpinnerTrap_OneImageMap"; 
   CollisionPolyList = "-0.168 -0.982 0.110 -0.982 0.094 0.928 -0.147 0.928";
   LinkPoints = "-0.010 -0.997 -0.021 0.943";
};

datablock SpacePropDatablock(Spinner_2_cannon : Prop_WeaponSpinnerBase_2) 
{ 
   weaponData[1] = "MediumCannon_rapid 0";
   weaponData[2] = "MediumCannon_rapid 180";
};

datablock SpacePropDatablock(Spinner_2_fusion : Prop_WeaponSpinnerBase_2) 
{ 
   weaponData[1] = "MediumEmitter_Heavy 0";
   weaponData[2] = "MediumEmitter_Heavy 180";
};

datablock SpacePropDatablock(Spinner_2_ion : Prop_WeaponSpinnerBase_2) 
{ 
   weaponData[1] = "MediumEmitter_ION 0";
   weaponData[2] = "MediumEmitter_ION 180";
};

// 3 SPINNER ///////////////////////////////////////////

datablock SpacePropDatablock(Prop_WeaponSpinnerBase_3 : Prop_WeaponSpinnerBase) 
{
   minLifeSpan = 15000; 
   maxAngularVelocity = 240;
   explosionDamageStrength = 200; 
   maxHealth = 50;    
   imageMap = "SpinnerTrap_ThreeImageMap"; 
   CollisionPolyList = "0.021 -0.997 0.665 -0.275 0.990 0.663 0.016 0.958 -0.964 0.673 -0.655 -0.221";
   LinkPoints = "0.016 -0.992 0.969 0.673 -0.948 0.673";
};

datablock SpacePropDatablock(Spinner_3_cannon : Prop_WeaponSpinnerBase_3) 
{
   weaponData[1] = "LargeCannon_rapid 0";
   weaponData[2] = "LargeCannon_rapid 120";
   weaponData[3] = "LargeCannon_rapid 240";  
};

datablock SpacePropDatablock(Spinner_3_fusion : Prop_WeaponSpinnerBase_3) 
{
   weaponData[1] = "LargeEmitter_Heavy 0";
   weaponData[2] = "LargeEmitter_Heavy 120";
   weaponData[3] = "LargeEmitter_Heavy 240";  
};

datablock SpacePropDatablock(Spinner_3_ion : Prop_WeaponSpinnerBase_3) 
{
   weaponData[1] = "LargeEmitter_ION 0";
   weaponData[2] = "LargeEmitter_ION 120";
   weaponData[3] = "LargeEmitter_ION 240";  
};

// 5 SPINNER ///////////////////////////////////////////

datablock SpacePropDatablock(Prop_WeaponSpinnerBase_5 : Prop_WeaponSpinnerBase) 
{
   minLifeSpan = 20000; 
   maxAngularVelocity = 120;
   explosionDamageStrength = 300;  
   maxHealth = 80;   
   imageMap = "SpinnerTrap_FiveImageMap"; 
   CollisionPolyList = "-0.959 -0.231 -0.021 -0.982 0.943 -0.187 0.629 0.928 -0.676 0.933";
   LinkPoints = "-0.005 -1.002 0.964 -0.221 0.592 0.923 -0.660 0.923 -0.974 -0.216";

};

datablock SpacePropDatablock(Spinner_5_cannon : Prop_WeaponSpinnerBase_5) 
{   
   weaponData[1] = "HugeCannon_rapid 0";
   weaponData[2] = "HugeCannon_rapid 72";
   weaponData[3] = "HugeCannon_rapid 144";
   weaponData[4] = "HugeCannon_rapid 216";
   weaponData[5] = "HugeCannon_rapid 288";
};

datablock SpacePropDatablock(Spinner_5_fusion : Prop_WeaponSpinnerBase_5) 
{
   weaponData[1] = "HugeEmitter_Heavy 0";
   weaponData[2] = "HugeEmitter_Heavy 72";
   weaponData[3] = "HugeEmitter_Heavy 144";
   weaponData[4] = "HugeEmitter_Heavy 216";
   weaponData[5] = "HugeEmitter_Heavy 288";
};

datablock SpacePropDatablock(Spinner_5_ion : Prop_WeaponSpinnerBase_5) 
{
   weaponData[1] = "HugeEmitter_ION 0";
   weaponData[2] = "HugeEmitter_ION 72";
   weaponData[3] = "HugeEmitter_ION 144";
   weaponData[4] = "HugeEmitter_ION 216";
   weaponData[5] = "HugeEmitter_ION 288";
};



