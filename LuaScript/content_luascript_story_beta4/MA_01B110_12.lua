

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)


	init_psbattleadv("201040000", "201040000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true,5,5,0)  
	pbadv_setup_101026_Percival(0,true,4,5,0)  
	pbadv_setup_101027_Dindrane(0,true,4,3,0)  
	pbadv_setup_101036_Viena(0,true,5,3,0)  
	pbadv_setup_101042_Moronoe(true,8,4,0)  
	
	pbadv_setup_101027_Dindrane(2,true,35,3,0)  
	pbadv_setup_101036_Viena(1,true,36,3,0)  
	
	barbaroi1 = dot_reserve_enemy(1301, 9, 3, 0)
	barbaroi2 = dot_reserve_enemy(1301, 9, 5, 0)
	barbaroi3 = dot_reserve_enemy(1103, 10, 3, 0)
	barbaroi4 = dot_reserve_enemy(1103, 10, 5, 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotPercival, false)
	dot_disp_weapon(dotDindrane, false)
	dot_disp_weapon(dotViena, false)

	
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(dotDindrane2, false)
	dot_disp_unit(dotViena1, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(6, 5, 0.0)
	
	


	Ef_Killers1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	
	Ef_Vibes2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_Vibes3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem10", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem10", false, true) 

	Ef_Emblem3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_KillChan2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true) 


end





function Play()
	fadein(0)
	Play_start(true)
	
	
	
	change_face(Dindrane, "Anger")
	open_speech_window("CHRNAME_DINDRANE", Dindrane, nil)
	 --PlayPartVoice("ディンドラン","落胆")
	message("MA_01B110_120002")
	close_speech_window()	
	
	
	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	 --PlayPartVoice("フィエナ","怒り")
	message("MA_01B110_120003")
	close_speech_window()	
	
	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotPercival, true)

	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)
	on_active(Ef_Emblem3)

	local locatorpos = dot_get_unit_locator(dotPercival, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotDindrane, 1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotViena, 1)
	set_pos(Ef_Emblem3, locatorpos)
	play_particle(Ef_Emblem3)

	wait_time(2.0)

	on_active(Ef_Killers1)
	on_active(Ef_Vibes2)
	on_active(Ef_Vibes3)

	local gridpos = get_grid_position(4, 5)
	set_pos(Ef_Killers1, gridpos)
	play_particle(Ef_Killers1)

	local gridpos = get_grid_position(4, 3)
	set_pos(Ef_Vibes2, gridpos)
	play_particle(Ef_Vibes2)

	local gridpos = get_grid_position(5, 3)
	set_pos(Ef_Vibes3, gridpos)
	play_particle(Ef_Vibes3)

	wait_time(1.5)

	on_active(Ef_KillChan1)
	on_active(Ef_KillChan2)

	local gridpos = get_grid_position(4, 3)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	local gridpos = get_grid_position(5, 3)
	set_pos(Ef_KillChan2, gridpos)
	play_particle(Ef_KillChan2)

	wait_time(0.7)

	dot_change_unit(dotViena, dotViena1, 0.0)
	dot_change_unit(dotDindrane, dotDindrane2, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Vibes2)
	stop_particle(Ef_Vibes3)
	stop_particle(Ef_Killers1)
	
	wait_time(2.0)

	
	on_active(Ef_bar1) 
	on_active(Ef_bar2) 
	on_active(Ef_bar3) 
	on_active(Ef_bar4) 

	local gridpos = get_grid_position(10, 3) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)


	local gridpos = get_grid_position(10, 5) 
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar2)

	local gridpos = get_grid_position(9, 3) 
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar3)


	local gridpos = get_grid_position(9, 5) 
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar4)

	wait_time(0.2)
	
	dot_disp_unit(barbaroi1, true) 
	dot_disp_unit(barbaroi2, true) 
	dot_disp_unit(barbaroi3, true) 
	dot_disp_unit(barbaroi4, true) 

	wait_time(2.0)
	
	bgm_play("BGM_To_Main")
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","悩む")
	message("MA_01B110_120005")
	close_speech_window()	
	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	 --PlayPartVoice("モーロノエー","肯定2")
	message("MA_01B110_120006")
	
	
	
	
	
	message("MA_01B110_120007")
	close_speech_window()	
	
	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B110_120008")
	close_speech_window()	

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	 --PlayPartVoice("モーロノエー","笑い")
	message("MA_01B110_120009")
	close_speech_window()	

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	 --PlayPartVoice("パーシヴァル","激怒")
	message("MA_01B110_120010")
	close_speech_window()	


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,5,5,0)
	pbadv_setup_101026_Percival_preload(0,true,4,5,0)
	pbadv_setup_101027_Dindrane_preload(0,true,4,3,0)
	pbadv_setup_101036_Viena_preload(0,true,5,3,0)
	pbadv_setup_101042_Moronoe_preload(true,8,4,0)
	pbadv_setup_101027_Dindrane_preload(2,true,35,3,0)
	pbadv_setup_101036_Viena_preload(1,true,36,3,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem10", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem10", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
end
