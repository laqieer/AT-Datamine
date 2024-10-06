-- このluaスクリプトは、CO_101010_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:ランスロット先生～ちょっと聞きたいことが…ってあれ？いない
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020002")

-- ▼直接出力
PlayPartVoice("女子2", "肯定3")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:あっ！きみって、転入生のノワールくんだよね？
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020003")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("現代女子", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:ね、ね、ノワールくんがランスロット先生の幼馴染って本当？
	Talk(Actor005,"NPCNAME_0148","speech","N","CO_101010_03020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:え？まぁ、そうだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020006")

	PlayAction(Actor001,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("女子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:本当なんだ！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020007")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子2", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:ってことはランスロット先生のこといろいろ知ってるんだよね？
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020008")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（女）②★★:わたしたちにも教えて欲しいなー！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020009")

-- ▼直接出力
PlayPartVoice("現代女子", "照れ")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:お願いします！
	Talk(Actor005,"NPCNAME_0148","speech","N","CO_101010_03020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ええ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020012")


	--★★ノワール★★:（これが、アーサーが言ってた女子にモテモテってやつか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101010_03020013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:ランスロット先生ってどんなものが好きなの？
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("現代女子", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:趣味とかありますか！？
	Talk(Actor005,"NPCNAME_0148","speech","N","CO_101010_03020015")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（女）②★★:逆に苦手なものも知りたい！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020016")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ええーっと…ランスロットとはしばらく離れてたから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020017")


	--★★ノワール★★:俺が知ってるのは昔の情報で今も同じとは限らないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020018")


	--★★女子生徒たち★★:それでも全然いいです！！
	Talk(Actor006,"NPCNAME_0273","speech","N","CO_101010_03020019")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そっか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:えっと…ランスロットは水辺が好きなんだ泳いだり、潜ったり…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020022")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子1", "納得")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:そうなの！素敵～！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020023")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:水の流れる音を聞きながら読書したりたまに滝行とかもやったりしてたかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子2", "納得")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:ストイック～！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020025")


	--★★ノワール★★:あとは馬の世話とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020026")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:馬は賢いから好きなんだってさブラッシングとか、よくやってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020027")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2", "肯定3")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:かわいい～！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020028")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:逆に苦手なのは…そうだな汚いとことかは苦手みたいだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020029")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("現代女子", "納得")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:わかる！清潔感あるもんね！！
	Talk(Actor005,"NPCNAME_0148","speech","N","CO_101010_03020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（女）★★:さすがノワールくん詳しいね！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020031")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、これぐらいは別に…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020032")

-- ▼直接出力
setup_small_camera_start(Camera002)
turn_chara(Actor003, -134, 0)
turn_chara(Actor004, -150, 0)
turn_chara(Actor005, 160, 0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:すまない、少し手間取ってしまった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020034")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:なんだ、他にも生徒が来ていたのか俺に質問か？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020036")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あー、それがさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020037")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:はいはい！質問ありまーす！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020039")

	PlayAction(Actor004,"to  Std_Talk")

	--★★キャメロット騎士学術院（女）②★★:ランスロット先生って馬が好きなんですよね？先生が馬のお世話してるとこ、見たいな～
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020041")

-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:授業で馬を使う予定は今のところないな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020043")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("現代女子", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:そういうことじゃなくて
	Talk(Actor005,"NPCNAME_0148","speech","N","CO_101010_03020044")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("女子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:先生って泳ぐの得意なんでしょ？<br>私、先生に泳ぎ教えてもらいたいな～
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020045")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:課外活動の申請には少し時間がかかる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020046")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:そういうことじゃなくて
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020047")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("現代女子", "照れ")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:今からノワールくんとマンツーマンですよね？先生とふたりっきり…ちょっと羨ましいな～
	Talk(Actor005,"NPCNAME_0148","speech","N","CO_101010_03020048")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:こいつは入学時期が遅いからなこうでもしてやらんと皆に追いつけないんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020049")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:そういうことじゃなくて
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020050")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("女子2", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:先生ってば本当にもうっ…
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020052")

	PlayAction(Actor005,"to  Std_Sad02")

	--★★キャメロット騎士学術院（女）③★★:さすが、難攻不落のランスロット先生…
	Talk(Actor005,"NPCNAME_0148","speech","N","CO_101010_03020053")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:まぁ、そういうところがまたいいんですけどね！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020054")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:…？<br>そうか、ありがとう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020056")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ところで、今からノワールのバイブス学の補習を始めるんだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020057")

-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力

	--★★ランスロット★★:お前たちも質問があると言ったな？聞きたいなら席について用意を…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020059")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("女子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:あっ、いっけな～い！そろそろ行かないと限定ケーキが売り切れちゃう！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101010_03020061")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:質問は完了したので、わたしたちはこの辺で！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101010_03020062")

	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
PlayPartVoice("現代女子", "照れ")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:それじゃあ、失礼しま～す！
	Talk(Actor005,"NPCNAME_0148","speech","N","CO_101010_03020063")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
se_play("SE_ADV_MA_01B112_01_Foot_01")
se_play("SE_ADV_MA_01B112_12_Foot")
se_play("SE_ADV_MA_01B112_01_Foot_02")
Hide(Actor003)
Hide(Actor005)
Hide(Actor004)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
se_play("SE_ADV_MA_01B112_12_Door_Open")
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:ノワール、俺はそんなに質問しにくい態度をしていただろうか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020065")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_03020067","CO_101010_03020068")
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

	--★★ノワール★★:まぁ、してたとも言えるかなある意味
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020070")

-- ▼直接出力
PlayPartVoice("ランスロット", "照れ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:そうなのか？気を付けたもりだったんだが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020071")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:生徒の緊張感をほぐすにはどうしたらいいんだ？ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020072")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのままでいいんじゃないか？よくわからないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020074")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、そういうわけじゃないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020076")

-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ないけど？ないけど、なんだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020077")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁ、当人たちが解決したって言ってたし気にしないでいいんじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020078")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:そういうものだろうか…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020079")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことより、補習やるんだろさっさと終わらせよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03020081")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ、そうだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03020082")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ3_3")
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
