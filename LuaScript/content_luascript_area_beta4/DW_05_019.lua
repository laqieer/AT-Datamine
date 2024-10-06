-- このluaスクリプトは、DW_05_019.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190001")

	change_face(Actor001,"Anger")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0190002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0190003")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0190005")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190006")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190007")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190008")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0190009")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0190011")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190012")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190013")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0190014")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190015")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190016")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_05_0190017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0190018")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end
