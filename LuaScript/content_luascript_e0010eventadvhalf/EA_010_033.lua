-- このluaスクリプトは、EA_010_033から自動生成されました --
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
	DotActor001 = dot_reserve_ally(playerId, 12, 13, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101002001)
	DotActor002 = dot_reserve_ally(101002001, 13, 14, 0)
	dot_set_weapon(DotActor002, 101030001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(201001001, 14, 13, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201001001, 14, 14, 0)
	dot_set_weapon(DotActor004, 101010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201001001, 17, 12, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201001001, 17, 15, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	character2DFull(Actor007, "Actor007", 101011008)
	DotActor007 = dot_reserve_ally(101011007, 16, 13, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	character2DFull(Actor008, "Actor008", 101010008)
	DotActor008 = dot_reserve_ally(101010007, 16, 14, 0)
	dot_set_weapon(DotActor008, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor003, 2)
	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(13, 14, 0.0)
dot_disp_unit(DotActor005,false)
dot_disp_unit(DotActor006,false)
dot_disp_unit(DotActor007,false)
dot_disp_unit(DotActor008,false)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
local gridpos1 = get_grid_position(16,14) 
set_pos(Ef_Aura_Enemy, gridpos1)

Ef_AuraArea = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area_Start", false, true)
local gridpos1 = get_grid_position(16, 15)
set_pos(Ef_AuraArea, gridpos1)
set_scale(Ef_AuraArea, {1.4, 1.4, 1.4})
load_sound("BGM_ADV_Silence")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Swd_N_Atk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor003,6)
dot_change_anim(DotActor004,6)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor004,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor004,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)
dot_disp_unit(DotActor003, false)
dot_disp_unit(DotActor004, false)
dot_remove_unit(DotActor003) --この後バルバロイを登場させない場合に入力
dot_remove_unit(DotActor004) --この後バルバロイを登場させない場合に入力
wait_time(0.5)
dot_change_anim(DotActor002,0)
wait_time(0.5)

PlayPartVoiceDirect("レーヴァテイン","0037")

	--★★レーヴァテイン★★:ごめん、覚悟して<br>これからは──
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0330004")

	--★★レーヴァテイン★★:破滅するまで<br>ゆっくり眠れなさそうだから
	change_face(Actor002, "Smile")
	message("EA_010_0330006")

close_speech_window()
se_play("SE_ADV_MA_01104_25_Earthquake") --地揺れ

wait_time(2.0)
move_camera(15,14,1)
wait_time(0.2)

on_active(Ef_bar1) 
on_active(Ef_bar2)

local gridpos1 = get_grid_position(17, 12) --出現するバルバロイの座標を入力
local gridpos2 = get_grid_position(17, 15) --出現するバルバロイの座標を入力
set_pos(Ef_bar1, gridpos1)
set_pos(Ef_bar2, gridpos2)
set_scale(Ef_bar1, {0.8, 0.8, 0.8}) --エフェクトの大きさを指定。（0.8固定）
set_scale(Ef_bar2, {0.8, 0.8, 0.8}) --エフェクトの大きさを指定。（0.8固定）
play_particle(Ef_bar1)
play_particle(Ef_bar2)

wait_time(0.2)

dot_disp_unit(DotActor005, true) --出現するバルバロイのIDを入力
dot_disp_unit(DotActor006, true) --出現するバルバロイのIDを入力

wait_camera()
wait_time(2.0)

bgm_play("BGM_ADV_Silence")

	--★★レーヴァテイン★★:………まだ、来る…？
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0330010")

close_speech_window()
on_active(Ef_bar3) 
on_active(Ef_bar4)

local gridpos1 = get_grid_position(16, 13) --出現するバルバロイの座標を入力
local gridpos2 = get_grid_position(16, 14) --出現するバルバロイの座標を入力
set_pos(Ef_bar3, gridpos1)
set_pos(Ef_bar4, gridpos2)
set_scale(Ef_bar3, {0.8, 0.8, 0.8}) --エフェクトの大きさを指定。（0.8固定）
set_scale(Ef_bar4, {0.8, 0.8, 0.8}) --エフェクトの大きさを指定。（0.8固定）
play_particle(Ef_bar3)
play_particle(Ef_bar4)

wait_time(0.2)

dot_disp_unit(DotActor007, true) --出現するバルバロイのIDを入力
dot_disp_unit(DotActor008, true) --出現するバルバロイのIDを入力

wait_time(2.0)

	--★★ギネヴィアIMT★★:湖に枯れて<br>在りし日への献花
	open_speech_window("CHRNAME_NAMELES", nil, Actor007)
	message("EA_010_0330015")

close_speech_window()
PlayPartVoiceDirect("レーヴァテイン","0058")

	--★★レーヴァテイン★★:人──…！？
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0330017")

	close_speech_window()

	--★★ランスロットIMT★★:湖に呑め<br>呪いの足音
	open_speech_window("CHRNAME_NAMELES", nil, Actor008)
	message("EA_010_0330019")

close_speech_window()
on_active(Ef_Aura_Enemy)
play_particle(Ef_Aura_Enemy)
wait_time(1.0)
on_active(Ef_AuraArea)
play_particle(Ef_AuraArea)
wait_time(2.5)

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
	character2DFull_Preload(Actor007, "Actor007", 101011008)
	character2DFull_Preload(Actor008, "Actor008", 101010008)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area_Start", false, true)
preload_sound("BGM_ADV_Silence")
end
