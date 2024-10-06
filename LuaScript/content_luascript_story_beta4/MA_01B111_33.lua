

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)










	
	
	
	init_psbattleadv("201200001", "201200001")
	
	
	change_time_and_weather(1, 5)

	pbadv_setup_101028_Galahad(1,true, 17, 9,0)  
	pbadv_setup_101053_Mathajim(2,true, 16, 9,0)  
	pbadv_setup_101054_Adam(2,true, 18, 9,0)  
	pbadv_setup_101055_Owen(2,true, 17, 8,0)  
	pbadv_setup_101056_Perez(1,true, 18, 5,0)  
	pbadv_setup_101042_Moronoe(true, 13, 7,0)  
	
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotGalahad1, 2)	
	dot_unit_dir(dotMoronoe, 3)
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotMathajim2, 3)
	dot_unit_dir(dotAdam2, 2)
	dot_unit_dir(dotOwen2, 2)
	
	
	
	dot_change_anim(dotGalahad1, 1)

	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(17, 8, 0.0)
end

function Play()
	fadein(0)
	Play_start(true)

	
	wait_time(1.0)

	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_330002")
	
	change_face(Moronoe, "Normal")
	message("MA_01B111_330003")
	
	
	change_face(Moronoe, "Smile")
	message("MA_01B111_330005")
	close_speech_window()

	
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_330007")
	close_speech_window()

	
	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_330008")

	
	
	
	message("MA_01B111_330010")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_330012")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_330013")

	
	message("MA_01B111_330014")
	close_speech_window()

	


	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101028_Galahad_preload(1,true, 17, 9,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 16, 9,0)
	pbadv_setup_101054_Adam_preload(2,true, 18, 9,0)
	pbadv_setup_101055_Owen_preload(2,true, 17, 8,0)
	pbadv_setup_101056_Perez_preload(1,true, 18, 5,0)
	pbadv_setup_101042_Moronoe_preload(true, 13, 7,0)
end
