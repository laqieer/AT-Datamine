

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)

	
	
	

	
	
	init_psbattleadv("201120000", "201120000")
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	change_time_and_weather(BattleTime_Night, BattleWeather_Shiny)
	
	
	
	
	
	
	
	
	












	
	pbadv_setup_101035_Liliana(1,true, 19, 4,0)  
	pbadv_setup_101029_Astera(1,true,  19, 1,0) 
	
	
	
	
	
	
	
	
	
	






	
	
	barbaroi1 = dot_reserve_enemy(1, 36, 10, 0)
	barbaroi2 = dot_reserve_enemy(1, 37, 10, 0)
	barbaroi3 = dot_reserve_enemy(1, 36, 12, 0)
	barbaroi4 = dot_reserve_enemy(1, 37, 3, 0)
	barbaroi5 = dot_reserve_enemy(1, 35, 0, 0)
	barbaroi6 = dot_reserve_enemy(1, 37, 0, 0)
	
	
	barbaroi7 = dot_reserve_enemy(1, 39, 5, 0)
	barbaroi8 = dot_reserve_enemy(1, 40, 6, 0)
	barbaroi9 = dot_reserve_enemy(1, 41, 7, 0)
	barbaroi10 = dot_reserve_enemy(1, 37, 8, 0)
	barbaroi11 = dot_reserve_enemy(1, 31, 1, 0)
	barbaroi12 = dot_reserve_enemy(1, 33, 3, 0)
	barbaroi13 = dot_reserve_enemy(1, 31, 5, 0)
	
	
	
	
	setup_complete_unit()

	
	
	
	
	
	
	
	
	
	
	dot_unit_dir(barbaroi6, 3)
	dot_unit_dir(barbaroi7, 3)
	dot_unit_dir(barbaroi8, 2)
	dot_unit_dir(barbaroi11, 2)
	dot_unit_dir(barbaroi13, 2)
	
	
















	
	
	
	
	
	
	
	
	
	











	
	
	
	
	
	







	
	dot_disp_unit(dotAstera1, false)
	dot_disp_unit(dotLiliana1, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(35, 3, 0.0)
	
	
	Ef_Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	
	
	Ef_Smoke1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flame02", false, true)
	Ef_kaminari = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Thunder01", false, true)
	Ef_kaminari2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Thunder01", false, true)
	
	on_active(Ef_Smoke1) 
	local gridpos = get_grid_position(40,1)
	set_pos(Ef_Smoke1, gridpos)
	play_particle(Ef_Smoke1)

	

	movie_load("MA_01B109_37")


	load_sound("BGM_ADV_DarkBrave")
	load_sound("BGM_ADV_Tragedy")

end




function Play()



fadein(0)
	Play_start(true)
	
	wait_time(1.0)	
	
	
	on_active(Ef_kaminari) 
	local gridpos = get_grid_position(39,3)
	set_pos(Ef_kaminari, gridpos)
	play_particle(Ef_kaminari)
	
	dot_move_unit_seq(barbaroi8,39,6 )
	dot_move_unit_seq(barbaroi13 ,32,7 )
	
	wait_time(1.0)	
	
	
	
	
	dot_move_unit_seq(barbaroi10,38,6 )	
	dot_move_unit_seq(barbaroi1, 36, 4)
	

	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(barbaroi1, 3)
	dot_move_unit_seq(barbaroi11,30,1 )	
	
	
	dot_move_unit_seq(barbaroi2, 34, 1)
	
	on_active(Ef_kaminari2) 
	local gridpos = get_grid_position(39,5)
	set_pos(Ef_kaminari2, gridpos)
	play_particle(Ef_kaminari2)
	
	
	dot_move_unit_seq(barbaroi8,40,6 )	
	dot_move_unit_seq(barbaroi13 ,31,5 )
	
	dot_unit_dir(barbaroi2, 3)
	
	
	wait_time(1.5)	
	
	
	
	
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)


	off_active(Ef_Smoke1) 
	off_active(Ef_kaminari) 
	off_active(Ef_kaminari2) 


	movie_set_active(true)

	fadein(0)
	Play_start(true)
	
	movie_play()
	movie_wait_playing()
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)

	

	
























































































































































































































































	






	
	wait_time(0.5)
	

	change_face(Liliana1, "Sad")
	open_simple_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01B109_370028")
	close_simple_window()
	
	






	

	change_face(Astera1, "Sad")
	open_simple_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B109_370030")
	
	

	change_face(Astera1, "Normal")
	
	message("MA_01B109_370031")
	close_simple_window()
	






	


	wait_time(1.5)


	change_face(Astera1, "Sad")
	open_simple_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B109_370033")
	close_simple_window()
	
	



















	
	
	wait_time(1.0)
	





	bgm_play("BGM_ADV_DarkBrave")

	open_narration_window()
	message("MA_01B109_370035")
	
	

	
	message("MA_01B109_370036")
	


	
	message("MA_01B109_370037")
	


	
	message("MA_01B109_370038")
	


	
	message("MA_01B109_370040")
	


	
	message("MA_01B109_370041")
	


	
	message("MA_01B109_370042")
	


	
	message("MA_01B109_370043")
	







	
	message("MA_01B109_370045")
	


	
	message("MA_01B109_370046")
	


	
	message("MA_01B109_370047")
	


	
	message("MA_01B109_370048")
	close_narration_window()
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	pbadv_setup_101035_Liliana_preload(1,true, 19, 4,0)
	pbadv_setup_101029_Astera_preload(1,true,  19, 1,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flame02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Thunder01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Thunder01", false, true)
	movie_load_preload("MA_01B109_37")
	preload_sound("BGM_ADV_DarkBrave")
	preload_sound("BGM_ADV_Tragedy")
end