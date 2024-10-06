-- このluaスクリプトは、CO_101039_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110091_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_006)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor005,"J_Head")
lookat_weight(Actor003,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor005,"J_Head")
lookat_weight(Actor004,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
keep_ik_lookat(Actor005,Actor004,"J_Head")
lookat_weight(Actor005,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
keep_ik_lookat(Actor006,Actor004,"J_Head")
lookat_weight(Actor006,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
keep_ik_lookat(Actor007,Actor004,"J_Head")
lookat_weight(Actor007,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor005,"J_Head")
lookat_weight(Actor008,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Knight2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:またやってるのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020002")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:お前、さっきわざとぶつかってきたろ！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_09020003")

-- ▼直接出力
PlayPartVoice("現代男子", "怒り")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:わざとじゃねえよ！<br>いちいち難癖付けてくんじゃねえ！
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_09020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）★★:ローマ野郎は<br>嫌がらせも古くせえなあ！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_09020005")

	PlayAction(Actor005,"to  Std_Worry")

	--★★キャメロット騎士学術院（男）②★★:ログレス野郎は嫌いなヤツを<br>イビって追い出すわけか？ああ、陰湿だねえ！
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_09020006")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_reset(Actor002,0.8)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:ちょっと、みんな！<br>やめてってば！！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020007")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
wait_time(0.3)
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:どいてろよフレン！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_09020009")

	PlayAction(Actor005,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）②★★:だいたいお前はどっちの味方なんだよ！？<br>ローマ生まれなのにログレスの味方なのか？
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_09020010")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）★★:今はログレスにいるのに<br>ローマが正しいって言うのか！？
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_09020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "苦しみ")
-- ▲直接出力

	--★★フレン★★:私…私は…！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020012")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.6)
wait_time(0.2)
keep_delay_ik_lookat(Actor007,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor008,Actor002,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor006,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Knight2")
-- ▲直接出力

	--★★フレン★★:私はみんながケンカを始めたとき<br>その場にいなかったから
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:これから私の言うことなんて、きっと全部綺麗事<br>でも、言わせて
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フレン★★:ローマが正しいとかログレスが正しいとか<br>今はそんなことを言ってるときじゃない！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020017")


	--★★フレン★★:陸上部の活動で少しでも学園やログレス…<br>ううん、この島の暗い雰囲気を吹き飛ばそうよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:今までみんなが大切に思っていたものはなに？<br>この学園や陸上部でしょ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020019")


	--★★フレン★★:自分の過ちを認めて謝る<br>それが難しいことだってのはわかるよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020020")

	PlayAction(Actor002,"to  Std_Surp")

	--★★フレン★★:でも、言葉を届けるのが難しいなら<br>態度で少しずつでも見せていけばいいじゃない
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020021")


	--★★フレン★★:今、みんなはそれぞれ<br>違う方向を向いているかもしれないけど
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:歩みより、混ざり合うことで<br>お互いを引き立てることだってできるんだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★フレン★★:意地を張らないで
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020024")


	--★★フレン★★:私たちで陸上部を、競技大会を盛り上げて<br>学園や島中のみんなを元気にしようよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:青春の思い出を作ろうよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020026")


	--★★キャメロット騎士学術院（男）★★:思い出を…
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_09020027")


	--★★キャメロット騎士学術院（男）②★★:作る…？
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_09020028")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:そうだ<br>思い出は絆となり、俺たちの力となってくれる
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_09020029")


	--★★キャメロット騎士学術院（男）③★★:俺たち陸上部はみんなで楽しくをモットーに<br>これまで仲良く練習してきた
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_09020031")

-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:仲が良かったがゆえに<br>余計にこじれてしまったのかもしれないが
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_09020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:仲が良かったのなら<br>昔の関係に戻ることだってできるだろう？
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_09020033")

	open_select_window_tag(Actor001,"Normal","CO_101039_09020035","CO_101039_09020036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだよ<br>「雨降って地固まる」ってやつだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:これまで以上に絆が深まって<br>良い成績を出せるようになるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020039")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:うんうん、そうだよね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020040")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いやー、それはどうだろう？<br>とくに男って意地っ張りなもんだからなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020042")

-- ▼直接出力
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_delay_weight(Actor002,0.45,0.1,0.8,0.4,0.8)
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:ノワールくん！<br>変なところで水を差さないでよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020043")

-- ▼直接出力
wait_time(0.2)
lookat_delay_weight_reset(Actor002,0.8)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:みんな<br>さっきのノワールくんの言葉は無視してね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★フレン★★:絶対、これまで以上に仲良くなれるはずだから！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020045")

	goto Block1end

::Block1end::
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("現代男子", "肯定3")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:意地を張ってる場合じゃない、か<br>そうだよな
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_09020047")


	--★★キャメロット騎士学術院（男）★★:アーサー様とコトを構えようってときに<br>つまんないことで言い争ってる場合じゃないよな
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_09020048")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor004,"J_Head",0.8)
wait_time(0.4)
keep_delay_ik_lookat(Actor004,Actor005,"J_Head",0.8)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）②★★:その…悪かったな<br>なんか引くに引けなくなっちゃってさ
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_09020049")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "照れ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:こっちこそ、ごめん<br>一緒にいい思い出を作ろうぜ
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_09020050")

	change_face(Actor002,"Surprise")

	--★★フレン★★:みんな…！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020052")

-- ▼直接出力
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_delay_weight(Actor002,0.45,0.1,0.8,0.4,0.8)
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:さあ、じゃあ大会に向けて練習、練習！<br>アーサー王の前にあのふたりを倒さないとね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020053")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺たち？<br>どういうこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020055")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:競技大会は２チームに分かれての対抗戦なの
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フレン★★:私は陸上部のみんなと同じチーム！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020057")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:ノワールくんとジーン部長は<br>当日参加の人たちと同じチーム！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020058")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:そ、そんなの聞いてないぞ！？
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_09020059")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:当たり前でしょ<br>私、まだチーム分けのこと言ってなかったもん
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_09020062","CO_101039_09020063")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ええっ！？<br>今、そんな話の流れだった？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020065")

	change_face(Actor002,"Surprise")

	--★★フレン★★:そんな話の流れだったよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020066")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:私たちは競技大会では敵同士！<br>ぜーったい負けないんだから！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020067")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:そっちがその気なら<br>俺たちも全力でいくぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020069")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ふっふっふ<br>私たちに勝てるかな～？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020070")

	change_face(Actor001,"Smile")

	--★★ノワール★★:望むところだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020071")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:正々堂々戦おうね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020072")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:そうだ。みんなが仲直りできたこと<br>ルーシャスくんに知らせないと
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09020074")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうだな<br>急いで競技大会の準備をさせよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09020075")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ9_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Knight2")
	InitializeLoad_Preload()
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
