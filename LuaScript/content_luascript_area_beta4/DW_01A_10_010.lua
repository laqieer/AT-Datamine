-- このluaスクリプトは、DW_01A_10_010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lovein","101031001","101031001","content_animationpack_101_101love","MotionPack_101Love","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_10_0100001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0100002")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_10_0100003")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_10_0100004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0100005")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_10_0100006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0100007")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_10_0100008")

	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_10_0100009")


	--★★ラヴェイン★★:
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","DW_01A_10_0100010")

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
