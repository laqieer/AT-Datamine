-- このluaスクリプトは、DW_01A_12_018.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Schoolgirl_Samba","401008001","401008001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Schoolboy_Cue","401005001","401005001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor003,"NPCNAME_0383","speech","L","DW_01A_12_0180001")


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_12_0180002")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0180003")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor003,"NPCNAME_0383","speech","L","DW_01A_12_0180004")


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_12_0180005")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor003,"NPCNAME_0383","speech","L","DW_01A_12_0180006")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor003,"NPCNAME_0383","speech","L","DW_01A_12_0180007")


	--★★キャメロット騎士学術院（男）★★:
	Talk(Actor003,"NPCNAME_0383","speech","L","DW_01A_12_0180008")


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_12_0180009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01A_12_0180010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Schoolgirl_Samba","401008001","401008001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Schoolboy_Cue","401005001","401005001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end
