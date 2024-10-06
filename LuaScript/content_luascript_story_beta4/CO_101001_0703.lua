
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(1,1) 


	
	pbadv_setup_101009_Noir(2,true, 22, 25,0)  
	pbadv_setup_101001_Tyrfing(0,true, 21, 24,0)  

	
	syoujo = dot_reserve_ally(401011001, 21,  25, 0)
	dot_set_weapon(syoujo, 101010005)		
	
	
	sanzoku1 = dot_reserve_ally(401041001, 23,  25, 0)
	dot_set_weapon(sanzoku1, 101010005)		
	sanzoku2 = dot_reserve_ally(401041001, 19,  24, 0)
	dot_set_weapon(sanzoku2, 101010005)		
	sanzoku3 = dot_reserve_ally(401041001, 14,  25, 0)
	dot_set_weapon(sanzoku3, 101010005)		
	sanzoku4 = dot_reserve_ally(401041001, 25,  27, 0)
	dot_set_weapon(sanzoku4, 101010005)		

setup_complete_unit()


	
	dot_unit_dir(sanzoku1, 2)
	dot_unit_dir(sanzoku4, 2)

	
	
	dot_disp_weapon(syoujo, false)



	


	
	dot_change_anim(sanzoku2,1)
	dot_change_anim(sanzoku4,1)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(40.0, 0.0)
	move_camera(22, 25, 0.0)

	load_sound("BGM_Area_Acoustic")
end



function Play()
	fadein(0)
	Play_start(true)
	

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "気合い")
	message("CO_101001_07030002")
	close_speech_window()
	
	
	dot_attack_seq(dotNoir2, sanzoku1)
	dot_damage_seq(sanzoku1, dotNoir2, true)
	
		
	wait_seq()
	
	
	dot_move_knockback(sanzoku1, 25, 25,0.3,2)
	
	
	wait_time(0.5)
	
	
	dot_change_anim(sanzoku1,1)
	dot_change_anim(dotNoir2,0)

	
	open_speech_window("NPCNAME_0283", nil, nil)
	message("CO_101001_07030004")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101001_07030006")
	
	change_face(Noir2, "Normal")
	message("CO_101001_07030007")
	close_speech_window()

	dot_unit_dir(dotTyrfing, 2)

	
	change_face(Tyrfing, "Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing, nil)
	message("CO_101001_07030008")
	close_speech_window()
	
	
	move_camera(19, 25, 0.5)
	wait_camera()
	
	
	dot_unit_dir(syoujo, 2)
	dot_unit_dir(dotNoir2, 2)

	
	open_speech_window("NPCNAME_0283", nil, nil)
	PlayPartVoice("山賊", "喜び")
	message("CO_101001_07030010")
	close_speech_window()

	
	dot_move_unit_seq(sanzoku3, 18, 25)
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101001_07030012")
	close_speech_window()

	
	dot_move_unit_seq(dotTyrfing, 20, 24)
	
	
	wait_seq()
	
	
	change_face(Tyrfing, "Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing, nil)
	message("CO_101001_07030013")
	close_speech_window()
	
	
	
	dot_move_unit_seq(dotNoir2, 19, 25)
	
	wait_seq()
	
	
	dot_attack_seq(dotNoir2, sanzoku3)
	dot_damage_seq(sanzoku3, dotNoir2, true)
	
		
	wait_seq()
	
	
	dot_move_knockback(sanzoku3, 16, 25,0.3,2)
	
	
	wait_time(0.5)
	
	
	dot_unit_dir(dotTyrfing, 2)
	
	
	dot_change_anim(sanzoku3,1)

	
	open_speech_window("NPCNAME_0283", nil, nil)
	PlayPartVoice("山賊", "苦しみ")
	message("CO_101001_07030015")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")

	
	change_face(Tyrfing, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing, nil)
	PlayPartVoice("ティルフィング", "挨拶")
	message("CO_101001_07030017")
	close_speech_window()
	
	
	dot_unit_dir(dotNoir2, 3)
	
	dot_change_anim(dotNoir2,0)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101001_07030018")
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotTyrfing, false)
	
	bgm_play("BGM_Area_Acoustic")
	
	change_face(Noir2, "Normal")
	message("CO_101001_07030020")
	close_speech_window()

	
	open_speech_window("NPCNAME_0359", nil, nil)
	PlayPartVoice("市民_男2", "肯定3")
	message("CO_101001_07030022")
	close_speech_window()

	
	change_face(Tyrfing, "Smile")
	open_speech_window("CHRNAME_TYRFING", Tyrfing, nil)
	PlayPartVoice("ティルフィング", "笑い")	
	message("CO_101001_07030024")
	close_speech_window()

	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "笑い")	
	message("CO_101001_07030026")
	
	change_face(Noir2, "Smile")
	message("CO_101001_07030027")
	close_speech_window()

	
	change_face(Tyrfing, "Smile")
	open_speech_window("CHRNAME_TYRFING", Tyrfing, nil)
	PlayPartVoice("ティルフィング", "肯定")
	message("CO_101001_07030028")
	close_speech_window()

	
	open_speech_window("NPCNAME_0359", nil, nil)
	message("CO_101001_07030030")
	close_speech_window()

	
	change_face(Tyrfing, "Surprise")
	open_speech_window("CHRNAME_TYRFING", Tyrfing, nil)
	PlayPartVoice("ティルフィング", "驚き")	
	message("CO_101001_07030031")
	close_speech_window()



	
	open_speech_window("NPCNAME_0359", nil, nil)
	PlayPartVoice("市民_男2", "喜び")
	message("CO_101001_07030032")
	
	message("CO_101001_07030033")
	
	message("CO_101001_07030046")
	close_speech_window()



	
	change_face(Tyrfing, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing, nil)
	PlayPartVoice("ティルフィング", "悩む")		
	message("CO_101001_07030035")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "照れ")
	message("CO_101001_07030037")
	close_speech_window()

	
	open_speech_window("NPCNAME_0086", nil, nil)
	message("CO_101001_07030039")
	close_speech_window()
	
	

	dot_unit_dir(dotTyrfing, 3)
	dot_unit_dir(syoujo, 3)

	
	open_speech_window("NPCNAME_0359", nil, nil)
	PlayPartVoice("市民_男2", "肯定3")
	message("CO_101001_07030040")
	
	
	dot_unit_dir(syoujo, 2)	
	
	
	message("CO_101001_07030047")
	close_speech_window()

	
	dot_move_unit_seq(syoujo, 22, 33)
	
	
	wait_seq()
	
	
	dot_unit_dir(dotTyrfing, 2)

	
	change_face(Tyrfing, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing, nil)
	PlayPartVoice("ティルフィング", "挨拶")	
	message("CO_101001_07030042")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101001_07030043")
	close_speech_window()
	
	
	dot_move_unit_seq(dotTyrfing, 22, 34)
	
	
	wait_seq()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101001_07030045")
	close_speech_window()

	local trustParam2 = set_communication_rankup("ティルフィング_コミュランク", "ティルフィング_親密度")	
	trustParam2.UpdateRankup()	
	open_trust_rank_up(Tyrfing, trustParam2)	
	

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 22, 25,0)
	pbadv_setup_101001_Tyrfing_preload(0,true, 21, 24,0)
	preload_sound("BGM_Area_Acoustic")
end
