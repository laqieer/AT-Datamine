-- このluaスクリプトは、DW_01C_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Evelyn","401028001","401028001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ヴォールス", "驚き")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_01C_09_0030001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0030002")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_09_0030003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0030004")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_09_0030005")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_09_0030006")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_09_0030007")

	change_face(Actor003,"Sad")

	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_01C_09_0030008")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_09_0030009")

	change_face(Actor003,"Normal")

	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_01C_09_0030010")

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
	InitializeActiveCharacter_Preload("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
end
