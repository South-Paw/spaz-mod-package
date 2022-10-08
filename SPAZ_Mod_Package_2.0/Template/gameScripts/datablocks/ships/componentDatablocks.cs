
////////////////////////////////////////////////////////////////////////////////
//globals to control button sizes and types
////////////////////////////////////////////////////////////////////////////////

$compButtonSize_S = "64 64";
$compButtonType_S = "shipconIcon_sizeSmallImageMap";

$compButtonSize_M = "64 64";
$compButtonType_M = "shipconIcon_sizeMedImageMap";

$compButtonSize_L = "64 64";
$compButtonType_L = "shipconIcon_sizeLargeImageMap";

$compButtonSize_H = "64 64";
$compButtonType_H = "shipconIcon_sizeHugeImageMap";

//Component Datablocks
//These will need to inherit from some base class for sanity sake. 

/*
enum eComponentSize
{
    SMALL,
    MEDIUM,
    LARGE,
    HUGE,
    MOTHERSHIP,

   COUNT
};
*/


function ComponentDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "ComponentBase" )
      return;
            
   %this.addComponentToDatabase();      
}

function ComponentDatablock::addComponentToDatabase(%this)
{ 
   %componentDatabase = CD_GetComponentDatabase(%this.componentType);
   %componentDatabase.add(%this);   
}

//This exists so i can find ALL registered components. 
$ComponentDatabase_Types = new SimSet() {};

//Component Database
function CD_CreateComponentDatabaseType(%type)
{
   %componentTypeObject = new ScriptObject()
   {
      componentType = %type;
   };
   $ComponentDatabase_Types.add(%componentTypeObject);
   
   %componentDatabase = new SimSet() {};  
   $ComponentDatabase[%type] = %componentDatabase;
   
   return %componentDatabase;
}

function CD_GetComponentDatabase(%type)
{
   %componentDatabase = $ComponentDatabase[%type];
   if ( %componentDatabase $= "" )
      %componentDatabase = CD_CreateComponentDatabaseType(%type);
   return %componentDatabase;
}

function CD_ListAllComponents()
{
   for (%i = 0; %i < $ComponentDatabase_Types.getCount(); %i ++)
   {
      %componentTypeObject = $ComponentDatabase_Types.getObject(%i);
      %componentType = %componentTypeObject.componentType;
      CD_ListComponentsByType(%componentType);      
   }   
}

function CD_ListComponentsByType(%type)
{
   %componentDatabase = CD_GetComponentDatabase(%type);
   echo("Component:" SPC %type);
   for (%i = 0; %i < %componentDatabase.getCount(); %i++)
   {
      %componentDatablock = %componentDatabase.getObject(%i);
      echo("    " SPC %componentDatablock.getName());      
   }
}


function ComponentDatablock::GetRequiredResearchLevel(%this)
{
   %level = %this.RequiredResearchLevel;
   if ( %level $= "" )
      return 0;
      
   return %level;    
}


$ButtonColors["Civ"]      = "green";
$ButtonColors["Basic"]    = "blue";
$ButtonColors["Improved"] = "yellow";
$ButtonColors["Advanced"] = "red";
$ButtonColors["Booster"]  = "purple";

function ComponentDatablock::GetComponentButtonColor(%this)
{
   %color = $ButtonColors[%this.componentButtonColor];
   if ( %color $= "" )
      %color = "grey";  //something aint working color
   
   return %color;
}

//Wrapper for friendly name so can access Purchase Tutorial
function ComponentDatablock::GetFriendlyName(%this)
{
   %currentName = %this.friendlyName;
   %purchaseTutorial = %this.purchaseTutorial;
   if ( !isObject(%purchaseTutorial) )
      return %currentName;
   
   %realName = %purchaseTutorial.title;
   //Now need to prefix with size.
   //if ( %this.isMemberOfClass("HullDatablock") )
   //   return %realName;
      
   if ( %this.componentType !$= "External" && %this.componentType !$= "Turret" )
      return %realName;
   
   if ( %this.componentSize == $SLOT_SMALL )
      return "SMALL" SPC %realName;
   
   if ( %this.componentSize == $SLOT_MEDIUM )
      return "MEDIUM" SPC %realName;
   
   if ( %this.componentSize == $SLOT_LARGE )
      return "LARGE" SPC %realName;
   
   if ( %this.componentSize == $SLOT_HUGE )
      return "HUGE" SPC %realName;
   
   return %currentName; //dont care about names for mothership or station stuff
}


//NOTE: WE CANNOT INHERIT CODE VARIABLES ACROSS CLASSES!!!!
//This inheritance is ONLY here for dynamic fields!!!
//BEWARE
datablock ComponentDatablock(ComponentBase)
{
   //All Components need these defined
   componentType              = "INVALID";   //Types are: "Engine", ProjectileCannon, MissileLauncher, BeamEmitter and UniversalExternalLink 
   maxComponentHealth         = 1;
   componentMass              = 0;   
   componentSize              = $SLOT_SMALL;      
   
   powerConsumption           = 1;   //1MJ/second = 1 MW
   
   //TODO (move to code_
   //componentButtonBitmap       = "~/gui/buttons/generic_button/generic_button";
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentButtonColor        = "Basic";
   componentIconGraphic        = "shipconIcon_NA";
   componentButtonBackground   = $compButtonColor_Grey;
   
   purchaseTutorial            = "";   
   
   RUCost                      = 1;  
  

                                    
                    
   ShouldIncludeTech = false; //research manager will set to true where needed. 
   ShouldInitialUnlock = false;   //research manager will set to true where needed.
  
   friendlyName = "NOT DEFINED!!";
};




