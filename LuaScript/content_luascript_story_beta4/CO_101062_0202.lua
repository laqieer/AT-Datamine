-- このluaスクリプトは、CO_101062_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",190,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	Camera002 = SetTemplate("Actor002",20,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_510_02_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_008)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
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
Hide(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401026","001","401026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:いいものたくさんそろってますからね～きっとノワールさんの欲しいものもあるはずです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020002")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:うーん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020003")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:無理にとは言いませんよ<br>お客様がお求めでないなら意味はありませんから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ふーんゴリ押しで怖い感じってだけでもないんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020005")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:もちろんです！<br>「押して駄目なら引いてみろ」ってやつです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020006")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ！<br>そうだな。ちょっと見せてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020007")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor001)
Appear(Actor003)
turn_chara(Actor002,357,0)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start(RndCamera002)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("市民中年_女2", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★市民（中年女）②★★:こんにちは、マルイル<br>いつも元気だねぇ
	Talk(Actor003,"NPCNAME_0256","speech","N","CO_101062_02020009")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ありがとうございます！「明るく元気に」が商売の基本ですから！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女2", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★市民（中年女）②★★:いいわねぇ。マルイルを見ていると、私まで元気になってくるわ～
	Talk(Actor003,"NPCNAME_0256","speech","N","CO_101062_02020011")

-- ▼直接出力
PlayPartVoice("マルイル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:そう言っていただけると嬉しいです！でも実はぼく、昨日までダウンしてたんですよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020012")


	--★★マルイル★★:仕入れで重い荷物を背負って歩き回ってたら腰を痛めちゃって…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020013")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民中年_女2", "納得")
-- ▲直接出力

	--★★市民（中年女）②★★:あら。私と一緒だわでも全然体調が悪かったように見えないわね
	Talk(Actor003,"NPCNAME_0256","speech","N","CO_101062_02020014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:それはこの塗り薬のおかげです！腰痛にバッチリ効くので、おすすめですよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女2", "肯定2")
-- ▲直接出力

	--★★市民（中年女）②★★:あら、そんなに効くのマルイルがそう言うなら、試してみようかしら
	Talk(Actor003,"NPCNAME_0256","speech","N","CO_101062_02020016")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor004)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:こんにちは、マダム！<br>どうしたんですか？困った顔をされてますが
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("貴族_女1", "悩む")
-- ▲直接出力

	--★★貴族（女）②★★:ああ、マルイル…実はね、お夕飯が決まらなくて…
	Talk(Actor004,"NPCNAME_0264","speech","N","CO_101062_02020019")

	change_face(Actor002,"Normal")

	--★★マルイル★★:なるほど～それなら、このスパイスはいかがですか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020020")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:どんな食材も美味しく仕上げてくれるんですよさ、ご試食どうぞ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020021")

-- ▼直接出力
setup_small_camera_start(Camera004)
Appear(Actor005)
turn_chara(Actor005, 125, 0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("貴族_女1", "笑い")
-- ▲直接出力

	--★★貴族（女）②★★:どれどれ…あら、本当！味がバッチリ決まってるわ！！
	Talk(Actor004,"NPCNAME_0264","speech","N","CO_101062_02020022")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "挨拶")
-- ▲直接出力

	--★★市民（中年男）★★:おお、マルイル。なんかいいものないかのう
	Talk(Actor005,"NPCNAME_0254","speech","N","CO_101062_02020024")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
lookWeight = {0.9, 0, 0.7, 0.35}
lookat_delay_weight(Actor002, lookWeight,2)
keep_ik_lookat(Actor002, Actor005, "J_Head")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:はい！なんでもありますよ～<br>これとか、おじさんの趣味にぴったりです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020025")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★市民（中年男）★★:おお、さすがマルイルじゃ～！
	Talk(Actor005,"NPCNAME_0254","speech","N","CO_101062_02020026")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
set_enable_auto_lookat_all(false)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Appear(Actor001)
 -- turn_chara(Actor001, -118.9, 0)
setup_small_camera_start()
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力

	--★★マルイル★★:ふう…ちょっと一息つけそうですねあれ？どうしました、ノワールさん
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020028")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101062_02020031","CO_101062_02020032","CO_101062_02020033")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:すごいな、マルイルどんどん商品を売っていくじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020035")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ありがとうございます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020036")

	change_face(Actor002,"Normal")

	--★★マルイル★★:「お客さんの要望に品物で応える」それが商人の務めですから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020037")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それに、マルイルと話したお客さんたちみんな楽しそうだし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020038")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:新参者とか言ってた割にずいぶんこの街に馴染んでるじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020039")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor006)
Camera006 = setup_small_camera_resetting(Actor006,CharaPos002,CameraPos002)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:いやあ、ぼくなんてまだまだですって
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020040")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本当になんでもあるんだな、この店
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:はい！仕入れは商人の基本ですから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020043")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor006)
Camera006 = setup_small_camera_resetting(Actor006,CharaPos002,CameraPos002)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:お客様のどんなご要望にも応えられるようあらゆるジャンルのものを取り揃えています！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020044")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:最後のおじさんはなんて？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルイル★★:それは秘密です！お客様の欲しいものはプライベートな情報ですからね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020047")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor006)
Camera006 = setup_small_camera_resetting(Actor006,CharaPos002,CameraPos002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:情報漏洩ダメ、ゼッタイ！これは商人の鉄則です！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020048")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力

	--★★市民（男）★★:あの…ちょっといいですか？探しているものがあるんですが
	Talk(Actor006,"NPCNAME_0177","speech","N","CO_101062_02020050")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:はい！お伺いします！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020051")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "悩む")
-- ▲直接出力

	--★★市民（男）★★:これ、なんですけど…
	Talk(Actor006,"NPCNAME_0177","speech","N","CO_101062_02020053")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:あー…すみません<br>これはちょっと今、在庫がないですね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020054")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:在庫がない？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020055")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:この工芸品はロンディニウムの特産品なんですそれで、いつも行商人から仕入れてるんですが…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:最近、街道に野盗や魔物だけでなくバルバロイまで出るようになったんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020057")


	--★★マルイル★★:なので、行商人が来る頻度が落ちてしまって
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020058")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで品物が入らないってわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("市民_男2", "落胆")
-- ▲直接出力

	--★★市民（男）★★:そうですか…残念です
	Talk(Actor006,"NPCNAME_0177","speech","N","CO_101062_02020060")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マルイル★★:いえ、大丈夫です！行商人が来ないならこっちから買い付けにいけばいいんですから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020061")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:お任せください！　ぼくが必ず品物を仕入れておきます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020062")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定3")
-- ▲直接出力

	--★★市民（男）★★:本当ですか？楽しみにしておきますね
	Talk(Actor006,"NPCNAME_0177","speech","N","CO_101062_02020063")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera006)
end
-- ▲直接出力

	--★★市民（男）★★:それでは私はこれで
	Talk(Actor006,"NPCNAME_0177","speech","N","CO_101062_02020064")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Camera001 = setup_small_camera_resetting(Actor001,CharaPos003,CameraPos003)
Hide(Actor006)
lookWeight = {0.9, 0, 0.7, 0.35}
lookat_delay_weight(Actor002, lookWeight,100)
keep_ik_lookat(Actor002, Actor001, "J_Head")
setup_small_camera_start(RndCamera001)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:さて…それじゃ、早速行ってきますね！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020066")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:行くって、どこへ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020067")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:やだなあ、もちろん買い付けですよロンディニウムまで行ってきます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020068")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ひとりで行くのか！？危険すぎるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020069")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:でも、ぼくが行かなきゃあの人の要望に応えられませんので！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020070")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうはいっても…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:大丈夫です。「商人たるもの、体が資本！」こう見えてぼく、鍛えてますから！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020072")


	--★★ノワール★★:（この様子じゃ、止めても行きそうだな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_02020073")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった。それじゃ、俺が護衛をするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020074")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:え、ノワールさんがですか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020075")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。ここに来る前は傭兵をやっていたからな行商の護衛も経験済みだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020076")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:ノワールさんにご迷惑をおかけするわけにはいきませんよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020077")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:護衛代のことを気にしてるのか？気持ち程度でいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020078")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力

	--★★マルイル★★:うーん。「正当な対価を正当な形で」それが商人の心得ですけど…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020079")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:………あ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020080")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:…そうですね！やっぱり、街道は危険ですし護衛の方にいてもらったほうがいいですね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020082")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:お代は弾みますからぜひぜひ、お願いします！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020083")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、任せろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_02020084")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ありがとうございます！それでは出発の日取りが決まったらお知らせしますね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_02020085")

-- ▼直接出力
local trustParam = set_communication_rankup("マルイル_コミュランク", "マルイル_親密度")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401026","001","401026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
