-- このluaスクリプトは、EA_010_042から自動生成されました --
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
	DotActor001 = dot_reserve_ally(playerId, 17, 22, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101002001)
	DotActor002 = dot_reserve_ally(101002001, 19, 22, 0)
	dot_set_weapon(DotActor002, 101030001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101035002)

	Actor004 = set_chara_unknown()

	Actor005 = set_chara_unknown()

	Actor006 = set_chara_unknown()

	Actor007 = set_chara_unknown()
	character2DFull(Actor007, "Actor007", 101011008)

	Actor008 = set_chara_unknown()
	character2DFull(Actor008, "Actor008", 101010008)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(101011007, 20, 21, 0)
	dot_set_weapon(DotActor009, 101010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(101010007, 20, 22, 0)
	dot_set_weapon(DotActor010, 101010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201001001, 19, 21, 0)
	dot_set_weapon(DotActor011, 101010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(201001001, 19, 23, 0)
	dot_set_weapon(DotActor012, 101010001)

	Actor013 = set_chara_unknown()
	DotActor013 = dot_reserve_ally(201001001, 20, 24, 0)
	dot_set_weapon(DotActor013, 101010001)

	Actor014 = set_chara_unknown()
	DotActor014 = dot_reserve_ally(201001001, 22, 20, 0)
	dot_set_weapon(DotActor014, 101010001)

	Actor015 = set_chara_unknown()
	DotActor015 = dot_reserve_ally(201001001, 26, 21, 0)
	dot_set_weapon(DotActor015, 101010001)

	Actor016 = set_chara_unknown()
	DotActor016 = dot_reserve_ally(201001001, 26, 23, 0)
	dot_set_weapon(DotActor016, 101010001)

	setup_complete_unit()

	dot_unit_dir(DotActor009, 2)
	dot_unit_dir(DotActor010, 2)
	dot_unit_dir(DotActor011, 2)
	dot_unit_dir(DotActor012, 2)
	dot_unit_dir(DotActor013, 2)
	dot_unit_dir(DotActor014, 2)
	dot_unit_dir(DotActor015, 2)
	dot_unit_dir(DotActor016, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(45.0, 0.0)
move_camera(19, 22, 0.0)
Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true) 
local gridpos1 = get_grid_position(20,22)
set_pos(Ef_Aura_Enemy, gridpos1)
on_active(Ef_Aura_Enemy)
play_particle(Ef_Aura_Enemy)
load_image("201010153", "content_still_20101015_image", "201010153_StillImage")
	load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_change_anim(DotActor011,3)
dot_unit_dir(DotActor011,1)
wait_time(0.1)
dot_play_particle_unit(DotActor011,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)

wait_time(0.3)

dot_change_anim(DotActor012,3)
dot_unit_dir(DotActor012,0)
wait_time(0.1)
dot_play_particle_unit(DotActor012,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)
dot_change_anim(DotActor011,0)
dot_unit_dir(DotActor011,2)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)

wait_time(0.3)

dot_change_anim(DotActor009,3)
wait_time(0.1)
dot_play_particle_unit(DotActor009,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)
dot_change_anim(DotActor012,0)
dot_unit_dir(DotActor012,2)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_Critical01",1,true)

wait_time(0.5)
dot_change_anim(DotActor009,0)
dot_change_anim(DotActor002,0)

PlayPartVoiceDirect("レーヴァテイン","0043")

	--★★レーヴァテイン★★:叫んで！！<br><%player>！！
	change_face(Actor002, "Pain")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0420004")

close_speech_window()

dot_change_anim(DotActor012,3)
dot_unit_dir(DotActor012,0)
wait_time(0.1)
dot_play_particle_unit(DotActor012,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)

wait_time(0.3)

dot_change_anim(DotActor010,3)
wait_time(0.1)
dot_play_particle_unit(DotActor010,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)
dot_change_anim(DotActor012,0)
dot_unit_dir(DotActor012,2)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_Critical01",1,true)

wait_time(0.3)

dot_change_anim(DotActor011,3)
dot_unit_dir(DotActor011,1)
wait_time(0.1)
dot_play_particle_unit(DotActor011,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)
dot_change_anim(DotActor010,0)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)

wait_time(0.3)

dot_reserve_move_unit_seq(DotActor014,20,20)
dot_reserve_move_unit_seq(DotActor015,21,21)
dot_reserve_move_unit_seq(DotActor016,20,23)
exec_parallel_seq()

wait_time(0.2)

dot_change_anim(DotActor009,3)
dot_change_anim(DotActor010,3)
wait_time(0.1)
dot_play_particle_unit(DotActor010,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor009,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)
dot_change_anim(DotActor011,0)
dot_unit_dir(DotActor011,2)

dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_Critical01",1,true)

wait_time(0.5)
dot_change_anim(DotActor009,0)
dot_change_anim(DotActor010,0)
dot_change_anim(DotActor002,1)
wait_seq()

	--★★レーヴァテイン★★:あなたの──…！！
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0420006")

	--★★レーヴァテイン★★:あなたの武器の名を！！
	message("EA_010_0420007")

	--★★レーヴァテイン★★:きかせて！！！！
	message("EA_010_0420008")

	open_select_window_tag(Actor001,"Normal","EA_010_0420010")
	close_speech_window()

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

dot_change_anim(DotActor011,6)
dot_change_anim(DotActor012,6)
dot_play_particle_unit(DotActor011,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_N_Hit_Sla01",1,true)

wait_time(0.1)

	goto Block1end

::Block1end::

dot_change_anim(DotActor014,6)
dot_change_anim(DotActor016,6)
dot_play_particle_unit(DotActor014,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor016,"Ef_C_Cmn_N_Hit_Sla01",1,true)

wait_time(0.1)

dot_change_anim(DotActor015,6)
dot_change_anim(DotActor013,6)
dot_play_particle_unit(DotActor015,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor013,"Ef_C_Cmn_N_Hit_Sla01",1,true)

wait_time(0.2)

dot_play_particle_unit(DotActor011,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor012,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor013,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor014,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor015,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor016,"Ef_C_Cmn_DieEmy01",2,true)

wait_time(0.5)

dot_disp_unit(DotActor011, false)
dot_disp_unit(DotActor012, false)
dot_disp_unit(DotActor013, false)
dot_disp_unit(DotActor014, false)
dot_disp_unit(DotActor015, false)
dot_disp_unit(DotActor016, false)
dot_remove_unit(DotActor011)
dot_remove_unit(DotActor012)
dot_remove_unit(DotActor013)
dot_remove_unit(DotActor014)
dot_remove_unit(DotActor015)
dot_remove_unit(DotActor016)

wait_time(0.2)

dot_change_anim(DotActor009,6)
dot_change_anim(DotActor010,6)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Critical01",1,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_N_Hit_Critical01",1,true)
dot_move_knockback(DotActor009,22,21,0.5,2)
dot_move_knockback(DotActor010,22,22,0.5,2)
local gridpos1 = get_grid_position(22,22)
slidemove(Ef_Aura_Enemy,gridpos1,0.5)

wait_time(1.0)

dot_change_anim(DotActor009,0)
dot_change_anim(DotActor010,0)

wait_time(1.0)

	--★★ロンギヌス★★:………あれは──…
	change_face(Actor003, "Surprise")
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0420015")

close_speech_window()
PlayPartVoiceDirect("ギネヴィア","swim_0010")

	--★★ギネヴィア影★★:格好イイでしょ？
	open_speech_window("CHRNAME_NAMELES", Actor007, nil)
	message("EA_010_0420017")

close_speech_window()
PlayPartVoiceDirect("ランスロット","0007")

	--★★ランスロット影★★:継承者の劔だ
	open_speech_window("CHRNAME_NAMELES", Actor008, nil)
	message("EA_010_0420019")

close_speech_window()
close_textbox_base()

show_image("101010150", 0.0, 0.0, 1.0,false,false)
set_scale_image(20,20)
wait_time(IMAGE_TIME_OUT_OUT)
wait_time(0.5)

	open_select_window_tag(Actor001,"Anger","EA_010_0420025")

	if is_select(1) then
		goto Block2_1
	end

::Block2_1::

wait_time(0.5)
fadeout(255,255,255,1.0, 0)
show_image("201010153",0.0,0.0,0.0,true,true)
set_scale_image(0.8,0.8)
fadein(2.0)
wait_time(2.0)

	--★★ギネヴィア影★★:
	open_simple_window("CHRNAME_NAMELES")
	message("EA_010_0420028")

	goto Block2end

::Block2end::

	--★★ランスロット影★★:湖に映すは<br>玲瓏たる足跡
	if is_select(1) then
		close_speech_window()
		open_simple_window("CHRNAME_NAMELES")
	end
	message("EA_010_0420030")

	close_speech_window()

	--★★ギネヴィア★★:ギネヴィア・<ruby=ファクタライズ>因枢分解</ruby>──
	open_simple_window("CHRNAME_GUINEVERE2")
	message("EA_010_0420031")

	close_speech_window()

	--★★ランスロット★★:ランスロット・<ruby=ファクタライズ>因枢分解</ruby>──
	open_simple_window("CHRNAME_LANCELOT2")
	message("EA_010_0420033")

	close_speech_window()

	--★★ギネヴィア／ランスロット★★:アロンダイト
	open_simple_window("CHRNAME_GUINEVERE_LANCELOT")
	message("EA_010_0420035")

	close_speech_window()

	--★★レーヴァテイン★★:…アロン、ダイト
	open_simple_window("CHRNAME_LAEVATEIN")
	message("EA_010_0420037")

	close_speech_window()

	--★★ギネヴィア★★:ただいま。世界
	open_simple_window("CHRNAME_GUINEVERE2")
	message("EA_010_0420038")

	close_speech_window()

	--★★ランスロット★★:あなたの劔に新たな<ruby=めい>命</ruby>を<br>マスター・<%player>
	open_simple_window("CHRNAME_LANCELOT2")
	message("EA_010_0420039")

close_speech_window()
PlayPartVoiceDirect("ギネヴィア","0012")

	--★★ギネヴィア★★:どんとこい。マスター！
	open_simple_window("CHRNAME_GUINEVERE2")
	message("EA_010_0420041")

bgm_play("Stop_BGM_Bus_MidFade")

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
	character2DFull_Preload(Actor003, "Actor003", 101035002)
	character2DFull_Preload(Actor007, "Actor007", 101011008)
	character2DFull_Preload(Actor008, "Actor008", 101010008)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_image_preload("201010153", "content_still_20101015_image", "201010153_StillImage")
	load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
end
