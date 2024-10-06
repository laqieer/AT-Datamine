
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201070100", "201070100")
	change_time_and_weather(1,1) 

	load_image("10301009", "content_still_10301009_image", "103010090_StillImage")
	load_image("10301003", "content_still_10301003_image", "103010030_StillImage")
	load_image("10301010", "content_still_10301010_image", "103010100_StillImage")
	load_image("10301011", "content_still_10301011_image", "103010110_StillImage")
	load_image("10301012", "content_still_10301012_image", "103010120_StillImage")
	load_image("103010122", "content_still_10301012_image", "103010120_StillImage")
	load_image("10301013", "content_still_10301013_image", "103010130_StillImage")
	load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010151", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010152", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010153", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010154", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010155", "content_still_10101015_image", "101010150_StillImage")
	load_image("103010260", "content_still_10301026_image", "103010260_StillImage")
	

	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)

	
	pbadv_setup_101009_Noir(2,true, 20, 19,0)  
	pbadv_setup_101012_Dinatan(0,true, 21, 19,0)
	pbadv_setup_101017_Maladisant(0,true, 19, 19,0)  
	pbadv_setup_101001_Tyrfing(1,true, 22, 19,0)  

	pbadv_setup_101014_Tristan(0,true, 19, 20,0)  
	pbadv_setup_101018_Ragnar(1,true, 20, 20,0)  
	pbadv_setup_101013_Gawain(0,true, 21, 20,0)  
	pbadv_setup_101011_Guinevere(0,true, 19, 21,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 20, 21,0)  
	pbadv_setup_101019_Isolde(1,true, 21, 21,0)  
	
	pbadv_setup_101017_Maladisant(1,true, 21, 26,0)  
	pbadv_setup_101050_Brian(0,true, 30, 30,0)  

	pbadv_setup_101041_Morgan(2,true, 20, 3,0) 
	pbadv_setup_101015_Arthur(0,true, 20, 16,0)  
	
	pbadv_setup_101043_Mazoe(true,20, 1,0)  
	
	pbadv_setup_101047_Tyronoe(true, 20, 6,0) 
	pbadv_setup_101048_Thiten(true, 19, 9,0)  
	pbadv_setup_101049_Thiton(true, 21, 9,0)  
	barbaroi1 = dot_reserve_enemy(1, 17, 9, 0)
	barbaroi2 = dot_reserve_enemy(1100, 23, 9, 0)
	barbaroi3 = dot_reserve_enemy(42, 17, 11, 0)
	barbaroi4 = dot_reserve_enemy(1, 23, 11, 0)


setup_complete_unit()

	
	dot_disp_unit(dotMaladisant1, false)
	
	dot_unit_dir(barbaroi1, 3)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 3)
	dot_unit_dir(barbaroi4, 2)


	






	
	dot_disp_unit(dotArthur, false)
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotTyronoe, false)
	dot_disp_unit(dotThiten, false)
	dot_disp_unit(dotThiton, false)
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	
	
	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	Ef_WitchSpear2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	Ef_WitchSpear3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_021", false, true)
	Ef_WitchSpear4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_022", false, true)
	Ef_WitchSpear5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_023", false, true)
	Ef_WitchSpear6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_024", false, true)
	Ef_WitchSpear7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_025", false, true)
	
	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)

	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	Ef_WitchSpearHit2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	Ef_WitchSpearHit3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	
	Ef_BlFeather1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	
	
	Ef_DINA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	Ef_MARU = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)	
	Ef_DINA2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	Ef_MARU2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)	
	
	
	dot_change_anim(dotMorgan2,1)
	
	
	movie_load("MA_01106_32")
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(20, 13, 0.0)

	load_sound("BGM_ADV_Mardisant_Theme")
	load_sound("BGM_Battle_Running")
end



function Play()
	fadein(0)
	Play_start(true)
	

	on_active(Ef_WitchSpear1) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear1)	


	on_active(Ef_WitchSpear2) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear2, gridpos)
	turn(Ef_WitchSpear2,45, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear2)	

	on_active(Ef_WitchSpear3) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear3, gridpos)
	turn(Ef_WitchSpear3,45,45, 0, 0.0) 
	play_particle(Ef_WitchSpear3)	

	on_active(Ef_WitchSpear4) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear4, gridpos)
	turn(Ef_WitchSpear4,45,-45, 0, 0.0) 
	play_particle(Ef_WitchSpear4)	


	on_active(Ef_WitchSpear5) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear5, gridpos)
	turn(Ef_WitchSpear5,45,90, 0, 0.0) 
	play_particle(Ef_WitchSpear5)	

	on_active(Ef_WitchSpear6) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear6, gridpos)
	turn(Ef_WitchSpear6,45,-90, 0, 0.0) 
	play_particle(Ef_WitchSpear6)		

	on_active(Ef_WitchSpear7) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear7, gridpos)
	turn(Ef_WitchSpear7,45,-135, 0, 0.0) 
	play_particle(Ef_WitchSpear7)	

	
	
	
	dot_reserve_move_unit_seq(dotNoir2, 20, 12)
	dot_reserve_move_unit_seq(dotDinatan, 21, 12)
	dot_reserve_move_unit_seq(dotMaladisant, 19, 12)
	dot_reserve_move_unit_seq(dotTyrfing1, 20, 14)
	exec_parallel_seq()
	wait_seq()	

	
	wait_time(0.3)

	
	
	move_camera(20, 5, 0.7)
	wait_camera()
	
	
	change_face(Maladisant, "Surprise")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320002")
	close_speech_window()
	
	
	move_camera(20, 12, 0.7)
	wait_camera()


	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320004")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_320005")
	close_speech_window()

	
	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320006")
	
	change_face(Maladisant, "Anger")
	message("MA_01106_320008")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320010")
	close_speech_window()
	
	


	local gridpos = get_grid_position(19, 4) 
	gridpos[2] = 2.0

	slidemove(Ef_WitchSpear5, gridpos, 0.1) 

	local gridpos = get_grid_position(20, 4) 
	gridpos[2] = 2.0

	slidemove(Ef_WitchSpear6, gridpos, 0.1) 

	local gridpos = get_grid_position(21, 4) 
	gridpos[2] = 2.0

	slidemove(Ef_WitchSpear7, gridpos, 0.1) 


	turn(Ef_WitchSpear5,90, 0, 0, 0.2)
	play_particle(Ef_WitchSpear5)


	turn(Ef_WitchSpear6,90, 0, 0, 0.2)
	play_particle(Ef_WitchSpear6)


	turn(Ef_WitchSpear7,90, 0, 0, 0.2)
	play_particle(Ef_WitchSpear7)


	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_320012")
	close_speech_window()
	
	
	
	

	
	move_camera(20, 5, 0.8)
	wait_camera()	

	
	wait_time(0.5)


	turn(Ef_WitchSpear5,20, 0, 0, 0.5)
	play_particle(Ef_WitchSpear5)


	turn(Ef_WitchSpear6,20, 0, 0, 0.5)
	play_particle(Ef_WitchSpear6)


	turn(Ef_WitchSpear7,20, 0, 0, 0.5)
	play_particle(Ef_WitchSpear7)


	
	wait_time(0.8)
	
	
	move_camera(20, 10, 0.7)
	wait_camera()

		
	dot_move_unit_seq(dotMaladisant, 20, 10)
	
	
	wait_seq()	

	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320014")
	
	change_face(Dinatan, "Anger")
	message("MA_01106_320016")
	close_speech_window()
	
	
	dot_move_unit_seq(dotDinatan, 21, 10)
	
	
	wait_seq()	
	
	
	dot_move_knockback(dotMaladisant, 19, 10,0.5, 2)
	
	
	wait_seq()	
	
	dot_change_anim(dotMaladisant,0)


	local gridpos = get_grid_position(21, 11) 
	gridpos[2] = 0.8

	slidemove(Ef_WitchSpear7, gridpos, 0.1) 



	wait_time(0.1)

	on_active(Ef_WitchSpearHit1) 

	local gridpos = get_grid_position(21, 10)
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)

	dot_change_anim(dotDinatan,6)
	
	wait_time(0.5)
	
	dot_change_anim(dotDinatan,1)

	
		
	wait_time(0.5)

	
	change_face(Maladisant, "Surprise")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320018")
	close_speech_window()
	
	

	turn(Ef_WitchSpear6,20, 10, 0, 0.1)
	play_particle(Ef_WitchSpear6)


	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320020")
	close_speech_window()
	
	
	

	local gridpos = get_grid_position(19, 11) 
	gridpos[2] = 0.8

	slidemove(Ef_WitchSpear6, gridpos, 0.1) 



	wait_time(0.1)

	on_active(Ef_WitchSpearHit2) 

	local gridpos = get_grid_position(19, 10)
	set_pos(Ef_WitchSpearHit2, gridpos)
	play_particle(Ef_WitchSpearHit2)

	dot_change_anim(dotMaladisant,6)
	
	wait_time(0.5)
	
	dot_change_anim(dotMaladisant,1)	
	

	
	change_face(Maladisant, "Pain")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320022")
	close_speech_window()
	
	
	
	
	
	dot_move_unit_seq(dotTyrfing1, 20, 10)
	
	
	wait_seq()	
	

	local gridpos = get_grid_position(20, 10) 
	gridpos[2] = 1.0

	slidemove(Ef_WitchSpear5, gridpos, 0.1) 



	wait_time(0.1)

	on_active(Ef_WitchSpearHit3) 

	local gridpos = get_grid_position(20, 10)
	set_pos(Ef_WitchSpearHit3, gridpos)
	play_particle(Ef_WitchSpearHit3)

	dot_change_anim(dotTyrfing1,3)
	
	wait_time(0.5)
	

	local gridpos = get_grid_position(20, 6) 
	gridpos[2] = 1.0

	slidemove(Ef_WitchSpear5, gridpos, 0.1) 


	
	dot_change_anim(dotTyrfing1,0)	
	
	
	wait_seq()	

	
	
	dot_unit_dir(dotTyrfing1, 3)
	dot_unit_dir(dotNoir2, 2)


	
	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01106_320024")
	close_speech_window()



	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_320025")
	close_speech_window()
	
	
	move_camera(20, 10, 0.3)
	wait_camera()

	
	change_face(Tyronoe, "Normal")
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01106_320027")
	close_speech_window()
	
	
	
	on_active(Ef_BlFeather1)
	on_active(Ef_WitchChange1)

	local gridpos = get_grid_position(21, 10)
	set_pos(Ef_BlFeather1, gridpos)
	play_particle(Ef_BlFeather1)

	local gridpos = get_grid_position(21, 9)
	set_pos(Ef_WitchChange1, gridpos)
	play_particle(Ef_WitchChange1)
	
	
	on_active(Ef_BlFeather2)
	on_active(Ef_WitchChange2)

	local gridpos = get_grid_position(19, 10)
	set_pos(Ef_BlFeather2, gridpos)
	play_particle(Ef_BlFeather2)

	local gridpos = get_grid_position(19, 9)
	set_pos(Ef_WitchChange2, gridpos)
	play_particle(Ef_WitchChange2)
	
	
	on_active(Ef_BlFeather3)
	on_active(Ef_WitchChange3)

	local gridpos = get_grid_position(20, 6)
	set_pos(Ef_BlFeather3, gridpos)
	play_particle(Ef_BlFeather3)

	local gridpos = get_grid_position(20, 6)
	set_pos(Ef_WitchChange3, gridpos)
	play_particle(Ef_WitchChange3)	
	

	wait_time(0.5)
	stop_particle(Ef_WitchSpear5)
	stop_particle(Ef_WitchSpear6)
	stop_particle(Ef_WitchSpear7)

	wait_time(0.5)
	dot_disp_unit(dotTyronoe, true)
	dot_disp_unit(dotThiten, true)
	dot_disp_unit(dotThiton, true)

	wait_time(2.0)	
	

	dot_reserve_move_unit_seq(dotThiten, 19, 7)
	dot_reserve_move_unit_seq(dotThiton, 21, 7)
	exec_parallel_seq()
	wait_seq()	


	
	change_face(Thiten, "Normal")
	open_speech_window("NPCNAME_0165", nil, nil)
	message("MA_01106_320029")
	close_speech_window()


open_cutin(1,1)

on_cutin(1,Noir2,"Serious") 


	

	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01106_320030")
	close_speech_window()


close_cutin()

	
	
	
	
	
	dot_reserve_move_unit_seq(dotNoir2, 21, 8)
	dot_reserve_move_unit_seq(dotTyrfing1, 19, 8)
	exec_parallel_seq()
	wait_seq()	
	
	
	dot_damage_seq(dotThiten, dotNoir2, true)
	dot_damage_seq(dotThiton, dotTyrfing1, true)
	
	
	wait_seq()	
	
	
	move_camera(20, 10, 0.3)
	wait_camera()
	
		
	dot_move_unit_seq(dotDinatan, 20, 10)
	
	
	wait_seq()	
	
	dot_change_anim(dotDinatan,1)	

	
	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320032")
	close_speech_window()

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320033")
	close_speech_window()

	
	change_face(Tyronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_6", nil, Tyronoe)
	message("MA_01106_320034")
	close_speech_window()

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320035")
	close_speech_window()
	
	

	
	change_face(Thiten, "Smile")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01106_320037")
	close_speech_window()

	
	change_face(Thiton, "Smile")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01106_320038")
	close_speech_window()

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320039")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("NPCNAME_0165", nil, Thiten)
	message("MA_01106_320040")
	close_speech_window()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")

	
	
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301009", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_DINATAN")
	message("MA_01106_320042")
	
	message("MA_01106_320043")
	close_simple_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 

off_cameraframe()
off_screencolor()



	
	


 
 


show_image("101010150", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
fadein(0)

	

	
	change_face(Dinatan, "Sad")
	open_mind_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320045")
	close_mind_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	
	


 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301003", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_DINATAN")
	message("MA_01106_320047")
	
	
	message("MA_01106_320049")
	
	
	message("MA_01106_320051")
	close_simple_window()
	
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 

off_cameraframe()
off_screencolor()



	
	


 
 


show_image("101010151", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
fadein(0)

	 

	
	change_face(Dinatan, "Sad")
	open_mind_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320053")
	close_mind_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	
	


 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301010", 0.0, 0.0, 0.0,true,false)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	
	open_simple_window("CHRNAME_MALADISANT")
	message("MA_01106_320055")
	close_simple_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	
	


 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301011", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_MALADISANT")
	message("MA_01106_320057")
	
	message("MA_01106_320059")
	close_simple_window()
	
	

	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 

off_cameraframe()
off_screencolor()



	
	


 
 


show_image("101010152", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
fadein(0)


	
	change_face(Dinatan, "Sad")
	open_mind_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320061")
	close_mind_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	
	


 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301012", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_MALADISANT")
	message("MA_01106_320063")
	close_simple_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 

off_cameraframe()
off_screencolor()



	
	


 
 


show_image("101010153", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
fadein(0)


	
	change_face(Dinatan, "Sad")
	open_mind_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320065")
	close_mind_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	
	


 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103010122", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_DINATAN")
	message("MA_01106_320067")
	
	message("MA_01106_320068")
	close_simple_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 

off_cameraframe()
off_screencolor()



	
	


 
 


show_image("101010154", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
fadein(0)


	
	change_face(Dinatan, "Pain")
	open_mind_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320070")
	close_mind_window()
	
	bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320072")
	close_speech_window()
	
	

	
	change_face(Maladisant, "Pain")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320074")
	close_speech_window()

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320075")
	
	change_face(Dinatan, "Sad")
	message("MA_01106_320077")
	close_speech_window()
	
	
	on_active(Ef_DINA) 
	local locatorpos = dot_get_unit_locator(dotDinatan, 1)
	set_pos(Ef_DINA, locatorpos)
	
	
	wait_time(0.5)
	

	
	change_face(Maladisant, "Anger")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320079")
	close_speech_window()
	
	
	on_active(Ef_MARU) 
	local locatorpos = dot_get_unit_locator(dotMaladisant, 1)
	set_pos(Ef_MARU, locatorpos)

	
	
	wait_time(0.5)
	

	

	
	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01106_320081")
	
	change_face(Tyrfing1, "Normal")
	message("MA_01106_320082")
	close_speech_window()
	
	

	
	change_face(Maladisant, "Pain")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320084")
	close_speech_window()
	
	

	
	dot_change_anim(dotMaladisant,0)
	dot_change_anim(dotDinatan,0)

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320086")
	
	change_face(Dinatan, "Pain")
	message("MA_01106_320087")
	
	change_face(Dinatan, "Smile")
	message("MA_01106_320088")
	close_speech_window()

	
	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320089")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320090")
	
	change_face(Dinatan, "Anger")
	message("MA_01106_320091")
	close_speech_window()

	
	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320092")
	close_speech_window()

	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320093")
	close_speech_window()

	bgm_play("BGM_ADV_Mardisant_Theme")
	
	
	
	
	on_active(Ef_DINA2) 
	local locatorpos = dot_get_unit_locator(dotDinatan,1)
	set_pos(Ef_DINA2, locatorpos)
	
	on_active(Ef_MARU2) 
	local locatorpos = dot_get_unit_locator(dotMaladisant,1)
	set_pos(Ef_MARU2, locatorpos)
	
	
	wait_time(1.0)

	
	change_face(Maladisant, "Anger")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320095")
	close_speech_window()

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320096")
	close_speech_window()

	
	change_face(Maladisant, "Pain")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320097")
	close_speech_window()

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320098")
	close_speech_window()

	
	change_face(Maladisant, "Pain")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_320099")
	close_speech_window()

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320100")
	
	change_face(Dinatan, "Anger")
	message("MA_01106_320102")
	close_speech_window()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301013", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_BRIAN")
	message("MA_01106_320104")
	
	message("MA_01106_320105")
	close_simple_window()

	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	
	
	
	
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	
	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01106_320107")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_320108")
	close_speech_window()

	
	
	
show_image("101010155", 0.0, 0.0, BLACK_WHITE_TIME,false,false,true)
set_scale_image(20,20,true)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)

	
	open_simple_window("CHRNAME_DINATAN_MALADISANT")
	message("MA_01106_320110")
	
	message("MA_01106_320111")
	
	message("MA_01106_320112")
	close_simple_window()
	
	
	off_active(Ef_WitchSpear1)	
	off_active(Ef_WitchSpear2)	
	off_active(Ef_WitchSpear3)	
	off_active(Ef_WitchSpear4)	
	off_active(Ef_WitchSpear5)	
	off_active(Ef_WitchSpear6)	
	off_active(Ef_WitchSpear7)	
	off_active(Ef_WSpearAppea1)	
	off_active(Ef_WSpearAppea2)	
	off_active(Ef_WSpearAppea3)	
	off_active(Ef_WSpearAppea4)	
	off_active(Ef_WSpearAppea5)	
	off_active(Ef_WSpearAppea6)	
	off_active(Ef_WSpearAppea7)	
	off_active(Ef_WSpearAura1)	
	off_active(Ef_WSpearAura2)	
	off_active(Ef_WSpearAura3)	
	off_active(Ef_WSpearAura4)	
	off_active(Ef_WSpearAura5)	
	off_active(Ef_WSpearAura6)	
	off_active(Ef_WSpearAura7)	
	
	off_active(Ef_WitchSpearHit1)	
	off_active(Ef_WitchSpearHit2)	
	off_active(Ef_WitchSpearHit3)	
	off_active(Ef_BlFeather1)	
	off_active(Ef_BlFeather2)	
	off_active(Ef_BlFeather3)	
	off_active(Ef_WitchChange1)	
	off_active(Ef_WitchChange2)	
	off_active(Ef_WitchChange3)	

	off_active(Ef_DINA)	
	off_active(Ef_MARU)	
	off_active(Ef_DINA2)	
	off_active(Ef_MARU2)	
	
	wait_time(0.3)

	
	movie_set_active(true)
	movie_play()
	
	
	hide_image(BLACK_WHITE_TIME,true)

	movie_wait_playing()
	
	
	dot_change_unit(dotMaladisant,dotMaladisant1,0)
	
	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)
	
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)
	
	
	move_camera(20, 13, 0.6)
	wait_camera()	
	
	
	dot_disp_unit(dotArthur, true)
	dot_disp_unit(dotMazoe, true)	
	
	
	dot_move_height(dotMazoe,3.0,0.7, 0)

	
	dot_reserve_move_unit_seq(dotArthur, 20, 12)
	dot_reserve_move_unit_seq(dotGuinevere, 18, 13)
	dot_reserve_move_unit_seq(dotTristan, 19, 13)
	dot_reserve_move_unit_seq(dotRagnar1, 22, 13)
	dot_reserve_move_unit_seq(dotGawain, 21, 13)
	dot_reserve_move_unit_seq(dotGwenhwymawr1, 17, 13)
	dot_reserve_move_unit_seq(dotIsolde1, 23, 13)
	exec_parallel_seq()
	wait_seq()	
	
	
	dot_unit_dir(dotGuinevere, 3)
	dot_unit_dir(dotGwenhwymawr1, 3)
	
	
	move_camera(20, 1, 1.3)
	wait_camera()	
	
	dot_move_height(dotMazoe,2.0,0.7, 0)	

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_320125")
	close_speech_window()
	
	
	
	move_camera(20, 10, 0.8)
	wait_camera()	
	
	wait_time(0.5)	
	
	dot_reserve_move_unit_seq(dotTyrfing1, 18, 10)
	dot_reserve_move_unit_seq(dotNoir2, 21, 10)
	exec_parallel_seq()
	wait_seq()	

	
	dot_unit_dir(dotTyrfing1, 2)
	dot_unit_dir(dotNoir2, 3)

	
	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01106_320127")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_320128")
	close_speech_window()

	bgm_play("BGM_Battle_Running")
	
	change_face(Maladisant1, "Normal")
	open_speech_window("CHRNAME_MALADISANT2", Maladisant1, nil)
	message("MA_01106_320130")
	close_speech_window()
	
	


open_cutin(1,1)

on_cutin(1,Dinatan, "Anger") 


	

	open_speech_window("CHRNAME_DINATAN", nil, nil)
	message("MA_01106_320132")
	close_speech_window()


close_cutin()


	
	
	
	
	move_camera(20, 13, 0.6)
	wait_camera()	

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_320133")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_320134")
	close_speech_window()
	
	
	
	move_camera(20, 10, 0.6)
	wait_camera()

	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320136")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_320137")
	close_speech_window()

	dot_reserve_move_unit_seq(dotDinatan, 20, 9)
	exec_parallel_seq()
	wait_seq()	

	
	
	change_face(Dinatan, "Smile")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_320138")
	close_speech_window()
	
	
	

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10301009", "content_still_10301009_image", "103010090_StillImage")
	load_image_preload("10301003", "content_still_10301003_image", "103010030_StillImage")
	load_image_preload("10301010", "content_still_10301010_image", "103010100_StillImage")
	load_image_preload("10301011", "content_still_10301011_image", "103010110_StillImage")
	load_image_preload("10301012", "content_still_10301012_image", "103010120_StillImage")
	load_image_preload("103010122", "content_still_10301012_image", "103010120_StillImage")
	load_image_preload("10301013", "content_still_10301013_image", "103010130_StillImage")
	load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010151", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010152", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010153", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010154", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010155", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("103010260", "content_still_10301026_image", "103010260_StillImage")
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	pbadv_setup_101009_Noir_preload(2,true, 20, 19,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 21, 19,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 19, 19,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 22, 19,0)
	pbadv_setup_101014_Tristan_preload(0,true, 19, 20,0)
	pbadv_setup_101018_Ragnar_preload(1,true, 20, 20,0)
	pbadv_setup_101013_Gawain_preload(0,true, 21, 20,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 19, 21,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 20, 21,0)
	pbadv_setup_101019_Isolde_preload(1,true, 21, 21,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 21, 26,0)
	pbadv_setup_101050_Brian_preload(0,true, 30, 30,0)
	pbadv_setup_101041_Morgan_preload(2,true, 20, 3,0)
	pbadv_setup_101015_Arthur_preload(0,true, 20, 16,0)
	pbadv_setup_101043_Mazoe_preload(true,20, 1,0)
	pbadv_setup_101047_Tyronoe_preload(true, 20, 6,0)
	pbadv_setup_101048_Thiten_preload(true, 19, 9,0)
	pbadv_setup_101049_Thiton_preload(true, 21, 9,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
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
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	movie_load_preload("MA_01106_32")
	preload_sound("BGM_ADV_Mardisant_Theme")
	preload_sound("BGM_Battle_Running")
end
