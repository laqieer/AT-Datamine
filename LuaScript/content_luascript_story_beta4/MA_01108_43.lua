
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201000001", "201000001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 6, 21,0)  
	pbadv_setup_101011_Guinevere(0,true, 5, 20,0)  
	pbadv_setup_101010_Lancelot(3,true, 6, 20,0)  
	pbadv_setup_101012_Dinatan(0,true, 4, 21,0)  
	pbadv_setup_101021_Bruno(3,true, 5, 21,0)  
	pbadv_setup_101058_Laiens(0,true, 9, 20,0)  
	
		
	
	
	
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	



	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotBruno3, false)

	
	
	dot_disp_unit(dotLaiens, false)

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(40.0, 0.0)

	
	
	move_camera(5, 21, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)


					
	
	
	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE",  Guinevere, nil)
	message("MA_01108_430002")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01108_430003")
	close_speech_window()

	
	change_face(Lancelot3, "Smile")
	open_speech_window("CHRNAME_LANCELOT",  Lancelot3, nil)
	message("MA_01108_430004")
	close_speech_window()

	
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN",  Dinatan, nil)
	message("MA_01108_430005")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01108_430006")
	close_speech_window()

	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotLancelot3,2)

	wait_time(0.8)
	
	dot_unit_dir(dotBruno3,2)
	wait_time(0.3)
	dot_unit_dir(dotBruno3,3)
	wait_time(0.3)
	
	wait_time(0.5)
	
	change_face(Bruno3, "Normal")
	open_speech_window("CHRNAME_BRUNO2",  Bruno3, nil)
	message("MA_01108_430007")
	close_speech_window()


	
	
	open_cutin(2, 1)
	
	on_cutin(1, Noir2, "Smile", nil)
	on_cutin(2, Dinatan, "Smile", nil)
	open_speech_window("CHRNAME_NOIR_DINATAN",  nil, nil)
	message("MA_01108_430008")
	close_speech_window()
	
	
	close_cutin()

	
	change_face(Bruno3, "Surprise")
	open_speech_window("CHRNAME_BRUNO2",  Bruno3, nil)
	message("MA_01108_430009")
	close_speech_window()

	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01108_430010")
	close_speech_window()

	
	change_face(Dinatan, "Smile")
	open_speech_window("CHRNAME_DINATAN",  Dinatan, nil)
	message("MA_01108_430011")
	close_speech_window()

	
	change_face(Bruno3, "Smile")
	open_speech_window("CHRNAME_BRUNO2",  Bruno3, nil)
	message("MA_01108_430012")
	close_speech_window()

	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN",  Dinatan, nil)
	message("MA_01108_430013")
	close_speech_window()

	
	change_face(Bruno3, "Sad")
	open_speech_window("CHRNAME_BRUNO2",  Bruno3, nil)
	message("MA_01108_430014")
	close_speech_window()

	
	change_face(Dinatan, "Smile")
	open_speech_window("CHRNAME_DINATAN",  Dinatan, nil)
	message("MA_01108_430015")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE",  Guinevere, nil)
	message("MA_01108_430016")
	close_speech_window()

	
	change_face(Lancelot3, "Smile")
	open_speech_window("CHRNAME_LANCELOT",  Lancelot3, nil)
	message("MA_01108_430017")
	close_speech_window()

	
	change_face(Bruno3, "Smile")
	open_speech_window("CHRNAME_BRUNO2",  Bruno3, nil)
	message("MA_01108_430018")
	close_speech_window()

	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01108_430019")
	close_speech_window()

	
	change_face(Dinatan, "Smile")
	open_speech_window("CHRNAME_DINATAN",  Dinatan, nil)
	message("MA_01108_430020")
	close_speech_window()


	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE",  Guinevere, nil)
	message("MA_01108_430022")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Laiens, "Normal")
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01108_430023")
	close_speech_window()

	

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 6, 21,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 5, 20,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 6, 20,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 4, 21,0)
	pbadv_setup_101021_Bruno_preload(3,true, 5, 21,0)
	pbadv_setup_101058_Laiens_preload(0,true, 9, 20,0)
end
