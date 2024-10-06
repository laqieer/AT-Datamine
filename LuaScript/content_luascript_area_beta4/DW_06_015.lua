-- このluaスクリプトは、DW_06_015.csvから自動生成されました --
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
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_06_0150001")


	--★★リオネス★★:
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","DW_06_0150002")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_06_0150003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0150004")

	change_face(Actor002,"Normal")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_06_0150005")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_06_0150006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0150007")

-- ▼直接出力
PlayPartVoice("リオネス", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","DW_06_0150008")

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
