
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// CLOCKWORK
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Clockwork_Top : ShipWreck_MetalBase)
{
   wreckImpulseForce = "45 70"; 
   wreckAngularVelocityMult = -1.2;
   wreckMaxAngularVelocity = 15;
   
   imageMap = "shipWreck_clockwork_01ImageMap";   
   size = "512 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.133 -0.147 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.236 0.338 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.133 -0.147 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.236 0.338 0 0 0.4 750 2000";
       
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "512 384";    
      imageMap = "shipWreck_clockwork_ember_01ImageMap";     
      breachStates["Breach", "pulseSizeMin"]  = "512 384"; 
      breachStates["Breach", "pulseSizeMax"]  = "512 384";                
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {  
      size = "512 384";   
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.133 -0.147 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.236 0.338 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "512 384";
      breachStates["Breach", "flickerSize", 1]    = "512 384";
      imageMap = "shipWreck_clockwork_elec_01ImageMap";    
   };     
};

new ScriptGroup(ShipWreck_Clockwork_Left : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_clockwork_02ImageMap";   
   size = "256 512";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.293 -0.609 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.471 0.069 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.293 -0.609 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.471 0.069 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "256 512";    
      imageMap = "shipWreck_clockwork_ember_02ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "256 512";
      breachStates["Breach", "pulseSizeMax"]  = "256 512";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "256 512";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.293 -0.609 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.471 0.069 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "256 512";
      breachStates["Breach", "flickerSize", 1]    = "256 512";
      imageMap = "shipWreck_clockwork_elec_02ImageMap";
   };     
};


new ScriptGroup(ShipWreck_Clockwork_Right : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_clockwork_03ImageMap";   
   size = "256 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.534 0.093 0 0 0.9 0 0";
   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.534 0.093 0 0 0.3 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "256 384";    
      imageMap = "shipWreck_clockwork_ember_03ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "256 384";
      breachStates["Breach", "pulseSizeMax"]  = "256 384";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "256 384";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.534 0.093 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "256 384";
      breachStates["Breach", "flickerSize", 1]    = "256 384";
      imageMap = "shipWreck_clockwork_elec_03ImageMap";
   };     
};


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// DYSON
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


new ScriptGroup(ShipWreck_dyson_Left : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_dyson_01ImageMap";   
   size = "384 512";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.126 -0.462 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.342 0.491 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.126 -0.462 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.342 0.491 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "384 512";    
      imageMap = "shipWreck_dyson_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "384 512";
      breachStates["Breach", "pulseSizeMax"]  = "384 512";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "384 512";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.126 -0.462 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.342 0.491 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "384 512";
      breachStates["Breach", "flickerSize", 1]    = "384 512";
      imageMap = "shipWreck_dyson_elec_01ImageMap";
   };     
};

new ScriptGroup(ShipWreck_dyson_Right : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_dyson_02ImageMap";   
   size = "384 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.131 0.206 0 0 0.9 0 0";
   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.131 0.206 0 0 0.3 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "384 384";    
      imageMap = "shipWreck_dyson_ember_02ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "384 384";
      breachStates["Breach", "pulseSizeMax"]  = "384 384";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "384 384";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.131 0.206 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "384 384";
      breachStates["Breach", "flickerSize", 1]    = "384 384";
      imageMap = "shipWreck_dyson_elec_02ImageMap";
   };     
};


new ScriptGroup(ShipWreck_dyson_Med : ShipWreck_MetalBase)
{
   wreckImpulseForce = "100 120"; 
   imageMap = "shipWreck_dyson_03ImageMap";   
   size = "768 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.529 -0.285 0 0 0.9 0 0";
   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.529 -0.285 0 0 0.3 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 768";    
      imageMap = "shipWreck_dyson_ember_03ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 768";
      breachStates["Breach", "pulseSizeMax"]  = "768 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.529 -0.285 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 768";
      breachStates["Breach", "flickerSize", 1]    = "768 768";
      imageMap = "shipWreck_dyson_elec_03ImageMap";
   };     
};

