
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	
	
	load_image("10104020", "content_still_10104020_image", "101040200_StillImage")
	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	

	
	
	
	init_psbattleadv("201150000", "201150000")
	
	change_time_and_weather(2,1)
	
	
    pbadv_setup_101009_Noir(2,true,20,22,0)
    
    pbadv_setup_101016_Gwenhwymawr(1,true,19,11,0)
    
    
    pbadv_setup_101011_Guinevere(0,true,20,11,0)
    
    
    pbadv_setup_101010_Lancelot(3,true,21,11,0)
    
    
    pbadv_setup_101012_Dinatan(1,true,1,0,0)
    pbadv_setup_101012_Dinatan(0,true,19,20,0)
    
    
    
    pbadv_setup_101024_Bors(0,true,19,12,0)
    
    
    pbadv_setup_101025_Clare(1,true,21,12,0)
    
    
	pbadv_setup_101015_Arthur(2,true,20,20,0)
	
	
	pbadv_setup_101013_Gawain(1,true,1,1,0)
	
	
	pbadv_setup_101018_Ragnar(1,true,1,2,0)
	

	
	
	barbaroi    = dot_reserve_enemy(1, 14, 10, 0)
	barbaroi2   = dot_reserve_enemy(1, 29, 13, 0)
	barbaroi3   = dot_reserve_enemy(1, 15, 17, 0)
	barbaroi4m  = dot_reserve_enemy(1, 19, 17, 0)
	barbaroi5m  = dot_reserve_enemy(1, 21, 17, 0)
	barbaroi6m  = dot_reserve_enemy(1, 23, 22, 0)
	barbaroi7m  = dot_reserve_enemy(1, 19, 25, 0)
	barbaroi8m  = dot_reserve_enemy(1, 21, 25, 0)
	barbaroi9m  = dot_reserve_enemy(1, 20, 26, 0)
	barbaroi10  = dot_reserve_enemy(1, 19, 27, 0)
	barbaroi11  = dot_reserve_enemy(1, 21, 27, 0)
	
	
	barbaroi    = dot_reserve_enemy(1, 17, 22, 0)
	barbaroi    = dot_reserve_enemy(1, 15, 21, 0)
	barbaroi    = dot_reserve_enemy(1, 25, 21, 0)
	barbaroi    = dot_reserve_enemy(1, 24, 19, 0)
	barbaroi    = dot_reserve_enemy(1, 18, 24, 0)
	barbaroi    = dot_reserve_enemy(1, 16, 24, 0)
	barbaroi    = dot_reserve_enemy(1, 17, 18, 0)
	barbaroi    = dot_reserve_enemy(1, 26, 20, 0)
	barbaroi    = dot_reserve_enemy(1, 24, 24, 0)
	barbaroi    = dot_reserve_enemy(1, 23, 25, 0)
	
	Ef_baruba = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_blood = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Blood_Splash", false, true)
	Ef_blood2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Blood_Drop", false, true)
	Ef_WarpOut = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpOut2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	
	
	
	setup_complete_unit()
	
	

	
	dot_unit_dir(dotArthur2, 2)


	
	dot_disp_unit(barbaroi4m, false)
	dot_disp_unit(barbaroi5m, false)
	
	
	
	dot_disp_unit(dotClare1, false)
	dot_disp_unit(dotBors, false)
	dot_disp_unit(dotRagnar1, false)
	dot_disp_unit(dotGawain1, false)
	dot_disp_unit(dotDinatan1, false)
	dot_change_anim(dotDinatan,1)
	dot_change_anim(dotNoir2,1)
	
	dot_disp_unit(dotGuinevere, false)
	dot_disp_unit(dotGwenhwymawr1, false)
	dot_disp_unit(dotLancelot3, false)	
	

	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(20, 22, 0.0)
	
	movie_load("MA_01C109_19")
	movie_set_active(true)
	movie_play()
	
end
	
	function LancelotMoveSet() 
	local signal1 = dot_move_unit(dotBors,19,16)
	wait_proccess(signal1)
	dot_unit_dir(barbaroi4m,2)
	dot_target_attack(dotBors,barbaroi4m,false)
	dot_change_anim(barbaroi4m,6)
	wait_time(0.1)
	local signal2 = dot_dying_unit(barbaroi4m)
	wait_proccess(signal2)
end

function ArthurMoveSet() 
	local signal3 = dot_move_unit(dotClare1,21,16)
	wait_proccess(signal3)
	dot_target_attack(dotClare1,barbaroi5m,false)
	dot_change_anim(barbaroi5m,6)
	wait_time(0.1)
	local signal4 = dot_dying_unit(barbaroi5m)
	wait_proccess(signal4)
end


function Play()
	fadein(0)
	Play_start(true)

	movie_wait_playing()
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)

	
	change_face(Arthur2, "Normal") 
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C109_190015")
	close_speech_window()

	
	change_face(Noir2, "Pain") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C109_190016")
	close_speech_window()
	
	dot_disp_unit(barbaroi4m, true)
	
	on_active(Ef_baruba)
	local gridpos = get_grid_position(19,17)
	set_pos(Ef_baruba, gridpos)
	set_scale(Ef_baruba, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba)
	
	dot_disp_unit(barbaroi5m, true)
	
	on_active(Ef_baruba2)
	local gridpos = get_grid_position(21,17)
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2)

	
	
	
	change_face(Arthur2, "Anger") 
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C109_190018")
	
	


	
	change_face(Arthur2, "Anger") 
	
	message("MA_01C109_190020")
	close_speech_window()
	
	move_camera(20, 18, 1.0)
	
	dot_disp_unit(dotGuinevere, true)
	dot_disp_unit(dotGwenhwymawr1, true)
	dot_disp_unit(dotLancelot3, true)
	dot_disp_unit(dotClare1, true)
	dot_disp_unit(dotBors, true)	
	
	
	dot_reserve_move_unit_seq(dotGuinevere,20,14)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,19,14)
	dot_reserve_move_unit_seq(dotLancelot3,21,14)
	dot_reserve_move_unit_seq(dotClare1,21,13)
	dot_reserve_move_unit_seq(dotBors,19,13)
	exec_parallel_seq()
	wait_seq()

	
	change_face(Guinevere, "Surprise") 
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01C109_190021")
	close_speech_window()

	
	change_face(Arthur2, "Normal") 
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C109_190023")
	

	
	change_face(Arthur2, "Sad") 
	
	message("MA_01C109_190024")
	

	
	change_face(Arthur2, "Sad") 
	
	message("MA_01C109_190025")
	close_speech_window()

	
	change_face(Lancelot3, "Surprise") 
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C109_190027")
	close_speech_window()

	
	change_face(Arthur2, "Normal") 
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C109_190028")
	

	
	change_face(Arthur2, "Sad") 
	
	message("MA_01C109_190029")
	

	
	change_face(Arthur2, "Sad") 
	
	message("MA_01C109_190030")
	close_speech_window()
	
	
	
	local LancelotSet = create_coroutine(LancelotMoveSet) 
	local ArthurSet = create_coroutine(ArthurMoveSet) 
	
	coroutine.resume(LancelotSet)  
	coroutine.resume(ArthurSet)  


	pbadv_wait_coroutine(LancelotSet) 
	pbadv_wait_coroutine(ArthurSet) 
	
	dot_change_anim(dotClare1,0)
	dot_change_anim(dotBors,0)
	
	move_camera(20, 17, 0.0)

	
	
	
	change_face(Clare1, "Anger") 
	open_speech_window("CHRNAME_CLARE2",Clare1 , nil)
	message("MA_01C109_190032")
	close_speech_window()

	
	change_face(Bors, "Anger") 
	open_speech_window("CHRNAME_BORS",Bors , nil)
	message("MA_01C109_190033")
	close_speech_window()
	
	
	dot_move_unit_seq(dotArthur2,20 ,19 )
	wait_seq()
	dot_unit_dir(dotArthur2, 2)

	
	change_face(Arthur2, "Normal") 
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C109_190034")
	close_speech_window()

	
	
	change_face(Clare1, "Normal") 
	open_speech_window("CHRNAME_CLARE2",Clare1 , nil)
	message("MA_01C109_190036")
	

	
	change_face(Clare1, "Normal") 
	
	message("MA_01C109_190037")
	

	
	change_face(Clare1, "Anger") 
	
	message("MA_01C109_190038")
	close_speech_window()

	
	change_face(Arthur2, "Normal") 
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C109_190039")
	close_speech_window()

	
	
	
	
	    on_active(Ef_WarpOut) 

        local gridpos = get_grid_position(22, 16) 
        set_pos(Ef_WarpOut, gridpos)
        play_particle(Ef_WarpOut)

        wait_time(0.3)
        
        dot_unit_dir(dotRagnar1, 2)
        dot_disp_unit(dotRagnar1, true)
		dot_place_unit(dotRagnar1,22,16) 

        wait_time(0.5)
	
	
	wait_seq()
	dot_change_anim(dotRagnar1,3)
	dot_play_particle_unit(dotRagnar1,"Ef_C_Axe_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotClare1,6)
	dot_play_particle_unit(dotClare1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)
	dot_change_anim(dotRagnar1,0)
	dot_change_anim(dotClare1,1)
	
	
	change_face(Clare1, "Pain") 
	open_speech_window("CHRNAME_CLARE2",Clare1 , nil)
	message("MA_01C109_190041")
	close_speech_window()

	
	
	
	change_face(Ragnar1, "Sad") 
	open_speech_window("CHRNAME_RAGNAR2",nil , Ragnar1)
	message("MA_01C109_190043")
	close_speech_window()

	
	
	change_face(Bors, "Normal") 
	open_speech_window("CHRNAME_BORS",Bors , nil)
	message("MA_01C109_190045")
	close_speech_window()

	wait_time(0.3)

	
	change_face(Dinatan, "Surprise") 
	open_speech_window("CHRNAME_DINATAN",Dinatan, nil)
	message("MA_01C109_190022")
	close_speech_window()

	dot_change_anim(dotDinatan,0)

	wait_time(0.5)

	    on_active(Ef_WarpOut2) 

        local gridpos = get_grid_position(18, 16) 
        set_pos(Ef_WarpOut2, gridpos)
        play_particle(Ef_WarpOut2)

        wait_time(0.3)
        
        dot_disp_unit(dotGawain1, true)
		dot_place_unit(dotGawain1,18,16)

        wait_time(0.5)
	
	wait_seq()
	dot_change_anim(dotGawain1,3)
	dot_play_particle_unit(dotGawain1,"Ef_C_Ham_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotBors,6)
	dot_play_particle_unit(dotBors,"Ef_C_Cmn_N_Hit_Str01",1,true)
	wait_time(0.2)
	dot_change_anim(dotGawain1,0)
	dot_change_anim(dotBors,1)


	
	
	change_face(Bors, "Anger") 
	open_speech_window("CHRNAME_BORS",Bors , nil)
	message("MA_01C109_190047")
	close_speech_window()

	
	
	
	change_face(Gawain1, "Sad") 
	open_speech_window("CHRNAME_GAWAIN",nil , Gawain1)
	message("MA_01C109_190049")
	close_speech_window()

	
	change_face(Noir2, "Surprise") 
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C109_190050")
	close_speech_window()
	
	show_image("10104020", 0.0, 0.0, 0.0, true, false)
	
	fadein(FADE_TIME+1.6)
	wait_time(FADE_TIME)
	
	dot_play_particle_unit(dotArthur2,"Ef_C_Ham_N_Atk01",3,true)
	dot_play_particle_unit(dotBors,"Ef_C_Cmn_N_Hit_Str01",1,true)
	dot_remove_unit(dotBors)

	dot_unit_dir(dotClare1, 2)
		
	wait_time(0.9)
	
	on_active(Ef_blood2)
	local gridpos = get_grid_position(19,16)
	set_pos(Ef_blood2, gridpos)
	play_particle(Ef_blood2)
	
	on_active(Ef_blood)
	local gridpos = get_grid_position(19,16)
	set_pos(Ef_blood, gridpos)
	play_particle(Ef_blood)
		
	wait_time(4.2)
	
	hide_image(STILL_SWITCH_TIME) 
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )

	
	
	
	
	change_face(Dinatan, "Sad") 
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01C109_190052")
	close_speech_window()

	
	change_face(Arthur2, "Normal") 
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C109_190053")
	

	
	change_face(Arthur2, "Sad") 
	
	message("MA_01C109_190054")
	

	
	change_face(Arthur2, "Sad") 
	
	message("MA_01C109_190055")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10104020", "content_still_10104020_image", "101040200_StillImage")
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
    pbadv_setup_101009_Noir_preload(2,true,20,22,0)
    pbadv_setup_101016_Gwenhwymawr_preload(1,true,19,11,0)
    pbadv_setup_101011_Guinevere_preload(0,true,20,11,0)
    pbadv_setup_101010_Lancelot_preload(3,true,21,11,0)
    pbadv_setup_101012_Dinatan_preload(1,true,1,0,0)
    pbadv_setup_101012_Dinatan_preload(0,true,19,20,0)
    pbadv_setup_101024_Bors_preload(0,true,19,12,0)
    pbadv_setup_101025_Clare_preload(1,true,21,12,0)
	pbadv_setup_101015_Arthur_preload(2,true,20,20,0)
	pbadv_setup_101013_Gawain_preload(1,true,1,1,0)
	pbadv_setup_101018_Ragnar_preload(1,true,1,2,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Blood_Splash", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Blood_Drop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	movie_load_preload("MA_01C109_19")
end
