-- このluaスクリプトは、DW_01C_11_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("クラリス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_01C_11_0120001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0120002")


	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_01C_11_0120003")


	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_01C_11_0120004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0120005")


	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_01C_11_0120006")

	change_face(Actor002,"Normal")

	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_01C_11_0120007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0120008")


	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_01C_11_0120009")


	--★★クラリス★★:
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DW_01C_11_0120010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_f")
end
