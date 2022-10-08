//reactor Datablocks

//if structure is destroyed and reactor surtvives, it should be part of the debris (and highly explosive)

function ReactorDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "ReactorBase" )
      return;
            
   %this.HandleProceduralStats();
   
   Parent::onAdd(%this);            
}


////////////////////////////////////////////////
// PROCEDURAL DATA  ////////////////////////////
////////////////////////////////////////////////
//These are the numbers for the basic military version. 

//Max output.
//Note: all users of the reactor pull power based on percentage of reference reactor, this means that all we have to do is balance reactors vs one anoter
//to keep weapons one size down still having an appriciable reactor draw, we multiply by a reasonable number like 5 between levels
$REACTORDATA["maxReactorOutput", $HULLTYPE_SMALL]        = 10;
$REACTORDATA["maxReactorOutput", $HULLTYPE_MEDIUM]       = 15;
$REACTORDATA["maxReactorOutput", $HULLTYPE_LARGE]        = 23;
$REACTORDATA["maxReactorOutput", $HULLTYPE_HUGE]         = 37;
$REACTORDATA["maxReactorOutput", $HULLTYPE_MOTHERSHIP]   = 500;
$REACTORDATA["maxReactorOutput", $HULLTYPE_STATION]      = 500;

//This is multiplied by maxReactor Output. 
//Larget vessels can afford to stand and fight due to their massive capacitors.
$REACTORDATA["capacitorCapacity", $HULLTYPE_SMALL]       = 6;
$REACTORDATA["capacitorCapacity", $HULLTYPE_MEDIUM]      = 10;
$REACTORDATA["capacitorCapacity", $HULLTYPE_LARGE]       = 15;
$REACTORDATA["capacitorCapacity", $HULLTYPE_HUGE]        = 30;
$REACTORDATA["capacitorCapacity", $HULLTYPE_MOTHERSHIP]  = 60;
$REACTORDATA["capacitorCapacity", $HULLTYPE_STATION]     = 60;
 
$REACTORDATA["ResourceCost", $HULLTYPE_SMALL]            = 2;
$REACTORDATA["ResourceCost", $HULLTYPE_MEDIUM]           = 8;
$REACTORDATA["ResourceCost", $HULLTYPE_LARGE]            = 25;
$REACTORDATA["ResourceCost", $HULLTYPE_HUGE]             = 100;
$REACTORDATA["ResourceCost", $HULLTYPE_MOTHERSHIP]       = 0;
$REACTORDATA["ResourceCost", $HULLTYPE_STATION]          = 0;
     
   
function ReactorDatablock::GetProceduralData(%this, %statID)
{
   %datum = $REACTORDATA[%statID, %this.hullType];
   if ( %datum $= "" )
      echo("$REACTORDATA::GetProceduralData WARNING: Trying to get invalid procedural Data!" SPC %statID);
   
   return %datum;
}

////////////////////////
// PROCEDURAL Mults ////
////////////////////////
//This is how we keep technology consistent between categories. 

$REACTORMULTS["maxReactorOutput", "BASIC"]          = 1.000;
$REACTORMULTS["maxReactorOutput", "CIV"]            = 0.850;
$REACTORMULTS["maxReactorOutput", "HIGHCAP"]        = 0.950;  
$REACTORMULTS["maxReactorOutput", "OVERCHARGE"]     = 1.500;  

$REACTORMULTS["capacitorCapacity", "BASIC"]         = 1.000;
$REACTORMULTS["capacitorCapacity", "CIV"]           = 1.000;
$REACTORMULTS["capacitorCapacity", "HIGHCAP"]       = 2.000;  
$REACTORMULTS["capacitorCapacity", "OVERCHARGE"]    = 0.500;  

$REACTORMULTS["ResourceCost", "BASIC"]              = 1.000;
$REACTORMULTS["ResourceCost", "CIV"]                = 0.500;  
$REACTORMULTS["ResourceCost", "HIGHCAP"]            = 2.500;
$REACTORMULTS["ResourceCost", "OVERCHARGE"]         = 4.000;


function ReactorDatablock::GetProceduralMult(%this, %statID)
{
   %typeID = %this.myType;
   
   %datum = $REACTORMULTS[%statID, %typeID];
   if ( %datum $= "" )
      echo("ReactorDatablock::GetProceduralMult WARNING: Trying to get invalid procedural Mult!" SPC %statID SPC %typeID);
   
   return %datum;
}


///////////////////////////////////////
//Procedural Stat /////////////////////
///////////////////////////////////////

function ReactorDatablock::GetFinalStat(%this, %statID)
{
   %data = %this.GetProceduralData(%statID);
   %mult = %this.GetProceduralMult(%statID);
   
   %result = %data * %mult;  
   return %result;
}



function ReactorDatablock::HandleProceduralStats(%this)
{     
   %this.maxReactorOutput    = %this.GetFinalStat("maxReactorOutput");   
   %this.capacitorCapacity   = %this.GetFinalStat("capacitorCapacity") * %this.maxReactorOutput; 
   
   %this.RUCost = mRound(%this.GetFinalStat("ResourceCost"));  //rounding just in case  
}



////////////////////////////////////////////////
// BASE CLASS  //////////////////////////////////
////////////////////////////////////////////////
datablock ReactorDatablock(ReactorBase : ComponentBase) 
{       

   componentType              = "Reactor";
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 0;
          
   reactorCriticalDatablock   = "ReactorCritical";  //reactor is going to blow in reactorCriticalTime milliseconds   
   reactorCriticalScale       = "0.5";
   reactorCriticalTime        = "2000";   //milliseconds.  this is when the explosion causes the damage
   reactorCriticalSound       = "snd_reactorCritical";  //need a looping sound for this. 
   
   researchDatablock = "ReactorResearch";
   
   componentButtonColor        = "Basic";
   
   purchaseTutorial = "PT_basicReactor"; 
};

////////////////////////////////////////
// Smalls //////////////////////////////
////////////////////////////////////////
datablock ReactorDatablock(S_BasicReactor : ReactorBase) 
{
   friendlyName = "Small Basic Reactor";    
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_SMALL;
 
   componentSize              = $SLOT_SMALL;   
    
   reactorCoreExplosionScale  = "2";
   
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_reactor";
  
   sizeTable[$SLOT_SMALL]  = "S_BasicReactor";
   sizeTable[$SLOT_MEDIUM] = "M_BasicReactor";
   sizeTable[$SLOT_LARGE]  = "L_BasicReactor";
   sizeTable[$SLOT_HUGE]   = "H_BasicReactor"; 
};


datablock ReactorDatablock(S_CivReactor : S_BasicReactor) 
{
   friendlyName = "Small Surplus Reactor"; 
   
   purchaseTutorial = "PT_basicReactor_civ";       
   
   myType = "CIV"; //used for procedural systmes.
   
   sizeTable[$SLOT_SMALL]  = "S_CivReactor";
   sizeTable[$SLOT_MEDIUM] = "M_CivReactor";
   sizeTable[$SLOT_LARGE]  = "L_CivReactor";
   sizeTable[$SLOT_HUGE]   = "H_CivReactor"; 
   
   componentButtonColor        = "Civ";
};


datablock ReactorDatablock(S_HighCapacityReactor : S_BasicReactor) 
{
   friendlyName = "Small High Capactiy Reactor";    
   
   componentButtonColor        = "Improved";
   
   myType = "HIGHCAP"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_reactorHuge";
   
   purchaseTutorial = "PT_highCapReactor"; 
   
   sizeTable[$SLOT_SMALL]  = "S_HighCapacityReactor";
   sizeTable[$SLOT_MEDIUM] = "M_HighCapacityReactor";
   sizeTable[$SLOT_LARGE]  = "L_HighCapacityReactor";
   sizeTable[$SLOT_HUGE]   = "H_HighCapacityReactor"; 
};


datablock ReactorDatablock(S_OverchargedReactor : S_BasicReactor) 
{
   friendlyName = "Small Over Charge Reactor";    
   
   componentButtonColor        = "Advanced";
   
   myType = "OVERCHARGE"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_reactorOvercharge";
   
   purchaseTutorial = "PT_overChargeReactor"; 
   
   sizeTable[$SLOT_SMALL]  = "S_OverchargedReactor";
   sizeTable[$SLOT_MEDIUM] = "M_OverchargedReactor";
   sizeTable[$SLOT_LARGE]  = "L_OverchargedReactor";
   sizeTable[$SLOT_HUGE]   = "H_OverchargedReactor"; 
};


////////////////////////////////////////
// Mediums /////////////////////////////
////////////////////////////////////////
datablock ReactorDatablock(M_BasicReactor : ReactorBase) 
{
   friendlyName = "Medium Basic Reactor";    
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM;
   
   componentSize              = $SLOT_MEDIUM;   
   
   reactorCriticalScale       = "0.66";   
 
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_reactor";
   
   sizeTable[$SLOT_SMALL]  = "S_BasicReactor";
   sizeTable[$SLOT_MEDIUM] = "M_BasicReactor";
   sizeTable[$SLOT_LARGE]  = "L_BasicReactor";
   sizeTable[$SLOT_HUGE]   = "H_BasicReactor"; 

};

datablock ReactorDatablock(M_CivReactor : M_BasicReactor) 
{
   friendlyName = "Medium Civilian Reactor";
   
   purchaseTutorial = "PT_basicReactor_civ";     
   
   myType = "CIV"; //used for procedural systmes.
   
   sizeTable[$SLOT_SMALL]  = "S_CivReactor";
   sizeTable[$SLOT_MEDIUM] = "M_CivReactor";
   sizeTable[$SLOT_LARGE]  = "L_CivReactor";
   sizeTable[$SLOT_HUGE]   = "H_CivReactor"; 
   
   componentButtonColor        = "Civ";
};


datablock ReactorDatablock(M_HighCapacityReactor : M_BasicReactor) 
{
   friendlyName = "Medium High Capacity Reactor";   
   
   componentButtonColor        = "Improved";
   
   myType = "HIGHCAP"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_reactorHuge";
   
   purchaseTutorial = "PT_highCapReactor"; 
   
   sizeTable[$SLOT_SMALL]  = "S_HighCapacityReactor";
   sizeTable[$SLOT_MEDIUM] = "M_HighCapacityReactor";
   sizeTable[$SLOT_LARGE]  = "L_HighCapacityReactor";
   sizeTable[$SLOT_HUGE]   = "H_HighCapacityReactor"; 
};


datablock ReactorDatablock(M_OverchargedReactor : M_BasicReactor) 
{
   friendlyName = "Medium Over Charge Reactor";   
   
   componentButtonColor        = "Advanced";
   
   myType = "OVERCHARGE"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_reactorOvercharge";
   
   purchaseTutorial = "PT_overChargeReactor"; 
   
   sizeTable[$SLOT_SMALL]  = "S_OverchargedReactor";
   sizeTable[$SLOT_MEDIUM] = "M_OverchargedReactor";
   sizeTable[$SLOT_LARGE]  = "L_OverchargedReactor";
   sizeTable[$SLOT_HUGE]   = "H_OverchargedReactor"; 
};


///////////////////////////////////
// Larges /////////////////////////
///////////////////////////////////
datablock ReactorDatablock(L_BasicReactor : ReactorBase) 
{
   friendlyName = "Large Basic Reactor";   
   
   myType = "BASIC"; //used for procedural systmes.
   
   componentSize              = $SLOT_LARGE;  
   hullType = $HULLTYPE_LARGE; 
  
   reactorCriticalScale       = "0.8";    
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_reactor";
      
   sizeTable[$SLOT_SMALL]  = "S_BasicReactor";
   sizeTable[$SLOT_MEDIUM] = "M_BasicReactor";
   sizeTable[$SLOT_LARGE]  = "L_BasicReactor";
   sizeTable[$SLOT_HUGE]   = "H_BasicReactor"; 
};


datablock ReactorDatablock(L_CivReactor : L_BasicReactor) 
{
   friendlyName = "Large Civilian Reactor";
   
   purchaseTutorial = "PT_basicReactor_civ";       
 
   myType = "CIV"; //used for procedural systmes.
   
   sizeTable[$SLOT_SMALL]  = "S_CivReactor";
   sizeTable[$SLOT_MEDIUM] = "M_CivReactor";
   sizeTable[$SLOT_LARGE]  = "L_CivReactor";
   sizeTable[$SLOT_HUGE]   = "H_CivReactor"; 
   
   componentButtonColor        = "Civ";
};


datablock ReactorDatablock(L_HighCapacityReactor : L_BasicReactor) 
{
   friendlyName = "Large High Capacity Reactor";  
        
   componentButtonColor        = "Improved";
   
   myType = "HIGHCAP"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_reactorHuge";
   
   purchaseTutorial = "PT_highCapReactor"; 
   
   sizeTable[$SLOT_SMALL]  = "S_HighCapacityReactor";
   sizeTable[$SLOT_MEDIUM] = "M_HighCapacityReactor";
   sizeTable[$SLOT_LARGE]  = "L_HighCapacityReactor";
   sizeTable[$SLOT_HUGE]   = "H_HighCapacityReactor"; 
};


datablock ReactorDatablock(L_OverchargedReactor : L_BasicReactor) 
{
   friendlyName = "Large Over Charge Reactor";  
   
   componentButtonColor        = "Advanced";
   
   myType = "OVERCHARGE"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_reactorOvercharge";
      
   purchaseTutorial = "PT_overChargeReactor"; 
   
   sizeTable[$SLOT_SMALL]  = "S_OverchargedReactor";
   sizeTable[$SLOT_MEDIUM] = "M_OverchargedReactor";
   sizeTable[$SLOT_LARGE]  = "L_OverchargedReactor";
   sizeTable[$SLOT_HUGE]   = "H_OverchargedReactor"; 
};


///////////////////////////////////
// Huges //////////////////////////
///////////////////////////////////

datablock ReactorDatablock(H_BasicReactor : ReactorBase) 
{
   friendlyName = "Huge Basic Reactor";  
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_HUGE;
   
   componentSize              = $SLOT_HUGE;   
    
   reactorCriticalScale       = "1";  
      
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_reactor";

   sizeTable[$SLOT_SMALL]  = "S_BasicReactor";
   sizeTable[$SLOT_MEDIUM] = "M_BasicReactor";
   sizeTable[$SLOT_LARGE]  = "L_BasicReactor";
   sizeTable[$SLOT_HUGE]   = "H_BasicReactor"; 
};


datablock ReactorDatablock(H_CivReactor : H_BasicReactor) 
{
   friendlyName = "Huge Civilian Reactor";  
   
   purchaseTutorial = "PT_basicReactor_civ";  
      
   myType = "CIV"; //used for procedural systmes.
   
   sizeTable[$SLOT_SMALL]  = "S_CivReactor";
   sizeTable[$SLOT_MEDIUM] = "M_CivReactor";
   sizeTable[$SLOT_LARGE]  = "L_CivReactor";
   sizeTable[$SLOT_HUGE]   = "H_CivReactor"; 
   
   componentButtonColor        = "Civ";
};


datablock ReactorDatablock(H_HighCapacityReactor : H_BasicReactor) 
{
   friendlyName = "Huge High Capactiy Reactor";  
   
   componentButtonColor        = "Improved";
   
   myType = "HIGHCAP"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_reactorHuge";
   
   purchaseTutorial = "PT_highCapReactor"; 
   
   sizeTable[$SLOT_SMALL]  = "S_HighCapacityReactor";
   sizeTable[$SLOT_MEDIUM] = "M_HighCapacityReactor";
   sizeTable[$SLOT_LARGE]  = "L_HighCapacityReactor";
   sizeTable[$SLOT_HUGE]   = "H_HighCapacityReactor"; 
};


datablock ReactorDatablock(H_OverchargedReactor : H_BasicReactor) 
{
   friendlyName = "Huge Over Charge Reactor";  
      
   componentButtonColor        = "Advanced";
   
   myType = "OVERCHARGE"; //used for procedural systmes.
   
   componentIconGraphic        = "shipconIcon_reactorOvercharge";
   
   purchaseTutorial = "PT_overChargeReactor"; 
   
   sizeTable[$SLOT_SMALL]  = "S_OverchargedReactor";
   sizeTable[$SLOT_MEDIUM] = "M_OverchargedReactor";
   sizeTable[$SLOT_LARGE]  = "L_OverchargedReactor";
   sizeTable[$SLOT_HUGE]   = "H_OverchargedReactor"; 
};


/////////////////////////////////////////////////
// Specials /////////////////////////////////////
/////////////////////////////////////////////////
datablock ReactorDatablock(Mothership_BasicReactor : ReactorBase) 
{
   friendlyName = "Mothership Reactor";  
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_MOTHERSHIP;
   
   componentSize              = $SLOT_MOTHERSHIP;   
   
   reactorCriticalScale       = "1.5";     
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_reactor";
   

};



datablock ReactorDatablock(Station_CivReactor : ReactorBase) 
{
   friendlyName = "Station Reactor";  
   
   myType = "BASIC"; //used for procedural systmes.
   hullType = $HULLTYPE_STATION;
   
   componentSize              = $SLOT_MOTHERSHIP;   
      
   reactorCriticalScale       = "1.5";    
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_reactor";
   

};

datablock ReactorDatablock(Station_AdvancedReactor : ReactorBase) 
{
   friendlyName = "Station Reactor";  
   
   myType = "OVERCHARGE"; //used for procedural systmes.
   hullType = $HULLTYPE_STATION;
   
   componentSize              = $SLOT_MOTHERSHIP;   
      
   reactorCriticalScale       = "1.5";    
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_reactor";
   

};



