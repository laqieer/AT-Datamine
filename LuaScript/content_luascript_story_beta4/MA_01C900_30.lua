-- このluaスクリプトは、MA_01C900_30.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
-- ▼直接出力
disableTextBox = true
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
movie_load("MA_01C900_30")
movie_set_active(true)
movie_play()
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
movie_wait_playing()
fadeout(0,0,0,1.0,0)
movie_stop()
disableTextBox = false
open_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
fadein(0.5)
wait_time(1.0)
-- ▲直接出力

	--★★???★★:憶えたそばから<br>忘れていくとしても
	Talk(Actor001,"CHRNAME_NAMELES","simple","N","MA_01C900_300035")


	--★★???★★:傷痕なら<br>遺せるだろうか
	Talk(Actor001,"CHRNAME_NAMELES","simple","N","MA_01C900_300036")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
movie_load_preload("MA_01C900_30")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
