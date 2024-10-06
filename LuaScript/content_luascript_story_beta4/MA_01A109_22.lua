

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	
	init_psbattleadv("201010002", "201010002")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 3, 20,0)  

	pbadv_setup_101011_Guinevere(0,true,3, 19,0)


	pbadv_setup_101011_Guinevere(1,true,13, 19,0)
	
	
	pbadv_setup_101013_Gawain(0,true, 2, 20,0)  

	
	pbadv_setup_101018_Ragnar(0,true, 2, 19,0)  

   
 	pbadv_setup_101030_Elaine(3,true, 0, 20,0)  

	
	pbadv_setup_101031_Lovein(0,true, 1, 19,0)  

	
	pbadv_setup_101046_Gliton(true,39,27,0)	

	
	rog1 = dot_reserve_ally(401036001, 15, 19, 0)
	dot_set_weapon(rog1, 105010001)
	rog2 = dot_reserve_ally(401036001, 15, 20, 0)
	dot_set_weapon(rog2, 105010001)
	rog3 = dot_reserve_ally(401036001, 9, 17, 0)
	dot_set_weapon(rog3, 105010001)
	rog4 = dot_reserve_ally(401036001, 12, 21, 0)
	dot_set_weapon(rog4, 105010001)
	rog5 = dot_reserve_ally(401036001, 37, 25, 0)
	dot_set_weapon(rog5, 105010001)
	rog6 = dot_reserve_ally(401036001, 35, 23, 0)
	dot_set_weapon(rog6, 105010001)
	rog7 = dot_reserve_ally(401036001, 31, 22, 0)
	dot_set_weapon(rog7, 105010001)

	
	barbaroi1 = dot_reserve_enemy(49, 0, 0, 0)
	barbaroi2 = dot_reserve_enemy(49, 1, 0, 0)
	barbaroi3 = dot_reserve_enemy(49, 2, 0, 0)
	barbaroi4 = dot_reserve_enemy(49, 3, 0, 0)
	
	
	setup_complete_unit()
	

	
	dot_disp_unit(dotNoir2, false)
	dot_disp_unit(dotGuinevere, false)
	dot_disp_unit(dotGuinevere1, false)
	dot_disp_unit(dotGawain, false)
	dot_disp_unit(dotRagnar, false)
	dot_disp_unit(dotElaine3, false)
	dot_disp_unit(dotLovein, false)

	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)

	dot_unit_dir(rog1, 2)
	dot_unit_dir(rog2, 2)
	dot_unit_dir(rog3, 2)
	dot_unit_dir(rog4, 2)
	dot_unit_dir(rog5, 2)
	dot_unit_dir(rog6, 2)
	dot_unit_dir(rog7, 2)
	
	dot_move_height(dotGliton,5,0,0)
	
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(45.0, 0.0)
	
	
	move_camera(39, 26, 0.0)

	
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 

	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)

	Ef_Change1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	Ef_Change2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	Ef_Change3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	Ef_Change4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)

end






function Play()
	fadein(0)
	Play_start(true)
	
	
	dot_move_height(dotGliton,2,2.5,0)

	wait_time(2.5)

	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220002")
	
	
	
	
	message("MA_01A109_220003")
	
	
	
	
	message("MA_01A109_220004")
	close_speech_window()

	move_camera(12, 20, 5.0)
	change_camera_angle(25.0, 5.0)

	
	dot_disp_unit(dotNoir2, true)
	dot_disp_unit(dotGuinevere, true)
	dot_disp_unit(dotGawain, true)
	dot_disp_unit(dotRagnar, true)
	dot_disp_unit(dotElaine3, true)
	dot_disp_unit(dotLovein, true)

	wait_camera()
	
	
	dot_reserve_move_unit_seq(dotNoir2, 13, 20)
	dot_reserve_move_unit_seq(dotGuinevere, 12, 19)
	dot_reserve_move_unit_seq(dotGawain, 10, 20)
	dot_reserve_move_unit_seq(dotRagnar, 10, 19)
	dot_reserve_move_unit_seq(dotElaine3, 7, 20)
	dot_reserve_move_unit_seq(dotLovein, 8, 20)
	
	
	exec_parallel_seq()
	
	
	wait_seq()
	
	
	change_face(Gliton, "Normal")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220006")
	close_speech_window()
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A109_220007")
	
	
	
	
	

	
	MA_01A109_22_select1()

	
	open_select_window_tag(Noir2, "Normal", "MA_01A109_220009", "MA_01A109_220010", "MA_01A109_220011")	
	close_speech_window()	

	if is_select(1) then			
		MA_01A109_22_select1_1()

	elseif is_select(2) then		
		MA_01A109_22_select1_2()

	elseif is_select(3) then		
		MA_01A109_22_select1_3()

	end
	MA_01A109_22_end()

end

function MA_01A109_22_select1()

end

function MA_01A109_22_select1_1()



	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A109_220013")
	close_speech_window()
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A109_220014")
	close_speech_window()
	
	
	change_face(Gawain, "Smile")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A109_220015")
	close_speech_window()
	


		
end


function MA_01A109_22_select1_2()





	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A109_220017")
	close_speech_window()
	
	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220018")
	close_speech_window()

	move_camera(9, 19, 1.0)
	wait_camera()

	
	change_face(Elaine3, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_220019")
	
	
	
	change_face(Elaine3, "Sad")
	
	message("MA_01A109_220021")
	close_speech_window()




		
end


function MA_01A109_22_select1_3()



	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A109_220023")
	close_speech_window()
	
	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220024")
	
	
	
	
	message("MA_01A109_220025")
	close_speech_window()
	
	
	change_face(Ragnar, "Anger")
	open_speech_window("CHRNAME_RAGNAR", Ragnar, nil)
	message("MA_01A109_220026")
	close_speech_window()




		
end


function MA_01A109_22_end()

	move_camera(15, 19, 1.0)
	wait_camera()

	dot_place_unit(dotGliton,17,18)
	dot_move_height(dotGliton,4,0,0)
	wait_time(1.0)

	dot_move_height(dotGliton,0,2.5,2)

	wait_time(2.5)


	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220028")
	
	
	
	message("MA_01A109_220029")
	
	
	
	message("MA_01A109_220030")
	close_speech_window()

	on_active(Ef_BlFeather)

	local gridpos = get_grid_position(17,18)
	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)


	wait_time(1.0)


	
	on_active(Ef_Change1)
	on_active(Ef_Change2)
	on_active(Ef_Change3)
	on_active(Ef_Change4)

	local gridpos = get_grid_position(15, 19)
	set_pos(Ef_Change1, gridpos)
	play_particle(Ef_Change1)

	local gridpos = get_grid_position(15, 20)
	set_pos(Ef_Change2, gridpos)
	play_particle(Ef_Change2)

	local gridpos = get_grid_position(9, 17)
	set_pos(Ef_Change3, gridpos)
	play_particle(Ef_Change3)

	local gridpos = get_grid_position(12, 21)
	set_pos(Ef_Change4, gridpos)
	play_particle(Ef_Change4)

	wait_time(1.0)
	
	dot_change_unit(rog1,barbaroi1,0)
	dot_change_unit(rog2,barbaroi2,0)
	dot_change_unit(rog3,barbaroi3,0)
	dot_change_unit(rog4,barbaroi4,0)

	wait_time(2.0)

	move_camera(9, 19, 1.0)
	wait_camera()

	
	change_face(Lovein, "Sad")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01A109_220032")
	

	
	change_face(Lovein, "Anger")
	message("MA_01A109_220033")
	close_speech_window()
	
	
	change_face(Elaine3, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_220034")
	close_speech_window()
	
	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A109_220035")
	close_speech_window()
	
	
	change_face(Ragnar, "Anger")
	open_speech_window("CHRNAME_RAGNAR", Ragnar, nil)
	message("MA_01A109_220036")
	close_speech_window()
	

	move_camera(14, 20, 1.0)
	wait_camera()

	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220037")
	close_speech_window()
	
	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A109_220038")
	close_speech_window()
	
	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220039")
	close_speech_window()
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A109_220041")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A109_220043")
	close_speech_window()
	
	change_camera_distance(7.0, 1.0)
	move_camera(12, 19, 1.0)
	wait_camera()

	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotGuinevere,1)
	set_pos(Ef_Emblem1, locatorpos)

	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotNoir2,1)
	set_pos(Ef_Emblem2, locatorpos)

	play_particle(Ef_Emblem2)

	wait_time(2.0)

	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(12, 19)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(13, 20)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)


	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A109_220044")
	close_speech_window()
	

	bgm_play("BGM_To_Main")

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A109_220045")
	close_speech_window()

	
	
	open_cutin(1,1)
	
	on_cutin(1, Noir2, "Anger", 1)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01A109_220046")
	close_speech_window()

	
	close_cutin()
	wait_time(2.0)


	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(12, 19)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)

	dot_change_unit(dotGuinevere, dotGuinevere1, 0.0)


	wait_time(1.5)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)

	wait_time(2.0)

	change_camera_distance(8.0, 1.0)
	move_camera(9, 20, 1.0)
	wait_camera()
	
	
	change_face(Elaine3, "Surprise")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_220048")
	
	message("MA_01A109_220050")
	close_speech_window()
	

	move_camera(14, 20, 1.0)
	wait_camera()
	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220052")
	close_speech_window()
	
	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_220053")
	close_speech_window()
	
	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_220054")
	close_speech_window()
	
	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_220055")
	
	
	
	change_face(Guinevere1, "Normal")
	
	message("MA_01A109_220056")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 3, 20,0)
	pbadv_setup_101011_Guinevere_preload(0,true,3, 19,0)
	pbadv_setup_101011_Guinevere_preload(1,true,13, 19,0)
	pbadv_setup_101013_Gawain_preload(0,true, 2, 20,0)
	pbadv_setup_101018_Ragnar_preload(0,true, 2, 19,0)
 	pbadv_setup_101030_Elaine_preload(3,true, 0, 20,0)
	pbadv_setup_101031_Lovein_preload(0,true, 1, 19,0)
	pbadv_setup_101046_Gliton_preload(true,39,27,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
end
