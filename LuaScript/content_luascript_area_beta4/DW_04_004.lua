-- このluaスクリプトは、DW_04_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0040001")


	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_04_0040002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0040003")


	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_04_0040004")


	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_04_0040005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0040006")


	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_04_0040007")


	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_04_0040008")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0040009")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end
