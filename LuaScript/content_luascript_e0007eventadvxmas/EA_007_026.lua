-- このluaスクリプトは、EA_007_026.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-25,CharaPos112031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_003)
	Camera002 = SetTemplate("Actor002",-9,CharaPos112031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_004)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
-- ▼直接出力
CameraEX = set_camera({0.4, 1.46, 0.24,   0, 167.1563, 0,   32.31116})
set_camera_nearclip(CameraEX,0.1)
RndCamera001 =CameraEX
on_active(CameraEX)
lookat_delay_weight(Actor001, {1.0, 0.03, 0.5, 0.2} , 1.0)
lookat_delay_weight(Actor002, {1.0, 0.03, 0.5, 0.2} , 1.0)
keep_delay_ik_lookat_object(Actor001,nil,"Camera.LinkCamera",10)
keep_delay_ik_lookat_object(Actor002,nil,"Camera.LinkCamera",10)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
FX_DoF=load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEX = 2.5
gaussian_end_CameraEX = 2
gaussian_max_radius_CameraEX = 1.5
set_pos(Actor001, {1.37, 0, -1.61})

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
	load_area_scene(112031)
	Actor001 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(CameraEX)
PlayPartVoiceDirect("クレア", "0009")
-- ▲直接出力

	--★★クレア★★:予期せぬ事件を起こしましょう<br>解決までの道筋が険しいほどイイわ
	Talk(Actor001,"CHRNAME_CLARE","simple","N","EA_007_0260003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス", "0008")
-- ▲直接出力

	--★★ヴォールス★★:こういうヤツなんだ<br>驚かせてすまないが
	Talk(Actor002,"CHRNAME_BORS","simple","N","EA_007_0260004")

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
	load_area_scene_preload(112031)
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
