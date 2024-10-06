

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201050000", "201050000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 14, 15,0)  
	
	pbadv_setup_101036_Viena(0,true, 13, 14,0)  
	pbadv_setup_101036_Viena(1,true, 1, 32,0)  
	
	pbadv_setup_101028_Galahad(1,true, 19, 14,0)  
	
	pbadv_setup_101035_Liliana(1,true, 23, 15,0)  
	pbadv_setup_101053_Mathajim(2,true, 27, 15,0)  

	pbadv_setup_101049_Thiton(true, 24, 14,0)  
	
	
	
	
	barbaroi = dot_reserve_enemy(42, 22, 14, 0)
	barbaroi2 = dot_reserve_enemy(42, 22, 15, 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	dot_unit_dir(dotLiliana1, 2)
	dot_unit_dir(dotMathajim2, 2)

	
	dot_disp_unit(dotMathajim2, false)
	dot_disp_unit(dotNoir2, false)
	dot_disp_unit(dotViena, false)
	dot_disp_unit(dotViena1, false)
	
	
	
	
	change_camera_distance(7.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(21, 15, 0.0)

	
	Ef_Coat = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	Ef_VibesAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	Ef_KillChan = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_Viena = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	Ef_Gala = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)

	
	dot_move_height(dotThiton, 6.0, 0, 0)

	load_sound("BGM_ADV_Revenge")
	load_sound("BGM_Battle_AfterLancelot_General2_Start")

end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	
	dot_move_fly(dotThiton, 23, 14, 0.11, 1.0, 2)
	wait_time(1.0)

	
	
	
	change_face(Thiton, "Smile")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310002")
	close_speech_window()

	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310003")
	close_speech_window()

	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310005")
	close_speech_window()
	
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310006")
	

	
	change_face(Galahad1, "Normal")
	
	message("MA_01B110_310007")
	

	
	change_face(Galahad1, "Normal")
	
	message("MA_01B110_310008")
	close_speech_window()

	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310009")
	
	
	

	
	change_face(Thiton, "Normal")
	
	message("MA_01B110_310011")
	
	
	
	change_face(Thiton, "Smile")
	
	message("MA_01B110_310012")
	close_speech_window()

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310013")
	close_speech_window()

	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310014")
	
	
	
	change_face(Thiton, "Normal")
	
	message("MA_01B110_310015")
	close_speech_window()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310016")
	close_speech_window()

	
	change_face(Thiton, "Smile")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310017")
	close_speech_window()
	
	bgm_play("Stop_BGM_Bus_2")

	
	dot_disp_unit(dotNoir2, true)
	dot_move_unit_seq(dotNoir2, 15, 15)
	dot_move_unit_seq(dotNoir2, 16, 15)
	dot_move_unit_seq(dotNoir2, 17, 15)
	dot_move_unit_seq(dotNoir2, 18, 15)
	dot_move_unit_seq(dotNoir2, 19, 15)
	dot_move_unit_seq(dotNoir2, 20, 15)
	wait_seq()

	dot_unit_dir(dotNoir2, 3)

	dot_move_fly(dotThiton, 24, 14, 6.0, 0.2, 2)

	dot_change_anim(dotNoir2, 3)

	wait_time(0.1)

	dot_change_anim(barbaroi, 6)
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_N_Hit_Sla01",3,true)

	dot_change_anim(barbaroi2, 6)
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_N_Hit_Sla01",3,true)

	wait_time(0.2)

	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	
	wait_time(0.5)

	dot_disp_unit(barbaroi, false)
	dot_disp_unit(barbaroi2, false)

	dot_remove_unit(barbaroi)
	dot_remove_unit(barbaroi2)

	wait_time(0.5)

	
	move_camera(22, 16, 1.0)
	change_camera_distance(8.0, 1.0)

	dot_move_fly(dotThiton, 25, 14, 0.11, 1.0, 2)
	dot_change_anim(dotNoir2, 0)
	wait_time(0.5)

	wait_camera()

	wait_time(0.3)
	
	
	on_active(Ef_Coat) 

	local gridpos = get_grid_position(20, 15)
	set_pos(Ef_Coat, gridpos)
	play_particle(Ef_Coat)
	
	wait_time(1.0)

	bgm_play("BGM_ADV_Revenge")
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310019")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_310020")
	close_speech_window()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310021")
	close_speech_window()

	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310022")
	

	
	change_face(Thiton, "Normal")
	
	message("MA_01B110_310024")
	close_speech_window()

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad1, nil)
	message("MA_01B110_310026")
	
	
	
	
	

  
    MA_01B110_31_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B110_310027", "MA_01B110_310028")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01B110_31_select1_1()

    else                            
        MA_01B110_31_select1_2()

    end
    MA_01B110_31_end()
 
end
 
function MA_01B110_31_select1()
 
end
 
function MA_01B110_31_select1_1()
 

 
	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_310030")
	close_speech_window()
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310031")
	close_speech_window()
	
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_310032")
	
	
 	
	change_face(Noir2, "Serious")
	
	message("MA_01B110_310038")
	
	
	
      
end
 
 
function MA_01B110_31_select1_2()
 

 
	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_310034")
	close_speech_window()
	
	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310035")
	

	
	change_face(Thiton, "Smile")
	
	message("MA_01B110_310036")
	close_speech_window()


	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_310038")
	


 
    
end
 
 
function MA_01B110_31_end()


	
	
	
	change_face(Noir2, "Serious")
	
	message("MA_01B110_310039")
	
	
	
	change_face(Noir2, "Serious")
	
	message("MA_01B110_310040")
	close_speech_window()
	

	
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310042")
	
	
	
	change_face(Galahad1, "Normal")
	
	message("MA_01B110_310043")
	
	
	
	change_face(Galahad1, "Normal")
	
	message("MA_01B110_310044")
	close_speech_window()
	
	
	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_310046")
	close_speech_window()

	move_camera(19, 16, 1.0)

	dot_unit_dir(dotGalahad1, 2)
	dot_disp_unit(dotViena, true)
	dot_move_unit_seq(dotViena, 14, 14)
	dot_move_unit_seq(dotViena, 15, 14)
	dot_move_unit_seq(dotViena, 16, 14)
	dot_move_unit_seq(dotViena, 17, 14)
	dot_move_unit_seq(dotViena, 18, 14)
	wait_seq()
	wait_camera()

		
	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_310047")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310048")
	close_speech_window()

	move_camera(21, 16, 1.0)
	
	change_face(Liliana1, "Sad")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_310049")
	close_speech_window()
	
	
	
	
	dot_unit_dir(dotGalahad1, 3)

	wait_time(1.5)
	wait_camera()
		
	
	change_face(Liliana1, "Anger")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_310051")
	

	
	change_face(Liliana1, "Anger")
	
	message("MA_01B110_310052")
	close_speech_window()

	
	dot_unit_dir(dotMathajim2, 2)
	dot_disp_unit(dotMathajim2, true)
	dot_move_unit_seq(dotMathajim2, 26, 15)
	dot_move_unit_seq(dotMathajim2, 25, 15)
	dot_move_unit_seq(dotMathajim2, 24, 15)
	dot_move_unit_seq(dotMathajim2, 23, 15)
	dot_move_unit_seq(dotMathajim2, 22, 15)

	change_camera_distance(5.0, 0.5)
	move_camera(22, 16, 0.5)

	wait_camera()
	wait_seq()

	
	
	change_face(Mathajim2, "Normal")
	open_speech_window("CHRNAME_MATHAJIM",  nil, Mathajim2)
	message("MA_01B110_310054")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_310055")
	close_speech_window()

	
	change_face(Liliana1, "Normal")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_310056")
	close_speech_window()

	move_camera(19, 15, 1.0)

	wait_camera()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310058")
	close_speech_window()
	
	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_310059")
	
	
	
	change_face(Viena, "Smile")
	
	message("MA_01B110_310060")
	close_speech_window()
	
	
	dot_unit_dir(dotGalahad1, 2)
	wait_time(1.0)
	
	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_310062")
	
	
	
	change_face(Viena, "Smile")
	
	message("MA_01B110_310063")
	close_speech_window()
	
	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310064")
	
	bgm_play("Stop_BGM_Bus_MidFade")

	dot_unit_dir(dotGalahad1, 3)

	wait_time(0.5)
	
	
	on_active(Ef_Gala) 

	local locatorpos = dot_get_unit_locator(dotGalahad1, 1)
	set_pos(Ef_Gala, locatorpos)
	play_particle(Ef_Gala)
	
	
	change_face(Galahad1, "Anger")
	
	message("MA_01B110_310066")
	close_speech_window()
	
	
	on_active(Ef_Viena) 

	local locatorpos = dot_get_unit_locator(dotViena, 1)
	set_pos(Ef_Viena, locatorpos)
	play_particle(Ef_Viena)
	
	
	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_310068")
	close_speech_window()
	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310069")
	close_speech_window()

	
	
	open_cutin(2, 1)
	
	on_cutin(1, Galahad1, "Anger", 0)
	on_cutin(2, Viena, "Anger", 0)

	bgm_play("BGM_Battle_AfterLancelot_General2_Start")
	
	open_speech_window("CHRNAME_GALAHAD_VIENA", nil, nil)
	message("MA_01B110_310084")
	close_speech_window()

	
	close_cutin()
	
	
	on_active(Ef_VibesAura) 
	on_active(Ef_Killers) 

	local gridpos = get_grid_position(19, 14)
	set_pos(Ef_VibesAura, gridpos)
	play_particle(Ef_VibesAura)
	
	
	local gridpos = get_grid_position(18, 14)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	wait_time(1.5)

	on_active(Ef_KillChan)

	local gridpos = get_grid_position(18, 14)
	set_pos(Ef_KillChan, gridpos)
	play_particle(Ef_KillChan)

	wait_time(0.7)
	dot_change_unit(dotViena, dotViena1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Killers)
	stop_particle(Ef_VibesAura)

	bgm_play("BGM_To_Main")
	
	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2",  Viena1, nil)
	message("MA_01B110_310071")
	close_speech_window()

	move_camera(21, 15, 0.5)
	change_camera_distance(8.0, 0.5)
	wait_camera()

	
	change_face(Mathajim2, "Normal")
	open_speech_window("CHRNAME_MATHAJIM",  nil, Mathajim2)
	message("MA_01B110_310072")
	close_speech_window()

	
	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2",  Viena1, nil)
	message("MA_01B110_310073")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310074")
	close_speech_window()
	
	dot_move_unit_seq(dotThiton, 23, 14)
	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310075")
	close_speech_window()

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310076")
	close_speech_window()

	
	change_face(Liliana1, "Normal")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_310077")
	close_speech_window()

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310078")
	close_speech_window()

	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_310079")
	close_speech_window()

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310080")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_310081")
	close_speech_window()
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_310082")
	
	
	
	change_face(Galahad1, "Anger")
	
	message("MA_01B110_310083")
	close_speech_window()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 14, 15,0)
	pbadv_setup_101036_Viena_preload(0,true, 13, 14,0)
	pbadv_setup_101036_Viena_preload(1,true, 1, 32,0)
	pbadv_setup_101028_Galahad_preload(1,true, 19, 14,0)
	pbadv_setup_101035_Liliana_preload(1,true, 23, 15,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 27, 15,0)
	pbadv_setup_101049_Thiton_preload(true, 24, 14,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	preload_sound("BGM_ADV_Revenge")
	preload_sound("BGM_Battle_AfterLancelot_General2_Start")
end
