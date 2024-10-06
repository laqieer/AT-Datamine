-- このluaスクリプトは、DW_08_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Astera","101029001","101029001","content_animationpack_101_101aste","MotionPack_101Aste","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0150001")

-- ▼直接出力
PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_08_0150002")

-- ▼直接出力
PlayPartVoice("アステラ", "挨拶")
-- ▲直接出力

	--★★アステラ★★:
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","DW_08_0150003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0150004")


	--★★アステラ★★:
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","DW_08_0150005")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0150006")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_08_0150007")

-- ▼直接出力
PlayPartVoice("アステラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アステラ★★:
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","DW_08_0150008")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_08_0150009")

	change_face(Actor003,"Normal")

	--★★アステラ★★:
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","DW_08_0150010")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_08_0150011")


	--★★アステラ★★:
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","DW_08_0150012")


	--★★アステラ★★:
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","DW_08_0150013")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_08_0150014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0150015")

-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_08_0150016")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_08_0150017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0150018")


	--★★アステラ★★:
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","DW_08_0150019")


	--★★ガラハッド★★:
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","DW_08_0150020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0150021")

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
	InitializeActiveCharacter_Preload("Astera","101029001","101029001","content_animationpack_101_101aste","MotionPack_101Aste","Com_Std01_Loop_f")
end
