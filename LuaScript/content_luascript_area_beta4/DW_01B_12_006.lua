-- このluaスクリプトは、DW_01B_12_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_12_0060001")

-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_01B_12_0060002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0060003")

-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_01B_12_0060004")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_12_0060005")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_12_0060006")


	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_01B_12_0060007")


	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_01B_12_0060008")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0060009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0060010")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_12_0060011")

	change_face(Actor003,"Smile")

	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_01B_12_0060012")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0060013")

-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_12_0060014")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
end
