

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(1,1) 
	
	
    pbadv_setup_101009_Noir(2,true,23,24,0)
    pbadv_setup_101012_Dinatan(1,true,23,26,0)
	pbadv_setup_101052_Vernarth(0,true,27,24,0)
	pbadv_setup_101037_Rasia(0,true,25,25,0)
	pbadv_setup_101039_Fren(0,true,26,23,0)
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotVernarth, 2)

	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotDinatan1, false)
	dot_disp_weapon(dotVernarth, false)
	dot_disp_weapon(dotRasia, false)
	dot_disp_weapon(dotFren, false)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(25, 25, 0.0)
	
end





function Play()
	fadein(0)
	Play_start(true)

	
	change_face(Rasia, "Smile") 
	open_speech_window("CHRNAME_RASIA",Rasia , nil)
	message("MA_01C111_340002")
	close_speech_window()

	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340003")
	close_speech_window()

	
	change_face(Vernarth, "Normal") 
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_340004")
	close_speech_window()

	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340005")
	close_speech_window()

	
	change_face(Vernarth, "Smile") 
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_340006")




	
 
    
    MA_01C111_34_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01C111_340007", "MA_01C111_340008")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01C111_34_select1_1()
 
    elseif is_select(2) then        
        MA_01C111_34_select1_2()
 
    end
    MA_01C111_34_end()
 
end
 
function MA_01C111_34_select1()
 
end
 
function MA_01C111_34_select1_1()
 

 
	
	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340010")
	close_speech_window()

	
	change_face(Vernarth, "Normal") 
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_340011")
	
	change_face(Vernarth, "Normal") 
	message("MA_01C111_340012")
	
	change_face(Vernarth, "Smile") 
	message("MA_01C111_340013")
	close_speech_window()

	
	change_face(Noir2, "Smile") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340014")
	close_speech_window()
 
      
end
 
 
function MA_01C111_34_select1_2()
 

 
	
	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340016")
	close_speech_window()

	
	change_face(Vernarth, "Normal") 
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_340017")
	close_speech_window()

	
	change_face(Fren, "Smile") 
	open_speech_window("CHRNAME_FREN",Fren , nil)
	message("MA_01C111_340018")
	close_speech_window()
 
    
end
 
function MA_01C111_34_end()
 

	
	move_camera(24, 25, 0.5)

	
	
	dot_reserve_move_unit_seq(dotVernarth, 24, 24)
	exec_parallel_seq()
	wait_seq()	
	
	
	dot_change_anim(dotVernarth, 1)	
	
	
	dot_unit_dir(dotRasia, 2)
	dot_unit_dir(dotFren, 2)
	
	
	change_face(Vernarth, "Normal") 
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_340020")
	
	change_face(Vernarth, "Sad") 
	message("MA_01C111_340021")
	
	change_face(Vernarth, "Sad") 
	message("MA_01C111_340022")
	
	change_face(Vernarth, "Normal") 
	message("MA_01C111_340023")



    MA_01C111_34_select2()
 
    open_select_window_tag(Noir2, "Normal", "MA_01C111_340024", "MA_01C111_340025")  
	close_speech_window()    
 
    if is_select(1) then            
        MA_01C111_34_select2_1()
 
    elseif is_select(2) then        
        MA_01C111_34_select2_2()
 
    end
    MA_01C111_34_2_end()
 
end
 
function MA_01C111_34_select2()
 
end
 
function MA_01C111_34_select2_1()
 

 
	
	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340027")
	
	change_face(Noir2, "Normal") 
	message("MA_01C111_340028")
	close_speech_window()

	
	change_face(Vernarth, "Sad") 
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_340029")
	close_speech_window()
	
      
end
 
 
function MA_01C111_34_select2_2()
 

 
	
	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340031")
	
	change_face(Noir2, "Normal") 
	message("MA_01C111_340032")
	close_speech_window()

	
	change_face(Dinatan1, "Sad") 
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C111_340033")
	close_speech_window()

	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340034")
	close_speech_window()

	
	change_face(Vernarth, "Sad") 
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_340035")
	close_speech_window()

	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340036")
	close_speech_window()

	
	change_face(Fren, "Sad") 
	open_speech_window("CHRNAME_FREN", Fren, nil)
	message("MA_01C111_340037")
	close_speech_window()

	
	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_340038")
	close_speech_window()
	
    
end
 
function MA_01C111_34_2_end()

	
	
	change_face(Rasia, "Normal") 
	open_speech_window("CHRNAME_RASIA",Rasia , nil)
	message("MA_01C111_340040")
	close_speech_window()
	
	
	dot_change_anim(dotVernarth, 0)	
	
	
	wait_time(1.0)		

	
	change_face(Vernarth, "Normal") 	
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_340041")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,23,24,0)
    pbadv_setup_101012_Dinatan_preload(1,true,23,26,0)
	pbadv_setup_101052_Vernarth_preload(0,true,27,24,0)
	pbadv_setup_101037_Rasia_preload(0,true,25,25,0)
	pbadv_setup_101039_Fren_preload(0,true,26,23,0)
end
