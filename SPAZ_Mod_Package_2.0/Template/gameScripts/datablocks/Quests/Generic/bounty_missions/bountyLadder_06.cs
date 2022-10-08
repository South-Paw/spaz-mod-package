////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 06
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_06 : ArenaChallengeLadder_Base)
{
   ladderName = "Improved Ladder";
   ladderDescription = "How good are you at using odd ball ships?  These ships use some of the more unorthodox weapons and components.  Learn them and adapt to survive.";
   minDeployStarLevel = 55; //the max level to use here should be 65.  
   sector4Only = false; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_06A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_06B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_06C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_06D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_06E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_06A : BountyBase)
{      
   title = "Improved Arena Event A";  
   description = "Use your cloak or die!  Strike when the time is right and watch your reactor level.  Give your cloak a chance to recharge between attacks.";
   
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
   TechLevels_0 = "5 6 5 5 5";
   TechLevels_1 = "5 5 5 5 5";
   TechLevels_2 = "5 4 5 5 5";
   
   DifficultyDesc[0]  = "You have a slight tech advantage.";
   DifficultyDesc[1]  = "Your tech level is evenly matched to your enemy ";
   DifficultyDesc[2]  = "Your enemies have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "GimpShip_Advanced_C";  //Bronze
   PlayerShipInfo_1 = "GimpShip_Advanced_C";  //Silver
   PlayerShipInfo_2 = "GimpShip_Advanced_C";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 1;
         shipDesignWL = "GimpShip 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 1;
         shipDesignWL = "GimpShip 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 1;
         shipDesignWL = "HatchetShip_Basic 10";                                     
      };                 
   };
}; 

new ScriptGroup(Bounty_Ladder_06B : BountyBase)
{      
   title = "Improved Arena Event B";  
   description = "You are up against 2 weird ships.  Learn their systems and exploit them.";
   
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
   TechLevels_1 = "5 7 5 5 5";
   TechLevels_2 = "5 7 5 5 5";
   
   DifficultyDesc[0]  = "Cloaked with a deployable turret.  You don't really have to do the heavy lifting.  You have a good tech advantage.";
   DifficultyDesc[1]  = "Slow them down to land your shots.  You have a good tech advantage.";
   DifficultyDesc[2]  = "You have some really primitive equipment.  Make do with what you have.  You have a good tech advantage."; 
   
   //Arena Ships
   PlayerShipInfo_0 = "GullShip_Advanced_B";  //Bronze
   PlayerShipInfo_1 = "GullShip_Improved_A";  //Silver
   PlayerShipInfo_2 = "GullShip_Basic_A";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Civ";
         shipDesignWL = "YachtShip_Improved 10";                                     
      };  
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "RangerShip_improved_E 10";                                     
      };
   };
}; 

new ScriptGroup(Bounty_Ladder_06C : BountyBase)
{      
   title = "Improved Arena Event C";  
   description = "Mine wars!  Just watch your step.  Those TurtleHead ships will make quick work of your mines, so watch out.";
   
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
   TechLevels_1 = "5 7 5 5 5";
   TechLevels_2 = "5 6 5 5 5";
   
   DifficultyDesc[0]  = "You have an Advanced Helix design.  You have a good tech advantage.";
   DifficultyDesc[1]  = "You have an Improved Helix design.  You have a good tech advantage.";
   DifficultyDesc[2]  = "You have a Basic Helix design.  You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "HelixShip_Advanced_B";  //Bronze
   PlayerShipInfo_1 = "HelixShip_Improved_C";  //Silver
   PlayerShipInfo_2 = "HelixShip_Basic_B";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Civ";
         objectCount = 1;
         shipDesignWL = "PounderShip_Basic_A 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         factionOverride = "Civ";
         objectCount = 2;
         shipDesignWL = "GirlScoutShip_Advanced 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_06D : BountyBase)
{      
   title = "Improved Arena Event D";  
   description = "Crew wars!  You are slighly outmatched, but your brain is bigger.  Use what little crew you have wisely.  No free refills.";
   
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
   TechLevels_0 = "5 8 5 5 5";
   TechLevels_1 = "5 7 5 5 5";
   TechLevels_2 = "5 6 5 5 5";
   
   DifficultyDesc[0]  = "Your have lots of equipment to use.  You have a high tech advantage.";
   DifficultyDesc[1]  = "Your have lots of equipment to use.  You have a good tech advantage.";
   DifficultyDesc[2]  = "Your ship does not have the best equipment.  You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "BigBusShip_ArenaSpecial_01";  //Bronze
   PlayerShipInfo_1 = "BigBusShip_ArenaSpecial_01";  //Silver
   PlayerShipInfo_2 = "BigBusShip_Improved_B";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Civ";
         shipDesignWL = "BigBusShip_Advanced 10";                                     
      };  
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Civ";
         shipDesignWL = "YachtShip_Improved_A 10";                                     
      };            
   };
}; 

new ScriptGroup(Bounty_Ladder_06E : BountyBase)
{      
   title = "Improved Arena Event E";  
   description = "You're piloting a slow turning pig while being swarmed by smaller ships.  Try not to miss your shots of opportunity.";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_06A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_06B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_06C";   
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "5 5 5 5 5";
   TechLevels_1 = "5 5 5 5 5";
   TechLevels_2 = "5 5 5 5 5";
   
   DifficultyDesc[0]  = "Your StarCruiser has some exceptional weaponry.";
   DifficultyDesc[1]  = "Your StarCruiser is fairly basic.";
   DifficultyDesc[2]  = "You have the most budget looking StarCruiser.";
   
   //Arena Ships
   PlayerShipInfo_0 = "StarCruiserShip_Basic_A";  //Bronze
   PlayerShipInfo_1 = "StarCruiserShip_Basic";  //Silver
   PlayerShipInfo_2 = "StarCruiserShip";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         offset = "6500";
         factionOverride = "Civ";
         objectCount = 2;
         shipDesignWL = "GirlScoutShip_Basic 10";                                     
      };   
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         offset = "8000";
         factionOverride = "Civ";
         objectCount = 2;
         shipDesignWL = "GirlScoutShip_Basic 10";                                     
      };  
      new ScriptGroup(KillShips_03 : SHIP_ArenaBasic)
      {  
         offset = "10000";
         factionOverride = "Civ";
         objectCount = 2;
         shipDesignWL = "GirlScoutShip_Basic 10";                                     
      };           
   };
}; 