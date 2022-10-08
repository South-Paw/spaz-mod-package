
/////////////////////////////////////////////
// Base Classes /////////////////////////////
/////////////////////////////////////////////
$AmbientObjectSet_All = new SimSet() {};
function AmbientObjectRootDatablock::OnAdd(%this)
{
   if ( %this.getId() == AmbientObjectRoot.getId() )
      return; //is a root object
      
   $AmbientObjectSet_All.add(%this);            
}

//These are what we call to spawn.  They know how to build ambient objects. 
new AmbientObjectRootDatablock (AmbientObjectRoot)
{
   isRepeatable = false;  //if true, there can be more than one of these before ambientObjectDeck reset repeatable calls. 

   earlyOut = true; //set to false if uses special deploy data.   
   innerOnly = false;  //only for zombie stars
   infrastructureOnly = false;
   starTypeIndex = 0; //1 = colony, 2 = science, 3 = mining, 0 = dont care
   
   randomizedScaleFactor = "0.66 1.5"; //will inherit to all sub objects.
};


function AmbientSubObjectDatablock::OnAdd(%this)
{
   %this.imageGraphic = createEfficientWeightedList(%this.imageGraphic);   
}



new AmbientSubObjectDatablock (AmbientSubObjectBase)
{
     
   imageSuperClass = "AmbientSubObject";  //these know how to create their children with offsets 
   imageClass = ""; //can be set to anything for specials like coronas
   //Maybe also add creation chances?
   
   createHotSurface = false; //only for stars.
   
   imageGraphic = "";
   LOD_image = ""; 
   imageIsIntense = false;
   //imageRotation = 0;  //removed.  makes more sense to pass this in along with scenegraph, position, and parallax factor to simulate a position and orientation in 3d space
   imageBlend = "1 1 1 1";
   imagePulseBlend = "1 1 1 1"; 
   imageSize = "768 768";
   imagePulseSize = "768 768";
   imagePulseTime = 0;
   imageAdoptLevelColor = false;
   imageAdoptMoonColor = false;

   //New stuff   
   imageRotationOffset = 0;  //so sub objects can maintain a standard position and rotation offset connected to the parent's position and rotation
   imageOffsetDirection = 0;  //offsets from parent.
   imageOffsetDistance = 0; // can use randomized values like "0 360" as well for both of these
   imageCreationChance = 1;  //ahh what the hell
   imageCount = 1; //maybe we want a buncha them, who knows uses randoms like instances so 1 or "1 5" are valid
   imageAngularVelocity = 0;
   imageCollisionPolyList = "-0.633 -0.658 -0.020 -0.894 0.638 -0.658 0.918 0.005 0.658 0.638 -0.010 0.913 -0.629 0.658 -0.904 0.000";  
      
   imageObstructionFactor = 0;  //numbers > 0 interfere with the star's corona.  this is expensive.
  
   canColorOverride = false;  //we only want some pieces of stars to be able to do this. 
   
   
};


function CreateAmbientObjectDeck()
{
   %deck = new AmbientDeckClass() {};
   return %deck;
}

   



