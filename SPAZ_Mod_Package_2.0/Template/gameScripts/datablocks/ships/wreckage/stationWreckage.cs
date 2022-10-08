//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// TERRAN STATIONS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_terranStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_terranStation_01ImageMap";   
   size = "384 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.320 -0.339 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.089 0.304 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.320 -0.339 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.089 0.304 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "384 384";    
      imageMap = "shipWreck_terranStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "384 384";
      breachStates["Breach", "pulseSizeMax"]  = "384 384";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "384 384";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.320 -0.339 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.089 0.304 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "384 384";
      breachStates["Breach", "flickerSize", 1]    = "384 384";
      imageMap = "shipWreck_terranStation_elec_01ImageMap";
   };     
};

new ScriptGroup(ShipWreck_terranStation_02 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_terranStation_02ImageMap";   
   size = "512 512";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.042 -0.280 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.550 -0.260 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.042 -0.280 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.550 -0.260 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "512 512";    
      imageMap = "shipWreck_terranStation_ember_02ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "512 512";
      breachStates["Breach", "pulseSizeMax"]  = "512 512";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "512 512";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.042 -0.280 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.550 -0.260 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "512 512";
      breachStates["Breach", "flickerSize", 1]    = "512 512";
      imageMap = "shipWreck_terranStation_elec_02ImageMap";
   };     
};

new ScriptGroup(ShipWreck_terranStation_03 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_terranStation_03ImageMap";   
   size = "768 576";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.432 -0.792 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.712 0.516 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.432 -0.792 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.712 0.516 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 576";    
      imageMap = "shipWreck_terranStation_ember_03ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 576";
      breachStates["Breach", "pulseSizeMax"]  = "768 576";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 576";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.432 -0.792 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.712 0.516 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 576";
      breachStates["Breach", "flickerSize", 1]    = "768 576";
      imageMap = "shipWreck_terranStation_elec_03ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// PIRATE STATION
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_pirateStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_pirateStation_01ImageMap";   
   size = "512 512";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.043 -0.241 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.237 0.805 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.043 -0.241 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.237 0.805 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "512 512";    
      imageMap = "shipWreck_pirateStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "512 512";
      breachStates["Breach", "pulseSizeMax"]  = "512 512";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "512 512";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.043 -0.241 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.237 0.805 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "512 512";
      breachStates["Breach", "flickerSize", 1]    = "512 512";
      imageMap = "shipWreck_pirateStation_elec_01ImageMap";
   };     
};

new ScriptGroup(ShipWreck_pirateStation_02 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_pirateStation_02ImageMap";   
   size = "768 512";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.093 0.007 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.196 -0.444 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.093 0.007 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.196 -0.444 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 512";    
      imageMap = "shipWreck_pirateStation_ember_02ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 512";
      breachStates["Breach", "pulseSizeMax"]  = "768 512";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 512";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.093 0.007 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.196 -0.444 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 512";
      breachStates["Breach", "flickerSize", 1]    = "768 512";
      imageMap = "shipWreck_pirateStation_elec_02ImageMap";
   };     
};

new ScriptGroup(ShipWreck_pirateStation_03 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_pirateStation_03ImageMap";   
   size = "768 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.105 0.167 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire -0.681 0.398 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.105 0.167 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff -0.681 0.398 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 768";    
      imageMap = "shipWreck_pirateStation_ember_03ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 768";
      breachStates["Breach", "pulseSizeMax"]  = "768 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.105 0.167 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger -0.681 0.398 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 768";
      breachStates["Breach", "flickerSize", 1]    = "768 768";
      imageMap = "shipWreck_pirateStation_elec_03ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// MINING STATION
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


new ScriptGroup(shipWreck_boreStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_boreStation_01ImageMap";   
   size = "512 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.010 0.074 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire -0.270 0.289 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.010 0.074 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff -0.270 0.289 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "512 384";    
      imageMap = "shipWreck_boreStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "512 384";
      breachStates["Breach", "pulseSizeMax"]  = "512 384";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "512 384";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.010 0.074 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger -0.270 0.289 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "512 384";
      breachStates["Breach", "flickerSize", 1]    = "512 384";
      imageMap = "shipWreck_boreStation_elec_01ImageMap";
   };     
};

new ScriptGroup(shipWreck_quarryStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_quarryStation_01ImageMap";   
   size = "768 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.718 -0.270 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire -0.540 -0.393 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.718 -0.270 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff -0.540 -0.393 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 768";    
      imageMap = "shipWreck_quarryStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 768";
      breachStates["Breach", "pulseSizeMax"]  = "768 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.718 -0.270 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger -0.540 -0.393 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 768";
      breachStates["Breach", "flickerSize", 1]    = "768 768";
      imageMap = "shipWreck_quarryStation_elec_01ImageMap";
   };     
};

new ScriptGroup(shipWreck_dredgeStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_dredgeStation_01ImageMap";   
   size = "576 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.265 -0.688 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.168 0.314 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.265 -0.688 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.168 0.314 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "576 768";    
      imageMap = "shipWreck_dredgeStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "576 768";
      breachStates["Breach", "pulseSizeMax"]  = "576 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "576 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.265 -0.688 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.168 0.314 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "576 768";
      breachStates["Breach", "flickerSize", 1]    = "576 768";
      imageMap = "shipWreck_dredgeStation_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// SCI STATION
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_echoStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_echoStation_01ImageMap";   
   size = "512 512";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.010 0.751 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.545 0.020 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.010 0.751 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.545 0.020 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "512 512";    
      imageMap = "shipWreck_echoStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "512 512";
      breachStates["Breach", "pulseSizeMax"]  = "512 512";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "512 512";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.010 0.751 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.545 0.020 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "512 512";
      breachStates["Breach", "flickerSize", 1]    = "512 512";
      imageMap = "shipWreck_echoStation_elec_01ImageMap";
   };     
};

new ScriptGroup(shipWreck_quasarStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_quasarStation_01ImageMap";   
   size = "512 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.024 -0.486 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.220 0.496 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.024 -0.486 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.220 0.496 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "512 768";    
      imageMap = "shipWreck_quasarStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "512 768";
      breachStates["Breach", "pulseSizeMax"]  = "512 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "512 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.024 -0.486 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.220 0.496 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "512 768";
      breachStates["Breach", "flickerSize", 1]    = "512 768";
      imageMap = "shipWreck_quasarStation_elec_01ImageMap";
   };     
};

new ScriptGroup(shipWreck_pulsarStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_pulsarStation_01ImageMap";   
   size = "768 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.450 0.609 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.498 0.511 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.450 0.609 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.498 0.511 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 768";    
      imageMap = "shipWreck_pulsarStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 768";
      breachStates["Breach", "pulseSizeMax"]  = "768 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.450 0.609 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.498 0.511 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 768";
      breachStates["Breach", "flickerSize", 1]    = "768 768";
      imageMap = "shipWreck_pulsarStation_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// COL STATION
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(shipWreck_sanctuaryStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_sanctuaryStation_01ImageMap";   
   size = "384 384";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.456 -0.638 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire -0.251 0.692 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.456 -0.638 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff -0.251 0.692 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "384 384";    
      imageMap = "shipWreck_sanctuaryStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "384 384";
      breachStates["Breach", "pulseSizeMax"]  = "384 384";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "384 384";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.456 -0.638 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger -0.251 0.692 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "384 384";
      breachStates["Breach", "flickerSize", 1]    = "384 384";
      imageMap = "shipWreck_sanctuaryStation_elec_01ImageMap";
   };     
};

new ScriptGroup(shipWreck_oasisStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_oasisStation_01ImageMap";   
   size = "768 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.780 -0.236 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.005 0.152 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.780 -0.236 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.005 0.152 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 768";    
      imageMap = "shipWreck_oasisStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 768";
      breachStates["Breach", "pulseSizeMax"]  = "768 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.780 -0.236 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.005 0.152 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 768";
      breachStates["Breach", "flickerSize", 1]    = "768 768";
      imageMap = "shipWreck_oasisStation_elec_01ImageMap";
   };     
};

new ScriptGroup(shipWreck_fiveStarStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_fiveStarStation_01ImageMap";   
   size = "768 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.021 -0.452 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.419 0.025 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.021 -0.452 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.419 0.025 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 768";    
      imageMap = "shipWreck_fiveStarStation_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 768";
      breachStates["Breach", "pulseSizeMax"]  = "768 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.021 -0.452 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.419 0.025 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 768";
      breachStates["Breach", "flickerSize", 1]    = "768 768";
      imageMap = "shipWreck_fiveStarStation_elec_01ImageMap";
   };     
};

new ScriptGroup(shipWreck_carlotStation_01 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_carlot_01ImageMap";   
   size = "256 256";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.100 -0.393 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.314 0.147 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.100 -0.393 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.314 0.147 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "256 256";    
      imageMap = "shipWreck_carlot_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "1024 1024";
      breachStates["Breach", "pulseSizeMax"]  = "1024 1024";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "256 256";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.100 -0.393 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.314 0.147 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "1024 1024";
      breachStates["Breach", "flickerSize", 1]    = "1024 1024";
      imageMap = "shipWreck_carlot_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// DOODAD WRECKS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


new ScriptGroup(ShipWreck_beacon : ShipWreck_MetalBase_Cleanup) //beacon wreck must clean up so we don't clutter
{
   imageMap = "shipWreck_beaconImageMap";   
   size = "128 128";  
   wreckAngularVelocityOverride = "45"; 
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.173 -0.039 0 0 0.9 0 0";
   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.173 -0.039 0 0 0.3 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "128 128";    
      imageMap = "shipWreck_beacon_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "128 128";
      breachStates["Breach", "pulseSizeMax"]  = "128 128";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "128 128";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.173 -0.039 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "128 128";
      breachStates["Breach", "flickerSize", 1]    = "128 128";
      imageMap = "shipWreck_beacon_elecImageMap";
   };     
};

new ScriptGroup(ShipWreck_stationDoodad_Small : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_doodadSmallImageMap";   
   size = "256 256";  
   wreckAngularVelocityOverride = "45"; 
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.450 -0.358 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.257 0.255 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.450 -0.358 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.257 0.255 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "256 256";    
      imageMap = "shipWreck_doodadSmall_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "256 256";
      breachStates["Breach", "pulseSizeMax"]  = "256 256";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "256 256";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.450 -0.358 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.257 0.255 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "256 256";
      breachStates["Breach", "flickerSize", 1]    = "256 256";
      imageMap = "shipWreck_doodadSmall_elecImageMap";
   };     
};

new ScriptGroup(ShipWreck_stationDoodad_Med : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_stationDoodad_medImageMap";   
   size = "512 512";  
   wreckAngularVelocityOverride = "45"; 
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.251 -0.319 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.278 0.594 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.251 -0.319 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.278 0.594 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "512 512";    
      imageMap = "shipWreck_stationDoodad_med_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "512 512";
      breachStates["Breach", "pulseSizeMax"]  = "512 512";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "512 512";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.251 -0.319 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.278 0.594 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "512 512";
      breachStates["Breach", "flickerSize", 1]    = "512 512";
      imageMap = "shipWreck_stationDoodad_med_elecImageMap";
   };     
};

new ScriptGroup(ShipWreck_stationDoodad_Med02 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_stationDoodad_Med02ImageMap";   
   size = "512 512"; 
   wreckAngularVelocityOverride = "45";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.498 -0.020 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.042 0.732 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.498 -0.020 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.042 0.732 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "512 512";    
      imageMap = "shipWreck_stationDoodad_Med02_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "512 512";
      breachStates["Breach", "pulseSizeMax"]  = "512 512";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "512 512";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.498 -0.020 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.042 0.732 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "512 512";
      breachStates["Breach", "flickerSize", 1]    = "512 512";
      imageMap = "shipWreck_stationDoodad_Med02_elecImageMap";
   };     
};

new ScriptGroup(ShipWreck_stationDoodad_Large : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_stationDoodad_LargeImageMap";   
   size = "192 576"; 
   wreckAngularVelocityOverride = "30";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.330 -0.766 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.314 0.604 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff 0.330 -0.766 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.314 0.604 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "192 576";    
      imageMap = "shipWreck_stationDoodad_Large_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "192 576";
      breachStates["Breach", "pulseSizeMax"]  = "192 576";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "192 576";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.330 -0.766 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.314 0.604 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "192 576";
      breachStates["Breach", "flickerSize", 1]    = "192 576";
      imageMap = "shipWreck_stationDoodad_Large_elecImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ZOMBIE STATIONS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_zombie_generic_01 : ShipWreck_ZombieBase)
{
   imageMap = "shipWreck_zombieGeneric_01ImageMap";   
   size = "256 256"; 
   wreckAngularVelocityOverride = "30";  
};

new ScriptGroup(ShipWreck_zombie_generic_02 : ShipWreck_ZombieBase)
{
   imageMap = "shipWreck_zombieGeneric_02ImageMap";   
   size = "256 256"; 
   wreckAngularVelocityOverride = "30";  
};

new ScriptGroup(ShipWreck_zombie_heart : ShipWreck_ZombieBase)
{
   imageMap = "shipWreck_zombieHeartImageMap";   
   size = "512 512"; 
   wreckAngularVelocityOverride = "30";  
};

new ScriptGroup(ShipWreck_zombie_artery : ShipWreck_ZombieBase)
{
   imageMap = "shipWreck_zombieArteryImageMap";   
   size = "768 768"; 
   wreckAngularVelocityOverride = "30";  
};

new ScriptGroup(ShipWreck_zombie_hive : ShipWreck_ZombieBase)
{
   imageMap = "shipWreck_zombieHiveImageMap";   
   size = "768 768"; 
   wreckAngularVelocityOverride = "30";  
};

new ScriptGroup(ShipWreck_zombie_clockwork : ShipWreck_ZombieBase)
{
   imageMap = "shipWreck_zombieClockworkImageMap";   
   size = "768 768"; 
   wreckAngularVelocityOverride = "30";  
};

////////////////////////////////////////////////////////////////////////////////
// BOUNTY HUNTER
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_bountyStation_03 : ShipWreck_MetalBase)
{
   imageMap = "shipWreck_bountyBase_03ImageMap";   
   size = "768 768";  
   
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.021 0.250 0 0 0.9 0 0";
   breachStates["Breach", "breachEffects", 1]  = "hullFire 0.079 -0.437 0 0 0.7 0 0";

   breachStates["Cold", "breachEffects", 0]  = "hullElecPuff -0.021 0.250 0 0 0.3 750 2000";
   breachStates["Cold", "breachEffects", 1]  = "hullElecPuff 0.079 -0.437 0 0 0.4 750 2000";
        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "768 768";    
      imageMap = "shipWreck_bountyBase_03_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "768 768";
      breachStates["Breach", "pulseSizeMax"]  = "768 768";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "768 768";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.021 0.250 0 0 1.5 0 0";
      breachStates["Breach", "breachEffects", 1]  = "hullLinger 0.079 -0.437 0 0 1.5 0 0";
       
      breachStates["Breach", "flickerSize", 0]    = "768 768";
      breachStates["Breach", "flickerSize", 1]    = "768 768";
      imageMap = "shipWreck_bountyBase_03_elecImageMap";
   };     
};
