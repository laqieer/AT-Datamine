-- このluaスクリプトは、MA_00100_14.csvから自動生成されました --
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


	--★★アルハン？★★:見下すな、仰ぎ見ろ<br>ワタシに耳をかたむけよ
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_00100_140002")


	--★★アルハン？★★:まもなく世界は終わり<br>歴史は幕を閉じる
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_00100_140004")


	--★★アルハン？★★:バルバロイが洪水のごとく<br>空の<ruby=けが>穢</ruby>れが嵐のごとく、万物を呑み込む
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_00100_140006")


	--★★アルハン？★★:学び舎で研がれし武器たちでは<ruby=もろ>脆</ruby>く<br>その波は防げまい
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_00100_140008")

-- ▼直接出力
 --CloseTalkWindow()
--wait_time(1.0)
-- ▲直接出力

	--★★アルハン？★★:だが、ひとつだけ
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_00100_140010")

-- ▼直接出力
 --CloseTalkWindow()
--wait_time(1.0)
-- ▲直接出力

	--★★アルハン？★★:…たったひとつだけ<br>救いの道があるとすれば
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_00100_140012")

-- ▼直接出力
 CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
