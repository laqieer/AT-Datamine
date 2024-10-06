
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201150000", "201150000")
	
	
	change_time_and_weather(4, 4)

	
	pbadv_setup_101009_Noir(2,true, 18, 22,0)  
	pbadv_setup_101011_Guinevere(1,true, 18, 21,0)  
	pbadv_setup_101051_Lucius(2,true, 22, 22,0)  
	pbadv_setup_101001_Tyrfing(1,true, 17, 23,0)  
	pbadv_setup_101038_Lola(2,true, 21, 21,0) 
	pbadv_setup_101039_Fren(2,true, 21, 23,0) 
	
	pbadv_setup_101010_Lancelot(3,true, 15, 20,0)  
	pbadv_setup_101015_Arthur(0,true, 15, 22,0)  
	pbadv_setup_101012_Dinatan(0,true, 15, 23,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 15, 21,0)  
	pbadv_setup_101017_Maladisant(1,true, 15, 24,0)  

	ryuu = dot_reserve_ally(201021001, 24,  20, 0)	
	dot_set_weapon(ryuu, 105010001)		
	
	barbaroi1 = dot_reserve_enemy(1, 23, 20, 0)
	barbaroi2 = dot_reserve_enemy(1, 27, 20, 0)
	barbaroi3 = dot_reserve_enemy(1, 23, 24, 0)
	barbaroi4 = dot_reserve_enemy(1, 27, 24, 0)

setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotGuinevere1, 3)
	dot_unit_dir(ryuu, 2)
	dot_unit_dir(dotLucius2, 2)
	dot_unit_dir(dotLola2, 2)
	dot_unit_dir(dotFren2, 2)

	
	dot_change_anim(dotLola2,1)
	dot_change_anim(dotFren2,1)


	
	
	dot_disp_unit(dotTyrfing1, false)
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)	
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)		
	
	dot_change_anim(ryuu,1)
	
	
	Ef_BriB = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)	
	


	
	Ef_Shougeki = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Shockwave02", false, true)
	

	
	Ef_baruba1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_spout = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_spout2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_Flash = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)

	Ef_Sword = load_particle("content_effect3d_common_adv", "Ef_C_Adv_LightSword", false, true) 
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(23, 22, 0.0)

	load_sound("BGM_Battle_IllusionWar_Start")
	
	movie_load("MA_01A900_46")

	movie_set_active(true)
	movie_play()


end



function Play()
	fadein(0)
	Play_start(true)
	
	movie_wait_playing()
	movie_set_active(false)

	movie_stop()

	on_active(Ef_Sword)
	--local locatorpos = dot_get_unit_locator(ryuu, 1)
	--set_pos(Ef_Sword, locatorpos)
	local gridpos = get_grid_position(25, 22)
	gridpos[2] = 1.5
	set_pos(Ef_Sword, gridpos)
	set_scale(Ef_Sword, {2.5, 2.5, 2.5}) 
	play_particle(Ef_Sword)


	wait_time(MOVIE_AFTER)


	
	change_face(Lucius2, "Pain")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_460019")
	close_speech_window()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_460020")
	close_speech_window()

	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_460021")
	close_speech_window()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_460022")


    
    
    
 
    
    MA_01A900_46_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01A900_460024", "MA_01A900_460025", "MA_01A900_460026")  
    close_speech_window()
 
    if is_select(1) then            
        MA_01A900_46_select1_1()
 
    elseif is_select(2) then        
        MA_01A900_46_select1_2()
 
    elseif is_select(3) then        
        MA_01A900_46_select1_3()
 
    end
    MA_01A900_46_end()

 
end
 
function MA_01A900_46_select1()
 
end
 
function MA_01A900_46_select1_1()
 

 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_460028")
	close_speech_window()

	
	change_face(Guinevere1, "Smile")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_460029")
	close_speech_window()

	
	change_face(Lucius2, "Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_460031")
	bgm_play("BGM_Battle_IllusionWar_Start")
	
	change_face(Lucius2, "Normal")
	message("MA_01A900_460045")
	close_speech_window()
 
      
end
 
 
function MA_01A900_46_select1_2()
 


 	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_460033")
	close_speech_window()

	
	change_face(Guinevere1, "Smile")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_460035")
	close_speech_window()

	
	change_face(Lucius2, "Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_460037")
	bgm_play("BGM_Battle_IllusionWar_Start")
	
	change_face(Lucius2, "Normal")
	message("MA_01A900_460045")
	close_speech_window()
 
    
end
 
 
function MA_01A900_46_select1_3()
 

     
 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_460039")
	close_speech_window()

	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_460040")
	
	change_face(Lucius2, "Normal")
	message("MA_01A900_460041")
	
	change_face(Lucius2, "Smile")
	message("MA_01A900_460043")
	bgm_play("BGM_Battle_IllusionWar_Start")
	
	change_face(Lucius2, "Normal")
	message("MA_01A900_460045")
	close_speech_window()
 
 
        
end
 
 
function MA_01A900_46_end()
 

	dot_unit_dir(dotLucius2, 3)
	
	
	move_camera(25, 21, 0.6)	
	
	wait_time(0.8)	
	
	


	local gridpos = get_grid_position(22, 22)
	set_pos(Ef_spout, gridpos)

	on_active(Ef_spout)
	play_particle(Ef_spout)

	wait_time(1.5)

	
	gridpos[2] = 1.8

	slidemove(Ef_spout, gridpos, 0.8)
	dot_move_height(dotLucius2,2,0.8,2)
	wait_time(1.8)
	
	se_play("SE_ADV_MA_01A900_46_WhiteDrg_Fusion")
	
	local gridpos = get_grid_position(22, 22)
	gridpos[2] = 1.8 
	set_pos(Ef_Flash, gridpos)

	on_active(Ef_Flash)
	
	play_particle(Ef_Flash)
	set_scale(Ef_Flash, {1.5, 1.5, 1.5})
	stop_particle(Ef_spout)

	wait_time(0.5)
	dot_change_anim(ryuu,0)
	dot_remove_unit(dotLucius2)
	off_active(Ef_Sword)

	
	local gridpos = get_grid_position(25, 22)
	set_pos(Ef_spout2, gridpos)

	on_active(Ef_spout2)
	play_particle(Ef_spout2)
	set_scale(Ef_spout2, {1.5, 1.5, 1.5})
	wait_time(2)



	




	
	dot_disp_unit(dotLucius2, false)
	wait_time(1.0)	

	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_460047")
	
	change_face(Lucius2, "Normal")
	message("MA_01A900_460048")
	close_speech_window()
	
	
	move_camera(25, 22, 0.6)
	wait_camera()
	
	
	
	dot_change_anim(ryuu,3)
	wait_time(0.5)
	
	se_play("SE_ADV_MA_01A900_36_WhiteDrg_Roar")

	on_active(Ef_BriB )
	local gridpos = get_grid_position(25,22)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )
	wait_time(1.0)		
	
	dot_change_anim(ryuu,0)
	
	
	
	on_active(Ef_baruba1)
	local gridpos = get_grid_position(23,20)
	set_pos(Ef_baruba1 , gridpos)
    set_scale(Ef_baruba1, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba1 )
	on_active(Ef_baruba2 )
	local gridpos = get_grid_position(27,20)
	set_pos(Ef_baruba2 , gridpos)
    set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2 )	
	on_active(Ef_baruba3 )
	local gridpos = get_grid_position(23,24)
	set_pos(Ef_baruba3 , gridpos)
    set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3 )
	on_active(Ef_baruba4 )
	local gridpos = get_grid_position(27,24)
	set_pos(Ef_baruba4 , gridpos)
    set_scale(Ef_baruba4, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba4 )

	wait_time(0.2)		
	
	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)		
	dot_disp_unit(barbaroi4, true)
	
	wait_time(2.0)	
	
	
	
	move_camera(20, 22, 0.8)
	wait_camera()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_460050")
	
	change_face(Guinevere1, "Normal")
	message("MA_01A900_460051")
	
	change_face(Guinevere1, "Normal")
	message("MA_01A900_460052")
	close_speech_window()

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 18, 22,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 18, 21,0)
	pbadv_setup_101051_Lucius_preload(2,true, 22, 22,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 17, 23,0)
	pbadv_setup_101038_Lola_preload(2,true, 21, 21,0)
	pbadv_setup_101039_Fren_preload(2,true, 21, 23,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 15, 20,0)
	pbadv_setup_101015_Arthur_preload(0,true, 15, 22,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 15, 23,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 15, 21,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 15, 24,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Shockwave02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_LightSword", false, true)
	preload_sound("BGM_Battle_IllusionWar_Start")
	movie_load_preload("MA_01A900_46")
end
