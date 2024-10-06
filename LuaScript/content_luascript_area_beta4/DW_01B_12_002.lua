-- このluaスクリプトは、DW_01B_12_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Night_Schoolboy01","401007001","401007001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★キャメロット騎士学術院（男）②★★:
	Talk(Actor002,"NPCNAME_0001","speech","L","DW_01B_12_0020001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0020002")

-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:
	Talk(Actor002,"NPCNAME_0001","speech","L","DW_01B_12_0020003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0020004")

-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:
	Talk(Actor002,"NPCNAME_0001","speech","L","DW_01B_12_0020005")


	--★★キャメロット騎士学術院（男）②★★:
	Talk(Actor002,"NPCNAME_0001","speech","L","DW_01B_12_0020006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0020007")


	--★★キャメロット騎士学術院（男）②★★:
	Talk(Actor002,"NPCNAME_0001","speech","L","DW_01B_12_0020008")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0020009")


	--★★キャメロット騎士学術院（男）②★★:
	Talk(Actor002,"NPCNAME_0001","speech","L","DW_01B_12_0020010")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0020011")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Night_Schoolboy01","401007001","401007001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end
