-- このluaスクリプトは、DW_01B_10_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0060001")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_10_0060002")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力

	--★★パーシヴァル★★:
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","DW_01B_10_0060003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0060004")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_10_0060005")


	--★★パーシヴァル★★:
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","DW_01B_10_0060006")

	change_face(Actor003,"Serious")

	--★★パーシヴァル★★:
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","DW_01B_10_0060007")

-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_10_0060008")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_10_0060009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0060010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0060011")


	--★★パーシヴァル★★:
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","DW_01B_10_0060012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0060013")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_10_0060014")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","DW_01B_10_0060015")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_10_0060016")


	--★★パーシヴァル★★:
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","DW_01B_10_0060017")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
end