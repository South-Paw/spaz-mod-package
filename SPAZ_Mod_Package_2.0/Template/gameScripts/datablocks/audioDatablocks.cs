


function AudioProfile::onAdd(%this)
{
   //echo(%this.getName()); 
   $LoadingEntryCount++;
   Startup_LoadingScreen_Update(); //will move the bar and repaint the canvas  
}

$PreLoadMusic = false;
/*
new AudioProfile(TempSong)
{
   filename = "~/data/audio/music/Song_03.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};
*/

new AudioProfile(Song_01)
{
   filename = "~/data/audio/music/Song_01.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_02)
{
   filename = "~/data/audio/music/Song_02.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_03)
{
   filename = "~/data/audio/music/Song_03.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_04)
{
   filename = "~/data/audio/music/Song_04.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_05)
{
   filename = "~/data/audio/music/Song_05.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_06)
{
   filename = "~/data/audio/music/Song_06.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_07)
{
   filename = "~/data/audio/music/Song_07.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_08)
{
   filename = "~/data/audio/music/Song_08.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_09)
{
   filename = "~/data/audio/music/Song_09.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};
new AudioProfile(Song_10)
{
   filename = "~/data/audio/music/Song_10.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_12)
{
   filename = "~/data/audio/music/Song_12.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_13)
{
   filename = "~/data/audio/music/Song_13.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_14)
{
   filename = "~/data/audio/music/Song_14.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

new AudioProfile(Song_15)
{
   filename = "~/data/audio/music/Song_15.ogg";
   description = "AudioLooping_Music";
   preload = $PreLoadMusic;
};

//SOUND EFFECTS////////////

//loops

new AudioProfile(loop_thrusterTiny)
{
   filename = "~/data/audio/effects/loop_thrusterTiny.ogg";
   description = "AudioLooping_Effect";
   preload = true;
};

new AudioProfile(loop_thrusterSmall)
{
   filename = "~/data/audio/effects/loop_thrusterSmall.ogg";
   description = "AudioLooping_Effect";
   preload = true;
};

new AudioProfile(loop_thrusterLarge)
{
   filename = "~/data/audio/effects/loop_thrusterLarge.ogg";
   description = "AudioLooping_Effect";
   preload = true;
};

// squash effect

new AudioProfile(squash_01)
{
   filename = "~/data/audio/effects/squash_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(squash_02)
{
   filename = "~/data/audio/effects/squash_02.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(squash_03)
{
   filename = "~/data/audio/effects/squash_03.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(squash_04)
{
   filename = "~/data/audio/effects/squash_04.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(squash_05)
{
   filename = "~/data/audio/effects/squash_05.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(squash_06)
{
   filename = "~/data/audio/effects/squash_06.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//zombie squash

new AudioProfile(squash_zom_01)
{
   filename = "~/data/audio/effects/squash_zom_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};
new AudioProfile(squash_zom_02)
{
   filename = "~/data/audio/effects/squash_zom_02.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};
new AudioProfile(squash_zom_03)
{
   filename = "~/data/audio/effects/squash_zom_03.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};
new AudioProfile(squash_zom_04)
{
   filename = "~/data/audio/effects/squash_zom_04.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

// space scream

new AudioProfile(space_scream_01)
{
   filename = "~/data/audio/effects/space_scream_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(space_scream_02)
{
   filename = "~/data/audio/effects/space_scream_02.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(space_scream_03)
{
   filename = "~/data/audio/effects/space_scream_03.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(space_scream_04)
{
   filename = "~/data/audio/effects/space_scream_04.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//lasers

new AudioProfile(microScannerFire_01)
{
   filename = "~/data/audio/effects/microScannerFire_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(microLaserFire_01)
{
   filename = "~/data/audio/effects/microLaserFire_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(smallLaserFire_01)
{
   filename = "~/data/audio/effects/smallLaserFire_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(rapidLaserFire_01)
{
   filename = "~/data/audio/effects/rapidLaserFire_01.ogg";
   description = "AudioNonLooping_Effect_LOW"; //can shoot often
   preload = true;
};

new AudioProfile(leechBeamFire) 
{
   filename = "~/data/audio/effects/leechBeamFire.ogg";
   description = "AudioNonLooping_Effect_MED"; //can shoot often
   preload = true;
};

new AudioProfile(leechBeamPuff) 
{
   filename = "~/data/audio/effects/leechBeamPuff.ogg";
   description = "AudioNonLooping_Effect_MED"; 
   preload = true;
};

new AudioProfile(gravBeamFire) 
{
   filename = "~/data/audio/effects/gravBeamFire.ogg";
   description = "AudioNonLooping_Effect_MED"; //can shoot often
   preload = true;
};

new AudioProfile(gravBeamPuff) 
{
   filename = "~/data/audio/effects/gravBeamPuff.ogg";
   description = "AudioNonLooping_Effect_MED"; //can shoot often
   preload = true;
};

new AudioProfile(heavyLaserFire_01)
{
   filename = "~/data/audio/effects/heavyLaserFire_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(heavyLaserFire_01_puff)
{
   filename = "~/data/audio/effects/heavyLaserFire_01_puff.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(hugeLaserFire_01)
{
   filename = "~/data/audio/effects/hugeLaserFire_01.ogg";
   description = "AudioNonLooping_Effect_HIGH";
   preload = true;
};

new AudioProfile(hugeLaserFire_01_puff)
{
   filename = "~/data/audio/effects/hugeLaserFire_01_puff.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(smallLaserHit_01)
{
   filename = "~/data/audio/effects/smallLaserHit_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

//projectiles

new AudioProfile(smallProjectileFire_01)
{
   filename = "~/data/audio/effects/smallProjectileFire_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(microProjectileFire_01)
{
   filename = "~/data/audio/effects/microProjectileFire_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(pulseFire_01)
{
   filename = "~/data/audio/effects/pulseFire_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(massDriverFire_01)
{
   filename = "~/data/audio/effects/massDriverFire_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(clusterProjectileFire_01)
{
   filename = "~/data/audio/effects/clusterProjectileFire_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(smallProjectileHit_01)
{
   filename = "~/data/audio/effects/smallProjectileHit_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(zombieSpitting_01)
{
   filename = "~/data/audio/effects/zombieSpitting_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//missiles

new AudioProfile(missileReload_sound01)
{
   filename = "~/data/audio/effects/missileReload_sound01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(smallMissileFlare_01)
{
   filename = "~/data/audio/effects/smallMissileFlare_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(rapidMissileFlare_01)
{
   filename = "~/data/audio/effects/rapidMissileFlare_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(smallTorpFlare_01)
{
   filename = "~/data/audio/effects/smallTorpFlare_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//explosions

new AudioProfile(massiveWave_01)
{
   filename = "~/data/audio/effects/massiveWave.ogg";
   description = "AudioNonLooping_Effect_HIGH";
   preload = true;
};

new AudioProfile(asteroidExplosion_01)
{
   filename = "~/data/audio/effects/asteroidExplosion_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(cometExplosion_01)
{
   filename = "~/data/audio/effects/cometExplosion_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};


new AudioProfile(smallExplosion_01)
{
   filename = "~/data/audio/effects/smallExplosion_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(smallExplosion_cascade)
{
   filename = "~/data/audio/effects/smallExplosion_cascade.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(mediumExplosion_01)
{
   filename = "~/data/audio/effects/mediumExplosion_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(mediumExplosion_02)
{
   filename = "~/data/audio/effects/mediumExplosion_02.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(massBombExplosion_01)
{
   filename = "~/data/audio/effects/massBombExplosion.ogg";
   description = "AudioNonLooping_Effect_HIGH";
   preload = true;
};

new AudioProfile(resonateExplode_01)
{
   filename = "~/data/audio/effects/resonateExplode.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(bigExplosion_01)
{
   filename = "~/data/audio/effects/bigExplosion_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};
new AudioProfile(bigExplosion_02)
{
   filename = "~/data/audio/effects/bigExplosion_02.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};
new AudioProfile(bigExplosion_03)
{
   filename = "~/data/audio/effects/bigExplosion_03.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(bigExplosion_zombie_01)
{
   filename = "~/data/audio/effects/bigExplosion_zombie_01.ogg";
   description = "AudioNonLooping_Effect_HIGH";
   preload = true;
};

new AudioProfile(hugeExplosion_01)
{
   filename = "~/data/audio/effects/hugeExplosion_01.ogg";
   description = "AudioNonLooping_Effect_HIGH";
   preload = true;
};

new AudioProfile(hugeExplosion_zombie_01)
{
   filename = "~/data/audio/effects/hugeExplosion_zombie_01.ogg";
   description = "AudioNonLooping_Effect_HIGH";
   preload = true;
};

//zombie wakeup

new AudioProfile(zombie_wakeup_01)
{
   filename = "~/data/audio/effects/zombie_wakeup_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(zombie_wakeup_02)
{
   filename = "~/data/audio/effects/zombie_wakeup_02.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(zombie_wakeup_03)
{
   filename = "~/data/audio/effects/zombie_wakeup_03.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//cargo

new AudioProfile(smallCargoPickup_01)
{
   filename = "~/data/audio/effects/smallCargoPickup_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(tractorAttach)
{
   filename = "~/data/audio/effects/tractorAttach.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//shields

new AudioProfile(shieldFail_01)
{
   filename = "~/data/audio/effects/shieldFail_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(cloakEngage_01)
{
   filename = "~/data/audio/effects/cloakEngage_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(cloakLost_01)
{
   filename = "~/data/audio/effects/cloakLost_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

//reactor

new AudioProfile(reactorCritical_01)
{
   filename = "~/data/audio/effects/reactorCritical_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(reactorExplosion_01)
{
   filename = "~/data/audio/effects/reactorExplosion_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(reactorImplosion_01)
{
   filename = "~/data/audio/effects/reactorImplosion_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

//armor

new AudioProfile(armorHit_01)
{
   filename = "~/data/audio/effects/armorHit_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//hull

new AudioProfile(hullHit_01)
{
   filename = "~/data/audio/effects/hullHit_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(hullHit_02)
{
   filename = "~/data/audio/effects/hullHit_02.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(hullHit_zombie_01)
{
   filename = "~/data/audio/effects/hullHit_zombie_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(hullHit_zombie_02)
{
   filename = "~/data/audio/effects/hullHit_zombie_02.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(hullHit_zombie_03)
{
   filename = "~/data/audio/effects/hullHit_zombie_03.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(hullHit_zombie_04)
{
   filename = "~/data/audio/effects/hullHit_zombie_04.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//escape pods and abandon ship

new AudioProfile(escapePodEject_small)
{
   filename = "~/data/audio/effects/escapePodEject_small.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};


new AudioProfile(escapePodEject_large)
{
   filename = "~/data/audio/effects/escapePodEject_large.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};


new AudioProfile(abandonShipAlarm)
{
   filename = "~/data/audio/effects/abandonShipAlarm.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(shuttleLaunch)
{
   filename = "~/data/audio/effects/shuttleLaunch.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(turretDeploy_01)
{
   filename = "~/data/audio/effects/turretDeploy_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

//warp effects

new AudioProfile(shipWarp_01)
{
   filename = "~/data/audio/effects/shipWarp_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(beaconWarp_01)
{
   filename = "~/data/audio/effects/beaconWarp_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

/////////////////////////////////////////////////////////////////////////
//eggs
/////////////////////////////////////////////////////////////////////////

new AudioProfile(eggHit_01)
{
   filename = "~/data/audio/effects/eggHit_01.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(eggHit_02)
{
   filename = "~/data/audio/effects/eggHit_02.ogg";
   description = "AudioNonLooping_Effect_LOW";
   preload = true;
};

new AudioProfile(eggMotion_01)
{
   filename = "~/data/audio/effects/eggMotion_01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(eggMotion_large01)
{
   filename = "~/data/audio/effects/eggMotion_large01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(eggGrow_large01)
{
   filename = "~/data/audio/effects/eggGrow_large01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(eggGrow_Small01)
{
   filename = "~/data/audio/effects/eggGrow_Small01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(eggHatch_Huge01)
{
   filename = "~/data/audio/effects/eggHatch_Huge01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(eggHatch_Small01)
{
   filename = "~/data/audio/effects/eggHatch_Small01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(eggHatch_Small02)
{
   filename = "~/data/audio/effects/eggHatch_Small02.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(eggHatch_Small03)
{
   filename = "~/data/audio/effects/eggHatch_Small03.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};

new AudioProfile(eggAbort_Small01)
{
   filename = "~/data/audio/effects/eggAbort_Small01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};


new AudioProfile(eggAbort_Large01)
{
   filename = "~/data/audio/effects/eggAbort_Large01.ogg";
   description = "AudioNonLooping_Effect_MED";
   preload = true;
};


/////////////////////////////////////////////////////////////////////////
//dialog
/////////////////////////////////////////////////////////////////////////

new AudioProfile(dialog_terran_01)
{
   filename = "~/data/audio/dialog/terranDialog_01.ogg";
   description = "AudioNonLooping_DIALOGUE";
   preload = false;
};

new AudioProfile(dialog_pirate_01)
{
   filename = "~/data/audio/dialog/pirateDialog_01.ogg";
   description = "AudioNonLooping_DIALOGUE";
   preload = false;
};

new AudioProfile(dialog_zombie_01)
{
   filename = "~/data/audio/dialog/zombieDialog_01.ogg";
   description = "AudioNonLooping_DIALOGUE";
   preload = false;
};

//interface

new AudioProfile(calloutCue)
{
   filename = "~/data/audio/effects/calloutCue.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(resourceCollect)
{
   filename = "~/data/audio/effects/resourceCollect.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(dataCollect)
{
   filename = "~/data/audio/effects/dataCollect.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(windowExpand)
{
   filename = "~/data/audio/effects/windowExpand.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(windowPurchase)
{
   filename = "~/data/audio/effects/windowPurchase.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(windowInstall)
{
   filename = "~/data/audio/effects/windowInstall.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(windowResearch)
{
   filename = "~/data/audio/effects/windowResearch.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(windowError)
{
   filename = "~/data/audio/effects/windowError.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(dialogLogIn_01)
{
   filename = "~/data/audio/effects/dialogLogIn_01.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(levelupSound)
{
   filename = "~/data/audio/effects/levelupSound.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(shipUnlock_01)
{
   filename = "~/data/audio/effects/shipUnlock_01.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(HUD_selectShipSound)
{
   filename = "~/data/audio/effects/HUD_selectShip_sound.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(HUD_targetShipSound)
{
   filename = "~/data/audio/effects/HUD_targetShip_sound.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(missionFail_sound)
{
   filename = "~/data/audio/effects/missionFail.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(missionSuccess_sound)
{
   filename = "~/data/audio/effects/missionSuccess.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(gameSaved_sound)
{
   filename = "~/data/audio/effects/gameSaved.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(missionAccept_sound)
{
   filename = "~/data/audio/effects/missionAccept.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(tutorialNew_01)
{
   filename = "~/data/audio/effects/tutorial_new_01.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(tutorialNew_02)
{
   filename = "~/data/audio/effects/tutorial_new_02.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(tutorialNew_03)
{
   filename = "~/data/audio/effects/tutorial_new_03.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

/////////////////////////////////////////////////////////////////////////
//RADIO CHATTER
/////////////////////////////////////////////////////////////////////////

//random

new AudioProfile(chatter_civ_random_01)
{
   filename = "~/data/audio/chatter/chatter_civ_random_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_02)
{
   filename = "~/data/audio/chatter/chatter_civ_random_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_03)
{
   filename = "~/data/audio/chatter/chatter_civ_random_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_04)
{
   filename = "~/data/audio/chatter/chatter_civ_random_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_05)
{
   filename = "~/data/audio/chatter/chatter_civ_random_06.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_06)
{
   filename = "~/data/audio/chatter/chatter_civ_random_06.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_07)
{
   filename = "~/data/audio/chatter/chatter_civ_random_07.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_08)
{
   filename = "~/data/audio/chatter/chatter_civ_random_08.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_09)
{
   filename = "~/data/audio/chatter/chatter_civ_random_09.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_random_10)
{
   filename = "~/data/audio/chatter/chatter_civ_random_10.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//response

new AudioProfile(chatter_civ_respond_01)
{
   filename = "~/data/audio/chatter/chatter_civ_respond_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_respond_02)
{
   filename = "~/data/audio/chatter/chatter_civ_respond_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_respond_03)
{
   filename = "~/data/audio/chatter/chatter_civ_respond_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_respond_04)
{
   filename = "~/data/audio/chatter/chatter_civ_respond_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_respond_05)
{
   filename = "~/data/audio/chatter/chatter_civ_respond_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//miners

new AudioProfile(chatter_civ_miner_01)
{
   filename = "~/data/audio/chatter/chatter_civ_miner_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_miner_02)
{
   filename = "~/data/audio/chatter/chatter_civ_miner_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_miner_03)
{
   filename = "~/data/audio/chatter/chatter_civ_miner_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_miner_04)
{
   filename = "~/data/audio/chatter/chatter_civ_miner_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_miner_05)
{
   filename = "~/data/audio/chatter/chatter_civ_miner_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//colony

new AudioProfile(chatter_civ_colony_01)
{
   filename = "~/data/audio/chatter/chatter_civ_colony_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_colony_02)
{
   filename = "~/data/audio/chatter/chatter_civ_colony_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_colony_03)
{
   filename = "~/data/audio/chatter/chatter_civ_colony_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_colony_04)
{
   filename = "~/data/audio/chatter/chatter_civ_colony_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_colony_05)
{
   filename = "~/data/audio/chatter/chatter_civ_colony_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//science

new AudioProfile(chatter_civ_sci_01)
{
   filename = "~/data/audio/chatter/chatter_civ_sci_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_sci_02)
{
   filename = "~/data/audio/chatter/chatter_civ_sci_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_sci_03)
{
   filename = "~/data/audio/chatter/chatter_civ_sci_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_sci_04)
{
   filename = "~/data/audio/chatter/chatter_civ_sci_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_sci_05)
{
   filename = "~/data/audio/chatter/chatter_civ_sci_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//security

new AudioProfile(chatter_civ_security_01)
{
   filename = "~/data/audio/chatter/chatter_civ_security_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_security_02)
{
   filename = "~/data/audio/chatter/chatter_civ_security_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_security_03)
{
   filename = "~/data/audio/chatter/chatter_civ_security_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_security_04)
{
   filename = "~/data/audio/chatter/chatter_civ_security_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_security_05)
{
   filename = "~/data/audio/chatter/chatter_civ_security_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//funny lines

new AudioProfile(chatter_civ_funny_01)
{
   filename = "~/data/audio/chatter/chatter_civ_funny_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_funny_02)
{
   filename = "~/data/audio/chatter/chatter_civ_funny_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_funny_03)
{
   filename = "~/data/audio/chatter/chatter_civ_funny_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_funny_04)
{
   filename = "~/data/audio/chatter/chatter_civ_funny_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_funny_05)
{
   filename = "~/data/audio/chatter/chatter_civ_funny_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//pirate

new AudioProfile(chatter_civ_pirate_01)
{
   filename = "~/data/audio/chatter/chatter_civ_pirate_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_pirate_02)
{
   filename = "~/data/audio/chatter/chatter_civ_pirate_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_pirate_03)
{
   filename = "~/data/audio/chatter/chatter_civ_pirate_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_pirate_04)
{
   filename = "~/data/audio/chatter/chatter_civ_pirate_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_pirate_05)
{
   filename = "~/data/audio/chatter/chatter_civ_pirate_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//beeps

new AudioProfile(chatter_civ_beeps_01)
{
   filename = "~/data/audio/chatter/chatter_civ_beeps_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_beeps_02)
{
   filename = "~/data/audio/chatter/chatter_civ_beeps_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_beeps_03)
{
   filename = "~/data/audio/chatter/chatter_civ_beeps_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_beeps_04)
{
   filename = "~/data/audio/chatter/chatter_civ_beeps_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_beeps_05)
{
   filename = "~/data/audio/chatter/chatter_civ_beeps_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//call sign

new AudioProfile(chatter_civ_callSign_01)
{
   filename = "~/data/audio/chatter/chatter_civ_callSign_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_callSign_02)
{
   filename = "~/data/audio/chatter/chatter_civ_callSign_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_callSign_03)
{
   filename = "~/data/audio/chatter/chatter_civ_callSign_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_callSign_04)
{
   filename = "~/data/audio/chatter/chatter_civ_callSign_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_callSign_05)
{
   filename = "~/data/audio/chatter/chatter_civ_callSign_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};


//distant

new AudioProfile(chatter_civ_distant_01)
{
   filename = "~/data/audio/chatter/chatter_civ_distant_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_distant_02)
{
   filename = "~/data/audio/chatter/chatter_civ_distant_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_distant_03)
{
   filename = "~/data/audio/chatter/chatter_civ_distant_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_distant_04)
{
   filename = "~/data/audio/chatter/chatter_civ_distant_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_civ_distant_05)
{
   filename = "~/data/audio/chatter/chatter_civ_distant_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//bot

new AudioProfile(chatter_bot_random_01)
{
   filename = "~/data/audio/chatter/chatter_bot_random_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bot_random_02)
{
   filename = "~/data/audio/chatter/chatter_bot_random_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bot_random_03)
{
   filename = "~/data/audio/chatter/chatter_bot_random_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bot_random_04)
{
   filename = "~/data/audio/chatter/chatter_bot_random_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bot_random_05)
{
   filename = "~/data/audio/chatter/chatter_bot_random_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//zombie rumors

new AudioProfile(chatter_zombieRumor_01)
{
   filename = "~/data/audio/chatter/chatter_zombieRumor_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_zombieRumor_02)
{
   filename = "~/data/audio/chatter/chatter_zombieRumor_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_zombieRumor_03)
{
   filename = "~/data/audio/chatter/chatter_zombieRumor_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_zombieRumor_04)
{
   filename = "~/data/audio/chatter/chatter_zombieRumor_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_zombieRumor_05)
{
   filename = "~/data/audio/chatter/chatter_zombieRumor_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//metal bending

new AudioProfile(chatter_metalBend_01)
{
   filename = "~/data/audio/chatter/chatter_metalBend_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_metalBend_02)
{
   filename = "~/data/audio/chatter/chatter_metalBend_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_metalBend_03)
{
   filename = "~/data/audio/chatter/chatter_metalBend_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_metalBend_04)
{
   filename = "~/data/audio/chatter/chatter_metalBend_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_metalBend_05)
{
   filename = "~/data/audio/chatter/chatter_metalBend_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

//bounty chatter


new AudioProfile(chatter_bountyGeneric_01)
{
   filename = "~/data/audio/chatter/chatter_bountyGeneric_01.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyGeneric_02)
{
   filename = "~/data/audio/chatter/chatter_bountyGeneric_02.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyGeneric_03)
{
   filename = "~/data/audio/chatter/chatter_bountyGeneric_03.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyGeneric_04)
{
   filename = "~/data/audio/chatter/chatter_bountyGeneric_04.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyGeneric_05)
{
   filename = "~/data/audio/chatter/chatter_bountyGeneric_05.ogg";
   description = "AudioNonLooping_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bountyAttack_01)
{
   filename = "~/data/audio/chatter/chatter_bountyAttack_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyAttack_02)
{
   filename = "~/data/audio/chatter/chatter_bountyAttack_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyAttack_03)
{
   filename = "~/data/audio/chatter/chatter_bountyAttack_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bountyBaseAttack_01)
{
   filename = "~/data/audio/chatter/chatter_bountyBaseAttack_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyBaseAttack_02)
{
   filename = "~/data/audio/chatter/chatter_bountyBaseAttack_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bountyExtort_01)
{
   filename = "~/data/audio/chatter/chatter_bountyExtort_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyExtort_02)
{
   filename = "~/data/audio/chatter/chatter_bountyExtort_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bountyHelp_01)
{
   filename = "~/data/audio/chatter/chatter_bountyHelp_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyHelp_02)
{
   filename = "~/data/audio/chatter/chatter_bountyHelp_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyHelp_03)
{
   filename = "~/data/audio/chatter/chatter_bountyHelp_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bountyPaid_01)
{
   filename = "~/data/audio/chatter/chatter_bountyPaid_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyPaid_02)
{
   filename = "~/data/audio/chatter/chatter_bountyPaid_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};


new AudioProfile(chatter_bountyFlee_01)
{
   filename = "~/data/audio/chatter/chatter_bountyFlee_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyFlee_02)
{
   filename = "~/data/audio/chatter/chatter_bountyFlee_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyFlee_03)
{
   filename = "~/data/audio/chatter/chatter_bountyFlee_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bountyNetural_01)
{
   filename = "~/data/audio/chatter/chatter_bountyNetural_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyNetural_02)
{
   filename = "~/data/audio/chatter/chatter_bountyNetural_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyNetural_03)
{
   filename = "~/data/audio/chatter/chatter_bountyNetural_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_bountyNetural_04)
{
   filename = "~/data/audio/chatter/chatter_bountyNetural_04.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//abandon ship

new AudioProfile(chatter_abandonShip_01)
{
   filename = "~/data/audio/chatter/chatter_abandonShip_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_abandonShip_02)
{
   filename = "~/data/audio/chatter/chatter_abandonShip_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_abandonShip_03)
{
   filename = "~/data/audio/chatter/chatter_abandonShip_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//cargo full

new AudioProfile(chatter_cargoFull_01)
{
   filename = "~/data/audio/chatter/chatter_cargoFull_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_cargoFull_02)
{
   filename = "~/data/audio/chatter/chatter_cargoFull_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_cargoFull_03)
{
   filename = "~/data/audio/chatter/chatter_cargoFull_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//boarding party

new AudioProfile(chatter_boardingAbord_01)
{
   filename = "~/data/audio/chatter/chatter_boardingAbord_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_boardingAbord_02)
{
   filename = "~/data/audio/chatter/chatter_boardingAbord_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_boardingAway_01)
{
   filename = "~/data/audio/chatter/chatter_boardingAway_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_boardingAway_02)
{
   filename = "~/data/audio/chatter/chatter_boardingAway_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_boardingEmpty_01)
{
   filename = "~/data/audio/chatter/chatter_boardingEmpty_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_boardingEmpty_02)
{
   filename = "~/data/audio/chatter/chatter_boardingEmpty_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//venting hostages

new AudioProfile(chatter_hostageVent_01)
{
   filename = "~/data/audio/chatter/chatter_hostageVent_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_hostageVent_02)
{
   filename = "~/data/audio/chatter/chatter_hostageVent_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_hostageVent_03)
{
   filename = "~/data/audio/chatter/chatter_hostageVent_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_prisonerTerm_01)
{
   filename = "~/data/audio/chatter/chatter_prisonerTerm_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//ship destroyed

new AudioProfile(chatter_shipDestroyed_01)
{
   filename = "~/data/audio/chatter/chatter_shipDestroyed_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipDestroyed_02)
{
   filename = "~/data/audio/chatter/chatter_shipDestroyed_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipDestroyed_03)
{
   filename = "~/data/audio/chatter/chatter_shipDestroyed_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipDestroyed_04)
{
   filename = "~/data/audio/chatter/chatter_shipDestroyed_04.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipDestroyed_05)
{
   filename = "~/data/audio/chatter/chatter_shipDestroyed_05.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipDestroyed_06)
{
   filename = "~/data/audio/chatter/chatter_shipDestroyed_06.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//ship contsructed

new AudioProfile(chatter_shipConstructed_01)
{
   filename = "~/data/audio/chatter/chatter_shipConstructed_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipConstructed_02)
{
   filename = "~/data/audio/chatter/chatter_shipConstructed_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipConstructed_03)
{
   filename = "~/data/audio/chatter/chatter_shipConstructed_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipConstructed_04)
{
   filename = "~/data/audio/chatter/chatter_shipConstructed_04.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_shipConstructed_05)
{
   filename = "~/data/audio/chatter/chatter_shipConstructed_05.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//vent decks

new AudioProfile(chatter_ventDecks_01)
{
   filename = "~/data/audio/chatter/chatter_ventDecks_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_ventDecks_02)
{
   filename = "~/data/audio/chatter/chatter_ventDecks_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_ventDecks_03)
{
   filename = "~/data/audio/chatter/chatter_ventDecks_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//relation up

new AudioProfile(chatter_relationUp_01)
{
   filename = "~/data/audio/chatter/chatter_relationUp_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_relationUp_02)
{
   filename = "~/data/audio/chatter/chatter_relationUp_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_relationUp_03)
{
   filename = "~/data/audio/chatter/chatter_relationUp_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_relationUp_04)
{
   filename = "~/data/audio/chatter/chatter_relationUp_04.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_relationUp_05)
{
   filename = "~/data/audio/chatter/chatter_relationUp_05.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//station damage chatter
//science
new AudioProfile(chatter_scienceDamage_01)
{
   filename = "~/data/audio/chatter/chatter_scienceDamage_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_scienceDamage_02)
{
   filename = "~/data/audio/chatter/chatter_scienceDamage_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_scienceDamage_03)
{
   filename = "~/data/audio/chatter/chatter_scienceDamage_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
//miner
new AudioProfile(chatter_minerDamage_01)
{
   filename = "~/data/audio/chatter/chatter_minerDamage_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_minerDamage_02)
{
   filename = "~/data/audio/chatter/chatter_minerDamage_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_minerDamage_03)
{
   filename = "~/data/audio/chatter/chatter_minerDamage_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
//colony
new AudioProfile(chatter_colonyDamage_01)
{
   filename = "~/data/audio/chatter/chatter_colonyDamage_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_colonyDamage_02)
{
   filename = "~/data/audio/chatter/chatter_colonyDamage_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_colonyDamage_03)
{
   filename = "~/data/audio/chatter/chatter_colonyDamage_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
//colony
new AudioProfile(chatter_utaDamage_01)
{
   filename = "~/data/audio/chatter/chatter_utaDamage_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_utaDamage_02)
{
   filename = "~/data/audio/chatter/chatter_utaDamage_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_utaDamage_03)
{
   filename = "~/data/audio/chatter/chatter_utaDamage_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//relation down

new AudioProfile(chatter_relationDown_01)
{
   filename = "~/data/audio/chatter/chatter_relationDown_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_relationDown_02)
{
   filename = "~/data/audio/chatter/chatter_relationDown_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_relationDown_03)
{
   filename = "~/data/audio/chatter/chatter_relationDown_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_relationDown_04)
{
   filename = "~/data/audio/chatter/chatter_relationDown_04.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};
new AudioProfile(chatter_relationDown_05)
{
   filename = "~/data/audio/chatter/chatter_relationDown_05.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//attackers on board

new AudioProfile(chatter_enemyAbord_01)
{
   filename = "~/data/audio/chatter/chatter_enemyAbord_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_enemyAbord_02)
{
   filename = "~/data/audio/chatter/chatter_enemyAbord_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_enemyAbord_03)
{
   filename = "~/data/audio/chatter/chatter_enemyAbord_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//zombies on board

new AudioProfile(chatter_zombieAbord_01)
{
   filename = "~/data/audio/chatter/chatter_zombieAbord_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_zombieAbord_02)
{
   filename = "~/data/audio/chatter/chatter_zombieAbord_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_zombieAbord_03)
{
   filename = "~/data/audio/chatter/chatter_zombieAbord_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//boss fight chatter

new AudioProfile(chatter_bossAttack_01)
{
   filename = "~/data/audio/chatter/chatter_bossAttack_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bossAttack_02)
{
   filename = "~/data/audio/chatter/chatter_bossAttack_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bossAttack_03)
{
   filename = "~/data/audio/chatter/chatter_bossAttack_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bossDefend_01)
{
   filename = "~/data/audio/chatter/chatter_bossDefend_01.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bossDefend_02)
{
   filename = "~/data/audio/chatter/chatter_bossDefend_02.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

new AudioProfile(chatter_bossDefend_03)
{
   filename = "~/data/audio/chatter/chatter_bossDefend_03.ogg";
   description = "AudioNonLooping_UNIT_CHATTER";
   preload = false;
};

//comic dialog

new AudioProfile(comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comicDialog_1_1.ogg";
   description = "AudioNonLooping_DIALOGUE";
   preload = false;
};
new AudioProfile(comicDialog_1_2 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comicDialog_1_2.ogg";
};
new AudioProfile(comicDialog_1_3 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comicDialog_1_3.ogg";
};
new AudioProfile(comicDialog_1_4 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comicDialog_1_4.ogg";
};
new AudioProfile(comicDialog_1_5 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comicDialog_1_5.ogg";
};
new AudioProfile(comicDialog_1_6 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comicDialog_1_6.ogg";
};
new AudioProfile(comicDialog_1_7 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comicDialog_1_7.ogg";
};

new AudioProfile(comicDialog_2_1 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_2_1.ogg";
};
new AudioProfile(comicDialog_2_2 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_2_2.ogg";
};

new AudioProfile(comicDialog_3_1 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_3_1.ogg";
};
new AudioProfile(comicDialog_3_2 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_3_2.ogg";
};

new AudioProfile(comicDialog_4_1 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_4_1.ogg";
};

new AudioProfile(comicDialog_5_1 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_5_1.ogg";
};
new AudioProfile(comicDialog_5_2 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_5_2.ogg";
};

new AudioProfile(comicDialog_6_1 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_6_1.ogg";
};
new AudioProfile(comicDialog_6_2 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_6_2.ogg";
};
new AudioProfile(comicDialog_6_3 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_6_3.ogg";
};
new AudioProfile(comicDialog_6_4 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_6_4.ogg";
};
new AudioProfile(comicDialog_6_5 : comicDialog_1_1)
{
   filename = "~/data/audio/dialog/comic_Dialog/comic_Dialog_6_5.ogg";
};
























