-- このluaスクリプトは、DW_01B_12_010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01B_12_0100001")

-- ▼直接出力
PlayPartVoice("トリスタン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01B_12_0100002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0100003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0100004")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01B_12_0100005")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01B_12_0100006")

-- ▼直接出力
PlayPartVoice("イゾルデ", "悩む")
-- ▲直接出力

	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01B_12_0100007")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01B_12_0100008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0100009")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end
