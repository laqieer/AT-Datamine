-- このluaスクリプトは、DW_07_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_07_0110001")

-- ▼直接出力
PlayPartVoice("ローラ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_07_0110002")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_07_0110003")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0110004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0110005")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_07_0110006")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_07_0110007")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0110008")

-- ▼直接出力
PlayPartVoice("ローラ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_07_0110009")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_07_0110010")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_07_0110011")

	change_face(Actor003,"Sad")

	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_07_0110012")

	change_face(Actor002,"Smile")

	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_07_0110013")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_07_0110014")

-- ▼直接出力
PlayPartVoice("ローラ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_07_0110015")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0110016")

	change_face(Actor002,"Sad")

	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_07_0110017")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end
