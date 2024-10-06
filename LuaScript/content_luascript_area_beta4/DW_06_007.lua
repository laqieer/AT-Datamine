-- このluaスクリプトは、DW_06_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end

function Play()
	StartPlayActive()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0070001")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070002")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0070003")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0070005")

	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0070007")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070008")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070009")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070010")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0070012")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070013")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0070014")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070015")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_06_0070016")

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
