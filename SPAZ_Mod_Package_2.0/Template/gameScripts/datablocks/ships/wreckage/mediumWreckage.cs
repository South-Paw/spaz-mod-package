
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// GENERIC WRECKS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Small_01 : ShipWreck_MetalBase_Cleanup)
{
   imageMap = "shipWreck_small01ImageMap";   
   size = "64 64";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0 0 0 0 0.9 0 0";        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "64 64";    
      imageMap = "shipWreck_small01_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "64 64";
      breachStates["Breach", "pulseSizeMax"]  = "64 64";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "64 64";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0 0 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "64 64";
      breachStates["Breach", "flickerSize", 1]    = "64 64";
      imageMap = "shipWreck_small01_elecImageMap";
   };     
};

new ScriptGroup(ShipWreck_Small_02 : ShipWreck_MetalBase_Cleanup)
{
   imageMap = "shipWreck_small02ImageMap";   
   size = "64 64";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0 0 0 0 0.9 0 0";        
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "64 64";    
      imageMap = "shipWreck_small02_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "64 64";
      breachStates["Breach", "pulseSizeMax"]  = "64 64";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "64 64";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0 0 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "64 64";
      breachStates["Breach", "flickerSize", 1]    = "64 64";
      imageMap = "shipWreck_small02_elecImageMap";
   };     
};

new ScriptGroup(ShipWreck_Small_03 : ShipWreck_MetalBase_Cleanup)
{
   imageMap = "shipWreck_small03ImageMap";   
   size = "64 64";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0 0 0 0 0.9 0 0";   
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "64 64";    
      imageMap = "shipWreck_small03_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "64 64";
      breachStates["Breach", "pulseSizeMax"]  = "64 64";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "64 64";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0 0 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "64 64";
      breachStates["Breach", "flickerSize", 1]    = "64 64";
      imageMap = "shipWreck_small03_elecImageMap";
   };     
};

