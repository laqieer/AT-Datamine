

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201080100", "201080100")
	
	load_image("10301008", "content_still_10301008_image", "103010080_StillImage")
	
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101009_Noir(2,true,9,4,0)
	pbadv_setup_101001_Tyrfing(1,true,9,5,0)
	pbadv_setup_101011_Guinevere(0,true,10,3,0)
	pbadv_setup_101016_Gwenhwymawr(1,true,10,2,0)
	pbadv_setup_101013_Gawain(0,true,9,1,0)
	pbadv_setup_101018_Ragnar(2,true,9,0,0)
	pbadv_setup_101057_Leodgrains(1,true,14,3,0)
	pbadv_setup_101042_Moronoe(true,14,2,0)
	
	
	
	
	
	barbaroi1 = dot_reserve_enemy(42, 13,4, 0)
	barbaroi2 = dot_reserve_enemy(49, 14,4, 0)
	barbaroi3 = dot_reserve_enemy(42, 13,1, 0)
	barbaroi4 = dot_reserve_enemy(600, 14,1, 0)
	
	gridposEf_bar_1 = get_grid_position(13,4)
	gridposEf_bar_2 = get_grid_position(14,4)
	gridposEf_bar_3 = get_grid_position(13,1)
	gridposEf_bar_4 = get_grid_position(14,1)

	
	reserve_particle("Ef_C_Cmn_EmyPortal_01")
	
	setup_complete_unit()
	
	
	dot_unit_dir(barbaroi1, 2)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 2)
	dot_unit_dir(barbaroi4, 2)
	

	
	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi3,false)
	dot_disp_unit(barbaroi4,false)
	
	dot_disp_weapon(dotGwenhwymawr1,false)
	dot_disp_weapon(dotGuinevere,false)
	
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(12,3, 0.0)
	
	Ef_1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true) 
	Ef_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true) 
	
	
	dot_unit_dir(dotLeodgrains1, DotDir_Left)
	
	
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_tink2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	Ef_Aura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)
	Ef_bar_scale = {0.8,0.8,0.8}
	
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	



	
	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01105_360002")
	close_speech_window()

	
	change_face(Leodgrains1,"Anger")
	open_speech_window("CHRNAME_LEODEGRAINS", nil, Leodgrains1)
	message("MA_01105_360003")
	close_speech_window()
	
	
		
	local gridpos1 = get_grid_position(14, 3)
	set_pos(Ef_1, gridpos1)
	on_active(Ef_1)
	wait_time(1.0)
	
	
	on_active(Ef_bar3) 
	set_pos(Ef_bar3, gridposEf_bar_3)
	set_scale(Ef_bar3, Ef_bar_scale)
	play_particle(Ef_bar3)
	wait_time(0.5)
	dot_disp_unit(barbaroi3,true)
	wait_time(0.5)
	
	on_active(Ef_bar4) 
	set_pos(Ef_bar4, gridposEf_bar_4)
	set_scale(Ef_bar4, Ef_bar_scale)
	play_particle(Ef_bar4)
	wait_time(0.5)
	dot_disp_unit(barbaroi4,true)
	wait_time(0.5)
	
	on_active(Ef_bar1) 
	set_pos(Ef_bar1, gridposEf_bar_1)
	set_scale(Ef_bar1, Ef_bar_scale)
	play_particle(Ef_bar1)
	wait_time(0.5)
	dot_disp_unit(barbaroi1,true)
	wait_time(0.5)
	
	on_active(Ef_bar2) 
	set_pos(Ef_bar2, gridposEf_bar_2)
	set_scale(Ef_bar2, Ef_bar_scale)
	play_particle(Ef_bar2)
	wait_time(0.5)
	dot_disp_unit(barbaroi2,true)
	wait_time(0.5)
	
	
	
	dot_unit_dir(dotGuinevere, DotDir_Right)
	dot_change_anim(dotGuinevere,DotAnim_Squat)
	wait_time(0.5)
	
	
	dot_move_unit_seq(dotGwenhwymawr1, 11, 3)
	wait_seq()
	dot_unit_dir(dotGwenhwymawr1, DotDir_Right)
	
	dot_disp_weapon(dotGwenhwymawr1,true)
	
	wait_seq()
	
	
	change_face(Guinevere,"Pain")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360005")
	close_speech_window()
	wait_seq()

	
	change_face(Gwenhwymawr1,"Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01105_360006")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360007")

	
	message("MA_01105_360009")
	close_speech_window()

	
	change_face(Leodgrains1,"Anger")
	open_speech_window("CHRNAME_LEODEGRAINS", nil, Leodgrains1)
	message("MA_01105_360010")
	close_speech_window()

	
	change_face(Moronoe,"Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01105_360011")
	close_speech_window()

	
	change_face(Gawain,"Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01105_360013")
	close_speech_window()

	
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01105_360014")

	
	message("MA_01105_360015")
	close_speech_window()

	
	change_face(Ragnar2,"Anger")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar2, nil)
	message("MA_01105_360017")
	close_speech_window()
	
	
	move_camera(11,3, 1.0)
	
	dot_move_unit_seq(dotTyrfing1, 9, 3)
	wait_seq()
	dot_unit_dir(dotTyrfing1, DotDir_Right )
	
	wait_camera()
	
	
	change_face(Tyrfing1,"Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01105_360019")
	close_speech_window()

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360020")
	close_speech_window()

	
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01105_360021")
	close_speech_window()

	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_360022")
	close_speech_window()

	
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01105_360023")
	close_speech_window()

	
	change_face(Guinevere,"Pain")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360024")

	
	message("MA_01105_360025")
	close_speech_window()
	
	
	
	
	dot_move_unit_seq(dotLeodgrains1, 13, 3)
	wait_seq()
	wait_time(0.5)
	
	dot_reserve_move_unit_seq(barbaroi1,12,4)
	dot_reserve_move_unit_seq(barbaroi2,13,4)
	dot_reserve_move_unit_seq(barbaroi3,12,1)
	dot_reserve_move_unit_seq(barbaroi4,13,1)
	exec_parallel_seq()
	
	wait_seq()
	
	
	change_face(Tyrfing1,"Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01105_360027")

	
	message("MA_01105_360028")

	
	message("MA_01105_360029")
	close_speech_window()

	
	change_face(Guinevere,"Pain")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360030")
	close_speech_window()
	
	
	dot_move_unit_seq(dotLeodgrains1, 12, 3)
	wait_seq()
	wait_time(0.6)
	dot_change_anim(dotLeodgrains1,3)
	dot_play_particle_unit(dotLeodgrains1,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.4)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_change_anim(dotGwenhwymawr1,6)
	dot_move_knockback(dotGwenhwymawr1,11, 5,0.4,2)
	
	dot_unit_dir(dotLeodgrains1,DotDir_Left)
	dot_change_anim(dotLeodgrains1,0)
	wait_seq()
	wait_time(0.5)
	dot_unit_dir(dotGwenhwymawr1, DotDir_Right)
	dot_change_anim(dotGwenhwymawr1,DotAnim_Squat)
	
	
	
	change_face(Gwenhwymawr1,"Pain")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01105_360032")
	close_speech_window()
	wait_seq()
	dot_change_anim(dotGwenhwymawr1,DotAnim_Down)
	wait_time(0.5)

	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360033")
	close_speech_window()

	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01105_360035")

	
	change_face(Moronoe,"Smile")
	message("MA_01105_360036")
	close_speech_window()

	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360037")
	close_speech_window()
	
	
	dot_move_unit_seq(dotNoir2, 11,2)
	wait_seq()
	dot_unit_dir(dotNoir2, DotDir_Right)
	
	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_360038")
	
	dot_move_unit_seq(dotLeodgrains1, 12, 2)
	wait_seq()
	dot_unit_dir(dotLeodgrains1,DotDir_Left)
	dot_change_anim(dotLeodgrains1,0)
	
	
	message("MA_01105_360040")
	close_speech_window()

	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360042")
	close_speech_window()
	
	se_play("SE_ADV_MA_01105_36_jewelry")
	wait_time(1.0)
	
	on_active(Ef_tink2)
	
	local gridpos = get_grid_position(11, 3)
	set_pos(Ef_tink2, gridpos)
	set_scale(Ef_tink2, {0.2, 0.2, 0.2})
	play_particle(Ef_tink2)
	wait_time(1.0)
	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360044")
	close_speech_window()

	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_360045")

	
	message("MA_01105_360046")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360047")
	close_speech_window()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301008", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)


	
	open_simple_window("CHRNAME_GUINEVERE")
	message("MA_01105_360049")

	
	message("MA_01105_360050")
	close_simple_window()

	
	change_face(Guinevere,"Sad")
	open_mind_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360051")
	close_mind_window()

	
	open_simple_window("CHRNAME_GUINEVERE")
	message("MA_01105_360052")
	close_simple_window()

	
	open_mind_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360053")
	close_mind_window()

	
	open_simple_window("CHRNAME_GUINEVERE")
	message("MA_01105_360055")
	close_simple_window()


	open_simple_window("CHRNAME_NOIR")
	message("MA_01105_360056")
	close_simple_window()

	
	change_face(Guinevere,"Normal")
	open_mind_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360057")
	close_mind_window()

	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	wait_time(1.0)
	
	
	on_active(Ef_2)
	local locatorpos = dot_get_unit_locator(dotGuinevere,1)
	set_pos(Ef_2, locatorpos)

	
	dot_unit_dir(dotGuinevere, DotDir_Right)
	dot_change_anim(dotGuinevere,DotAnim_Idle)
	wait_time(1.0)
	
	wait_seq()
	
	
	change_face(Gwenhwymawr1,"Pain")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01105_360059")
	close_speech_window()

	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01105_360060")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360061")
	close_speech_window()

	
	change_face(Leodgrains1,"Anger")
	open_speech_window("CHRNAME_LEODEGRAINS", nil, Leodgrains1)
	message("MA_01105_360062")
	close_speech_window()
	
	
	dot_move_unit_seq(dotLeodgrains1, 12, 3)
	wait_seq()
	dot_unit_dir(dotLeodgrains1, DotDir_Left)
	
	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360064")

	
	message("MA_01105_360065")
	close_speech_window()

	
	change_face(Leodgrains1,"Anger")
	open_speech_window("CHRNAME_LEODEGRAINS", nil, Leodgrains1)
	message("MA_01105_360066")
	close_speech_window()

	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360067")

	
	message("MA_01105_360068")
	
	on_active(Ef_Aura2 )
	local gridpos = get_grid_position(10,3)
	set_pos(Ef_Aura2 , gridpos)
	play_particle(Ef_Aura2 )
	wait_time(1.0)

	
	message("MA_01105_360069")
	close_speech_window()
	
	

	
	change_face(Leodgrains1,"Anger")
	open_speech_window("CHRNAME_LEODEGRAINS", nil, Leodgrains1)
	message("MA_01105_360070")
	close_speech_window()

	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360071")
	close_speech_window()
	
	
	open_cutin(1, 1)
	
	on_cutin(1, Guinevere, "Anger", 1)
	

	
	
	
	open_speech_window("CHRNAME_GUINEVERE", nil, nil)
	message("MA_01105_360072")
	close_speech_window()
	
	

	
	close_cutin()
	wait_time(0.5)
	
	
	dot_move_unit_seq(dotGwenhwymawr1, 11, 4)
	wait_seq()
	dot_unit_dir(dotGwenhwymawr1, 3)
	dot_change_anim(dotGwenhwymawr1,3)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Spr_N_Atk01",3,true)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Str01",3,true)
	wait_time(0.2)
	dot_change_anim(barbaroi1,6)
	dot_change_anim(barbaroi2,6)
	wait_time(0.2)
	dot_dying_unit_seq(barbaroi1)
	dot_dying_unit_seq(barbaroi2)
	wait_seq()
	
	
	move_camera(11, 3, 0.0)
	dot_move_unit_seq(dotGwenhwymawr1, 11, 3)
	wait_seq()
	
	
	change_face(Gwenhwymawr1,"Anger")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01105_360074")
	close_speech_window()
	
	
	move_camera(10,3, 1.0)
	wait_time(2.0)
	
	wait_seq()
	
	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360075")

	
	change_face(Guinevere,"Anger")
	message("MA_01105_360076")

	
	change_face(Guinevere,"Normal")
	message("MA_01105_360078")
	
	
	open_select_window_tag(Noir2,"Normal","MA_01105_360079","MA_01105_360080")
	close_speech_window()
	
	if is_select(1) then
	
		
		
		change_face(Noir2,"Normal")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01105_360082")
		close_speech_window()

		
		change_face(Guinevere,"Sad")
		open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
		message("MA_01105_360084")

		
		change_face(Guinevere,"Normal")
		message("MA_01105_360085")
		close_speech_window()
		
	elseif is_select(2) then
	
		
	
		change_face(Noir2,"Smile")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01105_360087")
		close_speech_window()

		
		change_face(Guinevere,"Shy")
		open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
		message("MA_01105_360088")

		
		change_face(Guinevere,"Smile")
		message("MA_01105_360089")
		close_speech_window()
	end
	
	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_360091")
	close_speech_window()
	
	dot_move_unit_seq(dotTyrfing1, 10,2)
	wait_seq()
	dot_move_unit_seq(dotTyrfing1, 10,1)
	dot_move_unit_seq(dotTyrfing1, 11,1)
	wait_seq()

	
	change_face(Tyrfing1,"Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01105_360093")
	close_speech_window()

	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360094")

	
	message("MA_01105_360095")
	close_speech_window()

	
	change_face(Tyrfing1,"Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01105_360096")
	close_speech_window()

	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360097")
	close_speech_window()
	
	dot_unit_dir(dotTyrfing1, 3)
	dot_change_anim(dotTyrfing1,3)
	dot_play_particle_unit(dotTyrfing1,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.4)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_change_anim(barbaroi3,6)
	dot_change_anim(barbaroi4,6)
	wait_time(0.2)
	dot_dying_unit_seq(barbaroi3)
	dot_dying_unit_seq(barbaroi4)
	wait_seq()
	
	dot_change_anim(dotTyrfing1,0)
	
	move_camera(10,3, 1.0)
	wait_camera()
	
	
	change_face(Tyrfing1,"Smile")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01105_360099")
	close_speech_window()
	
	
	
	
	
	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_360101")
	close_speech_window()
	
	
	
	dot_disp_weapon(dotNoir2,true)
	dot_disp_weapon(dotTyrfing1,true)
	dot_disp_weapon(dotGuinevere,true)
	
	
	open_cutin(1, 1)
	
	on_cutin(1, Guinevere, "Anger", 1)
	
	
	
	open_speech_window("CHRNAME_GUINEVERE", nil, nil)
	message("MA_01105_360103")
	close_speech_window()
	
	

	
	close_cutin()
	wait_time(0.5)
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10301008", "content_still_10301008_image", "103010080_StillImage")
	pbadv_setup_101009_Noir_preload(2,true,9,4,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,9,5,0)
	pbadv_setup_101011_Guinevere_preload(0,true,10,3,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,10,2,0)
	pbadv_setup_101013_Gawain_preload(0,true,9,1,0)
	pbadv_setup_101018_Ragnar_preload(2,true,9,0,0)
	pbadv_setup_101057_Leodgrains_preload(1,true,14,3,0)
	pbadv_setup_101042_Moronoe_preload(true,14,2,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)
	Ef_bar_scale = {0.8,0.8,0.8}
end
