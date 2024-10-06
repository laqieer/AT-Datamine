
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201020001", "201020001")
	
	
	change_time_and_weather(3, 1)
	
	
	pbadv_setup_101009_Noir(3,true, 18, 17,0)  
	pbadv_setup_101011_Guinevere(0,true, 19, 17,0)   
	pbadv_setup_101010_Lancelot(3,true, 7, 17,0)  
	
	barubaroi1 = dot_reserve_enemy(1, 15, 18, 0)
	barubaroi2 = dot_reserve_enemy(1, 15, 16, 0)

	
	dotrogu1 = dot_reserve_ally(401036001, 6, 16, 0)
	dot_set_weapon(dotrogu1, 101010001)		
	dotrogu2 = dot_reserve_ally(401036001, 6, 17, 0)
	dot_set_weapon(dotrogu2, 101010001)		
	dotrogu3 = dot_reserve_ally(401036001, 6, 18, 0)
	dot_set_weapon(dotrogu3, 101010001)		

setup_complete_unit()

	
	dot_unit_dir(dotNoir3, 3)
	dot_unit_dir(dotGuinevere, 2)
	
	dot_unit_dir(barubaroi1, 3)
	dot_unit_dir(barubaroi2, 3)


	
	dot_disp_weapon(dotNoir3, false)
	dot_disp_weapon(dotGuinevere, false)

	
	dot_disp_unit(dotLancelot3, false)
	dot_disp_unit(dotrogu1, false)
	dot_disp_unit(dotrogu2, false)
	dot_disp_unit(dotrogu3, false)
	
	dot_change_anim(dotGuinevere,13)	

	dot_change_anim(barubaroi1,1)
	dot_change_anim(barubaroi2,1)
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(18, 17, 0.0)

	load_sound("BGM_ADV_Invasion2")
	load_sound("BGM_ADV_Reconnaissance")
	Ef_COIN = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
	
	
end



function Play()
	fadein(0)
	Play_start(true)
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100057")
	close_speech_window()

	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100059")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100060")
	
	change_face(Guinevere, "Normal")
	message("MA_01100_100062")
	close_speech_window()

	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100063")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100064")
	
	change_face(Guinevere, "Normal")
	message("MA_01100_100065")
	
	change_face(Guinevere, "Normal")
	message("MA_01100_100067")
	close_speech_window()

	
	change_face(Noir3, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100069")
	close_speech_window()

	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100070")
	change_face(Guinevere, "Normal")
	message("MA_01100_100074")
	change_face(Guinevere, "Normal")
	message("MA_01100_100076")
	close_speech_window()

	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100077")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100078")
	change_face(Guinevere, "Normal")
	message("MA_01100_100080")
	close_speech_window()

	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100081")
	close_speech_window()

	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100082")
	close_speech_window()

	
	change_face(Noir3, "Normal")
	open_mind_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100083")
	close_mind_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100084")
	
	change_face(Guinevere, "Normal")
	message("MA_01100_100086")
	close_speech_window()
	
	wait_time(0.4)		
	
	on_active(Ef_COIN) 
	local offsetX = 0.4 
	local offsetY = -0.1 
	local locatorpos = dot_get_unit_locator(dotGuinevere,1)
	set_pos(Ef_COIN,  {locatorpos[1] + offsetX,locatorpos[2] + offsetY,locatorpos[3]})
	set_scale(Ef_COIN,{0.1,0.1,0.1})
	
	wait_time(1.5)	
	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100088")
	
	change_face(Noir3, "Normal")
	message("MA_01100_100089")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100091")
	
	change_face(Guinevere, "Anger")
	message("MA_01100_100092")
	close_speech_window()

	
	change_face(Noir3, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100093")
	close_speech_window()

	
	change_face(Guinevere, "Shy")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100094")
	close_speech_window()
	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100096")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100097")
	change_face(Guinevere, "Normal")
	message("MA_01100_100099")

	dot_change_anim(dotGuinevere,0)		
	
	change_face(Guinevere, "Normal")
	message("MA_01100_100101")
	change_face(Guinevere, "Normal")
	message("MA_01100_100109")
	change_face(Guinevere, "Normal")
	message("MA_01100_100111")
	close_speech_window()

	bgm_play("BGM_ADV_Invasion2")	
	
	move_camera(16, 17, 0.5)
	
	wait_camera()	


	dot_change_anim(barubaroi1,0)

	
	wait_time(0.7)
	
	dot_change_anim(barubaroi2,0)
	
	
	wait_time(0.5)
	
	
	dot_disp_unit(dotLancelot3, true)
	dot_disp_unit(dotrogu1, true)
	dot_disp_unit(dotrogu2, true)
	dot_disp_unit(dotrogu3, true)
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100113")
	
	change_face(Guinevere, "Normal")
	message("MA_01100_100114")
	close_speech_window()
	
	dot_unit_dir(dotNoir3, 2)		

	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100115")
	close_speech_window()
	

	dot_change_anim(barubaroi1,5)
	dot_change_anim(barubaroi2,5)

	
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("MA_01100_100095")
	close_speech_window()
	
	

	bgm_play("BGM_ADV_Reconnaissance")
	

	
	dot_attack_seq(dotLancelot3, barubaroi2)

	wait_time(0.5)		

	dot_play_particle_unit(barubaroi1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barubaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)	
	
	wait_time(0.5)	
	dot_unit_dir(barubaroi1, 2)	
	dot_unit_dir(barubaroi2, 2)		
		
	
	dot_change_anim(barubaroi1,6)
	dot_change_anim(barubaroi2,6)


	wait_time(0.2)

	dot_play_particle_unit(barubaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barubaroi2,"Ef_C_Cmn_DieEmy01",2,true)

        
	wait_time(0.5)

	dot_disp_unit(barubaroi1, false)
	dot_disp_unit(barubaroi2, false)


	dot_remove_unit(barubaroi1) 
	dot_remove_unit(barubaroi2) 


	wait_time(0.5)	
	
	
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotrogu1, false)	
	dot_disp_weapon(dotrogu2, false)
	dot_disp_weapon(dotrogu3, false)	
	
	wait_time(1.0)	

	dot_reserve_move_unit_seq(dotLancelot3, 14, 17)
	dot_reserve_move_unit_seq(dotrogu1, 13, 16)
	dot_reserve_move_unit_seq(dotrogu2, 13, 17)
	dot_reserve_move_unit_seq(dotrogu3, 13, 18)
	exec_parallel_seq()
	wait_seq()	
	
	
	move_camera(16, 17, 0.5)
	wait_camera()	
		
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100117")
	OpenFirstAppearance(Lancelot3)
	close_speech_window()
	
	
	dot_change_anim(dotGuinevere,0)

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100119")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100120")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100121")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100122")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100123")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100124")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100125")
	close_speech_window()

	
	change_face(Noir3, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100126")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100127")
	close_speech_window()

	
	change_face(Noir3, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100128")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100129")
	close_speech_window()

	
	change_face(Noir3, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100130")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100131")
	close_speech_window()

	
	change_face(Noir3, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100132")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100133")
	close_speech_window()

	
	change_face(Noir3, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100134")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dotNoir3, 17, 17)
	dot_reserve_move_unit_seq(dotrogu1, 16, 16)
	dot_reserve_move_unit_seq(dotrogu2, 16, 17)
	dot_reserve_move_unit_seq(dotrogu3, 16, 18)
	exec_parallel_seq()
	wait_seq()	

	
	open_speech_window("NPCNAME_0124", nil, nil)
	message("MA_01100_100136")
	close_speech_window()

	
	change_face(Noir3, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100137")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100138")
	close_speech_window()

	
	change_face(Noir3, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100139")
	close_speech_window()

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01100_100140")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100142")
	close_speech_window()
	
	
	move_camera(16, 20, 0.5)
	
	
	
	dot_reserve_move_unit_seq(dotNoir3, 17, 20)
	dot_reserve_move_unit_seq(dotrogu1, 16, 19)
	dot_reserve_move_unit_seq(dotrogu2, 16, 20)
	dot_reserve_move_unit_seq(dotrogu3, 16, 21)
	exec_parallel_seq()
	wait_seq()

	wait_time(0.2)		
	
	
	dot_unit_dir(dotNoir3, 2)	
	
	wait_time(0.8)		

	
	change_face(Noir3, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100144")
	close_speech_window()

	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01100_100145")
	close_speech_window()

	
	change_face(Noir3, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir3, nil)
	message("MA_01100_100146")
	close_speech_window()


	bgm_play("Stop_BGM_Bus_MidFade")
	
 
	
	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(3,true, 18, 17,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 19, 17,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 7, 17,0)
	preload_sound("BGM_ADV_Invasion2")
	preload_sound("BGM_ADV_Reconnaissance")
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Cloak_Kira", false, true)
end
