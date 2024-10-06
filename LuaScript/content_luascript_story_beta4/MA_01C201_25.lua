

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	

	
	
	init_psbattleadv("201080100", "201080100")
	change_time_and_weather(1,1) 
	
	
	
	
	
	
	
	
	pbadv_setup_101009_Noir(2,true, 2, 5,0)  
	pbadv_setup_101011_Guinevere(0,true, 15, 5,0)  
	pbadv_setup_101016_Gwenhwymawr(0,true, 16, 4,0)  
	pbadv_setup_101012_Dinatan(0,true, 15, 4,0)  
	pbadv_setup_101017_Maladisant(0,true, 2, 3,0)  
	pbadv_setup_101022_Mordred(0,true, 2, 1,0)  
	
	
	
	
	
	
	
	
	
	
	
	setup_complete_unit()

	
	
	
	
	
	
	
	
	dot_unit_dir(dotDinatan, 2)
	dot_unit_dir(dotGwenhwymawr, 2)
	dot_unit_dir(dotGuinevere, 2)

	
	
	
	
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotMaladisant, false)
	dot_disp_weapon(dotMordred, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr, false)

	
	
	
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(13, 5, 0.0)
end




function Play()
	fadein(0)
	Play_start(true)






	
	

	
	
	
	
	
	
	
	
	
	
	
	
	
	




	dot_reserve_move_unit_seq(dotNoir2, 11, 5)
	dot_reserve_move_unit_seq(dotMaladisant, 11, 3)
	dot_reserve_move_unit_seq(dotMordred, 11, 1)
	exec_parallel_seq()
	wait_seq()


	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01C201_250002")
	close_speech_window()




	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01C201_250004")
	






 
    MA_01C201_25_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01C201_250005", "MA_01C201_250006", "MA_01C201_250007")  
 
    if is_select(1) then            
        MA_01C201_25_select1_1()
 
    elseif is_select(2) then        
        MA_01C201_25_select1_2()
 
    elseif is_select(3) then        
        MA_01C201_25_select1_3()
 
    end
    MA_01C201_25_end()
 
end
 
function MA_01C201_25_select1()
 
end
 
function MA_01C201_25_select1_1()


 

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250009")
	close_speech_window()


	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250010")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250011")
	
	
	wait_time(2.0)
	
	
	change_face(Guinevere, "Normal")
	
	message("MA_01C201_250023")
	close_speech_window()
 
      
end

 
function MA_01C201_25_select1_2()
 

 

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250013")
	close_speech_window()


	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01C201_250014")
	close_speech_window()


	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250015")
	
	
	wait_time(2.0)


	change_face(Guinevere, "Normal")
	
	message("MA_01C201_250023")
	close_speech_window()


 
    
end
 
 
function MA_01C201_25_select1_3()
 

     
 

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250017")
	close_speech_window()


	change_face(Gwenhwymawr, "Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR", nil, Gwenhwymawr)
	message("MA_01C201_250018")
	close_speech_window()


	change_face(Mordred, "Anger")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C201_250019")
	close_speech_window()


	change_face(Gwenhwymawr, "Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR", nil, Gwenhwymawr)
	message("MA_01C201_250020")
	close_speech_window()
	
	wait_time(2.0)


	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250023")
	close_speech_window()
 
        
end
 
 
function MA_01C201_25_end()
 

 



	dot_move_unit_seq(dotDinatan,11,4,1)
	wait_seq()
	dot_unit_dir(dotDinatan, 3)
	wait_time(0.5)


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01C201_250025")
	close_speech_window()


	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250026")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250027")
	close_speech_window()


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250028")
	close_speech_window()


	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250029")
	close_speech_window()




	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250031")
	


	change_face(Noir2, "Anger")
	
	message("MA_01C201_250032")
	


	change_face(Noir2, "Anger")
	
	message("MA_01C201_250033")
	close_speech_window()




	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250035")
	


	change_face(Guinevere, "Normal")
	
	message("MA_01C201_250036")
	close_speech_window()




	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250038")
	close_speech_window()


	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250039")
	




	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250041")
	


	change_face(Guinevere, "Normal")
	
	message("MA_01C201_250042")
	


	change_face(Guinevere, "Normal")
	
	message("MA_01C201_250043")
	close_speech_window()


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250044")
	close_speech_window()



	move_camera(15, 5, 1.5)
	change_camera_distance(5.0, 1.5)


	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250046")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250047")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250048")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250049")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250050")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250051")
	close_speech_window()


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250052")
	close_speech_window()


	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250053")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250054")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250055")
	


	change_face(Guinevere, "Normal")
	
	message("MA_01C201_250056")
	


	change_face(Guinevere, "Normal")
	
	message("MA_01C201_250057")
	




	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250059")
	




	change_face(Guinevere, "Normal")
	
	message("MA_01C201_250061")
	





	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250063")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250064")
	close_speech_window()


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250065")
	close_speech_window()


	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250066")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250067")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Guinevere, "Normal") 




	
	open_speech_window("CHRNAME_GUINEVERE", nil, nil)
	message("MA_01C201_250068")
	close_speech_window()


close_cutin()
	





	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250070")
	


	change_face(Guinevere, "Sad")
	
	message("MA_01C201_250071")
	close_speech_window()


	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01C201_250072")
	close_speech_window()


	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message("MA_01C201_250073")
	


	change_face(Guinevere, "Anger")
	
	message("MA_01C201_250074")
	close_speech_window()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 2, 5,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 15, 5,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true, 16, 4,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 15, 4,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 2, 3,0)
	pbadv_setup_101022_Mordred_preload(0,true, 2, 1,0)
end
