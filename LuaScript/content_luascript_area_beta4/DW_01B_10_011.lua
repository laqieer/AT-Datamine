-- このluaスクリプトは、DW_01B_10_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01B_10_0110001")

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01B_10_0110002")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01B_10_0110003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定２")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0110004")

	change_face(Actor003,"Normal")

	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01B_10_0110005")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01B_10_0110006")

	change_face(Actor002,"Anger")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01B_10_0110007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0110008")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_01B_10_0110009")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end
