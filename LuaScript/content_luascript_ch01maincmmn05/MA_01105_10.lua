-- このluaスクリプトは、MA_01105_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPos112021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_008)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_common_look_at(Actor001,Actor002,1.5)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0,0,0,0)
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
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
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
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ヤケよ、ヤケ買いよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100002")

	open_select_window_tag(Actor001,"Normal","MA_01105_100004","MA_01105_100005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:当然の結果だな<br>俺の妹だし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_100007")

-- ▼直接出力
lookat_delay_weight_default(Actor002,0.7)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:なによ！<br>ノワールもディナタンに投票したっての！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100008")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:わたしに雇われているクセに！<br>裏切りものーっ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:誘拐されなくて良かったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_100011")

-- ▼直接出力
lookat_delay_weight_default(Actor002,0.7)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…心配、してくれてるの…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうね<br>結果的にそれが正解、それが安全よね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100013")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:いやあ、なんかむしろごめんね結果出せなくて<br>あなたもわたしに投票してくれたんでしょお？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100015")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:お、俺は誰にも投票してないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_100017")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:なんで投票してないのよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100018")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ご…『五月女王』になれなくたって<br>もう王妃様じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_100020")

-- ▼直接出力
setup_small_camera_start()
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:だって選ばれたかったんだもん…そしたら<br>ちょっとはキャメリアードも救われるじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100021")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あッ、これからちゃあんと救い出すんだけどね！<br>それでも、それでもよ…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100022")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:キャメリアードで育った、もと王女が<br>ログレスでも元気よって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:故郷に錦を飾る？っていうか
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100024")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
set_enable_auto_lookat(Actor001,true)
lookat_delay_weight_reset(Actor001,0.6)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Smile")

	--★★ギネヴィア★★:あっ、ここーっ！<br>ここに来たかった！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01105_100026")

	close_cutin()
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
template2()
Appear(Actor007)
on_camera(RndCamera011)
--フェードイン
fadein(CHARA_IN_OUT)
 --on_camera(RndCamera009)
wait_time(CHARA_IN_OUT)
-- ▲直接出力

	--★★ノワール★★:…宝石屋？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_100027")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:いつも来ては<br>いつも選び切れなくって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100028")


	--★★市民（中年男）★★:ま、毎度ご来店ありがとうございます殿下<br>ですが安物ですし、殿下に見合うものでは…
	Talk(Actor007,"NPCNAME_0157","speech","N","MA_01105_100029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:フフフ…、とても素敵だから来ています<br>いつも買っていけなくてごめんなさい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100030")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:迷うなら全部買っちゃえば？<br>王妃様なんだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_100031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:婚約も仮なら、実態も偽物よ<br>使うのは汗水垂らして働き稼いだお小遣いだけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:パパがいつも言ってたわ<br>「限られた資源は有効に使おうね」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:「その場の選択肢のなかから<br>価値あるものを見つけ出しなさい」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100034")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:要は<br>そーいうことなんじゃないかと思うわけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100035")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そういうものをいっぱい集めて<br>わたしはリッチになるのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100036")


	--★★ギネマウア★★:そろそろお決まりに？
	Talk(Actor003,"NPCNAME_0070","speech","N","MA_01105_100038")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:う～っ、やめて急かさないで、決めきれない…<br>どうしよう、ねえ、なにが一番イイ…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100039")

-- ▼直接出力
open_select_window_tag(Actor001, "Normal", "MA_01105_100041", "MA_01105_100042", "MA_01105_100043")
wait_time(0.5)
-- ▲直接出力

	--★★ギネヴィア★★:…………それ、リッチな、かんじ…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100044")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…似合いそうだと思ったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_100045")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:じゃあ、それ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100046")


	--★★市民（中年男）★★:一番の安物ですよ、イミテーションですし<br>もっと高価な、本物の貴石もございますが…
	Talk(Actor007,"NPCNAME_0157","speech","N","MA_01105_100047")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:うん、でも<br>これがいいです
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100048")

	PlayAction(Actor004,"to  Std_Talk")

	--★★皇帝ルーシャス★★:ぜんぶ寄越してもらおうか
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","MA_01105_100050")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor004)
Appear(Actor005)
Appear(Actor006)
setup_small_camera_start(RndCamera006)
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
turn_chara(Actor001, 20.477, 0)
turn_chara(Actor002, 3.91, 0)
turn_chara(Actor003, -14.965, 0)
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor001,true)
lookat_delay_weight(Actor001, 0, 0, 0, 0,1.0)
lookat_delay_weight(Actor003, 0, 0, 0, 0,1.0)
-- ▲直接出力

	--★★市民（中年男）★★:皇太子殿下！！<br>そのようなお戯れ…！
	Talk(Actor007,"NPCNAME_0157","speech","N","MA_01105_100052")

	PlayAction(Actor004,"to  Std_Talk")

	--★★皇帝ルーシャス★★:そなたらが不自由のないよう<br>店ごと買い上げたいところなのだが
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01105_100053")


	--★★皇帝ルーシャス★★:いつも『お小遣い』が足らなくてな
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01105_100054")


	--★★市民（中年男）★★:こんなにいただいたら<br>お釣りがでますよぉ
	Talk(Actor007,"NPCNAME_0157","speech","N","MA_01105_100055")


	--★★皇帝ルーシャス★★:貴様の眩しき笑顔の駄賃だ
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01105_100056")

	PlayAction(Actor004,"to  Std_Worry")

	--★★皇帝ルーシャス★★:民草のそれを見に来た、それが見たかった<br>せいぜい己を愛でて励んで余を崇め奉れ
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01105_100057")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★市民（中年男）★★:ローマは領土だけでなく<br>器も大きいのですねえ！！
	Talk(Actor007,"NPCNAME_0157","speech","N","MA_01105_100058")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:クッククク、いいぞ！<br>やるじゃないか！その調子だ！
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01105_100059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002, 0.8, 0.03, 0.7, 0.5)
keep_ik_lookat(Actor002,Actor004,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…ルーシャス皇太子殿下
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100060")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
DontChangeRandomCamera(true)
--皇帝ルーシャス,CHRNAME_LUCIUS @名前変更
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")

	--★★皇帝ルーシャス★★:やあ。麗しのギネヴィア王妃殿下<br>余が里帰りしている間に随分社交的になったな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100061")

-- ▼直接出力
OpenFirstAppearance(Actor004)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ルーシャス皇太子…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_100062")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…大陸からね、いらしてるの<br>ローマ大帝国からの交換留学生
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100063")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:ロンディニウムとは違う賑わいがあるな<br>あちらはホーム、こちらはゲスト…どちらも良い
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100064")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:さあ好きな物を持っていけ<br>美しきギネヴィア？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100065")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:せっかくですけど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100066")

	change_face(Actor004,"Sad")

	--★★皇帝ルーシャス★★:これでいくらでも飾り立てられる<br>はて、それを望んだのではなかったか？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100067")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:え、選べませんので…<br>こんなに多くては
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100068")

	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:ふむ。欲しがったり拒んだり…<br>惚れ惚れするほどわからぬ女だ、そなたは
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100069")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★皇帝ルーシャス★★:聞いたよ。人の良心につけこんで<br>彼まで引っ張りまわしているそうじゃないか
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100071")


	--★★ギネヴィア★★:…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100072")


	--★★皇帝ルーシャス★★:なるほど。そなたが彼女の飾りか
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100073")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:苦労するだろう。わかるよ<br>クッククク…
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100075")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★皇帝ルーシャス★★:そなたとは<br>良いトモダチになれそうだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01105_100076")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
