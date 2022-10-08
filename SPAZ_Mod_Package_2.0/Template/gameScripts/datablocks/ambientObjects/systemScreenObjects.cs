
//////////////////////////////////////
// SYSTEM SCREEN OBJECTS
//////////////////////////////////////

//base data

new AmbientObjectRootDatablock (AmbientObjectSystemScreenRoot : AmbientObjectRoot)
{
   //isRepeatable = true;
   randomizedScaleFactor = "1 1"; //no scaling here
};

//used data

new AmbientObjectRootDatablock (systemScreenObject_lightCloud : AmbientObjectSystemScreenRoot)
{   
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   }; 
};

new AmbientObjectRootDatablock (systemScreenObject_asteroids : AmbientObjectSystemScreenRoot)
{     
   new AmbientSubObjectDatablock (Asteroid02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_asteroid_cluster_01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = 2;      
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (systemScreenObject_junk : AmbientObjectSystemScreenRoot)
{    
   new AmbientSubObjectDatablock (Asteroid02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = 2;      
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   };
};

new AmbientObjectRootDatablock (systemScreenObject_infected : AmbientObjectSystemScreenRoot)
{    //ZombieEgg is a reserved word
   new AmbientSubObjectDatablock (AO_ZombieEgg : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_zombie_egg01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   }; 
};

new AmbientObjectRootDatablock (systemScreenObject_colony : AmbientObjectSystemScreenRoot)
{   
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "OrbitObject_civ_outpost_02ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   }; 
};

new AmbientObjectRootDatablock (systemScreenObject_mining : AmbientObjectSystemScreenRoot)
{  
   new AmbientSubObjectDatablock (AsteroidMassive : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_asteroid_huge_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 3.5;
      imageObstructionFactor = 1; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (systemScreenObject_science : AmbientObjectSystemScreenRoot)
{   
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   }; 
};

new AmbientObjectRootDatablock (systemScreenObject_pirate : AmbientObjectSystemScreenRoot)
{   
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "OrbitObject_pirate_outpost_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   }; 
};


new AmbientObjectRootDatablock (systemScreenObject_militay : AmbientObjectSystemScreenRoot)
{   
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "OrbitObject_terran_outpost_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   }; 
};

new AmbientObjectRootDatablock (systemScreenObject_mothership : AmbientObjectSystemScreenRoot)
{   
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (systemScreenObject_security : AmbientObjectSystemScreenRoot)
{   
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "OrbitObject_terran_outpost_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   }; 
};

new AmbientObjectRootDatablock (systemScreenObject_warpgate : AmbientObjectSystemScreenRoot)
{   
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "orbitObject_civ_warpgate_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4;
       
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   }; 
};


