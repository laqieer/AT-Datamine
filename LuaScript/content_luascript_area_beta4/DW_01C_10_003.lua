-- このluaスクリプトは、DW_01C_10_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_10_0030001")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0030002")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_10_0030003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0030004")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_10_0030005")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_10_0030006")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_10_0030007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end
