
////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_01 : ArenaChallengeLadder_Base)
{
   ladderName = "Novice Ladder";
   ladderDescription = "A nice and easy tournament to hone your skills at dog fighting.";
   minDeployStarLevel = 6; //setting to 6 so it won't land in the first 2 tutorial stars  //the max level to use here should be 65.  
   sector4Only = false; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_01E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_01A : BountyBase)
{      
   title = "Novice Arena Event A";  
   description = "Let's see what you can do against the weakest ship in the known galaxy.  Plus you have a higher tech level than your opponent."; 
   
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
   TechLevels_0 = "1 2 1 1 1";
   TechLevels_1 = "1 2 1 1 1";
   TechLevels_2 = "1 2 1 1 1";
   
   DifficultyDesc[0]  = "A powerful Dart versus a ShortBus.  You should almost feel sorry for the other guy.";
   DifficultyDesc[1]  = "An average Dart versus 2 ShortBus ships.  You won't lose, unless you can't fly.";
   DifficultyDesc[2]  = "An average Dart versus 3 ShortBus ships.  You have a slight tech level advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "DartShip_Basic";  //Bronze
   PlayerShipInfo_1 = "DartShip";  //Silver
   PlayerShipInfo_2 = "DartShip";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };    
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "ShortBusShip 10";                                  
      };   
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "ShortBusShip 10";        
         SelectionData["BountyDiffRange"]     = "1 2";                               
      };   
      new ScriptGroup(KillShips_03 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "ShortBusShip 10";    
         SelectionData["BountyDiffRange"]     = "2 2";                              
      };             
   };   
}; 

new ScriptGroup(Bounty_Ladder_01B : BountyBase)
{      
   DifficultySettings_0 = $Difficulty_Expert;
   DifficultySettings_1 = $Difficulty_Expert;
   DifficultySettings_2 = $Difficulty_Insane;
   
   title = "Novice Arena Event B";  
   description = "Can you handle more than one ship at a time?  We hope so.  See if you can take on 2 Grasshopper ships.";
   
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
   TechLevels_0 = "1 4 1 1 1";
   TechLevels_1 = "1 4 1 1 1";
   TechLevels_2 = "1 5 1 1 1";
   
   DifficultyDesc[0]  = "An improved Dart design built for ripping down shields.  Just beware your reactor level.  You have a good tech advantage.  Watch out for fodder.";
   DifficultyDesc[1]  = "A basic Dart design, but the beams are easy to aim.  You have a good tech advantage.  Watch out for fodder.";
   DifficultyDesc[2]  = "A junker Dart design.  You don't do much damage, but that beam has some crazy range on it.  Try to shoot down incoming missiles.  You have a high tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "DartShip_Improved";  //Bronze
   PlayerShipInfo_1 = "DartShip_Basic";  //Silver
   PlayerShipInfo_2 = "DartShip";  //Gold
    
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };        
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         factionOverride = "Civ";
         shipDesignWL = "MoleShip 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "ShortBusShip 10";    
         SelectionData["BountyDiffRange"]     = "0 1";                              
      };               
   };
}; 

new ScriptGroup(Bounty_Ladder_01C : BountyBase)
{      
   title = "Novice Arena Event C";  
   description = "A little mixed bag of tricks, but you're bigger than them.  All 3 enemy ships are different.  Pick off the weaker targets first to avoid the gang beat down.";
   
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
   TechLevels_1 = "2 3 2 2 2";
   TechLevels_2 = "2 2 2 2 2";
   
   DifficultyDesc[0]  = "You are well endowed to deal with a few insects.  You have an improved cloaked Ranger design.  You have a good tech advantage.";
   DifficultyDesc[1]  = "An average ship versus a few undersized ships should be an even fight, right?  You have a slight tech advantage.";
   DifficultyDesc[2]  = "An average ship versus a few undersized ships should be an even fight, right?  You have no tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ScoutShip_Improved_D";  //Bronze
   PlayerShipInfo_1 = "ScoutShip_Basic";  //Silver
   PlayerShipInfo_2 = "ScoutShip_Basic";  //Gold
    
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "DartShip 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         factionOverride = "Civ";
         offset = "8000"; 
         shipDesignWL = "MoleShip 10";                                     
      };  
      new ScriptGroup(KillShips_03 : SHIP_ArenaBasic)
      {  
         offset = "12000"; 
         shipDesignWL = "ShortBusShip 10";                                     
      };              
   };
}; 

new ScriptGroup(Bounty_Ladder_01D : BountyBase)
{      
   title = "Novice Arena Event D";  
   description = "3 on 1!  Make good use of your ships here.  You can't afford to spray bullets everywhere.  Your Colt has great firepower and a tech advantage.  Use it wisely.";
   
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
   TechLevels_0 = "1 5 1 1 1";
   TechLevels_1 = "1 5 1 1 1";
   TechLevels_2 = "1 5 1 1 1";
   
   DifficultyDesc[0]  = "You are a cloaked shield killer.  Take your time, and strike when the time is right.  Make a discreet exit or they will spot you.  You have a good tech advantage.";
   DifficultyDesc[1]  = "You might have a hard time landing your cannon shot.  They do great damage, but you have to pitch them well.  You have a good tech advantage.";
   DifficultyDesc[2]  = "You have to be a bullet god to land your shots.  You have surplus cannons which are not suited to hit high speed targets.  You have a good tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ColtShip_Improved_B";  //Bronze
   PlayerShipInfo_1 = "ColtShip_Basic";  //Silver
   PlayerShipInfo_2 = "ColtShip";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 3;
         shipDesignWL = "RangerShip 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_01E : BountyBase)
{      
   title = "Novice Arena Event E";  
   description = "Let's see if you can handle a crowd of 8 ShortBus Ships.  Don't let them gang up on you.  You are under time pressure for this event.";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_01A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_01B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_01C"; 

   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "2 5 2 2 2";
   TechLevels_1 = "2 5 2 2 2";
   TechLevels_2 = "2 3 2 2 2";
   
   DifficultyDesc[0]  = "Keep your distance and you should have no troubles.  Use your missiles.  You have a high tech advantage.";
   DifficultyDesc[1]  = "You don't have the best weapons, but if you stay at range you should be able to handle the mob.  You have a high tech advantage.";
   DifficultyDesc[2]  = "Beware!  Your ship isn't much better than thiers.  Try to seperate your targets.  Divide and conquer.  You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ScoutShip_Basic";  //Bronze
   PlayerShipInfo_1 = "ScoutShip";  //Silver
   PlayerShipInfo_2 = "DartShip";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "180000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 180"; 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 3;
         shipDesignWL = "ShortBusShip 10";                                     
      };   
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 3;
         shipDesignWL = "ShortBusShip 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         shipDesignWL = "ShortBusShip 10";                                     
      };             
   };
}; 