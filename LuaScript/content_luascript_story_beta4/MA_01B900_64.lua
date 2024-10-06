Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")

function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)	-- 黒背景
	template1()

	ED_Anime = load_ui_effect("content_still_10102015_anim", "10102015_StillAnim", nil, nil, nil, "Root")

	--ボタン制御
	ShowGlobalMenuButton(false)
	--黒帯非表示
	disableTextBox = true

end

function Play()
--	StartPlay()
	fadein(0)
	Play_start(true, false)

	--エピローグデモ

	ED_Anime.SetActive(true)
	hide_image(0)
	fadein(0.5)

	local signal = play_ui_timeline_controller_in(ED_Anime)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	wait_time(3.0)

	signal = play_ui_timeline_controller_out(ED_Anime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	fadeout(0, 0, 0, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)

	ED_Anime.SetActive(false)
	wait_time(STILL_SWITCH_TIME)

--	EndPlay()
	Play_end(true)
	--黒帯表示念のため
	disableTextBox = false

end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	load_ui_effect_preload("content_still_10102015_anim", "10102015_StillAnim", nil, nil, nil, "Root")
	disableTextBox = true
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
