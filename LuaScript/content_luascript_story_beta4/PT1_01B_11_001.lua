-- このluaスクリプトは、PT1_01B_11_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_02","110071_02_h")
Include("content_adv_advsmall_110071_02","Template110071_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_006)
	InitializeTemplateRandomCamera110071_02()
	InitializeTemplate110071_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★気取った男子生徒★★:お前、この前リリアーナちゃんと<br>一緒にいなかったか？なにしてたんだ？
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_11_0010004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★武骨な男子生徒★★:彼女が近くの農家の畑仕事を<br>手伝いに行くと言ったから、付いて行ったまでだ
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_11_0010005")


	--★★気取った男子生徒★★:随分と優しいんだな
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_11_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★武骨な男子生徒★★:いや、そんなつもりはない
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_11_0010007")


	--★★武骨な男子生徒★★:アーサー様の厚意により生徒になったとはいえ<br>もとは銀卓騎士団の一員だった者だ
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_11_0010008")

	PlayAction(Actor002,"to  Std_Joy")

	--★★武骨な男子生徒★★:ログレスに弓引くのではないかと<br>見張っていただけのこと
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_11_0010009")

	PlayAction(Actor003,"to  Std_Talk")

	--★★気取った男子生徒★★:その割には、お前…<br>楽しそうに話してるように見えたけど？
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_11_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★武骨な男子生徒★★:一緒にいてわかったが<br>悪辣な策を仕掛けるタイプではないとわかったし
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_11_0010011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★武骨な男子生徒★★:体調が優れぬアーサー様へ<br>見舞いとして野菜を持っていくと言っていたから
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_11_0010012")


	--★★武骨な男子生徒★★:アーサー様の<br>好きそうな食べ物を紹介していただけだ
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_11_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "落胆")
-- ▲直接出力

	--★★武骨な男子生徒★★:…もっとも<br>アーサー様の好物に野菜はあまり含まれぬのだが
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_11_0010014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★気取った男子生徒★★:…そういえば、そうだったな
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_11_0010015")

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
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
