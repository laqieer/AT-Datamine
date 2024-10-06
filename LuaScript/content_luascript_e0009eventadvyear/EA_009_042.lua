

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	init_psbattleadv("201210000", "25010201")
	change_time_and_weather(BattleTime_Sunset,BattleWeather_Shiny)
	
	
	pbadv_setup_101009_Noir(2,true, 20, 14,0)  
	
	pbadv_setup_101012_Dinatan(0,true,19,15,0)
	
	pbadv_setup_101030_Elaine(1,true,21 ,15 ,0)  
	
	pbadv_setup_101031_Lovein(1,true,20 ,15 ,0)  
	
	barbaroi = dot_reserve_enemy(1100, 20, 33, 0)
	magic = dot_reserve_ally(401011001, 20, 7, 0)
	dot_set_weapon(magic, 107010001) 
	
	Tyr = dot_reserve_facility(52, 20, 0, DotDir_Up, 1, true)
	
	barubaB = dot_reserve_ally(201020001, 39, 20, 0)
	dot_set_weapon(barubaB, 104010001)
	
	barbaroi2 = dot_reserve_enemy(1100,39 ,33 , 0)
	barbaroi3 = dot_reserve_enemy(1100,39 ,34 , 0)
	barbaroi4 = dot_reserve_enemy(1100,39 ,35 , 0)
	barbaroi5 = dot_reserve_enemy(49,39 ,36 , 0)
	barbaroi6 = dot_reserve_enemy(49,21 ,36 , 0)
	barbaroi7 = dot_reserve_enemy(49,22 ,36 , 0)
	
	setup_complete_unit()
	
	dot_unit_dir(magic, 2)
	dot_unit_dir(barubaB, 2)
	
	change_camera_distance(8.0, 0.0)

	change_camera_angle(32.0, 0.0)
	
	move_camera(20, 7, 0.0)
	
	Ef_reply= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_reply2= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_reply3= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_power= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_lost= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)

	Ef_changeBri = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)

	on_active(Ef_power)

	local gridpos = get_grid_position(20,7)
	set_pos(Ef_power, gridpos)
	play_particle(Ef_power)

	load_sound("BGM_Battle_AfterDinatan_General1_Start")

end

	



function Play()
	fadein(0)
	Play_start(true)
	
	
	
	wait_time(1.5)

	-- @ノワール	そこまでだ
	change_face(Noir2, "Anger")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_009_0420005")
	close_speech_window()
	
	
	move_camera(20, 11, 1.5)
	
	dot_reserve_move_unit_seq(dotNoir2 ,20, 10)
	dot_reserve_move_unit_seq(dotDinatan ,20,12)
    dot_reserve_move_unit_seq(dotElaine1 ,19,12)
    dot_reserve_move_unit_seq(dotLovein1 ,21,12)
    exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotElaine1, 3)

	-- @魔術師	お前たちは――
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420006")
	--close_speech_window()
	
	on_active(Ef_lost)
	local gridpos = get_grid_position(20,7)
	set_pos(Ef_lost, gridpos)
	play_particle(Ef_lost)
	wait_time(0.5)
	off_active(Ef_power)

	-- @魔術師	そうか。自ら力を捧げにやってきましたか選ばれしもの――継承者であるこの私に
	--open_speech_window("",nil , nil)
	message("EA_009_0420007")
	close_speech_window()

	-- @ノワール	お前が、継承者…？
	open_speech_window("PLAYERNAME_NOIR", Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0028")
	message("EA_009_0420008")
	close_speech_window()

	-- @魔術師	私は継承者として世界を救わねばなりませんそのためには力が必要なのです
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420009")
	close_speech_window()

	-- @ノワール	だから奪ったのか皆から、力を
	open_speech_window("PLAYERNAME_NOIR",Noir2  , nil)
	PlayPartVoiceDirect("ノワール","0016")
	message("EA_009_0420010")
	close_speech_window()

	-- @魔術師	優れた力は継承者が持つべきものあるべきところへ集結させるべきなのです
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420011")
	close_speech_window()

	-- @ラヴェイン	貴方のせいでたくさんの人間が苦しみましたバルバロイに襲われて傷ついた人だっています
	change_face(Lovein1, "Anger")
	open_speech_window("CHRNAME_LOVEIN2",Lovein1 , nil)
	PlayPartVoiceDirect("ラヴェイン","0015")
	message("EA_009_0420012")
	--close_speech_window()

	-- @ラヴェイン	それが正しいことだとでも…？
	--open_speech_window("CHRNAME_LOVEIN2", , nil)
	message("EA_009_0420013")
	close_speech_window()

	-- @魔術師	世界を救うためですから世界を救うためには何を犠牲にしても許されます
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420014")
	--close_speech_window()

	-- @魔術師	継承者にはそれが許されるのです世界を救う選ばれし存在なのですから
	--open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420015")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	-- @ノワール	…！お前――
	open_speech_window("PLAYERNAME_NOIR",Noir2  , nil)
	PlayPartVoiceDirect("ノワール","0015")
	message("EA_009_0420016")
	close_speech_window()

	-- @エレイン	――ふざけないで！！！
	change_face(Elaine1, "Anger")
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0420017")
	close_speech_window()
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotLovein1, 2)
	
	on_active(Ef_reply)
	on_active(Ef_reply2)
	on_active(Ef_reply3)
	
	local gridpos = get_grid_position(20,4)
	gridpos[2] = 3.0
	set_pos(Ef_reply, gridpos)
	play_particle(Ef_reply3)
	
	local gridpos = get_grid_position(22,7)
	gridpos[2] = 2.8
	set_pos(Ef_reply2, gridpos)
	play_particle(Ef_reply3)
	
	wait_time(1.0)

	change_camera_distance(5.0, 1.5)
	dot_move_unit_seq(dotNoir2 ,21,10)
	wait_seq()
	dot_unit_dir(dotNoir2, 2)
	wait_time(0.5)
	dot_reserve_move_unit_seq(dotDinatan ,20,11)
    dot_reserve_move_unit_seq(dotElaine1 ,19,11)
    exec_parallel_seq()
	wait_seq()

	

	bgm_play("BGM_Battle_AfterDinatan_General1_Start")
	-- @エレイン	「なにが継承者よ。なにが世界を救うための力よ勝手なこと言わないで」
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0420020")
	--close_speech_window()

	-- @エレイン	「兄さんたちがどんなに辛い思いをしてるかなにも知らないくせに！！！」
	--open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	PlayPartVoiceDirect("エレイン_005","0018")
	message("EA_009_0420021")
	close_speech_window()

	-- @ラヴェイン	え、エレイン…？
	change_face(Lovein1, "Surprise")
	open_speech_window("CHRNAME_LOVEIN2",Lovein1 , nil)
	message("EA_009_0420022")
	close_speech_window()
	
	

	-- @エレイン	ディナタンさん、次の手紙を！！
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0420023")
	close_speech_window()

	-- @ディナタン	！！
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_009_0420024")
	close_speech_window()

			
	-- @エレイン	「世界を救うためならなにを犠牲にしてもいいなんて、そんなわけないでしょう！？」
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	PlayPartVoiceDirect("エレイン_005","0015")
	message("EA_009_0420026")
	--close_speech_window()

	-- @エレイン	「だって兄さんが守りたい世界は大切な人が――皆がいる世界なんだから」
	--open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0420027")
	close_speech_window()

	-- @ノワール	…！
	change_face(Noir2, "Normal")
	open_speech_window("PLAYERNAME_NOIR",Noir2  , nil)
	message("EA_009_0420028")
	close_speech_window()

	-- @エレイン	ディナタンさん、次の手紙を！
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	PlayPartVoiceDirect("エレイン_005","0035")
	message("EA_009_0420029")
	close_speech_window()

	-- @ディナタン	！！
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_009_0420030")
	close_speech_window()

	-- @エレイン	「継承者だからって、そんなの受け止められない受け止めなくたっていい」
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0420031")
	--close_speech_window()

	-- @エレイン	「大切な人を笑顔にできない苦しみも大切な人に上手く寄り添えない悲しさも」
	--open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0420032")
	--close_speech_window()

	-- @エレイン	「継承者だからなんでも背負わなきゃなんてそんなの絶対おかしいのに」
	change_face(Elaine1, "Sad")
	--open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	PlayPartVoiceDirect("エレイン_005","0021")
	message("EA_009_0420033")
	close_speech_window()

	-- @ノワール	ディナタン…
	change_face(Noir2, "Sad")
	open_speech_window("PLAYERNAME_NOIR",Noir2  , nil)
	voice_play("VO_101009_sp_0003_3")
	message("EA_009_0420034")
	close_speech_window()

	-- @ディナタン	～～～！！
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_009_0420035")
	close_speech_window()
	
	dot_reserve_move_unit_seq(dotDinatan ,20,10)
    dot_reserve_move_unit_seq(dotElaine1 ,19,10)
    exec_parallel_seq()
	wait_seq()
	move_camera(20, 10, 2.0)

			
	-- @エレイン	「…それでも、兄さんは戦うんだから――それが、継承者なんだから。だから…」
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_0420037")
	close_speech_window()

	open_cutin(2, 1)
	
	on_cutin(1, Dinatan, "Anger", nil)
	on_cutin(2, Elaine1, "Anger", nil)
			
	-- @エレイン	あなたは継承者なんかじゃない
	open_speech_window("CHRNAME_ELAINE",nil , nil)
	PlayPartVoiceDirect("エレイン_005","0020")
	message("EA_009_0420039")
	--close_speech_window()
	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotLovein1, 3)

	-- @エレイン	あなたは――偽物です
	--open_speech_window("CHRNAME_ELAINE",nil1 , nil)
	message("EA_009_0420040")
	close_speech_window()
	
	close_cutin()
	wait_time(0.5)
	
	change_camera_distance(8.0, 1.5)

	-- @魔術師	な…なんだ？なにを言っているんだ？継承者である私に向かって…
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420041")
	--close_speech_window()

	-- @魔術師	私は世界を救う選ばれし存在…私は、継承者なんですよ…？なのに…
	--open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420042")
	close_speech_window()

	-- @ラヴェイン	…ところで、貴方は本当に継承者なのですか？
	change_face(Lovein1, "Anger")
	open_speech_window("CHRNAME_LOVEIN2",Lovein1 , nil)
	PlayPartVoiceDirect("ラヴェイン","0025")
	message("EA_009_0420043")
	close_speech_window()
	
	dot_move_unit_seq(magic ,20,6)
	wait_seq()

	dot_unit_dir(magic, 2)
	
	move_camera(20, 6, 1.0)
	
	wait_time(1.0)
	
	

	-- @魔術師	…は。なにを馬鹿なことを当然じゃありませんか！
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420044")
	--close_speech_window()

	-- @魔術師	その証拠に私には力がある！バルバロイを従える力が！！
	--open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420045")
	close_speech_window()
	
	--//魔術師の周りに現れるバルバロイ
	

	on_active(Ef_baruba2)
	local gridpos = get_grid_position(18,8)
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2)
	dot_place_unit(barbaroi,18, 8)
	wait_seq()
	
	on_active(Ef_baruba3)
	local gridpos = get_grid_position(22,8)
	set_pos(Ef_baruba3, gridpos)
	set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3)
	dot_place_unit(barbaroi3,22, 8)
	wait_seq()
	
	wait_time(0.2)
	
	on_active(Ef_baruba4)
	local gridpos = get_grid_position(15,6)
	set_pos(Ef_baruba4, gridpos)
	set_scale(Ef_baruba4, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba4)
	dot_place_unit(barbaroi4,15, 6)
	wait_seq()
	
	on_active(Ef_baruba5)
	local gridpos = get_grid_position(16,6)
	set_pos(Ef_baruba5, gridpos)
	set_scale(Ef_baruba5, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba5)
	dot_place_unit(barbaroi5,16, 6)
	wait_seq()
	
	wait_time(0.2)
	
	on_active(Ef_baruba6)
	
	local gridpos = get_grid_position(24,6)
	set_pos(Ef_baruba6, gridpos)
	set_scale(Ef_baruba6, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba6)
	dot_place_unit(barbaroi6,24, 6)
	wait_seq()
	
	on_active(Ef_baruba7)
	local gridpos = get_grid_position(25,6)
	set_pos(Ef_baruba7, gridpos)
	set_scale(Ef_baruba7, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba7)
	dot_place_unit(barbaroi7,25, 6)
	wait_seq()
	
	
	wait_time(1.5)
	
	on_active(Ef_changeBri)
	local gridpos = get_grid_position(20,6)
	set_pos(Ef_changeBri , gridpos)
	set_scale(Ef_changeBri, {1.6, 1.6, 1.6})
	play_particle(Ef_changeBri )
	wait_time(1.2)
	dot_place_unit(barubaB,19, 4)
	dot_disp_unit(magic, false)
	dot_disp_unit(barubaB, true)
	wait_seq()
	dot_unit_dir(barubaB, 2)

	wait_time(1.0)
	
	
			
	-- @ラヴェイン	…どうやらかなり末期のようです
	change_face(Lovein1, "Sad")
	open_speech_window("CHRNAME_LOVEIN2",Lovein1 , nil)
	PlayPartVoiceDirect("ラヴェイン","0007")
	message("EA_009_0420047")
	--close_speech_window()

	-- @ラヴェイン	『継承者』という存在に執着しながらそれがなにを為す存在かも忘れているのですから
	--open_speech_window("CHRNAME_LOVEIN2",Lovein1 , nil)
	message("EA_009_0420048")
	close_speech_window()
	
	

	-- @魔術師	私は継承者だ。世界を救うのだ
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420049")
	--close_speech_window()

	-- @魔術師	その私に仇なすものは世界の敵だこの場で殺してやる、世界のために！！
	--open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0420050")
	close_speech_window()

	

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 14,0)
	pbadv_setup_101012_Dinatan_preload(0,true,19,15,0)
	pbadv_setup_101030_Elaine_preload(1,true,21 ,15 ,0)
	pbadv_setup_101031_Lovein_preload(1,true,20 ,15 ,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	preload_sound("BGM_Battle_AfterDinatan_General1_Start")
end
