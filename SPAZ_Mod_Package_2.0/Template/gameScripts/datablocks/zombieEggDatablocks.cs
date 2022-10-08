//Zombie Eggs



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Egg Size Definitions //////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
datablock ZombieEggSizeDatablock(ZombieEggSizeBase)
{
   //Art
   eggData_ImageMap_Membrane         = "zombieEgg_station_01ImageMap";
   eggData_ImageMap_EmbryoForeground = "zombieEgg_station_background_01ImageMap";
   eggData_ImageMap_EmbryoBackground = "zombieEgg_station_background_01ImageMap";
   eggData_ImageMap_VeinsFirst       = "zombieEgg_station_veins_01ImageMap";
   eggData_ImageMap_VeinsLast        = "zombieEgg_station_veins_01ImageMap";
   eggData_ImageMap_Cracks           = "zombieEgg_station_cracks_01ImageMap";
         
   eggData_maxHealth              = 50;  //bigger eggs should have more health.
   eggData_mass                   = 5;
   
   
   eggData_TwitchAlertMultiplier  = 4;   //how much faster i rotate when alert
   eggData_TwitchAlertTime        = 5;   //how long i stay alert for
   eggData_EmbryoRotationRate     = 60;
   
   eggData_BreathRate             = 0.5; //seconds per breath
   eggData_BreathSize             = 0.2; //percent of total size. (all layers breathe together)
   
   //how much of the embryo rotation is translated to each layer. 
   eggData_RotationFactor_Membrane           = 0.25;
   eggData_RotationFactor_EmbryoForeground   = 0.5;
   eggData_RotationFactor_EmbryoBackground   = 0.5;
   eggData_RotationFactor_VeinsFirst         = 0.25;
   eggData_RotationFactor_VeinsLast          = 0.25;
   eggData_RotationFactor_Cracks             = 0.25;  
 
   
   //Effects   
   //When popped by gunfire.  hatch will also play.  this should spawn some juicy leftover guts that were not yet absorbed
   
   eggData_Effects_Effect_OnDamaged     = "hullImpact_zombie";
   eggData_Effects_Scale_OnDamaged      = 1;
   eggData_Effects_Sound_OnDamaged      = "snd_eggHit";
   
   eggData_Effects_Effect_Hatching      = "zombieEggHatchSmall";
   eggData_Effects_Scale_Hatching       = 1;
   eggData_Effects_Sound_Hatching       = "snd_eggHatchSmall"; 
   
   eggData_Effects_Effect_Maturing      = "zombieEggBugs_01";
   eggData_Effects_Scale_Maturing       = 3;
   eggData_Effects_Sound_Maturing       = "snd_eggMotion"; //This sound will replay periodically. will expose period
   
   eggData_Effects_Effect_Molting       = "zombieEggChange";
   eggData_Effects_Scale_Molting        = 1;
   eggData_Effects_Sound_Molting        = "snd_eggGrowSmall"; 
   
   eggData_Effects_Effect_Rupturing     = "zombieEggHatchSmall"; 
   eggData_Effects_Scale_Rupturing      = 1;
   eggData_Effects_Sound_Rupturing      = "snd_eggAbortSmall"; 
   
   //Not in code: (will play on the link point of the parent ship. at i laver below the ship
   shipBirth_Effect        = "zombieEggBirth"; 
   shipBirth_EffectScale   = 0.33;
   shipBirth_EffectTime    = 1; //seconds
   shipBirth_Sound         = "snd_eggAbortSmall"; 
   shipBirth_Debris        = "DC_Combat_Large_Heavy_Zombie";
   shipBirth_DebrisCount   = 1;
   shipBirth_EjectionForce = 50;
   
   ///////////////////////////////
   //States (State 0 = spawn/quick growth, State 1 = maturing egg, no growth, but lots of activity inside)
   ///////////////////////////////   
   
   //Spawn/Growth 
   eggStates_0_StateTime                      = 0.1;  //seconds        
   
   eggStates_0_Initial_Size_Membrane          = "1 1";
   eggStates_0_Initial_Size_EmbryoForeground  = "0 0";  //Anything Will match membrane if set to "0 0"
   eggStates_0_Initial_Size_EmbryoBackground  = "0 0";
   eggStates_0_Initial_Size_VeinsFirst        = "0 0";
   eggStates_0_Initial_Size_VeinsLast         = "0 0";
   eggStates_0_Initial_Size_Cracks            = "0 0";
   
   eggStates_0_Initial_Color_Membrane         = "1 1 1 1";  
   eggStates_0_Initial_Color_EmbryoForeground = "1 1 1 1";    //Anything Will match membrane if set to "0 0"
   eggStates_0_Initial_Color_EmbryoBackground = "1 1 1 1";
   eggStates_0_Initial_Color_VeinsFirst       = "0.3 0.3 0.3 0.7";
   eggStates_0_Initial_Color_VeinsLast        = "0.3 0.3 0.3 0.7";
   eggStates_0_Initial_Color_Cracks           = "1 1 1 0";
      
   eggStates_0_Final_Size_Membrane            = "36 36";
   eggStates_0_Final_Size_EmbryoForeground    = "0 0";  //Anything Will match membrane if set to "0 0"
   eggStates_0_Final_Size_EmbryoBackground    = "0 0";
   eggStates_0_Final_Size_VeinsFirst          = "0 0";
   eggStates_0_Final_Size_VeinsLast           = "0 0";
   eggStates_0_Final_Size_Cracks              = "0 0";
   
   eggStates_0_Final_Color_Membrane           = "1 0 0 1";  
   eggStates_0_Final_Color_EmbryoForeground   = "1 1 1 1";    
   eggStates_0_Final_Color_EmbryoBackground   = "1 1 1 1";
   eggStates_0_Final_Color_VeinsFirst         = "0.7 0.7 0.7 0.5";
   eggStates_0_Final_Color_VeinsLast          = "0.7 0.7 0.7 0.5";
   eggStates_0_Final_Color_Cracks             = "1 1 1 0";
   
   
   
   //Maturing 
   eggStates_1_StateTime                      = 5;  //seconds        
   
   eggStates_1_Initial_Size_Membrane          = "36 36";
   eggStates_1_Initial_Size_EmbryoForeground  = "0 0";  //Anything Will match membrane if set to "0 0"
   eggStates_1_Initial_Size_EmbryoBackground  = "0 0";
   eggStates_1_Initial_Size_VeinsFirst        = "0 0";
   eggStates_1_Initial_Size_VeinsLast         = "0 0";
   eggStates_1_Initial_Size_Cracks            = "0 0";
   
   eggStates_1_Initial_Color_Membrane         = "1 0.5 0.5 1";  
   eggStates_1_Initial_Color_EmbryoForeground = "1 1 1 1";    //Anything Will match membrane if set to "0 0"
   eggStates_1_Initial_Color_EmbryoBackground = "1 1 1 1";
   eggStates_1_Initial_Color_VeinsFirst       = "0.7 0.7 0.7 0.5";
   eggStates_1_Initial_Color_VeinsLast        = "0.7 0.7 0.7 0.5";
   eggStates_1_Initial_Color_Cracks           = "1 1 1 0";
      
   eggStates_1_Final_Size_Membrane            = "36 36";
   eggStates_1_Final_Size_EmbryoForeground    = "0 0";  //Anything Will match membrane if set to "0 0"
   eggStates_1_Final_Size_EmbryoBackground    = "0 0";
   eggStates_1_Final_Size_VeinsFirst          = "36 36";
   eggStates_1_Final_Size_VeinsLast           = "24 24"; //2/3 of the egg size (or 1/2 of the spawned ship size, take yer pick)
   eggStates_1_Final_Size_Cracks              = "0 0";
   
   eggStates_1_Final_Color_Membrane           = "1 1 1 0.66";  
   eggStates_1_Final_Color_EmbryoForeground   = "1 1 1 0";        //become invisible to show ship
   eggStates_1_Final_Color_EmbryoBackground   = "1 1 1 1";
   eggStates_1_Final_Color_VeinsFirst         = "0.3 0.3 0.3 0.7";        //veins act as a progress bar.  fill at different rate to look more natural
   eggStates_1_Final_Color_VeinsLast          = "0.3 0.3 0.3 0.7";
   eggStates_1_Final_Color_Cracks             = "1 1 1 1";        //cracks only show if this is the final state for the egg and it is going to hatch
   
   
};

datablock ZombieEggSizeDatablock(ZombieEggSize_Tiny : ZombieEggSizeBase)
{   
   eggData_mass                   = 5;
   eggData_maxHealth              = 25;
   
   eggData_Effects_Scale_Hatching     = 0.6;
   eggData_Effects_Scale_Maturing     = 0.8;
   eggData_Effects_Scale_Rupturing    = 0.6;
   eggData_Effects_Scale_Molting      = 0.4;
     
   //Art
   eggData_ImageMap_Membrane         = "zombieEgg_tiny_01ImageMap";
   eggData_ImageMap_EmbryoForeground = "zombieEgg_tiny_background_01ImageMap";
   eggData_ImageMap_EmbryoBackground = "zombieEgg_glowImageMap";
   eggData_ImageMap_VeinsFirst       = "zombieEgg_tiny_veins_01ImageMap";
   eggData_ImageMap_VeinsLast        = "zombieEgg_tiny_veins_01ImageMap";
   eggData_ImageMap_Cracks           = "zombieEgg_tiny_cracks_01ImageMap";   
    
   //Spawn
   eggStates_0_StateTime                 = 0.10;     
   eggStates_0_Initial_Size_Membrane     = "1 1";
   eggStates_0_Final_Size_Membrane       = "36 36";   //75% of ship size.
           
   //Mature
   eggStates_1_StateTime                 = 5;     
   eggStates_1_Initial_Size_Membrane     = "36 36";
   eggStates_1_Final_Size_Membrane       = "36 36";   //no change to shell as embryo grows inside
   
   eggStates_1_Final_Size_VeinsFirst     = "36 36";
   eggStates_1_Final_Size_VeinsLast      = "24 24";   //2/3 of the egg size (or 1/2 of the spawned ship size, take yer pick)

   eggData_BreathRate             = 0.5; 
   eggData_BreathSize             = 0.2; 
   
   //glow effect
   eggStates_0_Initial_Size_EmbryoBackground  = "0 0";
   eggStates_0_Final_Size_EmbryoBackground    = "64 64";
   eggStates_1_Initial_Size_EmbryoBackground  = "64 64";
   eggStates_1_Final_Size_EmbryoBackground  = "64 64";
   
   
   shipBirth_EffectScale   = 0.7;
   shipBirth_EffectTime    = 2; //seconds  
   shipBirth_Debris        = "DC_Combat_Small_Light_Zombie";
   shipBirth_EjectionForce = 10;
   shipBirth_DebrisCount   = 1;
};



datablock ZombieEggSizeDatablock(ZombieEggSize_Small : ZombieEggSizeBase)
{  
   eggData_mass                       = 10; //double the mass of the ship that will be inside it. 
   eggData_maxHealth                  = 75;
   
   eggData_Effects_Scale_Hatching     = 0.8;
   eggData_Effects_Scale_Maturing     = 1;
   eggData_Effects_Scale_Rupturing    = 0.8;
   eggData_Effects_Scale_Molting      = 0.6;
   
   //Art
   eggData_ImageMap_Membrane         = "zombieEgg_small_01ImageMap";
   eggData_ImageMap_EmbryoForeground = "zombieEgg_small_background_01ImageMap";
   eggData_ImageMap_EmbryoBackground = "zombieEgg_glowImageMap";
   eggData_ImageMap_VeinsFirst       = "zombieEgg_small_veins_01ImageMap";
   eggData_ImageMap_VeinsLast        = "zombieEgg_small_veins_01ImageMap";
   eggData_ImageMap_Cracks           = "zombieEgg_small_cracks_01ImageMap";  
    
   //Spawn
   eggStates_0_StateTime                 = 0.15;     
   eggStates_0_Initial_Size_Membrane     = "36 36"; 
   eggStates_0_Final_Size_Membrane       = "48 48";   //75% of ship size.
           
   //Mature
   eggStates_1_StateTime                 = 10;     
   eggStates_1_Initial_Size_Membrane     = "48 48";
   eggStates_1_Final_Size_Membrane       = "48 48";   //no change to shell as embryo grows inside
   
   eggStates_1_Final_Size_VeinsFirst     = "48 48";
   eggStates_1_Final_Size_VeinsLast      = "36 36";   //2/3 of the egg size (or 1/2 of the spawned ship size, take yer pick)
     
   eggData_BreathRate             = 0.75; 
   eggData_BreathSize             = 0.15; 
   
   //glow effect
   eggStates_0_Initial_Size_EmbryoBackground  = "64 64";
   eggStates_0_Final_Size_EmbryoBackground    = "100 100";
   eggStates_1_Initial_Size_EmbryoBackground  = "100 100";
   eggStates_1_Final_Size_EmbryoBackground  = "100 100";
   
   shipBirth_EffectScale   = 0.8;
   shipBirth_EffectTime    = 3; //seconds  
   shipBirth_Debris        = "DC_Combat_Small_Light_Zombie";
   shipBirth_EjectionForce = 20;
   shipBirth_DebrisCount   = 2;
};


datablock ZombieEggSizeDatablock(ZombieEggSize_Medium : ZombieEggSizeBase)
{   
   eggData_mass                       = 50; //double the mass of the ship that will be inside it. 
   eggData_maxHealth                  = 200;
   
   eggData_Effects_Scale_Hatching     = 1;
   eggData_Effects_Scale_Maturing     = 1.7;
   eggData_Effects_Scale_Rupturing    = 1;
   eggData_Effects_Scale_Molting      = 0.7;
   
   //Art
   eggData_ImageMap_Membrane         = "zombieEgg_medium_01ImageMap";
   eggData_ImageMap_EmbryoForeground = "zombieEgg_medium_background_01ImageMap";
   eggData_ImageMap_EmbryoBackground = "zombieEgg_glowImageMap";
   eggData_ImageMap_VeinsFirst       = "zombieEgg_medium_veins_01ImageMap";
   eggData_ImageMap_VeinsLast        = "zombieEgg_medium_veins_01ImageMap";
   eggData_ImageMap_Cracks           = "zombieEgg_medium_cracks_01ImageMap"; 
   
   //Spawn
   eggStates_0_StateTime                 = 0.20;     
   eggStates_0_Initial_Size_Membrane     = "48 48"; 
   eggStates_0_Final_Size_Membrane       = "96 96";   //75% of ship size.
           
   //Mature
   eggStates_1_StateTime                 = 15;     
   eggStates_1_Initial_Size_Membrane     = "96 96";
   eggStates_1_Final_Size_Membrane       = "96 96";   //no change to shell as embryo grows inside
   
   eggStates_1_Final_Size_VeinsFirst     = "96 96";
   eggStates_1_Final_Size_VeinsLast      = "64 64";   //2/3 of the egg size (or 1/2 of the spawned ship size, take yer pick)
 
   eggData_BreathRate             = 1; 
   eggData_BreathSize             = 0.1; 
   
   //glow effect
   eggStates_0_Initial_Size_EmbryoBackground  = "100 100";
   eggStates_0_Final_Size_EmbryoBackground    = "192 192";
   eggStates_1_Initial_Size_EmbryoBackground  = "192 192";
   eggStates_1_Final_Size_EmbryoBackground  = "192 192";
   
   shipBirth_EffectScale   = 1;
   shipBirth_EffectTime    = 4; //seconds  
   shipBirth_Debris        = "DC_Combat_Small_Heavy_Zombie";
   shipBirth_EjectionForce = 30;
   shipBirth_DebrisCount   = 1;
};

datablock ZombieEggSizeDatablock(ZombieEggSize_Large : ZombieEggSizeBase)
{  
   eggData_mass                       = 250; //double the mass of the ship that will be inside it. 
   eggData_maxHealth                  = 500;   
      
   //Sound and Effects   
   eggData_Effects_Effect_Hatching      = "zombieEggHatchSmall";
   eggData_Effects_Scale_Hatching       = 1.2;
   eggData_Effects_Sound_Hatching       = "snd_eggHatchHuge"; 
   
   eggData_Effects_Effect_Molting       = "zombieEggChange";
   eggData_Effects_Scale_Molting        = 1.6;
   eggData_Effects_Sound_Molting        = "snd_eggGrowLarge"; 
   
   eggData_Effects_Effect_Rupturing     = "zombieEggHatchSmall"; 
   eggData_Effects_Scale_Rupturing      = 1.2;
   eggData_Effects_Sound_Rupturing      = "snd_eggAbortLarge";
   
   eggData_Effects_Sound_Maturing       = "snd_eggMotion_large";
   eggData_Effects_Scale_Maturing     = 2.2;
    
   //Art
   eggData_ImageMap_Membrane         = "zombieEgg_large_01ImageMap";
   eggData_ImageMap_EmbryoForeground = "zombieEgg_large_background_01ImageMap";
   eggData_ImageMap_EmbryoBackground = "zombieEgg_glowImageMap";
   eggData_ImageMap_VeinsFirst       = "zombieEgg_large_veins_01ImageMap";
   eggData_ImageMap_VeinsLast        = "zombieEgg_large_veins_01ImageMap";
   eggData_ImageMap_Cracks           = "zombieEgg_large_cracks_01ImageMap"; 
   
   //Spawn
   eggStates_0_StateTime                 = 0.30;     
   eggStates_0_Initial_Size_Membrane     = "96 96"; 
   eggStates_0_Final_Size_Membrane       = "160 160";   //75% of ship size.
           
   //Mature
   eggStates_1_StateTime                 = 20;     
   eggStates_1_Initial_Size_Membrane     = "160 160";
   eggStates_1_Final_Size_Membrane       = "160 160";   //no change to shell as embryo grows inside
   
   eggStates_1_Final_Size_VeinsFirst     = "160 160";
   eggStates_1_Final_Size_VeinsLast      = "112 112";   //2/3 of the egg size (or 1/2 of the spawned ship size, take yer pick)

   eggData_BreathRate             = 1.5; 
   eggData_BreathSize             = 0.075; 
   
   //glow effect
   eggStates_0_Initial_Size_EmbryoBackground  = "160 160";
   eggStates_0_Final_Size_EmbryoBackground    = "288 288";
   eggStates_1_Initial_Size_EmbryoBackground  = "288 288";
   eggStates_1_Final_Size_EmbryoBackground  = "288 288";
   
   shipBirth_EffectScale   = 1.1;
   shipBirth_EffectTime    = 4.5; //seconds  
   shipBirth_Debris        = "DC_Combat_Small_Heavy_Zombie";
   shipBirth_EjectionForce = 50;
   shipBirth_DebrisCount   = 2;
};


//also used for stations. 
datablock ZombieEggSizeDatablock(ZombieEggSize_Huge : ZombieEggSizeBase)
{  
   eggData_mass                         = 1000; //double the mass of the ship that will be inside it. 
   eggData_maxHealth                    = 1000;   

   //Sound and Effects   
   eggData_Effects_Effect_Hatching      = "zombieEggHatchLarge";
   eggData_Effects_Scale_Hatching       = 0.7;
   eggData_Effects_Sound_Hatching       = "snd_eggHatchHuge"; 
   
   eggData_Effects_Effect_Molting       = "zombieEggChange";
   eggData_Effects_Scale_Molting        = 1.8;
   eggData_Effects_Sound_Molting        = "snd_eggGrowLarge"; 
   
   eggData_Effects_Effect_Rupturing     = "zombieEggHatchLarge"; 
   eggData_Effects_Scale_Rupturing      = 0.7;
   eggData_Effects_Sound_Rupturing      = "snd_eggAbortLarge";
   
   eggData_Effects_Sound_Maturing       = "snd_eggMotion_large"; 
   eggData_Effects_Scale_Maturing     = 3.2; 
    
   //Art
   eggData_ImageMap_Membrane         = "zombieEgg_station_01ImageMap";
   eggData_ImageMap_EmbryoForeground = "zombieEgg_station_background_01ImageMap";
   eggData_ImageMap_EmbryoBackground = "zombieEgg_glowImageMap";
   eggData_ImageMap_VeinsFirst       = "zombieEgg_station_veins_01ImageMap";
   eggData_ImageMap_VeinsLast        = "zombieEgg_station_veins_01ImageMap";
   eggData_ImageMap_Cracks           = "zombieEgg_station_cracks_01ImageMap"; 
         
   //Spawn
   eggStates_0_StateTime                 = 0.50;     
   eggStates_0_Initial_Size_Membrane     = "160 160";
   eggStates_0_Final_Size_Membrane       = "320 320";   //75% of ship size.
           
   //Mature
   eggStates_1_StateTime                 = 25;     
   eggStates_1_Initial_Size_Membrane     = "320 320";
   eggStates_1_Final_Size_Membrane       = "320 320";   //no change to shell as embryo grows inside
   
   eggStates_1_Final_Size_VeinsFirst     = "320 320";
   eggStates_1_Final_Size_VeinsLast      = "256 256";   //2/3 of the egg size (or 1/2 of the spawned ship size, take yer pick)

   eggData_BreathRate             = 2; 
   eggData_BreathSize             = 0.05; 
   
   //glow effect
   eggStates_0_Initial_Size_EmbryoBackground  = "288 288";
   eggStates_0_Final_Size_EmbryoBackground    = "384 384";
   eggStates_1_Initial_Size_EmbryoBackground  = "384 384";
   eggStates_1_Final_Size_EmbryoBackground  = "384 384";
   
   shipBirth_EffectScale   = 1.3;
   shipBirth_EffectTime    = 5; //seconds  
   shipBirth_Debris        = "DC_Combat_Huge_Heavy_Zombie";
   shipBirth_EjectionForce = 50;
   shipBirth_DebrisCount   = 2;
};



//These must be last or game will crash.  code needs to look up the eggSizeData_
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Egg definitions ///////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
datablock ZombieEggDatablock(ZombieEggBase) 
{      
   //Note: Embryo keyword is special here.  everything is mounted to it, but you do not define the image map for it above
   eggSizeData_LayerCreationOrder = "EmbryoBackground Embryo EmbryoForeground Membrane VeinsLast VeinsFirst Cracks";

   //Note: you have 2 layers to work with.  Anything on 0 offset is on the embryo layer.
   eggSizeData_LayerOffset_Membrane           = -1; 
   eggSizeData_LayerOffset_EmbryoForeground   = 0;
   eggSizeData_LayerOffset_EmbryoBackground   = 0;
   eggSizeData_LayerOffset_VeinsFirst         = -1;
   eggSizeData_LayerOffset_VeinsLast          = -1;
   eggSizeData_LayerOffset_Cracks             = -1;  

   //numbers map to ship sizes
   eggSizeData_0 = "ZombieEggSize_Tiny";
   eggSizeData_1 = "ZombieEggSize_Small";
   eggSizeData_2 = "ZombieEggSize_Medium";
   eggSizeData_3 = "ZombieEggSize_Large";
   eggSizeData_4 = "ZombieEggSize_Huge";
   eggSizeData_5 = "ZombieEggSize_Huge";
   eggSizeData_6 = "ZombieEggSize_Huge";      
};


$ZombieConvertScales[$HULLTYPE_TINY]   = ZombieEggSize_Tiny.eggData_Effects_Scale_Rupturing;
$ZombieConvertScales[$HULLTYPE_SMALL]  = ZombieEggSize_Small.eggData_Effects_Scale_Rupturing;
$ZombieConvertScales[$HULLTYPE_MEDIUM] = ZombieEggSize_Medium.eggData_Effects_Scale_Rupturing;
$ZombieConvertScales[$HULLTYPE_LARGE]  = ZombieEggSize_Large.eggData_Effects_Scale_Rupturing;
$ZombieConvertScales[$HULLTYPE_HUGE]   = ZombieEggSize_Huge.eggData_Effects_Scale_Rupturing;

$ZombieConvertEffects[$HULLTYPE_TINY]   = ZombieEggSize_Tiny.eggData_Effects_Effect_Rupturing;
$ZombieConvertEffects[$HULLTYPE_SMALL]  = ZombieEggSize_Small.eggData_Effects_Effect_Rupturing;
$ZombieConvertEffects[$HULLTYPE_MEDIUM] = ZombieEggSize_Medium.eggData_Effects_Effect_Rupturing;
$ZombieConvertEffects[$HULLTYPE_LARGE]  = ZombieEggSize_Large.eggData_Effects_Effect_Rupturing;
$ZombieConvertEffects[$HULLTYPE_HUGE]   = ZombieEggSize_Huge.eggData_Effects_Effect_Rupturing;

$ZombieConvertSounds[$HULLTYPE_TINY]   = ZombieEggSize_Tiny.eggData_Effects_Sound_Rupturing;
$ZombieConvertSounds[$HULLTYPE_SMALL]  = ZombieEggSize_Small.eggData_Effects_Sound_Rupturing;
$ZombieConvertSounds[$HULLTYPE_MEDIUM] = ZombieEggSize_Medium.eggData_Effects_Sound_Rupturing;
$ZombieConvertSounds[$HULLTYPE_LARGE]  = ZombieEggSize_Large.eggData_Effects_Sound_Rupturing;
$ZombieConvertSounds[$HULLTYPE_HUGE]   = ZombieEggSize_Huge.eggData_Effects_Sound_Rupturing;



   
