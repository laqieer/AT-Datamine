-- このluaスクリプトは、EA_007_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
CameraEX = set_camera({12.75, 1.34, -26.34,   0, 114.49, 0,   32.31116})
set_camera_nearclip(CameraEX,0.1)
RndCamera001 =CameraEX
on_active(CameraEX)
lookat_delay_weight(Actor001, {1.0, 0.03, 0.5, 0.2} , 1.0)
lookat_delay_weight(Actor002, {0.5, 0.03, 0.5, 0.2} , 0.6)
keep_delay_ik_lookat_object(Actor001,nil,"Camera.LinkCamera",10)
keep_delay_ik_lookat_object(Actor002,nil,"Camera.LinkCamera",10)
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
FX_DoF=load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEX = 2.5
gaussian_end_CameraEX = 2
gaussian_max_radius_CameraEX = 1.5
 --set_pos(Actor001, {-5.2, 0, 13.07})
 --set_pos(Actor002, {-5.35, 0,13.7})
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
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(CameraEX)
PlayPartVoiceDirect("ディナタン", "0034")
-- ▲直接出力

	--★★ディナタン★★:相手に聞いちゃうかも、です<br>あっ、これじゃサプライズにならない…
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","EA_007_0220004")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0010")
-- ▲直接出力

	--★★ラグネル★★:ディナタンちゃんらしくて可愛いね！<br>次！
	Talk(Actor002,"CHRNAME_RAGNAR","simple","N","EA_007_0220005")

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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
