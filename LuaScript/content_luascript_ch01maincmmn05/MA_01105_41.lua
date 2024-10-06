-- このluaスクリプトは、MA_01105_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_02","111012_02_h")
Include("content_adv_advsmall_111012_02","Template111012_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-80,CharaPos111012_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111012_02,CameraPos111012_02_003)
	Camera002 = SetTemplate("Actor002",100,CharaPos111012_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleName111012_02,CameraPos111012_02_004)
	InitializeTemplateRandomCamera111012_02()
	InitializeTemplate111012_02()
-- ▼直接出力
prop001 = setup_prop_object(10130004)
set_pos(prop001 , {-2.3,0,16.34})
prop002 = setup_prop_object(10130004)
set_pos(prop002 , {-0.87,0.251,22.36})
set_rot(prop002,{0, 46.438, 180})
prop003 = setup_prop_object(10130004)
set_pos(prop003 , {2.71,0,17.13})
set_rot(prop003,{0, 100.713, 0})
prop004 = setup_prop_object(10130004)
set_pos(prop004 , {13.79,0,19.2})
set_rot(prop004,{0, 136.967, 0})
prop005 = setup_prop_object(10130004)
set_pos(prop005 , {-2.805,0,19.38})
set_rot(prop005,{0, -63.547, 0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
SetOffset(Actor001,0,0,0.15)
lookat_delay_weight(Actor002, {0.8, 0.05, 0.6, 0.6} , 1.0)
lookat_position(Actor002,{2.54,1.6,-1.465})
lookat_delay_weight(Actor001, {0.8, 0.05, 0.6, 0.6} , 1.0)
lookat_position(Actor001,{2.54,1.6,-1.465})
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("101010140_2", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101021","001","101021001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
hide_image(0.5)
wait_time(2.0)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力

	--★★ブルーノ★★:………
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","MA_01105_410002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(RndCamera001)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.6)
wait_time(0.4)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.6)
wait_time(1.5)
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
wait_time(0.5)
play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
wait_time(1.0)
lookat_delay_weight_reset(Actor002,0.5)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,0,0.8)
wait_time(0.4)
lookat_delay_weight_reset(Actor001,0.5)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,0,0.8)
wait_time(0.4)
slidemove(Actor002,{-0.5,0,24},3)
wait_time(0.4)
slidemove(Actor001,{0.425,0,24},3)
-- ▲直接出力
-- ▼直接出力
show_image("101010140_2",0.0,0.0, 1.5,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130004)
setup_prop_object_preload(10130004)
setup_prop_object_preload(10130004)
setup_prop_object_preload(10130004)
setup_prop_object_preload(10130004)
load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010140_2", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101021","001","101021001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName111012_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
