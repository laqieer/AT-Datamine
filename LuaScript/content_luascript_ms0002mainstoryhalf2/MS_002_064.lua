-- このluaスクリプトは、MS_002_064から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(2,1)

	Actor001 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor001, "Actor001", playerId)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101009001)
	DotActor002 = dot_reserve_ally(101009001, 20, 12, 0)
	dot_set_weapon(DotActor002, 101010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(101012001, 22, 14, 0)
	dot_set_weapon(DotActor003, 108010001)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101068002)
	DotActor004 = dot_reserve_ally(101068001, 19, 14, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101001002)
	DotActor005 = dot_reserve_ally(101001002, 20, 21, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201001001, 18, 11, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201001001, 19, 11, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201001001, 20, 11, 0)
	dot_set_weapon(DotActor008, 101010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201001001, 21, 11, 0)
	dot_set_weapon(DotActor009, 101010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201001001, 22, 11, 0)
	dot_set_weapon(DotActor010, 101010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201001001, 17, 8, 0)
	dot_set_weapon(DotActor011, 101010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(201001001, 18, 8, 0)
	dot_set_weapon(DotActor012, 101010001)

	Actor013 = set_chara_unknown()
	DotActor013 = dot_reserve_ally(201001001, 22, 8, 0)
	dot_set_weapon(DotActor013, 101010001)

	Actor014 = set_chara_unknown()
	DotActor014 = dot_reserve_ally(201001001, 23, 8, 0)
	dot_set_weapon(DotActor014, 101010001)

	Actor015 = set_chara_unknown()
	DotActor015 = dot_reserve_ally(201001001, 19, 6, 0)
	dot_set_weapon(DotActor015, 101010001)

	Actor016 = set_chara_unknown()
	DotActor016 = dot_reserve_ally(201001001, 20, 6, 0)
	dot_set_weapon(DotActor016, 101010001)

	Actor017 = set_chara_unknown()
	DotActor017 = dot_reserve_ally(201001001, 21, 6, 0)
	dot_set_weapon(DotActor017, 101010001)

	Actor018 = set_chara_unknown()
	DotActor018 = dot_reserve_ally(201026001, 19, 8, 0)
	dot_set_weapon(DotActor018, 102020001)

	Actor019 = set_chara_unknown()
	DotActor019 = dot_reserve_ally(201026001, 17, 3, 0)
	dot_set_weapon(DotActor019, 102020001)

	Actor020 = set_chara_unknown()
	DotActor020 = dot_reserve_ally(201026001, 21, 3, 0)
	dot_set_weapon(DotActor020, 102020001)

	setup_complete_unit()

	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor009, 2)
	dot_unit_dir(DotActor010, 2)
	dot_unit_dir(DotActor011, 2)
	dot_unit_dir(DotActor012, 2)
	dot_unit_dir(DotActor013, 2)
	dot_unit_dir(DotActor014, 2)
	dot_unit_dir(DotActor015, 2)
	dot_unit_dir(DotActor016, 2)
	dot_unit_dir(DotActor017, 2)
	dot_unit_dir(DotActor018, 2)
	dot_unit_dir(DotActor019, 2)
	dot_unit_dir(DotActor020, 2)

	dot_disp_weapon(DotActor004, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(30.0, 0.0)
move_camera(20, 12, 0.0)
dot_disp_weapon(DotActor003,false)
dot_disp_weapon(DotActor004,false)
dot_disp_unit(DotActor005,false)
dot_disp_unit(DotActor019,false)
dot_disp_unit(DotActor020,false)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_fh1 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
dot_change_anim(DotActor003,1)
dot_change_anim(DotActor004,1)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

wait_time(0.2)

dot_unit_dir(DotActor002,0)
dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Swd_N_Atk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor006,6)
dot_change_anim(DotActor007,6)
dot_change_anim(DotActor008,6)
dot_change_anim(DotActor009,6)
dot_change_anim(DotActor010,6)

dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor006,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)

dot_place_unit(DotActor006,18,20)
dot_place_unit(DotActor007,19,20)
dot_place_unit(DotActor008,20,20)
dot_place_unit(DotActor009,21,20)
dot_place_unit(DotActor010,22,20)
dot_change_anim(DotActor006,0)
dot_change_anim(DotActor007,0)
dot_change_anim(DotActor008,0)
dot_change_anim(DotActor009,0)
dot_change_anim(DotActor010,0)
wait_time(0.5)
dot_change_anim(DotActor002,0)

dot_move_unit_seq(DotActor002,20,11)
wait_seq()


dot_unit_dir(DotActor002,0)
dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Swd_N_Atk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor018,6)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Critical01",1,true)
wait_time(0.2)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_DieBos01",2,true)
wait_time(0.5)
dot_disp_unit(DotActor018,false)
dot_change_anim(DotActor018,0)
wait_time(0.5)
dot_change_anim(DotActor002,0)
wait_camera(0.5)


move_camera(20,16,2.0)
wait_time(0.2)

dot_reserve_move_unit_seq(DotActor006,18,16)
dot_reserve_move_unit_seq(DotActor007,19,16)
dot_reserve_move_unit_seq(DotActor008,20,16)
dot_reserve_move_unit_seq(DotActor009,21,16)
dot_reserve_move_unit_seq(DotActor010,22,16)
dot_reserve_move_unit_seq(DotActor015,19,10)
dot_reserve_move_unit_seq(DotActor016,20,10)
dot_reserve_move_unit_seq(DotActor017,21,10)
exec_parallel_seq()
wait_seq()

dot_unit_dir(DotActor006,2)
dot_unit_dir(DotActor007,2)
dot_unit_dir(DotActor008,2)
dot_unit_dir(DotActor009,2)
dot_unit_dir(DotActor010,2)
dot_unit_dir(DotActor015,2)
dot_unit_dir(DotActor016,2)
dot_unit_dir(DotActor017,2)

dot_reserve_move_unit_seq(DotActor011,18,9)
dot_reserve_move_unit_seq(DotActor012,18,10)
dot_reserve_move_unit_seq(DotActor013,22,9)
dot_reserve_move_unit_seq(DotActor014,22,10)
exec_parallel_seq()
wait_seq()

dot_unit_dir(DotActor011,2)
dot_unit_dir(DotActor012,2)
dot_unit_dir(DotActor013,2)
dot_unit_dir(DotActor014,2)
dot_disp_unit(DotActor005,true)
dot_reserve_move_unit_seq(DotActor005,20,17)
dot_reserve_move_unit_seq(DotActor002,20,13)
exec_parallel_seq()
wait_seq()


dot_unit_dir(DotActor005,0)
dot_change_anim(DotActor005,3)
wait_time(0.1)
dot_play_particle_unit(DotActor005,"Ef_C_Swd_N_Atk01",3,true)

wait_time(0.1)


dot_change_anim(DotActor006,6)
dot_change_anim(DotActor007,6)
dot_change_anim(DotActor008,6)
dot_change_anim(DotActor009,6)
dot_change_anim(DotActor010,6)

dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor006,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)
dot_remove_unit(DotActor006)
dot_remove_unit(DotActor007)
dot_remove_unit(DotActor008)
dot_remove_unit(DotActor009)
dot_remove_unit(DotActor010)
wait_time(0.5)
dot_change_anim(DotActor005,0)
wait_camera()


move_camera(20,13,1.0)
dot_move_unit_seq(DotActor005,19,13)
wait_seq()
dot_unit_dir(DotActor005,3)
dot_unit_dir(DotActor002,2)
wait_time(0.5)
wait_camera()

PlayPartVoiceDirect("ティルフィング","0037")

	--★★ティルフィング★★:遅れて申し訳ございません、マスター…！<br>町中のバルバロイに阻まれ──
	change_face(Actor005, "Sad")
	open_speech_window("CHRNAME_TYRFING", Actor005, nil)
	message("MS_002_0640006")

	--★★ティルフィング★★:………！
	change_face(Actor005, "Surprise")
	message("MS_002_0640007")

close_speech_window()

dot_unit_dir(DotActor005,2)
wait_time(0.5)

PlayPartVoiceDirect("ウレリー","0016")

	--★★ウレリー★★:…？<br>ティルフィング、さん…？
	change_face(Actor004, "Sad")
	open_speech_window("CHRNAME_URRIE", Actor004, nil)
	message("MS_002_0640008")

close_speech_window()

wait_time(1.0)
dot_unit_dir(DotActor005,3)
wait_time(0.5)

	--★★ティルフィング★★:マスター…
	open_speech_window("CHRNAME_TYRFING", Actor005, nil)
	message("MS_002_0640009")

	--★★ティルフィング★★:ディナタン様とウレリー様を守りながら<br>この数のバルバロイをさばき切ったのですか…？
	message("MS_002_0640010")

close_speech_window()
PlayPartVoiceDirect("ノワール","0007")

	--★★ノワール★★:ああ<br>だけど、これからのために──
	open_speech_window("CHRNAME_NOIR", Actor002, nil)
	message("MS_002_0640011")

	open_select_window_tag(Actor001,"Normal","MS_002_0640013")
	close_speech_window()

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

move_camera(20,6,2.0)
dot_place_unit(DotActor018,19,6)
wait_time(0.5)

	goto Block1end

::Block1end::

on_active(Ef_bar1)
local gridpos = get_grid_position(18, 5)
set_pos(Ef_bar1, gridpos)
set_scale(Ef_bar1, {1.2, 1.2, 1.2})
play_particle(Ef_bar1)

on_active(Ef_bar2)
local gridpos = get_grid_position(22, 5)
set_pos(Ef_bar2, gridpos)
set_scale(Ef_bar2, {1.2, 1.2, 1.2})
play_particle(Ef_bar2)

on_active(Ef_bar3)
local gridpos = get_grid_position(20, 8)
set_pos(Ef_bar3, gridpos)
set_scale(Ef_bar3, {1.2, 1.2, 1.2})
play_particle(Ef_bar3)

wait_time(1.0)


on_active(Ef_fh1)
gridpos[2]=1.0
set_pos(Ef_fh1,gridpos)
set_scale(Ef_fh1, {1.2, 1.2, 1.2})
play_particle(Ef_fh1)

wait_time(0.2)
dot_disp_unit(DotActor018,true)
dot_disp_unit(DotActor019,true)
dot_disp_unit(DotActor020,true)

wait_time(1.0)
wait_camera()

wait_time(1.0)
move_camera(20,13,2.0)
wait_camera()

voice_play("VO_101009_sp_0007_1")

	--★★ノワール★★:キミが必要だ<br>ティルフィング
	open_speech_window("CHRNAME_NOIR", Actor002, nil)
	message("MS_002_0640019")

close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Actor005,"Surprise")

wait_time(2.0)

	close_cutin()

wait_time(0.5)

	--★★ティルフィング★★:…はい
	change_face(Actor005, "Laugh")
	open_speech_window("CHRNAME_TYRFING", Actor005, nil)
	message("MS_002_0640022")

PlayPartVoiceDirect("ティルフィング","swim_0035")

	--★★ティルフィング★★:全霊をもって
	change_face(Actor005, "Anger")
	message("MS_002_0640023")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", playerId)
	character2DFull_Preload(Actor002, "Actor002", 101009001)
	character2DFull_Preload(Actor004, "Actor004", 101068002)
	character2DFull_Preload(Actor005, "Actor005", 101001002)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
end
