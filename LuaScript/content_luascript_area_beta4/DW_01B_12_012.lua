-- このluaスクリプトは、DW_01B_12_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Maril","101062001","101062001","content_animationpack_101_101mari","MotionPack_101Mari","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クリスティーナ★★:
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","DW_01B_12_0120001")

-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01B_12_0120002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0120003")

	change_face(Actor003,"Normal")

	--★★クリスティーナ★★:
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","DW_01B_12_0120004")

	change_face(Actor002,"Normal")

	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01B_12_0120005")

	change_face(Actor003,"Smile")

	--★★クリスティーナ★★:
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","DW_01B_12_0120006")


	--★★クリスティーナ★★:
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","DW_01B_12_0120007")


	--★★クリスティーナ★★:
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","DW_01B_12_0120008")

-- ▼直接出力
PlayPartVoice("マルイル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01B_12_0120009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0120010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Maril","101062001","101062001","content_animationpack_101_101mari","MotionPack_101Mari","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end
