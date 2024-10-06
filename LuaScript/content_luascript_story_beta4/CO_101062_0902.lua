
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")	
Include("content_luascript_common","DemoCommonPack")	

function Load()
	Load_common(true)
	
	init_psbattleadv("201060000", "201060000") 
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)



	pbadv_setup_101009_Noir(2,true, 38, 18,0)  

	pbadv_setup_101062_Maril(true, 39, 20,0) 



	barbaroi1 = dot_reserve_enemy(1, 19, 6, 0)
	barbaroi2 = dot_reserve_enemy(1, 21, 6, 0)
	barbaroi3 = dot_reserve_enemy(1, 22, 6, 0)
	barbaroi4 = dot_reserve_enemy(1, 18, 6, 0)
	barbaroi5 = dot_reserve_enemy(1, 18, 7, 0)
	barbaroi6 = dot_reserve_enemy(1, 23, 7, 0)
	barbaroi7 = dot_reserve_enemy(1, 19, 7, 0)
	barbaroi8 = dot_reserve_enemy(1, 20, 7, 0)
	barbaroi9 = dot_reserve_enemy(1, 21, 7, 0)

	setup_complete_unit() 

	


	dot_disp_weapon(dotNoir2,false)
	


	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(39, 18, 0.0)

	load_sound("BGM_ADV_Antagonism")
	

end


function Play()
	fadein(0)
	Play_start(true)

	
	
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "悩む")
	message("CO_101062_09020002")


	
	change_face(Noir2, "Normal")
	message("CO_101062_09020003")
	close_speech_window()

	dot_move_unit_seq(dotMaril, 39, 19)
	
	
	wait_seq()

	dot_unit_dir(dotMaril, 2)

	
	change_face(Maril, "Sad")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "肯定")
	message("CO_101062_09020004")
	close_speech_window()


	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "落胆")
	message("CO_101062_09020005")
	


	
	CO_101062_0902_select1()

	
	open_select_window_tag(Noir2, "Normal", "CO_101062_09020007", "CO_101062_09020008", "CO_101062_09020009")	
	close_speech_window()	

	if is_select(1) then			
		CO_101062_0902_select1_1()

	elseif is_select(2) then		
		CO_101062_0902_select1_2()

	elseif is_select(3) then		
		CO_101062_0902_select1_3()

	end
	CO_101062_0902_end()

end

function CO_101062_0902_select1()

end

function CO_101062_0902_select1_1()


	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	
	message("CO_101062_09020011")
	close_speech_window()

	
	
	change_face(Maril, "Normal")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "気合い")
	message("CO_101062_09020012")

	
	change_face(Maril, "Surprise")
	message("CO_101062_09020013")
	close_speech_window()

	

	dot_move_knockback(dotMaril,39, 20,0.1,EaseOut)

	
	dot_move_unit_seq(dotNoir2, 38, 20)
	
	
	wait_seq()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101062_09020015")
	close_speech_window()

	dot_unit_dir(dotMaril, 2)
	
	
	change_face(Maril, "Surprise")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "挨拶")
	message("CO_101062_09020016")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "落胆")
	message("CO_101062_09020017")
	close_speech_window()

	
	change_face(Maril, "Surprise")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "落胆")
	message("CO_101062_09020018")
	close_speech_window()


end



function CO_101062_0902_select1_2()


	
	
	change_face(Maril, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101062_09020020")
	close_speech_window()

	
	
	change_face(Maril, "Surprise")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "驚き")
	message("CO_101062_09020021")

	
	change_face(Maril, "Sad")
	message("CO_101062_09020022")

	
	change_face(Maril, "Anger")
	message("CO_101062_09020023")
	close_speech_window()


end


function CO_101062_0902_select1_3()


	
	
	change_face(Maril, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101062_09020025")

	
	change_face(Noir2, "Normal")
	message("CO_101062_09020026")
	close_speech_window()

	
	
	change_face(Maril, "Anger")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "怒り")
	message("CO_101062_09020027")
	close_speech_window()

end


function CO_101062_0902_end()

	
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101062_09020029")
	close_speech_window()

	
	change_face(Maril, "Surprise")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "驚き")
	message("CO_101062_09020030")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101062_09020031")

	
	message("CO_101062_09020032")
	close_speech_window()

	
	change_face(Maril, "Surprise")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "納得")
	message("CO_101062_09020033")

	
	change_face(Maril, "Normal")
	message("CO_101062_09020034")
	close_speech_window()

	
	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "笑い")
	message("CO_101062_09020036")
	close_speech_window()

	
	fadeout(0,0,0,1.0, FADE_TIME)

	wait_time(TIME_ELAPSED + FADE_TIME)

	dot_place_unit(dotNoir2,21,14)
	dot_place_unit(dotMaril,23,14)

	move_camera(20, 10, 0.0)

	fadein(FADE_TIME)

	bgm_play("BGM_ADV_Antagonism")

	wait_time(FADE_TIME)

	move_camera(22, 14, 1.0)
	wait_camera()
		
	
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "悩む")
	message("CO_101062_09020038")

	
	change_face(Noir2, "Sad")
	message("CO_101062_09020039")

	
	change_face(Noir2, "Normal")
	message("CO_101062_09020040")
	close_speech_window()

	
	change_face(Maril, "Normal")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "肯定")
	message("CO_101062_09020041")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101062_09020042")
	close_speech_window()

	
	change_face(Maril, "Normal")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "肯定2")
	message("CO_101062_09020043")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101062_09020044")
	close_speech_window()

	dot_move_unit_seq(dotNoir2, 18, 8)
	

	
	

	fadeout(0,0,0,1.0, FADE_TIME)

	dot_attack_seq(dotNoir2, barbaroi1)			
	dot_damage_seq(barbaroi1, dotNoir2, false)	
	wait_seq()									

	dot_change_anim(dotNoir2, DotAnim_Idle)		

	dot_move_unit_seq(dotMaril, 21, 8)
	
	
	wait_time(TIME_ELAPSED + FADE_TIME)


	dot_place_unit(dotNoir2,5,10)
	
	dot_place_unit(barbaroi1,7,9)
	dot_place_unit(barbaroi2,7,10)
	dot_place_unit(barbaroi3,7,11)
	dot_place_unit(barbaroi4,8,10)
	dot_place_unit(barbaroi5,8,11)
	dot_place_unit(barbaroi6,9,9)
	dot_place_unit(barbaroi7,9,10)
	dot_place_unit(barbaroi8,6,8)
	dot_place_unit(barbaroi9,7,8)

	move_camera(21, 8, 0.0)


	dot_unit_dir(dotMaril, 2)
	dot_unit_dir(dotNoir2, 3)
	dot_disp_weapon(dotNoir2,true)

	fadein(FADE_TIME)

	wait_time(FADE_TIME)

	
	wait_seq()

	
	change_face(Maril, "Sad")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	
	message("CO_101062_09020046")
	close_speech_window()

	move_camera(6, 10, 1.0)
	wait_camera()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "気合い")
	message("CO_101062_09020047")
	close_speech_window()

	move_camera(21, 8, 1.0)
	wait_camera()

	
	change_face(Maril, "Anger")
	open_speech_window("CHRNAME_MARIL", Maril, nil)
	PlayPartVoice("マルイル", "気合い")
	message("CO_101062_09020048")
	close_speech_window()

	dot_move_unit_seq(dotMaril, 21, 5)

	
	
	fadeout(0,0,0,1.0, FADE_TIME)

	wait_time(TIME_ELAPSED + FADE_TIME)



reserve_next_script("1章/コミュ/x0401_マルイル_ランクアップ9_3")


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 38, 18,0)
	pbadv_setup_101062_Maril_preload(true, 39, 20,0)
	preload_sound("BGM_ADV_Antagonism")
end
