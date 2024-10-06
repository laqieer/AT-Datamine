-- このluaスクリプトは、DW_01B_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Dindrane","101027001","101027001","content_animationpack_101_101dind","MotionPack_101Dind","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_10_0020001")

-- ▼直接出力
PlayPartVoice("ディンドラン", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_10_0020002")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0020003")

	change_face(Actor003,"Normal")

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_10_0020004")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_10_0020005")


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_10_0020006")

-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_10_0020007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0020008")

	change_face(Actor002,"Normal")

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_10_0020009")


	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","DW_01B_10_0020010")

-- ▼直接出力
PlayPartVoice("ディンドラン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_10_0020011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0020012")

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
	InitializeActiveCharacter_Preload("Dindrane","101027001","101027001","content_animationpack_101_101dind","MotionPack_101Dind","Com_Std01_Loop_f")
end
