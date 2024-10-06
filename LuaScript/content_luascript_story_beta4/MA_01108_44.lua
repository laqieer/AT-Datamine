

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201000001", "201000001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 6, 21,0)  
	pbadv_setup_101011_Guinevere(0,true, 5, 20,0)  
	pbadv_setup_101010_Lancelot(3,true, 6, 20,0)  
	pbadv_setup_101012_Dinatan(0,true, 4, 21,0)  
	pbadv_setup_101021_Bruno(3,true, 5, 21,0)  
	
	pbadv_setup_101058_Laiens(1,true, 10, 20,0)  
	
	pbadv_setup_101015_Arthur(0,true, 0, 22,0)  
	pbadv_setup_101020_Merlin(0,true, 0, 23,0)  
	pbadv_setup_101001_Tyrfing(2,true, 0, 20,0)  
	pbadv_setup_101017_Maladisant(0,true, 0, 21,0)  
	pbadv_setup_101016_Gwenhwymawr(0,true, 0, 24,0)  

	pbadv_setup_101042_Moronoe(true, 10, 21,0)  
	pbadv_setup_101043_Mazoe(true, 10, 19,0)  
	pbadv_setup_101044_Gliten(true, 11, 21,0) 
	pbadv_setup_101045_Glitonea(true, 11, 20,0) 
	pbadv_setup_101046_Gliton(true, 11, 19,0) 
	pbadv_setup_101047_Tyronoe(true, 12, 21,0) 
	pbadv_setup_101048_Thiten(true, 12, 20,0)  
	pbadv_setup_101049_Thiton(true, 12, 19,0)  
		
	
	
	
	barbaroi = dot_reserve_enemy(1100, 8, 20, 0)
	barbaroi2 = dot_reserve_enemy(1100, 9, 20, 0)
	barbaroi3 = dot_reserve_enemy(1100, 8, 21, 0)
	barbaroi4 = dot_reserve_enemy(1100, 9, 21, 0)
	barbaroi5 = dot_reserve_enemy(1100, 9, 19, 0)

	barbaroi6 = dot_reserve_enemy(1100, 9, 18, 0)
	barbaroi7 = dot_reserve_enemy(1100, 10, 18, 0)
	barbaroi8 = dot_reserve_enemy(1100, 8, 22, 0)
	barbaroi9 = dot_reserve_enemy(1100, 9, 22, 0)
	barbaroi10 = dot_reserve_enemy(1100, 10, 22, 0)
	
	barbaroi11 = dot_reserve_enemy(1100, 11, 22, 0)
	barbaroi12 = dot_reserve_enemy(1100, 12, 22, 0)
	barbaroi13 = dot_reserve_enemy(1100, 11, 18, 0)
	barbaroi14 = dot_reserve_enemy(1100, 12, 18, 0)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotLancelot3,2)
	dot_unit_dir(dotLaiens1,2)



	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotBruno3, false)
	dot_disp_weapon(dotTyrfing2, false)
	dot_disp_weapon(dotArthur, false)
	dot_disp_weapon(dotGwenhwymawr, false)
	dot_disp_weapon(dotMaladisant, false)
	dot_disp_weapon(dotMerlin, false)

	
	
	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotGliton, false)
	dot_disp_unit(dotTyronoe, false)
	dot_disp_unit(dotThiten, false)
	dot_disp_unit(dotThiton, false)
	dot_disp_unit(barbaroi, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)
	dot_disp_unit(barbaroi8, false)
	dot_disp_unit(barbaroi9, false)
	dot_disp_unit(barbaroi10, false)
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)
	dot_disp_unit(barbaroi13, false)
	dot_disp_unit(barbaroi14, false)
	dot_disp_unit(dotTyrfing2, false)
	dot_disp_unit(dotArthur, false)
	dot_disp_unit(dotGwenhwymawr, false)
	dot_disp_unit(dotMaladisant, false)
	dot_disp_unit(dotMerlin, false)


	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(34.0, 0.0)

	
	
	move_camera(5, 21, 0.0)
	

	Ef_WitchPortal1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true) 
	Ef_WitchPortal2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true) 
	Ef_WitchPortal3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true) 
	Ef_WitchPortal4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true) 
	Ef_WitchPortal5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true) 
	Ef_WitchPortal6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true) 

	Ef_Lake = load_particle("content_effect3d_common_adv", "Ef_C_Adv_LakeColor_syoku", false, true)

	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar9 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar10 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar11 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar12 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar13 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar14 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 

end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotLancelot3,3)
	
	move_camera(7, 22, 1.0)

	wait_camera()
	
	
	change_face(Lancelot3, "Anger")
	open_speech_window("CHRNAME_LANCELOT",  Lancelot3, nil)
	message("MA_01108_440002")
	close_speech_window()

	
	
	on_active(Ef_WitchPortal1) 

	local gridpos = get_grid_position(10, 21) 
	set_pos(Ef_WitchPortal1, gridpos)
	set_scale(Ef_WitchPortal1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal1)

	wait_time(0.5)
	
	dot_disp_unit(dotMoronoe, true) 

	wait_time(2.0)
	
	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	message("MA_01108_440004")
	close_speech_window()


	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE",  Guinevere, nil)
	message("MA_01108_440006")
	close_speech_window()


	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",  nil, Laiens1)
	message("MA_01108_440007")
	

	
	change_face(Laiens1, "Sad")
	
	message("MA_01108_440009")
	close_speech_window()

	
	local gridpos = get_grid_position(10, 19) 
	set_pos(Ef_WitchPortal1, gridpos)
	set_scale(Ef_WitchPortal1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal1)

	wait_time(0.5)
	
	dot_disp_unit(dotMazoe, true)

	wait_time(2.0)
	
	

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2",  nil, Mazoe)
	message("MA_01108_440011")
	close_speech_window()

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",  nil, Laiens1)
	message("MA_01108_440012")
	close_speech_window()

	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN",  Dinatan, nil)
	message("MA_01108_440013")
	close_speech_window()

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",  nil, Laiens1)
	message("MA_01108_440014")
	

	
	change_face(Laiens1, "Normal")
	
	message("MA_01108_440015")
	

	
	change_face(Laiens1, "Normal")
	
	message("MA_01108_440016")
	

	
	change_face(Laiens1, "Smile")
	
	message("MA_01108_440017")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN",  Dinatan, nil)
	message("MA_01108_440018")
	close_speech_window()

	
	dot_disp_unit(dotArthur, true)
	dot_move_unit_seq(dotArthur,6, 22)
	
	wait_seq()
	
	dot_disp_weapon(dotArthur, false)
	

	
	change_face(Arthur, "Sad")
	open_speech_window("CHRNAME_ARTHUR",  Arthur, nil)
	message("MA_01108_440020")
	

	
	change_face(Arthur, "Sad")
	
	message("MA_01108_440021")
	close_speech_window()

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",  nil, Laiens1)
	message("MA_01108_440022")
	

	
	change_face(Laiens1, "Smile")
	
	message("MA_01108_440023")
	close_speech_window()

	
	
	on_active(Ef_WitchPortal2)
	on_active(Ef_WitchPortal3) 
	on_active(Ef_WitchPortal4) 
	on_active(Ef_WitchPortal5) 
	on_active(Ef_WitchPortal6) 
 

	local gridpos = get_grid_position(11, 21) 
	set_pos(Ef_WitchPortal1, gridpos)
	set_scale(Ef_WitchPortal1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal1)

	local gridpos = get_grid_position(11, 20) 
	set_pos(Ef_WitchPortal2, gridpos)
	set_scale(Ef_WitchPortal2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal2)

	local gridpos = get_grid_position(11, 19) 
	set_pos(Ef_WitchPortal3, gridpos)
	set_scale(Ef_WitchPortal3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal3)

	local gridpos = get_grid_position(12, 21) 
	set_pos(Ef_WitchPortal4, gridpos)
	set_scale(Ef_WitchPortal4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal4)

	local gridpos = get_grid_position(12, 20) 
	set_pos(Ef_WitchPortal5, gridpos)
	set_scale(Ef_WitchPortal5, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal5)

	local gridpos = get_grid_position(12, 19) 
	set_pos(Ef_WitchPortal6, gridpos)
	set_scale(Ef_WitchPortal6, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal6)

	wait_time(0.5)	

	dot_disp_unit(dotGliten, true) 
	dot_disp_unit(dotGlitonea, true)
	dot_disp_unit(dotGliton, true)
	dot_disp_unit(dotTyronoe, true)
	dot_disp_unit(dotThiten, true)
	dot_disp_unit(dotThiton, true)

	wait_time(2.0)
	
	dot_disp_unit(dotTyrfing2, true)
	dot_disp_unit(dotMerlin, true)
	
	dot_reserve_move_unit_seq(dotMerlin, 0, 22)
	dot_reserve_move_unit_seq(dotTyrfing2, 0, 23)
	exec_parallel_seq()
	wait_seq()

	dot_reserve_move_unit_seq(dotMerlin, 1, 22)
	dot_reserve_move_unit_seq(dotTyrfing2, 0, 22)
	exec_parallel_seq()
	wait_seq()

	dot_disp_unit(dotGwenhwymawr, true)
	dot_disp_unit(dotMaladisant, true)

	dot_reserve_move_unit_seq(dotMerlin,5, 22)
	dot_reserve_move_unit_seq(dotTyrfing2,4, 20)
	dot_reserve_move_unit_seq(dotMaladisant,3, 21)
	dot_reserve_move_unit_seq(dotGwenhwymawr,4, 22)
	
	exec_parallel_seq()
	
	wait_seq()

	dot_disp_weapon(dotTyrfing2, false)
	dot_disp_weapon(dotMerlin, false)
	dot_disp_weapon(dotGwenhwymawr, false)
	dot_disp_weapon(dotMaladisant, false)

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2",  nil, Mazoe)
	message("MA_01108_440025")
	close_speech_window()


	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	message("MA_01108_440027")
	close_speech_window()

	
	wait_time(1.0)

	on_active(Ef_Lake) 
	play_particle(Ef_Lake)

	wait_time(3.0)

	on_active(Ef_bar1) 
	on_active(Ef_bar2) 
	on_active(Ef_bar3) 
	on_active(Ef_bar4) 
	on_active(Ef_bar5) 
	on_active(Ef_bar6) 
	on_active(Ef_bar7) 
	on_active(Ef_bar8) 
	on_active(Ef_bar9) 
	on_active(Ef_bar10) 

	local gridpos = get_grid_position(8, 20) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)

	local gridpos = get_grid_position(9, 20) 
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar2)

	local gridpos = get_grid_position(8, 21) 
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar3)

	local gridpos = get_grid_position(9, 21) 
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar4)

	local gridpos = get_grid_position(9, 19) 
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar5)

	local gridpos = get_grid_position(9, 18) 
	set_pos(Ef_bar6, gridpos)
	set_scale(Ef_bar6, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar6)

	local gridpos = get_grid_position(10, 18) 
	set_pos(Ef_bar7, gridpos)
	set_scale(Ef_bar7, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar7)

	local gridpos = get_grid_position(10, 22) 
	set_pos(Ef_bar8, gridpos)
	set_scale(Ef_bar8, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar8)

	local gridpos = get_grid_position(9, 22) 
	set_pos(Ef_bar9, gridpos)
	set_scale(Ef_bar9, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar9)

	local gridpos = get_grid_position(10, 22) 
	set_pos(Ef_bar10, gridpos)
	set_scale(Ef_bar10, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar10)

	wait_time(0.2)
	
	dot_disp_unit(barbaroi, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)
	dot_disp_unit(barbaroi5, true)
	dot_disp_unit(barbaroi6, true)
	dot_disp_unit(barbaroi7, true)
	dot_disp_unit(barbaroi8, true)
	dot_disp_unit(barbaroi9, true)
	dot_disp_unit(barbaroi10, true)

	wait_time(2.0)


	
	change_face(Maladisant, "Anger")
	open_speech_window("CHRNAME_MALADISANT",  Maladisant, nil)
	message("MA_01108_440029")
	close_speech_window()

	
	on_active(Ef_bar11) 
	on_active(Ef_bar12) 
	on_active(Ef_bar13) 
	on_active(Ef_bar14) 

	local gridpos = get_grid_position(11, 22) 
	set_pos(Ef_bar11, gridpos)
	set_scale(Ef_bar11, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar11)

	local gridpos = get_grid_position(12, 22) 
	set_pos(Ef_bar12, gridpos)
	set_scale(Ef_bar12, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar12)

	local gridpos = get_grid_position(11, 18) 
	set_pos(Ef_bar13, gridpos)
	set_scale(Ef_bar13, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar13)

	local gridpos = get_grid_position(12, 18) 
	set_pos(Ef_bar14, gridpos)
	set_scale(Ef_bar14, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar14)

	wait_time(0.2)

	dot_disp_unit(barbaroi11, true)
	dot_disp_unit(barbaroi12, true)
	dot_disp_unit(barbaroi13, true)
	dot_disp_unit(barbaroi14, true)

	wait_time(2.0)

	
	change_face(Tyrfing2, "Anger")
	open_speech_window("CHRNAME_TYRFING",  Tyrfing2, nil)
	message("MA_01108_440031")
	close_speech_window()

	
	change_face(Laiens1, "Smile")
	open_speech_window("CHRNAME_LAIENS",  nil, Laiens1)
	message("MA_01108_440032")
	close_speech_window()




	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 6, 21,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 5, 20,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 6, 20,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 4, 21,0)
	pbadv_setup_101021_Bruno_preload(3,true, 5, 21,0)
	pbadv_setup_101058_Laiens_preload(1,true, 10, 20,0)
	pbadv_setup_101015_Arthur_preload(0,true, 0, 22,0)
	pbadv_setup_101020_Merlin_preload(0,true, 0, 23,0)
	pbadv_setup_101001_Tyrfing_preload(2,true, 0, 20,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 0, 21,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true, 0, 24,0)
	pbadv_setup_101042_Moronoe_preload(true, 10, 21,0)
	pbadv_setup_101043_Mazoe_preload(true, 10, 19,0)
	pbadv_setup_101044_Gliten_preload(true, 11, 21,0)
	pbadv_setup_101045_Glitonea_preload(true, 11, 20,0)
	pbadv_setup_101046_Gliton_preload(true, 11, 19,0)
	pbadv_setup_101047_Tyronoe_preload(true, 12, 21,0)
	pbadv_setup_101048_Thiten_preload(true, 12, 20,0)
	pbadv_setup_101049_Thiton_preload(true, 12, 19,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_LakeColor_syoku", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
end
