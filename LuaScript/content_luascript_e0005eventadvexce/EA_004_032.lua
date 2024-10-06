
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(1,1) 

	
	pbadv_setup_101009_Noir(2,true, 20, 33,0)  
	pbadv_setup_101034_Excelia(0,true, 20, 35,0)  
	pbadv_setup_101035_Liliana(0,true, 19, 34,0)  
	pbadv_setup_101054_Adam(3,true, 13, 35,0)  
	
	seito1 = dot_reserve_ally(401005001, 23,  33, 0)
	dot_set_weapon(seito1, 101010005)		
	
	seito2 = dot_reserve_ally(401006001, 23,  34, 0)
	dot_set_weapon(seito2, 101010005)		
	
	seito3 = dot_reserve_ally(401007001, 23,  35, 0)
	dot_set_weapon(seito3, 101010005)		
	
	seito4 = dot_reserve_ally(401008001, 23,  36, 0)
	dot_set_weapon(seito4, 101010005)		



setup_complete_unit()

	dot_unit_dir(seito1, 2)
	dot_unit_dir(seito2, 2)
	dot_unit_dir(seito3, 2)
	dot_unit_dir(seito4, 2)
	
	
	dot_disp_weapon(dotNoir2, false)	
	dot_disp_weapon(dotExcelia, false)	
	dot_disp_weapon(dotLiliana, false)	
	dot_disp_weapon(dotAdam3, false)		
	dot_disp_weapon(seito1, false)
	dot_disp_weapon(seito2, false)	
	dot_disp_weapon(seito3, false)	
	dot_disp_weapon(seito4, false)	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(21, 35, 0.0)
	

end



function Play()
	fadein(0)
	Play_start(true)
	




	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoice("エクセリア","肯定3")	
	message("EA_004_0320004")

	change_face(Excelia, "Normal")	
	message("EA_004_0320005")

	change_face(Excelia, "Normal")	
	message("EA_004_0320006")
	close_speech_window()

	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","肯定2")		
	message("EA_004_0320007")
	close_speech_window()
	
	dot_move_unit_seq(seito1, 22, 33)
	wait_seq()		

	wait_time(0.2)	


	open_speech_window("NPCNAME_0151", nil, nil)
	PlayPartVoice("男子1","悩む")		
	message("EA_004_0320008")
	close_speech_window()

	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0320009")
	close_speech_window()


	open_speech_window("NPCNAME_0151", nil, nil)
	PlayPartVoice("男子1","否定")		
	message("EA_004_0320010")
	close_speech_window()


	open_speech_window("NPCNAME_0153", nil, nil)
	PlayPartVoice("男子2","悩む")		
	message("EA_004_0320011")

	message("EA_004_0320012")
	close_speech_window()

	change_face(Excelia, "Anger")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoice("エクセリア","怒り")		
	message("EA_004_0320013")

	change_face(Excelia, "Anger")	
	message("EA_004_0320014")
	close_speech_window()
	
	se_play("SE_ADV_MA_01107_06_Crowds")
	
	wait_time(0.5)	
	

	open_speech_window("NPCNAME_0153", nil, nil)
	message("EA_004_0320015")
	close_speech_window()
	
	dot_unit_dir(seito1, 3)	
	
	dot_move_unit_seq(seito4, 22, 35)
	wait_seq()	
	
	dot_unit_dir(seito4, 3)		
	
	wait_time(0.8)		
	
	dot_unit_dir(seito1, 2)		

	wait_time(0.5)		
	
	dot_unit_dir(seito4, 2)			
	
	
	wait_time(0.5)		
	
	dot_move_unit_seq(dotLiliana, 19, 35)
	wait_seq()	



	change_face(Liliana, "Normal")	
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ","挨拶")		
	message("EA_004_0320018")
	close_speech_window()
	
	dot_unit_dir(dotExcelia, 2)		
	
	wait_time(0.3)		


	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0320019")

	change_face(Excelia, "Anger")	
	message("EA_004_0320020")

	change_face(Excelia, "Anger")	
	message("EA_004_0320021")
	close_speech_window()


	change_face(Liliana, "Normal")	
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	message("EA_004_0320022")
	close_speech_window()
	
	
	dot_unit_dir(dotNoir2, 2)	
	dot_unit_dir(seito1, 2)		

	wait_time(0.3)			

	change_face(Noir2, "Sad")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","悩む")		
	message("EA_004_0320024")

	change_face(Noir2, "Normal")	
	voice_play("VO_101009_sp_0027_1")	
	message("EA_004_0320025")


    EA_004_032_select1()
 
    open_select_window_tag(Noir2, "Normal", "EA_004_0320027", "EA_004_0320028")   
    close_speech_window() 
    
    if is_select(1) then            
        EA_004_032_select1_1()
 
    elseif is_select(2) then        
		EA_004_032_select1_2()
 

	end
	EA_004_032_end()
 
end
 
function EA_004_032_select1()
 
end
 
function EA_004_032_select1_1()
 

	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("EA_004_0320031")
	close_speech_window()


	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoice("エクセリア","否定")			
	message("EA_004_0320032")
	close_speech_window()


	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("EA_004_0320033")

	change_face(Noir2, "Normal")	
	message("EA_004_0320034")
	close_speech_window()

	
	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0320035")

	change_face(Excelia, "Normal")	
	message("EA_004_0320043")
	close_speech_window()	
 
      
end
 
 
function EA_004_032_select1_2()
 


	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("EA_004_0320038")
	close_speech_window()


	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoice("エクセリア","肯定2")			
	message("EA_004_0320039")
	
	change_face(Excelia, "Normal")	
	message("EA_004_0320040")
	close_speech_window()

	open_speech_window("NPCNAME_0151", nil, nil)
	message("EA_004_0320041")
	close_speech_window()

	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0320043")
	close_speech_window()
 
    
end
 
function EA_004_032_end()		


	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("EA_004_0320044")
	close_speech_window()
	
	move_camera(19, 35, 0.5)
	
	dot_move_unit_seq(dotAdam3, 18, 35)
	wait_seq()	

	change_face(Adam3, "Normal")	
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	PlayPartVoice("アダン","否定")		
	message("EA_004_0320046")
	close_speech_window()
	

	dot_unit_dir(dotNoir2, 2)	
	dot_unit_dir(dotExcelia, 2)	
	dot_unit_dir(dotLiliana, 2)	
	wait_time(0.5)	

	change_face(Excelia, "Surprise")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoice("エクセリア","驚き")		
	message("EA_004_0320047")
	close_speech_window()

	change_face(Adam3, "Normal")	
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	message("EA_004_0320048")
	close_speech_window()

	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0320049")
	close_speech_window()

	dot_move_unit_seq(dotAdam3, 18, 34)
	wait_seq()	

	change_face(Adam3, "Normal")	
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	voice_play("VO_101054_sp_0001_1")		
	message("EA_004_0320050")
	close_speech_window()

	change_face(Noir2, "Surprise")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","驚き")		
	message("EA_004_0320052")
	close_speech_window()

	change_face(Adam3, "Normal")	
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	PlayPartVoice("アダン","肯定2")		
	message("EA_004_0320053")

	change_face(Adam3, "Smile")	
	message("EA_004_0320054")
	close_speech_window()

	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","否定")		
	message("EA_004_0320055")
	close_speech_window()

	change_face(Excelia, "Sad")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)	
	message("EA_004_0320058")
	close_speech_window()

	change_face(Adam3, "Normal")	
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	voice_play("VO_101054_sp_0002_1")		
	message("EA_004_0320059")
	close_speech_window()

	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	PlayPartVoice("エクセリア","肯定3")		
	message("EA_004_0320060")
	close_speech_window()
	
	dot_move_unit_seq(dotExcelia, 18, 36)
	wait_seq()		

	dot_unit_dir(dotExcelia, 3)	

	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","悩む")		
	message("EA_004_0320062")
	
	change_face(Noir2, "Normal")	
	message("EA_004_0320063")
	close_speech_window()
	
	
	
	fadeout(0,0,0,1.0, FADE_TIME)


	wait_time(FADE_TIME)

	dot_place_unit(seito1, 23, 33,0)	
	dot_place_unit(seito4, 23, 36,0)		
	dot_place_unit(dotAdam3, 18, 35,0)
	dot_place_unit(dotNoir2, 21, 34,0)
	dot_place_unit(dotLiliana, 20, 35,0)	
	dot_unit_dir(seito1, 2)	
	dot_unit_dir(seito4, 2)				
	dot_unit_dir(dotNoir2, 3)	
	dot_unit_dir(dotExcelia, 3)	
	dot_unit_dir(dotLiliana, 3)		

	move_camera(22, 35, 0.0)	
	
	wait_time(0.1)

	
	wait_time(0.2)
	
	
	fadein(FADE_TIME)

	wait_time(FADE_TIME)		
	


	open_speech_window("NPCNAME_0151", nil, nil)
	PlayPartVoice("男子1","納得")			
	message("EA_004_0320066")
	close_speech_window()
			
	open_speech_window("NPCNAME_0153", nil, nil)
	PlayPartVoice("男子2","肯定")		
	message("EA_004_0320067")
	close_speech_window()
	
	
	move_camera(19, 35, 1.0)	
	wait_camera()
	
	wait_time(0.2)	
	

	change_face(Excelia, "Normal")	
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("EA_004_0320069")
	close_speech_window()

	change_face(Adam3, "Normal")	
	open_speech_window("CHRNAME_ADAM", Adam3, nil)
	message("EA_004_0320070")
	close_speech_window()

	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","肯定")		
	message("EA_004_0320071")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")


	
	
	Play_end(true)
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 33,0)
	pbadv_setup_101034_Excelia_preload(0,true, 20, 35,0)
	pbadv_setup_101035_Liliana_preload(0,true, 19, 34,0)
	pbadv_setup_101054_Adam_preload(3,true, 13, 35,0)
end
