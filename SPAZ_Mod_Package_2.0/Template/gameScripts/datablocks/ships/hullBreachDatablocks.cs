
function HullBreachComponent::GetStateData(%this, %state, %dataType, %subDataType)
{
   if ( %subDataType $= "" )
   {
      %data = %this.breachStates[%state, %dataType];
      if ( %data $= "" )
         %data = BreachDefualtStates.breachStates["Default", %dataType];
   }
   else
   {
      %data = %this.breachStates[%state, %dataType, %subDataType];
      if ( %data $= "" )
         %data = BreachDefualtStates.breachStates["Default", %dataType, %subDataType];      
   }
   
   return %data;   
}

function HullBreachComponent::ShouldChangeToState(%this, %state)
{
   %stateFilter = %this.breachStateFilter;
   if ( %stateFilter $= "" )
      return true;
      
   for ( %i = 0; %i < getWordCount(%stateFilter); %i++ )
   {
      %filterState = getWord(%stateFilter, %i);
      if ( %filterState $= %state )
         return true;      
   }   
   return false;
}





//suport states, which are effect based only
//walk the group and set state on each breach element.
//each piece of a breach 

//Spew is relative to ships current crew capacity. 
$HB_Spew_None   = 0;
$HB_Spew_Small  = 1;
$HB_Spew_Medium = 2;
$HB_Spew_Large  = 3;

$MaxSpew[$HB_Spew_None]  = 0;
$MaxSpew[$HB_Spew_Small]  = 0.10;
$MaxSpew[$HB_Spew_Medium] = 0.25;
$MaxSpew[$HB_Spew_Large]  = 0.50;

function GetMaxSpewPercent(%spewLevel)
{
   return $MaxSpew[%spewLevel];
}



new ScriptGroup(BreachBase)
{
   superClass = "HullBreachComponent";
   
   imageMap = "";  //Must define an image map. 
   size = "32 32";

   mountOffset = "0 0";  //default
   trackMountRotation = true;   //default
   mountRotationOffset = 0;
   creationChance = 1;  //default
   
   //State Handling
   initialState = "Default";  //Defualt state is special and is used if a sub breach component doesnt have anyhting defined for a state. 
      
   breachStateFilter = "";  //if "" then listen to all states, else listen only to states listed.

   breachStates["Repair", "breachVisible"]  = false;    
};

//Only need one of these to reference. 
new ScriptObject(BreachDefualtStates)
{   
   
   breachStates["Default", "nextStateWL"]   = "";  //examples
   breachStates["Default", "nextStateTime"] = 0;  //do not go to another state based on timer.  in MS
      
   //Spew
   breachStates["Default", "crewSpew"]  = $HB_Spew_None; 
   breachStates["Default", "cargoSpew"] = $HB_Spew_None;   
   
   //Color
   
   breachStates["Default", "breachVisible"]      = true;   
   breachStates["Default", "breachInitialColor"] = "";  //this is the color we snap to before doing any blending
   breachStates["Default", "isIntense"]          = false;
   breachStates["Default", "breachBlend"]        = "1 1 1 1"; //color we will apply to the breach.
   breachStates["Default", "breachBlendRate"]    = 0.02;  //good to keep it <= blend rate. too small is expensive
   breachStates["Default", "breachBlendEpsilon"] = 0.02;
   
   //Spin
   breachStates["Default", "shouldSpin"]    = false;
   breachStates["Default", "spinVelocity"]  = "-360 360";
   
   //Pulse
   breachStates["Default", "shouldPulse"]   = false;
   breachStates["Default", "pulseTime"]     = 1000;
   breachStates["Default", "pulseSizeMin"]  = "32 32";
   breachStates["Default", "pulseSizeMax"]  = "48 64";
   breachStates["Default", "pulseBlendMin"] = "1 1 1 1";
   breachStates["Default", "pulseBlendMax"] = "0.5 0.5 0 0.5";
   breachStates["Default", "pulseLinear"]   = false;  //use a sin wave pulse
        
   //Flicker
   breachStates["Default", "shouldFlicker"] = false;
   breachStates["Default", "randomFlicker"] = false;
   
   breachStates["Default", "flickerTime", 0]    = "1000 1500";
   breachStates["Default", "flickerBlend", 0]   = "1 1 1 1";
   breachStates["Default", "flickerSize", 0]    = "32 32";
   breachStates["Default", "flickerIntense", 0] = true;  
   
   breachStates["Default", "shouldDeleteSelf"] = false; //if a component is no longer needed, let it delete itself dor mem purposes.  
   breachStates["Default", "addToCullSetID"] = "";
     
   //Sound
   breachStates["Default", "soundCue"]    = "";
   
   
   //Effects  
   //breachEffects# = "EffectName OffestX OffsetY  EmissionRotation EmissionForce EffectScale MinMSTime MaxMSTime" if mintime and max time are 0 it will only play once.  good for constant effects like smoke 
   //IMPORTANT NOTE: you cannot mount effects that are part of a preload set since they are released from their
   //mount when they finish playing so someone else can use them.
   //This means Breach effects must not be preload Effects.
   
   breachStates["Default", "breachEffects", 0] = "";  //Nothing so stop looking
   //breachStates["Default", "breachEffects", 1] = "TinyThruster 0 1 180 100 0.25 0 0";
   
   breachStates["Default", "breachDebris", 0]  = "";  //ClusterID ClusterChance ClusterEjectionForce
};


////////////////////////////////////////////////////////////////////////////////////////////
// COMMON BREACH COMPONENTS
////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(BreachGlowDefault : BreachBase)
{   
   breachStateFilter = "Breach Repair";       
       
   imageMap = "reactor_wispImageMap";     
   size = "64 64";
       
   breachStates["Breach", "isIntense"]     = true;
   breachStates["Breach", "breachBlend"]   = "1 1 1 1";
   breachStates["Breach", "shouldPulse"]   = true;
   breachStates["Breach", "pulseTime"]     = "2000";
   breachStates["Breach", "pulseSizeMin"]  = "64 64";
   breachStates["Breach", "pulseSizeMax"]  = "92 92";
   breachStates["Breach", "pulseBlendMin"] = "1 0.4 0.2 0.3";
   breachStates["Breach", "pulseBlendMax"] = "1 0.4 0.2 0.6";
   breachStates["Breach", "pulseLinear"]   = false;      
 
};

new ScriptGroup(BreachEmberDefault : BreachBase)
{    
   breachStateFilter = "Breach Repair";    
      
   imageMap = "hullHole_small_ember_01ImageMap";     
   size = "32 32"; 
   
      
   breachStates["Breach", "isIntense"]     = true;
   breachStates["Breach", "breachBlend"]   = "1 1 1 1";
   
   breachStates["Breach", "shouldPulse"]   = true;
   breachStates["Breach", "pulseTime"]     = "1000 2255";   //added getrandomfromPair for variance if overlapping embers
   breachStates["Breach", "pulseSizeMin"]  = "32 32";
   breachStates["Breach", "pulseSizeMax"]  = "32 32";
   breachStates["Breach", "pulseBlendMin"] = "1 1 1 0.3";
   breachStates["Breach", "pulseBlendMax"] = "1 1 1 0.75";     
   breachStates["Breach", "pulseLinear"]   = false;       
  
};

new ScriptGroup(BreachElectricsDefault : BreachBase) //huge spicific doodad
{    
   breachStateFilter = "Breach Repair";    
      
   imageMap = "hullHole_huge_elec_01ImageMap";     
   size = "48 48"; 
   
   
   breachStates["Breach", "shouldFlicker"] = true;
   
   breachStates["Breach", "flickerTime", 0]    = "200 1000";
   breachStates["Breach", "flickerBlend", 0]   = "0 0 0 0";
   breachStates["Breach", "flickerSize", 0]    = "64 64";
   breachStates["Breach", "flickerIntense", 0] = true;   
   
   breachStates["Breach", "flickerTime", 1]    = "10 15";
   breachStates["Breach", "flickerBlend", 1]   = "1 1 1 1";
   breachStates["Breach", "flickerSize", 1]    = "64 64";
   breachStates["Breach", "flickerIntense", 1] = true;    
     
};

new ScriptGroup(BreachRepairDefault : BreachBase) //huge spicific doodad
{    
   breachStateFilter = "Breach Repair";   
      
   imageMap = "hullHole_tiny_patch_01ImageMap";     
   size = "64 64"; 
      
   breachStates["Breach", "breachVisible"]      = false; 
   breachStates["Breach", "breachInitialColor"] = "0.25 0.25 0.25 1"; 
   
   breachStates["Repair", "breachBlend"]   = "1 1 1 0.3";
   breachStates["Repair", "breachVisible"]      = true; 
   breachStates["Repair", "breachEffects", 0]   = "repairEffect 0 0 0 0 1 0 0";  //want it to only play once, puff! 
   //TODO: spawn some debris here, cold debris, so it looks like the wreckage was scraped off
};


////////////////////////////////////////////////////////////////////////////////////////////
// TINY BREACH
////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(TinyBreach_Base : BreachBase)
{
   imageMap = "hullHole_tiny_01ImageMap";   
   size = "16 16";  
   
   //mountRotationOffset = 180;  //upside down   
   
   initialState = "Breach";  //will set the state on all children
   
   //Breach
   breachStates["Breach", "nextStateWL"]       = "HeavyBurn";  //Only works on Root Components
   breachStates["Breach", "nextStateTime"]     = "100 120";   //Only works on Root Components
   breachStates["Breach", "breachEffects", 0]  = "explosivePuff 0 0 0 0 0.4 0 0";
   breachStates["Breach", "breachDebris", 0]   = "DC_Combat_Small_Light 0.75 25";

   //HeavyBurn
   breachStates["HeavyBurn", "nextStateWL"]   = "LightBurn";  
   breachStates["HeavyBurn", "nextStateTime"] = "1000 1500";  
   breachStates["HeavyBurn", "breachEffects", 0]  = "hullBreach 0 0 0 0 1 0 0"; 
   breachStates["HeavyBurn", "breachEffects", 1]  = "hullVent 0 0 0 0 0.8 0 0"; 
   
   //LightBurn
   breachStates["LightBurn", "nextStateWL"]   = "Extinguish";
   breachStates["LightBurn", "nextStateTime"] = "2000 2500";
   breachStates["LightBurn", "breachEffects", 0]  = "hullVent 0 0 0 0 1 0 0";
      
   //Extinguish
   breachStates["Extinguish", "nextStateWL"]   = "";  
   breachStates["Extinguish", "nextStateTime"] = "0";
   breachStates["Extinguish", "breachEffects", 0]  = "hullElecPuff 0 0 0 0 0.3 750 2000"; 
};

new ScriptGroup(TinyBreach_01 : TinyBreach_Base)
{
   imageMap = "hullHole_tiny_01ImageMap";   
   size = "16 16";     
   initialState = "Breach";
   new ScriptGroup(ScarEmbers : BreachEmberDefault)
   {          
      imageMap = "hullHole_tiny_ember_01ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "16 16";
      breachStates["Breach", "pulseSizeMax"]  = "16 16";     
   };   
   
   new ScriptGroup(ScarGlow : BreachGlowDefault)
   {         
      imageMap = "reactor_wispImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "32 32";
      breachStates["Breach", "pulseSizeMax"]  = "40 40";
   }; 
   
   new ScriptGroup(RepairPatch : BreachRepairDefault)
   {         
      imageMap = "hullHole_tiny_patch_01ImageMap";     
      size = "16 16";  
   }; 
};



////////////////////////////////////////////////////////////////////////////////////////////
// SMALL BREACH
////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(SmallBreach_Base : BreachBase)
{
   imageMap = "hullHole_small_01ImageMap";   
   size = "32 32"; 
      
   //mountRotationOffset = 180;  //upside down   
   
   initialState = "Breach";  //will set the state on all children
   
   //Breach
   breachStates["Breach", "nextStateWL"]   = "HeavyBurn";  //Only works on Root Components
   breachStates["Breach", "nextStateTime"] = "100 120";   //Only works on Root Components
   breachStates["Breach", "breachEffects", 0]  = "explosivePuff 0 0 0 0 0.5 0 0";
   breachStates["Breach", "breachDebris", 0]   = "DC_Combat_Small_Heavy 1 35";

   //HeavyBurn
   breachStates["HeavyBurn", "nextStateWL"]   = "LightBurn";  
   breachStates["HeavyBurn", "nextStateTime"] = "2000 3000";  
   breachStates["HeavyBurn", "breachEffects", 0]  = "hullBreach 0 0 0 0 2 0 0"; 
   breachStates["HeavyBurn", "breachEffects", 1]  = "hullVent 0 0 0 0 1.6 0 0"; 
   
   //LightBurn
   breachStates["LightBurn", "nextStateWL"]   = "Extinguish";
   breachStates["LightBurn", "nextStateTime"] = "5000 6000";
   breachStates["LightBurn", "breachEffects", 0]  = "hullVent 0 0 0 0 1.6 0 0";
   
   breachStates["LightBurn", "crewSpew"] = $HB_Spew_Small; 
   breachStates["LightBurn", "cargoSpew"] = $HB_Spew_Small;  
   
   //Extinguish
   breachStates["Extinguish", "nextStateWL"]   = "";  
   breachStates["Extinguish", "nextStateTime"] = "0";
   breachStates["Extinguish", "breachEffects", 0]  = "hullPurgeSmall 0 0 0 0 0.8 1500 2200";
   breachStates["Extinguish", "breachEffects", 1]  = "hullElecPuff 0 0 0 0 0.5 1000 3000"; 
};

new ScriptGroup(SmallBreach_01 : SmallBreach_Base)
{
   imageMap = "hullHole_small_01ImageMap";   
   size = "32 32";     
   initialState = "Breach";
   new ScriptGroup(ScarEmbers : BreachEmberDefault)
   {          
      imageMap = "hullHole_small_ember_01ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "32 32";
      breachStates["Breach", "pulseSizeMax"]  = "32 32";    
   };   
   
   new ScriptGroup(ScarGlow : BreachGlowDefault)
   {         
      imageMap = "reactor_wispImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "64 64";
      breachStates["Breach", "pulseSizeMax"]  = "70 70";
   }; 
   
   new ScriptGroup(RepairPatch : BreachRepairDefault)
   {         
      imageMap = "hullHole_small_patch_01ImageMap";     
      size = "32 32";     
   }; 
};

new ScriptGroup(SmallBreach_Glass_01 : SmallBreach_Base)
{
   imageMap = "hullHole_small_glass_01ImageMap";   
   size = "32 32";     
   initialState = "Breach";
   
   new ScriptGroup(RepairPatch : BreachRepairDefault)
   {         
      imageMap = "hullHole_small_glass_patch_01ImageMap";     
      size = "32 32";     
   }; 
};

////////////////////////////////////////////////////////////////////////////////////////////
// HUGE BREACH
////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(HugeBreach_Base : BreachBase)
{
   imageMap = "hullHole_huge_01ImageMap";   
   size = "48 48";  
   
   //mountRotationOffset = 180;  //upside down   
   
   initialState = "Breach";  //will set the state on all children
   
   //Breach
   breachStates["Breach", "nextStateWL"]   = "HeavyBurn";  //Only works on Root Components
   breachStates["Breach", "nextStateTime"] = "100 120";   //Only works on Root Components
   breachStates["Breach", "breachEffects", 0]  = "explosivePuff 0 0 0 0 0.6 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullVent 0 0 0 0 2 0 0"; 
   breachStates["Breach", "breachDebris", 0]   = "DC_HullBreach_Small 1 50";
   breachStates["Breach", "breachDebris", 1]   = "DC_Combat_Small_Heavy 0.5 35";
   breachStates["Breach", "breachDebris", 2]   = "DC_Combat_Small_Light 0.25 25";

   //HeavyBurn
   breachStates["HeavyBurn", "nextStateWL"]   = "LightBurn";  
   breachStates["HeavyBurn", "nextStateTime"] = "2000 3000";
   breachStates["HeavyBurn", "breachEffects", 0]  = "explosivePuff 0.2 0 0 0 0.35 0 0";  
   breachStates["HeavyBurn", "breachEffects", 1]  = "hullBreach 0 0 0 0 2.5 0 0"; 
   breachStates["HeavyBurn", "breachEffects", 2]  = "hullVent 0 0 0 0 2 0 0"; 
   breachStates["HeavyBurn", "breachEffects", 3]  = "hullVent 0.3 0.2 0 0 1.8 0 0";
   
   //LightBurn
   breachStates["LightBurn", "nextStateWL"]   = "Blowout";
   breachStates["LightBurn", "nextStateTime"] = "10000 15000";
   breachStates["LightBurn", "breachEffects", 0]  = "explosivePuff 0 -0.4 0 0 0.4 0 0";
   breachStates["LightBurn", "breachEffects", 1]  = "hullVent 0 0 0 0 2 0 0";
   breachStates["LightBurn", "breachEffects", 2]  = "hullVent -0.2 0.1 0 0 1.8 0 0"; 
   
   breachStates["LightBurn", "crewSpew"] = $HB_Spew_Large; 
   breachStates["LightBurn", "cargoSpew"] = $HB_Spew_Large;  
   
   //Blowout
   breachStates["Blowout", "nextStateWL"]   = "Extinguish";
   breachStates["Blowout", "nextStateTime"] = "400 500";
   breachStates["Blowout", "breachEffects", 0]  = "explosivePuff 0 0 0 0 0.4 0 0";
   breachStates["Blowout", "breachEffects", 1]  = "hullFire 0 0 0 0 1.3 0 0";  
   
   //Extinguish
   breachStates["Extinguish", "nextStateWL"]   = "";     
   breachStates["Extinguish", "nextStateTime"] = "";
   breachStates["Extinguish", "breachEffects", 0]  = "hullPurgeHuge 0 0 0 0 1.6 3000 4500";
   breachStates["Extinguish", "breachEffects", 1]  = "hullElecPuff 0 0 0 0 0.7 1500 4500"; 
};

new ScriptGroup(HugeBreach_01 : HugeBreach_Base)
{
   imageMap = "hullHole_huge_01ImageMap";   
   size = "48 48";     
   initialState = "Breach";
   new ScriptGroup(ScarEmbers : BreachEmberDefault)
   {          
      imageMap = "hullHole_huge_ember_01ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "48 48";
      breachStates["Breach", "pulseSizeMax"]  = "48 48 ";   
   };   
   
   new ScriptGroup(ScarGlow : BreachGlowDefault)
   {         
      imageMap = "reactor_wispImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "128 128";
      breachStates["Breach", "pulseSizeMax"]  = "142 142"; 
   };
   
   new ScriptGroup(ScarElec : BreachElectricsDefault)
   {            
      imageMap = "hullHole_huge_elec_01ImageMap";     
   };
   
   new ScriptGroup(RepairPatch : BreachRepairDefault)
   {         
      imageMap = "hullHole_huge_patch_01ImageMap";     
      size = "48 48";    
   }; 
};


new ScriptGroup(HugeBreach_02 : HugeBreach_Base)
{
   imageMap = "hullHole_huge_02ImageMap";   
   size = "48 48";     
   initialState = "Breach";
   new ScriptGroup(ScarEmbers : BreachEmberDefault)
   {           
      imageMap = "hullHole_huge_ember_02ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "48 48";
      breachStates["Breach", "pulseSizeMax"]  = "48 48 ";   
   };   
   
   new ScriptGroup(ScarGlow : BreachGlowDefault)
   {          
      imageMap = "reactor_wispImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "128 128";
      breachStates["Breach", "pulseSizeMax"]  = "142 142"; 
   };
   
   new ScriptGroup(ScarElec : BreachElectricsDefault)
   {           
      imageMap = "hullHole_huge_elec_02ImageMap";     
   };
   
   new ScriptGroup(RepairPatch : BreachRepairDefault)
   {         
      imageMap = "hullHole_huge_patch_02ImageMap";     
      size = "48 48";    
   }; 
};

new ScriptGroup(HugeBreach_Glass_01 : HugeBreach_Base)
{
   imageMap = "hullHole_huge_glass_01ImageMap";   
   size = "48 48";     
   initialState = "Breach";
   
   new ScriptGroup(RepairPatch : BreachRepairDefault)
   {         
      imageMap = "hullHole_huge_glass_patch_01ImageMap";     
      size = "48 48";    
   }; 
};

////////////////////////////////////////////////////////////////////////////////////////////
// ZOMBIE BREACH BREACH
////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Zombie_SmallBreach_01 : BreachBase)
{
   imageMap = "hullHole_zombie_small_01ImageMap";   
   size = "32 32";     
   initialState = "Breach";
   
   //Breach
   breachStates["Breach", "nextStateWL"]   = "Bleed";
   breachStates["Breach", "nextStateTime"] = "100 120";
   breachStates["Breach", "breachEffects", 0]  = "zombiePuke 0 0 0 0 1 0 0";
   breachStates["Breach", "breachEffects", 0]  = "hullBleed 0 0 0 0 2 0 0"; 
   breachStates["Breach", "breachDebris", 0]   = "DC_Combat_Small_Light_Zombie 1 25";

   //Bleed
   breachStates["Bleed", "nextStateWL"]   = "Extinguish";  
   breachStates["Bleed", "nextStateTime"] = "3000 4500";  
   breachStates["Bleed", "breachEffects", 0]  = "hullBleed 0 0 0 0 1 0 0"; 
      
   //Extinguish
   breachStates["Extinguish", "nextStateWL"]   = "";  
   breachStates["Extinguish", "nextStateTime"] = "0";
   breachStates["Extinguish", "breachEffects", 0]  = "hullBleed 0 0 0 0 0.65 4000 6500"; 
};

new ScriptGroup(Zombie_HugeBreach_01 : BreachBase)
{
   imageMap = "hullHole_zombie_huge_01ImageMap";   
   size = "64 64";     
   initialState = "Breach";
   
   //Breach
   breachStates["Breach", "nextStateWL"]   = "Bleed";
   breachStates["Breach", "nextStateTime"] = "100 120";
   breachStates["Breach", "breachEffects", 0]  = "zombiePuke 0 0 0 0 1 0 0";
   breachStates["Breach", "breachEffects", 0]  = "hullBleed 0 0 0 0 3.5 0 0"; 
   breachStates["Breach", "breachDebris", 0]   = "DC_Combat_Small_Heavy_Zombie 1 50";
   breachStates["Breach", "breachDebris", 1]   = "DC_Combat_Small_Light_Zombie 0.5 35";
   breachStates["Breach", "breachDebris", 2]   = "DC_Combat_Small_Light_Zombie 0.25 25";

   //Bleed
   breachStates["Bleed", "nextStateWL"]   = "Extinguish";  
   breachStates["Bleed", "nextStateTime"] = "3000 4500";  
   breachStates["Bleed", "breachEffects", 0]  = "hullBleed 0 0 0 0 2 0 0"; 
      
   //Extinguish
   breachStates["Extinguish", "nextStateWL"]   = "";  
   breachStates["Extinguish", "nextStateTime"] = "0";
   breachStates["Extinguish", "breachEffects", 0]  = "hullBleed 0 0 0 0 1 4000 6500"; 
};


/////////////////////////////////////////////////////////////////////////////////////////////////
// Hull Breach Sets /////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////
//move to hull breach datablocks later
function HullBreachSet::OnAdd(%this)
{  
   if ( %this.getName() $= "HullBreachSet" )
      return;
      
   %this.breachWL = createEfficientWeightedList(%this.breachWL);   
}

function HullBreachSet::GetBreachDatablock(%this)
{
   return getRandomWeightedWord(%this.breachWL);
}

new ScriptObject(HullBreachSetBase )
{
   class = "HullBreachSet";   
};

//HUMAN SETS//

new ScriptObject(BreachSet_Tiny : HullBreachSetBase )
{
   breachWL = "TinyBreach_01";   
};

new ScriptObject(BreachSet_Small : HullBreachSetBase )
{
   breachWL = "SmallBreach_01";   
};

new ScriptObject(BreachSet_Small_Glass : HullBreachSetBase )
{
   breachWL = "SmallBreach_Glass_01";   
};

new ScriptObject(BreachSet_Huge : HullBreachSetBase )
{
   breachWL = "HugeBreach_01 10 HugeBreach_02 10";   
};

new ScriptObject(BreachSet_Huge_Glass : HullBreachSetBase )
{
   breachWL = "HugeBreach_Glass_01";   
};

//ZOMBIE SETS//

new ScriptObject(BreachSet_Small_Zombie : HullBreachSetBase )
{
   breachWL = "Zombie_SmallBreach_01";   
};

new ScriptObject(BreachSet_Huge_Zombie : HullBreachSetBase )
{
   breachWL = "Zombie_HugeBreach_01";   
};





////////////////////////////////////////////////////////////////////////////////////////////
// BIG OL EXAMPLE CASE
////////////////////////////////////////////////////////////////////////////////////////////

/*

//Remember to auto add breaches to sim sets for automatic selection based on size
new ScriptGroup(SmallBreach_01 : BreachBase)
{
   imageMap = "hullHole_01ImageMap";   
   size = "32 32";     
   
   initialState = "Breach";  //will set the state on all children
   
   //Breach
   breachStates["Breach", "nextStateWL"]   = "HeavyBurn";  //Only works on Root Components
   breachStates["Breach", "nextStateTime"] = "5000 5000";   //Only works on Root Components
   
   breachStates["Breach", "breachEffects", 0]  = "sparks 0.5 0.5 0 0 1 100 300";
   breachStates["Breach", "breachEffects", 1]  = "sparks -0.5 -0.5 0 0 1 100 300";
   breachStates["Breach", "breachEffects", 2]  = "sparks 0.5 -0.5 0 0 1 100 300";
   breachStates["Breach", "breachEffects", 3]  = "sparks -0.5 0.5 0 0 1 100 300";
      
   //HeavyBurn
   breachStates["HeavyBurn", "nextStateWL"]   = "LightBurn";  
   breachStates["HeavyBurn", "nextStateTime"] = "5000 8000";  
   breachStates["HeavyBurn", "crewSpew"]      = $HB_Spew_Large;   
   breachStates["HeavyBurn", "cargoSpew"]     = $HB_Spew_Small;   

   
   breachStates["HeavyBurn", "shouldFlicker"] = true;
   
   breachStates["HeavyBurn", "flickerTime", 0]    = "1000 1500";
   breachStates["HeavyBurn", "flickerBlend", 0]   = "0.5 0 0 1";
   breachStates["HeavyBurn", "flickerSize", 0]    = "32 32";
   breachStates["HeavyBurn", "flickerIntense", 0] = false;   
   
   breachStates["HeavyBurn", "flickerTime", 1]    = "1000 1500";
   breachStates["HeavyBurn", "flickerBlend", 1]   = "1 0 0 1";
   breachStates["HeavyBurn", "flickerSize", 1]    = "32 32";
   breachStates["HeavyBurn", "flickerIntense", 1] = false;   
   
   //LightBurn
   breachStates["LightBurn", "nextStateWL"]   = "LightBurn 10 Extinguish 10";  //recalls itself which is legal
   breachStates["LightBurn", "nextStateTime"] = "2000 5000";
   breachStates["LightBurn", "crewSpew"]      = $HB_Spew_Small;   
   
   breachStates["LightBurn", "breachEffects", 0]  = "smokePuff 0.5 0.5 0 0 1 100 300";
   breachStates["LightBurn", "breachEffects", 1]  = "smokePuff -0.5 -0.5 0 0 1 100 300";
   breachStates["LightBurn", "breachEffects", 2]  = "smokePuff 0.5 -0.5 0 0 1 100 300";
   breachStates["LightBurn", "breachEffects", 3]  = "smokePuff -0.5 0.5 0 0 1 100 300";
   
   //Extinguish
   breachStates["Extinguish", "nextStateWL"]   = "";  
   breachStates["Extinguish", "nextStateTime"] = 0;  //just stay in this state unless changed externally
   
   new ScriptGroup(ScarEmbers : BreachBase)
   {         
      imageMap = "hullHole_01_emberImageMap";     
      size = "32 32"; 
      breachStateFilter = "Breach HeavyBurn LightBurn";  //no extinguish
      
      //Breach
      breachStates["Breach", "isIntense"]        = false;
      breachStates["Breach", "breachBlend"]      = "1 1 1 0";  //invisible while explosion is happening
  
      //HeavyBurn
      breachStates["HeavyBurn", "isIntense"]     = true;
      breachStates["HeavyBurn", "breachBlend"]   = "1 1 1 1";  
         
      breachStates["HeavyBurn", "shouldPulse"]   = true;
      breachStates["HeavyBurn", "pulseTime"]     = "500 1000"; //get random from pair
      breachStates["HeavyBurn", "pulseSizeMin"]  = "32 32";
      breachStates["HeavyBurn", "pulseSizeMax"]  = "32 32";
      breachStates["HeavyBurn", "pulseBlendMin"] = "1 1 1 1";
      breachStates["HeavyBurn", "pulseBlendMax"] = "1 0.5 0.5 0.5";
      breachStates["HeavyBurn", "pulseLinear"]   = false;  
               
      //LightBurn
      breachStates["LightBurn", "isIntense"]     = true;
      breachStates["LightBurn", "breachBlend"]   = "0.8 0.4 0.4 0.6";
      
      breachStates["LightBurn", "shouldPulse"]   = true;
      breachStates["LightBurn", "pulseTime"]     = "500 1000";
      breachStates["LightBurn", "pulseSizeMin"]  = "32 32";
      breachStates["LightBurn", "pulseSizeMax"]  = "32 32";
      breachStates["LightBurn", "pulseBlendMin"] = "0.8 0.4 0.4 0.6";
      breachStates["LightBurn", "pulseBlendMax"] = "0.8 0.4 0.4 0.2";
      breachStates["LightBurn", "pulseLinear"]   = false;  
  
                 
      new ScriptGroup(SubEmbers : BreachBase)
      {         
         imageMap = "hullHole_01_emberImageMap";     
         size = "24 24"; 
         mountRotationOffset = 180;  //upside down
               
          //Breach
         breachStates["Breach", "isIntense"]        = false;
         breachStates["Breach", "breachBlend"]      = "1 1 1 0";  //invisible while explosion is happening
     
         //HeavyBurn
         breachStates["HeavyBurn", "isIntense"]     = true;
         breachStates["HeavyBurn", "breachBlend"]   = "1 1 1 1";  
            
         breachStates["HeavyBurn", "shouldPulse"]   = true;
         breachStates["HeavyBurn", "pulseTime"]     = "200 400"; //get random from pair
         breachStates["HeavyBurn", "pulseSizeMin"]  = "24 24"; 
         breachStates["HeavyBurn", "pulseSizeMax"]  = "24 24"; 
         breachStates["HeavyBurn", "pulseBlendMin"] = "1 1 1 1";
         breachStates["HeavyBurn", "pulseBlendMax"] = "1 0.5 0.5 0.5";
         breachStates["HeavyBurn", "pulseLinear"]   = false;  
                  
         //LightBurn
         breachStates["LightBurn", "isIntense"]     = true;
         breachStates["LightBurn", "breachBlend"]   = "0.8 0.4 0.4 0.6";
         
         breachStates["LightBurn", "shouldPulse"]   = true;
         breachStates["LightBurn", "pulseTime"]     = "200 400"; 
         breachStates["LightBurn", "pulseSizeMin"]  = "24 24"; 
         breachStates["LightBurn", "pulseSizeMax"]  = "24 24"; 
         breachStates["LightBurn", "pulseBlendMin"] = "0.8 0.4 0.4 0.6";
         breachStates["LightBurn", "pulseBlendMax"] = "0.8 0.4 0.4 0.2";
         breachStates["LightBurn", "pulseLinear"]   = false;  
     
         //Extinguish
         breachStates["Extinguish", "isIntense"]    = false;
         breachStates["Extinguish", "breachBlend"]  = "1 1 1 0";       
      };   
      new ScriptGroup(SpinningEmbers1 : BreachBase)
      {         
         imageMap = "hullHole_01_emberImageMap";     
         size = "12 12";   
         trackMountRotation = false;  //IMPORTANT IF YOU WANT SOMETHING TO SPIN       
               
          //Breach
         breachStates["Breach", "isIntense"]        = false;
         breachStates["Breach", "breachBlend"]      = "1 1 1 0";  //invisible while explosion is happening
     
         //HeavyBurn
         breachStates["HeavyBurn", "isIntense"]     = true;
         breachStates["HeavyBurn", "breachBlend"]   = "1 1 1 1";  
            
         breachStates["HeavyBurn", "shouldPulse"]   = true;
         breachStates["HeavyBurn", "pulseTime"]     = "100 200"; //get random from pair
         breachStates["HeavyBurn", "pulseSizeMin"]  = "12 12"; 
         breachStates["HeavyBurn", "pulseSizeMax"]  = "12 12";  
         breachStates["HeavyBurn", "pulseBlendMin"] = "1 1 1 1";
         breachStates["HeavyBurn", "pulseBlendMax"] = "1 0 0 0.25";
         breachStates["HeavyBurn", "pulseLinear"]   = true;  
         
         breachStates["HeavyBurn", "shouldSpin"]    = true;
         breachStates["HeavyBurn", "spinVelocity"]  = "-90 -30";
                  
         //LightBurn
         breachStates["LightBurn", "isIntense"]     = false;
         breachStates["LightBurn", "breachBlend"]   = "1 1 1 0";      
         
             
         //Extinguish
         breachStates["Extinguish", "isIntense"]    = false;
         breachStates["Extinguish", "breachBlend"]  = "1 1 1 0";       
      };         
      new ScriptGroup(SpinningEmbers2 : BreachBase)
      {         
         imageMap = "hullHole_01_emberImageMap";     
         size = "16 16";   
         trackMountRotation = false;  //IMPORTANT IF YOU WANT SOMETHING TO SPIN       
               
          //Breach
         breachStates["Breach", "isIntense"]        = false;
         breachStates["Breach", "breachBlend"]      = "1 1 1 0";  //invisible while explosion is happening
     
         //HeavyBurn
         breachStates["HeavyBurn", "isIntense"]     = true;
         breachStates["HeavyBurn", "breachBlend"]   = "1 1 1 1";  
            
         breachStates["HeavyBurn", "shouldPulse"]   = true;
         breachStates["HeavyBurn", "pulseTime"]     = "100 200"; //get random from pair
         breachStates["HeavyBurn", "pulseSizeMin"]  = "16 16"; 
         breachStates["HeavyBurn", "pulseSizeMax"]  = "16 16";  
         breachStates["HeavyBurn", "pulseBlendMin"] = "1 1 1 1";
         breachStates["HeavyBurn", "pulseBlendMax"] = "1 0 0 0.25";
         breachStates["HeavyBurn", "pulseLinear"]   = true;  
         
         breachStates["HeavyBurn", "shouldSpin"]    = true;
         breachStates["HeavyBurn", "spinVelocity"]  = "30 90";
                  
         //LightBurn
         breachStates["LightBurn", "isIntense"]     = false;
         breachStates["LightBurn", "breachBlend"]   = "1 1 1 0";      
         
             
         //Extinguish
         breachStates["Extinguish", "isIntense"]    = false;
         breachStates["Extinguish", "breachBlend"]  = "1 1 1 0";       
      };         
   };   
      
   
   //Note: there can be multiple children with their own creation chances.  just not bothering for the demo one
};
*/








