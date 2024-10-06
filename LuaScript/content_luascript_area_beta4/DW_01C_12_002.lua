-- このluaスクリプトは、DW_01C_12_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_12_0020001")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_12_0020002")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_12_0020003")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0020004")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_12_0020005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0020006")

	change_face(Actor002,"Anger")

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_12_0020007")

	change_face(Actor003,"Smile")

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","DW_01C_12_0020008")

-- ▼直接出力
PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_12_0020009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0020010")

-- ▼直接出力
PlayPartVoice("クラリス", "笑い")
-- ▲直接出力

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","DW_01C_12_0020011")

	change_face(Actor002,"Smile")

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_12_0020012")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_f")
end
