

//Register with research system.
$ResearchDatablockSet = new SimSet() {};
function ResearchDatablock::onAdd(%this)
{   
   //add me to the research database indexed by my name. need one per faction
   if ( %this.getID() != researchDatablockBase.getId() )
      $ResearchDatablockSet.add(%this);
   
}
//RM_AddResearchType(%this.getName());

datablock ResearchDatablock(ResearchDatablockBase) 
{
   //TODO:  Add pre-requisites for unlocking in the GUI
   //Pre-requisite could also be chosen from a list for variety.
   //Could even unlock tech if we wish
   researchTotalLevels = 10;
   
   //Note: could automate this, but not sure if i like updating Datablocks on the fly. 
   componentConnection = "NONE"; //When there is an upgrade, we inform all ships with this type of component, they need an upgrade.
   subComponentMask = 0; //only External components need this.
};



//We assume 10 levels"  Level data is stores in the research manager, not the base datablocks
//it is faction dependent
//we conduct projectile research, not sub category research, for simplicity for the player.
//this means we need to define a research matrix, OR could this research matrix be generated on game start
//that oculd be more interesting. 

$RM_MaxMult = 0;
$RM_MaxLevel = 1;
$RM_Description = 2;

%counter = 0;
$SHIELD_Shielding    = bit(%counter++);  //will be 1
$SHIELD_Cloaking     = bit(%counter++);

function ResearchDatablock::GetTechUnlockData(%this, %level, %dataType)
{
   %data = %this.unlocking[%level];
   return getWord(%data, %dataType);    
}

function ResearchDatablock::HasTechUnlock(%this, %level)
{
   return %this.GetTechUnlockCost(%level) !$= "";   
}

function ResearchDatablock::GetTechUnlockCost(%this, %level)
{
   if ( %level == 0 )
   {
      if ( %this.initialUnlockList $= "" )
         return "";
      else
         return 0;
   }
   
   return %this.GetTechUnlockData(%level, $RD_UnlockCost);   
}

function ResearchDatablock::GetTechRarity(%this, %level)
{
   return %this.GetTechUnlockData(%level, $RD_Rarity); 
}
   
function ResearchDatablock::GetTechUnlockLevel(%this, %level)
{
   return %this.GetTechUnlockData(%level, $RD_UnlockLevel); 
}

function ResearchDatablock::GetTechStationType(%this, %level)
{
   return %this.GetTechUnlockData(%level, $RD_StationType); 
}
   
function ResearchDatablock::GetTechUnlockComponents(%this, %level)
{
   if ( %level == 0 )
      return %this.initialUnlockList;   
   
   %data = %this.unlocking[%level];
   %count = getWordCount(%data);
   
   %componentList = getWords(%data, $RD_ComponentListStart, %count - 1);
   return %componentList;   
}

//This is the component we will use for the research screen icon.
function ResearchDatablock::GetTechDisplayComponent(%this, %level)
{
   %componentList = %this.GetTechUnlockComponents(%level);
   return getWord(%componentList, 0);
}



///////////////////////////////////
// Research Distribution Data /////
///////////////////////////////////

//need to add to research sets so i can deal like decks. 
//should work very similar to how i do missions. 
//deal to instances, not stars. 


//RR = Research Rarity
%count = 1;
$RR_Common   = bit(%count++);
$RR_UnCommon = bit(%count++);
$RR_Rare     = bit(%count++);

//RL = Research Location bitfield
%count = 1;
$RL_Mining   = bit(%count++);
$RL_Science  = bit(%count++);
$RL_Colony   = bit(%count++);
$RL_Security = bit(%count++);
$RL_All = $RL_Mining | $RL_Science | $RL_Colony | $RL_Security;

//RSL = Research Star Level 
%count = 1;
$RSL_Start   = bit(%count++);
$RSL_Low    = bit(%count++);
$RSL_Med    = bit(%count++);
$RSL_High   = bit(%count++);


$ResearchCount[$RR_Common]   = 15; //only need 1 piece
$ResearchCount[$RR_UnCommon] = 12; //need 2 pieces
$ResearchCount[$RR_Rare]     = 9; //need 3 pieces.

function GetResearchCardCount(%rarity)
{
   return  $ResearchCount[%rarity];
}

//This is multiplied by the Research Unlock Level where the item appears.
//Also can have discount for friendliness
$ResearchCost[$RR_Common]   = 10;
$ResearchCost[$RR_UnCommon] = 11;
$ResearchCost[$RR_Rare]     = 12; //since rate at high levels + need 3, this is punishing enough 

function ResearchDatablock::GetResearchBaseCost(%this, %level)
{
   %rarity = %this.GetTechRarity(%level);
   %rarityCost = $ResearchCost[%rarity];
   
   %realCost = %rarityCost * mPow(%level + 3, 1.4); //high level rare stuff super expensive. 
   %realCost = mFloor(%realCost);
   return %realCost;     
}

$ResearchPieces[$RR_Common]   = 1;
$ResearchPieces[$RR_UnCommon] = 2;
$ResearchPieces[$RR_Rare]     = 3;

function ResearchDatablock::GetResearchPieces(%this, %level)
{
   %rarity = %this.GetTechRarity(%level);
   %pieces = $ResearchPieces[%rarity];
      
   return %pieces;     
}


$ResearchUnlockRelations[$RR_Common]   = $FactionRelation_NEUTRAL;
$ResearchUnlockRelations[$RR_UnCommon] = $FactionRelation_LIKE;
$ResearchUnlockRelations[$RR_Rare]     = $FactionRelation_FRIEND;

function ResearchDatablock::GetRequiredRelations(%this, %level)
{
   %rarity = %this.GetTechRarity(%level);
   %required = $ResearchUnlockRelations[%rarity];
      
   return %required;     
}



$ResearchUnlock[$RSL_Start]  = "0 15";
$ResearchUnlock[$RSL_Low]    = "10 35";
$ResearchUnlock[$RSL_Med]    = "33 55";
$ResearchUnlock[$RSL_High]   = "50 70"; //80+ stars are zombies.
 
function IsValidResearchMinStarLevel(%index, %starLevel)
{
   %levelRange = $ResearchUnlock[%index];
   if ( %starLevel < getWord(%levelRange, 0) )
      return false;
      
   if ( %starLevel > getWord(%levelRange, 1) )
      return false;
   
   return true;
}

////////////////////////////////////
// Data Definitions ////////////////
////////////////////////////////////

$RD_UnlockCost  = 0;
$RD_Rarity      = 1;
$RD_UnlockLevel = 2;
$RD_StationType = 3;
$RD_ComponentListStart = 4;


///////////////////////////////////////////////////////////////////////////////
// Projectiles ////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(ProjectileResearch : ResearchDatablockBase) 
{    
   researchElements = "damageStrength maxRange maxSpeed reloadMS clusterSpread";
   researchTitle = "CANNONS";
   
   componentConnection = "External";
   subComponentMask = $WEAPON_ProjectileCannon; 
   //NOTE: $WEAPON_CrewProjectileCannon should be moved to crew research category later. 
   
   
   //Projectiles
                                       //maxMult maxLevels description 
   researchData_maxRange               = "1.25 5 How far the projectile will travel";
   researchData_maxSpeed               = "1.5 5 How fast the projectile will travel";
   researchData_damageStrength         = "5 20 How hard the projectile will hit";
   
   //Cannons:
   researchData_reloadMS               = "0.70 3 How fast the cannon will reload"; 
   
   //not safe to monket with the burst size. just make it burst more often     
   //researchData_burstSize              = "2 5 How many projectiles are fired in a burst";
   researchData_clusterSpread          = "0.70 3 How wide the shots spread";
   
   
   researchTotalLevels = 10;
   
   //Unlocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "SmallCannon_pulse_civ" SPC "MediumCannon_pulse_civ" SPC "LargeCannon_pulse_civ" SPC "HugeCannon_pulse_civ";
   unlocking[2] = 2 SPC $RR_Common SPC $RSL_Start SPC $RL_Security SPC "SmallCannon_pulse" SPC "MediumCannon_pulse" SPC "LargeCannon_pulse" SPC "HugeCannon_pulse";
   unlocking[3] = 3 SPC $RR_Common SPC $RSL_Low SPC $RL_All SPC "CannonBooster_S" SPC "CannonBooster_M" SPC "CannonBooster_L" SPC "CannonBooster_H";
   unlocking[4] = 4 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_All SPC "SmallCannon_cluster" SPC "MediumCannon_cluster" SPC "LargeCannon_cluster" SPC "HugeCannon_cluster";
   unlocking[6] = 6 SPC $RR_UnCommon  SPC $RSL_Med SPC $RL_All SPC "SmallCannon_rapid" SPC "MediumCannon_rapid" SPC "LargeCannon_rapid" SPC "HugeCannon_rapid";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_High SPC $RL_Mining SPC "SmallCannon_massDriver" SPC "MediumCannon_massDriver" SPC "LargeCannon_massDriver" SPC "HugeCannon_massDriver";  
};


   
///////////////////////////////////////////////////////////////////////////////
// Beams ////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(BeamResearch : ResearchDatablockBase) 
{   
   researchElements = "baseDamage beamLength beamLife beamRegen chargeTime";
   researchTitle = "BEAMS";
   
   componentConnection = "External";
   subComponentMask = $WEAPON_BeamEmitter; 
   //Note Mining and tractor should be moves to subsystems
  
   //Beams     //Note max damage mult for lasers higher than projectiles to make things more fair long term
   researchData_baseDamage    = "6 20 How much damage the beam will do";
   researchData_beamLength    = "1.25 5 How long the beam is";
   researchData_beamLife      = "1.3 3 How long the beam will stay active";
   researchData_beamRegen     = "0.7 3 How long the crystal needs to cool down";
   researchData_chargeTime    = "0.7 3 Charge up time mult";
         
   researchTotalLevels = 10;
   
   //Unlocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "SmallEmitter_Civ" SPC "MediumEmitter_Civ" SPC "LargeEmitter_Civ" SPC "HugeEmitter_Civ";
   unlocking[1] = 1 SPC $RR_Common SPC $RSL_Start SPC $RL_All SPC "SmallEmitter" SPC "MediumEmitter" SPC "LargeEmitter" SPC "HugeEmitter";
   unlocking[3] = 3 SPC $RR_Common SPC $RSL_Low SPC $RL_All SPC "BeamBooster_S" SPC "BeamBooster_M" SPC "BeamBooster_L" SPC "BeamBooster_H";
   unlocking[5] = 5 SPC $RR_Rare SPC $RSL_Med SPC $RL_Science SPC "SmallEmitter_Ion" SPC "MediumEmitter_Ion" SPC "LargeEmitter_Ion" SPC "HugeEmitter_Ion";
   unlocking[6] = 6 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_Science SPC "SmallEmitter_Leech" SPC "MediumEmitter_Leech" SPC "LargeEmitter_Leech" SPC "HugeEmitter_Leech";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_High SPC $RL_Security SPC "SmallEmitter_Heavy" SPC "MediumEmitter_Heavy" SPC "LargeEmitter_Heavy" SPC "HugeEmitter_Heavy";  
}; 


///////////////////////////////////////////////////////////////////////////////
// Missiles ///////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(MissileResearch : ResearchDatablockBase) 
{   
   researchElements = "damageStrength maxSpeed turnSpeed constantThrustForce maxHealth reloadMS";
   researchTitle = "LAUNCHERS";
   
   componentConnection = "External";
   subComponentMask = $WEAPON_TorpedoLauncher | $WEAPON_MissileLauncher | $WEAPON_RocketLauncher; 
   
   
   //Missiles
   researchData_damageStrength       = "5 20 Description Here";
   researchData_maxSpeed             = "1.5 10 Description Here";
   researchData_turnSpeed            = "1.5 10 Description Here";
   researchData_constantThrustForce  = "1.5 10 Description Here";   
   researchData_maxHealth            = "5 10 Description Here";   
   
   //Missile Launchers
   researchData_reloadMS            = "0.5 10 Description Here";
   
         
   researchTotalLevels = 10;
   
   //Ulocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "SmallLauncher_Civ" SPC "MediumLauncher_Civ" SPC "LargeLauncher_Civ" SPC "HugeLauncher_Civ" SPC "SmallTorpedoLauncher_Civ" SPC "MediumTorpedoLauncher_Civ" SPC "LargeTorpedoLauncher_Civ" SPC "HugeTorpedoLauncher_Civ";
   unlocking[1] = 1 SPC $RR_Common SPC $RSL_Start SPC $RL_Security SPC "SmallLauncher" SPC "MediumLauncher" SPC "LargeLauncher" SPC "HugeLauncher";
   unlocking[2] = 2 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_Security SPC "SmallRocketLauncher" SPC "MediumRocketLauncher" SPC "LargeRocketLauncher" SPC "HugeRocketLauncher";  
   unlocking[3] = 3 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_Security SPC "SmallTorpedoLauncher" SPC "MediumTorpedoLauncher" SPC "LargeTorpedoLauncher" SPC "HugeTorpedoLauncher";
   unlocking[4] = 4 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_Science SPC "SmallLauncher_GRAV" SPC "MediumLauncher_GRAV" SPC "LargeLauncher_GRAV" SPC "HugeLauncher_GRAV";
   unlocking[5] = 5 SPC $RR_Common SPC $RSL_Med SPC $RL_All SPC "LauncherBooster_S" SPC "LauncherBooster_M" SPC "LauncherBooster_L" SPC "LauncherBooster_H";
   unlocking[7] = 7 SPC $RR_Rare SPC $RSL_High SPC $RL_Science SPC "SmallHunterLauncher" SPC "MediumHunterLauncher" SPC "LargeHunterLauncher" SPC "HugeHunterLauncher";    
}; 

   

///////////////////////////////////////////////////////////////////////////////
// Mass Bombs /////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(MassBombResearch : ResearchDatablockBase) 
{   
   researchElements = "damageStrength maxSpeed maxHealth reloadMS";
   researchTitle = "MASS BOMBS";
   
   componentConnection = "External";
   subComponentMask = $WEAPON_MassBombLauncher; 
   
   
   //Mass Bombs
   researchData_damageStrength       = "8 20 Description Here";
   researchData_maxSpeed             = "1.5 5 Description Here";     
   researchData_maxHealth            = "5 10 Description Here";   
      
   
   //Mass Bomb Launchers
   researchData_reloadMS            = "0.7 3 Description Here";
  
   
   researchTotalLevels = 10;
   
   //Ulocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "MassBombLauncher_HEAT_Medium" SPC "MassBombLauncher_HEAT_Large";
   unlocking[3] = 3 SPC $RR_Common SPC $RSL_Low SPC $RL_Mining SPC "MassBombLauncher_EXP_Medium" SPC "MassBombLauncher_EXP_Large";
   unlocking[5] = 5 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_Mining SPC "MassBombLauncher_ION_Medium" SPC "MassBombLauncher_ION_Large";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_High SPC $RL_Mining SPC "MassBombLauncher_CORROSIVE_Medium" SPC "MassBombLauncher_CORROSIVE_Large";


}; 

   



///////////////////////////////////////////////////////////////////////////////
// Mine Research //////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(MineResearch : ResearchDatablockBase) 
{   
   researchElements = "damageStrength maxHealth detectionRadius seekingSpeed cloakDisruptionTime mineDelpoyTime";
   researchTitle = "MINES";
   
   componentConnection = "External";
   
   subComponentMask = $WEAPON_MineDropperLauncher;
   
   //MINES
   researchData_maxHealth            = "5 10 Description Here";   
   researchData_damageStrength       = "7 20 Description Here";
   researchData_detectionRadius      = "1.25 5 Description Here";   
   researchData_seekingSpeed         = "1.5 5 Description Here";
   researchData_cloakDisruptionTime  = "0.5 5 Description Here";
  
   //MINE DROPPERS
   researchData_mineDelpoyTime       = "0.5 10 Description Here";  
        
   researchTotalLevels = 10;
   
   //NOTE: mine datablocks are changin so just hooking up a couple for now. 
   //Unlocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "Dropper_Small_Civ_Launcher" SPC "Dropper_Large_Civ_Launcher";
   unlocking[2]  = 2 SPC $RR_Common SPC $RSL_Low SPC $RL_All SPC  "Dropper_Small_Explosive_Launcher" SPC "Dropper_Large_Explosive_Launcher";
   unlocking[4]  = 2 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_Science SPC  "Dropper_Small_Ion_Launcher" SPC "Dropper_Large_Ion_Launcher";
   unlocking[6]  = 3 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_Science SPC  "Dropper_Small_Scanner_Launcher" SPC "Dropper_Large_Scanner_Launcher";
   unlocking[8]  = 4 SPC $RR_Rare SPC $RSL_Med SPC $RL_Security SPC  "Dropper_Small_MicroLaser_Launcher" SPC "Dropper_Large_MicroLaser_Launcher";
   unlocking[10] = 5 SPC $RR_Rare SPC $RSL_High SPC $RL_All SPC "Dropper_Small_Random_Launcher" SPC "Dropper_Large_Random_Launcher";
   
  
}; 

    
///////////////////////////////////////////////////////////////////////////////
// Drone Research //////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(DroneResearch : ResearchDatablockBase) 
{   
   researchElements = "droneDamageBoost maxHealth maxSpeed turnSpeed constantThrustForce cloakDisruptionTime droneConstructTime droneLaunchTime";
   researchTitle = "DRONES";
   
   componentConnection = "External";
   subComponentMask = $WEAPON_DroneHiveLauncher; 
   
   //Drones
   researchData_maxHealth            = "8 20 Description Here";      
   researchData_cloakDisruptionTime  = "0.5 5 Description Here";   
   
   researchData_maxSpeed             = "1.5 5 Description Here";
   researchData_turnSpeed            = "1.5 5 Description Here";
   researchData_constantThrustForce  = "1.5 5 Description Here";
   researchData_droneDamageBoost     = "3 10 Description Here";
   
   //Drone Hives
   researchData_droneConstructTime   = "0.35 15 Description Here";
   researchData_droneLaunchTime      = "0.35 15 Description Here";
     
   researchTotalLevels = 10;
   
   //NOTE: datablocks are changin so just hooking up a couple for now. 
   //Unlocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "HiveLauncher_Fighter";
   unlocking[2] = 2 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_Security SPC "HiveLauncher_Fighter_Cloaked";
   unlocking[4] = 2 SPC $RR_Common SPC $RSL_Med SPC $RL_Security SPC "HiveLauncher_Zapper";
   unlocking[6] = 2 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_Security SPC "HiveLauncher_Zapper_Cloaked";
   unlocking[8] = 2 SPC $RR_UnCommon SPC $RSL_High SPC $RL_Security SPC "HiveLauncher_Bomber";
   unlocking[10] = 2 SPC $RR_Rare SPC $RSL_High SPC $RL_Security SPC "HiveLauncher_Bomber_Cloaked";
}; 


///////////////////////////////////////////////////////////////////////////////
// Shields ////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(ShieldResearch : ResearchDatablockBase) 
{   
   researchElements = "shieldMaxStrength shieldRegenSpeed shieldCreateStrength shieldCreateTime shieldDamageMult";
   researchTitle = "SHIELDS";
   
   componentConnection = "Shield";
   subComponentMask = $SHIELD_Shielding;
      
                                  //maxMult maxLevels description 
       
   researchData_shieldMaxStrength      = "7.5 20 Description Here";    
   researchData_shieldRegenSpeed       = "2 10 Description Here";
   researchData_shieldCreateStrength   = "1.5 5 Description Here";   
   researchData_shieldCreateTime       = "0.7 3 Description Here";  
   researchData_shieldDamageMult       = "0.75 5 Description Here"; 
   
   researchTotalLevels = 10;
   
   //Ulocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "S_CivShield" SPC "M_CivShield" SPC "L_CivShield" SPC "H_CivShield";
   unlocking[2] = 2 SPC $RR_Common SPC $RSL_Start SPC $RL_All SPC "S_BasicShield" SPC "M_BasicShield" SPC "L_BasicShield" SPC "H_BasicShield";
   unlocking[3] = 3 SPC $RR_Common SPC $RSL_Low SPC $RL_Mining SPC "ShieldBooster_S" SPC "ShieldBooster_M" SPC "ShieldBooster_L" SPC "ShieldBooster_H";
   unlocking[5] = 5 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_All SPC "S_QuickChargeShield" SPC "M_QuickChargeShield" SPC "L_QuickChargeShield" SPC "H_QuickChargeShield";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_High SPC $RL_Colony SPC "S_FortressShield" SPC "M_FortressShield" SPC "L_FortressShield" SPC "H_FortressShield"; 
  
}; 



///////////////////////////////////////////////////////////////////////////////
// Cloaking ///////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(CloakingResearch : ResearchDatablockBase) 
{  
   researchElements = "cloakDamageBoost shieldCreateStrength cloakEngineSpeedDecrease cloakTurnRateDecrease cloakThrustDecrease shieldMaxStrength shieldRegenSpeed shieldCreateTime shieldDamageMult";
   researchTitle = "CLOAKING";
   
   //Use a sub type here i guess?
   //PROBLEM!  Cross contamination between shield and cloak research!!
   componentConnection = "Shield";  //need cloak component type. 
   subComponentMask = $SHIELD_Cloaking;
   
   researchData_cloakEngineSpeedDecrease = "0 10 Description Here";
   researchData_cloakTurnRateDecrease    = "0 10 Description Here";
   researchData_cloakThrustDecrease      = "0 10 Description Here";
   researchData_cloakDisruptionTime      = "0.25 10 Description Here";
   researchData_cloakDamageBoost         = "2 20 Description Here";
                                  //maxMult maxLevels description 
       
   researchData_shieldMaxStrength      = "4 10 Description Here";    
   researchData_shieldRegenSpeed       = "2 10 Description Here";
   researchData_shieldCreateStrength   = "2 5 Description Here";   
   researchData_shieldCreateTime       = "0.5 5 Description Here";  
   researchData_shieldDamageMult       = "0.75 5 Description Here";  
   
   researchTotalLevels = 10;
   
   //Unlocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "S_CivCloak" SPC "M_CivCloak" SPC "L_CivCloak" SPC "H_CivCloak";

   
   unlocking[2] = 2 SPC $RR_Common SPC $RSL_Low SPC $RL_All SPC "S_BasicCloak" SPC "M_BasicCloak" SPC "L_BasicCloak" SPC "H_BasicCloak";
   unlocking[4] = 4 SPC $RR_Common SPC $RSL_Med SPC $RL_Science SPC "CloakBooster_S" SPC "CloakBooster_M" SPC "CloakBooster_L" SPC "CloakBooster_H";
   unlocking[5] = 5 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_Science SPC "S_StableCloak" SPC "M_StableCloak" SPC "L_StableCloak" SPC "H_StableCloak";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_High SPC $RL_Science SPC "S_ExperimentalCloak" SPC "M_ExperimentalCloak" SPC "L_ExperimentalCloak" SPC "H_ExperimentalCloak";
     
}; 

///////////////////////////////////////////////////////////////////////////////
// Reactors ///////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(ReactorResearch : ResearchDatablockBase) 
{   
   researchElements = "maxReactorOutput capacitorCapacity";
   researchTitle    = "REACTORS";
   
   componentConnection = "Reactor";
   
                                  //maxMult maxLevels description 
   researchData_maxReactorOutput       = "2.5 15 Description Here";
   researchData_capacitorCapacity      = "2.5 15 Description Here";     
   
   //Note: no power consumption here   
   
   
   researchTotalLevels = 10;
   
   //Ulocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "S_CivReactor" SPC "M_CivReactor" SPC "L_CivReactor" SPC "H_CivReactor";
   unlocking[2] = 2 SPC $RR_Common SPC $RSL_Start SPC $RL_All SPC "S_BasicReactor" SPC "M_BasicReactor" SPC "L_BasicReactor" SPC "H_BasicReactor";
   unlocking[3] = 3 SPC $RR_Common SPC $RSL_Low SPC $RL_Mining SPC "ReactorBooster_S" SPC "ReactorBooster_M" SPC "ReactorBooster_L" SPC "ReactorBooster_H";
   unlocking[5] = 5 SPC $RR_Rare SPC $RSL_Med SPC $RL_All SPC "S_HighCapacityReactor" SPC "M_HighCapacityReactor" SPC "L_HighCapacityReactor" SPC "H_HighCapacityReactor";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_High SPC $RL_Security SPC "S_OverchargedReactor" SPC "M_OverchargedReactor" SPC "L_OverchargedReactor" SPC "H_OverchargedReactor"; 
 
}; 


///////////////////////////////////////////////////////////////////////////////
// Engines ////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(EngineResearch : ResearchDatablockBase) 
{ 
   researchElements = "engineMaxSpeed engineThrustForce engineTurnSpeed";
   researchTitle    = "ENGINES";
   
   componentConnection = "Engine";
   
                                  //maxMult maxLevels description 
   researchData_engineThrustForce   = "2 20 Description Here";
   researchData_engineTurnSpeed     = "1.5 5 Description Here";   
   researchData_engineMaxSpeed      = "1.5 10 Description Here"; 
   
     
   researchTotalLevels = 10;
   
   //Ulocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "S_CivEngine" SPC "M_CivEngine" SPC "L_CivEngine" SPC "H_CivEngine";
   unlocking[2] = 2 SPC $RR_Common SPC $RSL_Start SPC $RL_All SPC "S_BasicEngine" SPC "M_BasicEngine" SPC "L_BasicEngine" SPC "H_BasicEngine";
   unlocking[3] = 3 SPC $RR_Common SPC $RSL_Low SPC $RL_All SPC "EngineBooster_S" SPC "EngineBooster_M" SPC "EngineBooster_L" SPC "EngineBooster_H";
   unlocking[5] = 5 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_All SPC "S_ThrusterEngine" SPC "M_ThrusterEngine" SPC "L_ThrusterEngine" SPC "H_ThrusterEngine";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_Med SPC $RL_Science SPC "S_InertialEngine" SPC "M_InertialEngine" SPC "L_InertialEngine" SPC "H_InertialEngine"; 
 
}; 


///////////////////////////////////////////////////////////////////////////////
// Turrets ////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(TurretResearch : ResearchDatablockBase) 
{   
   researchElements = "rotationSpeed";
   researchTitle    = "TURRETS";
   
   componentConnection = "Turret";   
   subComponentMask = $WEAPON_DeployableTurretLauncher; 
                                  //maxMult maxLevels description 
   researchData_rotationSpeed     = "1.5 10 Description Here";
      
   
   researchTotalLevels = 8;   
   
   //Ulocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "SmallTurret" SPC "MediumTurret" SPC "LargeTurret" SPC "HugeTurret" SPC "DeployableTurretLauncher_Surplus_M" SPC "DeployableTurretLauncher_Surplus_L";
   unlocking[1] = 1 SPC $RR_Common SPC $RSL_Low SPC $RL_All SPC "DeployableTurretLauncher_Basic_M" SPC "DeployableTurretLauncher_Basic_L";
   unlocking[2] = 2 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_Security SPC "LargeDoubleTurret" SPC "HugeDoubleTurret" SPC "MediumDoubleTurret";
   unlocking[3] = 3 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_Security SPC "SmallFixedTurretMod" SPC "MediumFixedTurretMod" SPC "LargeFixedTurretMod";
   unlocking[4] = 4 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_All SPC "DeployableTurretLauncher_Leech_M" SPC "DeployableTurretLauncher_Leech_L";
   unlocking[5] = 5 SPC $RR_Rare SPC $RSL_Med SPC $RL_Security SPC "HugeTriTurret";
   unlocking[6] = 6 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_All SPC "DeployableTurretLauncher_Ion_M" SPC "DeployableTurretLauncher_Ion_L";
   unlocking[7] = 7 SPC $RR_UnCommon SPC $RSL_High SPC $RL_Security SPC "DeployableTurretLauncher_TorpRack_M" SPC "DeployableTurretLauncher_TorpRack_L";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_High SPC $RL_Security SPC "DeployableTurretLauncher_BattleStation_M" SPC "DeployableTurretLauncher_BattleStation_L";

}; 


///////////////////////////////////////////////////////////////////////////////
// Armor ////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(ArmorResearch : ResearchDatablockBase) 
{   
   researchElements = "maxComponentHealth baseArmorDamageMult";
   researchTitle    = "ARMOR";
   
   componentConnection = "Armor";      
                                  //maxMult maxLevels description 
   researchData_baseArmorDamageMult  = "0.75 5 Description Here";
   researchData_maxComponentHealth   = "7.5 20 Description Here";   
      
   researchTotalLevels = 10;   
   
   //Ulocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "CivArmor_S CivArmor_M CivArmor_L CivArmor_H";
   unlocking[2] = 2 SPC $RR_Common SPC $RSL_Start SPC $RL_Security SPC "TitaniumArmor_S TitaniumArmor_M TitaniumArmor_L TitaniumArmor_H";
   unlocking[5] = 5 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_Mining SPC "HeavyArmor_S HeavyArmor_M HeavyArmor_L HeavyArmor_H";
   unlocking[8] = 8 SPC $RR_Rare SPC $RSL_High SPC $RL_Security SPC "AdvancedArmor_S AdvancedArmor_M AdvancedArmor_L AdvancedArmor_H";
}; 


///////////////////////////////////////////////////////////////////////////////
// Hulls //////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
datablock ResearchDatablock(HullResearch : ResearchDatablockBase) 
{   
   researchElements = "maxComponentHealth hullBaseDamageMult maxCrewSize hullCargoSpace";
   researchTitle    = "SHIP HULL";
   
   componentConnection = "Hull";   
   
                                  //maxMult maxLevels description 
      
   researchData_maxComponentHealth       = "7.5 20 Description Here";    
   researchData_hullCargoSpace           = "2 5 Description Here";
   researchData_hullBaseDamageMult       = "0.75 5 Description Here";  
   researchData_maxCrewSize              = "2 5 Description Here"; 
     
   researchTotalLevels = 10;

}; 


///////////////////////////////////////////////////////////////////////////////
// SubSystemResearch //////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////

datablock ResearchDatablock(SubSystemResearch : ResearchDatablockBase) 
{   
   researchElements = "boosterPower baseDamage beamLength";
   researchTitle = "SUB SYSTEMS";
   
   componentConnection = "External";
   subComponentMask = $WEAPON_TractorBeamEmitter | $WEAPON_MiningBeamEmitter | $WEAPON_PointDefenseEmitter | $WEAPON_ScannerEmitter; 
   
 
   //Beams
   researchData_baseDamage    = "5 20 How much damage the beam will do";
   researchData_beamLength    = "1.5 5 How long the beam is";
  
   //boosters
   researchData_boosterPower  = "2 10 How effective boosters are";
         
   researchTotalLevels = 10;
   
   //Unlocking cost spc stuff spc stuff (if 0 it is auto unlocked for civ stuff)
   initialUnlockList = "SmallMinerEmitter" SPC "MediumMinerEmitter" SPC "HugeCoreMiner" SPC "MiningTractorEmitter" SPC "LargeMinerEmitter" SPC "TractorEmitter_medium" SPC "TractorEmitter_large" SPC "TractorEmitter_huge" SPC "SurplusScannerEmitter_S" SPC "SurplusScannerEmitter_M" SPC "SurplusScannerEmitter_L" SPC "SurplusScannerEmitter_H";
   unlocking[3] = 2 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_All SPC "PointDefenseBeamEmitter_S" SPC "PointDefenseBeamEmitter_M" SPC "PointDefenseBeamEmitter_L" SPC "PointDefenseBeamEmitter_H";
   unlocking[5] = 4 SPC $RR_UnCommon SPC $RSL_Med SPC $RL_All SPC "ScannerEmitter_S" SPC "ScannerEmitter_M" SPC "ScannerEmitter_L" SPC "ScannerEmitter_H";
  
}; 


///////////////////////////////////////////////////////////////////////////////
// CrewResearch //////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////

datablock ResearchDatablock(CrewResearch : ResearchDatablockBase) 
{   
   researchElements = "combatStrength hacking recruitingChance repairRate maxRange maxSpeed reloadMS shuttleArmor";
   researchTitle = "CREW";
   
   componentConnection = "External";
   subComponentMask = $WEAPON_CrewProjectileCannon; 
   
   //Shuttles:
   researchData_maxRange               = "2 5 How far the shuttle will travel";
   researchData_maxSpeed               = "1.5 5 How fast the shuttle will travel";
   researchData_reloadMS               = "0.5 5 How fast shuttles launch"; 
   researchData_shuttleArmor           = "5 10 Shuttle armor strength";

   //general
   researchData_combatStrength         = "3 15 How fast shuttles launch"; 
   researchData_hacking                = "5 20 How well we steal data"; 
   researchData_recruitingChance       = "4 15 How likley to convert an enemy pod to an ally";
   researchData_repairRate             = "4 15 How fast can crew repair ship damage";
   
         
   researchTotalLevels = 10;
   
   //Note: need to hook up more crew tech here, for repairs, boarding paries etc..
   initialUnlockList = "";
   unlocking[2] = 2 SPC $RR_UnCommon SPC $RSL_Low SPC $RL_Colony SPC "KamakazieCannon_M" SPC "KamakazieCannon_L" SPC "KamakazieCannon_H";
   unlocking[3] = 3 SPC $RR_Common SPC $RSL_Low SPC $RL_Colony SPC "CrewBooster_S" SPC "CrewBooster_M" SPC "CrewBooster_L" SPC "CrewBooster_H";
   unlocking[5] = 5 SPC $RR_Rare SPC $RSL_Med SPC $RL_Colony SPC "ShuttleCannon_L" SPC "ShuttleCannon_H";
}; 



