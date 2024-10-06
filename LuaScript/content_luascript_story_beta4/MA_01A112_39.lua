

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)

	
	
	
	
	init_psbattleadv("201090100", "201090100")
	
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")


load_image("101010150", "content_still_10101015_image", "101010150_StillImage")

	

	
	pbadv_setup_101009_Noir(2,true,10,3,0)

	pbadv_setup_101011_Guinevere(1,true, 7, 3,0)  

	pbadv_setup_101013_Gawain(0,true, 11, 4,0)  
	pbadv_setup_101018_Ragnar(2,true, 10, 4,0)  
	pbadv_setup_101015_Arthur(0,true, 12, 3,0)  
	
	
	pbadv_setup_101020_Merlin(2,true,10,3,0) 
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	

	pbadv_setup_101020_Merlin(1,true, 1, 1,0)  

	pbadv_setup_101030_Elaine(1,true,10,2,0) 

	pbadv_setup_101031_Lovein(1,true, 11, 2,0)  
	

	
	pbadv_setup_101041_Morgan(1,true, 14, 3,0) 
	pbadv_setup_101042_Moronoe(true, 17, 2,0)  
	pbadv_setup_101044_Gliten(true, 17, 4,0) 


	
	
	
	setup_complete_unit()


	
	
	dot_change_anim(dotMerlin2,1)


	
	
	dot_disp_unit(dotGuinevere1, false)
	dot_disp_unit(dotGawain, false)
	dot_disp_unit(dotRagnar2, false)
	dot_disp_unit(dotMerlin1, false)
	dot_disp_unit(dotElaine1, false)
	dot_disp_unit(dotLovein1, false)
	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotNoir2, false)
	
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(12, 3, 0.0)
	
	
	
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem08", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem08", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	
	Ef_WarpIN = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIN2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpOut = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	
	Ef_warpW= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_warpW2= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	
	
	Ef_Spear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Surround_526", false, true)
	Ef_Spear2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Surround_526", false, true)
	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotCenter_526", false, true)
	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	
	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchChange = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_BlFeather2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_C_Killers_G=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)


	Ef_AuraArea = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area", false, true)

	on_active(Ef_AuraArea)

	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_AuraArea, gridpos)
	set_scale(Ef_AuraArea, {1.4, 1.4, 1.4})
	play_particle(Ef_AuraArea)

	load_sound("BGM_ADV_Revenge")

	movie_load("MA_01A112_39")


end

function Play()
	fadein(0)
	Play_start(true)





	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_390002")
	
	
	
	change_face(Morgan1, "Normal")
	
	message("MA_01A112_390004")
	close_speech_window()
	
	
	change_face(Merlin2, "Pain")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01A112_390006")
	close_speech_window()
	
	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_390007")
	close_speech_window()
	
	
	change_face(Morgan1, "Anger")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_390008")
	close_speech_window()
	
	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_390009")
	close_speech_window()
	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_390010")
	close_speech_window()
	
	
	change_face(Arthur, "Anger")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_390011")
	close_speech_window()
	
	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_390012")
	close_speech_window()
	
	on_active(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotArthur,1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem1)
	
	wait_time(1.0)
	
	on_active(Ef_Vibes)
	
	local gridpos = get_grid_position(12, 3)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)
	

	
	change_face(Arthur, "Anger")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_390014")
	close_speech_window()
	
	
	

	

	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_390016")
	close_speech_window()
	
	on_active(Ef_WitchSpear1) 
	on_active(Ef_WSpearAppea1) 
	local gridpos = get_grid_position(14, 3)
	gridpos[2] = 1.8 
	turn(Ef_WSpearAppea1, 45, 90, 0, 0.0)
	set_pos(Ef_WSpearAppea1, gridpos)
	play_particle(Ef_WSpearAppea1)

	wait_time(0.5)

	local gridpos = get_grid_position(14, 3)
	gridpos[2] = 1.8 
	turn(Ef_WitchSpear1, 45, 90, 0, 0.0)
	set_pos(Ef_WitchSpear1, gridpos)
	play_particle(Ef_WitchSpear1)

	wait_time(1.0)
	
	dot_change_anim(dotMorgan1,3)
	
	local gridpos = get_grid_position(12, 3)
	gridpos[2] = 0.3

	slidemove(Ef_WitchSpear1, gridpos, 0.2)

	
	wait_time(0.1)

	on_active(Ef_WitchSpearHit1) 
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)
	
	dot_change_anim(dotArthur,6)
	stop_particle(Ef_Vibes)

	wait_time(1.0)
	dot_change_anim(dotArthur,1)
	
	dot_change_anim(dotMorgan1,0)

	wait_time(0.5)
	



	local gridpos = get_grid_position(12, 3)
	gridpos[2] = 1.5
	
	slidemove(Ef_WitchSpear1, gridpos, 0.2)
	dot_move_height(dotArthur,1.2,0.4,0)
	
	wait_time(1.0)
	
	on_active(Ef_Spear1)
	
	
	local gridpos = get_grid_position(12, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_Spear1, gridpos)
	play_particle(Ef_Spear1)
	
	
	
	change_face(Merlin2, "Pain")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01A112_390018")
	close_speech_window()
	
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
	
	set_pos(Ef_WSpearAppea1, gridpos)
	play_particle(Ef_WSpearAppea1)
	
	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_Spear1)
	stop_particle(Ef_WitchSpear1)
	
	dot_disp_unit(dotNoir2, true)
	dot_move_unit_seq(dotNoir2,13, 3)
	wait_seq()
	dot_change_anim(dotNoir2,3)
	dot_damage_seq(dotMorgan1,dotNoir2,true)
	wait_time(0.5)
	dot_change_anim(dotArthur,1)
	wait_time(1.0)
	wait_seq()

	dot_move_height(dotArthur,0.0,0,0)
	
	
	
	hide_image(BLACK_WHITE_TIME)
	

	dot_change_anim(dotMorgan1,6)
	
	 wait_time(1.5)
	

	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotMorgan1,1)
	




	
	bgm_play("Stop_BGM_Bus_MidFade")
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_390020")
	close_speech_window()
		
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A112_390021")
	close_speech_window()
	
	dot_unit_dir(dotMorgan1, 1)
	
	

	        on_active(Ef_BlFeather)
        on_active(Ef_WitchChange)

        local gridpos = get_grid_position(17, 2)
        set_pos(Ef_BlFeather, gridpos)
        play_particle(Ef_BlFeather)

        local gridpos = get_grid_position(17, 2)
        set_pos(Ef_WitchChange, gridpos)
        play_particle(Ef_WitchChange)

        on_active(Ef_BlFeather2)
        on_active(Ef_WitchChange2)

        local gridpos = get_grid_position(17, 4)
        set_pos(Ef_BlFeather2, gridpos)
        play_particle(Ef_BlFeather2)

        local gridpos = get_grid_position(17, 4)
        set_pos(Ef_WitchChange2, gridpos)
        play_particle(Ef_WitchChange2)
	
	wait_time(1.0)
      
        dot_disp_unit(dotMoronoe, true)
		dot_disp_unit(dotGliten, true)

       wait_time(0.5)

	
	
	open_cutin(2, 1)
	
	on_cutin(1, Moronoe, "Smile", 1)
	on_cutin(2, Gliten, "Smile", 1)
	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1_3", nil, nil)
	message("MA_01A112_390023")
	close_speech_window()
	
	
		
	close_cutin()
	
	dot_disp_unit(dotGawain, true)
	dot_disp_unit(dotLovein1, true)
	
	dot_reserve_move_unit_seq(dotGliten,14,4)
	dot_reserve_move_unit_seq(dotMoronoe,14,2)
	
	
	dot_reserve_move_unit_seq(dotGawain,13,4)
	dot_reserve_move_unit_seq(dotLovein1,13,2)
	exec_parallel_seq()
	wait_seq()
	
	dot_change_anim(dotMoronoe,3)
	dot_play_particle_unit(dotMoronoe,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotGliten,3)
	dot_play_particle_unit(dotGliten,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotGawain,7)
	dot_play_particle_unit(dotMoronoe,"Ef_C_Cmn_Guard01",1,false)
	dot_change_anim(dotLovein1,7)
	dot_play_particle_unit(dotGliten,"Ef_C_Cmn_Guard01",1,false)
	wait_seq()
	dot_move_knockback(dotGliten,16, 4,0.4,2)
	dot_move_knockback(dotMoronoe,16, 2,0.4,2)
	
	wait_time(1.0)
	dot_change_anim(dotGliten,0)
	dot_change_anim(dotMoronoe,0)
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Gawain, "Serious", 1)
	on_cutin(2, Elaine1, "Anger", 1)
	
	
	


	
	change_face(Gawain, "Serious")
	open_speech_window("CHRNAME_GAWAIN_ELAINE", nil, nil)
	message("MA_01A112_390025")
	close_speech_window()
	
		
		
	close_cutin()
	
	
	dot_disp_unit(dotRagnar2, true)
	dot_disp_unit(dotElaine1, true)
	dot_reserve_move_unit_seq(dotRagnar2,15,4)
	dot_reserve_move_unit_seq(dotElaine1,15,2)
	exec_parallel_seq()
	wait_seq()
	dot_change_anim(dotRagnar2,3)
	dot_play_particle_unit(dotRagnar2,"Ef_C_Axe_N_Atk01",3,true)
	dot_play_particle_unit(dotGliten,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_change_anim(dotGliten,6)
	dot_change_anim(dotElaine1,3)
	dot_play_particle_unit(dotElaine1,"Ef_C_Spr_N_Atk01",3,true)
	dot_play_particle_unit(dotMoronoe,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_change_anim(dotMoronoe,6)
	wait_time(0.5)
	dot_change_anim(dotRagnar2,0)
	dot_change_anim(dotElaine1,0)
	dot_change_anim(dotGliten,1)
	dot_change_anim(dotMoronoe,1)
	
	move_camera(10, 3, 1.0)
	wait_time(1.0)
	
	bgm_play("BGM_ADV_Revenge")
	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01A112_390026")
	close_speech_window()
	
	
	
	on_active(Ef_WarpOut) 

	local gridpos = get_grid_position(10, 3) 
	set_pos(Ef_WarpOut, gridpos)
	play_particle(Ef_WarpOut)
	
	on_active(Ef_WarpOut2) 

	local gridpos = get_grid_position(12, 3) 
	set_pos(Ef_WarpOut2, gridpos)
	play_particle(Ef_WarpOut2)

	wait_time(0.3)
	
	dot_disp_unit(dotMerlin2, false)
	dot_disp_unit(dotArthur, false)
	
	move_camera(7, 3, 1.0)

	wait_time(1.0)
	wait_seq()
	
	on_active(Ef_WarpIN) 

	local gridpos = get_grid_position(6, 2) 
	set_pos(Ef_WarpIN, gridpos)
	play_particle(Ef_WarpIN)

	wait_time(0.5)
	dot_disp_unit(dotMerlin2, true)
	dot_unit_dir(dotMerlin2, 3)
	
	dot_place_unit(dotMerlin2,6, 2)
		
	on_active(Ef_WarpIN2) 

	local gridpos = get_grid_position(6, 4) 
	set_pos(Ef_WarpIN2, gridpos)
	play_particle(Ef_WarpIN2)

	wait_time(0.5)
	
	dot_disp_unit(dotArthur, true)
	dot_unit_dir(dotArthur, 3)
	dot_place_unit(dotArthur,6, 4)

	wait_time(1.0)
	
	dot_change_anim(dotMerlin2,0)
	dot_change_anim(dotArthur,1)
	wait_seq()
	
	
	
	


	
	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01A112_390028")
	
	
	change_face(Merlin2, "Normal")
	message("MA_01A112_390029")
	close_speech_window()
	
	

	change_face(Arthur, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_390030")
	close_speech_window()

	
	change_face(Merlin2, "Smile")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01A112_390032")
	
	
	change_face(Merlin2, "Normal")
	message("MA_01A112_390033")
	close_speech_window()
	
	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_390034")
	close_speech_window()
	
	
	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01A112_390035")
	close_speech_window()
	
	wait_time(1.0)
	
	
	dot_change_anim(dotArthur,0)
	on_active(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotArthur,1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	wait_time(1.0)

	on_active(Ef_Vibes)

	local gridpos = get_grid_position(6, 4)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	


	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_390037")
	close_speech_window()
	
	on_active(Ef_Emblem1)
	
	local locatorpos = dot_get_unit_locator(dotMerlin2,1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)
	
	wait_time(1.0)
	
	on_active(Ef_Killers)
	
	local gridpos = get_grid_position(6, 2)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	

	on_active(Ef_warpW2)
	local gridpos = get_grid_position(14,3)
	set_pos(Ef_warpW2, gridpos)
	set_scale(Ef_warpW2, {0.8, 0.8, 0.8})
	play_particle(Ef_warpW2)

	wait_time(1.0)

	dot_unit_dir(dotMorgan1, 2)
	dot_place_unit(dotMorgan1,10, 3)


	dot_change_anim(dotMorgan1,0)
	on_active(Ef_warpW)
	local gridpos = get_grid_position(10,3)
	set_pos(Ef_warpW, gridpos)
	set_scale(Ef_warpW, {0.8, 0.8, 0.8})
	play_particle(Ef_warpW)
	
	wait_time(1.0)
	
	dot_place_unit(dotMorgan1,10, 3)
	wait_seq()

	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_390039")
	close_speech_window()
	
	
	
	dot_disp_unit(dotGuinevere1, true)
	dot_reserve_move_unit_seq(dotMorgan1,9, 3)
	dot_reserve_move_unit_seq(dotGuinevere1,8, 3)
	exec_parallel_seq()
	wait_seq()
	dot_change_anim(dotMorgan1,3)
	dot_play_particle_unit(dotMorgan1,"Ef_C_Swd_N_Atk01",3,true)
	dot_play_particle_unit(dotGuinevere1,"Ef_C_Cmn_Guard01",1,false)
	
	wait_time(0.2)
	dot_change_anim(dotMorgan1,0)
	
	

	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A112_390041")
	close_speech_window()
	
	
	dot_change_anim(dotGuinevere1,3)
	dot_play_particle_unit(dotGuinevere1,"Ef_C_Swd_N_Atk01",3,true)
	dot_play_particle_unit(dotMorgan1,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	dot_change_anim(dotMorgan1,6)
	dot_move_knockback(dotMorgan1,11, 3,0.4,2)
	
	
	wait_time(0.2)
	dot_change_anim(dotGuinevere1,0)
	dot_change_anim(dotMorgan1,0)
	move_camera(6, 3, 1.0)
	wait_seq()
	dot_unit_dir(dotMorgan1, 2)
	move_camera(6, 3, 1.0)
	change_camera_distance(7.0, 3.0)
	wait_camera()

	off_active(Ef_warpW)	
	off_active(Ef_warpW2)	
	off_active(Ef_Killers)	
	off_active(Ef_Emblem1)	
	off_active(Ef_Emblem2)	
	off_active(Ef_WarpIN2)	
	off_active(Ef_WarpIN)	
	off_active(Ef_WarpOut)	
	off_active(Ef_WarpOut2)	
	off_active(Ef_Vibes)	
	off_active(Ef_Spear1)
	off_active(Ef_WitchSpear1) 
	off_active(Ef_WSpearAppea1) 
	off_active(Ef_WitchSpearHit1) 
	off_active(Ef_BlFeather)
	off_active(Ef_WitchChange)


	movie_set_active(true)
	movie_play()

	dot_change_unit(dotMerlin2, dotMerlin1, 0.0)


	movie_wait_playing()

	
	movie_stop()

	wait_time(MOVIE_AFTER)

	
	change_face(Elaine1, "Anger")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A112_390054")
	close_speech_window()
	
	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A112_390055")
	close_speech_window()
	

	
	change_face(Merlin1, "Anger")
	open_speech_window("CHRNAME_MERLIN2", Merlin1, nil)
	message("MA_01A112_390057")
	close_speech_window()
	




	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	pbadv_setup_101009_Noir_preload(2,true,10,3,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 7, 3,0)
	pbadv_setup_101013_Gawain_preload(0,true, 11, 4,0)
	pbadv_setup_101018_Ragnar_preload(2,true, 10, 4,0)
	pbadv_setup_101015_Arthur_preload(0,true, 12, 3,0)
	pbadv_setup_101020_Merlin_preload(2,true,10,3,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	pbadv_setup_101020_Merlin_preload(1,true, 1, 1,0)
	pbadv_setup_101030_Elaine_preload(1,true,10,2,0)
	pbadv_setup_101031_Lovein_preload(1,true, 11, 2,0)
	pbadv_setup_101041_Morgan_preload(1,true, 14, 3,0)
	pbadv_setup_101042_Moronoe_preload(true, 17, 2,0)
	pbadv_setup_101044_Gliten_preload(true, 17, 4,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem08", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem08", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Surround_526", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Surround_526", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotCenter_526", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area", false, true)
	preload_sound("BGM_ADV_Revenge")
	movie_load_preload("MA_01A112_39")
end
