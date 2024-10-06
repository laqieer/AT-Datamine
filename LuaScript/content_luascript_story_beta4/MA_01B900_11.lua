




Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101010_Lancelot(3,true, 21, 5,0)  
	pbadv_setup_101015_Arthur(0,true, 23, 5,0)  

	pbadv_setup_101020_Merlin(2,true, 18, 5,0)  
	pbadv_setup_101009_Noir(2,true, 18, 6,0)  
	
	
	
	
	

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	dot_unit_dir(dotArthur, 2)


	
	
	dot_disp_weapon(dotArthur, false)
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotMerlin2, false)
	dot_disp_weapon(dotLancelot3, false)

	
	

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(22, 5, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)

	
	

	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_110002")
	close_speech_window()

	se_play("SE_ADV_MA_01B109_12_Sword")
	wait_time(0.4)
	dot_disp_weapon(dotLancelot3, true)
	dot_change_anim(dotLancelot3,12)

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_110003")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_110004")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_110005")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_110006")
	

	
	se_play("SE_ADV_MA_01B109_12_Sword")
	wait_time(0.4)
	dot_disp_weapon(dotArthur, true)
	dot_change_anim(dotArthur,12)


	
	
	change_face(Arthur, "Normal")
	
	message("MA_01B900_110008")
	close_speech_window()

	
	change_face(Lancelot3, "Smile")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_110009")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101010_Lancelot_preload(3,true, 21, 5,0)
	pbadv_setup_101015_Arthur_preload(0,true, 23, 5,0)
	pbadv_setup_101020_Merlin_preload(2,true, 18, 5,0)
	pbadv_setup_101009_Noir_preload(2,true, 18, 6,0)
end
