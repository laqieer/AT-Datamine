

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201070100", "201070100")
	change_time_and_weather(1,1) 
	

	load_image("10102001", "content_still_10102001_image", "101020010_StillImage")
	
	
	
	pbadv_setup_101009_Noir(2,true, 19, 9,0)  
	pbadv_setup_101010_Lancelot(1,true, 21, 9,0)  
	pbadv_setup_101028_Galahad(1,true, 18, 10,0)  
	pbadv_setup_101036_Viena(1,true, 22, 10,0)  



	
	pbadv_setup_101043_Mazoe(true, 20, 4,0)  
	pbadv_setup_101029_Astera(1,true, 22, 2,0) 
	

	pbadv_setup_101015_Arthur(0,true, 21, 16,0)  
	pbadv_setup_101020_Merlin(2,true, 19, 16,0)  

	pbadv_setup_101055_Owen(2,true, 20, 18,0)  

	barbaroi1 = dot_reserve_enemy(1, 21, 19, 0)
	barbaroi2 = dot_reserve_enemy(1, 20, 19, 0)
	barbaroi3 = dot_reserve_enemy(1, 19, 19, 0)
	barbaroi4 = dot_reserve_enemy(1, 20, 20, 0)	

	setup_complete_unit()
	
	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotLancelot1, 3)
	dot_unit_dir(dotGalahad1, 3)	
	dot_unit_dir(dotViena1, 3)

	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotMerlin2, 3)

	
	dot_unit_dir(dotMazoe, 2)
	dot_unit_dir(dotOwen2, 2)
	dot_unit_dir(dotAstera1, 2)
	
	
	dot_disp_unit(dotAstera1,false)	
	dot_disp_unit(dotArthur,false)	
	dot_disp_unit(dotMerlin2,false)	
	
	dot_disp_unit(dotOwen2,false)	
	dot_disp_unit(barbaroi1,false)	
	dot_disp_unit(barbaroi2,false)	
	dot_disp_unit(barbaroi3,false)	
	dot_disp_unit(barbaroi4,false)	
	
	
	Ef_WitchDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	Ef_Hane = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)	
	Ef_WarpOut1 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut3 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut4 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut5 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut6 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut7 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut8 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut9 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(20, 9, 0.0)
	
	movie_load("MA_01B109_29")
	movie_set_active(true)
	movie_play()

	load_sound("BGM_ADV_Mountain")
	load_sound("BGM_ADV_Serious2")

end



function Play()
	fadein(0)
	Play_start(true)

	movie_wait_playing()
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)


	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_290007")
	close_speech_window()

	
	change_face(Lancelot1, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_290009")
	close_speech_window()
	
	
	move_camera(20, 3, 0.5)
	
	dot_reserve_move_unit_seq(dotLancelot1, 20, 5)
	exec_parallel_seq()
	wait_seq()	
	
	dot_attack_seq(dotLancelot1, dotMazoe)
	dot_damage_seq(dotMazoe, dotLancelot1, true)	
	wait_seq()
	
	dot_change_anim(dotMazoe,6)		
	dot_move_knockback(dotMazoe, 20, 3,0.1, 2)


	
	change_face(Mazoe, "Anger") 
	open_speech_window("CHRNAME_SISTERS_2", nil,Mazoe)
	message("MA_01B109_290011")
	close_speech_window()
	
	dot_reserve_move_unit_seq(dotNoir2, 19, 4)
	exec_parallel_seq()
	wait_seq()	
	
	dot_attack_seq(dotNoir2, dotMazoe)
	dot_damage_seq(dotMazoe, dotNoir2, true)	
	wait_seq()
	dot_change_anim(dotMazoe,6)			
	dot_move_knockback(dotMazoe, 20, 2,0.1, 2)

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_290013")
	close_speech_window()
	
	
	dot_change_anim(dotNoir2,0)
	
	
	dot_reserve_move_unit_seq(dotLancelot1, 20, 3)
	exec_parallel_seq()
	wait_seq()	
	
	dot_attack_seq(dotLancelot1, dotMazoe)
	dot_damage_seq(dotMazoe, dotLancelot1, true)	
	wait_seq()		
	dot_change_anim(dotMazoe,6)	
	dot_move_knockback(dotMazoe, 20, 1,0.1, 2)
	
	
	wait_time(0.5)	
		
	dot_change_anim(dotMazoe,0)

	
	change_face(Mazoe, "Anger") 
	open_speech_window("CHRNAME_SISTERS_2", nil,Mazoe)
	message("MA_01B109_290015")
	close_speech_window()


	on_active(Ef_WarpOut9) 

	local gridpos = get_grid_position(22, 2) 
	set_pos(Ef_WarpOut9, gridpos)
	play_particle(Ef_WarpOut9)

	wait_time(0.3)
	
	dot_disp_unit(dotAstera1, true) 


	wait_time(1.0)
	
	dot_reserve_move_unit_seq(dotAstera1, 20, 2)
	exec_parallel_seq()
	wait_seq()	
	
	dot_change_anim(dotAstera1, 3)
	dot_change_anim(dotLancelot1, 3)

	
	wait_time(0.2)	

	dot_play_particle_unit(dotAstera1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotLancelot1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Lancelot1, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_290017")
	close_speech_window()

	bgm_play("BGM_ADV_Serious2")
	
	change_face(Galahad1, "Surprise") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290018")
	close_speech_window()
	
	dot_attack_seq(dotAstera1, dotLancelot1)	
	dot_damage_seq(dotLancelot1, dotAstera1, true)
	wait_seq()	
	dot_change_anim(dotLancelot1,6)		
	dot_move_knockback(dotLancelot1, 20, 6,0.2, 2)

	
	wait_time(0.2)
	
	dot_change_anim(dotNoir2, 0)
	dot_change_anim(dotLancelot1,0)	

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_290020")
	close_speech_window()
	
	dot_change_anim(dotAstera1, 0)	

	
	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B109_290021")
	
	
	move_camera(20, 5, 0.5)
	
	dot_reserve_move_unit_seq(dotNoir2, 19, 6)
	exec_parallel_seq()
	wait_seq()	
	
	
	wait_time(0.5)





 
    
    MA_01B109_29_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B109_290022", "MA_01B109_290023", "MA_01B109_290024")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01B109_29_select1_1()
 
    elseif is_select(2) then        
        MA_01B109_29_select1_2()
        
    elseif is_select(3) then        
        MA_01B109_29_select1_3()
 
    end
    MA_01B109_29_1_end()
 
end
 
function MA_01B109_29_select1()
 
end
 
function MA_01B109_29_select1_1()
 


 
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_290026")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_290028")
	close_speech_window()

	
	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B109_290029")
	close_speech_window()

	
	change_face(Galahad1, "Normal") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290030")
	close_speech_window()	
	
	
	change_face(Astera1, "Anger")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B109_290042")
	close_speech_window()


 
      
end
 
 
function MA_01B109_29_select1_2()
 

 
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_290032")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_290033")
	close_speech_window()


	
	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B109_290035")
	
	change_face(Astera1, "Anger")
	message("MA_01B109_290042")
	close_speech_window()

 
    
end

function MA_01B109_29_select1_3()
 

 
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_290037")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_290038")
	close_speech_window()

	
	change_face(Viena1, "Surprise")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B109_290039")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_290040")
	close_speech_window()
	

	
	change_face(Astera1, "Anger")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B109_290042")
	close_speech_window()
 
    
end
 
function MA_01B109_29_1_end()



	
	
	move_camera(20, 10, 0.5)	
	wait_camera()	

	
	change_face(Galahad1, "Anger") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290043")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_290044")
	close_speech_window()

	
	change_face(Galahad1, "Normal") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290046")
	close_speech_window()
	
	
	move_camera(20, 6, 0.5)	
	wait_camera()	

	
	dot_reserve_move_unit_seq(dotAstera1, 20, 5)
	exec_parallel_seq()
	wait_seq()	

	
	change_face(Astera1, "Anger")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B109_290048")
	close_speech_window()
	



	
	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B109_290050")
	close_speech_window()
	
	
	move_camera(20, 2, 0.5)	
	wait_camera()	
	
	
	on_active(Ef_Hane) 

	local gridpos = get_grid_position(20, 1)
	set_pos(Ef_Hane, gridpos)
	play_particle(Ef_Hane)

	wait_time(0.5)

	
	change_face(Mazoe, "Smile") 
	open_speech_window("CHRNAME_SISTERS_2", nil,Mazoe)
	message("MA_01B109_290051")
	close_speech_window()
	
	
	dot_disp_unit(dotArthur,true)	
	dot_disp_unit(dotMerlin2,true)	



	
	change_face(Merlin2, "Anger") 
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01B109_290053")
	close_speech_window()

	
	
	dot_play_particle_unit(dotMazoe,"Ef_C_Mag_I_Hit01",1,true)	
	dot_change_anim(dotMazoe, 6)
	
	wait_time(1.5)

	
	change_face(Arthur, "Anger") 
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01B109_290055")
	close_speech_window()
	
	
	dot_change_anim(dotMazoe,0)
	
	
	move_camera(20, 8, 0.8)	
	wait_camera()
	
	dot_reserve_move_unit_seq(dotArthur, 21, 8)
	dot_reserve_move_unit_seq(dotMerlin2, 19, 8)
	exec_parallel_seq()
	wait_seq()	

	
	change_face(Merlin2, "Normal") 
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B109_290057")
	close_speech_window()
	
	
	move_camera(20, 3, 0.7)	
	
	dot_reserve_move_unit_seq(dotArthur, 20, 2)
	exec_parallel_seq()
	wait_seq()	

	dot_attack_seq(dotArthur, dotMazoe)
	dot_damage_seq(dotMazoe, dotArthur, true)	
	wait_seq()	
	
	
	dot_change_anim(dotMazoe,1)	
	dot_change_anim(dotArthur,0)	

	
	change_face(Mazoe, "Anger") 
	open_speech_window("CHRNAME_SISTERS_2", nil,Mazoe)
	message("MA_01B109_290059")
	close_speech_window()

	
	change_face(Arthur, "Normal") 
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B109_290060")
	close_speech_window()

	
	change_face(Mazoe, "Anger") 
	open_speech_window("CHRNAME_SISTERS_2", nil,Mazoe)
	message("MA_01B109_290061")
	
	change_face(Mazoe, "Anger") 
	message("MA_01B109_290063")
	close_speech_window()

	
	
	on_active(Ef_WitchDie) 

	local gridpos = get_grid_position(20, 1)
	set_pos(Ef_WitchDie, gridpos)
	play_particle(Ef_WitchDie)

	wait_time(1.0)

	dot_disp_unit(dotMazoe, false)
	dot_remove_unit(dotMazoe)

	wait_time(2.0)


	
	change_face(Arthur, "Normal") 
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B109_290065")
	close_speech_window()
	
	
	move_camera(20, 6, 0.5)	
	wait_camera()	
	
	
	wait_time(0.5)	
	
	show_image("10102001", 0.0, 0.0, STILL_SWITCH_TIME)
	set_position_image(STILL_POS_LEFT,STILL_POS_LENGTH)
	set_scale_image(STILL_SCALE,STILL_SCALE)
	
	wait_time(STILL_SWITCH_TIME)
	
	scale_to_image(1,1,STILL_MOVE_TIME2,2)
	move_to_image(0,0,STILL_MOVE_TIME2,2)
	wait_time(STILL_ACTIVE_AFTER)
	
	
	open_simple_window("CHRNAME_ASTERA2", nil, nil)
	message("MA_01B109_290067")
	close_simple_window()

	
	move_camera(20, 13, 0.0)	
	
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotArthur, 2)
	dot_change_anim(dotArthur, 0)	
	dot_disp_unit(dotOwen2,true)	
	dot_disp_unit(barbaroi1,true)	
	dot_disp_unit(barbaroi2,true)	
	dot_disp_unit(barbaroi3,true)	
	dot_disp_unit(barbaroi4,true)	
		
	
	open_simple_window("CHRNAME_OWEN", nil, nil)
	message("MA_01B109_290069")
	close_simple_window()
	
	dot_place_unit(dotOwen2,20, 12)
	dot_place_unit(barbaroi1,21, 14)	
	dot_place_unit(barbaroi2,20, 14)
	dot_place_unit(barbaroi3,19, 14)
	dot_place_unit(barbaroi4,20, 15)
	
	
	open_simple_window("CHRNAME_VIENA2", nil, nil)
	message("MA_01B109_290070")
	close_simple_window()
	
	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )

	
	
	wait_time(0.5)

	
	move_camera(20, 7, 0.6)	
	wait_camera()	
	
	
	
	wait_time(0.5)



 
    
    MA_01B109_29_select2()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B109_290071", "MA_01B109_290072")  
 
    if is_select(1) then            
        MA_01B109_29_select2_1()
 
    elseif is_select(2) then        
        MA_01B109_29_select2_2()
 
    end
    MA_01B109_29_2_end()
 
end
 
function MA_01B109_29_select2()
 
end
 
function MA_01B109_29_select2_1()
 

	dot_reserve_move_unit_seq(dotNoir2, 21, 8)
	dot_reserve_move_unit_seq(dotOwen2, 21, 9)
	dot_reserve_move_unit_seq(dotLancelot1, 20, 6)
	dot_reserve_move_unit_seq(dotAstera1, 20, 5)
	exec_parallel_seq()
	wait_seq()
	
	wait_time(0.2)	
	
	
	dot_unit_dir(dotLancelot1, 2)	
	
	





	dot_change_anim(dotLancelot1, 3)
	dot_change_anim(dotAstera1, 3)

	
	wait_time(0.4)	
	
	dot_play_particle_unit(dotLancelot1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotAstera1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	

	
	wait_time(0.2)


	
	dot_move_knockback(dotLancelot1, 21, 6,0.2, 2)	
	dot_move_knockback(dotAstera1, 19, 6,0.2, 2)	
	
	
	wait_time(0.2)		
	
	dot_change_anim(dotOwen2, 3)
	dot_change_anim(dotNoir2, 3)
	
	
	wait_time(0.4)	
	
	dot_play_particle_unit(dotOwen2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	wait_time(0.2)	
	
	
	dot_move_knockback(dotNoir2, 20, 8,0.2, 2)
	dot_move_knockback(dotOwen2, 22, 8,0.2, 2)
	
	
	wait_time(0.3)	
	
	
	
	dot_change_anim(dotNoir2,0)	
	dot_change_anim(dotOwen2,0)	
	dot_change_anim(dotLancelot1,0)	
	dot_change_anim(dotAstera1,0)		
	
	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotOwen2, 2)
	dot_unit_dir(dotLancelot1, 2)	
	dot_unit_dir(dotAstera1, 3)
	
	
	wait_time(0.2)	
	

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_290074")
	close_speech_window()

	
	change_face(Lancelot1, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_290075")
	
	change_face(Lancelot1, "Normal")
	message("MA_01B109_290076")
	close_speech_window()
	
	
	move_camera(20, 12, 0.7)

	
	dot_reserve_move_unit_seq(dotMerlin2, 19, 12)
	dot_reserve_move_unit_seq(dotArthur, 20, 12)
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotMerlin2, 3)

	
	change_face(Merlin2, "Anger") 
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B109_290077")
	
	change_face(Merlin2, "Normal") 
	message("MA_01B109_290084")
	close_speech_window()
 
      
end
 
 
function MA_01B109_29_select2_2()
 


	dot_reserve_move_unit_seq(dotNoir2, 21, 8)
	dot_reserve_move_unit_seq(dotOwen2, 21, 9)
	dot_reserve_move_unit_seq(dotLancelot1, 20, 6)
	dot_reserve_move_unit_seq(dotAstera1, 20, 5)
	exec_parallel_seq()
	wait_seq()
	
	wait_time(0.2)	
	
	
	dot_unit_dir(dotLancelot1, 2)	
	
	





	dot_change_anim(dotLancelot1, 3)
	dot_change_anim(dotAstera1, 3)

	
	wait_time(0.4)	
	
	dot_play_particle_unit(dotLancelot1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotAstera1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	

	
	wait_time(0.2)


	
	dot_move_knockback(dotLancelot1, 21, 6,0.2, 2)	
	dot_move_knockback(dotAstera1, 19, 6,0.2, 2)	
	
	
	wait_time(0.2)		
	
	dot_change_anim(dotOwen2, 3)
	dot_change_anim(dotNoir2, 3)
	
	
	wait_time(0.4)	
	
	dot_play_particle_unit(dotOwen2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	wait_time(0.2)	
	
	
	dot_move_knockback(dotNoir2, 20, 8,0.2, 2)
	dot_move_knockback(dotOwen2, 22, 8,0.2, 2)
	
	
	wait_time(0.3)	
	
	
	
	dot_change_anim(dotNoir2,0)	
	dot_change_anim(dotOwen2,0)	
	dot_change_anim(dotLancelot1,0)	
	dot_change_anim(dotAstera1,0)		
	
	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotOwen2, 2)
	dot_unit_dir(dotLancelot1, 2)	
	dot_unit_dir(dotAstera1, 3)
	
	
	wait_time(0.2)	
		
 
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_290079")
	close_speech_window()

	
	change_face(Galahad1, "Normal") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290081")
	close_speech_window()
	
	
	move_camera(20, 12, 0.5)

	
	dot_reserve_move_unit_seq(dotMerlin2, 20, 12)
	dot_reserve_move_unit_seq(dotArthur, 19, 12)
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotMerlin2, 3)

	
	change_face(Arthur, "Anger") 
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B109_290082")
	close_speech_window()

	
	change_face(Merlin2, "Normal") 
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B109_290084")
	close_speech_window()

 
    
end
 
function MA_01B109_29_2_end()



	



	
	change_face(Galahad1, "Normal") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290086")
	close_speech_window()
	
	
	move_camera(20, 10, 0.3)
	
	
	wait_time(0.2)		

	dot_reserve_move_unit_seq(dotOwen2, 21, 8)
	dot_reserve_move_unit_seq(dotLancelot1, 20, 6)
	dot_reserve_move_unit_seq(dotNoir2, 20, 8)
	dot_reserve_move_unit_seq(dotAstera1, 19, 6)
	exec_parallel_seq()
	wait_seq()	
	
	
	dot_change_anim(dotNoir2, 3)
	dot_change_anim(dotOwen2, 3)
	
	
	wait_time(0.4)	
		
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotOwen2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	wait_time(0.2)	
	
	dot_move_knockback(dotOwen2, 23, 8,0.2, 2)	

	
	wait_time(0.2)	

	dot_change_anim(dotAstera1, 3)
	dot_change_anim(dotLancelot1, 3)
	
	
	wait_time(0.4)	
	
	dot_play_particle_unit(dotAstera1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotLancelot1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	
	wait_time(0.2)		
	
	dot_move_knockback(dotAstera1, 17, 6,0.2, 2)
	
	
	wait_time(0.4)	
	
	
	dot_change_anim(dotNoir2,0)	
	dot_change_anim(dotOwen2,0)	
	dot_change_anim(dotLancelot1,0)	
	dot_change_anim(dotAstera1,0)

	
	change_face(Galahad1, "Normal") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290088")
	
	change_face(Galahad1, "Normal") 
	message("MA_01B109_290090")
	close_speech_window()

	
	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B109_290091")
	close_speech_window()

	
	change_face(Galahad1, "Sad") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290093")
	close_speech_window()
	
	
	move_camera(17, 6, 0.6)
	wait_camera()	

	
	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B109_290094")
	close_speech_window()
	
	
	move_camera(20, 10, 0.6)
	wait_camera()	

	
	change_face(Galahad1, "Normal") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290095")
	close_speech_window()
	
	

	
	change_face(Owen2, "Normal")
	open_speech_window("CHRNAME_OWEN", nil, Owen2)
	message("MA_01B109_290096")
	close_speech_window()

	
	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B109_290097")
	close_speech_window()
	
	
	



	
	change_face(Galahad1, "Sad") 
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_290098")
	close_speech_window()
	
	
	on_active(Ef_WarpOut1) 

	local gridpos = get_grid_position(18, 10) 
	set_pos(Ef_WarpOut1, gridpos)
	play_particle(Ef_WarpOut1)
        
	on_active(Ef_WarpOut2) 

	local gridpos = get_grid_position(22, 10) 
	set_pos(Ef_WarpOut2, gridpos)
	play_particle(Ef_WarpOut2)

	on_active(Ef_WarpOut5) 

	local gridpos = get_grid_position(20, 6) 
	set_pos(Ef_WarpOut5, gridpos)
	play_particle(Ef_WarpOut5)
        
	on_active(Ef_WarpOut6) 

	local gridpos = get_grid_position(20, 8) 
	set_pos(Ef_WarpOut6, gridpos)
	play_particle(Ef_WarpOut6)

	on_active(Ef_WarpOut7) 

	local gridpos = get_grid_position(20, 12) 
	set_pos(Ef_WarpOut7, gridpos)
	play_particle(Ef_WarpOut7)
        
	on_active(Ef_WarpOut8) 

	local gridpos = get_grid_position(19, 12) 
	set_pos(Ef_WarpOut8, gridpos)
	play_particle(Ef_WarpOut8)

	wait_time(0.3)
	
	dot_disp_unit(dotNoir2, false) 
	dot_disp_unit(dotLancelot1, false) 
	dot_disp_unit(dotGalahad1, false) 
	dot_disp_unit(dotViena1, false) 

	dot_disp_unit(dotArthur, false) 
	dot_disp_unit(dotMerlin2, false) 


	wait_time(2.0)

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10102001", "content_still_10102001_image", "101020010_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 19, 9,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 21, 9,0)
	pbadv_setup_101028_Galahad_preload(1,true, 18, 10,0)
	pbadv_setup_101036_Viena_preload(1,true, 22, 10,0)
	pbadv_setup_101043_Mazoe_preload(true, 20, 4,0)
	pbadv_setup_101029_Astera_preload(1,true, 22, 2,0)
	pbadv_setup_101015_Arthur_preload(0,true, 21, 16,0)
	pbadv_setup_101020_Merlin_preload(2,true, 19, 16,0)
	pbadv_setup_101055_Owen_preload(2,true, 20, 18,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	movie_load_preload("MA_01B109_29")
	preload_sound("BGM_ADV_Mountain")
	preload_sound("BGM_ADV_Serious2")
end
