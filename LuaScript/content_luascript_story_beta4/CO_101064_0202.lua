-- このluaスクリプトは、CO_101064_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")

	--★★クラリス★★:ふわわ～、ノワールくんじゃないですか～<br>いらっしゃいませ～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020002")

	PlayAction(Actor001,"to Greet_one")

	--★★ノワール★★:お疲れ様、クラリス
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020003")


	--★★ノワール★★:学園に通いながらシスターの仕事もやって<br>毎日大変だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020004")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Smile")

	--★★クラリス★★:いえいえ～好きでやっていることですから～<br>今日はどんなご用ですか～？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020005")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:いや、用というかなんというか<br>ちょっと気になることがあって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020006")

	change_face(Actor002,"Surprise")

	--★★クラリス★★:んん～？ノワールくん<br>聖堂は木になったりしませんよ～…？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020007")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、そっちの木じゃなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020009")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:その…司祭のリアムさんって<br>どんな人なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020011")

	change_face(Actor002,"Normal")

	--★★クラリス★★:リアム様ですか～？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020013")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★クラリス★★:とっても優しくて<br>いい方ですよ～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020015")

	open_select_window_tag(Actor001,"Normal","CO_101064_02020017","CO_101064_02020018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに優しそうだな<br>このあいだも街の人の手伝いもしてたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020020")

	change_face(Actor002,"Normal")

	--★★クラリス★★:はい。いつもお忙しいのに<br>仕事の合間をぬってみなさんの悩みを聞いてます
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020021")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★クラリス★★:街のみなさんも<br>リアム様のことを大好きだと思いますよ～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:優しい、か…<br>実はちょっとアヤシイと思ってるんだ、俺
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020024")

	change_face(Actor002,"Anger")

	--★★クラリス★★:こらっ、ノワールくん！
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020025")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★クラリス★★:誰かの悪口をいうなんて<br>メッ！ですよ？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020026")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、悪口というわけではないんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020027")

	change_face(Actor002,"Anger")

	--★★クラリス★★:誰かを悪く言う人は<br>誰かから悪く言われちゃうんですから！
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020028")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ご、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020029")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:優しいって答えはなんとなく想像できてた<br>他にも教えてくれ、リアムさんのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020031")

	change_face(Actor002,"Normal")

	--★★クラリス★★:リアムさんのことが<br>気になってるんですかぁ～？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020032")


	--★★ノワール★★:いや、ちょっとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020033")


	--★★クラリス★★:ん～と…カラ～い料理が好きで～<br>ウス～い味付けの料理は嫌いみたいです
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020034")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あっ…そう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020035")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クラリス★★:あとは～<br>ハーブにとっても詳しいんですよ
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020036")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ハーブ？<br>なんか意外だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020037")


	--★★クラリス★★:今日もハーブ園に行くと仰ってました
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:さっき言ってた野暮用って<br>そのことだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020039")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:（これは思い切って<br>本人に聞いてみるのが一番早いかな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_02020040")


	--★★ノワール★★:ハーブ園ってどこにあるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020041")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クラリス★★:大聖堂を出てすぐですよ～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_02020042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:そっか。ありがとう<br>ちょっと行って来る
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02020043")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ2_3")
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
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
