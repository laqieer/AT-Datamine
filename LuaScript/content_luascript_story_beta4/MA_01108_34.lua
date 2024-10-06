

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	init_psbattleadv("201130000", "201130000")



	
	
	load_image("MA011083401", "content_still_10101012_image", "101010120_StillImage")

	
	show_image("MA011083401", 0.0, 0.0, 0.0,true,false)

	
	
	
	
    pbadv_setup_101009_Noir(2,true,22,12,0)
    
    pbadv_setup_101010_Lancelot(0,true,20,15,0)
    
   pbadv_setup_101012_Dinatan(0,true,21,11,0)
	
	pbadv_setup_101050_Brian(0,true,21 ,12 ,0) 
	
	pbadv_setup_101021_Bruno(3,true,20 ,12 ,0) 
    
    pbadv_setup_101011_Guinevere(0,true,22,15,0)
	
	
	change_time_and_weather(2,7)
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotGuinevere, 2)
	dot_change_anim(dotBrian,1)
	dot_unit_dir(dotBrian,2)

	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotBruno3 , false)
	dot_disp_weapon(dotBrian , false)
	dot_disp_weapon(dotLancelot , false)
	dot_disp_weapon(dotDinatan , false)
	dot_disp_weapon(dotGuinevere , false)
	

	
	
	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(21, 12, 0.0)
	
	
	Ef_Tsars_L = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Tears_L", false, true)
	Ef_NoirG = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	Ef_EnemyDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	open_simple_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340002")
	close_simple_window()

	
	
	open_simple_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_340004")
	close_simple_window()

	
	open_simple_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340005")
	close_simple_window()

	
	
	open_simple_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_340007")
	close_simple_window()

	
	
	open_simple_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340009")
	

	
	
	message("MA_01108_340010")
	close_simple_window()

	
	open_simple_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_340011")
	close_simple_window()

	
	open_simple_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340012")
	close_simple_window()

	
	
	open_simple_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_340014")
	close_simple_window()


	
	hide_image(0.6)
	wait_time(1.0)


	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_340015")
	close_speech_window()

	
	change_face(Brian, "Smile")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340016")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01108_340017")
	
	
	on_active(Ef_Tsars_L)
	local gridpos = get_grid_position(20,12)
	set_pos(Ef_Tsars_L, gridpos)
	play_particle(Ef_Tsars_L)

	
	
	change_face(Dinatan, "Sad")
	
	message("MA_01108_340019")
	close_speech_window()

	
	change_face(Brian, "Smile")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340020")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01108_340021")
	

	
	change_face(Dinatan, "Sad")
	
	message("MA_01108_340022")
	close_speech_window()

	
	change_face(Brian, "Smile")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340023")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01108_340024")
	close_speech_window()

	
	change_face(Brian, "Sad")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340025")
	close_speech_window()

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01108_340026")
	close_speech_window()

	
	change_face(Brian, "Sad")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340027")
	close_speech_window()

	
	change_face(Lancelot, "Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01108_340028")
	close_speech_window()

	
	change_face(Brian, "Smile")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340029")
	

	
	change_face(Brian, "Sad")
	
	message("MA_01108_340030")
	

	
	change_face(Brian, "Normal")
	
	message("MA_01108_340031")
	
	
	
	dot_unit_dir(dotBrian,3)

	
	change_face(Brian, "Anger")
	
	message("MA_01108_340032")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_340033")
	close_speech_window()

	
	change_face(Brian, "Normal")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340034")
	

	
	change_face(Brian, "Normal")
	
	message("MA_01108_340035")
	

	
	change_face(Brian, "Smile")
	
	message("MA_01108_340036")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_340037")
	close_speech_window()

	
	change_face(Brian, "Normal")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340038")
	

	
	change_face(Brian, "Normal")
	
	message("MA_01108_340039")
	

	
	change_face(Brian, "Smile")
	
	message("MA_01108_340040")
	

	
	
	change_face(Brian, "Normal")
	
	message("MA_01108_340042")
	

	
	change_face(Brian, "Sad")
	
	message("MA_01108_340043")
	close_speech_window()

	
	change_face(Bruno3, "Sad")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_340044")
	close_speech_window()
	
	change_camera_distance(5.0, 1.0)
	wait_time(1.0)
	wait_seq()

	
	
	change_face(Brian, "Normal")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340046")
	close_speech_window()
	

	
	
	change_face(Brian, "Smile")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_340048")
	close_speech_window()
	
	on_active(Ef_Fog) 

	local gridpos = get_grid_position(21, 12)
	set_pos(Ef_Fog, gridpos)
	play_particle(Ef_Fog)
	
	dot_disp_unit(dotBrian, false)

	on_active(Ef_EnemyDie) 

	local gridpos = get_grid_position(21, 12)
	set_pos(Ef_EnemyDie, gridpos)
	play_particle(Ef_EnemyDie)
	
	wait_time(0.5)
	
	dot_disp_unit(dotBrian, false)

	stop_particle(Ef_Fog)

	wait_time(2.0)
	
	
	
	bgm_play("Stop_BGM_Bus_MidFade")
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_340050")
	close_speech_window()
	
	dot_change_anim(dotNoir2,1)
	wait_time(0.5)
	
	
	




	
	

	
	
	
	
	
	
	
	










	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("MA011083401", "content_still_10101012_image", "101010120_StillImage")
    pbadv_setup_101009_Noir_preload(2,true,22,12,0)
    pbadv_setup_101010_Lancelot_preload(0,true,20,15,0)
   pbadv_setup_101012_Dinatan_preload(0,true,21,11,0)
	pbadv_setup_101050_Brian_preload(0,true,21 ,12 ,0)
	pbadv_setup_101021_Bruno_preload(3,true,20 ,12 ,0)
    pbadv_setup_101011_Guinevere_preload(0,true,22,15,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Tears_L", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
end
