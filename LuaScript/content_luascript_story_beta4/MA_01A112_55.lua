-- このluaスクリプトは、MA_01A112_55.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115113)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor006")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Sad01")
PlayActionDirect(Actor004,"to  Std_Sad01")
wait_time(2.0)
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Greet_one")
wait_time(2.0)
setup_small_camera_start(Camera006)
play_head_motion(Actor006, "No", 0.3, 1.0, false)
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor002,"to  Std_Joy")
PlayActionDirect(Actor005,"to  Std_Joy")
wait_time(2.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102012)
load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	InitializeLoad_Preload()
	load_area_scene_preload(115113)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor006")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
