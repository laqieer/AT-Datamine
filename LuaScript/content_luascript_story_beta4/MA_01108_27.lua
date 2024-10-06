

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	
	
	
	
	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	 
    pbadv_setup_101009_Noir(2,true,19,18,0)
    
	
	pbadv_setup_101010_Lancelot(0,true,21,18,0)
    
	
	pbadv_setup_101041_Morgan(2,true,20,12,0)
	
	
    pbadv_setup_101028_Galahad(0,true,21,25,0)
    
    
    pbadv_setup_101011_Guinevere(0,true,21,23,0)
    
    
    pbadv_setup_101012_Dinatan(0,true,18,22,0)
    
     
    pbadv_setup_101016_Gwenhwymawr(2,true,22,23,0)
    
        
    pbadv_setup_101020_Merlin(0,true,20,25,0)
    
       
    pbadv_setup_101017_Maladisant(0,true,19,22,0)
    
    
	pbadv_setup_101051_Lucius(0,true,20,23,0)
    
    
    pbadv_setup_101027_Dindrane(2,true,19,24,0)


    
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

	
	
	
		
	
	
	
	
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotNoir2, 0)
	dot_unit_dir(dotLancelot, 0)

	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr, false)
	dot_disp_weapon(dotLancelot, false)
	dot_disp_weapon(dotGalahad, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotMerlin, false)
	dot_disp_weapon(dotMaladisant, false)
	dot_disp_weapon(dotLucius, false)
	dot_disp_weapon(dotDindrane2, false)
	dot_disp_weapon(dotMorgan2, false)

	
	
	
	dot_disp_unit(dotMorgan2, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(20, 22, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	dot_reserve_move_unit_seq(dotNoir2,19,20)
	dot_reserve_move_unit_seq(dotLancelot,21,20)
	dot_reserve_move_unit_seq(dotDinatan,18,32)
	dot_reserve_move_unit_seq(dotMaladisant,19,32)
	dot_reserve_move_unit_seq(dotGalahad,21,35)
	dot_reserve_move_unit_seq(dotLucius,21,32)
	dot_reserve_move_unit_seq(dotGuinevere,21,33)
	dot_reserve_move_unit_seq(dotGwenhwymawr,22,33)
	dot_reserve_move_unit_seq(dotMerlin,20,35)
	dot_reserve_move_unit_seq(dotDindrane2,19,34)
	exec_parallel_seq()
	
	
	
	
	change_face(Morgan2, "Anger")
	open_speech_window("CHRNAME_MORGAN",Morgan2 , nil)
	message("MA_01108_270002")
	close_speech_window()
	
	
	dot_unit_dir(dotNoir2, 0)
	dot_unit_dir(dotLancelot, 2)
	
	dot_disp_unit(dotMorgan2, true)
	move_camera(20, 18, 1.0)
	dot_move_unit_seq(dotMorgan2,20,18)
	wait_seq()
	dot_unit_dir(dotMorgan2, 3)

	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_270003")
	close_speech_window()

	
	
	
	change_face(Morgan2, "Anger")
	open_speech_window("CHRNAME_MORGAN",Morgan2 , nil)
	message("MA_01108_270004")
	close_speech_window()

	
	
	change_face(Lancelot, "Normal")	
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01108_270006")
	close_speech_window()

	
	
	change_face(Morgan2, "Sad")	
	open_speech_window("CHRNAME_MORGAN",Morgan2 , nil)
	message("MA_01108_270007")
	

	
	
	
	
	change_face(Morgan2, "Sad")	
	
	message("MA_01108_270008")
	

	
	
	change_face(Morgan2, "Sad")	
	
	message("MA_01108_270010")
	

	
	
	
	change_face(Morgan2, "Anger")	
	
	message("MA_01108_270011")
	close_speech_window()
	
	
	wait_time(1.5)


	
	
	change_face(Lancelot, "Normal")	
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01108_270013")
	close_speech_window()

	
	
	change_face(Morgan2, "Normal")	
	open_speech_window("CHRNAME_MORGAN",Morgan2 , nil)
	message("MA_01108_270014")
	close_speech_window()

	
	
	change_face(Lancelot, "Normal")	
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01108_270015")
	close_speech_window()
	
	dot_unit_dir(dotMorgan2, 2)
	wait_seq()
	
	
		
	
	change_face(Morgan2, "Normal")	
	open_speech_window("CHRNAME_MORGAN",Morgan2 , nil)
	message("MA_01108_270016")
	

	
	
	change_face(Morgan2, "Normal")	
	
	message("MA_01108_270018")
	close_speech_window()

	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_270019")
	close_speech_window()

	
	
	change_face(Morgan2, "Anger")	
	open_speech_window("CHRNAME_MORGAN",Morgan2 , nil)
	message("MA_01108_270020")
	

	
	
	change_face(Morgan2, "Anger")
	
	message("MA_01108_270021")
	close_speech_window()





	
	

	
	
	
	
	
	
	
	










	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,19,18,0)
	pbadv_setup_101010_Lancelot_preload(0,true,21,18,0)
	pbadv_setup_101041_Morgan_preload(2,true,20,12,0)
    pbadv_setup_101028_Galahad_preload(0,true,21,25,0)
    pbadv_setup_101011_Guinevere_preload(0,true,21,23,0)
    pbadv_setup_101012_Dinatan_preload(0,true,18,22,0)
    pbadv_setup_101016_Gwenhwymawr_preload(2,true,22,23,0)
    pbadv_setup_101020_Merlin_preload(0,true,20,25,0)
    pbadv_setup_101017_Maladisant_preload(0,true,19,22,0)
	pbadv_setup_101051_Lucius_preload(0,true,20,23,0)
    pbadv_setup_101027_Dindrane_preload(2,true,19,24,0)
end
