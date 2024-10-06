-- このluaスクリプトは、DW_01C_11_016.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0160001")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0160002")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0160003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0160004")

	change_face(Actor003,"Sad")

	--★★ラシア★★:
	Talk(Actor003,"CHRNAME_RASIA","speech","L","DW_01C_11_0160005")


	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0160006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0160007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0160008")


	--★★ラシア★★:
	Talk(Actor003,"CHRNAME_RASIA","speech","L","DW_01C_11_0160009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0160010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0160011")

	change_face(Actor003,"Smile")

	--★★ラシア★★:
	Talk(Actor003,"CHRNAME_RASIA","speech","L","DW_01C_11_0160012")

	change_face(Actor002,"Smile")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_11_0160013")


	--★★ラシア★★:
	Talk(Actor003,"CHRNAME_RASIA","speech","L","DW_01C_11_0160014")

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
	InitializeActiveCharacter_Preload("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Std01_Loop_f")
end
