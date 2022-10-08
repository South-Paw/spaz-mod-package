////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 02
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_02 : ArenaChallengeLadder_Base)
{
   ladderName = "Amateur Ladder";
   ladderDescription = "A favorable tournament with some beefy sized ships.  You have more on board weapons to think about here.  Know your systems and use them.";
   minDeployStarLevel = 10; //the max level to use here should be 65.  
   sector4Only = false; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_02A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_02B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_02C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_02D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_02E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_02A : BountyBase)
{      
   title = "Amateur Arena Event A";  
   description = "UFO?  Where?  This event is all about the Saucer Designs.  The enemy has some cannon fodder just to waste your time.";
   
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
   TechLevels_0 = "3 5 3 3 3";
   TechLevels_1 = "3 5 3 3 3";
   TechLevels_2 = "3 4 3 3 3";
   
   DifficultyDesc[0]  = "You have a better ship and higher tech level.  Should be easy going for this entry event.";
   DifficultyDesc[1]  = "An even match of ships, but your tech is higher.";
   DifficultyDesc[2]  = "An even match of ships.  You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "SaucerShip_Basic_B";  //Bronze
   PlayerShipInfo_1 = "SaucerShip_Basic";  //Silver
   PlayerShipInfo_2 = "SaucerShip_Basic";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "SaucerShip_Basic 10";                                     
      };   
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 4;
         shipDesignWL = "ShortBusShip 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_02B : BountyBase)
{      
   title = "Amateur Arena Event B";  
   description = "Watch out for enemy bombers!  They pack a punch, but if you can shoot it out of the sky, you have a nice window of opportunity.  Consider dumping your armor if you can't catch up.  Beware the wingmen.";
   
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
   TechLevels_0 = "2 4 2 2 2";
   TechLevels_1 = "2 4 2 2 2";
   TechLevels_2 = "2 4 2 2 2";
   
   DifficultyDesc[0]  = "Your sub-systems should take care of those nasty bombs.  You have a high tech advantage.";
   DifficultyDesc[1]  = "Some of your components are useless in this fight.  Use what you can to win.  You have a high tech advantage.";
   DifficultyDesc[2]  = "Your ship is junk.  Use superior tactics to win.  You have a high tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "MuleShip_ArenaSpecial_01";  //Bronze
   PlayerShipInfo_1 = "MuleShip_ArenaSpecial_02";  //Silver
   PlayerShipInfo_2 = "MuleShip_ArenaSpecial_03";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "HelixShip_Basic 10";                                     
      };  
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         shipDesignWL = "RangerShip 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_02C : BountyBase)
{      
   title = "Amateur Arena Event C";  
   description = "Now you're the bomber pilot!  It's fire versus fire here.  Just try not to blow yourself up too.  Tech levels are high for both sides!  Watch out for fodder.";
   
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
   TechLevels_0 = "6 8 6 6 6";
   TechLevels_1 = "6 7 6 6 6";
   TechLevels_2 = "6 6 6 6 6";
   
   DifficultyDesc[0]  = "Ion bombs are potent if used correctly.  You'll still need to get in close for the kill.  You have a good tech advantage.";
   DifficultyDesc[1]  = "A powerful and explosive combination.  Keep your distance.  You have a slight tech advantage.";
   DifficultyDesc[2]  = "A powerful and explosive combination.  Keep your distance.  You have no tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "HelixShip_Improved";  //Bronze
   PlayerShipInfo_1 = "HelixShip_Basic";  //Silver
   PlayerShipInfo_2 = "HelixShip_Basic";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "HelixShip_Basic 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         factionOverride = "Civ";
         shipDesignWL = "CabShip 10";                                     
      };              
   };
}; 

new ScriptGroup(Bounty_Ladder_02D : BountyBase)
{      
   title = "Amateur Arena Event D";  
   description = "Big brother always beats me up!  Your ship is smaller, but it has a much higher tech level.  Use your cloak or enemy drones will rip you apart.";
   
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
   TechLevels_0 = "2 6 2 2 2";
   TechLevels_1 = "2 6 2 2 2";
   TechLevels_2 = "2 5 2 2 2";
   
   DifficultyDesc[0]  = "A medium versus a large.  Can you do it?  I think so.  You have a great array of weapons.  You have a supreme tech advantage.";
   DifficultyDesc[1]  = "A small versus a large.  Your sub systems should make short work of enemy drones.  Take him out at the knees and go in for the kill.  You have a supreme tech advantage.";
   DifficultyDesc[2]  = "A small versus a large.  I feel sorry for you.  Hit and runs are the only option.  Take your time.  You have a high tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ArrayShip_ArenaSpecial_02";  //Bronze
   PlayerShipInfo_1 = "GirlScoutShip_Improved_C";  //Silver  
   PlayerShipInfo_2 = "ColtShip_Improved_B";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "BigBrotherShip_Basic 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_02E : BountyBase)
{      
   title = "Amateur Arena Event E";  
   description = "You have the big guns now, but you are vastly outnumbered and everyone has a higher tech level than you.  Single out your targtes.  Be mindful of your reactor level, turret rotation, and armor plates.";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_02A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_02B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_02C";   
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "5 4 5 5 5";
   TechLevels_1 = "5 4 5 5 5";
   TechLevels_2 = "6 4 6 6 6";
   
   DifficultyDesc[0]  = "Not only are you massive, but you have nice weapons on that HammerHead.";
   DifficultyDesc[1]  = "Your a bully, but they are many.  Your HammerHead has surplus equipment.";
   DifficultyDesc[2]  = "Enemies have much higher tech level!  Your HammerHead has surplus equipment.  You can't afford to miss any shots here.";
   
   //Arena Ships
   PlayerShipInfo_0 = "HammerHeadShip_Basic";  //Bronze
   PlayerShipInfo_1 = "HammerHeadShip";  //Silver
   PlayerShipInfo_2 = "HammerHeadShip";  //Gold
    
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };      
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 3;
         shipDesignWL = "DartShip 10";                                     
      };  
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         factionOverride = "Civ";
         objectCount = 3;
         shipDesignWL = "RetinaShip_basic 10";                                     
      };              
   };
}; 