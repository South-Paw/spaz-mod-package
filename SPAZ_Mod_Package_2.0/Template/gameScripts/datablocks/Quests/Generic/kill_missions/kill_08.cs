

///////////////////////////////////////////////////////////
// KILL 08
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_08 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "TIME";
       
   title = "MORALE BOOSTER";  
   description = "The locals need to be shown that the zombie threat is not insurmountable.  There is an area swarming with small zombie ships.  Wipe out a huge number of them in a short time to look like a hero among the population.";
  
   initialWaves = "WAVE_setup WAVE_ZomSwarm WAVE_ZomSwarm WAVE_ZomSwarm WAVE_ZomSwarm WAVE_ZomSwarm MADD_WAVE";
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick killsNeeded 50";
   initialTimedCallbacks[2] = "180000 StartWaveName QuestFail 0 failTime";
   
   missionText["initial"] = "MT_ATTACK DESTROY ZOMBIE TARGETS";
   missionText["remaining"] = "MT_INFO KILL QUOTA";
   missionText["failTime"] = "MT_FAIL You failed to kill enough targets";
   missionText["killTime"] = "MT_INFO TIME LIMIT";

   missionTrackerData[0] = "initial"; 
   missionTrackerData[1] = "remaining MT_TICKCOUNTER killsNeeded";
   missionTrackerData[2] = "killTime MT_TIMERTEXT 180";
     
   DeployData["StarType"] = "INNER";
   SelectionData["SectorProgress"] = "4 4"; //sec 4 spicific
   SelectionData["InfectionLevel"] = "1 3";
   
   Rewards["Complete", "Goons"] = "high";

   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   new ScriptGroup("WAVE_setup")
   {    
      maxWaves = 1;  
      WaveMissionTrackers["active", 1] = "0 1 2";                
   };
         
   new ScriptGroup("WAVE_ZomSwarm")
   {    
      maxWaves = -1;  
      healthCallbackSets = "enemy"; 
      setHealthCallback["all", "enemy", 0] = "0 StartWaveName WAVE_ZomSwarm 0";                
      new ScriptGroup(SurveyShip_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "TinyShips 10";
         objectCount = "1"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy"; 
         factionOverride = "ZombieKiller";                         
         offset = "1500 2000";
         refObjectName = "REF_Player";
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         objectFuncs["Death", 0] = "CallInstanceFunc TS_addTrackingTick killsNeeded -1"; 
         objectFuncs["Death", 1] = "CallInstanceFunc TS_evalTrackingTick killsNeeded 0 StartWaveName QuestComplete"; 
      };                
   };

   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CivHelpGroup : MADD_Civ_Ped)
      { 
      }; 
      new ScriptGroup(CivUTAGroup : MADD_UTA_Ped)
      {                       
      }; 
   };
}; 
