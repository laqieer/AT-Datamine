

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	init_psbattleadv("201010000", "201010000")
	
	change_time_and_weather(1,1)
	
	
	
	
    pbadv_setup_101009_Noir(2,true,33,19,0)
    
     
    pbadv_setup_101012_Dinatan(0,true,31,14,0)
	
	pbadv_setup_101030_Elaine(1,true,30 ,18 ,0)  

	
	dotsolderG= dot_reserve_ally(401005001, 32, 16, 0)
	dotsolder= dot_reserve_ally(401005001, 34, 19, 0)
	dotsolder2= dot_reserve_ally(401006001, 29, 18, 0)
	
	
	
	
	dot_set_weapon(dotsolder, 101010001)
	dot_set_weapon(dotsolderG, 101010001)
	dot_set_weapon(dotsolder2, 101010001)
	
	
	setup_complete_unit()
	
	dot_change_anim(dotsolder,1)
	dot_change_anim(dotsolderG,1)
	dot_change_anim(dotsolder2,1)
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotElaine1, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotsolder, false)
	dot_disp_weapon(dotsolderG, false)
	dot_disp_weapon(dotsolder2, false)
	
	dot_unit_dir(dotsolder, 2)
	dot_unit_dir(dotElaine1, 2)
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(32, 19, 0.0)
	
		Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	
	load_sound("BGM_Battle_AfterDinatan_General1_Start")
end

	



function Play()
	fadein(0)
	Play_start(true)

	-- @ノワール	おい、お前ら無事か？	
	
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0001")
	message("EA_009_02100002")
	close_speech_window()

	-- @男子生徒A	あ、ああ…なんとか大丈夫――あれ？	
	open_speech_window("NPCNAME_0151",nil , nil)
	message("EA_009_02100003")
	close_speech_window()
	dot_change_anim(dotsolderG,0)
	dot_change_anim(dotsolder2,0)
	dot_unit_dir(dotElaine1, 3)

	-- @エレイン	どうかしましたか…？	
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	message("EA_009_02100004")
	close_speech_window()

	-- @男子生徒A	あ、足が――足の感覚が無い立ち上がれない…！	
	open_speech_window("NPCNAME_0151",nil , nil)
	message("EA_009_02100005")
	close_speech_window()

	-- @ノワール	！？	
	change_face(Noir2 , "Surprise")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0028")
	message("EA_009_02100006")
	close_speech_window()
	
	dot_move_unit_seq(dotsolderG ,31,16)
	dot_unit_dir(dotsolder2, 3)
	
	wait_time(0.8)
	dot_move_unit_seq(dotsolder2 ,32,19)
	dot_unit_dir(dotsolder2, 2)
	wait_time(0.5)
	dot_move_unit_seq(dotsolderG ,34,16)
	wait_seq()
	dot_unit_dir(dotsolder2, 3)
	dot_move_unit_seq(dotsolder2 ,31,19)
	dot_change_anim(dotsolderG,6)
	dot_move_knockback(dotsolderG,33, 16,0.4,2)
	wait_time(0.8)
	dot_change_anim(dotsolderG,1)

	-- @男子生徒B	うわあ！め、目が――目が見えない！	
	open_speech_window("NPCNAME_0153",nil , nil)
	message("EA_009_02100007")
	close_speech_window()
	
	dot_move_unit_seq(dotDinatan ,32,16)

	-- @女子生徒B	音がなにも聞こえない…なんで？
	open_speech_window("NPCNAME_0147",nil , nil)
	message("EA_009_02100008")
	close_speech_window()

				--//生徒たち大混乱
	-- @エレイン	せ、先輩…これって…	
	change_face(Elaine1 , "Surprise")
	open_speech_window("CHRNAME_ELAINE",Elaine1 , nil)
	voice_play("VO_101030_sp_0001_3")
	message("EA_009_02100010")
	close_speech_window()

	-- @ノワール	どういうことだ…？足、目、耳…身体の能力を失っている…？	
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0029")
	message("EA_009_02100011")
	--close_speech_window()

	-- @ノワール	…！もしかして――	
	--open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_009_02100012")
	close_speech_window()
	
	dot_unit_dir(dotElaine1, 3)
	dot_unit_dir(dotNoir2, 2)
	
	wait_time(0.6)
	
	move_camera(32, 16, 2.0)
	change_camera_distance(5.0, 2.0)

				--//ノワール、ディナタンを見る
	-- @ディナタン	……！	
	change_face(Dinatan , "Surprise")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("EA_009_02100014")
	close_speech_window()



	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,33,19,0)
    pbadv_setup_101012_Dinatan_preload(0,true,31,14,0)
	pbadv_setup_101030_Elaine_preload(1,true,30 ,18 ,0)
		load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	preload_sound("BGM_Battle_AfterDinatan_General1_Start")
end
