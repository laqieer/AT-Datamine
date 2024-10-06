-- このluaスクリプトは、EA_053_053から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201040000", "201040000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101009001)
	DotActor001 = dot_reserve_ally(101009001, 2, 3, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101013004)
	DotActor002 = dot_reserve_ally(101013004, 1, 4, 0)
	dot_set_weapon(DotActor002, 103010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(401041001, 11, 3, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(401041001, 12, 4, 0)
	dot_set_weapon(DotActor004, 101010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201001001, 22, 7, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201001001, 22, 8, 0)
	dot_set_weapon(DotActor006, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(9,3, 0.0)
Ef_change1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
Ef_change2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
load_sound("BGM_Battle_General1_Intro")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_reserve_move_unit_seq(DotActor001,8, 3)
dot_reserve_move_unit_seq(DotActor002,7,4)

exec_parallel_seq()

	--★★ノワール★★:いたぞ！
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("EA_053_0530003")

	close_speech_window()

	--★★盗賊1★★:………
	open_speech_window("NPCNAME_0283", nil, nil)
	message("EA_053_0530004")

dot_unit_dir(DotActor003,2)
wait_time(0.2)

	close_speech_window()

	--★★ノワール★★:奪ったものはどこだ！！
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("EA_053_0530005")

	close_speech_window()

	--★★盗賊1★★:………
	open_speech_window("NPCNAME_0283", nil, nil)
	message("EA_053_0530006")

	close_speech_window()

	--★★ノワール★★:…？おい、聞いているのか――
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("EA_053_0530007")


	close_speech_window()

	--★★ガウェイン★★:待て、ノワール<br>アイツら…なんだか様子が変だぜ
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
PlayPartVoiceDirect("ガウェイン","0002")
	message("EA_053_0530008")

on_active(Ef_change1)
on_active(Ef_change2)
local gridpos = get_grid_position(11,3)
set_pos(Ef_change1 , gridpos)
play_particle(Ef_change1)

local gridpos = get_grid_position(12,4)
set_pos(Ef_change2 , gridpos)
play_particle(Ef_change2)
wait_time(1.2)

dot_change_unit(DotActor003,DotActor005, 0.0)
dot_change_unit(DotActor004,DotActor006, 0.0)
wait_time(1.0)


	close_speech_window()

	--★★ノワール★★:！？バルバロイ！？
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
PlayPartVoiceDirect("ノワール","0029")
	message("EA_053_0530010")

bgm_play("BGM_Battle_General1_Intro")

	close_speech_window()

	--★★ガウェイン★★:気を付けろ――来るぞ！
	change_face(Actor002, "Serious")
	open_speech_window("CHRNAME_GAWAIN", Actor002, nil)
	message("EA_053_0530012")

dot_change_anim(DotActor005,4)
dot_change_anim(DotActor006,4)

se_play("SE_ADV_Emy001_Cry")

	close_speech_window()

	--★★バルバロイ1★★:ウアアアアアアアア…！
	open_speech_window("CHRNAME_BARBAROI", nil, nil)

	message("EA_053_0530013")

dot_change_anim(DotActor005,0)
dot_change_anim(DotActor006,0)
dot_reserve_move_unit_seq(DotActor005,9,3)
dot_reserve_move_unit_seq(DotActor006,8,4)

exec_parallel_seq()
wait_seq()

dot_change_anim(DotActor001,3)
dot_change_anim(DotActor002,3)
dot_change_anim(DotActor005,3)
dot_change_anim(DotActor006,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
dot_play_particle_unit(DotActor002,"Ef_C_Ham_N_Atk01",3,true)
dot_play_particle_unit(DotActor005,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor006,"Ef_C_Swd_N_EmyAtk01",3,true)

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
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
preload_sound("BGM_Battle_General1_Intro")
end
