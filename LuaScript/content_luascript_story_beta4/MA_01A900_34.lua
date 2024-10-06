Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201080000", "201080000")
	change_time_and_weather(BattleTime_Eclipse ,BattleWeather_Eclipse )


	pbadv_setup_101014_Tristan(0,true,14,9,0)
	pbadv_setup_101019_Isolde(1,true,15,9,0)

	pbadv_setup_101013_Gawain(0,true,7,7,0)
	pbadv_setup_101018_Ragnar(1,true,5,5,0)
	
	
	
	
	barbaroi1=dot_reserve_enemy(1,12,11,0)
	barbaroi2=dot_reserve_enemy(1,13,11,0)
	barbaroi3=dot_reserve_enemy(1,14,11,0)
	barbaroi4=dot_reserve_enemy(1,15,11,0)
	barbaroi5=dot_reserve_enemy(1,16,11,0)
	barbaroi6=dot_reserve_enemy(1,17,11,0)
	barbaroi7=dot_reserve_enemy(1,13,12,0)
	barbaroi8=dot_reserve_enemy(1,14,12,0)
	barbaroi9=dot_reserve_enemy(1,15,12,0)
	barbaroi10=dot_reserve_enemy(1,16,12,0)
	
	
	
	
	barbaroi15=dot_reserve_enemy(1,4,6,0)
	barbaroi16=dot_reserve_enemy(1,5,6,0)
	barbaroi17=dot_reserve_enemy(1,6,6,0)
	
	
	barbaroi20=dot_reserve_enemy(1,4,7,0)
	barbaroi21=dot_reserve_enemy(1,5,7,0)
	barbaroi22=dot_reserve_enemy(1,6,7,0)
	
	
	
	barbaroi26=dot_reserve_enemy(1,5,8,0)
	barbaroi27=dot_reserve_enemy(1,6,8,0)
	





	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotGawain,2)
	dot_unit_dir(dotTristan,2)

	dot_unit_dir(barbaroi1,3)
	dot_unit_dir(barbaroi2,3)
	dot_unit_dir(barbaroi3,3)
	dot_unit_dir(barbaroi4,3)
	dot_unit_dir(barbaroi5,3)
	dot_unit_dir(barbaroi6,3)
	dot_unit_dir(barbaroi7,3)
	dot_unit_dir(barbaroi8,3)
	dot_unit_dir(barbaroi9,3)
	dot_unit_dir(barbaroi10,3)
	
	
	dot_unit_dir(barbaroi15,3)
	dot_unit_dir(barbaroi16,3)
	
	
	
	dot_unit_dir(barbaroi20,3)
	dot_unit_dir(barbaroi21,3)
	dot_unit_dir(barbaroi22,3)
	
	
	
	dot_unit_dir(barbaroi26,3)
	dot_unit_dir(barbaroi27,3)
	
	
	
	
	

	
	

	
	

	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(34,6,0.0)
	
	Ef_Shockwave01_0=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_9=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_10=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_11=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_12=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_13=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_14=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_15=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_16=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_17=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_18=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_19=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
end





function Play()
	fadein(0)
	Play_start(true)


	move_camera(15,9,1.0)
	wait_camera()
	
	
	wait_time(0.1)
	dot_attack_seq(dotTristan,barbaroi1)
	dot_damage_seq(barbaroi1,dotTristan,true)
	wait_seq()
	
	dot_remove_unit(barbaroi1)
	
	wait_time(0.1)
	dot_attack_seq(dotTristan,barbaroi2)
	dot_damage_seq(barbaroi2,dotTristan,true)
	wait_seq()
	
	dot_remove_unit(barbaroi2)
	
	wait_time(0.1)
	dot_attack_seq(dotTristan,barbaroi3)
	dot_damage_seq(barbaroi3,dotTristan,true)
	wait_seq()
	
	dot_remove_unit(barbaroi3)
	
	
	dot_change_anim(dotTristan,0)
	
	
	change_face(Tristan,"Smile")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01A900_340002")
	close_speech_window()

	
	change_face(Isolde1,"Normal")	
	open_speech_window("CHRNAME_ISOLDE2",Isolde1,nil)
	message("MA_01A900_340003")
	close_speech_window()
	
	dot_attack_seq(dotIsolde1,barbaroi4)
	dot_damage_seq(barbaroi4,dotIsolde1,true)
	wait_seq()

	dot_remove_unit(barbaroi4)

	wait_time(0.1)

	dot_attack_seq(dotIsolde1,barbaroi5)
	dot_damage_seq(barbaroi5,dotIsolde1,true)

	wait_seq()

	dot_remove_unit(barbaroi5)

	wait_time(0.1)
	dot_attack_seq(dotIsolde1,barbaroi6)
	dot_damage_seq(barbaroi6,dotIsolde1,true)
	wait_seq()

	dot_remove_unit(barbaroi6)

	wait_time(0.1)

	dot_change_anim(dotIsolde1,0)
	
	wait_time(1.0)
	
	
	change_face(Tristan,"Sad")	
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01A900_340004")
	close_speech_window()

	
	move_camera(6,7,0.2)
	wait_camera()
	
	dot_attack_seq(dotGawain,barbaroi22)
	dot_change_anim(dotRagnar1,3)
	wait_seq()
	
	wait_time(0.1)

	on_active(Ef_Shockwave01_0)
	on_active(Ef_Shockwave01_1)
	on_active(Ef_Shockwave01_2)
	on_active(Ef_Shockwave01_3)
	on_active(Ef_Shockwave01_4)
	on_active(Ef_Shockwave01_5)
	on_active(Ef_Shockwave01_6)
	on_active(Ef_Shockwave01_7)
	on_active(Ef_Shockwave01_8)
	on_active(Ef_Shockwave01_9)
	on_active(Ef_Shockwave01_10)
	on_active(Ef_Shockwave01_11)
	on_active(Ef_Shockwave01_12)
	on_active(Ef_Shockwave01_13)
	on_active(Ef_Shockwave01_14)
	on_active(Ef_Shockwave01_15)
	on_active(Ef_Shockwave01_16)
	on_active(Ef_Shockwave01_17)
	on_active(Ef_Shockwave01_18)
	on_active(Ef_Shockwave01_19)
	
	









	local gridpos=get_grid_position(4,6)
	set_pos(Ef_Shockwave01_10,gridpos)
	play_particle(Ef_Shockwave01_0)
	dot_change_anim(barbaroi15,6)
	
	local gridpos=get_grid_position(5,6)
	set_pos(Ef_Shockwave01_1,gridpos)
	play_particle(Ef_Shockwave01_1)
	dot_change_anim(barbaroi16,6)
	
	local gridpos=get_grid_position(6,6)
	set_pos(Ef_Shockwave01_2,gridpos)
	play_particle(Ef_Shockwave01_2)
	dot_change_anim(barbaroi17,6)
	
	









	local gridpos=get_grid_position(4,7)
	set_pos(Ef_Shockwave01_5,gridpos)
	play_particle(Ef_Shockwave01_5)
	dot_change_anim(barbaroi20,6)
	
	local gridpos=get_grid_position(5,7)
	set_pos(Ef_Shockwave01_6,gridpos)
	play_particle(Ef_Shockwave01_6)
	dot_change_anim(barbaroi21,6)
	
	local gridpos=get_grid_position(6,7)
	set_pos(Ef_Shockwave01_7,gridpos)
	play_particle(Ef_Shockwave01_7)
	dot_change_anim(barbaroi22,6)
	
	














	local gridpos=get_grid_position(5,8)
	set_pos(Ef_Shockwave01_11,gridpos)
	play_particle(Ef_Shockwave01_11)
	dot_change_anim(barbaroi26,6)
	
	se_play("SE_ADV_MA_01A900_33_Axe_Impact")
	dot_play_particle_unit(barbaroi27,"Ef_C_Cmn_N_Hit_Str01",3,true)
	
	local gridpos=get_grid_position(6,8)
	set_pos(Ef_Shockwave01_12,gridpos)
	play_particle(Ef_Shockwave01_12)
	dot_change_anim(barbaroi27,6)
	

























	
	
	dot_remove_unit(barbaroi15)
	dot_remove_unit(barbaroi16)
	dot_remove_unit(barbaroi17)
	
	
	dot_remove_unit(barbaroi20)
	dot_remove_unit(barbaroi21)
	dot_remove_unit(barbaroi22)
	


	dot_remove_unit(barbaroi26)
	dot_remove_unit(barbaroi27)
	





	wait_time(0.6)
	dot_change_anim(dotRagnar1,0)
	dot_change_anim(dotGawain,0)
	
	
	
	change_face(Ragnar1,"Normal")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1,nil)
	message("MA_01A900_340006")
	close_speech_window()

	
	change_face(Gawain,"Smile")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01A900_340008")
	close_speech_window()

	
	change_face(Ragnar1,"Smile")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1,nil)
	message("MA_01A900_340009")
	close_speech_window()
	dot_unit_dir(dotGawain,3)
	wait_time(0.5)

	
	change_face(Gawain,"Normal")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01A900_340010")
	close_speech_window()

	wait_time(0.2)


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101014_Tristan_preload(0,true,14,9,0)
	pbadv_setup_101019_Isolde_preload(1,true,15,9,0)
	pbadv_setup_101013_Gawain_preload(0,true,7,7,0)
	pbadv_setup_101018_Ragnar_preload(1,true,5,5,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
end
