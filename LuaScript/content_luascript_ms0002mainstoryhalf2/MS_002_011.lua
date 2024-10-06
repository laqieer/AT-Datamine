-- このluaスクリプトは、MS_002_011から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101070002)
	DotActor001 = dot_reserve_ally(101070002, 30, 28, 0)
	dot_set_weapon(DotActor001, 106030001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101070001)
	DotActor002 = dot_reserve_ally(101070001, 10, 32, 0)
	dot_set_weapon(DotActor002, 106030001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(201026001, 7, 21, 0)
	dot_set_weapon(DotActor003, 102020001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201026001, 9, 23, 0)
	dot_set_weapon(DotActor004, 102020001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201026001, 11, 21, 0)
	dot_set_weapon(DotActor005, 102020001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201001001, 9, 26, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201001001, 10, 26, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201001001, 11, 26, 0)
	dot_set_weapon(DotActor008, 101010001)

	Actor009 = set_chara_unknown()
	character2DFull(Actor009, "Actor009", 101070001)
	DotActor009 = dot_reserve_ally(101070001, 10, 32, 0)
	dot_set_weapon(DotActor009, 106030001)

	setup_complete_unit()

	dot_unit_dir(DotActor003, 2)
	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(25.0, 0.0)
move_camera(10, 27, 0.0)
dot_move_height(DotActor004,0.06,0,0)
dot_disp_unit(DotActor003,false)
dot_disp_unit(DotActor004,false)
dot_disp_unit(DotActor005,false)
dot_disp_unit(DotActor006,false)
dot_disp_unit(DotActor007,false)
dot_disp_unit(DotActor008,false)

load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_Roar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
Ef_fh1 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
Ef_fh2 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem23", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem23", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

wait_time(0.5)
dot_move_unit_seq(DotActor002,10,28)
wait_time(0.5)
--フライクーゲル登場、行く手をバルに阻まれる
--小さいバルバロイ出現
on_active(Ef_bar2)
on_active(Ef_bar3)
on_active(Ef_bar4)

local gridpos = get_grid_position(9, 26)
set_pos(Ef_bar2, gridpos)
play_particle(Ef_bar2)

local gridpos = get_grid_position(10, 26)
set_pos(Ef_bar3, gridpos)
play_particle(Ef_bar3)

local gridpos = get_grid_position(11, 26)
set_pos(Ef_bar4, gridpos)
play_particle(Ef_bar4)

wait_time(1.0)

dot_disp_unit(DotActor006,true)
dot_disp_unit(DotActor007,true)
dot_disp_unit(DotActor008,true)
move_camera(10, 25, 1.5)
wait_time(1.5)

on_active(Ef_bar1)
local gridpos = get_grid_position(10, 25) --出現エフェクトを出す場所を入力
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {1.2, 1.2, 1.2})
play_particle(Ef_bar1)

wait_time(1.0)

on_active(Ef_fh1)
gridpos[2]=1.0
set_pos(Ef_fh1,gridpos)
set_scale(Ef_fh1, {1.2, 1.2, 1.2})
play_particle(Ef_fh1)

wait_time(0.2)
dot_disp_unit(DotActor004,true)

wait_time(1.0)
move_camera(10, 27, 1.0)
wait_time(1.0)
on_active(Ef_Emblem1)

	 
	local locatorpos = dot_get_unit_locator(DotActor002, 1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)
	wait_time(2.0)
	
	on_active(Ef_Killers)

	local gridpos = get_grid_position(10, 28)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	--★★フライクーゲル2★★:
	change_face(Actor002, "Laugh")
	open_speech_window("NPCNAME_0400", Actor002, nil)
	message("MS_002_0110007")

	--★★フライクーゲル2★★:その場のテンションとか<br>大事なコトバを言うタイミングとか
	message("MS_002_0110008")

close_speech_window()
bgm_play("Stop_BGM_Bus_2")

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(10, 28)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)
	dot_place_unit(DotActor002,31, 28)
wait_seq()
dot_place_unit(DotActor001,10, 28)

	wait_time(1.5)
	stop_particle(Ef_Killers)
	
	wait_time(2.0)


dot_unit_dir(DotActor001,0)
wait_seq()
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor006,6)
dot_change_anim(DotActor007,6)
dot_change_anim(DotActor008,6)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)
dot_change_anim(DotActor001,0)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)
dot_disp_unit(DotActor006, false)
dot_disp_unit(DotActor007, false)
dot_disp_unit(DotActor008, false)
dot_remove_unit(DotActor006)
dot_remove_unit(DotActor007)
dot_remove_unit(DotActor008)
wait_time(0.5)





move_camera(10, 23, 1.5)
wait_time(1.0)
--巨大バルバロイ出現
on_active(Ef_bar1)
local gridpos = get_grid_position(12, 23) 
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {1.8, 1.8, 1.8})
play_particle(Ef_bar1)

local gridpos = get_grid_position(8, 22)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {1.8, 1.8, 1.8})
play_particle(Ef_bar2)

wait_time(1.0)

on_active(Ef_fh1)

local gridpos = get_grid_position(10, 22)
gridpos[2]=2.0
set_pos(Ef_fh1,gridpos)
set_scale(Ef_fh2, {1.2, 1.2, 1.2})
play_particle(Ef_fh1)
wait_time(0.2)

move_camera(10, 23, 0.0)

wait_time(0.2)
dot_disp_unit(DotActor003,true)
dot_disp_unit(DotActor005,true)

wait_time(1.8)
move_camera(10, 27, 1.0)
wait_time(1.0)

	--★★フライクーゲル★★:
	change_face(Actor001, "Anger")
	open_speech_window("NPCNAME_0400", Actor001, nil)
	message("MS_002_0110010")

close_speech_window()


fadeout(0,0,0,0.2, 0.2)
dot_unit_dir(DotActor001,0)
wait_seq()
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
show_image("101010140", 1.5,  1.5,BLACK_WHITE_TIME,FALSE,FALSE)
set_scale_image(20,20)

fadein(0.2)
wait_time(0.2)

dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.7)
dot_play_particle_unit(DotActor004,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.5)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.5)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.8)                                                                                                                                                                                                                                    
dot_play_particle_unit(DotActor004,"Ef_C_Swd_N_EmyAtk01",3,true)

dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.9)

PlayPartVoiceDirect("フライクーゲル","0064")

	open_cutin(1,2)
	on_cutin(1,Actor001,"Smile")

	--★★フライクーゲル★★:スタンバイ・ミー、ダーリン！
	open_speech_window("NPCNAME_0400", nil, nil)
	message("MS_002_0110013")

	close_cutin()

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101070002)
	character2DFull_Preload(Actor002, "Actor002", 101070001)
	character2DFull_Preload(Actor009, "Actor009", 101070001)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem23", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem23", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
end
