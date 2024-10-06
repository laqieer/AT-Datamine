-- このluaスクリプトは、EA_007_023.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-58.384,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	Camera002 = SetTemplate("Actor002",-43.6,CharaPos110141_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
CameraEX = set_camera({-1.2, 1.33, 1.56,   0, 128.72, 0,   32.31116})
set_camera_nearclip(CameraEX,0.1)
RndCamera001 =CameraEX
on_active(CameraEX)
lookat_delay_weight(Actor001, {1.0, 0.03, 0.5, 0.2} , 1.0)
lookat_delay_weight(Actor002, {0.5, 0.03, 0.5, 0.2} , 0.6)
keep_delay_ik_lookat_object(Actor001,nil,"Camera.LinkCamera",10)
keep_delay_ik_lookat_object(Actor002,nil,"Camera.LinkCamera",10)
set_pos(Actor001, {0.4, 0, 0.7})
set_pos(Actor002, {0.11, 0, 0.1})
set_pos(Actor003, {-0.85, 0, 2.234})
set_enable_auto_lookat(Actor001, false)
 --set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
 --Hide(Actor003)

-- ▲直接出力
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEX = 4.5
gaussian_end_CameraEX = 5.0
gaussian_max_radius_CameraEX = 1.5
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
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(CameraEX)
PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力

	--★★マルディサント★★:あ～、なんだろな～<br>詩………とか、ダメっかなあ～
	Talk(Actor001,"CHRNAME_MALADISANT","simple","N","EA_007_0230003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "悩む")
-- ▲直接出力

	--★★イゾルデ★★:ダメではないかもしれないけれど…<br>詩の内容によるわね
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_007_0230004")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力

	--★★マルディサント★★:うるせえなあ…まあ今ちょっと忙しいから<br>詩なんて考えるヒマねえけどさっ
	Talk(Actor001,"CHRNAME_MALADISANT","simple","N","EA_007_0230005")

-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン", "0036")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","simple","N","EA_007_0230006")

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
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
