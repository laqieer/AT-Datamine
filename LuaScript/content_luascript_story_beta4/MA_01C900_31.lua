-- このluaスクリプトは、MA_01C900_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
movie_load("MA_01C900_31")
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10104010_anim", "10104010_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Geshturtshift_adoption")
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_2DOnly("101012","001","101012001")
	Actor002 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:ブリテン島　６世紀　８月
	Talk(Actor002,"","simple","N","MA_01C900_310002")

-- ▼直接出力
CloseTalkWindow()
movie_set_active(true)
movie_play()
movie_wait_playing()
movie_stop()
fadeout(255,255,255, 1, 0.5)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
close_textbox_base()
stillAnime.SetActive(true)
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + 0.5)
    local signal = play_ui_timeline_controller_in(stillAnime)
    while signal.IsProccessing() do
    coroutine.yield()
end
open_textbox_base()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★ディナタン★★:はじめてくれた<br>えらんでくれた
	Talk(Actor001,"CHRNAME_DINATAN","simple","L","MA_01C900_310013")


	--★★ディナタン★★:ほんとうに、ありがとう
	Talk(Actor001,"CHRNAME_DINATAN","simple","L","MA_01C900_310015")

-- ▼直接出力
CloseTalkWindow()
signal = play_ui_timeline_controller_out(stillAnime, false)
    while signal.IsProccessing() do
    coroutine.yield()
end
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
movie_load_preload("MA_01C900_31")
load_ui_effect_preload("content_still_10104010_anim", "10104010_StillAnim", nil, nil, nil, "Root")
preload_sound("BGM_ADV_Geshturtshift_adoption")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_2DOnly_Preload("101012","001","101012001")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
