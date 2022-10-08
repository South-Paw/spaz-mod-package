//engine Datablocks

function EngineDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "EngineBase" )
      return;
            
   %this.HandleProceduralStats();
   Parent::onAdd(%this);            
}

//Private
function EngineDatablock::GetEngineEffectData(%this, %engineType, %factionName)
{
   %engineEffectData = %this.engineEffects[%engineType, %factionName];
   if ( %engineEffectData $= "" )
      %engineEffectData = %this.engineEffects[%engineType, "Default"];
   
   return %engineEffectData;
}

//Public
function EngineDatablock::GetEngineEffect(%this, %engineType, %factionName)
{
   %engineEffectData = %this.GetEngineEffectData(%engineType, %factionName);
   %engineEffect = getWord(%engineEffectData, 0);
   
   return %engineEffect;
}

//Public
function EngineDatablock::GetEngineEffectScale(%this, %engineType, %factionName)
{
   %engineEffectData = %this.GetEngineEffectData(%engineType, %factionName);
   %engineEffectScale = getWord(%engineEffectData, 1);
   
   return %engineEffectScale;
}

////////////////////////////////////////////////
// PROCEDURAL STATS  ///////////////////////////
////////////////////////////////////////////////
//These are the numbers for the basic military version. 

//Assumed Mass
//Pulled directly from HULL database
$ENGINEDATA["AssumedMass", $HULLTYPE_SMALL]       = $HULL_BASEMASS[$HULLTYPE_SMALL];
$ENGINEDATA["AssumedMass", $HULLTYPE_MEDIUM]      = $HULL_BASEMASS[$HULLTYPE_MEDIUM];
$ENGINEDATA["AssumedMass", $HULLTYPE_LARGE]       = $HULL_BASEMASS[$HULLTYPE_LARGE];
$ENGINEDATA["AssumedMass", $HULLTYPE_HUGE]        = $HULL_BASEMASS[$HULLTYPE_HUGE];
$ENGINEDATA["AssumedMass", $HULLTYPE_MOTHERSHIP]  = $HULL_BASEMASS[$HULLTYPE_MOTHERSHIP];
$ENGINEDATA["AssumedMass", $HULLTYPE_STATION]     = $HULL_BASEMASS[$HULLTYPE_STATION];

//Thrust force:  
//NOTE: this force is multiplied by the ships mass, this allows for easy comparision of acceleration.  is a number is 2x another, accel will be 2x as fast
$ENGINEDATA["ThrustForce", $HULLTYPE_SMALL]        = 800;
$ENGINEDATA["ThrustForce", $HULLTYPE_MEDIUM]       = 650;    
$ENGINEDATA["ThrustForce", $HULLTYPE_LARGE]        = 450;   
$ENGINEDATA["ThrustForce", $HULLTYPE_HUGE]         = 200;   
$ENGINEDATA["ThrustForce", $HULLTYPE_MOTHERSHIP]   = 50;      
$ENGINEDATA["ThrustForce", $HULLTYPE_STATION]      = 0;

//Turn Speed
$ENGINEDATA["TurnSpeed", $HULLTYPE_SMALL]          = 240;
$ENGINEDATA["TurnSpeed", $HULLTYPE_MEDIUM]         = 180;    
$ENGINEDATA["TurnSpeed", $HULLTYPE_LARGE]          = 60;   
$ENGINEDATA["TurnSpeed", $HULLTYPE_HUGE]           = 30;   
$ENGINEDATA["TurnSpeed", $HULLTYPE_MOTHERSHIP]     = 5;     
$ENGINEDATA["TurnSpeed", $HULLTYPE_STATION]        = 0;

//Max Speed
$ENGINEDATA["MaxSpeed", $HULLTYPE_SMALL]           = 350;
$ENGINEDATA["MaxSpeed", $HULLTYPE_MEDIUM]          = 325;    
$ENGINEDATA["MaxSpeed", $HULLTYPE_LARGE]           = 300;   
$ENGINEDATA["MaxSpeed", $HULLTYPE_HUGE]            = 275;   
$ENGINEDATA["MaxSpeed", $HULLTYPE_MOTHERSHIP]      = 20;     
$ENGINEDATA["MaxSpeed", $HULLTYPE_STATION]         = 0;

//Power consumption  
$ENGINEDATA["PowerConsumption", $HULLTYPE_SMALL]           = 0.333;  
$ENGINEDATA["PowerConsumption", $HULLTYPE_MEDIUM]          = 0.333;    
$ENGINEDATA["PowerConsumption", $HULLTYPE_LARGE]           = 0.333;   
$ENGINEDATA["PowerConsumption", $HULLTYPE_HUGE]            = 0.333;   
$ENGINEDATA["PowerConsumption", $HULLTYPE_MOTHERSHIP]      = 0; 
$ENGINEDATA["PowerConsumption", $HULLTYPE_STATION]         = 0;

//These should be even since civ stuff costs half.
$ENGINEDATA["ResourceCost", $HULLTYPE_SMALL]                = 2;  
$ENGINEDATA["ResourceCost", $HULLTYPE_MEDIUM]               = 10;    
$ENGINEDATA["ResourceCost", $HULLTYPE_LARGE]                = 30;   
$ENGINEDATA["ResourceCost", $HULLTYPE_HUGE]                 = 100;   
$ENGINEDATA["ResourceCost", $HULLTYPE_MOTHERSHIP]           = 0; 
$ENGINEDATA["ResourceCost", $HULLTYPE_STATION]              = 0;

function EngineDatablock::GetProceduralData(%this, %statID)
{
   %datum = $ENGINEDATA[%statID, %this.hullType];
   if ( %datum $= "" )
      echo("EngineDatablock::GetProceduralData WARNING: Trying to get invalid procedural Stat!" SPC %statID);
   
   return %datum;
}


////////////////////////
// Engine Mults ////////
////////////////////////
//This is how we keep technology consistent between categories. 

//Accel
$ENGINEMULTS["ThrustForce", "BASIC"]          = 1.000;
$ENGINEMULTS["ThrustForce", "CIV"]            = 0.750;
$ENGINEMULTS["ThrustForce", "THRUSTER"]       = 1.000;  
$ENGINEMULTS["ThrustForce", "INTERTIAL"]      = 1.500;  

$ENGINEMULTS["MaxSpeed", "BASIC"]             = 1.000;
$ENGINEMULTS["MaxSpeed", "CIV"]               = 0.750;
$ENGINEMULTS["MaxSpeed", "THRUSTER"]          = 1.500;
$ENGINEMULTS["MaxSpeed", "INTERTIAL"]         = 1.300;

$ENGINEMULTS["TurnSpeed", "BASIC"]            = 1.000;
$ENGINEMULTS["TurnSpeed", "CIV"]              = 0.750;
$ENGINEMULTS["TurnSpeed", "THRUSTER"]         = 0.850;
$ENGINEMULTS["TurnSpeed", "INTERTIAL"]        = 1.300;

$ENGINEMULTS["PowerConsumption", "BASIC"]     = 1.000;
$ENGINEMULTS["PowerConsumption", "CIV"]       = 0.500;  //civ is good for low power consumption
$ENGINEMULTS["PowerConsumption", "THRUSTER"]  = 1.500;
$ENGINEMULTS["PowerConsumption", "INTERTIAL"] = 2.000;

$ENGINEMULTS["ResourceCost", "BASIC"]         = 1.000;
$ENGINEMULTS["ResourceCost", "CIV"]           = 0.333;  //civ is good for low power consumption
$ENGINEMULTS["ResourceCost", "THRUSTER"]      = 3.000;
$ENGINEMULTS["ResourceCost", "INTERTIAL"]     = 5.000;


function EngineDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $ENGINEMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("EngineDatablock::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}

///////////////////////////////////////
//Procedural Stat /////////////////////
///////////////////////////////////////

function EngineDatablock::GetFinalStat(%this, %statID)
{
   %data = %this.GetProceduralData(%statID);
   %mult = %this.GetProceduralMult(%statID);
   
   %result = %data * %mult;  
   return %result;
}

function EngineDatablock::HandleProceduralStats(%this)
{
   %this.engineAssumedMass = %this.GetProceduralData("AssumedMass");  //Not using stat here, no need.        
      
   %this.engineThrustForce = %this.GetFinalStat("ThrustForce") * %this.engineAssumedMass;
   %this.engineTurnSpeed   = %this.GetFinalStat("TurnSpeed");   
   %this.engineMaxSpeed    = %this.GetFinalStat("MaxSpeed");   
   %this.powerConsumption  = %this.GetFinalStat("PowerConsumption") * %this.referenceReactor.maxReactorOutput;      

   %this.RUCost = mRound(%this.GetFinalStat("ResourceCost"));  //rounding just in case  
}

////////////////////////////////////////////////
// BaseClass ///////////////////////////////////
////////////////////////////////////////////////
datablock EngineDatablock(EngineBase : ComponentBase) 
{      
   componentType              = "Engine";
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   //Are we still using this?      
   engineEffectForceBase      = "30";  //This is the force that the gas comes out of the engine, looks neat, we need to make sure this keeps working. 
      
   engineSound                = "snd_loop_thrusterSmall";   //Only one sound, since they loop and eat a channel
   
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;
   
   brakeDamping        = 2.0;
   ambientDamping      = 0.15;   //damping when engines off/slowing down (prevents kiting)
   
   researchDatablock = "EngineResearch"; 
 
   //Effect SPC Scale (NOTE: flare effects get colorized to faction)
   engineEffectScaleBase = 1.0; //This multiplies all the different effect scales to keep them in line.
   engineEffects["Flare", "Default"]   = "MissileThruster 1.2"; 
   engineEffects["Flare", "Zombie"]    = "MissileThruster 1.2";
   engineEffects["Trail", "Default"]   = "bulletRings 1"; //Temp for testing
   engineEffects["Trail", "Zombie"]    = "ZombieThruster 1";   
   engineEffects["Cloaked", "Default"] = "CloakThruster 1";
   engineEffects["Damaged", "Default"] = "SmokeyThruster 3"; //is played in addition to flare and trail
   
   engineEffects["Jets", "Default"] = "LatThruster 1"; //Temp for testing
   
   purchaseTutorial = "PT_basicEngine";
};

////////////////////////////////////////////////
// Smalls //////////////////////////////////////
////////////////////////////////////////////////
datablock EngineDatablock(S_BasicEngine : EngineBase) 
{
   friendlyName = "Small Basic Engine";
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL; //used for procedural systmes.
   referenceReactor = "S_BasicReactor"; //used to determine power consumption
   
  
   engineEffectScaleBase      = "0.6";    
   engineEffects["Trail", "Default"]   = "TinyThruster 1"; 
         
   engineSound                = "snd_loop_thrusterTiny";       
      
   componentSize              = $SLOT_SMALL;     
      
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_engineStable";
     
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
         
   componentButtonColor        = "Basic";
   
   sizeTable[$SLOT_SMALL]  = "S_BasicEngine";
   sizeTable[$SLOT_MEDIUM] = "M_BasicEngine";
   sizeTable[$SLOT_LARGE]  = "L_BasicEngine";
   sizeTable[$SLOT_HUGE]   = "H_BasicEngine";
};

datablock EngineDatablock(S_CivEngine : S_BasicEngine) 
{
   friendlyName = "Small Budget Engine"; 
   
   purchaseTutorial = "PT_basicEngine_civ";     
  
   myType = "CIV";
   
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
          
   componentButtonColor        = "Civ";
   
   sizeTable[$SLOT_SMALL]  = "S_CivEngine";
   sizeTable[$SLOT_MEDIUM] = "M_CivEngine";
   sizeTable[$SLOT_LARGE]  = "L_CivEngine";
   sizeTable[$SLOT_HUGE]   = "H_CivEngine";
};


datablock EngineDatablock(S_ThrusterEngine : S_BasicEngine) 
{
   friendlyName = "Small Thruster Engine";   
   
   engineEffects["Trail", "Default"]   = "SmallThruster 1"; 
 
 
   myType = "THRUSTER";
    
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.333;
   strafe_thrust_mult  = 0.333;   
        
   componentButtonColor        = "Improved";   
   componentIconGraphic        = "shipconIcon_engine";   
   purchaseTutorial = "PT_thrusterEngine";
   
   sizeTable[$SLOT_SMALL]  = "S_ThrusterEngine";
   sizeTable[$SLOT_MEDIUM] = "M_ThrusterEngine";
   sizeTable[$SLOT_LARGE]  = "L_ThrusterEngine";
   sizeTable[$SLOT_HUGE]   = "H_ThrusterEngine";
};


datablock EngineDatablock(S_InertialEngine : S_BasicEngine) 
{ 
   friendlyName = "Small Inertial Engine";
   
   engineEffects["Trail", "Default"]   = "inertiaThruster 1";       
   
   myType = "INTERTIAL";
   
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 1.0;
   strafe_thrust_mult  = 1.0;
   //ambientDamping      = 1.0; 
        
   componentButtonColor        = "Advanced";
   
   componentIconGraphic        = "shipconIcon_engine_inert";
   
   purchaseTutorial = "PT_inertialEngine";
   
   engineEffects["Jets", "Default"] = "Lat_InertThruster 1"; 
   
   sizeTable[$SLOT_SMALL]  = "S_InertialEngine";
   sizeTable[$SLOT_MEDIUM] = "M_InertialEngine";
   sizeTable[$SLOT_LARGE]  = "L_InertialEngine";
   sizeTable[$SLOT_HUGE]   = "H_InertialEngine";
};

///////////////////////////////////////////////////
// Mediums ////////////////////////////////////////
///////////////////////////////////////////////////
datablock EngineDatablock(M_BasicEngine : EngineBase) 
{
   friendlyName = "Medium Basic Engine";   
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption
   
   engineEffectScaleBase      = "0.75";   
   engineEffects["Trail", "Default"]   = "TinyThruster 1"; 
  
   componentSize              = $SLOT_MEDIUM;     
    
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_engineStable";
      
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
   
   sizeTable[$SLOT_SMALL]  = "S_BasicEngine";
   sizeTable[$SLOT_MEDIUM] = "M_BasicEngine";
   sizeTable[$SLOT_LARGE]  = "L_BasicEngine";
   sizeTable[$SLOT_HUGE]   = "H_BasicEngine";
};


datablock EngineDatablock(M_CivEngine : M_BasicEngine) 
{
   friendlyName = "Medium Civilian Engine"; 
   
   purchaseTutorial = "PT_basicEngine_civ";   
      
   myType = "CIV";    

   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
  
   
   componentButtonColor        = "Civ";
   
   sizeTable[$SLOT_SMALL]  = "S_CivEngine";
   sizeTable[$SLOT_MEDIUM] = "M_CivEngine";
   sizeTable[$SLOT_LARGE]  = "L_CivEngine";
   sizeTable[$SLOT_HUGE]   = "H_CivEngine";
};


datablock EngineDatablock(M_ThrusterEngine : M_BasicEngine) 
{
   friendlyName = "Medium Thruster Engine";      
   
   engineEffects["Trail", "Default"]   = "SmallThruster 1"; 

   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.333;
   strafe_thrust_mult  = 0.333;   
   
   
   myType = "THRUSTER"; 
   
   componentButtonColor        = "Improved";
   
   componentIconGraphic        = "shipconIcon_engine";
   
   purchaseTutorial = "PT_thrusterEngine";
   
   sizeTable[$SLOT_SMALL]  = "S_ThrusterEngine";
   sizeTable[$SLOT_MEDIUM] = "M_ThrusterEngine";
   sizeTable[$SLOT_LARGE]  = "L_ThrusterEngine";
   sizeTable[$SLOT_HUGE]   = "H_ThrusterEngine";
};


datablock EngineDatablock(M_InertialEngine : M_BasicEngine) 
{
   friendlyName = "Medium Inertial Engine";   
   
   engineEffects["Trail", "Default"]   = "inertiaThruster 1";       
   
   myType = "INTERTIAL";

   forward_thrust_mult = 1.0;
   back_thrust_mult    = 1.0;
   strafe_thrust_mult  = 1.0;   
   //ambientDamping      = 1.0; 
   
   componentButtonColor        = "Advanced";
   
   componentIconGraphic        = "shipconIcon_engine_inert";
   
   purchaseTutorial = "PT_inertialEngine";
   
   engineEffects["Jets", "Default"] = "Lat_InertThruster 1"; 
   
   sizeTable[$SLOT_SMALL]  = "S_InertialEngine";
   sizeTable[$SLOT_MEDIUM] = "M_InertialEngine";
   sizeTable[$SLOT_LARGE]  = "L_InertialEngine";
   sizeTable[$SLOT_HUGE]   = "H_InertialEngine";
};
///////////////////////////////////////////////////
// Larges /////////////////////////////////////////
///////////////////////////////////////////////////
datablock EngineDatablock(L_BasicEngine : EngineBase) 
{
   friendlyName = "Large Basic Engine";   
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption
   
   engineAssumedMass          = $HULL_BASEMASS[$HULLTYPE_LARGE];   
    
   engineEffectScaleBase      = "0.85"; 
   engineEffects["Trail", "Default"]   = "TinyThruster 1"; 

   
   engineSound                = "snd_loop_thrusterLarge"; 
   
   componentSize              = $SLOT_LARGE;     
    
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_engineStable";
    
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
   ambientDamping      = 0.1;  //gliding engine 
   
   sizeTable[$SLOT_SMALL]  = "S_BasicEngine";
   sizeTable[$SLOT_MEDIUM] = "M_BasicEngine";
   sizeTable[$SLOT_LARGE]  = "L_BasicEngine";
   sizeTable[$SLOT_HUGE]   = "H_BasicEngine";
};


datablock EngineDatablock(L_CivEngine : L_BasicEngine) 
{
   friendlyName = "Large Civilian Engine"; 
   
   purchaseTutorial = "PT_basicEngine_civ";     
    
   myType = "CIV"; 

   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
  
   
   componentButtonColor        = "Civ";
   
   sizeTable[$SLOT_SMALL]  = "S_CivEngine";
   sizeTable[$SLOT_MEDIUM] = "M_CivEngine";
   sizeTable[$SLOT_LARGE]  = "L_CivEngine";
   sizeTable[$SLOT_HUGE]   = "H_CivEngine";
};


datablock EngineDatablock(L_ThrusterEngine : L_BasicEngine) 
{
   friendlyName = "Large Thruster Engine";  
   
   engineEffects["Trail", "Default"]   = "SmallThruster 1"; 
  
   myType = "THRUSTER";   
   
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.333;
   strafe_thrust_mult  = 0.333;   
   
   
   componentButtonColor        = "Improved";
   
   componentIconGraphic        = "shipconIcon_engine";
   
   purchaseTutorial = "PT_thrusterEngine";
   
   sizeTable[$SLOT_SMALL]  = "S_ThrusterEngine";
   sizeTable[$SLOT_MEDIUM] = "M_ThrusterEngine";
   sizeTable[$SLOT_LARGE]  = "L_ThrusterEngine";
   sizeTable[$SLOT_HUGE]   = "H_ThrusterEngine";
};


datablock EngineDatablock(L_InertialEngine : L_BasicEngine) 
{
   friendlyName = "Large Inertial Engine";  

   engineEffects["Trail", "Default"]   = "inertiaThruster 1";       

   myType = "INTERTIAL";  
   
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 1.0;
   strafe_thrust_mult  = 1.0;   
   //ambientDamping      = 1.0; 
   
   componentButtonColor        = "Advanced";
   
   componentIconGraphic        = "shipconIcon_engine_inert";
   
   purchaseTutorial = "PT_inertialEngine";
   
   engineEffects["Jets", "Default"] = "Lat_InertThruster 1"; 
   
   sizeTable[$SLOT_SMALL]  = "S_InertialEngine";
   sizeTable[$SLOT_MEDIUM] = "M_InertialEngine";
   sizeTable[$SLOT_LARGE]  = "L_InertialEngine";
   sizeTable[$SLOT_HUGE]   = "H_InertialEngine";
};

///////////////////////////////////////////////////
// Huges //////////////////////////////////////////
///////////////////////////////////////////////////
datablock EngineDatablock(H_BasicEngine : EngineBase) 
{
   friendlyName = "Huge Basic Engine";  
      
   
   engineEffectScaleBase      = "1.2"; 
   engineEffects["Trail", "Default"]   = "TinyThruster 1"; 

   
   engineSound                = "snd_loop_thrusterLarge";   
      
   componentSize              = $SLOT_HUGE;     
  
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_HUGE; //used for procedural systmes.
   referenceReactor = "H_BasicReactor"; //used to determine power consumption
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_engineStable";
     
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
   
   sizeTable[$SLOT_SMALL]  = "S_BasicEngine";
   sizeTable[$SLOT_MEDIUM] = "M_BasicEngine";
   sizeTable[$SLOT_LARGE]  = "L_BasicEngine";
   sizeTable[$SLOT_HUGE]   = "H_BasicEngine";
};


datablock EngineDatablock(H_CivEngine : H_BasicEngine) 
{
   friendlyName = "Huge Civilian Engine"; 
   
   purchaseTutorial = "PT_basicEngine_civ";  
   
   myType = "CIV";   

   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
     
   componentButtonColor        = "Civ";
   
   sizeTable[$SLOT_SMALL]  = "S_CivEngine";
   sizeTable[$SLOT_MEDIUM] = "M_CivEngine";
   sizeTable[$SLOT_LARGE]  = "L_CivEngine";
   sizeTable[$SLOT_HUGE]   = "H_CivEngine";
};


datablock EngineDatablock(H_ThrusterEngine : H_BasicEngine) 
{
   friendlyName = "Huge Thruster Engine";  
    
   engineEffects["Trail", "Default"]   = "SmallThruster 1"; 

   myType = "THRUSTER";  
   
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.333;
   strafe_thrust_mult  = 0.333;   
      
   componentButtonColor        = "Improved";
   
   componentIconGraphic        = "shipconIcon_engine";
   
   purchaseTutorial = "PT_thrusterEngine";
   
   sizeTable[$SLOT_SMALL]  = "S_ThrusterEngine";
   sizeTable[$SLOT_MEDIUM] = "M_ThrusterEngine";
   sizeTable[$SLOT_LARGE]  = "L_ThrusterEngine";
   sizeTable[$SLOT_HUGE]   = "H_ThrusterEngine";
};


datablock EngineDatablock(H_InertialEngine : H_BasicEngine) 
{
   friendlyName = "Huge Inertial Engine";  
   
   engineEffects["Trail", "Default"]   = "inertiaThruster 1";       
  
   myType = "INTERTIAL";
   
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 1.0;
   strafe_thrust_mult  = 1.0;   
   //ambientDamping      = 1.0; 
   
   componentButtonColor        = "Advanced";
   
   componentIconGraphic        = "shipconIcon_engine_inert";
   
   purchaseTutorial = "PT_inertialEngine";
   
   engineEffects["Jets", "Default"] = "Lat_InertThruster 1"; 
   
   sizeTable[$SLOT_SMALL]  = "S_InertialEngine";
   sizeTable[$SLOT_MEDIUM] = "M_InertialEngine";
   sizeTable[$SLOT_LARGE]  = "L_InertialEngine";
   sizeTable[$SLOT_HUGE]   = "H_InertialEngine";
};

////////////////////////////////////////////////
// Specials ////////////////////////////////////
////////////////////////////////////////////////

datablock EngineDatablock(Mothership_BasicEngine : EngineBase) 
{
   friendlyName = "Mothership Engine";  
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MOTHERSHIP; //used for procedural systmes.
   referenceReactor = "Mothership_BasicReactor"; //used to determine power consumption

   engineEffectScaleBase      = "2";  
   engineEffects["Trail", "Default"]   = "SmallThruster 1"; 

   engineSound                = "snd_loop_thrusterLarge";       
   
   componentSize              = $SLOT_MOTHERSHIP;       
      
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_engineStable";
      
   forward_thrust_mult = 1.0;
   back_thrust_mult    = 0.667;
   strafe_thrust_mult  = 0.667;   
   ambientDamping      = 0.1;  //gliding engine 
};

datablock EngineDatablock(Station_CivEngine : EngineBase) 
{
   friendlyName = "Station Dampener Engine";     
     
   engineEffects["Trail", "Default"]   = "bulletRings 1"; 
      
   componentSize              = $SLOT_MOTHERSHIP;       
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_STATION; //used for procedural systmes.
   referenceReactor = "Station_CivReactor"; //used to determine power consumption
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_engine";   
   
   forward_thrust_mult = 0;
   back_thrust_mult    = 0;
   strafe_thrust_mult  = 0;   
   ambientDamping      = 1000;  
};

