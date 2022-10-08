//Hangar Configuration
//Important:
//SPAZ is optimized for 4 hangars.  The game will run slowly for people with more hangars active

//Hangar Sizes:
//$HULLTYPE_TINY
//$HULLTYPE_SMALL
//$HULLTYPE_MEDIUM
//$HULLTYPE_LARGE
//$HULLTYPE_HUGE

//Mothership Level, Hangar Index = Size. 
//Broken Clockwork (Tutorial)
$HConfig[0, 0] = $HULLTYPE_TINY;
$HConfig[0, 1] = -1;
$HConfig[0, 2] = -1;
$HConfig[0, 3] = -1;  //-1 = inactive.
$HConfig[0, 4] = -1;
$HConfig[0, 5] = -1;
$HConfig[0, 6] = -1;
$HConfig[0, 7] = -1;

//Slightly Fixed Clockwork (Tutorial)
$HConfig[1, 0] = $HULLTYPE_SMALL;
$HConfig[1, 1] = $HULLTYPE_TINY;
$HConfig[1, 2] = -1; 
$HConfig[1, 3] = -1;  //-1 = inactive.
$HConfig[1, 4] = -1;
$HConfig[1, 5] = -1;
$HConfig[1, 6] = -1;
$HConfig[1, 7] = -1;

//Chapter 2
$HConfig[2, 0] = $HULLTYPE_LARGE;   
$HConfig[2, 1] = $HULLTYPE_SMALL;
$HConfig[2, 2] = $HULLTYPE_SMALL;
$HConfig[2, 3] = -1;
$HConfig[2, 4] = -1;
$HConfig[2, 5] = -1;
$HConfig[2, 6] = -1;
$HConfig[2, 7] = -1;

//Chapter 3
$HConfig[3, 0] = $HULLTYPE_HUGE;
$HConfig[3, 1] = $HULLTYPE_MEDIUM;
$HConfig[3, 2] = $HULLTYPE_SMALL;
$HConfig[3, 3] = -1;
$HConfig[3, 4] = -1;
$HConfig[3, 5] = -1;
$HConfig[3, 6] = -1;
$HConfig[3, 7] = -1;

//Chapter 4
$HConfig[4, 0] = $HULLTYPE_HUGE;
$HConfig[4, 1] = $HULLTYPE_LARGE;
$HConfig[4, 2] = $HULLTYPE_MEDIUM;
$HConfig[4, 3] = $HULLTYPE_SMALL;
$HConfig[4, 4] = -1;
$HConfig[4, 5] = -1;
$HConfig[4, 6] = -1;
$HConfig[4, 7] = -1;
