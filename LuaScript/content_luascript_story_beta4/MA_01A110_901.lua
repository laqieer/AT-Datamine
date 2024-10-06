

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)


	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(BattleTime_Night,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 16, 13,0)  

	pbadv_setup_101030_Elaine(3,true, 19, 13,0)  
	pbadv_setup_101031_Lovein(0,true, 18, 14,0)  
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotLovein, 2)
	dot_unit_dir(dotElaine3, 2)

	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotLovein,false)
	dot_disp_weapon(dotElaine3,false)
	
	
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(25.0, 0.0)
	
	
	move_camera(17, 13, 0.0)
	
end


function Play()
	fadein(0)
	Play_start(true)

	
	change_face(Lovein,"Angry")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	 --PlayPartVoice("ラヴェイン","否定")
	message("MA_01A110_9010002")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","驚き")
	message("MA_01A110_9010003")
	close_speech_window()
	

	
	change_face(Elaine3,"Angry")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	 --PlayPartVoice("エレイン","挨拶")
	message("MA_01A110_9010004")
	close_speech_window()


	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","肯定2")
	message("MA_01A110_9010005")
	close_speech_window()

	Play_end(true)
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 16, 13,0)
	pbadv_setup_101030_Elaine_preload(3,true, 19, 13,0)
	pbadv_setup_101031_Lovein_preload(0,true, 18, 14,0)
end
