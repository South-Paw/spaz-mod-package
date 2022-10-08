


datablock DroneDatablock(DroneBase) 
{
   imageMap_Default = "ship_fighterImageMap";  //RLB note, we need a civ drone/color
  
   explosionSound = "snd_smallExplosion";
   explosionDatablock = "SmallExplosion";
   explosionScale = "1";
   
   researchDatablock = "DroneResearch";
   
   isCloakedDrone = false;  //some drones are naturally cloaked when deployed. (advanced ones)
   cloakDisruptionTime = 2;
      
   engineImageMap = "effect_whiteLight_01ImageMap";
   engineSize = "32 32";
   
   maxSpeed = "600";   
   turnSpeed = "360";
   constantThrustForce = "3000";
           
   droneDamping = 0.66;
   
   defenseRadius = 800;
   droneDamageBoost = 1.0;
   
   collectionDatablock = "beamAbord";  
   collectionSound     = "snd_smallCargoPickup";
   collectionScale     = "1.0";
};


   

function DroneDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}

//fighter drone

datablock DroneDatablock(FighterDrone : DroneBase) 
{
   imageMap_Terran = "ship_fighterImageMap";
   imageMap_Pirate = "ship_fighter_pirateImageMap";
   imageMap_Civ = "ship_fighter_civImageMap"; 
   imageMap_Zombie = "ship_fighter_zomImageMap";
   imageMap_Bounty = "ship_fighter_bountyImageMap";
       
   size = "24 24";         
   CollisionPolyList = "0.000 -0.933 0.678 0.633 -0.648 0.624";
   
   //Link Point 1 = the engine links, the rest are for weapons. 
   LinkPoints = "0.000 0.800 0.000 -0.500";       
      
   weaponLinks = "2";
   
   weapons[2] = "MicroDoubleCannon -1"; //weapon datablock, num times can fire
     
    
   aggroLevel = 0.85;  //likleyhood of an attackrun
   
   maxHealth = 20;      
   
   maxSpeed = "450";   
   turnSpeed = "360";
   constantThrustForce = "3000";
};

datablock DroneDatablock(FighterDroneCloaked : FighterDrone) 
{   
   maxSpeed = FighterDrone.maxSpeed * 0.80;   
   turnSpeed = FighterDrone.turnSpeed * 0.80;   
   constantThrustForce = FighterDrone.constantThrustForce * 0.80;   
   
   isCloakedDrone = true;
};

//zapper drone

//will make these lasers turreted so like a mobile point defense. 
datablock DroneDatablock(ZapperDrone : DroneBase) 
{
   imageMap_Terran = "ship_zapperImageMap";
   imageMap_Pirate = "ship_zapper_pirateImageMap";
   imageMap_Civ = "ship_zapper_civImageMap"; 
   imageMap_Zombie = "ship_zapper_zomImageMap";
   imageMap_Bounty = "ship_zapper_bountyImageMap";
       
   size = "24 24";         
   CollisionPolyList = "0.000 -0.933 0.678 0.633 -0.648 0.624";
   LinkPoints = "0.000 0.800 0.000 0.250";  
   
   weaponLinks = "2";
   
   weapons[2] = "DRONE_MicroLaser -1";  
   
   aggroLevel = 0.4;  //likleyhood of an attackrun
   
   maxHealth = 15;      
      
   maxSpeed = FighterDrone.maxSpeed;   
   turnSpeed = FighterDrone.turnSpeed;   
   constantThrustForce = FighterDrone.constantThrustForce;   
};

datablock DroneDatablock(ZapperDroneCloaked : ZapperDrone) 
{
   maxSpeed = ZapperDrone.maxSpeed * 0.80;   
   turnSpeed = ZapperDrone.turnSpeed * 0.80;   
   constantThrustForce = ZapperDrone.constantThrustForce * 0.80;   
   
   isCloakedDrone = true;
};

//bomber drone

datablock DroneDatablock(BomberDrone : DroneBase) 
{
   imageMap_Terran = "ship_microBomberImageMap";
   imageMap_Pirate = "ship_microBomber_pirateImageMap";
   imageMap_Civ = "ship_microBomber_civImageMap"; 
   imageMap_Zombie = "ship_microBomber_zomImageMap";
   imageMap_Bounty = "ship_microBomber_bountyImageMap";       
       
   size = "24 24";         
   CollisionPolyList = "0.000 -0.933 0.678 0.633 -0.648 0.624";
   LinkPoints = "0.000 0.800 0.000 0.000";  
   
   weaponLinks = "2";
   
   weapons[2] = "MicroBomberCannon -1";  //only 2 bombs
  
   maxHealth = 30; 
   
   aggroLevel = 0.50;  //likleyhood of an attackrun
   
   maxSpeed = FighterDrone.maxSpeed * 0.750;   
   turnSpeed = FighterDrone.turnSpeed * 0.750;   
   constantThrustForce = FighterDrone.constantThrustForce * 0.750;   

};

datablock DroneDatablock(BomberDroneCloaked : BomberDrone) 
{
   maxSpeed = BomberDrone.maxSpeed * 0.80;   
   turnSpeed = BomberDrone.turnSpeed * 0.80;   
   constantThrustForce = BomberDrone.constantThrustForce * 0.80;   
   
   isCloakedDrone = true;
};



///////////////////////////////////////////////////////
// Zombie Drone ///////////////////////////////////////
///////////////////////////////////////////////////////

datablock DroneDatablock(ZombieDrone : DroneBase) 
{   
   imageMap_Zombie = "ship_zombie_droneImageMap";
    
   size = "24 24";         
   CollisionPolyList = "0.000 -0.933 0.678 0.633 -0.648 0.624";
   LinkPoints = "0.000 0.800 0.000 -0.500";  
   
   weaponLinks = "2";
   
   weapons[2] = "DRONE_MicroLaser -1";  //needs own gun if we keep em
   
   maxHealth = 5;      
   maxSpeed = "400";   
};

///////////////////////////////////////////////////////
// CIV DRONES
///////////////////////////////////////////////////////

//FOR STATIONS ONLY!
datablock DroneDatablock(CivDrone_01 : FighterDrone) 
{
   imageMap_Civ = "ship_civ_drone_01ImageMap";
   imageMap_Zombie = "ship_civ_drone_zomImageMap";
       
   size = "24 24";         
   CollisionPolyList = "0.000 -0.933 0.678 0.633 -0.648 0.624";
   LinkPoints = "0.000 0.800 0.000 0.000";  
   
   weaponLinks = "2";
   
   aggroLevel = 0.50;  //likleyhood of an attackrun
   weapons[2] = "MicroDoubleCannon -1"; 
  
   maxHealth = 20;      
   maxSpeed = "400";
};

datablock DroneDatablock(CivDrone_02 : CivDrone_01) 
{
   imageMap_Civ = "ship_civ_drone_02ImageMap";
   weapons[2] = "DRONE_MicroLaser -1";  
};

datablock DroneDatablock(CivDrone_03 : CivDrone_01) 
{
   imageMap_Civ = "ship_civ_drone_03ImageMap";
   weapons[2] = "MicroBomberCannon -1";  
};

///////////////////////////////////////////////////////
// Silly Debug Drone //////////////////////////////////
///////////////////////////////////////////////////////
/*
datablock DroneDatablock(UltraDrone : DroneBase) 
{
   imageMap_Terran = "ship_scoutImageMap";
   imageMap_Pirate = "ship_scout_pirateImageMap";
       
   size = "32 32";         
   CollisionPolyList = "0.000 -0.933 0.678 0.633 -0.648 0.624";
   
   engineSize = "48 48";
   
   //Link Point 1 = the engine links, the rest are for weapons. 
   LinkPoints = "0.000 0.800 -0.668 0.295 0.678 0.304 -0.412 -0.412 0.417 -0.422";       
      
   weaponLinks = "2 3 4 5";
   
   weapons[2] = "MicroBomberCannon 2"; 
   weapons[3] = "MicroBomberCannon 2"; 
   weapons[4] = "MicroDoubleCannon 20"; 
   weapons[5] = "MicroDoubleCannon 20"; 
   
   maxHealth = 10;      
   maxSpeed = "500";  
};
*/




