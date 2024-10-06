-- このluaスクリプトは、DW_01A_09_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Girflet","401029001","401029001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01A_09_0040001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0040002")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01A_09_0040003")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01A_09_0040004")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01A_09_0040005")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01A_09_0040006")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01A_09_0040007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Girflet","401029001","401029001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end
