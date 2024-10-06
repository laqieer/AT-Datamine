-- このluaスクリプトは、DW_01A_12_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ラグネル", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0020001")

	change_face(Actor003,"Surprise")

	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0020002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0020003")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0020004")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0020005")

-- ▼直接出力
PlayPartVoice("リリアーナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0020006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0020007")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0020008")

-- ▼直接出力
PlayPartVoice("リリアーナ", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0020009")


	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0020010")

	change_face(Actor003,"Sad")

	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0020011")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0020012")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end
