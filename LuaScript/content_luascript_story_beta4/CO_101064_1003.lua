-- このluaスクリプトは、CO_101064_1003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor006,"to  Std_Angry")

	--★★山賊A★★:なんだぁ、テメェらは？
	Talk(Actor006,"NPCNAME_0198","speech","N","CO_101064_10030002")

	open_select_window_tag(Actor001,"Normal","CO_101064_10030004","CO_101064_10030005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:通りすがりの正義の味方だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10030007")

	PlayAction(Actor004,"to Greet_one")
	change_face(Actor004,"Normal")

	--★★市民（中年男）②★★:よっ！<br>決まったじゃねーか、ノワっちゃん！！
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_10030008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（変な合いの手を入れられると<br>決まるものも決まらないじゃないか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_10030009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Serious")

	--★★ノワール★★:ログレスの住人に迷惑をかけるのはやめろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10030011")

	change_face(Actor001,"Serious")

	--★★ノワール★★:手荒な真似はしたくない<br>今すぐ立ち去ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10030012")

	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Normal")

	--★★山賊B★★:はぁ？どこの馬の骨とも知れねーヤツの<br>言うことを素直に聞けるかってんだ
	Talk(Actor007,"NPCNAME_0199","speech","N","CO_101064_10030013")

	change_face(Actor007,"Normal")

	--★★山賊B★★:こちとら黒牙団だぜ？
	Talk(Actor007,"NPCNAME_0199","speech","N","CO_101064_10030014")

	goto Block1end

::Block1end::

	--★★リアム★★:私たちの名を騙って<br>ずいぶんと好き勝手してくれたようですが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030016")


	--★★リアム★★:これ以上まだ続けるというのであれば<br>寛容な主も見逃してはくれませんよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030017")

	PlayAction(Actor007,"to  Std_Angry")
	change_face(Actor007,"Normal")

	--★★山賊B★★:なんだお前<br>なにをごちゃごちゃ抜かしてやがる
	Talk(Actor007,"NPCNAME_0199","speech","N","CO_101064_10030018")


	--★★山賊A★★:ここがどこかわかってんのか？<br>黒牙団のアジトだぞ
	Talk(Actor006,"NPCNAME_0198","speech","N","CO_101064_10030019")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Normal")

	--★★市民（中年男）②★★:はぁ～？オレたちはこんなところ<br>アジトにした覚えはねえなあ…
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_10030020")


	--★★市民（中年男）★★:だいたいよ、こんなカビくせえところ<br>アジトにしようとするヤツいねえだろ
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_10030021")

	PlayAction(Actor007,"to  Std_Surp")

	--★★山賊B★★:お、おい待て<br>まさか…本物の黒牙団？
	Talk(Actor007,"NPCNAME_0199","speech","N","CO_101064_10030022")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★市民（中年男）②★★:ご名答～
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_10030023")


	--★★山賊A★★:黒牙団は<br>随分昔に壊滅したってハナシじゃ…
	Talk(Actor006,"NPCNAME_0198","speech","N","CO_101064_10030024")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★市民（中年男）★★:それがよー、再結成したんだよ
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_10030025")

	PlayAction(Actor002,"to  Std_No")

	--★★リアム★★:していませんよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030026")

	PlayAction(Actor006,"to  Std_Sad01")

	--★★山賊A★★:くっ…本物がどれだけ強かったか知らねえが<br>今じゃオッサンばっかりじゃねえか！
	Talk(Actor006,"NPCNAME_0198","speech","N","CO_101064_10030027")


	--★★市民（男）★★:幸せだねえ<br>本物がどれだけ強かったか知らねえってのはさ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10030028")


	--★★リアム★★:これが最後の忠告です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030029")

	PlayAction(Actor002,"to  Std_No")

	--★★リアム★★:迷惑行為をやめて<br>今すぐここから立ち去りなさい
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030030")


	--★★山賊B★★:う、うるせえうるせえ！<br>たった５人でなにができるんだ
	Talk(Actor007,"NPCNAME_0199","speech","N","CO_101064_10030031")


	--★★山賊A★★:戦いは数だってことを教えてやるぜ！
	Talk(Actor006,"NPCNAME_0198","speech","N","CO_101064_10030032")


	--★★市民（男）★★:どうやら、あっちも覚悟できたようだぜ<br>リアム？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10030034")

	PlayAction(Actor002,"to  Std_Worry")

	--★★リアム★★:…そうか<br>どうしてもやるってんなら仕方ねぇな
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030035")

	change_face(Actor002,"Anger")

	--★★リアム★★:死ぬ覚悟ができたヤローから<br>かかってこいやぁあああああ！！
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030036")


	--★★山賊A★★:つ、つえぇ…
	Talk(Actor006,"NPCNAME_0198","speech","N","CO_101064_10030038")


	--★★山賊B★★:これが、本物の黒牙団…
	Talk(Actor007,"NPCNAME_0199","speech","N","CO_101064_10030039")

	change_face(Actor002,"Normal")

	--★★リアム★★:理由もなく人を傷つければ<br>それはいつか必ず自分に返ってきます
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030040")


	--★★リアム★★:ちょうど、今のあなたたちのように
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030041")


	--★★山賊A★★:う、うるせぇ…！<br>てめーになにがわかる！
	Talk(Actor006,"NPCNAME_0198","speech","N","CO_101064_10030042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:わかります<br>私もかつて経験しましたから
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030043")


	--★★リアム★★:あなたたちの拳から伝わってきた<br>怒り、憎しみ、そして悲しみ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030044")


	--★★リアム★★:それは昔の黒牙団が抱いていたものと<br>よく似ています
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030045")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:だからこそお伝えしましょう<br>こんなことを続けても、なにも変わりません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030046")


	--★★リアム★★:せいぜい<br>ちっぽけなイザコザを生み出すのが関の山です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030047")

	PlayAction(Actor007,"to  Std_No")

	--★★山賊B★★:だったらどうしろってんだ！？<br>どうせなにをやっても変わりゃしねぇんだ！
	Talk(Actor007,"NPCNAME_0199","speech","N","CO_101064_10030048")


	--★★リアム★★:それは違います<br>簡単なことではありませんが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030049")


	--★★リアム★★:そばに寄り添ってくれる者がいれば<br>人は変わることができるのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030050")


	--★★リアム★★:もし、あなたたちが変わりたいと思うなら<br>私があなたたちに寄り添いましょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:そうですね…<br>まずは一緒にハーブでも育ててみますか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030052")

	PlayAction(Actor006,"to  Std_Surp")

	--★★山賊A★★:てめー…本気か？
	Talk(Actor006,"NPCNAME_0198","speech","N","CO_101064_10030053")

	change_face(Actor002,"Normal")

	--★★リアム★★:もちろんです。その気になったら<br>ログレスの大聖堂を訪ねてきてください
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030054")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:いつでも、お待ちしていますよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10030055")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ10_4")
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
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
