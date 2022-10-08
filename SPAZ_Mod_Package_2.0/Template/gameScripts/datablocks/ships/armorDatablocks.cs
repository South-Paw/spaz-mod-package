//Armor Datablocks
function ArmorDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "ArmorBase" )
      return;
      
   %this.HandleProceduralStats();
            
   Parent::onAdd(%this);            
}

////////////////////////////////////////////////
// PROCEDURAL STATS  ///////////////////////////
////////////////////////////////////////////////
//Numbers for basic Military version. 

$ArmorPlateMassFactor = 0.25 / 4;  //4 plates will be X% ship mass. 


$ARMORDATA["componentMass", $SLOT_SMALL]          = $HULL_BASEMASS[$HULLTYPE_SMALL] * $ArmorPlateMassFactor;
$ARMORDATA["componentMass", $SLOT_MEDIUM]         = $HULL_BASEMASS[$HULLTYPE_MEDIUM] * $ArmorPlateMassFactor;   
$ARMORDATA["componentMass", $SLOT_LARGE]          = $HULL_BASEMASS[$HULLTYPE_LARGE] * $ArmorPlateMassFactor;   
$ARMORDATA["componentMass", $SLOT_HUGE]           = $HULL_BASEMASS[$HULLTYPE_HUGE] * $ArmorPlateMassFactor;   

$ARMORDATA["maxComponentHealth", $SLOT_SMALL]      = 25;
$ARMORDATA["maxComponentHealth", $SLOT_MEDIUM]     = 75;    
$ARMORDATA["maxComponentHealth", $SLOT_LARGE]      = 200;   
$ARMORDATA["maxComponentHealth", $SLOT_HUGE]       = 500;   

$ARMORDATA["ResourceCost", $SLOT_SMALL]            = 2;  //has to be even number
$ARMORDATA["ResourceCost", $SLOT_MEDIUM]           = 6;    
$ARMORDATA["ResourceCost", $SLOT_LARGE]            = 20;   
$ARMORDATA["ResourceCost", $SLOT_HUGE]             = 60;   

$ARMORDATA["Explosive", $SLOT_SMALL]               = 0.750;  
$ARMORDATA["Explosive", $SLOT_MEDIUM]              = 0.750;    
$ARMORDATA["Explosive", $SLOT_LARGE]               = 0.750;   
$ARMORDATA["Explosive", $SLOT_HUGE]                = 0.750;   

$ARMORDATA["Energy", $SLOT_SMALL]                  = 1;  
$ARMORDATA["Energy", $SLOT_MEDIUM]                 = 1;    
$ARMORDATA["Energy", $SLOT_LARGE]                  = 1;   
$ARMORDATA["Energy", $SLOT_HUGE]                   = 1;   


$ARMORDATA["Projectile", $SLOT_SMALL]              = 1.333;  
$ARMORDATA["Projectile", $SLOT_MEDIUM]             = 1.333;    
$ARMORDATA["Projectile", $SLOT_LARGE]              = 1.333;   
$ARMORDATA["Projectile", $SLOT_HUGE]               = 1.333;   

function ArmorDatablock::GetProceduralData(%this, %statID)
{
   %datum = $ARMORDATA[%statID, %this.componentSize];
   if ( %datum $= "" )
      echo("ArmorDatablock::GetProceduralData WARNING: Trying to get invalid procedural Stat!" SPC %statID);
   
   return %datum;
}


////////////////////////
// Engine Mults ////////
////////////////////////
//This is how we keep technology consistent between categories. 

$ARMORMULTS["componentMass", "LIGHT"]          = 0.667;
$ARMORMULTS["componentMass", "MEDIUM"]         = 1.000;
$ARMORMULTS["componentMass", "HEAVY"]          = 2.000;  
$ARMORMULTS["componentMass", "MAGIC"]          = 1.000;  

$ARMORMULTS["maxComponentHealth", "LIGHT"]     = 0.500;
$ARMORMULTS["maxComponentHealth", "MEDIUM"]    = 1.000;
$ARMORMULTS["maxComponentHealth", "HEAVY"]     = 2.000;  
$ARMORMULTS["maxComponentHealth", "MAGIC"]     = 1.500;  

$ARMORMULTS["ResourceCost", "LIGHT"]           = 0.500;
$ARMORMULTS["ResourceCost", "MEDIUM"]          = 1.000;
$ARMORMULTS["ResourceCost", "HEAVY"]           = 2.000;  
$ARMORMULTS["ResourceCost", "MAGIC"]           = 5.000;  

$ARMORMULTS["Explosive", "LIGHT"]              = 0.750;
$ARMORMULTS["Explosive", "MEDIUM"]             = 0.750;
$ARMORMULTS["Explosive", "HEAVY"]              = 0.750;
$ARMORMULTS["Explosive", "MAGIC"]              = 0.800;  

$ARMORMULTS["Energy", "LIGHT"]                 = 1.000;
$ARMORMULTS["Energy", "MEDIUM"]                = 1.000;
$ARMORMULTS["Energy", "HEAVY"]                 = 1.000;
$ARMORMULTS["Energy", "MAGIC"]                 = 0.800; 

$ARMORMULTS["Projectile", "LIGHT"]             = 1.150;
$ARMORMULTS["Projectile", "MEDIUM"]            = 1.150;
$ARMORMULTS["Projectile", "HEAVY"]             = 1.150;
$ARMORMULTS["Projectile", "MAGIC"]             = 0.930;  



function ArmorDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $ARMORMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("ArmorDatablock::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}

///////////////////////////////////////
//Procedural Stat /////////////////////
///////////////////////////////////////

function ArmorDatablock::GetFinalStat(%this, %statID)
{
   %data = %this.GetProceduralData(%statID);
   %mult = %this.GetProceduralMult(%statID);
   
   %result = %data * %mult;  
   return %result;
}

function ArmorDatablock::HandleProceduralStats(%this)
{
   %this.componentMass = %this.GetFinalStat("componentMass");          
   %this.maxComponentHealth = %this.GetFinalStat("maxComponentHealth");         
   %this.RUCost = mRound(%this.GetFinalStat("ResourceCost"));  //rounding just in case  

   %this.armorDamageModifier_Explosive = %this.GetFinalStat("Explosive");  
   %this.armorDamageModifier_Projectile = %this.GetFinalStat("Projectile");
   %this.armorDamageModifier_Energy = %this.GetFinalStat("Energy");
}


////////////////////////////////////////////////
// BaseClass ///////////////////////////////////
////////////////////////////////////////////////

datablock ArmorDatablock(ArmorBase : ComponentBase) 
{       
   componentType                   = "Armor";
   maxComponentHealth              = 0.5;    
   componentMass                   = 1;  
   componentSize                   = $SLOT_SMALL;  //meaningless here
   powerConsumption                = 0;    
   
   armorHitEffect                  = "ArmorImpact";   //need armor shards flying off. 
   armorHitEffectScale             = "1.0";
   armorHitSound                   = "snd_armorHit";    
      
   armorDamageModifier_Default     = "1";   
   armorDamageModifier_Ion         = "0.10"; //ion damage does almost nothing
   armorDamageModifier_Corrosive   = "0.50"; //provides some protection, but all 4 sides getting hit.
   armorDamageModifier_Zombify     = "1"; 
      
   baseArmorDamageMult = 1.0;  //research increases this. 
   
   researchDatablock = "ArmorResearch";
   
   componentButtonColor        = "Basic";   
   
   componentIconGraphic        = "shipconIcon_armorTit";
   
   purchaseTutorial = "PT_basicArmor";     
   
   plateCount = 1;
   plateBlend = "1 1 1 1";
};

//////////////////////////////////////
// Civ Armor /////////////////////////
//////////////////////////////////////

datablock ArmorDatablock(CivArmor_S : ArmorBase) 
{
   myType = "LIGHT";
   friendlyName = "Civilian Armor";
   
   purchaseTutorial = "PT_basicArmor_civ";        
   
   componentSize                   = $SLOT_SMALL;
      
   componentIconGraphic            = "shipconIcon_armorCiv";  
   
   componentButtonColor            = "Civ";   
   
   armorImage = "ShipDisplay_armor_lightImageMap";
   armorScale = 0.444;
   plateCount = 1;
   plateBlend = "1 1 1 1";
   
   sizeTable[$SLOT_SMALL]  = "CivArmor_S";
   sizeTable[$SLOT_MEDIUM] = "CivArmor_M";
   sizeTable[$SLOT_LARGE]  = "CivArmor_L";
   sizeTable[$SLOT_HUGE]   = "CivArmor_H";
};

datablock ArmorDatablock(CivArmor_M : CivArmor_S) 
{
   componentSize                   = $SLOT_MEDIUM;
};

datablock ArmorDatablock(CivArmor_L : CivArmor_S) 
{
   componentSize                   = $SLOT_LARGE;
};

datablock ArmorDatablock(CivArmor_H : CivArmor_S) 
{
   componentSize                   = $SLOT_HUGE;
};


//////////////////////////////////////
// Basic Armor ///////////////////////
//////////////////////////////////////

datablock ArmorDatablock(TitaniumArmor_S : ArmorBase) 
{
   myType = "MEDIUM";
   friendlyName = "Titanium Armor";   
   componentSize                   = $SLOT_SMALL;
   

   
   componentButtonColor            = "Basic";
   
   armorImage = "ShipDisplay_armor_medImageMap";
   armorScale = 0.667;
   
   plateCount = 2;
   plateBlend = "1 1 1 1";
   
   sizeTable[$SLOT_SMALL]  = "TitaniumArmor_S";
   sizeTable[$SLOT_MEDIUM] = "TitaniumArmor_M";
   sizeTable[$SLOT_LARGE]  = "TitaniumArmor_L";
   sizeTable[$SLOT_HUGE]   = "TitaniumArmor_H";
};

datablock ArmorDatablock(TitaniumArmor_M : TitaniumArmor_S) 
{
   componentSize                   = $SLOT_MEDIUM;  
};

datablock ArmorDatablock(TitaniumArmor_L : TitaniumArmor_S) 
{
   componentSize                   = $SLOT_LARGE;  
};

datablock ArmorDatablock(TitaniumArmor_H : TitaniumArmor_S) 
{
   componentSize                   = $SLOT_HUGE;   
};


//////////////////////////////////////
// HEAVY Armor ///////////////////////
//////////////////////////////////////

datablock ArmorDatablock(HeavyArmor_S: ArmorBase) 
{
   myType = "HEAVY";
   friendlyName = "Heavy Armor";
   componentSize                   = $SLOT_SMALL;
                   

    
   componentButtonColor            = "Improved";      
   componentIconGraphic            = "shipconIcon_armorAdv";   
   purchaseTutorial                = "PT_heavyArmor";
   
   armorImage = "ShipDisplay_armorImageMap";
   armorScale = 1.000;
   
   plateCount = 4;
   plateBlend = "1 1 1 1";
   
   sizeTable[$SLOT_SMALL]  = "HeavyArmor_S";
   sizeTable[$SLOT_MEDIUM] = "HeavyArmor_M";
   sizeTable[$SLOT_LARGE]  = "HeavyArmor_L";
   sizeTable[$SLOT_HUGE]   = "HeavyArmor_H";
};

datablock ArmorDatablock(HeavyArmor_M : HeavyArmor_S) 
{
   componentSize                   = $SLOT_MEDIUM; 
};

datablock ArmorDatablock(HeavyArmor_L : HeavyArmor_S) 
{
   componentSize                   = $SLOT_LARGE;
};

datablock ArmorDatablock(HeavyArmor_H : HeavyArmor_S) 
{
   componentSize                   = $SLOT_HUGE; 
};


//////////////////////////////////////
// MAGIC Armor ///////////////////////
//////////////////////////////////////

datablock ArmorDatablock(AdvancedArmor_S : ArmorBase) 
{
   myType = "MAGIC";
   friendlyName = "Advanced Armor";
   componentSize                   = $SLOT_SMALL;
        

   
   componentButtonColor        = "Advanced";
      
   componentIconGraphic        = "shipconIcon_armorStatic";   
   purchaseTutorial = "PT_advancedArmor";
   
   armorImage = "ShipDisplay_armor_specialImageMap";
   armorScale = 0.667;
   
   plateCount = 2;
   plateBlend = "0 1 1 1";
   
   sizeTable[$SLOT_SMALL]  = "AdvancedArmor_S";
   sizeTable[$SLOT_MEDIUM] = "AdvancedArmor_M";
   sizeTable[$SLOT_LARGE]  = "AdvancedArmor_L";
   sizeTable[$SLOT_HUGE]   = "AdvancedArmor_H";
};


datablock ArmorDatablock(AdvancedArmor_M : AdvancedArmor_S) 
{
   componentSize                   = $SLOT_MEDIUM;
};

datablock ArmorDatablock(AdvancedArmor_L : AdvancedArmor_S) 
{
   componentSize                   = $SLOT_LARGE;
};

datablock ArmorDatablock(AdvancedArmor_H : AdvancedArmor_S) 
{
   componentSize                   = $SLOT_HUGE;
};





















