///////////////////////////////////////////////////////////////////
// FRIENDLY STAT LOOKUP
///////////////////////////////////////////////////////////////////

function GetFriendlyStat(%tag, %colon, %researchCategory)
{
   %lookupString = "FriendlyStat_Lookup".lookupTag[%researchCategory, %tag]; //get spicific to catagory
   if (%lookupString $= "")
      %lookupString = "FriendlyStat_Lookup".lookupTag[%tag]; //or get generic
      
   if (%lookupString !$= "")
      if (%colon == true)
         return %lookupString @ ":";
      else
         return %lookupString; 
   else
   {  
      echo("YOU DON'T HAVE A FRIENDLY TAG FOR" SPC %tag);
      return %tag;
   }
}

new ScriptGroup (FriendlyStat_Lookup)
{   
   lookupTag["maxCrewSize"] = "Crew Capacity";
   lookupTag["maxRange"] = "Max Range";
   lookupTag["damageStrength"] = "Damage Strength";
   lookupTag["reloadMS"] = "Reload Speed";
   lookupTag["powerConsumption"] = "Power Consumption";
   lookupTag["componentMass"] = "Component Mass";
   lookupTag["burstSize"] = "Burst Size";
   lookupTag["clusterSpread"] = "Cluster Spread";
   lookupTag["baseDamage"] = "Base Damage";
   lookupTag["beamLength"] = "Beam Length";
   lookupTag["beamLife"] = "Beam Life";
   lookupTag["beamRegen"] = "Beam Regen";
   lookupTag["chargeTime"] = "Charge Time";
   lookupTag["maxSpeed"] = "Max Speed";
   lookupTag["turnSpeed"] = "Turn Speed";
   lookupTag["constantThrustForce"] = "Thruster Force";
   lookupTag["missileLifetimeMS"] = "Missile Life";
   lookupTag["maxHealth"] = "Max Health";
   lookupTag["subProjectileCount"] = "Sub Projectiles";
   lookupTag["wispLifetime"] = "Combustion Time";
   lookupTag["wispDestructionRadius"] = "Combustion Range";
   lookupTag["wispDestructionPower"] = "Combustion Strength";
   lookupTag["wispCount"] = "Combustion Count";
   lookupTag["detectionRadius"] = "Detection Radius";
   lookupTag["explosiveRadius"] = "Explosive Radius";
   lookupTag["movementSpeed"] = "Movement Speed";
   lookupTag["cloakDisruptionTime"] = "Cloak Disruption Time";
   lookupTag["cloakDamageBoost"] = "Cloaked Damage Boost";   
   lookupTag["alarmTime"] = "Alarm Time";
   lookupTag["explodeTime"] = "Explosion Time";
   lookupTag["mineDelpoyTime"] = "Deployment Time";
   lookupTag["minePingTime"] = "Ping Time";
   lookupTag["droneConstructTime"] = "Construction Time";
   lookupTag["dronesMax"] = "Drone Count";
   lookupTag["droneLaunchTime"] = "Drone Deploy Time";
   lookupTag["droneDamageBoost"] = "Drone Damage Boost";   
   lookupTag["aggroLevel"] = "Seek Level";
   lookupTag["attackRunTime"] = "Attack Run Time";
   lookupTag["shieldMaxStrength"] = "Shield Strength";
   lookupTag["shieldRegenSpeed"] = "Shield Regen Speed";
   lookupTag["shieldCreateStrength"] = "Initial Shield Strength";
   lookupTag["shieldCreateTime"] = "Shield Recharge Time";
   lookupTag["shieldDamageMult"] = "Damage Multiplier";
   lookupTag["cloakEngineSpeedDecrease"] = "Engine Speed Penalty";
   lookupTag["cloakTurnRateDecrease"] = "Turn Rate Penalty";
   lookupTag["cloakThrustDecrease"] = "Thruster Penalty";
   lookupTag["maxReactorOutput"] = "Reactor Output";
   lookupTag["capacitorCapacity"] = "Capacitor Capacity";
   lookupTag["engineThrustForce"] = "Thrust Force";
   lookupTag["engineTurnSpeed"] = "Turn Speed";
   lookupTag["engineMaxSpeed"] = "Max Speed";
   lookupTag["rotationSpeed"] = "Rotation Speed";
   lookupTag["baseArmorDamageMult"] = "Armor Damage Multiplier";
   lookupTag["maxComponentHealth"] = "Health";
   lookupTag["hullCargoSpace"] = "Cargo Space";
   lookupTag["hullBaseDamageMult"] = "Hull Damage Multiplier";
   lookupTag["boosterPower"] = "Booster Overdrive";
   lookupTag["seekingSpeed"] = "Seeking Speed";
   lookupTag["combatStrength"] = "Crew Combat Strength";
   lookupTag["hacking"] = "Data Theft Skill";   
   lookupTag["recruitingChance"] = "Crew Recruiting Chance";
   lookupTag["repairRate"] = "Hull Repair Rate";
   lookupTag["shuttleArmor"] = "Shuttle Armor";
   lookupTag["seekingSpeed"] = "Seeking Speed";
   
   //special tags for odd balls
   lookupTag["CrewResearch", "maxRange"] = "Max Shuttle Speed";
   lookupTag["CrewResearch", "maxSpeed"] = "Max Shuttle Range";
   lookupTag["CrewResearch", "reloadMS"] = "Shuttle Reload Speed";
   
   lookupTag["CloakingResearch", "shieldMaxStrength"] = "Cloak Strength";
   lookupTag["CloakingResearch", "shieldRegenSpeed"] = "Cloak Regen Speed";
   lookupTag["CloakingResearch", "shieldCreateStrength"] = "Initial Cloak Strength";
   lookupTag["CloakingResearch", "shieldCreateTime"] = "Cloak Recharge Time";
   
   lookupTag["SubSystemResearch", "beamLength"] = "Subsystem Beam Length";
   lookupTag["SubSystemResearch", "baseDamage"] = "Point Defense Damage";
};

