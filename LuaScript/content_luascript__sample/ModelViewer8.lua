Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")

function Load()
	demo_setup_nofade()
	load_ui()

	load_scene("content_areascene_110011", "Area110011") -- ノワール教室：夕晴
	MAIN_CAMERA = set_camera({1.856,2.041,2.292,	3+10,-145.5,0,	21})

	POS = {-0.8,0,-1.4,	50}

	CHARA01 = set_chara("content_chr_401005_401005001_model", "401005001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	CHARA02 = set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	CHARA03 = set_chara("content_chr_401007_401007001_model", "401007001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	CHARA04 = set_chara("content_chr_401008_401008001_model", "401008001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	CHARA05 = set_chara("content_chr_401009_401009001_model", "401009001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	CHARA06 = set_chara("content_chr_401010_401010001_model", "401010001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	CHARA07 = set_chara("content_chr_401019_401019001_model", "401019001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	CHARA08 = set_chara("content_chr_401021_401021001_model", "401021001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")

--[[


]]

	off_active(CHARA01)
	off_active(CHARA02)
	off_active(CHARA03)
	off_active(CHARA04)
	off_active(CHARA05)
	off_active(CHARA06)
	off_active(CHARA07)
	off_active(CHARA08)

--[[


]]

end

function Play()
	on_camera(MAIN_CAMERA)
	demo_start_nofade()

	open_narration_window()
	message_direct("モデルビューワ　テスト８")
	close_narration_window()

	test_view(CHARA01, "118　401005001\nキャメロット騎士学術院（男）　学生")
	test_view(CHARA02, "119　401006001\nキャメロット騎士学術院（女）　学生")
	test_view(CHARA03, "120　401007001\nキャメロット騎士学術院（男）２　学生")
	test_view(CHARA04, "121　401008001\nキャメロット騎士学術院（女）２　学生")
	test_view(CHARA05, "122　401009001\nキャメロット騎士学術院（男）３　学生")
	test_view(CHARA06, "123　401010001\nキャメロット騎士学術院（女）３　学生")
	test_view(CHARA07, "124　401019001\n市民（中年男）　市民")
	test_view(CHARA08, "125　401021001\n市民（中年男）２　市民")

--[[

]]

	demo_end_nofade()

end


function test_view(chara_no, model_name)

	on_active(chara_no)

	turn(chara_no, 0,50+120,0, 0.5)
	wait_time(0.5)
	turn(chara_no, 0,50+240,0, 0.5)
	wait_time(0.5)
	turn(chara_no, 0,50,0, 0.5)

	open_narration_window()
	message_direct(model_name)
	close_narration_window()

	off_active(chara_no)

end


--[[	3Dモデル表示リスト

4	101009001	ノワール	制服　金コート姿
5	101009002	ノワール	制服
6	101009003	ノワール	東方諸国連合軍
7	101010001	ランスロット	円卓の騎士
8	101010002	ランスロット・アロンダイト	キラーズ
9	101011001	ギネヴィア	制服
10	101011002	ギネヴィア・アロンダイト	キラーズ
11	101012001	ディナタン	制服
12	101012002	ディナタン・アロンダイト	キラーズ
13	101012003	ディナタン	兵士

14	101013001	ガウェイン	制服
15	101014001	トリスタン	制服
16	101015001	アーサー	王族
17	101016001	ギネマウア・ロンゴミアント	制服
18	101016002	ギネマウア・ロンゴミアント	キラーズ
19	101017001	マルディサント	制服
20	101017002	マルディサント・ビアンパンサント	キラーズ
21	101017003	マルディサント	療養姿

22	101018001	ラグネル・ガラティン	制服
23	101018002	ラグネル・ガラティン	キラーズ
24	101019001	イゾルデ・フェイルノート	制服
25	101019002	イゾルデ・フェイルノート	キラーズ
26	101020002	マーリン・エクスカリバー	キラーズ
27	101021001	ブルーノ・ジョワイユ	キラーズ
28	101022001	モルドレッド	円卓の騎士

29	101023002	クラリス・クラレント	キラーズ
30	101024001	ボールス	円卓の騎士
31	101025002	クレア・カシウス	キラーズ
32	101026001	パーシヴァル	制服
33	101027001	ディンドラン・ゲイボルグ	制服
34	101028002	ガラハッド	銀卓の騎士
35	101029002	アステラ・カラドボルグ	キラーズ

36	101030001	エレイン	制服
37	101030002	エレイン	顔傷有
38	101032001	ガレス	制服
39	101033001	アメリア・タスラム	制服
40	101035002	リリアーナ・ロンギヌス	キラーズ
41	101037002	ラシア・アスカロン	キラーズ
42	101038001	ヴェンデ・バルムンク	制服
43	101039001	イーラ・グラム	制服
44	101040001	知将ケイ	制服

45	101041002	モルガン・バルバロイ	バルバロイ
46	101042001	モーロノエー	バルバロイ
47	101043001	マゾエー	バルバロイ
48	101044001	グリーテン	バルバロイ
49	101045001	グリートーネア	バルバロイ
50	101046001	グリートン	バルバロイ
51	101047001	ティーロノエー	バルバロイ
52	101048001	ティーテン	バルバロイ
53	101049001	ティートン	バルバロイ

54	101051001	皇帝ルーシャス	皇帝
55	101052001	ヴェルナルス大将軍	大将軍
56	101053001	マターヤ	銀卓の騎士
57	401035001	キャメロット軍兵士_上位	兵士
58	401036001	キャメロット軍兵士_下位	兵士
59	401037001	東方諸国連合軍兵_上位	兵士
60	401038001	東方諸国連合軍兵_下位	兵士

118	401005001	キャメロット騎士学術院（男）	学生
119	401006001	キャメロット騎士学術院（女）	学生
120	401007001	キャメロット騎士学術院（男）②	学生
121	401008001	キャメロット騎士学術院（女）②	学生
122	401009001	キャメロット騎士学術院（男）③	学生
123	401010001	キャメロット騎士学術院（女）③	学生
124	401019001	市民（中年男）	市民
125	401021001	市民（中年男）②	市民

]]


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
	POS = {-0.8,0,-1.4,	50}
	set_chara_preload("content_chr_401005_401005001_model", "401005001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	set_chara_preload("content_chr_401007_401007001_model", "401007001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	set_chara_preload("content_chr_401008_401008001_model", "401008001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	set_chara_preload("content_chr_401009_401009001_model", "401009001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	set_chara_preload("content_chr_401010_401010001_model", "401010001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	set_chara_preload("content_chr_401019_401019001_model", "401019001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
	set_chara_preload("content_chr_401021_401021001_model", "401021001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", POS, "Mob_Std_loop_m", "Normal")
end
