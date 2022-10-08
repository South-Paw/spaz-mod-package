
datablock RocketDatablock(RocketBase) 
{
   launchSound = "snd_smallTorpLaunch";
   explosionSound = "snd_smallExplosion";
   subProjectileCount = "0";
   
   CollisionPolyList = "-0.241 -0.884 0.069 -0.884 0.069 0.869 -0.246 0.869";
   LinkPoints = "0.000 0.000 0.000 1.000";
     
   researchDatablock = "MissileResearch";
   
   engineDatablock_Zombie = "ZombieThruster";  
   
   launchImpulse = 100;
   launchDir     = 0;  //direction is mirrored if missile is on the left side.  
   launchDamping = 0;
 
   isCloaking = false;
   
   allowNonFactionCollision = true; //will not hit asteroids and such
   hitShipsOnly = false;  //most missiles we want to avoid all but ships. will also only target ships. 
   useRandomTargeting = false;
   randomTargetingRange = 400;
   
   spawnEffect = "MissileReloadFlash";
   spawnScale = 0.5;
   spawnSound = "snd_missileReload"; //played on player ship only. and only if ship has been alive for > 1 second.


   isMissilePod = false;
   bombletMinSpawnTime = 50;
   bombletMaxSpawnTime = 100;
   
   flightDamping = 0;
   brainActivationTime = -1; //brain never turns on.
   
   thrustEffectScale = 1;
   
   //paint job
   mountedImageMaps[0] = "rocket_glowImageMap 16 16 0 0 0";
   
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0.5 0.5 0.5 0.5";
   mountedImageMapState["Mounted", "FinalBlend", 0]   = "0.5 0.5 0.5 0.5";
   mountedImageMapState["Mounted", "PulseData", 0]    = "0 0 1 1 0";
   
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0.5 0.5 0.5 0.5";
   mountedImageMapState["Drifting", "FinalBlend", 0]   = "1 1 1 1"; 
   mountedImageMapState["Drifting", "PulseData", 0]    = "0 0 1 1 0";
   
   mountedImageMapState["Active", "InitialBlend", 0] = "1 1 1 1";
   mountedImageMapState["Active", "FinalBlend", 0]   = "1 1 1 0.5"; 
   mountedImageMapState["Active", "PulseData", 0]    = "0 0 1 1 0"; 
   
   //glow off until active
   mountedImageMapState["Mounted", "InitialBlend", 1] = "0 0 0 0";
   mountedImageMapState["Mounted", "FinalBlend", 1]   = "0 0 0 0";
   mountedImageMapState["Mounted", "PulseData", 1]    = "0 0 1 1 0";
  
   mountedImageMapState["Drifting", "InitialBlend", 1] = "0 0 0 0";
   mountedImageMapState["Drifting", "FinalBlend", 1]   = "0 0 0 0"; 
   mountedImageMapState["Drifting", "PulseData", 1]    = "0 1 1 1 0";  
};




function RocketDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}


function RocketDatablock::GetFactionEngineDatablock(%this, %factionName)
{
   %engineDatablock = %this.engineDatablock_[%factionName];
   if ( %engineDatablock $= "" )
      %engineDatablock = %this.engineDatablock_Default;
       
   return %engineDatablock;   
}


//THIS IS A SRM POD.
datablock RocketDatablock(SRM_Pod_Small : RocketBase) 
{
   imageMap_Default = "rocket_caseImageMap";
    
   size = "8 32";          
   
   isMissilePod = true;  //remain attached.
   bombletMinSpawnTime = 35;
   bombletMaxSpawnTime = 100;
   
   launchSound = "snd_smallTorpLaunch"; //this is played when the fhooshing starts
   
   explosionSound = "snd_smallExplosion";  //plays when pod is spent
   explosionDatablock = "SmallExplosion";
   explosionScale = "1";
      
   subProjectile = "SRMBomblet_Small";  
   subProjectileCount = "4";
   
   missileLifetimeMS = "1"; //how long before it begins to fire bomblets.
   
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[0] = "rocket_glowImageMap 8 32 0 0 0";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "1 0 1 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "1 0 1 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "1 0 1 0.5";
   
   //Mounted images: "imageMap sizeX sizeY LinkOffsetX LinkOffsetY LayerOffset";
   mountedImageMaps[1] = "missileHighlightImageMap 8 32 0 0 0";
   
   //PulseTime, PulseCount, InitialSizeMult, finalSizeMult, isIntense   
   mountedImageMapState["Active", "InitialBlend", 1] = "1 0 0 0.6";
   mountedImageMapState["Active", "FinalBlend", 1]   = "1 0 0 0.3"; 
   mountedImageMapState["Active", "PulseData", 1]    = "300 0 1.5 2 1";  
};
datablock RocketDatablock(HUNTER_Pod_Small : SRM_Pod_Small) 
{
   subProjectile = "HunterBomblet_Small";
   imageMap_Default = "hunter_caseImageMap"; 
   mountedImageMaps[0] = "hunter_glowImageMap 8 32 0 0 0";   
     
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 1 0.5";
};

datablock RocketDatablock(SRM_Pod_Medium : SRM_Pod_Small) 
{
   imageMap_Default = "rocket_caseImageMap";
   size = "12 48";            
  
   subProjectileCount = "7";
   subProjectile = "SRMBomblet_Small"; 
   
   mountedImageMaps[0] = "rocket_glowImageMap 12 48 0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap 12 48 0 0 0";
};
datablock RocketDatablock(HUNTER_Pod_Medium : SRM_Pod_Medium) 
{
   subProjectile = "HunterBomblet_Small";   
   imageMap_Default = "hunter_caseImageMap"; 
   mountedImageMaps[0] = "hunter_glowImageMap 12 48 0 0 0"; 
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 1 0.5";  
};

   
   
datablock RocketDatablock(SRM_Pod_Large : SRM_Pod_Small) 
{
   imageMap_Default = "rocket_caseImageMap";
   size = "16 64";            
  
   subProjectileCount = "4";
   subProjectile = "SRMBomblet_Large"; 
   
   mountedImageMaps[0] = "rocket_glowImageMap 16 64 0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap 16 64 0 0 0";
};
datablock RocketDatablock(HUNTER_Pod_Large : SRM_Pod_Large) 
{
   subProjectile = "HunterBomblet_Large"; 
   imageMap_Default = "hunter_caseImageMap"; 
   mountedImageMaps[0] = "hunter_glowImageMap 16 64 0 0 0"; 
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 1 0.5";     
};

datablock RocketDatablock(SRM_Pod_Huge : SRM_Pod_Small) 
{
   imageMap_Default = "rocket_caseImageMap";
   size = "24 80";            
  
   subProjectileCount = "7";
   subProjectile = "SRMBomblet_Large"; 
   
   mountedImageMaps[0] = "rocket_glowImageMap 24 80 0 0 0";
   mountedImageMaps[1] = "missileHighlightImageMap 24 80 0 0 0";
};
datablock RocketDatablock(HUNTER_Pod_Huge : SRM_Pod_Huge) 
{
   subProjectile = "HunterBomblet_Large"; 
   imageMap_Default = "hunter_caseImageMap"; 
   mountedImageMaps[0] = "hunter_glowImageMap 24 80 0 0 0";
   
   //paint job
   mountedImageMapState["Mounted", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Drifting", "InitialBlend", 0] = "0 1 1 0.5";
   mountedImageMapState["Active", "InitialBlend", 0] = "0 1 1 0.5";      
};
   
   
   