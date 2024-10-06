-- このluaスクリプトは、PT5_01_0051_1.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:では今日も<br>ブリテン島の歴史について話していくとしよう
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510002")


	--★★ケイ★★:ローマの本隊が<br>この島から離れてしばらく
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510003")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ケイ★★:小競り合いは頻繁に起きていたものの<br>領主たちの争いは膠着状態に陥っていた
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:大きな動きがったのは<br>今からおよそ８年前
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510005")


	--★★ケイ★★:前王ユーサーが逝去し<br>現王アーサーがそのあとを継いでからだ
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510006")


	--★★ケイ★★:国内が安定しないうちにログレスを討ち<br>ブリテン西部を手に入れようと
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510007")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:東部の領主たちが<br>大規模な侵攻作戦を開始したのだ
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:この戦いはカレドニアが<br>混乱に乗じて他国の背後を突き
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510009")


	--★★ケイ★★:東部諸国の大半を手中に収めたことで<br>いったんの落ち着きを見せたのだが
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510010")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ケイ★★:カレドニア王ライエンスは<br>変わらずこの島の全権を握ろうとしている
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:彼奴を討つまで<br>この島に平和は訪れぬものと考えてほしい
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510012")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:カレドニアにバルバロイが巣食っているのなら<br>なおさらな
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00510013")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
