//general base

//Dont call this randomInstanceBase or we will have a name collision
new ScriptGroup(RandomInstance : InstanceBase)
{
   instanceClass = "RandomInstanceClass";
   friendlyName = "genericName"; 
   
   showInstanceName = false; //this tells the instance screen to now display the name
   
   faction = "InstanceDefined";
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_lightCloud";
   buttonBlend = "0.4 1 0.4 1";           
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
   };            
};

new ScriptGroup(RandomInstance_Rich : InstanceBase)
{
   instanceClass = "RandomInstanceClass";
   friendlyName = "ASTEROID CLUSTER"; 
   
   showInstanceName = true;
   
   faction = "InstanceDefined";
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids";
   buttonBlend = "0.4 1 0.4 1";           
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
      
      new ScriptGroup("") 
      {                                      
         instanceObjectWeightedList = "AsteroidBreakage";
         offset = "1000 4000";  
         creationChance = 1;
         objectCount = "4 8";
      }; 
   };            
};

new ScriptGroup(RandomInstance_Barrels : InstanceBase)
{
   instanceClass = "RandomInstanceClass";
   friendlyName = "DUMPING GROUND"; 
   
   showInstanceName = true;
   
   faction = "InstanceDefined";
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_junk";
   buttonBlend = "0.4 1 0.4 1";           
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
      
      new ScriptGroup("") 
      {                                      
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels";
         offset = "1000 4000";  
         creationChance = 1;
         objectCount = "5 10";
      };
      
      new ScriptGroup("") 
      {                                      
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels";
         offset = "3000 6000";  
         creationChance = 1;
         objectCount = "5 10";
      };
      
      new ScriptGroup("") 
      {                                      
         instanceObjectWeightedList = "SpaceProp_EMPBarrels";
         offset = "1000 4000";  
         creationChance = 0.2;
         objectCount = "2 8";
      };  
      
      new ScriptGroup("") 
      {                                      
         instanceObjectWeightedList = "SpaceProp_AcidBarrels";
         offset = "1000 4000";  
         creationChance = 0.2;
         objectCount = "2 8";
      };    
   };            
};

new ScriptGroup(RandomInstance_Crates : InstanceBase)
{
   instanceClass = "RandomInstanceClass";
   friendlyName = "SUPPLY FIELD"; 
   
   showInstanceName = true;
   
   faction = "InstanceDefined";
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_junk";
   buttonBlend = "0.4 1 0.4 1";           
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
      instanceObjectWeightedList = "SpaceProp_AmbientCrates";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
      
      new ScriptGroup("") 
      {                                      
         instanceObjectWeightedList = "SpaceProp_Crates";
         offset = "1000 4000";  
         creationChance = 1;
         objectCount = "5 10";
      };
      
      new ScriptGroup("") 
      {                                      
         instanceObjectWeightedList = "SpaceProp_Crates_Rich";
         offset = "1000 4000";  
         creationChance = 0.2;
         objectCount = "2 8";
      };   
   };            
};


new ScriptGroup(RandomInstance_Wrecks : InstanceBase)
{
   instanceClass = "RandomInstanceClass";
   friendlyName = "WRECK FIELD"; 
   
   showInstanceName = true;
   
   faction = "InstanceDefined";
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_junk";
   buttonBlend = "0.4 1 0.4 1";           
      
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "5 10";
   };     
      
   new ScriptGroup("MoreWrecks") 
   {    
      creationChance = 1;
      instanceObjectWeightedList = "ShipWreck_Graveyard 10";                                
      objectCount = "6 10";
      offset = "1000 4000";  
      wreckDatablockWL = "ShipWreck_BigBus 10 ShipWreck_Flora 10 ShipWreck_BigBrother 10 ShipWreck_RightHook 10 ShipWreck_Helix 10 ShipWreck_SunSpot_Left 5 ShipWreck_SunSpot_Right 5 ShipWreck_terranStation_01 5 shipWreck_quasarStation_01 5 ShipWreck_stationDoodad_Large 5 ShipWreck_stationDoodad_Med02 5"; 
      objectCount = "4 5";  
   }; 
   new ScriptGroup("MoreWrecks1" : MoreWrecks) 
   {    
      objectCount = "6 8";
      offset = "3000 6000";  
   }; 
   new ScriptGroup("MoreWrecks2" : MoreWrecks) 
   {    
      offset = "3000 8000";                         
      objectCount = "1 3";  
   };
   new ScriptGroup("MoreWrecks3" : MoreWrecks) 
   {    
      offset = "3000 8000";                         
      objectCount = "1 3";  
   };
   new ScriptGroup("MoreWrecks4" : MoreWrecks) 
   {    
      offset = "3000 8000";                         
      objectCount = "1 3";  
   };    
   new ScriptGroup("MoreWrecks5" : MoreWrecks) 
   {    
      offset = "3000 8000";                         
      objectCount = "1 3";  
   };                  
};