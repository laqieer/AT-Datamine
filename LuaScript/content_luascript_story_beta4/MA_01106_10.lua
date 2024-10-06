-- このluaスクリプトは、MA_01106_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",46,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101017","001","101017001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さん、足早いよお
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100002")

	open_select_window_tag(Actor001,"Normal","MA_01106_100004","MA_01106_100005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to ReadLetter")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:日が暮れるよ。急がないとさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_100007")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:わかってるけど…もお
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100008")

	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:そーゆーこっちゃないのよ、ノワール
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:早く着かないと夜道が危ない、って<br>心配してくれてるのはわかるんですけどね…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ディナタン、ほら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_100012")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:はっ、恥ずかしいよ兄さん<br>子供じゃないんだから…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100014")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:少しゆっくり行こうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_100015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:………うん。兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100016")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:いいお兄さんね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100018")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ディナタン★★:そうなんです！<br>自慢じゃありませんが！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100019")

	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:ウワア
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:傭兵してると色々とアブナイことが多いんです<br>兄さんはそういうの目を光らせてくれて…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100021")


	--★★ディナタン★★:戦いのときも、そうでないときも<br>悪いひとが近寄ってこないか見張ってくれていて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100022")

	PlayAction(Actor007,"to  Std_Talk")

	--★★トリスタン★★:妹離れ出来てないだけじゃないの？
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","MA_01106_100023")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ディナタン★★:ああ！それからお裁縫！<br>兄さんはお裁縫が得意なんですこのナリで！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:コートは自分で繕っちゃうし！<br>こんなリボンも作れちゃうんです！このナリで！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100026")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あっ、自慢じゃありませんが！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100027")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:裁縫趣味の男の子がいてもいいと思うわ<br>ちょっと見習いたいかも
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100028")

	open_select_window_tag(Actor001,"Normal","MA_01106_100030","MA_01106_100031")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
turn_chara(Actor001,-20,0.5)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:教えるよ、ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_100033")

	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:ちょーどよかったっ<br>あのね、お気に入りのパジャマがほつれちゃって
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100034")

	change_face(Actor001,"Normal")

	--★★ノワール★★:買い直したほうが良くないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_100035")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:そーゆーこっちゃないのよ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100036")

	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:にっしっし♪今度部屋来てよ<br>パジャマ…直して欲しいな
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100037")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:「このナリ」ってどういうことだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_100039")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さんっていつも同じ服で<br>オシャレとか興味なさそうじゃない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100040")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:物持ちがいい<br>と言ってほしいなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_100041")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:せっかく、かっこいいのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100042")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:なんでも大切にする感じはするかも
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100043")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:そうなんです<br>このナリで
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100044")

	goto Block2end

::Block2end::
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
turn_chara(Actor001,46,0.5)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:あれっ…ってことはディナタンのそのリボン<br>ノワールの手作りなの？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:毎日洗って、毎晩一緒に寝て<br>毎朝挨拶して、毎日つけてます
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100047")

	change_face(Actor006,"Sad")

	--★★イゾルデ★★:それはイタいわね
	Talk(Actor006,"CHRNAME_ISOLDE","speech","L","MA_01106_100048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:凄まじい家族愛ね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:兄さんは凄まじいんです！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100050")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:いえディナタン、あなたがよ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100051")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:えっ、ええっ、私！？<br>そうでしょうか～、え～、そうでしょうか～…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:ディナタン<br>わたしも自慢をひとつ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100053")

	PlayAction(Actor007,"to  Std_Worry")

	--★★トリスタン★★:なに、この流れ
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","MA_01106_100054")


	--★★ギネヴィア★★:わたしの友達がね<br>パパを弔ってくれたの
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100055")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:いいお兄さんよね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100056")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…そうなんです
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100057")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:自慢の兄です
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100058")

	PlayAction(Actor009,"to  Std_Talk")

	--★★マルディサント2D★★:オイ<br>自慢のオニーサン
	Talk(Actor009,"CHRNAME_MALADISANT","speech","L","MA_01106_100060")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor004,Camera004,EntryDataDuelCommonFormation01_04,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_104)
turn_chara(Actor002,67.472,0.8)
-- ▲直接出力

	--★★マルディサント★★:グラストンベリー着いたら<br>茶、しばかねえ？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01106_100062")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:ま、マルディサント…！？<br>だめー！兄さんは私と──
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100063")


	--★★マルディサント★★:キメえな違えよキメえな
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01106_100064")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ディナタン★★:マルディサント<br>ほんと、そういう言いかた良くないよ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_100065")

	PlayAction(Actor004,"to  Std_No")

	--★★マルディサント★★:茶はアタシとじゃなくて<br>モルガンせんせと
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01106_100066")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:ひっぱりだこね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_100068")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor005,Camera005,EntryDataDuelCommonFormation01_02,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_102)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Smile")

	--★★モルガン★★:一息、いかが？
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01106_100070")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101017","001","101017001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
