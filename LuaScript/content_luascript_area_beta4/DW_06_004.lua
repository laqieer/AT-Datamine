-- このluaスクリプトは、DW_06_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Lioness","101033001","101033001","content_animationpack_101_101lyon","MotionPack_101Lyon","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Surprise")

	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_06_0040001")


	--★★リオネス★★:
	Talk(Actor003,"NPCNAME_0073","speech","L","DW_06_0040002")

-- ▼直接出力
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_06_0040003")


	--★★リオネス★★:
	Talk(Actor003,"NPCNAME_0073","speech","L","DW_06_0040004")


	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_06_0040005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0040006")

	change_face(Actor002,"Normal")

	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_06_0040007")


	--★★リオネス★★:
	Talk(Actor003,"NPCNAME_0073","speech","L","DW_06_0040008")


	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_06_0040009")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0040010")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_06_0040011")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Lioness","101033001","101033001","content_animationpack_101_101lyon","MotionPack_101Lyon","Com_Std01_Loop_f")
end
