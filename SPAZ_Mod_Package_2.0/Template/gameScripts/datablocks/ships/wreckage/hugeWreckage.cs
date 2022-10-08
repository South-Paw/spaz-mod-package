
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Hammerhead
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_HammerHead_Left : ShipWreck_MetalBase_Cull_Huge)
{
   imageMap = "shipWreck_hammerHead_01ImageMap";   
   size = "288 192";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.422 -0.193 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.398 0.069 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.422 -0.193 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.398 0.069 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "288 192";    
      imageMap = "shipWreck_hammerHead_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "288 192";
      breachStates["Breach", "pulseSizeMax"]  = "288 192";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "288 192";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.422 -0.193 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.398 0.069 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "288 192";
      breachStates["Breach", "flickerSize", 1]    = "288 192";
      imageMap = "shipWreck_hammerHead_elec_01ImageMap";
   };     
};

new ScriptGroup(ShipWreck_HammerHead_Right : ShipWreck_MetalBase_Cull_Huge)
{
   wreckImpulseForce = "45 70"; 
   wreckAngularVelocityMult = -1.2;
   wreckMaxAngularVelocity = 15;
   
   imageMap = "shipWreck_hammerHead_02ImageMap";   
   size = "192 192";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.382 -0.309 0 0 0.7 0 0"; 

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.382 -0.309 0 0 0.4 750 2000";
       
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "192 192";    
      imageMap = "shipWreck_hammerHead_ember_02ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "192 192"; 
      breachStates["Breach", "pulseSizeMax"]  = "192 192";                
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {  
      size = "192 192";   
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.382 -0.309 0 0 1.5 0 0"; 
       
      breachStates["Breach", "flickerSize", 0]    = "192 192";
      breachStates["Breach", "flickerSize", 1]    = "192 192";
      imageMap = "shipWreck_hammerHead_elec_02ImageMap";    
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Star Cruiser
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Starcruiser_Top : ShipWreck_MetalBase_Cull_Huge)
{
   wreckImpulseForce = "45 70"; 
   wreckAngularVelocityMult = -1.2;
   wreckMaxAngularVelocity = 15;
   
   imageMap = "shipWreck_starCruiser_02ImageMap";   
   size = "192 192";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.168 -0.059 0 0 0.7 0 0"; 

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.168 -0.059 0 0 0.4 750 2000";
       
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "192 192";    
      imageMap = "shipWreck_starCruiser_ember_02ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "192 192"; 
      breachStates["Breach", "pulseSizeMax"]  = "192 192";                
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {  
      size = "192 192";   
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.168 -0.059 0 0 1.5 0 0"; 
       
      breachStates["Breach", "flickerSize", 0]    = "192 192";
      breachStates["Breach", "flickerSize", 1]    = "192 192";
      imageMap = "shipWreck_starCruiser_elec_02ImageMap";    
   };     
};

new ScriptGroup(ShipWreck_Starcruiser_Bottom : ShipWreck_MetalBase_Cull_Huge)
{
   imageMap = "shipWreck_starCruiser_01ImageMap";   
   size = "192 288";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.055 -0.481 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire -0.204 0.427 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.055 -0.481 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff -0.204 0.427 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "192 288";    
      imageMap = "shipWreck_starCruiser_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "192 288";
      breachStates["Breach", "pulseSizeMax"]  = "192 288";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "192 288";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.055 -0.481 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger -0.204 0.427 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "192 288";
      breachStates["Breach", "flickerSize", 1]    = "192 288";
      imageMap = "shipWreck_starCruiser_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// SUN SPOT
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_SunSpot_Left : ShipWreck_MetalBase_Cull_Huge)
{
   imageMap = "shipWreck_sunspot_01ImageMap";   
   size = "384 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.419 -0.614 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.335 0.584 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.419 -0.614 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.335 0.584 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "384 384";    
      imageMap = "shipWreck_sunspot_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "384 384";
      breachStates["Breach", "pulseSizeMax"]  = "384 384";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "384 384";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.419 -0.614 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.335 0.584 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "384 384";
      breachStates["Breach", "flickerSize", 1]    = "384 384";
      imageMap = "shipWreck_sunspot_elec_01ImageMap";
   };     
};

new ScriptGroup(ShipWreck_SunSpot_Right : ShipWreck_MetalBase_Cull_Huge)
{
   wreckImpulseForce = "45 70"; 
   wreckAngularVelocityMult = -1.2;
   wreckMaxAngularVelocity = 15;
   
   imageMap = "shipWreck_sunspot_02ImageMap";   
   size = "288 288";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.440 0.083 0 0 0.7 0 0"; 

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.440 0.083 0 0 0.4 750 2000";
       
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "288 288";    
      imageMap = "shipWreck_sunspot_ember_02ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "288 288"; 
      breachStates["Breach", "pulseSizeMax"]  = "288 288";                
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {  
      size = "288 288";   
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.440 0.083 0 0 1.5 0 0"; 
       
      breachStates["Breach", "flickerSize", 0]    = "288 288";
      breachStates["Breach", "flickerSize", 1]    = "288 288";
      imageMap = "shipWreck_sunspot_elec_02ImageMap";    
   };     
};


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// FREIGHTER
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Freighter_Top : ShipWreck_MetalBase_Cull_Huge)
{
   imageMap = "shipWreck_freighter_01ImageMap";   
   size = "144 192";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.510 -0.142 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire -0.307 0.579 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.510 -0.142 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff -0.307 0.579 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "144 192";    
      imageMap = "shipWreck_freighter_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "144 192";
      breachStates["Breach", "pulseSizeMax"]  = "144 192";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "144 192";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.510 -0.142 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger -0.307 0.579 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "144 192";
      breachStates["Breach", "flickerSize", 1]    = "144 192";
      imageMap = "shipWreck_freighter_elec_01ImageMap";
   };     
};

new ScriptGroup(ShipWreck_Freighter_Bottom : ShipWreck_MetalBase_Cull_Huge)
{
   wreckImpulseForce = "45 70"; 
   wreckAngularVelocityMult = -1.2;
   wreckMaxAngularVelocity = 15;
   
   imageMap = "shipWreck_freighter_02ImageMap";   
   size = "96 144";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.047 -0.540 0 0 0.7 0 0"; 

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.047 -0.540 0 0 0.4 750 2000";
       
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "96 144";    
      imageMap = "shipWreck_freighter_ember_02ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "96 144"; 
      breachStates["Breach", "pulseSizeMax"]  = "96 144";                
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {  
      size = "96 144";   
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.047 -0.540 0 0 1.5 0 0"; 
       
      breachStates["Breach", "flickerSize", 0]    = "96 144";
      breachStates["Breach", "flickerSize", 1]    = "96 144";
      imageMap = "shipWreck_freighter_elec_02ImageMap";    
   };     
};


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// CARRIER
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Carrier_Left : ShipWreck_MetalBase_Cull_Huge)
{
   imageMap = "shipWreck_carrier_01ImageMap";   
   size = "144 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.489 -0.594 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.419 0.525 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.489 -0.594 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.419 0.525 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "144 384";    
      imageMap = "shipWreck_carrier_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "144 384";
      breachStates["Breach", "pulseSizeMax"]  = "144 384";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "144 384";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.489 -0.594 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.419 0.525 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "144 384";
      breachStates["Breach", "flickerSize", 1]    = "144 384";
      imageMap = "shipWreck_carrier_elec_01ImageMap";
   };     
};


new ScriptGroup(ShipWreck_Carrier_Right : ShipWreck_MetalBase_Cull_Huge)
{
   wreckImpulseForce = "45 70"; 
   wreckAngularVelocityMult = -1.2;
   wreckMaxAngularVelocity = 15;
   
   imageMap = "shipWreck_carrier_02ImageMap";   
   size = "72 144";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.084 -0.147 0 0 0.7 0 0"; 

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.084 -0.147 0 0 0.4 750 2000";
       
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "72 144";    
      imageMap = "shipWreck_carrier_ember_02ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "72 144"; 
      breachStates["Breach", "pulseSizeMax"]  = "72 144";                
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {  
      size = "72 144";   
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.084 -0.147 0 0 1.5 0 0"; 
       
      breachStates["Breach", "flickerSize", 0]    = "72 144";
      breachStates["Breach", "flickerSize", 1]    = "72 144";
      imageMap = "shipWreck_carrier_elec_02ImageMap";    
   };     
};



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// BOUNTY HUGE 01
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_BountyHuge_01_Left : ShipWreck_MetalBase_Cull_Huge)
{
   imageMap = "shipWreck_bountyHuge_01_leftImageMap";   
   size = "192 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.073 -0.462 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.419 0.633 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.073 -0.462 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.419 0.633 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "192 384";    
      imageMap = "shipWreck_bountyHuge_01_left_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "192 384";
      breachStates["Breach", "pulseSizeMax"]  = "192 384";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "192 384";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.073 -0.462 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.419 0.633 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "192 384";
      breachStates["Breach", "flickerSize", 1]    = "192 384";
      imageMap = "shipWreck_bountyHuge_01_left_elecImageMap";
   };     
};


new ScriptGroup(ShipWreck_BountyHuge_01_Right : ShipWreck_MetalBase_Cull_Huge)
{
   wreckImpulseForce = "45 70"; 
   wreckAngularVelocityMult = -1.2;
   wreckMaxAngularVelocity = 15;
   
   imageMap = "shipWreck_bountyHuge_01_rightImageMap";   
   size = "192 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.073 -0.437 0 0 0.7 0 0"; 

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.073 -0.437 0 0 0.4 750 2000";
       
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "192 384";    
      imageMap = "shipWreck_bountyHuge_01_right_emberImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "192 384"; 
      breachStates["Breach", "pulseSizeMax"]  = "192 384";                
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {  
      size = "192 384";   
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.073 -0.437 0 0 1.5 0 0"; 
       
      breachStates["Breach", "flickerSize", 0]    = "192 384";
      breachStates["Breach", "flickerSize", 1]    = "192 384";
      imageMap = "shipWreck_bountyHuge_01_right_elecImageMap";    
   };     
};



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// BOUNTY HUGE 02
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_BountyHuge_02_Top : ShipWreck_MetalBase_Cull_Huge)
{
   imageMap = "shipWreck_bountyHuge_02_TopImageMap";   
   size = "256 192";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.599 -0.258 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire -0.133 0.184 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.599 -0.258 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff -0.133 0.184 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "256 192";    
      imageMap = "shipWreck_bountyHuge_02_Top_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "256 192";
      breachStates["Breach", "pulseSizeMax"]  = "256 192";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "256 192";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.599 -0.258 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger -0.133 0.184 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "256 192";
      breachStates["Breach", "flickerSize", 1]    = "256 192";
      imageMap = "shipWreck_bountyHuge_02_Top_elecImageMap";
   };     
};

new ScriptGroup(ShipWreck_BountyHuge_02_Bottom : ShipWreck_MetalBase_Cull_Huge)
{
   wreckImpulseForce = "45 70"; 
   wreckAngularVelocityMult = -1.2;
   wreckMaxAngularVelocity = 15;
   
   imageMap = "shipWreck_bountyHuge_02_BottomImageMap";   
   size = "256 256";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.189 -0.319 0 0 0.7 0 0"; 

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.189 -0.319 0 0 0.4 750 2000";
       
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "256 256";    
      imageMap = "shipWreck_bountyHuge_02_Bottom_emberImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "256 256"; 
      breachStates["Breach", "pulseSizeMax"]  = "256 256";                
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {  
      size = "256 256";   
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.189 -0.319 0 0 1.5 0 0"; 
       
      breachStates["Breach", "flickerSize", 0]    = "256 256";
      breachStates["Breach", "flickerSize", 1]    = "256 256";
      imageMap = "shipWreck_bountyHuge_02_elecImageMap";    
   };     
};





