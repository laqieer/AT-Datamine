-- このluaスクリプトは、MA_01A900_55.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10103014_anim", "10103014_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
	stillAnime.SetActive(true)
hide_image(0)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(0, 0, 0, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
stillAnime.SetActive(false)
wait_time(STILL_SWITCH_TIME)
fadein(0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_ui_effect_preload("content_still_10103014_anim", "10103014_StillAnim", nil, nil, nil, "Root")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
