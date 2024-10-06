-- このluaスクリプトは、DW_01C_11_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_11_0070001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0070002")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_11_0070003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0070004")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_11_0070005")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_11_0070006")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_11_0070007")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0070008")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_11_0070009")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_01C_11_0070010")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01C_11_0070011")

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
