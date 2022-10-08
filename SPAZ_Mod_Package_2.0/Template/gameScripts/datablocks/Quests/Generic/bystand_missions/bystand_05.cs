
///////////////////////////////////////////////////////////
// BYSTAND 05
///////////////////////////////////////////////////////////

new ScriptGroup(Quest_Bystand_05 : QuestBase_Bystand)
{
   addToDatabase = true;  //Important 
       
   title = "COMET SPOTTED";  
   description = "A comet has been detected in the area.  It may contain valuable resources and scientific data.  NOTE: Comets are extremely dangerous and can easily damage the largest of ships.";
  
   rarity = "Uncommon"; 
   DeployData["Infrastructure"] = "Any"; //Any, Mining, Science, Colony
  
   initialWaves = "WAVE_SetupComet MADD_WAVE";
   
   //////////////////////////////////
   //BASIC MISSION
   //////////////////////////////////

   new ScriptGroup(WAVE_SetupComet)
   {
      maxWaves = 1; 
      WaveMissionTrackers["active", 1] = "0"; 
      new ScriptGroup(REF_CometArea : MO_Trigger) 
      {                              
      }; 
      new ScriptGroup("REF_comet" : MO_Props) 
      {
         instanceObjectWeightedList = "AsteroidCometMassive";
         offset = "10000 10000";      
         objectCount = "1 1";           
         refObjectName = "REF_Beacon";
         mountRefObjectNames = "REF_CometArea"; 
         objectFuncs["Spawn", 0] = "destroyAtRange 500000"; //get rid of the thing if it goes too far
         objectFuncs["Spawn", 1] = "ImpulseToRef Ref_Beacon 400"; 
         objectFuncs["Spawn", 2] = "AddPoiMarker"; 
      }; 
      new ScriptGroup("REF_comet_bits" : MO_Props) 
      {
         instanceObjectWeightedList = "AsteroidComet";
         offset = "0 0";      
         objectCount = "4 5";       
         refObjectName = "REF_comet";
         objectFuncs["Spawn", 0] = "ImpulseToRef REF_Beacon 380";  
         objectFuncs["Spawn", 1] = "destroyAtRange 500000"; //get rid of the thing if it goes too far
      }; 
   }; 
   
   //////////////////////////////////
   //MISSION ADDS
   //////////////////////////////////
   new ScriptGroup(MADD_WAVE : MADD_WaveBasic)
   {   
      new ScriptGroup(CIV_Ambient : MADD_CIV_Ambient)
      {                  
      }; 
      new ScriptGroup(UTA_Ambient : MADD_UTA_Ambient)
      {                   
      };   
   };
};