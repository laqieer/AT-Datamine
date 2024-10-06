-- このluaスクリプトは、DW_01A_11_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Elaine","101030001","101030001","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_11_0110001")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","DW_01A_11_0110002")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_11_0110003")


	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","DW_01A_11_0110004")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0110005")

	change_face(Actor002,"Normal")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_11_0110006")

	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","DW_01A_11_0110007")

	change_face(Actor002,"Smile")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_11_0110008")

	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","DW_01A_11_0110009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0110010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Elaine","101030001","101030001","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end
