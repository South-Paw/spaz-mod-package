////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 08
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_08 : ArenaChallengeLadder_Base)
{
   ladderName = "Expert Ladder";
   ladderDescription = "This is zombie country folks.  This tournament will challenge your ability to deal with the infection.";
   minDeployStarLevel = 65; //the max level to use here should be 65.  
   sector4Only = true; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_08A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_08B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_08C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_08D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_08E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_08A : BountyBase)
{      
   title = "Expert Arena Event A";  
   description = "Something familiar.  A basic Boomerang on Boomerang fight, but he's a zombie!";
   
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
   TechLevels_0 = "7 10 7 7 7";
   TechLevels_1 = "7 9 7 7 7";
   TechLevels_2 = "7 8 7 7 7";
   
   DifficultyDesc[0]  = "You have a great tech advantage.";
   DifficultyDesc[1]  = "You have a good tech advantage.";
   DifficultyDesc[2]  = "You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "BoomerangShip";  //Bronze
   PlayerShipInfo_1 = "BoomerangShip";  //Silver
   PlayerShipInfo_2 = "BoomerangShip";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "ZombieKiller";
         shipDesignWL = "BoomerangShip 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_08B : BountyBase)
{      
   title = "Expert Arena Event B";  
   description = "Don't get infected!  You are up against breeder ships.  Don't take too long or you'll get overwhelmed.";
   
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
   TechLevels_0 = "7 9 7 7 7";
   TechLevels_1 = "7 8 7 7 7";
   TechLevels_2 = "7 7 7 7 7";
   
   DifficultyDesc[0]  = "You are a flying chainsaw that can soak a lot of shield damage.  You have a good tech advantage.";
   DifficultyDesc[1]  = "You are a flying chainsaw that can soak a lot of shield damage.  You have a slight tech advantage.";
   DifficultyDesc[2]  = "You have a basic Array ship.  No tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ArrayShip_Advanced_A";  //Bronze
   PlayerShipInfo_1 = "ArrayShip_Advanced";  //Silver
   PlayerShipInfo_2 = "ArrayShip_Basic";  //Gold
  
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_LeechShip 10";                                     
      };    
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_WartShip 10";                                     
      };         
   };
}; 

new ScriptGroup(Bounty_Ladder_08C : BountyBase)
{      
   title = "Expert Arena Event C";  
   description = "You're breaking my heart!  See if you can take down this zombie space station.  Watch out for those eggs.  You are under time pressure for this event.";
   
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
   TechLevels_0 = "4 9 4 4 4";
   TechLevels_1 = "4 9 4 4 4";
   TechLevels_2 = "4 8 4 4 4";
   
   DifficultyDesc[0]  = "Your RightHook is built for killing zombies.";
   DifficultyDesc[1]  = "Your RightHook is built for dealing damage.";
   DifficultyDesc[2]  = "You have a basic RightHook ship.";
   
   //Arena Ships
   PlayerShipInfo_0 = "RightHookShip_ArenaSpecial_01";  //Bronze
   PlayerShipInfo_1 = "RightHookShip_Basic_A";  //Silver
   PlayerShipInfo_2 = "RightHookShip_Basic";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "230000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 230"; 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Zombie";
         shipDesignWL = "HeartZombieStation 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_08D : BountyBase)
{      
   title = "Expert Arena Event D";  
   description = "Riot control!  You have a mixed bag of enemies, but you have a nice big ship.";
   
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
   TechLevels_0 = "7 8 7 7 7";
   TechLevels_1 = "7 7 7 7 7";
   TechLevels_2 = "7 6 7 7 7";
   
   DifficultyDesc[0]  = "You have a slight tech advantage.";
   DifficultyDesc[1]  = "Your tech level is evenly matched to your enemy.";
   DifficultyDesc[2]  = "Your enemies have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "FloraShip_Improved_A";  //Bronze
   PlayerShipInfo_1 = "FloraShip_Improved_A";  //Silver
   PlayerShipInfo_2 = "FloraShip_Improved_A";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_ScabShip 10";                                     
      };  
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Zombie";
         objectCount = 3;
         shipDesignWL = "Zombie_WartShip 10";                                     
      };            
   };
}; 

new ScriptGroup(Bounty_Ladder_08E : BountyBase)
{      
   title = "Expert Arena Event E";  
   description = "You are up against a crowd, but your ship is built for attacking many targets.  Remember, if your ship has critters on board, you will not be attacked by zombies.  Use this to your advantage.  You have a slight tech advantage.";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_08A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_08B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_08C"; 
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "7 9 7 7 7";
   TechLevels_1 = "7 9 7 7 7";
   TechLevels_2 = "7 8 7 7 7";
   
   DifficultyDesc[0]  = "You have no turret control, but you have insane firepower.  You have a good tech advantage.";
   DifficultyDesc[1]  = "Your Crawler ship has a good array of weapon types.  You have a good tech advantage.";
   DifficultyDesc[2]  = "You have a basic Crawler ship.  You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "CrawlerShip_Advanced_C";  //Bronze
   PlayerShipInfo_1 = "CrawlerShip_Basic_A";  //Silver
   PlayerShipInfo_2 = "CrawlerShip_Basic";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_BlightShip 10";                                     
      };    
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         factionOverride = "Zombie";
         shipDesignWL = "Zombie_WormShip 10";                                     
      };  
      new ScriptGroup(KillShips_03 : SHIP_ArenaBasic)
      { 
         offset = "6000";
         objectCount = 2;
         factionOverride = "Zombie"; 
         shipDesignWL = "Zombie_BlowfishShip 10";                                     
      }; 
      new ScriptGroup(KillShips_04 : SHIP_ArenaBasic)
      { 
         offset = "8000";
         objectCount = 2;
         factionOverride = "Zombie"; 
         shipDesignWL = "Zombie_WartShip 10";                                     
      };            
   };
}; 