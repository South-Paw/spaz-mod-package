
///////////////////////////////////////////////////////////////////////////////////////////////////////
// Security Instances /////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

//Provides protection for current star
new ScriptGroup(SecurityInstance : InstanceBase)
{
   instanceClass = "SecurityInstanceClass";
   friendlyName = "UTA SECURITY BASE";
   
   buttonImage = "objectiveMarker_terranImageMap";
   systemScreenObject = "systemScreenObject_security";
   buttonBlend = "1 0.5 0.5 1";
   
   faction = "StarFaction";
   instanceWaringTag = "security";
      
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "SecurityBase";
      offset = 0;  
      creationChance = 1;      
      objectCount = 1;        
      
      //reinforcement ships controlled by instance. 
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AmbientAsteroids";
         offset = 0;  
         creationChance = 1;
         objectCount = "15 20";
      };       
   };   
};
