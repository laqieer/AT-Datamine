-- このluaスクリプトは、CO_101066_0502から自動生成されました --
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")
Include("content_luascript_common","DemoCommonPack")


function Load()
	Load_common(true)

	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(1,1)

	Actor001 = set_chara_unknown()
	character2DFull(Actor001, "Actor001", 101009001)
	DotActor001 = dot_reserve_ally(101009001, 6, 31, 0)
	dot_set_weapon(DotActor001, 101010001)

	Actor002 = set_chara_unknown()
	character2DFull(Actor002, "Actor002", 101066001)
	DotActor002 = dot_reserve_ally(101066001, 7, 30, 0)
	dot_set_weapon(DotActor002, 104010001)

	Actor003 = set_chara_unknown()
	DotActor003 = dot_reserve_ally(201001001, 28, 33, 0)
	dot_set_weapon(DotActor003, 101010001)

	Actor004 = set_chara_unknown()
	DotActor004 = dot_reserve_ally(201004001, 31, 30, 0)
	dot_set_weapon(DotActor004, 104010001)

	Actor005 = set_chara_unknown()
	DotActor005 = dot_reserve_ally(201007001, 29, 31, 0)
	dot_set_weapon(DotActor005, 107010001)

	Actor006 = set_chara_unknown()
	DotActor006 = dot_reserve_ally(201007001, 32, 33, 0)
	dot_set_weapon(DotActor006, 107010001)

	Actor007 = set_chara_unknown()
	DotActor007 = dot_reserve_ally(201011001, 30, 32, 0)
	dot_set_weapon(DotActor007, 104010001)

	Actor008 = set_chara_unknown()
	DotActor008 = dot_reserve_ally(201018001, 19, 30, 0)
	dot_set_weapon(DotActor008, 104010001)

	Actor009 = set_chara_unknown()
	DotActor009 = dot_reserve_ally(201018001, 18, 31, 0)
	dot_set_weapon(DotActor009, 104010001)

	Actor010 = set_chara_unknown()
	DotActor010 = dot_reserve_ally(201018001, 19, 33, 0)
	dot_set_weapon(DotActor010, 104010001)

	Actor011 = set_chara_unknown()
	DotActor011 = dot_reserve_ally(201004000, 28, 31, 0)
	dot_set_weapon(DotActor011, 104010001)

	setup_complete_unit()

	dot_unit_dir(DotActor004, 2)
	dot_unit_dir(DotActor006, 2)
	dot_unit_dir(DotActor007, 2)

	dot_disp_weapon(DotActor002, false)
	dot_disp_weapon(DotActor008, false)
	dot_disp_weapon(DotActor009, false)
	dot_disp_weapon(DotActor010, false)
	dot_disp_weapon(DotActor011, false)

	-- ▼スクリプト欄▼ --
change_camera_distance(8.0, 0.0)
change_camera_angle(25.0, 0.0)
move_camera(12,31, 0.0)
dot_disp_weapon(DotActor001,false)
dot_disp_weapon(DotActor002,false)
dot_disp_unit(DotActor008,false)
dot_disp_unit(DotActor009,false)
dot_disp_unit(DotActor010,false)
dot_disp_unit(DotActor011,false)
	-- ▲スクリプト欄▲ --
end


function Play()
	fadein(0)
	Play_start(true)

dot_reserve_move_unit_seq(DotActor002,12,30)
dot_reserve_move_unit_seq(DotActor001,11,31)
exec_parallel_seq()
wait_seq()

	--★★ブレイズ★★:うむ、このあたりでいいじゃろう
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020002")

	close_speech_window()

	--★★ノワール★★:このあたりって…
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020003")

	open_select_window_tag(Actor001,"Normal","CO_101066_05020005","CO_101066_05020006")
	close_speech_window()

	if is_select(1) then
		goto Block1_1
	else
		goto Block1_2
	end

::Block1_1::

	--★★ノワール★★:危険じゃないか？このあたりは盗賊に魔物<br>それにバルバロイもよく確認されてるし…
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020008")

close_speech_window()

dot_unit_dir(DotActor002,2)

PlayPartVoiceDirect("ブレイズ","0010")

	--★★ブレイズ★★:だから来たんじゃろ！おぬしとバルバロイとの<br>戦闘を存分に観測させてもらうぞい！
	change_face(Actor002, "Smile")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020009")

	close_speech_window()

	--★★ノワール★★:まぁ、あんたがそう言うならいいけどさ
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020010")

	goto Block1end

::Block1_2::

	--★★ノワール★★:大丈夫なのか？<br>あんたも戦闘に巻き込まれるかもしれないぞ
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020012")

close_speech_window()

dot_unit_dir(DotActor002,2)

PlayPartVoiceDirect("ブレイズ","0010")

	--★★ブレイズ★★:ふぉっふぉっふぉ！<br>年寄りを思いやれるのは感心じゃのう
	change_face(Actor002, "Smile")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020013")

	--★★ブレイズ★★:だが心配ご無用じゃ！とっとと行くぞ！
	change_face(Actor002, "Normal")
	message("CO_101066_05020014")

	goto Block1end

::Block1end::

	--★★ブレイズ★★:さてさて、どんなバルバロイが出るのかの～♪
	change_face(Actor002, "Smile")
	if is_select(1) then
		close_speech_window()
		open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	end
	message("CO_101066_05020016")

close_speech_window()

dot_move_unit_seq(DotActor002,20,31)
wait_seq()

	--★★ノワール★★:お、おい！ひとりで先に行くなって！
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020018")

close_speech_window()

dot_move_unit_seq(DotActor001,19,32)

fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
move_camera(22,32, 0.0)
wait_camera()
wait_seq()
dot_place_unit(DotActor002,15,31)
dot_place_unit(DotActor001,14,32)
fadein(FADE_TIME)
wait_time(FADE_TIME)

dot_reserve_move_unit_seq(DotActor002,22,31)
dot_reserve_move_unit_seq(DotActor001,21,32)
exec_parallel_seq()
wait_seq()

PlayPartVoiceDirect("ブレイズ","0007")

	--★★ブレイズ★★:ふむ…あいつらがよさそうじゃの
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020020")

dot_reserve_move_unit_seq(DotActor002,25,31)
dot_reserve_move_unit_seq(DotActor001,24,32)
exec_parallel_seq()
move_camera(26,32, 1.0)
wait_camera()
wait_seq()

PlayPartVoiceDirect("ブレイズ","0028")

	--★★ブレイズ★★:むむっ！歩行型に魔法型に…？<br>おおっ、なんと飛ぶやつもおるのか！<br>　
	change_face(Actor002, "Smile")
	message("CO_101066_05020021")

dot_unit_dir(DotActor002,2)

	--★★ブレイズ★★:ほれ、なにをしておるノワール！<br>さっさと戦わんか！
	change_face(Actor002, "Anger")
	message("CO_101066_05020022")

	close_speech_window()

	--★★ノワール★★:わかったよ…
	change_face(Actor001, "Sad")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020023")

close_speech_window()
dot_unit_dir(DotActor002,3)
dot_disp_weapon(DotActor001,true)

dot_move_unit_seq(DotActor001,27,33)
wait_seq()
dot_unit_dir(DotActor003,2)

dot_attack_seq(DotActor001,DotActor003)
dot_damage_seq(DotActor003,DotActor001)
wait_seq()
dot_change_anim(DotActor003,6)

	--★★ブレイズ★★:ふむ…バルバロイが次々にノワールに…<br>なるほど、やはりバルバロイは継承者を――
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020025")

close_speech_window()

dot_attack_seq(DotActor001,DotActor003)
dot_damage_seq(DotActor003,DotActor001)
wait_seq()
dot_change_anim(DotActor003,6)
dot_play_particle_unit(DotActor003,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)

dot_disp_unit(DotActor003, false)
dot_remove_unit(DotActor003)
wait_time(0.5)
dot_change_anim(DotActor001,0)

PlayPartVoiceDirect("ブレイズ","0034")

	--★★ブレイズ★★:すると、やはりあの理論が正しいか…？<br>いや、あるいは――
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020027")

close_speech_window()

dot_reserve_move_unit_seq(DotActor007,29,33)
dot_reserve_move_unit_seq(DotActor001,28,32)
exec_parallel_seq()
wait_seq()
dot_unit_dir(DotActor005,2)

	--★★ブレイズ★★:おお、おお！　<br>なんと興味深いんじゃ～！
	change_face(Actor002, "Smile")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020028")

close_speech_window()

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor005,6)
dot_change_anim(DotActor007,6)
dot_play_particle_unit(DotActor005,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)
dot_change_anim(DotActor001,0)
dot_change_anim(DotActor005,0)
dot_change_anim(DotActor007,0)

	--★★ノワール★★:（ブレイズ先生、目がヤバいな…）
	open_mind_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020029")

close_speech_window()

dot_disp_unit(DotActor008,true)
dot_disp_unit(DotActor009,true)
dot_disp_unit(DotActor010,true)
move_camera(19,31, 1.0)
wait_camera()

PlayPartVoiceDirect("ノワール","0030")

	--★★ノワール★★:なっ…魔物の群れ！？
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020031")

close_speech_window()

move_camera(25,31, 1.0)
dot_reserve_move_unit_seq(DotActor008,24,30)
dot_reserve_move_unit_seq(DotActor009,22,31)
dot_reserve_move_unit_seq(DotActor010,24,33)
exec_parallel_seq()
wait_camera()

	--★★ノワール★★:ブレイズ先生のほうへ向かってる！<br>クソッ、バルバロイもまだ残ってるってのに
	change_face(Actor001, "Anger")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020032")

close_speech_window()
wait_seq()

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor005,6)
dot_change_anim(DotActor007,6)
dot_play_particle_unit(DotActor005,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(0.2)
dot_move_knockback(DotActor005,30,31,0.2,2)
dot_move_knockback(DotActor007,30,33,0.2,2)
wait_time(0.2)
dot_change_anim(DotActor005,0)
dot_change_anim(DotActor007,0)
dot_change_anim(DotActor001,0)

dot_move_unit_seq(DotActor001,27,32)
wait_seq()

	--★★ノワール★★:先生、逃げろ！
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020033")

PlayPartVoiceDirect("ブレイズ","0015")

	close_speech_window()

	--★★ブレイズ★★:なんじゃ？<br>観測の邪魔じゃのう…ほれ
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020035")

close_speech_window()

dot_play_particle_unit(DotActor002,"Ef_C_Mag_N_Aura01",2,true)
wait_time(0.5)
dot_play_particle_unit(DotActor002,"Ef_C_Mag_N_Atk01",1,true)
wait_time(0.5)

dot_change_anim(DotActor008,6)
dot_change_anim(DotActor009,6)
dot_change_anim(DotActor010,6)
dot_play_particle_unit(DotActor008,"Ef_C_Mag_N_Hit01",1,true)
dot_play_particle_unit(DotActor009,"Ef_C_Mag_N_Hit01",1,true)
dot_play_particle_unit(DotActor010,"Ef_C_Mag_N_Hit01",1,true)
wait_time(0.2)

dot_play_particle_unit(DotActor008,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor009,"Ef_C_Cmn_DieEmy01",2,true)
dot_play_particle_unit(DotActor010,"Ef_C_Cmn_DieEmy01",2,true)
wait_time(0.5)

dot_disp_unit(DotActor008, false)
dot_disp_unit(DotActor009, false)
dot_disp_unit(DotActor010, false)
dot_remove_unit(DotActor008)
dot_remove_unit(DotActor009)
dot_remove_unit(DotActor010)
wait_time(0.5)

	--★★ノワール★★:なっ…！　<br>あれだけの魔物を一瞬で…？
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020037")

	close_speech_window()

	--★★ブレイズ★★:これ、なにをしておる！<br>さっさとそこのバルバロイと戦わんか！
	change_face(Actor002, "Anger")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020038")

	close_speech_window()

	--★★ノワール★★:あ…わ、わかった！
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020039")

close_speech_window()
fadeout(0,0,0,1.0, FADE_TIME)

dot_move_unit_seq(DotActor001,29,32)
wait_seq()

dot_change_anim(DotActor001,3)
wait_time(0.1)
dot_play_particle_unit(DotActor001,"Ef_C_Swd_N_Atk01",3,true)
wait_time(0.2)
dot_change_anim(DotActor005,6)
dot_change_anim(DotActor007,6)
dot_play_particle_unit(DotActor005,"Ef_C_Cmn_N_Hit_Sla01",1,true)
dot_play_particle_unit(DotActor007,"Ef_C_Cmn_N_Hit_Sla01",1,true)
wait_time(TIME_ELAPSED)

dot_remove_unit(DotActor004)
dot_remove_unit(DotActor005)
dot_remove_unit(DotActor006)
dot_remove_unit(DotActor007)

dot_disp_unit(DotActor011,true)
dot_place_unit(DotActor002,27,31)
dot_place_unit(DotActor001,25,32)
dot_change_anim(DotActor001,0)
dot_disp_weapon(DotActor001,false)
move_camera(26,31, 0.0)
wait_camera()
fadein(FADE_TIME)
wait_time(FADE_TIME)

	--★★ブレイズ★★:これをこう、採取して…<br>塩水に浸して、と…
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020041")

close_speech_window()

dot_move_unit_seq(DotActor002,26,31)
wait_seq()

PlayPartVoiceDirect("ブレイズ","0010")

	--★★ブレイズ★★:うむ。途中、少々邪魔は入ったものの<br>なかなかいいデータがとれたのう
	change_face(Actor002, "Smile")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020043")

close_speech_window()

PlayPartVoiceDirect("ノワール","0014")

	--★★ノワール★★:はぁ、それはよかった
	change_face(Actor001, "Normal")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020044")

	--★★ノワール★★:なあ、ブレイズ先生
	message("CO_101066_05020045")

	close_speech_window()

	--★★ブレイズ★★:なんじゃ？
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020046")

	close_speech_window()

	--★★ノワール★★:あんた、あんなにすごい魔法を使えるなら<br>俺たちと一緒に戦ってくれればいいのに
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020047")

	close_speech_window()

	--★★ブレイズ★★:…
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020048")

	--★★ブレイズ★★:ワシはほらもう、トシじゃから<br>魔法を１回使っただけでフラフラなんじゃよ
	message("CO_101066_05020049")

close_speech_window()

dot_move_unit_seq(DotActor002,27,31)
wait_seq()

	--★★ブレイズ★★:それにワシの魔法なぞ<br>おぬしらの戦いの役には立たんよ
	change_face(Actor002, "Sad")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020051")

	close_speech_window()

	--★★ノワール★★:え？
	change_face(Actor001, "Surprise")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020053")

close_speech_window()

dot_unit_dir(DotActor002,2)

	--★★ブレイズ★★:それはそうとおぬし<br>なかなかやるではないか
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020054")

	--★★ブレイズ★★:バルバロイの性質を瞬時に見極め<br>効果的な一手を決めておる
	message("CO_101066_05020055")

close_speech_window()

dot_move_unit_seq(DotActor002,26,31)
wait_seq()

	--★★ブレイズ★★:特に3体目のバルバロイを斬ったときの剣捌き<br>ありゃあ見事なもんじゃった！
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020056")

PlayPartVoiceDirect("ブレイズ","0010")

	--★★ブレイズ★★:円卓の騎士に<br>将来有望な新人が入ったもんじゃ
	change_face(Actor002, "Smile")
	message("CO_101066_05020057")

	close_speech_window()

	--★★ノワール★★:そ、そうか？
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020059")

	close_speech_window()

	--★★ブレイズ★★:うむ。ワシの授業でバルバロイ学を深く学べば<br>もっと効率的に戦えるようになるぞ
	change_face(Actor002, "Normal")
	open_speech_window("CHRNAME_BLAZE", Actor002, nil)
	message("CO_101066_05020060")

PlayPartVoiceDirect("ブレイズ","0011")

	--★★ブレイズ★★:精進せいよ、ノワール！
	change_face(Actor002, "Smile")
	message("CO_101066_05020061")

close_speech_window()

PlayPartVoiceDirect("ノワール","0007")

	--★★ノワール★★:あぁ、わかったよ
	change_face(Actor001, "Smile")
	open_speech_window("CHRNAME_NOIR", Actor001, nil)
	message("CO_101066_05020062")

local trustParam = set_communication_rankup("ブレイズ_コミュランク", "ブレイズ_親密度")

trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換

open_trust_rank_up(Actor002, trustParam)

	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Actor001, "Actor001", 101009001)
	character2DFull_Preload(Actor002, "Actor002", 101066001)
end
