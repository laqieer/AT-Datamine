-- このluaスクリプトは、DW_01B_10_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Smile")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_10_0090001")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0090002")


	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_10_0090003")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_10_0090004")


	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_10_0090005")


	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_10_0090006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0090007")

-- ▼直接出力
PlayPartVoice("フィエナ", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:
	Talk(Actor002,"CHRNAME_VIENA","speech","L","DW_01B_10_0090008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01B_10_0090009")

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
end
