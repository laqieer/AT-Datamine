
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201010000", "201010000")
	
	
	change_time_and_weather(2, 1)

	
	pbadv_setup_101030_Elaine(1,true, 31, 11,0)  
	pbadv_setup_101037_Rasia(1,true, 33, 11,0) 
	pbadv_setup_101031_Lovein(1,true, 31, 12,0)  
	pbadv_setup_101044_Gliten(true, 30, 11,0) 
	pbadv_setup_101052_Vernarth(0,true, 30, 18,0)  


setup_complete_unit()

	
	Ef_WitchDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	Ef_VanishDust = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true) 
	Ef_KillersDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true) 
	
	
	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)


	dot_unit_dir(dotVernarth, 3)
	dot_unit_dir(dotGliten, 3)
	dot_unit_dir(dotElaine1, 3)
	dot_unit_dir(dotRasia1, 3)
	dot_unit_dir(dotLovein1, 3)
	
	
	dot_disp_weapon(dotVernarth, false)
	dot_disp_weapon(dotElaine1, false)
	dot_disp_weapon(dotRasia1, false)
	dot_disp_weapon(dotLovein1, false)

	
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotVernarth, false)
	
	
	dot_change_anim(dotRasia1,1)


	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(31, 12, 0.0)
	
	load_image("101030310","content_still_10103031_image","101030310_StillImage")	
	load_image("101010150", "content_still_10101015_image", "101010150_StillImage")

	load_sound("BGM_Battle_Tragedy_TragedyStart")

	movie_load("MA_01A900_52_01")

end



function Play()
	fadein(0)
	Play_start(true)
	
	
	change_face(Elaine1, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_520002")
	close_speech_window()
	
	
	dot_unit_dir(dotRasia1, 2)
	
	
	wait_time(0.3)	

	
	change_face(Elaine1, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_520004")
	close_speech_window()

	
	change_face(Rasia1, "Pain")	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia1)
	message("MA_01A900_520005")
	close_speech_window()

	
	change_face(Elaine1, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_520006")
	close_speech_window()

	
	change_face(Rasia1, "Pain")	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia1)
	message("MA_01A900_520008")
	
	change_face(Rasia1, "Sad")	
	message("MA_01A900_520009")
	close_speech_window()

	
	change_face(Elaine1, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_520010")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dotElaine1, 32, 0)
	dot_reserve_move_unit_seq(dotLovein1, 32, 1)
	exec_parallel_seq()
	wait_seq()
	
	
	wait_time(0.5)	
	
	
	
	
	dot_disp_unit(dotVernarth, true)
	dot_move_unit_seq(dotVernarth, 31, 11)	
	
	wait_seq()	

	
	change_face(Vernarth, "Normal")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01A900_520012")
	close_speech_window()

	
	change_face(Rasia1, "Sad")	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia1)
	message("MA_01A900_520014")
	close_speech_window()

	
	change_face(Vernarth, "Sad")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01A900_520015")
	
	change_face(Vernarth, "Sad")
	message("MA_01A900_520016")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	


	on_active(Ef_WSpearAppea1) 

	local gridpos = get_grid_position(30, 11) 
	gridpos[2] = 2.0	
	set_pos(Ef_WSpearAppea1, gridpos)
	turn(Ef_WSpearAppea1,45, -90, 0, 0.0) 
	play_particle(Ef_WSpearAppea1)

	wait_time(0.5)
	
	on_active(Ef_WitchSpear1) 

	local gridpos = get_grid_position(30, 11)
	gridpos[2] = 3.0 
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,45, -90, 0, 0.0) 
	play_particle(Ef_WitchSpear1)


	on_active(Ef_WSpearAura1) 

	set_pos(Ef_WSpearAura1, gridpos)
	turn(Ef_WSpearAura1,45, -90, 0, 0.0) 
	play_particle(Ef_WSpearAura1)
	
	wait_time(1.0)


	local gridpos = get_grid_position(32, 11) 
	gridpos[2] = 1.5

	slidemove(Ef_WitchSpear1, gridpos, 0.1) 
	slidemove(Ef_WSpearAura1, gridpos, 0.1) 

	wait_time(0.3)


	on_active(Ef_WitchSpearHit1) 

	local gridpos = get_grid_position(31, 11)
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)

	dot_change_anim(dotVernarth,6)
	
	wait_time(0.5)
	
	dot_change_anim(dotVernarth,1)
	stop_particle(Ef_WitchSpear1)
	
	wait_time(0.5)
	



	on_active(Ef_BlFeather)
	on_active(Ef_WitchChange2)

	local gridpos = get_grid_position(30, 11)
	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)

	local gridpos = get_grid_position(30, 11)
	set_pos(Ef_WitchChange2, gridpos)
	play_particle(Ef_WitchChange2)

	wait_time(1.0)


	stop_particle(Ef_WSpearAura1)
	
	wait_time(0.5)	
	dot_disp_unit(dotGliten, true)

	wait_time(1.5)



	bgm_play("BGM_Battle_Tragedy_TragedyStart")
	
	change_face(Gliten, "Anger")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A900_520018")
	close_speech_window()

	
	change_face(Rasia1, "Anger")	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia1)
	message("MA_01A900_520019")
	close_speech_window()

	
	change_face(Gliten, "Anger")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A900_520020")
	close_speech_window()
	
	
	on_active(Ef_WitchDie) 

	local gridpos = get_grid_position(30, 11)
	set_pos(Ef_WitchDie, gridpos)
	play_particle(Ef_WitchDie)

	wait_time(1.0)

	dot_disp_unit(dotGliten, false)
	dot_remove_unit(dotGliten)

	wait_time(2.0)	

	
	
	move_camera(31, 12, 0.3)
	wait_camera()

	
	change_face(Vernarth, "Sad")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01A900_520022")
	close_speech_window()

	
	on_active(Ef_VanishDust)

	local gridpos = get_grid_position(33, 11)
	set_pos(Ef_VanishDust, gridpos)
	play_particle(Ef_VanishDust)

	
	change_face(Rasia1, "Sad")	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia1)
	message("MA_01A900_520023")
	
	change_face(Rasia1, "Sad")	
	message("MA_01A900_520025")
	close_speech_window()
	
	
	close_textbox_base()
	disableTextBox = true
	
	dot_play_particle_unit(dotVernarth,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	dot_disp_unit(dotVernarth, false)

	
	fadeout(255,255,255,1.0, FADE_TIME)
	wait_time(FADE_TIME)	

	show_image("101010150", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	movie_set_active(true)
	movie_play()



	movie_wait_playing()
	movie_stop()
	wait_time(MOVIE_AFTER)


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101030_Elaine_preload(1,true, 31, 11,0)
	pbadv_setup_101037_Rasia_preload(1,true, 33, 11,0)
	pbadv_setup_101031_Lovein_preload(1,true, 31, 12,0)
	pbadv_setup_101044_Gliten_preload(true, 30, 11,0)
	pbadv_setup_101052_Vernarth_preload(0,true, 30, 18,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_image_preload("101030310","content_still_10103031_image","101030310_StillImage")
	load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	preload_sound("BGM_Battle_Tragedy_TragedyStart")
	movie_load_preload("MA_01A900_52_01")
end
