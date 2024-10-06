-- このluaスクリプトは、CO_101064_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★リアム★★:それで、ハーブについて聞きたいこと<br>というのは？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:あのハーブの栽培のしかたを<br>詳しく教えてほしいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020003")


	--★★ノワール★★:栽培方法を間違って枯らしちゃったら<br>せっかくくれたあんたに申し訳ないからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020004")

	PlayAction(Actor002,"to  Std_Worry")

	--★★リアム★★:…ハーブの栽培は一筋縄ではいきませんよ？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020005")


	--★★リアム★★:気温や湿度、土の状態の確認を怠ることは<br>許されませんし
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020006")


	--★★リアム★★:たとえそれを完璧にこなしたとしても<br>ハーブの機嫌次第で枯れてしまうことがあります
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020007")

	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなに大変なのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020008")

	change_face(Actor002,"Smile")

	--★★リアム★★:ですが、だからこそハーブ栽培への挑戦は<br>あなたの精神的な成長に役立ってくれるはずです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020009")

	open_select_window_tag(Actor001,"Normal","CO_101064_03020011","CO_101064_03020012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうか<br>よし！挑戦してみるよ、俺
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020014")

	change_face(Actor002,"Smile")

	--★★リアム★★:ふふっ<br>あなたにハーブを差し上げてよかった
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:なんでも聞いてください<br>私の知りうることであればお教えいたします
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんか自信なくなってきた…<br>やめようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020018")

	change_face(Actor002,"Normal")

	--★★リアム★★:最初は誰でも失敗するものです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020019")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★リアム★★:ですが、失敗を恐れていては<br>その先に進むことはできません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020020")

	change_face(Actor002,"Smile")

	--★★リアム★★:私が初歩からレクチャーして差し上げます<br>ハーブ栽培に挑戦してみてください
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020021")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、そんなに大変なことを<br>タダで教えてもらうのも悪い気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020023")

	change_face(Actor002,"Normal")

	--★★リアム★★:ふむ…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020024")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:それでは<br>こういうのはどうでしょう？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020025")


	--★★リアム★★:この大聖堂にはさまざまな方が<br>悩みの相談にやってきます
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020026")


	--★★リアム★★:彼らの悩みを私やクラリスと一緒に<br>解決してあげてくれませんか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020027")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？でも、俺…<br>司祭やシスターの仕事の経験なんてないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:はい、それは理解しています<br>できることからで構わないのですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:それなら、うん<br>手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020030")


	--★★リアム★★:素晴らしい
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020031")

	change_face(Actor002,"Normal")

	--★★リアム★★:ではさっそく<br>みなさんのお話を聞いてきてください
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_03020032")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ、今日からなのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03020033")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ3_3")
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
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
