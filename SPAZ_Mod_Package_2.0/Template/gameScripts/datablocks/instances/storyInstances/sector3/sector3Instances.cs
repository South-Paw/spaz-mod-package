

new ScriptGroup(SI_S3_UberMining : MiningInstance)
{   
   instanceSubClass = "SI_S3_UberMiningClass"; 
   
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "MiningBase";
      offset = "3800";  
      creationChance = 1;      
      objectCount = 1; 
      refObjectName = "REF_beacon"; //this is some distance from the beacon for gameplay reasons
                 
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AmbientAsteroids";
         offset = 0;  
         creationChance = 1;
         objectCount = "15 20";
      };         
   };   
};

new ScriptGroup(SI_S3_TradeRouteInstance : InstanceBase)
{   
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "SI_S3_TradeRouteInstanceClass"; 
   
   friendlyName = "SHIP TRADE ROUTE";
   
   hideOnInit  = false;    
   
   showInstanceName = false;
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids"; 
   buttonBlend = "0.4 1 0.4 1";
};

new ScriptGroup(SI_S3_UberColony : ColonyInstance)
{   
   instanceSubClass = "SI_S3_UberColonyClass"; 
   
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



new ScriptGroup(SI_S3_UberScience : ScienceInstance)
{   
   instanceSubClass = "SI_S3_UberScienceClass"; 
   
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

new ScriptGroup(SI_S3_PureRezInstance : InstanceBase)
{   
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "SI_S3_PureRezClass"; 
   
   friendlyName = "PURE REZ DEPOSIT";
   
   hideOnInit  = false;    
   
   showInstanceName = false;
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids"; 
   buttonBlend = "0.4 1 0.4 1";
};




























