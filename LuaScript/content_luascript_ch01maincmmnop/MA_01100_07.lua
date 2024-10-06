-- このluaスクリプトは、MA_01100_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
-- ▼直接出力
ShowGlobalMenuButton(false)
-- ▲直接出力
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010270", "content_still_10101027_image", "101010270_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_2DOnly("101009","005","101009005")
	Actor002 = InitializeCharacter_2DOnly("101012","004","101012004")
	Actor003 = InitializeCharacter_2DOnly("101060","001","101060001")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
fadeout(255,255,255,1,0.2)
wait_time(0.2)
show_image("101010270", 0.0, 0.0, 0,true,true)
fadein(IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
-- ▲直接出力

	--★★セレスティ★★:──置き去りにしちゃうね
	Talk(Actor003,"NPCNAME_0163","simple","L","MA_01100_070002")


	--★★ディナタン★★:母さん、いやだよ、死なないで──…
	Talk(Actor002,"CHRNAME_DINATAN","simple","L","MA_01100_070003")

-- ▼直接出力
reserve_eyesync(Actor003,"Close")
-- ▲直接出力

	--★★セレスティ★★:だけど忘れないで<br>父さんが全部遺してくれたから
	Talk(Actor003,"NPCNAME_0163","simple","L","MA_01100_070004")


	--★★セレスティ★★:抗うすべも、選び抜く道も、その先の平和も
	Talk(Actor003,"NPCNAME_0163","simple","L","MA_01100_070006")


	--★★ノワール★★:…なに、言ってるんだよ…！？<br>だって父さんは──
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01100_070007")

-- ▼直接出力
reserve_eyesync(Actor003,"Auto")
-- ▲直接出力

	--★★セレスティ★★:ディナタンを守って
	Talk(Actor003,"NPCNAME_0163","simple","L","MA_01100_070008")

-- ▼直接出力
CloseTalkWindow() 
fadeout(0,0,0,1,BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
 --黒背景に移行
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
fadein(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力

	--★★セレスティ★★:貴方の武器を、見つけて
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01100_070010")

-- ▼直接出力
CloseTalkWindow() 
wait_time(WAIT_TIME_NORMAL)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★ティルフィング★★:劔をご用命ですか？
	Talk(Actor004,"CHRNAME_NAMELES","narration","N","MA_01100_070012")

-- ▼直接出力
SetTrackingId(59)
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
load_image_preload("101010270", "content_still_10101027_image", "101010270_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_2DOnly_Preload("101009","005","101009005")
	InitializeCharacter_2DOnly_Preload("101012","004","101012004")
	InitializeCharacter_2DOnly_Preload("101060","001","101060001")
	system.PreLoadRequest(CameraAssetBundleName116101_01)
end
