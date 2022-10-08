


datablock DroneHiveDatablock(DroneHiveBase) 
{
   explosionSound = "snd_smallExplosion";
   explosionDatablock = "BigExplosion";
   explosionScale = "0.5";
   
   launchSound = "snd_smallMissileLaunch";
   
   researchDatablock = "DroneResearch";
   
   size = "32 32";         
   CollisionPolyList = "-0.236 -0.683 0.172 -0.688 0.746 -0.118 0.300 0.815 -0.275 0.815 -0.786 -0.079";
   LinkPoints = "0.000 0.000";
         
   imageMap_Default  = "ship_droneLauncher_pirateImageMap"; //generic
   imageMap_Pirate = "ship_droneLauncher_pirateImageMap"; 
   imageMap_Zombie = "ship_zombie_droneLauncherImageMap"; 

   maxHealth = 20; //doesnt really matter since we dont drop them anymore
   
   dronesMax = 3;
   
   isCloakedHive = false;  //some hives are naturally cloaked when deployed. (advanced ones)
   cloakDisruptionTime = 4;
   droneConstructTime = 5;  //5 seconds.
   droneLaunchTime = 1;  //1 second
   hiveCanSelfConstruct = false;  // usually a hive needs to be mounted to a ship to construct drones
    
};



function DroneHiveDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}

//fighter

datablock DroneHiveDatablock(DroneHive_Fighter : DroneHiveBase) 
{         
   dronesMax = 10;  
   droneAmmo = "FighterDrone";   
   
};

datablock DroneHiveDatablock(DroneHive_Fighter_Cloaked : DroneHiveBase) 
{    
   dronesMax = 10;  
   droneAmmo = "FighterDroneCloaked";       
   isCloakedHive = true;  
};

//zapper

datablock DroneHiveDatablock(DroneHive_Zapper : DroneHiveBase) 
{    
   dronesMax = 8;  
   droneAmmo = "ZapperDrone";   
   
};

datablock DroneHiveDatablock(DroneHive_Zapper_Cloaked : DroneHiveBase) 
{       
   dronesMax = 8;  
   droneAmmo = "ZapperDroneCloaked";  
   isCloakedHive = true;
};

//bomber

datablock DroneHiveDatablock(DroneHive_Bomber : DroneHiveBase) 
{           
   dronesMax = 7;  
   droneAmmo = "BomberDrone";     
};

datablock DroneHiveDatablock(DroneHive_Bomber_Cloaked : DroneHiveBase) 
{        
   dronesMax = 7;   
   droneAmmo = "BomberDroneCloaked";   
   isCloakedHive = true;
};

//////////////////////////////////////
// CIV ///////////////////////////////
//////////////////////////////////////

datablock DroneHiveDatablock(DroneHive_Civ : DroneHiveBase) 
{         
   dronesMax = 10;  
   droneAmmo = "CivDrone_01 CivDrone_02 CivDrone_03";   
   
};


//////////////////////////////////////
// Zombie ////////////////////////////
//////////////////////////////////////


datablock DroneHiveDatablock(DroneHive_Zombie : DroneHiveBase) 
{            
   dronesMax = 5;  
   droneAmmo = "ZombieDrone";   //may want multiple types of these. 
   
};
















