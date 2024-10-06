

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	init_psbattleadv("201150100", "201150100")
	
	change_time_and_weather(1,1)
	
	
	
	
    pbadv_setup_101009_Noir(2,true,29,13,0)
    
     
    pbadv_setup_101016_Gwenhwymawr(1,true,29,7,0)
    
    
    pbadv_setup_101011_Guinevere(0,true,30,6,0)
    
    
    pbadv_setup_101010_Lancelot(3,true,30,21,0)
    
    
    pbadv_setup_101012_Dinatan(0,true,30,13,0)
     pbadv_setup_101012_Dinatan(1,true,1,1,0)
    Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
    
    
    
    
    
    
    
    
	
	
	
	
	
	
	
	
	
	

	
	
	
	
	
	
	
	
	
	
	dotsolder   = dot_reserve_ally(401006001, 14, 22, 0)
	dotsolder2m = dot_reserve_ally(401005001, 20, 24, 0)
	dotsolder3  = dot_reserve_ally(401005001, 23, 23, 0)
	
	
	
	
	dot_set_weapon(dotsolder, 101010001)
	dot_set_weapon(dotsolder2m, 101010001)
	dot_set_weapon(dotsolder3, 101010001)
	
	
	
	
	
	

	
	
	
		
	
	
	
	
	barbaroim    = dot_reserve_enemy(1, 30, 9, 0)
	barbaroi2m   = dot_reserve_enemy(601, 29, 10, 0)
	barbaroi3m   = dot_reserve_enemy(1203, 30, 18, 0)
	barbaroi5m   = dot_reserve_enemy(1, 15, 22, 0)
	barbaroi6m   = dot_reserve_enemy(1100, 20, 23, 0)
	barbaroi7   = dot_reserve_enemy(1, 24, 23, 0)



	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	

	
	
	
	
	

	
	
	dot_disp_unit(dotDinatan1, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(20, 24, 0.0)
	
		Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	
	load_sound("BGM_Battle_AfterDinatan_General1_Start")

end

function LancelotMoveSet() 
	local signal1 = dot_move_unit(dotLancelot3,24,22)
	wait_proccess(signal1)
	dot_unit_dir(dotLancelot3, 1)
	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(barbaroi7,6)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	dot_disp_unit(barbaroi7, false)
	dot_change_anim(dotLancelot3,0)
end

function ArthurMoveSet() 
	local signal3 = dot_move_unit(dotNoir2,20, 22)
	wait_proccess(signal3)
	dot_unit_dir(dotNoir2, 1)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi6m,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(barbaroi6m,6)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi6m,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	dot_disp_unit(barbaroi6m, false)
	dot_change_anim(dotNoir2,0)
	
end





function Play()
	fadein(0)
	Play_start(true)


	

	
	
	
	
	
	
	move_camera(30, 14, 2.0)
	wait_time(2.0)
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	 --PlayPartVoice("ノワール", "驚き")
	message("MA_01C109_140002")
	close_speech_window()
	
	move_camera(30, 10, 1.0)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,29,9)
	dot_reserve_move_unit_seq(dotGuinevere,30,8)
	exec_parallel_seq()
	wait_seq()
	
	dot_change_anim(dotGuinevere,3)
	dot_play_particle_unit(dotGuinevere,"Ef_C_Swd_N_Atk01",3,true)
	dot_play_particle_unit(barbaroim,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_dying_unit_seq(barbaroim)
	wait_seq()
	dot_change_anim(dotGwenhwymawr1,3)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Spr_N_Atk01",3,true)
	dot_play_particle_unit(barbaroi2m,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_dying_unit_seq(barbaroi2m)
	wait_seq()
	dot_reserve_move_unit_seq(dotGuinevere,30,12)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,29,12)
	exec_parallel_seq()
	wait_seq()
	move_camera(30, 14, 0.3)
	wait_camera()
	
	
	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	 --PlayPartVoice("ギネヴィア", "怒り")
	message("MA_01C109_140004")
	close_speech_window()

	
	change_face(Gwenhwymawr1, "Surprise")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1 , nil)
	message("MA_01C109_140005")
	close_speech_window()
	
	move_camera(30, 18, 1.0)
	dot_move_unit_seq(dotLancelot3,30, 19)
	wait_seq()
	wait_time(1.0)
	
	
	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	dot_play_particle_unit(barbaroi3m,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_dying_unit_seq(barbaroi3m)
	wait_seq()
	dot_move_unit_seq(dotLancelot3,29, 15)
	wait_seq()
	move_camera(30, 14, 0.3)
	wait_camera()


	
	
	change_face(Lancelot3, "Serious")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3 , nil)
	 --PlayPartVoice("ランスロット", "怒り")
	message("MA_01C109_140007")
	close_speech_window()
	
	dot_reserve_move_unit_seq(dotLancelot3,29,22)
	dot_reserve_move_unit_seq(dotNoir2,29,21)
	dot_reserve_move_unit_seq(dotDinatan,30,21)
	dot_reserve_move_unit_seq(dotGuinevere,30,20)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,29,20)
	exec_parallel_seq()
	move_camera(20, 24, 0.8)
	wait_seq()
	wait_time(2.0)
	
	
	dot_unit_dir(barbaroi6m, 1)
	dot_change_anim(barbaroi6m,3)
	dot_play_particle_unit(barbaroi6m,"Ef_C_Axe_N_EmyAtk01",3,true)
	dot_play_particle_unit(dotsolder2m,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
	dot_change_anim(dotsolder2m,6)
	wait_time(0.5)
	dot_change_anim(barbaroi6m,0)
	dot_change_anim(dotsolder2m,1)
	wait_time(0.5)
	










	local LancelotSet = create_coroutine(LancelotMoveSet) 
	local ArthurSet = create_coroutine(ArthurMoveSet) 
	
	coroutine.resume(LancelotSet)  
	coroutine.resume(ArthurSet)  


	pbadv_wait_coroutine(LancelotSet) 
	pbadv_wait_coroutine(ArthurSet) 
	
	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotLancelot3,0)
	
	move_camera(20, 24, 0.5)
	
	
	dot_move_unit_seq(dotDinatan,19, 21)
	dot_move_unit_seq(dotDinatan,19, 24)
	wait_seq()
	wait_time(1.0)
	
	dot_play_particle_unit(dotsolder2m,"Ef_C_Cmn_Die01",2,true)
	wait_time(0.5)

	dot_disp_unit(dotsolder2m, false)
	move_camera(20, 24, 0.5)
	wait_time(1.0)

	
	
	
	
	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	 --PlayPartVoice("ディナタン", "悲しみ")
	message("MA_01C109_140009")
	close_speech_window()
	
	dot_change_anim(dotDinatan,0)
	wait_time(1.0)
	
	
	
	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01C109_140011")
	close_speech_window()
	
	
	bgm_play("BGM_Battle_AfterDinatan_General1_Start")
	
	
	dot_move_unit_seq(dotNoir2,21, 22)
	dot_move_unit_seq(dotNoir2,21, 24)
	wait_seq()
	dot_unit_dir(dotNoir2, 2)
	
	on_active(Ef_Emblem2)

	on_active(Ef_Emblem2) 
	local locatorpos = dot_get_unit_locator(dotNoir2, 1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	


	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	 --PlayPartVoice("ノワール", "怒り")
	message("MA_01C109_140013")
	close_speech_window()
	
	on_active(Ef_Emblem1)
	
	local locatorpos = dot_get_unit_locator(dotDinatan, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)
	
	wait_time(2.0)

	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(19, 24)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(21, 24)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	
	
	
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01C109_140015")
	close_speech_window()

	bgm_play("BGM_To_Main")
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C109_140017")
	close_speech_window()
	
	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(19, 24)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)
	dot_change_unit(dotDinatan, dotDinatan1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)
	
	wait_time(2.0)

	
	
	
	
	
	change_face(Dinatan1, "Smile")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1 , nil)
	 --PlayPartVoice("ディナタン", "笑い")
	message("MA_01C109_140019")
	close_speech_window()





	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,29,13,0)
    pbadv_setup_101016_Gwenhwymawr_preload(1,true,29,7,0)
    pbadv_setup_101011_Guinevere_preload(0,true,30,6,0)
    pbadv_setup_101010_Lancelot_preload(3,true,30,21,0)
    pbadv_setup_101012_Dinatan_preload(0,true,30,13,0)
     pbadv_setup_101012_Dinatan_preload(1,true,1,1,0)
    load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
		load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	preload_sound("BGM_Battle_AfterDinatan_General1_Start")
end
