-- このluaスクリプトは、EA_007_024.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",167,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera002 = SetTemplate("Actor002",200,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
CameraEX = set_camera({7.67, 1.55, -1.08,   0, 0.57, 0,   32.31116})
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
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEX = 4.5
gaussian_end_CameraEX = 5.0
gaussian_max_radius_CameraEX = 1.5
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001, {7.37, 0, 0.505})
set_pos(Actor002, {8.1, 0,0.537})
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
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(CameraEX)
PlayPartVoiceDirect("アーサー", "0009")
-- ▲直接出力

	--★★アーサー★★:Ｂ級グルメかな！！！！
	Talk(Actor001,"CHRNAME_ARTHUR","simple","N","EA_007_0240003")

-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ウン！クムピルがいいな！<br>クムピルっていうのは──
	Talk(Actor001,"CHRNAME_ARTHUR","simple","N","EA_007_0240004")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("マーリン", "0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","simple","N","EA_007_0240005")

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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
