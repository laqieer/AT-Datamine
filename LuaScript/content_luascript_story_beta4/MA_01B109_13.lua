Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	setup_101009_Noir(nil, nil, 2, false) 
	setup_101010_Lancelot(nil, nil, 0, false) 
	setup_101014_Tristan(nil, nil, 0, false) 
	setup_101019_Isolde(nil, nil, 0, false) 
	
	
	
	init_psbattleadv("201000000", "201000000")
	
	change_time_and_weather(1,1)
	
	
	
	
	
	
	
	dotnoir = dot_reserve_ally(101009001, 21, 34, 0)
	
	
	
	dot_set_weapon(dotnoir, 101010001)		

	
	
	
	dotLancelot = dot_reserve_ally(101010001, 20, 35, 0)
	dot_set_weapon(dotLancelot, 101010001)		

	
	dotTristan = dot_reserve_ally(101014001, 23, 34, 0)
    dot_set_weapon(dotTristan, 105010001)    
    
    
   	dotIsolde = dot_reserve_ally(101019001, 24, 35, 0)
    dot_set_weapon(dotIsolde, 107010001)    

	
	dotstudent = dot_reserve_ally(401036001, 23, 37, 0) 
	dot_set_weapon(dotstudent, 101010001)		
	
	dotstudent2 = dot_reserve_ally(401036001, 24, 36, 0) 
	dot_set_weapon(dotstudent2, 101010001)		
	
	dotstudent3 = dot_reserve_ally(401036001, 24, 34 , 0) 
	dot_set_weapon(dotstudent3, 102010001)
	
	dotstudent4 = dot_reserve_ally(401036001,25 ,35 , 0) 
	dot_set_weapon(dotstudent4, 102010001)
	
	dotstudent5 = dot_reserve_ally(401036001,24 ,37 , 0) 
	dot_set_weapon(dotstudent5, 104010001)
	
	dotstudent6 = dot_reserve_ally(401036001,25 ,36 , 0) 
	dot_set_weapon(dotstudent6, 104010001)
	
	dotstudent7 = dot_reserve_ally(401036001, 25, 34, 0) 
	dot_set_weapon(dotstudent7, 105010001)
	
	dotstudent8 = dot_reserve_ally(401036001, 26, 35, 0) 
	dot_set_weapon(dotstudent8, 105010001)
	
	dotstudent9 = dot_reserve_ally(401036001, 25, 37, 0) 
	dot_set_weapon(dotstudent9, 107010001)
	
	dotstudent10 = dot_reserve_ally(401036001, 26, 36, 0) 
	dot_set_weapon(dotstudent10, 107010001)
		
	
	
	
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotTristan, 2)
	dot_unit_dir(dotIsolde, 2)
	dot_unit_dir(dotstudent, 2)
	dot_unit_dir(dotstudent2, 2)
	dot_unit_dir(dotstudent3, 2)
	dot_unit_dir(dotstudent4, 2)
	dot_unit_dir(dotstudent5, 2)
	dot_unit_dir(dotstudent6, 2)
	dot_unit_dir(dotstudent7, 2)
	dot_unit_dir(dotstudent8, 2)
	dot_unit_dir(dotstudent9, 2)
	dot_unit_dir(dotstudent10, 2)

	
	
	dot_disp_weapon(dotnoir, false)
	dot_disp_weapon(dotLancelot, false)
	dot_disp_weapon(dotTristan, true)
	dot_disp_weapon(dotIsolde, true)
	
	
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(22, 34, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	




	
	
	
	open_speech_window("NPCNAME_0001", nil, nil)
	 --PlayPartVoice("男子2","挨拶")
	message("MA_01B109_130002")
	close_speech_window()
	
	
	
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	 --PlayPartVoice("ランスロット","肯定2")
	message("MA_01B109_130003")
	close_speech_window()
	
	
	
	
	open_speech_window("NPCNAME_0001", nil, nil)
	 --PlayPartVoice("男子1","肯定")
	message("MA_01B109_130004")
	close_speech_window()
	
		

	
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	 --PlayPartVoice("ランスロット","悩む")
	message("MA_01B109_130006")
	close_speech_window()
	
	dot_unit_dir(dotnoir, 2)
	
	
	change_face(Noir, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	 --PlayPartVoice("ノワール","笑い")
	message("MA_01B109_130007")
	close_speech_window()
	
	
	
	change_face(Lancelot, "Smile")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	 --PlayPartVoice("ランスロット","笑い")
	message("MA_01B109_130008")
	
	
	
	
	change_face(Lancelot, "Normal")
	
	message("MA_01B109_130009")
	close_speech_window()
	
	
	
	change_face(Noir, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message("MA_01B109_130010")
	close_speech_window()
	
	dot_change_anim(dotLancelot, 12)
	
	
	change_face(Lancelot, "Smile")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	 --PlayPartVoice("ランスロット","喜び")
	message("MA_01B109_130011")
	close_speech_window()
	
	se_play("SE_ADV_MA_01B109_12_Sword")
	dot_unit_dir(dotnoir, 3)
	
	dot_disp_weapon(dotnoir, true)
	
	dot_change_anim(dotnoir,12)


	
	change_face(Noir, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	 --PlayPartVoice("ノワール","喜び")
	message("MA_01B109_130013")
	close_speech_window()
	
	se_play("SE_ADV_MA_01B109_12_Sword")
	dot_disp_weapon(dotLancelot, true)


	
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	 --PlayPartVoice("ランスロット","肯定3")
	message("MA_01B109_130015")
	
	
	
	
	change_face(Lancelot, "Normal")
	
	message("MA_01B109_130016")
	close_speech_window()	



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup_101009_Noir_preload(nil, nil, 2, false)
	setup_101010_Lancelot_preload(nil, nil, 0, false)
	setup_101014_Tristan_preload(nil, nil, 0, false)
	setup_101019_Isolde_preload(nil, nil, 0, false)
end
