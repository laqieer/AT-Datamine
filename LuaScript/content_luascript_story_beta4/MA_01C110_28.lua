

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101022_Mordred(0,true, 21, 22,0)  
	pbadv_setup_101023_Clarice(1,true, 26, 22,0) 
	pbadv_setup_101015_Arthur(2,true, 24, 22,0)  
	

	
	setup_complete_unit()
	


	dot_unit_dir(dotArthur2, 2)
	
	dot_unit_dir(dotClarice1, 2)


	dot_change_anim(dotClarice1,1)
	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(23, 21, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	change_face(Arthur2, "Normal")	
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur2)
	 --PlayPartVoice("アーサー", "落胆")
	message("MA_01C110_280003")
	

	
	change_face(Arthur2, "Normal")	
	
	message("MA_01C110_280004")
	

	
	change_face(Arthur2, "Normal")	
	
	message("MA_01C110_280005")
	close_speech_window()

	
	
	change_face(Mordred, "Anger")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	 --PlayPartVoice("モルドレッド", "激怒")
	message("MA_01C110_280007")
	close_speech_window()

	
	

	dot_move_unit_seq(dotMordred,23, 22)
	wait_seq()

	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.3)
	
	dot_change_anim(dotMordred,0)
	dot_change_anim(dotArthur2,0)

	wait_time(0.2)

	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.1)

	dot_change_anim(dotMordred,6)
	dot_move_knockback(dotMordred, 22, 22, 0.2, 2)
	dot_move_unit_seq(dotArthur2,23, 22)
	wait_seq()
		
	dot_change_anim(dotMordred,0)
	dot_change_anim(dotArthur2,0)

	wait_time(0.2)
	
	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.3)
	
	dot_change_anim(dotMordred,0)
	dot_change_anim(dotArthur2,0)

	wait_time(0.2)
	
	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.2)

	dot_change_anim(dotArthur2,0)
	dot_change_anim(dotMordred,6)
	dot_play_particle_unit(dotMordred,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	move_camera(22, 21, 0.2)
	dot_move_knockback(dotMordred, 20, 22, 0.2, 2)
	wait_time(0.2)
	wait_camera()
	
	dot_change_anim(dotMordred,1)

	wait_time(0.5)

	
	
	dot_move_unit_seq(dotArthur2,22, 22)
	wait_seq()

	
	
	dot_move_unit_seq(dotClarice1,23, 22)
	wait_seq()
	
	dot_change_anim(dotClarice1,3)
	dot_play_particle_unit(dotClarice1,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotArthur2,6)
	dot_play_particle_unit(dotArthur2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(dotClarice1,0)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		

	wait_time(0.2)

	dot_change_anim(dotArthur2,0)
	
	
	change_face(Arthur2, "Surprise")	
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur2)
	 --PlayPartVoice("アーサー", "驚き")
	message("MA_01C110_280009")
	close_speech_window()

	
	dot_unit_dir(dotArthur2, 3)	
	
	
	change_face(Mordred, "Surprise")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C110_280011")
	close_speech_window()

	
	change_face(Clarice1, "Anger")	
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	message("MA_01C110_280012")
	close_speech_window()

	
	change_face(Mordred, "Anger")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	 --PlayPartVoice("モルドレッド", "落胆")
	message("MA_01C110_280013")
	close_speech_window()

	
	change_face(Clarice1, "Anger")	
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	 --PlayPartVoice("クラリス", "否定")
	message("MA_01C110_280014")
	

	
	change_face(Clarice1, "Anger")	
	
	message("MA_01C110_280015")
	close_speech_window()

	
	

	dot_change_anim(dotClarice1,3)
	dot_play_particle_unit(dotClarice1,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.5)
	
	dot_change_anim(dotClarice1,0)
	dot_change_anim(dotArthur2,0)

	wait_time(0.2)

	dot_change_anim(dotClarice1,3)
	dot_play_particle_unit(dotClarice1,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.2)
	
	dot_change_anim(dotClarice1,6)
	dot_move_knockback(dotClarice1, 24, 22, 0.2, 2)
	dot_move_unit_seq(dotArthur2,23, 22)
	wait_seq()

	dot_change_anim(dotClarice1,0)
	dot_change_anim(dotArthur2,0)

	wait_time(0.2)
	
	dot_change_anim(dotClarice1,3)
	dot_play_particle_unit(dotClarice1,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.2)

	dot_change_anim(dotClarice1,0)
	dot_change_anim(dotArthur2,0)

	wait_time(0.2)

	dot_change_anim(dotClarice1,3)
	dot_play_particle_unit(dotClarice1,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	
	se_play("SE_ADV_MA_01C201_29_Sword_Block")		
	
	wait_time(0.2)
	dot_change_anim(dotClarice1,6)
	dot_play_particle_unit(dotClarice1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	
	
	change_face(Clarice1, "Anger")	
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	 --PlayPartVoice("クラリス", "苦しみ")
	message("MA_01C110_280017")
	close_speech_window()

	dot_change_anim(dotArthur2,0)
	dot_change_anim(dotClarice1,1)
	wait_time(0.5)

	
	change_face(Mordred, "Anger")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C110_280018")
	close_speech_window()

	
	change_face(Arthur2, "Normal")	
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur2)
	 --PlayPartVoice("アーサー", "肯定2")
	message("MA_01C110_280019")
	

	
	change_face(Arthur2, "Normal")	
	
	message("MA_01C110_280020")
	close_speech_window()

	
	change_face(Mordred, "Anger")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	 --PlayPartVoice("モルドレッド", "激怒")
	message("MA_01C110_280022")
	close_speech_window()

	dot_change_anim(dotMordred,0)
	wait_time(0.5)

	dot_unit_dir(dotArthur2, 2)
	wait_time(0.5)

	
	change_face(Arthur2, "Normal")	
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur2)
	message("MA_01C110_280023")
	close_speech_window()

	

	
	
	change_face(Clarice1, "Sad")	
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	message("MA_01C110_280025")
	close_speech_window()

	dot_change_anim(dotClarice1,0)

	wait_time(0.5)

	
	dot_unit_dir(dotArthur2, 3)

	wait_time(2.0)

	
	change_face(Arthur2, "Normal")	
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur2)
	 --PlayPartVoice("アーサー", "納得")
	message("MA_01C110_280027")
	

	
	change_face(Arthur2, "Normal")	
	
	message("MA_01C110_280029")
	close_speech_window()

	
	change_face(Clarice1, "Normal")	
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	message("MA_01C110_280030")
	close_speech_window()

	
	change_face(Arthur2, "Normal")	
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur2)
	message("MA_01C110_280031")
	close_speech_window()

	

	wait_time(1.0)
	

	
	dot_reserve_move_unit_seq(dotArthur2,25, 28)
	
	exec_parallel_seq()
	
	wait_seq()
	
	
	



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101022_Mordred_preload(0,true, 21, 22,0)
	pbadv_setup_101023_Clarice_preload(1,true, 26, 22,0)
	pbadv_setup_101015_Arthur_preload(2,true, 24, 22,0)
end
