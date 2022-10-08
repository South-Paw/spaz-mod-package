
///////////////////////////////////////////////////////////////////////////////////////////////////////
// Colony Instances /////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ColonyInstance : InstanceBase)
{
   instanceClass = "ColonyInstanceClass";
   friendlyName = "COLONY STATION";
      
   buttonImage = "objectiveMarker_colonyImageMap";
   systemScreenObject = "systemScreenObject_colony";
   buttonBlend = "0.4 1 0.4 1";
   
   faction = "Civ";
   instanceWaringTag = "colony";
   
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "ColonyBase";
      offset = 0;  
      creationChance = 1;      
      objectCount = 1;      
            
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AmbientAsteroids";
         offset = 0;  
         creationChance = 1;
         objectCount = "15 20";
      };        
   };   
};
