-- このluaスクリプトは、MA_01A112_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_003)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
DontChangeRandomCamera(true)
change_face(Actor001,"Sad")
set_pos(Actor001,{8.85,0,-24.95})
set_rot(Actor001,{0,90,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115034)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,{11.85,0,-24.95},0.75)
wait_time(0.75)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{12.85,0,-24.95},0.6)
wait_time(0.3)
turn(Actor001,0,141,0,0.25)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A112_130002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor001,"Close")
-- ▲直接出力

	--★★ギネヴィア★★:（いたい）
	Talk(Actor001,"CHRNAME_GUINEVERE","mind","L","MA_01A112_130003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
-- ▲直接出力

	--★★ギネヴィア★★:（いたいよ、ノワール）
	Talk(Actor001,"CHRNAME_GUINEVERE","mind","L","MA_01A112_130004")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115034)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
