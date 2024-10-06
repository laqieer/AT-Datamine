-- このluaスクリプトは、DW_08_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_08_0070001")


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_08_0070002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0070003")


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_08_0070004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0070005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0070006")


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_08_0070007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0070008")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_08_0070009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0070010")

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
