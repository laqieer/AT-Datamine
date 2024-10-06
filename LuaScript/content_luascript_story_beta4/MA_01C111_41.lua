

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201090100", "201090100")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101051_Lucius(0,true,12,3,0)
		
	pbadv_setup_101042_Moronoe(true,15,3,0)  
	pbadv_setup_101044_Gliten(true,14,4,0) 
	pbadv_setup_101049_Thiton(true,14,2,0)  

    pbadv_setup_101009_Noir(2,true,3,2,0)	 
    pbadv_setup_101012_Dinatan(1,true,4,1,0)	
	
	pbadv_setup_101022_Mordred(0,true,4,2,0) 
	pbadv_setup_101023_Clarice(0,true,4,3,0)
	pbadv_setup_101052_Vernarth(0,true,3,4,0)
	pbadv_setup_101037_Rasia(3,true,3,5,0)
	pbadv_setup_101039_Fren(0,true,3,1,0)
	
	
	barubaroi1 = dot_reserve_enemy(603, 17, 1, 0)
	barubaroi2 = dot_reserve_enemy(1101, 17, 2, 0)
	barubaroi3 = dot_reserve_enemy(42, 17, 3, 0)
	barubaroi4 = dot_reserve_enemy(1101, 17, 4, 0)
	barubaroi5 = dot_reserve_enemy(603, 17, 5, 0)

	
	setup_complete_unit()
	
	
	dot_disp_unit(dotNoir2,false)	
	dot_disp_unit(dotDinatan1,false)	
	dot_disp_unit(dotMordred,false)	
	dot_disp_unit(dotClarice,false)
	dot_disp_unit(dotVernarth,false)	
	dot_disp_unit(dotRasia3,false)	
	dot_disp_unit(dotFren,false)	
	
	load_image("10203007",  "content_still_10203007_image", "102030070_StillImage")
	show_image("10203007", 0.0, 0.0, 0 ,true,false)		
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(14, 3, 0.0)

	load_sound("BGM_Battle_Running_FI")
end



function Play()
	fadein(0)
	Play_start(true)
	
	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)		
	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01C111_410002")
	close_speech_window()

	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01C111_410004")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01C111_410005")
	close_speech_window()

	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_410007")
	close_speech_window()

	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01C111_410009")
	close_speech_window()

	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_410010")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")

	bgm_play("BGM_Battle_Running_FI")

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01C111_410011")
	close_speech_window()
	
	move_camera(13, 3, 0.5)	
	
	dot_disp_unit(dotNoir2,true)	
	dot_disp_unit(dotDinatan1,true)	
	dot_disp_unit(dotVernarth,true)	
	dot_disp_unit(dotRasia3,true)	
	dot_disp_unit(dotFren,true)	
	
	dot_reserve_move_unit_seq(dotNoir2, 12, 2)
	dot_reserve_move_unit_seq(dotDinatan1, 12, 1)
	dot_reserve_move_unit_seq(dotVernarth, 12, 4)
	dot_reserve_move_unit_seq(dotRasia3, 11, 1)
	dot_reserve_move_unit_seq(dotFren, 11, 4)
	exec_parallel_seq()
	wait_seq()
	
	
	
	change_face(Lucius, "Surprise")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_410013")
	close_speech_window()

	
	change_face(Vernarth, "Sad")
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_410014")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01C111_410015")
	
	change_face(Moronoe, "Smile")
	message("MA_01C111_410016")
	close_speech_window()

	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01C111_410017")
	close_speech_window()

	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_410018")
	close_speech_window()

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C111_410019")
	close_speech_window()
	
	
	dot_disp_unit(dotMordred,true)	
	dot_disp_unit(dotClarice,true)
	
	dot_reserve_move_unit_seq(dotMordred, 11, 2)
	dot_reserve_move_unit_seq(dotClarice, 11, 3)
	exec_parallel_seq()
	wait_seq()
	

	
	change_face(Clarice, "Normal")
	open_speech_window("CHRNAME_CLARICE", Clarice, nil)
	message("MA_01C111_410021")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01C111_410022")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_410024")
	close_speech_window()

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C111_410025")
	close_speech_window()

	
	change_face(Clarice, "Normal")
	open_speech_window("CHRNAME_CLARICE", Clarice, nil)
	message("MA_01C111_410027")
	close_speech_window()

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C111_410028")
	close_speech_window()

	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_410029")
	close_speech_window()

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C111_410030")
	close_speech_window()

	
	change_face(Clarice, "Normal")
	open_speech_window("CHRNAME_CLARICE", Clarice, nil)
	message("MA_01C111_410032")
	close_speech_window()

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C111_410033")
	
	change_face(Mordred, "Smile")
	message("MA_01C111_410035")
	close_speech_window()

	
	change_face(Dinatan1, "Anger")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C111_410037")
	close_speech_window()

	
	change_face(Clarice, "Smile")
	open_speech_window("CHRNAME_CLARICE", Clarice, nil)
	message("MA_01C111_410039")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C111_410040")
	
	change_face(Noir2, "Normal")
	message("MA_01C111_410041")
	close_speech_window()

	
	change_face(Clarice, "Smile")
	open_speech_window("CHRNAME_CLARICE", Clarice, nil)
	message("MA_01C111_410043")
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101051_Lucius_preload(0,true,12,3,0)
	pbadv_setup_101042_Moronoe_preload(true,15,3,0)
	pbadv_setup_101044_Gliten_preload(true,14,4,0)
	pbadv_setup_101049_Thiton_preload(true,14,2,0)
    pbadv_setup_101009_Noir_preload(2,true,3,2,0)
    pbadv_setup_101012_Dinatan_preload(1,true,4,1,0)
	pbadv_setup_101022_Mordred_preload(0,true,4,2,0)
	pbadv_setup_101023_Clarice_preload(0,true,4,3,0)
	pbadv_setup_101052_Vernarth_preload(0,true,3,4,0)
	pbadv_setup_101037_Rasia_preload(3,true,3,5,0)
	pbadv_setup_101039_Fren_preload(0,true,3,1,0)
	load_image_preload("10203007",  "content_still_10203007_image", "102030070_StillImage")
	preload_sound("BGM_Battle_Running_FI")
end
