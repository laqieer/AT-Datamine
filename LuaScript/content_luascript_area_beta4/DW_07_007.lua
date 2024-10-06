-- このluaスクリプトは、DW_07_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Dindrane","101027001","101027001","content_animationpack_101_101dind","MotionPack_101Dind","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_07_0070001")


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_07_0070002")


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_07_0070003")


	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_07_0070004")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_07_0070005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0070006")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_07_0070007")

-- ▼直接出力
PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_07_0070008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0070009")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","DW_07_0070010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_07_0070011")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Dindrane","101027001","101027001","content_animationpack_101_101dind","MotionPack_101Dind","Com_Std01_Loop_f")
end
