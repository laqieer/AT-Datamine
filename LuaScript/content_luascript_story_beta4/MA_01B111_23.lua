

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)


	
	
	init_psbattleadv("201200001", "201200001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	pbadv_setup_101009_Noir(2,true, 20, 40,0)  
	pbadv_setup_101010_Lancelot(1,true, 21, 40,0)  
	pbadv_setup_101028_Galahad(1,true, 19, 41,0)  
	pbadv_setup_101036_Viena(1,true, 22, 41,0)  
	pbadv_setup_101024_Bors(0,true, 20, 41,0)  
	pbadv_setup_101025_Clare(0,true, 21, 41,0)  
	pbadv_setup_101025_Clare(1,true, 21, 33,0)  
	pbadv_setup_101042_Moronoe(true, 21, 29,0)  


	barbaroi1 = dot_reserve_enemy(1101, 20, 35, 0)
	barbaroi2 = dot_reserve_enemy(1101, 21, 35, 0)
	barbaroi3 = dot_reserve_enemy(1, 19, 34, 0)
	barbaroi4 = dot_reserve_enemy(1, 22, 34, 0)

	barbaroi5 = dot_reserve_enemy(600, 19, 30, 0)
	barbaroi6 = dot_reserve_enemy(600, 22, 30, 0)
	barbaroi7 = dot_reserve_enemy(42, 19, 31, 0)
	barbaroi8 = dot_reserve_enemy(42, 22, 31, 0)

	barbaroi9 = dot_reserve_enemy(304, 20, 30, 0)
	barbaroi10 = dot_reserve_enemy(304, 22, 30, 0)
	barbaroi11 = dot_reserve_enemy(42, 19, 29, 0)
	barbaroi12 = dot_reserve_enemy(42, 23, 29, 0)

	barbaroi13 = dot_reserve_enemy(304, 16, 30, 0)
	barbaroi14 = dot_reserve_enemy(600, 16, 31, 0)
	barbaroi15 = dot_reserve_enemy(42, 16, 32, 0)
	barbaroi16 = dot_reserve_enemy(49, 16, 33, 0)
	barbaroi17 = dot_reserve_enemy(1, 16, 34, 0)
	
	
	
	setup_complete_unit()
	

	
	
	dot_disp_unit(dotClare1, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)
	dot_disp_unit(barbaroi8, false)

	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(barbaroi9, false)
	dot_disp_unit(barbaroi10, false)
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)

	dot_disp_unit(barbaroi13, false)
	dot_disp_unit(barbaroi14, false)
	dot_disp_unit(barbaroi15, false)
	dot_disp_unit(barbaroi16, false)
	dot_disp_unit(barbaroi17, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(34.0, 0.0)

	
	
	move_camera(20, 37, 0.0)
	
		
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem17", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem17", false, true) 
	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_bar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_Witch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)

	Ef_ChangeWitch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)

	Ef_BalAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BalAura01_S_Lop", false, true)

	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)

	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)

	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)

end

function Play()
	fadein(0)
	Play_start(true)


	
	
	dot_reserve_move_unit_seq(dotNoir2, 20, 36)
	dot_reserve_move_unit_seq(dotLancelot1, 21, 36)
	dot_reserve_move_unit_seq(dotGalahad1, 19, 37)
	dot_reserve_move_unit_seq(dotViena1, 22, 37)
	dot_reserve_move_unit_seq(dotBors, 20, 37)
	dot_reserve_move_unit_seq(dotClare, 21, 37)	
	
	exec_parallel_seq()

	
	wait_seq()

	
	change_face(Lancelot1, "Serious")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_230002")

	

	dot_attack_seq(dotLancelot1, barbaroi2)			
	dot_damage_seq(barbaroi2, dotLancelot1, false)	
	wait_seq()
	dot_change_anim(barbaroi2, 6)

	dot_damage_seq(barbaroi4, dotLancelot1, false)	
	wait_seq()
	dot_change_anim(barbaroi4, 6)

	dot_attack_seq(dotNoir2, barbaroi1)			
	dot_damage_seq(barbaroi1, dotNoir2, false)	
	wait_seq()
	dot_change_anim(barbaroi1, 6)

	dot_damage_seq(barbaroi3, dotNoir2, false)	
	wait_seq()
	dot_change_anim(barbaroi3, 6)

	wait_time(0.2)

	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)

	dot_remove_unit(barbaroi1) 
	dot_remove_unit(barbaroi2) 
	dot_remove_unit(barbaroi3) 
	dot_remove_unit(barbaroi4) 
	
	wait_time(0.5)

	dot_reserve_move_unit_seq(dotNoir2, 20, 34)
	dot_reserve_move_unit_seq(dotLancelot1, 21, 34)
	dot_reserve_move_unit_seq(dotGalahad1, 19, 35)
	dot_reserve_move_unit_seq(dotViena1, 22, 35)
	dot_reserve_move_unit_seq(dotBors, 20, 35)
	dot_reserve_move_unit_seq(dotClare, 21, 35)	
	
	exec_parallel_seq()

	wait_seq()

	move_camera(20, 34, 0.5)
	wait_camera()
	
	
	
	change_face(Lancelot1, "Serious")
	message("MA_01B111_230004")


	
	on_active(Ef_bar)

	local gridpos = get_grid_position(19, 31)
	set_pos(Ef_bar, gridpos)
	set_scale(Ef_bar, {0.8, 0.8, 0.8})
	play_particle(Ef_bar)

	on_active(Ef_bar2)

	local gridpos = get_grid_position(22, 31)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	on_active(Ef_bar3)

	local gridpos = get_grid_position(19, 30)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	on_active(Ef_bar4)

	local gridpos = get_grid_position(22, 30)
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8})
	play_particle(Ef_bar4)

	wait_time(0.2)


	dot_disp_unit(barbaroi5, true)
	dot_disp_unit(barbaroi6, true)
	dot_disp_unit(barbaroi7, true)
	dot_disp_unit(barbaroi8, true)

	wait_time(2.0)

	dot_reserve_move_unit_seq(barbaroi5, 20, 31)
	dot_reserve_move_unit_seq(barbaroi6, 21, 31)
	dot_reserve_move_unit_seq(barbaroi7, 20, 32)
	dot_reserve_move_unit_seq(barbaroi8, 21, 32)
	
	exec_parallel_seq()

	wait_seq()
	
	
	
	change_face(Lancelot1, "Serious")
	message("MA_01B111_230006")

	dot_move_unit_seq(dotLancelot1, 21, 32)

	wait_seq()
	
	
	

	dot_attack_seq(dotLancelot1, barbaroi8)			
	dot_damage_seq(barbaroi8, dotLancelot1, false)	
	wait_seq()
	dot_change_anim(barbaroi8, 6)

	dot_damage_seq(barbaroi7, dotLancelot1, false)	
	wait_seq()
	dot_change_anim(barbaroi7, 6)

	dot_damage_seq(barbaroi5, dotLancelot1, false)	
	wait_seq()
	dot_change_anim(barbaroi5, 6)

	dot_damage_seq(barbaroi6, dotLancelot1, false)	
	wait_seq()
	dot_change_anim(barbaroi6, 6)



	wait_time(0.2)

	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi8,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)
	dot_disp_unit(barbaroi8, false)

	dot_remove_unit(barbaroi5) 
	dot_remove_unit(barbaroi6) 
	dot_remove_unit(barbaroi7) 
	dot_remove_unit(barbaroi8) 

	wait_time(0.5)


	
	
	change_face(Lancelot1, "Serious")
	message("MA_01B111_230008")
	close_speech_window()

	
	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01B111_230010")
	close_speech_window()

	on_active(Ef_WSpearAppea1) 

	local gridpos = get_grid_position(21, 29) 
	gridpos[2] = 2.0	
	set_pos(Ef_WSpearAppea1, gridpos)
	turn(Ef_WSpearAppea1,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAppea1)

	wait_time(0.5)
	
	on_active(Ef_WitchSpear1) 

	local gridpos = get_grid_position(21, 29)
	gridpos[2] = 2.0 
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear1)


	on_active(Ef_WSpearAura1) 

	set_pos(Ef_WSpearAura1, gridpos)
	turn(Ef_WSpearAura1,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAura1)

	local gridpos = get_grid_position(21, 29) 
	gridpos[2] = 0.11
	
	se_play("SE_ADV_MA_01106_15_Whitch_Spr_Ground")

	slidemove(Ef_WitchSpear1, gridpos, 0.1) 
	slidemove(Ef_WSpearAura1, gridpos, 0.1) 

	
	
	dot_reserve_move_unit_seq(dotNoir2, 20, 31)
	dot_reserve_move_unit_seq(dotLancelot1, 21, 31)
	dot_reserve_move_unit_seq(dotGalahad1, 19, 32)
	dot_reserve_move_unit_seq(dotViena1, 22, 32)
	dot_reserve_move_unit_seq(dotBors, 20, 32)
	dot_reserve_move_unit_seq(dotClare, 21, 32)	
	
	exec_parallel_seq()

	wait_seq()

	move_camera(21, 32, 0.5)
	wait_camera()
	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_230012")
	close_speech_window()

	

	on_active(Ef_ChangeWitch)

	
	local gridpos = get_grid_position(21, 29)
	set_pos(Ef_ChangeWitch, gridpos)
	play_particle(Ef_ChangeWitch)

	wait_time(1.0)

	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WSpearAura1)

	dot_disp_unit(dotMoronoe, true)

	wait_time(2.0)

	change_camera_angle(25.0, 1)
	wait_camera()

	on_active(Ef_bar2)

	
	local gridpos = get_grid_position(20, 30)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	on_active(Ef_bar3)

	local gridpos = get_grid_position(22, 30)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	on_active(Ef_bar4)

	local gridpos = get_grid_position(19, 29)
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8})
	play_particle(Ef_bar4)

	on_active(Ef_bar5)

	local gridpos = get_grid_position(23, 29)
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8})
	play_particle(Ef_bar5)


	wait_time(0.2)

	dot_disp_unit(barbaroi9, true)
	dot_disp_unit(barbaroi10, true)
	dot_disp_unit(barbaroi11, true)
	dot_disp_unit(barbaroi12, true)
	
	wait_time(2.0)
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_230014")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_230015")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_230016")
	close_speech_window()

	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE", Clare, nil)
	message("MA_01B111_230017")
	close_speech_window()

	
	open_cutin(1,1)
	
	on_cutin(1, Bors, "Anger", 1)
	
	
	
	open_speech_window("CHRNAME_BORS", nil, nil)
	message("MA_01B111_230018")
	close_speech_window()

	
	close_cutin()
	wait_time(0.5)
	
	
	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)


	local locatorpos = dot_get_unit_locator(dotBors,1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)


	local locatorpos = dot_get_unit_locator(dotClare,1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	wait_time(2.0)

	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(21, 32)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(20, 32)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(21, 32)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)
	dot_change_unit(dotClare, dotClare1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Killers)
	stop_particle(Ef_Vibes)

	wait_time(2.5)

	dot_reserve_move_unit_seq(dotNoir2, 19, 31)
	dot_reserve_move_unit_seq(dotLancelot1, 22, 31)
	dot_reserve_move_unit_seq(dotBors, 20, 31)
	dot_reserve_move_unit_seq(dotClare1, 21, 31)
	
	exec_parallel_seq()

	wait_seq()

	move_camera(21, 32, 0.5)
	wait_camera()

	dot_unit_dir(dotLancelot1, 2)
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotViena1, 2)

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B111_230020")
	close_speech_window()

	
	dot_unit_dir(dotClare1, 0)


	dot_attack_seq(dotClare1, dotMoronoe)			
	dot_dodge_seq(dotMoronoe)					
	dot_damage_seq(barbaroi9, dotClare1, false)	
	wait_seq()
	dot_change_anim(barbaroi9, 6)

	dot_damage_seq(barbaroi10, dotClare1, false)	
	wait_seq()
	dot_change_anim(barbaroi10, 6)

	dot_damage_seq(barbaroi11, dotClare1, false)	
	wait_seq()
	dot_change_anim(barbaroi11, 6)

	dot_damage_seq(barbaroi12, dotClare1, false)	
	wait_seq()
	dot_change_anim(barbaroi12, 6)

	wait_time(0.2)

	dot_play_particle_unit(barbaroi9,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi10,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi11,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi12,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi9, false)
	dot_disp_unit(barbaroi10, false)
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)

	dot_remove_unit(barbaroi9) 
	dot_remove_unit(barbaroi10) 
	dot_remove_unit(barbaroi11) 
	dot_remove_unit(barbaroi12) 
	
	wait_time(0.5)

	dot_change_anim(dotClare1, DotAnim_Idle)		

	change_camera_distance(6.0, 0.5)
	change_camera_angle(40.0, 0.5)
	move_camera(21, 31, 0.5)
	wait_camera()
	
	
	change_face(Clare1, "Smile")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B111_230022")
	close_speech_window()

	
	change_face(Bors, "Anger")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	message("MA_01B111_230023")
	close_speech_window()


	
	change_face(Lancelot1, "Surprise")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_230024")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	message("MA_01B111_230025")
	close_speech_window()

	
	
	dot_reserve_move_unit_seq(dotNoir2, 19, 25)
	dot_reserve_move_unit_seq(dotLancelot1, 22, 25)
	dot_reserve_move_unit_seq(dotGalahad1, 19, 26)
	dot_reserve_move_unit_seq(dotViena1, 22, 26)
	dot_reserve_move_unit_seq(dotBors, 20, 30)
	dot_reserve_move_unit_seq(dotClare1, 21, 30)

	
	exec_parallel_seq()

	

	dot_reserve_move_unit_seq(dotNoir2, 19, 17)
	dot_reserve_move_unit_seq(dotLancelot1, 22, 17)
	dot_reserve_move_unit_seq(dotGalahad1, 19, 18)
	dot_reserve_move_unit_seq(dotViena1, 22, 18)

	
	exec_parallel_seq()

	wait_seq()
	
	dot_remove_unit(dotNoir2)
	dot_remove_unit(dotLancelot1)
	dot_remove_unit(dotGalahad1)
	dot_remove_unit(dotViena1)

	move_camera(21, 30, 0.5)
	wait_camera()
	
	
	
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_230027")
	close_speech_window()

	
	

	change_camera_angle(25.0, 1)
	wait_camera()
	
	on_active(Ef_BalAura)

	local gridpos = get_grid_position(21, 29)
	set_pos(Ef_BalAura, gridpos)
	
	play_particle(Ef_BalAura)


	
	local gridpos = get_grid_position(20, 29)
	set_pos(Ef_bar, gridpos)
	set_scale(Ef_bar, {0.8, 0.8, 0.8})
	play_particle(Ef_bar)


	local gridpos = get_grid_position(19, 30)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)


	local gridpos = get_grid_position(22, 30)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)


	local gridpos = get_grid_position(21, 32)
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8})
	play_particle(Ef_bar4)


	local gridpos = get_grid_position(20, 32)
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8})
	play_particle(Ef_bar5)

	wait_time(0.2)

	dot_place_unit(barbaroi13, 20, 29)
	dot_place_unit(barbaroi14, 19, 30)
	dot_place_unit(barbaroi15, 22, 30)
	dot_place_unit(barbaroi16, 21, 32)
	dot_place_unit(barbaroi17, 20, 32)

	dot_disp_unit(barbaroi13, true)
	dot_disp_unit(barbaroi14, true)
	dot_disp_unit(barbaroi15, true)
	dot_disp_unit(barbaroi16, true)
	dot_disp_unit(barbaroi17, true)
	
	dot_unit_dir(barbaroi13, 3)
	dot_unit_dir(barbaroi14, 3)
	dot_unit_dir(barbaroi17, 3)

	wait_time(2.0)
	
	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B111_230029")

	
	change_face(Clare1, "Smile")
	message("MA_01B111_230030")
	close_speech_window()



	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 40,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 21, 40,0)
	pbadv_setup_101028_Galahad_preload(1,true, 19, 41,0)
	pbadv_setup_101036_Viena_preload(1,true, 22, 41,0)
	pbadv_setup_101024_Bors_preload(0,true, 20, 41,0)
	pbadv_setup_101025_Clare_preload(0,true, 21, 41,0)
	pbadv_setup_101025_Clare_preload(1,true, 21, 33,0)
	pbadv_setup_101042_Moronoe_preload(true, 21, 29,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem17", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem17", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BalAura01_S_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
end
