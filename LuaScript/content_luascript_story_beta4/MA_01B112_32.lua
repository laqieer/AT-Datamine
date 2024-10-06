

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	init_psbattleadv("201120100", "201120100")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)
	
	
	pbadv_setup_101009_Noir(2,true, 9, 4,0)  
	pbadv_setup_101010_Lancelot(1,true, 10, 5,0)  
	pbadv_setup_101015_Arthur(0,true, 8, 4,0)  
	pbadv_setup_101028_Galahad(1,true, 9, 3,0)  
	pbadv_setup_101036_Viena(1,true, 10, 2,0)  
	
	
	pbadv_setup_101056_Perez(1,true, 15, 4,0)  
	pbadv_setup_101042_Moronoe(true, 13, 2,0)  
	pbadv_setup_101053_Mathajim(2,true, 16, 1,0)  
	pbadv_setup_101054_Adam(2,true, 16, 3,0)  
	pbadv_setup_101055_Owen(2,true, 16, 5,0)  
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotMathajim2, 2)
	dot_unit_dir(dotAdam2, 2)
	dot_unit_dir(dotOwen2, 2)
	
	
	dot_disp_weapon(dotPerez1, false)
	
	
	dot_disp_unit(dotMoronoe, false)
	
	
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(25.0, 0.0)
	
	
	move_camera(13, 5, 0.0)
	
	
	Enemy_spout = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_Witch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)

end




function Play()
	fadein(0)
	Play_start(true)


	dot_reserve_move_unit_seq(dotPerez1, 13,4)
	dot_reserve_move_unit_seq(dotLancelot1, 12,4)
	dot_unit_dir(dotPerez1, 2)
	exec_parallel_seq()

	wait_seq()

	dot_change_anim(dotPerez1, 3)
	dot_play_particle_unit(dotPerez1,"Ef_C_Mag_R_Atk01",1,true)
	
	
	wait_time(0.2)

	dot_play_particle_unit(dotLancelot1,"Ef_C_Mag_R_Hit01",1,true)

	dot_change_anim(dotLancelot1, 6)

	wait_time(0.2)
	dot_change_anim(dotPerez1, 0)
	
	

	dot_move_knockback(dotLancelot1, 10,4,0.2,2)
	
	
	dot_disp_weapon(dotLancelot1, false)
	dot_unit_dir(dotLancelot1, 3)
	dot_change_anim(dotLancelot1,6)
	wait_time(0.5)
	dot_change_anim(dotLancelot1, 1)

	wait_time(1.0)


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_320002")
	


	dot_move_unit_seq(dotNoir2, 11,5)
	wait_seq()


	change_face(Perez1, "Normal")
	
	message("MA_01B112_320004")
	
	
	change_face(Perez1, "Normal")
	
	message("MA_01B112_320005")
	
	
	change_face(Perez1, "Normal")
	
	message("MA_01B112_320006")
	close_speech_window()
	

	move_camera(10, 4, 1.0)
	change_camera_distance(6.0, 1.0)

	

	wait_time(1.5)
	dot_change_anim(dotLancelot1, 0)
	dot_disp_weapon(dotLancelot1, true)
	wait_time(1.0)


	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B112_320008")
	close_speech_window()
	
	dot_unit_dir(dotNoir2, 2)
	wait_time(0.5)
	

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_320009")
	close_speech_window()
	

	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B112_320010")
	
	
	change_face(Lancelot1, "Normal")
	
	message("MA_01B112_320011")
	
	
	change_face(Lancelot1, "Serious")
	
	message("MA_01B112_320012")
	


	change_face(Lancelot1, "Serious")
	
	message("MA_01B112_320014")
	
	

	change_face(Lancelot1, "Serious")
	
	message("MA_01B112_320016")
	
    
    MA_01B112_32_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B112_320017", "MA_01B112_320018")  
 	close_speech_window()

    if is_select(1) then            
        MA_01B112_32_select1_1()
 
    else                                
        MA_01B112_32_select1_2()
  
    end
    MA_01B112_32_end()
 
end
 
function MA_01B112_32_select1()
 
end
 
	function MA_01B112_32_select1_1()




	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_320020")
	close_speech_window()
	

	change_face(Lancelot1, "Smile")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B112_320021")
	
	

	change_face(Lancelot1, "Smile")
	
	message("MA_01B112_320022")
	
 

end
	
function MA_01B112_32_select1_2()
 

 

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_320024")
	close_speech_window()
	

	change_face(Lancelot1, "Smile")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B112_320025")
	
	

	change_face(Lancelot1, "Normal")
	
	message("MA_01B112_320026")
	
 
    
end
	function MA_01B112_32_end()
	


	dot_unit_dir(dotNoir2, 3) 
	dot_move_unit_seq(dotLancelot1, 11,4)
	wait_seq()

	dot_change_anim(dotNoir2, 12)
	dot_change_anim(dotLancelot1, 12)


	change_face(Lancelot1, "Normal")
	
	message("MA_01B112_320028")
	close_speech_window()



	move_camera(13, 5, 1.0)
	change_camera_distance(7.0, 1.0)
	

	wait_time(2.0)


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_320030")
	
	

	change_face(Perez1, "Normal")
	
	message("MA_01B112_320031")
	
	

	change_face(Perez1, "Normal")
	
	message("MA_01B112_320032")
	close_speech_window()
	
	se_play("SE_ADV_MA_01B112_32_Armor_Move")
	
	wait_time(0.2)

	move_camera(12, 5, 1.0)
	dot_reserve_move_unit_seq(dotMathajim2, 14,1)
	dot_reserve_move_unit_seq(dotAdam2, 14,3)
	dot_reserve_move_unit_seq(dotOwen2, 14,5)
	exec_parallel_seq()

	wait_camera()

	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_320034")
	close_speech_window()
	

	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_320035")
	
	

	change_face(Perez1, "Normal")
	
	message("MA_01B112_320036")
	close_speech_window()
	

	open_cutin(1,1)

	on_cutin(1,Galahad1, "Anger") 

	open_speech_window("CHRNAME_GALAHAD",  nil, nil)
	message("MA_01B112_320037")
	close_speech_window()


	close_cutin()
	
	

	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_320038")
	close_speech_window()
	

	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_320039")
	
	

	change_face(Perez1, "Normal")
	
	message("MA_01B112_320040")
	
	

	change_face(Perez1, "Normal")
	
	message("MA_01B112_320041")
	close_speech_window()
	

	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B112_320042")
	close_speech_window()
	
	

	move_camera(12, 3, 2.0)
	change_camera_distance(6.0, 2.0)

	
	on_active(Ef_Witch) 
	
	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Witch)

	wait_time(0.5)
	
	dot_disp_unit(dotMoronoe, true)

	wait_time(2.0)


	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B112_320044")
	close_speech_window()
	

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_320045")
	close_speech_window()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 9, 4,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 10, 5,0)
	pbadv_setup_101015_Arthur_preload(0,true, 8, 4,0)
	pbadv_setup_101028_Galahad_preload(1,true, 9, 3,0)
	pbadv_setup_101036_Viena_preload(1,true, 10, 2,0)
	pbadv_setup_101056_Perez_preload(1,true, 15, 4,0)
	pbadv_setup_101042_Moronoe_preload(true, 13, 2,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 16, 1,0)
	pbadv_setup_101054_Adam_preload(2,true, 16, 3,0)
	pbadv_setup_101055_Owen_preload(2,true, 16, 5,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
end
