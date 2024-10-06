-- このluaスクリプトは、MS_002_071から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201220000", "201220000")
	change_time_and_weather(3,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101070001)
	DotActor001 = dot_reserve_ally(101070001, 8, 14, 0)
	dot_set_weapon(DotActor001, 106030001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101012008)
	DotActor002 = dot_reserve_ally(101012008, 12, 14, 0)
	dot_set_weapon(DotActor002, 101010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(201001001, 6, 13, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201006001, 4, 14, 0)
	dot_set_weapon(DotActor004, 106010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201004001, 9, 17, 0)
	dot_set_weapon(DotActor005, 104010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201003001, 10, 14, 0)
	dot_set_weapon(DotActor006, 103010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201005001, 5, 16, 0)
	dot_set_weapon(DotActor007, 105010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201006001, 12, 13, 0)
	dot_set_weapon(DotActor008, 106010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201005001, 5, 13, 0)
	dot_set_weapon(DotActor009, 105010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201004001, 6, 15, 0)
	dot_set_weapon(DotActor010, 104010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201003001, 10, 15, 0)
	dot_set_weapon(DotActor011, 103010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(201006001, 11, 13, 0)
	dot_set_weapon(DotActor012, 106010001)

	Actor013 = set_chara_unknown()

	setup_complete_unit()

	dot_unit_dir(DotActor002, 2)
	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor011, 2)
	dot_unit_dir(DotActor012, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(8,14, 0.0)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
dot_disp_unit(DotActor002,false)
dot_disp_unit(DotActor009,false)
dot_disp_unit(DotActor010,false)
dot_disp_unit(DotActor011,false)
dot_disp_unit(DotActor012,false)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
dot_change_anim(DotActor001,1)
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

	--★★テロップ★★:「自由になりたいと思ったこと…ない？」
	open_narration_window()
	message("MS_002_0710003")

close_narration_window()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)

wait_time(0.2)
dot_change_anim(DotActor001,0)
wait_time(0.5)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor006,6)
dot_change_anim(DotActor008,6)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor006,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true) 
wait_time(0.5)

dot_disp_unit(DotActor006, false)
dot_disp_unit(DotActor008, false)

dot_remove_unit(DotActor006)
dot_remove_unit(DotActor008)
wait_time(1.0)
dot_change_anim(DotActor001,0)
wait_time(0.5)

	--★★フライクーゲル★★:
	change_face(Actor001, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0710007")

close_speech_window()

on_active(Ef_bar3) 
on_active(Ef_bar4) 
local gridpos = get_grid_position(11,13)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)

local gridpos = get_grid_position(10,15)
set_pos(Ef_bar4, gridpos)
set_scale(Ef_bar4, {0.8, 0.8, 0.8})
play_particle(Ef_bar4)
wait_time(0.2)
dot_disp_unit(DotActor011, true)
dot_disp_unit(DotActor012, true)
wait_time(2.0)

	--★★テロップ★★:
	open_narration_window()
	message("MS_002_0710009")

close_narration_window()

dot_unit_dir(DotActor001,2)
wait_time(0.5)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor003,6)
dot_change_anim(DotActor004,6)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor004,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor003,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor004,"Ef_C_Cmn_DieEmy01",2,true) 
wait_time(0.5)

dot_disp_unit(DotActor003, false)
dot_disp_unit(DotActor004, false)

dot_remove_unit(DotActor003)
dot_remove_unit(DotActor004)
wait_time(1.0)
dot_change_anim(DotActor001,0)
wait_time(0.5)

PlayPartVoiceDirect("フライクーゲル","0068")

	--★★フライクーゲル★★:
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0710011")

close_speech_window()

on_active(Ef_bar1) 
on_active(Ef_bar2) 
local gridpos = get_grid_position(5,13)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)

local gridpos = get_grid_position(6,15)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)
wait_time(0.2)
dot_disp_unit(DotActor009, true)
dot_disp_unit(DotActor010, true)
wait_time(2.0)

	--★★テロップ★★:
	open_narration_window()
	message("MS_002_0710013")

	close_narration_window()

	--★★フライクーゲル★★:…心のなかの悪魔がささやく的なヤツ
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0710014")

close_speech_window()

se_play("SE_ADV_MA_01A900_25_Earthquake_loop")
psbattle_shake_camera(0.4,45,3.0)
wait_time(1.0)

on_active(Ef_bar5) 
local gridpos = get_grid_position(12,14)
set_pos(Ef_bar5, gridpos)
set_scale(Ef_bar5, {0.8, 0.8, 0.8})
play_particle(Ef_bar5)
wait_time(0.2)
dot_disp_unit(DotActor002, true)
wait_time(1.0)
dot_unit_dir(DotActor001,3)
se_play("SE_LoopSE_Stop")
wait_time(1.0)

move_camera(10,14,1.0)
wait_camera()
bgm_play("Stop_BGM_Bus_2")

PlayPartVoiceDirect("ディナタン_008","0010")

	--★★イミテーション★★:──
	change_face(Actor002, "Smile")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor002)
	message("MS_002_0710018")

	--★★イミテーション★★:子守歌、歌ってあげる
	change_face(Actor002, "Laugh")
	message("MS_002_0710019")

close_speech_window()

dot_change_anim(DotActor002,4)
wait_time(0.2)
se_play("SE_ADV_EA_010_047_Imitation_Song")
on_active(Roar) 
local gridpos = get_grid_position(12,14)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

show_image("101010150", 0.0, 0.0,1.0,false,false)
set_scale_image(20,20)
wait_time(2.0)

PlayPartVoiceDirect("フライクーゲル","0013")

	--★★フライクーゲル★★:…逃がさない気なんだね
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0710022")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101070001)
	character2DFull_Preload(Actor002, "Actor002", 101012008)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
end
