Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 23, 25,0)  
	pbadv_setup_101035_Liliana(0,true, 22, 25,0)  

	dotmarco = dot_reserve_ally(401038001, 21, 26, 0) 
	dot_set_weapon(dotmarco, 102020001)

	pbadv_setup_101012_Dinatan(0,true, 31, 26,0)  
	pbadv_setup_101025_Clare(1,true, 32, 26,0)  


	barbaroi1 = dot_reserve_enemy(1, 30, 24, 0) 
	barbaroi2 = dot_reserve_enemy(1, 31, 25, 0) 
	barbaroi3 = dot_reserve_enemy(601, 22, 25, 0) 

	
	
	
	setup_complete_unit()
	

	dot_unit_dir(barbaroi3,3)

	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLiliana, false)
	dot_disp_weapon(dotmarco, false)

	dot_disp_weapon(dotDinatan, false)

	
	
	dot_disp_unit(dotDinatan, false)
	dot_disp_unit(dotClare1, false)
		
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(27, 24, 0.0)

	
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 

	load_sound("BGM_ADV_Invasion2")
	load_sound("BGM_Area_Acoustic")


end





function Play()
	fadein(0)
	Play_start(true)


	
	dot_reserve_move_unit_seq(dotNoir2, 25, 25)
	dot_reserve_move_unit_seq(dotLiliana,24, 25)
	dot_reserve_move_unit_seq(dotmarco, 23, 26)
	exec_parallel_seq()

	dot_reserve_move_unit_seq(dotNoir2, 25, 24)
	dot_reserve_move_unit_seq(dotLiliana,25, 25)
	dot_reserve_move_unit_seq(dotmarco,23, 25)
	exec_parallel_seq()

	dot_reserve_move_unit_seq(dotNoir2, 27, 24)
	dot_reserve_move_unit_seq(dotLiliana,26, 24)
	dot_reserve_move_unit_seq(dotmarco,25, 25)
	exec_parallel_seq()

	wait_seq()

	
	change_face(Liliana, "Sad")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "悲しみ")
	message("CO_101035_08030002")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101035_08030003")
	close_speech_window()

	bgm_play("BGM_ADV_Invasion2")

	
	on_active(Ef_bar1) 

	local gridpos = get_grid_position(30, 24) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)

	on_active(Ef_bar2) 

	local gridpos = get_grid_position(31, 25) 
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar2)

	wait_time(0.2)
	
	dot_disp_unit(barbaroi1, true) 
	dot_disp_unit(barbaroi2, true) 

	wait_time(2.0)
	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101035_08030005")
	close_speech_window()

	
	open_speech_window("NPCNAME_0250", nil, nil)
	PlayPartVoice("市民_男2", "驚き")
	message("CO_101035_08030006")
	close_speech_window()

	dot_unit_dir(dotNoir2,2)

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101035_08030007")
	close_speech_window()

	
	dot_disp_weapon(dotNoir2, true)

	dot_move_unit_seq(dotNoir2, 29, 24)	
	wait_seq()
	
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotNoir2,0)
	dot_change_anim(barbaroi1,6)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	dot_disp_unit(barbaroi1, false)

	dot_unit_dir(dotLiliana,2)

		
	
	change_face(Liliana, "Anger")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "肯定3")
	message("CO_101035_08030009")
	close_speech_window()

	
	open_speech_window("NPCNAME_0250", nil, nil)
	PlayPartVoice("市民_男2", "悲しみ")
	message("CO_101035_08030010")
	close_speech_window()

	
	change_face(Liliana, "Anger")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	message("CO_101035_08030066")
	close_speech_window()

	move_camera(24, 25, 1.0)
	change_camera_distance(8.0, 1.0)

	dot_move_unit_seq(dotLiliana, 25, 26)	

	wait_seq()

	dot_reserve_move_unit_seq(dotLiliana,24, 26)
	dot_reserve_move_unit_seq(dotmarco,24, 25)
	dot_reserve_move_unit_seq(dotNoir2,30, 25)

	exec_parallel_seq()

	wait_seq()

	dot_move_unit_seq(barbaroi3, 22, 26)	
	wait_seq()

	dot_unit_dir(barbaroi3,3)

	
	local gridpos = get_grid_position(22, 26) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)

	wait_time(0.2)
	
	dot_disp_unit(barbaroi3, true) 

	dot_reserve_move_unit_seq(dotLiliana,25, 26)
	dot_reserve_move_unit_seq(dotmarco,25, 25)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotLiliana,2)
	dot_unit_dir(dotmarco,2)

	
	change_face(Liliana, "Surprise")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "驚き")
	message("CO_101035_08030012")
	close_speech_window()

	
	
	
	wait_time(1.0)

	dot_move_unit_seq(dotmarco, 24, 25)	
	wait_seq()

	dot_disp_weapon(dotmarco, true)

	
	open_speech_window("NPCNAME_0250", nil, nil)
	message("CO_101035_08030014")
	close_speech_window()

	
	change_face(Liliana, "Sad")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	message("CO_101035_08030015")
	close_speech_window()

	
	open_speech_window("NPCNAME_0250", nil, nil)
	PlayPartVoice("市民_男2", "否定")
	message("CO_101035_08030016")
	close_speech_window()

	
	change_face(Liliana, "Sad")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "苦しみ")
	message("CO_101035_08030017")
	

	
	change_face(Liliana, "Anger")
	
	message("CO_101035_08030018")
	close_speech_window()

	
	dot_disp_weapon(dotLiliana, true)
	dot_reserve_move_unit_seq(dotmarco,25, 25)
	dot_reserve_move_unit_seq(dotLiliana,23, 26)

	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotmarco,2)

	
	change_face(Liliana, "Anger")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	message("CO_101035_08030020")
	close_speech_window()

	
	dot_change_anim(dotLiliana,3)
	dot_play_particle_unit(dotLiliana,"Ef_C_Mag_W_Atk01",3,true)

	wait_time(0.4)
	
	dot_change_anim(dotLiliana,0)
	dot_change_anim(barbaroi3,6)
	dot_play_particle_unit(barbaroi3,"Ef_C_Mag_W_Hit01",1,true)

	wait_time(0.5)

	dot_change_anim(barbaroi3,3)
	dot_play_particle_unit(barbaroi3,"Ef_C_Mag_R_Atk01",3,true)

	wait_time(0.4)
	
	dot_change_anim(barbaroi3,0)
	dot_change_anim(dotLiliana,6)
	dot_play_particle_unit(dotLiliana,"Ef_C_Mag_R_Hit01",1,true)

	wait_time(0.5)

	dot_change_anim(dotLiliana,4)
	dot_play_particle_unit(dotLiliana,"Ef_C_Mag_W_Cha01",3,true)

	wait_time(0.5)

	dot_change_anim(dotLiliana,3)
	dot_play_particle_unit(dotLiliana,"Ef_C_Mag_W_Atk01",3,true)

	wait_time(0.4)
	
	dot_change_anim(dotLiliana,0)
	dot_change_anim(barbaroi3,6)
	dot_play_particle_unit(barbaroi3,"Ef_C_Mag_W_Hit01",1,true)

	wait_time(0.4)

	dot_move_unit_seq(barbaroi3, 22, 25)	

	wait_seq()

	dot_unit_dir(barbaroi3,3)
	dot_change_anim(barbaroi3,0)
	dot_change_anim(dotLiliana,0)

	
	
	change_face(Liliana, "Normal")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "激怒")
	message("CO_101035_08030022")
	close_speech_window()

	
	dot_change_anim(barbaroi3,4)
	dot_play_particle_unit(barbaroi3,"Ef_C_Mag_R_Cha01",3,true)

	dot_move_unit_seq(dotLiliana, 24, 25)	

	wait_seq()

	dot_unit_dir(dotLiliana,2)

	
	open_speech_window("NPCNAME_0250", nil, nil)
	PlayPartVoice("市民_男2", "悲しみ")
	message("CO_101035_08030024")
	close_speech_window()

	
	change_face(Liliana, "Normal")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	message("CO_101035_08030025")
	close_speech_window()

	
	dot_change_anim(dotLiliana,6)
	dot_play_particle_unit(dotLiliana,"Ef_C_Mag_R_Hit01",1,true)

	
	fadeout(255,255,255,1.0, FADE_TIME)

	wait_time(TIME_ELAPSED + FADE_TIME)

	
	dot_change_anim(dotLiliana,1)
	dot_remove_unit(barbaroi1)
	dot_remove_unit(barbaroi2)
	dot_place_unit(dotDinatan, 30, 24)
	dot_place_unit(dotClare1, 30, 25)
	dot_place_unit(dotNoir2, 29, 24)
	dot_disp_unit(dotDinatan, true)
	dot_disp_unit(dotClare1, true)
	dot_change_anim(barbaroi3,0)
	dot_disp_weapon(dotLiliana, false)

	fadein(FADE_TIME)

	wait_time(FADE_TIME)
	
	
	
	dot_reserve_move_unit_seq(dotNoir2,24, 26)
	dot_reserve_move_unit_seq(dotDinatan,25, 26)
	dot_reserve_move_unit_seq(dotClare1,24, 27)

	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotClare1,2)

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "怒り")
	message("CO_101035_08030027")
	close_speech_window()

	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("CO_101035_08030028")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101035_08030029")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotNoir2,23, 26)
	dot_reserve_move_unit_seq(dotClare1,23, 27)
	exec_parallel_seq()
	
	dot_reserve_move_unit_seq(dotNoir2,23, 25)
	dot_reserve_move_unit_seq(dotClare1,23, 26)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotClare1,2)

	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotNoir2,0)
	dot_change_anim(barbaroi3,6)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)

	dot_reserve_move_unit_seq(dotClare1,21, 27)
	dot_reserve_move_unit_seq(dotNoir2,21, 26)
	exec_parallel_seq()
	dot_reserve_move_unit_seq(dotClare1,21, 32)
	dot_reserve_move_unit_seq(dotNoir2,21, 31)
	dot_reserve_move_unit_seq(barbaroi3,21, 30)
	dot_reserve_move_unit_seq(dotDinatan,24, 26)

	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotDinatan,3)
	dot_remove_unit(barbaroi3)
	dot_disp_weapon(dotmarco, false)
	dot_disp_weapon(dotClare1, false)
	dot_disp_weapon(dotNoir2, false)

	
	
	move_camera(24, 25, 1.0)

	wait_camera()


	bgm_play("Stop_BGM_Bus_MidFade")
	
	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("CO_101035_08030031")
	close_speech_window()

	bgm_play("BGM_Area_Acoustic")
	
	change_face(Liliana, "Sad")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "苦しみ")
	message("CO_101035_08030032")
	close_speech_window()

	dot_change_anim(dotLiliana,0)

	
	dot_reserve_move_unit_seq(dotNoir2,22, 25)
	dot_reserve_move_unit_seq(dotClare1,22, 26)
	exec_parallel_seq()

	dot_reserve_move_unit_seq(dotNoir2,23, 25)
	dot_reserve_move_unit_seq(dotClare1,23, 26)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotClare1,3)

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	PlayPartVoice("クレア", "笑い")
	message("CO_101035_08030034")
	

	
	
    CO_101035_0803_select1()
 
    open_select_window_tag(Noir2, "Normal", "CO_101035_08030036", "CO_101035_08030037")  
	close_speech_window()

  if is_select(1) then            
        CO_101035_0803_select1_1()

    else                            
        CO_101035_0803_select1_2()

    end
    CO_101035_0803_end() 
 
end
 
function CO_101035_0803_select1()
 
end
 
function CO_101035_0803_select1_1()
 

 
	

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "悲しみ")
	message("CO_101035_08030039")
	

	
	change_face(Noir2, "Normal")
	
	message("CO_101035_08030040")
	close_speech_window()

	dot_unit_dir(dotLiliana,2)

	
	change_face(Liliana, "Sad")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "肯定3")	
	message("CO_101035_08030041")
	

	
	change_face(Liliana, "Normal")
	
	message("CO_101035_08030042")
	

	
	change_face(Liliana, "Sad")
	
	message("CO_101035_08030048")
	close_speech_window()
 
      
end
 
function CO_101035_0803_select1_2()
 

 
	

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101035_08030044")
	close_speech_window()

	dot_unit_dir(dotLiliana,2)

	
	change_face(Liliana, "Sad")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "肯定3")
	message("CO_101035_08030045")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	PlayPartVoice("ディナタン", "肯定2")
	message("CO_101035_08030046")
	close_speech_window()
 
 	
	change_face(Liliana, "Sad")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	
	message("CO_101035_08030048")
	close_speech_window()

    
end
 
function CO_101035_0803_end()


	


	
	open_speech_window("NPCNAME_0250", nil, nil)
	PlayPartVoice("市民_男2", "否定")

	message("CO_101035_08030049")
	

	dot_unit_dir(dotLiliana,3)

	
	
	message("CO_101035_08030050")
	

	
	
	message("CO_101035_08030051")
	close_speech_window()

	
	change_face(Liliana, "Normal")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	message("CO_101035_08030052")
	close_speech_window()

	
	dot_unit_dir(dotLiliana,3)

	wait_time(0.2)
	
	dot_unit_dir(dotLiliana,2)

	wait_time(0.2)

	dot_unit_dir(dotLiliana,3)

	wait_time(0.2)
	
	dot_unit_dir(dotLiliana,2)

	wait_time(0.2)

	
	change_face(Liliana, "Shy")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	PlayPartVoice("リリアーナ", "悲しみ")
	message("CO_101035_08030054")
	

	
	change_face(Liliana, "Shy")
	
	message("CO_101035_08030055")
	close_speech_window()

	
	
	dot_reserve_move_unit_seq(dotLiliana,26, 25)

	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotmarco,3)
	dot_unit_dir(dotDinatan,3)

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101035_08030057")
	close_speech_window()

	dot_unit_dir(dotLiliana,2)

	
	change_face(Liliana, "Shy")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	message("CO_101035_08030058")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101035_08030059")
	close_speech_window()

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	PlayPartVoice("クレア", "肯定")
	message("CO_101035_08030060")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101035_08030061")
	close_speech_window()

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("CO_101035_08030062")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotmarco,26, 24)
	dot_reserve_move_unit_seq(dotClare1,25, 24)
	dot_reserve_move_unit_seq(dotDinatan,25, 25)

	exec_parallel_seq()
	wait_seq()


	dot_reserve_move_unit_seq(dotLiliana,33, 25)
	dot_reserve_move_unit_seq(dotmarco, 33, 24)
	dot_reserve_move_unit_seq(dotDinatan,32, 25)
	dot_reserve_move_unit_seq(dotClare1,32, 24)

	exec_parallel_seq()

	move_camera(23, 25, 1.0)

	wait_seq()

	wait_camera()
	
	wait_time(0.3)	

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101035_08030064")
	

	
	change_face(Noir2, "Smile")
	
	message("CO_101035_08030065")
	close_speech_window()



	local trustParam2 = set_communication_rankup("リリアーナ_コミュランク", "リリアーナ_親密度")    
	trustParam2.UpdateRankup()    
	open_trust_rank_up(Liliana, trustParam2)    
	

	
	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 23, 25,0)
	pbadv_setup_101035_Liliana_preload(0,true, 22, 25,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 31, 26,0)
	pbadv_setup_101025_Clare_preload(1,true, 32, 26,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	preload_sound("BGM_ADV_Invasion2")
	preload_sound("BGM_Area_Acoustic")
end
