-- このluaスクリプトは、PT5_01_0024.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_004)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:それではホームルームをはじめよう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240002")


	--★★ランスロット★★:まずはなにから話したものかと<br>考えていたんだが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:今年は特例措置の者もいるし<br>当学園の入学資格について話していこう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:（特例措置…俺のことだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT5_01_00240005")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:キャメロット騎士学術院は<br>ふたつの目的のために作られた学術機関だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ひとつは<br>ログレスを守る騎士の育成
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240007")


	--★★ランスロット★★:もうひとつは<br>バルバロイに対抗する戦士の教育
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:特に重要となるのが後者であり
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240009")


	--★★ランスロット★★:入学の前にはバルバロイと戦う資格の有無を<br>入念に審査され
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:入学後も各人の素養に合わせた<br>クラス分けやカリキュラムが用意される
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:補足しておくと、資格の有無の審査というのは<br>剣の祭壇に赴いての儀式だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240012")


	--★★ランスロット★★:今、この教室にいる大半は<br>儀式を通過しているはずだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240013")


	--★★ランスロット★★:儀式を済んでいない者もいる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240014")


	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00240015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:その者にはあらためて儀式…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:いや<br>入学試験の説明がなされることと思う
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00240017")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
ShowTutorialPopup(63)
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
