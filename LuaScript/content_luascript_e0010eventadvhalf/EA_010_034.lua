-- このluaスクリプトは、EA_010_034から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(4,4)

	Actor001 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor001, "Actor001", playerId)
	DotActor001 = dot_reserve_ally(playerId, 18, 21, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101002001)
	DotActor002 = dot_reserve_ally(101002001, 19, 22, 0)
	dot_set_weapon(DotActor002, 101030001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101011007)
	DotActor003 = dot_reserve_ally(101011007, 22, 21, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101010007)
	DotActor004 = dot_reserve_ally(101010007, 22, 22, 0)
	dot_set_weapon(DotActor004, 101010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201001001, 23, 20, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201001001, 23, 23, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201001001, 19, 21, 0)
	dot_set_weapon(DotActor007, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor003, 2)
	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(21, 22, 0.0)
Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true) 
local gridpos1 = get_grid_position(22,22)
set_pos(Ef_Aura_Enemy, gridpos1)
on_active(Ef_Aura_Enemy)
play_particle(Ef_Aura_Enemy)
dot_disp_unit(DotActor007,false)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

PlayPartVoiceDirect("レーヴァテイン","0030")

	--★★レーヴァテイン★★:まさか…！
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0340002")

close_speech_window()
dot_reserve_move_unit_seq(DotActor003,20,21)
dot_reserve_move_unit_seq(DotActor004,20,22)
gridpos1 = get_grid_position(20,22)
move_camera(19,22,1.0)
exec_parallel_seq()
slidemove(Ef_Aura_Enemy,gridpos1,0.25)
wait_seq()
wait_camera()

dot_change_anim(DotActor003,3)
dot_change_anim(DotActor004,3)
wait_time(0.1)
dot_play_particle_unit(DotActor003,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor004,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)

wait_time(0.5)
dot_change_anim(DotActor003,0)
dot_change_anim(DotActor004,0)
dot_change_anim(DotActor002,0)

	--★★レーヴァテイン★★:あぐッ！？<br>ああああぁ………っ！？
	change_face(Actor002, "Pain")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0340004")

PlayPartVoiceDirect("レーヴァテイン","0043")

	--★★レーヴァテイン★★:あれは『イミテーション』──…！
	change_face(Actor002, "Anger")
	message("EA_010_0340005")

	open_select_window_tag(Actor001,"Surprise","EA_010_0340007")
	close_speech_window()

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

PlayPartVoiceDirect("ランスロット_007","0007")

	--★★ランスロットIMT★★:<ruby=あやま>過</ruby>つのなら
	open_speech_window("CHRNAME_LANCELOT3", nil, Actor004)
	message("EA_010_0340010")

	goto Block1end

::Block1end::

close_speech_window()

dot_change_anim(DotActor004,3)
wait_time(0.1)
dot_play_particle_unit(DotActor004,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_Critical01",1,true)
dot_move_knockback(DotActor002,17,22,0.5,2)
wait_time(1.0)

	--★★レーヴァテイン★★:アアアッ！？<br>うあああああ…！？！？
	change_face(Actor002, "Pain")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0340013")

close_speech_window()
dot_change_anim(DotActor004,0)
dot_change_anim(DotActor002,1)
wait_time(0.5)

PlayPartVoiceDirect("ギネヴィア_007","0010")

	--★★ギネヴィアIMT★★:滅びて
	change_face(Actor003, "Laugh")
	open_speech_window("CHRNAME_GUINEVERE3", nil, Actor003)
	message("EA_010_0340014")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", get_player_styleId())
	character2DFull_Preload(Actor002, "Actor002", 101002001)
	character2DFull_Preload(Actor003, "Actor003", 101011007)
	character2DFull_Preload(Actor004, "Actor004", 101010007)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
end
