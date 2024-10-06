-- このluaスクリプトは、MS_002_062から自動生成されました --
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
	character2DFull(Actor002, "Actor002", 101059001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101009001)
	DotActor003 = dot_reserve_ally(101009001, 16, 40, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	character2DFull(Actor004, "Actor004", 101068001)
	DotActor004 = dot_reserve_ally(101068001, 15, 40, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	character2DFull(Actor005, "Actor005", 101012001)
	DotActor005 = dot_reserve_ally(101012001, 20, 7, 0)
	dot_set_weapon(DotActor005, 108010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(401036001, 18, 35, 0)
	dot_set_weapon(DotActor006, 101010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(401036001, 19, 35, 0)
	dot_set_weapon(DotActor007, 101010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(401036001, 20, 35, 0)
	dot_set_weapon(DotActor008, 101010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(401036001, 21, 35, 0)
	dot_set_weapon(DotActor009, 101010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(401035001, 20, 25, 0)
	dot_set_weapon(DotActor010, 101010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201001001, 18, 37, 0)
	dot_set_weapon(DotActor011, 101010001)

	Actor012 = set_chara_unknown()
	DotActor012 = dot_reserve_ally(201001001, 19, 36, 0)
	dot_set_weapon(DotActor012, 101010001)

	Actor013 = set_chara_unknown()
	DotActor013 = dot_reserve_ally(201001001, 20, 36, 0)
	dot_set_weapon(DotActor013, 101010001)

	Actor014 = set_chara_unknown()
	DotActor014 = dot_reserve_ally(201001001, 21, 37, 0)
	dot_set_weapon(DotActor014, 101010001)

	Actor015 = set_chara_unknown()
	DotActor015 = dot_reserve_ally(201001001, 25, 40, 0)
	dot_set_weapon(DotActor015, 101010001)

	Actor016 = set_chara_unknown()
	DotActor016 = dot_reserve_ally(201001001, 24, 40, 0)
	dot_set_weapon(DotActor016, 101010001)

	Actor017 = set_chara_unknown()
	DotActor017 = dot_reserve_ally(201001001, 23, 41, 0)
	dot_set_weapon(DotActor017, 101010001)

	Actor018 = set_chara_unknown()
	DotActor018 = dot_reserve_ally(201026001, 19, 15, 0)
	dot_set_weapon(DotActor018, 102020001)

	setup_complete_unit()

	dot_unit_dir(DotActor011, 2)
	dot_unit_dir(DotActor012, 2)
	dot_unit_dir(DotActor013, 2)
	dot_unit_dir(DotActor014, 2)
	dot_unit_dir(DotActor015, 2)
	dot_unit_dir(DotActor016, 2)
	dot_unit_dir(DotActor017, 2)
	dot_unit_dir(DotActor018, 2)

	dot_disp_weapon(DotActor004, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(45.0, 0.0)
move_camera(20, 36, 0.0)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("101010170", "content_still_10101017_image", "101010170_StillImage")
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_fh1 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
Ef_Roar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
dot_disp_weapon(DotActor003,false)
dot_disp_weapon(DotActor004,false)
dot_disp_weapon(DotActor005,false)
dot_disp_unit(DotActor003,false)
dot_disp_unit(DotActor004,false)
dot_disp_unit(DotActor005,false)
dot_disp_unit(DotActor018,false)
dot_disp_unit(DotActor015,false)
dot_disp_unit(DotActor016,false)
dot_disp_unit(DotActor017,false)
load_sound("BGM_ADV_Painful2")
load_sound("BGM_Battle_Running")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_attack_seq(DotActor008,DotActor013)
dot_damage_seq(DotActor013,DotActor008,false)
dot_attack_seq(DotActor007,DotActor012)
dot_damage_seq(DotActor012,DotActor007,false)
wait_seq()

dot_attack_seq(DotActor013,DotActor008)
dot_damage_seq(DotActor008,DotActor013,false)
wait_seq()

dot_change_anim(DotActor008,6)

dot_attack_seq(DotActor012,DotActor007)
dot_damage_seq(DotActor007,DotActor012,false)
wait_seq()

dot_play_particle_unit(DotActor006,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_N_Hit_Sla01",1,true)

dot_change_anim(DotActor012,0)
dot_change_anim(DotActor013,0)
dot_unit_dir(DotActor012,2)
dot_unit_dir(DotActor013,2)

dot_change_anim(DotActor006,1)
dot_change_anim(DotActor007,1)
dot_change_anim(DotActor008,1)
dot_change_anim(DotActor009,1)

wait_time(0.4)

dot_move_knockback(DotActor006, 18, 34,0.1,2)
dot_move_knockback(DotActor007, 19, 34,0.1,2)
dot_move_knockback(DotActor008, 20, 34,0.1,2)
dot_move_knockback(DotActor009, 21, 34,0.1,2)
wait_time(0.5)

dot_play_particle_unit(DotActor006,"Ef_C_Cmn_Die01",2,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_Die01",2,true)
dot_play_particle_unit(DotActor008,"Ef_C_Cmn_Die01",2,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_Die01",2,true)
wait_time(0.5)

dot_remove_unit(DotActor007)
dot_remove_unit(DotActor008)
dot_remove_unit(DotActor009)

dot_place_unit(DotActor006,19,26)
dot_change_anim(DotActor006,0)

move_camera(20,27,2.0)
wait_time(1.0)

dot_reserve_move_unit_seq(DotActor011, 18, 28)
dot_reserve_move_unit_seq(DotActor012, 19, 27)
dot_reserve_move_unit_seq(DotActor013, 19, 28)
dot_reserve_move_unit_seq(DotActor014, 21, 28)
exec_parallel_seq()
wait_seq()
dot_unit_dir(DotActor012,2)

dot_reserve_move_unit_seq(DotActor011, 18, 26)
dot_reserve_move_unit_seq(DotActor013, 20, 27)
dot_reserve_move_unit_seq(DotActor014, 21, 26)
exec_parallel_seq()
wait_seq()

dot_reserve_move_unit_seq(DotActor013, 20, 26)
dot_reserve_move_unit_seq(DotActor014, 21, 25)
exec_parallel_seq()
wait_seq()

dot_unit_dir(DotActor013,2)
dot_unit_dir(DotActor014,2)
wait_camera()
wait_time(0.5)

	--★★アルハン★★:──やはり、ここか
	change_face(Actor002, "Sad")
	open_speech_window("NPCNAME_0313", Actor002, nil)
	message("MS_002_0620005")

	open_select_window_tag(Actor001,"Normal","MS_002_0620007")
	close_speech_window()

	if is_select(1) then
		goto Block1_1
	end

::Block1_1::

dot_disp_unit(DotActor003,true)
dot_disp_unit(DotActor004,true)
dot_reserve_move_unit_seq(DotActor003,20,40)
dot_reserve_move_unit_seq(DotActor004,19,40)
exec_parallel_seq()
wait_seq()

move_camera(20,35,2.0)

dot_reserve_move_unit_seq(DotActor003,20,34)
dot_reserve_move_unit_seq(DotActor004,19,34)
exec_parallel_seq()
wait_seq()

wait_camera()

dot_remove_unit(DotActor006)
dot_remove_unit(DotActor010)
wait_time(0.5)

	goto Block1end

::Block1end::

PlayPartVoiceDirect("アルハン","0034")

	--★★アルハン★★:…ティルフィングがわずかに間に合わず<br>手が届かなかった存在…
	change_face(Actor002, "Normal")
	open_speech_window("NPCNAME_0313", Actor002, nil)
	message("MS_002_0620012")

close_speech_window()

dot_disp_unit(DotActor015,true)
dot_disp_unit(DotActor016,true)
dot_disp_unit(DotActor017,true)

dot_place_unit(DotActor015,19,38)
dot_place_unit(DotActor016,20,38)
dot_place_unit(DotActor017,21,38)

dot_reserve_move_unit_seq(DotActor015,19,36)
dot_reserve_move_unit_seq(DotActor016,20,36)
dot_reserve_move_unit_seq(DotActor017,21,36)
exec_parallel_seq()
wait_seq()

dot_unit_dir(DotActor015,2)
dot_unit_dir(DotActor016,2)
dot_unit_dir(DotActor017,2)
wait_time(0.5)

	--★★アルハン★★:他にも救い切れなかった人間は多くいるが<br>それはもはや手遅れの者がほとんどであった
	open_speech_window("NPCNAME_0313", Actor002, nil)
	message("MS_002_0620014")

close_speech_window()

move_camera(20, 15, 2.0)
wait_camera()

on_active(Ef_bar1)
local gridpos = get_grid_position(20, 16)
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
move_camera(20,16,0.0)
dot_disp_unit(DotActor018,true)

wait_time(1.0)

	--★★アルハン★★:だがこの運命ならば…<br>今のキサマの力であれば──
	open_speech_window("NPCNAME_0313", Actor002, nil)
	message("MS_002_0620016")

close_speech_window()

dot_disp_weapon(DotActor003,true)
dot_reserve_move_unit_seq(DotActor003, 26, 22)
dot_reserve_move_unit_seq(DotActor004,18,32)
exec_parallel_seq()

wait_time(0.5)
move_camera(25,23,2.0)
wait_seq()
dot_unit_dir(DotActor003,2)
wait_camera()

PlayPartVoiceDirect("ノワール","0035")

	--★★ノワール★★:こっちだ！俺を狙え！！
	change_face(Actor003, "Anger")
	open_speech_window("CHRNAME_NOIR", Actor003, nil)
	message("MS_002_0620018")

close_speech_window()

dot_reserve_move_unit_seq(DotActor011,24,21)
dot_reserve_move_unit_seq(DotActor012,25,22)
dot_reserve_move_unit_seq(DotActor013,25,23)
dot_reserve_move_unit_seq(DotActor014,24,24)
dot_reserve_move_unit_seq(DotActor015,23,22)
dot_reserve_move_unit_seq(DotActor016,23,23)
dot_reserve_move_unit_seq(DotActor017,23,24)
exec_parallel_seq()
wait_seq()

	--★★ノワール★★:今戦えるのは俺たちしかいない<br>そうじゃなくても見過ごせない…！
	open_speech_window("CHRNAME_NOIR", Actor003, nil)
	message("MS_002_0620020")

close_speech_window()

dot_attack_seq(DotActor012,DotActor003)
dot_dodge_seq(DotActor003)
wait_seq()

dot_attack_seq(DotActor003,DotActor012)
dot_damage_seq(DotActor012,DotActor003,false)
wait_seq()

dot_change_anim(DotActor012,6)
dot_change_anim(DotActor003,0)

wait_time(0.2)


dot_play_particle_unit(DotActor012,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)
dot_remove_unit(DotActor012)
wait_time(0.5)

dot_reserve_move_unit_seq(DotActor015,25,22)
dot_reserve_move_unit_seq(DotActor018,20,21)
exec_parallel_seq()
wait_seq()
wait_time(0.5)

PlayPartVoiceDirect("ウレリー","0009")

	--★★ウレリー★★:キリがない…！だめだよ！<br>ノワールくんが喰われる、逃げなきゃ──
	change_face(Actor004, "Surprise")
	open_speech_window("CHRNAME_URRIE", Actor004, nil)
	message("MS_002_0620022")

close_speech_window()

dot_disp_unit(DotActor005,true)

move_camera(20,18,2.0)
dot_move_unit_seq(DotActor005,20,14)
wait_seq()
wait_camera()
wait_time(0.5)

	--★★ディナタン★★:兄さん！？！？
	change_face(Actor005, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Actor005, nil)
	message("MS_002_0620025")

close_speech_window()
PlayPartVoiceDirect("ノワール","0030")

	--★★ノワール★★:ディナタン！？<br>だめだ、来るなッ！！
	change_face(Actor003, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor003, nil)
	message("MS_002_0620026")

close_speech_window()

dot_move_unit_seq(DotActor018,19,17)
wait_seq()
wait_time(0.5)

PlayPartVoiceDirect("ディナタン_006","0030")

	--★★ディナタン★★:え………っ
	open_speech_window("CHRNAME_DINATAN", Actor005, nil)
	message("MS_002_0620028")

close_speech_window()

move_camera(22,19,1.0)
dot_reserve_move_unit_seq(DotActor003,23,20)
dot_reserve_move_unit_seq(DotActor011,23,19)
dot_reserve_move_unit_seq(DotActor013,22,20)
dot_reserve_move_unit_seq(DotActor014,24,19)
exec_parallel_seq()
wait_seq()

dot_unit_dir(DotActor013,3)
dot_unit_dir(DotActor014,2)

wait_camera()
wait_time(0.5)

voice_play("VO_101009_sp_0003_2")

	--★★ノワール★★:ディナタン！！！！
	change_face(Actor003, "Anger")
	open_speech_window("CHRNAME_NOIR", Actor003, nil)
	message("MS_002_0620030")

close_speech_window()

move_camera(18,32,2.0)
wait_camera()

	--★★ウレリー★★:にげなきゃ、にげなきゃ
	change_face(Actor004, "Sad")
	open_speech_window("CHRNAME_URRIE", Actor004, nil)
	message("MS_002_0620031")

close_speech_window()

move_camera(22,18,1.0)
wait_camera()

dot_move_unit_seq(DotActor018,19,16)
wait_seq()
dot_unit_dir(DotActor018,2)

on_active(Ef_Roar1)
local gridpos = get_grid_position(19, 16)
set_pos(Ef_Roar1, gridpos)
play_particle(Ef_Roar1)

dot_change_anim(DotActor018,3)

	--★★巨大バルバロイ★★:アアアアアアアアアアアアアアッッ！！
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("MS_002_0620032")

dot_change_anim(DotActor018,0)

	close_speech_window()

	--★★ウレリー★★:にげなきゃ
	open_speech_window("CHRNAME_URRIE", Actor004, nil)
	message("MS_002_0620033")

close_speech_window()

dot_place_unit(DotActor004,17,25)

move_camera(20,15,2.0)
dot_move_unit_seq(DotActor004,19,14)
wait_seq()
wait_camera()

dot_change_anim(DotActor004,3)

wait_time(0.2)
dot_change_anim(DotActor005,6)
dot_move_knockback(DotActor005,22,14,0.1,2)
wait_time(0.5)
dot_change_anim(DotActor005,1)

	--★★ディナタン★★:ウレリーさん！？
	open_speech_window("CHRNAME_DINATAN", Actor005, nil)
	message("MS_002_0620035")

close_speech_window()

dot_move_unit_seq(DotActor004,20,14)
wait_seq()

	open_cutin(1,1)
	on_cutin(1,Actor004,"Anger")

	--★★ウレリー★★:こっちだッッ！！！！
	open_speech_window("CHRNAME_URRIE", nil, nil)
	message("MS_002_0620036")

close_speech_window()
bgm_play("Stop_BGM_Bus_MidFade")

	close_cutin()

dot_move_unit_seq(DotActor018,19,15)
wait_seq()
dot_unit_dir(DotActor018,2)

fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(2.0)

show_image("101010170", 0.0, 0.0, 0.0,true,false)
fadein(1.5)
wait_time(2.0)
bgm_play("BGM_ADV_Painful2")

PlayPartVoiceDirect("ウレリー","0100")

	--★★ウレリー★★:にげて
	open_simple_window("CHRNAME_URRIE")
	message("MS_002_0620040")

close_simple_window()
PlayPartVoiceDirect("ディナタン_006","0044")

	--★★ディナタン★★:ウレリーさん！！！！
	open_simple_window("CHRNAME_DINATAN")
	message("MS_002_0620041")

	close_simple_window()

	--★★ウレリー★★:おにいさんが、かなしむよ
	open_simple_window("CHRNAME_URRIE")
	message("MS_002_0620042")

close_simple_window()
PlayPartVoiceDirect("ノワール","0030")

	--★★ノワール★★:ウレリー！？
	open_simple_window("CHRNAME_NOIR")
	message("MS_002_0620043")

	close_simple_window()

	--★★ウレリー★★:こわくないよ、ワタシこわくないから
	open_simple_window("CHRNAME_URRIE")
	message("MS_002_0620044")

	close_simple_window()

	--★★ノワール★★:やめろ、やめろおおおっっ！！
	open_simple_window("CHRNAME_NOIR")
	message("MS_002_0620045")

close_simple_window()
PlayPartVoiceDirect("ウレリー","0108")

	--★★ウレリー★★:………わすれないで
	open_simple_window("CHRNAME_URRIE")
	message("MS_002_0620046")

	--★★ウレリー★★:むりなの、わかってる<br>だけど約束、だから、おねがい、おねがい
	message("MS_002_0620047")

bgm_play("Stop_BGM_Bus_LongFade")

	--★★ウレリー★★:わすれないで、わすれないで、やだぁっ<br>あああっ、わすれないで、わすれないで、わすれ
	message("MS_002_0620048")

close_simple_window()

fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(2.0)

show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,true)
set_scale_image(20,20)
fadein(1.0)
wait_time(1.0)

	open_select_window_tag(Actor001,"Anger","MS_002_0620053")

	if is_select(1) then
		goto Block2_1
	end

::Block2_1::

dot_play_particle_unit(DotActor003,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.1)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Critical01",1,true)
wait_time(0.2)

	goto Block2end

::Block2end::

dot_play_particle_unit(DotActor003,"Ef_C_Ham_N_Atk01",3,true)
wait_time(0.1)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Str01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor003,"Ef_C_Wit_N_Atk01",3,true)
wait_time(0.1)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Exp01",1,true)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_I_HitSub01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor003,"Ef_C_Ect_Swd01_F",3,true)
wait_time(0.1)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_F_HitSub01",1,true)
dot_play_particle_unit(DotActor018,"Ef_C_Cmn_N_Hit_Critical01",1,true)
wait_time(0.2)

wait_time(2.0)
bgm_play("BGM_Battle_Running")

	--★★ウレリー★★:…──えっ？
	open_simple_window("CHRNAME_URRIE")
	message("MS_002_0620059")

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", playerId)
	character2DFull_Preload(Actor002, "Actor002", 101059001)
	character2DFull_Preload(Actor003, "Actor003", 101009001)
	character2DFull_Preload(Actor004, "Actor004", 101068001)
	character2DFull_Preload(Actor005, "Actor005", 101012001)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010170", "content_still_10101017_image", "101010170_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
preload_sound("BGM_ADV_Painful2")
preload_sound("BGM_Battle_Running")
end
