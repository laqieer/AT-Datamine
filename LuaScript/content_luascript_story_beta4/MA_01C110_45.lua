

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201010000", "201010000")
	
	change_time_and_weather(3,1)
	
	
	pbadv_setup_101009_Noir(2,true, 30, 19,0)  
	pbadv_setup_101012_Dinatan(1,true, 29, 19,0)  
	pbadv_setup_101011_Guinevere(0,true, 30, 18,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 30, 17,0)  
	pbadv_setup_101010_Lancelot(0,true, 29, 17,0)  
	pbadv_setup_101017_Maladisant(1,true, 29, 18,0)  
	
	pbadv_setup_101013_Gawain(1,true, 41, 17,0)  
	pbadv_setup_101018_Ragnar(1,true, 41, 18,0)  

	
	
	
	barbaroi = dot_reserve_enemy(1100, 34, 17, 0)
	barbaroi2 = dot_reserve_enemy(1100, 34, 19, 0)
	barbaroi3 = dot_reserve_enemy(304, 36, 17, 0)
	barbaroi4 = dot_reserve_enemy(304, 36, 19, 0)

	barbaroi5 = dot_reserve_enemy(1204, 37, 17, 0)
	barbaroi6 = dot_reserve_enemy(49, 38, 15, 0)
	barbaroi7 = dot_reserve_enemy(1204, 37, 19, 0)
	
	
	
	
	setup_complete_unit()
	
	


	dot_unit_dir(dotGawain1, 2)
	dot_unit_dir(dotRagnar1, 2)


	
	dot_disp_unit(dotGawain1, false)
	dot_disp_unit(dotRagnar1, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)


	
	change_camera_distance(9.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(31, 18, 0.0)

	
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_Sun = load_particle("content_effect3d_common_adv", "Ef_C_Adv_SunRises", false, true)

end





function Play()
	fadein(0)
	Play_start(true)

	
	
	
	change_face(Guinevere, "Normal")	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "悩む")
	message("MA_01C110_450002")
	

	
	change_face(Guinevere, "Normal")	
	
	message("MA_01C110_450003")
	close_speech_window()

	
	change_face(Gwenhwymawr1, "Anger")	
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01C110_450005")
	close_speech_window()

	
	move_camera(32, 18, 0.5)
	change_camera_distance(7.0, 0.5)
	dot_disp_unit(dotRagnar1, true)
	dot_move_unit_seq(dotRagnar1,34, 18, 1.5)
	wait_seq()

	dot_reserve_move_unit_seq(dotRagnar1,33, 18)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,31, 17)
	exec_parallel_seq()
	dot_reserve_move_unit_seq(dotRagnar1,32, 18)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,31, 18)
	exec_parallel_seq()
	wait_seq()

	wait_camera()

	dot_unit_dir(dotGwenhwymawr1, 3)

	dot_change_anim(dotGwenhwymawr1,3)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Spr_N_Atk01",3,true)

	dot_change_anim(dotRagnar1,3)
	dot_play_particle_unit(dotRagnar1,"Ef_C_Axe_N_Atk01",3,true)

	se_play("SE_ADV_MA_01C201_29_Sword_Block")		

	wait_time(0.2)
	

	dot_change_anim(dotGwenhwymawr1,0)
	dot_move_knockback(dotRagnar1, 33, 18, 0.2, 2)
	
	wait_time(0.2)
	dot_change_anim(dotRagnar1,0)
	
	
	
	change_face(Gawain1, "Normal")	
	open_speech_window("CHRNAME_GAWAIN", nil, Gawain1)
	 --PlayPartVoice("ガウェイン", "肯定3")
	message("MA_01C110_450007")
	close_speech_window()

	move_camera(31, 18, 1.0)
	change_camera_distance(9.0, 1.0)
	dot_disp_unit(dotGawain1, true)
	dot_move_unit_seq(dotGawain1,33, 19, 1.3)
	wait_seq()
	
	dot_unit_dir(dotGawain1, 2)
	wait_camera()

	
	change_face(Ragnar1, "Sad")	
	open_speech_window("CHRNAME_RAGNAR2", nil, Ragnar1)
	message("MA_01C110_450008")
	close_speech_window()

	
	
	
	change_face(Gwenhwymawr1, "Anger")	
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	 --PlayPartVoice("ギネマウア", "悲しみ")
	message("MA_01C110_450010")
	close_speech_window()

	
	change_face(Gawain1, "Normal")	
	open_speech_window("CHRNAME_GAWAIN", nil, Gawain1)
	 --PlayPartVoice("ガウェイン", "落胆")
	message("MA_01C110_450011")
	

	
	change_face(Gawain1, "Normal")	
	
	message("MA_01C110_450012")
	

	
	change_face(Gawain1, "Normal")	
	
	message("MA_01C110_450013")
	

	
	change_face(Gawain1, "Normal")	
	
	message("MA_01C110_450014")
	close_speech_window()

	
	
	
	
	change_face(Noir2, "Serious")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "激怒")
	message("MA_01C110_450016")
	close_speech_window()

	
	change_face(Gawain1, "Normal")	
	open_speech_window("CHRNAME_GAWAIN", nil, Gawain1)
	 --PlayPartVoice("ガウェイン", "肯定2")
	message("MA_01C110_450017")
	

	
	change_face(Gawain1, "Normal")	
	
	message("MA_01C110_450018")
	

	
	change_face(Gawain1, "Normal")	
	
	message("MA_01C110_450019")
	close_speech_window()

	
	on_active(Ef_Sun) 
	play_particle(Ef_Sun)

	wait_time(2.0)

	on_active(Ef_bar1) 
	
	local gridpos = get_grid_position(37, 17)
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8})
	play_particle(Ef_bar1)

	on_active(Ef_bar2) 
	
	local gridpos = get_grid_position(37, 18)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	on_active(Ef_bar3) 
	
	local gridpos = get_grid_position(37, 19)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	wait_time(0.2)
	
	dot_place_unit(barbaroi6, 37, 18)
	
	dot_disp_unit(barbaroi5, true)
	dot_disp_unit(barbaroi6, true)
	dot_disp_unit(barbaroi7, true)

	wait_time(2.0)

	
	change_face(Noir2, "Anger")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "怒り")
	message("MA_01C110_450021")
	close_speech_window()

	
	change_face(Gawain1, "Normal")	
	open_speech_window("CHRNAME_GAWAIN", nil, Gawain1)
	message("MA_01C110_450022")
	close_speech_window()

	
	open_cutin(1,1)
	
	
	on_cutin(1,Gawain1,"Serious") 

	
	
	
	open_speech_window("CHRNAME_GAWAIN", nil, nil)
	 --PlayPartVoice("ガウェイン", "気合い")
	message("MA_01C110_450023")
	close_speech_window()

	
	close_cutin()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 30, 19,0)
	pbadv_setup_101012_Dinatan_preload(1,true, 29, 19,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 30, 18,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 30, 17,0)
	pbadv_setup_101010_Lancelot_preload(0,true, 29, 17,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 29, 18,0)
	pbadv_setup_101013_Gawain_preload(1,true, 41, 17,0)
	pbadv_setup_101018_Ragnar_preload(1,true, 41, 18,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_SunRises", false, true)
end
