

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)

	
	
	init_psbattleadv("201060001", "201060001")

    pbadv_setup_101009_Noir(2,true,28,4,0)

	
	pbadv_setup_101023_Clarice(0,true,26,4,0)
	pbadv_setup_101023_Clarice(1,true,1,1,0)
	Kair  = dot_reserve_ally(401015001, 25, 4, 0)
	dot_set_weapon(Kair, 101010001)
	 

	
	
	barbaroi = dot_reserve_enemy(100, 39, 10, 0)
	barbaroi2 = dot_reserve_enemy(100, 41, 10, 0)
	barbaroi3 = dot_reserve_enemy(100, 40, 11, 0)
	barbaroi4 = dot_reserve_enemy(100, 40, 5, 0)
	
	
	
	setup_complete_unit()
	dot_disp_weapon(Kair, false)
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotClarice, false)
	
	dot_disp_unit(barbaroi, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(33, 10, 0.0)
	
	
	Ef_Flash = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	
	Ef_WarpIN = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpIN2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
end





function Play()
	fadein(0)
	Play_start(true)


	
    
    dot_reserve_move_unit_seq(Kair,33,11)
	dot_reserve_move_unit_seq(dotClarice,32,10)
	dot_reserve_move_unit_seq(dotNoir2,33,9)
	exec_parallel_seq()
	wait_seq()

	-- @ノワール	『天使の贈り物』の群生地はこの先か
	open_speech_window("PLAYERNAME_NOIR",Noir2, nil)
	message("EA_007_0420004")
	close_speech_window()

	dot_disp_unit(barbaroi, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	
	dot_reserve_move_unit_seq(barbaroi,36,9)
	dot_reserve_move_unit_seq(barbaroi2,36,10)
	dot_reserve_move_unit_seq(barbaroi3,36,11)
	exec_parallel_seq()
	wait_seq()
	
	dot_disp_weapon(dotNoir2, true)

	-- @クラリス	本来このあたりの獣は大人しいと聞きますが魔女の穢れの影響か、狂暴になっていますね…
	change_face(Clarice, "Anger")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	PlayPartVoiceDirect("クラリス","0020")
	message("EA_007_0420007")
	close_speech_window()
	
	
			
	-- @カイル	く、クラリスお姉ちゃん…！
	open_speech_window("NPCNAME_0386",nil , nil)
	message("EA_007_0420009")
	close_speech_window()

	-- @クラリス	カイルくん、わたしの後ろに
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	PlayPartVoiceDirect("クラリス","0007")
	message("EA_007_0420010")
	close_speech_window()
	
	dot_move_unit_seq(Kair ,31,9)
	wait_seq()
	dot_unit_dir(Kair, 3)
	dot_move_unit_seq(Kair ,31,10)
	
	
	change_camera_distance(5.0, 2.0)
	
	move_camera(32, 10, 2.0)
	
	on_active(Ef_Emblem1)
	
	local locatorpos = dot_get_unit_locator(dotClarice, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)
	
	wait_time(2.0)
	
	on_active(Ef_Killers)
	
	local gridpos = get_grid_position(32, 10)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)
	
	
	
			
	-- @クラリス	今より目覚めよ　<ruby=しろたえ>白妙</ruby>の王者
	open_speech_window("CHRNAME_CLARICE",Clarice, nil)
	message("EA_007_0420012")
	close_speech_window()

			
	open_cutin(1, 1)
	
	on_cutin(1,Clarice , "Anger", 1)
		
			
	-- @クラリス	
	open_speech_window("CHRNAME_CLARICE",nil, nil)
	message("EA_007_0420014")
	close_speech_window()
	
	close_cutin()
	wait_time(0.5)

			
	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(32, 10)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)
	
	wait_time(0.7)
	dot_change_unit(dotClarice, dotClarice1, 0.0)

	wait_time(2.5)

	stop_particle(Ef_Killers)
			
			
	-- @カイル	…うわあ
	open_speech_window("NPCNAME_0386",nil , nil)
	message("EA_007_0420020")
	--close_speech_window()

			
	-- @カイル	………天使さん、みたいだ
	--open_speech_window("NPCNAME_0386",nil , nil)
	message("EA_007_0420022")
	close_speech_window()

	move_camera(34, 10, 1.0)
	dot_move_unit_seq(dotClarice1 ,33,10)
	wait_seq()

			
			
	-- @クラリス・クラレント	おいで。なでてあげます
	change_face(Clarice, "Smile")
	open_speech_window("CHRNAME_CLARICE2",Clarice1 , nil)
	PlayPartVoiceDirect("クラリス","0010")
	message("EA_007_0420024")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,28,4,0)
	pbadv_setup_101023_Clarice_preload(0,true,26,4,0)
	pbadv_setup_101023_Clarice_preload(1,true,1,1,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
end
