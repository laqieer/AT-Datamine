-- このluaスクリプトは、DW_06_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Shy")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_06_0060001")

-- ▼直接出力
PlayPartVoice("イゾルデ", "否定")
-- ▲直接出力

	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_06_0060002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0060003")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_06_0060004")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_06_0060005")

	change_face(Actor002,"Sad")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_06_0060006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_06_0060007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_06_0060008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0060009")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_06_0060010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0060011")

-- ▼直接出力
PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_06_0060012")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_06_0060013")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_06_0060014")

	change_face(Actor002,"Normal")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_06_0060015")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_06_0060016")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_06_0060017")

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
	InitializeActiveCharacter_Preload("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end
