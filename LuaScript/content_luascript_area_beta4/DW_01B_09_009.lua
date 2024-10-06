-- このluaスクリプトは、DW_01B_09_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0090001")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_09_0090002")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0090003")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_09_0090004")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0090005")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_09_0090006")


	--★★ヴォールス★★:
	Talk(Actor002,"CHRNAME_BORS","speech","L","DW_01B_09_0090007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0090008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0090009")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
end
