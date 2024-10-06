-- このluaスクリプトは、EA_007_044.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:不運なことに
	Talk(Actor001,"","simple","N","EA_007_0440005")


	--★★テロップ★★:目的地には無事ついたものの<br>『天使の贈り物』は枯れ果てていた
	Talk(Actor001,"","simple","N","EA_007_0440006")


	--★★テロップ★★:
	Talk(Actor001,"","simple","N","EA_007_0440007")


	--★★テロップ★★:魔女との決戦が迫り<br>それ以降、カイルの外出は禁じられた
	Talk(Actor001,"","simple","N","EA_007_0440008")


	--★★テロップ★★:
	Talk(Actor001,"","simple","N","EA_007_0440009")


	--★★テロップ★★:カイルがさらわれた
	Talk(Actor001,"","simple","N","EA_007_0440010")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★テロップ★★:敵は、誘拐したカイルを交渉材料に<br>ご両親の持つ商売の販路を掌握
	Talk(Actor001,"","simple","N","EA_007_0440012")


	--★★テロップ★★:ローマ残党軍に兵糧や武器を行き渡らせ<br>疲弊したログレスを狙わんとしていた
	Talk(Actor001,"","simple","N","EA_007_0440013")


	--★★テロップ★★:その不幸までは<br>視えなかったらしい
	Talk(Actor001,"","simple","N","EA_007_0440014")

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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
end
