

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	
	
	
	
	init_psbattleadv("201080100", "201080100")
	change_time_and_weather(1,1) 
	
	
	
	
	
	
	
	
	pbadv_setup_101009_Noir(2,true, 13, 5,0)  
	pbadv_setup_101012_Dinatan(0,true, 11, 3,0)  
	pbadv_setup_101017_Maladisant(0,true, 11, 1,0)  
	pbadv_setup_101032_Gareth(0,true, 10, 3,0) 
	pbadv_setup_101033_Lyoness(0,true, 10, 2,0) 
	pbadv_setup_101016_Gwenhwymawr(0,true, 20, 5,0)  

	
	
	
	
	
	
	
	
	
	
	setup_complete_unit()

	
	
	
	
	
	
	
	
	dot_unit_dir(dotGwenhwymawr, 2)

	
	
	
	
	
	
	

	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotMaladisant, false)
	dot_disp_weapon(dotGareth, false)
	dot_disp_weapon(dotLyoness, false)
	dot_disp_weapon(dotGwenhwymawr, false)

	
	
	
	
	
	dot_disp_unit(dotGwenhwymawr, false)
	
	
	
	
	change_camera_distance(7.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(13, 5, 0.0)
end




function Play()
	fadein(0)
	Play_start(true)






	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	




	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130002")
	close_speech_window()
	
	dot_move_unit_seq(dotMaladisant, 11,2)
	dot_unit_dir(dotMaladisant, 2)
	wait_seq()


	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01C201_130003")
	close_speech_window()


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01C201_130004")
	close_speech_window()


	change_face(Lyoness, "Sad")
	open_speech_window("CHRNAME_LYONESS", Lyoness, nil)
	message("MA_01C201_130005")
	close_speech_window()


	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01C201_130006")
	


	change_face(Dinatan, "Anger")
	
	message("MA_01C201_130007")
	
	

	
	
 
    
    MA_01C201_13_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01C201_130008", "MA_01C201_130009")  
 
    if is_select(1) then            
        MA_01C201_13_select1_1()
 
    else is_select(2) 	      
        MA_01C201_13_select1_2()
  
    end
    MA_01C201_13_end()
    
    end
 
function MA_01C201_13_select1()
 
end
 
function MA_01C201_13_select1_1()
 

 
	 dot_unit_dir(dotNoir2, 2)

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130011")
	close_speech_window()


	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01C201_130012")
	


	change_face(Dinatan, "Normal")
	
	message("MA_01C201_130013")
	close_speech_window()



	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130015")
	close_speech_window()


 
      
end

 
function MA_01C201_13_select1_2()
 

 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130017")
	close_speech_window()


	change_face(Maladisant, "Anger")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01C201_130018")
	


	change_face(Maladisant, "Anger")
	
	message("MA_01C201_130019")
	close_speech_window()

	 dot_unit_dir(dotNoir2, 2)

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130020")
	close_speech_window()


	change_face(Maladisant, "Sad")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01C201_130021")
	


	change_face(Maladisant, "Sad")
	
	message("MA_01C201_130022")
	


	change_face(Maladisant, "Anger")
	
	message("MA_01C201_130023")
	close_speech_window()




	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01C201_130025")
	
	

	change_face(Dinatan, "Normal")
	
	message("MA_01C201_130026")
	


	change_face(Dinatan, "Normal")
	
	message("MA_01C201_130027")
	close_speech_window()
 
    
end

function MA_01C201_13_end()
 





	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01C201_130029")
	


	change_face(Gareth, "Sad")
	
	message("MA_01C201_130030")
	


	change_face(Gareth, "Smile")
	
	message("MA_01C201_130031")
	close_speech_window()


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130032")
	close_speech_window()



	dot_reserve_move_unit_seq(dotDinatan, 2,3)
	dot_reserve_move_unit_seq(dotMaladisant, 2,2)
	dot_reserve_move_unit_seq(dotLyoness, 3,2)
	dot_reserve_move_unit_seq(dotGareth, 2,4)
	exec_parallel_seq()
	wait_seq()
	
	dot_disp_unit(dotDinatan, false)
	dot_disp_unit(dotMaladisant, false)
	dot_disp_unit(dotLyoness, false)
	dot_disp_unit(dotGareth, false)
	wait_seq()
	
	wait_time(1.5)


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130034")
	close_speech_window()


	dot_disp_unit(dotGwenhwymawr, true)
	dot_move_unit_seq(dotGwenhwymawr, 15,5)
	dot_unit_dir(dotGwenhwymawr, 2)
	wait_seq()


	dot_unit_dir(dotNoir2, 3)
	move_camera(14, 5, 1.0)
	wait_time(1.0)


	change_face(Gwenhwymawr, "Normal")
	open_speech_window("CHRNAME_GWENHWYMAWR", Gwenhwymawr, nil)
	message("MA_01C201_130036")
	close_speech_window()


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130037")
	close_speech_window()


	change_face(Gwenhwymawr, "Normal")
	open_speech_window("CHRNAME_GWENHWYMAWR", Gwenhwymawr, nil)
	message("MA_01C201_130038")
	


	change_face(Gwenhwymawr, "Normal")
	
	message("MA_01C201_130039")
	


	change_face(Gwenhwymawr, "Normal")
	
	message("MA_01C201_130040")
	close_speech_window()


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130041")
	close_speech_window()


	change_face(Gwenhwymawr, "Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR", Gwenhwymawr, nil)
	message("MA_01C201_130042")
	close_speech_window()


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_130043")
	close_speech_window()


	change_face(Gwenhwymawr, "Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR", Gwenhwymawr, nil)
	message("MA_01C201_130044")
	close_speech_window()
	
	dot_unit_dir(dotGwenhwymawr, 3)
	wait_time(1.5)
	dot_unit_dir(dotGwenhwymawr, 2)
	wait_time(0.5)


	change_face(Gwenhwymawr, "Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR", Gwenhwymawr, nil)
	message("MA_01C201_130045")
	close_speech_window()
	
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 13, 5,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 11, 3,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 11, 1,0)
	pbadv_setup_101032_Gareth_preload(0,true, 10, 3,0)
	pbadv_setup_101033_Lyoness_preload(0,true, 10, 2,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true, 20, 5,0)
end
