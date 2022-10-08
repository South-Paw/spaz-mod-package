////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 06
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_07 : ArenaChallengeLadder_Base)
{
   ladderName = "Veteran Ladder";
   ladderDescription = "This tournament is about advanced dog fighting.  Use your small, yet fast, ships to get the job done.";
   minDeployStarLevel = 65; //the max level to use here should be 65.  
   sector4Only = false; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_07A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_07B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_07C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_07D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_07E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_07A : BountyBase)
{      
   title = "Veteran Arena Event A";  
   description = "Where did they go?  Your enemies are cloaked.  You have a bit of help to spot your targets.  You are under time pressure for this event.";
   
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
   TechLevels_0 = "5 7 5 6 5";
   TechLevels_1 = "5 7 5 6 5";
   TechLevels_2 = "5 7 5 6 5";
   
   DifficultyDesc[0]  = "You are piloting an improved Ranger for this event.  You have a good tech advantage.";
   DifficultyDesc[1]  = "You are piloting a basic Ranger for this event.  You have a good tech advantage.";
   DifficultyDesc[2]  = "You are piloting a basic TurtleHead for this event.  You have a good tech advantage."; 
   
   //Arena Ships
   PlayerShipInfo_0 = "ScoutShip_Improved_D";  //Bronze
   PlayerShipInfo_1 = "ScoutShip_Basic";  //Silver
   PlayerShipInfo_2 = "GirlScoutShip_Basic";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "60000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 60"; 
    
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   { 
      waveRelations[1, 0] = "Pirate Civ" SPC $FactionRelation_MYFACTION;
      waveRelations[1, 2] = "Terran Civ" SPC $FactionRelation_HATE;       
   };      
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "RangerShip_improved_D 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : KillShips_01)
      {                                     
      };     
      new ScriptGroup(KillShips_03 : KillShips_01)
      {                                    
      };
      new ScriptGroup(KillShips_04 : KillShips_01)
      {                                    
      };  
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         shipDesignWL = "CabShip_basic 10";  
         factionOverride = "Civ";                                   
      };                  
   };
}; 

new ScriptGroup(Bounty_Ladder_07B : BountyBase)
{      
   title = "Veteran Arena Event B";  
   description = "It's all in the reflexes.  Your turret should do all the work while you focus on dodging.  Just stop long enough for your weapons to zero in.";
   
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
   TechLevels_0 = "5 7 5 5 5";
   TechLevels_1 = "5 6 5 5 5";
   TechLevels_2 = "5 5 5 5 5";
   
   DifficultyDesc[0]  = "You have a good tech advantage.";
   DifficultyDesc[1]  = "You have a slight tech advantage.";
   DifficultyDesc[2]  = "Your tech level is evenly matched to your enemy.";
   
   //Arena Ships
   PlayerShipInfo_0 = "RetinaShip_advanced";  //Bronze
   PlayerShipInfo_1 = "RetinaShip_advanced";  //Silver
   PlayerShipInfo_2 = "RetinaShip_advanced";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         shipDesignWL = "MoleShip 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_07C : BountyBase)
{      
   title = "Veteran Arena Event C";  
   description = "Death by 1000 paper cuts.  You have a huge tech advantage, but they have a swarm.";
   
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
   TechLevels_0 = "1 9 1 1 1";
   TechLevels_1 = "1 8 1 1 1";
   TechLevels_2 = "1 8 1 1 1";
   
   DifficultyDesc[0]  = "You have an Advanced Hatchet Ship and an even higher tech advantage.";
   DifficultyDesc[1]  = "You have an Improved Hatchet Ship.";
   DifficultyDesc[2]  = "You have a Basic Hatchet Ship.";
   
   //Arena Ships
   PlayerShipInfo_0 = "HatchetShip_Advanced_A";  //Bronze
   PlayerShipInfo_1 = "HatchetShip_Improved_A";  //Silver
   PlayerShipInfo_2 = "HatchetShip_Basic";  //Gold
    
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 7;
         shipDesignWL = "RangerShip 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_07D : BountyBase)
{      
   title = "Veteran Arena Event D";  
   description = "Can you take down the giant.  You have a massive tech advantage, but a small class ship.  You have some help to deal with the drones.";
   
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
   TechLevels_0 = "2 8 2 6 2";
   TechLevels_1 = "2 8 2 6 2";
   TechLevels_2 = "2 8 2 6 2";
   
   DifficultyDesc[0]  = "You have a advanced Colt ship.";
   DifficultyDesc[1]  = "You have a basic Colt ship.";
   DifficultyDesc[2]  = "You have a surplus Colt ship.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ColtShip_Advanced_C";  //Bronze
   PlayerShipInfo_1 = "ColtShip_Basic";  //Silver
   PlayerShipInfo_2 = "ColtShip";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {  
      waveRelations[1, 0] = "Pirate Civ" SPC $FactionRelation_MYFACTION; 
      waveRelations[1, 2] = "Terran Civ" SPC $FactionRelation_HATE;                  
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "SunspotShip 10";                                     
      }; 
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         shipDesignWL = "ArrayShip_ArenaSpecial_01 10";  
         factionOverride = "Civ";                                   
      };               
   };
}; 

new ScriptGroup(Bounty_Ladder_07E : BountyBase)
{      
   title = "Veteran Arena Event E";  
   description = "Can you fight with your hands tied?  Your enemy has gravity weapons, which will make it hard for you to aim.";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_07A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_07B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_07C";  
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "6 8 6 6 6";
   TechLevels_1 = "6 7 6 6 6";
   TechLevels_2 = "6 7 6 6 6";
   
   DifficultyDesc[0]  = "You won't be shooting down any of those missiles, but you pack a punch.  You have a great tech advantage.";
   DifficultyDesc[1]  = "You'll shoot down the odd incoming missile.  You have a slight tech advantage.";
   DifficultyDesc[2]  = "You have a tiny Gopher Ship.  You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ScoutShip_Advanced_A";  //Bronze
   PlayerShipInfo_1 = "GirlScoutShip_Advanced";  //Silver
   PlayerShipInfo_2 = "CabShip_ArenaSpecial_01";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 3;
         shipDesignWL = "RangerShip_advanced_B 10";                                     
      };             
   };
}; 