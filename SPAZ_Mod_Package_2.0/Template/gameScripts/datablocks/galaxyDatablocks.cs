//Using an accessor to keep things clean
$GAL_STAR_TECH_FOCUS         = 0;  //see: $STF_CATEGORIES
$GAL_STAR_TECH_LEVEL         = 1;
$GAL_INITIAL_SECURITY        = 2;
$GAL_INITIAL_INFRASTRUCTURE  = 3;
$GAL_STAR_ISKNOWN            = 4;
$GAL_STARPOS_X               = 5;
$GAL_STARPOS_Y               = 6;
$GAL_INITIAL_INFECTION       = 7;
$GAL_RELATIONS_PIRATE_CIV    = 8;
$GAL_RELATIONS_PIRATE_TERRAN = 9;
$GAL_RELATIONS_CIV_TERRAN    = 10; //we may want to diddle with this too.
//Earth   star0_setupData = "Bal 1 0 1 1 0 0 0 1 0.25 0.75";
//Sector2_Root "Random 3 0 0 0 350 50 RANDOM RANDOM RANDOM RANDOM";
//FRONTEND "Random 100 0 0 0 0 0 1 RANDOM RANDOM RANDOM";

new ScriptObject(StarReplace)  //need names for linking to others since starType maaaay be the same. 
{
   insertMode = "StarReplace";
};

new ScriptObject(StarAdd)  //need names for linking to others since starType maaaay be the same. 
{
   insertMode = "StarAdd";
};

new ScriptGroup(GalaxyBase)
{
   class = "GalaxyDatablock";      
};


///////////////////////////////////////////////////////
// Front End Galaxy ///////////////////////////////////
///////////////////////////////////////////////////////

new ScriptGroup(FrontEndGalaxy : GalaxyBase)
{   
   new ScriptObject(FEG_FRONTEND : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "FRONTEND";  
      desiredLevel = "Random";  //doenst care.
      
      techFocus = "RANDOM";
      techLevel = 80;
      initialSec = 0;
      initialInf = 0;
      initialInfection = 0;
      relationPirCiv = 0.25;
      relationPirUta = 0.25;
      relationCivUta = 0.25;
   };
};


///////////////////////////////////////////////
// Story Galaxy ///////////////////////////////
///////////////////////////////////////////////

//note: start galaxy creation at level 5 and end at level 95.
//start and end levels will be inserted. 
new ScriptGroup(StoryGalaxy : GalaxyBase)
{    
   //////////////////////////////
   // Sector 1/2 Connection /////
   //////////////////////////////
   
   //Star Replace Planets
   new ScriptObject(SG_SEC_2_ROOT : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector2_Root";      
      //desiredLevel = 5;  
      desiredLevel = "LastStar"; //special id so i can show where earth will be on galgen
       
      techFocus = "RANDOM";
      techLevel = 5;
      initialSec = 2;
      initialInf = 1;
      initialInfection = 0;
      relationPirCiv = 0.25;
      relationPirUta = 0.75;
      relationCivUta = 0.25;
   };
     
   //Insert New Planets
   new ScriptObject(SG_EARTH : StarAdd)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Earth";  
      connectionStar = "Sector2_RootSystem"; 
      offsetPercent = 1.05; //% outside the outer donut. 
      offsetAngle = 0;
           
      techFocus = "Bal";
      techLevel = 1;
      initialSec = 0;
      initialInf = 1;
      initialInfection = 0;
      relationPirCiv = 1;
      relationPirUta = 0.25;
      relationCivUta = 0.25;
   };
   
   new ScriptObject(SG_WOLF359 : StarAdd)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "WOLF359";  
      connectionStar = "Sector2_RootSystem"; 
      offsetPercent = 1.08; //% outside the outer donut. 
      offsetAngle = 3;
           
      techFocus = "RANDOM";
      techLevel = 8;
      initialSec = 1;
      initialInf = 1;
      initialInfection = 0;
      relationPirCiv = 0.25;
      relationPirUta = 0.50;
      relationCivUta = 0.25;
   };
   
   new ScriptObject(SG_SIRIUS : StarAdd)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "SIRIUS";  
      connectionStar = "Sector2_RootSystem"; 
      offsetPercent = 1.02; //% outside the outer donut. 
      offsetAngle = -5;
           
      techFocus = "RANDOM";
      techLevel = 11;
      initialSec = 2;
      initialInf = 2;
      initialInfection = 0;
      relationPirCiv = 0.5;
      relationPirUta = 0.25;
      relationCivUta = 0.25;
   };
   
   new ScriptObject(SG_LUYTEN : StarAdd)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "LUYTEN";  
      connectionStar = "Sector2_RootSystem"; 
      offsetPercent = 1.02; //% outside the outer donut. 
      offsetAngle = 7;
           
      techFocus = "RANDOM";
      techLevel = 15;
      initialSec = 1;
      initialInf = 1;
      initialInfection = 0;
      relationPirCiv = 0.5;
      relationPirUta = 0.5;
      relationCivUta = 0.5;
   };
   
   
   //////////////////////////
   // Sec 2 Flow Stars //////
   //////////////////////////
   
   new ScriptObject(SG_SEC_2_CAPACITORS : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector2_Capacitor";      
      desiredLevel = 18;  
      
      //for placement weighting
      desiredDistance = 0.30;
      referenceStar = "Sector2_RootSystem"; 
       
      techFocus = "RANDOM";
      techLevel = 18;
      initialSec = 1;
      initialInf = 1;
      initialInfection = 0;
      relationPirCiv = 0.2;
      relationPirUta = 0.50;
      relationCivUta = 0.25;
   };
   
   new ScriptObject(SG_SEC_2_REACTOR : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector2_Reactor";      
      desiredLevel = 25;  
      
      //for placement weighting
      desiredDistance = 0.50;
      referenceStar = "Sector2_RootSystem"; 
       
      techFocus = "RANDOM";
      techLevel = 25;
      initialSec = 2;
      initialInf = 2;
      initialInfection = 0;
      relationPirCiv = 0.2;
      relationPirUta = 0.50;
      relationCivUta = 0.25;
   };
   
   new ScriptObject(SG_SEC_2_SHIPYARD : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector2_Shipyard";      
      desiredLevel = 32;  
      
      //for placement weighting
      desiredDistance = 0.70;
      referenceStar = "Sector2_RootSystem"; 
       
      techFocus = "RANDOM";
      techLevel = 32;
      initialSec = 2;
      initialInf = 2;
      initialInfection = 0;
      relationPirCiv = 0.7;
      relationPirUta = 0.2;
      relationCivUta = 0.25;
   };
   
   
   //////////////////////////
   // Sec 3 Flow Stars //////
   //////////////////////////
   
   new ScriptObject(SG_SEC_3_UBERCOLONY : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector3_UberColony";      
      desiredLevel = 48;  //is it possible we would jump into prev circle?
       
      techFocus = "RANDOM";
      techLevel = 48;
      initialSec = 3;
      initialInf = 3;
      initialInfection = 0;
      relationPirCiv = 0.2;
      relationPirUta = 0.5;
      relationCivUta = 0.25;
   };
   
   new ScriptObject(SG_SEC_3_UBERMINING : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector3_UberMining";      
      desiredLevel = 56;  //is it possible we would jump into prev circle?
       
      techFocus = "RANDOM";
      techLevel = 56;
      initialSec = 3;
      initialInf = 3;
      initialInfection = 0;
      relationPirCiv = 0.75;
      relationPirUta = 0.2;
      relationCivUta = 0.25;
   };  

   new ScriptObject(SG_SEC_3_UBERSCIENCE : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector3_UberScience";      
      desiredLevel = 64;  //is it possible we would jump into prev circle?
       
      techFocus = "RANDOM";
      techLevel = 64;
      initialSec = 3;
      initialInf = 3;
      initialInfection = 2;
      relationPirCiv = 0.75;
      relationPirUta = 0.2;
      relationCivUta = 0.25;
   };
   
   ///////////////////////////////////////////////
   // Sector 4 ///////////////////////////////////
   ///////////////////////////////////////////////
   
   //Star Replace Planets
   new ScriptObject(SG_SEC_3_4_Connect : StarReplace)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector3_4_Connect";      
      desiredLevel = 70; 
       
      techFocus = "Def";
      techLevel = 70;
      initialSec = 3;
      initialInf = 3;
      initialInfection = 2;
      relationPirCiv = 0.25;
      relationPirUta = 0.25;
      relationCivUta = 0.25;
   };
     
   //Insert New Planets
   new ScriptObject(SG_ZOMBIE_Homestar : StarAdd)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector4_ZombieHomestar";  
      connectionStar = "Sector3_4_ConnectSystem"; 
      offsetPercent = 0;
      offsetAngle = 0;
           
      techFocus = "Off";
      techLevel = 80;
      initialSec = 0;
      initialInf = 0;
      initialInfection = 3;
      relationPirCiv = 1;
      relationPirUta = 1;
      relationCivUta = 1;
   };
   
   new ScriptObject(SG_ZOMBIE_BossFightStar : StarAdd)  //need names for linking to others since starType maaaay be the same. 
   {
      starType = "Sector4_ZombieBossFightStar";  
      connectionStar = ""; //This is a non linked star. Warped to trhu alien gate automagically. 
      offsetPercent = 100; //faar
      offsetAngle = 0;
           
      techFocus = "Off";
      techLevel = 100;
      initialSec = 0;
      initialInf = 0;
      initialInfection = 3;
      relationPirCiv = 1;
      relationPirUta = 1;
      relationCivUta = 1;
   };
};
























