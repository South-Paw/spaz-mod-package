
/////////////////////////////////////////////////////////////////////////////////////////////////////
// Stars ////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////
$AmbientObjectDeck_Stars = CreateAmbientObjectDeck();
function AmbientObjectStarDatablock::OnAdd(%this)
{   
   if ( %this.getId() == AmbientObjectRoot_Star.getId() )
      return; // parent will now be called so will not add to global db either. 
      
   if ( %this.isStoryStar )
      return;      
      
   Parent::OnAdd(%this);
   
   $AmbientObjectDeck_Stars.AddCard(%this);            
}

function AmbientObjectStarDatablock::GetStarSize(%this)
{ 
   return %this.getObject(0).imageSize; //make sure object 0 is always the star
   //NOTE: dyson and black hole are special and do not work this way.    
}

new AmbientObjectRootDatablock (AmbientObjectRoot_Star : AmbientObjectRoot)
{
   randomizedScaleFactor = "1 1"; //no star scaling since they already zoom
   class = "AmbientObjectStarDatablock";    
   isRepeatable = true;  //this is true because galaxy never resets the repeatable set.  so we will cycle through the deck over and over. 

   minScale = 0.4;  //keep max scale / minscale = 5 ratio minimum
   maxScale = 2;   //you can override these.  scaling is exponential so shrinks really fast. after closest instance.

   childStars = "Star_Child_01";  //none to pick from, so will never have a shild star
   childStarChance = 0.66; //0 - 1;  1 = always.
   childStarMax = 2;   //chance of a trinary star at mPow(childStarChance, childStarIndex);
   
   contextImage = "~/data/images/interface/starContext/starContextImage_starLarge.png"; 
   contextImageOptional = "";   
   
   isStoryStar = false;
};




new AmbientSubObjectDatablock (AmbientSubObjectStar : AmbientSubObjectBase)
{   
   imageAdoptLevelColor = true;   
   canColorOverride = true;
   createHotSurface = true; //only for stars.
};

new AmbientSubObjectDatablock (AmbientSubObjectStarCorona : AmbientSubObjectBase)
{   
   imageClass = "CoronaClass"; 
   imageAdoptLevelColor = true;   
   canColorOverride = true;    
};

//stars

new AmbientObjectRootDatablock (Star_Large_01 : AmbientObjectRoot_Star)
{  
   minScale = 0.3;
   maxScale = 1.5; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starLarge.png";
   LOD_image = "orbitLOD_largeStarImageMap";    
   
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "largeStar_01Imagemap";
      imageSize = "384 384";
      imageAngularVelocity = 3;
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "largeStar_01Imagemap";
         imageSize = "384 384";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.75"; 
         
         imagePulseSize = "384 384";
         imagePulseBlend = "1 1 1 0.55"; 
         imagePulseTime = 1250;      
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "768 768";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.8"; 
         
         imagePulseSize = "768 768";
         imagePulseBlend = "1 1 1 0.6"; 
         imagePulseTime = 10000;      
      };
   };
};

new AmbientObjectRootDatablock (Star_Large_02 : AmbientObjectRoot_Star)
{  
   minScale = 0.3;
   maxScale = 1.5;
   contextImage = "~/data/images/interface/starContext/starContextImage_starFlair.png";  
   LOD_image = "orbitLOD_plasmaStarImageMap";   
   
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "largeStar_02Imagemap";
      imageSize = "384 384";
      imageAngularVelocity = 3;
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "largeStar_02Imagemap";
         imageSize = "384 384";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.75"; 
         
         imagePulseSize = "384 384";
         imagePulseBlend = "1 1 1 0.55"; 
         imagePulseTime = 1250;      
      };
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "largeFlair_03ImageMap";
         imageSize = "384 384";
         imageAngularVelocity = -1.3; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.75"; 
         
         imagePulseSize = "384 384";
         imagePulseBlend = "1 1 1 0.55"; 
         imagePulseTime = 3250;      
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "768 768";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.6"; 
         
         imagePulseSize = "768 768";
         imagePulseBlend = "1 1 1 0.5"; 
         imagePulseTime = 10000;      
      };
   };
};


new AmbientObjectRootDatablock (Star_Large_03 : AmbientObjectRoot_Star)
{  
   minScale = 0.3;
   maxScale = 1.5;
   contextImage = "~/data/images/interface/starContext/starContextImage_starRings.png"; 
   LOD_image = "orbitLOD_waveStarImageMap"; 
   
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "largeStar_03Imagemap";
      imageSize = "384 384";
      imageIsIntense = true; 
        
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "768 768";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.6"; 
         
         imagePulseSize = "768 768";
         imagePulseBlend = "1 1 1 0.5"; 
         imagePulseTime = 10000;      
      };
   };
};

new AmbientObjectRootDatablock (Star_Large_04 : AmbientObjectRoot_Star)
{  
   minScale = 0.3;
   maxScale = 1.5; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starQuasar.png"; 
   LOD_image = "orbitLOD_nutronStarImageMap";   
   
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "largeStar_04Imagemap";
      imageSize = "384 384";
      imageIsIntense = true; 
        
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "768 768";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.6"; 
         
         imagePulseSize = "768 768";
         imagePulseBlend = "1 1 1 0.5"; 
         imagePulseTime = 10000;      
      };
   };
};

new AmbientObjectRootDatablock (Star_Large_05 : AmbientObjectRoot_Star)
{  
   minScale = 0.3;
   maxScale = 1.5; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starDouble.png"; 
   LOD_image = "orbitLOD_doubleStarImageMap"; 
   
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "largeStar_05Imagemap";
      imageSize = "384 384";
      imageIsIntense = true; 
        
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "768 768";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.6"; 
         
         imagePulseSize = "768 768";
         imagePulseBlend = "1 1 1 0.5"; 
         imagePulseTime = 10000;      
      };
   };
};


new AmbientObjectRootDatablock (Star_Med_01 : AmbientObjectRoot_Star)
{   
   minScale = 0.4;
   maxScale = 2; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starMed.png";
   LOD_image = "orbitLOD_smallStarImageMap"; 
     
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "MedStar_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 3;
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "MedStar_01ImageMap";
         imageSize = "256 256";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.4"; 
         
         imagePulseSize = "256 256";
         imagePulseBlend = "1 1 1 0.2"; 
         imagePulseTime = 1250;      
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "1000 1000";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.8"; 
         
         imagePulseSize = "1024 1024";
         imagePulseBlend = "1 1 1 0.6"; 
         imagePulseTime = 10000;      
      };
   };
};



new AmbientObjectRootDatablock (Star_Small_01 : AmbientObjectRoot_Star)
{   
   minScale = 0.3;
   maxScale = 1.5; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starSmall.png";
   LOD_image = "orbitLOD_smallStarImageMap"; 
    
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "smallStar_01Imagemap";
      imageSize = "256 256";
      imageAngularVelocity = 3;
      imageIsIntense = true; 
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "smallStar_01Imagemap";
         imageSize = "192 192";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 1"; 
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "1024 1024";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.6"; 
         
         imagePulseSize = "1024 1024";
         imagePulseBlend = "1 1 1 0.4"; 
         imagePulseTime = 10000;      
      };
   };
};



new AmbientObjectRootDatablock (DysonStar_01 : AmbientObjectRoot_Star)
{  
   minScale = 0.8; //just looks too crunchy when its small
   maxScale = 1.5; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starMed.png";
   contextImageOptional = "~/data/images/interface/starContext/starContextImage_starDyson.png";    
   LOD_image = "orbitLOD_largeStarImageMap"; 
   
   new AmbientSubObjectDatablock (BackOuterSphere : AmbientSubObjectBase)  //Note: not a star ambient sub object, just a regular one
   {
      imageGraphic = "dysonSphere_outter01Imagemap";
      imageSize = "768 768";
      imageAngularVelocity = 1;
      imageBlend = "0.3 0.3 0.3 0.65";
   };
    
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "MedStar_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 3;
            
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "MedStar_01ImageMap";
         imageSize = "256 256";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.75"; 
         
         imagePulseSize = "300 300";
         imagePulseBlend = "1 1 1 0.35"; 
         imagePulseTime = 2000;
      };
      
      new AmbientSubObjectDatablock (FrontOuterSphere : AmbientSubObjectBase)  //Note: not a star ambient sub object, just a regular one
      {
         imageGraphic = "dysonSphere_outter01Imagemap";
         LOD_image = "orbitLOD_sphereImageMap"; 
         imageSize = "768 768";
         imageAngularVelocity = 1;
         imageBlend = "1 1 1 0.65";
         imageAdoptMoonColor = true;
         imageRotationOffset = 72;
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "1280 1280";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.8"; 
         
         imagePulseSize = "1400 1400";
         imagePulseBlend = "1 1 1 0.6";  
         imagePulseTime = 10000; 
      };
   };
};




new AmbientObjectRootDatablock (Blackhole_01 : AmbientObjectRoot_Star)
{  
   contextImage = "~/data/images/interface/starContext/starContextImage_starBlackhole.png"; 
   LOD_image = "orbitLOD_blackholeImageMap";  
   
   new AmbientSubObjectDatablock (TheRing : AmbientSubObjectBase)   //Note: not a star ambient sub object,
   {
      imageGraphic = "blackhole_ring01Imagemap";
      imageSize = "768 768";      
      imageIsIntense = true;
      imageAdoptLevelColor = true;
      
      new AmbientSubObjectDatablock (BlackCore : AmbientSubObjectBase)    //Note: not a star ambient sub object,
      {
         imageGraphic = "blackhole_core01Imagemap";
         imageSize = "128 128";
         imageAngularVelocity = 2.5;
         imageAdoptLevelColor = true;          
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "1024 1024";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.8"; 
         
         imagePulseSize = "1400 1400";
         imagePulseBlend = "1 1 1 0.6"; 
         imagePulseTime = 10000;      
      };
   };
};



//NOTE:  this star seems to be special and is not inheriting like the others. 
new AmbientObjectRootDatablock (SuperNova_01 : AmbientObjectRoot_Star)
{   
   contextImage = "~/data/images/interface/starContext/starContextImage_starSmall.png"; 
   minScale = 0.3;
   maxScale = 1.5; 
   LOD_image = "orbitLOD_smallStarImageMap"; 
   
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectBase)  //Note: not a star ambient sub object,
   {
      imageGraphic = "reactor_wispImageMap";
      imageSize = "32 32";
      imageAngularVelocity = 6;
      imageIsIntense = true; 
      imageAdoptLevelColor = true;
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectBase)  //Note: not a star ambient sub object,
      {
         imageGraphic = "smallStar_01Imagemap";
         imageSize = "256 256";
         imageAngularVelocity = 3; 
         imageIsIntense = true; 
         imageAdoptLevelColor = true;  
         imageBlend = "1 1 1 0.7";        
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectBase)  //Note: not a star ambient sub object,
      {
         imageGraphic = "largeFlair_02ImageMap"; 
         imageIsIntense = true; 
         imageSize = "768 768";
         imageAngularVelocity = 5;
         imageAdoptLevelColor = true;         
         imageBlend = "1 1 1 0.5";
      };
      new AmbientSubObjectDatablock (StarFlare2 : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "768 768";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.6"; 
         
         imagePulseSize = "1024 1024";
         imagePulseBlend = "1 1 1 0.4"; 
         imagePulseTime = 10000;      
      };
   };
};

/////////////////////////////////////////////////
// Child Stars //////////////////////////////////
/////////////////////////////////////////////////



function AmbientObjectChildStarDatablock::GetStarSize(%this)
{ 
   return %this.getObject(0).imageSize; //make sure object 0 is always the star
}


new AmbientObjectRootDatablock (AmbientObjectRoot_ChildStar : AmbientObjectRoot)
{
   randomizedScaleFactor = "1 1"; //no star scaling
   class = "AmbientObjectChildStarDatablock";  //we do not want this adding itself to any groups on its own!     
};




new AmbientObjectRootDatablock (Star_Child_01 : AmbientObjectRoot_ChildStar)
{   
   //doesnt need min or max scale.  it scales with its parent star.
  
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "childStar_01ImageMap";
      imageSize = "128 128";
      imageAngularVelocity = 3;
      imageIsIntense = true; 
      colorDecayRate = 0.10;
      new AmbientSubObjectDatablock (StarFlare2 : AmbientSubObjectStarCorona)
      {
         imageGraphic = "smallStar_01ImageMap"; 
         imageIsIntense = true; 
         imageSize = "256 256";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.2"; 
         imagePulseSize = "300 300";
         imagePulseBlend = "1 1 1 0.3"; 
         imagePulseTime = 10000;  
         colorDecayRate = 0.10;    
      };
   };
};


//////////////////////////////////////////////////////////
// Specials //////////////////////////////////////////////
//////////////////////////////////////////////////////////

new AmbientObjectRootDatablock (TheSun : AmbientObjectRoot_Star)
{ 
   randomizedScaleFactor = "";
   
   childStars = ""; 
   minScale = 0.4;
   maxScale = 2; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starLarge.png"; 
   LOD_image = "orbitLOD_largeStarImageMap"; 
   
   isStoryStar = true;
   
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "MedStar_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 3;
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "MedStar_01ImageMap";
         imageSize = "256 256";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.4"; 
         
         imagePulseSize = "256 256";
         imagePulseBlend = "1 1 1 0.2"; 
         imagePulseTime = 1250;      
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "1000 1000";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.8"; 
         
         imagePulseSize = "1024 1024";
         imagePulseBlend = "1 1 1 0.6"; 
         imagePulseTime = 10000;      
      };
   };
};




new AmbientObjectRootDatablock (TheProximaDyson : AmbientObjectRoot_Star)
{ 
   minScale = 0.8; //just looks too crunchy when its small
   maxScale = 1.5; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starMed.png";
   contextImageOptional = "~/data/images/interface/starContext/starContextImage_starDyson.png";    
   LOD_image = "orbitLOD_largeStarImageMap"; 
   
   new AmbientSubObjectDatablock (BackOuterSphere : AmbientSubObjectBase)  //Note: not a star ambient sub object, just a regular one
   {
      imageGraphic = "dysonSphere_outter01Imagemap";
      imageSize = "768 768";
      imageAngularVelocity = 1;
      imageBlend = "0.3 0.3 0.3 0.65";
   };
    
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "MedStar_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 3;
            
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "MedStar_01ImageMap";
         imageSize = "256 256";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.75"; 
         
         imagePulseSize = "300 300";
         imagePulseBlend = "1 1 1 0.35"; 
         imagePulseTime = 2000;
      };
      
      new AmbientSubObjectDatablock (FrontOuterSphere : AmbientSubObjectBase)  //Note: not a star ambient sub object, just a regular one
      {
         imageGraphic = "dysonSphere_outter01Imagemap";
         LOD_image = "orbitLOD_sphereImageMap"; 
         imageSize = "768 768";
         imageAngularVelocity = 1;
         imageBlend = "1 1 1 0.65";
         imageAdoptMoonColor = true;
         imageRotationOffset = 72;
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "1280 1280";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.8"; 
         
         imagePulseSize = "1400 1400";
         imagePulseBlend = "1 1 1 0.6";  
         imagePulseTime = 10000; 
      };
   };
};


new AmbientObjectRootDatablock (WOLF359_StarArt : AmbientObjectRoot_Star)
{ 
   randomizedScaleFactor = "";
   
   childStars = ""; 
   minScale = 0.4;
   maxScale = 2; 
   isStoryStar = true;
   
   contextImage = "~/data/images/interface/starContext/starContextImage_starSmall.png";
   LOD_image = "orbitLOD_smallStarImageMap"; 
    
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "smallStar_01Imagemap";
      imageSize = "256 256";
      imageAngularVelocity = 3;
      imageIsIntense = true; 
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "smallStar_01Imagemap";
         imageSize = "192 192";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 1"; 
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "1024 1024";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.6"; 
         
         imagePulseSize = "1024 1024";
         imagePulseBlend = "1 1 1 0.4"; 
         imagePulseTime = 10000;      
      };
   };
};


new AmbientObjectRootDatablock (SIRIUS_StarArt : AmbientObjectRoot_Star)
{    
   randomizedScaleFactor = "";
   childStars = ""; 
   isStoryStar = true;
   
   minScale = 0.3;
   maxScale = 1.5;
   contextImage = "~/data/images/interface/starContext/starContextImage_starFlair.png";  
   LOD_image = "orbitLOD_plasmaStarImageMap";   
   
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "largeStar_02Imagemap";
      imageSize = "384 384";
      imageAngularVelocity = 3;
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "largeStar_02Imagemap";
         imageSize = "384 384";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.75"; 
         
         imagePulseSize = "384 384";
         imagePulseBlend = "1 1 1 0.55"; 
         imagePulseTime = 1250;      
      };
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "largeFlair_03ImageMap";
         imageSize = "384 384";
         imageAngularVelocity = -1.3; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.75"; 
         
         imagePulseSize = "384 384";
         imagePulseBlend = "1 1 1 0.55"; 
         imagePulseTime = 3250;      
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "768 768";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.6"; 
         
         imagePulseSize = "768 768";
         imagePulseBlend = "1 1 1 0.5"; 
         imagePulseTime = 10000;      
      };
   };
};

new AmbientObjectRootDatablock (LUYTEN_StarArt : AmbientObjectRoot_Star)
{   
   randomizedScaleFactor = "";
   childStars = ""; 
   isStoryStar = true;   
   
   minScale = 0.4;
   maxScale = 2; 
   contextImage = "~/data/images/interface/starContext/starContextImage_starMed.png";
   LOD_image = "orbitLOD_smallStarImageMap"; 
     
   new AmbientSubObjectDatablock (StarCore : AmbientSubObjectStar)
   {
      imageGraphic = "MedStar_01ImageMap";
      imageSize = "256 256";
      imageAngularVelocity = 3;
      
      new AmbientSubObjectDatablock (StarSurface : AmbientSubObjectStar)
      {
         imageGraphic = "MedStar_01ImageMap";
         imageSize = "256 256";
         imageAngularVelocity = -2.25; 
         imageIsIntense = true; 
         imageBlend = "1 1 1 0.4"; 
         
         imagePulseSize = "256 256";
         imagePulseBlend = "1 1 1 0.2"; 
         imagePulseTime = 1250;      
      };
           
      //TODO:  back layer flare and front layer flare. 
      new AmbientSubObjectDatablock (StarFlare : AmbientSubObjectStarCorona)
      {
         imageGraphic = "largeFlair_01Imagemap"; 
         imageIsIntense = true; 
         imageSize = "1000 1000";
         imageAngularVelocity = 4.2;
         imageBlend = "1 1 1 0.8"; 
         
         imagePulseSize = "1024 1024";
         imagePulseBlend = "1 1 1 0.6"; 
         imagePulseTime = 10000;      
      };
   };
};


new AmbientObjectRootDatablock (FinalStar : AmbientObjectRoot_Star)
{ 
   randomizedScaleFactor = "";
   
   childStars = ""; 
   minScale = 3;
   maxScale = 3; 
    
   contextImage = "~/data/images/interface/starContext/starContextImage_starBlackhole.png"; 
   LOD_image = "orbitLOD_blackholeImageMap";  
   
   isStoryStar = true;
   
   new AmbientSubObjectDatablock (TheRing : AmbientSubObjectBase)   //Note: not a star ambient sub object,
   {
      imageGraphic = "largeFlair_03ImageMap";
      imageSize = "512 512";      
      imageIsIntense = true;
      imageAdoptLevelColor = true;
      new AmbientSubObjectDatablock (BlackCore : AmbientSubObjectBase)    //Note: not a star ambient sub object,
      {
         imageGraphic = "blackhole_core01Imagemap";
         imageSize = "384 384";
         imageAngularVelocity = 2.5;
         imageAdoptLevelColor = true;          
      };
      new AmbientSubObjectDatablock (ShatteredPlanetPart_01 : AmbientSubObjectBase)  
      {
         imageGraphic = "finalStarPart_01ImageMap";
         imageSize = "512 512";
         imageAngularVelocity = 2.5;
         imageAdoptLevelColor = true;          
      };  
   };
};

