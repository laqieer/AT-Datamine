




Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	disp_calendar(false)
	
	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(3,1)

	
	pbadv_setup_101015_Arthur(2,true, 20, 29,0)  
	pbadv_setup_101013_Gawain(1,true, 11, 22,0)  
	
	dotstu = dot_reserve_ally(401005001, 21, 29, 0) 
	dot_set_weapon(dotstu, 101010001)
	
	dotstu2 = dot_reserve_ally(401005001, 19, 30, 0) 
	dot_set_weapon(dotstu2, 101010001)

	
	setup_complete_unit()
	

	
	dot_unit_dir(dotstu, 2)

	dot_change_anim(dotstu2,1)
	
	
	dot_disp_unit(dotGawain1, false)
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(20, 29, 0.0)
	
end

function Play()
	fadein(0)
	Play_start(true)

	
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.2)

	dot_change_anim(dotArthur2,0)	
	dot_change_anim(dotstu,6)
	dot_play_particle_unit(dotstu,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_move_knockback(dotstu, 22, 29, 0.2, 2)

	wait_time(0.2)

	dot_change_anim(dotstu,1)
	wait_time(0.8)

	dot_move_unit_seq(dotArthur2,20, 22)	
	move_camera(20, 22, 2.0)
	wait_seq()
	wait_camera()

	wait_time(1.0)
	
	
	dot_disp_unit(dotGawain1, true)
	dot_move_unit_seq(dotGawain1,19, 22)	
	wait_seq()
	


	dot_unit_dir(dotArthur2, 2)
	
	
	change_face(Gawain1, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Gawain1, nil)
	 --PlayPartVoice("ガウェイン", "肯定3")
	message("MA_01C110_040002")
	close_speech_window()

	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur2, nil)
	 --PlayPartVoice("アーサー", "悲しみ")
	message("MA_01C110_040003")
	close_speech_window()

	
	change_face(Gawain1, "Sad")
	open_speech_window("CHRNAME_GAWAIN", Gawain1, nil)
	message("MA_01C110_040004")
	close_speech_window()

	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur2, nil)
	message("MA_01C110_040005")
	close_speech_window()

	
	change_face(Gawain1, "Sad")
	open_speech_window("CHRNAME_GAWAIN", Gawain1, nil)
	message("MA_01C110_040006")
	close_speech_window()

	
	
	dot_unit_dir(dotArthur2, 3)

	wait_time(1.0)

	dot_unit_dir(dotArthur2, 2)

	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur2, nil)
	message("MA_01C110_040008")
	close_speech_window()

	
	change_face(Gawain1, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Gawain1, nil)
	message("MA_01C110_040009")
	

	
	change_face(Gawain1, "Normal")
	
	message("MA_01C110_040010")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur2, nil)
	 --PlayPartVoice("アーサー", "否定")
	message("MA_01C110_040011")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C110_040012")
	close_speech_window()

	
	change_face(Gawain1, "Sad")
	open_speech_window("CHRNAME_GAWAIN", Gawain1, nil)
	message("MA_01C110_040013")
	close_speech_window()

	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur2, nil)
	 --PlayPartVoice("アーサー", "落胆")
	message("MA_01C110_040014")
	close_speech_window()

	
	change_face(Gawain1, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Gawain1, nil)
	 --PlayPartVoice("ガウェイン", "落胆")
	message("MA_01C110_040015")
	

	
	change_face(Gawain1, "Normal")
	
	message("MA_01C110_040016")
	close_speech_window()

	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur2, nil)
	message("MA_01C110_040017")
	close_speech_window()

	
	change_face(Gawain1, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Gawain1, nil)
	message("MA_01C110_040018")
	

	
	change_face(Gawain1, "Serious")
	
	message("MA_01C110_041001")
	close_speech_window()

	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur2, nil)
	 --PlayPartVoice("アーサー", "肯定2")
	message("MA_01C110_040019")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101015_Arthur_preload(2,true, 20, 29,0)
	pbadv_setup_101013_Gawain_preload(1,true, 11, 22,0)
end
