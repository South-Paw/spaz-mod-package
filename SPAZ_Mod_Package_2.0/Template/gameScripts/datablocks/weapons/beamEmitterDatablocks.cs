

function BeamEmitterDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "BeamEmitterBase" || %this.getName() $= "TractorBeamEmitterBase" || %this.getName() $= "PointDefenseBeamEmitterBase" || %this.getName() $= "ScannerEmitterBase")
      return;
   
   if ( %this.getName() $= "CorruptionBeamEmitterBase" )
      return;
  
   Parent::onAdd(%this);            
}



////////////////////////////////////////////////
// PROCEDURAL STATS  ///////////////////////////
////////////////////////////////////////////////
//These are the numbers for the basic military version. 

//For constant beams, this is a per second cost, else it is a one time pulse cost.
//as ships get bigger their caps get bigger to allow for more guns to fire at once. 

 
$EMITTERDATA["PowerConsumption", $HULLTYPE_SMALL]        = 0.900;
$EMITTERDATA["PowerConsumption", $HULLTYPE_MEDIUM]       = 1.250;    
$EMITTERDATA["PowerConsumption", $HULLTYPE_LARGE]        = 1.500;  
$EMITTERDATA["PowerConsumption", $HULLTYPE_HUGE]         = 1.750;   
$EMITTERDATA["PowerConsumption", $HULLTYPE_MOTHERSHIP]   = 0;  //special 
$EMITTERDATA["PowerConsumption", $HULLTYPE_STATION]      = 0;

$EMITTERDATA["ResourceCost", $HULLTYPE_SMALL]                = 2;  
$EMITTERDATA["ResourceCost", $HULLTYPE_MEDIUM]               = 6;    
$EMITTERDATA["ResourceCost", $HULLTYPE_LARGE]                = 20;   
$EMITTERDATA["ResourceCost", $HULLTYPE_HUGE]                 = 60;   
$EMITTERDATA["ResourceCost", $HULLTYPE_MOTHERSHIP]           = 0; 
$EMITTERDATA["ResourceCost", $HULLTYPE_STATION]              = 0;


function BeamEmitterDatablock::GetProceduralData(%this, %statID)
{
   %datum = $EMITTERDATA[%statID, %this.hullType];
   if ( %datum $= "" )
      echo("$EMITTERDATA::GetProceduralData WARNING: Trying to get invalid procedural Stat!" SPC %statID);
   
   return %datum;
}


////////////////////////
// $EMITTERMULTS ////////
////////////////////////
//This is how we keep technology consistent between categories. 

$EMITTERMULTS["PowerConsumption", "BASIC"]          = 1.000;
$EMITTERMULTS["PowerConsumption", "CIV"]            = 0.800;
$EMITTERMULTS["PowerConsumption", "ION"]            = 2.500;  
$EMITTERMULTS["PowerConsumption", "LEECH"]          = 0.000;  //leeches are free
$EMITTERMULTS["PowerConsumption", "HEAVY"]          = 1.100;
$EMITTERMULTS["PowerConsumption", "MINING"]         = 0.500;
$EMITTERMULTS["PowerConsumption", "TRACTOR"]        = 0.000;
$EMITTERMULTS["PowerConsumption", "SCANNER"]        = 0.000;
$EMITTERMULTS["PowerConsumption", "SURPLUSSCANNER"] = 0.000;
$EMITTERMULTS["PowerConsumption", "POINTDEF"]       = 0.000;
$EMITTERMULTS["PowerConsumption", "DRONE"]          = 0.000;

$EMITTERMULTS["ResourceCost", "BASIC"]          = 1.000;
$EMITTERMULTS["ResourceCost", "CIV"]            = 0.500;  
$EMITTERMULTS["ResourceCost", "ION"]            = 2.000;
$EMITTERMULTS["ResourceCost", "LEECH"]          = 2.000;
$EMITTERMULTS["ResourceCost", "HEAVY"]          = 4.000;
$EMITTERMULTS["ResourceCost", "MINING"]         = 0.500;
$EMITTERMULTS["ResourceCost", "TRACTOR"]        = 0.500;
$EMITTERMULTS["ResourceCost", "SCANNER"]        = 0.500;
$EMITTERMULTS["ResourceCost", "SURPLUSSCANNER"] = 0.500;
$EMITTERMULTS["ResourceCost", "POINTDEF"]       = 0.500;
$EMITTERMULTS["ResourceCost", "DRONE"]          = 0.000;

function BeamEmitterDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $EMITTERMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("$EMITTERMULTS::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}


////////////////////////////////////////////////
// BaseClass ///////////////////////////////////
////////////////////////////////////////////////
datablock BeamEmitterDatablock(BeamEmitterBase : WeaponBase) 
{      
   componentType      = "External";
   componentSubType   = $WEAPON_BeamEmitter;
   isAutomated        = false;  //only tractors are automated (they fire themselves, point defense will too)
 
   regenBoost = 1.0; //for boosters;
   chargeBoost = 1.0; //for boosters;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   researchDatablock = "BeamResearch";
   
   componentButtonColor        = "Basic";
   
   purchaseTutorial = "PT_beam"; 
   
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_None;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_None;  //long range lasers and projectiles
   threat_Short = $WT_None; //$WT_None $WT_Low $WT_Med $WT_High
};

   
   
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Normal Beams //////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/////////////////////////////////////////
// Smalls ///////////////////////////////
/////////////////////////////////////////
datablock BeamEmitterDatablock(SmallEmitter : BeamEmitterBase) 
{    
   friendlyName = "Small Basic Emitter";    
        
   ammoType        = "SmallCrystal";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_SMALL;    
   

   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S; 
   componentIconGraphic        = "shipconIcon_emitter";
         
   WeaponMountDatablock        = "SmallBeamMount";   
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_Low;  
   threat_Short = $WT_Med; 
};

datablock BeamEmitterDatablock(SmallEmitter_Civ : SmallEmitter) 
{ 
   friendlyName = "Small Civilian Emitter";  
   
   purchaseTutorial = "PT_beam_civ"; 
   
   ammoType        = "SmallCrystal_Civ";
   

   myType = "CIV"; //used for procedural systmes.
   
   componentButtonColor        = "Civ";
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_Med;  
   threat_Short = $WT_Low; 
};

datablock BeamEmitterDatablock(SmallEmitter_Heavy : SmallEmitter) 
{     
   friendlyName = "Small Fusion Emitter";  
       
   ammoType        = "SmallCrystal_Heavy";
   
   myType = "HEAVY"; //used for procedural systmes.
   

  
   
   componentButtonColor        = "Advanced";
   
   WeaponMountDatablock        = "SmallBeamMount_heavy";  
   componentIconGraphic        = "shipconIcon_emitterHeavy";
      
   purchaseTutorial = "PT_heavyBeam";
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_None;  
   threat_Short = $WT_High; 
};


datablock BeamEmitterDatablock(SmallEmitter_ION : SmallEmitter) 
{    
   friendlyName = "Small ION Emitter";  
        
   ammoType        = "SmallCrystal_ION";
   
   myType = "ION"; //used for procedural systmes.
   

   
   componentButtonColor        = "Advanced";
   
   WeaponMountDatablock        = "SmallBeamMount_ion";   
   componentIconGraphic        = "shipconIcon_ionBeam";
   
   purchaseTutorial = "PT_ionBeam";  //Needs real tutorial
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_Low;  
   threat_Short = $WT_Med; 
};


datablock BeamEmitterDatablock(SmallEmitter_LEECH : SmallEmitter) 
{    
   friendlyName = "Small LEECH Emitter";  
        
   ammoType     = "SmallCrystal_LEECH";
   
   myType = "LEECH"; //used for procedural systmes.
   
   componentButtonColor        = "Basic";
   
   WeaponMountDatablock        = "SmallBeamMount_leech";   
   componentIconGraphic        = "shipconIcon_leechBeam";
   
   purchaseTutorial = "PT_leechBeam";  //Needs real tutorial
  
   threat_Long = $WT_None;  
   threat_Medium = $WT_Low;  
   threat_Short = $WT_Med; 
};

/////////////////////////////////////////
// Mediums ///////////////////////////////
/////////////////////////////////////////


datablock BeamEmitterDatablock(MediumEmitter : BeamEmitterBase) 
{    
   friendlyName = "Medium Basic Emitter";  
        
   ammoType        = "MediumCrystal";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
   
   componentSize      = $SLOT_MEDIUM;    

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
   componentIconGraphic        = "shipconIcon_emitter";
   

   
   WeaponMountDatablock = "MediumBeamMount";      
   
   threat_Long = SmallEmitter.threat_Long;  
   threat_Medium = SmallEmitter.threat_Medium;   
   threat_Short = SmallEmitter.threat_Short;   
};


datablock BeamEmitterDatablock(MediumEmitter_Civ : MediumEmitter) 
{ 
   friendlyName = "Medium Civilian Emitter"; 
   
   purchaseTutorial = "PT_beam_civ"; 
   
   ammoType        = "MediumCrystal_Civ";
   

   myType = "CIV"; //used for procedural systmes.   
     
   componentButtonColor        = "Civ";
   
   threat_Long = SmallEmitter_Civ.threat_Long;  
   threat_Medium = SmallEmitter_Civ.threat_Medium;   
   threat_Short = SmallEmitter_Civ.threat_Short;  
};


datablock BeamEmitterDatablock(MediumEmitter_Heavy : MediumEmitter) 
{    
   friendlyName = "Medium Heavy Emitter"; 
        
   ammoType        = "MediumCrystal_Heavy";
   
   myType = "HEAVY"; //used for procedural systmes.
   

      
   componentButtonColor        = "Advanced";
   
   WeaponMountDatablock        = "MediumBeamMount_heavy";  
   componentIconGraphic            = "shipconIcon_emitterHeavy";
   
   purchaseTutorial = "PT_heavyBeam";
   
   threat_Long = SmallEmitter_Heavy.threat_Long;  
   threat_Medium = SmallEmitter_Heavy.threat_Medium;   
   threat_Short = SmallEmitter_Heavy.threat_Short;  
};

datablock BeamEmitterDatablock(MediumEmitter_ION : MediumEmitter) 
{    
   friendlyName = "Medium Ion Emitter";  
        
   ammoType        = "MediumCrystal_ION";
   
   myType = "ION"; //used for procedural systmes. 
   

   
   componentButtonColor        = "Advanced";
   
   WeaponMountDatablock        = "MediumBeamMount_ion";   
   componentIconGraphic        = "shipconIcon_ionBeam";
   
   purchaseTutorial = "PT_ionBeam";  //Needs real tutorial
   
   threat_Long = SmallEmitter_ION.threat_Long;  
   threat_Medium = SmallEmitter_ION.threat_Medium;   
   threat_Short = SmallEmitter_ION.threat_Short;  
};


datablock BeamEmitterDatablock(MediumEmitter_LEECH : MediumEmitter) 
{    
   friendlyName = "Medium Leech Emitter";  
        
   ammoType        = "MediumCrystal_LEECH";
   
   myType = "LEECH"; //used for procedural systmes.
   

   
     
   componentButtonColor        = "Basic";
   
   WeaponMountDatablock        = "MediumBeamMount_leech";   
   componentIconGraphic        = "shipconIcon_leechBeam";
   
   purchaseTutorial = "PT_leechBeam";  //Needs real tutorial
   
   threat_Long = SmallEmitter_LEECH.threat_Long;  
   threat_Medium = SmallEmitter_LEECH.threat_Medium;   
   threat_Short = SmallEmitter_LEECH.threat_Short;  
};

/////////////////////////////////////////
// Larges ///////////////////////////////
/////////////////////////////////////////


datablock BeamEmitterDatablock(LargeEmitter : BeamEmitterBase) 
{  
   friendlyName = "Large Basic Emitter"; 
          
   ammoType        = "LargeCrystal";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

   
  
   componentSize      = $SLOT_LARGE;  
   

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
   componentIconGraphic        = "shipconIcon_emitter";
      
       
   WeaponMountDatablock = "LargeBeamMount";   
   
   componentButtonColor        = "Basic";   
   
   threat_Long = SmallEmitter.threat_Long;  
   threat_Medium = SmallEmitter.threat_Medium;   
   threat_Short = SmallEmitter.threat_Short;   
};



datablock BeamEmitterDatablock(LargeEmitter_Civ : LargeEmitter) 
{ 
   friendlyName = "Large Civilian Emitter"; 
   
   purchaseTutorial = "PT_beam_civ"; 
   
   ammoType        = "LargeCrystal_Civ";
   

   myType = "CIV"; //used for procedural systmes.
   
   componentButtonColor        = "Civ";
   
   threat_Long = SmallEmitter_Civ.threat_Long;  
   threat_Medium = SmallEmitter_Civ.threat_Medium;   
   threat_Short = SmallEmitter_Civ.threat_Short;  
};


datablock BeamEmitterDatablock(LargeEmitter_Heavy : LargeEmitter) 
{   
   friendlyName = "Large Heavy Emitter"; 
         
   ammoType        = "LargeCrystal_Heavy";
   
   myType = "HEAVY"; //used for procedural systmes.
   
   
   componentButtonColor        = "Advanced";
   
   WeaponMountDatablock        = "LargeBeamMount_heavy";  
   componentIconGraphic            = "shipconIcon_emitterHeavy";
   
   purchaseTutorial = "PT_heavyBeam";
   
   threat_Long = SmallEmitter_Heavy.threat_Long;  
   threat_Medium = SmallEmitter_Heavy.threat_Medium;   
   threat_Short = SmallEmitter_Heavy.threat_Short;  
};

datablock BeamEmitterDatablock(LargeEmitter_ION : LargeEmitter) 
{    
   friendlyName = "Large Ion Emitter";  
        
   ammoType        = "LargeCrystal_ION";
   
   myType = "ION"; //used for procedural systmes.
   

   
   componentButtonColor        = "Advanced";
   
   WeaponMountDatablock        = "LargeBeamMount_ion";   
   componentIconGraphic        = "shipconIcon_ionBeam";
   
   purchaseTutorial = "PT_ionBeam";  //Needs real tutorial
   
   threat_Long = SmallEmitter_ION.threat_Long;  
   threat_Medium = SmallEmitter_ION.threat_Medium;   
   threat_Short = SmallEmitter_ION.threat_Short;  
};


datablock BeamEmitterDatablock(LargeEmitter_LEECH : LargeEmitter) 
{    
   friendlyName = "Large Leech Emitter";  
        
   ammoType        = "LargeCrystal_LEECH";
   
   myType = "LEECH"; //used for procedural systmes.
   
     
   componentButtonColor        = "Basic";
   
   WeaponMountDatablock        = "LargeBeamMount_leech";   
   componentIconGraphic        = "shipconIcon_leechBeam";
   
   purchaseTutorial = "PT_leechBeam";  //Needs real tutorial
   
   threat_Long = SmallEmitter_LEECH.threat_Long;  
   threat_Medium = SmallEmitter_LEECH.threat_Medium;   
   threat_Short = SmallEmitter_LEECH.threat_Short;  
};

/////////////////////////////////////////
// Huges ///////////////////////////////
/////////////////////////////////////////


datablock BeamEmitterDatablock(HugeEmitter : BeamEmitterBase) 
{   
   friendlyName = "Huge Basic Emitter"; 
         
   ammoType        = "HugeCrystal";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption
 
   componentSize      = $SLOT_HUGE;    

   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_emitter";
   
   
   WeaponMountDatablock = "HugeBeamMount";   

   threat_Long = SmallEmitter.threat_Long;  
   threat_Medium = SmallEmitter.threat_Medium;   
   threat_Short = SmallEmitter.threat_Short;   
};


datablock BeamEmitterDatablock(HugeEmitter_Civ : HugeEmitter) 
{ 
   friendlyName = "Huge Civilian Emitter"; 
   
   purchaseTutorial = "PT_beam_civ"; 
   
   ammoType        = "HugeCrystal_Civ";
   

   myType = "CIV"; //used for procedural systmes.
   
   componentButtonColor        = "Civ";
   
   threat_Long = SmallEmitter_Civ.threat_Long;  
   threat_Medium = SmallEmitter_Civ.threat_Medium;   
   threat_Short = SmallEmitter_Civ.threat_Short;  
};


datablock BeamEmitterDatablock(HugeEmitter_Heavy : HugeEmitter) 
{  
   friendlyName = "Huge Heavy Emitter"; 
          
   ammoType        = "HugeCrystal_Heavy";
   
   myType = "HEAVY"; //used for procedural systmes.
   
   componentButtonColor        = "Advanced";
      
   WeaponMountDatablock        = "HugeBeamMount_heavy";  
   componentIconGraphic            = "shipconIcon_emitterHeavy";
   
   purchaseTutorial = "PT_heavyBeam";
   
   threat_Long = SmallEmitter_Heavy.threat_Long;  
   threat_Medium = SmallEmitter_Heavy.threat_Medium;   
   threat_Short = SmallEmitter_Heavy.threat_Short;  
};


datablock BeamEmitterDatablock(HugeEmitter_ION : HugeEmitter) 
{    
   friendlyName = "Huge Ion Emitter";  
        
   ammoType        = "HugeCrystal_ION";
   
   myType = "ION"; //used for procedural systmes.
   

   
   componentButtonColor        = "Advanced";
   
   WeaponMountDatablock        = "HugeBeamMount_ion";   
   componentIconGraphic        = "shipconIcon_ionBeam";
   
   purchaseTutorial = "PT_ionBeam";  //Needs real tutorial
   
   threat_Long = SmallEmitter_ION.threat_Long;  
   threat_Medium = SmallEmitter_ION.threat_Medium;   
   threat_Short = SmallEmitter_ION.threat_Short;  
};


datablock BeamEmitterDatablock(HugeEmitter_LEECH : HugeEmitter) 
{    
   friendlyName = "Huge Leech Emitter";  
        
   ammoType        = "HugeCrystal_LEECH";
   
   myType = "LEECH"; //used for procedural systmes.
     
   componentButtonColor        = "Basic";
   
   WeaponMountDatablock        = "HugeBeamMount_leech";   
   componentIconGraphic        = "shipconIcon_leechBeam";
   
   purchaseTutorial = "PT_leechBeam";  //Needs real tutorial
   
   threat_Long = SmallEmitter_LEECH.threat_Long;  
   threat_Medium = SmallEmitter_LEECH.threat_Medium;   
   threat_Short = SmallEmitter_LEECH.threat_Short;  
};

///////////////////////////////////////////
// Mining /////////////////////////////////
///////////////////////////////////////////

datablock BeamEmitterDatablock(SmallMinerEmitter : BeamEmitterBase) 
{   
   friendlyName = "Small Mining Emitter"; 
         
   ammoType           = "SmallMinerCrystal";
   
   myType = "MINING"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
 
 
   componentSize      = $SLOT_SMALL;    
   componentSubType   = $WEAPON_MiningBeamEmitter;
   researchDatablock  = "SubSystemResearch";
   

   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;  
   componentIconGraphic        = "shipconIcon_mineEmitter";
   
   WeaponMountDatablock = "SmallMiningBeamMount";   
   
   automatedTargetCollisionGroups  = $COLLISION_GROUPS_MINING;
   automatedTargetPriority         = $AutomatedPriority_Smallest;
      
   componentButtonColor        = "Civ";
   
   purchaseTutorial = "PT_miningBeam";
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_Low;  
   threat_Short = $WT_Low; 
};

datablock BeamEmitterDatablock(MediumMinerEmitter : BeamEmitterBase) 
{     
   friendlyName = "Medium Mining Emitter"; 
       
   ammoType        = "MediumMinerCrystal";
   
   myType = "MINING"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption

   
 
   componentSize      = $SLOT_MEDIUM;    
   componentSubType   = $WEAPON_MiningBeamEmitter;
   researchDatablock  = "SubSystemResearch";

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
   componentIconGraphic        = "shipconIcon_mineEmitter";
  
   WeaponMountDatablock = "MediumMiningBeamMount";   
   
   automatedTargetCollisionGroups  = $COLLISION_GROUPS_MINING;
   automatedTargetPriority         = $AutomatedPriority_Smallest;
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_Low;  
   threat_Short = $WT_Low; 
      
   componentButtonColor        = "Civ";
   
   purchaseTutorial = "PT_miningBeam";
};


datablock BeamEmitterDatablock(LargeMinerEmitter : BeamEmitterBase) 
{  
   friendlyName = "Large Mining Emitter"; 
          
   ammoType        = "LargeMinerCrystal";
   
   myType = "MINING"; //used for procedural systmes.
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption
 
   componentSize      = $SLOT_LARGE;  
   componentSubType   = $WEAPON_MiningBeamEmitter;
   researchDatablock  = "SubSystemResearch";

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
   componentIconGraphic        = "shipconIcon_mineEmitter";

   WeaponMountDatablock = "LargeMiningBeamMount";   
   
   automatedTargetCollisionGroups  = $COLLISION_GROUPS_MINING;
   automatedTargetPriority         = $AutomatedPriority_Largest;
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_Low;  
   threat_Short = $WT_Low; 
     
   componentButtonColor        = "Civ";
   
   purchaseTutorial = "PT_miningBeam";
};



datablock BeamEmitterDatablock(HugeCoreMiner : BeamEmitterBase) 
{ 
   friendlyName = "Huge Mining Emitter"; 
           
   ammoType        = "HugeCoreMinerCrystal";
   
   myType = "MINING"; //used for procedural systmes.
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption

  
   componentSize      = $SLOT_HUGE; 
   componentSubType   = $WEAPON_MiningBeamEmitter;
   researchDatablock  = "SubSystemResearch";

   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_mineEmitter";
   
   WeaponMountDatablock = "HugeCoreMiningBeamMount";   
   
   automatedTargetCollisionGroups  = BIT ($COLLISION_ID_MOTHER_ROCK);
   automatedTargetPriority         = $AutomatedPriority_Largest;  
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_Med;  
   threat_Short = $WT_Low; 
     
   componentButtonColor        = "Civ";
   
   purchaseTutorial = "PT_miningBeam";
};



///////////////////////////////////////////
// Point Defnese Beam Emitter /////////////
///////////////////////////////////////////

datablock PointDefenseEmitterDatablock(PointDefenseBeamEmitterBase : WeaponBase) 
{    
   componentType      = "External";
   componentSubType   = $WEAPON_PointDefenseEmitter;
   researchDatablock  = "SubSystemResearch";
   isAutomated        = true;  //only tractors are automated (they fire themselves, point defense will too)
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 0;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   
   componentButtonColor = "Basic";
    
   purchaseTutorial = "PT_pointDefense";
      
   includedLayers = $MISSILE_LAYERMASK | bit($LAYER_ZOMBIECRITTERS) | bit($LAYER_DRONES);
   includedCollisionGroups = $COLLISION_GROUPS_FACTION_ALL;  //we are only interested in factioned objects. 

   threat_Long = $WT_None;  
   threat_Medium = $WT_None;  
   threat_Short = $WT_None; 
};

 datablock PointDefenseEmitterDatablock(PointDefenseBeamEmitter_S : PointDefenseBeamEmitterBase) 
{   
   friendlyName = "Small Point Defense"; 
         
   ammoType        = "POINTDEF_Crystal_S";
   
   myType = "POINTDEF"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_SMALL;  
   

   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_pointDef";

   WeaponMountDatablock = "PointDefenseBeamMount_S";   
   
   componentButtonColor        = "Basic";
};

datablock PointDefenseEmitterDatablock(PointDefenseBeamEmitter_M : PointDefenseBeamEmitterBase) 
{   
   friendlyName = "Medium Point Defense"; 
         
   ammoType        = "POINTDEF_Crystal_M";
   
   myType = "POINTDEF"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_MEDIUM;  
   

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_pointDef";

   WeaponMountDatablock = "PointDefenseBeamMount_M";   
   
   componentButtonColor        = "Basic";
};
   
datablock PointDefenseEmitterDatablock(PointDefenseBeamEmitter_L : PointDefenseBeamEmitter_M) 
{
   friendlyName = "Large Point Defense"; 
         
   ammoType        = "POINTDEF_Crystal_L";
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_LARGE;  
 
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   
   WeaponMountDatablock = "PointDefenseBeamMount_L"; 
};

datablock PointDefenseEmitterDatablock(PointDefenseBeamEmitter_H : PointDefenseBeamEmitter_M) 
{
   friendlyName = "Huge Point Defense"; 
         
   ammoType        = "POINTDEF_Crystal_H";
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_HUGE;  
 
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   
   WeaponMountDatablock = "PointDefenseBeamMount_H"; 
};

///////////////////////////////////////////////////
// Corruption Beams ///////////////////////////////
///////////////////////////////////////////////////

datablock PointDefenseEmitterDatablock(CorruptionBeamEmitterBase : WeaponBase) 
{    
   componentType      = "External";
   componentSubType   = $WEAPON_PointDefenseEmitter;
   researchDatablock  = "SubSystemResearch";
   isAutomated        = true;  //only tractors are automated (they fire themselves, point defense will too)
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 0;
   
   myType = "POINTDEF"; //used for procedural systmes.
   WeaponMountDatablock = "CorruptionBeamMount";
   
   
   componentButtonColor = "Basic";
   componentIconGraphic        = "shipconIcon_pointDef";
    
   purchaseTutorial = "PT_pointDefense";
   
   includedCollisionGroups = $COLLISION_GROUPS_FACTION_ALL | $COLLISION_GROUPS_FACTION_PODS_ALL;  //we are only interested in factioned objects. 
   includedLayers = $POD_LAYERMASK | bit($LAYER_SPACEMEN);

   threat_Long = $WT_None;  
   threat_Medium = $WT_Low;  
   threat_Short = $WT_Med; 
};

datablock PointDefenseEmitterDatablock(CorruptionBeamEmitter_S : CorruptionBeamEmitterBase) 
{   
   friendlyName = "Small Corruption Beam";        
   ammoType        = "CORRUPTION_Crystal_S";
      
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
   componentSize      = $SLOT_SMALL;    
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
};

datablock PointDefenseEmitterDatablock(CorruptionBeamEmitter_M : CorruptionBeamEmitterBase) 
{   
   friendlyName = "Medium Corruption Beam";        
   ammoType        = "CORRUPTION_Crystal_M";
      
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
   componentSize      = $SLOT_MEDIUM;    
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
};

datablock PointDefenseEmitterDatablock(CorruptionBeamEmitter_L : CorruptionBeamEmitterBase) 
{   
   friendlyName = "Large Corruption Beam";        
   ammoType        = "CORRUPTION_Crystal_L";
      
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption
   componentSize      = $SLOT_LARGE;    
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
};

datablock PointDefenseEmitterDatablock(CorruptionBeamEmitter_H : CorruptionBeamEmitterBase) 
{   
   friendlyName = "Huge Corruption Beam";        
   ammoType        = "CORRUPTION_Crystal_H";
      
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption
   componentSize      = $SLOT_HUGE;    
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
};


///////////////////////////////////////////
// Scanner Emitter /////////////////////////
///////////////////////////////////////////

datablock ScannerEmitterDatablock(ScannerEmitterBase : WeaponBase) 
{    
   componentType      = "External";
   componentSubType   = $WEAPON_ScannerEmitter;
   researchDatablock  = "SubSystemResearch";
   isAutomated        = true;  
  
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 0;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   
   componentButtonColor = "Improved";
    
   purchaseTutorial = "PT_scanner";
   
   //we only care about factioened items, and really only cloaked ones. 
   includedCollisionGroups = $COLLISION_GROUPS_FACTION_ALL | BIT($COLLISION_ID_CRATES);   
   includedLayers = $SHIP_LAYERMASK | bit($LAYER_DRONES) | bit($LAYER_DEBRIS);
   
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_None;  
   threat_Short = $WT_None; 
};

//Doesnt need a civ version
datablock ScannerEmitterDatablock(ScannerEmitter_S : ScannerEmitterBase) 
{   
   friendlyName = "Advanced Cloaking Scanner"; 
         
   ammoType        = "SCANNER_Crystal_S";
   
   myType = "SCANNER"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
 
   componentSize      = $SLOT_SMALL;  
 
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_scanner";

   WeaponMountDatablock = "ScannerMount_S";   
   
   componentButtonColor        = "Improved";
};   
datablock ScannerEmitterDatablock(SurplusScannerEmitter_S : ScannerEmitter_S) 
{
   friendlyName         = "Surplus Cloaking Scanner";   
   purchaseTutorial     = "PT_scanner_civ";       
   ammoType             = "SCANNER_Crystal_S_SURPLUS";
   myType               = "SURPLUSSCANNER";
   componentButtonColor = "Civ";
};
   

datablock ScannerEmitterDatablock(ScannerEmitter_M : ScannerEmitterBase) 
{   
   friendlyName = "Cloaking Scanner"; 
         
   ammoType        = "SCANNER_Crystal_M";
   
   myType = "SCANNER"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
 
   componentSize      = $SLOT_MEDIUM;  
 
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_scanner";

   WeaponMountDatablock = "ScannerMount_M";   
    
   componentButtonColor        = "Improved";
};
datablock ScannerEmitterDatablock(SurplusScannerEmitter_M : ScannerEmitter_M) 
{
   friendlyName         = "Surplus Cloaking Scanner";  
   purchaseTutorial     = "PT_scanner_civ";             
   ammoType             = "SCANNER_Crystal_M_SURPLUS";
   myType               = "SURPLUSSCANNER";
   componentButtonColor = "Civ";
};

   
datablock ScannerEmitterDatablock(ScannerEmitter_L : ScannerEmitter_M) 
{
   friendlyName = "Cloaking Scanner Array"; 
   
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

   ammoType        = "SCANNER_Crystal_L";
   
   componentSize      = $SLOT_LARGE;  
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   WeaponMountDatablock = "ScannerMount_L"; 
};
datablock ScannerEmitterDatablock(SurplusScannerEmitter_L : ScannerEmitter_L) 
{
   friendlyName         = "Surplus Cloaking Scanner"; 
   purchaseTutorial     = "PT_scanner_civ";              
   ammoType             = "SCANNER_Crystal_L_SURPLUS";
   myType               = "SURPLUSSCANNER";
   componentButtonColor = "Civ";
};

datablock ScannerEmitterDatablock(ScannerEmitter_H : ScannerEmitter_M) 
{
   friendlyName = "Cloaking Scanner Multi-Array"; 
   
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption

   ammoType        = "SCANNER_Crystal_H";
   
   componentSize      = $SLOT_HUGE;  
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   WeaponMountDatablock = "ScannerMount_H"; 
};
datablock ScannerEmitterDatablock(SurplusScannerEmitter_H : ScannerEmitter_H) 
{
   friendlyName         = "Surplus Cloaking Scanner"; 
   purchaseTutorial     = "PT_scanner_civ";             
   ammoType             = "SCANNER_Crystal_H_SURPLUS";
   myType               = "SURPLUSSCANNER";
   componentButtonColor = "Civ";
};


///////////////////////////////////////////
// Tractor Beam Emitter ///////////////////
///////////////////////////////////////////

datablock TractorBeamEmitterDatablock(TractorBeamEmitterBase : WeaponBase) 
{    
   componentType      = "External";
   componentSubType   = $WEAPON_TractorBeamEmitter;
   researchDatablock  = "SubSystemResearch";
   isAutomated        = true;  //only tractors are automated (they fire themselves, point defense will too)
   tractorCompleteRadius = 32;
   canFireCloaked = true;
      
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 0;
   
   WeaponMountDatablock = "DefaultWeaponMount";
   
   componentButtonColor        = "Basic";
   
   tractorSpeed     = 400;
   
   purchaseTutorial = "PT_tractorBeam";
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_None;  
   threat_Short = $WT_None; 
};

//All ships get one of these for picking up data (FREE)
datablock TractorBeamEmitterDatablock(MicroTractorEmitter : TractorBeamEmitterBase) 
{  
   friendlyName = "Micro Tractor Beam"; 
          
   ammoType           = "MicroTractorCrystal";
   
   myType = "TRACTOR"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption

   componentSize      = $SLOT_SMALL;  
     
   WeaponMountDatablock = "MicroTractorBeamMount"; 
   
   tractorSpeed     = 400; 
   

};

//This is all you get for a small tractor. (Can only pick rocks)
datablock TractorBeamEmitterDatablock(MiningTractorEmitter : TractorBeamEmitterBase) 
{ 
   friendlyName = "Mining Tractor Beam"; 
           
   ammoType           = "MiningTractorCrystal";
      
   myType = "TRACTOR"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
     
   componentSize      = $SLOT_SMALL;  
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_mineTractor";
   
   WeaponMountDatablock = "MiningTractorBeamMount"; 
   

      
   tractorSpeed     = 400;  
   
   componentButtonColor        = "Civ";
   

};


datablock TractorBeamEmitterDatablock(TractorEmitter_medium : TractorBeamEmitterBase) 
{   
   friendlyName = "Medium Tractor Beam"; 
         
   ammoType        = "TractorCrystal_medium";
   
   myType = "TRACTOR"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
   
   componentSize      = $SLOT_MEDIUM;  
   

   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_tractor";

   WeaponMountDatablock = "TractorBeamMount_medium";   
   
   componentButtonColor        = "Civ";
   

   
   tractorSpeed     = 500;
};

datablock TractorBeamEmitterDatablock(TractorEmitter_large : TractorBeamEmitterBase) 
{   
   friendlyName = "Large Tractor Beam"; 
         
   ammoType        = "TractorCrystal_large";
   
   myType = "TRACTOR"; //used for procedural systmes.
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

  
   componentSize      = $SLOT_LARGE;  
   

   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_tractor";
     
   WeaponMountDatablock = "TractorBeamMount_large";  
   
   tractorSpeed     = 600; 

   
   componentButtonColor        = "Civ";
};

datablock TractorBeamEmitterDatablock(TractorEmitter_huge : TractorBeamEmitterBase) 
{   
   friendlyName = "Huge Tractor Beam"; 
         
   ammoType        = "TractorCrystal_huge";
   
   myType = "TRACTOR"; //used for procedural systmes.
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption

  
   componentSize      = $SLOT_HUGE;  
   

   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_tractor";
     
   WeaponMountDatablock = "TractorBeamMount_huge";  
   
   tractorSpeed     = 800; 

   
   componentButtonColor        = "Civ";
};






///////////////////////////////////////////
// Special ///////////////////
///////////////////////////////////////////

datablock BeamEmitterDatablock(MothershipEmitter : BeamEmitterBase) 
{    
   friendlyName = "Mothership Ion Beam"; 
        
   ammoType        = "MothershipCrystal";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MOTHERSHIP; //used for procedural systmes.
   referenceReactor = "Mothership_BasicReactor"; //used to determine power consumption
  
   componentSize      = $SLOT_MOTHERSHIP; 
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_emitter";
   
   RUCost                      = 100;
   
   WeaponMountDatablock = "HugeBeamMount_heavy";
   
   threat_Long = $WT_None;  
   threat_Medium = $WT_HIGH;  
   threat_Short = $WT_Low; 
};


datablock BeamEmitterDatablock(MothershipEmitter_super : MothershipEmitter) 
{  
   friendlyName = "Mothership Nutron Beam"; 
          
   ammoType        = "MothershipCrystal_super";
   
   myType = "HEAVY"; //used for procedural systmes.
   hullType = $HULLTYPE_MOTHERSHIP; //used for procedural systmes.
   referenceReactor = "Mothership_BasicReactor"; //used to determine power consumption
   
   componentSize      = $SLOT_MOTHERSHIP; 
   

};

datablock BeamEmitterDatablock(MothershipEmitter_zombie : MothershipEmitter) 
{      
   friendlyName = "Corruption Beam"; 
      
   ammoType        = "MothershipCrystal_zombie";
   
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MOTHERSHIP; //used for procedural systmes.
   referenceReactor = "Mothership_BasicReactor"; //used to determine power consumption

   
   componentSize      = $SLOT_HUGE; //has to fit on a turret
   WeaponMountDatablock = "ZombieMotherBeamMount"; 
   

};

//////////////////////////////////////
// Drone Beams //////////////////////
//////////////////////////////////////

datablock BeamEmitterDatablock(DRONE_MicroLaser : BeamEmitterBase) 
{   
   friendlyName = "Drone Beam"; 
         
   ammoType        = "DRONE_MicroLaserCrystal";
   
   myType = "DRONE"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
  

};

datablock BeamEmitterDatablock(DRONE_CivMicroLaser : DRONE_MicroLaser) 
{     
   ammoType        = "DRONE_MicroLaserCrystal"; //use same as other drones. 
};

//////////////////////////////////////
// Mine Beams //////////////////////
//////////////////////////////////////

datablock BeamEmitterDatablock(MINE_MicroLaser : BeamEmitterBase) 
{   
   friendlyName = "Mine Beam"; 
         
   ammoType        = "MINE_MicroLaserCrystal";
   
   myType = "DRONE"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
  

};


datablock BeamEmitterDatablock(MINE_ScannerEmitter : MINE_MicroLaser) 
{   
   friendlyName = "Mine Scanner"; 
         
   ammoType        = "SCANNER_Crystal_M"; 
};


