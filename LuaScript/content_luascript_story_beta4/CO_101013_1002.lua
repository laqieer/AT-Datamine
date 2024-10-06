-- このluaスクリプトは、CO_101013_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
turn_lookat(Actor001,Actor003,0)
set_enable_auto_lookat(Actor001, false)
set_common_look_at(Actor001,Actor003)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor003,0)
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor002,Actor003)
-- ▲直接出力
-- ▼直接出力
load_image("104000060", "content_still_10400006_image", "104000060_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:トム！久しぶりだな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020002")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力

	--★★子供（男）★★:お兄ちゃんたち！元気だった？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:お前こそ調子はどうだ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）★★:うん、僕も元気だよ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:それでな…これをお前に渡そうと思ってよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020007")

-- ▼直接出力
ShowImageItem("104000060")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("子供_男2", "挨拶")
-- ▲直接出力

	--★★子供（男）★★:なにこれ、宝石？<br>僕にくれるの？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020009")

-- ▼直接出力
HideImageItem()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("子供_男2", "喜び")
-- ▲直接出力

	--★★子供（男）★★:わぁーっ、チョウチョが入ってる！<br>キレイだなあ！こんなのがあるんだ！？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:それは琥珀っていうんだぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:宝石じゃなくて樹液が固まったものなんだ<br>だからこうして虫が閉じ込められたのもある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定3")
-- ▲直接出力

	--★★子供（男）★★:そっか、虫って樹液が好きだもんね
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020013")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:でな<br>そこに入ってるのはキンイロチョウだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("子供_男2", "驚き")
-- ▲直接出力

	--★★子供（男）★★:えっ？<br>…ほんとだ！！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力

	--★★ガウェイン★★:これならずっと<br>綺麗なキンイロチョウを見られる
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020016")


	--★★ガウェイン★★:…親父さんの思い出を<br>ずっとそばに置いておける
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020017")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("子供_男2", "喜び")
-- ▲直接出力

	--★★子供（男）★★:すごい！<br>お母さん、きっと喜ぶよ！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020018")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:そんで、あとでさ<br>本物のキンイロチョウを捕りに行こうぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020019")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガウェイン★★:バルバロイが出たって大丈夫だ<br>俺がぜーんぶブッ倒してやるから
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力

	--★★子供（男）★★:本当？<br>約束だよ！？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020021")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力

	--★★ガウェイン★★:そんときさ<br>こっちの兄ちゃんも連れて行っていいか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020023")

	open_select_window_tag(Actor001,"Normal","CO_101013_10020025","CO_101013_10020026")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、俺はいいよ<br>せっかくだしふたりで行って来いよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020028")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:このお兄ちゃんな<br>カッコつけてるけど虫が苦手なんだぜ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020029")

-- ▼直接出力
PlayPartVoice("子供_男2", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）★★:えー、ほんと？<br>大人なのに？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020030")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:大人だって苦手なものくらいあるんだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ダメって言われてもついていくぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020033")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）★★:ダメなんて言わないよ！<br>３人で一緒に行こう
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020034")

	change_face(Actor003,"Normal")

	--★★子供（男）★★:そうだ<br>お姉ちゃんも誘おうよ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020035")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:あー…誘ってみるけど<br>ラグネルは来ねえかもなあ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020036")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:虫が嫌いなんだよ、あいつ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020037")

-- ▼直接出力
PlayPartVoice("子供_男2", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）★★:そうなの？残念だなあ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020038")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★子供（男）★★:みんなですっごく大きなやつを捕まえようよ<br>ガウェインお兄ちゃんならできるでしょ？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020040")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:すっごく大きなキンイロチョウか…<br>頑張ってはみるけどよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020041")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "喜び")
-- ▲直接出力

	--★★子供（男）★★:ぜったい捕まえられるよ！<br>だってお兄ちゃんは太陽のヒーローだもん！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:まだ道半ばのヒーローだけどな<br>ありがとな、そう言われて悪い気はしねーよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020044")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:トム、ひとついいことを教えるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020045")

-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）★★:なあに、ノワールお兄ちゃん？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020046")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:琥珀ってさ<br>太陽の石とも呼ばれてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020047")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:えっ！？<br>なんでお前そんなこと知ってんの？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ちょっと大図書院で調べてみたんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定3")
-- ▲直接出力

	--★★子供（男）★★:太陽の石か～。だから<br>ガウェインお兄ちゃんが持ってたんだね
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020050")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:あー、いや<br>そういうわけじゃ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020051")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さらに太古の記憶が詰まっているとも<br>言われているんだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）★★:たいこ？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020054")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:うんと昔ってとこかな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020055")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★子供（男）★★:へえ～！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020056")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:トム。早いところお袋さんのところに<br>持って行ってやれよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020058")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）★★:あっ、うん！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020059")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("子供_男2", "喜び")
-- ▲直接出力

	--★★子供（男）★★:お兄ちゃんたち、本当にありがとう！<br>僕、この石、大事にするよ！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_10020060")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
setup_small_camera_start()
 --ノワールとガウェインの首を調整
turn_chara(Actor002,220,0)
lookat_weight(Actor001,1.0,0.5,0.8,0.2)
lookat_weight(Actor002,1.0,0.5,0.8,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:やったな、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020062")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:お前のおかげだよ<br>ありがとな、ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020063")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:これでトムのお袋さんが<br>元気になってくれるといいな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020064")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:きっと大丈夫さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020065")

	change_face(Actor001,"Normal")

	--★★ノワール★★:誰かとの繋がりを感じる<br>特別なものってあるだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020066")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:お前の金コートみたいなもんか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そう<br>大切な思いを支えてくれるもの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020068")


	--★★ノワール★★:あの琥珀はきっと<br>トムのお母さんを支えてくれるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020069")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:…だな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ノワール、決めたぜ<br>これから俺が目指すヒーロー像
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020072")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:聞かせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020073")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:「家族を大事にして<br>家族を大事にするヤツを支えるヒーロー」！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020074")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いいんじゃないか？<br>カッコイイと思うよ、俺は
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_10020075")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力

	--★★ガウェイン★★:…だよな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_10020077")

-- ▼直接出力
local trustParam = set_communication_rankup("ガウェイン_コミュランク", "ガウェイン_親密度")
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
load_image_preload("104000060", "content_still_10400006_image", "104000060_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
