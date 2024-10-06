-- このluaスクリプトは、MS_002_082から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201220000", "201220000")
	change_time_and_weather(4,4)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101001002)
	DotActor001 = dot_reserve_ally(101001002, 9, 14, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101059001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101070002)
	DotActor003 = dot_reserve_ally(101070002, 8, 14, 0)
	dot_set_weapon(DotActor003, 106030001)

	Actor004 = set_chara_unknown()

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101002001)
	DotActor005 = dot_reserve_ally(101002001, 9, 20, 0)
	dot_set_weapon(DotActor005, 101030001)

	Actor006 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor006, "Actor006", playerId)
	DotActor006 = dot_reserve_ally(playerId, 7, 13, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	character2DFull(Actor007, "Actor007", 101012008)
	DotActor007 = dot_reserve_ally(101012008, 12, 14, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	character2DFull(Actor008, "Actor008", 101011007)
	DotActor008 = dot_reserve_ally(101011007, 13, 13, 0)
	dot_set_weapon(DotActor008, 101010001)

	Actor009 = set_chara_unknown()
	character2DFull(Actor009, "Actor009", 101010007)
	DotActor009 = dot_reserve_ally(101010007, 13, 15, 0)
	dot_set_weapon(DotActor009, 101010001)

	Actor010 = set_chara_unknown()
	character2DFull(Actor010, "Actor010", 101011002)
	DotActor010 = dot_reserve_ally(101011002, 10, 13, 0)
	dot_set_weapon(DotActor010, 101010001)

	Actor011 = set_chara_unknown()
	character2DFull(Actor011, "Actor011", 101010002)
	DotActor011 = dot_reserve_ally(101010002, 10, 16, 0)
	dot_set_weapon(DotActor011, 101010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(201004001, 5, 14, 0)
	dot_set_weapon(DotActor012, 104010001)

	Actor013 = set_chara_unknown()
	DotActor013 = dot_reserve_ally(201003001, 5, 16, 0)
	dot_set_weapon(DotActor013, 103010001)

	Actor014 = set_chara_unknown()
	DotActor014 = dot_reserve_ally(201006001, 7, 15, 0)
	dot_set_weapon(DotActor014, 106010001)

	Actor015 = set_chara_unknown()
	DotActor015 = dot_reserve_ally(201001001, 9, 16, 0)
	dot_set_weapon(DotActor015, 101010001)

	Actor016 = set_chara_unknown()
	DotActor016 = dot_reserve_ally(201002001, 10, 15, 0)
	dot_set_weapon(DotActor016, 102010001)

	Actor017 = set_chara_unknown()
	DotActor017 = dot_reserve_ally(201021001, 11, 11, 0)
	dot_set_weapon(DotActor017, 104010001)

	Actor018 = set_chara_unknown()
	DotActor018 = dot_reserve_ally(201021001, 11, 15, 0)
	dot_set_weapon(DotActor018, 104010001)

	Actor019 = set_chara_unknown()
	DotActor019 = dot_reserve_ally(201021001, 14, 13, 0)
	dot_set_weapon(DotActor019, 104010001)

	Actor020 = set_chara_unknown()
	character2DFull(Actor020, "Actor020", 101035002)
	DotActor020 = dot_reserve_ally(101035002, 7, 22, 0)
	dot_set_weapon(DotActor020, 104010001)

	setup_complete_unit()

	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor009, 2)
	dot_unit_dir(DotActor015, 2)
	dot_unit_dir(DotActor016, 2)
	dot_unit_dir(DotActor017, 2)
	dot_unit_dir(DotActor018, 2)
	dot_unit_dir(DotActor019, 2)

	dot_disp_weapon(DotActor017, false)
	dot_disp_weapon(DotActor018, false)
	dot_disp_weapon(DotActor019, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(10,14, 0.0)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
dot_disp_unit(DotActor012,false)
dot_disp_unit(DotActor013,false)
dot_disp_unit(DotActor014,false)
dot_disp_unit(DotActor015,false)
dot_disp_unit(DotActor016,false)
dot_disp_unit(DotActor017,false)
dot_disp_unit(DotActor018,false)
dot_disp_unit(DotActor019,false)
dot_disp_unit(DotActor010,false)
dot_disp_unit(DotActor011,false)
dot_disp_unit(DotActor005,false)
dot_disp_unit(DotActor020,false)
dot_disp_unit(DotActor006,false)
Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
Flash=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
Tele1=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Teleport_Killers", false, true)
Tele2=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Teleport_Killers", false, true)
Aura1=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
Aura2=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
Aura3=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
Aura4=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Aura5=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Aura6=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Aura7=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Aura8=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Aura9=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
Roar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
Roar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

	--★★ティルフィング★★:…──そう、呼ばれていますから
	change_face(Actor001, "Laugh")
	open_speech_window("CHRNAME_TYRFING", Actor001, nil)
	message("MS_002_0820002")

close_speech_window()

on_active(Tele1)

local gridpos = get_grid_position(7,13)
set_pos(Tele1, gridpos)
play_particle(Tele1)
wait_time(1.0)
dot_disp_unit(DotActor006, true)
dot_unit_dir(DotActor006,3)
wait_time(2.0)

	--★★アルハン★★:フライクーゲル！！
	change_face(Actor002, "Anger")
	open_speech_window("NPCNAME_0313", Actor002, nil)
	message("MS_002_0820003")

close_speech_window()

dot_unit_dir(DotActor003,2)
wait_time(1.0)

PlayPartVoiceDirect("フライクーゲル","0057")

	--★★フライクーゲル★★:アルハン、遅いよぉ…っ
	change_face(Actor003, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820004")

	close_speech_window()

	--★★アルハン★★:すまぬ、<%player>の消耗により<br>帰還に遅れが生じ…
	change_face(Actor002, "Sad")
	open_speech_window("NPCNAME_0313", Actor002, nil)
	message("MS_002_0820005")

PlayPartVoiceDirect("アルハン","0021")

	--★★アルハン★★:さらにイミテーションが発生させた空間が邪魔で<br>キサマに干渉できなかったのだ…！
	message("MS_002_0820006")

	--★★アルハン★★:しかしフライクーゲル…<br>あの空間を、どうやって………？
	change_face(Actor002, "Normal")
	message("MS_002_0820007")

	close_speech_window()

	--★★フライクーゲル★★:バルバロイの力で構築された空間<br>なんでしょ…？
	change_face(Actor003, "Normal")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820008")

	--★★フライクーゲル★★:だったらバルバロイを片っ端から<br>蜂の巣にしまくって、その力を削いで──
	message("MS_002_0820009")

	--★★フライクーゲル★★:逃げ道を作っただけ<br>賭けだったけどね
	change_face(Actor003, "Laugh")
	message("MS_002_0820010")

	close_speech_window()

	--★★テロップ★★:「いつもハズしてばっかり」
	open_narration_window()
	message("MS_002_0820012")

close_narration_window()

dot_unit_dir(DotActor003,3)
wait_time(1.0)

PlayPartVoiceDirect("フライクーゲル","0038")

	--★★フライクーゲル★★:予想は的中！<br>でしょ、<ruby=イミテーション>ソックリさん</ruby>？
	change_face(Actor003, "Smile")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820013")

close_speech_window()
bgm_play("Set_BGM_Bus_LPF_Volume_short")

dot_change_anim(DotActor007,4)
wait_time(0.2)
se_play("SE_ADV_EA_010_047_Imitation_Song")
on_active(Roar) 
local gridpos = get_grid_position(12,14)
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

local gridpos = get_grid_position(5,14)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)
local gridpos = get_grid_position(5,16)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)
local gridpos = get_grid_position(7,15)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)

local gridpos = get_grid_position(9,16)
set_pos(Ef_bar4, gridpos)
set_scale(Ef_bar4, {1.2, 1.2, 1.2})
play_particle(Ef_bar4)
local gridpos = get_grid_position(10,15)
set_pos(Ef_bar5, gridpos)
set_scale(Ef_bar5, {0.8, 0.8, 0.8})
play_particle(Ef_bar5)

wait_time(0.2)
dot_disp_unit(DotActor012, true)
dot_unit_dir(DotActor012,3)
dot_disp_unit(DotActor013, true)
dot_unit_dir(DotActor013,3)
dot_disp_unit(DotActor014, true)
dot_unit_dir(DotActor014,3)
dot_disp_unit(DotActor015, true)
dot_disp_unit(DotActor016, true)
wait_time(2.0)
se_play("SE_LoopSE_Stop")
wait_time(1.0)
wait_camera()
dot_change_anim(DotActor007,0)
bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	--★★ディナタン★★:おやすみなさい
	open_speech_window("CHRNAME_DINATAN3", nil, Actor007)
	message("MS_002_0820016")

close_speech_window()
move_camera(8,14, 1.0)
wait_camera()

PlayPartVoiceDirect("フライクーゲル","0013")

	--★★フライクーゲル★★:まだまだ寝ないよ
	change_face(Actor003, "Normal")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820017")

close_speech_window()

dot_disp_unit(DotActor020,true)
dot_move_unit_seq(DotActor020,7,16)
wait_seq()
dot_unit_dir(DotActor020,0)

dot_change_anim(DotActor020,3)
wait_time(0.1)
dot_play_particle_unit(DotActor020,"Ef_C_Spr_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor015,6)
dot_change_anim(DotActor013,6)
dot_play_particle_unit(DotActor015,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor013,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.1)
dot_change_anim(DotActor014,6)
dot_change_anim(DotActor016,6)
dot_play_particle_unit(DotActor014,"Ef_C_Cmn_N_Hit_Spe01",1,true)
dot_play_particle_unit(DotActor016,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.1)

dot_change_anim(DotActor012,6)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_N_Hit_Spe01",1,true)
wait_time(0.2)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor013,"Ef_C_Cmn_DieEmy01",2,true) 
dot_play_particle_unit(DotActor014,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor016,"Ef_C_Cmn_DieEmy01",2,true) 
dot_play_particle_unit(DotActor015,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)

dot_disp_unit(DotActor012, false)
dot_disp_unit(DotActor013, false)
dot_disp_unit(DotActor014, false)
dot_disp_unit(DotActor015, false)
dot_disp_unit(DotActor016, false)

dot_remove_unit(DotActor012)
dot_remove_unit(DotActor013)
dot_remove_unit(DotActor014)
dot_remove_unit(DotActor015)
dot_remove_unit(DotActor016)
wait_time(1.0)
dot_move_unit_seq(DotActor020,7,15)
wait_seq()
dot_change_anim(DotActor020,0)
dot_unit_dir(DotActor020,3)

PlayPartVoiceDirect("リリアーナ","0007")

	--★★ロンギヌス★★:お泊り会中ですからね
	change_face(Actor020, "Laugh")
	open_speech_window("CHRNAME_LONGINUS", Actor020, nil)
	message("MS_002_0820019")

close_speech_window()

dot_disp_unit(DotActor005,true)
dot_move_unit_seq(DotActor005,10,15)
move_camera(10,14, 1.0)
wait_seq()
dot_unit_dir(DotActor005,3)

dot_change_anim(DotActor007,3)
dot_change_anim(DotActor005,3)
wait_time(0.1)
dot_play_particle_unit(DotActor007,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor005,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor007,6)
dot_move_knockback(DotActor007,14,14,0.2,2)
wait_time(0.4)
dot_change_anim(DotActor007,0)
dot_change_anim(DotActor005,0)
wait_camera()

PlayPartVoiceDirect("レーヴァテイン","0002")

	--★★レーヴァテイン★★:
	open_speech_window("CHRNAME_LAEVATEIN", Actor005, nil)
	message("MS_002_0820021")

close_speech_window()

PlayPartVoiceDirect("フライクーゲル","0064")

	--★★フライクーゲル★★:閑話休題！
	change_face(Actor003, "Smile")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820022")

	--★★フライクーゲル★★:感動の再会はこのあとで
	change_face(Actor003, "Laugh")
	message("MS_002_0820023")

close_speech_window()

dot_unit_dir(DotActor003,2)
wait_time(1.0)

	--★★フライクーゲル★★:…──ね、ダーリン？
	change_face(Actor003, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820025")

	open_select_window_tag(Actor006,"Smile","MS_002_0820027")
	close_speech_window()

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

wait_time(2.0)

	goto Block1end

::Block1end::

PlayPartVoiceDirect("フライクーゲル","0038")

	--★★フライクーゲル★★:………いえすっ
	change_face(Actor003, "Smile")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820032")

close_speech_window()

dot_unit_dir(DotActor005,2)
wait_time(0.5)

	--★★レーヴァテイン★★:おかえり、ティルフィング
	change_face(Actor005, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor005, nil)
	message("MS_002_0820034")

close_speech_window()

	--★★ティルフィング★★:…ただいま、戻りました
	open_speech_window("CHRNAME_TYRFING", Actor001, nil)
	message("MS_002_0820035")

	close_speech_window()

	--★★ディナタン★★:アアアアアアアアアアアアッッ！！！！
	change_face(Actor007, "Anger")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor007)
	message("MS_002_0820036")

close_speech_window()
bgm_play("Set_BGM_Bus_LPF_Volume_short")

dot_unit_dir(DotActor005,3)
dot_unit_dir(DotActor003,3)
move_camera(13,14, 1.0)
wait_camera()

dot_change_anim(DotActor007,4)
wait_time(0.2)
se_play("SE_ADV_EA_010_047_Imitation_Song")
on_active(Roar) 
local gridpos = get_grid_position(14,14)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

on_active(Aura1)
local gridpos = get_grid_position(14, 14)
set_pos(Aura1, gridpos)
play_particle(Aura1)
wait_time(1.0)

on_active(Aura2)
on_active(Aura3)

local gridpos = get_grid_position(13, 13)
set_pos(Aura2, gridpos)
play_particle(Aura2)
local gridpos = get_grid_position(13, 15)
set_pos(Aura3, gridpos)
play_particle(Aura3)

wait_time(0.5)

on_active(Aura4)
on_active(Aura5)
on_active(Aura6)
local gridpos = get_grid_position(14, 14)
set_pos(Aura4, gridpos)
play_particle(Aura4)
local gridpos = get_grid_position(13, 13)
set_pos(Aura5, gridpos)
play_particle(Aura5)
local gridpos = get_grid_position(13, 15)
set_pos(Aura6, gridpos)
play_particle(Aura6)

wait_time(0.5)

local gridpos = get_grid_position(14, 14)
gridpos[2] = 1.2
slidemove(Aura4, gridpos, 0.8)
dot_move_height(DotActor007,1.5,0.8,2)
wait_time(0.5)

local gridpos = get_grid_position(13,13)
gridpos[2] = 1.2
slidemove(Aura5, gridpos, 0.8)
dot_move_height(DotActor008,1.5,0.8,2)
local gridpos = get_grid_position(13, 15)
gridpos[2] = 1.2
slidemove(Aura6, gridpos, 0.8)
dot_move_height(DotActor009,1.5,0.8,2)
wait_time(1.0)

	se_play("SE_ADV_MA_01A900_46_WhiteDrg_Fusion")

local gridpos = get_grid_position(14, 14)
gridpos[2] = 1.2 
set_pos(Flash, gridpos)
on_active(Flash)
play_particle(Flash)
set_scale(Flash, {1.5, 1.5, 1.5})
wait_time(0.3)
move_camera(13,14, 0)
change_camera_distance(10.0, 0)
wait_camera()
stop_particle(Aura4)
stop_particle(Aura5)
stop_particle(Aura6)

wait_time(0.2)
dot_remove_unit(DotActor007)
dot_remove_unit(DotActor008)
dot_remove_unit(DotActor009)
dot_disp_unit(DotActor017,true)
dot_disp_unit(DotActor018,true)
dot_disp_unit(DotActor019,true)

on_active(Aura7)
on_active(Aura8)
on_active(Aura9)
local gridpos = get_grid_position(12, 13)
set_pos(Aura7, gridpos)
play_particle(Aura7)
local gridpos = get_grid_position(12, 17)
set_pos(Aura8, gridpos)
play_particle(Aura8)
local gridpos = get_grid_position(15, 15)
set_pos(Aura9, gridpos)
play_particle(Aura9)

wait_time(2.0)

dot_change_anim(DotActor019,3)
wait_time(0.5)
se_play("SE_ADV_MA_01A900_36_WhiteDrg_Roar")
on_active(Roar) 
local gridpos = get_grid_position(16,15)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

dot_change_anim(DotActor019,0)
dot_change_anim(DotActor018,3)
dot_change_anim(DotActor017,3)
wait_time(0.5)
on_active(Roar2) 
on_active(Roar3) 
local gridpos = get_grid_position(13,13)
set_pos(Roar2, gridpos)
play_particle(Roar2)
local gridpos = get_grid_position(13,17)
set_pos(Roar3, gridpos)
play_particle(Roar3)
wait_time(1.0)

dot_change_anim(DotActor018,0)
dot_change_anim(DotActor017,0)
wait_time(1.0)
move_camera(10,14, 1.0)
wait_camera()

dot_unit_dir(DotActor003,2)
wait_time(0.5)
bgm_play("Reset_BGM_Bus_LPF_Volume_2")

PlayPartVoiceDirect("フライクーゲル","0049")

	--★★フライクーゲル★★:ダーリン、聞かせて。もう一度
	change_face(Actor003, "Normal")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820039")

	--★★フライクーゲル★★:きみの武器の名を！
	change_face(Actor003, "Anger")
	message("MS_002_0820040")

	open_select_window_tag(Actor006,"Anger","MS_002_0820042")
	close_speech_window()

	if is_select(1) then
		goto Block2_1
	end

::Block2_1::

dot_unit_dir(DotActor003,3)

	goto Block2end

::Block2end::

on_active(Tele1)
on_active(Tele2)

local gridpos = get_grid_position(10,13)
set_pos(Tele1, gridpos)
play_particle(Tele1)
local gridpos = get_grid_position(10,16)
set_pos(Tele2, gridpos)
play_particle(Tele2)
wait_time(1.0)
dot_disp_unit(DotActor010,true)
dot_unit_dir(DotActor010,3)
dot_disp_unit(DotActor011,true)
dot_unit_dir(DotActor011,3)
wait_time(2.0)

dot_change_anim(DotActor010,3)
dot_change_anim(DotActor011,3)
wait_time(0.1)
dot_play_particle_unit(DotActor010,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor011,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor017,6)
dot_change_anim(DotActor018,6)
dot_play_particle_unit(DotActor017,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(1.0)
dot_change_anim(DotActor010,0)
dot_change_anim(DotActor011,0)
dot_change_anim(DotActor017,0)
dot_change_anim(DotActor018,0)

	--★★ディナタン★★:
	change_face(Actor007, "Surprise")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor007)
	message("MS_002_0820047")

	close_speech_window()

	--★★フライクーゲル★★:
	change_face(Actor003, "Sad")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820048")

	--★★フライクーゲル★★:
	change_face(Actor003, "Anger")
	message("MS_002_0820049")

	close_speech_window()

	--★★レーヴァテイン★★:
	change_face(Actor005, "Smile")
	open_speech_window("CHRNAME_LAEVATEIN", Actor005, nil)
	message("MS_002_0820051")

close_speech_window()

PlayPartVoiceDirect("フライクーゲル","0069")

	--★★フライクーゲル★★:ターゲット・ロックオーン！
	change_face(Actor003, "Smile")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820052")

close_speech_window()

dot_change_anim(DotActor003,3)
wait_time(0.1)
dot_play_particle_unit(DotActor003,"Ef_C_Gu2_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor019,6)
dot_play_particle_unit(DotActor019,"Ef_C_Cmn_N_Hit_Spe01",1,true)


PlayPartVoiceDirect("ディナタン_008","0043")

	--★★ディナタン★★:
	change_face(Actor007, "Pain")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor007)
	message("MS_002_0820055")

dot_change_anim(DotActor019,0)
dot_change_anim(DotActor003,0)

	close_speech_window()

	--★★ロンギヌス★★:
	change_face(Actor020, "Smile")
	open_speech_window("CHRNAME_LONGINUS", Actor020, nil)
	message("MS_002_0820056")

	close_speech_window()

	--★★フライクーゲル★★:運命の<br>ど真ん中
	change_face(Actor003, "Laugh")
	open_speech_window("CHRNAME_FREIKUGEL", Actor003, nil)
	message("MS_002_0820057")

PlayPartVoiceDirect("フライクーゲル","0038")

	open_cutin(1,1)
	on_cutin(1,Actor003,"Smile")

	close_speech_window()

	--★★フライクーゲル★★:命中させるよ
	open_speech_window("CHRNAME_FREIKUGEL", nil, nil)
	message("MS_002_0820059")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101001002)
	character2DFull_Preload(Actor002, "Actor002", 101059001)
	character2DFull_Preload(Actor003, "Actor003", 101070002)
	character2DFull_Preload(Actor005, "Actor005", 101002001)
	character2DFull_Preload(Actor006, "Actor006", playerId)
	character2DFull_Preload(Actor007, "Actor007", 101012008)
	character2DFull_Preload(Actor008, "Actor008", 101011007)
	character2DFull_Preload(Actor009, "Actor009", 101010007)
	character2DFull_Preload(Actor010, "Actor010", 101011002)
	character2DFull_Preload(Actor011, "Actor011", 101010002)
	character2DFull_Preload(Actor020, "Actor020", 101035002)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Teleport_Killers", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Teleport_Killers", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
end
