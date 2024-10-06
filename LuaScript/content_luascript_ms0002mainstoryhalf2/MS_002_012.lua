-- このluaスクリプトは、MS_002_012から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201220000", "201220000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101002001)
	DotActor001 = dot_reserve_ally(101002001, 25, 14, 0)
	dot_set_weapon(DotActor001, 101030001)

	Actor002 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor002, "Actor002", playerId)
	DotActor002 = dot_reserve_ally(playerId, 18, 14, 0)
	dot_set_weapon(DotActor002, 101010001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101070002)
	DotActor003 = dot_reserve_ally(101070002, 23, 21, 0)
	dot_set_weapon(DotActor003, 106030001)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101035002)
	DotActor004 = dot_reserve_ally(101035002, 18, 13, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101012008)
	DotActor005 = dot_reserve_ally(101012008, 28, 14, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201001001, 26, 13, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201001001, 26, 15, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201002001, 27, 14, 0)
	dot_set_weapon(DotActor008, 102010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201006001, 29, 15, 0)
	dot_set_weapon(DotActor009, 106010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201006001, 29, 14, 0)
	dot_set_weapon(DotActor010, 106010001)

	Actor011 = set_chara_unknown()

	Actor012 = set_chara_unknown()
	character2DFull(Actor012, "Actor012", 101070002)

	setup_complete_unit()

	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor009, 2)
	dot_unit_dir(DotActor010, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(40.0, 0.0)
move_camera(25, 14, 0.0)
dot_disp_weapon(DotActor002,false)
load_sound("BGM_Battle_LTeinn")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_reserve_move_unit_seq(DotActor004,22,13)
dot_reserve_move_unit_seq(DotActor002,22,14)
exec_parallel_seq()

dot_change_anim(DotActor006,3)
dot_change_anim(DotActor007,3)
dot_change_anim(DotActor008,3)
dot_change_anim(DotActor009,3)
dot_change_anim(DotActor010,3)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor006,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor007,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor008,"Ef_C_Axe_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor009,"Ef_C_Gun_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor010,"Ef_C_Gun_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.2)

wait_seq()

PlayPartVoiceDirect("レーヴァテイン","0002")

	--★★レーヴァテイン★★:
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("MS_002_0120006")

close_speech_window()

PlayPartVoiceDirect("リリアーナ","0028")

	--★★ロンギヌス★★:
	change_face(Actor004, "Surprise")
	open_speech_window("CHRNAME_LONGINUS", Actor004, nil)
	message("MS_002_0120008")

close_speech_window()

dot_change_anim(DotActor006,0)
dot_change_anim(DotActor007,0)
dot_change_anim(DotActor008,0)
dot_change_anim(DotActor009,0)
dot_change_anim(DotActor010,0)
dot_change_anim(DotActor001,0)

PlayPartVoiceDirect("レーヴァテイン","0042")

	--★★レーヴァテイン★★:
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("MS_002_0120009")

close_speech_window()
bgm_play("Stop_BGM_Bus_2")

PlayPartVoiceDirect("フライクーゲル","0064")

	--★★？？？★★:
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MS_002_0120012")

close_speech_window()

dot_change_anim(DotActor003,3)
wait_time(0.1)
dot_play_particle_unit(DotActor003,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor006,6)
dot_change_anim(DotActor007,6)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor006,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_DieEmy01",2,true) 
wait_time(0.5)

dot_disp_unit(DotActor006, false)
dot_disp_unit(DotActor007, false)

dot_remove_unit(DotActor006)
dot_remove_unit(DotActor007)
wait_time(0.5)

PlayPartVoiceDirect("ディナタン_008","0028")

	--★★ディナタン★★:！？
	change_face(Actor005, "Surprise")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor005)
	message("MS_002_0120014")

close_speech_window()

move_camera(24, 15, 1.0)
dot_move_unit_seq(DotActor003,23,16)
wait_seq()
wait_camera()
dot_change_anim(DotActor003,0)
bgm_play("BGM_Battle_LTeinn")

PlayPartVoiceDirect("フライクーゲル","0049")

	--★★奔放な少女★★:
	change_face(Actor012, "Laugh")
	open_speech_window("NPCNAME_0400", Actor012, nil)
	message("MS_002_0120016")

close_speech_window()

dot_move_unit_seq(DotActor003,24,15)
wait_seq()
dot_change_anim(DotActor003,3)
wait_time(0.1)
dot_play_particle_unit(DotActor003,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor008,6)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true)

wait_time(0.5)

dot_disp_unit(DotActor008, false)
dot_remove_unit(DotActor008)
wait_time(0.5)
dot_change_anim(DotActor003,0)

	--★★ロンギヌス★★:
	change_face(Actor004, "Laugh")
	open_speech_window("CHRNAME_LONGINUS", Actor004, nil)
	message("MS_002_0120018")

	close_speech_window()

	--★★奔放な少女★★:ソーリー、エビバディ！
	open_speech_window("NPCNAME_0400", Actor012, nil)
	message("MS_002_0120019")

close_speech_window()

	open_select_window_tag(Actor002,"Normal","MS_002_0120021")

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

voice_play("VO_101002001_sp_0002_1")

	--★★レーヴァテイン★★:
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("MS_002_0120025")

	goto Block1end

::Block1end::

if is_select(1) then
	close_speech_window()
end


dot_unit_dir(DotActor003,2)

PlayPartVoiceDirect("フライクーゲル","0069")

	--★★フライクーゲル★★:
	change_face(Actor003, "Smile")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0120028")

	--★★フライクーゲル★★:
	message("MS_002_0120029")

	--★★フライクーゲル★★:
	message("MS_002_0120030")

	close_speech_window()

	--★★レーヴァテイン★★:
	change_face(Actor001, "Sad")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("MS_002_0120032")

close_speech_window()

PlayPartVoiceDirect("フライクーゲル","0012")

	--★★フライクーゲル★★:
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0120033")

	--★★フライクーゲル★★:
	change_face(Actor003, "Normal")
	message("MS_002_0120034")

close_speech_window()
dot_unit_dir(DotActor003,3)
move_camera(26, 15, 1.0)
wait_camera()

PlayPartVoiceDirect("フライクーゲル","0035")

	--★★フライクーゲル★★:
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0120035")

	--★★フライクーゲル★★:
	message("MS_002_0120038")

PlayPartVoiceDirect("フライクーゲル","0010")

	--★★フライクーゲル★★:
	change_face(Actor003, "Smile")
	message("MS_002_0120039")

	--★★フライクーゲル★★:
	change_face(Actor003, "Laugh")
	message("MS_002_0120040")

	--★★フライクーゲル★★:
	message("MS_002_0120041")

voice_play("VO_101070001_sp_0001_1")

	--★★フライクーゲル★★:
	change_face(Actor003, "Smile")
	message("MS_002_0120042")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101002001)
	character2DFull_Preload(Actor002, "Actor002", playerId)
	character2DFull_Preload(Actor003, "Actor003", 101070002)
	character2DFull_Preload(Actor004, "Actor004", 101035002)
	character2DFull_Preload(Actor005, "Actor005", 101012008)
	character2DFull_Preload(Actor012, "Actor012", 101070002)
preload_sound("BGM_Battle_LTeinn")
end
