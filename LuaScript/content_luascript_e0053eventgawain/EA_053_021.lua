-- このluaスクリプトは、EA_053_021から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201010000", "201010000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101013004)
	DotActor001 = dot_reserve_ally(101013004, 30, 15, 0)
	dot_set_weapon(DotActor001, 103010001)

	Actor002 = set_chara_unknown()
	DotActor002 = dot_reserve_ally(401011001, 37, 13, 0)
	dot_set_weapon(DotActor002, 104010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(401036001, 41, 13, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(401036001, 40, 13, 0)
	dot_set_weapon(DotActor004, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor001, 3)
	dot_unit_dir(DotActor002, 2)
	dot_unit_dir(DotActor003, 2)
	dot_unit_dir(DotActor004, 2)

	dot_disp_weapon(DotActor002, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(33,13, 0.0)
dot_disp_unit(DotActor001,false)
dot_disp_weapon(DotActor001,false)
dot_disp_weapon(DotActor002,false)
dot_disp_weapon(DotActor003,false)
dot_disp_weapon(DotActor004,false)
load_sound("BGM_Battle_Gawain")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

se_play("SE_ADV_MA_01B109_10_Ambient_Loop")
move_camera(36,13,5.0)
dot_reserve_move_unit_seq(DotActor003,36,13,0.25)
dot_reserve_move_unit_seq(DotActor004,35,13,0.25)
exec_parallel_seq()
wait_time(2.0)
se_play("SE_ADV_MA_01C900_19_Punch")
wait_time(0.3)
dot_unit_dir(DotActor002,3)
se_play("SE_ADV_MA_01107_39_AppleDrop")
wait_time(0.7)
dot_unit_dir(DotActor002,2)


	--★★男性★★:おい、なにするんだ！<br>商品の陳列が崩れたじゃないか！
	open_speech_window("NPCNAME_0177", nil, nil)
PlayPartVoiceDirect("市民_男1","0015")
	message("EA_053_0210005")

wait_seq()
dot_unit_dir(DotActor003,3)
dot_unit_dir(DotActor004,3)
wait_camera()


	close_speech_window()

	--★★ログレス兵A★★:あ？ちょっとぶつかっただけだろ…<br>細かいこと気にすんなよ
	open_speech_window("NPCNAME_0124", nil, nil)
PlayPartVoiceDirect("兵士3","0015")
	message("EA_053_0210006")

	close_speech_window()

	--★★男性★★:なんだと？ぶつかったならまず謝れよ<br>それくらい常識だろ！？
	open_speech_window("NPCNAME_0177", nil, nil)
	message("EA_053_0210007")

	close_speech_window()

	--★★ログレス兵A★★:うるせえなあ！警備してやってるんだ<br>これくらいいいだろうが！
	open_speech_window("NPCNAME_0124", nil, nil)
	message("EA_053_0210008")

	--★★ログレス兵A★★:俺は、こんなゴチャゴチャした商店街の<br>警備なんてしたことねーんだよ！
	message("EA_053_0210009")

	--★★ログレス兵A★★:自分の身も自分で守れねえくせに…<br>文句があるなら拳でわからせてみろよ！
	message("EA_053_0210010")


	close_speech_window()

	--★★男性★★:なっ…
	open_speech_window("NPCNAME_0177", nil, nil)
PlayPartVoiceDirect("市民_男1","0028")
	message("EA_053_0210011")

close_speech_window()

dot_disp_unit(DotActor001,true)
move_camera(35,13,1.0)
dot_move_unit_seq(DotActor001,34,14)
wait_seq()
dot_unit_dir(DotActor001,3)
wait_camera()


	--★★ガウェイン★★:はいはい、そこまで！<br>街中でもめてんじゃねーっつーの！
	open_speech_window("CHRNAME_GAWAIN", Actor001, nil)
PlayPartVoiceDirect("ガウェイン","0002")
	message("EA_053_0210013")

dot_unit_dir(DotActor003,2)
dot_unit_dir(DotActor004,2)

	close_speech_window()

	--★★ログレス兵A★★:ああ？
	open_speech_window("NPCNAME_0124", nil, nil)
	message("EA_053_0210014")

	close_speech_window()

	--★★ガウェイン★★:あんたら、見ねー顔だな
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_GAWAIN", Actor001, nil)
	message("EA_053_0210015")


	--★★ガウェイン★★:戦い続きで兵士が足りねーから<br>急いでかき集めてきたとは聞いてるけど…
	change_face(Actor001, "Normal")
PlayPartVoiceDirect("ガウェイン_004","0034")
	message("EA_053_0210016")

	--★★ガウェイン★★:…なるほど。<ruby=ケイ>鬼教師</ruby>の教育は<br>まだ皆に行き届いてねーってわけだ
	message("EA_053_0210017")

	close_speech_window()

	--★★ログレス兵A★★:なんだ、てめえ…やろうってのか！
	open_speech_window("NPCNAME_0124", nil, nil)
	message("EA_053_0210019")

	--★★ログレス兵A★★:円卓の騎士だかなんだか知らねーが<br>ただのガキのくせに、生意気なんだよ！
	message("EA_053_0210020")

bgm_play("Stop_BGM_Bus_MidFade")


	close_speech_window()

	--★★ガウェイン★★:ったく、しかたねーなぁ…
	change_face(Actor001, "Laugh")
	open_speech_window("CHRNAME_GAWAIN", Actor001, nil)
PlayPartVoiceDirect("ガウェイン","0033")
	message("EA_053_0210021")

bgm_play("BGM_Battle_Gawain")


	--★★ガウェイン★★:街の人たちに迷惑をかけるってんなら<br>ヒーローが容赦しねーぜ！
	change_face(Actor001, "Serious")
PlayPartVoiceDirect("ガウェイン_004","0035")
	message("EA_053_0210022")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101013004)
preload_sound("BGM_Battle_Gawain")
end
