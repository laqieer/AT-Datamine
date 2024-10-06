

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	

	
	init_psbattleadv("201060001", "201060001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)
	
	
	pbadv_setup_101009_Noir(2,true,22,22,0)

	
	pbadv_setup_101010_Lancelot(3,true,21,21,0)
	
	
	
	barbaroi1 = dot_reserve_enemy(1, 29, 22, 0)
	barbaroi2 = dot_reserve_enemy(1, 29, 21, 0)
	barbaroi3 = dot_reserve_enemy(1, 28, 22, 0)
	barbaroi4 = dot_reserve_enemy(1, 28, 21, 0)
	barbaroi5 = dot_reserve_enemy(1, 27, 22, 0)
	barbaroi6 = dot_reserve_enemy(1, 27, 21, 0)
	barbaroi7 = dot_reserve_enemy(1, 27, 20, 0)
	barbaroi8 = dot_reserve_enemy(1, 28, 20, 0)
	barbaroi9 = dot_reserve_enemy(1, 29, 20, 0)

	pbadv_setup_101047_Tyronoe(true, 23, 22,0) 

	
	
	setup_complete_unit()

	dot_change_anim(barbaroi1, 1)
	dot_change_anim(barbaroi2, 1)
	dot_change_anim(barbaroi3, 1)
	dot_change_anim(barbaroi4, 1)
	dot_change_anim(barbaroi5, 1)
	dot_change_anim(barbaroi6, 1)
	dot_change_anim(barbaroi7, 1)
	dot_change_anim(barbaroi8, 1)
	dot_change_anim(barbaroi9, 1)

	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(23, 22, 0.0)
	
	
	Ef_Vanish = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	Ef_WitchDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)

	load_sound("BGM_ADV_Recollection")
end




function Play()
	fadein(0)
	Play_start(true)




	wait_time(0.5)

	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi8,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi9,"Ef_C_Cmn_DieEmy01",2,true)
	
	wait_time(0.5)

	dot_remove_unit(barbaroi1) 
	dot_remove_unit(barbaroi2) 
	dot_remove_unit(barbaroi3) 
	dot_remove_unit(barbaroi4) 
	dot_remove_unit(barbaroi5) 
	dot_remove_unit(barbaroi6) 
	dot_remove_unit(barbaroi7) 
	dot_remove_unit(barbaroi8) 
	dot_remove_unit(barbaroi9) 

	dot_attack_seq(dotNoir2, dotTyronoe)			
	dot_damage_seq(dotTyronoe, dotNoir2, false)	
	wait_seq()									

	dot_change_anim(dotNoir2, DotAnim_Idle)		
	
	
	
	se_play("SE_ADV_MA_01B111_08_Water_Drop")

	dot_move_knockback(dotTyronoe, 24, 23,0.1,2)
	
	wait_time(0.1)
	dot_change_anim(dotTyronoe, 1)	

	se_play("SE_ADV_MA_01B111_08_Water_Drop")

	wait_time(1.5)

	change_face(Tyronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_6", nil, Tyronoe)
	 --PlayPartVoice("ティーロノエー", "悲しみ")
	message("MA_01B111_080002")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_080004")
	close_speech_window()
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	 --PlayPartVoice("ランスロット", "肯定3")
	message("MA_01B111_080005")
	close_speech_window()
	

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "肯定2")
	message("MA_01B111_080006")
	close_speech_window()
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	 --PlayPartVoice("ランスロット", "肯定")
	message("MA_01B111_080007")
	close_speech_window()

	

	local gridpos = get_grid_position(24, 23)
	set_pos(Ef_Fog, gridpos)
	on_active(Ef_Fog) 

	play_particle(Ef_Fog)


	
	change_face(Tyronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_6", nil, Tyronoe)
	 --PlayPartVoice("ティーロノエー", "怒り")
	message("MA_01B111_080009")
	close_speech_window()
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B111_080010")
	
	

	change_face(Lancelot3, "Normal")
	message("MA_01B111_080011")
	
	
	change_face(Lancelot3, "Normal")
	message("MA_01B111_080013")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_080014")
	close_speech_window()
	
	bgm_play("Stop_BGM_Bus_LongFade")
	

	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	 --PlayPartVoice("ランスロット", "笑い")
	message("MA_01B111_080015")
	close_speech_window()
	



	dot_move_height(dotTyronoe,-0.2,1,2)
	dot_change_anim(dotTyronoe, 1)
	wait_time(0.2)

	

	change_face(Tyronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_6", nil, Tyronoe)
	message("MA_01B111_080017")

	

	
	 --PlayPartVoice("ティーロノエー", "笑い")
	message("MA_01B111_080019")
	close_speech_window()

	
	stop_particle(Ef_Fog)

	

	on_active(Ef_WitchDie) 

	local gridpos = get_grid_position(24, 23)
	set_pos(Ef_WitchDie, gridpos)
	play_particle(Ef_WitchDie)

	wait_time(1.0)

	dot_remove_unit(dotTyronoe)

	wait_time(2.0)

	
	move_camera(20, 19, 2.0)
	

	dot_reserve_move_unit_seq(dotLancelot3, 20, 19)
	dot_reserve_move_unit_seq(dotNoir2, 21, 19)
	
	
	exec_parallel_seq()

	
	wait_seq()
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotLancelot3, 3)
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotLancelot3,false)

	wait_camera()


	bgm_play("BGM_ADV_Recollection")
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_080021")
	close_speech_window()
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	 --PlayPartVoice("ランスロット", "肯定")
	message("MA_01B111_080022")
	
	
	change_face(Lancelot3, "Normal")
	message("MA_01B111_080023")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_080024")
	close_speech_window()
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B111_080025")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_080026")
	close_speech_window()
	

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	 --PlayPartVoice("ランスロット", "照れ")
	message("MA_01B111_080028")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール", "笑い")
	message("MA_01B111_080029")
	close_speech_window()
	
	

	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B111_080030")
	
	
	change_face(Lancelot3, "Normal")
	message("MA_01B111_080032")
	
	
	change_face(Lancelot3, "Normal")
	message("MA_01B111_080033")
	
	
	change_face(Lancelot3, "Normal")
	message("MA_01B111_080034")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,22,22,0)
	pbadv_setup_101010_Lancelot_preload(3,true,21,21,0)
	pbadv_setup_101047_Tyronoe_preload(true, 23, 22,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	preload_sound("BGM_ADV_Recollection")
end
