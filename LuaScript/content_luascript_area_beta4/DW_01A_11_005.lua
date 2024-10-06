-- このluaスクリプトは、DW_01A_11_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01A_11_0050001")

-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_11_0050002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0050003")


	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01A_11_0050004")

	change_face(Actor003,"Sad")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_11_0050005")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_11_0050006")

-- ▼直接出力
PlayPartVoice("リリアーナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01A_11_0050007")


	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_11_0050008")

-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01A_11_0050009")


	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_11_0050010")

	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","DW_01A_11_0050011")

-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_11_0050012")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01A_11_0050013")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end
