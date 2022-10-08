
function TurretDatablock::onAdd(%this)
{ 
   if( %this.getName() $= "TurretBase" )
      return;
            
   Parent::onAdd(%this);            
}




datablock TurretDatablock(TurretBase : ComponentBase) 
{   
   imageMap_Default = "turret_basicImageMap";  
   imageMap_Zombie = "turret_zombieImageMap";   
      
   size  = "32 32";
   maxRotation = 360;  //degrees
   rotationSpeed = 180;  //degrees per second  
   LinkPoints = "0.000 -0.300 0.000 0.000";  
   CollisionPolyList = "-0.702 -0.206 0.691 -0.206 0.728 0.029 0.566 0.462 0.157 0.697 -0.236 0.678 -0.560 0.447 -0.733 0.025";
   mountLayerOffset = 0;   //on top  (will sort on top)
   
   turretLinkPoints = "1";
      
   turretLinkType1  = $LINK_Shooter;
   turretLinkSize1  = $SLOT_SMALL;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   componentType              = "Turret";  
   componentSubType           = $WEAPON_Turret;
   
   //Must define since no inheritance across classes. (so cannon inherit this from component base)
   componentMass                   = 0;
   powerConsumption                = 1;
   

   componentSize              = $SLOT_SMALL;   
   
   isAutomated                = true;  //currently only mining turrets are automated. need to decide if turrest should concentrate fire on traget or shoot whatever is available. 

   researchDatablock = "TurretResearch";
   
   componentButtonColor        = "Civ";
   
   purchaseTutorial = "PT_basicTurret";
};


function TurretDatablock::GetFactionImageMap(%this, %factionName)
{
   %imageMap = %this.imageMap_[%factionName];
   if ( %imageMap $= "" )
      %imageMap = %this.imageMap_Default;
       
   return %imageMap;
}

///////////////////////////////////////////////////////////////////////////
// Small Turrets ///////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////



datablock TurretDatablock(SmallTurret : TurretBase) 
{   
   friendlyName = "Small Turret"; 
   
   size  = "32 32";
   rotationSpeed = 100;  //degrees per second  
   
   powerConsumption           = 1;  
   

   componentSize              = $SLOT_SMALL;    
   
   turretLinkSize1  = $SLOT_SMALL; 
   
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_singleTurret";

   
   RUCost                      = 5; 

};

datablock TurretDatablock(SmallFixedTurretMod : TurretBase) 
{   
   friendlyName = "Small Fixed Turret Mod"; 
   
   imageMap_Default = "turret_fixedImageMap";  
   imageMap_Zombie = "turret_fixed_zombieImageMap";   
   
   size  = "32 32";
   rotationSpeed = 0;  //degrees per second  
   maxRotation = 0;  //degrees
   
   powerConsumption           = 1;  
   

   componentSize              = $SLOT_SMALL;    
   
   turretLinkSize1  = $SLOT_MEDIUM; 
   
   componentButtonBitmap       = $compButtonType_S;
   componentButtonSize         = $compButtonSize_S;
   componentIconGraphic        = "shipconIcon_fixedTurret";

   purchaseTutorial            = "PT_FixedTurretMod";
   componentButtonColor        = "Basic";
   RUCost                      = 5; 
};


///////////////////////////////////////////////////////////////////////////
// Medium Turrets ///////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////



datablock TurretDatablock(MediumTurret : TurretBase) 
{    
   friendlyName = "Medium Turret";    
    
   rotationSpeed = 90;  
   size  = "48 48";
   
   powerConsumption           = 10;   
   

   componentSize              = $SLOT_MEDIUM;     
   
   turretLinkSize1  = $SLOT_MEDIUM; 
   
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_singleTurret";

   RUCost                      = 10;  

};

datablock TurretDatablock(MediumFixedTurretMod : TurretBase) 
{   
   friendlyName = "Medium Fixed Turret Mod"; 

   imageMap_Default = "turret_fixedImageMap";  
   imageMap_Zombie = "turret_fixed_zombieImageMap";   
   
   size  = "48 48";
   rotationSpeed = 0;  //degrees per second  
   maxRotation = 0;  //degrees
   
   powerConsumption           = 1;  
   

   componentSize              = $SLOT_MEDIUM;    
   
   turretLinkSize1  = $SLOT_LARGE; 
   
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_fixedTurret";

   purchaseTutorial            = "PT_FixedTurretMod";
   componentButtonColor        = "Basic";
   
   RUCost                      = 10; 
};

datablock TurretDatablock(MediumDoubleTurret : TurretBase) 
{   
   friendlyName = "Medium Double Turret"; 
     
   rotationSpeed = 75;  
   size  = "48 48";
   imageMap_Default = "turret_doubleImageMap"; 
   imageMap_Zombie = "turret_double_zomImageMap";    
   
   powerConsumption           = 10;   
   
   componentSize              = $SLOT_MEDIUM;     
   
   LinkPoints = "-0.388 -0.496 0.403 -0.511";
   turretLinkPoints = "1 2";
      
   turretLinkType1  = $LINK_Shooter;
   turretLinkSize1  = $SLOT_SMALL;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Shooter;
   turretLinkSize2  = $SLOT_SMALL;  
   turretLinkHomeRotation2 = "0"; //in case we want converging turrets, WACKO!"
   
   componentButtonBitmap       = $compButtonType_M;
   componentButtonSize         = $compButtonSize_M;
   componentIconGraphic        = "shipconIcon_doubleTurret";

   RUCost                      = 12;    

   componentButtonColor        = "Improved";
   
   purchaseTutorial = "PT_doubleTurret";
};

///////////////////////////////////////////////////////////////////////////
// Large Turrets //////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////



datablock TurretDatablock(LargeTurret : TurretBase) 
{     
   friendlyName = "Large Turret";    
   
   rotationSpeed = 80;  
   size  = "56 56";
   
   powerConsumption           = 100;   
   

   componentSize              = $SLOT_LARGE;     
   
   turretLinkSize1  = $SLOT_LARGE; 
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_singleTurret";

   RUCost                      = 75; 

};

datablock TurretDatablock(LargeFixedTurretMod : TurretBase) 
{   
   friendlyName = "Large Fixed Turret Mod"; 
   
   imageMap_Default = "turret_fixedImageMap";  
   imageMap_Zombie = "turret_fixed_zombieImageMap";   
   
   size  = "56 56";
   rotationSpeed = 0;  //degrees per second  
   maxRotation = 0;  //degrees
   
   powerConsumption           = 1;  
   

   componentSize              = $SLOT_LARGE;    
   
   turretLinkSize1  = $SLOT_HUGE; 
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_fixedTurret";

   purchaseTutorial            = "PT_FixedTurretMod";
   componentButtonColor        = "Basic";
   
   RUCost                      = 75; 
};


datablock TurretDatablock(LargeDoubleTurret : TurretBase) 
{   
   friendlyName = "Large Double Turret"; 
     
   rotationSpeed = 70;  
   size  = "56 56";
   imageMap_Default = "turret_doubleImageMap"; 
   imageMap_Zombie = "turret_double_zomImageMap";    
   
   powerConsumption           = 100;   
   

   componentSize              = $SLOT_LARGE;     
   
   LinkPoints = "-0.388 -0.496 0.403 -0.511";
   turretLinkPoints = "1 2";
      
   turretLinkType1  = $LINK_Shooter;
   turretLinkSize1  = $SLOT_MEDIUM;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Shooter;
   turretLinkSize2  = $SLOT_MEDIUM;  
   turretLinkHomeRotation2 = "0"; //in case we want converging turrets, WACKO!"
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_doubleTurret";

   RUCost                      = 75;    

   
   componentButtonColor        = "Improved";
   
   purchaseTutorial = "PT_doubleTurret";
};

datablock TurretDatablock(LargeDoubleTurret_zombie : TurretBase) 
{  
   friendlyName = "Large Double Zombie Turret"; 
      
   rotationSpeed = 40;  
   size  = "128 128";
   imageMap_Zombie = "double_turret_zombie_01ImageMap";   
   
   powerConsumption           = 100;   
   

   componentSize              = $SLOT_LARGE;     
   
   LinkPoints = "-0.665 -0.688 0.073 -0.825";
   turretLinkPoints = "1 2";
      
   turretLinkType1  = $LINK_Universal;
   turretLinkSize1  = $SLOT_MEDIUM;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Universal;
   turretLinkSize2  = $SLOT_MEDIUM;  
   turretLinkHomeRotation2 = "0"; //in case we want converging turrets, WACKO!"
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_doubleTurret";

       
};

///////////////////////////////////////////////////////////////////////////
// Huge Turrets ///////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////


datablock TurretDatablock(HugeTurret : TurretBase) 
{    
   friendlyName = "Huge Turret"; 
    
   rotationSpeed = 50;  
   size  = "64 64";
   
   powerConsumption           = 1000;   
   

   componentSize              = $SLOT_HUGE;     
   
   turretLinkSize1  = $SLOT_HUGE;  
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_singleTurret";

   RUCost                      = 100;

};

//Special for bounty bases.
datablock TurretDatablock(HugeMotherTurret_Bounty : TurretBase) 
{    
   friendlyName = "Huge Mothership Turret"; 
    
   rotationSpeed = 30;  
   size  = "64 64";
   
   powerConsumption           = 1;   
   

   componentSize              = $SLOT_HUGE;     
   
   turretLinkSize1  = $SLOT_MOTHERSHIP;  
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_singleTurret";

   RUCost                      = 100;

};


datablock TurretDatablock(HugeDoubleTurret : TurretBase) 
{   
   friendlyName = "Huge Double Turret"; 
     
   rotationSpeed = 50;  
   size  = "64 64";
   imageMap_Default = "turret_doubleImageMap"; 
   imageMap_Zombie = "turret_double_zomImageMap";    
   
   powerConsumption           = 1000;   
   
   componentSize              = $SLOT_HUGE;     
   
   LinkPoints = "-0.388 -0.496 0.403 -0.511";
   turretLinkPoints = "1 2";
      
   turretLinkType1  = $LINK_Shooter;
   turretLinkSize1  = $SLOT_LARGE;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Shooter;
   turretLinkSize2  = $SLOT_LARGE;  
   turretLinkHomeRotation2 = "0"; //in case we want converging turrets, WACKO!"
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_doubleTurret";

   RUCost                      = 100;    

   componentButtonColor        = "Improved";
   
   purchaseTutorial = "PT_doubleTurret";
};

datablock TurretDatablock(HugeTriTurret : TurretBase) 
{    
   friendlyName = "Huge Triple Turret"; 
    
   rotationSpeed = 45;  
   size  = "64 64";
   imageMap_Default = "turret_triImageMap"; 
   imageMap_Zombie = "turret_tri_zomImageMap";     
   
   powerConsumption           = 1000;   
   

   componentSize              = $SLOT_HUGE;     
   
   LinkPoints = "0.000 -0.511 -0.566 -0.300 0.571 -0.309";
   turretLinkPoints = "1 2 3";
      
   turretLinkType1  = $LINK_Shooter;
   turretLinkSize1  = $SLOT_LARGE;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Shooter;
   turretLinkSize2  = $SLOT_LARGE;  
   turretLinkHomeRotation2 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType3  = $LINK_Shooter;
   turretLinkSize3  = $SLOT_LARGE;  
   turretLinkHomeRotation3 = "0"; //in case we want converging turrets, WACKO!"
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_trippleTurret";

   
   RUCost                      = 100;    

   
   componentButtonColor        = "Advanced";
   
   purchaseTutorial = "PT_tripleTurret";
};

//zombie stuff

datablock TurretDatablock(HugeTriTurret_zombie : TurretBase) 
{    
   friendlyName = "Huge Triple Zombie Turret";    
    
   rotationSpeed = 30;  
   size  = "256 256";
   imageMap_Zombie = "tri_turret_zombie_01ImageMap";   
   
   powerConsumption           = 1000;   
   

   componentSize              = $SLOT_HUGE;     
   
   LinkPoints = "-0.482 -0.354 -0.157 -0.565 0.560 -0.874";  
   turretLinkPoints = "1 2 3";
      
   turretLinkType1  = $LINK_Universal;
   turretLinkSize1  = $SLOT_LARGE;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Universal;
   turretLinkSize2  = $SLOT_LARGE;  
   turretLinkHomeRotation2 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType3  = $LINK_Universal;
   turretLinkSize3  = $SLOT_LARGE;  
   turretLinkHomeRotation3 = "0"; //in case we want converging turrets, WACKO!"
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_trippleTurret";


       
};

datablock TurretDatablock(ZombieCorruptionTurret : TurretBase) 
{   
   friendlyName = "Corruption Turret"; 
    
   imageMap_Default = "alphaPixelImageMap";  
   imageMap_Zombie = "alphaPixelImageMap";     
   LinkPoints = "0 0";
   
   rotationSpeed = 45;  
   size  = "16 16";
   
   powerConsumption           = 1000;   
   

   componentSize              = $SLOT_HUGE;     
   
   turretLinkSize1  = $SLOT_HUGE;  
   turretLinkType1  = $LINK_Shooter;
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_mineTurret";

   RUCost                      = 75;    
   
   isAutomated                = true;

};

///////////////////////////////////////////////////////////////////////////
// Mining Turrets ///////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////








datablock TurretDatablock(LargeMiningDoubleTurret : TurretBase) 
{     
   friendlyName = "Large Double Mining Turret"; 
   
   imageMap_Civ = "turret_minerImageMap"; 
   
   rotationSpeed = 40;  
   size  = "48 48";
   
   powerConsumption           = 100;   
   
   componentSize              = $SLOT_LARGE;     
   
   LinkPoints = "0.200 -0.250 -0.200 -0.250";   
   turretLinkPoints = "1 2";
      
   turretLinkType1  = $LINK_Shooter;
   turretLinkSize1  = $SLOT_MEDIUM;  
   turretLinkHomeRotation1 = "-0.4"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Shooter;
   turretLinkSize2  = $SLOT_MEDIUM;  
   turretLinkHomeRotation2 = "0.4"; //in case we want converging turrets, WACKO!"
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_doubleMineTurret";

   
   RUCost                      = 20;   
   isAutomated                = true;

};


datablock TurretDatablock(LargeMiningTurret : TurretBase) 
{     
   friendlyName = "Large Mining Turret"; 
   
   imageMap_Civ = "turret_minerImageMap";
   
   rotationSpeed = 40;  
   size  = "48 48";
   
   powerConsumption           = 100;   
   
     
   componentSize              = $SLOT_LARGE;     
   
   LinkPoints = "0.0 -0.250";   
   turretLinkPoints = "1";
      
   turretLinkType1  = $LINK_Shooter;
   turretLinkSize1  = $SLOT_LARGE;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"  
   
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_mineTurret";

   RUCost                      = 20;
       
   isAutomated                = true;

};




datablock TurretDatablock(HugeMiningTurret : TurretBase) 
{    
   friendlyName = "Huge Mining Turret"; 
    
   imageMap_Civ = "turret_minerImageMap";
   LinkPoints = "0.000 -0.500";
   
   rotationSpeed = 30;  
   size  = "64 64";
   
   powerConsumption           = 1000;   
   
   
   componentSize              = $SLOT_HUGE;     
   
   turretLinkSize1  = $SLOT_HUGE;  
   turretLinkType1  = $LINK_Shooter;
   
   componentButtonBitmap       = $compButtonType_H;
   componentButtonSize         = $compButtonSize_H;
   componentIconGraphic        = "shipconIcon_mineTurret";

   RUCost                      = 75;    
   
   isAutomated                = true;

};





////////////////////////////////////////////////////////////////////////////////
// deploy turrets
////////////////////////////////////////////////////////////////////////////////

datablock TurretDatablock(DeployTurret_Single : TurretBase) 
{  
   friendlyName = "Medium Deployable Turret"; 
      
   rotationSpeed = 180;  
   size  = "48 48";
   
   imageMap_Default = "turret_deployCustomImageMap"; 
   imageMap_Civ = "turret_deployCustomImageMap";   
   imageMap_Terran = "turret_deployCustomImageMap";   
   imageMap_Pirate = "turret_deployCustomImageMap";   
   imageMap_Zombie = "turret_deployCustomImageMap";   
   
   powerConsumption           = 10;   

   componentSize              = $SLOT_MEDIUM;     
   
   LinkPoints = "0 0";
   turretLinkPoints = "1";
      
   turretLinkType1  = $LINK_Universal;
   turretLinkSize1  = $SLOT_HUGE;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   componentButtonBitmap       = $compButtonType_L;
   componentButtonSize         = $compButtonSize_L;
   componentIconGraphic        = "shipconIcon_singleTurret";    
};

datablock TurretDatablock(DeployTurret_Dual : DeployTurret_Single) 
{ 
   rotationSpeed = 135;  
   
   LinkPoints = "-0.667 0 0.667 0";
   turretLinkPoints = "1 2";
      
   turretLinkType1  = $LINK_Universal;
   turretLinkSize1  = $SLOT_HUGE;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Universal;
   turretLinkSize2  = $SLOT_HUGE;  
   turretLinkHomeRotation2 = "0"; //in case we want converging turrets, WACKO!"

};

datablock TurretDatablock(DeployTurret_Tri : DeployTurret_Single) 
{ 
   rotationSpeed = 90;  
   
   LinkPoints = "-0.866 0.300 0.000 0.0 0.866 0.300";
   turretLinkPoints = "1 2 3";
      
   turretLinkType1  = $LINK_Universal;
   turretLinkSize1  = $SLOT_HUGE;  
   turretLinkHomeRotation1 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType2  = $LINK_Universal;
   turretLinkSize2  = $SLOT_HUGE;  
   turretLinkHomeRotation2 = "0"; //in case we want converging turrets, WACKO!"
   
   turretLinkType3  = $LINK_Universal;
   turretLinkSize3  = $SLOT_HUGE;  
   turretLinkHomeRotation3 = "0"; //in case we want converging turrets, WACKO!"   
};



