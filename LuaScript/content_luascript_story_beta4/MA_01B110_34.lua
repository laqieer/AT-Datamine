

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201050000", "201050000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 21, 15,0)  
	pbadv_setup_101036_Viena(1,true, 19, 15,0)  

	pbadv_setup_101028_Galahad(1,true, 17, 12,0)  
	pbadv_setup_101035_Liliana(1,true, 24, 14,0)  
	pbadv_setup_101049_Thiton(true, 19, 12,0)  

	pbadv_setup_101053_Mathajim(2,true, 22, 15,0)  
	pbadv_setup_101025_Clare(1,true, 16, 14,0)  
	pbadv_setup_101024_Bors(0,true, 12, 13,0)  


	
	
	barbaroi = dot_reserve_enemy(1, 18, 11, 0)
	barbaroi2 = dot_reserve_enemy(1301, 18, 13, 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	dot_unit_dir(dotLiliana1, 2)
	dot_unit_dir(dotMathajim2, 2)
	
	
	dot_disp_weapon(dotMathajim2,true)

	
	
	dot_disp_unit(dotClare1, false)
	dot_disp_unit(dotBors, false)
	
	
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(40.0, 0.0)
	
	
	move_camera(21, 15, 0.0)

	
	Ef_WitchDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)

	load_sound("BGM_Area_Acoustic")
	
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	
	dot_change_anim(dotNoir2, 3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotMathajim2, 3)
	dot_play_particle_unit(dotMathajim2,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotNoir2, 6)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(dotMathajim2, 6)
	dot_play_particle_unit(dotMathajim2,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_move_knockback(dotNoir2, 20, 15, 0.3, 2)
	dot_move_knockback(dotMathajim2, 23, 15, 0.3, 2)

	wait_time(0.3)	
	dot_change_anim(dotNoir2, 0)
	dot_change_anim(dotMathajim2, 0)
	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_340002")
	close_speech_window()

	
	change_face(Liliana1, "Anger")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340003")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_340004")
	

	
	dot_reserve_move_unit_seq(dotNoir2, 21, 15)
	dot_reserve_move_unit_seq(dotMathajim2, 22, 15)
	exec_parallel_seq()
	
	wait_seq()

	dot_change_anim(dotNoir2, 3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotMathajim2, 3)
	dot_play_particle_unit(dotMathajim2,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.3)
	
	dot_change_anim(dotNoir2, 0)
	dot_change_anim(dotMathajim2, 0)


	
	change_face(Noir2, "Serious")
	
	message("MA_01B110_340006")
	close_speech_window()

	
	change_face(Mathajim2, "Normal")
	open_speech_window("CHRNAME_MATHAJIM",  nil, Mathajim2)
	message("MA_01B110_340007")
	close_speech_window()

	dot_change_anim(dotNoir2, 3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotMathajim2, 6)
	dot_play_particle_unit(dotMathajim2,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_move_knockback(dotMathajim2, 24, 15, 0.3, 2)
	dot_change_anim(dotMathajim2,6)

	wait_time(0.3)

	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotMathajim2,0)
	
	
	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2",  Viena1, nil)
	message("MA_01B110_340008")
	close_speech_window()

	
	dot_change_anim(dotViena1, 3)
	dot_play_particle_unit(dotViena1,"Ef_C_Mag_T_Atk01",3,true)

	wait_time(0.3)

	dot_damage_seq(dotMathajim2,dotViena1,false)

	wait_seq()
	
	dot_change_anim(dotMathajim2, 1)
	dot_change_anim(dotViena1, 0)

	wait_time(0.5)
	
	
	dot_reserve_move_unit_seq(dotNoir2, 21, 14)
	dot_reserve_move_unit_seq(dotLiliana1, 23, 14)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotNoir2, 0)
	dot_change_anim(dotNoir2, 3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotLiliana1, 3)
	dot_play_particle_unit(dotLiliana1,"Ef_C_Spr_N_Atk01",3,true)

	wait_time(0.2)

	dot_move_knockback(dotNoir2, 20, 14, 0.3, 2)
	dot_unit_dir(dotNoir2, 3)
	dot_change_anim(dotNoir2,6)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Spe01",1,true)

	wait_time(0.3)
	
	dot_change_anim(dotNoir2, 0)
	dot_change_anim(dotLiliana1, 0)
		
	
	change_face(Thiton, "Smile")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_340010")
	close_speech_window()

	

	
	change_face(Liliana1, "Anger")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340012")
	close_speech_window()



	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340013")
	close_speech_window()

	dot_change_anim(dotThiton, 4)
	dot_move_unit_seq(dotGalahad1, 17, 12)

	
	move_camera(18, 12, 0.5)
	change_camera_distance(5.0, 0.5)
	dot_change_anim(dotThiton, 0)

	dot_change_anim(barbaroi, 3)
	dot_play_particle_unit(barbaroi,"Ef_C_Swd_N_EmyAtk01",3,true)

	dot_change_anim(barbaroi2, 3)
	dot_play_particle_unit(barbaroi2,"Ef_C_Gun_N_EmyAtk01",3,true)

	dot_change_anim(dotGalahad1, 3)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)	

	dot_change_anim(dotThiton, 0)
	dot_change_anim(barbaroi, 0)
	dot_change_anim(barbaroi2, 0)

	dot_change_anim(dotGalahad1, 6)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Cmn_N_Hit_EmySla01",1,true)

	wait_time(0.2)	

	dot_change_anim(dotGalahad1, 0)	

	wait_seq()
	wait_camera()

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340015")
	close_speech_window()

	
	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01B110_340017")
	close_speech_window()
	
	
	
	change_face(Thiton, "Anger")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_340019")
	close_speech_window()

	
	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01B110_340021")
	close_speech_window()

	
	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01B110_340023")
	close_speech_window()

	
	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_NAMELES",  nil, nil)
	message("MA_01B110_340025")
	
	
	
	change_face(Bors, "Normal")
	
	message("MA_01B110_341001")
	close_speech_window()


	
	dot_change_anim(barbaroi, 6)
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_N_Hit_Spe01",1,true)

	dot_change_anim(barbaroi2, 6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Spe01",1,true)

	wait_time(0.2)

	
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	
	wait_time(0.5)

	dot_disp_unit(barbaroi, false)
	dot_disp_unit(barbaroi2, false)

	dot_remove_unit(barbaroi)
	dot_remove_unit(barbaroi2)

	change_camera_distance(6.0, 0.5)
	move_camera(22, 14, 0.5)

	dot_disp_unit(dotClare1, true)
	dot_place_unit(dotClare1, 21, 14)

	wait_camera()

	

	dot_unit_dir(dotClare1, 3)
	dot_unit_dir(dotNoir2, 3)

	dot_change_anim(dotClare1, 3)
	dot_play_particle_unit(dotClare1,"Ef_C_Spr_N_Atk01",3,true)

	dot_change_anim(dotLiliana1, 3)
	dot_play_particle_unit(dotLiliana1,"Ef_C_Cmn_N_Hit_Spe01",1,true)

	wait_time(0.3)

	dot_move_knockback(dotLiliana1, 24, 14, 0.3, 2)
	dot_change_anim(dotLiliana1,6)

	wait_time(0.3)
	
	dot_change_anim(dotClare1, 0)
	dot_change_anim(dotLiliana1, 1)

	
	
	change_face(Clare1, "Anger")
	open_speech_window("CHRNAME_CLARE2",  Clare1, nil)
	message("MA_01B110_340027")
	close_speech_window()

	
	change_face(Liliana1, "Surprise")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340028")
	close_speech_window()


	
	move_camera(18, 12, 1.0)
	


	
	dot_disp_unit(dotBors, true)
	dot_move_unit_seq(dotBors,13, 13)
	dot_move_unit_seq(dotBors,14, 13)
	dot_move_unit_seq(dotBors,15, 13)	
	dot_move_unit_seq(dotBors,16, 13)	
	dot_move_unit_seq(dotBors,17, 13)	
	wait_seq()
	wait_camera()
		

	
	change_face(Bors, "Anger")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_340030")
	close_speech_window()

	

	
	dot_unit_dir(dotThiton, 3)

	
	change_face(Thiton, "Anger")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_340032")
	close_speech_window()

	
	

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340034")
	close_speech_window()

	
	dot_unit_dir(dotThiton, 2)

	dot_move_unit_seq(dotGalahad1, 17, 12)
	dot_move_unit_seq(dotGalahad1, 18, 12)
	wait_seq()

	dot_change_anim(dotGalahad1, 3)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotGalahad1, 0)
	dot_change_anim(dotThiton, 6)
	dot_play_particle_unit(dotThiton,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.3)

	
	change_face(Thiton, "Anger")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_340036")
	close_speech_window()

	dot_change_anim(dotThiton, 1)

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340037")
	close_speech_window()

	
	change_face(Thiton, "Smile")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01B110_340039")
	close_speech_window()

	
	on_active(Ef_WitchDie) 

	local gridpos = get_grid_position(19, 12)
	set_pos(Ef_WitchDie, gridpos)
	play_particle(Ef_WitchDie)

	wait_time(1.0)

	dot_disp_unit(dotThiton, false)
	dot_remove_unit(dotThiton)

	wait_time(2.0)

	dot_disp_weapon(dotViena1,false)
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotClare1,false)
	dot_disp_weapon(dotGalahad1,false)
	dot_disp_weapon(dotBors,false)
	
	dot_reserve_move_unit_seq(dotViena1, 19, 14)
	exec_parallel_seq()
	
	dot_reserve_move_unit_seq(dotViena1, 19, 13)
	dot_reserve_move_unit_seq(dotNoir2, 20, 13)
	dot_reserve_move_unit_seq(dotClare1, 20, 14)
	exec_parallel_seq()
	
	dot_reserve_move_unit_seq(dotViena1, 19, 12)
	dot_reserve_move_unit_seq(dotNoir2, 20, 12)
	dot_reserve_move_unit_seq(dotClare1, 20, 13)
	exec_parallel_seq()

	wait_seq()
	
	dot_unit_dir(dotViena1, 2)
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotClare1, 2)

	bgm_play("BGM_Area_Acoustic")
	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_340041")
	close_speech_window()

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2",  Clare1, nil)
	message("MA_01B110_340042")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_340043")
	close_speech_window()

	

	
	change_face(Liliana1, "Normal")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340045")
	close_speech_window()


	
	
	dot_disp_unit(dotMathajim2,false)
	dot_change_anim(dotLiliana1, 0)
	dot_disp_weapon(dotLiliana1,false)
	dot_unit_dir(dotViena1, 3)
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotClare1, 3)

	dot_reserve_move_unit_seq(dotLiliana1, 23, 13)
	exec_parallel_seq()
	
	dot_unit_dir(dotLiliana1, 2)

	change_camera_distance(8.0, 1.0)
	move_camera(21, 13, 1.0)

	wait_seq()
	wait_camera()

	
	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2",  Viena1, nil)
	message("MA_01B110_340047")
	close_speech_window()

	
	change_face(Liliana1, "Sad")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340048")
	close_speech_window()

	dot_move_unit_seq(dotBors,19, 13)	
	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2",  Clare1, nil)
	message("MA_01B110_340049")
	close_speech_window()

	
	change_face(Liliana1, "Normal")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340051")
	close_speech_window()

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2",  Clare1, nil)
	message("MA_01B110_340052")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_340053")
	close_speech_window()

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2",  Clare1, nil)
	message("MA_01B110_340054")
	

	
	
	
	    MA_01B110_34_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B110_340055", "MA_01B110_340056")  
	close_speech_window()

   if is_select(1) then            
       MA_01B110_34_select1_1()

    else                            
        MA_01B110_34_select1_2()

    end
   MA_01B110_34_end() 

end
 
function MA_01B110_34_select1()
 
end
 
function MA_01B110_34_select1_1()
 

 
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_340058")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340059")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_340060")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B110_340061")
	

	
	change_face(Noir2, "Normal")
	
	message("MA_01B110_340062")
	close_speech_window()

	
	change_face(Viena1, "Smile")
	open_speech_window("CHRNAME_VIENA2",  Viena1, nil)
	message("MA_01B110_340063")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_340064")
	close_speech_window()

	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340065")
	close_speech_window()

	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_340066")
	close_speech_window()

	
	change_face(Bors, "Smile")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_340067")
	close_speech_window()

 
      
end
 
 
function MA_01B110_34_select1_2()
 

 
	

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_340069")
	close_speech_window()

	
	change_face(Viena1, "Surprise")
	open_speech_window("CHRNAME_VIENA2",  Viena1, nil)
	message("MA_01B110_340070")
	close_speech_window()

	
	change_face(Liliana1, "Normal")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340071")
	close_speech_window()


	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_340072")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340073")
	close_speech_window()

	
	change_face(Liliana1, "Normal")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340074")
	close_speech_window()


	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340075")
	

	
	change_face(Galahad1, "Sad")
	
	message("MA_01B110_340076")
	close_speech_window()

	
	change_face(Liliana1, "Surprise")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340077")
	close_speech_window()


	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B110_340078")
	close_speech_window()
	
	
    
end
 
 

function MA_01B110_34_end()
 




	

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2",  Clare1, nil)
	message("MA_01B110_340080")
	

	
	change_face(Clare1, "Normal")
	
	message("MA_01B110_340081")
	close_speech_window()

	
	change_face(Liliana1, "Sad")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana1)
	message("MA_01B110_340082")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 21, 15,0)
	pbadv_setup_101036_Viena_preload(1,true, 19, 15,0)
	pbadv_setup_101028_Galahad_preload(1,true, 17, 12,0)
	pbadv_setup_101035_Liliana_preload(1,true, 24, 14,0)
	pbadv_setup_101049_Thiton_preload(true, 19, 12,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 22, 15,0)
	pbadv_setup_101025_Clare_preload(1,true, 16, 14,0)
	pbadv_setup_101024_Bors_preload(0,true, 12, 13,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	preload_sound("BGM_Area_Acoustic")
end
