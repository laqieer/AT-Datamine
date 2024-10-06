-- このluaスクリプトは、DW_01B_09_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Schoolboy01","401005001","401005001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Schoolboy02","401007001","401007001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0140001")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0151","speech","L","DW_01B_09_0140002")


	--★★キャメロット騎士学術院（男）②★★:
	Talk(Actor003,"NPCNAME_0153","speech","L","DW_01B_09_0140003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0140004")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Schoolboy01","401005001","401005001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Schoolboy02","401007001","401007001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end
