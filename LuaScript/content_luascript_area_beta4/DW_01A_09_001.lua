-- このluaスクリプトは、DW_01A_09_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_09_0010001")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_09_0010002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0010003")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_09_0010004")

-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_09_0010005")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_09_0010006")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_09_0010007")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01A_09_0010008")

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
end
