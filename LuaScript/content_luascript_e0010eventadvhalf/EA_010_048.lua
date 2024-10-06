-- このluaスクリプトは、EA_010_048から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201060000", "201060000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101059001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101002001)
	DotActor002 = dot_reserve_ally(101002001, 26, 24, 0)
	dot_set_weapon(DotActor002, 101030001)

	Actor003 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor003, "Actor003", playerId)
	DotActor003 = dot_reserve_ally(playerId, 22, 28, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101035002)
	DotActor004 = dot_reserve_ally(101035002, 22, 27, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101012008)
	DotActor005 = dot_reserve_ally(101012008, 28, 24, 0)
	dot_set_weapon(DotActor005, 101010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201001001, 27, 23, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201001001, 27, 25, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201002001, 28, 26, 0)
	dot_set_weapon(DotActor008, 102010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201006001, 29, 25, 0)
	dot_set_weapon(DotActor009, 106010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201006001, 29, 24, 0)
	dot_set_weapon(DotActor010, 106010001)

	setup_complete_unit()

	dot_unit_dir(DotActor005, 2)
	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)
	dot_unit_dir(DotActor008, 2)
	dot_unit_dir(DotActor009, 2)
	dot_unit_dir(DotActor010, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(40.0, 0.0)
move_camera(27, 24, 0.0)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_change_anim(DotActor002,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor006,6)
dot_change_anim(DotActor002,0)
dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)
dot_change_anim(DotActor002,3)
dot_change_anim(DotActor006,0)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor007,6)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)

	--★★アルハン★★:『イミテーション』──…
	open_speech_window("NPCNAME_0313", Actor001, nil)
	message("EA_010_0480006")

close_speech_window()

dot_change_anim(DotActor002,0)
dot_change_anim(DotActor007,0)
dot_change_anim(DotActor006,3)
wait_time(0.1)
dot_play_particle_unit(DotActor006,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor006,0)
dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)
dot_change_anim(DotActor002,0)
dot_change_anim(DotActor007,3)
wait_time(0.1)
dot_play_particle_unit(DotActor007,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.1)
dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
wait_time(0.2)

	--★★アルハン★★:白き竜と化した<br>騎士の時代における…最後の敵
	open_speech_window("NPCNAME_0313", Actor001, nil)
	message("EA_010_0480007")

	--★★アルハン★★:現代にて『<ruby=オーセンティック>根源の武器</ruby>』を模した<br>最後の継承者が倒すべき…最初の敵
	message("EA_010_0480008")

close_speech_window()

dot_change_anim(DotActor002,0)
dot_change_anim(DotActor007,0)
wait_time(0.2)
dot_change_anim(DotActor002,3)
dot_change_anim(DotActor005,3)
wait_time(0.1)
dot_play_particle_unit(DotActor002,"Ef_C_Swd_N_Atk01",3,true)
dot_play_particle_unit(DotActor005,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)

	--★★アルハン★★:倒せるはずであった<br>本来なら
	open_speech_window("NPCNAME_0313", Actor001, nil)
	message("EA_010_0480010")

close_speech_window()

dot_change_anim(DotActor002,0)
dot_change_anim(DotActor005,0)
wait_time(0.2)
dot_change_anim(DotActor005,3)
wait_time(0.1)
dot_play_particle_unit(DotActor005,"Ef_C_Swd_N_EmyAtk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor005,0)
dot_change_anim(DotActor002,6)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_EmySla01",1,true)
dot_move_knockback(DotActor002,25,24,0.2,2)
wait_time(0.2)
dot_change_anim(DotActor002,1)

	--★★アルハン★★:だが、ディナタンが選ばれた世界線は<br>聖域化されずに滅びたがゆえ──
	change_face(Actor001, "Sad")
	open_speech_window("NPCNAME_0313", Actor001, nil)
	message("EA_010_0480012")

	--★★アルハン★★:
	message("EA_010_0480013")

close_speech_window()

dot_reserve_move_unit_seq(DotActor006,26,23)
dot_reserve_move_unit_seq(DotActor007,26,25)
dot_reserve_move_unit_seq(DotActor008,27,24)
exec_parallel_seq()
wait_seq()
dot_unit_dir(DotActor008,2)

	--★★アルハン★★:武器が足らぬ<br>このままでは──
	change_face(Actor001, "Normal")
	open_speech_window("NPCNAME_0313", Actor001, nil)
	message("EA_010_0480015")

close_speech_window()

dot_change_anim(DotActor005,4)
wait_time(0.2)
se_play("SE_ADV_Emy001_Cry")
on_active(Roar) 
local gridpos = get_grid_position(28,24)
set_pos(Roar, gridpos)
play_particle(Roar)
wait_time(1.0)

dot_change_anim(DotActor006,3)
dot_change_anim(DotActor007,3)
dot_change_anim(DotActor008,3)
dot_change_anim(DotActor009,3)
dot_change_anim(DotActor010,3)
wait_time(0.1)
dot_play_particle_unit(DotActor006,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor007,"Ef_C_Swd_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor008,"Ef_C_Axe_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor009,"Ef_C_Gun_N_EmyAtk01",3,true)
dot_play_particle_unit(DotActor010,"Ef_C_Gun_N_EmyAtk01",3,true)
wait_time(0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)

PlayPartVoiceDirect("アルハン","0023")

	--★★アルハン★★:終わりか
	change_face(Actor001, "Sad")
	open_speech_window("NPCNAME_0313", Actor001, nil)
	message("EA_010_0480019")

	close_speech_window()

	--★★レーヴァテイン★★:………
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0480020")

PlayPartVoiceDirect("レーヴァテイン","0002")

	--★★レーヴァテイン★★:ねえ、<%player>
	message("EA_010_0480021")

	--★★レーヴァテイン★★:私、言ったよね
	message("EA_010_0480022")

	--★★レーヴァテイン★★:「私といても見れるのは<br>世界の終わりくらいだよ」って
	message("EA_010_0480023")

PlayPartVoiceDirect("レーヴァテイン","0050")

	--★★レーヴァテイン★★:…でも
	message("EA_010_0480024")

PlayPartVoiceDirect("レーヴァテイン","0041")

	--★★レーヴァテイン★★:それは今日じゃない
	change_face(Actor002, "Anger")
	message("EA_010_0480025")

reserve_next_script("シナリオイベクエ/e0010/3話_ADV_11")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101059001)
	character2DFull_Preload(Actor002, "Actor002", 101002001)
	character2DFull_Preload(Actor003, "Actor003", get_player_styleId())
	character2DFull_Preload(Actor004, "Actor004", 101035002)
	character2DFull_Preload(Actor005, "Actor005", 101012008)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
end
