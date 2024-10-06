-- このluaスクリプトは、MS_002_072から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201170000", "201170000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101070001)
	DotActor002 = dot_reserve_ally(101070001, 4, 4, 0)
	dot_set_weapon(DotActor002, 106030001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101012008)
	DotActor003 = dot_reserve_ally(101012008, 8, 4, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201005001, 1, 3, 0)
	dot_set_weapon(DotActor004, 105010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201005001, 1, 6, 0)
	dot_set_weapon(DotActor005, 105010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201004001, 2, 5, 0)
	dot_set_weapon(DotActor006, 104010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201004001, 5, 7, 0)
	dot_set_weapon(DotActor007, 104010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201003001, 6, 5, 0)
	dot_set_weapon(DotActor008, 103010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201006001, 7, 3, 0)
	dot_set_weapon(DotActor009, 106010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201001001, 6, 4, 0)
	dot_set_weapon(DotActor010, 101010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201002001, 7, 6, 0)
	dot_set_weapon(DotActor011, 102010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(201006001, 8, 3, 0)
	dot_set_weapon(DotActor012, 106010001)

	Actor013 = set_chara_unknown()
	DotActor013 = dot_reserve_ally(201005001, 1, 4, 0)
	dot_set_weapon(DotActor013, 105010001)

	Actor014 = set_chara_unknown()
	DotActor014 = dot_reserve_ally(201003001, 2, 2, 0)
	dot_set_weapon(DotActor014, 103010001)

	Actor015 = set_chara_unknown()
	DotActor015 = dot_reserve_ally(201001001, 2, 6, 0)
	dot_set_weapon(DotActor015, 101010001)

	Actor016 = set_chara_unknown()
	DotActor016 = dot_reserve_ally(201002001, 1, 5, 0)
	dot_set_weapon(DotActor016, 102010001)

	Actor017 = set_chara_unknown()
	character2DFull(Actor017, "Actor017", 101070002)
	DotActor017 = dot_reserve_ally(101070002, 28, 6, 0)
	dot_set_weapon(DotActor017, 106030001)

	setup_complete_unit()

	dot_unit_dir(DotActor003, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor009, 2)
	dot_unit_dir(DotActor010, 2)
	dot_unit_dir(DotActor011, 2)
	dot_unit_dir(DotActor012, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(4,4, 0.0)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
dot_disp_unit(DotActor010,false)
dot_disp_unit(DotActor011,false)
dot_disp_unit(DotActor012,false)
dot_disp_unit(DotActor013,false)
dot_disp_unit(DotActor014,false)
dot_disp_unit(DotActor015,false)
dot_disp_unit(DotActor016,false)
Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem23", false, true) --紋章
Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) --キラーズ化
Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) --キラーズ化
dot_disp_unit(DotActor017,false)
load_sound("BGM_Battle_LTeinn")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

	--★★テロップ★★:「命懸けで戦って」
	open_narration_window()
	message("MS_002_0720003")

close_narration_window()

PlayPartVoiceDirect("フライクーゲル","0068")

	--★★フライクーゲル★★:ひとりずつ確実に潰していく気だ<br>最終的にダーリンを丸裸にするために
	change_face(Actor002, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720004")

close_speech_window()

dot_move_unit_seq(DotActor008,6,4)
wait_seq()
dot_change_anim(DotActor008,3)
dot_change_anim(DotActor009,3)
dot_play_particle_unit(DotActor008,"Ef_C_Axe_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor009,"Ef_C_Gun_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor008,0)
dot_change_anim(DotActor009,0)
dot_dodge_seq(DotActor002)
wait_seq()

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor008,6)
dot_change_anim(DotActor009,6)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)
dot_change_anim(DotActor008,0)
dot_change_anim(DotActor009,0)
dot_change_anim(DotActor002,0)

	--★★テロップ★★:
	open_narration_window()
	message("MS_002_0720006")

	close_narration_window()

	--★★フライクーゲル★★:
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720007")

close_speech_window()

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor008,6)
dot_change_anim(DotActor009,6)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_DieEmy01",2,true)

wait_time(0.5)

dot_disp_unit(DotActor008, false)
dot_disp_unit(DotActor009, false)
wait_time(1.0)
dot_change_anim(DotActor002,0)
wait_time(0.5)

on_active(Ef_bar1) 
on_active(Ef_bar2) 
on_active(Ef_bar3) 
local gridpos = get_grid_position(6,4)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)

local gridpos = get_grid_position(7,6)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)
local gridpos = get_grid_position(8,3)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)
wait_time(0.2)
dot_disp_unit(DotActor010, true)
dot_disp_unit(DotActor011, true)
dot_disp_unit(DotActor012, true)
wait_time(2.0)

PlayPartVoiceDirect("フライクーゲル","0031")

	--★★フライクーゲル★★:
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720009")

close_speech_window()

dot_unit_dir(DotActor002,2)
wait_time(0.5)
dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor004,6)
dot_change_anim(DotActor006,6)
dot_play_particle_unit(DotActor004,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor004,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_DieEmy01",2,true)

wait_time(0.5)

dot_disp_unit(DotActor004, false)
dot_disp_unit(DotActor006, false)
wait_time(1.0)
dot_change_anim(DotActor002,0)
wait_time(0.5)

on_active(Ef_bar4) 
on_active(Ef_bar5) 

local gridpos = get_grid_position(1,4)
set_pos(Ef_bar4, gridpos)
set_scale(Ef_bar4, {0.8, 0.8, 0.8})
play_particle(Ef_bar4)
local gridpos = get_grid_position(2,2)
set_pos(Ef_bar5, gridpos)
set_scale(Ef_bar5, {0.8, 0.8, 0.8})
play_particle(Ef_bar5)
wait_time(0.2)
dot_disp_unit(DotActor013, true)
dot_disp_unit(DotActor014, true)

wait_time(2.0)

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor005,6)
dot_change_anim(DotActor013,6)
dot_play_particle_unit(DotActor005,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor013,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor005,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor013,"Ef_C_Cmn_DieEmy01",2,true)

wait_time(0.5)

dot_disp_unit(DotActor005, false)
dot_disp_unit(DotActor013, false)
wait_time(1.0)
dot_change_anim(DotActor002,0)
wait_time(0.5)

on_active(Ef_bar1) 
on_active(Ef_bar2) 
on_active(Ef_bar3) 

local gridpos = get_grid_position(1,3)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)
local gridpos = get_grid_position(2,6)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)
local gridpos = get_grid_position(1,5)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)
wait_time(0.2)
dot_unit_dir(DotActor004,3)
dot_change_anim(DotActor004,0)
dot_disp_unit(DotActor004, true)
dot_disp_unit(DotActor015, true)
dot_disp_unit(DotActor016, true)
wait_time(2.0)

dot_unit_dir(DotActor002,3)

on_active(Ef_bar4) 
on_active(Ef_bar5) 

local gridpos = get_grid_position(6,5)
set_pos(Ef_bar4, gridpos)
set_scale(Ef_bar4, {0.8, 0.8, 0.8})
play_particle(Ef_bar4)
local gridpos = get_grid_position(7,3)
set_pos(Ef_bar5, gridpos)
set_scale(Ef_bar5, {0.8, 0.8, 0.8})
play_particle(Ef_bar5)
wait_time(0.2)
dot_disp_unit(DotActor009, true)
dot_disp_unit(DotActor008, true)

wait_time(2.0)

	--★★テロップ★★:
	open_narration_window()
	message("MS_002_0720011")

close_narration_window()

move_camera(6,4, 0.5)
wait_camera()
dot_change_anim(DotActor003,4)
wait_time(0.2)
on_active(Roar) 
local gridpos = get_grid_position(8,4)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)
dot_change_anim(DotActor003,0)

	--★★フライクーゲル★★:
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720013")

	close_speech_window()

	--★★テロップ★★:「逃げるのは、自由だよ」
	open_narration_window()
	message("MS_002_0720014")

close_narration_window()
move_camera(4,4, 1.0)
wait_camera()

	--★★フライクーゲル★★:…ああ、もお<br>ずーっと、うまくいかないなあ
	change_face(Actor002, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720015")

close_speech_window()

dot_change_anim(DotActor002,2)
dot_move_knockback(DotActor002,3,4,0.2,0)
wait_time(0.2)
dot_change_anim(DotActor002,0)

	--★★フライクーゲル★★:<ruby=うごくな>フリーズ</ruby>、わたし
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720018")

close_speech_window()

on_active(Ef_Emblem1)

local locatorpos = dot_get_unit_locator(DotActor002,1)
set_pos(Ef_Emblem1, locatorpos)
play_particle(Ef_Emblem1)

wait_time(2.0)
dot_move_unit_seq(DotActor003,7,4)
wait_seq()

PlayPartVoiceDirect("ディナタン_008","0028")

	--★★イミテーション★★:
	change_face(Actor003, "Surprise")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor003)
	message("MS_002_0720021")

	close_speech_window()

	--★★テロップ★★:
	open_narration_window()
	message("MS_002_0720023")

	close_narration_window()

	--★★フライクーゲル★★:<ruby=にげみち>都合の良い自由</ruby>を探しても<br>不自由ばっかり見えてきちゃう
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720024")

bgm_play("Stop_BGM_Bus_2")

	close_speech_window()

	--★★テロップ★★:「好きに、しなよ」
	open_narration_window()
	message("MS_002_0720027")

bgm_play("BGM_Battle_LTeinn")

	close_narration_window()

	--★★フライクーゲル★★:だったら<br>…もう、<dot>好きにする</dot>
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720028")

	--★★フライクーゲル★★:わたしを縛るたくさんの<br>大嫌いな不自由を──
	message("MS_002_0720030")

dot_move_unit_seq(DotActor002,4,4)
wait_seq()

PlayPartVoiceDirect("フライクーゲル","0008")

	--★★フライクーゲル★★:わたしの<dot>好きに</dot>、するよ
	change_face(Actor002, "Laugh")
	message("MS_002_0720032")

close_speech_window()

on_active(Ef_Killers)

local gridpos = get_grid_position(4, 4)
set_pos(Ef_Killers, gridpos)
play_particle(Ef_Killers)
wait_time(1.5)

	--★★フライクーゲル★★:起こせ撃鉄、悪魔の引き金<br>当たるか否かは魔弾の気まぐれ
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0720035")

	open_cutin(1,1)
	on_cutin(1,Actor002,"Anger")

	close_speech_window()

	--★★フライクーゲル★★:<ruby=ファクタライズ>因枢分解</ruby>・フライクーゲル！！
	open_speech_window("CHRNAME_FREIKUGEL", nil, nil)
	message("MS_002_0720036")

	close_cutin()

wait_time(0.5)
on_active(Ef_KillChan1)

local gridpos = get_grid_position(4, 4)
set_pos(Ef_KillChan1, gridpos)
play_particle(Ef_KillChan1)
wait_time(0.7)
dot_change_unit(DotActor002, DotActor017, 0.0)

wait_time(1.5)
stop_particle(Ef_Killers)
wait_time(2.0)

dot_change_anim(DotActor017,3)
wait_time(0.1)
dot_play_particle_unit(DotActor017,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor010,6)
dot_change_anim(DotActor008,6)
dot_change_anim(DotActor003,3)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_Guard01",2,true)
wait_time(0.2)

dot_play_particle_unit(DotActor010,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true)

wait_time(0.5)

dot_disp_unit(DotActor010, false)
dot_disp_unit(DotActor008, false)
dot_remove_unit(DotActor010)
wait_time(1.0)
dot_change_anim(DotActor017,0)
dot_change_anim(DotActor003,0)
wait_time(0.5)

	close_speech_window()

	--★★フライクーゲル2★★:不都合ばっかりの世界だけど
	change_face(Actor017, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor017, nil)
	message("MS_002_0720040")

close_speech_window()

dot_change_anim(DotActor017,3)
wait_time(0.1)
dot_play_particle_unit(DotActor017,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor012,6)
dot_change_anim(DotActor011,6)
dot_change_anim(DotActor003,3)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_Guard01",2,true)
wait_time(0.2)

dot_play_particle_unit(DotActor012,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor011,"Ef_C_Cmn_DieEmy01",2,true)

wait_time(0.5)

dot_disp_unit(DotActor012, false)
dot_disp_unit(DotActor011, false)
wait_time(1.0)
dot_change_anim(DotActor017,0)
dot_change_anim(DotActor003,0)
wait_time(0.5)

	--★★テロップ★★:
	open_narration_window()
	message("MS_002_0720042")

	close_narration_window()

	--★★フライクーゲル2★★:
	change_face(Actor017, "Anger")
	open_speech_window("CHRNAME_FREIKUGEL", Actor017, nil)
	message("MS_002_0720043")

close_speech_window()

dot_move_unit_seq(DotActor003,6,4)
wait_seq()
dot_change_anim(DotActor017,3)
dot_change_anim(DotActor003,3)
wait_time(0.1)
dot_play_particle_unit(DotActor017,"Ef_C_Gu2_N_Atk01",3,true)
dot_play_particle_unit(DotActor003,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)

	--★★フライクーゲル2★★:
	open_speech_window("CHRNAME_FREIKUGEL", Actor017, nil)
	message("MS_002_0720045")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor002, "Actor002", 101070001)
	character2DFull_Preload(Actor003, "Actor003", 101012008)
	character2DFull_Preload(Actor017, "Actor017", 101070002)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem23", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
preload_sound("BGM_Battle_LTeinn")
end
