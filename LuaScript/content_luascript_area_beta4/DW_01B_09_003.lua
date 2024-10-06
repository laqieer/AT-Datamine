-- このluaスクリプトは、DW_01B_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Blaise","101066001","101066001","content_animationpack_101_101blaz","MotionPack_101Blaz","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ブレイズ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_09_0030001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0030002")

-- ▼直接出力
PlayPartVoice("ブレイズ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_09_0030003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0030004")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_09_0030005")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_01B_09_0030006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0030007")

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
