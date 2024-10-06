-- このluaスクリプトは、DW_01A_09_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Schoolboy_Cue","401005001","401005001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_01A_09_0070001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0070002")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_01A_09_0070003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0070004")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_01A_09_0070005")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_01A_09_0070006")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_01A_09_0070007")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_01A_09_0070008")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_01A_09_0070009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0070010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Schoolboy_Cue","401005001","401005001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end
