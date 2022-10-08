
////////////////////////////////////////////////////////////////////////////////
//tutorial def
////////////////////////////////////////////////////////////////////////////////

// base tutorial

new ScriptGroup (tutorialBase) 
{
   class = "TutorialObjectClass";
   character = "TUTORIAL";
   displayInLister = false;
   onlyShowAfterUse = false;
   markOnRead = false; //some tutorials never call from flow, so we mark them when you read them
   
   objectivePreReq = "";
   
   isMotherUp = false;
   motherLevel = 0;
   
   title = "";
   
   text[0] = "";
   displayImage[0] = "";
   startupSound = "snd_tutorialNew"; 
};

////////////////////////////////////////////////////////////////////////////////
//FLOW BASED TUTORIALS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup (ObjectivesTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "WHAT AM I DOING AGAIN?";

   text[0] = "Nearly everything of importance is marked with the radar, allowing you to see it when it's off screen.  Radar indicators will be pinned to the edge of the screen, showing you the direction to and orientation of other ships.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_radar.png";
   
   text[1] = "If you get confused as to what you should be doing, you can see your primary objective in the ship's log (F1).  Just about every menu you see will have a HELP indicator.  Click the help indicators to find out useful information about what you are looking at.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_help.png";

};

new ScriptGroup (CombatTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "KILL OR BE KILLED";
   
   text[0] = "Keep an eye on the condition of your ship in the upper left corner.  You can see how much armor, hull, and shield strength you have by their color.  Green is healthy, while red means you are in trouble.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_shipHUD.png"; 
   
   text[1] = "You can push ^STR_nextTarget and ^STR_prevTarget to lock on to various non-allied targets to see a similar readout of their ship in the upper right corner.  Enemy readouts have indicators for which faction they belong to, as well as their faction relationship with you.  Always check your targets, so you don't accidentally fire upon friends.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_enemyHud.png"; 

   text[2] = "Watch your capacitor level, as it directly controls your ability to fire weapons.  Shields, cannons, lasers and launchers all take power to operate.  Even sustained thrust will slow your recharge rate.  If you tap out your power supply, you'll be left defenseless until it can recharge.  Make your shots count, and fire in short bursts.";
   displayImage[2] = "~/gui/tutorialImages/tutImage_reactorCargo.png"; 
};

new ScriptGroup (FleeTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "SUICIDE IS NEVER THE ANSWER";
   
   text[0] = "If you ever feel outgunned, you can always use the MASS RETREAT command from the TACTICS PANEL.  You'll lose any current mission progress, but you get to keep all the Rez, data, and levelups you've collected.  Ships are expensive, so don't try and fight a losing battle.  If you find yourself with no ships or Rez, fall back and harvest some Rez in a safe location.  You can always build a Short Bus ship for free.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_retreat.png"; 
};

new ScriptGroup (FineStuffToBuy : tutorialBase) 
{  
   displayInLister = true;
   onlyShowAfterUse = true;
   title = "YOU HAVE SOME REZ.  NOW SPEND IT!";
   
   text[0] = "Rez can be used for more than just pumping out ships.  You can use it to buy new weapons and components on the Black Market.  You will have a hard time getting anywhere in the galaxy without buying new gear.  Black markets can usually be found at UTA and Civilian space stations.  Explore often, and keep an eye out for the vendor icon to see if a station has items for sale.  You'll also need to watch the faction relation icon.  If the station's faction dislikes you, you won't be able to buy from them.  You'll either have to find a way to make them happy, or you'll have to take what you want by force (not recommended for rookies).";
   displayImage[0] = "~/gui/tutorialImages/tutImage_buyStuff.png";
};


new ScriptGroup (FleetControlTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "FLEET CONTROL";
   
   text[0] = "You are free to switch between all the ships you currently have in your fleet by pressing the (NUMBER KEY) associated with each hangar.  Alternatively, you can cycle between all your active ships with the ^STR_nextShip or ^STR_prevShip key.  Any ship you are not directly controlling will be controlled by AI.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_fleetWarp.png";
};

new ScriptGroup (AsteroidMiningTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "REZ PROCESSING";
   
   text[0] = "The mothership is too slow to scout for Rez on its own, so it deploys a short range warp beacon that can transfer ships and Rez back and forth instantly.  You can find Rez by destroying asteroids with weapons fire (MOUSE 1).  Fly over Rez to load it into the cargo hold.  Return to the beacon to automatically transfer Rez back to the mothership for processing.  You can see your processed Rez count in the upper left corner of the screen.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mining.png";
   
   text[1] = "Keep an eye on how much cargo space your ships have.  The more full the cargo bay, the slower that ship will go.  Be aware that smaller ships can not carry large deposits of Rez.  If you do not have a large enough ship, you can always break Rez apart with weapons fire.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_reactorCargo.png";
};

new ScriptGroup (ZombieTutorial : tutorialBase) 
{  
   displayInLister = true;
   onlyShowAfterUse = true;
   title = "ZOMBIES!";
   
   text[0] = "Zombies have a complex ecology.  Zombie ships come in two flavours.  The first is a breeder.  Breeders have no armor or shields, making them nice and squishy.  Breeders will lay eggs that will eventually hatch into new breeders.  Breeders do not attack to kill, but rather to infect.  They infect other ships by saturating them with critters.  When a ship has become infected it will begin to produce eggs, further spreading the infection.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_zom1.png";

   text[1] = "When a ship falls to the infection, it will transform into a zombie version of that ship.  Zombified ships act differently than breeder ships.  They are stupid and will blindly attack any ship that isn't infected.  Both breeders and zombified ships have partially organic hulls that quickly regenerate over time.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_zom2.png";
   
   text[2] = "The best way to combat the infection is to deal with it early, before it has a chance to spread across the area.  Having lots of crew on board your ships can help in fighting off infection.  Try to keep infected ship away from clean ships, or the infection will spread.  If you have infected ships, you can VENT THE CREW from the TACTICS PANEL to get rid of every living thing on the ship but the captain (must have at least 1 crew member to vent).";
   displayImage[2] = "~/gui/tutorialImages/tutImage_zom3.png";

};

new ScriptGroup (BystandTutorial : tutorialBase) 
{  
   displayInLister = true;
   onlyShowAfterUse = true;
   title = "AMBIENT EVENT";
   
   text[0] = "Ambient events pop up from time to time.  There is no particular objective to an ambient event.  Ambient events do tend to have some valuable resources that you may want to exploit.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bystand.png";
};

new ScriptGroup (CombatEventTutorial : tutorialBase) 
{  
   displayInLister = true;
   onlyShowAfterUse = true;
   title = "CONFLICT EVENT";
   
   text[0] = "A conflict event occurs when the local factions in the system can't get along, which is most of the time.  There is no particular objective in a combat event, but you are free to participate.  A combat event is a great place to earn some black box data from destroyed ships.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_combatEvent.png";
};


new ScriptGroup (SecondaryMissionTutorial : tutorialBase) 
{  
   displayInLister = true;
   onlyShowAfterUse = true;
   title = "SECONDARY MISSION";
   
   text[0] = "Secondary mission are unique missions related to current events in the galaxy.  Each secondary mission can only be completed once, and they are entirely optional.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_secondaryMission.png";
};

new ScriptGroup (OpenWorldTutorial : tutorialBase) 
{  
   displayInLister = true;
   onlyShowAfterUse = true;
   title = "OFF COME THE TRAINING WHEELS";
   
   text[0] = "You are now being let loose upon the galaxy.  You are free to take jobs, interact with colonies and wreak havoc.  Take your time, and explore the universe.  Use the objective screen (F1) if you need to get yourself back on track.  Check the System map (F5) frequently to see what's going on in the neighborhood.  Clear additional warp gate blockades and travel to new star systems using the Star map (F6).";
   displayImage[0] = "~/gui/tutorialImages/tutImage_openWorld.png";
   
   text[1] = "If at any time you feel the need for a refresher, you can push (F7) to see a list of all the tutorials you have been presented with so far.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_listerHint.png";
};

////////////////////////////////////////////////////////////////////////////////
//CONTEXTUAL TUTORIALS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup (CON_TUT_CrewCollectionAndUses : tutorialBase) 
{  
   objectivePreReq = "S1_AcceptFavor1";
   
   displayInLister = true;
   title = "CREW AND GOONS";
   
   text[0] = "Each ship hangar has a desired surplus crew count (default 20%).  This value can be changed in the hangar view.  When a ship is created from that hangar, it draws upon the pool of excess goons to fill the desired crew count.  As the goon pool drains, the ship may not be able to fully staff the desired count.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_escapePods.png";   
   
   text[1] = "Having lots of crew on board your ships has many advantages.  Crew members can repair damaged hull and armor components.  They can also fight off foreign invaders that find their way on board the ship.  Alternatively, goons that are not on board your ships can be sold at some space stations for various commodities.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_escapePods.png"; 
   
   text[2] = "You'll see escape pods being ejected from destroyed ships.  Retrieve escape pods to recruit more crew members.  Pods of an enemy faction may not accept their new life as a pirate, and will be frequently tossed out the air lock.  If the captured crewman accepts pirate life, that ship's crew count will increase (low faction relations and high ship crew count will decrease conversion chance).  If a ship ends up with more crew than the desired crew count, the extra crewmen will be deposited into the pool of excess goons when the ship warps, refits, or goes back for repairs.";
   displayImage[2] = "~/gui/tutorialImages/tutImage_escapePods.png";   
};


new ScriptGroup (CON_TUT_Levelup : tutorialBase) 
{  
   //RLBRLB talk about xp multi
   
   displayInLister = true;
   title = "LEVELING UP";
   
   text[0] = "You will earn level ups as you collect data pickups.  Data can be found in many places, but most commonly from destroyed ships.  Each time you gain a level, you receive upgrade points to spend in the research screen.  Push (F4) to view the research screen.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_levelup.png"; 
   
   //not a good place
   //text[0] = "As you gain levels and research technology you'll be able to more impressive weapons and devices on your ships; however you must purchase the blueprints for these items at space stations.  Keep an eye out for venders in the galaxy.";
   //displayImage[0] = "~/gui/tutorialImages/tutImage_levelup.png";   
};

new ScriptGroup (CON_TUT_BlackBox : tutorialBase) 
{  
   displayInLister = true;
   title = "BLACK BOXES";
   
   text[0] = "When you destroy a ship, the black box will be left behind.  Collect black boxes to reverse engineer that ship type.  The larger ships will require more black boxes in order to successfully reverse engineer.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_blackbox.png";   
};

/* //no longer used
new ScriptGroup (CON_TUT_CLONING : tutorialBase) 
{  
   displayInLister = true;
   title = "CLONING";
   
   text[0] = "Each time you level up, new cloned goons become available.  Af first, cloning may seem slow, but with the right cloning specialists and an improved mothership, you will be churning out armies in no time.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_placeholder.png";   
};
*/

new ScriptGroup (CON_TUT_ShipLost : tutorialBase) 
{  
   displayInLister = true;
   title = "MY SHIP WENT BOOM!";
   
   text[0] = "When you have lost a ship, you can easily rebuild it by pressing the number key associated with that hangar (providing you can afford to rebuild it).  There is also an auto-rebuild function in the Hangar View (F3).  Keep your fleet at max size whenever possible.  Try outfitting your ships with different weapons for different situations.  If you simply can't afford to build any more ships, you can always revert to the basic Short Bus design free of charge.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_fleetWarp.png";   
};

new ScriptGroup (CON_TUT_CloakDetect : tutorialBase) 
{  
   displayInLister = true;
   title = "CLOAK DETECTOR";
   
   text[0] = "When there is something in the area that is cloaked, the cloak detector will begin to flash.  The more rapidly it flashes, the closer the cloaked object is.  This is a crude, but reliable way to detect a cloak; however there are cloak detecting sub systems.  You can also turn the tables on your enemies and install cloaking devices on your own ships instead of shields.  Keep an eye out for these components for sale at space stations.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_firstCloak.png";   
};

new ScriptGroup (CON_TUT_MineDetect : tutorialBase) 
{  
   displayInLister = true;
   title = "MINE FIELDS";
   
   text[0] = "The cloak detector can scan areas that have been mined.  You can also periodically see mines emit a detection ping.  If a mine detects a hostile target within its ping range, it will try to attach itself to the target and explode.  Mines are never solitary and come in large groups maintained by a near by mine generator.  If the mine generator is destroyed, the mine field will collapse.  Both mines and generators are cloaked, but the basic cloak detector will only detect generators.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mines.png";   
};

new ScriptGroup (CON_TUT_BeaconDestroyed : tutorialBase) 
{  
   displayInLister = true;
   title = "BEACON DESTROYED";
   
   text[0] = "The BEACON has been destroyed.  You cannot build any more ships or refit or repair them at the Mothership.  Short range jumping has been disabled, so the only way to exit this sector of space is to retreat back to the Mothership.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_beaconLost.png";   
};



////////////////////////////////////////////////////////////////////////////////
//SCREEN BASED TUTORIALS
////////////////////////////////////////////////////////////////////////////////

//research screen //only used when player clicks ? button

new ScriptGroup (ResearchTutorial : tutorialBase) 
{  
   displayInLister = true;
   markOnRead = true;
   title = "RESEARCH";
  
   text[0] = "After you've leveled up and earned some upgrade points, there are several categories you can upgrade.  Each category has several upgrades that increase that technology's efficiency.  Many advanced ship weapons and components will have a prerequisite level, meaning you can't use the most advanced components without first upgrading that component's technology category.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_levelup.png";
};

new ScriptGroup (ObsoleteTutorial : tutorialBase) 
{  
   displayInLister = true;
   markOnRead = true;
   title = "OBSOLETE SHIPS";
  
   text[0] = "When you finish upgrading your technology, some of your ships may become obsolete.  You can upgrade these ships for free.  Use the REPAIR command from the TACTICS PANEL to send them back to the mothership for upgraded parts.  Obsolete ships are automatically updated any time you warp to a new location.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_Obsolete.png";
};

//ship building

new ScriptGroup (ShipBuildingTutorial : tutorialBase) 
{  
   //RLBRLB mention AI controlled ships
   
   displayInLister = true;
   title = "SHIP CUSTOMIZATION";
   
   text[0] = "From the hangar view, you can fully customize every aspect of your ship designs.  By default, your ship will be outfitted with nothing but surplus components.  Even early on, you'll have access to several different components.  Click on the mount icons on the ship to see what else you can install.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_shipDesignBasic.png";
   
   text[1] = "You can also modify shields, engines and the reactor, which powers everything on the ship.  The more advanced the component, the more it will cost you.  Be sure to refit your obsolete ships whenever you unlock new technology.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_designSystems.png";
   
   text[2] = "As your mothership becomes more advanced, additional hangars will be added.  Old hangars will also be upgraded, allowing them to support larger ships.  It's usually wise to build the largest ships available if you can afford them.";
   displayImage[2] = "~/gui/tutorialImages/tutImage_fleetWarp.png";

};

new ScriptGroup (ArmorTutorial : tutorialBase) 
{  
   //RLBRLB mention AI controlled ships
   
   displayInLister = true;
   title = "ARMOR PLATES";
   
   text[0] = "All but the smallest ships can have armor plating installed.  Different plating types can be mounted to different quadrants of the ship.  Depending on the size and shape of a ship, some armor sections tend to take more damage than others.  Each installed plate will add cost and weight to the ship.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_designArmor.png";
};

//starmap tutorial

new ScriptGroup (StarmapTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "STAR MAP";
   
   text[0] = "As you clear warp gate blockades, you'll unlock connections that allow you to travel to different star systems.  The star map shows all the warp gate connections in the galaxy and how powerful each star is.  As you get closer to the core, the stars' tech levels will increase.  Beware of traveling to a star with a level well beyond your own.  The more dangerous a star is, the more red its icon will be.  If a star is beneath your level, it will be green, while yellow means your levels are evenly matched.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_starmap.png"; 
   
   text[1] = "In addition to the tech level, there are many defining features of a star system.   Most important is the Civilian and UTA relationship with you.  Your actions can change these relationships, altering how they respond to you, and what missions are available.  Your relationships do not carry over from one star to another.  Every new star you come across will have an untainted (but not necessarily hospitable) opinion of you.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_relation.png";  
};

//system map tutorial

new ScriptGroup (SystemMapTutorial : tutorialBase) 
{ 
   //RLBRLB mention orange combat events and yellow ped events ... mouse overs too
   
   displayInLister = true; 
   title = "SYSTEM MAP";
   
   text[0] = "Every star system has some level of Civilian and UTA presence.  Many conflicts erupt within a system and it's up to you to interact with them or not.  Choosing to interact with an event or not can have long lasting effects on the system and its inhabitants.  Be aware that the galaxy may entice you to make some hard decisions, like killing friendly ships to gain quick resources, data and especially blueprints.  Mouse over the event markers in the system map to find out exactly what is going on there.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_systemmap.png"; 
   
   text[1] = "Usually UTA ships are the most likely to cause you trouble when in any given star system.  Their ships blockade all the warp gate exits.  If you want to travel to any new star systems, you'll have to deal with a UTA blockade.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_warpgate.png";     
};


//specialist tutorial

new ScriptGroup (SpecialistTutorial : tutorialBase) 
{ 
   displayInLister = true; 
   title = "SPECIALISTS";
   
   text[0] = "Specialists can be placed in command positions on your mothership.  Each specialist has a unique set of skills that will increase if they are active when you level up. Higher level systems will have higher level specialists with higher base skills.  Some specialists are also better than others, having a far greater array of skills available.  These specialists also usually have bonus requirements that if satisfied will increase their power by 33%.  Specialists can be viewed from the HANGAR VIEW (F3).  Specialists can only be swapped while near the mothership.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_specialist.png"; 
};


new ScriptGroup (TacticsPanelTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "TACTICS PANEL";
   
   text[0] = "From the tactics panel you get a complete radar view of the battlefield.  Select ships with (LEFT CLICK) and issue attack and move orders with (RIGHT CLICK).  You can drag select multiple ships to give group orders.  You can also customize various autopilot functions from the tactics panel.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_tacticsPanel.png";   
   
   text[1] = "When you are not directly controlling your ships, the AI kicks in to navigate, fight, harvest Rez and do basically everything a human pilot would.  At any time you can see the state of all your ships in the hangar view to the left side of the screen.  You can select different ships by pressing the (NUMBER KEY) associated with their hanger.  If that hangar is empty, you can prompt it to quickly build a new ship by pressing the (NUMBER KEY) of a hangar with no active ship.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_fleetWarp.png";  

};

new ScriptGroup (CatalogTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "BLACK MARKET CATALOG";
   
   text[0] = "Most star systems have weapon and component blueprints for sale.  Some advanced blueprints come in many parts.  Once you have purchased all the parts for a particular blueprint, you will unlock a new component to use on your ships (providing your level is high enough).  You can purchase blueprints by docking with either a Civilian or UTA station.  Each station will sell a unique set of items.  Most stations will not deal with you if your relationship is too low, so be careful who you piss off.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_compUnlock.png";   
};

new ScriptGroup (ComponentTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "UNLOCKING DEVICES";
   
   text[0] = "To unlock a new ship device, you must purchase all the required blueprints.  Once unlocked, it will show up in the hangar view component selection window.  Keep in mind that some components require that you have upgraded your technology level in the research screen before you can use them.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_compUnlock.png";   
};

new ScriptGroup (utaBribeTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "UTA BRIBES";
   
   text[0] = "Sometimes you come across a system where the UTA are friendly with you.  Despite your good relationship with them, you must deal with the UTA warp gate blockade in order to travel to another system.  If you don't wish to spoil your relationship, you can always bribe your way past gate blockades.  Go to the system's UTA security base to attempt a bribe.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bribes.png";   
};

///////////////////////////////////////////////////////////////////
// first time item use
////////////////////////////////////////////////////////////////////

new ScriptGroup (newWepTutorial_missile : tutorialBase) 
{  
   displayInLister = true;
   title = "MISSILES AND TORPEDOES";
   
   text[0] = "Missiles and torpedoes are smart weapons.  They will avoid things like asteroids or other objects that do not have an electromagnetic signature.  You can fire missiles and torpedoes with (DEFAULT: RIGHT MOUSE BUTTON).  You can change the control assignment in the advanced options of the TACTICS PANEL.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_firstMissile.png";   
};

new ScriptGroup (newWepTutorial_bombs : tutorialBase) 
{  
   displayInLister = true;
   title = "BOMBS AND MINES";
   
   text[0] = "Bombs are very unique weapons.  As the bomb speeds up, it will become increasingly more unstable, but it will yield a greater graviton charge.  This harmonic graviton pulse is tuned to the polarized frequency of your hull (won't effect you or your allies), however the secondary charges will damage anything within its blast radius.  During flight, the bomb will eventually burn itself out and consume all of its graviton fuel.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bombs.png";  
   
   text[1] = "All bomb mounts also support mine generators.  When a mine generator is deployed, it will begin creating a field of mines at the location of deployment.  If the generator is destroyed, the mine field will collapse.  You can deploy both bombs and mine generators with (DEFAULT: RIGHT MOUSE BUTTON).  You can change the control assignment in the advanced options of the TACTICS PANEL.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_mines.png";   
};

new ScriptGroup (newWepTutorial_crew : tutorialBase) 
{  
   displayInLister = true;
   title = "CREW PODS AND SHUTTLES";
   
   text[0] = "Crew pods can be mounted on some of the larger projectile mounts.  Each time a pod is fired, it consumes crew from the ship.  If a pod docks with an enemy ship, the crew will begin assaulting it from the inside out.  Large shuttle pods have thrusters allowing them to either pursue targets or return to you.  Suicide cannons do not support return trips.  You can deploy crew pods with (DEFAULT: MIDDLE MOUSE BUTTON).  You can change the control assignment in the advanced options of the TACTICS PANEL.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_firstPod.png";   
};

///////////////////////////////////////////////////////////////////
// bounty stuff
////////////////////////////////////////////////////////////////////

new ScriptGroup (bountyHunterTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "BOUNTY HUNTERS";
   
   text[0] = "Bounty hunters are a global mercenary faction.  They typically reside within their stronghold bases scattered throughout the galaxy.  They only operate within star systems that contain a stronghold, and any star system immediately connected to it.  Every move you make within Bounty Hunter territory will be watched.  Be mindful of your actions, or you'll end up accumulating a bounty on your head.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_BountyIntro.png";   

   text[1] = "Bounty Hunters have been known to extort or attack ships that travel through their territory.  The greater your bounty, and the closer you are to their stronghold, the higher the threat will become.  If you don't have the resources to pay them off, you'll end up in a fight.  Bounty Hunters have been known to respect those who can successfully fight them off, but this is not an advisable strategy for those who wish to stay alive.  Avoidance is the safer route.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_RespectBounty.png";   

   text[2] = "As terrifying as they may seem, Bounty Hunters run a more than successful business.  They typically remain neutral within the area around their stronghold bases.  You're free to dock and see what opportunities they offer without risk of attack.  If you have a high bounty, it might be a good idea to stop by and pay it off, before they come looking for you.";
   displayImage[2] = "~/gui/tutorialImages/tutImage_BountyBase.png";   
};

new ScriptGroup (bountyBaseTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "BOUNTY HUNTER BASE";
   
   text[0] = "Bounty Hunter bases are scary and armed to the teeth.  There are no reported cases of anyone ever taking one down.  Despite the overzealously armed exterior, they have an open door policy and let just about anyone dock.  They host a popular series of lethal arena combat events, where ships compete for respect, as well as fortune.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_BountyBase.png";   
   
   text[1] = "Competing in the Arena is the best way to gain the Bounty Hunters respect.  Higher level systems will have more insane Arena ladders available.  If you manage to beat a particular Arena ladder, you will receive a special reward.  All Arena events provide you with a specific ship, with a specific tech level and load out.  Research levels and unlocks have no effect on arena combat events.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_ArenaVs.png";   
};

new ScriptGroup (bountyTributeTutorial : tutorialBase) 
{  
   displayInLister = true;
   title = "BOUNTY HUNTER TRIBUTE";
   
   text[0] = "The Bounty Hunters will now demand tribute when passing through their borders, and double within their stronghold systems.  In return for their \"protection\", Bounty Hunters will also skim 50% of your resource production off the top within their influence.  In return, they will assist in keeping the infection under control, reducing Zombie attack effectiveness.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_RespectBounty.png";   
   
   text[1] = "You can dock with the UTA base within a stronghold system and alter its Bounty Hunter policy.  You may choose to resist them, which will halve the defensive capability in this and surrounding systems, but resources will be produced at full speed.  In resisted systems, the Bounty Hunter threat will increase by one level, and their tribute demands will double.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_RespectBounty.png";   
   
   text[2] = "To permanently end the Bounty Hunter threat within an area would require the destruction of their Stronghold, and a UTA policy of resistance.  It should be noted, that a Bounty Hunter stronghold has never been defeated in the five years since the zombies began to spread.  Even the Zombies give these structures a wide berth in infected systems.  Beware.";
   displayImage[2] = "~/gui/tutorialImages/tutImage_RespectBounty.png";   
 
};

///////////////////////////////////////////////////////////////////
// Sector 4
////////////////////////////////////////////////////////////////////

new ScriptGroup (S4_Tutorial : tutorialBase) 
{  
   displayInLister = true;
   onlyShowAfterUse = true;
   
   title = "THE ZOMBIE WAR";
   
   //NOTE: this is the only tutorial that is allow to assume youve done this because its hidden from the lister until this time
   text[0] = "Now that the galaxy is finally taking the zombie threat seriously, the factions have ceased fighting and are now allied with you.  You can build up a fleet of allies by liberating infected star systems.  Help the systems clear infections and build up their starbases to amass a fleet.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_sec3war1.png";

   text[1] = "When you travel to an infected system, your mothership will be stranded and unable to leave.  You must destroy the root of the infection before you can use any jump gates.  As you travel from star to star, the zombie hoard will eventually catch up with you.  Beware of attacks on your mothership.";
   displayImage[1] = "~/gui/tutorialImages/tutImage_sec3war2.png";

   text[2] = "The greater the number of infected systems, and their level of infection, the greater the chance of a zombie invasion assaulting neighboring systems.  You cannot be everywhere at once, so build security bases to allow systems to defend themselves and to give you more time to react to invasions.";
   displayImage[2] = "~/gui/tutorialImages/tutImage_sec3war1.png";
   
   text[3] = "As you liberate systems, upgrade their infrastructure star bases and they will begin to generate resources for you to collect upon return.  These resources can be used to strengthen your fleet or to upgrade other systems.  Upgrading bases will also improve the strength of your allied fleet.  Colony bases increase fleet reinforcement, Mining Bases improve fleet ship size, Science bases improve fleet tech level.";
   displayImage[3] = "~/gui/tutorialImages/tutImage_sec3war3.png";
   
   text[4] = "As your control over the sector grows, the size of your task force will increase.  When the 'Task Force' meter reaches 100%, your allies will be ready for you to lead the assault through the Alien Gate.";
   displayImage[4] = "~/gui/tutorialImages/tutImage_sec3war4.png";
};



////////////////////////////////////////////////////////////////////////////////
// MOTHER UPS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup (PT_MotherUp1 : tutorialBase) 
{  
   title = "MOTHERSHIP UPGRADED TO LEVEL 2";
   text[0] = "The mothership has been upgraded.  It can now hold more ships, more cargo, more crew and kick more ass.  The goon cloning facility has also come back online.  You will now receive an influx of cloned goons every time you levelup.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mother1.png";
   isMotherUp = true;
   motherLevel = 1;
};

new ScriptGroup (PT_MotherUp2 : PT_MotherUp1) 
{  
   title = "MOTHERSHIP UPGRADED TO LEVEL 3";
   text[0] = "The mothership has been upgraded.  It can now hold more ships, more cargo, more crew and kick more ass.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mother2.png";
   motherLevel = 2;
};

new ScriptGroup (PT_MotherUp3 : PT_MotherUp1) 
{  
   title = "BRAND NEW MOTHERSHIP .. SORT OF";
   text[0] = "Welcome to the Clockwork Two.  It's not much to look at, but neither was the last one.  Try not to blow this one up.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mother3.png";
   motherLevel = 3;
};

////////////////////////////////////////////////////////////////////////////////
// SPECIAL ACCEPT DECLINE
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup (AnD_SaveFileStomp : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "You already have a save file by that name.  Accept if you wish the overwrite the save file with your current information.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_QuitGame : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "You are about to quit the current game.  Any unsaved progress will be lost.  The game will auto save between warp jumps, but you are currently away from the mothership and unable to manually save.  Proceed to quit?";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_QuitGame_Home : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "You are about to quit the current game.  Any unsaved progress will be lost.  The game will auto save between warp jumps.  Since you are near the mothership, you can manually save the game.  Proceed to quit?";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_LoadGame : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Are you sure you want to load this file?  You are currently in-game and any unsaved progress will be lost.  Proceed with load?";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};
new ScriptGroup (AnD_CorruptFile : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "A corrupted save file has been detected.  This file should be deleted to make room for other saves.  Proceed with delete?";
   displayImage[0] = "~/gui/tutorialImages/tutImage_beaconLost.png";   
};

new ScriptGroup (AnD_restartChange : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME RESTART"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "You have changed settings that require you to restart the game before they can take effect.  Would you like to quit now?  All unsaved progress will be lost.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_BuyNowCheck : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME RESTART"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Thanks for your support!\n\nSpace Pirates and Zombies will shutdown and take you to our webpage to complete the purchase.\n\nAny unsaved progress will be lost.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_WarpOut : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Are you sure you want to chicken out and run home to the mommy ship?  If you flee now you'll lose any current mission progress.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_flee.png";   
};

new ScriptGroup (AnD_RetireSpecialist : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Are you sure you want to get rid of this specialist?";
   displayImage[0] = "~/gui/tutorialImages/tutImage_retirespec.png";   
};


new ScriptGroup (AnD_Respec : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Are you sure you want respec this category?  Resynchronizing the databases will require a data infusion, and your research progression will be paused until the data debt is paid off.  As your level increases, reconfiguring the database requires a greater data debt.  Each respec will also cause the next one to require a greater debt.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_respec.png";   
};

new ScriptGroup (AnD_LowerDifficulty : tutorialBase) 
{  
   displayInLister = false;
   title = "OVERRIDE ME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Are you sure you want to PERMANENTLY lower the difficulty level?  Once lowered, it cannot be raised again until you start a new game.  Unless you are irrevocably stuck, it is best to back away and level up a bit and return when you are stronger.  This is a last ditch solution if you chose a difficulty beyond what is fun for you";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_TechUp : tutorialBase) 
{  
   displayInLister = false;
   title = "TECH UP"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = ""; //MUST BE EMPTY SO IT CAN GET FILLED WITH CUSTOM STUFF
   displayImage[0] = "~/gui/tutorialImages/tutImage_researchUpgrade.png";   
};

new ScriptGroup (AnD_SaveDelete : tutorialBase) 
{  
   displayInLister = false;
   title = "SAVE DELETE"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Are you sure you want to delete your save game and all the progress along with it?";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_ZombieHomeAttack : tutorialBase) 
{  
   displayInLister = false;
   title = "ZOM ATTACK"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Zombie forces have zeroed in on your position.  You will have to defend the mothership while the jump engines warm up.  Are you sure you want to commit to a warp jump?";
   displayImage[0] = "~/gui/tutorialImages/tutImage_mother3.png";   
};

new ScriptGroup (AnD_EnterSec4 : tutorialBase) 
{  
   displayInLister = false;
   title = "THE CALM BEFORE THE STORM"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "You have a bad feeling about what lies ahead.  You should be absolutely sure you are ready to walk this road before proceeding.   Are you sure you want to venture into the unknown?";
   displayImage[0] = "~/gui/tutorialImages/tutImage_noReturn.png";   
};

new ScriptGroup (AnD_PointOfNoReturn : tutorialBase) 
{  
   displayInLister = false;
   title = "ALIEN GATE TIME"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "This is it kiddies!  This is the point of no return.  From here there is no turning back.  You better make sure you have enough Rez, as well as all the upgrades you will need.  Pandora's Box can not be closed once it has been opened.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_noReturn.png";   
};

new ScriptGroup (AnD_UpgradeBase : tutorialBase) 
{  
   displayInLister = false;
   title = "BASE UP"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "Do you wish to commit to this upgrade?  You will be automatically returned to the mothership while construction takes place.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_researchUpgrade.png";   
};

new ScriptGroup (AnD_AcceptMission : tutorialBase) 
{  
   displayInLister = false;
   title = "ACCEPT MISSION"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "";
   displayImage[0] = "~/gui/tutorialImages/tutImage_contractAccept.png";   
};

new ScriptGroup (AnD_TutorialSkip : tutorialBase) 
{  
   displayInLister = false;
   title = "tut skip"; //TITLE NOT USED
   startupSound = ""; 
   
   text[0] = "";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_Cheaters : tutorialBase) 
{  
   displayInLister = false;
   title = "ARE YOU SURE YOU WANT TO CHEAT?"; 
   startupSound = ""; 
   
   text[0] = "";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_ArenaRetry : tutorialBase) 
{  
   displayInLister = false;
   title = "Care to try again?  We love a good show."; 
   startupSound = ""; 
   
   text[0] = "Care to try again?  We love a good show.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_BountyExtort : tutorialBase) 
{  
   displayInLister = false;
   title = "TODO"; 
   startupSound = ""; 
   
   text[0] = "";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bountyExtort.png";   
};

new ScriptGroup (AnD_BountyTribute_ProtOn : tutorialBase) 
{  
   displayInLister = false;
   title = "TODO"; 
   startupSound = ""; 
   
   text[0] = "";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bountyTribute.png";   
};

new ScriptGroup (AnD_BountyTribute_ProtOff : tutorialBase) 
{  //Bounty hunters pissed off in this case cut not allowed to collect locally.
   displayInLister = false;
   title = "TODO"; 
   startupSound = ""; 
   
   text[0] = "";
   displayImage[0] = "~/gui/tutorialImages/tutImage_bountyTribute.png";   
};

new ScriptGroup (AnD_BountyExtortWin : tutorialBase) 
{  
   displayInLister = false;
   title = "TODO"; 
   startupSound = ""; 
   
   text[0] = "Warp engines are back online!";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};



new ScriptGroup (AnD_ArenaVs : tutorialBase) 
{  
   displayInLister = false;
   title = "NA"; 
   startupSound = ""; 
   
   text[0] = "";
   displayImage[0] = "~/gui/tutorialImages/tutImage_ArenaVs.png";   
};

new ScriptGroup (AnD_ArenaNoSpecRoom : tutorialBase) 
{  
   displayInLister = false;
   title = "NA"; 
   startupSound = ""; 
   
   text[0] = "";
   displayImage[0] = "~/gui/tutorialImages/tutImage_question.png";   
};

new ScriptGroup (AnD_ArenaDone : tutorialBase) 
{  
   displayInLister = false;
   title = "NA"; 
   startupSound = ""; 
   
   text[0] = "Congratulations on the win!  Would you like to warp back to the Stronghold for more destruction?  If you are afraid, we will send you back to your Mommyship.";
   displayImage[0] = "~/gui/tutorialImages/tutImage_ArenaVs.png";   
};




