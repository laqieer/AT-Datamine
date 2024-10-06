-- このluaスクリプトは、DW_01B_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_01B_10_0010001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0010002")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_01B_10_0010003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0010004")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_01B_10_0010005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0010006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0010007")


	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","DW_01B_10_0010008")

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