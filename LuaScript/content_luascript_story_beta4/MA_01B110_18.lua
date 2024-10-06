

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201060001", "201060001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	load_image("MA01B1101801", "content_still_10102004_image", "101020040_StillImage")
	
	
	pbadv_setup_101009_Noir(2,true, 20, 22,0)  
	pbadv_setup_101028_Galahad(1,true, 25, 22,0)  

	pbadv_setup_101036_Viena(0,true, 19, 22,0)  
	pbadv_setup_101036_Viena(1,true, 1, 24,0)  

	pbadv_setup_101034_Excelia(1,true, 29, 22,0)  
	pbadv_setup_101054_Adam(2,true, 28, 27,0)  

	pbadv_setup_101048_Thiten(true, 30, 21,0)  

		
	
	
	
	barbaroi1 = dot_reserve_enemy(600, 27, 21, 0)
	barbaroi2 = dot_reserve_enemy(600, 27, 23, 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotExcelia1, 2)
	dot_unit_dir(dotAdam2, 2)

	
	

	
	
	
	
	dot_disp_unit(dotNoir2, false)
	dot_disp_unit(dotViena, false)
	dot_disp_unit(dotAdam2, false)
	dot_disp_unit(dotViena1, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(40.0, 0.0)

	
	
	move_camera(27, 22, 0.0)
	
	
	Ef_Coat = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	Ef_VibesAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	Ef_KillChan = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_Viena = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	Ef_Gala = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)

	
	dot_move_height(dotThiten, 6.0, 0, 0)

	load_sound("BGM_ADV_Revenge")
	load_sound("BGM_Battle_Nature_Start")

end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	dot_move_fly(dotThiten, 28, 21, 0.5, 1.0, 2)
	wait_time(0.5)
		
	
	change_face(Thiten, "Normal")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01B110_180002")
	close_speech_window()
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180004")
	close_speech_window()
	
	
	change_face(Thiten, "Normal")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01B110_180005")
	close_speech_window()
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180007")
	close_speech_window()
	
	
	change_face(Thiten, "Normal")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01B110_180008")
	
	
	
	change_face(Thiten, "Normal")
	
	message("MA_01B110_180009")
	
	
	
	change_face(Thiten, "Normal")
	
	message("MA_01B110_180011")
	close_speech_window()
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180013")
	close_speech_window()
	
	
	change_face(Thiten, "Smile")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01B110_180014")
	close_speech_window()
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180016")
	close_speech_window()
	
	
	change_face(Thiten, "Smile")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01B110_180017")
	close_speech_window()
	
	
	dot_disp_unit(dotNoir2, true)
	dot_move_unit_seq(dotNoir2, 26, 22)

	wait_seq()

	dot_unit_dir(dotNoir2, 3)

	dot_move_fly(dotThiten, 29, 21, 6.0, 0.2, 2)

	dot_change_anim(dotNoir2, 3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)
	
	dot_change_anim(barbaroi1, 6)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Sla01",2,true)

	dot_change_anim(barbaroi2, 6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",2,true)

	wait_time(0.2)

	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	
	wait_time(0.5)

	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)

	dot_remove_unit(barbaroi1)
	dot_remove_unit(barbaroi2)

	wait_time(0.5)
	
	
	dot_move_height(dotThiten, 1.11, 2.0, 2)

	move_camera(26, 22, 1.0)
	change_camera_distance(6.0, 1.0)
	
	dot_change_anim(dotNoir2, 0)
	dot_unit_dir(dotThiten, 2)

	wait_camera()

	wait_time(0.3)
	
	
	on_active(Ef_Coat) 

	local gridpos = get_grid_position(26, 22)
	set_pos(Ef_Coat, gridpos)
	play_particle(Ef_Coat)
	
	wait_time(1.0)

	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180019")
	close_speech_window()
	
	dot_unit_dir(dotNoir2, 2)

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_180020")
	close_speech_window()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180021")
	close_speech_window()
	

	move_camera(27, 22, 0.5)
	change_camera_distance(8.0, 0.5)
	
	change_face(Thiten, "Normal")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01B110_180022")
	
	wait_camera()
	dot_unit_dir(dotNoir2, 3)	
	
	change_face(Thiten, "Smile")
	
	message("MA_01B110_180024")
	close_speech_window()
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad1, nil)
	message("MA_01B110_180026")
	
	
	
	

  
    MA_01B110_18_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B110_180027", "MA_01B110_180028")  
	close_speech_window()

    if is_select(1) then            
        MA_01B110_18_select1_1()

    else                            
        MA_01B110_18_select1_2()

    end
    MA_01B110_18_end()
 
end
 
function MA_01B110_18_select1()
 
end
 
function MA_01B110_18_select1_1()
 

 
	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_180030")
	close_speech_window()
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180031")
	close_speech_window()
	
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_180032")
	
	
 	
	change_face(Noir2, "Serious")
	
	message("MA_01B110_180038")
	
	
	
      
end
 
 
function MA_01B110_18_select1_2()
 

 
	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_180034")
	close_speech_window()
	
	
	change_face(Thiten, "Normal")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01B110_180035")
	
	
	
	change_face(Thiten, "Smile")
	
	message("MA_01B110_180036")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_180038")
	


 
    
end
 
 
function MA_01B110_18_end()


	
	
	
	change_face(Noir2, "Serious")
	
	message("MA_01B110_180039")
	
	
	
	change_face(Noir2, "Serious")
	
	message("MA_01B110_180040")
	close_speech_window()
	

	
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180042")
	
	
	
	change_face(Galahad1, "Normal")
	
	message("MA_01B110_180043")
	
	
	
	change_face(Galahad1, "Normal")
	
	message("MA_01B110_180044")
	close_speech_window()
	
	
	
	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_180046")
	close_speech_window()

	dot_disp_unit(dotViena, true)
	dot_move_unit_seq(dotViena, 24, 22)	

	move_camera(25, 22, 0.8)

	wait_seq()
	wait_camera()

	dot_unit_dir(dotViena, 3)
	dot_unit_dir(dotGalahad1, 2)


	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_180047")
	close_speech_window()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180048")
	close_speech_window()
	
	move_camera(27, 22, 1.0)

	wait_camera()
	wait_time(0.5)
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_180049")
	
	dot_unit_dir(dotGalahad1, 3)
	
	
	message("MA_01B110_180051")
	
	
	
	change_face(Excelia1, "Anger")
	
	message("MA_01B110_180052")
	close_speech_window()
	
	
	dot_disp_unit(dotAdam2, true)
	dot_unit_dir(dotAdam2, 2)

	dot_move_unit_seq(dotAdam2, 28, 22)
	move_camera(28, 22, 0.5)

	wait_seq()
	dot_unit_dir(dotAdam2, 2)

	wait_camera()

	
	
	
	change_face(Adam2, "Normal")
	open_speech_window("CHRNAME_ADAM",  nil, Adam2)
	message("MA_01B110_180054")
	close_speech_window()
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_180055")
	close_speech_window()
	
	show_image("MA01B1101801", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
	set_scale_image(STILL_SCALE,STILL_SCALE)
	wait_time(STILL_SWITCH_TIME)
	
	scale_to_image(1,1,STILL_MOVE_TIME,2)
	wait_time(STILL_ACTIVE_AFTER)
	
	
	open_simple_window("CHRNAME_EXCELIA2")
	message("MA_01B110_180056")
	close_simple_window()
	
	move_camera(25, 22, 0.0)
	wait_camera()

	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )


		
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180058")
	close_speech_window()
	
	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_180059")
	
	
	
	change_face(Viena, "Smile")
	
	message("MA_01B110_180060")
	close_speech_window()
	
	
	dot_unit_dir(dotGalahad1, 2)

	wait_time(1.0)
	
	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_180062")
	
	bgm_play("Stop_BGM_Bus_MidFade")
	
	change_face(Viena, "Smile")
	
	message("MA_01B110_180063")
	close_speech_window()
	
	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180064")
	close_speech_window()

	bgm_play("BGM_ADV_Revenge")


	dot_unit_dir(dotGalahad1, 3)

	wait_time(0.5)
	
	
	on_active(Ef_Gala) 

	local locatorpos = dot_get_unit_locator(dotGalahad1, 1)
	set_pos(Ef_Gala, locatorpos)
	play_particle(Ef_Gala)
	
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180066")
	close_speech_window()
	
	
	on_active(Ef_Viena) 

	local locatorpos = dot_get_unit_locator(dotViena, 1)
	set_pos(Ef_Viena, locatorpos)
	play_particle(Ef_Viena)
	
	
	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_180068")
	close_speech_window()
	
	bgm_play("BGM_Battle_Nature_Start")
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180080")
	close_speech_window()


	
	open_cutin(2, 1)
	
	on_cutin(1, Galahad1, "Anger", 0)
	on_cutin(2, Viena, "Anger", 0)

	bgm_play("BGM_To_Main")
	
	open_speech_window("CHRNAME_GALAHAD_VIENA", nil, nil)
	message("MA_01B110_180069")
	close_speech_window()

	
	close_cutin()
	
	
	
	on_active(Ef_VibesAura) 
	on_active(Ef_Killers) 

	local gridpos = get_grid_position(25, 22)
	set_pos(Ef_VibesAura, gridpos)
	play_particle(Ef_VibesAura)
	
	
	local gridpos = get_grid_position(24, 22)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	wait_time(1.5)

	on_active(Ef_KillChan)

	local gridpos = get_grid_position(24, 22)
	set_pos(Ef_KillChan, gridpos)
	play_particle(Ef_KillChan)

	wait_time(0.7)
	dot_change_unit(dotViena, dotViena1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Killers)
	stop_particle(Ef_VibesAura)

	
	
	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2",  Viena1, nil)
	message("MA_01B110_180071")
	close_speech_window()

	move_camera(27, 22, 0.5)
	change_camera_distance(8.0, 0.5)
	wait_camera()

		
	
	change_face(Adam2, "Normal")
	open_speech_window("CHRNAME_ADAM",  nil, Adam2)
	message("MA_01B110_180072")
	close_speech_window()
	
	
	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2",  nil, Excelia1)
	message("MA_01B110_180073")
	close_speech_window()
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180074")
	close_speech_window()
	
	
	change_face(Thiten, "Normal")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01B110_180075")
	close_speech_window()
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180076")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_180077")
	close_speech_window()
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_180078")
	
	
	
	change_face(Galahad1, "Anger")
	
	message("MA_01B110_180079")
	close_speech_window()




	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("MA01B1101801", "content_still_10102004_image", "101020040_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 20, 22,0)
	pbadv_setup_101028_Galahad_preload(1,true, 25, 22,0)
	pbadv_setup_101036_Viena_preload(0,true, 19, 22,0)
	pbadv_setup_101036_Viena_preload(1,true, 1, 24,0)
	pbadv_setup_101034_Excelia_preload(1,true, 29, 22,0)
	pbadv_setup_101054_Adam_preload(2,true, 28, 27,0)
	pbadv_setup_101048_Thiten_preload(true, 30, 21,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	preload_sound("BGM_ADV_Revenge")
	preload_sound("BGM_Battle_Nature_Start")
end
