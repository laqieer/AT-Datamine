

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	
	
	
	init_psbattleadv("201110000", "201110000")
	change_time_and_weather(1,1) 
	
	
	
	 
    pbadv_setup_101009_Noir(2,true,23,10,0)
    
    
    pbadv_setup_101010_Lancelot(3,true,24,5,0)
    
    
    pbadv_setup_101012_Dinatan(1,true,24,10,0)
    
    
	pbadv_setup_101051_Lucius(0,true,23,11,0)
	
	
	pbadv_setup_101022_Mordred(0,true,25,10 ,0)  
	
	
	pbadv_setup_101023_Clarice(1,true,25,11,0)
	
	
    pbadv_setup_101017_Maladisant(1,true,24,11,0)
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

	
	
	
		
	
	
	
	
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotLancelot3, 2)

	
	
	
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotDinatan1, false)
	dot_disp_weapon(dotLucius, false)
	dot_disp_weapon(dotMordred, false)
	dot_disp_weapon(dotClarice1, false)
	dot_disp_weapon(dotMaladisant1, false)

	
	
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(24, 8, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370002")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_370003")
	close_speech_window()

	
	change_face(Dinatan1, "Smile")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_370004")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370005")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_370006")
	close_speech_window()

	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370008")
	close_speech_window()

	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_370009")
	close_speech_window()

	
	change_face(Lancelot3, "Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370010")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_370011")
	close_speech_window()

	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_370012")
	

	
	change_face(Dinatan1, "Sad")
	
	message("MA_01C112_370013")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370014")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_370015")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_370016")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370017")
	close_speech_window()

	se_play("SE_ADV_MA_01B111_03_Sword")
	
	wait_time(0.3)
	
	dot_disp_weapon(dotLancelot3, true)
	wait_time(2.0)
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_370019")
	close_speech_window()
	
	
	change_face(Mordred, "Anger")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C112_370020")
	close_speech_window()

	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370022")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_370023")
	

	
	change_face(Lancelot3, "Anger")
	
	message("MA_01C112_370024")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_370025")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370026")
	

	
	change_face(Lancelot3, "Sad")
	
	message("MA_01C112_370027")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_370028")
	close_speech_window()
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Noir2, "Surprise", nil)
	on_cutin(2, Lancelot3, "Anger", nil)

	
	change_face(Lancelot3, "Anger")
	open_speech_window("CHRNAME_LANCELOT",nil , nil)
	message("MA_01C112_370029")
	

	
	change_face(Lancelot3, "Anger")
	
	message("MA_01C112_370030")
	close_speech_window()
	
	

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",nil , nil)
	message("MA_01C112_370031")
	close_speech_window()
	
	
	close_cutin()
	wait_time(0.5)

	
	change_face(Lancelot3, "Anger")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370032")
	



	
	change_face(Lancelot3, "Anger")
	
	message("MA_01C112_370033")
	close_speech_window()

	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_370034")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370035")
	close_speech_window()

	
	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_370037")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370038")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_370039")
	close_speech_window()

	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_370040")
	

	
	change_face(Dinatan1, "Anger")
	
	message("MA_01C112_370041")
	close_speech_window()

	
	change_face(Lancelot3, "Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370042")
	

	
	change_face(Lancelot3, "Sad")
	
	message("MA_01C112_370043")
	close_speech_window()

	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_370044")
	close_speech_window()
	
	dot_disp_weapon(dotMaladisant1, true)
	
	dot_reserve_move_unit_seq(dotLancelot3,24, 8)
	dot_reserve_move_unit_seq(dotMaladisant1,24, 9)
	exec_parallel_seq()
	wait_seq()
	
	
	dot_change_anim(dotLancelot3,3)
	dot_change_anim(dotMaladisant1,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	dot_play_particle_unit(dotMaladisant1,"Ef_C_Axe_N_Atk01",3,true)

	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.2)
	
	dot_move_knockback(dotLancelot3,24, 6,0.4,2)
	wait_time(0.4)

	dot_unit_dir(dotLancelot3, 2)
	dot_change_anim(dotLancelot3,0)
	dot_change_anim(dotMaladisant1,0)
	
	
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370046")
	close_speech_window()

	
	change_face(Maladisant1, "Anger")
	open_speech_window("CHRNAME_MALADISANT2",Maladisant1 , nil)
	message("MA_01C112_370047")
	close_speech_window()
	
	wait_seq()

	
	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C112_370049")
	
	
	dot_disp_weapon(dotClarice1, true)
	dot_disp_weapon(dotMordred, true)
	
	dot_reserve_move_unit_seq(dotMordred,25, 8)
	dot_reserve_move_unit_seq(dotClarice1,25, 9)
	exec_parallel_seq()
	wait_seq()
	

	
	change_face(Mordred, "Anger")
	
	message("MA_01C112_370050")
	close_speech_window()
	
	dot_disp_weapon(dotLucius, true)
	dot_move_unit_seq(dotLucius,23, 8)
	wait_seq()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C112_370051")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370052")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_370053")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370054")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01C112_370055")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_370056")
	close_speech_window()

	
	change_face(Lancelot3, "Serious")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C112_370057")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,23,10,0)
    pbadv_setup_101010_Lancelot_preload(3,true,24,5,0)
    pbadv_setup_101012_Dinatan_preload(1,true,24,10,0)
	pbadv_setup_101051_Lucius_preload(0,true,23,11,0)
	pbadv_setup_101022_Mordred_preload(0,true,25,10 ,0)
	pbadv_setup_101023_Clarice_preload(1,true,25,11,0)
    pbadv_setup_101017_Maladisant_preload(1,true,24,11,0)
end
