-- このluaスクリプトは、EA_010_047から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101002001)
	DotActor001 = dot_reserve_ally(101002001, 35, 32, 0)
	dot_set_weapon(DotActor001, 101030001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101035002)
	DotActor002 = dot_reserve_ally(101035002, 34, 31, 0)
	dot_set_weapon(DotActor002, 104010001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101012009)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101012008)
	DotActor004 = dot_reserve_ally(101012008, 39, 32, 0)
	dot_set_weapon(DotActor004, 101010001)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101011002)
	DotActor005 = dot_reserve_ally(101011002, 37, 31, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	character2DFull(Actor006, "Actor006", 101010002)
	DotActor006 = dot_reserve_ally(101010002, 37, 33, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor007, "Actor007", playerId)
	DotActor007 = dot_reserve_ally(playerId, 35, 31, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201004001, 40, 30, 0)
	dot_set_weapon(DotActor008, 104010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201005001, 40, 33, 0)
	dot_set_weapon(DotActor009, 105010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201001001, 36, 33, 0)
	dot_set_weapon(DotActor010, 101010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201002001, 35, 34, 0)
	dot_set_weapon(DotActor011, 102010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(201003001, 34, 34, 0)
	dot_set_weapon(DotActor012, 103010001)

	Actor013 = set_chara_unknown()
	DotActor013 = dot_reserve_ally(201006001, 32, 33, 0)
	dot_set_weapon(DotActor013, 106010001)

	Actor014 = set_chara_unknown()
	DotActor014 = dot_reserve_ally(201004001, 32, 31, 0)
	dot_set_weapon(DotActor014, 104010001)

	Actor015 = set_chara_unknown()
	DotActor015 = dot_reserve_ally(201003001, 36, 31, 0)
	dot_set_weapon(DotActor015, 103010001)

	Actor016 = set_chara_unknown()
	DotActor016 = dot_reserve_ally(201002001, 33, 30, 0)
	dot_set_weapon(DotActor016, 102010001)

	Actor017 = set_chara_unknown()
	DotActor017 = dot_reserve_ally(201001001, 38, 30, 0)
	dot_set_weapon(DotActor017, 101010001)

	Actor018 = set_chara_unknown()
	DotActor018 = dot_reserve_ally(201001001, 38, 34, 0)
	dot_set_weapon(DotActor018, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor001, 2)
	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor009, 2)
	dot_unit_dir(DotActor010, 2)
	dot_unit_dir(DotActor011, 2)
	dot_unit_dir(DotActor015, 2)
	dot_unit_dir(DotActor017, 2)
	dot_unit_dir(DotActor018, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(34.0, 0.0)
move_camera(35,32, 0.0)
dot_disp_unit(DotActor004,false)
dot_disp_unit(DotActor008,false)
dot_disp_unit(DotActor009,false)
dot_disp_unit(DotActor010,false)
dot_disp_unit(DotActor011,false)
dot_disp_unit(DotActor012,false)
dot_disp_unit(DotActor013,false)
dot_disp_unit(DotActor014,false)
dot_disp_unit(DotActor015,false)
dot_disp_unit(DotActor016,false)
dot_disp_unit(DotActor017,false)
dot_disp_unit(DotActor018,false)
dot_disp_weapon(DotActor001,false)
dot_disp_weapon(DotActor002,false)
dot_disp_weapon(DotActor007,false)
dot_disp_weapon(DotActor006,false)
dot_disp_weapon(DotActor005,false)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_sound("BGM_Battle_Boss_Start")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

se_play("SE_ADV_MA_01A112_31_Earthquake")
wait_time(0.3)
dot_unit_dir(DotActor001,3)
dot_unit_dir(DotActor006,2)
wait_time(0.2)
dot_unit_dir(DotActor007,3)
dot_unit_dir(DotActor005,2)
wait_time(0.5)
dot_unit_dir(DotActor002,2)
wait_time(0.3)
dot_unit_dir(DotActor007,2)
dot_unit_dir(DotActor005,3)
wait_time(0.5)
dot_unit_dir(DotActor001,2)
dot_unit_dir(DotActor006,3)
wait_time(0.3)
dot_unit_dir(DotActor007,3)
dot_unit_dir(DotActor005,2)
wait_time(1.0)

PlayPartVoiceDirect("レーヴァテイン","0024")

	--★★レーヴァテイン★★:まだ………来るの！？
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("EA_010_0470005")

close_speech_window()
dot_unit_dir(DotActor006,2)
dot_unit_dir(DotActor002,3)

	--★★ロンギヌス★★:そ、そうだ<br>…も、もうひとり
	change_face(Actor002, "Sad")
	open_speech_window("CHRNAME_LONGINUS", Actor002, nil)
	message("EA_010_0470006")

dot_unit_dir(DotActor007,2)

	open_select_window_tag(Actor007,"Normal","EA_010_0470008")
	close_speech_window()

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

	--★★ロンギヌス★★:
	open_speech_window("CHRNAME_LONGINUS", Actor002, nil)
	message("EA_010_0470010")

	goto Block1end

::Block1end::

	--★★ディナタン（影）★★:
	change_face(Actor003, "Normal")
	if is_select(1) then
		close_speech_window()
		open_speech_window("CHRNAME_NAMELES", nil, Actor003)
	end
	message("EA_010_0470012")

close_speech_window()

	open_cutin(3,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor007,"Surprise")
	on_cutin(3,Actor002,"Surprise")

wait_time(2.0)
close_cutin()
dot_unit_dir(DotActor007,3)
dot_unit_dir(DotActor001,3)
dot_unit_dir(DotActor006,3)
dot_unit_dir(DotActor005,3)
move_camera(37, 32, 1.0)

on_active(Ef_bar1) 
local gridpos = get_grid_position(39,32)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)
wait_time(0.2)        
dot_disp_unit(DotActor004, true)
wait_camera()
wait_time(2.0)

	--★★ロンギヌス★★:あれは………っ
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_LONGINUS", Actor002, nil)
	message("EA_010_0470015")

	close_speech_window()

	--★★ディナタン★★:歌います
	change_face(Actor004, "Normal")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor004)
	message("EA_010_0470016")

bgm_play("Stop_BGM_Bus_2")

close_speech_window()
dot_disp_weapon(DotActor006,true)
dot_disp_weapon(DotActor005,true)

dot_change_anim(DotActor004,4)
wait_time(0.2)
se_play("SE_ADV_EA_010_047_Imitation_Song")
on_active(Roar) 
local gridpos = get_grid_position(39,32)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

on_active(Ef_bar2) 
on_active(Ef_bar3) 
local gridpos = get_grid_position(40,30)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)

local gridpos = get_grid_position(40,33)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)
wait_time(0.2)
dot_disp_unit(DotActor008, true)
dot_disp_unit(DotActor009, true)
wait_time(2.0)
dot_change_anim(DotActor004,0)

bgm_play("BGM_Battle_Boss_Start")

PlayPartVoiceDirect("レーヴァテイン","0030")

	--★★レーヴァテイン★★:イミテーション・ディナタン…！！ 
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("EA_010_0470018")

close_speech_window()

	--★★ディナタン★★:最後の継承者を<br>排除します
	open_speech_window("CHRNAME_DINATAN3", nil, Actor004)
	message("EA_010_0470019")

close_speech_window()
move_camera(38, 32, 0.5)
change_camera_distance(6.0, 0.5)

dot_reserve_move_unit_seq(DotActor005,38,31)
dot_reserve_move_unit_seq(DotActor006,38,33)
exec_parallel_seq()
wait_seq()

dot_change_anim(DotActor004,3)
dot_change_anim(DotActor005,3)
dot_change_anim(DotActor006,3)
wait_time(0.1)
dot_play_particle_unit(DotActor004,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor005,"Ef_C_Swd_N_Atk01",3,true)
dot_play_particle_unit(DotActor006,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.2)
wait_camera()

	--★★ギネヴィア★★:
	change_face(Actor005, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Actor005, nil)
	message("EA_010_0470022")

close_speech_window()
PlayPartVoiceDirect("ランスロット","0021")

	--★★ランスロット★★:
	change_face(Actor006, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Actor006, nil)
	message("EA_010_0470023")

close_speech_window()

dot_change_anim(DotActor004,0)
dot_change_anim(DotActor005,0)
dot_change_anim(DotActor006,0)
wait_time(0.1)
dot_change_anim(DotActor004,3)
wait_time(0.1)
dot_play_particle_unit(DotActor004,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor005,6)
dot_change_anim(DotActor006,6)
dot_play_particle_unit(DotActor005,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_EmySla01",1,true)

dot_move_knockback(DotActor005,37,31,0.2,2)
dot_move_knockback(DotActor006,37,33,0.2,2)
wait_time(0.3)
dot_change_anim(DotActor004,0)
dot_change_anim(DotActor005,1)
dot_change_anim(DotActor006,1)
wait_time(0.5)

PlayPartVoiceDirect("ディナタン_008","0010")

	--★★ディナタン★★:ふふふ
	change_face(Actor004, "Laugh")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor004)
	message("EA_010_0470025")

close_speech_window()
move_camera(37, 32, 0.5)
change_camera_distance(8.0, 0.5)

dot_change_anim(DotActor004,4)
wait_time(0.2)
se_play("SE_ADV_Emy001_Cry")
on_active(Roar) 
local gridpos = get_grid_position(39,32)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

on_active(Ef_bar2) 
on_active(Ef_bar3) 
local gridpos = get_grid_position(38,31)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)

local gridpos = get_grid_position(38,33)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)
wait_time(0.2)
dot_place_unit(DotActor017,38,31)
dot_place_unit(DotActor018,38,33)
dot_unit_dir(DotActor017,2)
dot_unit_dir(DotActor018,2)
dot_disp_unit(DotActor017, true)
dot_disp_unit(DotActor018, true)
wait_time(2.0)
dot_change_anim(DotActor004,0)

	--★★ディナタン★★:あはははははは
	change_face(Actor004, "Smile")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor004)
	message("EA_010_0470027")

close_speech_window()

PlayPartVoiceDirect("レーヴァテイン","0024")

	--★★レーヴァテイン★★:アロンダイトでも、止められない…！？<br>これは…！？
	change_face(Actor001, "Sad")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("EA_010_0470028")

close_speech_window()

on_active(Ef_bar4) 
on_active(Ef_bar5) 
on_active(Ef_bar6) 
local gridpos = get_grid_position(36,33)
set_pos(Ef_bar4, gridpos)
set_scale(Ef_bar4, {0.8, 0.8, 0.8})
play_particle(Ef_bar4)

local gridpos = get_grid_position(34,34)
set_pos(Ef_bar5, gridpos)
set_scale(Ef_bar5, {0.8, 0.8, 0.8})
play_particle(Ef_bar5)

local gridpos = get_grid_position(32,31)
set_pos(Ef_bar6, gridpos)
set_scale(Ef_bar6, {0.8, 0.8, 0.8})
play_particle(Ef_bar6)
wait_time(0.2)

dot_disp_unit(DotActor010, true)
dot_disp_unit(DotActor012, true)
dot_disp_unit(DotActor014, true)
wait_time(2.0)

PlayPartVoiceDirect("リリアーナ","0023")

	--★★ロンギヌス★★:
	change_face(Actor002, "Sad")
	open_speech_window("CHRNAME_LONGINUS", Actor002, nil)
	message("EA_010_0470030")

	--★★ロンギヌス★★:イミテーションと同様<br>ディナタンさんのアロンダイトはどこに…！？
	message("EA_010_0470031")

	close_speech_window()

	--★★ディナタン★★:どこにも
	change_face(Actor004, "Normal")
	open_speech_window("CHRNAME_DINATAN3", nil, Actor004)
	message("EA_010_0470032")

close_speech_window()
PlayPartVoiceDirect("リリアーナ","0024")

	--★★ロンギヌス★★:
	open_speech_window("CHRNAME_LONGINUS", Actor002, nil)
	message("EA_010_0470033")

close_speech_window()

on_active(Ef_bar1) 
on_active(Ef_bar2) 
on_active(Ef_bar3) 
on_active(Ef_bar7) 
local gridpos = get_grid_position(35,34)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {0.8, 0.8, 0.8})
play_particle(Ef_bar1)

local gridpos = get_grid_position(33,33)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {0.8, 0.8, 0.8})
play_particle(Ef_bar2)

local gridpos = get_grid_position(36,31)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {0.8, 0.8, 0.8})
play_particle(Ef_bar3)

local gridpos = get_grid_position(33,30)
set_pos(Ef_bar7, gridpos)
set_scale(Ef_bar7, {0.8, 0.8, 0.8})
play_particle(Ef_bar7)
wait_time(0.2)

dot_disp_unit(DotActor011, true)
dot_disp_unit(DotActor013, true)
dot_disp_unit(DotActor015, true)
dot_disp_unit(DotActor016, true)
wait_time(2.0)

	--★★バルバロイ1★★:キャキャキャキャキャキャキャキャ
	change_face(Actor008, "Normal")
	open_speech_window("CHRNAME_BARBAROI", Actor008, nil)
	message("EA_010_0470035")

	close_speech_window()

	--★★レーヴァテイン★★:………ううん
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("EA_010_0470036")

close_speech_window()

dot_move_unit_seq(DotActor001,35,33)
wait_seq()
dot_disp_weapon(DotActor001,true)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor011,6)
dot_change_anim(DotActor012,6)
dot_play_particle_unit(DotActor011,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor011,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_DieEmy01",2,true)  
wait_time(0.5)

dot_disp_unit(DotActor011, false)
dot_disp_unit(DotActor012, false)

dot_remove_unit(DotActor011)
dot_remove_unit(DotActor012)
wait_time(0.5)
dot_change_anim(DotActor001,0)

PlayPartVoiceDirect("レーヴァテイン","0035")

	--★★レーヴァテイン★★:攻めるのみ！！
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("EA_010_0470038")

	close_speech_window()

	--★★ロンギヌス★★:レーヴァテイン！？
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_LONGINUS", Actor002, nil)
	message("EA_010_0470039")

close_speech_window()

dot_move_unit_seq(DotActor001,35,32)
wait_seq()
dot_unit_dir(DotActor001,3)
dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor010,6)
dot_change_anim(DotActor015,6)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor015,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor010,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor015,"Ef_C_Cmn_DieEmy01",2,true)  
wait_time(0.5)

dot_disp_unit(DotActor010, false)
dot_disp_unit(DotActor015, false)

dot_remove_unit(DotActor010)
dot_remove_unit(DotActor015)
wait_time(0.5)
dot_change_anim(DotActor001,0)

	--★★レーヴァテイン★★:
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("EA_010_0470040")

close_speech_window()

dot_move_unit_seq(DotActor001,37,32)
wait_seq()
dot_change_anim(DotActor001,3)
dot_change_anim(DotActor017,3)
dot_change_anim(DotActor018,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
dot_play_particle_unit(DotActor017,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor018,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor001,0)
dot_change_anim(DotActor017,0)
dot_change_anim(DotActor018,0)
wait_time(0.2)

dot_change_anim(DotActor017,3)
dot_change_anim(DotActor018,3)
wait_time(0.1)
dot_play_particle_unit(DotActor017,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor018,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor001,6)
dot_play_particle_unit(DotActor001,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
dot_move_knockback(DotActor001,36,32,0.2,2)
wait_time(0.2)
dot_change_anim(DotActor001,0)
dot_change_anim(DotActor017,0)
dot_change_anim(DotActor018,0)
wait_time(0.5)

	--★★レーヴァテイン★★:私は、破滅の剣…！
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("EA_010_0470042")

	close_speech_window()

	--★★バルバロイ1★★:
	open_speech_window("CHRNAME_BARBAROI", Actor008, nil)
	message("EA_010_0470043")

	close_speech_window()

	--★★レーヴァテイン★★:あなたの破滅を斬り払い<br>地獄の底へと叩き込む
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_LAEVATEIN", Actor001, nil)
	message("EA_010_0470044")

	--★★レーヴァテイン★★:太刀打ちできない？<br>上等だよ！
	change_face(Actor001, "Anger")
	message("EA_010_0470048")

	--★★レーヴァテイン★★:<%player>、あなたは<br>そんな痛みとともに戦い続けてきた
	change_face(Actor001, "Normal")
	message("EA_010_0470049")

	--★★レーヴァテイン★★:なら私も<br>負けてられない
	message("EA_010_0470050")

	--★★レーヴァテイン★★:痛くても、笑ってみせる
	change_face(Actor001, "Smile")
	message("EA_010_0470051")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101002001)
	character2DFull_Preload(Actor002, "Actor002", 101035002)
	character2DFull_Preload(Actor003, "Actor003", 101012009)
	character2DFull_Preload(Actor004, "Actor004", 101012008)
	character2DFull_Preload(Actor005, "Actor005", 101011002)
	character2DFull_Preload(Actor006, "Actor006", 101010002)
	character2DFull_Preload(Actor007, "Actor007", get_player_styleId())
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
preload_sound("BGM_Battle_Boss_Start")
end
