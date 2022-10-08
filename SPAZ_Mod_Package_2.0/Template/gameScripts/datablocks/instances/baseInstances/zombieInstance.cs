
///////////////////////////////////////////////////////////////////////////////////////////////////////
// Zombie Instances /////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ZombieInstance : InstanceBase)
{
   instanceClass = "ZombieInstanceClass";
   friendlyName = "ZOMBIE NEST";
   
   faction = "Zombie";
   
   buttonImage = "objectiveMarker_emptyImageMap"; //missions now overrite this
   systemScreenObject = "systemScreenObject_infected";
   buttonBlend = "1 0.3 1 1";
      
   //will double normal infection spawn rates that occur in all instances
   //the zombie base will be handled by a mission. 
   new ScriptGroup() 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
   };        
      
};
