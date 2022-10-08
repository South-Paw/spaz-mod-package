
///////////////////////////////////////////////////////////////////
// DIALOG OBJECTS
///////////////////////////////////////////////////////////////////


new ScriptGroup (Sector2Arrival : dialogBox_base) 
{  
   character[0] = "MS_MINER";
   text[0]      = "I can't believe we actually cracked the gate!  I haven't left home since I was a kid, before the UTA locked down the outer fringe worlds.";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "As impressive as it may be to you, this is elementary compared to what's ahead.  When doing projects for the UTA, we came across Titan class warp gates.  Only the UTA flagship was able to power them, but we never saw them get used.  Supposedly they used a massive emitter called the Titan beam to generate the energy required.  I'm sure by now that there are dozens of Titan gates between us and the core.  Sadly, your optimism has little merit as we currently have no way to open them.";
   
   character[2] = "MS_PIRATE";
   text[2]      = "Well that was a nice story, but I assume you have a plan to remedy our technical shortcomings, right?";
   
   character[3] = "MS_SCIENTIST";
   text[3]      = "Indeed.  The Titan beam mechanism isn't beyond my understanding, but acquiring the parts will be problematic.  The first thing we need is a focus crystal suitable to emit the beam.  I'm going to need to do some local scans.  Unfortunately, I wouldn't expect the civilian science base in this system to be very hospitable.  I have a soured relationship with them.  On the other hand, Admiral Jamison is posted at the UTA base in this system, and he owes me a favor.";

   character[4] = "MS_MINER";
   text[4]      = "Admiral Jamison?  Have you gone bat shit crazy?  Don't you remember the other day when we destroyed a whole pile of UTA attack ships?  All that pew pewing and explosions, remember?";

   character[5] = "MS_PIRATE";
   text[5]      = "Carl's right on this one.  These UTA colonies are as isolated as everyone else.  They have no clue what's going on beyond their gates.  I've seen these UTA operations long enough to realize they are anything but organized.  They go months without supply drops and turn to freelancers and mercenaries to make ends meet.  I would bet there are still several UTA colonies that are in similarly rough shape.  It's worth checking out, but carefully.";
};


//Need a sec base face.
new ScriptGroup (Sector2MeetRootSecBase : dialogBox_base) 
{  
   character[0] = "MS_JAMISON";
   text[0]      = "Carl?  You son of a bitch is that you?  It's been a long time, yet still not nearly long enough.  What the hell do you want?";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Greetings Jamison; how's the depth perception?  You happen to still remember the incident with the ambassador's wife a while back?  Well, of course you do.  My prolonged silence is going to cost you yet again.  Nothing major, we just need to dock and use the scanner for a few hours.";
   
   character[2] = "MS_JAMISON";
   text[2]      = "Very well you bastard.  I see you haven't changed at all over the years.  Do your damn scans and get the hell out of here.";
};


//Optional only happens if go to science base before sec base. 
new ScriptGroup (Sector2MeetRootScienceBase : dialogBox_base) 
{  
   character[0] = "MS_PURPLEFACE";
   text[0]      = "Carl, you son of a bitch!  My skin is still purple and itching from those damn \"flu shot\" injections.  You're going to die you little prick!";  
};

//Optional only happens if go to science base before sec base. 
new ScriptGroup (Sector2FocusAccept : dialogBox_base) 
{  
   character[0] = "MS_SCIENTIST";
   text[0]      = "I've completed scans of the area.  During my time here, I was able to stash away a few office supplies, including a delta class science vessel.  You never know when a rainy day may come.  At any rate, it has a suitable ion crystal that we could amplify for the Titan gate beam.  We need to go salvage it right away.";  
};

//Optional only happens if go to science base before sec base. 

new ScriptGroup (Sector2FocusStarted : dialogBox_base) 
{     
   character[0] = "MS_SCIENTIST";
   text[0]      = "It seems my old ship has collided with an asteroid.  We're going to have to fracture it to free the ship.  To further complicate matters, it seems my former acquaintances are aware of my presence here and are trying to pillage my work.  They are going to be nothing but bothersome unless we eliminate them.";  
};


new ScriptGroup (Sector2FocusShipFound : dialogBox_base) 
{  
   character[0] = "MS_MINER";
   text[0]      = "Oh my god!  What the hell is that?  Are those people?  We have to help them.";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Well how impressive.  I believe we're looking at my old ship, or what's left of it.  It seems as though some of my half finished experiments have run amok.  I had no idea that I was working on something so volatile.   This is truly amazing; we really do need to take samples.";  
   
   character[2] = "MS_PIRATE";
   text[2]      = "Not going to happen.  We're going to destroy it right now.  I'm not taking any chances.  Carl, I need to know if we can salvage the crystal from the wreckage.  No bullshit here, just a simple yes or a no!";

   character[3] = "MS_SCIENTIST";
   text[3]      = "Well yes, but curse you and your limited ambition!  This could be the discovery of an alien species."; 
};

new ScriptGroup (Sector2FocusComplete : dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "I know neither of you are happy with my decision, but we couldn't let that thing live.  We have enough problems as it is without adding space zombies to the list.  Carl, what shape is the crystal in?";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "The crystal appears to be undamaged, but it's going to need an astronomical amount of power to open the Titan gates.  We'll need several capital ship class capacitors working in tandem to fire it for even a short period.";  
   
   character[2] = "MS_PIRATE";
   text[2]      = "I know of an old battleship graveyard.  It was supposed to stage military surplus during the Lockdown wars, but it was abandoned decades ago.  Since then it's gone to the dogs, being stripped and looted for scrap.  With some luck, we should still be able to find a few capacitors.";
};

new ScriptGroup (Sector2CapacitorStarted : dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "Too damn quiet here.  Well let me tell you this.  Every junk yard I know of has junk yard dogs.  There's just too much metal here for it to be completely unclaimed.  I hope I'm wrong, but keep an eye out and the guns hot.";   
   
   character[1] = "MS_MINER";
   text[1]      = "It looks like this place has also been used as a dumping ground.  A testament to the UTA recycling program.  We should watch out for those toxic barrels.  The shit inside can eat right through even the thickest hull.";
     
   character[2] = "MS_SCIENTIST";
   text[2]      = "What good are you if you're not here to lick our wounds?  I on the other hand have the responsibility to taxi us clear across the known galaxy in the hopes of pulling together a few bucks.  To that end, I've pinpointed several candidates for capacitors that we can salvage for the Titan beam.  I'll need no less than ten of them.  Please retrieve them with haste.  I grow impatient with this constant dilly dallying.";    
};

new ScriptGroup (Sector2CapacitorStolen : dialogBox_base) 
{  
   character[0] = "MS_PUNK";
   text[0]      = "Well, look what we have here.  You're trespassing on my property.  Seeing as how this is your first offence, you can just surrender your ships, and we promise we'll send you home in a shuttle pod.  Hey wait; you were those saps on the evening news.  Oh I'll be making a pretty penny off you folks.";   
   
   character[1] = "MS_MINER";
   text[1]      = "Evening news?  The UTA must have put a damn bounty on us.  Listen to me, you can come with us.  We're just trying to get to the core to score some Rez.  All we need is a few capacitors from your supply field and we'll be able to crack the UTA Titan gates.  A lot of people have joined us already.  What do you say?";
    
   character[2] = "MS_PUNK";
   text[2]      = "Oh yea!  You sure do look purdy!  I'll be able to make some real money with an ass like that.";   
   
   character[3] = "MS_MINER";
   text[3]      = "Oh I see.  Well tell me this asshole!  How does it feel to know you have less than a minute to live?";   
};

new ScriptGroup (Sector2CapacitorBoss : dialogBox_base) 
{  
   character[0] = "MS_MINER";
   text[0]      = "Damn!  We're still short one capacitor.  I'm not picking up anything on the scanner we can salvage.  We're so close.";
    
   character[1] = "MS_PUNK";
   text[1]      = "Aw, you looking for another capacitor there sweetie pie?  It just so happens that I have a nice shiny one right here.  Maybe if you bring your tail over here and ask real sexy like, I'll let you borrow it.  What do you say to that hot stuff?";   
   
   character[2] = "MS_MINER";
   text[2]      = "What in the hell did you just say to me?  All ships target his primary reactor.  I want that ship turned to dust!";  
   
   character[3] = "MS_PIRATE";
   text[3]      = "Whoa, easy there Elsa.  We still need to salvage the capacitor.  We'll just kill him the good old fashion way, okay?";   
 
};

new ScriptGroup (Sector2CapacitorComplete : dialogBox_base) 
{ 
   character[0] = "MS_PIRATE";
   text[0]      = "Okay, crystals and capacitors.  All we need now is a case of beer.  What else are we going to need to punch through those bloody gates?"; 
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Well, now we need a reactor, a massive reactor in fact.  Unfortunately, we can't just twist tie a bunch of them together.  I do however know of a facility in which they are developing reactors for Titan jumping ships.  They won't give them up willingly, so we have little option but to take it by force.";

   character[2] = "MS_MINER";
   text[2]      = "We sure are leaving a lot of grief in our wake.  I can't help but think our selfish desires of getting to the core may be unjustified.";
   
   character[3] = "MS_PIRATE";
   text[3]      = "It'll be worth it Elsa.  The ends will justify the means.  You just have to trust me on this.";
};



new ScriptGroup (Sector2ReactorGrabStarted : dialogBox_base) 
{  
   character[0] = "MS_SCIENTIST";
   text[0]      = "Finally!  This is the place that assembles the reactors we'll need for the Titan beam.  It might be worth noting again that this station is rather protective of their work.  We won't be able to diplomatically convince them to give us the reactor.";
     
   character[1] = "MS_MINER";
   text[1]      = "We don't need to kill them; we just need to make them think we will.  I'd be willing to bet they'll give us the core before we're forced to breach their inner hull.  I'll send them a transmission with our demands.";    

   character[2] = "MS_TURBODEF";
   text[2]      = "Please allow me to introduce myself.  I am the TURBO DEFENDER 9000-EX.  I regret to inform you that your request for surrender is not a customer service my particular model can support.  We understand your time is valuable.  To help speed this process along, please lower your shields, as it will allow your life to be extinguished with greater efficiency.";    

   character[3] = "MS_PIRATE";
   text[3]      = "Oh for hell's sake!  I hate robots.  We don't have any other options but this one.  Let's get our targets locked and get to work.";
};

new ScriptGroup (Sector2ReactorDrop : dialogBox_base) 
{  
   character[0] = "MS_TURBODEF";
   text[0]      = "You're an asshole, you know that?  Take your stupid reactor you jerk.  TURBO DEFENDER 9000-EX doesn't give a shit any more.  TURBO DEFENDER 9000-EX will get old job back waxing space cars.";

   character[1] = "MS_PIRATE";
   text[1]      = "Oh cry me a river of purple piss you tin can!";
};

new ScriptGroup (Sector2ReactorGrabComplete : dialogBox_base) 
{ 
   character[0] = "MS_SCIENTIST";
   text[0]      = "Ah, this reactor will suit our needs perfectly.  It's obviously a variant of one of my ingenious designs.  Not sure what this particular component does though.";    

   character[1] = "MS_MINER";
   text[1]      = "Are you serious?  That's the magnetic stabilizer.  It keeps the thing from exploding.  Remember the part that failed on our old reactor?  Never mind; we have another problem to deal with now.  All these capacitors and reactors are adding mass to the ship.  I wouldn't dare fire this Titan beam without reinforcing the hull.";   
   
   character[2] = "MS_PIRATE";
   text[2]      = "Bloody hell, it's just one thing after another.  Elsa, can you see if there are any stations around that would be willing to make the upgrades required?";   

   character[3] = "MS_MINER";
   text[3]      = "Already on it.  One place does come to mind.  It's a black market mining station.  My father and I lived there when I was very young, hiding from UTA conscription.  It wasn't much of a place to raise a kid, but it's ideal for what we need right now.  They won't work for free, but I don't think they'll pass up the kind of favors we seem to provide.";   

   character[4] = "MS_PIRATE";
   text[4]      = "Why can't anyone accept cash payment any more?  Shit, let's get this over with before we get inundated with more housecleaning.";  
};

new ScriptGroup (Sector2ShipyardFavorStart : dialogBox_base) 
{  
   character[0] = "MS_MINER";
   text[0]      = "My father's contact at the black market mining base has hooked me up with their mercenary contracts board.  It looks like this is the place the contract mentioned.";   
   
   character[1] = "MS_PIRATE";
   text[1]      = "Alright, let's get this over with.  What the hell is this job all about anyway?";   

   character[2] = "MS_MINER";
   text[2]      = "Well the UTA have been camping out here, charging a toll on passing ships.  It's slowing everything down, not to mention it's illegal.  Needless to say, this UTA operation is off the books, so I doubt they have any backup out here.  Like I said, a nice and simple job.  Once we're finished, we'll head over to the construction yard and begin retrofitting big mamma.";    

   character[3] = "MS_PIRATE";
   text[3]      = "All of this out of a classified ad huh?  I hope you know what you're doing Elsa.  You know how I like dealing with people face to face.  It gives me something to punch when things don't go according to plan.";  

   character[4] = "MS_SCIENTIST";
   text[4]      = "Spoken like a true gentleman.  Your compassion and tolerance knows no bounds.";    
};

new ScriptGroup (Sector2ShipyardFavorComplete : dialogBox_base) 
{  
   character[0] = "MS_STARCONTRACT";
   text[0]      = "On behalf of StarContracts.wut we would like to thank you for your timely completion of the registered contract \n\nMURDER DAMN UTA SHIPS\n\nYour payment is ready for pickup at the following location. \n\nWINK WINK\n\nWe hope you will use StarContracts.wut in the future.";   
   
   character[1] = "MS_PIRATE";
   text[1]      = "That job was too easy.  I don't like this.  Considering how much activity has been going on here lately, I'd expect more resistance than that.";   

   character[2] = "MS_SCIENTIST";
   text[2]      = "Well paranoia aside.  The mining base has set up an off site shipyard to conduct the expansions to the Clockwork.  I'd like to return to make sure they aren't doing anything idiotic to my ship.";    
};

new ScriptGroup (Sector2ShipyardStart : dialogBox_base) 
{ 
   character[0] = "MS_JAMISON";
   text[0]      = "Well hello again Carl.  It seems as though you and your friends have been making quite a mess around the neighborhood.  It turns out that there is a guaranteed promotion to anyone who tracks you down.  If I knew your heads were that valuable, you would have never left Proxima.  I won't be making that mistake again.  Dead or alive, you're coming with me.";    

   character[1] = "MS_SCIENTIST";
   text[1]      = "How articulate of you.  Did you come up with that all by yourself?  You really have an eye for this kind of thing.";    

   character[2] = "MS_PIRATE";
   text[2]      = "Carl you son of a bitch!  Your contact tracked us here.  An entire UTA attack fleet is on an intercept course with the Clockwork.  Everyone to battle stations now!";    

   character[3] = "MS_SCIENTIST";
   text[3]      = "Oh don't be so dramatic.  His flagship is rigged up with surplus Junk.  You shouldn't have any trouble putting the Cyclops in his place.  Do what you do best.";    
};

new ScriptGroup (Sector2ShipyardComplete : dialogBox_base) 
{ 
   character[0] = "MS_JAMISON";
   text[0]      = "Well played!  It appears I'll have to come back with a larger ship.  Listen to me and listen well.  I strongly recommend you stay the hell away from the core worlds.  You have no idea the shit storm you'll bring upon yourself if you breach the Titan gates.";    
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "Well that was positively terrifying.  We were nearly gunned down by a half blind man.  My dead grandmother can fire a particle array better than that.  What are you people trying to do to my ship?";    
   
   character[2] = "MS_MINER";
   text[2]      = "Your ship?!  It was your asshole acquaintances that tracked us all the way here.  Now the UTA are on the hunt for us.  I'm going to kick your skinny ass inside out Carl.";   

   character[3] = "MS_PIRATE";
   text[3]      = "Let me be abundantly clear on the matter.  If either of you put my ship in jeopardy again I'll kill you.  There is too much at risk for any of you to screw it up with amateur mistakes.  Fix the damage and get this damn thing up and running now!";   

};

new ScriptGroup (Sector2HeadForSector3 : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "I've done some diagnostics, and my Titan beam should be fully compatible with all the Titan gates.  Despite all the effort to keep everyone out, the UTA's plans will be thwarted by my superior mind and some duct tape.";   
   
   character[1] = "MS_MINER";
   text[1]      = "Easy there Carl or we'll have to expand the ship's hull again to house your swollen ego.  I've managed to cobble together a network map using old star maps from before the lockdown.  The star map will now show all the new systems we can access.";   

   character[2] = "MS_PIRATE";
   text[2]      = "That took bloody long enough.  Let's lay in a course for the nearest Titan gate and get the hell out of dodge.  I don't want to be around if Jamison comes back for us.";   
};


new ScriptGroup (Sec2UTAFleeTitan : dialogBox_base) 
{
   character[0] = "MS_UTACOWARD";
   text[0]      = "Oh crap!  It's those renegades from the news.  I'm not dying for this.  Everyone, get the hell out of there.  I'm getting too old for this shit.";   
};

new ScriptGroup (TitanGateTooEarly : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "What did I tell you Neanderthals?  We can't get through these Titan gates without a calibrated Titan beam.  Trust me; there is no other way around it.  It does its job flawlessly.  This thing does have the blessing of my expertise after all.";   
};










