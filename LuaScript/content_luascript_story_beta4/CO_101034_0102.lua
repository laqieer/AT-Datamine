-- このluaスクリプトは、CO_101034_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
DontChangeRandomCamera(true)
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:どのくらいの人に聞いたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:ざっと１０人ね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01020003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:それで、そのデータはどうするんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01020004")

-- ▼直接出力
PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力

	--★★エクセリア★★:そうね…実践して最適解を探してみたいわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:ノワールよければ今度付き合ってもらえないかしら？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01020006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺が？まあ、いいけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:準備ができたら声をかけるわしばらく忙しくなりそうね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01020008")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:（リフレッシュするんじゃないのか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101034_01020009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃ、俺もキミに合いそうなリフレッシュ方法を少し考えておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_acquired("エクセリア_コミュランク", "エクセリア_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_area_scene_preload(110031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
