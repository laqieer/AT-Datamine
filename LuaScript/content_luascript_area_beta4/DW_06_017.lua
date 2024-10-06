-- このluaスクリプトは、DW_06_017.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Evelyn","401028001","401028001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Smile")

	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_06_0170001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0170002")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_06_0170003")

	change_face(Actor002,"Normal")

	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_06_0170004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0170005")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_06_0170006")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_06_0170007")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_06_0170008")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0170009")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Evelyn","401028001","401028001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end
