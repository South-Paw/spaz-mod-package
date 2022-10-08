
/////////////////////////////////////////////////////////////////////////////////////////////////////
// Asteroids /////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////
$AmbientObjectDeck_NearObjects = CreateAmbientObjectDeck();
SetCodeVal_AOD_NearObjects($AmbientObjectDeck_NearObjects);

$AmbientObjectDeck_Asteroids = CreateAmbientObjectDeck();
function AmbientObjectAsteroidDatablock::OnAdd(%this)
{   
   if ( %this.getId() == AmbientObjectRoot_Asteroid.getId() )
      return; // parent will now be called so will not add to global db either. 
      
   Parent::OnAdd(%this);
   
   $AmbientObjectDeck_Asteroids.AddCard(%this);        
   $AmbientObjectDeck_NearObjects.AddCard(%this); //For all near objects.    
}




new AmbientObjectRootDatablock (AmbientObjectRoot_Asteroid : AmbientObjectRoot)
{
   randomizedScaleFactor = "0.75 1.3"; //will inherit to all sub objects. 
   class = "AmbientObjectAsteroidDatablock";    
   isRepeatable = true;
};

new AmbientSubObjectDatablock (AmbientSubObjectAsteroid : AmbientSubObjectBase)
{   
   imageAdoptMoonColor = true;   
};

new AmbientSubObjectDatablock (AmbientSubObjectCloud : AmbientSubObjectBase)
{   
   imageBlend = "1 1 1 0.35";
   imageGraphic = "orbitObject_cloud_01ImageMap";
   imageSize = "512 512";
   imageAngularVelocity = 0.62;
   imageAdoptMoonColor = true; 
};

new AmbientSubObjectDatablock (AmbientSubObjectCloud_Light : AmbientSubObjectCloud)
{   
   imageBlend = "1 1 1 0.25";
};

new AmbientSubObjectDatablock (AmbientSubObjectCloud_Thick : AmbientSubObjectCloud)
{   
   imageBlend = "1 1 1 0.5";
};

//Asteroids 

new AmbientObjectRootDatablock (OrbitObject_asteroid_huge_01 : AmbientObjectRoot_Asteroid)
{     
   new AmbientSubObjectDatablock (AsteroidMassive : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_asteroid_huge_01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = 3.5;
      imageObstructionFactor = 1; 
   };
   new AmbientSubObjectDatablock (Asteroid02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_asteroid_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = 2;      
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   };   
};

new AmbientObjectRootDatablock (OrbitObject_asteroid_base_01 : AmbientObjectRoot_Asteroid)
{     
   new AmbientSubObjectDatablock (AsteroidMassive : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_asteroid_base_01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = 3.5;
      imageObstructionFactor = 0.5; 
   };
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

new AmbientObjectRootDatablock (OrbitObject_asteroid_cluster_01 : AmbientObjectRoot_Asteroid)
{      
   new AmbientSubObjectDatablock (Asteroid01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_asteroid_cluster_01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3;  //pretty see through 
   };
   new AmbientSubObjectDatablock (Asteroid02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_asteroid_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;      
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   };   
};

new AmbientObjectRootDatablock (OrbitObject_debris_cluster_01 : AmbientObjectRoot_Asteroid)
{      
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3;  //pretty see through 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
      
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "768 768";
   };   
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_01 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3;       
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };   
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_02 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_02ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_03 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_03ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_04 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_04ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_05 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_05ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_06 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_06ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_07 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_07ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_08 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_08ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_09 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_09ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_10 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_10ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_11 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_11ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_12 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_12ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_13 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_13ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_debris_huge_14 : AmbientObjectRoot_Asteroid)
{    
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_debris_huge_14ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_debris_cluster_02ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "768 768";
   };  
};

//zombie stuff

new AmbientObjectRootDatablock (OrbitObject_eggs_huge_01 : AmbientObjectRoot_Asteroid)
{   
   earlyOut = false; //flag to do smart stuff code side
   innerOnly = true; //zombie stuff 
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_zombie_egg01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_zombie_skin01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "512 512";
   }; 
};

new AmbientObjectRootDatablock (OrbitObject_eggs_huge_02 : AmbientObjectRoot_Asteroid)
{    
   earlyOut = false; //flag to do smart stuff code side
   innerOnly = true; //zombie stuff 
   new AmbientSubObjectDatablock (Debris01 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_zombie_egg02ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.3; 
   };
   new AmbientSubObjectDatablock (Debris02 : AmbientSubObjectAsteroid)
   {
      imageGraphic = "orbitObject_zombie_skin01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = -1;
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud)
   {
      imageSize = "512 512";
   }; 
};

/////////////////////////////////////////////////////////////////////////////////////////////////////
// Stations
/////////////////////////////////////////////////////////////////////////////////////////////////////

$AmbientObjectDeck_Stations = CreateAmbientObjectDeck();
function AmbientObjectStationDatablock::OnAdd(%this)
{   
   if ( %this.getId() == AmbientObjectRoot_Station.getId() )
      return; // parent will now be called so will not add to global db either. 
      
   Parent::OnAdd(%this);
   
   $AmbientObjectDeck_Stations.AddCard(%this);        
   $AmbientObjectDeck_NearObjects.AddCard(%this); //For all near objects.    
}


new AmbientObjectRootDatablock (AmbientObjectRoot_Station : AmbientObjectRoot)
{
   class = "AmbientObjectStationDatablock"; 
   randomizedScaleFactor = "0.75 1.5"; //will inherit to all sub objects.    
};

new AmbientSubObjectDatablock (AmbientSubObjectStation : AmbientSubObjectBase)
{   
   imageAdoptMoonColor = true;   
};

//Stations

new AmbientObjectRootDatablock (OrbitObject_pirate_outpost_01 : AmbientObjectRoot_Station)
{     
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "OrbitObject_pirate_outpost_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Thick)
   {
      imageSize = "512 512";
   }; 
};

new AmbientObjectRootDatablock (OrbitObject_terran_outpost_01 : AmbientObjectRoot_Station)
{     
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "OrbitObject_terran_outpost_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Light)
   {
      imageSize = "512 512";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_civ_outpost_01 : AmbientObjectRoot_Station)
{     
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "OrbitObject_civ_outpost_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Light)
   {
      imageSize = "512 512";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_civ_outpost_02 : AmbientObjectRoot_Station)
{       
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "OrbitObject_civ_outpost_02ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4; 
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Light)
   {
      imageSize = "512 512";
   };  
};

new AmbientObjectRootDatablock (orbitObject_civ_warpgate_01 : AmbientObjectRoot_Station)
{    
   new AmbientSubObjectDatablock (station : AmbientSubObjectStation)
   {
      imageGraphic = "orbitObject_civ_warpgate_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 1.5;
      imageObstructionFactor = 0.4;
       
   };
   new AmbientSubObjectDatablock (Cloud01 : AmbientSubObjectCloud_Light)
   {
      imageSize = "512 512";
   };  
};

new AmbientObjectRootDatablock (OrbitObject_pirate_wreckage_01 : AmbientObjectRoot_Asteroid)
{     
   new AmbientSubObjectDatablock (AsteroidMassive : AmbientSubObjectAsteroid)
   {
      imageGraphic = "OrbitObject_pirate_wreckage_01ImageMap";
      imageSize = "512 512";
      imageAngularVelocity = 3.5;
      imageObstructionFactor = 0.5; 
   };
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


