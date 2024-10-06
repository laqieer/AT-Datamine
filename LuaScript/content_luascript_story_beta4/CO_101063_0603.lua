

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	setup_101063_Christina(nil, nil, 0, false)
	
	
	
	init_psbattleadv("201000000", "201000000")
	
	change_time_and_weather(1,1)
	
	
	
	 
    pbadv_setup_101009_Noir(2,true,11,32,0)
    
    pbadv_setup_101063_Christina(true, 10, 33,0)

	
	merchant = dot_reserve_ally(401011001 , 19, 33, 0)
	
	
	
	dot_set_weapon(merchant, 101010001)
	
	

	
	
	
	setup_complete_unit()
	
	
	
	dot_unit_dir(merchant, 3)

	
	
	
	dot_disp_weapon(dotChristina, false)
	dot_disp_weapon(merchant, false)
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(20, 34, 0.0)
	
	
end





function Play()
	fadein(0)
	Play_start(true)


	
	CO_101063_0603_select1()
	open_select_window_tag(Noir2, "Normal", "CO_101063_06030026", "CO_101063_06030027")	
	
	
	if is_select(1) then			
		CO_101063_0603_select1_1()
		
	elseif is_select(2) then		
		CO_101063_0603_select1_2()
		

	end
	

	CO_101063_0603_end()


	end

	
	function CO_101063_0603_select1()
	
	
	
	dot_reserve_move_unit_seq(dotNoir2, 19, 32, 1.0)
	dot_reserve_move_unit_seq(dotChristina, 18, 33,1.0)
	dot_reserve_move_unit_seq(merchant, 22, 33, 0.5)
	exec_parallel_seq()
	
	
	change_face(Noir2, "Anger")	
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "怒り")
	message("CO_101063_06030002")
	close_speech_window()

	
	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "激怒")
	message("CO_101063_06030004")
	close_speech_window()

	wait_seq()	
	dot_unit_dir(merchant, 2)
	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "驚き")
	message("CO_101063_06030006")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "激怒")
	message("CO_101063_06030007")
	close_speech_window()

	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "照れ")
	message("CO_101063_06030008")
	

	
	
	message("CO_101063_06030009")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "怒り")
	message("CO_101063_06030010")
	close_speech_window()

	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "納得")
	message("CO_101063_06030011")
	

	
	
	PlayPartVoice("市民_男1", "否定")
	message("CO_101063_06030012")
	close_speech_window()
	
	dot_reserve_move_unit_seq(merchant, 35, 29, 1.5)
	exec_parallel_seq()

	
	
	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "激怒")
	message("CO_101063_06030014")
	close_speech_window()
	
	
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "怒り")
	message("CO_101063_06030015")
	close_speech_window()
	
	dot_reserve_move_unit_seq(dotNoir2, 26, 29, 1.5)
	dot_reserve_move_unit_seq(dotChristina, 25, 29, 1.0)
	exec_parallel_seq()
	
	
	
	fadeout(0,0,0,0,1.0)
	wait_time(1.0)
	wait_seq()
	dot_place_unit(dotChristina, 25, 30)
	dot_place_unit(dotNoir2, 35, 30)
	dot_place_unit(merchant, 35, 29)
	dot_unit_dir(merchant, 1)
	dot_disp_weapon(merchant, true)
	dot_unit_dir(dotNoir2, 0)
	move_camera(35, 30, 0.0)
	fadein(1.0)
	wait_time(1.0)

	
	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "激怒")
	message("CO_101063_06030017")
	close_speech_window()
	
	dot_change_anim(merchant,2)
	dot_play_particle_unit(merchant,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(merchant,0)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(dotNoir2,6)
	dot_move_knockback(dotNoir2,35, 31,0.2,2)
	wait_time(0.5)
	dot_change_anim(dotNoir2,0)
	
	
	change_face(Noir2, "Pain")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "苦しみ")
	message("CO_101063_06030018")
	close_speech_window()
	
	dot_move_unit_seq(dotChristina,34, 29)

	
	
	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "気合い")
	message("CO_101063_06030020")
	close_speech_window()
	
	
	wait_seq()
	dot_change_anim(dotChristina,3)
	dot_play_particle_unit(dotChristina,"Ef_C_Spr_N_Atk01",3,true)
	dot_play_particle_unit(merchant,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_change_anim(merchant,6)
	dot_unit_dir(merchant, 2)
	dot_move_knockback(merchant,38, 29,0.4,2)
	wait_time(0.4)
	dot_change_anim(dotChristina,0)
	dot_change_anim(merchant,1)

	
	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "苦しみ")
	message("CO_101063_06030022")
	close_speech_window()

	
	
	
	change_face(Christina, "Sad")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "悲しみ")
	message("CO_101063_06030024")
	
	
	end

	function CO_101063_0603_select1_1()
	
	dot_move_unit_seq(dotNoir2,35, 30)

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101063_06030029")
	

	
	
	message("CO_101063_06030030")
	

	
	
	message("CO_101063_06030031")
	close_speech_window()

	
	
	
	
	change_face(Christina, "Surprise")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "驚き")
	message("CO_101063_06030032")
	

	
	
	message("CO_101063_06030033")
	close_speech_window()
	
	end


	function CO_101063_0603_select1_2()
	
	dot_move_unit_seq(dotNoir2,35, 30)

	
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101063_06030035")
	close_speech_window()

	
	
	
	
	change_face(Christina, "Smile")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "笑い")
	message("CO_101063_06030036")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101063_06030037")
	close_speech_window()

	
	change_face(Christina, "Surprise")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "驚き")
	message("CO_101063_06030038")
	close_speech_window()

	end


	function CO_101063_0603_end()
	
	dot_change_anim(merchant,0)
	
	
	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "照れ")
	message("CO_101063_06030040")
	
	
	dot_move_unit_seq(merchant,38, 29)

	
	
	message("CO_101063_06030041")
	
	
	dot_move_unit_seq(merchant,37, 29)

	
	
	message("CO_101063_06030042")
	
	
	dot_move_unit_seq(merchant,35, 29)

	
	
	message("CO_101063_06030043")
	close_speech_window()

	
	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "激怒")
	message("CO_101063_06030045")
	close_speech_window()
	
	dot_change_anim(dotChristina,3)
	dot_play_particle_unit(dotChristina,"Ef_C_Spr_N_Atk01",3,true)
	dot_change_anim(merchant,6)
	dot_unit_dir(merchant, 2)
	dot_play_particle_unit(merchant,"Ef_C_Cmn_N_Hit_Str01",1,true)
	dot_move_knockback(merchant,38, 29,0.4,2)
	wait_time(0.4)
	dot_change_anim(dotChristina,0)
	dot_change_anim(merchant,1)

	
	
	
	change_face(Christina, "Normal")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	message("CO_101063_06030047")
	close_speech_window()

	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("CO_101063_06030049")
	close_speech_window()

	
	
	change_face(Christina, "Normal")
	open_speech_window("CHRNAME_CHRISTINA",Christina, nil)
	PlayPartVoice("クリスティーナ", "否定")
	message("CO_101063_06030051")
	

	
	
	message("CO_101063_06030052")
	

	
	
	PlayPartVoice("クリスティーナ", "笑い")
	message("CO_101063_06030053")
	close_speech_window()


	local trustParam2 = set_communication_rankup("クリスティーナ_コミュランク", "クリスティーナ_親密度")    
	trustParam2.UpdateRankup()    
	open_trust_rank_up(Christina, trustParam2)    
	

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup_101063_Christina_preload(nil, nil, 0, false)
    pbadv_setup_101009_Noir_preload(2,true,11,32,0)
    pbadv_setup_101063_Christina_preload(true, 10, 33,0)
end
