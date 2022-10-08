
$AmbientObjectDeck_VeryNearObjects = CreateAmbientObjectDeck();
SetCodeVal_AOD_VeryNearObjects($AmbientObjectDeck_VeryNearObjects);

$AmbientObjectDeck_Billboards = CreateAmbientObjectDeck();

function AmbientObjectBillboardDatablock::OnAdd(%this)
{   
   if ( %this.getId() == AmbientObjectRoot_Billboard.getId() )
      return; // parent will not be called so will not add to global db either. 
      
   Parent::OnAdd(%this);
   
   $AmbientObjectDeck_VeryNearObjects.AddCard(%this);        //For all cloud objects.
   $AmbientObjectDeck_Billboards.AddCard(%this);     
}


//////////////////////////////////////
// Billboard TV
//////////////////////////////////////

new AmbientObjectRootDatablock (AmbientObjectRoot_Billboard : AmbientObjectRoot)
{
   randomizedScaleFactor = "1 1"; //no sign scaling
   class = "AmbientObjectBillboardDatablock";    
   isRepeatable = true;
};


new AmbientObjectRootDatablock (orbitObject_adScreen_01 : AmbientObjectRoot_Billboard)
{   
   new AmbientSubObjectDatablock (adScreen : AmbientSubObjectStation)
   {
      imageClass = "adScreenClass"; 
      imageGraphic = "adScreen_barsImageMap";
      imageSize = "128 128";
      imageAngularVelocity = 2;
      imageObstructionFactor = 0.5; 
   };
};

////////////////////////////////////////////////////////////////////////////////
//STATIC billbaords
////////////////////////////////////////////////////////////////////////////////

new AmbientSubObjectDatablock (billbaord_PirateOverlay : AmbientSubObjectStation)
{   
   imageGraphic = "billboard_overlayPirateImageMap 10 billboard_overlayPirate_2ImageMap 10 billboard_overlayPirate_3ImageMap 10"; 
   imageSize = "256 256";
   imageBlend = "1 1 1 1";
   imageCreationChance = 1;  
   imageAngularVelocity = 1.5;
   
   SelectionData["InfraLevelRange"] = "3 3"; 
   SelectionData["Relations_Pirate_Civ"] = $FactionRelation_FRIEND SPC $FactionRelation_MYFACTION; 
};

new AmbientSubObjectDatablock (billbaord_ZombieOverlay : AmbientSubObjectStation)
{   
   imageGraphic = "billboard_overlayZombieImageMap 10 billboard_overlayZombie_2ImageMap 10"; 
   imageSize = "256 256";
   imageBlend = "1 1 1 1";
   imageCreationChance = 1;   
   imageAngularVelocity = 1.5;
   
   SelectionData["InfectionLevel"] = "1 3";
};

new AmbientSubObjectDatablock (billbaordStatic_large : AmbientSubObjectStation)
{     
   imageSize = "256 256";
   imageAngularVelocity = 1.5;
   imageObstructionFactor = 0.5; 
};

new AmbientSubObjectDatablock (billbaordStatic_small : AmbientSubObjectStation)
{     
   imageSize = "128 128";
   imageAngularVelocity = 1.7;
   imageObstructionFactor = 0.5; 
};

//BILLBOARDS

new AmbientObjectRootDatablock (billboard_treatment : AmbientObjectRoot_Billboard)
{   
   earlyOut = false; //flag to do smart stuff code side
   innerOnly = true; //zombie stuff 
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_large)
   {
      imageGraphic = "billboard_treatmentImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};

new AmbientObjectRootDatablock (billboard_roads : AmbientObjectRoot_Billboard)
{     
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_large)
   {
      imageGraphic = "billboard_roadsImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};

new AmbientObjectRootDatablock (billboard_military : AmbientObjectRoot_Billboard)
{        
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_large)
   {
      imageGraphic = "billboard_militaryImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};

new AmbientObjectRootDatablock (billboard_miners : AmbientObjectRoot_Billboard)
{     
   earlyOut = false; //flag to do smart stuff code side
   infrastructureOnly = true;
   starTypeIndex = 3; //1 = colony, 2 = science, 3 = mining, 0 = dont care
   
   new AmbientSubObjectDatablock (billboardMiners : billbaordStatic_large)
   {
      imageGraphic = "billboard_minersImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};

new AmbientObjectRootDatablock (billboard_fiveStar : AmbientObjectRoot_Billboard)
{     
   earlyOut = false; //flag to do smart stuff code side
   infrastructureOnly = true;
   starTypeIndex = 1; //1 = colony, 2 = science, 3 = mining, 0 = dont care
   
   new AmbientSubObjectDatablock (billboardMiners : billbaordStatic_large)
   {
      imageGraphic = "billboard_fiveStarImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};

new AmbientObjectRootDatablock (billboard_science : AmbientObjectRoot_Billboard)
{     
   earlyOut = false; //flag to do smart stuff code side
   infrastructureOnly = true;
   starTypeIndex = 2; //1 = colony, 2 = science, 3 = mining, 0 = dont care
      
   new AmbientSubObjectDatablock (billboardscience : billbaordStatic_large)
   {
      imageGraphic = "billboard_scienceImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};

new AmbientObjectRootDatablock (billboard_wanted : AmbientObjectRoot_Billboard)
{     
   //wanted poster will show up everywhere, better than slowing down loading.
   //if need be we can add some special case code.  Probably better to just hand place this 
   //in that case though
   //these checks no longer exist
   //DeployData["InstanceType"]   = "Security"; //uses the expensive check
   //DeployData["LevelRange"]     = "20 100"; //
   
   new AmbientSubObjectDatablock (billboardscience : billbaordStatic_large)
   {
      imageGraphic = "billboard_wantedImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};


new AmbientObjectRootDatablock (billboard_brokenRoadSign : AmbientObjectRoot_Billboard)
{     
   new AmbientSubObjectDatablock (billboardBroken : billbaordStatic_large)
   {
      imageGraphic = "billboard_brokenRoadSignImageMap";
   };
};

new AmbientObjectRootDatablock (billboard_growop : AmbientObjectRoot_Billboard)
{           
   new AmbientSubObjectDatablock (billboardBroken : billbaordStatic_large)
   {
      imageGraphic = "billboard_growopImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};

new AmbientObjectRootDatablock (billboard_anotherWay : AmbientObjectRoot_Billboard)
{   
   earlyOut = false; //flag to do smart stuff code side
   innerOnly = true; //zombie stuff 
   new AmbientSubObjectDatablock (billboardBroken : billbaordStatic_large)
   {
      imageGraphic = "billboard_anotherWayImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};

new AmbientObjectRootDatablock (billboard_bonds : AmbientObjectRoot_Billboard)
{     
   new AmbientSubObjectDatablock (billboardBroken : billbaordStatic_large)
   {
      imageGraphic = "billboard_bondsImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};


new AmbientObjectRootDatablock (billboard_streams : AmbientObjectRoot_Billboard)
{    
   earlyOut = false; //flag to do smart stuff code side
   infrastructureOnly = true;
   starTypeIndex = 2; //1 = colony, 2 = science, 3 = mining, 0 = dont care
    
   new AmbientSubObjectDatablock (billboardscience : billbaordStatic_large)
   {
      imageGraphic = "billboard_streamsImageMap";
   };
   new AmbientSubObjectDatablock (PirateOverlay : billbaord_PirateOverlay)
   {
   };
   new AmbientSubObjectDatablock (ZombieOverlay : billbaord_ZombieOverlay)
   {
   };
};


//SMALL BILLBOARDS

new AmbientObjectRootDatablock (billboard_piratePark : AmbientObjectRoot_Billboard)
{     
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_small)
   {
      imageGraphic = "billboard_pirateParkImageMap";
   };
};

new AmbientObjectRootDatablock (billboard_zombieCross : AmbientObjectRoot_Billboard)
{   
   earlyOut = false; //flag to do smart stuff code side
   innerOnly = true; //zombie stuff 
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_small)
   {
      imageGraphic = "billboard_zombieCrossImageMap";
   };
};

new AmbientObjectRootDatablock (billboard_speedLimit : AmbientObjectRoot_Billboard)
{     
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_small)
   {
      imageGraphic = "billboard_speedLimitImageMap";
   };
};

new AmbientObjectRootDatablock (billboard_survivor01 : AmbientObjectRoot_Billboard)
{    
   earlyOut = false; //flag to do smart stuff code side
   innerOnly = true; //zombie stuff 
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_small)
   {
      imageGraphic = "billboard_survivor01ImageMap";
   };
};

new AmbientObjectRootDatablock (billboard_stop : AmbientObjectRoot_Billboard)
{     
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_small)
   {
      imageGraphic = "billboard_stopImageMap";
   };
};

new AmbientObjectRootDatablock (billboard_question : AmbientObjectRoot_Billboard)
{     
   new AmbientSubObjectDatablock (billboardSign : billbaordStatic_small)
   {
      imageGraphic = "billboard_questionImageMap";
   };
};

