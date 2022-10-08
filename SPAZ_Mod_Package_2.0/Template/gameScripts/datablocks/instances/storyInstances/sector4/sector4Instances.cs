

new ScriptGroup(Sector3_4_Connect_Warpgate : WarpGateInstance)
{      
   instanceClass = "WarpGateInstanceClass";  //Use the base version
   instanceSubClass = "Sector3_4_Connect_WarpgateInstanceClass";
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
   };   
};



new ScriptGroup(Sector3_4_Connect_MothershipHide : MothershipHideInstance)
{   
   instanceSubClass = "Sector3_4_Connect_MothershipHideClass"; 
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
       instanceObjectWeightedList = "AmbientAsteroids";
       offset = 0;  
       creationChance = 1;  
       objectCount = "10 60";
   };  
};



new ScriptGroup(Sector3_4_Connect_Science : ScienceInstance)
{   
   instanceSubClass = "Sector3_4_Connect_ScienceClass"; 
   
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

new ScriptGroup(Sector3_4_Connect_Security : SecurityInstance)
{   
   instanceSubClass = "Sector3_4_Connect_SecurityClass"; 
   
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





///////////////////////////////////////////////////////////////////////
// ZOMBIE SYSTEM BELOW ////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////

new ScriptGroup(Sector4_ZombieHomestar_Warpgate : WarpGateInstance)
{      
   instanceClass = "WarpGateInstanceClass";  //Use the base version
   instanceSubClass = "Sector4_ZombieHomestar_WarpgateInstanceClass";
   
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
   };   
};

new ScriptGroup(Sector4_ZombieHomestar_MothershipHide : MothershipHideInstance)
{   
   instanceSubClass = "Sector4_ZombieHomestar_MothershipHideClass"; 
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
       instanceObjectWeightedList = "AmbientAsteroids";
       offset = 0;  
       creationChance = 1;  
       objectCount = "10 60";
   };  
};

new ScriptGroup(Sector4_ZombieHomestar_Infrastructure : ScienceInstance)
{   
   instanceSubClass = "Sector4_ZombieHomestar_InfrastructureClass"; 
   hideOnInit  = true; 
   
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

new ScriptGroup(Sector4_ZombieHomestar_Security : SecurityInstance)
{   
   instanceSubClass = "Sector4_ZombieHomestar_SecurityClass"; 
   hideOnInit  = true; 
   
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


new ScriptGroup(Sector4_ZombieHomestar_ZombieInstance : ZombieInstance)
{   
   instanceSubClass = "Sector4_ZombieHomestar_ZombieInstanceClass"; 
               
   new ScriptGroup() 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
   };        
};

new ScriptGroup(AlienGateInstance : InstanceBase)
{   
   instanceClass = "AsteroidInstanceClass";  
   instanceSubClass = "AlienGateInstanceClass"; 
   
   friendlyName = "ALIEN GATE";
     
   showInstanceName = true;
   
   buttonImage = "objectiveMarker_emptyImageMap";
   systemScreenObject = "systemScreenObject_asteroids"; 
   buttonBlend = "0.4 1 0.4 1";
   
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
       instanceObjectWeightedList = "FakeWarpGate";
       offset = "6000 6000";  
       creationChance = 1;  
       objectCount = "1 1";
       isAlien = true;
       refObjectName = "REF_Beacon";    
   };  
};


/////////////////////////////////////////////////////////////
// BOSS FIGHT DIMENSION /////////////////////////////////////
/////////////////////////////////////////////////////////////

new ScriptGroup(Sector4_ZombieBossFight_MothershipHide : MothershipHideInstance)
{   
   instanceSubClass = "BossFightInstanceClass"; 
   
   friendlyName = "BOSS FIGHT";     
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



new ScriptGroup(Sector4_ZombieBossFight_Infrastructure : ScienceInstance)
{   
   instanceSubClass = "Sector4_ZombieBossFight_InfrastructureClass"; 
   hideOnInit  = true; 
   
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

new ScriptGroup(Sector4_ZombieBossFight_Security : SecurityInstance)
{   
   instanceSubClass = "Sector4_ZombieBossFight_SecurityClass"; 
   hideOnInit  = true; 
   
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


new ScriptGroup(Sector4_ZombieBossFight_ZombieInstance : ZombieInstance)
{   
   instanceSubClass = "Sector4_ZombieBossFight_ZombieInstanceClass"; 
   hideOnInit  = true; 
   new ScriptGroup() 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
   };        
};
































