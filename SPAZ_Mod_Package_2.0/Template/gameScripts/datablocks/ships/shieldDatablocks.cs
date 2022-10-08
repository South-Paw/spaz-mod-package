//Shield Datablocks



function ShieldDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "ShieldBase" )
      return;
   
   %this.HandleProceduralStats();
   
   Parent::onAdd(%this);            
}



////////////////////////////////////////////////
// PROCEDURAL DATA  ////////////////////////////
////////////////////////////////////////////////
//These are the numbers for the basic military version. 

//Try all shields pulling an equal percent for now. 
$SHIELDDATA["powerConsumption", $HULLTYPE_SMALL]        = 0.25;
$SHIELDDATA["powerConsumption", $HULLTYPE_MEDIUM]       = 0.25;
$SHIELDDATA["powerConsumption", $HULLTYPE_LARGE]        = 0.25;
$SHIELDDATA["powerConsumption", $HULLTYPE_HUGE]         = 0.25;
$SHIELDDATA["powerConsumption", $HULLTYPE_MOTHERSHIP]   = 0.25;
$SHIELDDATA["powerConsumption", $HULLTYPE_STATION]      = 0.25;


$SHIELDDATA["shieldMaxStrength", $HULLTYPE_SMALL]       = $HULL_BASEHEALTH[$HULLTYPE_SMALL] * 0.500;
$SHIELDDATA["shieldMaxStrength", $HULLTYPE_MEDIUM]      = $HULL_BASEHEALTH[$HULLTYPE_MEDIUM] * 0.667;
$SHIELDDATA["shieldMaxStrength", $HULLTYPE_LARGE]       = $HULL_BASEHEALTH[$HULLTYPE_LARGE] * 0.750;
$SHIELDDATA["shieldMaxStrength", $HULLTYPE_HUGE]        = $HULL_BASEHEALTH[$HULLTYPE_HUGE] * 1.000;
$SHIELDDATA["shieldMaxStrength", $HULLTYPE_MOTHERSHIP]  = $HULL_BASEHEALTH[$HULLTYPE_MOTHERSHIP] * 1.250;
$SHIELDDATA["shieldMaxStrength", $HULLTYPE_STATION]     = $HULL_BASEHEALTH[$HULLTYPE_STATION] * 1;
   
//How many seconds to recharge shields fully (proportional to shieldMaxStrength)

$SHIELDDATA["shieldRegenSpeed", $HULLTYPE_SMALL]        = 10;
$SHIELDDATA["shieldRegenSpeed", $HULLTYPE_MEDIUM]       = 12;
$SHIELDDATA["shieldRegenSpeed", $HULLTYPE_LARGE]        = 15;
$SHIELDDATA["shieldRegenSpeed", $HULLTYPE_HUGE]         = 20;
$SHIELDDATA["shieldRegenSpeed", $HULLTYPE_MOTHERSHIP]   = 20;
$SHIELDDATA["shieldRegenSpeed", $HULLTYPE_STATION]      = 30;
  
//This is a percentage of max strength
$SHIELDDATA["shieldCreateStrength", $HULLTYPE_SMALL]      = 0.333;
$SHIELDDATA["shieldCreateStrength", $HULLTYPE_MEDIUM]     = 0.333;
$SHIELDDATA["shieldCreateStrength", $HULLTYPE_LARGE]      = 0.333;
$SHIELDDATA["shieldCreateStrength", $HULLTYPE_HUGE]       = 0.333;
$SHIELDDATA["shieldCreateStrength", $HULLTYPE_MOTHERSHIP] = 0.333;
$SHIELDDATA["shieldCreateStrength", $HULLTYPE_STATION]    = 0.333;
  
//This is in MS
$SHIELDDATA["shieldCreateTime", $HULLTYPE_SMALL]      = 3000;
$SHIELDDATA["shieldCreateTime", $HULLTYPE_MEDIUM]     = 4000;
$SHIELDDATA["shieldCreateTime", $HULLTYPE_LARGE]      = 6000;
$SHIELDDATA["shieldCreateTime", $HULLTYPE_HUGE]       = 10000;
$SHIELDDATA["shieldCreateTime", $HULLTYPE_MOTHERSHIP] = 15000;
$SHIELDDATA["shieldCreateTime", $HULLTYPE_STATION]    = 20000;
 
$SHIELDDATA["ResourceCost", $HULLTYPE_SMALL]           = 2;  
$SHIELDDATA["ResourceCost", $HULLTYPE_MEDIUM]          = 8;    
$SHIELDDATA["ResourceCost", $HULLTYPE_LARGE]           = 25;   
$SHIELDDATA["ResourceCost", $HULLTYPE_HUGE]            = 100;   
$SHIELDDATA["ResourceCost", $HULLTYPE_MOTHERSHIP]      = 0; 
$SHIELDDATA["ResourceCost", $HULLTYPE_STATION]         = 0;
   
 
function ShieldDatablock::GetProceduralData(%this, %statID)
{
   %datum = $SHIELDDATA[%statID, %this.hullType];
   if ( %datum $= "" )
      echo("$SHIELDDATA::GetProceduralData WARNING: Trying to get invalid procedural Data!" SPC %statID);
   
   return %datum;
}

////////////////////////
// PROCEDURAL Mults ////
////////////////////////
//This is how we keep technology consistent between categories. 

$SHIELDMULTS["powerConsumption", "BASIC"]          = 1.000;
$SHIELDMULTS["powerConsumption", "CIV"]            = 0.500;
$SHIELDMULTS["powerConsumption", "QUICKCHARGE"]    = 1.500;  
$SHIELDMULTS["powerConsumption", "FORTRESS"]       = 1.000;  

$SHIELDMULTS["shieldMaxStrength", "BASIC"]          = 1.000;
$SHIELDMULTS["shieldMaxStrength", "CIV"]            = 0.750;
$SHIELDMULTS["shieldMaxStrength", "QUICKCHARGE"]    = 0.500;  
$SHIELDMULTS["shieldMaxStrength", "FORTRESS"]       = 2.000; 

$SHIELDMULTS["shieldRegenSpeed", "BASIC"]           = 1.000;
$SHIELDMULTS["shieldRegenSpeed", "CIV"]             = 1.250;
$SHIELDMULTS["shieldRegenSpeed", "QUICKCHARGE"]     = 0.500;   //smaller numbers are better
$SHIELDMULTS["shieldRegenSpeed", "FORTRESS"]        = 1.500; 

$SHIELDMULTS["shieldCreateStrength", "BASIC"]       = 1.000;
$SHIELDMULTS["shieldCreateStrength", "CIV"]         = 0.750;
$SHIELDMULTS["shieldCreateStrength", "QUICKCHARGE"] = 0.250;  
$SHIELDMULTS["shieldCreateStrength", "FORTRESS"]    = 1.500; 

$SHIELDMULTS["shieldCreateTime", "BASIC"]           = 1.000;
$SHIELDMULTS["shieldCreateTime", "CIV"]             = 0.750;
$SHIELDMULTS["shieldCreateTime", "QUICKCHARGE"]     = 0.500;  
$SHIELDMULTS["shieldCreateTime", "FORTRESS"]        = 1.500; 

$SHIELDMULTS["ResourceCost", "BASIC"]           = 1.000;
$SHIELDMULTS["ResourceCost", "CIV"]             = 0.500;
$SHIELDMULTS["ResourceCost", "QUICKCHARGE"]     = 2.000;  
$SHIELDMULTS["ResourceCost", "FORTRESS"]        = 4.000; 



function ShieldDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $SHIELDMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("ShieldDatablock::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}


///////////////////////////////////////
//Procedural Stat /////////////////////
///////////////////////////////////////

function ShieldDatablock::GetFinalStat(%this, %statID)
{
   %data = %this.GetProceduralData(%statID);
   %mult = %this.GetProceduralMult(%statID);
   
   %result = %data * %mult;  
   return %result;
}



function ShieldDatablock::HandleProceduralStats(%this)
{     
   %baseStrength = %this.GetProceduralData("shieldMaxStrength"); //need to use an unmodified one for multiplication
   
   %this.shieldMaxStrength     = %this.GetFinalStat("shieldMaxStrength");   
   %this.shieldRegenSpeed      = %baseStrength / %this.GetFinalStat("shieldRegenSpeed"); 
   %this.shieldCreateStrength  = %baseStrength * %this.GetFinalStat("shieldCreateStrength");   
   %this.shieldCreateTime      = %this.GetFinalStat("shieldCreateTime"); 
   
   %this.powerConsumption  = %this.GetFinalStat("PowerConsumption") * %this.referenceReactor.maxReactorOutput;      

   %this.RUCost = mRound(%this.GetFinalStat("ResourceCost"));  //rounding just in case  
}


////////////////////////////////////////
// Base ///////////////////////////////
//////////////////////////////////////


datablock ShieldDatablock(ShieldBase : ComponentBase) 
{       

   componentType                   = "Shield";
   componentSubType                = $SHIELD_Shielding; //defined in researchDatablocks.cs
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   isCloaking                      = false;
   
   shieldCollapseEffect            = "ShieldCollapse";   

   shieldCollapseSound             = "snd_smallShieldFail";       
   
   shieldDamageModifier_Default    = "1";   
   shieldDamageModifier_Explosive  = "0.500";   //explosives very weak against shields
   shieldDamageModifier_Projectile = "0.400"; //was 0.5
   shieldDamageModifier_Energy     = "2"; //lasers nuke shields
   shieldDamageModifier_Ion        = "5.0";
   shieldDamageModifier_Corrosive  = "0.25"; //very little shield damage.
   shieldDamageModifier_Zombify    = "4"; //pops shields right away.
   
   shieldDamageMult = "1";  //this is multiplies by the damage modifiers, and can be increased thru resreach
   
   researchDatablock = "ShieldResearch";
 

   componentButtonColor        = "Basic"; 
   
   purchaseTutorial = "PT_basicShield"; 
};

////////////////////////////////////////
// Smalls /////////////////////////////
//////////////////////////////////////

datablock ShieldDatablock(S_BasicShield : ShieldBase) 
{
   friendlyName = "Small Basic Shield";  
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption

   componentSize                   = $SLOT_SMALL;   
  
   shieldCollapseEffectScale       = "0.25";
   
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S; 
   componentIconGraphic        = "shipconIcon_shield";
         
   sizeTable[$SLOT_SMALL]  = "S_BasicShield";
   sizeTable[$SLOT_MEDIUM] = "M_BasicShield";
   sizeTable[$SLOT_LARGE]  = "L_BasicShield";
   sizeTable[$SLOT_HUGE]   = "H_BasicShield";
};


datablock ShieldDatablock(S_CivShield : S_BasicShield) 
{     
   friendlyName = "Small Civilian Shield";  
   
   purchaseTutorial = "PT_basicShield_civ"; 
   
   myType = "CIV";  
  
   sizeTable[$SLOT_SMALL]  = "S_CivShield";
   sizeTable[$SLOT_MEDIUM] = "M_CivShield";
   sizeTable[$SLOT_LARGE]  = "L_CivShield";
   sizeTable[$SLOT_HUGE]   = "H_CivShield";
   
   componentButtonColor        = "Civ";
};

datablock ShieldDatablock(S_QuickChargeShield : S_BasicShield) 
{   
   friendlyName = "Small Quick Charge Shield";  
      
   myType = "QUICKCHARGE";  
   
   componentButtonColor            = "Improved";
   
   componentIconGraphic        = "shipconIcon_shieldQuick";
   
   purchaseTutorial = "PT_quickShield"; 
   
   sizeTable[$SLOT_SMALL]  = "S_QuickChargeShield";
   sizeTable[$SLOT_MEDIUM] = "M_QuickChargeShield";
   sizeTable[$SLOT_LARGE]  = "L_QuickChargeShield";
   sizeTable[$SLOT_HUGE]   = "H_QuickChargeShield"; 
};


datablock ShieldDatablock(S_FortressShield : S_BasicShield) 
{   
   friendlyName = "Small Fortress Shield";  
   
   myType = "FORTRESS";  
   
   componentButtonColor        = "Advanced";
   
   componentIconGraphic        = "shipconIcon_shieldFort";
   
   purchaseTutorial = "PT_fortShield"; 
   
   sizeTable[$SLOT_SMALL]  = "S_FortressShield";
   sizeTable[$SLOT_MEDIUM] = "M_FortressShield";
   sizeTable[$SLOT_LARGE]  = "L_FortressShield";
   sizeTable[$SLOT_HUGE]   = "H_FortressShield"; 
};


////////////////////////////////////////
// Mediums /////////////////////////////
//////////////////////////////////////

datablock ShieldDatablock(M_BasicShield : ShieldBase) 
{
   friendlyName = "Medium Basic Shield";  
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption

   componentSize                   = $SLOT_MEDIUM;        
   
   shieldCollapseEffectScale       = "0.5";   
      
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_shield";
        
   sizeTable[$SLOT_SMALL]  = "S_BasicShield";
   sizeTable[$SLOT_MEDIUM] = "M_BasicShield";
   sizeTable[$SLOT_LARGE]  = "L_BasicShield";
   sizeTable[$SLOT_HUGE]   = "H_BasicShield";
};

datablock ShieldDatablock(M_CivShield : M_BasicShield) 
{    
   friendlyName = "Medium Civilian Shield";  
   
   purchaseTutorial = "PT_basicShield_civ"; 
    
   myType = "CIV";
 
   sizeTable[$SLOT_SMALL]  = "S_CivShield";
   sizeTable[$SLOT_MEDIUM] = "M_CivShield";
   sizeTable[$SLOT_LARGE]  = "L_CivShield";
   sizeTable[$SLOT_HUGE]   = "H_CivShield";
   
   componentButtonColor        = "Civ";
};

datablock ShieldDatablock(M_QuickChargeShield : M_BasicShield) 
{   
   friendlyName = "Medium Quick Charge Shield";    
   
   myType = "QUICKCHARGE";  
   
   componentButtonColor            = "Improved";
   
   componentIconGraphic        = "shipconIcon_shieldQuick";
   
   purchaseTutorial = "PT_quickShield"; 
   
   sizeTable[$SLOT_SMALL]  = "S_QuickChargeShield";
   sizeTable[$SLOT_MEDIUM] = "M_QuickChargeShield";
   sizeTable[$SLOT_LARGE]  = "L_QuickChargeShield";
   sizeTable[$SLOT_HUGE]   = "H_QuickChargeShield"; 
};


datablock ShieldDatablock(M_FortressShield : M_BasicShield) 
{   
   friendlyName = "Medium Fortress Shield"; 
   
   myType = "FORTRESS"; 
   
   componentButtonColor            = "Advanced";
   
   componentIconGraphic        = "shipconIcon_shieldFort";
   
   purchaseTutorial = "PT_fortShield"; 
   
   sizeTable[$SLOT_SMALL]  = "S_FortressShield";
   sizeTable[$SLOT_MEDIUM] = "M_FortressShield";
   sizeTable[$SLOT_LARGE]  = "L_FortressShield";
   sizeTable[$SLOT_HUGE]   = "H_FortressShield"; 
};


////////////////////////////////////////
// Larges /////////////////////////////
//////////////////////////////////////

datablock ShieldDatablock(L_BasicShield : ShieldBase) 
{
   friendlyName = "Large Basic Shield"; 
   
   shieldCollapseEffect            = "ShieldCollapse_Large";       
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

   componentSize                   = $SLOT_LARGE;        
   
   shieldCollapseEffectScale       = "0.7";
    
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;  
   componentIconGraphic        = "shipconIcon_shield";
  
   sizeTable[$SLOT_SMALL]  = "S_BasicShield";
   sizeTable[$SLOT_MEDIUM] = "M_BasicShield";
   sizeTable[$SLOT_LARGE]  = "L_BasicShield";
   sizeTable[$SLOT_HUGE]   = "H_BasicShield";
};


datablock ShieldDatablock(L_CivShield : L_BasicShield) 
{    
   friendlyName = "Large Civilian Shield"; 
   
   purchaseTutorial = "PT_basicShield_civ";    
    
   myType = "CIV";
   
   sizeTable[$SLOT_SMALL]  = "S_CivShield";
   sizeTable[$SLOT_MEDIUM] = "M_CivShield";
   sizeTable[$SLOT_LARGE]  = "L_CivShield";
   sizeTable[$SLOT_HUGE]   = "H_CivShield";
   
   componentButtonColor        = "Civ";  
};


datablock ShieldDatablock(L_QuickChargeShield : L_BasicShield) 
{   
   friendlyName = "Large Quick Charge Shield"; 
   
   myType = "QUICKCHARGE";  
   
   componentButtonColor            = "Improved";
   
   componentIconGraphic        = "shipconIcon_shieldQuick";
   
   purchaseTutorial = "PT_quickShield"; 
   
   sizeTable[$SLOT_SMALL]  = "S_QuickChargeShield";
   sizeTable[$SLOT_MEDIUM] = "M_QuickChargeShield";
   sizeTable[$SLOT_LARGE]  = "L_QuickChargeShield";
   sizeTable[$SLOT_HUGE]   = "H_QuickChargeShield"; 
};

datablock ShieldDatablock(L_FortressShield : L_BasicShield) 
{   
   friendlyName = "Large Fortress Shield"; 
   
   myType = "FORTRESS"; 
   
   componentButtonColor            = "Advanced";
   
   componentIconGraphic        = "shipconIcon_shieldFort";
   
   purchaseTutorial = "PT_fortShield"; 
   
   sizeTable[$SLOT_SMALL]  = "S_FortressShield";
   sizeTable[$SLOT_MEDIUM] = "M_FortressShield";
   sizeTable[$SLOT_LARGE]  = "L_FortressShield";
   sizeTable[$SLOT_HUGE]   = "H_FortressShield"; 
};


////////////////////////////////////////
// Huges //////////////////////////////
//////////////////////////////////////


datablock ShieldDatablock(H_BasicShield : ShieldBase) 
{
   friendlyName = "Huge Basic Shield";    
   
   shieldCollapseEffect            = "ShieldCollapse_Large";       
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption

   componentSize                   = $SLOT_HUGE;     
   
   shieldCollapseEffectScale       = "1";
     
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_shield";
  
   sizeTable[$SLOT_SMALL]  = "S_BasicShield";
   sizeTable[$SLOT_MEDIUM] = "M_BasicShield";
   sizeTable[$SLOT_LARGE]  = "L_BasicShield";
   sizeTable[$SLOT_HUGE]   = "H_BasicShield";
};


datablock ShieldDatablock(H_CivShield : H_BasicShield) 
{     
   friendlyName = "Huge Civilian Shield";
   
   purchaseTutorial = "PT_basicShield_civ";  
   
   myType = "CIV";
   
   sizeTable[$SLOT_SMALL]  = "S_CivShield";
   sizeTable[$SLOT_MEDIUM] = "M_CivShield";
   sizeTable[$SLOT_LARGE]  = "L_CivShield";
   sizeTable[$SLOT_HUGE]   = "H_CivShield";
   
   componentButtonColor        = "Civ";  
};


datablock ShieldDatablock(H_QuickChargeShield : H_BasicShield) 
{   
   friendlyName = "Huge Quick Charge Shield"; 
   
   myType = "QUICKCHARGE";  
   
   componentButtonColor            = "Improved";
   
   componentIconGraphic        = "shipconIcon_shieldQuick";
   
   purchaseTutorial = "PT_quickShield";
   
   sizeTable[$SLOT_SMALL]  = "S_QuickChargeShield";
   sizeTable[$SLOT_MEDIUM] = "M_QuickChargeShield";
   sizeTable[$SLOT_LARGE]  = "L_QuickChargeShield";
   sizeTable[$SLOT_HUGE]   = "H_QuickChargeShield"; 
};

datablock ShieldDatablock(H_FortressShield : H_BasicShield) 
{   
   friendlyName = "Huge Fortress Shield"; 
   
   myType = "FORTRESS"; 
   
   componentButtonColor            = "Advanced";
   
   componentIconGraphic        = "shipconIcon_shieldFort";
   
   purchaseTutorial = "PT_fortShield"; 
   
   sizeTable[$SLOT_SMALL]  = "S_FortressShield";
   sizeTable[$SLOT_MEDIUM] = "M_FortressShield";
   sizeTable[$SLOT_LARGE]  = "L_FortressShield";
   sizeTable[$SLOT_HUGE]   = "H_FortressShield"; 
};




////////////////////////////////////////
// Specials ////////////////////////////
//////////////////////////////////////
datablock ShieldDatablock(Mothership_BasicShield : ShieldBase) 
{
   friendlyName = "Mothership Shield"; 
   
   shieldCollapseEffect            = "ShieldCollapse_Large";       
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MOTHERSHIP; //used for procedural systmes.
   referenceReactor = "Mothership_BasicReactor"; //used to determine power consumption

   componentSize                   = $SLOT_MOTHERSHIP;     
   
   shieldCollapseEffectScale       = "1";
     
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_shield";  
};

datablock ShieldDatablock(Mothership_FortressShield : Mothership_BasicShield) 
{
   friendlyName = "Mothership Fortress Shield"; 
   
   shieldCollapseEffect            = "ShieldCollapse_Large";       
   
   componentSize                   = $SLOT_MOTHERSHIP;     
   myType = "FORTRESS";
   
   shieldCollapseEffectScale       = "1";
     
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_shield";  
};


//Civillian
datablock ShieldDatablock(Station_CivShield : ShieldBase) 
{
   friendlyName = "Station Shield";    
   
   shieldCollapseEffect            = "ShieldCollapse_Large";       
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_STATION; //used for procedural systmes.
   referenceReactor = "Station_CivReactor"; //used to determine power consumption

   componentSize                   = $SLOT_MOTHERSHIP;     
      
   shieldCollapseEffectScale       = "1";
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_shield";
};


datablock ShieldDatablock(Station_ImprovedShield : ShieldBase) 
{
   friendlyName = "Station Shield";    
   
   shieldCollapseEffect            = "ShieldCollapse_Large";       
   
   myType = "QUICKCHARGE"; //used for procedural systmes.
   hullType = $HULLTYPE_STATION; //used for procedural systmes.
   referenceReactor = "Station_CivReactor"; //used to determine power consumption

   componentSize                   = $SLOT_MOTHERSHIP;     
      
   shieldCollapseEffectScale       = "1";
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_shield";
};


datablock ShieldDatablock(Station_AdvancedShield : ShieldBase) 
{
   friendlyName = "Station Shield";    
   
   shieldCollapseEffect            = "ShieldCollapse_Large";       
   
   myType = "FORTRESS"; //used for procedural systmes.
   hullType = $HULLTYPE_STATION; //used for procedural systmes.
   referenceReactor = "Station_CivReactor"; //used to determine power consumption

   componentSize                   = $SLOT_MOTHERSHIP;     
      
   shieldCollapseEffectScale       = "1";
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
   componentIconGraphic        = "shipconIcon_shield";
};
























