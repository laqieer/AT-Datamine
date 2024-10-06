

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201050000", "201050000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)
	
	
	pbadv_setup_101028_Galahad(1,true, 13, 14,0)  
	pbadv_setup_101035_Liliana(1,true, 25, 14,0)  
	
	
	
	barbaroi1 = dot_reserve_enemy(1, 23, 13, 0)
	barbaroi2 = dot_reserve_enemy(1, 24, 14, 0)
	barbaroi3 = dot_reserve_enemy(1, 23, 15, 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	dot_disp_weapon(dotGalahad1, false)
	dot_disp_weapon(dotLiliana1, false)
	
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	
	
	
	
	change_camera_distance(5.0, 0.0)
	
	
	change_camera_angle(34.0, 0.0)
	
	
	move_camera(19, 14, 0.0)
	
	
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
	load_image("10202007",  "content_still_10202007_image", "102020070_StillImage")
	show_image("10202007", 0.0, 0.0, 0 ,true,false)			

end





function Play()
	fadein(0)
	Play_start(true)

	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)	
	
	se_play("SE_ADV_MA_01B110_29_Sea_Waves")
	
	dot_move_unit_seq(dotGalahad1, 14, 14)
	dot_move_unit_seq(dotGalahad1, 15, 14)
	dot_move_unit_seq(dotGalahad1, 16, 14)
	dot_move_unit_seq(dotGalahad1, 17, 14)
	dot_move_unit_seq(dotGalahad1, 18, 14)
	dot_move_unit_seq(dotGalahad1, 19, 14)
	
	wait_seq()
	
	
	
	
	change_face(Liliana1, "Normal")
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01B110_290002")
	close_speech_window()

	
	se_play("SE_ADV_MA_01B110_29_Sea_Waves")
	
	change_camera_distance(8.0, 2.0)
	move_camera(22, 15, 2.0)

	wait_camera()
	
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド", "怒り")
	message("MA_01B110_290004")
	close_speech_window()
	
	dot_unit_dir(dotLiliana1, 2)
	
	
	change_face(Liliana1, "Anger")
	open_speech_window("CHRNAME_LILIANA2", nil, Liliana1)
	message("MA_01B110_290005")
	close_speech_window()
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド", "激怒")
	message("MA_01B110_290006")
	close_speech_window()
	
	
	change_face(Liliana1, "Sad")
	open_speech_window("CHRNAME_LILIANA2", nil, Liliana1)
	 --PlayPartVoice("リリアーナ", "落胆")
	message("MA_01B110_290008")
	
	
	
	change_face(Liliana1, "Normal")
	
	message("MA_01B110_290009")
	
	
	
	change_face(Liliana1, "Normal")
	
	 --PlayPartVoice("リリアーナ", "肯定3")
	message("MA_01B110_290010")
	
	
	
	change_face(Liliana1, "Sad")
	
	message("MA_01B110_290011")
	close_speech_window()
	
	
	on_active(Ef_bar1) 
	on_active(Ef_bar2) 
	on_active(Ef_bar3) 

	local gridpos = get_grid_position(23, 13)
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8})
	play_particle(Ef_bar1)

	local gridpos = get_grid_position(24, 14)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	local gridpos = get_grid_position(23, 15)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)


	wait_time(0.2)

	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)


	wait_time(2.0)


	
	change_face(Liliana1, "Sad")
	open_speech_window("CHRNAME_LILIANA2", nil, Liliana1)
	message("MA_01B110_290013")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101028_Galahad_preload(1,true, 13, 14,0)
	pbadv_setup_101035_Liliana_preload(1,true, 25, 14,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_image_preload("10202007",  "content_still_10202007_image", "102020070_StillImage")
end
