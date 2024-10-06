

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	

	
	
	init_psbattleadv("201000000", "201000000")
	
	
	change_time_and_weather(BattleTime_Night, BattleWeather_Shiny)


    pbadv_setup_101009_Noir(2,true,5,25, 0)    
	
	
	barbaroi0 = dot_reserve_enemy(1, 9,20,0)  
	barbaroi1 = dot_reserve_enemy(49, 10,20,0)  
	barbaroi2 = dot_reserve_enemy(42, 8,19,0)  
	barbaroi3 = dot_reserve_enemy(1200, 11,19,0)  
	merchant = dot_reserve_ally(401011001, 4,25, 0)
	dot_set_weapon(merchant, 104010001)


	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotNoir2, 0)
	dot_unit_dir(merchant, 0)
	dot_unit_dir(barbaroi1, 2)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 2)
	dot_unit_dir(barbaroi0, 2)

	
	
	dot_disp_weapon(merchant, false)



	dot_change_anim(dotNoir2,2) 
	dot_change_anim(merchant,2) 


	
	
	
	dot_disp_unit(barbaroi0, false)
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	
	
	
	
	Ef_0 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_1= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_2= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_3= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_changeBriF = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_changeBriF2 = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)


	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(34.0, 0.0)

	
	
	move_camera(8,27, 0.0)
	move_camera(8,21, 3.0)
	
	
	dot_reserve_move_unit_seq(dotNoir2,9, 22) 
	dot_reserve_move_unit_seq(merchant,8, 22) 
		exec_parallel_seq() 

	load_sound("BGM_ADV_Invasion2")

end





function Play()
	fadein(0)
	Play_start(true)



		wait_seq()
		

	dot_unit_dir(dotNoir2, 0)
	dot_unit_dir(merchant, 0)


	dot_change_anim(dotNoir2,0) 
	dot_change_anim(merchant,0) 

	wait_time(1.3)


	dot_unit_dir(merchant, 3)

	open_speech_window("NPCNAME_0307", nil, nil)
		message("MA_01105_9020002") 
	close_speech_window()


	dot_unit_dir(dotNoir2, 2)

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01105_9020003") 
	close_speech_window()

	open_speech_window("NPCNAME_0307", nil, nil)
		message("MA_01105_9020004") 
		message("MA_01105_9020005") 
	close_speech_window()


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01105_9020006") 
	close_speech_window()

	open_speech_window("NPCNAME_0307", nil, nil)
		message("MA_01105_9020007") 
		message("MA_01105_9020008") 
		message("MA_01105_9020009") 
	close_speech_window()

	bgm_play("BGM_ADV_Invasion2")

 

	on_active(Ef_0)
	local gridpos = get_grid_position(9, 20) 
	set_pos(Ef_0, gridpos)
	set_scale(Ef_0, {0.8, 0.8, 0.8})
	play_particle(Ef_0)
	
	dot_disp_unit(barbaroi0,true) 

	on_active(Ef_1)
	local gridpos = get_grid_position(10, 20) 
	set_pos(Ef_1, gridpos)
	set_scale(Ef_1, {0.8, 0.8, 0.8})
	play_particle(Ef_1)
	
	dot_disp_unit(barbaroi1,true) 

	on_active(Ef_2)
	local gridpos = get_grid_position(8, 19) 
	set_pos(Ef_2, gridpos)
	set_scale(Ef_2, {0.8, 0.8, 0.8})
	play_particle(Ef_2)
	
	dot_disp_unit(barbaroi2,true) 

	on_active(Ef_3)
	local gridpos = get_grid_position(11, 19) 
	set_pos(Ef_3, gridpos)
	set_scale(Ef_3, {0.8, 0.8, 0.8})
	play_particle(Ef_3)
	
	dot_disp_unit(barbaroi3,true) 

	wait_time(1.9)
	

	
	

	dot_disp_unit(barbaroi3,true) 



	















	open_speech_window("NPCNAME_0307", nil, nil)
		message("MA_01105_9020010") 
		message("MA_01105_9020011") 
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,5,25, 0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	preload_sound("BGM_ADV_Invasion2")
end
