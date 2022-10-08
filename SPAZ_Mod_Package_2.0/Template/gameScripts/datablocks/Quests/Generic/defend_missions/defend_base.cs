////////////////////////////////////////////////////////////////////////////////
//DEFEND BASE
////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////
//DEFEND WAVE SETUP
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Defend_WaveBasic)
{                                      
   maxWaves = 1;  
   
   healthCallbackSets = "DefendPropSet";
   setHealthCallback["All", "DefendPropSet", 0] = "0 StartWaveName QuestFail 0 failReason"; 
   
   waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand Defend_AttackerSet Attack defendPropSet";     
   waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand Defend_AttackerSet SetTactic TP_Stance TP_SeekAndDestroy";     
   waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand Defend_AttackerSet SetTactic TP_Shields TP_ShieldsDown"; //makes them easier to kill off
   waveTimedCallbacks[1, 3] = "0 QAI_SetAICommand Defend_DefenderSet SetTactic TP_Stance TP_SeekAndDestroy"; 
}; 

////////////////////////////////////////////////////////////////////////////////
//DEFEND OBJECTS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(MO_Defend_Prop : MO_Props)
{  
   refObjectName = "REF_Beacon";
   offset = "3000 4000";                                      
   onInitializedFunc[0] = "AddToHealthCallbackSet DefendPropSet";
   objectFuncs["Spawn", 0]   = "AddDefendMarker true"; 
   objectFuncs["Spawn", 1] = "addToTrackingSet defendPropSet"; 
   objectFuncs["Spawn", 2]   = "QAI_AddToSet defendPropSet";  
}; 

new ScriptGroup(MO_Defend_Attackers : MO_Ships)
{ 
   offset = "8000 10000"; //far away to you can intercept              
   refObjectName = "REF_DefendCluster";
   objectFuncs["Spawn", 0]   = "QAI_AddToSet Defend_AttackerSet"; 
   objectFuncs["Spawn", 1]   = "AddTargetMarker";    
   onInitializedFunc[0] = "AddToHealthCallbackSet Defend_AttackerSet";                                   
}; 










