
///////////////////////////////////////////////////////////////////////////////////////////////////////
// WarpGate Instances /////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

//Automatically added as stars are linked. 
new ScriptGroup(WarpGateInstance : InstanceBase)
{
   instanceClass = "WarpGateInstanceClass";
   friendlyName = "UTA WARP GATE BLOCKADE";
   
   buttonImage = "objectiveMarker_warpgateImageMap";
   systemScreenObject = "systemScreenObject_warpgate";
   buttonBlend = "0.4 1 1 1";
   
   buttonImage_Blocked = "objectiveMarker_warpgateBlockedImageMap";
   buttonBlend_Blocked = "1 0.5 0.5 1";
   
   faction = "InstanceDefined";
   
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "WarpGate";  //hope there is not a name collision on this. 
      offset = 0;  
      creationChance = 1;      
      objectCount = 1;  
      
      offset = "3000";  
      refObjectName = "REF_beacon";       
      
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AmbientAsteroids";
         offset = 0;  
         creationChance = 1;
         objectCount = "15 20";
      };  
   };
};

