

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
		
    load_image("MA01C1093001", "content_still_10104001_image", "101040010_StillImage")
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	

	
	init_psbattleadv("201150000", "201150000")
	
	
	
	
    pbadv_setup_101009_Noir(2,true,20,16,0)
    
     
    pbadv_setup_101016_Gwenhwymawr(1,true,19,5,0)
    
    
    pbadv_setup_101011_Guinevere(0,true,21,5,0)
    
    
    pbadv_setup_101010_Lancelot(3,true,20,5,0)
    
    
    pbadv_setup_101012_Dinatan(1,true,21,17,0)
    
    
    
	pbadv_setup_101015_Arthur(2,true,20,15,0)
	
	
	pbadv_setup_101023_Clarice(0,true,19,15,0)
	pbadv_setup_101023_Clarice(1,true,1,1,0)
	
	
	
	pbadv_setup_101022_Mordred(0,true,21,15,0)
	

	
	barbaroi    = dot_reserve_enemy(1, 21,7, 0)
	barbaroi2   = dot_reserve_enemy(1, 20,7, 0)
	barbaroi3   = dot_reserve_enemy(1, 19,7, 0)
	
	barbaroi4    = dot_reserve_enemy(1, 21,9, 0)
	barbaroi5   = dot_reserve_enemy(1, 20,9, 0)
	barbaroi6   = dot_reserve_enemy(1, 19,9, 0)
	
	
	
	change_time_and_weather(2,1)
	
	
	
	setup_complete_unit()
	

	
	
	
	dot_disp_weapon(dotDinatan1, false)
	
	dot_unit_dir(dotArthur2, 2)
	
	
	
	dot_disp_unit(dotMordred, false)
	dot_disp_unit(dotClarice, false)
	dot_change_anim(dotDinatan1,1)

	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(20, 7, 0.0)
	
	Ef_Flash = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	
	Ef_WarpIN = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIN2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)

	load_sound("BGM_ADV_Prayer")
	load_sound("BGM_ADV_Revenge")
	
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	dot_unit_dir(dotGwenhwymawr1, 1)	
	dot_unit_dir(dotLancelot3, 1)
	dot_unit_dir(dotGuinevere, 1)
	
	dot_change_anim(dotGwenhwymawr1,3)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Spr_N_Atk01",3,true)
	
	dot_change_anim(dotGuinevere,3)
	dot_play_particle_unit(dotGuinevere,"Ef_C_Spr_N_Atk01",3,true)
	
	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.2)
	
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_change_anim(barbaroi,6)
	
	
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(barbaroi2,6)
	
	
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_change_anim(barbaroi3,6)
	
	wait_time(0.2)
	
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.7)
	
	dot_remove_unit(barbaroi)
	dot_remove_unit(barbaroi2)
	dot_remove_unit(barbaroi3)
	
	wait_time(0.5)
	
	dot_change_anim(dotGwenhwymawr1,0)
	dot_change_anim(dotLancelot3,0)
	dot_change_anim(dotGuinevere,0)
	
	dot_reserve_move_unit_seq(barbaroi4,21,7)
	dot_reserve_move_unit_seq(barbaroi5,20,7)
	dot_reserve_move_unit_seq(barbaroi6,19,7)
	exec_parallel_seq()
	wait_seq()
	
	move_camera(20, 17, 2.0)
	wait_time(2.0)
	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil , Arthur2)
	message("MA_01C109_290004")
	close_speech_window()

	
	
	change_face(Noir2, "Pain")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C109_290006")
	close_speech_window()

	
	change_face(Dinatan1, "Pain")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C109_290007")
	close_speech_window()

	
	
	
	
	
	dot_unit_dir(dotNoir2, 0)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(dotArthur2)
	wait_time(0.7)
	dot_unit_dir(dotArthur2, 1)
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	dot_change_anim(dotNoir2,6)
	dot_move_knockback(dotNoir2,20,19,0.3,2)
	wait_time(0.5)
	dot_unit_dir(dotArthur2, 2)
	dot_change_anim(dotArthur2,0)
	dot_change_anim(dotNoir2,1)

	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil ,Arthur2)
	message("MA_01C109_290009")
	close_speech_window()

	
	
	
	change_face(Noir2, "Pain")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C109_290011")
	close_speech_window()

	
	dot_move_unit_seq(dotArthur2,20, 17)
	wait_seq()
	dot_unit_dir(dotArthur2, 2)

	
	change_face(Dinatan1, "Anger")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C109_290012")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")

	
	
	dot_disp_weapon(dotDinatan1, true)
	dot_move_unit_seq(dotDinatan1,20, 18)
	
	 
                show_image("MA01C1093001", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
                set_scale_image(STILL_SCALE,STILL_SCALE)
                wait_time(STILL_SWITCH_TIME)
                
                 scale_to_image(1,1,STILL_MOVE_TIME,2)
                wait_time(STILL_ACTIVE_AFTER)
                
            
		
	
	open_simple_window("CHRNAME_DINATAN2")
	message("MA_01C109_290013")
	close_simple_window()

	bgm_play("BGM_ADV_Prayer")
	
	on_active(Ef_Killers)

	local gridpos = get_grid_position(20, 18)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)
	
	
	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
	
	

	
	
	bgm_play("Set_BGM_Bus_Volume")
	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR",nil ,Arthur2)
	message("MA_01C109_290015")
	close_speech_window()

	
	
	
	change_face(Dinatan1, "Anger")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	message("MA_01C109_290017")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")
	
	on_active(Ef_Flash)

	local gridpos = get_grid_position(20,18)
	set_pos(Ef_Flash , gridpos)
	play_particle(Ef_Flash)
	
	stop_particle(Ef_Vibes2)
	
	dot_disp_unit(dotDinatan1, false)
	dot_disp_unit(dotNoir2, false)
	
	stop_particle(Ef_Killers)
	
	wait_time(2.0)
	
	dot_unit_dir(dotGwenhwymawr1, 1)	
	dot_unit_dir(dotLancelot3, 1)
	dot_unit_dir(dotGuinevere, 1)
	
	dot_change_anim(dotGwenhwymawr1,3)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Spr_N_Atk01",3,true)
	
	
	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(dotGuinevere,3)
	dot_play_particle_unit(dotGuinevere,"Ef_C_Spr_N_Atk01",3,true)
	
	wait_time(0.2)
	
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_change_anim(barbaroi4,6)
	
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_change_anim(barbaroi6,6)
	
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(barbaroi5,6)
	
	wait_time(0.2)
	
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	

	dot_remove_unit(barbaroi4)
	dot_remove_unit(barbaroi5)
	dot_remove_unit(barbaroi6)
	
	wait_time(0.5)
	
	dot_change_anim(dotGwenhwymawr1,0)
	dot_change_anim(dotLancelot3,0)
	dot_change_anim(dotGuinevere,0)
	
	dot_reserve_move_unit_seq(dotGuinevere,21,13)
	dot_reserve_move_unit_seq(dotLancelot3,20,13)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,19,13)
	exec_parallel_seq()
	wait_seq()

	
	
	change_face(Lancelot3, "Surprise")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	message("MA_01C109_290019")
	close_speech_window()

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01C109_290020")
	close_speech_window()

	
	
	
	move_camera(20, 18, 1.0)
	dot_move_unit_seq(dotArthur2,20, 20)
	wait_seq()
	dot_unit_dir(dotArthur2, 2)
	
	change_face(Arthur2, "Sad")
	open_speech_window("CHRNAME_ARTHUR",nil ,Arthur2)
	message("MA_01C109_290022")
	close_speech_window()

	
	bgm_play("Reset_BGM_Bus_Volume")
	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_NAMELES",nil , nil)
	message("MA_01C109_290024")
	close_speech_window()

	bgm_play("BGM_ADV_Revenge")
	
	on_active(Ef_WarpIN) 

	local gridpos = get_grid_position(19, 15) 
	set_pos(Ef_WarpIN, gridpos)
	play_particle(Ef_WarpIN)
	
	on_active(Ef_WarpIN2) 

	local gridpos = get_grid_position(21, 15) 
	set_pos(Ef_WarpIN2, gridpos)
	play_particle(Ef_WarpIN2)

	wait_time(0.5)
	
	dot_disp_unit(dotMordred, true)
	dot_disp_unit(dotClarice, true)
	dot_reserve_move_unit_seq(dotMordred,21, 18)
	dot_reserve_move_unit_seq(dotClarice,19, 18)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotClarice, 3)
	dot_unit_dir(dotMordred, 2)
	

	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil ,Arthur2)
	message("MA_01C109_290026")
	close_speech_window()

	
	
	
	change_face(Mordred, "Smile")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C109_290028")
	close_speech_window()

	
	
	
	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil ,Arthur2)
	message("MA_01C109_290030")
	close_speech_window()

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C109_290031")
	close_speech_window()
	

	
	
	change_face(Clarice, "Normal")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	message("MA_01C109_290032")
	close_speech_window()
	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)

	 
	local locatorpos = dot_get_unit_locator(dotClarice, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotMordred, 1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	wait_time(2.0)
	
	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(19, 18)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(21, 18)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	
	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C109_290034")
	close_speech_window()
	

	
	change_face(Clarice, "Normal")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	message("MA_01C109_290036")
	close_speech_window()
	
	
	
	change_face(Mordred, "Serious")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C109_290038")
	close_speech_window()


	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(19, 18)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)
	dot_change_unit(dotClarice, dotClarice1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)
	
	wait_time(2.0)
	
	
	
	
	
	change_face(Mordred, "Serious")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C109_290040")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
	

	
	
	
	
	open_narration_window()
	message("MA_01C109_290042")
	

	
	
	message("MA_01C109_290043")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    load_image_preload("MA01C1093001", "content_still_10104001_image", "101040010_StillImage")
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
    pbadv_setup_101009_Noir_preload(2,true,20,16,0)
    pbadv_setup_101016_Gwenhwymawr_preload(1,true,19,5,0)
    pbadv_setup_101011_Guinevere_preload(0,true,21,5,0)
    pbadv_setup_101010_Lancelot_preload(3,true,20,5,0)
    pbadv_setup_101012_Dinatan_preload(1,true,21,17,0)
	pbadv_setup_101015_Arthur_preload(2,true,20,15,0)
	pbadv_setup_101023_Clarice_preload(0,true,19,15,0)
	pbadv_setup_101023_Clarice_preload(1,true,1,1,0)
	pbadv_setup_101022_Mordred_preload(0,true,21,15,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	preload_sound("BGM_ADV_Prayer")
	preload_sound("BGM_ADV_Revenge")
end
