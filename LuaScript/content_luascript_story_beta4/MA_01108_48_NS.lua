Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")
Include("content_luascript_system", "BranchSelect")



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201000001", "201000001")
	change_time_and_weather(1,2)
	
	
	
	pbadv_setup_101009_Noir(2,true, 3, 19,0)  
	pbadv_setup_101001_Tyrfing(1,true, 6, 19,0)  

	pbadv_setup_101011_Guinevere(0,true, 5, 15,0)  
	pbadv_setup_101010_Lancelot(3,true, 4, 17,0)  
	pbadv_setup_101012_Dinatan(0,true, 3, 16,0)  

	pbadv_setup_101021_Bruno(1,true, 1, 17,0)  

	pbadv_setup_101016_Gwenhwymawr(1,true, 5, 13,0)  
	pbadv_setup_101017_Maladisant(1,true, 6, 13,0)  

	pbadv_setup_101058_Laiens(1,true, 11, 19,0)  

	pbadv_setup_101015_Arthur(0,true, 2, 27,0)  
	pbadv_setup_101020_Merlin(0,true, 2, 28,0)  

	pbadv_setup_101042_Moronoe(true, 8, 19, 0)  
	pbadv_setup_101043_Mazoe(true, 8, 17, 0)  

	pbadv_setup_101044_Gliten(true, 10, 17,0) 
	pbadv_setup_101045_Glitonea(true, 10, 19,0) 
	pbadv_setup_101046_Gliton(true, 10, 21,0) 

	pbadv_setup_101047_Tyronoe(true, 8, 21,0) 
	pbadv_setup_101048_Thiten(true, 9, 18,0)  
	pbadv_setup_101049_Thiton(true, 9, 20,0)  

	
	
	
	
	barbaroi2 = dot_reserve_enemy(1, 5, 21, 0)
	barbaroi3 = dot_reserve_enemy(1301, 7, 22, 0)
	barbaroi4 = dot_reserve_enemy(42, 7, 16, 0)
	barbaroi5 = dot_reserve_enemy(49, 8, 13, 0)

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	

	
	dot_unit_dir(dotLaiens1,2)


	
	
	dot_disp_weapon(dotNoir2, false) 

	
	
	dot_disp_unit(dotArthur, false)
	dot_disp_unit(dotMerlin, false)

	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotGliton, false)
	dot_disp_unit(dotTyronoe, false)
	dot_disp_unit(dotThiten, false)
	dot_disp_unit(dotThiton, false)

	dot_change_anim(dotNoir2,1)

	dot_change_anim(dotLancelot3,1)
	dot_change_anim(dotGuinevere,1)
	dot_change_anim(dotDinatan,1)

	dot_change_anim(dotGwenhwymawr1,1)
	dot_change_anim(dotMaladisant1,1)

	dot_change_anim(dotBruno1,1)

	
	
	dot_move_height(dotMoronoe, 5.0, 0, 0)
	dot_move_height(dotMazoe, 5.0, 0, 0)
	dot_move_height(dotGliten, 5.0, 0, 0)
	dot_move_height(dotGlitonea, 5.0, 0, 0)
	dot_move_height(dotGliton, 5.0, 0, 0)
	dot_move_height(dotTyronoe, 5.0, 0, 0)
	dot_move_height(dotThiten, 5.0, 0, 0)
	dot_move_height(dotThiton, 5.0, 0, 0)


	
	
	
	change_camera_distance(7.0, 0.0)

	
	
	change_camera_angle(34.0, 0.0)

	
	
	move_camera(4, 19, 0.0)

	
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_BlFeather1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)

	Ef_SwordWind = load_particle("content_effect3d_common_adv", "Ef_C_Adv_SwordWind", false, true)

	Ef_Vanish = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)

	Ef_Lake = load_particle("content_effect3d_common_adv", "Ef_C_Adv_LakeColor_syoku_Lop", false, true)

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	Ef_Emblem3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)

	movie_load("MA_01108_48_1")

	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image("101010140_2", "content_still_10101014_image", "101010140_StillImage")
	load_image("101010140_3", "content_still_10101015_image", "101010150_StillImage")

	load_image("10101011", "content_still_10101011_image", "101010110_StillImage")
	

	movie_play()
	movie_set_active(true)

	
	

	load_sound("BGM_ADV_Painful")
	load_sound("BGM_ADV_Revenge")
	load_sound("BGM_ADV_I_promise_you")
	load_sound("BGM_ADV_Noir_Theme")

end




function Play()
	fadein(0)
	Play_start(true)


	
	
	show_image("101010140", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)
	play_particle(Ef_Lake)
	
	movie_wait_playing()

	
	movie_stop()

	wait_time(BLACK_WHITE_WAIT_TIME)
	
	
	

	bgm_play("Stop_BGM_Bus_2")
	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01108_480010")
	

	
	
	message("MA_01108_480011")
	close_simple_window()

	wait_time(0.5)
	
















	movie_load("MA_01108_48_2")
	movie_set_active(true)
	bgm_play("BGM_ADV_Painful")
	movie_play()

	hide_image(0)

	movie_wait_playing()

	
	movie_stop()

	on_active(Ef_Lake) 
	play_particle(Ef_Lake)
	
	
	wait_time(MOVIE_AFTER)

	
	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480016")
	close_speech_window()

	
	dot_move_unit_seq(dotTyrfing1, 4, 19, 0.7)
	wait_seq()
	
	
	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480018")
	

	
	
	change_face(Tyrfing1, "Normal")
	
	message("MA_01108_480020")
	

	bgm_play("Stop_BGM_Bus_MidFade")
	
	
	change_face(Tyrfing1, "Smile")
	
	message("MA_01108_480022")
	close_speech_window()


	
	
	bgm_play("BGM_ADV_Revenge")
	
	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(4, 19)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(3, 19)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	move_camera(7, 19, 1.0)
	change_camera_distance(8.0, 1.0)

	wait_camera()
	
	
	dot_disp_unit(dotMoronoe, true)
	dot_disp_unit(dotMazoe, true)
	dot_disp_unit(dotGliten, true)
	dot_disp_unit(dotGlitonea, true)
	dot_disp_unit(dotGliton, true)
	dot_disp_unit(dotTyronoe, true)
	dot_disp_unit(dotThiten, true)
	dot_disp_unit(dotThiton, true)

	dot_move_height(dotMoronoe, 0.11, 2.0, 2)
	dot_move_height(dotMazoe, 1.0, 1.0 ,2)
	dot_move_height(dotGliten,0.5, 1.5 ,2)
	dot_move_height(dotGlitonea,0.2, 1.8 ,2)
	dot_move_height(dotGliton,0.11, 2.0 ,2)
	dot_move_height(dotTyronoe,0.5, 2.0 ,2)
	dot_move_height(dotThiten,0.7, 1.0 ,2)
	dot_move_height(dotThiton,1.0, 1.5 ,2)

	wait_time(1.0)
	
	on_active(Ef_BlFeather1)
	on_active(Ef_BlFeather2)
	on_active(Ef_BlFeather3)
	on_active(Ef_BlFeather4)

	local gridpos = get_grid_position(8, 18)
	gridpos[2] = 
	set_pos(Ef_BlFeather1, gridpos)
	play_particle(Ef_BlFeather1)

	local gridpos = get_grid_position(10, 18)
	gridpos[2] = 
	set_pos(Ef_BlFeather2, gridpos)
	play_particle(Ef_BlFeather2)

	local gridpos = get_grid_position(8, 20)
	gridpos[2] = 
	set_pos(Ef_BlFeather3, gridpos)
	play_particle(Ef_BlFeather3)

	local gridpos = get_grid_position(10, 20)
	gridpos[2] = 
	set_pos(Ef_BlFeather4, gridpos)
	play_particle(Ef_BlFeather4)
	
	wait_time(1.0)
	
	
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01108_480024")
	close_speech_window()

	
	wait_time(0.5)

	dot_change_anim(dotNoir2,0)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)

	wait_time(1.0)

	dot_move_unit_seq(dotTyrfing1, 6, 19, 0.7)
	wait_seq()

	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480026")
	close_speech_window()

	
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01108_480027")
	close_speech_window()

	
	dot_move_unit_seq(dotMoronoe, 7, 19)
	wait_seq()

	dot_change_anim(dotMoronoe,3)
	dot_play_particle_unit(dotMoronoe,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotTyrfing1,3)
	dot_play_particle_unit(dotTyrfing1,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotTyrfing1,0)
	dot_move_knockback(dotMoronoe, 8, 19, 0.2, 2)
	dot_move_fly(dotMazoe, 7, 18, 0.11, 0.3, 2)
	dot_move_fly(dotTyronoe, 7, 20, 0.11, 0.3, 2)

	wait_time(0.2)
	dot_change_anim(dotMoronoe,0)

	wait_time(0.1)
	dot_change_anim(dotMazoe,3)
	dot_play_particle_unit(dotMazoe,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotTyronoe,3)
	dot_play_particle_unit(dotTyronoe,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotTyrfing1,3)
	dot_play_particle_unit(dotTyrfing1,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotTyrfing1,0)
	dot_move_fly(dotMazoe, 8, 17, 1.0, 0.3, 2)
	dot_move_fly(dotTyronoe, 8, 21, 0.5, 0.3, 2)

	wait_time(0.3)

	dot_change_anim(dotMazoe,0)
	dot_change_anim(dotTyronoe,0)

	
	change_face(Tyrfing1, "Pain")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480029")
	close_speech_window()

	
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01108_480030")
	close_speech_window()

	
	change_face(Tyrfing1, "Pain")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480031")
	close_speech_window()

	
	
	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01108_480033")
	close_speech_window()

	wait_time(0.3)
	dot_unit_dir(dotNoir2,2)
	move_camera(5, 19, 1.0)
	wait_time(0.3)

	bgm_play("BGM_ADV_Revenge")

	wait_camera()
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_480034")
	close_speech_window()

	
	dot_disp_unit(dotArthur, true)
	dot_disp_unit(dotMerlin, true)
	dot_reserve_move_unit_seq(dotArthur, 2, 20)
	dot_reserve_move_unit_seq(dotMerlin, 2, 21)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotArthur, 3, 20)
	dot_reserve_move_unit_seq(dotMerlin, 2, 20)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotNoir2,3)

	dot_reserve_move_unit_seq(dotArthur, 4, 20)
	dot_reserve_move_unit_seq(dotMerlin, 3, 20)
	exec_parallel_seq()
	wait_seq()

	dot_change_anim(dotArthur,3)
	dot_play_particle_unit(dotArthur,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.2)

	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.2)

	dot_disp_unit(barbaroi2, false)
	move_camera(7, 19, 1.0)
	dot_reserve_move_unit_seq(dotArthur, 6, 20)
	dot_reserve_move_unit_seq(dotMerlin, 5, 20)
	exec_parallel_seq()
	wait_seq()
	wait_camera()


	dot_remove_unit(barbaroi2)

	
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01108_480036")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01108_480037")
	close_speech_window()

	
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01108_480038")
	close_speech_window()

	
	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01108_480039")
	

	
	change_face(Arthur, "Serious")
	
	message("MA_01108_480040")
	close_speech_window()

	
	dot_change_anim(dotArthur,3)
	dot_play_particle_unit(dotArthur,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.1)
	
	on_active(Ef_SwordWind)

	local gridpos = get_grid_position(8, 19)
	set_pos(Ef_SwordWind, gridpos)
	play_particle(Ef_SwordWind)

	wait_time(0.3)

	dot_move_fly(dotMoronoe, 9, 19, 5.0, 0.3, 2)
	dot_move_fly(dotMazoe, 9, 17, 5.0, 0.3, 2)
	dot_move_fly(dotGliten, 11, 17, 5.0, 0.3, 2)

	dot_move_height(dotGlitonea,5.0, 0.3 ,2)

	dot_move_fly(dotGliton, 11, 21, 5.0, 0.3, 2)
	dot_move_fly(dotTyronoe, 9, 21, 5.0, 0.3, 2)
	dot_move_fly(dotThiten, 10, 18, 5.0, 0.3, 2)
	dot_move_fly(dotThiton, 20, 30, 5.0, 0.3, 2)

	wait_time(0.2)
	
	dot_reserve_move_unit_seq(dotArthur, 6, 25)
	dot_reserve_move_unit_seq(dotMerlin, 5, 25)
	exec_parallel_seq()
	wait_seq()

	dot_remove_unit(dotMoronoe)
	dot_remove_unit(dotMazoe)
	dot_remove_unit(dotGliten)
	dot_remove_unit(dotGlitonea)
	dot_remove_unit(dotGliton)
	dot_remove_unit(dotTyronoe)
	dot_remove_unit(dotThiten)
	dot_remove_unit(dotThiton)
	dot_remove_unit(dotArthur)
	dot_remove_unit(dotMerlin)
	
	
	dot_change_anim(dotLaiens1,2)
	dot_move_fly(dotLaiens1, 8, 19, -0.14, 1.5, 2)

	wait_time(1.5)
	
	dot_change_anim(dotLaiens1,0)

	local gridpos = get_grid_position(6, 19)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480043")
	close_speech_window()

	move_camera(4, 16, 0.5)
	change_camera_distance(8.0, 0.5)

	wait_camera()
	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)
	on_active(Ef_Emblem3)

	local gridpos = get_grid_position(5, 15)
	gridpos[2] = 0.0
	set_pos(Ef_Emblem1, gridpos)
	play_particle(Ef_Emblem1)

	local gridpos = get_grid_position(4, 17)
	gridpos[2] = 0.0
	set_pos(Ef_Emblem2, gridpos)
	play_particle(Ef_Emblem2)

	local gridpos = get_grid_position(3, 16)
	gridpos[2] = 0.0
	set_pos(Ef_Emblem3, gridpos)
	play_particle(Ef_Emblem3)

	wait_time(2.5)

	move_camera(4, 19, 1.0)
	change_camera_distance(8.0, 1.0)

	wait_camera()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_480052")
	close_speech_window()

	stop_particle(Ef_Killers)

	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480053")
	close_speech_window()

	
	move_camera(6, 19, 1.0)

	wait_camera()
	
	change_face(Laiens1, "Smile")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_480055")
	close_speech_window()


	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480057")
	close_speech_window()

	dot_change_anim(dotLaiens1,4)
	dot_play_particle_unit(dotLaiens1,"Ef_C_Mag_R_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotTyrfing1,6)
	dot_play_particle_unit(dotTyrfing1,"Ef_C_Mag_R_Hit01",1,true)
	dot_move_knockback(dotTyrfing1, 4, 19, 0.2, 2)

	wait_time(0.2)

	
	
	
	change_face(Tyrfing1, "Pain")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480059")
	close_speech_window()

	dot_change_anim(dotTyrfing1,1)
	dot_change_anim(dotLaiens1,2)
	dot_move_fly(dotLaiens1, 7, 19, 0.06, 0.5, 2)
	move_camera(5, 19, 1.0)

	wait_time(0.5)

	dot_change_anim(dotLaiens1,0)

	wait_camera()
	

	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_480060")
	close_speech_window()

	
	dot_move_unit_seq(dotBruno1, 6, 19)
	wait_time(0.5)

	dot_change_anim(dotLaiens1,4)
	dot_play_particle_unit(dotLaiens1,"Ef_C_Mag_R_Cha01",3,true)

	wait_seq()
	dot_unit_dir(dotBruno1,3)

	dot_change_anim(dotBruno1,3)
	dot_play_particle_unit(dotBruno1,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotBruno1,0)

	on_active(Ef_Vanish) 

	local gridpos = get_grid_position(6, 19)
	set_pos(Ef_Vanish, gridpos)
	play_particle(Ef_Vanish)

	dot_change_anim(dotLaiens1,6)
	dot_play_particle_unit(dotLaiens1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.2)

	dot_change_anim(dotLaiens1,0)

	
	change_face(Bruno1, "Anger")
	open_speech_window("CHRNAME_BRUNO2", Bruno1, nil)
	message("MA_01108_480062")
	close_speech_window()

	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_480063")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_480064")
	close_speech_window()

	
	change_face(Bruno1, "Serious")
	open_speech_window("CHRNAME_BRUNO2", Bruno1, nil)
	message("MA_01108_480065")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_480066")
	close_speech_window()

	stop_particle(Ef_Vanish)
	
	
	dot_move_unit_seq(dotGuinevere, 6, 18)
	wait_seq()

	dot_change_anim(dotGuinevere,3)
	dot_play_particle_unit(dotGuinevere,"Ef_C_Spr_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotGuinevere,0)
	dot_change_anim(dotLaiens1,6)
	dot_play_particle_unit(dotLaiens1,"Ef_C_Cmn_N_Hit_Spe01",1,true)

	wait_time(0.2)

	dot_change_anim(dotLaiens1,0)

	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01108_480068")
	close_speech_window()

	
	dot_move_unit_seq(dotDinatan, 6, 17)
	wait_seq()

	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_480070")
	close_speech_window()

	play_particle(Ef_Vanish)

	
	change_face(Bruno1, "Anger")
	open_speech_window("CHRNAME_BRUNO2", Bruno1, nil)
	message("MA_01108_480071")
	close_speech_window()

	
	dot_move_unit_seq(dotLancelot3, 6, 20)
	wait_seq()

	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotLancelot3,0)
	dot_change_anim(dotLaiens1,6)
	dot_play_particle_unit(dotLaiens1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.2)

	dot_change_anim(dotLaiens1,0)

	
	change_face(Lancelot3, "Serious")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01108_480073")
	close_speech_window()

	stop_particle(Ef_Vanish)

	bgm_play("Stop_BGM_Bus_MidFade")
	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_480074")
	close_speech_window()

	
	dot_change_anim(dotLaiens1,4)
	dot_play_particle_unit(dotLaiens1,"Ef_C_Mag_R_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotGuinevere,6)
	dot_change_anim(dotBruno1,6)
	dot_change_anim(dotLancelot3,6)
	dot_change_anim(dotDinatan,6)

	dot_play_particle_unit(dotBruno1,"Ef_C_Mag_R_HitAll01",1,true)

	dot_move_knockback(dotGuinevere, 4, 18, 0.2, 2)
	dot_move_knockback(dotBruno1, 4, 20, 0.2, 2)
	dot_move_knockback(dotLancelot3, 4, 21, 0.2, 2)
	dot_move_knockback(dotDinatan, 4, 17, 0.2, 2)

	wait_time(0.2)

	dot_change_anim(dotLaiens1,0)
	dot_change_anim(dotGuinevere,1)
	dot_change_anim(dotBruno1,1)
	dot_change_anim(dotLancelot3,1)
	dot_change_anim(dotDinatan,1)

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_480076")
	close_speech_window()

	
	dot_change_anim(dotTyrfing1,0)

	tempbgm = bgm_play("BGM_ADV_I_promise_you")
	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_480078")
	

	
	change_face(Tyrfing1, "Anger")
	
	message("MA_01108_480079")
	close_speech_window()

	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_480042")
	close_speech_window()

	dot_move_unit_seq(dotTyrfing1, 5, 19)
	wait_seq()

	dot_reserve_move_unit_seq(dotTyrfing1, 5, 19)
	dot_reserve_move_unit_seq(dotLaiens1, 6, 19)
	exec_parallel_seq()
	wait_seq()

	off_active(Ef_BlFeather1)
	off_active(Ef_BlFeather2)
	off_active(Ef_BlFeather3)
	off_active(Ef_BlFeather4)
	off_active(Ef_Vanish) 
	off_active(Ef_Emblem1)
	off_active(Ef_Emblem2)
	off_active(Ef_Emblem3)
	off_active(Ef_SwordWind)
	off_active(Ef_Killers)
	off_active(Ef_Vibes)


	movie_load("MA_01108_48_3")
	movie_set_active(true)
	movie_play()

	
	show_image("101010140_2", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)
	play_particle(Ef_Lake)

	movie_wait_playing()

	
	movie_stop()

	
	wait_time(MOVIE_AFTER)

	
	open_simple_window("")
	message("MA_01108_480090")
	close_speech_window()

	
	fadeout(0,0,0,1.0, BLACK_WHITE_TIME)
	wait_time(BLACK_WHITE_TIME)

	show_image("10101011", 0.0, 0.0, 0,true,false) 

	fadein(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
	
	bgm_play("BGM_ADV_Noir_Theme")
	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01108_480092")
	close_simple_window()

	
	
	open_simple_window("CHRNAME_BRUNO")
	message("MA_01108_480094")
	close_simple_window()

	
	open_simple_window("NPCNAME_0163")
	message("MA_01108_480095")
	

	
	
	message("MA_01108_480096")
	close_simple_window()

	
	open_simple_window("CHRNAME_BRUNO")
	message("MA_01108_480097")
	close_simple_window()

	
	open_simple_window("NPCNAME_0163")
	message("MA_01108_480098")
	close_simple_window()

	
	open_simple_window("CHRNAME_BRUNO")
	message("MA_01108_480099")
	close_simple_window()

	movie_load("MA_01108_48_4")
	movie_set_active(true)
	movie_play()

	show_image("101010140_3", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)
	
	close_textbox_base()

	movie_wait_playing()

	
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)

	bgm_stop(tempbgm, 0.5)	-- 下記のスキップ処理によってBGMが止まらないのでコマンドで停止

--[[ エリアクエスト用にアロンダイト選択処理をスキップ
	fadeout(1.0, 1.0, 1.0, 1.0, 0.5)
	system.SetPlaySpeed(1.0)
	wait_time(0.5)
    load_branch_select()

	pre_play_branch_select()

    fadein(0)
	play_branch_select()

	fadeout(1.0, 1.0, 1.0, 1.0, 0.0)
	set_selected_option()
]]
	
	Play_end(true)
end
	


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 3, 19,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 6, 19,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 5, 15,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 4, 17,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 3, 16,0)
	pbadv_setup_101021_Bruno_preload(1,true, 1, 17,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 5, 13,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 6, 13,0)
	pbadv_setup_101058_Laiens_preload(1,true, 11, 19,0)
	pbadv_setup_101015_Arthur_preload(0,true, 2, 27,0)
	pbadv_setup_101020_Merlin_preload(0,true, 2, 28,0)
	pbadv_setup_101042_Moronoe_preload(true, 8, 19, 0)
	pbadv_setup_101043_Mazoe_preload(true, 8, 17, 0)
	pbadv_setup_101044_Gliten_preload(true, 10, 17,0)
	pbadv_setup_101045_Glitonea_preload(true, 10, 19,0)
	pbadv_setup_101046_Gliton_preload(true, 10, 21,0)
	pbadv_setup_101047_Tyronoe_preload(true, 8, 21,0)
	pbadv_setup_101048_Thiten_preload(true, 9, 18,0)
	pbadv_setup_101049_Thiton_preload(true, 9, 20,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_SwordWind", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_LakeColor_syoku_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	movie_load_preload("MA_01108_48_1")
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image_preload("101010140_2", "content_still_10101014_image", "101010140_StillImage")
	load_image_preload("101010140_3", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("10101011", "content_still_10101011_image", "101010110_StillImage")
	preload_sound("BGM_ADV_Painful")
	preload_sound("BGM_ADV_Revenge")
	preload_sound("BGM_ADV_I_promise_you")
	preload_sound("BGM_ADV_Noir_Theme")
end
