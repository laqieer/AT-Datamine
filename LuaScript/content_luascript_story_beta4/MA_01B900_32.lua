

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201180000", "201180000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 21, 39,0)  
	pbadv_setup_101010_Lancelot(3,true, 22, 39,0)  
	pbadv_setup_101010_Lancelot(1,true, 5, 13,0)  
	pbadv_setup_101028_Galahad(1,true, 20, 39,0)  

	pbadv_setup_101041_Morgan(1,true, 22, 29,0) 
	pbadv_setup_101015_Arthur(1,true, 21, 29,0)  
	
	
	
	
	

	
	
	

	
	Arthur = dot_reserve_facility(51, 21, 29, DotDir_Down, 1, true)

	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotArthur1, 2) 


	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotGalahad1, false)
	dot_disp_weapon(dotArthur1, false)
	dot_disp_weapon(dotMorgan1, false)

	
	
	
	dot_disp_unit(dotArthur1, false)
	dot_disp_unit(dotLancelot1, false)

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(21, 30, 0.0)

	
	Ef_EneAura_A1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	Ef_EneAura_A1_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)

	Ef_EneAura_A2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_EneAura_A2_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)

	Ef_EneAura_A3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	Ef_EneAura_A3_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	Ef_EneAura_A3_3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)

	Ef_Blackfog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)

	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)

	Ef_EmblemN = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 
	Ef_EmblemL = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 

	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_KillChan = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)

	
	dot_disp_facility(Arthur,true)

	on_active(Ef_Blackfog) 
	local gridpos = get_grid_position(21, 29)
	set_pos(Ef_Blackfog, gridpos)
	set_scale(Ef_Blackfog, {1.5, 1.5, 1.5}) 
	play_particle(Ef_Blackfog)

	load_sound("BGM_ADV_Revenge")

end





function Play()
	fadein(0)
	Play_start(true)

	
	

	
	
	wait_time(1.0)

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320002")
	

	dot_reserve_move_unit_seq(dotMorgan1, 22, 31)
	exec_parallel_seq()
	dot_reserve_move_unit_seq(dotMorgan1, 21, 31)
	exec_parallel_seq()

	wait_seq()

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_320003")
	close_speech_window()

	dot_unit_dir(dotMorgan1, 0) 
	dot_change_anim(dotMorgan1,5)

	
	
	

	wait_time(0.3)

	on_active(Ef_EneAura_A3_2) 

	local gridpos = get_grid_position(21, 31)
	set_pos(Ef_EneAura_A3_2, gridpos)
	play_particle(Ef_EneAura_A3_2)

	wait_time(0.2)

	

	on_active(Ef_EneAura_A1) 
	on_active(Ef_EneAura_A2) 
	on_active(Ef_EneAura_A3) 

	local gridpos = get_grid_position(21, 30)
	set_pos(Ef_EneAura_A3, gridpos)
	set_scale(Ef_EneAura_A3, {1.8, 1.8, 1.8}) 
	play_particle(Ef_EneAura_A3)

	wait_time(0.3)

	
	dot_disp_unit(dotArthur1, true)
	dot_facility_interact_seq(1)

	wait_time(0.3)

	local gridpos = get_grid_position(21, 30)
	set_pos(Ef_EneAura_A1, gridpos)
	set_scale(Ef_EneAura_A1, {1.6, 1.6, 1.6}) 
	play_particle(Ef_EneAura_A1)
	
	local gridpos = get_grid_position(21, 30)
	set_pos(Ef_EneAura_A2, gridpos)
	set_scale(Ef_EneAura_A2, {1.6, 1.6, 1.6}) 
	play_particle(Ef_EneAura_A2)

	local gridpos = get_grid_position(21, 30)
	set_pos(Ef_EneAura_A3_3, gridpos)
	set_scale(Ef_EneAura_A3_3, {1.8, 1.8, 1.8}) 
	play_particle(Ef_EneAura_A3_3)

	wait_time(2.0)
	
	stop_particle(Ef_EneAura_A1)
	stop_particle(Ef_EneAura_A3)
	dot_change_anim(dotMorgan1,0)

	wait_time(1.0)

	stop_particle(Ef_EneAura_A2)

	wait_time(0.5)

	stop_particle(Ef_Blackfog)


	wait_time(0.5)

	dot_reserve_move_unit_seq(dotMorgan1, 20, 31)
	exec_parallel_seq()
	dot_reserve_move_unit_seq(dotMorgan1, 20, 29)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotMorgan1, 3) 
	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320005")
	

	
	change_face(Morgan1, "Smile")
	
	message("MA_01B900_320006")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotNoir2, 21, 33)
	dot_reserve_move_unit_seq(dotGalahad1,20, 33)
	dot_reserve_move_unit_seq(dotLancelot3,22, 33)

	exec_parallel_seq()

	move_camera(21, 32, 0.5)

	wait_seq()
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotGalahad1, false)
	dot_unit_dir(dotLancelot3, 3) 
	dot_unit_dir(dotNoir2, 3) 
	dot_unit_dir(dotGalahad1, 3) 
	dot_unit_dir(dotMorgan1, 2) 



	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_320008")
	close_speech_window()

	
	
	change_face(Morgan1, "Smile")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320010")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_320012")
	close_speech_window()

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_320013")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320015")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_321001")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_320017")
	close_speech_window()

	

	
	local gridpos = get_grid_position(21, 29)
	set_pos(Ef_EneAura_A3, gridpos)
	set_scale(Ef_EneAura_A3, {1.2, 1.2, 1.2}) 
	play_particle(Ef_EneAura_A3)

	wait_time(0.5)

	local gridpos = get_grid_position(21, 29)
	set_pos(Ef_EneAura_A1, gridpos)
	play_particle(Ef_EneAura_A1)
	
	
	wait_time(0.5)

	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320019")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_320020")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_320021")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320022")
	

	
	
	change_face(Morgan1, "Smile")
	
	message("MA_01B900_320024")
	close_speech_window()

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_320025")
	close_speech_window()

	
	on_active(Ef_BlFeather) 

	local gridpos = get_grid_position(20, 29)
	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)

	dot_change_anim(dotMorgan1,4)

	wait_time(1.0)

	dot_change_anim(dotMorgan1,0)

	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320027")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_320029")
	close_speech_window()
	
	dot_move_unit_seq(dotLancelot3,22, 32)
	
	wait_seq()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_320030")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320031")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_320032")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320033")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_320034")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01B900_320035")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01B900_320036")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01B900_320037")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_320038")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_320039")
	

	
	change_face(Lancelot3, "Normal")
	
	message("MA_01B900_320040")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	on_active(Ef_EmblemN)
	on_active(Ef_EmblemL)

	local locatorpos = dot_get_unit_locator(dotNoir2, 1)
	set_pos(Ef_EmblemN, locatorpos)
	play_particle(Ef_EmblemN)

	local locatorpos = dot_get_unit_locator(dotLancelot3, 1)
	set_pos(Ef_EmblemL, locatorpos)
	play_particle(Ef_EmblemL)

	wait_time(2.0)

	on_active(Ef_Killers) 
	on_active(Ef_Vibes) 

	
	local gridpos = get_grid_position(22, 32)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(21, 33)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	on_active(Ef_KillChan)

	local gridpos = get_grid_position(22, 32)
	set_pos(Ef_KillChan, gridpos)
	play_particle(Ef_KillChan)

	wait_time(0.7)

	dot_change_unit(dotLancelot3, dotLancelot1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Killers)
	stop_particle(Ef_Vibes)

	wait_time(2.5)
	
	bgm_play("BGM_ADV_Revenge")
	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_320042")
	

	
	change_face(Lancelot1, "Normal")
	
	message("MA_01B900_320043")
	
	

	
	

   
    MA_01B900_32_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B900_320044", "MA_01B900_320045")  
 	close_speech_window()

   if is_select(1) then            
        MA_01B900_32_select1_1()

    else                            
        MA_01B900_32_select1_2()

    end
    MA_01B900_32_end()
    
end
 
function MA_01B900_32_select1()
 
end
 
function MA_01B900_32_select1_1()
 

 
	
	
	
	dot_reserve_move_unit_seq(dotNoir2, 21, 32)
	dot_reserve_move_unit_seq(dotGalahad1,20, 32)

	exec_parallel_seq()

	wait_seq()

	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotGalahad1, true)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_320047")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_320048")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_320050")
	
 
 	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_320056")
	

      
end
 
 
function MA_01B900_32_select1_2()
 

 
	
	
	
	dot_reserve_move_unit_seq(dotNoir2, 21, 32)
	dot_reserve_move_unit_seq(dotGalahad1,20, 32)

	exec_parallel_seq()

	wait_seq()

	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotGalahad1, true)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_320052")
	close_speech_window()

	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_320053")
	

	
	change_face(Galahad1, "Smile")
	
	message("MA_01B900_320054")
	close_speech_window()
 
 	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_320056")
	

    
end
 
function MA_01B900_32_end()
 



	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B900_320057")
	close_speech_window()

	
	change_face(Lancelot1, "Smile")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_320058")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_320059")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_320060")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_320061")
	close_speech_window()

	
	on_active(Ef_Roar) 

	local gridpos = get_grid_position(21, 29)
	set_pos(Ef_Roar, gridpos)
	play_particle(Ef_Roar)

	dot_unit_dir(dotArthur1, 1) 
	dot_change_anim(dotArthur1,3)

	wait_time(0.7)

	dot_unit_dir(dotArthur1, 2) 
	dot_change_anim(dotArthur1,0)

	wait_time(0.5)

	
	open_cutin(1,1)
	
	on_cutin(1,Lancelot1,"Serious") 

	
	
	open_speech_window("CHRNAME_LANCELOT2", nil, nil)
	message("MA_01B900_320063")
	close_speech_window()

	
	close_cutin()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 21, 39,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 22, 39,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 5, 13,0)
	pbadv_setup_101028_Galahad_preload(1,true, 20, 39,0)
	pbadv_setup_101041_Morgan_preload(1,true, 22, 29,0)
	pbadv_setup_101015_Arthur_preload(1,true, 21, 29,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	preload_sound("BGM_ADV_Revenge")
end
