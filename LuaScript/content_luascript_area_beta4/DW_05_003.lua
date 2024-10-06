-- このluaスクリプトは、DW_05_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力

	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_05_0030001")

-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_05_0030002")


	--★★イゾルデ★★:
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","DW_05_0030003")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_05_0030004")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0030005")

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
