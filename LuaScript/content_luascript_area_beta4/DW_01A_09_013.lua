-- このluaスクリプトは、DW_01A_09_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0130001")

	change_face(Actor002,"Smile")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0130003")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130004")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0130006")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130007")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130008")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130009")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130010")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130011")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130012")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130013")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130014")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0130015")

	change_face(Actor002,"Smile")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_09_0130016")

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
