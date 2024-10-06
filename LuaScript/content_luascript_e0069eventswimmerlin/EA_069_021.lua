-- このluaスクリプトは、EA_069_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_01","113011_01_h")
Include("content_adv_advsmall_113011_01","Template113011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName113011_01,CameraPos113011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName113011_01,CameraPos113011_01_001)
	InitializeTemplateRandomCamera113011_01()
	InitializeTemplate113011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0056")
-- ▲直接出力

	--★★ギネマウア★★:それじゃあ、少し出かけてくるから
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0210003")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0210004")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネマウア★★:ここのマーケットには<br>素敵なお店がたくさんあるそうよ
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0210005")


	--★★ギネヴィア★★:………
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0210006")

-- ▼直接出力
voice_play("VO_101016_sp_0003_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:…ギネヴィア
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0210007")


	--★★ギネヴィア★★:………いってらっしゃい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0210008")

	change_face(Actor001,"Normal")

	--★★ギネマウア★★:…いってきます
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0210009")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName113011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
