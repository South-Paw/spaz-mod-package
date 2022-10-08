

function StarArtClass::OnAdd(%this)
{
   %this.AddStarArtToDatabase();
   %this.SetupWeightedLists();
}

function StarArtClass::SetupWeightedLists(%this)
{
   %this.star = createEfficientWeightedList(%this.star); 
   %this.secondaryStar = createEfficientWeightedList(%this.secondaryStar); 
   
   %this.distantLayerImage = createEfficientWeightedList(%this.distantLayerImage);
    
   %this.weatherEffect = createEfficientWeightedList(%this.weatherEffect); 
}


function StarArtClass::AddStarArtToDatabase(%this)
{
   if ( $StarArtDatabase $= "" )
      $StarArtDatabase = new ScriptGroup() {};
      
   %starType = %this.starType;
   if ( %starType $= "" )
      return;
        
   if ($StarArtDatabase[%starType] $= "" )
      $StarArtDatabase[%starType] = new SimSet() {};
      
   %starArtObjectHolder = new ScriptObject()
   {
      starArtObject = %this;
   };
   
   $StarArtDatabase.add(%starArtObjectHolder);
   $StarArtDatabase[%starType].add(%starArtObjectHolder);      
}

function GetStarArtTypeSet(%starType)
{
   return $StarArtDatabase[%starType];   
}

function GetRandomStarArtByType(%starType)
{
   %typeSet = GetStarArtTypeSet(%starType);
   %randomSelection = %typeSet.getObject(getRandom(0, %typeSet.getCount() - 1));
   %starArt = %randomSelection.starArtObject;
     
   return %starArt;   
}


//Stars need to define:
new ScriptObject(StarArtBase) 
{
   class = "StarArtClass";

   starOverride = "";  //this star will be selected no matter what
   starExcludes = ""; //this star will never be selected.   
   
   starBlend = "1 1 1 1"; 
   childStarBlends[0] = "";  //can have as many as we want.
   
   colorIndex = 0;  
   brightnessAddative = 0;
      
   //The Background (will be colored)
   rawBackgroundImage = "background_redImageMap";
   
   distantLayerImage = "cloud_flakesImageMap 10 cloud_heavyCloudsImageMap 10 cloud_dustImageMap 10 cloud_darkCloudsImageMap 10 cloud_mistImageMap 10 cloud_funnelsImageMap 10 cloud_junkImageMap 10";  //Weighted list of possible clouds
   distantLayerBlend = "1 1 1 0.7";
   
   weatherEffect = "cloudBurst_01";  //Weighted list of possible effects.
      
   planet = "";      //Only one of these to match the context image.
   LevelFeatureExcludes = "";  //these are planets we cannot pick
   FeatureOrbitalExcludes = ""; //moons and such. 
   NearObjectExcludes = "";  //debris on the near layer
   CloudObjectExcludes = "";
   
   starType = "";  //need a star type to have it added to the automatic selection database.
   
   forcedSong = "";
};

//Planet_Red_01
//Planet_Orange_01
//Planet_Yellow_01
//Planet_Green_01
//Planet_Blue_01
//Planet_Purple_01

$Planets_Red = "Planet_red_01 Planet_Small_Red";
$Planets_Orange = "Planet_Orange_01 Planet_Small_Orange";
$Planets_Yellow = "Planet_yellow_01 Planet_Small_Yellow";
$Planets_Green = "Planet_Green_01 Planet_Small_Green";
$Planets_Blue = "Planet_blue_01 Planet_Small_Blue";
$Planets_Purple = "Planet_Purple_01 Planet_Small_Purple";

$Planets_All = $Planets_Red SPC $Planets_Orange SPC $Planets_Yellow SPC $Planets_Green SPC $Planets_Blue SPC $Planets_Purple;

////////////////////////////////////////////////
// Red Stars ///////////////////////////////////
////////////////////////////////////////////////
//Used for the best mining ops.

new ScriptObject(RedStar_0 : StarArtBase) 
{          
   rawBackgroundImage = "background_redImageMap";
 
   distantLayerBlend = "0.35 0.1 0 1";
   
   moonBlend = "0.7 0.4 0.2 1";
   starBlend = "1 0.4 0.2 1";
   colorIndex = 0;
   brightnessAddative = -0.1;
   
   //can and should add many of these.
   childStarBlends[0] = "0.9 0.3 0.3 1";   //red
   childStarBlends[1] = "0.9 0.6 0.4 1";  //orange
   childStarBlends[2] = "0.7 0.6 0.3 1";  //yellow
   childStarBlends[3] = "0.8 0.5 0.8 1";    //purple

   weatherEffect = cloudBurst_01;
            
   starType = "Red";
};


new ScriptObject(RedStar_1 : RedStar_0) 
{       
   brightnessAddative = 0;   
   rawBackgroundImage = "background_red_2ImageMap"; 
};

new ScriptObject(RedStar_2 : RedStar_1) 
{        
   rawBackgroundImage = "background_red_3ImageMap"; 
};


////////////////////////////////////////////////
// Orange Stars ////////////////////////////////
////////////////////////////////////////////////
//Used for the depleted/struggling mining ops.
new ScriptObject(OrangeStar_0 : StarArtBase) 
{          
   rawBackgroundImage = "background_orangeImageMap";
   
   distantLayerBlend = "1 0.6 0.7 1";
   
   moonBlend = "0.8 0.5 0.3 1";
   starBlend = "0.9 0.6 0.4 1";
   colorIndex = 1;
   brightnessAddative = -0.1;
   
   //can and should add many of these.
   childStarBlends[0] = "0.9 0.3 0.3 1";   //red
   childStarBlends[1] = "0.9 0.6 0.4 1";   //orange
   childStarBlends[2] = "0.7 0.6 0.3 1";   //yellow

   weatherEffect = lightning_01;
      
   starType = "Orange";
};

////////////////////////////////////////////////
// Yellow Stars ////////////////////////////////
////////////////////////////////////////////////
//Used for struggling colonies

new ScriptObject(YellowStar_0 : StarArtBase) 
{        
   rawBackgroundImage = "background_yellowImageMap";
    
   distantLayerBlend = "0.8 0.7 0.3 1";
   
   moonBlend = "0.7 0.5 0.2 1";
   starBlend = "0.7 0.6 0.3 1";
   colorIndex = 2;
   
   //can and should add many of these.
   childStarBlends[0] = "0.9 0.3 0.3 1";   //red
   childStarBlends[1] = "0.9 0.6 0.4 1";   //orange
   childStarBlends[2] = "0.7 0.6 0.3 1";   //yellow
   childStarBlends[3] = "0.5 0.8 0.5 1";  //green
   
   weatherEffect = cloudBurst_01;
      
   starType = "Yellow";
};


new ScriptObject(YellowStar_1 : YellowStar_0) 
{     
   brightnessAddative = -0.1;  
   rawBackgroundImage = "background_yellow_2ImageMap";
   distantLayerBlend = "0.8 0.7 0.2 1";
};

new ScriptObject(YellowStar_2 : YellowStar_1) 
{     
   rawBackgroundImage = "background_yellow_3ImageMap";
};

////////////////////////////////////////////////
// Green Stars ////////////////////////////////
////////////////////////////////////////////////
//Used for Eden colonies
new ScriptObject(GreenStar_0 : StarArtBase) 
{      
   rawBackgroundImage = "background_greenImageMap";
   
   distantLayerBlend = "0.4 0.6 0.2 1";
   moonBlend = "0.4 0.5 0.1 1";
   starBlend = "0.4 0.7 0.2 1";
   
   colorIndex = 3;
   brightnessAddative = -0.1;
   
  //can and should add many of these.   
   childStarBlends[0] = "0.7 0.6 0.3 1";   //yellow
   childStarBlends[1] = "0.5 0.8 0.5 1";  //green
   childStarBlends[2] = "0.45 0.45 1 1";  //blue
   
   weatherEffect = lightning_01;
      
   starType = "Green";
};


new ScriptObject(GreenStar_1 : GreenStar_0) 
{       
   rawBackgroundImage = "background_green_2ImageMap";
   
   distantLayerBlend = "0.3 0.6 0.3 1";
   moonBlend = "0.2 0.5 0.2 1";
   starBlend = "0.3 0.7 0.3 1";
   
   brightnessAddative = -0.15;
};

new ScriptObject(GreenStar_2 : GreenStar_1) 
{       
   rawBackgroundImage = "background_green_3ImageMap";
};

////////////////////////////////////////////////
// Blue Stars ////////////////////////////////
////////////////////////////////////////////////
//Used for Science Stars

new ScriptObject(BlueStar_0 : StarArtBase) 
{       
   rawBackgroundImage = "background_blueImageMap";
  
   distantLayerBlend = "0.75 0.75 1 1";
   
   moonBlend = "0.55 0.55 0.9 1";
   starBlend = "0.45 0.45 1 1";
   colorIndex = 4;
   
   //can and should add many of these.   
   childStarBlends[0] = "0.8 0.5 0.8 1";  //purple
   childStarBlends[1] = "0.5 0.8 0.5 1";  //green
   childStarBlends[2] = "0.45 0.45 1 1";  //blue
   
   weatherEffect = auroraBurst_01;
      
   starType = "Blue";
};


new ScriptObject(BlueStar_1 : BlueStar_0) 
{            
   rawBackgroundImage = "background_blue_2ImageMap";
   
   distantLayerBlend = "0.3 0.5 1 1";
};

new ScriptObject(BlueStar_2 : BlueStar_0) 
{            
   rawBackgroundImage = "background_blue_3ImageMap";
   
   distantLayerBlend = "0.3 0.5 1 1";
   
   brightnessAddative = -0.1;
   
   weatherEffect = cloudBurst_01;
};

new ScriptObject(BlueStar_3 : BlueStar_0) 
{            
   rawBackgroundImage = "background_blue_4ImageMap";
};


////////////////////////////////////////////////
// Purple Stars ////////////////////////////////
////////////////////////////////////////////////
//Used for top secret stuff

new ScriptObject(PurpleStar_0 : StarArtBase) 
{         
   rawBackgroundImage = "background_purpleImageMap";
  
   distantLayerBlend = "0.6 0.2 0.6 1";
   moonBlend = "0.5 0.2 0.5 1";
   starBlend = "0.7 0.4 0.9 1";
   
   colorIndex = 5;
   
   //can and should add many of these.   
   childStarBlends[0] = "0.8 0.5 0.8 1";  //purple
   childStarBlends[1] = "0.5 0.8 0.5 1";  //green
   childStarBlends[2] = "0.45 0.45 1 1";  //blue
   
   weatherEffect = cloudBurst_01;
      
   starType = "Purple";
};


new ScriptObject(PurpleStar_1 : PurpleStar_0) 
{     
   brightnessAddative = -0.1;
        
   rawBackgroundImage = "background_purple_2ImageMap";
   
   //distantLayerBlend = "1 0.2 1 1";
   //moonBlend = "0.7 0.5 0.9 1";
};

new ScriptObject(PurpleStar_2 : PurpleStar_1) 
{          
   rawBackgroundImage = "background_purple_3ImageMap";
};

///////////////////////////////////////////////
// Special Stars //////////////////////////////
///////////////////////////////////////////////

new ScriptObject(EarthStar : YellowStar_1) 
{  
   //brightnessAddative = 0.2;   
   
   starOverride = "TheSun"; 
   starType = "Earth_Special";
};


new ScriptObject(ProximaStar : BlueStar_0) 
{    
   starOverride = "TheProximaDyson"; 
   starType = "Proxima_Special";
};

new ScriptObject(WOLF359Star : RedStar_0) 
{    
   starOverride = "WOLF359_StarArt"; 
   starType = "WOLF359_Special";
};


new ScriptObject(SIRIUSStar : PurpleStar_1) 
{    
   starOverride = "SIRIUS_StarArt"; 
   starType = "SIRIUS_Special";
};

new ScriptObject(LUYTENStar : GreenStar_1) 
{    
   starOverride = "LUYTEN_StarArt"; 
   starType = "LUYTEN_Special";
};





new ScriptObject(BlackHoleStar : PurpleStar_0) 
{    
   starOverride = "Blackhole_01"; 
   starType = "BlackHole_Special";
};


new ScriptObject(FinalZombieStar : StarArtBase) 
{  
   rawBackgroundImage = "background_finalImageMap";
  
   distantLayerBlend = "0.3 0.2 0.3 1";
   distantLayerImage = "cloud_heavyCloudsImageMap 10";
   
   moonBlend = "0.3 0.2 0.3 1";
   starBlend = "0.8 0.5 1 1";
   colorIndex = 5;
   
   //can and should add many of these.   
   childStarBlends[0] = "0.8 0.5 0.8 1";  //purple
   childStarBlends[1] = "0.5 0.8 0.5 1";  //green
   childStarBlends[2] = "0.45 0.45 1 1";  //blue
   
   weatherEffect = cloudBurst_01;
   
   starOverride = "FinalStar"; 
   starType = "Zombie_Special";
};




