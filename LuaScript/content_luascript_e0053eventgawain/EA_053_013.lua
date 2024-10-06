-- このluaスクリプトは、EA_053_013から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000003", "201000003")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101009001)
	DotActor001 = dot_reserve_ally(101009001, 20, 27, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101013004)
	DotActor002 = dot_reserve_ally(101013004, 20, 25, 0)
	dot_set_weapon(DotActor002, 103010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(201001001, 23, 24, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201002001, 24, 25, 0)
	dot_set_weapon(DotActor004, 102010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201004001, 25, 26, 0)
	dot_set_weapon(DotActor005, 104010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201007001, 25, 27, 0)
	dot_set_weapon(DotActor006, 107010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201001001, 24, 28, 0)
	dot_set_weapon(DotActor007, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor001, 3)
	dot_unit_dir(DotActor002, 3)
	dot_unit_dir(DotActor003, 2)
	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(22,26, 0.0)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)


	--★★ノワール★★:バルバロイがこんなに…！
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
PlayPartVoiceDirect("ノワール","0028")
	message("EA_053_0130004")


	close_speech_window()

	--★★ガウェイン★★:カレドニアでバルバロイの動きが<br>活発になってきてるからな
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
PlayPartVoiceDirect("ガウェイン_004","0034")
	message("EA_053_0130005")

	--★★ガウェイン★★:それで最近、こっちにも頻繁に出てくるんだ
	message("EA_053_0130006")


	close_speech_window()

	--★★ノワール★★:そうなのか…
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
PlayPartVoiceDirect("ノワール","0046")
	message("EA_053_0130007")


	close_speech_window()

	--★★ガウェイン★★:ま、<ruby=ヒーロー>俺</ruby>がいる限り<br>ログレスには手出しさせねーけどな！
	change_face(Actor002, "Smile")
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
PlayPartVoiceDirect("ガウェイン_004","0010")
	message("EA_053_0130008")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101009001)
	character2DFull_Preload(Actor002, "Actor002", 101013004)
end
