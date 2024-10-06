-- このluaスクリプトは、DW_01C_01_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Lioness","101033001","101033001","content_animationpack_101_101lyon","MotionPack_101Lyon","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0060001")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0060002")


	--★★リオネス★★:
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","DW_01C_01_0060003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0060004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0060005")


	--★★リオネス★★:
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","DW_01C_01_0060006")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0060007")

-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0060008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0060009")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0060010")

	change_face(Actor003,"Smile")

	--★★リオネス★★:
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","DW_01C_01_0060011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0060012")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0060013")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0060014")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Lioness","101033001","101033001","content_animationpack_101_101lyon","MotionPack_101Lyon","Com_Std01_Loop_f")
end