
///////////////////////////////////////////////////////////
// COLLECT 05
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Collect_05 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
       
   title = "SUPPLY RUN";  
   description = "The local resistance is running low on food and medical supplies.  There is some nearby, but the area is infected.";
  
   initialWaves = "Zom_respawnFleet WAVE_collectables MADD_WAVE";
   
   missionText["initial"] = "MT_GOTO COLLECT THE ITEMS";
   missionText["remaining"] = "MT_INFO REMAINING ITEMS:";
   
   initialTimedCallbacks[0] = "3000 callQuestFunctionOnInstance MissionCallout initial";
      
   missionTrackerData[0] = "initial";
   missionTrackerData[1] = "remaining MT_SETCOUNTER pickupSet";
   
   DeployData["StarType"] = "INNER";
   SelectionData["SectorProgress"] = "4 4"; //sec 4 spicific
   
   Rewards["Complete", "Goons"] = "med";
   Rewards["Complete", "Bounty"] = "med";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
      
   new ScriptGroup(WAVE_collectables)
   {
      maxWaves = 1;     
      WaveMissionTrackers["active", 1] = "0 1"; 
      //creat pickup clusters       
      new ScriptGroup(CollectProp_01 : MO_CollectProp)
      {   
         offset = "4000 8500";      
         objectFuncs["Spawn", 1] = "AddGoToMarker";   
         objectFuncs["Pickup", 0] = "evalTrackingSetCount pickupSet 0 StartWaveName QuestComplete";  
         objectFuncs["Pickup", 1] = "CallInstanceFunc StartWaveName Zom_attackFleet 2500";  
         new ScriptGroup(CollectGuard_01 : MO_CollectGuard) 
         {   
            factionOverride = "Zombie";                                          
         };                                   
      };
                                               
      new ScriptGroup(CollectProp_02 : CollectProp_01)
      {   
         new ScriptGroup(CollectGuard_02 : MO_CollectGuard) 
         {   
            objectCount = "1";
            factionOverride = "Zombie";
            instanceObjectWeightedList = "HeavyShips 10";                                             
         };                               
      };
                                   
      new ScriptGroup(CollectProp_03 : CollectProp_01) //not all props have guards
      {                             
      };
      
      new ScriptGroup(CollectProp_04 : CollectProp_01) 
      {                       
      };
      new ScriptGroup(CollectProp_05 : CollectProp_01)
      {                               
      };
      new ScriptGroup(CollectProp_06 : CollectProp_01)
      {                               
      };
      new ScriptGroup(CollectProp_07 : CollectProp_01)
      {                               
      };
      new ScriptGroup(CollectProp_08 : CollectProp_01)
      {                               
      };
      new ScriptGroup(CollectProp_09 : CollectProp_01)
      {                               
      };
      new ScriptGroup(CollectProp_10 : CollectProp_01)
      {                               
      };
   };
   
   new ScriptGroup("Zom_attackFleet")
   {
      maxWaves = -1;
      new ScriptGroup(REF_ZomAttackers : MO_Ships) 
      {   
         instanceObjectWeightedList = "AverageShips 10 HeavyShips 3";
         offset = "2500 4000";  
         objectCount = "1 2";
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Player";
         respectShipCount = 4;                
      };    
   }; 
   
   new ScriptGroup("Zom_respawnFleet")
   {
      maxWaves = 15; //lots, but not forever
      healthCallbackSets = "enemy"; 
      setHealthCallback["All", "enemy", 0] = "1 StartWaveName Zom_respawnFleet 7500";
      new ScriptGroup(REF_ZomAttackers2 : MO_Ships) 
      {   
         instanceObjectWeightedList = "LightShips 10 AverageShips 5";
         offset = "3000 6000";  
         objectCount = "1 2";
         factionOverride = "ZombieKiller";                     
         refObjectName = "REF_Player"; 
         onInitializedFunc[0] = "AddToHealthCallbackSet enemy";              
      };    
   }; 
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CivHelpGroup : MADD_Civ_Help)
      {                  
      }; 
      new ScriptGroup(UTAHelpGroup : MADD_UTA_Help)
      {                  
      };  
   };
};