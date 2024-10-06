-- このluaスクリプトは、DW_01B_12_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0080001")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_12_0080002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0080003")

-- ▼直接出力
PlayPartVoice("エクセリア", "疑問")
-- ▲直接出力

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_12_0080004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0080005")

-- ▼直接出力
PlayPartVoice("エクセリア", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_12_0080006")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_12_0080007")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0080008")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_12_0080009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0080010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0080011")

	change_face(Actor002,"Sad")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_12_0080012")


	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01B_12_0080013")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0080014")

-- ▼直接出力
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01B_12_0080015")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0080016")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_12_0080017")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_12_0080018")

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
	InitializeActiveCharacter_Preload("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end
