

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	init_psbattleadv("201080000", "201080000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)
	
	pbadv_setup_101009_Noir(2,true, 6, 22,0)  

	pbadv_setup_101038_Lola(0,true, 5, 22,0) 
	pbadv_setup_101039_Fren(0,true, 4, 22,0) 
	
	
	dotsho = dot_reserve_ally(401011001, 15, 22, 0)
	dot_set_weapon(dotsho, 102010001)
	
	barbaroi1 = dot_reserve_enemy(1, 17, 22, 0)
	barbaroi2 = dot_reserve_enemy(49, 18, 21, 0)
	barbaroi3 = dot_reserve_enemy(1301, 18, 23, 0)
	barbaroi4 = dot_reserve_enemy(1, 18, 20, 0)
	barbaroi5 = dot_reserve_enemy(600, 18, 24, 0)
	
	
	setup_complete_unit()
	
	dot_disp_weapon(dotsho,false)
	
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(25.0, 0.0)
	
	
	move_camera(13, 22, 0.0)
	
end


function Play()
	fadein(0)
	Play_start(true)


	
	open_speech_window("NPCNAME_0303", nil, nil)
	 --PlayPartVoice("市民_男1","苦しみ")
	message("MA_01A109_9030002")
	close_speech_window()

	dot_reserve_move_unit_seq(dotNoir2, 13, 22)
	dot_reserve_move_unit_seq(dotLola, 12, 21)
	dot_reserve_move_unit_seq(dotFren, 12, 23)

	
	exec_parallel_seq()

	
	wait_seq()

	change_face(Noir2,"Anger")

	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A109_9030003")
	close_speech_window()

	dot_unit_dir(dotsho, DotDir_Left)

	
	open_speech_window("NPCNAME_0303", nil, nil)
	 --PlayPartVoice("市民_男1","驚き")
	message("MA_01A109_9030004")

	
	message("MA_01A109_9030005")
	close_speech_window()


	change_face(Noir2,"Anger")

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","怒り")
	message("MA_01A109_9030006")
	close_speech_window()


	
	open_speech_window("NPCNAME_0303", nil, nil)
	message("MA_01A109_9030007")
	close_speech_window()

	
	dot_move_unit_seq(dotsho, 6, 22)
	wait_seq()

	change_face(Noir2,"Anger")

	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","気合い")
	message("MA_01A109_9030008")
	close_speech_window()


	
	change_face(Lola, "Surprise")
	open_speech_window("CHRNAME_LOLA", Lola, nil)
	 --PlayPartVoice("ローラ","悩む")
	message("MA_01A109_9030009")
	close_speech_window()


	
	change_face(Fren, "Sad")
	open_speech_window("CHRNAME_FREN", Fren, nil)
	message("MA_01A109_9030010")
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 6, 22,0)
	pbadv_setup_101038_Lola_preload(0,true, 5, 22,0)
	pbadv_setup_101039_Fren_preload(0,true, 4, 22,0)
end
