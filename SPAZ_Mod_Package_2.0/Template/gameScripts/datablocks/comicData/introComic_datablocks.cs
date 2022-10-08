

///////////////////////////////////////////////////////////////////////////////
// BASE DATA
///////////////////////////////////////////////////////////////////////////////

function testComic()
{
   EscScreen_Pop();
   comic_startSequence("Comic_Intro_01");
}

new ScriptGroup (Comic_SceneBase) 
{ 
   nextScene = "";
   sceneTime = 4000; 
   dialog = "";
   dialogDelay = 0; 
   stayBlack = false;
};
new ScriptGroup (Comic_CellBase) 
{  
   rotation = 0;
   cellAngle = 0;
   cellImage = "comic_intro_s01c01ImageMap";
   cellAngularVelocity = 1;  
   cellPosition = "0 0";
   cellPulseDelay = 0; // 0-1 base on scene time
   cellStartSize = "768 768";
   cellEndSize = "768 768"; 
   cellStartBlend = "1 1 1 1";
   cellEndBlend = "1 1 1 1";
   cellPulseTime = 0.2; // 0-1 base on scene time
   cellMoveDelay = 0;
   cellMoveType = "MOVEIN"; //MOVEIN //MOVEOUT
   cellMoveSpeed = 6000;
   cellVisibleDelay = "";
   cellPulseDelete = false;
};

///////////////////////////////////////////////////////////////////////////////
// INTRO COMIC DATA
///////////////////////////////////////////////////////////////////////////////

new ScriptGroup (Comic_Intro_01 : Comic_SceneBase) 
{  
   nextScene = "Comic_Intro_02";
   sceneTime = 10000;
   dialog = "snd_comicDialog_1_1";
   dialogDelay = 0.2;
   new ScriptGroup (cell_pulse : Comic_CellBase) 
   {  
      cellImage = "effect_basicShockwaveImageMap";
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 1;
      cellStartSize = "512 512";
      cellEndSize = "2200 2200"; 
   };
   new ScriptGroup (cell_stars : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s01c01ImageMap";
      cellPulseDelay = 0.05;
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
      cellStartSize = "1000 1000"; 
      cellEndSize = "1000 1000"; 
   };
   new ScriptGroup (cell_ambientStars_01 : cell_stars) 
   {  
      rotation = 123;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.3";
      cellPulseTime = 1;
      cellStartSize = "1024 1024"; 
      cellEndSize = "1500 1500"; 
   };
   new ScriptGroup (cell_ambientStars_02 : cell_ambientStars_01) 
   {  
      rotation = 234;
      cellEndSize = "1800 1800"; 
   };
   new ScriptGroup (cell_lines1 : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s01c02ImageMap";
      cellPulseDelay = 0.3;
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
      cellStartSize = "1000 1000";
      cellEndSize = "1000 1000"; 
   };
   new ScriptGroup (cell_lines2 : cell_lines1) 
   {  
      cellImage = "comic_intro_s01c03ImageMap";
      cellPulseDelay = 0.5;
   };
   new ScriptGroup (cell_lines3 : cell_lines1) 
   {  
      cellImage = "comic_intro_s01c04ImageMap";
      cellPulseDelay = 0.7;
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s01textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 270";
      cellPulseDelay = 0.2; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};

new ScriptGroup (Comic_Intro_02 : Comic_SceneBase) 
{  
   nextScene = "Comic_Intro_03";
   dialog = "snd_comicDialog_1_2";
   sceneTime = 10000;
   new ScriptGroup (Cell_warpgate : Comic_CellBase) 
   {  
      cellAngle = -90;
      cellDistance = 10000;
      cellImage = "comic_intro_s02c01ImageMap";
      cellPosition = "234.000 190";
      cellStartSize = "512 512";
      cellEndSize = "512 512"; 
   };
   //ships
   new ScriptGroup (cell_ships1 : Comic_CellBase) 
   {  
      cellAngularVelocity = 0;  
      cellAngle = 90;
      cellDistance = 30000;
      cellImage = "comic_intro_s02c02ImageMap";
      cellPosition = "83 13";
      cellStartSize = "256 256";
      cellEndSize = "256 256"; 
   };
   new ScriptGroup (cell_ships2 : cell_ships1) 
   {  
      cellDistance = 50000;
      cellPosition = "-138 175";
      cellStartSize = "128 128";
      cellEndSize = "128 128"; 
      cellImage = "comic_intro_s02c03ImageMap";
   };
   new ScriptGroup (cell_ships3 : cell_ships1) 
   { 
      rotation = -90;
      cellDistance = 55000;
      cellPosition = "-229 -134";
      cellImage = "comic_intro_s07c01ImageMap";
      cellStartSize = "384 256";
      cellEndSize = "384 256"; 
   };
   //text
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s02textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "189 -218";
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};

new ScriptGroup (Comic_Intro_03 : Comic_SceneBase) 
{  
   nextScene = "Comic_Intro_04";
   dialog = "snd_comicDialog_1_3";
   sceneTime = 10000;
   new ScriptGroup (cell_data1 : Comic_CellBase) 
   {  
      cellAngularVelocity = 0; 
      cellImage = "comic_intro_s03c04ImageMap";
      cellPosition = "-281.000 211.000";
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.2";
      cellPulseTime = 1;
      cellStartSize = "512 512";
      cellEndSize = "512 512"; 
   };
   new ScriptGroup (cell_data2 : cell_data1) 
   {  
      rotation = "180";
      cellPosition = "52.602 -17.000";
      cellPulseDelay = 0.6; 
      cellEndBlend = "1 1 1 0.5";
   };
   new ScriptGroup (cell_atom : Comic_CellBase) 
   {  
      cellAngle = -90;
      cellDistance = 10000;
      cellImage = "comic_intro_s03c01ImageMap";
      cellPosition = "203.000 128.000";
      cellStartSize = "256 256";
      cellEndSize = "256 256"; 
   };
   new ScriptGroup (cell_elec1 : Comic_CellBase) 
   {  
      cellAngularVelocity = 45; 
      cellImage = "comic_intro_s03c02ImageMap";
      cellPosition = "203.000 128.000";
      cellPulseDelay = 0.2;
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
      cellStartSize = "512 512";
      cellEndSize = "512 512"; 
   };
   new ScriptGroup (cell_elec2 : Comic_CellBase) 
   {  
      cellAngularVelocity = 25; 
      cellImage = "comic_intro_s03c02ImageMap";
      cellPosition = "203.000 128.000";
      cellPulseDelay = 0.3;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.3";
      cellPulseTime = 0.25;
      cellStartSize = "768 768";
      cellEndSize = "768 768"; 
   };
   new ScriptGroup (cell_elec3 : Comic_CellBase) 
   {  
      cellAngularVelocity = 10; 
      cellImage = "comic_intro_s03c02ImageMap";
      cellPosition = "203.000 128.000";
      cellPulseDelay = 0.5;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.1";
      cellPulseTime = 0.25;
      cellStartSize = "1024 1024";
      cellEndSize = "1024 1024"; 
   };
   new ScriptGroup (cell_cryo : Comic_CellBase) 
   {  
      cellAngularVelocity = 0; 
      cellImage = "comic_intro_s03c03ImageMap";
      cellPosition = "-242.000 228.000";
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.15;
      cellStartSize = "256 256";
      cellEndSize = "256 256"; 
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s03textImageMap";
      cellAngularVelocity = 0; 
      cellPosition = "-171.000 -180";
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};

new ScriptGroup (Comic_Intro_04 : Comic_SceneBase) 
{  
   nextScene = "Comic_Intro_05";
   dialog = "snd_comicDialog_1_4";
   sceneTime = 10000;
   new ScriptGroup (debris1 : Comic_CellBase) 
   {  
      cellImage = "orbitObject_asteroid_cluster_02Imagemap";
      cellPosition = "128 128";
      cellAngularVelocity = -1;  
      cellPulseDelay = 0.2;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.1";
      cellPulseTime = 1;
      cellStartSize = "512 512";
      cellEndSize = "768 768"; 
   };
   new ScriptGroup (debris2 : Comic_CellBase) 
   {  
      cellImage = "orbitObject_asteroid_cluster_02Imagemap";
      cellPosition = "-256 -256";
      cellAngularVelocity = -1;  
      cellPulseDelay = 0.2;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.1";
      cellPulseTime = 1;
      cellStartSize = "512 512";
      cellEndSize = "768 768"; 
   };
   new ScriptGroup (cell_dust : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s04c01ImageMap";
      cellPulseDelay = 0.2;
      cellPosition = "100 -75";
      cellStartSize = "512 512";
      cellEndSize = "1200 1200"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 1;
   };
   new ScriptGroup (cell_data1 : Comic_CellBase) 
   {  
      cellAngularVelocity = 0; 
      cellImage = "comic_intro_s03c04ImageMap";
      cellPosition = "100 -75";
      cellPulseDelay = 0.3;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.2";
      cellPulseTime = 1;
      cellStartSize = "512 512";
      cellEndSize = "512 512"; 
   };
   new ScriptGroup (cell_rock : Comic_CellBase) 
   {  
      cellDistance = 10000;
      cellAngle = 180;
      cellPosition = "100 -75";
      cellImage = "comic_intro_s04c02ImageMap";
      cellAngularVelocity = -2;  
      cellStartSize = "400 400";
      cellEndSize = "400 400"; 
      cellPulseTime = 1;
   };
   new ScriptGroup (cell_ships1 : Comic_CellBase) 
   {  
      cellDistance = 20000;
      cellAngle = -90;
      cellImage = "comic_intro_s04c03ImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "260 180";
      cellStartSize = "256 256";
      cellEndSize = "256 256"; 
      cellPulseTime = 0.5;
   };
   new ScriptGroup (cell_ships2 : cell_ships1) 
   {  
      Rotation = "270";
      cellDistance = 30000;
      cellImage = "comic_intro_s04c03ImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "263.453 -199.800";
   };
   new ScriptGroup (cell_ships3 : Comic_CellBase) 
   {  
      cellDistance = 25000;
      cellAngle = 90;
      cellImage = "comic_intro_s04c04ImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "-250 0";
      cellStartSize = "256 256";
      cellEndSize = "256 256"; 
      cellPulseTime = 0.5;
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s04textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "-200 260";
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};


new ScriptGroup (Comic_Intro_05 : Comic_SceneBase) 
{  
   nextScene = "Comic_Intro_06";
   dialog = "snd_comicDialog_1_5";
   sceneTime = 10000;
   new ScriptGroup (cell_planet : Comic_CellBase) 
   {  
      cellDistance = 6500;
      cellAngle = -90;
      cellImage = "comic_intro_s05c01ImageMap";
      cellAngularVelocity = 1.5;  
      cellPosition = "90.611 95.792";
      cellStartSize = "512 512";
      cellEndSize = "512 512"; 
   };
   new ScriptGroup (cell_logo : Comic_CellBase) 
   {  
      Rotation = "23.892";
      cellAngularVelocity = 0;  
      cellImage = "comic_intro_s05c02ImageMap";
      cellPulseDelay = 0.3;
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.15;
      cellPosition = "140.624 -25.247";
      cellStartSize = "768 768";
      cellEndSize = "512 512"; 
   };
   new ScriptGroup (cell_ships : Comic_CellBase) 
   {  
      cellAngularVelocity = 6;  
      cellImage = "comic_intro_s05c03ImageMap";
      cellPulseDelay = 0.6;
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
      cellPosition = "-29.000 219.000";
      cellStartSize = "256 256";
      cellEndSize = "256 256"; 
   };
   new ScriptGroup (cell_ships2 : cell_ships) 
   {  
      cellAngularVelocity = 0;  
      cellImage = "comic_intro_s02c03ImageMap";
      cellPulseDelay = 0.4;
      cellPosition = "-321.870 186.497";
      cellStartSize = "128 128";
      cellEndSize = "128 128"; 
   };
   new ScriptGroup (cell_ships3 : cell_ships) 
   {  
      cellAngularVelocity = 0;  
      rotation = 180;
      cellImage = "comic_intro_s02c03ImageMap";
      cellPulseDelay = 0.8;
      cellPosition = "-271.200 54.613";
      cellStartSize = "128 128";
      cellEndSize = "128 128"; 
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s05textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "-184.000 -190";
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};


new ScriptGroup (Comic_Intro_06 : Comic_SceneBase) 
{  
   nextScene = "Comic_Intro_07";
   dialog = "snd_comicDialog_1_6";
   sceneTime = 10000;
   new ScriptGroup (cell_utaFightingShips : Comic_CellBase) 
   {  
      cellDistance = 6500;
      Rotation = "45";
      cellAngle = -90;
      cellMoveDelay = 0.1;
      cellAngularVelocity = 0;  
      cellImage = "comic_intro_s07c01ImageMap";
      cellPosition = "-236.274 93.726";
      cellStartSize = "384.000 256.000";
      cellEndSize = "384.000 256.000"; 
   };
   new ScriptGroup (cell_civFightingShips : Comic_CellBase) 
   {  
      cellDistance = 6500;
      Rotation = "225";
      cellAngle = 90; 
      cellMoveDelay = 0.2;
      cellAngularVelocity = 0;  
      cellImage = "comic_intro_s07c02ImageMap";
      cellPosition = "71.274 -143.726";
      cellStartSize = "384.000 256.000";
      cellEndSize = "384.000 256.000"; 
   };
   new ScriptGroup (cell_explosion : Comic_CellBase) 
   {  
      cellAngularVelocity = 0;  
      cellImage = "effect_puffImageMap";
      cellVisibleDelay = 0.4;
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.03;
      cellPosition = "-294.400 -76.077";
      cellStartSize = "128 128";
      cellEndSize = "256 256"; 
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
   };
   new ScriptGroup (cell_explosion2 : cell_explosion) 
   {  
      cellVisibleDelay = 0.45;
      cellPulseDelay = 0.45;
      cellPosition = "100.000 5.605";
   };
   new ScriptGroup (cell_explosion3 : cell_explosion) 
   {  
      cellVisibleDelay = 0.6;
      cellPulseDelay = 0.6;
      cellPosition = "-87.389 -79.281";
   };
   new ScriptGroup (cell_explosion4 : cell_explosion2) 
   {  
      cellVisibleDelay = 0.7;
      cellPulseDelay = 0.7;
   };
   new ScriptGroup (cell_explosion5 : cell_explosion3) 
   {  
      cellVisibleDelay = 0.75;
      cellPulseDelay = 0.75;
   };
   new ScriptGroup (cell_explosion6 : cell_explosion) 
   {  
      cellVisibleDelay = 0.8;
      cellPulseDelay = 0.8;
   };
      new ScriptGroup (cell_explosion7 : cell_explosion3) 
   {  
      cellVisibleDelay = 0.9;
      cellPulseDelay = 0.9;
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s07textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "210 200.000";
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};

new ScriptGroup (Comic_Intro_07 : Comic_SceneBase) 
{  
   sceneTime = 10000;
   dialog = "snd_comicDialog_1_7";
   new ScriptGroup (cell_ship : Comic_CellBase) 
   {  
      cellStartBlend = "1 1 1 0";
      cellAngle = 180;
      cellImage = "comic_intro_s06c01ImageMap";
      cellAngularVelocity = 1.5;  
      cellPosition = "0 100";
      cellStartSize = "512 512";
      cellEndSize = "512 512";
      cellPulseTime = 1;
   };
   new ScriptGroup (cell_cloud : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s01c01ImageMap";
      cellAngularVelocity = 2;  
      cellPosition = "0 100";
      cellStartSize = "768 768";
      cellEndSize = "1024 1024"; 
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 0.65";
      cellPulseTime = 1;
   };
   new ScriptGroup (cell_cloud_2 : cell_cloud) 
   {  
      cellAngularVelocity = -2;  
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s06textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "12.906 -200.531";
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};
