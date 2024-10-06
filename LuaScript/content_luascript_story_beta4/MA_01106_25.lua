
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(BattleTime_Sunset,BattleWeather_Cloudy) 

	
	pbadv_setup_101009_Noir(2,true, 24, 26,0)  
	pbadv_setup_101001_Tyrfing(0,true, 24, 25,0)  
	pbadv_setup_101012_Dinatan(0,true, 23, 27,0)
	pbadv_setup_101017_Maladisant(0,true, 23, 26,0)  
	pbadv_setup_101014_Tristan(0,true, 23, 24,0)  
	pbadv_setup_101013_Gawain(0,true, 24, 27,0)  
	pbadv_setup_101018_Ragnar(0,true, 22, 26,0)  
	pbadv_setup_101011_Guinevere(0,true, 22, 24,0)  
	pbadv_setup_101016_Gwenhwymawr(0,true, 21, 26,0)  
	pbadv_setup_101015_Arthur(0,true, 21, 24,0)  
	pbadv_setup_101019_Isolde(0,true, 22, 27,0)  
		
	pbadv_setup_101050_Brian(0,true,30, 26,0)
	
	
	roguresu1 = dot_reserve_ally(401038001, 31, 25, 0)
	dot_set_weapon(roguresu1, 102010001)		
	roguresu2 = dot_reserve_ally(401038001, 31, 27, 0)
	dot_set_weapon(roguresu2, 102010001)		

setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotTyrfing, 3)
	dot_unit_dir(dotDinatan, 3)
	dot_unit_dir(dotMaladisant, 3)
	dot_unit_dir(dotTristan, 3)
	dot_unit_dir(dotGawain, 3)
	dot_unit_dir(dotRagnar, 3)
	dot_unit_dir(dotGuinevere, 3)
	dot_unit_dir(dotGwenhwymawr, 3)
	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotIsolde, 3)
	dot_unit_dir(dotBrian, 2)
	
	
	dot_disp_weapon(dotNoir2, false)	
	dot_disp_weapon(dotTyrfing, false)	
	dot_disp_weapon(dotDinatan, false)	
	dot_disp_weapon(dotMaladisant, false)	
	dot_disp_weapon(dotTristan, false)	
	dot_disp_weapon(dotGawain, false)	
	dot_disp_weapon(dotRagnar, false)
	dot_disp_weapon(dotGuinevere, false)	
	dot_disp_weapon(dotGwenhwymawr, false)
	dot_disp_weapon(dotArthur, false)	
	dot_disp_weapon(dotBrian, false)
	dot_disp_weapon(roguresu1, false)
	dot_disp_weapon(roguresu2, false)
	
	dot_disp_unit(dotBrian, false)
	dot_disp_unit(roguresu1, false)
	dot_disp_unit(roguresu2, false)	

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(23, 27, 0.0)
	
	load_image("10201005", "content_still_10201005_image", "102010050_StillImage")

	load_sound("BGM_ADV_Brian")
end



function Play()
	fadein(0)
	Play_start(true)
	
	wait_time(0.5)	

	show_image("10201005", 0.0, 0.0, 0.6,false,false)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)


	change_face(Gawain, "Normal") 
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_250002")	

	change_face(Gawain, "Normal") 
	message("MA_01106_250003")
	close_speech_window()	


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_250004")

	change_face(Noir2, "Normal")
	message("MA_01106_250005")

	change_face(Noir2, "Normal")
	message("MA_01106_250006")
	close_speech_window()	
	

	change_face(Gawain, "Normal") 
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_250007")	
	close_speech_window()	
	
	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )

	bgm_play("Stop_BGM_Bus_2")

	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01106_250009")
	close_speech_window()	

	


	move_camera(25, 27, 0.7)

	dot_disp_unit(roguresu1, true)
	dot_disp_unit(roguresu2, true)
	dot_disp_unit(dotBrian, true)
	
	dot_reserve_move_unit_seq(dotBrian, 26, 26)
	dot_reserve_move_unit_seq(roguresu1, 27, 25)
	dot_reserve_move_unit_seq(roguresu2, 27, 27)
	exec_parallel_seq()
	wait_seq()
	
	
	dot_unit_dir(dotBrian, 2)
	dot_unit_dir(roguresu1, 2)
	dot_unit_dir(roguresu2, 2)
	
	
	wait_time(1.0)	
	

	bgm_play("BGM_ADV_Brian")

	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_250011")	

	change_face(Brian, "Normal") 
	message("MA_01106_250012")

	change_face(Brian, "Normal") 
	message("MA_01106_250013")
	close_speech_window()	


	change_face(Tristan, "Anger")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01106_250014")
	close_speech_window()


	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_250015")
	close_speech_window()


	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_250017")	

	change_face(Brian, "Normal") 
	message("MA_01106_250019")
	close_speech_window()	


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_250020")
	close_speech_window()


	change_face(Brian, "Anger") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_250021")	

	change_face(Brian, "Normal") 
	message("MA_01106_250022")
	close_speech_window()	


	change_face(Tristan, "Anger")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01106_250023")




 
    
    MA_01106_25_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01106_250025", "MA_01106_250026")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01106_25_select1_1()
 
    elseif is_select(2) then        
        MA_01106_25_select1_2()
 
    end
    MA_01106_25_end()
 
end
 
function MA_01106_25_select1()
 
end
 
function MA_01106_25_select1_1()
 


 

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_250028")
	close_speech_window()
 

	change_face(Brian, "Normal") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_250029")	

	change_face(Brian, "Normal") 
	message("MA_01106_250030")
	close_speech_window()	

 
      
end
 
 
function MA_01106_25_select1_2()
 

 

	change_face(Noir2, "Normal") 
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_250032")	

	change_face(Noir2, "Normal") 
	message("MA_01106_250033")
	close_speech_window()	


	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_250034")
	close_speech_window()

 
    
end
 
function MA_01106_25_end()





	
	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotTyrfing, true)
	dot_disp_weapon(dotDinatan, true)
	dot_disp_weapon(dotMaladisant, true)
	dot_disp_weapon(dotTristan, true)
	dot_disp_weapon(dotGawain, true)
	dot_disp_weapon(dotRagnar, true)
	dot_disp_weapon(dotGuinevere, true)
	dot_disp_weapon(dotGwenhwymawr, true)
	dot_disp_weapon(dotArthur, true)
	dot_disp_weapon(dotBrian, true)
	dot_disp_unit(dotBrian, true)
	dot_disp_unit(roguresu1, true)
	dot_disp_unit(roguresu2, true)

	
	wait_time(0.5)	
	
	dot_change_anim(dotNoir2, 12)	
	
	
	wait_time(0.5)	


	change_face(Brian, "Anger") 
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_250036")
	close_speech_window()	

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 24, 26,0)
	pbadv_setup_101001_Tyrfing_preload(0,true, 24, 25,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 23, 27,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 23, 26,0)
	pbadv_setup_101014_Tristan_preload(0,true, 23, 24,0)
	pbadv_setup_101013_Gawain_preload(0,true, 24, 27,0)
	pbadv_setup_101018_Ragnar_preload(0,true, 22, 26,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 22, 24,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true, 21, 26,0)
	pbadv_setup_101015_Arthur_preload(0,true, 21, 24,0)
	pbadv_setup_101019_Isolde_preload(0,true, 22, 27,0)
	pbadv_setup_101050_Brian_preload(0,true,30, 26,0)
	load_image_preload("10201005", "content_still_10201005_image", "102010050_StillImage")
	preload_sound("BGM_ADV_Brian")
end
