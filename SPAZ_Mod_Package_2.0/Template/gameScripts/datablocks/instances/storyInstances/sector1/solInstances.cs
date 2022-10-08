

//Will need to have instance logic that determines if it is hidden or not
//cannot put this logic on board the datablock. 
//could have an initialHide flag. 
new ScriptGroup(SI_S1_Sol_MothershipHide : InstanceBase)
{
   friendlyName = "MOTHERSHIP HIDEOUT";
   //instanceClass = "MothershipHideInstanceClass";  //We do not want to link to this as the parent.
   //But in most other story cases we will want to take advantage of the parent's functionality.
   //This instance is so special it isnt really related to MothershipHideInstanceClass
   instanceSubClass = "SI_S1_Sol_MothershipHideClass";
   
   hideOnInit  = false; //we will want to see this one. 
      
   buttonImage = "objectiveMarker_homeImageMap";
   systemScreenObject = "systemScreenObject_mothership";
   buttonBlend = "0.4 1 0.4 1"; 
};



new ScriptGroup(SI_S1_Sol_Security : InstanceBase)
{
   instanceClass = "SecurityInstanceClass";  //Use the base version
   instanceSubClass = "SI_S1_Sol_SecurityInstanceClass";
   
   friendlyName = "SECURITY BASE";
   instanceWaringTag = "security";
   
   hideOnInit  = true;  
   
   buttonImage = "objectiveMarker_terranImageMap";
   systemScreenObject = "systemScreenObject_security";
   buttonBlend = "1 0.5 0.5 1";
   
   faction = "Terran";  
      
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "SecurityBase";
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


new ScriptGroup(SI_S1_Sol_Warpgate : WarpGateInstance)
{      
   instanceClass = "WarpGateInstanceClass";  //Use the base version
   instanceSubClass = "SI_S1_Sol_WarpGateInstanceClass";
   hideOnInit  = true; 
   
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
      new ScriptGroup() 
      {                              
          instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_Light";
          offset = 0;  
          creationChance = 0.5;
          objectCount = "4 6";
      };    
      new ScriptGroup() 
      {                              
          instanceObjectWeightedList = "SpaceProp_Crates";
          offset = 0;  
          creationChance = 0.5;
          objectCount = "4 6";
      };                   
   };   
};


new ScriptGroup(SI_S1_Sol_Mining : InstanceBase)
{
   instanceClass = "MiningInstanceClass";  //Use the base version
   instanceSubClass = "SI_S1_Sol_MiningInstanceClass";
   
   friendlyName = "MINING STATION"; 
   instanceWaringTag = "mining";  
   
   hideOnInit  = true; 
   
   buttonImage = "objectiveMarker_mineImageMap";
   systemScreenObject = "systemScreenObject_mining";
   buttonBlend = "0.4 1 0.4 1";
      
   faction = "Civ";   
   
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "MiningBase";
      offset = "3500 3500";  
      creationChance = 1;      
      objectCount = 1;
      refObjectName = "REF_Beacon";    
      new ScriptGroup("REF_S1_motherRock") 
      {
         instanceObjectWeightedList = "AsteroidMother";
         offset = "600 800";  
         creationChance = 1;       
         objectCount = 1;  
      };         
   };   
};


new ScriptGroup(SI_S1_Sol_DeadSpace : InstanceBase)
{
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "SI_S1_Sol_SaturnInstanceClass";
   
   friendlyName = "STAGING AREA";
   
   hideOnInit  = true;
   
   showInstanceName = false; 
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids";
   buttonBlend = "0.4 1 0.4 1";
      
   faction = "Civ";
   
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "AsteroidBreakage"; //need something here so game does not die.
      offset = 0;  
      creationChance = 1;      
      objectCount = "2 3";
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "AmbientAsteroids";
          offset = 0;  
          creationChance = 1;
          objectCount = "6 10";
      };              
   };
   
   new ScriptGroup() 
   {                                      
      instanceObjectWeightedList = "SpaceProp_Crates";
      offset = 0;  
      creationChance = 1;
      objectCount = "2 3";
      refObjectName = "REF_InstanceFocus"; 
   };
};

new ScriptGroup(SI_S1_Sol_AmbientAsteroid : InstanceBase)
{
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "";
   
   friendlyName = "ASTEROID CLUSTER";
   
   hideOnInit  = true;
   
   showInstanceName = false; 
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids";
   buttonBlend = "0.4 1 0.4 1";
      
   faction = "Civ";
   
   
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "AsteroidBreakage"; //need something here so game does not die.
      offset = 0;  
      creationChance = 1;      
      objectCount = "10 12";
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "AmbientAsteroids";
          offset = 0;  
          creationChance = 1;
          objectCount = "15 20";
      };            
      new ScriptGroup() 
      {                              
          instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_Light";
          offset = 0;  
          creationChance = 1;
          objectCount = "2 3";
      };    
   };
   
   new ScriptGroup() 
   {                                      
      instanceObjectWeightedList = "SpaceProp_Crates";
      offset = 0;  
      creationChance = 1;
      objectCount = "4 6";
      refObjectName = "REF_InstanceFocus"; 
   };
};





