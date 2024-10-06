-- このluaスクリプトは、CO_101022_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110081_01","110081_01_h")
Include("content_adv_advsmall_110081_01","Template110081_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110081_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_005)
	Camera002 = SetTemplate("Actor002",200,CharaPos110081_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110081_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110081_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110081_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110081_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_007)
	InitializeTemplateRandomCamera110081_01()
	InitializeTemplate110081_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.5,0.7,0.2,1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
keep_ik_lookat(Actor006,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110081)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:よお、てめえらヘマしてねえか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02020002")

	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:あ、級長。お疲れ～
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020003")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.7)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.7)
wait_time(0.2)
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",0.7)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.7)
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:あれ？後ろにいるのって…
	Talk(Actor005,"NPCNAME_0212","speech","N","CO_101022_02020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クラリス", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:ふわわ、ノワールくんです～こんにちは～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020005")


	--★★ノワール★★:こ、こんにちは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020006")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:前に言ってた助っ人だ<br>まあまあウデは立つはずだぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02020007")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ノワールです。よろしく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020008")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:助っ人連れてくるっつって円卓の騎士連れてきちゃうのかよ
	Talk(Actor004,"NPCNAME_0213","speech","N","CO_101022_02020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Appl")
-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:さすが級長、スケールがでかい
	Talk(Actor005,"NPCNAME_0212","speech","N","CO_101022_02020010")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★クラリス★★:ノワールくんはとっても頼りになるので嬉しいです～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020011")

-- ▼直接出力
PlayPartVoice("クラリス", "笑い")
-- ▲直接出力

	--★★クラリス★★:よろしくお願いしますね～、ノワールくん
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020013")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:クラリス、それメニューボードだよ<br>ノワールはこっち
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020014")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クラリス", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:ふわわ～！？ま、間違えちゃいました～ごめんなさい…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:大丈夫、気にしないでくれ（いつものことだしな）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020016")

	PlayAction(Actor006,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:メガネ度が合ってるのにしたほうがいいんじゃないか？
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020017")

-- ▼直接出力
PlayPartVoice("クラリス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:これはモルくんからのもらいものですから大切にしたいんですよ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020018")

-- ▼直接出力
CloseTalkWindow()
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_delay_weight(Actor004,0.5,0.05,1.0,1.0,0.5)
wait_time(0.3)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）②★★:級長～ちょっと相談があるんだけどさ
	Talk(Actor004,"NPCNAME_0213","speech","N","CO_101022_02020020")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:あん、どした？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02020021")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(0.5)
se_play("SE_ADV_CO_101030_0303_Foot_2_Peaple")
wait_time(CHARA_IN_IN + 2.0)
Hide(Actor002)
Hide(Actor004)
keep_ik_lookat(Actor001,Actor003,"J_Head")
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:なんていうか…想像してたのと違うな『気まぐれな道化師』って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:もっとこう、規律が厳しい感じかと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020025")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "喜び")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:あははは！そっか～
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020026")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:『気まぐれな道化師』はみ～んな仲良しさんですよ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:級長が堅苦しいのを嫌うんだ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020029")


	--★★キャメロット騎士学術院（男）③★★:「てめえらは好き勝手やってりゃいい文句言ってくるヤツは俺がねじ伏せる」ってさ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020030")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:へえ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_02020033","CO_101022_02020034")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんか…わかる気はする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020036")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ハラの探りあいとか、嫌いそうだもんなモルドレッドって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020037")

-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★キャメロット騎士学術院（男）③★★:はは、正解！さすが円卓の騎士、見るとこ見てるね
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020038")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:意外だな…モルドレッドってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020040")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:もっとオレサマな感じかと思ってたよ<br>円卓会議での言動見てると
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020041")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:モルくんはとっても優しいですよ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020042")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:慕われてるんだな、結構
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020044")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★キャメロット騎士学術院（男）③★★:もちろん我らが自慢の級長だからね
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020045")


	--★★キャメロット騎士学術院（男）③★★:まぁ、ふだんはあんなだから勘違いされて当たり前だけどさ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:アーサー王がおかしくなっちゃったときもみんなで心配してたんだ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020048")


	--★★キャメロット騎士学術院（男）③★★:出自が出自だからね、あいつ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020049")


	--★★ノワール★★:出自…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020050")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クラリス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:モルくんはもともと王城で次期王位継承者として扱われていたらしいんです
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020051")

	change_face(Actor003,"Sad")

	--★★クラリス★★:でも、あるときアーサー様が戻られて…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020053")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ユーサー王の長子たるアーサー様が王になりあくまで次席だった級長は継承権を無くした
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だからアーサーに対してケンカ腰で接することが多かったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020055")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）③★★:で、自分が得るはずだった王位を持ってったアーサー王が、ああなっちゃっただろ？
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020056")

-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:俺らもショックだったけど一番ショックだったのは級長だと思うんだ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:いろいろ思うところもあるんじゃないかな
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020059")


	--★★キャメロット騎士学術院（男）③★★:あんなことがあった直後いつにもなく取り乱してさ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020060")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:しょっちゅう俺たちに黙って学園を離れていたよ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020062")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_02020064","CO_101022_02020065")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:黙って出て行ったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020067")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:みんなを心配させて…怒るべきなじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020068")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★キャメロット騎士学術院（男）③★★:いや、むしろいいことなんだよ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020069")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020070")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:モルくんが黙ってひとりで出ていくときは必ず戻ってきてくれるんです
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020071")

	change_face(Actor003,"Smile")

	--★★クラリス★★:だからわたしたちは安心してました
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020072")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ…信頼されてるんだなあ、あいつ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020073")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（じゃあ、みんなに伝えていくときは…それなりの覚悟をしている、ってことか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101022_02020074")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにやってたんだろう気にならないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020076")

-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★キャメロット騎士学術院（男）③★★:気にならないといったらウソになるけど
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020077")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★キャメロット騎士学術院（男）③★★:余計な詮索はしないことにしてるんだよ俺たちはさ
	Talk(Actor006,"NPCNAME_0211","speech","N","CO_101022_02020078")

	goto Block2end

::Block2end::
-- ▼直接出力
 --モルドレッド登場のため、カメラを指定
CloseTalkWindow()
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:モルくんはわかってたんですアーサー様に遭ったら大変なことになるって
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020080")


	--★★クラリス★★:わかってたからわたしたちに黙って行ったんです
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_02020081")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
Appear(Actor002)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.5,0.7,0.2,1)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:まだいたのか？帰っていいぜ、継承者
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02020083")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:は？なにか用事があって呼んだんじゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020084")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:もう終わったよこいつらにてめえを紹介したかっただけだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02020085")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:最初からそう言ってくれよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020086")

-- ▼直接出力
 --モルドレッドたちのやりとり
CloseTalkWindow()
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
wait_time(0.2)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor006,Actor002,"J_Head",1.0)
wait_time(0.3)
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(1.5)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to  Std_Talk")
wait_time(1.7)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor005,"to  Std_Joy")
wait_time(1.0)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(1.2) 
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:なに見てやがる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02020088")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…意外と信頼されてるんだな、と
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020089")


	--★★モルドレッド★★:あ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02020090")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:なんでもないこっちのことさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02020091")

-- ▼直接出力
local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110081)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110081_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
