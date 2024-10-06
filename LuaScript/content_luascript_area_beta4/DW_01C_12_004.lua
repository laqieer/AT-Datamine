-- このluaスクリプトは、DW_01C_12_004.csvから自動生成されました --
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
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01C_12_0040001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0040002")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01C_12_0040003")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01C_12_0040004")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01C_12_0040005")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01C_12_0040006")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01C_12_0040007")

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
