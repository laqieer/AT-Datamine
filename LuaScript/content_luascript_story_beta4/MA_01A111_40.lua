

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201200000", "201200000")
	change_time_and_weather(1,1)
	
	
	
	pbadv_setup_101009_Noir(2,true,9,15,0)
	pbadv_setup_101011_Guinevere(1,true,9,16,0)
	pbadv_setup_101036_Viena(1,true,13,9,0)
	pbadv_setup_101010_Lancelot(0,true,11,7,0)
	pbadv_setup_101034_Excelia(1,true,15,5,0)
	pbadv_setup_101035_Liliana(1,true,9,5,0)
	pbadv_setup_101028_Galahad(3,true,11,5,0)
	pbadv_setup_101054_Adam(0,true,8,6,0)
	pbadv_setup_101053_Mathajim(0,true,14,6,0)
		
	
	
	setup_complete_unit()
	

	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(12,13, 0.0)
	
	
	dot_unit_dir(dotViena1, DotDir_Left)
	dot_change_anim(dotViena1,DotAnim_Squat)
	dot_unit_dir(dotExcelia1, DotDir_Left)
	dot_change_anim(dotExcelia1,DotAnim_Squat)
	dot_unit_dir(dotMathajim, DotDir_Left)
	dot_change_anim(dotMathajim,DotAnim_Squat)
	dot_unit_dir(dotLiliana1, DotDir_Right)
	dot_change_anim(dotLiliana1,DotAnim_Squat)
	dot_unit_dir(dotAdam, DotDir_Right)
	dot_change_anim(dotAdam,DotAnim_Squat)
	wait_seq()
	
	
	Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true) 
	

	
	
	on_active(Ef_Aura_Enemy )
	local gridpos = get_grid_position(11,5) 
	set_pos(Ef_Aura_Enemy, gridpos)
	play_particle(Ef_Aura_Enemy)
	
end





function Play()
	Play_start(true)


	
	
	dot_reserve_move_unit_seq(dotNoir2, 11,9)
	dot_reserve_move_unit_seq(dotGuinevere1, 12,9)
	exec_parallel_seq()
	
	move_camera(12,10, 1.0)
	fadein(0.5)
	
	wait_time(1.0)
	
	wait_seq()
	dot_unit_dir(dotGuinevere1, DotDir_Left)
	
	dot_change_anim(dotViena1,DotAnim_Squat)
	
	open_cutin(1,1)
	on_cutin(1,Viena1,"Sad",0)
	
	change_face(Viena1,"Sad")
	open_speech_window("CHRNAME_VIENA2", nil, nil)
	message("MA_01A111_400002")
	close_speech_window()
	
	close_cutin()	
	
	move_camera(11,8, 0.5)
	

	
	dot_move_unit_seq(dotLancelot,12,7)
	dot_change_anim(dotGalahad3,DotAnim_Attack)
	wait_seq()
	wait_camera()
	
	local gridpos3 = get_grid_position(11,7) 
	dot_move_unit_seq(dotGalahad3,11,7)
	slidemove(Ef_Aura_Enemy,gridpos3,0.25)
	
	dot_unit_dir(dotLancelot, DotDir_Left)
	wait_seq()
	
	dot_unit_dir(dotGalahad3, DotDir_Right)
	dot_change_anim(dotGalahad3,DotAnim_Attack)
	dot_play_particle_unit(dotGalahad3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotLancelot,DotAnim_Attack)
	dot_play_particle_unit(dotLancelot,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	
	dot_dodge_seq(dotGalahad3)
	
	dot_dodge_seq(dotLancelot)
	wait_time(0.8)
	dot_change_anim(dotGalahad3,0)
	dot_change_anim(dotLancelot,0)
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_400003")
	close_speech_window()
	
	dot_change_anim(dotViena1,DotAnim_Squat)
	
	
	change_face(Liliana1,"Anger")
	open_speech_window("CHRNAME_LILIANA2", Liliana1, nil)
	message("MA_01A111_400005")

	dot_change_anim(dotGalahad3,DotAnim_Attack)
	dot_play_particle_unit(dotGalahad3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotLancelot,DotAnim_Attack)
	dot_play_particle_unit(dotLancelot,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	
	dot_dodge_seq(dotGalahad3)
	
	dot_dodge_seq(dotLancelot)
	wait_time(0.8)
	dot_change_anim(dotGalahad3,0)
	dot_change_anim(dotLancelot,0)
	
	message("MA_01A111_400006")
	close_speech_window()
	
	move_camera(12,10, 1.0)
	wait_time(1.0)
	
	
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01A111_400007")

	dot_unit_dir(dotGuinevere1, DotDir_Right)

	dot_change_anim(dotGalahad3,DotAnim_Attack)
	dot_play_particle_unit(dotGalahad3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotLancelot,DotAnim_Attack)
	dot_play_particle_unit(dotLancelot,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	
	dot_dodge_seq(dotGalahad3)
	
	dot_dodge_seq(dotLancelot)
	wait_time(0.8)
	dot_change_anim(dotGalahad3,0)
	dot_change_anim(dotLancelot,0)
	
	change_face(Viena1,"Anger")
	message("MA_01A111_400009")
	close_speech_window()

	
	change_face(Excelia1,"Sad")
	open_speech_window("CHRNAME_EXCELIA2", Excelia1, nil)
	message("MA_01A111_400010")

	dot_change_anim(dotGalahad3,DotAnim_Attack)
	dot_play_particle_unit(dotGalahad3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotLancelot,DotAnim_Attack)
	dot_play_particle_unit(dotLancelot,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	
	dot_dodge_seq(dotGalahad3)
	
	dot_dodge_seq(dotLancelot)
	wait_time(0.8)
	dot_change_anim(dotGalahad3,0)
	dot_change_anim(dotLancelot,0)
	
	message("MA_01A111_400011")

	
	message("MA_01A111_400012")
	close_speech_window()

	dot_change_anim(dotGalahad3,DotAnim_Attack)
	dot_play_particle_unit(dotGalahad3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotLancelot,DotAnim_Attack)
	dot_play_particle_unit(dotLancelot,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	
	dot_dodge_seq(dotGalahad3)
	
	dot_dodge_seq(dotLancelot)
	wait_time(0.8)
	dot_change_anim(dotGalahad3,0)
	dot_change_anim(dotLancelot,0)
	
	change_face(Viena1,"Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01A111_400013")
	close_speech_window()
	
	move_camera(11,6, 0.5)
	wait_time(1.0)
	
	
	dot_attack_seq(dotGalahad3,dotLancelot)
	wait_seq()
	dot_damage_seq(dotLancelot, dotGalahad3, true)
	wait_seq()
	dot_change_anim(dotLancelot,DotAnim_Squat)
	dot_change_anim(dotGalahad3,DotAnim_Idle)

	dot_move_knockback(dotLancelot,14,7,0.2,2)
	exec_parallel_seq()
	wait_seq()
	dot_change_anim(dotLancelot,1)
	
	dot_unit_dir(dotGuinevere1, DotDir_Left)
	
	move_camera(11,7, 0.5)
	wait_time(1.0)

	
	change_face(Viena1,"Surprise")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01A111_400015")
	close_speech_window()


	se_play("SE_ADV_MA_01A111_39_Gallahad_Roar")
	wait_time(2.0)


	change_face(Guinevere1,"Sad")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_400017")
	close_speech_window()

	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_400018")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_400019")

	
	change_face(Guinevere1,"Pain")
	message("MA_01A111_400020")
	close_speech_window()

	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_400021")
	close_speech_window()

	
	change_face(Guinevere1,"Sad")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_400022")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_400023")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_400024")

	
	message("MA_01A111_400025")

	
	change_face(Guinevere1,"Pain")
	message("MA_01A111_400026")
	close_speech_window()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,9,15,0)
	pbadv_setup_101011_Guinevere_preload(1,true,9,16,0)
	pbadv_setup_101036_Viena_preload(1,true,13,9,0)
	pbadv_setup_101010_Lancelot_preload(0,true,11,7,0)
	pbadv_setup_101034_Excelia_preload(1,true,15,5,0)
	pbadv_setup_101035_Liliana_preload(1,true,9,5,0)
	pbadv_setup_101028_Galahad_preload(3,true,11,5,0)
	pbadv_setup_101054_Adam_preload(0,true,8,6,0)
	pbadv_setup_101053_Mathajim_preload(0,true,14,6,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
end
