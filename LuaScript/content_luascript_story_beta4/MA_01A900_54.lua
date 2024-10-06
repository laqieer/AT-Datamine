
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201190000", "201190000")
	change_time_and_weather(1,1) 

	
	pbadv_setup_101009_Noir(2,true, 26, 7,0)  
	pbadv_setup_101011_Guinevere(1,true, 26, 3,0)  
	pbadv_setup_101011_Guinevere(0,true, 26, 8,0)  

	ryuu = dot_reserve_ally(201021001, 36,  8, 0)	
	dot_set_weapon(ryuu, 105010001)		
	
	barbaroi1 = dot_reserve_enemy(1, 34, 7, 0)
	barbaroi2 = dot_reserve_enemy(1, 34, 9, 0)	

setup_complete_unit()

	
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_Mana = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_GD_Lop", false, true)
	
	load_image("10103019", "content_still_10103019_image", "101030190_StillImage")

	load_image("101010270", "content_still_10101027_image", "101010270_StillImage")
	
	dot_unit_dir(ryuu, 2)



	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGuinevere1, false)







	
	dot_disp_unit(dotGuinevere1, false)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(40.0, 0.0)
	move_camera(28, 9, 0.0)

	movie_load("MA_01A900_54")


	load_sound("BGM_ADV_Noir_adoption")
	load_sound("BGM_ADV_WhiteDragon_G")
end



function Play()
	fadein(0)
	Play_start(true)

	
	dot_reserve_move_unit_seq(dotNoir2, 28, 7)
	dot_reserve_move_unit_seq(dotGuinevere, 28, 8)
	exec_parallel_seq()
	wait_seq()
		
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_540002")
	
	change_face(Guinevere, "Normal")
	message("MA_01A900_540003")
	
	change_face(Guinevere, "Smile")
	message("MA_01A900_540004")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_540005")
	
	change_face(Noir2, "Normal")
	message("MA_01A900_540006")
	
	change_face(Noir2, "Normal")
	message("MA_01A900_540007")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_540009")
	
	change_face(Guinevere, "Smile")
	message("MA_01A900_540010")
	
	change_face(Guinevere, "Shy")
	message("MA_01A900_540011")


	
    
 
    
    MA_01A900_54_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01A900_540012", "MA_01A900_540013")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01A900_54_select1_1()
 
    elseif is_select(2) then        
        MA_01A900_54_select1_2()
        
    end
    MA_01A900_54_end()
 
end
 
function MA_01A900_54_select1()
 
end
 
function MA_01A900_54_select1_1()
 

 
 
	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotGuinevere, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotNoir2, 1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	wait_time(2.0)

	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(28, 8)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(28, 7)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(28, 8)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)
	dot_change_unit(dotGuinevere, dotGuinevere1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)
	
	wait_time(2.0)

 

fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  

on_cameraframe(2) 
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("101010270", 0.0, 0.0, 0.0) 
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)	
 
	
	bgm_play("Stop_BGM_Bus_MidFade")
	open_simple_window("NPCNAME_0163")
	message("MA_01A900_540015")
	close_simple_window()

	bgm_play("BGM_ADV_Noir_adoption")
 

fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
  

 hide_image()
  

off_cameraframe()
off_screencolor()
 
 
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)    
      
end
 
 
function MA_01A900_54_select1_2()
 

	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotGuinevere, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotNoir2, 1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	wait_time(2.0)

	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(28, 8)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(28, 7)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(28, 8)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)
	dot_change_unit(dotGuinevere, dotGuinevere1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)
	
	wait_time(2.0)
	

fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  

on_cameraframe(2) 
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("101010270", 0.0, 0.0, 0.0) 
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)	
 
	
	bgm_play("Stop_BGM_Bus_MidFade")
	open_simple_window("NPCNAME_0163")
	message("MA_01A900_540015")
	close_simple_window()

	bgm_play("BGM_ADV_Noir_adoption")
 

fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
  

 hide_image()
  

off_cameraframe()
off_screencolor()
 
 
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)    

end
 
 
function MA_01A900_54_end()
 


	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_540016")
	close_speech_window()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_540017")
	close_speech_window()

	
	open_narration_window()
	message("MA_01A900_540018")
	close_narration_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_540019")
	
	change_face(Noir2, "Normal")
	message("MA_01A900_540020")
	close_speech_window()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_540021")
	close_speech_window()
	

	
	open_narration_window()
	message("MA_01A900_540022")
	close_narration_window()
	
	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_540023")
	
	change_face(Guinevere1, "Normal")
	message("MA_01A900_540024")
	
	change_face(Guinevere1, "Normal")
	message("MA_01A900_540025")
	close_speech_window()

	
	open_narration_window()
	message("MA_01A900_540026")
	close_narration_window()

	
	on_active(Ef_Mana)

	local gridpos = get_grid_position(28, 7)
	set_pos(Ef_Mana, gridpos)
	play_particle(Ef_Mana)

		
	wait_time(1.5)
	
	
	dot_disp_weapon(dotGuinevere1, true)
	
		
	wait_time(1.5)

	
	open_narration_window()
	message("MA_01A900_540028")
	close_narration_window()
	
	stop_particle(Ef_Mana)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_540030")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_540032")
	close_speech_window()
	
	
	off_active(Ef_Mana)	
	off_active(Ef_Killers)
	off_active(Ef_Emblem1)
	off_active(Ef_Emblem2)
	off_active(Ef_Vibes)
	off_active(Ef_KillChan1)

	
	movie_set_active(true)
	movie_play()




		
	move_camera(30, 9, 0.0)	

	dot_place_unit(dotNoir2, 30, 7)
	dot_place_unit(dotGuinevere1, 30, 8)


	
	show_image("10103019", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) 


	movie_wait_playing()

	
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)

	
	open_simple_window("CHRNAME_GUINEVERE2")	
	message("MA_01A900_540034")
	close_simple_window()

	
	open_simple_window("CHRNAME_NOIR")	
	message("MA_01A900_540035")
	close_simple_window()

	
	open_simple_window("CHRNAME_GUINEVERE2")	
	message("MA_01A900_540037")
	
	message("MA_01A900_540039")
	
	message("MA_01A900_540041")
	close_simple_window()
	
	wait_time(1.0)
	
	fadeout(255,255,255,1.0, FADE_TIME + 1.0)

	wait_time(TIME_ELAPSED + FADE_TIME)



	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 26, 7,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 26, 3,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 26, 8,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_GD_Lop", false, true)
	load_image_preload("10103019", "content_still_10103019_image", "101030190_StillImage")
	load_image_preload("101010270", "content_still_10101027_image", "101010270_StillImage")
	movie_load_preload("MA_01A900_54")
	preload_sound("BGM_ADV_Noir_adoption")
	preload_sound("BGM_ADV_WhiteDragon_G")
end
