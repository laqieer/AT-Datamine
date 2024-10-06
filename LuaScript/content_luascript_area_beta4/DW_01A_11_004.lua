-- このluaスクリプトは、DW_01A_11_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_11_0040001")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_11_0040002")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_01A_11_0040003")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_11_0040004")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_01A_11_0040005")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_11_0040006")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_01A_11_0040007")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_11_0040008")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_11_0040009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01A_11_0040010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end
