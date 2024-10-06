-- このluaスクリプトは、DW_01C_11_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("キッス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01C_11_0040001")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01C_11_0040002")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0040003")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01C_11_0040004")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0040005")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01C_11_0040006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0040007")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01C_11_0040008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0040009")


	--★★キッス★★:
	Talk(Actor002,"CHRNAME_KISS","speech","L","DW_01C_11_0040010")

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
