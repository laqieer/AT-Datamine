-- このluaスクリプトは、DW_01A_11_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Night_Schoolgirl01","401008001","401008001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_11_0020001")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0020002")


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_11_0020003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0020004")


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_11_0020005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0020006")


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_11_0020007")


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_11_0020008")


	--★★キャメロット騎士学術院（女）②★★:
	Talk(Actor002,"NPCNAME_0384","speech","L","DW_01A_11_0020009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0020010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Night_Schoolgirl01","401008001","401008001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end
