Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	
	
	
	
	init_psbattleadv("201000002", "201000002")
	
	change_time_and_weather(1,1)
	
	pbadv_setup_101009_Noir(2,true,26,19,0)
	pbadv_setup_101054_Adam(3,true, 20, 15,0)
    pbadv_setup_101026_Percival(0,true,15,19,0)
	pbadv_setup_101034_Excelia(0,true,13 ,20 ,0)
	pbadv_setup_101035_Liliana(0,true, 27, 20,0)  
	
	dotstudentB = dot_reserve_ally(401005001, 28, 18, 0)
	dot_set_weapon(dotstudentB, 101010001)
	
	dotstudentG = dot_reserve_ally(401006001, 29, 19, 0)
	dot_set_weapon(dotstudentG, 104010001)
	
	dotstudentB2 = dot_reserve_ally(401005001, 13, 19, 0)
	dot_set_weapon(dotstudentB2, 108010001)
	
	dotstudentG2 = dot_reserve_ally(401006001, 16, 20, 0)
	dot_set_weapon(dotstudentG2, 102020001)
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotAdam3, 2)
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotLiliana, 2)
	dot_unit_dir(dotstudentB, 2)
	dot_unit_dir(dotstudentG, 2)
	dot_disp_weapon(dotAdam3, false)
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(20, 15, 0.0)
	
	Ef_panic = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_panic2 = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_panic3 = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)

	load_sound("BGM_Battle_Running_FI")
	
end





function Play()
	fadein(0)
	Play_start(true)

	change_face(Adam3, "Normal")
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	PlayPartVoiceDirect("アダン", "0034")
	message("EA_004_0210006")
	close_speech_window()
	
	move_camera(15, 20, 2.0)
	wait_time(2.0)
	
	change_face(Percival, "Smile")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoiceDirect("パーシヴァル", "0010")
	message("EA_004_0210008")
	PlayPartVoiceDirect("パーシヴァル", "0042")
	message("EA_004_0210009")
	close_speech_window()
	
	change_face(Excelia, "Normal")
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoiceDirect("エクセリア", "0008")
	message("EA_004_0210010")
	close_speech_window()
	
	move_camera(26, 20, 2.0)
	wait_time(2.0)
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0007")
	message("EA_004_0210011")
	close_speech_window()
	
	change_face(Liliana, "Anger")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoiceDirect("リリアーナ", "0007")
	message("EA_004_0210012")
	close_speech_window()
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("EA_004_0210013")
	close_speech_window()
	
	move_camera(15, 20, 2.0)
	wait_time(2.0)
	
	change_face(Excelia, "Anger")
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoiceDirect("エクセリア", "0025")
	message("EA_004_0210014")
	close_speech_window()
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0021")
	message("EA_004_0210015")
	close_speech_window()
	
	bgm_play("Stop_BGM_Bus_MidFade")
	change_face(Adam3, "Normal")
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	message("EA_004_0210016")
	close_speech_window()

	bgm_play("BGM_Battle_Running_FI")
	
	
	
	change_face(Excelia, "Anger")
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0210018")
	close_speech_window()
	
	
	
	on_active(Ef_panic)
	local gridpos = get_grid_position(13,19)
	gridpos[2] = 1.5
	set_pos(Ef_panic, gridpos)
	play_particle(Ef_panic)
	wait_seq()
	
	on_active(Ef_panic2)
	local gridpos = get_grid_position(16,20)
	gridpos[2] = 1.5
	set_pos(Ef_panic2, gridpos)
	play_particle(Ef_panic2)
	wait_seq()
	
	on_active(Ef_panic3)
	local gridpos = get_grid_position(15,19)
	gridpos[2] = 1.5
	set_pos(Ef_panic3, gridpos)
	play_particle(Ef_panic3)
	wait_seq()
	
	dot_reserve_move_unit_seq(dotLiliana,20,20, 1.5)
	dot_reserve_move_unit_seq(dotNoir2,21,19)
	dot_reserve_move_unit_seq(dotstudentG ,25 ,19 )
	dot_reserve_move_unit_seq(dotstudentB ,26 ,20 )
	exec_parallel_seq()
	wait_seq()
	
	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoiceDirect("パーシヴァル", "0028")
	message("EA_004_0210020")
	close_speech_window()
	
	stop_particle(Ef_panic)
	stop_particle(Ef_panic2)
	stop_particle(Ef_panic3)
	
	change_face(Excelia, "Anger")
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0210021")
	close_speech_window()
	
	
	dot_unit_dir(dotPercival, 3)
	wait_time(0.3)
	dot_unit_dir(dotPercival, 2)
	wait_time(0.3)
	dot_unit_dir(dotPercival, 3)
	wait_time(0.2)
	dot_unit_dir(dotPercival, 2)
	wait_time(0.3)
	dot_unit_dir(dotPercival, 3)
	
	
	
	dot_reserve_move_unit_seq(dotLiliana,17,22)
	dot_reserve_move_unit_seq(dotNoir2,17,17)
	dot_reserve_move_unit_seq(dotstudentG ,18 ,19 )
	dot_reserve_move_unit_seq(dotstudentB ,18 ,20 )
	exec_parallel_seq()
	wait_seq()
	
	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("EA_004_0210023")
	close_speech_window()
	
	dot_unit_dir(dotstudentG2, 3)
	wait_time(0.3)
	dot_move_unit_seq(dotstudentB2, 14,19, 1.5)
	dot_unit_dir(dotstudentG2, 2)
	wait_time(0.4)
	dot_unit_dir(dotstudentB2, 3)
	dot_unit_dir(dotstudentG2, 3)
	wait_time(0.2)
	dot_unit_dir(dotstudentG2, 2)
	
	
	open_speech_window("NPCNAME_0151", nil, nil)
	PlayPartVoiceDirect("男子2", "0021")
	message("EA_004_0210024")
	close_speech_window()
	
	dot_unit_dir(dotstudentG2, 3)
	dot_unit_dir(dotstudentB2, 3)
	dot_move_unit_seq(dotstudentG2, 15,20, 1.5)
	wait_time(0.3)
	dot_unit_dir(dotstudentG2, 2)
	dot_unit_dir(dotstudentB2, 2)
	dot_move_unit_seq(dotstudentB2, 13,19, 1.5)
	wait_time(0.4)
	dot_unit_dir(dotstudentG2, 3)
	dot_unit_dir(dotstudentB2, 3)
	
	
	open_speech_window("NPCNAME_0146", nil, nil)
	message("EA_004_0210025")
	close_speech_window()
	
	dot_reserve_move_unit_seq(dotLiliana,11,22)
	dot_reserve_move_unit_seq(dotNoir2,14,17)
	dot_reserve_move_unit_seq(dotstudentG ,17 ,19 )
	dot_reserve_move_unit_seq(dotstudentB ,17 ,20 )
	exec_parallel_seq()
	wait_seq()
	
	dot_move_unit_seq(dotLiliana, 11,19, 1.5)
	wait_seq()
	
	change_face(Percival, "Pain")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("EA_004_0210026")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_LongFade")
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
	
	dot_disp_unit(dotNoir2, true)
	dot_move_unit_seq(dotNoir2,14, 19)
	wait_seq()
	dot_change_anim(dotNoir2,3)
	dot_damage_seq(dotPercival,dotNoir2,true)
	wait_seq()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	pbadv_setup_101009_Noir_preload(2,true,26,19,0)
	pbadv_setup_101054_Adam_preload(3,true, 20, 15,0)
    pbadv_setup_101026_Percival_preload(0,true,15,19,0)
	pbadv_setup_101034_Excelia_preload(0,true,13 ,20 ,0)
	pbadv_setup_101035_Liliana_preload(0,true, 27, 20,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	preload_sound("BGM_Battle_Running_FI")
end
