
///////////////////////////////////////////////////////////////////////////////
// FINAL COMIC setup
///////////////////////////////////////////////////////////////////////////////

function finalComic()
{
   EscScreen_Pop();
   comic_startSequence("Comic_Final_01"); 
}

new ScriptGroup (cell_finalCreepFace_A : Comic_CellBase) 
{  
   cellImage = "comic_creepyface1ImageMap"; 
   cellAngularVelocity = 0;  
   cellPulseDelay = 0.1;
   cellStartBlend = "1 1 1 1";
   cellEndBlend = "1 1 1 0";
   cellPulseTime = 0.035;
   cellStartSize = "1024 1024";
   cellEndSize = "1024 1024";  
   cellPosition = "324.018 -70.835";    
};

new ScriptGroup (cell_finalCreepFace_B : cell_finalCreepFace_A) 
{  
   cellImage = "comic_creepyface2ImageMap";  
};

///////////////////////////////////////////////////////////////////////////////
// FINAL COMIC
///////////////////////////////////////////////////////////////////////////////

new ScriptGroup (Comic_Final_01 : Comic_SceneBase) 
{  
   nextScene = "Comic_Final_02";
   sceneTime = 10000;
   dialog = "snd_comicDialog_6_1";
   dialogDelay = 0.2;
   stayBlack = true; 
   
   new ScriptGroup (cell_finalCore : Comic_CellBase) 
   {  
      cellImage = "blackhole_core01ImageMap"; 
      cellAngularVelocity = 10;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "512 512";
      cellEndSize = "512 512";  
      cellPosition = "324.018 -70.835";    
   };
   
   new ScriptGroup (cell_final_lightning1 : Comic_CellBase) 
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
      cellPosition = "324.018 -70.835";     
   };
   new ScriptGroup (cell_final_lightning2 : cell_final_lightning1) 
   {  
      cellPulseDelay = 0.6;
      cellVisibleDelay = 0.6;
      rotation = 45; 
   };
   new ScriptGroup (cell_final_lightning2 : cell_final_lightning1) 
   {  
      cellPulseDelay = 0.7;
      cellVisibleDelay = 0.7;
      rotation = 70; 
   };
   
   new ScriptGroup (cell_finalShips : Comic_CellBase) 
   {  
      cellAngle = -90;
      cellDistance = 5000;
      cellMoveDelay = 0.4;
      cellImage = "comic_final_c1shipImageMap"; 
      cellAngularVelocity = 0;  
      cellStartSize = "192.000 64.000";
      cellEndSize = "192.000 64.000";  
      cellPosition = "-359.000 -68.551";     
   };  
   
   new ScriptGroup (cell_finalTouch : Comic_CellBase) 
   {  
      cellImage = "comic_final_c1touchImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.7;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.02;
      cellStartSize = "768.000 384.000";
      cellEndSize = "768.000 384.000";  
      cellPosition = "27.418 -89.551";    
   }; 
   
   new ScriptGroup (cell_finalCreepFlash_s1_1 : cell_finalCreepFace_A) 
   {  
      cellVisibleDelay = 0.7;
      cellPulseDelay = 0.7;
      cellPosition = "-359.000 -68.551";    
   }; 
   
   new ScriptGroup (cell_finalCreepFlash_s1_2 : cell_finalCreepFace_B) 
   {  
      cellVisibleDelay = 0.9;
      cellPulseDelay = 0.9;
      cellPosition = "-359.000 -68.551";    
   }; 
   
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_final_s01textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 280 ";
      cellPulseDelay = 0.1; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};

new ScriptGroup (Comic_Final_02 : Comic_SceneBase) 
{  
   nextScene = "Comic_Final_03";
   sceneTime = 10000;
   dialog = "snd_comicDialog_6_2";
   dialogDelay = 0.2; 
   stayBlack = true;
   
   new ScriptGroup (cell_finalBulletShip : Comic_CellBase) 
   {  
      cellMoveSpeed = 350;
      cellMoveDelay = 0.1;
      rotation = 90;
      cellAngle = -90;
      cellDistance = 2000;
      cellImage = "bullet_normalImageMap"; 
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.7;
      cellPulseTime = 0.1;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellStartSize = "16 16";
      cellEndSize = "16 16";
      cellPosition = "0 0";
   };
   
   new ScriptGroup (cell_finalEarth : Comic_CellBase) 
   {  
      cellImage = "comic_M1_s02c04ImageMap"; 
      cellAngularVelocity = 0;  
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.2;
      cellStartSize = "512 512";
      cellEndSize = "512 512";
      cellPosition = "232.775 -125.352";
   };
   
   new ScriptGroup (cell_finalStation : Comic_CellBase) 
   {  
      cellImage = "comic_final_c2stationImageMap"; 
      cellAngularVelocity = 10;  
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.25;
      cellStartSize = "64 64";
      cellEndSize = "64 64";
      cellPosition = "0 0";
   };
   
   new ScriptGroup (cell_finalFace : Comic_CellBase) 
   {  
      cellVisibleDelay = 0.5;
      cellPulseDelay = 0.5;
      cellImage = "comic_final_c2faceImageMap"; 
      cellAngularVelocity = 0;  
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.4;
      cellStartSize = "768.000 768.000";
      cellEndSize = "768.000 768.000";
      cellPosition = "-326.000 16.000";
   };
   
   new ScriptGroup (cell_finalCreepFlash_s2_1 : cell_finalCreepFace_B) 
   {  
      cellVisibleDelay = 0.7;
      cellPulseDelay = 0.7;
      cellPosition = "-326.000 16.000";    
   }; 
   new ScriptGroup (cell_finalCreepFlash_s2_3 : cell_finalCreepFace_A) 
   {  
      cellVisibleDelay = 0.75;
      cellPulseDelay = 0.75;
      cellPosition = "-326.000 16.000";    
   }; 
   new ScriptGroup (cell_finalCreepFlash_s2_3 : cell_finalCreepFace_B) 
   {  
      cellVisibleDelay = 0.9;
      cellPulseDelay = 0.9;
      cellPosition = "-326.000 16.000";    
   }; 
   
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_final_s02textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "200 260";
      cellPulseDelay = 0.1; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};


new ScriptGroup (Comic_Final_03 : Comic_SceneBase) 
{  
   nextScene = "Comic_Final_04";
   sceneTime = 10000;
   dialog = "snd_comicDialog_6_3";
   dialogDelay = 0.2; 
   stayBlack = true;
   
   new ScriptGroup (cell_starmap : Comic_CellBase) 
   {  
      cellImage = "comic_final_c3starsImageMap"; 
      cellAngularVelocity = 0;  
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.2;
      cellStartSize = "1024 768";
      cellEndSize = "1024 768";
      cellPosition = "-3.000 2.956";
   };
   
   new ScriptGroup (cell_finalPulse : Comic_CellBase) 
   {  
      cellVisibleDelay = 0.4;
      cellPulseDelay = 0.4;
      cellImage = "effect_basicShockwaveImageMap";
      cellStartBlend = "1 1 1 0.5";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.3;
      cellStartSize = "1 1";
      cellEndSize = "2200 2200"; 
      cellPosition = "219.000 -58.952";
   };
   
   new ScriptGroup (cell_finalCreepFlash_s3_1 : cell_finalCreepFace_A) 
   {  
      cellVisibleDelay = 0.5;
      cellPulseDelay = 0.5;
      cellPosition = "219.000 -58.952";    
   }; 
   new ScriptGroup (cell_finalCreepFlash_s3_2 : cell_finalCreepFace_B) 
   {  
      cellVisibleDelay = 0.55;
      cellPulseDelay = 0.55;
      cellPosition = "219.000 -58.952";    
   }; 
   
   new ScriptGroup (cell_finalInfectWarn : Comic_CellBase) 
   {  
      cellImage = "comic_final_c3infectImageMap"; 
      cellAngularVelocity = 0;  
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellPulseDelay = 0.45; 
      cellStartSize = "192.000 96.000";
      cellEndSize = "192.000 96.000";
      cellPosition = "219.000 -58.952";
   };
   
   new ScriptGroup (cell_finalInfectWarn_2 : cell_finalInfectWarn) 
   {  
      cellPulseDelay = 0.5; 
      cellPosition = "256.024 38.000";
   };
   new ScriptGroup (cell_finalInfectWarn_3 : cell_finalInfectWarn) 
   {  
      cellPulseDelay = 0.6; 
      cellPosition = "-117.473 93.000";
   };
   new ScriptGroup (cell_finalInfectWarn_4 : cell_finalInfectWarn) 
   {  
      cellPulseDelay = 0.65; 
      cellPosition = "79.000 155.398";
   };
   new ScriptGroup (cell_finalInfectWarn_5 : cell_finalInfectWarn) 
   {  
      cellPulseDelay = 0.7; 
      cellPosition = "-293.000 2.587";
   };
   new ScriptGroup (cell_finalInfectWarn_5 : cell_finalInfectWarn) 
   {  
      cellPulseDelay = 0.75; 
      cellPosition = "269.000 -253.000";
   };
   
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_final_s03textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "-200.000 -200.000";
      cellPulseDelay = 0.1; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};


new ScriptGroup (Comic_Final_04 : Comic_SceneBase) 
{  
   nextScene = "Comic_Final_05";
   sceneTime = 10000;
   dialog = "snd_comicDialog_6_4";
   dialogDelay = 0.2; 
   stayBlack = true;
   
   new ScriptGroup (cell_finalWorkers_01 : Comic_CellBase) 
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
   new ScriptGroup (cell_finalWorkers_02 : cell_finalWorkers_01) 
   {  
      cellAngularVelocity = 8;  
      cellPulseDelay = 0.5;
      cellPosition = "-335.162 165.904"; 
   };
   new ScriptGroup (cell_finalWorkers_02 : cell_finalWorkers_01) 
   {  
      cellAngularVelocity = 12;  
      cellPulseDelay = 0.6;
      cellPosition = "229.000 -134.000"; 
   };
   new ScriptGroup (cell_finalWorkers_02 : cell_finalWorkers_01) 
   {  
      cellAngularVelocity = 12;  
      cellPulseDelay = 0.7;
      cellPosition = "-229.000 -134.000"; 
   };
   
   new ScriptGroup (cell_final_part : Comic_CellBase) 
   {  
      cellAngle = 0;
      cellDistance = 10000;
      cellImage = "comic_final_c4partImageMap"; //uses image from previous comic
      cellAngularVelocity = -5;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.1;
      cellStartSize = "192 256";
      cellEndSize = "192 256";   
      cellPosition = "-278.400 -165.960";  
   };
   
   new ScriptGroup (cell_final_underlay : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellDistance = 10000;
      cellImage = "comic_final_c4clockImageMap"; //uses image from previous comic
      cellAngularVelocity = 1;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 1";
      cellEndBlend = "1 1 1 0";
      cellPulseTime = 0.2;
      cellStartSize = "512 512";
      cellEndSize = "512 512";   
      cellPosition = "41.000 96.000";  
   };
   new ScriptGroup (cell_final_overlay : Comic_CellBase) 
   {  
      cellAngle = 180;
      cellImage = "comic_intro_s06c01ImageMap"; 
      cellAngularVelocity = 1;  
      cellPulseDelay = 0.4;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "512 512";
      cellEndSize = "512 512"; 
      cellPosition = "41.000 96.000";    
   };
   
   new ScriptGroup (cell_finalCreepFlash_s4_1 : cell_finalCreepFace_B) 
   {  
      cellVisibleDelay = 0.55;
      cellPulseDelay = 0.55;
      cellPosition = "41.000 96.000";    
   }; 
   
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_final_s04textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 -180";
      cellPulseDelay = 0.1; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};


new ScriptGroup (Comic_Final_05 : Comic_SceneBase) 
{  
   nextScene = "Comic_Final_Creds";
   sceneTime = 10000;
   dialog = "snd_comicDialog_6_5";
   dialogDelay = 0.2; 
   stayBlack = true;
   
   new ScriptGroup (cell_final_fleet : Comic_CellBase) 
   {  
      cellImage = "comic_final_c5shipsImageMap"; //uses image from previous comic
      cellAngularVelocity = 0;  
      cellPulseDelay = 0.5;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.3;
      cellStartSize = "2048 1536";
      cellEndSize = "1024 768";   
      cellPosition = "0 0";  
   };
   new ScriptGroup (cell_final_rock : Comic_CellBase) 
   {  
      cellImage = "comic_intro_s04c02ImageMap"; 
      cellAngularVelocity = 1.5;  
      cellPulseDelay = 0.1;
      cellStartBlend = "1 1 1 0";
      cellEndBlend = "1 1 1 1";
      cellPulseTime = 0.1;
      cellStartSize = "256 256";
      cellEndSize = "256 256"; 
      cellPosition = "0 0";    
   };
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_final_s05textImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 265";
      cellPulseDelay = 0.1; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.1;
   };
};

new ScriptGroup (Comic_Final_Creds : Comic_SceneBase) 
{  
   nextScene = "Comic_Final_Thanks";
   sceneTime = 5000;
   dialog = "";
   dialogDelay = 0.2; 
   stayBlack = true;
   
   new ScriptGroup (cell_finalCreepFlash_s6_1 : cell_finalCreepFace_A) 
   {  
      cellVisibleDelay = 0.2;
      cellPulseDelay = 0.2;
      cellPosition = "0 0";    
   }; 
   new ScriptGroup (cell_finalCreepFlash_s6_2 : cell_finalCreepFace_B) 
   {  
      cellVisibleDelay = 0.22;
      cellPulseDelay = 0.22;
      cellPosition = "0 0";    
   }; 
   new ScriptGroup (cell_finalCreepFlash_s6_3 : cell_finalCreepFace_A) 
   {  
      rotation = 90;
      cellVisibleDelay = 0.23;
      cellPulseDelay = 0.23;
      cellPosition = "0 0";    
   };    
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_final_theEndImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 0";
      cellPulseDelay = 0.2; 
      cellStartSize = "512 256";
      cellEndSize = "512 256"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
   };
};

new ScriptGroup (Comic_Final_Thanks : Comic_SceneBase) 
{  
   nextScene = "";
   sceneTime = 5000;
   dialog = "";
   dialogDelay = 0.2; 
   stayBlack = true;
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_final_credsImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 0";
      cellPulseDelay = 0.2; 
      cellStartSize = "512 768";
      cellEndSize = "512 768"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.2;
   };
};

new ScriptGroup (Comic_rawCredits : Comic_SceneBase) 
{  
   nextScene = "";
   sceneTime = 1000;
   dialog = "";
   dialogDelay = 0.2; 
   stayBlack = false;
   new ScriptGroup (cell_text : Comic_CellBase) 
   {  
      cellImage = "comic_final_credsImageMap";
      cellAngularVelocity = 0;  
      cellPosition = "0 0";
      cellPulseDelay = 0.2; 
      cellStartSize = "512 768";
      cellEndSize = "512 768"; 
      cellStartBlend = "1 1 1 0";
      cellPulseTime = 0.5;
   };
};
