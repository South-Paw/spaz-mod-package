
/////////////////////////////////////////////////////////////////////////////////////////////////////
// Moons ////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////
$AmbientObjectDeck_Moons = CreateAmbientObjectDeck();
SetCodeVal_AOD_Moons($AmbientObjectDeck_Moons);

function AmbientObjectMoonDatablock::OnAdd(%this)
{   
   if ( %this.getId() == AmbientObjectRoot_Moon.getId() )
      return; // parent will now be called so will not add to global db either. 
      
   Parent::OnAdd(%this);
   
   $AmbientObjectDeck_Moons.AddCard(%this);            
}



new AmbientObjectRootDatablock (AmbientObjectRoot_Moon : AmbientObjectRoot)
{
   randomizedScaleFactor = "0.75 1.5"; //will inherit to all sub objects. 
   class = "AmbientObjectMoonDatablock";    
};

new AmbientSubObjectDatablock (AmbientSubObjectMoon : AmbientSubObjectBase)
{   
   imageAdoptMoonColor = true;   
};

//moons

new AmbientObjectRootDatablock (Moon_Small_01 : AmbientObjectRoot_Moon)
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_small01Imagemap";
      imageSize = "128 128";    
   };
};


new AmbientObjectRootDatablock (Moon_Small_Shatter_01 : AmbientObjectRoot_Moon)
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_small_shatter01ImageMap";
      imageSize = "128 128";  
      new AmbientSubObjectDatablock (MoonCrumble : AmbientSubObjectMoon)
      {
         imageGraphic = "orbitObject_asteroid_cluster_small_01ImageMap";
         imageSize = "256 256";
         imageAngularVelocity = 2;      
      };
      new AmbientSubObjectDatablock (MoonCrumble2 : AmbientSubObjectMoon)
      {   
         imageBlend = "1 1 1 0.3";
         imageGraphic = "effect_blackSmokeImageMap";
         imageSize = "384 384";
         imageAngularVelocity = 0.62;
      };  
   };
};


new AmbientObjectRootDatablock (Moon_Med_01 : AmbientObjectRoot_Moon)
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_med01Imagemap";
      imageSize = "256 256"; 
      imageObstructionFactor = 1; //pretty big so can obstruct.
   };
};


new AmbientObjectRootDatablock (Moon_Tiny_01 : AmbientObjectRoot_Moon)
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_tiny01Imagemap";
      imageSize = "64 64";
   };
};


new AmbientObjectRootDatablock (Moon_Tiny_02 : AmbientObjectRoot_Moon)
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_tiny02Imagemap";
      imageSize = "64 64";
   };
};


new AmbientObjectRootDatablock (Moon_Tiny_03 : AmbientObjectRoot_Moon)
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_tiny03Imagemap";
      imageSize = "64 64";
   };
};


new AmbientObjectRootDatablock (Moon_Tiny_04 : AmbientObjectRoot_Moon)
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_tiny04Imagemap";
      imageSize = "64 64";
   };
};


new AmbientObjectRootDatablock (Moon_Spec_01 : AmbientObjectRoot_Moon)
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_spec01Imagemap";
      imageSize = "32 32";
   };
};

/////////////////////////////////////////////////////////////////////////////////////////////////////
// shadded moons
/////////////////////////////////////////////////////////////////////////////////////////////////////

new AmbientObjectRootDatablock (Moon_Small_orange : AmbientObjectRoot_Moon) //saturn titan
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_small_orangeImageMap";
      imageSize = "128 128";    
   };
};
new AmbientObjectRootDatablock (Moon_Small_brown : AmbientObjectRoot_Moon) //jupiter ganymede
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_small_brownImageMap";
      imageSize = "128 128";    
   };
};
new AmbientObjectRootDatablock (Moon_Small_yellow : AmbientObjectRoot_Moon) //jupiter Io
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_small_yellowImageMap";
      imageSize = "128 128";    
   };
};
new AmbientObjectRootDatablock (Moon_Tiny_orange : AmbientObjectRoot_Moon) //jupiter callisto
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_tiny_orangeImageMap";
      imageSize = "64 64";    
   };
};
new AmbientObjectRootDatablock (Moon_Tiny_red : AmbientObjectRoot_Moon)  //saturn hyperion
{      
   new AmbientSubObjectDatablock (Moon : AmbientSubObjectMoon)
   {
      imageGraphic = "moon_tiny_redImageMap";
      imageSize = "64 64";    
   };
};