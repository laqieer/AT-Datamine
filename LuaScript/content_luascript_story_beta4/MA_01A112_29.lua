

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	init_psbattleadv("201080000", "201080000")
	change_time_and_weather(BattleTime_Night ,BattleWeather_Shiny)
	
    
	pbadv_setup_101041_Morgan(1,true, 8, 16,0) 
	
    
    pbadv_setup_101042_Moronoe(true, 7, 16,0)  
    
    pbadv_setup_101044_Gliten(true, 9, 16,0) 
	
	barbaroi1 = dot_reserve_enemy(3, 5, 15, 0)
	barbaroi2 = dot_reserve_enemy(3, 5, 16, 0)
	barbaroi3 = dot_reserve_enemy(3, 5, 17, 0)
	barbaroi4 = dot_reserve_enemy(3, 11, 15, 0)
	barbaroi5 = dot_reserve_enemy(3, 11, 16, 0)
	barbaroi6 = dot_reserve_enemy(3, 11, 17, 0)
	barbaroi7 = dot_reserve_enemy(3, 7, 18, 0)
	barbaroi8 = dot_reserve_enemy(3, 8, 18, 0)
	barbaroi9 = dot_reserve_enemy(3, 9, 18, 0)
	barbaroi10 = dot_reserve_enemy(3, 7, 14, 0)
	barbaroi11 = dot_reserve_enemy(3, 8, 14, 0)
	barbaroi12 = dot_reserve_enemy(3, 9, 14, 0)

	
	barbaroi14 = dot_reserve_enemy(3, 8, 15, 0)
	
	
	setup_complete_unit()

	dot_change_anim(dotMorgan1, 1)

	
	dot_unit_dir(dotMoronoe, 3)
	dot_unit_dir(barbaroi1, 3)
	dot_unit_dir(barbaroi2, 3)
	dot_unit_dir(barbaroi3, 3)

	
	dot_disp_weapon(dotMorgan1, false)
	
	change_camera_distance(8.0, 0.0)
	
	change_camera_angle(45.0, 0.0)
	
	move_camera(8, 16, 0.0)
	
	
	Ef_Lop = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	Ef_Witch_Spr = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true) 
	Ef_Witch_Spr2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true) 


	on_active(Ef_Lop)

	
	local gridpos = get_grid_position(8, 16)
	set_pos(Ef_Lop, gridpos)
	play_particle(Ef_Lop)

	
	turn(Ef_Witch_Spr,0, -30, 0,0)
	turn(Ef_Witch_Spr2,0, 30, 0,0)

	on_active(Ef_Witch_Spr) 

	local gridpos = get_grid_position(8, 16)
	set_pos(Ef_Witch_Spr, gridpos)
	play_particle(Ef_Witch_Spr)

	on_active(Ef_Witch_Spr2) 

	local gridpos = get_grid_position(8, 16)
	set_pos(Ef_Witch_Spr2, gridpos)
	play_particle(Ef_Witch_Spr2)	
	
end





function Play()
	fadein(0)
	Play_start(true)


	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	 --PlayPartVoice("モーロノエー","挨拶")
	message("MA_01A112_290002")
	
	
	
	message("MA_01A112_290003")
	close_speech_window()
	
	
	open_speech_window("CHRNAME_MORGAN", Morgan1, nil)
	 --PlayPartVoice("モルガン","悲しみ")
	message("MA_01A112_290005")
	close_speech_window()
	
	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	 --PlayPartVoice("グリーテン","笑い")
	message("MA_01A112_290006")
	close_speech_window()

	change_camera_distance(7.0, 1.0)

	
	open_speech_window("CHRNAME_MORGAN", Morgan1, nil)
	 --PlayPartVoice("モルガン","苦しみ")
	message("MA_01A112_290007")
	close_speech_window()
	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	 --PlayPartVoice("モーロノエー","笑い")
	message("MA_01A112_290008")
	close_speech_window()
	
	
	open_speech_window("CHRNAME_MORGAN", Morgan1, nil)
	message("MA_01A112_290009")
	close_speech_window()
	
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Moronoe, "Smile", 1)
	on_cutin(2, Gliten, "Smile", 1)
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1_3", nil, nil)
	message("MA_01A112_290010")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101041_Morgan_preload(1,true, 8, 16,0)
    pbadv_setup_101042_Moronoe_preload(true, 7, 16,0)
    pbadv_setup_101044_Gliten_preload(true, 9, 16,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
end
