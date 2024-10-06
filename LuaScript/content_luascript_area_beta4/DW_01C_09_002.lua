-- このluaスクリプトは、DW_01C_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01C_09_0020001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0020002")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01C_09_0020003")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01C_09_0020004")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_09_0020005")

-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01C_09_0020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
end
