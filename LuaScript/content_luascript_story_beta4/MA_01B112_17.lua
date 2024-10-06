-- このluaスクリプトは、MA_01B112_17.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos116102_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_511_01_StdController","to Std_Loop",CameraAssetBundleName116102_01,CameraPos116102_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos116102_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleName116102_01,CameraPos116102_01_003)
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_3D("101067","001","101067001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101021","001","101021001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
-- ▲直接出力

	--★★ニニアン★★:聖杯の解放を望む者は…<br>『サラスの都』に足を踏み入れる必要がある
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B112_170002")


	--★★ニニアン★★:サラスの都への門は固く閉ざされている<br>開くために鍵となるもの、それが──
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B112_170003")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ブルーノ★★:妖精の命
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B112_170005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ニニアン★★:ブルーノ、貴方の剣で<br>この妖精ニニアンの命を天へと捧げ──
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B112_170006")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_3D_Preload("101067","001","101067001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101021","001","101021001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
