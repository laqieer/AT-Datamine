

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)

	
	init_psbattleadv("201200000", "201200000")

	change_time_and_weather(BattleTime_Day, BattleWeather_Snowstorm)


	pbadv_setup_101009_Noir(2,true, 27, 4,0)  
	pbadv_setup_101010_Lancelot(1,true, 27, 5,0)  
	pbadv_setup_101028_Galahad(1,true, 29, 4,0)  
	pbadv_setup_101036_Viena(1,true, 29, 5,0)  
	pbadv_setup_101026_Percival(0,true, 0, 0,0)  
	pbadv_setup_101027_Dindrane(2,true, 1, 0,0)  

	dotGalahad3 = dot_reserve_ally(101028004, 40, 1, 0)
	dot_set_weapon(dotGalahad3, 101010001)		
	
	
	setup_complete_unit()
	

	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot1, false)
	dot_disp_weapon(dotGalahad1, false)

	dot_disp_weapon(dotViena1, false)
	dot_disp_weapon(dotPercival, false)
	dot_disp_weapon(dotDindrane2, false)
	
	
	dot_disp_unit(dotGalahad3, false)
	dot_disp_unit(dotPercival, false)
	dot_disp_unit(dotDindrane2, false)
	
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(25.0, 0.0)
	
	
	move_camera(28, 5, 0.0)
	
	
	Ef_Light = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Sunbeams_Lop", false, true)


	Ef_Holy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", false, true)
	
	Ef_Holy1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_Appearance", false, true)
	Ef_Holy2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)

	Ef_Holy3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_OminousLight", false, true)


	movie_load("MA_01B111_24")
	load_sound("SE_ADV_Movie")

	load_sound("BGM_ADV_Tragedy")

end

function Play()
	fadein(0)
	Play_start(true)

	
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_240002")
	close_speech_window()


	dot_reserve_move_unit_seq(dotGalahad1, 37, 3)
	dot_reserve_move_unit_seq(dotViena1, 38, 3)
	dot_reserve_move_unit_seq(dotNoir2, 37, 4)
	dot_reserve_move_unit_seq(dotLancelot1, 38, 4)
	
	
	exec_parallel_seq()

	move_camera(37, 3, 1.0)
	wait_camera()

	
	wait_seq()

	
	change_face(Viena1, "Surprise")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B111_240003")
	close_speech_window()

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_240004")
	close_speech_window()

	
	change_face(Viena1, "Normal")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B111_240005")
	close_speech_window()


	on_active(Ef_Holy2)

	local gridpos = get_grid_position(39, 1)
	gridpos[2] = 5.5
	set_pos(Ef_Holy2, gridpos)
	play_particle(Ef_Holy2)


	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_240007")
	close_speech_window()

	
	
	change_face(Lancelot1, "Serious")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_240008")
	
	
	MA_01B111_24_select1()

	
	

	open_select_window_tag(Noir2, "Normal", "MA_01B111_240009", "MA_01B111_240010")	
	close_speech_window()

	if is_select(1) then			
		MA_01B111_24_select1_1()

	else							
		MA_01B111_24_select1_2()

	end
	MA_01B111_24_end()

end

function MA_01B111_24_select1()

end

function MA_01B111_24_select1_1()

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_240012")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_240013")

	
	change_face(Lancelot1, "Normal")
	message("MA_01B111_240014")
	close_speech_window()


end


function MA_01B111_24_select1_2()

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_240016")
	close_speech_window()

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_240017")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_240018")
	close_speech_window()


end


function MA_01B111_24_end()
	
	
	dot_disp_unit(dotPercival, true)
	dot_disp_unit(dotDindrane2, true)

	dot_place_unit(dotPercival,31,4)
	dot_place_unit(dotDindrane2,30,4)

	wait_time(0.5)


	
	dot_reserve_move_unit_seq(dotPercival, 34, 5)
	dot_reserve_move_unit_seq(dotDindrane2, 33, 5)
	exec_parallel_seq()
	wait_seq()
	
	dot_reserve_move_unit_seq(dotPercival, 36, 5)
	dot_reserve_move_unit_seq(dotDindrane2, 35, 5)
	exec_parallel_seq()
	
	wait_seq()
	
	dot_reserve_move_unit_seq(dotPercival, 38, 5)
	dot_reserve_move_unit_seq(dotDindrane2, 37, 5)
	exec_parallel_seq()
	
	wait_seq()
	
	change_camera_angle(40.0, 1.0)
	move_camera(37, 4, 1.0)
	wait_camera()

	
	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_240020")
	close_speech_window()


	
	change_face(Dindrane2, "Normal")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_240021")
	close_speech_window()

	
	change_face(Percival, "Sad")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_240022")

	
	change_face(Percival, "Anger")
	message("MA_01B111_240023")

	
	change_face(Percival, "Sad")
	message("MA_01B111_240024")
	close_speech_window()


	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B111_240026")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_240027")
	close_speech_window()

	
	dot_move_unit_seq(dotViena1, 39, 2)
	
	
	wait_seq()

	dot_unit_dir(dotViena1, 2)


	
	change_face(Viena1, "Normal")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B111_240029")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_240030")
	close_speech_window()

	
	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B111_240031")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_240032")
	close_speech_window()

	
	change_face(Viena1, "Normal")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B111_240033")
	close_speech_window()

	
	change_face(Lancelot1, "Surprise")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_240034")
	close_speech_window()

	
	change_face(Viena1, "Normal")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B111_240035")

	
	change_face(Viena1, "Sad")
	message("MA_01B111_240036")
	close_speech_window()

	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_240038")
	close_speech_window()


	movie_set_active(true)
	movie_play()



	movie_wait_playing()

	fadeout(0,0,0,1.0, 0)

	movie_stop()



	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 27, 4,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 27, 5,0)
	pbadv_setup_101028_Galahad_preload(1,true, 29, 4,0)
	pbadv_setup_101036_Viena_preload(1,true, 29, 5,0)
	pbadv_setup_101026_Percival_preload(0,true, 0, 0,0)
	pbadv_setup_101027_Dindrane_preload(2,true, 1, 0,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Sunbeams_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_OminousLight", false, true)
	movie_load_preload("MA_01B111_24")
	preload_sound("SE_ADV_Movie")
	preload_sound("BGM_ADV_Tragedy")
end
