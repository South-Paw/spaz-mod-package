
////////////////////////////////////////////////////////////////////////////////
// SMALL SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE SCOUT
/////////////////////////////////////////////

datablock ShipDesignDatablock(ScoutShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullScout;  //This determines what we can put of the ship. 
   
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";

   //Now we set up the weapons, check the hull to determine which weapons are allowed where. 
   //The game will assert if you place illegal weapons in slots not made for them
     
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink3 = "SmallLauncher_Civ";
   externalLink4 = "SmallLauncher_Civ";
   externalLink5 = "SmallEmitter_Civ";
   externalLink6 = "SmallEmitter_Civ";
};

//Assume level 15+
datablock ShipDesignDatablock(ScoutShip_Basic : ScoutShip)
{ 
   designDescriptionBits = $SST_DESIGN_BASIC;  
   friendlyName = "Basic Scout";   
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "";
   shipArmor_Port        = "CivArmor_S";

   externalLink3 = "SmallLauncher";
   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallEmitter";
   externalLink6 = "SmallEmitter";
};
datablock ShipDesignDatablock(ScoutShip_Basic_A : ScoutShip_Basic)
{ 
   externalLink3 = "SmallLauncher";
   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallEmitter_Civ";
   externalLink6 = "SmallEmitter_Civ";
   parentDesign = ScoutShip_Basic; 
};
datablock ShipDesignDatablock(ScoutShip_Basic_B : ScoutShip_Basic)
{  //This one is more of a brawler, needs more armor
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
   
   externalLink3 = "SmallRocketLauncher";
   externalLink4 = "SmallRocketLauncher";
   externalLink5 = "SmallCannon_Pulse";
   externalLink6 = "SmallCannon_Pulse";
   parentDesign = ScoutShip_Basic; 
};
datablock ShipDesignDatablock(ScoutShip_Basic_C : ScoutShip_Basic)
{  //Will have similar intercept pos so torps will work well
   externalLink3 = "SmallTorpedoLauncher";
   externalLink4 = "SmallTorpedoLauncher";
   externalLink5 = "SmallCannon_pulse_Civ";
   externalLink6 = "SmallCannon_pulse_Civ";
   parentDesign = ScoutShip_Basic; 
};




//Assume level 25+
datablock ShipDesignDatablock(ScoutShip_Improved : ScoutShip_Basic)
{ 
   designDescriptionBits = $SST_DESIGN_IMPROVED;  
   friendlyName = "Improved Scout";   
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink3 = "SmallTorpedoLauncher";
   externalLink4 = "SmallTorpedoLauncher";
   externalLink5 = "LauncherBooster_S";
   externalLink6 = "LauncherBooster_S";
};
datablock ShipDesignDatablock(ScoutShip_Improved_A : ScoutShip_Improved)
{ 
   externalLink3 = "ReactorBooster_S";
   externalLink4 = "ReactorBooster_S";
   externalLink5 = "SmallEmitter_ION";
   externalLink6 = "SmallEmitter_ION";
   parentDesign = ScoutShip_Improved; 
};
datablock ShipDesignDatablock(ScoutShip_Improved_B : ScoutShip_Improved)
{ 
   externalLink3 = "SmallLauncher";
   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallEmitter";
   externalLink6 = "SmallEmitter";
   parentDesign = ScoutShip_Improved; 
};
datablock ShipDesignDatablock(ScoutShip_Improved_C : ScoutShip_Improved)
{ 
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "HeavyArmor_S";

   externalLink3 = "ReactorBooster_S";
   externalLink4 = "CannonBooster_S";
   externalLink5 = "SmallCannon_Pulse";
   externalLink6 = "SmallCannon_Pulse";
   parentDesign = ScoutShip_Improved; 
};
datablock ShipDesignDatablock(ScoutShip_Improved_D : ScoutShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipEngine            = S_BasicEngine;    
   shipShield            = S_StableCloak;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "HeavyArmor_S";
   shipArmor_Port        = "HeavyArmor_S";
   
   externalLink3 = "SmallRocketLauncher";
   externalLink4 = "SmallRocketLauncher";
   externalLink5 = "SmallCannon_cluster";
   externalLink6 = "SmallCannon_cluster";
   parentDesign = ScoutShip_Improved; 
};


//Assume level 35+
datablock ShipDesignDatablock(ScoutShip_Advanced : ScoutShip_Basic)
{ 
   designDescriptionBits = $SST_DESIGN_ADVANCED; 
   friendlyName = "Advanced Scout";   
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";

   externalLink3 = "SmallLauncher_GRAV";
   externalLink4 = "SmallLauncher_GRAV";
   externalLink5 = "SmallCannon_Pulse";
   externalLink6 = "SmallCannon_Pulse";
};
datablock ShipDesignDatablock(ScoutShip_Advanced_A : ScoutShip_Advanced)
{ 
   externalLink3 = "SmallHunterLauncher";
   externalLink4 = "SmallTorpedoLauncher";
   externalLink5 = "SmallCannon_rapid";
   externalLink6 = "SmallCannon_rapid";
   parentDesign = ScoutShip_Advanced; 
};
datablock ShipDesignDatablock(ScoutShip_Advanced_B : ScoutShip_Advanced)
{ 
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";
   
   externalLink3 = "ShieldBooster_S";
   externalLink4 = "ShieldBooster_S";
   externalLink5 = "SmallCannon_massDriver";
   externalLink6 = "SmallCannon_massDriver";
   parentDesign = ScoutShip_Advanced; 
};
datablock ShipDesignDatablock(ScoutShip_Advanced_C : ScoutShip_Advanced)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_ExperimentalCloak;
   
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";
   
   externalLink3 = "ReactorBooster_S";
   externalLink4 = "ReactorBooster_S";
   externalLink5 = "SmallEmitter_Heavy";
   externalLink6 = "SmallEmitter_Heavy";
   parentDesign = ScoutShip_Advanced; 
};
datablock ShipDesignDatablock(ScoutShip_Advanced_D : ScoutShip_Advanced)
{ 
   externalLink3 = "SmallTorpedoLauncher";
   externalLink4 = "SmallTorpedoLauncher";
   externalLink5 = "SmallCannon_pulse_Civ";
   externalLink6 = "SmallCannon_pulse_Civ";
   parentDesign = ScoutShip_Advanced; 
};
datablock ShipDesignDatablock(ScoutShip_Advanced_E : ScoutShip_Advanced)
{ 
   externalLink3 = "SmallLauncher";
   externalLink4 = "SmallLauncher";
   externalLink5 = "SmallEmitter";
   externalLink6 = "SmallEmitter_ION";
   parentDesign = ScoutShip_Advanced; 
};




/////////////////////////////////////////////
// THE GIMP
/////////////////////////////////////////////

datablock ShipDesignDatablock(GimpShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullGimp;  //This determines what we can put of the ship. 
   
   
   shipEngine            = S_CivEngine;    
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
     
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";
   
   externalLink1 = "SmallLauncher_Civ";
   externalLink2 = "SmallCannon_Pulse_Civ";
   externalLink7 = "SmallCannon_Pulse_Civ";
};

datablock ShipDesignDatablock(GimpShip_Basic : GimpShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Gimp";   
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
   
   externalLink1 = "SmallLauncher";
   externalLink2 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";
};
datablock ShipDesignDatablock(GimpShip_Basic_A : GimpShip_Basic)
{  
   externalLink1 = "SmallTorpedoLauncher";
   externalLink2 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";   
   parentDesign = GimpShip_Basic; 
};
datablock ShipDesignDatablock(GimpShip_Basic_B : GimpShip_Basic)
{  
   externalLink1 = "SmallTorpedoLauncher";
   externalLink2 = "SmallCannon_pulse_Civ";
   externalLink7 = "SmallCannon_pulse_Civ";   
   parentDesign = GimpShip_Basic; 
};
datablock ShipDesignDatablock(GimpShip_Basic_C : GimpShip_Basic)
{  
   externalLink1 = "SmallLauncher";
   externalLink2 = "SmallEmitter";
   externalLink7 = "SmallEmitter";   
   parentDesign = GimpShip_Basic; 
};
datablock ShipDesignDatablock(GimpShip_Basic_D : GimpShip_Basic)
{  
   externalLink1 = "SmallLauncher";
   externalLink2 = "SmallEmitter_Civ";
   externalLink7 = "SmallEmitter_Civ";   
   parentDesign = GimpShip_Basic; 
};




datablock ShipDesignDatablock(GimpShip_Improved : GimpShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Gimp";   
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
   
   externalLink1 = "ReactorBooster_S";
   externalLink2 = "SmallEmitter_Heavy";
   externalLink7 = "SmallEmitter_Heavy";
};
datablock ShipDesignDatablock(GimpShip_Improved_A : GimpShip_Improved)
{  
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipEngine            = S_BasicEngine;    
   shipShield            = S_StableCloak;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "HeavyArmor_S";
   shipArmor_Port        = "HeavyArmor_S";
   
   externalLink1 = "CloakBooster_S";
   externalLink2 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";   
   parentDesign = GimpShip_Improved; 
};
datablock ShipDesignDatablock(GimpShip_Improved_B : GimpShip_Improved)
{  
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipEngine            = S_BasicEngine;    
   shipShield            = S_StableCloak;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "HeavyArmor_S";
   shipArmor_Port        = "HeavyArmor_S";
   
   externalLink1 = "CloakBooster_S";
   externalLink2 = "SmallCannon_cluster";
   externalLink7 = "SmallCannon_cluster";   
   parentDesign = GimpShip_Improved; 
};
datablock ShipDesignDatablock(GimpShip_Improved_C : GimpShip_Improved)
{  
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipEngine            = S_BasicEngine;    
   shipShield            = S_StableCloak;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "HeavyArmor_S";
   shipArmor_Port        = "HeavyArmor_S";
   
   externalLink1 = "CloakBooster_S";
   externalLink2 = "SmallEmitter_ION";
   externalLink7 = "SmallEmitter_ION";   
   parentDesign = GimpShip_Improved; 
};
datablock ShipDesignDatablock(GimpShip_Improved_D : GimpShip_Improved)
{  
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
   
   shipEngine            = S_BasicEngine;  
   
   externalLink1 = "SmallTorpedoLauncher";
   externalLink2 = "SmallCannon_pulse_Civ";
   externalLink7 = "SmallCannon_pulse_Civ";   
   parentDesign = GimpShip_Improved; 
};




datablock ShipDesignDatablock(GimpShip_Advanced : GimpShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;  
   friendlyName = "Advanced Gimp";   
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";
   
   externalLink1 = "SmallHunterLauncher";
   externalLink2 = "SmallCannon_pulse";
   externalLink7 = "SmallCannon_pulse";
};
datablock ShipDesignDatablock(GimpShip_Advanced_A : GimpShip_Advanced)
{     
   externalLink1 = "ReactorBooster_S";
   externalLink2 = "SmallEmitter_Heavy";
   externalLink7 = "SmallEmitter_Heavy";
   parentDesign = GimpShip_Advanced; 
};
datablock ShipDesignDatablock(GimpShip_Advanced_B : GimpShip_Advanced)
{     
   externalLink1 = "ShieldBooster_S";
   externalLink2 = "SmallCannon_rapid";
   externalLink7 = "SmallCannon_rapid";
   parentDesign = GimpShip_Advanced; 
};
datablock ShipDesignDatablock(GimpShip_Advanced_C : GimpShip_Advanced)
{    
   deviceDescriptionBits = $SST_DEVICE_CLOAK;     
   shipShield            = S_StableCloak;
    
   externalLink1 = "CloakBooster_S";
   externalLink2 = "SmallCannon_cluster";
   externalLink7 = "SmallCannon_cluster";
   parentDesign = GimpShip_Advanced; 
};
datablock ShipDesignDatablock(GimpShip_Advanced_D : GimpShip_Advanced)
{    
   deviceDescriptionBits = $SST_DEVICE_CLOAK;     
   shipShield            = S_StableCloak;
    
   externalLink1 = "CloakBooster_S";
   externalLink2 = "SmallEmitter_ION";
   externalLink7 = "SmallEmitter_ION";
   parentDesign = GimpShip_Advanced; 
};
datablock ShipDesignDatablock(GimpShip_Advanced_E : GimpShip_Advanced)
{    
   deviceDescriptionBits = $SST_DEVICE_CLOAK;     
   shipShield            = S_StableCloak;
    
   externalLink1 = "CloakBooster_S";
   externalLink2 = "SmallCannon_massDriver";
   externalLink7 = "SmallCannon_massDriver";
   parentDesign = GimpShip_Advanced; 
};

/////////////////////////////////////////////
// THE BOOMERANG
/////////////////////////////////////////////

datablock ShipDesignDatablock(BoomerangShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullBoomerang;  //This determines what we can put of the ship. 
   
      
   shipEngine            = S_CivEngine;    
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
     
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";
   
   externalLink4 = "SmallCannon_Pulse_Civ";
   externalLink5 = "SmallCannon_Pulse_Civ";
};

datablock ShipDesignDatablock(BoomerangShip_Basic : BoomerangShip)
{  
   designDescriptionBits = $SST_DESIGN_BASIC; 
   friendlyName = "Basic Boomerang";   
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "";
   shipArmor_Port        = "CivArmor_S";
   
   externalLink4 = "SmallCannon_Pulse";
   externalLink5 = "SmallCannon_Pulse";
};
datablock ShipDesignDatablock(BoomerangShip_Basic_A : BoomerangShip_Basic)
{     
   externalLink4 = "SmallCannon_Pulse_Civ";
   externalLink5 = "SmallCannon_Pulse_Civ";
   parentDesign = BoomerangShip_Basic; 
};
datablock ShipDesignDatablock(BoomerangShip_Basic_B : BoomerangShip_Basic)
{     
   externalLink4 = "SmallEmitter";
   externalLink5 = "SmallEmitter";
   parentDesign = BoomerangShip_Basic; 
};
datablock ShipDesignDatablock(BoomerangShip_Basic_C : BoomerangShip_Basic)
{     
   externalLink4 = "SmallEmitter_Civ";
   externalLink5 = "SmallEmitter_Civ";
   parentDesign = BoomerangShip_Basic; 
};




datablock ShipDesignDatablock(BoomerangShip_Improved : BoomerangShip_Basic)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Boomerang";   
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "";
   shipArmor_Port        = "CivArmor_S";
   
   externalLink4 = "SmallCannon_cluster";
   externalLink5 = "SmallCannon_cluster";   
};
datablock ShipDesignDatablock(BoomerangShip_Improved_A : BoomerangShip_Improved)
{   
   externalLink4 = "SmallCannon_Pulse_Civ";
   externalLink5 = "SmallCannon_Pulse_Civ";
   parentDesign = BoomerangShip_Improved; 
};
datablock ShipDesignDatablock(BoomerangShip_Improved_B : BoomerangShip_Improved)
{   
   externalLink4 = "SmallEmitter_Civ";
   externalLink5 = "SmallEmitter_Civ";
   parentDesign = BoomerangShip_Improved; 
};
datablock ShipDesignDatablock(BoomerangShip_Improved_C : BoomerangShip_Improved)
{   
   externalLink4 = "SmallEmitter";
   externalLink5 = "SmallEmitter";
   parentDesign = BoomerangShip_Improved; 
};
datablock ShipDesignDatablock(BoomerangShip_Improved_D : BoomerangShip_Improved)
{   
   externalLink4 = "SmallEmitter_ION";
   externalLink5 = "SmallEmitter_ION";
   parentDesign = BoomerangShip_Improved; 
};



datablock ShipDesignDatablock(BoomerangShip_Advanced : BoomerangShip_Basic)
{  
   designDescriptionBits = $SST_DESIGN_ADVANCED;   
   friendlyName = "Advanced Boomerang";   
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "";
   shipArmor_Port        = "CivArmor_S";
   
   externalLink4 = "SmallEmitter_ION";
   externalLink5 = "SmallCannon_massDriver";
};
datablock ShipDesignDatablock(BoomerangShip_Advanced_A : BoomerangShip_Advanced)
{  
   externalLink4 = "SmallCannon_rapid";
   externalLink5 = "SmallCannon_rapid";
   parentDesign = BoomerangShip_Advanced; 
};
datablock ShipDesignDatablock(BoomerangShip_Advanced_B : BoomerangShip_Advanced)
{  
   externalLink4 = "SmallCannon_Pulse";
   externalLink5 = "SmallCannon_Pulse";
   parentDesign = BoomerangShip_Advanced; 
};
datablock ShipDesignDatablock(BoomerangShip_Advanced_C : BoomerangShip_Advanced)
{  
   externalLink4 = "SmallCannon_cluster";
   externalLink5 = "SmallCannon_cluster";
   parentDesign = BoomerangShip_Advanced; 
};   
datablock ShipDesignDatablock(BoomerangShip_Advanced_D : BoomerangShip_Advanced)
{  
   externalLink4 = "SmallEmitter";
   externalLink5 = "SmallEmitter";
   parentDesign = BoomerangShip_Advanced; 
};


/////////////////////////////////////////////
// THE COLT
/////////////////////////////////////////////

datablock ShipDesignDatablock(ColtShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullColt;  //This determines what we can put of the ship. 
   
      
   shipEngine            = S_CivEngine;    
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
     
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";

   //Now we set up the weapons, check the hull to determine which weapons are allowed where. 
   //The game will assert if you place illegal weapons in slots not made for them
     
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink6 = "SmallCannon_Pulse_Civ";
   externalLink7 = "SmallCannon_Pulse_Civ";
   externalLink8 = "SmallCannon_Pulse_Civ";
   externalLink9 = "SmallCannon_Pulse_Civ";            
   externalLink10 = "SmallCannon_Pulse_Civ";
};

datablock ShipDesignDatablock(ColtShip_Basic : ColtShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Colt";   
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
   
   externalLink6 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";
   externalLink8 = "SmallCannon_Pulse";
   externalLink9 = "SmallCannon_Pulse";            
   externalLink10 = "SmallCannon_Pulse";
};
datablock ShipDesignDatablock(ColtShip_Basic_A : ColtShip_Basic)
{      
   externalLink6 = "SmallEmitter";
   externalLink7 = "SmallEmitter";
   externalLink8 = "SmallEmitter";
   externalLink9 = "SmallEmitter";            
   externalLink10 = "SmallEmitter";
   parentDesign = ColtShip_Basic; 
};



datablock ShipDesignDatablock(ColtShip_Improved : ColtShip_Basic)
{  
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Colt";   
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "HeavyArmor_S";
   shipArmor_Port        = "HeavyArmor_S";
   
   externalLink6 = "SmallEmitter_heavy";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";            
   externalLink10 = "SmallEmitter_heavy";
};
datablock ShipDesignDatablock(ColtShip_Improved_A : ColtShip_Improved)
{ 
   externalLink6 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "SmallCannon_Pulse";            
   externalLink10 = "SmallCannon_Pulse";
   parentDesign = ColtShip_Improved; 
};
datablock ShipDesignDatablock(ColtShip_Improved_B : ColtShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK;   
   shipShield            = S_StableCloak;
   
   externalLink6 = "SmallCannon_cluster";
   externalLink7 = "SmallCannon_cluster";
   externalLink8 = "SmallCannon_cluster";
   externalLink9 = "SmallCannon_cluster";            
   externalLink10 = "SmallCannon_cluster";
   parentDesign = ColtShip_Improved; 
};
datablock ShipDesignDatablock(ColtShip_Improved_C : ColtShip_Improved)
{ 
   externalLink6 = "SmallEmitter_ION";
   externalLink7 = "SmallEmitter";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "SmallEmitter";            
   externalLink10 = "SmallEmitter_ION";
   parentDesign = ColtShip_Improved; 
};





datablock ShipDesignDatablock(ColtShip_Advanced : ColtShip_Basic)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Colt";   
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_FortressShield;
     
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";
   
   externalLink6 = "SmallEmitter_ION";
   externalLink7 = "SmallCannon_massDriver";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "SmallCannon_massDriver";            
   externalLink10 = "SmallEmitter_ION";
};
datablock ShipDesignDatablock(ColtShip_Advanced_A : ColtShip_Advanced)
{   
   externalLink6 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "SmallCannon_Pulse";            
   externalLink10 = "SmallCannon_Pulse";
   parentDesign = ColtShip_Advanced; 
};
datablock ShipDesignDatablock(ColtShip_Advanced_B : ColtShip_Advanced)
{   
   externalLink6 = "SmallEmitter_ION";
   externalLink7 = "SmallEmitter_LEECH";
   externalLink8 = "SmallCannon_massDriver";
   externalLink9 = "SmallEmitter_LEECH";            
   externalLink10 = "SmallEmitter_ION";
   parentDesign = ColtShip_Advanced; 
};
datablock ShipDesignDatablock(ColtShip_Advanced_C : ColtShip_Advanced)
{   
   shipReactor   = S_OverchargedReactor;
   externalLink6 = "SmallCannon_rapid";
   externalLink7 = "SmallCannon_rapid";
   externalLink8 = "ShieldBooster_S";
   externalLink9 = "SmallCannon_rapid";            
   externalLink10 = "SmallCannon_rapid";
   parentDesign = ColtShip_Advanced; 
};


/////////////////////////////////////////////
// THE HATCHET
/////////////////////////////////////////////
//Just a big pig that uses basic weapons

datablock ShipDesignDatablock(HatchetShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullHatchet;  //This determines what we can put of the ship. 
   
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
      
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";
   
   externalLink6 = "SmallCannon_Pulse_Civ";
   externalLink7 = "SmallCannon_Pulse_Civ";      
   externalLink8 = "TractorEmitter_medium";      
};

datablock ShipDesignDatablock(HatchetShip_Basic : HatchetShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Hatchet"; 
   
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
         
   externalLink6 = "SmallEmitter";
   externalLink7 = "SmallEmitter";      
   externalLink8 = "TractorEmitter_medium";    
};
datablock ShipDesignDatablock(HatchetShip_Basic_A : HatchetShip_Basic)
{           
   externalLink6 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";      
   parentDesign = HatchetShip_Basic; 
};


datablock ShipDesignDatablock(HatchetShip_Improved : HatchetShip)
{    
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Hatchet"; 
   
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicShield;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "HeavyArmor_S";
   shipArmor_Port        = "HeavyArmor_S";
         
   externalLink6 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";      
   externalLink8 = "PointDefenseBeamEmitter_M";    
};
datablock ShipDesignDatablock(HatchetShip_Improved_A : HatchetShip_Improved)
{        
   externalLink6 = "SmallEmitter";
   externalLink7 = "SmallEmitter";     
   parentDesign = HatchetShip_Improved; 
};


datablock ShipDesignDatablock(HatchetShip_Advanced : HatchetShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced Hatchet"; 
   
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";
         
   externalLink6 = "SmallCannon_Pulse";
   externalLink7 = "SmallCannon_Pulse";      
   externalLink8 = "PointDefenseBeamEmitter_M";    
};
datablock ShipDesignDatablock(HatchetShip_Advanced_A : HatchetShip_Advanced)
{ 
   externalLink6 = "SmallEmitter";
   externalLink7 = "SmallEmitter";  
   parentDesign = HatchetShip_Advanced;     
};



////////////////////////////////////////////////////////////////////////////////
// ZOMBIE SHIPS
////////////////////////////////////////////////////////////////////////////////

datablock ShipDesignDatablock(GirlScoutShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullGirlScout;  //This determines what we can put of the ship. 
   
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";

   //Now we set up the weapons, check the hull to determine which weapons are allowed where. 
   //The game will assert if you place illegal weapons in slots not made for them
     
   //Weapons also have weight, so no need to add all available weapons if less will do
   externalLink2 = "SmallLauncher_Civ";
   
   externalLink3 = "SmallEmitter_Civ";
   externalLink4 = "SmallEmitter_Civ";
   
   externalLink5 = "MiningTractorEmitter";
   externalLink6 = "MiningTractorEmitter";
};

datablock ShipDesignDatablock(GirlScoutShip_Basic : GirlScoutShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic GirlScout"; 
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";
     
   externalLink2 = "SmallLauncher";     
         
   externalLink3 = "SmallEmitter";
   externalLink4 = "SmallEmitter";
   
   externalLink5 = "MiningTractorEmitter";
   externalLink6 = "MiningTractorEmitter";  
};
datablock ShipDesignDatablock(GirlScoutShip_Basic_A : GirlScoutShip_Basic)
{   
   externalLink3 = "SmallEmitter_Civ";
   externalLink4 = "SmallEmitter_Civ";
   parentDesign = GirlScoutShip_Basic;   
};
datablock ShipDesignDatablock(GirlScoutShip_Basic_B : GirlScoutShip_Basic)
{   
   externalLink3 = "SmallCannon_pulse_Civ";
   externalLink4 = "SmallCannon_pulse_Civ";
   parentDesign = GirlScoutShip_Basic;   
};
datablock ShipDesignDatablock(GirlScoutShip_Basic_C : GirlScoutShip_Basic)
{   
   externalLink3 = "SmallCannon_pulse";
   externalLink4 = "SmallCannon_pulse";
   parentDesign = GirlScoutShip_Basic;   
};


datablock ShipDesignDatablock(GirlScoutShip_Improved : GirlScoutShip)
{    
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved GirlScout"; 
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
      
   externalLink2 = "SmallLauncher";  
         
   externalLink3 = "SmallEmitter";
   externalLink4 = "SmallEmitter";
   
   externalLink5 = "ScannerEmitter_S";
   externalLink6 = "PointDefenseBeamEmitter_S";    
};
datablock ShipDesignDatablock(GirlScoutShip_Improved_A : GirlScoutShip_Improved)
{ 
   externalLink3 = "SmallCannon_pulse";
   externalLink4 = "SmallCannon_pulse";
   parentDesign = GirlScoutShip_Improved;   
};
datablock ShipDesignDatablock(GirlScoutShip_Improved_B : GirlScoutShip_Improved)
{ 
   externalLink3 = "SmallEmitter_ION";
   externalLink4 = "SmallCannon_pulse_Civ";
   parentDesign = GirlScoutShip_Improved;   
};
datablock ShipDesignDatablock(GirlScoutShip_Improved_C : GirlScoutShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK;     
   shipShield            = S_BasicCloak;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "HeavyArmor_S";
   
   externalLink5 = "PointDefenseBeamEmitter_S";
   externalLink6 = "PointDefenseBeamEmitter_S";    
   
   externalLink2 = "CloakBooster_S";  
   
   externalLink3 = "SmallCannon_cluster";
   externalLink4 = "SmallCannon_cluster";
   parentDesign = GirlScoutShip_Improved;   
};
datablock ShipDesignDatablock(GirlScoutShip_Improved_D : GirlScoutShip_Improved)
{ 
   deviceDescriptionBits = $SST_DEVICE_CLOAK;     
   shipShield            = S_BasicCloak;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "HeavyArmor_S";
   
   externalLink5 = "PointDefenseBeamEmitter_S";
   externalLink6 = "PointDefenseBeamEmitter_S";    
   
   externalLink2 = "CloakBooster_S";  
   
   externalLink3 = "SmallCannon_pulse";
   externalLink4 = "SmallCannon_pulse";
   parentDesign = GirlScoutShip_Improved;   
};




datablock ShipDesignDatablock(GirlScoutShip_Advanced : GirlScoutShip)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   friendlyName = "Advanced GirlScout"; 
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
   
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";
      
   externalLink2 = "ShieldBooster_S";   
         
   externalLink3 = "SmallCannon_rapid";
   externalLink4 = "SmallCannon_rapid"; 
   
   externalLink5 = "ScannerEmitter_S";
   externalLink6 = "PointDefenseBeamEmitter_S";   
};
datablock ShipDesignDatablock(GirlScoutShip_Advanced_A : GirlScoutShip_Advanced)
{               
   externalLink3 = "SmallEmitter_ION";
   externalLink4 = "SmallCannon_massDriver"; 
   parentDesign = GirlScoutShip_Advanced;  
};
datablock ShipDesignDatablock(GirlScoutShip_Advanced_B : GirlScoutShip_Advanced)
{               
   externalLink3 = "SmallCannon_pulse";
   externalLink4 = "SmallCannon_pulse"; 
   parentDesign = GirlScoutShip_Advanced;  
};
datablock ShipDesignDatablock(GirlScoutShip_Advanced_C : GirlScoutShip_Advanced)
{               
   deviceDescriptionBits = $SST_DEVICE_CLOAK;     
   shipShield            = S_ExperimentalCloak;
   
   externalLink5 = "PointDefenseBeamEmitter_S";
   externalLink6 = "PointDefenseBeamEmitter_S";   
   
   externalLink3 = "SmallCannon_cluster";
   externalLink4 = "SmallCannon_cluster"; 
   parentDesign = GirlScoutShip_Advanced;  
};
datablock ShipDesignDatablock(GirlScoutShip_Advanced_D : GirlScoutShip_Advanced)
{               
   deviceDescriptionBits = $SST_DEVICE_CLOAK;     
   shipShield            = S_ExperimentalCloak;
   
   externalLink5 = "PointDefenseBeamEmitter_S";
   externalLink6 = "PointDefenseBeamEmitter_S";   
   
   externalLink3 = "SmallCannon_pulse";
   externalLink4 = "SmallCannon_pulse"; 
   parentDesign = GirlScoutShip_Advanced;  
};
datablock ShipDesignDatablock(GirlScoutShip_Advanced_E : GirlScoutShip_Advanced)
{               
   deviceDescriptionBits = $SST_DEVICE_CLOAK;     
   shipShield            = S_ExperimentalCloak;
   
   externalLink5 = "PointDefenseBeamEmitter_S";
   externalLink6 = "PointDefenseBeamEmitter_S";   
   
   externalLink3 = "SmallEmitter_ION";
   externalLink4 = "SmallCannon_pulse_Civ"; 
   parentDesign = GirlScoutShip_Advanced;  
};

////////////////////////////////////////////////////////////////////////////////
// GEMINI
////////////////////////////////////////////////////////////////////////////////

/*

datablock ShipDesignDatablock(GeminiShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullGemini;  //This determines what we can put of the ship. 
    
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";

   turretLink6  = "SmallTurret";
   turretWeaponLink6_1  = "SmallEmitter_Civ";
   
   turretLink7  = "SmallTurret";
   turretWeaponLink7_1  = "SmallEmitter_Civ";
};

*/

////////////////////////////////////////////////////////////////////////////////
// ZOMBIE SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE LEECH
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_LeechShip : DefaultZombieShip)
{
   shipHull    = HullZombieLeech;  
   
      
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;

   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink2 = "SmallLauncher_Zombie";
   externalLink4 = "SmallCannon_zombie";
   externalLink5 = "SmallCannon_zombie";
};

/////////////////////////////////////////////
// THE WART
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_WartShip : DefaultZombieShip)
{
   shipHull    = HullZombieWart;  
   
      
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;

   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink6 = "SmallCannon_zombie";
   externalLink7 = "SmallCannon_zombie";
   
   externalLink8 = "SmallLauncher_zombie";
   externalLink9 = "SmallLauncher_zombie";
};

/////////////////////////////////////////////
// BOUNTY SHIPS
/////////////////////////////////////////////

/////////////////////////////////////////////
// CYCLOPS
/////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Small_01_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
     
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";

   externalLink6 = "HugeEmitter_Civ";
   externalLink7 = "MiningTractorEmitter";
   externalLink8 = "MiningTractorEmitter";
   externalLink9 = "MiningTractorEmitter";
};

///////////////////////////////
// Basic //////////////////////
///////////////////////////////

datablock ShipDesignDatablock(BountyShip_Small_01_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink6 = "HugeEmitter";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};

datablock ShipDesignDatablock(BountyShip_Small_01_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
  
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";
   
   externalLink6 = "HugeCannon_pulse";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};
///////////////////////////////
// Improveds //////////////////////
///////////////////////////////

datablock ShipDesignDatablock(BountyShip_Small_01_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink6 = "HugeEmitter";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};


datablock ShipDesignDatablock(BountyShip_Small_01_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_BasicCloak;
     
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "HeavyArmor_S";
   shipArmor_Port        = "HeavyArmor_S";

   externalLink6 = "HugeCannon_pulse";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};

datablock ShipDesignDatablock(BountyShip_Small_01_IMPROVED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;
     
   shipArmor_Front       = "HeavyArmor_S";   
   shipArmor_Starboard   = "HeavyArmor_S";
   shipArmor_Aft         = "HeavyArmor_S";
   shipArmor_Port        = "HeavyArmor_S";

   externalLink6 = "HugeCannon_rapid";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};

///////////////////////////////
// Advanced //////////////////////
///////////////////////////////


datablock ShipDesignDatablock(BountyShip_Small_01_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";

   externalLink6 = "HugeEmitter";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};


datablock ShipDesignDatablock(BountyShip_Small_01_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";

   externalLink6 = "HugeCannon_pulse";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};

datablock ShipDesignDatablock(BountyShip_Small_01_ADVANCED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";

   externalLink6 = "HugeCannon_rapid";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};


datablock ShipDesignDatablock(BountyShip_Small_01_ADVANCED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";

   externalLink6 = "HugeCannon_rapid";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};


datablock ShipDesignDatablock(BountyShip_Small_01_ADVANCED_E : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_01;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";

   externalLink6 = "HugeEmitter_HEAVY";
   externalLink7 = "ReactorBooster_S";
   externalLink8 = "ReactorBooster_S";
   externalLink9 = "ReactorBooster_S";
};
/////////////////////////////////////////////
// LEFT HOOK
/////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Small_02_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivCloak;
     
   shipArmor_Front       = "CivArmor_S";   
   shipArmor_Starboard   = "CivArmor_S";
   shipArmor_Aft         = "CivArmor_S";
   shipArmor_Port        = "CivArmor_S";

   externalLink6 = "LargeLauncher_Civ";
   externalLink7 = "MiningTractorEmitter";
   externalLink8 = "MiningTractorEmitter";
   externalLink9 = "MiningTractorEmitter";
   externalLink10 = "MiningTractorEmitter";
};

/////////////////////////////
// Basic ////////////////////
/////////////////////////////


datablock ShipDesignDatablock(BountyShip_Small_02_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicCloak;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink6 = "LargeLauncher";
   externalLink7 = "CloakBooster_S";
   externalLink8 = "CloakBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};

datablock ShipDesignDatablock(BountyShip_Small_02_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicCloak;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink6 = "LargeTorpedoLauncher";
   externalLink7 = "CloakBooster_S";
   externalLink8 = "CloakBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};


/////////////////////////////
// Improved  ///////////////////
/////////////////////////////


datablock ShipDesignDatablock(BountyShip_Small_02_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_StableCloak;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink6 = "LargeTorpedoLauncher";
   externalLink7 = "CloakBooster_S";
   externalLink8 = "LauncherBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};


datablock ShipDesignDatablock(BountyShip_Small_02_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_StableCloak;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink6 = "LargeLauncher";
   externalLink7 = "CloakBooster_S";
   externalLink8 = "LauncherBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};

datablock ShipDesignDatablock(BountyShip_Small_02_IMPROVED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_StableCloak;
     
   shipArmor_Front       = "TitaniumArmor_S";   
   shipArmor_Starboard   = "TitaniumArmor_S";
   shipArmor_Aft         = "TitaniumArmor_S";
   shipArmor_Port        = "TitaniumArmor_S";

   externalLink6 = "LargeRocketLauncher";
   externalLink7 = "CloakBooster_S";
   externalLink8 = "LauncherBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};


/////////////////////////////
// Advanced  ///////////////////
/////////////////////////////


datablock ShipDesignDatablock(BountyShip_Small_02_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";


   externalLink6 = "LargeRocketLauncher";
   externalLink7 = "LauncherBooster_S";
   externalLink8 = "LauncherBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};


datablock ShipDesignDatablock(BountyShip_Small_02_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";


   externalLink6 = "LargeHunterLauncher";
   externalLink7 = "LauncherBooster_S";
   externalLink8 = "LauncherBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};

datablock ShipDesignDatablock(BountyShip_Small_02_ADVANCED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";


   externalLink6 = "LargeLauncher";
   externalLink7 = "LauncherBooster_S";
   externalLink8 = "LauncherBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};


datablock ShipDesignDatablock(BountyShip_Small_02_ADVANCED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Small_02;  //This determines what we can put of the ship. 
     
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
     
   shipArmor_Front       = "AdvancedArmor_S";   
   shipArmor_Starboard   = "AdvancedArmor_S";
   shipArmor_Aft         = "AdvancedArmor_S";
   shipArmor_Port        = "AdvancedArmor_S";


   externalLink6 = "LargeTorpedoLauncher";
   externalLink7 = "LauncherBooster_S";
   externalLink8 = "LauncherBooster_S";
   externalLink9 = "LauncherBooster_S";
   externalLink10 = "LauncherBooster_S";
};
