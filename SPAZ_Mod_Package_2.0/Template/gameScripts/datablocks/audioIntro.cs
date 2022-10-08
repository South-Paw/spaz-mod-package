//Needed so we can have audio in settings screen.

new AudioDescription(AudioNonLooping_Effect_MED)
{
   volume   = 0.1;   //MED //WORKS LIKE A PRIORITY HIGHER = LESS LIKLEY TO BE CULLED
   isLooping= false;
   is3D     = true;
   type     = $AudioType_Effects;
};


new AudioDescription(AudioNonLooping_Effect_LOW) //BG = non critical effect
{
   volume   = 0.01;  //LOW (note < 0.01 is bad)
   isLooping= false;
   is3D     = true;
   type     = $AudioType_Effects;
};

//would like a low med and high priority defined. 
new AudioDescription(AudioNonLooping_Effect_HIGH) //BG = non critical effect
{
   volume   = 1.0;    //HIGH
   isLooping= false;
   is3D     = true;
   type     = $AudioType_Effects;
};


new AudioDescription(AudioLooping_Effect)
{
   volume   = 1.0; 
   isLooping= true;
   is3D     = true;
   type     = $AudioType_Effects;
};

///////////////////////////////////////////
// Done use priorities on these ///////////
///////////////////////////////////////////

//These dont really need priorities
new AudioDescription(AudioLooping_MUSIC)
{
   volume   = 1.0;
   isLooping= true;
   is3D     = false;
   type     = $AudioType_Music;
   isStreaming = true; //i think streaming loopers are broken beware
};

new AudioDescription(AudioNonLooping_INTERFACE)
{
   volume   = 1.0; 
   isLooping= false;
   is3D     = false;
   type     = $AudioType_GUI;
};

//May also want a chatter that is quieter
new AudioDescription(AudioNonLooping_DIALOGUE)
{
   volume   = 1.0; 
   isLooping= false;
   is3D     = false;
   type     = $AudioType_Dialogue;
};

new AudioDescription(AudioNonLooping_CHATTER)
{
   volume   = 0.5; 
   isLooping= false;
   is3D     = false;
   type     = $AudioType_Chatter;
};

new AudioDescription(AudioNonLooping_UNIT_CHATTER)
{
   volume   = 0.8; 
   isLooping= false;
   is3D     = false;
   type     = $AudioType_UnitChatter;
};

//Needed for interface buttons
new AudioProfile(buttonClickPositive)
{
   filename = "~/data/audio/effects/buttonClickPositive.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};

new AudioProfile(buttonMouseOver)
{
   filename = "~/data/audio/effects/buttonMouseOver.ogg";
   description = "AudioNonLooping_INTERFACE";
   preload = true;
};
