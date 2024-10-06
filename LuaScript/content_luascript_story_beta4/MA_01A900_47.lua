
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201190000", "201190000")
	change_time_and_weather(1,1) 

	
	pbadv_setup_101009_Noir(2,true, 27, 9,0)  
	pbadv_setup_101011_Guinevere(1,true, 27, 7,0)  
	pbadv_setup_101051_Lucius(2,true, 30, 8,0)  
	pbadv_setup_101001_Tyrfing(1,true, 26, 10,0)  
	pbadv_setup_101038_Lola(2,true, 30, 7,0) 
	pbadv_setup_101039_Fren(2,true, 30, 9,0) 
	
	pbadv_setup_101010_Lancelot(3,true, 25, 8,0)  
	pbadv_setup_101015_Arthur(0,true, 25, 6,0)  
	pbadv_setup_101012_Dinatan(0,true, 25, 7,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 25, 9,0)  
	pbadv_setup_101017_Maladisant(1,true, 25, 10,0)  

	ryuu = dot_reserve_ally(201021001, 33,  6, 0)	
	dot_set_weapon(ryuu, 105010001)		

setup_complete_unit()


	
	dot_unit_dir(ryuu, 2)
	dot_unit_dir(dotLucius2, 2)
	dot_unit_dir(dotLola2, 2)
	dot_unit_dir(dotFren2, 2)	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere1, false)
	dot_disp_weapon(dotLola2, false)
	dot_disp_weapon(dotFren2, false)



	
	
	dot_disp_unit(dotLucius2, false)
	
	dot_disp_unit(dotTyrfing1, false)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(28, 9, 0.0)
end



function Play()
	fadein(0)
	Play_start(true)

	wait_time(1.0)

	
	move_camera(30, 9, 0.5)	
	wait_camera()
	
	
	
	dot_disp_weapon(dotFren2, true)
	
	
	change_face(Fren2, "Anger")
	open_speech_window("CHRNAME_FREN2", nil, Fren2)
	message("MA_01A900_470003")
	close_speech_window()

	
	dot_disp_weapon(dotLola2, true)
	
	change_face(Lola2, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola2)
	message("MA_01A900_470004")
	close_speech_window()
	
	
	move_camera(27, 9, 0.7)	
	wait_camera()
	
	dot_disp_weapon(dotGuinevere1, true)

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_470005")
	close_speech_window()
	
	
	dot_disp_weapon(dotNoir2, true)
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_470006")
	close_speech_window()

	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_470007")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_470008")
	close_speech_window()

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 27, 9,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 27, 7,0)
	pbadv_setup_101051_Lucius_preload(2,true, 30, 8,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 26, 10,0)
	pbadv_setup_101038_Lola_preload(2,true, 30, 7,0)
	pbadv_setup_101039_Fren_preload(2,true, 30, 9,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 25, 8,0)
	pbadv_setup_101015_Arthur_preload(0,true, 25, 6,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 25, 7,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 25, 9,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 25, 10,0)
end
