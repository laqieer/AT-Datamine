




Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101010_Lancelot(3,true, 22, 5,0)  
	pbadv_setup_101015_Arthur(0,true, 23, 5,0)  

	pbadv_setup_101020_Merlin(2,true, 18, 5,0)  
	pbadv_setup_101009_Noir(2,true, 18, 6,0)  
	
	pbadv_setup_101013_Gawain(0,true, 30, 3,0)  
	pbadv_setup_101041_Morgan(2,true, 29, 3,0) 
	
	 
	setup_101041_Morgan(nil, nil, 0, false) 

	
	
	
	

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	dot_unit_dir(dotArthur, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotMorgan2, 2)


	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotMerlin2, false)
	dot_disp_weapon(dotGawain, false)
	dot_disp_weapon(dotMorgan2, false)

	
	
	dot_disp_unit(dotGawain, false)
	dot_disp_unit(dotMorgan2, false)

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(22, 5, 0.0)

	
	Ef_EneAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	Ef_EneAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	Ef_BigEneAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)

end





function Play()
	fadein(0)
	Play_start(true)

	
	

	
	dot_change_anim(dotArthur, 3)
	dot_play_particle_unit(dotArthur,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotLancelot3, 6)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_move_knockback(dotLancelot3, 21, 5, 0.3, 2)

	dot_change_anim(dotArthur, 0)

	wait_time(0.2)

	dot_change_anim(dotLancelot3, 0)
	dot_move_unit_seq(dotArthur,22, 5)	
	wait_seq()

	dot_change_anim(dotLancelot3, 3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01A111_14_sword_02")
	
	dot_change_anim(dotArthur, 3)
	dot_play_particle_unit(dotArthur,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.2)

	
	dot_change_anim(dotLancelot3, 0)
	dot_change_anim(dotArthur, 0)

	wait_time(0.1)
	
	dot_change_anim(dotLancelot3, 3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotArthur, 6)
	dot_play_particle_unit(dotArthur,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_move_knockback(dotArthur, 23, 5, 0.3, 2)
	
	dot_change_anim(dotLancelot3, 0)

	wait_time(0.2)

	dot_change_anim(dotArthur, 0)

	wait_time(0.2)

	dot_move_unit_seq(dotLancelot3,22, 5)	
	wait_seq()

	dot_change_anim(dotLancelot3, 3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01A111_14_sword_02")
	
	dot_change_anim(dotArthur, 3)
	dot_play_particle_unit(dotArthur,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.1)
	dot_change_anim(dotLancelot3, 6)
	dot_change_anim(dotArthur, 6)
	
	dot_move_knockback(dotLancelot3, 21, 5, 0.3, 2)
	dot_move_knockback(dotArthur, 24, 5, 0.3, 2)

	wait_time(0.3)

	dot_change_anim(dotLancelot3, 0)
	dot_change_anim(dotArthur, 0)
	
	wait_time(0.25)	
		
	dot_move_unit_seq(dotArthur,23, 5)
	
	wait_seq()
		
	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_130002")
	close_speech_window()

	
	dot_disp_weapon(dotArthur, false)
	dot_disp_weapon(dotLancelot3, false)

	wait_time(0.3)
	
	
	on_active(Ef_EneAura) 
	
	local gridpos = get_grid_position(23, 5)
	set_pos(Ef_EneAura, gridpos)
	play_particle(Ef_EneAura)
	

	change_camera_distance(8.0, 1.0)
	move_camera(22, 5, 1.0)	
	
	dot_reserve_move_unit_seq(dotLancelot3, 22, 5)
	dot_reserve_move_unit_seq(dotMerlin2,20, 5)
	dot_reserve_move_unit_seq(dotNoir2,21, 6)
	
	exec_parallel_seq()
	wait_seq()
	wait_camera()

	dot_change_anim(dotArthur, 1)

	
	dot_disp_weapon(dotLancelot3, false)

	
	change_face(Lancelot3, "Sad")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_130004")
	close_speech_window()

	
	change_face(Merlin2, "Sad")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B900_130005")
	close_speech_window()

	
	local gridpos = get_grid_position(23, 5)
	set_pos(Ef_EneAura, gridpos)
	play_particle(Ef_EneAura)
		
	wait_time(0.5)
	
	on_active(Ef_EneAura2) 
	
	local gridpos = get_grid_position(23, 5)
	set_pos(Ef_EneAura2, gridpos)
	play_particle(Ef_EneAura2)
	


	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_130007")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_130008")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_130009")
	close_speech_window()

	
	change_face(Merlin2, "Normal")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B900_130011")
	

	
	change_face(Merlin2, "Normal")
	
	message("MA_01B900_130012")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_130014")
	

	
	change_face(Arthur, "Normal")
	
	message("MA_01B900_130015")
	

	
	change_face(Arthur, "Smile")
	
	message("MA_01B900_130016")
	close_speech_window()

	
	dot_change_anim(dotArthur, 0)
	stop_particle(Ef_EneAura2)
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_130018")
	close_speech_window()

	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_130019")
	close_speech_window()

	
	
	
	wait_time(1.0)
	
	
	
	
	
	
	
	change_face(Gawain, "Smile")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01B900_130021")
	close_speech_window()

	
	dot_unit_dir(dotArthur, 3)
	
	dot_disp_unit(dotGawain, true)
	dot_disp_unit(dotMorgan2, true)

	
	dot_reserve_move_unit_seq(dotMorgan2,26, 4)
	dot_reserve_move_unit_seq(dotGawain,27, 4)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotMorgan2,26, 5)
	exec_parallel_seq()
	
	
	
	
	move_camera(23, 5, 1.0)
	
	wait_seq()

	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotMorgan2, 2)
	dot_disp_weapon(dotGawain, false)

	
	
	change_face(Gawain, "Sad")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01B900_130023")
	close_speech_window()

	
	change_face(Morgan, "Smile")
	open_speech_window("CHRNAME_MORGAN", Morgan, nil)
	message("MA_01B900_130024")
	close_speech_window()

	
	change_face(Arthur, "Surprise")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_130025")
	close_speech_window()

	
	change_face(Morgan, "Normal")
	open_speech_window("CHRNAME_MORGAN", Morgan, nil)
	message("MA_01B900_130026")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_130027")
	close_speech_window()

	
	change_face(Gawain, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01B900_130028")
	

	
	change_face(Gawain, "Smile")
	
	message("MA_01B900_130029")
	close_speech_window()

	
	change_face(Morgan, "Smile")
	open_speech_window("CHRNAME_MORGAN", Morgan, nil)
	message("MA_01B900_130030")
	

	bgm_play("Stop_BGM_Bus_LongFade")
	
	change_face(Morgan, "Normal")
	
	message("MA_01B900_130031")
	close_speech_window()
	
	local gridpos = get_grid_position(23, 5)
	set_pos(Ef_EneAura, gridpos)
	play_particle(Ef_EneAura)
		
	wait_time(0.2)

	on_active(Ef_BigEneAura) 

	local gridpos = get_grid_position(23, 5)
	set_pos(Ef_BigEneAura, gridpos)
	play_particle(Ef_BigEneAura)
		
	wait_time(1.0)
	
	


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101010_Lancelot_preload(3,true, 22, 5,0)
	pbadv_setup_101015_Arthur_preload(0,true, 23, 5,0)
	pbadv_setup_101020_Merlin_preload(2,true, 18, 5,0)
	pbadv_setup_101009_Noir_preload(2,true, 18, 6,0)
	pbadv_setup_101013_Gawain_preload(0,true, 30, 3,0)
	pbadv_setup_101041_Morgan_preload(2,true, 29, 3,0)
	setup_101041_Morgan_preload(nil, nil, 0, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
end
