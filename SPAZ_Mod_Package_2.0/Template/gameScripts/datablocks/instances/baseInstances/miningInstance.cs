
///////////////////////////////////////////////////////////////////////////////////////////////////////
// Mining Instances ///////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(MiningInstance : InstanceBase)
{
   instanceClass = "MiningInstanceClass";
   friendlyName = "MINING STATION";
   
   buttonImage = "objectiveMarker_mineImageMap";
   systemScreenObject = "systemScreenObject_mining";
   buttonBlend = "0.4 1 0.4 1";
      
   faction = "Civ";
   instanceWaringTag = "mining";
   
   //Each of these script Objects will be InstanceObject Containers
   //this will work as recursivley as desired. 
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "MiningBase";
      offset = 0;  
      creationChance = 1;      
      objectCount = 1;
      
            
      new ScriptGroup() 
      {
         instanceObjectWeightedList = "AsteroidMother";
         offset = "600 800";  
         creationChance = 1;       
         objectCount = 1;  
          
         //This is the asteroid breakage seen when the area respawns
         new ScriptGroup() 
         {                                      //example showing weighted list usage
             instanceObjectWeightedList = "AsteroidBreakage 10 AsteroidBreakage 10";
             offset = 0;  
             creationChance = 1;
             objectCount = "5 10";
         };
      };           
   };   
};

