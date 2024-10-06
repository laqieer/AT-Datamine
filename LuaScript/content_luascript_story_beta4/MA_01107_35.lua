Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system","MovieFunctions")



function Load()
	Load_common(true)

	load_sound("SE_ADV_Movie")

	
	
	

	
	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(1,2)


	
	
	load_image("103010160","content_still_10301016_image","103010160_StillImage")
	load_image("103010170","content_still_10301017_image","103010170_StillImage")
	load_image("103010180_1","content_still_10301018_image","103010180_StillImage")
	load_image("103010180_2","content_still_10301018_image","103010180_StillImage")
	load_image("103010050","content_still_10301005_image","103010050_StillImage")
	load_image("MA011073501","content_still_10101009_image","101010090_StillImage")
	load_image("101010150_1", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010150_2", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010150_3", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010150_4", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010150_5", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")

	change_time_and_weather(BattleTime_Day,BattleWeather_Rainy)


	pbadv_setup_101028_Galahad(2,true,20,22,0)

	pbadv_setup_101029_Astera(1,true,21,22,0)
	
	pbadv_setup_101010_Lancelot(3,true,20,20,0)

	pbadv_setup_101009_Noir(2,true,21,20,0)
	
	pbadv_setup_101001_Tyrfing(1,true,21,21,0)
	
	pbadv_setup_101011_Guinevere(0,true,20,21,0)
	
	pbadv_setup_101012_Dinatan(0,true,22,21,0)
	
	pbadv_setup_101021_Bruno(3,true,13,18,0)
	
	pbadv_setup_101058_Laiens(0,true,20,12,0)
	
	
	
	
	
	
	
	

	
	
	
	
	
	

	dotbaroi21=dot_reserve_enemy(42,21,15,0)
	dotbaroi22=dot_reserve_enemy(42,22,15,0)
	dotbaroi23=dot_reserve_enemy(42,18,15,0)
	dotbaroi24=dot_reserve_enemy(42,19,15,0)
	dotbaroi25=dot_reserve_enemy(42,21,14,0)
	dotbaroi26=dot_reserve_enemy(42,22,14,0)
	dotbaroi27=dot_reserve_enemy(42,18,14,0)
	dotbaroi28=dot_reserve_enemy(42,19,14,0)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	dot_unit_dir(dotDinatan,3)
	dot_unit_dir(dotGuinevere,2)
	dot_unit_dir(dotLancelot3,2)
	dot_unit_dir(dotGalahad2,2)
	
	
	dot_unit_dir(dotbaroi21,3)
	dot_unit_dir(dotbaroi22,3)
	dot_unit_dir(dotbaroi23,3)
	dot_unit_dir(dotbaroi24,3)
	dot_unit_dir(dotbaroi25,3)
	dot_unit_dir(dotbaroi26,3)
	dot_unit_dir(dotbaroi27,3)
	dot_unit_dir(dotbaroi28,3)
	

	
	
	dot_disp_weapon(dotLaiens,false)

	
	
	dot_disp_unit(dotBruno3,false)
	dot_disp_unit(dotLaiens,false)
	dot_disp_unit(dotbaroi21,false)
	dot_disp_unit(dotbaroi22,false)
	dot_disp_unit(dotbaroi23,false)
	dot_disp_unit(dotbaroi24,false)
	dot_disp_unit(dotbaroi25,false)
	dot_disp_unit(dotbaroi26,false)
	dot_disp_unit(dotbaroi27,false)
	dot_disp_unit(dotbaroi28,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(28.0,0.0)

	
	
	move_camera(21,21,0.0)
	
	Ef_Portal_E0=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E9=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)

	Ef_VibesAura1=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_VibesAura2=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_VibesAura3=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_KillersDie=load_particle("content_effect3d_common_adv","Ef_C_Adv_VanishDust_Disappear",false,true) 

	Ef_Aura_Lop1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Lop",false,true)
	
	Ef_Emblem01_0=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	Ef_Emblem01_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	Ef_Emblem01_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	
	Ef_Aura_spout3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_spout",false,true)
	
	Ef_Emblem03=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem03",false,true)
	

	
	

	Ef_Aura_Enemy_spout=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_spout",false,true)

	Ef_Roar01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)

	Ef_SwordWind=load_particle("content_effect3d_common_adv","Ef_C_Adv_SwordWind",false,true)

	load_sound("BGM_ADV_Elation")

end





function Play()
	fadein(0)
	Play_start(true)




	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_350002")
	close_speech_window()



	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_350003")
	close_speech_window()



	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350004")
	close_speech_window()


	se_play("SE_ADV_MA_01107_35_Aura_BossEmy")
	wait_time(1.5)



	change_face(Tyrfing1,"Pain")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_350006")
	close_speech_window()



	change_face(Dinatan,"Pain")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_350007")
	close_speech_window()



	change_face(Guinevere, "Surprise")	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01107_350008")
	close_speech_window()
	dot_unit_dir(dotTyrfing1,3)
	dot_unit_dir(dotDinatan,2)



	move_camera(20,12,0.0)
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotAstera1,2)
	dot_unit_dir(dotGalahad2,2)
	dot_unit_dir(dotTyrfing1,2)
	dot_unit_dir(dotGuinevere,2)
	move_camera(20,19,5.0)

	on_active(Ef_Portal_E0)
	on_active(Ef_Portal_E1)
	on_active(Ef_Portal_E2)
	on_active(Ef_Portal_E3)
	on_active(Ef_Portal_E4)
	on_active(Ef_Portal_E5)
	on_active(Ef_Portal_E6)
	on_active(Ef_Portal_E7)
	on_active(Ef_Portal_E8)
	
	local gridpos=get_grid_position(20,12)
	set_pos(Ef_Portal_E0,gridpos)
	set_scale(Ef_Portal_E0,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E0)

	local gridpos=get_grid_position(18,14)
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)
	
	local gridpos=get_grid_position(19,14)
	set_pos(Ef_Portal_E2,gridpos)
	set_scale(Ef_Portal_E2,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E2)
	
	local gridpos=get_grid_position(21,14)
	set_pos(Ef_Portal_E3,gridpos)
	set_scale(Ef_Portal_E3,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E3)
	
	local gridpos=get_grid_position(22,14)
	set_pos(Ef_Portal_E4,gridpos)
	set_scale(Ef_Portal_E4,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E4)
	
	local gridpos=get_grid_position(18,15)
	set_pos(Ef_Portal_E5,gridpos)
	set_scale(Ef_Portal_E5,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E5)
	
	local gridpos=get_grid_position(19,15)
	set_pos(Ef_Portal_E6,gridpos)
	set_scale(Ef_Portal_E6,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E6)
	
	local gridpos=get_grid_position(21,15)
	set_pos(Ef_Portal_E7,gridpos)
	set_scale(Ef_Portal_E7,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E7)
	
	local gridpos=get_grid_position(22,15)
	set_pos(Ef_Portal_E8,gridpos)
	set_scale(Ef_Portal_E8,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E8)

	on_active(Ef_Aura_Enemy_spout)
	local gridpos=get_grid_position(20,12)
	set_pos(Ef_Aura_Enemy_spout,gridpos)
	play_particle(Ef_Aura_Enemy_spout)
		
	wait_time(0.2)

	dot_disp_unit(dotLaiens,true)
	dot_disp_unit(dotbaroi21,true)
	dot_disp_unit(dotbaroi22,true)
	dot_disp_unit(dotbaroi23,true)
	dot_disp_unit(dotbaroi24,true)
	dot_disp_unit(dotbaroi25,true)
	dot_disp_unit(dotbaroi26,true)
	dot_disp_unit(dotbaroi27,true)
	dot_disp_unit(dotbaroi28,true)
	
	Ef_10=dot_play_particle_unit(dotLaiens,"Ef_C_Cmn_Smoke01",0,true)
	Ef_11=dot_play_particle_unit(dotLaiens,"Ef_C_Cmn_Smoke02",1,true)
	
	wait_time(1.0)
	
	dot_move_unit_seq(dotLaiens,20,17)
	wait_seq()

	local gridpos=get_grid_position(20,17)
	set_pos(Ef_Aura_Enemy_spout,gridpos)
	play_particle(Ef_Aura_Enemy_spout)





	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01107_350010")
	close_speech_window()




	change_face(Lancelot3,"Serious")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350012")
	close_speech_window()


		


	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350013")
	close_speech_window()



	
	dot_move_unit_seq(dotLancelot3,20,18)
	wait_seq()
	
	dot_unit_dir(dotLancelot3,0)
	dot_attack_seq(dotLancelot3,dotLaiens)
	wait_seq()

	dot_unit_dir(dotLaiens,1)
	dot_change_anim(dotLaiens,5)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Cmn_Guard01",1,false)

	
	wait_time(0.5)



	dot_stop_particle(Ef_10)
	dot_stop_particle(Ef_11)

	stop_particle(Ef_Aura_Enemy_spout)
	


	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350015")
	close_speech_window()



	
	dot_change_anim(dotLaiens,3)
	dot_play_particle_unit(dotLaiens,"Ef_C_Swd_N_Atk01",3,true)
	
	Ef_13=dot_play_particle_unit(dotLancelot3,"Ef_C_Cmn_Kira01_R",3,true)
	
	dot_change_anim(dotLancelot3,6)
	wait_time(0.1)
	dot_move_knockback(dotLancelot3,20,19,0.1,2)
	wait_seq()
	wait_time(0.3)
	dot_change_anim(dotLancelot3,0)
	dot_unit_dir(dotLancelot3,2)
	
	dot_unit_dir(dotLancelot3,2)
	wait_time(0.3)
	dot_change_anim(dotLaiens,0)


	change_face(Laiens,"Normal")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350017")
	close_speech_window()



	dot_change_anim(dotLaiens,5)
	dot_change_anim(dotbaroi21,5)
	dot_change_anim(dotbaroi22,5)
	dot_change_anim(dotbaroi23,5)
	dot_change_anim(dotbaroi24,5)
	dot_change_anim(dotbaroi25,5)
	dot_change_anim(dotbaroi26,5)
	dot_change_anim(dotbaroi27,5)
	dot_change_anim(dotbaroi28,5)

	on_active(Ef_Roar01)
	local gridpos=get_grid_position(20,17)
	set_pos(Ef_Roar01,gridpos)
	play_particle(Ef_Roar01)
	
	wait_time(1.0)

	dot_change_anim(dotLaiens,0)
	dot_change_anim(dotbaroi21,0)
	dot_change_anim(dotbaroi22,0)
	dot_change_anim(dotbaroi23,0)
	dot_change_anim(dotbaroi24,0)
	dot_change_anim(dotbaroi25,0)
	dot_change_anim(dotbaroi26,0)
	dot_change_anim(dotbaroi27,0)
	dot_change_anim(dotbaroi28,0)

	dot_unit_dir(dotNoir2,2)


	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350019")
	close_speech_window()

	dot_unit_dir(dotLancelot3,3)


	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350020")



	message("MA_01107_350021")
	close_speech_window()



	change_face(Laiens,"Normal")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350022")
	close_speech_window()



	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350023")
	close_speech_window()



	change_face(Laiens,"Normal")	
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350025")


	change_face(Laiens,"Smile")
	message("MA_01107_350026")
	close_speech_window()



	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350027")
	close_speech_window()



	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350028")
	close_speech_window()



	change_face(Dinatan,"Surprise")	
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_350029")
	close_speech_window()



	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350030")



	change_face(Laiens,"Normal")	
	message("MA_01107_350031")
	close_speech_window()



	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_350032")
	close_speech_window()



	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350033")
	close_speech_window()



	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350034")
	close_speech_window()

	dot_unit_dir(dotTyrfing1,2)


	change_face(Tyrfing1,"Normal")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_350035")
	close_speech_window()





	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350037")
	close_speech_window()



	change_face(Noir2,"Normal")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350038")
	close_speech_window()



	change_face(Laiens,"Normal")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350039")
	close_speech_window()



	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350040")
	close_speech_window()



	change_face(Laiens,"Normal")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350041")



	change_face(Laiens,"Smile")
	message("MA_01107_350042")
	close_speech_window()


	open_cutin(1,1)
	on_cutin(1,Noir2,"Serious",0)
	

	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",nil,nil)
	message("MA_01107_350043")
	close_speech_window()

	close_cutin()	



	open_cutin(1,1)
	on_cutin(1,Tyrfing1,"Anger",0)

	change_face(Tyrfing1,"Anger")
	open_speech_window("CHRNAME_TYRFING",nil,nil)
	message("MA_01107_350045")
	close_speech_window()

	close_cutin()	
	move_camera(21,20,0.1)

	on_active(Ef_KillersDie)
	on_active(Ef_Aura_Lop1)
	
	local gridpos=get_grid_position(21,20)
	set_pos(Ef_KillersDie,gridpos)
	play_particle(Ef_KillersDie)
	
	local gridpos=get_grid_position(21,20)
	set_pos(Ef_Aura_Lop1,gridpos)
	play_particle(Ef_Aura_Lop1)
	
	wait_time(1.0)
	
	on_active(Ef_Emblem01_0)
	on_active(Ef_Emblem01_1)
	on_active(Ef_Emblem01_2)
	on_active(Ef_VibesAura1)
	on_active(Ef_VibesAura2)
	on_active(Ef_VibesAura3)
	
	
	local gridpos=get_grid_position(20,19)
	set_pos(Ef_VibesAura1,gridpos)
	play_particle(Ef_VibesAura1)
	
	local gridpos=get_grid_position(20,21)
	set_pos(Ef_VibesAura2,gridpos)
	play_particle(Ef_VibesAura2)
	
	local gridpos=get_grid_position(22,21)
	set_pos(Ef_VibesAura3,gridpos)
	play_particle(Ef_VibesAura3)
	
	local locatorpos = dot_get_unit_locator(dotLancelot3,1)
	set_pos(Ef_Emblem01_0,locatorpos)
	
	local locatorpos = dot_get_unit_locator(dotGuinevere,1)
	set_pos(Ef_Emblem01_1,locatorpos)
	
	local locatorpos = dot_get_unit_locator(dotDinatan,1)
	set_pos(Ef_Emblem01_2,locatorpos)


	change_face(Lancelot3,"Surprise")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350047")
	close_speech_window()



	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_350048")
	close_speech_window()



	change_face(Dinatan,"Surprise")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_350049")
	close_speech_window()




	change_face(Tyrfing1,"Anger")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_350050")
	





	change_face(Tyrfing1,"Anger")
	message("MA_01107_350052")
	close_speech_window()



	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350053")
	close_speech_window()



	change_face(Lancelot3,"Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350054")
	close_speech_window()



	change_face(Noir2,"Surprise")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350055")
	close_speech_window()
	
	on_active(Ef_KillersDie)
	on_active(Ef_Aura_Lop1)
	stop_particle(Ef_Aura_Lop1)
	stop_particle(Ef_Emblem01_0)
	stop_particle(Ef_Emblem01_1)
	stop_particle(Ef_Emblem01_2)
	stop_particle(Ef_VibesAura1)
	stop_particle(Ef_VibesAura2)
	stop_particle(Ef_VibesAura3)




	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
	
	on_cameraframe(2)
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("103010160", 0.0, 0.0, 0.0)
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)
	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01107_350057")
	close_speech_window()




	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01107_350059")
	close_speech_window()




	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01107_350061")
	close_speech_window()

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	off_cameraframe()
	off_screencolor()
	show_image("101010150_1", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	fadein(BLACK_WHITE_TIME)
	wait_time(BLACK_WHITE_TIME)


	change_face(Lancelot3,"Sad")
	open_mind_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350062")
	close_mind_window()
	
	


	fadeout(255,255,255,0.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)

	on_cameraframe(2)
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("103010170", 0.0, 0.0, 0.0)

	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01107_350064")
	close_speech_window()

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	off_cameraframe()
	off_screencolor()
	show_image("101010150_2", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	fadein(BLACK_WHITE_TIME)
	wait_time(BLACK_WHITE_TIME)
	
	
	change_face(Lancelot3,"Sad")
	open_mind_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350065")
	close_mind_window()

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	move_camera(20,19,0.0)
	
	hide_image()
	off_cameraframe()
	off_screencolor()
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)



	dot_unit_dir(dotLancelot3,3)

	bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350067")
	close_speech_window()



	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350068")



	change_face(Lancelot3,"Sad")
	message("MA_01107_350069")
	close_speech_window()



	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350070")
	close_speech_window()



	change_face(Lancelot3,"Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350071")
	close_speech_window()





	fadeout(255,255,255,0.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)

	on_cameraframe(2)
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("103010180_1", 0.0, 0.0, 0.0)

	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)
	bgm_play("Set_BGM_Bus_LPF_Volume_2")

	
	open_simple_window("CHRNAME_LANCELOT")
	message("MA_01107_350073")
	close_speech_window()

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	off_cameraframe()
	off_screencolor()
	show_image("101010150_3", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	fadein(BLACK_WHITE_TIME)
	wait_time(BLACK_WHITE_TIME)


	change_face(Lancelot3,"Sad")
	open_mind_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350074")
	close_mind_window()

	fadeout(255,255,255,0.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)

	on_cameraframe(2)
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("103010180_2", 0.0, 0.0, 0.0)

	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)



	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01107_350076")
	close_speech_window()

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	off_cameraframe()
	off_screencolor()
	show_image("101010150_4", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	fadein(BLACK_WHITE_TIME)
	wait_time(BLACK_WHITE_TIME)

	
	change_face(Lancelot3,"Sad")
	open_mind_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350077")
	close_mind_window()
	

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
	
	hide_image()
	off_cameraframe()
	off_screencolor()
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)



	bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	change_face(Lancelot3,"Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350079")
	close_speech_window()



	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350080")



	message("MA_01107_350081")






	
	MA_01107_35_select1()

	open_select_window_tag(Noir2,"Normal","MA_01107_350082","MA_01107_350083")
	
	close_speech_window()

	if is_select(1) then			
		MA_01107_35_select1_1()

	else		
		MA_01107_35_select1_2()

	end
	MA_01107_35_end()

	end

	function MA_01107_35_select1()

	end

	function MA_01107_35_select1_1()



	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350085")
	close_speech_window()



	change_face(Laiens,"Surprise")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350086")



	change_face(Laiens,"Smile")
	message("MA_01107_350087")





	change_face(Laiens,"Normal")
	message("MA_01107_350093")



	change_face(Laiens,"Smile")
	message("MA_01107_350094")
	close_speech_window()

end
 
 
function MA_01107_35_select1_2()




	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350089")
	close_speech_window()



	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350090")
	close_speech_window()



	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350091")
	close_speech_window()





	change_face(Laiens,"Normal")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_350093")



	change_face(Laiens,"Smile")
	message("MA_01107_350094")
	close_speech_window()
	
	end


	function MA_01107_35_end()





	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350096")



	change_face(Lancelot3,"Sad")
	message("MA_01107_350097")



	change_face(Lancelot3,"Pain")
	message("MA_01107_350098")
	close_speech_window()



	bgm_play("Stop_BGM_Bus_LongFade")
	change_face(Tyrfing1,"Sad")	
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_350099")
	close_speech_window()



	
	local gridpos=get_grid_position(20,19)
	set_pos(Ef_KillersDie,gridpos)
	play_particle(Ef_KillersDie)
	
	local gridpos=get_grid_position(20,19)
	set_pos(Ef_Aura_Lop1,gridpos)
	play_particle(Ef_Aura_Lop1)

	bgm_play("BGM_ADV_Elation")

	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350101")
	close_speech_window()



	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350102")
	close_speech_window()



	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350103")
	close_speech_window()




	change_face(Bruno3,"Normal")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01107_350105")
	close_speech_window()




	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350107")
	close_speech_window()


	




	
		show_image("MA011073501", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
		set_position_image(STILL_POS_RIGHT, STILL_POS_LENGTH)
		set_scale_image(STILL_SCALE,STILL_SCALE)

		wait_time(STILL_SWITCH_TIME)
		scale_to_image(1,1,STILL_MOVE_TIME2,2)
		move_to_image(0,0,STILL_MOVE_TIME2,2)
		wait_time(STILL_ACTIVE_AFTER)

	off_active(Ef_Emblem01_0)
	off_active(Ef_Emblem01_1)
	off_active(Ef_Emblem01_2)
	off_active(Ef_Aura_spout3)
	off_active(Ef_VibesAura1)
	off_active(Ef_VibesAura2)
	off_active(Ef_VibesAura3)
	off_active(Ef_Aura_Lop1)
	off_active(Ef_Aura_Lop1)
	off_active(Ef_Aura_Lop1)
	off_active(Ef_Aura_Lop1)


	open_simple_window("CHRNAME_LANCELOT_BRUNO",nil,nil)
	message("MA_01107_350108")
	close_speech_window()

	dot_unit_dir(dotLaiens,2)
	dot_disp_unit(dotBruno3,true)
	dot_move_unit_seq(dotBruno3,19,17)
	wait_seq()
	
	


	movie_load("MA_01107_35")
	movie_set_active(true)
	bgm_play("BGM_ADV_Elation")
	movie_play()

	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)

	movie_wait_playing()
	movie_stop()
	dot_move_unit_seq(dotLancelot3,20,20)
	wait_time(MOVIE_AFTER)
	

	OpenFirstAppearance(Bruno3)

bgm_play("Set_BGM_Bus_LPF_Volume_2")


	on_cameraframe(2)
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("103010050", 0.0, 0.0, 0.0)
	
	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01107_350117")
	close_speech_window()

	stop_particle(Ef_Aura_spout3)
	stop_particle(Ef_Aura_Lop1)



	
	open_simple_window("CHRNAME_LANCELOT")
	message("MA_01107_350119")
	close_speech_window()

	bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	hide_image()
	
	off_cameraframe()
	off_screencolor()
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)



	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350121")
	close_speech_window()



	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350122")
	close_speech_window()



	open_narration_window()
	message("MA_01107_350123")
	close_narration_window()



	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350124")
	close_speech_window()



	open_narration_window()
	message("MA_01107_350125")
	close_narration_window()




	change_face(Lancelot3,"Smile")	
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_350127")
	close_speech_window()


	

	wait_time(0.2)


	
	wait_time(1.0)



	change_face(Noir2,"Smile")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_350129")
	close_speech_window()



	dot_change_anim(dotLancelot3,5)
	dot_change_anim(dotNoir2,5)
	wait_time(1.2)



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	preload_sound("SE_ADV_Movie")
	load_image_preload("103010160","content_still_10301016_image","103010160_StillImage")
	load_image_preload("103010170","content_still_10301017_image","103010170_StillImage")
	load_image_preload("103010180_1","content_still_10301018_image","103010180_StillImage")
	load_image_preload("103010180_2","content_still_10301018_image","103010180_StillImage")
	load_image_preload("103010050","content_still_10301005_image","103010050_StillImage")
	load_image_preload("MA011073501","content_still_10101009_image","101010090_StillImage")
	load_image_preload("101010150_1", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010150_2", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010150_3", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010150_4", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010150_5", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	pbadv_setup_101028_Galahad_preload(2,true,20,22,0)
	pbadv_setup_101029_Astera_preload(1,true,21,22,0)
	pbadv_setup_101010_Lancelot_preload(3,true,20,20,0)
	pbadv_setup_101009_Noir_preload(2,true,21,20,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,21,21,0)
	pbadv_setup_101011_Guinevere_preload(0,true,20,21,0)
	pbadv_setup_101012_Dinatan_preload(0,true,22,21,0)
	pbadv_setup_101021_Bruno_preload(3,true,13,18,0)
	pbadv_setup_101058_Laiens_preload(0,true,20,12,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VanishDust_Disappear",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_spout",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem03",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_spout",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_SwordWind",false,true)
	preload_sound("BGM_ADV_Elation")
end
