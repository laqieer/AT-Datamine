
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	init_psbattleadv("201000002", "201000002")
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101009_Noir(2,true, 23, 33,0)  
	
	pbadv_setup_101012_Dinatan(0,true,22,33,0)
	
	pbadv_setup_101011_Guinevere(0,true,22 ,32 ,0)  
	
	pbadv_setup_101068_Urrie(0,true,20 ,15 ,0)  
	
	pbadv_setup_101016_Gwenhwymawr(1,true,23 ,32 ,0)
	
	Suisei = set_chara_unknown()
	character2DFull(Suisei, "Suisei", 101069001 )
	
	
	magic = dot_reserve_ally(101069001, 20, 33, 0)
	dot_set_weapon(magic, 107010001) 
	
	setup_complete_unit()
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotDinatan, 2)
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGwenhwymawr1, 2)
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr1, false)
	dot_disp_weapon(dotUrrie, false)
	dot_disp_weapon(magic, false)
	
	change_camera_distance(8.0, 0.0)

	change_camera_angle(37.0, 0.0)
	
	move_camera(21, 33, 0.0)
	
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_Fog2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_Fog3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_EnemyDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)

end

	



function Play()
	-- Animation処理があるのでFadeより先に実行
	dateIn()
	fadein(0)
	Play_start(true)
	
	dot_move_unit_seq(dotUrrie ,21,31)
	wait_seq()
	
	-- @ウレリー	バルバロイを全部倒したの！？さすがノワールくんにギネヴィア様だね
	change_face(Urrie, "Smile")
	PlayPartVoiceDirect("ウレリー","0006")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0410004")
	close_speech_window()

	-- @ギネヴィア	心強い応援があったからね
	change_face(Guinevere, "Smile")
	PlayPartVoiceDirect("ギネヴィア","0012")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("EA_014_0410005")
	close_speech_window()

	-- @星街すいせい	そんな！私は大したことはしてないですみなさんの頑張りの成果ですよ
	change_face(Suisei, "Smile")
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0410006")
	close_speech_window()

	-- @ディナタン	ウレリーさんほかのみなさんは無事ですか！？
	PlayPartVoiceDirect("ディナタン","0002")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_014_0410007")
	close_speech_window()

	-- @ウレリー	うん。<ruby=ライヴ>野外音楽会</ruby>に参加予定だったアーティストさんたちも避難できてたよ
	change_face(Urrie, "Smile")
	PlayPartVoiceDirect("ウレリー","0012")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0410008")
	close_speech_window()

	dot_unit_dir(dotUrrie, 2)
	wait_time(0.5)		
			
	-- @ウレリー	挨拶が遅れてしまってごめんなさいえっと…
	change_face(Urrie, "Sad")
	PlayPartVoiceDirect("ウレリー","0003")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0410011")
	close_speech_window()

	-- @ディナタン	星街すいせいさんです
	change_face(Dinatan, "Smile")
	PlayPartVoiceDirect("ディナタン","0038")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_014_0410012")
	close_speech_window()

	-- @ウレリー	…？参加アーティストの<ruby=リスト>一覧</ruby>に名前あったかな～
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0410013")
	close_speech_window()

			
	-- @星街すいせい	えっと、それは、その…
	change_face(Suisei, "Sad")
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0410015")
	close_speech_window()

	-- @ギネヴィア	ねえ。またバルバロイが現れるかもしれないしわたしたちも街に戻りましょ
	change_face(Guinevere, "Normal")
	PlayPartVoiceDirect("ギネヴィア","0002")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("EA_014_0410016")
	--close_speech_window()

	-- @ギネヴィア	で、戻ったらアーサーに掛け合ってみるわね学園の講堂を音楽会の会場に使えないかって
	change_face(Guinevere, "Smile")
	PlayPartVoiceDirect("ギネヴィア","0010")
	--open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("EA_014_0410017")
	close_speech_window()
	
	dot_unit_dir(dotUrrie, 3)

	-- @ウレリー	あ、それ、グッドアイデア！
	change_face(Urrie, "Smile")
	PlayPartVoiceDirect("ウレリー","0007")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0410018")
	close_speech_window()

	-- @ギネヴィア	でしょでしょ～？落ち着いた状態ですいせいさんの歌を聴きましょ。にししっ♪
	PlayPartVoiceDirect("ギネヴィア","0012")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("EA_014_0410019")
	close_speech_window()
	
	dot_unit_dir(magic, 2)
	wait_time(0.7)
	dot_unit_dir(magic, 3)
	
	wait_time(0.8)
	
	dot_move_unit_seq(magic ,19,33)

			
	-- @星街すいせい	ごめんなさい…私、もうすぐ帰らないといけないんです
	change_face(Suisei, "Sad")
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0410021")
	close_speech_window()
	
	dot_unit_dir(dotUrrie, 2)

	-- @ウレリー	えー？ワタシ、歌を聴けてないのに！ゆっくりしていってほしいなあ
	change_face(Urrie, "Surprise")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0410022")
	close_speech_window()
	
	dot_unit_dir(magic, 3)

	-- @星街すいせい	本当にごめんなさい！
	open_speech_window("CHRNAME_SUISEI",Suisei , nil)
	message("EA_014_0410023")
	--close_speech_window()

	-- @星街すいせい	でも、みんなと一緒にいられて楽しかったですすごく素敵な時間を過ごせました
	change_face(Suisei, "Smile")
	--open_speech_window("CHRNAME_SUISEI",Noir2 , nil)
	message("EA_014_0410024")
	--close_speech_window()

	-- @星街すいせい	これからも応援してます頑張ってくださいね！
	--open_speech_window("CHRNAME_SUISEI",Noir2 , nil)
	message("EA_014_0410025")
	close_speech_window()

	dot_move_unit_seq(magic ,12,35)
	wait_seq()
			
	-- @ウレリー	行っちゃった…友達になれるかと思ったのにな
	change_face(Urrie, "Sad")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0410028")
	close_speech_window()

	-- @ギネヴィア	うん、わたしももっと元気をもらいたかったな
	change_face(Guinevere, "Sad")
	PlayPartVoiceDirect("ギネヴィア","0008")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("EA_014_0410029")
	close_speech_window()
	

	
	wait_time(1.5)
	
	dot_unit_dir(dotGuinevere, 3)
			
	-- @ギネヴィア	さて…帰ろっか
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("EA_014_0410031")
	close_speech_window()
	
	dot_unit_dir(dotUrrie, 3)

	-- @ウレリー	ですね
	change_face(Urrie, "Smile")
	open_speech_window("CHRNAME_URRIE",Urrie , nil)
	message("EA_014_0410032")
	close_speech_window()
	
	
	
	dot_reserve_move_unit_seq(dotUrrie ,20,15)
	dot_reserve_move_unit_seq(dotGuinevere ,20,16)
	dot_reserve_move_unit_seq(dotGwenhwymawr1 ,21,16)
	dot_reserve_move_unit_seq(dotNoir2 ,21,15)
    exec_parallel_seq()
	
	wait_seq()

	
	dot_move_unit_seq(dotDinatan ,21,33)
	
	change_camera_distance(5.0, 2.0)

	
	move_camera(21, 33, 2.0)
	
	-- @ディナタン	歌を聴いた人を元気にする、か…
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_014_0410034")
	--close_speech_window()

	-- @ディナタン	私にもできたらいいなそんなことが…
	change_face(Dinatan, "Smile")
	PlayPartVoiceDirect("ディナタン","0010")
	--open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_014_0410035")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_LongFade")



	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 23, 33,0)
	pbadv_setup_101012_Dinatan_preload(0,true,22,33,0)
	pbadv_setup_101011_Guinevere_preload(0,true,22 ,32 ,0)
	pbadv_setup_101068_Urrie_preload(0,true,20 ,15 ,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,23 ,32 ,0)
	character2DFull_Preload(Suisei, "Suisei", 101069001)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
end
