
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201010000", "201010000")
	
	
	change_time_and_weather(4, 4)

	
	pbadv_setup_101030_Elaine(1,true, 31, 11,0)  
	pbadv_setup_101037_Rasia(1,true, 34, 11,0) 
	pbadv_setup_101031_Lovein(1,true, 31, 13,0)  

setup_complete_unit()


	
	dot_unit_dir(dotElaine1, 3)
	dot_unit_dir(dotLovein1, 3)
	dot_unit_dir(dotRasia1, 2)
	
	
	dot_disp_weapon(dotElaine1, true)
	dot_disp_weapon(dotRasia1, true)
	dot_disp_weapon(dotLovein1, true)
	
	
	Ef_Rasia = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem13", false, true)
	Ef_Ela = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true)
	Ef_Ela2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true)
	Ef_AURA1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_spout", false, true)
	Ef_AURA2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_spout", false, true)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(32, 12, 0.0)
end



function Play()
	fadein(0)
	Play_start(true)
	
	
	
	
	
	on_active(Ef_AURA1) 

	local gridpos = get_grid_position(31, 11)
	set_pos(Ef_AURA1, gridpos)
	play_particle(Ef_AURA1)
	
	wait_time(0.5)
	

open_cutin(1,1)

on_cutin(1,Elaine1,"Anger") 


	

	open_speech_window("CHRNAME_ELAINE", nil, nil)
	message("MA_01A900_400002")
	close_speech_window()


close_cutin()


	
	
	
	on_active(Ef_Ela) 
	local locatorpos = dot_get_unit_locator(dotElaine1,1)
	set_pos(Ef_Ela, locatorpos)

	wait_time(1.0)
	
	
	dot_attack_seq(dotElaine1, dotRasia1)
	dot_damage_seq(dotRasia1, dotElaine1, true)
	
	
	wait_time(0.5)
	
	
	dot_move_knockback(dotRasia1,35,11,0.4, 2)
	
	
	wait_time(0.3)
	
	
	dot_unit_dir(dotRasia1, 2)
	
	
	wait_time(0.3)
	
	stop_particle(Ef_AURA1)
	
	
	dot_change_anim(dotElaine1,0)

	
	change_face(Rasia1, "Anger")	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia1)
	message("MA_01A900_400004")
	close_speech_window()
	
	

	

	on_active(Ef_Rasia) 
	local locatorpos = dot_get_unit_locator(dotRasia1,1)
	set_pos(Ef_Rasia, locatorpos)

	wait_time(2.0)
	
	
	dot_attack_seq(dotRasia1, dotElaine1)
	dot_disp_weapon(dotLovein1, false)

	
	change_face(Lovein1, "Anger")	
	open_speech_window("CHRNAME_LOVEIN2", Lovein1, nil)
	message("MA_01A900_400006")
	close_speech_window()
	
	
	dot_move_unit_seq(dotLovein1, 32,  12)
	
	
	wait_time(0.5)
	
	
	dot_damage_seq(dotLovein1, dotRasia1, true)
	
	
	wait_time(0.5)
	
	dot_change_anim(dotLovein1,1)

	
	dot_change_anim(dotRasia1,0)


	
	change_face(Elaine1, "Surprise")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_400008")
	close_speech_window()
	
	

	
	change_face(Lovein1, "Anger")	
	open_speech_window("CHRNAME_LOVEIN2", Lovein1, nil)
	message("MA_01A900_400010")
	close_speech_window()

	
	change_face(Rasia1, "Anger")	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia1)
	message("MA_01A900_400012")
	close_speech_window()
	
	
		
	on_active(Ef_AURA2) 
	local gridpos = get_grid_position(31, 11)
	set_pos(Ef_AURA2, gridpos)
	play_particle(Ef_AURA2)
	
	
	on_active(Ef_Ela2) 
	local locatorpos = dot_get_unit_locator(dotElaine1,1)
	set_pos(Ef_Ela2, locatorpos)

	wait_time(1.0)	
	
	
	wait_time(0.5)
	

	
	change_face(Elaine1, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_400014")
	close_speech_window()

	
	change_face(Rasia1, "Anger")	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia1)
	message("MA_01A900_400015")
	close_speech_window()

	
	change_face(Elaine1, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_400016")
	
	change_face(Elaine1, "Anger")
	message("MA_01A900_400017")
	close_speech_window()

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101030_Elaine_preload(1,true, 31, 11,0)
	pbadv_setup_101037_Rasia_preload(1,true, 34, 11,0)
	pbadv_setup_101031_Lovein_preload(1,true, 31, 13,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem13", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_spout", false, true)
end
