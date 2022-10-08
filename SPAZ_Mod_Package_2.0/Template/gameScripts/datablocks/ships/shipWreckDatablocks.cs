
//Works like a super hull breach

$ShipWreckSet = new SimSet() {};
function ShipWreckComponent::OnAdd(%this)
{
   %name = %this.getName();
   if ( %name $= "ShipWreckBase" || %name $= "ShipWreck_MetalBase" || %name $= "ShipWreck_MetalBase_Cleanup")
      return;
       
   $ShipWreckSet.add(%this);
}


new ScriptGroup(ShipWreckBase : BreachBase)
{
   class = "ShipWreckComponent"; //superclass = HullBreachComponent  
   
   //Never make health more than 20.  You need to put health on individual wrecks
   maxHealth = 0;  //low health is ok, since non ship damage is multiplied by 0.05 so everyhting isnt obliterated
    
   wreckDamping = 0.3;
   wreckImpulseForce = "30 50";  //getrandomfrompair   
   wreckMinAngularVelocity = 2; //so there is at least some motion
   wreckMaxAngularVelocity = 45;
   wreckAngularVelocityMult = 1.2;  //reverse, smaller pieces shuld have neg mult and be less.
   wreckAngularVelocityOverride = "";  //this is to set a precise angular velocity for spinning undercarriage etc.
};

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// common wreck types
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

$AllCullSet = new SimSet() {};
$HugeCullSet = new SimSet() { maxCount = 7; }; $AllCullSet.add($HugeCullSet);
$RegularCullSet = new SimSet() { maxCount = 4; }; $AllCullSet.add($RegularCullSet);


new ScriptGroup(ShipWreck_MetalBase : ShipWreckBase)
{   
   adoptStarColor = true;   
   
   wreckImpulseForce = "35 50";  //getrandomfrompair   
   wreckAngularVelocityMult = 0.8;
   wreckMaxAngularVelocity = 10;
   
   initialState = "Breach";  //Need to use breech for inheritance to work
   
   //Firey
   breachStates["Breach", "nextStateWL"]       = "Cooling";  
   breachStates["Breach", "nextStateTime"]     = "10000 15000";   
      
   //Cooling
   breachStates["Cooling", "nextStateWL"]   = "Cold";  
   breachStates["Cooling", "nextStateTime"] = "5000 10000";  
   
   //Cold
   breachStates["Cold", "nextStateWL"]   = "Dead";
   breachStates["Cold", "nextStateTime"] = "10000 15000";  //needs enough time to fuly fade embers
         
};

//Dead will add to cull set, cull state is called by the addToCullSetID when it is time to go.
new ScriptGroup(ShipWreck_MetalBase_Cull_Regular : ShipWreck_MetalBase)
{
   maxHealth = 10;  //a big-ish explosion will pop the wreckage
   
   breachStates["Cull", "breachEffects", 0]  = "hullCleanupPuff 0 0 0 0 0.7 0 0";
   breachStates["Cull", "nextStateWL"]   = "Delete";
   breachStates["Cull", "nextStateTime"] = "1 2";
   
   breachStates["Cull", "breachDebris", 0]   = "DC_HullBreach_Small 1 35";
   breachStates["Cull", "breachDebris", 1]   = "DC_Combat_Small_Heavy 1 30";
   breachStates["Cull", "breachDebris", 2]   = "DC_Combat_Small_Light 1 25";
   
   breachStates["Delete", "shouldDeleteSelf"] = true;   //save mem  
   breachStates["Dead", "addToCullSetID"] = $RegularCullSet;        
};

new ScriptGroup(ShipWreck_MetalBase_Cull_Huge : ShipWreck_MetalBase_Cull_Regular)
{
   breachStates["Cull", "breachEffects", 0]  = "hullCleanupPuff 0 0 0 0 1.2 0 0";
   breachStates["Dead", "addToCullSetID"] = $HugeCullSet;         
};



//bypasses culling and just deletes on the state change. 
new ScriptGroup(ShipWreck_MetalBase_Cleanup : ShipWreck_MetalBase)
{   
   breachStates["Dead", "addToCullSetID"] = ""; //do not add to cull set.  
   
   maxHealth = 10;  //a big-ish explosion will pop the wreckage
   
   breachStates["Dead", "breachEffects", 0]  = "hullCleanupPuff 0 0 0 0 0.7 0 0";
   breachStates["Dead", "nextStateWL"]   = "Delete";
   breachStates["Dead", "nextStateTime"] = "1 2";
   
   breachStates["Dead", "breachDebris", 0]   = "DC_HullBreach_Small 1 35";
   breachStates["Dead", "breachDebris", 1]   = "DC_Combat_Small_Heavy 1 30";
   breachStates["Dead", "breachDebris", 2]   = "DC_Combat_Small_Light 1 25";
   
   breachStates["Delete", "shouldDeleteSelf"] = true;   //save mem       
};

new ScriptGroup(ShipWreck_EmbersBase : BreachEmberDefault)
{    
   size = "16 16";   

   breachStateFilter = "Breach Cold Dead";    
  
   breachStates["Cold", "isIntense"]       = true;
   breachStates["Cold", "breachBlend"]     = "1 1 1 0";

   breachStates["Dead", "shouldDeleteSelf"] = true;   //save mem        
};  
   
new ScriptGroup(ShipWreck_ElecBase : BreachElectricsDefault)
{    
   size = "16 16"; 
   
   breachStateFilter = "Breach";    
   
   //Since breach filter is on, this will not get called.
   //breachStates["Dead", "shouldDeleteSelf"] = true;    //save mem
};  

//ZOMBIE WRECK

new ScriptGroup(ShipWreck_ZombieBase : ShipWreckBase)
{   
   adoptStarColor = true;   
   
   wreckImpulseForce = "35 50";  //getrandomfrompair   
   wreckAngularVelocityMult = 0.8;
   wreckMaxAngularVelocity = 10;
   
   initialState = "Breach";  //Need to use breech for inheritance to work
   
   //Firey
   breachStates["Breach", "nextStateWL"]       = "Cooling";  
   breachStates["Breach", "nextStateTime"]     = "10000 15000";   
      
   //Cooling
   breachStates["Cooling", "nextStateWL"]   = "Cold";  
   breachStates["Cooling", "nextStateTime"] = "5000 10000";  
   
   //Cold
   breachStates["Cold", "nextStateWL"]   = "Dead";
   breachStates["Cold", "nextStateTime"] = "10000 15000";  //needs enough time to fuly fade embers
  
};






























