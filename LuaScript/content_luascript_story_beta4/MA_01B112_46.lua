-- このluaスクリプトは、MA_01B112_46.csvから自動生成されました --
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
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115159)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ランスロット<br>プレゼント配りの調子はどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_460002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:子供の相手は慣れないので苦戦はしたが<br>なんとか終わりそうだよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_460003")


	--★★ノワール★★:終わったら少し散歩しないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_460009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:ああ、いいだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_460010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:プレゼントを配るの、俺も手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_460011")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
