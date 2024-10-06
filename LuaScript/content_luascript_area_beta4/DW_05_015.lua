-- このluaスクリプトは、DW_05_015.csvから自動生成されました --
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
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_05_0150001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0150002")

-- ▼直接出力
PlayPartVoice("ティルフィング", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_05_0150003")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_05_0150004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0150005")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_05_0150006")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_05_0150007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0150008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0150009")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_05_0150010")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_05_0150011")


	--★★ティルフィング★★:
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","DW_05_0150012")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0150013")

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
