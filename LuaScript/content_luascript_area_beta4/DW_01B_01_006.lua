-- このluaスクリプトは、DW_01B_01_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Blaise","101066001","101066001","content_animationpack_101_101blaz","MotionPack_101Blaz","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0060001")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_01_0060002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0060003")

-- ▼直接出力
PlayPartVoice("ブレイズ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_01_0060004")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_01_0060005")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0060006")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_01_0060007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0060008")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_01_0060009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0060010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0060011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0060012")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0060013")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_01_0060014")

-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_01_0060015")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Blaise","101066001","101066001","content_animationpack_101_101blaz","MotionPack_101Blaz","Com_Std01_Loop_m")
end
