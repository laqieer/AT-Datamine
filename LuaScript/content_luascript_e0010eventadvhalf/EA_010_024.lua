-- このluaスクリプトは、EA_010_024から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201220000", "201220000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	local playerId = get_player_styleId()
	character2DFull(Actor001, "Actor001", playerId)
	DotActor001 = dot_reserve_ally(playerId, 12, 13, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101002001)
	DotActor002 = dot_reserve_ally(101002001, 11, 13, 0)
	dot_set_weapon(DotActor002, 101030001)

	Actor003 = set_chara_unknown()
	character2DFull(Actor003, "Actor003", 101035002)
	DotActor003 = dot_reserve_ally(101035002, 12, 15, 0)
	dot_set_weapon(DotActor003, 104010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201001001, 17, 15, 0)
	dot_set_weapon(DotActor004, 101010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201026021, 16, 11, 0)
	dot_set_weapon(DotActor005, 102020001)

	setup_complete_unit()

	dot_unit_dir(DotActor001, 2)
	dot_unit_dir(DotActor003, 2)
	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor005, 2)


	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(45.0, 0.0)
move_camera(12, 14, 0.0)
dot_disp_unit(DotActor004,false)
dot_disp_unit(DotActor005,false)
Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_fh = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("201010152", "content_still_20101015_image", "201010152_StillImage")
dot_disp_weapon(DotActor001,false)
dot_disp_weapon(DotActor002,false)
dot_disp_weapon(DotActor003,false)
load_sound("BGM_ADV_Invasion2")
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

PlayPartVoiceDirect("レーヴァテイン","0056")

	--★★レーヴァテイン★★:なんで
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240005")

	--★★レーヴァテイン★★:戦うのよ
	message("EA_010_0240006")

	open_select_window_tag(Actor001,"Normal","EA_010_0240008","EA_010_0240009")
	close_speech_window()

	if is_select(1) then
		goto Block1_1
	else
		goto Block1_2
	end

::Block1_1::

PlayPartVoiceDirect("レーヴァテイン","0033")

	--★★レーヴァテイン★★:戦ってたよ
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240012")

close_speech_window()
PlayPartVoiceDirect("リリアーナ","0014")

	--★★ロンギヌス★★:まあまあ
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240013")

	close_speech_window()

	--★★レーヴァテイン★★:ばしばしばしばし倒してた
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240014")

	close_speech_window()

	--★★ロンギヌス★★:まあまあまあまあ
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240015")

	goto Block1end

::Block1_2::

PlayPartVoiceDirect("レーヴァテイン","0058")

	--★★レーヴァテイン★★:わ、悪びれもせず…っ
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240018")

close_speech_window()
PlayPartVoiceDirect("リリアーナ","0034")

	--★★ロンギヌス★★:な、何事も全力で挑むことは<br>いいこと、です、から…！
	change_face(Actor003, "Normal")
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240019")

	close_speech_window()

	--★★レーヴァテイン★★:そういう話じゃない！
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240020")

	close_speech_window()

	--★★ロンギヌス★★:じょ、助力してくださったことを<br>悪く言うわけにはいきませんよ
	change_face(Actor003, "Sad")
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240021")

	goto Block1end

::Block1end::

close_speech_window()
PlayPartVoiceDirect("レーヴァテイン","0015")

	--★★レーヴァテイン★★:ロンギヌスはどっちの味方なの
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240023")

	close_speech_window()

	--★★ロンギヌス★★:じ、人類の味方です
	change_face(Actor003, "Sad")
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240024")

	close_speech_window()

	--★★レーヴァテイン★★:広い！！
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240025")

	close_speech_window()

	--★★ロンギヌス★★:…最後の継承者の力が発現したことに<br>共鳴するようにバルバロイも数を増しています
	change_face(Actor003, "Normal")
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240026")

	--★★ロンギヌス★★:<%player>さんの力が<br>我々には、必要です…
	change_face(Actor003, "Sad")
	message("EA_010_0240027")

	close_speech_window()

	--★★レーヴァテイン★★:世界には救世主が必要だとして<br>救世主のことは誰が救ってあげられるの
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240028")

	close_speech_window()

	--★★ロンギヌス★★:そ、それは…
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240029")

close_speech_window()
PlayPartVoiceDirect("レーヴァテイン","0002")

	--★★レーヴァテイン★★:あなたも変だよ<br><%player>
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240030")

	--★★レーヴァテイン★★:覚えていないんでしょ？ 
	message("EA_010_0240031")

	--★★レーヴァテイン★★:過去に潜る前の世界<br>あなたが守ろうとしていた世界
	message("EA_010_0240032")

	--★★レーヴァテイン★★:潜る前にいた、あなたの<br><dot>はじめての友達</dot>のこととか…
	change_face(Actor002, "Sad")
	message("EA_010_0240033")

	close_speech_window()

	--★★ロンギヌス★★:ど、どうしようもないことです<br>こればかりは………
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240036")

	close_speech_window()

	--★★レーヴァテイン★★:………
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240037")

	open_select_window_tag(Actor001,"Normal","EA_010_0240039")
	close_speech_window()

	if is_select(1) then
		goto Block2_1
	end

::Block2_1::

	--★★レーヴァテイン★★:…！！
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240042")

	goto Block2end

::Block2end::

PlayPartVoiceDirect("レーヴァテイン","0059")

	--★★レーヴァテイン★★:そ、それは──…っ
	change_face(Actor002, "Sad")
	message("EA_010_0240043")

close_speech_window()
move_camera(14, 14, 1.0)
change_camera_distance(10.0, 1.0)
change_camera_angle(34.0, 0.4)
wait_time(0.4)

on_active(Ef_bar1) 
on_active(Ef_bar2)

local gridpos1 = get_grid_position(17, 15) --出現するバルバロイの座標を入力
local gridpos2 = get_grid_position(17, 12) --出現するバルバロイの座標を入力
set_pos(Ef_bar1, gridpos1)
set_pos(Ef_bar2, gridpos2)
set_scale(Ef_bar1, {0.8, 0.8, 0.8}) --エフェクトの大きさを指定。（0.8固定）
set_scale(Ef_bar2, {1.2, 1.2, 1.2}) --エフェクトの大きさを指定。（0.8固定）
play_particle(Ef_bar1)
play_particle(Ef_bar2)

wait_time(0.2)

dot_disp_unit(DotActor004, true) --出現するバルバロイのIDを入力

wait_time(0.8)

on_active(Ef_fh)
gridpos2[2]=1.0
set_pos(Ef_fh,gridpos2)
set_scale(Ef_fh, {1.2, 1.2, 1.2})
play_particle(Ef_fh)

wait_time(0.2)

dot_disp_unit(DotActor005, true) --出現するバルバロイのIDを入力

wait_camera()
wait_time(1.0)

dot_unit_dir(DotActor001,3)
dot_unit_dir(DotActor003,3)

bgm_play("Stop_BGM_Bus_2")

	--★★ロンギヌス★★:！？
	change_face(Actor003, "Surprise")
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240045")

close_speech_window()
dot_move_unit_seq(DotActor004,13,15)
wait_seq()
dot_disp_weapon(DotActor003,true)

dot_change_anim(DotActor004,3)
wait_time(0.1)
dot_play_particle_unit(DotActor004,"Ef_C_Swd_N_EmyAtk01",3,true)

wait_time(0.1)

dot_change_anim(DotActor003,6)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_N_Hit_EmySla01",1,true)

wait_time(0.5)
dot_change_anim(DotActor004,0)
dot_change_anim(DotActor003,0)

bgm_play("BGM_ADV_Invasion2")

	--★★レーヴァテイン★★:ロンギヌス！？
	change_face(Actor002, "Surprise")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240047")

close_speech_window()
PlayPartVoiceDirect("リリアーナ","0043")

	--★★ロンギヌス★★:だ、だいじょうぶですっ…！！<br>それより<%player>さんを──
	change_face(Actor003, "Sad")
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240048")

close_speech_window()
dot_move_unit_seq(DotActor005,13,11)
wait_seq()

	--★★レーヴァテイン★★:<%player>！！！！
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240050")

close_speech_window()
dot_change_anim(DotActor005,3)
fadeout(255,255,255,1.0,0.2)
wait_time(0.2)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
dot_place_unit(DotActor001,11,13)
dot_place_unit(DotActor002,12,13)
wait_time(0.2)
dot_play_particle_unit(DotActor002,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(1.0)
fadein(1.0)
wait_time(1.0)

PlayPartVoiceDirect("レーヴァテイン","0043")

	--★★レーヴァテイン★★:アッ、ぐっ、あぁああっっ…！？
	change_face(Actor002, "Pain")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240054")

	close_speech_window()

	--★★ロンギヌス★★:レーヴァテイン！？！？
	change_face(Actor003, "Surprise")
	open_speech_window("CHRNAME_LONGINUS", Actor003, nil)
	message("EA_010_0240055")

	close_speech_window()

	--★★バルバロイ★★:アアアアアアアアッ…！！
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("EA_010_0240056")

	close_speech_window()

	--★★レーヴァテイン★★:………クチ、閉じてよ
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_LAEVATEIN", Actor002, nil)
	message("EA_010_0240057")

	--★★レーヴァテイン★★:あくびしてんの？
	message("EA_010_0240058")

close_speech_window()
wait_time(0.5)
dot_play_particle_unit(DotActor005,"Ef_C_Cmn_N_Hit_Sla01",1,true)
fadeout(255,255,255,1.0,0.2)
fadein(0.2)
wait_time(0.2)

fadeout(0,0,0,1.0, 0)
wait_time(0,4)
show_image("201010152", 0.0, 0.0,0,true,true)
set_scale_image(0.8,0.8)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	--★★レーヴァテイン★★:………言ったでしょ
	open_simple_window("CHRNAME_LAEVATEIN")
	message("EA_010_0240062")

	--★★レーヴァテイン★★:あなたは<br>傷つけさせない
	message("EA_010_0240063")

close_speech_window()
PlayPartVoiceDirect("リリアーナ","0023")

	--★★ロンギヌス★★:れ、レーヴァテイン、あなたはまだ<br>昨日の傷も治っていないのに…！！
	open_simple_window("CHRNAME_LONGINUS")
	message("EA_010_0240064")

	close_speech_window()

	--★★レーヴァテイン★★:私の傷なんて、どうでもいい
	open_simple_window("CHRNAME_LAEVATEIN")
	message("EA_010_0240065")

	--★★レーヴァテイン★★:誰かが傷つくぐらいなら<br>こんなの実質無傷だし
	message("EA_010_0240066")

	close_speech_window()

	--★★ロンギヌス★★:実質無傷の意味がわかりませんが！！
	open_simple_window("CHRNAME_LONGINUS")
	message("EA_010_0240067")

	close_speech_window()

	--★★レーヴァテイン★★:…こんなことになってなかったら<br>普通の学園生活を送れたひと、たくさんいた
	open_simple_window("CHRNAME_LAEVATEIN")
	message("EA_010_0240068")

	--★★レーヴァテイン★★:<%player>も<br>そうだったはずだ
	message("EA_010_0240069")

	--★★レーヴァテイン★★:なのに、なんでこっちが怖がって<br>ビクビクしてなきゃいけないの
	message("EA_010_0240070")

	--★★レーヴァテイン★★:それが、ムカつく
	message("EA_010_0240071")

	--★★レーヴァテイン★★:だから絶対平和にしてやる<br>じゃなきゃ気が済まない
	message("EA_010_0240072")

PlayPartVoiceDirect("レーヴァテイン","0035")

	--★★レーヴァテイン★★:みんな殺して、あくびをしてやる
	message("EA_010_0240073")

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
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010152", "content_still_20101015_image", "201010152_StillImage")
preload_sound("BGM_ADV_Invasion2")
end
