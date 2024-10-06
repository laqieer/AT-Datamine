-- このluaスクリプトは、DW_01B_11_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070001")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070002")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070003")

-- ▼直接出力
PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガラハッド★★:
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DW_01B_11_0070004")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070005")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0070006")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070007")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070008")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070009")


	--★★ガラハッド★★:
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DW_01B_11_0070010")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070011")

	change_face(Actor003,"Sad")

	--★★ガラハッド★★:
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DW_01B_11_0070012")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070013")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01B_11_0070014")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01B_11_0070015")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end
