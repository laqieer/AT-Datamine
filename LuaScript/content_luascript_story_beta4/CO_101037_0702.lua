
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(1,1) 

	
	pbadv_setup_101009_Noir(2,true, 11, 32,0)  
	pbadv_setup_101037_Rasia(0,true, 10, 33,0) 
	
	
	roujin = dot_reserve_ally(401011001, 13,  32, 0)
	dot_set_weapon(roujin, 101010005)		
	
	barbaroi1 = dot_reserve_enemy(1, 12, 32, 0)


setup_complete_unit()


	
	dot_unit_dir(roujin, 2)
	dot_unit_dir(barbaroi1, 3)



	

	dot_disp_weapon(dotRasia, false)
	dot_disp_weapon(roujin, false)

	



	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(40.0, 0.0)
	move_camera(21, 32, 0.0)

	load_sound("BGM_Area_Acoustic")
	load_sound("BGM_ADV_Reconnaissance")
	
end



function Play()
	fadein(0)
	Play_start(true)
	
	
	dot_reserve_move_unit_seq(roujin, 23,32)
	dot_reserve_move_unit_seq(barbaroi1, 21,32)	
	exec_parallel_seq()
	wait_seq()
	
	
	wait_time(0.3)
	dot_unit_dir(roujin, 2)
	
	
	open_speech_window("NPCNAME_0177", nil, nil)
	PlayPartVoice("市民_男2", "悲しみ")
	message("CO_101037_07020002")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")
	
	
	dot_reserve_move_unit_seq(dotNoir2, 20, 32)
	
	exec_parallel_seq()
	wait_seq()

	
	dot_attack_seq(dotNoir2, barbaroi1)
	dot_damage_seq(barbaroi1, dotNoir2, true)
	
		
	wait_seq()
	
	
	dot_change_anim(barbaroi1,6)

	wait_time(0.2)

	dot_dying_unit_seq(barbaroi1)

	wait_seq()
	
	
	dot_reserve_move_unit_seq(dotRasia, 19, 33)
	
	exec_parallel_seq()
	wait_seq()
	
	
	dot_change_anim(dotNoir2,0)
	dot_disp_weapon(dotNoir2, false)
	
	
	wait_time(0.3)

	bgm_play("BGM_Area_Acoustic")
	
	change_face(Rasia, "Normal")
	open_speech_window("CHRNAME_RASIA", Rasia, nil)
	PlayPartVoice("ラシア", "挨拶")
	message("CO_101037_07020004")
	close_speech_window()

	
	open_speech_window("NPCNAME_0177", nil, nil)
	PlayPartVoice("市民_男2", "喜び")
	message("CO_101037_07020005")
	
	message("CO_101037_07020006")
	
	message("CO_101037_07020007")
	
	message("CO_101037_07020009")
	close_speech_window()

	
	change_face(Rasia, "Normal")
	open_speech_window("CHRNAME_RASIA", Rasia, nil)
	PlayPartVoice("ラシア", "肯定")
	message("CO_101037_07020010")
	close_speech_window()

	bgm_play("BGM_ADV_Reconnaissance")

	
	open_speech_window("NPCNAME_0177", nil, nil)
	PlayPartVoice("市民_男2", "落胆")
	message("CO_101037_07020013")
	
	message("CO_101037_07020014")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "納得")
	message("CO_101037_07020015")
	close_speech_window()

	
	open_speech_window("NPCNAME_0177", nil, nil)
	PlayPartVoice("市民_男2", "肯定2")
	message("CO_101037_07020016")
	
	message("CO_101037_07020017")
	
	message("CO_101037_07020018")
	close_speech_window()

	
	change_face(Rasia, "Sad")
	open_speech_window("CHRNAME_RASIA", Rasia, nil)
	PlayPartVoice("ラシア", "挨拶")
	message("CO_101037_07020019")
	close_speech_window()

	
	open_speech_window("NPCNAME_0177", nil, nil)
	PlayPartVoice("市民_男2", "肯定3")
	message("CO_101037_07020020")
	close_speech_window()

	
	change_face(Rasia, "Sad")
	open_speech_window("CHRNAME_RASIA", Rasia, nil)
	message("CO_101037_07020021")
	
	change_face(Rasia, "Sad")
	message("CO_101037_07020022")
	close_speech_window()

	
	open_speech_window("NPCNAME_0177", nil, nil)
	PlayPartVoice("市民_男2", "悩む")
	message("CO_101037_07020023")
	
	message("CO_101037_07020025")
	close_speech_window()

	
	change_face(Rasia, "Sad")
	open_speech_window("CHRNAME_RASIA", Rasia, nil)
	PlayPartVoice("ラシア", "悲しみ")
	message("CO_101037_07020026")
	close_speech_window()

	
	open_speech_window("NPCNAME_0177", nil, nil)
	message("CO_101037_07020027")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(roujin, 32, 32)
	
	exec_parallel_seq()
	wait_seq()	

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101037_07020029")
	close_speech_window()

	
	change_face(Rasia, "Sad")
	open_speech_window("CHRNAME_RASIA", Rasia, nil)
	PlayPartVoice("ラシア", "落胆")
	message("CO_101037_07020030")
	close_speech_window()

	
	fadeout(0,0,0,0,1.0)
	reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ7_3")

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 11, 32,0)
	pbadv_setup_101037_Rasia_preload(0,true, 10, 33,0)
	preload_sound("BGM_Area_Acoustic")
	preload_sound("BGM_ADV_Reconnaissance")
end
