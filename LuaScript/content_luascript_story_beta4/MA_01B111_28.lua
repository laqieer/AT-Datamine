

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
















	load_image("MA01B1112801", "content_still_10102007_image", "101020070_StillImage")
	
	
	
	
	
	
	init_psbattleadv("201200001", "201200001")
	
	
	change_time_and_weather(1, 5)

	pbadv_setup_101009_Noir(2,true, 7, 2,0)  
	pbadv_setup_101010_Lancelot(1,true, 7, 3,0)  
	pbadv_setup_101011_Guinevere(0,true,9,2,0)  
	pbadv_setup_101013_Gawain(0,true,8,3,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 8, 2,0)  
	pbadv_setup_101018_Ragnar(1,true, 9, 1,0)  
    
	
    
	pbadv_setup_101051_Lucius(0,true,1,2,0)  	
	pbadv_setup_101052_Vernarth(0,true,1,3,0)	
	pbadv_setup_101039_Fren(0,true,3,1,0) 
	pbadv_setup_101038_Lola(0,true,4,2,0) 
	pbadv_setup_101037_Rasia(0,true,3,3,0) 
	

	dotroma1 = dot_reserve_ally(401039001, 0, 1, 0)
	dot_set_weapon(dotroma1, 105010001)		
	dotroma2 = dot_reserve_ally(401039001, 0, 2, 0)
	dot_set_weapon(dotroma2, 102010001)		
	dotroma3 = dot_reserve_ally(401039001, 0, 3, 0)
	dot_set_weapon(dotroma3, 105010001)		
	dotroma4 = dot_reserve_ally(401039001, 0, 4, 0)
	dot_set_weapon(dotroma4, 102010001)		
	dotroma5 = dot_reserve_ally(401039001, 0, 5, 0)
	dot_set_weapon(dotroma5, 105010001)		
	dotroma6 = dot_reserve_ally(401039001, 0, 6, 0)
	dot_set_weapon(dotroma6, 102010001)		
	dotroma7 = dot_reserve_ally(401039001, 0, 7, 0)
	dot_set_weapon(dotroma7, 105010001)		
	dotroma8 = dot_reserve_ally(401039001, 0, 8, 0)
	dot_set_weapon(dotroma8, 102010001)		
	
	barubaroi1 = dot_reserve_enemy(1, 12, 1, 0)
	barubaroi2 = dot_reserve_enemy(1, 12, 2, 0)
	barubaroi3 = dot_reserve_enemy(1, 12, 3, 0)
	barubaroi4 = dot_reserve_enemy(1, 12, 4, 0)
	barubaroi5 = dot_reserve_enemy(1, 12, 5, 0)
	barubaroi6 = dot_reserve_enemy(1, 12, 6, 0)
	barubaroi7 = dot_reserve_enemy(1, 12, 7, 0)
	barubaroi8 = dot_reserve_enemy(1, 12, 8, 0)
	

	
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotGwenhwymawr1, 2)
	dot_unit_dir(dotRagnar1, 2)
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotLancelot1, 2)

	dot_unit_dir(barubaroi1 , 2)
	dot_unit_dir(barubaroi2 , 2)
	dot_unit_dir(barubaroi3 , 2)
	dot_unit_dir(barubaroi4 , 2)
	dot_unit_dir(barubaroi5 , 2)
	dot_unit_dir(barubaroi6 , 2)
	dot_unit_dir(barubaroi7 , 2)
	dot_unit_dir(barubaroi8 , 2)

	
	dot_disp_unit(dotNoir2, false)
	dot_disp_unit(dotLancelot1, false)


	
	dot_change_anim(dotGuinevere, 1)
	
	
	Ef_WarpIN = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIN2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	
	Ef_MONSHOUF = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem15", false, true)
	Ef_MONSHOUL = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem16", false, true)
	Ef_MONSHOUR = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem13", false, true)
	Ef_MONSHOUN = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	Ef_MONSHOUL2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	Ef_MONSHOUN3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	
	Ef_HIKARI = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White01", false, true)
	Ef_SEIHAI = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(5, 3, 0.0)
end

function Play()
	fadein(0)
	Play_start(true)

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS",  nil,Lucius)
	message("MA_01B111_280002")
	close_speech_window()

	
	dot_change_anim(dotGuinevere, 0)
	
	
	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_280004")
	close_speech_window()


	
	change_face(Lucius, "Smile")
	open_speech_window("CHRNAME_LUCIUS",  nil,Lucius)
	message("MA_01B111_280006")

	
	change_face(Lucius, "Normal")
	message("MA_01B111_280007")

	
	
	
	change_face(Lucius, "Normal")
	message("MA_01B111_280009")
	close_speech_window()

	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_280011")
	close_speech_window()

	
	on_active(Ef_HIKARI) 

	local gridpos = get_grid_position(6, 3) 
	set_pos(Ef_HIKARI, gridpos)
	play_particle(Ef_HIKARI)
	
	on_active(Ef_HIKARI) 	
	
	wait_time(1.0)

	se_play("SE_ADV_MA_01A900_25_Earthquake_loop")

	wait_time(1.5)
	
	change_face(Lucius, "Surprise")
	open_speech_window("CHRNAME_LUCIUS",  nil,Lucius)
	message("MA_01B111_280013")
	close_speech_window()
	
	
	
	move_camera(6, 3, 0.7)
	wait_camera()
	
	wait_time(0.5)

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_280014")
	close_speech_window()

	
	se_play("SE_LoopSE_Stop")

	
	wait_time(0.5)
	
	
	on_active(Ef_WarpIN) 

	local gridpos = get_grid_position(7, 2) 
	set_pos(Ef_WarpIN, gridpos)
	play_particle(Ef_WarpIN)
	
	on_active(Ef_WarpIN2) 

	local gridpos = get_grid_position(7, 3) 
	set_pos(Ef_WarpIN2, gridpos)
	play_particle(Ef_WarpIN2)

	wait_time(0.5)
        
	
	dot_disp_unit(dotNoir2, true)
	dot_disp_unit(dotLancelot1, true)

	wait_time(1.5)

	
	change_face(Rasia, "Surprise")
	open_speech_window("CHRNAME_RASIA", nil, Rasia)
	message("MA_01B111_280016")
	close_speech_window()
	
	
	
	
	
	
	show_image("MA01B1112801", 0.0, 0.0, STILL_SWITCH_TIME)
	set_position_image(STILL_POS_LEFT,STILL_POS_LENGTH)
	set_scale_image(STILL_SCALE,STILL_SCALE)
	
	wait_time(STILL_SWITCH_TIME)
	
	scale_to_image(1,1,STILL_MOVE_TIME2,2)
	move_to_image(0,0,STILL_MOVE_TIME2,2)
	wait_time(STILL_ACTIVE_AFTER)
	
	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01B111_280017")
	close_simple_window()
	
	
	dot_attack_seq(dotLancelot1, dotLucius)
	
	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
	
	

	
	

	dot_play_particle_unit(dotroma1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotroma2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotroma3,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotroma4,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	dot_play_particle_unit(dotroma5,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	dot_play_particle_unit(dotroma6,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	dot_play_particle_unit(dotroma7,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	dot_play_particle_unit(dotroma8,"Ef_C_Cmn_N_Hit_Sla01",1,true)		
	dot_play_particle_unit(barubaroi1,"Ef_C_Cmn_N_Hit_Sla01",1,true)		
	dot_play_particle_unit(barubaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	dot_play_particle_unit(barubaroi3,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	dot_play_particle_unit(barubaroi4,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	dot_play_particle_unit(barubaroi5,"Ef_C_Cmn_N_Hit_Sla01",1,true)		
	dot_play_particle_unit(barubaroi6,"Ef_C_Cmn_N_Hit_Sla01",1,true)		
	dot_play_particle_unit(barubaroi7,"Ef_C_Cmn_N_Hit_Sla01",1,true)		
	dot_play_particle_unit(barubaroi8,"Ef_C_Cmn_N_Hit_Sla01",1,true)		

	
	wait_time(0.3)		
			
	
	dot_change_anim(dotroma1, 1)
	dot_change_anim(dotroma2, 1)
	dot_change_anim(dotroma3, 1)
	dot_change_anim(dotroma4, 1)
	dot_change_anim(dotroma5, 1)
	dot_change_anim(dotroma6, 1)
	dot_change_anim(dotroma7, 1)
	dot_change_anim(dotroma8, 1)
	dot_change_anim(barubaroi1, 1)
	dot_change_anim(barubaroi2, 1)
	dot_change_anim(barubaroi3, 1)
	dot_change_anim(barubaroi4, 1)
	dot_change_anim(barubaroi5, 1)
	dot_change_anim(barubaroi6, 1)
	dot_change_anim(barubaroi7, 1)
	dot_change_anim(barubaroi8, 1)
	

	
	wait_time(1.0)	

	
	dot_change_anim(dotLancelot1, 0)


	
	
	
	change_face(Vernarth, "Serious")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01B111_280019")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS",  nil,Lucius)
	message("MA_01B111_280020")
	close_speech_window()


	
	on_active(Ef_SEIHAI) 
	local locatorpos = dot_get_unit_locator(dotNoir2,1)
	set_pos(Ef_SEIHAI, locatorpos)
	
	
	wait_time(1.5)		
	
	stop_particle(Ef_SEIHAI)	

	
	wait_time(0.5)	
	
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_280022")
	close_speech_window()

	
	change_face(Gawain, "Serious")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01B111_280023")
	close_speech_window()

	
	
	on_active(Ef_MONSHOUL2) 
	local locatorpos = dot_get_unit_locator(dotLancelot1,1)
	set_pos(Ef_MONSHOUL2, locatorpos)
	
	
	wait_time(1.5)	
	
	on_active(Ef_MONSHOUN) 
	local locatorpos = dot_get_unit_locator(dotNoir2,1)
	set_pos(Ef_MONSHOUN, locatorpos)
	
	wait_time(1.2)	
	
	
	move_camera(2, 3, 0.9)
	
	
	wait_time(0.8)	

	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",  nil,Lucius)
	message("MA_01B111_280025")
	close_speech_window()

	
	change_face(Vernarth, "Serious")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01B111_280026")
	close_speech_window()
	
	
	move_camera(4, 3, 0.5)

	
	
	

	
	wait_time(0.5)	
	
	
	dot_change_anim(dotroma1, 0)
	dot_change_anim(dotroma2, 0)
	dot_change_anim(dotroma3, 0)
	dot_change_anim(dotroma4, 0)
	dot_change_anim(dotroma5, 0)
	dot_change_anim(dotroma6, 0)
	dot_change_anim(dotroma7, 0)
	dot_change_anim(dotroma8, 0)
	dot_change_anim(barubaroi1, 0)
	dot_change_anim(barubaroi2, 0)
	dot_change_anim(barubaroi3, 0)
	dot_change_anim(barubaroi4, 0)
	dot_change_anim(barubaroi5, 0)
	dot_change_anim(barubaroi6, 0)
	dot_change_anim(barubaroi7, 0)
	dot_change_anim(barubaroi8, 0)

	



	
	
	wait_time(0.3)	
	
	dot_change_anim(dotLola, 3)
	
	
	wait_time(0.2)	
	
	
	change_face(Lola, "Anger")
	open_speech_window("CHRNAME_LOLA", nil, Lola)
	message("MA_01B111_280028")
	close_speech_window()

	
	



	
	


	dot_change_anim(dotLola, 0)

	
	wait_time(0.3)	
	
	dot_change_anim(dotFren, 3)
	
	
	wait_time(0.2)	

	
	change_face(Fren, "Anger")
	open_speech_window("CHRNAME_FREN",  nil,Fren)
	message("MA_01B111_280030")
	close_speech_window()

	



	
	
	



	dot_change_anim(dotFren, 0)

	
	wait_time(0.3)	
	
	dot_change_anim(dotRasia, 3)
	
	
	wait_time(0.2)	

	
	
	change_face(Rasia, "Anger")
	open_speech_window("CHRNAME_RASIA", nil, Rasia)
	message("MA_01B111_280031")
	close_speech_window()
	
	dot_change_anim(dotRasia, 0)

	
	change_face(Lucius, "Anger")
	open_speech_window("CHRNAME_LUCIUS",  nil,Lucius)
	message("MA_01B111_280032")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dotNoir2, 6, 2)
	dot_reserve_move_unit_seq(dotLancelot1, 6, 3)
	exec_parallel_seq()
	wait_seq()
	

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_280033")
	close_speech_window()

	
	change_face(Lola, "Anger")
	open_speech_window("CHRNAME_LOLA", nil, Lola)
	message("MA_01B111_280034")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_280035")
	close_speech_window()

	
	change_face(Fren, "Anger")
	open_speech_window("CHRNAME_FREN",  nil,Fren)
	message("MA_01B111_280036")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_280037")

	
	dot_change_anim(dotLancelot1, 12)	

	
	
	wait_time(0.5)	

	
	change_face(Lancelot1, "Anger")
	message("MA_01B111_280039")
	close_speech_window()
	
	
	dot_change_anim(dotNoir2, 12)	


	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_280041")
	close_speech_window()

	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("MA01B1112801", "content_still_10102007_image", "101020070_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 7, 2,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 7, 3,0)
	pbadv_setup_101011_Guinevere_preload(0,true,9,2,0)
	pbadv_setup_101013_Gawain_preload(0,true,8,3,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 8, 2,0)
	pbadv_setup_101018_Ragnar_preload(1,true, 9, 1,0)
	pbadv_setup_101051_Lucius_preload(0,true,1,2,0)
	pbadv_setup_101052_Vernarth_preload(0,true,1,3,0)
	pbadv_setup_101039_Fren_preload(0,true,3,1,0)
	pbadv_setup_101038_Lola_preload(0,true,4,2,0)
	pbadv_setup_101037_Rasia_preload(0,true,3,3,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem15", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem16", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem13", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
end
