-- このluaスクリプトは、DW_08_014.csvから自動生成されました --
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
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140001")

-- ▼直接出力
PlayPartVoice("クラリス", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","DW_08_0140002")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0140003")

-- ▼直接出力
PlayPartVoice("クラリス", "笑い")
-- ▲直接出力

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","DW_08_0140004")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_08_0140006")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0140008")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0140010")

	change_face(Actor003,"Surprise")

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","DW_08_0140011")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140012")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140013")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140014")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0140015")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0140016")

-- ▼直接出力
PlayPartVoice("クラリス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","DW_08_0140017")

-- ▼直接出力
PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140018")

	change_face(Actor003,"Sad")

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","DW_08_0140019")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_08_0140020")

	change_face(Actor003,"Surprise")

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","DW_08_0140021")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_08_0140022")

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
