-- このluaスクリプトは、MA_01A900_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
load_image("10302004", "content_still_10302004_image", "103020040_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("10302004", 0.0, 0.0,0)
-- ▲直接出力
-- ▼直接出力
set_scale_image(1.15,1.15)
set_position_image(250,50)
move_to_image(-250,50,10.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2.5)
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
hide_image(0)
wait_time(1.0)
setup_small_camera_start(RndCamera001)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
wait_time(1.0)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
character_in_move_walk_offset(Actor001,CharaPos112021_01_002,0,0,2.0,2.0)
setup_small_camera_start(RndCamera002)
wait_time(2.0)
setup_small_camera_start(RndCamera003)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-198,1)
wait_time(1)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(2.0)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,260,1)
wait_time(1)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(2.0)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なつかしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_070002")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10302004", "content_still_10302004_image", "103020040_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
