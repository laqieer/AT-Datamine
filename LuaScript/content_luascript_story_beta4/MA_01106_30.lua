
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201070000", "201070000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Cloudy) 

	
	pbadv_setup_101009_Noir(2,true, 24, 13,0)  
	pbadv_setup_101001_Tyrfing(1,true, 25, 12,0)  
	pbadv_setup_101012_Dinatan(0,true, 24, 14,0)
	pbadv_setup_101017_Maladisant(0,true, 25, 14,0)  
	pbadv_setup_101014_Tristan(0,true, 25, 15,0)  
	pbadv_setup_101013_Gawain(0,true, 26, 13,0)  
	pbadv_setup_101018_Ragnar(1,true, 26, 14,0)  
	pbadv_setup_101011_Guinevere(0,true, 26, 15,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 26, 11,0)  
	pbadv_setup_101015_Arthur(0,true, 28, 12,0)  
	pbadv_setup_101019_Isolde(1,true,26, 12,0)  
		
	pbadv_setup_101050_Brian(0,true,22, 13,0)


setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotTyrfing1, 2)
	dot_unit_dir(dotDinatan, 2)
	dot_unit_dir(dotMaladisant, 2)
	dot_unit_dir(dotTristan, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotRagnar1, 2)
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGwenhwymawr1, 2)
	dot_unit_dir(dotArthur, 2)
	dot_unit_dir(dotIsolde1, 2)
	dot_unit_dir(dotBrian, 3)

	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotTyrfing1, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotMaladisant, false)
	dot_disp_weapon(dotTristan, false)
	dot_disp_weapon(dotGawain, false)
	dot_disp_weapon(dotRagnar1, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr1, false)
	dot_disp_weapon(dotArthur, false)
	dot_disp_weapon(dotIsolde1, false)
	dot_disp_weapon(dotBrian, false)
	
	
	dot_change_anim(dotBrian,1)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(24, 14, 0.0)
end



function Play()
	fadein(0)
	Play_start(true)


	
	change_face(Brian, "Sad") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_300002")

	
	
	
	dot_move_unit_seq(dotDinatan, 23, 14)
	
	
	wait_seq()
	
	
	dot_unit_dir(dotDinatan, 2)

	
	change_face(Brian, "Sad") 

	message("MA_01106_300004")
	close_speech_window()
	
	
	wait_time(0.3)	
	
	
	
	dot_disp_weapon(dotNoir2, true)
	
	
	wait_time(0.5)
		
	dot_change_anim(dotNoir2,12)	
	
	
	wait_time(1.0)	

	
	change_face(Brian, "Smile") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_300006")
	
	change_face(Brian, "Normal") 
	message("MA_01106_300007")






	
	 
    MA_01106_30_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01106_300009", "MA_01106_300010", "MA_01106_300011")  
	close_speech_window()
 
    if is_select(1) then            
       MA_01106_30_select1_1()
 
    elseif is_select(2) then        
        MA_01106_30_select1_2()
 
    elseif is_select(3) then        
        MA_01106_30_select1_3()
 
    end
    MA_01106_30_end()
 
end
 
function MA_01106_30_select1()
 
end
 
function MA_01106_30_select1_1()
 

 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_300013")
	
	change_face(Noir2, "Normal")
	message("MA_01106_300014")
	close_speech_window()

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_300015")
	close_speech_window()
 
      
end
 
 
function MA_01106_30_select1_2()
 

 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_300017")
	close_speech_window()

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_300018")
	
	change_face(Brian, "Normal") 
	message("MA_01106_300019")
	close_speech_window()
 
    
end
 
 
function MA_01106_30_select1_3()
 

     
 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_300021")
	close_speech_window()

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_300023")
	
	change_face(Brian, "Normal") 
	message("MA_01106_300024")
	
	change_face(Brian, "Normal") 
	message("MA_01106_300025")
	close_speech_window()
 
        
end
 
 
function MA_01106_30_end()
	


	
	change_face(Gawain, "Normal") 
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_300027")
	close_speech_window()

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_300028")
	close_speech_window()

	
	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01106_300029")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_300030")
	close_speech_window()

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_300031")
	close_speech_window()

	
	wait_time(0.5)
	
	dot_change_anim(dotNoir2,0)	
	
	
	wait_time(0.5)
	
	
	dot_disp_weapon(dotNoir2, false)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_300032")
	close_speech_window()

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 24, 13,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 25, 12,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 24, 14,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 25, 14,0)
	pbadv_setup_101014_Tristan_preload(0,true, 25, 15,0)
	pbadv_setup_101013_Gawain_preload(0,true, 26, 13,0)
	pbadv_setup_101018_Ragnar_preload(1,true, 26, 14,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 26, 15,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 26, 11,0)
	pbadv_setup_101015_Arthur_preload(0,true, 28, 12,0)
	pbadv_setup_101019_Isolde_preload(1,true,26, 12,0)
	pbadv_setup_101050_Brian_preload(0,true,22, 13,0)
end
