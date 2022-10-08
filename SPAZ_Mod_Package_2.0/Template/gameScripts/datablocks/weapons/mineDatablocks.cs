//Mine Datablocks



datablock MineDatablock(MineBase) 
{
   explosionSound = "snd_smallExplosion";
   explosionDatablock = "SmallExplosion";
   explosionScale = "1.7";
   
   size = "32 32";   
   
   
   researchDatablock = "MineResearch";
   
   CollisionPolyList = "-0.342 -0.417 0.392 -0.408 0.234 0.363 -0.419 0.280";
   LinkPoints = "0.000 0.000";   
   damageType = "Explosive";  
   
   maxHealth           = "1";   
   detectionRadius     = "1000";
   alarmRadius         = "750";
   movementSpeed       = "350";  //how fast we move to home position
   seekingSpeed        = "200";  //how fast we chase.
   cloakDisruptionTime = "2";
   damageStrength = "50";
   alarmTime = 2;
   explodeTime = 1;
   
   weapon = "";
};

//GREEN MISSILE

function MineDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}



//goot fos civ mines.  just sit there. 
datablock MineDatablock(CivMine : MineBase) 
{
   imageMap_Default = "mine_basicImageMap";
   imageMap_Pirate = "mine_basicImageMap";   
   
   damageType = "Universal";
   seekingSpeed = 300;  
   alarmTime = 2;      
   damageStrength = "5";   
   
   maxHealth = 2; //not very strong
};

datablock MineDatablock(BasicMine : MineBase) 
{
   imageMap_Default = "mine_basicImageMap";
   imageMap_Pirate = "mine_basicImageMap";   
   
   damageType = "Universal";
   seekingSpeed = 400;
   alarmTime = 2;  //how long it decides to go suicide mode or break off attack
   damageStrength = "7";
   
   maxHealth = 3; //slightly stronger than civ
};

datablock MineDatablock(IonMine : MineBase) 
{
   //Needs an image
   imageMap_Default = "mine_empImageMap";
   imageMap_Pirate = "mine_empImageMap";   
   
   damageType = "Ion";  
   seekingSpeed = 400;
   alarmTime = 2;  //how long it decides to go suicide mode or break off attack
   damageStrength = "12";
   
   maxHealth = 3; //slightly stronger than civ
};

datablock MineDatablock(MicroLaserMine : MineBase) 
{
   //Needs an image
   imageMap_Default = "mine_laserImageMap";
   imageMap_Pirate = "mine_laserImageMap";   
   
   //detection radius, and alatm radius tied to gun range.  TODO
   weapon = "MINE_MicroLaser";
 
   damageType = "Universal";
   seekingSpeed = 300;    
   alarmTime = 2; //alarm never expires so it will not pop. 
   damageStrength = "12";  //does not explode when run over, instead chases.
      
   maxHealth = 5;  //is a little tougher sinze it is a micro fort.
};

datablock MineDatablock(ScannerMine : MineBase) 
{
   //Needs an image
   imageMap_Default = "mine_scanImageMap";
   imageMap_Pirate = "mine_scanImageMap";   
   
   //detection radius, and alatm radius tied to gun range.  TODO
   weapon = "MINE_ScannerEmitter";
 
   damageType = "Universal";  //is ion damage since it is high tech.
   seekingSpeed = 400;    
   alarmTime = 2; 
   damageStrength = "12"; //do not run this over.  
   
   maxHealth = 5;  //not quite as beefy as the micro laser
};



