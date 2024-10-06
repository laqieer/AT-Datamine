Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	
	init_psbattleadv("201000000", "201000000")
	
	change_time_and_weather(1,1)
	
	pbadv_setup_101009_Noir(2,true,20,34,0)
	pbadv_setup_101054_Adam(3,true, 25, 34,0)
	
	
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotAdam3, 2)
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(23, 34, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)
	
	dot_attack_seq(dotAdam3, dotNoir2)		
	wait_time(0.5)	
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	wait_time(0.5)	
	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotAdam3,0)
	
	
	dot_move_unit_seq(dotNoir2,24, 34)
	wait_seq()
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotAdam3,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_Guard01",1,false)
	wait_seq()
	dot_move_knockback(dotNoir2,22, 34,0.6,2)
	wait_time(1.0)	
	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotAdam3,0)
	

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0046")
	message("EA_004_0120002")
	close_speech_window()
	
	dot_move_unit_seq(dotAdam3,24, 34)
	wait_seq()
	
	change_face(Adam3, "Smile")
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	PlayPartVoiceDirect("アダン", "0034")
	message("EA_004_0120003")
	close_speech_window()
	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0007")
	message("EA_004_0120004")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_LongFade")
	
	



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,20,34,0)
	pbadv_setup_101054_Adam_preload(3,true, 25, 34,0)
end
