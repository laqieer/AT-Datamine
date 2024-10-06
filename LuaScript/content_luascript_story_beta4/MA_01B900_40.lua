

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201180000", "201180000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 21, 35, 0)  

	pbadv_setup_101010_Lancelot(1,true, 24, 34 ,0)  
	
	pbadv_setup_101028_Galahad(1,true, 18, 35,0)  
	pbadv_setup_101028_Galahad(2,true, 0, 0,0)  
	
	pbadv_setup_101055_Owen(0,true, 20, 34, 0)  
	pbadv_setup_101053_Mathajim(0,true, 0, 5,0)  
	pbadv_setup_101054_Adam(0,true, 22, 34,0)  
	
	pbadv_setup_101029_Astera(1,true, 19, 36,0) 
	pbadv_setup_101034_Excelia(1,true, 24, 36,0)  
	pbadv_setup_101035_Liliana(1,true, 23, 36,0)  

	pbadv_setup_101041_Morgan(1,true, 21, 33, 0) 
	pbadv_setup_101015_Arthur(1,true, 24, 31, 0)  
	
	pbadv_setup_101021_Bruno(0,true, 21,34, 0)  
	
	
	
	
	
	
	barbaroi1 = dot_reserve_enemy(42, 20, 32, 0) 
	barbaroi2 = dot_reserve_enemy(42, 22, 32, 0) 

	
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotArthur1, 2) 
	dot_unit_dir(dotBruno, 2) 


	
	
	
	dot_disp_weapon(dotAstera1, false) 
	dot_disp_weapon(dotExcelia1, false) 
	dot_disp_weapon(dotLiliana1, false) 
	dot_disp_weapon(dotArthur1, false) 

	
	
	
	dot_disp_unit(dotMathajim, false)
	dot_disp_unit(dotAdam, false)
	dot_disp_unit(dotOwen, false)
	
	dot_disp_unit(dotAstera1, false)
	dot_disp_unit(dotExcelia1, false)
	dot_disp_unit(dotLiliana1, false)
	dot_disp_unit(dotGalahad2, false)

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(21, 35, 0.0)

	
	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Coat = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	Ef_Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)

	dot_change_anim(dotGalahad1,1)	
	dot_unit_dir(dotLancelot1, 2) 
	
	load_sound("BGM_ADV_Knight")

	load_image("101020250", "content_still_10102025_image", "101020250_StillImage")
	load_image("101020290", "content_still_10102029_image", "101020290_StillImage")
	load_image("101020260", "content_still_10102026_image", "101020260_StillImage")


end

function MoveSet1() 
	dot_reserve_move_unit_seq(dotMorgan1, 21, 32)	
	dot_reserve_move_unit_seq(dotMathajim, 21, 33)	
	dot_reserve_move_unit_seq(dotOwen, 20, 33)	
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotMathajim, 0) 
	dot_change_anim(dotMathajim,3)	
	dot_play_particle_unit(dotMathajim,"Ef_C_Swd_N_Atk01",3,true)

	dot_unit_dir(dotAdam, 0) 
	dot_change_anim(dotAdam,3)	
	dot_play_particle_unit(dotAdam,"Ef_C_Bow_N_Atk01",3,true)

	dot_unit_dir(dotOwen, 0) 
	dot_change_anim(dotOwen,3)	
	dot_play_particle_unit(dotOwen,"Ef_C_Spr_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotMorgan1,6)	
	dot_play_particle_unit(dotMorgan1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.2)

	dot_change_anim(dotMathajim,3)	
	dot_play_particle_unit(dotMathajim,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotAdam,3)	
	dot_play_particle_unit(dotAdam,"Ef_C_Bow_N_Atk01",3,true)

	dot_change_anim(dotOwen,3)	
	dot_play_particle_unit(dotOwen,"Ef_C_Spr_N_Atk01",3,true)

	dot_unit_dir(dotMorgan1, 1) 
	dot_change_anim(dotMorgan1,4)	
	dot_play_particle_unit(dotOwen,"Ef_C_Mag_R_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotMorgan1,6)	
	dot_move_knockback(dotMorgan1, 21, 31, 0.2, 2)

	dot_change_anim(dotMathajim,6)	
	dot_change_anim(dotAdam,6)	
	dot_change_anim(dotOwen,6)	
	dot_move_knockback(dotMathajim, 21, 34, 0.2, 2)
	dot_move_knockback(dotOwen, 20, 34, 0.2, 2)

	wait_time(0.2)

	dot_unit_dir(dotMorgan1, 2) 
	dot_change_anim(dotMorgan1,0)	

	dot_unit_dir(dotMathajim, 3) 
	dot_unit_dir(dotAdam, 3) 
	dot_unit_dir(dotOwen, 3) 
	dot_change_anim(dotMathajim,0)	
	dot_change_anim(dotAdam,0)	
	dot_change_anim(dotOwen,0)	
end

function MoveSet2() 
	dot_reserve_move_unit_seq(dotLancelot1, 24, 33)
	dot_reserve_move_unit_seq(dotLiliana1, 23, 34)
	dot_reserve_move_unit_seq(dotArthur1, 24, 32)
	exec_parallel_seq()

	wait_seq()

	dot_change_anim(dotLiliana1,3)	
	dot_play_particle_unit(dotLiliana1,"Ef_C_Spr_N_Atk01",3,true)

	dot_unit_dir(dotExcelia1, 0) 
	dot_change_anim(dotExcelia1,3)	
	dot_play_particle_unit(dotExcelia1,"Ef_C_Mag_F_Atk01",3,true)

	dot_change_anim(dotLancelot1,3)	
	dot_play_particle_unit(dotLancelot1,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_unit_dir(dotArthur1, 2) 
	dot_change_anim(dotArthur1,6)	
	dot_play_particle_unit(dotArthur1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_move_knockback(dotArthur1, 24, 31, 0.2, 2)

	dot_unit_dir(dotLancelot1, 3) 
	dot_unit_dir(dotExcelia1, 3) 
	dot_unit_dir(dotLiliana1, 3) 
	dot_change_anim(dotLancelot1,0)	
	dot_change_anim(dotExcelia1,0)	
	dot_change_anim(dotLiliana1,0)	

	wait_time(0.2)

	dot_unit_dir(dotArthur1, 1) 
	dot_change_anim(dotArthur1,4)	
	dot_play_particle_unit(dotArthur1,"Ef_C_Mag_R_Atk01",3,true)
	
	wait_time(0.2)

	dot_unit_dir(dotArthur1, 2) 
	dot_change_anim(dotArthur1,0)
		
	dot_change_anim(dotLiliana1,6)	
	dot_play_particle_unit(dotLiliana1,"Ef_C_Mag_R_Hit01",1,true)

	dot_change_anim(dotLancelot1,6)	
	dot_play_particle_unit(dotLancelot1,"Ef_C_Mag_R_Hit01",1,true)

	dot_move_knockback(dotLiliana1, 23, 36, 0.2, 2)
	dot_move_knockback(dotLancelot1, 24, 35, 0.2, 2)

	wait_time(0.2)

	dot_unit_dir(dotLancelot1, 3) 
	dot_unit_dir(dotLiliana1, 3) 

	dot_change_anim(dotLiliana1,0)	
	dot_change_anim(dotLancelot1,0)	
end



function Play()
	fadein(0)
	Play_start(true)

	
	

	
	dot_unit_dir(dotBruno, 0) 
	dot_change_anim(dotBruno,3)
	dot_play_particle_unit(dotBruno,"Ef_C_Swd_N_Atk01",3,true)

	dot_unit_dir(dotMorgan1, 1) 
	dot_change_anim(dotMorgan1,3)
	dot_play_particle_unit(dotMorgan1,"Ef_C_Swd_N_Atk01",1,true)

	wait_time(0.2)

	dot_move_knockback(dotMorgan1, 21, 31, 0.2, 2)

	dot_change_anim(dotBruno,0)	
	dot_change_anim(dotMorgan1,0)
	dot_unit_dir(dotMorgan1, 2) 
	dot_unit_dir(dotBruno, 2) 

	wait_time(0.5)
	
	
	on_active(Ef_Coat) 

	local gridpos = get_grid_position(21, 34)
	set_pos(Ef_Coat, gridpos)
	play_particle(Ef_Coat)

	wait_time(1.0)
	
	
	
	dot_unit_dir(dotBruno, 0) 
	dot_change_anim(dotBruno,3)
	dot_play_particle_unit(dotBruno,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(barbaroi1,6)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.2)
		
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_change_anim(dotBruno,0)
	dot_unit_dir(dotBruno, 2) 
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)

	wait_time(1.0)
	
	dot_remove_unit(barbaroi1)
	dot_remove_unit(barbaroi2)

	show_image("101020250", 0.0, 0.0, STILL_SWITCH_TIME,true,false) --0.6秒
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)--0.6秒+0.5秒	

	wait_time(1.0)
	
	change_face(Noir2, "Surprise")
	open_simple_window("CHRNAME_NOIR", nil, nil)
	message("MA_01B900_400002")
	close_simple_window()

	wait_time(0.5)

	bgm_play("Stop_BGM_Bus_2")
	fadeout(255,255,255,1.0, 0.5)
	wait_time(0.5)

	wait_time(0.1)
	show_image("101020290", 0.0, 0.0, 0 ,true,false) --0.6秒
	wait_time(0.1)

	fadein(0.5)
	wait_time(1.5)

	move_camera(21, 36, 0.0)
	wait_camera()

	dot_unit_dir(dotBruno, 2) 
	dot_remove_unit(dotBruno)
	
	dot_place_unit(dotMathajim,21, 34)

	dot_disp_unit(dotOwen, true)	
	dot_disp_unit(dotMathajim, true)
	dot_disp_unit(dotAdam, true)
	
	dot_place_unit(dotNoir2,21, 36)
	dot_place_unit(dotGalahad1,18, 36)
	dot_unit_dir(dotNoir2, 2) 
	dot_change_anim(dotGalahad1,0)	

	
	dot_unit_dir(dotNoir2, 2) 
	dot_change_anim(dotGalahad1,0)	
	
	dot_disp_unit(dotAstera1, true)
	dot_disp_unit(dotLiliana1, true)	
	dot_disp_unit(dotExcelia1, true)
	
	change_face(Astera1, "Normal")
	open_simple_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01B900_400004")
	close_simple_window()	
	
	change_face(Excelia1, "Normal")
	open_simple_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01B900_400006")
	close_simple_window()

	bgm_play("BGM_ADV_Knight")

	hide_image(STILL_SWITCH_TIME) --0.6秒
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒	
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_400008")
	close_speech_window()

	
	dot_move_unit_seq(dotLancelot1,24, 35)
	wait_seq()
	dot_unit_dir(dotLancelot1, 2) 
	
	
	change_face(Lancelot1, "Surprise")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_400010")
	close_speech_window()

	
	change_face(Liliana1, "Normal")
	open_speech_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01B900_400011")
	close_speech_window()

	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2", Excelia1, nil)
	message("MA_01B900_400012")
	close_speech_window()

	
	dot_move_unit_seq(dotAstera1,19, 35)
	move_camera(19, 35, 1.0)
	change_camera_distance(8.0, 1.0)

	wait_seq()
	wait_camera()

	dot_unit_dir(dotAstera1, 3) 
	dot_unit_dir(dotGalahad1, 3) 
	dot_unit_dir(dotLancelot1, 2) 


	
	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B900_400014")
	close_speech_window()

	
	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_400016")
	close_speech_window()

	
	change_face(Liliana1, "Surprise")
	open_speech_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01B900_400017")
	close_speech_window()

	
	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_400019")
	close_speech_window()

	move_camera(21, 35, 1.0)
	wait_camera()
	
	
	dot_disp_weapon(dotAstera1, true) 
	dot_disp_weapon(dotExcelia1, true) 
	dot_disp_weapon(dotLiliana1, true) 

	dot_change_anim(dotMathajim,3)	
	dot_change_anim(dotAdam,3)	
	dot_change_anim(dotOwen,3)	
	
	wait_time(1.0)
	
	dot_change_anim(dotMathajim,0)	
	dot_change_anim(dotAdam,0)	
	dot_change_anim(dotOwen,0)	
	
	
	
	change_face(Liliana1, "Smile")
	open_speech_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01B900_400021")
	close_speech_window()

	
	change_face(Excelia1, "Smile")
	open_speech_window("CHRNAME_EXCELIA2", Excelia1, nil)
	message("MA_01B900_400022")
	close_speech_window()

	
	change_face(Astera1, "Smile")
	open_speech_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B900_400023")
	close_speech_window()

	
	
	
	local Set1 = create_coroutine(MoveSet1) 
	local Set2 = create_coroutine(MoveSet2) 
	
	coroutine.resume(Set1)  
	coroutine.resume(Set2)  

	pbadv_wait_coroutine(Set1) 
	pbadv_wait_coroutine(Set2) 
	
	wait_time(0.3)

	
	on_active(Ef_BlFeather) 

	local gridpos = get_grid_position(21, 29)
	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)
	
	wait_time(1.0)
	
	
	change_face(Morgan1, "Anger")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_400025")
	close_speech_window()

	
	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B900_400026")
	close_speech_window()

	move_camera(18, 36, 1.0)
	change_camera_distance(7.0, 1.0)

	dot_move_unit_seq(dotAstera1,19, 36)
	wait_seq()

	dot_unit_dir(dotAstera1, 2) 

	wait_camera()
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_400028")
	close_speech_window()

	
	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B900_400030")
	close_speech_window()

	-- カットインを開く
	open_cutin(1,1)
	-- カットインのキャラ表示
	on_cutin(1,Galahad1,"Surprise") --カットイン出すキャラ分指定を入れる

	wait_time(2.0)

	-- カットインを閉じる
	close_cutin()
	
	dot_move_unit_seq(dotGalahad1,19, 34)
	move_camera(19, 34, 1.0)
	change_camera_distance(7.0, 1.0)

	wait_seq()
	wait_camera()

	wait_time(0.5)

	show_image("101020260", 0.0, 0.0, STILL_SWITCH_TIME,true,false) --0.6秒
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)--0.6秒+0.5秒	

	dot_disp_unit(dotGalahad2, true)
	dot_change_unit(dotGalahad1,dotGalahad2,0)
	dot_unit_dir(dotAstera1, 3) 
	dot_unit_dir(dotNoir2, 2) 
	

	--change_face(Noir2, "Normal")
	open_simple_window("CHRNAME_NOIR", nil, nil)
	message("MA_01B900_400032")
	close_simple_window()

	--change_face(Galahad2, "Normal")
	open_simple_window("CHRNAME_GALAHAD", nil, nil)
	message("MA_01B900_400034")

	
	--change_face(Galahad2, "Normal")	
	message("MA_01B900_400035")
	close_simple_window()
	

	hide_image(STILL_SWITCH_TIME) --0.6秒
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_400036")
	close_speech_window()

	dot_unit_dir(dotNoir2, 3)
	 
	move_camera(21, 35, 1.0)
	change_camera_distance(8.0, 1.0)
	wait_camera()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_400037")
	close_speech_window()

	dot_move_unit_seq(dotLancelot1,24, 34)
	wait_seq()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_400038")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_400039")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_400040")
	close_speech_window()

	
	change_face(Morgan1, "Anger")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_400042")
	close_speech_window()

	
	change_face(Liliana1, "Anger")
	open_speech_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01B900_400043")
	close_speech_window()

	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2", Excelia1, nil)
	message("MA_01B900_400045")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B900_400046")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_400048")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_400050")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B900_400052")
	close_speech_window()

	
	
	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 21, 35, 0)
	pbadv_setup_101010_Lancelot_preload(1,true, 24, 34 ,0)
	pbadv_setup_101028_Galahad_preload(1,true, 18, 35,0)
	pbadv_setup_101028_Galahad_preload(2,true, 0, 0,0)
	pbadv_setup_101055_Owen_preload(0,true, 20, 34, 0)
	pbadv_setup_101053_Mathajim_preload(0,true, 0, 5,0)
	pbadv_setup_101054_Adam_preload(0,true, 22, 34,0)
	pbadv_setup_101029_Astera_preload(1,true, 19, 36,0)
	pbadv_setup_101034_Excelia_preload(1,true, 24, 36,0)
	pbadv_setup_101035_Liliana_preload(1,true, 23, 36,0)
	pbadv_setup_101041_Morgan_preload(1,true, 21, 33, 0)
	pbadv_setup_101015_Arthur_preload(1,true, 24, 31, 0)
	pbadv_setup_101021_Bruno_preload(0,true, 21,34, 0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	preload_sound("BGM_ADV_Knight")
	load_image_preload("101020250", "content_still_10102025_image", "101020250_StillImage")
	load_image_preload("101020290", "content_still_10102029_image", "101020290_StillImage")
	load_image_preload("101020260", "content_still_10102026_image", "101020260_StillImage")
end
