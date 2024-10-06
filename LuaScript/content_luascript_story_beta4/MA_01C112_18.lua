

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	load_image("10203009",  "content_still_10203009_image", "102030090_StillImage")
	show_image("10203009", 0.0, 0.0, 0 ,true,false)
	
	
	
	
	init_psbattleadv("201020000", "201020000")
	
	change_time_and_weather(BattleTime_Day, BattleWeather_Snowy)
	
	
	
	 
    pbadv_setup_101009_Noir(2,true,15,10,0)
    
    
    pbadv_setup_101012_Dinatan(1,true,16,10,0)
    
    
	pbadv_setup_101022_Mordred(0,true,17,11,0)  
	
	
	pbadv_setup_101023_Clarice(1,true,18,11,0)
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

	
	
	
		
	
	
	
	
	
	barbaroi   = dot_reserve_enemy(1100,14 ,1 , 0)
	barbaroi2  = dot_reserve_enemy(1100,15 ,1 , 0)
	barbaroi3  = dot_reserve_enemy(1102,13 ,3 , 0)
	barbaroi4  = dot_reserve_enemy(1102,14 ,3 , 0)
	barbaroi5  = dot_reserve_enemy(1301,12 ,4 , 0)
	barbaroi6  = dot_reserve_enemy(600,14 ,5 , 0)
	barbaroi7  = dot_reserve_enemy(600,17 ,5 , 0)
	barbaroi8  = dot_reserve_enemy(49,13 ,6 , 0)
	barbaroi9  = dot_reserve_enemy(600,18 ,6 , 0)
	barbaroi10 = dot_reserve_enemy(49,14 ,7 , 0)
	barbaroi11 = dot_reserve_enemy(49,16 ,7 , 0)
	barbaroi12 = dot_reserve_enemy(600,17 ,7 , 0)
	barbaroi13 = dot_reserve_enemy(49,15 ,8 , 0)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	

	
	
	
	
	

	
	
	
	
	dot_disp_unit(barbaroi  , false)
	dot_disp_unit(barbaroi2 , false)
	dot_disp_unit(barbaroi3 , false)
	dot_disp_unit(barbaroi4 , false)
	dot_disp_unit(barbaroi5 , false)
	dot_disp_unit(barbaroi6 , false)
	dot_disp_unit(barbaroi7 , false)
	dot_disp_unit(barbaroi8 , false)
	dot_disp_unit(barbaroi9 , false)
	dot_disp_unit(barbaroi10, false)
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)
	dot_disp_unit(barbaroi13, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(15, 10, 0.0)
	
	
	Ef_baruba   = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba4  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba5  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba6  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba7  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba8  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba9  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba10 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba11 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba12 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba13 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
	
end





function Play()
	fadein(0)
	Play_start(true)


	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)


	
	
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C112_180002")
	close_speech_window()

	
	change_face(Dinatan1, "Anger")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C112_180003")
	close_speech_window()
	
	move_camera(14, 2, 3.5)
	
	on_active(Ef_baruba6)
	local gridpos = get_grid_position(14,5)
	set_pos(Ef_baruba6, gridpos)
	set_scale(Ef_baruba6, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba)
	dot_disp_unit(barbaroi6 , true)
	
	on_active(Ef_baruba7)
	local gridpos = get_grid_position(17,5)
	set_pos(Ef_baruba7, gridpos)
	set_scale(Ef_baruba7, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba7)
	dot_disp_unit(barbaroi7 , true)
	
	on_active(Ef_baruba8)
	local gridpos = get_grid_position(13,6)
	set_pos(Ef_baruba8, gridpos)
	set_scale(Ef_baruba8, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba8)
	dot_disp_unit(barbaroi8 , true)
	
	on_active(Ef_baruba9)
	local gridpos = get_grid_position(18,6)
	set_pos(Ef_baruba9, gridpos)
	set_scale(Ef_baruba9, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba9)
	dot_disp_unit(barbaroi9 , true)
	
	on_active(Ef_baruba10)
	local gridpos = get_grid_position(14,7)
	set_pos(Ef_baruba10, gridpos)
	set_scale(Ef_baruba10, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba10)
	dot_disp_unit(barbaroi10, true)
	
	on_active(Ef_baruba11)
	local gridpos = get_grid_position(16,7)
	set_pos(Ef_baruba11, gridpos)
	set_scale(Ef_baruba11, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba11)
	dot_disp_unit(barbaroi11, true)
	
	on_active(Ef_baruba12)
	local gridpos = get_grid_position(17,7)
	set_pos(Ef_baruba12, gridpos)
	set_scale(Ef_baruba12, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba12)
	dot_disp_unit(barbaroi12, true)
	
	on_active(Ef_baruba13)
	local gridpos = get_grid_position(15,8)
	set_pos(Ef_baruba13, gridpos)
	set_scale(Ef_baruba13, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba13)
	dot_disp_unit(barbaroi13, true)
	
	wait_time(1.5)
	
	on_active(Ef_baruba)
	local gridpos = get_grid_position(14,1)
	set_pos(Ef_baruba, gridpos)
	set_scale(Ef_baruba, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba)
	dot_disp_unit(barbaroi  , true)
	
	on_active(Ef_baruba2)
	local gridpos = get_grid_position(15,1)
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2)
	dot_disp_unit(barbaroi2 , true)
	
	on_active(Ef_baruba3)
	local gridpos = get_grid_position(13,3)
	set_pos(Ef_baruba3, gridpos)
	set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3)
	dot_disp_unit(barbaroi3 , true)
	
	on_active(Ef_baruba4)
	local gridpos = get_grid_position(14,3)
	set_pos(Ef_baruba4, gridpos)
	set_scale(Ef_baruba4, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba4)
	dot_disp_unit(barbaroi4 , true)
	
	on_active(Ef_baruba5)
	local gridpos = get_grid_position(12,4)
	set_pos(Ef_baruba5, gridpos)
	set_scale(Ef_baruba5, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba5)
	dot_disp_unit(barbaroi5 , true)
	
	
	wait_time(2.5)
	
	move_camera(15, 10, 1.3)
	wait_camera()
	
	wait_time(0.2)

	
	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	 --PlayPartVoice("モルドレッド", "肯定2")
	message("MA_01C112_180005")
	

	
	change_face(Mordred, "Anger")
	
	 --PlayPartVoice("モルドレッド", "激怒")
	message("MA_01C112_180006")
	close_speech_window()
	
	dot_change_anim(dotNoir2,12)
	dot_change_anim(dotDinatan1,12)

	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	 --PlayPartVoice("ノワール", "肯定2")
	message("MA_01C112_180007")
	close_speech_window()

				



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10203009",  "content_still_10203009_image", "102030090_StillImage")
    pbadv_setup_101009_Noir_preload(2,true,15,10,0)
    pbadv_setup_101012_Dinatan_preload(1,true,16,10,0)
	pbadv_setup_101022_Mordred_preload(0,true,17,11,0)
	pbadv_setup_101023_Clarice_preload(1,true,18,11,0)
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
