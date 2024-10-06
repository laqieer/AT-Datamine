-- このluaスクリプトは、DW_08_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0020001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0020002")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_08_0020003")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_08_0020004")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_08_0020005")


	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_08_0020006")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0020007")

	change_face(Actor003,"Laugh")

	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_08_0020008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0020009")

-- ▼直接出力
PlayPartVoice("フレン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フレン★★:
	Talk(Actor003,"CHRNAME_FREN","speech","L","DW_08_0020010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Flen","101039001","101039001","content_animationpack_101_101flen","MotionPack_101Flen","Com_Std01_Loop_f")
end
