


Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201000001", "201000001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 5, 21,0)  
	pbadv_setup_101001_Tyrfing(1,true, 5, 20,0)  

	pbadv_setup_101011_Guinevere(0,true, 3, 17,0)  
	pbadv_setup_101010_Lancelot(3,true, 3, 18,0)  

	pbadv_setup_101021_Bruno(3,true, 3, 19,0)  
	pbadv_setup_101021_Bruno(1,true, 38, 19,0)  

	pbadv_setup_101016_Gwenhwymawr(1,true, 2, 17,0)  
	pbadv_setup_101017_Maladisant(1,true, 2, 18,0)  
	pbadv_setup_101012_Dinatan(0,true, 2, 19,0)  

	pbadv_setup_101058_Laiens(1,true, 8, 20,0)  

	pbadv_setup_101015_Arthur(0,true, 5, 24,0)  
	pbadv_setup_101020_Merlin(0,true, 4, 24,0)  

	pbadv_setup_101042_Moronoe(true, 7, 24,0)  
	pbadv_setup_101043_Mazoe(true, 6, 24,0)  

	pbadv_setup_101044_Gliten(true, 6, 23,0) 
	pbadv_setup_101045_Glitonea(true, 5, 23,0) 
	pbadv_setup_101046_Gliton(true, 4, 23,0) 

	pbadv_setup_101047_Tyronoe(true, 6, 25,0) 
	pbadv_setup_101048_Thiten(true, 5, 25,0)  
	pbadv_setup_101049_Thiton(true, 4, 25,0)  

	dotromav = dot_reserve_ally(401040001, 6, 17, 0) 
	dot_set_weapon(dotromav, 101010001)

	dotromal = dot_reserve_ally(401040001, 6, 18, 0) 
	dot_set_weapon(dotromal, 101010001)
	
	dotromab = dot_reserve_ally(401040001, 6, 19, 0)  
	dot_set_weapon(dotromab, 101010001)
		
	dotromaw = dot_reserve_ally(401040001, 0, 17, 0) 
	dot_set_weapon(dotromaw, 101010001)

	dotromam = dot_reserve_ally(401040001, 0, 18, 0) 
	dot_set_weapon(dotromam, 101010001)
	
	dotromad = dot_reserve_ally(401040001, 0, 19, 0) 
	dot_set_weapon(dotromad, 101010001)

	
	
	

	
	Gliten1 = dot_reserve_enemy(29, 25, 23, 0)
	Glitonea1 = dot_reserve_enemy(30, 26, 23, 0)
	Gliton1 = dot_reserve_enemy(31, 27, 23, 0)
	Tyronoe1 = dot_reserve_enemy(32, 25, 25, 0)
	Thiten1 = dot_reserve_enemy(33, 26, 25, 0)
	Thiton1 = dot_reserve_enemy(34, 27, 25, 0)

	
	barbaroi1 = dot_reserve_enemy(1100, 4, 17, 0)
	barbaroi2 = dot_reserve_enemy(1100, 4, 18, 0)
	barbaroi3 = dot_reserve_enemy(1100, 4, 19, 0)
	
	
	barbaroi4 = dot_reserve_enemy(1100, 1, 17, 0)
	barbaroi5 = dot_reserve_enemy(1100, 1, 18, 0)
	barbaroi6 = dot_reserve_enemy(1100, 1, 19, 0)
	
	
	barbaroi7 = dot_reserve_enemy(1301, 7, 17, 0)
	barbaroi8 = dot_reserve_enemy(1301, 7, 18, 0)
	barbaroi9 = dot_reserve_enemy(1301, 7, 19, 0)
	
	
	barbaroi10 = dot_reserve_enemy(49, 8, 17, 0)
	barbaroi11 = dot_reserve_enemy(1200, 8, 18, 0)
	barbaroi12 = dot_reserve_enemy(49, 8, 19, 0)	
	
	
	barbaroi19 = dot_reserve_enemy(1301, 9, 17, 0)
	barbaroi20 = dot_reserve_enemy(1301, 9, 18, 0)
	barbaroi21 = dot_reserve_enemy(1301, 9, 19, 0)
	
	
	barbaroi13 = dot_reserve_enemy(1301, 39, 17, 0)
	barbaroi14 = dot_reserve_enemy(1301, 39, 18, 0)
	barbaroi15 = dot_reserve_enemy(1301, 39, 19, 0)	
	barbaroi16 = dot_reserve_enemy(1301, 39, 20, 0)
	barbaroi17 = dot_reserve_enemy(1301, 39, 21, 0)
	barbaroi18 = dot_reserve_enemy(1301, 39, 22, 0)	

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	

	
	dot_unit_dir(dotLaiens1,2)

	
	dot_unit_dir(dotMaladisant1,2)
	dot_unit_dir(dotGwenhwymawr1,2)
	dot_unit_dir(dotDinatan,2)

	
	dot_unit_dir(barbaroi4,3)
	dot_unit_dir(barbaroi5,3)
	dot_unit_dir(barbaroi6,3)

	
	dot_unit_dir(dotromav,3)
	dot_unit_dir(dotromal,3)
	dot_unit_dir(dotromab,3)
	dot_unit_dir(dotromaw,3)
	dot_unit_dir(dotromam,3)
	dot_unit_dir(dotromad,3)

	
	
	

	
	
	
	
	dot_disp_unit(barbaroi19, false)
	dot_disp_unit(barbaroi20, false)
	dot_disp_unit(barbaroi21, false)
	
	
	dot_disp_unit(barbaroi10, false)
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)
		










	
	dot_disp_unit(barbaroi13, false)
	dot_disp_unit(barbaroi14, false)
	dot_disp_unit(barbaroi15, false)
	dot_disp_unit(barbaroi16, false)
	dot_disp_unit(barbaroi17, false)
	dot_disp_unit(barbaroi18, false)

	
	dot_disp_unit(Gliten1, false)
	dot_disp_unit(Glitonea1, false)
	dot_disp_unit(Gliton1, false)
	dot_disp_unit(Tyronoe1, false)
	dot_disp_unit(Thiten1, false)
	dot_disp_unit(Thiton1, false)
	
	
	dot_disp_unit(dotBruno1, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(34.0, 0.0)

	
	
	move_camera(5, 24, 0.0)

	
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)

	Ef_BlFeather1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)


	Ef_Vanish = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)

	Ef_Lake = load_particle("content_effect3d_common_adv", "Ef_C_Adv_LakeColor_syoku_Lop", false, true)

	on_active(Ef_Lake) 
	play_particle(Ef_Lake)

	load_sound("BGM_Battle_Tragedy_TragedyStart")


end




function Play()
	fadein(0)
	Play_start(true)


	se_play("SE_ADV_MA_01108_46_RomeSolduar_Guard")
	
	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01108_460002")
	close_speech_window()


	dot_change_anim(dotMazoe,4)
	dot_play_particle_unit(dotMazoe,"Ef_C_Mag_W_Atk01",1,true)

	dot_change_anim(dotGliten,4)
	dot_unit_dir(dotGliten,1)
	dot_play_particle_unit(dotGliten,"Ef_C_Mag_R_Atk01",1,true)

	dot_change_anim(dotGlitonea,4)
	dot_unit_dir(dotGlitonea,1)
	dot_play_particle_unit(dotGlitonea,"Ef_C_Mag_I_Atk01",1,true)

	dot_change_anim(dotTyronoe,4)
	dot_unit_dir(dotTyronoe,0)
	dot_play_particle_unit(dotTyronoe,"Ef_C_Mag_I_Atk01",1,true)

	dot_change_anim(dotThiten,4)
	dot_unit_dir(dotThiten,0)
	dot_play_particle_unit(dotThiten,"Ef_C_Mag_T_Atk01",1,true)

	dot_change_anim(dotGliton,4)
	dot_unit_dir(dotGliton,1)
	dot_play_particle_unit(dotGliton,"Ef_C_Mag_W_Atk01",1,true)

	dot_change_anim(dotThiton,4)
	dot_unit_dir(dotThiton,0)
	dot_play_particle_unit(dotThiton,"Ef_C_Mag_F_Atk01",1,true)
	
	wait_time(0.5)
	
	dot_change_anim(dotArthur,6)
	dot_play_particle_unit(dotArthur,"Ef_C_Mag_W_Hit01",1,true)
	dot_play_particle_unit(dotArthur,"Ef_C_Mag_F_Hit01",1,true)
	dot_play_particle_unit(dotArthur,"Ef_C_Mag_T_Hit01",1,true)

	dot_change_anim(dotMerlin,6)
	dot_play_particle_unit(dotMerlin,"Ef_C_Mag_R_Hit01",1,true)
	dot_play_particle_unit(dotMerlin,"Ef_C_Mag_I_Hit01",1,true)

	wait_time(0.5)


	dot_change_anim(dotArthur,1)
	dot_change_anim(dotMerlin,1)

	dot_change_anim(dotMazoe,0)
	dot_change_anim(dotGliten,0)
	dot_change_anim(dotGlitonea,0)
	dot_change_anim(dotTyronoe,0)
	dot_change_anim(dotThiten,0)
	dot_change_anim(dotGliton,0)
	dot_change_anim(dotThiton,0)
	
	
	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01108_460004")
	close_speech_window()




	
	move_camera(3, 18, 0.5)
	
	se_play("SE_ADV_MA_01108_46_RomeSolduar_Guard")

	wait_camera()
	
	

	
	
	dot_change_anim(dotBruno3,3)
	dot_play_particle_unit(dotBruno3,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotGuinevere,3)
	dot_play_particle_unit(dotGuinevere,"Ef_C_Spr_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(barbaroi1,6)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Spe01",1,true)

	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(barbaroi3,6)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	wait_time(0.5)

	dot_change_anim(dotBruno3,0)
	dot_change_anim(dotLancelot3,0)
	dot_change_anim(dotGuinevere,0)

	
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)

	
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)

	
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)

	wait_time(0.5)

	dot_remove_unit(barbaroi1)
	dot_remove_unit(barbaroi2)
	dot_remove_unit(barbaroi3)

	
	on_active(Ef_bar1) 
	
	local gridpos = get_grid_position(8, 17)
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8})
	play_particle(Ef_bar1)

	on_active(Ef_bar2) 
	
	local gridpos = get_grid_position(8, 18)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	on_active(Ef_bar3) 
	
	local gridpos = get_grid_position(8, 19)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	wait_time(0.5)

	dot_disp_unit(barbaroi10, true)
	dot_disp_unit(barbaroi11, true)
	dot_disp_unit(barbaroi12, true)

	wait_time(2.0)
	

	
	dot_change_anim(dotGwenhwymawr1,3)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Spr_N_Atk01",3,true)

	dot_change_anim(dotMaladisant1,3)
	dot_play_particle_unit(dotMaladisant1,"Ef_C_Axe_N_Atk01",3,true)

	dot_change_anim(dotDinatan,3)
	dot_play_particle_unit(dotDinatan,"Ef_C_Mag_N_Atk01",3,true)

	dot_change_anim(dotromam,3)
	dot_play_particle_unit(dotromam,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotromad,3)
	dot_play_particle_unit(dotromad,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotromaw,3)
	dot_play_particle_unit(dotromaw,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)
	
	dot_change_anim(barbaroi4,6)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(barbaroi5,6)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_N_Hit_Spe01",1,true)

	dot_change_anim(barbaroi6,6)
	dot_play_particle_unit(barbaroi6,"Ef_C_Mag_R_Hit01",1,true)
	
	wait_time(0.2)

	dot_change_anim(dotGwenhwymawr1,0)
	dot_change_anim(dotMaladisant1,0)
	dot_change_anim(dotDinatan,0)
	dot_change_anim(dotromam,0)
	dot_change_anim(dotromad,0)
	dot_change_anim(dotromaw,0)

	
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_DieEmy01",2,true)

	
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",2,true)

	
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)

	wait_time(0.5)

		
	move_camera(5, 19, 1.0)

	dot_remove_unit(barbaroi4)
	dot_remove_unit(barbaroi5)
	dot_remove_unit(barbaroi6)

	
	local gridpos = get_grid_position(9, 17)
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8})
	play_particle(Ef_bar1)

	local gridpos = get_grid_position(9, 18)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	local gridpos = get_grid_position(9, 19)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	dot_unit_dir(dotMaladisant1,3)
	dot_unit_dir(dotGwenhwymawr1,3)
	dot_unit_dir(dotDinatan,3)

	wait_time(0.2)
	
	dot_disp_unit(barbaroi19, true)
	dot_disp_unit(barbaroi20, true)
	dot_disp_unit(barbaroi21, true)

	
	wait_time(2.0)
	wait_camera()

	
	
	change_face(Tyrfing1, "Pain")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_460006")
	close_speech_window()



	
	dot_move_knockback(dotromal,5, 18, 0.2,2)
	dot_move_knockback(dotromab,5, 19, 0.2,2)
	dot_move_knockback(dotromav,5, 17, 0.2,2)

	
	change_face(Guinevere, "Pain")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01108_460008")
	close_speech_window()

	
	change_face(Gwenhwymawr1, "Pain")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01108_460009")
	close_speech_window()

	
	dot_unit_dir(dotromal,2)
	dot_unit_dir(dotromab,2)
	dot_unit_dir(dotromav,2)

	
	
	change_face(Tyrfing1, "Pain")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_460011")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01108_460012")
	close_speech_window()

	
	move_camera(3, 18, 0.5)

	wait_camera()


	
	
	dot_move_unit_seq(dotTyrfing1, 4, 20)
	
	wait_seq()

	
	dot_reserve_move_unit_seq(dotTyrfing1,4, 19)
	dot_reserve_move_unit_seq(dotromav,4, 17)
	dot_reserve_move_unit_seq(dotromal,4, 18)
	dot_reserve_move_unit_seq(dotromam,1, 17)
	dot_reserve_move_unit_seq(dotromaw,1, 18)
	dot_reserve_move_unit_seq(dotromad,1, 19)
	
	exec_parallel_seq()
	
	wait_seq()
	
	
	dot_unit_dir(dotromab,2)

	
	
	dot_change_anim(dotromad,3)
	dot_play_particle_unit(dotromad,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotromab,3)
	dot_play_particle_unit(dotromab,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotromam,3)
	dot_play_particle_unit(dotromam,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotromaw,3)
	dot_play_particle_unit(dotromaw,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotromal,3)
	dot_play_particle_unit(dotromal,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotromav,3)
	dot_play_particle_unit(dotromav,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)
	
	
	dot_change_anim(dotTyrfing1,6)
	dot_play_particle_unit(dotTyrfing1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(dotGuinevere,6)
	dot_play_particle_unit(dotGuinevere,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(dotDinatan,6)
	dot_play_particle_unit(dotDinatan,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(dotGwenhwymawr1,6)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(dotLancelot3,6)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(dotMaladisant1,6)
	dot_play_particle_unit(dotMaladisant1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	wait_time(0.5)

	dot_change_anim(dotromad,0)
	dot_change_anim(dotromab,0)
	dot_change_anim(dotromam,0)
	dot_change_anim(dotromaw,0)
	dot_change_anim(dotromal,0)
	dot_change_anim(dotromav,0)

	
	dot_change_anim(dotGuinevere,1)
	dot_change_anim(dotDinatan,1)
	dot_change_anim(dotGwenhwymawr1,1)
	dot_change_anim(dotLancelot3,1)
	dot_change_anim(dotMaladisant1,1)
	
	wait_time(0.5)



	bgm_play("BGM_Battle_Tragedy_TragedyStart")
	
	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01108_460014")
	close_speech_window()


	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_460015")
	

	
	
	
	change_face(Noir2, "Anger")
	
	message("MA_01108_460017")
	close_speech_window()

	
	change_face(Bruno3, "Surprise")
	open_speech_window("CHRNAME_BRUNO2", Bruno3, nil)
	message("MA_01108_460018")
	close_speech_window()

	
	change_face(Tyrfing1, "Pain")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01108_460019")
	

	
	change_face(Tyrfing1, "Pain")
	
	message("MA_01108_460020")
	close_speech_window()

	
	
	dot_change_anim(dotTyrfing1,1)


	
	change_face(Bruno3, "Normal")
	open_speech_window("CHRNAME_BRUNO2", Bruno3, nil)
	message("MA_01108_460022")
	close_speech_window()

	
	
	
	on_active(Ef_BlFeather1)
	on_active(Ef_WitchChange1) 

	local gridpos = get_grid_position(1, 19)
	set_pos(Ef_BlFeather1, gridpos)
	play_particle(Ef_BlFeather1)

	local gridpos = get_grid_position(1, 19)
	set_pos(Ef_WitchChange1, gridpos)
	play_particle(Ef_WitchChange1)


	on_active(Ef_BlFeather2)
	on_active(Ef_WitchChange2) 

	local gridpos = get_grid_position(1, 17)
	set_pos(Ef_WitchChange2, gridpos)
	play_particle(Ef_WitchChange2)

	local gridpos = get_grid_position(1, 17)
	set_pos(Ef_BlFeather2, gridpos)
	play_particle(Ef_BlFeather2)


	on_active(Ef_BlFeather3)
	on_active(Ef_WitchChange3) 

	local gridpos = get_grid_position(1, 18)
	set_pos(Ef_BlFeather3, gridpos)
	play_particle(Ef_BlFeather3)

	local gridpos = get_grid_position(1, 18)
	set_pos(Ef_WitchChange3, gridpos)
	play_particle(Ef_WitchChange3)


	on_active(Ef_BlFeather4)
	on_active(Ef_WitchChange4) 

	local gridpos = get_grid_position(4, 17)
	set_pos(Ef_BlFeather4, gridpos)
	play_particle(Ef_BlFeather4)

	local gridpos = get_grid_position(4, 17)
	set_pos(Ef_WitchChange4, gridpos)
	play_particle(Ef_WitchChange4)

	on_active(Ef_BlFeather5)
	on_active(Ef_WitchChange5) 

	local gridpos = get_grid_position(5, 19)
	set_pos(Ef_BlFeather5, gridpos)
	play_particle(Ef_BlFeather5)

	local gridpos = get_grid_position(5, 19)
	set_pos(Ef_WitchChange5, gridpos)
	play_particle(Ef_WitchChange5)


	on_active(Ef_BlFeather6)
	on_active(Ef_WitchChange6) 

	local gridpos = get_grid_position(4, 18)
	set_pos(Ef_BlFeather6, gridpos)
	play_particle(Ef_BlFeather6)

	local gridpos = get_grid_position(4, 18)
	set_pos(Ef_WitchChange6, gridpos)
	play_particle(Ef_WitchChange6)

	wait_time(1.0)

	dot_change_unit(dotromad,Gliten1,0)	
	dot_change_unit(dotromam,Glitonea1,0)
	dot_change_unit(dotromaw,Gliton1,0)
	dot_change_unit(dotromav,Tyronoe1,0)
	dot_change_unit(dotromab,Thiten1,0)
	dot_change_unit(dotromal,Thiton1,0)


	wait_time(2.0)

	move_camera(6, 24, 1.0)

	wait_camera()

	
	
	local gridpos = get_grid_position(6, 23)
	set_pos(Ef_BlFeather1, gridpos)
	play_particle(Ef_BlFeather1)

	local gridpos = get_grid_position(6, 23)
	set_pos(Ef_WitchChange1, gridpos)
	play_particle(Ef_WitchChange1)


	local gridpos = get_grid_position(5, 23)
	set_pos(Ef_BlFeather2, gridpos)
	play_particle(Ef_BlFeather2)

	local gridpos = get_grid_position(5, 23)
	set_pos(Ef_WitchChange2, gridpos)
	play_particle(Ef_WitchChange2)


	local gridpos = get_grid_position(4, 23)
	set_pos(Ef_BlFeather3, gridpos)
	play_particle(Ef_BlFeather3)

	local gridpos = get_grid_position(4, 23)
	set_pos(Ef_WitchChange3, gridpos)
	play_particle(Ef_WitchChange3)


	local gridpos = get_grid_position(6, 25)
	set_pos(Ef_BlFeather4, gridpos)
	play_particle(Ef_BlFeather4)

	local gridpos = get_grid_position(6, 25)
	set_pos(Ef_WitchChange4, gridpos)
	play_particle(Ef_WitchChange4)


	local gridpos = get_grid_position(5, 25)
	set_pos(Ef_BlFeather5, gridpos)
	play_particle(Ef_BlFeather5)

	local gridpos = get_grid_position(5, 25)
	set_pos(Ef_WitchChange5, gridpos)
	play_particle(Ef_WitchChange5)


	local gridpos = get_grid_position(4, 25)
	set_pos(Ef_BlFeather6, gridpos)
	play_particle(Ef_BlFeather6)

	local gridpos = get_grid_position(4, 25)
	set_pos(Ef_WitchChange6, gridpos)
	play_particle(Ef_WitchChange6)

	wait_time(1.0)

	dot_change_unit(dotGliten,barbaroi13,0)
	dot_change_unit(dotGlitonea,barbaroi14,0)
	dot_change_unit(dotGliton,barbaroi15,0)
	dot_change_unit(dotTyronoe,barbaroi16,0)
	dot_change_unit(dotThiten,barbaroi17,0)
	dot_change_unit(dotThiton,barbaroi18,0)

	wait_time(2.0)

	dot_remove_unit(dotGliten)
	dot_remove_unit(dotGlitonea)
	dot_remove_unit(dotGliton)
	dot_remove_unit(dotTyronoe)
	dot_remove_unit(dotThiten)
	dot_remove_unit(dotThiton)

	
	
	
	
	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01108_460024")
	close_speech_window()

	
	move_camera(7, 21, 0.5)

	wait_camera()
	

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_460025")
	

	
	change_face(Laiens1, "Normal")
	
	message("MA_01108_460026")
	

	
	change_face(Laiens1, "Smile")
	
	message("MA_01108_460027")
	close_speech_window()

	
	dot_move_unit_seq(dotBruno3, 7, 20)
	
	wait_seq()

	dot_change_anim(dotBruno3,3)
	dot_play_particle_unit(dotBruno3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotLaiens1,4)
	dot_play_particle_unit(dotLaiens1,"Ef_C_Mag_R_Atk01",3,true)
	
	wait_time(0.5)

	
	dot_change_anim(dotBruno3,6)
	dot_play_particle_unit(dotBruno3,"Ef_C_Mag_R_Hit01",1,true)

	wait_time(0.3)

	dot_move_knockback(dotBruno3, 6, 20, 0.3, 2)
	dot_change_anim(dotLaiens1,0)

	wait_time(0.3)

	
	dot_change_anim(dotBruno3,1)

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_460029")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_460030")
	close_speech_window()

	on_active(Ef_Vanish) 

	local gridpos = get_grid_position(6, 20)
	set_pos(Ef_Vanish, gridpos)
	play_particle(Ef_Vanish)


	
	change_face(Bruno3, "Anger")
	open_speech_window("CHRNAME_BRUNO2", Bruno3, nil)
	message("MA_01108_460032")
	close_speech_window()

	stop_particle(Ef_Vanish)
	
	
	change_face(Lancelot3, "Pain")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01108_460033")
	

	
	change_face(Lancelot3, "Pain")
	
	message("MA_01108_460034")
	

				
	
	change_face(Lancelot3, "Pain")
	
	message("MA_01108_460036")
	

	
	change_face(Lancelot3, "Pain")
	
	message("MA_01108_460037")
	close_speech_window()

	
	change_face(Bruno3, "Normal")
	open_speech_window("CHRNAME_BRUNO2", Bruno3, nil)
	message("MA_01108_460038")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_460039")
	close_speech_window()

	
	change_face(Bruno3, "Normal")
	open_speech_window("CHRNAME_BRUNO2", Bruno3, nil)
	message("MA_01108_460040")
	

	
	change_face(Bruno3, "Normal")
	
	message("MA_01108_460041")
	

	
	change_face(Bruno3, "Normal")
	
	message("MA_01108_460042")
	

	
	change_face(Bruno3, "Sad")
	
	message("MA_01108_460043")
	close_speech_window()


	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_460045")
	close_speech_window()

	
	change_face(Bruno3, "Sad")
	open_speech_window("CHRNAME_BRUNO2", Bruno3, nil)
	message("MA_01108_460046")
	

	
	change_face(Bruno3, "Normal")
	
	message("MA_01108_460047")
	close_speech_window()

	wait_time(0.5)
	dot_change_anim(dotBruno3,0)
	wait_time(0.5)

	
	open_narration_window()
	message("MA_01108_460048")
	close_narration_window()

	wait_time(0.5)

	
	dot_change_unit(dotBruno3,dotBruno1,0.0)
	
	wait_time(0.5)

	
	change_face(Bruno1, "Normal")
	open_speech_window("CHRNAME_BRUNO2", Bruno1, nil)
	message("MA_01108_460050")
	close_speech_window()

	
	wait_time(1.0)
	
	
	dot_move_unit_seq(dotNoir2, 6, 21)
	
	wait_seq()

	wait_time(0.5)

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_460052")
	close_speech_window()

	
	change_face(Bruno1, "Normal")
	open_speech_window("CHRNAME_BRUNO2", Bruno1, nil)
	message("MA_01108_460053")
	close_speech_window()

	
	open_narration_window()
	message("MA_01108_460054")
	close_narration_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_460055")
	close_speech_window()

	
	change_face(Bruno1, "Normal")
	open_speech_window("CHRNAME_BRUNO2", Bruno1, nil)
	message("MA_01108_460056")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_460057")
	close_speech_window()

	
	change_face(Bruno1, "Normal")
	open_speech_window("CHRNAME_BRUNO2", Bruno1, nil)
	message("MA_01108_460058")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_460059")
	close_speech_window()

	
	change_face(Bruno1, "Normal")
	open_speech_window("CHRNAME_BRUNO2", Bruno1, nil)
	message("MA_01108_460060")
	close_speech_window()

	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_460061")
	close_speech_window()

	
	open_cutin(1,1)
	
	on_cutin(1,Bruno1,"Serious") 

	
	
	
	
	
	open_speech_window("CHRNAME_BRUNO2", nil, nil)
	message("MA_01108_460062")
	

	
	
	
	message("MA_01108_460063")
	close_speech_window()


	
	close_cutin()
	

	
	Play_end(true)
end
	



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 5, 21,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 5, 20,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 3, 17,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 3, 18,0)
	pbadv_setup_101021_Bruno_preload(3,true, 3, 19,0)
	pbadv_setup_101021_Bruno_preload(1,true, 38, 19,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 2, 17,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 2, 18,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 2, 19,0)
	pbadv_setup_101058_Laiens_preload(1,true, 8, 20,0)
	pbadv_setup_101015_Arthur_preload(0,true, 5, 24,0)
	pbadv_setup_101020_Merlin_preload(0,true, 4, 24,0)
	pbadv_setup_101042_Moronoe_preload(true, 7, 24,0)
	pbadv_setup_101043_Mazoe_preload(true, 6, 24,0)
	pbadv_setup_101044_Gliten_preload(true, 6, 23,0)
	pbadv_setup_101045_Glitonea_preload(true, 5, 23,0)
	pbadv_setup_101046_Gliton_preload(true, 4, 23,0)
	pbadv_setup_101047_Tyronoe_preload(true, 6, 25,0)
	pbadv_setup_101048_Thiten_preload(true, 5, 25,0)
	pbadv_setup_101049_Thiton_preload(true, 4, 25,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_LakeColor_syoku_Lop", false, true)
	preload_sound("BGM_Battle_Tragedy_TragedyStart")
end
