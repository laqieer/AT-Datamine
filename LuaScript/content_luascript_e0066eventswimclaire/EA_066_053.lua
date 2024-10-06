-- このluaスクリプトは、EA_066_053.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
-- ▼直接出力
load_sound("BGM_Battle_Running")
load_image("201010860", "content_still_20101086_image", "201010860_StillImage") -- イベントスチル
load_image("101010140", "content_still_10101014_image", "101010140_StillImage") -- 黒背景
load_image("101010150", "content_still_10101015_image", "101010150_StillImage") -- 白背景
DontChangeRandomCamera(true)
on_camera(RndCamera001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_2DOnly("101024","002","101024002")
	Actor003 = InitializeCharacter_2DOnly("101025","001","101025001")
	Actor004 = InitializeCharacter_2DOnly("101025","002","101025002")
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:「覚悟を決めよ<br>その覚悟こそが可能性を広げる劒となる」
	Talk(Actor001,"","narration","N","EA_066_0530002")


	--★★テロップ★★:「己が心の内にある鞘から劔を抜くとき<br>その覚悟は山をも砕くだろう」
	Talk(Actor001,"","narration","N","EA_066_0530003")


	--★★テロップ★★:「あらゆる覚悟は尊ばれ<br>何人もこれを侵すことは許されない」
	Talk(Actor001,"","narration","N","EA_066_0530004")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0046")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0530005")


	--★★ヴォールス★★:あいつらは、とっくに覚悟を決めていたんだ<br>大切なものを、守るために――
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0530006")

-- ▼直接出力
EndTalk()
show_image("101010140", 0, 0, 1.0, false, false)
set_scale_image(20,20)
wait_time(1.0)
-- ▲直接出力

	--★★ヴォールス★★:………力とは――
	Talk(Actor002,"CHRNAME_BORS","simple","N","EA_066_0530007")

-- ▼直接出力
voice_play("VO_101025_sp_0002_1")
-- ▲直接出力

	--★★クレア★★:それより――ちゃんと見て。前を――<br>………『今』を
	Talk(Actor003,"CHRNAME_CLARE2","simple","N","EA_066_0530010")

-- ▼直接出力
EndTalk()
se_play("SE_ADV_MA_Urery_Emy501_Roar")
wait_time(2.0)
se_play("SE_ADV_MA_01104_25_Earthquake")
show_image("201010860", 0, 0, 0, true, false)
scale_to_image(1.5, 1.5, 0.2, EaseIn)
wait_time(0.2)
scale_to_image(1.0, 1.0, 0.5, EaseOut)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101025_sp_0002_2")
-- ▲直接出力

	--★★クレア2★★:
	Talk(Actor004,"CHRNAME_CLARE2","simple","N","EA_066_0530021")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0037")
-- ▲直接出力

	--★★ヴォールス★★:すまん、クレア<br>情けないところを見せたな
	Talk(Actor002,"CHRNAME_BORS","simple","N","EA_066_0530022")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","simple","N","EA_066_0530023")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0039")
-- ▲直接出力

	--★★ヴォールス★★:円卓の騎士の誇りにかけて
	Talk(Actor002,"CHRNAME_BORS","simple","N","EA_066_0530024")

-- ▼直接出力
EndTalk()
PlayPartVoiceDirect("ヴォールス_002","0035")
fadeout(1,1,1,1,0.1)
wait_time(0.1)
fadein(1.0)
wait_time(2.0)
PlayPartVoiceDirect("クレア","0029")
-- ▲直接出力

	--★★クレア2★★:キラーズ因子を武器に流し込んで<br>力に変えているの…？そんなの、いつ――
	Talk(Actor004,"CHRNAME_CLARE2","simple","N","EA_066_0530025")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0013")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","simple","N","EA_066_0530026")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力

	--★★クレア2★★:…！
	Talk(Actor004,"CHRNAME_CLARE2","simple","N","EA_066_0530027")

-- ▼直接出力
bgm_play("BGM_Battle_Running")
-- ▲直接出力

	--★★ヴォールス★★:力を示すぞ、守護者とやら<br>この力で、俺は仲間を守り抜く――
	Talk(Actor002,"CHRNAME_BORS","simple","N","EA_066_0530028")

-- ▼直接出力
voice_play("VO_101024_sp_0002_2")
-- ▲直接出力

	--★★ヴォールス★★:俺は、もう二度と諦めない
	Talk(Actor002,"CHRNAME_BORS","simple","N","EA_066_0530029")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Battle_Running")
load_image_preload("201010860", "content_still_20101086_image", "201010860_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_2DOnly_Preload("101024","002","101024002")
	InitializeCharacter_2DOnly_Preload("101025","001","101025001")
	InitializeCharacter_2DOnly_Preload("101025","002","101025002")
	system.PreLoadRequest(CameraAssetBundleName116101_01)
end
