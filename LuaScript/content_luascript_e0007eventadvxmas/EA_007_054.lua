

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	

	
	init_psbattleadv("201010003", "201010003")
	
	change_time_and_weather(1, 3)
	
	
	
    pbadv_setup_101009_Noir(2,true,16,13,0)
	
	Clarice = set_chara_unknown()
	character2DFull(Clarice, "Clarice", 101023003 )
	dotClarice  = dot_reserve_ally(101023003, 16, 15, 0)
	
	dot_set_weapon(dotClarice, 106010001)
	
	pbadv_setup_101022_Mordred(0,true,20,25,0)
	
	pbadv_setup_101013_Gawain(0,true,14,25,0)
	
	
	pbadv_setup_101018_Ragnar(0,true,13,25,0)
	
	Kair  = dot_reserve_ally(401015001, 15, 14, 0)
	
	dot_set_weapon(Kair, 101010001)
	
	KairOG  = dot_reserve_ally(401021001, 19, 14, 0)
	
	
	dot_set_weapon(KairOG, 101010001)
	

	
	barbaroiR    = dot_reserve_ally(401040001, 20,20, 0)
	barbaroi2R   = dot_reserve_ally(401040001, 19,20, 0)
	barbaroi3R   = dot_reserve_ally(401040001, 19,21, 0)
	barbaroi4R    = dot_reserve_ally(401040001, 18,21, 0)
	barbaroi5R   = dot_reserve_ally(401040001, 18,22, 0)
	
	barbaroi    = dot_reserve_ally(401040001, 14,20, 0)
	barbaroi2   = dot_reserve_ally(401040001, 15,20, 0)
	barbaroi3   = dot_reserve_ally(401040001, 15,21, 0)
	barbaroi4    = dot_reserve_ally(401040001, 16,21, 0)
	barbaroi5   = dot_reserve_ally(401040001, 16,22, 0)
	
	
	barbaroi6   = dot_reserve_ally(401040001, 28,13, 0)
	barbaroi7   = dot_reserve_ally(401040001, 28,14, 0)
	barbaroi8   = dot_reserve_ally(401040001, 29,13, 0)
	barbaroi9   = dot_reserve_ally(401040001, 29,14, 0)
	
	dot_set_weapon(barbaroi, 101010001)
	dot_set_weapon(barbaroi2, 101010001)
	dot_set_weapon(barbaroi3, 101010001)
	dot_set_weapon(barbaroi4, 101010001)
	dot_set_weapon(barbaroi5, 101010001)
	
	dot_set_weapon(barbaroiR, 101010001)
	dot_set_weapon(barbaroi2R, 101010001)
	dot_set_weapon(barbaroi3R, 101010001)
	dot_set_weapon(barbaroi4R, 101010001)
	dot_set_weapon(barbaroi5R, 101010001)
	
	dot_set_weapon(barbaroi6, 101010001)
	dot_set_weapon(barbaroi7, 101010001)
	dot_set_weapon(barbaroi8, 101010001)
	dot_set_weapon(barbaroi9, 101010001)
	
	setup_complete_unit()

	dot_unit_dir(KairOG, 2)
	dot_disp_weapon(KairOG, false)
	dot_disp_weapon(Kair, false)
	
	change_camera_distance(7.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(17, 14, 0.0)

	Ef_Shockwave01_0=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	Ef_Shockwave01_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)

	load_sound("BGM_Battle_Candlelight")
	
	
end





function Play()
	fadein(0)
	Play_start(true)

	-- @カイルの叔父	私は望む者に<ruby=プレゼントして>望むだけの商品を与えて</ruby>いるだけだ！	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540004")
	--close_speech_window()

				--//「望むだけの商品を与えて」ルビ「プレゼントして」
	-- @カイルの叔父	ローマ軍残党が、ログレスの滅亡を望むなら商売人としてソレを<ruby=プレゼント>与えようと</ruby>するだけだ！	
	--open_speech_window("NPCNAME_0389", , nil)
	message("EA_007_0540006")
	close_speech_window()

				--//「与えようと」ルビ「プレゼント」
	-- @カイル	叔父さん…！	
	open_speech_window("NPCNAME_0386",nil , nil)
	message("EA_007_0540008")
	close_speech_window()

	-- @ノワール	どんな結果になるかわかっているのか	
	change_face(Noir2, "Anger")
	PlayPartVoiceDirect("ノワール","0016")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_007_0540009")
	close_speech_window()

	-- @カイルの叔父	<ruby=プレゼント>他者が欲しがるものを与えること</ruby>になんの迷いもない！！	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540010")
	--close_speech_window()

				--//「他者が欲しがるものを与えること」ルビ「プレゼント」
	-- @カイルの叔父	あとのことなど知らぬわ！！	
	--open_speech_window("NPCNAME_0389", , nil)
	message("EA_007_0540012")
	close_speech_window()
	
	move_camera(13, 18, 2.0)
	wait_time(1.0)
	dot_reserve_move_unit_seq(barbaroi ,12,16)
	dot_reserve_move_unit_seq(barbaroi2 ,12,17)
	dot_reserve_move_unit_seq(barbaroi3 ,13,18)
	dot_reserve_move_unit_seq(barbaroi4 ,14,18)
	dot_reserve_move_unit_seq(barbaroi5 ,15,18)
    exec_parallel_seq()
    wait_seq()

	
	dot_unit_dir(barbaroi, 3)
	dot_unit_dir(barbaroi2, 3)
	dot_unit_dir(barbaroi3, 3)
	dot_unit_dir(barbaroi4, 3)
	dot_unit_dir(barbaroi5, 3)
	dot_unit_dir(dotNoir2, 2)
	
	wait_time(1.0)
	move_camera(21, 18, 2.0)
	dot_unit_dir(dotNoir2, 3)
	dot_reserve_move_unit_seq(barbaroiR ,22,16)
	dot_reserve_move_unit_seq(barbaroi2R ,22,17)
	dot_reserve_move_unit_seq(barbaroi3R ,19,18)
	dot_reserve_move_unit_seq(barbaroi4R ,20,18)
	dot_reserve_move_unit_seq(barbaroi5R ,21,18)
    exec_parallel_seq()
    wait_seq()

    
    dot_unit_dir(barbaroiR, 2)
	dot_unit_dir(barbaroi2R, 2)
	dot_unit_dir(barbaroi3R, 2)
	dot_unit_dir(barbaroi4R, 2)
	dot_unit_dir(barbaroi5R, 2)
    dot_unit_dir(Kair, 2)
	wait_time(1.0)
	 dot_unit_dir(Kair, 3)
	dot_reserve_move_unit_seq(barbaroi6 ,21,13)
	dot_reserve_move_unit_seq(barbaroi7 ,21,14)
	dot_reserve_move_unit_seq(barbaroi8 ,22,13)
	dot_reserve_move_unit_seq(barbaroi9 ,22,14)
    exec_parallel_seq()
    wait_seq()

	move_camera(17, 14, 1.5)
	
				--//ノワールたちの周囲にローマ軍残党の伏兵が大勢現れる。
	-- @ノワール	ローマ軍の伏兵…！	
	change_face(Noir2, "Anger")
	PlayPartVoiceDirect("ノワール","0021")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_007_0540014")
	close_speech_window()

	-- @カイルの叔父	祭りで騒ぐ民どもを殺せ！！	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540015")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
				--//ガウェイン
	-- @？？？	騒ぎと聞いちゃあ──	
	open_speech_window("CHRNAME_NAMELES",nil , nil)
	PlayPartVoiceDirect("ガウェイン","0048")
	message("EA_007_0540017")
	close_speech_window()
	
	move_camera(13, 18, 2.0)
	
	dot_reserve_move_unit_seq(dotGawain ,15,19)
	dot_reserve_move_unit_seq(dotRagnar ,13,19)
    exec_parallel_seq()
    wait_seq()
    
    dot_unit_dir(dotGawain, 0)	
	dot_unit_dir(dotRagnar, 0)
	
	wait_time(0.1)
	
	wait_seq()
	dot_change_anim(dotRagnar,3)
	dot_play_particle_unit(dotRagnar,"Ef_C_Gun_N_Atk01",3,true)
	dot_change_anim(dotGawain,3)
	dot_play_particle_unit(dotGawain,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	
	wait_time(0.1)
	
	on_active(Ef_Shockwave01_0)
	on_active(Ef_Shockwave01_1)
	on_active(Ef_Shockwave01_2)
	
	


	local gridpos=get_grid_position(13,18)
	set_pos(Ef_Shockwave01_0,gridpos)
	play_particle(Ef_Shockwave01_0)
	dot_change_anim(barbaroi3,6)
	
	local gridpos=get_grid_position(14,18)
	set_pos(Ef_Shockwave01_1,gridpos)
	play_particle(Ef_Shockwave01_1)
	dot_change_anim(barbaroi4,6)
	
	local gridpos=get_grid_position(15,18)
	set_pos(Ef_Shockwave01_2,gridpos)
	play_particle(Ef_Shockwave01_2)
	dot_change_anim(barbaroi5,6)
	
	se_play("SE_ADV_MA_01A900_33_Axe_Impact")
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Spe01",3,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_change_anim(barbaroi3,6)
	dot_change_anim(barbaroi4,6)
	dot_change_anim(barbaroi5,6)
	
	wait_time(0.2)
	
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.7)
	
	dot_remove_unit(barbaroi3)
	dot_remove_unit(barbaroi4)
	dot_remove_unit(barbaroi5)
	
	dot_change_anim(dotRagnar,0)
	dot_change_anim(dotGawain,0)
	
	wait_time(0.5)
	
	
				--//ローマ軍残党兵が一部斬り崩される。
				--//ガウェイン、ラグネルが増援として登場。
				
	--ガウェインが出てきたのがわかりずらいため二人のカットイン
	
	open_cutin(2, 1)
	
	on_cutin(1,Ragnar , "Smile", 1)
	on_cutin(2,Gawain , "Smile", 1)
	

	bgm_play("BGM_Battle_Candlelight")
	open_speech_window("CHRNAME_RAGNAR",nil , nil)
	message("EA_007_0540020")
	close_speech_window()
	
	

	
	close_cutin()
	wait_time(0.5)
	
	-- @ラグネル	黙っていられないよね！	
	
	move_camera(17, 14, 1.5)
	

	-- @カイルの叔父	ゲ、ゲェーッ！？に、逃げねば…！このスポンサーの退路を確保しろ、兵ども！！	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540021")
	close_speech_window()
	
	

				--//「このスポンサー」ルビ「わたし」
				--//モルドレッド
	-- @？？？	ノロマが	
	open_speech_window("CHRNAME_NAMELES",nil , nil)
	PlayPartVoiceDirect("モルドレッド","0010")
	message("EA_007_0540024")
	close_speech_window()

				--//ローマ軍残党兵が一部斬り崩される。
				--//モルドレッドが増援として登場。
				
				
	
	
	move_camera(21, 18, 2.0)
	
	dot_move_unit_seq(dotMordred ,20,19)
    wait_seq()
    
    dot_unit_dir(dotMordred, 0)	
	
	wait_time(0.1)
	
	wait_seq()
	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)
	wait_seq()
	dot_unit_dir(KairOG, 3)
	
	wait_time(0.1)
	
	on_active(Ef_Shockwave01_0)
	on_active(Ef_Shockwave01_1)
	on_active(Ef_Shockwave01_2)
	
	


	local gridpos=get_grid_position(19,18)
	set_pos(Ef_Shockwave01_0,gridpos)
	play_particle(Ef_Shockwave01_0)
	dot_change_anim(barbaroi3R,6)
	
	local gridpos=get_grid_position(20,18)
	set_pos(Ef_Shockwave01_1,gridpos)
	play_particle(Ef_Shockwave01_1)
	dot_change_anim(barbaroi4R,6)
	
	local gridpos=get_grid_position(21,18)
	set_pos(Ef_Shockwave01_2,gridpos)
	play_particle(Ef_Shockwave01_2)
	dot_change_anim(barbaroi5R,6)
	
	se_play("SE_ADV_MA_01A900_33_Axe_Impact")
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_change_anim(barbaroi3R,6)
	dot_change_anim(barbaroi4R,6)
	dot_change_anim(barbaroi5R,6)
	
	wait_time(0.2)
	
	dot_play_particle_unit(barbaroi3R,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi4R,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi5R,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.7)
	
	dot_remove_unit(barbaroi3R)
	dot_remove_unit(barbaroi4R)
	dot_remove_unit(barbaroi5R)
	
	dot_unit_dir(dotMordred, 2)
	dot_change_anim(dotMordred,0)
	
	wait_time(0.5)
	
	
		
	open_cutin(1, 1)
	
	on_cutin(1,Mordred , "Smile", 1)
		
	-- @モルドレッド	てめえらツリーの飾りにしてやるよ
	change_face(Mordred, "Smile")	
	open_speech_window("CHRNAME_MORDRED",nil , nil)
	PlayPartVoiceDirect("モルドレッド","0018")
	message("EA_007_0540027")
	close_speech_window()
	
	close_cutin()
	wait_time(0.5)
	
	move_camera(17, 14, 1.5)

	-- @カイルの叔父	ひっ…！？	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540028")
	close_speech_window()

	-- @カイル	叔父さん！！	
	open_speech_window("NPCNAME_0386",nil , nil)
	message("EA_007_0540029")
	close_speech_window()
	
	dot_unit_dir(KairOG, 2)

	-- @カイルの叔父	か、カイル、今更懺悔はせんぞ！！	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540030")
	close_speech_window()

	-- @カイル	謝ったほうがうまくいく商売も世の中にはあると思うけどな！	
	open_speech_window("NPCNAME_0386",nil , nil)
	message("EA_007_0540031")
	close_speech_window()

	-- @カイルの叔父	なっ………！？	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540032")
	close_speech_window()
	
	dot_move_unit_seq(Kair ,16,14)

	-- @カイル	叔父さん、商売下手だね！！	
	open_speech_window("NPCNAME_0386",nil , nil)
	message("EA_007_0540033")
	close_speech_window()

	-- @カイルの叔父	なっ、なっ…！？	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540034")
	close_speech_window()

	-- @クラリス	…プレゼント選びで迷うのは贈る者が責任をもつ必要があるからです	
	change_face(Clarice, "Normal")
	PlayPartVoiceDirect("クラリス","0025")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	message("EA_007_0540035")
	--close_speech_window()

	-- @クラリス	幸せを願う責任があるからです	
	--open_speech_window("CHRNAME_CLARICE", , nil)
	message("EA_007_0540036")
	close_speech_window()
	
	--空白
	dot_move_unit_seq(dotClarice ,17,14)
	move_camera(18, 14, 1.0)
	change_camera_distance(5.0, 1.0)	
	wait_time(1.5)
	


	-- @クラリス	その責任を放棄したあなたには──	
	change_face(Clarice, "Anger")
	open_speech_window("CHRNAME_CLARICE",Clarice , nil)
	message("EA_007_0540037")
	close_speech_window()
	
	dot_move_unit_seq(KairOG ,20,14)
	wait_seq()
	dot_unit_dir(KairOG, 2)
	

	-- @カイルの叔父	ブチ殺せ～～～っ！！！！	
	open_speech_window("NPCNAME_0389",nil , nil)
	message("EA_007_0540038")
	close_speech_window()

	--カットイン
	open_cutin(1, 1)
	
	on_cutin(1,Clarice , "Anger", 1)
	

	open_speech_window("CHRNAME_CLARICE",nil , nil)
	PlayPartVoiceDirect("クラリス","0017")
	message("EA_007_0540039")
	close_speech_window()
	
	

	
	close_cutin()
	wait_time(0.5)

	-- @クラリス	ついていけませんね	
	

				--//バトル3：スノー・ファイト
				--//敵：カイルの叔父、ローマ軍残党兵多数


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,16,13,0)
	character2DFull_Preload(Clarice, "Clarice", 101023003)
	pbadv_setup_101022_Mordred_preload(0,true,20,25,0)
	pbadv_setup_101013_Gawain_preload(0,true,14,25,0)
	pbadv_setup_101018_Ragnar_preload(0,true,13,25,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",true,true)
	preload_sound("BGM_Battle_Candlelight")
end
