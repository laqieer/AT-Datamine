-- このluaスクリプトは、MS_002_052から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000001", "201000001")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor001, "Actor001", playerId)
	DotActor001 = dot_reserve_ally(playerId, 2, 21, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101002002)
	DotActor002 = dot_reserve_ally(101002002, 3, 21, 0)
	dot_set_weapon(DotActor002, 101030001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101070001)
	DotActor003 = dot_reserve_ally(101070001, 2, 20, 0)
	dot_set_weapon(DotActor003, 106030001)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101035003)
	DotActor004 = dot_reserve_ally(101035003, 3, 22, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101059001)

	Actor006 = set_chara_unknown()

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201001001, 6, 20, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201001001, 6, 21, 0)
	dot_set_weapon(DotActor008, 101010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201001001, 6, 22, 0)
	dot_set_weapon(DotActor009, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor002, 2)
	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor009, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(40.0, 0.0)
move_camera(3, 21, 0.0)
dot_disp_weapon(DotActor001,false)
dot_disp_weapon(DotActor002,false)
dot_disp_weapon(DotActor003,false)
dot_disp_weapon(DotActor004,false)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
dot_disp_unit(DotActor007, false)
dot_disp_unit(DotActor008, false)
dot_disp_unit(DotActor009, false)
load_sound("BGM_Battle_LTeinn")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

wait_time(0.5)
dot_unit_dir(DotActor002,3)
wait_time(0.3)
dot_unit_dir(DotActor003,2)
wait_time(0.2)
dot_unit_dir(DotActor004,3)
wait_time(0.4)
dot_unit_dir(DotActor001,2)
wait_time(0.1)
dot_unit_dir(DotActor002,2)
wait_time(0.3)
dot_unit_dir(DotActor003,3)
wait_time(0.2)
dot_unit_dir(DotActor004,2)
wait_time(0.4)
dot_unit_dir(DotActor001,3)
wait_time(0.1)
dot_unit_dir(DotActor002,3)
wait_time(0.3)
dot_unit_dir(DotActor003,2)
wait_time(0.2)
dot_unit_dir(DotActor004,3)
wait_time(0.4)
dot_unit_dir(DotActor001,2)
wait_time(0.5)

PlayPartVoiceDirect("レーヴァテイン","0043")

	--★★レーヴァテイン★★:またログレスの景色に呑み込まれた…！
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("MS_002_0520005")

close_speech_window()
dot_unit_dir(DotActor001,3)
PlayPartVoiceDirect("リリアーナ","0023")

	--★★ロンギヌス★★:…導き手であるティルフィングが帰還できず<br>現代とログレスの時代が繋がったままです…！
	change_face(Actor004, "Sad")
	open_speech_window("CHRNAME_LONGINUS", Actor004, nil)
	message("MS_002_0520006")

	close_speech_window()

	--★★アルハン★★:なのでログレス時代のバルバロイの力が<br>現代に流れ込んで来ている──
	open_speech_window("NPCNAME_0313", Actor005, nil)
	message("MS_002_0520007")

	--★★アルハン★★:そのせいでイミテーションの力は<br>強まり続けているのだ…！！
	change_face(Actor005, "Anger")
	message("MS_002_0520008")

close_speech_window()
dot_unit_dir(DotActor003,3)
PlayPartVoiceDirect("フライクーゲル","0034")

	--★★フライクーゲル★★:…つまり、ティルフィングの未練の元を見つけて<br>それを断ち切り、彼女を現代へ呼び戻せれば──
	change_face(Actor003, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0520009")

close_speech_window()
dot_unit_dir(DotActor002,2)
PlayPartVoiceDirect("レーヴァテイン","0049")

	--★★レーヴァテイン★★:勝てる<br>機を逃がさなければ
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("MS_002_0520010")

	close_speech_window()

	--★★フライクーゲル★★:………！
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0520011")

voice_play("VO_101070001_sp_0001_3")

	--★★フライクーゲル★★:ダーリン………っ
	message("MS_002_0520012")

	close_speech_window()

	--★★テロップ★★:「絶対にきみを、自由にする」
	open_narration_window()
	message("MS_002_0520013")

	close_narration_window()

	--★★フライクーゲル★★:わたしは、きみを──
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0520014")

close_speech_window()

move_camera(4,21,1.0)
change_camera_angle(34.0, 0.5)
wait_time(0.5)

on_active(Ef_bar1) 
local gridpos = get_grid_position(6, 20)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)

on_active(Ef_bar2)
local gridpos = get_grid_position(6, 21)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)

on_active(Ef_bar3)
local gridpos = get_grid_position(6, 22)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)

wait_time(0.2)

dot_disp_unit(DotActor007, true)
dot_disp_unit(DotActor008, true)
dot_disp_unit(DotActor009, true)

dot_unit_dir(DotActor002,3)

wait_time(2.0)

dot_disp_weapon(DotActor004,true)
dot_move_unit_seq(DotActor004,4,22,0.7)
wait_seq()
wait_time(0.2)

PlayPartVoiceDirect("リリアーナ","0043")

	--★★ロンギヌス★★:ここは私が引き受けます…っ！
	change_face(Actor004, "Anger")
	open_speech_window("CHRNAME_LONGINUS", Actor004, nil)
	message("MS_002_0520017")

	close_speech_window()

	--★★アルハン★★:この空間は、いわばログレス時代の記憶──<br><dot>バルバロイの力そのもの</dot>であろう…！
	change_face(Actor005, "Normal")
	open_speech_window("NPCNAME_0313", Actor005, nil)
	message("MS_002_0520018")

PlayPartVoiceDirect("アルハン","0032")

	--★★アルハン★★:これ以上ヤツらの力が高まったら<br>内外の行き来すら難しくなる…！
	change_face(Actor005, "Anger")
	message("MS_002_0520020")

close_speech_window()

dot_disp_weapon(DotActor002,true)
dot_move_unit_seq(DotActor002,4,21,0.7)
wait_seq()
wait_time(0.2)

voice_play("VO_101002001_sp_0002_1")

	--★★レーヴァテイン★★:フライクーゲル！<br><%player>を連れて武器庫へ！
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("MS_002_0520022")

close_speech_window()
voice_play("VO_101070001_sp_0002_3")

	--★★フライクーゲル★★:れ、レーヴァ<br>わたし、わたし──
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0520023")

	close_speech_window()

	--★★レーヴァテイン★★:フライクーゲル<br>私はもう決めたよ
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("MS_002_0520024")

PlayPartVoiceDirect("レーヴァテイン","0010")

	--★★レーヴァテイン★★:運命に殺されるまで殺し続ける
	change_face(Actor002, "Smile")
	message("MS_002_0520025")

close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Actor003,"Surprise")

wait_time(2.0)

	close_cutin()

	--★★レーヴァテイン★★:あなたがこれからどこに行くかは<br>あなたの自由
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("MS_002_0520027")

bgm_play("Stop_BGM_Bus_MidFade")

PlayPartVoiceDirect("レーヴァテイン","0060")

	--★★レーヴァテイン★★:だから…好きに、しなよ
	message("MS_002_0520029")

bgm_play("BGM_Battle_LTeinn")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", playerId)
	character2DFull_Preload(Actor002, "Actor002", 101002002)
	character2DFull_Preload(Actor003, "Actor003", 101070001)
	character2DFull_Preload(Actor004, "Actor004", 101035003)
	character2DFull_Preload(Actor005, "Actor005", 101059001)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
preload_sound("BGM_Battle_LTeinn")
end
