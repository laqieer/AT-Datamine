-- このluaスクリプトは、DW_01B_10_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_10_0080001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0080002")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_10_0080003")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_10_0080004")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_10_0080005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定２")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0080006")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_01B_10_0080007")

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
end
