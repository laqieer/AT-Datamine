-- このluaスクリプトは、CO_101039_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
turn_lookat(Actor001,Actor006,0)
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor006,Actor001,0)
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
Hide(Actor008)
SwitchMob(false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★キャメロット騎士学術院（男）③★★:ノワール！<br>お前のその運動神経を陸上部で活かそう！
	Talk(Actor006,"NPCNAME_0241","speech","L","CO_101039_02020002")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:誘ってくれるのは嬉しいんだけど<br>…ごめんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020003")

	PlayAction(Actor006,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★キャメロット騎士学術院（男）③★★:ぐぬぬ…！<br>気が変わったらいつでも声をかけてくれ！
	Talk(Actor006,"NPCNAME_0241","speech","L","CO_101039_02020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:陸上部はお前が来るのを待っている！
	Talk(Actor006,"NPCNAME_0241","speech","L","CO_101039_02020005")

	change_face(Actor001,"Smile")

	--★★ノワール★★:あ、ああ…<br>（暑苦しい…）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020006")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
MobsNo = 1
template2()
set_pos(Actor004,{-2.471,0,-13.283})
Appear(Actor002)
Appear(Actor003)
Hide(Actor006)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.45,0.1,0.8,0.2)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,true)
setup_template_moveobj_110122_01(4,true)
setup_template_moveobj_110122_01(5,true)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:遅かったね？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ごめんごめん<br>ちょっと知り合いに話しかけられちゃってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020009")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ところでノワールくんはなにを選んだの？<br>私はオムレツセット！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020011")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は日替わりのスープセットとドリンク<br>ローラはフレンと一緒か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:うん、お揃いにしたの
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020013")

-- ▼直接出力
wait_time(0.5)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",0.3)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:あっ、ラシア
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020015")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to Sit01_RH01")
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:席を探してるのかな？<br>おーい、ラシア！一緒に食べよ～！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020016")

-- ▼直接出力
CloseTalkWindow()
IN_WALK(Actor004,CharaPos110122_01_001)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.8)
wait_time(0.1)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラシア★★:フレン！ローラも！
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101039_02020017")

-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor004,"Shy")

	--★★ラシア★★:えっと…<br>ノワール、私も同席していいですか？
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101039_02020019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、もちろんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020020")


	--★★ラシア★★:それじゃあお言葉に甘えて
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101039_02020021")

-- ▼直接出力
 --ラシア着席
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor004)
Appear(Actor005)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor002,"J_Head")
lookat_weight(Actor005,0.45,0.1,0.8,0.2)
wait_time(CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(6,true)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ラシアの選んだメニューはなにかな～？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020023")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラシア2★★:私はサンドイッチ<br>食堂のサンドイッチ、好きだから
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:サンドイッチは、私もよく頼むの<br>野菜が新鮮なんだよね
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020025")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:ラシアはサンドイッチに入ってる<br>チーズが目当てでしょ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020026")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力

	--★★ラシア2★★:うん<br>乳製品は欠かさず摂りたいから
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラシア2★★:みんなは食堂の<br>どんなメニューが好き？
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020028")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:いっぱいあるよー！<br>オムレツでしょ、豆のスープでしょ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020029")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力

	--★★ローラ★★:ふわふわのパンも！
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:うんうん、パンもおいしい！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020031")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア2★★:採れたての果物が食べられるのも嬉しいよね<br>ノワールはどうですか？
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_02020034","CO_101039_02020035","CO_101039_02020036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はあまり食にこだわりがなくてさ<br>食べられればなんでもいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020038")

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:えーっ！？なにを食べるかも<br>毎日の楽しみのひとつじゃない
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020039")

	change_face(Actor003,"Surprise")

	--★★ローラ★★:食堂のメニューは美味しいものばかりだから<br>いろいろ食べないともったいないよ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020040")

-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ラシア2★★:日々メニュー開発にいそしんでいる<br>ガレスとコック長がかわいそうです
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020041")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:こんなにみんなから<br>責められると思わなかった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020042")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どれが好きっていうのはないんだけど<br>日替わりセットを頼むことが多いかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:そっか<br>毎日違うものを食べるってのもいいね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020045")

	change_face(Actor002,"Smile")

	--★★フレン★★:そういうのも<br>この食堂の楽しみかたのひとつだね、うん！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020046")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:じつは俺も<br>この食堂のオムレツが大好きなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020048")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ノワールくん、わかってるー！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020049")

	change_face(Actor002,"Smile")

	--★★フレン★★:カンタンそうに思えるかもしれないけど
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020050")

	change_face(Actor002,"Smile")

	--★★フレン★★:オムレツを上手に作るのって<br>すっごく技術がいるんだよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020051")

	change_face(Actor002,"Smile")

	--★★フレン★★:つまり、こんなに美味しい<br>オムレツを作れるってことは…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:コック長とガレスの腕前は超一流！<br>学園の、いやログレスの宝だよね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020053")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは、大袈裟だなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020054")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:さーて、それじゃ<br>いっただきまーす！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020056")

-- ▼直接出力
wait_time(0.3)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.6)
wait_time(0.1)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラシア2★★:毎日、頭も体も使ってるから<br>たくさん食べておかないとね
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020058")

-- ▼直接出力
wait_time(0.3)
keep_delay_ik_lookat(Actor005,Actor003,"J_Head",0.6)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(1.0)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.8)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:ノワールさん？<br>私たちの顔になにか付いてる？
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020059")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いや<br>３人はすごく仲がいいなって思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020060")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "肯定")
-- ▲直接出力

	--★★フレン★★:私たち、みんなローマ生まれでね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020061")

	change_face(Actor003,"Smile")

	--★★ローラ★★:子供の頃からの付き合いなの
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020062")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ、そうだったんだな<br>昔から仲が良かったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020063")


	--★★フレン★★:私がローラのふりをして<br>ラシアにイタズラしたり
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020064")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力

	--★★ローラ★★:私がお姉ちゃんのふりをして<br>ラシアを困らせたり
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020065")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "怒り")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ラシア2★★:ふたりったら<br>私に意地悪ばっかりするんだもん！
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020066")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.8)
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラシア2★★:でも、ノワールがふたりと<br>ランチをする仲だなんて思わなかったです
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020068")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:じつはこのあいだね<br>陸上部の活動に付き合ってもらったんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定2")
-- ▲直接出力

	--★★ラシア2★★:ああ、そうなんですか<br>フレンの運動神経、すごかったでしょう？
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020070")


	--★★フレン★★:でも、ノワールくんもいいセンスしてたよ<br>だから陸上部にどう、って誘ってみたんだけどね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_02020074","CO_101039_02020075")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺はいいってば
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020077")

	change_face(Actor002,"Surprise")

	--★★フレン★★:つれないなぁ<br>このあいだ、楽しくなかった？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020078")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:楽しかったか、楽しくなかったかで言ったら<br>それはもちろん楽しかったんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020079")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:やらなきゃならないことがいろいろあってさ<br>本当にごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020080")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:気が向いたら応援に行くから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020081")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:たまに顔を出させてもらうつもりだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020083")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:本当？<br>約束だよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020084")

	change_face(Actor002,"Smile")

	--★★フレン★★:だいたい決まった日の放課後に<br>大聖堂前に集まってるから。絶対来てよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020085")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:だいたい？<br>思ったよりもゆるい感じなんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020087")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:あんまり強制しても<br>息苦しくなっちゃうだけだしね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020088")

	change_face(Actor002,"Smile")

	--★★フレン★★:…といっても決まったメンツは<br>ほぼほぼ毎日いるんだけど
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020090")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("ラシア", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ラシア2★★:ノワールが陸上部に入部ですか
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020092")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:仮入部ね、仮入部
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020093")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:仮入部したつもりもないんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020094")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラシア2★★:ノワールが走ってるところ<br>見てみたいなあ～
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020095")


	--★★フレン★★:でしょでしょ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020096")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:あっ、お姉ちゃん<br>呼ばれてるよ？
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020098")

	change_face(Actor002,"Surprise")

	--★★フレン★★:ん？<br>なになにー？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_02020100")

-- ▼直接出力
 --暗転してフレンを非表示に
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
set_pos(Actor007,{-2.471,0,-13.283})
set_pos(Actor008,{-3.144,0,-13.213})
Hide(Actor002)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor003,"J_Head")
wait_time(CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力

	--★★ラシア2★★:相変わらずフレンは顔が広いのね<br>あの人、別の学年でしょう？
	Talk(Actor005,"CHRNAME_RASIA","speech","L","CO_101039_02020101")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:お姉ちゃんは、学園のなかだけじゃなく<br>城下町にも知り合いがいっぱいいるの
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020102")

-- ▼直接出力
 --リオネスとフレンがやってくる
CloseTalkWindow()
IN_WALK(Actor007,CharaPos110122_01_001)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor007,Actor001,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor001,Actor007,"J_Head",0.8)
wait_time(0.2)
PlayActionDirect(Actor007,"to  Std_Talk")
wait_time(1.0)
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
IN_WALK(Actor008,CharaPos110122_01_002)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor008,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★フレン2★★:ノワールくんのそれって、今日のドリンク？
	Talk(Actor008,"CHRNAME_FREN","speech","L","CO_101039_02020104")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor008,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor005,Actor008,"J_Head",0.8)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そう。りんごジュース
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020105")


	--★★ノワール★★:これうまいな<br>甘さと酸味のバランスがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020106")

-- ▼直接出力
PlayPartVoice("ローラ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:そのジュース、ふたつのりんごを<br>ブレンドしてるって聞いたことがあるよ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_02020107")

-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★リオネス★★:ブレンドする前のを飲んでみるか？<br>ちょっと待ってろ、持ってきてやる
	Talk(Actor007,"CHRNAME_LYONESS","speech","L","CO_101039_02020108")

-- ▼直接出力
 --暗転して時間経過(ちょっと短めに)
CloseTalkWindow()
fadeout(0,0,0,1, FADE_TIME)
wait_time(FADE_TIME + 0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Normal")

	--★★リオネス★★:ほら。まずはこれ
	Talk(Actor007,"CHRNAME_LYONESS","speech","L","CO_101039_02020110")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まずくはないけど…甘すぎて飲みにくいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020112")

	PlayAction(Actor007,"to  Std_Talk")

	--★★リオネス★★:次はこっちを飲んでみろ
	Talk(Actor007,"CHRNAME_LYONESS","speech","L","CO_101039_02020113")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:うわっ！？<br>こっちは酸っぱすぎる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020115")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★リオネス★★:そのふたつをうまくブレンドしたのが<br>さっきのりんごジュースだ
	Talk(Actor007,"CHRNAME_LYONESS","speech","L","CO_101039_02020116")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "喜び")
-- ▲直接出力

	--★★リオネス★★:ガレスとコック長の自信作！<br>配合の割合は企業秘密！あたしも知らん！
	Talk(Actor007,"CHRNAME_LYONESS","speech","L","CO_101039_02020117")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんで知らないのに威張ってるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020119")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:でも、驚いたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020120")


	--★★ノワール★★:まったく方向性の違うふたつを混ぜることで<br>こんなに美味しいジュースができるなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_02020121")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン2★★:おもしろいね～<br>私も今度頼んでみようかな
	Talk(Actor008,"CHRNAME_FREN","speech","L","CO_101039_02020122")

-- ▼直接出力
local trustParam = set_communication_rankup("フレン_コミュランク", "フレン_親密度")
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
