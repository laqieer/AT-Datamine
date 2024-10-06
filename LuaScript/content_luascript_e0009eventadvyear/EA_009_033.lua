Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201000002","201000002")
	change_time_and_weather(1,7)
	



	pbadv_setup_101009_Noir(2,true, 17, 21,0)  
	
	pbadv_setup_101012_Dinatan(0,true,17,22,0)
	
	pbadv_setup_101030_Elaine(1,true,16 ,23 ,0)  
	
	pbadv_setup_101031_Lovein(1,true,16 ,24 ,0) 
	
	magic = dot_reserve_ally(401011001, 10, 23, 0)
	dot_set_weapon(magic, 107010001) 
	
	barbaroi1=dot_reserve_enemy(49,21,21,0)
	barbaroi2=dot_reserve_enemy(49,22,20,0)
	barbaroi3=dot_reserve_enemy(49,24,21,0)
	barbaroi4=dot_reserve_enemy(49,25,20,0)
	barbaroi5=dot_reserve_enemy(49,22,23,0)
	barbaroi6=dot_reserve_enemy(1,23,22,0)
	barbaroi7=dot_reserve_enemy(1,24,23,0)
	barbaroi8=dot_reserve_enemy(1,25,22,0)
	barbaroi9=dot_reserve_enemy(1,18,21,0)
	barbaroi10=dot_reserve_enemy(1,24,24,0)
	
	
	
	setup_complete_unit()
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(33.0,0.0)

	
	
	move_camera(18,23,0.0)
	
	Ef_power= load_particle("content_effect3d_common_common", "Ef_C_Mag_R_Cha01", false, true)
	Ef_WarpOut = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut3 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut4 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut5 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut6 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut7 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut8 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut9 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut10 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut11 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	
end





function Play()
	fadein(0)
	Play_start(true)
	
	wait_seq()
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(barbaroi9,6)
	dot_play_particle_unit(barbaroi9,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.4)
	dot_dying_unit(barbaroi9)
	wait_seq()
	
	wait_time(0.5)
	
	dot_change_anim(dotNoir2,0)

	move_camera(18,23,1.0)
	
	wait_time(0.5)
	dot_reserve_move_unit_seq(barbaroi1 ,20,21)
	dot_reserve_move_unit_seq(barbaroi2 ,21,20)
	dot_reserve_move_unit_seq(barbaroi3 ,23,21)
	dot_reserve_move_unit_seq(barbaroi4 ,24,20)
	dot_reserve_move_unit_seq(barbaroi5 ,21,23)
	dot_reserve_move_unit_seq(barbaroi6 ,22,22)
	dot_reserve_move_unit_seq(barbaroi7 ,23,23)
	dot_reserve_move_unit_seq(barbaroi8 ,24,22)
	dot_reserve_move_unit_seq(barbaroi10 ,23,24)
    exec_parallel_seq()
	wait_seq()
	


	-- @ノワール	くっ…ずいぶん数が多いな――皆、油断するなよ――！？	
	change_face(Noir2, "Serious")
	open_speech_window("PLAYERNAME_NOIR",Noir2, nil)
	PlayPartVoiceDirect("ノワール","0015")
	message("EA_009_0330003")
	close_speech_window()
	
	dot_move_unit_seq(magic ,10,21)
	
	on_active(Ef_power)

	local gridpos = get_grid_position(11,21)
	gridpos[2] = 0.4
	set_scale(Ef_power, {0.8, 0.8, 0.8})
	set_pos(Ef_power, gridpos)
	play_particle(Ef_power)
	
	wait_time(1.5)
	
	dot_unit_dir(dotNoir2, 2)
	move_camera(13,23,1.5)
	wait_time(1.5)
	

				--//ノワール、怪しい魔術師が力を使おうとしている（光などの演出）のを見つける
				--//ノワール以外は魔術師に背を向けており気づいていない
	-- @魔術師	どれにしようか――	
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0330006")
	close_speech_window()

	-- @ノワール	！――皆、気を付けろ！後ろだ！	
	change_face(Noir2, "Serious")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_009_0330007")
	close_speech_window()
	
	dot_unit_dir(dotDinatan, 2)
	dot_unit_dir(dotElaine1, 2)
	dot_unit_dir(dotLovein1, 2)

	-- @全員	！？	
	open_speech_window("NPCNAME_0394",nil , nil)
	message("EA_009_0330008")
	close_speech_window()
	
	stop_particle(Ef_power)

	-- @魔術師	チッ…気づかれたか	
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0330009")
	close_speech_window()
	
	
	
	dot_move_unit_seq(magic ,11,21)
	dot_move_unit_seq(magic ,14,21)
	dot_move_unit_seq(magic ,14,22)
	
	move_camera(14,23,1.5)
	
	wait_time(1.5)
	
	dot_move_unit_seq(dotDinatan,16,22)

	-- @ディナタン	！！！	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_009_0330010")
	close_speech_window()
	
	

				--//ディナタン、エレインに手紙を渡す
				--//疑似バトルADVなので上記の演出は不要。ディナタンがエレインに近づくくらいさせてもらえると嬉しいです。
	-- @エレイン	…！あの人が、ディナタンさんが声を失ったとき近くにいた怪しい魔術師なんですか！？	
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	PlayPartVoiceDirect("エレイン","0028")
	message("EA_009_0330013")
	close_speech_window()

	-- @ノワール	なんだって！？	
	change_face(Noir2, "Anger")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0028")
	message("EA_009_0330014")
	close_speech_window()

	-- @魔術師	ああ、貴方でしたか	
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0330015")
	--close_speech_window()

	-- @魔術師	記憶力もなかなかのようですね声よりもそちらを奪うべきでしたでしょうか	
	--open_speech_window("",nil , nil)
	message("EA_009_0330016")
	close_speech_window()

	-- @ノワール	お前がディナタンの…学園の皆の力を奪ったのか！？	
	change_face(Noir2, "Serious")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0015")
	message("EA_009_0330017")
	close_speech_window()

	-- @魔術師	だったらどうします？	
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0330018")
	close_speech_window()

	-- @ノワール	決まってるだろう…！？盗んだものは返してもらう！！	
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0016")
	message("EA_009_0330019")
	close_speech_window()

	-- @魔術師	盗んだとは心外ですね力はあるべきところへ集結させるべき	
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0330020")
	--close_speech_window()

	-- @魔術師	私は正しいことをしているんです私は世界を救うんですから	
	--open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0330021")
	close_speech_window()

	-- @ノワール	なにをいって――	
	change_face(Noir2, "Surprise")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_009_0330022")
	close_speech_window()

	-- @魔術師	…とはいえ、この状況はさすがに不利ですねいったん退くとしましょう	
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0330023")
	close_speech_window()
	
	

	-- @ノワール	待て！	
	change_face(Noir2, "Anger")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0015")
	message("EA_009_0330024")
	close_speech_window()
	
	
	dot_move_unit_seq(dotNoir2,15,22)
	wait_seq()
	dot_unit_dir(dotNoir2, 2)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.2)
	
	on_active(Ef_WarpOut) 

	local gridpos = get_grid_position(14, 23) 
	set_pos(Ef_WarpOut, gridpos)
	play_particle(Ef_WarpOut)
	
	dot_disp_unit(magic,false)
	
	wait_time(0.8)
	
	dot_change_anim(dotNoir2,0)
	
	move_camera(20,23,2.0)
	wait_time(2.0)
	
	
	on_active(Ef_WarpOut2) 

	local gridpos = get_grid_position(20, 21) 
	set_pos(Ef_WarpOut2, gridpos)
	play_particle(Ef_WarpOut2)
	
	on_active(Ef_WarpOut11) 

	local gridpos = get_grid_position(21, 20) 
	set_pos(Ef_WarpOut11, gridpos)
	play_particle(Ef_WarpOut11)
	
	on_active(Ef_WarpOut3) 

	local gridpos = get_grid_position(23, 21) 
	set_pos(Ef_WarpOut3, gridpos)
	play_particle(Ef_WarpOut3)
	
	on_active(Ef_WarpOut4) 

	local gridpos = get_grid_position(24, 20) 
	set_pos(Ef_WarpOut4, gridpos)
	play_particle(Ef_WarpOut4)
	
	on_active(Ef_WarpOut5) 

	local gridpos = get_grid_position(21, 23) 
	set_pos(Ef_WarpOut5, gridpos)
	play_particle(Ef_WarpOut5)
	
	on_active(Ef_WarpOut6) 

	local gridpos = get_grid_position(22, 22) 
	set_pos(Ef_WarpOut6, gridpos)
	play_particle(Ef_WarpOut6)
	
	on_active(Ef_WarpOut7) 

	local gridpos = get_grid_position(23, 23) 
	set_pos(Ef_WarpOut7, gridpos)
	play_particle(Ef_WarpOut7)
	
	on_active(Ef_WarpOut8) 

	local gridpos = get_grid_position(24, 22) 
	set_pos(Ef_WarpOut8, gridpos)
	play_particle(Ef_WarpOut8)
	
	on_active(Ef_WarpOut10) 

	local gridpos = get_grid_position(23, 24) 
	set_pos(Ef_WarpOut10, gridpos)
	play_particle(Ef_WarpOut10)
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)
	dot_disp_unit(barbaroi8, false)
	dot_disp_unit(barbaroi9, false)
	dot_disp_unit(barbaroi10, false)
	
	
	dot_unit_dir(dotDinatan, 3)
	dot_unit_dir(dotElaine1, 3)
	dot_unit_dir(dotLovein1, 3)
	
	
	wait_time(1.0)
	
	move_camera(17,23,1.0)
	
	dot_move_unit_seq(dotElaine1 ,16,23)
	wait_time(0.5)
	dot_unit_dir(dotElaine1, 2)
	wait_time(0.7)
	dot_move_unit_seq(dotElaine1 ,17,23)
	wait_time(0.8)
	dot_unit_dir(dotElaine1, 2)
	
	
	
	
	
	
	
	wait_time(1.0)

				--//魔術師とバルバロイ、魔法でその場から消える
	-- @エレイン	今のは…転移魔法？	
	change_face(Elaine1, "Surprise")
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0330026")
	close_speech_window()

				--//マーリンが使っていたもののかなり下位の魔法をイメージ。そんな遠くに行けない
	-- @ラヴェイン・セクエンス	どうやら、魔術師であることは間違いないようですね	
	open_speech_window("CHRNAME_LOVEIN2",Lovein1 , nil)
	PlayPartVoiceDirect("ラヴェイン","0007")
	message("EA_009_0330028")
	close_speech_window()

	-- @エレイン	じゃあ、やっぱりあの人が『力を奪う魔術師』…！？	
	change_face(Elaine1, "Anger")
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0330029")
	close_speech_window()

	-- @ディナタン	………	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_009_0330030")
	close_speech_window()

	-- @ノワール	…あるべきところへ集結させる?いったいどういう意味だ…？	
	change_face(Noir2, "Sad")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_009_0330031")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 17, 21,0)
	pbadv_setup_101012_Dinatan_preload(0,true,17,22,0)
	pbadv_setup_101030_Elaine_preload(1,true,16 ,23 ,0)
	pbadv_setup_101031_Lovein_preload(1,true,16 ,24 ,0)
	load_particle_preload("content_effect3d_common_common", "Ef_C_Mag_R_Cha01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
end
