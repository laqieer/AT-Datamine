

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201200000", "201200000")
	change_time_and_weather(1,1)
	
	
	
	pbadv_setup_101009_Noir(2,true,35,23,0)
	pbadv_setup_101011_Guinevere(1,true,36,23,0)
	pbadv_setup_101030_Elaine(0,true,37,23,0)
	pbadv_setup_101031_Lovein(1,true,37,24,0)
	pbadv_setup_101013_Gawain(0,true,36,24,0)
	pbadv_setup_101018_Ragnar(1,true,35,24,0)
	pbadv_setup_101026_Percival(0,true,37,25,0)
	pbadv_setup_101027_Dindrane(1,true,35,25,0)
	pbadv_setup_101024_Bors(0,true,36,26,0)
	pbadv_setup_101025_Clare(1,true,36,25,0)
	

	
	roma1 = dot_reserve_enemy(3, 36,27, 0)
	roma2 = dot_reserve_enemy(3, 34,24, 0)
	barbaroi1 = dot_reserve_enemy(3, 33,25, 0)
	barbaroi2 = dot_reserve_enemy(3, 35,22, 0)

	barbaroi3 = dot_reserve_enemy(3, 19,19, 0)
	barbaroi4 = dot_reserve_enemy(3, 20,19, 0)
	roma3 = dot_reserve_enemy(3, 21,19, 0)
	roma4 = dot_reserve_enemy(3, 22,19, 0)
		
	
	
	setup_complete_unit()
	
	
	
	dot_unit_dir(dotBors,1)
	dot_unit_dir(dotNoir2,DotDir_Left)
	dot_unit_dir(dotGawain,DotDir_Left)
	dot_unit_dir(dotDindrane1,DotDir_Left)
	
	dot_unit_dir(barbaroi1,DotDir_Right)
	dot_unit_dir(roma2,DotDir_Right)

	
	dot_disp_unit(barbaroi3,false)
	dot_disp_unit(roma3,false)
	dot_disp_unit(roma4,false)
	dot_disp_unit(barbaroi4,false)
	
	Ef_EnemyDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)


	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(36,25, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)

	dot_move_unit_seq(dotDindrane1,34,25)
	wait_seq()
	dot_change_anim(dotDindrane1,3)
	dot_play_particle_unit(dotDindrane1,"Ef_C_Spr_N_Atk01",3,true)
	
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	
	dot_change_anim(dotGawain,3)
	dot_play_particle_unit(dotGawain,"Ef_C_Axe_N_Atk01",3,true)
	
	dot_play_particle_unit(roma2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	dot_change_anim(barbaroi1,6)
	dot_change_anim(roma2,6)
	
	
	dot_change_anim(dotBors,3)
	dot_play_particle_unit(dotBors,"Ef_C_Axe_N_Atk01",3,true)
	
	dot_play_particle_unit(roma1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	dot_change_anim(roma1,6)
	
	wait_seq()
	
	
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	dot_change_anim(dotNoir2,DotAnim_Idle)
	wait_seq()

	wait_time(0.5)
	
	
	dot_change_anim(barbaroi2,6)

	wait_time(0.2)

	dot_play_particle_unit(roma1,"Ef_C_Cmn_DieEmy01",DotEffect_Body,true)
	dot_play_particle_unit(roma2,"Ef_C_Cmn_DieEmy01",DotEffect_Body,true)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",DotEffect_Body,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",DotEffect_Body,true)
	
	wait_time(0.5)

	dot_disp_unit(roma1, false)
	dot_disp_unit(roma2, false)
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)

	dot_remove_unit(roma1) 
	dot_remove_unit(roma2) 
	dot_remove_unit(barbaroi1) 
	dot_remove_unit(barbaroi2) 

	wait_time(0.5)
	
	
	move_camera(36,25, 0.5)
	wait_camera()
	
	
	dot_change_anim(dotBors,DotAnim_Idle)
	dot_change_anim(dotGawain,DotAnim_Idle)
	dot_change_anim(dotDindrane1,DotAnim_Idle)
	dot_unit_dir(dotDindrane1,DotDir_Left)
	wait_time(0.5)
		
	
	change_face(Dindrane1,"Anger")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane1, nil)
	 --PlayPartVoice("ディンドラン","挨拶")
	message("MA_01A111_350002")
	close_speech_window()
	
	
	move_camera(35,23, 1.0)
	
	
	dot_disp_unit(barbaroi3,true)
	dot_disp_unit(roma3,true)
	dot_disp_unit(roma4,true)
	dot_disp_unit(barbaroi4,true)
	
	
	dot_reserve_move_unit_seq(barbaroi4, 33,24)
	dot_reserve_move_unit_seq(barbaroi3, 33,23)
	dot_reserve_move_unit_seq(roma3, 35,21)
	dot_reserve_move_unit_seq(roma4, 36,21)
	exec_parallel_seq()
	
	wait_time(0.5)
	
	dot_unit_dir(dotNoir2,DotDir_Left)
	dot_unit_dir(dotGuinevere1,DotDir_Left)
	dot_unit_dir(dotElaine,DotDir_Left)
	dot_unit_dir(dotLovein1,DotDir_Left)
	dot_unit_dir(dotClare1,DotDir_Left)
	dot_unit_dir(dotBors,DotDir_Left)
	dot_unit_dir(dotPercival,DotDir_Left)
	dot_unit_dir(dotGawain,DotDir_Left)
	dot_unit_dir(dotRagnar1,DotDir_Left)
	
	wait_time(0.5)
	
	
	dot_reserve_move_unit_seq(dotPercival, 34,24)
	dot_reserve_move_unit_seq(dotDindrane1, 34,23)
	dot_reserve_move_unit_seq(dotClare1, 35,22)
	dot_reserve_move_unit_seq(dotBors, 36,22)
	exec_parallel_seq()	
	
	
	wait_camera()
	wait_seq()
	
	dot_unit_dir(dotDindrane1,DotDir_Left)

	
	wait_time(0.3)
	dot_change_anim(dotBors,3)
	dot_play_particle_unit(dotBors,"Ef_C_Axe_N_Atk01",3,true)
	
	
	dot_change_anim(dotPercival,3)
	dot_play_particle_unit(dotPercival,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.1)
	dot_play_particle_unit(roma4,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	dot_change_anim(roma4,6)
	dot_change_anim(barbaroi4,6)
	wait_time(0.8)
	
	dot_unit_dir(dotBors,DotDir_Left)
	dot_change_anim(dotBors,0)
	dot_unit_dir(dotPercival,DotDir_Left)
	dot_change_anim(dotPercival,0)
	wait_seq()
	dot_change_anim(roma4,0)
	dot_change_anim(barbaroi4,0)
	
	
	change_face(Percival,"Smile")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	 --PlayPartVoice("パーシヴァル","笑い")
	message("MA_01A111_350003")
	close_speech_window()

	
	
	change_face(Clare1,"Sad")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	 --PlayPartVoice("クレア","挨拶")
	message("MA_01A111_350004")
	close_speech_window()

	
	change_face(Dindrane1,"Sad")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane1, nil)
	 --PlayPartVoice("ディンドラン","落胆")
	message("MA_01A111_350005")
	close_speech_window()
	
	
	change_face(Percival,"Anger")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	 --PlayPartVoice("パーシヴァル","怒り")
	message("MA_01A111_350006")
	close_speech_window()

	
	change_face(Bors,"Smile")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	 --PlayPartVoice("ヴォールス","笑い")
	message("MA_01A111_350007")
	close_speech_window()
	
	
	dot_unit_dir(dotRagnar1,DotDir_Right)
	dot_unit_dir(dotGawain,DotDir_Right)

	
	change_face(Ragnar1,"Anger")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar1, nil)
	message("MA_01A111_350008")
	close_speech_window()

	
	change_face(Gawain,"Serious")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	 --PlayPartVoice("ガウェイン","肯定2")
	message("MA_01A111_350009")

	
	message("MA_01A111_350010")
	close_speech_window()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,35,23,0)
	pbadv_setup_101011_Guinevere_preload(1,true,36,23,0)
	pbadv_setup_101030_Elaine_preload(0,true,37,23,0)
	pbadv_setup_101031_Lovein_preload(1,true,37,24,0)
	pbadv_setup_101013_Gawain_preload(0,true,36,24,0)
	pbadv_setup_101018_Ragnar_preload(1,true,35,24,0)
	pbadv_setup_101026_Percival_preload(0,true,37,25,0)
	pbadv_setup_101027_Dindrane_preload(1,true,35,25,0)
	pbadv_setup_101024_Bors_preload(0,true,36,26,0)
	pbadv_setup_101025_Clare_preload(1,true,36,25,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
end
