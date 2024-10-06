-- このluaスクリプトは、PT2_01C_09_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",245,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",310,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor003,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ヴォールス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ヴォールス★★:本当なのか！？
	Talk(Actor003,"CHRNAME_BORS","speech","L","PT2_01C_09_0040002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力

	--★★クレア★★:もう少し探ってみる必要はあるけれど<br>おそらくね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT2_01C_09_0040003")

-- ▼直接出力
 --ノワール登場のためカメラを指定
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:にわかには信じがたいが…
	Talk(Actor003,"CHRNAME_BORS","speech","L","PT2_01C_09_0040004")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor001)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ヴォールス<br>それと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0040005")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:おはよう、ノワール
	Talk(Actor003,"CHRNAME_BORS","speech","L","PT2_01C_09_0040006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ヴォールス★★:自分のキラーズだ<br>名はクレア、銘はカシウスという
	Talk(Actor003,"CHRNAME_BORS","speech","L","PT2_01C_09_0040007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:よろしく
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT2_01C_09_0040008")


	--★★ノワール★★:ふたりでなにを話してたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0040009")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:それは…
	Talk(Actor003,"CHRNAME_BORS","speech","L","PT2_01C_09_0040010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:守秘義務を守らせてもらうわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT2_01C_09_0040011")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0040012")

-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:すまんな、ノワール<br>今はまだ確かな証拠がなく、話してやれない
	Talk(Actor003,"CHRNAME_BORS","speech","L","PT2_01C_09_0040013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ヴォールス★★:もう少し待ってくれるか
	Talk(Actor003,"CHRNAME_BORS","speech","L","PT2_01C_09_0040014")

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
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
