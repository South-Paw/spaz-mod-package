////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 08
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_09 : ArenaChallengeLadder_Base)
{
   ladderName = "Master Ladder";
   ladderDescription = "Some really messed up events here.  See and do things in this tournament you would normally never experience.";
   minDeployStarLevel = 65; //the max level to use here should be 65.  
   sector4Only = true; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_09A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_09B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_09C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_09D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_09E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_09A : BountyBase)
{      
   title = "Master Arena Event A";  
   description = "Clash of the Capitals.  You have a huge drone ship, but you are up against 2 huge zombie ships and a pile of fodder.";
   
   //BRONZE REWARD
   Rewards["Complete_0", "Resource"]         = "Low"; 
   Rewards["Complete_0", "Bounty"]           = "Sub_Low";  
   //SILVER REWARD
   Rewards["Complete_1", "Resource"]         = "Med"; 
   Rewards["Complete_1", "Bounty"]           = "Sub_Med";  
   //GOLD REWARD
   Rewards["Complete_2", "Resource"]         = "High"; 
   Rewards["Complete_2", "Bounty"]           = "Sub_High";  
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "8 10 8 8 8";
   TechLevels_1 = "8 10 8 8 8";
   TechLevels_2 = "8 9 8 8 8";
   
   DifficultyDesc[0]  = "You have a good tech advantage.  You have an advanced SunSpot Ship.";
   DifficultyDesc[1]  = "You have a good tech advantage.  You have an improved SunSpot Ship.";
   DifficultyDesc[2]  = "You have a slight tech advantage.  You have a basic SunSpot Ship.";
   
   //Arena Ships
   PlayerShipInfo_0 = "SunspotShip_Advanced_B";  //Bronze
   PlayerShipInfo_1 = "SunspotShip_Improved";  //Silver
   PlayerShipInfo_2 = "SunspotShip_Basic";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_TumorShip 10";                                     
      };   
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_BigFootShip 10";                                     
      };  
      new ScriptGroup(KillShips_03 : SHIP_ArenaBasic)
      {  
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_BlightShip 10";                                     
      };
      new ScriptGroup(KillShips_04 : SHIP_ArenaBasic)
      {  
         //objectCount = 2;
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_WartShip 10";                                     
      };                
   };
}; 

new ScriptGroup(Bounty_Ladder_09B : BountyBase)
{      
   title = "Master Arena Event B";  
   description = "You are behind the wheel of your mothership.  Keep in mind, that big beam can shoot really far, but it takes a long time to charge.  You have some help to draw fire.";
   
   //BRONZE REWARD
   Rewards["Complete_0", "Resource"]         = "Low"; 
   Rewards["Complete_0", "Bounty"]           = "Sub_Low";  
   //SILVER REWARD
   Rewards["Complete_1", "Resource"]         = "Med"; 
   Rewards["Complete_1", "Bounty"]           = "Sub_Med";  
   //GOLD REWARD
   Rewards["Complete_2", "Resource"]         = "High"; 
   Rewards["Complete_2", "Bounty"]           = "Sub_High";  
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "8 9 8 8 8";
   TechLevels_1 = "8 8 8 8 8";
   TechLevels_2 = "8 7 8 8 8";
   
   DifficultyDesc[0]  = "You have a good tech advantage.";
   DifficultyDesc[1]  = "You have a slight tech advantage.";
   DifficultyDesc[2]  = "Your tech level is evenly matched to your enemy.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ClockworkStation_02";  //Bronze
   PlayerShipInfo_1 = "ClockworkStation_02";  //Silver
   PlayerShipInfo_2 = "ClockworkStation_02";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {   
      waveRelations[1, 0] = "Pirate Civ" SPC $FactionRelation_MYFACTION;
      waveRelations[1, 2] = "Terran Civ" SPC $FactionRelation_HATE;            
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "DysonStation_01 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         shipDesignWL = "ScoutShip_Basic 10";                                     
      };  
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         objectCount = 4;
         shipDesignWL = "CabShip_basic 10";  
         factionOverride = "Civ";                                   
      };                 
   };
}; 

new ScriptGroup(Bounty_Ladder_09C : BountyBase)
{      
   title = "Master Arena Event C";  
   description = "Suicide bombers away!  Just run away as fast as you can!";
   
   //BRONZE REWARD
   Rewards["Complete_0", "Resource"]         = "Low"; 
   Rewards["Complete_0", "Bounty"]           = "Sub_Low";  
   //SILVER REWARD
   Rewards["Complete_1", "Resource"]         = "Med"; 
   Rewards["Complete_1", "Bounty"]           = "Sub_Med";  
   //GOLD REWARD
   Rewards["Complete_2", "Resource"]         = "High"; 
   Rewards["Complete_2", "Bounty"]           = "Sub_High";  
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "8 7 8 8 8";
   TechLevels_1 = "8 6 8 8 8";
   TechLevels_2 = "8 5 8 8 8";
   
   DifficultyDesc[0]  = "Your enemies have a slight tech advantage.";
   DifficultyDesc[1]  = "Your enemies have a good tech advantage.";
   DifficultyDesc[2]  = "Your enemies have a high tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "DartShip_ArenaSpecial_01";  //Bronze
   PlayerShipInfo_1 = "DartShip_ArenaSpecial_01";  //Silver
   PlayerShipInfo_2 = "DartShip_ArenaSpecial_01";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      maxWaves = 10;        
      setHealthCallback["All", "enemy", 0] = "0 StartWaveName arenaSpawn";       
      setHealthCallback[10, "enemy", 0] = "0 StartWaveName QuestComplete";   
      
      waveTimedCallbacks[1, 0] = "0 QAI_SetAICommand BountyArenaShipSet SetTactic TP_Stance TP_SeekAndDestroy"; //dupe from base just for sanity
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand BountyArenaShipSet MoveTo REF_Player 0";
      waveTimedCallbacks[1, 2] = "0 QAI_SetAICommand BountyArenaShipSet SetTactic TP_Collect TP_NoCollect";
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {                                      
         instanceObjectWeightedList = "SpawnMyShip";
         objectCount = 2; 
         factionOverride = "Civ";                      
         refObjectName = "REF_Player";
         offset = "3000";
         objectFuncs["Spawn", 2] = "SM_09_nearPlayerCheck";
         shipDesignWL = "TugShip_SM_09 10";     
      };              
   };
}; 

new ScriptGroup(Bounty_Ladder_09D : BountyBase)
{      
   title = "Master Arena Event D";  
   description = "You have a support ship.  Keep your allies safe.  If they die, it's game over for you.  Shoot down those missiles as fast as you can.";
   
   //BRONZE REWARD
   Rewards["Complete_0", "Resource"]         = "Low"; 
   Rewards["Complete_0", "Bounty"]           = "Sub_Low";  
   //SILVER REWARD
   Rewards["Complete_1", "Resource"]         = "Med"; 
   Rewards["Complete_1", "Bounty"]           = "Sub_Med";  
   //GOLD REWARD
   Rewards["Complete_2", "Resource"]         = "High"; 
   Rewards["Complete_2", "Bounty"]           = "Sub_High";  
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "8 9 8 8 8";
   TechLevels_1 = "8 8 8 8 8";
   TechLevels_2 = "8 7 8 8 8";
   
   DifficultyDesc[0]  = "You have a slight tech advantage.";
   DifficultyDesc[1]  = "Your tech level is evenly matched to your enemy ";
   DifficultyDesc[2]  = "Your enemies have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ArrayShip_ArenaSpecial_01";  //Bronze
   PlayerShipInfo_1 = "ArrayShip_ArenaSpecial_01";  //Silver
   PlayerShipInfo_2 = "ArrayShip_ArenaSpecial_01";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {            
      waveRelations[1, 1] = "Pirate Terran" SPC $FactionRelation_MYFACTION;  
      waveRelations[1, 2] = "Civ Terran" SPC $FactionRelation_HATE;         
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 5;
         shipDesignWL = "MoleShip_Basic 10";   
         factionOverride = "Civ";                                  
      };   
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         objectCount = 3;
         shipDesignWL = "RangerShip_Basic 10";  
         factionOverride = "Terran"; 
         objectFuncs["Spawn", 1] = "addToTrackingSet arenaHelperSet";
         objectFuncs["Spawn", 2] = "AddDefendMarker";  
         objectFuncs["Death", 0] = "evalTrackingSetCount arenaHelperSet 0 StartWaveName QuestFail 0 noMoreHelp";      
                              
      };           
   };
}; 

new ScriptGroup(Bounty_Ladder_09E : BountyBase)
{      
   title = "Master Arena Event E";  
   description = "Everyone hates everyone!  Use this to your advantage.  Be the last ship standing.";
   
   //BRONZE REWARD
   Rewards["Complete_0", "Resource"]         = "Low"; 
   Rewards["Complete_0", "Bounty"]           = "Sub_Low";  
   //SILVER REWARD
   Rewards["Complete_1", "Resource"]         = "Med"; 
   Rewards["Complete_1", "Bounty"]           = "Sub_Med";  
   //GOLD REWARD
   Rewards["Complete_2", "Resource"]         = "High"; 
   Rewards["Complete_2", "Bounty"]           = "Sub_High"; 
   
   //spec rewards
   Rewards["Complete_0", "Spec"]           = "arenaSpec_09A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_09B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_09C";  
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "8 9 8 8 8";
   TechLevels_1 = "8 8 8 8 8";
   TechLevels_2 = "8 8 8 8 8";
   
   DifficultyDesc[0]  = "You have an advanced HammerHead ship and a slight tech advantage.";
   DifficultyDesc[1]  = "You have an improved HammerHead ship.";
   DifficultyDesc[2]  = "You have a basic HammerHead ship.";
   
   //Arena Ships
   PlayerShipInfo_0 = "HammerHeadShip_Advanced";  //Bronze
   PlayerShipInfo_1 = "HammerHeadShip_Improved";  //Silver
   PlayerShipInfo_2 = "HammerHeadShip_Basic";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {        
      waveRelations[1, 0] = "Pirate Civ" SPC $FactionRelation_HATE;
      waveRelations[1, 1] = "Pirate Terran" SPC $FactionRelation_HATE;  
      waveRelations[1, 2] = "Terran Civ" SPC $FactionRelation_HATE;          
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    

      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "terran";
         shipDesignWL = "StarCruiserShip_Basic 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         factionOverride = "civ";
         shipDesignWL = "FreighterShip_Basic 10";                                     
      }; 
      new ScriptGroup(KillShips_03 : SHIP_ArenaBasic)
      {  
         factionOverride = "zombie";
         shipDesignWL = "Zombie_BigFootShip 10";                                     
      };          
   };
}; 