-- このluaスクリプトは、DW_01B_10_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Night_Schoolgirl02","401006001","401006001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0002","speech","L","DW_01B_10_0040001")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0040002")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0002","speech","L","DW_01B_10_0040003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0040004")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0002","speech","L","DW_01B_10_0040005")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0002","speech","L","DW_01B_10_0040006")


	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0002","speech","L","DW_01B_10_0040007")

-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:
	Talk(Actor002,"NPCNAME_0002","speech","L","DW_01B_10_0040008")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0040009")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0040010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Night_Schoolgirl02","401006001","401006001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end
