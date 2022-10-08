
///////////////////////////////////////////////////////////////////////////////
// MOTHER COMIC 3
///////////////////////////////////////////////////////////////////////////////

function testComic_4()
{
   EscScreen_Pop();
   comic_startSequence("Comic_Mother3_01");
}

new ScriptGroup (Comic_Mother3_01 : Comic_SceneBase) 
{  
   nextScene = "Comic_Mother3_02";
   sceneTime = 10000;
   dialog = "snd_comicDialog_5_1";
   dialogDelay = 0.2;
   stayBlack = true; 
   
   new ScriptGroup (cell_zombieCore : Comic_CellBase) 
   {  
      cellImage = "blackhole_core01ImageMap"; 
      cellAngularVelocity = 10;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.2;
      cellStartSize = "512 512";
      cellEndSize = "512 512";  
      cellPosition = "0 0";    
   }; 
   new ScriptGroup (cell_wreckRight : Comic_CellBase) 
   {  
      cellAngle = 90;
      cellDistance = 5000;
      cellImage = "shipWreck_clockwork_03ImageMap";
      cellAngularVelocity = 1.5;  
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 1";
      cellStartSize = "200 384";
      cellEndSize = "256 384";
      cellPosition = "350 100";   
   };
   new ScriptGroup (cell_wreckLeft : Comic_CellBase) 
   {  
      cellAngle = 90;
      cellDistance = 7000;
      cellImage = "shipWreck_clockwork_02ImageMap";
      cellAngularVelocity = -1.5;  
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 1";
      cellStartSize = "256 512";
      cellEndSize = "256 512";
      cellPosition = "-300 80";   
   };
   new ScriptGroup (cell_wreckTop : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellDistance = 9000;
      cellImage = "shipWreck_clockwork_01ImageMap";
      cellAngularVelocity = 0.3;  
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 1";
      cellStartSize = "512 384";
      cellEndSize = "512 384";
      cellPosition = "0 -200";   
   };
   
   new ScriptGroup (cell_lightning1 : Comic_CellBase) 
   {  
      cellImage = "effect_lightning_01ImageMap";
      cellAngularVelocity = 0.3;  
      cellStartSize = "768 768";
      cellEndSize = "768 768";
      cellPosition = "0 0"; 
      cellPulseDelay = 0.3;
      cellVisibleDelay = 0.3;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.05;  
   };
   new ScriptGroup (cell_lightning2 : cell_lightning1) 
   {  
      cellPulseDelay = 0.6;
      cellVisibleDelay = 0.6;
      rotation = 45; 
   };
   new ScriptGroup (cell_lightning3 : cell_lightning1) 
   {  
      cellPulseDelay = 0.7;
      cellVisibleDelay = 0.7;
      rotation = 70; 
   };
      
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_M3_s01textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 290";
      cellPulseDelay = 0.2; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
   };
};

new ScriptGroup (Comic_Mother3_02 : Comic_SceneBase) 
{  
   dialog = "snd_comicDialog_5_2";
   sceneTime = 10000;
   
   new ScriptGroup (cell_mother3part1 : Comic_CellBase) 
   {  
      cellAngularVelocity = 0;  
      cellAngle = 135;
      cellDistance = 5000;
      cellImage = "comic_M3_s02c01ImageMap"; 
      cellStartBlend = "1 1 1 1";
      cellStartSize = "384.000 512.000";
      cellEndSize = "384.000 512.000"; 
      cellPosition = "-210 112";  
      rotation = 45; 
   };
   new ScriptGroup (cell_mother3part2 : Comic_CellBase) 
   {  
      cellMoveDelay = 0.1;
      cellAngularVelocity = 0; 
      cellAngle = -135;
      cellDistance = 5000;
      cellImage = "comic_M3_s02c02ImageMap"; 
      cellStartBlend = "1 1 1 1";
      cellStartSize = "256.000 512.000";
      cellEndSize = "256.000 512.000"; 
      cellPosition = "-137 186";
      rotation = 45;    
   };
   new ScriptGroup (cell_mother3part3 : Comic_CellBase) 
   {  
      cellImage = "comic_M3_s02c03ImageMap"; 
      cellAngularVelocity = 0;  
      cellStartSize = "768 512";
      cellEndSize = "768 512";  
      cellPosition = "-129 83";
      cellAngle = 90;
      cellDistance = 5000;
      cellMoveDelay = 0.4; 
      rotation = 45;    
   };
   new ScriptGroup (cell_mother3text_s2 : Comic_CellBase) 
   {  
      cellImage = "comic_M3_s02textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "180 -200";
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};

