////////////////////////////////////////////////////////////////////////////////
//ESCORT BASE
////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////
//ESCORT WAVE SETUP
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Escort_WaveBasic)
{                                      
   maxWaves = 1;            
   waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand EscortShipSet SetTactic TP_Stance TP_Escorted";
   waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand EscortWarpOutSet SetTactic TP_Retreat TP_RetreatOn";
   waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand EscortAttackerSet Attack EscortShipSet";
   waveTimedCallbacks[1, 3] = "0 QAI_SetAICommand EscortAttackerSet SetTactic TP_Stance TP_SeekAndDestroy";              
}; 

////////////////////////////////////////////////////////////////////////////////
//ESCORT OBJECTS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(MO_Escort_Ship : MO_Ships)
{                                   
   instanceObjectWeightedList = "HeavyShips 10";
   offset = 0;  
   objectCount = "1 1";
   factionOverride = "Civ";                     
   refObjectName = "";
   
   objectFuncs["Spawn", 0] = "AddDefendMarker";           
   objectFuncs["Spawn", 1] = "QAI_AddToSet EscortShipSet"; 
   objectFuncs["Spawn", 2] = "addToTrackingSet EscortShipSet";  
   objectFuncs["Spawn", 3] = "leashToPlayer 1000";    
   objectFuncs["Spawn", 4] = "SetAngerMult 0.3";   
        
   objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail";  
   
   objectFuncs["WarpOut", 0] = "evalTrackingSetCount EscortShipSet 0 StartWaveName questComplete"; 
   
   deviceBitMatching = bitInverse($SST_DEVICE_CLOAK); //don't pick cloaked ships
}; 

new ScriptGroup(MO_Follower_Ship : MO_Ships)
{                                   
   instanceObjectWeightedList = "HeavyShips 10";
   offset = 0;  
   objectCount = "1 1";
   factionOverride = "Civ";                     
   refObjectName = "";
   
   objectFuncs["Spawn", 0] = "AddDefendMarker";           
   objectFuncs["Spawn", 1] = "QAI_AddToSet EscortShipSet"; 
   objectFuncs["Spawn", 2] = "addToTrackingSet EscortShipSet"; 
   objectFuncs["Spawn", 3] = "leashToPlayer 1000";  
   objectFuncs["Spawn", 4] = "SetAngerMult 0.3";      
        
   objectFuncs["Death", 0] = "CallInstanceFunc StartWaveName QuestFail";  
   
   objectFuncs["WarpOut", 0] = "evalTrackingSetCount EscortShipSet 0 StartWaveName questComplete"; 
   
   deviceBitMatching = bitInverse($SST_DEVICE_CLOAK); //don't pick cloaked ships
}; 

new ScriptGroup(MO_Escort_DestinationTrig : MO_Trigger) 
{                                      
   triggerFuncs[0] = "ObjectFunc 1 EscortShipSet QAI_AddToSet EscortWarpOutSet";

   refObjectName = "REF_EscortOutProp";
   objectFuncs["Spawn", 0] = "AddGoToMarker"; 
};



