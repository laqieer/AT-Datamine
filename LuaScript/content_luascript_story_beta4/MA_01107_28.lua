Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	

	
	init_psbattleadv("201000000","201000000")
	change_time_and_weather(1,2)
	


	pbadv_setup_101028_Galahad(2,true,22 ,32 ,0)  
	
	pbadv_setup_101029_Astera(1,true, 23, 32 ,0) 
    
	
	
	barbaroi1  = dot_reserve_enemy(1, 14, 28, 0)
	barbaroi2  = dot_reserve_enemy(1, 15, 28, 0)
	barbaroi3  = dot_reserve_enemy(1, 16, 28, 0)
	barbaroi4  = dot_reserve_enemy(1, 17, 28, 0)
	barbaroi5  = dot_reserve_enemy(1, 18, 28, 0)
	barbaroi6  = dot_reserve_enemy(1, 19, 28, 0)
	barbaroi7  = dot_reserve_enemy(1, 20, 28, 0)
	barbaroi8  = dot_reserve_enemy(1, 21, 28, 0)
	barbaroi9  = dot_reserve_enemy(1, 22, 28, 0)
	barbaroi10 = dot_reserve_enemy(1, 23, 28, 0)
	barbaroi11 = dot_reserve_ally(401038001, 14, 27, 0)
	dot_set_weapon(barbaroi11, 105010001)
	barbaroi12 = dot_reserve_ally(401038001, 15, 27, 0)
	dot_set_weapon(barbaroi12, 105010001)
	barbaroi13 = dot_reserve_ally(401038001, 16, 27, 0)
	dot_set_weapon(barbaroi13, 105010001)
	barbaroi14 = dot_reserve_ally(401038001, 17, 27, 0)
	dot_set_weapon(barbaroi14, 105010001)
	barbaroi15 = dot_reserve_ally(401038001, 18, 27, 0)
	dot_set_weapon(barbaroi15, 101010001)
	barbaroi16 = dot_reserve_ally(401038001, 19, 27, 0)
	dot_set_weapon(barbaroi16, 101010001)
	barbaroi17 = dot_reserve_ally(401038001, 20, 27, 0)
	dot_set_weapon(barbaroi17, 101010001)
	barbaroi18 = dot_reserve_ally(401038001, 21, 27, 0)
	dot_set_weapon(barbaroi18, 101010001)
	barbaroi19 = dot_reserve_ally(401038001, 22, 27, 0)
	dot_set_weapon(barbaroi19, 101010001)
	barbaroi20 = dot_reserve_ally(401038001, 23, 27, 0)
	dot_set_weapon(barbaroi20, 101010001)
	
	
	setup_complete_unit()
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(35.0,0.0)

	
	
	move_camera(23,37,0.0)
	Ef_Roar01_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	Ef_Roar01_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	Ef_Roar01_3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
end





function Play()
	fadein(0)
	Play_start(true)




	dot_reserve_move_unit_seq(dotGalahad2, 22, 36)
	dot_reserve_move_unit_seq(dotAstera1, 23, 36)

	se_play("SE_ADV_MA_01107_28_Emy001_Army_Foot")

	dot_reserve_move_unit_seq(barbaroi1 , 14,32)
	dot_reserve_move_unit_seq(barbaroi2 , 15,32)
	dot_reserve_move_unit_seq(barbaroi3 , 16,32)
	dot_reserve_move_unit_seq(barbaroi4 , 17,32)
	dot_reserve_move_unit_seq(barbaroi5 , 18,32)
	dot_reserve_move_unit_seq(barbaroi6 , 19,32)
	dot_reserve_move_unit_seq(barbaroi7 , 20,32)
	dot_reserve_move_unit_seq(barbaroi8 , 21,32)
	dot_reserve_move_unit_seq(barbaroi9 , 22,32)
	dot_reserve_move_unit_seq(barbaroi10, 23,32)
	dot_reserve_move_unit_seq(barbaroi11, 14,31)
	dot_reserve_move_unit_seq(barbaroi12, 15,31)
	dot_reserve_move_unit_seq(barbaroi13, 16,31)
	dot_reserve_move_unit_seq(barbaroi14, 17,31)
	dot_reserve_move_unit_seq(barbaroi15, 18,31)
	dot_reserve_move_unit_seq(barbaroi16, 19,31)
	dot_reserve_move_unit_seq(barbaroi17, 20,31)
	dot_reserve_move_unit_seq(barbaroi18, 21,31)
	dot_reserve_move_unit_seq(barbaroi19, 22,31)
	dot_reserve_move_unit_seq(barbaroi20, 23,31)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(barbaroi5 , 18,36)
	dot_reserve_move_unit_seq(barbaroi6 , 19,37)
	dot_reserve_move_unit_seq(barbaroi7 , 20,38)
	dot_reserve_move_unit_seq(barbaroi8 , 25,32)
	dot_reserve_move_unit_seq(barbaroi9 , 26,32)
	dot_reserve_move_unit_seq(barbaroi10, 27,32)
	dot_reserve_move_unit_seq(barbaroi15, 18,35)
	dot_reserve_move_unit_seq(barbaroi16, 19,34)
	dot_reserve_move_unit_seq(barbaroi17, 20,33)
	dot_reserve_move_unit_seq(barbaroi18, 25,31)
	dot_reserve_move_unit_seq(barbaroi19, 26,31)
	dot_reserve_move_unit_seq(barbaroi20, 27,31)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(barbaroi5 , 3)
	dot_unit_dir(barbaroi6 , 3)
	dot_unit_dir(barbaroi7 , 3)
	dot_reserve_move_unit_seq(barbaroi1 , 21,32)
	dot_reserve_move_unit_seq(barbaroi2 , 22,32)
	dot_reserve_move_unit_seq(barbaroi3 , 23,32)
	dot_reserve_move_unit_seq(barbaroi4 , 24,32)
	dot_reserve_move_unit_seq(barbaroi8 , 25,38)
	dot_reserve_move_unit_seq(barbaroi9 , 26,37)
	dot_reserve_move_unit_seq(barbaroi10, 27,36)
	dot_reserve_move_unit_seq(barbaroi11, 21,31)
	dot_reserve_move_unit_seq(barbaroi12, 22,31)
	dot_reserve_move_unit_seq(barbaroi13, 23,31)
	dot_reserve_move_unit_seq(barbaroi14, 24,31)
	dot_reserve_move_unit_seq(barbaroi18, 25,33)
	dot_reserve_move_unit_seq(barbaroi19, 26,34)
	dot_reserve_move_unit_seq(barbaroi20, 27,35)
	dot_reserve_move_unit_seq(dotGalahad2, 22, 38)
	dot_reserve_move_unit_seq(dotAstera1, 23, 38)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(barbaroi8 , 2)
	dot_unit_dir(barbaroi9 , 2)
	dot_unit_dir(barbaroi10, 2)
	dot_unit_dir(barbaroi18, 2)
	dot_unit_dir(barbaroi19, 2)
	dot_unit_dir(barbaroi20, 2)
	dot_unit_dir(barbaroi1 , 1)
	dot_unit_dir(barbaroi2 , 1)
	dot_unit_dir(barbaroi3 , 1)
	dot_unit_dir(barbaroi4 , 1)
	dot_unit_dir(barbaroi11, 1)
	dot_unit_dir(barbaroi12, 1)
	dot_unit_dir(barbaroi13, 1)
	dot_unit_dir(barbaroi14, 1)




	change_face(Galahad2, "Normal")
	open_speech_window("NPCNAME_0136", Galahad2, nil)
	message("MA_01107_280002")
	close_speech_window()

	
	
	
	
	dot_reserve_move_unit_seq(barbaroi1 , 21,34)
	dot_reserve_move_unit_seq(barbaroi2 , 22,34)
	dot_reserve_move_unit_seq(barbaroi3 , 23,34)
	dot_reserve_move_unit_seq(barbaroi4 , 24,34)
	dot_reserve_move_unit_seq(barbaroi11, 21,33)
	dot_reserve_move_unit_seq(barbaroi12, 22,33)
	dot_reserve_move_unit_seq(barbaroi13, 23,33)
	dot_reserve_move_unit_seq(barbaroi14, 24,33)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(barbaroi1 , 1)
	dot_unit_dir(barbaroi2 , 1)
	dot_unit_dir(barbaroi3 , 1)
	dot_unit_dir(barbaroi4 , 1)
	dot_unit_dir(barbaroi11, 1)
	dot_unit_dir(barbaroi12, 1)
	dot_unit_dir(barbaroi13, 1)
	dot_unit_dir(barbaroi14, 1)




	change_face(Astera1, "Anger")
	open_speech_window("CHRNAME_NAMELES", Astera1, nil)
	message("MA_01107_280004")
	close_speech_window()


	change_face(Galahad2, "Normal")
	open_speech_window("NPCNAME_0136", Galahad2, nil)
	message("MA_01107_280005")
	close_speech_window()


	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_NAMELES", Astera1, nil)
	message("MA_01107_280006")
	close_speech_window()



	change_face(Galahad2, "Normal")
	open_speech_window("NPCNAME_0136", Galahad2, nil)
	message("MA_01107_280007")
	close_speech_window()


	change_face(Astera1, "Smile")
	open_speech_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01107_280009")
	OpenFirstAppearance(Astera1)
	close_speech_window()





	change_face(Galahad2, "Normal")
	open_speech_window("NPCNAME_0136", Galahad2, nil)
	message("MA_01107_280011")
	close_speech_window()


	
	dot_change_anim(barbaroi1 , 5)
	dot_change_anim(barbaroi2 , 5)
	dot_change_anim(barbaroi3 , 5)
	dot_change_anim(barbaroi4 , 5)
	dot_change_anim(barbaroi5 , 5)
	dot_change_anim(barbaroi6 , 5)
	dot_change_anim(barbaroi7 , 5)
	dot_change_anim(barbaroi8 , 5)
	dot_change_anim(barbaroi9 , 5)
	dot_change_anim(barbaroi10, 5)
	dot_change_anim(barbaroi11, 5)
	dot_change_anim(barbaroi12, 5)
	dot_change_anim(barbaroi13, 5)
	dot_change_anim(barbaroi14, 5)
	dot_change_anim(barbaroi15, 5)
	dot_change_anim(barbaroi16, 5)
	dot_change_anim(barbaroi17, 5)
	dot_change_anim(barbaroi18, 5)
	dot_change_anim(barbaroi19, 5)
	dot_change_anim(barbaroi20, 5)
	
	on_active(Ef_Roar01_1)
	on_active(Ef_Roar01_2)
	on_active(Ef_Roar01_3)
	local gridpos=get_grid_position(27,34)
	set_pos(Ef_Roar01_1,gridpos)
	play_particle(Ef_Roar01_1)
	
	local gridpos=get_grid_position(18,34)
	set_pos(Ef_Roar01_2,gridpos)
	play_particle(Ef_Roar01_2)
	
	local gridpos=get_grid_position(22,32)
	set_pos(Ef_Roar01_3,gridpos)
	play_particle(Ef_Roar01_3)
	
	wait_time(0.5)
	dot_change_anim(barbaroi1 , 0)
	dot_change_anim(barbaroi2 , 0)
	dot_change_anim(barbaroi3 , 0)
	dot_change_anim(barbaroi4 , 0)
	dot_change_anim(barbaroi5 , 0)
	dot_change_anim(barbaroi6 , 0)
	dot_change_anim(barbaroi7 , 0)
	dot_change_anim(barbaroi8 , 0)
	dot_change_anim(barbaroi9 , 0)
	dot_change_anim(barbaroi10, 0)
	dot_change_anim(barbaroi11, 0)
	dot_change_anim(barbaroi12, 0)
	dot_change_anim(barbaroi13, 0)
	dot_change_anim(barbaroi14, 0)
	dot_change_anim(barbaroi15, 0)
	dot_change_anim(barbaroi16, 0)
	dot_change_anim(barbaroi17, 0)
	dot_change_anim(barbaroi18, 0)
	dot_change_anim(barbaroi19, 0)
	dot_change_anim(barbaroi20, 0)


	change_face(Galahad2, "Normal")
	open_speech_window("NPCNAME_0136", Galahad2, nil)
	message("MA_01107_280013")
	close_speech_window()
	



	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101028_Galahad_preload(2,true,22 ,32 ,0)
	pbadv_setup_101029_Astera_preload(1,true, 23, 32 ,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
end
