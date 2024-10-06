-- このluaスクリプトは、DW_04_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_04_0060001")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_04_0060002")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_04_0060003")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_04_0060004")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_04_0060005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0060006")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_04_0060007")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_04_0060008")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end
