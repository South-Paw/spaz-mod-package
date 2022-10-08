
///////////////////////////////////////////////////////////////////
// DIALOG OBJECTS
///////////////////////////////////////////////////////////////////

new ScriptGroup (Dialog_S1_EngineStartup : dialogBox_base) 
{
   character[0] = "MS_PIRATE";
   text[0]      = "Okay folks.  It's that time again.  This'll be our seventh engine test this week.  I don't want to go to bed with radiation burns again tonight, alright?  Let's get those puppies fired up good and proper this time.";
    
   character[1] = "MS_SCIENTIST";
   text[1]      = "Yes, well you see, we're lucky the toilets even flush on this brick.  I've managed to bootstrap the induction coil to the main core to boost output, but I don't expect it to maintain a viable reaction.  Nuclear particle physics and duct tape do not mingle well, yes?";   
   character[2] = "MS_PIRATE";
   text[2]      = "Carl, I have no idea what the hell you're talking about.  Just turn the bloody thing on.";
};

new ScriptGroup (Dialog_S1_EngineGetPart : dialogBox_base) 
{
   character[0] = "MS_MINER";
   text[0]      = "Damn!  The magnetic stabilizers blew.  We have major breaches on decks six through ten.  Our escort ships are gone, and we're venting atmosphere.  We have crew casualties.";
    
   character[1] = "MS_SCIENTIST";
   text[1]      = "Oh crewmen can always be replaced!  The ship damage on the other hand.  Well, I told you that piece of junk wouldn't hold back an overload.  Did you honestly expect any different?  Look at what I have to work with here.";

   character[2] = "MS_MINER";
   text[2]      = "The blown stabilizer system will have to be replaced before we can even think of trying this again.  It's a common part.  I'm sure there is another one in the junk field somewhere.  We still have a working hangar, so let's fire up the fabricator systems and build a ship to retrieve it.";
};

new ScriptGroup (Dialog_S1_EnginePartReturned : dialogBox_base) 
{
   character[0] = "MS_SCIENTIST";
   text[0]      = "Well that should fix the stabilizer, but the overload compromised the structural integrity of the ship more than I initially thought.  We can't jump with a breach like this.  I've written up an extensive list of the repairs that will have to be satisfied before I'll conduct another test.  Meanwhile I'll be in my quarters.  Let me know when you're done cleaning up your failure.";
    
   character[1] = "MS_MINER";
   text[1]      = "Oh you've got to be kidding!  I really do hate that man.  We're going to need to replace more than just one ship if we expect to cork that hole any time soon.";

   character[2] = "MS_PIRATE";
   text[2]      = "That's unfortunately easier said than done.  The hull damage vented most of our Rez supply.  We even lost all the damn liquor.  We need to restock before we can build more ships.  There is a mining station in the system.  Elsa, you've worked with the miners before.  See if you can convince them to let us harvest in their territory.";
};

//IMPORTANT
//Should have dialogue here where miner contacts base, makes base allied.
new ScriptGroup (Dialog_S1_MakeMiningBaseFriendly : dialogBox_base) 
{
   character[0] = "MS_MINER";
   text[0]      = "I contacted the mining base.  They're all drunk on industrial paint stripper, so it wasn't too hard to convince them to let us harvest some Rez.  We'll have to be very careful around here.  The mining base is automated and won't think twice about slicing us in half with that mining beam.  Let's siphon what we need and move on.";

   character[1] = "MINING_BASE";
   text[1]      = "Your prospecting request has been granted.  Please refrain from tampering with the automated mining systems.  If you happen to be exposed to the vacuum of space, please proceed to the nearest eye wash station and rinse thoroughly.  Thank you, and have a pleasant day.";

   character[2] = "MS_SCIENTIST";
   text[2]      = "This should be interesting.  That asteroid they are drilling into is even more dense than you Elsa.  There is no way we can crack it.  Only a station class core mining beam can even come close.  We'll have to grab the spill off table scraps.  I feel like such a transient.";
};

new ScriptGroup (Dialog_S1_BuildFleet : dialogBox_base) 
{
   character[0] = "MS_MINER";
   text[0]      = "Now we have enough Rez to build the extra ship we're going to need, plus I was able to officially kick ass and salvage another hangar.  We should be able to support two ships now.";

   character[1] = "MS_SCIENTIST";
   text[1]      = "That being the good news, here is the bad news.  The explosion all but wiped out our construction database, and nobody backed up their hard drive.  Luckily, I was able to recover the data for a single small fighter ship called the Dart.  I recommend we build a couple.  Our current ships can't even cut butter, let alone stand up against any UTA ships.";

   character[2] = "MS_PIRATE";
   text[2]      = "Well, finally some progress!  Let's see to it that we collect what we need to build two Darts.  We're not leaving until we have some ships fit for combat.";
};

new ScriptGroup (Dialog_S1_MiningChainSetup : dialogBox_base) 
{
   character[0] = "MS_PIRATE";
   text[0]      = "Well, there we go.  Our fleet is slightly less pathetic now.  We've got what we need; now let's get the hell out of here.";

   character[1] = "MS_MAC";
   text[1]      = "So ye'all wanna pick my stones and run off eh?  Well you go right ahead there missy, but not without hearin' me out first.  Ye'all help us kick those UTA boys in the jimmy and me and the boys will fix up that big ol' ship you got floatin' around.  What say ya?";
  
   character[2] = "MS_MINER";
   text[2]      = "I suppose we can trust these people, providing you don't have any money in your pockets.  I'm not sure we really have much of a choice.  We're weeks away from repairing the Clockwork without their help.  We have a small and capable fleet now, why not put it to some use?";
};

new ScriptGroup (Dialog_S1_Favor1Started : dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "Ah fortune smiles!  We're lucky there are no UTA ships here right now.  They are probably off robbing some other mining patrol.  These fringe worlds are unmonitored, so the bastards just do as they damn well please.  Let's loot the hell out of this place quickly before they come back.  We need to keep an eye on what we're blasting too.  Mac sent us some backup, so don't be shooting at the green ships!"; 

   character[1] = "MS_MINER";
   text[1]      = "The tactical systems have been repaired and are coming online now.  We need to fire the system up to make sure there aren't any crossed wires."; 
};

new ScriptGroup (Dialog_S1_Favor1GoneBad : dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "Shit, UTA ships on radar!  I was hoping they wouldn't come back so soon, but we're not that lucky are we?  This job just got a bit more complicated than kicking over a few boxes.  We'll have to take them out.  Check your damn targets too.  This place is crawling with civilian ships, and the last thing we need right now is a three way firefight.";
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "You know, a confrontation may not be a bad thing.  If we destroy their ships, I can salvage most of their data and rebuild our database.  We can then pick up the escape pods and force the willing to work on ship repairs.  We lost quite a few of those crewmen with the red shirts in the explosion.";
};

new ScriptGroup (Dialog_S1_Favor1Complete : dialogBox_base) 
{  
   character[0] = "MS_MAC";
   text[0]      = "Ye'all kick them UTA assholes!  Now we went and figured some of our own folk gone and helped them UTA bastards.  I hate to be shootin' down my own boys, but mamma won't stand for it.  Please go on and deal with them before they turn tail and run off.  I've sent you one of them E-mail things for your map.  Ye'all should maybe stop by my station before scootin off.  That's some real turd you have hangin off your ships.  Mac can sells you some fine booty to replace those rusty boom sticks you've been fighting with.";
};


new ScriptGroup (Dialog_S1_Favor2Complete : dialogBox_base) 
{  
   character[0] = "MS_MAC";
   text[0]      = "Wooooo boy!  You really know how to show a girl a good time!  I hate to be the donkey's carrot here mister, but we still need some of that fine help you been providing.  Them UTA bastards have come back lookin' for their missin' goons.  I be thinkin' we waste 'em and eventually they'll stop comin' around here.";
};

new ScriptGroup (Dialog_S1_Favor3Complete : dialogBox_base) 
{  
   character[0] = "MS_MAC";
   text[0]      = "Well this be the best day of my whole life!  Just like apple pie!  I think we be done sending you on suicide missions now mister.  C'mon back to the Clockwork and have a drink on us.  We'll have that big ol' turd of yours polished up in no time.";
};

new ScriptGroup (Dialog_S1_Clockwork1Ready : dialogBox_base) 
{  
   character[0] = "MS_SCIENTIST";
   text[0]      = "I have to admit my surprise that Elsa's friends were able to patch up the Clockwork in decent time.  Let's hope it doesn't fly apart around the first bend.";

   character[1] = "MS_MINER";
   text[1]      = "You should have more faith in these people.  They took a risk lending us a hand, and we should pray we find such luck in the future.";

   character[2] = "MS_PIRATE";
   text[2]      = "You two need to stay focused.  Don't forget we almost got killed back there, and we haven't even left home yet.  As long as they are willing to pay us, we can stay to build up the fleet and collect the supplies we need.  Beyond that, we have no time for chivalry or to fight a losing war.  Getting the hell out of here is all that matters right now.";

   character[3] = "MS_SCIENTIST";
   text[3]      = "Well it looks like these feeble repairs allow us to build much larger vessels.   We need to be on the lookout for black boxes.  I can use them to reverse engineer new ship designs and rebuild our database.";
};

new ScriptGroup (Dialog_S1_WarpgateArrival : dialogBox_base) 
{  
   character[0] = "MS_PIRATE";
   text[0]      = "Alright, here's the first gate we need to cross.  The UTA ships are loaded down with warp inhibitors so we'll need to wipe out every last one of them before we can access the warp network.  We should expect similar blockades at every warp gate between us and the core.";
};

new ScriptGroup (Dialog_S1_WarpgateComplete : dialogBox_base) 
{    
   character[0] = "MS_PIRATE";
   text[0]      = "That's the last of the bastards.  Unfortunately from this moment on, it gets nothing but harder.  If we're going to survive, a pirate's life is all we have the luxury of now.  The warp gate is back online, so let's heat up the warp capacitor and set a course.  We've all been here far too long.  It's time we moved on.";
};


new ScriptGroup (Dialog_S1_Levelup : dialogBox_base) 
{    
   character[0] = "MS_SCIENTIST";
   text[0]      = "Good, we've acquired enough data.  I can start upgrading some of our ship's systems.  We don't have a lot of data, but we have enough to get a few critical systems up to par.  We'll have to choose which upgrades we think are most important.  We should take care of this right away to get a leg up against our enemies.";
};

new ScriptGroup (Dialog_S1_FirstCrew : dialogBox_base) 
{    
   character[0] = "MS_FIRSTCREW";
   text[0]      = "Hey man, please don't kill me man.  I was just following orders.  I really don't even know why I'm out here.";
   
   character[1] = "MS_PIRATE";
   text[1]      = "Well, I'm not going to kill you yet.  Drones are expensive and the toilets are in need of a scrubbing.  Perhaps you can take a look at that crack in the reactor for me.  Hell, you're going to eat turd sandwiches without the bread if I tell you to.  You even look at me the wrong way; I'll toss your ass out an air-lock.";
   
   character[2] = "MS_MINER";
   text[2]      = "That might have been a bit harsh.  As awesome as I am and fixing your tin traps, I could really use the extra crew working repairs.  We should put anyone who is willing to use.  The Clockwork can also hold quite a few extra goons if we need to keep manpower in reserve.  We don't really need to space everyone we come across.";
   
   character[3] = "MS_SCIENTIST";
   text[3]      = "I do agree with you, somewhat.  Let us not forget that these goons might be valuable if we pawn them off as workers.  I'm sure there are many stations that are willing to pay for the extra manpower.";
};

//BOUNTY INTRO//

new ScriptGroup (Dialog_S1_BountyIntro: dialogBox_base) 
{    
   character[0] = "MS_BOUNTY";
   text[0]      = "Listen up and listen well, as I'm only going to say this one time!  The UTA might not be able to stop you, but we certainly and easily can.  This sector is ours; you're simply living in it.  As such, you are required to pay us whenever we see fit to ask it of you.  Make a error in judgement against us, and you'll be erased.  If you want to earn our respect, and a bit of income on the side, come by one of our bases and we'll talk.  We have special events for fodder like you.  Just watch yourself in our territory, as we'll surely be watching you.  Goodbye.";

   character[1] = "MS_MINER";
   text[1]      = "Yeah, that's a bit creepy.  We're not the only ones around here freely kicking over warp gate blockades.  That signal source just came and went.  I have no way to track it.  These boys must be packing some serious gear.  Probably a good idea if we just take a wide berth around their systems if we see them.";

   character[2] = "MS_SCIENTIST";
   text[2]      = "Where is the science Elsa!  If these gentlemen have better technology than we do, we must investigate them further.  We've practically been given an invitation.";
};



