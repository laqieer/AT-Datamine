

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	ShowGlobalMenuButton(false)
	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(BattleTime_Night,BattleWeather_Shiny)
	
	
	
	pbadv_setup_101009_Noir(3,true, 12, 17,0)  
	pbadv_setup_101012_Dinatan(2,true, 0, 0,0)  
	
	toho1 = dot_reserve_ally(401038001, 23, 21, 0)
	dot_set_weapon(toho1, 101010001)		
	toho2 = dot_reserve_ally(401038001, 22, 22, 0)
	dot_set_weapon(toho2, 101010001)		
	toho3 = dot_reserve_ally(401038001, 22, 23, 0)
	dot_set_weapon(toho3, 101010001)		
	toho4 = dot_reserve_ally(401038001, 23, 24, 0)
	dot_set_weapon(toho4, 101010001)		

	
	dotsoldier1 = dot_reserve_ally(401035001, 36, 12, 0)
	dot_set_weapon(dotsoldier1, 101010001)    
	dotsoldier2 = dot_reserve_ally(401035001, 37, 12, 0)
	dot_set_weapon(dotsoldier2, 101010001)    
	dotsoldier3 = dot_reserve_ally(401035001, 38, 12, 0)
	dot_set_weapon(dotsoldier3, 101010001)    
	dotsoldier4 = dot_reserve_ally(401035001, 36, 13, 0)
	dot_set_weapon(dotsoldier4, 101010001)    
	dotsoldier5 = dot_reserve_ally(401035001, 37, 13, 0)
	dot_set_weapon(dotsoldier5, 101010001)    
	dotsoldier6 = dot_reserve_ally(401035001, 38, 13, 0)
	dot_set_weapon(dotsoldier6, 101010001)    
	dotsoldier7 = dot_reserve_ally(401035001, 36, 14, 0)
	dot_set_weapon(dotsoldier7, 101010001)    
	dotsoldier8 = dot_reserve_ally(401035001, 37, 14, 0)
	dot_set_weapon(dotsoldier8, 101010001)    
	dotsoldier9 = dot_reserve_ally(401035001, 38, 14, 0)
	dot_set_weapon(dotsoldier9, 101010001)    


	
	
	setup_complete_unit()

	
	
	dot_unit_dir(toho1, 2)
	dot_unit_dir(toho2, 2)
	dot_unit_dir(toho3, 2)
	dot_unit_dir(toho4, 2)

	dot_unit_dir(dotsoldier1, 2)
	dot_unit_dir(dotsoldier2, 2)
	dot_unit_dir(dotsoldier3, 2)
	dot_unit_dir(dotsoldier4, 2)
	dot_unit_dir(dotsoldier5, 2)
	dot_unit_dir(dotsoldier6, 2)
	dot_unit_dir(dotsoldier7, 2)
	dot_unit_dir(dotsoldier8, 2)
	dot_unit_dir(dotsoldier9, 2)

	
	
	
	dot_disp_weapon(dotDinatan2, false)
	dot_disp_weapon(toho1, false)
	dot_disp_weapon(toho2, false)
	dot_disp_weapon(toho3, false)
	dot_disp_weapon(toho4, false)
	

	
	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(12, 17, 0.0)

	load_sound("BGM_ADV_Unnmei_to_struggle")
	
end

function Play()
	fadein(0)
	Play_start(true)

	SetTrackingId(25)

	
	open_narration_window()
	message("MA_01100_020002")
	
	
	message("MA_01100_020003")

	
	message("MA_01100_020004")
	close_narration_window()

	dot_disp_weapon(dotNoir3, false)

	move_camera(20, 22, 1.0)
	dot_move_unit_seq(dotNoir3, 20, 22)
	
	
	wait_seq()
	wait_camera()

	wait_time(0.5)

	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_020019")
	close_speech_window()

	dot_place_unit(dotDinatan2 ,19, 30)
	dot_move_unit_seq(dotDinatan2, 19, 22)
	
	
	wait_seq()
	wait_time(0.5)

	
	change_face(Dinatan2, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan2, nil)
	message("MA_01100_020021")
	OpenFirstAppearance(Dinatan2)
	close_speech_window()
	
	dot_unit_dir(dotNoir3, 2)

	
	change_face(Noir3, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_020022")
	close_speech_window()
	

	dot_unit_dir(dotNoir3, 3)

	
	change_face(Dinatan2, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan2, nil)
	message("MA_01100_020024")
	close_speech_window()

	dot_unit_dir(dotNoir3, 2)

	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_020025")
	close_speech_window()
	

	
	change_face(Dinatan2, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan2, nil)
	message("MA_01100_020027")
	close_speech_window()

	dot_unit_dir(dotNoir3, 2)
	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_020033")
	close_speech_window()


	
	change_face(Dinatan2, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan2, nil)
	message("MA_01100_020034")
	close_speech_window()
	

	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_020035")
	close_speech_window()

	
	change_face(Dinatan2, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan2, nil)
	message("MA_01100_020036")
	close_speech_window()

	dot_unit_dir(dotNoir3, 3)

	wait_time(1.0)
	
	move_camera(37, 16, 1.0)
	wait_camera()
	
	
	open_narration_window()
	message("MA_01100_020041")
	close_narration_window()


	bgm_play("Stop_BGM_Bus_MidFade")
	
	change_face(Dinatan2, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan2, nil)
	message("MA_01100_020042")
	close_speech_window()

	dot_place_unit(dotNoir3 ,24, 22)
	dot_place_unit(dotDinatan2 ,21, 22)
	dot_unit_dir(toho1, 3)
	dot_unit_dir(toho2, 3)
	dot_unit_dir(toho3, 3)
	dot_unit_dir(toho4, 3)
	dot_disp_weapon(dotNoir3, true)

	move_camera(23, 22, 1.0)
	wait_camera()

	bgm_play("BGM_ADV_Unnmei_to_struggle")
	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_020044")
	close_speech_window()

	dot_disp_weapon(toho1, true)
	dot_disp_weapon(toho2, true)
	dot_disp_weapon(toho3, true)
	dot_disp_weapon(toho4, true)
	
	
	change_face(Noir3, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_020046")


	
	message("MA_01100_020047")
	

	
	message("MA_01100_020048")
	close_speech_window()


	
	open_narration_window()
	message("MA_01100_020050")
	close_narration_window()

	SetTrackingId(26)

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(3,true, 12, 17,0)
	pbadv_setup_101012_Dinatan_preload(2,true, 0, 0,0)
	preload_sound("BGM_ADV_Unnmei_to_struggle")
end
