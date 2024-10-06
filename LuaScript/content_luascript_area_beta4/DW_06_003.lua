-- このluaスクリプトは、DW_06_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ギネマウア", "挨拶")
-- ▲直接出力

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_06_0030001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0030002")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_06_0030003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0030004")

-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_06_0030005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0030006")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_06_0030007")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_06_0030008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0030009")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_06_0030010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end
