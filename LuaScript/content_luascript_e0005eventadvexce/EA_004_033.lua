Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	
	init_psbattleadv("201000000", "201000000")
	
	change_time_and_weather(1,1)
	
	pbadv_setup_101009_Noir(2,true,23,39,0)
	pbadv_setup_101034_Excelia(0,true,21 ,38 ,0)
	pbadv_setup_101035_Liliana(0,true, 24, 35,0) 
	pbadv_setup_101054_Adam(3,true, 17, 35,0)
	
	dotstudentB = dot_reserve_ally(401005001, 24, 37, 0)
	dot_set_weapon(dotstudentB, 101010005)
	
	dotstudentG = dot_reserve_ally(401006001, 23, 35, 0)
	dot_set_weapon(dotstudentG, 101010005)
	
	dotstudentB2 = dot_reserve_ally(401007001, 22, 36, 0)
	dot_set_weapon(dotstudentB2, 101010005)
	
	dotstudentG2 = dot_reserve_ally(401008001, 25, 36, 0)
	dot_set_weapon(dotstudentG2, 101010005)
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotLiliana, 2)
	dot_unit_dir(dotstudentB, 2)
	dot_unit_dir(dotstudentG2, 2)
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(22, 37, 0.0)
	
	Ef_think = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_think2 = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_think3 = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_think4 = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_think5 = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_think6 = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_panic = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_moya = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Moya01_Lop", false, true)
	
end





function Play()
	fadein(0)
	Play_start(true)

	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0012")
	message("EA_004_0330003")
	close_speech_window()
	
	change_face(Excelia, "Normal")
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0330004")
	close_speech_window()
	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0011")
	message("EA_004_0330005")
	close_speech_window()
	
	change_face(Excelia, "Normal")
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoiceDirect("エクセリア", "0008")
	message("EA_004_0330006")
	close_speech_window()
	
	
	dot_move_unit_seq(dotNoir2,23, 37)
	wait_seq()
	
	
	wait_time(1.0)
	dot_unit_dir(dotExcelia, 2)
	on_active(Ef_think) 

	local gridpos = get_grid_position(23, 37) 
	gridpos[2] = 1.5
	set_pos(Ef_think, gridpos)
	play_particle(Ef_think)
	
	move_camera(21, 38, 2.0)
	change_camera_distance(5.0, 2.0)
	
	
	
	change_face(Excelia, "Sad")
	open_mind_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0330007")
	

	stop_particle(Ef_think)

	on_active(Ef_think2)
	local gridpos = get_grid_position(24, 37) 
	gridpos[2] = 1.5
	set_pos(Ef_think2, gridpos)
	play_particle(Ef_think2)
	
	on_active(Ef_think3)
	local gridpos = get_grid_position(25, 36) 
	gridpos[2] = 1.5
	set_pos(Ef_think3, gridpos)
	play_particle(Ef_think3)
	
	on_active(Ef_think6)
	local gridpos = get_grid_position(24, 35) 
	gridpos[2] = 1.5
	set_pos(Ef_think6, gridpos)
	play_particle(Ef_think6)
	
	wait_time(1.0)
	
	on_active(Ef_panic)
	local gridpos = get_grid_position(23, 37) 
	gridpos[2] = 1.5
	set_pos(Ef_panic, gridpos)
	play_particle(Ef_panic)
	
	
	change_face(Excelia, "Sad")
	message("EA_004_0330008")
	
	stop_particle(Ef_panic)
	
	on_active(Ef_think) 

	local gridpos = get_grid_position(23, 37) 
	gridpos[2] = 1.5
	set_pos(Ef_think, gridpos)
	play_particle(Ef_think)
	
	wait_time(1.0)
	
	on_active(Ef_think4)
	local gridpos = get_grid_position(22, 36) 
	gridpos[2] = 1.5
	set_pos(Ef_think4, gridpos)
	play_particle(Ef_think4)
	
	on_active(Ef_think5)
	local gridpos = get_grid_position(23, 35) 
	gridpos[2] = 1.5
	set_pos(Ef_think5, gridpos)
	play_particle(Ef_think5)
	
	
	change_face(Excelia, "Sad")
	message("EA_004_0330009")
	close_mind_window()
	
	stop_particle(Ef_think)
	dot_unit_dir(dotNoir2, 2)
	wait_time(1.5)
	
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	voice_play("VO_101009_sp_0027_1")
	message("EA_004_0330010")
	close_speech_window()
	
	dot_unit_dir(dotExcelia, 3)
	
	change_face(Excelia, "Normal")
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoiceDirect("エクセリア", "0040")
	message("EA_004_0330011")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("EA_004_0330012")
	close_speech_window()
	
	


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,23,39,0)
	pbadv_setup_101034_Excelia_preload(0,true,21 ,38 ,0)
	pbadv_setup_101035_Liliana_preload(0,true, 24, 35,0)
	pbadv_setup_101054_Adam_preload(3,true, 17, 35,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Moya01_Lop", false, true)
end
