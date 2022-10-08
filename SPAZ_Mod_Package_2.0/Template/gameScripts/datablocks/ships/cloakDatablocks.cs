function CloakDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "CloakBase" )
      return;
      
   %this.HandleProceduralStats();
   
   Parent::onAdd(%this);            
}



////////////////////////////////////////////////
// PROCEDURAL DATA  ////////////////////////////
////////////////////////////////////////////////
//These are the numbers for the basic military version. 


$CLOAKDATA["powerConsumption", $HULLTYPE_SMALL]        = 0.250;
$CLOAKDATA["powerConsumption", $HULLTYPE_MEDIUM]       = 0.250;
$CLOAKDATA["powerConsumption", $HULLTYPE_LARGE]        = 0.250;
$CLOAKDATA["powerConsumption", $HULLTYPE_HUGE]         = 0.250;
$CLOAKDATA["powerConsumption", $HULLTYPE_MOTHERSHIP]   = 0.250;
$CLOAKDATA["powerConsumption", $HULLTYPE_STATION]      = 0.250;

$CLOAKDATA["shieldMaxStrength", $HULLTYPE_SMALL]       = $SHIELDDATA["shieldMaxStrength", $HULLTYPE_SMALL] / 1.7;
$CLOAKDATA["shieldMaxStrength", $HULLTYPE_MEDIUM]      = $SHIELDDATA["shieldMaxStrength", $HULLTYPE_MEDIUM] / 1.7;
$CLOAKDATA["shieldMaxStrength", $HULLTYPE_LARGE]       = $SHIELDDATA["shieldMaxStrength", $HULLTYPE_LARGE] / 1.7;
$CLOAKDATA["shieldMaxStrength", $HULLTYPE_HUGE]        = $SHIELDDATA["shieldMaxStrength", $HULLTYPE_HUGE] / 1.7;
$CLOAKDATA["shieldMaxStrength", $HULLTYPE_MOTHERSHIP]  = $SHIELDDATA["shieldMaxStrength", $HULLTYPE_MOTHERSHIP] / 1.7;
$CLOAKDATA["shieldMaxStrength", $HULLTYPE_STATION]     = $SHIELDDATA["shieldMaxStrength", $HULLTYPE_STATION] / 1.7;
   
//How many seconds to recharge shields fully (proportional to shieldMaxStrength)
$CLOAKDATA["shieldRegenSpeed", $HULLTYPE_SMALL]        = $SHIELDDATA["shieldRegenSpeed", $HULLTYPE_SMALL];
$CLOAKDATA["shieldRegenSpeed", $HULLTYPE_MEDIUM]       = $SHIELDDATA["shieldRegenSpeed", $HULLTYPE_MEDIUM];
$CLOAKDATA["shieldRegenSpeed", $HULLTYPE_LARGE]        = $SHIELDDATA["shieldRegenSpeed", $HULLTYPE_LARGE];
$CLOAKDATA["shieldRegenSpeed", $HULLTYPE_HUGE]         = $SHIELDDATA["shieldRegenSpeed", $HULLTYPE_HUGE];
$CLOAKDATA["shieldRegenSpeed", $HULLTYPE_MOTHERSHIP]   = $SHIELDDATA["shieldRegenSpeed", $HULLTYPE_MOTHERSHIP];
$CLOAKDATA["shieldRegenSpeed", $HULLTYPE_STATION]      = $SHIELDDATA["shieldRegenSpeed", $HULLTYPE_STATION];
  
//This is a percentage of max strength
$CLOAKDATA["shieldCreateStrength", $HULLTYPE_SMALL]      = 0.200;
$CLOAKDATA["shieldCreateStrength", $HULLTYPE_MEDIUM]     = 0.200;
$CLOAKDATA["shieldCreateStrength", $HULLTYPE_LARGE]      = 0.200;
$CLOAKDATA["shieldCreateStrength", $HULLTYPE_HUGE]       = 0.200;
$CLOAKDATA["shieldCreateStrength", $HULLTYPE_MOTHERSHIP] = 0.200;
$CLOAKDATA["shieldCreateStrength", $HULLTYPE_STATION]    = 0.200;
  
//This is in MS
$CLOAKDATA["shieldCreateTime", $HULLTYPE_SMALL]      = 2000;
$CLOAKDATA["shieldCreateTime", $HULLTYPE_MEDIUM]     = 3000;
$CLOAKDATA["shieldCreateTime", $HULLTYPE_LARGE]      = 4000;
$CLOAKDATA["shieldCreateTime", $HULLTYPE_HUGE]       = 5000;
$CLOAKDATA["shieldCreateTime", $HULLTYPE_MOTHERSHIP] = 7000;
$CLOAKDATA["shieldCreateTime", $HULLTYPE_STATION]    = 7000;
 
$CLOAKDATA["ResourceCost", $HULLTYPE_SMALL]           = 2;  
$CLOAKDATA["ResourceCost", $HULLTYPE_MEDIUM]          = 8;    
$CLOAKDATA["ResourceCost", $HULLTYPE_LARGE]           = 25;   
$CLOAKDATA["ResourceCost", $HULLTYPE_HUGE]            = 100;   
$CLOAKDATA["ResourceCost", $HULLTYPE_MOTHERSHIP]      = 0; 
$CLOAKDATA["ResourceCost", $HULLTYPE_STATION]         = 0;
   
$CLOAKDATA["cloakEngineSpeedDecrease", $HULLTYPE_SMALL]        = 0.140;  
$CLOAKDATA["cloakEngineSpeedDecrease", $HULLTYPE_MEDIUM]       = 0.140;     
$CLOAKDATA["cloakEngineSpeedDecrease", $HULLTYPE_LARGE]        = 0.140;   
$CLOAKDATA["cloakEngineSpeedDecrease", $HULLTYPE_HUGE]         = 0.140;   
$CLOAKDATA["cloakEngineSpeedDecrease", $HULLTYPE_MOTHERSHIP]   = 1.0; 
$CLOAKDATA["cloakEngineSpeedDecrease", $HULLTYPE_STATION]      = 1.0;

$CLOAKDATA["cloakTurnRateDecrease", $HULLTYPE_SMALL]           = 0.14;  
$CLOAKDATA["cloakTurnRateDecrease", $HULLTYPE_MEDIUM]          = 0.14;     
$CLOAKDATA["cloakTurnRateDecrease", $HULLTYPE_LARGE]           = 0.14;   
$CLOAKDATA["cloakTurnRateDecrease", $HULLTYPE_HUGE]            = 0.14;   
$CLOAKDATA["cloakTurnRateDecrease", $HULLTYPE_MOTHERSHIP]      = 0.14;  
$CLOAKDATA["cloakTurnRateDecrease", $HULLTYPE_STATION]         = 0.14; 
  
$CLOAKDATA["cloakThrustDecrease", $HULLTYPE_SMALL]             = 0.14;  
$CLOAKDATA["cloakThrustDecrease", $HULLTYPE_MEDIUM]            = 0.14;     
$CLOAKDATA["cloakThrustDecrease", $HULLTYPE_LARGE]             = 0.14;   
$CLOAKDATA["cloakThrustDecrease", $HULLTYPE_HUGE]              = 0.14;   
$CLOAKDATA["cloakThrustDecrease", $HULLTYPE_MOTHERSHIP]        = 0.14;  
$CLOAKDATA["cloakThrustDecrease", $HULLTYPE_STATION]           = 0.14; 
  
//in seconds
$CLOAKDATA["cloakDisruptionTime", $HULLTYPE_SMALL]             = 1;  
$CLOAKDATA["cloakDisruptionTime", $HULLTYPE_MEDIUM]            = 1.5;     
$CLOAKDATA["cloakDisruptionTime", $HULLTYPE_LARGE]             = 2.0;   
$CLOAKDATA["cloakDisruptionTime", $HULLTYPE_HUGE]              = 3;   
$CLOAKDATA["cloakDisruptionTime", $HULLTYPE_MOTHERSHIP]        = 5;  
$CLOAKDATA["cloakDisruptionTime", $HULLTYPE_STATION]           = 5;
  
function CloakDatablock::GetProceduralData(%this, %statID)
{
   %datum = $CLOAKDATA[%statID, %this.hullType];
   if ( %datum $= "" )
      echo("CloakDatablock::GetProceduralData WARNING: Trying to get invalid procedural Data!" SPC %statID);
   
   return %datum;
}

////////////////////////
// PROCEDURAL Mults ////
////////////////////////
//This is how we keep technology consistent between categories. 

$CLOAKMULTS["powerConsumption", "BASIC"]          = 1.000;
$CLOAKMULTS["powerConsumption", "CIV"]            = 0.500;
$CLOAKMULTS["powerConsumption", "STABLE"]         = 1.333;  
$CLOAKMULTS["powerConsumption", "EXPERIMENTAL"]   = 1.667;  

$CLOAKMULTS["shieldMaxStrength", "BASIC"]          = 1.000;
$CLOAKMULTS["shieldMaxStrength", "CIV"]            = 0.750;
$CLOAKMULTS["shieldMaxStrength", "STABLE"]         = 2.000;  
$CLOAKMULTS["shieldMaxStrength", "EXPERIMENTAL"]   = 1.250; 

$CLOAKMULTS["shieldRegenSpeed", "BASIC"]           = 1.000;
$CLOAKMULTS["shieldRegenSpeed", "CIV"]             = 1.500;
$CLOAKMULTS["shieldRegenSpeed", "STABLE"]          = 0.667;   //smaller numbers are better
$CLOAKMULTS["shieldRegenSpeed", "EXPERIMENTAL"]    = 0.850; 

$CLOAKMULTS["shieldCreateStrength", "BASIC"]       = 1.000;
$CLOAKMULTS["shieldCreateStrength", "CIV"]         = 0.750;
$CLOAKMULTS["shieldCreateStrength", "STABLE"]      = 2.000;  
$CLOAKMULTS["shieldCreateStrength", "EXPERIMENTAL"]= 1.500; 

$CLOAKMULTS["shieldCreateTime", "BASIC"]           = 1.000;
$CLOAKMULTS["shieldCreateTime", "CIV"]             = 1.500;
$CLOAKMULTS["shieldCreateTime", "STABLE"]          = 0.500;  
$CLOAKMULTS["shieldCreateTime", "EXPERIMENTAL"]    = 1.500; 

$CLOAKMULTS["ResourceCost", "BASIC"]               = 1.000;
$CLOAKMULTS["ResourceCost", "CIV"]                 = 0.500;
$CLOAKMULTS["ResourceCost", "STABLE"]              = 2.000;  
$CLOAKMULTS["ResourceCost", "EXPERIMENTAL"]        = 4.000; 

$CLOAKMULTS["cloakEngineSpeedDecrease", "BASIC"]       = 1.000;
$CLOAKMULTS["cloakEngineSpeedDecrease", "CIV"]         = 1.333;
$CLOAKMULTS["cloakEngineSpeedDecrease", "STABLE"]      = 1.333; 
$CLOAKMULTS["cloakEngineSpeedDecrease", "EXPERIMENTAL"]= 0.500; 

$CLOAKMULTS["cloakTurnRateDecrease", "BASIC"]          = 1.000;
$CLOAKMULTS["cloakTurnRateDecrease", "CIV"]            = 1.500;
$CLOAKMULTS["cloakTurnRateDecrease", "STABLE"]         = 1.500; 
$CLOAKMULTS["cloakTurnRateDecrease", "EXPERIMENTAL"]   = 0.500; 

$CLOAKMULTS["cloakThrustDecrease", "BASIC"]            = 1.000;
$CLOAKMULTS["cloakThrustDecrease", "CIV"]              = 1.500;
$CLOAKMULTS["cloakThrustDecrease", "STABLE"]           = 1.500;  
$CLOAKMULTS["cloakThrustDecrease", "EXPERIMENTAL"]     = 0.500; 

$CLOAKMULTS["cloakDisruptionTime", "BASIC"]            = 1.000;
$CLOAKMULTS["cloakDisruptionTime", "CIV"]              = 1.500;
$CLOAKMULTS["cloakDisruptionTime", "STABLE"]           = 0.500;  
$CLOAKMULTS["cloakDisruptionTime", "EXPERIMENTAL"]     = 0.850; 

function CloakDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $CLOAKMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("CloakDatablock::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}


///////////////////////////////////////
//Procedural Stat /////////////////////
///////////////////////////////////////

function CloakDatablock::GetFinalStat(%this, %statID)
{
   %data = %this.GetProceduralData(%statID);
   %mult = %this.GetProceduralMult(%statID);
   
   %result = %data * %mult;  
   return %result;
}



function CloakDatablock::HandleProceduralStats(%this)
{     
   %baseStrength = %this.GetProceduralData("shieldMaxStrength"); //need to use an unmodified one for multiplication
   
   %this.shieldMaxStrength     = %this.GetFinalStat("shieldMaxStrength");   
   %this.shieldRegenSpeed      = %baseStrength / %this.GetFinalStat("shieldRegenSpeed"); 
   %this.shieldCreateStrength  = %baseStrength * %this.GetFinalStat("shieldCreateStrength");   
   %this.shieldCreateTime      = %this.GetFinalStat("shieldCreateTime"); 
   
   %this.powerConsumption  = %this.GetFinalStat("PowerConsumption") * %this.referenceReactor.maxReactorOutput;      

   %this.RUCost = mRound(%this.GetFinalStat("ResourceCost"));  //rounding just in case  

   %this.cloakEngineSpeedDecrease = %this.GetFinalStat("cloakEngineSpeedDecrease"); 
   %this.cloakTurnRateDecrease = %this.GetFinalStat("cloakTurnRateDecrease");
   %this.cloakThrustDecrease = %this.GetFinalStat("cloakThrustDecrease");
   %this.cloakDisruptionTime = %this.GetFinalStat("cloakDisruptionTime");
}


////////////////////////////////////////
// Base ///////////////////////////////
//////////////////////////////////////


//A cloaking device is a modified shield
//cloack have weak shields.  the cloak is disrupted when the shields drop. 
datablock CloakDatablock(CloakBase : ComponentBase) 
{       

   componentType                   = "Shield";  //cloak is a sub type of shield with its own research tree. 
   componentSubType                = $SHIELD_Cloaking;  //defined in researchDatablocks.cs
   isCloaking                      = true;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
      
   shieldCollapseEffect            = "ShieldCollapse";    
   shieldCollapseSound             = "snd_cloakLost";       
   
   cloakHitEffect                  = "CloakImpact";
   cloakHitEffectScale             = 0.5;
  
   
   cloakInitEffect                 = "CloakEngage";
   cloakInitEffectScale            = 1;
   cloakInitSound                  = "snd_cloakEngage";
      
   cloakDamageBoost                = 1.000; //more damage while cloaked or cloak disrupted (universal)
   
   shieldDamageModifier_Default    = "1";   
   shieldDamageModifier_Explosive  = "0.5";   //explosives very weak against shields
   shieldDamageModifier_Projectile = "1";
   shieldDamageModifier_Energy     = "2.0"; //lasers nuke shields
   shieldDamageModifier_Ion        = "10.0";
   shieldDamageModifier_Corrosive  = "0.33"; //wont break the cloak right away, but will disrupt it.
   
   shieldDamageMult = "1";  //this is multiplies by the damage modifiers, and can be increased thru resreach
   
   researchDatablock = "CloakingResearch";
   
   purchaseTutorial = "PT_basicCloak";
};


/////////////////////////////////////////
// SMALLS ///////////////////////////////
/////////////////////////////////////////

datablock CloakDatablock(S_BasicCloak : CloakBase) 
{
   friendlyName = "Small Basic Cloak";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
   
   componentSize                   = $SLOT_SMALL;      
   
   shieldCollapseEffectScale       = "0.2";
      
   componentButtonBitmap           = $compButtonType_S;
   componentButtonSize             = $compButtonSize_S; 
   componentIconGraphic            = "shipconIcon_cloak";  
   
   componentButtonColor        = "Basic";
   
   sizeTable[$SLOT_SMALL]  = "S_BasicCloak";
   sizeTable[$SLOT_MEDIUM] = "M_BasicCloak";
   sizeTable[$SLOT_LARGE]  = "L_BasicCloak";
   sizeTable[$SLOT_HUGE]   = "H_BasicCloak";
};
datablock CloakDatablock(S_CivCloak : S_BasicCloak) 
{
   friendlyName = "Small Civ Cloak";   
   myType = "CIV"; //used for procedural systmes.
   componentButtonColor        = "Civ";
   
   sizeTable[$SLOT_SMALL]  = "S_CivCloak";
   sizeTable[$SLOT_MEDIUM] = "M_CivCloak";
   sizeTable[$SLOT_LARGE]  = "L_CivCloak";
   sizeTable[$SLOT_HUGE]   = "H_CivCloak";
   
   purchaseTutorial = "PT_surplusCloak";
};

datablock CloakDatablock(S_StableCloak : S_BasicCloak) 
{
   friendlyName = "Small Stable Cloak";
   
   myType = "STABLE";
   
   componentButtonColor        = "Improved";
   
   componentIconGraphic            = "shipconIcon_cloakStable";
   
   purchaseTutorial = "PT_stableCloak";
   
   sizeTable[$SLOT_SMALL]  = "S_StableCloak";
   sizeTable[$SLOT_MEDIUM] = "M_StableCloak";
   sizeTable[$SLOT_LARGE]  = "L_StableCloak";
   sizeTable[$SLOT_HUGE]   = "H_StableCloak";
};


datablock CloakDatablock(S_ExperimentalCloak : S_BasicCloak) 
{
   friendlyName = "Small Experimental Cloak";
   
   myType = "EXPERIMENTAL";
   
   componentButtonColor        = "Advanced";
   
   componentIconGraphic            = "shipconIcon_cloakExp";
   
   purchaseTutorial = "PT_experimentalCloak";
   
   sizeTable[$SLOT_SMALL]  = "S_ExperimentalCloak";
   sizeTable[$SLOT_MEDIUM] = "M_ExperimentalCloak";
   sizeTable[$SLOT_LARGE]  = "L_ExperimentalCloak";
   sizeTable[$SLOT_HUGE]   = "H_ExperimentalCloak";
};
/////////////////////////////////////////
// Mediums ///////////////////////////////
/////////////////////////////////////////

datablock CloakDatablock(M_BasicCloak : CloakBase) 
{
   friendlyName = "Medium Basic Cloak";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
   
   componentSize                   = $SLOT_MEDIUM;   
   
   shieldCollapseEffectScale       = "0.5";
      
   componentButtonBitmap           = $compButtonType_M;
   componentButtonSize             = $compButtonSize_M; 
   componentIconGraphic            = "shipconIcon_cloak";
     
   componentButtonColor        = "Basic";
   
   sizeTable[$SLOT_SMALL]  = "S_BasicCloak";
   sizeTable[$SLOT_MEDIUM] = "M_BasicCloak";
   sizeTable[$SLOT_LARGE]  = "L_BasicCloak";
   sizeTable[$SLOT_HUGE]   = "H_BasicCloak";
};
datablock CloakDatablock(M_CivCloak : M_BasicCloak) 
{
   friendlyName = "Medium Civ Cloak";   
   myType = "CIV"; //used for procedural systmes.
   componentButtonColor        = "Civ";
   
   sizeTable[$SLOT_SMALL]  = "S_CivCloak";
   sizeTable[$SLOT_MEDIUM] = "M_CivCloak";
   sizeTable[$SLOT_LARGE]  = "L_CivCloak";
   sizeTable[$SLOT_HUGE]   = "H_CivCloak";
   
   purchaseTutorial = "PT_surplusCloak";
};


datablock CloakDatablock(M_StableCloak : M_BasicCloak) 
{
   friendlyName = "Medium Stable Cloak";
   
   myType = "STABLE";
   
   componentButtonColor        = "Improved";
   
   componentIconGraphic            = "shipconIcon_cloakStable";
   
   purchaseTutorial = "PT_stableCloak";
   
   sizeTable[$SLOT_SMALL]  = "S_StableCloak";
   sizeTable[$SLOT_MEDIUM] = "M_StableCloak";
   sizeTable[$SLOT_LARGE]  = "L_StableCloak";
   sizeTable[$SLOT_HUGE]   = "H_StableCloak";
};


datablock CloakDatablock(M_ExperimentalCloak : M_BasicCloak) 
{
   friendlyName = "Medium Experimental Cloak";
   
   myType = "EXPERIMENTAL";
   
   componentButtonColor        = "Advanced";
   
   componentIconGraphic            = "shipconIcon_cloakExp";
   
   purchaseTutorial = "PT_experimentalCloak";
   
   sizeTable[$SLOT_SMALL]  = "S_ExperimentalCloak";
   sizeTable[$SLOT_MEDIUM] = "M_ExperimentalCloak";
   sizeTable[$SLOT_LARGE]  = "L_ExperimentalCloak";
   sizeTable[$SLOT_HUGE]   = "H_ExperimentalCloak";
};

/////////////////////////////////////////
// Larges ///////////////////////////////
/////////////////////////////////////////


datablock CloakDatablock(L_BasicCloak : CloakBase) 
{
   friendlyName = "Large Basic Cloak";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption
   
   componentSize                   = $SLOT_LARGE;   
      
   shieldCollapseEffectScale       = "0.7";
   
   componentButtonBitmap           = $compButtonType_L;
   componentButtonSize             = $compButtonSize_L; 
   componentIconGraphic            = "shipconIcon_cloak";
    
   componentButtonColor        = "Basic";
   
   sizeTable[$SLOT_SMALL]  = "S_BasicCloak";
   sizeTable[$SLOT_MEDIUM] = "M_BasicCloak";
   sizeTable[$SLOT_LARGE]  = "L_BasicCloak";
   sizeTable[$SLOT_HUGE]   = "H_BasicCloak";
};
datablock CloakDatablock(L_CivCloak : L_BasicCloak) 
{
   friendlyName = "Large Civ Cloak";   
   myType = "CIV"; //used for procedural systmes.
   componentButtonColor        = "Civ";
   
   sizeTable[$SLOT_SMALL]  = "S_CivCloak";
   sizeTable[$SLOT_MEDIUM] = "M_CivCloak";
   sizeTable[$SLOT_LARGE]  = "L_CivCloak";
   sizeTable[$SLOT_HUGE]   = "H_CivCloak";
   
   purchaseTutorial = "PT_surplusCloak";
};

datablock CloakDatablock(L_StableCloak : L_BasicCloak) 
{
   friendlyName = "Large Stable Cloak";   
   
   myType = "STABLE";
   
   componentButtonColor        = "Improved";
   
   componentIconGraphic            = "shipconIcon_cloakStable";
   
   purchaseTutorial = "PT_stableCloak";
   
   sizeTable[$SLOT_SMALL]  = "S_StableCloak";
   sizeTable[$SLOT_MEDIUM] = "M_StableCloak";
   sizeTable[$SLOT_LARGE]  = "L_StableCloak";
   sizeTable[$SLOT_HUGE]   = "H_StableCloak";
};


datablock CloakDatablock(L_ExperimentalCloak : L_BasicCloak) 
{
   friendlyName = "Large Experimental Cloak";
   
   myType = "EXPERIMENTAL";
   
   componentButtonColor        = "Advanced";
   
   componentIconGraphic            = "shipconIcon_cloakExp";
   
   purchaseTutorial = "PT_experimentalCloak";
   
   sizeTable[$SLOT_SMALL]  = "S_ExperimentalCloak";
   sizeTable[$SLOT_MEDIUM] = "M_ExperimentalCloak";
   sizeTable[$SLOT_LARGE]  = "L_ExperimentalCloak";
   sizeTable[$SLOT_HUGE]   = "H_ExperimentalCloak";
};
/////////////////////////////////////////
// Huges/ ///////////////////////////////
/////////////////////////////////////////


datablock CloakDatablock(H_BasicCloak : CloakBase) 
{
   friendlyName = "Huge Basic Cloak";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption
   
   componentSize                   = $SLOT_HUGE;   
   
   shieldCollapseEffectScale       = "1";
      
   componentButtonBitmap           = $compButtonType_H;
   componentButtonSize             = $compButtonSize_H; 
   componentIconGraphic            = "shipconIcon_cloak";
 
   componentButtonColor        = "Basic";
   
   sizeTable[$SLOT_SMALL]  = "S_BasicCloak";
   sizeTable[$SLOT_MEDIUM] = "M_BasicCloak";
   sizeTable[$SLOT_LARGE]  = "L_BasicCloak";
   sizeTable[$SLOT_HUGE]   = "H_BasicCloak";
};
datablock CloakDatablock(H_CivCloak : H_BasicCloak) 
{
   friendlyName = "Huge Civ Cloak";   
   myType = "CIV"; //used for procedural systmes.
   componentButtonColor        = "Civ";
   
   sizeTable[$SLOT_SMALL]  = "S_CivCloak";
   sizeTable[$SLOT_MEDIUM] = "M_CivCloak";
   sizeTable[$SLOT_LARGE]  = "L_CivCloak";
   sizeTable[$SLOT_HUGE]   = "H_CivCloak";
   
   purchaseTutorial = "PT_surplusCloak";
};


datablock CloakDatablock(H_StableCloak : H_BasicCloak) 
{
   friendlyName = "Huge Stable Cloak";   
   
   myType = "STABLE";
   
   componentButtonColor        = "Improved";
   
   componentIconGraphic            = "shipconIcon_cloakStable";
   
   purchaseTutorial = "PT_stableCloak";
   
   sizeTable[$SLOT_SMALL]  = "S_StableCloak";
   sizeTable[$SLOT_MEDIUM] = "M_StableCloak";
   sizeTable[$SLOT_LARGE]  = "L_StableCloak";
   sizeTable[$SLOT_HUGE]   = "H_StableCloak";
};


datablock CloakDatablock(H_ExperimentalCloak : H_BasicCloak) 
{
   friendlyName = "Huge Experimental Cloak";
   
   myType = "EXPERIMENTAL";
   
   componentButtonColor        = "Advanced";
   
   componentIconGraphic            = "shipconIcon_cloakExp";
   
   purchaseTutorial = "PT_experimentalCloak";
   
   sizeTable[$SLOT_SMALL]  = "S_ExperimentalCloak";
   sizeTable[$SLOT_MEDIUM] = "M_ExperimentalCloak";
   sizeTable[$SLOT_LARGE]  = "L_ExperimentalCloak";
   sizeTable[$SLOT_HUGE]   = "H_ExperimentalCloak";
};













