
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	init_psbattleadv("201000002", "201000002")
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101009_Noir(2,true, 21, 39,0)  
	
	pbadv_setup_101012_Dinatan(0,true,20,37,0)
	
	pbadv_setup_101011_Guinevere(0,true,23 ,39 ,0)  
	
	pbadv_setup_101068_Urrie(0,true,22 ,39 ,0)  
	
	pbadv_setup_101016_Gwenhwymawr(0,true,24 ,39 ,0)
	pbadv_setup_101016_Gwenhwymawr(1,true,1 ,5 ,0)
	
	Suisei = set_chara_unknown()
	character2DFull(Suisei, "Suisei", 101069001 )



	magic = dot_reserve_ally(101069001, 19, 25, 0)
	dot_set_weapon(magic, 107010001) 
	
	
	
	city13 = dot_reserve_ally(401011001, 20, 35, 0)
	dot_set_weapon(city13, 107010001) 
	
	city = dot_reserve_ally(401005001, 21, 35, 0)
	dot_set_weapon(city, 107010001) 
	city2 = dot_reserve_ally(401006001, 22, 35, 0)
	dot_set_weapon(city2, 107010001) 
	city3 = dot_reserve_ally(401011001, 23, 35, 0)
	dot_set_weapon(city3, 107010001) 
	
	city4 = dot_reserve_ally(401006001, 21, 36, 0)
	dot_set_weapon(city4, 107010001) 
	city5 = dot_reserve_ally(401005001, 22, 36, 0)
	dot_set_weapon(city5, 107010001) 
	city6 = dot_reserve_ally(401006001, 23, 36, 0)
	dot_set_weapon(city6, 107010001) 
	city7 = dot_reserve_ally(401011001, 24, 36, 0)
	dot_set_weapon(city7, 107010001) 
	
	city8 = dot_reserve_ally(401011001, 14, 38, 0)
	dot_set_weapon(city8, 107010001) 
	city9 = dot_reserve_ally(401005001, 23, 38, 0)
	dot_set_weapon(city9, 107010001) 
	city10 = dot_reserve_ally(401006001, 24, 38, 0)
	dot_set_weapon(city10, 101010001)
	
	city11 = dot_reserve_ally(401005001, 25, 38, 0)
	dot_set_weapon(city11, 107010001) 

	city12 = dot_reserve_ally(401045001, 38, 32, 0)
	dot_set_weapon(city12, 107010001) 
	

	
	barbaroi = dot_reserve_enemy(1100,39 ,32 , 0)
	barbaroi3 = dot_reserve_enemy(1100,39 ,34 , 0)
	barbaroi4 = dot_reserve_enemy(1100,39 ,35 , 0)
	barbaroi5 = dot_reserve_enemy(49,39 ,36 , 0)
	barbaroi6 = dot_reserve_enemy(49,21 ,9 , 0)
	barbaroi7 = dot_reserve_enemy(49,22 ,6 , 0)
	barbaroi8 = dot_reserve_enemy(1100,1,1 , 0)
	barbaroi9 = dot_reserve_enemy(1100,1 ,2 , 0)
	barbaroi10 = dot_reserve_enemy(49,1 ,3 , 0)
	barbaroi11 = dot_reserve_enemy(49,1 ,4 , 0)
	
	
	setup_complete_unit()

	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGwenhwymawr1, 2)
	dot_unit_dir(dotUrrie, 2)
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr, false)
	dot_disp_weapon(dotUrrie, false)
	dot_disp_weapon(magic, false)
	
	dot_disp_unit(magic, false)
	
	dot_disp_weapon(city, false)
	dot_disp_weapon(city2, false)
	dot_disp_weapon(city4, false)
	dot_disp_weapon(city3, false)
	dot_disp_weapon(city5, false)
	dot_disp_weapon(city6, false)
	dot_disp_weapon(city7, false)
	dot_disp_weapon(city8, false)
	dot_disp_weapon(city9, false)
	dot_disp_weapon(city10, false)
	dot_disp_weapon(city11, false)
	dot_disp_weapon(city13, false)
	
	change_camera_distance(8.0, 0.0)

	change_camera_angle(37.0, 0.0)
	
	move_camera(22, 38, 0.0)
	
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_Fog2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_Fog3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_EnemyDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	
	Ef_baruba = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
	Ef_Flash = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	load_sound("BGM_ADV_Antagonism")

end

	



function Play()
	fadein(0)
	Play_start(true)
	

	
					--//SE：ざわざわ、ドヨドヨ
	se_play("SE_ADV_MA_01107_06_Crowds")
	se_play("SE_ADV_MA_01C110_42_Crowd")
	
	dot_move_unit_seq(dotDinatan,21,37)
	dot_unit_dir(city5, 3)
	dot_unit_dir(city2, 3)
	dot_unit_dir(city11, 3)
	dot_move_unit_seq(city13,19,35)
	dot_unit_dir(city3, 3)
	dot_unit_dir(city4, 3)
	wait_time(0.5)
	dot_unit_dir(city, 3)
	dot_move_unit_seq(city11,25,35)
	dot_move_unit_seq(city8,22,38)
	dot_unit_dir(city7, 3)
	dot_unit_dir(city, 3)
	wait_time(0.5)
	dot_unit_dir(city10, 2)
	dot_unit_dir(city13, 2)
	dot_unit_dir(city6, 2)
	dot_unit_dir(dotUrrie, 3)
	dot_unit_dir(city, 2)
	wait_time(0.5)
	dot_unit_dir(city7, 3)
	dot_unit_dir(city, 3)
	dot_unit_dir(city10, 2)
	wait_time(0.5)
	dot_unit_dir(city3, 3)
	dot_unit_dir(city4, 2)
	dot_move_unit_seq(city13,20,35)
	dot_unit_dir(city, 3)
	dot_unit_dir(city10, 2)
	wait_time(0.5)
	dot_move_unit_seq(dotDinatan,20,37)
	dot_unit_dir(city3, 2)
	dot_unit_dir(city4, 3)
	dot_unit_dir(dotUrrie, 2)
	dot_move_unit_seq(city11,25,38)
	dot_unit_dir(city5, 2)
	dot_unit_dir(city2, 3)
	dot_unit_dir(city11, 2)
	
	wait_time(2.0)
	dot_move_unit_seq(dotDinatan,20,39)
	wait_seq()

					
	-- @ディナタン	開演時間をずいぶん過ぎてる気がするんだけど…はじまらないね	
	change_face(Dinatan,"Sad")
	PlayPartVoiceDirect("ディナタン","0034")
	
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_014_0110007")
	close_speech_window()

	-- @ウレリー	うーんちょっとワタシ、係の人に話を聞いてこようかな	
	change_face(Urrie,"Sad")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0110008")
	close_speech_window()
	
	
	move_camera(25, 35, 2.0)
	dot_move_unit_seq(city12 ,27,35)
	wait_seq()
	
				--//画面外からログレス兵士が走ってくる
				--<in>ログレス兵士
	-- @ログレス兵	に…逃げろ！野外音楽会は中止だ！	
	open_speech_window("NPCNAME_0124",nil , nil)
	message("EA_014_0110011")
	--close_speech_window()
	
	
	dot_unit_dir(dotGuinevere, 3)
	dot_unit_dir(dotGwenhwymawr, 3)
	dot_unit_dir(dotUrrie, 3)
	
	dot_unit_dir(city, 3)
	dot_unit_dir(city2, 3)
	dot_unit_dir(city3, 3)
	dot_unit_dir(city4, 3)
	dot_unit_dir(city5, 3)
	dot_unit_dir(city6, 3)
	dot_unit_dir(city7, 3)
	dot_unit_dir(city8, 3)
	dot_unit_dir(city9, 3)
	dot_unit_dir(city10, 3)
	dot_unit_dir(city11, 3)
	dot_unit_dir(city13, 3)

	-- @ログレス兵	バルバロイが出現した！一刻も早くここから逃げ…	
	--open_speech_window("",nil , nil)
	message("EA_014_0110012")
	close_speech_window()

	dot_move_unit_seq(barbaroi ,28,35)
	wait_seq()
	dot_change_anim(barbaroi,3)
	dot_play_particle_unit(barbaroi,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(city12,6)
	dot_play_particle_unit(city12,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.4)
	dot_change_anim(city12,1)
	dot_change_anim(barbaroi,0)

				--//バルバロイが出現、ログレス兵に攻撃
	-- @ログレス兵	ぐあぁっ…！！	
	open_speech_window("NPCNAME_0124",nil , nil)
	message("EA_014_0110014")
	close_speech_window()
	
	
	dot_move_unit_seq(barbaroi ,28,35)
	wait_seq()
	dot_change_anim(barbaroi,3)
	dot_play_particle_unit(barbaroi,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(city12,6)
	dot_play_particle_unit(city12,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.4)
	dot_play_particle_unit(city12,"Ef_C_Cmn_Die01",2,true)
	dot_disp_unit(city12, false)
	dot_change_anim(barbaroi,0)
	
	dot_place_unit(city12,6, 2)
	dot_reserve_move_unit_seq(barbaroi3 ,30,34)
	dot_reserve_move_unit_seq(barbaroi4 ,30,35)
	dot_reserve_move_unit_seq(barbaroi5 ,29,36)
	dot_reserve_move_unit_seq(city ,10,35)
	dot_reserve_move_unit_seq(city8 ,20,38)
	dot_reserve_move_unit_seq(city9 ,21,38)
	dot_reserve_move_unit_seq(city13 ,9,35)
	
	
    exec_parallel_seq()


				--//ログレス兵、消滅。
				--//ついでにモブ生徒も数人襲われてもいい。
				--//モブ、大騒ぎ（左右振り向いたり、ちょこちょこ動いたり）。
				
				
		se_play("SE_ADV_MA_01C109_29_Amb_Screaming")
		se_play("SE_ADV_MA_01C110_42_Crowd")
		
		move_camera(22, 38, 1.0)
		
		dot_unit_dir(city, 2)
		wait_time(0.5)
		dot_move_unit_seq(city8 ,21,38)
		dot_unit_dir(city7, 2)
		dot_unit_dir(city, 3)
		dot_unit_dir(city8, 3)
		dot_move_unit_seq(city9 ,22,38)
		dot_unit_dir(city10, 2)
		wait_time(0.7)
		dot_unit_dir(city3, 3)
		dot_unit_dir(city4, 2)
		dot_move_unit_seq(city6 ,20,35)
		dot_unit_dir(city, 3)
		dot_unit_dir(city10, 2)
		dot_unit_dir(city, 2)
		dot_unit_dir(city7, 3)
		
		dot_unit_dir(city, 2)
		dot_unit_dir(city10, 3)
		wait_time(0.5)
		dot_unit_dir(city3, 2)
		dot_move_unit_seq(city10 ,23,38)
		dot_unit_dir(city4, 3)
		wait_time(0.5)
		dot_unit_dir(city, 3)
		dot_unit_dir(city7, 3)
		dot_unit_dir(city6, 3)
		dot_unit_dir(city, 3)
		dot_reserve_move_unit_seq(city8 ,20,38)
		dot_reserve_move_unit_seq(city9 ,21,38)
    	exec_parallel_seq()
		wait_seq()
		wait_time(0.5)
		dot_unit_dir(city10, 3)
		dot_unit_dir(city3, 3)
		dot_move_unit_seq(city10 ,24,38)
		dot_unit_dir(city4, 3)
		dot_move_unit_seq(city11 ,22,38)
		dot_unit_dir(city, 2)
		wait_time(0.5)
		dot_unit_dir(city7, 2)
		dot_unit_dir(city, 3)
		dot_unit_dir(city10, 3)
		dot_move_unit_seq(city5 ,19,36)
		wait_time(0.5)
		dot_unit_dir(city3, 3)
		dot_unit_dir(city4, 3)
		dot_disp_weapon(city10, true)
		dot_unit_dir(city5, 2)
		dot_unit_dir(city2, 2)
		dot_unit_dir(city11, 3)
		dot_unit_dir(city10, 3)
		dot_unit_dir(city13, 3)
		dot_unit_dir(city6, 3)
		
		
				--//SE：ざわざわ、ドヨドヨ（緊迫感大）
				wait_time(0.5)
				
				
	
	-- @ウレリー	バ、バルバロイ！なんで、どうして…！？	
	change_face(Urrie,"Surprise")
	PlayPartVoiceDirect("ウレリー","0011")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0110019")
	close_speech_window()
	
	move_camera(27, 35, 2.0)
	
	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotDinatan, true)
	dot_disp_weapon(dotGuinevere, true)
	dot_disp_weapon(dotGwenhwymawr, true)
	
	dot_reserve_move_unit_seq(dotGuinevere ,26,34)		
	dot_reserve_move_unit_seq(dotGwenhwymawr ,25,35)
	dot_reserve_move_unit_seq(dotNoir2 ,26,36)
	exec_parallel_seq()
	wait_seq()
	

	-- @ノワール	みんな逃げろ！急いで街に避難するんだ！	
	change_face(Noir2,"Anger")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_014_0110020")
	close_speech_window()
	
	move_camera(22, 38, 2.0)

				--//モブ、聞く耳持たず大騒ぎ。
				--//SE：ざわざわ、ドヨドヨ（緊迫感大）
				se_play("SE_ADV_MA_01C109_29_Amb_Screaming")
				
		dot_unit_dir(city4, 2)
		wait_time(0.5)
		dot_unit_dir(city, 3)
		dot_unit_dir(city7, 3)
		dot_unit_dir(city, 3)
		wait_time(0.5)
		dot_unit_dir(city10, 3)
		dot_unit_dir(dotUrrie, 2)
		dot_unit_dir(city3, 3)
		dot_unit_dir(city4, 3)
		dot_unit_dir(city, 2)
		dot_move_unit_seq(city3 ,22,36)
		wait_time(0.5)
		dot_unit_dir(city7, 2)
		dot_unit_dir(city, 2)
		
		dot_move_unit_seq(city7 ,21,35)
		dot_unit_dir(city10, 2)
		dot_disp_weapon(city5, true)
		wait_time(0.5)
		
		dot_unit_dir(city3, 2)
		dot_unit_dir(city8, 2)
		dot_unit_dir(dotUrrie, 3)
		dot_unit_dir(city4, 2)
		dot_move_unit_seq(city5 ,23,36)
		dot_unit_dir(city5, 3)
		dot_unit_dir(city2, 2)
		dot_unit_dir(city11, 2)
		dot_unit_dir(city10, 3)
		wait_time(1.0)
		
		
	-- @ディナタン	みんな動転しちゃってるよ…私たちの声が届いてない…！	
	change_face(Dinatan,"Surprise")
	PlayPartVoiceDirect("ディナタン","0021")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_014_0110023")
	close_speech_window()

	-- @ウレリー	どうすれば…！？	
	change_face(Urrie,"Sad")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0110024")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")
	-- @？？？（星街すいせい）	みんな、落ち着いて―！一度深呼吸しようーっ！	
	open_speech_window("CHRNAME_NAMELES",nil, nil)
	message("EA_014_0110025")
	close_speech_window()

				--//まだ姿なし
	-- @ディナタン	えっ？	
	change_face(Dinatan,"Surprise")
	PlayPartVoiceDirect("ディナタン","0028")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_014_0110027")
	close_speech_window()
	
	move_camera(27, 35, 2.0)
	
		dot_unit_dir(barbaroi, 3)
		wait_time(0.5)
		dot_unit_dir(barbaroi3, 3)
		dot_unit_dir(barbaroi4, 3)
		wait_time(0.5)
		dot_unit_dir(barbaroi, 2)
		dot_unit_dir(barbaroi3, 2)
		dot_unit_dir(barbaroi4, 2)
		wait_time(0.5)
		dot_unit_dir(barbaroi, 3)
		wait_time(0.5)
		dot_unit_dir(barbaroi, 2)
		dot_unit_dir(barbaroi3, 3)
		
		dot_unit_dir(barbaroi3, 2)
		dot_unit_dir(barbaroi4, 3)
		dot_unit_dir(barbaroi, 3)
		
	
	
	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotDinatan, true)
	dot_disp_weapon(dotGuinevere, true)
	dot_disp_weapon(dotGwenhwymawr, true)
	
	

				--//モブたち、静かになる。
				--//バルバロイも動きを止める。
	-- @ギネヴィア	バルバロイが足を止めた？今がチャンスよ！	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("EA_014_0110030")
	close_speech_window()

	bgm_play("BGM_ADV_Antagonism")
	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)

	 
	local locatorpos = dot_get_unit_locator(dotGwenhwymawr, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotGuinevere, 1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)
	
	wait_time(2.0)
	
	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(25, 35)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(26, 34)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)
	
	on_active(Ef_KillChan1)
	local gridpos = get_grid_position(25, 35)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)
	
	wait_time(0.7)
	dot_change_unit(dotGwenhwymawr, dotGwenhwymawr1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)

	

				--//ギネマウア、すばやく動いてバルバロイに組みかかる。光ってGSしてから動くのが理想。
				--//ノワールとギネヴィアもあとに続く。
				
				
	dot_move_unit_seq(dotGwenhwymawr1 ,27,35)
	wait_seq()
	dot_change_anim(dotGwenhwymawr1,3)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Spr_N_Atk01",3,true)
	dot_change_anim(barbaroi,6)
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	wait_time(0.5)
	dot_dying_unit(barbaroi)
	dot_change_anim(dotGwenhwymawr1,0)
	dot_unit_dir(barbaroi3, 2)
	dot_unit_dir(barbaroi4, 2)
	wait_time(1.5)
	
	dot_disp_unit(magic, true)
	move_camera(22, 38, 2.0)
	dot_move_unit_seq(magic,19,36)
	wait_seq()

	
				--//すいせいさん、ここで登場。
	-- @？？？（星街すいせい）	怖～いバルバロイは騎士さんたちがやっつけてくれるよ	
	change_face(Suisei, "Smile")
	open_speech_window("CHRNAME_NAMELES",Suisei , nil)
	message("EA_014_0110034")
	--close_speech_window()
	
	move_camera(22, 38, 2.0)
	
	dot_unit_dir(city, 2)
	dot_unit_dir(city2,2)
	dot_unit_dir(city3, 2)
	dot_unit_dir(city4, 2)
	dot_unit_dir(city5, 2)
	dot_unit_dir(city6, 2)
	dot_unit_dir(city7, 2)
	dot_unit_dir(city8, 2)
	dot_unit_dir(city9, 2)
	dot_unit_dir(city10, 2)
	dot_unit_dir(city11, 2)
	dot_unit_dir(city13, 2)
	dot_unit_dir(dotUrrie, 2)
	dot_unit_dir(dotDinatan,2)

	-- @？？？（星街すいせい）	焦らなくて大丈夫、怖がらなくて大丈夫落ち着いて街に避難しよう	
	--open_speech_window("CHRNAME_NAMELES",Suisei , nil)
	message("EA_014_0110035")
	close_speech_window()
	
	

	-- @ウレリー	みんな、こっち！	
	change_face(Urrie,"Anger")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0110036")
	close_speech_window()
	
	dot_move_unit_seq(dotUrrie ,21,39)
	dot_move_unit_seq(dotUrrie ,21,37)
	dot_move_unit_seq(dotUrrie ,20,37)
	dot_move_unit_seq(dotUrrie ,19,35)

	wait_seq()

	dot_move_unit_seq(dotUrrie ,19,24)
	
	
	
	dot_reserve_move_unit_seq(city2 ,19,25)
	dot_reserve_move_unit_seq(city3 ,20,25)
	dot_reserve_move_unit_seq(city4 ,21,25)
	dot_reserve_move_unit_seq(city5 ,13,28)
	dot_reserve_move_unit_seq(city6 ,14,28)
	dot_reserve_move_unit_seq(city7 ,18,26)
	dot_reserve_move_unit_seq(city8 ,19,26)
	dot_reserve_move_unit_seq(city9 ,20,26)
	dot_reserve_move_unit_seq(city10 ,15,26)
	dot_reserve_move_unit_seq(city11 ,16,28)
	
	
	
	

				--//ウレリーに連れられるようにしてモブ退場。
				--//ノワール、ギネヴィア、ギネマウア、ディナタンは退場させない。
				
	exec_parallel_seq()
	wait_seq()
	
	dot_disp_unit(dotUrrie, false)
	dot_disp_unit(city, false)
	dot_disp_unit(city2, false)
	dot_disp_unit(city3, false)
	dot_disp_unit(city4, false)
	dot_disp_unit(city5, false)
	dot_disp_unit(city6, false)
	dot_disp_unit(city7, false)
	dot_disp_unit(city8, false)
	dot_disp_unit(city9, false)
	dot_disp_unit(city10, false)
	dot_disp_unit(city11, false)
	dot_disp_unit(city13, false)
	
	move_camera(19, 36, 2.0)
	dot_move_unit_seq(dotDinatan ,20,36)
	dot_unit_dir(dotDinatan, 2)
	wait_seq()
	dot_unit_dir(dotDinatan, 2)
	
   	

	
	-- @ディナタン	あの、あなたは…？	
	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_014_0110039")
	close_speech_window()

	-- @？？？（星街すいせい）	彗星のごとく現れたスターの原石！アイドルＶＴｕｂｅｒの	
	change_face(Suisei,"Laugh")
	open_speech_window("CHRNAME_NAMELES",Suisei , nil)
	message("EA_014_0110040")
	close_speech_window()
	
	open_cutin(1, 2)
	
	on_cutin(1,Suisei , "Smile", 1)

	-- @星街すいせい	星街すいせいでーす	
	open_speech_window("CHRNAME_SUISEI",nil , nil)
	message("EA_014_0110041")
	close_speech_window()
	
	close_cutin()
	wait_time(0.5)
	
	move_camera(28, 35, 1.0)
	
	wait_time(0.2)
	
	on_active(Ef_baruba2)
	local gridpos = get_grid_position(29,34)
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2)
	dot_place_unit(barbaroi6,29, 34)
	wait_seq()
	
	on_active(Ef_baruba3)
	local gridpos = get_grid_position(29,35)
	set_pos(Ef_baruba3, gridpos)
	set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3)
	dot_place_unit(barbaroi7,29, 35)
	wait_seq()
	
	wait_time(0.2)
	
	on_active(Ef_baruba4)
	local gridpos = get_grid_position(30,36)
	set_pos(Ef_baruba4, gridpos)
	set_scale(Ef_baruba4, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba4)
	dot_place_unit(barbaroi8,30, 36)
	wait_seq()
	
	on_active(Ef_baruba5)
	local gridpos = get_grid_position(31,34)
	set_pos(Ef_baruba5, gridpos)
	set_scale(Ef_baruba5, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba5)
	dot_place_unit(barbaroi9,31, 34)
	wait_seq()
	
	wait_time(0.2)
	
	on_active(Ef_baruba6)
	local gridpos = get_grid_position(31,36)
	set_pos(Ef_baruba6, gridpos)
	set_scale(Ef_baruba6, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba6)
	dot_place_unit(barbaroi10,31, 36)
	wait_seq()
	
	
	
	wait_time(1.5)

				--//バルバロイ、追加で出現。大量に。
	-- @ギネヴィア	これはちょっとというか…かなりピンチな状況かも？	
	change_face(Guinevere,"Surprise")
	PlayPartVoiceDirect("ギネヴィア","0029")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("EA_014_0110043")
	--close_speech_window()

	-- @ギネヴィア	すいせいさんも早く逃げて！	
	change_face(Guinevere,"Anger")
	--open_speech_window("CHRNAME_GUINEVERE", , nil)
	message("EA_014_0110044")
	close_speech_window()
	dot_reserve_move_unit_seq(magic ,26,35)
	dot_reserve_move_unit_seq(dotDinatan ,25,34)
	exec_parallel_seq()


	-- @星街すいせい	私も一緒に戦います！私の歌が、きっとみんなに力をあげられるから！	
	change_face(Suisei,"Laugh")
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0110045")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")





	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 21, 39,0)
	pbadv_setup_101012_Dinatan_preload(0,true,20,37,0)
	pbadv_setup_101011_Guinevere_preload(0,true,23 ,39 ,0)
	pbadv_setup_101068_Urrie_preload(0,true,22 ,39 ,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true,24 ,39 ,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,1 ,5 ,0)
	character2DFull_Preload(Suisei, "Suisei", 101069001)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	preload_sound("BGM_ADV_Antagonism")
end
