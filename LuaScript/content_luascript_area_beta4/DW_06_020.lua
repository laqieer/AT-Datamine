-- このluaスクリプトは、DW_06_020.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_06_0200001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200002")


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_06_0200003")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_06_0200004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200006")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_06_0200007")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_06_0200008")


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_06_0200009")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200012")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_06_0200013")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200014")


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_06_0200015")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200016")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0200017")

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
end
