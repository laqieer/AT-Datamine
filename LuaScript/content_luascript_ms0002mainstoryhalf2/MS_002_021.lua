-- このluaスクリプトは、MS_002_021から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201220000", "201220000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor001, "Actor001", playerId)
	DotActor001 = dot_reserve_ally(playerId, 23, 14, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101070002)
	DotActor002 = dot_reserve_ally(101070002, 25, 14, 0)
	dot_set_weapon(DotActor002, 106030001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101002001)
	DotActor003 = dot_reserve_ally(101002001, 23, 15, 0)
	dot_set_weapon(DotActor003, 101030001)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101035002)
	DotActor004 = dot_reserve_ally(101035002, 24, 13, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101012008)
	DotActor005 = dot_reserve_ally(101012008, 29, 14, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201001001, 27, 14, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201001001, 28, 13, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201001001, 28, 15, 0)
	dot_set_weapon(DotActor008, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(26, 14, 0.0)
dot_change_anim(DotActor003,1)
Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_Portal1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
load_sound("BGM_Battle_Boss_Start")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor006,6)
dot_change_anim(DotActor007,6)
dot_change_anim(DotActor008,6)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)
dot_disp_unit(DotActor006, false)
dot_disp_unit(DotActor007, false)
dot_disp_unit(DotActor008, false)
dot_remove_unit(DotActor006)
dot_place_unit(DotActor007,28,13)
dot_place_unit(DotActor008,28,15)
wait_time(0.5)
dot_change_anim(DotActor002,0)
wait_time(0.5)

dot_move_unit_seq(DotActor005,27,14)
wait_time(0.1)
dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)

wait_time(0.1)
dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",26,14)
wait_seq()
wait_time(0.5)

PlayPartVoiceDirect("フライクーゲル","0069")

	--★★フライクーゲル★★:フリーズ。ホールドアップ
	change_face(Actor002, "Laugh")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0210005")

	close_speech_window()

	--★★ディナタンIMT★★:──
	open_speech_window("CHRNAME_DINATAN3", nil, Actor005)
	message("MS_002_0210006")

close_speech_window()

dot_change_anim(DotActor002,0)
move_camera(24,14,1.0)
wait_time(0.7)
dot_change_anim(DotActor003,0)
wait_camera()

PlayPartVoiceDirect("レーヴァテイン","0036")

	--★★レーヴァテイン★★:…ありがと、助かった
	open_speech_window("CHRNAME_LAEVATEIN", Actor003, nil)
	message("MS_002_0210008")

close_speech_window()
PlayPartVoiceDirect("フライクーゲル","0057")

	--★★フライクーゲル★★:レーヴァ、へーき…？
	change_face(Actor002, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0210010")

close_speech_window()
PlayPartVoiceDirect("レーヴァテイン","0010")

	--★★レーヴァテイン★★:超元気で<br>歩くのがやっと
	change_face(Actor003, "Smile")
	open_speech_window("CHRNAME_LAEVATEIN", Actor003, nil)
	message("MS_002_0210012")

close_speech_window()
PlayPartVoiceDirect("フライクーゲル","0034")

	--★★フライクーゲル★★:ヤバそうだね
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0210013")

close_speech_window()
PlayPartVoiceDirect("レーヴァテイン","0060")

	--★★レーヴァテイン★★:…かなりね
	change_face(Actor003, "Pain")
	open_speech_window("CHRNAME_LAEVATEIN", Actor003, nil)
	message("MS_002_0210014")

close_speech_window()
move_camera(25,14,1.0)
wait_camera()

PlayPartVoiceDirect("フライクーゲル","0015")

	--★★フライクーゲル★★:…許さないよ<br><ruby=イミテーション>ソックリさん</ruby>
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0210015")

close_speech_window()

dot_change_anim(DotActor005,4)
wait_time(0.2)
se_play("SE_ADV_Emy001_Cry")
on_active(Roar) 
local gridpos = get_grid_position(27,14)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

on_active(Ef_bar1) 
on_active(Ef_bar2)

local gridpos = get_grid_position(28, 13)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8}) --エフェクトの大きさを指定。（0.8固定）
play_particle(Ef_bar1)

local gridpos = get_grid_position(28, 15)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8}) --エフェクトの大きさを指定。（0.8固定）
play_particle(Ef_bar2)
wait_time(0.2)

dot_disp_unit(DotActor007, true) --出現するバルバロイのIDを入力
dot_disp_unit(DotActor008, true) --出現するバルバロイのIDを入力

wait_time(0.5)
dot_change_anim(DotActor005,0)
wait_time(0.5)

PlayPartVoiceDirect("フライクーゲル","0065")

	--★★フライクーゲル★★:フリーズって言ったでしょっ
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0210018")

close_speech_window()
bgm_play("Stop_BGM_Bus_2")

dot_change_anim(DotActor005,4)
wait_time(0.1)
dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
se_play("SE_ADV_EA_010_047_Imitation_Song")
on_active(Roar) 
local gridpos = get_grid_position(27,14)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(0.1)
dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",27,13)
wait_time(0.1)
dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.1)
dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",27,15)
wait_time(1.0)
dot_change_anim(DotActor002,0)
dot_change_anim(DotActor005,0)
wait_time(0.5)
bgm_play("BGM_Battle_Boss_Start")

PlayPartVoiceDirect("リリアーナ","0024")

	--★★ロンギヌス★★:弾丸が当たらない…！？<br>どうして──…！？
	change_face(Actor004, "Surprise")
	open_speech_window("CHRNAME_LONGINUS", Actor004, nil)
	message("MS_002_0210021")

	close_speech_window()

	--★★フライクーゲル★★:…でも、ここで仕留めないと
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0210022")

	--★★フライクーゲル★★:退かれて、他のイミテーションを治癒されたら<br>もうさすがに止めきれない…
	message("MS_002_0210023")

voice_play("VO_101070001_sp_0001_1")

	--★★フライクーゲル★★:感動の再会はこのあとで<br>ゆっくりね、ダーリン？
	change_face(Actor002, "Laugh")
	message("MS_002_0210024")

close_speech_window()
wait_time(1.0)

	open_select_window_tag(Actor001,"Normal","MS_002_0210027")

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

	--★★フライクーゲル★★:………
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0210031")

	goto Block1end

::Block1end::

dot_unit_dir(DotActor002,2)

PlayPartVoiceDirect("フライクーゲル","0028")

	--★★フライクーゲル★★:………………えっ
	change_face(Actor002, "Surprise")
	message("MS_002_0210032")

close_speech_window()

on_active(Ef_Portal1)

local gridpos = get_grid_position(27, 14)
set_pos(Ef_Portal1, gridpos)
set_scale(Ef_Portal1, {0.8, 0.8, 0.8})
play_particle(Ef_Portal1)

wait_time(1.0)

dot_disp_unit(DotActor005, false)

wait_time(0.5)
dot_unit_dir(DotActor002,3)
wait_time(1.5)

PlayPartVoiceDirect("フライクーゲル","0023")

	--★★フライクーゲル★★:…<ruby=フリーズ>ちょっと待ってよ</ruby>
	change_face(Actor002, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0210036")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", playerId)
	character2DFull_Preload(Actor002, "Actor002", 101070002)
	character2DFull_Preload(Actor003, "Actor003", 101002001)
	character2DFull_Preload(Actor004, "Actor004", 101035002)
	character2DFull_Preload(Actor005, "Actor005", 101012008)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
preload_sound("BGM_Battle_Boss_Start")
end
