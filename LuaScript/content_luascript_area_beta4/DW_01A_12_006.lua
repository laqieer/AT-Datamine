-- このluaスクリプトは、DW_01A_12_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0060001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0060002")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0060003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0060004")

	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0060005")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0060006")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0060007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0060008")


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0060009")


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0060010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0060011")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0060012")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end
