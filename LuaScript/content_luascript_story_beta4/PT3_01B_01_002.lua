-- このluaスクリプトは、PT3_01B_01_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT3_01B_01_002002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガラハッド…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_01_002003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ノ、ノワールか、おはよう！<br>今日もいい天気だな。絶好の勉強日和だ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT3_01B_01_002004")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ちゃんと予習、復習はしてきたか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT3_01B_01_002005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:お前は円卓の騎士なのだから<br>皆の模範であるべきだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT3_01B_01_002006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ガラハッドもコルベニック城にいた頃は<br>そうお爺様や姉上に…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT3_01B_01_002007")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:あねうえ、に…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT3_01B_01_002008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_01_002009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
