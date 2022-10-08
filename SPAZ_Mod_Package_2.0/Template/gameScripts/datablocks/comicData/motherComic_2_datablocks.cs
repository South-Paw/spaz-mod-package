
///////////////////////////////////////////////////////////////////////////////
// MOTHER COMIC 2
///////////////////////////////////////////////////////////////////////////////

function testComic_2()
{
   EscScreen_Pop();
   comic_startSequence("Comic_Mother2_01");
}
function testComic_3()
{
   EscScreen_Pop();
   comic_startSequence("Comic_Mother2_02");
}

new ScriptGroup (Comic_Mother2_01 : Comic_SceneBase) 
{  
   nextScene = "Comic_Mother2_01B"; 
   sceneTime = 15000;
   dialog = "snd_comicDialog_3_1";
   dialogDelay = 0.2; 
   stayBlack = true;
   
   new ScriptGroup (cell_ship_scafold : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellImage = "comic_M2_s01c01ImageMap"; 
      cellAngularVelocity = 1.5;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "512 768";
      cellEndSize = "512 768";  
      cellPosition = "9.526 -32.013";    
   }; 
   new ScriptGroup (cell_ship_before : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellDistance = 10000;
      cellImage = "comic_M1_s01c01ImageMap"; //uses image from previous comic
      cellAngularVelocity = 1.5;  
      cellPulseDelay = 0.6;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.2;
      cellStartSize = "512 512";
      cellEndSize = "512 512";
      cellPosition = "27.134 2.281";   
   };
   new ScriptGroup (cell_ship_after : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellImage = "comic_M2_s01c02ImageMap"; 
      cellAngularVelocity = 1.5;  
      cellPulseDelay = 0.6;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "512 768";
      cellEndSize = "512 768";  
      cellPosition = "19.000 -24.000";
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
      cellImage = "comic_M2_s02textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "14.000 250.000";
      cellPulseDelay = 0.2; 
      cellStartSize = "512 128";
      cellEndSize = "512 128"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
   };
};

new ScriptGroup (Comic_Mother2_01B : Comic_SceneBase) 
{  
   sceneTime = 10000;
   dialog = "snd_comicDialog_3_2";
   dialogDelay = 0.2; 
   stayBlack = true;
   new ScriptGroup (cell_utaFleetShips : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s07c01ImageMap"; 
      cellAngularVelocity = 0;  
      cellStartSize = "384 256";
      cellEndSize = "384 256";  
      cellPosition = "207.200 109.602";
      cellAngle = 180;
      cellDistance = 10000;
      cellMoveDelay = 0.4; 
   };
   new ScriptGroup (cell_utaFleetShips_02 : cell_utaFleetShips) 
   {  
      cellPosition = "-207 -150";
      cellMoveDelay = 0.5; 
      cellStartBlend = "1 1 1 0.5";
      cellEndBlend = "1 1 1 0.5";
   };
   new ScriptGroup (cell_utaFleetShips_02 : cell_utaFleetShips) 
   {  
      cellPosition = "300 -300";
      cellMoveDelay = 0.6; 
      cellStartBlend = "1 1 1 0.5";
      cellEndBlend = "1 1 1 0.5";
   };
   new ScriptGroup (cell_jamisonFace : Comic_CellBase) 
   {  
      cellImage = "comic_M2_s01Bc01ImageMap"; 
      cellAngularVelocity = 0; 
      cellPulseDelay = 0.25;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.2; 
      cellStartSize = "512 512";
      cellEndSize = "512 512";  
      cellPosition = "-284.000 101.000"; 

   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_M2_s01BtextImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "180 -240";
      cellPulseDelay = 0.1; 
      cellStartSize = "512 128";
      cellEndSize = "512 128"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
   };
};

////////////////////////////////////////////////////////////////////////////////
// comic 2 chapter 2
////////////////////////////////////////////////////////////////////////////////

new ScriptGroup (Comic_Mother2_02 : Comic_SceneBase) 
{  
   dialog = "snd_comicDialog_4_1";
   dialogDelay = 0.2; 
   sceneTime = 10000;
   new ScriptGroup (cell_mothership : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellDistance = 10000; 
      cellImage = "comic_M2_s01c02ImageMap"; 
      rotation = "55.728";
      cellAngularVelocity = 0;  
      cellStartSize = "512 768";
      cellEndSize = "512 768";  
      cellPosition = "-377.667 250";
      cellRotation = "70";
      cellMoveDelay = 0.2; 
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 1";
   };
   new ScriptGroup (cell_titanFlash : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s04c01ImageMap";
      cellVisibleDelay = 0.5;
      cellPulseDelay = 0.5;
      cellPulseTime = 0.1;
      cellPosition = "311.000 -166.000";
      cellStartSize = "256 256";
      cellEndSize = "1200 1200"; 
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.6";
   };
   new ScriptGroup (cell_titanGate : Comic_CellBase) 
   {  
      cellAngle = 90;
      cellDistance = 6000;
      cellImage = "comic_M2_s02c01ImageMap"; 
      cellAngularVelocity = 20;  
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 1";
      cellStartSize = "512 512";
      cellEndSize = "512 512";
      cellPosition = "311.000 -166.000";
      cellMoveDelay = 0.1; 
   };
   new ScriptGroup (cell_titanBeam : Comic_CellBase) 
   {  
      cellImage = "beam_baseImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.5;
      cellVisibleDelay = 0.5;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.05;
      cellStartSize =  "49.908 674.725";
      cellEndSize = "49.908 674.725";
      cellPosition = "57.231 -15.351";
      rotation = "61.715";
   };
   new ScriptGroup (cell_titanBeam2 : Comic_CellBase) 
   {  
      cellImage = "comic_final_c1touchImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.5;
      cellVisibleDelay = 0.5;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.2;
      cellStartSize =  "1024.000 512.000";
      cellEndSize = "1024.000 512.000";
      cellPosition = "72.646 -36.409";
      rotation = "-27.5172";
   };
   new ScriptGroup (cell_swirl : Comic_CellBase) 
   {  
      cellImage = "effect_sparkBurst_01ImageMap"; 
      cellAngularVelocity = 128;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.5";
      cellPulseTime = 0.2;
      cellStartSize = "300 300";
      cellEndSize = "300 300";
      cellPosition = "311.000 -166.000";
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_M2_s01textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "-180.000 -200";
      cellPulseDelay = 0.1; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
   };
};

