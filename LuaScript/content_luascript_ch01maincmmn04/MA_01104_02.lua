-- このluaスクリプトは、MA_01104_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 101
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
SetOffset(Actor003,-0.03,-0.085,0.085)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 101
-- ▲直接出力
end

function Play()
	StartPlay()

-- ▼直接出力
se_play("SE_ADV_MA_01C110_42_Crowd")
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:（………同じくらいの年の人が、沢山）
	Talk(Actor001,"CHRNAME_DINATAN","mind","L","MA_01104_020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:（私たち………戦ってたんだ）
	Talk(Actor001,"CHRNAME_DINATAN","mind","L","MA_01104_020003")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 101
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
