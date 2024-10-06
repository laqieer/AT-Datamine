




Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201180000", "201180000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 21, 33,0)  
	
	pbadv_setup_101010_Lancelot(1,true, 24, 34,0)  
	pbadv_setup_101015_Arthur(1,true, 24, 31,0)  
	
	pbadv_setup_101028_Galahad(1,true, 18, 32,0)  
	pbadv_setup_101041_Morgan(1,true, 18, 31,0) 
	
	
	
	
	barbaroi1 = dot_reserve_enemy(42, 20, 32, 0) 
	barbaroi2 = dot_reserve_enemy(42, 22, 32, 0) 

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotArthur1, 2) 


	
	
	
	dot_disp_weapon(dotArthur1, false)

	
	
	
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(21, 34, 0.0)
	
	
	
	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)

	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_526", false, true)
	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

end

function NoirMoveSet() 
	dot_unit_dir(dotNoir2, 0) 
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	
	dot_change_anim(barbaroi1,6)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	dot_change_anim(dotNoir2,0)
	wait_time(0.2)

	dot_unit_dir(barbaroi1, 1) 
	dot_unit_dir(barbaroi2, 1) 
	dot_change_anim(barbaroi1,3)
	dot_play_particle_unit(barbaroi1,"Ef_C_Spr_N_EmyAtk01",3,true)
	dot_change_anim(barbaroi2,3)
	dot_play_particle_unit(barbaroi2,"Ef_C_Spr_N_EmyAtk01",3,true)	
	wait_time(0.2)

	dot_change_anim(dotNoir2,6)
	dot_change_anim(barbaroi1,0)
	dot_change_anim(barbaroi2,0)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_EmySla01",1,true)	
	dot_move_knockback(dotNoir2, 21, 35, 0.5, 2)
	wait_time(0.5)

	dot_change_anim(dotNoir2,0)
end

function LanceMoveSet() 
	dot_move_unit_seq(dotLancelot1, 24, 32)
	wait_seq()

	dot_unit_dir(dotLancelot1, 0) 
	dot_unit_dir(dotArthur1, 1) 
	dot_change_anim(dotLancelot1,3)
	dot_play_particle_unit(dotLancelot1,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotArthur1,4)
	dot_play_particle_unit(dotArthur1,"Ef_C_Mag_R_Atk01",3,true)
	wait_time(0.2)

	dot_unit_dir(dotArthur1, 2) 
	dot_change_anim(dotLancelot1,6)
	dot_change_anim(dotArthur1,0)
	dot_play_particle_unit(dotLancelot1,"Ef_C_Mag_R_Hit01",3,true)
	dot_move_knockback(dotLancelot1, 24, 34, 0.5, 2)
	wait_time(0.5)

	dot_change_anim(dotLancelot1,0)
end

function GalaMoveSet() 
	dot_target_attack(dotGalahad1,dotMorgan1,false)

	dot_unit_dir(dotGalahad1, 0) 
	dot_unit_dir(dotMorgan1, 1) 
	dot_change_anim(dotGalahad1,3)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotMorgan1,4)
	dot_play_particle_unit(dotMorgan1,"Ef_C_Mag_R_Atk01",3,true)
	wait_time(0.2)

	dot_change_anim(dotGalahad1,6)
	dot_change_anim(dotMorgan1,0)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Mag_R_Hit01",3,true)
	dot_move_knockback(dotGalahad1, 18, 33, 0.5, 2)
	wait_time(0.5)

	dot_change_anim(dotGalahad1,0)
end



function Play()
	fadein(0)
	Play_start(true)

	
	
	
	
	local NoirSet = create_coroutine(NoirMoveSet) 
	local LanceSet = create_coroutine(LanceMoveSet) 
	local GalaSet = create_coroutine(GalaMoveSet) 
	
	coroutine.resume(NoirSet)  
	coroutine.resume(LanceSet)  
	coroutine.resume(GalaSet)  

	pbadv_wait_coroutine(NoirSet) 
	pbadv_wait_coroutine(LanceSet) 
	pbadv_wait_coroutine(GalaSet) 
	
	wait_time(0.3)
	
	move_camera(19, 34, 1.0)
	
	on_active(Ef_BlFeather) 

	local gridpos = get_grid_position(18, 31)
	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)

	wait_time(0.5)
	wait_camera()

	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_360002")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360003")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360004")
	close_speech_window()

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_360006")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_360007")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360008")
	

	
	change_face(Morgan1, "Smile")
	
	message("MA_01B900_360009")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360010")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360011")
	close_speech_window()

	move_camera(21, 34, 1.0)
	wait_camera()
	
	change_face(Lancelot1, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_360013")
	close_speech_window()

	
	change_face(Morgan1, "Smile")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_360014")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360015")
	close_speech_window()

	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_360016")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_360017")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360018")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_361001")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360019")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360020")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360021")
	

	
	change_face(Morgan1, "Smile")
	
	message("MA_01B900_360022")
	close_speech_window()


	
	dot_move_unit_seq(dotGalahad1, 18, 32)
	
	wait_seq()	

	dot_change_anim(dotGalahad1,3)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.2)	
	
	dot_change_anim(dotGalahad1,0)
	dot_change_anim(dotMorgan1,6)
	dot_play_particle_unit(dotMorgan1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.2)	

	dot_change_anim(dotGalahad1,0)
	dot_change_anim(dotMorgan1,0)

	
	
	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_360024")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_360025")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360026")
	close_speech_window()

	
	dot_play_particle_unit(dotGalahad1,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotMorgan1,4)
	dot_play_particle_unit(dotMorgan1,"Ef_C_Mag_R_Atk01",3,true)
	wait_time(0.2)

	dot_change_anim(dotGalahad1,6)
	dot_change_anim(dotMorgan1,0)
	dot_play_particle_unit(dotGalahad1,"Ef_C_Mag_R_Hit01",1,true)
	dot_move_knockback(dotGalahad1, 18, 34, 0.5, 2)
	wait_time(0.5)

	dot_change_anim(dotGalahad1,0)

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_360028")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotLancelot1,24, 33)
	dot_reserve_move_unit_seq(dotArthur1,24, 32)	
	exec_parallel_seq()
	wait_seq()	

	dot_change_anim(dotLancelot1,3)
	dot_play_particle_unit(dotLancelot1,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotArthur1,4)
	dot_play_particle_unit(dotArthur1,"Ef_C_Mag_R_Atk01",3,true)
		
	wait_time(0.3)
	
	dot_unit_dir(dotArthur1, 2) 
	dot_change_anim(dotLancelot1,0)
	dot_change_anim(dotArthur1,0)
	
	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_360030")
	close_speech_window()

	
	on_active(Ef_WitchSpear1) 
	on_active(Ef_WSpearAppea1) 
	on_active(Ef_WSpearAura1) 

	local gridpos = get_grid_position(18, 31)
	gridpos[2] = 1.5 
	turn(Ef_WSpearAppea1, 45, 0, 0, 0.0)
	set_pos(Ef_WSpearAppea1, gridpos)
	play_particle(Ef_WSpearAppea1)

	wait_time(0.5)

	local gridpos = get_grid_position(18, 31)
	gridpos[2] = 1.5 
	turn(Ef_WitchSpear1, 45, 0, 0, 0.0)
	set_pos(Ef_WitchSpear1, gridpos)
	play_particle(Ef_WitchSpear1)

	local gridpos = get_grid_position(18, 31)
	gridpos[2] = 1.5 
	turn(Ef_WSpearAura1, 45, 00, 0, 0.0)
	set_pos(Ef_WSpearAura1, gridpos)
	play_particle(Ef_WSpearAura1)

	wait_time(1.5)
	
	local gridpos = get_grid_position(18, 35)
	gridpos[2] = 0.0

	slidemove(Ef_WitchSpear1, gridpos, 0.2)
	slidemove(Ef_WSpearAura1, gridpos, 0.2)

	wait_time(0.1)

	on_active(Ef_WitchSpearHit1) 
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)

	dot_move_knockback(dotGalahad1, 18, 35, 0.2, 2)
	wait_time(0.2)
	
	dot_change_anim(dotGalahad1,1)

	wait_time(1.0)

	set_pos(Ef_WSpearAppea1, gridpos)
	play_particle(Ef_WSpearAppea1)

	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WSpearAura1)

	wait_time(0.5)
	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_360032")
	

	
	
	change_face(Morgan1, "Smile")
	
	message("MA_01B900_360034")
	

	
	on_active(Ef_Roar) 

	local gridpos = get_grid_position(24, 32)
	set_pos(Ef_Roar, gridpos)
	play_particle(Ef_Roar)

	dot_unit_dir(dotArthur1, 1) 
	dot_change_anim(dotArthur1,4)
	
	wait_time(0.2)

	
	dot_move_unit_seq(dotLancelot1,24, 35)
	wait_seq()	

	dot_unit_dir(dotLancelot1, 3) 
	dot_unit_dir(dotArthur1, 2) 
	dot_change_anim(dotArthur1,0)

	
	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_360036")
	close_speech_window()

	
	dot_move_unit(dotMorgan1, 21, 33)
	wait_time(0.2)

	
	change_face(Lancelot1, "Serious")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B900_360038")
	close_speech_window()

	
	dot_move_unit(dotLancelot1, 23, 34)
	wait_time(0.2)

	dot_unit_dir(dotMorgan1, 1) 
	dot_change_anim(dotMorgan1,3)
	dot_change_anim(dotLancelot1,3)
	
	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 21, 33,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 24, 34,0)
	pbadv_setup_101015_Arthur_preload(1,true, 24, 31,0)
	pbadv_setup_101028_Galahad_preload(1,true, 18, 32,0)
	pbadv_setup_101041_Morgan_preload(1,true, 18, 31,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_526", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
end
