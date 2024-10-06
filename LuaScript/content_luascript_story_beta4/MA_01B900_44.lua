




Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201180000", "201180000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 22, 34,0)  
	pbadv_setup_101010_Lancelot(1,true, 21, 33,0)  
	
	pbadv_setup_101028_Galahad(1,true, 20, 34,0)  
	
	pbadv_setup_101055_Owen(0,true, 20, 36,0)  
	pbadv_setup_101053_Mathajim(0,true, 21, 36,0)  
	pbadv_setup_101054_Adam(0,true, 22, 36,0)  
	
	pbadv_setup_101029_Astera(1,true, 20, 37,0) 
	pbadv_setup_101035_Liliana(1,true, 21, 37,0)  
	pbadv_setup_101034_Excelia(1,true, 22, 37,0)  

	pbadv_setup_101015_Arthur(0,true, 21, 31,0)  
	
		
	
	
	
	

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	dot_unit_dir(dotArthur, 2) 


	
	
	dot_disp_weapon(dotNoir2, false) 
	dot_disp_weapon(dotGalahad1, false) 
	dot_disp_weapon(dotAdam, false) 
	dot_disp_weapon(dotOwen, false) 
	dot_disp_weapon(dotMathajim, false) 
	dot_disp_weapon(dotExcelia1, false) 
	dot_disp_weapon(dotLiliana1, false) 
	dot_disp_weapon(dotAstera1, false) 
	dot_disp_weapon(dotArthur, false) 

	
	
	

	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(21, 33, 0.0)

	
	Ef_bfog= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	Ef_bfog2= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemyhuman", false, true)

	Ef_holy= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)

	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image("101020270", "content_still_10102027_image", "101020270_StillImage")
	load_image("101020280", "content_still_10102028_image", "101020280_StillImage")

	
	show_image("101010140", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	dot_change_anim(dotArthur,1)

	load_sound("BGM_ADV_Tragedy_Painful")

end





function Play()
	fadein(0)
	Play_start(true)

	
	
	open_simple_window()
	message("MA_01B900_440002")
	
	
	
	
	message("MA_01B900_440003")
	

	
	
	message("MA_01B900_440004")
	close_simple_window()

	fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	show_image("101020270", 0.0, 0.0, 0.0 ,true,false)
	set_position_image(0,0)
	scale_to_image(1.5,1.5,10.0,"EaseInOut")
	move_to_image(-220,-50,10.0,"EaseInOut")

	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)


	bgm_play("BGM_ADV_Tragedy_Painful")

	
	open_simple_window("CHRNAME_LANCELOT2", nil, nil)
	message("MA_01B900_440006")
	

	
	
	
	message("MA_01B900_440008")
	

	
	
	message("MA_01B900_440009")
	

	
	
	message("MA_01B900_440010")
	

	
	
	message("MA_01B900_440011")
	close_simple_window()

	fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
	wait_time(0.5)
	show_image("101020280", 0.0, 0.0, 0 ,true,false)
	set_position_image(400,-50)
	scale_to_image(1.50,1.50,0.0,"EaseInOut")

	fadein(0.5)
	scale_to_image(1.0,1.0,5.0,"EaseInOut")
	move_to_image(-80,0,5.0,"EaseInOut")

	open_simple_window("CHRNAME_ARTHUR", nil, nil)
	message("MA_01B900_440012")
	close_simple_window()


	open_simple_window("CHRNAME_LANCELOT2", nil, nil)
	message("MA_01B900_440014")
	close_simple_window()

	wait_time(2.0)

	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_440015")
	

	
	change_face(Arthur, "Normal")
	
	message("MA_01B900_440017")
	close_speech_window()
	

	dot_change_anim(dotArthur,0)	
	dot_move_unit_seq(dotArthur,21, 30, 0.3)	
	wait_seq()

	dot_unit_dir(dotArthur, 2) 
	wait_time(0.5)
	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_440019")
	close_speech_window()

	
	
	change_face(Galahad1, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_440021")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B900_440022")
	

	
	change_face(Arthur, "Normal")
	
	message("MA_01B900_440023")
	

	
	change_face(Arthur, "Normal")
	
	message("MA_01B900_440024")
	

	
	change_face(Arthur, "Smile")
	
	message("MA_01B900_440025")
	

	
	change_face(Arthur, "Normal")
	
	message("MA_01B900_440026")
	

	
	change_face(Arthur, "Smile")
	
	message("MA_01B900_440027")
	
	
	
	
	change_camera_distance(7.0, 1.0)
	move_camera(21, 32, 1.0)
	wait_camera()

	on_active(Ef_bfog) 

	local gridpos = get_grid_position(21, 30)
	set_pos(Ef_bfog, gridpos)
	play_particle(Ef_bfog)
	
	dot_change_anim(dotLancelot1,1)
	
	
	change_face(Arthur, "Normal")
	
	message("MA_01B900_440029")
	close_speech_window()

	
	on_active(Ef_bfog2) 

	local gridpos = get_grid_position(21, 30)
	set_pos(Ef_bfog2, gridpos)
	play_particle(Ef_bfog2)

	wait_time(0.5)

	dot_disp_unit(dotArthur, false) 
	stop_particle(Ef_bfog)

	wait_time(2.0)
	
	
	
	open_speech_window("CHRNAME_ARTHUR", nil, nil)
	message("MA_01B900_440031")
	close_speech_window()

	
	wait_time(1.0)

	






	
	on_active(Ef_holy) 

	local gridpos = get_grid_position(22, 34)
	gridpos[2] = 0.5
	set_pos(Ef_holy, gridpos)
	play_particle(Ef_holy)

	wait_time(1.0)
	
	change_camera_distance(8.0, 0.5)
	move_camera(22, 34, 0.5)
	
	wait_camera()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_440033")
	close_speech_window()
	
	dot_disp_weapon(dotLancelot1, false) 
	dot_change_anim(dotLancelot1,0)

	wait_time(1.0)

	bgm_play("Stop_BGM_Bus_LongFade")
	
	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B900_440034")
	close_speech_window()

	
	fadeout(255, 255, 255, 1, 2.5)
	
	wait_time(3.0)
	
	
	
	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 22, 34,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 21, 33,0)
	pbadv_setup_101028_Galahad_preload(1,true, 20, 34,0)
	pbadv_setup_101055_Owen_preload(0,true, 20, 36,0)
	pbadv_setup_101053_Mathajim_preload(0,true, 21, 36,0)
	pbadv_setup_101054_Adam_preload(0,true, 22, 36,0)
	pbadv_setup_101029_Astera_preload(1,true, 20, 37,0)
	pbadv_setup_101035_Liliana_preload(1,true, 21, 37,0)
	pbadv_setup_101034_Excelia_preload(1,true, 22, 37,0)
	pbadv_setup_101015_Arthur_preload(0,true, 21, 31,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemyhuman", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image_preload("101020270", "content_still_10102027_image", "101020270_StillImage")
	load_image_preload("101020280", "content_still_10102028_image", "101020280_StillImage")
	preload_sound("BGM_ADV_Tragedy_Painful")
end
