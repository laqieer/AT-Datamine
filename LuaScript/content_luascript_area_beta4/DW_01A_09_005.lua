-- このluaスクリプトは、DW_01A_09_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0050001")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0050002")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0050003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0050004")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0050005")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0050006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0050007")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0050008")

	change_face(Actor002,"Surprise")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0050009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0050010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end
