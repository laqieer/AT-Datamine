

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)



	load_image("MA011044201", "content_image_beta3_ma0110442", "MA011044201")
	
	load_image("MA01A1121901", "content_still_10103009_image", "101030090_StillImage")


	
	
	init_psbattleadv("201090000", "201090000")

	change_time_and_weather(BattleTime_Night, BattleWeather_Shiny)

	
	
	pbadv_setup_101014_Tristan(0,true, 20, 23,0)  
	
	
	pbadv_setup_101019_Isolde(1,true, 19, 23,0)  
	

	
	
	barbaroi1 = dot_reserve_enemy(1, 17, 21, 0)
	barbaroi2 = dot_reserve_enemy(1, 17, 22, 0)
	barbaroi3 = dot_reserve_enemy(1, 17, 23, 0)
	barbaroi4 = dot_reserve_enemy(1, 22, 22, 0)
	barbaroi5 = dot_reserve_enemy(1, 22, 23, 0)
	barbaroi6 = dot_reserve_enemy(1, 22, 24, 0)
	barbaroi7 = dot_reserve_enemy(1, 18, 25, 0)
	barbaroi8 = dot_reserve_enemy(1, 19, 25, 0)
	barbaroi9 = dot_reserve_enemy(1, 20, 25, 0)
	
	barbaroi10 = dot_reserve_enemy(1, 16, 21, 0)
	barbaroi11 = dot_reserve_enemy(1, 16, 22, 0)
	barbaroi12 = dot_reserve_enemy(1, 16, 23, 0)
	barbaroi13 = dot_reserve_enemy(1, 23, 22, 0)
	barbaroi14 = dot_reserve_enemy(1, 23, 23, 0)
	barbaroi15 = dot_reserve_enemy(1, 23, 24, 0)
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotIsolde1, 2)
	dot_unit_dir(barbaroi1, 3)
	dot_unit_dir(barbaroi2, 3)
	dot_unit_dir(barbaroi3, 3)

	dot_unit_dir(barbaroi10, 3)
	dot_unit_dir(barbaroi11, 3)
	dot_unit_dir(barbaroi12, 3)
	
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(25.0, 0.0)
	
	
	move_camera(20, 23, 0.0)
end






function Play()
	show_image("MA01A1121901", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
	fadein(0)
	Play_start(true)


	
	open_simple_window("CHRNAME_ISOLDE2", nil, nil)
	message("MA_01A112_190002")
	close_simple_window()
	
	
	open_simple_window("CHRNAME_TRISTAN", nil, nil)
	message("MA_01A112_190003")
	close_simple_window()
	
	
	open_simple_window("CHRNAME_ISOLDE2", nil, nil)
	message("MA_01A112_190004")
	close_simple_window()
	
	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
	
	
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01A112_190005")
	close_speech_window()

	
	wait_time(1.0)

	dot_attack_seq(dotIsolde1, barbaroi2)			
	dot_damage_seq(barbaroi2, dotIsolde1, false)	
	wait_seq()
	dot_change_anim(barbaroi2,6)
	dot_damage_seq(barbaroi1, dotIsolde1, false)	
	wait_seq()
	dot_change_anim(barbaroi1,6)
	dot_damage_seq(barbaroi3, dotIsolde1, false)	
	wait_seq()
	dot_change_anim(barbaroi3,6)

	dot_attack_seq(dotTristan, barbaroi5)			
	dot_damage_seq(barbaroi5, dotTristan, false)	
	wait_seq()
	dot_change_anim(barbaroi5,6)
	dot_damage_seq(barbaroi4, dotTristan, false)	
	wait_seq()
	dot_change_anim(barbaroi4,6)
	dot_damage_seq(barbaroi6, dotTristan, false)	
	wait_seq()
	dot_change_anim(barbaroi6,6)


	dot_change_anim(dotIsolde1, DotAnim_Idle)		
	dot_change_anim(dotTristan, DotAnim_Idle)


	wait_time(0.2)

	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",2,true)
	
	wait_time(0.5)

	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)

	dot_remove_unit(barbaroi1) 
	dot_remove_unit(barbaroi2) 
	dot_remove_unit(barbaroi3) 
	dot_remove_unit(barbaroi4) 
	dot_remove_unit(barbaroi5) 
	dot_remove_unit(barbaroi6) 

	wait_time(1.5)

	dot_reserve_move_unit_seq(barbaroi10, 17, 21)
	dot_reserve_move_unit_seq(barbaroi11, 17, 22)
	dot_reserve_move_unit_seq(barbaroi12, 17, 23)
	dot_reserve_move_unit_seq(barbaroi13, 22, 22)
	dot_reserve_move_unit_seq(barbaroi14, 22, 23)
	dot_reserve_move_unit_seq(barbaroi15, 22, 24)

	
	exec_parallel_seq()

	
	wait_seq()

	move_camera(20, 23, 1.0)
	wait_camera()
	
	
	change_face(Isolde1, "Normal")
	open_speech_window("CHRNAME_ISOLDE2", Isolde1, nil)
	message("MA_01A112_190006")
	close_speech_window()


	
	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01A112_190007")

	
	change_face(Tristan, "Normal")
	message("MA_01A112_190008")
	
	
	change_face(Tristan, "Normal")
	message("MA_01A112_190009")
	close_speech_window()

	
	change_face(Isolde1, "Sad")
	open_speech_window("CHRNAME_ISOLDE2", Isolde1, nil)
	message("MA_01A112_190010")
	close_speech_window()
	
	
	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01A112_190011")
	
	
	change_face(Tristan, "Normal")
	message("MA_01A112_190012")
	close_speech_window()
	
	
	change_face(Isolde1, "Normal")
	open_speech_window("CHRNAME_ISOLDE2", Isolde1, nil)
	message("MA_01A112_190013")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("MA011044201", "content_image_beta3_ma0110442", "MA011044201")
	load_image_preload("MA01A1121901", "content_still_10103009_image", "101030090_StillImage")
	pbadv_setup_101014_Tristan_preload(0,true, 20, 23,0)
	pbadv_setup_101019_Isolde_preload(1,true, 19, 23,0)
end
