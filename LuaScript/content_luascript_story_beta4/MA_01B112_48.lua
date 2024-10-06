-- このluaスクリプトは、MA_01B112_48.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115159)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ガラハッド<br>プレゼントは配れているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_480002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:子供の相手はコルベニック城にいた頃から<br>よくやっていたからな。お手の物だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_480003")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:終わったら少し散歩しないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_480009")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ガラハッドと？<br>わかった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_480010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:プレゼントを配るの、俺も手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_480011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115159)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
