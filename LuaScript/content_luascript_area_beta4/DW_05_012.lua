-- このluaスクリプトは、DW_05_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0120001")

-- ▼直接出力
PlayPartVoice("ギネマウア", "挨拶")
-- ▲直接出力

	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0120002")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0120003")


	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0120004")


	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0120005")


	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0120006")


	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0120007")


	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0120008")


	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0120009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0120010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end
