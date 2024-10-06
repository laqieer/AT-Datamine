
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201070000", "201070000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Cloudy) 

	
	pbadv_setup_101009_Noir(2,true, 24, 13,0)  
	pbadv_setup_101001_Tyrfing(0,true, 25, 12,0)  
	pbadv_setup_101012_Dinatan(0,true, 25, 14,0)
	pbadv_setup_101017_Maladisant(0,true, 26, 14,0)  
	pbadv_setup_101014_Tristan(0,true, 26, 15,0)  
	pbadv_setup_101013_Gawain(0,true, 26, 13,0)  
	pbadv_setup_101018_Ragnar(0,true, 27, 14,0)  
	pbadv_setup_101011_Guinevere(0,true, 27, 15,0)  
	pbadv_setup_101016_Gwenhwymawr(0,true, 26, 11,0)  
	pbadv_setup_101015_Arthur(0,true, 28, 12,0)  
	pbadv_setup_101019_Isolde(0,true, 26, 12,0)  
		
	pbadv_setup_101050_Brian(0,true,22, 13,0)

	barbaroi1 = dot_reserve_enemy(1100, 21, 12, 0)
	barbaroi2 = dot_reserve_enemy(1100, 21, 14, 0)
	
	
	roguresu1 = dot_reserve_ally(401038001, 20, 11, 0)
	dot_set_weapon(roguresu1, 105010001)		
	roguresu2 = dot_reserve_ally(401038001, 20, 14, 0)
	dot_set_weapon(roguresu2, 105010001)		

setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotTyrfing, 2)
	dot_unit_dir(dotDinatan, 2)
	dot_unit_dir(dotMaladisant, 2)
	dot_unit_dir(dotTristan, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotRagnar, 2)
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGwenhwymawr, 2)
	dot_unit_dir(dotArthur, 2)
	dot_unit_dir(dotIsolde, 2)
	dot_unit_dir(dotBrian, 3)
	dot_unit_dir(barbaroi1, 3)
	dot_unit_dir(barbaroi2, 3)

	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	
	
	Ef_baruba1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	
	load_image("10201013",  "content_still_10201013_image", "102010130_StillImage")
	show_image("10201013", 0.0, 0.0, 0 ,true,false)	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(24, 14, 0.0)
end



function Play()
	fadein(0)
	Play_start(true)
	
	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)	

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_280002")
	close_speech_window()

	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_280003")
	close_speech_window()

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_280004")
	
	change_face(Brian, "Normal") 
	message("MA_01106_280005")
	
	change_face(Brian, "Normal") 
	message("MA_01106_280006")
	close_speech_window()

	
	change_face(Dinatan, "Sad") 
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_280007")
	close_speech_window()

	
	change_face(Tristan, "Normal") 
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01106_280009")
	close_speech_window()

	
	change_face(Gawain, "Anger") 
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_280010")
	close_speech_window()

	
	change_face(Guinevere, "Normal") 
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_280011")
	close_speech_window()

	
	change_face(Gawain, "Anger") 
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_280012")
	close_speech_window()

	
	change_face(Guinevere, "Normal") 
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_280013")
	close_speech_window()

	
	change_face(Gawain, "Normal") 
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_280014")
	close_speech_window()

	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_280015")
	close_speech_window()

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_280016")
	close_speech_window()

	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_280017")
	close_speech_window()
	
	
	on_active(Ef_baruba1)
	local gridpos = get_grid_position(21,12)
	set_pos(Ef_baruba1 , gridpos)
	set_scale(Ef_baruba1, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba1 )

	on_active(Ef_baruba2 )
	local gridpos = get_grid_position(21,14)
	set_pos(Ef_baruba2 , gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2 )

	wait_time(0.2)	

	dot_disp_unit(barbaroi2, true)	
	dot_disp_unit(barbaroi1, true)	
	
	wait_time(2.0)	
	
	wait_time(0.5)

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_280019")
	close_speech_window()

	
	change_face(Maladisant, "Normal") 
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_280020")
	
	change_face(Maladisant, "Normal") 
	message("MA_01106_280021")
	close_speech_window()

	
	change_face(Dinatan, "Sad") 
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_280022")
	close_speech_window()

	
	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_280023")
	close_speech_window()

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 24, 13,0)
	pbadv_setup_101001_Tyrfing_preload(0,true, 25, 12,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 25, 14,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 26, 14,0)
	pbadv_setup_101014_Tristan_preload(0,true, 26, 15,0)
	pbadv_setup_101013_Gawain_preload(0,true, 26, 13,0)
	pbadv_setup_101018_Ragnar_preload(0,true, 27, 14,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 27, 15,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true, 26, 11,0)
	pbadv_setup_101015_Arthur_preload(0,true, 28, 12,0)
	pbadv_setup_101019_Isolde_preload(0,true, 26, 12,0)
	pbadv_setup_101050_Brian_preload(0,true,22, 13,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_image_preload("10201013",  "content_still_10201013_image", "102010130_StillImage")
end
