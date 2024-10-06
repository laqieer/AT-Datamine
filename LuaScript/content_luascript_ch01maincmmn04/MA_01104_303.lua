-- このluaスクリプトは、MA_01104_303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
set_pos(Actor002,{-1.757,0,-0.491})
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
IN_WALK(Actor002,CharaPos110011_04_005)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3030001")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3030002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3030006")


	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3030008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3030009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
