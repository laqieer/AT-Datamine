-- このluaスクリプトは、DW_01B_10_010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end

function Play()
	StartPlayActive()


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01B_10_0100001")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0100002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0100003")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01B_10_0100004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01B_10_0100005")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01B_10_0100006")


	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01B_10_0100007")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","DW_01B_10_0100008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0100009")

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
