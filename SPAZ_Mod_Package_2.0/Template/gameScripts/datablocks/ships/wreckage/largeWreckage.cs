
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// MULE
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Mule : ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_cargoPlatform_01ImageMap";   
   size = "112 224";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.660 0.113 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "112 224";    
      imageMap = "shipWreck_cargoPlatform_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "112 224";
      breachStates["Breach", "pulseSizeMax"]  = "112 224";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "112 224";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.660 0.113 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "112 224";
      breachStates["Breach", "flickerSize", 1]    = "112 224";
      imageMap = "shipWreck_cargoPlatform_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// RIGHTHOOK
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_RightHook : ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_rightHook_01ImageMap";   
   size = "186 84";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.211 0.193 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "186 84";    
      imageMap = "shipWreck_rightHook_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "186 84";
      breachStates["Breach", "pulseSizeMax"]  = "186 84";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "186 84";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.211 0.193 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "186 84";
      breachStates["Breach", "flickerSize", 1]    = "186 84";
      imageMap = "shipWreck_rightHook_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// HELIX
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Helix: ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_helix_01ImageMap";   
   size = "81 224";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.087 0.349 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "81 224";    
      imageMap = "shipWreck_helix_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "81 224";
      breachStates["Breach", "pulseSizeMax"]  = "81 224";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "81 224";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.087 0.349 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "81 224";
      breachStates["Breach", "flickerSize", 1]    = "81 224";
      imageMap = "shipWreck_helix_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// BIGBROTHER
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_BigBrother: ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_bigBrother_01ImageMap";   
   size = "224 224";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.037 0.020 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "224 224";    
      imageMap = "shipWreck_bigBrother_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "224 224";
      breachStates["Breach", "pulseSizeMax"]  = "224 224";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "224 224";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.037 0.020 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "224 224";
      breachStates["Breach", "flickerSize", 1]    = "224 224";
      imageMap = "shipWreck_bigBrother_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// CRAWLER
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Crawler: ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_crawler_01ImageMap";   
   size = "168 224";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.517 -0.103 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "168 224";    
      imageMap = "shipWreck_crawler_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "168 224";
      breachStates["Breach", "pulseSizeMax"]  = "168 224";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "168 224";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.517 -0.103 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "168 224";
      breachStates["Breach", "flickerSize", 1]    = "168 224";
      imageMap = "shipWreck_crawler_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// CIV SHIPS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// FLORA
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Flora: ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_flora_01ImageMap";   
   size = "224 224";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.016 0.152 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "224 224";    
      imageMap = "shipWreck_flora_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "224 224";
      breachStates["Breach", "pulseSizeMax"]  = "224 224";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "224 224";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.016 0.152 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "224 224";
      breachStates["Breach", "flickerSize", 1]    = "224 224";
      imageMap = "shipWreck_flora_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// GRINDER
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_Grinder: ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_grinder_01ImageMap";   
   size = "56 168";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.330 0.447 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "56 168";    
      imageMap = "shipWreck_grinder_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "56 168";
      breachStates["Breach", "pulseSizeMax"]  = "56 168";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "56 168";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.330 0.447 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "56 168";
      breachStates["Breach", "flickerSize", 1]    = "56 168";
      imageMap = "shipWreck_grinder_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// BIGBUS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_BigBus: ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_bigBus_01ImageMap";   
   size = "224 224";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.168 0.118 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "224 224";    
      imageMap = "shipWreck_bigBus_ember_01ImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "224 224";
      breachStates["Breach", "pulseSizeMax"]  = "224 224";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "224 224";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.168 0.118 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "224 224";
      breachStates["Breach", "flickerSize", 1]    = "224 224";
      imageMap = "shipWreck_bigBus_elec_01ImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// BOUNTY LARGE 01
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_BountyLarge_01: ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_bountyLarge_01ImageMap";   
   size = "224 224";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire 0.644 -0.025 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "224 224";    
      imageMap = "shipWreck_bountyLarge_01_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "224 224";
      breachStates["Breach", "pulseSizeMax"]  = "224 224";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "224 224";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger 0.644 -0.025 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "224 224";
      breachStates["Breach", "flickerSize", 1]    = "224 224";
      imageMap = "shipWreck_bountyLarge_01_elecImageMap";
   };     
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// BOUNTY LARGE 02
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ShipWreck_BountyLarge_02: ShipWreck_MetalBase_Cull_Regular)
{
   imageMap = "shipWreck_bountyLarge_02ImageMap";   
   size = "224 224";  
   breachStates["Breach", "breachEffects", 0]  = "hullFire -0.241 -0.201 0 0 0.9 0 0";     
   new ScriptGroup(ScarEmbers : ShipWreck_EmbersBase)
   {  
      size = "224 224";    
      imageMap = "shipWreck_bountyLarge_02_emberImageMap";    
      breachStates["Breach", "pulseSizeMin"]  = "224 224";
      breachStates["Breach", "pulseSizeMax"]  = "224 224";        
   };   
   new ScriptGroup(ScarElec : ShipWreck_ElecBase)
   {   
      size = "224 224";  
      breachStates["Breach", "breachEffects", 0]  = "hullLinger -0.241 -0.201 0 0 1.5 0 0";
      breachStates["Breach", "flickerSize", 0]    = "224 224";
      breachStates["Breach", "flickerSize", 1]    = "224 224";
      imageMap = "shipWreck_bountyLarge_02_elecImageMap";
   };     
};







