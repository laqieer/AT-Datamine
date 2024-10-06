Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201170000", "201170000")
	change_time_and_weather(1,1) 

	
	pbadv_setup_101009_Noir(2,true, 6, 6, 0)  
	pbadv_setup_101012_Dinatan(1,true, 7, 6, 0)  

	ryuu = dot_reserve_ally(201021001, 6, 3, 0)	
	dot_set_weapon(ryuu, 101010001)		
	
	barbaroi1 = dot_reserve_enemy(49, 4, 3, 0)
	barbaroi2 = dot_reserve_enemy(42, 4, 5, 0)	
	barbaroi3 = dot_reserve_enemy(1100, 8, 4, 0)	

setup_complete_unit()

	
	
	dot_unit_dir(ryuu, 2)
	
	

	

	
	change_camera_distance(10.0, 0.0)
	change_camera_angle(40.0, 0.0)
	move_camera(6, 5, 0.0)

	movie_load("MA_01C900_27")

	
	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	
	
	show_image("101010140", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	
	load_image("101040140", "content_still_10104014_image", "101040140_StillImage")

	load_sound("BGM_ADV_WhiteDragon_D")
	load_sound("BGM_ADV_Geshturtshift_adoption")
	
end



function Play()
	fadein(0)
	Play_start(true)


	
	open_simple_window("")
	message("MA_01C900_270002")
	close_simple_window()

	wait_time(1.0)

	
	hide_image(0)
	
	
	
	
	
	






















































	movie_set_active(true)
	bgm_play("BGM_ADV_WhiteDragon_D")
	movie_play()



	show_image("101040140", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) 

	movie_wait_playing()
	
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)

	bgm_play("BGM_ADV_Geshturtshift_adoption")
	
	open_simple_window("CHRNAME_ARTHUR")
	message("MA_01C900_270009")
	

	
	
	message("MA_01C900_270010")
	

	
	
	message("MA_01C900_270011")
	

	bgm_play("Stop_BGM_Bus_MidFade")
	
	
	message("MA_01C900_270013")
	close_simple_window()

	
	wait_time(1.0)
	
	fadeout(255,255,255,1.0, FADE_TIME + 1.0)

	wait_time(TIME_ELAPSED + FADE_TIME)


	
	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 6, 6, 0)
	pbadv_setup_101012_Dinatan_preload(1,true, 7, 6, 0)
	movie_load_preload("MA_01C900_27")
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image_preload("101040140", "content_still_10104014_image", "101040140_StillImage")
	preload_sound("BGM_ADV_WhiteDragon_D")
	preload_sound("BGM_ADV_Geshturtshift_adoption")
end
