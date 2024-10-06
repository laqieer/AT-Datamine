-- このluaスクリプトは、DW_01A_12_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_12_0140001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0140002")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_12_0140003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0140004")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_12_0140005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0140006")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_12_0140007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0140008")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_12_0140009")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
end
