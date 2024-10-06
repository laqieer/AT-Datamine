-- このluaスクリプトは、DW_01A_12_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ラヴェイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210001")

-- ▼直接出力
PlayPartVoice("ギネマウア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_12_0210002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0210003")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210004")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210005")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_12_0210006")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210007")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210008")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210009")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_12_0210010")

	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210011")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210012")


	--★★ラヴェイン★★:
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0210013")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_12_0210014")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0210015")


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01A_12_0210016")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0210017")

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
	InitializeActiveCharacter_Preload("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end
