-- このluaスクリプトは、EA_007_025.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",60,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera002 = SetTemplate("Actor002",87,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
CameraEX = set_camera({-3.7, 1.45, 13.635,   0, 262.0353, 0,   32.31116})
set_camera_nearclip(CameraEX,0.1)
RndCamera001 =CameraEX
on_active(CameraEX)
lookat_delay_weight(Actor001, {1.0, 0.03, 0.5, 0.2} , 1.0)
lookat_delay_weight(Actor002, {0.5, 0.03, 0.5, 0.2} , 0.6)
keep_delay_ik_lookat_object(Actor001,nil,"Camera.LinkCamera",10)
keep_delay_ik_lookat_object(Actor002,nil,"Camera.LinkCamera",10)
set_enable_auto_lookat(Actor001, false)
 --set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
FX_DoF=load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEX = 2.5
gaussian_end_CameraEX = 2
gaussian_max_radius_CameraEX = 1.5
set_pos(Actor001, {-5.2, 0, 13.07})
set_pos(Actor002, {-5.35, 0,13.7})
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start_CameraEX)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end_CameraEX)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius_CameraEX)
on_active(FX_DoF)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(CameraEX)
PlayPartVoiceDirect("パーシヴァル", "0034")
-- ▲直接出力

	--★★パーシヴァル★★:大量のお金を渡すかな！<br>上品にラッピングして！！
	Talk(Actor001,"CHRNAME_PERCIVAL","simple","N","EA_007_0250003")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ディンドラン", "0025")
-- ▲直接出力

	--★★ディンドラン★★:驚きです<br>下品すぎて
	Talk(Actor002,"CHRNAME_DINDRANE","simple","N","EA_007_0250004")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
