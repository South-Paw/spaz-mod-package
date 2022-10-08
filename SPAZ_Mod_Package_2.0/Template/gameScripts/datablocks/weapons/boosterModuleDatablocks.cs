//stuff

//IMPORTANT: BOOSTER MOD VALUES >0.25 are BAD!
//IMPORTANT: BOOSTER MOD VALUES >0.25 are BAD!
//IMPORTANT: BOOSTER MOD VALUES >0.25 are BAD!
//IMPORTANT: BOOSTER MOD VALUES >0.25 are BAD!
//IMPORTANT: BOOSTER MOD VALUES >0.25 are BAD!
//IMPORTANT: BOOSTER MOD VALUES >0.25 are BAD!


//For simpler tuning.
$BoosterCost_Small  = 5;
$BoosterCost_Medium = 25;
$BoosterCost_Large  = 150;
$BoosterCost_Huge   = 500;


function BoosterModuleDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "BoosterModuleBase" )
      return;
  
   Parent::onAdd(%this);            
}




datablock BoosterModuleDatablock(BoosterModuleBase : WeaponBase) 
{   
   componentType      = "External";
   componentSubType   = $WEAPON_BoosterModule;
   isAutomated        = false;
     
 
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 0;
   
   WeaponMountDatablock = "DefaultWeaponMount";   
   researchDatablock    = "SubSystemResearch";   
   componentButtonColor        = "Booster";
   
   boosterPower = 1.0;
   
   purchaseTutorial = "PT_boosterModule_shield";
   
};

//////////////////////////////////////////
// Shield Booster ////////////////////////
//////////////////////////////////////////


//Make booster univesal so works the same on all sized craft. 
datablock BoosterModuleDatablock(ShieldBooster_S : BoosterModuleBase) 
{
   friendlyName = "Shield Booster";   
   componentIconGraphic        = "shipconIcon_boost_shield";          
  
   RUCost                      = $BoosterCost_Small;

   
   boost_researchDatablock  = "ShieldResearch";
   boost_componentType      = "Shield";
   boost_componentSubType   = $SHIELD_Shielding; 
   
   //Note: boosters boost the effects of other positive boosters, and dimimish effects of negative boosters.
   //topic for discussion.
   boostVars[0] = "shieldMaxStrength 0.20";
   boostVars[1] = "shieldRegenSpeed 0.20";
   boostVars[2] = "shieldCreateTime -0.20";   //note the negative
   
   //Functionality needs to be size relative.  
   WeaponMountDatablock = "BoosterMount_Shield_S";    
      
   componentSize               = $SLOT_SMALL;          
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   
   purchaseTutorial = "PT_boosterModule_shield";  
};

datablock BoosterModuleDatablock(ShieldBooster_M : ShieldBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Shield_M";    
   
   RUCost                      = $BoosterCost_Medium;
   
   
   componentSize               = $SLOT_MEDIUM;          
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
};

datablock BoosterModuleDatablock(ShieldBooster_L : ShieldBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Shield_L";  
   
   RUCost                      = $BoosterCost_Large;  
   
   componentSize               = $SLOT_LARGE;          
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
};

datablock BoosterModuleDatablock(ShieldBooster_H : ShieldBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Shield_H";  
   
   RUCost                      = $BoosterCost_Huge;    
   
   componentSize               = $SLOT_HUGE;          
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
};

//////////////////////////////////////////
// Reactor Booster ////////////////////////
//////////////////////////////////////////

   
//Make booster univesal so works the same on all sized craft. 
datablock BoosterModuleDatablock(ReactorBooster_S : BoosterModuleBase) 
{
   friendlyName = "Reactor Booster";   
   componentIconGraphic = "shipconIcon_boost_reactor";          
  
   RUCost                      = $BoosterCost_Small;

   boost_researchDatablock  = "ReactorResearch";
   boost_componentType      = "Reactor";
   boost_componentSubType   = ""; 
  
   boostVars[0] = "maxReactorOutput 0.25";
   boostVars[1] = "capacitorCapacity 0.25";
      
   WeaponMountDatablock = "BoosterMount_Reactor_S";    
      
   componentSize               = $SLOT_SMALL;          
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   
   purchaseTutorial = "PT_boosterModule_reactor";  
};

datablock BoosterModuleDatablock(ReactorBooster_M : ReactorBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Reactor_M";  
   
   RUCost                      = $BoosterCost_Medium;  
   
   componentSize               = $SLOT_MEDIUM;          
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
};

datablock BoosterModuleDatablock(ReactorBooster_L : ReactorBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Reactor_L";   
   
   RUCost                      = $BoosterCost_Large;   
   
   componentSize               = $SLOT_LARGE;          
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
};

datablock BoosterModuleDatablock(ReactorBooster_H : ReactorBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Reactor_H";    
   
   RUCost                      = $BoosterCost_Huge;
   
   componentSize               = $SLOT_HUGE;          
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
};



//////////////////////////////////////////
// Engine Booster ////////////////////////
//////////////////////////////////////////
   
datablock BoosterModuleDatablock(EngineBooster_S : BoosterModuleBase) 
{
   friendlyName = "Engine Booster";   
   componentIconGraphic = "shipconIcon_boost_engine";          
  
   RUCost                      = $BoosterCost_Small;

   boost_researchDatablock  = "EngineResearch";
   boost_componentType      = "Engine";
   boost_componentSubType   = ""; 
  
   boostVars[0] = "engineThrustForce 0.25";
   boostVars[1] = "engineTurnSpeed 0.25";
   boostVars[2] = "engineMaxSpeed 0.10";   //not much speed improvement
      
   WeaponMountDatablock = "BoosterMount_Engines_S";    
      
   componentSize               = $SLOT_SMALL;          
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S; 
   
   purchaseTutorial = "PT_boosterModule_engine"; 
};

datablock BoosterModuleDatablock(EngineBooster_M : EngineBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Engines_M";   
   
   RUCost                      = $BoosterCost_Medium; 
   
   componentSize               = $SLOT_MEDIUM;          
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
};

datablock BoosterModuleDatablock(EngineBooster_L : EngineBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Engines_L"; 
   
   RUCost                      = $BoosterCost_Large;     
   
   componentSize               = $SLOT_LARGE;          
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
};

datablock BoosterModuleDatablock(EngineBooster_H : EngineBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Engines_H";    
   
   RUCost                      = $BoosterCost_Huge;
   
   componentSize               = $SLOT_HUGE;          
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
};


//////////////////////////////////////////
// Cloak Booster ////////////////////////
//////////////////////////////////////////
         
datablock BoosterModuleDatablock(CloakBooster_S : BoosterModuleBase) 
{
   friendlyName = "Cloak Booster";   
   componentIconGraphic = "shipconIcon_boost_cloak";          
  
   RUCost                      = $BoosterCost_Small;

   boost_researchDatablock  = "CloakingResearch";
   boost_componentType      = "Shield";
   boost_componentSubType   = $SHIELD_Cloaking; 
  
   boostVars[0] = "shieldMaxStrength 0.20";
   boostVars[1] = "shieldRegenSpeed 0.20";
   boostVars[2] = "shieldCreateTime -0.20";   
   boostVars[3] = "cloakDisruptionTime -0.20";
     
   WeaponMountDatablock = "BoosterMount_Cloak_S";    
      
   componentSize               = $SLOT_SMALL;          
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   
   purchaseTutorial = "PT_boosterModule_cloak";  
};

datablock BoosterModuleDatablock(CloakBooster_M : CloakBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Cloak_M";    
   
   RUCost                      = $BoosterCost_Medium;
   
   componentSize               = $SLOT_MEDIUM;          
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
};

datablock BoosterModuleDatablock(CloakBooster_L : CloakBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Cloak_L";    
      
   RUCost                      = $BoosterCost_Large;  
   
   componentSize               = $SLOT_LARGE;          
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
};

datablock BoosterModuleDatablock(CloakBooster_H : CloakBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Cloak_H";    
   
   RUCost                      = $BoosterCost_Huge;
   
   componentSize               = $SLOT_HUGE;          
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
};


//////////////////////////////////////////
// Crew Booster //////////////////////////
//////////////////////////////////////////
         
datablock BoosterModuleDatablock(CrewBooster_S : BoosterModuleBase) 
{
   friendlyName = "Crew Booster";   
   componentIconGraphic = "shipconIcon_boost_crew";          
  
   RUCost                      = $BoosterCost_Small;

   boost_researchDatablock  = "CrewResearch";
   boost_componentType      = "Hull";
   boost_componentSubType   = ""; 
  
   boostVars[0] = "maxCrewSize 0.25";
       
   WeaponMountDatablock = "BoosterMount_Crew_S";    
      
   componentSize               = $SLOT_SMALL;          
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   
   purchaseTutorial = "PT_boosterModule_crew";    
};

datablock BoosterModuleDatablock(CrewBooster_M : CrewBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Crew_M";  
   
   RUCost                      = $BoosterCost_Medium;  
   
   componentSize               = $SLOT_MEDIUM;          
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
};

datablock BoosterModuleDatablock(CrewBooster_L : CrewBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Crew_L";    
   
   RUCost                      = $BoosterCost_Large;  
   
   componentSize               = $SLOT_LARGE;          
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
};

datablock BoosterModuleDatablock(CrewBooster_H : CrewBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Crew_H";    
   
   RUCost                      = $BoosterCost_Huge;
   
   componentSize               = $SLOT_HUGE;          
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
};


//////////////////////////////////////////
// Launcher Booster///////////////////////
//////////////////////////////////////////
         
datablock BoosterModuleDatablock(LauncherBooster_S : BoosterModuleBase) 
{
   friendlyName = "Launcher Booster";   
   componentIconGraphic = "shipconIcon_boost_launcher";          
  
   RUCost                      = $BoosterCost_Small;

   boost_researchDatablock  = "MissileResearch";
   boost_componentType      = "External";
   boost_componentSubType   = $WEAPON_MissileLauncher SPC $WEAPON_TorpedoLauncher SPC $WEAPON_RocketLauncher; 
  
   boostVars[0] = "reloadMS -0.10";
   boostVars[1] = "missileDamageMult 0.15";
   
        
   WeaponMountDatablock = "BoosterMount_Launcher_S";    
      
   componentSize               = $SLOT_SMALL;          
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   
   purchaseTutorial = "PT_boosterModule_launcher";    
};

datablock BoosterModuleDatablock(LauncherBooster_M : LauncherBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Launcher_M";    
   
   RUCost                      = $BoosterCost_Medium;
   
   componentSize               = $SLOT_MEDIUM;          
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
};

datablock BoosterModuleDatablock(LauncherBooster_L : LauncherBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Launcher_L"; 
   
   RUCost                      = $BoosterCost_Large;     
   
   componentSize               = $SLOT_LARGE;          
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
};

datablock BoosterModuleDatablock(LauncherBooster_H : LauncherBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Launcher_H";    
   
   RUCost                      = $BoosterCost_Huge;
   
   componentSize               = $SLOT_HUGE;          
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
};





//////////////////////////////////////////
// Cannon Booster///////////////////////
//////////////////////////////////////////
         
datablock BoosterModuleDatablock(CannonBooster_S : BoosterModuleBase) 
{
   friendlyName = "Cannon Booster";   
   componentIconGraphic = "shipconIcon_boost_cannon";          
  
   RUCost                      = $BoosterCost_Small;

   boost_researchDatablock  = "ProjectileResearch";
   boost_componentType      = "External";
   boost_componentSubType   = $WEAPON_ProjectileCannon; 
  
   boostVars[0] = "reloadMS -0.10";
   boostVars[1] = "ammoSpeed 0.10";
   boostVars[2] = "ammoRange 0.10";
   boostVars[3] = "ammoDamage 0.125";
          
   WeaponMountDatablock = "BoosterMount_Cannon_S";    
      
   componentSize               = $SLOT_SMALL;          
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   
   purchaseTutorial = "PT_boosterModule_cannon";    
};

datablock BoosterModuleDatablock(CannonBooster_M : CannonBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Cannon_M";  
   
   RUCost                      = $BoosterCost_Medium;  
   
   componentSize               = $SLOT_MEDIUM;          
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
};

datablock BoosterModuleDatablock(CannonBooster_L : CannonBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Cannon_L";  
   
   RUCost                      = $BoosterCost_Large;    
   
   componentSize               = $SLOT_LARGE;          
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
};

datablock BoosterModuleDatablock(CannonBooster_H : CannonBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Cannon_H";    
   
   RUCost                      = $BoosterCost_Huge;
   
   componentSize               = $SLOT_HUGE;          
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
};



//////////////////////////////////////////
// Beam Booster //////////////////////////
//////////////////////////////////////////
         
datablock BoosterModuleDatablock(BeamBooster_S : BoosterModuleBase) 
{
   friendlyName = "Beam Booster";   
   componentIconGraphic = "shipconIcon_boost_emitter";          
  
   RUCost                      = $BoosterCost_Small;

   boost_researchDatablock  = "BeamResearch";
   boost_componentType      = "External";
   boost_componentSubType   = $WEAPON_BeamEmitter; 
  
   boostVars[0] = "chargeBoost -0.10";
   boostVars[1] = "regenBoost -0.10";
   boostVars[2] = "beamDamage 0.125";
   boostVars[3] = "beamLength 0.10";
   
        
   WeaponMountDatablock = "BoosterMount_Beam_S";    
      
   componentSize               = $SLOT_SMALL;          
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   
   purchaseTutorial = "PT_boosterModule_beam";    
};

datablock BoosterModuleDatablock(BeamBooster_M : BeamBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Beam_M"; 
   
   RUCost                      = $BoosterCost_Medium;   
   
   componentSize               = $SLOT_MEDIUM;          
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M; 
};

datablock BoosterModuleDatablock(BeamBooster_L : BeamBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Beam_L";    
   
   RUCost                      = $BoosterCost_Large;  
   
   componentSize               = $SLOT_LARGE;          
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L; 
};

datablock BoosterModuleDatablock(BeamBooster_H : BeamBooster_S) 
{
   WeaponMountDatablock = "BoosterMount_Beam_H";    
   
   RUCost                      = $BoosterCost_Huge;
   
   componentSize               = $SLOT_HUGE;          
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H; 
};


