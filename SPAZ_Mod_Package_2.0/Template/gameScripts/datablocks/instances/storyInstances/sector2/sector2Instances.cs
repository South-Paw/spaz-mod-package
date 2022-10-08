/////////////////////////////////////////////////
// S2 Root Instances ////////////////////////////
/////////////////////////////////////////////////

new ScriptGroup(SI_S2_Root_MothershipHide : MothershipHideInstance)
{   
   instanceSubClass = "SI_S2_Root_MothershipHideClass"; 
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
       instanceObjectWeightedList = "AmbientAsteroids";
       offset = 0;  
       creationChance = 1;  
       objectCount = "10 60";
   };  
};

new ScriptGroup(SI_S2_Root_Security : SecurityInstance)
{   
   instanceSubClass = "SI_S2_Root_SecurityClass";    
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

new ScriptGroup(SI_S2_Root_Science : ScienceInstance)
{   
   instanceSubClass = "SI_S2_Root_ScienceClass";    
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


new ScriptGroup(SI_S2_Root_Graveyard : InstanceBase)
{   
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "SI_S2_Root_GraveyardClass";
   
   friendlyName = "AFTERMATH";
   
   hideOnInit  = true; 
   
   showInstanceName = false;
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_infected"; //RLBRLB this will never show up cuz its aborted when the instance is hidden .. we need to recreate this object any any others when its un-hidden
   buttonBlend = "0.4 1 0.4 1";
      
   faction = "Zombie";   
};


new ScriptGroup(SI_S2_CapacitorInstance : InstanceBase)
{   
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "SI_S2_CapacitorInstanceClass"; 
   
   friendlyName = "BATTLESHIP GRAVEYARD";
   
   showInstanceName = false;
   
   hideOnInit  = true; 
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids"; 
   buttonBlend = "0.4 1 0.4 1";
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
       instanceObjectWeightedList = "AmbientAsteroids";
       offset = 0;  
       creationChance = 1;  
       objectCount = "10 60";
   };  
};


new ScriptGroup(SI_S2_ReactorInstance : InstanceBase)
{   
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "SI_S2_ReactorInstanceClass"; 
   
   friendlyName = "SECRET SCIENCE FACILITY";
   
   hideOnInit  = true; 
   
   showInstanceName = false;
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids"; 
   buttonBlend = "0.4 1 0.4 1";
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
       instanceObjectWeightedList = "AmbientAsteroids";
       offset = 0;  
       creationChance = 1;  
       objectCount = "10 60";
   };  
};


new ScriptGroup(SI_S2_ShipyardInstance : InstanceBase)
{   
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "SI_S2_ShipyardInstanceClass"; 
   
   friendlyName = "BLACK MARKET SHIPYARD";
   
   hideOnInit  = true; 
   
   showInstanceName = false;
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids"; 
   buttonBlend = "0.4 1 0.4 1";
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
       instanceObjectWeightedList = "AmbientAsteroids";
       offset = 0;  
       creationChance = 1;  
       objectCount = "10 60";
   };  
};


