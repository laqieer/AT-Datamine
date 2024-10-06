-- このluaスクリプトは、TU_68_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_01","100021_01_h")
Include("content_adv_advsmall_100021_01","Template100021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_01,CameraPos100021_01_002)
	InitializeTemplateRandomCamera100021_01()
	InitializeTemplate100021_01()
-- ▼直接出力
load_image("101010280", "content_still_10101028_image", "101010280_StillImage")
 --ボタン制御
ShowGlobalMenuButton(false)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()


	--★★アルハン★★:
	Talk(Actor001,"NPCNAME_0313","speech","L","TU_68_01001")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera005)
show_image("101010280", 0.0, 0.0, STILL_SWITCH_TIME,true,false )
set_position_image(0,60)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アルハン★★:
	Talk(Actor001,"NPCNAME_0313","speech","L","TU_68_01002")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010280", "content_still_10101028_image", "101010280_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName100021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
