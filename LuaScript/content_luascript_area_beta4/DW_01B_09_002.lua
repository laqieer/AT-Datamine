-- このluaスクリプトは、DW_01B_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor001,"Smile")

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","DW_01B_09_0020001")


	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01B_09_0020002")

	change_face(Actor003,"Smile")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01B_09_0020003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor002,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0020004")

-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","DW_01B_09_0020005")

-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_01B_09_0020006")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor002,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0020007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end
