

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)


	init_psbattleadv("201200001", "201200001")
	
	
	change_time_and_weather(1, 1) 

	pbadv_setup_101036_Viena(0,true, 40, 1,0)  
	pbadv_setup_101026_Percival(0,true, 39, 1,0)  
	pbadv_setup_101027_Dindrane(2,true, 38, 2,0)  

	pbadv_setup_101028_Galahad(1,true, 41, 2,0)   


	
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotGalahad1, 2)
	dot_unit_dir(dotViena, 2)

	dot_change_anim(dotViena, 1)
	dot_change_anim(dotGalahad1, 1)

	dot_disp_weapon(dotGalahad1,false)
	dot_disp_weapon(dotPercival,false)
	dot_disp_weapon(dotViena,false)
	dot_disp_weapon(dotDindrane2,false)
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(39, 2, 0.0)
end

function Play()
	fadein(0)
	Play_start(true)

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_300002")
	close_speech_window()

	
	
	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_300004")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_300005")

	
	change_face(Galahad1, "Sad")
	message("MA_01B111_300006")

	
	change_face(Galahad1, "Sad")
	message("MA_01B111_300007")
	close_speech_window()

	
	
	change_face(Dindrane2, "Normal")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_300009")
	close_speech_window()

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_300010")
	close_speech_window()

	
	change_face(Galahad1, "Shy")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_300011")
	close_speech_window()

	
	
	change_face(Dindrane2, "Normal")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_300013")
	
	change_face(Dindrane2, "Normal")
	message("MA_01B111_300014")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_300015")
	close_speech_window()

	
	change_face(Percival, "Sad")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_300016")
	close_speech_window()

	
	change_face(Dindrane2, "Normal")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_300017")

	
	change_face(Dindrane2, "Normal")
	message("MA_01B111_300018")

	
	change_face(Dindrane2, "Normal")
	message("MA_01B111_300019")
	close_speech_window()




	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101036_Viena_preload(0,true, 40, 1,0)
	pbadv_setup_101026_Percival_preload(0,true, 39, 1,0)
	pbadv_setup_101027_Dindrane_preload(2,true, 38, 2,0)
	pbadv_setup_101028_Galahad_preload(1,true, 41, 2,0)
end
