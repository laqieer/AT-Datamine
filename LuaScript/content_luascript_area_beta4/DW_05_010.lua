-- このluaスクリプトは、DW_05_010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Schoolboy_Cue","401005001","401005001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_05_0100001")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_05_0100002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0100003")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_05_0100004")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_05_0100005")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_05_0100006")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_05_0100007")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0100008")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_05_0100009")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor002,"NPCNAME_0383","speech","L","DW_05_0100010")

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
