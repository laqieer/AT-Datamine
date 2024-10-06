-- このluaスクリプトは、MA_01104_105.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",-71.3,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	Camera003 = SetTemplate("Actor003",178.2,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Angry")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Sad02")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_1050002")


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_1050003")

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
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
