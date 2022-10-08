
///////////////////////////////////////////////////////////////////
// functions
///////////////////////////////////////////////////////////////////

function CharData_getName(%character)
{
   %fullName = "charData_" @ %character;
   return %fullName.title; 
}

function CharData_getImage(%character)
{
   %fullName = "charData_" @ %character;
   return %fullName.image.imageName;  
}

function CharData_getOptional(%character, %index)
{
   %fullName = "charData_" @ %character;
   return %fullName.optional[%index];  
}

///////////////////////////////////////////////////////////////////
// Known Characters
///////////////////////////////////////////////////////////////////

new ScriptGroup (charData_Base) 
{
   title = "not defined";
   image = "pirateFace_01ImageMap";
   optional[1] = "";
   optional[2] = "";
   optional[3] = "";
   optional[4] = "";
};

new ScriptGroup (charData_MS_PIRATE : charData_Base) 
{
   title = "DON GIBSON";
   image = "pirateFace_01ImageMap";
};

new ScriptGroup (charData_MS_MINER : charData_Base) 
{
   title = "ELSA YOUNG";
   image = "pirateFace_03ImageMap";
};

new ScriptGroup (charData_MS_SCIENTIST : charData_Base) 
{
   title = "DR. CARL MEMFORD";
   image = "civFace_01ImageMap";
};

new ScriptGroup (charData_UTA_ADMIRAL : charData_Base) 
{
   title = "COMMANDER WESTON";
   image = "terranFace_02ImageMap";
};

new ScriptGroup (charData_ANONYMOUS : charData_Base) 
{
   title = "ANONYMOUS";
   image = "unknownFace_01ImageMap";
};

new ScriptGroup (charData_SCIENCE_BASE : charData_Base) 
{
   title = "SCIENCE BASE";
   image = "scienceFace_01ImageMap";
};

new ScriptGroup (charData_COLONY_BASE : charData_Base) 
{
   title = "COLONY BASE";
   image = "colonyFace_01ImageMap";
};

new ScriptGroup (charData_MINING_BASE : charData_Base) 
{
   title = "MINING BASE";
   image = "miningFace_01ImageMap";
};

new ScriptGroup (charData_SECURITY_BASE : charData_Base) 
{
   title = "UTA BASE";
   image = "secFace_01ImageMap";
};


new ScriptGroup (charData_TUTORIAL : charData_Base) 
{
   title = "TUTORIAL";
   image = "tutorialFace_01ImageMap";
};

new ScriptGroup (charData_MS_MAC : charData_Base) 
{
   title = "MAC";
   image = "pirateFace_02ImageMap";
};

new ScriptGroup (charData_MS_EVILDON : charData_Base) 
{
   title = "DON GIBSON";
   image = "zombieFace_01ImageMap";
};

new ScriptGroup (charData_MS_PURPLEFACE : charData_Base) 
{
   title = "SCIENCE BASE";
   image = "zombieFace_02ImageMap";
};

new ScriptGroup (charData_MS_JAMISON : charData_Base) 
{
   title = "ADMIRAL JAMISON";
   image = "terranFace_01ImageMap";
};

new ScriptGroup (charData_MS_SEC3_SCIENCE_BASE : charData_Base) 
{
   title = "DR. GALE HARPER";
   image = "civFace_02ImageMap";
};

new ScriptGroup (charData_MS_CONTRACT : charData_Base) 
{
   title = "GET CONTRACT";
   image = "contractFace_01ImageMap";
};

new ScriptGroup (charData_MS_TRADE : charData_Base) 
{
   title = "TRADE RESOURCES";
   image = "contractFace_01ImageMap";
};

new ScriptGroup (charData_MS_PUNK : charData_Base) 
{
   title = "SPACE SKID PUFF";
   image = "punkFace_01ImageMap";
};

new ScriptGroup (charData_MS_STARCONTRACT : charData_Base) 
{
   title = "STAR CONTRACTS COMPLETION FORM";
   image = "contractFace_01ImageMap";
};

new ScriptGroup (charData_MS_FIRSTCREW : charData_Base) 
{
   title = "CAPTURED CREWMAN";
   image = "civFace_03ImageMap";
};

new ScriptGroup (charData_MS_UTACOWARD : charData_Base) 
{
   title = "COWARDLY UTA COMMANDER";
   image = "civFace_04ImageMap";
};

new ScriptGroup (charData_MS_TURBODEF : charData_Base) 
{
   title = "TURBO DEFENDER 9000-EX";
   image = "autoFace_01ImageMap";
};

new ScriptGroup (charData_MS_EXTRA_01 : charData_Base) 
{
   title = "TOM PRESTON";
   image = "face_extra_01ImageMap";
};

new ScriptGroup (charData_MS_EXTRA_02 : charData_Base) 
{
   title = "MAJOR DICKENS";
   image = "face_extra_02ImageMap";
};

new ScriptGroup (charData_MS_MOONBURGER : charData_Base) 
{
   title = "MOON BURGER";
   image = "face_moonBurgerImageMap";
};

new ScriptGroup (charData_MS_SPAMBOT : charData_Base) 
{
   title = "SPAM BOT";
   image = "maxCap_01ImageMap";
};

new ScriptGroup (charData_MS_ANONYMOUS : charData_Base) 
{
   title = "MYSTERY CONTACT";
   image = "unknownFace_01ImageMap";
};

new ScriptGroup (charData_MS_BOUNTY : charData_Base) 
{
   title = "BOUNTY HUNTER";
   image = "bountyFace_01ImageMap";
};

new ScriptGroup (charData_MS_ALIENFX : charData_Base) 
{
   title = "ALIEN FX";
   image = "alienWareFace_01ImageMap";
};

///////////////////////////////////////////////////////////////////
// OLD CHARACTER DATA
///////////////////////////////////////////////////////////////////

/*
$dialogObjectCharacter["DYSON", "title"] = "COMMANDER DYSON JONES";
$dialogObjectCharacter["DYSON", "image"] = "~/data/images/interface/hud/mugShots/terranFace_01.png";

$dialogObjectCharacter["CARLOS", "title"] = "DR. CARLOS MEMFORD";
$dialogObjectCharacter["CARLOS", "image"] = "~/data/images/interface/hud/mugShots/civFace_01.png";

$dialogObjectCharacter["DON", "title"] = "DON GIBSON";
$dialogObjectCharacter["DON", "image"] = "~/data/images/interface/hud/mugShots/pirateFace_01.png";

$dialogObjectCharacter["ELSA", "title"] = "ELSA RENOLDS";
$dialogObjectCharacter["ELSA", "image"] = "~/data/images/interface/hud/mugShots/pirateFace_03.png";

$dialogObjectCharacter["MAC", "title"] = "MAC EDWARDS";
$dialogObjectCharacter["MAC", "image"] = "~/data/images/interface/hud/mugShots/pirateFace_02.png";

$dialogObjectCharacter["ADAM", "title"] = "ADAM FOSTER";
$dialogObjectCharacter["ADAM", "image"] = "~/data/images/interface/hud/mugShots/pirateFace_02.png";

$dialogObjectCharacter["RENA", "title"] = "RENA MOSS";
$dialogObjectCharacter["RENA", "image"] = "~/data/images/interface/hud/mugShots/pirateFace_02.png";

$dialogObjectCharacter["ZOMBIE_DON", "title"] = "ZOMBIE DON";
$dialogObjectCharacter["ZOMBIE_DON", "image"] = "~/data/images/interface/hud/mugShots/zombieFace_01.png";

$dialogObjectCharacter["ZOMBIE", "title"] = "ZOMBIE";
$dialogObjectCharacter["ZOMBIE", "image"] = "~/data/images/interface/hud/mugShots/zombieFace_02.png";

$dialogObjectCharacter["RECORDING", "title"] = "AUTOMATED RECORDING";
$dialogObjectCharacter["RECORDING", "image"] = "~/data/images/interface/hud/mugShots/autoFace_01.png";

$dialogObjectCharacter["ANONYMOUS", "title"] = "ANONYMOUS";
$dialogObjectCharacter["ANONYMOUS", "image"] = "~/data/images/interface/hud/mugShots/unknownFace_01.png";

$dialogObjectCharacter["MAXCAP", "title"] = "MAX CAPACITOR!!";
$dialogObjectCharacter["MAXCAP", "image"] = "~/data/images/interface/hud/mugShots/maxCap_01.png";

*/

///////////////////////////////////////////////////////////////////
// BASE DIALOG OBJECT
///////////////////////////////////////////////////////////////////

new ScriptGroup (dialogBox_base) 
{
   class = "DialogBoxClass";

   title[0] = ""; //used for multibutton windows
   
   character[0] = "MS_PIRATE";
   text[0] = "";
   soundCue[0] = "";
};


///////////////////////////////////////////////////////////////////
// DIALOG OBJECTS
///////////////////////////////////////////////////////////////////

new ScriptGroup (Dialog_Generic_Mining : dialogBox_base) 
{
   character[0] = "MINING_BASE";
   title[0]     = "MINING BASE INFO BOARD";
   text[0]      = "Welcome!  Feel free to browse our stocks.  We're always looking for able-bodied workers.  Take a look at some of the new exciting employment opportunities we offer."; 
};

new ScriptGroup (Dialog_Generic_Science : dialogBox_base) 
{
   character[0] = "SCIENCE_BASE";
   title[0]     = "SCIENCE BASE INFO BOARD";
   text[0]      = "Looking for power converters?  We probably sell them here.  Need a job?  We're always looking for new guinea pigs.  Help modern science.  Apply inside today!"; 
};

new ScriptGroup (Dialog_Generic_Colony : dialogBox_base) 
{
   character[0] = "COLONY_BASE";
   title[0]     = "COLONY BASE INFO BOARD";
   text[0]      = "Got good people skills and a reasonable criminal record?  We're looking for people like you.  Drop off a resume today!  Don't forget to stop by the gift shop on your way out."; 
};

new ScriptGroup (Dialog_Generic_Security : dialogBox_base) 
{
   character[0] = "SECURITY_BASE";
   title[0]     = "SECURITY BASE INFO BOARD";
   text[0]      = "Ready to fight the good fight?  We're always looking for new pilots.  Join the UTA today and become part of the solution."; 
};

new ScriptGroup (Dialog_Generic_TutorialList : dialogBox_base) 
{
   character[0] = "TUTORIAL";
   title[0]     = "TUTORIAL DATABASE";
   text[0]      = "Forget how to tie your shoes?  Resort to your handy tutorial database for a refresher.  Don't be caught in a space battle with your pants down.  RTFM!"; 
};



new ScriptGroup (Dialog_Generic_Contract : dialogBox_base) 
{
   character[0] = "MS_CONTRACT";
   title[0]     = "PICK UP A CONTRACT";
   text[0]      = ""; 
};

new ScriptGroup (Dialog_Generic_GateBribe : dialogBox_base) 
{
   character[0] = "MS_TRADE";
   title[0]     = "BRIBE WARP GATE GUARDS";
   text[0]      = "If the UTA like you enough, you can pay your way past warp gate blockades rather than having to use lethal force.  Which gate would you like to pass?"; 
};

new ScriptGroup (Dialog_Generic_GateBHAssault : dialogBox_base) 
{
   character[0] = "MS_TRADE";
   title[0]     = "BOUNTY HUNTER GATE ASSAULT";
   text[0]      = "If the Bounty Hunters like you enough, you can use some of your influence to sick them on unsuspecting gate guards. Which gate would you like cleared?"; 
};


new ScriptGroup (Dialog_Generic_GateBHInfectionAssault : dialogBox_base) 
{
   character[0] = "MS_TRADE";
   title[0]     = "BOUNTY HUNTER INFECTION ASSAULT";
   text[0]      = "If the Bounty Hunters like you enough, you can use some of your influence to sick them on a nearby infection root, weakening it for a short time.  Which system would you like the bounty hunters to assault?"; 
};

new ScriptGroup (Dialog_Generic_Cheater : dialogBox_base) 
{
   character[0] = "MS_SPAMBOT";
   title[0]     = "CHEAT MENU";
   text[0]      = "WARNING: If you wish to cheat you will not be able to gain achievements, and some strange things may occur.  You have been warned!"; 
};

////////////////////////////////////////////////////////////////////////////////
// bounty hunter dialog
////////////////////////////////////////////////////////////////////////////////


new ScriptGroup (Dialog_Generic_BountyBase : dialogBox_base) 
{
   character[0] = "MS_BOUNTY";
   title[0]     = "BOUNTY BASE INFO BOARD";
   text[0]      = "Text to be added"; 
};

new ScriptGroup (Dialog_BountyBase_RootIntro : dialogBox_base) 
{
   character[0] = "MS_BOUNTY";
   title[0]     = "BOUNTY BASE INFO BOARD";
   text[0]      = "Welcome to our humble hide away.  Just watch yourself here, because we'll be watching you!  Make one wrong move, and we'll put an end to you."; 
};

/////////////////////////////////////////////////////////
// Alien FX /////////////////////////////////////////////
/////////////////////////////////////////////////////////


new ScriptGroup (Dialog_AlienFX_Root : dialogBox_base) 
{
   character[0] = "MS_ALIENFX";  
   title[0]     = "AlienFX: Device Selection";
   text[0]      = "This system allows you to configure your AlienFX enabled system to interface with Space Pirates and Zombies. Please select a device, or click on Global Settings to apply to all connected devices."; 
};

new ScriptGroup (Dialog_AlienFX_Device : dialogBox_base) 
{
   character[0] = "MS_ALIENFX";  
   title[0]     = "AlienFX: LABEL DEVICE HERE";
   text[0]      = "Select the lighting for the entire device, or select an individual light to connect to a gameplay system."; 
};

new ScriptGroup (Dialog_AlienFX_Light : dialogBox_base) 
{
   character[0] = "MS_ALIENFX";  
   title[0]     = "AlienFX: LABEL LIGHT HERE";
   text[0]      = "Select a lighting connection for the currently selected light(s)."; 
};

new ScriptGroup (Dialog_AlienFX_Custom : dialogBox_base) 
{
   character[0] = "MS_ALIENFX";  
   title[0]     = "AlienFX: LABEL CUSTOM COLOR ROOT";
   text[0]      = "Select a constant custom color for the currently selected light(s)."; 
};












