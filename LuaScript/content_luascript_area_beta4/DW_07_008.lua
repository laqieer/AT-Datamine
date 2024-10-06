-- このluaスクリプトは、DW_07_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_07_0080001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0080002")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_07_0080003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0080004")


	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_07_0080005")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_07_0080006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0080007")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_07_0080008")

-- ▼直接出力
PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor003,"CHRNAME_BORS","speech","L","DW_07_0080009")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_07_0080010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_07_0080011")

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
	InitializeActiveCharacter_Preload("Vors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
end
