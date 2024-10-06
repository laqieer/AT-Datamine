-- このluaスクリプトは、MS_002_043から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(3,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101002001)
	DotActor001 = dot_reserve_ally(101002001, 22, 25, 0)
	dot_set_weapon(DotActor001, 101030001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101070002)
	DotActor002 = dot_reserve_ally(101070002, 25, 25, 0)
	dot_set_weapon(DotActor002, 106030001)

	setup_complete_unit()

	dot_unit_dir(DotActor002, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(23.0, 0.0)
move_camera(24, 24, 0.0)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_Guard01",1,false)
wait_time(0.2)

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_Guard01",1,true)
wait_time(0.5)

dot_change_anim(DotActor002,0)
dot_move_unit_seq(DotActor001,24,25,1.5)
wait_seq()

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_move_knockback(DotActor002,26, 25,0.2,2)
wait_time(0.7)

dot_change_anim(DotActor001,0)

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
dot_dodge_seq(DotActor001)
wait_time(0.1)
dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",21,25)
wait_seq()

dot_change_anim(DotActor002,0)

dot_move_unit_seq(DotActor001,25,25)
wait_seq()

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
dot_dodge_seq(DotActor002)
wait_seq()

dot_change_anim(DotActor001,0)

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_Critical01",1,true)
dot_move_knockback(DotActor001,23, 25,0.4,2)
wait_time(0.9)
dot_change_anim(DotActor001,1)
dot_move_unit_seq(DotActor002,25,25,0.7)
wait_seq()
wait_time(2.0)

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101002001)
	character2DFull_Preload(Actor002, "Actor002", 101070002)
end
