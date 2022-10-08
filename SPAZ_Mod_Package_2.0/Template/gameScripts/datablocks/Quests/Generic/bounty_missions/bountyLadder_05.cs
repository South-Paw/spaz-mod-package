////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 05
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(ArenaChallenge_Ladder_05 : ArenaChallengeLadder_Base)
{
   ladderName = "Experienced Ladder";
   ladderDescription = "Learn to use your environment in this tournament.  Exploding barrels are your friend.  The arena is littered with stuff you can exploit.";
   minDeployStarLevel = 45; //the max level to use here should be 65.  
   sector4Only = false; //note, all arenas are unlocked in sector 4.
   
   new ScriptObject(Tier_0 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_05A";    
   };
   new ScriptObject(Tier_1 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_05B";    
   };
   new ScriptObject(Tier_2 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_05C";    
   };
   new ScriptObject(Tier_3 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_05D";    
   };
   new ScriptObject(Tier_4 : ArenaChallengeTier_Base)
   {       
      eventName = "Bounty_Ladder_05E";    
   };
};

////////////////////////////////////////////////////////////////////////////////
// BOOUNTY LADDER 01 MISSIONS
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup(Bounty_Ladder_05A : BountyBase)
{      
   title = "Experienced Arena Event A";  
   description = "You have a small craft versus many small craft.  You are totally outmatched.  Your only hope is those barrels.  Just watch out for the shockwaves!";
   
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
   TechLevels_1 = "4 6 4 4 4";
   TechLevels_2 = "5 6 5 5 5";
   
   DifficultyDesc[0]  = "Your enemies should die very easily.";
   DifficultyDesc[1]  = "Your enemies are fairly weak.";
   DifficultyDesc[2]  = "Your enemies can soak a bit more damage."; 
   
   //Arena Ships
   PlayerShipInfo_0 = "DartShip_ArenaSpecial_02";  //Bronze
   PlayerShipInfo_1 = "DartShip_ArenaSpecial_02";  //Silver
   PlayerShipInfo_2 = "DartShip_ArenaSpecial_02";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {  
      new ScriptGroup(arenaProps_01 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_EMPBarrels 10";
      };  
      new ScriptGroup(arenaProps_02 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels 10";
      }; 
      new ScriptGroup(arenaProps_03 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_AcidBarrels 10";
      }; 
      new ScriptGroup(arenaProps_04 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      };              
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         objectCount = 3;
         shipDesignWL = "DartShip_Basic 10";                                     
      };          
   };
}; 

new ScriptGroup(Bounty_Ladder_05B : BountyBase)
{      
   title = "Experienced Arena Event B";  
   description = "You have a fast ship, but zero weapons.  Make your opponent kill himself.  Use superior tactics to lure him into a trap.";
   
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
   TechLevels_0 = "1 7 1 1 1";
   TechLevels_1 = "2 7 2 2 2";
   TechLevels_2 = "3 7 3 3 3";
   
   DifficultyDesc[0]  = "Your enemy should die very easily.";
   DifficultyDesc[1]  = "Your enemy is fairly weak.";
   DifficultyDesc[2]  = "Your enemy can soak a bit more damage."; 
   
   //Arena Ships
   PlayerShipInfo_0 = "DartShip_ArenaSpecial_01";  //Bronze
   PlayerShipInfo_1 = "DartShip_ArenaSpecial_01";  //Silver
   PlayerShipInfo_2 = "DartShip_ArenaSpecial_01";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   { 
      new ScriptGroup(arenaProps_01 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      };  
      new ScriptGroup(arenaProps_02 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      }; 
      new ScriptGroup(arenaProps_03 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      };              
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand BountyArenaShipSet SetTactic TP_Shields TP_ShieldsDown";   
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         shipDesignWL = "CrawlerShip_Basic_B 10";                                     
      };          
   };
}; 

new ScriptGroup(Bounty_Ladder_05C : BountyBase)
{      
   title = "Experienced Arena Event C";  
   description = "You are up against 2 superior vessels here.  You have some deployable turrets in the area.  Use them to your advantage.  Use the asteroids for cover.";
   
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
   TechLevels_0 = "4 6 4 4 6";
   TechLevels_1 = "4 6 4 4 6";
   TechLevels_2 = "4 6 4 4 6";
   
   DifficultyDesc[0]  = "You have a basic Dart design.  You should be able to soak some damage.";
   DifficultyDesc[1]  = "You have a low tech Dart.  You'll have to be on the ball to win.";
   DifficultyDesc[2]  = "You have a Dart with no weapons.  This will be rough.  Stay as far away as possible."; 
   
   //Arena Ships
   PlayerShipInfo_0 = "DartShip_Basic";  //Bronze
   PlayerShipInfo_1 = "DartShip";  //Silver
   PlayerShipInfo_2 = "DartShip_ArenaSpecial_03";  //Gold
   
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   { 
      waveRelations[1, 5] = "Pirate Bounty" SPC $FactionRelation_MYFACTION;   
      new ScriptGroup(arenaProps_01 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_EMPBarrels 10";
      };  
      new ScriptGroup(arenaProps_02 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels 10";
      }; 
      new ScriptGroup(arenaProps_03 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_AcidBarrels 10";
      };          
   };       
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
        
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         offset = "6000";  
         factionOverride = "Civ";
         shipDesignWL = "BigBusShip_Basic 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         offset = "6000";  
         factionOverride = "Civ";
         shipDesignWL = "HoundShip_Improved_D 10";                                     
      }; 
      new ScriptGroup(helperShips_01 : SHIP_ArenaWingman)
      {  
         offset = "2000"; 
         factionOverride = "Bounty";
         shipDesignWL = "DeployTurretShip_BattleStation 10";
         new ScriptGroup(arenaRoids_01 : PROP_arenaProps_01) 
         {  
            refObjectName = "helperShips_01"; 
            offset = "10";                                 
            instanceObjectWeightedList = "AsteroidCluster 10";
         };                                     
      };   
      new ScriptGroup(helperShips_02 : helperShips_01)
      { 
         new ScriptGroup(arenaRoids_02 : arenaRoids_01) 
         { 
            refObjectName = "helperShips_02";   
         };                                    
      }; 
      new ScriptGroup(helperShips_03 : helperShips_01)
      {  
         new ScriptGroup(arenaRoids_03 : arenaRoids_01) 
         { 
            refObjectName = "helperShips_03";   
         };                                  
      };             
   };
}; 

new ScriptGroup(Bounty_Ladder_05D : BountyBase)
{      
   title = "Experienced Arena Event D";  
   description = "You have lots of targets to contend with.  There are turrets out there to help you, but they are very weak.";
   
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
   TechLevels_0 = "5 6 5 5 2";
   TechLevels_1 = "5 6 5 5 2";
   TechLevels_2 = "5 6 5 5 2";
   
   DifficultyDesc[0]  = "You have a basic Dart design.  You should be able to soak some damage.";
   DifficultyDesc[1]  = "You have a low tech Dart.  You'll have to on the ball to win.";
   DifficultyDesc[2]  = "You have a Dart with no weapons.  This will be rough.  Stay as far away as possible."; 
   
   //Arena Ships
   PlayerShipInfo_0 = "DartShip_Basic";  //Bronze
   PlayerShipInfo_1 = "DartShip";  //Silver
   PlayerShipInfo_2 = "DartShip_ArenaSpecial_03";  //Gold
    
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   {  
      waveRelations[1, 5] = "Pirate Bounty" SPC $FactionRelation_MYFACTION;
      new ScriptGroup(arenaProps_01 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_EMPBarrels 10";
      };  
      new ScriptGroup(arenaProps_02 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels 10";
      }; 
      new ScriptGroup(arenaProps_03 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_AcidBarrels 10";
      };              
   };      
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         offset = "6000";  
         objectCount = 3;
         factionOverride = "Civ";
         shipDesignWL = "CabShip 10";                                     
      }; 
      new ScriptGroup(KillShips_02 : SHIP_ArenaBasic)
      {  
         offset = "8000";  
         objectCount = 2;
         shipDesignWL = "CabShip 10";                                     
      }; 
      new ScriptGroup(helperShips_01 : SHIP_ArenaWingman)
      {  
         offset = "2500";  
         factionOverride = "Bounty";
         shipDesignWL = "DeployTurretShip_BattleStation 10";                                     
      }; 
      new ScriptGroup(helperShips_02 : SHIP_ArenaWingman)
      {  
         offset = "4000";  
         factionOverride = "Bounty";
         shipDesignWL = "DeployTurretShip_TorpedoRack 10";                                     
      };  
      new ScriptGroup(helperShips_03 : SHIP_ArenaWingman)
      {  
         offset = "5500";  
         factionOverride = "Bounty";
         shipDesignWL = "DeployTurretShip_TorpedoRack 10";                                     
      }; 
      new ScriptGroup(helperShips_04 : SHIP_ArenaWingman)
      {  
         offset = "6500";  
         factionOverride = "Bounty";
         shipDesignWL = "DeployTurretShip_TorpedoRack 10";                                     
      };              
   };
}; 

new ScriptGroup(Bounty_Ladder_05E : BountyBase)
{      
   title = "Experienced Arena Event E";  
   description = "You have a small ship versus a mammoth beast.  Don't waste your barrels.  Your enemy can soak a lot of damage.  Your ship is cloaked, so use the element of surprise.  Manage your cloak to lure him to his doom!";
   
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
   Rewards["Complete_0", "Spec"]           = "arenaSpec_05A"; 
   Rewards["Complete_1", "Spec"]           = "arenaSpec_05B"; 
   Rewards["Complete_2", "Spec"]           = "arenaSpec_05C";   
   
   //Terran, Pirate, Zombie, Civ, Bounty levels   
   TechLevels_0 = "1 5 1 1 1";
   TechLevels_1 = "2 5 2 2 2";
   TechLevels_2 = "3 5 3 3 3";
   
   DifficultyDesc[0]  = "Your enemy should die very easily.";
   DifficultyDesc[1]  = "Your enemy is fairly weak.";
   DifficultyDesc[2]  = "Your enemy can soak a bit more damage."; 
   
   //Arena Ships
   //Arena Ships
   PlayerShipInfo_0 = "DartShip_Improved_A_Cloak";  //Bronze
   PlayerShipInfo_1 = "DartShip_Improved_A_Cloak";  //Silver
   PlayerShipInfo_2 = "DartShip_Improved_A_Cloak";  //Gold
    
   new ScriptGroup(arenaSetup : WAVE_arenaSetup)
   { 
      waveRelations[1, 5] = "Pirate Bounty" SPC $FactionRelation_MYFACTION;  
      new ScriptGroup(arenaProps_01 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      };  
      new ScriptGroup(arenaProps_02 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      }; 
      new ScriptGroup(arenaProps_03 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      };
      new ScriptGroup(arenaProps_04 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      };    
      new ScriptGroup(arenaProps_05 : PROP_arenaProps_01) 
      {                                    
         instanceObjectWeightedList = "SpaceProp_ExplodingBarrels_HoldersOnly 10";
      };                
   };      
   new ScriptGroup(arenaSpawn : WAVE_arenaSpawnBasic)
   {    
      waveTimedCallbacks[1, 1] = "0 QAI_SetAICommand BountyArenaShipSet SetTactic TP_Shields TP_ShieldsDown";   
      new ScriptGroup(KillShips_01 : SHIP_ArenaBasic)
      {  
         offset = "6000"; 
         factionOverride = "Civ"; 
         shipDesignWL = "CarrierShip 10";                                     
      };              
   };
}; 