

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	load_image("10104019", "content_still_10104019_image", "101040190_StillImage")
	load_image("10104027",  "content_still_10104027_image", "101040270_StillImage")
	
	
	
	
	init_psbattleadv("201200000", "201200000")
	change_time_and_weather(1,1) 
	
	
	
	    
    pbadv_setup_101026_Percival(0,true,9,9,0)
    
        
    pbadv_setup_101027_Dindrane(1,true,8,9,0)

	
    pbadv_setup_101010_Lancelot(0,true,8,8,0)
    
    
    pbadv_setup_101011_Guinevere(0,true,8,10,0)
    
    
	pbadv_setup_101018_Ragnar(1,true,13,10,0)
	
	
	pbadv_setup_101015_Arthur(2,true,12,9,0)
	
	
	pbadv_setup_101013_Gawain(1,true,13,8,0)
	
	
	pbadv_setup_101041_Morgan(1,true,30,10,0)
	pbadv_setup_101041_Morgan(4,true,1,1,0)
	
	
	
	setup_complete_unit()
	
	

	
	dot_unit_dir(dotArthur2, 2)
	dot_unit_dir(dotRagnar1, 2)
	dot_unit_dir(dotGawain1, 2)
	dot_unit_dir(dotMorgan1, 2)

	

	
	dot_disp_weapon(dotPercival, false)
	dot_disp_weapon(dotDindrane1, false)
	dot_disp_weapon(dotLancelot, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotRagnar1, false)
	dot_disp_weapon(dotArthur2, false)
	dot_disp_weapon(dotGawain1, false)
	dot_disp_weapon(dotMorgan4, false)

	
	
	dot_disp_unit(dotMorgan1, false)
	dot_disp_unit(dotMorgan4, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(10, 11, 0.0)
	
	
	Ef_WitchPortal= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	
	Ef_WitchDie= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	Ef_blood = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Blood_Splash", false, true)
	Ef_blood2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Blood_Drop", false, true)
	
	Ef_blood = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Blood_Splash", false, true)
	Ef_blood2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Blood_Drop", false, true)
	Ef_KillersDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true) 
	
end





function Play()
	fadein(0)
	Play_start(true)


	

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01C112_150002")
	close_speech_window()

	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150004")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_150005")
	close_speech_window()

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	message("MA_01C112_150006")
	

	
	change_face(Percival, "Anger")
	
	message("MA_01C112_150007")
	close_speech_window()

	
	change_face(Gawain1, "Anger")
	open_speech_window("CHRNAME_GAWAIN",nil , Gawain1)
	message("MA_01C112_150008")
	close_speech_window()

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	message("MA_01C112_150009")
	close_speech_window()

	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere, nil)
	message("MA_01C112_150011")
	close_speech_window()
	
	wait_time(1.0)
	

	
	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01C112_150013")
	close_speech_window()

	
	change_face(Ragnar1, "Sad")
	open_speech_window("CHRNAME_RAGNAR2",nil, Ragnar1)
	message("MA_01C112_150014")
	

	
	change_face(Ragnar1, "Sad")
	
	message("MA_01C112_150015")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150016")
	

	
	change_face(Arthur2, "Sad")
	
	message("MA_01C112_150017")
	

	
	change_face(Arthur2, "Sad")
	
	message("MA_01C112_150018")
	

	
	
	
	
	change_face(Arthur2, "Anger")
	
	message("MA_01C112_150020")
	close_speech_window()

	
	change_face(Lancelot, "Anger")
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01C112_150021")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150022")
	close_speech_window()

	
	
	
	
	dot_disp_weapon(dotRagnar1, true)
	dot_change_anim(dotPercival,12)
	dot_disp_weapon(dotArthur2, true)
	
	dot_disp_weapon(dotPercival, true)
	dot_disp_weapon(dotDindrane1, true)
	
	
	dot_change_anim(dotGuinevere,12)
	dot_change_anim(dotLancelot,12)
	
	
	
	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	message("MA_01C112_150024")
	close_speech_window()

	
	change_face(Lancelot, "Anger")
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01C112_150025")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150026")
	close_speech_window()

	
	change_face(Lancelot, "Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01C112_150027")
	close_speech_window()

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01C112_150028")
	

	
	change_face(Percival, "Sad")
	
	message("MA_01C112_150029")
	

	
	change_face(Percival, "Sad")
	
	message("MA_01C112_150030")
	

	
	change_face(Percival, "Serious")
	
	message("MA_01C112_150031")
	close_speech_window()
	
	
	
	dot_move_unit_seq(dotPercival,11, 9)
	wait_seq()
	dot_change_anim(dotPercival,3)
	dot_play_particle_unit(dotPercival,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(dotArthur2)
	
	wait_seq()
	wait_time(0.5)
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotPercival,6)
	dot_play_particle_unit(dotPercival,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_move_knockback(dotPercival,10, 9,0.4,2)
	wait_seq()
	wait_time(0.4)
	dot_change_anim(dotPercival,1)
	dot_change_anim(dotArthur2,0)

	
	
	
	
	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01C112_150033")
	close_speech_window()
	
	
	
	
	change_face(Percival, "Pain")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	message("MA_01C112_150035")
	close_speech_window()
	
	dot_change_anim(dotPercival,0)
	

	
	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150037")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_150038")
	close_speech_window()

	
	dot_move_unit_seq(dotDindrane1,11, 9)
	
	
	
	change_face(Dindrane1, "Anger")
	open_speech_window("CHRNAME_DINDRANE2",Dindrane1 , nil)
	message("MA_01C112_150040")
	close_speech_window()

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	dot_damage_seq(dotDindrane1,dotArthur2,true)
	wait_seq()
	dot_change_anim(dotArthur2,0)
	
	
	
	
	change_face(Dindrane1, "Pain")
	open_speech_window("CHRNAME_DINDRANE2",Dindrane1 , nil)
	message("MA_01C112_150042")
	close_speech_window()
	
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	dot_damage_seq(dotDindrane1,dotArthur2,true)
	
	dot_change_anim(dotDindrane1,6)
	dot_move_knockback(dotDindrane1,9, 6,0.9,2)
	wait_time(0.9)
	dot_change_anim(dotDindrane1,1)
	
	move_camera(10, 11, 1.0)

	
	
	change_face(Percival, "Serious")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	message("MA_01C112_150044")
	close_speech_window()
	
	dot_move_unit_seq(dotArthur2,11, 9)
	move_camera(10, 11, 1.0)
	wait_seq()
	wait_time(0.2)
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotPercival,6)
	dot_play_particle_unit(dotPercival,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(dotArthur2,0)
	wait_time(0.2)
	dot_change_anim(dotPercival,1)

	
	
	change_face(Percival, "Pain")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	message("MA_01C112_150046")
	close_speech_window()
	

	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150048")
	close_speech_window()
	
	
	change_face(Percival, "Pain")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	message("MA_01C112_150050")
	close_speech_window()
	
	fadeout(0,0,0,0,1.0)
	wait_time(1.0)
	
	
	dot_place_unit(dotArthur2,12,9)
	dot_place_unit(dotGawain1,11,9)
	dot_disp_weapon(dotGawain1, true)
	dot_play_particle_unit(dotGawain1,"Ef_C_Ham_N_Atk01",3,true)
	wait_time(0.4)
	
	
	
	wait_time(1.8)
	
	fadein(1.0)
	wait_time(1.0)
	
	wait_seq()

	
	
	change_face(Lancelot, "Anger")
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01C112_150052")
	close_speech_window()

	

	
	change_face(Ragnar1, "Sad")
	open_speech_window("CHRNAME_RAGNAR2",nil,  Ragnar1)
	message("MA_01C112_150053")
	close_speech_window()
	

	
	
	change_face(Gawain1, "Serious")
	open_speech_window("CHRNAME_GAWAIN",nil , Gawain1)
	message("MA_01C112_150055")
	close_speech_window()
	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150056")
	close_speech_window()

	
	change_face(Gawain1, "Sad")
	open_speech_window("CHRNAME_GAWAIN",nil , Gawain1)
	message("MA_01C112_150057")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150058")
	close_speech_window()

	
	change_face(Percival, "Pain")
	open_speech_window("CHRNAME_PERCIVAL",Percival , nil)
	message("MA_01C112_150059")
	close_speech_window()
	
	
	dot_move_unit_seq(dotArthur2,12, 10)
	wait_seq()
	dot_move_unit_seq(dotArthur2,10, 10)
	wait_time(1.0)
	wait_seq()
	dot_unit_dir(dotArthur2, 0)
	
	
	show_image("10104019", 0.0, 0.0, 0.0, true, false)

fadein(FADE_TIME+1.6)
wait_time(FADE_TIME)
	
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	dot_play_particle_unit(dotPercival,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_disp_unit(dotMorgan4, false)
	dot_remove_unit(dotPercival)
	
	wait_time(0.9)
	
	on_active(Ef_blood2)
	local gridpos = get_grid_position(19,16)
	set_pos(Ef_blood2, gridpos)
	play_particle(Ef_blood2)
	
	on_active(Ef_blood)
	local gridpos = get_grid_position(19,16)
	set_pos(Ef_blood, gridpos)
	play_particle(Ef_blood)
	
	wait_time(0.9)
	
	se_play("SE_ADV_MA_01104_25_Fall")
		
	wait_time(3.2)


hide_image(STILL_SWITCH_TIME) 
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )

	on_active(Ef_KillersDie) 

	local gridpos = get_grid_position(9, 6)
	set_pos(Ef_KillersDie, gridpos)
	play_particle(Ef_KillersDie)

	


	dot_unit_dir(dotArthur2, 3)
	dot_change_anim(dotArthur2,0)

	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150061")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_150062")
	
	
	dot_unit_dir(dotArthur2, 3)

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_150063")
	close_speech_window()
	
	dot_place_unit(dotMorgan1,12, 10)
	on_active(Ef_WitchPortal) 

    local gridpos = get_grid_position(12, 10) 
    set_pos(Ef_WitchPortal, gridpos)
    set_scale(Ef_WitchPortal, {0.8, 0.8, 0.8}) 
    play_particle(Ef_WitchPortal)

    wait_time(0.5)
        
    dot_disp_unit(dotMorgan1, true) 

    wait_time(2.0)
    wait_seq()

	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN",nil, Morgan1)
	message("MA_01C112_150065")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01C112_150066")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01C112_150067")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150068")
	

	
	change_face(Arthur2, "Normal")
	
	message("MA_01C112_150069")
	close_speech_window()

	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN",nil , Morgan1)
	message("MA_01C112_150070")
	

	
	change_face(Morgan1, "Normal")
	
	message("MA_01C112_150071")
	close_speech_window()

	
	
	
	
	
	dot_move_unit_seq(dotMorgan1,11, 10)
	wait_time(1.0)
	wait_seq()
	--ブラックアウト
	fadeout(0,0,0,1.0, 0.6)
	wait_time(0.6)
	
	wait_time(0.5)
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotMorgan1,6)
	dot_play_particle_unit(dotMorgan1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
    wait_time(0.2)
    
    --スチル表示
    show_image("10104027", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
    
    fadein(0.7)
	wait_time(0.7)
    
    
    
	dot_change_anim(dotMorgan1,1)
	dot_change_anim(dotArthur2,0)
	
	
	
	open_simple_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150073")
	message("MA_01C112_150074")
	close_simple_window()

	
	
	open_simple_window("CHRNAME_MORGAN",nil , Morgan1)
	message("MA_01C112_150075")
	message("MA_01C112_150076")
	close_simple_window()
	
	--ブラックアウト
	fadeout(0,0,0,1.0, 0.5)
	wait_time(0.5)
	
	hide_image(STILL_SWITCH_TIME) 
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
	
	fadein(FADE_TIME)
	wait_time(FADE_TIME)
	
	
	on_active(Ef_WitchDie) 

	local gridpos = get_grid_position(11, 10)
	set_pos(Ef_WitchDie, gridpos)
	play_particle(Ef_WitchDie)

	wait_time(1.0)
	
	dot_disp_unit(dotMorgan1, false)
	

	wait_time(2.0)

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01C112_150077")
	close_speech_window()

	
	change_face(Lancelot, "Serious")
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01C112_150078")
	close_speech_window()
	
	dot_unit_dir(dotArthur2, 2)

	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C112_150080")
	close_speech_window()

	


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10104019", "content_still_10104019_image", "101040190_StillImage")
	load_image_preload("10104027",  "content_still_10104027_image", "101040270_StillImage")
    pbadv_setup_101026_Percival_preload(0,true,9,9,0)
    pbadv_setup_101027_Dindrane_preload(1,true,8,9,0)
    pbadv_setup_101010_Lancelot_preload(0,true,8,8,0)
    pbadv_setup_101011_Guinevere_preload(0,true,8,10,0)
	pbadv_setup_101018_Ragnar_preload(1,true,13,10,0)
	pbadv_setup_101015_Arthur_preload(2,true,12,9,0)
	pbadv_setup_101013_Gawain_preload(1,true,13,8,0)
	pbadv_setup_101041_Morgan_preload(1,true,30,10,0)
	pbadv_setup_101041_Morgan_preload(4,true,1,1,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Blood_Splash", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Blood_Drop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Blood_Splash", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Blood_Drop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
end
