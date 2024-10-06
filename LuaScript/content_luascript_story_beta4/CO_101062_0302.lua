
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")	
Include("content_luascript_common","DemoCommonPack")	

function Load()
	Load_common(true)
	
	setup_101062_Maril()

	init_psbattleadv("201020000", "201020000") 
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)


	pbadv_setup_101009_Noir(2,true, 17, 33,0)  

	

	dotMaril = dot_reserve_ally(101062001, 16, 34, 0) 
	dot_set_weapon(dotMaril, 101030001)


	dotBand1 = dot_reserve_ally(401041001, 32, 25, 0) 
	dotBand2 = dot_reserve_ally(401041001, 33, 25, 0) 
	dotBand3 = dot_reserve_ally(401041001, 34, 25, 0) 
	dot_set_weapon(dotBand1, 101030001)
	dot_set_weapon(dotBand2, 101030001)
	dot_set_weapon(dotBand3, 101030001)

	setup_complete_unit() 


	dot_disp_unit(dotBand1, false)
	dot_disp_unit(dotBand2, false)
	dot_disp_unit(dotBand3, false)
	

	dot_unit_dir(dotBand1, 2)
	dot_unit_dir(dotBand2, 2)
	dot_unit_dir(dotBand3, 2)
	dot_unit_dir(dotNoir2, 2)



	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotMaril,false)


	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(16, 33, 0.0)
	
end


function Play()
	fadein(0)
	Play_start(true)



	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101062_03020002")
	close_speech_window()

	
	change_face(Maril, "Normal")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "肯定")
	message("CO_101062_03020003")

	
	change_face(Maril, "Smile")
	message("CO_101062_03020004")
	close_speech_window()




	dot_reserve_move_unit_seq(dotNoir2, 20, 28)
	dot_reserve_move_unit_seq(dotMaril, 21, 27)
	
	
	exec_parallel_seq()

	fadeout(0,0,0,1.0, FADE_TIME)

	wait_time(TIME_ELAPSED + FADE_TIME)

	move_camera(24, 27, 0.0)
	
	fadein(FADE_TIME)

	wait_time(FADE_TIME)

	
	wait_seq()



	move_camera(24, 27, 2.0)

	dot_reserve_move_unit_seq(dotNoir2, 22, 28)
	dot_reserve_move_unit_seq(dotMaril, 23, 27)
	
	
	exec_parallel_seq()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101062_03020006")

	
	PlayPartVoice("ノワール", "悩む")
	message("CO_101062_03020007")
	close_speech_window()

	
	wait_seq()

	dot_unit_dir(dotMaril, 2)

	
	change_face(Maril, "Normal")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "挨拶")
	message("CO_101062_03020008")

	
	change_face(Maril, "Smile")
	message("CO_101062_03020009")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101062_03020010")
	close_speech_window()

	dot_disp_unit(dotBand1, true)
	dot_disp_unit(dotBand2, true)
	dot_disp_unit(dotBand3, true)

	dot_reserve_move_unit_seq(dotBand1, 25, 26)
	dot_reserve_move_unit_seq(dotBand2, 25, 27)
	dot_reserve_move_unit_seq(dotBand3, 25, 28)
	
	
	exec_parallel_seq()


	
	open_speech_window("NPCNAME_0207", nil, nil)
	message("CO_101062_03020012")
	close_speech_window()

	
	wait_seq()
	
	dot_unit_dir(dotMaril, 3)
	dot_move_unit_seq(dotNoir2, 23, 28)
	
	
	wait_seq()
	
	dot_disp_weapon(dotNoir2,true)

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "怒り")
	message("CO_101062_03020013")
	close_speech_window()

	
	open_speech_window("NPCNAME_0208", nil, nil)
	PlayPartVoice("山賊", "喜び")
	message("CO_101062_03020014")
	close_speech_window()

	
	change_face(Maril, "Normal")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "肯定")
	message("CO_101062_03020015")
	close_speech_window()


	dot_move_unit_seq(dotMaril, 24, 27)

	
	wait_seq()

	dot_change_anim(dotMaril,3)
	dot_damage_seq(dotBand2,dotMaril)
	dot_damage_seq(dotBand1,dotMaril)
	dot_damage_seq(dotBand3,dotMaril)

	wait_seq()

	
	dot_move_knockback(dotBand1,26, 26,0.1,EaseOut)
	dot_move_knockback(dotBand2,26, 27,0.1,EaseOut)
	dot_move_knockback(dotBand3,26, 28,0.1,EaseOut)

	dot_change_anim(dotMaril,0)
	
	se_play("SE_ADV_MA_01B112_38_Kneeling")
	wait_time(0.1)
	se_play("SE_ADV_MA_01B112_38_Kneeling")

	dot_change_anim(dotBand2,1)
	dot_change_anim(dotBand1,1)
	dot_change_anim(dotBand3,1)

	
	open_speech_window("NPCNAME_0288", nil, nil)
	message("CO_101062_03020017")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101062_03020018")
	close_speech_window()

	
	change_face(Maril, "Normal")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "肯定2")
	message("CO_101062_03020019")

	
	change_face(Maril, "Anger")
	message("CO_101062_03020020")

	dot_unit_dir(dotMaril, 2)
	
	
	change_face(Maril, "Smile")
	message("CO_101062_03020021")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "落胆")
	message("CO_101062_03020022")



	dot_move_unit_seq(dotMaril, 34, 25)

	
	wait_seq()

	
	change_face(Noir2, "Sad")
	message("CO_101062_03020024")
	close_speech_window()





reserve_next_script("1章/コミュ/x0401_マルイル_ランクアップ3_3")


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup_101062_Maril_preload()
	pbadv_setup_101009_Noir_preload(2,true, 17, 33,0)
end
