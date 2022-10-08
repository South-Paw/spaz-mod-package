///////////////////////////////////////////////////////////////////////////////
// Crew Cannons ///////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////

function CrewProjectileWeaponDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "CrewProjectileCannonBase" )
      return;
       
   Parent::onAdd(%this);            
}

//TUNING DATA HANDLED IN projectileWeaponDatablocks
//TUNING DATA HANDLED IN projectileWeaponDatablocks
//TUNING DATA HANDLED IN projectileWeaponDatablocks
//TUNING DATA HANDLED IN projectileWeaponDatablocks
//TUNING DATA HANDLED IN projectileWeaponDatablocks


//Nore: Cannot inherit from: ProjectileCannonBase as it is another class.  it wont work right
datablock CrewProjectileWeaponDatablock(CrewProjectileCannonBase : WeaponBase) 
{   
   componentType      = "External";
   componentSubType   = $WEAPON_CrewProjectileCannon;
   isAutomated        = false;
   isBurstCannon      = false;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   
   damageMult        = "1";  
   speedMult         = "1";  
   rangeMult         = "1";   
   
   clusterCount = 1;
   
   WeaponMountDatablock = "DefaultWeaponMount";   
   researchDatablock = "CrewResearch";   
   componentButtonColor = "Basic";
   
   purchaseTutorial = "PT_crewShuttle";
   
   //Multiple weapons threats can be true, like a long laser is highly effective at long range and somewhat effective at short.
   //we care about relative effectivness.  so a shorter beamed laser of same size would be more effective so the long laser even tho it does 100% damage would be downgraded
   threat_Long = $WT_None;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_None;  //long range lasers and projectiles
   threat_Short = $WT_None; //$WT_None $WT_Low $WT_Med $WT_High
};


datablock CrewProjectileWeaponDatablock(KamakazieCannon_M : CrewProjectileCannonBase) 
{
   friendlyName = "Kamakazie Cannon";      
   
   reloadMS          = "200";
   burstSize         = "1";
   ammoType          = "CrewCannonBullet_Kamakazie";
            

   componentSize      = $SLOT_MEDIUM;    
   
   myType = "CREW"; //used for procedural systmes.
   hullType = $HULLTYPE_MEDIUM; //used for procedural systmes.
   referenceReactor = "M_BasicReactor"; //used to determine power consumption

   
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_cannon";  
   
   clusterSpread      = "0";  //Must be acurate to be fair 
   
   componentIconGraphic        = "shipconIcon_shuttleSuicide";
   
   

   
   componentButtonColor        = "Improved";
   
   WeaponMountDatablock = "CrewCannonMount_Kamakazie";   
   
   cannonSuperClass = "CrewCannonClass";
   cannonClass = "KamakazieCannonClass";
   
   purchaseTutorial = "PT_crewCannon";
   
   threat_Long = $WT_None;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Low;  //long range lasers and projectiles
   threat_Short = $WT_Med; //$WT_None $WT_Low $WT_Med $WT_High
};

datablock CrewProjectileWeaponDatablock(KamakazieCannon_L : KamakazieCannon_M) 
{
   componentSize      = $SLOT_LARGE;  
};

datablock CrewProjectileWeaponDatablock(KamakazieCannon_H : KamakazieCannon_M) 
{
   componentSize      = $SLOT_HUGE;  
};





datablock CrewProjectileWeaponDatablock(ShuttleCannon_L : CrewProjectileCannonBase) 
{
   friendlyName = "Crew Shuttle Cannon";   
   
   reloadMS          = "500";
   burstSize         = "1";
   ammoType          = "CrewCannonBullet_Shuttle";
           

   componentSize      = $SLOT_LARGE;  
     
   myType = "CREW"; //used for procedural systmes.
   hullType = $HULLTYPE_LARGE; //used for procedural systmes.
   referenceReactor = "L_BasicReactor"; //used to determine power consumption

   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_NA";  
   
   clusterSpread     = "30";  //seek targets, avoid fire
   
   componentIconGraphic        = "shipconIcon_shuttleLarge";
   
   RUCost                      = 50;

   
   componentButtonColor        = "Advanced";
   
   WeaponMountDatablock = "CrewCannonMount_Shuttle";   
   
   cannonSuperClass = "CrewCannonClass";
   cannonClass = "ShuttleCannonClass";
   
   threat_Long = $WT_High;  //missiles, torps, mass bombs, maybe fighters
   threat_Medium = $WT_Med;  //long range lasers and projectiles
   threat_Short = $WT_Low; //$WT_None $WT_Low $WT_Med $WT_High
};

datablock CrewProjectileWeaponDatablock(ShuttleCannon_H : ShuttleCannon_L) 
{
   componentSize      = $SLOT_HUGE;  
};


