-- このluaスクリプトは、DW_01A_09_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01A_09_0120001")

-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_09_0120002")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_09_0120003")

	change_face(Actor003,"Surprise")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_09_0120004")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_09_0120005")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01A_09_0120006")


	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_09_0120007")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01A_09_0120008")

-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01A_09_0120009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01A_09_0120010")

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
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end
