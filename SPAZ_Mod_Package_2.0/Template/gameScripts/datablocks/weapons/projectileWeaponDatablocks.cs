
function ProjectileWeaponDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "ProjectileCannonBase" )
      return;
            
   Parent::onAdd(%this);            
}




////////////////////////////////////////////////
// PROCEDURAL STATS  ///////////////////////////
////////////////////////////////////////////////
//These are the numbers for the basic military version. 

$CANNONDATA["PowerConsumption", $HULLTYPE_SMALL]        = 0.800;
$CANNONDATA["PowerConsumption", $HULLTYPE_MEDIUM]       = 1.100;   
$CANNONDATA["PowerConsumption", $HULLTYPE_LARGE]        = 1.200;  
$CANNONDATA["PowerConsumption", $HULLTYPE_HUGE]         = 1.500;    
$CANNONDATA["PowerConsumption", $HULLTYPE_MOTHERSHIP]   = 0;   
$CANNONDATA["PowerConsumption", $HULLTYPE_STATION]      = 0;

$CANNONDATA["ResourceCost", $HULLTYPE_SMALL]                = 2;  
$CANNONDATA["ResourceCost", $HULLTYPE_MEDIUM]               = 6;    
$CANNONDATA["ResourceCost", $HULLTYPE_LARGE]                = 20;   
$CANNONDATA["ResourceCost", $HULLTYPE_HUGE]                 = 60;   
$CANNONDATA["ResourceCost", $HULLTYPE_MOTHERSHIP]           = 0; 
$CANNONDATA["ResourceCost", $HULLTYPE_STATION]              = 0;


function ProjectileWeaponDatablock::GetProceduralData(%this, %statID)
{
   %datum = $CANNONDATA[%statID, %this.hullType];
   if ( %datum $= "" )
      echo("$CANNONDATA::GetProceduralData WARNING: Trying to get invalid procedural Stat!" SPC %statID);
   
   return %datum;
}


////////////////////////
// $CANNONMULTS ////////
////////////////////////
//This is how we keep technology consistent between categories. 

$CANNONMULTS["PowerConsumption", "BASIC"]      = 1.000; //machine gun, self tuning with spread so leave low
$CANNONMULTS["PowerConsumption", "CIV"]        = 0.667; 
$CANNONMULTS["PowerConsumption", "CREW"]       = 0.500;  //crew in other file. 
$CANNONMULTS["PowerConsumption", "BLAST"]      = 1.500;  
$CANNONMULTS["PowerConsumption", "RAPID"]      = 0.333;
$CANNONMULTS["PowerConsumption", "MASSDRIVER"] = 1.500;
$CANNONMULTS["PowerConsumption", "DRONE"]      = 0.000;
$CANNONMULTS["PowerConsumption", "ZOMBIE"]     = 0;

$CANNONMULTS["ResourceCost", "BASIC"]         = 1.000;
$CANNONMULTS["ResourceCost", "CIV"]           = 0.500;  
$CANNONMULTS["ResourceCost", "CREW"]          = 2.000;
$CANNONMULTS["ResourceCost", "BLAST"]         = 2.000;
$CANNONMULTS["ResourceCost", "RAPID"]         = 4.000;
$CANNONMULTS["ResourceCost", "MASSDRIVER"]    = 4.000;
$CANNONMULTS["ResourceCost", "DRONE"]         = 0;
$CANNONMULTS["ResourceCost", "ZOMBIE"]        = 0;

function ProjectileWeaponDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $CANNONMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("$CANNONMULTS::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}


////////////////////////////////////////////////
// BaseClass ///////////////////////////////////
////////////////////////////////////////////////

datablock ProjectileWeaponDatablock(ProjectileCannonBase : WeaponBase) 
{   
   componentType      = "External";
   componentSubType   = $WEAPON_ProjectileCannon;
   isAutomated        = false;
   isBurstCannon      = false;
   
   damageMult        = "1";  
   speedMult         = "1";  
   rangeMult         = "1";   
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   clusterCount = 1; //how many bullets we shoot in a frame.
   clusterSpreadTime = 0; //meaning we will always be at max spread.   
   clusterSpreadResetTime = 0.750; //takes this long to get accuracy back
   
   cannonClass = "";
   cannonSuperClass = "";
   
   WeaponMountDatablock = "DefaultWeaponMount";
   
   researchDatablock = "ProjectileResearch";
   
   componentButtonColor = "Basic";
   
   purchaseTutorial = "PT_pulseCannon";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_None;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Med;  //long range lasers and projectiles
   threat_Short = $WT_Low; //$WT_None $WT_Low $WT_Med $WT_High
};

//////////////////////////////////////////////////
// Smalls ////////////////////////////////////////
//////////////////////////////////////////////////


datablock ProjectileWeaponDatablock(SmallCannon_pulse : ProjectileCannonBase) 
{
   friendlyName = "Small Pulse Cannon";
   
   reloadMS          = "1000";
   burstSize         = "1";
   ammoType          = "smallBullet_cannon";
         
   myType = "BASIC";
   
   clusterSpread     = "0";  //in degrees   
   
   componentIconGraphic        = "shipconIcon_cannonBall";
     
   componentButtonColor        = "Basic";
   
   WeaponMountDatablock = "SmallCannonMount"; 
   
   purchaseTutorial = "PT_pulseCannon";
   
   //inherited stuff
   componentSize      = $SLOT_SMALL;    
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
   
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;   
   
   threat_Long = $WT_None;     
   threat_Medium = $WT_High;  
   threat_Short = $WT_Med;    
};

datablock ProjectileWeaponDatablock(SmallCannon_pulse_Civ : SmallCannon_pulse) 
{
   friendlyName = "Small Civilian Pulse Cannon";
   
   purchaseTutorial = "PT_pulseCannon_civ";
   
   reloadMS          = "750";
        
   myType = "CIV";

   componentButtonColor        = "Civ";
   ammoType          = "smallBullet_cannon_civ";
   
   threat_Long = $WT_None;     
   threat_Medium = $WT_High;  
   threat_Short = $WT_Med;    
};

datablock ProjectileWeaponDatablock(SmallCannon_rapid : SmallCannon_pulse) 
{
   friendlyName = "Small Basic Cannon";
   
   reloadMS          = "375";
   burstSize         = "6";
   ammoType          = "SmallBullet";
   
   myType = "RAPID"; //used for procedural systmes.
   
    
   componentIconGraphic        = "shipconIcon_cannon";
   componentButtonColor        = "Advanced";
 
   WeaponMountDatablock = "SmallCannonMount_rapid"; 
      
   purchaseTutorial = "PT_rapidCannon";     
   
   threat_Long = $WT_None;     
   threat_Medium = $WT_Med;  
   threat_Short = $WT_Med;    
};

datablock ProjectileWeaponDatablock(SmallCannon_cluster : SmallCannon_pulse) 
{
   friendlyName = "Small Cluster Cannon";
   
   reloadMS          = "1000";
   burstSize         = "1";
   ammoType          = "SmallBullet_cluster";
         
   myType = "BLAST";
   
   clusterSpreadTime = 0;
   clusterCount      = 6;
   clusterSpread     = "20";  //in degrees
   
   componentIconGraphic        = "shipconIcon_clusterCannon";
      
   componentButtonColor        = "Improved";
   
   WeaponMountDatablock = "SmallCannonMount_cluster"; 
   
   purchaseTutorial = "PT_clusterCannon";  
   
   threat_Long = $WT_None;     
   threat_Medium = $WT_None;  
   threat_Short = $WT_High;    
};

datablock ProjectileWeaponDatablock(SmallCannon_massDriver : SmallCannon_pulse) 
{
   friendlyName = "Small Mass Driver";
   
   reloadMS          = "750";
   burstSize         = "1";
   ammoType          = "SmallBullet_massDriver";
         
   myType = "MASSDRIVER";
   
   clusterSpread     = "0";  //in degrees
   
   componentIconGraphic        = "shipconIcon_railgun";
   
   componentButtonColor        = "Improved";
   
   WeaponMountDatablock = "SmallCannonMount_massDriver";
   
   purchaseTutorial = "PT_massDriver";   
   
   threat_Long = $WT_None;     
   threat_Medium = $WT_High;  
   threat_Short = $WT_Med;    
};

//////////////////////////////////////////////////
// Mediums ////////////////////////////////////////
//////////////////////////////////////////////////

datablock ProjectileWeaponDatablock(MediumCannon_pulse : ProjectileCannonBase) 
{
   friendlyName = "Medium Pulse Cannon";
   
   reloadMS          = "1200";
   burstSize         = "1";
   ammoType          = "MediumBullet_cannon";
         
   myType = "BASIC";
   
   clusterSpread     = "0";  //in degrees   
   
   componentIconGraphic        = "shipconIcon_cannonBall";
   

   
   componentButtonColor        = "Basic";
   
   WeaponMountDatablock = "MediumCannonMount"; 
   
   purchaseTutorial = "PT_pulseCannon";
   
   //inherited stuff
   componentSize      = $SLOT_MEDIUM;    
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
   
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
   
   threat_Long = SmallCannon_pulse.threat_Long;     
   threat_Medium = SmallCannon_pulse.threat_Medium;      
   threat_Short = SmallCannon_pulse.threat_Short;           
};

datablock ProjectileWeaponDatablock(MediumCannon_pulse_Civ : MediumCannon_pulse) 
{
   friendlyName = "Medium Civilian Pulse Cannon";
   
   purchaseTutorial = "PT_pulseCannon_civ";
   
   reloadMS          = "900";
        
   myType = "CIV";

   componentButtonColor        = "Civ";
   ammoType          = "mediumBullet_cannon_civ";
   
   threat_Long = SmallCannon_pulse_Civ.threat_Long;     
   threat_Medium = SmallCannon_pulse_Civ.threat_Medium;      
   threat_Short = SmallCannon_pulse_Civ.threat_Short;    
};

datablock ProjectileWeaponDatablock(MediumCannon_rapid : MediumCannon_pulse) 
{
   friendlyName = "Medium Basic Cannon";
   
   reloadMS          = "450";
   burstSize         = "6";
   ammoType          = "MediumBullet";
         
   myType = "RAPID"; //used for procedural systmes.

  
   componentIconGraphic        = "shipconIcon_cannon";
   componentButtonColor        = "Advanced";
       
   WeaponMountDatablock = "SmallCannonMount_rapid";   
   
   RUCost                      = 10;

   
   purchaseTutorial = "PT_rapidCannon";    
   
   threat_Long = SmallCannon_rapid.threat_Long;     
   threat_Medium = SmallCannon_rapid.threat_Medium;      
   threat_Short = SmallCannon_rapid.threat_Short;    
};

datablock ProjectileWeaponDatablock(MediumCannon_cluster : MediumCannon_pulse) 
{
   friendlyName = "Medium Cluster Cannon";
   
   reloadMS          = "1200";
   burstSize         = 1;
   ammoType          = "MediumBullet_cluster";
         
   myType = "BLAST";
   
   clusterSpreadTime = 0;
   clusterCount      = 6;
   clusterSpread     = "20";  //in degrees
   
   componentIconGraphic        = "shipconIcon_clusterCannon";
     
   componentButtonColor        = "Improved";
   
   WeaponMountDatablock = "MediumCannonMount_cluster"; 
   
   purchaseTutorial = "PT_clusterCannon";  
   
   threat_Long = SmallCannon_cluster.threat_Long;     
   threat_Medium = SmallCannon_cluster.threat_Medium;      
   threat_Short = SmallCannon_cluster.threat_Short;    
};

datablock ProjectileWeaponDatablock(MediumCannon_massDriver : MediumCannon_pulse) 
{
   friendlyName = "Medium Mass Driver";
   
   reloadMS          = "1000";
   burstSize         = "1";
   ammoType          = "MediumBullet_massDriver";
         
   myType = "MASSDRIVER";
   
   clusterSpread     = "0";  //in degrees
   
   componentIconGraphic        = "shipconIcon_railgun";
   
   componentButtonColor        = "Improved";
   
   WeaponMountDatablock = "MediumCannonMount_massDriver";
   
   purchaseTutorial = "PT_massDriver";   
   
   threat_Long = SmallCannon_massDriver;     
   threat_Medium = SmallCannon_massDriver;  
   threat_Short = SmallCannon_massDriver;    
};

//////////////////////////////////////////////////
// Larges ////////////////////////////////////////
//////////////////////////////////////////////////

datablock ProjectileWeaponDatablock(LargeCannon_pulse : ProjectileCannonBase) 
{
   friendlyName = "Large Pulse Cannon";
   
   reloadMS          = "1350";
   burstSize         = "1";
   ammoType          = "LargeBullet_cannon";
   
   myType = "BASIC";
   
   clusterSpread     = "0";  //in degrees   
   
   componentIconGraphic        = "shipconIcon_cannonBall";
   
   

   
   componentButtonColor        = "Basic";
   
   WeaponMountDatablock = "LargeCannonMount"; 
   
   purchaseTutorial = "PT_pulseCannon";
   
   //inherited stuff
   componentSize      = $SLOT_LARGE;    
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;   
   
   threat_Long = SmallCannon_pulse.threat_Long;     
   threat_Medium = SmallCannon_pulse.threat_Medium;      
   threat_Short = SmallCannon_pulse.threat_Short;     
};

datablock ProjectileWeaponDatablock(LargeCannon_pulse_Civ : LargeCannon_pulse) 
{
   friendlyName = "Large Civilian Pulse Cannon";
   
   purchaseTutorial = "PT_pulseCannon_civ";
   
   reloadMS          = "1050";
        
   myType = "CIV";

   componentButtonColor        = "Civ";
   ammoType          = "largeBullet_cannon_civ";
   
   threat_Long = SmallCannon_pulse_Civ.threat_Long;     
   threat_Medium = SmallCannon_pulse_Civ.threat_Medium;      
   threat_Short = SmallCannon_pulse_Civ.threat_Short;    
};

datablock ProjectileWeaponDatablock(LargeCannon_rapid : LargeCannon_pulse) 
{
   friendlyName = "Large Basic Cannon";
   
   reloadMS          = "525";
   burstSize         = "6";
   ammoType          = "LargeBullet";
         
   myType = "RAPID"; //used for procedural systmes.

     
   componentIconGraphic        = "shipconIcon_cannon";
   componentButtonColor        = "Advanced";
      
   WeaponMountDatablock = "SmallCannonMount_rapid"; 
     
   purchaseTutorial = "PT_rapidCannon";
   
   threat_Long = SmallCannon_rapid.threat_Long;     
   threat_Medium = SmallCannon_rapid.threat_Medium;      
   threat_Short = SmallCannon_rapid.threat_Short;    
};

//convert to blast
datablock ProjectileWeaponDatablock(LargeCannon_cluster : LargeCannon_pulse) 
{
   friendlyName = "Large Cluster Cannon";
   
   reloadMS          = "1350";
   burstSize         = 1;
   ammoType          = "LargeBullet_cluster";
    
   myType = "BLAST";
   
   clusterSpreadTime = 0;
   clusterCount      = 6;
   clusterSpread     = "20";  //in degrees

   componentIconGraphic        = "shipconIcon_clusterCannon";
      
   componentButtonColor        = "Improved";
   
   purchaseTutorial = "PT_clusterCannon";
   
   WeaponMountDatablock = "LargeCannonMount_cluster";  
   
   threat_Long = SmallCannon_cluster.threat_Long;     
   threat_Medium = SmallCannon_cluster.threat_Medium;      
   threat_Short = SmallCannon_cluster.threat_Short;     
};

datablock ProjectileWeaponDatablock(LargeCannon_massDriver : LargeCannon_pulse) 
{
   friendlyName = "Large Mass Driver";
   
   reloadMS          = "1500";
   burstSize         = "1";
   ammoType          = "LargeBullet_massDriver";
         
   myType = "MASSDRIVER";
   
   clusterSpread     = "0";  //in degrees
   
   componentIconGraphic        = "shipconIcon_railgun";
   
   componentButtonColor        = "Improved";
   
   WeaponMountDatablock = "LargeCannonMount_massDriver";
   
   purchaseTutorial = "PT_massDriver";   
   
   threat_Long = SmallCannon_massDriver;     
   threat_Medium = SmallCannon_massDriver;  
   threat_Short = SmallCannon_massDriver;     
};

//////////////////////////////////////////////////
// Huges ////////////////////////////////////////
//////////////////////////////////////////////////


datablock ProjectileWeaponDatablock(HugeCannon_pulse : ProjectileCannonBase) 
{
   reloadMS          = "1550";
   burstSize         = "1";
   ammoType          = "HugeBullet_cannon";
   
   myType = "BASIC";
   
   friendlyName = "Huge Pulse Cannon";

   clusterSpread     = "0";  //in degrees   
   
   componentIconGraphic        = "shipconIcon_cannonBall";
   

   
   componentButtonColor        = "Basic";
   
   WeaponMountDatablock = "HugeCannonMount"; 
   
   purchaseTutorial = "PT_pulseCannon";  
   
   //inherited stuff
   componentSize      = $SLOT_HUGE;    
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;   
   
   threat_Long = SmallCannon_pulse.threat_Long;     
   threat_Medium = SmallCannon_pulse.threat_Medium;      
   threat_Short = SmallCannon_pulse.threat_Short;     
};

datablock ProjectileWeaponDatablock(HugeCannon_pulse_Civ : HugeCannon_pulse) 
{
   friendlyName = "Huge Civilian Pulse Cannon";
   
   purchaseTutorial = "PT_pulseCannon_civ";
   
   reloadMS          = "1250";
        
   myType = "CIV";

   componentButtonColor        = "Civ";
   ammoType          = "largeBullet_cannon_civ";
   
   threat_Long = SmallCannon_pulse_Civ.threat_Long;     
   threat_Medium = SmallCannon_pulse_Civ.threat_Medium;      
   threat_Short = SmallCannon_pulse_Civ.threat_Short;    
};

datablock ProjectileWeaponDatablock(HugeCannon_rapid : HugeCannon_pulse) 
{
   friendlyName = "Huge Rapid Cannon";
   
   reloadMS          = "625";
   burstSize         = "6";
   ammoType          = "HugeBullet";
         
   myType = "RAPID"; //used for procedural systmes.

  
   componentIconGraphic        = "shipconIcon_cannon";
   componentButtonColor        = "Advanced";
      
   WeaponMountDatablock = "SmallCannonMount_rapid"; 
   
   RUCost                      = 100;

   
   purchaseTutorial = "PT_rapidCannon";
   
   threat_Long = SmallCannon_rapid.threat_Long;     
   threat_Medium = SmallCannon_rapid.threat_Medium;      
   threat_Short = SmallCannon_rapid.threat_Short;    
};

//convert to blast
datablock ProjectileWeaponDatablock(HugeCannon_cluster : HugeCannon_pulse) 
{
   friendlyName = "Huge Cluster Cannon";
   
   reloadMS          = "1550";
   burstSize         = 1;
   ammoType          = "HugeBullet_cluster";
         
   myType = "BLAST";
   
   clusterSpreadTime = 0;
   clusterCount      = 6;
   clusterSpread     = "20";  //in degrees
   
   componentIconGraphic        = "shipconIcon_clusterCannon";
      
   componentButtonColor        = "Improved";
   
   WeaponMountDatablock = "HugeCannonMount_cluster";  
   
   purchaseTutorial = "PT_clusterCannon"; 
   
   threat_Long = SmallCannon_cluster.threat_Long;     
   threat_Medium = SmallCannon_cluster.threat_Medium;      
   threat_Short = SmallCannon_cluster.threat_Short;    
};

datablock ProjectileWeaponDatablock(HugeCannon_massDriver : HugeCannon_pulse) 
{
   friendlyName = "Huge Mass Driver";
   
   reloadMS          = "2000";
   burstSize         = "1";
   ammoType          = "HugeBullet_massDriver";
         
   myType = "MASSDRIVER";
   
   clusterSpread     = "0";  //in degrees
   
   componentIconGraphic        = "shipconIcon_railgun";
   
   componentButtonColor        = "Improved";
   
   WeaponMountDatablock = "HugeCannonMount_massDriver"; 
   
   purchaseTutorial = "PT_massDriver";  
   
   threat_Long = SmallCannon_massDriver;     
   threat_Medium = SmallCannon_massDriver;  
   threat_Short = SmallCannon_massDriver;  
};

//////////////////////////////////////////////////
// drone weapons
//////////////////////////////////////////////////

datablock ProjectileWeaponDatablock(MicroDoubleCannon : SmallCannon_pulse) 
{
   friendlyName = "Micro Cannon";
   
   reloadMS          = "750";
   burstSize         = "3";
   clusterCount      = "1";
   ammoType          = "MicroDoubleBullet";
         
   myType = "DRONE"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption

   clusterSpread     = "0";  //in degrees
   

};

datablock ProjectileWeaponDatablock(MicroBomberCannon : SmallCannon_pulse) 
{
   friendlyName = "Micro Bomb";
   
   reloadMS          = "1000";
   burstSize         = "1";
   ammoType          = "MicroBombBullet";
         
   myType = "DRONE"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption

   clusterSpread     = "0";  //in degrees
   

};

//////////////////////////////////////////////////
// Specials //////////////////////////////////////
//////////////////////////////////////////////////

datablock ProjectileWeaponDatablock(SmallCannon_zombie : SmallCannon_pulse) 
{
   friendlyName = "Small Zombie Cannon";
   
   reloadMS          = "3000";
   burstSize         = "1";
   clusterCount      = "2";
   clusterSpread     = "10";  //in degrees
   
   ammoType          = "ZombieBlobBullet";
      
  
   componentSize      = $SLOT_SMALL;    
   
   myType = "ZOMBIE"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption


   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S; 
   componentIconGraphic        = "shipconIcon_clusterCannon";
   
   WeaponMountDatablock = "SmallCannonMount"; 
   
   threat_Long = $WT_None;     
   threat_Medium = $WT_Low;  
   threat_Short = $WT_High;    
};

datablock ProjectileWeaponDatablock(MediumCannon_zombie : SmallCannon_zombie) 
{
   friendlyName = "Medium Zombie Cannon";
   
   reloadMS          = "5000";
   burstSize         = "2";
   clusterCount      = "2";
   clusterSpread     = "15";  //in degrees
   
   componentSize      = $SLOT_MEDIUM;    
   
   myType = "ZOMBIE"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption

   
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 

   WeaponMountDatablock = "MediumCannonMount";
   

};

datablock ProjectileWeaponDatablock(LargeCannon_zombie : SmallCannon_zombie) 
{
   friendlyName = "Large Zombie Cannon";   
   
   reloadMS          = "7000";
   burstSize         = "3";
   clusterCount      = "2";
   clusterSpread     = "20";  //in degrees
   
   componentSize      = $SLOT_LARGE;    
   
   myType = "ZOMBIE"; //used for procedural systmes.
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

   

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 

   WeaponMountDatablock = "LargeCannonMount";
   

};

datablock ProjectileWeaponDatablock(HugeCannon_zombie : SmallCannon_zombie) 
{
   friendlyName = "Huge Zombie Cannon";
   
   reloadMS          = "1100";
   burstSize         = "4";
   clusterCount      = "2";
   clusterSpread     = "25";  //in degrees
   
   componentSize      = $SLOT_HUGE;    
   
   myType = "ZOMBIE"; //used for procedural systmes.
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption

   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 

   WeaponMountDatablock = "HugeCannonMount";  
   

};


