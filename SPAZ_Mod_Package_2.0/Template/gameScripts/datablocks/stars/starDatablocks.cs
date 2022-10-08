/////////////////////////////////
// Star Database ////////////////
/////////////////////////////////

//Used to help the galaxy generate itself logically. 


$StarDatablockNameChecker = new ScriptObject();
function StarDatablock::OnAdd(%this)
{
   if ( $StarDatablockNameChecker.names[%this.getName()] !$= "" )
      echo("StarDatablock name dupe.  will break loading FIX ME!" SPC %this.getName());
   
   $StarDatablockNameChecker.names[%this.getName()] = %this;
   
   %this.AddStarToDatabase();  
   %this.SetupWeightedLists();
}

function StarDatablock::SetupWeightedLists(%this)
{
   %this.starArtTypes = createEfficientWeightedList(%this.starArtTypes); 
}
  
   
function StarDatablock::AddStarToDatabase(%this)
{
   if ( $StarDatabase $= "" )
      $StarDatabase = new ScriptGroup() {};
      
   %starType = %this.starType;
   if ( %starType $= "" )
      return;
      
   if ( $StarDatabase[%starType] $= "" )
      $StarDatabase[%starType] = new ScriptGroup() {};
      
   %starDatabseEntry = new ScriptObject()
   {
      starDatablock = %this;
   };
   
   $StarDatabase.add(%starDatabseEntry);
   $StarDatabase[%starType].add(%starDatabseEntry);
}


//Used by the galaxy to "deal" cards
function GetStarSetByType(%starType)
{
   return $StarDatabase[%starType];
}

function GetRandomStarByType(%starType)
{
   %typeSet = GetStarSetByType(%starType);
   %randomSelection = %typeSet.getObject(getRandom(0, %typeSet.getCount() - 1));
   return %randomSelection.starDatablock;   
}

/////////////////////////////////////////////
// BaseStarInstance   ///////////////////////
/////////////////////////////////////////////

$InstanceDatablockNameChecker = new ScriptObject();   
function StarInstanceDatablock::OnAdd(%this)
{
   if ( $InstanceDatablockNameChecker.names[%this.getName()] !$= "" )
      echo("StarInstanceDatablock name dupe.  will break loading FIX ME!" SPC %this.getName());
   
   $InstanceDatablockNameChecker.names[%this.getName()] = %this;
      
   %this.instanceTypeWL = createEfficientWeightedList(%this.instanceTypeWL); 
}


new ScriptObject(StarInstanceDatablockBase)
{
   creationChance = 1; //if < 1 we can have random instance show up.  
   class = "StarInstanceDatablock";     
   
   instancePosition = "RANDOM";  
   instanceName = ""; //will auto generate. 
   
   instancePlanetChance = 0;
   instancePlanet = "RANDOM";  //In case we have a story planet to place here.
   instancePlanetOrbitals = "RANDOM"; //Will for the right orbitals (so the earth has a moon)
   instancePlanetOrbitalCount = "0 3"; //get random from pair
   
   songOverride = "";
};



new ScriptObject(MothershipHideInstanceBase : StarInstanceDatablockBase)
{
   instanceID = "Hide";  //So we know what we are dealing with if we need to find an instance in a star. 
   instanceTypeWL = "MothershipHideInstance";
   
   instancePosition = 0;  //MHI is always hiding right next to star.
   
   instancePlanetChance = 0.66;
};

new ScriptObject(SecurityInstanceBase : StarInstanceDatablockBase)
{
   instanceID = "Security";   
   instanceTypeWL = "SecurityInstance";
     
   instancePlanetChance = 0.66;
};

new ScriptObject(WarpgateInstanceBase : StarInstanceDatablockBase)
{
   instanceID = "Warpgate";   
   instanceTypeWL = "WarpGateInstance";
     
   instancePlanetChance = 0;
   instancePlanetOrbitalCount = 0;
};

//BOOM! Need to deal these like cards
new ScriptObject(InfrastructureInstanceBase : StarInstanceDatablockBase)
{
   instanceID = "Infrastructure";   
   instanceTypeWL = "EDL InfraInstances MiningInstance ScienceInstance ColonyInstance";
   
   instancePlanetChance = 1;
};

new ScriptObject(ZombieInstanceBase : StarInstanceDatablockBase)
{
   instanceID = "Zombie";   
   instanceTypeWL = "ZombieInstance";
     
   instancePlanetChance = 0;   //is weird to see a planet instance appear and disappear. 
};

new ScriptObject(BountyInstanceBase : StarInstanceDatablockBase)
{
   instanceID = "Bounty";   
   instanceTypeWL = "BountyInstance";
     
   instancePlanetChance = 0;   //is weird to see a planet instance appear and disappear. 
};

new ScriptObject(RandomInstanceBase : StarInstanceDatablockBase)
{
   creationChance = 1;  //THIS MUST BE 1!!!!! Or flow will randomly break 
   //NOTE: the random number generator is broken and not giving a good distribution.
   
   instanceID   = "Random";   
   instanceTypeWL = "RandomInstance 50 RandomInstance_Rich 15 RandomInstance_Barrels 15 RandomInstance_Crates 10 RandomInstance_Wrecks 5"; //This is a weighted list

   instancePlanetChance = 0.66;
};

////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////
// Defining Stars ////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////



/////////////////////////////////////////////
// BaseStar  ////////////////////////////////
/////////////////////////////////////////////

//We do not need to use Datablocks for this.
new ScriptGroup(StarDatablockBase)
{
   starNameOverride = ""; //used to overrite the randomly assigned name
   
   class = "StarDatablock";  //so we can hook up to an on Add type functionality. 
   starClass = "";   //unused for now
   starType = "";  //if "" will not be added to DB.  Allows us to categorize stars for galaxy creation

   baseInstanceDistance = 128; //some stars (like Sol) we want to move the instances waaaay out from the star so the sun doesnt seem too big
   starScaleMult = 1.0;
   
   warpGateInstanceDatablockWL = "WarpgateInstanceBase"; //Since there are multiple we need to provide a list to choose from. 
};



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Random Stars ///////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


new ScriptGroup(RandomStar : StarDatablockBase)
{      
   starType = "Random";
   starArtTypes = "EDL RandomStars Red Orange Yellow Green Blue Purple"; //Type could also be a specific star like "Earth"

   new ScriptObject(StarInstance_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(StarInstance_Security : SecurityInstanceBase) {};
   new ScriptObject(StarInstance_Infrastructure : InfrastructureInstanceBase) {};
   new ScriptObject(StarInstance_Zombie : ZombieInstanceBase) {};
   
   
   //Gotta make a logical assignment func for these, so we get mining type instances in mining stars. 
   new ScriptObject(StarInstance_Random0 : RandomInstanceBase) {};
   new ScriptObject(StarInstance_Random1 : RandomInstanceBase) {};
   new ScriptObject(StarInstance_Random2 : RandomInstanceBase) {};
   new ScriptObject(StarInstance_Random3 : RandomInstanceBase) {creationChance = 0.66;};
   new ScriptObject(StarInstance_Random4 : RandomInstanceBase) {creationChance = 0.50;};
};


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Story Stars ///////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


////////////////////////////////////
// SOL /////////////////////////////
////////////////////////////////////

new ScriptObject(S1_Sol_WarpgateInstance : WarpgateInstanceBase)
{   
   instanceTypeWL = "SI_S1_Sol_Warpgate"; 
};


//Will also need to control orbitals. 
new ScriptGroup(Earth_Story : StarDatablockBase)
{
   starNameOverride = "THE SOL SYSTEM";
   starType     = "EARTH"; 
   starArtTypes = "Earth_Special"; 
   
   baseInstanceDistance = 128;  
   starScaleMult = 0.66;  
       
   warpGateInstanceDatablockWL = "S1_Sol_WarpgateInstance";

   new ScriptObject(S1_Sol_MercuryRandomInstance : StarInstanceDatablockBase)
   {  
      instanceID   = "Random";   
      instanceName = "MERCURY";
      instanceTypeWL = "SI_S1_Sol_AmbientAsteroid"; 

      instancePosition = 0;
      
      instancePlanetChance = 1;
      instancePlanet         = "SI_S1_Sol_Mercury";
      instancePlanetOrbitals = "";  
      instancePlanetOrbitalCount = 0;
   };

   new ScriptObject(S1_Sol_VenusRandomInstance : StarInstanceDatablockBase)
   {  
      instanceID   = "Random";   
      instanceName = "VENUS";
      instanceTypeWL = "SI_S1_Sol_AmbientAsteroid"; 

      instancePosition = 1;
      
      instancePlanetChance = 1;
      instancePlanet         = "SI_S1_Sol_Venus";
      instancePlanetOrbitals = "";  
      instancePlanetOrbitalCount = 0;
   };


   new ScriptObject(Earth_Story_MHI : MothershipHideInstanceBase) 
   {
      instanceTypeWL = "SI_S1_Sol_MothershipHide";
      instanceName = "EARTH";
      
      instancePosition = 2;
       
      instancePlanetChance   = 1;
      instancePlanet         = "SI_S1_Sol_Earth";
      instancePlanetOrbitals = "Moon_Small_Shatter_01";
      
      distantLayerOverride = "cloud_junkImageMap";  
      songOverride = "Song_01";
   };
   
   new ScriptObject(Earth_Story_Security : SecurityInstanceBase) 
   {
      instanceTypeWL = "SI_S1_Sol_Security";
      instanceName = "MARS";
      
      instancePosition = 3;
      
      instancePlanetChance   = 1;
      instancePlanet         = "SI_S1_Sol_Mars";
      instancePlanetOrbitals = "Moon_Tiny_01 Moon_Tiny_02"; //need 2 smalls.Phobos Deimos  
  
      researchCards[0] = "ProjectileResearch 2";
   };
   
   new ScriptObject(Earth_Story_Infrastructure : InfrastructureInstanceBase) 
   {
      instanceTypeWL = "SI_S1_Sol_Mining";
      instanceName = "JUPITER";
      
      instancePosition = 4;
      
      instancePlanetChance   = 1;
      instancePlanet         = "SI_S1_Sol_Jupiter";
      instancePlanetOrbitals = "Moon_Tiny_orange Moon_Small_yellow Moon_Small_brown"; //need 4 bigs Io Europa Ganymede Callisto 
   
      researchCards[0] = "BeamResearch 1"; //research category + level.
      researchCards[1] = "ShieldResearch 2"; 
      researchCards[2] = "ReactorResearch 2"; 
   };
   
   new ScriptObject(S1_Sol_SaturnRandomInstance : StarInstanceDatablockBase)
   {  
      instanceID   = "Random";   
      instanceTypeWL = "SI_S1_Sol_DeadSpace"; 
      instanceName = "SATURN";

      instancePosition = 5;
      
      instancePlanetChance = 1;
      instancePlanet         = "SI_S1_Sol_Saturn";
      instancePlanetOrbitals = "Moon_Small_orange Moon_Tiny_red Moon_Tiny_03 Moon_Tiny_04"; //need 1 bigs 2 tinys 
   };
   
   new ScriptObject(S1_Sol_UranusRandomInstance : StarInstanceDatablockBase)
   {  
      instanceID   = "Random";   
      instanceTypeWL = "SI_S1_Sol_AmbientAsteroid"; 
      instanceName = "URANUS";
      
      
      instancePosition = 6;
      
      instancePlanetChance = 1;
      instancePlanet         = "SI_S1_Sol_Uranus";
      instancePlanetOrbitals = "Moon_Tiny_04 Moon_Tiny_01 Moon_Tiny_03";  
   };
   
   new ScriptObject(S1_Sol_NeptuneRandomInstance : StarInstanceDatablockBase)
   {  
      instanceID   = "Random";   
      instanceTypeWL = "SI_S1_Sol_AmbientAsteroid"; 
      instanceName = "NEPTUNE";
      
      instancePosition = 7;
      
      instancePlanetChance = 1;
      instancePlanet         = "SI_S1_Sol_Neptune";
      instancePlanetOrbitals = "Moon_Tiny_02 Moon_Med_01"; 
   };
   
   new ScriptObject(S1_Sol_PlutoRandomInstance : StarInstanceDatablockBase)
   {  
      instanceID   = "Random";   
      instanceTypeWL = "SI_S1_Sol_AmbientAsteroid"; 
      instanceName = "PLUTO";
      
      instancePosition = 8;
      
      instancePlanetChance = 1;
      instancePlanet         = "SI_S1_Sol_Pluto";
      instancePlanetOrbitals = "Moon_Tiny_04"; 
   };
   new ScriptObject(S1_Sol_Zombie : ZombieInstanceBase) {};
};


////////////////////////////////////
// Sector2_Root ////////////////////
////////////////////////////////////


new ScriptGroup(Sector2_RootSystem : StarDatablockBase)
{      
   starNameOverride = "PROXIMA";
   starType = "Sector2_Root";  
   starArtTypes = "Proxima_Special"; 

   new ScriptObject(Sector2_Root_MHI : MothershipHideInstanceBase) 
   {
      instanceTypeWL = "SI_S2_Root_MothershipHide";    
      instancePlanetChance   = 1;      
   };
     
   new ScriptObject(Sector2_Root_Security : SecurityInstanceBase) 
   {
      instanceTypeWL = "SI_S2_Root_Security"; 
      instancePlanetChance   = 1;      
      
      researchCards[0] = "EngineResearch 2";
      researchCards[1] = "ArmorResearch 2";
   };
   
   new ScriptObject(Sector2_Root_Science : InfrastructureInstanceBase) 
   {
      instanceTypeWL = "SI_S2_Root_Science";
      instancePlanetChance   = 1;      
      
      researchCards[0] = "MissileResearch 2";
   };
   
   
   new ScriptObject(Sector2_Root_Random0 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Root_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Root_Random2 : RandomInstanceBase) {};
   
   //probably want to set special background and clouds here. 
   new ScriptObject(Sector2_Root_FocusInstance : StarInstanceDatablockBase)
   {       
      instanceID   = "Random";  
      instanceName = "EXPERIMENT SITE";        
      instanceTypeWL = "SI_S2_Root_Graveyard";     
      
      instancePosition = 5;    //must situated before the randomly created instances. 
      instancePlanetChance = 0;    
   };
   
   new ScriptObject(Sector2_Root_Random3 : RandomInstanceBase) {creationChance = 0.66;};
   new ScriptObject(Sector2_Root_Random4 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector2_Root_Zombie : ZombieInstanceBase) {};
};


new ScriptGroup(Sector2_WOLF359System : StarDatablockBase)
{      
   starNameOverride = "WOLF 359";
   starType = "WOLF359";  
   starArtTypes = "WOLF359_Special"; 

   new ScriptObject(Sector2_WOLF359StarInstance_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector2_WOLF359StarInstance_Security : SecurityInstanceBase) {};
   new ScriptObject(Sector2_WOLF359StarInstance_Infrastructure : InfrastructureInstanceBase) {instanceTypeWL = "ColonyInstance";};
   new ScriptObject(Sector2_WOLF359StarInstance_Zombie : ZombieInstanceBase) {};
   
   
   //Gotta make a logical assignment func for these, so we get mining type instances in mining stars. 
   new ScriptObject(Sector2_WOLF359StarInstance_Random0 : RandomInstanceBase) {};
   new ScriptObject(Sector2_WOLF359StarInstance_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector2_WOLF359StarInstance_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector2_WOLF359StarInstance_Random3 : RandomInstanceBase) {creationChance = 0.66;};
   new ScriptObject(Sector2_WOLF359StarInstance_Random4 : RandomInstanceBase) {creationChance = 0.50;};

};

new ScriptGroup(Sector2_SIRIUSSystem : StarDatablockBase)
{      
   starNameOverride = "SIRIUS";
   starType = "SIRIUS";  
   starArtTypes = "SIRIUS_Special"; 

   new ScriptObject(Sector2_SIRIUSStarInstance_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector2_SIRIUSStarInstance_Security : SecurityInstanceBase) {};
   new ScriptObject(Sector2_SIRIUSStarInstance_Infrastructure : InfrastructureInstanceBase) {instanceTypeWL = "MiningInstance";};
   new ScriptObject(Sector2_SIRIUSStarInstance_Zombie : ZombieInstanceBase) {};
   
   
   //Gotta make a logical assignment func for these, so we get mining type instances in mining stars. 
   new ScriptObject(Sector2_SIRIUSStarInstance_Random0 : RandomInstanceBase) {};
   new ScriptObject(Sector2_SIRIUSStarInstance_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector2_SIRIUSStarInstance_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector2_SIRIUSStarInstance_Random3 : RandomInstanceBase) {creationChance = 0.66;};
   new ScriptObject(Sector2_SIRIUSStarInstance_Random4 : RandomInstanceBase) {creationChance = 0.50;};

};

new ScriptGroup(Sector2_LUYTENSystem : StarDatablockBase)
{      
   starNameOverride = "LUYTEN";
   starType = "LUYTEN";  
   starArtTypes = "LUYTEN_Special"; 

   new ScriptObject(Sector2_LUYTENStarInstance_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector2_LUYTENStarInstance_Security : SecurityInstanceBase) {};
   new ScriptObject(Sector2_LUYTENStarInstance_Infrastructure : InfrastructureInstanceBase) {instanceTypeWL = "ColonyInstance";};
   new ScriptObject(Sector2_LUYTENStarInstance_Zombie : ZombieInstanceBase) {};
   
   
   //Gotta make a logical assignment func for these, so we get mining type instances in mining stars. 
   new ScriptObject(Sector2_LUYTENStarInstance_Random0 : RandomInstanceBase) {};
   new ScriptObject(Sector2_LUYTENStarInstance_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector2_LUYTENStarInstance_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector2_LUYTENStarInstance_Random3 : RandomInstanceBase) {creationChance = 0.66;};
   new ScriptObject(Sector2_LUYTENStarInstance_Random4 : RandomInstanceBase) {creationChance = 0.50;};

};



//TODO: make the sec 2 stars in line with story.  for now are random,

new ScriptGroup(Sector2_CapacitorSystem : StarDatablockBase)
{      
   starType = "Sector2_Capacitor";  
   starArtTypes = "Red 10 Orange 10 Yellow 10 Green 10 Blue 10 Purple 10";
   
   //TODO: fill in with non random stuff
   new ScriptObject(Sector2_Capacitor_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector2_Capacitor_Security : SecurityInstanceBase) {};
   new ScriptObject(Sector2_Capacitor_Infrastructure : InfrastructureInstanceBase) {};
   
   //Gotta make a logical assignment func for these, so we get mining type instances in mining stars. 
   new ScriptObject(Sector2_Capacitor_Random0 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Capacitor_Random1 : RandomInstanceBase) {};
   
   //probably want to set special background and clouds here. 
   new ScriptObject(Sector2_CapacitorInstance : StarInstanceDatablockBase)
   {       
      instanceID   = "Random";  
      instanceName = "BATTLESHIP GRAVEYARD";        
      instanceTypeWL = "SI_S2_CapacitorInstance";     
      
      instancePosition = 1;    //must situated before the randomly created instances. 
      instancePlanetChance = 1;    
   };
   
   new ScriptObject(Sector2_Capacitor_Random2 : RandomInstanceBase) {creationChance = 0.66;};
   new ScriptObject(Sector2_Capacitor_Random3 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector2_Capacitor_Random4 : RandomInstanceBase) {creationChance = 0.30;};
   new ScriptObject(Sector2_Capacitor_Zombie : ZombieInstanceBase) {};
};

new ScriptGroup(Sector2_ReactorSystem : StarDatablockBase)
{      
   starType = "Sector2_Reactor";  
   starArtTypes = "Red 10 Orange 10 Yellow 10 Green 10 Blue 10 Purple 10";
   
   //TODO: fill in with non random stuff
   new ScriptObject(Sector2_Reactor_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector2_Reactor_Security : SecurityInstanceBase) {};
   new ScriptObject(Sector2_Reactor_Infrastructure : InfrastructureInstanceBase) {};
   
   //Gotta make a logical assignment func for these, so we get mining type instances in mining stars. 
   new ScriptObject(Sector2_Reactor_Random0 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Reactor_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Reactor_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Reactor_Random3 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Reactor_Random4 : RandomInstanceBase) {};
   
   //probably want to set special background and clouds here. 
   new ScriptObject(Sector2_RectorInstance : StarInstanceDatablockBase)
   {       
      instanceID   = "Random";  
      instanceName = "SECRET SCIENCE FACILITY";        
      instanceTypeWL = "SI_S2_ReactorInstance";     
      
      instancePosition = 8;    //must situated before the randomly created instances. 
      instancePlanetChance = 1;    
   };
   new ScriptObject(Sector2_Reactor_Zombie : ZombieInstanceBase) {};
};


new ScriptGroup(Sector2_ShipyardSystem : StarDatablockBase)
{      
   starType = "Sector2_Shipyard";  
   starArtTypes = "Red 10 Orange 10 Yellow 10 Green 10 Blue 10 Purple 10";
   
   //TODO: fill in with non random stuff
   new ScriptObject(Sector2_Shipyard_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector2_Shipyard_Security : SecurityInstanceBase) {};
   new ScriptObject(Sector2_Shipyard_Infrastructure : InfrastructureInstanceBase) {};
   
   //Gotta make a logical assignment func for these, so we get mining type instances in mining stars. 
   new ScriptObject(Sector2_Shipyard_Random0 : RandomInstanceBase) {};
      
   //probably want to set special background and clouds here. 
   
   new ScriptObject(Sector2_RoadBlockInstance : StarInstanceDatablockBase)
   {       
      instanceID   = "Random";  
      instanceName = "UTA Road Block";        
      instanceTypeWL = "SI_S2_ShipyardInstance";     
      
      instancePosition = 2;    //must situated before the randomly created instances. 
      instancePlanetChance = 1;    
   };   
   
   new ScriptObject(Sector2_ShipyardInstance : StarInstanceDatablockBase)
   {       
      instanceID   = "Random";  
      instanceName = "BLACK MARKET SHIPYARD";        
      instanceTypeWL = "SI_S2_ShipyardInstance";     
      
      instancePosition = 3;    //must situated before the randomly created instances. 
      instancePlanetChance = 1;    
   };
   
   new ScriptObject(Sector2_Shipyard_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Shipyard_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector2_Shipyard_Random3 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector2_Shipyard_Random4 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector2_Shipyard_Zombie : ZombieInstanceBase) {};
};

/////////////////////////////////////////////
// Sector 3 //////////////////////////////////
/////////////////////////////////////////////


new ScriptGroup(Sector3_UberColonySystem : StarDatablockBase)
{      
   starType = "Sector3_UberColony";  
   starArtTypes = "Red 10 Orange 10 Yellow 10 Green 10 Blue 10 Purple 10";
   
   //TODO: fill in with non random stuff
   new ScriptObject(Sector3_UberColony_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector3_UberColony_Security : SecurityInstanceBase) {};
   new ScriptObject(S3_UberColony_Infrastructure : InfrastructureInstanceBase) 
   {
      instanceTypeWL = "SI_S3_UberColony";
      instanceName = "COLONY HEADQUARTERS";
    
      instancePlanetChance   = 1;
    };
    
   new ScriptObject(Sector3_UberColony_Random0 : RandomInstanceBase) {};
        
   new ScriptObject(Sector3_UberColony_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector3_UberColony_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector3_UberColony_Random3 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector3_UberColony_Random4 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector3_UberColony_Zombie : ZombieInstanceBase) {};
};

new ScriptGroup(Sector3_UberMiningSystem : StarDatablockBase)
{      
   starType = "Sector3_UberMining";  
   starArtTypes = "Red 10 Orange 10 Yellow 10 Green 10 Blue 10 Purple 10";
   
   //TODO: fill in with non random stuff
   new ScriptObject(Sector3_UberMining_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector3_UberMining_Security : SecurityInstanceBase) {};
   new ScriptObject(S3_UberMining_Infrastructure : InfrastructureInstanceBase) 
   {
      instanceTypeWL = "SI_S3_UberMining";
      instanceName = "MINING HEADQUARTERS";
    
      instancePlanetChance   = 1;
   };
    
   new ScriptObject(Sector3_TradeRouteInstance : StarInstanceDatablockBase)
   {       
      instanceID   = "Random";  
      instanceName = "SHIP TRADE ROUTE";        
      instanceTypeWL = "SI_S3_TradeRouteInstance";     
      
      instancePosition = 5;    //must situated before the randomly created instances. 
      instancePlanetChance = 1;    
   };   
    
   new ScriptObject(Sector3_UberMining_Random0 : RandomInstanceBase) {};
        
   new ScriptObject(Sector3_UberMining_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector3_UberMining_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector3_UberMining_Random3 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector3_UberMining_Random4 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector3_UberMining_Zombie : ZombieInstanceBase) {};
};

new ScriptGroup(Sector3_UberScienceSystem : StarDatablockBase)
{      
   starType = "Sector3_UberScience";  
   starArtTypes = "Red 10 Orange 10 Yellow 10 Green 10 Blue 10 Purple 10";
   
   //TODO: fill in with non random stuff
   new ScriptObject(Sector3_UberScience_MHI : MothershipHideInstanceBase) {};  //Required
   new ScriptObject(Sector3_UberScience_Security : SecurityInstanceBase) {};
   new ScriptObject(S3_UberScience_Infrastructure : InfrastructureInstanceBase) 
   {
      instanceTypeWL = "SI_S3_UberScience";
      instanceName = "SCIENCE HEADQUARTERS";
    
      instancePlanetChance   = 1;
   };
    
   new ScriptObject(Sector3_PureRezInstance : StarInstanceDatablockBase)
   {       
      instanceID   = "Random";  
      instanceName = "PURE REZ DEPOSIT";        
      instanceTypeWL = "SI_S3_PureRezInstance";     
      
      instancePosition = 5;    //must situated before the randomly created instances. 
      instancePlanetChance = 1;    
   };      
    
    
   new ScriptObject(Sector3_UberScience_Random0 : RandomInstanceBase) {};
        
   new ScriptObject(Sector3_UberScience_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector3_UberScience_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector3_UberScience_Random3 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector3_UberScience_Random4 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector3_UberScience_Zombie : ZombieInstanceBase) {};
};

//////////////////////////////////////////////
// Sector 4 //////////////////////////////////
//////////////////////////////////////////////

new ScriptObject(Sector3_4_Connect_WarpgateInstance : WarpgateInstanceBase)
{   
   instanceName = "SECRET WARPGATE"; //name used for quest distribution
   instanceTypeWL = "Sector3_4_Connect_Warpgate"; 
};

new ScriptGroup(Sector3_4_ConnectSystem : StarDatablockBase)
{      
   starType = "Sector3_4_Connect";  
   starArtTypes = "Red 10 Orange 10 Yellow 10 Green 10 Blue 10";
   
   namedWGInstances["Sector4_ZombieHomestarSystem"] = "Sector3_4_Connect_WarpgateInstance";
   
   new ScriptObject(Sector3_4_Connect_MHI : MothershipHideInstanceBase) 
   {
      instanceTypeWL = "Sector3_4_Connect_MothershipHide";
      instancePlanetChance   = 1;
   };    
   
   new ScriptObject(Sector3_4_Connect_Sec : SecurityInstanceBase)
   {
      instanceTypeWL = "Sector3_4_Connect_Security";
      instanceName = "CORE GUARD ALPHA";
    
      instancePlanetChance   = 1;
   };
      
   new ScriptObject(Sector3_4_Connect_Infrastructure : InfrastructureInstanceBase) 
   {
      instanceTypeWL = "Sector3_4_Connect_Science";
      instanceName = "ADVANCED RESEARCH FACILITY";
    
      instancePlanetChance   = 1;
   };
   
    
   new ScriptObject(Sector3_4_Connect_Random0 : RandomInstanceBase) {};
        
   new ScriptObject(Sector3_4_Connect_Random1 : RandomInstanceBase) {};
   new ScriptObject(Sector3_4_Connect_Random2 : RandomInstanceBase) {};
   new ScriptObject(Sector3_4_Connect_Random3 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector3_4_Connect_Random4 : RandomInstanceBase) {creationChance = 0.50;};
   new ScriptObject(Sector3_4_Connect_Zombie : ZombieInstanceBase) {};
};

new ScriptObject(Sector4_ZombieHomestar_WarpgateInstance : WarpgateInstanceBase)
{   
   instanceTypeWL = "Sector4_ZombieHomestar_Warpgate"; 
};

new ScriptGroup(Sector4_ZombieHomestarSystem : StarDatablockBase)
{      
   starNameOverride = "BLACK HOLE";
   starType = "Sector4_ZombieHomestar";  
   starArtTypes = "BlackHole_Special";
   
   warpGateInstanceDatablockWL = "Sector4_ZombieHomestar_WarpgateInstance";
   
   new ScriptObject(Sector4_ZombieHomestar_MHI : MothershipHideInstanceBase) 
   {
      instanceTypeWL = "Sector4_ZombieHomestar_MothershipHide";    
      instancePlanetChance   = 0;      
   };
    
   new ScriptObject(Sector4_ZombieHomestar_Sec : SecurityInstanceBase)
   {
      instanceTypeWL = "Sector4_ZombieHomestar_Security"; //will auto hide 
      instancePlanetChance   = 0;      
   };
      
   new ScriptObject(Sector4_ZombieHomestar_Infra : InfrastructureInstanceBase) 
   {
      instanceTypeWL = "Sector4_ZombieHomestar_Infrastructure"; //will auto hide   
      instancePlanetChance   = 0;  
   };
   
   new ScriptObject(Sector4_ZombieHomestar_Zombie : ZombieInstanceBase) 
   {
      instanceTypeWL = "Sector4_ZombieHomestar_ZombieInstance"; //will auto hide                
      instancePlanetChance   = 0;  
   };
   
   new ScriptObject(Sector4_ZombieHomestar_AlienGate : StarInstanceDatablockBase)
   {       
      instanceID   = "AlienGate"; //This should prevent random quests from poppin in here.   
      instanceName = "Alien Gate";        
      instanceTypeWL = "AlienGateInstance";     
      
      instancePosition = 2;     
      instancePlanetChance = 1;    
   };   
     
};


new ScriptGroup(Sector4_ZombieBossFightSystem : StarDatablockBase)
{    
   starNameOverride = "UNKNOWN DIMENSION";
   starType     = "Sector4_ZombieBossFightStar"; 
   starArtTypes = "Zombie_Special"; 
    
   new ScriptObject(Sector4_ZombieBossFight_MHI : MothershipHideInstanceBase) 
   {
      instanceTypeWL = "Sector4_ZombieBossFight_MothershipHide";  
      instanceName = "Boss Fight";  //mission hook up
      
      instancePlanetChance = 1;
      instancePlanet         = "SI_S4_ZombiePlanet";
      instancePlanetOrbitals = "Moon_Small_Shatter_01";
      instancePlanetOrbitalCount = 1;
   };
    
   new ScriptObject(Sector4_ZombieBossFight_Sec : SecurityInstanceBase)
   {
      instanceTypeWL = "Sector4_ZombieBossFight_Security"; //will auto hide 
      instancePlanetChance   = 0;      
   };
      
   new ScriptObject(Sector4_ZombieBossFight_Infra : InfrastructureInstanceBase) 
   {
      instanceTypeWL = "Sector4_ZombieBossFight_Infrastructure"; //will auto hide   
      instancePlanetChance   = 0;  
   };
   
   new ScriptObject(Sector4_ZombieBossFight_Zombie : ZombieInstanceBase) 
   {
      instanceTypeWL = "Sector4_ZombieBossFight_ZombieInstance"; //will auto hide                
      instancePlanetChance   = 0;  
   };

};



///////////////////////////////////////////////////////////////
// FRONT END STAR /////////////////////////////////////////////
///////////////////////////////////////////////////////////////


if ( IDG() )
{
   new ScriptGroup(FrontEndStar : StarDatablockBase)
   {
      starType = "FRONTEND";
      starArtTypes = "Proxima_Special";
      
      new ScriptObject(FrontEndStar_MHI : MothershipHideInstanceBase) {};  
      
      new ScriptObject(FrontEndStar_Infrastructure : InfrastructureInstanceBase) 
      {
         instanceTypeWL = "FrontEndInstance";
         instancePlanetChance   = 1;
      };   
   };   
}
else
{
   new ScriptGroup(FrontEndStar : StarDatablockBase)
   {
      starType = "FRONTEND";
      starArtTypes = "Red 10 Orange 10 Yellow 10 Green 10 Blue 10 Purple 10"; //Type could also be a specific star like "Earth"

      
      new ScriptObject(FrontEndStar_MHI : MothershipHideInstanceBase) {};  
      
      new ScriptObject(FrontEndStar_Infrastructure : InfrastructureInstanceBase) 
      {
         instanceTypeWL = "FrontEndInstance";
         instancePlanetChance   = 1;
      };   
   };
}





