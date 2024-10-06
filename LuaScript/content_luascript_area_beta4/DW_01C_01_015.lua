-- このluaスクリプトは、DW_01C_01_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Surprise")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_01_0150001")

	change_face(Actor002,"Normal")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_01_0150002")

	change_face(Actor002,"Surprise")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_01_0150003")

	change_face(Actor003,"Surprise")

	--★★ローラ★★:
	Talk(Actor003,"CHRNAME_LOLA","speech","L","DW_01C_01_0150004")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0150005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0150006")

-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_01_0150007")

	change_face(Actor003,"Sad")

	--★★ローラ★★:
	Talk(Actor003,"CHRNAME_LOLA","speech","L","DW_01C_01_0150008")

	change_face(Actor002,"Sad")

	--★★フレン★★:
	Talk(Actor002,"CHRNAME_FREN","speech","L","DW_01C_01_0150009")

	change_face(Actor003,"Anger")

	--★★ローラ★★:
	Talk(Actor003,"CHRNAME_LOLA","speech","L","DW_01C_01_0150010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0150011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0150012")

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
	InitializeActiveCharacter_Preload("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
end
