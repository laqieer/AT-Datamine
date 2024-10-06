-- このluaスクリプトは、DW_01B_01_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01B_01_0040001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0040002")


	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01B_01_0040003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0040004")

	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01B_01_0040005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0040006")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力

	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01B_01_0040007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0040008")

-- ▼直接出力
PlayPartVoice("リリアーナ", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01B_01_0040009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0040010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end
