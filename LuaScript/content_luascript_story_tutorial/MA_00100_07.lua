-- このluaスクリプトは、MA_00100_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
ShowGlobalMenuButton(false)
-- ▲直接出力
-- ▼直接出力
load_image("101050080", "content_still_10105008_image", "101050080_StillImage")
load_image("101050090", "content_still_10105009_image", "101050090_StillImage")
load_image("101050100", "content_still_10105010_image", "101050100_StillImage")
load_image("101050110", "content_still_10105011_image", "101050110_StillImage")
load_image("101050120", "content_still_10105012_image", "101050120_StillImage")
load_image("101050130", "content_still_10105013_image", "101050130_StillImage")
load_image("101050140", "content_still_10105014_image", "101050140_StillImage")
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


	--★★テロップ★★:ひとつも失くしたくないのに<br>ひとつしか残せないのなら
	Talk(Actor001,"","narration","L","MA_00100_060002")


	--★★テロップ★★:選ぶことしか出来ないのか？
	Talk(Actor001,"","narration","L","MA_00100_060004")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
local CH_ST = 1.0
local CH_STH = CH_ST / 2
local ACTIVT = 0.2
local AFTIME = 1.0
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, 0.5)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
show_image("101050080", 0.0, 0.0, 0.0 ,false,false)
fadein(CH_ST)
wait_time(CH_STH)
local voiceSignalS = voice_play("VO_story00_0014")
wait_time(CH_STH)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(ACTIVT)
fadeout(0,0,0,1.0,CH_ST)
wait_time(CH_ST + AFTIME)
-- ▲直接出力
-- ▼直接出力
show_image("101050090", 0.0, 0.0, 0.0 ,false,false)
fadein(CH_ST)
wait_time(CH_STH)
voiceSignalS = voice_play("VO_story00_0015")
wait_time(CH_STH)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(ACTIVT)
fadeout(0,0,0,1.0,CH_ST)
wait_time(CH_ST + AFTIME)
-- ▲直接出力
-- ▼直接出力
show_image("101050100", 0.0, 0.0, 0.0 ,false,false)
fadein(CH_ST)
wait_time(CH_STH)
voiceSignalS = voice_play("VO_story00_0016")
wait_time(CH_STH)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(ACTIVT)
fadeout(0,0,0,1.0,CH_ST)
wait_time(CH_ST + AFTIME)
-- ▲直接出力
-- ▼直接出力
show_image("101050110", 0.0, 0.0, 0.0 ,false,false)
fadein(CH_ST)
wait_time(CH_STH)
voiceSignalS = voice_play("VO_story00_0017")
wait_time(CH_STH)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(ACTIVT)
fadeout(0,0,0,1.0,CH_ST)
wait_time(CH_ST + AFTIME)
-- ▲直接出力
-- ▼直接出力
show_image("101050120", 0.0, 0.0, 0.0 ,false,false)
fadein(CH_ST)
wait_time(CH_STH)
voiceSignalS = voice_play("VO_story00_0018")
wait_time(CH_STH)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(ACTIVT)
fadeout(0,0,0,1.0,CH_ST)
wait_time(CH_ST + AFTIME)
-- ▲直接出力
-- ▼直接出力
show_image("101050130", 0.0, 0.0, 0.0 ,false,false)
fadein(CH_ST)
wait_time(CH_STH)
voiceSignalS = voice_play("VO_story00_0019")
wait_time(CH_STH)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(ACTIVT)
fadeout(0,0,0,1.0,CH_ST)
wait_time(CH_ST + AFTIME)
-- ▲直接出力
-- ▼直接出力
show_image("101050140", 0.0, 0.0, 0.0 ,false,false)
fadein(CH_ST)
wait_time(CH_STH)
voiceSignalS = voice_play("VO_story00_0020")
wait_time(CH_STH)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(ACTIVT)
fadeout(0,0,0,1.0,CH_ST)
wait_time(CH_ST + AFTIME)
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
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
