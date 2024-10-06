-- このluaスクリプトは、DW_01A_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Larou","101061001","101061001","content_animationpack_101_101laro","MotionPack_101Laro","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01A_10_0020001")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","DW_01A_10_0020002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0020003")


	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01A_10_0020004")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "激怒")
-- ▲直接出力

	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","DW_01A_10_0020005")


	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01A_10_0020006")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力

	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","DW_01A_10_0020007")


	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01A_10_0020008")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","DW_01A_10_0020009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0020010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Larou","101061001","101061001","content_animationpack_101_101laro","MotionPack_101Laro","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end
