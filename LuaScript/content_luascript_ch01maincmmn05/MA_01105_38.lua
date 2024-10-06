

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(BattleTime_Night,BattleWeather_Shiny) 
	
	
	pbadv_setup_101052_Vernarth(0,true,22,15,0)
	pbadv_setup_101051_Lucius(0,true,21,14,0)
	pbadv_setup_101037_Rasia(0,true,23,15,0)
	
	
	
	dotfriendly_forces1_1 = dot_reserve_ally(401040001, 26, 11, 0)
	dot_set_weapon(dotfriendly_forces1_1, 101010001)
	
	dotfriendly_forces1_2 = dot_reserve_ally(401039001, 25, 8, 0)
	dot_set_weapon(dotfriendly_forces1_2, 104010001)
	
	dotfriendly_forces1_3 = dot_reserve_ally(401039001, 20, 9, 0)
	dot_set_weapon(dotfriendly_forces1_3, 108010001)
	
	dotfriendly_forces1_4 = dot_reserve_ally(401039001, 24, 12, 0)
	dot_set_weapon(dotfriendly_forces1_4, 102020001)
	
	die = dot_reserve_ally(201004000, 21, 9, 0)
	dot_set_weapon(die, 102020001)
	
	die2 = dot_reserve_ally(201007000 , 22, 9, 0)
	dot_set_weapon(die2, 102020001)
	
	die4 = dot_reserve_ally(201004000, 27, 14, 0)
	dot_set_weapon(die4, 102020001)
	
	die5 = dot_reserve_ally(201004000, 26, 13, 0)
	dot_set_weapon(die5, 102020001)
	
	die6 = dot_reserve_ally(201004000, 28, 11, 0)
	dot_set_weapon(die6, 102020001)
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotVernarth, DotDir_Left)
	dot_unit_dir(dotRasia, DotDir_Left)
	dot_unit_dir(dotfriendly_forces1_1, DotDir_Left)
	dot_unit_dir(dotfriendly_forces1_2, DotDir_Left)
	
	
	dot_change_anim(dotfriendly_forces1_1,DotAnim_Squat)
	dot_change_anim(dotfriendly_forces1_2,DotAnim_Squat)
	dot_change_anim(dotfriendly_forces1_3,DotAnim_Squat)
	dot_change_anim(dotfriendly_forces1_4,DotAnim_Squat)
	
	
	dot_disp_weapon(dotRasia,false)
	dot_disp_weapon(dotVernarth,false)
	dot_disp_weapon(dotLucius,false)
	dot_disp_weapon(die,false)
	dot_disp_weapon(die2,false)
	dot_disp_weapon(die4,false)
	dot_disp_weapon(die5,false)
	dot_disp_weapon(die6,false)
	
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(28.0, 0.0)

	
	
	move_camera(22,15, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	
	



	
	
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01105_380002")
	close_speech_window()

	
	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH", Vernarth, nil)
	message("MA_01105_380003")
	OpenFirstAppearance(Vernarth)
	close_speech_window()

	
	change_face(Lucius,"Sad")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01105_380004")
	close_speech_window()

	
	open_speech_window("CHRNAME_VERNARTH", Vernarth, nil)
	message("MA_01105_380005")
	close_speech_window()

	
	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01105_380006")
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101052_Vernarth_preload(0,true,22,15,0)
	pbadv_setup_101051_Lucius_preload(0,true,21,14,0)
	pbadv_setup_101037_Rasia_preload(0,true,23,15,0)
end
