
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")




function Load()
	Load_common(true)

	
	
	
	setup_101009_Noir(nil, nil, 2, false)
	setup_101011_Guinevere(nil, nil, 0, false)
	setup_101016_Gwenhwymawr(nil, nil, 0, false)
	
	
	
	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(BattleTime_Sunset,BattleWeather_Shiny)

	
	load_image("10301028", "content_still_10301028_image", "103010280_StillImage")

	
	movie_load("MA_01104_15")
	

	
	pbadv_setup_101009_Noir(2,true, 14, 14,0)  
	
	
	
	
	
	dotguine = dot_reserve_ally(101011001, 15, 14, 0)
	dot_set_weapon(dotguine, 104010001)		

	
	dotgwenh = dot_reserve_ally(101016001, 16, 13, 0)
	dot_set_weapon(dotgwenh, 108010001)		

	pbadv_setup_101016_Gwenhwymawr(1,true, 0, 0,0)  
	
	
	
	barbaroi = dot_reserve_enemy(1, 18, 14, 0)
	barbaroi2 = dot_reserve_enemy(1, 18, 13, 0)
	barbaroi3 = dot_reserve_enemy(1, 18, 15, 0)
	barbaroi4 = dot_reserve_enemy(1, 17, 13, 0)
	barbaroi5 = dot_reserve_enemy(1, 17, 15, 0)
	
	
	setup_complete_unit()
	
	

	dot_unit_dir(dotguine, 2)
	dot_unit_dir(dotgwenh, 2)
	
	
	dot_disp_weapon(dotguine, false)
	dot_disp_weapon(dotgwenh, false)
	dot_disp_weapon(dotNoir2, false)
	
	
	
	dot_disp_unit(barbaroi, false)
	dot_disp_unit(dotGwenhwymawr1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi5, false)
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(15, 14, 0.0)

	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_Emblem = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	load_sound("BGM_ADV_Invasion2")
	load_sound("BGM_Battle_Running")

	se_play("SE_ambient_wind_meadow_Loop")
end





function Play()
	fadein(0)
	Play_start(true)


	
	change_face(Guinevere, "Normal")

	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_140002")
	

	message("MA_01104_140004")
	close_speech_window()

	
	dot_unit_dir(dotgwenh, 3)
	dot_disp_weapon(dotgwenh, true)

	bgm_play("BGM_ADV_Invasion2")
	
	change_face(Gwenhwymawr, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_140005")
	close_speech_window()


	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_140006")
	close_speech_window()

	
	dot_unit_dir(dotguine, 3)

	dot_move_unit_seq(dotgwenh, 16, 14)
	wait_seq()


	
	
	
	
	change_face(Gwenhwymawr, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_150002")
	close_speech_window()


	
	on_active(Ef_bar1) 

	local gridpos = get_grid_position(18, 14) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)

	on_active(Ef_bar2) 

	local gridpos = get_grid_position(18, 13) 
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar2)
	
	on_active(Ef_bar3) 

	local gridpos = get_grid_position(18, 15) 
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar3)
	
	on_active(Ef_bar4) 

	local gridpos = get_grid_position(17, 13) 
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar4)
	
	on_active(Ef_bar5) 

	local gridpos = get_grid_position(17, 15) 
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar5)
	
	wait_time(0.2)
	
	
	dot_disp_unit(barbaroi, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)
	dot_disp_unit(barbaroi5, true)

	dot_move_unit_seq(barbaroi, 17, 14)
	
	wait_seq()

	
	
	

	wait_time(2.0)
	
	
	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_150004")


	
	change_face(Guinevere, "Normal")
	message("MA_01104_150005")
	close_speech_window()


	
	on_active(Ef_Emblem)

	local locatorpos = dot_get_unit_locator(dotguine,1)
	set_pos(Ef_Emblem, locatorpos)

	play_particle(Ef_Emblem)

	wait_time(2.0)

	on_active(Ef_Vibes)

	local gridpos = get_grid_position(15, 14)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)


	
	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_150007")
	close_speech_window()

	bgm_play("BGM_Battle_Running")

	off_active(Ef_Vibes)
	off_active(Ef_Emblem)

	off_active(Ef_bar1)
	off_active(Ef_bar2)
	off_active(Ef_bar3)
	off_active(Ef_bar4)
	off_active(Ef_bar5)

	
	movie_set_active(true)

	movie_play()
	
	

	
	stop_particle(Ef_Vibes)
	dot_disp_unit(dotGwenhwymawr1, true)
	dot_change_unit(dotgwenh,dotGwenhwymawr1,0)
	dot_remove_unit(barbaroi)

	
	dot_place_unit(dotGwenhwymawr1,17,14)
	dot_unit_dir(dotGwenhwymawr1, 2)
	dot_place_unit(barbaroi4,16,13)
	dot_place_unit(barbaroi5,16,15)
	dot_unit_dir(barbaroi4, 3)
	dot_unit_dir(barbaroi5, 3)

	movie_wait_playing()

	movie_stop()
	wait_time(BLACK_WHITE_WAIT_TIME)

	
	

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_150019")
	close_speech_window()

	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_150021")

	
	
	message("MA_01104_150022")

	
	
	
	message("MA_01104_150024")
	close_speech_window()

	
	change_face(Gwenhwymawr1, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01104_150025")
	close_speech_window()

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	
	on_cameraframe(2)
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("10301028", 0.0, 0.0, 0.0)
	
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)


	
	
	
	open_simple_window("CHRNAME_ARTHUR", nil, nil)
	message("MA_01104_150027")
	close_simple_window()

	

	
	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)

	
	hide_image()

	
	off_cameraframe()
	off_screencolor()
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_150028")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_150029")

	
	
	
	
	message("MA_01104_150031")
	close_speech_window()

	se_play("SE_LoopSE_Stop")

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup_101009_Noir_preload(nil, nil, 2, false)
	setup_101011_Guinevere_preload(nil, nil, 0, false)
	setup_101016_Gwenhwymawr_preload(nil, nil, 0, false)
	load_image_preload("10301028", "content_still_10301028_image", "103010280_StillImage")
	movie_load_preload("MA_01104_15")
	pbadv_setup_101009_Noir_preload(2,true, 14, 14,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 0, 0,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	preload_sound("BGM_ADV_Invasion2")
	preload_sound("BGM_Battle_Running")
end
