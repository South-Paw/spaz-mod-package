
///////////////////////////////////////////////////////////////////////////////
// demo comic setup
///////////////////////////////////////////////////////////////////////////////

function demoComic()
{
   EscScreen_Pop();
   comic_startSequence("demoComic_01"); 
}

///////////////////////////////////////////////////////////////////////////////
// DEMO COMIC
///////////////////////////////////////////////////////////////////////////////

new ScriptGroup (demoComic_01 : Comic_SceneBase) 
{  
   nextScene = "demoComic_02";
   sceneTime = 10000;
   dialog = "";
   dialogDelay = 0.2;
   //stayBlack = true; 
   
   new ScriptGroup (cell_demoRoid_01_large : Comic_CellBase) 
   {  
      cellAngle = 90;
      cellDistance = 6000;
      Rotation = "11.7587";
      cellImage = "demoRoids_7ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellStartSize = "512 512";
      cellEndSize = "512 512";  
      cellPosition = "270 -132.798";    
   };
   new ScriptGroup (cell_demoRoid_02_small : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellDistance = 7000;
      Rotation = "24.5894";
      cellImage = "demoRoids_5ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellStartSize = "256 256";
      cellEndSize = "256 256";  
      cellPosition = "221.646 160.345";   
   };
   new ScriptGroup (cell_demoRoid_03_small : Comic_CellBase) 
   {  
      cellAngle = -90;
      cellDistance = 8000;
      Rotation = "-12.4951";
      cellImage = "demoRoids_6ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellStartSize = "256 256";
      cellEndSize = "256 256";  
      cellPosition = "-36.264 202.662";    
   };
   new ScriptGroup (cell_demoRoid_04_small : Comic_CellBase) 
   {  
      cellAngle = 0;
      cellDistance = 10000;
      Rotation = "10.1458";
      cellImage = "demoRoids_4ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellStartSize = "256 256";
      cellEndSize = "256 256";  
      cellPosition = "-280.271 186.454";    
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "demoText_1ImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "-210 -100";
      cellPulseDelay = 0.25; 
      cellStartSize = "512 512";
      cellEndSize = "512 512"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};

new ScriptGroup (demoComic_02 : Comic_SceneBase) 
{  
   sceneTime = 10000;
   dialog = "";
   dialogDelay = 0.2;
   stayBlack = true; 
   
   new ScriptGroup (cell_demoRoid_01B_large : Comic_CellBase) 
   {  
      cellAngle = 90;
      cellDistance = 6000;
      Rotation = "11.7587";
      cellImage = "demoRoids_1ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellStartSize = "512 512";
      cellEndSize = "512 512";  
      cellPosition = "-290 136";    
   };
   new ScriptGroup (cell_demoRoid_02B_small : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellDistance = 7000;
      Rotation = "24.5894";
      cellImage = "demoRoids_2ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellStartSize = "256 256";
      cellEndSize = "256 256";  
      cellPosition = "239.654 200";   
   };
   new ScriptGroup (cell_demoRoid_03B_small : Comic_CellBase) 
   {  
      cellAngle = -90;
      cellDistance = 8000;
      Rotation = "-12.4951";
      cellImage = "demoRoids_3ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellStartSize = "256 256";
      cellEndSize = "256 256";  
      cellPosition = "-12.662 232.662";    
   };
   new ScriptGroup (cell_demoRoid_04B_small : Comic_CellBase) 
   {  
      cellAngle = 0;
      cellDistance = 10000;
      Rotation = "-14.2044";
      cellImage = "demoRoids_8ImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 1";
      cellStartSize = "256 256";
      cellEndSize = "256 256";  
      cellPosition = "-320.495 -200";    
   };
   new ScriptGroup (cell_textB : Comic_CellBase) 
   {  
      cellImage = "demoText_2ImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "220.000 -100.000";
      cellPulseDelay = 0.25; 
      cellStartSize = "512 512";
      cellEndSize = "512 512"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};