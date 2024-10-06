

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	

	load_image("MA011044201", "content_image_beta3_ma0110442", "MA011044201")
	
	load_image("MA01A1092801", "content_still_10103003_image", "101030030_StillImage")

	
	setup_101009_Noir(nil, nil, 2, false) 
	setup_101013_Gawain(nil, nil, 0, false) 
	setup_101018_Ragnar(nil, nil, 1, false) 
	
	
	init_psbattleadv("201010002", "201010002")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	dotnoir = dot_reserve_ally(101009001, 13, 20, 0)
	dot_set_weapon(dotnoir, 101010001)	

	
	pbadv_setup_101011_Guinevere(1,true, 12, 19,0)  
	
	
	dotgawain = dot_reserve_ally(101013001, 10, 20, 0)
	dot_set_weapon(dotgawain, 103010001)

	
	dotragnar = dot_reserve_ally(101018002, 10, 19, 0)
	dot_set_weapon(dotragnar, 102010001)

   
	pbadv_setup_101030_Elaine(3,true, 7, 20,0)  

	
	pbadv_setup_101031_Lovein(0,true, 8, 20,0)  

	
	pbadv_setup_101031_Lovein(1,true, 16, 20,0)  
	
	

	pbadv_setup_101044_Gliten(true, 20, 17,0) 
	pbadv_setup_101045_Glitonea(true, 20, 16,0) 
	pbadv_setup_101046_Gliton(true, 20, 18,0) 

	barbaroi1 = dot_reserve_enemy(42, 17, 19, 0)
	barbaroi2 = dot_reserve_enemy(204, 18, 20, 0)
	barbaroi3 = dot_reserve_enemy(42, 17, 21, 0)

	
	
	setup_complete_unit()

	

	dot_disp_unit(dotLovein1, false)
	
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotGlitonea, false)

	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)

	dot_move_height(dotGliten,5,0,0)
	dot_move_height(dotGlitonea,5,0,0)

	dot_change_anim(dotGliton, 1)

	
	change_camera_distance(8.0, 0.0)

	
	change_camera_angle(25.0, 0.0)
	
	move_camera(15, 21, 0.0)
	
	
	Ef_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_Enemy2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_Enemy3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true) 

	Ef_WitchDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)

	load_sound("BGM_Battle_AfterGinevia_General2_Start")

end





function Play()
	fadein(0)
	Play_start(true)
	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280002")
	close_speech_window()

	
	
	change_face(Gliton, "Normal")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_280003")
	

	
	message("MA_01A109_280004")
	close_speech_window()
	
	
	change_face(Noir, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message("MA_01A109_280005")
	close_speech_window()
	
	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280006")
	close_speech_window()


	dot_disp_unit(dotGliten, true)
	dot_disp_unit(dotGlitonea, true)

	dot_move_height(dotGliten,1,3,2)
	dot_move_height(dotGlitonea,1,3,2)

	wait_time(2.0)

	
	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_280008")
	close_speech_window()
	
	
	change_face(Guinevere1, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	
	message("MA_01A109_280009")
	close_speech_window()
	
	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	
	message("MA_01A109_280010")
	close_speech_window()

	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	
	message("MA_01A109_280012")
	close_speech_window()
	
	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	
	message("MA_01A109_280013")
	close_speech_window()
	
	
	change_face(Gliton, "Normal")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_280015")
	close_speech_window()
	
	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280017")
	
	
	
	change_face(Guinevere1, "Normal")
	
	message("MA_01A109_280018")
	close_speech_window()


	move_camera(19, 18, 2.0)
	change_camera_angle(30.0, 2.0)
	wait_camera()

	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01A109_280020")
	

	
	message("MA_01A109_280021")
	close_speech_window()



	on_active(Ef_WitchDie) 

	local gridpos = get_grid_position(20, 18)
	set_pos(Ef_WitchDie, gridpos)
	play_particle(Ef_WitchDie)

	wait_time(1.0)

	dot_disp_unit(dotGliton, false)
	dot_remove_unit(dotGliton)

	wait_time(2.0)

	
	wait_seq()

	move_camera(20, 16, 1.0)
	change_camera_angle(25.0, 1.0)
	wait_camera()

	
	change_face(Glitonea, "Smile")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_280023")
	close_speech_window()
	
	
	change_face(Gliten, "Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_280025")
	close_speech_window()

	move_camera(13, 20, 2.0)
	wait_camera()
	
	
	change_face(Noir, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message("MA_01A109_280026")
	close_speech_window()
	
	
	change_face(Gliten, "Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_280027")
	close_speech_window()
	
	
	change_face(Glitonea, "Smile")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_280028")
	

	on_active(Ef_Enemy)

	
	local gridpos = get_grid_position(17, 19)
	set_pos(Ef_Enemy, gridpos)
	set_scale(Ef_Enemy, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy)

	on_active(Ef_Enemy2)

	local gridpos = get_grid_position(18, 20)
	set_pos(Ef_Enemy2, gridpos)
	set_scale(Ef_Enemy2, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy2)

	on_active(Ef_Enemy3)

	local gridpos = get_grid_position(17, 21)
	set_pos(Ef_Enemy3, gridpos)
	set_scale(Ef_Enemy3, {0.8, 0.8, 0.8})
	play_particle(Ef_Enemy3)

	wait_time(0.1)

	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)

	wait_time(1.5)


	
	MA_01A109_28_select1()

	bgm_play("BGM_Battle_AfterGinevia_General2_Start")

	
	open_select_window_tag(Noir, "Normal", "MA_01A109_280030", "MA_01A109_280031", "MA_01A109_280032")	

	close_speech_window()	

	if is_select(1) then			
		MA_01A109_28_select1_1()

	elseif is_select(2) then		
		MA_01A109_28_select1_2()

	elseif is_select(3) then		
		MA_01A109_28_select1_3()

	end
	MA_01A109_28_end()

end

function MA_01A109_28_select1()

end

function MA_01A109_28_select1_1()


	change_face(Noir, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message("MA_01A109_280034")
	close_speech_window()
	
	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280035")
	
	
	message("MA_01A109_280036")
	
	change_face(Guinevere1, "Sad")
	message("MA_01A109_280047")
	close_speech_window()


end


function MA_01A109_28_select1_2()

	move_camera(12, 20, 1.0)
	wait_camera()

	change_face(Noir, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message("MA_01A109_280038")
	close_speech_window()
	

	change_face(Gawain, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A109_280039")
	
	change_face(Gawain, "Anger")
	
	message("MA_01A109_280040")
	close_speech_window()

	
	change_face(Guinevere1, "Sad")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280047")
	close_speech_window()


end


function MA_01A109_28_select1_3()

	
	change_face(Noir, "Pain")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message("MA_01A109_280042")
	close_speech_window()
	
	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_280043")
	close_speech_window()

	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280045")

	
	change_face(Guinevere1, "Sad")
	message("MA_01A109_280047")
	close_speech_window()


end


function MA_01A109_28_end()


	dot_change_anim(dotGuinevere1, 6)

	wait_time(0.5)

	dot_change_anim(dotGuinevere1, 1)

	dot_unit_dir(dotnoir, 2)
		
	move_camera(12, 20, 1.0)
	wait_camera()
	
	change_face(Noir, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message("MA_01A109_280049")
	close_speech_window()



	
	change_face(Guinevere1, "Pain")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280050")
	close_speech_window()
	
	
	change_face(Ragnar, "Sad")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar, nil)
	message("MA_01A109_280051")
	close_speech_window()
	
	
	change_face(Gawain, "Serious")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A109_280053")
	close_speech_window()

	dot_unit_dir(dotnoir, 3)

	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_280054")
	close_speech_window()

	
	change_face(Guinevere1, "Pain")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280056")
	close_speech_window()
	
	
	change_face(Elaine3, "Surprise")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_280057")
	close_speech_window()
	
	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280058")
	
	
	
	message("MA_01A109_280059")
	close_speech_window()

	

	dot_move_unit_seq(dotElaine3, 14, 19)

	
	change_face(Elaine3, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_280061")
	close_speech_window()

	
	move_camera(15, 19, 2.0)
	wait_camera()
	
	
	change_face(Noir, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir, nil)
	message("MA_01A109_280062")
	close_speech_window()
	
	
	change_face(Elaine3, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_280063")
	close_speech_window()

	dot_move_unit_seq(dotLovein, 15, 19)

	
	change_face(Lovein, "Normal")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01A109_280064")
	close_speech_window()
	
	
	change_face(Elaine3, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_280066")
	
	
	
	change_face(Elaine3, "Anger")
	
	message("MA_01A109_280067")
	
	
	message("MA_01A109_280069")
	close_speech_window()
	
	
	change_face(Lovein, "Normal")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01A109_280070")
	close_speech_window()
	
	
	change_face(Gliten, "Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_280071")
	close_speech_window()


	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotElaine3,1)
	set_pos(Ef_Emblem1, locatorpos)

	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotLovein,1)
	set_pos(Ef_Emblem2, locatorpos)

	play_particle(Ef_Emblem2)

	wait_time(2.0)

	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(15, 19)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(14, 19)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)


	
	change_face(Elaine3, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_280072")
	close_speech_window()
	
	
	change_face(Lovein, "Anger")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01A109_280073")
	close_speech_window()
	
	
	change_face(Elaine3, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_280074")
	close_speech_window()
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Elaine3, "Anger", 1)
	on_cutin(2, Lovein, "Anger", 1)
	
	
	
	bgm_play("BGM_To_Main")
	open_speech_window("CHRNAME_ELAINE_LOVEIN", nil, nil)
	message("MA_01A109_280075")
	close_speech_window()

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(15, 19)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)
	
	
	close_cutin()
	wait_time(0.5)
	
	
	show_image("MA01A1092801", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)

	wait_time(2.5)

	dot_change_unit(dotLovein, dotLovein1, 0.0)

	move_camera(14, 19, 0.0)
	wait_camera()

	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
	
	
	change_face(Guinevere1, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_280077")
	close_speech_window()

	
	change_face(Lovein1, "Anger")
	open_speech_window("CHRNAME_LOVEIN2", Lovein1, nil)
	message("MA_01A109_280079")
	close_speech_window()

	dot_unit_dir(dotElaine3, 2)
	
	
	change_face(Elaine3, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_280081")
	
	
	
	change_face(Elaine3, "Normal")
	
	message("MA_01A109_280082")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("MA011044201", "content_image_beta3_ma0110442", "MA011044201")
	load_image_preload("MA01A1092801", "content_still_10103003_image", "101030030_StillImage")
	setup_101009_Noir_preload(nil, nil, 2, false)
	setup_101013_Gawain_preload(nil, nil, 0, false)
	setup_101018_Ragnar_preload(nil, nil, 1, false)
	pbadv_setup_101011_Guinevere_preload(1,true, 12, 19,0)
	pbadv_setup_101030_Elaine_preload(3,true, 7, 20,0)
	pbadv_setup_101031_Lovein_preload(0,true, 8, 20,0)
	pbadv_setup_101031_Lovein_preload(1,true, 16, 20,0)
	pbadv_setup_101044_Gliten_preload(true, 20, 17,0)
	pbadv_setup_101045_Glitonea_preload(true, 20, 16,0)
	pbadv_setup_101046_Gliton_preload(true, 20, 18,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	preload_sound("BGM_Battle_AfterGinevia_General2_Start")
end
