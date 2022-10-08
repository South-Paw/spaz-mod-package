 
   
   
   
datablock WispDatablock(WispBase) 
{
   //Image
   wispImageMap               = "reactor_wisp_02ImageMap";   
   wispInitialSize            = "128 128";
   wispFinalSize              = "128 128";
   
   wispInitialColor           = "1 0.5 0.5 1";
   wispFinalColor             = "1 0.5 0.5 1";     
   wispIsIntense              = true;
   wispBaseImpulseForce       = "60 90";
   wispDamping                = 0.10;
      
   //Lifetime stuff
   wispEffect                 = "WispHole";   
   wispEffectBaseScale        = 1; //may be modified by linger effects
   wispLifetime               = "3000 4200"; //random pair    
   wispMaxSpinRate            = 1000;  
   
   //lifetime blending (for corrosive effects mostly)
   wispEffectInitialBlend     = "";  //this is per puff, not over the lifetime of the effect. 
   wispEffectFinalBlend       = "";  //requires initial blend defined.
   
   //Linger blossoms. 
   lingerBlossomRate              = 0; //If 0, linger is inactive.
   lingerEffectLifetimeScaleMult  = "0.2 1";  //This multiplies effect count at mSqrt(lifetimeProgress)
   blossomData["Linger", "DamageType"]   = "Explosive";
   blossomData["Linger", "Speed"]        = 512;  
   blossomData["Linger", "ImageMaps"]    = "effect_basicShockwaveImageMap"; //will get a random one. (may be good for toxic clouds)
   blossomData["Linger", "InitialBlend"] = "1 1 1 1";
   blossomData["Linger", "FinalBlend"]   = "1 1 1 0";
   blossomData["Linger", "MaxDamage"]    = 100;
   blossomData["Linger", "DamageRadius"] = 300; //note, if lingering, we mult these numbers by the current lifetime progress. so they start at 0
   
   //Explosion stuff
   wispExplosionSound         = "snd_reactorImplosion";      //This is for a structural explosion, reactor will have its own sound. 
   wispExplosionDatablock     = "ReactorExplosion";   
   wispExplosionDamageTime    = "1500";  //when implosion becomes explosion
   wispExplosionScale         = "0.66";
   
   //Blossom stuff (This is the final explosion)
   blossomData["Final", "DamageType"]   = "Explosive";
   blossomData["Final", "Speed"]        = 1024;  //speeds below 512 are not recommended.
   blossomData["Final", "ImageMaps"]    = "effect_basicShockwaveImageMap"; //will get a random one. (may be good for toxic clouds)
   blossomData["Final", "InitialBlend"] = "1 1 0.3 1";
   blossomData["Final", "FinalBlend"]   = "1 1 0.3 0";
   blossomData["Final", "MaxDamage"]    = 100;
   blossomData["Final", "DamageRadius"] = 600;   
      
};

//YELLOW
datablock WispDatablock(ExplosiveWisp : WispBase) 
{
   wispImageMap               = "reactor_wispImageMap";   
   wispEffect                 = "fireWisp";    
   
   wispInitialColor           = "1 0.7 0.3 1";
   wispFinalColor             = "1 0.7 0.3 1";
   wispInitialSize            = "64 64";
   wispFinalSize              = "92 92"; 
   
   wispExplosionDamageTime    = "0";
   wispEffectBaseScale = 1.2;
   wispExplosionSound         = "snd_mediumExplosion"; 
   wispExplosionDatablock     = "SmallExplosion";
   wispExplosionScale         = "2";   
   
   blossomData["Final", "MaxDamage"]    = 105;
   blossomData["Final", "DamageRadius"] = 600;   
};


//BLUE
datablock WispDatablock(IonWisp : WispBase) 
{
   wispEffectBaseScale = 0.3;
   
   wispInitialColor           = "0.3 0.3 1 1";
   wispFinalColor             = "0.3 0.3 1 1";  
   
   blossomData["Final", "DamageType"]   = "Ion";  //disables ships and knocks out shields.    
   blossomData["Final", "InitialBlend"] = "0.3 1 1 1";
   blossomData["Final", "FinalBlend"]   = "0.3 1 1 0";
};


//This should look like a poison cloud more than a wisp.
//This one will use the linger effects

//GREEN
datablock WispDatablock(CorrosiveWisp : WispBase) 
{
   wispEffectBaseScale = 0.3;
   
   wispInitialColor           = "0.3 1 0.3 0";  // make invisible.
   wispFinalColor             = "0.3 1 0.3 0";  
   
   wispEffect                 = "Wisp_ToxicFill";   //color it green for now
   wispEffectBaseScale        = 1.5; //maybe build a radius area effect?
   wispLifetime               = "15000 20000"; //random pair    
   
   wispEffectInitialBlend     = "0.6 1 0.6 1";  //this is per puff, not over the lifetime of the effect. 
   wispEffectFinalBlend       = "1 0.7 0.5 0";  //we assume we are blending emitter 0. we could blend all emitters if that is better. 

   lingerBlossomRate              = 0.4;  //will add up to 50% more time to help stagger things.
   lingerEffectLifetimeScaleMult  = "0.1 30";  //This multiplies effect count at mSqrt(lifetimeProgress)
   blossomData["Linger", "DamageType"]   = "Corrosive";
   blossomData["Linger", "Speed"]        = 512;  
   blossomData["Linger", "ImageMaps"]    = "effect_zombiePingImageMap"; //will get a random one. (may be good for toxic clouds)
   blossomData["Linger", "InitialBlend"] = "0.2 1 0.2 0"; //making it insivible, let the area effects do the work.
   blossomData["Linger", "FinalBlend"]   = "0.5 0.5 0 0";
   blossomData["Linger", "MaxDamage"]    = 50;
   blossomData["Linger", "DamageRadius"] = 500; //note, if lingering, we mult these numbers by the current lifetime progress. so they start at 0  
   
   //fades to nothing.   
   wispExplosionDatablock     = ""; //dont want an explosion (will also skip final deathblossom) 
};


//RED
datablock WispDatablock(HeatWisp : WispBase) 
{
   wispImageMap               = "reactor_wispImageMap"; 
   wispEffect                 = "Wisp_Resonate";     
   wispEffectBaseScale = 0.35;
   
   wispInitialColor           = "0.5 1 1 1";
   wispFinalColor             = "0.5 1 1 1";
   
   wispInitialSize            = "16 16";
   wispFinalSize              = "16 16";     
   
   wispExplosionDamageTime    = "0";
   wispExplosionDatablock     = "SmallExplosion"; 
   wispExplosionScale         = "1.8";
   wispExplosionSound         = "snd_resonateExplode";        
   
   blossomData["Final", "DamageType"]   = "Heat";  //heat
   blossomData["Final", "Speed"]        = 512;  
   blossomData["Final", "ImageMaps"]    = "effect_puffImageMap"; //will get a random one. (may be good for toxic clouds)
   blossomData["Final", "InitialBlend"] = "1 0.5 0.2 1";
   blossomData["Final", "FinalBlend"]   = "1 0.5 0.2 0";
   blossomData["Final", "MaxDamage"]    = 60;
   blossomData["Final", "DamageRadius"] = 600;   
};




