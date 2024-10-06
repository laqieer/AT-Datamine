-- このluaスクリプトは、EA_053_014から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000003", "201000003")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101013004)
	DotActor001 = dot_reserve_ally(101013004, 21, 25, 0)
	dot_set_weapon(DotActor001, 103010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101009001)
	DotActor002 = dot_reserve_ally(101009001, 20, 26, 0)
	dot_set_weapon(DotActor002, 101010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(401011001, 12, 24, 0)
	dot_set_weapon(DotActor003, 104010001)

	setup_complete_unit()


	dot_disp_weapon(DotActor003, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(21,26, 0.0)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

wait_time(0.5)
dot_unit_dir(DotActor001,2)
wait_time(0.8)
dot_unit_dir(DotActor002,2)
wait_time(0.7)
dot_unit_dir(DotActor001,3)
wait_time(1.0)
dot_disp_weapon(DotActor001,false)
dot_disp_weapon(DotActor002,false)
wait_time(0.5)
dot_unit_dir(DotActor001,2)
dot_unit_dir(DotActor002,3)


	--★★ガウェイン★★:よし、これで全部倒しきったな！
	change_face(Actor001, "Laugh")
	open_speech_window("CHRNAME_GAWAIN", Actor001, nil)
PlayPartVoiceDirect("ガウェイン","0008")
	message("EA_053_0140002")


	close_speech_window()

	--★★ノワール★★:ああ…けど、さすがに疲れたな<br>ちょっと休んでいかないか
	open_speech_window("CHRNAME_NOIR", Actor002, nil)
PlayPartVoiceDirect("ノワール","0007")
	message("EA_053_0140003")

	close_speech_window()

	--★★ガウェイン★★:そうだな――
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Actor001, nil)
	message("EA_053_0140004")

close_speech_window()

dot_disp_unit(DotActor003,true)
dot_move_unit_seq(DotActor003,19,24)
wait_seq()


	--★★男性★★:ガウェイン！ちょっといいか？<br>頼みたいことがあって…！
	open_speech_window("NPCNAME_0177", nil, nil)
PlayPartVoiceDirect("市民_男1","0002")
	message("EA_053_0140006")


	close_speech_window()

	--★★ガウェイン★★:ああ、わかった！<br>すぐに行くよ
	open_speech_window("CHRNAME_GAWAIN", Actor001, nil)
PlayPartVoiceDirect("ガウェイン","0009")
	message("EA_053_0140007")

close_speech_window()

dot_reserve_move_unit_seq(DotActor001,19,25)
dot_reserve_move_unit_seq(DotActor003,12,24)
exec_parallel_seq()
wait_time(0.2)
dot_unit_dir(DotActor002,2)


	--★★ノワール★★:え、もう行くのか！？<br>全然休憩できてないけど
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor002, nil)
PlayPartVoiceDirect("ノワール","0028")
	message("EA_053_0140008")

close_speech_window()

dot_unit_dir(DotActor001,3)


	--★★ガウェイン★★:まあな…けど、しかたねー！<br>呼ばれたらすぐ駆けつけるのがヒーローだからな
	change_face(Actor001, "Smile")
	open_speech_window("CHRNAME_GAWAIN", Actor001, nil)
PlayPartVoiceDirect("ガウェイン_004","0010")
	message("EA_053_0140009")

close_speech_window()

dot_move_unit_seq(DotActor001,12,25)
wait_seq()


	--★★ノワール★★:…ヒーローって大変なんだな
	open_speech_window("CHRNAME_NOIR", Actor002, nil)
PlayPartVoiceDirect("ノワール","0034")
	message("EA_053_0140011")

bgm_play("Stop_BGM_Bus_MidFade")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101013004)
	character2DFull_Preload(Actor002, "Actor002", 101009001)
end
