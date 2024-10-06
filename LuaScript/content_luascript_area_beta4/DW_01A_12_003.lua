-- このluaスクリプトは、DW_01A_12_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0030001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0030002")


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0030003")


	--★★エクセリア★★:
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","DW_01A_12_0030004")


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0030005")

-- ▼直接出力
PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力

	--★★エクセリア★★:
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","DW_01A_12_0030006")


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0030007")


	--★★エクセリア★★:
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","DW_01A_12_0030008")


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0030009")


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01A_12_0030010")

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
	InitializeActiveCharacter_Preload("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
end