

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)










	
	
	
	init_psbattleadv("201200000", "201200000")

	change_time_and_weather(BattleTime_Day, BattleWeather_Snowstorm)

	pbadv_setup_101009_Noir(2,true, 39, 4,0)  
	pbadv_setup_101010_Lancelot(1,true, 40, 5,0)  
	pbadv_setup_101036_Viena(1,true, 36, 4,0)  
	pbadv_setup_101026_Percival(0,true, 37, 4,0)  
	pbadv_setup_101027_Dindrane(2,true, 36, 5,0)  

	pbadv_setup_101028_Galahad(3,true, 38, 3,0)   
	pbadv_setup_101028_Galahad(1,true, 40, 40,0)   


	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	dot_unit_dir(dotLancelot1, 2)
	dot_unit_dir(dotNoir2, 2)


	dot_change_anim(dotNoir2, 0)

	dot_change_anim(dotDindrane2, 0)
	dot_change_anim(dotViena1, 1)

	dot_change_anim(dotLancelot1, 0)


	
	

	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotLancelot1,false)
	dot_disp_weapon(dotDindrane2,false)
	dot_disp_weapon(dotViena1,false)
	dot_disp_weapon(dotPercival,false)

	dot_disp_unit(dotGalahad1,false)
	
	
	
	change_camera_distance(7.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(38, 4, 0.0)

	
	Ef_Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)

end

function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	
	change_face(Galahad3, "Special")
	open_speech_window("CHRNAME_GALAHAD", Galahad3, nil)
	message("MA_01B111_250002")
	close_speech_window()

	dot_change_unit(dotGalahad3,dotGalahad1,0)
	dot_change_anim(dotGalahad1, 1)

	
	change_face(Lancelot1, "Surprise")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_250003")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_250004")

	
	message("MA_01B111_250005")

	
	message("MA_01B111_250006")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_250007")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_250008")

	
	message("MA_01B111_250009")
	close_speech_window()

	
	change_face(Percival, "Sad")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_250010")
	close_speech_window()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_250011")
	close_speech_window()

	
	open_cutin(1,1)
	
	on_cutin(1,Galahad1,"Sad")

	
	open_speech_window("CHRNAME_GALAHAD", nil, nil)
	message("MA_01B111_250012")
	close_speech_window()

	
	close_cutin()

	dot_change_unit(dotGalahad1,dotGalahad3,0)
	dot_change_anim(dotGalahad3, 1)

	
	on_active(Ef_Roar)

	se_play("SE_ADV_MA_01A111_39_Gallahad_Roar")
	
	local gridpos = get_grid_position(38, 3)
	set_pos(Ef_Roar, gridpos)
	set_scale(Ef_Roar, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar)

	dot_change_anim(dotGalahad3, 0)

	wait_time(1.5)

	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 39, 4,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 40, 5,0)
	pbadv_setup_101036_Viena_preload(1,true, 36, 4,0)
	pbadv_setup_101026_Percival_preload(0,true, 37, 4,0)
	pbadv_setup_101027_Dindrane_preload(2,true, 36, 5,0)
	pbadv_setup_101028_Galahad_preload(3,true, 38, 3,0)
	pbadv_setup_101028_Galahad_preload(1,true, 40, 40,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
end
