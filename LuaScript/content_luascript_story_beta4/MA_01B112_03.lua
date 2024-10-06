

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	init_psbattleadv("201120100", "201120100")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	
	pbadv_setup_101020_Merlin(2,true, 10, 3,0)  
	pbadv_setup_101011_Guinevere(0,true, 10, 5,0)  
	
	
	
	pbadv_setup_101029_Astera(0,true, 8, 4,0) 
	pbadv_setup_101029_Astera(1,true,13, 2,0) 
	pbadv_setup_101056_Perez(1,true, 14, 3,0)  
	pbadv_setup_101053_Mathajim(2,true, 15, 1,0)  
	pbadv_setup_101054_Adam(2,true, 15, 3,0)  
	pbadv_setup_101055_Owen(2,true, 15, 5,0)  
	
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotMathajim2, 2)
	dot_unit_dir(dotAdam2, 2)
	dot_unit_dir(dotOwen2, 2)
	
	
	
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotMerlin2, false)
	dot_disp_weapon(dotAstera, false)
	dot_disp_weapon(dotAstera1, false)
	
	
	dot_disp_unit(dotAstera1, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(25.0, 0.0)
	
	
	move_camera(12, 5, 0.0)
	
	
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem14", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem14", false, true) 
	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_warp = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Enemy_spout = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)

	load_image("10202005",  "content_still_10202005_image", "102020050_StillImage")
	show_image("10202005", 0.0, 0.0, 0 ,true,false)

end







function Play()
	fadein(0)
	Play_start(true)


	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)


	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン", "落胆")
	message("MA_01B112_030002")
	close_speech_window()
	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "肯定2")
	message("MA_01B112_030003")
	close_speech_window()
	

	change_face(Astera, "Normal")
	open_speech_window("CHRNAME_ASTERA", nil, Astera)
	message("MA_01B112_030004")
	close_speech_window()
	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "怒り")
	message("MA_01B112_030005")
	close_speech_window()
	

	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	 --PlayPartVoice("ペレス", "笑い")
	message("MA_01B112_030006")
	close_speech_window()
	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B112_030007")
	close_speech_window()
	

	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン", "肯定2")
	message("MA_01B112_030008")
	close_speech_window()
	

	change_face(Astera, "Special")
	open_speech_window("CHRNAME_ASTERA", nil, Astera)
	 --PlayPartVoice("アステラ", "肯定2")
	message("MA_01B112_030009")
	close_speech_window()
	
				

	change_face(Merlin2, "Normal")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン", "笑い")
	message("MA_01B112_030011")
	close_speech_window()
	
	dot_change_anim(dotMerlin2, 4)

	wait_time(0.2)


	on_active(Ef_warp) 
	
	local gridpos = get_grid_position(10, 3)
	set_pos(Ef_warp, gridpos)
	play_particle(Ef_warp)

	wait_time(0.5)

	stop_particle(Ef_warp)



	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	 --PlayPartVoice("ペレス", "否定")
	message("MA_01B112_030013")
	close_speech_window()
	
	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)

	
	local locatorpos = dot_get_unit_locator(dotAstera, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)

	
	local locatorpos = dot_get_unit_locator(dotOwen2, 1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	wait_time(1.0)

	move_camera(10, 5, 2.0)
	change_camera_distance(6.0, 2.0)

	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(8, 4)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(15, 5)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(8, 4)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)

	dot_change_unit(dotAstera, dotAstera1, 0)
	se_play("SE_ADV_MA_01B109_12_Sword")
	dot_disp_weapon(dotAstera1, true)

	stop_particle(Ef_Killers)
	stop_particle(Ef_Vibes)

	wait_time(2.5)
	
	dot_move_unit_seq(dotAstera1, 9,3)
	
	dot_attack_seq(dotAstera1, dotMerlin2)
	dot_damage_seq(dotMerlin2, dotAstera1,true)
	wait_time(0.3)
	dot_change_anim(dotAstera1, 0)
	wait_seq()

	dot_change_anim(dotMerlin2, 1)

	wait_seq()
	dot_change_anim(dotAstera1, 0)
	wait_time(1.5)

	dot_unit_dir(dotGuinevere, 2)
	se_play("SE_ADV_MA_01B109_12_Sword")
	dot_disp_weapon(dotGuinevere, true)
	

	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B112_030015")
	close_speech_window()
	



	change_face(Astera1, "Normal")	
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B112_030017")
	close_speech_window()
	

	dot_move_unit_seq(dotOwen2, 11,5,2)
	wait_seq()
	
	

	dot_attack_seq(dotOwen2, dotGuinevere)
	dot_damage_seq(dotGuinevere, dotOwen2,true)
	wait_time(0.3)
	wait_seq()
	
	dot_unit_dir(dotGuinevere, 3)
	dot_change_anim(dotGuinevere, 1)

	
	dot_change_anim(dotOwen2, 0)
	wait_time(1.5)



	open_cutin(1,1)

	on_cutin(1,Guinevere, "Anger") 


	open_speech_window("CHRNAME_GUINEVERE", nil, nil)
	message("MA_01B112_030019")
	close_speech_window()


	close_cutin()


	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	 --PlayPartVoice("アステラ", "落胆")
	message("MA_01B112_030020")
	close_speech_window()
	

	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B112_030021")
	
	

	
	message("MA_01B112_030022")
	
	
	
	change_face(Guinevere, "Anger")
	
	 --PlayPartVoice("ギネヴィア", "怒り")
	message("MA_01B112_031001")
	close_speech_window()
	

	dot_reserve_move_unit_seq(dotOwen2,9,5)
	dot_reserve_move_unit_seq(dotPerez1,11,5,0.8)
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotOwen2, 3)



	
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_030024")
	
	
	
	message("MA_01B112_030026")
	close_speech_window()
	
	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B112_030027")
	close_speech_window()
	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	 --PlayPartVoice("ペレス", "肯定2")
	message("MA_01B112_030028")
	
	
	change_face(Perez1, "Normal")
	
	message("MA_01B112_030029")
	
	
	change_face(Perez1, "Normal")
	
	message("MA_01B112_030030")
	close_speech_window()
	

	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B112_030031")
	close_speech_window()
	

	
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_030032")
	
	
	
	on_active(Enemy_spout) 
	
	local gridpos = get_grid_position(11,5)
	set_pos(Enemy_spout, gridpos)
	play_particle(Enemy_spout)
			
	wait_time(0.5)

	stop_particle(Enemy_spout)
	
	

	change_face(Perez1, "Normal")
	
	message("MA_01B112_030034")
	
	

	change_face(Perez1, "Anger")
	
	 --PlayPartVoice("ペレス", "激怒")
	message("MA_01B112_030035")
	close_speech_window()
	

	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "驚き")
	message("MA_01B112_030036")
	close_speech_window()
	

	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_030037")
	
	
	
	
	message("MA_01B112_030038")
	close_speech_window()
	

	change_face(Merlin2, "Sad")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン", "肯定2")
	message("MA_01B112_030039")
	close_speech_window()
	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "怒り")
	message("MA_01B112_030040")
	
	

	change_face(Guinevere, "Normal")
	
	message("MA_01B112_030041")
	
	

	change_face(Guinevere, "Sad")
	
	message("MA_01B112_030042")
	close_speech_window()
	

	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B112_030043")
	
	

	change_face(Astera1, "Sad")
	
	message("MA_01B112_030044")
	close_speech_window()
	

	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "怒り")
	message("MA_01B112_030045")
	close_speech_window()
	

	dot_disp_weapon(dotAstera1, true)


	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_030047")
	close_speech_window()
	

	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B112_030048")
	close_speech_window()
	

	change_face(Astera1, "Anger")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B112_030049")
	close_speech_window()
	

	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	 --PlayPartVoice("ペレス", "笑い")
	message("MA_01B112_030050")
	close_speech_window()
	

	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア", "驚き")
	message("MA_01B112_030052")
	close_speech_window()
	

	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B112_030053")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101020_Merlin_preload(2,true, 10, 3,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 10, 5,0)
	pbadv_setup_101029_Astera_preload(0,true, 8, 4,0)
	pbadv_setup_101029_Astera_preload(1,true,13, 2,0)
	pbadv_setup_101056_Perez_preload(1,true, 14, 3,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 15, 1,0)
	pbadv_setup_101054_Adam_preload(2,true, 15, 3,0)
	pbadv_setup_101055_Owen_preload(2,true, 15, 5,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem14", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem14", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_image_preload("10202005",  "content_still_10202005_image", "102020050_StillImage")
end
