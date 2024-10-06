-- このluaスクリプトは、MA_01A900_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_002)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
tegami = setup_prop_object(10106004)
-- ▲直接出力
-- ▼直接出力
set_pos(tegami,{0.798, 0.816, -2.038})
-- ▲直接出力
-- ▼直接出力
set_rot(tegami,{0, 212, 0})
-- ▲直接出力
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
-- ▲直接出力
-- ▼直接出力
set_pos(tegami2,{1.052, 0.818, -1.827})
-- ▲直接出力
-- ▼直接出力
set_rot(tegami2,{0,0, 180})
-- ▲直接出力
-- ▼直接出力
pen = setup_prop_object(10106006)
-- ▲直接出力
-- ▼直接出力
on_parent(pen,Actor001, "Loc_weapon_constrint_R", {0,0,0,0,0,0})
-- ▲直接出力
-- ▼直接出力
CameraEx = set_camera({-0.607, 1.398, 0.131,   6.29017, 145.0539, 0,   29.32144})
-- ▲直接出力
-- ▼直接出力
 --黒背景に移行
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0,0,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
CameraStart = set_camera({-1.02168, 2.77861, 6.47483,   17.9243, 174.1532, 1.02564,   35.71302})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Studying")
setup_small_camera_start(CameraStart)
slidemove(CameraStart,-0.93, 2.48, 5.54,10)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
wait_time(4.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEx)
slidemove(CameraEx,-0.46, 1.37, -0.08,10)
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106004)
setup_prop_object_preload(10106003)
setup_prop_object_preload(10106006)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
