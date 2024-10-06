

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)

	
	
	init_psbattleadv("201200000", "201200000")
	
	change_time_and_weather(1, 5)

    pbadv_setup_101009_Noir(2,true,28,4,0)
    
    
    pbadv_setup_101012_Dinatan(1,true,27,4,0)
    
    
	pbadv_setup_101022_Mordred(0,true,26,5,0)  

	
	pbadv_setup_101023_Clarice(1,true,26,4,0)
	
	 
	pbadv_setup_101046_Gliton(true,38 ,3 ,0)
	
	
	pbadv_setup_101015_Arthur(2,true,38 ,4 ,0)
	
	
	barbaroi = dot_reserve_enemy(1104, 39, 3, 0)
	barbaroi2 = dot_reserve_enemy(1104, 39, 5, 0)
	barbaroi3 = dot_reserve_enemy(600, 40, 3, 0)
	barbaroi4 = dot_reserve_enemy(1105, 40, 5, 0)
	
	
	
	setup_complete_unit()

	
	
	dot_unit_dir(dotArthur2, 2)


	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotDinatan1, false)
	dot_disp_weapon(dotClarice1, false)
	dot_disp_weapon(dotMordred, false)

	
	
	
	
	dot_disp_unit(dotGliton, false)
	dot_disp_unit(dotArthur2, false)
	dot_disp_unit(barbaroi, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(36, 4, 0.0)
	
	
	Ef_WitchPortal= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal2= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal3= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_WitchPortal4= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_WitchPortal5= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_WitchPortal6= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_Holy2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
	Ef_tink = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	Ef_tink2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, false)
	
	load_image("101040330", "content_still_10104033_image", "101040330_StillImage")
end





function Play()
	fadein(0)
	Play_start(true)


	
    
    dot_reserve_move_unit_seq(dotNoir2,34,3)
	dot_reserve_move_unit_seq(dotDinatan1,34,4)
	dot_reserve_move_unit_seq(dotClarice1,33,2)
	dot_reserve_move_unit_seq(dotMordred,33,3)
	exec_parallel_seq()
	wait_seq()

	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_210002")
	close_speech_window()
	
	dot_unit_dir(dotDinatan1, 2)
	wait_time(1.0)
	dot_unit_dir(dotDinatan1, 3)
	wait_time(1.0)

	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_210003")
	close_speech_window()

	
	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2",Clarice1 , nil)
	message("MA_01C112_210004")
	close_speech_window()

	
	change_face(Mordred, "Anger")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C112_210005")
	close_speech_window()
	
	
	on_active(Ef_WitchPortal)
        
	local gridpos = get_grid_position(38, 3)
	set_pos(Ef_WitchPortal, gridpos)
	set_scale(Ef_WitchPortal, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal)

	wait_time(1.0)
	
	dot_disp_unit(dotGliton, true)

	wait_time(2.0)
	wait_seq()
	
	
	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil , Gliton)
	message("MA_01C112_210007")
	

	
	change_face(Gliton, "Smile")
	
	message("MA_01C112_210008")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_210009")
	close_speech_window()

	
	change_face(Gliton, "Normal")
	open_speech_window("CHRNAME_SISTERS_5",nil , Gliton)
	message("MA_01C112_210010")
	close_speech_window()
	
	
	--ブラックアウト
	fadeout(0,0,0,1.0, 0.6)
	wait_time(0.8)
	
	
		
	se_play("SE_ADV_MA_01C112_21_Gore")
	
	wait_time(0.8)

	se_play("SE_ADV_MA_01C112_21_Spear_Drop")
	
	wait_time(1.0)
	

	show_image("101040330", 0.0, 0.0, STILL_SWITCH_TIME,true,false) --0.6秒
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)--0.6秒+0.5秒		
	
    fadein(0.7)
	wait_time(1.0)		
	
--	change_face(Dinatan1, "Sad")
	open_simple_window("CHRNAME_DINATAN2",nil , nil)
	message("MA_01C112_210012")
	close_simple_window()

	
--	change_face(Noir2, "Sad")
	open_simple_window("CHRNAME_NOIR",nil , nil)
	message("MA_01C112_210013")
	close_simple_window()
	
	--ブラックアウト
	fadeout(0,0,0,1.0, 0.5)
	wait_time(0.5)
	
	hide_image(STILL_SWITCH_TIME) 
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
	
	fadein(FADE_TIME)
	wait_time(FADE_TIME)

	wait_time(1.0)
	
	change_face(Gliton, "Normal")
	open_speech_window("CHRNAME_SISTERS_5",nil , Gliton)
	message("MA_01C112_210014")
	

	
	change_face(Gliton, "Normal")
	
	message("MA_01C112_210015")
	

	
	change_face(Gliton, "Smile")
	
	message("MA_01C112_210016")
	close_speech_window()

	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_210017")
	close_speech_window()

	
	change_face(Mordred, "Anger")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C112_210018")
	close_speech_window()

	
	change_face(Gliton, "Normal")
	open_speech_window("CHRNAME_SISTERS_5",nil , Gliton)
	message("MA_01C112_210019")
	

	
	change_face(Gliton, "Normal")
	
	message("MA_01C112_210020")
	close_speech_window()
	
	on_active(Ef_WitchPortal2)
        
	local gridpos = get_grid_position(38, 4)
	set_pos(Ef_WitchPortal2, gridpos)
	set_scale(Ef_WitchPortal2, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal2)

	wait_time(1.0)
	dot_disp_unit(dotArthur2, true)
	wait_seq()
	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotDinatan1, true)
	dot_disp_weapon(dotClarice1, true)
	dot_disp_weapon(dotMordred, true)

	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_210022")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_210023")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_210024")
	close_speech_window()
	
	on_active(Ef_Holy2)
	
	local gridpos = get_grid_position(37, 4)
	gridpos[2] = 5.61
	set_pos(Ef_Holy2, gridpos)
	play_particle(Ef_Holy2)
	
	wait_time(1.0)

	
	
	change_face(Dinatan1, "Surprise")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_210026")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_210027")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_210028")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_210029")
	

	
	change_face(Arthur2, "Anger")
	
	message("MA_01C112_210030")
	close_speech_window()

	
	change_face(Dinatan1, "Anger")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_210031")
	close_speech_window()
	
	change_camera_distance(7.0, 0.5)
	move_camera(37, 4, 0.5)
	dot_move_unit_seq(dotDinatan1,35, 4)
	wait_seq()
	
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	
	
	se_play("SE_ADV_MA_01C112_21_Grail")
	
	wait_time(0.5)
	
	on_active(Ef_tink)
	
	local gridpos = get_grid_position(37, 4)
	gridpos[2] = 5.61
	set_pos(Ef_tink, gridpos)
	play_particle(Ef_tink)
	stop_particle(Ef_Holy2)
	
	wait_time(2.0)
	
	dot_change_anim(dotArthur2,0)
	stop_particle(Ef_tink)

	
	
	change_face(Dinatan1, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_210033")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_210034")
	close_speech_window()

	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_210035")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_210036")
	
	
	change_camera_distance(8.0, 1.0)
	move_camera(36, 4, 1.0)

	
	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_210038")
	close_speech_window()
	
	
	dot_move_unit_seq(dotArthur2,40, 4)
	wait_seq()
	on_active(Ef_WitchPortal2)
	local gridpos = get_grid_position(40,4)
	set_pos(Ef_WitchPortal2, gridpos)
	play_particle(Ef_WitchPortal2)
	dot_disp_unit(dotArthur2,false )
	wait_seq()

	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil , Gliton)
	message("MA_01C112_210039")
	close_speech_window()
	
	dot_move_unit_seq(dotGliton,38, 4)
	on_active(Ef_WitchPortal3)
	on_active(Ef_WitchPortal4)
	on_active(Ef_WitchPortal5)
	on_active(Ef_WitchPortal6)
        
	local gridpos = get_grid_position(39, 3)
	set_pos(Ef_WitchPortal3, gridpos)
	set_scale(Ef_WitchPortal3, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal3)
	
	local gridpos = get_grid_position(39, 5)
	set_pos(Ef_WitchPortal4, gridpos)
	set_scale(Ef_WitchPortal4, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal4)
	
	local gridpos = get_grid_position(40, 3)
	set_pos(Ef_WitchPortal5, gridpos)
	set_scale(Ef_WitchPortal5, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal5)
	
	local gridpos = get_grid_position(40, 5)
	set_pos(Ef_WitchPortal6, gridpos)
	set_scale(Ef_WitchPortal6, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal6)

	wait_time(0.2)
	
	dot_disp_unit(barbaroi, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)

	wait_time(2.0)
	wait_seq()
	
	



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,28,4,0)
    pbadv_setup_101012_Dinatan_preload(1,true,27,4,0)
	pbadv_setup_101022_Mordred_preload(0,true,26,5,0)
	pbadv_setup_101023_Clarice_preload(1,true,26,4,0)
	pbadv_setup_101046_Gliton_preload(true,38 ,3 ,0)
	pbadv_setup_101015_Arthur_preload(2,true,38 ,4 ,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, false)
	load_image_preload("101040330", "content_still_10104033_image", "101040330_StillImage")
end
