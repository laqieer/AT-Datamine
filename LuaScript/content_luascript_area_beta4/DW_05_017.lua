-- このluaスクリプトは、DW_05_017.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Lioness","101033001","101033001","content_animationpack_101_101lyon","MotionPack_101Lyon","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_05_0170001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0170002")


	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_05_0170003")

	change_face(Actor003,"Anger")

	--★★リオネス★★:
	Talk(Actor003,"NPCNAME_0073","speech","L","DW_05_0170004")


	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_05_0170005")


	--★★リオネス★★:
	Talk(Actor003,"NPCNAME_0073","speech","L","DW_05_0170006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0170007")

	change_face(Actor002,"Sad")

	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_05_0170008")

-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_05_0170009")


	--★★リオネス★★:
	Talk(Actor003,"NPCNAME_0073","speech","L","DW_05_0170010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0170011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0170012")

	change_face(Actor002,"Normal")

	--★★ガレス★★:
	Talk(Actor002,"NPCNAME_0072","speech","L","DW_05_0170013")

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
