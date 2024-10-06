-- このluaスクリプトは、DW_01A_12_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0040001")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0040002")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0040003")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0040004")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0040005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0040006")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0040007")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0040008")

-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01A_12_0040009")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0040010")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0040011")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0040012")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_01A_12_0040013")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end
