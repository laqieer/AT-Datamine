-- このluaスクリプトは、DW_01C_01_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Girflet","401029001","401029001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01C_01_0050001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0050002")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01C_01_0050003")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01C_01_0050004")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01C_01_0050005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0050006")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01C_01_0050007")


	--★★料理人★★:
	Talk(Actor002,"NPCNAME_0260","speech","L","DW_01C_01_0050008")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0050009")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Girflet","401029001","401029001","content_animationpack_100_100srim","MotionPack_100SriM","Com_Std01_Loop_m")
end
