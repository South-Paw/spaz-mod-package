

///////////////////////////////////////////////////////////
// KILL 09
///////////////////////////////////////////////////////////

/*

new ScriptGroup(Quest_Kill_09 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "CIV";
       
   title = "AREA DENIAL";  
   description = "The local civilians have set up a webbing of automated turrets in the area, demanding a toll be paid to passing ships.  This is unacceptable in the eyes of the UTA.  A reward will be paid to anyone who destroys the turret network.";
  
   initialWaves = "WAVE_setupTurrets WAVE_setupTurrets WAVE_setupTurrets MADD_WAVE";
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
  
   missionText["initial"] = "MT_ATTACK DESTROY AUTO TURRETS";
   missionText["remaining"] = "MT_INFO REMAINING TURRETS:";

   missionTrackerData[0] = "initial"; 
   missionTrackerData[1] = "remaining MT_SETCOUNTER killTargets";
     
   //RELATIONSHIP RANGE //_HATE _ENEMY _DISLIKE _NEUTRAL _LIKE _FRIEND _MYFACTION
   SelectionData["Relations_Pirate_Civ"]    = $FactionRelation_HATE SPC $FactionRelation_FRIEND;  //this mission can happen in any state
   SelectionData["Relations_Pirate_Terran"] = $FactionRelation_HATE SPC $FactionRelation_FRIEND;
   
   missionTrackerData[0] = "initial";   
   
   Rewards["Complete", "Relations_Civ"] = $RelChange_Down;
   Rewards["Complete", "Resource"] = "High";
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4

   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
   
   new ScriptGroup("WAVE_setupTurrets")
   {    
      maxWaves = 3;  
      WaveMissionTrackers["active", 1] = "0 1"; 
      new ScriptGroup(UTA_Beacon : MO_Props) 
      {    
         instanceObjectWeightedList = "SpawnMyShip";
         offset = "5000 7000";  
         creationChance = 1;  
         objectCount = "3";
         factionOverride = "Civ";
         refObjectName = "REF_Beacon"; 
         
         objectFuncs["Spawn", 0] = "AddTargetMarker";  
         objectFuncs["Spawn", 1] = "addToTrackingSet killTargets";
         objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName WAVE_CivAttack";  
         objectFuncs["Death", 1] = "evalTrackingSetCount killTargets 0 StartWaveName QuestComplete";
           
         shipDesignWL = "DeployTurretShip_Basic 10";
      };                 
   };
         
   new ScriptGroup("WAVE_CivAttack")
   {    
      maxWaves = -1;
      waveTimedCallbacks["All", 0] = "0 QAI_SetAICommand civAttackSet SetTactic TP_Stance TP_SeekAndDestroy";         
      new ScriptGroup(CivShip_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "AverageShips 10";
         objectCount = "1 2"; 
         factionOverride = "Civ";                         
         offset = "1500 2000";
         refObjectName = "REF_Player";
         hullBitMatching = $SST_HULL_INF | $SST_HULL_SURPLUS;   
         respectShipCount = 5;
         objectFuncs["Spawn", 0] = "QAI_AddToSet civAttackSet";   
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

*/
