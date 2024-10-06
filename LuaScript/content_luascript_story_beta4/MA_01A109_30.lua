

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)


	
	
	init_psbattleadv("201010002", "201010002")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	pbadv_setup_101009_Noir(2,true, 13, 20,0)  

	
	pbadv_setup_101011_Guinevere(1,true,13, 19,0)

	
	pbadv_setup_101013_Gawain(0,true, 12, 19,0)  

	
	pbadv_setup_101018_Ragnar(1,true, 14, 19,0)  

   
	pbadv_setup_101030_Elaine(3,true, 16, 19,0)  

	
	pbadv_setup_101031_Lovein(1,true, 18, 20,0)  

	pbadv_setup_101037_Rasia(0,true, 41, 10,0) 

	
	barbaroi1 = dot_reserve_enemy(204, 19, 20, 0)
	barbaroi2 = dot_reserve_enemy(42, 17, 19, 0)

	
	pbadv_setup_101044_Gliten(true, 20, 17,0) 
	pbadv_setup_101045_Glitonea(true, 20, 16,0) 
	
	
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotRasia, DotDir_Left)
	
	dot_change_anim(dotGuinevere1, 1)
	dot_disp_weapon(dotRasia,false)

	dot_move_height(dotGliten,1,0,0)
	dot_move_height(dotGlitonea,1,0,0)

	dot_unit_dir(dotRagnar1, 2)

	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(40, 10, 0.0)
	
	
	Ef_Witch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	
end






function Play()
	fadein(0)
	Play_start(true)



	change_face(Rasia, "Sad")
	open_mind_window("CHRNAME_RASIA", Rasia, nil)
	message("MA_01A109_300002")
	
	
	message("MA_01A109_300004")
	close_mind_window()


	move_camera(16, 20, 3.0)
	wait_camera()



	dot_change_anim(dotElaine3, 3)
	dot_change_anim(dotLovein1, 3)

	dot_dying_unit_seq(barbaroi1)
	dot_dying_unit_seq(barbaroi2)
	wait_seq()

	dot_disp_unit(dotRasia, false)

	wait_time(0.5)

	dot_change_anim(dotElaine3, 0)
	dot_change_anim(dotLovein1, 0)


	change_face(Rasia, "Sad")
	open_speech_window("CHRNAME_RASIA", Rasia, nil)
	message("MA_01A109_300006")
	close_speech_window()


	dot_move_height(dotGliten,1.3,1,0)
	dot_move_height(dotGlitonea,1.3,1,0)

	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_300008")
	close_speech_window()
	
	move_camera(15, 19, 1.0)
	wait_camera()
	
	change_face(Elaine3, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine3, nil)
	message("MA_01A109_300009")
	close_speech_window()
	
	
	change_face(Gliten, "Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_300010")
	close_speech_window()
	
	
	change_face(Lovein1, "Normal")
	open_speech_window("CHRNAME_LOVEIN2", Lovein1, nil)
	message("MA_01A109_300011")
	close_speech_window()


	move_camera(14, 19, 1.0)
	wait_camera()

	change_face(Gawain, "Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A109_300013")
	close_speech_window()

	dot_unit_dir(dotRagnar1, 3)

	
	change_face(Ragnar1, "Surprise")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar1, nil)
	message("MA_01A109_300014")
	close_speech_window()

	
	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_300015")
	
	
	
	message("MA_01A109_300016")
	close_speech_window()
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A109_300017")
	close_speech_window()
	
	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_300018")
	
	
	
	message("MA_01A109_300020")
	close_speech_window()

	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_300021")
	close_speech_window()
	

	
	change_face(Rasia, "Sad")
	open_speech_window("CHRNAME_RASIA", Rasia, nil)
	message("MA_01A109_300023")
	close_speech_window()
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A109_300024")
	close_speech_window()

	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A109_300025")
	close_speech_window()
	
	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_300026")
	close_speech_window()
	
	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_300027")
	close_speech_window()
	

	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_300029")
	close_speech_window()
	
	dot_change_anim(dotGuinevere1, 0)
	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A109_300030")
	close_speech_window()
	

	
	change_face(Gliten, "Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_300032")
	close_speech_window()
	
	
	change_face(Glitonea, "Smile")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01A109_300033")
	close_speech_window()
	

	

	on_active(Ef_Witch)

	local gridpos = get_grid_position(20, 17)
	gridpos[2] = 1.0
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch)

	on_active(Ef_Witch2)

	local gridpos = get_grid_position(20, 16)
	gridpos[2] = 1.1
	set_pos(Ef_Witch2, gridpos)
	set_scale(Ef_Witch2, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch2)

	wait_time(1.0)
	
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotGliten, false)

	wait_time(2.0)

	
	change_face(Gliten, "Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A109_300035")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 13, 20,0)
	pbadv_setup_101011_Guinevere_preload(1,true,13, 19,0)
	pbadv_setup_101013_Gawain_preload(0,true, 12, 19,0)
	pbadv_setup_101018_Ragnar_preload(1,true, 14, 19,0)
	pbadv_setup_101030_Elaine_preload(3,true, 16, 19,0)
	pbadv_setup_101031_Lovein_preload(1,true, 18, 20,0)
	pbadv_setup_101037_Rasia_preload(0,true, 41, 10,0)
	pbadv_setup_101044_Gliten_preload(true, 20, 17,0)
	pbadv_setup_101045_Glitonea_preload(true, 20, 16,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
end
