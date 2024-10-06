-- このluaスクリプトは、DW_01B_12_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_12_0090001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0090002")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_12_0090003")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_12_0090004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0090005")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_12_0090006")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_12_0090007")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_12_0090008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0090009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0090010")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_12_0090011")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end
