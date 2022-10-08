
/*
enum eZombieTypes
 {
   ZTYPE_NORMAL = 0,
              
   ZTYPE_COUNT
 };
*/

$ZTYPE_NORMAL = 0;

datablock SpaceZombieDatablock(SpaceZombieBase)
{
   animationName = "spacemanZombieCurl";
   
   stateAnim_Rest  = "spacemanZombieCurl";
   stateAnim_Chase = "spacemanZombieTwig";
   
   //imageMap = "pickup_data_blueImageMap"; 
   size = "24.000 24.000";
   MinScaleMult = 0.667; //sacales between this and 1
   
   updateTime = 5.000;  //seconds.  this is how often a zombie picks a new position
   //if the aombie is awake, it will ping a lot faster.
   
   zombieType = 0;  
   
   maxHealth            = "0.25"; //for some reaosn point def having a hard time with em.
   
   deathEffect_Default      = "BloodSplat";
   deathEffectScale_Default = 1;
   deathSound_Default       = "snd_squash_zom";
      
   deathEffect_Energy       = "SmallBurn";
   deathEffectScale_Energy  = 1;
   deathSound_Energy        = "snd_squash_zom";
     
   impactDeath_Speed        = 400;  //impact speed causing maxhealth in damage. 
   impactDeath_Sound        = "snd_squash_zom";  
   
   wanderRange              = 2000;
   wanderSpeed              = 50;
   
   chaseSpeed               = 225;
      
   //called only when chase mode set, then the animation takes over. 
   chaseEffect              = "zombie_bodyImpulse"; 
   chaseEffectScale         = "0.333";
   chaseEffectSound         = "snd_zombie_wakeup";
   
   shieldDamage             = 10;
   
   zombieBlends0            = "1 1 1 1";
   zombieBlends1            = "0.6 0.6 0.6 1";
   zombieBlends2            = "1 0.8 0.8 1";
   zombieBlends3            = "1 0.8 1 1";
   zombieBlends4            = "1 1 0.8 1"; 
};


