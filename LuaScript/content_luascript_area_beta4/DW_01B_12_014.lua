-- このluaスクリプトは、DW_01B_12_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01B_12_0140001")


	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01B_12_0140002")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0140003")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01B_12_0140004")


	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01B_12_0140005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0140006")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01B_12_0140007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0140008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0140009")

-- ▼直接出力
PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01B_12_0140010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0140011")


	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01B_12_0140012")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01B_12_0140013")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_01B_12_0140014")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0140015")

	change_face(Actor003,"Smile")

	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01B_12_0140016")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end
