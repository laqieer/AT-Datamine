-- このluaスクリプトは、MA_01104_309.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110081_01","110081_01_h")
Include("content_adv_advsmall_110081_01","Template110081_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",315,CharaPos110081_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110081_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110081_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_003)
	InitializeTemplateRandomCamera110081_01()
	InitializeTemplate110081_01()
-- ▼直接出力
set_pos(Actor001,{-2.95,0,5.62})
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor003,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110081)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
Appear(Actor001)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,-3.81,0,7.33,1.4)
wait_time(1.4)
turn_chara(Actor001,310,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Serious")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3090001")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ランスロット★★:
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_3090002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3090003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3090004")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★ランスロット★★:
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_3090005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_3090006")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110081)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110081_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
