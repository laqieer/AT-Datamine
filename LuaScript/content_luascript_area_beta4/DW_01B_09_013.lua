-- このluaスクリプトは、DW_01B_09_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("キッス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0130002")

	change_face(Actor002,"Normal")

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130003")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130004")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0130005")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130006")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0130008")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0130010")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130011")

	change_face(Actor002,"Normal")

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130012")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_09_0130013")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0130014")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end
