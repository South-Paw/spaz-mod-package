

///////////////////////////////////////////////////////////
// KILL 07
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Kill_07 : QuestBase_Event)
{
   addToDatabase = true;  //Important 
   
   warningTags = "UTA";
       
   title = "POKE AN EYE OUT";  
   description = "The UTA have several survey ships in the area.  They are trying to scout for the resources they need to sustain the size of their base.   If enough survey ships are destroyed, the base will be forced to downsize.  Survey ships will flee at the first sign of trouble.  Aggressive tactics are required to take them out.";
  
   initialWaves = "WAVE_SurveyShip WAVE_SurveyShip WAVE_SurveyShip WAVE_SurveyShip WAVE_SurveyShip WAVE_SurveyShip";
   initialTimedCallbacks[0] = "1000 callQuestFunctionOnInstance MissionCallout initial";
   initialTimedCallbacks[1] = "0 TS_addTrackingTick killsNeeded 10";
   initialTimedCallbacks[2] = "0 TS_addTrackingTick shipLoss 2";
   
   missionText["initial"] = "MT_ATTACK DESTROY SERVEY SHIPS";
   missionText["boss"] = "MT_ATTACK SURVEY GUARD INBOUND";
   missionText["remaining"] = "MT_INFO KILL QUOTA";
   missionText["acceptLost"] = "MT_INFO ACCEPTABLE LOSSES";
   missionText["failEscape"] = "MT_FAIL Too many survey ships escaped";

   missionTrackerData[0] = "initial"; 
   missionTrackerData[1] = "remaining MT_TICKCOUNTER killsNeeded";
   missionTrackerData[2] = "acceptLost MT_TICKCOUNTER shipLoss";  
     
   Rewards["Complete", "Relations_Terran"] = $RelChange_Down;
   Rewards["Complete", "Security"]   = -1; 
   
   SelectionData["SectorProgress"] = "1 3"; //civ conflict needs to stop at sec 4
   SelectionData["SecLevelRange"]     = "1 3";

   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////
         
   new ScriptGroup("WAVE_SurveyShip")
   {    
      maxWaves = -1;  
      WaveMissionTrackers["active", 1] = "0 1 2"; 
      
      waveTimedCallbacks["all", 0] = "0 QAI_SetAICommand SurveyShipSet SetTactic TP_Stance TP_Passive"; 
      waveTimedCallbacks["all", 1] = "0 QAI_SetAICommand SurveyFleeSet SetTactic TP_Retreat TP_RetreatOn"; 
                  
      new ScriptGroup(SurveyShip_01 : MO_Ships)
      {                                      
         instanceObjectWeightedList = "LightShips 10";
         objectCount = "1"; 
         factionOverride = "Terran";                         
         offset = "3000 7000";
         
         objectFuncs["Spawn", 0] = "AddTargetMarker";
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SurveyShipSet";   
           
         objectFuncs["Death", 0] = "CallInstanceFunc TS_addTrackingTick killsNeeded -1"; 
         objectFuncs["Death", 1] = "CallInstanceFunc StartWaveName WAVE_SurveyShip 5000";         
         objectFuncs["Death", 2] = "CallInstanceFunc TS_evalTrackingTick killsNeeded 0 StartWaveName QuestComplete"; 
         objectFuncs["Death", 3] = "CallInstanceFunc TS_evalTrackingTick killsNeeded 2 StartWaveName WAVE_SurveyGuard"; 
         
         objectFuncs["WarpOut", 0] = "CallInstanceFunc TS_addTrackingTick shipLoss -1"; 
         objectFuncs["WarpOut", 1] = "CallInstanceFunc TS_evalTrackingTick shipLoss 0 StartWaveName QuestFail 0 failEscape"; 
         
         objectFuncs["Damage", 0]  = "QAI_AddToSet SurveyFleeSet";              
      };                
   };
   
   new ScriptGroup("WAVE_SurveyGuard")
   {    
      maxWaves = 1;
      waveContext[1] = "boss"; 
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand SeekAndDestroySet SetTactic TP_Stance TP_SeekAndDestroy";          
      new ScriptGroup(SurveyBoss_01 : MO_Ships)
      {    
         refObjectName = "REF_Player";                                  
         instanceObjectWeightedList = "BossShips 10";
         objectCount = "1"; 
         factionOverride = "Terran";                         
         offset = "400 600";
         objectFuncs["Spawn", 1]   = "QAI_AddToSet SeekAndDestroySet";              
      };                
   };
   //no madds or this mission might get too bonkers
}; 
