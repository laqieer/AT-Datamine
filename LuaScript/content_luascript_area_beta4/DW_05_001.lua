-- このluaスクリプトは、DW_05_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_05_0010001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0010002")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_05_0010003")

	change_face(Actor002,"Anger")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_05_0010004")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_05_0010005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0010006")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_05_0010007")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_05_0010008")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_05_0010009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0010010")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_05_0010011")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_05_0010012")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end
