
///////////////////////////////////////////////////////////////////////////////
// MOTHER COMIC 1
///////////////////////////////////////////////////////////////////////////////

function testComic_1()
{
   EscScreen_Pop();
   comic_startSequence("Comic_Mother1_01");
}

new ScriptGroup (Comic_Mother1_01 : Comic_SceneBase) 
{  
   nextScene = "Comic_Mother1_02";
   sceneTime = 10000;
   dialog = "snd_comicDialog_2_1";
   dialogDelay = 0.2;   
   new ScriptGroup (cell_ship_underlay : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellDistance = 10000;
      cellImage = "comic_intro_s06c01ImageMap"; //uses image from previous comic
      cellAngularVelocity = 1.5;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.2;
      cellStartSize = "512 512";
      cellEndSize = "512 512";     
   };
   new ScriptGroup (cell_ship_overlay : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellImage = "comic_M1_s01c01ImageMap"; 
      cellAngularVelocity = 1.5;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "512 512";
      cellEndSize = "512 512";   
   };
   new ScriptGroup (cell_smallShips_01 : Comic_CellBase) 
   {  
      cellImage = "comic_M1_s01c02ImageMap"; 
      cellAngularVelocity = 10;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "512 512";
      cellEndSize = "512 512";  
      cellPosition = "0 0"; 
   };
   new ScriptGroup (cell_smallShips_02 : cell_smallShips_01) 
   {  
      cellAngularVelocity = 8;  
      cellPulseDelay = 0.5;
      cellPosition = "-335.162 165.904"; 
   };
   new ScriptGroup (cell_smallShips_03 : cell_smallShips_01) 
   {  
      cellAngularVelocity = 12;  
      cellPulseDelay = 0.6;
      cellPosition = "229.000 -134.000"; 
   };
   new ScriptGroup (cell_smallShips_04 : cell_smallShips_01) 
   {  
      cellAngularVelocity = 12;  
      cellPulseDelay = 0.7;
      cellPosition = "-229.000 -134.000"; 
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_M1_s01textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 250 ";
      cellPulseDelay = 0.2; 
      cellStartSize = "512 128";
      cellEndSize = "512 128"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
   };
};

new ScriptGroup (Comic_Mother1_02 : Comic_SceneBase) 
{  
   dialog = "snd_comicDialog_2_2";
   sceneTime = 10000;
   new ScriptGroup (cell_galaxyProp : Comic_CellBase) 
   {  
      cellImage = "comic_M1_s02c05ImageMap"; 
      cellAngularVelocity = 10;  
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseDelay = 0.3;
      cellPulseTime = 0.6;
      cellStartSize = "1024 1024";
      cellEndSize = "1024 1024";
      cellPosition = "300 -100";
   };
   new ScriptGroup (planetEarthProp : Comic_CellBase) 
   {  
      cellAngle = -90;
      cellDistance = 5000;
      cellImage = "comic_M1_s02c04ImageMap"; 
      cellAngularVelocity = 15;  
      cellPulseDelay = 0.1;
      cellMoveDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.9;
      cellStartSize = "768 768";
      cellEndSize = "1 1";
      cellPosition = "300 -100";
   };
   new ScriptGroup (elsaFace : Comic_CellBase) 
   {  
      cellAngle = 0;
      cellImage = "comic_M1_s02c03ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "300 300";
      cellEndSize = "256 256";
      cellPosition = "50.546 -204.271";
   };
   new ScriptGroup (carlFace : Comic_CellBase) 
   {  
      cellAngle = 0;
      cellImage = "comic_M1_s02c02ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.3;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "450 450";
      cellEndSize = "384 384";
      cellPosition = "-121.000 -114.081";
   };
   new ScriptGroup (donFace : Comic_CellBase) 
   {  
      cellAngle = 0;
      cellImage = "comic_M1_s02c01ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.2;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "600 600";
      cellEndSize = "512 512";
      cellPosition = "-294.000 6.000";
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_M1_s02textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "200.000 260.000";
      cellStartSize = "512 128";
      cellEndSize = "512 128"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};
