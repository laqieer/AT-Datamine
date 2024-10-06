-- このluaスクリプトは、MA_01C900_44.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
stillAnime2 = load_ui_effect("content_still_10104012_anim", "10104012_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10104013_anim", "10104013_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
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
stillAnime2.SetActive(true)
hide_image(0)
fadein(0.5)
local signal = play_ui_timeline_controller_in(stillAnime2)
while signal.IsProccessing() do
coroutine.yield()
	end
wait_time(0.5)
-- ▲直接出力

	--★★telop★★:あなたは忘れてしまう
	Talk(Actor001,"","simple","N","MA_01C900_390016")

-- ▼直接出力
 -- ▼直接出力
CloseTalkWindow()
signal = play_ui_timeline_controller_out(stillAnime2, true)
while signal.IsProccessing() do
coroutine.yield()
	end
	fadeout(0, 0, 0, 1, 0)
	stillAnime2.SetActive(false)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力

stillAnime.SetActive(true)
fadein(0.5)
local signal = play_ui_timeline_controller_in(stillAnime)
while signal.IsProccessing() do
coroutine.yield()
	end
wait_time(0.5)
-- ▲直接出力

	--★★telop★★:でも世界はずっと覚えている
	Talk(Actor001,"","simple","N","MA_01C900_390017")

-- ▼直接出力
 -- ▼直接出力
CloseTalkWindow()
signal = play_ui_timeline_controller_out(stillAnime, true)
while signal.IsProccessing() do
coroutine.yield()
	end
-- ▲直接出力
-- ▼直接出力
 reserve_next_script("1章/メイン/エピローグ_マルディサント2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_ui_effect_preload("content_still_10104012_anim", "10104012_StillAnim", nil, nil, nil, "Root")
load_ui_effect_preload("content_still_10104013_anim", "10104013_StillAnim", nil, nil, nil, "Root")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
