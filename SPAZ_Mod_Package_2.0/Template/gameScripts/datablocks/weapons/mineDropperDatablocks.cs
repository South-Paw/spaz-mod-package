//Mine Dropper Datablocks

datablock MineDropperDatablock(MineDropperBase) 
{
   explosionSound = "snd_smallExplosion";
   explosionDatablock = "BigExplosion";
   explosionScale = "1";
   
   launchSound = "snd_smallMissileLaunch";
   
   researchDatablock = "MineResearch";
   
   //Research Stuff
   mineDelpoyTime = 1;  //2 seconds
   maxHealth = "150"; //note they die fast because of point def's massive damage
   minePingTime = 2;
   cloakDisruptionTime = 2;
   
   size = "48 48";         
   CollisionPolyList = "-0.342 -0.417 0.392 -0.408 0.234 0.363 -0.419 0.280";
   LinkPoints = "0.000 0.000";
   damageType = "Explosive";  
   
   imageMap_Default = "mine_dropper_basicImageMap";
   imageMap_Pirate = "mine_dropper_basicImageMap";
   
   canReplaceMines = true;  //all minefields can replace now.  (less janitorial work) 
   
   randomMineSwarm = false; //for now, no swarm fields. it is annoying to player, doesnt hurt ai
   randomMineSwarmPings = 2;  //only used if swarming
};

function MineDropperDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}

////////////////////////////////////////////////////////////////
// Smalls //////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////


datablock MineDropperDatablock(Dropper_Small_Explosive : MineDropperBase) 
{  
   minePingTime = 4;  
   
   patternMinesInitial = 0;
   patternMineAmmo = "BasicMine";  //can be multiple types
   patternScale = 1400; //works like a radius for the pattern to deploy within
   
   //outter ring
   patternElement0   = "1 0";
   patternElement1   = "-1 0";
   patternElement2   = "0 1";
   patternElement3   = "0 -1";
   
   patternElement4   = "0.707 0.707";
   patternElement5   = "-0.707 0.707";
   patternElement6   = "-0.707 -0.707";
   patternElement7   = "0.707 -0.707";    
    
   //inner Ring
   patternElement8   = "0.5 0";
   patternElement9   = "-0.5 0";
   patternElement10   = "0 0.5";
   patternElement11   = "0 -0.5";
   
   patternElement12   = "0.25 0.433";
   patternElement13   = "-0.25 0.433";
   patternElement14   = "0.25 -0.433";
   patternElement15   = "-0.25 -0.433";
   
   patternElement16  = "0.433 0.25";
   patternElement17  = "-0.433 0.25";
   patternElement18  = "0.433 -0.25";
   patternElement19  = "-0.433 -0.25";     
};

datablock MineDropperDatablock(Dropper_Small_Civ : Dropper_Small_Explosive) 
{
   patternMineAmmo = "CivMine"; 
};

datablock MineDropperDatablock(Dropper_Small_Ion : Dropper_Small_Explosive) 
{
   imageMap_Default = "mine_dropper_empImageMap";
   imageMap_Pirate = "mine_dropper_empImageMap";
   patternMineAmmo = "IonMine"; 
};

datablock MineDropperDatablock(Dropper_Small_MicroLaser : Dropper_Small_Explosive) 
{   
   imageMap_Default = "mine_dropper_laserImageMap";
   imageMap_Pirate = "mine_dropper_laserImageMap";  
   patternMineAmmo = "MicroLaserMine"; 
};

datablock MineDropperDatablock(Dropper_Small_Scanner : Dropper_Small_Explosive) 
{
   imageMap_Default = "mine_dropper_scanImageMap";
   imageMap_Pirate = "mine_dropper_scanImageMap";  
   patternMineAmmo = "ScannerMine"; 
};

datablock MineDropperDatablock(Dropper_Small_Random : Dropper_Small_Explosive) 
{
   patternMineAmmo = "ScannerMine MicroLaserMine IonMine BasicMine"; 
};

////////////////////////////////////////////////////////////////
// Larges //////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////


datablock MineDropperDatablock(Dropper_Large_Explosive : MineDropperBase) 
{  
   minePingTime = 4;
   
   size = "72 72";
   
   patternMinesInitial = 0;
   patternMineAmmo = "BasicMine";  //can be multiple types
   patternScale = 1900; //works like a radius for the pattern to deploy within
   
   //outter ring
   patternElement0   = "1 0";
   patternElement1   = "-1 0";
   patternElement2   = "0 1";
   patternElement3   = "0 -1";
   
   patternElement4   = "0.707 0.707";
   patternElement5   = "-0.707 0.707";
   patternElement6   = "-0.707 -0.707";
   patternElement7   = "0.707 -0.707";    
    
   //inner Ring
   patternElement8   = "0.5 0";
   patternElement9   = "-0.5 0";
   patternElement10   = "0 0.5";
   patternElement11   = "0 -0.5";
   
   patternElement12   = "0.25 0.433";
   patternElement13   = "-0.25 0.433";
   patternElement14   = "0.25 -0.433";
   patternElement15   = "-0.25 -0.433";
   
   patternElement16  = "0.433 0.25";
   patternElement17  = "-0.433 0.25";
   patternElement18  = "0.433 -0.25";
   patternElement19  = "-0.433 -0.25";     
   
   //Now we need a secondary pattern to interleve
   //best way to do this is to add a swarmfield to it. 
   //but swarmfields are a little mean, so lets just drop a random distribution   
   randomMineAmmo = "BasicMine";   
   randomMinesMax = 20;
   randomMinesRadius = 2500;
   randomMinesInitial = 0;
   
   
};

datablock MineDropperDatablock(Dropper_Large_Civ : Dropper_Large_Explosive) 
{
   randomMineAmmo  = "CivMine";   
   patternMineAmmo = "CivMine"; 
};

datablock MineDropperDatablock(Dropper_Large_Ion : Dropper_Large_Explosive) 
{
   imageMap_Default = "mine_dropper_empImageMap";
   imageMap_Pirate = "mine_dropper_empImageMap";
   randomMineAmmo  = "IonMine";   
   patternMineAmmo = "IonMine"; 
};

datablock MineDropperDatablock(Dropper_Large_MicroLaser : Dropper_Large_Explosive) 
{   
   imageMap_Default = "mine_dropper_laserImageMap";
   imageMap_Pirate = "mine_dropper_laserImageMap";  
   randomMineAmmo  = "MicroLaserMine";  //could make some ion and blast too?
   patternMineAmmo = "MicroLaserMine"; 
};

datablock MineDropperDatablock(Dropper_Large_Scanner : Dropper_Large_Explosive) 
{   
   imageMap_Default = "mine_dropper_scanImageMap";
   imageMap_Pirate = "mine_dropper_scanImageMap";  
   randomMineAmmo  = "ScannerMine"; 
   patternMineAmmo = "ScannerMine"; 
};

datablock MineDropperDatablock(Dropper_Large_Random : Dropper_Large_Explosive) 
{
   randomMineAmmo  = "ScannerMine MicroLaserMine IonMine BasicMine"; 
   patternMineAmmo = "ScannerMine MicroLaserMine IonMine BasicMine"; 
};


///////////////////////////////////////////////
// Reference Fields ///////////////////////////
///////////////////////////////////////////////
//Lotsa of good functionality here.  

/*

datablock MineDropperDatablock(Dropper_BurstMinefield_Small : MineDropperBase) 
{         
 
   
   //Random Mines Stuff
   randomMinesMax = 10;
   randomMinesRadius = 800;
   randomMinesInitial = 10;
   randomMineAmmo = "BasicMine";   
};


datablock MineDropperDatablock(Dropper_BurstMinefield_Large : MineDropperBase) 
{         
   canReplaceMines = false; 
   
   //Random Mines Stuff
   randomMinesMax = 30;
   randomMinesRadius = 1500;
   randomMinesInitial = 30;
   randomMineAmmo = "BasicMine BasicMine BasicMine";   
};



datablock MineDropperDatablock(Dropper_SwarmMinefield_Small : MineDropperBase) 
{      
   canReplaceMines = false; 
     
   
   //Random Mines Stuff
   randomMinesMax = 10;
   randomMinesRadius = 1800;
   randomMinesInitial = 10;
   randomMineAmmo = "BasicMine BasicMine BasicMine";
   
   randomMineSwarm = true;
   randomMineSwarmPings = 2;  //only used if swarming
   
};


datablock MineDropperDatablock(Dropper_SwarmMinefield_Large : MineDropperBase) 
{      
   canReplaceMines = false; 
     
   
   //Random Mines Stuff
   randomMinesMax = 30;
   randomMinesRadius = 1800;
   randomMinesInitial = 30;
   randomMineAmmo = "BasicMine BasicMine BasicMine";
   
   randomMineSwarm = true;
   randomMineSwarmPings = 2;  //only used if swarming
   
};


datablock MineDropperDatablock(Dropper_LineRegenerator : MineDropperBase) 
{   
   canReplaceMines = true; 
      
   //PATTERN MINE STUFF
   //pattern broken up this way to provide optimal coverage in the order the minefield deploys
   //mainly to look cool    
   
   patternMinesInitial = 1;
   patternMineAmmo = "BasicMine";  //can be multiple types
   patternScale = 3000; //works like a radius for the pattern to deploy within
   
   //outter ring
   patternElement0   = "0 0";
   
   //first line
   patternElement1   = "0.2 0";
   patternElement2   = "-0.2 0";
   patternElement3   = "0.4 0";
   patternElement4   = "-0.4 0";
   patternElement5   = "0.6 0";
   patternElement6   = "-0.6 0";
   patternElement7   = "0.8 0";
   patternElement8   = "-0.8 0";
   patternElement9   = "1 0";
   patternElement10  = "-1 0";
   
   patternElement11   = "0 0.2";
   patternElement12  = "0.2 0.2";
   patternElement13  = "-0.2 0.2";
   patternElement14  = "0.4 0.2";
   patternElement15  = "-0.4 0.2";
   patternElement16  = "0.6 0.2";
   patternElement17  = "-0.6 0.2";
   patternElement18  = "0.8 0.2";
   patternElement19  = "-0.8 0.2";
   patternElement20  = "1 0.2";
   patternElement21  = "-1 0.2";
   
   patternElement22  = "0 -0.2";
   patternElement23  = "0.2 -0.2";
   patternElement24  = "-0.2 -0.2";
   patternElement25  = "0.4 -0.2";
   patternElement26  = "-0.4 -0.2";
   patternElement27  = "0.6 -0.2";
   patternElement28  = "-0.6 -0.2";
   patternElement29  = "0.8 -0.2";
   patternElement30  = "-0.8 -0.2";
   patternElement31  = "1 -0.2";
   patternElement32  = "-1 -0.2";
};



datablock MineDropperDatablock(Dropper_SwarmRegenerator : MineDropperBase) 
{      
   canReplaceMines = true; 
     
   
   //Random Mines Stuff
   randomMinesMax = 30;
   randomMinesRadius = 2000;
   randomMinesInitial = 30;
   randomMineAmmo = "BasicMine BasicMine BasicMine";
   
   randomMineSwarm = true;
   randomMineSwarmPings = 2;  //only used if swarming
   
};

*/

