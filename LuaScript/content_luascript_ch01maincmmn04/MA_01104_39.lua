

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	init_psbattleadv("201210000", "25010201")
	change_time_and_weather(BattleTime_Sunset,BattleWeather_Shiny)
	
	
	pbadv_setup_101017_Maladisant(0,true, 19, 3,0) 	
	pbadv_setup_101012_Dinatan(0,true, 20, 3,0)  	
	
	pbadv_setup_101009_Noir(2,true, 17, 8,0)  
	pbadv_setup_101001_Tyrfing(2,true, 16, 8,0)  
	
	pbadv_setup_101019_Isolde(0,true, 23, 18,0)  
	pbadv_setup_101014_Tristan(0,true, 22, 18,0)  

	Cal = dot_reserve_facility(52, 20, 0, DotDir_Down, 1, true)		
	
	
	setup_complete_unit()

	dot_unit_dir(dotIsolde, 2)	
	dot_unit_dir(dotTristan, 2)			

	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotMaladisant,false)
	dot_disp_weapon(dotDinatan,false)	
	dot_disp_weapon(dotTyrfing2,false)		
	dot_disp_weapon(dotIsolde,false)	
	dot_disp_weapon(dotTristan,false)		
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(20, 4, 0.0)

	dot_disp_facility(Cal,true)
	
	Ef_Emblem01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	EfAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)	
	
end

function Play()
	fadein(0)
	Play_start(true)

	wait_time(1.0)
	
	move_camera(17, 8, 1.5)	
	wait_time(1.7)	
	
	dot_unit_dir(dotNoir2, 2)	

	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	message("MA_01104_390002")
	change_face(Tyrfing2, "Normal")	
	message("MA_01104_390003")	
	change_face(Tyrfing2, "Normal")
	message("MA_01104_390004")
	close_speech_window()	
	
	move_camera(20, 2, 1.2)	
	wait_time(1.5)		
	
	
	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)	
	message("MA_01104_390006")
	close_speech_window()
	
	move_camera(17, 8, 1.5)	
	wait_time(1.7)		
	
	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)	
	message("MA_01104_390008")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_390009")
	change_face(Noir2, "Normal")
	message("MA_01104_390010")
	close_speech_window()		
	
	change_face(Tyrfing2, "Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	message("MA_01104_390012")
	close_speech_window()	
	
	
	move_camera(20, 2, 1.5)	
	wait_time(1.7)		
	
	dot_reserve_move_unit_seq(dotDinatan, 20, 1)
	exec_parallel_seq()
	wait_seq()	

	wait_time(0.3)			
		
	dot_unit_dir(dotDinatan, 2)			
	
	change_face(Maladisant, "Normal")	
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01104_390014")
	close_speech_window()	
 
	wait_time(0.7)		
	
	dot_change_anim(dotDinatan, 3)		
 	dot_unit_dir(dotDinatan, 0)	
	
	wait_time(0.5)		
	
	
open_cutin(1,1)

on_cutin(1,Dinatan,"Anger") 

	open_speech_window("CHRNAME_DINATAN", nil, nil)
	message("MA_01104_390016")
	close_speech_window()


close_cutin()	
	


	change_face(Maladisant, "Normal")	
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01104_390018")
	close_speech_window()		
	
open_cutin(1,1)

on_cutin(1,Dinatan,"Anger") 


	open_speech_window("CHRNAME_DINATAN", nil, nil)
	message("MA_01104_390019")	
	close_speech_window()	


close_cutin()		
	
	wait_time(0.5)				
	
	dot_reserve_move_unit_seq(dotMaladisant, 19, 1)
	exec_parallel_seq()
	wait_seq()	
	
	wait_time(0.5)		
	
	dot_unit_dir(dotMaladisant, 2)		

	wait_time(0.5)	
	
	dot_change_anim(dotDinatan, 0)		
	dot_unit_dir(dotDinatan, 2)		

	wait_time(1.0)		
		
	
	change_face(Dinatan, "Smile")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)	
	message("MA_01104_390021")
	close_speech_window()		
	
	change_face(Maladisant, "Shy")	
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01104_390023")
	close_speech_window()

	wait_time(0.3)		
	
 	dot_unit_dir(dotDinatan, 0)
	dot_change_anim(dotDinatan, 3)	
	
	wait_time(0.3)	
	
	
open_cutin(1,1)

on_cutin(1,Dinatan,"Anger") 

	open_speech_window("CHRNAME_DINATAN", nil, nil)
	message("MA_01104_390025")
	close_speech_window()	


close_cutin()		

	
	wait_time(0.5)
	on_active(EfAura)

	
	local locatorpos = dot_get_unit_locator(dotDinatan,2)
	set_pos(EfAura, locatorpos)

	
	play_particle(EfAura)

	wait_time(1.5)

	stop_particle(EfAura)

	wait_time(3.5)	
	
	
	on_active(Ef_Emblem01)

	
	local locatorpos = dot_get_unit_locator(dotDinatan,1)
	set_pos(Ef_Emblem01, locatorpos)

	
	play_particle(Ef_Emblem01)

	wait_time(1.5)

	stop_particle(Ef_Emblem01)

	wait_time(2.5)

	dot_change_anim(dotDinatan, 0)
	dot_unit_dir(dotDinatan, 2)	
	dot_unit_dir(dotMaladisant, 3)	

	wait_time(1.0)

	change_face(Maladisant, "Normal")	
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01104_390027")
	close_speech_window()

	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_390028")
	close_speech_window()

	change_face(Maladisant, "Normal")	
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01104_390029")
	close_speech_window()
	
	move_camera(20, 4, 1.0)		
	
	dot_reserve_move_unit_seq(dotNoir2, 20, 4)
	dot_reserve_move_unit_seq(dotTyrfing2, 19, 4)
	exec_parallel_seq()
	wait_seq()	

	wait_time(0.7)		

    MA_01104_39_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01104_390030", "MA_01104_390031", "MA_01104_390032")  
 
    if is_select(1) then            
        MA_01104_39_select1_1()
 
    elseif is_select(2) then        
        MA_01104_39_select1_2()
 
    elseif is_select(3) then        
        MA_01104_39_select1_3()
 
    end
    MA_01104_39_end()

 
end
 
function MA_01104_39_select1()
 
end
 
function MA_01104_39_select1_1()
 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_390034")
	close_speech_window()

	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_390035")
	close_speech_window()

	change_face(Maladisant, "Smile")	
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01104_390036")
	close_speech_window()

 
      
end
 
 
function MA_01104_39_select1_2()
 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_390038")
	close_speech_window()

	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_390039")

	change_face(Dinatan, "Sad")
	message("MA_01104_390040")
	close_speech_window()
    
end
 
 
function MA_01104_39_select1_3()
 
     
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_390042")
	close_speech_window()

	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_390043")

	change_face(Dinatan, "Normal")	
	message("MA_01104_390044")
	close_speech_window()
 
        
end
 
 
function MA_01104_39_end()

	move_camera(20, 2, 1.0)		

	wait_time(1.7)		
	

	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)	
	message("MA_01104_390046")

	change_face(Dinatan, "Sad")
	message("MA_01104_390047")

	change_face(Dinatan, "Sad")
	message("MA_01104_390048")

	change_face(Dinatan, "Normal")
	message("MA_01104_390049")

	change_face(Dinatan, "Normal")
	message("MA_01104_390050")

	change_face(Dinatan, "Anger")
	message("MA_01104_390052")
	close_speech_window()
	
	move_camera(20, 18, 2.5)

	wait_time(3.3)		
	

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end
function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101017_Maladisant_preload(0,true, 19, 3,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 20, 3,0)
	pbadv_setup_101009_Noir_preload(2,true, 17, 8,0)
	pbadv_setup_101001_Tyrfing_preload(2,true, 16, 8,0)
	pbadv_setup_101019_Isolde_preload(0,true, 23, 18,0)
	pbadv_setup_101014_Tristan_preload(0,true, 22, 18,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
end
