-- このluaスクリプトは、EA_006_033から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101032002)
	DotActor001 = dot_reserve_ally(101032002, 10, 30, 0)
	dot_set_weapon(DotActor001, 106010001)

	Actor002 = set_chara_unknown()
	DotActor002 = dot_reserve_ally(401011001, 19, 30, 0)
	dot_set_weapon(DotActor002, 104010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(201017001, 18, 30, 0)
	dot_set_weapon(DotActor003, 104010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201017001, 17, 29, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201017001, 18, 29, 0)
	dot_set_weapon(DotActor005, 104010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201017001, 17, 31, 0)
	dot_set_weapon(DotActor006, 104010001)

	setup_complete_unit()

	dot_unit_dir(DotActor002, 2)

	dot_disp_weapon(DotActor002, false)
	dot_disp_weapon(DotActor003, false)
	dot_disp_weapon(DotActor004, false)
	dot_disp_weapon(DotActor005, false)
	dot_disp_weapon(DotActor006, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(40.0, 0.0)
move_camera(18, 30, 0.0)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

	--★★イノシシ★★:グルルルルル…
	open_speech_window("NPCNAME_0396", nil, nil)
	message("EA_006_0330002")

	close_speech_window()

	--★★行商人★★:ヒイイッ――来るな…来るなー！！！
	open_speech_window("NPCNAME_0086", nil, nil)
	message("EA_006_0330003")

close_speech_window()
move_camera(16, 30, 1.0)
dot_move_unit_seq(DotActor001, 11, 30, 1.5)
dot_move_unit_seq(DotActor001, 12, 30, 1.5)
dot_move_unit_seq(DotActor001, 13, 30, 1.5)
dot_move_unit_seq(DotActor001, 14, 30, 1.5)
wait_seq()
wait_camera()

PlayPartVoiceDirect("ガレス_002","0050")

	--★★ガレス★★:――いた！あそこだ！<br>待ってろ～、今、助けるからな！
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0330005")

	--★★ガレス★★:まずはアイツの気を引かないと…<br>…そうだ！さっき買ったこれをぶつければ――
	change_face(Actor001, "Anger")
	message("EA_006_0330006")

	--★★ガレス★★:えい！
	message("EA_006_0330007")

close_speech_window()
dot_change_anim(DotActor001,3)
wait_time(0.2)
dot_change_anim(DotActor003,6)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_N_Hit_Str01",3,true)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_N_Hit_Spark01",3,true)
wait_time(0.5)
dot_change_anim(DotActor001,0)
dot_change_anim(DotActor003,0)
dot_unit_dir(DotActor003, 2)
dot_unit_dir(DotActor004, 2)
dot_unit_dir(DotActor005, 2)
dot_unit_dir(DotActor006, 2)
dot_move_unit_seq(DotActor003,17,30,1.0)
wait_seq()

	--★★ガレス★★:こっちだ、イノシシ～！
	open_speech_window("CHRNAME_GARETH", Actor001, nil)
	message("EA_006_0330009")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101032002)
end
