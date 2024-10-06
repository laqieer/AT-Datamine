-- このluaスクリプトは、MA_01C112_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera002 = SetTemplate("Actor002",187.6,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-1.85,1.79,21.59})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-2.38,2.003,22.63})
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002,1.0, 0, 0.5, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115076)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_410002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_410003")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight(Actor002,0.8, 0.1, 0.4, 0.2,0.5)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:………あ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_410005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_410007")

-- ▼直接出力
lookat_delay_weight(Actor001, 1.0, 0, 0.6, 0.5,0.5)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_410008")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:ほら、見て<br>――雪
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_410009")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight(Actor001, 0.8, 0.1, 0.4, 0.2,0.5)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.5)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
wait_time(3.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…あぁ<br>――綺麗だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_410011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115076)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
