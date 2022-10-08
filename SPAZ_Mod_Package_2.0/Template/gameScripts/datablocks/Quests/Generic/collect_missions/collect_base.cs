////////////////////////////////////////////////////////////////////////////////
//COLLECT BASE
////////////////////////////////////////////////////////////////////////////////
   
function MissionPickup_Basic_Fetched(%object, %collector)
{
   %parentInstanceObject = %object.parentInstanceObject;   
   %parentInstance = %parentInstanceObject.getParentInstance();   
   %parentInstance.OnInstanceSubObjectPickup(%parentInstanceObject, %object, %collector);
}

new ScriptGroup(MO_CollectProp : MO_Pickups)
{   
   offset = "3000 4000";                                  
   objectCount = "1 1";
   //onInitializedFunc[0] = "AddToHealthCallbackSet pickupSet";
   refObjectName = "REF_beacon";   
           
   objectFuncs["Spawn", 0] = "addToTrackingSet pickupSet";  
           
   objectFuncs["Pickup", 0] = "evalTrackingSet pickupSet collected 1 StartWaveName questComplete"; 
};

new ScriptGroup(MO_CollectProp_Scatter : MO_CollectProp)
{                                
   instanceObjectWeightedList = "Pickups_Generic_scatter 10";
};

new ScriptGroup(MO_CollectGuard : MO_Ships) 
{   
   offset = "0";  
   objectCount = "1 1";
   factionOverride = "Terran"; 
   refObjectName = "";                                              
};  