-- このluaスクリプトは、DW_07_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("クラリス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_07_0090001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0090002")

-- ▼直接出力
PlayPartVoice("クラリス", "笑い")
-- ▲直接出力

	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_07_0090003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0090004")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0090005")

	change_face(Actor002,"Normal")

	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_07_0090006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0090007")


	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_07_0090008")


	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_07_0090009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0090010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_07_0090011")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_f")
end
