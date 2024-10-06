-- このluaスクリプトは、DW_01A_12_016.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Elaine","101030002","101030002","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01A_12_0160001")


	--★★エレイン★★:
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","DW_01A_12_0160002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0160003")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01A_12_0160004")


	--★★エレイン★★:
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","DW_01A_12_0160005")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01A_12_0160006")

-- ▼直接出力
PlayPartVoice("エレイン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","DW_01A_12_0160007")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01A_12_0160008")

-- ▼直接出力
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力

	--★★エレイン★★:
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","DW_01A_12_0160009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01A_12_0160010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Elaine","101030002","101030002","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
end
