-- このluaスクリプトは、MS_002_042.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
-- ▼直接出力
load_image("201010770", "content_still_20101077_image", "201010770_StillImage")
load_image("201010771", "content_still_20101077_image", "201010771_StillImage")
load_image("201010772", "content_still_20101077_image", "201010772_StillImage")
load_image("201010780", "content_still_20101078_image", "201010780_StillImage")
load_image("201010781", "content_still_20101078_image", "201010781_StillImage")
load_image("201010782", "content_still_20101078_image", "201010782_StillImage")
local assetbundleName
local fileName
heroId = GetPlayerStyleId()
if heroId == 101003001 then
    stillId = "201010770"
    assetbundleName = "content_still_20101077_image"
    fileName = "201010770_StillImage"
elseif heroId == 101005001 then
    stillId = "201010771"
    assetbundleName = "content_still_20101077_image"
    fileName = "201010771_StillImage"
elseif heroId == 101007001 then
    stillId = "201010772"
    assetbundleName = "content_still_20101077_image"
    fileName = "201010772_StillImage"
elseif heroId == 101004001 then
    stillId = "201010780"
    assetbundleName = "content_still_20101078_image"
    fileName = "201010780_StillImage"
elseif heroId == 101006001 then
    stillId = "201010781"
    assetbundleName = "content_still_20101078_image"
    fileName = "201010781_StillImage"
else
    stillId = "201010782"
    assetbundleName = "content_still_20101078_image"
    fileName = "201010782_StillImage"
end
load_image(stillId, assetbundleName, fileName)
-- ▲直接出力
-- ▼直接出力
load_image("201010740", "content_still_20101074_image", "201010740_StillImage")
load_image("201010750", "content_still_20101075_image", "201010750_StillImage")
load_image("201010760", "content_still_20101076_image", "201010760_StillImage")
load_image("201010150", "content_still_20101015_image", "201010150_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010150", 0.0, 0.0,0 ,true,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_2DOnly("101070","001","101070001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.0)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_cameraframe()
off_screencolor()
wait_time(0.3)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.8)
-- ▲直接出力

	--★★フライクーゲル★★:みんな、わたしを避けてた
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420002")


	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0421001")


	--★★フライクーゲル★★:わたしのキラーズ『フライクーゲル』は<br>撃てば当たる悪魔的な力を持ってて
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420003")


	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420004")


	--★★フライクーゲル★★:何人死んでも…隊が壊滅しても<br>わたしだけが危なげなく、いつも生き残る
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420005")


	--★★フライクーゲル★★:中にはわたしが殺してるんじゃないかって<br>噂する人だっていた
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420006")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(0.8)
hide_image(STILL_SWITCH_TIME)
wait_time(0.1)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(1.0)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★フライクーゲル★★:いつからか、わたしは<br>人を殺す『悪魔』だとか言われて
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420007")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(0.3)
hide_image(STILL_SWITCH_TIME)
wait_time(0.1)
show_image("201010740", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★フライクーゲル★★:きみと、隣の席になった
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420010")


	--★★フライクーゲル★★:お互いひとりで<br>ごはんを食べてた
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420011")


	--★★フライクーゲル★★:きみは転校してきたばかりで<br>まだ友達がいなかったから
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420012")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(0.3)
hide_image(STILL_SWITCH_TIME)
wait_time(0.1)
show_image("201010760", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★フライクーゲル★★:あるとき、きみが話しかけてくれた<br>わたしはうまく受け答えができなかった
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420013")


	--★★フライクーゲル★★:「そばにいてごめんね」とか<br>オーバーに、笑ってみせた
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420014")


	--★★フライクーゲル★★:『悪魔』のわたしがそばにいるせいで<br>きみに友達ができないのかも、とか思って
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420015")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(0.3)
hide_image(STILL_SWITCH_TIME)
wait_time(0.1)
show_image("201010750", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★フライクーゲル★★:…でも、きみは<br>「こんな悪魔は、はじめてだ」と言った
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420016")


	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420017")


	--★★フライクーゲル★★:「クラスメートが少しでも<br>自由でいられるように戦い続けている」
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420018")


	--★★フライクーゲル★★:あのときのわたしはただ<br>友達の作りかたがわからなかったから
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420019")


	--★★フライクーゲル★★:役割を果たせば誰かが認めてくれると<br>ただそう思っていただけなのに
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420020")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(0.3)
hide_image(STILL_SWITCH_TIME)
wait_time(0.1)
show_image(stillId, 0.0, 0.0, 0.8,true,false)
wait_time(0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★フライクーゲル★★:「こんなに優しい悪魔はいない」と
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420021")


	--★★フライクーゲル★★:「『はじめての友達』になってほしい」<br>そう言われた
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420022")


	--★★フライクーゲル★★:わたしは<br>きみを『友達』と呼んでいいか迷った
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420023")


	--★★フライクーゲル★★:きみはオーバーに言った
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420024")


	--★★フライクーゲル★★:「どう呼ぶかはきみの自由だ」と<br>「きみの人生はきみだけのものだから」と
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420025")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(0.8)
hide_image(STILL_SWITCH_TIME)
wait_time(0.1)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(1.0)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★フライクーゲル★★:だから、わたしはオーバーに<br>きみをこう呼ぶことにした
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0420026")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010770", "content_still_20101077_image", "201010770_StillImage")
load_image_preload("201010771", "content_still_20101077_image", "201010771_StillImage")
load_image_preload("201010772", "content_still_20101077_image", "201010772_StillImage")
load_image_preload("201010780", "content_still_20101078_image", "201010780_StillImage")
load_image_preload("201010781", "content_still_20101078_image", "201010781_StillImage")
load_image_preload("201010782", "content_still_20101078_image", "201010782_StillImage")
local assetbundleName
local fileName
heroId = GetPlayerStyleId()
if heroId == 101003001 then
    stillId = "201010770"
    assetbundleName = "content_still_20101077_image"
    fileName = "201010770_StillImage"
elseif heroId == 101005001 then
    stillId = "201010771"
    assetbundleName = "content_still_20101077_image"
    fileName = "201010771_StillImage"
elseif heroId == 101007001 then
    stillId = "201010772"
    assetbundleName = "content_still_20101077_image"
    fileName = "201010772_StillImage"
elseif heroId == 101004001 then
    stillId = "201010780"
    assetbundleName = "content_still_20101078_image"
    fileName = "201010780_StillImage"
elseif heroId == 101006001 then
    stillId = "201010781"
    assetbundleName = "content_still_20101078_image"
    fileName = "201010781_StillImage"
else
    stillId = "201010782"
    assetbundleName = "content_still_20101078_image"
    fileName = "201010782_StillImage"
end
load_image_preload(stillId, assetbundleName, fileName)
load_image_preload("201010740", "content_still_20101074_image", "201010740_StillImage")
load_image_preload("201010750", "content_still_20101075_image", "201010750_StillImage")
load_image_preload("201010760", "content_still_20101076_image", "201010760_StillImage")
load_image_preload("201010150", "content_still_20101015_image", "201010150_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_2DOnly_Preload("101070","001","101070001")
	system.PreLoadRequest(CameraAssetBundleName116101_01)
end
