Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	init_psbattleadv("201020001", "201020001")
	
	
	change_time_and_weather(3, 1)
	
	
	pbadv_setup_101009_Noir(3,true, 18, 17,0)  
	pbadv_setup_101011_Guinevere(0,true, 19, 17,0)   
	pbadv_setup_101010_Lancelot(3,true, 7, 17,0)  
	
	barubaroi1 = dot_reserve_enemy(1, 15, 18, 0)
	barubaroi2 = dot_reserve_enemy(1, 15, 16, 0)

	
	dotrogu1 = dot_reserve_ally(401036001, 6, 16, 0)
	dot_set_weapon(dotrogu1, 101010001)		
	dotrogu2 = dot_reserve_ally(401036001, 6, 17, 0)
	dot_set_weapon(dotrogu2, 101010001)		
	dotrogu3 = dot_reserve_ally(401036001, 6, 18, 0)
	dot_set_weapon(dotrogu3, 101010001)		

setup_complete_unit()

	
	dot_unit_dir(dotNoir3, 3)
	dot_unit_dir(dotGuinevere, 2)
	
	dot_unit_dir(barubaroi1, 3)
	dot_unit_dir(barubaroi2, 3)

		
	dot_disp_weapon(dotNoir3, false)
	dot_disp_weapon(dotGuinevere, false)

	
	dot_disp_unit(dotLancelot3, false)
	dot_disp_unit(dotrogu1, false)
	dot_disp_unit(dotrogu2, false)
	dot_disp_unit(dotrogu3, false)
	
	dot_change_anim(dotGuinevere,1)	

	dot_change_anim(barubaroi1,1)
	dot_change_anim(barubaroi2,1)
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(18, 17, 0.0)

	load_sound("BGM_ADV_Noir_Theme")

	load_sound("BGM_ADV_Ginevia_Theme")
	
	load_sound("BGM_ADV_Invation3")

	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	show_image("101010140", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	movie_load("MA_01100_05_01")

	movie_set_active(true)
	movie_play()

end

function Play()

	fadein(0)
	Play_start(true)

	movie_wait_playing()
	movie_stop()
	
	movie_load("MA_01100_10_2")
	movie_set_active(true)
	movie_play()
	hide_image(0)
	
	
	movie_wait_playing()
	movie_stop()
	
	bgm_play("BGM_ADV_Noir_Theme")
change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_NAMELES", Guinevere, nil)
	message("MA_01100_100042")
	close_speech_window()

	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100044")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_NAMELES", Guinevere, nil)
	message("MA_01100_100045")
	close_speech_window()
	
	
	dot_disp_weapon(dotNoir3, true)
	
	wait_time(0.5)	

	
	change_face(Noir3, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100047")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_NAMELES", Guinevere, nil)
	message("MA_01100_100048")
	close_speech_window()

	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100049")
	close_speech_window()
	
	
	dot_disp_weapon(dotNoir3, false)

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_NAMELES", Guinevere, nil)
	message("MA_01100_100052")
	close_speech_window()

	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100053")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	wait_time(0.5)		
	
	
	dot_change_anim(dotGuinevere,0)
	
	
	wait_time(0.5)	
	
	bgm_play("BGM_ADV_Ginevia_Theme")
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100055")
	OpenFirstAppearance(Guinevere)
	close_speech_window()

	
	bgm_play("Stop_BGM_Bus_MidFade")
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100056")
	close_speech_window()	
	
	dot_change_anim(barubaroi1,0)
	wait_time(0.1)
	
	dot_change_anim(barubaroi2,0)
	
	move_camera(16, 17, 0.5)
	wait_camera()	
	
	wait_time(0.5)	

	dot_unit_dir(dotNoir3, 2)

	dot_change_anim(barubaroi1,5)
	dot_change_anim(barubaroi2,5)	
	
	
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("MA_01100_109002")
	close_speech_window()	
	
	change_face(Noir3, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_109003")
	close_speech_window()	
	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_109004")
	close_speech_window()		

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(3,true, 18, 17,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 19, 17,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 7, 17,0)
	preload_sound("BGM_ADV_Noir_Theme")
	preload_sound("BGM_ADV_Ginevia_Theme")
	preload_sound("BGM_ADV_Invation3")
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	movie_load_preload("MA_01100_05_01")
end
