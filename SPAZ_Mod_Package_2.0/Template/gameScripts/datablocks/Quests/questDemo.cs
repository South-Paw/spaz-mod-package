///////////////////////////////////////////////////////////
// This is a quest that will never run, but is a testbed //
///////////////////////////////////////////////////////////


new ScriptGroup(QuestDemo : QuestBase)
{
   addToDatabase = false;  //DOnt need to include anymore 
   
   DeployData["StarType"]     = "UNDEFINED"; //will need quest launcher to fire. 
    
   questType   = "Inf";   //Pick this on eup at the star base.    
   SelectionData["ObjectivesComplete"]  = ""; //always allowed
   
   //DEBUG MISSIONS: lets just set this always active (NOT FOR NORMAL MISSIONS) No Keithing it up
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //Note: FactionRelationDefinedValues:
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_MYFACTION;  //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION


   rarity        = "Story"; 
   maxCompletes  = 1;
   expiryTurns = 2;
       
   title = "Quest Demo";  
   description = "This is the quest demo it shows how stuf werks.";

   parentQuest = "";
   childQuests = "";
   
   Rewards["Complete", "Resource"]          = "Exact 20";
   Rewards["Complete", "Relations_Civ"]     = $RelChange_Up;
   Rewards["Complete", "Relations_Terran"]  = $RelChange_Down;
  
   initialWaves = "WAVE_CargoField WAVE_CargoField_Outter WAVE_FakeWarpGate";
   
   initialTimedCallbacks[0] = "1000 callQuestFunction CustomCallout TIMED_CALLBACK";
   initialTimedCallbacks[1] = "2000 StartWaveName WAVE_Traffic 0";
   
   DeployData["LevelRange"]     = "20 30";
   
   beaconDistance = 2000; 
         
        
   new ScriptGroup("WAVE_CargoField")
   {
      maxWaves = 1;  
      healthCallbackSets = "Cargo";
      setHealthCallback["All", "Cargo", 0] = "0 callQuestFunction SEQ_activateSequence Dialog_S1_Favor1GoneBad Tutorial_Push CombatTutorial";
      setHealthCallback["All", "Cargo", 1] = "0 StartWaveName WAVE_CargoPickerGuards";
      //waveContext[1] = "DESTROY UTA STORAGE CRATES";
      
      //waveIndex, subIndex (can start multiple timers) "All" is a valid wave index too.
      waveTimedCallbacks[1, 0] = "10000 StartWaveName WAVE_AmbientCivShips 0";
      waveTimedCallbacks[1, 1] = "7500 StartWaveName WAVE_Number1Buddy 0";
      waveTimedCallbacks[1, 2] = "1000 StartWaveName WAVE_TestBomber 0";
            
      //Do some AI setup       //QAI = Quest AI
      waveTimedCallbacks[1, 3] = "1000 QAI_SetAICommand AlliesSet Attack EnemiesSet";
      waveTimedCallbacks[1, 4] = "1000 QAI_SetAICommand EnemiesSet Attack AlliesSet";  //Also: BeaconSet
      waveTimedCallbacks[1, 5] = "1000 QAI_SetAICommand EnemiesSet SetTactic TP_Stance TP_Passive";
      waveTimedCallbacks[1, 6] = "1000 QAI_SetAICommand EnemiesSet MoveTo REF_Beacon";
      
         
      new ScriptGroup("REF_S1_01") 
      {                                      
         instanceObjectWeightedList = "SpaceProp_UTASupply";
         offset = 0;  
         creationChance = 1;
         objectCount = "Scaled 1 10"; //looks at instance level vs DeplayData["LevelRange"]
         onInitializedFunc[0] = "AddToHealthCallbackSet Cargo";
         objectFuncs["Spawn", 0]   = "AddTargetMarker";        
      };
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "SpaceProp_Crates";
         offset = 0;  
         creationChance = 1;
         objectCount = "8 8";
         refObjectName = "REF_S1_01"; 
      };
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_Light";
         offset = 0;  
         creationChance = 1;
         objectCount = "2 2";
      };     
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "AsteroidBreakage";
         offset = 0;  
         creationChance = 1;
         objectCount = "14 14";
      };        
   };
   
   new ScriptGroup("WAVE_CargoField_Outter")
   {
      maxWaves = 1;  
      new ScriptGroup() 
      {                                      
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_Light";
         offset = 0;  
         creationChance = 1;
         objectCount = "20 20";  //puts a hazard field on the opposite side of the uta crates than the beacon
         refAngleData = "REF_Beacon REF_S1_01 0 5000"; //startpos, endpos, angle, distance.  (starttpos/endpos gives a line to reference the angle with)
      
         new ScriptGroup() 
         {                                      
            instanceObjectWeightedList = "SpaceProp_Crates";
            offset = 0;  
            creationChance = 1;
            objectCount = "8 8";
         };
      };         
   };
   
   
   new ScriptGroup("WAVE_CargoPickerGuards")
   {
      maxWaves = 5; //you should fight something easier then you first, so lets spawn some nerfed ships
      healthCallbackSets = "Enemies";
      setHealthCallback["All", "Enemies", 0] = "0 StartWaveName WAVE_CargoPickerGuards";
      //setHealthCallback[5, "Enemies", 0] = "0 StartWaveName QuestComplete";
      //waveContext[1] = "UTA SHIPS ON RADAR!";
            
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "500 750";  
          creationChance = 1;  
          objectCount = "2 2";
          factionOverride = "Terran";           
          onInitializedFunc[0] = "AddToHealthCallbackSet Enemies";
          refObjectName = "REF_S1_01";
          shipDesignWL = "DartShip 10";      
          
          objectFuncs["Spawn", 0]   = "QAI_AddToSet EnemiesSet";       
      };      
   };
   
   new ScriptGroup("WAVE_AmbientCivShips")
   {
      maxWaves = 8; //make sure you have a good supply of help
      waveRelations[1, 0] = "Civ Pirate" SPC $FactionRelation_MYFACTION;
      waveRelations[1, 1] = "Civ Terran" SPC $FactionRelation_HATE;
      healthCallbackSets = "Helpers";
      setHealthCallback["All", "Helpers", 0] = "0 StartWaveName WAVE_AmbientCivShips";
      
      //waveContext[1] = "Miners have sent reinforcements, shitty ones";
      
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "TinyShips 20";
          offset = "100 200";  
          creationChance = 1;  
          objectCount = "1 1";
          factionOverride = "Civ";          
          onInitializedFunc[0] = "AddToHealthCallbackSet Helpers";
          refObjectName = "REF_S1_01";   
          
          objectFuncs["Spawn", 0]   = "QAI_AddToSet AlliesSet";  
          
          hullBitMatching = $SST_HULL_MINING;
          //designBitMatching = $SST_DESIGN_CIV;  //Note: Civs default to civs, non civs default ot basic
      };     
      
      
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "TinyShips 20";
          offset = "100 200";  
          creationChance = 1;  
          objectCount = "2 2";
          factionOverride = "Civ";          
          onInitializedFunc[0] = "AddToHealthCallbackSet Helpers";
          refObjectName = "REF_S1_01";   
         
          hullBitMatching = $SST_HULL_COLONY; //we do not add to allies set, so these should be less likely to be attacked by enemies
      };     
   };  
   
   
   //Device example. 
   new ScriptGroup("WAVE_TestBomber")
   {
      maxWaves = 1; //make sure you have a good supply of help     
      
      waveTimedCallbacks[1, 0] = "1000 QAI_SetAICommand ExploderSet SetTactic TP_Destruct TP_DestructOn";
      waveTimedCallbacks[1, 1] = "500 callQuestFunction CustomCallout I_GO_BOOM!"; 
      
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "MediumShips 20 LargeShips 20";
          offset = "500 800";  
          creationChance = 1;  
          objectCount = "1 1";
          factionOverride = "Terran";                    
          refObjectName = "REF_Beacon";   
          deviceBitMatching = $SST_DEVICE_BOMB;
          objectFuncs["Spawn", 0]   = "QAI_AddToSet ExploderSet";  
          
          //hullBitMatching = $SST_HULL_MILITARY; //is Terran default (exists to differentiate civ types really
          //designBitMatching = $SST_DESIGN_CIV;  //Note: Civs default to civs, non civs default ot basic
      
      };     
   };  
   
   new ScriptGroup("WAVE_Number1Buddy")
   {
      maxWaves = 1; //make sure you have a good supply of help     
      
      //Buddies should spawn on top of the #1
      waveTimedCallbacks[1, 0] = "5000 StartWaveName WAVE_Number1BuddyBuddies 0";
      //time to leave. (will cause the spawned sub buddies to tag along)
      waveTimedCallbacks[1, 1] = "8000 callQuestFunction CustomCallout We_Go_Now"; //underscores so i can pass in text as a single parameter (need a real solution for this, should call a real sequence)
      waveTimedCallbacks[1, 2] = "9000 QAI_SetAICommand PlotSet SetTactic TP_Stance TP_Passive";
      waveTimedCallbacks[1, 3] = "9000 QAI_SetAICommand PlotSet SetTactic TP_Collect TP_NoCollect";
      waveTimedCallbacks[1, 4] = "10000 QAI_SetAICommand PlotSet MoveTo REF_WarpOutTrigger 0"; //last value is the distance tolerance. 

            
      new ScriptGroup("REF_Number1BuddySpawner") 
      {                                      
          instanceObjectWeightedList = "SpawnMyShip";
          offset = "500 750";  
          creationChance = 1;  
          objectCount = "1 1";
          factionOverride = "Civ";                     
          refObjectName = "REF_Beacon";
          shipDesignWL = "FreighterShip 10";          
          
          objectFuncs["Spawn", 0]   = "QAI_AddToSet PlotSet";  
          objectFuncs["Death", 0]   = "CallInstanceFunc StartWaveName QuestFail";  
          objectFuncs["WarpOut", 0] = "CallInstanceFunc StartWaveName QuestComplete";  
          
          shipSpawnHealth = 0.05;  //crippled 
          mountRefObjectNames = "REF_Number1BuddySpawner"; //any ref object can be mounted to this. Each time there is a spawn, the spawner gets re mounted to newest spawned object. (This is a list, so we can mount multiple ref objects)
          //So we mounted to parent ref object to the child, for other object to reference, but our initial spawn is based on another ref object (the beacon)
      };              
   };  
   
   //This spawns on top of the mounted buddy spawner. 
   new ScriptGroup("WAVE_Number1BuddyBuddies")
   {
      maxWaves = 1; 
      
                
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "AverageShips 10";
          offset = 0;  
          creationChance = 1;  
          objectCount = "1 1";
          factionOverride = "Civ";                    
          refObjectName = "REF_Number1BuddySpawner";   
          
          objectFuncs["Spawn", 0]   = "QAI_AddToSet PlotSet";  
          
          hullBitMatching = $SST_HULL_SCIENCE;          
      };              
   };  
   
   
   //simple fake warpgate traffic
   new ScriptGroup("WAVE_Traffic")
   {
      maxWaves = -1; 
     
      healthCallbackSets = "ScienceTraffic";
      setHealthCallback["All", "ScienceTraffic", 0] = "0 StartWaveName WAVE_Traffic";
              
      waveTimedCallbacks["All", 0] = "0 QAI_SetAICommand TrafficSet MoveTo REF_WarpOutTrigger 0"; //last value is the distance tolerance. 
 
      new ScriptGroup() 
      {                                      
          instanceObjectWeightedList = "LightShips 20";
          offset = 0;  
          creationChance = 1;  
          objectCount = "1 1";
          factionOverride = "Civ";                    
          refObjectName = "REF_Beacon";   
          onInitializedFunc[0] = "AddToHealthCallbackSet ScienceTraffic";
          
          objectFuncs["Spawn", 0]   = "QAI_AddToSet TrafficSet";  
          
          hullBitMatching = $SST_HULL_SCIENCE;          
      };              
   };  
   
   
   new ScriptGroup("WAVE_FakeWarpGate") //use WAVE_ prefix to avoid having 2 object of the same name. 
   {
      maxWaves = 1;      
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand WarpOutSet SetTactic TP_Retreat TP_RetreatOn";
   
      new ScriptGroup("REF_FakeWarpGate") 
      {
         instanceObjectWeightedList = "FakeWarpGate";  //hope there is not a name collision on this. 
         offset = 0;  
         creationChance = 1;      
         objectCount = 1;      
         
         refAngleData = "REF_Beacon REF_S1_01 180 3000"; //away from da action       
      
      
         new ScriptGroup("REF_WarpOutTrigger") //we will use this to turn it on and off maybe? 
         {                                      
             instanceObjectWeightedList = "QuestTrigger 20";
             offset = 0;  //dont use offsets with triggers
             creationChance = 1;  
             objectCount = "1 1";  //dont ever spawn more than one
             
             triggerRadius = 100;
             triggerPingRate = 250; //milliseconds
             
             //doesnt need a ref object in this case. using parenting
             //refObjectName = "REF_FakeWarpGate";  //this is where the trigger will originally spawn, BUT if this ref object is mounted to another object, the trigger will move with it. 
            
             //Potential gotcha with mounting: The ref object must be spawned BEFORE the object is spawned that wants to grab it to mount it to itself. 
            
             //trigger funcs:  ObjectFunc/InstanceFunc (1)onEnter/(0)onExit, SetName, command, params...
             triggerFuncs[0] = "ObjectFunc 1 PlotSet QAI_AddToSet WarpOutSet"; //these are called on the object that enters. 
             triggerFuncs[1] = "InstanceFunc 1 PlotSet callQuestFunction CustomCallout TRIGGER_ENTRY"; //these are called on the instance object
             
             triggerFuncs[2] = "ObjectFunc 1 TrafficSet QAI_AddToSet WarpOutSet";
             //turns trigger off after first guy enters
             //triggerFuncs[2] = "InstanceFunc 1 PlotSet setTriggerActive REF_WarpOutTrigger 0"; //these are called on the instance object
         
         };              
      };
   };
   
 
};  






