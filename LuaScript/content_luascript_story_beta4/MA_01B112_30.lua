

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)


	
	init_psbattleadv("201120100", "201120100")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)


	
	pbadv_setup_101009_Noir(2,true, 10, 4,0)  
	pbadv_setup_101010_Lancelot(1,true, 11, 5,0)  
	pbadv_setup_101015_Arthur(0,true, 9, 4,0)  
	pbadv_setup_101028_Galahad(1,true, 10, 3,0)  
	pbadv_setup_101036_Viena(1,true, 11, 2,0)  
	

	
	pbadv_setup_101056_Perez(1,true, 15, 4,0)  
	pbadv_setup_101053_Mathajim(2,true, 16, 1,0)  
	pbadv_setup_101054_Adam(2,true, 16, 3,0)  
	pbadv_setup_101055_Owen(2,true, 16, 5,0)  
	
	barbaroi1 = dot_reserve_enemy(49, 14, 2, 0)
	barbaroi2 = dot_reserve_enemy(49, 14, 5, 0)
	barbaroi3 = dot_reserve_enemy(1, 13, 3, 0)
	barbaroi4 = dot_reserve_enemy(1, 13, 4, 0)

	
	
	
	setup_complete_unit()


	
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotMathajim2, 2)
	dot_unit_dir(dotAdam2, 2)
	dot_unit_dir(dotOwen2, 2)


	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot1, false)
	dot_disp_weapon(dotGalahad1, false)
	dot_disp_weapon(dotViena1, false)
	dot_disp_weapon(dotArthur, false)
	
	dot_disp_weapon(dotMathajim2, false)
	dot_disp_weapon(dotAdam2, false)
	dot_disp_weapon(dotOwen2, false)

	
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(12, 5, 0.0)
	
	
	Enemy_spout = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_bar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)


end




function Play()
	fadein(0)
	Play_start(true)



	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B112_300002")
	close_speech_window()


	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_300003")
	close_speech_window()


	change_face(Arthur, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B112_300004")
	close_speech_window()


	wait_time(0.5)


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_300006")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_300007")
	close_speech_window()


	change_face(Arthur, "Surprise")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B112_300008")
	close_speech_window()


	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_300009")
	close_speech_window()


	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B112_300010")
	close_speech_window()

	se_play("SE_ADV_MA_01B112_32_Armor_Move")

	dot_disp_weapon(dotMathajim2, true)
	dot_disp_weapon(dotAdam2, true)
	dot_disp_weapon(dotOwen2, true)
	
	wait_time(0.5)


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_300012")
	close_speech_window()


	

	local gridpos = get_grid_position(15, 4)
	set_pos(Enemy_spout, gridpos)
	on_active(Enemy_spout)	

	play_particle(Enemy_spout)
	
	wait_time(0.5)


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_300014")
	close_speech_window()

	stop_particle(Enemy_spout)




	move_camera(14, 4, 1.5)
	change_camera_distance(6.0, 1.5)

	on_active(Ef_bar)
	

	local gridpos = get_grid_position(13, 4)
	set_pos(Ef_bar, gridpos)
	set_scale(Ef_bar, {0.8, 0.8, 0.8})
	play_particle(Ef_bar)

	on_active(Ef_bar2)

	local gridpos = get_grid_position(13, 3)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	on_active(Ef_bar3)

	local gridpos = get_grid_position(14, 5)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	on_active(Ef_bar4)

	local gridpos = get_grid_position(14, 2)
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8})
	play_particle(Ef_bar4)


	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)
	
	wait_time(1.5)
	

	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_300016")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 10, 4,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 11, 5,0)
	pbadv_setup_101015_Arthur_preload(0,true, 9, 4,0)
	pbadv_setup_101028_Galahad_preload(1,true, 10, 3,0)
	pbadv_setup_101036_Viena_preload(1,true, 11, 2,0)
	pbadv_setup_101056_Perez_preload(1,true, 15, 4,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 16, 1,0)
	pbadv_setup_101054_Adam_preload(2,true, 16, 3,0)
	pbadv_setup_101055_Owen_preload(2,true, 16, 5,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
end
