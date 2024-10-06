-- このluaスクリプトは、DW_01C_01_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gerard","401027001","401027001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★酒場店主★★:
	Talk(Actor002,"NPCNAME_0085","speech","L","DW_01C_01_0120001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0120002")


	--★★酒場店主★★:
	Talk(Actor002,"NPCNAME_0085","speech","L","DW_01C_01_0120003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0120004")


	--★★酒場店主★★:
	Talk(Actor002,"NPCNAME_0085","speech","L","DW_01C_01_0120005")


	--★★酒場店主★★:
	Talk(Actor002,"NPCNAME_0085","speech","L","DW_01C_01_0120006")


	--★★酒場店主★★:
	Talk(Actor002,"NPCNAME_0085","speech","L","DW_01C_01_0120007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0120008")


	--★★酒場店主★★:
	Talk(Actor002,"NPCNAME_0085","speech","L","DW_01C_01_0120009")


	--★★酒場店主★★:
	Talk(Actor002,"NPCNAME_0085","speech","L","DW_01C_01_0120010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0120011")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gerard","401027001","401027001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end
