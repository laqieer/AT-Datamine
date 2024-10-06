

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)











	
	
	

	
	stillAnime = load_ui_effect("content_still_10102006_anim", "10102006_StillAnim", nil, nil, nil, "Root")
	
	
	init_psbattleadv("201200000", "201200000")
	
	
	change_time_and_weather(1, 5)

	pbadv_setup_101009_Noir(2,true, 39, 14,0)  
	pbadv_setup_101010_Lancelot(1,true, 37, 12,0)  
	
	pbadv_setup_101036_Viena(1,true, 41, 10,0)  
	pbadv_setup_101026_Percival(0,true, 36, 15,0)  
	pbadv_setup_101027_Dindrane(2,true, 38, 15,0)  


	pbadv_setup_101028_Galahad(3,true, 38, 12,0)   


	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotViena1, 2)	
	dot_unit_dir(dotNoir2, 2)	
	dot_unit_dir(dotDindrane2, 2)
	dot_unit_dir(dotGalahad3, 2)

	dot_change_anim(dotGalahad3, 1)
	dot_change_anim(dotViena1, 1)


	
	Ef_BriB = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)	
	
	Ef_Aura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)	
	Ef_Aura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(37, 14, 0.0)

	load_sound("BGM_ADV_Noir_adoption")
end

function Play()
	fadein(0)
	Play_start(true)




	
	
	
	
	
	
	dot_change_anim(dotGalahad3, 0)

	
	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_270002")
	close_speech_window()

	
	change_face(Dindrane2, "Anger")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_270003")
	close_speech_window()

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_270004")
	close_speech_window()

	
	
	change_face(Dindrane2, "Anger")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_270006")
	close_speech_window()

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_270007")
	close_speech_window()

	
	change_face(Dindrane2, "Anger")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_270008")
	close_speech_window()

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_270009")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_270010")
	close_speech_window()

	
	

	
	move_camera(38, 12, 0.5)
	wait_camera()
	
	
	dot_attack_seq(dotGalahad3, dotLancelot1)
	dot_damage_seq(dotLancelot1, dotGalahad3, true)
	
		
	wait_seq()
	
	
	dot_change_anim(dotLancelot1, 6)
	dot_move_knockback(dotLancelot1, 33, 12,0.5, 2)
	
	
	wait_time(0.4)
	
	
	dot_unit_dir(dotLancelot1, 3)
	dot_change_anim(dotLancelot1, 0)
	
	
	wait_time(0.7)
	
	
	dot_move_unit_seq(dotGalahad3, 36, 12)
	
	
	wait_time(0.8)
	
	
	move_camera(37, 14, 0.4)
	wait_time(0.4)
	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_270012")
	close_speech_window()

	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_270014")
	close_speech_window()

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_270015")

	
	
	
	change_face(Percival, "Anger")
	message("MA_01B111_270017")
	close_speech_window()

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_270019")

	
	
	
	change_face(Noir2, "Anger")
	message("MA_01B111_270021")
	close_speech_window()

	


	
	dot_move_unit_seq(dotNoir2, 38, 12)
	wait_seq()

	
	change_face(Dindrane2, "Surprise")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_270023")
	close_speech_window()


	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_270024")
	close_speech_window()

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_270025")
	close_speech_window()

	bgm_play("BGM_ADV_Noir_adoption")
	
	
	move_camera(38, 12, 0.3)

	
	dot_disp_weapon(dotNoir2, false)	
	
	wait_time(0.3)

	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_270027")

	
	
	
	
	change_face(Noir2, "Serious")
	message("MA_01B111_270029")
	close_speech_window()

	
	
	
	dot_move_unit_seq(dotGalahad3, 35, 12)	
	
	
	open_cutin(1,1)
	
	on_cutin(1,Noir2,"Serious") 

	

	

	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01B111_270031")
	close_speech_window()

	
	close_cutin()
	wait_seq()
	
	dot_unit_dir(dotGalahad3, 3)	
	
	
	move_camera(35, 12, 0.6)
	wait_camera()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_270032")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_270033")
	close_speech_window()

	
	
	
	open_narration_window()
	message("MA_01B111_270035")
	close_narration_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_270036")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_270038")
	close_speech_window()

	
	dot_change_anim(dotGalahad3, 3)

	on_active(Ef_BriB )
	local gridpos = get_grid_position(35, 12)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )
	wait_time(1.0)		

	dot_change_anim(dotGalahad3, 0)
	
	
	dot_move_unit_seq(dotGalahad3, 37,12)
	
	
	wait_seq()

	dot_unit_dir(dotGalahad3, 3)
	
	
	dot_attack_seq(dotGalahad3, dotNoir2)
	dot_damage_seq(dotNoir2, dotGalahad3, true)
	
	
	wait_seq()
	
	wait_time(1.0)	
	
	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_270040")
	close_speech_window()

	
		
	move_camera(37, 12, 0.8)
	wait_camera()
	
	wait_time(0.5)		
	
	on_active(Ef_Aura )
	local gridpos = get_grid_position(37,12)
	set_pos(Ef_Aura , gridpos)
	play_particle(Ef_Aura )
	
	on_active(Ef_Aura2 )
	local gridpos = get_grid_position(38,12)
	set_pos(Ef_Aura2 , gridpos)
	play_particle(Ef_Aura2 )
	wait_time(1.0)		
	
	
	fadeout(0, 0, 0, 0, STILL_SWITCH_TIME )
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
	stillAnime.SetActive(true)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end


	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01B111_270042")

	
	
	message("MA_01B111_270044")

	
	
	
	message("MA_01B111_270046")

	
	
	message("MA_01B111_270048")
	close_simple_window()
	
	
	
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
	fadeout(255, 255, 255, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
	stillAnime.SetActive(false)
	


	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_ui_effect_preload("content_still_10102006_anim", "10102006_StillAnim", nil, nil, nil, "Root")
	pbadv_setup_101009_Noir_preload(2,true, 39, 14,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 37, 12,0)
	pbadv_setup_101036_Viena_preload(1,true, 41, 10,0)
	pbadv_setup_101026_Percival_preload(0,true, 36, 15,0)
	pbadv_setup_101027_Dindrane_preload(2,true, 38, 15,0)
	pbadv_setup_101028_Galahad_preload(3,true, 38, 12,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)
	preload_sound("BGM_ADV_Noir_adoption")
end
