-- このluaスクリプトは、PT2_01B_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力

	--★★フィエナ★★:あっ、ノワール<br>ようやく起きてきた
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_12_0010004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:フィエナ？<br>どうしたんだ、こんな朝から
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力

	--★★フィエナ★★:大切な話があるの<br>急いで円卓の間にみんなを集めてもらえる？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_12_0010006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいけど…大切な話って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0010007")

-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:みんなが集まってから話すわ<br>とにかく急いでほしいの
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_12_0010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:お願いね！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_12_0010009")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:フィエナのやつ<br>だいぶ急いでいたみたいだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0010011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ひとまずケイに相談して<br>円卓会議を開いてもらうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0010012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
