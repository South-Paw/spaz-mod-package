
////////////////////////////////////////////////////////////////////////////////
//sound cue database
////////////////////////////////////////////////////////////////////////////////

//base

$randomChatterSet = new SimSet() {};

function SoundCueDatablock::OnAdd(%this)
{
   //echo("Adding Sound Cue:" SPC %this.getName()); 
   
   if (%this.isRandomChatter == true)
      $randomChatterSet.add(%this);
}

datablock SoundCueDatablock(snd_base) 
{
   soundList = "";
   pitchShiftDown = 0; //no more then 2 or 3 or we'll lose sound quality
   pitchShiftUp = 0;  //no more then 2 or 3 or we'll lose sound quality
   
   volumeMult      = 1; //allows tuning without fiddling with sound files. 
   
   maxRangeShift   = 0; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
   soundRangeMult  = 1.0;  //how far away can sound be heard compared to code defined max range.
   falloffExponent = 1; //2 = sound remains loud out to long range, 1 = linear falloff, 0.5 = quick sound falloff.
                        //low sounds should use 2, high sounds should use 0.5. can be any number BTW, so 0.333 is legal etc..
                        
   isRandomChatter = false;
};

//loops


datablock SoundCueDatablock(snd_loop_thrusterTiny: snd_base) 
{
   soundList = "loop_thrusterTiny";
   
   //good for engines:
   falloffExponent = 0.66;  
   soundRangeMult = 0.65;
   maxRangeShift   = -2; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
};

datablock SoundCueDatablock(snd_loop_thrusterSmall: snd_base) 
{
   soundList = "loop_thrusterSmall";
   
   //good for engines:
   falloffExponent = 0.66;  
   soundRangeMult = 0.85;
   maxRangeShift   = -2; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
};

datablock SoundCueDatablock(snd_loop_thrusterLarge: snd_base) 
{
   soundList = "loop_thrusterLarge";
   
   //good for engines:
   falloffExponent = 0.66;  
   soundRangeMult = 1.6;
   maxRangeShift   = -2; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
};

//sounds

datablock SoundCueDatablock(snd_squash : snd_base) 
{
   soundRangeMult = 0.6;
   falloffExponent = 0.5;
   soundList = "squash_01 squash_03 squash_04 squash_05";
};

datablock SoundCueDatablock(snd_squash_wo_scream : snd_base) 
{
   soundRangeMult = 0.6;
   falloffExponent = 0.5;
   soundList = "squash_02 squash_06";
};

datablock SoundCueDatablock(snd_squash_zom : snd_base) 
{
   soundRangeMult = 0.6;
   falloffExponent = 0.5;
   soundList = "squash_zom_01 squash_zom_02 squash_zom_03 squash_zom_04";
};

datablock SoundCueDatablock(snd_space_scream : snd_base) 
{
   soundRangeMult = 0.6;
   falloffExponent = 0.5;
   soundList = "space_scream_01 space_scream_02 space_scream_03 space_scream_04";
};

//lasers

datablock SoundCueDatablock(snd_microLaserFire : snd_base) 
{
   soundRangeMult = 0.4;
   soundList = "microLaserFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_microScannerFire : snd_base) 
{
   soundRangeMult = 0.6;
   soundList = "microScannerFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_smallLaserFire : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "smallLaserFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_rapidLaserFire : snd_base) 
{
   soundList = "rapidLaserFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_heavyLaserFire : snd_base) 
{
   soundList = "heavyLaserFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_heavyLaserPuff : snd_base) 
{
   soundRangeMult = 0.6;
   soundList = "heavyLaserFire_01_puff";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
};

datablock SoundCueDatablock(snd_leechBeamFire : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "leechBeamFire";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_leechBeamPuff : snd_base) 
{
   soundRangeMult = 0.6;
   soundList = "leechBeamPuff";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_gravBeamFire : snd_base)  
{
   soundRangeMult = 0.8;
   soundList = "gravBeamFire";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_gravBeamPuff : snd_base)  
{
   soundRangeMult = 0.6;
   soundList = "gravBeamPuff";
   pitchShiftDown = -0.5;
   pitchShiftUp = 0.5; 
};

datablock SoundCueDatablock(snd_hugeLaserFire : snd_base) 
{
   soundList = "hugeLaserFire_01";
   pitchShiftDown = -0.5;
   pitchShiftUp = 0.5; 
};

datablock SoundCueDatablock(snd_hugeLaserPuff : snd_base) 
{
   soundList = "hugeLaserFire_01_puff";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
};

datablock SoundCueDatablock(snd_smallLaserHit : snd_base) 
{
   soundRangeMult = 0.65;
   soundList = "smallLaserHit_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

//projectiles

datablock SoundCueDatablock(snd_smallProjectileFire : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "smallProjectileFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_microProjectileFire : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "microProjectileFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_pulseFire : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "pulseFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_massDriverFire : snd_base) 
{
   soundList = "massDriverFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_clusterProjectileFire : snd_base) 
{
   soundRangeMult = 0.7;
   soundList = "clusterProjectileFire_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};


datablock SoundCueDatablock(snd_smallProjectileHit : snd_base) 
{
   soundRangeMult = 0.6;
   soundList = "smallProjectileHit_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_zombieSpitting : snd_base) 
{
   soundRangeMult = 0.6;
   soundList = "zombieSpitting_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

//cargo

datablock SoundCueDatablock(snd_smallCargoPickup : snd_base) 
{
   soundRangeMult = 0.6;
   soundList = "smallCargoPickup_01";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
};

datablock SoundCueDatablock(snd_tractorAttach : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "tractorAttach";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
};

datablock SoundCueDatablock(snd_massiveWave : snd_base) 
{
   soundList = "massiveWave_01";
   pitchShiftDown = -0.01;
   pitchShiftUp = 0.01; 
};

datablock SoundCueDatablock(snd_asteroidExplosion : snd_base) 
{
   soundList = "asteroidExplosion_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

datablock SoundCueDatablock(snd_cometExplosion : snd_base) 
{
   soundList = "cometExplosion_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
   
   maxRangeShift   = -2.5; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
   soundRangeMult  = 2;  //how far away can sound be heard compared to code defined max range.
   falloffExponent = 1.8; //2 = sound remains loud out to long range, 1 = linear falloff, 0.5 = quick sound falloff.
};

datablock SoundCueDatablock(snd_smallExplosion : snd_base) 
{
   soundRangeMult = 0.7;
   soundList = "smallExplosion_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

datablock SoundCueDatablock(snd_smallExplosion_cascade : snd_base) 
{
   soundList = "smallExplosion_cascade";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_mediumExplosion : snd_base) 
{
   soundList = "mediumExplosion_01 mediumExplosion_02";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_mediumExplosion_ship : snd_base) //does not differ from medium explosion, but seperated for halloween pack
{
   soundList = "mediumExplosion_01 mediumExplosion_02";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_massBombExplosion : snd_base) 
{
   soundList = "massBombExplosion_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

datablock SoundCueDatablock(snd_resonateExplode : snd_base) 
{
   soundList = "resonateExplode_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

datablock SoundCueDatablock(snd_bigExplosion : snd_base) 
{
   soundList = "bigExplosion_01 bigExplosion_02 bigExplosion_03";
   pitchShiftDown = -1;
   pitchShiftUp = 1;
   
   maxRangeShift   = -2; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
   soundRangeMult  = 1.5;  //how far away can sound be heard compared to code defined max range.
   falloffExponent = 1.2; //2 = sound remains loud out to long range, 1 = linear falloff, 0.5 = quick sound falloff.
};

datablock SoundCueDatablock(snd_bigExplosion_zombie : snd_base) 
{
   soundList = "bigExplosion_zombie_01";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
   
   maxRangeShift   = -2; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
   soundRangeMult  = 1.5;  //how far away can sound be heard compared to code defined max range.
   falloffExponent = 1.2; //2 = sound remains loud out to long range, 1 = linear falloff, 0.5 = quick sound falloff.
};

datablock SoundCueDatablock(snd_hugeExplosion : snd_base) 
{
   soundList = "hugeExplosion_01";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
   
   maxRangeShift   = -2.5; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
   soundRangeMult  = 2;  //how far away can sound be heard compared to code defined max range.
   falloffExponent = 1.8; //2 = sound remains loud out to long range, 1 = linear falloff, 0.5 = quick sound falloff.
};

datablock SoundCueDatablock(snd_hugeExplosion_zombie : snd_base) 
{
   soundList = "hugeExplosion_zombie_01";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
   
   maxRangeShift   = -2.5; //shifts pitch by this much * percent of max range.  so if -2, then at max range the pitch would be whatever initial pitch was -2
   soundRangeMult  = 2;  //how far away can sound be heard compared to code defined max range.
   falloffExponent = 1.8; //2 = sound remains loud out to long range, 1 = linear falloff, 0.5 = quick sound falloff.
};

datablock SoundCueDatablock(snd_zombie_wakeup : snd_base) 
{
   soundRangeMult = 0.7;
   soundList = "zombie_wakeup_01 zombie_wakeup_02 zombie_wakeup_03";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
};

//missiles

datablock SoundCueDatablock(snd_missileReload : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "missileReload_sound01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 0.5; 
};

datablock SoundCueDatablock(snd_smallMissileLaunch : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "smallMissileFlare_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 0.5; 
};

datablock SoundCueDatablock(snd_turretDeploy : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "turretDeploy_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 0.5; 
};

datablock SoundCueDatablock(snd_rapidMissileLaunch : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "rapidMissileFlare_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

datablock SoundCueDatablock(snd_smallTorpLaunch : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "smallTorpFlare_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

datablock SoundCueDatablock(snd_smallShieldFail : snd_base) 
{
   soundList = "shieldFail_01";
   pitchShiftDown = -1;
   pitchShiftUp = 1; 
};

datablock SoundCueDatablock(snd_cloakEngage : snd_base) 
{
   soundList = "cloakEngage_01";
   pitchShiftDown = -0.2;
   pitchShiftUp = 0.2; 
};

datablock SoundCueDatablock(snd_cloakLost : snd_base) 
{
   soundList = "cloakLost_01";
   pitchShiftDown = -0.2;
   pitchShiftUp = 0.2; 
};

datablock SoundCueDatablock(snd_reactorCritical : snd_base) 
{
   soundList = "reactorCritical_01";
};

datablock SoundCueDatablock(snd_reactorExplosion : snd_base) 
{
   soundList = "reactorExplosion_01";
};

datablock SoundCueDatablock(snd_reactorImplosion : snd_base) 
{
   soundList = "reactorImplosion_01";
};

datablock SoundCueDatablock(snd_armorHit : snd_base) 
{
   soundRangeMult = 0.7;
   soundList = "armorHit_01 hullHit_01 armorHit_01 hullHit_02"; //includes hull hit effects, but mostly armor ping
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_hullHit : snd_base) 
{
   soundRangeMult = 0.7;
   soundList = "hullHit_01 hullHit_02";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_hullHit_zombie : snd_base) 
{
   soundRangeMult = 0.7;
   soundList = "hullHit_zombie_01 hullHit_zombie_02 hullHit_zombie_03 hullHit_zombie_04";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

//warp effects

datablock SoundCueDatablock(snd_shipWarp_01 : snd_base) 
{
   soundList = "shipWarp_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = -1.4; 
};

datablock SoundCueDatablock(snd_beaconWarp_01 : snd_base) 
{
   soundList = "beaconWarp_01";
   pitchShiftDown = -1.5;
   pitchShiftUp = -1.4; 
};

//escape pods and abandon ship

datablock SoundCueDatablock(snd_escapePodEject_small : snd_base) 
{
   soundRangeMult = 0.6;
   soundList = "escapePodEject_small";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

datablock SoundCueDatablock(snd_escapePodEject_large : snd_base) 
{
   soundRangeMult = 0.7;
   soundList = "escapePodEject_large";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

datablock SoundCueDatablock(snd_abandonShipAlarm : snd_base) 
{
   soundList = "abandonShipAlarm";
};

datablock SoundCueDatablock(snd_shuttleLaunch : snd_base) 
{
   soundRangeMult = 0.8;
   soundList = "shuttleLaunch";
   pitchShiftDown = -1.5;
   pitchShiftUp = 1.5; 
};

//interface

datablock SoundCueDatablock(snd_buttonClickPositive : snd_base) 
{
   soundList = "buttonClickPositive";
};

datablock SoundCueDatablock(snd_calloutCue: snd_base) 
{
   soundList = "calloutCue";
};

datablock SoundCueDatablock(snd_resourceCollect: snd_base) 
{
   soundList = "resourceCollect";
};


datablock SoundCueDatablock(snd_dataCollect: snd_base) 
{
   soundList = "dataCollect";
};

datablock SoundCueDatablock(snd_windowExpand : snd_base) 
{
   soundList = "windowExpand";
};

datablock SoundCueDatablock(snd_windowInstall : snd_base) 
{
   soundList = "windowInstall";
};

datablock SoundCueDatablock(snd_windowPurchase : snd_base) 
{
   soundList = "windowPurchase";
};

datablock SoundCueDatablock(snd_windowResearch : snd_base) 
{
   soundList = "windowResearch";
};

datablock SoundCueDatablock(snd_windowError : snd_base) 
{
   soundList = "windowError";
};

datablock SoundCueDatablock(snd_dialogLogIn_01 : snd_base) 
{
   soundList = "dialogLogIn_01";
};

datablock SoundCueDatablock(snd_levelupSound : snd_base) 
{
   soundList = "levelupSound";
};

datablock SoundCueDatablock(snd_shipUnlock : snd_base) 
{
   soundList = "shipUnlock_01";
};

datablock SoundCueDatablock(snd_selectShip : snd_base) 
{
   soundList = "HUD_selectShipSound";
};

datablock SoundCueDatablock(snd_mouseOver : snd_base) 
{
   soundList = "buttonMouseOver";
};

datablock SoundCueDatablock(snd_mouseClick : snd_base) 
{
   soundList = "buttonClickPositive";
};

datablock SoundCueDatablock(snd_targetShip : snd_base) 
{
   soundList = "HUD_targetShipSound";
};

datablock SoundCueDatablock(snd_missionFail : snd_base) 
{
   soundList = "missionFail_sound";
};

datablock SoundCueDatablock(snd_missionSuccess : snd_base) 
{
   soundList = "missionSuccess_sound";
};

datablock SoundCueDatablock(snd_gameSaved : snd_base) 
{
   soundList = "gameSaved_sound";
};

datablock SoundCueDatablock(snd_missionAccept : snd_base) 
{
   soundList = "missionAccept_sound";
};

datablock SoundCueDatablock(snd_tutorialNew : snd_base) 
{
   soundList = "tutorialNew_01 tutorialNew_02 tutorialNew_03";
};

////////////////////////////////////////////////////////////////////////////////
// EGGS
////////////////////////////////////////////////////////////////////////////////

datablock SoundCueDatablock(snd_eggHit : snd_base) 
{
   soundList = "hullHit_zombie_01 hullHit_zombie_02 eggHit_01 eggHit_02";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_eggMotion : snd_base) 
{
   soundList = "eggMotion_01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_eggMotion_large : snd_base) 
{
   soundList = "eggMotion_large01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};


datablock SoundCueDatablock(snd_eggGrowLarge : snd_base) 
{
   soundList = "eggGrow_large01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_eggGrowSmall : snd_base) 
{
   soundList = "eggGrow_Small01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_eggHatchHuge : snd_base) 
{
   soundList = "eggHatch_Huge01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_eggHatchSmall : snd_base) 
{
   soundList = "eggHatch_small01 eggHatch_small02 eggHatch_small03";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_eggAbortSmall : snd_base) 
{
   soundList = "eggAbort_small01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

datablock SoundCueDatablock(snd_eggAbortLarge : snd_base) 
{
   soundList = "eggAbort_large01";
   pitchShiftDown = -2;
   pitchShiftUp = 2; 
};

////////////////////////////////////////////////////////////////////////////////
// RADIO CHATTER
////////////////////////////////////////////////////////////////////////////////

datablock SoundCueDatablock(snd_chatter_base : snd_base) 
{
   pitchShiftDown = -0.75;
   pitchShiftUp = 0.75; 
   preReq = "";
};

//huge list to cut back on repetative calls
datablock SoundCueDatablock(snd_chatter_civ_random_01 : snd_chatter_base) 
{
   isRandomChatter = true;
   soundList = "chatter_civ_funny_01 chatter_civ_funny_02 chatter_civ_funny_03 chatter_civ_funny_04 chatter_civ_funny_05 chatter_civ_random_01 chatter_civ_random_02 chatter_civ_random_03 chatter_civ_random_04 chatter_civ_random_05 chatter_civ_random_06 chatter_civ_random_07 chatter_civ_random_08 chatter_civ_random_09 chatter_civ_random_10";
};

datablock SoundCueDatablock(snd_chatter_civ_respond : snd_chatter_base) 
{
   isRandomChatter = true;
   soundList = "chatter_civ_respond_01 chatter_civ_respond_02 chatter_civ_respond_03 chatter_civ_respond_04 chatter_civ_respond_05";
};

datablock SoundCueDatablock(snd_chatter_civ_miner : snd_chatter_base) 
{
   isRandomChatter = true;
   preReq = "chatter_canPlayInf mining";
   soundList = "chatter_civ_miner_01 chatter_civ_miner_02 chatter_civ_miner_03 chatter_civ_miner_04 chatter_civ_miner_05";
};

datablock SoundCueDatablock(snd_chatter_civ_sci : snd_chatter_base) 
{
   isRandomChatter = true;
   preReq = "chatter_canPlayInf Science";
   soundList = "chatter_civ_sci_01 chatter_civ_sci_02 chatter_civ_sci_03 chatter_civ_sci_04 chatter_civ_sci_05";
};

datablock SoundCueDatablock(snd_chatter_civ_colony : snd_chatter_base) 
{
   isRandomChatter = true;
   preReq = "chatter_canPlayInf Colony";
   soundList = "chatter_civ_colony_01 chatter_civ_colony_02 chatter_civ_colony_03 chatter_civ_colony_04 chatter_civ_colony_05";
};

datablock SoundCueDatablock(snd_chatter_civ_security : snd_chatter_base) 
{
   isRandomChatter = true;
   preReq = "chatter_canPlaySec";
   soundList = "chatter_civ_security_01 chatter_civ_security_02 chatter_civ_security_03 chatter_civ_security_04 chatter_civ_security_05";
};

datablock SoundCueDatablock(chatter_civ_pirate : snd_chatter_base) 
{
   isRandomChatter = true;
   preReq = "chatter_canPlayHome";
   soundList = "chatter_civ_pirate_01 chatter_civ_pirate_02 chatter_civ_pirate_03 chatter_civ_pirate_04 chatter_civ_pirate_05";
};

datablock SoundCueDatablock(chatter_civ_beeps : snd_chatter_base) 
{
   isRandomChatter = true;
   soundList = "chatter_civ_beeps_01 chatter_civ_beeps_02 chatter_civ_beeps_03 chatter_civ_beeps_04 chatter_civ_beeps_05";
};

datablock SoundCueDatablock(chatter_civ_callSign : snd_chatter_base) 
{
   isRandomChatter = true;
   soundList = "chatter_civ_callSign_01 chatter_civ_callSign_02 chatter_civ_callSign_03 chatter_civ_callSign_04 chatter_civ_callSign_05";
};

datablock SoundCueDatablock(chatter_civ_distnat : snd_chatter_base) 
{
   isRandomChatter = true;
   soundList = "chatter_civ_distant_01 chatter_civ_distant_02 chatter_civ_distant_03 chatter_civ_distant_04 chatter_civ_distant_05";
};

datablock SoundCueDatablock(snd_chatter_bot_random : snd_chatter_base) 
{
   isRandomChatter = true;
   soundList = "chatter_bot_random_01 chatter_bot_random_02 chatter_bot_random_03 chatter_bot_random_04 chatter_bot_random_05";
};

datablock SoundCueDatablock(snd_chatter_zombie_rumor : snd_chatter_base) 
{
   isRandomChatter = true;  //needs some kind of prereq
   pitchShiftDown = -0.1; //sound bad with massive shift
   pitchShiftUp = 0.1;    //sound bad with massive shift
   soundList = "chatter_zombieRumor_01 chatter_zombieRumor_02 chatter_zombieRumor_03 chatter_zombieRumor_04 chatter_zombieRumor_05";
};

datablock SoundCueDatablock(snd_chatter_metalBend : snd_chatter_base) 
{
   isRandomChatter = true;
   soundList = "chatter_metalBend_01 chatter_metalBend_02 chatter_metalBend_03 chatter_metalBend_04 chatter_metalBend_05";
};

////////////////////////////////////////////////////////////////////////////////
// CALLED CHATTER
////////////////////////////////////////////////////////////////////////////////

datablock SoundCueDatablock(snd_triggeredChatter_base : snd_chatter_base) 
{
   soundCoolDown = 20; //prevents this sound from being used until the cooldown has expiered
};

datablock SoundCueDatablock(snd_chatter_abandonShip : snd_triggeredChatter_base) 
{
   soundList = "chatter_abandonShip_01 chatter_abandonShip_02 chatter_abandonShip_03";
};

datablock SoundCueDatablock(snd_chatter_boardingAbord : snd_triggeredChatter_base) 
{
   soundList = "chatter_boardingAbord_01 chatter_boardingAbord_02";
};

datablock SoundCueDatablock(snd_chatter_boardingAway : snd_triggeredChatter_base) 
{
   soundList = "chatter_boardingAway_01 chatter_boardingAway_02";
};

datablock SoundCueDatablock(snd_chatter_boardingEmpty : snd_triggeredChatter_base) 
{
   soundList = "chatter_boardingEmpty_01 chatter_boardingEmpty_02";
};

datablock SoundCueDatablock(snd_chatter_hostageVent : snd_triggeredChatter_base) //added in some generic ones "chatter_prisonerTerm_01" so its not so sammy
{
   soundList = "chatter_hostageVent_01 chatter_prisonerTerm_01 chatter_hostageVent_02 chatter_prisonerTerm_01 chatter_hostageVent_03 chatter_prisonerTerm_01";
};

datablock SoundCueDatablock(snd_chatter_shipDestroyed : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_shipDestroyed_01 chatter_shipDestroyed_02 chatter_shipDestroyed_03 chatter_shipDestroyed_04 chatter_shipDestroyed_05";
};

datablock SoundCueDatablock(snd_chatter_shipDestroyed_basic : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_shipDestroyed_06";
};

datablock SoundCueDatablock(snd_chatter_shipConstructed : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_shipConstructed_02 chatter_shipConstructed_03 chatter_shipConstructed_04 chatter_shipConstructed_05";
};

datablock SoundCueDatablock(snd_chatter_shipConstructed_basic : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_shipConstructed_01";
};

datablock SoundCueDatablock(snd_chatter_cargoFull : snd_triggeredChatter_base) 
{
   soundCoolDown = 3; //we want to hear this often
   soundList = "chatter_cargoFull_01 chatter_cargoFull_02 chatter_cargoFull_03";
};

datablock SoundCueDatablock(snd_chatter_ventDecks : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_ventDecks_01 chatter_ventDecks_02 chatter_ventDecks_03";
};

datablock SoundCueDatablock(snd_chatter_zombieAbord : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_zombieAbord_01 chatter_zombieAbord_02 chatter_zombieAbord_03";
};

datablock SoundCueDatablock(snd_chatter_enemyAbord : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_enemyAbord_01 chatter_enemyAbord_02 chatter_enemyAbord_03";
};

datablock SoundCueDatablock(snd_relationUp : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_relationUp_01 chatter_relationUp_02 chatter_relationUp_03 chatter_relationUp_04 chatter_relationUp_05";
};

datablock SoundCueDatablock(snd_relationDown : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_relationDown_01 chatter_relationDown_02 chatter_relationDown_03 chatter_relationDown_04 chatter_relationDown_05";
};

//station damage

datablock SoundCueDatablock(snd_scienceDamage : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_scienceDamage_01 chatter_scienceDamage_02 chatter_scienceDamage_03";
};

datablock SoundCueDatablock(snd_minerDamage : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_minerDamage_01 chatter_minerDamage_02 chatter_minerDamage_03";
};

datablock SoundCueDatablock(snd_colonyDamage : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_colonyDamage_01 chatter_colonyDamage_02 chatter_colonyDamage_03";
};

datablock SoundCueDatablock(snd_utaDamage : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_utaDamage_01 chatter_utaDamage_02 chatter_utaDamage_03";
};

//boss fight chatter

datablock SoundCueDatablock(snd_bossAttack : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_bossAttack_01 chatter_bossAttack_02 chatter_bossAttack_03";
};

datablock SoundCueDatablock(snd_bossDefend : snd_triggeredChatter_base) 
{
   soundCoolDown = 5; //we want to hear this often
   soundList = "chatter_bossDefend_01 chatter_bossDefend_02 chatter_bossDefend_03";
};

//bounty chatter

datablock SoundCueDatablock(snd_chatter_bountyGeneric_01 : snd_chatter_base) 
{
   isRandomChatter = true;
   preReq = "chatter_canPlayBounty";
   soundCoolDown = 20; //we want to hear this often
   soundList = "chatter_bountyGeneric_01 chatter_bountyGeneric_02 chatter_bountyGeneric_03 chatter_bountyGeneric_04 chatter_bountyGeneric_05";
};
datablock SoundCueDatablock(snd_chatter_bountyPaid_01 : snd_chatter_base) 
{
   soundCoolDown = 20; //we want to hear this often
   soundList = "chatter_bountyPaid_01 chatter_bountyPaid_02";
};
datablock SoundCueDatablock(snd_chatter_bountyHelp_01 : snd_chatter_base) 
{
   soundCoolDown = 20; //we want to hear this often
   soundList = "chatter_bountyHelp_01 chatter_bountyHelp_02 chatter_bountyHelp_03";
};
datablock SoundCueDatablock(snd_chatter_bountyExtort_01 : snd_chatter_base) 
{
   soundCoolDown = 20; //we want to hear this often
   soundList = "chatter_bountyExtort_01 chatter_bountyExtort_02";
};
datablock SoundCueDatablock(snd_chatter_bountyBaseAttack_01 : snd_chatter_base) 
{
   soundCoolDown = 20; //we want to hear this often
   soundList = "chatter_bountyBaseAttack_01 chatter_bountyBaseAttack_02";
};
datablock SoundCueDatablock(snd_chatter_bountyAttack_01 : snd_chatter_base) 
{
   soundCoolDown = 20; //we want to hear this often
   soundList = "chatter_bountyAttack_01 chatter_bountyAttack_02 chatter_bountyAttack_03";
};
datablock SoundCueDatablock(snd_chatter_bountyNetural_01 : snd_chatter_base) 
{
   soundCoolDown = 20; //we want to hear this often
   soundList = "chatter_bountyNetural_01 chatter_bountyNetural_02 chatter_bountyNetural_03 chatter_bountyNetural_04";
};
datablock SoundCueDatablock(snd_chatter_bountyFlee_01 : snd_chatter_base) 
{
   soundCoolDown = 20; //we want to hear this often
   soundList = "chatter_bountyFlee_01 chatter_bountyFlee_02 chatter_bountyFlee_03";
};

//COMIC DIALOG
datablock SoundCueDatablock(snd_comicDialog_1_1 : snd_base) 
{
   soundList = "comicDialog_1_1";
};
datablock SoundCueDatablock(snd_comicDialog_1_2 : snd_base) 
{
   soundList = "comicDialog_1_2";
};
datablock SoundCueDatablock(snd_comicDialog_1_3 : snd_base) 
{
   soundList = "comicDialog_1_3";
};
datablock SoundCueDatablock(snd_comicDialog_1_4 : snd_base) 
{
   soundList = "comicDialog_1_4";
};
datablock SoundCueDatablock(snd_comicDialog_1_5 : snd_base) 
{
   soundList = "comicDialog_1_5";
};
datablock SoundCueDatablock(snd_comicDialog_1_6 : snd_base) 
{
   soundList = "comicDialog_1_6";
};
datablock SoundCueDatablock(snd_comicDialog_1_7 : snd_base) 
{
   soundList = "comicDialog_1_7";
};

datablock SoundCueDatablock(snd_comicDialog_2_1 : snd_base) 
{
   soundList = "comicDialog_2_1";
};
datablock SoundCueDatablock(snd_comicDialog_2_2 : snd_base) 
{
   soundList = "comicDialog_2_2";
};

datablock SoundCueDatablock(snd_comicDialog_3_1 : snd_base) 
{
   soundList = "comicDialog_3_1";
};
datablock SoundCueDatablock(snd_comicDialog_3_2 : snd_base) 
{
   soundList = "comicDialog_3_2";
};

datablock SoundCueDatablock(snd_comicDialog_4_1 : snd_base) 
{
   soundList = "comicDialog_4_1";
};

datablock SoundCueDatablock(snd_comicDialog_5_1 : snd_base) 
{
   soundList = "comicDialog_5_1";
};
datablock SoundCueDatablock(snd_comicDialog_5_2 : snd_base) 
{
   soundList = "comicDialog_5_2";
};

datablock SoundCueDatablock(snd_comicDialog_6_1 : snd_base) 
{
   soundList = "comicDialog_6_1";
};
datablock SoundCueDatablock(snd_comicDialog_6_2 : snd_base) 
{
   soundList = "comicDialog_6_2";
};
datablock SoundCueDatablock(snd_comicDialog_6_3 : snd_base) 
{
   soundList = "comicDialog_6_3";
};
datablock SoundCueDatablock(snd_comicDialog_6_4 : snd_base) 
{
   soundList = "comicDialog_6_4";
};
datablock SoundCueDatablock(snd_comicDialog_6_5 : snd_base) 
{
   soundList = "comicDialog_6_5";
};














