////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 03
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_03 : ArenaChallengeLadder_Base)
{
   ladderName = "Skilled Ladder";
   ladderDescription = "Learn to use your wingmen in this tournament.  Watch your allies back, and they shall watch yours.  Fight together as a unit.";
   minDeployStarLevel = 20; //the max level to use here should be 65.  
   sector4Only = false; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_03A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_03B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_03C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_03D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_03E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_03A : BountyBase)
{     
   DifficultySettings_0 = $Difficulty_Insane;
   DifficultySettings_1 = $Difficulty_Insane;
   DifficultySettings_2 = $Difficulty_Expert;
    
   title = "Skilled Arena Event A";  
   description = "Let's start with something nice and easy.  You have a nice big ship with a little helper on the side, but you are both outnumbered.";
   
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
   TechLevels_0 = "4 6 4 4 4";
   TechLevels_1 = "4 5 4 4 4";
   TechLevels_2 = "4 4 4 4 4";
   
   DifficultyDesc[0]  = "Your big Tug should have all the firepower you'll need.  You might not even need a wingman here.  You have a good tech advantage.";
   DifficultyDesc[1]  = "Your Tug has some surplus junk. Utilize your wingman to survive.  You have a slight tech advantage.";
   DifficultyDesc[2]  = "You're not all that different than your enemy, size wise.  Survival will be a struggle here."; 
   
   //Arena Ships
   PlayerShipInfo_0 = "TugShip_Basic";  //Bronze
   PlayerShipInfo_1 = "TugShip";  //Silver
   PlayerShipInfo_2 = "GirlScoutShip_Advanced";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {        
      waveRelations[1, 1] = "Pirate Terran" SPC $FactionRelation_MYFACTION;  
      waveRelations[1, 2] = "Civ Terran" SPC $FactionRelation_HATE;            
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    

      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 3;
         shipDesignWL = "CabShip_improved_A 10";   
         factionOverride = "Civ";                                  
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "MoleShip_improved 10";   
         factionOverride = "Civ";                                  
      };    
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         shipDesignWL = "TugShip 10";  
         factionOverride = "Terran";                                   
      };           
   };
}; 

new ScriptGroup(Bounty_Ladder_03B : BountyBase)
{      
   title = "Skilled Arena Event B";  
   description = "You're up against a beast of a ship!  You have superior numbers and a slight tech advantage.  Try to sync up your fire and dig through that thick armor.";
   
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
   TechLevels_0 = "5 7 3 3 3";
   TechLevels_1 = "5 6 3 3 3";
   TechLevels_2 = "5 6 3 3 3";
   
   DifficultyDesc[0]  = "You have an improved Hound design.  You have a high tech advantage.";
   DifficultyDesc[1]  = "You have a basic Hound design.  Could be better, could be worse.  You have a good tech advantage.";
   DifficultyDesc[2]  = "Your Hound ship has surplus equipment.  You really have to lean on your allies here.  You have a good tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "HoundShip_Improved_B";  //Bronze
   PlayerShipInfo_1 = "HoundShip_Basic";  //Silver
   PlayerShipInfo_2 = "HoundShip";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {        
      waveRelations[1, 1] = "Pirate Terran" SPC $FactionRelation_MYFACTION;  
      waveRelations[1, 2] = "Civ Terran" SPC $FactionRelation_HATE;            
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    

      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "FreighterShip_Basic 10";   
         factionOverride = "Civ";                                  
      };   
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         objectCount = 1;
         shipDesignWL = "TugShip_Improved 10";  
         factionOverride = "Terran";                                   
      }; 
      new ScriptGroup(HelperShips_02 : SHIP_ArenaWingman)
      {  
         objectCount = 1;
         shipDesignWL = "TugShip_Improved_A 10";  
         factionOverride = "Terran";                                   
      }; 
      new ScriptGroup(HelperShips_03 : SHIP_ArenaWingman)
      {  
         objectCount = 3;
         shipDesignWL = "RangerShip_basic 10";  
         factionOverride = "Terran";                                   
      };          
   };
}; 

new ScriptGroup(Bounty_Ladder_03C : BountyBase)
{      
   title = "Skilled Arena Event C";  
   description = "This event is all about launchers.  Your wingman can dig through the shields, but you'll need to make the kill.  Watch out for those bombs and wingmen!";
   
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
   TechLevels_0 = "4 6 4 4 4";
   TechLevels_1 = "4 6 4 4 4";
   TechLevels_2 = "4 6 4 4 4";
   
   DifficultyDesc[0]  = "Your volley has some heavy hitting weapons.  Just make sure you aim them correctly.  You have a good tech advantage.";
   DifficultyDesc[1]  = "A basic volley ship with some easy fire and forget weapons.  You have a good tech advantage.";
   DifficultyDesc[2]  = "A surplus volley with some really cheap on board missiles is all you have.  You have a good tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "VolleyShip_Improved";  //Bronze
   PlayerShipInfo_1 = "VolleyShip_Basic";  //Silver
   PlayerShipInfo_2 = "VolleyShip";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {         
      waveRelations[1, 1] = "Pirate Terran" SPC $FactionRelation_MYFACTION;
      waveRelations[1, 2] = "Terran Civ" SPC $FactionRelation_HATE;         
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    

      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "PounderShip_Basic 10";   
         factionOverride = "Civ";                                  
      };
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         shipDesignWL = "MoleShip_Basic 10";   
         factionOverride = "Civ";                                  
      };    
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         objectCount = 2;
         shipDesignWL = "ScoutShip_Basic 10";  
         factionOverride = "Terran";                                   
      };           
   };
}; 

new ScriptGroup(Bounty_Ladder_03D : BountyBase)
{      
   title = "Skilled Arena Event D";  
   description = "You have a sizable ship, against a mixed bag of medium class ships.  Your wingman has bombs.  Coordinate your attacks.";
   
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
   TechLevels_0 = "6 7 4 4 4";
   TechLevels_1 = "6 7 4 4 4";
   TechLevels_2 = "6 6 4 4 4";
   
   DifficultyDesc[0]  = "A BigBrother ship has all the tools you'll ever need.  You have a high tech advantage.";
   DifficultyDesc[1]  = "The BigBus doesn't have massive firepower, but has great repair rates.  Remember that.  You have a high tech advantage.";
   DifficultyDesc[2]  = "You are stricken with a Mule ship.  Your wingman is laughing at you.  You have a good tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "BigBrotherShip_Basic";  //Bronze
   PlayerShipInfo_1 = "BigBusShip_Basic";  //Silver
   PlayerShipInfo_2 = "MuleShip_Basic";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {         
      waveRelations[1, 1] = "Pirate Terran" SPC $FactionRelation_MYFACTION;
      waveRelations[1, 2] = "Civ Terran" SPC $FactionRelation_HATE;          
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
  
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "MuleShip_Advanced 10";   
         factionOverride = "Civ";                                  
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         objectCount = 2;
         shipDesignWL = "YachtShip_Improved 10";   
         factionOverride = "Civ";                                  
      };     
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         shipDesignWL = "GullShip_Basic 10";  
         factionOverride = "Terran";                                   
      };           
   };
}; 

new ScriptGroup(Bounty_Ladder_03E : BountyBase)
{      
   title = "Skilled Arena Event E";  
   description = "You're up against a tiny station.  It packs a punch, but it can't really chase you down.  You are under time pressure for this event.";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_03A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_03B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_03C";   
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "4 6 4 4 4";
   TechLevels_1 = "4 6 4 4 4";
   TechLevels_2 = "4 6 4 4 4";
   
   DifficultyDesc[0]  = "You have a missile ship, built for dealing terrible terrible damage to the hull.  You have a slight tech advantage.";
   DifficultyDesc[1]  = "You are good at taking down shields, but your wingman will have to do most of the hull softening.  You have a slight tech advantage.";
   DifficultyDesc[2]  = "A basic Dart ship!  Are you joking?  You have a slight tech advantage.";
   
   //Arena Ships
   PlayerShipInfo_0 = "ScoutShip_Improved";  //Bronze
   PlayerShipInfo_1 = "ScoutShip_Improved_D";  //Silver
   PlayerShipInfo_2 = "DartShip_Basic";  //Gold
   
   //setup for the timer (don't forget WAVE_arenaSpawnTimed)
   initialTimedCallbacks[2] = "1200000 StartWaveName QuestFail 0 failTime";
   missionTrackerData[1] = "timer MT_TIMERTEXT 120"; 
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {         
      waveRelations[1, 0] = "Pirate Civ" SPC $FactionRelation_MYFACTION; 
      waveRelations[1, 2] = "Civ Terran" SPC $FactionRelation_HATE;            
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnTimed)
   {    
 
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "OutpostBase 10";   
         factionOverride = "Terran";                                  
      };    
      new ScriptGroup(HelperShips_01 : SHIP_ArenaWingman)
      {  
         shipDesignWL = "ScoutShip_Improved 10";  
         factionOverride = "Civ";                                   
      };           
   };
}; 