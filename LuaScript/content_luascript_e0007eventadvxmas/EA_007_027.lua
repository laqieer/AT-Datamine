-- このluaスクリプトは、EA_007_027.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
 --CameraEX = set_camera({0.39,1.38,0.519,0,-32.837,0,32.31116})
CameraEX = set_camera({0.496,1.38,0.564,0,-32.837,0,32.31116})
set_camera_nearclip(CameraEX,0.1)
Camera001 = manager.RegisterExclusiveCamera(CameraEX, Actor001)
on_active(CameraEX)
RndCamera001 = CameraEX
lookat_delay_weight(Actor001, {1.0, 0.03, 0.5, 0.2} , 1.0)
keep_delay_ik_lookat_object(Actor001,nil,"Camera.LinkCamera",10)
-- ▲直接出力
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEX = 1.5
gaussian_end_CameraEX = 3.0
gaussian_max_radius_CameraEX = 1.5
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start_CameraEX)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end_CameraEX)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius_CameraEX)
on_active(FX_DoF)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★トリスタン★★:それ答えるのって、ボクになにかトクある？
	Talk(Actor001,"CHRNAME_TRISTAN","simple","N","EA_007_0270003")

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
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
