-- このluaスクリプトは、MA_01105_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_02","113011_02_h")
Include("content_adv_advsmall_113011_02","Template113011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera113011_02()
	InitializeTemplate113011_02()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10101003_anim", "10101003_StillAnim", nil, nil, nil, "Root")


-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Recollection")
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:『どうか、リッチな夢だけでも』
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","N","MA_01105_220002")

-- ▼直接出力
CloseTalkWindow()
fadeout(255, 255, 255, 0, STILL_SWITCH_TIME )
	wait_time(STILL_SWITCH_TIME)
	stillAnime.SetActive(true)
hide_image(0)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Recollection")
-- ▲直接出力

	--★★レオデグランス王★★:＊＊＊＊＊＊＊＊＊＊＊＊…<br>「＊＊＊＊＊＊＊＊えました」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_230002")


	--★★レオデグランス王★★:「そういっ＊夢を持てる時点で<br>＊ミは十分にリッチだ」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_230003")


	--★★レオデグランス王★★:「キミが貧しい気持ちでいるのは<br>それに気づかないままだからだ」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_230004")


	--★★レオデグランス王★★:「異国のコインを磨いて＊＊＊<br>＊＊＊＊＊──…」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_230005")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
	CloseTalkWindow()
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(255, 255, 255, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
close_textbox_base()
disableTextBox = true
stillAnime.SetActive(false)
wait_time(STILL_SWITCH_TIME)
fadein(0)
disableTextBox = false
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_ui_effect_preload("content_still_10101003_anim", "10101003_StillAnim", nil, nil, nil, "Root")
preload_sound("BGM_ADV_Recollection")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	system.PreLoadRequest(CameraAssetBundleName113011_02)
end
