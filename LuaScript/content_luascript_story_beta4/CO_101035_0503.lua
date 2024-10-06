-- このluaスクリプトは、CO_101035_0503.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor002 = InitializeCharacter_2DOnly("101035","001","101035001")
	Actor003 = InitializeCharacter_2DOnly("101025","001","101025001")
	Actor004 = InitializeCharacter_2DOnly("101012","001","101012001")
	template1()

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "納得")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ディナタン★★:ここがリリアーナの畑ね/確かにすごく手入れが行き届いてる！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","CO_101035_05030002")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:そうね/…でも、見て
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05030003")


	--★★クレア★★:あの隅のほう、なんだか様子がおかしいわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05030004")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:畑が踏み荒らされてる…！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05030005")

-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:動物が入り込んだわけではないようね/この荒らしかたは人間の手によるものだわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05030006")

	change_face(Actor003,"Anger")

	--★★クレア★★:どうして…/この辺りは滅多に人が来ないのに…
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_05030007")


	--★★リリアーナ★★:まさか…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05030008")


	--★★ノワール★★:どうした、リリアーナ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05030009")

	change_face(Actor002,"Sad")

	--★★リリアーナ★★:い、いえ、なんでもありません…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05030010")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ5_4")
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
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_2DOnly_Preload("101035","001","101035001")
	InitializeCharacter_2DOnly_Preload("101025","001","101025001")
	InitializeCharacter_2DOnly_Preload("101012","001","101012001")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
