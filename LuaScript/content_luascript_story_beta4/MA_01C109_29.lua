-- このluaスクリプトは、MA_01C109_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
force_eyesync(Actor001,"Close")
reserve_eyesync(Actor001,"Close")
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10130005)
-- ▲直接出力
-- ▼直接出力
set_pos(prop001 , {0,0.46,-8.47})
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C109_29_Amb_Screaming")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_2DOnly("101020","001","101020001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(3.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★マーリン★★:──アーサー
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01C109_290002")

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130005)
	InitializeLoad_Preload()
	load_area_scene_preload(115104)
	InitializeCharacter_2DOnly_Preload("101020","001","101020001")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
end
