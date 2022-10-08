
////////////////////////////////////////////////////////////////////////////////
//stat strings
////////////////////////////////////////////////////////////////////////////////

//weapons
$compStats["DAM"]   = "DAMAGE";
$compStats["POW"]   = "REV POWER USAGE"; //REVERSE FILL.
$compStats["RANGE"] = "RANGE";
$compStats["LOAD"]  = "FIRING SPEED";
$compStats["ACC"]   = "ACCURACY";

//shields, reactor, and armor stuff
$compStats["STR"]  = "STRENGTH";
$compStats["CHR"]  = "RECHARGE SPEED";
$compStats["MASS"] = "REV ADDED WEIGHT";

$compStats["CAP"]  = "POWER CAPACITY";

//engines
$compStats["SPEED"]   = "MAX SPEED";
$compStats["THRUST"]  = "THRUST POWER";
$compStats["MANU"]    = "MANEUVERABILITY";

//ships
$compStats["HULL"]  = "HULL STRENGTH"; //comparativeHealth
$compStats["MASS"]  = "REV HULL MASS";  //comparativeMass 
$compStats["TURN"]  = "MANEUVERABILITY";  //hullTurnSpeedMod
$compStats["CARGO"] = "CARGO CAPACITY"; //comparativeCargo
$compStats["CREW"]  = "CREW CAPACITY";//comparativeCrew

//special
$compStats["DRONE"]  = "MAX DRONES";

////////////////////////////////////////////////////////////////////////////////
//COMPONENT TUTORIALS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup (PT_Base : tutorialBase) 
{  
   character = "MAXCAP";
   text[0] = "TEXT MISSING.";
   startupSound = ""; 
   
   compStat[0] = ""; //prevents zombie ships from pulling random mem
};

new ScriptGroup (TUT_MissingTutorialWarning : PT_Base) 
{  
   title = "TUTORIAL MISSING!";
   text[0] = "Will override to show name";
   displayImage[0] = "~/gui/tutorialImages/tutImage_placeholder.png";
   compClass = "";
};

//cannons


new ScriptGroup (PT_pulseCannon : PT_Base) 
{  
   title = "DISRUPTOR CANNON";
   text[0] = "The Disruptor Cannon is a second generation pulse cannon that sacrifices projectile speed and range for a devastating punch.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_cannon.png";
   
   compClass = "Cannon";
   
   compStat[0] = "POW 0.75"; //power use
   
   compStat[1] = "DAM 0.70"; //damage   
   compStat[2] = "RANGE 0.75"; //range
   compStat[3] = "LOAD 0.5"; //reload
   compStat[4] = "ACC 0.85"; //spread
   
   infoTag[0] = "HEX Good vs Armor";
   infoTag[1] = "DOWN Weak vs Shields";  
};

new ScriptGroup (PT_pulseCannon_civ : PT_pulseCannon) 
{  
   title = "PULSE CANNON";
   text[0] = "The Pulse Cannon delivers a high yield linear charge.  The charge requires a great deal of energy to fire, quickly depleting the capacitor.";
  
   compStat[0] = "POW 0.400";  //power use
   
   compStat[1] = "DAM 0.500";   //damage   
   compStat[2] = "RANGE 1"; //range   
   compStat[3] = "LOAD 0.667"; //reload
};

new ScriptGroup (PT_RapidCannon : PT_Base) 
{  
   title = "PARTICLE CANNON";
   text[0] = "The Particle Cannon releases a flurry of charged particles from a gatling accelerator.  The particle energy consumption is very low, allowing it to fire at a high rate of speed.  The particle cannon's fire rate and kinetic energy can overwhelm shields, armor, and hull with great efficiency.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_rapidCannon.png";
   
   compClass = "Cannon";
   
   compStat[0] = "POW 0.375";   //power use
   
   compStat[1] = "DAM 0.35";  //damage   
   compStat[2] = "RANGE 0.8"; //range
   compStat[3] = "LOAD 1";    //reload
   compStat[4] = "ACC 0.667"; 
   
   infoTag[0] = "HEX Decent vs shields";
   infoTag[1] = "HEX Decent vs armor";
   infoTag[2] = "HEX Decent vs hull";
};

new ScriptGroup (PT_ClusterCannon : PT_Base) 
{  
   title = "ENERGY BURST CANNON";
   text[0] = "The Energy Burst Cannon slowly supercharges a magazine of unstable neutrinos.  When fired, the energy burst cannon will discharge its entire magazine across a wide arc.  When these highly charged particles impact shields, they quickly overload and destabilize them.  The particles that penetrate the shields do little damage versus armor and hull, about equivalent to a focused laser blast.  When fitted to cloaked vessels, energy burst cannons become a devastating first strike weapon.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_clusterCannon.png";
   
   compClass = "Cannon";
   
   compStat[0] = "POW 1"; //power use   
   
   compStat[1] = "DAM 0.85"; //damage   
   compStat[2] = "RANGE 0.333"; //range
   compStat[3] = "LOAD 0.50"; //reload
   compStat[4] = "ACC 0.25"; //spread
   
   infoTag[0] = "HEX Good vs Shields";
   infoTag[1] = "DOWN Weak vs Armor";  
};

new ScriptGroup (PT_MassDriver : PT_Base) 
{  
   title = "MASS DRIVER";
   text[0] = "The Mass Driver fires super charged neutrino particles.  A normal neutrino particle is capable of passing through solid matter without disturbing it; however the super charged particles will disintegrate any matter they pass through.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_massdriver.png";
   
   compClass = "Cannon";
   
   compStat[0] = "POW 1"; //power use
   
   compStat[1] = "DAM 0.85"; //damage
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.35"; //reload
   compStat[4] = "ACC 1"; //spread
   
   infoTag[0] = "HEX Good vs Hull";
   
   infoTag[1] = "UP Penetrates Armor";
   infoTag[2] = "DOWN Shields reflect";  
};

//missiles

new ScriptGroup (PT_missile : PT_Base) 
{  
   title = "MISSILE";
   text[0] = "The Missile is a true fire and forget weapon.  Upon deployment, the onboard computer guides the missile to its target.  The warhead delivers a focused explosive blast, causing maximum damage to the target hull, with almost no damage to the surrounding area.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_missile.png";

   compClass = "Launcher";

   compStat[0] = "POW 0.25"; //power use
   
   compStat[1] = "DAM 0.5"; //damage   
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.5"; //reload
   compStat[4] = "ACC 0.8"; 
   
   infoTag[0] = "HEX Good vs Hull";
   infoTag[1] = "DOWN Weak vs Shields";  
};

new ScriptGroup (PT_missile_civ : PT_missile) 
{  
   title = "MICRO MISSILE";
   text[0] = "Micro Missiles are miniaturized low yield missiles that can be quickly constructed to apply constant pressure to destabilize an enemy ship's shield regeneration systems.";

   displayImage[0] = "~/gui/tutorialImages/tutImage_missile.png";
   
   compStat[0] = "POW 0.15"; //power use
   
   compStat[1] = "DAM 0.25"; //damage   
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.75"; //reload
   compStat[4] = "ACC 0.5"; 
};


/*  //Removed
new ScriptGroup (PT_hunterMissile : PT_missile) 
{  
   title = "HUNTER MISSILE";
   text[0] = "The Hunter Missile is a stealth version of the standard missile.  It enters a cloaked state after deployment.  While cloaked it slowly seeks its target.  Once within optimal strike range, the Hunter Missile will de-cloak and engage max thrust, giving its victim little time to react.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_hunter.png";
   
   compStat[0] = "POW 0.35"; //power use     
   compStat[3] = "LOAD 0.4"; //reload   
   
   infoTag[1] = "UP Cloaked";
   infoTag[2] = "DOWN Only LARGE and HUGE mounts supported"; 
};
*/

new ScriptGroup (PT_srm : PT_Base) 
{  
   title = "SRM LAUNCHER";
   text[0] = "The short range missile launcher deploys a volley of independently controlled warheads.  Each warhead has a low explosive yield, but combined they can inflict massive damage.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_rocket.png";
   
   compClass = "Launcher";   
   
   compStat[0] = "POW 0.35"; //power use
   
   compStat[1] = "DAM 0.3"; //damage   
   compStat[2] = "RANGE 0.5"; //range
   compStat[3] = "LOAD 0.4"; //reload
   compStat[4] = "ACC 0.90"; //spread
   
   infoTag[0] = "HEX Good vs Hull";
   infoTag[1] = "UP Multiple warheads";
   infoTag[2] = "DOWN Weak vs Shields";  
};

new ScriptGroup (PT_HunterSRM : PT_srm) 
{  
   title = "HUNTER SRM";
   text[0] = "The Hunter SRM uses its survey scanner to hunt for the plasma trails left by cloaked vessels.  These missiles are able to randomly target both cloaked and non cloaked ships.  Eventually scientists realized that 'the thing's gotta have a tailpipe.'";
   displayImage[0] = "~/gui/tutorialImages/tutImage_hunter.png";
   
   compStat[0] = "POW 0.50"; //power use
   
   compStat[1] = "DAM 0.15"; //damage   
   compStat[2] = "RANGE 0.5"; //range
   compStat[3] = "LOAD 0.4"; //reload
   compStat[4] = "ACC 0.90"; //spread
   
   infoTag[0] = "UP Disrupts cloaked objects";
   infoTag[1] = "UP Multiple warheads";
};


new ScriptGroup (PT_gravMissile : PT_Base) 
{  
   title = "GRAVITY MISSILE";
   text[0] = "The Gravity Missile produces an unstable pseudo black hole, slowing the target ship until the gravity well collapses.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_missile.png";
   
   compClass = "Launcher";
   
   compStat[0] = "POW 0.35"; //power use
   
   compStat[1] = "DAM 0.1"; //damage   
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.8"; //reload
   compStat[4] = "ACC 0.8"; //spread
   
   infoTag[0] = "HEX Slows ships on contact"; 
};

//torps

new ScriptGroup (PT_torp : PT_Base) 
{  
   title = "TORPEDO";
   text[0] = "The Torpedo is a heavy warhead delivery system.  The space used by a missile's guidance systems is instead packed with explosives.  Torpedoes have only minor course correctional capabilities once deployed.  Torpedoes are best used against slow moving targets";
   displayImage[0] = "~/gui/tutorialImages/tutImage_torp.png";
   
   compClass = "Launcher";
   
   compStat[0] = "POW 0.25"; //power use
   
   compStat[1] = "DAM 0.85"; //damage   
   compStat[2] = "RANGE 0.75"; //range
   compStat[3] = "LOAD 0.5"; //reload
   compStat[4] = "ACC 0.2"; //spread
   
   infoTag[0] = "HEX Good vs Hull";
   infoTag[1] = "DOWN Weak vs Shields";  
};

new ScriptGroup (PT_torp_civ : PT_torp) 
{  
   title = "SURPLUS TORPEDO";
   text[0] = "The Surplus Torpedo is a last generation lower yield version of the modern torpedo.  The space used by a missile's guidance systems is instead packed with explosives.  Torpedoes have only minor course correctional capabilities once deployed.  Torpedoes are best used against slow moving targets";

   displayImage[0] = "~/gui/tutorialImages/tutImage_torp.png";
   
   compStat[0] = "POW 0.15"; //power use
   
   compStat[1] = "DAM 0.65"; //damage
   compStat[3] = "LOAD 0.4"; //reload
};




//beams

new ScriptGroup (PT_beam : PT_Base) 
{  
   title = "OVERLOAD EMITTER";
   text[0] = "The Overload Emitter is an advanced version of the focal emitter that sacrifices range for power.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_beam.png";
   
   compClass = "Beam";
   
   compStat[0] = "POW 0.5"; //power use
   
   compStat[1] = "DAM 0.6"; //damage   
   compStat[2] = "RANGE 0.60"; //range
   compStat[3] = "LOAD 0.5"; //reload
   compStat[4] = "ACC 1"; 
   
   infoTag[0] = "HEX Good vs Shields";
   infoTag[1] = "DOWN Weak vs Armor";  
};

new ScriptGroup (PT_beam_civ : PT_beam) 
{  
   title = "FOCAL EMITTER";
   displayImage[0] = "~/gui/tutorialImages/tutImage_beam.png";
   text[0] = "The Focal Emitter uses a long range focus crystal to amplify and direct electro magnetic radiation.  It will deal direct damage to anything it comes into contact with, but does extra damage to the ionized shields found on all modern ships.";

   compStat[0] = "POW 0.35"; //power use
   
   compStat[1] = "DAM 0.4"; //damage   
   compStat[2] = "RANGE 0.90"; //range
   compStat[3] = "LOAD 0.5"; //reload
   compStat[4] = "ACC 1"; 
   
   infoTag[0] = "HEX Good vs Shields"; //simple red text
   infoTag[1] = "DOWN Weak vs Armor";  
};

new ScriptGroup (PT_heavyBeam : PT_Base) 
{  
   title = "FUSION BEAM EMITTER";
   text[0] = "The Fusion beam can remain active indefinitely, provided there is enough power.  It takes some time to heat up the Fusion beam, but once it reaches critical mass, a stable reaction occurs.  The beam itself is very lethal and can cut through anything efficiently, but it burns away its energy over a short distance.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_beam.png";
   
   compClass = "Beam";
   
   compStat[0] = "POW 0.75"; //power use
   
   compStat[1] = "DAM 1"; //damage   
   compStat[2] = "RANGE 0.3"; //range
   compStat[3] = "LOAD 0.5"; //reload
   compStat[4] = "ACC 1"; //spread
   
   infoTag[0] = "HEX Decent vs shields";
   infoTag[1] = "HEX Decent vs armor";
   infoTag[2] = "HEX Decent vs hull";
   infoTag[3] = "UP Constant";
};

new ScriptGroup (PT_leechBeam : PT_Base) 
{  
   title = "LEECH EMITTER";
   text[0] = "The Leech Emitter can focus its beam on another ship's reactor core, charging it with artificial neutrinos.  These neutrinos then escape the reactors containment grid, taking a great deal of energy with them.  The beam then channels these charged neutrinos back into the emitter, effectively siphoning the victim ship's power.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_hexBeam.png";
   
   compClass = "Beam";
   
   compStat[0] = "POW 0.1"; //power use   
   compStat[1] = "DAM 0.1"; //damage   
   compStat[2] = "RANGE 0.60"; //range
   compStat[3] = "LOAD 0.9"; //reload
   compStat[4] = "ACC 1"; //spread
   
   infoTag[0] = "UP Steals Power";
};

new ScriptGroup (PT_ionBeam : PT_Base) 
{  
   title = "ION EMITTER";
   text[0] = "The Ion Emitter destabalizes enemy shields and then ship's systems, but it does very little physical damage.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_hexBeam.png";
   
   compClass = "Beam";
   
   compStat[0] = "POW 1"; //power use
   
   compStat[1] = "DAM 0.1"; //damage   
   compStat[2] = "RANGE 0.6"; //range
   compStat[3] = "LOAD 0.9"; //reload
   compStat[4] = "ACC 1"; //spread
   
   infoTag[0] = "HEX VERY Good vs Shields";
   infoTag[1] = "UP Disables ships";
   infoTag[2] = "DOWN Causes no damage";  
};

new ScriptGroup (PT_miningBeam : PT_Base) 
{  
   title = "MINING LASER";
   text[0] = "The Mining laser creates an oscillating beam causing targets to vibrate violently, shaking them apart.  Sustained contact from the oscillating beam will cause rock like matter to weaken and fracture.  It has almost no effect on energy shields or metallic plating.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mineBeam.png";
   
   compClass = "Beam";
   
   compStat[0] = "POW 0.15";   //power use
   
   compStat[1] = "DAM 0.1";   //damage
   compStat[2] = "RANGE 0.5"; //range
   compStat[3] = "LOAD 0.5";  //reload
   compStat[4] = "ACC 1";     //spread
   
   infoTag[1] = "UP Increased mining yield";
};

new ScriptGroup (PT_tractorBeam : PT_Base) 
{  
   title = "TRACTOR BEAM";
   text[0] = "Most ships can transport non-organic materials into the cargo hold at extremely short distances.  Tractor beams are used to tow small objects into transport range.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_tractorBeam.png";
   
   compClass = "SubSystem";
   
   compStat[0] = "RANGE 0.5"; //range
   compStat[1] = "LOAD 0.8"; //reload

};

new ScriptGroup (PT_pointDefense : PT_Base) 
{  
   title = "POINT DEFENSE";
   text[0] = "Point Defense systems contain a low yield beam mounted in an orbital socket.  It's compatible with all utility class mounts.  It's primarily used for taking out incoming warheads and mines.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_pointDef.png";
   
   compClass = "SubSystem";
   
   compStat[0] = "RANGE 0.4"; //range
   compStat[1] = "LOAD 0.5"; //reload
};

new ScriptGroup (PT_scanner_civ : PT_Base) 
{  
   title = "SURPLUS SCANNER";
   text[0] = "Scanners are used to sweep the surrounding area for cloaked ships or devices.  The scanner can create a brief disruption in a cloak field; allowing the ship's systems to gain a target lock.  It's compatible with all utility class mounts.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_pointDef.png"; //image works for both
   
   compClass = "SubSystem";
   
   compStat[0] = "RANGE 0.3"; //range
   compStat[1] = "LOAD 0.4"; //reload
};

new ScriptGroup (PT_scanner : PT_Base) 
{  
   title = "SCANNER";
   text[0] = "This is an upgraded version of the Surplus Scanner, boasting longer range and a quicker recycle time.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_pointDef.png"; //image works for both
   
   compClass = "SubSystem";
   
   compStat[0] = "RANGE 0.4"; //range
   compStat[1] = "LOAD 0.6"; //reload
};

//boosters

new ScriptGroup (PT_boosterModule_shield : PT_Base) 
{  
   title = "SHIELD BOOSTER MODULE";
   text[0] = "The shield booster improves the maximum strength and regen speed of a ship's energy shields.  Booster Modules can be placed on any mount.  Several boosters of a type can be added for additional effect.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_booster.png"; //image works for all boosters
   compClass = "SubSystem";  
};
new ScriptGroup (PT_boosterModule_reactor : PT_Base) 
{  
   title = "REACTOR BOOSTER MODULE";
   text[0] = "The reactor booster improves the output and capacity of a ship's reactor core, allowing it to operate more systems simultaneously.  Booster Modules can be placed on any mount.  Several boosters of a type can be added for additional effect.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_booster.png"; //image works for all boosters
   compClass = "SubSystem"; 
};
new ScriptGroup (PT_boosterModule_engine : PT_Base) 
{  
   title = "ENGINE BOOSTER MODULE";
   text[0] = "The engine booster improves the thrust, turn rate, and maximum speed a ship's engines, allowing it to move faster and with greater agility.  Booster Modules can be placed on any mount.  Several boosters of a type can be added for additional effect.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_booster.png"; //image works for all boosters
   compClass = "SubSystem"; 
};

new ScriptGroup (PT_boosterModule_crew : PT_Base) 
{  
   title = "CREW BOOSTER MODULE";
   text[0] = "The crew booster adds additional crew quarters to a ship.  This in turn increases the maximum crew count a ship can have and the rate in which the ship can be repaired.  Booster Modules can be placed on any mount.  Several boosters of a type can be added for additional effect.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_booster.png"; //image works for all boosters
   compClass = "SubSystem"; 
};
new ScriptGroup (PT_boosterModule_cannon : PT_Base) 
{  
   title = "CANNON BOOSTER MODULE";
   text[0] = "The cannon booster increases the reload rate, damage, projectile speed, and range of all projectile cannon class weapons.  Booster Modules can be placed on any mount.  Several boosters of a type can be added for additional effect.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_booster.png"; //image works for all boosters
   compClass = "SubSystem"; 
};
new ScriptGroup (PT_boosterModule_beam : PT_Base) 
{  
   title = "BEAM BOOSTER MODULE";
   text[0] = "The beam booster improves the damage, range, charging and recycle times of all emitter class weapons.  Booster Modules can be placed on any mount.  Several boosters of a type can be added for additional effect.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_booster.png"; //image works for all boosters
   compClass = "SubSystem"; 
};
new ScriptGroup (PT_boosterModule_launcher : PT_Base) 
{  
   title = "LAUNCHER BOOSTER MODULE";
   text[0] = "The launcher booster improves the reload rate and warhead damage for all launched weapons.  Booster Modules can be placed on any mount.  Several boosters of a type can be added for additional effect.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_booster.png"; //image works for all boosters
   compClass = "SubSystem"; 
};
new ScriptGroup (PT_boosterModule_cloak : PT_Base) 
{  
   title = "CLOAK BOOSTER MODULE";
   text[0] = "The cloak booster increases the stability and regeneration rate of cloaking fields.  Booster Modules can be placed on any mount.  Several boosters of a type can be added for additional effect.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_booster.png"; //image works for all boosters
   compClass = "SubSystem"; 
};

//crew

new ScriptGroup (PT_crewCannon : PT_Base) 
{  
   title = "SUICIDE CANNON";
   text[0] = "The suicide cannon is a quick and highly effective way to deploy marines onto an enemy ship.  The cannon shell drills into the hull of a ship, allowing the marine access to its internal decks.  Shells that miss their target will breach after a short time, allowing rescue.  Marines will also use their hacking ability to steal data, blueprints, blackboxes, and free imprisoned specialists.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_crewPod.png";
   
   compClass = "Crew";
   
   compStat[0] = "POW 0.40"; //power use
   
   compStat[1] = "DAM 0.1"; //damage
   compStat[2] = "RANGE 0.85"; //range
   compStat[3] = "LOAD 0.5"; //reload
   compStat[4] = "ACC 0.85"; //spread
   
   infoTag[0] = "UP Damages and disables systems"; 
   infoTag[1] = "UP Stealin' Booty! Yarr!"; 
   infoTag[2] = "DOWN SMALL mounts not supported"; //simple red text
       
   crewUsePopupTag = true; //tells the comp selection buttons to fire tutorial on how to use
};

new ScriptGroup (PT_crewShuttle : PT_Base) 
{  
   title = "GRUNT SHUTTLE";
   text[0] = "The Grunt shuttle sends a squad of marines toward an enemy vessel.  Since the Grunt Shuttle is guided, it will reach its target, or return home.  Once docked, the marines will ransack the enemy ship, causing confusion and lowering its fighting capabilities.  Marines will also use their hacking ability to steal data, blueprints, blackboxes, and free imprisoned specialists.";

   displayImage[0] = "~/gui/tutorialImages/tutImage_crewPod.png";
   
   compClass = "Crew";
   
   compStat[0] = "POW 0.75"; //power use
   
   compStat[1] = "DAM 0.1"; //damage
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.5"; //reload
   compStat[4] = "ACC 0.85"; //spread
   
   infoTag[0] = "UP Damages and disables systems"; 
   infoTag[1] = "UP Stealin' Booty! Yarr!";
   infoTag[2] = "DOWN Only LARGE and HUGE mounts supported"; //simple red text
   
   crewUsePopupTag = true; //tells the comp selection buttons to fire tutorial on how to use
};

//drones

new ScriptGroup (PT_droneFighter : PT_Base) 
{  
   title = "FIGHTER DRONES";
   text[0] = "Fighter drones are small autonomous bots equipped with dual micro cannons good for attacking fast moving targets.  A hangar module attached to the ship will manage the drone hive and regenerate destroyed drones over time.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_drone.png";
   
   compClass = "Drones";
   
   compStat[0] = "POW 0.35"; //power use   
   
   compStat[1] = "DAM 0.5"; //damage   
   compStat[2] = "HULL 0.750"; //hull strength
   compStat[3] = "LOAD 0.9"; //reload
   compStat[4] = "ACC 0.5"; //spread
   compStat[5] = "DRONE 1"; //drone
   
   infoTag[0] = "UP Benefits from Cannon research";
};

new ScriptGroup (PT_droneFighter_Cloaked : PT_droneFighter) 
{
   title = "CLOAKED FIGHTER DRONES";
   text[0] = "Cloaked Fighter drones have identical armament as their non cloaked counterparts, however they are able to sneak up on their targets to inflict maximum damage.  Cloaked drone hives have fewer hangars than their non cloaked versions.";

   compStat[5] = "DRONE 1"; //drone
   
   infoTag[1] = "UP 33% Cloaked damage boost";
};

new ScriptGroup (PT_droneZapper : PT_Base) 
{  
   title = "ZAPPER DRONES";
   text[0] = "Zapper drones are small autonomous bots equipped with a very accurate micro beam emitter.  A hangar module attached to the ship will manage the drone hive and regenerate destroyed drones over time.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_drone.png";
   
   compClass = "Drones";
   
   compStat[0] = "POW 0.35"; //power use   
   
   compStat[1] = "DAM 0.35"; //damage   
   compStat[2] = "HULL 0.50"; //hull strength
   compStat[3] = "LOAD 0.6"; //reload
   compStat[4] = "ACC 1"; //spread
   compStat[5] = "DRONE 0.8"; //drone
   
   infoTag[0] = "UP Benefits from Beam research";
};

new ScriptGroup (PT_droneZapper_Cloaked : PT_droneZapper) 
{
   title = "CLOAKED ZAPPER DRONES";
   text[0] = "Cloaked Zapper drones have identical armament as their non cloaked counterparts, however they are able to sneak up on their targets to inflict maximum damage.  Cloaked drone hives have fewer hangars than their non cloaked versions.";

   compStat[5] = "DRONE 0.8"; //drone
   
   infoTag[1] = "UP 33% Cloaked damage boost";
};

new ScriptGroup (PT_droneBomber : PT_Base) 
{  
   title = "BOMBER DRONES";
   text[0] = "Bomber drones are small autonomous bots equipped with a micro pulse cannon, good for attacking large ships.  A hangar module attached to the ship will manage the drone hive and regenerate destroyed drones over time.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_drone.png";
   
   compClass = "Drones";
   
   compStat[0] = "POW 0.35"; //power use   
   
   compStat[1] = "DAM 0.85"; //damage   
   compStat[2] = "HULL 1.0"; //hull strength
   compStat[3] = "LOAD 0.2"; //reload
   compStat[4] = "ACC 0.333"; //spread
   compStat[5] = "DRONE 0.7"; //drone
   
   infoTag[0] = "UP Benefits from Cannon research";
};

new ScriptGroup (PT_droneBomber_Cloaked : PT_droneBomber) 
{
   title = "CLOAKED BOMBER DRONES";
   text[0] = "Cloaked Bomber drones have identical armament as their non cloaked counterparts, however they are able to sneak up on their targets to inflict maximum damage.  Cloaked drone hives have fewer hangars than their non cloaked versions.";

   compStat[5] = "DRONE 0.7"; //drone
   
   infoTag[1] = "UP 33% Cloaked damage boost";
};

//mines

new ScriptGroup (PT_minesBasic : PT_Base) 
{  
   title = "BASIC MINES";
   text[0] = "Basic mines contain a high yield phased warhead which it delivers after magnetically attaching itself to its victim.  All mines are cloaked until they commit to detonation.  Mine fields are maintained and regenerated by mine dropper device deployed from the ship.  A mine field will collapse if the dropper device is destroyed.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mine.png";
   
   compClass = "Mines";
   
   compStat[0] = "POW 0.1"; //power use
   
   compStat[1] = "DAM 0.75"; //damage      
   compStat[2] = "LOAD 0.5"; //reload 
   
   infoTag[0] = "HEX Good vs Hull, Shield, Armor"; 
};

new ScriptGroup (PT_minesSurplus : PT_Base) 
{
   title = "SURPLUS MINES";
   text[0] = "Surplus mines are last generation tech with a lower yield phased warhead which it delivers after magnetically attaching itself to its victim.  All mines are cloaked until they commit to detonation.  Mine fields are maintained and regenerated by mine dropper device deployed from the ship.  A mine field will collapse if the dropper device is destroyed.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mine.png";
   
   compClass = "Mines";
   
   compStat[0] = "POW 0.1"; //power use
   
   compStat[1] = "DAM 0.50"; //damage      
   compStat[2] = "LOAD 0.4"; //reload 
   
   infoTag[0] = "HEX Good vs Hull, Shield, Armor"; 
};

new ScriptGroup (PT_minesIon : PT_Base) 
{  
   title = "ION MINES";
   text[0] = "Ion mines release a disruption pulse into the victim ship upon detonation, disabling it.  This pulse will temporary interfere with ship systems.  All mines are cloaked until they commit to detonation.  Mine fields are maintained and regenerated by mine dropper device deployed from the ship.  A mine field will collapse if the dropper device is destroyed.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mine.png";
   
   compClass = "Mines";
   
   compStat[0] = "POW 0.1"; //power use
   
   compStat[1] = "DAM 1"; //damage      
   compStat[2] = "LOAD 0.5"; //reload 
   
   infoTag[0] = "HEX Devastating vs Shields"; 
   infoTag[1] = "UP Disables ship"; 
   infoTag[2] = "DOWN No physical damage"; 
};

new ScriptGroup (PT_minesScan : PT_Base) 
{  
   title = "SCANNER MINES";
   text[0] = "Scanner mines are the logical evolution of the basic mine, packing a bigger wallop and having the ability to track cloaked vessels.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mine.png";
   
   compClass = "Mines";
   
   compStat[0] = "POW 0.1"; //power use
   
   compStat[1] = "DAM 1"; //damage      
   compStat[2] = "LOAD 0.5"; //reload 
   compStat[3] = "ACC 1"; //spread
   
   infoTag[0] = "HEX Good vs Hull, Shield, Armor"; 
   infoTag[1] = "UP Can track cloaked vessels"; 
};

new ScriptGroup (PT_minesShooter : PT_Base) 
{  
   title = "ION EMITTER MINES";
   text[0] = "Ion Emitter mines carry a small orbital socket emitter allowing them to disable targeted ships within their sweep range.  Emitter mines first disable enemy ships and then move in for the kill, packing a huge warhead.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mine.png";
   
   compClass = "Mines";
   
   compStat[0] = "POW 0.1"; //power use
   
   compStat[1] = "DAM 1"; //damage      
   compStat[2] = "LOAD 0.5"; //reload 
   compStat[3] = "ACC 1"; //spread
   
   infoTag[0] = "HEX Good vs Hull, Shield, Armor"; 
   infoTag[1] = "UP Mounted Ion turret"; 
};

new ScriptGroup (PT_minesAll : PT_Base) 
{  
   title = "CLUSTER MINES";
   text[0] = "Cluster mines will deploy a combo of all types of mines at random.  Cluster mine fields can deal with any defensive situation, but only sporadically compared to a dedicated minefield of a single type.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mine.png";
   
   compClass = "Mines";
   
   compStat[0] = "POW 0.1"; //power use
   
   compStat[1] = "DAM 1"; //damage      
   compStat[2] = "LOAD 0.5"; //reload 
   compStat[3] = "ACC 1"; //spread

   infoTag[0] = "UP Jack of all trades"; 
   infoTag[1] = "DOWN Master of none"; 
};

//deployable Turrets

new ScriptGroup (PT_deployableTurretsSurplus : PT_Base) 
{  
   title = "FOCAL TURRET";
   text[0] = "The Deployable Focal Turret is fitted with a medium Focal emitter and surplus defensive systems and armor.  It is able to defend a large area due to the range of the Focal emitter, however it lacks the punch to be a threat to any but small ships.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_deployTurret.png";
   
   compClass = "Turrets";
   
   compStat[0] = "DAM 0.2";   
   compStat[1] = "HULL 0.2";  
   compStat[2] = "LOAD 0.5"; 
   
   infoTag[0] = "UP Can guard a large area."; 
   infoTag[1] = "UP Effective vs. small ships' shields."; 
};

new ScriptGroup (PT_deployableTurretsBasic : PT_Base) 
{  
   title = "DISRUPTOR TURRET";
   text[0] = "The Deployable Disruptor Turret is fitted with a devastating but slow firing medium Disruptor Cannon.  Its defensive systems have also been upgraded to use basic military hardware, giving it a lot more staying power than its little brother the Focal Turret.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_deployTurret.png";
   
   compClass = "Turrets";
   
   compStat[0] = "DAM 0.5";   
   compStat[1] = "HULL 0.3";  
   compStat[2] = "LOAD 0.25"; 
   
   infoTag[0] = "UP Great vs. armor."; 
   infoTag[1] = "DOWN Slow firing and easily avoided."; 
};

new ScriptGroup (PT_deployableTurretsIon : PT_Base) 
{  
   title = "STEALTH ION TURRET";
   text[0] = "The Deployable Stealth Ion Turret is fitted with a Large Ion Cannon to destroy shields and disable ships.  It is designed with tactical ambushes in mind.  Once the cloak has been defeated, it also contains larger armor plates and a more reinforced hull than the previous generation Disruptor Turret, making it a deadly adversary for the surprise attack and the sustained engagement.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_deployTurret.png";
   
   compClass = "Turrets";
   
   compStat[0] = "DAM 0.05";   
   compStat[1] = "HULL 0.6";  
   compStat[2] = "LOAD 0.5"; 
   
   infoTag[0] = "UP Cloaked."; 
   infoTag[1] = "UP Devastating vs. Shields.";
   infoTag[2] = "UP Disables Ships.";   
};

new ScriptGroup (PT_deployableTurretsLeech : PT_Base) 
{  
   title = "STEALTH LEECH TURRET";
   text[0] = "The Deployable Stealth Leech Turret uses the same chassis and tech as its stealthy sister the Stealth Ion Turret, however it is now fitted with a Large Leech Emitter to sap unsuspecting ships.  Ships stumbling into the range of the Leech Emitter will quickly find themselves out of power and unable to adequately defend themselves.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_deployTurret.png";
   
   compClass = "Turrets";
   
   compStat[0] = "DAM 0.05";   
   compStat[1] = "HULL 0.6";  
   compStat[2] = "LOAD 0.5"; 
   
   infoTag[0] = "UP Cloaked."; 
   infoTag[1] = "UP Drains enemy ships' capacitors."; 
};

new ScriptGroup (PT_deployableTurretsTorpRack : PT_Base) 
{  
   title = "TORPEDO RACK";
   text[0] = "The Deployable Torpedo Rack is a strategic terror weapon.  Not only is its triple mount array of medium Torpedoes able to hammer distant targets relentlessly, but the new turret mounting means that the torpedo's lack or turning ability can be compensated for with target interception prediction by the turret mount.  The Torpedo Rack also boasts medium Heavy Armor and a medium Fortress Shield for an advanced defense.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_deployTurret.png";
   
   compClass = "Turrets";
   
   compStat[0] = "DAM 1";   
   compStat[1] = "HULL 0.8";  
   compStat[2] = "LOAD 0.3"; 
   
   infoTag[0] = "UP Triple mount."; 
   infoTag[1] = "UP Long range destruction."; 
   infoTag[2] = "UP Scanner can detect cloaked ships.";
};

new ScriptGroup (PT_deployableTurretsBattleStation : PT_Base) 
{  
   title = "BATTLE STATION";
   text[0] = "The Deployable Battle Station is the ultimate deployable defense solution.  Its dual medium Particle Cannons can shred anything it scans... twice.  The Battle Station also sports a Large Fortress Shield and Large Heavy Armor, making it more than a match for most ships twice its size.  Beware...";
   displayImage[0] = "~/gui/tutorialImages/tutImage_deployTurret.png";
   
   compClass = "Turrets";
   
   compStat[0] = "DAM 0.8";   
   compStat[1] = "HULL 1";  
   compStat[2] = "LOAD 1"; 
   
   infoTag[0] = "UP Dual mount."; 
   infoTag[1] = "UP Universally good damage."; 
   infoTag[2] = "UP Rapid Fire."; 
   infoTag[3] = "UP Scanner can detect cloaked ships.";
};

//mass bombs

new ScriptGroup (PT_massBomb : PT_Base) 
{  
   title = "THERMAL MASS BOMB";
   text[0] = "All mass bombs deliver a harmonic graviton pulse upon initial impact, slowing all non-allied ships within range.  The thermal bomb's secondary charges cause damage to all objects within range.  The explosive yield will increase as the bomb is in flight.  Eventually its yield will decreases as the bomb runs out of fuel.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_massBomb.png";
   
   compClass = "Bombs";
     
   compStat[0] = "POW 0.25"; //power use
   
   compStat[1] = "DAM 0.85"; //damage   
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.3"; //reload
  
   infoTag[0] = "HEX Good vs Hull"; 
   
};

new ScriptGroup (PT_heatBomb : PT_Base) 
{  
   title = "RESONANCE MASS BOMB";
   text[0] = "All mass bombs deliver a harmonic graviton pulse upon initial impact, slowing all non-allied ships within range.  The resonance bomb's secondary charges light damage to shields or metallic plates.  The explosive yield will increase as the bomb is in flight.  Eventually its yield will decreases as the bomb runs out of fuel.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_massBomb.png";
   
   compClass = "Bombs";   
   
   compStat[0] = "POW 0.15"; //power use
   
   compStat[1] = "DAM 0.50"; //damage   
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.5"; //reload
  
};

new ScriptGroup (PT_empBomb : PT_Base) 
{  
   title = "ION MASS BOMB";
   text[0] = "All mass bombs deliver a harmonic graviton pulse upon initial impact, slowing all non-allied ships within range.  The Ion bomb's secondary charges release a disruption pulse, disabling any nearby ships for a short period.  The explosive yield will increase as the bomb is in flight.  Eventually its yield will decreases as the bomb runs out of fuel.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_massBomb.png";
   
   compClass = "Bombs";   
   
   compStat[0] = "POW 0.25"; //power use
   
   compStat[1] = "DAM 0.85"; //damage   
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.3"; //reload
  
   infoTag[0] = "HEX VERY Good vs Shields"; 
   infoTag[1] = "UP Disables ships"; 
};

new ScriptGroup (PT_toxicBomb : PT_Base) 
{  
   title = "CORROSIVE MASS BOMB";
   text[0] = "All mass bombs deliver a harmonic graviton pulse upon initial impact, slowing all non-allied ships within range.  The corrosive bomb releases a highly acidic compound.  Any unshielded ships within the cloud will take severe damage over time. The clouds will eventually dissipate.  The explosive yield will increase as the bomb is in flight.  Eventually its yield will decreases as the bomb runs out of fuel.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_massBomb.png";
   
   compClass = "Bombs";   
   
   compStat[0] = "POW 0.25"; //power use
   
   compStat[1] = "DAM 0.85"; //damage   
   compStat[2] = "RANGE 1"; //range
   compStat[3] = "LOAD 0.3"; //reload
  
   infoTag[0] = "HEX Very Good vs Hull"; 
};

//turrets

new ScriptGroup (PT_basicTurret : PT_Base) 
{  
   title = "SINGLE MOUNT TURRET";
   text[0] = "Turrets are swivelling platforms equipped with onboard computers allowing them to track targets independently of the ship's orientation.  Turrets have an array of mounts depending on their size that are fully customizable like any other ship mount.";  
   displayImage[0] = "~/gui/tutorialImages/tutImage_turret.png";
   compClass = "Turret"; 
};

new ScriptGroup (PT_doubleTurret : PT_basicTurret) 
{  
   title = "DOUBLE MOUNT TURRET";
   text[0] = "The double mount turret sacrifices weapon mount size, for number.  Two medium mounts can be more powerful than a single large mount, although  they will usually have shorter range.";  
   displayImage[0] = "~/gui/tutorialImages/tutImage_doubleTurret.png";
   compClass = "Turret"; 
};

new ScriptGroup (PT_tripleTurret : PT_basicTurret) 
{  
   title = "TRIPLE MOUNT TURRET";
   text[0] = "The triple mount turret is the ultimate in turret technology, sacrificing one huge mount for three large ones.  The triple mount turret is able to unleash a flurry of devastation upon its target.";  
   displayImage[0] = "~/gui/tutorialImages/tutImage_triTurret.png";
   compClass = "Turret"; 
};

new ScriptGroup (PT_FixedTurretMod : PT_basicTurret) 
{  
   title = "FIXED TURRET MOD";
   text[0] = "The Fixed Turret Mod is usually a ship engineer's side project; stripping out all of a turret mounts's internal structures to create room for an oversized weapon.  Beware, the added punch comes at the cost of a complete loss of target tracking capabilities.";  
   displayImage[0] = "~/gui/tutorialImages/tutImage_fixedTurret.png";
   compClass = "Turret"; 
   
   infoTag[0] = "UP Increased weapon size";
   infoTag[1] = "DOWN No rotation";
};






//shield

new ScriptGroup (PT_basicShield_civ : PT_Base) 
{  
   title = "SURPLUS SHIELD";
   text[0] = "The surplus shield is an outdated version of the standard shield.  Shields are highly effective at deflecting projectiles and explosions, however are weak to beam technology.  All shields require an undisrupted period of time in order to re-establish after a collapse.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_shield.png";
   
   compClass = "Shield";   
   
   compStat[0] = "POW 0.25"; //power use
   compStat[1] = "CHR 0.4"; //recharge time
   
   compStat[2] = "STR 0.4"; //strength   
   
   infoTag[0] = "UP Strong VS Projectiles";
   infoTag[1] = "UP Strong VS Explosions";
   infoTag[2] = "DOWN Weak VS Beams";
};

new ScriptGroup (PT_basicShield : PT_Base) 
{  
   title = "STANDARD SHIELD";
   text[0] = "The standard shield strikes a balance between its recharge rate and maximum strength.  All shields require an undisrupted period of time in order to re-establish after a collapse.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_shield.png";
   
   compClass = "Shield";      
   
   compStat[0] = "POW 0.5"; //power use
   
   compStat[1] = "CHR 0.6"; //recharge time
   compStat[2] = "STR 0.6"; //strength   
   
   infoTag[0] = "UP Strong VS Projectiles";
   infoTag[1] = "UP Strong VS Explosions";
   infoTag[2] = "DOWN Weak VS Beams";
};

new ScriptGroup (PT_quickShield : PT_Base) 
{  
   title = "QUICK CHARGE SHIELD";
   text[0] = "A quick charge shield has a lower maximum strength, but it is able to recharge itself very quickly.  All shields require an undisrupted period of time in order to re-establish after a collapse.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_shield.png";
   
   compClass = "Shield";      
   
   compStat[0] = "POW 0.75"; //power use
   
   compStat[1] = "CHR 0.9"; //recharge time
   compStat[2] = "STR 0.3"; //strength   
   
   infoTag[0] = "UP Strong VS Projectiles";
   infoTag[1] = "UP Strong VS Explosions";
   infoTag[2] = "DOWN Weak VS Beams";
};

new ScriptGroup (PT_fortShield : PT_Base) 
{  
   title = "FORTRESS SHIELD";
   text[0] = "The fortress shield has a poor recharge rate.  Instead it maintains a massive energy field capable of absorbing maximum damage.  All shields require an undisrupted period of time in order to re-establish after a collapse.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_shield.png";
   
   compClass = "Shield";      
   
   compStat[0] = "POW 0.5"; //power use
   
   compStat[1] = "CHR 0.4"; //recharge time
   compStat[2] = "STR 1"; //strength   
   
   infoTag[0] = "UP Strong VS Projectiles";
   infoTag[1] = "UP Strong VS Explosions";
   infoTag[2] = "DOWN Weak VS Beams";
};

//reactor

new ScriptGroup (PT_basicReactor_civ : PT_Base) 
{  
   title = "SURPLUS REACTOR";
   text[0] = "The surplus reactor uses last generation technology.  It has lower than average capacity and power output.  The power output determines how quickly the capacitor is recharged.  Weapons fire, shields and engines will consume capacitor energy.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_reactor.png";
   
   compClass = "Reactor";      
   
   compStat[0] = "CAP 0.45"; 
   compStat[1] = "CHR 0.51"; 
};

new ScriptGroup (PT_basicReactor : PT_Base) 
{  
   title = "STANDARD REACTOR";
   text[0] = "The standard reactor has a good balance between it power output and capacitor size.  The power output determines how quickly the capacitor is recharged.  Weapons fire, shields and engines will consume capacitor energy.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_reactor.png";
   
   compClass = "Reactor";      
   
   compStat[0] = "CAP 0.5"; 
   compStat[1] = "CHR 0.6"; 
};

new ScriptGroup (PT_highCapReactor : PT_Base) 
{  
   title = "HIGH CAPACITY REACTOR";
   text[0] = "The high capacity reactor has a slightly lower reactor output but a massive capacitor, great for hit and run tactics.  The power output determines how quickly the capacitor is recharged.  Weapons fire, shields and engines will consume capacitor energy.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_reactor.png";
   
   compClass = "Reactor";      
   
   compStat[0] = "CAP 1"; 
   compStat[1] = "CHR 0.570"; 
};

new ScriptGroup (PT_overChargeReactor : PT_Base) 
{  
   title = "OVERCHARGE REACTOR";
   text[0] = "The overcharge reactor has a small capacitor but is able to recharge it at high speed, great for sustained fire.  The power output determines how quickly the capacitor is recharged.  Weapons fire, shields and engines will consume capacitor energy.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_reactor.png";
   
   compClass = "Reactor";      
   
   compStat[0] = "CAP 0.250"; 
   compStat[1] = "CHR 0.9"; 
};

//cloak

new ScriptGroup (PT_basicCloak : PT_Base) 
{  
   title = "STANDARD CLOAK";
   text[0] = "The standard cloak creates a convincing cloak with a reasonable recharge rate.  While engaged in cloak, the ship's movement capability is somewhat reduced to maintain stealth. Ships firing from a cloaked state do 33% bonus damage.  This bonus can be further enhanced with research and specialists.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_cloak.png";
   
   compClass = "Cloak";      
   
   compStat[0] = "POW 0.3"; //power use
   
   compStat[1] = "STR 0.4"; //strength
   compStat[2] = "CHR 0.5"; //recharge time
};


new ScriptGroup (PT_surplusCloak : PT_Base) 
{  
   title = "SURPLUS CLOAK";
   text[0] = "The surplus cloak is an old design but still a favorite for smugglers and bounty hunters on a budget.  While engaged in cloak, the ship's movement capability is somewhat reduced to maintain stealth. Ships firing from a cloaked state do 33% bonus damage.  This bonus can be further enhanced with research and specialists.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_cloak.png";
   
   compClass = "Cloak";      
   
   compStat[0] = "POW 0.2"; //power use
   
   compStat[1] = "STR 0.3"; //strength
   compStat[2] = "CHR 0.3"; //recharge time
};

new ScriptGroup (PT_stableCloak : PT_Base) 
{  
   title = "STABLE CLOAK";
   text[0] = "The stable cloak creates the strongest and most quickly re-established cloaking field, but it saps the ship's maneuverability more than any other cloak field.  Ships firing from a cloaked state do 50% bonus damage.  This bonus can be further enhanced with research and specialists.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_cloak.png";
   
   compClass = "Cloak";     
   
   compStat[0] = "POW 0.45"; //power use
   
   compStat[1] = "STR 0.9"; //strength
   compStat[2] = "CHR 0.3"; //recharge time
   
   infoTag[0] = "UP Strong Cloak";
   infoTag[1] = "DOWN Slow Movement";
};

new ScriptGroup (PT_experimentalCloak : PT_Base) 
{  
   title = "EXPERIMENTAL CLOAK";
   text[0] = "The experimental cloak allows the ship to fly at nearly full speed while cloaked.  The cloaking field is very unstable and can be easily disrupted by weapons fire.  Ships firing from a cloaked state do 50% bonus damage.  This bonus can be further enhanced with research and specialists.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_cloak.png";
   
   compClass = "Cloak";     
   
   compStat[0] = "POW 0.6"; //power use
   
   compStat[1] = "STR 0.65"; //strength
   compStat[2] = "CHR 0.9"; //recharge time
   
   infoTag[0] = "UP Fast Movement";
   infoTag[1] = "DOWN Unstable Cloak";
};

//armor

new ScriptGroup (PT_basicArmor_civ : PT_Base) 
{  
   title = "LIGHT ARMOR";
   text[0] = "Light Armor provides minimal protection to the hull.  It has low mass and protects much better than nothing at all.  Armor is divided between the four sections of the ship (front, rear, left and right side).  Crew will gradually repair damaged armor over time.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_armor.png";
   
   compClass = "Armor";     
   
   compStat[0] = "MASS 0.333"; //weight
   
   compStat[1] = "STR 0.25"; //strength   
   
   infoTag[0] = "UP Strong VS Beams";
   infoTag[1] = "UP Strong VS Explosions";
   infoTag[2] = "DOWN Weak VS Projectiles";
};

new ScriptGroup (PT_basicArmor : PT_Base) 
{  
   title = "MEDIUM ARMOR";
   text[0] = "Medium armor is thicker and thus has greater mass than light armor.  It provides a good balance between ship speed and protection.  Armor is divided between the four sections of the ship (front, rear, left and right side).  Crew will gradually repair damaged armor over time.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_armor.png";
   
   compClass = "Armor";     
   
   compStat[0] = "MASS 0.5"; //weight   
   compStat[1] = "STR 0.5"; //strength   
   
   infoTag[0] = "UP Strong VS Beams";
   infoTag[1] = "UP Strong VS Explosions";
   infoTag[2] = "DOWN Weak VS Projectiles";
};

new ScriptGroup (PT_heavyArmor : PT_Base) 
{  
   title = "HEAVY ARMOR";
   text[0] = "Heavy armor offers a large amount of hull protection; however it comes at the greatest cost to ship's speed.  Heavy armor adds a great deal of mass to the ship.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_armor.png";
   
   compClass = "Armor";     
   
   compStat[0] = "MASS 1"; //weight   
   compStat[1] = "STR 1"; //strength   
   
   infoTag[0] = "UP Strong VS Beams";
   infoTag[1] = "UP Strong VS Explosions";
   infoTag[2] = "DOWN Weak VS Projectiles";
};

new ScriptGroup (PT_advancedArmor : PT_Base) 
{  
   title = "ADVANCED ARMOR";
   text[0] = "Advanced armor offers great protection from damage, and has much less mass than heavy armor.  The trade off is that advanced armor is very expensive.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_armor.png";
   
   compClass = "Armor";      
   
   compStat[0] = "MASS 0.5"; //weight
   compStat[1] = "STR 0.80"; //strength
   
   infoTag[0] = "UP Soaks 20% extra damage";  
   
   infoTag[1] = "UP Average VS Beams";
   infoTag[2] = "UP Average VS Explosions";
   infoTag[3] = "UP Average VS Projectiles";  
};

//engines

new ScriptGroup (PT_basicEngine_civ : PT_Base) 
{  
   title = "SURPLUS ENGINE";
   text[0] = "The surplus engine is a poor imitation of a modern engine.  It has weak forward, lateral and rear thrusters.  The forward thrusters are slightly more powerful than the maneuvering thrusters.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_thruster.png";
   
   compClass = "Engine";      
   
   compStat[0] = "POW 0.25"; //power use
   
   compStat[1] = "SPEED 0.5"; 
   compStat[2] = "THRUST 0.5"; 
   compStat[3] = "MANU 0.6"; 
};

new ScriptGroup (PT_basicEngine : PT_Base) 
{  
   title = "BASIC ENGINE";
   text[0] = "The basic engine strikes a good balance between maneuverability and speed.  The forward thrusters are slightly more powerful than the maneuvering thrusters.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_thruster.png";
   
   compClass = "Engine";     
   
   compStat[0] = "POW 0.5"; //power use
   
   compStat[1] = "SPEED 0.667"; 
   compStat[2] = "THRUST 0.667"; 
   compStat[3] = "MANU 0.8"; 
};

new ScriptGroup (PT_thrusterEngine : PT_Base) 
{  
   title = "THRUSTER ENGINE";
   text[0] = "The thruster engine trades maneuverability for maximum top speed.  These engines can achieve the greatest forward speeds, but only have a tiny amount of side and rear thrust.  Thruster engines are great for fast getaways and strafing, but not so much for close combat";
   displayImage[0] = "~/gui/tutorialImages/tutImage_thruster.png";
   
   compClass = "Engine";     
   
   compStat[0] = "POW 0.75"; //power use
   
   compStat[1] = "SPEED 1"; 
   compStat[2] = "THRUST 0.667"; 
   compStat[3] = "MANU 0.7"; 
};

new ScriptGroup (PT_inertialEngine : PT_Base) 
{  
   title = "INERTIAL ENGINE";
   text[0] = "The inertial engine creates a stable gravity well around the ship, giving it nearly perfect equalized movement in all directions.  Ships sporting inertial engines are the most maneuverable, and have the highest acceleration.  The downside is that Inertial engines eat power, and cannot quite match the thruster engine's top speed.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_thruster.png";
   
   compClass = "Engine";     
   
   compStat[0] = "POW 1"; //power use
   
   compStat[1] = "SPEED 0.8"; 
   compStat[2] = "THRUST 1"; 
   compStat[3] = "MANU 1"; 
};

////////////////////////////////////////////////////////////////////////////////
//HULL TUTORIALS
////////////////////////////////////////////////////////////////////////////////


//USED for ships, but do we use HIGHEST or LOWEST?
//Highest only used in special cases. multa cargo carrier also used.
function PT_GetBarValue(%multValue, %minValue, %maxValue)
{
   %progressVal = %multValue - %minValue;
   if ( %progressVal < 0 )
      %progressVal = 0;
      
   %valueRange = %maxValue - %minValue;
   %realProgress = mClamp(%progressVal / %valueRange, 0, 1);
   %realProgress *= 0.8;
   
   %val = 0.2 + %realProgress;
   
   return %val;  
}


function PT_ShipDatablock::OnAdd(%this)
{
   if ( %this.title $= "" )
      return;
   
   if ( !isObject(%this.myHull) )
      return; //will happen in a demo game. 
      
   %myHull = %this.myHull.getId();
   
   
   %hullStrength  = PT_GetBarValue(%myHull.comparativeHealth, $MULT_VERYLOW, $MULT_VERYHIGH);
   %hullMass      = PT_GetBarValue(%myHull.comparativeMass, $MULT_VERYLOW, $MULT_VERYHIGH);
   %hullTurnSpeed = PT_GetBarValue(%myHull.hullTurnSpeedMod, $MULT_VERYLOW, $MULT_VERYHIGH);
   %hullCrew      = PT_GetBarValue(%myHull.comparativeCrew, $MULT_VERYLOW, $MULT_HIGHEST);
   %hullCargo     = PT_GetBarValue(%myHull.comparativeCargo, $MULT_VERYLOW, $MULT_CARGOCARRIER / 2); //actually is CargoCarrier, but we dont wanna dwarf other bars.
   
   %this.compStat[0] = "HULL" SPC %hullStrength;
   %this.compStat[1] = "MASS" SPC %hullMass;
   %this.compStat[2] = "TURN" SPC %hullTurnSpeed;
   %this.compStat[3] = "CREW" SPC %hullCrew;
   %this.compStat[4] = "CARGO" SPC %hullCargo;   
}


new ScriptGroup (PT_ShipBase : PT_Base) 
{  
   class = "PT_ShipDatablock";
   
   title = "";
   text[0] = "missing tutorial";
   displayImage[0] = "~/gui/tutorialImages/tutImage_dart.png";
   
   compClass = "Hull";   
   
   compStat[0] = ""; //prevents zombie ships from pulling random mem
};

//TINY

new ScriptGroup (PT_HullDart : PT_ShipBase) 
{  
   title = "DART";
   text[0] = "The Dart is a basic fighter.  It has two forward guns but a fragile hull, making the Dart agile but easily dispatched if damaged.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_dart.png";
   
   myHull = HullDart;
};

new ScriptGroup (PT_HullShortBus : PT_ShipBase) 
{  
   title = "SHORT BUS";
   text[0] = "The Short Bus is a tiny mining ship designed to break up small asteroids for processing.  It has little value in combat, but its almost non existent production costs make it a reliable fallback ship.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_shortbus.png";
   
   myHull = HullShortBus;  
};


new ScriptGroup (PT_HullRanger : PT_ShipBase) 
{  
   title = "SCOUT";
   text[0] = "The Scout packs a punch, considering its size.  It has both a forward weapon mount, and a missile launcher.  Unfortunately the launcher is rear mounted, making it somewhat tricky to use effectively.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_ranger.png";
  
   myHull = HullRanger;
};

new ScriptGroup (PT_HullCab : PT_ShipBase) 
{  
   title = "GOPHER";
   text[0] = "The Gopher is a tiny utility ship used by much larger science vessels to conduct experiments and retreive hazardous materials.  The Gopher's thick hull and newly added forward mounts make it a capable combat vessel.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_cab.png";
  
   myHull = HullCab;
};

new ScriptGroup (PT_HullRetina : PT_ShipBase) 
{  
   title = "GYRO";
   text[0] = "The Gyro is an armored mobile defensive turret platform.  It's the only ship of its class that can support a free moving turret.  Its spherical shape maximizes crew capacity and maneuverability.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_retina.png";
   
   myHull = HullRetina;   
};

new ScriptGroup (PT_HullMole : PT_ShipBase) 
{  
   title = "GRASSHOPPER";
   text[0] = "The Grasshopper is a modified life boat, trading crew capacity for dual offset missile mounts.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mole.png";
  
   myHull = HullMole;  
};

//SMALL

new ScriptGroup (PT_HullGimp : PT_ShipBase) 
{  
   title = "GIMP";
   text[0] = "The Gimp is a light assault craft equipped with two guns and a launcher mount.  It's fast and agile, but lacks any significant hull strength.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_gimp.png";
   
   myHull = HullGimp;  
};

new ScriptGroup (PT_HullBoomerang : PT_ShipBase) 
{  
   title = "BOOMERANG";
   text[0] = "The Boomerang is a very light and therefore maneuverable ship, trading firepower for speed. It is lightly armed for its class, with only two forward guns, but it is very hard to hit when piloted by an expert.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_boomerang.png";
   
   myHull = HullBoomerang;  
};

new ScriptGroup (PT_HullScout : PT_ShipBase) 
{  
   title = "RANGER";
   text[0] = "The Ranger is a good all round ship for its size class.  It has two forward guns and two launchers.  It's fast, agile, and has decent hull strength.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_scout.png";
 
   myHull = HullScout;  
};

new ScriptGroup (PT_HullColt : PT_ShipBase) 
{  
   title = "COLT";
   text[0] = "The Colt is a heavy assault craft.  Its array of forward firing cannons are capable of dishing out tremendous amounts of damage.  Often, the Colt's fire rate is beyond the reactor's ability to maintain, though it still is the most deadly ship of its size class.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_colt.png";
   
   myHull = HullColt;  
};


new ScriptGroup (PT_HullHatchet : PT_ShipBase) 
{  
   title = "HATCHET";
   text[0] = "The Hatchet was originally a miner/cargo hauler.  It is quite heavy, but the Hatchet's thick hull and huge cargo capacity make it both a great miner and a worthy combat vessel.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_hatchet.png";

   myHull = HullHatchet;
};


new ScriptGroup (PT_HullGirlScout : PT_ShipBase) 
{  
   title = "TURTLE HEAD";
   text[0] = "The Turtle Head was the nickname given to this predecessor of the Ranger.  It has recently come back into service as a crew transport and utility vessel, with some basic combat ability.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_girlscout.png";
 
   myHull = HullGirlScout;  
};

//MED

new ScriptGroup (PT_HullTug : PT_ShipBase) 
{  
   title = "TUG";
   text[0] = "The Tug is a mid range cargo carrier.  Armed with a turret and missiles, it is more than capable of defending itself in combat, while still being able to harvest and haul nearby resources.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_tug.png";
   
   myHull = HullTug;  
};

new ScriptGroup (PT_HullVolley : PT_ShipBase) 
{  
   title = "VOLLEY";
   text[0] = "The Volley is a dedicated missile launching platform.  It is capable of delivering a massive amount of firepower at very long range.  The Volley has no other weapons of any kind, forcing it to rely on other ships for defense.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_volley.png";
   
   myHull = HullVolley;  
};

new ScriptGroup (PT_HullSaucer : PT_ShipBase) 
{  
   title = "SAUCER";
   text[0] = "The Saucer is an agile close range fighter with an array of forward guns and a small turret.  It is the most maneuverable ship within its size class.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_saucer.png";
   
   myHull = HullSaucer; 
};

new ScriptGroup (PT_HullGull : PT_ShipBase) 
{  
   title = "GULL";
   text[0] = "The Gull is one of the smallest ships capable of delivering a mass bomb.  The Gull is a ship built around a mass bomb, leaving little room for other weapons.  Two small forward guns keep the gull from being totally defenseless at close range.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_gull.png";
   
   myHull = HullGull; 
};

new ScriptGroup (PT_HullArray : PT_ShipBase) 
{  
   title = "ARRAY";
   text[0] = "The Array is a research ship.  It comes equipped with several utility slots and forward projectile mounts.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_array.png";
  
   myHull = HullArray; 
};

new ScriptGroup (PT_HullPounder : PT_ShipBase) 
{  
   title = "POUNDER";
   text[0] = "The Pounder was once a dedicated asteroid cracker.  Originally using resonance bombs for mining, it has now been upgraded to carry any bomb type.  Its standard weaponry is somewhat limited compared to other ships of its class.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_pounder.png";
  
   myHull = HullPounder; 
};

new ScriptGroup (PT_HullYacht : PT_ShipBase) 
{  
   title = "YACHT";
   text[0] = "The Yacht was originally a rich man's toy with all the bells and whistles.  Since the Lockdown Wars, it's been gutted and turned into a crew carrier for refugees, with some limited offensive weaponry.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_yacht.png";
 
   myHull = HullYacht; 
};

new ScriptGroup (PT_HullHound : PT_ShipBase) 
{  
   title = "HOUND";
   text[0] = "The Hound was the predecessor of the Saucer, and some diehards say it is still the superior ship.  The Lockdown Wars saw the Hound come back into service after having been mothballed for decades.  After all these years, the Hound is still a capable and agile warship.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_hound.png";
   
   myHull = HullHound; 
};

//LARGE

new ScriptGroup (PT_HullMule : PT_ShipBase) 
{  
   title = "MULE";
   text[0] = "The Mule was once a dedicated cargo vessel, but it has recently been upgraded into a serviceable combat ship.  Although still comparatively slow, its turrets and missiles allow the Mule to defend itself at any range.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mule.png";
  
   myHull = HullMule; 
};

new ScriptGroup (PT_HullRighthook : PT_ShipBase) 
{  
   title = "RIGHT HOOK";
   text[0] = "The Right Hook is a maneuverable brawler.  Its array of large guns makes it great for hammering other ships.  The Right Hook is also equipped with a large launcher mount for long range engagements.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_righthook.png";
   
   myHull = HullRighthook; 
};

new ScriptGroup (PT_HullHelix : PT_ShipBase) 
{  
   title = "HELIX";
   text[0] = "The Helix has a single turret and forward gun.  Its primary function is to carry the largest mass bombs, which can devastate a huge area.  The Helix was constructed as a bomb delivery system and can do little else.  The Helix is best partnered with a ship capable of more direct combat.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_helix.png";
   
   myHull = HullHelix; 
};

new ScriptGroup (PT_HullBigBrother : PT_ShipBase) 
{  
   title = "BIG BROTHER";
   text[0] = "The Big Brother is a heavily armoured jack of all trades.  Its specially modified missile mount is usually only found on huge vessels.  It also carries a single large turret and a drone bay for direct combat.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bigbrother.png";
   
   myHull = HullBigBrother; 
};

new ScriptGroup (PT_HullCrawler : PT_ShipBase) 
{  
   title = "CRAWLER";
   text[0] = "The Crawler is a dedicated turret array.  It has no other weapon mounts of any kind.  It lack any large sized turret mounts, but makes up for turret size with quantity.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_crawler.png";
   
   myHull = HullCrawler; 
};

new ScriptGroup (PT_HullFlora : PT_ShipBase) 
{  
   title = "FLORA";
   text[0] = "The Flora is a dedicated research ship.  It has little offensive power, but an array of utility mounts, and a drone bay ensures its usefulness.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_flora.png";
  
   myHull = HullFlora; 
};

new ScriptGroup (PT_HullGrinder : PT_ShipBase) 
{  
   title = "GRINDER";
   text[0] = "The Grinder was once a dedicated asteroid cracker.  Its massive forward mount has since been converted to use any projectile or beam weapon normally only found on huge ships.  Powering the Grinder's huge mount is a constant challenge";
   displayImage[0] = "~/gui/tutorialImages/tutImage_grinder.png";
  
   myHull = HullGrinder; 
};

new ScriptGroup (PT_HullBigBus : PT_ShipBase) 
{  
   title = "BIG BUS";
   text[0] = "The Big Bus has a standard array of forward projectile mounts and utility devices.  Originally a civilian transport ship, its crew capacity is beyond any other ship of its class.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bigbus.png";

   myHull = HullBigBus; 
};

//HUGE

new ScriptGroup (PT_HullHammerHead : PT_ShipBase) 
{  
   title = "HAMMERHEAD";
   text[0] = "The Hammerhead, a true modern battleship, relies on maneuverability and two massive turret mounts to devastate targets of all sizes.  Together with its selection of small turrets, the Hammerhead can fight off multiple attacks with ease.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_hammerhead.png";
   
   myHull = HullHammerHead; 
};

new ScriptGroup (PT_HullSunSpot : PT_ShipBase) 
{  
   title = "SUNSPOT";
   text[0] = "The Sunspot is more of a mobile hangar than anything else.  It houses a few assorted turrets, but primarily focuses on using its triple drone launchers to attack targets.  Because of its round shape, the Sunspot is very maneuverable for its size.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_sunspot.png";
  
   myHull = HullSunSpot; 
};

new ScriptGroup (PT_HullStarCruiser : PT_ShipBase) 
{  
   title = "STAR CRUISER";
   text[0] = "The Star Cruiser was once a luxury liner, now converted to be a warship in a time of need.  Massive forward facing cannons and launchers make it absolutely devastating in head to head combat.  It does quite poorly at fending off multi pronged attacks as it has very few turreted weapons and a poor turning rate.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_starcruiser.png";
   
   myHull = HullStarCruiser; 
};

new ScriptGroup (PT_HullFreighter : PT_ShipBase) 
{  
   title = "CARRIER";
   text[0] = "The Carrier is the oldest ship of its class.  It's been retrofitted many times over the years to serve ever changing roles.  As a result, its device and mount locations are quite unorthodox, most notably the side firing missile array.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_freighter.png";
   
   myHull = HullFreighter; 
};

new ScriptGroup (PT_HullCarrier : PT_ShipBase) 
{  
   title = "FREIGHTER";
   text[0] = "The Freighter is a massive multi purpose cargo vessel.  For its size, it's incredibly cost effective.  Its offensive capabilities are minimal for its size, but it houses a huge array of utility mounts, making it ideal for mining work, or support duties.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_carrier.png";

   myHull = HullCarrier;
};

////////////////////////////////////////////////////////////////////////////////
//bounty ships
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup (PT_Claw : PT_ShipBase) 
{  
   title = "CLAW";
   text[0] = "The Claw is a rather unimpressive vessel except for the 2 oversize forward mounts.  The ship typically has a hard time powering its weapons, but in the hand of the right pilot, it can be deadly.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_claw.png";

   myHull = HullBounty_Tiny_01;
};

new ScriptGroup (PT_Wasp : PT_ShipBase) 
{  
   title = "WASP";
   text[0] = "The Wasp is a tiny ship with a big surprise.  It can carry a single medium class launcher weapon and 2 utility slots to boost its short comings.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_wasp.png";

   myHull = HullBounty_Tiny_02;
};

new ScriptGroup (PT_Cyclops : PT_ShipBase) 
{  
   title = "CYCLOPS";
   text[0] = "The Cyclops is quite an odd ball.  It has a single huge forward mount, but a wealth of utility slots.  If utilized correctly, this can be one hell of a hit and run ship.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_cyclops.png";

   myHull = HullBounty_Small_01;
};

new ScriptGroup (PT_LeftHook : PT_ShipBase) 
{  
   title = "LEFT HOOK";
   text[0] = "The Left Hook is a dedicated missile launcher.  It has a single, but oversized large launcher mount.  The ship has no other weapons of any kind, but has a wealth of utility mounts.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_leftHook.png";

   myHull = HullBounty_Small_02;
};

new ScriptGroup (PT_Raven : PT_ShipBase) 
{  
   title = "RAVEN";
   text[0] = "The Raven is the smallest ship of its class to support a drone bay.  The trade off is it lacks a bit of direct firepower.  Plentiful utility mounts can make up for its shortcomings.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_raven.png";

   myHull = HullBounty_Medium_01;
};

new ScriptGroup (PT_GunSlinger : PT_ShipBase) 
{  
   title = "HYDRA";
   text[0] = "The Hydra is a medium class fighter ship.  It has several forward mounts, as well as some launchers.  Utility slots allow the ship to be boosted to adapt to various combat situations.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_gunSlinger.png";

   myHull = HullBounty_Medium_02;
};

new ScriptGroup (PT_Pelican : PT_ShipBase) 
{  
   title = "PELICAN";
   text[0] = "The Pelican is essentially a flying missile rack.  It doesn't have much direct firepower, but correct usage of its many utility slots can make it a force to be reckoned with.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_pelican.png";

   myHull = HullBounty_Large_01;
};

new ScriptGroup (PT_Sloth : PT_ShipBase) 
{  
   title = "BRUTE";
   text[0] = "The Brute is an overpowered turreted platform.  Careful use of utility mounts is the only way to keep this ship from sapping reactor power.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_Sloth.png";

   myHull = HullBounty_Large_02;
};


new ScriptGroup (PT_Mammoth : PT_ShipBase) 
{  
   title = "MAMMOTH";
   text[0] = "The Mammoth is the largest ship to carry a bomber mount.  Normally pilots like to use smaller ships capable of fleeing a bombs blast radius.  The Mammoth also has several turrets and utility mounts available.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bigTrouble.png";

   myHull = HullBounty_Huge_01;
};

new ScriptGroup (PT_MantaRay : PT_ShipBase) 
{  
   title = "MANTA RAY";
   text[0] = "The Manta Ray is basically a wall of forward mounts.  The ship has no indirect fire offensive mounts, but whoever is unlucky enough to get in front of this thing is dead.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_stingRay.png";

   myHull = HullBounty_Huge_02;
};





