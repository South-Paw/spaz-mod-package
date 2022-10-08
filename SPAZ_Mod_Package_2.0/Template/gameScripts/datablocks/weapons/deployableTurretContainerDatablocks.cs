datablock DeployableTurretContainerDatablock(DeployableTurretContainerBase) 
{
   explosionSound = "snd_smallExplosion";
   explosionDatablock = "BigExplosion";
   explosionScale = "1";
   
   launchSound = "snd_smallMissileLaunch";
   
   researchDatablock = "TurretResearch";
   
   size = "70 70";     //midsized between 64 and 96 looked too small on the helix but needed to be a standard size       
   CollisionPolyList = "-0.342 -0.417 0.392 -0.408 0.234 0.363 -0.419 0.280";
   LinkPoints = "0.000 0.000";
      
   imageMap_Default = "deployCase_beamImageMap";
   imageMap_Pirate  = "deployCase_beamImageMap";
          
   deploy_time          = 2000;  //MS    
   deploy_effect        = "deployCase_eject";  
   deploy_effect_scale  = 1.5;
   deploy_sound         = "snd_turretDeploy";
   deploy_turret        = "DeployTurretShip_Surplus";
   
   bowling_effect       = "shuttleMotion";
   bowling_effect_scale = "1.6";
   
   spawnEffect = "MissileReloadFlash";
   spawnScale  = 1.5;
   spawnSound  = "snd_missileReload"; //played on player ship only. and only if ship has been alive for > 1 second.

   hasCloaking = false;

   maxHealth = "25";
};

function DeployableTurretContainerDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}

////////////////////////////////////////////////////////////////
// Basic ///////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////


datablock DeployableTurretContainerDatablock(DeployableTurretContainer_Surplus : DeployableTurretContainerBase) 
{  
   deploy_time          = 2000;  //MS    
   deploy_effect_scale  = 1.5;
   deploy_turret        = "DeployTurretShip_Surplus";
   
   imageMap_Default = "deployCase_beamImageMap";
   imageMap_Pirate  = "deployCase_beamImageMap";
   
   maxHealth = "20";
};

//Basic
datablock DeployableTurretContainerDatablock(DeployableTurretContainer_Basic : DeployableTurretContainerBase) 
{    
   deploy_time          = 2000;  //MS    
   deploy_effect_scale  = 1.5;
   deploy_turret        = "DeployTurretShip_Basic";
   
   imageMap_Default = "deployCase_cannonImageMap";
   imageMap_Pirate  = "deployCase_cannonImageMap";
         
   maxHealth = "30";
};

//Improved
datablock DeployableTurretContainerDatablock(DeployableTurretContainer_Ion : DeployableTurretContainerBase) 
{    
   deploy_time          = 2000;  //MS    
   deploy_effect_scale  = 1.5;   
   deploy_turret        = "DeployTurretShip_Ion";
   
   imageMap_Default = "deployCase_ionImageMap";
   imageMap_Pirate  = "deployCase_ionImageMap";
      
   hasCloaking = true;
   maxHealth = "45";
};

datablock DeployableTurretContainerDatablock(DeployableTurretContainer_Leech : DeployableTurretContainerBase) 
{    
   deploy_time          = 2000;  //MS    
   deploy_effect_scale  = 1.5;   
   deploy_turret        = "DeployTurretShip_Leech";
   
   imageMap_Default = "deployCase_leechImageMap";
   imageMap_Pirate  = "deployCase_leechImageMap";
      
   hasCloaking = true;
   maxHealth = "45";
};




//Advanced
datablock DeployableTurretContainerDatablock(DeployableTurretContainer_TorpRack : DeployableTurretContainerBase) 
{  
   deploy_time          = 2000;  //MS    
   deploy_effect_scale  = 1.5;   
   deploy_turret        = "DeployTurretShip_TorpedoRack";
   
   imageMap_Default = "deployCase_torpImageMap";
   imageMap_Pirate  = "deployCase_torpImageMap";
      
   maxHealth = "75";
};

datablock DeployableTurretContainerDatablock(DeployableTurretContainer_BattleStation : DeployableTurretContainerBase) 
{   
   deploy_time          = 2000;  //MS    
   deploy_effect_scale  = 1.5;   
   deploy_turret        = "DeployTurretShip_BattleStation";
   
   imageMap_Default = "deployCase_rapidImageMap";
   imageMap_Pirate  = "deployCase_rapidImageMap";
      
   maxHealth = "120";
};





