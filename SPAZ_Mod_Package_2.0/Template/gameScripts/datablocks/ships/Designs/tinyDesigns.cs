
////////////////////////////////////////////////////////////////////////////////
// TINY SHIPS
////////////////////////////////////////////////////////////////////////////////

//$SST_DESIGN_CIV        
//$SST_DESIGN_BASIC        
//$SST_DESIGN_IMPROVED     
//$SST_DESIGN_ADVANCED    

/////////////////////////////////////////////
// THE SHORTBUS
/////////////////////////////////////////////

datablock ShipDesignDatablock(ShortBusShip : DefaultShip)
{
   friendlyName = "The Short Bus";    
   
   shipHull    = HullShortBus; 
   
   shipEngine            = S_CivEngine;   
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
   
   externalLink6 = "SmallMinerEmitter";
   
   externalLink7 = "MiningTractorEmitter";
   externalLink8 = "MiningTractorEmitter";
};

/////////////////////////////////////////////
// THE DART
/////////////////////////////////////////////

datablock ShipDesignDatablock(DartShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullDart;  //This determines what we can put of the ship. 
   
   friendlyName = "Surplus Dart";
   
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
          
   externalLink3 = "SmallEmitter_Civ";  
   externalLink4 = "SmallEmitter_Civ";    
};

datablock ShipDesignDatablock(DartShip_Basic : DartShip)
{   
   designDescriptionBits = $SST_DESIGN_BASIC;
   friendlyName = "Basic Dart";
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   externalLink3 = "SmallEmitter";   
   externalLink4 = "SmallEmitter";   
};
datablock ShipDesignDatablock(DartShip_Basic_A : DartShip_Basic)
{      
   externalLink3 = "SmallCannon_Pulse";   
   externalLink4 = "SmallCannon_Pulse";   
   parentDesign = DartShip_Basic;
};
datablock ShipDesignDatablock(DartShip_Basic_B : DartShip_Basic)
{      
   externalLink3 = "SmallCannon_pulse_Civ";   
   externalLink4 = "SmallCannon_pulse_Civ";  
   parentDesign = DartShip_Basic; 
};
datablock ShipDesignDatablock(DartShip_Basic_C : DartShip_Basic)
{      
   externalLink3 = "SmallEmitter_Civ";   
   externalLink4 = "SmallEmitter_Civ";   
   parentDesign = DartShip_Basic;
};
//NOTE: no basic cloakers.


datablock ShipDesignDatablock(DartShip_Improved : DartShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   friendlyName = "Improved Dart";
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
   
   externalLink3 = "SmallCannon_cluster"; 
   externalLink4 = "SmallCannon_cluster";     
};
datablock ShipDesignDatablock(DartShip_Improved_A : DartShip_Improved)
{      
   externalLink3 = "SmallCannon_Pulse";   
   externalLink4 = "SmallCannon_Pulse";   
   parentDesign = DartShip_Improved;
};
datablock ShipDesignDatablock(DartShip_Improved_B : DartShip_Improved)
{      
   externalLink3 = "SmallEmitter";   
   externalLink4 = "SmallEmitter";   
   parentDesign = DartShip_Improved;
};
datablock ShipDesignDatablock(DartShip_Improved_C : DartShip_Improved)
{      
   externalLink3 = "SmallEmitter_ION";   
   externalLink4 = "SmallEmitter";   
   parentDesign = DartShip_Improved;
};
datablock ShipDesignDatablock(DartShip_Improved_D : DartShip_Improved)
{      
   externalLink3 = "SmallCannon_pulse_Civ";   
   externalLink4 = "SmallCannon_pulse_Civ";  
   parentDesign = DartShip_Improved; 
};
datablock ShipDesignDatablock(DartShip_Improved_E : DartShip_Improved)
{      
   externalLink3 = "SmallEmitter_Civ";   
   externalLink4 = "SmallEmitter_Civ";   
   parentDesign = DartShip_Improved;
};


datablock ShipDesignDatablock(DartShip_Improved_Cloak : DartShip_Improved)
{   
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
     
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicCloak;
   
   parentDesign = DartShip_Improved; 
};
datablock ShipDesignDatablock(DartShip_Improved_A_Cloak : DartShip_Improved_Cloak)
{      
   externalLink3 = "SmallCannon_Pulse";   
   externalLink4 = "SmallCannon_Pulse";  
   parentDesign = DartShip_Improved; 
};
datablock ShipDesignDatablock(DartShip_Improved_B_Cloak : DartShip_Improved_Cloak)
{      
   externalLink3 = "SmallEmitter";   
   externalLink4 = "SmallEmitter";   
   parentDesign = DartShip_Improved; 
};
datablock ShipDesignDatablock(DartShip_Improved_C_Cloak : DartShip_Improved_Cloak)
{      
   externalLink3 = "SmallEmitter_ION";   
   externalLink4 = "SmallEmitter";   
   parentDesign = DartShip_Improved; 
};
datablock ShipDesignDatablock(DartShip_Improved_D_Cloak : DartShip_Improved_Cloak)
{      
   externalLink3 = "SmallCannon_pulse_Civ";   
   externalLink4 = "SmallCannon_pulse_Civ";   
   parentDesign = DartShip_Improved; 
};
datablock ShipDesignDatablock(DartShip_Improved_E_Cloak : DartShip_Improved_Cloak)
{      
   externalLink3 = "SmallEmitter_Civ";   
   externalLink4 = "SmallEmitter_Civ";   
   parentDesign = DartShip_Improved; 
};




datablock ShipDesignDatablock(DartShip_Advanced : DartShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;

   friendlyName = "Advanced Dart";
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;
   
   externalLink3 = "SmallCannon_rapid";
   externalLink4 = "SmallCannon_rapid";      
};
datablock ShipDesignDatablock(DartShip_Advanced_A : DartShip_Advanced)
{      
   externalLink3 = "SmallCannon_Pulse";   
   externalLink4 = "SmallCannon_Pulse";   
   parentDesign = DartShip_Advanced; 
};
datablock ShipDesignDatablock(DartShip_Advanced_B : DartShip_Advanced)
{      
   externalLink3 = "SmallEmitter";   
   externalLink4 = "SmallEmitter";   
   parentDesign = DartShip_Advanced; 
};
datablock ShipDesignDatablock(DartShip_Advanced_C : DartShip_Advanced)
{      
   externalLink3 = "SmallEmitter_ION";   
   externalLink4 = "SmallEmitter"; 
   parentDesign = DartShip_Advanced;   
};
datablock ShipDesignDatablock(DartShip_Advanced_D : DartShip_Advanced)
{      
   externalLink3 = "SmallEmitter";   
   externalLink4 = "SmallEmitter";   
   parentDesign = DartShip_Advanced; 
};
datablock ShipDesignDatablock(DartShip_Advanced_E : DartShip_Advanced)
{      
   externalLink3 = "SmallCannon_pulse_Civ";   
   externalLink4 = "SmallCannon_pulse_Civ"; 
   parentDesign = DartShip_Advanced;   
};
datablock ShipDesignDatablock(DartShip_Advanced_F : DartShip_Advanced)
{      
   externalLink3 = "SmallEmitter_Civ";   
   externalLink4 = "SmallEmitter_Civ";   
   parentDesign = DartShip_Advanced; 
};




datablock ShipDesignDatablock(DartShip_Advanced_Cloak : DartShip_Advanced)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 

   shipShield            = S_StableCloak;
   parentDesign = DartShip_Advanced; 
};
datablock ShipDesignDatablock(DartShip_Advanced_A_Cloak : DartShip_Advanced_Cloak)
{      
   externalLink3 = "SmallCannon_Pulse";   
   externalLink4 = "SmallCannon_Pulse";   
   parentDesign = DartShip_Advanced; 
};

datablock ShipDesignDatablock(DartShip_Advanced_B_Cloak : DartShip_Advanced_Cloak)
{      
   externalLink3 = "SmallEmitter";   
   externalLink4 = "SmallEmitter";   
   parentDesign = DartShip_Advanced; 
};
datablock ShipDesignDatablock(DartShip_Advanced_C_Cloak : DartShip_Advanced_Cloak)
{      
   externalLink3 = "SmallEmitter_ION";   
   externalLink4 = "SmallEmitter";  
   parentDesign = DartShip_Advanced;  
};
datablock ShipDesignDatablock(DartShip_Advanced_D_Cloak : DartShip_Advanced_Cloak)
{      
   externalLink3 = "SmallCannon_pulse_Civ";   
   externalLink4 = "SmallCannon_pulse_Civ";   
   parentDesign = DartShip_Advanced; 
};
datablock ShipDesignDatablock(DartShip_Advanced_E_Cloak : DartShip_Advanced_Cloak)
{      
   externalLink3 = "SmallCannon_pulse_Civ";   
   externalLink4 = "SmallCannon_pulse_Civ";
   parentDesign = DartShip_Advanced;    
};
datablock ShipDesignDatablock(DartShip_Advanced_F_Cloak : DartShip_Advanced_Cloak)
{      
   externalLink3 = "SmallEmitter_Civ";   
   externalLink4 = "SmallEmitter_Civ";   
   parentDesign = DartShip_Advanced; 
};




datablock ShipDesignDatablock(DartShip_tutorial : DartShip)
{   
   //used for tutorial only
   friendlyName = "Mining Dart";
   externalLink3 = "SmallMinerEmitter";
   externalLink4 = "SmallMinerEmitter"; 
   
   includeInSSTDatabase = false;     
};

/////////////////////////////////////////////
// THE RANGER
/////////////////////////////////////////////

datablock ShipDesignDatablock(RangerShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullRanger;  //This determines what we can put of the ship. 
   
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
        
   
   externalLink3 = "SmallEmitter_Civ";  
   externalLink2 = "SmallLauncher_Civ";    
};


datablock ShipDesignDatablock(RangerShip_Basic : RangerShip)
{  
   designDescriptionBits = $SST_DESIGN_BASIC; 
   friendlyName = "Basic Ranger";
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   externalLink3 = "SmallEmitter";  
   externalLink2 = "SmallLauncher";    
};
datablock ShipDesignDatablock(RangerShip_Basic_A : RangerShip_Basic)
{     
   externalLink3 = "SmallEmitter_Civ";  
   externalLink2 = "SmallLauncher";    
   parentDesign = RangerShip_Basic; 
};
datablock ShipDesignDatablock(RangerShip_Basic_B : RangerShip_Basic)
{     
   externalLink3 = "SmallCannon_pulse_Civ";  
   externalLink2 = "SmallLauncher";   
   parentDesign = RangerShip_Basic;  
};
datablock ShipDesignDatablock(RangerShip_Basic_C : RangerShip_Basic)
{     
   externalLink3 = "SmallCannon_Pulse";  
   externalLink2 = "SmallLauncher";    
   parentDesign = RangerShip_Basic; 
};




datablock ShipDesignDatablock(RangerShip_improved : RangerShip_Basic)
{     
   designDescriptionBits = $SST_DESIGN_IMPROVED;  
   friendlyName = "Improved Ranger";
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
   
   externalLink3 = "SmallEmitter";  
   externalLink2 = "SmallLauncher"; 
};
datablock ShipDesignDatablock(RangerShip_improved_A : RangerShip_improved)
{
   externalLink3 = "SmallEmitter_Civ";  
   externalLink2 = "SmallLauncher"; 
   parentDesign = RangerShip_improved; 
};
datablock ShipDesignDatablock(RangerShip_improved_B : RangerShip_improved)
{     
   externalLink3 = "SmallCannon_pulse_Civ";  
   externalLink2 = "SmallLauncher";    
   parentDesign = RangerShip_improved; 
};
datablock ShipDesignDatablock(RangerShip_improved_C : RangerShip_improved)
{     
   externalLink3 = "SmallCannon_Pulse";  
   externalLink2 = "SmallLauncher";    
   parentDesign = RangerShip_improved; 
};
datablock ShipDesignDatablock(RangerShip_improved_D : RangerShip_improved)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipEngine            = S_BasicEngine;    
   shipShield            = S_BasicCloak;
   externalLink3 = "SmallCannon_cluster";  
   externalLink2 = "CloakBooster_S";    
   parentDesign = RangerShip_improved; 
};
datablock ShipDesignDatablock(RangerShip_improved_E : RangerShip_improved)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipEngine            = S_BasicEngine;    
   shipShield            = S_BasicCloak;
   externalLink3 = "SmallEmitter_ION";  
   externalLink2 = "CloakBooster_S";    
   parentDesign = RangerShip_improved; 
};


datablock ShipDesignDatablock(RangerShip_advanced : RangerShip_Basic)
{   
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   friendlyName = "Advanced Ranger";
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;
      
   externalLink3 = "SmallCannon_rapid";  
   externalLink2 = "SmallLauncher";    
};
datablock ShipDesignDatablock(RangerShip_advanced_A : RangerShip_advanced)
{
   externalLink3 = "SmallEmitter";  
   externalLink2 = "SmallLauncher"; 
   parentDesign = RangerShip_advanced; 
};
datablock ShipDesignDatablock(RangerShip_advanced_B : RangerShip_advanced)
{
   externalLink3 = "SmallEmitter_Civ";  
   externalLink2 = "SmallLauncher_GRAV"; 
   parentDesign = RangerShip_advanced; 
};
datablock ShipDesignDatablock(RangerShip_advanced_C : RangerShip_advanced)
{
   externalLink3 = "SmallCannon_Pulse";  
   externalLink2 = "SmallLauncher_GRAV"; 
   parentDesign = RangerShip_advanced; 
};
datablock ShipDesignDatablock(RangerShip_advanced_D : RangerShip_advanced)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_StableCloak;
   externalLink3 = "SmallCannon_cluster";  
   externalLink2 = "CloakBooster_S";    
   parentDesign = RangerShip_advanced; 
};
datablock ShipDesignDatablock(RangerShip_advanced_E : RangerShip_advanced)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK;    
   shipShield            = S_StableCloak;
   externalLink3 = "SmallEmitter_ION";  
   externalLink2 = "CloakBooster_S";    
   parentDesign = RangerShip_advanced; 
};
datablock ShipDesignDatablock(RangerShip_advanced_F : RangerShip_advanced)
{
   externalLink3 = "SmallEmitter_LEECH";  
   externalLink2 = "SmallLauncher_GRAV"; 
   parentDesign = RangerShip_advanced; 
};



////////////////////////////////////////////////////////////////////////////////
// CIV SHIPS
////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////
// THE MOLE
/////////////////////////////////////////////

datablock ShipDesignDatablock(MoleShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullMole;  //This determines what we can put of the ship. 
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
          
   externalLink5 = "SmallLauncher_Civ"; 
   externalLink6 = "SmallLauncher_Civ"; 
};

datablock ShipDesignDatablock(MoleShip_basic : MoleShip)
{    
   designDescriptionBits = $SST_DESIGN_BASIC; 
   friendlyName = "Basic Mole";
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   externalLink5 = "SmallLauncher";  
   externalLink6 = "SmallLauncher";  
};



datablock ShipDesignDatablock(MoleShip_improved : MoleShip)
{    
   designDescriptionBits = $SST_DESIGN_IMPROVED; 
   friendlyName = "Improved Mole";
   
   shipEngine            = S_BasicEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
   
   externalLink5 = "SmallRocketLauncher";
   externalLink6 = "SmallRocketLauncher";    
};
datablock ShipDesignDatablock(MoleShip_improved_A : MoleShip_improved)
{     
   shipEngine            = S_ThrusterEngine;   
   externalLink5 = "SmallLauncher";
   externalLink6 = "SmallLauncher";    
   parentDesign = MoleShip_improved; 
};
datablock ShipDesignDatablock(MoleShip_improved_B : MoleShip_improved)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_BasicCloak;
   externalLink5 = "SmallLauncher";
   externalLink6 = "SmallLauncher";    
   parentDesign = MoleShip_improved; 
};
datablock ShipDesignDatablock(MoleShip_improved_C : MoleShip_improved)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_BasicCloak;
   externalLink5 = "SmallRocketLauncher";
   externalLink6 = "SmallRocketLauncher";   
   parentDesign = MoleShip_improved;  
};



datablock ShipDesignDatablock(MoleShip_advanced : MoleShip)
{    
   designDescriptionBits = $SST_DESIGN_ADVANCED; 
  
   friendlyName = "Advanced Mole";
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;    
   
   externalLink5 = "SmallLauncher"; 
   externalLink6 = "SmallLauncher";   
};
datablock ShipDesignDatablock(MoleShip_advanced_A : MoleShip_advanced)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_StableCloak;
   externalLink5 = "SmallRocketLauncher";
   externalLink6 = "SmallRocketLauncher";    
   parentDesign = MoleShip_advanced; 
};
datablock ShipDesignDatablock(MoleShip_advanced_B : MoleShip_advanced)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_StableCloak;
   externalLink5 = "SmallLauncher_GRAV";
   externalLink6 = "SmallLauncher_GRAV";  
   parentDesign = MoleShip_advanced;  
};
datablock ShipDesignDatablock(MoleShip_advanced_C : MoleShip_advanced)
{     
   externalLink5 = "SmallHunterLauncher";
   externalLink6 = "SmallHunterLauncher"; 
   parentDesign = MoleShip_advanced;   
};


/////////////////////////////////////////////
// THE CAB
/////////////////////////////////////////////

datablock ShipDesignDatablock(CabShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullCab;  //This determines what we can put of the ship. 
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
   
   externalLink2 = "MiningTractorEmitter";
   externalLink3 = "MiningTractorEmitter"; 
   externalLink4 = "SmallCannon_Pulse_Civ"; 
   externalLink5 = "SmallCannon_Pulse_Civ";   
};


datablock ShipDesignDatablock(CabShip_basic : CabShip)
{    
   designDescriptionBits = $SST_DESIGN_BASIC; 
   friendlyName = "Basic Mole";
   
   shipEngine            = S_BasicEngine;   
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
           
   externalLink2 = "SurplusScannerEmitter_S";
   externalLink3 = "SurplusScannerEmitter_S"; 
   externalLink4 = "SmallCannon_Pulse"; 
   externalLink5 = "SmallCannon_Pulse";           
};
datablock ShipDesignDatablock(CabShip_basic_A : CabShip_basic)
{   
   externalLink4 = "SmallCannon_Pulse_Civ"; 
   externalLink5 = "SmallCannon_Pulse_Civ";     
   parentDesign = CabShip_basic;      
};
datablock ShipDesignDatablock(CabShip_basic_B : CabShip_basic)
{   
   externalLink4 = "SmallEmitter_Civ"; 
   externalLink5 = "SmallEmitter_Civ";   
   parentDesign = CabShip_basic;           
};
datablock ShipDesignDatablock(CabShip_basic_C : CabShip_basic)
{   
   externalLink4 = "SmallEmitter"; 
   externalLink5 = "SmallEmitter";    
   parentDesign = CabShip_basic;          
};




datablock ShipDesignDatablock(CabShip_improved : CabShip)
{    
   designDescriptionBits = $SST_DESIGN_IMPROVED; 
   friendlyName = "Improved Petri";
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
                  
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "SurplusScannerEmitter_S"; 
   externalLink4 = "SmallCannon_Pulse_Civ"; 
   externalLink5 = "SmallCannon_Pulse_Civ";      
};
datablock ShipDesignDatablock(CabShip_improved_A : CabShip_improved)
{     
   externalLink4 = "SmallCannon_Pulse"; 
   externalLink5 = "SmallCannon_Pulse";      
   parentDesign = CabShip_improved;   
};
datablock ShipDesignDatablock(CabShip_improved_B : CabShip_improved)
{     
   externalLink4 = "SmallEmitter_Civ"; 
   externalLink5 = "SmallEmitter_Civ";     
   parentDesign = CabShip_improved;    
};
datablock ShipDesignDatablock(CabShip_improved_C : CabShip_improved)
{    
   externalLink4 = "SmallEmitter"; 
   externalLink5 = "SmallEmitter";      
   parentDesign = CabShip_improved;   
};
datablock ShipDesignDatablock(CabShip_improved_D : CabShip_improved)
{    
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_BasicCloak;
   
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "PointDefenseBeamEmitter_S"; 
   externalLink4 = "SmallCannon_cluster"; 
   externalLink5 = "SmallCannon_cluster"; 
   parentDesign = CabShip_improved;        
};
datablock ShipDesignDatablock(CabShip_improved_E : CabShip_improved)
{    
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_BasicCloak;
   
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "PointDefenseBeamEmitter_S"; 
   externalLink4 = "SmallEmitter_ION"; 
   externalLink5 = "SmallEmitter_ION";  
   parentDesign = CabShip_improved;       
};



datablock ShipDesignDatablock(CabShip_advanced : CabShip)
{    
   designDescriptionBits = $SST_DESIGN_ADVANCED; 
   friendlyName = "Advanced Petri";
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;   
              
   externalLink2 = "ScannerEmitter_S";
   externalLink3 = "ScannerEmitter_S"; 
   externalLink4 = "SmallCannon_rapid"; 
   externalLink5 = "SmallCannon_rapid";       
};
datablock ShipDesignDatablock(CabShip_advanced_A : CabShip_advanced)
{     
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "PointDefenseBeamEmitter_S"; 
   externalLink4 = "SmallCannon_Pulse"; 
   externalLink5 = "SmallCannon_Pulse"; 
   parentDesign = CabShip_advanced;         
};
datablock ShipDesignDatablock(CabShip_advanced_B : CabShip_advanced)
{     
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "ScannerEmitter_S"; 
   externalLink4 = "SmallEmitter"; 
   externalLink5 = "SmallEmitter";   
   parentDesign = CabShip_advanced;           
};
datablock ShipDesignDatablock(CabShip_advanced_C : CabShip_advanced)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_StableCloak;
   
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "PointDefenseBeamEmitter_S"; 
   externalLink4 = "SmallCannon_cluster"; 
   externalLink5 = "SmallCannon_cluster"; 
   parentDesign = CabShip_advanced;             
};
datablock ShipDesignDatablock(CabShip_advanced_D : CabShip_advanced)
{     
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_StableCloak;
   
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "PointDefenseBeamEmitter_S"; 
   externalLink4 = "SmallEmitter_ION"; 
   externalLink5 = "SmallEmitter_ION";   
   parentDesign = CabShip_advanced;           
};
datablock ShipDesignDatablock(CabShip_advanced_E : CabShip_advanced)
{     
   externalLink2 = "PointDefenseBeamEmitter_S";
   externalLink3 = "PointDefenseBeamEmitter_S"; 
   externalLink4 = "SmallEmitter_LEECH"; 
   externalLink5 = "SmallEmitter_LEECH";  
   parentDesign = CabShip_advanced;            
};

/////////////////////////////////////////////
// THE RETENA
/////////////////////////////////////////////

datablock ShipDesignDatablock(RetinaShip : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullRetina;  //This determines what we can put of the ship. 
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
   
   turretLink1  = "SmallTurret";
   turretWeaponLink1_1  = "SmallEmitter_Civ";   
};


datablock ShipDesignDatablock(RetinaShip_basic : RetinaShip)
{    
   designDescriptionBits = $SST_DESIGN_BASIC; 
   friendlyName = "Basic Gyro";
   
   shipEngine            = S_BasicEngine;   
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   turretLink1  = "SmallTurret";
   turretWeaponLink1_1  = "SmallEmitter";   
};
datablock ShipDesignDatablock(RetinaShip_basic_A : RetinaShip_basic)
{       
   turretWeaponLink1_1  = "SmallEmitter_Civ";  
   parentDesign = RetinaShip_basic;        
};
datablock ShipDesignDatablock(RetinaShip_basic_B : RetinaShip_basic)
{       
   turretWeaponLink1_1  = "SmallCannon_Pulse";   
   parentDesign = RetinaShip_basic;   
};
datablock ShipDesignDatablock(RetinaShip_basic_C : RetinaShip_basic)
{       
   turretWeaponLink1_1  = "SmallCannon_Pulse_Civ"; 
   parentDesign = RetinaShip_basic;     
};



datablock ShipDesignDatablock(RetinaShip_improved : RetinaShip)
{    
   designDescriptionBits = $SST_DESIGN_IMPROVED; 
   friendlyName = "Improved Gyro";
   
   shipEngine            = S_ThrusterEngine;    
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicShield;    
        
   turretLink1  = "SmallTurret";
   turretWeaponLink1_1  = "SmallEmitter";      
};
datablock ShipDesignDatablock(RetinaShip_improved_A : RetinaShip_improved)
{        
   turretWeaponLink1_1  = "SmallEmitter_Civ"; 
   parentDesign = RetinaShip_improved;        
};
datablock ShipDesignDatablock(RetinaShip_improved_B : RetinaShip_improved)
{        
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_BasicCloak;
   turretLink1  = "SmallFixedTurretMod";  
   turretWeaponLink1_1  = "MediumCannon_Pulse";  
   parentDesign = RetinaShip_improved;        
};
datablock ShipDesignDatablock(RetinaShip_improved_C : RetinaShip_improved)
{        
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_BasicCloak;
   turretLink1  = "SmallFixedTurretMod";  
   turretWeaponLink1_1  = "MediumCannon_Pulse_Civ"; 
   parentDesign = RetinaShip_improved;         
};
datablock ShipDesignDatablock(RetinaShip_improved_D : RetinaShip_improved)
{        
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_BasicCloak;
   turretLink1  = "SmallFixedTurretMod";  
   turretWeaponLink1_1  = "MediumCannon_cluster"; 
   parentDesign = RetinaShip_improved;         
};
datablock ShipDesignDatablock(RetinaShip_improved_E : RetinaShip_improved)
{        
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_BasicCloak;
   turretWeaponLink1_1  = "SmallEmitter_ION";  
   parentDesign = RetinaShip_improved;        
};


datablock ShipDesignDatablock(RetinaShip_advanced : RetinaShip)
{    
   designDescriptionBits = $SST_DESIGN_ADVANCED; 
 
   friendlyName = "Advanced Gyro";
   
   shipEngine            = S_InertialEngine;    
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;   
       
   turretLink1  = "SmallTurret";
   turretWeaponLink1_1  = "SmallCannon_rapid";         
};
datablock ShipDesignDatablock(RetinaShip_advanced_A : RetinaShip_advanced)
{   
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_StableCloak;
   turretLink1  = "SmallFixedTurretMod";   
   turretWeaponLink1_1  = "MediumCannon_Cluster";    
   parentDesign = RetinaShip_advanced;         
};
datablock ShipDesignDatablock(RetinaShip_advanced_B : RetinaShip_advanced)
{   
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_StableCloak;
   turretWeaponLink1_1  = "SmallEmitter_ION";    
   parentDesign = RetinaShip_advanced;         
};
datablock ShipDesignDatablock(RetinaShip_advanced_C : RetinaShip_advanced)
{   
   deviceDescriptionBits = $SST_DEVICE_CLOAK; 
   shipShield            = S_StableCloak;
   turretLink1  = "SmallFixedTurretMod";   
   turretWeaponLink1_1  = "MediumCannon_Pulse";   
   parentDesign = RetinaShip_advanced;          
};
datablock ShipDesignDatablock(RetinaShip_advanced_D : RetinaShip_advanced)
{   
   turretWeaponLink1_1  = "SmallEmitter_ION";   
   parentDesign = RetinaShip_advanced;          
};
datablock ShipDesignDatablock(RetinaShip_advanced_E : RetinaShip_advanced)
{   
   turretWeaponLink1_1  = "SmallEmitter_LEECH";   
   parentDesign = RetinaShip_advanced;          
};
datablock ShipDesignDatablock(RetinaShip_advanced_F : RetinaShip_advanced)
{   
   turretWeaponLink1_1  = "SmallCannon_massDriver";    
   parentDesign = RetinaShip_advanced;           
};

/////////////////////////////////////////////
// THE TICK
/////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_TickShip : DefaultZombieShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullTick;  //This determines what we can put of the ship. 
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
           
   externalLink5 = "SmallCannon_zombie";   
};

/////////////////////////////////////////////
// BOUNTY SHIPS
/////////////////////////////////////////////

/////////////////////////////////////////////
// THE CLAW
/////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Tiny_01_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
   
   externalLink6 = "MediumEmitter_Civ";   
   externalLink7 = "MediumEmitter_Civ";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_01_CIV_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
   
   externalLink6 = "MediumCannon_Pulse_Civ";   
   externalLink7 = "MediumCannon_Pulse_Civ";   
};

//////////////////////////////////
// Basic /////////////////////////
//////////////////////////////////
datablock ShipDesignDatablock(BountyShip_Tiny_01_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   externalLink6 = "MediumEmitter";   
   externalLink7 = "MediumEmitter";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_01_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   externalLink6 = "MediumCannon_Pulse";   
   externalLink7 = "MediumCannon_Pulse";   
};


datablock ShipDesignDatablock(BountyShip_Tiny_01_BASIC_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicCloak;
   
   externalLink6 = "MediumCannon_Pulse";   
   externalLink7 = "MediumCannon_Pulse";   
};


//////////////////////////////////
// Improved /////////////////////////
//////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Tiny_01_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_ThrusterEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicCloak;
   
   externalLink6 = "MediumCannon_Pulse";   
   externalLink7 = "MediumCannon_Pulse";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_01_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_ThrusterEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicCloak;
   
   externalLink6 = "MediumCannon_cluster";   
   externalLink7 = "MediumCannon_cluster";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_01_IMPROVED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_ThrusterEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_QuickChargeShield;
   
   externalLink6 = "MediumEmitter";   
   externalLink7 = "MediumEmitter";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_01_IMPROVED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_ThrusterEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_QuickChargeShield;
   
   externalLink6 = "MediumCannon_rapid";   
   externalLink7 = "MediumCannon_rapid";   
};

//////////////////////////////////
// Advanced /////////////////////////
//////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Tiny_01_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
   
   externalLink6 = "MediumEmitter";   
   externalLink7 = "MediumEmitter";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_01_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
   
   externalLink6 = "MediumEmitter_Heavy";   
   externalLink7 = "MediumEmitter_Heavy";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_01_ADVANCED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
   
   externalLink6 = "MediumEmitter_ION";   
   externalLink7 = "MediumEmitter_ION";   
};


datablock ShipDesignDatablock(BountyShip_Tiny_01_ADVANCED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
   
   externalLink6 = "MediumCannon_Pulse";   
   externalLink7 = "MediumCannon_Pulse";   
};


datablock ShipDesignDatablock(BountyShip_Tiny_01_ADVANCED_E : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
   
   externalLink6 = "MediumCannon_cluster";   
   externalLink7 = "MediumCannon_cluster";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_01_ADVANCED_F : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_01;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_FortressShield;
   
   externalLink6 = "MediumCannon_rapid";   
   externalLink7 = "MediumCannon_rapid";   
};
/////////////////////////////////////////////
// TINY 2
/////////////////////////////////////////////

datablock ShipDesignDatablock(BountyShip_Tiny_02_CIV_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_CIV;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_CivEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_CivReactor;
   shipShield            = S_CivShield;
   
   externalLink5 = "MediumLauncher_Civ";   
   externalLink6 = "MiningTractorEmitter";   
   externalLink7 = "MiningTractorEmitter";   
};

////////////////////////////
// Basic ///////////////////
////////////////////////////

datablock ShipDesignDatablock(BountyShip_Tiny_02_BASIC_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   externalLink5 = "MediumLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_02_BASIC_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicShield;
   
   externalLink5 = "MediumTorpedoLauncher";   
   externalLink6 = "EngineBooster_S";   
   externalLink7 = "ShieldBooster_S";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_02_BASIC_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicCloak;
   
   externalLink5 = "MediumLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_02_BASIC_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_BASIC;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_BasicReactor;
   shipShield            = S_BasicCloak;
   
   externalLink5 = "MediumTorpedoLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};
////////////////////////////
// Improved/////////////////
////////////////////////////

datablock ShipDesignDatablock(BountyShip_Tiny_02_IMPROVED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicCloak;
   
   externalLink5 = "MediumRocketLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_02_IMPROVED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicCloak;
   
   externalLink5 = "MediumHunterLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_02_IMPROVED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicCloak;
   
   externalLink5 = "MediumTorpedoLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_02_IMPROVED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_IMPROVED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_BasicEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_HighCapacityReactor;
   shipShield            = S_BasicCloak;
   
   externalLink5 = "MediumLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};

////////////////////////////
// Advanced /////////////////
////////////////////////////

datablock ShipDesignDatablock(BountyShip_Tiny_02_ADVANCED_A : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
   
   externalLink5 = "MediumTorpedoLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};

datablock ShipDesignDatablock(BountyShip_Tiny_02_ADVANCED_B : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
   
   externalLink5 = "MediumLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};


datablock ShipDesignDatablock(BountyShip_Tiny_02_ADVANCED_C : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
   
   externalLink5 = "MediumHunterLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};


datablock ShipDesignDatablock(BountyShip_Tiny_02_ADVANCED_D : DefaultShip)
{
   designDescriptionBits = $SST_DESIGN_ADVANCED;
   
   //Determines the skeleton for the ship.  
   shipHull    = HullBounty_Tiny_02;  //This determines what we can put of the ship. 
      
   shipEngine            = S_InertialEngine;    //Not in quotes so can right click name and jump to definition in torsion 
   shipReactor           = S_OverchargedReactor;
   shipShield            = S_ExperimentalCloak;
   
   externalLink5 = "MediumRocketLauncher";   
   externalLink6 = "LauncherBooster_S";   
   externalLink7 = "LauncherBooster_S";   
};

