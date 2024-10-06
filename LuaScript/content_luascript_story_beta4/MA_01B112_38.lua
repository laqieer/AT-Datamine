

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	init_psbattleadv("201120100", "201120100")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	
	pbadv_setup_101009_Noir(2,true, 11, 5,0)  
	pbadv_setup_101010_Lancelot(1,true, 11, 4,0)  
	pbadv_setup_101026_Percival(0,true, 8, 1,0)  
	pbadv_setup_101027_Dindrane(2,true, 8, 0,0)  
	pbadv_setup_101024_Bors(0,true, 8, 5,0)  
	pbadv_setup_101025_Clare(1,true, 8, 4,0)  
	pbadv_setup_101034_Excelia(1,true, 19, 3,0)  
	pbadv_setup_101035_Liliana(1,true, 19, 1,0)  
	pbadv_setup_101029_Astera(1,true, 19, 5,0) 
	pbadv_setup_101028_Galahad(1,true, 12, 3,0)  
	pbadv_setup_101036_Viena(1,true, 11, 2,0)  
	pbadv_setup_101011_Guinevere(0,true, 17, 4,0)  
	pbadv_setup_101015_Arthur(0,true, 6, 3,0)  
	pbadv_setup_101020_Merlin(2,true, 17, 2,0)  


	
	pbadv_setup_101056_Perez(1,true, 13, 3,0)  
	
	pbadv_setup_101053_Mathajim(2,true, 21, 1,0)  
	pbadv_setup_101054_Adam(2,true, 21, 3,0)  
	pbadv_setup_101055_Owen(2,true, 21, 5,0)  

	
	
	setup_complete_unit()


	
	
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotMathajim2, 2)
	dot_unit_dir(dotAdam2, 2)
	dot_unit_dir(dotOwen2, 2)
	
	
	
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotViena1, false)
	dot_disp_weapon(dotLancelot1, false)
	dot_disp_weapon(dotPercival, false)
	dot_disp_weapon(dotDindrane2, false)
	dot_disp_weapon(dotBors, false)
	dot_disp_weapon(dotClare1, false)

	dot_disp_weapon(dotMerlin2, false)
	dot_disp_weapon(dotExcelia1, false)
	dot_disp_weapon(dotLiliana1, false)
	dot_disp_weapon(dotAstera1, false)
	dot_disp_weapon(dotGuinevere, false)
	
	
	
	
	dot_disp_unit(dotExcelia1, false)
	dot_disp_unit(dotLiliana1, false)
	dot_disp_unit(dotAstera1, false)
	dot_disp_unit(dotMerlin2, false)
	dot_disp_unit(dotGuinevere, false)

	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(12, 4, 0.0)
	
	
	Ef_spout = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_spout2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_spout3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_warp = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_warp2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_warp3 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_vanish = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemyhuman", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)

end







function Play()
	fadein(0)
	Play_start(true)
	

	
	dot_change_anim(dotMathajim2,1)
	dot_change_anim(dotAdam2,1)
	dot_change_anim(dotOwen2,1)



	dot_attack_seq(dotGalahad1, dotPerez1)
	dot_damage_seq(dotPerez1, dotGalahad1,true)
	wait_time(1.7)
	dot_change_anim(dotGalahad1, 0)
	wait_seq()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380002")
	close_speech_window()


	wait_time(2.0)
	dot_change_anim(dotPerez1,6)
	wait_time(0.5)
	se_play("SE_ADV_MA_01104_25_Fall")
	dot_change_anim(dotPerez1, 1)
	
	


	wait_time(1.5)
	dot_change_anim(dotGalahad1,1)
	wait_seq()


	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_380004")
	


	change_face(Galahad1, "Sad")
	
	message("MA_01B112_380005")
	


	on_active(Ef_Fog)
	
	local gridpos = get_grid_position(13, 3)
	set_pos(Ef_Fog, gridpos)
	set_scale(Ef_Fog, {0.8, 0.8, 0.8})
	play_particle(Ef_Fog)
	

	change_face(Galahad1, "Anger")
	
	message("MA_01B112_380007")
	


	change_face(Galahad1, "Sad")
	
	message("MA_01B112_380008")
	close_speech_window()
	
	dot_move_unit_seq(dotViena1, 12,2)
	wait_seq()


	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B112_380009")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380010")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380011")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380012")
	


	wait_time(1.0)


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380014")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380015")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380016")
	
    
    MA_01B112_38_select1()

    open_select_window_tag(Noir2, "Normal", "MA_01B112_380017", "MA_01B112_380018", "MA_01B112_380019")  
	close_speech_window()

    if is_select(1) then            
        MA_01B112_38_select1_1()

    elseif is_select(2) then        
        MA_01B112_38_select1_2()

    elseif is_select(3) then        
        MA_01B112_38_select1_3()

    end
    MA_01B112_38_end()

end

function MA_01B112_38_select1()

end

function MA_01B112_38_select1_1()




	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_380021")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380022")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380023")
	
	
	
	change_face(Perez1, "Normal")
	
	message("MA_01B112_380034")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380035")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380036")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380037")
	close_speech_window()



end
 
 
function MA_01B112_38_select1_2()
 

 

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_380025")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380026")
	close_speech_window()


	change_face(Lancelot1, "Sad")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B112_380027")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380028")
	
	
	
	change_face(Perez1, "Normal")
	
	message("MA_01B112_380034")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380035")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380036")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380037")
	close_speech_window()



end
 
function MA_01B112_38_select1_3()
 



	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_380030")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380031")
	close_speech_window()


	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_380032")
	close_speech_window()
	
	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380034")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380035")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380036")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380037")
	close_speech_window()
	


end
 
 
function MA_01B112_38_end()
 



	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_380039")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380040")
	close_speech_window()


	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_380041")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380042")
	close_speech_window()


	dot_change_anim(dotGalahad1,0)
	dot_disp_weapon(dotGalahad1, false)
	wait_seq()


	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_380043")
	close_speech_window()


	wait_time(0.2)
	se_play("SE_ADV_MA_01A111_14_Earthquake")
	wait_time(1.0)


	move_camera(19, 5, 2.0)
	wait_time(2.0)
	
	dot_change_anim(dotMathajim2,0)
	dot_change_anim(dotAdam2,0)
	dot_change_anim(dotOwen2,0)
	
	
	
	local gridpos = get_grid_position(21, 1)
	set_pos(Ef_spout, gridpos)

	on_active(Ef_spout)
	play_particle(Ef_spout)
	
	
	local gridpos = get_grid_position(21, 3)
	set_pos(Ef_spout2, gridpos)
	on_active(Ef_spout2)
	play_particle(Ef_spout2)
	
	
	
	local gridpos = get_grid_position(21, 5)
	set_pos(Ef_spout3, gridpos)
	on_active(Ef_spout3)
	play_particle(Ef_spout3)
			
	wait_time(0.5)

	stop_particle(Ef_spout)
	stop_particle(Ef_spout2)
	stop_particle(Ef_spout3)


	wait_time(1.0)

	dot_unit_dir(dotPerez1, 3)


	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B112_380045")
	close_speech_window()


	change_face(Dindrane2, "Anger")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B112_380046")
	close_speech_window()


	change_face(Percival, "Sad")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B112_380047")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380048")
	close_speech_window()


	change_face(Bors, "Sad")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	message("MA_01B112_380049")
	close_speech_window()


	change_face(Clare1, "Anger")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B112_380050")
	close_speech_window()


	dot_move_unit_seq(dotArthur, 18,3)
	wait_seq()


	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B112_380052")
	close_speech_window()


	change_face(Lancelot1, "Surprise")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B112_380053")
	close_speech_window()


	dot_reserve_move_unit_seq(dotMathajim2, 20,1)
	dot_reserve_move_unit_seq(dotAdam2, 20,3)
	dot_reserve_move_unit_seq(dotOwen2, 20,5)
	exec_parallel_seq()


	open_cutin(1,1)

	on_cutin(1,Arthur, "Serious") 

	open_speech_window("CHRNAME_ARTHUR", nil, nil)
	message("MA_01B112_380055")
	close_speech_window()


	close_cutin()


	on_active(Ef_warp)
	local gridpos = get_grid_position(19, 1)
	set_pos(Ef_warp, gridpos)
	play_particle(Ef_warp)
	
	on_active(Ef_warp2)
	
	local gridpos = get_grid_position(19, 3)
	set_pos(Ef_warp2, gridpos)
	play_particle(Ef_warp2)
	
	on_active(Ef_warp3)
	
	local gridpos = get_grid_position(19, 5)
	set_pos(Ef_warp3, gridpos)
	play_particle(Ef_warp3)
	
	wait_time(0.5)
	
	dot_disp_unit(dotExcelia1, true)
	dot_disp_unit(dotLiliana1, true)
	dot_disp_unit(dotAstera1, true)

	wait_time(1.0)

	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B112_380057")
	close_speech_window()







	change_face(Dindrane2, "Surprise")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B112_380059")
	close_speech_window()


	change_face(Clare1, "Surprise")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B112_380060")
	close_speech_window()


	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_380061")
	close_speech_window()
	
	





	change_face(Excelia1, "Anger")
	open_speech_window("CHRNAME_EXCELIA2", Excelia1, nil)
	message("MA_01B112_380062")
	close_speech_window()


	change_face(Liliana1, "Anger")
	open_speech_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01B112_380063")
	close_speech_window()



	change_face(Astera1, "Anger")
	open_speech_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B112_380064")
	close_speech_window()


	change_face(Liliana1, "Sad")
	open_speech_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01B112_380065")
	close_speech_window()


	change_face(Astera1, "Sad")
	open_speech_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B112_380066")
	


	change_face(Astera1, "Sad")
	
	message("MA_01B112_380067")
	close_speech_window()


	change_face(Excelia1, "Sad")
	open_speech_window("CHRNAME_EXCELIA2", Excelia1, nil)
	message("MA_01B112_380068")
	close_speech_window()




	change_face(Liliana1, "Sad")
	open_speech_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01B112_380070")
	close_speech_window()


	change_face(Excelia1, "Normal")
	open_speech_window("CHRNAME_EXCELIA2", Excelia1, nil)
	message("MA_01B112_380071")
	close_speech_window()


	local gridpos = get_grid_position(17, 2)
	set_pos(Ef_warp, gridpos)
	play_particle(Ef_warp)

	local gridpos = get_grid_position(17, 4)
	set_pos(Ef_warp2, gridpos)
	play_particle(Ef_warp2)

	wait_time(0.5)

	dot_disp_unit(dotMerlin2, true)
	dot_disp_unit(dotGuinevere, true)


	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B112_380073")
	close_speech_window()


	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B112_380074")
	


	change_face(Arthur, "Sad")
	
	message("MA_01B112_380075")
	close_speech_window()




	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B112_380077")
	close_speech_window()


	change_camera_distance(6.0, 2.0)
	move_camera(12, 4, 2.0)
	wait_camera()

	dot_unit_dir(dotPerez1, 2)
	

	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380079")
	close_speech_window()


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_380080")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380081")
	


	wait_time(1.0)


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380083")
	


	change_face(Perez1, "Normal")
	
	message("MA_01B112_380084")
	close_speech_window()


	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_380085")
	close_speech_window()


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_380086")
	close_speech_window()


	open_cutin(1,1)
	on_cutin(1,Perez1,"Anger",0)

	bgm_play("Stop_BGM_Bus_MidFade")
	
	open_speech_window("CHRNAME_PEREZ", nil, nil)
	message("MA_01B112_380087")
	close_speech_window()

	close_cutin()


	on_active(Ef_vanish)

	local gridpos = get_grid_position(13, 3)
	set_pos(Ef_vanish, gridpos)
	play_particle(Ef_vanish)
	
	wait_time(0.5)
	
	dot_disp_unit(dotPerez1, false)

	stop_particle(Ef_Fog)

	wait_time(2.0)

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 11, 5,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 11, 4,0)
	pbadv_setup_101026_Percival_preload(0,true, 8, 1,0)
	pbadv_setup_101027_Dindrane_preload(2,true, 8, 0,0)
	pbadv_setup_101024_Bors_preload(0,true, 8, 5,0)
	pbadv_setup_101025_Clare_preload(1,true, 8, 4,0)
	pbadv_setup_101034_Excelia_preload(1,true, 19, 3,0)
	pbadv_setup_101035_Liliana_preload(1,true, 19, 1,0)
	pbadv_setup_101029_Astera_preload(1,true, 19, 5,0)
	pbadv_setup_101028_Galahad_preload(1,true, 12, 3,0)
	pbadv_setup_101036_Viena_preload(1,true, 11, 2,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 17, 4,0)
	pbadv_setup_101015_Arthur_preload(0,true, 6, 3,0)
	pbadv_setup_101020_Merlin_preload(2,true, 17, 2,0)
	pbadv_setup_101056_Perez_preload(1,true, 13, 3,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 21, 1,0)
	pbadv_setup_101054_Adam_preload(2,true, 21, 3,0)
	pbadv_setup_101055_Owen_preload(2,true, 21, 5,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemyhuman", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
end
