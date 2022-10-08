
///////////////////////////////////////////////////////////////////////////////////////////////////////
// Mothership Hidden Instances ///////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

//Automatically added to each star. 
new ScriptGroup(MothershipHideInstance : InstanceBase)
{
   instanceClass = "MothershipHideInstanceClass";
   friendlyName = "MOTHERSHIP HIDEOUT";
      
   buttonImage = "objectiveMarker_homeImageMap";
   systemScreenObject = "systemScreenObject_mothership";
   buttonBlend = "0.4 1 0.4 1";
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
       instanceObjectWeightedList = "AmbientAsteroids";
       offset = 0;  
       creationChance = 1;  
       objectCount = "10 60";
   };  
   
   
   //Mothership will be nestled in here. 
};
