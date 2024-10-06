-- このluaスクリプトは、DW_01A_12_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0150001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0150002")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0150003")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0150004")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0150005")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0150006")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0150007")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0150008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0150009")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_12_0150010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end
