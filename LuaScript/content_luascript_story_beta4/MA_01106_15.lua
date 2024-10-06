

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	init_psbattleadv("201160100", "201160100")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 20, 10,0)  
	pbadv_setup_101001_Tyrfing(2,true, 20, 9,0)  
	pbadv_setup_101012_Dinatan(0,true, 23, 11,0)
	pbadv_setup_101017_Maladisant(0,true, 24, 11,0)  
	pbadv_setup_101010_Lancelot(3,true, 18, 10,0)  
	pbadv_setup_101014_Tristan(0,true, 20, 13,0)  
	pbadv_setup_101019_Isolde(0,true, 19, 13,0)  
	pbadv_setup_101011_Guinevere(0,true, 19, 12,0)  
	pbadv_setup_101016_Gwenhwymawr(0,true, 18, 12,0)  
		
	pbadv_setup_101050_Brian(0,true,33, 12,0)
	pbadv_setup_101043_Mazoe(true, 28, 11,0)  
	pbadv_setup_101041_Morgan(2,true, 34, 13,0) 

	barbaroi1 = dot_reserve_enemy(42, 26, 10, 0)
	barbaroi2 = dot_reserve_enemy(1301, 25, 11, 0)
	barbaroi3 = dot_reserve_enemy(42, 26, 12, 0)
		
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotTyrfing2, 2)
	dot_unit_dir(dotDinatan, 3)
	dot_unit_dir(dotMaladisant, 2)
	dot_unit_dir(dotTristan, 2)
	dot_unit_dir(dotLancelot3, 3)
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGwenhwymawr, 3)
	dot_unit_dir(dotIsolde, 3)
	
	dot_unit_dir(dotMazoe, 2)
	dot_unit_dir(dotBrian, 2)
	dot_unit_dir(barbaroi1, 2)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 2)
	
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotTyrfing2, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotMaladisant, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotTristan, false)
	dot_disp_weapon(dotIsolde, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr, false)
	dot_disp_weapon(dotBrian, false) 
	dot_disp_weapon(dotMazoe, false)
	dot_disp_weapon(dotMorgan2, false)

	
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotBrian, false)
	dot_disp_unit(dotMorgan2, false)
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	
	
	
	Ef_WitchPortal = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	
	Ef_baruba1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	
	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(23, 12, 0.0)

	load_sound("BGM_ADV_Serious2")
end





function Play()
	fadein(0)
	Play_start(true)




	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150003")
	close_speech_window()


	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150004")
	close_speech_window()


	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150005")

	message("MA_01106_150006")

	change_face(Maladisant, "Smile")
	message("MA_01106_150007")

	change_face(Maladisant, "Shy")
	message("MA_01106_150008")
	close_speech_window()


	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150009")
	close_speech_window()


	change_face(Maladisant, "Smile")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150010")
	close_speech_window()


	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150011")
	close_speech_window()


	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150012")
	close_speech_window()


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150013")
	close_speech_window()


	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150014")
	close_speech_window()


	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150015")
	close_speech_window()


	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150016")
	close_speech_window()
	
	
	move_camera(26, 12, 0.7)	
	wait_camera()


	on_active(Ef_WSpearAppea1) 

	local gridpos = get_grid_position(28, 11) 
	gridpos[2] = 3.0	
	set_pos(Ef_WSpearAppea1, gridpos)
	turn(Ef_WSpearAppea1,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAppea1)

	wait_time(0.5)
	
	on_active(Ef_WitchSpear1) 

	local gridpos = get_grid_position(28, 11)
	gridpos[2] = 4.0 
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear1)


	on_active(Ef_WSpearAura1) 

	set_pos(Ef_WSpearAura1, gridpos)
	turn(Ef_WSpearAura1,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAura1)
	
	wait_time(1.0)





	local gridpos = get_grid_position(28, 11) 
	gridpos[2] = 1.5

	slidemove(Ef_WitchSpear1, gridpos, 0.1) 
	slidemove(Ef_WSpearAura1, gridpos, 0.1) 
	
	se_play("SE_ADV_MA_01106_15_Whitch_Spr_Ground")

	wait_time(1.0)









	

	

	









	on_active(Ef_BlFeather)
	on_active(Ef_WitchChange2)

	local gridpos = get_grid_position(28, 11)
	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)

	local gridpos = get_grid_position(28, 11)
	set_pos(Ef_WitchChange2, gridpos)
	play_particle(Ef_WitchChange2)

	wait_time(0.5)

	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WSpearAura1)
	
	wait_time(0.5)

	dot_disp_unit(dotMazoe, true)

	wait_time(2.0)



	bgm_play("Stop_BGM_Bus_2")

	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150018")
	close_speech_window()
	

	bgm_play("BGM_ADV_Serious2")

	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_NAMELES", nil, Mazoe)
	message("MA_01106_150020")

	change_face(Mazoe, "Smile")
	message("MA_01106_150022")
	close_speech_window()
	
	
	move_camera(25, 12, 0.5)
	
	
	dot_reserve_move_unit_seq(dotMazoe, 27, 11) 
	exec_parallel_seq()
	wait_seq()

	
	wait_time(0.5)	
	
	
	dot_unit_dir(dotMaladisant, 3)


	change_face(Maladisant, "Surprise")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150024")
	close_speech_window()
	

	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_NAMELES", nil, Mazoe)
	message("MA_01106_150025")
	close_speech_window()	
	

	change_face(Maladisant, "Pain")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150027")
	close_speech_window()	
	
	
	on_active(Ef_Fog) 

	local gridpos = get_grid_position(24, 11)
	set_pos(Ef_Fog, gridpos)
	play_particle(Ef_Fog)

	wait_time(0.5)	
	
	
	dot_change_anim(dotMaladisant,1)


	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150028")
	close_speech_window()
	
	
	dot_disp_weapon(dotTristan, true)	
	
	
	dot_reserve_move_unit_seq(dotTristan, 22, 12)
	exec_parallel_seq()
	wait_seq()	
	
	
	dot_attack_seq(dotTristan,dotMazoe)	
	dot_dodge_seq(dotMazoe)
	wait_seq()
	
	
	
	move_camera(22, 12, 0.5)


	dot_reserve_move_unit_seq(dotNoir2, 22, 10)
	dot_reserve_move_unit_seq(dotTyrfing2, 22, 9)
	dot_reserve_move_unit_seq(dotLancelot3, 21, 10)
	dot_reserve_move_unit_seq(dotGuinevere, 21, 11)
	dot_reserve_move_unit_seq(dotGwenhwymawr, 20, 10)
	dot_reserve_move_unit_seq(dotIsolde, 20, 12)
	exec_parallel_seq()
	wait_seq()
	
	
	dot_change_anim(dotTristan,0)


	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01106_150030")
	close_speech_window()


	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_150031")
	close_speech_window()


	change_face(Lancelot3, "Anger")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01106_150032")
	close_speech_window()


	change_face(Tyrfing2, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	message("MA_01106_150034")
	close_speech_window()


	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_150035")
	close_speech_window()

	move_camera(25, 12, 0.7)	
	wait_time(0.7)

	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_150036")
	close_speech_window()	


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150037")
	close_speech_window()


	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01106_150039")
	close_speech_window()	
	
	dot_disp_unit(dotBrian, true)
	dot_disp_unit(dotMorgan2, true)
	
	dot_reserve_move_unit_seq(dotBrian, 27, 12)	
	dot_reserve_move_unit_seq(dotMorgan2, 28, 13)	
	exec_parallel_seq()
	wait_seq()


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_150040")
	close_speech_window()


	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01106_150042")
	close_speech_window()


	change_face(Morgan2, "Anger")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01106_150043")
	close_speech_window()


	change_face(Maladisant, "Anger")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150044")
	close_speech_window()	


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150045")
	close_speech_window()
	

	change_face(Brian, "Smile") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_150046")
	OpenFirstAppearance(Brian)
	close_speech_window()	
	

	change_face(Maladisant, "Surprise")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_150047")
	close_speech_window()	


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_150048")

	change_face(Dinatan, "Sad")
	message("MA_01106_150049")
	close_speech_window()	


	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_150051")
	close_speech_window()	
	

	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_150052")
	close_speech_window()		
	
	
	on_active(Ef_baruba1)
	local gridpos = get_grid_position(26,10)
	set_pos(Ef_baruba1, gridpos)
	set_scale(Ef_baruba1, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba1)
	
	on_active(Ef_baruba2)
	local gridpos = get_grid_position(25,11)
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2)
	
	on_active(Ef_baruba3)
	local gridpos = get_grid_position(26,12)
	set_pos(Ef_baruba3, gridpos)
	set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3)

	wait_time(0.2)	
	
	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	
	wait_time(2.0)	

	

	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_150054")
	close_speech_window()		


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 10,0)
	pbadv_setup_101001_Tyrfing_preload(2,true, 20, 9,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 23, 11,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 24, 11,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 18, 10,0)
	pbadv_setup_101014_Tristan_preload(0,true, 20, 13,0)
	pbadv_setup_101019_Isolde_preload(0,true, 19, 13,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 19, 12,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true, 18, 12,0)
	pbadv_setup_101050_Brian_preload(0,true,33, 12,0)
	pbadv_setup_101043_Mazoe_preload(true, 28, 11,0)
	pbadv_setup_101041_Morgan_preload(2,true, 34, 13,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	preload_sound("BGM_ADV_Serious2")
end
