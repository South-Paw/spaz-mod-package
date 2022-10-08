datablock t2dSceneObjectDatablock(SpacemanBase) 
{  
   frame = "0";
   canSaveDynamicFields = "1";
   
   aliveTime      = "5000";
   removeBodyTime = "5000";  //this is triggered once the guy dies, if no body, there will be no removal needed. 
   
   deathEffect_Default  = "BloodSplat";
   deathSound_Default   = "snd_squash";
   
   deathEffect_Energy   = "SmallBurn";
   deathSound_Energy    = "snd_squash";
   
   spaceScream = "snd_space_scream";
   
   handWeapon           = "None";
   maxHealth            = "0.25";
   myMass               = "0.100";  //100kg
   
   killImpactSpeed      = "150"; 
   
   canSuffocate = false;
};

datablock t2dSceneObjectDatablock(SpacemanBlue_NoSuit_01 : SpacemanBase) 
{
   animationName = "spaceman_blueAnimation";
   size = "24.000 24.000";
   CollisionPolyList = "-0.226 0.241 -0.393 -0.594 0.295 -0.192 0.560 0.300 0.432 0.727 0.020 0.825";
   LinkPoints = "0.221 0.039 0.000 0.805"; 
   canSuffocate = true;
};

datablock t2dSceneObjectDatablock(SpacemanBlue_NoSuit_02 : SpacemanBlue_NoSuit_01) 
{
   animationName = "spaceman_blue_02Animation";
};


   
   
   
   
   
   
   