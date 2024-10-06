-- このluaスクリプトは、DW_08_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Astera","101029001","101029001","content_animationpack_101_101aste","MotionPack_101Aste","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Smile")

	--★★アステラ★★:
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","DW_08_0040001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0040002")


	--★★アステラ★★:
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","DW_08_0040003")

	change_face(Actor002,"Normal")

	--★★アステラ★★:
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","DW_08_0040004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0040005")


	--★★アステラ★★:
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","DW_08_0040006")


	--★★アステラ★★:
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","DW_08_0040007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0040008")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0040009")

	change_face(Actor002,"Smile")

	--★★アステラ★★:
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","DW_08_0040010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Astera","101029001","101029001","content_animationpack_101_101aste","MotionPack_101Aste","Com_Std01_Loop_f")
end
