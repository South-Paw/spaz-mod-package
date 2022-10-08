////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 04
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_04 : ArenaChallengeLadder_Base)
{
   ladderName = "Adept Ladder";
   ladderDescription = "This tournament is all about stations.  Fight them, command them, you`ll do it all.  All these events are under time pressure.";
   minDeployStarLevel = 35; //the max level to use here should be 65.  
   sector4Only = false; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_04A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_04B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_04C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_04D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_04E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_04A : BountyBase)
{      
   title = "Adept Arena Event A";  
   description = "You're commanding a small outpost station versus several ships.  Try not to get swarmed by enemy targets.  Pick them off one at a time and wait for your turrets to rotate into position.  You are under time pressure for this event.  You must manually aim while piloting a station.";
   
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
   
   DifficultyDesc[0]  = "You have a high tech advantage.";
   DifficultyDesc[1]  = "You have a good tech advantage.";
   DifficultyDesc[2]  = "You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "OutpostBase_ArenaSpecial_01";  //Bronze
   PlayerShipInfo_1 = "OutpostBase_ArenaSpecial_01";  //Silver
   PlayerShipInfo_2 = "OutpostBase_ArenaSpecial_01";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "60000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 60"; 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 5;
         shipDesignWL = "DartShip 10";                                     
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_04B : BountyBase)
{      
   title = "Adept Arena Event B";  
   description = "You're commanding a Beacon versus a fair sized enemy plus some fodder.  Enemy attackers are fixed on you, not your wingman, so cooridnate your attacks to drop targets quickly.  You are under time pressure for this event.  You must manually aim while piloting a station.";
   
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
   TechLevels_0 = "5 9 5 5 5";
   TechLevels_1 = "5 8 5 5 5";
   TechLevels_2 = "5 7 5 5 5";
   
   DifficultyDesc[0]  = "You have a great tech advantage.";
   DifficultyDesc[1]  = "You have a high tech advantage.";
   DifficultyDesc[2]  = "You have a good tech advantage.";
      
   //Arena Ships
   PlayerShipInfo_0 = "BeaconBase_03_ArenaSpecial_01";  //Bronze
   PlayerShipInfo_1 = "BeaconBase_03_ArenaSpecial_01";  //Silver
   PlayerShipInfo_2 = "BeaconBase_03_ArenaSpecial_01";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "180000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 180"; 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {          
      waveRelations[1, 0] = "Pirate Civ" SPC $FactionRelation_MYFACTION;  
      waveRelations[1, 2] = "Civ Terran" SPC $FactionRelation_HATE; 
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand forceAttackSet Attack BeaconSet";   
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "SaucerShip_Advanced_C 10"; 
         objectFuncs["Spawn", 2]   = "QAI_AddToSet forceAttackSet";                                    
      };
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         shipDesignWL = "HatchetShip_Improved 10";   
         objectFuncs["Spawn", 2]   = "QAI_AddToSet forceAttackSet";                                         
      }; 
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         shipDesignWL = "ArrayShip 10";  
         factionOverride = "Civ";                                   
      };  
      new ScriptGroup(HelperShips_02 : SHIP_ArenaWingman)
      {  
         objectCount = 2;
         shipDesignWL = "MoleShip 10";  
         factionOverride = "Civ";                                   
      };               
   };
}; 

new ScriptGroup(Bounty_Ladder_04C : BountyBase)
{      
   title = "Adept Arena Event C";  
   description = "You're pitted against a pile of deployable turrets.  Can you endure long enough to destroy them all?  You have little ability to drop shields, so coordinate with your wingman to destroy your targets.  Protect him at all costs.  You are under time pressure for this event.";
   
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
   TechLevels_0 = "5 6 1 1 1";
   TechLevels_1 = "5 6 1 1 1";
   TechLevels_2 = "5 6 2 2 2";
   
   DifficultyDesc[0]  = "Your ship is well equipped to spew out damage.  You have a great tech advantage.";
   DifficultyDesc[1]  = "You have a basic designed Volley ship.  You have a great tech advantage.";
   DifficultyDesc[2]  = "You have a basic designed Volley ship, plus the enemy turrets are a bit higher tech.  You have a good tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "VolleyShip_Improved";  //Bronze
   PlayerShipInfo_1 = "VolleyShip_Basic";  //Silver
   PlayerShipInfo_2 = "VolleyShip_Basic";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "200000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 200"; 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {     
      waveRelations[1, 1] = "Pirate Terran" SPC $FactionRelation_MYFACTION;      
      waveRelations[1, 2] = "Terran Civ" SPC $FactionRelation_HATE;           
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    

      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         offset = "3000"; 
         factionOverride = "Civ";
         shipDesignWL = "DeployTurretShip_BattleStation 10";                                     
      };   
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         offset = "5000"; 
         factionOverride = "Civ";
         shipDesignWL = "DeployTurretShip_BattleStation 10";                                     
      }; 
      new ScriptGroup(KillShips_03 : SHIP_ArenaBasic)
      {  
         offset = "7000"; 
         factionOverride = "Civ";
         shipDesignWL = "DeployTurretShip_BattleStation 10";                                     
      }; 
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         shipDesignWL = "ColtShip_Basic_A 10";  
         factionOverride = "Terran";                                   
      };            
   };
}; 

new ScriptGroup(Bounty_Ladder_04D : BountyBase)
{      
   title = "Adept Arena Event D";  
   description = "You are pitted against 3 Beacons.  Drop your turrets wisely.  Stay at range.  Try not to get attacked from multiple vectors.  You are under time pressure for this event.";
   
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
   TechLevels_0 = "3 6 3 3 3";
   TechLevels_1 = "3 6 3 3 3";
   TechLevels_2 = "3 6 3 3 3";
   
   DifficultyDesc[0]  = "Your ship is built for murder.  Plain and simple.  You have a great tech advantage.";
   DifficultyDesc[1]  = "Your ship has a high damage output and can disable targets.  You have a great tech advantage.";
   DifficultyDesc[2]  = "Your ship is fairly basic.  You have a great tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "HelixShip_Advanced";  //Bronze
   PlayerShipInfo_1 = "HelixShip_Advanced_C";  //Silver
   PlayerShipInfo_2 = "HelixShip_Basic_D";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "200000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 200"; 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      { 
         objectCount = 3; 
         shipDesignWL = "BeaconBase_03_ArenaSpecial_01 10";  
         minDistanceOverride = 0;
         maxDistanceOverride = 800;                                   
      };           
   };
}; 

new ScriptGroup(Bounty_Ladder_04E : BountyBase)
{      
   title = "Adept Arena Event E";  
   description = "You're commanding a massive station, but you're also being attacked by a massive ship.  You are under time pressure for this event.  You must manually aim while piloting a station.";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_04A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_04B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_04C";    
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "4 9 4 4 4";
   TechLevels_1 = "4 8 4 4 4";
   TechLevels_2 = "4 7 4 4 4";

   DifficultyDesc[0]  = "You have a supreme tech advantage.";
   DifficultyDesc[1]  = "You have a high tech advantage.";
   DifficultyDesc[2]  = "You have a good tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "Pirate03Base";  //Bronze
   PlayerShipInfo_1 = "Pirate03Base";  //Silver
   PlayerShipInfo_2 = "Pirate03Base";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "90000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 90"; 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {             
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "StarCruiserShip_Basic_B 10";                                     
      };               
   };
}; 