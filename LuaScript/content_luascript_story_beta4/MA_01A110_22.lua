

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)


	
	
	init_psbattleadv("201140000", "201140000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 20, 36,0)  


	
	pbadv_setup_101011_Guinevere(1,true, 21, 36,0)  
	

   
	pbadv_setup_101038_Lola(1,true, 21, 32,0) 

	
	

	barbaroi1 = dot_reserve_enemy(49, 20, 30, 0)
	barbaroi2 = dot_reserve_enemy(49, 21, 30, 0)
	barbaroi3 = dot_reserve_enemy(42, 20, 31, 0)
	barbaroi4 = dot_reserve_enemy(42, 21, 31, 0)

	barbaroi5 = dot_reserve_enemy(42, 20, 35, 0)
	barbaroi6 = dot_reserve_enemy(42, 21, 35, 0)
	barbaroi7 = dot_reserve_enemy(600, 20, 34, 0)
	barbaroi8 = dot_reserve_enemy(49, 21, 34, 0)

	barbaroi9 = dot_reserve_enemy(600, 22, 30, 0)
	barbaroi10 = dot_reserve_enemy(42, 22, 31, 0)
	
	
	pbadv_setup_101045_Glitonea(true, 22, 32,0) 
	
	
	
	
	setup_complete_unit()


	
	dot_disp_unit(dotLola1, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)

	dot_disp_unit(barbaroi9, false)
	dot_disp_unit(barbaroi10, false)


	
	
	change_camera_distance(7.0, 0.0)


	change_camera_angle(45.0, 0.0)

	move_camera(21, 35, 0.0)


	
	Ef_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_Enemy2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_Enemy3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_Enemy4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_Enemy5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_Enemy6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_Witch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)

	load_image("10203008",  "content_still_10203008_image", "102030080_StillImage")
	show_image("10203008", 0.0, 0.0, 0 ,true,false)

end






function Play()
	fadein(0)
	Play_start(true)


	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)


	dot_attack_seq(dotNoir2, barbaroi5)			
	dot_damage_seq(barbaroi5, dotNoir2, false)	
	wait_seq()
	dot_change_anim(barbaroi5,6)

	dot_damage_seq(barbaroi7, dotNoir2, false)	
	wait_seq()
	dot_change_anim(barbaroi7,6)

	dot_attack_seq(dotGuinevere1, barbaroi6)			
	dot_damage_seq(barbaroi6, dotGuinevere1, false)	
	wait_seq()
	dot_change_anim(barbaroi6,6)

	dot_damage_seq(barbaroi8, dotGuinevere1, false)	
	wait_seq()
	dot_change_anim(barbaroi8,6)

	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",3,true)
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",3,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_DieEmy01",3,true)
	dot_play_particle_unit(barbaroi8,"Ef_C_Cmn_DieEmy01",3,true)
	
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


	dot_change_anim(dotNoir2, DotAnim_Idle)		
	dot_change_anim(dotGuinevere1, DotAnim_Idle)

	wait_time(0.2)

	dot_change_anim(dotNoir2, 0)
	dot_change_anim(dotGuinevere1, 0)

	
	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A110_220002")
	close_speech_window()
	
	
	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01A110_220004")
	close_speech_window()



	dot_disp_unit(dotLola1, true)


	dot_move_unit_seq(dotLola1, 21, 33)

	wait_time(0.1)
	dot_unit_dir(dotLola1, 2)

	
	change_camera_distance(8.0, 2.0)
	change_camera_angle(34.0, 2.0)
	move_camera(21, 35, 2.0)

	wait_camera()


	change_face(Lola1, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola1)
	message("MA_01A110_220006")
	close_speech_window()
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A110_220008")
	close_speech_window()


	change_face(Lola1, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola1)
	message("MA_01A110_220009")
	
	
	
	MA_01A110_22_select1()

	open_select_window_tag(Noir2, "Normal", "MA_01A110_220011", "MA_01A110_220012", "MA_01A110_220013")	

	close_speech_window()	

	if is_select(1) then			
		MA_01A110_22_select1_1()

	elseif is_select(2) then		
		MA_01A110_22_select1_2()

	elseif is_select(3) then		
		MA_01A110_22_select1_3()

	end
	MA_01A110_22_end()

end

function MA_01A110_22_select1()

end

function MA_01A110_22_select1_1()


	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A110_220015")
	close_speech_window()

	
	change_face(Lola1, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola1)
	message("MA_01A110_220016")
	close_speech_window()
	
	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A110_220017")
	close_speech_window()


	dot_change_anim(dotLola1, 3)
	wait_time(0.5)
	dot_change_anim(dotLola1, 0)
	
	
	change_face(Lola1, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola1)
	message("MA_01A110_220028")
	
	
	
	message("MA_01A110_220029")
	
	

	change_face(Lola1, "Normal")
	message("MA_01A110_220030")
	close_speech_window()
	
		
end


function MA_01A110_22_select1_2()



	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A110_220019")
	close_speech_window()


	
	change_face(Lola1, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola1)
	message("MA_01A110_220021")
	close_speech_window()
	
	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A110_220022")
	close_speech_window()


	dot_change_anim(dotLola1, 3)
	wait_time(0.5)
	dot_change_anim(dotLola1, 0)
	
	
	change_face(Lola1, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola1)
	message("MA_01A110_220028")
	
	
	
	message("MA_01A110_220029")
	
	change_face(Lola1, "Normal")
	message("MA_01A110_220030")
	close_speech_window()

		
end


function MA_01A110_22_select1_3()



	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A110_220024")
	close_speech_window()

	
	change_face(Lola1, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola1)
	message("MA_01A110_220025")
	
	
	
	message("MA_01A110_220026")
	


	dot_change_anim(dotLola1, 3)
	wait_time(0.5)
	dot_change_anim(dotLola1, 0)
	
	
	
	
	message("MA_01A110_220028")
	
	
	
	message("MA_01A110_220029")
	

	change_face(Lola1, "Normal")
	message("MA_01A110_220030")
	close_speech_window()


		
end


function MA_01A110_22_end()	
	
	


	
	on_active(Ef_Witch)

	
	local gridpos = get_grid_position(22, 32)
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch)

	wait_time(1.0)
	
	dot_disp_unit(dotGlitonea, true)

	wait_time(2.0)


	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A110_220032")

	dot_unit_dir(dotGlitonea, 2)

	
	
	message("MA_01A110_220033")
	close_speech_window()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A110_220034")
	close_speech_window()
	
	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A110_220035")
	close_speech_window()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A110_220036")
	close_speech_window()
	
	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A110_220037")


	on_active(Ef_Enemy)

	
	local gridpos = get_grid_position(20, 30)
	set_pos(Ef_Enemy, gridpos)
	set_scale(Ef_Enemy, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy)

	on_active(Ef_Enemy2)

	local gridpos = get_grid_position(21, 30)
	set_pos(Ef_Enemy2, gridpos)
	set_scale(Ef_Enemy2, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy2)

	on_active(Ef_Enemy3)

	local gridpos = get_grid_position(20, 31)
	set_pos(Ef_Enemy3, gridpos)
	set_scale(Ef_Enemy3, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy3)

	on_active(Ef_Enemy4)

	local gridpos = get_grid_position(21, 31)
	set_pos(Ef_Enemy4, gridpos)
	set_scale(Ef_Enemy4, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy4)

	on_active(Ef_Enemy5)

	local gridpos = get_grid_position(22, 30)
	set_pos(Ef_Enemy5, gridpos)
	set_scale(Ef_Enemy5, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy5)

	on_active(Ef_Enemy6)

	local gridpos = get_grid_position(22, 31)
	set_pos(Ef_Enemy6, gridpos)
	set_scale(Ef_Enemy6, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy6)

	wait_time(0.2)
	
	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)

	dot_disp_unit(barbaroi9, true)
	dot_disp_unit(barbaroi10, true)

	wait_time(2.0)

	
	
	message("MA_01A110_220039")
	close_speech_window()

	
	change_face(Lola1, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola1)
	message("MA_01A110_220040")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 36,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 21, 36,0)
	pbadv_setup_101038_Lola_preload(1,true, 21, 32,0)
	pbadv_setup_101045_Glitonea_preload(true, 22, 32,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_image_preload("10203008",  "content_still_10203008_image", "102030080_StillImage")
end
