

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201200000", "201200000")
	change_time_and_weather(1,1)
	
	
	
	pbadv_setup_101009_Noir(2,true,21,32,0)
	pbadv_setup_101011_Guinevere(1,true,23,32,0)
	pbadv_setup_101030_Elaine(3,true,22,32,0)
	pbadv_setup_101031_Lovein(1,true,22,33,0)
	pbadv_setup_101013_Gawain(0,true,13,34,0)
	pbadv_setup_101018_Ragnar(1,true,14,34,0)
	
	
	pbadv_setup_101052_Vernarth(0,true,21,30,0)
	pbadv_setup_101037_Rasia(2,true,23,30,0)
	pbadv_setup_101044_Gliten(true,22,29,0)

		
	
	
	setup_complete_unit()
	
	
	
	
	dot_unit_dir(dotVernarth, DotDir_Left)
	dot_unit_dir(dotRasia2, DotDir_Left)

	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(22,31, 0.0)
	Ef_blood = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Blood_Splash", false, true)
	Ef_blood2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Blood_Drop", false, true)

	load_image("10103038",  "content_still_10103038_image", "101030380_StillImage")

end





function Play()
	fadein(0)
	Play_start(true)


	
	change_face(Gliten,"Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A111_390002")
	
	
	message("MA_01A111_390003")
	close_speech_window()

	
	change_face(Rasia2,"Normal")
	open_speech_window("CHRNAME_RASIA2", nil, Rasia2)
	message("MA_01A111_390005")
	close_speech_window()

	
	change_face(Gliten,"Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A111_390007")

	
	change_face(Gliten,"Smile")
	message("MA_01A111_390009")
	close_speech_window()

	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia2)
	message("MA_01A111_390010")
	close_speech_window()

	
	change_face(Guinevere1,"Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_390011")
	close_speech_window()

	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia2)
	message("MA_01A111_390012")

	
	message("MA_01A111_390013")
	close_speech_window()

	
	change_face(Guinevere1,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_390014")
	close_speech_window()

	
	change_face(Rasia2,"Anger")
	open_speech_window("CHRNAME_RASIA2", nil, Rasia2)
	message("MA_01A111_390015")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_390017")
	close_speech_window()

	
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A111_390019")
	close_speech_window()
	
	
	dot_move_unit_seq(dotVernarth,21,31)
	wait_seq()
	
	
	dot_unit_dir(dotVernarth, DotDir_Down)
	dot_change_anim(dotVernarth,3)
	dot_play_particle_unit(dotVernarth,"Ef_C_Swd_N_Atk01",3,true)
	
	
	dot_unit_dir(dotNoir2, DotDir_Up)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	
	
	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01A111_390021")
	
	
	
	open_select_window_tag(Noir2,"Normal","MA_01A111_390023","MA_01A111_390024","MA_01A111_390025")
	close_speech_window()
	
	
	if is_select(1) then
	
		
		change_face(Noir2,"Anger")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_390027")
		close_speech_window()

		
		open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
		message("MA_01A111_390028")

		
		message("MA_01A111_390029")
		close_speech_window()
		
		elseif is_select(2) then
	
		
		change_face(Noir2,"Anger")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_390031")
		close_speech_window()

		
		open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
		message("MA_01A111_390032")
		
		
		message("MA_01A111_390033")
		close_speech_window()
		
		else
	
		
		change_face(Noir2,"Anger")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_390035")
		close_speech_window()

		
		open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
		message("MA_01A111_390036")
		
		
		message("MA_01A111_390037")
		close_speech_window()
		
	end
	

	
	dot_move_unit_seq(dotRasia2,23,31)
	wait_seq()
	dot_change_anim(dotRasia2,3)
	dot_play_particle_unit(dotRasia2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_play_particle_unit(dotGuinevere1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_damage_seq(dotGuinevere1, dotRasia2, true)
	wait_seq()
	dot_change_anim(dotRasia2,DotAnim_Idle)
	dot_change_anim(dotGuinevere1,DotAnim_Squat)
		
	
	change_face(Guinevere1,"Pain")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_390039")
	close_speech_window()
	wait_seq()
	
	
	dot_unit_dir(dotRasia2, DotDir_Left)
	dot_change_anim(dotRasia2,DotAnim_Idle)
	
	
	open_speech_window("CHRNAME_RASIA2", nil, Rasia2)
	message("MA_01A111_390041")
	
	
	message("MA_01A111_390042")

	
	message("MA_01A111_390043")
	close_speech_window()

	
	change_face(Guinevere1,"Sad")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_390044")
	close_speech_window()
	
	dot_change_anim(dotVernarth,0)
	wait_time(0.2)
	dot_change_anim(dotVernarth,3)
	dot_play_particle_unit(dotVernarth,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",1,true)
	dot_move_knockback(dotNoir2,21, 34,0.4,2)
	
	wait_time(0.6)
	dot_unit_dir(dotNoir2, DotDir_Right)
	dot_change_anim(dotNoir2,DotAnim_Idle)
	dot_change_anim(dotVernarth,0)
	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_390046")
	close_speech_window()

	dot_move_unit_seq(dotRasia2,23,30)
	dot_move_unit_seq(dotVernarth,23,31)
	wait_seq()
	
	change_face(Vernarth,"Anger")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01A111_390048")
	close_speech_window()
	
	
	
	change_face(Rasia2,"Surprise")
	open_speech_window("CHRNAME_RASIA2", nil, Rasia2)
	message("MA_01A111_390050")
	close_speech_window()
	
	fadeout(0,0,0,1.0, 0.2)
	wait_time(0.2)
	
	
	dot_change_anim(dotVernarth,3)
	dot_play_particle_unit(dotVernarth,"Ef_C_Swd_N_Atk01",3,true)
	
	
	dot_play_particle_unit(dotGuinevere1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	dot_unit_dir(dotVernarth, DotDir_Down)
	dot_change_anim(dotVernarth,3)
	dot_change_anim(dotElaine3,6)
	

	on_active(Ef_blood2)
	local gridpos = get_grid_position(39,16)
	set_pos(Ef_blood2, gridpos)
	play_particle(Ef_blood2)
	
	on_active(Ef_blood)
	local gridpos = get_grid_position(39,16)
	set_pos(Ef_blood, gridpos)
	play_particle(Ef_blood)
	
	
	show_image("10103038", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
	
	
	dot_place_unit(dotGuinevere1,24,33)
	dot_place_unit(dotElaine3,24,32)

	
	dot_unit_dir(dotElaine3, DotDir_Right)
	dot_change_anim(dotElaine3,DotAnim_Damage)
	
	dot_unit_dir(dotGuinevere1, DotDir_Left)
	dot_change_anim(dotGuinevere1,DotAnim_Squat)

	dot_unit_dir(dotVernarth, DotDir_Left)
	dot_change_anim(dotVernarth,DotAnim_Idle)
	
	fadein(1.2)
	wait_time(1.5)
	
	open_simple_window("CHRNAME_ELAINE", nil, nil)
	message("MA_01A111_390052")
	close_simple_window()
	
	
	
	dot_change_anim(dotGuinevere1,DotAnim_Squat)
	
	
	open_simple_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_390054")
	close_simple_window()

	
	open_simple_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_390056")
	close_simple_window()

	hide_image(STILL_SWITCH_TIME) 
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )

	dot_change_anim(dotElaine3,1)
	dot_reserve_move_unit_seq(dotLovein1,23,32)
	exec_parallel_seq()
	wait_seq()

	
	change_face(Lovein1,"Anger")
	open_speech_window("CHRNAME_LOVEIN2", Lovein1, nil)
	message("MA_01A111_390057")
	close_speech_window()

	
	change_face(Guinevere1,"Pain")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_390059")
	close_speech_window()

	
	change_face(Lovein1,"Sad")
	open_speech_window("CHRNAME_LOVEIN2", Lovein1, nil)
	message("MA_01A111_390060")
	close_speech_window()
	
	se_play("SE_ADV_MA_01A111_39_Gallahad_Roar")
	wait_time(2.0)
	
	dot_move_unit_seq(dotVernarth,22,31)
	wait_seq()
	dot_unit_dir(dotVernarth, DotDir_Left)
	dot_change_anim(dotVernarth,DotAnim_Idle)
	
	
	
	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01A111_390062")
	close_speech_window()
	
	
	
	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_390063")
	close_speech_window()
	
	move_camera(21,32, 0.5)
	
	dot_reserve_move_unit_seq(dotGawain,20,31)
	dot_reserve_move_unit_seq(dotRagnar1,19,32)
	exec_parallel_seq()
	wait_seq()
	
	
	change_face(Gawain,"Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A111_390065")
	close_speech_window()
	
	
	change_face(Ragnar1,"Anger")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar1, nil)
	message("MA_01A111_390066")
	close_speech_window()

	
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth)
	message("MA_01A111_390067")
	close_speech_window()

	
	change_face(Ragnar1,"Anger")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar1, nil)
	message("MA_01A111_390069")
	close_speech_window()

	
	change_face(Gawain,"Serious")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A111_390071")
	close_speech_window()

	
	change_face(Guinevere1,"Pain")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A111_390072")
	close_speech_window()

	
	change_face(Lovein1,"Sad")
	open_speech_window("CHRNAME_LOVEIN2", Lovein1, nil)
	message("MA_01A111_390073")

	
	message("MA_01A111_390074")
	close_speech_window()

	
	change_face(Ragnar1,"Anger")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar1, nil)
	message("MA_01A111_390075")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,21,32,0)
	pbadv_setup_101011_Guinevere_preload(1,true,23,32,0)
	pbadv_setup_101030_Elaine_preload(3,true,22,32,0)
	pbadv_setup_101031_Lovein_preload(1,true,22,33,0)
	pbadv_setup_101013_Gawain_preload(0,true,13,34,0)
	pbadv_setup_101018_Ragnar_preload(1,true,14,34,0)
	pbadv_setup_101052_Vernarth_preload(0,true,21,30,0)
	pbadv_setup_101037_Rasia_preload(2,true,23,30,0)
	pbadv_setup_101044_Gliten_preload(true,22,29,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Blood_Splash", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Blood_Drop", false, true)
	load_image_preload("10103038",  "content_still_10103038_image", "101030380_StillImage")
end
