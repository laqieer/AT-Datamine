-- このluaスクリプトは、EA_053_041から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101009001)
	DotActor001 = dot_reserve_ally(101009001, 2, 18, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101013004)
	DotActor002 = dot_reserve_ally(101013004, 3, 18, 0)
	dot_set_weapon(DotActor002, 103010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(201017001, 12, 18, 0)
	dot_set_weapon(DotActor003, 104010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201017001, 10, 17, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201017001, 14, 19, 0)
	dot_set_weapon(DotActor005, 104010001)

	setup_complete_unit()

	dot_unit_dir(DotActor002, 2)
	dot_unit_dir(DotActor003, 2)
	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor005, 2)

	dot_disp_weapon(DotActor003, false)
	dot_disp_weapon(DotActor004, false)
	dot_disp_weapon(DotActor005, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(40.0, 0.0)
move_camera(2,18, 0.0)
dot_disp_weapon(DotActor001,false)
dot_disp_weapon(DotActor002,false)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

	--★★ノワール★★:街道の見回り？
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("EA_053_0410003")


	close_speech_window()

	--★★ガウェイン★★:ああ。五月祭は人の出入りが多くなるだろ<br>そのせいで魔物や獣の気が立ってて危険なんだ
	change_face(Actor002, "Laugh")
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
PlayPartVoiceDirect("ガウェイン","0007")
	message("EA_053_0410004")

close_speech_window()

dot_reserve_move_unit_seq(DotActor003,7,18)
dot_reserve_move_unit_seq(DotActor004,8,17)
dot_reserve_move_unit_seq(DotActor005,8,19)
exec_parallel_seq()
move_camera(4,18, 0.5)

wait_camera()
wait_seq()
dot_unit_dir(DotActor002,3)

	--★★イノシシ★★:グルルルルル…
	open_speech_window("NPCNAME_0396", nil, nil)
	message("EA_053_0410007")

close_speech_window()

wait_time(0.2)
dot_disp_weapon(DotActor001,true)
dot_disp_weapon(DotActor002,true)
wait_time(0.2)


	--★★ノワール★★:なるほど…一般人があれに襲われたら<br>ただじゃ済まないな
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
PlayPartVoiceDirect("ノワール","0046")
	message("EA_053_0410008")

	close_speech_window()

	--★★ガウェイン★★:そういうことだ<br>――来るぞ！
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
	message("EA_053_0410009")

dot_reserve_move_unit_seq(DotActor003,4,18)
dot_reserve_move_unit_seq(DotActor004,4,17)
dot_reserve_move_unit_seq(DotActor005,4,19)
exec_parallel_seq()

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
