

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	

	
	init_psbattleadv("201140000","201140000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)


	pbadv_setup_101009_Noir(2,true,22,26,0)
	
	pbadv_setup_101012_Dinatan(1,true,15,18,0)
	
	pbadv_setup_101032_Gareth(0,true,21,18,0)
	dot_set_weapon(dotGareth,106010001) 

	pbadv_setup_101033_Lyoness(1,true,22,17,0)
	pbadv_setup_101033_Lyoness(0,true,41,41,0)
	
	pbadv_setup_101014_Tristan(0,true,2,24,0)
	
	pbadv_setup_101019_Isolde(1,true,3,24,0)
	
	pbadv_setup_101051_Lucius(0,true,13,17,0)
	
	pbadv_setup_101022_Mordred(0,true,15,19,0)
	
	pbadv_setup_101023_Clarice(1,true,14,20,0)
	
	pbadv_setup_101018_Ragnar(2,true,20,23,0)
	pbadv_setup_101018_Ragnar(0,true,40,41,0)
	
	pbadv_setup_101013_Gawain(1,true,21,22,0)
	
	barbaroi1=dot_reserve_enemy(1102,16,17,0)
	barbaroi2=dot_reserve_enemy(1102,16,18,0)
	barbaroi3=dot_reserve_enemy(1102,16,19,0)
	barbaroi4=dot_reserve_enemy(1102,15,20,0)
	barbaroi5=dot_reserve_enemy(1102,15,21,0)
	

	
	setup_complete_unit()
	
	
	dot_unit_dir(dotRagnar2,2)
	dot_unit_dir(dotGawain1,2)

	
	

	dot_change_weapon(dotGareth,1)
	

	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(45.0,0.0)

	
	
	move_camera(21,22,0.0)
	
	movie_load("MA_01C900_16")

	Ef_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	
	Ef_10=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
	Ef_VanishDust=load_particle("content_effect3d_common_adv","Ef_C_Adv_VanishDust",false,true)
	
	load_image("MA01C9001601", "content_still_10104008_image", "101040080_StillImage")
	load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
	load_image("101040290", "content_still_10104029_image", "101040290_StillImage")

end





function Play()
	fadein(0)
	Play_start(true)




	dot_reserve_move_unit_seq(dotGareth,21,21)
	dot_reserve_move_unit_seq(dotLyoness1,22,20)
	exec_parallel_seq()
	wait_seq()


	dot_attack_seq(dotGawain1,dotGareth)
	dot_damage_seq(dotGareth,dotGawain1,true)
	wait_seq()
	
	on_active(Ef_1)
	local gridpos=get_grid_position(21,21)
	set_pos(Ef_1,gridpos)
	play_particle(Ef_1)
	
	dot_change_anim(dotGareth,6)
	wait_time(0.8)
	
	dot_move_unit_seq(dotLyoness1,21,20)
	wait_seq()

	dot_move_knockback(dotGareth,21,18,0.5,2)
	dot_move_knockback(dotLyoness1,21,17,0.5,2)
	

	
	dot_change_anim(dotLyoness1,1)
	dot_change_anim(dotGareth,1)
	dot_unit_dir(dotGawain1,2)
	dot_change_anim(dotGawain1,0)




	change_face(Noir2,"Anger")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_160002")
	close_speech_window()
	move_camera(21,25,0.3)
	
	
	dot_reserve_move_unit_seq(dotNoir2,22,24)
	dot_reserve_move_unit_seq(dotRagnar2,22,23)
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotNoir2,0)
	dot_unit_dir(dotRagnar2,1)
	
	dot_change_anim(dotNoir2,3)
	dot_change_anim(dotRagnar2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_H_Atk01",3,true)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",2,true)
	dot_play_particle_unit(dotRagnar2,"Ef_C_Swd_W_Atk01",3,true)
	dot_play_particle_unit(dotRagnar2,"Ef_C_Cmn_N_Hit_Sla01",2,true)
	
	wait_time(0.2)



	change_face(Ragnar2,"Anger")	
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar2)
	message("MA_01C900_160003")
	close_speech_window()



	dot_reserve_move_unit_seq(dotNoir2,20,24)
	dot_reserve_move_unit_seq(dotRagnar2,20,23)
	exec_parallel_seq()
	wait_seq()
	
	dot_attack_seq(dotRagnar2,dotNoir2)
	wait_seq()

	dot_change_anim(dotNoir2,3)
	dot_damage_seq(dotNoir2,dotRagnar2,false)	
	wait_seq()

	dot_move_knockback(dotNoir2,20,26,0.5,2)
	dot_change_anim(dotNoir2,6)

	wait_time(1.0)
	dot_change_anim(dotRagnar2,0)
	dot_change_anim(dotNoir2,1)


	change_face(Gawain1,"Pain")	
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C900_160005")
	close_speech_window()



	
	move_camera(21,22,0.3)
	wait_time(1.5)
	dot_change_anim(dotGareth,0)
	dot_unit_dir(dotNoir2,3)
	

	change_face(Gawain1,"Sad")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_160007")
	close_speech_window()

	dot_change_anim(dotNoir2,0)


	change_face(Gareth,"Normal")	
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C900_160008")



	change_face(Gareth,"Sad")	
	message("MA_01C900_160009")



	change_face(Gareth,"Anger")	
	message("MA_01C900_160010")



	change_face(Gareth,"Smile")	
	message("MA_01C900_160011")
	close_speech_window()



	change_face(Gawain1,"Pain")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_160012")
	close_speech_window()


	open_cutin(1,1)
	on_cutin(1,Gareth,"Sad",0)

	change_face(Gareth,"Sad")	
	open_speech_window("CHRNAME_GARETH",nil,nil)
	message("MA_01C900_160013")

	on_cutin(1,Gareth,"Normal",0)

	change_face(Gareth,"Normal")
	message("MA_01C900_160014")

	on_cutin(1,Gareth,"Anger",0)

	change_face(Gareth,"Anger")	
	message("MA_01C900_160015")
	close_speech_window()

	close_cutin()

	show_image("MA01C9001601", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
	set_scale_image(STILL_SCALE,STILL_SCALE)
	wait_time(STILL_SWITCH_TIME)
	wait_time(0.5)

	se_play("SE_Atk_Gun_001")

	scale_to_image(1,1,STILL_MOVE_TIME,2)
	wait_time(STILL_ACTIVE_AFTER)

	dot_change_anim(dotGawain1,1)

	wait_time(1.5)
	
	open_simple_window("CHRNAME_GAWAIN",nil,nil)
	message("MA_01C900_160017")
	close_simple_window()



	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
	

	dot_change_anim(dotGareth,0)
	wait_time(1.5)

	move_camera(21,25, 1.5)

	change_face(Noir2,"Sad")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_160019")
	close_speech_window()



	change_face(Gawain1,"Normal")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_160020")



	message("MA_01C900_160021")
	close_speech_window()




	change_face(Noir2,"Normal")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_160022")
	close_speech_window()




	change_face(Gawain1,"Sad")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_160024")



	message("MA_01C900_160025")
	close_speech_window()

	


	move_camera(20,25,1.5)
	wait_camera()

	open_cutin(1,2)
	on_cutin(1,Ragnar2,"Anger",0)

	change_face(Ragnar2,"Anger")	
	open_speech_window("CHRNAME_RAGNAR2",nil,nil)
	message("MA_01C900_160027")
	close_speech_window()
	
	close_cutin()
		

	dot_play_particle_unit(dotRagnar2,"Ef_C_Cmn_Aura_CS01_W",1,true)
	dot_move_unit_seq(dotRagnar2,20,25)
	wait_seq()


	change_face(Dinatan1,"Surprise")	
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_160029")
	close_speech_window()


	change_face(Ragnar2,"Anger")	
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar2)
	message("MA_01C900_160031")
	close_speech_window()


	dot_change_anim(dotRagnar2,3)

	wait_time(0.1)
	

	
	dot_damage_seq(dotRagnar2,dotTristan,true)
	wait_seq()

	dot_move_knockback(dotRagnar2,20,24,0.5,2)
	
	
	dot_change_anim(dotRagnar2,6)


	change_face(Ragnar2,"Pain")	
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar2)
	message("MA_01C900_160033")
	close_speech_window()

	dot_change_anim(dotRagnar2,1)
	
	dot_change_anim(dotTristan,3)



	move_camera(3,24,0.8)
	wait_time(2.5)

	dot_change_anim(dotTristan,0)

	move_camera(20,25,0.5)
	change_camera_angle(45.0,0.0)


	wait_time(1.0)

	
	
	dot_change_anim(dotRagnar2,1)
	dot_disp_weapon(dotRagnar2,false)



	change_face(Tristan,"Pain")	
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01C900_160035")
	close_speech_window()



	change_face(Ragnar2,"Pain")	
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar2)
	message("MA_01C900_160036")
	close_speech_window()



	move_camera(3,24,0.0)
	change_camera_angle(45.0,0.0)

	dot_change_anim(dotIsolde1,3)
	dot_play_particle_unit(dotIsolde1,"Ef_C_Bow_N_Atk01",1,true)

	wait_time(0.5)

	move_camera(20,24,1.5)
	change_camera_angle(45.0,0.0)
	
	

	dot_move_knockback(dotRagnar2,20,22,0.5,2)

	
	

	dot_damage_seq(dotRagnar2,dotIsolde1,true)
	wait_seq()

	dot_change_anim(dotRagnar2,6)
	wait_time(1.5)


	change_face(Isolde1,"Sad")	
	open_speech_window("CHRNAME_ISOLDE2",Isolde1,nil)
	message("MA_01C900_160038")
	close_speech_window()



	local gridpos=get_grid_position(20,22)
	on_active(Ef_10)
	set_pos(Ef_10,gridpos)
	play_particle(Ef_10)
	wait_time(0.6)
	dot_change_unit(dotRagnar2,dotRagnar,0.0)
	dot_change_anim(dotRagnar,1)
	wait_time(1.5)



	change_face(Gawain1,"Pain")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_160040")
	close_speech_window()

	on_active(Ef_VanishDust)
	
	local gridpos=get_grid_position(20,22)
	set_pos(Ef_VanishDust,gridpos)
	play_particle(Ef_VanishDust)


	change_face(Ragnar,"Sad")	
	open_speech_window("CHRNAME_RAGNAR",nil,Ragnar)
	message("MA_01C900_160041")



	change_face(Ragnar,"Normal")	
	message("MA_01C900_160042")
	



	change_face(Ragnar,"Sad")	
	
	message("MA_01C900_160043")
	close_speech_window()

	close_textbox_base()
	disableTextBox = true

	fadeout(255,255,255,1.0, FADE_TIME)
	wait_time(FADE_TIME)	

	show_image("101010150", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	off_active(Ef_1)
	off_active(Ef_10)

	off_active(Ef_VanishDust)
	dot_remove_unit(dotRagnar)


	movie_set_active(true)
	movie_play()



	movie_wait_playing()
	movie_stop()
	wait_time(MOVIE_AFTER)

	hide_image(STILL_SWITCH_TIME)
	fadein(FADE_TIME+1.6)
	wait_time(FADE_TIME)
	
	move_camera(21,22,1.5)
	change_camera_angle(45.0,0.0)

	disableTextBox = false
	open_textbox_base()

	change_face(Gawain1,"Surprise")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_160045")



	change_face(Gawain1,"Laugh")
	message("MA_01C900_160046")



	change_face(Gawain1,"Sad")	
	message("MA_01C900_160047")
	close_speech_window()

	dot_move_unit_seq(dotGareth,21,21)
	wait_seq()


	dot_change_anim(dotGareth,1)
	wait_time(0.5)


	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
	show_image("101040290", 0.0, 0.0, 0,true,false)

	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)


	open_simple_window("CHRNAME_GARETH",nil,nil)
	message("MA_01C900_160049")
	close_simple_window()

	wait_time(1.5)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,22,26,0)
	pbadv_setup_101012_Dinatan_preload(1,true,15,18,0)
	pbadv_setup_101032_Gareth_preload(0,true,21,18,0)
	pbadv_setup_101033_Lyoness_preload(1,true,22,17,0)
	pbadv_setup_101033_Lyoness_preload(0,true,41,41,0)
	pbadv_setup_101014_Tristan_preload(0,true,2,24,0)
	pbadv_setup_101019_Isolde_preload(1,true,3,24,0)
	pbadv_setup_101051_Lucius_preload(0,true,13,17,0)
	pbadv_setup_101022_Mordred_preload(0,true,15,19,0)
	pbadv_setup_101023_Clarice_preload(1,true,14,20,0)
	pbadv_setup_101018_Ragnar_preload(2,true,20,23,0)
	pbadv_setup_101018_Ragnar_preload(0,true,40,41,0)
	pbadv_setup_101013_Gawain_preload(1,true,21,22,0)
	movie_load_preload("MA_01C900_16")
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VanishDust",false,true)
	load_image_preload("MA01C9001601", "content_still_10104008_image", "101040080_StillImage")
	load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101040290", "content_still_10104029_image", "101040290_StillImage")
end
