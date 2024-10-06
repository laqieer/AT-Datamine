-- このluaスクリプトは、PT2_01C_01_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン","笑い")
-- ▲直接出力

	--★★ディナタン★★:おはよう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン","悩む")
-- ▲直接出力

	--★★ディナタン★★:あらためて思うけど<br>去年はいろんなことがあったね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:嬉しいことも<br>…悲しいことも
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030005")

-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだな<br>本当に…いろいろあった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0030006")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ディナタン★★:ときどきね、思うの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030007")


	--★★ディナタン★★:たくさんのことが起こりすぎて<br>まるで現実じゃないみたいで
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン","落胆")
-- ▲直接出力

	--★★ディナタン★★:実は全部、夢なんじゃないかって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030009")


	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:でもね、夢であって欲しいわけじゃないの<br>全部なかったことになんて、したくない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030011")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:だって、夢なんかじゃないもの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030012")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:気持ちの整理ってのはすぐに出来るもんじゃない<br>今はゆっくり休もう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0030013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:…うん<br>わかったよ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01C_01_0030014")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
