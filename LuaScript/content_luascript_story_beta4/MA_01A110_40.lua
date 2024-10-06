-- このluaスクリプトは、MA_01A110_40.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115070)
	Actor001 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()


	--★★エレイン★★:（………諦めても、諦めきれないモノ）
	Talk(Actor001,"CHRNAME_ELAINE","mind","L","MA_01A110_400002")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115070)
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor001")
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
