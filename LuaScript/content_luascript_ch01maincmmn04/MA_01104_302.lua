-- このluaスクリプトは、MA_01104_302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
 --set_pos(Actor002,{-1.757,0,-0.491})
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115030)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --IN_WALK(Actor002,CharaPos110011_04_005)
EntryWalk(Actor002,Camera002,EntryData110021_01_02,CameraAssetBundleName110021_01,CameraPos110021_01_102)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0031")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3120001")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3120002")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0050")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3120003")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3120004")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3120005")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0005")
-- ▲直接出力

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3120006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3120007")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115030)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
