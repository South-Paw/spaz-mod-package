
///////////////////////////////////////////////////////////////////
// DIALOG OBJECTS
///////////////////////////////////////////////////////////////////


new ScriptGroup (Sector3IntroBattleStart : dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "Holy shit!  We have bogies all over the radar.  Execute evasive maneuvers.  Carl, what hell did you jump us into?";
};

new ScriptGroup (Sector3IntroBattleUTAFlee : dialogBox_base) 
{  
   character[0] = "MS_JAMISON";
   text[0]      = "Damn it Carl, I warned you and your crew to stay the hell out!  Attention all decks!  The renegade pirate fleet has broken the inner blockade.  Helmsman, get us the hell out of here.  Initiate the failsafe transmitter.";
};


new ScriptGroup (Sector3IntroBattleComplete : dialogBox_base) 
{  
   character[0] = "MS_MINER";
   text[0]      = "What the hell just happened here?  That thing was made of that muck that was growing on Carl's old ship back in Proxima.";

   character[1] = "MS_SCIENTIST";
   text[1]      = "I knew it!  I'm picking up the exact same readings that I got from my science ship.  As I suspected, that wasn't an isolated incident.  Whatever happened to my ship is happening here ten fold.  Judging by these readings we are looking at decade's worth of growth.";
   
   character[2] = "MS_MINER";
   text[2]      = "Decade's worth?  There is no way we're just discovering this now.  Why haven't we heard about this back home?";
   
   character[3] = "MS_PIRATE";
   text[3]      = "Slow down there.  We can't be sure of anything just yet.  Jamison was toting some heavy toys, and yet he ran off scared.  For whatever reason, he gave a remote order to self destruct his own allied ships.  He's a filthy ass, but he's not stupid.  He wouldn't waste his own ships unless this bio paste was some serious shit.  Let's see if we can salvage any computer data and piece together what's going on.";
};

new ScriptGroup (Sector3OnBlackBoxPickup : dialogBox_base) 
{  
   character[0] = "MS_SCIENTIST";
   text[0]      = "Well from the data, it appears the UTA have been trying to quarantine the galactic core for the duration of the lockdown.  This biomass seems to be a significant problem across most of the systems here.  The remote self destruct mechanism is a way to nullify any infected UTA ships.  Not exactly what I would call job security.";

   character[1] = "MS_PIRATE";
   text[1]      = "Seems like standard military coward protocol.  The UTA are covering this up.  The Lockdown Wars were just a pile of bullshit to keep people distracted.  I'd guess they are either trying to avoid mass hysteria, or most likely, they are actually responsible for all this.  Either way, it's clear this is the reason for the lockdown, the Titan gates, and everything that the UTA have done.";
   
   character[2] = "MS_SCIENTIST";
   text[2]      = "That seems like a viable hypothesis.  This must be why they've neglected the outer worlds all these years.  This is quite an amazing find, but I do seem to now agree with Admiral Jamison's warning.  Perhaps we were in error in coming here.  This is not the pot of gold at the end of the rainbow that we were expecting.";
   
   character[3] = "MS_MINER";
   text[3]      = "It pains me to say, but Carl's right for once.  Coming here was a stupid idea.  These gates weren't meant to keep us out, but to keep this nightmare in.  No amount of Rez is worth this.  Can't we just get the hell out of here?";

   character[4] = "MS_PIRATE";
   text[4]      = "Damn you both!  Don't you get it?  We can't go back now.  We've seen behind the curtain, and the UTA know it.  The only way out of this now is to see it through.  What ever the hell they are doing out here, I'm putting an end to it one way or the other.  If either of you have a problem with that, then I suggest you to fire up an escape pod and get the hell off my ship.  Do we understand each other?";

   character[5] = "MS_SCIENTIST";
   text[5]      = "Excuse me for interrupting this delightful conversation we're having, but I did a data check on the prisoner manifest.  You're not going to believe this, but last week they transported that simpleton Mac to a prison facility in this sector.  That's a long way from where we left him.  I'm curious as to what his involvement in this may be, aren't you?";
   
   character[6] = "MS_MINER";
   text[6]      = "The same Mac that helped us get out of Earth space?  What could he be doing out here, and what would the UTA want with him?  We've got to try and break him out of there.  We owe him that much.  We can't leave him to the dogs.";
   
   character[7] = "MS_PIRATE";
   text[7]      = "Favors aside, we need some more info on what's going on out here.  We'll pick him up and find out what he knows.  As for you two, don't cross me again, not now.  The time for second guessing is over.  I need you both to be flying straight with me on this.  No more bullshit!";
};

/////////////////////////////////
// PRISON BASE
/////////////////////////////////

new ScriptGroup (Sector3ArriveInPrison : dialogBox_base) 
{  
   character[0] = "COLONY_BASE";
   text[0]      = "Welcome to the maximum security correction facility for sub sector A-B49-D.  If you know of any friends or family members you would like to nominate for incarceration here, please fill out a registration form and drop it off with one of our representatives during business hours.";
   
   character[1] = "MS_PIRATE";
   text[1]      = "Well here we are.  This base is mostly automated and operates with a skeleton crew.  If we breach the hull severely enough, the on board computer will purge the prisoners in escape pods.   Let's warm up the thermo nuclear welcome rockets and hit the base hard.  Everyone to your combat stations now!  Carl, get ready to scoop up those prisoners.";

   character[2] = "COLONY_BASE";
   text[2]      = "Your interest in our facility appreciated.  If you would like to purchase souvenirs at our gift shop, it is located across from the rectal cavity analysis booths on deck six.  Thank you, and enjoy your stay.";
};

new ScriptGroup (Sector3PrisonComplete : dialogBox_base)
{     
   character[0] = "MS_MAC";
   text[0]      = "Well, I'll be a dingo's proctologist!  If it ain't be me old stone picker buds.  Mac owe ya big for this here favor.";
  
   character[1] = "MS_MINER";
   text[1]      = "Damn Mac!  How did you end up here?";
   
   character[2] = "MS_MAC";
   text[2]      = "I ain't being so sure 'bout that.  The old skull reactor be a tad short on quarks.  I do seem to remember passin out from chowder poisoning.  When I woke up, those UTA assholes be askin me a bunch of questions.  Now that I think about it, they be askin bout ye'all folks.";
   
   character[3] = "MS_MINER";
   text[3]      = "Shit, Jamison is still looking for us even in this wasteland.  This isn't good, but I can't help but be a little flattered that he's trying so hard.  Mac, do you remember anything about the UTA flagship that brought you here?  Do you remember anything useful?";
   
   character[4] = "MS_MAC";
   text[4]      = "They were marching us all out on horse back and caravan every odd day.  We be pickin those fuzzy stones you like so much, except these be freakin fuzzy as a monkeys ass!";
   
   character[5] = "MS_PIRATE";
   text[5]      = "Not sure what language that was, but I'll guess we're getting close to the high density Rez deposits.  Elsa, see if you can dig a coordinate out of Mac.  We need to find out where they were taking him to work.";

};

/////////////////////////////////
// MINING BASE
/////////////////////////////////

new ScriptGroup (Sector3ArriveInUberMiningBase: dialogBox_base) 
{  
   character[0] = "UTA_ADMIRAL";
   text[0]      = "Halt!  Your ships are unregistered!  This facility is restricted and occupied by UTA forces.  Under no circumstances are you to dock with this facility.  Non compliance will be met with full and lethal force.";
   
   character[1] = "MS_PIRATE";
   text[1]      = "Well they sure don't look willing to give us the information we need.  Security here is tighter than I would have liked.  I don't think we can win this by the gun.  I do have an idea however.  With all these pissed off prisoners we picked up, we should be able to hijack a transport ship and get operatives onboard the base to do our dirty work.  They owe us a big favor, so why not cash it in?";

   character[2] = "MS_SCIENTIST";
   text[2]      = "I wouldn't call it a sound plan, but we're still yet to actually have a sound plan on this entire trek.  I'll start scanning for transport ships.";
};

new ScriptGroup (Sector3EscortStart: dialogBox_base) 
{  
   character[0] = "UTA_ADMIRAL";
   text[0]      = "This is a general alert to all UTA ships in the system.  Keep an eye out for the renegade pirate fleet.  If you have a positive ID on them, I want those transports locked down and evacuated immediately.";

   character[1] = "MS_PIRATE";
   text[1]      = "What a hard assed prick.  We're going to have to be discreet about this.  Let's get one of our fast ships rigged up with a cloaking device and do this covertly.  We need to sell off these fat boats.  We can't afford to blow our cover on this mission.";

};

new ScriptGroup (Sector3EscortComplete: dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "Okay, we have the ship.  Let's head back to the mining base and get this done before anyone gets wise.";
};

new ScriptGroup (Sector3EscortRun: dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "Alright, let's just get the ship in there nice and easy.  We shouldn't have any issues.  Don't do anything out of the ordinary here.  Keep the damn safety on.";
};

new ScriptGroup (Sector3HackStart: dialogBox_base) 
{     
   character[0] = "UTA_ADMIRAL";
   text[0]      = "Red alert to all ships, the base is being hijacked.  All units, engage civilian and pirate targets.  Do whatever it takes to stop them from capturing that base.  Destroy the base if you have to.";

   character[1] = "MS_PIRATE";
   text[1]      = "Ah damn!  Here we go.";
};


new ScriptGroup (Sector3UberMiningComplete : dialogBox_base) 
{  
   character[0] = "MS_MAC";
   text[0]      = "Good ol' Mac here be tappin' into them systems.  I saw how to do it on that TV thing.  Looks like every few months these folks get goodie bags from an egghead base in the sector next door.  I hates to say, but I couldn't help myself but to push a few red buttons.  Seems like the station is going to self destruct, so I be hoping you guys can open the docking bay.  Mac is comin' home!";
   
   character[1] = "MS_PIRATE";
   text[1]      = "You damn moron!  Get off the station and we'll tractor you in.  Lay in a course for that \"Egg head\" station."; 
};

/////////////////////////////////
// UBER SCIENCE FAVOR 
/////////////////////////////////

new ScriptGroup (Sector3UberScienceMeeting : dialogBox_base) 
{  
   character[0] = "MS_SEC3_SCIENCE_BASE";
   text[0]      = "Ah, welcome.  We've been expecting you for some time.  I'm assuming you have a plethora of questions about the Rez we're supplying.";
   
   character[1] = "MS_PIRATE";
   text[1]      = "Umm.  Ya.";
   
   character[2] = "MS_SEC3_SCIENCE_BASE";
   text[2]      = "Well I hate to disappoint you, but we don't have much in the way of answers for you at present.  The Rez we receive here, though still very potent, isn't quite pure, and thus we can't fully analyze it.  However, seeing as the UTA won't tell us what this substance really is, we'll have to find out for ourselves.  That's where you come in.";

   character[3] = "MS_PIRATE";
   text[3]      = "Alright, it sounds like you have a plan all laid out for us already.  What exactly do you have in mind?";

   character[4] = "MS_SEC3_SCIENCE_BASE";
   text[4]      = "My expertise has allowed me to locate a potential vein of Rez that might be pure and untainted.  The UTA have no idea where it's located, but they will find it eventually.  I'd go harvest it myself, but I'm sure you understand that my personal involvement will only draw UTA attention.  You seem to have no problem going where you please, therefore I suggest we work toward a common goal.  Go harvest this pure Rez, and I'll share with you any significant findings.";

   character[5] = "MS_SCIENTIST";
   text[5]      = "How impeccability organized!  I must confess that I think I'm in love.";
   
   character[6] = "MS_MINER";
   text[6]      = "Damn Carl, I think she's nearly 80 years old.  Perhaps I'll slip, fall, crack my head, and be rid of that mental image.";
   
   character[7] = "MS_MAC";
   text[7]      = "Mac be thinkin' he had enough excitement for t'day.  I'm gonna lollygag here with them egg heads.  You kids have fun, and be home in time for supper.";
};

new ScriptGroup (Sector3UberScienceComplete : dialogBox_base) 
{  
   character[0] = "MS_SCIENTIST";
   text[0]      = "Well, this is very interesting.  This Rez has zombie DNA all over it.  It's a fairly simple task to wipe it clean while still preserving the transmutable properties.  It appears the UTA have been doing this to keep anyone from making the connection.";
   
   character[1] = "MS_MINER";
   text[1]      = "So what are you saying, this stuff is zombie shit?  The UTA have been knowingly stirring the hornet's nest all this time.  Why risk so many human lives?   It doesn't make any sense.";
   
   character[2] = "MS_SCIENTIST";
   text[2]      = "It's hard to tell exactly what Rez is supposed to be, but I would highly doubt it to be excrement.  If I had to guess, I'd say it's bait.  Rez can only be used to fabricate basic alloys, nothing biological.  These zombie ships can't reproduce without the materials our bodies provide.  What better way to draw in space faring races then with a transmutable element that we can't replicate.  They produce something we need, and in turn, we feed them.";

   character[3] = "MS_PIRATE";
   text[3]      = "That wouldn't stop those UTA bastards.  Everyone's hooked on the stuff now.  That would explain why the UTA are so well equipped out here.  They have all the Rez they'll ever need, but right next to the shit storm.";

   character[4] = "MS_SCIENTIST";
   text[4]      = "Considering how advanced this stuff is, I'd suggest there is some kind of intelligent being behind it.  There must be a primary hive somewhere.  I presume we're inevitably going to attempt to destroy it.  I say lets go, simply because I'd adore having a sample of whatever this thing is.";

   character[5] = "MS_SEC3_SCIENCE_BASE";
   text[5]      = "This is all disheartening, but none of it comes as a surprise.  The Rez deposits grow more abundant toward the core, so the source must be there.  Unfortunately no gates I know of actually go there.";
   
   character[6] = "MS_MAC";
   text[6]      = "You be talking 'bout that cloaked warp gate those UTA folk talking 'bout when they think'n I not be listening?  I think I do recon I do know where it be.  I draw crayon map for y'all.";

   character[7] = "MS_PIRATE";
   text[7]      = "Cloaked warp gate eh.  Mac, you're an amazing man, you know that?  Unless anyone has any objections, let's lay in a course and get this done.  This is the point of no return people, so let's make sure we have everything we're going to need before crossing the line.";

   character[8] = "MS_MINER";
   text[8]      = "Over a century of chaos for all this?  Damn, we were all just supposed to make some quick cash, not save the galaxy.  How did we end up being responsible for all this?  None of this feels right.";

};

///////////////////////////////
// SECTOR 4 LINK //////////////
///////////////////////////////

new ScriptGroup (Sector3CloakedGate : dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "Sure enough, there are the cloak generators.  It's roughly enough power to keep a gate hidden.  Let's pop those bitches and get this show on the road.";
};

new ScriptGroup (Sector3CloakedGate_destroyed : dialogBox_base) 
{  
   character[0] = "MS_JAMISON";
   text[0]      = "That son of a bitch is after the generators.  Stop him now ";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Well what a surprise.  You're always keeping a close eye on us aren't you?";
};

new ScriptGroup (Sector3CloakedGate_zoms : dialogBox_base) 
{  
   character[0] = "MS_JAMISON";
   text[0]      = "Now infected ships are appearing on radar!  Damn you Don.  You've really stirred up the hornet's nest here.  You are making the mistake of a lifetime.";
};

new ScriptGroup (Sector3CloakedGate_follow : dialogBox_base) 
{  
   character[0] = "MS_JAMISON";
   text[0]      = "Don you bastard!  Don't think I won't follow you anywhere you go.  Helmsman, follow them now!";
};

///////////////////////////////
// contextual spec pickup
///////////////////////////////

new ScriptGroup (Sector3_SpecPodDialog : dialogBox_base) 
{  
   character[0] = "MS_MINER";
   text[0]      = "What the hell?  That infected ship had human life signs on board.";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Interesting!  Zombie DNA is capable of absorbing just about anything into its bio matrix.  This lucky fellow appears to be unharmed however.  It's such a shame.  It would have been fascinating to watch assimilation in action.";
   
   character[2] = "MS_MINER";
   text[2]      = "Carl, what is wrong with you!?  You really do need constant parental supervision.  Let's blast that zombie shit off the pod and pick up the survivor.  I'm sure he will be more than grateful for the rescue.";
};








