Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201200002","201200002")
	change_time_and_weather(1,1)
	
	
	

	pbadv_setup_101009_Noir(2,true,10,6,0)
	pbadv_setup_101011_Guinevere(1,true,12,6,0)
	pbadv_setup_101011_Guinevere(0,true,13,6,0)
	pbadv_setup_101036_Viena(1,true,13,5,0)
	pbadv_setup_101010_Lancelot(0,true,12,5,0)
	pbadv_setup_101034_Excelia(1,true,15,5,0)
	pbadv_setup_101035_Liliana(1,true,9,5,0)
	pbadv_setup_101028_Galahad(3,true,11,5,0)
	pbadv_setup_101054_Adam(0,true,8,5,0)
	pbadv_setup_101053_Mathajim(0,true,14,6,0)

	
	pbadv_setup_101044_Gliten(true,10,8,0)
	pbadv_setup_101042_Moronoe(true,12,8,0)
	pbadv_setup_101041_Morgan(1,true,11,8,0)
	pbadv_setup_101051_Lucius(0,true,11,10,0)
	
	
	barbaroi1 = dot_reserve_enemy(3, 14, 8, 0)
	barbaroi2 = dot_reserve_enemy(3, 15, 9, 0)
	barbaroi3 = dot_reserve_enemy(3, 9, 9, 0)
	barbaroi4 = dot_reserve_enemy(3, 8, 8, 0)
	
	
	
	setup_complete_unit()
	
	
	dot_disp_unit(dotGuinevere,false)
	dot_disp_unit(dotMorgan1,false)
	dot_disp_unit(dotGliten,false)
	dot_disp_unit(dotMoronoe,false)	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(11,9, 0.0)
	
	
	dot_change_anim(dotGalahad3,DotAnim_Squat)
	dot_unit_dir(dotViena1, DotDir_Left)
	dot_change_anim(dotViena1,DotAnim_Squat)
	dot_unit_dir(dotExcelia1, DotDir_Left)
	dot_change_anim(dotExcelia1,DotAnim_Squat)
	dot_unit_dir(dotLancelot, DotDir_Left)
	dot_change_anim(dotLancelot,DotAnim_Squat)
	dot_unit_dir(dotLiliana1, DotDir_Right)
	dot_change_anim(dotLiliana1,DotAnim_Squat)
	dot_unit_dir(dotGuinevere1, DotDir_Left)
	dot_change_anim(dotGuinevere1,DotAnim_Squat)
	dot_unit_dir(dotAdam, DotDir_Right)
	dot_change_anim(dotAdam,DotAnim_Squat)
	dot_unit_dir(dotMathajim, DotDir_Left)
	dot_change_anim(dotMathajim,DotAnim_Squat)
	wait_seq()
	
	
	dot_unit_dir(dotLucius, DotDir_Left)
	
	
	Ef_BlackFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true) 
	Ef_Change_Witch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true) 
	Ef_Killers_Cancel = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Cancel", false, true) 
	Ef_PivotCenter_526 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotCenter_526", false, true) 
	Ef_PivotTip_526 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_526", false, true) 
	Ef_Witch_Spr_AtkAura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true) 
	Ef_Hit_Witch_Spe = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	Ef_BlackFeather_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true) 
	Ef_Change_Witch_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true) 	
	Ef_Hit_Witch_Spe_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)	

	Ef_BlackFeather_3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true) 
	Ef_Change_Witch_3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true) 	
	Ef_Hit_Witch_Spe_3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)		
	
	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_BlFeather1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)	
	
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WitchSpear2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	Ef_WSpearAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchChange3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_BlFeather2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchSpearHit2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)		
	
	
	load_image("101030520", "content_still_10103052_image", "101030520_StillImage")	

	load_sound("BGM_ADV_Morgan")
	load_sound("BGM_Battle_Tragedy_TragedyStart")
	
	

end





function Play()
	Play_start(true)
	fadein(0)


	
	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A111_460002")


	
	message("MA_01A111_460004")

	
	message("MA_01A111_460005")
	close_speech_window()

	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_460006")
	close_speech_window()

	
	change_face(Lucius,"Normaal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A111_460007")

	
	message("MA_01A111_460008")

	
	message("MA_01A111_460009")

	
	message("MA_01A111_460011")
	
	
	
	open_select_window_tag(Noir2,"Normal","MA_01A111_460013","MA_01A111_460014","MA_01A111_460015")
	close_speech_window()
	
	
	
	dot_move_unit_seq(dotNoir2,11,7)
	wait_time(0.5)
	wait_seq()
	
	change_face(Noir2,"Serious")
	
	if is_select(1) then
		
		
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_460017")
		close_speech_window()

		
		change_face(Lucius,"Sad")
		open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
		message("MA_01A111_460018")

		
		change_face(Lucius,"Normal")
		message("MA_01A111_460019")
		
		
		change_face(Lucius,"Smile")

		elseif is_select(2) then

		
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_460021")
		close_speech_window()

		
		change_face(Lucius,"Normal")
		open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
		message("MA_01A111_460022")

		
		change_face(Lucius,"Smile")
		message("MA_01A111_460023")
		
		
		elseif is_select(3) then
		
		
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_460025")
		close_speech_window()

		
		change_face(Lucius,"Normal")
		open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
		message("MA_01A111_460026")

		
		change_face(Lucius,"Smile")
		message("MA_01A111_460027")
	
	end
	
	
	message("MA_01A111_460029")

	
	message("MA_01A111_460030")
	close_speech_window()

	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_460031")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Lucius,"Normal",0)
	
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, nil)
	message("MA_01A111_460032")
	
	
	message("MA_01A111_460034")

	
	message("MA_01A111_460035")

	
	message("MA_01A111_460036")

	
	message("MA_01A111_460037")

	on_cutin(1,Lucius,"Smile",0)
	
	change_face(Lucius,"Smile")
	message("MA_01A111_460038")
	close_speech_window()
	
	close_cutin()	
	wait_time(0.2)
	
	on_active(Ef_PivotCenter_526)

	local gridpos = get_grid_position(11, 8)
	gridpos[2] = 5.0
	set_pos(Ef_PivotCenter_526, gridpos)
	turn(Ef_PivotCenter_526,90, 0, 0, 0.0)
	play_particle(Ef_PivotCenter_526)
	
	on_active(Ef_Witch_Spr_AtkAura)

	set_pos(Ef_Witch_Spr_AtkAura, gridpos)
	turn(Ef_Witch_Spr_AtkAura,90, 0, 0, 0.0)
	play_particle(Ef_Witch_Spr_AtkAura)
	
	local gridpos = get_grid_position(11, 8)
	gridpos[2] = 1.61
	
	slidemove(Ef_PivotCenter_526, gridpos, 0.1)
	slidemove(Ef_Witch_Spr_AtkAura, gridpos, 0.1)
	
	on_active(Ef_Hit_Witch_Spe)

	local gridpos = get_grid_position(11, 8)
	gridpos[2] = 0.01
	set_pos(Ef_Hit_Witch_Spe, gridpos)
	play_particle(Ef_Hit_Witch_Spe)
	
	stop_particle(Ef_Witch_Spr_AtkAura)
	
	dot_play_particle_grid("Ef_C_Cmn_N_Hit_Sla01",11,8)
	
	
	dot_move_unit_seq(dotNoir2,10,6)
	wait_seq()
	dot_unit_dir(dotNoir2, DotDir_Right)
	
	
	dot_unit_dir(dotGliten, DotDir_Right)
	
	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_460040")
	close_speech_window()

	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01A111_460042")
	close_speech_window()
	
	
		
	on_active(Ef_BlackFeather)
	
	on_active(Ef_Change_Witch)

	local gridpos = get_grid_position(11, 8)
	set_pos(Ef_Change_Witch, gridpos)
	play_particle(Ef_Change_Witch)

	wait_time(0.5)

	stop_particle(Ef_PivotCenter_526)
	stop_particle(Ef_Hit_Witch_Spe)
	
	wait_time(1.3)
	
	dot_disp_unit(dotMorgan1,true)

	set_pos(Ef_BlackFeather, gridpos)
	play_particle(Ef_BlackFeather)
	
	wait_time(2.0)
	
	local gridpos = get_grid_position(11,8)
	
	set_pos(Ef_BlackFeather, gridpos)
	play_particle(Ef_BlackFeather)
	
	
	
	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01A111_460044")
	close_speech_window()
	
	
	
	
	bgm_play("BGM_ADV_Morgan")
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A111_460046")
	close_speech_window()

	
	change_face(Morgan1,"Normal")
	open_speech_window("CHRNAME_NAMELES", Morgan1, nil)
	message("MA_01A111_460047")
	close_speech_window()

	
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A111_460048")
	close_speech_window()

	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_460050")
	close_speech_window()

	
	change_face(Morgan1,"Smile")
	open_speech_window("CHRNAME_MORGAN2", Morgan1, nil)
	message("MA_01A111_460051")
	close_speech_window()

	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_460052")
	close_speech_window()

	
	open_speech_window("CHRNAME_MORGAN2", Morgan1, nil)
	message("MA_01A111_460053")
	close_speech_window()
	
	
	dot_move_unit_seq(dotLucius,11,9)
	wait_seq()
	dot_unit_dir(dotLucius, DotDir_Left)
	
	
	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A111_460054")
	close_speech_window()
	
	
	on_active(Ef_WSpearAppea1) 

	local gridpos = get_grid_position(10,8) 
	gridpos[2] = 2.5	
	set_pos(Ef_WSpearAppea1, gridpos)
	turn(Ef_WSpearAppea1,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAppea1)
	
	on_active(Ef_WSpearAppea2) 

	local gridpos = get_grid_position(12,8) 
	gridpos[2] = 2.5	
	set_pos(Ef_WSpearAppea2, gridpos)
	turn(Ef_WSpearAppea2,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAppea2)
	

	wait_time(0.5)
	
	on_active(Ef_WitchSpear1) 

	local gridpos = get_grid_position(10,8)
	gridpos[2] = 2.5 
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear1)
	
	on_active(Ef_WitchSpear2) 

	local gridpos = get_grid_position(12,8)
	gridpos[2] = 2.5 
	set_pos(Ef_WitchSpear2, gridpos)
	turn(Ef_WitchSpear2,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear2)	


--

	on_active(Ef_WSpearAura1) 
	local gridpos = get_grid_position(10,8)
	gridpos[2] = 2.0
--	set_pos(Ef_WSpearAura1, gridpos)
--	turn(Ef_WSpearAura1,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAura1)

	on_active(Ef_WSpearAura2) 
	local gridpos = get_grid_position(10,8)
	gridpos[2] = 2.0
--	set_pos(Ef_WSpearAura2, gridpos)
--	turn(Ef_WSpearAura2,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAura2)	
	
	wait_time(1.5)
	
	turn(Ef_WitchSpear1,45, -90, 0, 0.5)
	play_particle(Ef_WitchSpear1)


	turn(Ef_WitchSpear2,45, 45, 0, 0.5)
	play_particle(Ef_WitchSpear2)	

	wait_time(0.8)	

	bgm_play("BGM_Battle_Tragedy_TragedyStart")
	
--ブラックアウト
	fadeout(0,0,0,1.0, 0.6)
	wait_time(0.8)
	
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,90, 0, 0, 0.0)
	play_particle(Ef_WitchSpear1)
	
	local gridpos = get_grid_position(10, 8)
	gridpos[2] =0.4
	
	slidemove(Ef_WitchSpear1, gridpos, 0.1)
	slidemove(Ef_WSpearAura1, gridpos, 0.1)
	
	on_active(Ef_WitchSpearHit1)

	local gridpos = get_grid_position(10, 8)
	gridpos[2] = 0.4
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)
	
	
	set_pos(Ef_WitchSpear2, gridpos)
	turn(Ef_WitchSpear2,90, 0, 0, 0.0)
	play_particle(Ef_WitchSpear2)
	
	local gridpos = get_grid_position(12, 8)
	gridpos[2] = 0.4
	
	slidemove(Ef_WitchSpear2, gridpos, 0.1)
	slidemove(Ef_WSpearAura2, gridpos, 0.1)
	
	on_active(Ef_WitchSpearHit2)

	local gridpos = get_grid_position(12, 8)
	gridpos[2] = 0.4
	set_pos(Ef_WitchSpearHit2, gridpos)
	play_particle(Ef_WitchSpearHit2)	
	
	stop_particle(Ef_WSpearAura1)		
	stop_particle(Ef_WSpearAura2)		
	
	
	

	
	dot_change_anim(dotLucius,3)
	
	dot_play_particle_grid("Ef_C_Cmn_N_Hit_Sla01",11,8)
	dot_change_anim(dotMorgan1,6)
	
	dot_change_anim(dotLucius,0)
	dot_change_anim(dotMorgan1,1)
	
	show_image("101030520", 0.0, 0.0, STILL_SWITCH_TIME,true,false) --0.6秒
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)--0.6秒+0.5秒		
	
    fadein(0.7)
	wait_time(1.0)			
	
	--change_face(Morgan1,"Normal")
	open_simple_window("CHRNAME_MORGAN2", nil, nil)
	message("MA_01A111_460056")
	close_simple_window()
	
	--ブラックアウト
	fadeout(0,0,0,1.0, 0.5)
	wait_time(0.5)
	
	hide_image(STILL_SWITCH_TIME) 
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
	
	fadein(FADE_TIME)
	wait_time(FADE_TIME)

	wait_time(1.0)	
	
	on_active(Ef_BlackFeather_2)
	on_active(Ef_Change_Witch_2)

	local gridpos = get_grid_position(10, 8)
	set_pos(Ef_Change_Witch_2, gridpos)
	play_particle(Ef_Change_Witch_2)

	on_active(Ef_BlackFeather_3)	
	on_active(Ef_Change_Witch_3)

	local gridpos = get_grid_position(12, 8)
	set_pos(Ef_Change_Witch_3, gridpos)
	play_particle(Ef_Change_Witch_3)


	wait_time(0.5)

	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WitchSpear2)

	
	wait_time(1.3)
	
	dot_disp_unit(dotGliten,true)
	dot_disp_unit(dotMoronoe,true)


	set_pos(Ef_BlackFeather_2, gridpos)
	play_particle(Ef_BlackFeather_2)

	set_pos(Ef_BlackFeather_3, gridpos)
	play_particle(Ef_BlackFeather_3)
	
	wait_time(2.0)
	
	local gridpos = get_grid_position(10,8)
	
	set_pos(Ef_BlackFeather_2, gridpos)
	play_particle(Ef_BlackFeather_2)

	local gridpos = get_grid_position(12,8)
	
	set_pos(Ef_BlackFeather_3, gridpos)
	play_particle(Ef_BlackFeather_3)
	
	wait_time(1.0)	
	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01A111_460057")
	close_speech_window()

	
	change_face(Gliten,"Normal")
	open_speech_window("CHRNAME_SISTERS_3",nil, Gliten )
	message("MA_01A111_460058")
	close_speech_window()

	
	open_speech_window("CHRNAME_MORGAN2", Morgan1, nil)
	message("MA_01A111_460059")
	close_speech_window()

	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01A111_460060")
	close_speech_window()

	
	change_face(Gliten,"Normal")
	open_speech_window("CHRNAME_SISTERS_3",nil, Gliten )
	message("MA_01A111_460061")
	close_speech_window()
	
	
	
	
	
	change_face(Morgan1,"Normal")
	open_speech_window("CHRNAME_MORGAN2", Morgan1, nil)
	message("MA_01A111_460063")

	
	message("MA_01A111_460064")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_460065")
	close_speech_window()

	
	open_speech_window("CHRNAME_MORGAN2", Morgan1, nil)
	message("MA_01A111_460066")

	
	change_face(Morgan1,"Smile")
	message("MA_01A111_460067")
	close_speech_window()
	
	
	fadeout(0,0,0,1.0, 0.5)
	wait_time(0.5)
	
	
	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi3,false)
	dot_disp_unit(barbaroi4,false)
	dot_disp_unit(dotGliten,false)
	dot_disp_unit(dotLucius,false)
	dot_disp_unit(dotMorgan1,false)
	dot_disp_unit(dotMoronoe,false)
	wait_seq()
	wait_time(2.5)
	
	fadein(0.5)
	wait_time(0.5)
	
	move_camera(11,6, 1.0)
	wait_time(1.0)
	
	
	change_face(Guinevere1,"Sad")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_460069")
	close_speech_window()

	
	open_speech_window("CHRNAME_LUCIUS", nil, nil)
	message("MA_01A111_460071")

	
	message("MA_01A111_460072")
	close_speech_window()

	
	change_face(Guinevere1,"Pain")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_460074")
	close_speech_window()

	
	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, nil)
	message("MA_01A111_460075")

	
	message("MA_01A111_460076")
	close_speech_window()
	
	
	local gridpos3 = get_grid_position(12,6)
	set_pos(Ef_Killers_Cancel, gridpos3)
	on_active(Ef_Killers_Cancel)
	wait_time(0.5)
	dot_change_unit(dotGuinevere1, dotGuinevere, 0.3)
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_460078")
	close_speech_window()

	
	open_speech_window("CHRNAME_LUCIUS", nil, nil)
	message("MA_01A111_460079")
	close_speech_window()
	
	
	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_460080")
	close_speech_window()

	
	open_speech_window("CHRNAME_LUCIUS", nil, nil)
	message("MA_01A111_460081")

	
	message("MA_01A111_460083")

	
	change_face(Lucius,"Smile")
	message("MA_01A111_460084")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,10,6,0)
	pbadv_setup_101011_Guinevere_preload(1,true,12,6,0)
	pbadv_setup_101011_Guinevere_preload(0,true,13,6,0)
	pbadv_setup_101036_Viena_preload(1,true,13,5,0)
	pbadv_setup_101010_Lancelot_preload(0,true,12,5,0)
	pbadv_setup_101034_Excelia_preload(1,true,15,5,0)
	pbadv_setup_101035_Liliana_preload(1,true,9,5,0)
	pbadv_setup_101028_Galahad_preload(3,true,11,5,0)
	pbadv_setup_101054_Adam_preload(0,true,8,5,0)
	pbadv_setup_101053_Mathajim_preload(0,true,14,6,0)
	pbadv_setup_101044_Gliten_preload(true,10,8,0)
	pbadv_setup_101042_Moronoe_preload(true,12,8,0)
	pbadv_setup_101041_Morgan_preload(1,true,11,8,0)
	pbadv_setup_101051_Lucius_preload(0,true,11,10,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Cancel", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotCenter_526", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_526", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_image_preload("101030520", "content_still_10103052_image", "101030520_StillImage")
	preload_sound("BGM_ADV_Morgan")
	preload_sound("BGM_Battle_Tragedy_TragedyStart")
end
