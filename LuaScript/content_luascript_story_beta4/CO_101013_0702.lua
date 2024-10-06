-- このluaスクリプトは、CO_101013_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",20,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	Camera002 = SetTemplate("Actor002",135,CharaPos110111_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_008)
	Camera003 = SetTemplate("Actor003",308,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_003)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_common_look_at(Actor001,Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor002,Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("子供_男2", "驚き")
-- ▲直接出力

	--★★子供（男）★★:あっ！<br>ガウェインお兄ちゃんにノワールお兄ちゃん！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020002")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:トム、久しぶりだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020003")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:よ、よう…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）★★:キンイロチョウ、見つかりそう？
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_07020007","CO_101013_07020008","CO_101013_07020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのあと<br>学園で本を読んでいろいろ調べてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今度ふたりで捕まえに行ってくるから<br>もう少しだけ待っててくれるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）★★:そうなんだ<br>うん、わかった。僕、待ってるよ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020014")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ノワール…ありがとな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今、ガウェインが頑張って<br>捕まえかたを調べてくれるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:もう少し待ってもらっていいか？<br>な、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:え？あ、ああ<br>もうすぐ捕まえられるからよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）★★:そうなんだ<br>うん、わかった。僕、待ってるよ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それがな<br>あの蝶、捕まえるのがすごく難しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020022")

	change_face(Actor001,"Sad")

	--★★ノワール★★:悪いけど諦めて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:悪いな、トム<br>もう少しだけ待っててもらえるか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020024")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:こないだ本を読んで<br>捕まえかたがわかったからよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020025")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）★★:お兄ちゃんたちなら<br>ぜったいに捕まえられるよね！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020027")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ところでよ<br>お前のお袋さんの調子はどうなんだ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020029")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）★★:元気だよ。親戚のおばさんに教わりながら<br>なにか仕事を始めたみたい
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★子供（男）★★:「母さん、頑張って働いて<br>うんと美味しいもの食べさせてあげるからね」
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020031")


	--★★子供（男）★★:って言って<br>今日も出かけてったんだ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そっか
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020033")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）★★:でもね<br>僕、この前見ちゃったんだ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020034")


	--★★子供（男）★★:…お母さんがひとりで泣いてるところ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020035")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:キンイロチョウを早く捕まえて<br>元気づけてやらないとな…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "落胆")
-- ▲直接出力

	--★★子供（男）★★:僕も…
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:トム、話がある
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020040")


	--★★ガウェイン★★:今は魔女だなんだで<br>バルバロイの数が増えちまってる
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:俺たちだっておちおち外は歩けねー<br>お前を守れるかどうかの保証もねー
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020043")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ガウェイン★★:だから<br>キンイロチョウのことは俺たちに任せてくれ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020044")


	--★★ガウェイン★★:ひとりで街の外に行ったりしないって<br>約束してくれ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020045")


	--★★ガウェイン★★:お前がいなくなったら<br>誰がお袋さんのことを守るんだ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:お前は家族を守れ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020047")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）★★:うん、わかった<br>僕、大人しく待ってるよ
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★子供（男）★★:じゃ、僕、お使いを頼まれてるから<br>今日はこれで行くね
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020050")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力

	--★★子供（男）★★:バイバイ、お兄ちゃんたち！
	Talk(Actor003,"NPCNAME_0248","speech","N","CO_101013_07020051")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
setup_small_camera_start()
 --ノワールとガウェインの首を調整
lookat_weight(Actor001,0.4, 0.08, 0.7, 0.6)
lookat_weight(Actor002,0.4, 0.08, 0.7, 0.6)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:悪い<br>ハッキリ伝えられなかった
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020053")


	--★★ガウェイン★★:どうやって捕まえたらいいのかわかんねーのに<br>もうすぐだ、なんて言っちまったしよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020054")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:なんかダメだわ<br>ここんところずっと失敗続きでよ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_07020057","CO_101013_07020058")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや<br>トムにはきちんと伝わったと思うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020060")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今、世界が危険な状態にあることと<br>ガウェインがトムを想っているってこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そうかな<br>…そうだといいな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020062")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:しょげてる場合じゃないぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020064")

	change_face(Actor001,"Normal")

	--★★ノワール★★:トムを励ますんなら<br>早くキンイロチョウをどうにかしないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020065")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ああ、悪い<br>お前にも心配かけさせちまったな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020066")

	goto Block2end

::Block2end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なあ、ガウェインはどうして<br>トムに対してそこまで親身になれるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020068")


	--★★ノワール★★:「知り合いか、そうじゃないかは関係ない」<br>って理屈だけとは思えない気がするんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020069")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:あー…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:俺さ<br>「家族は大事にしろ」って教わってんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020071")


	--★★ガウェイン★★:俺、生まれてすぐに家を出されて<br>親の顔とかちっとも覚えてねーのよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020073")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:でも、だからこそ<br>家族の愛情の大事さってのを理解してるつもりだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020074")


	--★★ガウェイン★★:そんで、家族を大事にしようとしてるやつは<br>力になってやりてー
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020075")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:あとは<br>ちょうどあいつのトシぐれーのときなんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020077")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:トムと同い年くらいのとき？<br>なにが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020078")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:俺が助けてもらったの
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020079")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、ずいぶん前に話してくれたあの人か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020080")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そう<br>だからさ、カッコつけてーじゃん
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020081")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:…こーゆーの<br>逆にカッコ悪いかなあ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020082")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いや、お前らしくていいと思うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020083")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:俺らしくってどーゆー意味だよ？<br>褒めてんのか、それ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020084")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:どうだかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07020085")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ったくよ<br>まあでも、口先ばっかりじゃ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020086")


	--★★ガウェイン★★:ヒーローにはなれねえよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07020087")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Appear(Actor004)
wait_time(CHARA_IN_WAIT)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor004)
DontChangeRandomCamera(true)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
setup_small_camera_start()
wait_time(1.0)
-- ▲直接出力
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
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
