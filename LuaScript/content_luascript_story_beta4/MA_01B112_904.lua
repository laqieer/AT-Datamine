

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101015_Arthur(0,true,25, 35,0)   
	pbadv_setup_101009_Noir(2,true, 23, 34,0)  
	pbadv_setup_101010_Lancelot(1,true, 22, 35,0)  

	barbaroi1 = dot_reserve_enemy(1104, 28, 34, 0)
	barbaroi2 = dot_reserve_enemy(603, 27, 35, 0)
	barbaroi3 = dot_reserve_enemy(1104, 28, 36, 0)
		
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotLancelot1, 3)
	dot_unit_dir(dotArthur, 2)

	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)	
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot1, false)
	dot_disp_weapon(dotArthur, false)


	
	
	Ef_baruba1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(30.0, 0.0)
	move_camera(23, 35, 0.0)

	load_sound("BGM_ADV_Antagonism")
end





function Play()
	fadein(0)
	Play_start(true)


	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー", "笑い")
	message("MA_01B112_9040002")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_9040003")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー", "肯定3")
	message("MA_01B112_9040004")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "照れ")
	message("MA_01B112_9040005")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B112_9040007")
	
	change_face(Arthur, "Normal")
	message("MA_01B112_9040008")
	
	change_face(Arthur, "Normal")
	message("MA_01B112_9040009")
	
	change_face(Arthur, "Normal")
	 --PlayPartVoice("アーサー", "落胆")
	message("MA_01B112_9040010")
	close_speech_window()

	bgm_play("BGM_ADV_Antagonism")
	
	
	move_camera(27, 35, 0.5)
	wait_camera()
	
	
	on_active(Ef_baruba1) 
	local gridpos = get_grid_position(28, 34) 
	set_pos(Ef_baruba1, gridpos)
	set_scale(Ef_baruba1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_baruba1)


	on_active(Ef_baruba2) 
	local gridpos = get_grid_position(27, 35) 
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_baruba2)


	on_active(Ef_baruba3) 
	local gridpos = get_grid_position(28, 36) 
	set_pos(Ef_baruba3, gridpos)
	set_scale(Ef_baruba3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_baruba3)

	wait_time(0.2)
        
	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	
	dot_unit_dir(dotArthur, 3)

	wait_time(1.5)

	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotLancelot1, true)
	dot_disp_weapon(dotArthur, true)

	wait_time(0.5)
	
	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー", "悩む")
	message("MA_01B112_9040013")
	
	
	change_face(Arthur, "Normal")
	message("MA_01B112_9040014")
	close_speech_window()
	
	
	dot_move_unit_seq(barbaroi2, 26, 35)	
	
	
	dot_attack_seq(barbaroi2, dotArthur)
	dot_damage_seq(dotArthur, barbaroi2, true)
	
	wait_seq()	

	dot_move_knockback(dotArthur,24,35,0.2,2)

	move_camera(25, 35, 0.2)
	wait_camera()
	
	dot_change_anim(barbaroi2,0)
	dot_change_anim(dotArthur,1)
	se_play("SE_ADV_MA_01104_25_Fall")
	wait_time(1.5)
	
	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー", "苦しみ")
	message("MA_01B112_9040016")
	close_speech_window()

	
	
	

	dot_reserve_move_unit_seq(dotNoir2, 25, 34)
	dot_reserve_move_unit_seq(dotLancelot1, 25, 36)
	
	
	exec_parallel_seq()

	
	wait_seq()
	
	
	change_face(Lancelot1, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	 --PlayPartVoice("ランスロット", "否定")
	message("MA_01B112_9040017")
	close_speech_window()

	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー", "悲しみ")
	message("MA_01B112_9040018")
	
	change_face(Arthur, "Pain")
	message("MA_01B112_9040019")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "肯定2")
	message("MA_01B112_9040020")
	close_speech_window()
	

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101015_Arthur_preload(0,true,25, 35,0)
	pbadv_setup_101009_Noir_preload(2,true, 23, 34,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 22, 35,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	preload_sound("BGM_ADV_Antagonism")
end
