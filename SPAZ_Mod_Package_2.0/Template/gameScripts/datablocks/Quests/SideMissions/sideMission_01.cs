

///////////////////////////////////////////////////////////
// SIDE MISSION 01 DIALOG
///////////////////////////////////////////////////////////

new ScriptGroup (Dialog_sideMission_01_A : dialogBox_base) 
{
   character[0] = "MS_MINER";
   text[0]      = "Well this is very odd.  I'm picking up a huge metallic object nearby.  There are some human life signs too.  How the hell did they survive out here?  We need to go pick them up.";      
   
   character[1] = "MS_SCIENTIST";
   text[1]      = "I've confirmed it.  We're picking up signals from the old Clockwork!  We should see if we can salvage some of my missing data.";
    
   character[2] = "MS_MINER";
   text[2]      = "The Clockwork!?  I don't like this one bit.  This smells like a trap Carl.";   
   
   character[3] = "MS_SCIENTIST";
   text[3]      = "I must have that data Elsa.  I can't even begin to explain to your simple intellect how important this is.";
   
   character[4] = "MS_MINER";
   text[4]      = "To hell with your data!  Let's pick up the survivors and get out of here quickly.";   
};

new ScriptGroup (Dialog_sideMission_01_B : dialogBox_base) 
{
   character[0] = "MS_EVILDON";
   text[0]      = "You both are far too gullible.  If you wish to survive, you will have to take far better precautions than this.";
    
   character[1] = "MS_MINER";
   text[1]      = "Carl, what the hell did I tell you?  Trap!  Don't you watch TV?";   
};

new ScriptGroup (Dialog_sideMission_01_C : dialogBox_base) 
{  
   character[0] = "MS_SCIENTIST";
   text[0]      = "Hopefully the survivors we scooped up will be worth the damage.  Don must have left them here as bait.  Like a moth to the flame Elsa.";

   character[1] = "MS_MINER";
   text[1]      = "Carl, saving human life is always worth the effort!  Hell, one of these guys is even more skilled than you are.  Though that's not much of a feat.";  
};


///////////////////////////////////////////////////////////
// SIDE MISSION SETUP
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_SideMission_01 : QuestBase_SideMission)
{
   addToDatabase = true;  //Important 
   
   // !! SUPER IMPORTANT !! //////////////////////////////
   SelectionData["ObjectivesComplete"]  = "S1_Clockwork1"; 
   SelectionData["ObjectivesNotComplete"]  = "OBJ_SideMission_01"; 
   Callbacks["BeaconArrival"] = "SideMission_Start OBJ_SideMission_01 Dialog_sideMission_01_A";
   Callbacks["Complete"]      = "SideMission_Complete OBJ_SideMission_01 Dialog_sideMission_01_C";
   // !! SUPER IMPORTANT !! //////////////////////////////
       
   title = "THE CLOCK IS TICKING";  
   description = "The original Clockwork's radio transponder has been detected in this area.  Further investigation is required.";
  
   initialWaves = "WAVE_setup WAVE_Crates";
   
   missionText["initial"] = "MT_ATTACK COLLECT THE SUPPLIES";
   missionText["fight"] = "MT_ATTACK DESTROY ATTACKERS";
   missionText["beacon"] = "MT_ATTACK BEACON UNDER ATTACK";
   
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "fight";   
   
   Rewards["Complete", "Spec"] = "SS_ClockTicker";  
    
   DeployData["StarType"] = "INNER";  
   SelectionData["SectorProgress"] = "4 4"; //sec 4 spicific
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_setup")
   {    
      maxWaves = 1;  
      WaveMissionTrackers["active", 1] = "0"; 
      new ScriptGroup("REF_shipWreck") 
      {    
         creationChance = 1;
         instanceObjectWeightedList = "ShipWreck_Graveyard 10";                                
         offset = "4000";  
         refObjectName = "REF_Beacon";
         wreckDatablockWL = "shipWreck_Clockwork_Top 10"; 
         objectCount = "1";  
         //objectFuncs["Spawn", 0] = "AddGoToMarker"; 
         minDistanceOverride = 0;
         maxDistanceOverride = 0;
      };             
   };
   
   new ScriptGroup("WAVE_Crates")
   {
      maxWaves = 1; 
      healthCallbackSets = "Cargo";
      setHealthCallback["All", "Cargo", 0] = "0 StartWaveName WAVE_zomAttack";
      new ScriptGroup(crates_01 : MO_Props) 
      {     
         offset = "200 500";                                 
         instanceObjectWeightedList = "SpaceProp_UTASupply_zom";
         objectCount = "4";
         onInitializedFunc[0] = "AddToHealthCallbackSet Cargo";
         refObjectName = "REF_shipWreck";  
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet targetCrates";    
      }; 
      new ScriptGroup(goons_01 : MO_Props) 
      {     
         offset = "200 1000";                                 
         instanceObjectWeightedList = "SpaceProp_GoonPods_Zom";
         objectCount = "6";
         onInitializedFunc[0] = "AddToHealthCallbackSet Cargo";
         refObjectName = "REF_shipWreck";  
         objectFuncs["Spawn", 0]   = "AddTargetMarker";
         objectFuncs["Spawn", 1] = "addToTrackingSet targetCrates";    
      };          
   };
   
   new ScriptGroup("WAVE_zomAttack")
   {
      maxWaves = 4;        
      waveContext[1] = "fight"; 
      WaveMissionTrackers["active", 1] = "1";
      WaveMissionTrackers["remove", 1] = "0"; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zomAttack";    
      setHealthCallback[4, "enemy", 0] = "0 StartWaveName WAVE_zomAttack_beacon";  
      waveTimedCallbacks[1, 0] = "0 callOnSubObjects REF_shipWreck RemoveObjectiveMarker_ALL";     
      waveTimedCallbacks[1, 1] = "0 callQuestFunction SEQ_activateSequence Dialog_sideMission_01_B"; 
      new ScriptGroup(KillShips_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "3 4"; 
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Player";
         offset = "650"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
      };     
   };
   
   new ScriptGroup("WAVE_zomAttack_beacon")
   {
      maxWaves = 3;        
      waveContext[1] = "beacon"; 
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName WAVE_zomAttack_beacon"; 
      setHealthCallback[3, "enemy", 0] = "0 StartWaveName questComplete";      
      new ScriptGroup(KillShips_03 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "HeavyShips 10";
         objectCount = "2"; 
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Beacon";
         offset = "100"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";
         objectFuncs["Spawn", 0] = "AddTargetMarker"; 
      };    
   };
}; 
