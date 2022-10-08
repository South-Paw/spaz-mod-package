

function InstanceDatablock::OnAdd(%this)
{
       
}



//We do not need to use Datablocks for this.
new ScriptGroup(InstanceBase)
{
   class = "InstanceDatablock";  //so we can hook up to an on Add type functionality. 
   friendlyName = "NAME NOT DEFINED!";
   instanceClass = ""; //Needs to be defined for things to work
   instanceSubClass = ""; //For story missions and such
   
   
   //NOTE: The warpin position is from the center of the instance 0 0
   warpInDistance = 2000;  //how far away we spawn from the root position when warping in.
   maxObjectCount = 50;    //some instances may want to have more or fewer limits
      
   faction = "StarFaction";  //will make the instance whatever faction the star is. 
   systemScreenObject = "systemScreenObject_lightCloud";
   
   hideOnInit = false; //if true the instance will need to be revealed thru gameflow.   
   
   showInstanceName = true; //used by instance screen
};



new ScriptGroup(QuestInstance : InstanceBase)
{
   instanceClass = "QuestInstanceClass";
   friendlyName = "MISSION OBJECTIVE";
   
   buttonImage = "objectiveMarker_emptyImageMap";
   buttonBlend = "1 0.5 0.5 1";
          
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
   }; 
};

new ScriptGroup(ArenaInstance : InstanceBase)
{
   instanceClass = "ArenaInstanceClass";
   friendlyName = "THE ARENA";
   
   buttonImage = "objectiveMarker_emptyImageMap";
   buttonBlend = "1 0.5 0.5 1";
          
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
   }; 
};


new ScriptGroup(BountyInstance : InstanceBase)
{
   instanceClass = "BountyInstanceClass";
   friendlyName = "BOUNTY HUNTER BASE";
   
   buttonImage = "objectiveMarker_bountyBaseImageMap";
   buttonBlend = "1 0.5 0.5 1";
          
   new ScriptGroup("REF_InstanceFocus") 
   {
      instanceObjectWeightedList = "BountyStarbase";
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

new ScriptGroup(FrontEndInstance : InstanceBase)
{
   instanceClass = "FrontEnd_InstanceClass";
   
   buttonImage = "objectiveMarker_friendlyImageMap";
   buttonBlend = "1 0.5 0.5 1";
   
   warpInDistance = 0;  //sets beacon position to 0,0 which moves the camera there.
  
   new ScriptGroup("REF_InstanceFocus") 
   {                                      
      instanceObjectWeightedList = "AmbientAsteroids";
      offset = 0;  
      creationChance = 1;
      objectCount = "15 20";
   };  
    
};