-- このluaスクリプトは、DW_01A_09_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_01A_09_0140001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0140002")


	--★★ラシア★★:
	Talk(Actor002,"CHRNAME_RASIA","speech","L","DW_01A_09_0140003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0140004")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_01A_09_0140005")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_01A_09_0140006")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_01A_09_0140007")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0140008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0140009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0140010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0140011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0140012")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_01A_09_0140013")

	change_face(Actor003,"Anger")

	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_01A_09_0140014")

	change_face(Actor002,"Sad")

	--★★ラシア★★:
	Talk(Actor002,"CHRNAME_RASIA","speech","L","DW_01A_09_0140015")

	change_face(Actor003,"Sad")

	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_01A_09_0140016")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_01A_09_0140017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0140018")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end
