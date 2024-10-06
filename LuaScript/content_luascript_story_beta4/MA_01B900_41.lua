




Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201180000", "201180000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 21, 36,0)  
	pbadv_setup_101010_Lancelot(1,true, 24, 34,0)  
	
	pbadv_setup_101028_Galahad(2,true, 19, 34, 0)  
	
	pbadv_setup_101055_Owen(0,true, 20, 34,0)  
	pbadv_setup_101053_Mathajim(0,true, 21, 34,0)  
	pbadv_setup_101054_Adam(0,true, 22, 34,0)  
	
	pbadv_setup_101029_Astera(1,true, 19, 36,0) 
	pbadv_setup_101035_Liliana(1,true, 23, 36,0)  
	pbadv_setup_101034_Excelia(1,true, 24, 36,0)  

	pbadv_setup_101041_Morgan(1,true, 21, 31,0) 
	pbadv_setup_101015_Arthur(1,true, 24, 31,0)  
	
		
	
	
	
	

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	dot_unit_dir(dotArthur1, 2) 


	
	
	

	
	
	

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(21, 35, 0.0)

	
	Ef_EneAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_EneAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	Ef_KillAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	
	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_410001")
	

	
	change_face(Lancelot1, "Normal")
	
	message("MA_01B900_410002")
	close_speech_window()

	
	change_face(Morgan1, "Anger")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_410004")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_410005")
	

	
	change_face(Noir2, "Anger")
	
	message("MA_01B900_410006")
	close_speech_window()

	
	change_face(Morgan1, "Anger")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_410007")
	

	
	change_face(Morgan1, "Anger")
	
	message("MA_01B900_410008")
	close_speech_window()

	
	dot_move_unit_seq(dotMorgan1,23, 31)
	
	change_camera_distance(7.0, 1.0)
	move_camera(23, 31, 1.0)

	wait_seq()
	wait_camera()
	
	dot_unit_dir(dotMorgan1, 2) 

	on_active(Ef_EneAura) 
	on_active(Ef_EneAura2) 
	
	local gridpos = get_grid_position(24, 31)
	set_pos(Ef_EneAura2, gridpos)
	play_particle(Ef_EneAura2)

	wait_time(0.3)
	
	local gridpos = get_grid_position(24, 31)
	set_pos(Ef_EneAura, gridpos)
	play_particle(Ef_EneAura)

	wait_time(1.0)
	

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_410010")
	close_speech_window()

	move_camera(24, 33, 1.0)
	change_camera_distance(8.0, 1.0)
	wait_camera()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_410011")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_410012")
	

	
	change_face(Morgan1, "Anger")
	
	message("MA_01B900_410013")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_410014")
	

	
	dot_move_unit_seq(dotLancelot1,24, 33)

	move_camera(24, 33, 1.0)

	wait_seq()
	wait_camera()

	on_active(Ef_KillAura) 

	local gridpos = get_grid_position(24, 33)
	set_pos(Ef_KillAura, gridpos)
	play_particle(Ef_KillAura)


	
	change_face(Lancelot1, "Normal")
	
	message("MA_01B900_410016")
	

	
	change_face(Lancelot1, "Normal")
	
	message("MA_01B900_410017")
	close_speech_window()

	
	change_face(Morgan1, "Anger")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_410018")
	close_speech_window()


	
	open_cutin(1,1)
	
	on_cutin(1,Lancelot1,"Serious") 

	
	open_speech_window("CHRNAME_LANCELOT2", nil, nil)
	message("MA_01B900_410019")
	close_speech_window()

	

	
	close_cutin()	


	
	dot_change_anim(dotLancelot1,12)	
	
	wait_time(0.5)
	
	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_410021")
	

	
	dot_move_unit_seq(dotNoir2, 23, 33)
	wait_seq()

	dot_change_anim(dotNoir2,12)		
	
	
	change_face(Lancelot1, "Normal")
	
	message("MA_01B900_410023")
	

	
	dot_move_unit_seq(dotGalahad2, 22, 33)
	wait_seq()
	
	
	
	change_face(Lancelot1, "Normal")
	
	message("MA_01B900_410025")
	

	
	move_camera(23, 34, 1.0)
	change_camera_distance(8.0, 1.0)
	dot_reserve_move_unit_seq(dotAdam,24, 35)
	dot_reserve_move_unit_seq(dotMathajim,23, 35)
	dot_reserve_move_unit_seq(dotOwen,22, 35)
	dot_reserve_move_unit_seq(dotAstera1,22, 36)
	
	exec_parallel_seq()
	
	wait_seq()
	wait_camera()
	
	
	change_face(Lancelot1, "Normal")
	
	message("MA_01B900_410027")
	

	
	
	change_face(Lancelot1, "Smile")
	
	message("MA_01B900_410029")
	close_speech_window()

	

	
	
	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 21, 36,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 24, 34,0)
	pbadv_setup_101028_Galahad_preload(2,true, 19, 34, 0)
	pbadv_setup_101055_Owen_preload(0,true, 20, 34,0)
	pbadv_setup_101053_Mathajim_preload(0,true, 21, 34,0)
	pbadv_setup_101054_Adam_preload(0,true, 22, 34,0)
	pbadv_setup_101029_Astera_preload(1,true, 19, 36,0)
	pbadv_setup_101035_Liliana_preload(1,true, 23, 36,0)
	pbadv_setup_101034_Excelia_preload(1,true, 24, 36,0)
	pbadv_setup_101041_Morgan_preload(1,true, 21, 31,0)
	pbadv_setup_101015_Arthur_preload(1,true, 24, 31,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
end
