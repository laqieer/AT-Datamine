-- このluaスクリプトは、DW_01C_11_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0060002")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060003")

	change_face(Actor002,"Normal")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0060005")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0060007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0060008")

	change_face(Actor002,"Surprise")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0060010")

	change_face(Actor002,"Normal")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060011")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060012")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060013")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0060014")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0060015")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060016")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0060017")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end
