
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201160000", "201160000")
	change_time_and_weather(1,1) 

	
	pbadv_setup_101009_Noir(2,true, 19, 12,0)  
	pbadv_setup_101001_Tyrfing(1,true, 17, 9,0)  
	pbadv_setup_101012_Dinatan(0,true, 17, 12,0)
	pbadv_setup_101014_Tristan(0,true, 16, 10,0)  
	pbadv_setup_101010_Lancelot(3,true, 16, 13,0) 
	pbadv_setup_101017_Maladisant(0,true, 17, 11,0)  
	pbadv_setup_101011_Guinevere(0,true, 17, 10,0)  
	pbadv_setup_101019_Isolde(1,true, 16, 11,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 16, 12,0)  
	
	pbadv_setup_101050_Brian(0,true, 21, 12,0)
	pbadv_setup_101043_Mazoe(true, 22, 11,0)  
	pbadv_setup_101041_Morgan(2,true, 22, 10,0) 

setup_complete_unit()

	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotDinatan, 3)
	dot_unit_dir(dotBrian, 2)
	dot_unit_dir(dotMazoe, 2)
	dot_unit_dir(dotTristan, 3)
	dot_unit_dir(dotMorgan2, 2)
	dot_unit_dir(dotLancelot3, 3)
	dot_unit_dir(dotMaladisant, 3)
	dot_unit_dir(dotGuinevere, 3)
	dot_unit_dir(dotIsolde1, 3)
	dot_unit_dir(dotGwenhwymawr1, 3)
	
	









	
	Ef_teni1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_teni2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_teni3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(20, 12, 0.0)
end



function Play()
	fadein(0)
	Play_start(true)



	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_180002")
	close_speech_window()
	

	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_180003")
	close_speech_window()	


	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_180004")
	close_speech_window()
	

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_180005")
	close_speech_window()	
	
	move_camera(18, 12, 1.0)
	
	dot_disp_unit(dotMaladisant, true)
	dot_move_unit_seq(dotMaladisant, 18, 11)
	wait_seq()
	
	wait_camera()

	change_face(Maladisant, "Anger")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_180006")
	close_speech_window()


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_180007")
	close_speech_window()
	


	change_face(Maladisant, "Anger")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_180008")
	close_speech_window()


	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_180009")
	close_speech_window()
	
	
	on_active(Ef_Fog) 

	local gridpos = get_grid_position(18, 11)
	set_pos(Ef_Fog, gridpos)
	play_particle(Ef_Fog)

	wait_time(0.5)		
	
	
	dot_change_anim(dotMaladisant,1)


	change_face(Maladisant, "Pain")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_180010")
	close_speech_window()

	move_camera(20, 12, 0.8)

	wait_time(1.0)		

	change_face(Morgan2, "Sad")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01106_180012")
	close_speech_window()

	

	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_180014")
	close_speech_window()
	


	change_face(Mazoe, "Normal") 
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_180016")
	close_speech_window()

	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_180017")
	close_speech_window()

	

	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_180019")

	change_face(Brian, "Normal") 
	message("MA_01106_180021")

	change_face(Brian, "Normal") 
	message("MA_01106_180023")
	close_speech_window()
	

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_180024")
	close_speech_window()	


	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_180026")
	close_speech_window()	
	

	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01106_180027")
	close_speech_window()


	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_180029")

	change_face(Brian, "Normal") 
	message("MA_01106_180030")
	close_speech_window()


	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_180032")
	close_speech_window()	


	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_180034")
	close_speech_window()	


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_180035")
	close_speech_window()	
	
	
	dot_reserve_move_unit_seq(dotBrian, 22, 12)
	exec_parallel_seq()
	wait_seq()

	
	wait_time(1.0)	

	
	on_active(Ef_teni1)
	local gridpos = get_grid_position(22,12)
	set_pos(Ef_teni1, gridpos)
	set_scale(Ef_teni1, {0.8, 0.8, 0.8})
	play_particle(Ef_teni1)

	on_active(Ef_teni2)
	local gridpos = get_grid_position(22,11)
	set_pos(Ef_teni2, gridpos)
	set_scale(Ef_teni2, {0.8, 0.8, 0.8})
	play_particle(Ef_teni2)
	
	on_active(Ef_teni3)
	local gridpos = get_grid_position(22,10)
	set_pos(Ef_teni3, gridpos)
	set_scale(Ef_teni3, {0.8, 0.8, 0.8})
	play_particle(Ef_teni3)
	
	wait_time(1.0)	
	
	dot_disp_unit(dotBrian, false)
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotMorgan2, false)
	
	
	wait_time(1.5)	


	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_180037")
	close_speech_window()	

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 19, 12,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 17, 9,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 17, 12,0)
	pbadv_setup_101014_Tristan_preload(0,true, 16, 10,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 16, 13,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 17, 11,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 17, 10,0)
	pbadv_setup_101019_Isolde_preload(1,true, 16, 11,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 16, 12,0)
	pbadv_setup_101050_Brian_preload(0,true, 21, 12,0)
	pbadv_setup_101043_Mazoe_preload(true, 22, 11,0)
	pbadv_setup_101041_Morgan_preload(2,true, 22, 10,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
end
