-- このluaスクリプトは、MS_002_081から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201170000", "201170000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101070002)
	DotActor001 = dot_reserve_ally(101070002, 4, 4, 0)
	dot_set_weapon(DotActor001, 106030001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101070001)

	Actor003 = set_chara_unknown()

	Actor004 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor004, "Actor004", playerId)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101001002)
	DotActor005 = dot_reserve_ally(101001002, 20, 3, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	character2DFull(Actor006, "Actor006", 101012008)
	DotActor006 = dot_reserve_ally(101012008, 8, 4, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	character2DFull(Actor007, "Actor007", 101011007)
	DotActor007 = dot_reserve_ally(101011007, 19, 3, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	character2DFull(Actor008, "Actor008", 101010007)
	DotActor008 = dot_reserve_ally(101010007, 7, 5, 0)
	dot_set_weapon(DotActor008, 101010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201001001, 2, 3, 0)
	dot_set_weapon(DotActor009, 101010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201005001, 1, 4, 0)
	dot_set_weapon(DotActor010, 105010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201004001, 2, 6, 0)
	dot_set_weapon(DotActor011, 104010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(201003001, 5, 2, 0)
	dot_set_weapon(DotActor012, 103010001)

	Actor013 = set_chara_unknown()
	DotActor013 = dot_reserve_ally(201014001, 6, 5, 0)
	dot_set_weapon(DotActor013, 105010001)

	Actor014 = set_chara_unknown()
	DotActor014 = dot_reserve_ally(201009001, 7, 3, 0)
	dot_set_weapon(DotActor014, 102020001)

	Actor015 = set_chara_unknown()
	DotActor015 = dot_reserve_ally(201006001, 8, 6, 0)
	dot_set_weapon(DotActor015, 106010001)

	Actor016 = set_chara_unknown()
	DotActor016 = dot_reserve_ally(201007001, 10, 3, 0)
	dot_set_weapon(DotActor016, 107010001)

	Actor017 = set_chara_unknown()
	DotActor017 = dot_reserve_ally(201003001, 3, 3, 0)
	dot_set_weapon(DotActor017, 103010001)

	Actor018 = set_chara_unknown()
	DotActor018 = dot_reserve_ally(201002001, 3, 7, 0)
	dot_set_weapon(DotActor018, 102010001)

	Actor019 = set_chara_unknown()
	DotActor019 = dot_reserve_ally(201003001, 4, 6, 0)
	dot_set_weapon(DotActor019, 103010001)

	Actor020 = set_chara_unknown()
	DotActor020 = dot_reserve_ally(201010001, 6, 3, 0)
	dot_set_weapon(DotActor020, 103010001)

	Actor021 = set_chara_unknown()
	DotActor021 = dot_reserve_ally(201001001, 7, 4, 0)
	dot_set_weapon(DotActor021, 101010001)

	Actor022 = set_chara_unknown()
	DotActor022 = dot_reserve_ally(201006001, 8, 2, 0)
	dot_set_weapon(DotActor022, 106010001)

	Actor023 = set_chara_unknown()
	DotActor023 = dot_reserve_ally(201013001, 2, 5, 0)
	dot_set_weapon(DotActor023, 104020001)

	Actor024 = set_chara_unknown()
	DotActor024 = dot_reserve_ally(201011001, 6, 3, 0)
	dot_set_weapon(DotActor024, 104010001)

	Actor025 = set_chara_unknown()
	DotActor025 = dot_reserve_ally(201002001, 6, 5, 0)
	dot_set_weapon(DotActor025, 102010001)

	Actor026 = set_chara_unknown()
	DotActor026 = dot_reserve_ally(201003001, 7, 7, 0)
	dot_set_weapon(DotActor026, 103010001)

	Actor027 = set_chara_unknown()
	DotActor027 = dot_reserve_ally(201006001, 9, 1, 0)
	dot_set_weapon(DotActor027, 106010001)

	Actor028 = set_chara_unknown()
	DotActor028 = dot_reserve_ally(201012001, 9, 5, 0)
	dot_set_weapon(DotActor028, 105010001)

	setup_complete_unit()

	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor012, 2)
	dot_unit_dir(DotActor013, 2)
	dot_unit_dir(DotActor014, 2)
	dot_unit_dir(DotActor015, 2)
	dot_unit_dir(DotActor016, 2)
	dot_unit_dir(DotActor019, 2)
	dot_unit_dir(DotActor020, 2)
	dot_unit_dir(DotActor021, 2)
	dot_unit_dir(DotActor022, 2)
	dot_unit_dir(DotActor024, 2)
	dot_unit_dir(DotActor025, 2)
	dot_unit_dir(DotActor026, 2)
	dot_unit_dir(DotActor027, 2)
	dot_unit_dir(DotActor028, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(4,4, 0.0)
load_image("201010270", "content_still_20101027_image", "201010270_StillImage")
show_image("201010270", 0.0, 0.0, 0.0,true,false)
load_image("101010210", "content_still_10101021_image", "101010210_StillImage")
dot_disp_unit(DotActor008,false)
dot_disp_unit(DotActor007,false)
dot_disp_unit(DotActor017,false)
dot_disp_unit(DotActor018,false)
dot_disp_unit(DotActor019,false)
dot_disp_unit(DotActor020,false)
dot_disp_unit(DotActor021,false)
dot_disp_unit(DotActor022,false)
dot_disp_unit(DotActor023,false)
dot_disp_unit(DotActor024,false)
dot_disp_unit(DotActor025,false)
dot_disp_unit(DotActor026,false)
dot_disp_unit(DotActor027,false)
dot_disp_unit(DotActor028,false)
Ef_bar1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar9=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar10=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar11=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar12=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
Roar=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
Slash=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Slash01", false, true)
Tele=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Teleport_Killers", false, true)
Flash=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
Ef_bar13=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_sound("BGM_ADV_Tyrfing")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)--0.6秒+0.5秒

	--★★フライクーゲル1★★:きみとケンカしたまま<br>さよならだったんだ
	change_face(Actor002, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor002, nil)
	message("MS_002_0810005")

	--★★フライクーゲル1★★:本当のことを、きみに言いそびれたまま
	message("MS_002_0810006")

	--★★フライクーゲル1★★:…きみは忘れてしまった過去のきみのハナシ
	message("MS_002_0810007")

	--★★フライクーゲル1★★:本来ならダーリンと知り合ったときに<br>わたしが伝えるべきだったんだ
	message("MS_002_0810008")

	--★★フライクーゲル1★★:「ダーリンが最後の継承者であること」<br>「武器庫から過去へ潜らなきゃならないこと」を
	message("MS_002_0810009")

PlayPartVoiceDirect("フライクーゲル","0057")

	--★★フライクーゲル1★★:…でも、きみを知るほどに…わかった<br>きみが自分の運命を聞いたら──
	message("MS_002_0810010")

	--★★フライクーゲル1★★:きっと迷わず、ひとを救おうとする<br>過去への潜行へためらいなく行ってしまう…
	message("MS_002_0810011")

	--★★フライクーゲル1★★:だからわたしは<br>本当のことを黙ったままで──
	message("MS_002_0810012")

	--★★フライクーゲル1★★:きみを逃避行に誘った
	message("MS_002_0810013")

	--★★フライクーゲル1★★:「わたしと逃げよう」「きみの好きに生きよう」<br>隠しごとしたまま、そう言ってはみたけど──
	message("MS_002_0810014")

PlayPartVoiceDirect("フライクーゲル","0021")

	--★★フライクーゲル1★★:もちろん狙いはハズれて<br>きみとはケンカ別れ
	change_face(Actor002, "Pain")
	message("MS_002_0810015")

	--★★フライクーゲル1★★:わたしはきみを見送れなかった
	message("MS_002_0810016")

	--★★フライクーゲル1★★:きみのそばに<br>いられなかった
	message("MS_002_0810017")

close_speech_window()
bgm_play("Set_BGM_Bus_LPF_Volume_short")

hide_image(STILL_SWITCH_TIME) --0.6秒
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒

dot_change_anim(DotActor006,4)
wait_time(0.2)
se_play("SE_ADV_EA_010_047_Imitation_Song")
on_active(Roar) 
local gridpos = get_grid_position(8,4)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

se_play("SE_ADV_MA_01A900_25_Earthquake_loop")
psbattle_shake_camera(0.4,45,3.0)
wait_time(1.0)

on_active(Ef_bar1) 
on_active(Ef_bar2) 
on_active(Ef_bar3) 
on_active(Ef_bar4) 
on_active(Ef_bar5) 
on_active(Ef_bar6) 

local gridpos = get_grid_position(3,3)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)
local gridpos = get_grid_position(3,7)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)
local gridpos = get_grid_position(4,6)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)

local gridpos = get_grid_position(6,3)
set_pos(Ef_bar4, gridpos)
set_scale(Ef_bar4, {1.2, 1.2, 1.2})
play_particle(Ef_bar4)
local gridpos = get_grid_position(7,4)
set_pos(Ef_bar5, gridpos)
set_scale(Ef_bar5, {0.8, 0.8, 0.8})
play_particle(Ef_bar5)
local gridpos = get_grid_position(8,2)
set_pos(Ef_bar6, gridpos)
set_scale(Ef_bar6, {0.8, 0.8, 0.8})
play_particle(Ef_bar6)

wait_time(0.2)
dot_disp_unit(DotActor017, true)
dot_unit_dir(DotActor017,3)
dot_disp_unit(DotActor018, true)
dot_unit_dir(DotActor018,3)
dot_disp_unit(DotActor019, true)
dot_disp_unit(DotActor020, true)
dot_disp_unit(DotActor021, true)
dot_disp_unit(DotActor022, true)
wait_time(2.0)
se_play("SE_LoopSE_Stop")
wait_time(1.0)
dot_change_anim(DotActor006,0)

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor020,6)
dot_change_anim(DotActor013,6)
dot_play_particle_unit(DotActor020,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor013,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor020,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor013,"Ef_C_Cmn_DieEmy01",2,true)

dot_unit_dir(DotActor001,2)
wait_time(0.1)

dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor017,6)
dot_change_anim(DotActor010,6)
dot_play_particle_unit(DotActor017,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_disp_unit(DotActor020, false)
dot_disp_unit(DotActor013, false)
dot_play_particle_unit(DotActor017,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_DieEmy01",2,true)
dot_unit_dir(DotActor001,3)

wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor014,6)
dot_change_anim(DotActor021,6)
dot_play_particle_unit(DotActor014,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor021,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_disp_unit(DotActor017, false)
dot_disp_unit(DotActor010, false)
dot_play_particle_unit(DotActor014,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor021,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)

dot_disp_unit(DotActor014, false)
dot_disp_unit(DotActor021, false)
wait_time(1.0)
dot_change_anim(DotActor001,0)
dot_remove_unit(DotActor014)
dot_remove_unit(DotActor017)
dot_remove_unit(DotActor013)
dot_remove_unit(DotActor020)
dot_remove_unit(DotActor021)
bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	--★★フライクーゲル★★:だから、もうどこにも行かない！
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0810021")

close_speech_window()
bgm_play("Set_BGM_Bus_LPF_Volume_short")

dot_change_anim(DotActor006,4)
wait_time(0.2)
se_play("SE_ADV_EA_010_047_Imitation_Song")
on_active(Roar) 
local gridpos = get_grid_position(8,4)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

se_play("SE_ADV_MA_01A900_25_Earthquake_loop")
psbattle_shake_camera(0.4,45,3.0)
wait_time(1.0)

on_active(Ef_bar7) 
on_active(Ef_bar8) 
on_active(Ef_bar9) 
on_active(Ef_bar10) 
on_active(Ef_bar11) 
on_active(Ef_bar12) 
on_active(Ef_bar13) 

local gridpos = get_grid_position(2,5)
set_pos(Ef_bar7, gridpos)
set_scale(Ef_bar7, {1.2, 1.2, 1.2})
play_particle(Ef_bar7)
local gridpos = get_grid_position(6,3)
set_pos(Ef_bar8, gridpos)
set_scale(Ef_bar8, {1.2, 1.2, 1.2})
play_particle(Ef_bar8)
local gridpos = get_grid_position(6,5)
set_pos(Ef_bar9, gridpos)
set_scale(Ef_bar9, {0.8, 0.8, 0.8})
play_particle(Ef_bar9)

local gridpos = get_grid_position(7,7)
set_pos(Ef_bar10, gridpos)
set_scale(Ef_bar10, {0.8, 0.8, 0.8})
play_particle(Ef_bar10)
local gridpos = get_grid_position(9,1)
set_pos(Ef_bar11, gridpos)
set_scale(Ef_bar11, {0.8, 0.8, 0.8})
play_particle(Ef_bar11)
local gridpos = get_grid_position(9,5)
set_pos(Ef_bar12, gridpos)
set_scale(Ef_bar12, {1.2, 1.2, 1.2})
play_particle(Ef_bar12)
local gridpos = get_grid_position(1,4)
set_pos(Ef_bar13, gridpos)
set_scale(Ef_bar13, {0.8, 0.8, 0.8})
play_particle(Ef_bar13)

wait_time(0.2)
dot_change_anim(DotActor010,0)
dot_unit_dir(DotActor010,3)
dot_disp_unit(DotActor010, true)
dot_disp_unit(DotActor023, true)
dot_unit_dir(DotActor023,3)
dot_disp_unit(DotActor024, true)
dot_disp_unit(DotActor025, true)
dot_disp_unit(DotActor026, true)
dot_disp_unit(DotActor027, true)
dot_disp_unit(DotActor028, true)
se_play("SE_LoopSE_Stop")
wait_time(2.0)

move_camera(6,4, 1.0)
on_active(Ef_bar1) 
on_active(Ef_bar2) 

local gridpos = get_grid_position(7,3)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)
local gridpos = get_grid_position(7,5)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)

wait_time(0.2)
dot_place_unit(DotActor007,7,3)
dot_disp_unit(DotActor007, true)
dot_disp_unit(DotActor008, true)
wait_time(2.0)
wait_camera()
dot_change_anim(DotActor006,0)
bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	--★★テロップ★★:「きみの自由だ」
	open_narration_window()
	message("MS_002_0810024")

close_narration_window()

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor024,6)
dot_change_anim(DotActor025,6)
dot_play_particle_unit(DotActor024,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor025,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor024,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor025,"Ef_C_Cmn_DieEmy01",2,true)
dot_unit_dir(DotActor001,0)
wait_time(0.1)

dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor012,6)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_disp_unit(DotActor024, false)
dot_disp_unit(DotActor025, false)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)

dot_disp_unit(DotActor012, false)
wait_time(1.0)
dot_remove_unit(DotActor024)
dot_remove_unit(DotActor025)
dot_change_anim(DotActor001,0)
dot_unit_dir(DotActor001,3)

	--★★フライクーゲル★★:
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0810026")

close_speech_window()

dot_unit_dir(DotActor001,2)
wait_time(0.1)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor009,6)
dot_change_anim(DotActor023,6)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor023,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor009,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor023,"Ef_C_Cmn_DieEmy01",2,true)
dot_unit_dir(DotActor001,1)
wait_time(0.1)

dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor018,6)
dot_change_anim(DotActor019,6)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor019,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor018,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor019,"Ef_C_Cmn_DieEmy01",2,true)
dot_disp_unit(DotActor009, false)
dot_disp_unit(DotActor023, false)
wait_time(0.5)
dot_disp_unit(DotActor018, false)
dot_disp_unit(DotActor019, false)
wait_time(1.0)
dot_change_anim(DotActor001,0)
dot_unit_dir(DotActor001,3)

	--★★フライクーゲル★★:わたしは『<ruby=フライクーゲル>自由に動く弾丸</ruby>』だ！！
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0810028")

close_speech_window()

dot_change_anim(DotActor007,3)
wait_time(0.1)
dot_play_particle_unit(DotActor007,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)

dot_change_anim(DotActor007,0)
dot_change_anim(DotActor008,3)
dot_change_anim(DotActor001,0)
wait_time(0.1)
dot_play_particle_unit(DotActor008,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)

dot_change_anim(DotActor008,0)
dot_change_anim(DotActor006,3)
dot_change_anim(DotActor007,3)
dot_change_anim(DotActor001,0)
wait_time(0.1)
dot_play_particle_unit(DotActor007,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor006,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_dodge_seq(DotActor007)
dot_dodge_seq(DotActor008)
wait_seq()

dot_change_anim(DotActor008,3)
dot_change_anim(DotActor007,3)
dot_change_anim(DotActor001,0)
wait_time(0.1)
dot_play_particle_unit(DotActor007,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor008,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)

dot_change_anim(DotActor008,0)
dot_change_anim(DotActor007,0)
dot_change_anim(DotActor006,3)
wait_time(0.1)
dot_play_particle_unit(DotActor006,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)
dot_change_anim(DotActor001,1)
dot_change_anim(DotActor006,0)

wait_time(1.0)
dot_change_anim(DotActor001,0)

	--★★フライクーゲル★★:だからこそ<br>今は動かない！
	change_face(Actor001, "Pain")
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0810031")

close_speech_window()

dot_reserve_move_unit_seq(DotActor010,3,3)
dot_reserve_move_unit_seq(DotActor011,3,5)
exec_parallel_seq()

on_active(Ef_bar1) 
on_active(Ef_bar2) 
on_active(Ef_bar3) 

local gridpos = get_grid_position(2,3)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)
local gridpos = get_grid_position(5,2)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)
local gridpos = get_grid_position(2,5)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)

wait_time(0.2)
dot_unit_dir(DotActor009,3)
dot_unit_dir(DotActor012,3)
dot_unit_dir(DotActor023,3)
dot_change_anim(DotActor009,0)
dot_change_anim(DotActor012,0)
dot_change_anim(DotActor023,0)
dot_disp_unit(DotActor009, true)
dot_disp_unit(DotActor012, true)
dot_disp_unit(DotActor023, true)
wait_seq()

dot_change_anim(DotActor010,3)
dot_change_anim(DotActor011,3)
dot_unit_dir(DotActor001,2)
wait_time(0.1)
dot_play_particle_unit(DotActor011,"Ef_C_Spr_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor010,"Ef_C_Bow_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySpe01",1,true)
wait_time(0.2)
dot_change_anim(DotActor010,0)
dot_change_anim(DotActor011,0)

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor010,6)
dot_change_anim(DotActor011,6)
dot_play_particle_unit(DotActor011,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor011,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_DieEmy01",2,true) 
wait_time(0.5)

dot_disp_unit(DotActor011, false)
dot_disp_unit(DotActor010, false)

dot_remove_unit(DotActor011)
dot_remove_unit(DotActor010)
wait_time(1.0)
dot_change_anim(DotActor001,0)
wait_time(0.5)
dot_unit_dir(DotActor001,3)

	--★★フライクーゲル★★:きみが帰ってくるまで！！
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0810033")

close_speech_window()

dot_move_unit_seq(DotActor007,6,3)
wait_seq()

dot_change_anim(DotActor007,3)
wait_time(0.1)
dot_play_particle_unit(DotActor007,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)

	--★★テロップ★★:
	open_narration_window()
	message("MS_002_0810035")

close_narration_window()

dot_change_anim(DotActor007,0)
dot_change_anim(DotActor001,0)

	--★★フライクーゲル★★:きみを呼び続けるよ！！！！
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_FREIKUGEL", Actor001, nil)
	message("MS_002_0810036")

close_speech_window()

dot_move_unit_seq(DotActor008,6,5)
wait_seq()

dot_change_anim(DotActor008,3)
wait_time(0.1)
dot_play_particle_unit(DotActor008,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)

	--★★テロップ★★:「我が同胞の叫びを、アナタに」
	open_narration_window()
	message("MS_002_0810038")

close_narration_window()

dot_change_anim(DotActor008,0)
dot_change_anim(DotActor001,0)

dot_move_unit_seq(DotActor006,5,4)
wait_seq()

dot_change_anim(DotActor006,3)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor006,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor001,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)

	open_cutin(1,1)
	on_cutin(1,Actor001,"Anger")

	--★★フライクーゲル★★:
	open_speech_window("CHRNAME_FREIKUGEL", nil, nil)
	message("MS_002_0810041")

bgm_play("Stop_BGM_Bus_MidFade")
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)

close_speech_window()

	close_cutin()

show_image("101010210", 0.0, 0.0,0 ,true,false)
dot_change_anim(DotActor001,0)
dot_change_anim(DotActor006,0)

fadein(FADE_TIME)
wait_time(FADE_TIME)
bgm_play("BGM_ADV_Tyrfing_ShortLoop")

	--★★？？？★★:
	open_simple_window("CHRNAME_NAMELES")
	message("MS_002_0810044")

	--★★？？？★★:無尽の武器庫を開き、無限の武具で拓く未来<br>永劫なる平和など土台無謀な願いを背負い…
	message("MS_002_0810045")

	--★★？？？★★:その命　革めるのなら
	message("MS_002_0810046")

	--★★？？？★★:アナタに<br>終わりの続きを斬り拓く、武器を
	message("MS_002_0810048")

	open_select_window_tag(Actor004,"Anger","MS_002_0810050")
	close_simple_window()

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )

	goto Block1end

::Block1end::

bgm_play("BGM_To_Transition_Fade0time")
on_active(Slash)

local gridpos = get_grid_position(6,4)
set_pos(Slash, gridpos)
set_scale(Slash, {1.2, 1.2, 1.2})
turn(Slash,0,0,180, 0.0)
play_particle(Slash)

wait_time(0.1)
dot_change_anim(DotActor008,6)
dot_change_anim(DotActor007,6)
dot_change_anim(DotActor006,6)

dot_change_anim(DotActor009,6)
dot_change_anim(DotActor023,6)
dot_change_anim(DotActor012,6)
dot_change_anim(DotActor026,6)
dot_change_anim(DotActor022,6)
dot_change_anim(DotActor015,6)
dot_change_anim(DotActor027,6)
dot_change_anim(DotActor028,6)
dot_change_anim(DotActor016,6)

dot_play_particle_unit(DotActor009,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor023,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor026,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor022,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor015,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor027,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor028,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor016,"Ef_C_Cmn_DieEmy01",2,true)

dot_move_knockback(DotActor008,8,5,0.2,2)
dot_move_knockback(DotActor007,8,3,0.2,2)
dot_move_knockback(DotActor006,7,4,0.2,2)

wait_time(0.5)

dot_disp_unit(DotActor009,false)
dot_disp_unit(DotActor023,false)
dot_disp_unit(DotActor012,false)
dot_disp_unit(DotActor026,false)
dot_disp_unit(DotActor022,false)
dot_disp_unit(DotActor015,false)
dot_disp_unit(DotActor027,false)
dot_disp_unit(DotActor028,false)
dot_disp_unit(DotActor016,false)

wait_time(0.2)
dot_change_anim(DotActor008,0)
dot_change_anim(DotActor007,0)
dot_change_anim(DotActor006,0)
wait_time(1.0)

PlayPartVoiceDirect("ディナタン_008","0028")

	--★★ディナタン★★:
	change_face(Actor006, "Surprise")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor006)
	message("MS_002_0810057")

	close_speech_window()

	--★★？？？★★:まだ<br>終わりではありません
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MS_002_0810059")

	--★★？？？★★:なぜなら私は『<ruby=ファースト・キラーズ>最初の武器</ruby>』
	message("MS_002_0810060")

	--★★？？？★★:万物切り裂く錆びずの魔剣<br>願いの代価はアナタの<ruby=さだめ>運命</ruby>
	message("MS_002_0810062")

bgm_play("BGM_To_Normal_Fade0time")

	open_select_window_tag(Actor004,"Anger","MS_002_0810066")
	close_speech_window()

	if is_select(1) then
		goto Block2_1
	end

::Block2_1::

on_active(Tele)

	goto Block2end

::Block2end::

bgm_play("Stop_BGM_Bus_MidFade")
local gridpos = get_grid_position(5,4)
set_pos(Tele, gridpos)
play_particle(Tele)
wait_time(1.0)
dot_place_unit(DotActor005,5,4)
dot_disp_unit(DotActor005, true)
wait_time(2.0)

dot_change_anim(DotActor005,3)
wait_time(0.1)
dot_play_particle_unit(DotActor005,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.2)

on_active(Flash)

local gridpos = get_grid_position(6,4)
set_pos(Flash, gridpos)

play_particle(Flash)
wait_time(0.2)
show_image("101010150", 0.0, 0.0, 1.0,false,false)
set_scale_image(20,20)
wait_time(1.5)

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
	character2DFull_Preload(Actor004, "Actor004", playerId)
	character2DFull_Preload(Actor005, "Actor005", 101001002)
	character2DFull_Preload(Actor006, "Actor006", 101012008)
	character2DFull_Preload(Actor007, "Actor007", 101011007)
	character2DFull_Preload(Actor008, "Actor008", 101010007)
load_image_preload("201010270", "content_still_20101027_image", "201010270_StillImage")
load_image_preload("101010210", "content_still_10101021_image", "101010210_StillImage")
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Slash01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Teleport_Killers", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("BGM_ADV_Tyrfing")
end
