-- このluaスクリプトは、DW_04_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_04_0210001")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0210002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0210003")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_04_0210004")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_04_0210005")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_04_0210006")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_04_0210007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0210008")

-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_04_0210009")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end
