-- このluaスクリプトは、ND_01111_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Schoolgirl","401006001","401006001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0385","speech","L","ND_01111_010001")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0385","speech","L","ND_01111_010002")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0385","speech","L","ND_01111_010003")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0385","speech","L","ND_01111_010004")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0385","speech","L","ND_01111_010005")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0385","speech","L","ND_01111_010006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_01111_010007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Schoolgirl","401006001","401006001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end
