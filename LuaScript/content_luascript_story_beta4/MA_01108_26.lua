Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(3,7) 
	
	
	
	
	pbadv_setup_101042_Moronoe(true,27 ,23 ,0)  
	
	
	pbadv_setup_101043_Mazoe(true,25 ,23 ,0)  
	
	 
	pbadv_setup_101058_Laiens(1,true,23 ,24 ,0)
	pbadv_setup_101058_Laiens(0,true,1 ,8 ,0)
	
	
	pbadv_setup_101050_Brian(0,true,26 ,24 ,0) 

    
	
	
	
	barbaroi  = dot_reserve_enemy(3,23 ,21 , 0)
	barbaroi1  = dot_reserve_enemy(3,24 ,21 , 0)
	barbaroi2 = dot_reserve_enemy(3,25 ,21 , 0)
	barbaroi3 = dot_reserve_enemy(3,26 ,21 , 0)
	barbaroi4 = dot_reserve_enemy(3,27 ,21 , 0)
	barbaroi5 = dot_reserve_enemy(3,22 ,24 , 0)
	barbaroi6 = dot_reserve_enemy(3,29 ,24 , 0)
	barbaroi7 = dot_reserve_enemy(3,22 ,25 , 0)
	barbaroi8 = dot_reserve_enemy(3,29 ,25 , 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotBrian, 2)
	dot_unit_dir(dotMazoe, 3)
	
	dot_unit_dir(barbaroi , 3)
	dot_unit_dir(barbaroi1, 3)
	dot_unit_dir(barbaroi2, 3)
	dot_unit_dir(barbaroi5, 3)
	dot_unit_dir(barbaroi7, 3)


	
	
	
	dot_disp_unit(dotLaiens, false)

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(25, 24, 0.0)
	
	Ef_changeBriF = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260002")
	close_speech_window()

	
	change_face(Brian, "Sad")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260003")
	close_speech_window()

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260004")
	

	
	change_face(Laiens1, "Normal")
	
	message("MA_01108_260005")
	

	
	change_face(Laiens1, "Anger")
	
	message("MA_01108_260006")
	close_speech_window()

	
	change_face(Brian, "Normal")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260007")
	close_speech_window()
	
	dot_change_anim(dotMazoe,3)
	dot_damage_seq(dotBrian,dotMazoe,true)
	wait_seq()
	dot_change_anim(dotBrian,1)
	dot_change_anim(dotMazoe,0)
	move_camera(25, 24, 1.0)
	
	change_face(Brian, "Pain")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260009")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil , Moronoe)
	message("MA_01108_260010")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2",nil , Mazoe)
	message("MA_01108_260011")
	close_speech_window()

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260012")
	

	
	change_face(Laiens1, "Anger")
	
	message("MA_01108_260013")
	

	
	change_face(Laiens1, "Anger")
	
	message("MA_01108_260014")
	

	
	change_face(Laiens1, "Anger")
	
	message("MA_01108_260015")
	close_speech_window()

	
	change_face(Brian, "Sad")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260016")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil , Moronoe)
	message("MA_01108_260017")
	close_speech_window()

	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260018")
	close_speech_window()

	
	change_face(Brian, "Sad")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260019")
	

	
	change_face(Brian, "Sad")
	
	message("MA_01108_260020")
	

	
	change_face(Brian, "Smile")
	
	message("MA_01108_260021")
		
	dot_change_anim(dotBrian,1)
	dot_move_unit_seq(dotBrian,25, 24)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(dotMazoe, 2)

	
	change_face(Brian, "Normal")
	
	message("MA_01108_260022")
	close_speech_window()
	
	
	
	change_face(Laiens1, "Sad")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260024")
	close_speech_window()

	
	change_face(Brian, "Anger")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260026")
	close_speech_window()

	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260027")
	close_speech_window()

	
	change_face(Brian, "Anger")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260028")
	close_speech_window()

	
	change_face(Laiens, "Anger")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260029")
	

	
	change_face(Laiens, "Surprise")
	
	message("MA_01108_260030")
	close_speech_window()
	
	dot_change_anim(dotLaiens1,1)

	change_face(Brian, "Surprise")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260031")
	close_speech_window()
	
	wait_time(1.5)
	
	on_active(Ef_changeBriF)

	local gridpos = get_grid_position(23,24)
	set_pos(Ef_changeBriF , gridpos)
	play_particle(Ef_changeBriF )
	dot_change_anim(dotLaiens1,0)
	
	wait_time(1.5)
	

	
	change_face(Laiens1, "Smile")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260032")
	close_speech_window()

	
	change_face(Brian, "Anger")
	open_speech_window("CHRNAME_BRIAN",Brian , nil)
	message("MA_01108_260033")
	close_speech_window()

	
	change_face(Laiens1, "Smile")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_260034")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101042_Moronoe_preload(true,27 ,23 ,0)
	pbadv_setup_101043_Mazoe_preload(true,25 ,23 ,0)
	pbadv_setup_101058_Laiens_preload(1,true,23 ,24 ,0)
	pbadv_setup_101058_Laiens_preload(0,true,1 ,8 ,0)
	pbadv_setup_101050_Brian_preload(0,true,26 ,24 ,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
end
