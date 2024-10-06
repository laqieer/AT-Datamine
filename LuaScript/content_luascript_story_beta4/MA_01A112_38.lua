

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	

	
	
	
	
	
	init_psbattleadv("201090100", "201090100")
	change_time_and_weather(1,1)

	

	
	pbadv_setup_101030_Elaine(1,true,10,3,0)

	

	
	pbadv_setup_101041_Morgan(1,true, 14, 2,0) 
	pbadv_setup_101042_Moronoe(true,  16, 5,0)  
	pbadv_setup_101043_Mazoe(true,    15, 3,0)  
	pbadv_setup_101044_Gliten(true,   17, 2,0) 
	pbadv_setup_101045_Glitonea(true, 15, 4,0) 
	pbadv_setup_101046_Gliton(true,   16, 2,0) 
	pbadv_setup_101047_Tyronoe(true,  16, 3,0) 
	pbadv_setup_101048_Thiten(true,   17, 4,0)  
	pbadv_setup_101049_Thiton(true,   14, 4,0)  
	
	witch  = dot_reserve_ally(101041002, 14, 3, 0)
	witch2 = dot_reserve_ally(101042001, 10 , 1, 0)
	witch3 = dot_reserve_ally(101043001, 11, 3, 0)
	witch4 = dot_reserve_ally(101044001, 10 , 5, 0)
	witch5 = dot_reserve_ally(101045001, 10 , 2, 0)
	witch6 = dot_reserve_ally(101046001, 12, 2, 0)
	witch7 = dot_reserve_ally(101047001, 11 , 1, 0)
	witch8 = dot_reserve_ally(101048001, 9 , 3, 0)
	witch9 = dot_reserve_ally(101049001, 12 , 4, 0)
	
	dot_set_weapon(witch, 104010001)
	dot_set_weapon(witch2, 104010001)
	dot_set_weapon(witch3, 104010001)
	dot_set_weapon(witch4, 104010001)
	dot_set_weapon(witch5, 104010001)
	dot_set_weapon(witch6, 104010001)
	dot_set_weapon(witch7, 104010001)	
	dot_set_weapon(witch8, 104010001)
	dot_set_weapon(witch9, 104010001)
	
	
	
	setup_complete_unit()

	
	
	dot_unit_dir(witch, 2)
	dot_unit_dir(witch2, 3)
	dot_unit_dir(witch3, 3)
	dot_unit_dir(witch4, 3)
	dot_unit_dir(witch5, 3)
	dot_unit_dir(witch6, 3)
	dot_unit_dir(witch7, 3)
	dot_unit_dir(witch8, 3)
	dot_unit_dir(witch9, 3)

	
	
	
	
	dot_disp_weapon(witch, false)
	dot_disp_weapon(witch2, false)
	dot_disp_weapon(witch3, false)
	dot_disp_weapon(witch4, false)
	dot_disp_weapon(witch5, false)
	dot_disp_weapon(witch6, false)
	dot_disp_weapon(witch7, false)
	dot_disp_weapon(witch8, false)
	dot_disp_weapon(witch9, false)
	
	
	

	
	dot_disp_unit(dotMorgan1, false)
	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotGliton, false)
	dot_disp_unit(dotTyronoe, false)
	dot_disp_unit(dotThiten, false)
	dot_disp_unit(dotThiton, false)
	dot_disp_unit(witch2, false)
	dot_disp_unit(witch3, false)
	dot_disp_unit(witch4, false)
	dot_disp_unit(witch5, false)
	dot_disp_unit(witch6, false)
	dot_disp_unit(witch7, false)
	dot_disp_unit(witch8, false)
	dot_disp_unit(witch9, false)
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(13, 3, 0.0)
	
	
	
	
	
	Ef_warpW= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpW2= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpW3= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpW4= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpW5= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpW6= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpW7= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpW8= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpW9= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpWc2= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpWc3= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpWc4= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpWc5= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpWc6= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpWc7= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpWc8= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_warpWc9= load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	
	
	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true) 
	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true) 
	Ef_AuraArea = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area", false, true)

	on_active(Ef_AuraArea)

	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_AuraArea, gridpos)
	set_scale(Ef_AuraArea, {1.4, 1.4, 1.4})
	play_particle(Ef_AuraArea)

end






function Play()
	fadein(0)
	Play_start(true)




	
	
	
	dot_move_unit_seq(dotElaine1,13, 3)
	wait_seq()
	dot_change_anim(dotElaine1,3)
	dot_play_particle_unit(dotElaine1,"Ef_C_Spr_N_Atk01",3,true)
	dot_disp_unit(witch, false)
	
	on_active(Ef_warpW2)
	local gridpos = get_grid_position(14,3)
	set_pos(Ef_warpW2, gridpos)
	play_particle(Ef_warpW2)
	
	wait_time(0.5)
	dot_change_anim(dotElaine1,0)
	wait_time(1.0)
	dot_unit_dir(dotElaine1, 2)
	wait_time(1.5)
	dot_unit_dir(dotElaine1, 3)
	wait_time(1.5)
	

	dot_disp_unit(dotMorgan1, true)
	
	on_active(Ef_warpW)
	local gridpos = get_grid_position(14,2)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)
	
	dot_disp_unit(dotGliten, true)
	
	on_active(Ef_warpW4)
	local gridpos = get_grid_position(17,2)
	set_pos(Ef_warpW4, gridpos)
	play_particle(Ef_warpW4)
	
	dot_disp_unit(dotTyronoe, true)
	
	on_active(Ef_warpW7)
	local gridpos = get_grid_position(16,3)
	set_pos(Ef_warpW7, gridpos)
	play_particle(Ef_warpW7)
	
	
	dot_disp_unit(witch2, true)
	
	on_active(Ef_warpWc2)
	local gridpos = get_grid_position(10,1)
	set_pos(Ef_warpWc2, gridpos)
	play_particle(Ef_warpWc2)
	
	dot_disp_unit(witch7, true)
	
	on_active(Ef_warpWc7)
	local gridpos = get_grid_position(11,1)
	set_pos(Ef_warpWc7, gridpos)
	play_particle(Ef_warpWc7)
	
	dot_disp_unit(witch9, true)
	
	on_active(Ef_warpWc9)
	local gridpos = get_grid_position(12,4)
	set_pos(Ef_warpWc9, gridpos)
	play_particle(Ef_warpWc9)
	wait_seq()
	

	
	
	change_face(Moronoe, "Normal")
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01A112_380002")
	
	
	change_face(Moronoe, "Normal")
	message("MA_01A112_380003")
	close_speech_window()
	
	
	dot_disp_unit(dotMorgan1, false)
	
	local gridpos = get_grid_position(14,2)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)
	
	dot_disp_unit(dotGliten, false)
	
	local gridpos = get_grid_position(17,2)
	set_pos(Ef_warpW4, gridpos)
	play_particle(Ef_warpW4)
	
	dot_disp_unit(dotTyronoe, false)
	
	local gridpos = get_grid_position(16,3)
	set_pos(Ef_warpW7, gridpos)
	play_particle(Ef_warpW7)
	
	
	dot_disp_unit(witch2, false)
	
	local gridpos = get_grid_position(10,1)
	set_pos(Ef_warpWc2, gridpos)
	play_particle(Ef_warpWc2)
	
	dot_disp_unit(witch7, false)
	
	local gridpos = get_grid_position(11,1)
	set_pos(Ef_warpWc7, gridpos)
	play_particle(Ef_warpWc7)
	
	dot_disp_unit(witch9, false)
	
	local gridpos = get_grid_position(12,4)
	set_pos(Ef_warpWc9, gridpos)
	play_particle(Ef_warpWc9)
	wait_time(1.0)
	
	
	dot_unit_dir(witch3, 3)
	dot_unit_dir(witch4, 3)
	dot_unit_dir(witch6, 3)
	wait_seq()
	
	dot_disp_unit(dotMazoe, true)
	
	on_active(Ef_warpW3)
	local gridpos = get_grid_position(15,3)
	set_pos(Ef_warpW3, gridpos)
	play_particle(Ef_warpW3)
	
	dot_disp_unit(dotGlitonea, true)
	
	on_active(Ef_warpW5)
	local gridpos = get_grid_position(15,4)
	set_pos(Ef_warpW5, gridpos)
	play_particle(Ef_warpW5)
	
	
	dot_disp_unit(dotThiten, true)
	
	on_active(Ef_warpW8)
	local gridpos = get_grid_position(17,4)
	set_pos(Ef_warpW8, gridpos)
	play_particle(Ef_warpW8)
	
	dot_disp_unit(witch3, true)
	
	on_active(Ef_warpWc3)
	local gridpos = get_grid_position(11,3)
	set_pos(Ef_warpWc3, gridpos)
	play_particle(Ef_warpWc3)
	
	dot_disp_unit(witch4, true)
	
	on_active(Ef_warpWc4)
	local gridpos = get_grid_position(10,5)
	set_pos(Ef_warpWc4, gridpos)
	play_particle(Ef_warpWc4)
	
	
	dot_disp_unit(witch6, true)
	
	on_active(Ef_warpWc6)
	local gridpos = get_grid_position(12,2)
	set_pos(Ef_warpWc6, gridpos)
	play_particle(Ef_warpWc6)
	wait_seq()
	
	
	

	change_face(Moronoe, "Smile")
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01A112_380004")
	
	
	change_face(Moronoe, "Smile")
	message("MA_01A112_380006")
	close_speech_window()
	
	
	change_face(Elaine1, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A112_380007")
	close_speech_window()
	
	
	dot_disp_unit(dotMazoe, false)
	
	on_active(Ef_warpW3)
	local gridpos = get_grid_position(15,3)
	set_pos(Ef_warpW3, gridpos)
	play_particle(Ef_warpW3)
	
	dot_disp_unit(dotGlitonea, false)
	
	on_active(Ef_warpW5)
	local gridpos = get_grid_position(15,4)
	set_pos(Ef_warpW5, gridpos)
	play_particle(Ef_warpW5)
	
	dot_disp_unit(dotThiten, false)
	
	on_active(Ef_warpW8)
	local gridpos = get_grid_position(17,4)
	set_pos(Ef_warpW8, gridpos)
	play_particle(Ef_warpW8)
	
	dot_disp_unit(witch3, false)
	
	on_active(Ef_warpWc3)
	local gridpos = get_grid_position(11,3)
	set_pos(Ef_warpWc3, gridpos)
	play_particle(Ef_warpWc3)
	
	dot_disp_unit(witch4, false)
	
	on_active(Ef_warpWc4)
	local gridpos = get_grid_position(10,5)
	set_pos(Ef_warpWc4, gridpos)
	play_particle(Ef_warpWc4)
	
	dot_disp_unit(witch6, false)
	
	on_active(Ef_warpWc6)
	local gridpos = get_grid_position(12,2)
	set_pos(Ef_warpWc6, gridpos)
	play_particle(Ef_warpWc6)
	wait_time(1.0)
	
	
	dot_unit_dir(witch5, 3)
	dot_unit_dir(witch7, 3)
	dot_unit_dir(witch8, 3)
	wait_seq()
	dot_disp_unit(dotMoronoe, true)
	
	
	on_active(Ef_warpW2)
	local gridpos = get_grid_position(16,5)
	set_pos(Ef_warpW2, gridpos)
	play_particle(Ef_warpW2)
	
	
	dot_disp_unit(dotGliton, true)
	
	on_active(Ef_warpW6)
	local gridpos = get_grid_position(16,2)
	set_pos(Ef_warpW6, gridpos)
	play_particle(Ef_warpW6)
	
	dot_disp_unit(dotThiton, true)
	
	on_active(Ef_warpW9)
	local gridpos = get_grid_position(14,4)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)
	
	dot_disp_unit(witch5, true)
	
	on_active(Ef_warpWc5)
	local gridpos = get_grid_position(10,2)
	set_pos(Ef_warpWc5, gridpos)
	play_particle(Ef_warpWc5)
	
	dot_disp_unit(witch7, true)
	
	on_active(Ef_warpWc7)
	local gridpos = get_grid_position(11,1)
	set_pos(Ef_warpWc7, gridpos)
	play_particle(Ef_warpWc7)
	
	dot_disp_unit(witch8, true)
	
	on_active(Ef_warpWc8)
	local gridpos = get_grid_position(9,3)
	set_pos(Ef_warpWc8, gridpos)
	play_particle(Ef_warpWc8)
	
	wait_seq()

	
	
	change_face(Gliten, "Normal")
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01A112_380008")
	close_speech_window()
	
	
	change_face(Elaine1, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A112_380009")
	close_speech_window()
	
	
	dot_disp_unit(dotMoronoe, false)
	
	local gridpos = get_grid_position(16,5)
	set_pos(Ef_warpW2, gridpos)
	play_particle(Ef_warpW2)
	
	
	dot_disp_unit(dotGliton, false)
	
	local gridpos = get_grid_position(16,2)
	set_pos(Ef_warpW6, gridpos)
	play_particle(Ef_warpW6)
	
	dot_disp_unit(dotThiton, false)
	
	local gridpos = get_grid_position(14,4)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)
	
	dot_disp_unit(witch5, false)
	
	local gridpos = get_grid_position(10,2)
	set_pos(Ef_warpWc5, gridpos)
	play_particle(Ef_warpWc5)
	
	dot_disp_unit(witch7, false)
	
	local gridpos = get_grid_position(11,1)
	set_pos(Ef_warpWc7, gridpos)
	play_particle(Ef_warpWc7)
	
	dot_disp_unit(witch8, false)
	
	local gridpos = get_grid_position(9,3)
	set_pos(Ef_warpWc8, gridpos)
	play_particle(Ef_warpWc8)
	
	wait_time(1.0)
	
	
	dot_unit_dir(witch3, 3)
	dot_unit_dir(witch5, 3)
	dot_unit_dir(witch8, 3)
	dot_unit_dir(witch9, 3)
	
	wait_seq()
	
	dot_disp_unit(dotMorgan1, true)
	
	local gridpos = get_grid_position(14,2)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)
	
	dot_disp_unit(dotMazoe, true)
	
	local gridpos = get_grid_position(15,3)
	set_pos(Ef_warpW3, gridpos)
	play_particle(Ef_warpW3)
	
	dot_disp_unit(dotGlitonea, true)
	
	local gridpos = get_grid_position(15,4)
	set_pos(Ef_warpW5, gridpos)
	play_particle(Ef_warpW5)
	
	
	dot_disp_unit(dotTyronoe, true)
	
	local gridpos = get_grid_position(16,3)
	set_pos(Ef_warpW7, gridpos)
	play_particle(Ef_warpW7)
	
	
	dot_disp_unit(dotThiten, true)
	
	local gridpos = get_grid_position(17,4)
	set_pos(Ef_warpW8, gridpos)
	play_particle(Ef_warpW8)
	
	dot_disp_unit(witch3, true)
	
	local gridpos = get_grid_position(11,3)
	set_pos(Ef_warpWc3, gridpos)
	play_particle(Ef_warpWc3)
	
	dot_disp_unit(witch5, true)
	
	local gridpos = get_grid_position(10,2)
	set_pos(Ef_warpWc5, gridpos)
	play_particle(Ef_warpWc5)
	
	dot_disp_unit(witch8, true)
	
	local gridpos = get_grid_position(9,3)
	set_pos(Ef_warpWc8, gridpos)
	play_particle(Ef_warpWc8)
	
	dot_disp_unit(witch9, true)
	
	local gridpos = get_grid_position(12,4)
	set_pos(Ef_warpWc9, gridpos)
	play_particle(Ef_warpWc9)
	wait_seq()
	
	
	
	change_face(Tyronoe, "Anger")
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01A112_380010")
	close_speech_window()
	
	
	change_face(Elaine1, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A112_380011")
	
	

	change_face(Elaine1, "Anger")
	message("MA_01A112_380012")
	close_speech_window()
	
	
	on_active(Ef_Emblem1) 
	local locatorpos = dot_get_unit_locator(dotElaine1, 1)
	set_pos(Ef_Emblem1, locatorpos)
	
	on_active(Ef_Vibes) 
	local gridpos = get_grid_position(13, 3)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)
	
	

	

	
	change_face(Elaine1, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A112_380014")
	close_speech_window()
	
	
	
	local gridpos = get_grid_position(14,2)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)
	dot_disp_unit(dotMorgan1, false)
	
	dot_disp_unit(dotMazoe, false)
	
	local gridpos = get_grid_position(15,3)
	set_pos(Ef_warpW3, gridpos)
	play_particle(Ef_warpW3)
	
	dot_disp_unit(dotGlitonea, false)
	
	local gridpos = get_grid_position(15,4)
	set_pos(Ef_warpW5, gridpos)
	play_particle(Ef_warpW5)
	
	
	dot_disp_unit(dotTyronoe, false)
	
	local gridpos = get_grid_position(16,3)
	set_pos(Ef_warpW7, gridpos)
	play_particle(Ef_warpW7)
	
	dot_disp_unit(dotThiten, false)
	
	local gridpos = get_grid_position(17,4)
	set_pos(Ef_warpW8, gridpos)
	play_particle(Ef_warpW8)
	
	dot_disp_unit(witch3, false)
	
	local gridpos = get_grid_position(11,3)
	set_pos(Ef_warpWc3, gridpos)
	play_particle(Ef_warpWc3)
	
	dot_disp_unit(witch5, false)
	
	local gridpos = get_grid_position(10,2)
	set_pos(Ef_warpWc5, gridpos)
	play_particle(Ef_warpWc5)
	
	dot_disp_unit(witch8, false)
	
	local gridpos = get_grid_position(9,3)
	set_pos(Ef_warpWc8, gridpos)
	play_particle(Ef_warpWc8)
	
	dot_disp_unit(witch9, false)
	
	local gridpos = get_grid_position(12,4)
	set_pos(Ef_warpWc9, gridpos)
	play_particle(Ef_warpWc9)
	
	wait_time(1.0)
	
	
	dot_unit_dir(witch2, 3)
	dot_unit_dir(witch6, 3)
	wait_seq()
	
	dot_disp_unit(dotMoronoe, true)
	
	local gridpos = get_grid_position(16,5)
	set_pos(Ef_warpW2, gridpos)
	play_particle(Ef_warpW2)
	
	dot_disp_unit(dotGliten, true)
	
	local gridpos = get_grid_position(17,2)
	set_pos(Ef_warpW4, gridpos)
	play_particle(Ef_warpW4)
	
	dot_disp_unit(dotGliton, true)
	
	local gridpos = get_grid_position(16,2)
	set_pos(Ef_warpW6, gridpos)
	play_particle(Ef_warpW6)
	
	dot_disp_unit(witch2, true)
	
	local gridpos = get_grid_position(10,1)
	set_pos(Ef_warpWc2, gridpos)
	play_particle(Ef_warpWc2)
	
	dot_disp_unit(witch6, true)
	
	local gridpos = get_grid_position(12,2)
	set_pos(Ef_warpWc6, gridpos)
	play_particle(Ef_warpWc6)
	
	wait_seq()
	
	
	change_face(Glitonea, "Anger")
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01A112_380015")
	close_speech_window()
	
	
	change_face(Elaine1, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A112_380016")
	
	
	change_face(Elaine1, "Anger")
	message("MA_01A112_380017")
	close_speech_window()
	
	
	dot_disp_unit(dotMoronoe, false)
	
	local gridpos = get_grid_position(16,5)
	set_pos(Ef_warpW2, gridpos)
	play_particle(Ef_warpW2)
	
	dot_disp_unit(dotGliten, false)
	
	local gridpos = get_grid_position(17,2)
	set_pos(Ef_warpW4, gridpos)
	play_particle(Ef_warpW4)
	
	dot_disp_unit(dotGliton, false)
	
	local gridpos = get_grid_position(16,2)
	set_pos(Ef_warpW6, gridpos)
	play_particle(Ef_warpW6)
	
	dot_disp_unit(witch2, false)
	
	local gridpos = get_grid_position(10,1)
	set_pos(Ef_warpWc2, gridpos)
	play_particle(Ef_warpWc2)
	
	dot_disp_unit(witch6, false)
	
	local gridpos = get_grid_position(12,2)
	set_pos(Ef_warpWc6, gridpos)
	play_particle(Ef_warpWc6)
	wait_time(1.0)
	
	
	dot_unit_dir(witch5, 3)
	dot_unit_dir(witch7, 3)
	wait_seq()
	
	local gridpos = get_grid_position(14,2)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)
	dot_disp_unit(dotMorgan1, true)
	
	dot_disp_unit(dotGlitonea, true)
	
	local gridpos = get_grid_position(15,4)
	set_pos(Ef_warpW5, gridpos)
	play_particle(Ef_warpW5)
	
	
	dot_disp_unit(dotThiton, true)
	
	local gridpos = get_grid_position(14,4)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)
	
	dot_disp_unit(witch5, true)
	
	local gridpos = get_grid_position(10,2)
	set_pos(Ef_warpWc5, gridpos)
	play_particle(Ef_warpWc5)
	
	dot_disp_unit(witch7, true)
	
	local gridpos = get_grid_position(11,1)
	set_pos(Ef_warpWc7, gridpos)
	play_particle(Ef_warpWc7)
	wait_seq()
	
	
	

	change_face(Moronoe, "Anger")
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01A112_380018")
	close_speech_window()
	
	
	open_cutin(1, 1)
	
	on_cutin(1, Elaine1, "Anger", 1)
	
	
	
	
	open_speech_window("CHRNAME_ELAINE", nil, nil)
	message("MA_01A112_380020")
	
	
	
	message("MA_01A112_380021")
	
	
	

	
	message("MA_01A112_380022")
	
	
	
	message("MA_01A112_380024")
	close_speech_window()
	
		
	close_cutin()
	wait_time(0.5)
	






	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101030_Elaine_preload(1,true,10,3,0)
	pbadv_setup_101041_Morgan_preload(1,true, 14, 2,0)
	pbadv_setup_101042_Moronoe_preload(true,  16, 5,0)
	pbadv_setup_101043_Mazoe_preload(true,    15, 3,0)
	pbadv_setup_101044_Gliten_preload(true,   17, 2,0)
	pbadv_setup_101045_Glitonea_preload(true, 15, 4,0)
	pbadv_setup_101046_Gliton_preload(true,   16, 2,0)
	pbadv_setup_101047_Tyronoe_preload(true,  16, 3,0)
	pbadv_setup_101048_Thiten_preload(true,   17, 4,0)
	pbadv_setup_101049_Thiton_preload(true,   14, 4,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area", false, true)
end
