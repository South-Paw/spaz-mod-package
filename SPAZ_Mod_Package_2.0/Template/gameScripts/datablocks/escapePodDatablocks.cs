
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Escape Pods /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


datablock EscapePodDatablock(EscapePodBase) 
{
   //Stuff from PickupBase, need to redefine, cannot copy across classes.
   collectionDatablock = "beamAbord";  
   collectionSound     = "snd_smallCargoPickup";
   collectionScale     = "1.0";
   
   minLifeSpan = 15000;  //In MS  will vary but this is the minimum
   maxHealth = 100;
   pickupMass = 10;  //keep mass constant for pickups then we can play with their ejection forces.   
    
   objectClass = "";
   objectSuperclass = ""; 
   
   baseBlend = "1 1 1 1";
   pulseBlend = "1 1 1 1";    
   pulseTime = 0;
        
   pulseSize = "32 32";    
   initialStateTime = "800 1200"; //getrandomfrompair
 
   isIntense = false;      
     
   //Escape pod stuff
   initialState = "Attract";
   
   stateEffects["Attract", $PD_EffectDatablock]  = "WhiteFlash";
   stateEffects["Attract", $PD_EffectScale]      = "1";
   stateEffects["Attract", $PD_EffectLinkPoints] = "1";
   
   stateEffects["MovingToTarget", $PD_EffectDatablock]  = "GreenLight";
   stateEffects["MovingToTarget", $PD_EffectScale]      = "2";
   stateEffects["MovingToTarget", $PD_EffectLinkPoints] = "2 3";
     
   size = "32 32";
   CollisionPolyList = "-0.309 -0.678 0.000 -0.908 0.299 -0.697 0.304 0.702 0.000 0.972 -0.309 0.707";
   LinkPoints = "0.000 0.000 0.000 -0.900 0.000 0.900";
   
   
   //Needs to be set on creation
   GraphGroup = 0;  

   explosionDatablock = "escapePod_shatter";
   explosionSound     = "snd_smallExplosion";
   explosionScale     = 1;
   
   spawnEffect = "escapePod_eject";  //cover escape pod spawn
   spawnEffectScale = 2;
   spawnSound = "snd_escapePodEject_smal"; 
   
   brakeEffect = "MissileThruster";
   brakeEffectScale = 0.7;
   brakeEffectSound = "snd_smallLaserHit"; //soft puff sound works well
  
   value = -1;  //DB Ignore
   valueMultiplier = 5;  //to allow AI to better prioritize what to pick up.
};

//////////////////////////////////////////////////////
//Pod Types //////////////////////////////////////////
//////////////////////////////////////////////////////
$LargeEscapePodValue = 10;

datablock EscapePodDatablock(EscapePod_Small : EscapePodBase) 
{
   maxHealth = 2;
   size = "32 32";
   minLifeSpan = 60000;
   
   imageMap["Terran"] = "escapePod_terran_smallImageMap"; 
   imageMap["Pirate"] = "escapePod_pirate_smallImageMap"; 
   imageMap["Civ"]    = "escapePod_civ_smallImageMap"; 
   imageMap["Bounty"]    = "escapePod_bounty_smallImageMap"; 
   
   trackingSpeed = 50;
  
   initialImpulse = 1000;  
   brakeTime = "500 750"; //getrandomfromPiar
   brakingDamping = 2;
   value = 1;
};

datablock EscapePodDatablock(EscapePod_Large : EscapePodBase) 
{
   maxHealth = 5;
   size = "64 64";
   minLifeSpan = 60000;
   brakeEffectScale = 1.2;
   
   spawnSound = "snd_escapePodEject_large";
   spawnEffectScale = 4;
   explosionScale   = 2;
   
   imageMap["Terran"] = "escapePod_terran_largeImageMap"; 
   imageMap["Pirate"] = "escapePod_pirate_largeImageMap"; 
   imageMap["Civ"]    = "escapePod_civ_largeImageMap"; 
   imageMap["Bounty"]    = "escapePod_bounty_largeImageMap"; 
   
   trackingSpeed = 100; 
    
   initialImpulse = 500; 
   brakeTime = "1000 1500";
   
   brakingDamping = 1;
      
   value = $LargeEscapePodValue;
};

/*
snd_abandonShipAlarm
snd_chatter_abandonShip

*/
