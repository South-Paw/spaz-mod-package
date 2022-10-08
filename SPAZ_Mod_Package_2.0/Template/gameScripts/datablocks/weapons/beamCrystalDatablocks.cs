

datablock BeamCrystlDatablock(BeamCrystalBase) 
{  
   body0_imagemap     = "beam_coreImageMap"; 
   body0_color        = "0 0 0 0.7";
   body0_variance     = "0 0 0 0.2";
   body0_scale        = "0.25 0.2";  //scale and scale variance % so here +/- 5 so 20-30
   body0_fadeTime     = "0.1 0.1";  //fadeIn/Fade out in % beam life.  fades in whhile beam is doing damage so one should be set near 0, fades out after damage complete
   body0_fadeScale    = "3 0"; //this is a scale multiplier.  so when the beam starts it seems to grow and at the end seems to shrink
   body0_isIntense    = true;
   //NOTE: fade time in seconds 
     
   body1_imagemap     = "beam_baseImageMap"; 
   body1_color        = "0 0 0 0.4";
   body1_variance     = "0 0 0 0.5";
   body1_scale        = "2.0 0.1";  //scale and scale variance % so here +/- 5 so 20-30
   body1_fadeTime     = "0.3 0.5";
   body1_fadeScale    = "0 3"; //grows with beam firing, and on fade out disperses
   body1_isIntense    = true;
   
   //area Effect (times in seconds.  end time is seconds before beam end.  if this is a constant beam.  end time will never be reached.  will stop with beam
   areaEffectStartTime    = 0;  //so can start and end the effect whenever you want.
   areaEffectEndTime      = 0;  //applies to both collision and area effect

   areaEffect               = "";
   areaEffectScale          = 1;      
   area_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   area_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   areaEffectStartWidth   = 0.25;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.75;  //length taken from beam length
   areaEffectAllowEffectLinger = false;  //if false.  effects are killed as soon as beam stops
   areaEffectQuantityScaling  = true; //fewer effects when the beam is scaled short hitting nearby things
   //Note: if effect linger is on, when effects hit an object, they are not reset, so only use for effects 
   //that are not linked to position or rotation.    
      
   areaCollisionEffect      = "beamAreaHighlight";  //if not defined, areaEffect will always play.  if only this defined, then only effect on collision
   areaCollisionEffectScale = 1;   
   areaCollision_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   areaCollision_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore  //Alpha value ingored, works as a flag
   areaCollisionEffectStartWidth   = 0.1;   //this is a % of beam thickness, >1 is ok
   areaCollisionEffectEndWidth     = 0.1;  //length taken from beam length
   areaCollisionEffectAllowEffectLinger = false;  //if false.  effects are killed as soon as beam stops
   areaCollisionEffectQuantityScaling   = true; //fewer effects when the beam is scaled short hitting nearby things
    
   //effect played by the emitter so will not be played in all cases. 
   //different emitters require charging.  Effect is here for convienience.  
   charging_effect            = "LaserCharge";
   charging_effect_scale      = "1";
   charging_sound             = "snd_smallLaserFire";  //Need a sound.
   charging_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   charging_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
  
   fire_effect            = "LaserFire";
   fire_effect_scale      = "2";
   fire_sound             = "snd_smallLaserFire";
   fire_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   fire_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag

   //Will only play for constant beams (not tractors)
   //if set to "" will not play at all.  
   fire_soundPuff_Sound    = "snd_heavyLaserPuff"; //only for constant style beams
   fire_soundPuff_Delay    = 0.1; //delay before puffing starts. (gives time for initial sound to pass)
   fire_soundPuff_Rate     = 0.3; //how often to puff.
   fire_soundPuff_Variance = 0.1; //what percentage of total Rate can we +/- gives sound an irregular feel.  it is ok to set to 0 
   
   hit_effect            = "LaserCut";
   hit_effect_scale      = "2";
   hit_sound             = "snd_smallLaserHit";
   hit_effect_StartBlend = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag
   hit_effect_EndBlend   = "0 0 0 0";  //note: "0 0 0 0" tells code to ignore //Alpha value ingored, works as a flag

   //for the mother rock beams.. these collision bits get added to the natural beam collision bits.
   specialCollision  = 0;

   isConstant = false;  //these types of beams will fire for as long as there is power, or desire to fire them
   chargeTime = 0;  //if 0, beam does not use charging
   
   researchDatablock = "BeamResearch";
};

///////////////////////////////////////////////
// BASIC LASERS
///////////////////////////////////////////////

datablock BeamCrystlDatablock(SmallCrystal : BeamCrystalBase) 
{
   body0_color       = "0.2 1 1 0.7";      
   body0_fadeTime    = "0.2 0.2";
   body0_fadeScale   = "2 0";  //focus down, then shrink to nothing
   
   body1_color       = "1 0 1 0.4";
   body1_fadeTime    = "0.4 0.4";
   body1_fadeScale   = "0 2";  //heat up, then disperse
   
   baseDamage        = "8";  //damage per ssecond
   thickness         = "20"; 
   beamLength        = "600"; 
   beamLife          = "1000";
   beamRegen         = "1000";  
   damageType        = "Energy";
   
   hit_effect_scale  = "1";
   hit_effect_StartBlend = "1 0.7 0 1"; 
   hit_effect_EndBlend   = "1 0 0 1"; 
   
   fire_effect_scale      = "1";          
   fire_effect_StartBlend = "1 0.7 0 1";  
   fire_effect_EndBlend   = "1 0 0 1"; 
   
   
   //areaEffect         = "beamAreaExample"; 
   
   areaEffect             = "beamAreaCoils";
   areaEffectScale        = 1;   
   area_effect_StartBlend = "1 1 0 1";  
   area_effect_EndBlend   = "1 0 0 1";  
   areaEffectStartWidth   = 0.25;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.75;  //length taken from beam length
   //areaEffectQuantityScaling  = true; 
   
   charging_effect_scale = 1;
   charging_effect_StartBlend = "1 1 0 1";  
   charging_effect_EndBlend   = "1 0 0 1";  
   isConstant = false;  
   chargeTime = 0;  //If charge time is 0 we use charge effect while regenning.
};

datablock BeamCrystlDatablock(MediumCrystal : SmallCrystal) 
{
   body0_fadeTime    = "0.25 0.25";
   body0_fadeScale   = "2 0";  //focus down, then shrink to nothing
   
   body1_fadeTime    = "0.5 0.5";
   body1_fadeScale   = "0 2";  //heat up, then disperse 
   
   baseDamage        = "12";  //damage per ssecond
   thickness         = "25"; 
   beamLength        = "700"; 
   beamLife          = "1500";
   beamRegen         = "1250";  
   
   hit_effect_scale  = "1.2";
   
   fire_effect_scale      = "1.2";          
   
   areaEffectScale        = 1.2;   
   areaEffectStartWidth   = 0.25;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.75;  //length taken from beam length
   //areaEffectQuantityScaling  = true; 
   
   areaCollisionEffectScale = 1.4;   
   
   charging_effect_scale = 1.15;  
};

datablock BeamCrystlDatablock(LargeCrystal : SmallCrystal) 
{
   body0_fadeTime     = "0.4 0.4";
   body0_fadeScale    = "2 0";  //focus down, then shrink to nothing
  
   body1_fadeTime     = "0.6 0.6";
   body1_fadeScale    = "0 2";  //heat up, then disperse
   
   baseDamage        = "18";  //damage per ssecond
   thickness         = "30"; 
   beamLength        = "800"; 
   beamLife          = "2000";
   beamRegen         = "1500";  
   damageType        = "Energy";
   
   fire_effect_scale = "1.5";
   hit_effect_scale  = "1.5";
   
   hit_effect_scale  = "1.6";
   
   fire_effect_scale      = "1.6";          
   
   areaEffectScale        = 1.5;   
   areaEffectStartWidth   = 0.25;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.75;  //length taken from beam length
   //areaEffectQuantityScaling  = true; 
   
   areaCollisionEffectScale = 1.6; 
   
   charging_effect_scale = 1.3;  
};

datablock BeamCrystlDatablock(HugeCrystal : SmallCrystal) 
{
   body0_fadeTime     = "0.5 0.5";
   body0_fadeScale    = "2 0";  //focus down, then shrink to nothing
    
   body1_fadeTime     = "0.8 0.8";
   body1_fadeScale    = "0 2";  //heat up, then disperse
   
   baseDamage        = "27";  //damage per ssecond
   thickness         = "40"; 
   beamLength        = "900"; 
   beamLife          = "3000";
   beamRegen         = "2000";  
   damageType        = "Energy";
   
   hit_effect_scale  = "2";
   
   fire_effect_scale      = "2";          
   
   areaEffectScale        = 1.7;   
   areaEffectStartWidth   = 0.25;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.75;  //length taken from beam length 
   //areaEffectQuantityScaling  = true; 
   
   areaCollisionEffectScale = 2; 
   
   charging_effect_scale = 1.5;  
};

///////////////////////////////////////////////
// CIV LASERS
///////////////////////////////////////////////

//KEEP ALL COLOR DATA THE SAME

//Longer range, less damage

datablock BeamCrystlDatablock(SmallCrystal_Civ : SmallCrystal) 
{   
   body0_color       = "1 0.5 0 0.7";   
   body1_color       = "1 0 0 0.4";
   
   thickness         = "15"; 
   
   beamLength        = SmallCrystal.beamLength * 1.333;   
   baseDamage        = SmallCrystal.baseDamage * 0.667;   
};

    
   
datablock BeamCrystlDatablock(MediumCrystal_Civ : MediumCrystal) 
{
   body0_color       = "1 0.5 0 0.7";   
   body1_color       = "1 0 0 0.4";
   
   thickness         = "17.5"; 
   
   beamLength        = MediumCrystal.beamLength * 1.333;   
   baseDamage        = MediumCrystal.baseDamage * 0.667;   
};

datablock BeamCrystlDatablock(LargeCrystal_Civ : LargeCrystal) 
{
   body0_color       = "1 0.5 0 0.7";   
   body1_color       = "1 0 0 0.4";
   
   thickness         = "20.0"; 
   
   beamLength        = LargeCrystal.beamLength * 1.333;   
   baseDamage        = LargeCrystal.baseDamage * 0.667;   
};

datablock BeamCrystlDatablock(HugeCrystal_Civ : HugeCrystal) 
{
   body0_color       = "1 0.5 0 0.7";   
   body1_color       = "1 0 0 0.4";
   
   thickness         = "25.0"; 
   
   beamLength        = HugeCrystal.beamLength * 1.333;   
   baseDamage        = HugeCrystal.baseDamage * 0.667;   
};

///////////////////////////////////////////////
// HEAVY LASERS
///////////////////////////////////////////////

datablock BeamCrystlDatablock(SmallCrystal_Heavy : SmallCrystal) 
{
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   body0_color       = "1 0.5 0 0.7";   
   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "3 0.6"; 
   body1_color       = "0 1 0 0.7";    
   
   fire_sound        = "snd_heavyLaserFire";
   
   baseDamage        = "15";  
   thickness         = "20"; 
   beamLength        = "400"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Universal";
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffect                  = "beamAreaElec";
   areaEffectScale             = 0.7;          
   areaEffectAllowEffectLinger = true; //good for effects not linked to beams
   
   areaCollisionEffect      = "beamAreaCoils"; 
   areaCollisionEffectScale        = 1;   
    
   isConstant = true;  
   chargeTime = 0.5; 
   
   hit_effect_scale  = "1";
   hit_effect_StartBlend = "1 1 0 1"; 
   hit_effect_EndBlend   = "0 1 0 1"; 
   
   fire_effect_scale      = "1";          
   fire_effect_StartBlend = "1 1 0 1";  
   fire_effect_EndBlend   = "0 1 0 1"; 
   
   area_effect_StartBlend = "1 0 0 1";  
   area_effect_EndBlend   = "0 1 0 1";  

   charging_effect_StartBlend = "1 1 0 1";  
   charging_effect_EndBlend   = "0 1 0 1";  
};

datablock BeamCrystlDatablock(MediumCrystal_Heavy : SmallCrystal_Heavy) 
{  
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_scale        = "3 0.6";   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
      
   baseDamage        = "22.5";   //damage per ssecond
   thickness         = "25"; 
   beamLength        = "467"; 
   beamLife          = "800";  //meaningless
   beamRegen         = "300";
   damageType        = "Universal";
   
   hit_effect_scale  = "1.4";
   fire_effect_scale      = "1.4";  
   
   areaEffectStartTime         = 0.2;
   areaEffectScale             = 0.9;          
   areaEffectAllowEffectLinger = true; //good for effects not linked to beams
   
   areaCollisionEffectScale = 1.8;  
   
   charging_effect_scale = 1.15;
   isConstant = true;  
   chargeTime = 0.75; 
};

datablock BeamCrystlDatablock(LargeCrystal_Heavy : SmallCrystal_Heavy) 
{   
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_scale        = "3 0.6";
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
      
   baseDamage        = "34";  //damage per ssecond
   thickness         = "30"; 
   beamLength        = "534"; 
   beamLife          = "1500";  //meaningless
   beamRegen         = "500";
   damageType        = "Universal";
   
   hit_effect_scale  = "1.8";
   fire_effect_scale      = "1.8";  
   
   areaEffectStartTime         = 0.2;
   areaEffectScale             = 1.2;          
   areaEffectAllowEffectLinger = true; //good for effects not linked to beams
   
   areaCollisionEffectScale = 2;   
   
   charging_effect_scale = 1.3;
   isConstant = true;  
   chargeTime = 1.0; 
};

datablock BeamCrystlDatablock(HugeCrystal_Heavy : SmallCrystal_Heavy) 
{
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_scale         = "3 0.6";   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
      
   baseDamage        = "50";   //damage per ssecond
   thickness         = "35"; 
   beamLength        = "600"; 
   beamLife          = "2000"; //meaningless
   beamRegen         = "1000";    
   damageType        = "Universal";
   
   hit_effect_scale  = "2.5";   
   fire_effect_scale      = "2.5";   
   
   areaEffectStartTime         = 0.2;
   areaEffectScale             = 1.6;          
   areaEffectAllowEffectLinger = true; //good for effects not linked to beams
   
   areaCollisionEffectScale = 2.6;    
   
   charging_effect_scale = 1.5;
   isConstant = true;  
   chargeTime = 1.5; 
};

///////////////////////////////////////////////
// ION LASERS
///////////////////////////////////////////////

datablock BeamCrystlDatablock(SmallCrystal_ION : SmallCrystal) 
{
   body0_color       = "0 0 0 0";   //no core
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "3 0.1";
   body1_color       = "0.4 1 0.7 0.3";
   
   fire_sound        = "snd_leechBeamFire";
   fire_soundPuff_Sound    = "snd_leechBeamPuff"; //only for constant style beams
   
   baseDamage        = "5";    
   thickness         = "8"; 
   beamLength        = "600"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Ion";
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffect                  = "beamAreaLeech";
   areaEffectScale             = 0.5;          
   areaEffectAllowEffectLinger = false; //good for effects not linked to beams
   
   areaCollisionEffect             = "beamAreaLeech"; 
   areaCollisionEffectScale        = 0.5; 
   
   hit_effect            = "LeechContact";  
   
   charging_effect_scale = 1;
   isConstant = true;  
   chargeTime = 1; 
   
   hit_effect_scale  = "0.7";
   hit_effect_StartBlend = "1 1 0 1"; 
   hit_effect_EndBlend   = "0 1 1 1"; 
   
   fire_effect_scale      = "0.7";          
   fire_effect_StartBlend = "1 1 0 1";  
   fire_effect_EndBlend   = "0 1 1 1"; 
   
   area_effect_StartBlend = "1 1 0 1";  
   area_effect_EndBlend   = "0 1 1 1";  

   charging_effect_StartBlend = "1 1 0 1";  
   charging_effect_EndBlend   = "0 1 1 1";     
};


datablock BeamCrystlDatablock(MediumCrystal_ION : SmallCrystal_ION) 
{
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "3.5 0.1";
   
   baseDamage        = "8";    //damage = how much mass per second.
   thickness         = "10"; 
   beamLength        = "650"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Ion";
   
   hit_effect_scale  = "0.8";   
   fire_effect_scale      = "0.8";  
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffectScale             = 0.6;          
   areaEffectAllowEffectLinger = false; //good for effects not linked to beams
   
   areaCollisionEffectScale        = 0.6;
   
   charging_effect_scale = 1.15;
   isConstant = true;  
   chargeTime = 1.25; 
};

datablock BeamCrystlDatablock(LargeCrystal_ION : SmallCrystal_ION) 
{
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "4 0.1";
   
   baseDamage        = "12";    //damage = how much mass per second.
   thickness         = "12"; 
   beamLength        = "700"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Ion";
   
   hit_effect_scale  = "0.9";   
   fire_effect_scale      = "0.9";   
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffectScale             = 0.8;          
   areaEffectAllowEffectLinger = false; //good for effects not linked to beams
   areaCollisionEffectScale        = 0.8;
   
   charging_effect_scale = 1.3;
   isConstant = true;  
   chargeTime = 1.5; 
};

datablock BeamCrystlDatablock(HugeCrystal_ION : SmallCrystal_ION) 
{
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "4.5 0.1";
   
   baseDamage        = "20";    
   thickness         = "15"; 
   beamLength        = "800"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Ion";
   
   hit_effect_scale  = "1.0";   
   fire_effect_scale      = "1.0";   
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffectScale             = 1;          
   areaEffectAllowEffectLinger = false; //good for effects not linked to beams
   
   areaCollisionEffectScale        = 1;
      
   charging_effect_scale = 1.5;
   isConstant = true;  
   chargeTime = 2; 
};

///////////////////////////////////////////////
// LEECH LASERS
///////////////////////////////////////////////

datablock BeamCrystlDatablock(SmallCrystal_LEECH : SmallCrystal) 
{
   body0_color       = "0 0 0 0";   //no core
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "3 0.1";
   body1_color       = "0.8 0 1 0.5";
   
   fire_sound        = "snd_gravBeamFire";
   fire_soundPuff_Sound    = "snd_gravBeamPuff"; //only for constant style beams

   baseDamage        = "3";    //150% base reactor output
   thickness         = "20"; 
   beamLength        = "600"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Leech";
   
   hit_effect_scale  = "1";
   fire_effect_scale      = "1";  
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffect                  = "beamAreaGrav";
   areaEffectScale             = 0.7;          
   areaEffectAllowEffectLinger = false; //good for effects not linked to beams
   
   areaCollisionEffect             = "beamAreaGrav"; 
   areaCollisionEffectScale        = 0.7;   
   
   hit_effect            = "GravContact";
   
   charging_effect_scale = 1;
   isConstant = true;  
   chargeTime = 1;
   
   hit_effect_StartBlend = "1 0 1 1"; 
   hit_effect_EndBlend   = "0 0 1 1"; 
      
   fire_effect_StartBlend = "1 0 1 1";  
   fire_effect_EndBlend   = "0 0 1 1"; 
   
   area_effect_StartBlend = "1 0 1 1";  
   area_effect_EndBlend   = "0 0 1 1";  

   charging_effect_StartBlend = "1 0 1 1";  
   charging_effect_EndBlend   = "0 0 1 1";  
};

datablock BeamCrystlDatablock(MediumCrystal_LEECH : SmallCrystal_LEECH) 
{   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "3.5 0.1";
   
   baseDamage        = "9";    //150% base reactor output
   thickness         = "20"; 
   beamLength        = "700"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Leech";
   
   hit_effect_scale  = "1.2";   
   fire_effect_scale      = "1.2";   
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffectScale             = 0.9;          
   areaEffectAllowEffectLinger = false; //good for effects not linked to beams
   
   areaCollisionEffectScale        = 0.9; 
      
   charging_effect_scale = 1.15;
   isConstant = true;  
   chargeTime = 1; 
};


datablock BeamCrystlDatablock(LargeCrystal_LEECH : SmallCrystal_LEECH) 
{   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "4 0.1";
   
   baseDamage        = "27";    //150% base reactor output
   thickness         = "20"; 
   beamLength        = "800"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Leech";
   
   hit_effect_scale  = "1.2";   
   fire_effect_scale      = "1.2"; 
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffectScale             = 1.1;          
   areaEffectAllowEffectLinger = false; //good for effects not linked to beams
   
   areaCollisionEffectScale        = 1.1;
   
   charging_effect_scale = 1.3;
   isConstant = true;  
   chargeTime = 1; 
};

datablock BeamCrystlDatablock(HugeCrystal_LEECH : SmallCrystal_LEECH) 
{
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "4.5 0.1";
   
   baseDamage        = "80";    //150% base reactor output
   thickness         = "20"; 
   beamLength        = "900"; 
   beamLife          = "600";  //meaningless for constant beam
   beamRegen         = "150";
   damageType        = "Leech";
   
   hit_effect_scale  = "1.6";   
   fire_effect_scale      = "1.6"; 
   
   areaEffectStartTime         = 0.2;  //longer timed beam so let the effect come in over time to make it look hotter. 
   areaEffectScale             = 1.4;          
   areaEffectAllowEffectLinger = false; //good for effects not linked to beams
   
   areaCollisionEffectScale        = 1.4;
   
   charging_effect_scale = 1.5;
   isConstant = true;  
   chargeTime = 1; 
};

///////////////////////////////////////////////
// Specials ///////////////////////////////////
///////////////////////////////////////////////

datablock BeamCrystlDatablock(MothershipCrystal : BeamCrystalBase) 
{
   body0_color        = "1 1 0.2 0.7";    
   body0_scale        = "0.6 0.8";
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "5 0";   //focus, shrink  
  
   body1_scale        = "4 0.8";
   body1_color        = "1 0 0 0.4";  
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   
   baseDamage        = "500";   //damage per ssecond
   thickness         = "70"; 
   beamLength        = "6000"; 
   beamLife          = "5000";  
   beamRegen         = "20000";
   damageType        = "Energy";   
   fire_sound        = "snd_hugeLaserFire";
   fire_soundPuff_Sound    = "snd_hugeLaserPuff"; //only for constant style beams
   
   hit_effect_scale  = "3";
   hit_effect_StartBlend = "1 0.6 0 1"; 
   hit_effect_EndBlend   = "1 0 0 1"; 
   
   fire_effect_scale      = "3";          
   fire_effect_StartBlend = "1 0.6 0 1";  
   fire_effect_EndBlend   = "1 0 0 1";
   
   areaEffect             = "beamAreaCoilsLarge";
   areaEffectScale        = 1;   
   area_effect_StartBlend = "1 1 0 1";  
   area_effect_EndBlend   = "1 0 0 1";  
   areaEffectStartWidth   = 0.2;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.2;  //length taken from beam length  
   areaEffectAllowEffectLinger = false; 
   //areaEffectQuantityScaling  = true; 
   
   
   areaCollisionEffectScale = 4; 
   
   charging_effect_scale = 1.5;
   charging_effect_StartBlend = "1 0.6 0 1";  
   charging_effect_EndBlend   = "1 0 0 1";
   isConstant = false;  
   chargeTime = 0;   
   
   skipTechModifiers = true;
};

datablock BeamCrystlDatablock(MothershipCrystal_super : MothershipCrystal) 
{
   body0_color        = "0.2 1 1 0.7";    
   body0_scale        = "0.6 0.8";
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "5 0";   //focus, shrink  
  
   body1_scale        = "4 0.8";
   body1_color        = "1 0 1 0.4";  
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   
   
   baseDamage        = "5000";   //Crrrrrrrrrrrrrrrrrrrrrusha!
   thickness         = "60"; 
   beamLength        = "8000"; 
   beamLife          = "15000";  
   beamRegen         = "30000";
   damageType        = "AntiZombie";   //Only use this here. it is a beam that the zombie mothership can be imune to damage wise. 
   fire_sound        = "snd_hugeLaserFire";
   fire_soundPuff_Sound    = "snd_hugeLaserPuff"; //only for constant style beams
   
   hit_effect_scale  = "3";
   hit_effect_StartBlend = "0.5 0.5 1 1"; 
   hit_effect_EndBlend   = "0 0 1 1"; 
   
   fire_effect_scale      = "3";          
   fire_effect_StartBlend = "0.5 0.5 1 1";  
   fire_effect_EndBlend   = "0 0 1 1";
   
   areaEffect             = "beamAreaCoilsLarge";
   areaEffectScale        = 1;   
   area_effect_StartBlend = "0.5 0.5 1 1";  
   area_effect_EndBlend   = "0 0 1 1";  
   areaEffectStartWidth   = 0.2;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.2;  //length taken from beam length  
   areaEffectAllowEffectLinger = false; 
   //areaEffectQuantityScaling  = true; 
   
   
   areaCollisionEffectScale = 4; 
   
   charging_effect_scale = 1.5;
   charging_effect_StartBlend = "0.5 0.5 1 1";  
   charging_effect_EndBlend   = "0 0 1 1";
   isConstant = false;  
   chargeTime = 0;   
   
   skipTechModifiers = true;
};

datablock BeamCrystlDatablock(MothershipCrystal_zombie : MothershipCrystal) 
{
   body0_color        = "0 0 0 1";    
   body0_scale        = "0.6 0.8";
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink 
   body0_isIntense    = false;
  
   body1_scale        = "4 0.8";
   body1_color        = "1 0 1 0.7";  
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   
   
   baseDamage        = "50";   
   thickness         = "60"; 
   beamLength        = "2000"; 
   beamLife          = "5000";  
   beamRegen         = "5000";
   damageType        = "Zombify";   
   fire_sound        = "snd_hugeLaserFire";
   fire_soundPuff_Sound    = "snd_hugeLaserPuff"; //only for constant style beams
   
   hit_effect_scale  = "3";
   hit_effect_StartBlend = "1 0 1 1"; 
   hit_effect_EndBlend   = "1 0 0 1"; 
   
   fire_effect            = "LaserCharge_zombie";
   fire_effect_scale      = "1";          
   fire_effect_StartBlend = "1 0 1 1";  
   fire_effect_EndBlend   = "1 0 0 1";
   
   areaEffect             = "beamAreaCorruption";
   areaEffectScale        = 1;   
   area_effect_StartBlend = "1 1 1 1";  
   area_effect_EndBlend   = "1 1 1 0";  
   areaEffectStartWidth   = 0.2;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.2;  //length taken from beam length  
   areaEffectAllowEffectLinger = true; 
   //areaEffectQuantityScaling  = true; 
   
   areaCollisionEffectScale = 4; 
   
   charging_effect            = "LaserCharge_zombie";
   charging_effect_scale = 1;
   charging_effect_StartBlend = "1 0 1 1";  
   charging_effect_EndBlend   = "1 0 0 1";
   isConstant = false;  
   chargeTime = 0;   
   
   skipTechModifiers = true;
};

///////////////////////////////////////////////
// Tractor ////////////////////////////////////
///////////////////////////////////////////////

datablock BeamCrystlDatablock(TractorCrystal_medium : BeamCrystalBase) 
{
   body0_color        = "0.2 0.2 0.2 0.7";  
   body1_color        = "0.6 0.6 0.7 0.4";
   
   fire_sound        = "snd_tractorAttach";     
   
   
   baseDamage        = "0";   //damage per ssecond
   thickness         = "20"; 
   beamLength        = "350"; 
   beamLife          = "1000";
   beamRegen         = "100";
   damageType        = "Energy";
   
   collisionOverride = $COLLISION_GROUPS_PICKUPS;

   hit_effect            = "LaserCut";
   hit_effect_scale  = "2";
   hit_effect_StartBlend = "0.6 1 1 1"; 
   hit_effect_EndBlend   = "0 0 0 1"; 
   
   fire_effect            = "TractorFire";
   fire_effect_scale      = "2";          
   fire_effect_StartBlend = "0.6 1 1 1";  
   fire_effect_EndBlend   = "0 0 1 1"; 
   
   //note:  when i make heavy beams that are constant i may be able to apply that tech to this to allow fading
   //but for now. no fading for tractors.
   body0_fadeTime     = "0 0";  //tractor beam life is SUPER long so fade time wont work
   body1_fadeTime     = "0 0";  //tractor beam life is SUPER long so fade time wont work
   
   areaEffectStartTime    = 0;  //again need to use 0 here since the beam life is sooooooo long
   areaEffectEndTime      = 0;  //effect wont end until the object reaches the emitter

   //no collision effect with tractors.  they dont collide.  the beam is just for show
   //make the collision effect part of the tractor area effect as a work around
   areaEffect             = "beamAreaTractor";
   areaEffectScale        = 0.5;   
   areaEffectStartWidth   = 0.1;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.1;  //length taken from beam length 
   areaEffectAllowEffectLinger = true; 
   
   isConstant = true;  
   chargeTime = 0; 
   
   researchDatablock = "SubSystemResearch";
};

datablock BeamCrystlDatablock(TractorCrystal_large : TractorCrystal_medium) 
{
   thickness         = "20"; 
   beamLength        = "700"; 
};

datablock BeamCrystlDatablock(TractorCrystal_huge : TractorCrystal_medium) 
{
   thickness         = "20"; 
   beamLength        = "1000"; 
};


datablock BeamCrystlDatablock(MiningTractorCrystal : TractorCrystal_medium) 
{
   thickness         = "20"; 
   beamLength        = "300"; 
   
   fire_effect_scale = "1";
   hit_effect_scale  = "1";
   
   //bugged people
   //collisionOverride = BIT( $COLLISION_ID_RESOURCE_ROCKS );
};

//For picking up datacubes.  all ships get one. 
datablock BeamCrystlDatablock(MicroTractorCrystal : TractorCrystal_medium) 
{ 
   thickness         = "20"; 
   beamLength        = "300"; 

   fire_effect_scale = "1";
   hit_effect_scale  = "1";
   
   collisionOverride = BIT( $COLLISION_ID_DATA_CUBES );
};

///////////////////////////////////////////////
// Mining /////////////////////////////////////
///////////////////////////////////////////////

datablock BeamCrystlDatablock(SmallMinerCrystal : BeamCrystalBase) 
{      
   body0_color       = "0.5 0.5 1 0.7";  
   body0_fadeTime    = "0.2 0.2";
   body0_fadeScale   = "2 0";  //focus down, then shrink to nothing
   
   body1_color       = "0.3 0.3 0.8 0.4";
   body1_fadeTime    = "0.4 0.4";
   body1_fadeScale   = "0 2";  //heat up, then disperse
   
   baseDamage        = "4";  //damage per ssecond
   thickness         = "20"; 
   beamLength        = "350"; 
   beamLife          = "750";
   beamRegen         = "500";
   damageType        = "Heat";   
   
   hit_effect_scale  = "1";
   hit_effect_StartBlend = "0.9 0.9 1 1"; 
   hit_effect_EndBlend   = "0 0 1 1"; 
   
   fire_effect_scale      = "1";          
   fire_effect_StartBlend = "0.9 0.9 1 1";  
   fire_effect_EndBlend   = "0 0 1 1"; 
   
   areaEffect             = "beamAreaWaves";
   areaEffectScale        = 1;   
   area_effect_StartBlend = "0.7 0.7 1 1";  
   area_effect_EndBlend   = "0 0 1 1";  
   areaEffectStartWidth   = 0.25;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.75;  //length taken from beam length 
   
   charging_effect_scale = 1;
   charging_effect_StartBlend = "0.9 0.9 1 1";  
   charging_effect_EndBlend   = "0 0 1 1"; 
   isConstant = false;  
   chargeTime = 0.1;   
   
   researchDatablock = "SubSystemResearch";
};


datablock BeamCrystlDatablock(MediumMinerCrystal : SmallMinerCrystal) 
{
   body0_fadeTime    = "0.25 0.25";
   body0_fadeScale   = "2 0";  //focus down, then shrink to nothing
   
   body1_fadeTime    = "0.5 0.5";
   body1_fadeScale   = "0 2";  //heat up, then disperse
   
   
   baseDamage        = "6";   //damage per ssecond
   thickness         = "20"; 
   beamLength        = "600"; 
   beamLife          = "1000";
   beamRegen         = "1000";
   damageType        = "Heat";
   
   fire_effect_scale = "1.2";
   hit_effect_scale  = "1.2";
   
   charging_effect_scale = 1.15;
   isConstant = false;  
   chargeTime = 0.2;   
   
};

//used by star bases for picking larger asteroids
datablock BeamCrystlDatablock(LargeMinerCrystal : SmallMinerCrystal) 
{   
   body0_fadeTime    = "0.4 0.4";
   body0_fadeScale   = "2 0";  //focus down, then shrink to nothing
   
   body1_fadeTime    = "0.6 0.6";
   body1_fadeScale   = "0 2";  //heat up, then disperse
   
   baseDamage        = "9";  //damage per ssecond
   thickness         = "30"; 
   beamLength        = "1200"; 
   beamLife          = "2000";
   beamRegen         = "2000";
   damageType        = "Heat";
   
   fire_effect_scale = "1.5";
   hit_effect_scale  = "1.5";
   
   charging_effect_scale = 1.3;
   isConstant = false;  
   chargeTime = 0.5; 
};


//This is what mining station fire at rocks
datablock BeamCrystlDatablock(HugeCoreMinerCrystal : SmallMinerCrystal) 
{
   body0_scale       = "0.25 0.6"; 
   body0_fadeTime    = "0.5 0.5";
   body0_fadeScale   = "2 0";  //focus down, then shrink to nothing
   
   body1_scale       = "3 0.6";
   body1_fadeTime    = "0.8 0.8";
   body1_fadeScale   = "0 2";  //heat up, then disperse
  
   baseDamage        = "15";   //damage per ssecond
   thickness         = "55"; 
   beamLength        = "1700"; 
   beamLife          = "4000";
   beamRegen         = "8000";
   damageType        = "CoreMiner";
   
   specialCollision  = bit($COLLISION_ID_MOTHER_ROCK);
   
   fire_effect_scale = "2";
   hit_effect_scale  = "2";
   
   fire_sound        = "snd_hugeLaserFire";
   
   areaEffectScale        = 3;  
   areaCollisionEffectScale = 1.5; 
   areaCollisionEffect      = "beamAreaCoils";    
   
   charging_effect_scale = 1.5;
   isConstant = false;  //if true will drain starbases dry  
   chargeTime = 3; 
};


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Point Defense //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

datablock BeamCrystlDatablock(POINTDEF_Crystal_S : BeamCrystalBase) 
{   
   fire_sound        = "snd_microLaserFire";  
   
   body0_color       = "1 0.6 0.6 0.7";   
   body0_fadeTime    = "0.1 0.1";
   body0_fadeScale   = "0 0";  
   
   body1_color       = "1 0 0 0.4";
   body1_fadeTime    = "0.2 0.2";
   body1_fadeScale   = "0 0";  
   
   baseDamage        = "23";  
   thickness         = "8"; 
   beamLength        = "500"; 
   beamLife          = "1000";
   beamRegen         = "1400";
   damageType        = "PointDef";
   
   fire_effect            = "MicroFire";
   hit_effect            = "MicroImpact";    
   
   hit_effect_scale  = "0.9";
   hit_effect_StartBlend = "1 1 0 1"; 
   hit_effect_EndBlend   = "1 0.2 0 1"; 
   
   fire_effect_scale      = "0.4";          
   fire_effect_StartBlend = "1 1 0 1";  
   fire_effect_EndBlend   = "1 0.2 0 1"; 
   
   isConstant = false;  //these types of beams will fire for as long as there is power, or desire to fire them
   chargeTime = 0;  //if 0, beam does not use charging

   researchDatablock = "SubSystemResearch";
};

datablock BeamCrystlDatablock(POINTDEF_Crystal_M : POINTDEF_Crystal_S) 
{     
   
   baseDamage        = "37";  
   thickness         = "10"; 
   beamLength        = "600"; 
   beamLife          = "1000";
   beamRegen         = "1100";
        
   hit_effect_scale  = "1";     
   fire_effect_scale      = "0.5";        
  
};

datablock BeamCrystlDatablock(POINTDEF_Crystal_L : POINTDEF_Crystal_S) 
{
   baseDamage        = "52";  
   thickness         = "12";
   beamLength        = "700"; 
   beamLife          = "1000";
   beamRegen         = "800";  //longer regen to simulate scanning
   
   hit_effect_scale  = "1.2";     
   fire_effect_scale      = "0.6";      
};

datablock BeamCrystlDatablock(POINTDEF_Crystal_H : POINTDEF_Crystal_S) 
{
   baseDamage        = "75";  
   thickness         = "14";
   beamLength        = "800"; 
   beamLife          = "1000";
   beamRegen         = "500";  //longer regen to simulate scanning
   
   hit_effect_scale  = "1.4";     
   fire_effect_scale      = "0.75";  
};

///////////////////////////////////////////////////////////
// Zombie Corruption Beams ////////////////////////////////
///////////////////////////////////////////////////////////

datablock BeamCrystlDatablock(CORRUPTION_Crystal_S : BeamCrystalBase) 
{   
   fire_sound        = "snd_microLaserFire";  
   
   body0_color        = "0 0 0 1";    
   body0_scale        = "0.6 0.8";
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink 
   body0_isIntense    = false;
  
   body1_scale        = "5 0.1";
   body1_color        = "1 0 1 0.4";  
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   
   baseDamage        = "5";  
   thickness         = "10"; 
   beamLength        = "500"; 
   beamLife          = "1000";  
   beamRegen         = "2000";
   damageType        = "Corruption";
   
   hit_effect_scale  = "1";
   hit_effect_StartBlend = "1 0 1 1"; 
   hit_effect_EndBlend   = "1 0 0 1"; 
   
   fire_effect            = "LaserCharge";
   fire_effect_scale      = "1";          
   fire_effect_StartBlend = "1 0 1 1";  
   fire_effect_EndBlend   = "1 0 0 1";
   
   areaEffect             = "beamAreaCorruption_small";
   areaEffectScale        = 1;   
   area_effect_StartBlend = "1 1 1 1";  
   area_effect_EndBlend   = "1 1 1 0";  
   areaEffectStartWidth   = 0.2;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.2;  //length taken from beam length  
   areaEffectAllowEffectLinger = true; 
   //areaEffectQuantityScaling  = true; 
   
   areaCollisionEffect      = "beamAreaCorruption_small";  
   areaCollisionEffectScale = 1;   
   
   isConstant = false;  //these types of beams will fire for as long as there is power, or desire to fire them
   chargeTime = 0;  //if 0, beam does not use charging

   researchDatablock = "SubSystemResearch";
};

datablock BeamCrystlDatablock(CORRUPTION_Crystal_M : CORRUPTION_Crystal_S) 
{    
   baseDamage        = "7";  
   thickness         = "12"; 
   beamLength        = "650";    
   beamLife          = "1000";  
   beamRegen         = "1700";
   
   areaCollisionEffectScale = 1;   
   areaEffectScale        = 1; 
   hit_effect_scale  = "1";
   fire_effect_scale      = "1";    
};

datablock BeamCrystlDatablock(CORRUPTION_Crystal_L : CORRUPTION_Crystal_S) 
{   
   baseDamage        = "9";   
   thickness         = "14"; 
   beamLength        = "800";  
   beamLife          = "1000";  
   beamRegen         = "1400";
   
   areaCollisionEffectScale = 1.3;   
   areaEffectScale        = 1.3; 
   hit_effect_scale  = "1.3";
   fire_effect_scale      = "1.3";   
};

datablock BeamCrystlDatablock(CORRUPTION_Crystal_H : CORRUPTION_Crystal_S) 
{    
   baseDamage        = "12";   
   thickness         = "17"; 
   beamLength        = "1000";
   beamLife          = "1000";  
   beamRegen         = "1000";
   
   areaCollisionEffectScale = 1.5;   
   areaEffectScale        = 1.5; 
   hit_effect_scale  = "1.5";
   fire_effect_scale      = "1.5"; 
};

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Scanners /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


datablock BeamCrystlDatablock(SCANNER_Crystal_S : BeamCrystalBase) 
{   
   fire_sound        = "snd_microScannerFire";     
   
   body0_color       = "0 1 0.5 0.7";   
   body0_fadeTime    = "0.1 0.1";
   body0_fadeScale   = "0 0";  
   
   body1_color       = "0.5 1 1 0.4";
   body1_fadeTime    = "0.2 0.2";
   body1_fadeScale   = "0 0";  
   
   
   baseDamage        = "0.0002";  
   thickness         = "8"; 
   beamLength        = "350"; 
   beamLife          = "200";
   beamRegen         = "1000";  //longer regen to simulate scanning
   damageType        = "Energy";
   
   hit_effect            = "ScannerContact";
   hit_effect_scale  = "0.9";
   hit_effect_StartBlend = "1 1 1 1"; 
   hit_effect_EndBlend   = "0 1 1 1"; 
   
   fire_effect_scale      = "0.6";          
   fire_effect_StartBlend = "1 1 1 1";  
   fire_effect_EndBlend   = "0 1 1 1";
   
   areaEffect             = "beamAreaScanner";
   areaEffectScale        = 0.75;   
   areaEffectStartWidth   = 0.1;   //this is a % of beam thickness, >1 is ok
   areaEffectEndWidth     = 0.1;  //length taken from beam length 
   areaEffectAllowEffectLinger = true;  
   
   isConstant = false;  //these types of beams will fire for as long as there is power, or desire to fire them
   chargeTime = 0;  //if 0, beam does not use charging

   researchDatablock = "SubSystemResearch";
};

datablock BeamCrystlDatablock(SCANNER_Crystal_M : SCANNER_Crystal_S) 
{      
   thickness         = "10"; 
   beamLength        = "450"; 
   beamLife          = "200";
   beamRegen         = "750";  //longer regen to simulate scanning
         
   hit_effect_scale  = "1";   
   fire_effect_scale      = "0.7";          
};

datablock BeamCrystlDatablock(SCANNER_Crystal_L : SCANNER_Crystal_M) 
{
   beamLength        = "550"; 
   beamLife          = "550";
   beamRegen         = "500";  //longer regen to simulate scanning
};

datablock BeamCrystlDatablock(SCANNER_Crystal_H : SCANNER_Crystal_M) 
{
   beamLength        = "700"; 
   beamLife          = "750";
   beamRegen         = "300";  //longer regen to simulate scanning
};

//Surplus scanners, free from start. 
datablock BeamCrystlDatablock(SCANNER_Crystal_S_SURPLUS : SCANNER_Crystal_S) 
{
   beamLength        = "250"; 
   beamLife          = "200";
   beamRegen         = "8000"; 
};

datablock BeamCrystlDatablock(SCANNER_Crystal_M_SURPLUS : SCANNER_Crystal_S_SURPLUS) 
{
   beamLength        = "350"; 
   beamLife          = "300";
   beamRegen         = "7000"; 
};

datablock BeamCrystlDatablock(SCANNER_Crystal_L_SURPLUS : SCANNER_Crystal_S_SURPLUS) 
{
   beamLength        = "450"; 
   beamLife          = "300";
   beamRegen         = "6000"; 
};

datablock BeamCrystlDatablock(SCANNER_Crystal_H_SURPLUS : SCANNER_Crystal_S_SURPLUS) 
{
   beamLength        = "550"; 
   beamLife          = "400";
   beamRegen         = "5000"; 
};

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// DRONE Energy Beams /////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

datablock BeamCrystlDatablock(DRONE_MicroLaserCrystal : BeamCrystalBase) 
{   
   fire_sound        = "snd_microLaserFire";  
   
   body0_color       = "0.5 1 0 0.7";   
   body0_fadeTime    = "0.1 0.1";
   body0_fadeScale   = "0 0";  
   
   body1_color       = "1 1 0 0.4";
   body1_fadeTime    = "0.2 0.2";
   body1_fadeScale   = "0 0";  
   
   
   baseDamage        = "6";  //damage per ssecond (note: we only fire for 0.1 second so this damage is ok)
   thickness         = "30"; 
   beamLength        = "300"; 
   beamLife          = "200";
   beamRegen         = "1000";
   damageType        = "Energy";

   fire_effect            = "MicroFire";
   hit_effect            = "MicroImpact";    
   
   hit_effect_scale  = "1";
   hit_effect_StartBlend = "1 1 0 1"; 
   hit_effect_EndBlend   = "0.667 0.333 0 1"; 
   
   fire_effect_scale      = "1";          
   fire_effect_StartBlend = "1 1 0 1";  
   fire_effect_EndBlend   = "0.667 0.333 0 1"; 
   
   charging_effect_scale      = 0.8;  
   
   isConstant = false;  //these types of beams will fire for as long as there is power, or desire to fire them
   chargeTime = 0;  //if 0, beam does not use charging

};


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// MINE Energy Beams /////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Make work the same as drones.
datablock BeamCrystlDatablock(MINE_MicroLaserCrystal : DRONE_MicroLaserCrystal) 
{   
   body0_color        = "0 0 0 0";   //no core
   body0_fadeTime     = "0.4 0.2";  //quick fade out of core beam
   body0_fadeScale    = "4 0";   //focus, shrink  
   
   body1_fadeTime     = "0.4 0.4";
   body1_fadeScale    = "2 3";   //heat up, disperse   
   body1_scale        = "3 0.1";
   body1_color        = "0.4 1 0.7 0.3";
   
   damageType        = "Ion";
   
   beamLength        = "500"; 
   baseDamage        = "30";
   thickness         = "12"; 
   
   beamLife          = "250";
   beamRegen         = "750";
   placeholder = true;
};

