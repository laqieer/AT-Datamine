-- このluaスクリプトは、DW_01B_10_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0070002")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0070004")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070005")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070006")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0070007")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070008")

	change_face(Actor002,"Smile")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0070010")

-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0070012")

	change_face(Actor002,"Sad")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070013")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070014")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070015")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0070016")

-- ▼直接出力
PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_10_0070017")

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
end
