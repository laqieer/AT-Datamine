-- このluaスクリプトは、DW_01C_09_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01C_09_0060001")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0060002")

	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01C_09_0060003")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0060004")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01C_09_0060005")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0060006")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01C_09_0060007")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01C_09_0060008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0060009")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01C_09_0060010")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01C_09_0060011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0060012")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
end
