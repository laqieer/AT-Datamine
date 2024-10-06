-- このluaスクリプトは、EA_006_053から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101032002)
	DotActor001 = dot_reserve_ally(101032002, 21, 35, 0)
	dot_set_weapon(DotActor001, 106010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101010001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101013001)
	DotActor003 = dot_reserve_ally(101013001, 10, 36, 0)
	dot_set_weapon(DotActor003, 103010001)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101033001)
	DotActor004 = dot_reserve_ally(101033001, 18, 35, 0)
	dot_set_weapon(DotActor004, 108010001)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101025001)
	DotActor005 = dot_reserve_ally(101025001, 17, 37, 0)
	dot_set_weapon(DotActor005, 108010001)

	Actor006 = set_chara_unknown()
	character2DFull(Actor006, "Actor006", 101024001)
	DotActor006 = dot_reserve_ally(101024001, 16, 37, 0)
	dot_set_weapon(DotActor006, 102020001)

	Actor007 = set_chara_unknown()
	character2DFull(Actor007, "Actor007", 101018001)
	DotActor007 = dot_reserve_ally(101018001, 15, 35, 0)
	dot_set_weapon(DotActor007, 106010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(401038001, 25, 35, 0)
	dot_set_weapon(DotActor008, 101010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201001001, 24, 36, 0)
	dot_set_weapon(DotActor009, 101010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201001001, 26, 37, 0)
	dot_set_weapon(DotActor010, 101010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201001001, 22, 35, 0)
	dot_set_weapon(DotActor011, 101010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(401038001, 26, 34, 0)
	dot_set_weapon(DotActor012, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor009, 2)
	dot_unit_dir(DotActor010, 2)
	dot_unit_dir(DotActor011, 2)
	dot_unit_dir(DotActor012, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(40.0, 0.0)
move_camera(21, 35, 0.0)
dot_disp_unit(DotActor003,false)
dot_disp_unit(DotActor004,false)
dot_disp_weapon(DotActor004,false)
dot_disp_unit(DotActor005,false)
dot_disp_weapon(DotActor005,false)
dot_disp_unit(DotActor006,false)
dot_disp_weapon(DotActor006,false)
dot_disp_unit(DotActor007,false)
dot_disp_weapon(DotActor007,false)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

PlayPartVoiceDirect("ガレス","0035")

	--★★ガレス★★:ハアアアッ！
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0530002")

close_speech_window()
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_change_anim(DotActor011,6)
dot_play_particle_unit(DotActor011,"Ef_C_Cmn_N_Hit_Str01",3,true)
wait_time(0.2)
dot_play_particle_unit(DotActor011,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)
dot_disp_unit(DotActor011,false)
dot_remove_unit(DotActor011)
wait_time(0.2)
dot_change_anim(DotActor001,0)
move_camera(24, 35, 1.0)
dot_move_unit_seq(DotActor001,22,35)
dot_move_unit_seq(DotActor001,22,36)
dot_move_unit_seq(DotActor001,23,36)
wait_seq()
wait_camera()
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_change_anim(DotActor009,6)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Str01",3,true)
wait_time(0.2)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)
dot_disp_unit(DotActor009,false)
dot_remove_unit(DotActor009)
wait_time(0.5)
dot_change_anim(DotActor001,0)

PlayPartVoiceDirect("兵士1","0043")

	--★★カレドニア兵A★★:く、くそ…！強い！<br>この女、まさか本当に円卓の騎士なのか！？
	open_speech_window("NPCNAME_0397", nil, nil)
	message("EA_006_0530004")

close_speech_window()
PlayPartVoiceDirect("ガレス","0033")

	--★★ガレス★★:だから最初っからそう言ってるだろ～！<br>あんまり侮らないでほしいな！
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0530005")

	close_speech_window()

	--★★カレドニア兵A★★:くそ…！<br>くそおおおおお！
	open_speech_window("NPCNAME_0397", nil, nil)
	message("EA_006_0530006")

close_speech_window()
dot_move_unit_seq(DotActor012,26,31,1.5)
dot_move_unit_seq(DotActor012,33,31,1.5)
wait_seq()
dot_disp_unit(DotActor012,false)
dot_remove_unit(DotActor012)
dot_move_unit_seq(DotActor008,25,33,1.5)
wait_seq()

bgm_play("Stop_BGM_Bus_2")

	--★★ガレス★★:あ！<br>待って、そこにはお弁当が――
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0530008")

dot_move_unit_seq(DotActor008,25,31,1.5)
dot_play_particle_grid("Ef_C_Cmn_N_Hit_Str01",25,32)
dot_move_unit_seq(DotActor008,32,31,1.5)
wait_seq()
dot_disp_unit(DotActor008,false)
dot_remove_unit(DotActor008)

	--★★ガレス★★:あ――…
	change_face(Actor001, "Sad")
	message("EA_006_0530011")

PlayPartVoiceDirect("ガレス_002","0024")

	--★★ガレス★★:お弁当…兄さんのために作った…<br>特製サンドウィッチが――…
	message("EA_006_0530012")

	close_speech_window()

	--★★ランスロット★★:ガレス！！
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_LANCELOT", Actor002, nil)
	message("EA_006_0530014")

	close_speech_window()

	--★★ガレス★★:！！
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0530015")

dot_move_unit_seq(DotActor010,25,37,2.0)
dot_move_unit_seq(DotActor010,25,36,2.0)
dot_move_unit_seq(DotActor010,24,36,2.0)

	--★★ガレス★★:しまっ――
	message("EA_006_0530018")

fadeout(255,255,255,1.0,0.2)
close_speech_window()
dot_place_unit(DotActor010,25,36)
dot_disp_unit(DotActor003,true)
dot_place_unit(DotActor003,24,36)
dot_change_anim(DotActor003,3)
dot_change_anim(DotActor010,6)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Str01",3,true)
wait_time(1.0)
fadein(1.7)
wait_time(1.7)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)
dot_disp_unit(DotActor010,false)
dot_remove_unit(DotActor010)
wait_time(0.5)

bgm_play("BGM_Battle_Running_FI")

	--★★ガウェイン★★:人の家族に、手ぇ出してんじゃねーよ
	change_face(Actor003, "Serious")
	open_speech_window("CHRNAME_GAWAIN", Actor003, nil)
	message("EA_006_0530023")

dot_change_anim(DotActor003,0)

close_speech_window()
voice_play("VO_101032_sp_0005_3")

	--★★ガレス★★:…兄さん
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0530024")

dot_unit_dir(DotActor003,2)

close_speech_window()
voice_play("VO_101013_sp_0006_1")

	--★★ガウェイン★★:無事か、ガレス――怪我は？
	change_face(Actor003, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Actor003, nil)
	message("EA_006_0530025")

	close_speech_window()

	--★★ガレス★★:う、うん…大丈夫
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0530026")

	close_speech_window()

	--★★ガウェイン★★:そうか。そりゃよかった
	change_face(Actor003, "Laugh")
	open_speech_window("CHRNAME_GAWAIN", Actor003, nil)
	message("EA_006_0530027")

	close_speech_window()

	--★★ガレス★★:あ、あの…
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0530028")

close_speech_window()
move_camera(22,36,0.5)
dot_disp_unit(DotActor004,true)
dot_move_unit_seq(DotActor004,22,35)
wait_seq()
wait_camera()

PlayPartVoiceDirect("リオネス","0012")

	--★★リオネス★★:フラワーグッドフレンド作戦実行委員の<br>リオネスがお弁当を持って来たぞー！
	change_face(Actor004, "Smile")
	open_speech_window("CHRNAME_LYONESS", Actor004, nil)
	message("EA_006_0530029")

	--★★リオネス★★:さあ、さっそくお花見を開始だー！
	message("EA_006_0530030")

close_speech_window()
dot_disp_unit(DotActor005,true)
dot_move_unit_seq(DotActor005,21,37)
wait_seq()

PlayPartVoiceDirect("クレア","0034")

	--★★クレア★★:…その前に、ちょっとは<br>片付けたほうがいいんじゃないかしら
	open_speech_window("CHRNAME_CLARE", Actor005, nil)
	message("EA_006_0530031")

close_speech_window()
dot_disp_unit(DotActor006,true)
dot_move_unit_seq(DotActor006,20,37)
wait_seq()

PlayPartVoiceDirect("ヴォールス","0038")

	--★★ヴォールス★★:…だな。アーサー王たちが来る前に<br>なんとかしてしまおう
	change_face(Actor006, "Smile")
	open_speech_window("CHRNAME_BORS", Actor006, nil)
	message("EA_006_0530032")

close_speech_window()
dot_disp_unit(DotActor007,true)
dot_move_unit_seq(DotActor007,20,35)
dot_move_unit_seq(DotActor007,20,36)
dot_move_unit_seq(DotActor007,21,36)
wait_seq()

PlayPartVoiceDirect("ラグネル","0007")

	--★★ラグネル★★:大丈夫、みんなで協力すれば<br>お片づけなんてすぐ終わるよ！
	change_face(Actor007, "Laugh")
	open_speech_window("CHRNAME_RAGNAR", Actor007, nil)
	message("EA_006_0530033")

bgm_play("Stop_BGM_Bus_LongFade")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101032002)
	character2DFull_Preload(Actor002, "Actor002", 101010001)
	character2DFull_Preload(Actor003, "Actor003", 101013001)
	character2DFull_Preload(Actor004, "Actor004", 101033001)
	character2DFull_Preload(Actor005, "Actor005", 101025001)
	character2DFull_Preload(Actor006, "Actor006", 101024001)
	character2DFull_Preload(Actor007, "Actor007", 101018001)
end
