


Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201000001", "201000001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 5, 21,0)  
	pbadv_setup_101011_Guinevere(1,true, 5, 20,0)  

	pbadv_setup_101021_Bruno(1,true, 1, 20,0)  


	pbadv_setup_101001_Tyrfing(1,true, 2, 21,0)  

	pbadv_setup_101010_Lancelot(3,true, 2, 19,0)  
	pbadv_setup_101012_Dinatan(0,true, 2, 20,0)  

	pbadv_setup_101016_Gwenhwymawr(1,true, 1, 17,0)  
	pbadv_setup_101017_Maladisant(1,true, 1, 18,0)  

	pbadv_setup_101058_Laiens(1,true, 8, 20,0)  


	
	
	

	barbaroi3 = dot_reserve_enemy(1, 8, 19, 0) 
	barbaroi4 = dot_reserve_enemy(1, 8, 22, 0) 
	barbaroi5 = dot_reserve_enemy(1, 9, 17, 0) 
	barbaroi6 = dot_reserve_enemy(1, 9, 21, 0) 
	barbaroi7 = dot_reserve_enemy(42, 10, 18, 0) 
	barbaroi8 = dot_reserve_enemy(49, 11, 21, 0) 

	barbaroi9 = dot_reserve_enemy(42, 10, 22, 0) 
	barbaroi10 = dot_reserve_enemy(49, 11, 19, 0) 
	barbaroi11 = dot_reserve_enemy(42, 10, 20, 0) 

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	

	
	dot_unit_dir(dotLaiens1,2)


	
	

	
	
		

	dot_change_anim(dotBruno1,1)
	dot_change_anim(dotMaladisant1,1)
	dot_change_anim(dotGwenhwymawr1,1)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(40.0, 0.0)

	
	
	move_camera(6, 21, 0.0)

	
	Ef_Lake = load_particle("content_effect3d_common_adv", "Ef_C_Adv_LakeColor_syoku_Lop", false, true)

	on_active(Ef_Lake) 
	play_particle(Ef_Lake)

	Ef_Sanc = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Sanctuary_Lake", false, true)

	Ef_Aura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)

end





function Play()
	fadein(0)
	Play_start(true)


	
	
	wait_time(0.5)

	on_active(Ef_Aura) 
	local gridpos = get_grid_position(5, 20)
	set_pos(Ef_Aura, gridpos)
	play_particle(Ef_Aura)

	wait_time(1.0)
	
	on_active(Ef_Sanc) 
	local gridpos = get_grid_position(20, 20)
	set_pos(Ef_Sanc, gridpos)
	play_particle(Ef_Sanc)

	wait_time(0.5)

	stop_particle(Ef_Lake)
	
	wait_time(1.0)

	stop_particle(Ef_Aura)

	wait_time(1.0)

	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_520002")
	close_speech_window()

	
	
	dot_change_anim(dotNoir2,12)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_520004")
	close_speech_window()

	
	open_cutin(1,1)

	
	on_cutin(1,Noir2,"Serious") 

	
	
	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01108_520005")
	close_speech_window()

	
	close_cutin()
	

	
	change_face(Laiens1, "Surprise")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_520007")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_520008")
	close_speech_window()

	dot_change_anim(dotGuinevere1,12)

	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01108_520012")
	close_speech_window()

	

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_520016")
	close_speech_window()

	
	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 5, 21,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 5, 20,0)
	pbadv_setup_101021_Bruno_preload(1,true, 1, 20,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 2, 21,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 2, 19,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 2, 20,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 1, 17,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 1, 18,0)
	pbadv_setup_101058_Laiens_preload(1,true, 8, 20,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_LakeColor_syoku_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Sanctuary_Lake", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)
end
