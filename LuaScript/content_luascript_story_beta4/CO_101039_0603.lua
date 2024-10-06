-- このluaスクリプトは、CO_101039_0603.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera006 = SetTemplate("Actor006",283,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera008 = SetTemplate("Actor008",260,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.5,0.1,0.8,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
turn_lookat(Actor004,Actor005,0)
keep_ik_lookat(Actor004,Actor005,"J_Head")
lookat_delay_weight(Actor004,0.5,0.1,0.8,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
turn_lookat(Actor005,Actor004,0)
keep_ik_lookat(Actor005,Actor004,"J_Head")
lookat_delay_weight(Actor005,0.5,0.1,0.8,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
keep_ik_lookat(Actor006,Actor005,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
keep_ik_lookat(Actor007,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor009, false)
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor010, false)
Hide(Actor010)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor010")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:ちょっとちょっと、みんなどうしたの！？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030002")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.6)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.7)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:このふたりのちょっとした言い合いをきっかけに<br>部員のみんな、いがみ合いをはじめちゃってさ
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_06030004")


	--★★ノワール★★:ちょっとした言い合いって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:練習のやりかたについてなんだ<br>ローマ流かログレス流のどっちでやるかって
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_06030006")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
wait_time(0.1)
lookat_delay_weight_reset(Actor002,0.6)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）②★★:ローマのやりかたには<br>長い歴史があるんだ！
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_06030008")

	PlayAction(Actor004,"to  Std_Worry")

	--★★キャメロット騎士学術院（男）★★:古臭いしきたりにしがみついてるから<br>ローマ野郎は成績が伸びないんだ！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_06030009")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("現代男子", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:なんだと！？
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_06030010")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:やる気かよ！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_06030011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おいおいふたりとも<br>やめろって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06030013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("現代男子", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:あーあ、こんなんじゃ今日は<br>練習する気になれないな
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_06030014")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ローマの奴は皇太子と同じく<br>気位ばかり高くて付き合いきれないぜ
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_06030015")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:そーこーまーでっ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
-- ▲直接出力

	--★★フレン★★:ふたりともこのあいだまで<br>同じ競技で一緒に頑張ってた仲間じゃない
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030017")


	--★★フレン★★:こんなことでいがみ合うのはよくないよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030018")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("現代男子", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:フレンはローマ出身なんだから<br>もちろん俺たちの味方だよな？
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_06030019")

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:えっ？それは…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030020")


	--★★キャメロット騎士学術院（男）③★★:みんなで楽しく運動する<br>それが俺たち陸上部のモットーだろ？
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_06030022")

	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:それがなんだ<br>つまらないことでケンカして
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_06030023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "苦しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:つまらないことじゃない！<br>ログレスのやりかたをバカにされたんだぞ
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_06030024")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）★★:ジーン部長はログレス出身だったよな？<br>だったら俺の言い分に賛同してくれるだろ！？
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_06030025")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:なにっ！？<br>い、いや、ちょっと待て…
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_06030026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor004,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("現代男子", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ずるいぞ、部長を引き入れるなんて！<br>だったらこっちはノワールだ
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_06030027")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:なんで俺！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06030028")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1.0)
wait_time(0.4)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ノワールはこの国の生まれじゃないし<br>このあいだローマ軍の救援にも行ってた
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_06030029")

	PlayAction(Actor005,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）②★★:つまりはローマ贔屓ってことだよな！？
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_06030030")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:なにがどうつまれば<br>そんな結論になるんだ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06030032")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:今日はみんな冷静な判断ができていないようだ<br>練習は切り上げて解散にしよう
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_06030034")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
Hide(Actor001)
Hide(Actor003)
Appear(Actor009)
Appear(Actor010)
keep_ik_lookat(Actor009,Actor010,"J_Head")
keep_ik_lookat(Actor002,Actor010,"J_Head")
keep_ik_lookat(Actor010,Actor009,"J_Head")
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★ノワール2★★:なんだか大変なことになったな
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030036")

	PlayAction(Actor010,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★ジーン2★★:はあ。こんな状況じゃ<br>競技大会の許可なんてもらえないよ
	Talk(Actor010,"NPCNAME_0241","speech","L","CO_101039_06030037")


	--★★ジーン2★★:フレンもノワールも<br>わざわざ顔を出してくれたのに悪いな
	Talk(Actor010,"NPCNAME_0241","speech","L","CO_101039_06030038")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera010)
end
-- ▲直接出力
	play_head_motion(Actor010, "Nod", 0.3, 1.0, false)

	--★★ジーン2★★:俺も今日のところは帰るよ<br>それじゃあ
	Talk(Actor010,"NPCNAME_0241","speech","L","CO_101039_06030039")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor010)
turn_lookat(Actor009,Actor002,0)
turn_lookat(Actor002,Actor009,0)
keep_ik_lookat(Actor009,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor009,"J_Head")
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール2★★:部長、かなり落ち込んでたな
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030041")

	change_face(Actor002,"Sad")

	--★★フレン★★:競技大会開催に向けて<br>陸上部を盛り上げようっていうときに
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030042")

-- ▼直接出力
PlayPartVoice("フレン", "悲しみ")
-- ▲直接出力

	--★★フレン★★:まさか部員のみんなが<br>ケンカをはじめちゃうなんてね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030043")

-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力

	--★★フレン★★:しかもどこの国で生まれたかとか<br>国のやりかたがどうだ、なんて
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030044")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★フレン★★:私はローマで生まれたけど<br>ログレスの人を嫌いだなんて思ったことないよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor009,"Normal","CO_101039_06030047","CO_101039_06030048","CO_101039_06030049")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ノワール2★★:なあに<br>これまで一緒にやってきた仲間だろ？
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030051")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
	change_face(Actor009,"Smile")

	--★★ノワール2★★:きっとすぐ仲直りしてくれるさ
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030052")

-- ▼直接出力
PlayPartVoice("フレン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:だといいんだけど
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030053")

	change_face(Actor002,"Sad")

	--★★フレン★★:みんなずっと口にしなかっただけで<br>いろいろ思うところがあったのかも
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030054")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor009, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★ノワール2★★:残念だけど<br>そう思えない人もいるんだ
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030056")

	change_face(Actor009,"Sad")

	--★★ノワール2★★:生まれた国の違いは<br>考えかたの違いに繋がって
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030057")

	change_face(Actor009,"Sad")

	--★★ノワール2★★:そこから争いが生じることは多い
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030058")

-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:そっか…そういうものかもしれないね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030059")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ノワール2★★:俺もそう思うよ、フレン
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030061")

	change_face(Actor009,"Normal")

	--★★ノワール2★★:どこで生まれたからとか<br>そんなことでいがみ合うのは間違ってる
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030062")

	change_face(Actor009,"Normal")

	--★★ノワール2★★:どうしたってケンカは起こるさ<br>でも、そのときにぶつけ合うのは
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030063")

	change_face(Actor009,"Normal")

	--★★ノワール2★★:お互いの意志でなくちゃいけない<br>本気で語らなきゃ絶対に分かり合えない
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030064")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:そうだよね<br>こんなことで争ってほしくないよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030065")

	change_face(Actor002,"Sad")

	--★★フレン★★:みんなに仲直りしてもらわなきゃ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030066")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ノワール2★★:今はみんな興奮してるだろうから<br>少し様子を見て話をしよう
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030068")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★フレン★★:そうだね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030069")


	--★★フレン★★:ねぇ、ノワールくん
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030071")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★フレン★★:私、ローマが好きだよ<br>だけどログレスのことも好きだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06030072")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール2★★:ああ<br>よく知ってるよ
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101039_06030074")

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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
