-- このluaスクリプトは、DW_08_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0120001")

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_08_0120002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0120003")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_08_0120004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0120005")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_08_0120006")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_08_0120007")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_08_0120008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0120009")

	change_face(Actor002,"Anger")

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_08_0120010")

	change_face(Actor001,"Serious")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0120011")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_08_0120012")

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
