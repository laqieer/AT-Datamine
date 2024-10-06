-- このluaスクリプトは、DW_01A_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ラシア★★:
	Talk(Actor002,"CHRNAME_RASIA","speech","L","DW_01A_09_0030001")


	--★★ラシア★★:
	Talk(Actor002,"CHRNAME_RASIA","speech","L","DW_01A_09_0030002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0030003")


	--★★ラシア★★:
	Talk(Actor002,"CHRNAME_RASIA","speech","L","DW_01A_09_0030004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0030005")

-- ▼直接出力
PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力

	--★★ラシア★★:
	Talk(Actor002,"CHRNAME_RASIA","speech","L","DW_01A_09_0030006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0030007")


	--★★ラシア★★:
	Talk(Actor002,"CHRNAME_RASIA","speech","L","DW_01A_09_0030008")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Std01_Loop_f")
end
