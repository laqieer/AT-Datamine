-- このluaスクリプトは、DW_01A_09_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150001")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0150002")

	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0150004")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0150006")

	change_face(Actor002,"Serious")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150007")

	change_face(Actor001,"Serious")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0150008")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150009")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150010")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0150011")

	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0150013")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150014")

	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_09_0150015")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_09_0150016")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
end
