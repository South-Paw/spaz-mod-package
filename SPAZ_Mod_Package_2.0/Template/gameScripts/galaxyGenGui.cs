
////////////////////////////////////////////////////////////////////////////////
// Galaxy Gen Gui
////////////////////////////////////////////////////////////////////////////////

function GalGen_Push()
{
  if ( GalaxyGenGui.isAwake() )
      return;  
   
   Canvas.pushDialog(GalaxyGenGui);    
}

function GalGen_Pop()
{   
   if ( !GalaxyGenGui.isAwake() )
      return;
      
   Canvas.popDialog(GalaxyGenGui);     
}

function GalGen_Toggle(%val)
{
   if (!%val)
      return;
  
   if ( !GalaxyGenGui.isAwake() )
      GalGen_Push();
   else
      GalGen_Pop();     
}


///////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////

$GalGenRadius = 1024;
$InitSpecialAudio = true;
function GalaxyGenGui::Initialize(%this)
{
   if ( %this.isInitialized !$= "" )
      return;
   
   %this.isInitialized = true;
   GalaxyGen_SceneWindow.panSpeedMult = 2;
   
   %container = "GalaxyGen_HelpTextContainer";
   customStatWidget_clear(%container);
   customStatWidget_AddParagraph(%container, "Here you can decide how large you want the galaxy to be.  The larger the galaxy, the less commodities each system will have.  Smaller galaxies have a more condensed experience, but can be more difficult as the level range between any 2 stars is larger.");
   
   //Need to populate star images for the current galaxy. 
   %level=expandFilename("~/data/levels/emptyEncounter.t2d");   
   %doFullScreen = false;   
   GalaxyGen_SceneWindow.loadLevel(%level, %doFullScreen, 500, 10);
   GalaxyGen_SceneWindow_Background.loadLevel(%level, %doFullScreen, 500, 10);
   
   
   %baseViewport = getWords(getRes(), 0, 1); 
   GalaxyGen_SceneWindow.Extent = %baseViewport;
   GalaxyGen_SceneWindow_Background.Extent = %baseViewport;
   GalaxyGen_BlackSpace.Extent = %baseViewport;
 
   GalaxyGen_SceneWindow.setCurrentCameraPosition("0 0", %baseViewport);  
   GalaxyGen_SceneWindow_Background.setCurrentCameraPosition("0 0", %baseViewport);  
   
   GalaxyGen_SceneWindow.AddChildSceneWindow(GalaxyGen_SceneWindow_Background, 0.03, true);
   %galGenSceneGraph = GalaxyGen_SceneWindow_Background.getSceneGraph();
   CreateParallaxScroller("cloud_starsImageMap", $LAYER_PARALLAX_1, "1", "0.6 1 1 0.5", 0.8, 0.8, 0, 0, %galGenSceneGraph, %galGenSceneGraph);
      
   %this.galGenScenegraph = GalaxyGen_SceneWindow.getSceneGraph();
   %this.galGenBGScenegraph = GalaxyGen_SceneWindow_Background.getSceneGraph();
   %this.galGenScenegraph.initScheduler();
   
   GalaxyGen_SceneWindow.SetZoomClamp($RealCenterZoom * 0.33, $RealCenterZoom * 2);
   GalaxyGen_SceneWindow.SetupZooming(%this); 
   
   GalaxyGen_SceneWindow.AddCameraMountObject();  
   
   GalaxyGen_SceneWindow.SetTargetZoomOutLevel($RealCenterZoom * 0.50);
  
   %this.AddGalaxyUnderlay();
   
   %this.InitGalGenValues();
}


function GalaxyGenGui::onWake(%this)
{   
   $SEC1_SkipTutorial = 0;
   GalaxyGen_Sec1Skip_Lockbox.setValue(0);   
   GalaxyGen_RandomTech_CheckBox.setValue(0);   
   
   $MouseWheelActive = true; //RLBRLB if this gives us trouble remove it, not worth the fight
   PauseGame(%this);
   %this.Initialize();  
   playSound_atCenter("snd_windowExpand");    
   GalaxyGen_SceneWindow.SetCameraPosition("0 0");  
   
   %this.GenerateGalaxy();
   
   %this.createGalaxyCore();
   
   %this.SetScenePaused(false);
   GalaxyGen_SceneWindow.SetPanModeActive(true);
   
   colorAllButtonStates("GalaxyGen_GenerateButton", "1 1 0 1");
   colorAllButtonStates("GalaxyGen_AcceptButton", "0 1 0 1");
   
   %difficulty = GetDifficultyLevel();
   GalaxyGen_Difficulty_Slider.setValue(%difficulty); 
   

   GalaxyGen_BH_Density_Slider.setValue($BH_Density_Normal); 
   GalaxyGen_Tech_Density_Slider.setValue($Tech_Density_Normal); 
   SetBH_Density($BH_Density_Normal, true);
   SetTech_Density($Tech_Density_Normal, true);
   PopAllPopups();
     
   if ( !isObject(GalGenMap) )
   {
      new ActionMap(GalGenMap);          
      GalGenMap.bind("keyboard",  "w", "CTRL_MoveForward");   
      GalGenMap.bind("keyboard",  "s", "CTRL_MoveBack");   
      GalGenMap.bind("keyboard",  "d", "CTRL_MoveClockwise");   
      GalGenMap.bind("keyboard",  "a", "CTRL_MoveCClockwise");     
      GalGenMap.bind("keyboard",  "=", "CTRL_ManualZoomIn");    
      GalGenMap.bind("keyboard",  "-", "CTRL_ManualZoomOut");     
   }
   GalGenMap.push(); 
}


function GalaxyGenGui::onSleep(%this)
{
   $MouseWheelActive = false;  //RLBRLB if this gives us trouble remove it, not worth the fight
   PopAllPopups(); //needs to be killed if up 
   
   //setScenePause
   //%this.galGenScenegraph.setScenePause(true);  //USE THIS FOR INGAME STARMAP
   CleanupGalaxyGenImages(); //if not cleaned up will kill frame rate
  
   %this.SetScenePaused(true);
   GalaxyGen_SceneWindow.SetPanModeActive(false);
   
   GalGenMap.pop();
   UnPauseGame(%this); 
}


///////////////////////////////////////////////
// Scene Pausing //////////////////////////////
///////////////////////////////////////////////
//gives back a little fps. 

function GalaxyGenGui::SetScenePaused(%this, %isPause)
{
   %sg1 = %this.galGenScenegraph;
   %sg2 = %this.galGenBGScenegraph;
   
   %sg1.setScenePause(%isPause);
   %sg2.setScenePause(%isPause);      
}


////////////////////////////////////////////
// Galaxy Underlay ////////////////////////
//////////////////////////////////////////

function GalaxyGenGui::AddGalaxyUnderlay(%this)
{
   %size = $GalGenRadius * 3;
   %size = %size SPC %size;   
  
   %underlay = new t2dStaticSprite() 
   {
      scenegraph = %this.galGenScenegraph;  
      imageMap = "starmap_galaxyPropImageMap";
      CollisionActiveSend = "0";
      CollisionActiveReceive = "0";      
      CollisionCallback = "0"; 
      CollisionGroups = $COLLISION_GROUPS_NONE;
      Layer = 4;
      GraphGroup = $COLLISION_ID_NONE;      
      position = "0 0";
      size = %size;
      BlendColor = "1 1 1 0.5";
   };
}

////////////////////////////////////////////
// Galgen Setup Buttons/Sliders////////////
//////////////////////////////////////////

$GalGen_NumStars  = "150 300";
$GalGen_ConstSize = "2 5";  //not used
$GalGen_MinScalingExponent = "0.333";   //not used. //we will make max be 1, since any more than that makes an unusably dense core.


function GalaxyGenGui::InitGalGenValues(%this)
{  
   %percent = 0.5;
   GalaxyGen_NumStars_Slider.setValue(%percent);
   %this.SetNumStars(%percent);
   
     
   %this.DebugMode = false;
   GalaxyGen_DebugMode_Lockbox.setValue(false);   
   
   return;
   
   %percent = 0.5;
   GalaxyGen_ConstellationSize_Slider.setValue(%percent);
   %this.SetConstellationSize(%percent);
   
   %percent = 0.5;
   GalaxyGen_ScalingExponent_Slider.setValue(%percent);
   %this.SetScalingExponent(%percent);
   
   %this.EvenLevelDistribution = false;
   GalaxyGen_EvenLevelDistribution_Lockbox.setValue(false);
   
   %this.MazeMode = false;
   GalaxyGen_MazeMode_Lockbox.setValue(false);      
}



///////////////
//Num Stars ///
///////////////
function GalaxyGenGui::SetNumStars(%this, %percent)
{
   %percent = mClamp(%percent, 0, 1);
   %minStars = getWord($GalGen_NumStars, 0);
   %maxStars = getWord($GalGen_NumStars, 1);
   
   %value = %minStars + ((%maxStars - %minStars) * %percent);
   %value = mRound(%value);
   
   %this.NumStars = %value;
   return %value;
}

function GalaxyGenGui::GetNumStars(%this)
{
   return %this.NumStars;
}


function GalaxyGenGui::onNumStarsChanged(%this)
{
   %percent = GalaxyGen_NumStars_Slider.getValue();
   %numStars = %this.SetNumStars(%percent);
   
   %text = "Total Stars:" SPC %numStars;   
   GalaxyGen_NumStars_Text.setText(%text);   
}


//////////////////////////
// Difficulty ////////////
//////////////////////////

//Mirrored in code (moved to globals)
/*
$Difficulty_Easy   = 0;
$Difficulty_Normal = 1;
$Difficulty_Hard   = 2;
$Difficulty_Expert = 3;
$Difficulty_Insane = 4;
$Difficulty_COUNT  = 5;
*/

$DifficultyText[$Difficulty_Easy]     = "CASUAL";
$DifficultyText[$Difficulty_Normal]   = "NORMAL";
$DifficultyText[$Difficulty_Hard]     = "VETERAN";
$DifficultyText[$Difficulty_Expert]   = "EXPERT";
$DifficultyText[$Difficulty_Insane]   = "INSANE!";

$DifficultyDesc[$Difficulty_Easy]   = "A casual experience.  Beating higher level foes and leveling up will be a breeze.  Select this if you like lots of pretty explosions and a relaxing romp through the stars.\n\nDifficulty Mult: 66%";
$DifficultyDesc[$Difficulty_Normal] = "A well balanced game.  If a challenge seems too hard, remember to level up and come back for revenge.  If you are careful, you'll be fine.  This is the recommended first play through difficulty level.\n\nDifficulty Mult: 80%";
$DifficultyDesc[$Difficulty_Hard]   = "Quite a challenge and potentially a grind if you do not manage your resources well.  Expect fights to be a lot tougher in higher level systems.\n\nDifficulty Mult: 100%";
$DifficultyDesc[$Difficulty_Expert] = "This level is for those who understand all the ins and outs of the game and want a well paced, but difficult challenge.  The AI hits a lot harder than you now, so beware.\n\nDifficulty Mult: 133%";
$DifficultyDesc[$Difficulty_Insane] = "Ok this one is just unfair, and you have a LONG and dangerous game ahead of you.  This level is only for the most masochistic individuals out there.  Do not play this mode...  We beg you.\n\nDifficulty Mult: 200%";

//Mirrored in code.
$DIFF_MULT_DAMAGE = 0;
$DIFF_MULT_REZ    = 1;
$DIFF_MULT_XP     = 2;
$DIFF_MULT_COUNT  = 3;


//Define the multa from script so we can easily tune.
$DIFF_MULT_DATA[$DIFF_MULT_DAMAGE, $Difficulty_Easy]    = 0.667;
$DIFF_MULT_DATA[$DIFF_MULT_DAMAGE, $Difficulty_Normal]  = 0.800;
$DIFF_MULT_DATA[$DIFF_MULT_DAMAGE, $Difficulty_Hard]    = 1.000;
$DIFF_MULT_DATA[$DIFF_MULT_DAMAGE, $Difficulty_Expert]  = 1.333;
$DIFF_MULT_DATA[$DIFF_MULT_DAMAGE, $Difficulty_Insane]  = 2.000;

$DIFF_MULT_DATA[$DIFF_MULT_REZ, $Difficulty_Easy]       = 1.300;
$DIFF_MULT_DATA[$DIFF_MULT_REZ, $Difficulty_Normal]     = 1.150;
$DIFF_MULT_DATA[$DIFF_MULT_REZ, $Difficulty_Hard]       = 1.000;
$DIFF_MULT_DATA[$DIFF_MULT_REZ, $Difficulty_Expert]     = 0.850;
$DIFF_MULT_DATA[$DIFF_MULT_REZ, $Difficulty_Insane]     = 0.700;

$DIFF_MULT_DATA[$DIFF_MULT_XP, $Difficulty_Easy]        = 1.300;
$DIFF_MULT_DATA[$DIFF_MULT_XP, $Difficulty_Normal]      = 1.150;
$DIFF_MULT_DATA[$DIFF_MULT_XP, $Difficulty_Hard]        = 1.000;
$DIFF_MULT_DATA[$DIFF_MULT_XP, $Difficulty_Expert]      = 0.850;
$DIFF_MULT_DATA[$DIFF_MULT_XP, $Difficulty_Insane]      = 0.700;
		
$DifficultyManager = 0;
function CreateDifficultyManager()
{
   if ( isObject($DifficultyManager) )
      return;
      
   %diffMan = new DifficultyManager() {};   
   $DifficultyManager = %diffMan;
   
   for ( %i = 0; %i < $DIFF_MULT_COUNT; %i++ )
   {
      for ( %j = 0; %j < $Difficulty_COUNT; %j++ )
      {
         %value = $DIFF_MULT_DATA[%i,%j];
         %diffMan.SetDifficultyMult(%i,%j,%value); //populate the thing from script.         
      }      
   }   
   SetDifficultyLevel($Difficulty_Normal);
}

function SetDifficultyLevel(%value)
{
   if ( %value $= "" )
      %value = $Difficulty_Hard;
      
   %shortText = $DifficultyText[%value];   
   %text = "Difficulty:   " SPC %shortText;
   GalaxyGen_Difficulty_Text.setText(%text);
   Options_Difficulty_Text.setText(%shortText);
   
   $DifficultyManager.SetDifficultyLevel(%value);
      
   if ( GalaxyGenGui.isAwake() )
      GalaxyGen_Difficulty_Slider.UpdateDescText();   
}

function GetDifficultyLevel()
{
   return $DifficultyManager.GetDifficultyLevel();
}

function GetDifficultyMult(%multType)
{
   return $DifficultyManager.GetDifficultyMult(%multType); 
}

function GetGeneralDifficultyMult()
{
   %baseMult = GetDifficultyMult($DIFF_MULT_DAMAGE);
   return %baseMult;   
}

// GUI INTEGRATION
function GalaxyGenGui::onDifficultyChanged(%this)
{
   %lastValue = GetDifficultyLevel();
   %value = GalaxyGen_Difficulty_Slider.getValue();
   
   if ( %value != %lastValue )
      SetDifficultyLevel(%value);   
}

function GalaxyGen_Difficulty_Slider::OnMouseEnter(%this)
{   
   %this.UpdateDescText();
}

function GalaxyGen_Difficulty_Slider::OnMouseLeave(%this)
{   
   PopSmartPopup();   
}

function GalaxyGen_Difficulty_Slider::UpdateDescText(%this)
{
   PopSmartPopup();   
   %difficulty = GetDifficultyLevel();
   %text = $DifficultyText[%difficulty];
   %description = $DifficultyDesc[%difficulty];
   
   %container = customStatWidget_addScaleContainer("256");
   customStatWidget_AddText(%container, %text, "", "18", "center", "1 1 1 1");
   customStatWidget_AddParagraph(%container, %description, "", "", "", "1 1 0 1");
   
   %warning = "";
   if ( %difficulty == $Difficulty_Insane )
   {
      customStatWidget_addSpace(%container);
      customStatWidget_AddText(%container, "Do not attempt on first play through", "", "", "", "1 0 0 1");   
   }
      
   PushSmartPopup("GuiSmartBitmapPopupProfile", %this, %container, 20, true, "0 1 1 1", "0 0.6 1 1", 3000);    
}

/////////////////////////////
// For the Arenas ///////////
/////////////////////////////
//turn off in options if set
//hook up the difficulty setting the the arena system

function SetArenaDifficultyLevel(%level)
{
   if ( IsArenaDifficultyLevelSet() )
   {
      echo("SetArenaDifficultyLevel Called without a clear");
      ClearArenaDifficultyLevel();
   }
      
   $LastDifficulyLevel = GetDifficultyLevel();
   SetDifficultyLevel(%level);   
}

function ClearArenaDifficultyLevel()
{
   if ( !IsArenaDifficultyLevelSet() )
      return;
      
   SetDifficultyLevel($LastDifficulyLevel);  
   $LastDifficulyLevel = "";
}

function IsArenaDifficultyLevelSet()
{
   return $LastDifficulyLevel !$= "";
}


////////////////////////
//Constellation Size ///
////////////////////////
function GalaxyGenGui::SetConstellationSize(%this, %percent)
{
   %percent = mClamp(%percent, 0, 1);
   %minSize = getWord($GalGen_ConstSize, 0);
   %maxSize = getWord($GalGen_ConstSize, 1);
   
   %value = %minSize + ((%maxSize - %minSize) * %percent);
   %value = mRound(%value);
   
   %this.ConstellationSize = %value;
   return %value;
}

function GalaxyGenGui::GetConstellationSize(%this)
{
   return %this.ConstellationSize;
}


function GalaxyGenGui::onConstellationSizeChanged(%this)
{
   %percent = GalaxyGen_ConstellationSize_Slider.getValue();
   %constSize = %this.SetConstellationSize(%percent);
   
   %text = "Constellation Size:" SPC %constSize; 
   GalaxyGen_ConstellationSize_Text.setText(%text);   
}




////////////////////////
//Scaling Exponent /////
////////////////////////

function GalaxyGenGui::SetScalingExponent(%this, %percent)
{
   %percent = mClamp(%percent, 0, 1);
   %minExp = $GalGen_MinScalingExponent;
   %maxExp = 1.0;   
   
   if ( %percent == 0 )
   {
      %this.ScalingExponent = %minExp;    
      return %minExp;
   }
   
   if ( %percent == 1 )
   {
      %this.ScalingExponent = %maxExp;    
      return %maxExp;      
   }
   
   %value = %minExp + ((%maxExp - %minExp) * %percent);
    
   %this.ScalingExponent = %value;
   return %value;
}

function GalaxyGenGui::GetScalingExponent(%this)
{
   return %this.ScalingExponent;
}


function GalaxyGenGui::onScalingExponentChanged(%this)
{
   %percent = GalaxyGen_ScalingExponent_Slider.getValue();
   %exp = %this.SetScalingExponent(%percent);
   
   %humanTranslation = %this.GetHumanDensityTranslation(%exp);
   
   %text = %humanTranslation;       
   GalaxyGen_ScalingExponent_Text.setText(%text);     
}


function GalaxyGenGui::GetHumanDensityTranslation(%this, %exp)
{
   
   if ( %exp < 0.500 )
      return "Sparse Core";
      
   if ( %exp > 0.833 )
      return "Dense Core";
            
   return "Even Distribution";
}

////////////////////////
// Check Boxes /////////
////////////////////////
function GalaxyGen_EvenLevelDistribution_Lockbox::onAction(%this)
{
   GalaxyGenGui.EvenLevelDistribution = %this.getValue();
}

function GalaxyGen_EvenLevelDistribution_Lockbox::onMouseEnter(%this)
{
   %container = customStatWidget_addScaleContainer("256");  
   customStatWidget_AddText(%container, "EVEN LEVEL DISTRIBUTION", "", "20", "center", "1 1 0 1");
   customStatWidget_AddParagraph(%container, "Keeps the connected stars from having large difficulty differences");
   PushSmartPopup("GuiSmartBitmapPopupProfile", %this, %container, 20, true, "0 1 1 1", "0 0.6 1 1", 3000);  
}
function GalaxyGen_EvenLevelDistribution_Lockbox::onMouseLeave(%this)
{
   PopSmartPopup();
}

function GalaxyGen_MazeMode_Lockbox::onAction(%this)
{
   GalaxyGenGui.MazeMode = %this.getValue();
}

//MAZE BUTTON

function GalaxyGen_DebugMode_Lockbox::onAction(%this)
{
   GalaxyGenGui.DebugMode = %this.getValue();
}

function GalaxyGen_MazeMode_Lockbox::onMouseEnter(%this)
{
   %container = customStatWidget_addScaleContainer("256");  
   customStatWidget_AddText(%container, "GALACTIC MAZE", "", "20", "center", "1 1 0 1");
   customStatWidget_AddParagraph(%container, "There is only one path to the end of the game.  It's up to you to figure out the maze through the galaxy.  This is very hard!");
   PushSmartPopup("GuiSmartBitmapPopupProfile", %this, %container, 20, true, "0 1 1 1", "0 0.6 1 1", 3000);  
}
function GalaxyGen_MazeMode_Lockbox::onMouseLeave(%this)
{
   PopSmartPopup();
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Generation ///////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

$GalGen_ShowDebugInfo = false;

$GalGen_GGGroup = 0;
function GalaxyGenGui::GenerateGalaxy(%this)
{
   %numStars = %this.GetNumStars();
   
   //To moke start pos look more random: 
   %numStars += getRandom(-2, 2);
     
   $GalGen_ShowDebugInfo = %this.DebugMode;
   
   %status = BuildMultiGalaxy(%numStars);
   if ( %status $= "FAIL" )
   {
      echo("GalaxyGenGui::GenerateGalaxy Fail");
      return;
   }
   
   SpawnGalaxyGenImages();   //for the gui only
}

$OuterRingMax = 35; //used elsewhere os need to make a global
$InnerRingMax = 70;
function BuildMultiGalaxy(%numStars)
{
   SetupGalGenGroup();
   
   //Built from core to outside. IMPORTANT!
   //Zombie core (once ready for final boss)             //scale factor super outside
   //%status = CreateGalaxyGraph(mRound(%numStars * 0.030), 85, 95, 1, 1, 0.333, 0.08 * $GalGenRadius, 0.12 * $GalGenRadius, false, true, true); //need to let center cross centerline or will hit an inf loop.
   //if ( %status $= "FAIL" )
   //    return "FAIL";

    //Sector 3/4                                          //scale factor weights to outside (away from center deathzone)
   %status = CreateGalaxyGraph(mRound(%numStars * 0.200), $InnerRingMax, $OuterRingMax + 5, 3, 3, 0.500, 0.10 * $GalGenRadius, 0.35 * $GalGenRadius, false, true, false);
   if ( %status $= "FAIL" )
      return "FAIL";
      
    //Sector 1/2                                           //scale factor weights to center
   %status = CreateGalaxyGraph(mRound(%numStars * 0.800), $OuterRingMax, 5, 0, 3, 0.850, 0.50 * $GalGenRadius, $GalGenRadius, false, true, false);
   if ( %status $= "FAIL" )
      return "FAIL";
      
   LinkAllGalaxyGraphs(); //we need to mark the link stars so story stars dont grab em. 

   return "OK";
}



function SetupGalGenGroup()
{
   if ( isObject($GalGen_GGGroup) )
      $GalGen_GGGroup.delete();

   $GalGen_GGGroup = new SimGroup() {};
}

function ClearGalGenGroup()
{
   SetupGalGenGroup();
}


function GetGalGenStarCount()
{
   if ( !isObject($GalGen_GGGroup) )
      return 0;
      
   %count = 0;
   for ( %i = 0; %i < $GalGen_GGGroup.getCount(); %i++ )
   {
      %gg = $GalGen_GGGroup.getObject(%i);
      %count += %gg.NumStars;
   }
   return %count;
}

//this will be the star earth attaches itself to.
function GalGenGetLastStar()
{
   %outterGG = $GalGen_GGGroup.getObject($GalGen_GGGroup.getCOunt() - 1);
   %starSet = %outterGG.getOrderedStarSet();
   %lastStar = %starSet.getObject(%starSet.getCount() - 1);
   return %lastStar;   
}


function GalaxyGenGui::AcceptGalaxy(%this)
{   
   EscScreen_Pop(); //need to get rid of front end also, can't get rid of till now so you can still back out of the galaxy gen
   GalGen_Pop();
   StartNewGame(); 
}

//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
// Galaxy Graph //////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////


$GalaxyGenImageGroup = 0;  

$GalaxyAbortions = 0;
function CreateGalaxyGraph(%numStars, %maxLevel, %minLevel, %numRingLinks, %maxConstellationSize, %scalingExponent, %minDistance, %maxDistance, %useDistanceBasedLevels, %shareChildren, %allowCrossCenterline)
{  
   %this = new GalGraph() 
   {
      NumStars = %numStars;
      MaxLevel = %maxLevel;
      MinLevel = %minLevel;
      MaxConstellationSize = %maxConstellationSize;
      ScalingExponent = %scalingExponent;
      MinStarDistance = %minDistance;
      MaxStarDistance = %maxDistance;
      DistanceBasedLevels = %useDistanceBasedLevels;
      ShareChildren = %shareChildren;
      NumRingLinks = %numRingLinks;
      allowCrossCenterline = %allowCrossCenterline;
   };      
   
   if ( %this.abortedGalaxy )
   {
      echo("ABORTED GALAXY!:" SPC %numStars SPC %minLevel SPC %maxLevel); 
      $GalaxyAbortions++;
      if ( $GalaxyAbortions == 5 )
      {
         $GalaxyAbortions = 0;
         return "FAIL";        
      }      
      CreateGalaxyGraph(%numStars, %minLevel, %maxLevel, %numRingLinks, %maxConstellationSize, %scalingExponent, %minDistance, %maxDistance, %useDistanceBasedLevels, %shareChildren, %allowCrossCenterline);
      return;
   }
       
   $GalGen_GGGroup.add(%this);
   return "OK";
}


////////////////////////////////////////////////////
// Linking Galaxies ////////////////////////////////
////////////////////////////////////////////////////


//Has to happen after story stars defined so we can avoid them . 
function LinkAllGalaxyGraphs()
{
   //we dont check outer galaxy so we stop at getcount -1 since outer has nothing to link to. 
   for ( %i = 0; %i < $GalGen_GGGroup.getCount()-1; %i++ )
   {
      %innerGG = $GalGen_GGGroup.getObject(%i);
      %outerGG = $GalGen_GGGroup.getObject(%i+1);
           
      %numLinks = %innerGG.NumRingLinks;
      LinkGalaxyGraphs(%innerGG, %outerGG, %numLinks);
   }
}

function LinkGalaxyGraphs(%innerGG, %outerGG, %numLinks)
{
   if ( %numLinks == 0 )
      return;
      
   //need to find the lowest stars in the inner galaxy.  
   %innerStarSet = %innerGG.getOrderedStarSet();
   %outterStarSet = %outerGG.getOrderedStarSet();
   
   %currentAngleMin = -1;
   %currentAngleMax = 360;
   
   %angleStep = 360 / %numLinks;   
     
   for ( %linkIndex = 0; %linkIndex < %numLinks; %linkIndex++ )
   {      
      if ( %rootAngle !$= "" )
      {
         %newAngle = GetNormalAngle(%rootAngle + ((%linkIndex) * %angleStep)) + 360; //need to avoid the 0 flip.
         %currentAngleMin = %newAngle - (%angleStep / 4);
         %currentAngleMax = %newAngle + (%angleStep / 4);               
      }
         
      for ( %i = %innerStarSet.getCount() - 1; %i >= 0; %i-- )
      {
         %innerggStar = %innerStarSet.getObject(%i);
         if ( %innerggStar.IsLinkStar )
            continue;         
         
         %starAngle = GetNormalAngle(getVectorAngle(%innerggStar.StarPosition)) + 360;
              
         if ( %rootAngle !$= "" && (%starAngle < %currentAngleMin || %starAngle > %currentAngleMax ))
            continue;
            
         if (%rootAngle $= "" )
            %rootAngle = %starAngle;
                       
         %closestDistance = 10000;
         %closestStar = 0;
         
         for ( %j = 0; %j < %outterStarSet.getCount(); %j++ )
         {
            %outerggStar = %outterStarSet.getObject(%j);
            if ( %outerggStar.IsLinkStar )
               continue;      
         
            %dist = t2dVectorDistance(%outerggStar.StarPosition, %innerggStar.StarPosition);
            if ( %dist < %closestDistance )
            {
               %closestDistance = %dist;
               %closestStar = %outerggStar;                  
            }              
         }                
                    
         if ( !isObject(%closestStar) )
            break;      
                             
         %innerggStar.isLinkStar = true;
         %closestStar.isLinkStar = true;
         
         %innerggStar.GetStarLinkSet().add(%closestStar);
         %closestStar.GetStarLinkSet().add(%innerggStar);
         break; //found one, so start again.
                   
      }      
   }
}


function GetNormalAngle(%angle)
{
   while (%angle > 360 )
      %angle -= 360;
      
   while (%angle < 0 )
      %angle += 360;
      
   return %angle;  
}


/////////////////////////////////////////////////////
// Spawning Images //////////////////////////////////
/////////////////////////////////////////////////////

function SpawnGalaxyGenImages()
{
   CleanupGalaxyGenImages();  //just in case.
   
   $GalaxyGenImageGroup = new SimGroup() {};
 
   for ( %ggIndex = 0; %ggIndex < $GalGen_GGGroup.getCount(); %ggIndex++ )
   {
      %gg = $GalGen_GGGroup.getObject(%ggIndex);
      
      %constellationSet = %gg.GetConstellationSet();
      %constellationCount = %constellationSet.getCount();   
      
      for ( %i = 0; %i < %constellationCount; %i++ )
      {
         %currentConstellation = %constellationSet.getObject(%i);
         
         if ( $GalGen_ShowDebugInfo )
            DrawConstellationInfo(%currentConstellation);      
         
         %starSet = %currentConstellation.GetStarSet();
         %starCount = %starSet.getCount();
               
         for ( %j = 0; %j < %starCount; %j++ )
         {
            %currentStar = %starSet.getObject(%j);
            %starObject = SpawnGGStar(%currentStar);           
         }      
      }    
   }
   SpawnSolPlaceholder();
   SpawnStartingNestPlaceholders();
}


function CleanupGalaxyGenImages()
{
   if ( !isObject($GalaxyGenImageGroup) )
      return;
      
   $GalaxyGenImageGroup.delete();  
   $GalaxyGenImageGroup = 0; 
}



function SpawnGGStar(%star, %position, %level)
{         
   if ( isObject(%star) )
   {
      %position = %star.StarPosition;
      %level = %star.Level;
   }
   
   %size = "16 16";
   %this = new t2dStaticSprite() 
   {
      scenegraph = GalaxyGen_SceneWindow.getSceneGraph();  
      CollisionActiveSend = "0";
      CollisionActiveReceive = "0";      
      CollisionCallback = "0"; 
      CollisionGroups = $COLLISION_GROUPS_NONE;
      Layer = 0;
      GraphGroup = $COLLISION_ID_NONE;          
      imageMap = "childStar_01ImageMap";
      size = %size;
      Rotation = 0; 
      Position = %position;        
      
      //profileName = "GuiSpaceScrollProfile";
      level = %level;
      //displayText = %level;
      textOffset = "0 24";
   };
   $GalaxyGenImageGroup.add(%this);  
         
   %buttonEffect = new t2dScaleFactorSprite() 
   {
      scenegraph = %this.getSceneGraph(); 
      scaleFactor = 0.75;     
      imageMap = "starmap_levelBoxImageMap";    
      Layer = 2;    
      size = "96 32";
      Position = %this.Position;      
   }; 
   %buttonEffect.setBlendColor(HUD_GetDisplayColor((100 - %level), 100, true, 1));
   AddStarLevelBox(%level, %buttonEffect, GalaxyGen_SceneWindow.getSceneGraph(), $GalaxyGenImageGroup);
   $GalaxyGenImageGroup.add(%buttonEffect);    
   
   if ( !isObject(%star) )
      return %this; //in case we are drawing a fake star (Sol)
   
   %linkSet = %star.GetStarLinkSet();
   %linkCount = %linkSet.getCount();
   for ( %i = 0; %i < %linkCount; %i++ )
   {
      %currentLinkedStar = %linkSet.getObject(%i);
      %linkLine = CreateLinkLine(%star, %currentLinkedStar);      
   }  
      
   return %this;   
}


//Sol isnt part of the galaxy yet, but we know where it will be so show player. 
function SpawnSolPlaceholder()
{
   %connectionPos = GalGenGetLastStar().StarPosition;
  
   //From: GalaxyClass::CreateStoryStar_Add needs to be kept in sync.
   %starData = SG_EARTH;
   %offsetPercent = %starData.offsetPercent; //based on galaxy size. 
   %offsetDist = $GalGenRadius * %offsetPercent;
   %dirToConnection = getVectorAngle(%connectionPos); //since center of galaxy is 0 0 we dont need to do a vector sub here. 
   %dirToConnection += %starData.offsetAngle;
   %newStarPos = getPositionInDirection("0 0", %dirToConnection, %offsetDist);
   
   %level = %starData.techLevel;
   %star = SpawnGGStar(0, %newStarPos, %level);
   
   %blendColor = "1 1 1 0.2";
   %starLinkObject = DrawLineBetweenTwoPoints(%connectionPos, %newStarPos, %blendColor);
   $GalaxyGenImageGroup.add(%starLinkObject);   
   
   StarButtonClass::CreateButtonEffect(%star, "starmap_URHereImageMap", "256 32", "0 0", "1 1 1 1", -45);  
}


function SpawnStartingNestPlaceholders()
{
   %connectionPos = GalGenGetLastStar().StarPosition;
  
   //From: GalaxyClass::CreateStoryStar_Add needs to be kept in sync.
   %nestStars = "SG_WOLF359 SG_SIRIUS SG_LUYTEN";
   for ( %i = 0; %i < getWordCount(%nestStars); %i++ )
   {   
      %starData = getWord(%nestStars, %i);
      %offsetPercent = %starData.offsetPercent; //based on galaxy size. 
      %offsetDist = $GalGenRadius * %offsetPercent;
      %dirToConnection = getVectorAngle(%connectionPos); //since center of galaxy is 0 0 we dont need to do a vector sub here. 
      %dirToConnection += %starData.offsetAngle;
      %newStarPos = getPositionInDirection("0 0", %dirToConnection, %offsetDist);
      
      %level = %starData.techLevel;
      %star = SpawnGGStar(0, %newStarPos, %level);
      
      %blendColor = "1 1 1 0.2";
      %starLinkObject = DrawLineBetweenTwoPoints(%connectionPos, %newStarPos, %blendColor);
      $GalaxyGenImageGroup.add(%starLinkObject);   
   }
}

function CreateLinkLine(%starA, %starB)
{ 
   //this prevents double linking, but the art looks better double linked
   if ( %starA.links[%starB] == true )
      return;
      
   //so we only single link
   %starA.links[%starB] = true;
   %starB.links[%starA] = true;
   
   %rootPosition = %starA.StarPosition;
   %targetPosition = %starB.StarPosition;
   %blendColor = "1 1 1 0.2";

   %starLinkObject = DrawLineBetweenTwoPoints(%rootPosition, %targetPosition, %blendColor);
   
   $GalaxyGenImageGroup.add(%starLinkObject);   
   return %starLinkObject;
}

function DrawLineBetweenTwoPoints(%rootPosition, %targetPosition, %blendColor)
{   
   %difference = t2dVectorSub(%targetPosition, %rootPosition);  
   %angle = getVectorAngle(%difference);
   %vectorLen = VectorLen(%difference);
   %midpoint = getPositionInDirection(%rootPosition, %angle, %vectorLen / 2);   
   
   
   %thickness = 4;   
   %size = %thickness SPC %vectorLen;
   
   %starLinkObject = new t2dScaleFactorSprite() 
   {
      imageMap = "beam_baseImageMap";
      scenegraph = GalaxyGen_SceneWindow.getSceneGraph();       
      CollisionActiveSend = "0";
      CollisionActiveReceive = "0";      
      CollisionCallback = "0"; 
      CollisionGroups = $COLLISION_GROUPS_NONE;
      Layer = 1;
      GraphGroup = $COLLISION_ID_NONE;  
      size = %size;
      position = %midpoint;
      rotation = %angle;
      blendColor = %blendColor;
      scaleFactor = 1;
      scaleY = false;
   };
          
   %starLinkObject.setBlending(true, SRC_ALPHA, ONE); 
   return %starLinkObject;
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Debug Stuff ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////
// Constellation Info ////////////////
//////////////////////////////////////

function DrawConstellationInfo(%constellation)
{
   DrawConstellationBoundingBox(%constellation);
   DrawAllNeighbors(%constellation);
}


function GetConstellationMinPos(%constellation)
{
   %minPosX = getWord(%constellation.GetMinStarX().StarPosition, 0);
   %minPosY = getWord(%constellation.GetMinStarY().StarPosition, 1);
   %minPos = %minPosX SPC %minPosY;
   return %minPos;
}

function GetConstellationMaxPos(%constellation)
{
   %maxPosX = getWord(%constellation.GetMaxStarX().StarPosition, 0);
   %maxPosY = getWord(%constellation.GetMaxStarY().StarPosition, 1);
   %maxPos = %maxPosX SPC %maxPosY;
   return %maxPos;
}

function GetConstellationCentrePos(%constellation)
{
   %minPos = GetConstellationMinPos(%constellation);
   %maxPos = GetConstellationMaxPos(%constellation);
   
   %centre = t2dVectorAdd(%minPos, t2dVectorScale(t2dVectorSub(%maxPos, %minPos), 0.5));
   return %centre;   
}

function DrawConstellationBoundingBox(%constellation)
{
   %minPos = GetConstellationMinPos(%constellation);
   %maxPos = GetConstellationMaxPos(%constellation);
     
   %blendColor = "1 0.3 0.3 0.5";
   
   %pos1 = %minPos;
   %pos2 = getWord(%minPos, 0) SPC getWord(%maxPos, 1);
   %pos3 = %maxPos;
   %pos4 = getWord(%maxPos, 0) SPC getWord(%minPos, 1);
   
   %starLinkObject = DrawLineBetweenTwoPoints(%pos1, %pos2, %blendColor);
   $GalaxyGenImageGroup.add(%starLinkObject);   
   
   %starLinkObject = DrawLineBetweenTwoPoints(%pos2, %pos3, %blendColor);
   $GalaxyGenImageGroup.add(%starLinkObject);   
      
   %starLinkObject = DrawLineBetweenTwoPoints(%pos3, %pos4, %blendColor);   
   $GalaxyGenImageGroup.add(%starLinkObject);   
   
   %starLinkObject = DrawLineBetweenTwoPoints(%pos4, %pos1, %blendColor);
   $GalaxyGenImageGroup.add(%starLinkObject);   
}

/////////////////////////////
// Draw Neighbors ///////////
/////////////////////////////

function DrawAllNeighbors(%constellation)
{
   %neighborSet_UP = %constellation.GetNeighborSet_UP();
   %neighborSet_DOWN = %constellation.GetNeighborSet_DOWN();
   %neighborSet_LEFT = %constellation.GetNeighborSet_LEFT();
   %neighborSet_RIGHT = %constellation.GetNeighborSet_RIGHT();
   %sets = %neighborSet_UP SPC %neighborSet_DOWN SPC %neighborSet_LEFT SPC %neighborSet_RIGHT;
   
   %myPos = GetConstellationCentrePos(%constellation);
   for ( %i = 0; %i < getWordCount(%sets); %i++ )
   {
      %currentSet = getWord(%sets, %i);
      DrawLineToNeighborSet(%myPos, %currentSet);     
   }   
}

function DrawLineToNeighborSet(%rootPos, %currentSet)
{
   %blendColor = "0.3 0.3 1 0.5";
   for ( %i = 0; %i < %currentSet.getCount(); %i++ )
   {
      %currentConstellation = %currentSet.getObject(%i);
      %currentPos = GetConstellationCentrePos(%currentConstellation);     
        
      %starLinkObject = DrawLineBetweenTwoPoints(%rootPos, %currentPos, %blendColor);
      $GalaxyGenImageGroup.add(%starLinkObject);   
   }  
}

/*
//ConsoleMethod( GalaxyGraphStar, GetStarLinkSet, S32, 2, 2, "GetStarLinkSet()")
//ConsoleMethod( GalaxyGraphConstellation, GetStarSet, S32, 2, 2, "GetStarSet()")
//ConsoleMethod( GalaxyGraph, GetConstellationSet, S32, 2, 2, "GetConstellationSet()")
function ShowGalaxyGraphInfo(%gg)
{
   echo("New Galaxy Start:");
   
   %constellationSet = %gg.GetConstellationSet();
   %constellationCount = %constellationSet.getCount();
   
   echo("   Total Constellation Count :" SPC %constellationCount);
   
   for ( %i = 0; %i < %constellationCount; %i++ )
   {
      %currentConstellation = %constellationSet.getObject(%i);
      %starSet = %currentConstellation.GetStarSet();
      %starCount = %starSet.getCount();
      
      echo("      Constellation" SPC %i SPC "Star Count:" SPC %starCount);
      
      for ( %j = 0; %j < %starCount; %j++ )
      {
         %currentStar = %starSet.getObject(%j);
         %linkSet = %currentStar.GetStarLinkSet();
         %linkCount = %linkSet.getCount();
         %position = %currentStar.StarPosition;
         %level = %currentStar.Level;
         
         echo("         Star" SPC %j SPC "Level:" SPC %level SPC "Position:" SPC %position SPC "Link Count:" SPC %linkCount);
      }      
   } 
   echo("New Galaxy Finish:");
}
*/



////////////////////////////////////////////////////////////////////////////////
// set dressing
////////////////////////////////////////////////////////////////////////////////

function GalaxyGenGui::createGalaxyCore(%this)
{
   %size = $GalGenRadius * 3;
   %size = %size SPC %size;  
   %starSceneGraph = Starmap_SceneWindow.getSceneGraph();   
   
   //RLBRLB we don't recreate the prop every time, as it takes a long time to warm up // let it pause along with the scene graph
   
   if (!isObject(%this.galaxyProp))
   {
      %this.galaxyProp = new t2dStaticSprite() 
      {
         imageMap = "starmap_galaxyPropImageMap";
         scenegraph = %starSceneGraph;  
         CollisionActiveSend = "0";
         CollisionActiveReceive = "0";      
         CollisionCallback = "0"; 
         CollisionGroups = $COLLISION_GROUPS_NONE;
         Layer = 5;
         GraphGroup = $COLLISION_ID_NONE;               
         position = "0 0";
         size = %size;
         BlendColor = "1 1 1 0.3";
      }; 
      %this.galaxyProp.setBlending(true, SRC_ALPHA, ONE);  //INTENSE 
      %this.galaxyProp.setAngularVelocity(7);
      
      %effect = CreateEffectAtPosition(%starSceneGraph, "0 0", "galaxyCore", 3);
      %effect.playEffect(true);  
   }
}



////////////////////////////////////////////////////////////////////////////////
// Skip Tutorail setup function
////////////////////////////////////////////////////////////////////////////////

function SEC1_TutorialSkip_SetupFlow()
{
   //add all objectives
   //sec 1 earth tutoral
   SEC1_TutorialSkip_FakeObjective("S1_EarthIntro", "", "ENGINE FAILURE", "Get the mothership up and running again.");   
   SEC1_TutorialSkip_FakeObjective("S1_BuildFirstShip", "S1_EarthIntro", "BUILD YOUR FIRST SHIP", "Build a ship in the hangar screen"); 
   SEC1_TutorialSkip_FakeObjective("S1_FetchPart", "S1_EarthIntro", "FETCH THE PART", "Find the missing part to get the mothership engines back online");
   SEC1_TutorialSkip_FakeObjective("S1_ReturnPart", "S1_EarthIntro", "RETURN THE PART", "Bring the engine part back to the mothership");
   SEC1_TutorialSkip_FakeObjective("S1_ToMiningInstance", "S1_EarthIntro", "GO TO THE MINING LOCATION", "Use the system map to travel to Jupiter.");  
   
   //mining instance flow
   SEC1_TutorialSkip_FakeObjective("S1_Min_RebuildFleet", "", "REBUILD A FLEET", "More ships are needed before the mothership can be repaired.");  
   SEC1_TutorialSkip_FakeObjective("S1_Min_MiningTask", "S1_Min_RebuildFleet", "COLLECT 20 REZ NODES", "Pickup enough resources around the Jupiter mining base to build a new ship.  Bring cargo back to the warp beacon.");  
   SEC1_TutorialSkip_FakeObjective("S1_Min_BuildShip3", "S1_Min_RebuildFleet", "BUILD TWO DART SHIPS", "Dart class ships are now available.  You must build 2 of them in order to be fit for combat.  Have both ships present at the Jupiter mining base.  Use the hanger view to build and refit ships (F3).");
   SEC1_TutorialSkip_FakeObjective("S1_Favors", "", "MINOR FAVORS", "Miners are willing to help rebuild the clockwork in exchange for assistance.");  
   SEC1_TutorialSkip_FakeObjective("S1_AcceptFavor1", "S1_Favors", "DOCK WITH MINING BASE", "Fly near the Jupiter mining base to establish contact.");
   SEC1_TutorialSkip_FakeObjective("S1_GotoFavor1Instance", "S1_Favors", "FIND THE UTA CARGO", "Go to the mission location at Saturn.  Use System Map to travel (F5).");
   
   //3 mission flow
   SEC1_TutorialSkip_FakeObjective("S1_CompleteFavor1", "S1_Favors", "DESTROY THE UTA CARGO", "Locate and destroy all UTA crates in space around Saturn.  Eliminate any other resistance.");
   SEC1_TutorialSkip_FakeObjective("S1_CompleteFavor2", "S1_Favors", "DESTROY THE CIVILIAN ROGUES", "Locate and destroy all rogue ships near Uranus.  Use System Map to travel (F5).");  
   SEC1_TutorialSkip_FakeObjective("S1_CompleteFavor3", "S1_Favors", "FINISH OFF THE UTA PATROL", "Locate and destroy the few remaining UTA ships orbiting Neptune.  Use System Map to travel (F5).");   

   //warp gate flow
   SEC1_TutorialSkip_FakeObjective("S1_Clockwork1", "", "FINISH REPAIRS", "Return to the Mothership in Earth space.  Use System Map to travel (F5).");
   SEC1_TutorialSkip_FakeObjective("S1_UnblockWarpGate", "", "UNBLOCK THE WARPGATE", "Unblock the warp gate by destroying the ships guarding it.  Use System Map to travel (F5).");

   //don't complete this one so the dialog will fire, the same as the debug save
   AddStoryObjective("S1_GotoSector2", "", "LEAP OF FAITH", "Travel to another star using the starmap (F6)"); 
   
   //tutorials
   SEC1_TutorialSkip_FakeTutorial("ObjectivesTutorial");
   SEC1_TutorialSkip_FakeTutorial("CombatTutorial");
   SEC1_TutorialSkip_FakeTutorial("FleeTutorial");
   SEC1_TutorialSkip_FakeTutorial("FineStuffToBuy");
   SEC1_TutorialSkip_FakeTutorial("FleetControlTutorial");
   SEC1_TutorialSkip_FakeTutorial("AsteroidMiningTutorial");
   SEC1_TutorialSkip_FakeTutorial("CON_TUT_Levelup"); //may be risky to let this fire outside of flow given how many ways you can get data outside of sec 1
   SEC1_TutorialSkip_FakeTutorial("ShipBuildingTutorial");
   SEC1_TutorialSkip_FakeTutorial("ArmorTutorial");
   SEC1_TutorialSkip_FakeTutorial("SystemMapTutorial");
   SEC1_TutorialSkip_FakeTutorial("TacticsPanelTutorial");
   SEC1_TutorialSkip_FakeTutorial("StarmapTutorial");
   SEC1_TutorialSkip_FakeTutorial("PT_MotherUp1");
   SEC1_TutorialSkip_FakeTutorial("CatalogTutorial");
   
   //New ones.
   SEC1_TutorialSkip_FakeTutorial("ObsoleteTutorial");
   SEC1_TutorialSkip_FakeTutorial("ComponentTutorial");
   SEC1_TutorialSkip_FakeTutorial("CON_TUT_CrewCollectionAndUses");
   SEC1_TutorialSkip_FakeTutorial("CON_TUT_BlackBox");
   SEC1_TutorialSkip_FakeTutorial("CON_TUT_ShipLost");
   SEC1_TutorialSkip_FakeTutorial("newWepTutorial_missile");
   
   tutorial_markTag("InstanceWarp_StopHinting"); //stops the crazy marking of your first instance in sec 1
   
   //give you ships   
   HM_SetShipInHangar(0, "BoomerangShip");  
   HM_SetShipInHangar(1, "BoomerangShip"); 
   HM_SetShipInHangar(2, "BoomerangShip"); 
   
   
   %hullList = "hullDart hullBoomerang HullHatchet hullRanger";
   for ( %i = 0; %i < getWordCount(%hullList); %i++ )
   {
      %currentHull = getWord(%hullList, %i);
      FM_SetBlackBoxes(%currentHull, FM_GetRequiredBlackBoxes(%currentHull));
   }
  
   //hullDart.SetState($UM_OWNED);
   //hullBoomerang.SetState($UM_OWNED);
   //HullHatchet.SetState($UM_OWNED); 
   //hullRanger.SetState($UM_OWNED);  
   FM_SetBlackBoxes("hullTug", 1);  //from the warp gate    
   
   //give you comps
   //SmallEmitter.SetState($UM_OWNED);
   //MediumEmitter.SetState($UM_OWNED);
   //LargeEmitter.SetState($UM_OWNED);
   //HugeEmitter.SetState($UM_OWNED);   
   
   //S_BasicReactor.SetState($UM_OWNED);   
   //M_BasicReactor.SetState($UM_OWNED);   
   //L_BasicReactor.SetState($UM_OWNED);   
   //H_BasicReactor.SetState($UM_OWNED); 
   
   //S_BasicShield.SetState($UM_OWNED);    
   //M_BasicShield.SetState($UM_OWNED);   
   //L_BasicShield.SetState($UM_OWNED);   
   //H_BasicShield.SetState($UM_OWNED);   
   
   //other stuff
   SetMothershipLevel(2); 
   Goon_ChangeCurrentCount(100); 
   FM_SetFactionRU("Pirate", 1650);
   FM_SetFactionData("Pirate", 500);
   
   //unblock stars
   %currentStar = $CurrentGalaxy.GetSolSystem();
   for ( %j = 0; %j < %currentStar.getCount(); %j++)
   {
      %currentInstance = %currentStar.getObject(%j);
      %currentInstance.setInstanceHidden(false);  
   } 
   
   //set up links
   %solStar = $CurrentGalaxy.GetSolSystem();
   %sec2StartStar = $CurrentGalaxy.FindStoryStar("Sector2_RootSystem");
   HandleUnblockStarLink(%solStar, %sec2StartStar);
   %solStar.SetIsKnown(true);   
   %sec2StartStar.SetIsKnown(true);   
   
   //drop you in
   %initialInstance = %sec2StartStar.GetHideInstance();
   LoadInstance(%initialInstance);  
}

function SEC1_TutorialSkip_FakeObjective(%objectiveID, %parentObjective, %title, %text)
{
   AddStoryObjective(%objectiveID, %parentObjective, %title, %text); 
   CompleteObjective(%objectiveID);
}

function SEC1_TutorialSkip_FakeTutorial(%tutorialDB)
{
   $tutorialManager.tutdata[%tutorialDB] = true;   
}

function GalaxyGen_Sec1Skip_Lockbox::onAction(%this)
{
   if (%this.getValue() == 1)
   {
      %text = "WARNING: This will skip roughly one hour's worth of tutorial gameplay, story, and missions.  It is HIGHLY recommend that you DO NOT SKIP chapter 1 on your first play though.";
      AcceptDecline_Push("SKIP CHAPTER 1?", "AnD_TutorialSkip", "SEC1_TutorialSkip_Accept", "SEC1_TutorialSkip_Decline", %this);
      %container = "AcceptDecline_CustomContainer";
      customStatWidget_AddParagraph(%container, %text, "", "18", "", "1 0 0 1", false);     
   } 
   else
   {
      $SEC1_SkipTutorial = 0;  
   }
}

$SEC1_SkipTutorial = 0;
function SEC1_TutorialSkip_Accept(%lockbox)
{
   $SEC1_SkipTutorial = 1;
}

function SEC1_TutorialSkip_Decline(%lockbox)
{
   $SEC1_SkipTutorial = 0;
   %lockbox.setValue(0);
}


///////////////////////////////////////////
// Tech Tree //////////////////////////////
///////////////////////////////////////////

function GalaxyGen_RandomTech_CheckBox::onAction(%this)
{
   if (%this.getValue() == 1)
   {
      %text = "WARNING: This option will generate a random tech progression for each research category.  This means that some levelups may be underpowered, while others are overpowered.  Only advanced users should use this option.  The maximum research bonuses are the same for both modes, but with a random tree, the game can take unusual turns and may be less balanced.";
      AcceptDecline_Push("Random Tech Progression?", "AnD_TutorialSkip", "RandomTechTree_Accept", "RandomTechTree_Decline", %this);
      %container = "AcceptDecline_CustomContainer";
      customStatWidget_AddParagraph(%container, %text, "", "18", "", "1 0 0 1", false);     
   } 
   else
   {
      $RandomTechTree = 0;  
   }
}

$RandomTechTree = 0;
function RandomTechTree_Accept(%lockbox)
{
   $RandomTechTree = 1;
}

function RandomTechTree_Decline(%lockbox)
{
   $RandomTechTree = 0;
   %lockbox.setValue(0);
}


function GalaxyGen_RandomTech_CheckBox::OnMouseEnter(%this)
{   
   PopSmartPopup(); 
   
   %text = "Tech Progression Mode";
   %description = "Normally, SPAZ uses an increasing but balanced tech tree, where each levelup gives the player incremental progress in each tech categories' stats.\n\nWhen a Randomized tech progression is selected, upgrades per level are dealt like cards from a deck, with higher levels being more likely to receive upgrade cards.  This leads to a much more interesting tech progression where research choices become more strategic, but it can also lead to an unbalanced experience.";
   
   %container = customStatWidget_addScaleContainer("256");
   customStatWidget_AddText(%container, %text, "", "18", "center", "1 1 1 1");
   customStatWidget_AddParagraph(%container, %description, "", "", "", "1 1 0 1");
   PushSmartPopup("GuiSmartBitmapPopupProfile", %this, %container, 20, true, "0 1 1 1", "0 0.6 1 1", 3000);    
}

function GalaxyGen_RandomTech_CheckBox::OnMouseLeave(%this)
{   
   PopSmartPopup();   
}

   
   


//////////////////////////////////////////////////
// BH Density ////////////////////////////////////
//////////////////////////////////////////////////

$BH_Density_None   = 0;
$BH_Density_Low    = 1;
$BH_Density_Normal = 2;
$BH_Density_High   = 3;

$Current_BH_Density = $BH_Density_Normal;

$BH_DensityText[$BH_Density_None]   = "NONE";
$BH_DensityText[$BH_Density_Low]    = "LOW";
$BH_DensityText[$BH_Density_Normal] = "DEFAULT";
$BH_DensityText[$BH_Density_High]   = "HIGH";

$BH_DensityDesc[$BH_Density_None]   = "No Bounty Hunter Strongholds will spawn in the Galaxy.  No global ramifications for your evil deeds.";
$BH_DensityDesc[$BH_Density_Low]    = "There are fewer Bounty Hunter Strongholds.  You can easily avoid Bounty Hunter space and cause trouble at will.";
$BH_DensityDesc[$BH_Density_Normal] = "There are a normal amount of Bounty Hunter Strongholds.  There should still be many safe areas where you can operate with impunity.";
$BH_DensityDesc[$BH_Density_High]   = "There are many Bounty Hunter Strongholds.  Beware, their agents are everywhere.";



function GetBH_Density()
{
   return $Current_BH_Density;  
}


function BH_Allowed()
{
   return GetBH_Density() != $BH_Density_None;
}


function SetBH_Density(%value, %isInit)
{
   if ( %isInit $= "" )
      %isInit = false;
      
   if ( %value $= "" )
      %value = $BH_Density_Normal;
      
   %shortText = $BH_DensityText[%value];   
   %text = "Bounty Hunter Population:   " SPC %shortText;
   GalaxyGen_BH_Density_Text.setText(%text);
   
   $Current_BH_Density = %value;
   
   if ( GalaxyGenGui.isAwake() && !%isInit)
      GalaxyGen_BH_Density_Slider.UpdateDescText();   
}

function GalaxyGenGui::onBH_DensityChanged(%this)
{
   %lastValue = GetBH_Density();
   %value = GalaxyGen_BH_Density_Slider.getValue();
   
   if ( %value != %lastValue )
      SetBH_Density(%value);   
}


function GalaxyGen_BH_Density_Slider::OnMouseEnter(%this)
{   
   %this.UpdateDescText();
}

function GalaxyGen_BH_Density_Slider::OnMouseLeave(%this)
{   
   PopSmartPopup();   
}

function GalaxyGen_BH_Density_Slider::UpdateDescText(%this)
{
   PopSmartPopup();   
   %density = GetBH_Density();
   %shortText = $BH_DensityText[%density];
   %text = "Bounty Hunter Pop: " SPC %shortText;
   %description = $BH_DensityDesc[%density];
   
   %container = customStatWidget_addScaleContainer("256");
   customStatWidget_AddText(%container, %text, "", "18", "center", "1 1 1 1");
   customStatWidget_AddParagraph(%container, %description, "", "", "", "1 1 0 1");
   
   %warning = "";
   if ( %density == $BH_Density_None )
   {
      customStatWidget_addSpace(%container);
      customStatWidget_AddText(%container, "Bounty Hunter ships will never spawn.", "", "", "", "1 0 0 1");   
   }
      
   PushSmartPopup("GuiSmartBitmapPopupProfile", %this, %container, 20, true, "0 1 1 1", "0 0.6 1 1", 3000);    
}

//////////////////////////////////////////////////
// Tech Density ////////////////////////////////////
//////////////////////////////////////////////////



$Current_Tech_Density = $Tech_Density_Normal;

$Tech_DensityText[$Tech_Density_Low]      = "LOW";
$Tech_DensityText[$Tech_Density_Normal]   = "DEFAULT";
$Tech_DensityText[$Tech_Density_High]     = "HIGH";
$Tech_DensityText[$Tech_Density_VeryHigh] = "VERY HIGH";

$Tech_DensityDesc[$Tech_Density_Low]      = "Blueprints are quite scarce. be prepared for to hunt far and wide for tech or research strategically to make the best use of what you have already found.";
$Tech_DensityDesc[$Tech_Density_Normal]   = "There is a normal amount of tech blueprints.  You will have to hunt around a little, but tech should come available fairly regularly in your travels.";
$Tech_DensityDesc[$Tech_Density_High]     = "Blueprints are more common.  You may have to do some searching to find more uncommon blueprints, but most of the time you will quickly find what you are after.";
$Tech_DensityDesc[$Tech_Density_VeryHigh] = "Blueprints are extremely common.  There will be almost no exploration involved in finding blueprints.";


function GetTech_Density()
{
   return $Current_Tech_Density;  
}

function SetTech_Density(%value, %isInit)
{
   if ( %isInit $= "" )
      %isInit = false;
      
   if ( %value $= "" )
      %value = $Tech_Density_Normal;
      
   %shortText = $Tech_DensityText[%value];   
   %text = "Tech Availability:   " SPC %shortText;
   GalaxyGen_Tech_Density_Text.setText(%text);
   
   $Current_Tech_Density = %value;
   
   if ( GalaxyGenGui.isAwake() && !%isInit)
      GalaxyGen_Tech_Density_Slider.UpdateDescText();   
}

function GalaxyGenGui::onTech_DensityChanged(%this)
{
   %lastValue = GetTech_Density();
   %value = GalaxyGen_Tech_Density_Slider.getValue();
   
   if ( %value != %lastValue )
      SetTech_Density(%value);   
}


function GalaxyGen_Tech_Density_Slider::OnMouseEnter(%this)
{   
   %this.UpdateDescText();
}

function GalaxyGen_Tech_Density_Slider::OnMouseLeave(%this)
{   
   PopSmartPopup();   
}

function GalaxyGen_Tech_Density_Slider::UpdateDescText(%this)
{
   PopSmartPopup();   
   %density = GetTech_Density();
   %shortText = $Tech_DensityText[%density];
   %text = "Tech Availability: " SPC %shortText;
   %description = $Tech_DensityDesc[%density];
   
   %container = customStatWidget_addScaleContainer("256");
   customStatWidget_AddText(%container, %text, "", "18", "center", "1 1 1 1");
   customStatWidget_AddParagraph(%container, %description, "", "", "", "1 1 0 1");
   
   %warning = "";
   if ( %density == $Tech_Density_Low )
   {
      customStatWidget_addSpace(%container);
      customStatWidget_AddText(%container, "Difficult to complete advanced blueprints.", "", "", "", "1 0 0 1");   
   }
      
   PushSmartPopup("GuiSmartBitmapPopupProfile", %this, %container, 20, true, "0 1 1 1", "0 0.6 1 1", 3000);    
}

 