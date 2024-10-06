-- このluaスクリプトは、DW_01B_09_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_09_0070001")

-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:
	Talk(Actor003,"CHRNAME_VIENA","speech","L","DW_01B_09_0070002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定２")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0070003")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_09_0070004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0070005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0070006")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0070007")


	--★★フィエナ★★:
	Talk(Actor003,"CHRNAME_VIENA","speech","L","DW_01B_09_0070008")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
end
