
//////////////////////////////////////////////////////////////////////////////////////////////////
// Debris Art Definitions ////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////
//Associate a piece of art with a set of embers

function AddArtToDebrisSet(%setID, %debrisArt)
{
   %set = $DebrisSets[%setID];
   if ( %set $= "" )
   {
      %setName = "DAS_"@%setID; //so code can find it. 
      $DebrisSets[%setID] = new SimSet(%setName) {};
      %set = $DebrisSets[%setID];
   }
   
   %set.add(%debrisArt);  
}

function GetRandomDebrisArt(%setID)
{
   %set = $DebrisSets[%setID];
   %randomIndex = getRandom(0, %set.getCount() - 1);
   return %set.getObject(%randomIndex);
}

function DebrisArt::OnAdd(%this)
{
   if ( %this.imageMap $= "" )
      return;
      
   %index = 0;
   %currentSetID = %this.addToSet[%index];
   while ( %currentSetID !$= "" )
   {
      AddArtToDebrisSet(%currentSetID, %this);     
      
      %index++;
      %currentSetID = %this.addToSet[%index]; 
   }   
}

new DebrisArt(DebrisArtBase)
{
   imageMap = "";
   emberMap = "";
   addToSet[0] = "ALL";   //left in script.  it handles this better. 
};

//////////////////////
//Basic Metal Chunks /
//////////////////////
new DebrisArt(DebrisArtMetal : DebrisArtBase)
{
   addToSet[1] = "METAL";
};

new DebrisArt(DebrisArt_Metal_01 : DebrisArtMetal)
{
   imageMap = "ship_debris_01ImageMap";
   emberMap = "ship_debris_ember_01ImageMap";  
};

new DebrisArt(DebrisArt_Metal_02 : DebrisArtMetal)
{
   imageMap = "ship_debris_02ImageMap";
   emberMap = "ship_debris_ember_02ImageMap";  
};

new DebrisArt(DebrisArt_Metal_03 : DebrisArtMetal)
{
   imageMap = "ship_debris_03ImageMap";
   emberMap = "ship_debris_ember_03ImageMap";  
};

new DebrisArt(DebrisArt_Metal_04 : DebrisArtMetal)
{
   imageMap = "ship_debris_04ImageMap";
   emberMap = "ship_debris_ember_04ImageMap";  
};

new DebrisArt(DebrisArt_Metal_05 : DebrisArtMetal)
{
   imageMap = "ship_debris_05ImageMap";
   emberMap = "ship_debris_ember_05ImageMap";  
};

new DebrisArt(DebrisArt_Metal_06 : DebrisArtMetal)
{
   imageMap = "ship_debris_06ImageMap";
   emberMap = "ship_debris_ember_06ImageMap";  
};

//////////////////////
//Sparking Tech //////
//////////////////////

new DebrisArt(DebrisArtHumanProp : DebrisArtBase)
{
   addToSet[1] = "HUMAN_PROP";
   emberMap = "reactor_wispImageMap";
};

new DebrisArt(DebrisArtHumanProp_01 : DebrisArtHumanProp)
{
   imageMap = "ship_debris_prop_01ImageMap";
};

new DebrisArt(DebrisArtHumanProp_02 : DebrisArtHumanProp)
{
   imageMap = "ship_debris_prop_02ImageMap";
};

//doodads

new DebrisArt(DebrisArtHumanProp_03 : DebrisArtHumanProp)
{
   imageMap = "radarImageMap";
};

new DebrisArt(DebrisArtHumanProp_04 : DebrisArtHumanProp)
{
   imageMap = "terranRadarImageMap";
};

new DebrisArt(DebrisArtHumanProp_05 : DebrisArtHumanProp)
{
   imageMap = "terranAntennaImageMap";
};

new DebrisArt(DebrisArtHumanProp_06 : DebrisArtHumanProp)
{
   imageMap = "pirateAntennaImageMap";
};

new DebrisArt(DebrisArtHumanProp_07 : DebrisArtHumanProp)
{
   imageMap = "intenaImageMap";
};

//////////////////////
//Zombie Meat ////////
//////////////////////

new DebrisArt(DebrisArtZombieMeat : DebrisArtBase)
{
   addToSet[1] = "ZOMBIE";
   emberMap = "reactor_wispImageMap";
};

new DebrisArt(DebrisArt_Zombie_01 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_01ImageMap";
};

new DebrisArt(DebrisArt_Zombie_02 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_02ImageMap";
};

new DebrisArt(DebrisArt_Zombie_03 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_03ImageMap";
};

new DebrisArt(DebrisArt_Zombie_04 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_04ImageMap";
};

new DebrisArt(DebrisArt_Zombie_05 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_05ImageMap";
};

new DebrisArt(DebrisArt_Zombie_06 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_06ImageMap";
};

new DebrisArt(DebrisArt_Zombie_07 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_07ImageMap";
};

new DebrisArt(DebrisArt_Zombie_08 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_08ImageMap";
};

new DebrisArt(DebrisArt_Zombie_09 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_09ImageMap";
};

new DebrisArt(DebrisArt_Zombie_10 : DebrisArtZombieMeat)
{
   imageMap = "ship_debris_zombie_10ImageMap";
};

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Debris Units ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//These are members of debris clusters 
/*
function DebrisUnitDatablock::GetRandomDebrisArt(%this)
{
   %setID = %this.DebrisArtSet;
   return GetRandomDebrisArt(%setID);
}
*/


//A debris unit defines how a certain type of debris behavies and what image maps and effects to use for that debris.
new DebrisUnitDatablock(DebrisUnitBase)
{      

   minSize = "12 12";
   maxSize = "48 48";  //scale factor will determine where on the range we choose to size the debris
      
   DebrisArtSet = "";
   
   initialColor = "1 1 1 1";  //this color is set on the object as soon as it is created. Pulse will override.
   finalColor = "1 1 1 1";  //this is the color we will blend to
   blendRateRange = "0.01 0.03"; //how fast we transition from start color to end color we define a range here.
   
   
   //Pulse For Embers.  Also embers are always intense
   emberPulseData_shouldPulse   = false;  //Means we will draw the embers.  else we will not.
   emberPulseData_endTime       = 1.0;   //if a pulse is active, this is when we will begin to blend to end color.
   emberPulseData_pulseTime     = 1000;   
   emberPulseData_pulseBlendMin = "1 1 1 1";
   emberPulseData_pulseBlendMax = "0.5 0.5 0 0.5";
   emberPulseData_pulseLinear   = false; 
      
   //debrisEffects# = "StartTimeScale StopTimeScale EffectName OffestX OffsetY  EmissionRotation EmissionForce EffectScale MinMSTime MaxMSTime" if mintime and max time are 0 it will only play once.  good for constant effects like smoke 
   debrisEffects_0 = "";
   
   angularVelocityScale = 1; //bigger stuff should rotate slower
   impulseForceScale = "1 1.5"; //bigger stuff should get a smaller impulse force
};

////////////////////////////////
// Human ///////////////////////
////////////////////////////////


//This is a big important piece of debris
new DebrisUnitDatablock(DebrisChunk_Mother_Hot : DebrisUnitBase)
{
   sizeRange = "24 32";  //assuming debris are square. will be 24x - 32x (big)
   
   DebrisArtSet = "METAL";
      
   //Effects: name, startTime SPC 
   debrisEffects_0 = "0 0.66 hullFire 0 0 0 0 0.6 0 0";  //flame almost until embers cool
   debrisEffects_1 = "0.66 0.8 hullSmoke 0 0 0 0 0.5 0 0"; 
         
   emberPulseData_shouldPulse   = true;    //will use intense embers.
   emberPulseData_endTime       = 0.66;    //this is when embers fade to nothing
   emberPulseData_pulseTime     = "200 400";   //random pair
   emberPulseData_pulseBlendMin = "1 0 0 1";
   emberPulseData_pulseBlendMax = "1 1 0 1";   
   
   initialColor = "1 0.5 0.5 1";     
   finalColor = "1 1 1 1";    
   
   angularVelocityScale = 0.5;
   impulseForceScale = "0.75 1";
  
};

new DebrisUnitDatablock(DebrisChunk_Child_Hot : DebrisUnitBase)
{
   sizeRange = "16 24";  
     
   DebrisArtSet = "METAL";
   
   emberPulseData_shouldPulse   = true;    
   emberPulseData_endTime       = 0.5;    
   emberPulseData_pulseTime     = "100 200";   
   emberPulseData_pulseBlendMin = "1 0 0 1";
   emberPulseData_pulseBlendMax = "1 1 0 1";   
   
   debrisEffects_0 = "0 0.5 hullFire 0 0 0 0 0.3 0 0";
      
   initialColor = "1 0.5 0.5 1";     
   finalColor = "1 1 1 1";     
   
   angularVelocityScale = 1;
   impulseForceScale = "1 1.5";
};

new DebrisUnitDatablock(DebrisChunk_Tiny_Cold : DebrisUnitBase)
{
   sizeRange = "12 16";  
   
   DebrisArtSet = "METAL";         
   
   angularVelocityScale = 1.5;
   impulseForceScale = "1.5 2";
};

new DebrisUnitDatablock(DebrisChunk_Shooters : DebrisUnitBase)
{
   sizeRange = "8 12";  
   
   DebrisArtSet = "METAL";
   
   emberPulseData_shouldPulse   = true;    
   emberPulseData_endTime       = 0.5;    
   emberPulseData_pulseTime     = "100 200";   
   emberPulseData_pulseBlendMin = "1 0 0 1";
   emberPulseData_pulseBlendMax = "1 1 0 1";   
   
   initialColor = "1 0.5 0.5 1";       
   finalColor = "1 1 1 1";       
   
   angularVelocityScale = 0;
   impulseForceScale = "2 3";
};

new DebrisUnitDatablock(DebrisChunk_Spinner : DebrisUnitBase)
{
   sizeRange = "32 48";  
   
   DebrisArtSet = "METAL";
   
   debrisEffects_0 = "0 1 hullFire 0 0 0 0 0.8 0 0";
   
   emberPulseData_shouldPulse   = true;    
   emberPulseData_endTime       = 0.5;    
   emberPulseData_pulseTime     = "100 200";   
   emberPulseData_pulseBlendMin = "1 0 0 1";
   emberPulseData_pulseBlendMax = "1 1 0 1";   
   
   initialColor = "1 0.5 0.5 1";       
   finalColor = "1 1 1 1";       
   
   angularVelocityScale = 10;
   impulseForceScale = "1 2";
};

new DebrisUnitDatablock(DebrisChunk_Spinner_Tiny : DebrisChunk_Spinner)
{
   sizeRange = "16 24";  
};

new DebrisUnitDatablock(DebrisChunk_HumanProp : DebrisUnitBase)
{
   sizeRange = "12 16";  
   
   DebrisArtSet = "HUMAN_PROP";
   
   debrisEffects_0 = "0 0.66 hullElecPuff 0 0 0 0 0.4 1000 2000";
   
   emberPulseData_shouldPulse   = true;    
   emberPulseData_endTime       = 0.2;    
   emberPulseData_pulseTime     = "100 200";   
   emberPulseData_pulseBlendMin = "1 0 0 0.5";
   emberPulseData_pulseBlendMax = "1 1 0 0.3";   
   
   initialColor = "1 1 1 1";       
   finalColor = "1 1 1 1";       
   
   angularVelocityScale = 0;
   impulseForceScale = "2 3";
};

////////////////////////////////
// Zombie //////////////////////
////////////////////////////////

new DebrisUnitDatablock(DebrisChunk_Zombie_MeatBall : DebrisUnitBase)
{
   sizeRange = "24 32";  
     
   DebrisArtSet = "ZOMBIE";
   
   emberPulseData_shouldPulse   = true;    
   emberPulseData_endTime       = 0.2;  
   emberPulseData_pulseTime     = "300 500";   
   emberPulseData_pulseBlendMin = "1 0 0 0.5";
   emberPulseData_pulseBlendMax = "1 0 0 1";   
   
   debrisEffects_0 = "0 0.66 bloodPuff 0 0 0 0 0.3 2000 3000";
      
   initialColor = "1 1 1 1";        
   
   angularVelocityScale = 1;
   impulseForceScale = "0.75 1";
};


new DebrisUnitDatablock(DebrisChunk_Zombie_Bleeder : DebrisUnitBase)
{
   sizeRange = "16 24";  
     
   DebrisArtSet = "ZOMBIE";
   
   emberPulseData_shouldPulse   = true;    
   emberPulseData_endTime       = 0.2;  
   emberPulseData_pulseTime     = "100 200";   
   emberPulseData_pulseBlendMin = "1 0 0 0.5";
   emberPulseData_pulseBlendMax = "1 0 0 1";   
   
   debrisEffects_0 = "0 0.66 bloodPuff 0 0 0 0 0.3 400 800";
      
   initialColor = "1 1 1 1";        
   
   angularVelocityScale = 1;
   impulseForceScale = "1 1.5";
};


new DebrisUnitDatablock(DebrisChunk_Shooters_Zombie : DebrisUnitBase)
{
   sizeRange = "8 12";  
   
   DebrisArtSet = "ZOMBIE";
   
   emberPulseData_shouldPulse   = true;    
   emberPulseData_endTime       = 0.2;    
   emberPulseData_pulseTime     = "100 200";   
   emberPulseData_pulseBlendMin = "1 0 0 0.5";
   emberPulseData_pulseBlendMax = "1 0 0 1";     
   
   initialColor = "1 0.5 0.5 1";       
   finalColor = "1 1 1 1";       
   
   angularVelocityScale = 0;
   impulseForceScale = "2 3";
};


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Debris Cluster ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//These define the debris that we spawn.  this is the template of a debris puff

$DebrisClusterSet = new SimSet() {};
function DebrisClusterDatablock::OnAdd(%this)
{
   if ( %this.getName() $= "DebrisClusterBase" )
      return;
   
   $DebrisClusterSet.add(%this);
}


new DebrisClusterDatablock(DebrisClusterBase)
{   
   clusterLifetime = 10000; //there is some built in variance   
};

////////////////////////////////////////////////////////////////////////////////
// Combat Debris 
////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////
// HUMAN PARTS
////////////////////////////////////////////////////////////////////////////////

new DebrisClusterSubGroup(ShooterChunk)
{
   creationChance = 1;
   offsetDistance = 5;  //picks a point randomly 360degrees between 0 - this distance.  favoring outside     
   offsetAngle = 10;  //how much to spray from given ejection angle +/- this angle
   unitList = "DebrisChunk_Shooters";
   maxToSpawn = 4;
   lifeTimeFactor = "0.5 1";  //how long is my life compared to life of the cluster            
}; 

new DebrisClusterSubGroup(HumanPropChunk)
{
   creationChance = 0.8;
   offsetDistance = 5;  //picks a point randomly 360degrees between 0 - this distance.  favoring outside     
   offsetAngle = 10;  //how much to spray from given ejection angle +/- this angle
   unitList = "DebrisChunk_HumanProp";
   maxToSpawn = 1;
   lifeTimeFactor = "0.5 1";  //how long is my life compared to life of the cluster            
}; 

new DebrisClusterSubGroup(SpinnerChunk)
{
   creationChance = 0.2;
   offsetDistance = 5;  //picks a point randomly 360degrees between 0 - this distance.  favoring outside     
   offsetAngle = 10;  //how much to spray from given ejection angle +/- this angle
   unitList = "DebrisChunk_Spinner";
   maxToSpawn = 1;
   lifeTimeFactor = "0.7 1";  //how long is my life compared to life of the cluster            
};

new DebrisClusterSubGroup(SpinnerChunk_Tiny : SpinnerChunk)
{
   unitList = "DebrisChunk_Spinner_Tiny";         
};

new DebrisClusterSubGroup(MainDebrisChunk)
{
   creationChance = 1;   //rolled for each child
   offsetDistance = 5;  //picks a point randomly 360degrees between 0 - this distance.  favoring outside     
   offsetAngle = 10;  //how much to spray from given ejection angle +/- this angle
   unitList = "DebrisChunk_Child_Hot";
   maxToSpawn = 2;
   lifeTimeFactor = "0.7 1";  //how long is my life compared to life of the cluster
};

new DebrisClusterSubGroup(TinySubChunk)
{
   creationChance = 1;   //rolled for each child
   offsetDistance = 5;    //picks a point randomly 360degrees between 0 - this distance.  favoring outside     
   offsetAngle = 5;  //how much to spray from given ejection angle +/- this angle
   unitList = "DebrisChunk_Tiny_Cold";
   maxToSpawn = 3;
   lifeTimeFactor = "0.5 1";  //how long is my life compared to life of the cluster            
};

////////////////////////////////////////////////////////////////////////////////
//ZOMBIE PARTS
////////////////////////////////////////////////////////////////////////////////

new DebrisClusterSubGroup(ZombieShooterChunk)
{
   creationChance = 1;
   offsetDistance = 5;  //picks a point randomly 360degrees between 0 - this distance.  favoring outside     
   offsetAngle = 10;  //how much to spray from given ejection angle +/- this angle
   unitList = "DebrisChunk_Shooters_Zombie";
   maxToSpawn = 3;
   lifeTimeFactor = "0.75 1";  //how long is my life compared to life of the cluster            
}; 

new DebrisClusterSubGroup(ZombieMainDebrisChunk)
{
   creationChance = 1;   //rolled for each child
   offsetDistance = 5;  //picks a point randomly 360degrees between 0 - this distance.  favoring outside     
   offsetAngle = 10;  //how much to spray from given ejection angle +/- this angle
   unitList = "DebrisChunk_Zombie_MeatBall";
   maxToSpawn = 1;
   lifeTimeFactor = "0.75 1";  //how long is my life compared to life of the cluster         
}; 

new DebrisClusterSubGroup(ZombieSubChunk)
{
   creationChance = 0.8;   //rolled for each child
   offsetDistance = 5;    //picks a point randomly 360degrees between 0 - this distance.  favoring outside     
   offsetAngle = 10;  //how much to spray from given ejection angle +/- this angle
   unitList = "DebrisChunk_Zombie_Bleeder";
   maxToSpawn = 2;
   lifeTimeFactor = "0.75 1";  //how long is my life compared to life of the cluster            
};

////////////////////////////////////////////////////////////////////////////////
// HUMAN DATA
////////////////////////////////////////////////////////////////////////////////

//LIGHT

new DebrisClusterDatablock(DC_Combat_Small_Light : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(Shooter : ShooterChunk)
   {
      maxToSpawn = 1;      
   }; 
   new DebrisClusterSubGroup(SmallChunk : TinySubChunk)
   {
      maxToSpawn = 2;      
   };      
};

new DebrisClusterDatablock(DC_Combat_Large_Light : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(Shooter : ShooterChunk)
   {
      maxToSpawn = 2;      
   }; 
   new DebrisClusterSubGroup(SmallChunk : TinySubChunk)
   {
      maxToSpawn = 2;      
   };    
};

new DebrisClusterDatablock(DC_Combat_Huge_Light : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(Shooter : ShooterChunk)
   {
      maxToSpawn = 4;      
   }; 
   new DebrisClusterSubGroup(SmallChunk : TinySubChunk)
   {
      maxToSpawn = 2;      
   };    
};

//HEAVY

new DebrisClusterDatablock(DC_Combat_Small_Heavy : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(MainDebris : MainDebrisChunk)
   {
      maxToSpawn = 1;       
      new DebrisClusterSubGroup(SubPart : TinySubChunk)
      {
         maxToSpawn = 1;       
      };
   };
   new DebrisClusterSubGroup(Shooter : ShooterChunk)
   {
      maxToSpawn = 1;      
   }; 
   new DebrisClusterSubGroup(Prop : HumanPropChunk)
   {
      maxToSpawn = 1;         
   };  
   new DebrisClusterSubGroup(Spinner : SpinnerChunk_Tiny)
   {
      maxToSpawn = 1;          
   };
   new DebrisClusterSubGroup(SmallChunk : TinySubChunk)
   {
      maxToSpawn = 1;      
   };      
};

new DebrisClusterDatablock(DC_Combat_Large_Heavy : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(MainDebris : MainDebrisChunk)
   {
      maxToSpawn = 1;       
      new DebrisClusterSubGroup(SubPart : TinySubChunk)
      {
         maxToSpawn = 2;       
      };
   };
   new DebrisClusterSubGroup(Shooter : ShooterChunk)
   {
      maxToSpawn = 3;      
   }; 
   new DebrisClusterSubGroup(Prop : HumanPropChunk)
   {
      maxToSpawn = 2;         
   };  
   new DebrisClusterSubGroup(Spinner : SpinnerChunk)
   {
      maxToSpawn = 1;          
   };
   new DebrisClusterSubGroup(SmallChunk : TinySubChunk)
   {
      maxToSpawn = 1;      
   };     
};

new DebrisClusterDatablock(DC_Combat_Huge_Heavy : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(MainDebris : MainDebrisChunk)
   {
      maxToSpawn = 1;       
      new DebrisClusterSubGroup(SubPart : TinySubChunk)
      {
         maxToSpawn = 3;       
      };
   };
   new DebrisClusterSubGroup(Shooter : ShooterChunk)
   {
      maxToSpawn = 4;      
   }; 
   new DebrisClusterSubGroup(Prop : HumanPropChunk)
   {
      maxToSpawn = 3;         
   };  
   new DebrisClusterSubGroup(Spinner : SpinnerChunk)
   {
      maxToSpawn = 2;          
   }; 
   new DebrisClusterSubGroup(SmallChunk : TinySubChunk)
   {
      maxToSpawn = 1;      
   };    
};

////////////////////////////////////////////////////////////////////////////////
//ZOMBIE DATA
////////////////////////////////////////////////////////////////////////////////

//LIGHT

new DebrisClusterDatablock(DC_Combat_Small_Light_Zombie : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(Shooters : ZombieShooterChunk)
   {
      maxToSpawn = 1;         
   };   
};

new DebrisClusterDatablock(DC_Combat_Large_Light_Zombie : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(Shooters : ZombieShooterChunk)
   {
      maxToSpawn = 2;         
   };   
};

new DebrisClusterDatablock(DC_Combat_Huge_Light_Zombie : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(Shooters : ZombieShooterChunk)
   {
      maxToSpawn = 3;         
   };   
};

//HEAVY

new DebrisClusterDatablock(DC_Combat_Small_Heavy_Zombie : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(MainDebris : ZombieMainDebrisChunk)
   {
      maxToSpawn = 1;     
      new DebrisClusterSubGroup(TinySubParticles : ZombieSubChunk)
      {
         maxToSpawn = 1;         
      };
   };
   new DebrisClusterSubGroup(Shooters : ZombieShooterChunk)
   {
      maxToSpawn = 2;         
   };  
};

new DebrisClusterDatablock(DC_Combat_Large_Heavy_Zombie : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(MainDebris : ZombieMainDebrisChunk)
   {
      maxToSpawn = 1;     
      new DebrisClusterSubGroup(TinySubParticles : ZombieSubChunk)
      {
         maxToSpawn = 2;         
      };
   };
   new DebrisClusterSubGroup(Shooters : ZombieShooterChunk)
   {
      maxToSpawn = 3;         
   };  
};

new DebrisClusterDatablock(DC_Combat_Huge_Heavy_Zombie : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(MainDebris : ZombieMainDebrisChunk)
   {
      maxToSpawn = 1;     
      new DebrisClusterSubGroup(TinySubParticles : ZombieSubChunk)
      {
         maxToSpawn = 2;         
      };
   };
   new DebrisClusterSubGroup(Shooters : ZombieShooterChunk)
   {
      maxToSpawn = 4;         
   };  
};

///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Breach Debris //////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////

new DebrisClusterDatablock(DC_HullBreach_Small : DebrisClusterBase)
{   
   new DebrisClusterSubGroup(MainDebris : MainDebrisChunk)
   {
      maxToSpawn = 1;
      unitList = "DebrisChunk_Mother_Hot";       
      new DebrisClusterSubGroup(SubPart : TinySubChunk)
      {
         maxToSpawn = 2;       
      };
   };
   
   new DebrisClusterSubGroup(Shooter : ShooterChunk)
   {
      maxToSpawn = 2;      
   }; 
   new DebrisClusterSubGroup(Prop : HumanPropChunk)
   {
      maxToSpawn = 1;         
   };     
};

/////////////////////////////////////////
// Mass Driver Debris ///////////////////
/////////////////////////////////////////

new DebrisClusterDatablock(DC_MassDriver_Small : DebrisClusterBase)
{      
   new DebrisClusterSubGroup(Shooter : ShooterChunk)
   {
      maxToSpawn = 1;      
   }; 
};



















