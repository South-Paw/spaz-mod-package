//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Planets ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
$AmbientObjectDeck_Planets = CreateAmbientObjectDeck();
SetCodeVal_AOD_Planets($AmbientObjectDeck_Planets);

function AmbientObjectPlanetDatablock::OnAdd(%this)
{   
   if ( %this.getId() == AmbientObjectRoot_Planet.getId() )
      return; // parent will now be called so will not add to global db either. 
      
   if ( %this.isStoryPlanet )
      return;  //they only show up when called.
      
   Parent::OnAdd(%this);
   
   $AmbientObjectDeck_Planets.AddCard(%this);            
}



new AmbientObjectRootDatablock (AmbientObjectRoot_Planet : AmbientObjectRoot)
{
   class = "AmbientObjectPlanetDatablock"; 
   isStoryPlanet = false;  
};


new AmbientSubObjectDatablock (AmbientSubObjectPlanet_Layer : AmbientSubObjectBase)
{   
   randomizeColor = true;
   contrastRatio = 1;
   contrastDecayRate = -0.075;
   colorDecayRate = 0.10;
   brightnessAddative = 0;
   imageSize = "512 512";
   imageBlend = "1 1 1 1"; 
   
};

new AmbientSubObjectDatablock (AmbientSubObjectPlanet : AmbientSubObjectPlanet_Layer)
{   
   imageObstructionFactor = 1;
   imageSize = "512 512";
   imageBlend = "1 1 1 1"; 
};

new AmbientSubObjectDatablock (AmbientSubObjectPlanet_SunCrest : AmbientSubObjectBase)
{   
   randomizeColor = false;
   imageGraphic = "planet_lightCardImageMap"; 
   imageIsIntense = true; 
   imageSize = "512 512";
   imageBlend = "1 1 1 1";
   imageAdoptLevelColor = true;   
};

new AmbientSubObjectDatablock (AmbientSubObjectPlanet_CityLights : AmbientSubObjectPlanet_Layer)
{   
   imageGraphic = "planet_lights_01ImageMap 10 planet_lights_02ImageMap 10 planet_lights_03ImageMap 10"; 
   imageIsIntense = true; 
   imageSize = "512 512";
   imageBlend = "1 1 0.5 1";
   imageAdoptLevelColor = false;
   randomizeColor = false;
   imageCreationChance = 0.7; //remove this if prereqs work
   
   contrastRatio = 1;
   contrastDecayRate = -0.00001;
   colorDecayRate = 0.00001;
   brightnessAddative = 0;         
};

new AmbientSubObjectDatablock (AmbientSubObjectPlanet_SmallRing : AmbientSubObjectPlanet_Layer)
{   
   imageGraphic = "planet_ring02ImageMap"; 
   imageIsIntense = true; 
   imageSize = "896 896";
   imagePulseSize = "896 896";     
   imageBlend = "1 1 1 0.6"; 
   imagePulseBlend = "1 1 1 0.4";
   imagePulseTime = 1525;
   imageCreationChance = 0.5; 
   imageGraphic = "planet_ring01ImageMap 10 planet_ring02ImageMap 10 planet_ring03ImageMap 10 planet_ring04ImageMap 10 planet_ring07ImageMap 10";      
};

new AmbientSubObjectDatablock (AmbientSubObjectPlanet_SmallAsteroidBelt : AmbientSubObjectPlanet_Layer)
{   
   imageGraphic = "planet_ring02ImageMap"; 
   imageIsIntense = false; 
   imageAdoptLevelColor = false;
   imageAdoptMoonColor = true;
   randomizeColor = false;
   imageSize = "896 896";
   imageCreationChance = 0.2; 
   imageGraphic = "planet_ring05ImageMap 10 planet_ring06ImageMap 10";      
};


//generic planets

new AmbientObjectRootDatablock (Planet_Generic_Storm_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_storm01ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1"; 
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = 0.6;       
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {        
      }; 
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Clouds_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_clouds01ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1"; 
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = 0.6;       
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {        
      }; 
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Ocean_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_ocean01ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1"; 
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = 0.6;       
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {        
      }; 
   };
};

new AmbientObjectRootDatablock (Planet_Generic_LandMass_02 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_landmass02ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1"; 
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = 0.6;       
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {        
      }; 
   };
};

new AmbientObjectRootDatablock (Planet_Generic_LandMass_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_landmass01ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1"; 
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = 0.6;       
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {        
      }; 
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Desert_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_desert01ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1";
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = 0.6;    
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {  
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {        
      };         
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Gas_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_gas01ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1";
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = 0.6;        
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      }; 
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      }; 
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {  
      };
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Cracked_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_crust01ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1";
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = -0.1;      
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {
      };   
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Alien_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_infection01ImageMap";
      imageSize = "512 512";
      imageBlend = "1 1 1 1"; 
      contrastRatio = 1;
      contrastDecayRate = -0.005;
      colorDecayRate = 0.0;
      brightnessAddative = 0.6;  
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };     
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {         
      };
   };
};

new AmbientObjectRootDatablock (Planet_Small_Orange : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_orange_smallImageMap";
      imageSize = "512 512";
      contrastRatio = 0.6;
      brightnessAddative = 0.15;   
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };      
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {        
      };
   };
};


new AmbientObjectRootDatablock (Planet_Small_Red : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_red_smallImageMap";
      imageSize = "512 512";
      contrastRatio = 0.8;
      brightnessAddative = 0.2;  
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };  
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {      
      };        
   };
};


new AmbientObjectRootDatablock (Planet_Small_Green : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_green_smallImageMap";
      imageSize = "512 512";
      contrastRatio = 0.6;
      brightnessAddative = 0.15;    
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };       
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {      
      }; 
   };
};


new AmbientObjectRootDatablock (Planet_Small_Blue : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_blue_smallImageMap";
      imageSize = "512 512";
      brightnessAddative = 0.35;
      contrastRatio = 0.8; 
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {      
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {      
      };              
   };
};


new AmbientObjectRootDatablock (Planet_Small_Yellow : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   { 
      imageGraphic = "planet_yellow_smallImageMap";
      imageSize = "512 512";
      brightnessAddative = 0.2;
      contrastRatio = 0.8;     
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {    
      };          
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {      
      }; 
   };
};


new AmbientObjectRootDatablock (Planet_Small_Purple : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_purple_smallImageMap";
      imageSize = "512 512";
      contrastRatio = 0.65;
      brightnessAddative = 0.15;  
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {  
      };          
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {      
      }; 
   };
};

//generic textured planets

new AmbientObjectRootDatablock (Planet_Generic_Textured_01 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_generic_01ImageMap";   
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {         
      };
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Textured_02 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_generic_02ImageMap";   
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {         
      };
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Textured_03 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_generic_03ImageMap";   
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {         
      };
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Textured_04 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_generic_04ImageMap";   
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {         
      };
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Textured_05 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_generic_05ImageMap";   
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {         
      };
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Textured_06 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_generic_06ImageMap";   
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {         
      };
   };
};

new AmbientObjectRootDatablock (Planet_Generic_Textured_07 : AmbientObjectRoot_Planet)
{   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_generic_07ImageMap";   
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
      new AmbientSubObjectDatablock (PlanetAsteroids : AmbientSubObjectPlanet_SmallAsteroidBelt)
      {        
      };  
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {         
      };
   };
};



/////////////////////////////////////////////////////////////////////////////
// Story Planets ////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////

new AmbientObjectRootDatablock (AmbientObjectRoot_StoryPlanet : AmbientObjectRoot_Planet)
{   
   isStoryPlanet = true;  
};


//////////////////////////////////////////////////////
// Sol Planets ///////////////////////////////////////
//////////////////////////////////////////////////////

new AmbientObjectRootDatablock (SI_S1_Sol_Mercury : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "0.5 0.5";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_desert01ImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "1 1 1 1";
      
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {  
      };         
   };
};


new AmbientObjectRootDatablock (SI_S1_Sol_Venus : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "1.1 1.1";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_crust01ImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "0.8 1 0.3 1";
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };         
   };
};

new AmbientObjectRootDatablock (SI_S1_Sol_Earth : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "1 1";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_earth_smallImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "1 1 1 1";
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {  
      };         
   };
};

new AmbientObjectRootDatablock (SI_S1_Sol_Mars : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "0.66 0.66";
   
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_red_smallImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "1 0.2 0.2 1";
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {  
      };         
   };
};



new AmbientObjectRootDatablock (SI_S1_Sol_Jupiter : AmbientObjectRoot_StoryPlanet)
{    
   randomizedScaleFactor = "1.75 1.75";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_orange_smallImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "1 0.7 0.2 1";
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      { 
      };         
   };
};


new AmbientObjectRootDatablock (SI_S1_Sol_Saturn : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "1.3 1.3";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_gas01ImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "0.9 0.7 0.2 1";
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {    
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {   
         imageGraphic = "planet_ring01ImageMap";
         randomizeColor = false;
         imageBlend = "1 0.4 0 1"; 
         imagePulseBlend = "1 0.4 0 1";   
         imageCreationChance = 1; 
      };           
   };
};

//should be greyish teal
new AmbientObjectRootDatablock (SI_S1_Sol_Uranus : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "1 1";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_ocean01ImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "0.6 0.6 0.8";
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
   };
};


//should be deep blue
new AmbientObjectRootDatablock (SI_S1_Sol_Neptune : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "0.8 0.8";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_blue_smallImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "0.6 0.8 1";
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };
      new AmbientSubObjectDatablock (PlanetRing : AmbientSubObjectPlanet_SmallRing)
      {   
         imageGraphic = "planet_ring02ImageMap";
         randomizeColor = false;
         imageBlend = "0.7 0.4 0 0.35";  
         imagePulseBlend = "0.7 0.4 0 0.35";   
         imageCreationChance = 1; 
      };           
   };
};

new AmbientObjectRootDatablock (SI_S1_Sol_Pluto : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "0.4 0.4";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "moon_small01ImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "0.2 0.4 0.6 1";
      
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {   
      };         
   };
};

//SPECIAL ZOMBIE PLANET

new AmbientObjectRootDatablock (SI_S4_ZombiePlanet : AmbientObjectRoot_StoryPlanet)
{      
   randomizedScaleFactor = "1 1";
   new AmbientSubObjectDatablock (Planet : AmbientSubObjectPlanet)
   {
      imageGraphic = "planet_desert01ImageMap";
      imageSize = "512 512";
      randomizeColor = false;
      imageBlend = "0 0 0 1";
      new AmbientSubObjectDatablock (LightCard : AmbientSubObjectPlanet_SunCrest)
      {  
      };         
   };
};


