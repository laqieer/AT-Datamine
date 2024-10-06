-- このluaスクリプトは、DW_01A_12_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0090001")

-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0090002")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0090003")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0090004")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0090005")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0090006")

	change_face(Actor002,"Normal")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0090007")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0090008")

-- ▼直接出力
PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0090009")

	change_face(Actor002,"Smile")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0090010")

-- ▼直接出力
PlayPartVoice("イゾルデ", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0090011")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end
