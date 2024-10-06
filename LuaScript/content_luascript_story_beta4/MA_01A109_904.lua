

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	init_psbattleadv("201080000", "201080000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)
	
	
	pbadv_setup_101009_Noir(2,true, 13, 22,0)  

	pbadv_setup_101038_Lola(0,true, 12, 21,0) 
	pbadv_setup_101039_Fren(0,true, 12, 23,0) 
	
	
	dotsho = dot_reserve_ally(401011001, 15, 22, 0)
	dot_set_weapon(dotsho, 102010001)
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotsho, DotDir_Left)
	
	dot_disp_weapon(dotsho,false)
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotLola,false)
	dot_disp_weapon(dotFren,false)

	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(25.0, 0.0)
	
	
	move_camera(13, 22, 0.0)
	
end






function Play()
	fadein(0)
	Play_start(true)

	
	open_speech_window("NPCNAME_0303", nil, nil)
	 --PlayPartVoice("市民_男1","驚き")
	message("MA_01A109_9040002")

	
	message("MA_01A109_9040003")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","肯定2")
	message("MA_01A109_9040004")

	
	message("MA_01A109_9040005")
	close_speech_window()

	
	change_face(Fren, "Sad")
	open_speech_window("CHRNAME_FREN", Fren, nil)
	message("MA_01A109_9040006")
	close_speech_window()

	dot_unit_dir(dotLola, 2)

	
	
	change_face(Lola, "Surprise")
	open_speech_window("CHRNAME_LOLA", Lola, nil)
	 --PlayPartVoice("ローラ","悩む")
	message("MA_01A109_9040007")
	close_speech_window()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 13, 22,0)
	pbadv_setup_101038_Lola_preload(0,true, 12, 21,0)
	pbadv_setup_101039_Fren_preload(0,true, 12, 23,0)
end
