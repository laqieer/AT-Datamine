Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(1,2)
	


	pbadv_setup_101028_Galahad(2,true,23,19,0)  

	pbadv_setup_101029_Astera(1,true,23,20,0) 
	
    pbadv_setup_101010_Lancelot(3,true,22,29,0)    

    pbadv_setup_101009_Noir(2,true,24,29,0)    
	
    pbadv_setup_101001_Tyrfing(1,true,24,30,0)  
    
    pbadv_setup_101011_Guinevere(0,true,22,30,0)  
    
    pbadv_setup_101012_Dinatan(0,true,23,30,0)    
    
	
	barbaroi1 = dot_reserve_ally(401038001,26,19,0)
	dot_set_weapon(barbaroi1, 105010001)
	barbaroi2 = dot_reserve_ally(401038001,26,20,0)
	dot_set_weapon(barbaroi2, 105010001)
	barbaroi3 = dot_reserve_ally(401038001,25,18,0)
	dot_set_weapon(barbaroi3, 105010001)
	barbaroi4 = dot_reserve_ally(401038001,24,17,0)
	dot_set_weapon(barbaroi4, 105010001)
	barbaroi5 = dot_reserve_ally(401038001,23,16,0)
	dot_set_weapon(barbaroi5, 105010001)
	barbaroi6 = dot_reserve_ally(401038001,22,17,0)
	dot_set_weapon(barbaroi6, 105010001)
	barbaroi7 = dot_reserve_ally(401038001,21,18,0)
	dot_set_weapon(barbaroi7, 105010001)
	
    barbaroi11 = dot_reserve_enemy(42,20,19,0)
	barbaroi12 = dot_reserve_enemy(42,20,20,0)
	barbaroi13 = dot_reserve_enemy(42,21,21,0)
	barbaroi14 = dot_reserve_enemy(42,22,22,0)
	barbaroi15 = dot_reserve_enemy(42,23,23,0)
	barbaroi16 = dot_reserve_enemy(42,24,22,0)
	barbaroi17 = dot_reserve_enemy(42,25,21,0)
	
	
	setup_complete_unit()
	
	

	
	dot_unit_dir(barbaroi1 ,2)
	dot_unit_dir(barbaroi2 ,2)
	dot_unit_dir(barbaroi3 ,2)
	dot_unit_dir(barbaroi4 ,2)
	dot_unit_dir(barbaroi5 ,3)
	dot_unit_dir(barbaroi6 ,3)
	dot_unit_dir(barbaroi7 ,3)
	dot_unit_dir(barbaroi11,3)
	dot_unit_dir(barbaroi12,3)
	dot_unit_dir(barbaroi13,3)
	dot_unit_dir(barbaroi14,3)
	dot_unit_dir(barbaroi15,2)
	dot_unit_dir(barbaroi16,2)
	dot_unit_dir(barbaroi17,2)

	
	dot_disp_unit(dotDinatan, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(23, 20, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01107_320002")
	OpenFirstAppearance(Galahad2)
	close_speech_window()


	dot_reserve_move_unit_seq(dotLancelot3 , 22,23)
	dot_reserve_move_unit_seq(dotNoir2, 24,23)
	dot_reserve_move_unit_seq(dotGuinevere, 22,24)
	dot_reserve_move_unit_seq(dotTyrfing1, 24,24)
	dot_reserve_move_unit_seq(dotDinatan, 23,25)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotGuinevere, 0)
	dot_unit_dir(dotTyrfing1, 0)
	dot_unit_dir(dotDinatan, 0)


	dot_unit_dir(dotLancelot3,3)
	dot_unit_dir(dotNoir2,2)
	
	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(barbaroi15,6)
	
	wait_time(0.2)
	
	dot_dying_unit_seq(barbaroi15) 
	
	wait_seq()
	
	dot_unit_dir(dotLancelot3 , 0)
	dot_unit_dir(dotNoir2 , 0)
	
	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.2)
	
	dot_play_particle_unit(barbaroi16,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi14,"Ef_C_Cmn_DieEmy01",2,true)
	
	wait_time(0.5)
	
	dot_remove_unit(barbaroi14)
	dot_remove_unit(barbaroi16)
	
	wait_time(0.5)
	
	
	move_camera(23, 18, 2.0)
	
	dot_reserve_move_unit_seq(dotLancelot3 , 22,19)
	dot_reserve_move_unit_seq(dotNoir2, 24,19)
	dot_reserve_move_unit_seq(dotGuinevere, 22,20)
	dot_reserve_move_unit_seq(dotTyrfing1, 24,20)
	dot_reserve_move_unit_seq(dotDinatan, 23,21)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotLancelot3 , 2)
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotDinatan, 0)

	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01107_320004")
	close_speech_window()

	


	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01107_320006")



	change_face(Galahad2, "Normal")
	message("MA_01107_320007")
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101028_Galahad_preload(2,true,23,19,0)
	pbadv_setup_101029_Astera_preload(1,true,23,20,0)
    pbadv_setup_101010_Lancelot_preload(3,true,22,29,0)
    pbadv_setup_101009_Noir_preload(2,true,24,29,0)
    pbadv_setup_101001_Tyrfing_preload(1,true,24,30,0)
    pbadv_setup_101011_Guinevere_preload(0,true,22,30,0)
    pbadv_setup_101012_Dinatan_preload(0,true,23,30,0)
end
