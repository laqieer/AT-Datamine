-- このluaスクリプトは、DW_01C_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Evelyn","401028001","401028001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0010001")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_10_0010002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0010003")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_10_0010004")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_10_0010005")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_10_0010006")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_10_0010007")


	--★★工房親方★★:
	Talk(Actor002,"NPCNAME_0083","speech","L","DW_01C_10_0010008")

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
