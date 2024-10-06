




Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101010_Lancelot(3,true, 22, 5,0)  
	pbadv_setup_101015_Arthur(0,true, 23, 5,0)  

	pbadv_setup_101020_Merlin(2,true, 20, 5,0)  
	pbadv_setup_101009_Noir(2,true, 21, 6,0)  
	
	pbadv_setup_101013_Gawain(0,true, 27, 4,0)  
	pbadv_setup_101041_Morgan(1,true, 26, 26,0) 
	pbadv_setup_101041_Morgan(2,true, 26, 5,0) 
	
	
	pbadv_setup_101056_Perez(1,true, 25, 3,0)  
	pbadv_setup_101058_Laiens(1,true, 25, 5,0)  
	
	
	
	
	
	barbaroi1 = dot_reserve_enemy(49, 27, 4, 0)
	
	barbaroi3 = dot_reserve_enemy(49, 27, 6, 0)

	barbaroi4 = dot_reserve_enemy(1300, 26, 1, 0)
	barbaroi5 = dot_reserve_enemy(1300, 26, 6, 0)


	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotMorgan2, 2)
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotLaiens1, 2)


	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotMerlin2, false)
	dot_disp_weapon(dotGawain, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotMorgan2, false)

	dot_disp_weapon(dotArthur, false)
	
	
	dot_disp_unit(dotPerez1, false) 
	dot_disp_unit(dotLaiens1, false) 
	dot_disp_unit(dotMorgan1, false) 
	
	dot_disp_unit(barbaroi1, false) 
	dot_disp_unit(barbaroi3, false) 
	dot_disp_unit(barbaroi4, false) 
	dot_disp_unit(barbaroi5, false) 

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(23, 6, 0.0)

	
	Ef_BigEneAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)

	Ef_WitchChange = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)

	
	Ef_EneAura_A = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	Ef_EneAura_M = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	Ef_EneAura_M2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)

	Ef_bar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	Ef_Roar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)


	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_526", false, true)
	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	on_active(Ef_EneAura_A) 

	local gridpos = get_grid_position(23, 5)
	set_pos(Ef_EneAura_A, gridpos)
	play_particle(Ef_EneAura_A)

	load_sound("BGM_Battle_Boss_Start")

	movie_load("MA_01B900_15")

end



function Play()
	fadein(0)
	Play_start(true)

	
	

	
	
	dot_change_anim(dotArthur, 1)
	wait_time(1.0)	


	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01B900_150002")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_150004")
	close_speech_window()

	
	change_face(Gawain, "Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01B900_150005")
	close_speech_window()

	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01B900_150006")
	

	
	change_face(Morgan2, "Normal")
	
	message("MA_01B900_150007")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_150008")
	close_speech_window()

	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01B900_150009")
	

	
	change_face(Morgan2, "Normal")
	
	message("MA_01B900_150011")
	

	

	
	change_face(Morgan2, "Normal")
	
	message("MA_01B900_150013")
	

	
	change_face(Morgan2, "Normal")
	
	message("MA_01B900_150014")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_150015")
	close_speech_window()


	
	change_face(Morgan2, "Smile")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01B900_150017")
	close_speech_window()

	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_150018")
	close_speech_window()

	
	on_active(Ef_BigEneAura) 

	local gridpos = get_grid_position(23, 5)
	set_pos(Ef_BigEneAura, gridpos)
	play_particle(Ef_BigEneAura)

	
	
	change_camera_distance(8.0, 1.0)
	move_camera(23, 6, 1.0)

	wait_camera()

	
	change_face(Lancelot3, "Pain")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_150020")
	close_speech_window()

	
	dot_disp_weapon(dotLancelot3, true)
	dot_change_anim(dotLancelot3, 12)

	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_150022")
	close_speech_window()

	dot_move_unit_seq(dotGawain,21, 4)
	
	wait_seq()

	dot_disp_weapon(dotGawain, false)
	dot_unit_dir(dotGawain, 3)


	
	change_face(Gawain, "Sad")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01B900_150023")
	close_speech_window()

	

	
	open_narration_window()
	message("MA_01B900_150025")
	close_narration_window()

	
	dot_change_anim(dotLancelot3, 0)

	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_150027")
	close_speech_window()

	
	open_narration_window()
	message("MA_01B900_150028")
	close_narration_window()
	
	
	
	dot_move_unit_seq(dotLancelot3,21, 5)
	wait_seq()
	
	dot_unit_dir(dotLancelot3, 3)

	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_150030")
	close_speech_window()

	
	change_face(Morgan2, "Anger")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01B900_150031")
	

	move_camera(25, 6, 1.0)

	wait_camera()

	
	change_face(Morgan2, "Anger")
	
	message("MA_01B900_150032")
	close_speech_window()

	se_play("SE_dark_Aura")
	
	on_active(Ef_EneAura_M2) 

	local gridpos = get_grid_position(26, 5)
	set_pos(Ef_EneAura_M2, gridpos)
	play_particle(Ef_EneAura_M2)

	wait_time(0.3)
	
	on_active(Ef_EneAura_M) 

	local gridpos = get_grid_position(26, 5)
	set_pos(Ef_EneAura_M, gridpos)
	play_particle(Ef_EneAura_M)
	
	wait_time(1.0)

	
	
	on_active(Ef_WitchSpear1) 
	on_active(Ef_WSpearAppea1) 
	on_active(Ef_WSpearAura1) 

	local gridpos = get_grid_position(26, 5)
	gridpos[2] = 2.5 
	turn(Ef_WSpearAppea1, 20, 90, 0, 0.0)
	set_pos(Ef_WSpearAppea1, gridpos)
	play_particle(Ef_WSpearAppea1)

	wait_time(0.5)

	local gridpos = get_grid_position(26, 5)
	gridpos[2] = 2.5 
	turn(Ef_WitchSpear1, 20, 90, 0, 0.0)
	set_pos(Ef_WitchSpear1, gridpos)
	play_particle(Ef_WitchSpear1)

	local gridpos = get_grid_position(26, 5)
	gridpos[2] = 2.5 
	turn(Ef_WSpearAura1, 20, 90, 0, 0.0)
	set_pos(Ef_WSpearAura1, gridpos)
	play_particle(Ef_WSpearAura1)

	wait_time(1.5)

	
	
	local gridpos = get_grid_position(19, 5)
	gridpos[2] = 1.11

	slidemove(Ef_WitchSpear1, gridpos, 0.2)
	slidemove(Ef_WSpearAura1, gridpos, 0.2)

	move_camera(20, 6, 0.2)
	change_camera_distance(7.0, 0.2)
	wait_camera()

	on_active(Ef_WitchSpearHit1) 
	local gridpos = get_grid_position(20, 5)
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)

	dot_change_anim(dotMerlin2, 6)
	wait_time(0.3)
	
	
	change_face(Merlin2, "Pain")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B900_150034")
	close_speech_window()

	local gridpos = get_grid_position(19, 5)
	gridpos[2] = 1.11

	set_pos(Ef_WSpearAppea1, gridpos)
	play_particle(Ef_WSpearAppea1)

	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WSpearAura1)

	wait_time(0.5)
	dot_change_anim(dotMerlin2, 1)

	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_150035")
	close_speech_window()

	
	move_camera(26, 6, 1.0)
	wait_camera()


	
	dot_place_unit(dotPerez1,25, 4)
	dot_place_unit(barbaroi4,26, 4)

	dot_unit_dir(dotPerez1, 2)

	on_active(Ef_bar) 
	on_active(Ef_bar2) 
	
	local gridpos = get_grid_position(25, 4)
	set_pos(Ef_bar, gridpos)
	set_scale(Ef_bar, {0.8, 0.8, 0.8})
	play_particle(Ef_bar)

	wait_time(0.2)

	dot_disp_unit(dotPerez1, true) 
	
	wait_time(0.5)
	

	local gridpos = get_grid_position(25, 5)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	wait_time(0.2)

	dot_disp_unit(dotLaiens1, true) 

	wait_time(1.0)

	
	on_active(Ef_Roar) 

	local gridpos = get_grid_position(25, 5)
	set_pos(Ef_Roar, gridpos)
	play_particle(Ef_Roar)

	dot_change_anim(dotPerez1, 5)
	dot_change_anim(dotLaiens1, 5)

	wait_time(0.7)

	dot_change_anim(dotPerez1, 0)
	dot_change_anim(dotLaiens1, 0)

	
	local gridpos = get_grid_position(27, 4)
	set_pos(Ef_bar, gridpos)
	set_scale(Ef_bar, {0.8, 0.8, 0.8})
	play_particle(Ef_bar)

	on_active(Ef_bar3) 

	local gridpos = get_grid_position(27, 6)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	on_active(Ef_bar4) 

	local gridpos = get_grid_position(26, 4)
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8})
	play_particle(Ef_bar4)

	on_active(Ef_bar5) 

	local gridpos = get_grid_position(26,6)
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8})
	play_particle(Ef_bar5)

	wait_time(0.2)

	dot_disp_unit(barbaroi1, true) 
	dot_disp_unit(barbaroi3, true) 
	dot_disp_unit(barbaroi4, true) 
	dot_disp_unit(barbaroi5, true) 

	wait_time(2.0)
	
	dot_disp_weapon(dotNoir2, true)

	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01B900_150037")
	close_speech_window()

	move_camera(23, 6, 1.0)
	wait_camera()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_150039")
	close_speech_window()

	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", Morgan2, nil)
	message("MA_01B900_150040")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")

	se_play("SE_dark_Transform")
	stop_particle(Ef_EneAura_M)


	off_active(Ef_bar) 
	off_active(Ef_bar2) 
	off_active(Ef_Roar) 
	off_active(Ef_bar3) 
	off_active(Ef_bar4) 
	off_active(Ef_bar5) 
	off_active(Ef_WitchSpearHit1) 
	off_active(Ef_WitchSpear1) 
	off_active(Ef_WSpearAppea1) 
	off_active(Ef_WSpearAura1) 




	movie_set_active(true)

	movie_play()
	

	dot_change_unit(dotMorgan2,dotMorgan1,0)

	wait_time(2.0)

	
	movie_wait_playing()

	movie_stop()
	wait_time(BLACK_WHITE_WAIT_TIME)


	bgm_play("BGM_Battle_Boss_Start")
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_150042")
	

	
	change_face(Morgan1, "Smile")
	
	message("MA_01B900_150043")
	
	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150044")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150045")
	close_speech_window()


	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01B900_150046")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_150047")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150048")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150050")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150051")
	close_speech_window()

	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_150052")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_150053")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150054")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150055")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150056")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01B900_150057")
	close_speech_window()

	
	change_face(Lancelot3, "Pain")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B900_150058")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01B900_150059")
	

	se_play("SE_dark_Roar")

	on_active(Ef_Roar) 

	local gridpos = get_grid_position(26, 5)
	set_pos(Ef_Roar, gridpos)
	play_particle(Ef_Roar)

	on_active(Ef_Roar2) 

	local gridpos = get_grid_position(26, 5)
	set_pos(Ef_Roar2, gridpos)
	play_particle(Ef_Roar2)

	dot_change_anim(barbaroi1, 5)
	
	dot_change_anim(barbaroi3, 5)
	dot_change_anim(barbaroi4, 5)
	dot_change_anim(barbaroi5, 5)
	dot_change_anim(dotPerez1, 5)
	dot_change_anim(dotLaiens1, 5)

	wait_time(0.7)

	dot_change_anim(barbaroi1, 0)
	
	dot_change_anim(barbaroi3, 0)
	dot_change_anim(barbaroi4, 0)
	dot_change_anim(barbaroi5, 0)
	dot_change_anim(dotPerez1, 0)
	dot_change_anim(dotLaiens1, 0)
	

	
	change_face(Morgan1, "Smile")
	
	message("MA_01B900_150061")
	close_speech_window()





	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101010_Lancelot_preload(3,true, 22, 5,0)
	pbadv_setup_101015_Arthur_preload(0,true, 23, 5,0)
	pbadv_setup_101020_Merlin_preload(2,true, 20, 5,0)
	pbadv_setup_101009_Noir_preload(2,true, 21, 6,0)
	pbadv_setup_101013_Gawain_preload(0,true, 27, 4,0)
	pbadv_setup_101041_Morgan_preload(1,true, 26, 26,0)
	pbadv_setup_101041_Morgan_preload(2,true, 26, 5,0)
	pbadv_setup_101056_Perez_preload(1,true, 25, 3,0)
	pbadv_setup_101058_Laiens_preload(1,true, 25, 5,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_526", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	preload_sound("BGM_Battle_Boss_Start")
	movie_load_preload("MA_01B900_15")
end
