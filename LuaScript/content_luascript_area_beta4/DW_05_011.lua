-- このluaスクリプトは、DW_05_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Blaise","101066001","101066001","content_animationpack_101_101blaz","MotionPack_101Blaz","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ブレイズ", "挨拶")
-- ▲直接出力

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_05_0110001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0110002")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_05_0110003")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_05_0110004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0110005")

-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_05_0110006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0110007")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_05_0110008")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_05_0110009")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","DW_05_0110010")

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
