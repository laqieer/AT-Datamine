-- このluaスクリプトは、DW_01A_12_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack__common","-","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0130001")

-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_12_0130002")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0130003")


	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0130004")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_12_0130005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0130006")


	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0130007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0130008")

-- ▼直接出力
PlayPartVoice("エクセリア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_12_0130009")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0130010")

-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0130011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0130012")


	--★★リリアーナ★★:
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DW_01A_12_0130013")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_12_0130014")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0130015")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0130016")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01A_12_0130017")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Excelia","101034001","101034001","content_animationpack__common","-","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end
