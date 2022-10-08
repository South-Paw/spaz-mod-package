////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 08
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_10 : ArenaChallengeLadder_Base)
{
   ladderName = "Legendary Ladder";
   ladderDescription = "This is the final tournament.  Let's see how you handle these crazy Bounty Hunter ships.";
   minDeployStarLevel = 65; //the max level to use here should be 65.  
   sector4Only = true; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_10A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_10B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_10C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_10D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_10E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_10A : BountyBase)
{      
   title = "Legendary Arena Event A";  
   description = "2 on 2 Bounty Hunter fight.  You are teamed up with another bounty hunter versus a couple of zombie bounty hunters.";
   
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
   TechLevels_0 = "8 10 8 8 9";
   TechLevels_1 = "8 9 8 8 9";
   TechLevels_2 = "8 8 8 8 9";
   
   DifficultyDesc[0]  = "You have a good tech advantage.  You have an advanced ship.";
   DifficultyDesc[1]  = "You have a slight tech advantage.  You have an advanced ship.";
   DifficultyDesc[2]  = "Your tech level is evenly matched to your enemy.  You have an improved ship.";
   
   //Arena Ships
   PlayerShipInfo_0 = "BountyShip_Tiny_01_ADVANCED_E";  //Bronze
   PlayerShipInfo_1 = "BountyShip_Tiny_01_ADVANCED_F";  //Silver
   PlayerShipInfo_2 = "BountyShip_Tiny_01_IMPROVED_C";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   { 
      waveRelations[1, 5] = "Pirate Bounty" SPC $FactionRelation_MYFACTION;             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         factionOverride = "ZombieKiller";
         shipDesignWL = "BountyShip_Tiny_02_ADVANCED_A 10";                         
      };    
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman) 
      {  
         factionOverride = "Bounty";
         shipDesignWL = "BountyShip_Tiny_02_ADVANCED_B 10";                                       
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_10B : BountyBase)
{      
   title = "Legendary Arena Event B";  
   description = "2 on 1 Bounty Hunter fight.  Can you stand being ganged up on?";
   
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
   TechLevels_0 = "9 10 9 9 9";
   TechLevels_1 = "9 9 9 9 9";
   TechLevels_2 = "9 9 9 9 9";
   
   DifficultyDesc[0]  = "You have a slight tech advantage.  You have an advanced ship.";
   DifficultyDesc[1]  = "Your tech level is evenly matched to your enemy.  You have an improved ship.";
   DifficultyDesc[2]  = "Your tech level is evenly matched to your enemy.";
   
   //Arena Ships
   PlayerShipInfo_0 = "BountyShip_Small_01_ADVANCED_D";  //Bronze
   PlayerShipInfo_1 = "BountyShip_Small_01_ArenaSpecial_01";  //Silver
   PlayerShipInfo_2 = "BountyShip_Small_01_ArenaSpecial_02";  //Gold  
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         factionOverride = "Bounty";
         shipDesignWL = "BountyShip_Small_02_ADVANCED_D 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_10C : BountyBase)
{      
   title = "Legendary Arena Event C";  
   description = "1 on 1 Bounty Hunter fight with medium class ships.";
   
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
   TechLevels_1 = "8 9 8 8 8";
   TechLevels_2 = "8 9 8 8 8";
   
   DifficultyDesc[0]  = "You have a good tech advantage.  You have an advanced ship with lots of firepower.";
   DifficultyDesc[1]  = "You have a slight tech advantage.  You have an advanced ship.";
   DifficultyDesc[2]  = "You have a slight tech advantage.  You have an improved ship.";
   
   //Arena Ships
   PlayerShipInfo_0 = "BountyShip_Medium_02_ADVANCED_A";  //Bronze
   PlayerShipInfo_1 = "BountyShip_Medium_02_ADVANCED_C";  //Silver
   PlayerShipInfo_2 = "BountyShip_Medium_02_IMPROVED_B";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Bounty";
         shipDesignWL = "BountyShip_Medium_02_ADVANCED_B 10";                                     
      };            
   };
}; 

new ScriptGroup(Bounty_Ladder_10D : BountyBase)
{      
   title = "Legendary Arena Event D";  
   description = "A Bounty Hunter fight with large ships.  The enemy has a bit of fodder.";
   
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
   TechLevels_0 = "9 10 9 9 9";
   TechLevels_1 = "9 9 9 9 9";
   TechLevels_2 = "9 9 9 9 9";
   
   DifficultyDesc[0]  = "You have a slight tech advantage.  You have an improved ship.";
   DifficultyDesc[1]  = "Your tech level is evenly matched to your enemy.  You have an improved ship.";
   DifficultyDesc[2]  = "Your tech level is evenly matched to your enemy.  Your ship is standard.";
   
   //Arena Ships
   PlayerShipInfo_0 = "BountyShip_Large_02_IMPROVED_C";  //Bronze
   PlayerShipInfo_1 = "BountyShip_Large_02_IMPROVED_A";  //Silver
   PlayerShipInfo_2 = "BountyShip_Large_01_BASIC_A";  //Gold 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Bounty";
         shipDesignWL = "BountyShip_Large_02_ADVANCED_B 10";                                     
      };
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         factionOverride = "Bounty";
         shipDesignWL = "BountyShip_Tiny_02_ADVANCED_A 10";                         
      };               
   };
}; 

new ScriptGroup(Bounty_Ladder_10E : BountyBase)
{      
   title = "Legendary Arena Event E";  
   description = "2 Huge ships going at it.  Your enemy has a bit of fodder.";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_10A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_10B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_10C";   
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "8 9 8 8 8";
   TechLevels_1 = "8 9 8 8 8";
   TechLevels_2 = "8 8 8 8 8";
   
   DifficultyDesc[0]  = "You have a slight tech advantage.  You have an advanced ship.";
   DifficultyDesc[1]  = "You have a slight tech advantage.  You have an improved ship.";
   DifficultyDesc[2]  = "You have no tech advantage.  You have an improved ship.";
   
   //Arena Ships
   PlayerShipInfo_0 = "BountyShip_Huge_02_ADVANCED_C";  //Bronze
   PlayerShipInfo_1 = "BountyShip_Huge_02_IMPROVED_B";  //Silver
   PlayerShipInfo_2 = "BountyShip_Huge_02_IMPROVED_B";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Bounty";
         shipDesignWL = "BountyShip_Huge_01_ADVANCED_B 10";                                     
      };
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 4;
         factionOverride = "Bounty";
         shipDesignWL = "BountyShip_Tiny_02_BASIC_A 10";                                     
      };              
   };
}; 