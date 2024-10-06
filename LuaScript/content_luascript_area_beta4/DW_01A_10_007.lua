-- このluaスクリプトは、DW_01A_10_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_10_0070001")


	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0070003")


	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0070005")


	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070006")


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_10_0070007")

	change_face(Actor003,"Sad")

	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070008")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_10_0070009")

	change_face(Actor003,"Normal")

	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070010")


	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0070012")


	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070013")


	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070014")


	--★★ケイ★★:
	Talk(Actor003,"CHRNAME_KAY","speech","L","DW_01A_10_0070015")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_10_0070016")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end
