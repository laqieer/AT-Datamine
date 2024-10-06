

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	

	setup_101009_Noir() 

	
	
	init_psbattleadv("201000000", "201000000")
	
	
	change_time_and_weather(BattleTime_Night, BattleWeather_Shiny)


    pbadv_setup_101009_Noir(2,true,8,19, 0)    
	
	merchant = dot_reserve_ally(401011001, 8,22, 0)
	dot_set_weapon(merchant, 102010001)
	

	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotNoir2, 0)
	dot_unit_dir(merchant, 0)

	
	
	dot_disp_weapon(merchant, false)



	dot_change_anim(dotNoir2,0) 
	dot_change_anim(merchant,0) 


	
	
	
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(40.0, 0.0)

	
	
	move_camera(8,21, 0.0)

end





function Play()
	fadein(0)
	Play_start(true)


	dot_unit_dir(dotNoir2, 2)
	wait_time(1.2)
	dot_unit_dir(dotNoir2, 3)
	wait_time(1.2)
	dot_disp_weapon(dotNoir2, false)


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01105_9030002") 
	close_speech_window()

	open_speech_window("NPCNAME_0307", nil, nil)
		message("MA_01105_9030003") 
	close_speech_window()



	dot_move_unit_seq(merchant,8, 20)
		wait_seq()
	dot_unit_dir(merchant, 0)

	open_speech_window("NPCNAME_0307", nil, nil)
		message("MA_01105_9030004") 
	close_speech_window()

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01105_9030005") 
	close_speech_window()



	dot_move_unit_seq(merchant,15, 20)
		wait_seq()
	dot_move_unit_seq(merchant,15, 14)
		wait_seq()
	dot_move_unit_seq(merchant,16, 14)
		wait_seq()
	dot_move_unit_seq(merchant,16, 6)
		wait_seq()

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01105_9030006") 
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup_101009_Noir_preload()
    pbadv_setup_101009_Noir_preload(2,true,8,19, 0)
end
