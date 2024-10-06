-- このluaスクリプトは、DW_01B_11_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_11_0050001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0050002")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_11_0050003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0050004")

	change_face(Actor002,"Normal")

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_11_0050005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0050006")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_11_0050007")

	change_face(Actor002,"Sad")

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01B_11_0050008")

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
