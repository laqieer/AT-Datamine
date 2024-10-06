-- このluaスクリプトは、EA_006_024から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000002", "201000002")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	DotActor001 = dot_reserve_ally(401011001, 27, 19, 0)
	dot_set_weapon(DotActor001, 104010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101033001)
	DotActor002 = dot_reserve_ally(101033001, 19, 19, 0)
	dot_set_weapon(DotActor002, 108010001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101032002)
	DotActor003 = dot_reserve_ally(101032002, 20, 19, 0)
	dot_set_weapon(DotActor003, 106010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(401041001, 30, 19, 0)
	dot_set_weapon(DotActor004, 101010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(401041001, 31, 18, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(401041001, 31, 20, 0)
	dot_set_weapon(DotActor006, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)

	dot_disp_weapon(DotActor001, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(40.0, 0.0)
move_camera(28, 19, 0.0)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

	--★★商人★★:た、助けてくれえ！
	open_speech_window("NPCNAME_0303", nil, nil)
	message("EA_006_0240005")

close_speech_window()
move_camera(20, 19, 1.0)
wait_camera()

PlayPartVoiceDirect("リオネス","0002")

	--★★リオネス★★:ガレス！人が襲われてるぞ！
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_LYONESS", Actor002, nil)
	message("EA_006_0240007")

	close_speech_window()

	--★★ガレス★★:
	change_face(Actor003, "Anger")
	open_speech_window("CHRNAME_GARETH", Actor003, nil)
	message("EA_006_0240008")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor002, "Actor002", 101033001)
	character2DFull_Preload(Actor003, "Actor003", 101032002)
end
