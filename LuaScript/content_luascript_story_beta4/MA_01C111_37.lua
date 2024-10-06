

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201090100", "201090100")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101051_Lucius(0,true,13,3,0)
    pbadv_setup_101009_Noir(2,true,13,2,0) 
   	pbadv_setup_101037_Rasia(3,true,11,1,0)
	pbadv_setup_101039_Fren(0,true,11,4,0)
    pbadv_setup_101012_Dinatan(1,true,13,4,0)	
	pbadv_setup_101022_Mordred(0,true,10,2,0) 
	pbadv_setup_101023_Clarice(0,true,10,3,0)
	pbadv_setup_101052_Vernarth(0,true,11,2,0)
		
	pbadv_setup_101042_Moronoe(true,16,3,0)  
	pbadv_setup_101044_Gliten(true,16,2,0) 
	pbadv_setup_101049_Thiton(true,16,4,0)  

	setup_complete_unit()
	
	
	
	Ef_WitchPortal = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(14, 3, 0.0)

	movie_load("MA_01C111_37")
	load_sound("SE_ADV_Movie")

	load_sound("BGM_ADV_Painful2")
end





function Play()
	fadein(0)
	Play_start(true)


	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01C111_370002")
	close_speech_window()

	
	
	change_face(Gliten, "Smile")
	open_speech_window("CHRNAME_SISTERS_3",nil,Gliten)
	message("MA_01C111_370004")
	
	change_face(Gliten, "Smile")
	message("MA_01C111_370005")
	close_speech_window()
	
	movie_set_active(true)
	movie_play()
	movie_wait_playing()	
	
	
	dot_change_anim(dotLucius, 1)	
	
	
	dot_disp_unit(dotGliten,false)	
	
	dot_place_unit(dotDinatan1,13, 3)
	

	
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01C111_370028")
	close_speech_window()
	
	

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_370029")
	close_speech_window()
	
	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01C111_370030")
	
	change_face(Moronoe, "Smile")
	message("MA_01C111_370031")
	close_speech_window()
	
	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C111_370032")
	close_speech_window()
	
	
	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01C111_370033")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")

	
	on_active(Ef_WitchPortal)

	local gridpos = get_grid_position(16, 4)
	set_pos(Ef_WitchPortal, gridpos)
	set_scale(Ef_WitchPortal, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal)

	on_active(Ef_WitchPortal2)

	local gridpos = get_grid_position(16, 3)
	set_pos(Ef_WitchPortal2, gridpos)
	set_scale(Ef_WitchPortal2, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal2)

	wait_time(1.0)

	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotThiton,false)	

	wait_time(2.0)	
	
	
	
	wait_time(1.0)		
	
	
	move_camera(12, 3, 1.0)
	wait_camera()	
	
	dot_unit_dir(dotDinatan1, 2)		
	
	bgm_play("BGM_ADV_Painful2")
	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_370035")
	close_speech_window()

	
	change_face(Fren, "Anger")
	open_speech_window("CHRNAME_FREN",Fren , nil)
	message("MA_01C111_370036")
	close_speech_window()

	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_370037")
	close_speech_window()

	
	change_face(Fren, "Sad")
	open_speech_window("CHRNAME_FREN",Fren , nil)
	message("MA_01C111_370038")
	close_speech_window()

	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius , nil)
	message("MA_01C111_370039")
	close_speech_window()

	

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101051_Lucius_preload(0,true,13,3,0)
    pbadv_setup_101009_Noir_preload(2,true,13,2,0)
   	pbadv_setup_101037_Rasia_preload(3,true,11,1,0)
	pbadv_setup_101039_Fren_preload(0,true,11,4,0)
    pbadv_setup_101012_Dinatan_preload(1,true,13,4,0)
	pbadv_setup_101022_Mordred_preload(0,true,10,2,0)
	pbadv_setup_101023_Clarice_preload(0,true,10,3,0)
	pbadv_setup_101052_Vernarth_preload(0,true,11,2,0)
	pbadv_setup_101042_Moronoe_preload(true,16,3,0)
	pbadv_setup_101044_Gliten_preload(true,16,2,0)
	pbadv_setup_101049_Thiton_preload(true,16,4,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	movie_load_preload("MA_01C111_37")
	preload_sound("SE_ADV_Movie")
	preload_sound("BGM_ADV_Painful2")
end
