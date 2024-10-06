-- このluaスクリプトは、DW_01C_09_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_09_0010001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0010002")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_09_0010003")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_09_0010004")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_09_0010005")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_09_0010006")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_09_0010007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0010008")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_09_0010009")

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
end
