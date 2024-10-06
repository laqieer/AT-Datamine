

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	init_psbattleadv("201080100", "201080100")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)
	
	
	pbadv_setup_101009_Noir(2,true, 11, 4,0)  
	pbadv_setup_101011_Guinevere(0,true, 15, 4,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 15, 2,0)  
	pbadv_setup_101012_Dinatan(1,true, 11, 2,0)  
	pbadv_setup_101017_Maladisant(1,true, 11, 0,0)  
	
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotGwenhwymawr1, 2)
	dot_unit_dir(dotGuinevere, 2)
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotDinatan1, false)
	dot_disp_weapon(dotMaladisant1, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr1, true)
	
	
	dot_change_anim(dotGwenhwymawr1, 1)

	change_camera_distance(8.0, 0.0)
	
	change_camera_angle(25.0, 0.0)
	
	move_camera(13, 4, 0.0)

	load_image("10104018",  "content_still_10104018_image", "101040180_StillImage")

	
end

function Play()
	fadein(0)
	Play_start(true)

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290002")

	
	message("MA_01C201_290003")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_290005")
	close_speech_window()
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290006")

	
	change_face(Guinevere, "Anger")
	message("MA_01C201_290008")

	
	message("MA_01C201_290009")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_290010")
	
	
	change_face(Noir2, "Serious")
	message("MA_01C201_290012")
	close_speech_window()

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290013")
	close_speech_window()
	
	
	change_face(Maladisant1, "Normal")
	open_speech_window("CHRNAME_MALADISANT2", Maladisant1, nil)
	message("MA_01C201_290014")

	
	message("MA_01C201_290015")


	
	message("MA_01C201_290016")


	
	change_face(Maladisant1, "Anger")
	message("MA_01C201_290017")
	
	
	message("MA_01C201_290018")
	close_speech_window()
	

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290019")


	
	change_face(Guinevere, "Pain")
	message("MA_01C201_290020")


	
	message("MA_01C201_290021")


	
	message("MA_01C201_290022")
	close_speech_window()


	
	change_face(Gwenhwymawr1, "Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR2", nil, Gwenhwymawr1)
	message("MA_01C201_290023")
	close_speech_window()



	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290024")


	
	message("MA_01C201_290025")

	
	message("MA_01C201_290026")
	close_speech_window()


	
	change_face(Maladisant1, "Normal")
	open_speech_window("CHRNAME_MALADISANT2", Maladisant1, nil)
	message("MA_01C201_290027")
	close_speech_window()
	


	dot_move_unit_seq(dotGuinevere, 14, 4)
	wait_seq()


	dot_disp_weapon(dotGuinevere, true)


	change_face(Guinevere, "Pain")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290028")
	


	move_camera(11, 3, 1.0)
	change_camera_distance(6.0, 1.0)



	dot_reserve_move_unit_seq(dotNoir2, 10, 4)
	dot_reserve_move_unit_seq(dotGuinevere, 12, 4)
	dot_reserve_move_unit_seq(dotDinatan1, 11, 4)
	exec_parallel_seq()
	wait_seq()



	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotDinatan1, 3)



	dot_disp_weapon(dotGuinevere, true)
	dot_disp_weapon(dotDinatan1, true)
	


	dot_change_anim(dotGuinevere, 3)
	dot_change_anim(dotDinatan1, 3)


	change_face(Guinevere, "Anger")
	
	message("MA_01C201_290030")
	close_speech_window()


	change_face(Dinatan1, "Anger")
	open_speech_window("CHRNAME_DINATAN2", Dinatan1, nil)
	message("MA_01C201_290031")
	close_speech_window()



	dot_attack_seq(dotDinatan1,dotGuinevere)
	dot_damage_seq(dotGuinevere,dotDinatan1,false)

	wait_seq()
	dot_change_anim(dotGuinevere, 6)


	change_face(Guinevere, "Pain")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290033")
	close_speech_window()



	dot_change_anim(dotDinatan1, 0)
	dot_change_anim(dotGuinevere, 0)


	change_face(Dinatan1, "Anger")
	open_speech_window("CHRNAME_DINATAN2", Dinatan1, nil)
	message("MA_01C201_290034")
	close_speech_window()


	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290035")
	close_speech_window()





	change_face(Dinatan1, "Surprise")
	open_speech_window("CHRNAME_DINATAN2", Dinatan1, nil)
	message("MA_01C201_290036")
	close_speech_window()


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_290037")
	close_speech_window()


	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2", Dinatan1, nil)
	message("MA_01C201_290038")
	


	change_face(Dinatan1, "Sad")
	
	message("MA_01C201_290039")
	


	change_face(Dinatan1, "Sad")
	message("MA_01C201_290040")
	close_speech_window()


	dot_change_anim(dotDinatan1, 1)


	change_face(Maladisant1, "Normal")
	open_speech_window("CHRNAME_MALADISANT2", Maladisant1, nil)
	message("MA_01C201_290042")
	close_speech_window()


	dot_move_unit_seq(dotMaladisant1, 11, 2)
	wait_seq()
	wait_time(2.0)


	dot_disp_weapon(dotGuinevere, false)


	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290044")
	


	move_camera(13, 4, 2.0)


	dot_move_unit_seq(dotGuinevere, 13, 4)
	wait_seq()
	dot_unit_dir(dotGuinevere, 3)
	wait_time(2.0)


	change_face(Guinevere, "Sad")
	message("MA_01C201_290045")
	close_speech_window()


	dot_change_anim(dotGuinevere, 1)
	wait_time(0.8)


	dot_move_unit_seq(dotNoir2, 12, 5)
	wait_seq()


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_290047")
	close_speech_window()


	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290048")


	change_face(Guinevere, "Sad")
	message("MA_01C201_290049")


	dot_unit_dir(dotGuinevere, 2)


	change_face(Guinevere, "Normal")
	message("MA_01C201_290050")


	change_face(Guinevere, "Normal")
	message("MA_01C201_290051")


	change_face(Guinevere, "Sad")
	message("MA_01C201_290052")



	change_face(Guinevere, "Sad")
	message("MA_01C201_290054")
	close_speech_window()

	dot_disp_weapon(dotDinatan1, false)

	dot_move_unit_seq(dotDinatan1, 12, 3)
	wait_seq()


	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2", Dinatan1, nil)
	message("MA_01C201_290055")
	close_speech_window()


	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290056")


	change_face(Guinevere, "Sad")
	message("MA_01C201_290057")




	change_face(Guinevere, "Normal")
	message("MA_01C201_290059")


	change_face(Guinevere, "Normal")
	message("MA_01C201_290060")
	close_speech_window()


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_290061")
	close_speech_window()


	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_290062")


	change_face(Guinevere, "Smile")
	message("MA_01C201_290063")


	change_face(Guinevere, "Smile")
	message("MA_01C201_290064")


	change_face(Guinevere, "Smile")
	message("MA_01C201_290065")
	close_speech_window()


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_290066")
	close_speech_window()

	dot_reserve_move_unit_seq(dotDinatan1, 13, 3)
	dot_reserve_move_unit_seq(dotNoir2, 13, 5)
	
	exec_parallel_seq()

	show_image("10104018", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)

	wait_time(0.5)

	se_play("SE_ADV_MA_01C112_21_Spear_Drop")
	wait_time(1.0)
	
	fadeout(0,0,0, 1, 1.5)
	wait_time(1.5)

	wait_seq()

	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 11, 4,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 15, 4,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 15, 2,0)
	pbadv_setup_101012_Dinatan_preload(1,true, 11, 2,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 11, 0,0)
	load_image_preload("10104018",  "content_still_10104018_image", "101040180_StillImage")
end
