-- このluaスクリプトは、MA_01C110_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111061_01","111061_01_h")
Include("content_adv_advsmall_111061_01","Template111061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",140,CharaPos111061_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_511_01_StdController","to Std_Loop",CameraAssetBundleName111061_01,CameraPos111061_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleName111061_01,CameraPos111061_01_003)
	InitializeTemplateRandomCamera111061_01()
	InitializeTemplate111061_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera004
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111061)
	Actor001 = InitializeCharacter_3D("101067","001","101067001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101021","001","101021001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101009","001","101009001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:…！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01C110_100002")

	change_face(Actor001,"Pain")

	--★★ニニアン★★:どうか――お願い
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01C110_100003")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera004
	InitializeLoad_Preload()
	load_area_scene_preload(111061)
	InitializeCharacter_3D_Preload("101067","001","101067001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101021","001","101021001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	system.PreLoadRequest(CameraAssetBundleName111061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
