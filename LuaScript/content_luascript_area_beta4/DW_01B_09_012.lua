-- このluaスクリプトは、DW_01B_09_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0120001")

	change_face(Actor002,"Smile")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120002")

	change_face(Actor003,"Sad")

	--★★ガラハッド★★:
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DW_01B_09_0120003")

	change_face(Actor002,"Anger")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120004")


	--★★ガラハッド★★:
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DW_01B_09_0120005")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120006")

	change_face(Actor002,"Normal")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0120008")

-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガラハッド★★:
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DW_01B_09_0120009")


	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120010")


	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120011")

	change_face(Actor002,"Sad")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","mind","L","DW_01B_09_0120012")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0120013")

-- ▼直接出力
PlayPartVoice("フィエナ", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120014")

	change_face(Actor002,"Smile")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120015")

-- ▼直接出力
PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガラハッド★★:
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DW_01B_09_0120016")


	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_09_0120017")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0120018")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end
