


Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201000001", "201000001")
	change_time_and_weather(4,4)
	
	
	pbadv_setup_101009_Noir(2,true, 4, 17,0)  

	pbadv_setup_101012_Dinatan(0,true, 4, 18,0)  
	pbadv_setup_101010_Lancelot(3,true, 3, 16,0)  
	pbadv_setup_101011_Guinevere(0,true, 2, 17,0)  

	pbadv_setup_101001_Tyrfing(1,true, 0, 18,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 0, 16,0)  
	pbadv_setup_101017_Maladisant(1,true, 0, 17,0)  


	pbadv_setup_101058_Laiens(1,true, 8, 18,0)  

	pbadv_setup_101051_Lucius(0,true, 0, 21,0)  


	pbadv_setup_101042_Moronoe(true, 9, 18,0)  
	pbadv_setup_101043_Mazoe(true, 9, 16,0)  

	pbadv_setup_101044_Gliten(true, 9, 19,0) 
	pbadv_setup_101045_Glitonea(true, 8, 19,0) 
	pbadv_setup_101046_Gliton(true, 7, 19,0) 

	pbadv_setup_101047_Tyronoe(true, 7, 18,0) 
	pbadv_setup_101048_Thiten(true, 7, 17,0)  

	pbadv_setup_101049_Thiton(true, 8, 16,0)  


	
	setup_complete_unit()
	

	
	dot_unit_dir(dotLaiens1,2)


	
	
	dot_disp_weapon(dotNoir2, false)  
	dot_disp_weapon(dotLancelot3, false)  
	dot_disp_weapon(dotTyrfing1, false)  
	dot_disp_weapon(dotDinatan, false)  
	dot_disp_weapon(dotGwenhwymawr1, false)  
	dot_disp_weapon(dotGuinevere, false)  
	dot_disp_weapon(dotMaladisant1, false)  
	dot_disp_weapon(dotLucius, false)  
	dot_disp_weapon(dotLaiens1, false)  

	


	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotGliton, false)
	dot_disp_unit(dotTyronoe, false)
	dot_disp_unit(dotThiten, false)
	dot_disp_unit(dotThiton, false)

	
	dot_disp_unit(dotLucius, false)


	dot_unit_dir(dotLaiens1,2)
	dot_change_anim(dotLaiens1,1)
	dot_change_anim(dotNoir2, 1)
	dot_change_anim(dotDinatan, 1)

	
	change_camera_distance(7.0, 0.0)

	
	change_camera_angle(34.0, 0.0)
	
	
	move_camera(3, 18, 0.0)


	
	Ef_VanishDust = load_particle("content_effect3d_common_adv","Ef_C_Adv_VanishDust", false, true) 
	Ef_KillersDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true) 

	Ef_Witch1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)

	Ef_Witch9 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)

	Ef_Black1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Black2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Black3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Black4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Black5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Black6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Black7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Black8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)

	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	Ef_Fog2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)

	Ef_Portal1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Portal2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Portal3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Portal4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Portal5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Portal6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Portal7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Portal8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Portal9 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)

	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	Ef_WitchSpear2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	Ef_WitchSpear3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	Ef_WitchSpear4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_021", false, true)
	Ef_WitchSpear5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_022", false, true)
	Ef_WitchSpear6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_023", false, true)
	Ef_WitchSpear7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_024", false, true)
	Ef_WitchSpear8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_025", false, true)

	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)

	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)

	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	load_sound("BGM_ADV_Serious2")
	movie_load("MA_01108_54")

end





function Play()


	movie_set_active(true)
	movie_play()

	fadein(0)
	Play_start(true)

	movie_wait_playing()
	movie_stop()
	wait_time(MOVIE_AFTER)
	
	wait_time(1)

	move_camera(8, 18, 2.0)
	wait_camera()

	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_540021")
	close_speech_window()


	dot_change_anim(dotNoir2, 0)
	dot_change_anim(dotDinatan, 0)

	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotGuinevere,3)


	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01108_540022")
	close_speech_window()

	
	on_active(Ef_WitchSpear1) 
	on_active(Ef_WitchSpear2) 
	on_active(Ef_WitchSpear3) 
	on_active(Ef_WitchSpear4) 
	on_active(Ef_WitchSpear5) 
	on_active(Ef_WitchSpear6) 
	on_active(Ef_WitchSpear7) 
	on_active(Ef_WitchSpear8) 

	on_active(Ef_WSpearAppea1) 
	on_active(Ef_WSpearAppea2) 
	on_active(Ef_WSpearAppea3) 
	on_active(Ef_WSpearAppea4) 
	on_active(Ef_WSpearAppea5) 
	on_active(Ef_WSpearAppea6) 
	on_active(Ef_WSpearAppea7) 
	on_active(Ef_WSpearAppea8) 

	on_active(Ef_WSpearAura1) 
	on_active(Ef_WSpearAura2) 
	on_active(Ef_WSpearAura3) 
	on_active(Ef_WSpearAura4) 
	on_active(Ef_WSpearAura5) 
	on_active(Ef_WSpearAura6) 
	on_active(Ef_WSpearAura7) 
	on_active(Ef_WSpearAura8) 

	local gridpos = get_grid_position(9, 18)
	gridpos[2] = 1.5	
	set_pos(Ef_WSpearAppea1, gridpos)
	turn(Ef_WSpearAppea1,45, 90, 0, 0.0)
	play_particle(Ef_WSpearAppea1)

	local gridpos = get_grid_position(9, 17)
	gridpos[2] = 1.5
	set_pos(Ef_WSpearAppea2, gridpos)
	turn(Ef_WSpearAppea2,45, 45, 0, 0.0)
	play_particle(Ef_WSpearAppea2)

	local gridpos = get_grid_position(9, 19)
	gridpos[2] = 1.5
	set_pos(Ef_WSpearAppea3, gridpos)
	turn(Ef_WSpearAppea3,45, 135, 0, 0.0)
	play_particle(Ef_WSpearAppea3)

	local gridpos = get_grid_position(8, 19)
	gridpos[2] = 1.5
	set_pos(Ef_WSpearAppea4, gridpos)
	turn(Ef_WSpearAppea4, 45, 180, 0, 0.0)
	play_particle(Ef_WSpearAppea4)

	local gridpos = get_grid_position(7, 19)
	gridpos[2] = 1.5
	set_pos(Ef_WSpearAppea5, gridpos)
	turn(Ef_WSpearAppea5, 45, -135, 0, 0.0)
	play_particle(Ef_WSpearAppea5)

	local gridpos = get_grid_position(7, 18)
	gridpos[2] = 1.5
	set_pos(Ef_WSpearAppea6, gridpos)
	turn(Ef_WSpearAppea6, 45, -90, 0, 0.0)
	play_particle(Ef_WSpearAppea6)

	local gridpos = get_grid_position(7, 17)
	gridpos[2] = 1.5
	set_pos(Ef_WSpearAppea7, gridpos)
	turn(Ef_WSpearAppea7, 45, -45, 0, 0.0)
	play_particle(Ef_WSpearAppea7)

	local gridpos = get_grid_position(8, 17)
	gridpos[2] = 1.5
	set_pos(Ef_WSpearAppea8, gridpos)
	turn(Ef_WSpearAppea8, 45, 0, 0, 0.0)
	play_particle(Ef_WSpearAppea8)

	wait_time(0.5)
	
	
	local gridpos = get_grid_position(9, 18)
	gridpos[2] = 1.5
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1, 45, 90, 0, 0.0)
	play_particle(Ef_WitchSpear1)

	set_pos(Ef_WSpearAura1, gridpos)
	turn(Ef_WSpearAura1,45, 90, 0, 0.0)
	play_particle(Ef_WSpearAura1)

	
	local gridpos = get_grid_position(9, 17)
	gridpos[2] = 1.5
	set_pos(Ef_WitchSpear2, gridpos)
	turn(Ef_WitchSpear2, 45, 45, 0, 0.0)
	play_particle(Ef_WitchSpear2)
	
	set_pos(Ef_WSpearAura2, gridpos)
	turn(Ef_WSpearAura2,45, 45, 0, 0.0)
	play_particle(Ef_WSpearAura2)

	
	local gridpos = get_grid_position(9, 19)
	gridpos[2] = 1.5
	set_pos(Ef_WitchSpear3, gridpos)
	turn(Ef_WitchSpear3, 45, 135, 0, 0.0)
	play_particle(Ef_WitchSpear3)
	
	set_pos(Ef_WSpearAura3, gridpos)
	turn(Ef_WSpearAura3,45, 135, 0, 0.0)
	play_particle(Ef_WSpearAura3)

	
	local gridpos = get_grid_position(8, 19)
	gridpos[2] = 1.5
	set_pos(Ef_WitchSpear4, gridpos)
	turn(Ef_WitchSpear4, 45, 180, 0, 0.0)
	play_particle(Ef_WitchSpear4)
	
	set_pos(Ef_WSpearAura4, gridpos)
	turn(Ef_WSpearAura4, 45, 180, 0, 0.0)
	play_particle(Ef_WSpearAura4)

	
	local gridpos = get_grid_position(7, 19)
	gridpos[2] = 1.5
	set_pos(Ef_WitchSpear5, gridpos)
	turn(Ef_WitchSpear5, 45, -135, 0, 0.0)
	play_particle(Ef_WitchSpear5)
	
	set_pos(Ef_WSpearAura5, gridpos)
	turn(Ef_WSpearAura5, 45, -135, 0, 0.0)
	play_particle(Ef_WSpearAura6)
	
	
	local gridpos = get_grid_position(7, 18)
	gridpos[2] = 1.5
	set_pos(Ef_WitchSpear6, gridpos)
	turn(Ef_WitchSpear6, 45, -90, 0, 0.0)
	play_particle(Ef_WitchSpear6)
	
	set_pos(Ef_WSpearAura6, gridpos)
	turn(Ef_WSpearAura6, 45, -90, 0, 0.0)
	play_particle(Ef_WSpearAura6)

	
	local gridpos = get_grid_position(7, 17)
	gridpos[2] = 1.5
	set_pos(Ef_WitchSpear7, gridpos)
	turn(Ef_WitchSpear7, 45, -45, 0, 0.0)
	play_particle(Ef_WitchSpear7)
	
	set_pos(Ef_WSpearAura8, gridpos)
	turn(Ef_WSpearAura8, 45, -45, 0, 0.0)
	play_particle(Ef_WSpearAura8)

	
	local gridpos = get_grid_position(8, 17)
	gridpos[2] = 1.5
	set_pos(Ef_WitchSpear8, gridpos)
	turn(Ef_WitchSpear8, 45, 0, 0, 0.0)
	play_particle(Ef_WitchSpear8)
	
	set_pos(Ef_WSpearAura8, gridpos)
	turn(Ef_WSpearAura8, 45, 0, 0, 0.0)
	play_particle(Ef_WSpearAura8)

	wait_time(1.0)

	local gridpos = get_grid_position(8, 18)
	gridpos[2] = -0.2

	slidemove(Ef_WitchSpear1, gridpos, 0.1)
	slidemove(Ef_WSpearAura1, gridpos, 0.1)

	slidemove(Ef_WitchSpear2, gridpos, 0.1)
	slidemove(Ef_WSpearAura2, gridpos, 0.1)

	slidemove(Ef_WitchSpear3, gridpos, 0.1)
	slidemove(Ef_WSpearAura3, gridpos, 0.1)

	slidemove(Ef_WitchSpear4, gridpos, 0.1)
	slidemove(Ef_WSpearAura4, gridpos, 0.1)

	slidemove(Ef_WitchSpear5, gridpos, 0.1)
	slidemove(Ef_WSpearAura5, gridpos, 0.1)

	slidemove(Ef_WitchSpear6, gridpos, 0.1)
	slidemove(Ef_WSpearAura6, gridpos, 0.1)

	slidemove(Ef_WitchSpear7, gridpos, 0.1)
	slidemove(Ef_WSpearAura7, gridpos, 0.1)

	slidemove(Ef_WitchSpear8, gridpos, 0.1)
	slidemove(Ef_WSpearAura8, gridpos, 0.1)

	wait_time(0.1)

	on_active(Ef_WitchSpearHit1) 
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)

	
	
	bgm_play("BGM_ADV_Serious2")
	
	change_face(Laiens1, "Sad")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_540024")
	close_speech_window()

	

	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01108_540026")
	

	
	
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotGuinevere,2)
	


	se_play("SE_ADV_MA_01106_01_Footstep")		
	
	change_face(Lucius, "Normal")
	
	message("MA_01108_540028")
	close_speech_window()

	
	on_active(Ef_Witch9) 
	
	local gridpos = get_grid_position(8, 18)
	set_pos(Ef_Witch9, gridpos)
	play_particle(Ef_Witch9)

	wait_time(0.5)

	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WSpearAura1)

	stop_particle(Ef_WitchSpear2)
	stop_particle(Ef_WSpearAura2)

	stop_particle(Ef_WitchSpear3)
	stop_particle(Ef_WSpearAura3)
	
	stop_particle(Ef_WitchSpear4)
	stop_particle(Ef_WSpearAura4)

	stop_particle(Ef_WitchSpear5)
	stop_particle(Ef_WSpearAura5)

	stop_particle(Ef_WitchSpear6)
	stop_particle(Ef_WSpearAura6)

	stop_particle(Ef_WitchSpear7)
	stop_particle(Ef_WSpearAura7)

	stop_particle(Ef_WitchSpear8)
	stop_particle(Ef_WSpearAura8)


	
	on_active(Ef_Witch1) 
	
	local gridpos = get_grid_position(9, 18)
	set_pos(Ef_Witch1, gridpos)
	play_particle(Ef_Witch1)

	on_active(Ef_Witch2) 
	
	local gridpos = get_grid_position(9, 19)
	set_pos(Ef_Witch2, gridpos)
	play_particle(Ef_Witch2)

	on_active(Ef_Witch3) 
	
	local gridpos = get_grid_position(8, 19)
	set_pos(Ef_Witch3, gridpos)
	play_particle(Ef_Witch3)

	on_active(Ef_Witch4) 
	
	local gridpos = get_grid_position(7, 19)
	set_pos(Ef_Witch4, gridpos)
	play_particle(Ef_Witch4)

	on_active(Ef_Witch5) 
	
	local gridpos = get_grid_position(7, 18)
	set_pos(Ef_Witch5, gridpos)
	play_particle(Ef_Witch5)

	on_active(Ef_Witch6) 
	
	local gridpos = get_grid_position(7, 17)
	set_pos(Ef_Witch6, gridpos)
	play_particle(Ef_Witch6)

	on_active(Ef_Witch7) 
	
	local gridpos = get_grid_position(9, 17)
	set_pos(Ef_Witch7, gridpos)
	play_particle(Ef_Witch7)

	on_active(Ef_Witch8) 
	
	local gridpos = get_grid_position(8, 17)
	set_pos(Ef_Witch8, gridpos)
	play_particle(Ef_Witch8)

	
	on_active(Ef_Black1) 
	
	local gridpos = get_grid_position(9, 18)
	set_pos(Ef_Black1, gridpos)
	play_particle(Ef_Black1)

	on_active(Ef_Black2) 
	
	local gridpos = get_grid_position(9, 19)
	set_pos(Ef_Black2, gridpos)
	play_particle(Ef_Black2)

	on_active(Ef_Black3) 
	
	local gridpos = get_grid_position(8, 19)
	set_pos(Ef_Black3, gridpos)
	play_particle(Ef_Black3)

	on_active(Ef_Black4) 
	
	local gridpos = get_grid_position(7, 19)
	set_pos(Ef_Black4, gridpos)
	play_particle(Ef_Black4)

	on_active(Ef_Black5) 
	
	local gridpos = get_grid_position(7, 18)
	set_pos(Ef_Black5, gridpos)
	play_particle(Ef_Black5)

	on_active(Ef_Black6) 
	
	local gridpos = get_grid_position(7, 17)
	set_pos(Ef_Black6, gridpos)
	play_particle(Ef_Black6)

	on_active(Ef_Black7) 
	
	local gridpos = get_grid_position(9, 17)
	set_pos(Ef_Black7, gridpos)
	play_particle(Ef_Black7)

	on_active(Ef_Black8) 
	
	local gridpos = get_grid_position(8, 17)
	set_pos(Ef_Black8, gridpos)
	play_particle(Ef_Black8)


	wait_time(1.0)

	dot_place_unit(dotMazoe,9, 17)
	dot_place_unit(dotThiton,8, 17)

	dot_disp_unit(dotMoronoe, true)
	dot_disp_unit(dotMazoe, true)
	dot_disp_unit(dotGliten, true)
	dot_disp_unit(dotGlitonea, true)
	dot_disp_unit(dotGliton, true)
	dot_disp_unit(dotTyronoe, true)
	dot_disp_unit(dotThiten, true)
	dot_disp_unit(dotThiton, true)
	dot_disp_unit(dotLucius, true)

	
	move_camera(6, 18, 2.0)
	change_camera_distance(8.0, 2.0)
	dot_move_unit_seq(dotLucius, 6, 21)
	
	wait_seq()

	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotGuinevere,3)

	dot_move_unit_seq(dotLucius, 6, 18)
	
	wait_seq()
	wait_camera()

	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01108_540030")
	close_speech_window()


	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_540031")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01108_540032")
	close_speech_window()

	
	on_active(Ef_Fog2) 
	
	local gridpos = get_grid_position(8, 18)
	set_pos(Ef_Fog2, gridpos)
	play_particle(Ef_Fog2)

	
	change_face(Laiens1, "Sad")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_540034")
	

	
	change_face(Laiens1, "Normal")
	
	message("MA_01108_540035")
	

	
	change_face(Laiens1, "Normal")
	
	message("MA_01108_540036")
	

	
	change_face(Laiens1, "Sad")
	
	message("MA_01108_540037")
	close_speech_window()

	
	on_active(Ef_Fog) 
	
	local gridpos = get_grid_position(8, 18)
	set_pos(Ef_Fog, gridpos)
	play_particle(Ef_Fog)

	wait_time(0.5)
	
	dot_disp_unit(dotLaiens1, false)

	stop_particle(Ef_Fog2)

	wait_time(2.0)

	
	
	dot_unit_dir(dotLucius,2)

	
	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01108_540039")
	

	
	change_face(Lucius, "Anger")
	
	message("MA_01108_540040")
	

	
	change_face(Lucius, "Anger")
	
	message("MA_01108_540041")
	

	
	change_face(Lucius, "Anger")
	
	message("MA_01108_540042")
	

	
	change_face(Lucius, "Normal")
	
	message("MA_01108_540043")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_540044")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01108_540045")
	

	
	change_face(Lucius, "Anger")
	
	message("MA_01108_540046")
	

	
	change_face(Lucius, "Normal")
	
	message("MA_01108_540047")
	

	
	
	change_face(Lucius, "Normal")
	
	message("MA_01108_540049")
	close_speech_window()

	
	on_active(Ef_Portal1) 
	
	local gridpos = get_grid_position(9, 18)
	set_pos(Ef_Portal1, gridpos)
	set_scale(Ef_Portal1, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal1)

	on_active(Ef_Portal2) 
	
	local gridpos = get_grid_position(9, 19)
	set_pos(Ef_Portal2, gridpos)
	set_scale(Ef_Portal2, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal2)

	on_active(Ef_Portal3) 
	
	local gridpos = get_grid_position(8, 19)
	set_pos(Ef_Portal3, gridpos)
	set_scale(Ef_Portal3, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal3)

	on_active(Ef_Portal4) 
	
	local gridpos = get_grid_position(7, 19)
	set_pos(Ef_Portal4, gridpos)
	set_scale(Ef_Portal4, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal4)

	on_active(Ef_Portal5) 
	
	local gridpos = get_grid_position(7, 18)
	set_pos(Ef_Portal5, gridpos)
	set_scale(Ef_Portal5, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal5)

	on_active(Ef_Portal6) 
	
	local gridpos = get_grid_position(7, 17)
	set_pos(Ef_Portal6, gridpos)
	set_scale(Ef_Portal6, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal6)

	on_active(Ef_Portal7) 
	
	local gridpos = get_grid_position(9, 17)
	set_pos(Ef_Portal7, gridpos)
	set_scale(Ef_Portal7, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal7)

	on_active(Ef_Portal8) 
	
	local gridpos = get_grid_position(8, 17)
	set_pos(Ef_Portal8, gridpos)
	set_scale(Ef_Portal8, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal8)

	on_active(Ef_Portal9) 
	
	local gridpos = get_grid_position(6, 18)
	set_pos(Ef_Portal9, gridpos)
	set_scale(Ef_Portal9, {0.8, 0.8, 0.8})
	play_particle(Ef_Portal9)

	wait_time(1.0)

	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotGliton, false)
	dot_disp_unit(dotTyronoe, false)
	dot_disp_unit(dotThiten, false)
	dot_disp_unit(dotThiton, false)
	dot_disp_unit(dotLucius, false)

	
	wait_time(3.0)

	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 4, 17,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 4, 18,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 3, 16,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 2, 17,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 0, 18,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 0, 16,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 0, 17,0)
	pbadv_setup_101058_Laiens_preload(1,true, 8, 18,0)
	pbadv_setup_101051_Lucius_preload(0,true, 0, 21,0)
	pbadv_setup_101042_Moronoe_preload(true, 9, 18,0)
	pbadv_setup_101043_Mazoe_preload(true, 9, 16,0)
	pbadv_setup_101044_Gliten_preload(true, 9, 19,0)
	pbadv_setup_101045_Glitonea_preload(true, 8, 19,0)
	pbadv_setup_101046_Gliton_preload(true, 7, 19,0)
	pbadv_setup_101047_Tyronoe_preload(true, 7, 18,0)
	pbadv_setup_101048_Thiten_preload(true, 7, 17,0)
	pbadv_setup_101049_Thiton_preload(true, 8, 16,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VanishDust", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
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
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_021", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_022", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_023", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_024", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_025", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	preload_sound("BGM_ADV_Serious2")
	movie_load_preload("MA_01108_54")
end
