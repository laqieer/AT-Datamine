

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201080100", "201080100")
	change_time_and_weather(1,1)

	
	
	pbadv_setup_101009_Noir(2,true,14,5,0)
	pbadv_setup_101001_Tyrfing(1,true,15,5,0)
	pbadv_setup_101011_Guinevere(0,true,13,5,0)
	pbadv_setup_101016_Gwenhwymawr(1,true,12,5,0)
	pbadv_setup_101013_Gawain(0,true,11,5,0)
	pbadv_setup_101018_Ragnar(2,true,10,5,0)
	
	
	
	setup_complete_unit()
	
	
	dot_disp_unit(dotNoir2,false)
	dot_disp_unit(dotTyrfing1,false)
	dot_disp_unit(dotGuinevere,false)
	dot_disp_unit(dotGwenhwymawr1,false)
	dot_disp_unit(dotGawain,false)
	dot_disp_unit(dotRagnar2,false)
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotTyrfing1, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr1, false)
	dot_disp_weapon(dotGawain, false)
	dot_disp_weapon(dotRagnar2, false)
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(12, 5, 0.0)
	
	
	Ef_WarpIn_1 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIn_2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIn_3 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIn_4 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIn_5 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIn_6 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	




	


	
	
	
	wait_time(1.0)
	
	

	on_active(Ef_WarpIn_1)
	on_active(Ef_WarpIn_2)
	on_active(Ef_WarpIn_3)
	on_active(Ef_WarpIn_4)
	on_active(Ef_WarpIn_5)
	on_active(Ef_WarpIn_6)

	
	local gridpos_Ef_1 = get_grid_position(14,5)
	local gridpos_Ef_2 = get_grid_position(15,5)
	local gridpos_Ef_3 = get_grid_position(13,5)
	local gridpos_Ef_4 = get_grid_position(12,5)
	local gridpos_Ef_5 = get_grid_position(11,5)
	local gridpos_Ef_6 = get_grid_position(10,5)
	
	set_pos(Ef_WarpIn_1, gridpos_Ef_1)
	set_pos(Ef_WarpIn_2, gridpos_Ef_2)
	set_pos(Ef_WarpIn_3, gridpos_Ef_3)
	set_pos(Ef_WarpIn_4, gridpos_Ef_4)
	set_pos(Ef_WarpIn_5, gridpos_Ef_5)
	set_pos(Ef_WarpIn_6, gridpos_Ef_6)

	
	play_particle(Ef_WarpIn_1)
	play_particle(Ef_WarpIn_2)
	play_particle(Ef_WarpIn_3)
	play_particle(Ef_WarpIn_4)
	play_particle(Ef_WarpIn_5)
	play_particle(Ef_WarpIn_6)
	
	wait_time(0.5)
	
	dot_disp_unit(dotGuinevere,true)
	dot_disp_unit(dotGwenhwymawr1,true)
	dot_disp_unit(dotNoir2,true)
	dot_disp_unit(dotTyrfing1,true)
	dot_disp_unit(dotGawain,true)
	dot_disp_unit(dotRagnar2,true)
	
	wait_time(1.0)
	
	
	dot_move_unit_seq(dotGuinevere, 13, 4)
	wait_seq()
	wait_time(1.0)
	wait_seq()
	
	change_face(Guinevere,"Sad")
	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_320002")
	close_speech_window()
		
	change_face(Noir2,"Normal")
	
	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_320003")
	close_speech_window()
	
	change_face(Gawain,"Anger")
	
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01105_320004")
	close_speech_window()
	
	
	wait_time(1.0)
	dot_unit_dir(dotGuinevere, DotDir_Left)
	wait_time(1.0)
	dot_unit_dir(dotGuinevere, DotDir_Right)
	
	change_face(Guinevere,"Normal")
	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_320005")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dotNoir2,14,0)
	dot_reserve_move_unit_seq(dotTyrfing1,15,0)
	dot_reserve_move_unit_seq(dotGuinevere,13,0)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,12,0)
	dot_reserve_move_unit_seq(dotGawain,11,0)
	dot_reserve_move_unit_seq(dotRagnar2,10,0)
	
	exec_parallel_seq()
	
	
	fadeout(0.0, 0.0, 0.0, 1.0, 0.5)
	
	
	wait_time(1.0)
	wait_seq()
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,14,5,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,15,5,0)
	pbadv_setup_101011_Guinevere_preload(0,true,13,5,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,12,5,0)
	pbadv_setup_101013_Gawain_preload(0,true,11,5,0)
	pbadv_setup_101018_Ragnar_preload(2,true,10,5,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
end
