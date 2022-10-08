//Ship Design Datablocks.  
//Some day these will be created with an interface, for now we will just cheat them. 
//we will need to verify that ship designs are valid when they spawn, and assert if they are not. 


function ShipDesignDatablock::AddHullDesign(%this)
{
   if ( %this.getName() $= "" || %this.getName() $= "DefaultShip" || %this.getName() $= "DefaultZombieShip")
      return;
      
   if ( !%this.includeInSSTDatabase )
      return;
      
   if ( !isObject(%this.parentDesign) ) //I am a parent so create the deisng set.
   {
      %this.designSet = new SimSet() {};
      %this.designSet.add(%this); //add self, or sub design for later random selection
   }
   else
   {
      %this.parentDesign.designSet.add(%this);
      return;
   }
   
   AddHullDesign(%this);  
}

function ShipDesignDatablock::RemoveHullDesign(%this)
{
   if ( isObject(%this.designSet) )
      %this.designSet.delete();   
}

//Used by SST
function ShipDesignDatablock::PickSubHullDesign(%this)
{
   %designSet = %this.designSet;
   %design = %designSet.getObject(getRandom(0, %designSet.getCount() - 1));
   return %design;
}


datablock ShipDesignDatablock(DefaultShip)
{      
   
   friendlyName = "Civilian Loadout"; //will need hookup to custom designs
   isCustomDesign        = false;
   
   shipArmor_Front       = "";   
   shipArmor_Starboard   = "";
   shipArmor_Aft         = "";
   shipArmor_Port        = "";

   includeInSSTDatabase  = true;
   
   parentDesign = 0; //Only sub designs need this. 
   
   designDescriptionBits = $SST_DESIGN_CIV;
   deviceDescriptionBits = $SST_DEVICE_GENERIC;
};

datablock ShipDesignDatablock(DefaultZombieShip : DefaultShip)
{
   isCustomDesign        = false;
   designDescriptionBits = $SST_DESIGN_BASIC;
};


function ShipDesignDatablock::GetFriendlyName(%this, %shipID)
{
   %currentName = %this.friendlyName;
   %hull = %this.shipHull;
    
   %realName = %hull.GetFriendlyName();
   //Now need to prefix with size.
   
   if ( %hull.isTurretHull )
      return %realName;
  
   %designDesc = %this.designDescriptionBits;
   
   if ( %shipID !$= "" && %shipID.getFaction() $= "Zombie")
      return "Zombie" SPC %realName;  
   
   if ( %hull.hullType == $HULLTYPE_MOTHERSHIP )
      return "Prototype" SPC %realName;  
   
   if ( %designDesc & $SST_DESIGN_CIV )
      return "Surplus" SPC %realName;
   
   if ( %designDesc & $SST_DESIGN_BASIC )
      return %realName;  //NO PREFIX
      
   if ( %designDesc & $SST_DESIGN_IMPROVED )
      return "Improved" SPC %realName;
      
   if ( %designDesc & $SST_DESIGN_ADVANCED )
      return "Advanced" SPC %realName;
   
   return %realName; 
}

 






























