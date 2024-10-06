

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	init_psbattleadv("201060001", "201060001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	
	pbadv_setup_101028_Galahad(1,true, 14, 20,0)  
	pbadv_setup_101034_Excelia(1,true, 25, 20,0)  
	
		
	
	
	
	barbaroi1 = dot_reserve_enemy(600, 21, 18, 0)
	barbaroi2 = dot_reserve_enemy(600, 21, 21, 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotExcelia1, 2)

	
	
	dot_disp_weapon(dotGalahad1, false)

	
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(dotExcelia1, false)

	
	
	
	
	change_camera_distance(6.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(19, 20, 0.0)

	
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
	load_image("10202006",  "content_still_10202006_image", "102020060_StillImage")
	show_image("10202006", 0.0, 0.0, 0 ,true,false)		

	load_sound("BGM_ADV_Reconnaissance")

end





function Play()
	fadein(0)
	Play_start(true)

	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)	
	
	
	
	
	
	
	dot_move_unit_seq(dotGalahad1, 19, 20)
	
	wait_seq()

	
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	 --PlayPartVoice("エクセリア","落胆")
	message("MA_01B110_160002")
	close_speech_window()

	bgm_play("BGM_ADV_Reconnaissance")
	
	
	dot_unit_dir(dotGalahad1, 3)
	wait_time(0.2)
	dot_unit_dir(dotGalahad1, 2)
	wait_time(0.2)
	dot_unit_dir(dotGalahad1, 3)

	wait_time(1.0)

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド","怒り")
	message("MA_01B110_160004")
	close_speech_window()
	
	
	
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2", nil, Excelia1)
	 --PlayPartVoice("エクセリア","挨拶")
	message("MA_01B110_160006")
	close_speech_window()
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_160007")
	close_speech_window()
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2", nil, Excelia1)
	 --PlayPartVoice("エクセリア","納得")
	message("MA_01B110_160008")
	
	
	
	change_face(Excelia1, "Normal")
	
	message("MA_01B110_160009")
	
	
	
	
	change_face(Excelia1, "Normal")
	
	message("MA_01B110_160010")
	
	
	
	change_face(Excelia1, "Normal")
	
	message("MA_01B110_160012")
	close_speech_window()

			
	
	dot_disp_unit(dotExcelia1, true)
	dot_move_unit_seq(dotExcelia1, 22, 20)
	
	move_camera(20, 20, 2.0)
	change_camera_distance(8.0, 2.0)

	wait_seq()
	wait_camera()
	
	
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2", nil, Excelia1)
	 --PlayPartVoice("エクセリア","否定")
	message("MA_01B110_160014")
	close_speech_window()

	
	on_active(Ef_bar1) 
	on_active(Ef_bar2) 

	local gridpos = get_grid_position(21, 19)
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8})
	play_particle(Ef_bar1)

	local gridpos = get_grid_position(21, 21)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)


	wait_time(0.2)

	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)

	wait_time(2.0)


	
	change_face(Excelia1, "Anger")
	open_speech_window("CHRNAME_EXCELIA2", nil, Excelia1)
	message("MA_01B110_160016")
	close_speech_window()				
					
					

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101028_Galahad_preload(1,true, 14, 20,0)
	pbadv_setup_101034_Excelia_preload(1,true, 25, 20,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_image_preload("10202006",  "content_still_10202006_image", "102020060_StillImage")
	preload_sound("BGM_ADV_Reconnaissance")
end
