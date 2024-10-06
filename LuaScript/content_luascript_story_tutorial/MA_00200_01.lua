-- このluaスクリプトは、MA_00200_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
disableTextBox = true
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
ShowGlobalMenuButton(false)
load_image("101050080", "content_still_10105008_image", "101050080_StillImage")
load_image("101050090", "content_still_10105009_image", "101050090_StillImage")
load_image("101050100", "content_still_10105010_image", "101050100_StillImage")
load_image("101050110", "content_still_10105011_image", "101050110_StillImage")
load_image("101050120", "content_still_10105012_image", "101050120_StillImage")
load_image("101050130", "content_still_10105013_image", "101050130_StillImage")
load_image("101050140", "content_still_10105014_image", "101050140_StillImage")
load_image("101050060", "content_still_10105006_image", "101050060_StillImage")
load_image("101050070", "content_still_10105007_image", "101050070_StillImage")
-- ▲直接出力
-- ▼直接出力
movie_load("MA_00100_01")
movie_set_active(true)
movie_play()
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Question")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
SetTrackingId(4)
SetTrackingId(12)
SetTrackingId(13)
movie_wait_playing()
movie_stop()
SetTrackingId(14)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
movie_load("MA_00100_08")
movie_set_active(true)
movie_play()
movie_wait_playing()
movie_stop()
SetTrackingId(15)
-- ▲直接出力
-- ▼直接出力
 --念のため会話窓の黒帯表示
disableTextBox = false
open_textbox_base()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101050080", "content_still_10105008_image", "101050080_StillImage")
load_image_preload("101050090", "content_still_10105009_image", "101050090_StillImage")
load_image_preload("101050100", "content_still_10105010_image", "101050100_StillImage")
load_image_preload("101050110", "content_still_10105011_image", "101050110_StillImage")
load_image_preload("101050120", "content_still_10105012_image", "101050120_StillImage")
load_image_preload("101050130", "content_still_10105013_image", "101050130_StillImage")
load_image_preload("101050140", "content_still_10105014_image", "101050140_StillImage")
load_image_preload("101050060", "content_still_10105006_image", "101050060_StillImage")
load_image_preload("101050070", "content_still_10105007_image", "101050070_StillImage")
movie_load_preload("MA_00100_01")
preload_sound("BGM_ADV_Question")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
