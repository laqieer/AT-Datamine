-- このluaスクリプトは、DW_01A_10_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_10_0050001")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0050002")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_10_0050003")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_10_0050004")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_10_0050005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0050006")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_10_0050007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0050008")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_10_0050009")

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
