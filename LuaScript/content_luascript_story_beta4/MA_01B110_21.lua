
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201060001", "201060001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true,26,23,0)  
	pbadv_setup_101036_Viena(1,true,26,22,0)  

	pbadv_setup_101028_Galahad(1,true,20,20,0)  

	pbadv_setup_101026_Percival(0,true,20,23,0)  
	pbadv_setup_101027_Dindrane(1,true,20,22,0)  

	pbadv_setup_101034_Excelia(1,true,30,22,0)  
	pbadv_setup_101054_Adam(2,true,29,23,0)  

	pbadv_setup_101048_Thiten(true,22,20,0)  
	
	
	
	barbaroi = dot_reserve_enemy(1200, 21, 19, 0)
	barbaroi2 = dot_reserve_enemy(1200, 21, 21, 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotExcelia1, 2)
	dot_unit_dir(dotAdam2, 2)
	
	
	dot_disp_unit(dotPercival, false)
	dot_disp_unit(dotDindrane1, false)
	
	
	
	
	change_camera_distance(6.0, 0.0)

	
	
	change_camera_angle(50.0, 0.0)

	
	
	move_camera(28, 23, 0.0)

	
	Ef_WitchDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)

	load_sound("BGM_Battle_Nature_Start")


end





function Play()
	fadein(0)
	Play_start(true)



	
	
	dot_change_anim(dotAdam2,3)
	dot_play_particle_unit(dotAdam2,"Ef_C_Bow_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.3)

	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotAdam2,0)

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210002")
	close_speech_window()
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_210003")
	close_speech_window()
	
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210004")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dotNoir2, 27, 23)
	dot_reserve_move_unit_seq(dotAdam2, 28, 23)
	exec_parallel_seq()
	
	wait_seq()

	
	
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotAdam2,6)
	dot_play_particle_unit(dotAdam2,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	
	wait_time(0.3)

	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotAdam2,0)

	
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210006")
	close_speech_window()
		
	
	change_face(Adam2, "Normal")
	open_speech_window("CHRNAME_ADAM",  nil, Adam2)
	message("MA_01B110_210007")
	close_speech_window()
	
	dot_target_attack(dotNoir2,dotAdam2)
	dot_change_anim(dotAdam2,6)

	dot_move_knockback(dotAdam2, 29, 23, 0.3, 2)

	wait_time(0.3)

	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotAdam2,1)
	
	
	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B110_210008")
	close_speech_window()
	
	
	dot_change_anim(dotViena1,3)
	dot_play_particle_unit(dotViena1,"Ef_C_Mag_T_Atk01",3,true)
	
	wait_time(0.3)

	dot_damage_seq(dotExcelia1,dotViena1,false)

	wait_seq()
	
	dot_change_anim(dotViena1,0)
	dot_change_anim(dotExcelia1,1)

	wait_time(0.5)
	
	
	
	change_face(Excelia1, "Pain")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_210010")
	close_speech_window()
	
	move_camera(21, 20, 0.5)
	
	wait_camera()


	dot_change_anim(dotGalahad1,3)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(barbaroi,3)
	dot_play_particle_unit(barbaroi,"Ef_C_Ham_N_EmyAtk01",3,true)

	dot_change_anim(barbaroi2,3)
	dot_play_particle_unit(barbaroi2,"Ef_C_Ham_N_EmyAtk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotGalahad1,6)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Cmn_N_Hit_EmyStr01",1,true)
	dot_move_knockback(dotGalahad1, 19, 20, 0.2, 2)

	wait_time(0.2)

	dot_change_anim(dotGalahad1,0)
	dot_change_anim(barbaroi,0)
	dot_change_anim(barbaroi2,0)


	
	change_face(Thiten, "Smile")
	open_speech_window("CHRNAME_SISTERS_7",  nil, Thiten)
	message("MA_01B110_210012")
	close_speech_window()
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210013")
	close_speech_window()
	
	
	
	
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01B110_210015")
	close_speech_window()
	
	
	
	change_face(Thiten, "Anger")
	open_speech_window("CHRNAME_SISTERS_7",  nil, Thiten)
	message("MA_01B110_210016")
	close_speech_window()
	
	
	
	
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01B110_210018")
	close_speech_window()
	
	
	
	
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01B110_210020")
	close_speech_window()
	
	
	
	
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01B110_210022")
	
	
	
	
	
	message("MA_01B110_211001")
	close_speech_window()

	
	
	dot_change_anim(barbaroi,6)
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_N_Hit_Spe01",3,true)

	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Spe01",3,true)

	wait_time(0.2)
	
	
	
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_DieEmy01",2,true)

	
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi, false)
	dot_disp_unit(barbaroi2, false)

	dot_remove_unit(barbaroi)
	dot_remove_unit(barbaroi2)
	
	
	dot_disp_unit(dotDindrane1, true)

	dot_reserve_move_unit_seq(dotDindrane1, 20, 19)
	exec_parallel_seq()
	
	wait_seq()
	
	dot_unit_dir(dotDindrane1, 3)


	
	
	change_face(Dindrane1, "Normal")
	open_speech_window("CHRNAME_DINDRANE2",  Dindrane1, nil)
	message("MA_01B110_210024")
	close_speech_window()
	
	
	
	dot_disp_unit(dotPercival, true)
	dot_reserve_move_unit_seq(dotPercival, 20, 21)
	exec_parallel_seq()
	
	wait_seq()
	

	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210026")
	close_speech_window()
	
	
	change_face(Excelia1, "Anger")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_210027")
	close_speech_window()
	
	
	
	
	
	change_face(Thiten, "Anger")
	open_speech_window("CHRNAME_SISTERS_7",  nil, Thiten)
	message("MA_01B110_210029")
	close_speech_window()
	
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210030")
	close_speech_window()
	
	
	
	dot_move_unit_seq(dotGalahad1,21, 20)

	
	dot_attack_seq(dotGalahad1,dotThiten)
	dot_damage_seq(dotThiten,dotGalahad1,false)

	wait_seq()

	dot_change_anim(dotGalahad1,0)
	dot_change_anim(dotThiten,6)

	
	change_face(Thiten, "Anger")
	open_speech_window("CHRNAME_SISTERS_7",  nil, Thiten)
	message("MA_01B110_210032")
	close_speech_window()

	dot_change_anim(dotThiten,1)
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210033")
	close_speech_window()
	
	
	
	change_face(Thiten, "Smile")
	open_speech_window("CHRNAME_SISTERS_7",  nil, Thiten)
	message("MA_01B110_210035")
	close_speech_window()

	bgm_play("BGM_Battle_Nature_Start")
	
	
	on_active(Ef_WitchDie) 

	local gridpos = get_grid_position(22, 20)
	set_pos(Ef_WitchDie, gridpos)
	play_particle(Ef_WitchDie)

	wait_time(1.0)

	dot_disp_unit(dotThiten, false)
	dot_remove_unit(dotThiten)

	wait_time(2.0)
	
	
	dot_change_anim(dotPercival,0)
	dot_change_anim(dotGalahad1,0)
	dot_change_anim(dotDindrane1,0)

	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210037")
	close_speech_window()
	
	dot_disp_weapon(dotPercival, false)
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotViena1, false)
	dot_disp_weapon(dotGalahad1, false)
	dot_disp_weapon(dotDindrane1, false)
		
	dot_reserve_move_unit_seq(dotNoir2,25, 22)
	exec_parallel_seq()

	dot_reserve_move_unit_seq(dotNoir2,22, 19)
	dot_reserve_move_unit_seq(dotViena1,22, 21)

	exec_parallel_seq()
	wait_seq()

	dot_disp_unit(dotAdam2, false)
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotViena1, 2)
	dot_unit_dir(dotGalahad1, 2)


	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210038")
	close_speech_window()
	
	
	change_face(Percival, "Smile")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210039")
	
	
	
	change_face(Percival, "Smile")
	
	message("MA_01B110_210040")
	close_speech_window()
	
	
	change_face(Viena1, "Surprise")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B110_210041")
	close_speech_window()
		
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210042")
	close_speech_window()
	
	
	change_face(Dindrane1, "Sad")
	open_speech_window("CHRNAME_DINDRANE2",  Dindrane1, nil)
	message("MA_01B110_210043")
	close_speech_window()
	
	
	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210045")
	close_speech_window()
	
	
	dot_disp_weapon(dotExcelia1, false)

	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_210047")
	close_speech_window()
	
	dot_move_unit_seq(dotExcelia1,24, 22)
	wait_seq()
	dot_unit_dir(dotExcelia1, 2)
	
	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotViena1, 3)
	dot_unit_dir(dotGalahad1, 3)

	
	change_camera_distance(8.0, 1.0)
	move_camera(22, 22, 1.0)

	wait_camera()


	
	
	change_face(Viena1, "Normal")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B110_210049")
	close_speech_window()
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_210050")
	close_speech_window()
	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210051")
	close_speech_window()
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_210053")
	close_speech_window()
	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210054")
	close_speech_window()
	
	
	change_face(Dindrane1, "Normal")
	open_speech_window("CHRNAME_DINDRANE2",  Dindrane1, nil)
	message("MA_01B110_210055")
	
	
	
	
	change_face(Dindrane1, "Anger")
	
	message("MA_01B110_210056")
	close_speech_window()
	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210057")
	
	
	
	
	
	
	  MA_01B110_21_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B110_210058", "MA_01B110_210059")  
	close_speech_window()
 
     if is_select(1) then            
        MA_01B110_21_select1_1()

    else                            
        MA_01B110_21_select1_2()

    end
    MA_01B110_21_end()
 
	end
 
	function MA_01B110_21_select1()
 
	end
 
	function MA_01B110_21_select1_1()
 
	
 
	
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210061")
	close_speech_window()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210062")
	close_speech_window()
	
	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210063")
	close_speech_window()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210064")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210065")
	close_speech_window()
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210066")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210067")
	close_speech_window()
	
	
	change_face(Percival, "Sad")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210068")
	
 
 	
	change_face(Percival, "Normal")
	
	message("MA_01B110_210079")
	
 
      
	end
 
 
	function MA_01B110_21_select1_2()
 

 
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210070")
	close_speech_window()
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210071")
	close_speech_window()
	
	
	change_face(Excelia1, "Sad")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_210072")
	close_speech_window()
	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210073")
	close_speech_window()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210074")
	close_speech_window()
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_210075")
	close_speech_window()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD",  Galahad1, nil)
	message("MA_01B110_210076")
	
	
	
	change_face(Galahad1, "Sad")
	
	message("MA_01B110_210077")
	close_speech_window()
	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL",  Percival, nil)
	message("MA_01B110_210079")
	
 
    
	end
 
 

 
	function MA_01B110_21_end()
 
	
	
	
	
	
	
	change_face(Percival, "Normal")
	
	message("MA_01B110_210080")
	close_speech_window()
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_210081")
	close_speech_window()
	




	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,26,23,0)
	pbadv_setup_101036_Viena_preload(1,true,26,22,0)
	pbadv_setup_101028_Galahad_preload(1,true,20,20,0)
	pbadv_setup_101026_Percival_preload(0,true,20,23,0)
	pbadv_setup_101027_Dindrane_preload(1,true,20,22,0)
	pbadv_setup_101034_Excelia_preload(1,true,30,22,0)
	pbadv_setup_101054_Adam_preload(2,true,29,23,0)
	pbadv_setup_101048_Thiten_preload(true,22,20,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	preload_sound("BGM_Battle_Nature_Start")
end
