Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	
	
	Selste=set_chara_unknown()
	character2DFull(Selste,"Selste",101060001)
	
	
	init_psbattleadv("201180000","201180000")
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)
	
	load_image("101020170","content_still_10102017_image", "101020170_StillImage")
	
	pbadv_setup_101010_Lancelot(1,true,29,9,0)
	
	pbadv_setup_101009_Noir(2,true,30,9,0)
	
	dotArthur_D=dot_reserve_ally(201021001,28,4,0)
	dot_set_weapon(dotArthur_D,101010001)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotArthur_D,2)
	dot_unit_dir(dotNoir2,0)

	
	

	
	
	
	
	
	
	change_camera_distance(10.0,0.0)

	
	
	change_camera_angle(35.0,0.0)

	
	
	move_camera(17,21,0.0)
	
	Ef_VanishDust=load_particle("content_effect3d_common_adv","Ef_C_Adv_VanishDust",false,true)
	Ef_Roar01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	Ef_Shockwave02=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave02",false,true) 
	Ef_K_FP=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_FullPower",false,true) 
	Ef_W_D_Vanish=load_particle("content_effect3d_common_adv","Ef_C_Adv_WhiteDragon_Vanish",false,true) 
	Ef_VibesAura=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true) 
	Ef_Aura_spout=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_spout",false,true) 

	Ef_VanishDust_Disappear=load_particle("content_effect3d_common_adv","Ef_C_Adv_VanishDust_Disappear",false,true) 

	movie_load("MA_01B900_53")
	load_sound("SE_ADV_Movie")
	
	movie_set_active(true)

	show_image("101020170",0.0,0.0,BLACK_WHITE_TIME,true,false)
	wait_time(BLACK_WHITE_TIME+BLACK_WHITE_WAIT_TIME)



	movie_play()



end





function Play()
	fadein(0)
	Play_start(true)

	movie_wait_playing()
	movie_set_active(false)

	wait_time(MOVIE_AFTER)
	
	
	
	
	
	
	

	
	
	

	

	

	

	

	

	
	
	
	
	
	open_simple_window("CHRNAME_LANCELOT2")
	message("MA_01B900_530002")

	
	message("MA_01B900_530003")
	close_speech_window()

	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01B900_530004")

	
	message("MA_01B900_530005")
	close_speech_window()

	
	open_simple_window("CHRNAME_LANCELOT2")
	message("MA_01B900_530006")
	close_speech_window()

	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01B900_530007")
	close_speech_window()

	
	open_simple_window("CHRNAME_LANCELOT2")
	message("MA_01B900_530008")
	
		
	message("MA_01B900_530009")
	close_speech_window()


	wait_time(1.0)
	
	fadeout(255,255,255,1.0, FADE_TIME + 1.0)

	wait_time(TIME_ELAPSED + FADE_TIME)

	

	
	
	

	
	
	wait_time(1.0)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Selste,"Selste",101060001)
	load_image_preload("101020170","content_still_10102017_image", "101020170_StillImage")
	pbadv_setup_101010_Lancelot_preload(1,true,29,9,0)
	pbadv_setup_101009_Noir_preload(2,true,30,9,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VanishDust",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave02",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_FullPower",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_WhiteDragon_Vanish",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_spout",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VanishDust_Disappear",false,true)
	movie_load_preload("MA_01B900_53")
	preload_sound("SE_ADV_Movie")
end
