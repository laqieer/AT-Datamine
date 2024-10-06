

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201010000", "201010000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 33, 19, 0)  

	pbadv_setup_101011_Guinevere(0,true, 28, 14, 0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 29, 14, 0)  

	pbadv_setup_101010_Lancelot(0,true, 30, 11, 0)  

	pbadv_setup_101012_Dinatan(1,true, 29, 16, 0)  
	pbadv_setup_101017_Maladisant(1,true, 28, 16, 0)  

	pbadv_setup_101013_Gawain(1,true, 34, 19, 0)  
	pbadv_setup_101018_Ragnar(1,true, 35, 15, 0)  

	pbadv_setup_101022_Mordred(0,true, 32, 18, 0)  
	pbadv_setup_101023_Clarice(0,true, 35, 24, 0) 
	
	
	
	
	barbaroi = dot_reserve_enemy(49, 33, 11, 0)
	barbaroi2 = dot_reserve_enemy(304, 32, 12, 0)

	barbaroi3 = dot_reserve_enemy(1100, 31, 14, 0)
	barbaroi4 = dot_reserve_enemy(304, 32, 15, 0)
	barbaroi5 = dot_reserve_enemy(1100, 31, 16, 0)

	barbaroi6 = dot_reserve_enemy(1204, 34, 14, 0)
	barbaroi7 = dot_reserve_enemy(1204, 34, 16, 0)

	
	
	
	setup_complete_unit()
	
	


	dot_unit_dir(dotGawain1, 2)
	dot_unit_dir(dotRagnar1, 2)

	
	
	
	dot_disp_weapon(dotClarice, false)

	
	
	
	dot_disp_unit(dotClarice, false)
	dot_disp_unit(dotMordred, false)

	
	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(40.0, 0.0)
	move_camera(33, 19, 0.0)

	load_sound("BGM_ADV_Speculation")
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	
	
	
	
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotGawain1,3)
	dot_play_particle_unit(dotGawain1,"Ef_C_Ham_N_Atk01",3,true)
	se_play("SE_ADV_MA_01C201_29_Sword_Block")	
	wait_time(0.2)

	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotGawain1,0)

	wait_time(0.1)

	dot_change_anim(dotGawain1,3)
	dot_play_particle_unit(dotGawain1,"Ef_C_Ham_N_Atk01",3,true)

	wait_time(0.2)

	dot_change_anim(dotGawain1,0)
	dot_change_anim(dotNoir2,6)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Str01",1,true)
	
	dot_move_knockback(dotNoir2, 31, 19, 0.2, 2)
	
	wait_time(0.2)

	dot_change_anim(dotNoir2,1)


	
	
	change_face(Noir2, "Pain")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "苦しみ")
	message("MA_01C110_470002")
	close_speech_window()


	
	change_face(Dinatan1, "Sad")	
	open_speech_window("CHRNAME_DINATAN2", Dinatan1, nil)
	message("MA_01C110_470003")
	close_speech_window()

	
	
	
	change_face(Gawain1, "Normal")	
	open_speech_window("CHRNAME_GAWAIN", nil, Gawain1)
	 --PlayPartVoice("ガウェイン", "落胆")
	message("MA_01C110_470005")
	

	
	change_face(Gawain1, "Normal")	
	
	message("MA_01C110_470006")
	close_speech_window()

	
	dot_move_unit_seq(dotGawain1, 33, 19)
	wait_seq()

	
	open_cutin(1,1)
	
	on_cutin(1,Mordred,"Normal") 

	wait_time(0.3)
	
	dot_place_unit(dotMordred, 32, 19)
	dot_disp_unit(dotMordred, true)
	dot_unit_dir(dotMordred, 3)
	
	
	
	
	open_speech_window("CHRNAME_MORDRED", nil, nil)
	 --PlayPartVoice("モルドレッド", "肯定3")
	message("MA_01C110_470008")
	close_speech_window()
	
	
	close_cutin()	

	
	
	change_camera_distance(7.0, 0.5)
	move_camera(32, 19, 0.5)

	
	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(dotGawain1,3)
	dot_play_particle_unit(dotGawain1,"Ef_C_Ham_N_Atk01",3,true)
	se_play("SE_ADV_MA_01C201_29_Sword_Block")	
	wait_time(0.2)

	dot_change_anim(dotMordred,0)
	dot_change_anim(dotGawain1,6)
	dot_play_particle_unit(dotGawain1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	dot_move_knockback(dotGawain1, 34, 19, 0.2, 2)
	
	wait_time(0.2)

	dot_change_anim(dotGawain1,0)
	wait_camera()


	
	change_face(Noir2, "Surprise")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "驚き")
	message("MA_01C110_470010")
	close_speech_window()

	
	change_face(Gawain1, "Anger")	
	open_speech_window("CHRNAME_GAWAIN", nil, Gawain1)
	 --PlayPartVoice("ガウェイン", "怒り")
	message("MA_01C110_470011")
	close_speech_window()

	
	change_face(Mordred, "Normal")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C110_470012")
	

	
	change_face(Mordred, "Normal")	
	
	message("MA_01C110_470013")
	

	
	change_face(Mordred, "Normal")	
	
	message("MA_01C110_470014")
	close_speech_window()

	
	change_face(Gawain1, "Serious")	
	open_speech_window("CHRNAME_GAWAIN", nil, Gawain1)
	 --PlayPartVoice("ガウェイン", "激怒")
	message("MA_01C110_470015")
	close_speech_window()
	
	move_camera(34, 19, 1.0)

	dot_move_unit_seq(dotRagnar1, 36, 15)
	dot_move_unit_seq(dotRagnar1, 36, 18)
	wait_seq()

	dot_unit_dir(dotRagnar1, 2)
	wait_camera()

	
	change_face(Ragnar1, "Normal")	
	open_speech_window("CHRNAME_RAGNAR2", nil, Ragnar1)
	message("MA_01C110_470016")
	

	
	change_face(Ragnar1, "Normal")	
	
	message("MA_01C110_470017")
	close_speech_window()

	
	dot_unit_dir(dotGawain1, 3)
	wait_time(1.0)
	
	
	change_face(Gawain1, "Anger")	
	open_speech_window("CHRNAME_GAWAIN", nil, Gawain1)
	 --PlayPartVoice("ガウェイン", "肯定2")
	message("MA_01C110_470019")
	

	dot_unit_dir(dotGawain1, 2)

	
	change_face(Gawain1, "Normal")	
	
	message("MA_01C110_470020")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")

	
	dot_remove_unit(barbaroi)
	dot_remove_unit(barbaroi2)
	
	dot_reserve_move_unit_seq(barbaroi3, 32, 10)
	dot_reserve_move_unit_seq(barbaroi4, 32, 11)
	dot_reserve_move_unit_seq(barbaroi5, 31, 11)
	dot_reserve_move_unit_seq(barbaroi6, 33, 10)
	dot_reserve_move_unit_seq(barbaroi7, 33, 11)
	dot_reserve_move_unit_seq(dotRagnar1, 34, 11)
	dot_reserve_move_unit_seq(dotGawain1, 35, 11)
	exec_parallel_seq()
	wait_seq()

	dot_remove_unit(dotRagnar1)
	dot_remove_unit(dotGawain1)
	dot_remove_unit(barbaroi3)
	dot_remove_unit(barbaroi4)
	dot_remove_unit(barbaroi5)
	dot_remove_unit(barbaroi6)
	dot_remove_unit(barbaroi7)
	
	wait_time(0.5)

	move_camera(30, 19, 1.0)
	change_camera_distance(8.0, 1.0)

	dot_reserve_move_unit_seq(dotLancelot, 29, 13)
	exec_parallel_seq()

	dot_reserve_move_unit_seq(dotGuinevere, 28, 15)
	dot_reserve_move_unit_seq(dotGwenhwymawr1, 29, 15)
	dot_reserve_move_unit_seq(dotLancelot, 29, 14)
	exec_parallel_seq()

	dot_reserve_move_unit_seq(dotDinatan1, 29, 19)
	dot_reserve_move_unit_seq(dotMaladisant1, 28, 19)
	dot_reserve_move_unit_seq(dotGuinevere, 28, 18)
	dot_reserve_move_unit_seq(dotGwenhwymawr1, 29, 18)
	dot_reserve_move_unit_seq(dotLancelot, 29, 17)
	exec_parallel_seq()
	wait_seq()

	

	dot_change_anim(dotNoir2,0)
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotDinatan1, false)
	dot_disp_weapon(dotGwenhwymawr1, false)
	dot_disp_weapon(dotMaladisant1, false)
	dot_disp_weapon(dotMordred, false)

	wait_camera()

	
	bgm_play("BGM_ADV_Speculation")
	
	change_face(Noir2, "Normal")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "肯定2")
	message("MA_01C110_470022")
	close_speech_window()

	dot_unit_dir(dotMordred, 2)

	
	change_face(Mordred, "Normal")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	 --PlayPartVoice("モルドレッド", "肯定2")
	message("MA_01C110_470023")
	close_speech_window()

	
	change_face(Dinatan1, "Surprise")	
	open_speech_window("CHRNAME_DINATAN2", Dinatan1, nil)
	message("MA_01C110_470024")
	close_speech_window()

	
	change_face(Mordred, "Normal")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01C110_470025")
	close_speech_window()

	
	change_face(Dinatan1, "Surprise")	
	open_speech_window("CHRNAME_DINATAN2", Dinatan1, nil)
	 --PlayPartVoice("ディナタン", "驚き")
	message("MA_01C110_470026")
	close_speech_window()

	
	change_face(Guinevere, "Surprise")	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "怒り")
	message("MA_01C110_470027")
	close_speech_window()

	
	change_face(Mordred, "Anger")	
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	 --PlayPartVoice("モルドレッド", "怒り")
	message("MA_01C110_470028")
	close_speech_window()

	dot_disp_unit(dotClarice, true)
	dot_move_unit_seq(dotClarice,34, 19, 0.8)

	wait_seq()

	dot_unit_dir(dotClarice, 2)


	
	change_face(Clarice, "Normal")	
	open_speech_window("CHRNAME_CLARICE", Clarice, nil)
	message("MA_01C110_470030")
	close_speech_window()
	
	
	dot_unit_dir(dotMordred, 3)

	
	change_face(Guinevere, "Surprise")	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "驚き")
	message("MA_01C110_470032")
	close_speech_window()

	
	change_face(Clarice, "Normal")	
	open_speech_window("CHRNAME_CLARICE", Clarice, nil)
	message("MA_01C110_470033")
	

	
	change_face(Clarice, "Normal")	
	
	message("MA_01C110_470034")
	

	
	change_face(Clarice, "Normal")	
	
	message("MA_01C110_470035")
	close_speech_window()

	
	dot_change_anim(dotClarice,1)
	
	se_play("SE_ADV_MA_01104_25_Fall")
	
	wait_time(0.7)
	


	change_face(Noir2, "Anger")	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "悲しみ")
	message("MA_01C110_470037")
	close_speech_window()
	
	


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 33, 19, 0)
	pbadv_setup_101011_Guinevere_preload(0,true, 28, 14, 0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 29, 14, 0)
	pbadv_setup_101010_Lancelot_preload(0,true, 30, 11, 0)
	pbadv_setup_101012_Dinatan_preload(1,true, 29, 16, 0)
	pbadv_setup_101017_Maladisant_preload(1,true, 28, 16, 0)
	pbadv_setup_101013_Gawain_preload(1,true, 34, 19, 0)
	pbadv_setup_101018_Ragnar_preload(1,true, 35, 15, 0)
	pbadv_setup_101022_Mordred_preload(0,true, 32, 18, 0)
	pbadv_setup_101023_Clarice_preload(0,true, 35, 24, 0)
	preload_sound("BGM_ADV_Speculation")
end
