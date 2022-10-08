///////////////////////////////////////////////////////////////////////////////////////////////////////
// Science Instances /////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ScienceInstance : InstanceBase)
{
   instanceClass = "ScienceInstanceClass";
   friendlyName = "SCIENCE STATION";
      
   buttonImage = "objectiveMarker_scienceImageMap";
   systemScreenObject = "systemScreenObject_science";
   buttonBlend = "0.4 1 0.4 1";
   
   faction = "Civ";
   instanceWaringTag = "science";
   
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "ScienceBase";
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

