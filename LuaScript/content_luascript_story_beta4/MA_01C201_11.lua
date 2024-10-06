

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	
	setup_101009_Noir(nil, nil, 0, false)

	
	
	init_psbattleadv("201080100", "201080100")
	change_time_and_weather(1,1) 
	
	
	
	
	
	
	
	
	pbadv_setup_101009_Noir(2,true, 11, 5,0)  
	pbadv_setup_101012_Dinatan(0,true, 11, 3,0)  
	pbadv_setup_101017_Maladisant(0,true, 11, 1,0)  
	pbadv_setup_101032_Gareth(0,true, 10, 4,0) 
	pbadv_setup_101033_Lyoness(0,true, 10, 2,0) 


	
	
	
	
	
	
	
	barbaroi1 = dot_reserve_enemy(202, 21, 1, 0)
	barbaroi2 = dot_reserve_enemy(506, 20, 2, 0)
	barbaroi3 = dot_reserve_enemy(1200, 21, 3, 0)
	barbaroi4 = dot_reserve_enemy(506, 20, 4, 0)
	barbaroi5 = dot_reserve_enemy(202, 21, 5, 0)
	
	
	
	setup_complete_unit()

	
	
	
	
	
	
	
	
	dot_unit_dir(barbaroi1, 2)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 2)
	dot_unit_dir(barbaroi4, 2)
	dot_unit_dir(barbaroi5, 2)


	
	
	
	
	
	
	

	
	
	
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi5, false)

	
	
	
	change_camera_distance(7.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(11, 5, 0.0)
	

	Ef_bar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
end



function Play()
	fadein(0)
	Play_start(true)






	
	

	
	
	
	
	
	
	
	
	
	
	
	
	
	





	change_face(Lyoness, "Anger")
	open_speech_window("CHRNAME_LYONESS", Lyoness, nil)
	message("MA_01C201_110002")
	close_speech_window()


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01C201_110003")
	


	change_face(Dinatan, "Sad")
	
	message("MA_01C201_110004")
	close_speech_window()


	wait_time(1.0)
	




	
	on_active(Ef_bar)
	on_active(Ef_bar2)
	on_active(Ef_bar3)
	on_active(Ef_bar4)
	on_active(Ef_bar5)
	
	
	local gridpos = get_grid_position(21, 1)
	set_pos(Ef_bar, gridpos)
	set_scale(Ef_bar, {0.8, 0.8, 0.8})
	play_particle(Ef_bar)

	local gridpos = get_grid_position(20, 2)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	local gridpos = get_grid_position(21, 3)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	local gridpos = get_grid_position(20, 4)
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8})
	play_particle(Ef_bar4)

	local gridpos = get_grid_position(21, 5)
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8})
	play_particle(Ef_bar5)






	move_camera(20, 5, 2.0)
	wait_time(1.5)
	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)
	dot_disp_unit(barbaroi5, true)
	wait_time(1.0)
	dot_reserve_move_unit_seq(barbaroi1, 14,1)
	dot_reserve_move_unit_seq(barbaroi2, 15,2)
	dot_reserve_move_unit_seq(barbaroi3, 14,3)
	dot_reserve_move_unit_seq(barbaroi4, 15,4)
	dot_reserve_move_unit_seq(barbaroi5, 14,5)
	move_camera(12, 5, 2.0)
	exec_parallel_seq()
	wait_time(2.0)


	change_face(Gareth, "Anger")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01C201_110006")
	close_speech_window()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup_101009_Noir_preload(nil, nil, 0, false)
	pbadv_setup_101009_Noir_preload(2,true, 11, 5,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 11, 3,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 11, 1,0)
	pbadv_setup_101032_Gareth_preload(0,true, 10, 4,0)
	pbadv_setup_101033_Lyoness_preload(0,true, 10, 2,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
end
