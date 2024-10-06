-- このluaスクリプトは、DW_01A_01_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ギネマウア", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_01_0030001")


	--★★ギネマウア★★:
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_01_0030002")


	--★★ギネマウア★★:
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_01_0030003")


	--★★ギネマウア★★:
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_01_0030004")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end
