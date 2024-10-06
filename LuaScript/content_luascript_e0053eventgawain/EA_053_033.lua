-- このluaスクリプトは、EA_053_033から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000003", "201000003")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	DotActor001 = dot_reserve_ally(401011001, 15, 36, 0)
	dot_set_weapon(DotActor001, 104010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101013004)
	DotActor002 = dot_reserve_ally(101013004, 8, 36, 0)
	dot_set_weapon(DotActor002, 103010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(401041001, 14, 36, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(401041001, 14, 35, 0)
	dot_set_weapon(DotActor004, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor001, 2)
	dot_unit_dir(DotActor002, 3)
	dot_unit_dir(DotActor003, 3)
	dot_unit_dir(DotActor004, 3)

	dot_disp_weapon(DotActor001, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(45.0, 0.0)
move_camera(14, 36, 0.0)
dot_disp_unit(DotActor002, false)
load_sound("BGM_Battle_Gawain")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)


	--★★山賊★★:へへ…もう逃げ場はねぇぞ<br>大人しく出すもん出しな！
	open_speech_window("NPCNAME_0283", nil, nil)
PlayPartVoiceDirect("山賊","0003")
	message("EA_053_0330003")

close_speech_window()
dot_change_anim(DotActor001, DotAnim_Move )
dot_move_knockback(DotActor001, 16, 36, 0.5, 1)
wait_time(0.5)
dot_change_anim(DotActor001, DotAnim_Damage)


	--★★市民（男）★★:ヒッ…ヒイイッ！おたすけえ！
	open_speech_window("NPCNAME_0303", nil, nil)
PlayPartVoiceDirect("市民中年_男2","0030")
	message("EA_053_0330004")

dot_move_unit_seq(DotActor003, 15, 36, 1.0)
wait_seq()
bgm_play("Stop_BGM_Bus_MidFade")


	close_speech_window()

	--★★ガウェイン★★:そこまでだぜ！
	change_face(Actor002, "Serious")
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
PlayPartVoiceDirect("ガウェイン_004","0017")
	message("EA_053_0330005")

close_speech_window()
dot_change_anim(DotActor001, DotAnim_Idle )
dot_unit_dir(DotActor003, DotDir_Left)
dot_unit_dir(DotActor004, DotDir_Left)
dot_disp_unit(DotActor002, true)
dot_move_unit_seq(DotActor002, 13, 36, 1.0)
wait_seq()
bgm_play("BGM_Battle_Gawain")


	--★★ガウェイン★★:円卓の騎士・十ノ座ガウェイン<br>太陽のヒーロー、これにありだ！
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
PlayPartVoiceDirect("ガウェイン","0035")
	message("EA_053_0330007")


	close_speech_window()

	--★★山賊★★:チッ…来やがったか
	open_speech_window("NPCNAME_0283", nil, nil)
PlayPartVoiceDirect("山賊","0032")
	message("EA_053_0330008")

close_speech_window()
dot_attack_seq(DotActor002, DotActor003)
wait_seq()


	--★★ガウェイン★★:
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
PlayPartVoiceDirect("ガウェイン_004","0035")
	message("EA_053_0330009")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor002, "Actor002", 101013004)
preload_sound("BGM_Battle_Gawain")
end
