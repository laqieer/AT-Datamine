-- このluaスクリプトは、CO_101064_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:どうかしましたか？<br>ノワールさん
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020004")


	--★★ノワール★★:やっぱりこのあいだのあれは<br>俺の見間違いだったのかなって思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020006")


	--★★リアム★★:あれ、とは？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020008")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ほら、リアムさんに似た誰かを<br>路地裏で見たっていう話だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020009")


	--★★ノワール★★:あのときはそう思えたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020010")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:こうやって普段のリアムさんを見てると<br>まったくの別人だったんじゃないかって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:リアムさん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020013")


	--★★リアム★★:誤解させたままはよろしくありませんので<br>事実をお伝えいたします
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:貴方が見たのは私で間違いないですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020015")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え！？<br>で、でも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020017")

	change_face(Actor001,"Anger")

	--★★ノワール★★:「おぼつかない足取りで拳を振るったって<br>さっきみてえにすっ転ぶのがオチだ」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020018")


	--★★ノワール★★:「大ケガしねえうちにさっさと消えな」<br>なんてことを言ってたのに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020019")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★リアム★★:そこまで細かく覚えていたんですか…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020021")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:じゃ、じゃあ…本当に…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:はい、私です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020023")

	change_face(Actor001,"Normal")

	--★★ノワール★★:自分のこと「俺」って言ってたけど？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020024")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★リアム★★:お恥ずかしい話ですが…<br>若い頃、少々ヤンチャをしていていましてね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020025")

	change_face(Actor002,"Normal")

	--★★リアム★★:そのとき使っていた言葉が<br>いまだに口を衝いて出ることがあるのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020026")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ヤンチャって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020027")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:国家や権力に反対意見を申し上げたり<br>似たような考えの持ち主と議論を戦わせたりです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020028")

	open_select_window_tag(Actor001,"Normal","CO_101064_05020030","CO_101064_05020031")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:正直、あのときのリアムさん…<br>ちょっと怖かった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020033")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★リアム★★:そうですか…<br>怖がらせてしまったこと、お詫びしておきます
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020034")

	change_face(Actor002,"Sad")

	--★★リアム★★:私もまだまだですね…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020035")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:意外だな…<br>今の姿からは想像つかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020037")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★リアム★★:そう思っていただいていたのは<br>嬉しいことですが…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020038")

	change_face(Actor002,"Normal")

	--★★リアム★★:叩けば埃の出る人間は多いものですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:街のみんなが知ったら<br>きっとひっくり返る
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020040")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★リアム★★:貴方だから特別にお教えしました<br>むやみに口外することなきようお願いしますよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、それはもちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020043")


	--★★ノワール★★:でもいったいなにがあって<br>司祭になったんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020044")

	change_face(Actor002,"Sad")

	--★★リアム★★:手短に説明しますと…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020045")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★リアム★★:とある人物に性根を叩き直されたんですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020046")


	--★★ノワール★★:…それで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:それだけです<br>手短に説明します、と言ったでしょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020049")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、もっとさ…こう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020050")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:さあ、ハーブのお勉強をしましょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05020051")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:あ、ああ、うん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05020052")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ5_3")
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
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
