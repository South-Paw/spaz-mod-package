
//Word COunt of eact doodad hull data element
$Doodad_OffsetX        = 0;
$Doodad_OffsetY        = 1;
$Doodad_Rotation       = 2;
$Doodad_InUnderShip    = 3;
$Doodad_CreationChance = 4;
$Doodad_FirstDatablock = 5;

$Doodad_Effect_Name              = 0;
$Doodad_Effect_OffsetX           = 1;
$Doodad_Effect_OffestY           = 2;
$Doodad_Effect_EmissionRotation  = 3;
$Doodad_Effect_EmissionForce     = 4;
$Doodad_Effect_Scale             = 5;
$Doodad_Effect_MinTime           = 6;
$Doodad_Effect_MaxTime           = 7;


//////////////////////////////////////////////////////
// Doodad Datablocks /////////////////////////////////
//////////////////////////////////////////////////////

datablock t2dSceneObjectDatablock(DoodadBase) 
{
   isDoodadSet = false;
   
   imageMap = "radarImageMap";
   size = "32 32";
    
   shouldSpin = false;               //Note, it will look weird if the doodad rotates slower than the ship in many cases
   randomAngularVelocity = "360 360";  //doodads will randomly spin clockwise or counter clockwise 
   randomScan = true;  //if the doodad should randomly stop spinning to "look" at a spot for a short time like turrets
  
   isIntense = false;       //if we should use intense rendering for the doodad. (flicker will override this)
   doodadBlend = "1 1 1 1"; //color we will apply to the doodad.
   
   shouldFlicker = false;  
   shouldRandomizeStates = true;  //if not random, will cycle between states
      
   shouldPulse = false;  //dont use flicker and pulse together. will do weird stuff
   pulseTime    = 1000;
   pulseSizeMin = "32 32";
   pulseSizeMax = "48 64";
   pulseBlendMin = "1 1 1 1";
   pulseBlendMax = "0.5 0.5 0 0.5";
   pulseLinear = false;  //use a sin wave pulse
  
   //Scroller Stuff (the pulse and angular velocity are still valid to use)
   isScroller = false;  //if this is true, we will create a sroller object instead of a t2dstaticsprite
   repeatX = "6";
   repeatY = "10";
   scrollX = "-15";  //these can all be read directly from the config.
   scrollY = "-15";
   scrollPositionX = "0";
   scrollPositionY = "0";    
      
   //Emitters   //note offsets are relative to their parent doodad, and not the doodad's parent ship
   //doodadEffects# = "EffectName OffestX OffsetY  EmissionRotation EmissionForce EffectScale MinMSTime MaxMSTime" if mintime and max time are 0 it will only play once.  good for constant effects like smoke 
   //IMPORTANT NOTE: you cannot mount effects that are part of a preload set since they are released from their
   //mount when they finish playing so someone else can use them.
   //This means doodad effects must not be preload Effects.
   //doodadEffects1 = "spark 0 -1 0 0 1 500 1000";
   //doodadEffects2 = "TinyThruster 0 1 180 100 0.25 0 0";
   //doodadEffects3 = "TinyThruster 1 0 90 100 0.5 1000 2000";
   //doodadEffects4 = "TinyThruster -1 0 270 100 1 2000 5000";
   
};

//light cards

//small

datablock t2dSceneObjectDatablock(Doodad_LightCard_Small_Terran : DoodadBase) 
{
   imageMap = "effect_terranLight_01ImageMap";
   isIntense = true;     
   
   shouldFlicker = true;  
   shouldRandomizeStates = false;
   
   flickerTime0    = "1000 1500";
   flickerBlend0   = "1 1 1 1";
   flickerSize0    = "32 32";
   flickerIntense0 = true;
   
   flickerTime1    = "50 50";
   flickerBlend1   = "1 1 1 1";
   flickerSize1    = "64 64";
   flickerIntense1 = true;
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Small_Pirate : Doodad_LightCard_Small_Terran) 
{
   imageMap = "effect_pirateLight_01ImageMap";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Small_Civ : Doodad_LightCard_Small_Terran) 
{
   imageMap = "effect_civLight_01ImageMap";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Small_Zom : Doodad_LightCard_Small_Terran) 
{
   imageMap = "effect_zombieLight_01ImageMap";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Small_Bounty : Doodad_LightCard_Small_Terran) 
{
   imageMap = "effect_bountyLight_01ImageMap";
};

//med

datablock t2dSceneObjectDatablock(Doodad_LightCard_Med_Terran : Doodad_LightCard_Small_Terran) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "128 128";
   flickerTime0    = "2000 4000";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Med_Pirate : Doodad_LightCard_Small_Pirate) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "128 128";
   flickerBlend1   = "1 1 0.4 1";
   flickerTime0    = "2000 4000";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Med_Civ : Doodad_LightCard_Small_Civ) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "128 128";
   flickerBlend1   = "1 1 0.4 1";
   flickerTime0    = "2000 4000";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Med_Zom : Doodad_LightCard_Small_Zom) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "128 128";
   flickerBlend1   = "1 1 0.4 1";
   flickerTime0    = "2000 4000";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Med_Bounty : Doodad_LightCard_Small_Bounty) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "128 128";
   flickerBlend1   = "1 1 0.4 1";
   flickerTime0    = "2000 4000";
};


//large

datablock t2dSceneObjectDatablock(Doodad_LightCard_Large_Terran : Doodad_LightCard_Small_Terran) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "256 256";
   flickerTime0    = "4500 6000";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Large_Pirate : Doodad_LightCard_Small_Pirate) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "256 256";
   flickerTime0    = "4500 6000";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Large_Civ : Doodad_LightCard_Small_Civ) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "256 256";
   flickerTime0    = "4500 6000";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Large_Zom : Doodad_LightCard_Small_Zom) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "256 256";
   flickerTime0    = "4500 6000";
};

datablock t2dSceneObjectDatablock(Doodad_LightCard_Large_Bounty : Doodad_LightCard_Small_Bounty) 
{
   flickerSize0    = "64 64";
   flickerSize1    = "256 256";
   flickerTime0    = "4500 6000";
};


//props

datablock t2dSceneObjectDatablock(Doodad_RadarDish : DoodadBase) 
{
   imageMap = "radarImageMap";
   size = "24 24";
   
   isIntense = false;     
   doodadBlend = "1 1 1 1";
   
   shouldSpin = true;               //Note, it will look weird if the doodad rotates slower than the ship in many cases
   randomAngularVelocity = "360 360";  //doodads will randomly spin clockwise or counter clockwise 
   randomScan = true;   //false will just spin in a circle
   
   doodadEffects1 = "GreenLight 0.0 -0.8 0 0 0.5 500 1500";
};

datablock t2dSceneObjectDatablock(Doodad_SpinningRadarDish : Doodad_RadarDish) 
{
   randomScan = false;
};

datablock t2dSceneObjectDatablock(Doodad_PirateRadarDish : Doodad_RadarDish) 
{
   imageMap = "pirateRadarImageMap";
};

datablock t2dSceneObjectDatablock(Doodad_TerranRadarDish : Doodad_RadarDish) 
{
   imageMap = "terranRadarImageMap";
};

datablock t2dSceneObjectDatablock(Doodad_ShipLight : DoodadBase) 
{
   imageMap = "effect_lightImageMap";
   size = "32 32";
  
   shouldFlicker = true;  
   shouldRandomizeStates = true;  //if not random, will cycle between states
   
   flickerTime0    = "500 1000";
   flickerBlend0   = "0 0 0 0";
   flickerSize0    = "32 32";
   flickerIntense0 = true;
   
   flickerTime1    = "200";
   flickerBlend1   = "1 0.5 0.5 1";
   flickerSize1    = "32 32";
   flickerIntense1 = true;

   flickerTime2    = "200";
   flickerBlend2   = "0.5 0.5 1 1";
   flickerSize2    = "32 32";
   flickerIntense2 = true;
};

datablock t2dSceneObjectDatablock(Doodad_Antenna : DoodadBase) 
{
   imageMap = "intenaImageMap";
   size = "32 32";
   
   doodadEffects1 = "RedLight 0 -1 0 0 1 500 1000";
   doodadEffects2 = "GreenLight 0.2 -0.8 0 0 0.5 0 0";
};

datablock t2dSceneObjectDatablock(Doodad_PirateAntenna : Doodad_Antenna) 
{
   imageMap = "PirateAntennaImageMap";
};

datablock t2dSceneObjectDatablock(Doodad_TerranAntenna : Doodad_Antenna) 
{
   imageMap = "TerranAntennaImageMap";
};

datablock t2dSceneObjectDatablock(Doodad_Antenna_Broken : Doodad_Antenna) 
{
   doodadEffects3 = "sparks 0 -1 0 0 0.5 1000 2000";
};

//zombie basic doodads

datablock t2dSceneObjectDatablock(Doodad_ZombieLight_small : DoodadBase) 
{
   imageMap = "effect_zombieGlowImageMap";    
   isIntense = true; 
   shouldPulse = true;
   pulseTime    = 1000;
   pulseSizeMin = "92 92";
   pulseSizeMax = "128 128";
   pulseBlendMin = "0.7 0.2 1 0.8";
   pulseBlendMax = "1 0.2 1 0.65";
   pulseLinear = false;  //use a sin wave pulse 
   
   shouldSpin = true;
   randomAngularVelocity = "-10 10";
   randomScan = false; 
};

datablock t2dSceneObjectDatablock(Doodad_ZombieLight_med : Doodad_ZombieLight_small) 
{
   pulseSizeMin = "192 192";
   pulseSizeMax = "256 256";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieLight_large : Doodad_ZombieLight_small) 
{
   pulseSizeMin = "384 384";
   pulseSizeMax = "512 512";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieLight_huge : Doodad_ZombieLight_small) 
{
   pulseSizeMin = "768 768";
   pulseSizeMax = "1024 1024";
   pulseBlendMin = "0.7 0.2 1 0.6";
   pulseBlendMax = "1 0.2 1 0.5";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieEye : Doodad_RadarDish) 
{
   size = "16 16";
   imageMap = "zombieEye_01ImageMap";  
   doodadEffects1 = "";
   doodadEffects1 = "zombiePuke_small 0 0 0 0 1 2000 6000";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieNode_01 : Doodad_RadarDish) 
{
   imageMap = "zombieNode_01ImageMap";
   isIntense = false; 
   shouldPulse = true;
   pulseTime    = 350;
   pulseSizeMin = "32 24";
   pulseSizeMax = "24 32";
   pulseBlendMin = "1 1 1 1";
   pulseBlendMax = "0.5 0.2 0.2 1";
   pulseLinear = false;  //use a sin wave pulse 
   shouldSpin = false;
   doodadEffects1 = "zombiePuke_small 0 0 0 0 1 2000 6000";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieNode_02 : Doodad_ZombieNode_01) 
{
   imageMap = "zombieNode_03ImageMap";
   pulseTime    = 500;
   pulseSizeMin = "24 24";
   pulseSizeMax = "24 24";
   pulseBlendMin = "1 1 1 1";
   pulseBlendMax = "0.5 0.2 0.2 1";
};

//zombie hive custom doodads

datablock t2dSceneObjectDatablock(Doodad_HiveScroller_01 : DoodadBase) 
{
   imageMap = "redFleshTileImageMap";
   size = "384 576";
   isScroller = true;  
   repeatX = "3";
   repeatY = "4";
   scrollX = "-10";  
   scrollY = "12";
   scrollPositionX = "0";
   scrollPositionY = "0";    
};

datablock t2dSceneObjectDatablock(Doodad_HiveScroller_02 : DoodadBase) 
{
   imageMap = "greenMuckTileImageMap";
   size = "384 576";
   isScroller = true;  
   repeatX = "6";
   repeatY = "8";
   scrollX = "8";  
   scrollY = "-6";
   scrollPositionX = "0";
   scrollPositionY = "0";   
};

datablock t2dSceneObjectDatablock(Doodad_HiveHeart : DoodadBase) 
{
   imageMap = "zombieNode_02ImageMap";
   isIntense = false; 
   shouldPulse = true;
   pulseTime    = 1500;
   pulseSizeMin = "256 256";
   pulseSizeMax = "368 368";
   pulseBlendMin = "1 1 1 0.1";
   pulseBlendMax = "0.5 1 0.5 0.8";
   pulseLinear = false;  //use a sin wave pulse 
   
   shouldSpin = true;
   randomAngularVelocity = "4 8";
   randomScan = false; 

   doodadEffects1 = "zombiePuke 0 0 0 0 1 5000 15000";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieClockworkCore : DoodadBase) 
{
   imageMap = "effect_heroGlowImageMap";
   size = "768 768";
   isIntense = true; 
   shouldPulse = false;
   shouldSpin = true;
   randomAngularVelocity = "14 16";
   randomScan = false; 
   doodadEffects1 = "zombieClockworkCore 0 0 0 0 0.4 0 0";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieCrystal_01 : DoodadBase) 
{
   imageMap = "zombieMother_crystals_01ImageMap";
   size = "384 384";
   isIntense = true; 
   shouldPulse = true;
   shouldSpin = false;
   randomScan = false; 
   
   pulseSizeMin = "384 384";
   pulseSizeMax = "384 384";
   pulseBlendMin = "1 1 1 1";
   pulseBlendMax = "1 0.5 0.5 0.7";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieCrystal_02 : Doodad_ZombieCrystal_01) 
{
   imageMap = "zombieMother_crystals_02ImageMap";
   size = "256 256";
   
   pulseSizeMin = "256 256";
   pulseSizeMax = "256 256";
};

datablock t2dSceneObjectDatablock(Doodad_ZombieCrystal_03 : Doodad_ZombieCrystal_01) 
{
   imageMap = "zombieMother_crystals_03ImageMap";
   size = "256 256";
   
   pulseSizeMin = "256 256";
   pulseSizeMax = "256 256";
};

//spinners

datablock t2dSceneObjectDatablock(Doodad_SpinnerBase : DoodadBase) 
{
   isIntense = false; 
   shouldPulse = false;
   shouldSpin = true;
   randomAngularVelocity = "25 30";
   randomScan = false; 
};

datablock t2dSceneObjectDatablock(Doodad_SunSpot_Bottom : Doodad_SpinnerBase) 
{
   imageMap = "ship_sunspot_bottomImageMap";
   size = "384 384";
};

datablock t2dSceneObjectDatablock(Doodad_StationSpinner_Small : Doodad_SpinnerBase) 
{
   imageMap = "staion_spinner_smallImageMap";
   size = "256 256";
};

datablock t2dSceneObjectDatablock(Doodad_StationSpinner_Med : Doodad_SpinnerBase) 
{
   imageMap = "staion_spinner_medImageMap";
   size = "512 512";
};

datablock t2dSceneObjectDatablock(Doodad_StationSpinner_Med_02 : Doodad_SpinnerBase) 
{
   imageMap = "staion_spinner_med_02ImageMap";
   size = "512 512";
};

datablock t2dSceneObjectDatablock(Doodad_StationSpinner_Large : Doodad_SpinnerBase) 
{
   imageMap = "staion_spinner_largeImageMap";
   size = "384 768";
   randomAngularVelocity = "10 12";
};

//beacons

datablock t2dSceneObjectDatablock(Doodad_BeaconPirate : DoodadBase) 
{
   imageMap = "effect_pirateLight_01ImageMap"; 
   doodadEffects1 = "BeaconTerran 0 0 0 0 1 0 0"; //swapped because of the color change
};

datablock t2dSceneObjectDatablock(Doodad_BeaconTerran : DoodadBase) 
{
   imageMap = "effect_terranLight_01ImageMap"; 
   doodadEffects1 = "BeaconPirate 0 0 0 0 1 0 0"; //swapped because of the color change
};

//carrier

datablock t2dSceneObjectDatablock(Doodad_SciCarrier : DoodadBase) 
{
   imageMap = "carrier_SciDoodadImageMap";
   //doodadEffects1 = "BeaconPirate 0 0 0 0 1 0 0";
   size = "288 288";
};

datablock t2dSceneObjectDatablock(Doodad_ColCarrier : DoodadBase) 
{
   imageMap = "carrier_ColDoodadImageMap";
   //doodadEffects1 = "BeaconTerran 0 0 0 0 1 0 0";
   size = "192 384";
};

datablock t2dSceneObjectDatablock(Doodad_MineCarrier : DoodadBase) 
{
   imageMap = "carrier_MineDoodadImageMap";
   //doodadEffects1 = "BeaconTerran 0 0 0 0 1 0 0";
   size = "192 384";
};

datablock t2dSceneObjectDatablock(Doodad_PirateCarrier : DoodadBase) 
{
   imageMap = "carrier_PirateDoodadImageMap";
   //doodadEffects1 = "BeaconTerran 0 0 0 0 1 0 0";
   size = "192 384";
};

datablock t2dSceneObjectDatablock(Doodad_zomCarrier : DoodadBase) 
{
   imageMap = "carrier_zomDoodadImageMap";
   //doodadEffects1 = "BeaconTerran 0 0 0 0 1 0 0";
   size = "192 384";
};

//mothership scafold

datablock t2dSceneObjectDatablock(Doodad_Mother2Scafold : DoodadBase) 
{
   imageMap = "station_clockwork_02_scafoldImageMap";
   size = "512 768";
};

//////////////////////////////////////////////////////
// Doodad Set Datablocks /////////////////////////////
//////////////////////////////////////////////////////

datablock t2dSceneObjectDatablock(DoodadSetBase) 
{
   isDoodadSet = true;  
};

//terran sets

datablock t2dSceneObjectDatablock(DoodadSet_Terran_S_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Small_Terran 100"; 
   //doodadItem1 = "Doodad_ShipLight 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Terran_M_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Med_Terran 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Terran_L_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Large_Terran 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Terran_S_Radar : DoodadSetBase) 
{   
   doodadItem1 = "Doodad_RadarDish 50"; 
   doodadItem2 = "Doodad_SpinningRadarDish 50";
   doodadItem3 = "Doodad_TerranRadarDish 100";
};

datablock t2dSceneObjectDatablock(DoodadSet_Terran_S_Antenna : DoodadSetBase) 
{   
   doodadItem1 = "Doodad_Antenna 100"; 
   doodadItem2 = "Doodad_TerranAntenna 100";
};

//pirate sets

datablock t2dSceneObjectDatablock(DoodadSet_Pirate_S_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Small_Pirate 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Pirate_M_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Med_Pirate 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Pirate_L_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Large_Pirate 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Pirate_S_Radar : DoodadSetBase) 
{   
   doodadItem1 = "Doodad_RadarDish 50"; 
   doodadItem2 = "Doodad_SpinningRadarDish 50";
   doodadItem3 = "Doodad_PirateRadarDish 100";
};

datablock t2dSceneObjectDatablock(DoodadSet_Pirate_S_Antenna : DoodadSetBase) 
{   
   doodadItem1 = "Doodad_Antenna_Broken 100";
   doodadItem2 = "Doodad_PirateAntenna 100";
};

//civ sets

datablock t2dSceneObjectDatablock(DoodadSet_Civ_S_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Small_Civ 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Civ_M_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Med_Civ 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Civ_L_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Large_Civ 100"; 
};

//zombie light sets

datablock t2dSceneObjectDatablock(DoodadSet_Zombie_S_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Small_Zom 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Zombie_M_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Med_Zom 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Zombie_L_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Large_Zom 100"; 
};

//bounty lights set

datablock t2dSceneObjectDatablock(DoodadSet_Bounty_S_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Small_Bounty 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Bounty_M_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Med_Bounty 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Bounty_L_Lights : DoodadSetBase) 
{    
   doodadItem1 = "Doodad_LightCard_Large_Bounty 100"; 
};

//zombie sets

datablock t2dSceneObjectDatablock(DoodadSet_Zombie_S_Node : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_ZombieEye 100"; 
   doodadItem2 = "Doodad_ZombieNode_01 100";
   doodadItem3 = "Doodad_ZombieNode_02 100";
};

datablock t2dSceneObjectDatablock(DoodadSet_Zombie_Glow_Small : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_ZombieEye 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Zombie_Glow_Med : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_ZombieEye 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Zombie_Glow_Large : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_ZombieEye 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_Zombie_Glow_Huge : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_ZombieEye 100"; 
};

//beacons

datablock t2dSceneObjectDatablock(DoodadSet_BeaconPirate : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_BeaconPirate 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_BeaconTerran : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_BeaconTerran 100"; 
};

//clockwork zero

datablock t2dSceneObjectDatablock(DoodadSet_clockworkzeroLeft : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_clockworkZeroLeft 100"; 
};

datablock t2dSceneObjectDatablock(DoodadSet_clockworkzeroRight : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_clockworkZeroRight 100"; 
};

//carrier

datablock t2dSceneObjectDatablock(DoodadSet_Carrier : DoodadSetBase) 
{  
   isSpecialCivDoodad = true;  
   doodadItem1 = "Doodad_MineCarrier 100"; 
   doodadItem2 = "Doodad_ColCarrier 100"; 
   doodadItem3 = "Doodad_SciCarrier 100"; 
};
datablock t2dSceneObjectDatablock(DoodadSet_PirateCarrier : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_PirateCarrier 100"; 
};

//mothership scafold

datablock t2dSceneObjectDatablock(DoodadSet_Mother2Scafold : DoodadSetBase) 
{  
   doodadItem1 = "Doodad_Mother2Scafold 100"; 
};

//deploy turret doodads

datablock t2dSceneObjectDatablock(Doodad_DeployTurret_Beam : Doodad_SpinnerBase) 
{
   imageMap = "deployDoodad_beamImageMap";
   size = "64 64";
};
datablock t2dSceneObjectDatablock(Doodad_DeployTurret_Cannon : Doodad_SpinnerBase) 
{
   imageMap = "deployDoodad_cannonImageMap";
   size = "64 64";
};
datablock t2dSceneObjectDatablock(Doodad_DeployTurret_Torp : Doodad_SpinnerBase) 
{
   imageMap = "deployDoodad_torpImageMap";
   size = "64 64";
};
datablock t2dSceneObjectDatablock(Doodad_DeployTurret_Ion : Doodad_SpinnerBase) 
{
   imageMap = "deployDoodad_ionImageMap";
   size = "64 64";
};
datablock t2dSceneObjectDatablock(Doodad_DeployTurret_Leech : Doodad_SpinnerBase) 
{
   imageMap = "deployDoodad_leechImageMap";
   size = "64 64";
};
datablock t2dSceneObjectDatablock(Doodad_DeployTurret_Rapid : Doodad_SpinnerBase) 
{
   imageMap = "deployDoodad_rapidImageMap";
   size = "64 64";
};

















