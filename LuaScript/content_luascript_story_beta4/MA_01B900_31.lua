

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(1,1) 
	
	load_image("10203010",  "content_still_10203010_image", "102030100_StillImage")
	show_image("10203010", 0.0, 0.0, 0 ,true,false)
	

	pbadv_setup_101009_Noir(2,true, 7, 26,0)  
	pbadv_setup_101010_Lancelot(3,true, 6, 27,0)  
	
	pbadv_setup_101012_Dinatan(0,true, 7, 25,0)  
	pbadv_setup_101017_Maladisant(0,true, 6, 25,0)  
	
	pbadv_setup_101028_Galahad(1,true, 8, 26,0)  
	pbadv_setup_101036_Viena(0,true, 9, 26,0)  
	
	pbadv_setup_101036_Viena(1,true, 1, 38,0)  

	
	setup_complete_unit()

	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotMaladisant, false)
	dot_disp_weapon(dotGalahad1, false)
	dot_disp_weapon(dotViena, false)
	dot_disp_weapon(dotViena1, false)
	
	dot_disp_unit(dotViena1, false)
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(35.0, 0.0)
	
	
	move_camera(10, 28, 0.0)

	load_image("101010150", "content_still_10101015_image", "101010150_StillImage")

	movie_load("MA_01B900_31")

	Ef_VanishDust = load_particle("content_effect3d_common_adv","Ef_C_Adv_VanishDust", false, true) 

	Ef_Dina = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	Ef_Viena = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	Ef_KillChan = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_Salas = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Salas_Gate", false, true)
	Ef_Salas2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Salas_Cross", false, true)

end





function Play()
	fadein(0)
	Play_start(true)

	
	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)
	
	
	dot_move_unit_seq(dotViena, 11, 27)
	
	wait_seq()
	
	dot_unit_dir(dotViena, 2) 

	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B900_310002")
	
	
	change_face(Viena, "Normal")
	
	message("MA_01B900_310003")
	close_speech_window()

	dot_move_unit_seq(dotGalahad1, 9, 27)
	
	wait_seq()

	dot_disp_weapon(dotGalahad1, false)

	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310004")
	
	
	change_face(Galahad1, "Smile")
	
	message("MA_01B900_310005")
	
	
	change_face(Galahad1, "Smile")
	
	message("MA_01B900_310006")
	close_speech_window()

	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B900_310007")
	close_speech_window()

	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310008")
	

	
	change_face(Galahad1, "Normal")
	
	message("MA_01B900_310010")
	

	
	
	
	change_face(Galahad1, "Normal")
	
	message("MA_01B900_310012")
	

	
	
	change_face(Galahad1, "Sad")
	
	message("MA_01B900_310014")
	close_speech_window()

	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B900_310015")
	close_speech_window()

	
	dot_change_anim(dotGalahad1,1)

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310017")
	close_speech_window()

	
	dot_move_unit_seq(dotViena, 10, 27)
	
	wait_seq()
	
	
	move_camera(8, 27, 1.0)
	wait_camera()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_310019")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310020")
	close_speech_window()
	
	wait_time(0.2)
	se_play("SE_ADV_MA_01A111_14_Earthquake")
	wait_time(4.0)
	
	dot_move_unit_seq(dotNoir2, 7, 28)
	wait_seq()
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_310022")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310023")
	close_speech_window()

	
	dot_change_anim(dotGalahad1,0)
	dot_unit_dir(dotGalahad1, 2) 

	change_camera_distance(7.0, 1.0)
	move_camera(7, 27, 1.0)
	
	wait_camera()
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_310025")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_310026")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_310027")
	

	
	change_face(Noir2, "Sad")
	
	message("MA_01B900_310028")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_310029")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_310030")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_310031")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310032")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_310033")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_310035")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_310036")
	close_speech_window()

	
	
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310038")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_310039")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310040")
	

	
	

    
    MA_01B900_31_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B900_310041", "MA_01B900_310042")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01B900_31_select1_1()

    else                            
        MA_01B900_31_select1_2()

    end
    MA_01B900_31_end()
 
end
 
function MA_01B900_31_select1()
 
end
 
function MA_01B900_31_select1_1()
 

 
	
	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_310044")
	close_speech_window()

	
	change_face(Galahad1, "Shy")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310045")
	

	
	change_face(Galahad1, "Shy")
	
	message("MA_01B900_310046")
	
	
	
	
	dot_move_unit_seq(dotGalahad1, 8, 26)
	
	wait_seq()
	
	
	change_face(Galahad1, "Normal")
	
	message("MA_01B900_310052")
	

	
	change_face(Galahad1, "Smile")
	
	message("MA_01B900_310053")
	close_speech_window()

 
      
end
 
 
function MA_01B900_31_select1_2()
 

 
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_310048")
	close_speech_window()

	
	change_face(Lancelot3, "Smile")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_310049")
	

	
	change_face(Lancelot3, "Smile")
	
	message("MA_01B900_310050")
	close_speech_window()

	
	
	dot_move_unit_seq(dotGalahad1, 8, 26)
	
	wait_seq()


	dot_unit_dir(dotGalahad1, 2) 
	dot_disp_weapon(dotGalahad1, false)

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310052")
	

	
	change_face(Galahad1, "Smile")
	
	message("MA_01B900_310053")
	close_speech_window()

    
end
 
function MA_01B900_31_end()
 




	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B900_310054")
	close_speech_window()

	wait_time(0.3)	

	dot_unit_dir(dotGalahad1, 3) 	

	wait_time(0.5)	

	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B900_310056")
	


	
	change_face(Viena, "Smile")
	
	message("MA_01B900_310058")
	close_speech_window()

	
	
	
	
	wait_time(0.2)
	se_play("SE_ADV_MA_01A111_14_Earthquake")
	wait_time(1.0)
	
	
	
	dot_move_unit_seq(dotViena, 8, 25)

	wait_seq()

	dot_unit_dir(dotGalahad1, 2) 	
	wait_time(0.2)	

	dot_change_anim(dotViena,5)
	dot_change_anim(dotDinatan,5)

	wait_time(0.5)

	

	on_active(Ef_Dina) 
	on_active(Ef_Viena) 

	local gridpos = get_grid_position(7, 25)
	set_pos(Ef_Dina, gridpos)
	play_particle(Ef_Dina)
	
	
	local gridpos = get_grid_position(8, 25)
	set_pos(Ef_Viena, gridpos)
	play_particle(Ef_Viena)

	wait_time(1.5)

	on_active(Ef_KillChan)

	local gridpos = get_grid_position(8, 25)
	set_pos(Ef_KillChan, gridpos)
	play_particle(Ef_KillChan)

	wait_time(0.7)
	dot_change_anim(dotViena1,5)
	dot_unit_dir(dotViena1, 2) 	
	dot_change_unit(dotViena, dotViena1, 0.0)

	wait_time(1.5)

	dot_change_anim(dotViena1,0)
	dot_change_anim(dotDinatan,0)
	stop_particle(Ef_Dina)
	stop_particle(Ef_Viena)

	wait_time(2.0)

	dot_reserve_move_unit_seq(dotViena1, 10, 27)
	dot_reserve_move_unit_seq(dotGalahad1, 9, 27)
	dot_reserve_move_unit_seq(dotNoir2, 9, 26)
	dot_reserve_move_unit_seq(dotLancelot3, 8, 26)
	exec_parallel_seq()

	wait_seq()	

	dot_move_unit_seq(dotMaladisant, 7, 26)
	
	wait_seq()

	dot_unit_dir(dotViena1, 2) 	
	dot_unit_dir(dotNoir2, 2) 	
	dot_unit_dir(dotLancelot3, 2) 	
	dot_unit_dir(dotGalahad1, 2) 	

	wait_time(0.5)

	
	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01B900_310060")
	close_speech_window()

	
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01B900_310061")
	close_speech_window()

	
	move_camera(10, 27, 1.0)
	wait_camera()


	dot_unit_dir(dotViena1, 2) 	
	dot_unit_dir(dotGalahad1, 3) 
	dot_unit_dir(dotNoir2, 3) 	
	dot_unit_dir(dotLancelot3, 3) 	

	wait_camera()
	
	
	change_face(Viena1, "Normal")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B900_310063")
	

	
	change_face(Viena1, "Smile")
	
	message("MA_01B900_310064")
	close_speech_window()

	
	
	dot_disp_weapon(dotGalahad1, true)	
	dot_change_anim(dotGalahad1,12)

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310066")
	

	
	change_face(Galahad1, "Smile")
	
	message("MA_01B900_310067")
	close_speech_window()

	
	
	change_face(Viena1, "Smile")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B900_310069")
	close_speech_window()

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310070")
	

	
	change_face(Galahad1, "Normal")
	
	message("MA_01B900_310071")
	close_speech_window()

	
	change_face(Viena1, "Normal")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B900_310072")
	close_speech_window()

	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_310073")
	close_speech_window()

	close_textbox_base()
	disableTextBox = true
	
	dot_attack_seq(dotGalahad1,dotViena1)
	dot_damage_seq(dotViena1,dotGalahad1,false)

	wait_seq()
	
	dot_change_anim(dotGalahad1,0)
	dot_change_anim(dotViena1,1)

	wait_time(1.0)

	on_active(Ef_VanishDust) 

	local gridpos = get_grid_position(10, 27)
	set_pos(Ef_VanishDust, gridpos)
	play_particle(Ef_VanishDust)
	
	on_active(Ef_Salas) 
	on_active(Ef_Salas2) 

	local gridpos = get_grid_position(10, 27)
	set_pos(Ef_Salas, gridpos)
	play_particle(Ef_Salas)

	wait_time(2.0)
	
	local gridpos = get_grid_position(10, 27)
	set_pos(Ef_Salas2, gridpos)
	play_particle(Ef_Salas2)

	wait_time(1.0)


	off_active(Ef_Viena)
	off_active(Ef_KillChan)

	fadeout(255,255,255,1.0, FADE_TIME)
	wait_time(FADE_TIME)	

	show_image("101010150", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	movie_set_active(true)
	movie_play()



	movie_wait_playing()
	movie_stop()
	wait_time(MOVIE_AFTER)
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10203010",  "content_still_10203010_image", "102030100_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 7, 26,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 6, 27,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 7, 25,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 6, 25,0)
	pbadv_setup_101028_Galahad_preload(1,true, 8, 26,0)
	pbadv_setup_101036_Viena_preload(0,true, 9, 26,0)
	pbadv_setup_101036_Viena_preload(1,true, 1, 38,0)
	load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	movie_load_preload("MA_01B900_31")
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VanishDust", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Salas_Gate", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Salas_Cross", false, true)
end
