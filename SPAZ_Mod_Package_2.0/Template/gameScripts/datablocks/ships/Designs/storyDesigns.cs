////////////////////////////////////////////////////////////////////////////////
// special designs for story and side missions
////////////////////////////////////////////////////////////////////////////////

datablock ShipDesignDatablock(Zombie_BlightShip_tutorial : DefaultZombieShip)
{
   shipHull    = HullZombieBlight_tutorial;

   shipEngine            = M_BasicEngine;     
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   shipArmor_Front       = "TitaniumArmor_L";   
   shipArmor_Starboard   = "TitaniumArmor_L";
   shipArmor_Aft         = "TitaniumArmor_L";
   shipArmor_Port        = "TitaniumArmor_L";
           
   externalLink7 = "";
   externalLink8 = "";
   externalLink9 = "";
   
   turretLink1  = "";
   turretWeaponLink1_1  = "";
      
   turretLink6  = "MediumTurret";
   turretWeaponLink6_1  = "SmallCannon_zombie";
   
   includeInSSTDatabase = false;
};

datablock ShipDesignDatablock(TugShip_SM_09 : DefaultShip)
{
   //Determines the skeleton for the ship.  
   shipHull    = HullTug_SM_09;  //This determines what we can put of the ship. 

   shipEngine            = M_BasicEngine;    
   shipReactor           = M_BasicReactor;
   shipShield            = M_BasicShield;
     
   //Armor (Note: Armor can be heavy, so keep that in mind.  Even if there is 100 armor points, no need to use them all 
   shipArmor_Front       = "";   
   shipArmor_Starboard   = "";
   shipArmor_Aft         = "";
   shipArmor_Port        = "";   
   
   //Weapons also have weight, so no need to add all available weapons if less will do
   turretLink4  = "MediumTurret";
   turretWeaponLink4_1  = "MediumEmitter_Civ";   
   
   externalLink5 = "MediumLauncher_GRAV";
   externalLink6 = "MediumLauncher_GRAV";
   
   externalLink7 = "EngineBooster_M";
   externalLink8 = "EngineBooster_M";
   
   includeInSSTDatabase = false;
};