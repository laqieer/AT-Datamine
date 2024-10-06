

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	setup_101063_Christina(nil, nil, 0, false)
	
	
	
	init_psbattleadv("201000000", "201000000")
	
	
	
	 
    pbadv_setup_101009_Noir(2,true,2,19,0)
    
    pbadv_setup_101063_Christina(true, 1, 19,0)

	
	merchant = dot_reserve_ally(401011001 , 5, 10, 0)
	thief = dot_reserve_ally(401041001, 4, 12, 0)
	thief2 = dot_reserve_ally(401041001, 7, 8, 0)
	student  = dot_reserve_ally(401006001, 1, 21, 0)
	student2 = dot_reserve_ally(401006001, 3, 21, 0)
	studentM = dot_reserve_ally(401005001, 2, 21, 0)
	
	
	dot_set_weapon(merchant, 101010001)
	dot_set_weapon(thief, 101010001)
	dot_set_weapon(thief2, 101010001)
	dot_set_weapon(student, 108010001)
	dot_set_weapon(student2, 105010001)
	dot_set_weapon(studentM, 104010001)
	
	
	
	
	setup_complete_unit()
	

	
	dot_unit_dir(merchant, 2)
	dot_unit_dir(thief2, 2)
	dot_unit_dir(thief, 2)

	
	
	dot_disp_weapon(dotChristina, false)
	dot_disp_weapon(merchant, false)

	

	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(2, 22, 0.0)
	
	
	FriendshipUp = set_friendship_up(false)        
	trustParam = set_communication("クリスティーナ_コミュランク", "クリスティーナ_親密度")    

	load_sound("BGM_Area_Acoustic")
end





function Play()
	fadein(0)
	Play_start(true)


	
	CO_101063_0903_select1()
	open_select_window_tag(Noir2, "Normal", "CO_101063_09030019", "CO_101063_09030020")	


	
	trustParam.UpdateRankup()    
	
	if is_select(1) then			
		CO_101063_0903_select1_1()
		
	elseif is_select(2) then		
		CO_101063_0903_select1_2()
		

	end
	

	CO_101063_0903_end()


	end

	
	function CO_101063_0903_select1()

	
	
	
	
	change_face(Christina, "Sad")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	message("CO_101063_09030002")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101063_09030003")
	close_speech_window()
	
	move_camera(5, 11, 1.0)

	
	
	
	open_speech_window("NPCNAME_0207",nil , nil)
	PlayPartVoice("山賊", "照れ")
	message("CO_101063_09030005")
	close_speech_window()

	
	open_speech_window("NPCNAME_0208",nil , nil)
	message("CO_101063_09030006")
	close_speech_window()

	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "笑い")
	message("CO_101063_09030007")
	

	
	
	message("CO_101063_09030008")
	close_speech_window()
	
	dot_move_unit_seq(merchant,16, 9)
	
	dot_reserve_move_unit_seq(dotNoir2,5,15)
	dot_reserve_move_unit_seq(dotChristina,4,15)
	
	dot_reserve_move_unit_seq(student,3,17)
	dot_reserve_move_unit_seq(student2,4,17)
	dot_reserve_move_unit_seq(studentM,5,17)
	exec_parallel_seq()
	wait_seq()

	move_camera(4, 14, 1.0)
	wait_camera()
	
	
	
	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "激怒")
	message("CO_101063_09030010")
	close_speech_window()

	
	open_speech_window("NPCNAME_0207",nil , nil)
	PlayPartVoice("山賊", "驚き")
	message("CO_101063_09030011")
	

	
	
	message("CO_101063_09030012")
	close_speech_window()

	
	open_speech_window("NPCNAME_0208",nil , nil)
	message("CO_101063_09030013")
	close_speech_window()

	
	
	
	open_speech_window("NPCNAME_0146",nil , nil)
	PlayPartVoice("女子2", "驚き")
	message("CO_101063_09030015")
	close_speech_window()

	
	
	open_speech_window("NPCNAME_0147",nil , nil)
	PlayPartVoice("女子1", "悲しみ")
	message("CO_101063_09030017")
	
	
	
	end

	function CO_101063_0903_select1_1()

	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "怒り")
	message("CO_101063_09030022")
	

	
	
	message("CO_101063_09030023")
	close_speech_window()

	
	
	
	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "肯定3")
	message("CO_101063_09030024")
	

	
	
	message("CO_101063_09030025")
	close_speech_window()
	
	end


	function CO_101063_0903_select1_2()

	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "怒り")
	message("CO_101063_09030027")
	close_speech_window()

	
	
	
	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "否定")
	message("CO_101063_09030028")
	

	
	
	message("CO_101063_09030029")
	close_speech_window()
	
	end


	function CO_101063_0903_end()
	
	dot_move_unit_seq(merchant,5, 13)
	wait_seq()

	
	
	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "笑い")
	message("CO_101063_09030031")
	close_speech_window()
	
	dot_move_unit_seq(thief2,5,11)
	wait_seq()
	
	dot_unit_dir(thief2, 2)

	
	open_speech_window("NPCNAME_0207",nil , nil)
	PlayPartVoice("山賊", "笑い")
	message("CO_101063_09030032")
	close_speech_window()
	
	dot_move_unit_seq(thief,3,13)
	dot_unit_dir(thief, 3)
	
	
	open_speech_window("NPCNAME_0208",nil , nil)
	message("CO_101063_09030033")
	close_speech_window()

	
	open_speech_window("NPCNAME_0267",nil , nil)
	PlayPartVoice("市民_男1", "納得")
	message("CO_101063_09030034")
	

	
	
	message("CO_101063_09030035")
	close_speech_window()

	
	open_speech_window("NPCNAME_0208",nil , nil)
	message("CO_101063_09030036")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "怒り")
	message("CO_101063_09030037")
	close_speech_window()

	
	open_speech_window("NPCNAME_0207",nil , nil)
	PlayPartVoice("山賊", "喜び")
	message("CO_101063_09030038")
	close_speech_window()

	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	message("CO_101063_09030039")
	close_speech_window()

	
	open_speech_window("NPCNAME_0208",nil , nil)
	message("CO_101063_09030040")
	close_speech_window()

	
	
	change_face(Christina, "Anger")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "激怒")
	message("CO_101063_09030042")
	close_speech_window()
	
	dot_move_unit_seq(dotChristina,4, 13)
	wait_seq()
	dot_unit_dir(dotChristina, 2)
	dot_change_anim(dotChristina,3)
	dot_play_particle_unit(dotChristina,"Ef_C_Spr_N_Atk01",3,true)
	dot_change_anim(thief,1)
	dot_play_particle_unit(thief,"Ef_C_Cmn_N_Hit_Str01",1,true)
	dot_move_knockback(thief,0, 13,0.3,2)
	wait_seq()
	dot_change_anim(thief,1)
	wait_time(0.8)
	dot_unit_dir(dotChristina, 3)
	wait_time(0.2)
	dot_change_anim(dotChristina,3)
	dot_play_particle_unit(dotChristina,"Ef_C_Spr_N_Atk01",3,true)
	dot_change_anim(merchant,1)
	dot_play_particle_unit(merchant,"Ef_C_Cmn_N_Hit_Str01",1,true)
	dot_move_knockback(merchant,8, 13,0.3,2)
	wait_seq()
	dot_change_anim(merchant,1)
	wait_seq()
	dot_change_anim(dotChristina,0)
	
	

	
	
	
	open_speech_window("NPCNAME_0146",nil , nil)
	PlayPartVoice("女子2", "驚き")
	message("CO_101063_09030044")
	close_speech_window()

	
	open_speech_window("NPCNAME_0001",nil , nil)
	PlayPartVoice("男子1", "驚き")
	message("CO_101063_09030045")
	close_speech_window()

	bgm_play("BGM_Area_Acoustic")
	
	open_speech_window("NPCNAME_0207",nil , nil)
	message("CO_101063_09030046")
	close_speech_window()


	dot_move_unit_seq(thief2,18, 8)
	
	
	
	
	change_face(Christina, "Normal")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "挨拶")
	message("CO_101063_09030048")
	

	
	change_face(Christina, "Anger")
	
	message("CO_101063_09030049")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101063_09030050")
	close_speech_window()

	
	change_face(Christina, "Smile")
	open_speech_window("CHRNAME_CHRISTINA",Christina , nil)
	PlayPartVoice("クリスティーナ", "笑い")
	message("CO_101063_09030051")
	close_speech_window()
	
	dot_move_unit_seq(dotChristina,20, 8)

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101063_09030052")
	close_speech_window()
	
	
	wait_seq()
	
	
	
	dot_disp_unit(thief2, false)
	dot_disp_unit(dotChristina, false)


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
    pbadv_setup_101009_Noir_preload(2,true,2,19,0)
    pbadv_setup_101063_Christina_preload(true, 1, 19,0)
	preload_sound("BGM_Area_Acoustic")
end
