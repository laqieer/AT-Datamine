-- このluaスクリプトは、DW_01A_11_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Elaine","101030001","101030001","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_11_0090001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0090002")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_11_0090003")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_11_0090004")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_11_0090005")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_11_0090006")

	change_face(Actor002,"Normal")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_11_0090007")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_11_0090008")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_11_0090009")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0090010")

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
	InitializeActiveCharacter_Preload("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end
