-- MA_01104_110
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")

function Load()
	Load_common(true)

	
	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(BattleTime_Sunset , BattleWeather_Shiny)

	pbadv_setup_101009_Noir(2,true, 20, 23,0) --ノワール
	pbadv_setup_101012_Dinatan(0,true, 22, 14,0)  --ディナタン
	pbadv_setup_101001_Tyrfing(1,true, 20, 29,0)  --ティルフィング（キラーズ）


	barbaroiB = dot_reserve_ally(201026001, 19, 17, 0)
	dot_set_weapon(barbaroiB, 104010001)
	
	barbaroi1 = dot_reserve_enemy(1, 18, 21, 0)
	barbaroi2 = dot_reserve_enemy(1, 19, 21, 0)
	barbaroi3 = dot_reserve_enemy(1, 20, 21, 0)
	barbaroi4 = dot_reserve_enemy(1, 21, 21, 0)
	barbaroi5 = dot_reserve_enemy(1, 22, 21, 0)

	barbaroi6 = dot_reserve_enemy(1, 18, 25, 0)
	barbaroi7 = dot_reserve_enemy(1, 19, 25, 0)
	barbaroi8 = dot_reserve_enemy(1, 20, 25, 0)
	barbaroi9 = dot_reserve_enemy(1, 21, 25, 0)
	barbaroi10 = dot_reserve_enemy(1, 22, 25, 0)

	setup_complete_unit()

	dot_change_anim(dotDinatan, 1)
	dot_unit_dir(barbaroiB,2)

	change_camera_distance(8.0, 0.0)
	
	change_camera_angle(25.0, 0.0)
	
	move_camera(20, 24, 0.0)

	load_sound("BGM_Battle_Running")
	
	
end

function Play()
	Play_start(true)
	fadein(0)


	-- @ノワール	おまえッッ！！！！	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1100002")
	close_speech_window()

	--//姿なし、ティルフィング
	-- @？？？	「万物切り裂く錆びずの魔剣願いの代価はアナタの運命」	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_1100004")
	close_speech_window()


	dot_move_unit_seq(dotTyrfing1, 20, 26)
	wait_seq()
	
	dot_attack_seq(dotTyrfing1,barbaroi8)
	dot_damage_seq(barbaroi8,dotTyrfing1,false)
	wait_seq()

	dot_change_anim(dotTyrfing1,0)

	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi8,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi9,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi10,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(barbaroi6,6)
	dot_change_anim(barbaroi7,6)
	dot_change_anim(barbaroi8,6)
	dot_change_anim(barbaroi9,6)
	dot_change_anim(barbaroi10,6)

	wait_time(0.2)

	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",3,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_DieEmy01",3,true)
	dot_play_particle_unit(barbaroi8,"Ef_C_Cmn_DieEmy01",3,true)
	dot_play_particle_unit(barbaroi9,"Ef_C_Cmn_DieEmy01",3,true)
	dot_play_particle_unit(barbaroi10,"Ef_C_Cmn_DieEmy01",3,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)
	dot_disp_unit(barbaroi8, false)
	dot_disp_unit(barbaroi9, false)
	dot_disp_unit(barbaroi10, false)

	dot_remove_unit(barbaroi6)
	dot_remove_unit(barbaroi7)
	dot_remove_unit(barbaroi8)
	dot_remove_unit(barbaroi8)
	dot_remove_unit(barbaroi10)

	wait_time(0.5)

	bgm_play("BGM_Battle_Running")
	-- @ノワール	ティルフィング…！？	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1100006")
	close_speech_window()

	move_camera(20, 23, 1.0)
	
	dot_move_unit_seq(dotTyrfing1, 19, 23)
	wait_seq()
	dot_unit_dir(dotTyrfing1,3)
	dot_unit_dir(dotNoir2,2)
	wait_camera()

	-- @ティルフィング	遅れて申し訳ございません、マスター…！町中のバルバロイに阻まれ──	
	change_face(Tyrfing1, "Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1100008")
	close_speech_window()


	-- @ノワール	頼む、ティルフィング、頼む…！！	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1100009")
	close_speech_window()

	-- @ティルフィング	はい、マスター	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1100010")
	close_speech_window()

	-- @ノワール	力を貸せ	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1100011")
	close_speech_window()

	-- @ティルフィング	全霊をもって	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1100012")
	close_speech_window()


	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 23,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 22, 14,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 20, 29,0)
	preload_sound("BGM_Battle_Running")
end
