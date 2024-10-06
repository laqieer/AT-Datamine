

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	
	
	
	
	init_psbattleadv("201110000", "201110000")
	change_time_and_weather(1,1) 
	
	load_image("MA01C1123901", "content_still_10104006_image", "101040060_StillImage")
	
	
	 
    pbadv_setup_101009_Noir(2,true,23,7,0)
    
    
    
    pbadv_setup_101010_Lancelot(3,true,24,7,0)
    
    
    pbadv_setup_101012_Dinatan(1,true,24,6,0)
    
    
	pbadv_setup_101051_Lucius(0,true,23,10,0)
	
	
	pbadv_setup_101022_Mordred(0,true,24,10 ,0)  
	
	
	pbadv_setup_101023_Clarice(1,true,25,10,0)
	
	
    pbadv_setup_101017_Maladisant(1,true,25,7,0)
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

	
	
	
		
	
	
	
	
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotLancelot3,2)
	dot_unit_dir(dotMaladisant1,2)
	dot_change_anim(dotLancelot3,1)

	
	
	
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotDinatan1, false)
	dot_disp_weapon(dotLucius, false)
	dot_disp_weapon(dotMordred, false)
	dot_disp_weapon(dotClarice1, false)
	dot_disp_weapon(dotMaladisant1, false)

	
	
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(24, 7, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	change_camera_distance(7.0, 1.0)

	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_390002")
	close_speech_window()

	
	change_face(Lancelot3, "Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_390003")
	close_speech_window()
	

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_390004")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_390005")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_390006")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_390007")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_390008")
	

	
	change_face(Lancelot3, "Sad")
	
	message("MA_01C112_390009")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_390010")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_390011")
	

	
	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_390013")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_390014")
	

	
	change_face(Lancelot3, "Sad")
	
	message("MA_01C112_390015")
	

	
	change_face(Lancelot3, "Sad")
	
	message("MA_01C112_390016")
	

	
	change_face(Lancelot3, "Sad")
	
	message("MA_01C112_390017")
	

	
	change_face(Lancelot3, "Sad")
	
	message("MA_01C112_390018")
	close_speech_window()

	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_390020")
	

	
	change_face(Noir2, "Sad")
	
	message("MA_01C112_390021")
	close_speech_window()

	
	change_face(Lancelot3, "Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_390022")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_390023")
	close_speech_window()

	
	change_face(Dinatan1, "Normal")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_390024")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_390025")
	

	
	change_face(Lancelot3, "Pain")
	
	message("MA_01C112_390026")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_390027")
	close_speech_window()

	
	change_face(Lancelot3, "Pain")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_390028")
	

	
	change_face(Lancelot3, "Pain")
	
	message("MA_01C112_390029")
	

	
	change_face(Lancelot3, "Pain")
	
	message("MA_01C112_390030")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_390031")
	close_speech_window()
	
	
	wait_time(0.5)
	wait_seq()

	
	show_image("MA01C1123901", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
	
	
	change_face(Noir2, "Anger")
	open_simple_window("CHRNAME_NOIR",nil , nil)
	message("MA_01C112_390033")
	

	
	change_face(Noir2, "Sad")
	
	message("MA_01C112_390034")
	

	
	change_face(Noir2, "Sad")
	
	message("MA_01C112_390035")
	

	
	change_face(Noir2, "Sad")
	
	message("MA_01C112_390036")
	

	
	change_face(Noir2, "Sad")
	
	message("MA_01C112_390037")
	


	
	change_face(Noir2, "Anger")
	
	message("MA_01C112_390038")
	close_simple_window()
	
	
	dot_change_anim(dotDinatan1,0)
	dot_reserve_move_unit_seq(dotDinatan1,23, 6)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotDinatan1,3)
	

	
	change_face(Dinatan1, "Sad")
	open_simple_window("CHRNAME_DINATAN",nil , nil)
	message("MA_01C112_390039")
	close_simple_window()

	
	change_face(Noir2, "Anger")
	open_simple_window("CHRNAME_NOIR",nil , nil)
	message("MA_01C112_390040")
	close_simple_window()
	
	
	
	
	wait_time(1.0)
	wait_seq()

	


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("MA01C1123901", "content_still_10104006_image", "101040060_StillImage")
    pbadv_setup_101009_Noir_preload(2,true,23,7,0)
    pbadv_setup_101010_Lancelot_preload(3,true,24,7,0)
    pbadv_setup_101012_Dinatan_preload(1,true,24,6,0)
	pbadv_setup_101051_Lucius_preload(0,true,23,10,0)
	pbadv_setup_101022_Mordred_preload(0,true,24,10 ,0)
	pbadv_setup_101023_Clarice_preload(1,true,25,10,0)
    pbadv_setup_101017_Maladisant_preload(1,true,25,7,0)
end
