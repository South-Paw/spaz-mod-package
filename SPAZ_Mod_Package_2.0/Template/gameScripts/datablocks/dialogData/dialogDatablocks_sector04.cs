
///////////////////////////////////////////////////////////////////
// DIALOG OBJECTS
///////////////////////////////////////////////////////////////////

new ScriptGroup (Sector4DysonLost : dialogBox_base) 
{  
   character[0] = "MS_JAMISON";
   text[0]      = "What in the name of @#$% is that thing!  Forget the damn renegades, just leave them here.  Everyone to the escape pods.  Fall back through the gate now!";
};

new ScriptGroup (Sector4IntroZombie : dialogBox_base) 
{  
   character[0] = "MS_MINER";
   text[0]      = "Shit no!  What the hell is going on?  Crew life signs are dropping.  We have breaches all over the damn place.  Our weapons and tactical systems are down.  We're totally screwed.  We need to evacuate now!";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Curses!  This thing knows our system codes.  It's rigging the reactor to blow.  How can this be possible?  Those codes are 128 billion bit encrypted!";
   
   character[2] = "MS_PIRATE";
   text[2]      = "I'm truly sorry.  I left the reactor system vulnerable.  I didn't want things to end this way, but I always knew they would.  I can't explain more than that, it won't allow me to.  Please, just get off the ship while you still have time.";

   character[3] = "MS_MINER";
   text[3]      = "Don, it was you?  No, that's impossible.  How can you sell out your own kind?  You son of a bitch!";
   
   character[4] = "MS_SCIENTIST";
   text[4]      = "Elsa, we need to vacate now.  We have no time left.";

};


new ScriptGroup (Sector4NeedToClearInfection : dialogBox_base) 
{  
   character[0] = "MS_SCIENTIST";
   text[0]      = "I find humorous irony in the fact that it's been five years today since we started out just like this; a derelict about to be given new life.";

   character[1] = "MS_MINER";
   text[1]      = "You're not going soft on me now, are you Carl?  Let's save the sap for the pub when we get the hell out of here.";

   character[2] = "MS_SCIENTIST";
   text[2]      = "Okay, powering up the warp engines.  Wait a minute...  Oh of course it doesn't work now does it?  Unfortunately, your alcoholic tendencies will have to wait a bit longer.  I was a fool to expect the ship to fire up on the first try.  I am unable to maintain a lock with the neighboring warp gates.  There is some residual zombie infection in this system that is somehow inhibiting our jump engines.  We're basically caught in a spider's web, so we'll have to clear the infection here before we can leave.";

   character[3] = "MS_MINER";
   text[3]      = "Shit!  We get back on the horse just to get kicked right back off again, right Carl?  Let's deal with this quickly.  I'm tired of drinking degreaser for my jollies.";
};


new ScriptGroup (Sector4WebArrival : dialogBox_base) 
{  
   character[0] = "MS_SCIENTIST";
   text[0]      = "Well, this is certainly the beast that is holding us here.  I suggest exercising extreme caution as it's quite the unsightly monstrosity.  I didn't even know infected vessels could get so large.";

   character[1] = "MS_MINER";
   text[1]      = "We didn't know a lot of things Carl, yet here we are.  Wait, that's no vessel, that's a space station!  We need to put a bullet to that bloody thing.";
};


new ScriptGroup (Sector4WebCleared : dialogBox_base) 
{  
   character[0] = "MS_MINER";
   text[0]      = "That's got to be the most disgusting mess I've ever seen.  Can we get the hell out of here now, please?";
   
   character[1] = "MS_EVILDON";
   text[1]      = "As much as I'm pleased to see you two are still alive after all this time, I regret you did that.  You were safe where you were, and I tried my best to keep it that way.  You seem determined to destroy yourselves.";

   character[2] = "MS_MINER";
   text[2]      = "Don, you bastard.  Where the hell are you?  Show yourself.  Fight us like a man, if there is any real man left in you!";

   character[3] = "MS_EVILDON";
   text[3]      = "Elsa, please.  I am simply a soldier, with no choice but to follow the orders I'm given.  I know it's impossible to understand, but I have no choice, despite how much I wish that I did.";
     
   character[4] = "MS_MINER";
   text[4]      = "You piece of shit.  How can you just justify the slaughter of countless billions?  How can you let that thing poison your mind?  You might be responsible for the extinction of our race.";

   character[5] = "MS_EVILDON";
   text[5]      = "I know, yet I can't fight it any more than you can fight your next breath.  I did what I was made to do.  I brought down the gates.  I brought it sustenance.  The galaxy will fall Elsa.  Your only chance now is to run, hide, and make the best of what little time you have left.  Please, you both would be wise to get out of here as quickly as possible.";
   
   character[6] = "MS_MINER";
   text[6]      = "Well that isn't going to happen.  We're coming to kick your ass inside out.";
   
   character[7] = "MS_SCIENTIST";
   text[7]      = "He's gone Elsa.  He was transmitting to us using some kind of quantum displacement band.  It's unlikely that he's even anywhere near this star system.  In any case, we may want to take his warning to heart and get out of here, quickly.";
};

new ScriptGroup (Sector4RefugeeEscape : dialogBox_base) 
{  
   character[0] = "MS_MAC";
   text[0]      = "Mac be always forgetting his car keys, but he never forget a mug shot as ugly as you folk.  I missed y'all.  Things be all crazy here with them zombie assholes nibbling.  Turns out the UTA ain't such rectum rangers like I thought.";
   
   character[1] = "MS_JAMISON";
   text[1]      = "Holy shit in a hand bag, you're still alive after all that time in the core system?  We've almost lost everything else in the sector after you breached that last gate.  Do you have any idea the loss of life that you are responsible for?  I have more than enough reason to destroy you all right now.";

   character[2] = "MS_SCIENTIST";
   text[2]      = "Slow down there Cyclops.  Things are more complicated than your limited intellect could possibly understand.  Our commander has been under the influence of this infection since we broke away from Earth space.  All this time he's been trying to unleash the infection throughout the warp network.  We have log records to confirm all this.";

   character[3] = "MS_JAMISON";
   text[3]      = "Well this is more than you deserve, but I'll spare your lives for the time being.  I'm placing your ships under lock down.  You're coming with us.  Let's have a little chat.";

};

new ScriptGroup (S4_MetagameBegins : dialogBox_base) 
{   
   character[0] = "MS_MINER";
   text[0]      = "Okay, what in bloody hell's name is going on here?  We've been literally under a rock for five years thanks to you.  Tell us what's going on.";
   
   character[1] = "MS_JAMISON";
   text[1]      = "Don't you forget it was you that broke through the gates and opened Pandora's Box.  After you forced open the core gate, more zombies started pouring out like horses' piss.  Before we could shut down any gates, a dozen systems had already been infected.  I'm not talking a few zombies here; I'm talking massive infections that lock the warp gates down.   All of a sudden, these damn zombies started growing a brain.  They use the infected systems as farms, for people.";

   character[2] = "MS_SCIENTIST";
   text[2]      = "That's got to be Dons work.  Those infected ships are not nearly intelligent enough to do anything of this nature.";
   
   character[3] = "MS_JAMISON";
   text[3]      = "After the shit hit the fan, the outer worlds cut us off and left us for dead.  The Titan gate connections have been severed.  There is no way for us to get out, and no way for anyone else to get in.  We're totally isolated.  If what you're saying about Don is true, we have a target now.  We kill him, and we might have a chance.";
   
   character[4] = "MS_MINER";
   text[4]      = "That's going to be a problem.  He can communicate with us from just about anywhere in the galaxy.  We have zero leads to his location and not much of a leg to stand on.  This is a damn near hopeless situation.";

   character[5] = "MS_SEC3_SCIENCE_BASE";
   text[5]      = "Sorry to interrupt, but I wouldn't go as far as to say it's hopeless.  We found an alien warp gate, billions of years old, and much more advanced than ours.  Despite its age, it's in surprisingly good condition.  We've observed a great deal of infected activity in the area.  This appears to be how the infection is traveling into our region of space.  Presumably, your former commander resides beyond this gate in safety.  Oh, and I'm glad to see you're both alive by the way.";
   
   character[6] = "MS_MINER";
   text[6]      = "Aliens?  Are you kidding?  What happened to all of them?  Let me guess.  Zombies right?  Where exactly does this alien gate go?";
   
   character[7] = "MS_SEC3_SCIENCE_BASE";
   text[7]      = "Sadly, I think you may be correct.  I believe these aliens were rendered extinct by the infection long ago.  I would assume at some point in their evolution they discovered Rez and, like us, were lead here to the core.  This appears to be the infection's natural feeding cycle.  As for where the gate goes, I have no real way of saying for sure, but I can tell you it's far outside this galaxy, possibly into another dimension.  We've been working around the clock to amass the power needed to invert the gate connection.  All we need now is a fleet.";
   
   character[8] = "MS_JAMISON";
   text[8]      = "Regardless of how insane this all is, that's the state of affairs.  We've been trying to rally enough civilians together to build up a fleet that might have a fighting chance, but we can't clear the infected systems fast enough.  Every time we try, we lose more people.  Your ship, on the other hand, is the largest thing we've seen in a long time.  You've already cleared one infection.  I'm willing to cut you loose if you agree to help us.  We must liberate as many of these systems from the infection as possible.";
   
   character[9] = "MS_MINER";
   text[9]      = "Ah damn, we've only been up and running for a minute and already have chores to do.  I've spent my whole life fighting and hating the UTA for what they've done, and now we're supposed to work with you bastards.  Hell, what kind of choice do we have?  Listen, send out a broad wave communication to all systems and tell them we're coming.  I don't want anyone shooting at us, you got that?  We need our star maps updated and some support ships.  I can't believe we're doing this.";

   character[10] = "MS_EVILDON";
   text[10]      = "I admire your courage, I always have.  I sincerely hope you succeed, but damn you for what is to come now.";

   character[11] = "MS_SCIENTIST";
   text[11]      = "I guess that means the element of surprise is out the window.  Don knows we're plotting against him, so it's reasonable to expect him to attack us directly at some point.";

};


new ScriptGroup (S4_AlienGateTooEarly : dialogBox_base) 
{ 
   character[0] = "MS_SCIENTIST";
   text[0]      = "I can't seem to make the connection between fleeing for our lives, and taking the time to stop here and take in the sights.  We need to leave this system immediately, before we arouse any dormant infected ships.";
};

new ScriptGroup (S4_AlienGateTooWeak : dialogBox_base) 
{ 
   character[0] = "MS_JAMISON";
   text[0]      = "You call that a fleet?  You have got to be shitting me!  We're not cracking that gate until we have enough ships.  Get your ass back out there and save more colonies so we can assemble a viable fleet.";
};


new ScriptGroup (S4_armyComplete : dialogBox_base) 
{ 
   character[0] = "MS_JAMISON";
   text[0]      = "Impressive!  You've liberated enough star systems.  We should have a decent chance now.  The power generators required to invert the gate are also complete.  I suggest freeing a few more systems before we get under way.  The more we can throw at this damn thing, the better our chances will be.  Either way, we'll be waiting for you.";   
};


new ScriptGroup (S4_AlienGateArrival : dialogBox_base) 
{ 
   character[0] = "MS_JAMISON";
   text[0]      = "Alright people, listen up!  Those power generators are feeding into the alien gate now.  Eventually, it'll invert and we'll be able to pass through.  I'm sure this will royally piss off Don, and his meat army, so the primary task force is executing a ruse to keep them off your ass.  Once the gate is open, the primary fleet will fall back into formation and we'll pass through.  In the meantime, you must protect those generators at all costs.  If we lose any, it'll take longer to invert the gate.  If we lose them all, we're screwed.";   

   character[1] = "MS_MINER";
   text[1]      = "Nothing like a little pressure eh?  Okay everyone, you heard him.  We're not getting any backup until we open that gate.  I didn't want to live forever anyway.  Let's get the job done.";   
   
   character[2] = "MS_SCIENTIST";
   text[2]      = "How motivational of you both.  Perhaps we should stop chatting and set up defensive positions around those generators, yes?";
};

new ScriptGroup (S4_AlienGateOpened : dialogBox_base) 
{ 
   character[0] = "MS_MINER";
   text[0]      = "The gate is open and our engines are hot.  Ready the fleet to jump.";
};


new ScriptGroup (S4_EnteringAlienGate : dialogBox_base) 
{ 
   character[0] = "MS_JAMISON";
   text[0]      = "All ships checked in.  The fleet is prepared to depart.  Engaging tandem jump drives.  All crew to battle stations.  We're in the shit now folks.";

   character[1] = "MS_MAC";
   text[1]      = "Yeeeehaaaw!  I can't wait to kickem up the skull and piss down them neck hole.  Yeaah!";   
};

///////////////////////////////////////
// FInal Boss Area
///////////////////////////////////////

new ScriptGroup (OnFinalBossArrival_A : dialogBox_base) 
{ 
   character[0] = "MS_SCIENTIST";
   text[0]      = "Unbelievable!  We must be in another dimension.  The space between spaces.  I can't even begin to fathom how much data we can get from here.  Please, please Elsa, Samples?";
   
   character[1] = "MS_MINER";
   text[1]      = "Leave it to you to be excited to be in this forsaken shit hole.  Just stay focused there Carl.  We're here for a reason.";
   
   character[2] = "MS_EVILDON";
   text[2]      = "So it comes to this then.  You're forcing my hand.  I wish you the best of luck, but I'm doubtful it will do you any good.";
};

new ScriptGroup (OnFinalBossArrival_B : dialogBox_base) 
{ 
   character[0] = "MS_MINER";
   text[0]      = "The Clockwork!  What has Don done to it?  The readings I'm getting on the tactical display are off the charts.  Can we even dent the damned thing?";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Elsa, I think I may have a brilliant idea.  That thing has bound itself to the Clockwork.  Though now it's more lethal, it has also inherited some of the ship's vulnerabilities.  The Clockwork's Titan reactor is still somewhat intact.  Given the fact that we have a more powerful version of the beam, I should be able to adjust the beam frequency to create a feedback pulse.  That should give us a short window to do some damage to it.";
   
   character[2] = "MS_MINER";
   text[2]      = "That's our attack angle then.  Attention all ships.  When we hit that thing with our Titan beam, attack it directly.  Do as much damage as you can and then fall back to defend the mothership until we can charge up another blast.";
};

new ScriptGroup (OnFinalBossComplete : dialogBox_base) 
{ 
   character[0] = "MS_EVILDON";
   text[0]      = "Amazing!  You've done it.  I would have never thought it possible.  Thank you for ending my torment.  I've lived far too many dark years.  Before I'm gone, I need you to understand.  I need you to see the things I've seen.  You deserve to know the truth.  Perhaps then will you be able to forgive me.";
};

///////////////////////////////////////
// gameover
///////////////////////////////////////

new ScriptGroup (GameOverDialog : dialogBox_base) 
{ 
   character[0] = "MS_MINER";
   text[0]      = "So!  What the hell you want to do now?";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Well, seeing as how we're no better off than when we started this goose chase and we're still flat broke, what kind of choices do we have?";
   
   character[2] = "MS_MINER";
   text[2]      = "We've got a nice big ship.  We can do what ever we want Carl.  You're such a downer sometimes, you know that?";
   
   character[3] = "MS_SCIENTIST";
   text[3]      = "Ya, about the ship.  Admiral Jamison is going to confiscate it as soon we're in port.  It does contain 90% UTA technology, so we can't really argue with that.  You didn't really think they would let us keep it did you?";
   
   character[4] = "MS_MINER";
   text[4]      = "Oh for the love of %$#@!  Zero appreciation.  You're right, we're no better off than when we started.  From the warmest part of my heart, I hate you Carl.";
   
   character[5] = "MS_SCIENTIST";
   text[5]      = "I hate you too Elsa.  We might as well go hit up the pub now.  I feel the need to reduce my overall brain cell count.";
   
   character[6] = "MS_MAC";
   text[6]      = "Mac calls shotgun!";
};



//BOUNTY INTRO  (Sector 4)//

new ScriptGroup (Dialog_S4_BountyIntro: dialogBox_base) 
{    
   character[0] = "MS_BOUNTY";
   text[0]      = "Welcome back.  I am here to give you a friendly reminder of how things are going to work from now on.  As you are most certainly aware, things are in a state of decline around here.  We're all feeling the heat.  We understand the whole unified effort, but we're doing it our way.  If you want to stay among the living, you will pay us what we tell you, when we tell you.  In return, we'll keep you safe from the infection.";
   
   character[1] = "MS_SEC3_SCIENCE_BASE";
   text[1]      = "As primitive and embarrassing to humanity as this is, we have little choice but to pay these Neanderthals in most of our unguarded systems.  We are ill equipped to defend against Zombies, let alone Bounty Hunter savagery.";

   character[2] = "MS_JAMISON";
   text[2]      = "Ah don't give me that crap.  A few of my good old boys are still sticking it to em out there.  We can stop their extortion.  All it takes is manpower.  You just can't give them one damn inch!";
   
   character[3] = "MS_MINER";
   text[3]      = "Seriously?  We're getting rolled by thugs out here at a time like this.  What is wrong with people?";
};













