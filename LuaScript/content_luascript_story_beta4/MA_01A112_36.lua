

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	init_psbattleadv("201090100", "201090100")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	
	pbadv_setup_101009_Noir(2,true, 13, 5,0)  
	
	
	pbadv_setup_101011_Guinevere(0,true, 14, 5,0)  

	
	pbadv_setup_101013_Gawain(0,true, 15, 5,0)  

   
	pbadv_setup_101030_Elaine(1,true, 12, 5,0)  

	
	pbadv_setup_101031_Lovein(0,true, 11, 5,0)  
	
	
	pbadv_setup_101015_Arthur(0,true, 13, 4,0)  
	
	
	pbadv_setup_101020_Merlin(2,true, 14, 4,0)  


	pbadv_setup_101041_Morgan(2,true, 13, 2,0) 
	pbadv_setup_101041_Morgan(1,true, 0, 0,0) 


	
	barbaroi1 = dot_reserve_enemy(304, 7, 0, 0)	
	barbaroi2 = dot_reserve_enemy(49, 8, 0, 0)	
	barbaroi3 = dot_reserve_enemy(504, 9, 0, 0)	
	barbaroi4 = dot_reserve_enemy(304, 10, 0, 0)
	barbaroi5 = dot_reserve_enemy(49, 11, 0, 0)
	barbaroi6 = dot_reserve_enemy(504, 12, 0, 0)
	barbaroi7 = dot_reserve_enemy(304, 13, 0, 0)
	barbaroi8 = dot_reserve_enemy(49, 14, 0, 0)
	barbaroi9 = dot_reserve_enemy(504, 15, 0, 0)
	barbaroi10 = dot_reserve_enemy(304, 16, 0, 0)
	barbaroi11 = dot_reserve_enemy(49, 17, 0, 0)
	barbaroi12 = dot_reserve_enemy(504, 18, 0, 0)
	barbaroi13 = dot_reserve_enemy(304, 19, 0, 0)


	pbadv_setup_101042_Moronoe(true, 9, 1,0)  
	pbadv_setup_101043_Mazoe(true, 10, 1,0)  
	pbadv_setup_101044_Gliten(true, 11, 1,0) 
	pbadv_setup_101045_Glitonea(true, 12, 1,0) 
	pbadv_setup_101046_Gliton(true, 14, 1,0) 
	pbadv_setup_101047_Tyronoe(true, 15, 1,0) 
	pbadv_setup_101048_Thiten(true, 16, 1,0)  
	pbadv_setup_101049_Thiton(true, 17, 1,0)  
	
	
	setup_complete_unit()


	
	dot_unit_dir(dotMorgan2, 2)

	dot_unit_dir(dotNoir2, 0)
	dot_unit_dir(dotGuinevere, 0)
	dot_unit_dir(dotGawain, 0)
	dot_unit_dir(dotElaine1, 0)
	dot_unit_dir(dotLovein, 0)
	dot_unit_dir(dotArthur, 0)
	dot_unit_dir(dotMerlin2, 0)
	

	dot_disp_weapon(dotMorgan2, false)

	dot_disp_unit(dotNoir2, false)
	dot_disp_unit(dotGuinevere, false)
	dot_disp_unit(dotGawain, false)
	dot_disp_unit(dotElaine1, false)
	dot_disp_unit(dotLovein, false)
	dot_disp_unit(dotArthur, false)
	dot_disp_unit(dotMerlin2, false)

	dot_disp_unit(dotMorgan1, false)


	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotTyronoe, false)
	dot_disp_unit(dotThiten, false)
	dot_disp_unit(dotThiton, false)
	dot_disp_unit(dotGliton, false)
	

	dot_move_height(dotMoronoe,1,0,0)
	dot_move_height(dotGliten,1,0,0)
	dot_move_height(dotMazoe,1,0,0)
	dot_move_height(dotGlitonea,1,0,0)
	dot_move_height(dotTyronoe,1,0,0)
	dot_move_height(dotThiten,1,0,0)
	dot_move_height(dotThiton,1,0,0)
	dot_move_height(dotGliton,1,0,0)

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(13, 3, 0.0)
	
	
	Ef_Witch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch9 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)

	
	Ef_ChangeWitch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)

	Ef_BalAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BalAura01_S_Lop", false, true)

	Ef_AuraArea = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area", false, true)

	load_sound("BGM_Battle_Tragedy_TragedyStart")

	on_active(Ef_AuraArea)

	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_AuraArea, gridpos)
	set_scale(Ef_AuraArea, {1.4, 1.4, 1.4})
	play_particle(Ef_AuraArea)


end







function Play()
	fadein(0)
	Play_start(true)
	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","笑い")
	message("MA_01A112_360002")



	fadeout(0,0,0,1.0, FADE_TIME)
	wait_time(TIME_ELAPSED + FADE_TIME)

	se_play("SE_ADV_MA_01B900_06_Door_Close")
	wait_time(0.5)
	
	dot_disp_unit(dotNoir2, true)
	dot_disp_unit(dotGuinevere, true)
	dot_disp_unit(dotGawain, true)
	dot_disp_unit(dotElaine1, true)
	dot_disp_unit(dotLovein, true)
	dot_disp_unit(dotArthur, true)
	dot_disp_unit(dotMerlin2, true)

	wait_time(0.5)

	fadein(FADE_TIME)
	wait_time(FADE_TIME)


	
	change_face(Morgan2, "Normal")
	message("MA_01A112_360004")
	
	
	change_face(Morgan2, "Smile")
	message("MA_01A112_360005")
	close_speech_window()
	
	
	change_face(Arthur, "Anger")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー","怒り")
	message("MA_01A112_360006")
	close_speech_window()
	

	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","納得")
	message("MA_01A112_360007")
	
	
	change_face(Morgan2, "Normal")
	 --PlayPartVoice("モルガン","挨拶")
	message("MA_01A112_360009")
	close_speech_window()
	
	
	
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01A112_360010")
	close_speech_window()


	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","笑い")
	message("MA_01A112_360012")
	close_speech_window()
	

	on_active(Ef_Witch2)

	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_Witch2, gridpos)
	set_scale(Ef_Witch2, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch2)

	wait_time(0.5)

	dot_place_unit(dotMorgan2,6,3)
	dot_disp_unit(dotMorgan2, false)
	wait_time(2.0)

	move_camera(6, 3, 0.0)
	wait_camera()

	wait_time(0.5)

	on_active(Ef_Witch)

	
	local gridpos = get_grid_position(6, 3)
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch)

	
	dot_unit_dir(dotMorgan2, 3)
	
	
	wait_time(0.5)
	dot_disp_unit(dotMorgan2, true)
	
	
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotElaine1, 2)
	dot_unit_dir(dotLovein, 2)
	dot_unit_dir(dotArthur, 2)
	dot_unit_dir(dotMerlin2, 2)
	
	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","肯定")
	message("MA_01A112_360014")
	
	

	change_face(Morgan2, "Normal")
	message("MA_01A112_360015")
	close_speech_window()
	
	
	change_face(Lovein, "Normal")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	 --PlayPartVoice("ラヴェイン","怒り")
	message("MA_01A112_360017")
	close_speech_window()
	
	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア","怒り")
	message("MA_01A112_360018")
	close_speech_window()

	local gridpos = get_grid_position(6, 3)
	set_pos(Ef_Witch2, gridpos)
	set_scale(Ef_Witch2, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch2)
	wait_time(0.5)

	
	dot_place_unit(dotMorgan2,20,4)
	dot_disp_unit(dotMorgan2, false)
	wait_time(2.0)

	move_camera(20, 4, 0.0)
	wait_camera()

	wait_time(0.5)
	
	
	local gridpos = get_grid_position(20, 4)
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch)

	
	wait_time(0.5)
	dot_disp_unit(dotMorgan2, true)


	
	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotGuinevere, 3)
	dot_unit_dir(dotGawain, 3)
	dot_unit_dir(dotElaine1, 3)
	dot_unit_dir(dotLovein, 3)
	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotMerlin2, 3)

	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","挨拶")
	message("MA_01A112_360019")
	
	

	change_face(Morgan2, "Normal")
	 --PlayPartVoice("モルガン","笑い")
	message("MA_01A112_360020")
	close_speech_window()
	
	

	change_face(Merlin2, "Normal")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン","否定")
	message("MA_01A112_360022")
	close_speech_window()

	local gridpos = get_grid_position(20, 4)
	set_pos(Ef_Witch2, gridpos)
	set_scale(Ef_Witch2, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch2)
	wait_time(0.5)

	
	dot_place_unit(dotMorgan2,9,4)
	dot_disp_unit(dotMorgan2, false)
	wait_time(2.0)
	
	move_camera(9, 4, 0.0)
	wait_camera()

	wait_time(0.5)
	
	

	
	local gridpos = get_grid_position(9, 4)
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch)

	
	dot_unit_dir(dotMorgan2, 3)

	wait_time(0.5)
	dot_disp_unit(dotMorgan2, true)


	
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotElaine1, 2)
	dot_unit_dir(dotLovein, 2)
	dot_unit_dir(dotArthur, 2)
	dot_unit_dir(dotMerlin2, 2)


	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","肯定2")
	message("MA_01A112_360024")
	
	

	change_face(Morgan2, "Normal")
	message("MA_01A112_360025")
	close_speech_window()
	
	
	change_face(Elaine1, "Surprise")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	 --PlayPartVoice("エレイン","驚き")
	message("MA_01A112_360027")
	close_speech_window()
	

	
	change_face(Arthur, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー","悲しみ")
	message("MA_01A112_360029")
	close_speech_window()

	local gridpos = get_grid_position(9, 4)
	set_pos(Ef_Witch2, gridpos)
	set_scale(Ef_Witch2, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch2)
	wait_time(0.5)

	
	dot_place_unit(dotMorgan2,17,2)
	dot_disp_unit(dotMorgan2, false)
	wait_time(2.0)

	move_camera(17, 2, 0.0)
	wait_camera()

	wait_time(0.5)
	

	
	local gridpos = get_grid_position(17, 2)
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch)

	wait_time(0.5)
	dot_disp_unit(dotMorgan2, true)


	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotGuinevere, 3)
	dot_unit_dir(dotGawain, 3)
	dot_unit_dir(dotElaine1, 3)
	dot_unit_dir(dotLovein, 3)
	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotMerlin2, 3)
	
	



	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","納得")
	message("MA_01A112_360030")
	close_speech_window()
	
	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア","驚き")
	message("MA_01A112_360032")
	close_speech_window()
	
	

	change_face(Merlin2, "Sad")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン","肯定2")
	message("MA_01A112_360033")
	close_speech_window()
	
	

	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー","肯定2")
	message("MA_01A112_360035")
	close_speech_window()
	

	local gridpos = get_grid_position(17, 2)
	set_pos(Ef_Witch2, gridpos)
	set_scale(Ef_Witch2, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch2)
	wait_time(0.5)


	
	dot_place_unit(dotMorgan2,13,3)
	dot_disp_unit(dotMorgan2, false)
	wait_time(2.0)

	move_camera(13, 3, 0.0)
	wait_camera()

	wait_time(0.5)
	
	

	
	local gridpos = get_grid_position(13, 3)
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch)

	wait_time(0.5)
	dot_disp_unit(dotMorgan2, true)

	
	

	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","落胆")
	message("MA_01A112_360037")
	close_speech_window()
	
	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	 --PlayPartVoice("ギネヴィア","怒り")
	message("MA_01A112_360039")
	
	
	MA_01A112_36_select1()

	open_select_window(Noir2, "Normal")	
	
	
	close_speech_window()	

	if is_select(1) then			
		MA_01A112_36_select1_1()

	else							
		MA_01A112_36_select1_2()

	end
	MA_01A112_36_end()

end

function MA_01A112_36_select1()

end

function MA_01A112_36_select1_1()



	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","落胆")
	message("MA_01A112_360044")
	close_speech_window()
	
	
	change_face(Merlin2, "Normal")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン","肯定2")
	message("MA_01A112_360046")
	
	
	
	message("MA_01A112_360047")
	close_speech_window()

		
end


function MA_01A112_36_select1_2()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","激怒")
	message("MA_01A112_360049")
	close_speech_window()
	
	

	change_face(Merlin2, "Normal")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン","肯定2")
	message("MA_01A112_360050")
	
	
	
	message("MA_01A112_360052")
	close_speech_window()

		
end


function MA_01A112_36_end()



	
	change_face(Elaine1, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A112_360054")
	close_speech_window()


	
	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","肯定2")
	message("MA_01A112_360055")
	
	

	change_face(Morgan2, "Normal")
	message("MA_01A112_360056")
	
	
	change_face(Morgan2, "Normal")
	message("MA_01A112_360058")
	close_speech_window()
	
	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー","悲しみ")
	message("MA_01A112_360059")
	close_speech_window()

	local gridpos = get_grid_position(13, 3)
	set_pos(Ef_Witch2, gridpos)
	set_scale(Ef_Witch2, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch2)
	wait_time(0.5)

	
	dot_place_unit(dotMorgan2,13,2)
	dot_disp_unit(dotMorgan2, false)
	wait_time(2.0)
	
	
	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_Witch, gridpos)
	set_scale(Ef_Witch, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch)

	dot_unit_dir(dotMorgan2, 2)

	wait_time(0.5)
	dot_disp_unit(dotMorgan2, true)


	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN", nil, Morgan2)
	 --PlayPartVoice("モルガン","肯定3")
	message("MA_01A112_360060")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")

	
	open_cutin(1,1)
	
	on_cutin(1, Morgan2, "Normal", 1)
	
	


	on_active(Ef_BalAura)

	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_BalAura, gridpos)
	play_particle(Ef_BalAura)

	
	open_speech_window("CHRNAME_MORGAN", nil, nil)
	 --PlayPartVoice("モルガンB","笑い")
	message("MA_01A112_360062")
	close_speech_window()

	bgm_play("BGM_Battle_Tragedy_TragedyStart")

	
	close_cutin()
	
	on_active(Ef_ChangeWitch)

	
	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_ChangeWitch, gridpos)
	play_particle(Ef_ChangeWitch)

	wait_time(0.5)
	
	
	dot_change_unit(dotMorgan2,dotMorgan1,0)




	on_active(Ef_Witch7)

	
	local gridpos = get_grid_position(9, 1)
	gridpos[2] = 1.0
	set_pos(Ef_Witch7, gridpos)
	set_scale(Ef_Witch7, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch7)

	

	local gridpos = get_grid_position(10, 1)
	gridpos[2] = 1.0
	set_pos(Ef_Witch2, gridpos)
	set_scale(Ef_Witch2, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch2)

	on_active(Ef_Witch3)

	local gridpos = get_grid_position(11, 1)
	gridpos[2] = 1.0
	set_pos(Ef_Witch3, gridpos)
	set_scale(Ef_Witch3, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch3)

	on_active(Ef_Witch4)

	local gridpos = get_grid_position(12, 1)
	gridpos[2] = 1.0
	set_pos(Ef_Witch4, gridpos)
	set_scale(Ef_Witch4, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch4)

	on_active(Ef_Witch5)

	local gridpos = get_grid_position(14, 1)
	gridpos[2] = 1.0
	set_pos(Ef_Witch5, gridpos)
	set_scale(Ef_Witch5, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch5)

	on_active(Ef_Witch6)

	local gridpos = get_grid_position(15, 1)
	gridpos[2] = 1.0
	set_pos(Ef_Witch6, gridpos)
	set_scale(Ef_Witch6, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch6)

	on_active(Ef_Witch9)

	local gridpos = get_grid_position(16, 1)
	gridpos[2] = 1.0
	set_pos(Ef_Witch9, gridpos)
	set_scale(Ef_Witch9, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch9)

	on_active(Ef_Witch8)

	local gridpos = get_grid_position(17, 1)
	gridpos[2] = 1.0
	set_pos(Ef_Witch8, gridpos)
	set_scale(Ef_Witch8, {0.8, 0.8, 0.8})
	play_particle(Ef_Witch8)


	
	wait_time(0.5)

	dot_disp_unit(dotMoronoe, true)
	dot_disp_unit(dotGliten, true)
	dot_disp_unit(dotMazoe, true)
	dot_disp_unit(dotGlitonea, true)
	dot_disp_unit(dotTyronoe, true)
	dot_disp_unit(dotThiten, true)
	dot_disp_unit(dotThiton, true)
	dot_disp_unit(dotGliton, true)


	

	
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01A112_360064")
	close_speech_window()
	
	
	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン","怒り")
	message("MA_01A112_360066")
	close_speech_window()
	
	
	change_face(Arthur, "Anger")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー","怒り")
	message("MA_01A112_360067")
	close_speech_window()
	
	
	change_face(Gawain, "Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	 --PlayPartVoice("ガウェイン","怒り")
	message("MA_01A112_360068")
	close_speech_window()
	
	
	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	 --PlayPartVoice("マーリン","肯定")
	message("MA_01A112_360069")
	
	
	
	message("MA_01A112_360070")
	close_speech_window()
	
	
	change_face(Arthur, "Anger")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_360071")
	close_speech_window()
	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	 --PlayPartVoice("モルガンB","肯定2")
	message("MA_01A112_360072")
	
	change_camera_distance(6.0, 1.0)

	dot_move_height(dotMorgan1,0.7,1,1)

	wait_camera()

	
	message("MA_01A112_360073")
	close_speech_window()
	
	
	
	open_speech_window("NPCNAME_0166", nil, nil)
	message("MA_01A112_360074")
	close_speech_window()

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 13, 5,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 14, 5,0)
	pbadv_setup_101013_Gawain_preload(0,true, 15, 5,0)
	pbadv_setup_101030_Elaine_preload(1,true, 12, 5,0)
	pbadv_setup_101031_Lovein_preload(0,true, 11, 5,0)
	pbadv_setup_101015_Arthur_preload(0,true, 13, 4,0)
	pbadv_setup_101020_Merlin_preload(2,true, 14, 4,0)
	pbadv_setup_101041_Morgan_preload(2,true, 13, 2,0)
	pbadv_setup_101041_Morgan_preload(1,true, 0, 0,0)
	pbadv_setup_101042_Moronoe_preload(true, 9, 1,0)
	pbadv_setup_101043_Mazoe_preload(true, 10, 1,0)
	pbadv_setup_101044_Gliten_preload(true, 11, 1,0)
	pbadv_setup_101045_Glitonea_preload(true, 12, 1,0)
	pbadv_setup_101046_Gliton_preload(true, 14, 1,0)
	pbadv_setup_101047_Tyronoe_preload(true, 15, 1,0)
	pbadv_setup_101048_Thiten_preload(true, 16, 1,0)
	pbadv_setup_101049_Thiton_preload(true, 17, 1,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BalAura01_S_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area", false, true)
	preload_sound("BGM_Battle_Tragedy_TragedyStart")
end
