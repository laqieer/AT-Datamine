-- このluaスクリプトは、DW_01A_10_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Elaine","101030001","101030001","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_10_0120001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0120002")

	change_face(Actor002,"Normal")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_10_0120003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0120004")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_10_0120005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0120006")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_10_0120007")

	change_face(Actor002,"Sad")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_10_0120008")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_10_0120009")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DW_01A_10_0120010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Elaine","101030001","101030001","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
end
