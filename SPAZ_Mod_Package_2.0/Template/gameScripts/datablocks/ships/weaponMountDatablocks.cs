


//NOTE: WE CANNOT INHERIT CODE VARIABLES ACROSS CLASSES!!!!
//This imheritance is ONLY here for dynamic fields!!!
//BEWARE
datablock WeaponMountDatablock(WeaponMountBase) 
{   
   imageMap_Default = "whitePixelImageMap";  
   size  = "8 8";   
   LinkPoints = "0.000 -0.800 0.000 0.000";  //where stuff comes out link 2 for missiles 
   mountLayerOffset = 0;  //draw on same layer as parent ship (will sort on top)
};


datablock WeaponMountDatablock(DefaultWeaponMount : WeaponMountBase) 
{   
   size  = "32 32";    
};

//////////////////////////////////////
// Cannons ///////////////////////////
//////////////////////////////////////

function WeaponMountDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
      
   return %imageMap;   
}



datablock WeaponMountDatablock(SmallCannonMount : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "cannon_basicImageMap";  
   imageMap_Zombie  = "cannon_zombieImageMap";  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(SmallCannonMount_rapid : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "cannon_rapidImageMap";  
   imageMap_Zombie  = "cannon_zombieImageMap";  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(SmallCannonMount_cluster : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "cannon_clusterImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap"; //zombies don't need cluster version  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(SmallCannonMount_massDriver : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "cannon_railgunImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap";   
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(MediumCannonMount : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "cannon_basicImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap";   
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(MediumCannonMount_rapid : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "cannon_rapidImageMap";  
   imageMap_Zombie  = "cannon_zombieImageMap";  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(MediumCannonMount_cluster : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "cannon_clusterImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap"; //zombies don't need cluster version  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(MediumCannonMount_massDriver : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "cannon_railgunImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap";   
   mountLayerOffset = 0;
};


datablock WeaponMountDatablock(LargeCannonMount : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "cannon_basicImageMap"; 
   imageMap_Zombie  = "cannon_zombieImageMap";  
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(LargeCannonMount_rapid : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "cannon_rapidImageMap";  
   imageMap_Zombie  = "cannon_zombieImageMap";  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(LargeCannonMount_cluster : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "cannon_clusterImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap"; //zombies don't need cluster version  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(LargeCannonMount_massDriver : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "cannon_railgunImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap"; //zombies don't need rail version  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(HugeCannonMount : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "cannon_basicImageMap";  
   imageMap_Zombie  = "cannon_zombieImageMap"; 
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(HugeCannonMount_rapid : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "cannon_rapidImageMap";  
   imageMap_Zombie  = "cannon_zombieImageMap";  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(HugeCannonMount_cluster : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "cannon_clusterImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap"; //zombies don't need cluster version  
   mountLayerOffset = 0;
};

datablock WeaponMountDatablock(HugeCannonMount_massDriver : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "cannon_railgunImageMap";
   imageMap_Zombie  = "cannon_zombieImageMap"; //zombies don't need rail version  
   mountLayerOffset = 0;
};

///////////////////////////////////////////////////
// Crew Cannons ///////////////////////////////////
///////////////////////////////////////////////////

datablock WeaponMountDatablock(CrewCannonMount_Kamakazie : WeaponMountBase) 
{   
   size             = "48 48";  
   imageMap_Default = "shuttle_launcher_smallImageMap";  
   imageMap_Zombie  = "shuttle_launcher_small_zomImageMap"; 
   mountLayerOffset = 0;   
};


datablock WeaponMountDatablock(CrewCannonMount_Shuttle : WeaponMountBase) 
{   
   size             = "48 48";  
   imageMap_Default = "shuttle_launcherImageMap";  
   imageMap_Zombie  = "shuttle_launcher_zomImageMap"; 
   mountLayerOffset = 0;   
};



//////////////////////////////////////
// Beams ///////////////////////////
//////////////////////////////////////

datablock WeaponMountDatablock(SmallBeamMount : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "emitter_basicImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(SmallBeamMount_heavy : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "emitter_heavyImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(SmallBeamMount_ion : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "emitter_ionImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(SmallBeamMount_leech : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "emitter_leechImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(MediumBeamMount : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "emitter_basicImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(MediumBeamMount_heavy : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "emitter_heavyImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(MediumBeamMount_ion : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "emitter_ionImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(MediumBeamMount_leech : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "emitter_leechImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};


datablock WeaponMountDatablock(LargeBeamMount : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "emitter_basicImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";   
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(LargeBeamMount_heavy : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "emitter_heavyImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";   
   mountLayerOffset = 0;   
};


datablock WeaponMountDatablock(LargeBeamMount_ion : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "emitter_ionImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";   
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(LargeBeamMount_leech : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "emitter_leechImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";   
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(HugeBeamMount : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "emitter_basicImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(HugeBeamMount_heavy : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "emitter_heavyImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};


datablock WeaponMountDatablock(HugeBeamMount_ion : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "emitter_ionImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

datablock WeaponMountDatablock(HugeBeamMount_leech : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "emitter_leechImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";  
   mountLayerOffset = 0;   
};

//////////////////////////////////////
// Mining Mounts /////////////////////
//////////////////////////////////////

datablock WeaponMountDatablock(SmallMiningBeamMount : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "emitter_minerImageMap";   
   imageMap_Zombie  = "emitter_zombieImageMap";   
   mountLayerOffset = 0;   
};


datablock WeaponMountDatablock(MediumMiningBeamMount : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "emitter_minerImageMap";  
   imageMap_Zombie  = "emitter_zombieImageMap";       
   mountLayerOffset = 0;   
};


datablock WeaponMountDatablock(LargeMiningBeamMount : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "emitter_minerImageMap";   
   imageMap_Zombie  = "emitter_zombieImageMap";     
   mountLayerOffset = 0;   
};

//No huge mining beams. this is the core beam
datablock WeaponMountDatablock(HugeCoreMiningBeamMount : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "emitter_minerImageMap"; 
   imageMap_Zombie  = "emitter_zombieImageMap";       
   mountLayerOffset = 0;   
};


//////////////////////////////////////
// Tractor ///////////////////////////
//////////////////////////////////////

datablock WeaponMountDatablock(TractorBeamMount_medium : WeaponMountBase) 
{   
   size             = "20 20";  
   imageMap_Default = "tractor_basicImagemap";  
   imageMap_Zombie  = "tractor_zombieImagemap";
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(TractorBeamMount_large : TractorBeamMount_medium) 
{   
   size             = "22 22";  
};

datablock WeaponMountDatablock(TractorBeamMount_huge : TractorBeamMount_medium) 
{   
   size             = "28 28";  
};

datablock WeaponMountDatablock(MiningTractorBeamMount : WeaponMountBase) 
{   
   size             = "16 16";  
   imageMap_Default = "tractor_basicImagemap";     
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

//hide under the ship
datablock WeaponMountDatablock(MicroTractorBeamMount : WeaponMountBase) 
{   
   size             = "1 1";  
   imageMap_Default = "tractor_basicImagemap";  
   imageMap_Zombie  = "tractor_zombieImagemap";   
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 1; 
};

//hide under the ship
datablock WeaponMountDatablock(CorruptionBeamMount : WeaponMountBase) 
{   
   size             = "1 1";  
   imageMap_Default = "tractor_basicImagemap";     
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 1; 
};

//////////////////////////////////////
// Point Defense Mounts //////////////
//////////////////////////////////////

datablock WeaponMountDatablock(PointDefenseBeamMount_S : WeaponMountBase) 
{   
   size             = "20 20";  
   imageMap_Default = "pointDef_turretImageMap"; 
   imageMap_Zombie  = "tractor_zombieImagemap";   
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(PointDefenseBeamMount_M : PointDefenseBeamMount_S) 
{   
   size             = "24 24";  
};

datablock WeaponMountDatablock(PointDefenseBeamMount_L : PointDefenseBeamMount_S) 
{   
   size             = "28 28";   
};

datablock WeaponMountDatablock(PointDefenseBeamMount_H : PointDefenseBeamMount_S) 
{   
   size             = "32 32";  
};

//////////////////////////////////////
// Scanner Mounts ////////////////////
//////////////////////////////////////

datablock WeaponMountDatablock(ScannerMount_S : WeaponMountBase) 
{   
   size             = "20 20";  
   imageMap_Default = "scanner_turretImageMap"; 
   imageMap_Zombie  = "tractor_zombieImagemap";   
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(ScannerMount_M : ScannerMount_S) 
{   
   size             = "24 24";  
};

datablock WeaponMountDatablock(ScannerMount_L : ScannerMount_S) 
{   
   size             = "28 28";     
};

datablock WeaponMountDatablock(ScannerMount_H : ScannerMount_S) 
{   
   size             = "32 32";     
};

//////////////////////////////////////
// Missiles ///////////////////////////
//////////////////////////////////////


datablock WeaponMountDatablock(SmallMissileMount : WeaponMountBase) 
{   
   size             = "24 24";  
   imageMap_Default = "missile_launcherImageMap";  
   imageMap_Zombie  = "missile_laucher_zombieImageMap";
   mountLayerOffset = 1;   //underneath
};


datablock WeaponMountDatablock(MediumMissileMount : WeaponMountBase) 
{   
   size             = "28 28";  
   imageMap_Default = "missile_launcherImageMap";  
   imageMap_Zombie  = "missile_laucher_zombieImageMap";
   mountLayerOffset = 1;   //underneath
};

datablock WeaponMountDatablock(LargeMissileMount : WeaponMountBase) 
{   
   size             = "36 36";  
   imageMap_Default = "missile_launcherImageMap";  
   imageMap_Zombie  = "missile_laucher_zombieImageMap";
   mountLayerOffset = 1;   //underneath
};


datablock WeaponMountDatablock(HugeMissileMount : WeaponMountBase) 
{   
   size             = "42 42";  
   imageMap_Default = "missile_launcherImageMap";  
   imageMap_Zombie  = "missile_laucher_zombieImageMap";
   mountLayerOffset = 1;   //underneath
};

//////////////////////////////////////
// Mine Droppers /////////////////////
//////////////////////////////////////

datablock WeaponMountDatablock(MineDropperLauncherMount : WeaponMountBase) 
{   
   size             = "32 32";  
   imageMap_Default = "missile_launcherImageMap";  
   imageMap_Zombie  = "missile_laucher_zombieImageMap";
   mountLayerOffset = 1;   //underneath
};

//////////////////////////////////////
// Deployable Turret Launcher /////////
//////////////////////////////////////

datablock WeaponMountDatablock(DeployableTurretLauncherMount : WeaponMountBase) 
{   
   size             = "32 32";  
   imageMap_Default = "missile_launcherImageMap";  
   imageMap_Zombie  = "missile_laucher_zombieImageMap";
   mountLayerOffset = 1;   //underneath
};

//////////////////////////////////////
// Drone Hive Mounts //////////////////
//////////////////////////////////////

datablock WeaponMountDatablock(DroneHiveLauncherMount : WeaponMountBase) 
{   
   size             = "32 32";  
   imageMap_Default = "missile_launcherImageMap";  
   imageMap_Zombie  = "missile_laucher_zombieImageMap";
   mountLayerOffset = 0;   //on top
};

//

datablock WeaponMountDatablock(ZombieMotherBeamMount : WeaponMountBase) 
{   
   size             = "16 16";  
   imageMap_Default = "alphaPixelImageMap";  
   imageMap_Zombie  = "alphaPixelImageMap";
   mountLayerOffset = 0;   //on top
};


//////////////////////////////////////
// Booster Mounts ////////////////////
//////////////////////////////////////


//SHIELDS
datablock WeaponMountDatablock(BoosterMount_Shield_S : WeaponMountBase) 
{   
   size             = "12 24";  
   imageMap_Default = "booster_shield_01ImageMap";  
   imageMap_Zombie  = "booster_zomImageMap";  
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(BoosterMount_Shield_M : BoosterMount_Shield_S) 
{   
   size             = "16 32";    
};

datablock WeaponMountDatablock(BoosterMount_Shield_L : BoosterMount_Shield_S) 
{   
   size             = "20 40";     
};


datablock WeaponMountDatablock(BoosterMount_Shield_H : BoosterMount_Shield_S) 
{   
   size             = "24 48";     
};


//REACTORS
datablock WeaponMountDatablock(BoosterMount_Reactor_S : WeaponMountBase) 
{   
   size             = "12 24";  
   imageMap_Default = "booster_reactor_01ImageMap";  
   imageMap_Zombie  = "booster_zomImageMap";    
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(BoosterMount_Reactor_M : BoosterMount_Reactor_S) 
{   
   size             = "16 32";    
};

datablock WeaponMountDatablock(BoosterMount_Reactor_L : BoosterMount_Reactor_S) 
{   
   size             = "20 40";     
};

datablock WeaponMountDatablock(BoosterMount_Reactor_H : BoosterMount_Reactor_S) 
{   
   size             = "24 48";     
};


//Engines
datablock WeaponMountDatablock(BoosterMount_Engines_S : WeaponMountBase) 
{   
   size             = "12 24";  
   imageMap_Default = "booster_engines_01ImageMap";  
   imageMap_Zombie  = "booster_zomImageMap";    
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(BoosterMount_Engines_M : BoosterMount_Engines_S) 
{   
   size             = "16 32";    
};

datablock WeaponMountDatablock(BoosterMount_Engines_L : BoosterMount_Engines_S) 
{   
   size             = "20 40";     
};

datablock WeaponMountDatablock(BoosterMount_Engines_H : BoosterMount_Engines_S) 
{   
   size             = "24 48";     
};

//Cloak
datablock WeaponMountDatablock(BoosterMount_Cloak_S : WeaponMountBase) 
{   
   size             = "12 24";  
   imageMap_Default = "booster_cloak_01ImageMap";  
   imageMap_Zombie  = "booster_zomImageMap";    
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(BoosterMount_Cloak_M : BoosterMount_Cloak_S) 
{   
   size             = "16 32";    
};

datablock WeaponMountDatablock(BoosterMount_Cloak_L : BoosterMount_Cloak_S) 
{   
   size             = "20 40";     
};

datablock WeaponMountDatablock(BoosterMount_Cloak_H : BoosterMount_Cloak_S) 
{   
   size             = "24 48";     
};


//Crew
datablock WeaponMountDatablock(BoosterMount_Crew_S : WeaponMountBase) 
{   
   size             = "12 24";  
   imageMap_Default = "booster_crew_01ImageMap"; 
   imageMap_Zombie  = "booster_zomImageMap";     
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(BoosterMount_Crew_M : BoosterMount_Crew_S) 
{   
   size             = "16 32";    
};

datablock WeaponMountDatablock(BoosterMount_Crew_L : BoosterMount_Crew_S) 
{   
   size             = "20 40";     
};

datablock WeaponMountDatablock(BoosterMount_Crew_H : BoosterMount_Crew_S) 
{   
   size             = "24 48";     
};



//Launcher
datablock WeaponMountDatablock(BoosterMount_Launcher_S : WeaponMountBase) 
{   
   size             = "12 24";  
   imageMap_Default = "booster_launcher_01ImageMap";   
   imageMap_Zombie  = "booster_zomImageMap";   
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(BoosterMount_Launcher_M : BoosterMount_Launcher_S) 
{   
   size             = "16 32";    
};

datablock WeaponMountDatablock(BoosterMount_Launcher_L : BoosterMount_Launcher_S) 
{   
   size             = "20 40";     
};

datablock WeaponMountDatablock(BoosterMount_Launcher_H : BoosterMount_Launcher_S) 
{   
   size             = "24 48";     
};


//Cannon
datablock WeaponMountDatablock(BoosterMount_Cannon_S : WeaponMountBase) 
{   
   size             = "12 24";  
   imageMap_Default = "booster_cannon_01ImageMap";  
   imageMap_Zombie  = "booster_zomImageMap";    
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(BoosterMount_Cannon_M : BoosterMount_Cannon_S) 
{   
   size             = "16 32";    
};

datablock WeaponMountDatablock(BoosterMount_Cannon_L : BoosterMount_Cannon_S) 
{   
   size             = "20 40";     
};

datablock WeaponMountDatablock(BoosterMount_Cannon_H : BoosterMount_Cannon_S) 
{   
   size             = "24 48";     
};

//Beam
datablock WeaponMountDatablock(BoosterMount_Beam_S : WeaponMountBase) 
{   
   size             = "12 24";  
   imageMap_Default = "booster_emitter_01ImageMap";    
   imageMap_Zombie  = "booster_zomImageMap";  
   LinkPoints = "0.000 0.000"; 
   mountLayerOffset = 0; 
};

datablock WeaponMountDatablock(BoosterMount_Beam_M : BoosterMount_Beam_S) 
{   
   size             = "16 32";    
};

datablock WeaponMountDatablock(BoosterMount_Beam_L : BoosterMount_Beam_S) 
{   
   size             = "20 40";     
};

datablock WeaponMountDatablock(BoosterMount_Beam_H : BoosterMount_Beam_S) 
{   
   size             = "24 48";     
};



